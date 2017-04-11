using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DictCN
{
	public partial class MainWindow : Form
	{
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

		void opacityChange(object sender, EventArgs e)
		{
			var tag = (string)((ToolStripMenuItem)sender).Tag;
			int opacity;
			if (int.TryParse(tag, out opacity))
				this.Opacity = opacity / 100.0;
		}

		[DllImport("user32.dll", SetLastError = true)]
		static extern bool AddClipboardFormatListener(IntPtr hwnd);

		void MainWindow_Load(object sender, EventArgs e)
		{
			if (!AddClipboardFormatListener(this.Handle))
			{
				MessageBox.Show(Marshal.GetLastWin32Error().ToString(), "Error", MessageBoxButtons.OK);
				this.Close();
				return;
			}

			_dictCN = new DictCN(Found);
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

		void Found(string text)
		{
			if (this.InvokeRequired)
				this.Invoke(new Action<string>(Found), text);
			else
			{
				this.result.Text = text;
				this.Size = this.result.Size;
			}
		}
	}
}
