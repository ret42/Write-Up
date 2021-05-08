using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Guna.UI2.WinForms;

namespace Rush_it_redesign
{
	// Token: 0x0200000C RID: 12
	public class reg_maker : UserControl
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000094A8 File Offset: 0x000076A8
		public reg_maker()
		{
			this.InitializeComponent();
			this.bunifuCheckbox1.Checked = false;
			this.bunifuCheckbox3.Checked = false;
			this.bunifuCheckbox7.Checked = false;
			this.regEditVersion = "Windows Registry Editor Version 5.00\r\nThis regedit was made by Rush it Reg Maker https://discord.gg/t6d4JPabSK" + Environment.NewLine;
			this.textBox1.AppendText(this.regEditVersion);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000951C File Offset: 0x0000771C
		public static reg_maker Instance
		{
			get
			{
				bool flag = reg_maker._instance == null;
				if (flag)
				{
					reg_maker._instance = new reg_maker();
				}
				return reg_maker._instance;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002057 File Offset: 0x00000257
		private void reg_maker_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000954C File Offset: 0x0000774C
		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			bool flag = folderBrowserDialog.ShowDialog() != DialogResult.OK;
			if (!flag)
			{
				this.bunifuMaterialTextbox3.Text = folderBrowserDialog.SelectedPath;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00009584 File Offset: 0x00007784
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			bool flag = this.bunifuMaterialTextbox1.Text == "";
			if (flag)
			{
				MessageBox.Show("Veuillez selectionner un nom", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				bool flag2 = this.bunifuMaterialTextbox3.Text == "";
				if (flag2)
				{
					MessageBox.Show("Veuillez selectier une sortie", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			string text = this.bunifuMaterialTextbox3.Text;
			TextWriter textWriter = new StreamWriter(text + "\\" + this.bunifuMaterialTextbox1.Text + ".reg");
			textWriter.Write(this.textBox1.Text);
			textWriter.Close();
			int num = (int)MessageBox.Show("Le regedit a été créer avec un succes", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000964C File Offset: 0x0000784C
		private void bunifuCheckbox7_OnChange(object sender, EventArgs e)
		{
			string text = this.bunifuMaterialTextbox5.Text;
			bool flag = this.bunifuMaterialTextbox5.Text == "";
			if (flag)
			{
				MessageBox.Show("Veuillez selectionner une interface", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.bunifuCheckbox7.Checked = false;
			}
			else
			{
				bool flag2 = this.bunifuMaterialTextbox2.Text == "";
				if (flag2)
				{
					MessageBox.Show("Veuillez selectionner un nombre de ram", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					this.bunifuCheckbox7.Checked = false;
				}
				else
				{
					bool flag3 = this.bunifuMaterialTextbox4.Text == "";
					if (flag3)
					{
						MessageBox.Show("Veuillez selectionner un mtu", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.bunifuCheckbox7.Checked = false;
					}
				}
			}
			int num = Convert.ToInt32(this.bunifuMaterialTextbox4.Text);
			int num2 = Convert.ToInt32(this.bunifuMaterialTextbox2.Text) / 4 * 983040;
			string text2 = num.ToString("X");
			string str = num2.ToString("X");
			bool @checked = this.bunifuCheckbox7.Checked;
			if (@checked)
			{
				this.textBox1.AppendText("\r\n[HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters]\r\n\"DefaultTTL\"=dword:000000ff\r\n\"DisableTaskOffload\"=dword:00000000\r\n\"EnableConnectionRateLimiting\"=dword:00000001\r\n\"EnablePMTUDiscovery\"=dword:00000001\r\n\"EnablePMTUBHDetect\"=dword:00000001\r\n\"EnableDCA\"=dword:00000001\r\n\"EnableICMPRedirect\"=dword:00000000\r\n\"EnableTCPA\"=dword:00000001\r\n\"EnableWsd\"=dword:00000000\r\n\"EnableFastRouteLookup\"=dword:00000001\r\n\"FFPFastForwardingCacheSize\"=dword:" + str + "\r\n\"FFPControlFlags\"=dword:00000001\r\n\"IGMPLevel\"=dword:00000004\r\n\"KeepAliveTime\"=dword:00000064\r\n\"KeepAliveInterval\"=dword:00000064\r\n\"MaxFreeTcbs\"=dword:00010000\r\n\"MaxHashTableSize\"=dword:00010000\r\n\"MaxUserPort\"=dword:0000fffe\r\n\"SackOpts\"=dword:00000001\r\n\"StrictTimeWaitSeqCheck\"=dword:00000001\r\n\"Tcp1323Opts\"=dword:00000000\r\n\"TcpFinWait2Delay\"=dword:000000001e\r\n\"TcpMaxConnectResponseRetransmissions\"=dword:00000001\r\n\"TcpMaxConnectRetransmissions\"=dword:00000002\r\n\"TcpTimedWaitDelay\"=dword:0000001e\r\n\"TcpCreateAndConnectTcbRateLimitDepth\"=dword:00000000\r\n\"TcpMaxSendFree\"=dword:0000ffff" + Environment.NewLine);
				this.textBox1.AppendText(string.Concat(new string[]
				{
					"\r\n[HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\",
					this.bunifuMaterialTextbox5.Text,
					"]\r\n\"TCPNoDelay\"=dword:1\r\n\"TcpAckFrequency\"=dword:1\r\n\"TcpDelAckticks\"=dword:0\r\n\"MTU\"=dword:",
					text2,
					"\r\n\"TcpInitialRTT\"=dword:2",
					Environment.NewLine
				}));
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000097E4 File Offset: 0x000079E4
		private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
		{
			bool @checked = this.bunifuCheckbox1.Checked;
			if (@checked)
			{
				this.textBox1.AppendText("\r\n[HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Psched\\Parameters\\Adaptaters\\{" + this.bunifuMaterialTextbox5.Text + "}]\r\n\"NonBestEffortLimit\"=dword:0" + Environment.NewLine);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00009830 File Offset: 0x00007A30
		private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
		{
			bool @checked = this.bunifuCheckbox3.Checked;
			if (@checked)
			{
				this.textBox1.AppendText("\r\n[HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters]\r\n\"MaxCacheEntryTtlLimit\"=dword:0000fa00\r\n\"MaxSOACacheEntryTtlLimit\"=dword:0000012d\r\n\"NegativeCacheTime\"=dword:00000000\r\n\"NetFailureCacheTime\"=dword:00000000\r\n\"NegativeSOACacheTime\"=dword:00000000\r\n\"CacheHashTableBucketSize\"=dword:1\r\n\"MaxNegativeCacheTtl\"=dword:00000000\r\n\"CacheHashTableSize\"=dword:00000180\r\n\"MaxCacheTtl\"=dword:00002a30" + Environment.NewLine);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002057 File Offset: 0x00000257
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000986C File Offset: 0x00007A6C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000098A4 File Offset: 0x00007AA4
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(reg_maker));
			this.bunifuMaterialTextbox3 = new BunifuMaterialTextbox();
			this.bunifuMaterialTextbox1 = new BunifuMaterialTextbox();
			this.bunifuImageButton1 = new BunifuImageButton();
			this.label3 = new Label();
			this.bunifuMaterialTextbox2 = new BunifuMaterialTextbox();
			this.label1 = new Label();
			this.bunifuMaterialTextbox4 = new BunifuMaterialTextbox();
			this.label2 = new Label();
			this.bunifuMaterialTextbox5 = new BunifuMaterialTextbox();
			this.label7 = new Label();
			this.bunifuCheckbox7 = new BunifuCheckbox();
			this.label4 = new Label();
			this.bunifuCheckbox1 = new BunifuCheckbox();
			this.label6 = new Label();
			this.bunifuCheckbox3 = new BunifuCheckbox();
			this.textBox1 = new TextBox();
			Guna2Button guna2Button = new Guna2Button();
			((ISupportInitialize)this.bunifuImageButton1).BeginInit();
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
			guna2Button.Location = new Point(393, 314);
			guna2Button.Name = "guna2Button2";
			guna2Button.ShadowDecoration.Parent = guna2Button;
			guna2Button.Size = new Size(215, 61);
			guna2Button.TabIndex = 7;
			guna2Button.Text = "Create";
			guna2Button.Click += this.guna2Button2_Click;
			this.bunifuMaterialTextbox3.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox3.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox3.ForeColor = Color.White;
			this.bunifuMaterialTextbox3.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox3.HintText = "Output";
			this.bunifuMaterialTextbox3.isPassword = false;
			this.bunifuMaterialTextbox3.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox3.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox3.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox3.LineThickness = 3;
			this.bunifuMaterialTextbox3.Location = new Point(431, 242);
			this.bunifuMaterialTextbox3.Margin = new Padding(4);
			this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
			this.bunifuMaterialTextbox3.Size = new Size(138, 33);
			this.bunifuMaterialTextbox3.TabIndex = 15;
			this.bunifuMaterialTextbox3.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox3.OnValueChanged += this.bunifuMaterialTextbox3_OnValueChanged;
			this.bunifuMaterialTextbox1.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox1.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox1.ForeColor = Color.White;
			this.bunifuMaterialTextbox1.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox1.HintText = "Regedit Name";
			this.bunifuMaterialTextbox1.isPassword = false;
			this.bunifuMaterialTextbox1.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox1.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox1.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox1.LineThickness = 3;
			this.bunifuMaterialTextbox1.Location = new Point(431, 184);
			this.bunifuMaterialTextbox1.Margin = new Padding(4);
			this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
			this.bunifuMaterialTextbox1.Size = new Size(138, 33);
			this.bunifuMaterialTextbox1.TabIndex = 16;
			this.bunifuMaterialTextbox1.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox1.OnValueChanged += this.bunifuMaterialTextbox1_OnValueChanged;
			this.bunifuImageButton1.BackColor = Color.Transparent;
			this.bunifuImageButton1.Image = (Image)componentResourceManager.GetObject("bunifuImageButton1.Image");
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new Point(576, 252);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new Size(32, 29);
			this.bunifuImageButton1.SizeMode = PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 17;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += this.bunifuImageButton1_Click;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Microsoft Sans Serif", 12f);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(104, 182);
			this.label3.Name = "label3";
			this.label3.Size = new Size(43, 20);
			this.label3.TabIndex = 19;
			this.label3.Text = "Ram";
			this.bunifuMaterialTextbox2.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox2.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox2.ForeColor = Color.White;
			this.bunifuMaterialTextbox2.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox2.HintText = "Ram";
			this.bunifuMaterialTextbox2.isPassword = false;
			this.bunifuMaterialTextbox2.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox2.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox2.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox2.LineThickness = 3;
			this.bunifuMaterialTextbox2.Location = new Point(65, 135);
			this.bunifuMaterialTextbox2.Margin = new Padding(4);
			this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
			this.bunifuMaterialTextbox2.Size = new Size(119, 33);
			this.bunifuMaterialTextbox2.TabIndex = 18;
			this.bunifuMaterialTextbox2.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox2.OnValueChanged += this.bunifuMaterialTextbox2_OnValueChanged;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 12f);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(303, 182);
			this.label1.Name = "label1";
			this.label1.Size = new Size(36, 20);
			this.label1.TabIndex = 21;
			this.label1.Text = "Mtu";
			this.bunifuMaterialTextbox4.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox4.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox4.ForeColor = Color.White;
			this.bunifuMaterialTextbox4.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox4.HintText = "Mtu";
			this.bunifuMaterialTextbox4.isPassword = false;
			this.bunifuMaterialTextbox4.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox4.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox4.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox4.LineThickness = 3;
			this.bunifuMaterialTextbox4.Location = new Point(257, 135);
			this.bunifuMaterialTextbox4.Margin = new Padding(4);
			this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
			this.bunifuMaterialTextbox4.Size = new Size(124, 33);
			this.bunifuMaterialTextbox4.TabIndex = 20;
			this.bunifuMaterialTextbox4.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox4.OnValueChanged += this.bunifuMaterialTextbox4_OnValueChanged;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 12f);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(160, 111);
			this.label2.Name = "label2";
			this.label2.Size = new Size(135, 20);
			this.label2.TabIndex = 23;
			this.label2.Text = "Network Interface";
			this.bunifuMaterialTextbox5.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox5.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox5.ForeColor = Color.White;
			this.bunifuMaterialTextbox5.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox5.HintText = "Network Interface";
			this.bunifuMaterialTextbox5.isPassword = false;
			this.bunifuMaterialTextbox5.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox5.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox5.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox5.LineThickness = 3;
			this.bunifuMaterialTextbox5.Location = new Point(65, 62);
			this.bunifuMaterialTextbox5.Margin = new Padding(4);
			this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
			this.bunifuMaterialTextbox5.Size = new Size(316, 33);
			this.bunifuMaterialTextbox5.TabIndex = 22;
			this.bunifuMaterialTextbox5.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox5.OnValueChanged += this.bunifuMaterialTextbox5_OnValueChanged;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Microsoft Sans Serif", 11f);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(82, 314);
			this.label7.Name = "label7";
			this.label7.Size = new Size(48, 18);
			this.label7.TabIndex = 54;
			this.label7.Text = "Tcp/Ip";
			this.bunifuCheckbox7.BackColor = Color.White;
			this.bunifuCheckbox7.ChechedOffColor = Color.White;
			this.bunifuCheckbox7.Checked = true;
			this.bunifuCheckbox7.CheckedOnColor = Color.White;
			this.bunifuCheckbox7.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox7.Location = new Point(56, 312);
			this.bunifuCheckbox7.Name = "bunifuCheckbox7";
			this.bunifuCheckbox7.Size = new Size(20, 20);
			this.bunifuCheckbox7.TabIndex = 53;
			this.bunifuCheckbox7.OnChange += this.bunifuCheckbox7_OnChange;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Microsoft Sans Serif", 11f);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(82, 342);
			this.label4.Name = "label4";
			this.label4.Size = new Size(121, 18);
			this.label4.TabIndex = 56;
			this.label4.Text = "Disable Bandwith";
			this.bunifuCheckbox1.BackColor = Color.White;
			this.bunifuCheckbox1.ChechedOffColor = Color.White;
			this.bunifuCheckbox1.Checked = true;
			this.bunifuCheckbox1.CheckedOnColor = Color.White;
			this.bunifuCheckbox1.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox1.Location = new Point(56, 340);
			this.bunifuCheckbox1.Name = "bunifuCheckbox1";
			this.bunifuCheckbox1.Size = new Size(20, 20);
			this.bunifuCheckbox1.TabIndex = 55;
			this.bunifuCheckbox1.OnChange += this.bunifuCheckbox1_OnChange;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Microsoft Sans Serif", 11f);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(82, 372);
			this.label6.Name = "label6";
			this.label6.Size = new Size(78, 18);
			this.label6.TabIndex = 60;
			this.label6.Text = "DnsCache";
			this.bunifuCheckbox3.BackColor = Color.White;
			this.bunifuCheckbox3.ChechedOffColor = Color.White;
			this.bunifuCheckbox3.Checked = true;
			this.bunifuCheckbox3.CheckedOnColor = Color.White;
			this.bunifuCheckbox3.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox3.Location = new Point(56, 373);
			this.bunifuCheckbox3.Name = "bunifuCheckbox3";
			this.bunifuCheckbox3.Size = new Size(20, 20);
			this.bunifuCheckbox3.TabIndex = 59;
			this.bunifuCheckbox3.OnChange += this.bunifuCheckbox3_OnChange;
			this.textBox1.BackColor = Color.FromArgb(40, 42, 60);
			this.textBox1.BorderStyle = BorderStyle.None;
			this.textBox1.ForeColor = Color.FromArgb(40, 42, 60);
			this.textBox1.Location = new Point(617, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(19, 13);
			this.textBox1.TabIndex = 61;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(40, 42, 60);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.bunifuCheckbox3);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.bunifuCheckbox1);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.bunifuCheckbox7);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.bunifuMaterialTextbox5);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.bunifuMaterialTextbox4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.bunifuMaterialTextbox2);
			base.Controls.Add(this.bunifuImageButton1);
			base.Controls.Add(this.bunifuMaterialTextbox1);
			base.Controls.Add(this.bunifuMaterialTextbox3);
			base.Controls.Add(guna2Button);
			base.Name = "reg_maker";
			base.Size = new Size(636, 483);
			base.Load += this.reg_maker_Load;
			((ISupportInitialize)this.bunifuImageButton1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000049 RID: 73
		public string regEditVersion;

		// Token: 0x0400004A RID: 74
		private static reg_maker _instance;

		// Token: 0x0400004B RID: 75
		private IContainer components = null;

		// Token: 0x0400004C RID: 76
		private BunifuMaterialTextbox bunifuMaterialTextbox3;

		// Token: 0x0400004D RID: 77
		private BunifuMaterialTextbox bunifuMaterialTextbox1;

		// Token: 0x0400004E RID: 78
		private BunifuImageButton bunifuImageButton1;

		// Token: 0x0400004F RID: 79
		private Label label3;

		// Token: 0x04000050 RID: 80
		private BunifuMaterialTextbox bunifuMaterialTextbox2;

		// Token: 0x04000051 RID: 81
		private Label label1;

		// Token: 0x04000052 RID: 82
		private BunifuMaterialTextbox bunifuMaterialTextbox4;

		// Token: 0x04000053 RID: 83
		private Label label2;

		// Token: 0x04000054 RID: 84
		private BunifuMaterialTextbox bunifuMaterialTextbox5;

		// Token: 0x04000055 RID: 85
		private Label label7;

		// Token: 0x04000056 RID: 86
		private BunifuCheckbox bunifuCheckbox7;

		// Token: 0x04000057 RID: 87
		private Label label4;

		// Token: 0x04000058 RID: 88
		private BunifuCheckbox bunifuCheckbox1;

		// Token: 0x04000059 RID: 89
		private Label label6;

		// Token: 0x0400005A RID: 90
		private BunifuCheckbox bunifuCheckbox3;

		// Token: 0x0400005B RID: 91
		private TextBox textBox1;
	}
}
