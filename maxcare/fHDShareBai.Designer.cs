namespace maxcare
{
	// Token: 0x020000C6 RID: 198
	public partial class fHDShareBai : global::System.Windows.Forms.Form
	{
		// Token: 0x060007FA RID: 2042 RVA: 0x00132700 File Offset: 0x00130900
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00132760 File Offset: 0x00130960
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDShareBai));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.rbShareVip = new global::System.Windows.Forms.RadioButton();
			this.rbShareThuong = new global::System.Windows.Forms.RadioButton();
			this.label3 = new global::System.Windows.Forms.Label();
			this.ckbKhongPhaiLinkFacebook = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtLinkChiaSe = new global::System.Windows.Forms.TextBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.plDangBaiLenPage = new global::System.Windows.Forms.Panel();
			this.label21 = new global::System.Windows.Forms.Label();
			this.label22 = new global::System.Windows.Forms.Label();
			this.nudCountPageTo = new global::System.Windows.Forms.NumericUpDown();
			this.label23 = new global::System.Windows.Forms.Label();
			this.nudCountPageFrom = new global::System.Windows.Forms.NumericUpDown();
			this.plDangBaiLenNhom = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.ckbKhongShareTrung = new global::System.Windows.Forms.CheckBox();
			this.ckbUuTienNhomNhieuThanhVien = new global::System.Windows.Forms.CheckBox();
			this.ckbOnlyShareNhomKhongKiemDuyet = new global::System.Windows.Forms.CheckBox();
			this.ckbCauHinhNangCao = new global::System.Windows.Forms.CheckBox();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.button8 = new global::System.Windows.Forms.Button();
			this.rbTuNhap = new global::System.Windows.Forms.RadioButton();
			this.rbRandom = new global::System.Windows.Forms.RadioButton();
			this.label11 = new global::System.Windows.Forms.Label();
			this.plInteractGroup = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.button7 = new global::System.Windows.Forms.Button();
			this.linkLabel2 = new global::System.Windows.Forms.LinkLabel();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.radioButton1 = new global::System.Windows.Forms.RadioButton();
			this.radioButton2 = new global::System.Windows.Forms.RadioButton();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.txtComment = new global::System.Windows.Forms.RichTextBox();
			this.lblComment = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label53 = new global::System.Windows.Forms.Label();
			this.nudTuongTacTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudTuongTacDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label7 = new global::System.Windows.Forms.Label();
			this.nudTuongTacFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label52 = new global::System.Windows.Forms.Label();
			this.ckbTuongTacComment = new global::System.Windows.Forms.CheckBox();
			this.nudTuongTacDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label51 = new global::System.Windows.Forms.Label();
			this.ckbTuongTacLike = new global::System.Windows.Forms.CheckBox();
			this.label50 = new global::System.Windows.Forms.Label();
			this.ckbTuongTac = new global::System.Windows.Forms.CheckBox();
			this.nudCountGroupTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudCountGroupFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label24 = new global::System.Windows.Forms.Label();
			this.label25 = new global::System.Windows.Forms.Label();
			this.label26 = new global::System.Windows.Forms.Label();
			this.ckbShareBaiLenPage = new global::System.Windows.Forms.CheckBox();
			this.ckbShareBaiLenNhom = new global::System.Windows.Forms.CheckBox();
			this.ckbShareBaiLenTuong = new global::System.Windows.Forms.CheckBox();
			this.nudDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label20 = new global::System.Windows.Forms.Label();
			this.label19 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.plVanBan = new global::System.Windows.Forms.Panel();
			this.button6 = new global::System.Windows.Forms.Button();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.rbNganCachKyTu = new global::System.Windows.Forms.RadioButton();
			this.rbNganCachMoiDong = new global::System.Windows.Forms.RadioButton();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.btnDown = new global::MetroFramework.Controls.MetroButton();
			this.btnUp = new global::MetroFramework.Controls.MetroButton();
			this.txtNoiDung = new global::System.Windows.Forms.RichTextBox();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.ckbVanBan = new global::System.Windows.Forms.CheckBox();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.plDangBaiLenPage.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountPageTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).BeginInit();
			this.plDangBaiLenNhom.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.plInteractGroup.SuspendLayout();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountGroupFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).BeginInit();
			this.plVanBan.SuspendLayout();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(1097, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1WVjVZVWRvYW1KV1ZtNVhXRTVRV2pKR1VsQlVNRDA9"))))))));
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
			this.pnlHeader.Size = new global::System.Drawing.Size(1097, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1ZYcFdTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.button1.Location = new global::System.Drawing.Point(1066, 1);
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
			this.panel1.Controls.Add(this.rbShareVip);
			this.panel1.Controls.Add(this.rbShareThuong);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.ckbKhongPhaiLinkFacebook);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtLinkChiaSe);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.nudDelayTo);
			this.panel1.Controls.Add(this.nudDelayFrom);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.plVanBan);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.ckbVanBan);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJjOQ=="))))))));
			this.panel1.Size = new global::System.Drawing.Size(1100, 612);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.rbShareVip.AutoSize = true;
			this.rbShareVip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbShareVip.Location = new global::System.Drawing.Point(203, 237);
			this.rbShareVip.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxWkhSa2hTYm14aFZteHdkMWt3UlRsUVVUMDk="))))))));
			this.rbShareVip.Size = new global::System.Drawing.Size(82, 20);
			this.rbShareVip.TabIndex = 68;
			this.rbShareVip.TabStop = true;
			this.rbShareVip.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSS2IyRkhUblJXVjJSWFlsZDRNdz09"))))))));
			this.rbShareVip.UseVisualStyleBackColor = true;
			this.rbShareVip.CheckedChanged += new global::System.EventHandler(this.rbShareVip_CheckedChanged);
			this.rbShareThuong.AutoSize = true;
			this.rbShareThuong.Checked = true;
			this.rbShareThuong.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbShareThuong.Location = new global::System.Drawing.Point(90, 237);
			this.rbShareThuong.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxWkhSa2hTYm14aFZteEtkbHBHWXpWa1ZuQXpVRlF3UFE9PQ=="))))))));
			this.rbShareThuong.Size = new global::System.Drawing.Size(104, 20);
			this.rbShareThuong.TabIndex = 67;
			this.rbShareThuong.TabStop = true;
			this.rbShareThuong.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSS2IyRkhUblJXVjJSclVqSndTR013T1VoT01qVllUbGMwUFE9PQ=="))))))));
			this.rbShareThuong.UseVisualStyleBackColor = true;
			this.rbShareThuong.CheckedChanged += new global::System.EventHandler(this.rbShareThuong_CheckedChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(11, 239);
			this.label3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTI4OQ=="))))))));
			this.label3.Size = new global::System.Drawing.Size(73, 16);
			this.label3.TabIndex = 66;
			this.label3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2RXRklWVEJVYWtaS1UwVTFkbGRXYUV0aVJUbHVVRlF3UFE9PQ=="))))))));
			this.ckbKhongPhaiLinkFacebook.AutoSize = true;
			this.ckbKhongPhaiLinkFacebook.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbKhongPhaiLinkFacebook.Location = new global::System.Drawing.Point(14, 270);
			this.ckbKhongPhaiLinkFacebook.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNVbGxWWkVkalJsSklZa2hXYUUxR2NHOVhWRXBYWVZkSmVVOVlTVDA9"))))))));
			this.ckbKhongPhaiLinkFacebook.Size = new global::System.Drawing.Size(265, 20);
			this.ckbKhongPhaiLinkFacebook.TabIndex = 65;
			this.ckbKhongPhaiLinkFacebook.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWa2MyUlhSalZSYlc4d1dXNUdkVmx0YkVOaGJVWklZa2RvU2xOR1FtOWtXRXA2V2pKRmVXRnJVakJTZWxaMVUxVm9RMko2VW1salYzQm9WVEJLY1U1SFNqRmliR3hVVVd0a1dsWXdOWE5YVnpBMVpHMUdNMUJVTUQwPQ=="))))))));
			this.ckbKhongPhaiLinkFacebook.UseVisualStyleBackColor = true;
			this.ckbKhongPhaiLinkFacebook.CheckedChanged += new global::System.EventHandler(this.ckbKhongPhaiLinkFacebook_CheckedChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(11, 116);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(137, 16);
			this.label2.TabIndex = 64;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWa2MyUlhSalZSYld3elRtdEtkMU5WWkZGaFNGWjRXa2hXU2xORk5YWlhWbWhMWWtWc1JGb3paRXhXUnpnNQ=="))))))));
			this.txtLinkChiaSe.Location = new global::System.Drawing.Point(14, 136);
			this.txtLinkChiaSe.Multiline = true;
			this.txtLinkChiaSe.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1RVVTFkbGxXWkVkV1JuQlNVRlF3UFE9PQ=="))))))));
			this.txtLinkChiaSe.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtLinkChiaSe.Size = new global::System.Drawing.Size(378, 98);
			this.txtLinkChiaSe.TabIndex = 63;
			this.txtLinkChiaSe.WordWrap = false;
			this.txtLinkChiaSe.TextChanged += new global::System.EventHandler(this.txtLinkChiaSe_TextChanged);
			this.groupBox2.Controls.Add(this.plDangBaiLenPage);
			this.groupBox2.Controls.Add(this.plDangBaiLenNhom);
			this.groupBox2.Controls.Add(this.ckbShareBaiLenPage);
			this.groupBox2.Controls.Add(this.ckbShareBaiLenNhom);
			this.groupBox2.Controls.Add(this.ckbShareBaiLenTuong);
			this.groupBox2.Location = new global::System.Drawing.Point(407, 94);
			this.groupBox2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwT1MyUnRVbGxSYTA1cFRUSmtOUT09"))))))));
			this.groupBox2.Size = new global::System.Drawing.Size(679, 459);
			this.groupBox2.TabIndex = 62;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVFNVhWbFJSYlhCb1ZEQmpNMkZzWXpCYU1rMTVZVWRvYW1KV1ZUaz0="))))))));
			this.plDangBaiLenPage.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.plDangBaiLenPage.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plDangBaiLenPage.Controls.Add(this.label21);
			this.plDangBaiLenPage.Controls.Add(this.label22);
			this.plDangBaiLenPage.Controls.Add(this.nudCountPageTo);
			this.plDangBaiLenPage.Controls.Add(this.label23);
			this.plDangBaiLenPage.Controls.Add(this.nudCountPageFrom);
			this.plDangBaiLenPage.Location = new global::System.Drawing.Point(35, 427);
			this.plDangBaiLenPage.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GSldiRmhPVnpWU1lsVmFkMVpGWkZka1ZsWklVbTAxWVZWVU1Eaz0="))))))));
			this.plDangBaiLenPage.Size = new global::System.Drawing.Size(310, 27);
			this.plDangBaiLenPage.TabIndex = 1;
			this.label21.AutoSize = true;
			this.label21.Location = new global::System.Drawing.Point(3, 3);
			this.label21.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4T1ZWUXdPUT09"))))))));
			this.label21.Size = new global::System.Drawing.Size(96, 16);
			this.label21.TabIndex = 49;
			this.label21.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNHlkRlJSYms0MFkydFNiMlJVV2s5a1ZuQTFVVzVrV2xZeVVuTlVNbU01VUZFOVBRPT0="))))))));
			this.label22.AutoSize = true;
			this.label22.Location = new global::System.Drawing.Point(264, 3);
			this.label22.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4T1dub3dPUT09"))))))));
			this.label22.Size = new global::System.Drawing.Size(36, 16);
			this.label22.TabIndex = 50;
			this.label22.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IySnNjRkpRVkRBOQ=="))))))));
			this.nudCountPageTo.Location = new global::System.Drawing.Point(205, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudCountPageTo;
			int[] array = new int[4];
			array[0] = 999999;
			numericUpDown.Maximum = new decimal(array);
			this.nudCountPageTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtVbGRXWkd0aVJscElUMFF3UFE9PQ=="))))))));
			this.nudCountPageTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountPageTo.TabIndex = 48;
			this.label23.AutoSize = true;
			this.label23.Location = new global::System.Drawing.Point(170, 3);
			this.label23.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4T1pIb3dPUT09"))))))));
			this.label23.Size = new global::System.Drawing.Size(29, 16);
			this.label23.TabIndex = 51;
			this.label23.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.nudCountPageFrom.Location = new global::System.Drawing.Point(108, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudCountPageFrom;
			int[] array2 = new int[4];
			array2[0] = 999999;
			numericUpDown2.Maximum = new decimal(array2);
			this.nudCountPageFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtVbGRXWkd0aVJrcDFVMjVhYVZWVU1Eaz0="))))))));
			this.nudCountPageFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountPageFrom.TabIndex = 47;
			this.plDangBaiLenNhom.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plDangBaiLenNhom.Controls.Add(this.panel4);
			this.plDangBaiLenNhom.Controls.Add(this.ckbCauHinhNangCao);
			this.plDangBaiLenNhom.Controls.Add(this.panel3);
			this.plDangBaiLenNhom.Controls.Add(this.label11);
			this.plDangBaiLenNhom.Controls.Add(this.plInteractGroup);
			this.plDangBaiLenNhom.Controls.Add(this.ckbTuongTac);
			this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupTo);
			this.plDangBaiLenNhom.Controls.Add(this.nudCountGroupFrom);
			this.plDangBaiLenNhom.Controls.Add(this.label24);
			this.plDangBaiLenNhom.Controls.Add(this.label25);
			this.plDangBaiLenNhom.Controls.Add(this.label26);
			this.plDangBaiLenNhom.Location = new global::System.Drawing.Point(33, 72);
			this.plDangBaiLenNhom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GSldiRmhPVnpWU1lsVmFkMVpGWkZka1ZsSjBZVWhhYVZWVU1Eaz0="))))))));
			this.plDangBaiLenNhom.Size = new global::System.Drawing.Size(637, 323);
			this.plDangBaiLenNhom.TabIndex = 1;
			this.panel4.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.ckbKhongShareTrung);
			this.panel4.Controls.Add(this.ckbUuTienNhomNhieuThanhVien);
			this.panel4.Controls.Add(this.ckbOnlyShareNhomKhongKiemDuyet);
			this.panel4.Location = new global::System.Drawing.Point(19, 138);
			this.panel4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrZWtFOQ=="))))))));
			this.panel4.Size = new global::System.Drawing.Size(287, 78);
			this.panel4.TabIndex = 69;
			this.ckbKhongShareTrung.AutoSize = true;
			this.ckbKhongShareTrung.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbKhongShareTrung.Location = new global::System.Drawing.Point(3, 55);
			this.ckbKhongShareTrung.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNWVmxWWkVkbFZuQlhWVzVzYTFaNlZuVT0="))))))));
			this.ckbKhongShareTrung.Size = new global::System.Drawing.Size(168, 20);
			this.ckbKhongShareTrung.TabIndex = 2;
			this.ckbKhongShareTrung.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwVTFkbGRXYUV0aVJXeEpWVzVzTTA0eWVERlhibXhEWkZkR1RsUXpjR2xWVkRBNQ=="))))))));
			this.ckbKhongShareTrung.UseVisualStyleBackColor = true;
			this.ckbUuTienNhomNhieuThanhVien.AutoSize = true;
			this.ckbUuTienNhomNhieuThanhVien.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbUuTienNhomNhieuThanhVien.Location = new global::System.Drawing.Point(3, 29);
			this.ckbUuTienNhomNhieuThanhVien.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXbGxXYkZab1ZqRmFNVlpITVc5a2JVcFdUbGM1YUZZeFdYaFdhMlJ2WVVkS2RHRkdaR2hXTVZveA=="))))))));
			this.ckbUuTienNhomNhieuThanhVien.Size = new global::System.Drawing.Size(255, 20);
			this.ckbUuTienNhomNhieuThanhVien.TabIndex = 1;
			this.ckbUuTienNhomNhieuThanhVien.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVoRk5VMVZiRWxWYmtJelRtNUNNVk5WYUU5aU1XeFpVMjE0U2xKNlZuWmtlbVJQWkVWc1NGVkZVbnBsVlVveFdWVmtkV0ZJVlRCU2FrWktVMFpLZG1SNldrTmtWMFpFVVdwS2FGa3dPWGhaYldNNVVGRTlQUT09"))))))));
			this.ckbUuTienNhomNhieuThanhVien.UseVisualStyleBackColor = true;
			this.ckbOnlyShareNhomKhongKiemDuyet.AutoSize = true;
			this.ckbOnlyShareNhomKhongKiemDuyet.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbOnlyShareNhomKhongKiemDuyet.Location = new global::System.Drawing.Point(3, 3);
			this.ckbOnlyShareNhomKhongKiemDuyet.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldVWGxPV0U1c1ZtczFkbGRXYUV0aVJsSjBZVWhhYVZaWVVuWlpha2t4WW14TmVXSkhlR2xXVmtsNFdsWmtWMDFCUFQwPQ=="))))))));
			this.ckbOnlyShareNhomKhongKiemDuyet.Size = new global::System.Drawing.Size(221, 20);
			this.ckbOnlyShareNhomKhongKiemDuyet.TabIndex = 0;
			this.ckbOnlyShareNhomKhongKiemDuyet.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEJoTW1ScVRXMW9iMWt5TVZaYU1rcDBZV3RTZWsxcVFtNVpWRXB4VWtoU1NFNVhOVXBTTTFKM1RrZEtNVkpIU2xSUmJYUnJWMGMxYjJSVVVtdE5RVDA5"))))))));
			this.ckbOnlyShareNhomKhongKiemDuyet.UseVisualStyleBackColor = true;
			this.ckbCauHinhNangCao.AutoSize = true;
			this.ckbCauHinhNangCao.Location = new global::System.Drawing.Point(6, 115);
			this.ckbCauHinhNangCao.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSWGxTYWtaVVVqSjRNVmxWVlRGaFIwcDBXa1ZTV2xaNlp6az0="))))))));
			this.ckbCauHinhNangCao.Size = new global::System.Drawing.Size(133, 20);
			this.ckbCauHinhNangCao.TabIndex = 68;
			this.ckbCauHinhNangCao.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1rcDZWREpzYVdKWFRtNVhWRXBIWkdjOVBRPT0="))))))));
			this.ckbCauHinhNangCao.UseVisualStyleBackColor = true;
			this.ckbCauHinhNangCao.CheckedChanged += new global::System.EventHandler(this.ckbCauHinhNangCao_CheckedChanged);
			this.panel3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.button8);
			this.panel3.Controls.Add(this.rbTuNhap);
			this.panel3.Controls.Add(this.rbRandom);
			this.panel3.Location = new global::System.Drawing.Point(19, 54);
			this.panel3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTI4OQ=="))))))));
			this.panel3.Size = new global::System.Drawing.Size(287, 54);
			this.panel3.TabIndex = 67;
			this.button8.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button8.Location = new global::System.Drawing.Point(207, 27);
			this.button8.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUVVWUXdPUT09"))))))));
			this.button8.Size = new global::System.Drawing.Size(75, 23);
			this.button8.TabIndex = 2;
			this.button8.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNXRklWbmhOV0dNOQ=="))))))));
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.rbTuNhap.AutoSize = true;
			this.rbTuNhap.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbTuNhap.Location = new global::System.Drawing.Point(3, 29);
			this.rbTuNhap.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxWlhVbFpPVnpsYVYwVkZPUT09"))))))));
			this.rbTuNhap.Size = new global::System.Drawing.Size(177, 20);
			this.rbTuNhap.TabIndex = 1;
			this.rbTuNhap.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSklUWGxOUjJSaFVucG9ibGx0TVcxU00wNVFVbnBrZFZZeWRHNVhhekZRVGxkS2RGa3laR2xpVjNCdlpGaEZlR1IzUFQwPQ=="))))))));
			this.rbTuNhap.UseVisualStyleBackColor = true;
			this.rbTuNhap.CheckedChanged += new global::System.EventHandler(this.rbTuNhap_CheckedChanged);
			this.rbRandom.AutoSize = true;
			this.rbRandom.Checked = true;
			this.rbRandom.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbRandom.Location = new global::System.Drawing.Point(3, 3);
			this.rbRandom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxVXhiRmhPVjNScFRXcEJPUT09"))))))));
			this.rbRandom.Size = new global::System.Drawing.Size(198, 20);
			this.rbRandom.TabIndex = 0;
			this.rbRandom.TabStop = true;
			this.rbRandom.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGJXRklWbmhrUkVaS1VucFdkbGxYVGxCalYwcHdVVzVXYUZSVk9UWlpiRTVGVWxkMGFsUXljRXBUUmtwMlYxWmpkMW94YjNsaVIyYzk="))))))));
			this.rbRandom.UseVisualStyleBackColor = true;
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(3, 35);
			this.label11.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1ZWUXdPUT09"))))))));
			this.label11.Size = new global::System.Drawing.Size(155, 16);
			this.label11.TabIndex = 66;
			this.label11.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVFNVhWbFJSYlhCb1ZEQmpNMkZzWXpCYU1rcDBZV3RTZWsxcVFtNWxSWEJKWVVoVk1GUlhaR3BOYldodldUSXhWazVuUFQwPQ=="))))))));
			this.plInteractGroup.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plInteractGroup.Controls.Add(this.panel2);
			this.plInteractGroup.Controls.Add(this.label5);
			this.plInteractGroup.Controls.Add(this.label6);
			this.plInteractGroup.Controls.Add(this.label53);
			this.plInteractGroup.Controls.Add(this.nudTuongTacTo);
			this.plInteractGroup.Controls.Add(this.nudTuongTacDelayTo);
			this.plInteractGroup.Controls.Add(this.label7);
			this.plInteractGroup.Controls.Add(this.nudTuongTacFrom);
			this.plInteractGroup.Controls.Add(this.label52);
			this.plInteractGroup.Controls.Add(this.ckbTuongTacComment);
			this.plInteractGroup.Controls.Add(this.nudTuongTacDelayFrom);
			this.plInteractGroup.Controls.Add(this.label51);
			this.plInteractGroup.Controls.Add(this.ckbTuongTacLike);
			this.plInteractGroup.Controls.Add(this.label50);
			this.plInteractGroup.Location = new global::System.Drawing.Point(338, 26);
			this.plInteractGroup.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GTnRTblZWYlhocVlsVmFjVnBGVm10bFYwbDZWbTVqUFE9PQ=="))))))));
			this.plInteractGroup.Size = new global::System.Drawing.Size(290, 280);
			this.plInteractGroup.TabIndex = 65;
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.button7);
			this.panel2.Controls.Add(this.linkLabel2);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Controls.Add(this.radioButton1);
			this.panel2.Controls.Add(this.radioButton2);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.txtComment);
			this.panel2.Controls.Add(this.lblComment);
			this.panel2.Location = new global::System.Drawing.Point(8, 101);
			this.panel2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJzOQ=="))))))));
			this.panel2.Size = new global::System.Drawing.Size(275, 168);
			this.panel2.TabIndex = 104;
			this.button7.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button7.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button7.Location = new global::System.Drawing.Point(244, 144);
			this.button7.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUFpIb3dPUT09"))))))));
			this.button7.Size = new global::System.Drawing.Size(23, 23);
			this.button7.TabIndex = 192;
			this.button7.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlVoak9WQlJQVDA9"))))))));
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.linkLabel2.Location = new global::System.Drawing.Point(164, 147);
			this.linkLabel2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a2MyUlhSWGRsUjJoYVlsWmFlbFJYWXpsUVVUMDk="))))))));
			this.linkLabel2.Size = new global::System.Drawing.Size(82, 16);
			this.linkLabel2.TabIndex = 191;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxjeFIyUldjRWhQV0ZKS1VqSjRjVmxxU1RCUVVUMDk="))))))));
			this.linkLabel2.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			this.button4.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button4.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.Location = new global::System.Drawing.Point(230, 189);
			this.button4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUFVWUXdPUT09"))))))));
			this.button4.Size = new global::System.Drawing.Size(21, 23);
			this.button4.TabIndex = 44;
			this.button4.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlVoak9WQlJQVDA9"))))))));
			this.button4.UseVisualStyleBackColor = true;
			this.button5.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button5.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button5.Location = new global::System.Drawing.Point(230, 166);
			this.button5.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUFZWUXdPUT09"))))))));
			this.button5.Size = new global::System.Drawing.Size(21, 23);
			this.button5.TabIndex = 45;
			this.button5.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlVoak9WQlJQVDA9"))))))));
			this.button5.UseVisualStyleBackColor = true;
			this.radioButton1.AutoSize = true;
			this.radioButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.radioButton1.Location = new global::System.Drawing.Point(71, 189);
			this.radioButton1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFIyRXlSbGhQVlU1clYwWkpkMWxxU1RCbFFUMDk="))))))));
			this.radioButton1.Size = new global::System.Drawing.Size(160, 20);
			this.radioButton1.TabIndex = 42;
			this.radioButton1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtoV1NFNHlNVmhoTW1SaFUwWmFNVmR1YkVOaGJtTXpWRmRrYVdKWGFIZE9SMG94VVcxU1ZGRnRkRE5PTUhBeFYyNWpPVkJSUFQwPQ=="))))))));
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton2.AutoSize = true;
			this.radioButton2.Checked = true;
			this.radioButton2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.radioButton2.Location = new global::System.Drawing.Point(71, 168);
			this.radioButton2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFIyRXlSbGhQVlU1clYwWkpkMWxxU1RCbFVUMDk="))))))));
			this.radioButton2.Size = new global::System.Drawing.Size(156, 20);
			this.radioButton2.TabIndex = 43;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtoV1NFNHlNVmhoTW1SaFUwWmFNVmR1YkVOaGJVWlFVbnBrY0ZVd1NuRmtlbVJPV2pBeFZGRnRkRE5PTUhBeFYyNWpPVkJSUFQwPQ=="))))))));
			this.radioButton2.UseVisualStyleBackColor = true;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(6, 168);
			this.label4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtFOQ=="))))))));
			this.label4.Size = new global::System.Drawing.Size(65, 16);
			this.label4.TabIndex = 41;
			this.label4.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVFNVhWbFJSYlhCb1ZEQmpNMkZzWXpCT1p6MDk="))))))));
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(5, 147);
			this.label10.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1VWUXdPUT09"))))))));
			this.label10.Size = new global::System.Drawing.Size(144, 16);
			this.label10.TabIndex = 40;
			this.label10.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VXpCYVQyUXlSbGhPUjJScFpGVmpNMkpXWkhKYU1YQkpWbTVXWVdWVlNUTlhWbWcwWVZkYVNGUnFiRXhWVkRBNQ=="))))))));
			this.txtComment.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtComment.Location = new global::System.Drawing.Point(7, 26);
			this.txtComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdSWGxQV0ZKcFZqRmFNVnBGUlRsUVVUMDk="))))))));
			this.txtComment.Size = new global::System.Drawing.Size(260, 119);
			this.txtComment.TabIndex = 34;
			this.txtComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(""))))))));
			this.txtComment.WordWrap = false;
			this.txtComment.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged);
			this.lblComment.AutoSize = true;
			this.lblComment.Location = new global::System.Drawing.Point(3, 5);
			this.lblComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhSWGxQV0ZKcFZqRmFNVnBGUlRsUVVUMDk="))))))));
			this.lblComment.Size = new global::System.Drawing.Size(150, 16);
			this.lblComment.TabIndex = 0;
			this.lblComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1XdDVUMWhTYVZZeFdqRmFSVTVDWWpBeFJHRjZXVDA9"))))))));
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label5.Location = new global::System.Drawing.Point(3, 6);
			this.label5.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtVOQ=="))))))));
			this.label5.Size = new global::System.Drawing.Size(110, 16);
			this.label5.TabIndex = 99;
			this.label5.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJSYVlsVm9UbG93WkhKYU1sSjBZbTFvTVdOcWEzZFVSRWt4WWpOak0xUnVVbEJhZWpBNQ=="))))))));
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label6.Location = new global::System.Drawing.Point(160, 7);
			this.label6.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtrOQ=="))))))));
			this.label6.Size = new global::System.Drawing.Size(29, 16);
			this.label6.TabIndex = 103;
			this.label6.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label53.AutoSize = true;
			this.label53.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label53.Location = new global::System.Drawing.Point(160, 33);
			this.label53.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaT1pIb3dPUT09"))))))));
			this.label53.Size = new global::System.Drawing.Size(29, 16);
			this.label53.TabIndex = 103;
			this.label53.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.nudTuongTacTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacTo.Location = new global::System.Drawing.Point(190, 4);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudTuongTacTo;
			int[] array3 = new int[4];
			array3[0] = 1000;
			numericUpDown3.Maximum = new decimal(array3);
			this.nudTuongTacTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5V1Ywb3pVRlF3UFE9PQ=="))))))));
			this.nudTuongTacTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacTo.TabIndex = 94;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudTuongTacTo;
			int[] array4 = new int[4];
			array4[0] = 10;
			numericUpDown4.Value = new decimal(array4);
			this.nudTuongTacDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacDelayTo.Location = new global::System.Drawing.Point(190, 30);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.nudTuongTacDelayTo;
			int[] array5 = new int[4];
			array5[0] = 1000;
			numericUpDown5.Maximum = new decimal(array5);
			this.nudTuongTacDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1ZuQllaVWRvYkZac1NqST0="))))))));
			this.nudTuongTacDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacDelayTo.TabIndex = 94;
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.nudTuongTacDelayTo;
			int[] array6 = new int[4];
			array6[0] = 10;
			numericUpDown6.Value = new decimal(array6);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label7.Location = new global::System.Drawing.Point(240, 7);
			this.label7.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWswOQ=="))))))));
			this.label7.Size = new global::System.Drawing.Size(25, 16);
			this.label7.TabIndex = 102;
			this.label7.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFoT1VGb3lSbEpRVkRBOQ=="))))))));
			this.nudTuongTacFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFrom.Location = new global::System.Drawing.Point(113, 3);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.nudTuongTacFrom;
			int[] array7 = new int[4];
			array7[0] = 1000;
			numericUpDown7.Maximum = new decimal(array7);
			this.nudTuongTacFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBUMWhSUFE9PQ=="))))))));
			this.nudTuongTacFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacFrom.TabIndex = 92;
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.nudTuongTacFrom;
			int[] array8 = new int[4];
			array8[0] = 5;
			numericUpDown8.Value = new decimal(array8);
			this.label52.AutoSize = true;
			this.label52.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label52.Location = new global::System.Drawing.Point(240, 32);
			this.label52.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaT1dub3dPUT09"))))))));
			this.label52.Size = new global::System.Drawing.Size(31, 16);
			this.label52.TabIndex = 102;
			this.label52.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.ckbTuongTacComment.AutoSize = true;
			this.ckbTuongTacComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacComment.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacComment.Location = new global::System.Drawing.Point(113, 79);
			this.ckbTuongTacComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U1IwbDVUVmhTWVZaNlZYYz0="))))))));
			this.ckbTuongTacComment.Size = new global::System.Drawing.Size(82, 20);
			this.ckbTuongTacComment.TabIndex = 96;
			this.ckbTuongTacComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUkhTbGhXYmxaclVWUXdPUT09"))))))));
			this.ckbTuongTacComment.UseVisualStyleBackColor = true;
			this.ckbTuongTacComment.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacComment_CheckedChanged);
			this.nudTuongTacDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacDelayFrom.Location = new global::System.Drawing.Point(113, 30);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.nudTuongTacDelayFrom;
			int[] array9 = new int[4];
			array9[0] = 1000;
			numericUpDown9.Maximum = new decimal(array9);
			this.nudTuongTacDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1ZuQllaVWRvYkZaV2NEVlpha2wzVUZFOVBRPT0="))))))));
			this.nudTuongTacDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacDelayFrom.TabIndex = 93;
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.nudTuongTacDelayFrom;
			int[] array10 = new int[4];
			array10[0] = 5;
			numericUpDown10.Value = new decimal(array10);
			this.label51.AutoSize = true;
			this.label51.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label51.Location = new global::System.Drawing.Point(3, 33);
			this.label51.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaT1ZWUXdPUT09"))))))));
			this.label51.Size = new global::System.Drawing.Size(100, 16);
			this.label51.TabIndex = 101;
			this.label51.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.ckbTuongTacLike.AutoSize = true;
			this.ckbTuongTacLike.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacLike.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacLike.Location = new global::System.Drawing.Point(113, 58);
			this.ckbTuongTacLike.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VVYwWllaRWQzUFE9PQ=="))))))));
			this.ckbTuongTacLike.Size = new global::System.Drawing.Size(49, 20);
			this.ckbTuongTacLike.TabIndex = 95;
			this.ckbTuongTacLike.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWa2MyTnNjRkpRVkRBOQ=="))))))));
			this.ckbTuongTacLike.UseVisualStyleBackColor = true;
			this.label50.AutoSize = true;
			this.label50.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label50.Location = new global::System.Drawing.Point(3, 59);
			this.label50.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaT1VWUXdPUT09"))))))));
			this.label50.Size = new global::System.Drawing.Size(94, 16);
			this.label50.TabIndex = 100;
			this.label50.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWak5XRkljRXhVYmtKS1UwWlNTR013TVdoaFIwcDBXVEprYTFJd2FFNWFNV1JPVG1jOVBRPT0="))))))));
			this.ckbTuongTac.AutoSize = true;
			this.ckbTuongTac.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTac.Location = new global::System.Drawing.Point(316, 3);
			this.ckbTuongTac.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU1UVVUMDk="))))))));
			this.ckbTuongTac.Size = new global::System.Drawing.Size(211, 20);
			this.ckbTuongTac.TabIndex = 57;
			this.ckbTuongTac.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeGFHUXphSGhTYmxaaFpWVkpkMlI2V2tkaGEyeElUbGM1TTA0d05UQlRWV2hUWlZob2VWSkhhREZPV0ZKeFUxVmtNR0l5UmxSUmJuQm9VakJhTlZkc1JUbFFVVDA5"))))))));
			this.ckbTuongTac.UseVisualStyleBackColor = true;
			this.ckbTuongTac.CheckedChanged += new global::System.EventHandler(this.ckbTuongTac_CheckedChanged);
			this.nudCountGroupTo.Location = new global::System.Drawing.Point(205, 3);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.nudCountGroupTo;
			int[] array11 = new int[4];
			array11[0] = 999999;
			numericUpDown11.Maximum = new decimal(array11);
			this.nudCountGroupTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtTVmt5TURWTlYwNUhWVzVaUFE9PQ=="))))))));
			this.nudCountGroupTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountGroupTo.TabIndex = 53;
			this.nudCountGroupFrom.Location = new global::System.Drawing.Point(108, 3);
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.nudCountGroupFrom;
			int[] array12 = new int[4];
			array12[0] = 999999;
			numericUpDown12.Maximum = new decimal(array12);
			this.nudCountGroupFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtTVmt5TURWTlYwNUdWMjVzYVUxcVFUaz0="))))))));
			this.nudCountGroupFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountGroupFrom.TabIndex = 52;
			this.label24.AutoSize = true;
			this.label24.Location = new global::System.Drawing.Point(170, 5);
			this.label24.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4UFVWUXdPUT09"))))))));
			this.label24.Size = new global::System.Drawing.Size(29, 16);
			this.label24.TabIndex = 56;
			this.label24.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label25.AutoSize = true;
			this.label25.Location = new global::System.Drawing.Point(264, 5);
			this.label25.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4UFZWUXdPUT09"))))))));
			this.label25.Size = new global::System.Drawing.Size(40, 16);
			this.label25.TabIndex = 55;
			this.label25.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cweGNWSklUWGxOUkRBOQ=="))))))));
			this.label26.AutoSize = true;
			this.label26.Location = new global::System.Drawing.Point(3, 5);
			this.label26.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4UFdub3dPUT09"))))))));
			this.label26.Size = new global::System.Drawing.Size(100, 16);
			this.label26.TabIndex = 54;
			this.label26.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNHlkRlJSYms0MFkydFNiMlJVV2s5a1ZuQTFVVzVXYUZSVk9UWlpiRkoyVUZFOVBRPT0="))))))));
			this.ckbShareBaiLenPage.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.ckbShareBaiLenPage.AutoSize = true;
			this.ckbShareBaiLenPage.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbShareBaiLenPage.Location = new global::System.Drawing.Point(10, 401);
			this.ckbShareBaiLenPage.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFSRmRXWkhOVVZuQllUbFpHV2xZeVVuTT0="))))))));
			this.ckbShareBaiLenPage.Size = new global::System.Drawing.Size(135, 20);
			this.ckbShareBaiLenPage.TabIndex = 0;
			this.ckbShareBaiLenPage.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSS2IyRkhUblJXVjJSYVl6QTVibGxXVGtOak0yTXlZMGhXU2xORlNtOVhha3BXVUZFOVBRPT0="))))))));
			this.ckbShareBaiLenPage.UseVisualStyleBackColor = true;
			this.ckbShareBaiLenPage.CheckedChanged += new global::System.EventHandler(this.ckbDangBaiLenPage_CheckedChanged);
			this.ckbShareBaiLenNhom.AutoSize = true;
			this.ckbShareBaiLenNhom.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbShareBaiLenNhom.Location = new global::System.Drawing.Point(10, 48);
			this.ckbShareBaiLenNhom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFSRmRXWkhOVVZuQllUbFU1YUZKNmJEQT0="))))))));
			this.ckbShareBaiLenNhom.Size = new global::System.Drawing.Size(139, 20);
			this.ckbShareBaiLenNhom.TabIndex = 0;
			this.ckbShareBaiLenNhom.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSS2IyRkhUblJXVjJSYVl6QTVibGxXVGtOak0yTXlZMGhXU2xKNlZuWmtlbVJQWkVFOVBRPT0="))))))));
			this.ckbShareBaiLenNhom.UseVisualStyleBackColor = true;
			this.ckbShareBaiLenNhom.CheckedChanged += new global::System.EventHandler(this.ckbDangBaiLenNhom_CheckedChanged);
			this.ckbShareBaiLenTuong.AutoSize = true;
			this.ckbShareBaiLenTuong.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbShareBaiLenTuong.Location = new global::System.Drawing.Point(10, 22);
			this.ckbShareBaiLenTuong.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFSRmRXWkhOVVZuQllUbFpXYTFaNmJERlhibU01VUZFOVBRPT0="))))))));
			this.ckbShareBaiLenTuong.Size = new global::System.Drawing.Size(140, 20);
			this.ckbShareBaiLenTuong.TabIndex = 0;
			this.ckbShareBaiLenTuong.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSS2IyRkhUblJXVjJSYVl6QTVibGxXVGtOak0yTXlZMGhXU2xOR1VraGpNRGxJVGpJMVdFNVhORDA9"))))))));
			this.ckbShareBaiLenTuong.UseVisualStyleBackColor = true;
			this.ckbShareBaiLenTuong.CheckedChanged += new global::System.EventHandler(this.ckbShareBaiLenTuong_CheckedChanged);
			this.nudDelayTo.Location = new global::System.Drawing.Point(235, 79);
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.nudDelayTo;
			int[] array13 = new int[4];
			array13[0] = 999999;
			numericUpDown13.Maximum = new decimal(array13);
			this.nudDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk="))))))));
			this.nudDelayTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayTo.TabIndex = 58;
			this.nudDelayFrom.Location = new global::System.Drawing.Point(138, 79);
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.nudDelayFrom;
			int[] array14 = new int[4];
			array14[0] = 999999;
			numericUpDown14.Maximum = new decimal(array14);
			this.nudDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk="))))))));
			this.nudDelayFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudDelayFrom.TabIndex = 57;
			this.label20.AutoSize = true;
			this.label20.Location = new global::System.Drawing.Point(200, 81);
			this.label20.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4T1VWUXdPUT09"))))))));
			this.label20.Size = new global::System.Drawing.Size(29, 16);
			this.label20.TabIndex = 61;
			this.label20.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label19.AutoSize = true;
			this.label19.Location = new global::System.Drawing.Point(294, 81);
			this.label19.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUVZWUXdPUT09"))))))));
			this.label19.Size = new global::System.Drawing.Size(31, 16);
			this.label19.TabIndex = 60;
			this.label19.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(11, 81);
			this.label15.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUFZWUXdPUT09"))))))));
			this.label15.Size = new global::System.Drawing.Size(121, 16);
			this.label15.TabIndex = 59;
			this.label15.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2IyUnFVbWxqVjNCcFlsZE9ibGRVYUZCaFJtdDVXakprYWsxdGFHOVpNakZXVG1jOVBRPT0="))))))));
			this.plVanBan.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plVanBan.Controls.Add(this.button6);
			this.plVanBan.Controls.Add(this.linkLabel1);
			this.plVanBan.Controls.Add(this.button3);
			this.plVanBan.Controls.Add(this.button2);
			this.plVanBan.Controls.Add(this.rbNganCachKyTu);
			this.plVanBan.Controls.Add(this.rbNganCachMoiDong);
			this.plVanBan.Controls.Add(this.label9);
			this.plVanBan.Controls.Add(this.label8);
			this.plVanBan.Controls.Add(this.btnDown);
			this.plVanBan.Controls.Add(this.btnUp);
			this.plVanBan.Controls.Add(this.txtNoiDung);
			this.plVanBan.Controls.Add(this.lblStatus);
			this.plVanBan.Location = new global::System.Drawing.Point(33, 324);
			this.plVanBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWXhiRmhPVlU1YVZucFJPUT09"))))))));
			this.plVanBan.Size = new global::System.Drawing.Size(359, 169);
			this.plVanBan.TabIndex = 33;
			this.button6.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button6.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button6.Location = new global::System.Drawing.Point(328, 145);
			this.button6.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUFdub3dPUT09"))))))));
			this.button6.Size = new global::System.Drawing.Size(23, 23);
			this.button6.TabIndex = 191;
			this.button6.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlVoak9WQlJQVDA9"))))))));
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.linkLabel1.Location = new global::System.Drawing.Point(245, 148);
			this.linkLabel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a2MyUlhSWGRsUjJoYVlsWmFlbFJXUlRsUVVUMDk="))))))));
			this.linkLabel1.Size = new global::System.Drawing.Size(82, 16);
			this.linkLabel1.TabIndex = 190;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxjeFIyUldjRWhQV0ZKS1VqSjRjVmxxU1RCUVVUMDk="))))))));
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button3.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.Location = new global::System.Drawing.Point(230, 189);
			this.button3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1pIb3dPUT09"))))))));
			this.button3.Size = new global::System.Drawing.Size(21, 23);
			this.button3.TabIndex = 44;
			this.button3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlVoak9WQlJQVDA9"))))))));
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(230, 166);
			this.button2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1dub3dPUT09"))))))));
			this.button2.Size = new global::System.Drawing.Size(21, 23);
			this.button2.TabIndex = 45;
			this.button2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlVoak9WQlJQVDA9"))))))));
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.rbNganCachKyTu.AutoSize = true;
			this.rbNganCachKyTu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachKyTu.Location = new global::System.Drawing.Point(71, 189);
			this.rbNganCachKyTu.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUXhiM2xTYmxaU1RXdGFjVmxWVmpCT1ZscEpWbFF3UFE9PQ=="))))))));
			this.rbNganCachKyTu.Size = new global::System.Drawing.Size(160, 20);
			this.rbNganCachKyTu.TabIndex = 42;
			this.rbNganCachKyTu.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtoV1NFNHlNVmhoTW1SaFUwWmFNVmR1YkVOaGJtTXpWRmRrYVdKWGFIZE9SMG94VVcxU1ZGRnRkRE5PTUhBeFYyNWpPVkJSUFQwPQ=="))))))));
			this.rbNganCachKyTu.UseVisualStyleBackColor = true;
			this.rbNganCachKyTu.CheckedChanged += new global::System.EventHandler(this.rbNganCachKyTu_CheckedChanged_1);
			this.rbNganCachMoiDong.AutoSize = true;
			this.rbNganCachMoiDong.Checked = true;
			this.rbNganCachMoiDong.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNganCachMoiDong.Location = new global::System.Drawing.Point(71, 168);
			this.rbNganCachMoiDong.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUXhiM2xTYmxaU1RXdGFjVmxWVlhoa2JVWldWVzVhYVdKWFRUaz0="))))))));
			this.rbNganCachMoiDong.Size = new global::System.Drawing.Size(156, 20);
			this.rbNganCachMoiDong.TabIndex = 43;
			this.rbNganCachMoiDong.TabStop = true;
			this.rbNganCachMoiDong.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtoV1NFNHlNVmhoTW1SaFUwWmFNVmR1YkVOaGJVWlFVbnBrY0ZVd1NuRmtlbVJPV2pBeFZGRnRkRE5PTUhBeFYyNWpPVkJSUFQwPQ=="))))))));
			this.rbNganCachMoiDong.UseVisualStyleBackColor = true;
			this.rbNganCachMoiDong.CheckedChanged += new global::System.EventHandler(this.rbNganCachMoiDong_CheckedChanged_1);
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(6, 168);
			this.label9.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxVOQ=="))))))));
			this.label9.Size = new global::System.Drawing.Size(65, 16);
			this.label9.TabIndex = 41;
			this.label9.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVFNVhWbFJSYlhCb1ZEQmpNMkZzWXpCT1p6MDk="))))))));
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(5, 147);
			this.label8.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxFOQ=="))))))));
			this.label8.Size = new global::System.Drawing.Size(144, 16);
			this.label8.TabIndex = 40;
			this.label8.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VXpCYVQyUXlSbGhPUjJScFpGVmpNMkpXWkhKYU1YQkpWbTVXWVdWVlNUTlhWbWcwWVZkYVNGUnFiRXhWVkRBNQ=="))))))));
			this.btnDown.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnDown.BackgroundImage = global::maxcare.Properties.Resources.icons8_expand_arrow_24px;
			this.btnDown.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnDown.Location = new global::System.Drawing.Point(302, -1);
			this.btnDown.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldTa2hQVkU1cFdub3dPUT09"))))))));
			this.btnDown.Size = new global::System.Drawing.Size(25, 25);
			this.btnDown.TabIndex = 38;
			this.btnDown.UseSelectable = true;
			this.btnDown.Click += new global::System.EventHandler(this.btnDown_Click);
			this.btnUp.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnUp.BackgroundImage = global::maxcare.Properties.Resources.icons8_collapse_arrow_24px;
			this.btnUp.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnUp.Location = new global::System.Drawing.Point(333, -1);
			this.btnUp.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldXbGxSVkRBOQ=="))))))));
			this.btnUp.Size = new global::System.Drawing.Size(25, 25);
			this.btnUp.TabIndex = 39;
			this.btnUp.UseSelectable = true;
			this.btnUp.Click += new global::System.EventHandler(this.btnUp_Click);
			this.txtNoiDung.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtNoiDung.Location = new global::System.Drawing.Point(7, 26);
			this.txtNoiDung.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdVblJQV0VKVFUwWmFNVmR1WXpsUVVUMDk="))))))));
			this.txtNoiDung.Size = new global::System.Drawing.Size(344, 119);
			this.txtNoiDung.TabIndex = 34;
			this.txtNoiDung.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(""))))))));
			this.txtNoiDung.WordWrap = false;
			this.txtNoiDung.TextChanged += new global::System.EventHandler(this.txtNoiDung_TextChanged);
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
			this.btnAdd.Location = new global::System.Drawing.Point(453, 570);
			this.btnAdd.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSbGhWYlhNOQ=="))))))));
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSklSblJOUkRBOQ=="))))))));
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.ckbVanBan.AutoSize = true;
			this.ckbVanBan.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbVanBan.Location = new global::System.Drawing.Point(14, 296);
			this.ckbVanBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXblJTYmxaU1lsVmFNUT09"))))))));
			this.ckbVanBan.Size = new global::System.Drawing.Size(113, 20);
			this.ckbVanBan.TabIndex = 32;
			this.ckbVanBan.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtoV1NFNHlNVmhoTW1SaFUwWmFNVmR1YkVObGJVWklVbTVzWVZWVU1Eaz0="))))))));
			this.ckbVanBan.UseVisualStyleBackColor = true;
			this.ckbVanBan.CheckedChanged += new global::System.EventHandler(this.ckbVanBan_CheckedChanged);
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(138, 49);
			this.txtTenHanhDong.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdXa2hXYmxaVVVqQmFNVmxWVmxOa2JVcDBXWG93UFE9PQ=="))))))));
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(193, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(11, 52);
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
			this.btnCancel.Location = new global::System.Drawing.Point(563, 570);
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(1097, 37);
			this.bunifuCards1.TabIndex = 28;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1100, 612);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMGIxSldWWGxoUjJocVlsWmFSRmRXWkhKUVVUMDk="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1sSk9XVmhrTkdOVldqRlhibXhEVFVoak1sSnRiejA9"))))))));
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.plDangBaiLenPage.ResumeLayout(false);
			this.plDangBaiLenPage.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountPageTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountPageFrom).EndInit();
			this.plDangBaiLenNhom.ResumeLayout(false);
			this.plDangBaiLenNhom.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.plInteractGroup.ResumeLayout(false);
			this.plInteractGroup.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountGroupTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountGroupFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayFrom).EndInit();
			this.plVanBan.ResumeLayout(false);
			this.plVanBan.PerformLayout();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040009F4 RID: 2548
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040009F5 RID: 2549
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040009F6 RID: 2550
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040009F7 RID: 2551
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040009F8 RID: 2552
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x040009F9 RID: 2553
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040009FA RID: 2554
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040009FB RID: 2555
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x040009FC RID: 2556
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040009FD RID: 2557
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040009FE RID: 2558
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040009FF RID: 2559
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000A00 RID: 2560
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000A01 RID: 2561
		private global::System.Windows.Forms.CheckBox ckbVanBan;

		// Token: 0x04000A02 RID: 2562
		private global::System.Windows.Forms.Panel plVanBan;

		// Token: 0x04000A03 RID: 2563
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000A04 RID: 2564
		private global::System.Windows.Forms.RichTextBox txtNoiDung;

		// Token: 0x04000A05 RID: 2565
		private global::MetroFramework.Controls.MetroButton btnDown;

		// Token: 0x04000A06 RID: 2566
		private global::MetroFramework.Controls.MetroButton btnUp;

		// Token: 0x04000A07 RID: 2567
		private global::System.Windows.Forms.NumericUpDown nudDelayTo;

		// Token: 0x04000A08 RID: 2568
		private global::System.Windows.Forms.NumericUpDown nudDelayFrom;

		// Token: 0x04000A09 RID: 2569
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04000A0A RID: 2570
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000A0B RID: 2571
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000A0C RID: 2572
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000A0D RID: 2573
		private global::System.Windows.Forms.Panel plDangBaiLenPage;

		// Token: 0x04000A0E RID: 2574
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000A0F RID: 2575
		private global::System.Windows.Forms.Label label22;

		// Token: 0x04000A10 RID: 2576
		private global::System.Windows.Forms.NumericUpDown nudCountPageTo;

		// Token: 0x04000A11 RID: 2577
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04000A12 RID: 2578
		private global::System.Windows.Forms.NumericUpDown nudCountPageFrom;

		// Token: 0x04000A13 RID: 2579
		private global::System.Windows.Forms.Panel plDangBaiLenNhom;

		// Token: 0x04000A14 RID: 2580
		private global::System.Windows.Forms.NumericUpDown nudCountGroupTo;

		// Token: 0x04000A15 RID: 2581
		private global::System.Windows.Forms.NumericUpDown nudCountGroupFrom;

		// Token: 0x04000A16 RID: 2582
		private global::System.Windows.Forms.Label label24;

		// Token: 0x04000A17 RID: 2583
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04000A18 RID: 2584
		private global::System.Windows.Forms.Label label26;

		// Token: 0x04000A19 RID: 2585
		private global::System.Windows.Forms.CheckBox ckbShareBaiLenPage;

		// Token: 0x04000A1A RID: 2586
		private global::System.Windows.Forms.CheckBox ckbShareBaiLenNhom;

		// Token: 0x04000A1B RID: 2587
		private global::System.Windows.Forms.CheckBox ckbShareBaiLenTuong;

		// Token: 0x04000A1C RID: 2588
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000A1D RID: 2589
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000A1E RID: 2590
		private global::System.Windows.Forms.RadioButton rbNganCachKyTu;

		// Token: 0x04000A1F RID: 2591
		private global::System.Windows.Forms.RadioButton rbNganCachMoiDong;

		// Token: 0x04000A20 RID: 2592
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000A21 RID: 2593
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000A22 RID: 2594
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000A23 RID: 2595
		private global::System.Windows.Forms.TextBox txtLinkChiaSe;

		// Token: 0x04000A24 RID: 2596
		private global::System.Windows.Forms.CheckBox ckbOnlyShareNhomKhongKiemDuyet;

		// Token: 0x04000A25 RID: 2597
		private global::System.Windows.Forms.CheckBox ckbKhongPhaiLinkFacebook;

		// Token: 0x04000A26 RID: 2598
		private global::System.Windows.Forms.RadioButton rbShareVip;

		// Token: 0x04000A27 RID: 2599
		private global::System.Windows.Forms.RadioButton rbShareThuong;

		// Token: 0x04000A28 RID: 2600
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000A29 RID: 2601
		private global::System.Windows.Forms.Panel plInteractGroup;

		// Token: 0x04000A2A RID: 2602
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000A2B RID: 2603
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000A2C RID: 2604
		private global::System.Windows.Forms.Label label53;

		// Token: 0x04000A2D RID: 2605
		private global::System.Windows.Forms.NumericUpDown nudTuongTacTo;

		// Token: 0x04000A2E RID: 2606
		private global::System.Windows.Forms.NumericUpDown nudTuongTacDelayTo;

		// Token: 0x04000A2F RID: 2607
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000A30 RID: 2608
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFrom;

		// Token: 0x04000A31 RID: 2609
		private global::System.Windows.Forms.Label label52;

		// Token: 0x04000A32 RID: 2610
		private global::System.Windows.Forms.CheckBox ckbTuongTacComment;

		// Token: 0x04000A33 RID: 2611
		private global::System.Windows.Forms.NumericUpDown nudTuongTacDelayFrom;

		// Token: 0x04000A34 RID: 2612
		private global::System.Windows.Forms.Label label51;

		// Token: 0x04000A35 RID: 2613
		private global::System.Windows.Forms.CheckBox ckbTuongTacLike;

		// Token: 0x04000A36 RID: 2614
		private global::System.Windows.Forms.Label label50;

		// Token: 0x04000A37 RID: 2615
		private global::System.Windows.Forms.CheckBox ckbTuongTac;

		// Token: 0x04000A38 RID: 2616
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000A39 RID: 2617
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000A3A RID: 2618
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000A3B RID: 2619
		private global::System.Windows.Forms.RadioButton radioButton1;

		// Token: 0x04000A3C RID: 2620
		private global::System.Windows.Forms.RadioButton radioButton2;

		// Token: 0x04000A3D RID: 2621
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000A3E RID: 2622
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000A3F RID: 2623
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x04000A40 RID: 2624
		private global::System.Windows.Forms.Label lblComment;

		// Token: 0x04000A41 RID: 2625
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000A42 RID: 2626
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000A43 RID: 2627
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04000A44 RID: 2628
		private global::System.Windows.Forms.LinkLabel linkLabel2;

		// Token: 0x04000A45 RID: 2629
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000A46 RID: 2630
		private global::System.Windows.Forms.CheckBox ckbKhongShareTrung;

		// Token: 0x04000A47 RID: 2631
		private global::System.Windows.Forms.CheckBox ckbUuTienNhomNhieuThanhVien;

		// Token: 0x04000A48 RID: 2632
		private global::System.Windows.Forms.CheckBox ckbCauHinhNangCao;

		// Token: 0x04000A49 RID: 2633
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000A4A RID: 2634
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04000A4B RID: 2635
		private global::System.Windows.Forms.RadioButton rbTuNhap;

		// Token: 0x04000A4C RID: 2636
		private global::System.Windows.Forms.RadioButton rbRandom;

		// Token: 0x04000A4D RID: 2637
		private global::System.Windows.Forms.Label label11;
	}
}
