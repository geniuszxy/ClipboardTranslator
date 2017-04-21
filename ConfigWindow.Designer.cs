namespace ClipboardTranslator
{
	partial class ConfigWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.lblOpacityValue = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(24, 13);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(47, 12);
			label1.TabIndex = 3;
			label1.Text = "Opacity";
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.LargeChange = 1;
			this.hScrollBar1.Location = new System.Drawing.Point(93, 9);
			this.hScrollBar1.Minimum = 50;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(125, 18);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.Value = 90;
			this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(36, 38);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(35, 12);
			label2.TabIndex = 3;
			label2.Text = "Color";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(12, 63);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(59, 12);
			label3.TabIndex = 3;
			label3.Text = "Auto hide";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(159, 63);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(47, 12);
			label4.TabIndex = 3;
			label4.Text = "seconds";
			// 
			// lblOpacityValue
			// 
			this.lblOpacityValue.Location = new System.Drawing.Point(221, 13);
			this.lblOpacityValue.Name = "lblOpacityValue";
			this.lblOpacityValue.Size = new System.Drawing.Size(36, 12);
			this.lblOpacityValue.TabIndex = 2;
			this.lblOpacityValue.Text = "90%";
			this.lblOpacityValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(103, 101);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(184, 101);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Red;
			this.pictureBox1.Location = new System.Drawing.Point(93, 35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 16);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(93, 58);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(60, 21);
			this.numericUpDown1.TabIndex = 5;
			this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// ConfigWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 134);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(label4);
			this.Controls.Add(this.lblOpacityValue);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.hScrollBar1);
			this.Controls.Add(this.button1);
			this.Controls.Add(label1);
			this.Controls.Add(label2);
			this.Controls.Add(label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfigWindow";
			this.ShowIcon = false;
			this.Text = "Configure";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigWindow_FormClosed);
			this.Load += new System.EventHandler(this.ConfigWindow_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblOpacityValue;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
	}
}