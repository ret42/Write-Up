using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Guna.UI2.WinForms;

namespace Rush_it_redesign
{
	// Token: 0x02000009 RID: 9
	public partial class Form2 : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000051D8 File Offset: 0x000033D8
		public Form2()
		{
			this.InitializeComponent();
			bool flag = !this.panel2.Controls.Contains(internet.Instance);
			if (flag)
			{
				this.panel2.Controls.Add(internet.Instance);
				internet.Instance.Dock = DockStyle.Fill;
				internet.Instance.BringToFront();
			}
			else
			{
				internet.Instance.BringToFront();
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002057 File Offset: 0x00000257
		private void Form2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002057 File Offset: 0x00000257
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005254 File Offset: 0x00003454
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.pictureBox1.Height = this.guna2Button1.Height;
			this.pictureBox1.Top = this.guna2Button1.Top;
			bool flag = !this.panel2.Controls.Contains(internet.Instance);
			if (flag)
			{
				this.panel2.Controls.Add(internet.Instance);
				internet.Instance.Dock = DockStyle.Fill;
				internet.Instance.BringToFront();
			}
			else
			{
				internet.Instance.BringToFront();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000052E8 File Offset: 0x000034E8
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			this.pictureBox1.Height = this.guna2Button2.Height;
			this.pictureBox1.Top = this.guna2Button2.Top;
			bool flag = !this.panel2.Controls.Contains(system.Instance);
			if (flag)
			{
				this.panel2.Controls.Add(system.Instance);
				system.Instance.Dock = DockStyle.Fill;
				system.Instance.BringToFront();
			}
			else
			{
				system.Instance.BringToFront();
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000537C File Offset: 0x0000357C
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			this.pictureBox1.Height = this.guna2Button3.Height;
			this.pictureBox1.Top = this.guna2Button3.Top;
			bool flag = !this.panel2.Controls.Contains(booster.Instance);
			if (flag)
			{
				this.panel2.Controls.Add(booster.Instance);
				booster.Instance.Dock = DockStyle.Fill;
				booster.Instance.BringToFront();
			}
			else
			{
				booster.Instance.BringToFront();
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005410 File Offset: 0x00003610
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			this.pictureBox1.Height = this.guna2Button4.Height;
			this.pictureBox1.Top = this.guna2Button4.Top;
			bool flag = !this.panel2.Controls.Contains(cleaner.Instance);
			if (flag)
			{
				this.panel2.Controls.Add(cleaner.Instance);
				cleaner.Instance.Dock = DockStyle.Fill;
				cleaner.Instance.BringToFront();
			}
			else
			{
				cleaner.Instance.BringToFront();
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000054A4 File Offset: 0x000036A4
		private void guna2Button5_Click(object sender, EventArgs e)
		{
			this.pictureBox1.Height = this.guna2Button5.Height;
			this.pictureBox1.Top = this.guna2Button5.Top;
			bool flag = !this.panel2.Controls.Contains(reg_maker.Instance);
			if (flag)
			{
				this.panel2.Controls.Add(reg_maker.Instance);
				reg_maker.Instance.Dock = DockStyle.Fill;
				reg_maker.Instance.BringToFront();
			}
			else
			{
				reg_maker.Instance.BringToFront();
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002057 File Offset: 0x00000257
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002057 File Offset: 0x00000257
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000020AB File Offset: 0x000002AB
		private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseLocation = new Point(-e.X, -e.Y);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005538 File Offset: 0x00003738
		private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				Point mousePosition = Control.MousePosition;
				mousePosition.Offset(this.mouseLocation.X, this.mouseLocation.Y);
				base.Location = mousePosition;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002097 File Offset: 0x00000297
		private void bunifuImageButton2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000020A0 File Offset: 0x000002A0
		private void bunifuImageButton3_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002057 File Offset: 0x00000257
		private void booster1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002057 File Offset: 0x00000257
		private void panel2_Paint_1(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002057 File Offset: 0x00000257
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400002C RID: 44
		public Point mouseLocation;
	}
}
