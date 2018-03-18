using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace ClipboardTranslator
{
	public partial class MainWindow : Form
	{
		Timer _autoHideTimer;
		Size _dragOffset;
		DictCN _dictCN;

		public MainWindow()
		{
			InitializeComponent();
		}

		void menuQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void menuShowHide_Click(object sender, EventArgs e)
		{
			var v = this.Visible;
			this.Visible = !v;
			((ToolStripMenuItem)sender).Text = v ? "Show" : "Hide";
		}

		void MainWindow_MouseDown(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
				case MouseButtons.Left:
					this.MouseMove += _DragWindow;
					result.MouseMove += _DragWindow;
					_dragOffset = (Size)e.Location;
					break;
			}
		}

		void MainWindow_MouseUp(object sender, MouseEventArgs e)
		{
			switch (e.Button)
			{
				case MouseButtons.Left:
					this.MouseMove -= _DragWindow;
					result.MouseMove -= _DragWindow;
					break;
			}
		}

		void _DragWindow(object sender, MouseEventArgs e)
		{
			var p = this.Location + (Size)(e.Location - _dragOffset);
			if (p.Y < 0)
				p.Y = 0;
			this.Location = p;
		}

		[DllImport("user32.dll", SetLastError = true)]
		static extern bool AddClipboardFormatListener(IntPtr hwnd);

		void MainWindow_Load(object sender, EventArgs e)
		{
			var config = Config.Load();
			this.Location = config.StartPosition;
			ApplyConfig();

			if (!AddClipboardFormatListener(this.Handle))
			{
				MessageBox.Show(Marshal.GetLastWin32Error().ToString(), "Error", MessageBoxButtons.OK);
				this.Close();
				return;
			}

			_dictCN = new DictCN(Found);

			//隐藏
			this.Hide();
		}

		void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			Config.Load().StartPosition = this.Location;
		}

		protected override void WndProc(ref Message m)
		{
			const int WM_CLIPBOARDUPDATE = 0x031D;

			switch (m.Msg)
			{
				case WM_CLIPBOARDUPDATE:
					if (Clipboard.ContainsText())
					{
						var text = Clipboard.GetText();
						if (text.Length > 64)
							return;
						foreach (var c in text)
						{
							if (c >= 'A' && c <= 'Z')
								continue;
							if (c >= 'a' && c <= 'z')
								continue;
							if (c == ' ')
								continue;
							return;
						}
						this._dictCN.Find(text);
					}
					break;
				default:
					base.WndProc(ref m);
					break;
			}
		}

		protected override CreateParams CreateParams
		{
			get
			{
				//Hide from ALT+TAB
				var cp = base.CreateParams;
				cp.ExStyle |= 0x80; //WS_EX_TOOLWINDOW
				return cp;
			}
		}

		void Found(string text)
		{
			if (this.InvokeRequired)
				this.Invoke(new Action<string>(Found), text);
			else
			{
				this.result.Text = text;
				this.Size = this.result.Size;
				StartAutoHide();
			}
		}

		void onOpenConfig(object sender, EventArgs e)
		{
			if (new ConfigWindow().ShowDialog(this) != DialogResult.OK)
				return;
			ApplyConfig();
		}

		void ApplyConfig()
		{
			var config = Config.Load();
			this.BackColor = config.BackgroundColor;
			this.Opacity = config.Opacity / 100.0;
		}

		void StartAutoHide()
		{
			var config = Config.Load();
			this.Show();
			this.Opacity = config.Opacity / 100.0;
			var delay = config.AutoHideDelay;
			if (delay == 0) //不隐藏
				return;

			//如果当前已经在隐藏了，则重新开始
			if (_autoHideTimer != null)
			{
				_autoHideTimer.Change(delay, 30);
				return;
			}

			//创建Timer
			_autoHideTimer = new System.Threading.Timer((state) =>
			{
				var opacity = this.Opacity - 0.1;
				if (opacity <= 0)
				{
					_autoHideTimer.Dispose();
					_autoHideTimer = null;
					this.Hide();
				}
				else
					this.Opacity = opacity;
			},
			null, delay, 30);
		}
	}
}
