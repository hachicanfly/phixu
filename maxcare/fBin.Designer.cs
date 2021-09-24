namespace maxcare
{
	// Token: 0x02000071 RID: 113
	public partial class fBin : global::System.Windows.Forms.Form
	{
		// Token: 0x060004EA RID: 1258 RVA: 0x000851C0 File Offset: 0x000833C0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00085220 File Offset: 0x00083420
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fBin));
			this.dtgvAcc = new global::System.Windows.Forms.DataGridView();
			this.cChose = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.cStt = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cId = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUid = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cToken = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCookies = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cEmail = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPhone = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFollow = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFriend = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cGroup = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cBirthday = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cGender = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPassword = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cMailRecovery = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPassMail = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cBackup = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFa2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUseragent = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cProxy = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cDateCreateAcc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cAvatar = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cProfile = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cThuMuc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cInteractEnd = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cInfo = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cGhiChu = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cDateDelete = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctmsAcc = new global::MetroFramework.Controls.MetroContextMenu(this.components);
			this.chọnLiveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tấtCảToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.liveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tinhTrangToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trạngTháiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bỏChọnTấtCảToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.khôiPhucTaiKhoanToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaTàiKhoảnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởTrìnhDuyệtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tiếnHànhMởToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.càiĐặtCấuHìnhMởToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.passToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fAToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.maBaoMât6SôToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPass2FaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mailPassMailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassTokenCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassTokenCookieMailPassMailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassTokenCookieMailPassMail2faToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.useragentToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.proxyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.đinhDangKhacToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraWallToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkInfoUIDToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraTokenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkAvatarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProfileToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkBackupToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraTàiKhoảnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraMailpassMailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProxyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.profileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.donDepProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởThưMụcBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởFileHTMLToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởFolderBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.htmlToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.thưMụcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaDữLiệuBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tảiLạiDanhSáchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.thoátToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.grQuanLyThuMuc = new global::System.Windows.Forms.GroupBox();
			this.btnLoadAcc = new global::MetroFramework.Controls.MetroButton();
			this.cbbTinhTrang = new global::MetroFramework.Controls.MetroComboBox();
			this.cbbThuMuc = new global::MetroFramework.Controls.MetroComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.grTimKiem = new global::System.Windows.Forms.GroupBox();
			this.BtnSearch = new global::MetroFramework.Controls.MetroButton();
			this.cbbSearch = new global::System.Windows.Forms.ComboBox();
			this.txbSearch = new global::WindowsFormsControlLibrary1.BunifuCustomTextbox();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel5 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblCountSelect = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel7 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblCountTotal = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.button9 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.dtgvAcc).BeginInit();
			this.ctmsAcc.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.grQuanLyThuMuc.SuspendLayout();
			this.grTimKiem.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.dtgvAcc.AllowUserToAddRows = false;
			this.dtgvAcc.AllowUserToDeleteRows = false;
			this.dtgvAcc.AllowUserToResizeRows = false;
			this.dtgvAcc.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.dtgvAcc.BackgroundColor = global::System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.Teal;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dtgvAcc.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvAcc.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.cChose,
				this.cStt,
				this.cId,
				this.cUid,
				this.cToken,
				this.cCookies,
				this.cEmail,
				this.cPhone,
				this.cName,
				this.cFollow,
				this.cFriend,
				this.cGroup,
				this.cBirthday,
				this.cGender,
				this.cPassword,
				this.cMailRecovery,
				this.cPassMail,
				this.cBackup,
				this.cFa2,
				this.cUseragent,
				this.cProxy,
				this.cDateCreateAcc,
				this.cAvatar,
				this.cProfile,
				this.cThuMuc,
				this.cInteractEnd,
				this.cInfo,
				this.cGhiChu,
				this.cDateDelete,
				this.cStatus
			});
			this.dtgvAcc.ContextMenuStrip = this.ctmsAcc;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dtgvAcc.DefaultCellStyle = dataGridViewCellStyle2;
			this.dtgvAcc.Location = new global::System.Drawing.Point(2, 124);
			this.dtgvAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0b1UySnRVbkpTYlhCYVpIb3dPUT09"))))))));
			this.dtgvAcc.ReadOnly = true;
			this.dtgvAcc.RowHeadersVisible = false;
			this.dtgvAcc.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvAcc.Size = new global::System.Drawing.Size(1199, 461);
			this.dtgvAcc.TabIndex = 0;
			this.dtgvAcc.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvAcc_CellClick);
			this.dtgvAcc.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAcc_CellDoubleClick);
			this.dtgvAcc.SortCompare += new global::System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dtgvAcc_SortCompare);
			this.dtgvAcc.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.DtgvAcc_KeyDown);
			this.cChose.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEJOV0ZVOQ=="))))))));
			this.cChose.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))));
			this.cChose.ReadOnly = true;
			this.cChose.Width = 40;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.cStt.DefaultCellStyle = dataGridViewCellStyle3;
			this.cStt.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSR1UxWlJQVDA9"))))))));
			this.cStt.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1QwMUhVa0pRVkRBOQ=="))))))));
			this.cStt.ReadOnly = true;
			this.cStt.Width = 35;
			this.cId.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlRGa1VsQlJQVDA9"))))))));
			this.cId.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))));
			this.cId.ReadOnly = true;
			this.cId.Visible = false;
			this.cId.Width = 90;
			this.cUid.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14V2MxSlJQVDA9"))))))));
			this.cUid.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))));
			this.cUid.ReadOnly = true;
			this.cUid.Width = 80;
			this.cToken.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10ak5XTnNjRmhPUkRBOQ=="))))))));
			this.cToken.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ=="))))))));
			this.cToken.ReadOnly = true;
			this.cToken.Width = 70;
			this.cCookies.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNjOQ=="))))))));
			this.cCookies.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))));
			this.cCookies.ReadOnly = true;
			this.cCookies.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cCookies.Width = 70;
			this.cEmail.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld4amVHRkhSbGhrZWpBOQ=="))))))));
			this.cEmail.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ=="))))))));
			this.cEmail.ReadOnly = true;
			this.cEmail.Width = 60;
			this.cPhone.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWa2IyUnRTblJXVkRBOQ=="))))))));
			this.cPhone.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EySXlTWGxPVjNjOQ=="))))))));
			this.cPhone.ReadOnly = true;
			this.cPhone.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cPhone.Visible = false;
			this.cPhone.Width = 90;
			this.cName.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVHTlhTbTVRVkRBOQ=="))))))));
			this.cName.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))));
			this.cName.ReadOnly = true;
			this.cName.Width = 70;
			this.cFollow.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2IySkhTalZSYlhScFQwaHNSVmxXUlRsUVVUMDk="))))))));
			this.cFollow.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1lXUnRTa2hsU0ZwclpIb3dPUT09"))))))));
			this.cFollow.ReadOnly = true;
			this.cFollow.Width = 80;
			this.cFriend.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVlsWm9UbG93UlRsUVVUMDk="))))))));
			this.cFriend.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1lXVlhSbGhXYmxaaFVWUXdPUT09"))))))));
			this.cFriend.ReadOnly = true;
			this.cFriend.Width = 70;
			this.cGroup.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGIyUnVjRXBTYmxFOQ=="))))))));
			this.cGroup.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2EyVlhTWHBXYm1NOQ=="))))))));
			this.cGroup.ReadOnly = true;
			this.cGroup.Width = 60;
			this.cBirthday.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGEyRkljRXBSYWxaS1UwVTFkMWx0TVc1UVVUMDk="))))))));
			this.cBirthday.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1MyTkhUblZWYlRsaFVqQlpNUT09"))))))));
			this.cBirthday.ReadOnly = true;
			this.cBirthday.Width = 90;
			this.cGender.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldwS2RXRklWVEZrU0VKS1VteFNSV05zWXpGaWR6MDk="))))))));
			this.cGender.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2EySkhTblJWYlhocVdub3dPUT09"))))))));
			this.cGender.ReadOnly = true;
			this.cGender.Width = 80;
			this.cPassword.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkV1NFNXVTbGxWVjJSb1RXMXdiMlJZUm5OTlVUMDk="))))))));
			this.cPassword.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))));
			this.cPassword.ReadOnly = true;
			this.cPassword.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cPassword.Visible = false;
			this.cPassword.Width = 70;
			this.cMailRecovery.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld4amVHRkhSbGhrTW1Sb1RXMXdSV1JGWkhKYU1rNUlZVzFvTVU1c1duRT0="))))))));
			this.cMailRecovery.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQmVHRkhSbGhsUms1aFZqQTFNbHBITVZkbFYxWlNVRlF3UFE9PQ=="))))))));
			this.cMailRecovery.ReadOnly = true;
			this.cMailRecovery.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cMailRecovery.Visible = false;
			this.cMailRecovery.Width = 120;
			this.cPassMail.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkV1NFNXVTbGxWVjJSb1RXMXdiMlJZUm5OTlZXeElUVmRvYUZZell6az0="))))))));
			this.cPassMail.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyRkhUWHBVYXpWYVZqSjRlZz09"))))))));
			this.cPassMail.ReadOnly = true;
			this.cPassMail.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cPassMail.Visible = false;
			this.cPassMail.Width = 120;
			this.cBackup.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZjeFIyRnRSWHBXYm1NOQ=="))))))));
			this.cBackup.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1MyRkdhM2xrUkVacVVWUXdPUT09"))))))));
			this.cBackup.ReadOnly = true;
			this.cBackup.Width = 70;
			this.cFa2.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkT1VHRnJiRVZUYTJSU1ZWUXdPUT09"))))))));
			this.cFa2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ=="))))))));
			this.cFa2.ReadOnly = true;
			this.cFa2.Width = 65;
			this.cUseragent.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14b1QySkhUblJTYlRWaFZucFZkdz09"))))))));
			this.cUseragent.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk="))))))));
			this.cUseragent.ReadOnly = true;
			this.cUseragent.Width = 70;
			this.cProxy.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWb1MyUnRWa2xoZWpBOQ=="))))))));
			this.cProxy.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ=="))))))));
			this.cProxy.ReadOnly = true;
			this.cProxy.Width = 55;
			this.cDateCreateAcc.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGEyRkljRXBSYWxaS1UwWktiMlZyZEU5a1p6MDk="))))))));
			this.cDateCreateAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1UyRkhVa2hXYTFKcVlsWmFiMXBGWkZkUmJHdDVWRlF3UFE9PQ=="))))))));
			this.cDateCreateAcc.ReadOnly = true;
			this.cDateCreateAcc.Width = 85;
			this.cAvatar.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZab1lXRkhVa2hTYm1zOQ=="))))))));
			this.cAvatar.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1IwMXNiRmxWYldocVdub3dPUT09"))))))));
			this.cAvatar.ReadOnly = true;
			this.cAvatar.Width = 50;
			this.cProfile.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWb1MyUnNjSFJpU0U1aFZWUXdPUT09"))))))));
			this.cProfile.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyVlhTWGxYYmtKcFVqRlZPUT09"))))))));
			this.cProfile.ReadOnly = true;
			this.cProfile.Width = 50;
			this.cThuMuc.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXpUa1JSYmxFd1dXNVdjMWRZWXpsUVVUMDk="))))))));
			this.cThuMuc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1UySXlVbFpOVkVaYVpIb3dPUT09"))))))));
			this.cThuMuc.ReadOnly = true;
			this.cInteractEnd.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVeFVHRlljRXBSYmxaS1UwWlNTR013TVdoaFIwcDBXVEprYTFJd2FFNWFNV1JPV2pGcmVsZEZVakJVV0d4RFdWWkZPVkJSUFQwPQ=="))))))));
			this.cInteractEnd.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2MyUlhVa2hXYm14YVZqQTBkMVZzWXpGaGR6MDk="))))))));
			this.cInteractEnd.ReadOnly = true;
			this.cInfo.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.cInfo.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVHTXlTblJhTW1SWFUwVjRiMlJZUmtka1ZuQXpVRlF3UFE9PQ=="))))))));
			this.cInfo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ=="))))))));
			this.cInfo.ReadOnly = true;
			this.cInfo.Width = 90;
			this.cGhiChu.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldwS2IyTkZiRVpVYlRrelRqSTRPUT09"))))))));
			this.cGhiChu.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2EySXlSbFpVYlRsclZWUXdPUT09"))))))));
			this.cGhiChu.ReadOnly = true;
			this.cDateDelete.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeEpZVWhhTmxOVldtOD0="))))))));
			this.cDateDelete.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1UyRkhVa2hXYTFaaFZqTm9jMXBGWkZaUVVUMDk="))))))));
			this.cDateDelete.ReadOnly = true;
			this.cDateDelete.Width = 111;
			this.cStatus.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cStatus.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10b1RXRklWbmhTYmxaaFpWVktWbGxWTVZCaFIwWlNVRlF3UFE9PQ=="))))))));
			this.cStatus.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09"))))))));
			this.cStatus.ReadOnly = true;
			this.ctmsAcc.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chọnLiveToolStripMenuItem,
				this.bỏChọnTấtCảToolStripMenuItem,
				this.khôiPhucTaiKhoanToolStripMenuItem,
				this.xóaTàiKhoảnToolStripMenuItem,
				this.mởTrìnhDuyệtToolStripMenuItem,
				this.copyToolStripMenuItem,
				this.checkCookieToolStripMenuItem,
				this.profileToolStripMenuItem,
				this.backupToolStripMenuItem,
				this.tảiLạiDanhSáchToolStripMenuItem
			});
			this.ctmsAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFST1UyUkhUWGRTYlhCYVpIb3dPUT09"))))))));
			this.ctmsAcc.Size = new global::System.Drawing.Size(198, 224);
			this.ctmsAcc.Opening += new global::System.ComponentModel.CancelEventHandler(this.CtmsAcc_Opening);
			this.chọnLiveToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tấtCảToolStripMenuItem,
				this.liveToolStripMenuItem,
				this.tinhTrangToolStripMenuItem,
				this.trạngTháiToolStripMenuItem
			});
			this.chọnLiveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2NXRklWVEJOV0ZaVlVqSjNlVmRzV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvd1ZFZDBjMlJHYkZoYVIzYzk=")))))))));
			this.chọnLiveToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2NXRklWVEJOV0ZaVlVqSjNlVmRzV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvdw=="))))))));
			this.chọnLiveToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.chọnLiveToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEJOV0ZVOQ=="))))))));
			this.tấtCảToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXVRbGxWYTFFd1dXNUdjVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtJeFZURmplR0ZHYjNsV1ZEQTk=")))))))));
			this.tấtCảToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXVRbGxWYTFFd1dXNUdjVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.tấtCảToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.tấtCảToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNXVRbGxWVjJSYVN6QmpNbUl6WXpsUVVUMDk="))))))));
			this.tấtCảToolStripMenuItem.Click += new global::System.EventHandler(this.TấtCảToolStripMenuItem_Click);
			this.liveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a2MwMXNjRmRWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVWNGNtSklVbHBXTWxKeg==")))))))));
			this.liveToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a2MwMXNjRmRWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVFOVBRPT0="))))))));
			this.liveToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.liveToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZoT1VFMUhSbFJTUlZaeVZqRmFNUT09"))))))));
			this.liveToolStripMenuItem.Click += new global::System.EventHandler(this.LiveToolStripMenuItem_Click);
			this.tinhTrangToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2MyUlhSa2RWYm14YVZucFdkVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtJeFZURmplR0ZHYjNsV1ZEQTk=")))))))));
			this.tinhTrangToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2MyUlhSa2RWYm14YVZucFdkVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.tinhTrangToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.tinhTrangToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2RWUlhaRWhPVnpsS1UwWktOVmRYVGpWaGJVcDBXWG93UFE9PQ=="))))))));
			this.trạngTháiToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb1RXRklWbmhTYmxaaFRWWktkbVI2V2tkalJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMlJXVGxoTlYyaGhUV3hWT1E9PQ==")))))))));
			this.trạngTháiToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb1RXRklWbmhTYmxaaFRWWktkbVI2V2tkalJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.trạngTháiToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.trạngTháiToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10b1RXRklWbmhTYmxaaFpWVkpkMWxWTVZCaFIwWlNVRlF3UFE9PQ=="))))))));
			this.trạngTháiToolStripMenuItem.Click += new global::System.EventHandler(this.trạngTháiToolStripMenuItem_Click);
			this.bỏChọnTấtCảToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFoV1NFNHliM2RVYlRnd1dXNVdUMWx0ZUZWaFNGWjRWbXBDVWtzd1l6Smlla1pUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUZSSGRITmtSbXhZV2tkM1BRPT0=")))))))));
			this.bỏChọnTấtCảToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFoV1NFNHliM2RVYlRnd1dXNVdUMWx0ZUZWaFNGWjRWbXBDVWtzd1l6Smlla1pUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUE9PQ=="))))))));
			this.bỏChọnTấtCảToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.bỏChọnTấtCảToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZoV1NFNHljRFZSYlhCb1ZEQmpNMkZzWXpCYU1sSlFVbnBhZDFkR1JtNVhVM1JJVG0wNU0xQlVNRDA9"))))))));
			this.bỏChọnTấtCảToolStripMenuItem.Click += new global::System.EventHandler(this.BỏChọnTấtCảToolStripMenuItem_Click);
			this.khôiPhucTaiKhoanToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_sync;
			this.khôiPhucTaiKhoanToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2NWSklVa2hpUmtab1UwWmFjVlpyWkVkalJrMTVZVWhhV2xaNlZsWlpha2sxWXpGVmVsVnViR2hYUlVwUFYyeGpNVTFXVGxsVmJYaHBWVlF3T1E9PQ=="))))))));
			this.khôiPhucTaiKhoanToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.khôiPhucTaiKhoanToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hoTW1ScVVqSm5lR1ZyZEU5aGEyeEpWVzFvTmxOVlNuZFRWV1F3WWpKSmVWTkZNWEJXZWxFNQ=="))))))));
			this.khôiPhucTaiKhoanToolStripMenuItem.Click += new global::System.EventHandler(this.khôiPhucTaiKhoanToolStripMenuItem_Click);
			this.xóaTàiKhoảnToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_delete_bin;
			this.xóaTàiKhoảnToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRmRXUlZKMlVqSjRUVmxWWTNaaFNGWjRWRzVXVjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlJEQTk="))))))));
			this.xóaTàiKhoảnToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.xóaTàiKhoảnToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHVnNiRlJSYWtKYVdUTnNRbGxXVGtOamJVWklUMWRvTmxOWGVERlRWV2hoWTBod1NsUnVWbWhSTUVsNVdWZE9VR05ZY0VwVWJsVTk="))))))));
			this.xóaTàiKhoảnToolStripMenuItem.Click += new global::System.EventHandler(this.giưLaiProfileToolStripMenuItem_Click);
			this.mởTrìnhDuyệtToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tiếnHànhMởToolStripMenuItem,
				this.càiĐặtCấuHìnhMởToolStripMenuItem
			});
			this.mởTrìnhDuyệtToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNHlOSGhWYm13elRtNW9NVmxWVmxOTlYxWnNVbnBrYjAweFNsWlpha2sxWXpGVmVsVnViR2hYUlVwUFYyeGpNVTFXVGxsVmJYaHBWWHBXUzFsc1pFZGliSEJTVUZRd1BRPT0=")))))))));
			this.mởTrìnhDuyệtToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNHlOSGhWYm13elRtNW9NVmxWVmxOTlYxWnNVbnBrYjAweFNsWlpha2sxWXpGVmVsVnViR2hYUlVwUFYyeGpNVTFXVGxsVmJYaHBWVlF3T1E9PQ=="))))))));
			this.mởTrìnhDuyệtToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.mởTrìnhDuyệtToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkV1NFNHlOVFZSYWtKcVl6QTVlbGx0TVc1YU1YQkpWbXBWTUZsdVZrbGFSVVU1VUZFOVBRPT0="))))))));
			this.tiếnHànhMởToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2RXRklWbmxQV0ZaVVZGVTVibGx0TVc5VWFsSnBaRmRhVjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlJEQTk="))))))));
			this.tiếnHànhMởToolStripMenuItem.Size = new global::System.Drawing.Size(181, 22);
			this.tiếnHànhMởToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2RXRklWbmxQV0ZaS1VqSndSV0l3WXpGaU1HeElUVEpvTVU1VVp6az0="))))))));
			this.tiếnHànhMởToolStripMenuItem.Click += new global::System.EventHandler(this.tiếnHànhMởToolStripMenuItem_Click);
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSb1VGb3lSbXBWTVVVd1dXNUZlbHBGVmxGaFNGWjRWbXBHVkZSVk9YcFpiVEZ2VkdwU2FXUlhXbGRTZW13eVdXdGFUMDFIVG5SaVNHUlZWakZhTVZwR1ZuTk5SbkJZVFVRd1BRPT0="))))))));
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Size = new global::System.Drawing.Size(181, 22);
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSb1VGb3lSbFJTUlZaeVdsVmpNbVJFVGxKYU1XdHlVbnBhZDFkR1ZtNVpWVEZRWXpKS2RGb3laR2xhVldNelltNWpPVkJSUFQwPQ=="))))))));
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Click += new global::System.EventHandler(this.càiĐặtCấuHìnhMởToolStripMenuItem_Click);
			this.copyToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.uidToolStripMenuItem,
				this.passToolStripMenuItem,
				this.tokenToolStripMenuItem,
				this.cookieToolStripMenuItem,
				this.mailToolStripMenuItem,
				this.fAToolStripMenuItem,
				this.maBaoMât6SôToolStripMenuItem,
				this.uidPassToolStripMenuItem,
				this.uidPass2FaToolStripMenuItem,
				this.mailPassMailToolStripMenuItem,
				this.uidPassTokenCookieToolStripMenuItem,
				this.uidPassTokenCookieMailPassMailToolStripMenuItem,
				this.uidPassTokenCookieMailPassMail2faToolStripMenuItem,
				this.useragentToolStripMenuItem1,
				this.proxyToolStripMenuItem1,
				this.đinhDangKhacToolStripMenuItem
			});
			this.copyToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUXlWbGRWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVWNGNtSklVbHBXTWxKeg==")))))))));
			this.copyToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUXlWbGRWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVFOVBRPT0="))))))));
			this.copyToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.copyToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUXlWbEpRVkRBOQ=="))))))));
			this.uidToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhXa2hQV0ZwcFVtczBkMWt5TVhOa01WSllWbTVXYTFaWGQzZFhiR04zWkZaT1dFMVhhR0ZOYkZVNQ==")))))))));
			this.uidToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhXa2hQV0ZwcFVtczBkMWt5TVhOa01WSllWbTVXYTFaWGQzZFhiR04zVUZFOVBRPT0="))))))));
			this.uidToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14a2MyRjNQVDA9"))))))));
			this.uidToolStripMenuItem.Click += new global::System.EventHandler(this.UidToolStripMenuItem_Click);
			this.passToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyVnRUWGhWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVWNGNtSklVbHBXTWxKeg==")))))))));
			this.passToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyVnRUWGhWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVFOVBRPT0="))))))));
			this.passToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.passToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWa1IyVnRUak5RVkRBOQ=="))))))));
			this.passToolStripMenuItem.Click += new global::System.EventHandler(this.PassToolStripMenuItem_Click);
			this.tokenToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVmxacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1ZFNVZjR2xXTUZwMVYyeEZPVkJSUFQwPQ==")))))))));
			this.tokenToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVmxacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1VsQlVNRDA9"))))))));
			this.tokenToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.tokenToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10ak5XTnNjRmhPUkRBOQ=="))))))));
			this.tokenToolStripMenuItem.Click += new global::System.EventHandler(this.TokenToolStripMenuItem_Click);
			this.cookieToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUlWbFJXZWtadlYycEtWbEJSUFQwPQ==")))))))));
			this.cookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUVNRDA9"))))))));
			this.cookieToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.cookieToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNjOQ=="))))))));
			this.cookieToolStripMenuItem.Click += new global::System.EventHandler(this.CookieToolStripMenuItem_Click);
			this.mailToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1IyTkhTa2RWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVWNGNtSklVbHBXTWxKeg==")))))))));
			this.mailToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1IyTkhTa2RWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVFOVBRPT0="))))))));
			this.mailToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.mailToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld4amVHRkhSbGhrZWpBOQ=="))))))));
			this.mailToolStripMenuItem.Click += new global::System.EventHandler(this.MailToolStripMenuItem_Click_1);
			this.fAToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMFIxWlhTWGxQV0U1V1RURktOVmxXYUVOVWJIQllUbFJHVkZkR1NuTlpiRTB4VTIxS1dGSnROV0ZWVkRBNQ==")))))))));
			this.fAToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMFIxWlhTWGxQV0U1V1RURktOVmxXYUVOVWJIQllUbFJHVkZkR1NuTlpiRVU1VUZFOVBRPT0="))))))));
			this.fAToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.fAToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZkMFlWRm5QVDA9"))))))));
			this.fAToolStripMenuItem.Click += new global::System.EventHandler(this.fAToolStripMenuItem_Click);
			this.maBaoMât6SôToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1IxRXhiRmhQVlRVelRtdHZkMVJ0ZUZGU1NGSkhWVzVhYVUxdWFGVmFSV2hMWTBkT1JrMVhlR2xpYkZwTFdrVmtWMlJGZUhKaVNGSmFWakpTY3c9PQ==")))))))));
			this.maBaoMât6SôToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1IxRXhiRmhQVlRVelRtdHZkMVJ0ZUZGU1NGSkhWVzVhYVUxdWFGVmFSV2hMWTBkT1JrMVhlR2xpYkZwTFdrVmtWMlJCUFQwPQ=="))))))));
			this.maBaoMât6SôToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.maBaoMât6SôToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa1NWUlhaRFZSYld4YVdUTnNTMWx1YkVOa1NHTXlWRVV4ZGsweFJtNVViV3hEWlc1ak0xWkZNVzVWVkRBNQ=="))))))));
			this.maBaoMât6SôToolStripMenuItem.Click += new global::System.EventHandler(this.maBaoMât6SôToolStripMenuItem_Click);
			this.uidPassToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxxU2pSV1IxSkpVMjVDYWxKVVJuTlpiVFZYVTIxU1NGWnVVazFoTW5nd1YxWmthMkpCUFQwPQ==")))))))));
			this.uidPassToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxxU2pSV1IxSkpVMjVDYWxKVVJuTlpiVFZYVTIxU1NGWnVVVDA9"))))))));
			this.uidPassToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidPassToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14a2MyRXlXa2RSYldocVRUQXdPUT09"))))))));
			this.uidPassToolStripMenuItem.Click += new global::System.EventHandler(this.UidPassToolStripMenuItem_Click);
			this.uidPass2FaToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVpXdHdTRmRXV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvd1ZFZDBjMlJHYkZoYVIzYzk=")))))))));
			this.uidPass2FaToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVpXdHdTRmRXV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvdw=="))))))));
			this.uidPass2FaToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidPass2FaToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14a2MyRXlXa2RSYldocVRUQTBORlJYZEdGaFFUMDk="))))))));
			this.uidPass2FaToolStripMenuItem.Click += new global::System.EventHandler(this.uidPass2FaToolStripMenuItem_Click);
			this.mailPassMailToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1IyTkhTa2RSYldocVRUQTFUMWRXWkhOak1WcElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMlJXVGxoTlYyaGhUV3hWT1E9PQ==")))))))));
			this.mailPassMailToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1IyTkhTa2RSYldocVRUQTFUMWRXWkhOak1WcElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.mailPassMailToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.mailPassMailToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa1IyTkhTa2xsUmtaYVYwVTFObE5WWTNoaFIwWllaSG93UFE9PQ=="))))))));
			this.mailPassMailToolStripMenuItem.Click += new global::System.EventHandler(this.MailPassMailToolStripMenuItem_Click);
			this.uidPassTokenCookieToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxVU2xka1ZrVjVUMWhhYUUxdGVITldhMk0xWkcxS1IxUnFRbXBpVjNnelZrWmtWMlJYVWxaaVJFSmhWbnBDTVZVeFkzaGhSbTk1VmxRd1BRPT0=")))))))));
			this.uidPassTokenCookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxVU2xka1ZrVjVUMWhhYUUxdGVITldhMk0xWkcxS1IxUnFRbXBpVjNnelZrWmtWMlJYVWxaaVJFSmhWbnBCT1E9PQ=="))))))));
			this.uidPassTokenCookieToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidPassTokenCookieToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14a2MyRXlXa2RSYldocVRUQTBORlpyWXpWamJIQllUbFJvVWsxcWJESlpWRXB6WWtFOVBRPT0="))))))));
			this.uidPassTokenCookieToolStripMenuItem.Click += new global::System.EventHandler(this.UidPassTokenCookieToolStripMenuItem_Click);
			this.uidPassTokenCookieMailPassMailToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxVU2xka1ZrVjVUMWhhYUUxdGVITldSbVJIWTBkS1IxRnRhR3BOTURWUFYxWmtjMk14V2toUFdGcHBVbXMwZDFreU1YTmtNVkpZVm01V2ExWlhkM2RYYkdOM1pGWk9XRTFYYUdGTmJGVTU=")))))))));
			this.uidPassTokenCookieMailPassMailToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxVU2xka1ZrVjVUMWhhYUUxdGVITldSbVJIWTBkS1IxRnRhR3BOTURWUFYxWmtjMk14V2toUFdGcHBVbXMwZDFreU1YTmtNVkpZVm01V2ExWlhkM2RYYkdOM1VGRTlQUT09"))))))));
			this.uidPassTokenCookieMailPassMailToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidPassTokenCookieMailPassMailToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14a2MyRXlXa2RSYldocVRUQTBORlpyWXpWamJIQllUbFJvVWsxcWJESlpWRXB6WWtkYVJrMVhhR2hXTTJjMFZsVmtSMlZ0VGpWUmJsSmFWako0ZWc9PQ=="))))))));
			this.uidPassTokenCookieMailPassMailToolStripMenuItem.Click += new global::System.EventHandler(this.UidPassTokenCookieMailPassMailToolStripMenuItem_Click);
			this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxVU2xka1ZrVjVUMWhhYUUxdGVITldSbVJIWTBkS1IxRnRhR3BOTURWUFYxWmtjMk13TVhSWGJXaFhVbnBzTWxscldrOU5SMDUwWWtoa1ZWWXhXakZhUmxaelRVWndXRTFJVmxSV2VrWnZWMnBLVmxCUlBUMD0=")))))))));
			this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxVU2xka1ZrVjVUMWhhYUUxdGVITldSbVJIWTBkS1IxRnRhR3BOTURWUFYxWmtjMk13TVhSWGJXaFhVbnBzTWxscldrOU5SMDUwWWtoa1ZWWXhXakZhUmxaelRVWndXRTFFTUQwPQ=="))))))));
			this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14a2MyRXlXa2RSYldocVRUQTBORlpyWXpWamJIQllUbFJvVWsxcWJESlpWRXB6WWtkYVJrMVhhR2hXTTJjMFZsVmtSMlZ0VGpWUmJsSmFWako0ZWxwclVrdGlWbXhTVUZRd1BRPT0="))))))));
			this.uidPassTokenCookieMailPassMail2faToolStripMenuItem.Click += new global::System.EventHandler(this.UidPassTokenCookieMailPassMail2faToolStripMenuItem_Click);
			this.useragentToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tab1QySkhUblJTYlRWaFZucFZkMVpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtJMFZFZDBjMlJHYkZoYVIzYzk=")))))))));
			this.useragentToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tab1QySkhUblJTYlRWaFZucFZkMVpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtJMA=="))))))));
			this.useragentToolStripMenuItem1.Size = new global::System.Drawing.Size(289, 22);
			this.useragentToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14b1QySkhUblJTYlRWaFZucFZkdz09"))))))));
			this.useragentToolStripMenuItem1.Click += new global::System.EventHandler(this.useragentToolStripMenuItem1_Click);
			this.proxyToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCb1MyUnRWa2xpUmxacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1ZWSllWbFJXZWtadlYycEtWbEJSUFQwPQ==")))))))));
			this.proxyToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCb1MyUnRWa2xpUmxacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1ZWSlVNRDA9"))))))));
			this.proxyToolStripMenuItem1.Size = new global::System.Drawing.Size(289, 22);
			this.proxyToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWb1MyUnRWa2xoZWpBOQ=="))))))));
			this.proxyToolStripMenuItem1.Click += new global::System.EventHandler(this.proxyToolStripMenuItem1_Click);
			this.đinhDangKhacToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1IyTkhTblJoUlZaYVZucFdkVlY2U205aFJtdDRWVzVhYVUxdWFGVmFSV2hMWTBkT1JrMVhlR2xpYkZwTFdrVmtWMlJGZUhKaVNGSmFWakpTY3c9PQ==")))))))));
			this.đinhDangKhacToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1IyTkhTblJoUlZaYVZucFdkVlY2U205aFJtdDRWVzVhYVUxdWFGVmFSV2hMWTBkT1JrMVhlR2xpYkZwTFdrVmtWMlJCUFQwPQ=="))))))));
			this.đinhDangKhacToolStripMenuItem.Size = new global::System.Drawing.Size(289, 22);
			this.đinhDangKhacToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1EyTkljRXhVYmxab1VUQktjbGRYVGpWaGJVcDBXVEprYUUxdGFHOWxhMnhIWVd0NGNFNUlWVDA9"))))))));
			this.đinhDangKhacToolStripMenuItem.Click += new global::System.EventHandler(this.đinhDangKhacToolStripMenuItem_Click);
			this.checkCookieToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.kiểmTraWallToolStripMenuItem,
				this.checkInfoUIDToolStripMenuItem,
				this.kiểmTraTokenToolStripMenuItem,
				this.kiểmTraCookieToolStripMenuItem,
				this.checkAvatarToolStripMenuItem,
				this.checkProfileToolStripMenuItem1,
				this.checkBackupToolStripMenuItem1,
				this.kiểmTraTàiKhoảnToolStripMenuItem,
				this.kiểmTraMailpassMailToolStripMenuItem,
				this.checkProxyToolStripMenuItem
			});
			this.checkCookieToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlZKcFRXcHNlVmxXWkZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeE5NVk50U2xoU2JUVmhWVlF3T1E9PQ==")))))))));
			this.checkCookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlZKcFRXcHNlVmxXWkZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.checkCookieToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.checkCookieToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2RXRklWVEJVYmxKS1UwWktOVmRXVGtOTlNHTXlVVzVDU2xJelVuWlphWFJJVG0wNGVVNUVNRDA9"))))))));
			this.kiểmTraWallToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVpxU2tkak1rcEhWVzVhYVUxdWFGVmFSV2hMWTBkT1JrMVhlR2xpYkZwTFdrVmtWMlJCUFQwPQ=="))))))));
			this.kiểmTraWallToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.kiểmTraWallToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SWFRXdGFlbGxyUlRsUVVUMDk="))))))));
			this.kiểmTraWallToolStripMenuItem.ToolTipText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNiMlJZUm10a1ZXeElWa1ZTTVZaNlZuVlRWV2hUWkcxRmVWWnVWVDA9"))))))));
			this.kiểmTraWallToolStripMenuItem.Click += new global::System.EventHandler(this.KiểmTraWallToolStripMenuItem_Click);
			this.checkInfoUIDToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlhCcFlsWndNbFpzVm5OU1ZscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.checkInfoUIDToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.checkInfoUIDToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZucFdkRmx1YkVOV2JFNVdWVlF3UFE9PQ=="))))))));
			this.checkInfoUIDToolStripMenuItem.ToolTipText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNiMlJZUm10a1ZXeElWa1ZTTVZaNlZuVlRWV2hUWkcxRmVWWnVWa1ZWV0VKRlpIcGFUVlJYT0hwUlYyUnBZbGR3UldJelRqVmhiVkpFVVdwQ2FGUlZPSGRaYlRGcVdqSlNTR0pJVmxCaFZVcEtXV3BvTldGcmJFbFdSVko0WWxSU2VsTlZWbXRqUkZKcFpGZEtObE5WV25kVFZXaFRZMGh3U2xKdVZtaFJNMlJ1Vm5wQ1YyUkdiRmhpU0U1WlZUTmtibFo2UWt0aFNIQk1WRzVXU2xJd2NITmxhMnhEV2tWNFJGRnRTbFZpVjJneVpXdHNSMlJHYUZSa01tUllUVVJXZFZkWFRqVlJWMVpVVVc1d2FGWjZWblpYUmtVNVVGRTlQUT09"))))))));
			this.checkInfoUIDToolStripMenuItem.Click += new global::System.EventHandler(this.checkInfoUIDToolStripMenuItem_Click);
			this.kiểmTraTokenToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVpyWXpWamJIQllUbFpXYVUxcWJIcFdWRTVUWlZkR1dWRnJOV0ZXZWxWNFZURm9VMkpIU2xKUVZEQTk="))))))));
			this.kiểmTraTokenToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.kiểmTraTokenToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SWFVucHNlVmRzWXpCUVVUMDk="))))))));
			this.kiểmTraTokenToolStripMenuItem.Click += new global::System.EventHandler(this.KiểmTraTokenToolStripMenuItem_Click);
			this.kiểmTraCookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVZVU1RWa2JVVjVZa2Q0VjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlJEQTk="))))))));
			this.kiểmTraCookieToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.kiểmTraCookieToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SU1RXcHNNbGxVU25OaVFUMDk="))))))));
			this.kiểmTraCookieToolStripMenuItem.Click += new global::System.EventHandler(this.KiểmTraCookieToolStripMenuItem_Click);
			this.checkAvatarToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlVwcllsVlpkMWRXYUV0V1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.checkAvatarToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.checkAvatarToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SU1YwWndiMXBGWkVkbFVUMDk="))))))));
			this.checkAvatarToolStripMenuItem.Click += new global::System.EventHandler(this.checkAvatarToolStripMenuItem_Click);
			this.checkProfileToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUmtacVlsUnNkRmxXWkRSaVJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMlZCUFQwPQ=="))))))));
			this.checkProfileToolStripMenuItem1.Size = new global::System.Drawing.Size(164, 22);
			this.checkProfileToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SV1UwVndNbGR0TVhOak1YQlNVRlF3UFE9PQ=="))))))));
			this.checkProfileToolStripMenuItem1.Click += new global::System.EventHandler(this.checkProfileToolStripMenuItem_Click);
			this.checkBackupToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlU1YVZqQTFlVnBHYUVOV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeFNSbEJSUFQwPQ=="))))))));
			this.checkBackupToolStripMenuItem1.Size = new global::System.Drawing.Size(164, 22);
			this.checkBackupToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SU1lsVmFjVmxVVGxka2R6MDk="))))))));
			this.checkBackupToolStripMenuItem1.Click += new global::System.EventHandler(this.checkBackupToolStripMenuItem_Click);
			this.kiểmTraTàiKhoảnToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVpyTVZCYU1rWldaRWM1YVVzd1l6Smlla2t4VmxkSmVVOVlUbFpOTVVvMVdWWm9RMVJzY0ZoT1ZFWlVWMFpLYzFsc1JUbFFVVDA5"))))))));
			this.kiểmTraTàiKhoảnToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.kiểmTraTàiKhoảnToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldzNVNFNXRPVmhPVnpWS1VqQTFkbGRzWkU5amJVNUlUMWhDYVdKc1JUaz0="))))))));
			this.kiểmTraTàiKhoảnToolStripMenuItem.ToolTipText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IyTkljRXBoTW1ScVQwZEdNMlZyYkhKYU1YQkpWMFV4ZGsxcVZuVlRWV1F3WWpKR1ZGRnFRbHBaTTJ4Q1dWWk9RMk50UmtoUFYyZzJVMWQ0TVZOVk1WUlZiR3hxWlZWU1NsSXdjSGRsYTNST1dqRnJlV0ZIZUZwTmJsSXpXV3BLYzJSWFVrUlNWREE5"))))))));
			this.kiểmTraTàiKhoảnToolStripMenuItem.Click += new global::System.EventHandler(this.KiểmTraTàiKhoảnToolStripMenuItem_Click);
			this.kiểmTraMailpassMailToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVpHWkVkalIwcEpVVzFvYWswd05VOVhWbVJ6WXpGYVNFOVlXbWxTYXpSM1dUSXhjMlF4VWxoV2JsWnJWbGQzZDFkc1kzZFFVVDA5"))))))));
			this.kiểmTraMailpassMailToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.kiểmTraMailpassMailToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa1IyTkhTa2xsU0dSYVYwVTFObE5WVlhoaFIwWllaSG93UFE9PQ=="))))))));
			this.kiểmTraMailpassMailToolStripMenuItem.Click += new global::System.EventHandler(this.kiểmTraMailpassMailToolStripMenuItem_Click);
			this.checkProxyToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUmtacVlsUnJNRnBXV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvdw=="))))))));
			this.checkProxyToolStripMenuItem.Size = new global::System.Drawing.Size(164, 22);
			this.checkProxyToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SV1UwVndNbHBWYUhKUVVUMDk="))))))));
			this.checkProxyToolStripMenuItem.Click += new global::System.EventHandler(this.checkProxyToolStripMenuItem_Click);
			this.profileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.xóaProfileToolStripMenuItem,
				this.donDepProfileToolStripMenuItem
			});
			this.profileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCb1MyUnNjSFJpU0U1aFZteEtNbGxxU2pSV1IxSkpVMjVDYWxKVVJuTlpiVFZYVTIxU1NGWnVVazFoTW5nd1YxWmthMkpCUFQwPQ==")))))))));
			this.profileToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCb1MyUnNjSFJpU0U1aFZteEtNbGxxU2pSV1IxSkpVMjVDYWxKVVJuTlpiVFZYVTIxU1NGWnVVVDA9"))))))));
			this.profileToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.profileToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWb1MyUnNjSFJpU0U1aFZUQktSVmxWYUV0a2JVcFlWbFF3UFE9PQ=="))))))));
			this.xóaProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRmRSYm14cFRXeHdkMWxyWkZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeE5NVk50U2xoU2JUVmhWVlF3T1E9PQ==")))))))));
			this.xóaProfileToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRmRSYm14cFRXeHdkMWxyWkZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.xóaProfileToolStripMenuItem.Size = new global::System.Drawing.Size(156, 22);
			this.xóaProfileToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHVnNiRlJSYm1ScVlsUnNkRmxXWkRSaVFUMDk="))))))));
			this.xóaProfileToolStripMenuItem.Click += new global::System.EventHandler(this.xóaProfileToolStripMenuItem_Click);
			this.donDepProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0ak5XUldTa2hXYm1SV1UwVndNbGR0TVhOak1YQlhWVzVhYVUxdWFGVmFSV2hMWTBkT1JrMVhlR2xpYkZwTFdrVmtWMlJGZUhKaVNGSmFWakpTY3c9PQ==")))))))));
			this.donDepProfileToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0ak5XUldTa2hXYm1SV1UwVndNbGR0TVhOak1YQlhWVzVhYVUxdWFGVmFSV2hMWTBkT1JrMVhlR2xpYkZwTFdrVmtWMlJCUFQwPQ=="))))))));
			this.donDepProfileToolStripMenuItem.Size = new global::System.Drawing.Size(156, 22);
			this.donDepProfileToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld0amRsUlhPSGxPUjJSaFVqRm9UbUo2VGtKYU1rNUpVMjVhWVdKWGVIcFhiRVU1VUZFOVBRPT0="))))))));
			this.donDepProfileToolStripMenuItem.Click += new global::System.EventHandler(this.donDepProfileToolStripMenuItem_Click);
			this.backupToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.checkBackupToolStripMenuItem,
				this.mởThưMụcBackupToolStripMenuItem,
				this.backupToolStripMenuItem1,
				this.xóaDữLiệuBackupToolStripMenuItem
			});
			this.backupToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUlWbFJXZWtadlYycEtWbEJSUFQwPQ==")))))))));
			this.backupToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUVNRDA9"))))))));
			this.backupToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.backupToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZjeFIyRnRSWHBXYm1SS1VqRlNTR013TVRWU1JXeElaVWhDTTA1dVNrNWllazVXVUZFOVBRPT0="))))))));
			this.checkBackupToolStripMenuItem.Image = global::maxcare.Properties.Resources.find_and_replace_25px;
			this.checkBackupToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlU1YVZqQTFlVnBHYUVOV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.checkBackupToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.checkBackupToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SU1lsVmFjVmxVVGxka2R6MDk="))))))));
			this.checkBackupToolStripMenuItem.Click += new global::System.EventHandler(this.checkBackupToolStripMenuItem_Click);
			this.mởThưMụcBackupToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mởFileHTMLToolStripMenuItem,
				this.mởFolderBackupToolStripMenuItem
			});
			this.mởThưMụcBackupToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNHlOSGhWYlRrMFkydEtUMDVIU2pGaVJtdDNVMjFvV2sxdVVYaFpNRnBUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUZSSGRITmtSbXhZV2tkM1BRPT0=")))))))));
			this.mởThưMụcBackupToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNHlOSGhWYlRrMFkydEtUMDVIU2pGaVJtdDNVMjFvV2sxdVVYaFpNRnBUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUE9PQ=="))))))));
			this.mởThưMụcBackupToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.mởThưMụcBackupToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkV1NFNHlOVFZSYlhNd1dXNVdNbE5WWkRSalNHTXlZMFJHU2xKVmNHOVhWRW93VFZkT1FsQlVNRDA9"))))))));
			this.mởFileHTMLToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNHlOSGRYYmtKcFVqRmFTbFpyVlhoVVZscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.mởFileHTMLToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.mởFileHTMLToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlcweGMyTXhjRlJSYTJ4WFVsUkdUZz09"))))))));
			this.mởFileHTMLToolStripMenuItem.Click += new global::System.EventHandler(this.mơFileHTMLToolStripMenuItem_Click);
			this.mởFolderBackupToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNHlOSGRYYmxwcFVqRktjMWt5ZEV0aFJtdDVaRVJHYWxKc1NqSlpha28wVmtkU1NWTnVRbXBTVkVaeldXMDFWMU50VWtoV2JsRTk="))))))));
			this.mởFolderBackupToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.mởFolderBackupToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vlcwd05XTXhjRWhXYm14S1VsVndiMWRVU2pCTlYwNUNVRlF3UFE9PQ=="))))))));
			this.mởFolderBackupToolStripMenuItem.Click += new global::System.EventHandler(this.mởThưMụcBackupToolStripMenuItem_Click);
			this.backupToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.htmlToolStripMenuItem,
				this.thưMụcToolStripMenuItem
			});
			this.backupToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUlhRTFoTW5nd1YxWmthMkpCUFQwPQ==")))))))));
			this.backupToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUlaejA9"))))))));
			this.backupToolStripMenuItem1.Size = new global::System.Drawing.Size(183, 22);
			this.backupToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUXlWbFJSYlhRMFkydFNUbG96YkVOak1rWnFWRE5HTmxNd05IaFRWVlpMWVVacmVXUkVSbXBSVkRBNQ=="))))))));
			this.htmlToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZWb1UyUkhTa2RWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVFOVBRPT0="))))))));
			this.htmlToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.htmlToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlcweGMyTXhjRlJSYTJ4WFVsUkdUZz09"))))))));
			this.htmlToolStripMenuItem.Click += new global::System.EventHandler(this.htmlToolStripMenuItem_Click);
			this.thưMụcToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2NWSXpUa1pOTW1neFRteGFjVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.thưMụcToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.thưMụcToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vlcwd05XTXhjRWhXYm14S1VsVndiMWRVU2pCTlYwNUNVRlF3UFE9PQ=="))))))));
			this.thưMụcToolStripMenuItem.Click += new global::System.EventHandler(this.thưMụcToolStripMenuItem_Click_1);
			this.xóaDữLiệuBackupToolStripMenuItem.Image = global::maxcare.Properties.Resources.close_window_25px;
			this.xóaDữLiệuBackupToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRlpXUjJneFRtcHNUbGxYVmtoT01tZDZWbXRPV2xZd05YbGFSbWhEVmxkSmVVOVlUbFpOTVVvMVdWWm9RMVJzY0ZoT1ZFWlVWMFpLYzFsc1JUbFFVVDA5"))))))));
			this.xóaDữLiệuBackupToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.xóaDữLiệuBackupToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHVnNiRlJSYlhNd1dXNVdNbE5WWkRSalJGSnBaRlZvYTFVd1NrUlhWbVJQWTIxU1dWRlVNRDA9"))))))));
			this.xóaDữLiệuBackupToolStripMenuItem.Click += new global::System.EventHandler(this.xóaDữLiệuBackupToolStripMenuItem_Click);
			this.tảiLạiDanhSáchToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXRPSGxpUlRBd1dXNUdiMWxXVmxOaFIwcDBZVVpTTTA1clduRlpWVnBUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUZSSGRITmtSbXhZV2tkM1BRPT0=")))))))));
			this.tảiLạiDanhSáchToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXRPSGxpUlRBd1dXNUdiMWxXVmxOaFIwcDBZVVpTTTA1clduRlpWVnBUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUE9PQ=="))))))));
			this.tảiLạiDanhSáchToolStripMenuItem.Size = new global::System.Drawing.Size(197, 22);
			this.tảiLạiDanhSáchToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNXRPSGxoTW1ScFZEQmpNbUl4WkhKYU1YQklVbTVXYUZFd1NqWmtlbHBIWVcxR1FsQlVNRDA9"))))))));
			this.tảiLạiDanhSáchToolStripMenuItem.Click += new global::System.EventHandler(this.TảiLạiDanhSáchToolStripMenuItem_Click);
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
			this.pnlHeader.Size = new global::System.Drawing.Size(1203, 29);
			this.pnlHeader.TabIndex = 0;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.pictureBox1.Location = new global::System.Drawing.Point(6, 1);
			this.pictureBox1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaUVVUMDk="))))))));
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.DoubleClick += new global::System.EventHandler(this.pictureBox1_DoubleClick);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1lWUldTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.button2.Location = new global::System.Drawing.Point(1107, 0);
			this.button2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1dub3dPUT09"))))))));
			this.button2.Size = new global::System.Drawing.Size(32, 29);
			this.button2.TabIndex = 0;
			this.button2.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.Button2_Click);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1ZYcFdTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.button1.Location = new global::System.Drawing.Point(1139, 0);
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
			this.btnMinimize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.btnMinimize.Location = new global::System.Drawing.Point(1171, 0);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(186, 16);
			this.bunifuCustomLabel1.TabIndex = 3;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1sSklVMFV4YmxJeWRHNVpWRXB2Wkd4c2FtVlZjR2xoVlZKR1lURmtTVlJYWkRWUmFsSnBUMGhzUTFkV1JUbFFVVDA5"))))))));
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.DarkRed;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RXdGFOVmRyYUU1bFFUMDk="))))))));
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(1204, 38);
			this.bunifuCards1.TabIndex = 0;
			this.menuStrip1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = global::System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.thoátToolStripMenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 37);
			this.menuStrip1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1YyUlhVbGRVYWtKcVlsZDRNMVJXUlRsUVVUMDk="))))))));
			this.menuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new global::System.Drawing.Size(1201, 25);
			this.menuStrip1.Stretch = false;
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1YyUlhVbGRVYWtKcVlsZDRNMVJXUlRsUVVUMDk="))))))));
			this.thoátToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_show_property_48px;
			this.thoátToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2IyUnVZekpTYWtKWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUVNRDA9"))))))));
			this.thoátToolStripMenuItem.Size = new global::System.Drawing.Size(132, 21);
			this.thoátToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSb1VHRlljRXBTYWtaS1VqSm9kMlZyYkVOa1YwWkVVVzA1YUZrd09YaGxhMnh6WkZWc1NWVnRPV2haTTJ4eA=="))))))));
			this.thoátToolStripMenuItem.Click += new global::System.EventHandler(this.câuHinhHiênThiToolStripMenuItem_Click);
			this.grQuanLyThuMuc.Controls.Add(this.btnLoadAcc);
			this.grQuanLyThuMuc.Controls.Add(this.cbbTinhTrang);
			this.grQuanLyThuMuc.Controls.Add(this.cbbThuMuc);
			this.grQuanLyThuMuc.Controls.Add(this.label2);
			this.grQuanLyThuMuc.Controls.Add(this.label1);
			this.grQuanLyThuMuc.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.grQuanLyThuMuc.Location = new global::System.Drawing.Point(292, 65);
			this.grQuanLyThuMuc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwT1MxVnRVbGhTYmxaVlUwZDRWbGxWYUZkVWJWSllWRlF3UFE9PQ=="))))))));
			this.grQuanLyThuMuc.Size = new global::System.Drawing.Size(445, 53);
			this.grQuanLyThuMuc.TabIndex = 5;
			this.grQuanLyThuMuc.TabStop = false;
			this.grQuanLyThuMuc.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmxab1dXRklWbmhVYmxaS1VqTndSV1JzVGtOTlIwWk9XVmhrU2xKNlRtOWtWRnBYWVdjOVBRPT0="))))))));
			this.btnLoadAcc.BackgroundImage = global::maxcare.Properties.Resources.available_updates_25px;
			this.btnLoadAcc.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.btnLoadAcc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnLoadAcc.Location = new global::System.Drawing.Point(416, 19);
			this.btnLoadAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVa2hQVjJoaFVsVmFjVmRZWXpsUVVUMDk="))))))));
			this.btnLoadAcc.Size = new global::System.Drawing.Size(25, 25);
			this.btnLoadAcc.TabIndex = 6;
			this.toolTip1.SetToolTip(this.btnLoadAcc, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWak5XRkdjRVJSYmswd1dXNUdiMWxXVGtOaE1XeFlUbGM1U2xOR1FrVmlNV1JQWW5jOVBRPT0=")))))))));
			this.btnLoadAcc.UseSelectable = true;
			this.btnLoadAcc.Click += new global::System.EventHandler(this.BtnLoadAcc_Click);
			this.cbbTinhTrang.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbTinhTrang.DropDownWidth = 300;
			this.cbbTinhTrang.FontSize = global::MetroFramework.MetroComboBoxSize.Small;
			this.cbbTinhTrang.FormattingEnabled = true;
			this.cbbTinhTrang.ItemHeight = 19;
			this.cbbTinhTrang.Items.AddRange(new object[]
			{
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm5wR1ZXRklWbmhXYWtKS1VqRkNiMlJZUms1YU1sSk9WRE5PYVdKWFpHNWFSV2hOWVVoV2VGSnVWbUZOVkVFNQ=="))))))))
			});
			this.cbbTinhTrang.Location = new global::System.Drawing.Point(289, 19);
			this.cbbTinhTrang.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS1MyRldXa2hpU0Zab1VteEtOVmRXWXpGaVp6MDk="))))))));
			this.cbbTinhTrang.Size = new global::System.Drawing.Size(121, 25);
			this.cbbTinhTrang.TabIndex = 3;
			this.cbbTinhTrang.UseSelectable = true;
			this.cbbTinhTrang.SelectedIndexChanged += new global::System.EventHandler(this.cbbTinhTrang_SelectedIndexChanged);
			this.cbbThuMuc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbThuMuc.DropDownWidth = 350;
			this.cbbThuMuc.FontSize = global::MetroFramework.MetroComboBoxSize.Small;
			this.cbbThuMuc.FormattingEnabled = true;
			this.cbbThuMuc.ItemHeight = 19;
			this.cbbThuMuc.Items.AddRange(new object[]
			{
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm5wR1ZXRklWbmhXYWtKS1VqRkNiMlJZUms1YU1sSklZV3RrZWxFd1NqQk9SMG94WWtacmVFMUVNRDA9"))))))))
			});
			this.cbbThuMuc.Location = new global::System.Drawing.Point(72, 19);
			this.cbbThuMuc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS1MyRldXa2hoUkVaVlYwWmFjUT09"))))))));
			this.cbbThuMuc.Size = new global::System.Drawing.Size(173, 25);
			this.cbbThuMuc.TabIndex = 1;
			this.cbbThuMuc.UseSelectable = true;
			this.cbbThuMuc.SelectedIndexChanged += new global::System.EventHandler(this.CbbFileAccount_SelectedIndexChanged);
			this.label2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(249, 22);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(42, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVNVNFNHljRmhVVkZrOQ=="))))))));
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(8, 23);
			this.label1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJjOQ=="))))))));
			this.label1.Size = new global::System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXpUa1JSYmxFd1dXNVdjMWRZY0haUVVUMDk="))))))));
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.grTimKiem.Controls.Add(this.BtnSearch);
			this.grTimKiem.Controls.Add(this.cbbSearch);
			this.grTimKiem.Controls.Add(this.txbSearch);
			this.grTimKiem.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.grTimKiem.Location = new global::System.Drawing.Point(2, 65);
			this.grTimKiem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwT1MxWlhSbGhOVlhob1ZqRmFNQT09"))))))));
			this.grTimKiem.Size = new global::System.Drawing.Size(284, 53);
			this.grTimKiem.TabIndex = 4;
			this.grTimKiem.TabStop = false;
			this.grTimKiem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVHTXlTbFJSYmtwb1dsVmpNbVJxU1hkUVVUMDk="))))))));
			this.BtnSearch.BackgroundImage = global::maxcare.Properties.Resources.icons8_search_24px_1;
			this.BtnSearch.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.BtnSearch.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.BtnSearch.Location = new global::System.Drawing.Point(253, 18);
			this.BtnSearch.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZjMVUyUldWWGxXYldocVlsVTFkZz09"))))))));
			this.BtnSearch.Size = new global::System.Drawing.Size(24, 24);
			this.BtnSearch.TabIndex = 2;
			this.BtnSearch.UseSelectable = true;
			this.BtnSearch.Click += new global::System.EventHandler(this.BtnSearch_Click);
			this.cbbSearch.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbSearch.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbSearch.DropDownWidth = 100;
			this.cbbSearch.FormattingEnabled = true;
			this.cbbSearch.Location = new global::System.Drawing.Point(12, 18);
			this.cbbSearch.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS1MyRldWWGxXYldocVlsVTFkZz09"))))))));
			this.cbbSearch.Size = new global::System.Drawing.Size(86, 24);
			this.cbbSearch.TabIndex = 0;
			this.txbSearch.BorderColor = global::System.Drawing.Color.SeaGreen;
			this.txbSearch.Location = new global::System.Drawing.Point(104, 19);
			this.txbSearch.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IyRldWWGxXYldocVlsVTFkZz09"))))))));
			this.txbSearch.Size = new global::System.Drawing.Size(143, 23);
			this.txbSearch.TabIndex = 1;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl2.Vertical = true;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 30000;
			this.toolTip1.InitialDelay = 0;
			this.toolTip1.ReshowDelay = 40;
			this.statusStrip1.BackColor = global::System.Drawing.SystemColors.Control;
			this.statusStrip1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel5,
				this.lblCountSelect,
				this.toolStripStatusLabel7,
				this.lblCountTotal
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 588);
			this.statusStrip1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1hwT1UyRkhVa2xXYm5CV1RURktOVmxXYUVKbFFUMDk="))))))));
			this.statusStrip1.Size = new global::System.Drawing.Size(1204, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1hwT1UyRkhVa2xXYm5CV1RURktOVmxXYUVKbFFUMDk="))))))));
			this.toolStripStatusLabel5.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel5.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XUnRTa2RVYWtKcVlsZDRNMVpVVGxOaFIxSkpWbTV3VlZJd1duQlhiR1F6VFZFOVBRPT0="))))))));
			this.toolStripStatusLabel5.Size = new global::System.Drawing.Size(66, 17);
			this.toolStripStatusLabel5.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhCb1ZEQmpNMkZzWXpCT1p6MDk="))))))));
			this.lblCountSelect.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCountSelect.ForeColor = global::System.Drawing.Color.FromArgb(0, 64, 0);
			this.lblCountSelect.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhSWGxQVkVacFlteEtWVmRzWkRSaVJtdDZWVlF3UFE9PQ=="))))))));
			this.lblCountSelect.Size = new global::System.Drawing.Size(16, 17);
			this.lblCountSelect.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
			this.toolStripStatusLabel7.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel7.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XUnRTa2RVYWtKcVlsZDRNMVpVVGxOaFIxSkpWbTV3VlZJd1duQlhiR1F6VFhjOVBRPT0="))))))));
			this.toolStripStatusLabel7.Size = new global::System.Drawing.Size(53, 17);
			this.toolStripStatusLabel7.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNXVRbGxWVjJSYVN6QmpNbUl6Y0haUVVUMDk="))))))));
			this.lblCountTotal.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCountTotal.ForeColor = global::System.Drawing.Color.Maroon;
			this.lblCountTotal.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhSWGxQVkVacFlteEtWbGxxVGxOaFIwcENVRlF3UFE9PQ=="))))))));
			this.lblCountTotal.Size = new global::System.Drawing.Size(16, 17);
			this.lblCountTotal.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
			this.button9.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button9.BackColor = global::System.Drawing.Color.White;
			this.button9.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button9.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button9.Image = global::maxcare.Properties.Resources.icons8_sync;
			this.button9.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button9.Location = new global::System.Drawing.Point(836, 78);
			this.button9.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUVZWUXdPUT09"))))))));
			this.button9.Size = new global::System.Drawing.Size(158, 34);
			this.button9.TabIndex = 12;
			this.button9.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hoTW1ScVVqSm5lR1ZyZEU5aGEyeEpWVzFvTmxOVlNuZFRWV1F3WWpKSmVWTkZNWEJXZWxFNQ=="))))))));
			this.button9.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			this.button3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button3.BackColor = global::System.Drawing.Color.White;
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button3.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.Image = global::maxcare.Properties.Resources.icons8_delete_bin;
			this.button3.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new global::System.Drawing.Point(1000, 78);
			this.button3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1pIb3dPUT09"))))))));
			this.button3.Size = new global::System.Drawing.Size(201, 34);
			this.button3.TabIndex = 12;
			this.button3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpCamRsUlhaRmhTVjJSclVqQm9UbG93WkhKYU1rVjVZVWhhV2xremJFdFpiV3hEVFcxR2FtVlZVbWxpVjJSdVdrY3hkVkpJUm5wbFZWSnBXbm93T1E9PQ=="))))))));
			this.button3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click_1);
			this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.label3.BackColor = global::System.Drawing.SystemColors.Control;
			this.label3.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Red;
			this.label3.Location = new global::System.Drawing.Point(688, 591);
			this.label3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTI4OQ=="))))))));
			this.label3.Size = new global::System.Drawing.Size(515, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm5wQ1RWSklVa2hoTW1RMFUydGFjMWx0YkVOa1YwWklZbTFvTVU1RldYaFRWV1JWVWtoT2RFNVhOVXBUUlhodlpGUldUMk5GYkVoT1Z6Z3dXVzVHYzFsdGJFTmtNa1pPVkROU2FWVXdTbFZaTUdSSFlXeHdWMDFIWkdoU2VUbHZaRmhLYTJGcmJFZGtSVkpwVWpKNGNWbFliRVZTVjNScVZIcGFhbEV3U1hsa2VscERaR3RzU1ZaRlVuWlNNblJ1V1ZSS2IyUnFVbWxqVjNCcFlrUkNibVZGY0VsaFNGVXdWRmRrYTFSVk9UQlhWRXB1V2pGcmVXRnRhREZPUkVZeFUxWkZPVkJSUFQwPQ=="))))))));
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Click += new global::System.EventHandler(this.label3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1204, 610);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.grTimKiem);
			base.Controls.Add(this.grQuanLyThuMuc);
			base.Controls.Add(this.dtgvAcc);
			base.Controls.Add(this.bunifuCards1);
			base.Controls.Add(this.menuStrip1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VTJ0b1UySXlSbGxVV0ZaVVZqQTFNbGx0WXpsUVVUMDk=")))))))));
			base.MainMenuStrip = this.menuStrip1;
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMFMyTkhTbTVRVkRBOQ=="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtaV1IxZFZiRVpVYTBwV1lURlZPUT09"))))))));
			base.Load += new global::System.EventHandler(this.FMain_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dtgvAcc).EndInit();
			this.ctmsAcc.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.grQuanLyThuMuc.ResumeLayout(false);
			this.grTimKiem.ResumeLayout(false);
			this.grTimKiem.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400036C RID: 876
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400036D RID: 877
		public global::System.Windows.Forms.DataGridView dtgvAcc;

		// Token: 0x0400036E RID: 878
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400036F RID: 879
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000370 RID: 880
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000371 RID: 881
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000372 RID: 882
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000373 RID: 883
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000374 RID: 884
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000375 RID: 885
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000376 RID: 886
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x04000377 RID: 887
		private global::System.Windows.Forms.GroupBox grQuanLyThuMuc;

		// Token: 0x04000378 RID: 888
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000379 RID: 889
		private global::MetroFramework.Controls.MetroComboBox cbbThuMuc;

		// Token: 0x0400037A RID: 890
		private global::MetroFramework.Controls.MetroContextMenu ctmsAcc;

		// Token: 0x0400037B RID: 891
		private global::System.Windows.Forms.ToolStripMenuItem chọnLiveToolStripMenuItem;

		// Token: 0x0400037C RID: 892
		private global::System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;

		// Token: 0x0400037D RID: 893
		private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

		// Token: 0x0400037E RID: 894
		private global::System.Windows.Forms.ToolStripMenuItem tokenToolStripMenuItem;

		// Token: 0x0400037F RID: 895
		private global::System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem;

		// Token: 0x04000380 RID: 896
		private global::System.Windows.Forms.ToolStripMenuItem uidPassToolStripMenuItem;

		// Token: 0x04000381 RID: 897
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

		// Token: 0x04000382 RID: 898
		private global::System.Windows.Forms.ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;

		// Token: 0x04000383 RID: 899
		private global::System.Windows.Forms.ToolStripMenuItem checkCookieToolStripMenuItem;

		// Token: 0x04000384 RID: 900
		private global::System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;

		// Token: 0x04000385 RID: 901
		private global::System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem;

		// Token: 0x04000386 RID: 902
		private global::System.Windows.Forms.ToolStripMenuItem bỏChọnTấtCảToolStripMenuItem;

		// Token: 0x04000387 RID: 903
		private global::System.Windows.Forms.ToolStripMenuItem passToolStripMenuItem;

		// Token: 0x04000388 RID: 904
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraCookieToolStripMenuItem;

		// Token: 0x04000389 RID: 905
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraTokenToolStripMenuItem;

		// Token: 0x0400038A RID: 906
		private global::System.Windows.Forms.ToolStripMenuItem tảiLạiDanhSáchToolStripMenuItem;

		// Token: 0x0400038B RID: 907
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraTàiKhoảnToolStripMenuItem;

		// Token: 0x0400038C RID: 908
		private global::System.Windows.Forms.ToolStripMenuItem mailPassMailToolStripMenuItem;

		// Token: 0x0400038D RID: 909
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieMailPassMailToolStripMenuItem;

		// Token: 0x0400038E RID: 910
		private global::System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;

		// Token: 0x0400038F RID: 911
		private global::System.Windows.Forms.ToolStripMenuItem trạngTháiToolStripMenuItem;

		// Token: 0x04000390 RID: 912
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraWallToolStripMenuItem;

		// Token: 0x04000391 RID: 913
		private global::System.Windows.Forms.GroupBox grTimKiem;

		// Token: 0x04000392 RID: 914
		private global::WindowsFormsControlLibrary1.BunifuCustomTextbox txbSearch;

		// Token: 0x04000393 RID: 915
		private global::System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;

		// Token: 0x04000394 RID: 916
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;

		// Token: 0x04000395 RID: 917
		private global::System.Windows.Forms.ToolStripMenuItem xóaProfileToolStripMenuItem;

		// Token: 0x04000396 RID: 918
		private global::System.Windows.Forms.ToolStripMenuItem fAToolStripMenuItem;

		// Token: 0x04000397 RID: 919
		private global::System.Windows.Forms.ToolStripMenuItem tinhTrangToolStripMenuItem;

		// Token: 0x04000398 RID: 920
		private global::System.Windows.Forms.ToolStripMenuItem uidPass2FaToolStripMenuItem;

		// Token: 0x04000399 RID: 921
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400039A RID: 922
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x0400039B RID: 923
		private global::System.Windows.Forms.ToolStripMenuItem đinhDangKhacToolStripMenuItem;

		// Token: 0x0400039C RID: 924
		private global::System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem1;

		// Token: 0x0400039D RID: 925
		private global::System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem;

		// Token: 0x0400039E RID: 926
		private global::System.Windows.Forms.ToolStripMenuItem thưMụcToolStripMenuItem;

		// Token: 0x0400039F RID: 927
		private global::System.Windows.Forms.ToolStripMenuItem maBaoMât6SôToolStripMenuItem;

		// Token: 0x040003A0 RID: 928
		private global::System.Windows.Forms.ToolStripMenuItem donDepProfileToolStripMenuItem;

		// Token: 0x040003A1 RID: 929
		private global::System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;

		// Token: 0x040003A2 RID: 930
		private global::System.Windows.Forms.ToolStripMenuItem useragentToolStripMenuItem1;

		// Token: 0x040003A3 RID: 931
		private global::System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem1;

		// Token: 0x040003A4 RID: 932
		private global::System.Windows.Forms.ComboBox cbbSearch;

		// Token: 0x040003A5 RID: 933
		private global::System.Windows.Forms.ToolStripMenuItem mởThưMụcBackupToolStripMenuItem;

		// Token: 0x040003A6 RID: 934
		private global::MetroFramework.Controls.MetroButton btnLoadAcc;

		// Token: 0x040003A7 RID: 935
		private global::MetroFramework.Controls.MetroComboBox cbbTinhTrang;

		// Token: 0x040003A8 RID: 936
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040003A9 RID: 937
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraMailpassMailToolStripMenuItem;

		// Token: 0x040003AA RID: 938
		private global::MetroFramework.Controls.MetroButton BtnSearch;

		// Token: 0x040003AB RID: 939
		private global::System.Windows.Forms.ToolStripMenuItem uidToolStripMenuItem;

		// Token: 0x040003AC RID: 940
		private global::System.Windows.Forms.ToolStripMenuItem checkAvatarToolStripMenuItem;

		// Token: 0x040003AD RID: 941
		private global::System.Windows.Forms.ToolStripMenuItem checkProxyToolStripMenuItem;

		// Token: 0x040003AE RID: 942
		private global::System.Windows.Forms.ToolStripMenuItem checkProfileToolStripMenuItem1;

		// Token: 0x040003AF RID: 943
		private global::System.Windows.Forms.ToolStripMenuItem xóaDữLiệuBackupToolStripMenuItem;

		// Token: 0x040003B0 RID: 944
		private global::System.Windows.Forms.ToolStripMenuItem mởFolderBackupToolStripMenuItem;

		// Token: 0x040003B1 RID: 945
		private global::System.Windows.Forms.ToolStripMenuItem mởFileHTMLToolStripMenuItem;

		// Token: 0x040003B2 RID: 946
		private global::System.Windows.Forms.ToolStripMenuItem checkBackupToolStripMenuItem;

		// Token: 0x040003B3 RID: 947
		private global::System.Windows.Forms.ToolStripMenuItem checkInfoUIDToolStripMenuItem;

		// Token: 0x040003B4 RID: 948
		private global::System.Windows.Forms.ToolStripMenuItem checkBackupToolStripMenuItem1;

		// Token: 0x040003B5 RID: 949
		private global::System.Windows.Forms.ToolStripMenuItem khôiPhucTaiKhoanToolStripMenuItem;

		// Token: 0x040003B6 RID: 950
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x040003B7 RID: 951
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;

		// Token: 0x040003B8 RID: 952
		private global::System.Windows.Forms.ToolStripStatusLabel lblCountSelect;

		// Token: 0x040003B9 RID: 953
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;

		// Token: 0x040003BA RID: 954
		private global::System.Windows.Forms.ToolStripStatusLabel lblCountTotal;

		// Token: 0x040003BB RID: 955
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn cChose;

		// Token: 0x040003BC RID: 956
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x040003BD RID: 957
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cId;

		// Token: 0x040003BE RID: 958
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cUid;

		// Token: 0x040003BF RID: 959
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cToken;

		// Token: 0x040003C0 RID: 960
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cCookies;

		// Token: 0x040003C1 RID: 961
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cEmail;

		// Token: 0x040003C2 RID: 962
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPhone;

		// Token: 0x040003C3 RID: 963
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cName;

		// Token: 0x040003C4 RID: 964
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFollow;

		// Token: 0x040003C5 RID: 965
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFriend;

		// Token: 0x040003C6 RID: 966
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGroup;

		// Token: 0x040003C7 RID: 967
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cBirthday;

		// Token: 0x040003C8 RID: 968
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGender;

		// Token: 0x040003C9 RID: 969
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPassword;

		// Token: 0x040003CA RID: 970
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cMailRecovery;

		// Token: 0x040003CB RID: 971
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPassMail;

		// Token: 0x040003CC RID: 972
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cBackup;

		// Token: 0x040003CD RID: 973
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFa2;

		// Token: 0x040003CE RID: 974
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cUseragent;

		// Token: 0x040003CF RID: 975
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cProxy;

		// Token: 0x040003D0 RID: 976
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cDateCreateAcc;

		// Token: 0x040003D1 RID: 977
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cAvatar;

		// Token: 0x040003D2 RID: 978
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cProfile;

		// Token: 0x040003D3 RID: 979
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cThuMuc;

		// Token: 0x040003D4 RID: 980
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cInteractEnd;

		// Token: 0x040003D5 RID: 981
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cInfo;

		// Token: 0x040003D6 RID: 982
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;

		// Token: 0x040003D7 RID: 983
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cDateDelete;

		// Token: 0x040003D8 RID: 984
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStatus;

		// Token: 0x040003D9 RID: 985
		private global::System.Windows.Forms.Button button9;

		// Token: 0x040003DA RID: 986
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040003DB RID: 987
		private global::System.Windows.Forms.ToolStripMenuItem mởTrìnhDuyệtToolStripMenuItem;

		// Token: 0x040003DC RID: 988
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040003DD RID: 989
		private global::System.Windows.Forms.ToolStripMenuItem tiếnHànhMởToolStripMenuItem;

		// Token: 0x040003DE RID: 990
		private global::System.Windows.Forms.ToolStripMenuItem càiĐặtCấuHìnhMởToolStripMenuItem;
	}
}
