namespace maxcare
{
	// Token: 0x020000AE RID: 174
	public partial class fHDBuffViewVideo : global::System.Windows.Forms.Form
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x000CE7A0 File Offset: 0x000CC9A0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000CE800 File Offset: 0x000CCA00
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label10 = new global::System.Windows.Forms.Label();
			this.txtUid = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.nudTimeTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudTimeFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeFrom).BeginInit();
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(359, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1VWjFWbTB4WVdGVlNsaFpWbVJYVFRCc1IxZHVRbUZTTVZveQ=="))))))));
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
			this.pnlHeader.Size = new global::System.Drawing.Size(359, 31);
			this.pnlHeader.TabIndex = 9;
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = global::maxcare.Properties.Resources.btnMinimize_Image;
			this.button1.Location = new global::System.Drawing.Point(328, 1);
			this.button1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1ZWUXdPUT09"))))))));
			this.button1.Size = new global::System.Drawing.Size(30, 30);
			this.button1.TabIndex = 77;
			this.button1.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = global::maxcare.Properties.Resources.icon_64;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
			this.pictureBox1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaUVVUMDk="))))))));
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 76;
			this.pictureBox1.TabStop = false;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.txtUid);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.nudTimeTo);
			this.panel1.Controls.Add(this.nudTimeFrom);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJjOQ=="))))))));
			this.panel1.Size = new global::System.Drawing.Size(362, 391);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(28, 322);
			this.label10.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1VWUXdPUT09"))))))));
			this.label10.Size = new global::System.Drawing.Size(97, 16);
			this.label10.TabIndex = 39;
			this.label10.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VXpCVmVtRklWVEZhU0VKS1VsZDRSbE5WVWtaYU1YQk9WRE5zYVdKWFRuYz0="))))))));
			this.txtUid.Location = new global::System.Drawing.Point(31, 125);
			this.txtUid.Multiline = true;
			this.txtUid.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdXbGhpUjNNOQ=="))))))));
			this.txtUid.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtUid.Size = new global::System.Drawing.Size(297, 194);
			this.txtUid.TabIndex = 41;
			this.txtUid.WordWrap = false;
			this.txtUid.TextChanged += new global::System.EventHandler(this.txtIdPost_TextChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 105);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(177, 16);
			this.label2.TabIndex = 40;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VqRktiMWx0TVc1YU1rMDBWREpvV2sxdFpHNVZNVlpTV2pGYWRHSkhkR0ZXZW1odVV6QlNRbU5GT1c1UVZEQTk="))))))));
			this.nudTimeTo.Location = new global::System.Drawing.Point(231, 78);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudTimeTo;
			int[] array = new int[4];
			array[0] = 999999;
			numericUpDown.Maximum = new decimal(array);
			this.nudTimeTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZteEtNZz09"))))))));
			this.nudTimeTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudTimeTo.TabIndex = 4;
			this.nudTimeFrom.Location = new global::System.Drawing.Point(134, 78);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudTimeFrom;
			int[] array2 = new int[4];
			array2[0] = 999999;
			numericUpDown2.Maximum = new decimal(array2);
			this.nudTimeFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZsWndOVmxxU1hkUVVUMDk="))))))));
			this.nudTimeFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudTimeFrom.TabIndex = 3;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(134, 49);
			this.txtTenHanhDong.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdXa2hXYmxaVVVqQmFNVmxWVmxOa2JVcDBXWG93UFE9PQ=="))))))));
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label7.Location = new global::System.Drawing.Point(196, 80);
			this.label7.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWswOQ=="))))))));
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(289, 80);
			this.label6.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtrOQ=="))))))));
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 36;
			this.label6.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 80);
			this.label5.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtVOQ=="))))))));
			this.label5.Size = new global::System.Drawing.Size(94, 16);
			this.label5.TabIndex = 34;
			this.label5.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NXRklWVEZOV0VKS1VqSlNkMWRXWXpCYU1sWklWbTVTVUZwNk1Eaz0="))))))));
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(27, 52);
			this.label1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJjOQ=="))))))));
			this.label1.Size = new global::System.Drawing.Size(99, 16);
			this.label1.TabIndex = 31;
			this.label1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVHTlhTbkJSYlRsYVdUTnNRbGx0TVc1YU0yaExVMFZTTUZSWWJIRlpiVEZxVG1jOVBRPT0="))))))));
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(188, 347);
			this.btnCancel.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxTYmxaYVRXeGFlZz09"))))))));
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSklUWGxPVnpROQ=="))))))));
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(81, 347);
			this.btnAdd.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSbGhWYlhNOQ=="))))))));
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSklSblJOUkRBOQ=="))))))));
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(359, 37);
			this.bunifuCards1.TabIndex = 28;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 391);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMGIxSldSblZXYlRGaFlrWndkMWRzYUd0V01rWllWVzE0YVdSNk1Eaz0="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1sSk9XVmhrTkdOVldqRlhibXhEVFVoak1sSnRiejA9"))))))));
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000657 RID: 1623
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000658 RID: 1624
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000659 RID: 1625
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400065A RID: 1626
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400065B RID: 1627
		private global::System.Windows.Forms.NumericUpDown nudTimeTo;

		// Token: 0x0400065C RID: 1628
		private global::System.Windows.Forms.NumericUpDown nudTimeFrom;

		// Token: 0x0400065D RID: 1629
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x0400065E RID: 1630
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400065F RID: 1631
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000660 RID: 1632
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000661 RID: 1633
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000662 RID: 1634
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000663 RID: 1635
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000664 RID: 1636
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000665 RID: 1637
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000666 RID: 1638
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000667 RID: 1639
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000668 RID: 1640
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000669 RID: 1641
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400066A RID: 1642
		private global::System.Windows.Forms.TextBox txtUid;

		// Token: 0x0400066B RID: 1643
		private global::System.Windows.Forms.Label label2;
	}
}
