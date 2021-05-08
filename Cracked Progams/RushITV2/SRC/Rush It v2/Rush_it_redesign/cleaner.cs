using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Guna.UI2.WinForms;

namespace Rush_it_redesign
{
	// Token: 0x02000006 RID: 6
	public class cleaner : UserControl
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003228 File Offset: 0x00001428
		public static cleaner Instance
		{
			get
			{
				bool flag = cleaner._instance == null;
				if (flag)
				{
					cleaner._instance = new cleaner();
				}
				return cleaner._instance;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003258 File Offset: 0x00001458
		public cleaner()
		{
			this.InitializeComponent();
			this.bunifuCheckbox1.Checked = false;
			this.bunifuCheckbox2.Checked = false;
			this.bunifuCheckbox3.Checked = false;
			this.bunifuCheckbox4.Checked = false;
			this.bunifuCheckbox5.Checked = false;
			this.bunifuCheckbox6.Checked = false;
			this.bunifuCheckbox7.Checked = false;
			this.bunifuCheckbox8.Checked = false;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002057 File Offset: 0x00000257
		private void cleaner_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox7_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox8_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox5_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox6_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000032E4 File Offset: 0x000014E4
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Process process = new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe",
					Arguments = "int tcp reset"
				}
			};
			bool @checked = this.bunifuCheckbox7.Checked;
			if (@checked)
			{
				process.StartInfo.Arguments = "del /s /f /q c:\\windows\\temp\\*.*";
				process.StartInfo.Arguments = "rd /s /q c:\\windows\\temp";
				process.StartInfo.Arguments = "md c:\\windows\\temp";
				process.StartInfo.Arguments = "del /s /f /q %temp%\\*.*";
				process.StartInfo.Arguments = "rd /s /q %temp%";
				process.StartInfo.Arguments = "md %temp%";
				process.StartInfo.Arguments = "deltree /y c:\\windows\\tempor~1";
				process.StartInfo.Arguments = "deltree /y c:\\windows\\temp";
				process.StartInfo.Arguments = "deltree /y c:\\windows\\tmp";
				process.StartInfo.Arguments = "deltree /y c:\\windows\\ff*.tmp";
			}
			bool checked2 = this.bunifuCheckbox3.Checked;
			if (checked2)
			{
				process.StartInfo.Arguments = "deltree /y c:\\windows\\cookies";
			}
			bool checked3 = this.bunifuCheckbox2.Checked;
			if (checked3)
			{
				process.StartInfo.Arguments = "del /s /f /q C:\\WINDOWS\\Prefetch";
			}
			bool checked4 = this.bunifuCheckbox1.Checked;
			if (checked4)
			{
				process.StartInfo.Arguments = "deltree /y c:\\windows\\recent";
				process.StartInfo.Arguments = "deltree /y c:\\windows\\spool\\printers";
				process.StartInfo.Arguments = "del c:\\WIN386.SWP";
			}
			bool checked5 = this.bunifuCheckbox8.Checked;
			if (checked5)
			{
				process.StartInfo.Arguments = "dir /s %ProgramFiles%\\Steam\\*.log";
				process.StartInfo.Arguments = "dir /s %ProgramFiles%\\Steam\\*log.last";
				process.StartInfo.Arguments = "dir %ProgramFiles%\\Steam\\.crash";
				process.StartInfo.Arguments = "dir %ProgramFiles%\\Steam\\Steam.log";
				process.StartInfo.Arguments = "dir /s %ProgramFiles%\\Steam\\*_log.txt";
				process.StartInfo.Arguments = "dir /s %ProgramFiles(x86)%\\Steam\\*.log";
				process.StartInfo.Arguments = "dir /s %ProgramFiles(x86)%\\Steam\\*log.last";
				process.StartInfo.Arguments = "dir %ProgramFiles(x86)%\\Steam\\.crash";
				process.StartInfo.Arguments = "dir %ProgramFile(x86)s%\\Steam\\Steam.log";
				process.StartInfo.Arguments = "dir /s %ProgramFiles(x86)%\\Steam\\*_log.txt";
			}
			bool checked6 = this.bunifuCheckbox4.Checked;
			if (checked6)
			{
				process.StartInfo.Arguments = "RD /S /Q C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportArchive";
				process.StartInfo.Arguments = "RD /S /Q C:\\ProgramData\\Microsoft\\Windows\\WER\\ReportQueue";
				process.StartInfo.Arguments = "RD /S /Q C:\\ProgramData\\Microsoft\\Windows\\WER\\Temp";
			}
			bool checked7 = this.bunifuCheckbox6.Checked;
			if (checked7)
			{
				process.StartInfo.Arguments = "RD /S /Q C:\\Windows\\SoftwareDistribution\\Download";
			}
			bool checked8 = this.bunifuCheckbox5.Checked;
			if (checked8)
			{
				process.StartInfo.Arguments = "RD /S /Q C:\\Windows\\SoftwareDistribution\\Download";
			}
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			MessageBox.Show("Systeme nettoyé", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000035D8 File Offset: 0x000017D8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003610 File Offset: 0x00001810
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(cleaner));
			this.label3 = new Label();
			this.bunifuCheckbox4 = new BunifuCheckbox();
			this.label5 = new Label();
			this.bunifuCheckbox5 = new BunifuCheckbox();
			this.label6 = new Label();
			this.bunifuCheckbox6 = new BunifuCheckbox();
			this.label2 = new Label();
			this.label1 = new Label();
			this.bunifuCheckbox2 = new BunifuCheckbox();
			this.label4 = new Label();
			this.bunifuCheckbox1 = new BunifuCheckbox();
			this.bunifuCheckbox3 = new BunifuCheckbox();
			this.bunifuCheckbox7 = new BunifuCheckbox();
			this.bunifuCheckbox8 = new BunifuCheckbox();
			this.label7 = new Label();
			this.label8 = new Label();
			Guna2Button guna2Button = new Guna2Button();
			base.SuspendLayout();
			guna2Button.BorderRadius = 22;
			guna2Button.CheckedState.Parent = guna2Button;
			guna2Button.CustomImages.Parent = guna2Button;
			guna2Button.FillColor = Color.White;
			guna2Button.Font = new Font("Segoe UI", 15f);
			guna2Button.ForeColor = Color.FromArgb(40, 42, 60);
			guna2Button.HoverState.Parent = guna2Button;
			guna2Button.Image = (Image)componentResourceManager.GetObject("guna2Button2.Image");
			guna2Button.ImageAlign = HorizontalAlignment.Left;
			guna2Button.ImageSize = new Size(40, 40);
			guna2Button.Location = new Point(219, 314);
			guna2Button.Name = "guna2Button2";
			guna2Button.ShadowDecoration.Parent = guna2Button;
			guna2Button.Size = new Size(184, 61);
			guna2Button.TabIndex = 37;
			guna2Button.Text = "Clean";
			guna2Button.Click += this.guna2Button2_Click;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Microsoft Sans Serif", 11f);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(382, 164);
			this.label3.Name = "label3";
			this.label3.Size = new Size(93, 18);
			this.label3.TabIndex = 49;
			this.label3.Text = "Report WER";
			this.bunifuCheckbox4.BackColor = Color.White;
			this.bunifuCheckbox4.ChechedOffColor = Color.White;
			this.bunifuCheckbox4.Checked = true;
			this.bunifuCheckbox4.CheckedOnColor = Color.White;
			this.bunifuCheckbox4.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox4.Location = new Point(483, 164);
			this.bunifuCheckbox4.Name = "bunifuCheckbox4";
			this.bunifuCheckbox4.Size = new Size(20, 20);
			this.bunifuCheckbox4.TabIndex = 48;
			this.bunifuCheckbox4.OnChange += this.bunifuCheckbox4_OnChange;
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Microsoft Sans Serif", 11f);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(367, 202);
			this.label5.Name = "label5";
			this.label5.Size = new Size(110, 18);
			this.label5.TabIndex = 47;
			this.label5.Text = "Explorer Cache";
			this.bunifuCheckbox5.BackColor = Color.White;
			this.bunifuCheckbox5.ChechedOffColor = Color.White;
			this.bunifuCheckbox5.Checked = true;
			this.bunifuCheckbox5.CheckedOnColor = Color.White;
			this.bunifuCheckbox5.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox5.Location = new Point(483, 200);
			this.bunifuCheckbox5.Name = "bunifuCheckbox5";
			this.bunifuCheckbox5.Size = new Size(20, 20);
			this.bunifuCheckbox5.TabIndex = 46;
			this.bunifuCheckbox5.OnChange += this.bunifuCheckbox5_OnChange;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Microsoft Sans Serif", 11f);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(335, 237);
			this.label6.Name = "label6";
			this.label6.Size = new Size(142, 18);
			this.label6.TabIndex = 45;
			this.label6.Text = "Software distribution";
			this.bunifuCheckbox6.BackColor = Color.White;
			this.bunifuCheckbox6.ChechedOffColor = Color.White;
			this.bunifuCheckbox6.Checked = true;
			this.bunifuCheckbox6.CheckedOnColor = Color.White;
			this.bunifuCheckbox6.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox6.Location = new Point(483, 237);
			this.bunifuCheckbox6.Name = "bunifuCheckbox6";
			this.bunifuCheckbox6.Size = new Size(20, 20);
			this.bunifuCheckbox6.TabIndex = 44;
			this.bunifuCheckbox6.OnChange += this.bunifuCheckbox6_OnChange;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 11f);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(131, 164);
			this.label2.Name = "label2";
			this.label2.Size = new Size(72, 18);
			this.label2.TabIndex = 43;
			this.label2.Text = "Coockies";
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 11f);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(131, 200);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 18);
			this.label1.TabIndex = 41;
			this.label1.Text = "Perfetch";
			this.bunifuCheckbox2.BackColor = Color.White;
			this.bunifuCheckbox2.ChechedOffColor = Color.White;
			this.bunifuCheckbox2.Checked = true;
			this.bunifuCheckbox2.CheckedOnColor = Color.White;
			this.bunifuCheckbox2.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox2.Location = new Point(105, 200);
			this.bunifuCheckbox2.Name = "bunifuCheckbox2";
			this.bunifuCheckbox2.Size = new Size(20, 20);
			this.bunifuCheckbox2.TabIndex = 40;
			this.bunifuCheckbox2.OnChange += this.bunifuCheckbox2_OnChange;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Microsoft Sans Serif", 11f);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(131, 237);
			this.label4.Name = "label4";
			this.label4.Size = new Size(89, 18);
			this.label4.TabIndex = 39;
			this.label4.Text = "Install cache";
			this.bunifuCheckbox1.BackColor = Color.White;
			this.bunifuCheckbox1.ChechedOffColor = Color.White;
			this.bunifuCheckbox1.Checked = true;
			this.bunifuCheckbox1.CheckedOnColor = Color.White;
			this.bunifuCheckbox1.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox1.Location = new Point(105, 237);
			this.bunifuCheckbox1.Name = "bunifuCheckbox1";
			this.bunifuCheckbox1.Size = new Size(20, 20);
			this.bunifuCheckbox1.TabIndex = 38;
			this.bunifuCheckbox1.OnChange += this.bunifuCheckbox1_OnChange;
			this.bunifuCheckbox3.BackColor = Color.White;
			this.bunifuCheckbox3.ChechedOffColor = Color.White;
			this.bunifuCheckbox3.Checked = true;
			this.bunifuCheckbox3.CheckedOnColor = Color.White;
			this.bunifuCheckbox3.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox3.Location = new Point(105, 164);
			this.bunifuCheckbox3.Name = "bunifuCheckbox3";
			this.bunifuCheckbox3.Size = new Size(20, 20);
			this.bunifuCheckbox3.TabIndex = 42;
			this.bunifuCheckbox3.OnChange += this.bunifuCheckbox3_OnChange;
			this.bunifuCheckbox7.BackColor = Color.White;
			this.bunifuCheckbox7.ChechedOffColor = Color.White;
			this.bunifuCheckbox7.Checked = true;
			this.bunifuCheckbox7.CheckedOnColor = Color.White;
			this.bunifuCheckbox7.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox7.Location = new Point(105, 128);
			this.bunifuCheckbox7.Name = "bunifuCheckbox7";
			this.bunifuCheckbox7.Size = new Size(20, 20);
			this.bunifuCheckbox7.TabIndex = 50;
			this.bunifuCheckbox7.OnChange += this.bunifuCheckbox7_OnChange;
			this.bunifuCheckbox8.BackColor = Color.White;
			this.bunifuCheckbox8.ChechedOffColor = Color.White;
			this.bunifuCheckbox8.Checked = true;
			this.bunifuCheckbox8.CheckedOnColor = Color.White;
			this.bunifuCheckbox8.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox8.Location = new Point(483, 128);
			this.bunifuCheckbox8.Name = "bunifuCheckbox8";
			this.bunifuCheckbox8.Size = new Size(20, 20);
			this.bunifuCheckbox8.TabIndex = 51;
			this.bunifuCheckbox8.OnChange += this.bunifuCheckbox8_OnChange;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Microsoft Sans Serif", 11f);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(131, 130);
			this.label7.Name = "label7";
			this.label7.Size = new Size(46, 18);
			this.label7.TabIndex = 52;
			this.label7.Text = "Temp";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Microsoft Sans Serif", 11f);
			this.label8.ForeColor = Color.White;
			this.label8.Location = new Point(387, 128);
			this.label8.Name = "label8";
			this.label8.Size = new Size(88, 18);
			this.label8.TabIndex = 53;
			this.label8.Text = "Steam Logs";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(40, 42, 60);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.bunifuCheckbox8);
			base.Controls.Add(this.bunifuCheckbox7);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.bunifuCheckbox4);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.bunifuCheckbox5);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.bunifuCheckbox6);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.bunifuCheckbox3);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.bunifuCheckbox2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.bunifuCheckbox1);
			base.Controls.Add(guna2Button);
			base.Name = "cleaner";
			base.Size = new Size(636, 483);
			base.Load += this.cleaner_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000D RID: 13
		private static cleaner _instance;

		// Token: 0x0400000E RID: 14
		private IContainer components = null;

		// Token: 0x0400000F RID: 15
		private Label label3;

		// Token: 0x04000010 RID: 16
		private BunifuCheckbox bunifuCheckbox4;

		// Token: 0x04000011 RID: 17
		private Label label5;

		// Token: 0x04000012 RID: 18
		private BunifuCheckbox bunifuCheckbox5;

		// Token: 0x04000013 RID: 19
		private Label label6;

		// Token: 0x04000014 RID: 20
		private BunifuCheckbox bunifuCheckbox6;

		// Token: 0x04000015 RID: 21
		private Label label2;

		// Token: 0x04000016 RID: 22
		private Label label1;

		// Token: 0x04000017 RID: 23
		private BunifuCheckbox bunifuCheckbox2;

		// Token: 0x04000018 RID: 24
		private Label label4;

		// Token: 0x04000019 RID: 25
		private BunifuCheckbox bunifuCheckbox1;

		// Token: 0x0400001A RID: 26
		private BunifuCheckbox bunifuCheckbox3;

		// Token: 0x0400001B RID: 27
		private BunifuCheckbox bunifuCheckbox7;

		// Token: 0x0400001C RID: 28
		private BunifuCheckbox bunifuCheckbox8;

		// Token: 0x0400001D RID: 29
		private Label label7;

		// Token: 0x0400001E RID: 30
		private Label label8;
	}
}
