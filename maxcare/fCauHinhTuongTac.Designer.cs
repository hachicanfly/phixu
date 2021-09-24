namespace maxcare
{
	// Token: 0x020000E8 RID: 232
	public partial class fCauHinhTuongTac : global::System.Windows.Forms.Form
	{
		// Token: 0x0600096B RID: 2411 RVA: 0x0018F1B0 File Offset: 0x0018D3B0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0018F210 File Offset: 0x0018D410
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fCauHinhTuongTac));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.rbTuongTacNhanh = new global::System.Windows.Forms.RadioButton();
			this.rbTuongTacKichBan = new global::System.Windows.Forms.RadioButton();
			this.btnCauHinhTuongTacNhanh = new global::MetroFramework.Controls.MetroButton();
			this.plTuongTacKichBan = new global::System.Windows.Forms.Panel();
			this.ckbRandomHanhDong = new global::System.Windows.Forms.CheckBox();
			this.cbbKichBan = new global::System.Windows.Forms.ComboBox();
			this.btnQuanLyKichBan = new global::MetroFramework.Controls.MetroButton();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.rbLoginWWW = new global::System.Windows.Forms.RadioButton();
			this.rbLoginMFB = new global::System.Windows.Forms.RadioButton();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.ckbCreateProfile = new global::System.Windows.Forms.CheckBox();
			this.ckbGetCookie = new global::System.Windows.Forms.CheckBox();
			this.ckbCreateShortcut = new global::System.Windows.Forms.CheckBox();
			this.ckbRepeatAll = new global::System.Windows.Forms.CheckBox();
			this.ckbAllowFollow = new global::System.Windows.Forms.CheckBox();
			this.ckbAutoLinkInstagram = new global::System.Windows.Forms.CheckBox();
			this.ckbLogOutOldDevice = new global::System.Windows.Forms.CheckBox();
			this.ckbLogOut = new global::System.Windows.Forms.CheckBox();
			this.ckbCapNhatThongTin = new global::System.Windows.Forms.CheckBox();
			this.ckbGetToken = new global::System.Windows.Forms.CheckBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.plShowNangCao = new global::System.Windows.Forms.Panel();
			this.ckbBatThongBaoDangNhap = new global::System.Windows.Forms.CheckBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.rbLoginEmailPass = new global::System.Windows.Forms.RadioButton();
			this.rbLoginUidPass = new global::System.Windows.Forms.RadioButton();
			this.rbLoginCookie = new global::System.Windows.Forms.RadioButton();
			this.btnShowNangCao = new global::System.Windows.Forms.Button();
			this.ckbReviewTag = new global::System.Windows.Forms.CheckBox();
			this.plShowCoBan = new global::System.Windows.Forms.Panel();
			this.plRepeatAll = new global::System.Windows.Forms.Panel();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.nudDelayTurnFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label5 = new global::System.Windows.Forms.Label();
			this.nudDelayTurnTo = new global::System.Windows.Forms.NumericUpDown();
			this.label11 = new global::System.Windows.Forms.Label();
			this.nudSoLuotChay = new global::System.Windows.Forms.NumericUpDown();
			this.label10 = new global::System.Windows.Forms.Label();
			this.btnShowCoBan = new global::System.Windows.Forms.Button();
			this.ckbDontSaveBrowser = new global::System.Windows.Forms.CheckBox();
			this.ckbCheckLiveUid = new global::System.Windows.Forms.CheckBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.rbLoginMbasic = new global::System.Windows.Forms.RadioButton();
			this.bunifuCards1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.groupBox2.SuspendLayout();
			this.plTuongTacKichBan.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.plShowNangCao.SuspendLayout();
			this.panel2.SuspendLayout();
			this.plShowCoBan.SuspendLayout();
			this.plRepeatAll.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTurnFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTurnTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuotChay).BeginInit();
			base.SuspendLayout();
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.FromArgb(24, 119, 242);
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(2, 1);
			this.bunifuCards1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RXdGFOVmRyYUU1bFFUMDk="))))))));
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(440, 38);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCak1XTXhUa2hXYldoaFVqRmFOUT09"))))))));
			this.pnlHeader.Size = new global::System.Drawing.Size(440, 32);
			this.pnlHeader.TabIndex = 9;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 1);
			this.pictureBox1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaUVVUMDk="))))))));
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 78;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.btnMinimize.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.btnMinimize.Location = new global::System.Drawing.Point(406, -2);
			this.btnMinimize.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaUVVUMDk="))))))));
			this.btnMinimize.Size = new global::System.Drawing.Size(32, 32);
			this.btnMinimize.TabIndex = 9;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new global::System.EventHandler(this.BtnMinimize_Click);
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RURmFObHBGWXpWa1JsSklVbTFzWVZZelpEUT0="))))))));
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(440, 32);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1WcE9XVmhrTkdOVldqRlhibXhEVFVoak1sSnRiejA9"))))))));
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(226, 443);
			this.btnCancel.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxTYmxaYVRXeGFlZz09"))))))));
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSklUWGxPVnpROQ=="))))))));
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.btnAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(122, 443);
			this.btnAdd.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSbGhWYlhNOQ=="))))))));
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVeGFHUXlVbEpRVkRBOQ=="))))))));
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.groupBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.groupBox2.Controls.Add(this.rbTuongTacNhanh);
			this.groupBox2.Controls.Add(this.rbTuongTacKichBan);
			this.groupBox2.Controls.Add(this.btnCauHinhTuongTacNhanh);
			this.groupBox2.Controls.Add(this.plTuongTacKichBan);
			this.groupBox2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox2.Location = new global::System.Drawing.Point(11, 287);
			this.groupBox2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwT1MyUnRVbGxSYTA1cFRUSmtOUT09"))))))));
			this.groupBox2.Size = new global::System.Drawing.Size(420, 139);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVFNVhWbFJSYlhCb1ZEQmpNMkZzWXpCYU1rVjVZbTFvTVU1Rk5IaFRWV2hWVWpOT1RsbFhhR2xpVjA1dVdrVXhVR0ZHYkROUVZEQTk="))))))));
			this.rbTuongTacNhanh.AutoSize = true;
			this.rbTuongTacNhanh.Checked = true;
			this.rbTuongTacNhanh.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbTuongTacNhanh.Location = new global::System.Drawing.Point(17, 23);
			this.rbTuongTacNhanh.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rbTuongTacNhanh.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxWlhVbGhQV0ZaaFRWWktiMWRVUVRGaU1XeFlUbGM0UFE9PQ=="))))))));
			this.rbTuongTacNhanh.Size = new global::System.Drawing.Size(123, 20);
			this.rbTuongTacNhanh.TabIndex = 0;
			this.rbTuongTacNhanh.TabStop = true;
			this.rbTuongTacNhanh.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeGFHUXphSGhTYmxaaFpWVkpkMlI2V2tkaGEyeElUbGM1V2xaNlZuWT0="))))))));
			this.rbTuongTacNhanh.UseVisualStyleBackColor = true;
			this.rbTuongTacNhanh.CheckedChanged += new global::System.EventHandler(this.rbTuongTacNhanh_CheckedChanged);
			this.rbTuongTacKichBan.AutoSize = true;
			this.rbTuongTacKichBan.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbTuongTacKichBan.Location = new global::System.Drawing.Point(17, 46);
			this.rbTuongTacKichBan.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rbTuongTacKichBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxWlhVbGhQV0ZaaFRWWktiMWRVUWpCalJtdDVZVVZPV2xaNlVUaz0="))))))));
			this.rbTuongTacKichBan.Size = new global::System.Drawing.Size(302, 20);
			this.rbTuongTacKichBan.TabIndex = 0;
			this.rbTuongTacKichBan.TabStop = true;
			this.rbTuongTacKichBan.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeGFHUXphSGhTYmxaaFpWVkpkMlI2V2tkaGEyeEpWVzA1WVZaNmFHNVpVM1JJVGpKcmVWUnRPVXBTTUhodlpGaEdUMlJWYkVSaFJYaG9VMFpaTVU1SFNuaE1Na3B3VVc1S2FGUlZPVEJYVkVwdVdqSk5jbEo2WkhsVk1FcHlUa2RLTVdKSFNuUlpNMEU5"))))))));
			this.rbTuongTacKichBan.UseVisualStyleBackColor = true;
			this.rbTuongTacKichBan.CheckedChanged += new global::System.EventHandler(this.rbTuongTacKichBan_CheckedChanged);
			this.btnCauHinhTuongTacNhanh.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCauHinhTuongTacNhanh.Location = new global::System.Drawing.Point(141, 22);
			this.btnCauHinhTuongTacNhanh.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxTYWtaVVVqSjRNVmxWV2xOTlYwbDVUbGMxVjFJd1duRldSekZ2WVVkS2RGcDZNRDA9"))))))));
			this.btnCauHinhTuongTacNhanh.Size = new global::System.Drawing.Size(75, 23);
			this.btnCauHinhTuongTacNhanh.TabIndex = 1;
			this.btnCauHinhTuongTacNhanh.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1UVVUMDk="))))))));
			this.btnCauHinhTuongTacNhanh.UseSelectable = true;
			this.btnCauHinhTuongTacNhanh.Click += new global::System.EventHandler(this.metroButton1_Click);
			this.plTuongTacKichBan.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plTuongTacKichBan.Controls.Add(this.ckbRandomHanhDong);
			this.plTuongTacKichBan.Controls.Add(this.cbbKichBan);
			this.plTuongTacKichBan.Controls.Add(this.btnQuanLyKichBan);
			this.plTuongTacKichBan.Controls.Add(this.label1);
			this.plTuongTacKichBan.Location = new global::System.Drawing.Point(37, 70);
			this.plTuongTacKichBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWlhVbGhQV0ZaaFRWWktiMWRVUWpCalJtdDVZVVZPV2xaNlVUaz0="))))))));
			this.plTuongTacKichBan.Size = new global::System.Drawing.Size(376, 63);
			this.plTuongTacKichBan.TabIndex = 2;
			this.ckbRandomHanhDong.AutoSize = true;
			this.ckbRandomHanhDong.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbRandomHanhDong.Location = new global::System.Drawing.Point(7, 35);
			this.ckbRandomHanhDong.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldWblJTYmxaaFVucHNNRlV3WkVka1YwWkdWVzVhYVdKWFRUaz0="))))))));
			this.ckbRandomHanhDong.Size = new global::System.Drawing.Size(200, 20);
			this.ckbRandomHanhDong.TabIndex = 2;
			this.ckbRandomHanhDong.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxjeFIyUldjRWhQV0ZKS1UwWktkazVIU2pGalJXeEpWa2RvTVU0d1ZtNVhWR2hRWVVac05WRnRPVE5PYTBveFdWVk9SVkpYZEd4U2VtUjBWbnBXZFE9PQ=="))))))));
			this.ckbRandomHanhDong.UseVisualStyleBackColor = true;
			this.cbbKichBan.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbKichBan.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbKichBan.DropDownWidth = 200;
			this.cbbKichBan.FormattingEnabled = true;
			this.cbbKichBan.Location = new global::System.Drawing.Point(103, 5);
			this.cbbKichBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS1MyRldUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))));
			this.cbbKichBan.Size = new global::System.Drawing.Size(161, 24);
			this.cbbKichBan.TabIndex = 1;
			this.btnQuanLyKichBan.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnQuanLyKichBan.Location = new global::System.Drawing.Point(270, 5);
			this.btnQuanLyKichBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWbGxXYldocFlUTm5NVlY2U25OaGJVWkdVMjFvYVZwNk1Eaz0="))))))));
			this.btnQuanLyKichBan.Size = new global::System.Drawing.Size(100, 25);
			this.btnQuanLyKichBan.TabIndex = 1;
			this.btnQuanLyKichBan.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmxab1dXRklWbmhVYmxaS1VqTndSV1JzVGtOamFsSnBaRlY0V2sxdFpHNVhXRlpJVG0wNGVVNUVNRDA9"))))))));
			this.btnQuanLyKichBan.UseSelectable = true;
			this.btnQuanLyKichBan.Click += new global::System.EventHandler(this.metroButton2_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(4, 8);
			this.label1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJjOQ=="))))))));
			this.label1.Size = new global::System.Drawing.Size(93, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEJOV0ZaS1VqTmFiMlJVVWpCaGJVWkVVVzFyTUZsdVJuRlpiWEIyVUZFOVBRPT0="))))))));
			this.panel3.Controls.Add(this.rbLoginMbasic);
			this.panel3.Controls.Add(this.rbLoginWWW);
			this.panel3.Controls.Add(this.rbLoginMFB);
			this.panel3.Location = new global::System.Drawing.Point(134, 55);
			this.panel3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTI4OQ=="))))))));
			this.panel3.Size = new global::System.Drawing.Size(273, 26);
			this.panel3.TabIndex = 5;
			this.rbLoginWWW.AutoSize = true;
			this.rbLoginWWW.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbLoginWWW.Location = new global::System.Drawing.Point(79, 3);
			this.rbLoginWWW.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUlhTWGxhU0VKcFlrZFNXVlp1WXpsUVVUMDk="))))))));
			this.rbLoginWWW.Size = new global::System.Drawing.Size(56, 20);
			this.rbLoginWWW.TabIndex = 4;
			this.rbLoginWWW.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tST2EwMTNQVDA9"))))))));
			this.rbLoginWWW.UseVisualStyleBackColor = true;
			this.rbLoginMFB.AutoSize = true;
			this.rbLoginMFB.Checked = true;
			this.rbLoginMFB.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbLoginMFB.Location = new global::System.Drawing.Point(3, 3);
			this.rbLoginMFB.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUlhTWGxhU0VKcFlYcEdTRlZYWXpsUVVUMDk="))))))));
			this.rbLoginMFB.Size = new global::System.Drawing.Size(52, 20);
			this.rbLoginMFB.TabIndex = 4;
			this.rbLoginMFB.TabStop = true;
			this.rbLoginMFB.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4Tk1XSldiRzVRVkRBOQ=="))))))));
			this.rbLoginMFB.UseVisualStyleBackColor = true;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(13, 58);
			this.label3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTI4OQ=="))))))));
			this.label3.Size = new global::System.Drawing.Size(111, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10b1MyRkhTblJaTW1RMFUydG9SbHA2U1RGaWEyeElUbGM1TTA1cmVFNWllazVDVG1jOVBRPT0="))))))));
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(13, 34);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(101, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2RXRklWVEJVYWtaS1ZGWk9VMlZGYkU5a1ZuQTFVVzVXYUZSVk9YQmxhM1JQWkRBNWJsQlVNRDA9"))))))));
			this.ckbCreateProfile.AutoSize = true;
			this.ckbCreateProfile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbCreateProfile.Location = new global::System.Drawing.Point(16, 31);
			this.ckbCreateProfile.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSWHBUYlhoYVYwWktjMVpWYUV0a2JIQjBZa2hPWVZWVU1Eaz0="))))))));
			this.ckbCreateProfile.Size = new global::System.Drawing.Size(187, 20);
			this.ckbCreateProfile.TabIndex = 2;
			this.ckbCreateProfile.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNHpUbFJTUlZaeVdsVmpNMkpXWXpGaWEyeEpWa2RvTVdOVldqSlRWVnBEWlZkSmVWZHVRbWxTTVZadVdWUktiMk5GYkVoVWJUZ3dXVzVHYjFwV1JUbFFVVDA5"))))))));
			this.ckbCreateProfile.UseVisualStyleBackColor = true;
			this.ckbGetCookie.AutoSize = true;
			this.ckbGetCookie.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbGetCookie.Location = new global::System.Drawing.Point(222, 31);
			this.ckbGetCookie.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldTWGxXYWtKU1RXcHNNbGxVU25OaVFUMDk="))))))));
			this.ckbGetCookie.Size = new global::System.Drawing.Size(187, 20);
			this.ckbGetCookie.TabIndex = 2;
			this.ckbGetCookie.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNHpUbFJTUlZaeVdsVmpNMkpXWXpGaWEyeElaVzFvTVdOV1dURlRWVlpQWkcxSmVXUklRbUZWTUVwNVdWVmtjbG94YTNsaGJXZ3hZMVZaTVE9PQ=="))))))));
			this.ckbGetCookie.UseVisualStyleBackColor = true;
			this.ckbCreateShortcut.AutoSize = true;
			this.ckbCreateShortcut.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbCreateShortcut.Location = new global::System.Drawing.Point(16, 108);
			this.ckbCreateShortcut.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSWHBUYlhoYVYwWktjMVpVU205a2JVNTFWVzF3YTFkR1JUaz0="))))))));
			this.ckbCreateShortcut.Size = new global::System.Drawing.Size(198, 20);
			this.ckbCreateShortcut.TabIndex = 2;
			this.ckbCreateShortcut.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeGFHUXpjRXhVVjJRMFUydG9SV1JGTVRWaGJVcDBXVEprYTFRd1l6SmlNV00wV2pGVmVXRklXbXBpYkVweFdrWm9VbG94UlhsaFNHeHBUV3BHY3c9PQ=="))))))));
			this.ckbCreateShortcut.UseVisualStyleBackColor = true;
			this.ckbCreateShortcut.Click += new global::System.EventHandler(this.ckbCreateShortcut_Click);
			this.ckbRepeatAll.AutoSize = true;
			this.ckbRepeatAll.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbRepeatAll.Location = new global::System.Drawing.Point(16, 109);
			this.ckbRepeatAll.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldWblJXYm1SaFZqQlpkMVZXWkRSamR6MDk="))))))));
			this.ckbRepeatAll.Size = new global::System.Drawing.Size(345, 20);
			this.ckbRepeatAll.TabIndex = 2;
			this.ckbRepeatAll.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWbmhTYWxaS1UwWlNTR013TVdoaFIwcDBXVEprYTFSVk9XOVhXR3hEWTNwU2FXTlhhR2hWTUVsM1dXcG9VRm95U25CUmJXc3dXVzVXWVZOVmFGVlNSemxJWVRKa2FFMXRhREpPUjBwNFlXMUtjRkZ1Y0ZwWFJsWnVXVlJLYjJORmJFaGhTRm96VG10S01WTlZhRk5pTTJNeVVXNVdhRkZVTURrPQ=="))))))));
			this.ckbRepeatAll.UseVisualStyleBackColor = true;
			this.ckbRepeatAll.CheckedChanged += new global::System.EventHandler(this.ckbRepeatAll_CheckedChanged);
			this.ckbAllowFollow.AutoSize = true;
			this.ckbAllowFollow.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbAllowFollow.Location = new global::System.Drawing.Point(227, 108);
			this.ckbAllowFollow.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSbGhsU0U1cFRUSlNTRmxxU2pSak1rbDZXWG93UFE9PQ=="))))))));
			this.ckbAllowFollow.Size = new global::System.Drawing.Size(188, 20);
			this.ckbAllowFollow.TabIndex = 2;
			this.ckbAllowFollow.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IyUnJiRWxSYlRsaFdUTnNRMWt3VGtOa1ZtODBXVmhrTkdOVmFFNWFNR1J5V2pKRmVXRkhhRFpUVlZweFUxVldZV1J0U2tobFNGcHJaSG93T1E9PQ=="))))))));
			this.ckbAllowFollow.UseVisualStyleBackColor = true;
			this.ckbAutoLinkInstagram.AutoSize = true;
			this.ckbAutoLinkInstagram.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbAutoLinkInstagram.Location = new global::System.Drawing.Point(227, 163);
			this.ckbAutoLinkInstagram.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVaG9kMWx0TVRCVGJVcDFWR3BDV2xZeVVqVlhWbU4zVUZFOVBRPT0="))))))));
			this.ckbAutoLinkInstagram.Size = new global::System.Drawing.Size(182, 20);
			this.ckbAutoLinkInstagram.TabIndex = 2;
			this.ckbAutoLinkInstagram.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeGFHUXpjRXhVVjJRMFUydG9SV1JGTVRWaGJVcDBXVEprYVZJeU5VVmpWekF3V2pKRk5GUXpSalpUVlZsM1UxVldjMlJYVFhwVmJXaGhUVEJ3YjFsc1JUbFFVVDA5"))))))));
			this.ckbAutoLinkInstagram.UseVisualStyleBackColor = true;
			this.ckbAutoLinkInstagram.Visible = false;
			this.ckbAutoLinkInstagram.CheckedChanged += new global::System.EventHandler(this.ckbAutoLinkInstagram_CheckedChanged);
			this.ckbLogOutOldDevice.AutoSize = true;
			this.ckbLogOutOldDevice.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbLogOutOldDevice.Location = new global::System.Drawing.Point(227, 84);
			this.ckbLogOutOldDevice.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldVa2hQVnpWVlRURlpkMVpFU2pSaE1VcElWbXBLYUZZd05YTT0="))))))));
			this.ckbLogOutOldDevice.Size = new global::System.Drawing.Size(167, 20);
			this.ckbLogOutOldDevice.TabIndex = 2;
			this.ckbLogOutOldDevice.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1UwZG5lRTVIU25oaVIxSkVVVzA1TTA1dVNrNWFNV2hTV2pKU1NHRklRak5PYmtwT1dqRm9VbG94YkhSaWF6RjJaVlZLY1ZwSFRqVlNRVDA5"))))))));
			this.ckbLogOutOldDevice.UseVisualStyleBackColor = true;
			this.ckbLogOut.AutoSize = true;
			this.ckbLogOut.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbLogOut.Location = new global::System.Drawing.Point(222, 57);
			this.ckbLogOut.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldVa2hQVnpWVlRURlpkdz09"))))))));
			this.ckbLogOut.Size = new global::System.Drawing.Size(187, 20);
			this.ckbLogOut.TabIndex = 2;
			this.ckbLogOut.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1UwZG5lRTVIU25oaVIxSkVVVzV3V2xkR1ZtNVpWRXB2WTBWc1NWWkZaSHBVVjBadldXMHhhbG95VWs1VU1taGFaSG93T1E9PQ=="))))))));
			this.ckbLogOut.UseVisualStyleBackColor = true;
			this.ckbCapNhatThongTin.AutoSize = true;
			this.ckbCapNhatThongTin.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbCapNhatThongTin.Location = new global::System.Drawing.Point(16, 57);
			this.ckbCapNhatThongTin.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSWGxTYm1SVllsZG9iMXBGV2xOaU1rbDVUbGMxVjFJeWVERT0="))))))));
			this.ckbCapNhatThongTin.Size = new global::System.Drawing.Size(182, 20);
			this.ckbCapNhatThongTin.TabIndex = 2;
			this.ckbCapNhatThongTin.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNHpUbFJTUlZaeVdsVmpNMkpXWXpGaWEyeElWVWRvTVdOVVJqTlRWV014WW5wU2FXTllVbXRSTUVsM1dWVXhVRTFIU25SWk1tUnJVako0TVE9PQ=="))))))));
			this.ckbCapNhatThongTin.UseVisualStyleBackColor = true;
			this.ckbCapNhatThongTin.Click += new global::System.EventHandler(this.ckbCapNhatThongTin_Click);
			this.ckbGetToken.AutoSize = true;
			this.ckbGetToken.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbGetToken.Location = new global::System.Drawing.Point(16, 84);
			this.ckbGetToken.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldTWGxXYWtKWFVucHNlVmRzWXpCUVVUMDk="))))))));
			this.ckbGetToken.Size = new global::System.Drawing.Size(184, 20);
			this.ckbGetToken.TabIndex = 2;
			this.ckbGetToken.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNHpUbFJTUlZaeVdsVmpNMkpXWXpGaWEyeElaVzFvTVdOV1dURlRWVnBUWkcxRmVWWnVWa3BTTTFKMldWWk9RMkZ0UmxCU2VscDJWMGR6T1E9PQ=="))))))));
			this.ckbGetToken.UseVisualStyleBackColor = true;
			this.ckbGetToken.Click += new global::System.EventHandler(this.ckbGetToken_Click);
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.plShowNangCao);
			this.panel1.Controls.Add(this.plShowCoBan);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJjOQ=="))))))));
			this.panel1.Size = new global::System.Drawing.Size(442, 485);
			this.panel1.TabIndex = 8;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.plShowNangCao.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.plShowNangCao.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plShowNangCao.Controls.Add(this.ckbBatThongBaoDangNhap);
			this.plShowNangCao.Controls.Add(this.panel2);
			this.plShowNangCao.Controls.Add(this.panel3);
			this.plShowNangCao.Controls.Add(this.btnShowNangCao);
			this.plShowNangCao.Controls.Add(this.ckbAutoLinkInstagram);
			this.plShowNangCao.Controls.Add(this.ckbReviewTag);
			this.plShowNangCao.Controls.Add(this.ckbAllowFollow);
			this.plShowNangCao.Controls.Add(this.ckbGetToken);
			this.plShowNangCao.Controls.Add(this.label2);
			this.plShowNangCao.Controls.Add(this.ckbLogOutOldDevice);
			this.plShowNangCao.Controls.Add(this.ckbCreateShortcut);
			this.plShowNangCao.Controls.Add(this.label3);
			this.plShowNangCao.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.plShowNangCao.Location = new global::System.Drawing.Point(11, 253);
			this.plShowNangCao.MaximumSize = new global::System.Drawing.Size(420, 162);
			this.plShowNangCao.MinimumSize = new global::System.Drawing.Size(420, 27);
			this.plShowNangCao.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWkhSa2hQVkU1VllsVmFNVmRxUWs5aFIwb3pVRlF3UFE9PQ=="))))))));
			this.plShowNangCao.Size = new global::System.Drawing.Size(420, 28);
			this.plShowNangCao.TabIndex = 3;
			this.ckbBatThongBaoDangNhap.AutoSize = true;
			this.ckbBatThongBaoDangNhap.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbBatThongBaoDangNhap.Location = new global::System.Drawing.Point(227, 134);
			this.ckbBatThongBaoDangNhap.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSblJTYWtKWFVqSm9NbGx0TVd0Uk1XeFlUMVZXV2xaNlZuVldSekZ2WVVkT1FsQlVNRDA9"))))))));
			this.ckbBatThongBaoDangNhap.Size = new global::System.Drawing.Size(170, 20);
			this.ckbBatThongBaoDangNhap.TabIndex = 7;
			this.ckbBatThongBaoDangNhap.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZoV1NFNXVTbGxWVjJSclVqSndSV1JGWXpGaWEyeElWRVZTZGxaNmFHNWxSWEJKVWxkamVVNVhOVXBTZWxaMlRrZEtlR1JIVGtKUVZEQTk="))))))));
			this.ckbBatThongBaoDangNhap.UseVisualStyleBackColor = true;
			this.panel2.Controls.Add(this.rbLoginEmailPass);
			this.panel2.Controls.Add(this.rbLoginUidPass);
			this.panel2.Controls.Add(this.rbLoginCookie);
			this.panel2.Location = new global::System.Drawing.Point(134, 31);
			this.panel2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJzOQ=="))))))));
			this.panel2.Size = new global::System.Drawing.Size(273, 26);
			this.panel2.TabIndex = 6;
			this.rbLoginEmailPass.AutoSize = true;
			this.rbLoginEmailPass.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbLoginEmailPass.Location = new global::System.Drawing.Point(93, 3);
			this.rbLoginEmailPass.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUlhTWGxhU0VKcFlURmFNRmRXWkhOak1WWklVbTV3YW1SNk1Eaz0="))))))));
			this.rbLoginEmailPass.Size = new global::System.Drawing.Size(89, 20);
			this.rbLoginEmailPass.TabIndex = 4;
			this.rbLoginEmailPass.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld4amVHRkhSbGhsUkdoV1VqQmFObGt6WXpsUVVUMDk="))))))));
			this.rbLoginEmailPass.UseVisualStyleBackColor = true;
			this.rbLoginUidPass.AutoSize = true;
			this.rbLoginUidPass.Checked = true;
			this.rbLoginUidPass.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbLoginUidPass.Location = new global::System.Drawing.Point(3, 3);
			this.rbLoginUidPass.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUlhTWGxhU0VKcFlrWmFkMWRyV2tOaFIwMTZWRlF3UFE9PQ=="))))))));
			this.rbLoginUidPass.Size = new global::System.Drawing.Size(76, 20);
			this.rbLoginUidPass.TabIndex = 4;
			this.rbLoginUidPass.TabStop = true;
			this.rbLoginUidPass.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14a2MyRXlXa2RSYldocVRUQXdPUT09"))))))));
			this.rbLoginUidPass.UseVisualStyleBackColor = true;
			this.rbLoginCookie.AutoSize = true;
			this.rbLoginCookie.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbLoginCookie.Location = new global::System.Drawing.Point(196, 3);
			this.rbLoginCookie.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUlhTWGxhU0VKcFlUQTFNbGxxU2pCalJuQlNVRlF3UFE9PQ=="))))))));
			this.rbLoginCookie.Size = new global::System.Drawing.Size(64, 20);
			this.rbLoginCookie.TabIndex = 4;
			this.rbLoginCookie.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNjOQ=="))))))));
			this.rbLoginCookie.UseVisualStyleBackColor = true;
			this.btnShowNangCao.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.btnShowNangCao.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnShowNangCao.FlatAppearance.BorderSize = 0;
			this.btnShowNangCao.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnShowNangCao.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnShowNangCao.ForeColor = global::System.Drawing.Color.Black;
			this.btnShowNangCao.Image = global::maxcare.Properties.Resources.icons8_expand_arrow_24px;
			this.btnShowNangCao.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnShowNangCao.Location = new global::System.Drawing.Point(0, 0);
			this.btnShowNangCao.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWWGxoU0ZwclRVUldiMWx0TVd0U1JteFlUMFF3UFE9PQ=="))))))));
			this.btnShowNangCao.Size = new global::System.Drawing.Size(418, 26);
			this.btnShowNangCao.TabIndex = 2;
			this.btnShowNangCao.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1rcDZWREpzYVdKWFRtNVhWRXBIWkdjOVBRPT0="))))))));
			this.btnShowNangCao.UseVisualStyleBackColor = false;
			this.btnShowNangCao.Click += new global::System.EventHandler(this.button1_Click);
			this.ckbReviewTag.AutoSize = true;
			this.ckbReviewTag.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbReviewTag.Location = new global::System.Drawing.Point(16, 134);
			this.ckbReviewTag.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldWblJXYWtwb1ZqRlplbFpyWkVkaVp6MDk="))))))));
			this.ckbReviewTag.Size = new global::System.Drawing.Size(189, 20);
			this.ckbReviewTag.TabIndex = 2;
			this.ckbReviewTag.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZoV1NFNXVTbGxWVjJSaFUwWlpNVTVIU2pGVFIxSkVVVzFzTTA1clNuZFRWV2hoWTBSU2FXTlRPV3RSTUVsM1dUTk9VR05YU25CUmFrSTBZMnRTYjJSVVZYaGtWbkF6VUZRd1BRPT0="))))))));
			this.ckbReviewTag.UseVisualStyleBackColor = true;
			this.plShowCoBan.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plShowCoBan.Controls.Add(this.plRepeatAll);
			this.plShowCoBan.Controls.Add(this.ckbGetCookie);
			this.plShowCoBan.Controls.Add(this.ckbCreateProfile);
			this.plShowCoBan.Controls.Add(this.btnShowCoBan);
			this.plShowCoBan.Controls.Add(this.ckbDontSaveBrowser);
			this.plShowCoBan.Controls.Add(this.ckbCheckLiveUid);
			this.plShowCoBan.Controls.Add(this.ckbCapNhatThongTin);
			this.plShowCoBan.Controls.Add(this.ckbRepeatAll);
			this.plShowCoBan.Controls.Add(this.ckbLogOut);
			this.plShowCoBan.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.plShowCoBan.Location = new global::System.Drawing.Point(11, 44);
			this.plShowCoBan.MaximumSize = new global::System.Drawing.Size(420, 203);
			this.plShowCoBan.MinimumSize = new global::System.Drawing.Size(420, 27);
			this.plShowCoBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWkhSa2hQVkU1U1RXcHNSRmRXWXpCUVVUMDk="))))))));
			this.plShowCoBan.Size = new global::System.Drawing.Size(420, 203);
			this.plShowCoBan.TabIndex = 3;
			this.plRepeatAll.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plRepeatAll.Controls.Add(this.label6);
			this.plRepeatAll.Controls.Add(this.label4);
			this.plRepeatAll.Controls.Add(this.nudDelayTurnFrom);
			this.plRepeatAll.Controls.Add(this.label5);
			this.plRepeatAll.Controls.Add(this.nudDelayTurnTo);
			this.plRepeatAll.Controls.Add(this.label11);
			this.plRepeatAll.Controls.Add(this.nudSoLuotChay);
			this.plRepeatAll.Controls.Add(this.label10);
			this.plRepeatAll.Location = new global::System.Drawing.Point(36, 131);
			this.plRepeatAll.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GVXhjRmxSYlhoYVYwWktRMWxyWkROUVVUMDk="))))))));
			this.plRepeatAll.Size = new global::System.Drawing.Size(376, 64);
			this.plRepeatAll.TabIndex = 13;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(3, 6);
			this.label6.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtrOQ=="))))))));
			this.label6.Size = new global::System.Drawing.Size(84, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDZWVmRrV2sxdGFHOWxhM1JQVGxVNWJsQlVNRDA9"))))))));
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(3, 34);
			this.label4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtFOQ=="))))))));
			this.label4.Size = new global::System.Drawing.Size(145, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEZOUjJSYVRXMW9iMlZyZEU5T1ZXeElaV3RrZWxSWFJtOWxhM1JQVFVWc1NWVnVRak5PYmtwT1dqRm9RbG95VWtoaFIzaHBaVzA0T1E9PQ=="))))))));
			this.nudDelayTurnFrom.Location = new global::System.Drawing.Point(154, 32);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudDelayTurnFrom;
			int[] array = new int[4];
			array[0] = 276447231;
			array[1] = 23283;
			numericUpDown.Maximum = new decimal(array);
			this.nudDelayTurnFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbHBHYUV0a1ZrcDFVMjVhYVZWVU1Eaz0="))))))));
			this.nudDelayTurnFrom.Size = new global::System.Drawing.Size(65, 23);
			this.nudDelayTurnFrom.TabIndex = 9;
			this.label5.Location = new global::System.Drawing.Point(222, 7);
			this.label5.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtVOQ=="))))))));
			this.label5.Size = new global::System.Drawing.Size(30, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1dzeGFHUXphSGhUUlRGMlRURkZPUT09"))))))));
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.Click += new global::System.EventHandler(this.label5_Click);
			this.nudDelayTurnTo.Location = new global::System.Drawing.Point(252, 32);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudDelayTurnTo;
			int[] array2 = new int[4];
			array2[0] = 276447231;
			array2[1] = 23283;
			numericUpDown2.Maximum = new decimal(array2);
			this.nudDelayTurnTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbHBHYUV0a1ZscElUMFF3UFE9PQ=="))))))));
			this.nudDelayTurnTo.Size = new global::System.Drawing.Size(65, 23);
			this.nudDelayTurnTo.TabIndex = 8;
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(320, 35);
			this.label11.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1ZWUXdPUT09"))))))));
			this.label11.Size = new global::System.Drawing.Size(33, 16);
			this.label11.TabIndex = 11;
			this.label11.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2NWSklWblZWVkRBOQ=="))))))));
			this.nudSoLuotChay.Location = new global::System.Drawing.Point(154, 4);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudSoLuotChay;
			int[] array3 = new int[4];
			array3[0] = 276447231;
			array3[1] = 23283;
			numericUpDown3.Maximum = new decimal(array3);
			this.nudSoLuotChay.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHJkMVZVU205aFIxWlNVRlF3UFE9PQ=="))))))));
			this.nudSoLuotChay.Size = new global::System.Drawing.Size(65, 23);
			this.nudSoLuotChay.TabIndex = 7;
			this.label10.Location = new global::System.Drawing.Point(222, 35);
			this.label10.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1VWUXdPUT09"))))))));
			this.label10.Size = new global::System.Drawing.Size(29, 16);
			this.label10.TabIndex = 12;
			this.label10.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NXRklWbmxQV0ZVOQ=="))))))));
			this.label10.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnShowCoBan.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.btnShowCoBan.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnShowCoBan.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnShowCoBan.FlatAppearance.BorderSize = 0;
			this.btnShowCoBan.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnShowCoBan.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnShowCoBan.ForeColor = global::System.Drawing.Color.Black;
			this.btnShowCoBan.Image = global::maxcare.Properties.Resources.icons8_collapse_arrow_24px;
			this.btnShowCoBan.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnShowCoBan.Location = new global::System.Drawing.Point(0, 0);
			this.btnShowCoBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWWGxoU0ZwclRVVTFNbFZYTVVka1VUMDk="))))))));
			this.btnShowCoBan.Size = new global::System.Drawing.Size(418, 25);
			this.btnShowCoBan.TabIndex = 2;
			this.btnShowCoBan.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1XczBXVmRvU2xJd2VHOWtXRVpQWkZFOVBRPT0="))))))));
			this.btnShowCoBan.UseVisualStyleBackColor = false;
			this.btnShowCoBan.Click += new global::System.EventHandler(this.button5_Click);
			this.ckbDontSaveBrowser.AutoSize = true;
			this.ckbDontSaveBrowser.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbDontSaveBrowser.Location = new global::System.Drawing.Point(222, 83);
			this.ckbDontSaveBrowser.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldTa2hQV0ZaclVtczFiMXBITVZkUk1rNTBUMVJPYWsxc1dqVT0="))))))));
			this.ckbDontSaveBrowser.Size = new global::System.Drawing.Size(200, 20);
			this.ckbDontSaveBrowser.TabIndex = 2;
			this.ckbDontSaveBrowser.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqTndTR013YUZaYU1sSkpWRVZTZVZKNlZuWlRWV1JUVFZkV2JGSjZaRzlOTVVadVdWUktiMk5GYkVobFNGcGhUVzE0TVE9PQ=="))))))));
			this.ckbDontSaveBrowser.UseVisualStyleBackColor = true;
			this.ckbCheckLiveUid.AutoSize = true;
			this.ckbCheckLiveUid.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbCheckLiveUid.Location = new global::System.Drawing.Point(16, 83);
			this.ckbCheckLiveUid.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSWGxoUjNoYVRXNVNUbGxXYUdGaVJscFlZa2R6UFE9PQ=="))))))));
			this.ckbCheckLiveUid.Size = new global::System.Drawing.Size(193, 20);
			this.ckbCheckLiveUid.TabIndex = 2;
			this.ckbCheckLiveUid.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVlVqSjNlVmRzVGtOV2JVWllWVmRrYTFORmVFaGpNRGxJVGpJd2VWUlhaR2hOYldoM1UxVmtUMko2VW1salYyaHNWVlF3T1E9PQ=="))))))));
			this.ckbCheckLiveUid.UseVisualStyleBackColor = true;
			this.timer1.Interval = 15;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.timer2.Interval = 15;
			this.timer2.Tick += new global::System.EventHandler(this.timer2_Tick);
			this.rbLoginMbasic.AutoSize = true;
			this.rbLoginMbasic.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbLoginMbasic.Location = new global::System.Drawing.Point(161, 3);
			this.rbLoginMbasic.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUlhTWGxhU0VKcFlYcEdjRmRXYUU5alJtd3pVRlF3UFE9PQ=="))))))));
			this.rbLoginMbasic.Size = new global::System.Drawing.Size(66, 20);
			this.rbLoginMbasic.TabIndex = 5;
			this.rbLoginMbasic.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1MyRkhUWGxpUjI4OQ=="))))))));
			this.rbLoginMbasic.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(442, 485);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.bunifuCards1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMFQyRkhVbFpoU0VKcFlsZG9WbHBHWXpWa1ZtOTRWVzFvV21SNk1Eaz0="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMFIyRXhjRVpYYmtKcFVqRlZPUT09"))))))));
			base.Load += new global::System.EventHandler(this.fCauHinhTuongTac_Load);
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.plTuongTacKichBan.ResumeLayout(false);
			this.plTuongTacKichBan.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.plShowNangCao.ResumeLayout(false);
			this.plShowNangCao.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.plShowCoBan.ResumeLayout(false);
			this.plShowCoBan.PerformLayout();
			this.plRepeatAll.ResumeLayout(false);
			this.plRepeatAll.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTurnFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudDelayTurnTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuotChay).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000D49 RID: 3401
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000D4A RID: 3402
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000D4B RID: 3403
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000D4C RID: 3404
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000D4D RID: 3405
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000D4E RID: 3406
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000D4F RID: 3407
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000D50 RID: 3408
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000D51 RID: 3409
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000D52 RID: 3410
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000D53 RID: 3411
		private global::System.Windows.Forms.RadioButton rbTuongTacNhanh;

		// Token: 0x04000D54 RID: 3412
		private global::System.Windows.Forms.RadioButton rbTuongTacKichBan;

		// Token: 0x04000D55 RID: 3413
		private global::MetroFramework.Controls.MetroButton btnCauHinhTuongTacNhanh;

		// Token: 0x04000D56 RID: 3414
		private global::System.Windows.Forms.Panel plTuongTacKichBan;

		// Token: 0x04000D57 RID: 3415
		private global::System.Windows.Forms.CheckBox ckbRandomHanhDong;

		// Token: 0x04000D58 RID: 3416
		private global::System.Windows.Forms.ComboBox cbbKichBan;

		// Token: 0x04000D59 RID: 3417
		private global::MetroFramework.Controls.MetroButton btnQuanLyKichBan;

		// Token: 0x04000D5A RID: 3418
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000D5B RID: 3419
		private global::System.Windows.Forms.CheckBox ckbCreateProfile;

		// Token: 0x04000D5C RID: 3420
		private global::System.Windows.Forms.CheckBox ckbGetCookie;

		// Token: 0x04000D5D RID: 3421
		private global::System.Windows.Forms.CheckBox ckbCapNhatThongTin;

		// Token: 0x04000D5E RID: 3422
		private global::System.Windows.Forms.CheckBox ckbGetToken;

		// Token: 0x04000D5F RID: 3423
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000D60 RID: 3424
		private global::System.Windows.Forms.CheckBox ckbRepeatAll;

		// Token: 0x04000D61 RID: 3425
		private global::System.Windows.Forms.CheckBox ckbLogOut;

		// Token: 0x04000D62 RID: 3426
		private global::System.Windows.Forms.CheckBox ckbLogOutOldDevice;

		// Token: 0x04000D63 RID: 3427
		private global::System.Windows.Forms.CheckBox ckbAutoLinkInstagram;

		// Token: 0x04000D64 RID: 3428
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000D65 RID: 3429
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000D66 RID: 3430
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000D67 RID: 3431
		private global::System.Windows.Forms.RadioButton rbLoginWWW;

		// Token: 0x04000D68 RID: 3432
		private global::System.Windows.Forms.RadioButton rbLoginMFB;

		// Token: 0x04000D69 RID: 3433
		private global::System.Windows.Forms.CheckBox ckbCreateShortcut;

		// Token: 0x04000D6A RID: 3434
		private global::System.Windows.Forms.CheckBox ckbAllowFollow;

		// Token: 0x04000D6B RID: 3435
		private global::System.Windows.Forms.Panel plShowCoBan;

		// Token: 0x04000D6C RID: 3436
		private global::System.Windows.Forms.Button btnShowCoBan;

		// Token: 0x04000D6D RID: 3437
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000D6E RID: 3438
		private global::System.Windows.Forms.Panel plShowNangCao;

		// Token: 0x04000D6F RID: 3439
		private global::System.Windows.Forms.Button btnShowNangCao;

		// Token: 0x04000D70 RID: 3440
		private global::System.Windows.Forms.Timer timer2;

		// Token: 0x04000D71 RID: 3441
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000D72 RID: 3442
		private global::System.Windows.Forms.RadioButton rbLoginEmailPass;

		// Token: 0x04000D73 RID: 3443
		private global::System.Windows.Forms.RadioButton rbLoginUidPass;

		// Token: 0x04000D74 RID: 3444
		private global::System.Windows.Forms.RadioButton rbLoginCookie;

		// Token: 0x04000D75 RID: 3445
		private global::System.Windows.Forms.Panel plRepeatAll;

		// Token: 0x04000D76 RID: 3446
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000D77 RID: 3447
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000D78 RID: 3448
		private global::System.Windows.Forms.NumericUpDown nudDelayTurnFrom;

		// Token: 0x04000D79 RID: 3449
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000D7A RID: 3450
		private global::System.Windows.Forms.NumericUpDown nudDelayTurnTo;

		// Token: 0x04000D7B RID: 3451
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000D7C RID: 3452
		private global::System.Windows.Forms.NumericUpDown nudSoLuotChay;

		// Token: 0x04000D7D RID: 3453
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000D7E RID: 3454
		private global::System.Windows.Forms.CheckBox ckbReviewTag;

		// Token: 0x04000D7F RID: 3455
		private global::System.Windows.Forms.CheckBox ckbCheckLiveUid;

		// Token: 0x04000D80 RID: 3456
		private global::System.Windows.Forms.CheckBox ckbDontSaveBrowser;

		// Token: 0x04000D81 RID: 3457
		private global::System.Windows.Forms.CheckBox ckbBatThongBaoDangNhap;

		// Token: 0x04000D82 RID: 3458
		private global::System.Windows.Forms.RadioButton rbLoginMbasic;
	}
}
