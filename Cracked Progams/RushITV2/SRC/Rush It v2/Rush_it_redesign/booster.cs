using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Guna.UI2.WinForms;

namespace Rush_it_redesign
{
	// Token: 0x02000002 RID: 2
	public class booster : UserControl
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002148 File Offset: 0x00000348
		public static booster Instance
		{
			get
			{
				bool flag = booster._instance == null;
				if (flag)
				{
					booster._instance = new booster();
				}
				return booster._instance;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002178 File Offset: 0x00000378
		public booster()
		{
			this.InitializeComponent();
			this.bunifuCheckbox1.Checked = false;
			this.bunifuCheckbox2.Checked = false;
			this.bunifuCheckbox3.Checked = false;
			this.bunifuCheckbox4.Checked = false;
			this.bunifuCheckbox7.Checked = false;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002057 File Offset: 0x00000257
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002057 File Offset: 0x00000257
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002057 File Offset: 0x00000257
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002057 File Offset: 0x00000257
		private void booster_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox6_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox5_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuCheckbox7_OnChange(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002057 File Offset: 0x00000257
		private void label7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021DC File Offset: 0x000003DC
		private void guna2Button2_Click_1(object sender, EventArgs e)
		{
			string text = this.bunifuMaterialTextbox1.Text;
			Process process = new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe"
				}
			};
			bool @checked = this.bunifuCheckbox3.Checked;
			if (@checked)
			{
				process.StartInfo.Arguments = "/C  wmic process where name='AZ-Launcher.exe' call setpriority '128'  & exit";
			}
			bool checked2 = this.bunifuCheckbox2.Checked;
			if (checked2)
			{
				process.StartInfo.Arguments = "/C  wmic process where name='javaw.exe' call setpriority '128'  & exit";
			}
			bool checked3 = this.bunifuCheckbox1.Checked;
			if (checked3)
			{
				process.StartInfo.Arguments = "/C  wmic process where name='Badlion Client.exe' call setpriority '128'  & exit";
			}
			bool checked4 = this.bunifuCheckbox4.Checked;
			if (checked4)
			{
				process.StartInfo.Arguments = "/C  wmic process where name='javaw.exe' call setpriority '128'  & exit";
			}
			bool checked5 = this.bunifuCheckbox7.Checked;
			if (checked5)
			{
				process.StartInfo.Arguments = "/C  wmic process where name='" + text + "' call setpriority '128'  & exit";
			}
			process.StartInfo.Arguments = "/C sc stop BITS & exit";
			process.StartInfo.Arguments = "/C  wmic process where name='svchost.exe' call setpriority '128'  & exit";
			process.StartInfo.Arguments = "/C ipconfig /flushdns & exit";
			process.StartInfo.Arguments = "/C  wmic process where name='conhost.exe' call setpriority '16384'  & exit";
			process.StartInfo.Arguments = "/C  wmic process where name='SearchUI.exe' call setpriority '16384'  & exit";
			process.StartInfo.Arguments = "/C  wmic process where name='RuntimeBroker.exe' call setpriority '16384'  & exit";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			MessageBox.Show("Jeux boostés", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002358 File Offset: 0x00000558
		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			Process process = new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe"
				}
			};
			process.StartInfo.Arguments = "/C  wmic process where name='svchost.exe' call setpriority '128' & exit";
			process.StartInfo.Arguments = "/C  wmic process where name='javaw.exe' call setpriority '128' & exit";
			process.StartInfo.Arguments = "/C  wmic process where name='AZ-Launcher.exe' call setpriority 'normal' & exit";
			process.StartInfo.Arguments = "/C  wmic process where name='AALService.exe' call setpriority 'normal' & exit";
			process.StartInfo.Arguments = "/C  wmic process where name='Badlion Client.exe' call setpriority 'normal' & exit";
			process.StartInfo.Arguments = "/C  wmic process where name='conhost.exe' call setpriority 'normal' & exit";
			process.StartInfo.Arguments = "/C  wmic process where name='SearchUI.exe' call setpriority 'normal' & exit";
			process.StartInfo.Arguments = "/C  wmic process where name='RuntimeBroker.exe' call setpriority 'normal' & exit";
			process.StartInfo.Arguments = "/C ipconfig /flushdns & exit";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			MessageBox.Show("Boost retiré", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002440 File Offset: 0x00000640
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002478 File Offset: 0x00000678
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(booster));
			this.bunifuCheckbox1 = new BunifuCheckbox();
			this.label4 = new Label();
			this.label1 = new Label();
			this.bunifuCheckbox2 = new BunifuCheckbox();
			this.label2 = new Label();
			this.bunifuCheckbox3 = new BunifuCheckbox();
			this.label3 = new Label();
			this.bunifuCheckbox4 = new BunifuCheckbox();
			this.bunifuMaterialTextbox1 = new BunifuMaterialTextbox();
			this.bunifuCheckbox7 = new BunifuCheckbox();
			Guna2Button guna2Button = new Guna2Button();
			Guna2Button guna2Button2 = new Guna2Button();
			base.SuspendLayout();
			guna2Button.BorderRadius = 22;
			guna2Button.CheckedState.Parent = guna2Button;
			guna2Button.CustomImages.Parent = guna2Button;
			guna2Button.FillColor = Color.White;
			guna2Button.Font = new Font("Segoe UI", 15f);
			guna2Button.ForeColor = Color.FromArgb(40, 42, 60);
			guna2Button.HoverState.Parent = guna2Button;
			guna2Button.Image = (Image)componentResourceManager.GetObject("guna2Button1.Image");
			guna2Button.ImageAlign = HorizontalAlignment.Left;
			guna2Button.ImageSize = new Size(40, 40);
			guna2Button.Location = new Point(369, 314);
			guna2Button.Name = "guna2Button1";
			guna2Button.ShadowDecoration.Parent = guna2Button;
			guna2Button.Size = new Size(184, 61);
			guna2Button.TabIndex = 37;
			guna2Button.Text = "Stop";
			guna2Button.Click += this.guna2Button1_Click_1;
			guna2Button2.BorderRadius = 22;
			guna2Button2.CheckedState.Parent = guna2Button2;
			guna2Button2.CustomImages.Parent = guna2Button2;
			guna2Button2.FillColor = Color.White;
			guna2Button2.Font = new Font("Segoe UI", 15f);
			guna2Button2.ForeColor = Color.FromArgb(40, 42, 60);
			guna2Button2.HoverState.Parent = guna2Button2;
			guna2Button2.Image = (Image)componentResourceManager.GetObject("guna2Button2.Image");
			guna2Button2.ImageAlign = HorizontalAlignment.Left;
			guna2Button2.ImageSize = new Size(40, 40);
			guna2Button2.Location = new Point(68, 314);
			guna2Button2.Name = "guna2Button2";
			guna2Button2.ShadowDecoration.Parent = guna2Button2;
			guna2Button2.Size = new Size(184, 61);
			guna2Button2.TabIndex = 36;
			guna2Button2.Text = "Boost";
			guna2Button2.Click += this.guna2Button2_Click_1;
			this.bunifuCheckbox1.BackColor = Color.White;
			this.bunifuCheckbox1.ChechedOffColor = Color.White;
			this.bunifuCheckbox1.Checked = true;
			this.bunifuCheckbox1.CheckedOnColor = Color.White;
			this.bunifuCheckbox1.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox1.Location = new Point(492, 159);
			this.bunifuCheckbox1.Name = "bunifuCheckbox1";
			this.bunifuCheckbox1.Size = new Size(20, 20);
			this.bunifuCheckbox1.TabIndex = 20;
			this.bunifuCheckbox1.OnChange += this.bunifuCheckbox1_OnChange;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Microsoft Sans Serif", 11f);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(388, 159);
			this.label4.Name = "label4";
			this.label4.Size = new Size(98, 18);
			this.label4.TabIndex = 22;
			this.label4.Text = "Badlion Client";
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 11f);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(140, 159);
			this.label1.Name = "label1";
			this.label1.Size = new Size(86, 18);
			this.label1.TabIndex = 24;
			this.label1.Text = "Lunar Client";
			this.bunifuCheckbox2.BackColor = Color.White;
			this.bunifuCheckbox2.ChechedOffColor = Color.White;
			this.bunifuCheckbox2.Checked = true;
			this.bunifuCheckbox2.CheckedOnColor = Color.White;
			this.bunifuCheckbox2.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox2.Location = new Point(114, 159);
			this.bunifuCheckbox2.Name = "bunifuCheckbox2";
			this.bunifuCheckbox2.Size = new Size(20, 20);
			this.bunifuCheckbox2.TabIndex = 23;
			this.bunifuCheckbox2.OnChange += this.bunifuCheckbox2_OnChange;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 11f);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(140, 123);
			this.label2.Name = "label2";
			this.label2.Size = new Size(90, 18);
			this.label2.TabIndex = 26;
			this.label2.Text = "Az Launcher";
			this.bunifuCheckbox3.BackColor = Color.White;
			this.bunifuCheckbox3.ChechedOffColor = Color.White;
			this.bunifuCheckbox3.Checked = true;
			this.bunifuCheckbox3.CheckedOnColor = Color.White;
			this.bunifuCheckbox3.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox3.Location = new Point(114, 123);
			this.bunifuCheckbox3.Name = "bunifuCheckbox3";
			this.bunifuCheckbox3.Size = new Size(20, 20);
			this.bunifuCheckbox3.TabIndex = 25;
			this.bunifuCheckbox3.OnChange += this.bunifuCheckbox3_OnChange;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Microsoft Sans Serif", 11f);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(417, 123);
			this.label3.Name = "label3";
			this.label3.Size = new Size(69, 18);
			this.label3.TabIndex = 32;
			this.label3.Text = "Minecraft";
			this.label3.Click += this.label3_Click;
			this.bunifuCheckbox4.BackColor = Color.White;
			this.bunifuCheckbox4.ChechedOffColor = Color.White;
			this.bunifuCheckbox4.Checked = true;
			this.bunifuCheckbox4.CheckedOnColor = Color.White;
			this.bunifuCheckbox4.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox4.Location = new Point(492, 123);
			this.bunifuCheckbox4.Name = "bunifuCheckbox4";
			this.bunifuCheckbox4.Size = new Size(20, 20);
			this.bunifuCheckbox4.TabIndex = 31;
			this.bunifuCheckbox4.OnChange += this.bunifuCheckbox4_OnChange;
			this.bunifuMaterialTextbox1.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox1.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox1.ForeColor = Color.White;
			this.bunifuMaterialTextbox1.HintForeColor = Color.Silver;
			this.bunifuMaterialTextbox1.HintText = "(gamename).exe";
			this.bunifuMaterialTextbox1.isPassword = false;
			this.bunifuMaterialTextbox1.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox1.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox1.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox1.LineThickness = 3;
			this.bunifuMaterialTextbox1.Location = new Point(207, 251);
			this.bunifuMaterialTextbox1.Margin = new Padding(4);
			this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
			this.bunifuMaterialTextbox1.Size = new Size(217, 33);
			this.bunifuMaterialTextbox1.TabIndex = 33;
			this.bunifuMaterialTextbox1.TextAlign = HorizontalAlignment.Left;
			this.bunifuMaterialTextbox1.OnValueChanged += this.bunifuMaterialTextbox1_OnValueChanged;
			this.bunifuCheckbox7.BackColor = Color.White;
			this.bunifuCheckbox7.ChechedOffColor = Color.White;
			this.bunifuCheckbox7.Checked = true;
			this.bunifuCheckbox7.CheckedOnColor = Color.White;
			this.bunifuCheckbox7.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox7.Location = new Point(180, 262);
			this.bunifuCheckbox7.Name = "bunifuCheckbox7";
			this.bunifuCheckbox7.Size = new Size(20, 20);
			this.bunifuCheckbox7.TabIndex = 34;
			this.bunifuCheckbox7.OnChange += this.bunifuCheckbox7_OnChange;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(40, 42, 60);
			base.Controls.Add(guna2Button);
			base.Controls.Add(guna2Button2);
			base.Controls.Add(this.bunifuCheckbox7);
			base.Controls.Add(this.bunifuMaterialTextbox1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.bunifuCheckbox4);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.bunifuCheckbox3);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.bunifuCheckbox2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.bunifuCheckbox1);
			base.Name = "booster";
			base.Size = new Size(636, 483);
			base.Load += this.booster_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private static booster _instance;

		// Token: 0x04000002 RID: 2
		private IContainer components = null;

		// Token: 0x04000003 RID: 3
		private BunifuCheckbox bunifuCheckbox1;

		// Token: 0x04000004 RID: 4
		private Label label4;

		// Token: 0x04000005 RID: 5
		private Label label1;

		// Token: 0x04000006 RID: 6
		private BunifuCheckbox bunifuCheckbox2;

		// Token: 0x04000007 RID: 7
		private Label label2;

		// Token: 0x04000008 RID: 8
		private BunifuCheckbox bunifuCheckbox3;

		// Token: 0x04000009 RID: 9
		private Label label3;

		// Token: 0x0400000A RID: 10
		private BunifuCheckbox bunifuCheckbox4;

		// Token: 0x0400000B RID: 11
		private BunifuMaterialTextbox bunifuMaterialTextbox1;

		// Token: 0x0400000C RID: 12
		private BunifuCheckbox bunifuCheckbox7;
	}
}
