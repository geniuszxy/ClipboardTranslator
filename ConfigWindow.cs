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
