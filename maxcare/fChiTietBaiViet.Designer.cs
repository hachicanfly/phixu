﻿namespace maxcare
{
	// Token: 0x0200008F RID: 143
	public partial class fChiTietBaiViet : global::System.Windows.Forms.Form
	{
		// Token: 0x06000562 RID: 1378 RVA: 0x0009B294 File Offset: 0x00099494
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0009B2F4 File Offset: 0x000994F4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.lblNanh = new global::System.Windows.Forms.Label();
			this.bunifuCards2 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.dgvPic = new global::System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtChuDe = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.txtConten = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.txtName = new global::System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.thêmMớiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sửaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.bunifuCards2.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPic).BeginInit();
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(36, 47);
			this.bunifuCards1.TabIndex = 12;
			this.panel1.BackColor = global::System.Drawing.Color.White;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lblNanh);
			this.panel1.Controls.Add(this.bunifuCards2);
			this.panel1.Controls.Add(this.dgvPic);
			this.panel1.Controls.Add(this.txtChuDe);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtConten);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJjOQ=="))))))));
			this.panel1.Size = new global::System.Drawing.Size(365, 342);
			this.panel1.TabIndex = 37;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.lblNanh.AutoSize = true;
			this.lblNanh.Location = new global::System.Drawing.Point(6, 100);
			this.lblNanh.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhVblJTYmxab1VWUXdPUT09"))))))));
			this.lblNanh.Size = new global::System.Drawing.Size(56, 16);
			this.lblNanh.TabIndex = 50;
			this.lblNanh.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VGtkS2VHRlhTblJhTW1STVVrVkdkMVF5WXpsUVVUMDk="))))))));
			this.lblNanh.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
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
			this.bunifuCards2.Size = new global::System.Drawing.Size(363, 37);
			this.bunifuCards2.TabIndex = 43;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.button2);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 3);
			this.pnlHeader.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCak1XTXhUa2hXYldoaFVqRmFOUT09"))))))));
			this.pnlHeader.Size = new global::System.Drawing.Size(363, 31);
			this.pnlHeader.TabIndex = 9;
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Image = global::maxcare.Properties.Resources.btnMinimize_Image;
			this.button2.Location = new global::System.Drawing.Point(332, 1);
			this.button2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1dub3dPUT09"))))))));
			this.button2.Size = new global::System.Drawing.Size(30, 30);
			this.button2.TabIndex = 77;
			this.button2.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = global::maxcare.Properties.Resources.icon_64;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 2);
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
			this.btnMinimize.Location = new global::System.Drawing.Point(899, 1);
			this.btnMinimize.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaUVVUMDk="))))))));
			this.btnMinimize.Size = new global::System.Drawing.Size(30, 30);
			this.btnMinimize.TabIndex = 9;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RURmFObHBGWXpWa1JsSklVbTFzWVZZelpEUT0="))))))));
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(363, 31);
			this.bunifuCustomLabel1.TabIndex = 12;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IyTkZiRWxWYmtFd1dXNUZkbHBGVGtOaFdHTXlVVzVDU2xOR2NIZE9SMHA0VERKU1FsQlVNRDA9"))))))));
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.dgvPic.AllowUserToAddRows = false;
			this.dgvPic.AllowUserToDeleteRows = false;
			this.dgvPic.AllowUserToResizeColumns = false;
			this.dgvPic.AllowUserToResizeRows = false;
			this.dgvPic.BackgroundColor = global::System.Drawing.Color.White;
			this.dgvPic.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPic.ColumnHeadersVisible = false;
			this.dgvPic.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn4
			});
			this.dgvPic.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.dgvPic.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvPic.Location = new global::System.Drawing.Point(85, 97);
			this.dgvPic.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvPic.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0a2EwMXNWa2hpUjI4OQ=="))))))));
			this.dgvPic.RowHeadersVisible = false;
			this.dgvPic.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPic.Size = new global::System.Drawing.Size(270, 76);
			this.dgvPic.TabIndex = 42;
			this.dgvPic.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPic_CellContentClick);
			this.dgvPic.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPic_CellDoubleClick);
			this.dataGridViewTextBoxColumn4.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld0a1IwNVJQVDA9"))))))));
			this.dataGridViewTextBoxColumn4.FillWeight = 57.38708f;
			this.dataGridViewTextBoxColumn4.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSXpUbEJTZW1SMVZucFdkVk5WWkZWaFNGWjRaRWhWUFE9PQ=="))))))));
			this.dataGridViewTextBoxColumn4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0a1IwMUdiRlphU0d4b1ZqRktXRmxXWkZkTk1WcElWbXBTYTFKVmNESmFWVlpQWkcxS1NWWnVVbWxoYkVVNQ=="))))))));
			this.txtChuDe.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtChuDe.Location = new global::System.Drawing.Point(85, 41);
			this.txtChuDe.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtChuDe.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdSWGxoUkVaVFVqRlZPUT09"))))))));
			this.txtChuDe.ReadOnly = true;
			this.txtChuDe.Size = new global::System.Drawing.Size(270, 23);
			this.txtChuDe.TabIndex = 46;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label5.Location = new global::System.Drawing.Point(6, 72);
			this.label5.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtVOQ=="))))))));
			this.label5.Size = new global::System.Drawing.Size(56, 16);
			this.label5.TabIndex = 44;
			this.label5.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2RWSklSblZXVjJRMFUydG9iMlJVVWtaT1p6MDk="))))))));
			this.label5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.txtConten.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtConten.Location = new global::System.Drawing.Point(85, 181);
			this.txtConten.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtConten.Multiline = true;
			this.txtConten.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdSWGxQV0ZaclVqRmFNUT09"))))))));
			this.txtConten.ReadOnly = true;
			this.txtConten.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtConten.Size = new global::System.Drawing.Size(270, 149);
			this.txtConten.TabIndex = 48;
			this.txtConten.WordWrap = false;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label4.Location = new global::System.Drawing.Point(6, 44);
			this.label4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtFOQ=="))))))));
			this.label4.Size = new global::System.Drawing.Size(53, 16);
			this.label4.TabIndex = 43;
			this.label4.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEpaTW1RMFUydG9iMlJVVWtaT1p6MDk="))))))));
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label2.Location = new global::System.Drawing.Point(6, 184);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(63, 16);
			this.label2.TabIndex = 45;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtoV1NFNHlNVmhoTW1SaFUwWmFNVmR1Y0haUVVUMDk="))))))));
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.txtName.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtName.Location = new global::System.Drawing.Point(85, 69);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtName.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdVblJTYmxKaFZWUXdPUT09"))))))));
			this.txtName.ReadOnly = true;
			this.txtName.Size = new global::System.Drawing.Size(270, 23);
			this.txtName.TabIndex = 47;
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.thêmMớiToolStripMenuItem,
				this.sửaToolStripMenuItem,
				this.xóaToolStripMenuItem
			});
			this.contextMenuStrip1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUlhVa2hXYWxKclVsUkdjMWx0TlZkV1IxSkpVMjVDYWxKRlZUaz0="))))))));
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(153, 70);
			this.thêmMớiToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2NWSklSblJOVlRRd1dXNVdhVmxXV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvdw=="))))))));
			this.thêmMớiToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.thêmMớiToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSklSblJOUjJSYVRXMXdiMlJVV21wYU0yaExVMGRvTVU1RlZUaz0="))))))));
			this.sửaToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1hsMFNFNHpTbGhTYkZacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1VsQlVNRDA9"))))))));
			this.sửaToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.sửaToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNHpTbGhTVjJSclZGVTVlRmx0YkVOaGJVWlFVbnBrZDJWVlVrWmhNbFpJVGpKa1VsQlVNRDA9"))))))));
			this.xóaToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRmRWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVFOVBRPT0="))))))));
			this.xóaToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.xóaToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHVnNiRlJSYlhCb1ZEQmpNMk5JYkVWU1YzUnNVbnBrYmxWVU1Eaz0="))))))));
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 200;
			this.toolTip1.ReshowDelay = 40;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(365, 342);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.bunifuCards1);
			this.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMFQySXlSbGRWYmtKaFYwWktSRmRXWkhOV01rWllWbXBCUFE9PQ=="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1XdDVZVVJHYVdKWFRUaz0="))))))));
			base.Load += new global::System.EventHandler(this.FConfigGenneral_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.bunifuCards2.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPic).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400047C RID: 1148
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400047D RID: 1149
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400047E RID: 1150
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400047F RID: 1151
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000480 RID: 1152
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000481 RID: 1153
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards2;

		// Token: 0x04000482 RID: 1154
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000483 RID: 1155
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000484 RID: 1156
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000485 RID: 1157
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000486 RID: 1158
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000487 RID: 1159
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000488 RID: 1160
		private global::System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;

		// Token: 0x04000489 RID: 1161
		private global::System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;

		// Token: 0x0400048A RID: 1162
		private global::System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;

		// Token: 0x0400048B RID: 1163
		private global::System.Windows.Forms.Label lblNanh;

		// Token: 0x0400048C RID: 1164
		private global::System.Windows.Forms.DataGridView dgvPic;

		// Token: 0x0400048D RID: 1165
		private global::System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

		// Token: 0x0400048E RID: 1166
		private global::System.Windows.Forms.TextBox txtChuDe;

		// Token: 0x0400048F RID: 1167
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000490 RID: 1168
		private global::System.Windows.Forms.TextBox txtConten;

		// Token: 0x04000491 RID: 1169
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000492 RID: 1170
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000493 RID: 1171
		private global::System.Windows.Forms.TextBox txtName;
	}
}
