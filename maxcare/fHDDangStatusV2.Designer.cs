﻿namespace maxcare
{
	// Token: 0x020000BF RID: 191
	public partial class fHDDangStatusV2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000790 RID: 1936 RVA: 0x00115950 File Offset: 0x00113B50
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x001159B0 File Offset: 0x00113BB0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDDangStatusV2));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label19 = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.nudKhoangCachTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudKhoangCachFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label18 = new global::System.Windows.Forms.Label();
			this.label17 = new global::System.Windows.Forms.Label();
			this.nudSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label16 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.plVanBan = new global::System.Windows.Forms.Panel();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.btnDown = new global::MetroFramework.Controls.MetroButton();
			this.btnUp = new global::MetroFramework.Controls.MetroButton();
			this.rbNganCachKyTu = new global::System.Windows.Forms.RadioButton();
			this.rbNganCachMoiDong = new global::System.Windows.Forms.RadioButton();
			this.label9 = new global::System.Windows.Forms.Label();
			this.txtNoiDung = new global::System.Windows.Forms.RichTextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.plAnh = new global::System.Windows.Forms.Panel();
			this.nudSoLuongAnhTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongAnhFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label21 = new global::System.Windows.Forms.Label();
			this.txtPathAnh = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.ckbDangAnhTheoThuTu = new global::System.Windows.Forms.CheckBox();
			this.ckbAnh = new global::System.Windows.Forms.CheckBox();
			this.ckbVanBan = new global::System.Windows.Forms.CheckBox();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudKhoangCachTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKhoangCachFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
			this.plVanBan.SuspendLayout();
			this.plAnh.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhFrom).BeginInit();
			this.bunifuCards1.SuspendLayout();
			base.SuspendLayout();
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RURmFObHBGWXpWa1JsSklVbTFzWVZZelpEUT0="))))))));
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(361, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU0yaExVa1ZXYmsxcVZuVlRWV2hQVFVac1dWVnFSbXBsVlVsNVZGZGpPVkJSUFQwPQ=="))))))));
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.pnlHeader;
			this.bunifuDragControl2.Vertical = true;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.button1);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCak1XTXhUa2hXYldoaFVqRmFOUT09"))))))));
			this.pnlHeader.Size = new global::System.Drawing.Size(361, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1ZYcFdTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.button1.Location = new global::System.Drawing.Point(330, 1);
			this.button1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1ZWUXdPUT09"))))))));
			this.button1.Size = new global::System.Drawing.Size(30, 30);
			this.button1.TabIndex = 0;
			this.button1.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
			this.pictureBox1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaUVVUMDk="))))))));
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 76;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.nudKhoangCachTo);
			this.panel1.Controls.Add(this.nudKhoangCachFrom);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.nudSoLuongTo);
			this.panel1.Controls.Add(this.nudSoLuongFrom);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.plVanBan);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.plAnh);
			this.panel1.Controls.Add(this.ckbAnh);
			this.panel1.Controls.Add(this.ckbVanBan);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJjOQ=="))))))));
			this.panel1.Size = new global::System.Drawing.Size(364, 510);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.label19.AutoSize = true;
			this.label19.Location = new global::System.Drawing.Point(291, 108);
			this.label19.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUVZWUXdPUT09"))))))));
			this.label19.Size = new global::System.Drawing.Size(31, 16);
			this.label19.TabIndex = 43;
			this.label19.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.label20.Location = new global::System.Drawing.Point(205, 108);
			this.label20.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4T1VWUXdPUT09"))))))));
			this.label20.Size = new global::System.Drawing.Size(29, 16);
			this.label20.TabIndex = 42;
			this.label20.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NXRklWbmxQV0ZVOQ=="))))))));
			this.label20.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudKhoangCachTo.Location = new global::System.Drawing.Point(236, 106);
			this.nudKhoangCachTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxoU0ZwYVZucFdkVlZVU2tkaGJVWkhWVzVaUFE9PQ=="))))))));
			this.nudKhoangCachTo.Size = new global::System.Drawing.Size(51, 23);
			this.nudKhoangCachTo.TabIndex = 41;
			this.nudKhoangCachFrom.Location = new global::System.Drawing.Point(151, 106);
			this.nudKhoangCachFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxoU0ZwYVZucFdkVlZVU2tkaGJVWkdWMjVzYVUxcVFUaz0="))))))));
			this.nudKhoangCachFrom.Size = new global::System.Drawing.Size(51, 23);
			this.nudKhoangCachFrom.TabIndex = 40;
			this.label18.AutoSize = true;
			this.label18.Location = new global::System.Drawing.Point(291, 83);
			this.label18.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUVVWUXdPUT09"))))))));
			this.label18.Size = new global::System.Drawing.Size(25, 16);
			this.label18.TabIndex = 39;
			this.label18.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFoT1VGb3lSbEpRVkRBOQ=="))))))));
			this.label17.Location = new global::System.Drawing.Point(205, 83);
			this.label17.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUFpIb3dPUT09"))))))));
			this.label17.Size = new global::System.Drawing.Size(29, 16);
			this.label17.TabIndex = 38;
			this.label17.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NXRklWbmxQV0ZVOQ=="))))))));
			this.label17.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudSoLuongTo.Location = new global::System.Drawing.Point(236, 78);
			this.nudSoLuongTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxOa1p6MDk="))))))));
			this.nudSoLuongTo.Size = new global::System.Drawing.Size(51, 23);
			this.nudSoLuongTo.TabIndex = 37;
			this.nudSoLuongFrom.Location = new global::System.Drawing.Point(151, 78);
			this.nudSoLuongFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUW1GbFYwbDVUVVF3UFE9PQ=="))))))));
			this.nudSoLuongFrom.Size = new global::System.Drawing.Size(51, 23);
			this.nudSoLuongFrom.TabIndex = 36;
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(30, 108);
			this.label16.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUFdub3dPUT09"))))))));
			this.label16.Size = new global::System.Drawing.Size(117, 16);
			this.label16.TabIndex = 35;
			this.label16.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2IyUnFVbWxqVjNCcFlsZE9ibGRVYUZCaFJtdDVXakprTkZOcmFFWmFla2t4WW1zNWJsQlVNRDA9"))))))));
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(30, 83);
			this.label15.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUFZWUXdPUT09"))))))));
			this.label15.Size = new global::System.Drawing.Size(109, 16);
			this.label15.TabIndex = 34;
			this.label15.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNHlkRlJSYms0MFkydFNiMlJVV2s5a1ZuQTFVVzFzTTA1clNuZFRWV2hoWTBSU2FXTlRPV3RTUnpnNQ=="))))))));
			this.plVanBan.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plVanBan.Controls.Add(this.button3);
			this.plVanBan.Controls.Add(this.button2);
			this.plVanBan.Controls.Add(this.btnDown);
			this.plVanBan.Controls.Add(this.btnUp);
			this.plVanBan.Controls.Add(this.rbNganCachKyTu);
			this.plVanBan.Controls.Add(this.rbNganCachMoiDong);
			this.plVanBan.Controls.Add(this.label9);
			this.plVanBan.Controls.Add(this.txtNoiDung);
			this.plVanBan.Controls.Add(this.label8);
			this.plVanBan.Controls.Add(this.lblStatus);
			this.plVanBan.Location = new global::System.Drawing.Point(47, 159);
			this.plVanBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWXhiRmhPVlU1YVZucFJPUT09"))))))));
			this.plVanBan.Size = new global::System.Drawing.Size(278, 187);
			this.plVanBan.TabIndex = 33;
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button3.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.Location = new global::System.Drawing.Point(225, 209);
			this.button3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1pIb3dPUT09"))))))));
			this.button3.Size = new global::System.Drawing.Size(21, 23);
			this.button3.TabIndex = 40;
			this.button3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlVoak9WQlJQVDA9"))))))));
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(225, 186);
			this.button2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1dub3dPUT09"))))))));
			this.button2.Size = new global::System.Drawing.Size(21, 23);
			this.button2.TabIndex = 41;
			this.button2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlVoak9WQlJQVDA9"))))))));
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.btnDown.BackgroundImage = global::maxcare.Properties.Resources.icons8_expand_arrow_24px;
			this.btnDown.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnDown.Location = new global::System.Drawing.Point(221, -1);
			this.btnDown.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldTa2hQVkU1cFdub3dPUT09"))))))));
			this.btnDown.Size = new global::System.Drawing.Size(25, 25);
			this.btnDown.TabIndex = 38;
			this.btnDown.UseSelectable = true;
			this.btnDown.Click += new global::System.EventHandler(this.btnDown_Click);
			this.btnUp.BackgroundImage = global::maxcare.Properties.Resources.icons8_collapse_arrow_24px;
			this.btnUp.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnUp.Location = new global::System.Drawing.Point(252, -1);
			this.btnUp.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldXbGxSVkRBOQ=="))))))));
			this.btnUp.Size = new global::System.Drawing.Size(25, 25);
			this.btnUp.TabIndex = 39;
			this.btnUp.UseSelectable = true;
			this.btnUp.Click += new global::System.EventHandler(this.btnUp_Click);
			this.rbNganCachKyTu.AutoSize = true;
			this.rbNganCachKyTu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachKyTu.Location = new global::System.Drawing.Point(69, 210);
			this.rbNganCachKyTu.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUXhiM2xTYmxaU1RXdGFjVmxWVmpCT1ZscEpWbFF3UFE9PQ=="))))))));
			this.rbNganCachKyTu.Size = new global::System.Drawing.Size(160, 20);
			this.rbNganCachKyTu.TabIndex = 37;
			this.rbNganCachKyTu.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtoV1NFNHlNVmhoTW1SaFUwWmFNVmR1YkVOaGJtTXpWRmRrYVdKWGFIZE9SMG94VVcxU1ZGRnRkRE5PTUhBeFYyNWpPVkJSUFQwPQ=="))))))));
			this.rbNganCachKyTu.UseVisualStyleBackColor = true;
			this.rbNganCachKyTu.CheckedChanged += new global::System.EventHandler(this.rbNganCachKyTu_CheckedChanged);
			this.rbNganCachMoiDong.AutoSize = true;
			this.rbNganCachMoiDong.Checked = true;
			this.rbNganCachMoiDong.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachMoiDong.Location = new global::System.Drawing.Point(69, 189);
			this.rbNganCachMoiDong.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUXhiM2xTYmxaU1RXdGFjVmxWVlhoa2JVWldWVzVhYVdKWFRUaz0="))))))));
			this.rbNganCachMoiDong.Size = new global::System.Drawing.Size(156, 20);
			this.rbNganCachMoiDong.TabIndex = 36;
			this.rbNganCachMoiDong.TabStop = true;
			this.rbNganCachMoiDong.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtoV1NFNHlNVmhoTW1SaFUwWmFNVmR1YkVOaGJVWlFVbnBrY0ZVd1NuRmtlbVJPV2pBeFZGRnRkRE5PTUhBeFYyNWpPVkJSUFQwPQ=="))))))));
			this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
			this.rbNganCachMoiDong.CheckedChanged += new global::System.EventHandler(this.rbNganCachMoiDong_CheckedChanged);
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(4, 189);
			this.label9.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxVOQ=="))))))));
			this.label9.Size = new global::System.Drawing.Size(65, 16);
			this.label9.TabIndex = 35;
			this.label9.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVFNVhWbFJSYlhCb1ZEQmpNMkZzWXpCT1p6MDk="))))))));
			this.label9.Click += new global::System.EventHandler(this.label9_Click);
			this.txtNoiDung.Location = new global::System.Drawing.Point(7, 24);
			this.txtNoiDung.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdVblJQV0VKVFUwWmFNVmR1WXpsUVVUMDk="))))))));
			this.txtNoiDung.Size = new global::System.Drawing.Size(263, 137);
			this.txtNoiDung.TabIndex = 34;
			this.txtNoiDung.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(""))))))));
			this.txtNoiDung.WordWrap = false;
			this.txtNoiDung.TextChanged += new global::System.EventHandler(this.txtNoiDung_TextChanged);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(2, 164);
			this.label8.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxFOQ=="))))))));
			this.label8.Size = new global::System.Drawing.Size(144, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VXpCYVQyUXlSbGhPUjJScFpGVmpNMkpXWkhKYU1YQkpWbTVXWVdWVlNUTlhWbWcwWVZkYVNGUnFiRXhWVkRBNQ=="))))))));
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(3, 5);
			this.lblStatus.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhWWHBWYldoclUwWmFOZz09"))))))));
			this.lblStatus.Size = new global::System.Drawing.Size(146, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1rcDZWSHBDTmxNd05YZFRWV1JUVFZkS2RGa3laRXhTUlVaM1ZESmpPVkJSUFQwPQ=="))))))));
			this.btnAdd.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(85, 465);
			this.btnAdd.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSbGhWYlhNOQ=="))))))));
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSklSblJOUkRBOQ=="))))))));
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.plAnh.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plAnh.Controls.Add(this.nudSoLuongAnhTo);
			this.plAnh.Controls.Add(this.nudSoLuongAnhFrom);
			this.plAnh.Controls.Add(this.label2);
			this.plAnh.Controls.Add(this.label4);
			this.plAnh.Controls.Add(this.label21);
			this.plAnh.Controls.Add(this.txtPathAnh);
			this.plAnh.Controls.Add(this.label3);
			this.plAnh.Controls.Add(this.ckbDangAnhTheoThuTu);
			this.plAnh.Location = new global::System.Drawing.Point(47, 372);
			this.plAnh.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GRnRTblJhZWpBOQ=="))))))));
			this.plAnh.Size = new global::System.Drawing.Size(278, 82);
			this.plAnh.TabIndex = 33;
			this.nudSoLuongAnhTo.Location = new global::System.Drawing.Point(206, 30);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudSoLuongAnhTo;
			int[] array = new int[4];
			array[0] = 99999;
			numericUpDown.Maximum = new decimal(array);
			this.nudSoLuongAnhTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkhWVzVaUFE9PQ=="))))))));
			this.nudSoLuongAnhTo.Size = new global::System.Drawing.Size(45, 23);
			this.nudSoLuongAnhTo.TabIndex = 7;
			this.nudSoLuongAnhFrom.Location = new global::System.Drawing.Point(129, 30);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudSoLuongAnhFrom;
			int[] array2 = new int[4];
			array2[0] = 99999;
			numericUpDown2.Maximum = new decimal(array2);
			this.nudSoLuongAnhFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkdWMjVzYVUxcVFUaz0="))))))));
			this.nudSoLuongAnhFrom.Size = new global::System.Drawing.Size(45, 23);
			this.nudSoLuongAnhFrom.TabIndex = 8;
			this.label2.Location = new global::System.Drawing.Point(177, 32);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(29, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NXRklWbmxQV0ZVOQ=="))))))));
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(249, 32);
			this.label4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtFOQ=="))))))));
			this.label4.Size = new global::System.Drawing.Size(29, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFkT05WTnRTblJhZWpBOQ=="))))))));
			this.label21.AutoSize = true;
			this.label21.Location = new global::System.Drawing.Point(3, 32);
			this.label21.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4T1ZWUXdPUT09"))))))));
			this.label21.Size = new global::System.Drawing.Size(111, 16);
			this.label21.TabIndex = 6;
			this.label21.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxU2xJd2FFNWhWbU14WWpCM2VWUkZVblpTTW5NeQ=="))))))));
			this.txtPathAnh.Location = new global::System.Drawing.Point(136, 2);
			this.txtPathAnh.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VsVmFNVmxWUlRsUVVUMDk="))))))));
			this.txtPathAnh.Size = new global::System.Drawing.Size(138, 23);
			this.txtPathAnh.TabIndex = 1;
			this.txtPathAnh.TextChanged += new global::System.EventHandler(this.txtPathAnh_TextChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(3, 5);
			this.label3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTI4OQ=="))))))));
			this.label3.Size = new global::System.Drawing.Size(138, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSXpUbEJTZW1SMVZucFdkVk5WWkZWaFNGWjRaRWhXU2xJeGNESlphMlJUWWtkT2NGSkhhREZqVlRVeFdWVlNkbEJSUFQwPQ=="))))))));
			this.ckbDangAnhTheoThuTu.AutoSize = true;
			this.ckbDangAnhTheoThuTu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbDangAnhTheoThuTu.Location = new global::System.Drawing.Point(7, 57);
			this.ckbDangAnhTheoThuTu.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldTa2hTYmxaaFRVVmFNVmxWV2xOaU1YQllUMVpXYUZOR1dsWmFSa1U1VUZFOVBRPT0="))))))));
			this.ckbDangAnhTheoThuTu.Size = new global::System.Drawing.Size(171, 20);
			this.ckbDangAnhTheoThuTu.TabIndex = 32;
			this.ckbDangAnhTheoThuTu.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VqRndkMWxyWkZaYU1XeHFaVlZ3YVdKWFpHNWFSV1J2WWtkS05WRnFRbWhVVjBZelpXdHNSbG95VWs1WldHUTJVekF3T1E9PQ=="))))))));
			this.ckbDangAnhTheoThuTu.UseVisualStyleBackColor = true;
			this.ckbAnh.AutoSize = true;
			this.ckbAnh.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbAnh.Location = new global::System.Drawing.Point(33, 350);
			this.ckbAnh.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSbGhPVnpnOQ=="))))))));
			this.ckbAnh.Size = new global::System.Drawing.Size(49, 20);
			this.ckbAnh.TabIndex = 32;
			this.ckbAnh.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZkT05WTnRTblJhZWpBOQ=="))))))));
			this.ckbAnh.UseVisualStyleBackColor = true;
			this.ckbAnh.CheckedChanged += new global::System.EventHandler(this.ckbAnh_CheckedChanged);
			this.ckbVanBan.AutoSize = true;
			this.ckbVanBan.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbVanBan.Location = new global::System.Drawing.Point(33, 135);
			this.ckbVanBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXblJTYmxaU1lsVmFNUT09"))))))));
			this.ckbVanBan.Size = new global::System.Drawing.Size(74, 20);
			this.ckbVanBan.TabIndex = 32;
			this.ckbVanBan.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm01T1ZGSkhTbkJSYld4YVdUTnNTMWx0WXpsUVVUMDk="))))))));
			this.ckbVanBan.UseVisualStyleBackColor = true;
			this.ckbVanBan.CheckedChanged += new global::System.EventHandler(this.ckbVanBan_CheckedChanged);
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(151, 49);
			this.txtTenHanhDong.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdXa2hXYmxaVVVqQmFNVmxWVmxOa2JVcDBXWG93UFE9PQ=="))))))));
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(174, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(30, 52);
			this.label1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJjOQ=="))))))));
			this.label1.Size = new global::System.Drawing.Size(99, 16);
			this.label1.TabIndex = 31;
			this.label1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVHTlhTbkJSYlRsYVdUTnNRbGx0TVc1YU0yaExVMFZTTUZSWWJIRlpiVEZxVG1jOVBRPT0="))))))));
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(184, 465);
			this.btnCancel.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxTYmxaYVRXeGFlZz09"))))))));
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSklUWGxPVnpROQ=="))))))));
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.bunifuCards1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.DarkViolet;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(1, 0);
			this.bunifuCards1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RXdGFOVmRyYUU1bFFUMDk="))))))));
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(361, 37);
			this.bunifuCards1.TabIndex = 28;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(364, 510);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMGIxSldTa2hTYmxaaFRWVTBkMWRXYUZOTlYwMTRWMWhyUFE9PQ=="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1sSk9XVmhrTkdOVldqRlhibXhEVFVoak1sSnRiejA9"))))))));
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudKhoangCachTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKhoangCachFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
			this.plVanBan.ResumeLayout(false);
			this.plVanBan.PerformLayout();
			this.plAnh.ResumeLayout(false);
			this.plAnh.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongAnhFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040008E8 RID: 2280
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040008E9 RID: 2281
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040008EA RID: 2282
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040008EB RID: 2283
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040008EC RID: 2284
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x040008ED RID: 2285
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040008EE RID: 2286
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040008EF RID: 2287
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040008F0 RID: 2288
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040008F1 RID: 2289
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040008F2 RID: 2290
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040008F3 RID: 2291
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040008F4 RID: 2292
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040008F5 RID: 2293
		private global::System.Windows.Forms.CheckBox ckbAnh;

		// Token: 0x040008F6 RID: 2294
		private global::System.Windows.Forms.CheckBox ckbVanBan;

		// Token: 0x040008F7 RID: 2295
		private global::System.Windows.Forms.Panel plVanBan;

		// Token: 0x040008F8 RID: 2296
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040008F9 RID: 2297
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x040008FA RID: 2298
		private global::System.Windows.Forms.Panel plAnh;

		// Token: 0x040008FB RID: 2299
		private global::System.Windows.Forms.TextBox txtPathAnh;

		// Token: 0x040008FC RID: 2300
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040008FD RID: 2301
		private global::System.Windows.Forms.RichTextBox txtNoiDung;

		// Token: 0x040008FE RID: 2302
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x040008FF RID: 2303
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04000900 RID: 2304
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000901 RID: 2305
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x04000902 RID: 2306
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x04000903 RID: 2307
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000904 RID: 2308
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000905 RID: 2309
		private global::System.Windows.Forms.NumericUpDown nudKhoangCachTo;

		// Token: 0x04000906 RID: 2310
		private global::System.Windows.Forms.NumericUpDown nudKhoangCachFrom;

		// Token: 0x04000907 RID: 2311
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000908 RID: 2312
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000909 RID: 2313
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x0400090A RID: 2314
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x0400090B RID: 2315
		private global::System.Windows.Forms.Label label16;

		// Token: 0x0400090C RID: 2316
		private global::System.Windows.Forms.Label label15;

		// Token: 0x0400090D RID: 2317
		private global::System.Windows.Forms.NumericUpDown nudSoLuongAnhTo;

		// Token: 0x0400090E RID: 2318
		private global::System.Windows.Forms.NumericUpDown nudSoLuongAnhFrom;

		// Token: 0x0400090F RID: 2319
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000910 RID: 2320
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000911 RID: 2321
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000912 RID: 2322
		private global::System.Windows.Forms.CheckBox ckbDangAnhTheoThuTu;

		// Token: 0x04000913 RID: 2323
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000914 RID: 2324
		private global::System.Windows.Forms.Button button2;
	}
}
