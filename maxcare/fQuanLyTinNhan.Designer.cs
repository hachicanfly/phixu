namespace maxcare
{
	// Token: 0x02000096 RID: 150
	public partial class fQuanLyTinNhan : global::System.Windows.Forms.Form
	{
		// Token: 0x060005EA RID: 1514 RVA: 0x000B13A8 File Offset: 0x000AF5A8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000B1408 File Offset: 0x000AF608
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.tabMain = new global::System.Windows.Forms.TabControl();
			this.dgvTaiKhoan = new global::System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.hiểnThịToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.đóngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sửaGhiChúToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cId = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cGhiChu = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cProxy = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCookies = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFa2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPassword = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUid = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTaiKhoan = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cAvatar = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.cStt = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvTaiKhoan).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.pnlHeader;
			this.bunifuDragControl1.Vertical = true;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.button2);
			this.pnlHeader.Controls.Add(this.button1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCak1XTXhUa2hXYldoaFVqRmFOUT09"))))))));
			this.pnlHeader.Size = new global::System.Drawing.Size(1080, 29);
			this.pnlHeader.TabIndex = 0;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.pictureBox1.Image = global::maxcare.Properties.Resources.icon_64;
			this.pictureBox1.Location = new global::System.Drawing.Point(6, 1);
			this.pictureBox1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaUVVUMDk="))))))));
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Image = global::maxcare.Properties.Resources.button2_Image;
			this.button2.Location = new global::System.Drawing.Point(984, 0);
			this.button2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1dub3dPUT09"))))))));
			this.button2.Size = new global::System.Drawing.Size(32, 29);
			this.button2.TabIndex = 0;
			this.button2.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.Button2_Click);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.button1.Enabled = false;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = global::maxcare.Properties.Resources.button1_Image;
			this.button1.Location = new global::System.Drawing.Point(1016, 0);
			this.button1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1ZWUXdPUT09"))))))));
			this.button1.Size = new global::System.Drawing.Size(32, 29);
			this.button1.TabIndex = 1;
			this.button1.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Image = global::maxcare.Properties.Resources.btnMinimize_Image;
			this.btnMinimize.Location = new global::System.Drawing.Point(1048, 0);
			this.btnMinimize.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaUVVUMDk="))))))));
			this.btnMinimize.Size = new global::System.Drawing.Size(32, 29);
			this.btnMinimize.TabIndex = 2;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new global::System.EventHandler(this.BtnMinimize_Click);
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(43, 6);
			this.bunifuCustomLabel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RURmFObHBGWXpWa1JsSklVbTFzWVZZelpEUT0="))))))));
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(178, 16);
			this.bunifuCustomLabel1.TabIndex = 3;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmxab1dXRklWbmhVYmxaS1VqTndSV1JzVGtOTlIwWllUa2RrYVdKWGNHOWtXRVUxWkZWc1NHRnJVblpTZWxaMVUxVmtOR1JxVW1salYyaHJVVlF3T1E9PQ=="))))))));
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl2.Vertical = true;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 30000;
			this.toolTip1.InitialDelay = 0;
			this.toolTip1.ReshowDelay = 40;
			this.bunifuCards1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.RoyalBlue;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, -1);
			this.bunifuCards1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RXdGFOVmRyYUU1bFFUMDk="))))))));
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(1081, 38);
			this.bunifuCards1.TabIndex = 0;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.dgvTaiKhoan);
			this.panel1.Controls.Add(this.bunifuCards1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJjOQ=="))))))));
			this.panel1.Size = new global::System.Drawing.Size(1082, 565);
			this.panel1.TabIndex = 8;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.tabMain);
			this.panel2.Location = new global::System.Drawing.Point(7, 39);
			this.panel2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJzOQ=="))))))));
			this.panel2.Size = new global::System.Drawing.Size(693, 519);
			this.panel2.TabIndex = 8;
			this.tabMain.Alignment = global::System.Windows.Forms.TabAlignment.Bottom;
			this.tabMain.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabMain.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.tabMain.Location = new global::System.Drawing.Point(0, 0);
			this.tabMain.Multiline = true;
			this.tabMain.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa1IyRldVbGhTYmtKcFdub3dPUT09"))))))));
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new global::System.Drawing.Size(693, 518);
			this.tabMain.TabIndex = 7;
			this.dgvTaiKhoan.AllowUserToAddRows = false;
			this.dgvTaiKhoan.AllowUserToDeleteRows = false;
			this.dgvTaiKhoan.AllowUserToResizeColumns = false;
			this.dgvTaiKhoan.AllowUserToResizeRows = false;
			this.dgvTaiKhoan.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.dgvTaiKhoan.BackgroundColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTaiKhoan.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.cStt,
				this.cAvatar,
				this.cTaiKhoan,
				this.cUid,
				this.cPassword,
				this.cFa2,
				this.cCookies,
				this.cProxy,
				this.cGhiChu,
				this.cId
			});
			this.dgvTaiKhoan.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvTaiKhoan.Cursor = global::System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTaiKhoan.Location = new global::System.Drawing.Point(706, 39);
			this.dgvTaiKhoan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0a2EwMXNXa2hTYmtKVVRXMW9NbGRXWXpCUVVUMDk="))))))));
			this.dgvTaiKhoan.ReadOnly = true;
			this.dgvTaiKhoan.RowHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvTaiKhoan.RowTemplate.Height = 50;
			this.dgvTaiKhoan.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTaiKhoan.Size = new global::System.Drawing.Size(369, 519);
			this.dgvTaiKhoan.TabIndex = 6;
			this.dgvTaiKhoan.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
			this.dgvTaiKhoan.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.hiểnThịToolStripMenuItem,
				this.đóngToolStripMenuItem,
				this.sửaGhiChúToolStripMenuItem
			});
			this.contextMenuStrip1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUlhVa2hXYWxKclVsUkdjMWx0TlZkV1IxSkpVMjVDYWxKRlZUaz0="))))))));
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(165, 70);
			this.hiểnThịToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_play_21px1;
			this.hiểnThịToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZWa2RXRklWVEJVYmxaWFVqSndiMlJVVWpCV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.hiểnThịToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.hiểnThịToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkV1NFNHlOVFZSYWtKcVl6QTVlbGx0TVc1YU1YQkpWbXBWTUZsdVZrbGFSVVU1VUZFOVBRPT0="))))))));
			this.hiểnThịToolStripMenuItem.Click += new global::System.EventHandler(this.hiểnThịToolStripMenuItem_Click);
			this.đóngToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_stop_21px;
			this.đóngToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklUWGxPVnpWWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUVNRDA9"))))))));
			this.đóngToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.đóngToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSklUWGxPVnpWS1UwWktOV1I2V2pSa1YwWkVVVzEwYTFkSE5XOWtWRkpyVFVFOVBRPT0="))))))));
			this.đóngToolStripMenuItem.Click += new global::System.EventHandler(this.đóngToolStripMenuItem_Click);
			this.sửaGhiChúToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_create_1;
			this.sửaGhiChúToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1hsMFNFNHpTbGhTYTJob1VqSjRSVmxWTVZCT2JGcElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.sửaGhiChúToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.sửaGhiChúToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNHpTbGhTVjJSaFRXMW9kMU5WWkU5aU0yTXpZbm93UFE9PQ=="))))))));
			this.sửaGhiChúToolStripMenuItem.Click += new global::System.EventHandler(this.sửaGhiChúToolStripMenuItem_Click);
			this.cId.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlRGa1VsQlJQVDA9"))))))));
			this.cId.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))));
			this.cId.ReadOnly = true;
			this.cId.Visible = false;
			this.cGhiChu.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldwS2IyTkZiRWhVYlRrelRqSTRPUT09"))))))));
			this.cGhiChu.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2EySXlSbFpVYlRsclZWUXdPUT09"))))))));
			this.cGhiChu.ReadOnly = true;
			this.cProxy.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWb1MyUnRWa2xoZWpBOQ=="))))))));
			this.cProxy.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ=="))))))));
			this.cProxy.ReadOnly = true;
			this.cProxy.Visible = false;
			this.cCookies.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNjOQ=="))))))));
			this.cCookies.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))));
			this.cCookies.ReadOnly = true;
			this.cCookies.Visible = false;
			this.cFa2.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZjeFlXRkJQVDA9"))))))));
			this.cFa2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ=="))))))));
			this.cFa2.ReadOnly = true;
			this.cFa2.Visible = false;
			this.cPassword.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWa1IyVnRUWHBhU0ZwcVlsWkZPUT09"))))))));
			this.cPassword.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))));
			this.cPassword.ReadOnly = true;
			this.cPassword.Visible = false;
			this.cUid.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14a2MyRjNQVDA9"))))))));
			this.cUid.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))));
			this.cUid.ReadOnly = true;
			this.cUid.Visible = false;
			this.cTaiKhoan.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.cTaiKhoan.DefaultCellStyle = dataGridViewCellStyle4;
			this.cTaiKhoan.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVGb3lSbFJSYmtwb1VuazViMlJZUms5a1VUMDk="))))))));
			this.cTaiKhoan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1UyRkhSbFprUnpscFRXdGFNUT09"))))))));
			this.cTaiKhoan.ReadOnly = true;
			this.cTaiKhoan.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.cTaiKhoan.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cAvatar.FillWeight = 50f;
			this.cAvatar.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZab1lXRkhVa2hTYm1zOQ=="))))))));
			this.cAvatar.ImageLayout = global::System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.cAvatar.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1IwMXNiRmxWYldocVdub3dPUT09"))))))));
			this.cAvatar.ReadOnly = true;
			this.cAvatar.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.cAvatar.Width = 70;
			this.cStt.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSR1UxWlJQVDA9"))))))));
			this.cStt.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1QwMUhVa0pRVkRBOQ=="))))))));
			this.cStt.ReadOnly = true;
			this.cStt.Resizable = global::System.Windows.Forms.DataGridViewTriState.False;
			this.cStt.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cStt.Width = 40;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1082, 565);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxNFIwMVdiRmhPVlRGc1ZteEtkMWx0Y3pGaU1XeFlUa1F3UFE9PQ=="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmxab1dXRklWbmhVYmxaS1VqTndSV1JzVGtOTlIwWllUa2RrYVdKWGNHOWtXRVUxWkZFOVBRPT0="))))))));
			base.Load += new global::System.EventHandler(this.fQuanLyTinNhan_Load);
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvTaiKhoan).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400053C RID: 1340
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400053D RID: 1341
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400053E RID: 1342
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400053F RID: 1343
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000540 RID: 1344
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000541 RID: 1345
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000542 RID: 1346
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000543 RID: 1347
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000544 RID: 1348
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000545 RID: 1349
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000546 RID: 1350
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000547 RID: 1351
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000548 RID: 1352
		private global::System.Windows.Forms.TabControl tabMain;

		// Token: 0x04000549 RID: 1353
		public global::System.Windows.Forms.DataGridView dgvTaiKhoan;

		// Token: 0x0400054A RID: 1354
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400054B RID: 1355
		private global::System.Windows.Forms.ToolStripMenuItem hiểnThịToolStripMenuItem;

		// Token: 0x0400054C RID: 1356
		private global::System.Windows.Forms.ToolStripMenuItem đóngToolStripMenuItem;

		// Token: 0x0400054D RID: 1357
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400054E RID: 1358
		private global::System.Windows.Forms.ToolStripMenuItem sửaGhiChúToolStripMenuItem;

		// Token: 0x0400054F RID: 1359
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x04000550 RID: 1360
		private global::System.Windows.Forms.DataGridViewImageColumn cAvatar;

		// Token: 0x04000551 RID: 1361
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cTaiKhoan;

		// Token: 0x04000552 RID: 1362
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cUid;

		// Token: 0x04000553 RID: 1363
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPassword;

		// Token: 0x04000554 RID: 1364
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFa2;

		// Token: 0x04000555 RID: 1365
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cCookies;

		// Token: 0x04000556 RID: 1366
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cProxy;

		// Token: 0x04000557 RID: 1367
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;

		// Token: 0x04000558 RID: 1368
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cId;
	}
}
