using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Microsoft.Win32;
using Rush_it_redesign.Properties;

namespace Rush_it_redesign
{
	// Token: 0x02000007 RID: 7
	public partial class Form1 : Form
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002063 File Offset: 0x00000263
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004438 File Offset: 0x00002638
		private void Form1_Load(object sender, EventArgs e)
		{
			bool flag = Settings.Default.Username != string.Empty;
			if (flag)
			{
				this.bunifuMaterialTextbox1.Text = Settings.Default.Username;
				this.bunifuMaterialTextbox2.Text = Settings.Default.Password;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000448C File Offset: 0x0000268C
		private void button1_Click(object sender, EventArgs e)
		{
			Settings.Default.Username = this.bunifuMaterialTextbox1.Text;
			Settings.Default.Password = this.bunifuMaterialTextbox2.Text;
			Settings.Default.Save();
			object value = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", null);
			WebClient webClient = new WebClient();
			string machineGuid = Form1.HWID2.GetMachineGuid();
			string text = this.bunifuMaterialTextbox1.Text;
			string text2 = this.bunifuMaterialTextbox2.Text;
			string text3 = webClient.DownloadString("https://pastebin.com/raw/Tim40pv6");
			bool flag = text3.Contains(machineGuid);
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = text3.Contains(text);
				bool flag4 = flag3;
				if (flag4)
				{
					bool flag5 = text3.Contains(text2);
					bool flag6 = flag5;
					if (flag6)
					{
						Form2 form = new Form2();
						MessageBox.Show("cracked by mano", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						form.Show();
						base.Hide();
					}
					else
					{
						Form2 form2 = new Form2();
						MessageBox.Show("cracked by mano", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						form2.Show();
						base.Hide();
					}
				}
				else
				{
					Form2 form3 = new Form2();
					MessageBox.Show("cracked by mano", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					form3.Show();
					base.Hide();
				}
			}
			else
			{
				Form2 form4 = new Form2();
				MessageBox.Show("cracked by mano", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				form4.Show();
				base.Hide();
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000207B File Offset: 0x0000027B
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseLocation = new Point(-e.X, -e.Y);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004604 File Offset: 0x00002804
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				Point mousePosition = Control.MousePosition;
				mousePosition.Offset(this.mouseLocation.X, this.mouseLocation.Y);
				base.Location = mousePosition;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002097 File Offset: 0x00000297
		private void bunifuImageButton2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020A0 File Offset: 0x000002A0
		private void bunifuImageButton3_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004654 File Offset: 0x00002854
		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			object value = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography", "MachineGuid", null);
			WebClient webClient = new WebClient();
			string machineGuid = Form1.HWID2.GetMachineGuid();
			Clipboard.SetText(machineGuid);
			MessageBox.Show("Votre hwid a été copié", "Rush It");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0400001F RID: 31
		public Point mouseLocation;

		// Token: 0x02000008 RID: 8
		internal class HWID2
		{
			// Token: 0x06000036 RID: 54 RVA: 0x00005138 File Offset: 0x00003338
			public static string GetMachineGuid()
			{
				string text = "SOFTWARE\\Microsoft\\Cryptography";
				string text2 = "MachineGuid";
				string result;
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
					{
						if (registryKey2 == null)
						{
							throw new KeyNotFoundException(string.Format("Key not found : {0}", text));
						}
						object value = registryKey2.GetValue(text2);
						if (value == null)
						{
							throw new IndexOutOfRangeException(string.Format("Index not found: {0}", text2));
						}
						result = value.ToString();
					}
				}
				return result;
			}
		}
	}
}
