namespace BloxSense_v1
{
	// Token: 0x02000004 RID: 4
	public partial class Form3 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00005944 File Offset: 0x00005944
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000597C File Offset: 0x0000597C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.richTextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.richTextBox1.ForeColor = global::System.Drawing.Color.Aqua;
			this.richTextBox1.Location = new global::System.Drawing.Point(0, 24);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(844, 369);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox1.WordWrap = false;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.button1.ForeColor = global::System.Drawing.Color.Red;
			this.button1.Location = new global::System.Drawing.Point(0, 399);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(164, 75);
			this.button1.TabIndex = 1;
			this.button1.Text = "Execute";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.button2.ForeColor = global::System.Drawing.Color.Orange;
			this.button2.Location = new global::System.Drawing.Point(170, 399);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(164, 75);
			this.button2.TabIndex = 2;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.button3.ForeColor = global::System.Drawing.Color.Yellow;
			this.button3.Location = new global::System.Drawing.Point(340, 399);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(164, 75);
			this.button3.TabIndex = 3;
			this.button3.Text = "Open Script";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.button4.ForeColor = global::System.Drawing.Color.Green;
			this.button4.Location = new global::System.Drawing.Point(510, 399);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(164, 75);
			this.button4.TabIndex = 4;
			this.button4.Text = "Save Script";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.button5.ForeColor = global::System.Drawing.Color.Blue;
			this.button5.Location = new global::System.Drawing.Point(680, 399);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(164, 75);
			this.button5.TabIndex = 5;
			this.button5.Text = "Get Script from pastebin";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			base.ClientSize = new global::System.Drawing.Size(846, 486);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.richTextBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form3";
			this.Text = "Form3";
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
			base.ResumeLayout(false);
		}

		// Token: 0x0400003E RID: 62
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Timer timer1;
	}
}
