﻿namespace maxcare
{
	// Token: 0x020000ED RID: 237
	public partial class fImportUseragent : global::System.Windows.Forms.Form
	{
		// Token: 0x06000999 RID: 2457 RVA: 0x0019DCC0 File Offset: 0x0019BEC0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0019DD20 File Offset: 0x0019BF20
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fImportUseragent));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.label8 = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.txtUseragent = new global::System.Windows.Forms.RichTextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.nudTaiKhoanPerUa = new global::System.Windows.Forms.NumericUpDown();
			this.ckbKhongNhapTaiKhoanDaCo = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.rbNgauNhien = new global::System.Windows.Forms.RadioButton();
			this.rbLanLuot = new global::System.Windows.Forms.RadioButton();
			this.bunifuCards1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTaiKhoanPerUa).BeginInit();
			base.SuspendLayout();
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.SaddleBrown;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RXdGFOVmRyYUU1bFFUMDk="))))))));
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(477, 38);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCak1XTXhUa2hXYldoaFVqRmFOUT09"))))))));
			this.pnlHeader.Size = new global::System.Drawing.Size(477, 32);
			this.pnlHeader.TabIndex = 9;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.pictureBox1.Location = new global::System.Drawing.Point(4, 1);
			this.pictureBox1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaUVVUMDk="))))))));
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 77;
			this.pictureBox1.TabStop = false;
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.btnMinimize.Location = new global::System.Drawing.Point(445, 0);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(477, 32);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktWMWw2U2xkbFZteFlXa2Q0YVdKc1JUaz0="))))))));
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(245, 342);
			this.btnCancel.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxTYmxaYVRXeGFlZz09"))))))));
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1EyUnVjRXBTYmxaaFpIb3dPUT09"))))))));
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(136, 342);
			this.btnAdd.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSbGhWYlhNOQ=="))))))));
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpCa1NWUlhaRmhVVjJScFlsZHdSV0l6VGpWaGJVcHVVRlF3UFE9PQ=="))))))));
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl1.Vertical = true;
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(301, 252);
			this.label8.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxFOQ=="))))))));
			this.label8.Size = new global::System.Drawing.Size(142, 16);
			this.label8.TabIndex = 5;
			this.label8.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VXpCVmVtRklWVEZhU0VKS1UwWmFObGRzYUV0aFJtOTVWbTVXYTFFd1JqUlRWV1JWVWtoT2RFNVhOVXhWVkRBNQ=="))))))));
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatus.Location = new global::System.Drawing.Point(30, 47);
			this.lblStatus.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhWWHBWYldoclUwWmFOZz09"))))))));
			this.lblStatus.Size = new global::System.Drawing.Size(155, 16);
			this.lblStatus.TabIndex = 6;
			this.lblStatus.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1WcFpWRzE0YW1KVlduVlhiR014VFVWc1JGb3paRXhXUnpnNQ=="))))))));
			this.txtUseragent.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUseragent.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtUseragent.Location = new global::System.Drawing.Point(34, 66);
			this.txtUseragent.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdXbGxVYlhocVlsVmFkVmRzWXpGTlFUMDk="))))))));
			this.txtUseragent.Size = new global::System.Drawing.Size(409, 181);
			this.txtUseragent.TabIndex = 118;
			this.txtUseragent.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(""))))))));
			this.txtUseragent.WordWrap = false;
			this.txtUseragent.TextChanged += new global::System.EventHandler(this.txtComment_TextChanged);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(31, 252);
			this.label1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJjOQ=="))))))));
			this.label1.Size = new global::System.Drawing.Size(147, 16);
			this.label1.TabIndex = 119;
			this.label1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJSclVqQm9UbG93WkhKYU1rVjVZVWhhV2xremJFdFpiV3MxVm0xTmVWWnViRnBXTWxKeldXMDFVazVuUFQwPQ=="))))))));
			this.nudTaiKhoanPerUa.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.nudTaiKhoanPerUa.Location = new global::System.Drawing.Point(184, 250);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudTaiKhoanPerUa;
			int[] array = new int[4];
			array[0] = 999999;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudTaiKhoanPerUa;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.nudTaiKhoanPerUa.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2hTYmtKVVRXMW9NbGRXWXpGVlZuQlpVMnhhV2xWVU1Eaz0="))))))));
			this.nudTaiKhoanPerUa.Size = new global::System.Drawing.Size(69, 23);
			this.nudTaiKhoanPerUa.TabIndex = 120;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudTaiKhoanPerUa;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			this.ckbKhongNhapTaiKhoanDaCo.AutoSize = true;
			this.ckbKhongNhapTaiKhoanDaCo.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbKhongNhapTaiKhoanDaCo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ckbKhongNhapTaiKhoanDaCo.Location = new global::System.Drawing.Point(33, 303);
			this.ckbKhongNhapTaiKhoanDaCo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNVRmxWWkVka01WcElVbTVDVkUxdGFESlhWbU14VWxac1ZsUnVXVDA9"))))))));
			this.ckbKhongNhapTaiKhoanDaCo.Size = new global::System.Drawing.Size(311, 20);
			this.ckbKhongNhapTaiKhoanDaCo.TabIndex = 121;
			this.ckbKhongNhapTaiKhoanDaCo.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrYTJKVmFFNWFNR00wV2pKS2RHRnJaSHBVV0d4RldXMHhhbG95VWtoVFJURnVVakowYmxsVVNtOWtiR3hxWlZWd2FXRlZVa1poTVdSSlZGZGtOVkZ0Y0dsUFNHeERVMVZhVjJWc2NGbFRiV2hoVFd4YU1WcEZSVGxRVVQwOQ=="))))))));
			this.ckbKhongNhapTaiKhoanDaCo.UseVisualStyleBackColor = true;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(30, 279);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(159, 16);
			this.label2.TabIndex = 119;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10b1dWUlhaRWxoTW1SYVRXMW9NbVZyZEU5a1ZXeElUbGM1TTA1cmVFNWllazVDV2pGYVdWUnRlR3BpVlZwMVYyeGpNVTFGT1c1UVZEQTk="))))))));
			this.rbNgauNhien.AutoSize = true;
			this.rbNgauNhien.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbNgauNhien.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rbNgauNhien.Location = new global::System.Drawing.Point(274, 277);
			this.rbNgauNhien.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUXhiM2xTYWtaVllsZG9kMWRzWXpCUVVUMDk="))))))));
			this.rbNgauNhien.Size = new global::System.Drawing.Size(90, 20);
			this.rbNgauNhien.TabIndex = 122;
			this.rbNgauNhien.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGJWSkhPWHBsVlZKclZUQktNVmxWWkhWU1NFWjBUa1F3UFE9PQ=="))))))));
			this.rbNgauNhien.UseVisualStyleBackColor = true;
			this.rbLanLuot.AutoSize = true;
			this.rbLanLuot.Checked = true;
			this.rbLanLuot.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbLanLuot.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rbLanLuot.Location = new global::System.Drawing.Point(184, 277);
			this.rbLanLuot.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxUldiRmhPVlRGclZucHJkdz09"))))))));
			this.rbLanLuot.Size = new global::System.Drawing.Size(72, 20);
			this.rbLanLuot.TabIndex = 122;
			this.rbLanLuot.TabStop = true;
			this.rbLanLuot.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVeFVHRlljRXBSYmxaS1VqTndTR013TVdoaFNIQk1WR3BCUFE9PQ=="))))))));
			this.rbLanLuot.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(477, 388);
			base.Controls.Add(this.rbLanLuot);
			base.Controls.Add(this.rbNgauNhien);
			base.Controls.Add(this.ckbKhongNhapTaiKhoanDaCo);
			base.Controls.Add(this.nudTaiKhoanPerUa);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.txtUseragent);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.lblStatus);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.bunifuCards1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMGMyUkhUa2hQV0d4clVteGFObGRzYUV0aFJtOTVWbTVXYTFGVU1Eaz0="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMFIyRXhjRVpYYmtKcFVqRlZPUT09"))))))));
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTaiKhoanPerUa).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000DC9 RID: 3529
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000DCA RID: 3530
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000DCB RID: 3531
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000DCC RID: 3532
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000DCD RID: 3533
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000DCE RID: 3534
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000DCF RID: 3535
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000DD0 RID: 3536
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000DD1 RID: 3537
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000DD2 RID: 3538
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000DD3 RID: 3539
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000DD4 RID: 3540
		private global::System.Windows.Forms.RichTextBox txtUseragent;

		// Token: 0x04000DD5 RID: 3541
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000DD6 RID: 3542
		private global::System.Windows.Forms.NumericUpDown nudTaiKhoanPerUa;

		// Token: 0x04000DD7 RID: 3543
		private global::System.Windows.Forms.CheckBox ckbKhongNhapTaiKhoanDaCo;

		// Token: 0x04000DD8 RID: 3544
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000DD9 RID: 3545
		private global::System.Windows.Forms.RadioButton rbNgauNhien;

		// Token: 0x04000DDA RID: 3546
		private global::System.Windows.Forms.RadioButton rbLanLuot;
	}
}
