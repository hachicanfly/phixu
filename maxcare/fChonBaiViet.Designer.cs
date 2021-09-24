namespace maxcare
{
	// Token: 0x02000090 RID: 144
	public partial class fChonBaiViet : global::System.Windows.Forms.Form
	{
		// Token: 0x06000581 RID: 1409 RVA: 0x0009EA84 File Offset: 0x0009CC84
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0009EAE4 File Offset: 0x0009CCE4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fChonBaiViet));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.bunifuCards2 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.lblCountAcc = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.dgvBaiVietDaChon = new global::System.Windows.Forms.DataGridView();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
			this.label1 = new global::System.Windows.Forms.Label();
			this.cbbChuDe = new global::System.Windows.Forms.ComboBox();
			this.dgvDSBaiViet = new global::System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.thêmBàiViếtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sửaBàiViếtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaBàiViếtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chiTiếtBàiViếtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.làmMớiDanhSáchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.hiểnThịTấtCảBàiViếtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.cStt = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cChuDe = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cIdBaiViet = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cTieuDe = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cAnh = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cVideo = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cStt1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cId = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this.bunifuCards2.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBaiVietDaChon).BeginInit();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDSBaiViet).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.bunifuCards1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 5;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.bunifuCards1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RXdGFOVmRyYUU1bFFUMDk="))))))));
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(270, 47);
			this.bunifuCards1.TabIndex = 12;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.bunifuCards2);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJjOQ=="))))))));
			this.panel1.Size = new global::System.Drawing.Size(927, 517);
			this.panel1.TabIndex = 37;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.bunifuCards2.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards2.BorderRadius = 0;
			this.bunifuCards2.BottomSahddow = true;
			this.bunifuCards2.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards2.Controls.Add(this.pnlHeader);
			this.bunifuCards2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards2.LeftSahddow = false;
			this.bunifuCards2.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RXdGFOVmRyYUU1bFVUMDk="))))))));
			this.bunifuCards2.RightSahddow = true;
			this.bunifuCards2.ShadowDepth = 20;
			this.bunifuCards2.Size = new global::System.Drawing.Size(925, 37);
			this.bunifuCards2.TabIndex = 43;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCak1XTXhUa2hXYldoaFVqRmFOUT09"))))))));
			this.pnlHeader.Size = new global::System.Drawing.Size(925, 31);
			this.pnlHeader.TabIndex = 9;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 4);
			this.pictureBox1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaUVVUMDk="))))))));
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 76;
			this.pictureBox1.TabStop = false;
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.btnMinimize.Location = new global::System.Drawing.Point(896, 3);
			this.btnMinimize.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaUVVUMDk="))))))));
			this.btnMinimize.Size = new global::System.Drawing.Size(30, 30);
			this.btnMinimize.TabIndex = 9;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RURmFObHBGWXpWa1JsSklVbTFzWVZZelpEUT0="))))))));
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(925, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEJOV0ZaS1VqQjRSV05yWXpGaU1HeElaVVJGTUZsdVJqQlpiV001VUZFOVBRPT0="))))))));
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.groupBox2.BackColor = global::System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.lblCountAcc);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.dgvBaiVietDaChon);
			this.groupBox2.Location = new global::System.Drawing.Point(465, 40);
			this.groupBox2.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.groupBox2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwT1MyUnRVbGxSYTA1cFRUSmtOUT09"))))))));
			this.groupBox2.Padding = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.groupBox2.Size = new global::System.Drawing.Size(454, 423);
			this.groupBox2.TabIndex = 41;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZoT1VHTXlTblJhTW1ScFUwWm9iMlJZUlhoa1ZXeElWVWRvTVdOWFVqRlRWV2hSWVVoVk1rMUhaR0ZVTUdNelkwWmpNV0puUFQwPQ=="))))))));
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.Red;
			this.label3.Location = new global::System.Drawing.Point(6, 401);
			this.label3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTI4OQ=="))))))));
			this.label3.Size = new global::System.Drawing.Size(167, 16);
			this.label3.TabIndex = 80;
			this.label3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VXpCV1QyTXlSbGhVYmtwS1ZGWk9VMlI2Wkhka01HeEpXV3RTZGxKNmFHNVhhekZRWlZkS2RGa3laRFJUYTJodlpGUlNUbG95Vms1VU0zQmFWVEp6T1E9PQ=="))))))));
			this.lblCountAcc.AutoSize = true;
			this.lblCountAcc.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.lblCountAcc.ForeColor = global::System.Drawing.Color.Blue;
			this.lblCountAcc.Location = new global::System.Drawing.Point(349, 401);
			this.lblCountAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhSWGxQVkVacFlteEtRMWRVU2s1UVVUMDk="))))))));
			this.lblCountAcc.Size = new global::System.Drawing.Size(16, 16);
			this.lblCountAcc.TabIndex = 78;
			this.lblCountAcc.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label7.Location = new global::System.Drawing.Point(307, 401);
			this.label7.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWswOQ=="))))))));
			this.label7.Size = new global::System.Drawing.Size(44, 16);
			this.label7.TabIndex = 79;
			this.label7.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNHllRmhPVnpWUVdub3dPUT09"))))))));
			this.dgvBaiVietDaChon.AllowUserToAddRows = false;
			this.dgvBaiVietDaChon.AllowUserToDeleteRows = false;
			this.dgvBaiVietDaChon.AllowUserToResizeRows = false;
			this.dgvBaiVietDaChon.BackgroundColor = global::System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.Teal;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBaiVietDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvBaiVietDaChon.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBaiVietDaChon.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.cStt1,
				this.dataGridViewTextBoxColumn2,
				this.cId,
				this.dataGridViewTextBoxColumn4,
				this.dataGridViewTextBoxColumn5,
				this.Column1
			});
			this.dgvBaiVietDaChon.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvBaiVietDaChon.Location = new global::System.Drawing.Point(6, 52);
			this.dgvBaiVietDaChon.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvBaiVietDaChon.MultiSelect = false;
			this.dgvBaiVietDaChon.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0a2EwMXNSblJTYmtKWFlsZDRjMXBGVmxOaFJrVjVZVWhhYVZwNk1Eaz0="))))))));
			this.dgvBaiVietDaChon.RowHeadersVisible = false;
			this.dgvBaiVietDaChon.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBaiVietDaChon.Size = new global::System.Drawing.Size(444, 345);
			this.dgvBaiVietDaChon.TabIndex = 76;
			this.dgvBaiVietDaChon.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaiVietDaChon_CellDoubleClick);
			this.dgvBaiVietDaChon.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBaiVietDaChon_RowsAdded);
			this.dgvBaiVietDaChon.RowsRemoved += new global::System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvBaiVietDaChon_RowsRemoved);
			this.groupBox1.BackColor = global::System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.metroButton1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbbChuDe);
			this.groupBox1.Controls.Add(this.dgvDSBaiViet);
			this.groupBox1.Location = new global::System.Drawing.Point(3, 39);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.groupBox1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwT1MyUnRVbGxSYTA1cFRUSmtOQT09"))))))));
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(3, 5, 3, 5);
			this.groupBox1.Size = new global::System.Drawing.Size(456, 423);
			this.groupBox1.TabIndex = 42;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5BelRtdGFjVmxWVGtOaFdHTXlaVWhXYUZFd1NucGFSMVpJVG01S1dFNUVNRDA9"))))))));
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.Red;
			this.label2.Location = new global::System.Drawing.Point(7, 401);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(174, 16);
			this.label2.TabIndex = 80;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VXpCV1QyTXlSbGhVYmtwS1ZGWk9VMlI2Wkhka01HeEpXV3RTZGxKNmFHNVhhekZRWlZkS2RGa3laRFJUYTJodlpGUlNUbG94YTNsaGJXZ3hUa1JHTVZNeFJUbFFVVDA5"))))))));
			this.metroButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.metroButton1.Location = new global::System.Drawing.Point(282, 23);
			this.metroButton1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1YwMUhUblJQVlU1clYwWkpkMWxxU1RCbFFUMDk="))))))));
			this.metroButton1.Size = new global::System.Drawing.Size(109, 25);
			this.metroButton1.TabIndex = 79;
			this.metroButton1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmxab1dXRklWbmhVYmxaS1VqTndSV1JzVGtOaGJVWlFVbnBrZDJWVlVrWmhNbFpJVGpKa1VsQlVNRDA9"))))))));
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new global::System.EventHandler(this.metroButton1_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(8, 27);
			this.label1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJjOQ=="))))))));
			this.label1.Size = new global::System.Drawing.Size(53, 16);
			this.label1.TabIndex = 78;
			this.label1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEpaTW1RMFUydG9iMlJVVWtaT1p6MDk="))))))));
			this.cbbChuDe.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbChuDe.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbChuDe.FormattingEnabled = true;
			this.cbbChuDe.Location = new global::System.Drawing.Point(64, 23);
			this.cbbChuDe.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS1MyRldSWGxoUkVaVFVqRlZPUT09"))))))));
			this.cbbChuDe.Size = new global::System.Drawing.Size(212, 24);
			this.cbbChuDe.TabIndex = 77;
			this.cbbChuDe.SelectedIndexChanged += new global::System.EventHandler(this.cbbChuDe_SelectedIndexChanged);
			this.dgvDSBaiViet.AllowUserToAddRows = false;
			this.dgvDSBaiViet.AllowUserToDeleteRows = false;
			this.dgvDSBaiViet.AllowUserToResizeRows = false;
			this.dgvDSBaiViet.BackgroundColor = global::System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.Teal;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDSBaiViet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDSBaiViet.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSBaiViet.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.cStt,
				this.cChuDe,
				this.cIdBaiViet,
				this.cTieuDe,
				this.cAnh,
				this.cVideo
			});
			this.dgvDSBaiViet.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvDSBaiViet.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvDSBaiViet.Location = new global::System.Drawing.Point(10, 54);
			this.dgvDSBaiViet.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvDSBaiViet.MultiSelect = false;
			this.dgvDSBaiViet.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0a2EwMXNTa2RVYTA1YVZqSjRXRmxXWkZkTlFUMDk="))))))));
			this.dgvDSBaiViet.RowHeadersVisible = false;
			this.dgvDSBaiViet.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSBaiViet.Size = new global::System.Drawing.Size(440, 343);
			this.dgvDSBaiViet.TabIndex = 76;
			this.dgvDSBaiViet.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBaiViet_CellContentClick);
			this.dgvDSBaiViet.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKichBan_CellDoubleClick);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.thêmBàiViếtToolStripMenuItem,
				this.sửaBàiViếtToolStripMenuItem,
				this.xóaBàiViếtToolStripMenuItem,
				this.chiTiếtBàiViếtToolStripMenuItem,
				this.làmMớiDanhSáchToolStripMenuItem,
				this.hiểnThịTấtCảBàiViếtToolStripMenuItem
			});
			this.contextMenuStrip1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUlhVa2hXYWxKclVsUkdjMWx0TlZkV1IxSkpVMjVDYWxKRlZUaz0="))))))));
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(202, 158);
			this.contextMenuStrip1.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			this.thêmBàiViếtToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2NWSklSblJOVlU0elRtdEtkMVp0TVhWaFNGWjVUMVJDVjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlJEQTk="))))))));
			this.thêmBàiViếtToolStripMenuItem.Size = new global::System.Drawing.Size(201, 22);
			this.thêmBàiViếtToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSklSblJOUjJSYVl6QTVlbGx0TVc1YU1rcEpWMGRvTVdOVVJqRT0="))))))));
			this.thêmBàiViếtToolStripMenuItem.Click += new global::System.EventHandler(this.thêmBàiViếtToolStripMenuItem_Click);
			this.sửaBàiViếtToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1hsMFNFNHpTbGhTYTA0elRtdEtkMVp0TVhWaFNGWjVUMVJDVjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlJEQTk="))))))));
			this.sửaBàiViếtToolStripMenuItem.Size = new global::System.Drawing.Size(201, 22);
			this.sửaBàiViếtToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNHpTbGhTVjJSYVl6QTVlbGx0TVc1YU1rcEpWMGRvTVdOVVJqRT0="))))))));
			this.sửaBàiViếtToolStripMenuItem.Click += new global::System.EventHandler(this.sửaBàiViếtToolStripMenuItem_Click);
			this.xóaBàiViếtToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRlpVUlZKMlVqSjRXRmxYVmtoT2JsbDZWV3hXYVUxcWJIcFdWRTVUWlZkR1dWRnJOV0ZXZWxWNFZURm9VMkpIU2xKUVZEQTk="))))))));
			this.xóaBàiViếtToolStripMenuItem.Size = new global::System.Drawing.Size(201, 22);
			this.xóaBàiViếtToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHVnNiRlJSYld3elRtNW9NVmxWVGtOak1sSnNVbnBhZVZaNlVUaz0="))))))));
			this.xóaBàiViếtToolStripMenuItem.Click += new global::System.EventHandler(this.xóaBàiViếtToolStripMenuItem_Click);
			this.chiTiếtBàiViếtToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IyTkdXa2hpYldneFkycHJkMVZZVGxCYU1rWlhWMjVCTUZsdVJYWmFSVnBUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUE9PQ=="))))))));
			this.chiTiếtBàiViếtToolStripMenuItem.Size = new global::System.Drawing.Size(201, 22);
			this.chiTiếtBàiViếtToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IyTkZiRWxWYmtFd1dXNUZkbHBGVGtOaFdHTXlaVWhXYUZFd1NucGFSMVpJVG01S1dFNUVNRDA9"))))))));
			this.chiTiếtBàiViếtToolStripMenuItem.Click += new global::System.EventHandler(this.chiTiếtBàiViếtToolStripMenuItem_Click);
			this.làmMớiDanhSáchToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1dzeFVGb3lTbFpOTW1neFRsaFNkMVZyWkVka1YwWkhWVVZTZGxZd05YWldhMk0xWkcxS1IxUnFRbXBpVjNnelZrWmtWMlJYVWxaaVJFSmhWbnBCT1E9PQ=="))))))));
			this.làmMớiDanhSáchToolStripMenuItem.Size = new global::System.Drawing.Size(201, 22);
			this.làmMớiDanhSáchToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVeFVGb3lTbFJSYmxFd1dXNVdhVmxXVGtOaE1XeFlUbGM1U2xOR1FrVmlNV1JQWW5jOVBRPT0="))))))));
			this.làmMớiDanhSáchToolStripMenuItem.Click += new global::System.EventHandler(this.làmMớiDanhSáchToolStripMenuItem_Click);
			this.hiểnThịTấtCảBàiViếtToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZWa2RXRklWVEJVYmxaWFVqSndiMlJVVWpCV1ZGSnBZMWQ0YTFKV1FtOWtXRVpQVVROak1sRnVRbGRpVnpWdlpGaEpOVTFHV2toUFdGcHBVbXMwZDFreU1YTmtNVkpZVm01V2ExWlhkM2RYYkdOM1VGRTlQUT09"))))))));
			this.hiểnThịTấtCảBàiViếtToolStripMenuItem.Size = new global::System.Drawing.Size(201, 22);
			this.hiểnThịTấtCảBàiViếtToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlRCa2RXRklWVEJVYmxaS1UwWktkazVIU2pGVVJXeEpWa2RvTVdOV1dYZFRWV1JSWVVoV2VGUlhaRnBqTURsNldXMHhibG95U2tsWFIyZ3hZMVJHTVE9PQ=="))))))));
			this.hiểnThịTấtCảBàiViếtToolStripMenuItem.Click += new global::System.EventHandler(this.hiểnThịTấtCảBàiViếtToolStripMenuItem_Click);
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(468, 473);
			this.btnCancel.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancel.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxTYmxaYVRXeGFlZz09"))))))));
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSklUWGxPVnpROQ=="))))))));
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.btnSave.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnSave.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSave.ForeColor = global::System.Drawing.Color.White;
			this.btnSave.Location = new global::System.Drawing.Point(361, 473);
			this.btnSave.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSave.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWWGxTYWtwaFZWUXdPUT09"))))))));
			this.btnSave.Size = new global::System.Drawing.Size(92, 29);
			this.btnSave.TabIndex = 19;
			this.btnSave.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVeGFHUXlVbEpRVkRBOQ=="))))))));
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new global::System.EventHandler(this.BtnSave_Click);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 200;
			this.toolTip1.ReshowDelay = 40;
			this.cStt.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSR1UxWlJQVDA9"))))))));
			this.cStt.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1QwMUhVa0pRVkRBOQ=="))))))));
			this.cStt.Width = 35;
			this.cChuDe.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEpaTW1RMFUydG9iMlJVVWtaUVVUMDk="))))))));
			this.cChuDe.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1QySXlVbFpWYlhjOQ=="))))))));
			this.cIdBaiViet.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlRGV1Vsb3hSbnBVTW1Sb1ZUQkplVmxYVmtoT2JsbDZWVlF3UFE9PQ=="))))))));
			this.cIdBaiViet.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2MyRXhSblJTYmtKWFlsZDRjMXBGUlRsUVVUMDk="))))))));
			this.cIdBaiViet.Visible = false;
			this.cIdBaiViet.Width = 90;
			this.cTieuDe.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2RWSklSblZXVjJRMFUydG9iMlJVVWtaUVVUMDk="))))))));
			this.cTieuDe.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1UyTkdjRmxXYTFaaFZWUXdPUT09"))))))));
			this.cTieuDe.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cTieuDe.Width = 230;
			this.cAnh.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cAnh.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VGtkS2VHRlhTblJhZWpBOQ=="))))))));
			this.cAnh.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1IyUlhSa0pRVkRBOQ=="))))))));
			this.cVideo.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm0weGMyRXhjRmhQUkRBOQ=="))))))));
			this.cVideo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1lXTkdjRWhXYmxrOQ=="))))))));
			this.cVideo.Visible = false;
			this.cVideo.Width = 50;
			this.cStt1.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSR1UxWlJQVDA9"))))))));
			this.cStt1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1QwMUhVa1ZTVkRBOQ=="))))))));
			this.cStt1.Width = 35;
			this.dataGridViewTextBoxColumn2.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEpaTW1RMFUydG9iMlJVVWtaUVVUMDk="))))))));
			this.dataGridViewTextBoxColumn2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0a1IwMUdiRlphU0d4b1ZqRktXRmxXWkZkTk1WcElWbXBTYTFKVmNESmFWVlpQWkcxS1NWWnVVbWxoYTJzNQ=="))))))));
			this.cId.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlRGV1Vsb3hSbnBVTW1Sb1ZUQkplVmxYVmtoT2JsbDZWVlF3UFE9PQ=="))))))));
			this.cId.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))));
			this.cId.Visible = false;
			this.cId.Width = 90;
			this.dataGridViewTextBoxColumn4.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2RWSklSblZXVjJRMFUydG9iMlJVVWtaUVVUMDk="))))))));
			this.dataGridViewTextBoxColumn4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0a1IwMUdiRlphU0d4b1ZqRktXRmxXWkZkTk1WcElWbXBTYTFKVmNESmFWVlpQWkcxS1NWWnVVbWxoYkVVNQ=="))))))));
			this.dataGridViewTextBoxColumn4.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn4.Width = 230;
			this.dataGridViewTextBoxColumn5.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VGtkS2VHRlhTblJhZWpBOQ=="))))))));
			this.dataGridViewTextBoxColumn5.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0a1IwMUdiRlphU0d4b1ZqRktXRmxXWkZkTk1WcElWbXBTYTFKVmNESmFWVlpQWkcxS1NWWnVVbWxoYkZVNQ=="))))))));
			this.Column1.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm0weGMyRXhjRmhQUkRBOQ=="))))))));
			this.Column1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XTXlVbGhOV0ZaT1ZWUXdPUT09"))))))));
			this.Column1.Visible = false;
			this.Column1.Width = 50;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(927, 517);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.bunifuCards1);
			this.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMFQySXlTWGxPVlU1YVZqSjRXRmxXWkZkTlFUMDk="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1XdDVZVVJHYVdKWFRUaz0="))))))));
			base.Load += new global::System.EventHandler(this.FConfigGenneral_Load);
			this.panel1.ResumeLayout(false);
			this.bunifuCards2.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBaiVietDaChon).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvDSBaiViet).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000496 RID: 1174
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000497 RID: 1175
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000498 RID: 1176
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000499 RID: 1177
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400049A RID: 1178
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x0400049B RID: 1179
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400049C RID: 1180
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x0400049D RID: 1181
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400049E RID: 1182
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400049F RID: 1183
		public global::System.Windows.Forms.DataGridView dgvDSBaiViet;

		// Token: 0x040004A0 RID: 1184
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x040004A1 RID: 1185
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040004A2 RID: 1186
		private global::System.Windows.Forms.ComboBox cbbChuDe;

		// Token: 0x040004A3 RID: 1187
		private global::System.Windows.Forms.Label lblCountAcc;

		// Token: 0x040004A4 RID: 1188
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040004A5 RID: 1189
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x040004A6 RID: 1190
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x040004A7 RID: 1191
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040004A8 RID: 1192
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x040004A9 RID: 1193
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x040004AA RID: 1194
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040004AB RID: 1195
		public global::System.Windows.Forms.DataGridView dgvBaiVietDaChon;

		// Token: 0x040004AC RID: 1196
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040004AD RID: 1197
		private global::System.Windows.Forms.ToolStripMenuItem thêmBàiViếtToolStripMenuItem;

		// Token: 0x040004AE RID: 1198
		private global::System.Windows.Forms.ToolStripMenuItem sửaBàiViếtToolStripMenuItem;

		// Token: 0x040004AF RID: 1199
		private global::System.Windows.Forms.ToolStripMenuItem xóaBàiViếtToolStripMenuItem;

		// Token: 0x040004B0 RID: 1200
		private global::System.Windows.Forms.ToolStripMenuItem làmMớiDanhSáchToolStripMenuItem;

		// Token: 0x040004B1 RID: 1201
		private global::System.Windows.Forms.ToolStripMenuItem chiTiếtBàiViếtToolStripMenuItem;

		// Token: 0x040004B2 RID: 1202
		private global::System.Windows.Forms.ToolStripMenuItem hiểnThịTấtCảBàiViếtToolStripMenuItem;

		// Token: 0x040004B3 RID: 1203
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040004B4 RID: 1204
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt1;

		// Token: 0x040004B5 RID: 1205
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

		// Token: 0x040004B6 RID: 1206
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cId;

		// Token: 0x040004B7 RID: 1207
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

		// Token: 0x040004B8 RID: 1208
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

		// Token: 0x040004B9 RID: 1209
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

		// Token: 0x040004BA RID: 1210
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x040004BB RID: 1211
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cChuDe;

		// Token: 0x040004BC RID: 1212
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cIdBaiViet;

		// Token: 0x040004BD RID: 1213
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cTieuDe;

		// Token: 0x040004BE RID: 1214
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cAnh;

		// Token: 0x040004BF RID: 1215
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cVideo;
	}
}
