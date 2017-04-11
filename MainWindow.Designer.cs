namespace DictCN
{
	partial class MainWindow
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStripSeparator sep0;
			System.Windows.Forms.ToolStripMenuItem op100;
			System.Windows.Forms.ToolStripMenuItem op90;
			System.Windows.Forms.ToolStripMenuItem op80;
			System.Windows.Forms.ToolStripMenuItem op70;
			System.Windows.Forms.ToolStripMenuItem op60;
			System.Windows.Forms.ToolStripMenuItem op50;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuOpacity = new System.Windows.Forms.ToolStripMenuItem();
			this.menuShowHide = new System.Windows.Forms.ToolStripMenuItem();
			this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.result = new System.Windows.Forms.Label();
			sep0 = new System.Windows.Forms.ToolStripSeparator();
			op100 = new System.Windows.Forms.ToolStripMenuItem();
			op90 = new System.Windows.Forms.ToolStripMenuItem();
			op80 = new System.Windows.Forms.ToolStripMenuItem();
			op70 = new System.Windows.Forms.ToolStripMenuItem();
			op60 = new System.Windows.Forms.ToolStripMenuItem();
			op50 = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIconMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// sep0
			// 
			sep0.Name = "sep0";
			sep0.Size = new System.Drawing.Size(92, 6);
			// 
			// op100
			// 
			op100.Name = "op100";
			op100.Size = new System.Drawing.Size(108, 22);
			op100.Tag = "100";
			op100.Text = "100%";
			op100.Click += new System.EventHandler(this.opacityChange);
			// 
			// op90
			// 
			op90.Name = "op90";
			op90.Size = new System.Drawing.Size(108, 22);
			op90.Tag = "90";
			op90.Text = "90%";
			op90.Click += new System.EventHandler(this.opacityChange);
			// 
			// op80
			// 
			op80.Name = "op80";
			op80.Size = new System.Drawing.Size(108, 22);
			op80.Tag = "80";
			op80.Text = "80%";
			op80.Click += new System.EventHandler(this.opacityChange);
			// 
			// op70
			// 
			op70.Name = "op70";
			op70.Size = new System.Drawing.Size(108, 22);
			op70.Tag = "70";
			op70.Text = "70%";
			op70.Click += new System.EventHandler(this.opacityChange);
			// 
			// op60
			// 
			op60.Name = "op60";
			op60.Size = new System.Drawing.Size(108, 22);
			op60.Tag = "60";
			op60.Text = "60%";
			op60.Click += new System.EventHandler(this.opacityChange);
			// 
			// op50
			// 
			op50.Name = "op50";
			op50.Size = new System.Drawing.Size(108, 22);
			op50.Tag = "50";
			op50.Text = "50%";
			op50.Click += new System.EventHandler(this.opacityChange);
			// 
			// mainNotifyIcon
			// 
			this.mainNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.mainNotifyIcon.BalloonTipText = "AAA";
			this.mainNotifyIcon.BalloonTipTitle = "BBB";
			this.mainNotifyIcon.ContextMenuStrip = this.notifyIconMenu;
			this.mainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotifyIcon.Icon")));
			this.mainNotifyIcon.Text = "Dict.CN";
			this.mainNotifyIcon.Visible = true;
			// 
			// notifyIconMenu
			// 
			this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpacity,
            sep0,
            this.menuShowHide,
            this.menuQuit});
			this.notifyIconMenu.Name = "notifyIconMenu";
			this.notifyIconMenu.ShowImageMargin = false;
			this.notifyIconMenu.Size = new System.Drawing.Size(96, 76);
			// 
			// menuOpacity
			// 
			this.menuOpacity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            op100,
            op90,
            op80,
            op70,
            op60,
            op50});
			this.menuOpacity.Name = "menuOpacity";
			this.menuOpacity.Size = new System.Drawing.Size(95, 22);
			this.menuOpacity.Text = "Opacity";
			// 
			// menuShowHide
			// 
			this.menuShowHide.Name = "menuShowHide";
			this.menuShowHide.Size = new System.Drawing.Size(95, 22);
			this.menuShowHide.Text = "Hide";
			this.menuShowHide.Click += new System.EventHandler(this.menuShowHide_Click);
			// 
			// menuQuit
			// 
			this.menuQuit.Name = "menuQuit";
			this.menuQuit.Size = new System.Drawing.Size(95, 22);
			this.menuQuit.Text = "Quit";
			this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(0, 0);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(47, 12);
			this.result.TabIndex = 2;
			this.result.Text = "Dict.CN";
			this.result.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
			this.result.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(100, 20);
			this.ContextMenuStrip = this.notifyIconMenu;
			this.ControlBox = false;
			this.Controls.Add(this.result);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(100, 20);
			this.Name = "MainWindow";
			this.Opacity = 0.9D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Dict.CN";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
			this.notifyIconMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon mainNotifyIcon;
		private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
		private System.Windows.Forms.ToolStripMenuItem menuQuit;
		private System.Windows.Forms.ToolStripMenuItem menuShowHide;
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.ToolStripMenuItem menuOpacity;
	}
}

