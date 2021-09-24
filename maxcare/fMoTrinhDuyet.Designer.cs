namespace maxcare
{
	// Token: 0x020000A6 RID: 166
	public partial class fMoTrinhDuyet : global::System.Windows.Forms.Form
	{
		// Token: 0x0600063F RID: 1599 RVA: 0x000BEA84 File Offset: 0x000BCC84
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000BEAE4 File Offset: 0x000BCCE4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fMoTrinhDuyet));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.ckbLoginHotmail = new global::System.Windows.Forms.CheckBox();
			this.txtLink = new global::System.Windows.Forms.TextBox();
			this.btnCauHinh = new global::MetroFramework.Controls.MetroButton();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.rbLoginWWW = new global::System.Windows.Forms.RadioButton();
			this.rbLoginMFB = new global::System.Windows.Forms.RadioButton();
			this.label4 = new global::System.Windows.Forms.Label();
			this.ckbAutoOpenLink = new global::System.Windows.Forms.CheckBox();
			this.ckbAutoCloseChromeLoginFail = new global::System.Windows.Forms.CheckBox();
			this.ckbKhongLuuTrinhDuyet = new global::System.Windows.Forms.CheckBox();
			this.ckbGetCookie = new global::System.Windows.Forms.CheckBox();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.rbSuDungProfile = new global::System.Windows.Forms.RadioButton();
			this.rbKhongDungProfile = new global::System.Windows.Forms.RadioButton();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.rbLoginEmailPass = new global::System.Windows.Forms.RadioButton();
			this.rbLoginUidPass = new global::System.Windows.Forms.RadioButton();
			this.rbLoginCookie = new global::System.Windows.Forms.RadioButton();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.plAddChromeVaoFormView = new global::System.Windows.Forms.Panel();
			this.nudWidthChrome = new global::System.Windows.Forms.NumericUpDown();
			this.label35 = new global::System.Windows.Forms.Label();
			this.label33 = new global::System.Windows.Forms.Label();
			this.nudHeighChrome = new global::System.Windows.Forms.NumericUpDown();
			this.ckbAddChromeIntoForm = new global::System.Windows.Forms.CheckBox();
			this.plSapXepCuaSoChrome = new global::System.Windows.Forms.Panel();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.cbbColumnChrome = new global::System.Windows.Forms.ComboBox();
			this.cbbRowChrome = new global::System.Windows.Forms.ComboBox();
			this.bunifuCards1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.plAddChromeVaoFormView.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudWidthChrome).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudHeighChrome).BeginInit();
			this.plSapXepCuaSoChrome.SuspendLayout();
			base.SuspendLayout();
			this.bunifuCards1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(1, 0);
			this.bunifuCards1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RXdGFOVmRyYUU1bFFUMDk="))))))));
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(452, 38);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCak1XTXhUa2hXYldoaFVqRmFOUT09"))))))));
			this.pnlHeader.Size = new global::System.Drawing.Size(452, 32);
			this.pnlHeader.TabIndex = 9;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
			this.pictureBox1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaUVVUMDk="))))))));
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			this.btnMinimize.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.btnMinimize.Location = new global::System.Drawing.Point(419, -1);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(452, 32);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1WSnNVbnBrZFdWVlNYZFpNMDVRWXpKS2RGb3laR0ZUUmxreFRrZEtNVk5IVWtKUVZEQTk="))))))));
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(233, 381);
			this.btnCancel.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxTYmxaYVRXeGFlZz09"))))))));
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1EyUnVjRXBTYmxaaFpIb3dPUT09"))))))));
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.plSapXepCuaSoChrome);
			this.panel1.Controls.Add(this.plAddChromeVaoFormView);
			this.panel1.Controls.Add(this.ckbAddChromeIntoForm);
			this.panel1.Controls.Add(this.ckbLoginHotmail);
			this.panel1.Controls.Add(this.txtLink);
			this.panel1.Controls.Add(this.btnCauHinh);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.ckbAutoOpenLink);
			this.panel1.Controls.Add(this.ckbAutoCloseChromeLoginFail);
			this.panel1.Controls.Add(this.ckbKhongLuuTrinhDuyet);
			this.panel1.Controls.Add(this.ckbGetCookie);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJjOQ=="))))))));
			this.panel1.Size = new global::System.Drawing.Size(453, 423);
			this.panel1.TabIndex = 5;
			this.ckbLoginHotmail.AutoSize = true;
			this.ckbLoginHotmail.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbLoginHotmail.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbLoginHotmail.Location = new global::System.Drawing.Point(37, 346);
			this.ckbLoginHotmail.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldVa2hQVnpWb1ZucFdTbGxxVGxOa1JteFlZa2hOUFE9PQ=="))))))));
			this.ckbLoginHotmail.Size = new global::System.Drawing.Size(185, 20);
			this.ckbLoginHotmail.TabIndex = 25;
			this.ckbLoginHotmail.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNHpUbFJTUlZaeVdsVmpNMkpXWXpGaWEyeE9WVEZLTkZOVk5URlhibXhEWkZkR1VGSjZXbmxYUlVadVdWVmpOVTFIU2xoU2JrSnBVVlF3T1E9PQ=="))))))));
			this.ckbLoginHotmail.UseVisualStyleBackColor = true;
			this.txtLink.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtLink.Location = new global::System.Drawing.Point(183, 318);
			this.txtLink.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1pIb3dPUT09"))))))));
			this.txtLink.Size = new global::System.Drawing.Size(233, 23);
			this.txtLink.TabIndex = 24;
			this.txtLink.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.btnCauHinh.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCauHinh.Location = new global::System.Drawing.Point(160, 62);
			this.btnCauHinh.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxTYWtaVVVqSjRNVmxWUlRsUVVUMDk="))))))));
			this.btnCauHinh.Size = new global::System.Drawing.Size(75, 23);
			this.btnCauHinh.TabIndex = 5;
			this.btnCauHinh.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1UVVUMDk="))))))));
			this.btnCauHinh.UseSelectable = true;
			this.btnCauHinh.Click += new global::System.EventHandler(this.metroButton1_Click);
			this.panel5.Controls.Add(this.rbLoginWWW);
			this.panel5.Controls.Add(this.rbLoginMFB);
			this.panel5.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.panel5.Location = new global::System.Drawing.Point(157, 155);
			this.panel5.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrZWtVOQ=="))))))));
			this.panel5.Size = new global::System.Drawing.Size(273, 26);
			this.panel5.TabIndex = 23;
			this.rbLoginWWW.AutoSize = true;
			this.rbLoginWWW.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbLoginWWW.Location = new global::System.Drawing.Point(127, 3);
			this.rbLoginWWW.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUlhTWGxhU0VKcFlrZFNXVlp1WXpsUVVUMDk="))))))));
			this.rbLoginWWW.Size = new global::System.Drawing.Size(99, 20);
			this.rbLoginWWW.TabIndex = 4;
			this.rbLoginWWW.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tST2EwMHdlSFJYYld4TllsVTFNbGxzUlRsUVVUMDk="))))))));
			this.rbLoginWWW.UseVisualStyleBackColor = true;
			this.rbLoginMFB.AutoSize = true;
			this.rbLoginMFB.Checked = true;
			this.rbLoginMFB.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbLoginMFB.Location = new global::System.Drawing.Point(3, 3);
			this.rbLoginMFB.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUlhTWGxhU0VKcFlYcEdTRlZYWXpsUVVUMDk="))))))));
			this.rbLoginMFB.Size = new global::System.Drawing.Size(120, 20);
			this.rbLoginMFB.TabIndex = 4;
			this.rbLoginMFB.TabStop = true;
			this.rbLoginMFB.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4Tk1XSldiRmhVYlhoYVlsUnNNbGxZYXpGaGJVbDVUVVF3UFE9PQ=="))))))));
			this.rbLoginMFB.UseVisualStyleBackColor = true;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(34, 160);
			this.label4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtFOQ=="))))))));
			this.label4.Size = new global::System.Drawing.Size(111, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10b1MyRkhTblJaTW1RMFUydG9SbHA2U1RGaWEyeElUbGM1TTA1cmVFNWllazVDVG1jOVBRPT0="))))))));
			this.ckbAutoOpenLink.AutoSize = true;
			this.ckbAutoOpenLink.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbAutoOpenLink.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbAutoOpenLink.Location = new global::System.Drawing.Point(37, 320);
			this.ckbAutoOpenLink.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVUnNNMWRzWXpGVVYwWllUbGhKUFE9PQ=="))))))));
			this.ckbAutoOpenLink.Size = new global::System.Drawing.Size(150, 20);
			this.ckbAutoOpenLink.TabIndex = 21;
			this.ckbAutoOpenLink.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNHpUbFJTUlZaeVdsVmpNMkpXWXpGaWEyeElUVEpvTVU1VWFHNWFSRXBYWVZkTmVXSkVRbUZXUnpnNQ=="))))))));
			this.ckbAutoOpenLink.UseVisualStyleBackColor = true;
			this.ckbAutoOpenLink.CheckedChanged += new global::System.EventHandler(this.ckbAutoOpenLink_CheckedChanged);
			this.ckbAutoCloseChromeLoginFail.AutoSize = true;
			this.ckbAutoCloseChromeLoginFail.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbAutoCloseChromeLoginFail.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbAutoCloseChromeLoginFail.Location = new global::System.Drawing.Point(37, 294);
			this.ckbAutoCloseChromeLoginFail.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVVTFlbGxxVGs5aVJrVjVZVWhzYVUxcVJuTldSV00xWW0xR1dFNVZaRnBXTW5oNg=="))))))));
			this.ckbAutoCloseChromeLoginFail.Size = new global::System.Drawing.Size(327, 20);
			this.ckbAutoCloseChromeLoginFail.TabIndex = 21;
			this.ckbAutoCloseChromeLoginFail.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNHpUbFJTUlZaeVdsVmpNMkpXWXpGaWEyeE9WVEZLTTA0d05URlhibXhEWkZkR1VGSjZaSGxOYWxaMVUxVm9VMkZHYkhCUmJYQm9VMFZ3TWxsc1pGWmFNMmhMVTBWV2JrMXFWblZUVldNeFlucFNhV05ZVW1wUk1FbDNXVlU1U0U1dVFsbFZWMlJhWkZWak1tSXhaSEpRVVQwOQ=="))))))));
			this.ckbAutoCloseChromeLoginFail.UseVisualStyleBackColor = true;
			this.ckbKhongLuuTrinhDuyet.AutoSize = true;
			this.ckbKhongLuuTrinhDuyet.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbKhongLuuTrinhDuyet.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbKhongLuuTrinhDuyet.Location = new global::System.Drawing.Point(37, 242);
			this.ckbKhongLuuTrinhDuyet.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNUbHBHYUZkV1YwNTBZa2hXYUZKV1NYaGFWbVJYVFVFOVBRPT0="))))))));
			this.ckbKhongLuuTrinhDuyet.Size = new global::System.Drawing.Size(233, 20);
			this.ckbKhongLuuTrinhDuyet.TabIndex = 21;
			this.ckbKhongLuuTrinhDuyet.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqTndTR013YUZaYU1sSkpWRVZTZVZKNlZuWlRWV1JUVFZkV2JGSjZaRzlOTVVadVdWUktiMk5GYkU1Vk1VbzBVMVUxTVZkdWJFTmtWMFpRVW5wYWVWZEZSVGs9"))))))));
			this.ckbKhongLuuTrinhDuyet.UseVisualStyleBackColor = true;
			this.ckbGetCookie.AutoSize = true;
			this.ckbGetCookie.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbGetCookie.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbGetCookie.Location = new global::System.Drawing.Point(37, 268);
			this.ckbGetCookie.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldTWGxXYWtKU1RXcHNNbGxVU25OaVFUMDk="))))))));
			this.ckbGetCookie.Size = new global::System.Drawing.Size(345, 20);
			this.ckbGetCookie.TabIndex = 21;
			this.ckbGetCookie.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNHpUbFJTUlZaeVdsVmpNMkpXWXpGaWEyeElWVWRvTVdOVVJqTlRWV014WW5wU2FXTllVbXRSTUVwRldXcEpOV050UmxoV1YyUnFUV3RaZUZOVlpEQmlNa1pVVWtWV2Nsa3hUa1ZaYlRGcVdqSktkR0Z0YURGalZFWXpVMVZvVTJJell6SlJibFpvVVRCS2NXUjZaRk5rVm5BelVGUXdQUT09"))))))));
			this.ckbGetCookie.UseVisualStyleBackColor = true;
			this.btnSave.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSave.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnSave.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSave.ForeColor = global::System.Drawing.Color.White;
			this.btnSave.Location = new global::System.Drawing.Point(125, 381);
			this.btnSave.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWWGxTYWtwaFZWUXdPUT09"))))))));
			this.btnSave.Size = new global::System.Drawing.Size(92, 29);
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVeGFHUXlVbEpRVkRBOQ=="))))))));
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.panel3.Controls.Add(this.rbSuDungProfile);
			this.panel3.Controls.Add(this.rbKhongDungProfile);
			this.panel3.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.panel3.Location = new global::System.Drawing.Point(157, 91);
			this.panel3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTI4OQ=="))))))));
			this.panel3.Size = new global::System.Drawing.Size(273, 26);
			this.panel3.TabIndex = 8;
			this.rbSuDungProfile.AutoSize = true;
			this.rbSuDungProfile.Checked = true;
			this.rbSuDungProfile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbSuDungProfile.Location = new global::System.Drawing.Point(3, 3);
			this.rbSuDungProfile.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxWkhVbFpWYWtacFlsZFNVbGt5TURWaVYwWllaVWQzUFE9PQ=="))))))));
			this.rbSuDungProfile.Size = new global::System.Drawing.Size(114, 20);
			this.rbSuDungProfile.TabIndex = 4;
			this.rbSuDungProfile.TabStop = true;
			this.rbSuDungProfile.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNHpTbFJSYlhNd1dXNVdjMWx0TVdwYU1WWkpVMjVhWVdKWGVIcFhiRVU1VUZFOVBRPT0="))))))));
			this.rbSuDungProfile.UseVisualStyleBackColor = true;
			this.rbKhongDungProfile.AutoSize = true;
			this.rbKhongDungProfile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbKhongDungProfile.Location = new global::System.Drawing.Point(127, 3);
			this.rbKhongDungProfile.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUkhSa2hQV0ZaaFRVWkplRmx0TVd0VlYwNTBUMWN4YUZZemFITT0="))))))));
			this.rbKhongDungProfile.Size = new global::System.Drawing.Size(133, 20);
			this.rbKhongDungProfile.TabIndex = 4;
			this.rbKhongDungProfile.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRlNSV1JXWXpGaWEyeEhVVzVzYVUxc2NIZFphMlJXVUZFOVBRPT0="))))))));
			this.rbKhongDungProfile.UseVisualStyleBackColor = true;
			this.panel2.Controls.Add(this.rbLoginEmailPass);
			this.panel2.Controls.Add(this.rbLoginUidPass);
			this.panel2.Controls.Add(this.rbLoginCookie);
			this.panel2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.panel2.Location = new global::System.Drawing.Point(157, 123);
			this.panel2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJzOQ=="))))))));
			this.panel2.Size = new global::System.Drawing.Size(273, 26);
			this.panel2.TabIndex = 8;
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
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(34, 64);
			this.label3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTI4OQ=="))))))));
			this.label3.Size = new global::System.Drawing.Size(99, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU0yaExVMGRvTVU1V1duZFRWVlp6VlZVNWJsQlVNRDA9"))))))));
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(34, 96);
			this.label1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJjOQ=="))))))));
			this.label1.Size = new global::System.Drawing.Size(105, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVFNVhWbFJSYlhCb1ZEQmpNMkZzWXpCYU1WWkpVMjVhWVdKWGVIcFhiRkoyVUZFOVBRPT0="))))))));
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(34, 128);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(101, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2RXRklWVEJVYWtaS1ZGWk9VMlZGYkU5a1ZuQTFVVzVXYUZSVk9YQmxhM1JQWkRBNWJsQlVNRDA9"))))))));
			this.plAddChromeVaoFormView.Controls.Add(this.nudWidthChrome);
			this.plAddChromeVaoFormView.Controls.Add(this.label35);
			this.plAddChromeVaoFormView.Controls.Add(this.label33);
			this.plAddChromeVaoFormView.Controls.Add(this.nudHeighChrome);
			this.plAddChromeVaoFormView.Location = new global::System.Drawing.Point(224, 185);
			this.plAddChromeVaoFormView.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GRnNjRWhWYTFKb1UwVndNbGxzWkZkV01XeFlUMVZrYVUwd2NEQldiVEZ6WWtkU00xQlVNRDA9"))))))));
			this.plAddChromeVaoFormView.Size = new global::System.Drawing.Size(175, 27);
			this.plAddChromeVaoFormView.TabIndex = 158;
			this.nudWidthChrome.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.nudWidthChrome.Location = new global::System.Drawing.Point(41, 2);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudWidthChrome;
			int[] array = new int[4];
			array[0] = 999999;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudWidthChrome;
			int[] array2 = new int[4];
			array2[0] = 516;
			numericUpDown2.Minimum = new decimal(array2);
			this.nudWidthChrome.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXWGxpUjNSclVqSm9SVmxWYUV0a2JVcFlWbFF3UFE9PQ=="))))))));
			this.nudWidthChrome.Size = new global::System.Drawing.Size(53, 23);
			this.nudWidthChrome.TabIndex = 151;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudWidthChrome;
			int[] array3 = new int[4];
			array3[0] = 516;
			numericUpDown3.Value = new decimal(array3);
			this.label35.AutoSize = true;
			this.label35.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label35.Location = new global::System.Drawing.Point(95, 2);
			this.label35.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCUFZWUXdPUT09"))))))));
			this.label35.Size = new global::System.Drawing.Size(23, 23);
			this.label35.TabIndex = 33;
			this.label35.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpCRk9WQlJQVDA9"))))))));
			this.label33.AutoSize = true;
			this.label33.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label33.Location = new global::System.Drawing.Point(3, 4);
			this.label33.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCT1pIb3dPUT09"))))))));
			this.label33.Size = new global::System.Drawing.Size(37, 16);
			this.label33.TabIndex = 33;
			this.label33.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSS2MwNXNjRlZpZWpBOQ=="))))))));
			this.nudHeighChrome.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.nudHeighChrome.Location = new global::System.Drawing.Point(118, 2);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudHeighChrome;
			int[] array4 = new int[4];
			array4[0] = 999999;
			numericUpDown4.Maximum = new decimal(array4);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.nudHeighChrome;
			int[] array5 = new int[4];
			array5[0] = 1;
			numericUpDown5.Minimum = new decimal(array5);
			this.nudHeighChrome.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUa2hXYmtKaFRXMW9SVmxWYUV0a2JVcFlWbFF3UFE9PQ=="))))))));
			this.nudHeighChrome.Size = new global::System.Drawing.Size(53, 23);
			this.nudHeighChrome.TabIndex = 151;
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.nudHeighChrome;
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Value = new decimal(array6);
			this.ckbAddChromeIntoForm.AutoSize = true;
			this.ckbAddChromeIntoForm.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbAddChromeIntoForm.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbAddChromeIntoForm.Location = new global::System.Drawing.Point(37, 187);
			this.ckbAddChromeIntoForm.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSbGhWYlhSU1RXMW9OVmxxU1hoaVJrNVlUbFJDYVUxR2NESlpNakIzVUZFOVBRPT0="))))))));
			this.ckbAddChromeIntoForm.Size = new global::System.Drawing.Size(188, 20);
			this.ckbAddChromeIntoForm.TabIndex = 157;
			this.ckbAddChromeIntoForm.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZaa1UyRXdiRVpVYlRscVlsUnNNRmRzVGtOTmJtTXlVVzVhU2xKV2NESlpNakIzV2pGYWRHSkhlR3RrZWpBNQ=="))))))));
			this.ckbAddChromeIntoForm.UseVisualStyleBackColor = true;
			this.ckbAddChromeIntoForm.CheckedChanged += new global::System.EventHandler(this.ckbAddChromeIntoForm_CheckedChanged);
			this.plSapXepCuaSoChrome.Controls.Add(this.label10);
			this.plSapXepCuaSoChrome.Controls.Add(this.label11);
			this.plSapXepCuaSoChrome.Controls.Add(this.cbbColumnChrome);
			this.plSapXepCuaSoChrome.Controls.Add(this.cbbRowChrome);
			this.plSapXepCuaSoChrome.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.plSapXepCuaSoChrome.Location = new global::System.Drawing.Point(32, 212);
			this.plSapXepCuaSoChrome.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWkdiRmxSYkd4aFYwVktSVnBHWkVkV1IwbDNWRzA1YW1KVWJEQlhiRVU1VUZFOVBRPT0="))))))));
			this.plSapXepCuaSoChrome.Size = new global::System.Drawing.Size(358, 28);
			this.plSapXepCuaSoChrome.TabIndex = 159;
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.Location = new global::System.Drawing.Point(3, 4);
			this.label10.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1VWUXdPUT09"))))))));
			this.label10.Size = new global::System.Drawing.Size(148, 16);
			this.label10.TabIndex = 33;
			this.label10.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNXVTWHBSVjJSc1ZEQmpNbVJxVGtKYU1XdHlVbnBrZVZZd1ZtNVplWFJJVGpKNFZGRnRjR2hUUlhBeVdXeGtWazVuUFQwPQ=="))))))));
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.Location = new global::System.Drawing.Point(245, 2);
			this.label11.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1ZWUXdPUT09"))))))));
			this.label11.Size = new global::System.Drawing.Size(23, 23);
			this.label11.TabIndex = 33;
			this.label11.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpCRk9WQlJQVDA9"))))))));
			this.cbbColumnChrome.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbColumnChrome.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbColumnChrome.FormattingEnabled = true;
			this.cbbColumnChrome.Items.AddRange(new object[]
			{
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZaRk9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZkak9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZoak9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vkd0Rk9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vkd4Rk9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vkcxak9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vkc1ak9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkRCRk9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkRGRk9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZaU1FsQlJQVDA9"))))))))
			});
			this.cbbColumnChrome.Location = new global::System.Drawing.Point(200, 2);
			this.cbbColumnChrome.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS1MyRldSWGxQV0U1clZucEdNVlZVU205bFYwbDVUVmQzUFE9PQ=="))))))));
			this.cbbColumnChrome.Size = new global::System.Drawing.Size(41, 24);
			this.cbbColumnChrome.TabIndex = 145;
			this.cbbRowChrome.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbRowChrome.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbRowChrome.FormattingEnabled = true;
			this.cbbRowChrome.Items.AddRange(new object[]
			{
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZaRk9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZkak9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZoak9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vkd0Rk9WQlJQVDA9")))))))),
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vkd4Rk9WQlJQVDA9"))))))))
			});
			this.cbbRowChrome.Location = new global::System.Drawing.Point(272, 2);
			this.cbbRowChrome.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS1MyRldWblJQVkU1U1RXMW9OVmxxU1hoaVFUMDk="))))))));
			this.cbbRowChrome.Size = new global::System.Drawing.Size(41, 24);
			this.cbbRowChrome.TabIndex = 145;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(453, 423);
			base.Controls.Add(this.bunifuCards1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxemVHUnNXa2xUYmtKcFlsZG9SbHBHYUhOaVIxSkNVRlF3UFE9PQ=="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMFIyRXhjRVpYYmtKcFVqRlZPUT09"))))))));
			base.Load += new global::System.EventHandler(this.fMoTrinhDuyet_Load);
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.plAddChromeVaoFormView.ResumeLayout(false);
			this.plAddChromeVaoFormView.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudWidthChrome).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudHeighChrome).EndInit();
			this.plSapXepCuaSoChrome.ResumeLayout(false);
			this.plSapXepCuaSoChrome.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040005C5 RID: 1477
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040005C6 RID: 1478
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x040005C7 RID: 1479
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040005C8 RID: 1480
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040005C9 RID: 1481
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040005CA RID: 1482
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040005CB RID: 1483
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040005CC RID: 1484
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040005CD RID: 1485
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040005CE RID: 1486
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x040005CF RID: 1487
		private global::System.Windows.Forms.RadioButton rbSuDungProfile;

		// Token: 0x040005D0 RID: 1488
		private global::System.Windows.Forms.RadioButton rbKhongDungProfile;

		// Token: 0x040005D1 RID: 1489
		private global::MetroFramework.Controls.MetroButton btnCauHinh;

		// Token: 0x040005D2 RID: 1490
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040005D3 RID: 1491
		private global::System.Windows.Forms.RadioButton rbLoginEmailPass;

		// Token: 0x040005D4 RID: 1492
		private global::System.Windows.Forms.RadioButton rbLoginUidPass;

		// Token: 0x040005D5 RID: 1493
		private global::System.Windows.Forms.RadioButton rbLoginCookie;

		// Token: 0x040005D6 RID: 1494
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040005D7 RID: 1495
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040005D8 RID: 1496
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040005D9 RID: 1497
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x040005DA RID: 1498
		private global::System.Windows.Forms.CheckBox ckbGetCookie;

		// Token: 0x040005DB RID: 1499
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x040005DC RID: 1500
		private global::System.Windows.Forms.RadioButton rbLoginWWW;

		// Token: 0x040005DD RID: 1501
		private global::System.Windows.Forms.RadioButton rbLoginMFB;

		// Token: 0x040005DE RID: 1502
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040005DF RID: 1503
		private global::System.Windows.Forms.CheckBox ckbAutoCloseChromeLoginFail;

		// Token: 0x040005E0 RID: 1504
		private global::System.Windows.Forms.TextBox txtLink;

		// Token: 0x040005E1 RID: 1505
		private global::System.Windows.Forms.CheckBox ckbAutoOpenLink;

		// Token: 0x040005E2 RID: 1506
		private global::System.Windows.Forms.CheckBox ckbKhongLuuTrinhDuyet;

		// Token: 0x040005E3 RID: 1507
		private global::System.Windows.Forms.CheckBox ckbLoginHotmail;

		// Token: 0x040005E4 RID: 1508
		private global::System.Windows.Forms.Panel plAddChromeVaoFormView;

		// Token: 0x040005E5 RID: 1509
		private global::System.Windows.Forms.NumericUpDown nudWidthChrome;

		// Token: 0x040005E6 RID: 1510
		private global::System.Windows.Forms.Label label35;

		// Token: 0x040005E7 RID: 1511
		private global::System.Windows.Forms.Label label33;

		// Token: 0x040005E8 RID: 1512
		private global::System.Windows.Forms.NumericUpDown nudHeighChrome;

		// Token: 0x040005E9 RID: 1513
		private global::System.Windows.Forms.CheckBox ckbAddChromeIntoForm;

		// Token: 0x040005EA RID: 1514
		private global::System.Windows.Forms.Panel plSapXepCuaSoChrome;

		// Token: 0x040005EB RID: 1515
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040005EC RID: 1516
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040005ED RID: 1517
		private global::System.Windows.Forms.ComboBox cbbColumnChrome;

		// Token: 0x040005EE RID: 1518
		private global::System.Windows.Forms.ComboBox cbbRowChrome;
	}
}
