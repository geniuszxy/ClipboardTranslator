using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClipboardTranslator
{
	public partial class ConfigWindow : Form
	{
		public ConfigWindow()
		{
			InitializeComponent();
		}

		private void ConfigWindow_Load(object sender, EventArgs e)
		{
			var config = Config.Load();
			this.hScrollBar1.Value = config.Opacity;
			this.pictureBox1.BackColor = config.BackgroundColor;
			this.numericUpDown1.Value = config.AutoHideDelay / 1000m;
		}

		private void ConfigWindow_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.DialogResult != DialogResult.OK)
				return;
			
			var config = Config.Load();
			config.Opacity = this.hScrollBar1.Value;
			config.BackgroundColor = this.pictureBox1.BackColor;
			config.AutoHideDelay = (int)(this.numericUpDown1.Value * 1000m);
			Config.Save();
		}

		private void hScrollBar1_ValueChanged(object sender, EventArgs e)
		{
			lblOpacityValue.Text = ((HScrollBar)sender).Value + "%";
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog(this);
			((Control)sender).BackColor = colorDialog1.Color;
		}
	}
}
