namespace maxcare
{
	// Token: 0x02000121 RID: 289
	public partial class fHDXemWatch : global::System.Windows.Forms.Form
	{
		// Token: 0x06000CC3 RID: 3267 RVA: 0x0027F740 File Offset: 0x0027D940
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0027F7A0 File Offset: 0x0027D9A0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fHDXemWatch));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.plCountComment = new global::System.Windows.Forms.Panel();
			this.nudCountCommentFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.nudCountCommentTo = new global::System.Windows.Forms.NumericUpDown();
			this.plCountShareWall = new global::System.Windows.Forms.Panel();
			this.nudCountShareFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.nudCountShareTo = new global::System.Windows.Forms.NumericUpDown();
			this.plCountLike = new global::System.Windows.Forms.Panel();
			this.nudCountLikeFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.nudCountLikeTo = new global::System.Windows.Forms.NumericUpDown();
			this.plComment = new global::System.Windows.Forms.Panel();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.txtComment = new global::System.Windows.Forms.RichTextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.ckbComment = new global::System.Windows.Forms.CheckBox();
			this.ckbShareWall = new global::System.Windows.Forms.CheckBox();
			this.ckbInteract = new global::System.Windows.Forms.CheckBox();
			this.nudTimeWatchTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudTimeWatchFrom = new global::System.Windows.Forms.NumericUpDown();
			this.nudSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.txtTenHanhDong = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.plFollow = new global::System.Windows.Forms.Panel();
			this.nudFollowFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.nudFollowTo = new global::System.Windows.Forms.NumericUpDown();
			this.ckbFollow = new global::System.Windows.Forms.CheckBox();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.plCountComment.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).BeginInit();
			this.plCountShareWall.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountShareFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountShareTo).BeginInit();
			this.plCountLike.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).BeginInit();
			this.plComment.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeWatchTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeWatchFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.plFollow.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudFollowFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudFollowTo).BeginInit();
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
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1XUklWbTVTU2xKdFVtOWFSV1JQWW5jOVBRPT0="))))))));
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
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1ZYcFdTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.button1.Location = new global::System.Drawing.Point(328, 1);
			this.button1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1ZWUXdPUT09"))))))));
			this.button1.Size = new global::System.Drawing.Size(30, 30);
			this.button1.TabIndex = 77;
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
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.plFollow);
			this.panel1.Controls.Add(this.ckbFollow);
			this.panel1.Controls.Add(this.plCountComment);
			this.panel1.Controls.Add(this.plCountShareWall);
			this.panel1.Controls.Add(this.plCountLike);
			this.panel1.Controls.Add(this.plComment);
			this.panel1.Controls.Add(this.ckbComment);
			this.panel1.Controls.Add(this.ckbShareWall);
			this.panel1.Controls.Add(this.ckbInteract);
			this.panel1.Controls.Add(this.nudTimeWatchTo);
			this.panel1.Controls.Add(this.nudSoLuongTo);
			this.panel1.Controls.Add(this.nudTimeWatchFrom);
			this.panel1.Controls.Add(this.nudSoLuongFrom);
			this.panel1.Controls.Add(this.txtTenHanhDong);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJjOQ=="))))))));
			this.panel1.Size = new global::System.Drawing.Size(362, 470);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.plCountComment.Controls.Add(this.nudCountCommentFrom);
			this.plCountComment.Controls.Add(this.label13);
			this.plCountComment.Controls.Add(this.label14);
			this.plCountComment.Controls.Add(this.nudCountCommentTo);
			this.plCountComment.Location = new global::System.Drawing.Point(132, 186);
			this.plCountComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GSkhTWHBXYmxaclVsVTFNbGxzWTNoaVIwcDFWVlF3UFE9PQ=="))))))));
			this.plCountComment.Size = new global::System.Drawing.Size(200, 25);
			this.plCountComment.TabIndex = 44;
			this.nudCountCommentFrom.Location = new global::System.Drawing.Point(1, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudCountCommentFrom;
			int[] array = new int[4];
			array[0] = 999999;
			numericUpDown.Maximum = new decimal(array);
			this.nudCountCommentFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtSVmxxU1hoa1JuQllUbFJDVTJKcmNESlpiRVU1VUZFOVBRPT0="))))))));
			this.nudCountCommentFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountCommentFrom.TabIndex = 1;
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(159, 3);
			this.label13.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1pIb3dPUT09"))))))));
			this.label13.Size = new global::System.Drawing.Size(25, 16);
			this.label13.TabIndex = 35;
			this.label13.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1dzNVNFNXVRWGxPUkRBOQ=="))))))));
			this.label14.Location = new global::System.Drawing.Point(63, 3);
			this.label14.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUFVWUXdPUT09"))))))));
			this.label14.Size = new global::System.Drawing.Size(29, 16);
			this.label14.TabIndex = 37;
			this.label14.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label14.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudCountCommentTo.Location = new global::System.Drawing.Point(98, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudCountCommentTo;
			int[] array2 = new int[4];
			array2[0] = 999999;
			numericUpDown2.Maximum = new decimal(array2);
			this.nudCountCommentTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtSVmxxU1hoa1JuQllUbFJDVjFKNlp6az0="))))))));
			this.nudCountCommentTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountCommentTo.TabIndex = 2;
			this.plCountShareWall.Controls.Add(this.nudCountShareFrom);
			this.plCountShareWall.Controls.Add(this.label11);
			this.plCountShareWall.Controls.Add(this.label12);
			this.plCountShareWall.Controls.Add(this.nudCountShareTo);
			this.plCountShareWall.Location = new global::System.Drawing.Point(132, 158);
			this.plCountShareWall.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GSkhTWHBXYmxaclVtczFkbGRXYUV0aVJsbDVVbTVPYVZGVU1Eaz0="))))))));
			this.plCountShareWall.Size = new global::System.Drawing.Size(200, 25);
			this.plCountShareWall.TabIndex = 43;
			this.nudCountShareFrom.Location = new global::System.Drawing.Point(1, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudCountShareFrom;
			int[] array3 = new int[4];
			array3[0] = 999999;
			numericUpDown3.Maximum = new decimal(array3);
			this.nudCountShareFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtWVmxWWkVkbFZuQldWMjVzYVUxcVFUaz0="))))))));
			this.nudCountShareFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountShareFrom.TabIndex = 1;
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(159, 3);
			this.label11.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1ZWUXdPUT09"))))))));
			this.label11.Size = new global::System.Drawing.Size(25, 16);
			this.label11.TabIndex = 35;
			this.label11.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1dzNVNFNXVRWGxPUkRBOQ=="))))))));
			this.label12.Location = new global::System.Drawing.Point(63, 3);
			this.label12.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1dub3dPUT09"))))))));
			this.label12.Size = new global::System.Drawing.Size(29, 16);
			this.label12.TabIndex = 37;
			this.label12.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label12.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudCountShareTo.Location = new global::System.Drawing.Point(98, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudCountShareTo;
			int[] array4 = new int[4];
			array4[0] = 999999;
			numericUpDown4.Maximum = new decimal(array4);
			this.nudCountShareTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtWVmxWWkVkbFZuQlhWVzVaUFE9PQ=="))))))));
			this.nudCountShareTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountShareTo.TabIndex = 2;
			this.plCountLike.Controls.Add(this.nudCountLikeFrom);
			this.plCountLike.Controls.Add(this.label9);
			this.plCountLike.Controls.Add(this.label10);
			this.plCountLike.Controls.Add(this.nudCountLikeTo);
			this.plCountLike.Location = new global::System.Drawing.Point(132, 130);
			this.plCountLike.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GSkhTWHBXYmxaclVsaG9kMWxVU2xaUVVUMDk="))))))));
			this.plCountLike.Size = new global::System.Drawing.Size(200, 25);
			this.plCountLike.TabIndex = 42;
			this.nudCountLikeFrom.Location = new global::System.Drawing.Point(1, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.nudCountLikeFrom;
			int[] array5 = new int[4];
			array5[0] = 999999;
			numericUpDown5.Maximum = new decimal(array5);
			this.nudCountLikeFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtUbGxXWkRCaVJrcDFVMjVhYVZWVU1Eaz0="))))))));
			this.nudCountLikeFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountLikeFrom.TabIndex = 1;
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(159, 3);
			this.label9.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxVOQ=="))))))));
			this.label9.Size = new global::System.Drawing.Size(25, 16);
			this.label9.TabIndex = 35;
			this.label9.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1dzNVNFNXVRWGxPUkRBOQ=="))))))));
			this.label10.Location = new global::System.Drawing.Point(63, 3);
			this.label10.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1VWUXdPUT09"))))))));
			this.label10.Size = new global::System.Drawing.Size(29, 16);
			this.label10.TabIndex = 37;
			this.label10.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label10.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudCountLikeTo.Location = new global::System.Drawing.Point(98, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.nudCountLikeTo;
			int[] array6 = new int[4];
			array6[0] = 999999;
			numericUpDown6.Maximum = new decimal(array6);
			this.nudCountLikeTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtUbGxXWkRCaVJscElUMFF3UFE9PQ=="))))))));
			this.nudCountLikeTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudCountLikeTo.TabIndex = 2;
			this.plComment.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.plComment.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plComment.Controls.Add(this.linkLabel1);
			this.plComment.Controls.Add(this.button2);
			this.plComment.Controls.Add(this.txtComment);
			this.plComment.Controls.Add(this.label8);
			this.plComment.Controls.Add(this.lblStatus);
			this.plComment.Location = new global::System.Drawing.Point(48, 249);
			this.plComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GSkhTWGxOV0ZKaFZucFZkdz09"))))))));
			this.plComment.Size = new global::System.Drawing.Size(278, 164);
			this.plComment.TabIndex = 8;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.linkLabel1.Location = new global::System.Drawing.Point(165, 4);
			this.linkLabel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a2MyUlhSWGRsUjJoYVlsWmFlbFJXUlRsUVVUMDk="))))))));
			this.linkLabel1.Size = new global::System.Drawing.Size(82, 16);
			this.linkLabel1.TabIndex = 48;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxjeFIyUldjRWhQV0ZKS1VqSjRjVmxxU1RCUVVUMDk="))))))));
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.button2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(247, 1);
			this.button2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1dub3dPUT09"))))))));
			this.button2.Size = new global::System.Drawing.Size(23, 23);
			this.button2.TabIndex = 46;
			this.button2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlVoak9WQlJQVDA9"))))))));
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.txtComment.Location = new global::System.Drawing.Point(6, 24);
			this.txtComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdSWGxQV0ZKcFZqRmFNVnBGUlRsUVVUMDk="))))))));
			this.txtComment.Size = new global::System.Drawing.Size(264, 114);
			this.txtComment.TabIndex = 45;
			this.txtComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(""))))))));
			this.txtComment.WordWrap = false;
			this.txtComment.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(4, 141);
			this.label8.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxFOQ=="))))))));
			this.label8.Size = new global::System.Drawing.Size(266, 16);
			this.label8.TabIndex = 0;
			this.label8.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VXpCVmVtRklWVEZhU0VKS1VucGtiMlJVVm5OalJXeElWV3BHYVdKWFRtNVVWazVEWVROak0xTnVWbUZsV0dSdVdYcE9RMk5IU25CUmJsVXdXVzVXWVZsV1RrTmhNbEpZVGxjMVNsTklVbTlhYTJSTFQwWnJlazFJUVQwPQ=="))))))));
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new global::System.Drawing.Point(3, 5);
			this.lblStatus.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhWWHBWYldoclUwWmFOZz09"))))))));
			this.lblStatus.Size = new global::System.Drawing.Size(140, 16);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtoV1NFNHlNVmhoTW1SaFUwWmFNVmR1YkVOaFdHTXlaVWhXYUZFd1NucGFSMVpJVG01S1dFNUhaRXhTUlVaM1ZESmpPVkJSUFQwPQ=="))))))));
			this.ckbComment.AutoSize = true;
			this.ckbComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbComment.Location = new global::System.Drawing.Point(30, 188);
			this.ckbComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldSWGxQV0ZKcFZqRmFNVnBGUlRsUVVUMDk="))))))));
			this.ckbComment.Size = new global::System.Drawing.Size(82, 20);
			this.ckbComment.TabIndex = 7;
			this.ckbComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUkhTbGhXYmxaclVWUXdPUT09"))))))));
			this.ckbComment.UseVisualStyleBackColor = true;
			this.ckbComment.CheckedChanged += new global::System.EventHandler(this.ckbComment_CheckedChanged);
			this.ckbShareWall.AutoSize = true;
			this.ckbShareWall.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbShareWall.Location = new global::System.Drawing.Point(30, 160);
			this.ckbShareWall.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFXVmRXWkRSamR6MDk="))))))));
			this.ckbShareWall.Size = new global::System.Drawing.Size(90, 20);
			this.ckbShareWall.TabIndex = 6;
			this.ckbShareWall.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSS2IyRkhUblJXVjJSWFRXdGFlbGxyUlRsUVVUMDk="))))))));
			this.ckbShareWall.UseVisualStyleBackColor = true;
			this.ckbShareWall.CheckedChanged += new global::System.EventHandler(this.ckbShareWall_CheckedChanged);
			this.ckbInteract.AutoSize = true;
			this.ckbInteract.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbInteract.Location = new global::System.Drawing.Point(30, 132);
			this.ckbInteract.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldUbGhPVkVKaFYwVndiMWRVVGxKUVVUMDk="))))))));
			this.ckbInteract.Size = new global::System.Drawing.Size(49, 20);
			this.ckbInteract.TabIndex = 5;
			this.ckbInteract.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWa2MyTnNjRkpRVkRBOQ=="))))))));
			this.ckbInteract.UseVisualStyleBackColor = true;
			this.ckbInteract.CheckedChanged += new global::System.EventHandler(this.ckbInteract_CheckedChanged_1);
			this.nudTimeWatchTo.Location = new global::System.Drawing.Point(229, 103);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.nudTimeWatchTo;
			int[] array7 = new int[4];
			array7[0] = 999999;
			numericUpDown7.Maximum = new decimal(array7);
			this.nudTimeWatchTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZtMVNiMXBGWkU5aU1WcElUMFF3UFE9PQ=="))))))));
			this.nudTimeWatchTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudTimeWatchTo.TabIndex = 4;
			this.nudSoLuongTo.Location = new global::System.Drawing.Point(229, 76);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.nudSoLuongTo;
			int[] array8 = new int[4];
			array8[0] = 999999;
			numericUpDown8.Maximum = new decimal(array8);
			this.nudSoLuongTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxOa1p6MDk="))))))));
			this.nudSoLuongTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongTo.TabIndex = 2;
			this.nudTimeWatchFrom.Location = new global::System.Drawing.Point(132, 103);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.nudTimeWatchFrom;
			int[] array9 = new int[4];
			array9[0] = 999999;
			numericUpDown9.Maximum = new decimal(array9);
			this.nudTimeWatchFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZtMVNiMXBGWkU5aU1VcDFVMjVhYVZWVU1Eaz0="))))))));
			this.nudTimeWatchFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudTimeWatchFrom.TabIndex = 3;
			this.nudSoLuongFrom.Location = new global::System.Drawing.Point(132, 76);
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.nudSoLuongFrom;
			int[] array10 = new int[4];
			array10[0] = 999999;
			numericUpDown10.Maximum = new decimal(array10);
			this.nudSoLuongFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUW1GbFYwbDVUVVF3UFE9PQ=="))))))));
			this.nudSoLuongFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudSoLuongFrom.TabIndex = 1;
			this.txtTenHanhDong.Location = new global::System.Drawing.Point(132, 49);
			this.txtTenHanhDong.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdXa2hXYmxaVVVqQmFNVmxWVmxOa2JVcDBXWG93UFE9PQ=="))))))));
			this.txtTenHanhDong.Size = new global::System.Drawing.Size(194, 23);
			this.txtTenHanhDong.TabIndex = 0;
			this.label7.Location = new global::System.Drawing.Point(194, 105);
			this.label7.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWswOQ=="))))))));
			this.label7.Size = new global::System.Drawing.Size(29, 16);
			this.label7.TabIndex = 38;
			this.label7.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Location = new global::System.Drawing.Point(194, 78);
			this.label3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTI4OQ=="))))))));
			this.label3.Size = new global::System.Drawing.Size(29, 16);
			this.label3.TabIndex = 37;
			this.label3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(290, 105);
			this.label6.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtrOQ=="))))))));
			this.label6.Size = new global::System.Drawing.Size(31, 16);
			this.label6.TabIndex = 36;
			this.label6.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(290, 78);
			this.label4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtFOQ=="))))))));
			this.label4.Size = new global::System.Drawing.Size(38, 16);
			this.label4.TabIndex = 35;
			this.label4.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tjeGMyRXhjRmhQUkRBOQ=="))))))));
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 105);
			this.label5.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtVOQ=="))))))));
			this.label5.Size = new global::System.Drawing.Size(94, 16);
			this.label5.TabIndex = 34;
			this.label5.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeEpZVWQ0YVZaSE9Eaz0="))))))));
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(27, 78);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(98, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxU2xOR2NIZFhhMlJYWkdzNWJsQlVNRDA9"))))))));
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(27, 52);
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
			this.btnCancel.Location = new global::System.Drawing.Point(189, 428);
			this.btnCancel.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxTYmxaYVRXeGFlZz09"))))))));
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSklUWGxPVnpROQ=="))))))));
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnAdd.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(82, 428);
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
			this.plFollow.Controls.Add(this.nudFollowFrom);
			this.plFollow.Controls.Add(this.label15);
			this.plFollow.Controls.Add(this.label16);
			this.plFollow.Controls.Add(this.nudFollowTo);
			this.plFollow.Location = new global::System.Drawing.Point(132, 212);
			this.plFollow.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GSXlTWGxsU0U1cFRUSk5PUT09"))))))));
			this.plFollow.Size = new global::System.Drawing.Size(200, 25);
			this.plFollow.TabIndex = 46;
			this.nudFollowFrom.Location = new global::System.Drawing.Point(1, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.nudFollowFrom;
			int[] array11 = new int[4];
			array11[0] = 999999;
			numericUpDown11.Maximum = new decimal(array11);
			this.nudFollowFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhTblJQV0U1cFVucHJlbFZ0TlV0a2JVcFNVRlF3UFE9PQ=="))))))));
			this.nudFollowFrom.Size = new global::System.Drawing.Size(56, 23);
			this.nudFollowFrom.TabIndex = 1;
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(159, 3);
			this.label15.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUFZWUXdPUT09"))))))));
			this.label15.Size = new global::System.Drawing.Size(36, 16);
			this.label15.TabIndex = 35;
			this.label15.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IySnNjRkpRVkRBOQ=="))))))));
			this.label16.Location = new global::System.Drawing.Point(63, 3);
			this.label16.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUFdub3dPUT09"))))))));
			this.label16.Size = new global::System.Drawing.Size(29, 16);
			this.label16.TabIndex = 37;
			this.label16.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label16.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudFollowTo.Location = new global::System.Drawing.Point(98, 1);
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.nudFollowTo;
			int[] array12 = new int[4];
			array12[0] = 999999;
			numericUpDown12.Maximum = new decimal(array12);
			this.nudFollowTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhTblJQV0U1cFVucHJlbFpyWXpSUVVUMDk="))))))));
			this.nudFollowTo.Size = new global::System.Drawing.Size(56, 23);
			this.nudFollowTo.TabIndex = 2;
			this.ckbFollow.AutoSize = true;
			this.ckbFollow.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbFollow.Location = new global::System.Drawing.Point(30, 214);
			this.ckbFollow.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldTblJQV0U1cFVucHJlZz09"))))))));
			this.ckbFollow.Size = new global::System.Drawing.Size(64, 20);
			this.ckbFollow.TabIndex = 45;
			this.ckbFollow.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vlcwd05XTXlTa2hQVkUwOQ=="))))))));
			this.ckbFollow.UseVisualStyleBackColor = true;
			this.ckbFollow.CheckedChanged += new global::System.EventHandler(this.ckbFollow_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(362, 470);
			base.Controls.Add(this.panel1);
			this.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMGIxSldaRWhXYmxKWFRXdFpkMWRVU201UVVUMDk="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1sSk9XVmhrTkdOVldqRlhibXhEVFVoak1sSnRiejA9"))))))));
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plCountComment.ResumeLayout(false);
			this.plCountComment.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountCommentTo).EndInit();
			this.plCountShareWall.ResumeLayout(false);
			this.plCountShareWall.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountShareFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountShareTo).EndInit();
			this.plCountLike.ResumeLayout(false);
			this.plCountLike.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudCountLikeTo).EndInit();
			this.plComment.ResumeLayout(false);
			this.plComment.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeWatchTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTimeWatchFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudSoLuongFrom).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.plFollow.ResumeLayout(false);
			this.plFollow.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudFollowFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudFollowTo).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001512 RID: 5394
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04001513 RID: 5395
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04001514 RID: 5396
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04001515 RID: 5397
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04001516 RID: 5398
		private global::System.Windows.Forms.NumericUpDown nudTimeWatchTo;

		// Token: 0x04001517 RID: 5399
		private global::System.Windows.Forms.NumericUpDown nudSoLuongTo;

		// Token: 0x04001518 RID: 5400
		private global::System.Windows.Forms.NumericUpDown nudTimeWatchFrom;

		// Token: 0x04001519 RID: 5401
		private global::System.Windows.Forms.NumericUpDown nudSoLuongFrom;

		// Token: 0x0400151A RID: 5402
		private global::System.Windows.Forms.TextBox txtTenHanhDong;

		// Token: 0x0400151B RID: 5403
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400151C RID: 5404
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400151D RID: 5405
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400151E RID: 5406
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400151F RID: 5407
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001520 RID: 5408
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001521 RID: 5409
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001522 RID: 5410
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04001523 RID: 5411
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04001524 RID: 5412
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001525 RID: 5413
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04001526 RID: 5414
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001527 RID: 5415
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04001528 RID: 5416
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04001529 RID: 5417
		private global::System.Windows.Forms.Panel plComment;

		// Token: 0x0400152A RID: 5418
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400152B RID: 5419
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x0400152C RID: 5420
		private global::System.Windows.Forms.CheckBox ckbComment;

		// Token: 0x0400152D RID: 5421
		private global::System.Windows.Forms.CheckBox ckbInteract;

		// Token: 0x0400152E RID: 5422
		private global::System.Windows.Forms.CheckBox ckbShareWall;

		// Token: 0x0400152F RID: 5423
		private global::System.Windows.Forms.Panel plCountComment;

		// Token: 0x04001530 RID: 5424
		private global::System.Windows.Forms.NumericUpDown nudCountCommentFrom;

		// Token: 0x04001531 RID: 5425
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04001532 RID: 5426
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04001533 RID: 5427
		private global::System.Windows.Forms.NumericUpDown nudCountCommentTo;

		// Token: 0x04001534 RID: 5428
		private global::System.Windows.Forms.Panel plCountShareWall;

		// Token: 0x04001535 RID: 5429
		private global::System.Windows.Forms.NumericUpDown nudCountShareFrom;

		// Token: 0x04001536 RID: 5430
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04001537 RID: 5431
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04001538 RID: 5432
		private global::System.Windows.Forms.NumericUpDown nudCountShareTo;

		// Token: 0x04001539 RID: 5433
		private global::System.Windows.Forms.Panel plCountLike;

		// Token: 0x0400153A RID: 5434
		private global::System.Windows.Forms.NumericUpDown nudCountLikeFrom;

		// Token: 0x0400153B RID: 5435
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400153C RID: 5436
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400153D RID: 5437
		private global::System.Windows.Forms.NumericUpDown nudCountLikeTo;

		// Token: 0x0400153E RID: 5438
		private global::System.Windows.Forms.RichTextBox txtComment;

		// Token: 0x0400153F RID: 5439
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04001540 RID: 5440
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04001541 RID: 5441
		private global::System.Windows.Forms.Panel plFollow;

		// Token: 0x04001542 RID: 5442
		private global::System.Windows.Forms.NumericUpDown nudFollowFrom;

		// Token: 0x04001543 RID: 5443
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04001544 RID: 5444
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04001545 RID: 5445
		private global::System.Windows.Forms.NumericUpDown nudFollowTo;

		// Token: 0x04001546 RID: 5446
		private global::System.Windows.Forms.CheckBox ckbFollow;
	}
}
