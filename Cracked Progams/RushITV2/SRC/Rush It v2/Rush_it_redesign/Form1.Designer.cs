namespace Rush_it_redesign
{
	// Token: 0x02000007 RID: 7
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00004698 File Offset: 0x00002898
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000046D0 File Offset: 0x000028D0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Rush_it_redesign.Form1));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.bunifuMaterialTextbox1 = new global::Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuMaterialTextbox2 = new global::Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuImageButton1 = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.bunifuImageButton3 = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton2 = new global::Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuElipse1 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.button1 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bunifuImageButton1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bunifuImageButton3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bunifuImageButton2).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(59, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(226, 180);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.bunifuMaterialTextbox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox1.ForeColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox1.HintForeColor = global::System.Drawing.Color.LightGray;
			this.bunifuMaterialTextbox1.HintText = "Username";
			this.bunifuMaterialTextbox1.isPassword = false;
			this.bunifuMaterialTextbox1.LineFocusedColor = global::System.Drawing.Color.Silver;
			this.bunifuMaterialTextbox1.LineIdleColor = global::System.Drawing.Color.White;
			this.bunifuMaterialTextbox1.LineMouseHoverColor = global::System.Drawing.Color.Silver;
			this.bunifuMaterialTextbox1.LineThickness = 3;
			this.bunifuMaterialTextbox1.Location = new global::System.Drawing.Point(59, 231);
			this.bunifuMaterialTextbox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
			this.bunifuMaterialTextbox1.Size = new global::System.Drawing.Size(230, 33);
			this.bunifuMaterialTextbox1.TabIndex = 1;
			this.bunifuMaterialTextbox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.bunifuMaterialTextbox1.OnValueChanged += new global::System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
			this.bunifuMaterialTextbox2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.bunifuMaterialTextbox2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox2.ForeColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox2.HintForeColor = global::System.Drawing.Color.LightGray;
			this.bunifuMaterialTextbox2.HintText = "Password";
			this.bunifuMaterialTextbox2.isPassword = true;
			this.bunifuMaterialTextbox2.LineFocusedColor = global::System.Drawing.Color.Silver;
			this.bunifuMaterialTextbox2.LineIdleColor = global::System.Drawing.Color.White;
			this.bunifuMaterialTextbox2.LineMouseHoverColor = global::System.Drawing.Color.Silver;
			this.bunifuMaterialTextbox2.LineThickness = 3;
			this.bunifuMaterialTextbox2.Location = new global::System.Drawing.Point(59, 272);
			this.bunifuMaterialTextbox2.Margin = new global::System.Windows.Forms.Padding(4);
			this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
			this.bunifuMaterialTextbox2.Size = new global::System.Drawing.Size(230, 33);
			this.bunifuMaterialTextbox2.TabIndex = 2;
			this.bunifuMaterialTextbox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.bunifuImageButton1.BackColor = global::System.Drawing.Color.FromArgb(40, 42, 60);
			this.bunifuImageButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuImageButton1.Image");
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new global::System.Drawing.Point(-1, 367);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new global::System.Drawing.Size(52, 46);
			this.bunifuImageButton1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 3;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new global::System.EventHandler(this.bunifuImageButton1_Click);
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(12, 231);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(40, 34);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new global::System.Drawing.Point(12, 272);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(40, 34);
			this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			this.panel1.Controls.Add(this.bunifuImageButton3);
			this.panel1.Controls.Add(this.bunifuImageButton2);
			this.panel1.Location = new global::System.Drawing.Point(-1, -3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(341, 49);
			this.panel1.TabIndex = 7;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.bunifuImageButton3.BackColor = global::System.Drawing.Color.FromArgb(40, 42, 60);
			this.bunifuImageButton3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuImageButton3.Image");
			this.bunifuImageButton3.ImageActive = null;
			this.bunifuImageButton3.Location = new global::System.Drawing.Point(241, 4);
			this.bunifuImageButton3.Name = "bunifuImageButton3";
			this.bunifuImageButton3.Size = new global::System.Drawing.Size(49, 45);
			this.bunifuImageButton3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton3.TabIndex = 1;
			this.bunifuImageButton3.TabStop = false;
			this.bunifuImageButton3.Zoom = 10;
			this.bunifuImageButton3.Click += new global::System.EventHandler(this.bunifuImageButton3_Click);
			this.bunifuImageButton2.BackColor = global::System.Drawing.Color.FromArgb(40, 42, 60);
			this.bunifuImageButton2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuImageButton2.Image");
			this.bunifuImageButton2.ImageActive = null;
			this.bunifuImageButton2.Location = new global::System.Drawing.Point(292, 4);
			this.bunifuImageButton2.Name = "bunifuImageButton2";
			this.bunifuImageButton2.Size = new global::System.Drawing.Size(49, 45);
			this.bunifuImageButton2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton2.TabIndex = 0;
			this.bunifuImageButton2.TabStop = false;
			this.bunifuImageButton2.Zoom = 10;
			this.bunifuImageButton2.Click += new global::System.EventHandler(this.bunifuImageButton2_Click);
			this.bunifuElipse1.ElipseRadius = 12;
			this.bunifuElipse1.TargetControl = this;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(86, 336);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(176, 58);
			this.button1.TabIndex = 4;
			this.button1.Text = "Connect";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(40, 42, 60);
			base.ClientSize = new global::System.Drawing.Size(338, 425);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.bunifuImageButton1);
			base.Controls.Add(this.bunifuMaterialTextbox2);
			base.Controls.Add(this.bunifuMaterialTextbox1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bunifuImageButton1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			this.panel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.bunifuImageButton3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bunifuImageButton2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000020 RID: 32
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000022 RID: 34
		private global::Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;

		// Token: 0x04000023 RID: 35
		private global::Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;

		// Token: 0x04000024 RID: 36
		private global::Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000028 RID: 40
		private global::Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;

		// Token: 0x04000029 RID: 41
		private global::Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;

		// Token: 0x0400002A RID: 42
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Button button1;
	}
}
