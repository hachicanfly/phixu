namespace maxcare
{
	// Token: 0x02000132 RID: 306
	public partial class fMain : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F9C RID: 3996 RVA: 0x003E7734 File Offset: 0x003E5934
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x003E7794 File Offset: 0x003E5994
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fMain));
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
			this.cStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ctmsAcc = new global::MetroFramework.Controls.MetroContextMenu(this.components);
			this.chọnLiveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tấtCảToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.liveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tinhTrangToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trạngTháiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bỏChọnTấtCảToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
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
			this.mởTrìnhDuyệtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởLuônToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.càiĐặtCấuHìnhMởToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaTàiKhoảnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraWallToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkInfoUIDToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraTokenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkAvatarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProfileToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkBackupToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraMailpassMailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProxyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.câpNhâtThôngTinCaNhânToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sưDungTokenTrungGianToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sửDụngCookieTrungGianToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cậpNhậtDữLiệuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cậpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mậtKhẩuToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tựĐộngLấyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenEAAAAZToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenBussinessToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nhậpDữLiệuToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cookieToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mailKhôiPhụcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.passMailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mã2FAToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.useragentToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.proxyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ghiChuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ngàySinhToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chuyểnThưMụcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chứcNăngToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.locTrungToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.taoShortcutChromeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tảiXuốngAvatarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.loginHotmailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.loginYandexToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.loginGmailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởFormQuảnLýTinNhắnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.khôiPhụcMậtKhẩuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.đổiPassHotmailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.profileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tạoProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.đăngNhâpBăngUidpassToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.đăngNhâpBăngCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.donDepProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaCacheToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.copyProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.taoFileHTMLToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởThưMụcBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởFileHTMLToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mởFolderBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.htmlToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fileTxtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.thưMụcToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaDữLiệuBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dọnDẹpBackupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.giaiCheckpointToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.giảiCheckpintNgàySinhToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gửiOTPVềMailMbasicbetaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.giảiCP282ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tảiLạiDanhSáchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.lblNotify = new global::System.Windows.Forms.LinkLabel();
			this.lblStatusUpdate = new global::System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.hệThốngToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.càiĐặtToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.thoátToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.taiKhoanĐaXoaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tiệnÍchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkLiveUidToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkProxyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkHotmailToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lọcTrùngDữLiệuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xửLýChuỗiOnlineToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.liênHệToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.grQuanLyThuMuc = new global::System.Windows.Forms.GroupBox();
			this.btnLoadAcc = new global::MetroFramework.Controls.MetroButton();
			this.btnEditFile = new global::MetroFramework.Controls.MetroButton();
			this.btnDeleteFile = new global::MetroFramework.Controls.MetroButton();
			this.AddFileAccount = new global::MetroFramework.Controls.MetroButton();
			this.cbbTinhTrang = new global::MetroFramework.Controls.MetroComboBox();
			this.cbbThuMuc = new global::MetroFramework.Controls.MetroComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button9 = new global::System.Windows.Forms.Button();
			this.grTimKiem = new global::System.Windows.Forms.GroupBox();
			this.BtnSearch = new global::MetroFramework.Controls.MetroButton();
			this.cbbSearch = new global::System.Windows.Forms.ComboBox();
			this.txbSearch = new global::WindowsFormsControlLibrary1.BunifuCustomTextbox();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblStatus = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblKey = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel8 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.txbUid = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblUser = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel9 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel10 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblDateExpried = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblCountHighline = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblCountSelect = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel7 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblCountTotal = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.btnViewLivestream = new global::System.Windows.Forms.Button();
			this.btnShare = new global::System.Windows.Forms.Button();
			this.btnPost = new global::System.Windows.Forms.Button();
			this.btnPause = new global::System.Windows.Forms.Button();
			this.btnInteract = new global::System.Windows.Forms.Button();
			this.plChucNang = new global::System.Windows.Forms.Panel();
			this.button8 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			this.metroButton1 = new global::MetroFramework.Controls.MetroButton();
			this.btnRandomIndexRow = new global::MetroFramework.Controls.MetroButton();
			this.plTrangThai = new global::System.Windows.Forms.Panel();
			this.lblTrangThai = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.dtgvAcc).BeginInit();
			this.ctmsAcc.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.grQuanLyThuMuc.SuspendLayout();
			this.grTimKiem.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.plChucNang.SuspendLayout();
			this.plTrangThai.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.dtgvAcc.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtgvAcc.Location = new global::System.Drawing.Point(9, 156);
			this.dtgvAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0b1UySnRVbkpTYlhCYVpIb3dPUT09"))))))));
			this.dtgvAcc.RowHeadersVisible = false;
			this.dtgvAcc.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvAcc.Size = new global::System.Drawing.Size(1225, 423);
			this.dtgvAcc.TabIndex = 0;
			this.dtgvAcc.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvAcc_CellClick);
			this.dtgvAcc.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAcc_CellDoubleClick);
			this.dtgvAcc.CellValueChanged += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAcc_CellValueChanged);
			this.dtgvAcc.SelectionChanged += new global::System.EventHandler(this.dtgvAcc_SelectionChanged);
			this.dtgvAcc.SortCompare += new global::System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dtgvAcc_SortCompare);
			this.dtgvAcc.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.DtgvAcc_KeyDown);
			this.cChose.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEJOV0ZVOQ=="))))))));
			this.cChose.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))));
			this.cChose.Width = 40;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.cStt.DefaultCellStyle = dataGridViewCellStyle3;
			this.cStt.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSR1UxWlJQVDA9"))))))));
			this.cStt.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1QwMUhVa0pRVkRBOQ=="))))))));
			this.cStt.Width = 35;
			this.cId.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlRGa1VsQlJQVDA9"))))))));
			this.cId.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))));
			this.cId.Visible = false;
			this.cId.Width = 90;
			this.cUid.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14V2MxSlJQVDA9"))))))));
			this.cUid.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))));
			this.cUid.Width = 80;
			this.cToken.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10ak5XTnNjRmhPUkRBOQ=="))))))));
			this.cToken.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ=="))))))));
			this.cToken.Width = 70;
			this.cCookies.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNjOQ=="))))))));
			this.cCookies.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))));
			this.cCookies.Width = 70;
			this.cEmail.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld4amVHRkhSbGhrZWpBOQ=="))))))));
			this.cEmail.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ=="))))))));
			this.cEmail.Width = 60;
			this.cPhone.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWa2IyUnRTblJXVkRBOQ=="))))))));
			this.cPhone.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EySXlTWGxPVjNjOQ=="))))))));
			this.cPhone.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cPhone.Visible = false;
			this.cPhone.Width = 90;
			this.cName.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVHTlhTbTVRVkRBOQ=="))))))));
			this.cName.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))));
			this.cName.Width = 70;
			this.cFollow.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2IySkhTalZSYlhScFQwaHNSVmxXUlRsUVVUMDk="))))))));
			this.cFollow.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1lXUnRTa2hsU0ZwclpIb3dPUT09"))))))));
			this.cFollow.Width = 80;
			this.cFriend.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVlsWm9UbG93UlRsUVVUMDk="))))))));
			this.cFriend.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1lXVlhSbGhXYmxaaFVWUXdPUT09"))))))));
			this.cFriend.Width = 70;
			this.cGroup.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGIyUnVjRXBTYmxFOQ=="))))))));
			this.cGroup.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2EyVlhTWHBXYm1NOQ=="))))))));
			this.cGroup.Width = 60;
			this.cBirthday.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGEyRkljRXBSYWxaS1UwVTFkMWx0TVc1UVVUMDk="))))))));
			this.cBirthday.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1MyTkhUblZWYlRsaFVqQlpNUT09"))))))));
			this.cBirthday.Width = 90;
			this.cGender.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldwS2RXRklWVEZrU0VKS1VteFNSV05zWXpGaWR6MDk="))))))));
			this.cGender.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2EySkhTblJWYlhocVdub3dPUT09"))))))));
			this.cGender.Width = 80;
			this.cPassword.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkV1NFNXVTbGxWVjJSb1RXMXdiMlJZUm5OTlVUMDk="))))))));
			this.cPassword.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))));
			this.cPassword.Visible = false;
			this.cPassword.Width = 70;
			this.cMailRecovery.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld4amVHRkhSbGhrTW1Sb1RXMXdSV1JGWkhKYU1rNUlZVzFvTVU1c1duRT0="))))))));
			this.cMailRecovery.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQmVHRkhSbGhsUms1aFZqQTFNbHBITVZkbFYxWlNVRlF3UFE9PQ=="))))))));
			this.cMailRecovery.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cMailRecovery.Visible = false;
			this.cMailRecovery.Width = 120;
			this.cPassMail.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkV1NFNXVTbGxWVjJSb1RXMXdiMlJZUm5OTlZXeElUVmRvYUZZell6az0="))))))));
			this.cPassMail.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyRkhUWHBVYXpWYVZqSjRlZz09"))))))));
			this.cPassMail.Visible = false;
			this.cPassMail.Width = 120;
			this.cBackup.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZjeFIyRnRSWHBXYm1NOQ=="))))))));
			this.cBackup.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1MyRkdhM2xrUkVacVVWUXdPUT09"))))))));
			this.cBackup.Width = 70;
			this.cFa2.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkT1VHRnJiRVZUYTJSU1ZWUXdPUT09"))))))));
			this.cFa2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ=="))))))));
			this.cFa2.Width = 65;
			this.cUseragent.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14b1QySkhUblJTYlRWaFZucFZkdz09"))))))));
			this.cUseragent.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk="))))))));
			this.cUseragent.Width = 70;
			this.cProxy.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWb1MyUnRWa2xoZWpBOQ=="))))))));
			this.cProxy.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ=="))))))));
			this.cProxy.Width = 55;
			this.cDateCreateAcc.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGEyRkljRXBSYWxaS1UwWktiMlZyZEU5a1p6MDk="))))))));
			this.cDateCreateAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1UyRkhVa2hXYTFKcVlsWmFiMXBGWkZkUmJHdDVWRlF3UFE9PQ=="))))))));
			this.cDateCreateAcc.Width = 85;
			this.cAvatar.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZab1lXRkhVa2hTYm1zOQ=="))))))));
			this.cAvatar.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1IwMXNiRmxWYldocVdub3dPUT09"))))))));
			this.cAvatar.Width = 50;
			this.cProfile.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWb1MyUnNjSFJpU0U1aFZWUXdPUT09"))))))));
			this.cProfile.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyVlhTWGxYYmtKcFVqRlZPUT09"))))))));
			this.cProfile.Width = 50;
			this.cThuMuc.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXpUa1JSYmxFd1dXNVdjMWRZWXpsUVVUMDk="))))))));
			this.cThuMuc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1UySXlVbFpOVkVaYVpIb3dPUT09"))))))));
			this.cInteractEnd.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVeFVHRlljRXBSYmxaS1UwWlNTR013TVdoaFIwcDBXVEprYTFJd2FFNWFNV1JPV2pGcmVsZEZVakJVV0d4RFdWWkZPVkJSUFQwPQ=="))))))));
			this.cInteractEnd.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2MyUlhVa2hXYm14YVZqQTBkMVZzWXpGaGR6MDk="))))))));
			this.cInfo.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.cInfo.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVHTXlTblJhTW1SWFUwVjRiMlJZUmtka1ZuQXpVRlF3UFE9PQ=="))))))));
			this.cInfo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ=="))))))));
			this.cInfo.Width = 90;
			this.cGhiChu.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldwS2IyTkZiRVpVYlRrelRqSTRPUT09"))))))));
			this.cGhiChu.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2EySXlSbFpVYlRsclZWUXdPUT09"))))))));
			this.cStatus.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cStatus.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10b1RXRklWbmhTYmxaaFpWVktWbGxWTVZCaFIwWlNVRlF3UFE9PQ=="))))))));
			this.cStatus.MinimumWidth = 200;
			this.cStatus.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09"))))))));
			this.ctmsAcc.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chọnLiveToolStripMenuItem,
				this.bỏChọnTấtCảToolStripMenuItem,
				this.copyToolStripMenuItem,
				this.mởTrìnhDuyệtToolStripMenuItem,
				this.xóaTàiKhoảnToolStripMenuItem,
				this.checkCookieToolStripMenuItem,
				this.câpNhâtThôngTinCaNhânToolStripMenuItem,
				this.cậpNhậtDữLiệuToolStripMenuItem,
				this.chuyểnThưMụcToolStripMenuItem,
				this.chứcNăngToolStripMenuItem1,
				this.profileToolStripMenuItem,
				this.backupToolStripMenuItem,
				this.giaiCheckpointToolStripMenuItem,
				this.tảiLạiDanhSáchToolStripMenuItem
			});
			this.ctmsAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFST1UyUkhUWGRTYlhCYVpIb3dPUT09"))))))));
			this.ctmsAcc.Size = new global::System.Drawing.Size(175, 312);
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
			this.chọnLiveToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.chọnLiveToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEJOV0ZVOQ=="))))))));
			this.tấtCảToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXVRbGxWYTFFd1dXNUdjVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtJeFZURmplR0ZHYjNsV1ZEQTk=")))))))));
			this.tấtCảToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXVRbGxWYTFFd1dXNUdjVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.tấtCảToolStripMenuItem.Size = new global::System.Drawing.Size(128, 22);
			this.tấtCảToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNXVRbGxWVjJSYVN6QmpNbUl6WXpsUVVUMDk="))))))));
			this.tấtCảToolStripMenuItem.Click += new global::System.EventHandler(this.TấtCảToolStripMenuItem_Click);
			this.liveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a2MwMXNjRmRWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVWNGNtSklVbHBXTWxKeg==")))))))));
			this.liveToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a2MwMXNjRmRWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVFOVBRPT0="))))))));
			this.liveToolStripMenuItem.Size = new global::System.Drawing.Size(128, 22);
			this.liveToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZoT1VFMUhSbFJTUlZaeVZqRmFNUT09"))))))));
			this.liveToolStripMenuItem.Click += new global::System.EventHandler(this.LiveToolStripMenuItem_Click);
			this.tinhTrangToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2MyUlhSa2RWYm14YVZucFdkVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtJeFZURmplR0ZHYjNsV1ZEQTk=")))))))));
			this.tinhTrangToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2MyUlhSa2RWYm14YVZucFdkVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.tinhTrangToolStripMenuItem.Size = new global::System.Drawing.Size(128, 22);
			this.tinhTrangToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2RWUlhaRWhPVnpsS1UwWktOVmRYVGpWaGJVcDBXWG93UFE9PQ=="))))))));
			this.trạngTháiToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb1RXRklWbmhTYmxaaFRWWktkbVI2V2tkalJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMlJXVGxoTlYyaGhUV3hWT1E9PQ==")))))))));
			this.trạngTháiToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb1RXRklWbmhTYmxaaFRWWktkbVI2V2tkalJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.trạngTháiToolStripMenuItem.Size = new global::System.Drawing.Size(128, 22);
			this.trạngTháiToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10b1RXRklWbmhTYmxaaFpWVkpkMWxWTVZCaFIwWlNVRlF3UFE9PQ=="))))))));
			this.trạngTháiToolStripMenuItem.Click += new global::System.EventHandler(this.trạngTháiToolStripMenuItem_Click);
			this.bỏChọnTấtCảToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFoV1NFNHliM2RVYlRnd1dXNVdUMWx0ZUZWaFNGWjRWbXBDVWtzd1l6Smlla1pUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUZSSGRITmtSbXhZV2tkM1BRPT0=")))))))));
			this.bỏChọnTấtCảToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFoV1NFNHliM2RVYlRnd1dXNVdUMWx0ZUZWaFNGWjRWbXBDVWtzd1l6Smlla1pUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUE9PQ=="))))))));
			this.bỏChọnTấtCảToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.bỏChọnTấtCảToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZoV1NFNHljRFZSYlhCb1ZEQmpNMkZzWXpCYU1sSlFVbnBhZDFkR1JtNVhVM1JJVG0wNU0xQlVNRDA9"))))))));
			this.bỏChọnTấtCảToolStripMenuItem.Click += new global::System.EventHandler(this.BỏChọnTấtCảToolStripMenuItem_Click);
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
			this.copyToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
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
			this.maBaoMât6SôToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa1NWUlhaRFZSYld4YVdUTnNTMWx1YkVOa1NHTXlWRVV4ZGsweFJtNVViV3hEWlc1ak0xWkZNVzVWTUVsM1RrZEtNV05yYkVWVGEyUlNWVlF3T1E9PQ=="))))))));
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
			this.đinhDangKhacToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtST1UySXhjRmxUV0ZaTllWUlJPUT09"))))))));
			this.đinhDangKhacToolStripMenuItem.Click += new global::System.EventHandler(this.đinhDangKhacToolStripMenuItem_Click);
			this.mởTrìnhDuyệtToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.mởLuônToolStripMenuItem,
				this.càiĐặtCấuHìnhMởToolStripMenuItem
			});
			this.mởTrìnhDuyệtToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNHlOSGhWYm13elRtNW9NVmxWVmxOTlYxWnNVbnBrYjAweFNsWlpha2sxWXpGVmVsVnViR2hYUlVwUFYyeGpNVTFXVGxsVmJYaHBWWHBXUzFsc1pFZGliSEJTVUZRd1BRPT0=")))))))));
			this.mởTrìnhDuyệtToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNHlOSGhWYm13elRtNW9NVmxWVmxOTlYxWnNVbnBrYjAweFNsWlpha2sxWXpGVmVsVnViR2hYUlVwUFYyeGpNVTFXVGxsVmJYaHBWVlF3T1E9PQ=="))))))));
			this.mởTrìnhDuyệtToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.mởTrìnhDuyệtToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkV1NFNHlOVFZSYWtKcVl6QTVlbGx0TVc1YU1YQkpWbXBWTUZsdVZrbGFSVVU1VUZFOVBRPT0="))))))));
			this.mởLuônToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNHlOSGRsUkVZelRqRktNVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.mởLuônToolStripMenuItem.Size = new global::System.Drawing.Size(181, 22);
			this.mởLuônToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2RXRklWbmxQV0ZaS1VqSndSV0l3WXpGaU1HeElUVEpvTVU1VVp6az0="))))))));
			this.mởLuônToolStripMenuItem.Click += new global::System.EventHandler(this.mởLuônToolStripMenuItem_Click);
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSb1VGb3lSbXBWTVVVd1dXNUZlbHBGVmxGaFNGWjRWbXBHVkZSVk9YcFpiVEZ2VkdwU2FXUlhXbGRTZW13eVdXdGFUMDFIVG5SaVNHUlZWakZhTVZwR1ZuTk5SbkJZVFVRd1BRPT0="))))))));
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Size = new global::System.Drawing.Size(181, 22);
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSb1VGb3lSbFJTUlZaeVdsVmpNbVJFVGxKYU1XdHlVbnBhZDFkR1ZtNVpWVEZRWXpKS2RGb3laR2xhVldNelltNWpPVkJSUFQwPQ=="))))))));
			this.càiĐặtCấuHìnhMởToolStripMenuItem.Click += new global::System.EventHandler(this.mởTrìnhDuyệtToolStripMenuItem_Click);
			this.xóaTàiKhoảnToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRmRXUlZKMlVqSjRUVmxWWTNaaFNGWjRWRzVXVjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlNGWlVWbnBHYjFkcVNsWlFVVDA5")))))))));
			this.xóaTàiKhoảnToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRmRXUlZKMlVqSjRUVmxWWTNaaFNGWjRWRzVXVjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlJEQTk="))))))));
			this.xóaTàiKhoảnToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.xóaTàiKhoảnToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHVnNiRlJSYWtKYVdUTnNRbGxXVGtOamJVWklUMWRvTmxOWGVERT0="))))))));
			this.xóaTàiKhoảnToolStripMenuItem.Click += new global::System.EventHandler(this.giưLaiProfileToolStripMenuItem_Click);
			this.checkCookieToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.kiểmTraWallToolStripMenuItem,
				this.checkInfoUIDToolStripMenuItem,
				this.kiểmTraTokenToolStripMenuItem,
				this.kiểmTraCookieToolStripMenuItem,
				this.checkAvatarToolStripMenuItem,
				this.checkProfileToolStripMenuItem1,
				this.checkBackupToolStripMenuItem1,
				this.kiểmTraMailpassMailToolStripMenuItem,
				this.checkProxyToolStripMenuItem
			});
			this.checkCookieToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlZKcFRXcHNlVmxXWkZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeE5NVk50U2xoU2JUVmhWVlF3T1E9PQ==")))))))));
			this.checkCookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlZKcFRXcHNlVmxXWkZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.checkCookieToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.checkCookieToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2RXRklWVEJVYmxKS1UwWktOVmRXVGtOTlNHTXlVVzVDU2xJelVuWlphWFJJVG0wNGVVNUVNRDA9"))))))));
			this.checkCookieToolStripMenuItem.Click += new global::System.EventHandler(this.checkCookieToolStripMenuItem_Click);
			this.kiểmTraWallToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVpxU2tkak1rcEhWVzVhYVUxdWFGVmFSV2hMWTBkT1JrMVhlR2xpYkZwTFdrVmtWMlJCUFQwPQ=="))))))));
			this.kiểmTraWallToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.kiểmTraWallToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SWFRXdGFlbGxyUlRsUVVUMDk="))))))));
			this.kiểmTraWallToolStripMenuItem.ToolTipText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNiMlJZUm10a1ZXeElWa1ZTTVZaNlZuVlRWV2hUWkcxRmVWWnVWVDA9"))))))));
			this.kiểmTraWallToolStripMenuItem.Click += new global::System.EventHandler(this.KiểmTraWallToolStripMenuItem_Click);
			this.checkInfoUIDToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlhCcFlsWndNbFpzVm5OU1ZscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.checkInfoUIDToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.checkInfoUIDToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZucFdkRmx1YkVOV2JFNVdWVlF3UFE9PQ=="))))))));
			this.checkInfoUIDToolStripMenuItem.ToolTipText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNiMlJZUm10a1ZXeElWa1ZTTVZaNlZuVlRWV2hUWkcxRmVWWnVWa1ZWV0VKRlpIcGFUVlJYT0hwUlYyUnBZbGR3UldJelRqVmhiVkpFVVdwQ2FGUlZPSGRaYlRGcVdqSlNTR0pJVmxCaFZVcEtXV3BvTldGcmJFbFdSVko0WWxSU2VsTlZWbXRqUkZKcFpGZEtObE5WV25kVFZXaFRZMGh3U2xKdVZtaFJNMlJ1Vm5wQ1YyUkdiRmhpU0U1WlZUTmtibFo2UWt0aFNIQk1WRzVXU2xJd2NITmxhMnhEV2tWNFJGRnRTbFZpVjJneVpXdHNSMlJHYUZSa01tUllUVVJXZFZkWFRqVlJWMVpVVVc1d2FGWjZWblpYUmtVNVVGRTlQUT09"))))))));
			this.checkInfoUIDToolStripMenuItem.Click += new global::System.EventHandler(this.checkInfoUIDToolStripMenuItem_Click);
			this.kiểmTraTokenToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVpyWXpWamJIQllUbFpXYVUxcWJIcFdWRTVUWlZkR1dWRnJOV0ZXZWxWNFZURm9VMkpIU2xKUVZEQTk="))))))));
			this.kiểmTraTokenToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.kiểmTraTokenToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SWFVucHNlVmRzWXpCUVVUMDk="))))))));
			this.kiểmTraTokenToolStripMenuItem.Click += new global::System.EventHandler(this.KiểmTraTokenToolStripMenuItem_Click);
			this.kiểmTraCookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVZVU1RWa2JVVjVZa2Q0VjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlJEQTk="))))))));
			this.kiểmTraCookieToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.kiểmTraCookieToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SU1RXcHNNbGxVU25OaVFUMDk="))))))));
			this.kiểmTraCookieToolStripMenuItem.Click += new global::System.EventHandler(this.KiểmTraCookieToolStripMenuItem_Click);
			this.checkAvatarToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlVwcllsVlpkMWRXYUV0V1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.checkAvatarToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.checkAvatarToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SU1YwWndiMXBGWkVkbFVUMDk="))))))));
			this.checkAvatarToolStripMenuItem.Click += new global::System.EventHandler(this.checkAvatarToolStripMenuItem_Click);
			this.checkProfileToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUmtacVlsUnNkRmxXWkRSaVJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMlZCUFQwPQ=="))))))));
			this.checkProfileToolStripMenuItem1.Size = new global::System.Drawing.Size(153, 22);
			this.checkProfileToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SV1UwVndNbGR0TVhOak1YQlNVRlF3UFE9PQ=="))))))));
			this.checkProfileToolStripMenuItem1.Click += new global::System.EventHandler(this.checkProfileToolStripMenuItem_Click);
			this.checkBackupToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlU1YVZqQTFlVnBHYUVOV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeFNSbEJSUFQwPQ=="))))))));
			this.checkBackupToolStripMenuItem1.Size = new global::System.Drawing.Size(153, 22);
			this.checkBackupToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SU1lsVmFjVmxVVGxka2R6MDk="))))))));
			this.checkBackupToolStripMenuItem1.Click += new global::System.EventHandler(this.checkBackupToolStripMenuItem_Click);
			this.kiểmTraMailpassMailToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVpHWkVkalIwcEpVVzFvYWswd05VOVhWbVJ6WXpGYVNFOVlXbWxTYXpSM1dUSXhjMlF4VWxoV2JsWnJWbGQzZDFkc1kzZFFVVDA5"))))))));
			this.kiểmTraMailpassMailToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.kiểmTraMailpassMailToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa1IyTkhTa2xsU0dSYVYwVTFObE5WVlhoaFIwWllaSG93UFE9PQ=="))))))));
			this.kiểmTraMailpassMailToolStripMenuItem.Click += new global::System.EventHandler(this.kiểmTraMailpassMailToolStripMenuItem_Click);
			this.checkProxyToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUmtacVlsUnJNRnBXV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvdw=="))))))));
			this.checkProxyToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.checkProxyToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SV1UwVndNbHBWYUhKUVVUMDk="))))))));
			this.checkProxyToolStripMenuItem.Click += new global::System.EventHandler(this.checkProxyToolStripMenuItem_Click);
			this.câpNhâtThôngTinCaNhânToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.sưDungTokenTrungGianToolStripMenuItem,
				this.sửDụngCookieTrungGianToolStripMenuItem
			});
			this.câpNhâtThôngTinCaNhânToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSb1VHRlhUa1pPVnprelRtdHZkMVpyWkhGU1NGSklUbGMxVjFJeWVERlZWRXBIVkRKR1RsUXliR2xpUmtveVdXcEtORlpIVWtsVGJrSnFVbFJHYzFsdE5WZFRiVkpJVm01U1RXRXllREJYVm1ScllrRTlQUT09")))))))));
			this.câpNhâtThôngTinCaNhânToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSb1VHRlhUa1pPVnprelRtdHZkMVpyWkhGU1NGSklUbGMxVjFJeWVERlZWRXBIVkRKR1RsUXliR2xpUmtveVdXcEtORlpIVWtsVGJrSnFVbFJHYzFsdE5WZFRiVkpJVm01UlBRPT0="))))))));
			this.câpNhâtThôngTinCaNhânToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.câpNhâtThôngTinCaNhânToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSb1VHRlljRXhVYm1SS1VucFdkbVI2V2sxVVZ6aDZWVmRrYTFJeWNFVmtSV014WW10c1NWVnVRbWxhZWpBNQ=="))))))));
			this.sưDungTokenTrungGianToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1hwb2FHUXhTa2xXYmxaaFRWWktNbGxVU2xka1ZscEpVMnBHYVdKWFVrbFpWbVJIWkZaYVNFOVlXbWxTYXpSM1dUSXhjMlF4VWxoV2JsWnJWbGQzZDFkc1kzZFFVVDA5"))))))));
			this.sưDungTokenTrungGianToolStripMenuItem.Size = new global::System.Drawing.Size(216, 22);
			this.sưDungTokenTrungGianToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb2FHUXpjRXBoTW1SaFUwWm9UbUo2U1RGaWEyeEhWVzVhYUUxc1dqRlRWV2hUWlZkU1dFNVhOVXBTTWxKM1YxWmpNRkJSUFQwPQ=="))))))));
			this.sưDungTokenTrungGianToolStripMenuItem.ToolTipText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSb1VHRlljRXhVYm1SS1VucFdkbVI2V2sxVVZ6aDZWVmRrYTFJeWNFVmtSV014WW10c1NWVnVRbWxoYlRsdVZUQmpkbFJYT1RWUmFrSXpUbTVDTVZSRlRrTlRSMFpzVW5wa2RFOUliRU5aVms1RFRVZEdhbVZWU21saVYyUjZVMVZhTUZKdFNsaFNia0pwVW1wQ2VsTlZXakJSTVd4cVpWZHdhV0ZWU25CWGJVNDFVVlpvVkdReVpGaE5SRloyV1dwb05WRnRTbGROU0U1S1VtNVNVRmRxU2tsVVYyUkpZVEprYWsxdGVERlpWVmwzVUZFOVBRPT0="))))))));
			this.sưDungTokenTrungGianToolStripMenuItem.Click += new global::System.EventHandler(this.sưDungTokenTrungGianToolStripMenuItem_Click);
			this.sửDụngCookieTrungGianToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1hsMFNFNHpTbFpXUjJneFRteGFNVmRxUWs5a2JVbDVaRWhDWVZac1NqVmFSbU14WW14SmVXSkhhR2xpUmtveVdXcEtORlpIVWtsVGJrSnFVbFJHYzFsdE5WZFRiVkpJVm01UlBRPT0="))))))));
			this.sửDụngCookieTrungGianToolStripMenuItem.Size = new global::System.Drawing.Size(216, 22);
			this.sửDụngCookieTrungGianToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNHpTbFJSYlhNd1dXNVdjMWx0TVdwYU1VVjVUMWhhYUUxdGVITlRWV2hUWlZkU1dFNVhOVXBTTWxKM1YxWmpNRkJSUFQwPQ=="))))))));
			this.sửDụngCookieTrungGianToolStripMenuItem.Click += new global::System.EventHandler(this.sửDụngCookieTrungGianToolStripMenuItem_Click);
			this.cậpNhậtDữLiệuToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.cậpToolStripMenuItem,
				this.mậtKhẩuToolStripMenuItem1,
				this.tokenToolStripMenuItem2,
				this.cookieToolStripMenuItem3,
				this.mailKhôiPhụcToolStripMenuItem,
				this.passMailToolStripMenuItem,
				this.mã2FAToolStripMenuItem,
				this.useragentToolStripMenuItem,
				this.proxyToolStripMenuItem,
				this.ghiChuToolStripMenuItem,
				this.ngàySinhToolStripMenuItem
			});
			this.cậpNhậtDữLiệuToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFOMFNFNXVTbGxSYXpsb1ZEQmpNbU5zYUZOU1ZGSnBaRmhhVlZJeU5XOWtWRkpyVFZaYVNFOVlXbWxTYXpSM1dUSXhjMlF4VWxoV2JsWnJWbGQzZDFkc1kzZGtWazVZVFZkb1lVMXNWVGs9")))))))));
			this.cậpNhậtDữLiệuToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFOMFNFNXVTbGxSYXpsb1ZEQmpNbU5zYUZOU1ZGSnBaRmhhVlZJeU5XOWtWRkpyVFZaYVNFOVlXbWxTYXpSM1dUSXhjMlF4VWxoV2JsWnJWbGQzZDFkc1kzZFFVVDA5"))))))));
			this.cậpNhậtDữLiệuToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.cậpNhậtDữLiệuToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeElWa2RvTVU1cWFHNVphMlIxWVVoVk1GcEVSVDA9"))))))));
			this.cậpToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_multiline_text_32px;
			this.cậpToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFOMFNFNXVTbGxSYkZacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1VsQlVNRDA9"))))))));
			this.cậpToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.cậpToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeElZV3RTZGxKNlZuVlRWV1EwWkdwU2FXTlhhR3RSTUVsM1dWVmtWMlJyYkVkV2EzQlRVVlF3T1E9PQ=="))))))));
			this.cậpToolStripMenuItem.Click += new global::System.EventHandler(this.cậpToolStripMenuItem_Click);
			this.mậtKhẩuToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNXVTbGxWYTNob1ZEQmpNbU5XYUZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeFNSbVJXVGxoTlYyaGhUV3hWT1E9PQ==")))))))));
			this.mậtKhẩuToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNXVTbGxWYTNob1ZEQmpNbU5XYUZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeFNSbEJSUFQwPQ=="))))))));
			this.mậtKhẩuToolStripMenuItem1.Size = new global::System.Drawing.Size(224, 22);
			this.mậtKhẩuToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWa1IyVnRUWHBhU0ZwcVlsWkZPUT09"))))))));
			this.mậtKhẩuToolStripMenuItem1.Click += new global::System.EventHandler(this.mậtKhẩuToolStripMenuItem1_Click);
			this.tokenToolStripMenuItem2.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tựĐộngLấyToolStripMenuItem1,
				this.nhậpDữLiệuToolStripMenuItem2
			});
			this.tokenToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVmxacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1ZWTllWbFJXZWtadlYycEtWbEJSUFQwPQ==")))))))));
			this.tokenToolStripMenuItem2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVmxacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1ZWTlVNRDA9"))))))));
			this.tokenToolStripMenuItem2.Size = new global::System.Drawing.Size(224, 22);
			this.tokenToolStripMenuItem2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10ak5XTnNjRmhPUkRBOQ=="))))))));
			this.tựĐộngLấyToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tokenEAAAAZToolStripMenuItem,
				this.tokenBussinessToolStripMenuItem
			});
			this.tựĐộngLấyToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNHpUbXBWTVVVd1dXNVdZVmx0TVd0VVZGSnBZMWQ0YkZac1NqSlpha28wVmtkU1NWTnVRbXBTVkVaeldXMDFWMU50VWtoV2JsSk9WVlF3T1E9PQ=="))))))));
			this.tựĐộngLấyToolStripMenuItem1.Size = new global::System.Drawing.Size(142, 22);
			this.tựĐộngLấyToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNHpUbFJTUlZaeVdsVmpNMkpXWXpGaWEyeElaVzFvTVdOV1dURT0="))))))));
			this.tokenEAAAAZToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVlZwU1ZsVmFRMVZXV25kV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.tokenEAAAAZToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.tokenEAAAAZToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10ak5XTnNjRmhPUjJSVFZsVmFRMVZXVmtkWlVUMDk="))))))));
			this.tokenEAAAAZToolStripMenuItem.ToolTipText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNHpTbFJSYlhNd1dXNVdjMWx0TVdwYU1XdDVUMWhhYUUxdGVITT0="))))))));
			this.tokenEAAAAZToolStripMenuItem.Click += new global::System.EventHandler(this.tokenEAAAAZToolStripMenuItem_Click);
			this.tokenBussinessToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVlU1clYwVTFObGxXWXpGaVIwMTZWR3hXYVUxcWJIcFdWRTVUWlZkR1dWRnJOV0ZXZWxWNFZURm9VMkpIU2xKUVZEQTk="))))))));
			this.tokenBussinessToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
			this.tokenBussinessToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10ak5XTnNjRmhPUjJSVFZsVmFRMVZ1WXpsUVVUMDk="))))))));
			this.tokenBussinessToolStripMenuItem.ToolTipText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNHpTbFJSYlhNd1dXNVdjMWx0TVdwYU1XdDVUMWhhYUUxdGVITT0="))))))));
			this.tokenBussinessToolStripMenuItem.Click += new global::System.EventHandler(this.TokenBussinessToolStripMenuItem_Click);
			this.nhậpDữLiệuToolStripMenuItem2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cweGNXRklWbmhOV0dSVFZEQmpNMk5xUWpSalJGSnBaRlZvYTFac1NqSlpha28wVmtkU1NWTnVRbXBTVkVaeldXMDFWMU50VWtoV2JsSk9Xbm93T1E9PQ=="))))))));
			this.nhậpDữLiệuToolStripMenuItem2.Size = new global::System.Drawing.Size(142, 22);
			this.nhậpDữLiệuToolStripMenuItem2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VqRlNiMlJVV1RSYU1rcElZbTFvTVU1SFVYZz0="))))))));
			this.nhậpDữLiệuToolStripMenuItem2.Click += new global::System.EventHandler(this.NhậpDữLiệuToolStripMenuItem2_Click);
			this.cookieToolStripMenuItem3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUljRTFoTW5nd1YxWmthMkpCUFQwPQ==")))))))));
			this.cookieToolStripMenuItem3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUliejA9"))))))));
			this.cookieToolStripMenuItem3.Size = new global::System.Drawing.Size(224, 22);
			this.cookieToolStripMenuItem3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNjOQ=="))))))));
			this.cookieToolStripMenuItem3.Click += new global::System.EventHandler(this.NhậpDữLiệuToolStripMenuItem1_Click);
			this.mailKhôiPhụcToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1IyTkhTa1prUnprelRqRktkMVpWWkhGaFNGVXlWbTF3VjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlNGWlVWbnBHYjFkcVNsWlFVVDA5")))))))));
			this.mailKhôiPhụcToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1IyTkhTa1prUnprelRqRktkMVpWWkhGaFNGVXlWbTF3VjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlJEQTk="))))))));
			this.mailKhôiPhụcToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.mailKhôiPhụcToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld4amVHRkhSbGhsUkdoV1VqQmFObGt6YkVOU2JVcFlVbTVDYVZGVU1Eaz0="))))))));
			this.mailKhôiPhụcToolStripMenuItem.Click += new global::System.EventHandler(this.mailKhôiPhụcToolStripMenuItem_Click);
			this.passMailToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_1password;
			this.passMailToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyVnRUWGROVjJob1ZqTm9WbGxxU1RWak1WVjZWVzVzYUZkRlNrOVhiR014VFZaT1dWVnRlR2xWVkRBNQ=="))))))));
			this.passMailToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.passMailToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWa1IyVnRUalZSYXpWYVZqSjRlZz09"))))))));
			this.passMailToolStripMenuItem.Click += new global::System.EventHandler(this.passMailToolStripMenuItem_Click);
			this.mã2FAToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxT1VHRnJNWEpYYTBwWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUlWbFJXZWtadlYycEtWbEJSUFQwPQ==")))))))));
			this.mã2FAToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxT1VHRnJNWEpYYTBwWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUVNRDA9"))))))));
			this.mã2FAToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.mã2FAToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkT1VHRnJiRVZUYTJSU1ZWUXdPUT09"))))))));
			this.mã2FAToolStripMenuItem.Click += new global::System.EventHandler(this.mã2FAToolStripMenuItem_Click);
			this.useragentToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tab1QySkhUblJTYlRWaFZucFZkMVpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtJeFZURmplR0ZHYjNsV1ZEQTk=")))))))));
			this.useragentToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tab1QySkhUblJTYlRWaFZucFZkMVpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.useragentToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.useragentToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14b1QySkhUblJTYlRWaFZucFZkdz09"))))))));
			this.useragentToolStripMenuItem.Click += new global::System.EventHandler(this.useragentToolStripMenuItem_Click);
			this.proxyToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCb1MyUnRWa2xpUmxacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1ZFNVZjR2xXTUZwMVYyeEZPVkJSUFQwPQ==")))))))));
			this.proxyToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCb1MyUnRWa2xpUmxacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1VsQlVNRDA9"))))))));
			this.proxyToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.proxyToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWb1MyUnRWa2xoZWpBOQ=="))))))));
			this.proxyToolStripMenuItem.Click += new global::System.EventHandler(this.proxyToolStripMenuItem_Click);
			this.ghiChuToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_note_48px;
			this.ghiChuToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2IyTkdSWGxoUkVaWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUVNRDA9"))))))));
			this.ghiChuToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.ghiChuToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldwS2IyTkZiRWhVYlRscldUTnNRdz09"))))))));
			this.ghiChuToolStripMenuItem.Click += new global::System.EventHandler(this.ghiChuToolStripMenuItem_Click);
			this.ngàySinhToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_calendar_5_48px;
			this.ngàySinhToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cweGJWSkhPVWxpUmxKb1ZucFdkbFpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.ngàySinhToolStripMenuItem.Size = new global::System.Drawing.Size(224, 22);
			this.ngàySinhToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGJWSkhPVWxoTW1ScVRXMTRNVmxWUlRsUVVUMDk="))))))));
			this.ngàySinhToolStripMenuItem.Click += new global::System.EventHandler(this.ngàySinhToolStripMenuItem_Click);
			this.chuyểnThưMụcToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IwMVhWbXhTZW1SdVRXcFdWbGxWTVdoa01WSnNVbnBrZDFZd05WWlpha2sxWXpGVmVsVnViR2hYUlVwUFYyeGpNVTFXVGxsVmJYaHBWWHBXUzFsc1pFZGliSEJTVUZRd1BRPT0=")))))))));
			this.chuyểnThưMụcToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IwMVhWbXhTZW1SdVRXcFdWbGxWTVdoa01WSnNVbnBrZDFZd05WWlpha2sxWXpGVmVsVnViR2hYUlVwUFYyeGpNVTFXVGxsVmJYaHBWVlF3T1E9PQ=="))))))));
			this.chuyểnThưMụcToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.chuyểnThưMụcToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IwMVhWbXhTZW1SdVRXcFNibHBGWkhGU00wNUVVVzVSTUZsdVZuTlhXR001VUZFOVBRPT0="))))))));
			this.chứcNăngToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.locTrungToolStripMenuItem,
				this.taoShortcutChromeToolStripMenuItem,
				this.tảiXuốngAvatarToolStripMenuItem,
				this.loginHotmailToolStripMenuItem,
				this.loginYandexToolStripMenuItem,
				this.toolStripMenuItem1,
				this.loginGmailToolStripMenuItem,
				this.lToolStripMenuItem,
				this.mởFormQuảnLýTinNhắnToolStripMenuItem,
				this.khôiPhụcMậtKhẩuToolStripMenuItem,
				this.đổiPassHotmailToolStripMenuItem
			});
			this.chứcNăngToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2NXRklWVEppUjNCVll6Rk9SVmx0TVd0V1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeFNSbVJXVGxoTlYyaGhUV3hWT1E9PQ==")))))))));
			this.chứcNăngToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2NXRklWVEppUjNCVll6Rk9SVmx0TVd0V1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeFNSbEJSUFQwPQ=="))))))));
			this.chứcNăngToolStripMenuItem1.Size = new global::System.Drawing.Size(174, 22);
			this.chứcNăngToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEppUjNCS1VucGtSbHA2U1RGaVp6MDk="))))))));
			this.locTrungToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0ak5XRnNXa2xUYWtacFlsZFNWbGxxU1RWak1WVjZWVzVzYUZkRlNrOVhiR014VFZaT1dWVnRlR2xWZWxaTFdXeGtSMkpzY0ZKUVZEQTk=")))))))));
			this.locTrungToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0ak5XRnNXa2xUYWtacFlsZFNWbGxxU1RWak1WVjZWVzVzYUZkRlNrOVhiR014VFZaT1dWVnRlR2xWVkRBNQ=="))))))));
			this.locTrungToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.locTrungToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWamRsUlhPSGxVVjJSclUwVnZlR1ZyYkVOa1ZuQTFVV3BDV2xremJFSlpWazVEWTIxR1NFOVhhRFpUVjNneA=="))))))));
			this.locTrungToolStripMenuItem.Click += new global::System.EventHandler(this.locTrungToolStripMenuItem_Click);
			this.taoShortcutChromeToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_chrome_25px;
			this.taoShortcutChromeToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa1IyUnNWWGxoU0ZwcVlteEtjVnBHYUZOU1IwWkpVMjVhYVZZeFdsWlpha2sxWXpGVmVsVnViR2hYUlVwUFYyeGpNVTFXVGxsVmJYaHBWVlF3T1E9PQ=="))))))));
			this.taoShortcutChromeToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.taoShortcutChromeToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1NWUlhPSGxQUjJSV1RXMW9NbGt5TlZOaGJWSlpWVmRrVWsxdGFEVlpha2w0WWtFOVBRPT0="))))))));
			this.taoShortcutChromeToolStripMenuItem.Click += new global::System.EventHandler(this.taoShortcutChromeToolStripMenuItem_Click);
			this.tảiXuốngAvatarToolStripMenuItem.Image = global::maxcare.Properties.Resources.client_management_25px;
			this.tảiXuốngAvatarToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXRPSGxpUm14cldsVmpNMkV4WXpGaWJFWlpWMjFvYTFJd1dqVldhMk0xWkcxS1IxUnFRbXBpVjNnelZrWmtWMlJYVWxaaVJFSmhWbnBCT1E9PQ=="))))))));
			this.tảiXuốngAvatarToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.tảiXuốngAvatarToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNXRPSGxoTW1Sc1UwWm9iMlJVVmtka1ZuQTFVVzFvYTJKVldYZFhWbWhLVUZFOVBRPT0="))))))));
			this.tảiXuốngAvatarToolStripMenuItem.Click += new global::System.EventHandler(this.tảiXuốngAvatarToolStripMenuItem_Click);
			this.loginHotmailToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_microsoft_outlook_48px;
			this.loginHotmailToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0ak5XSnRSbGhPVld4cFRURktNRmRXWkhOak1WcElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.loginHotmailToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.loginHotmailToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWak5XSnRSbGhPUjJSVVVucHJkMWxzWkVkalIwcENVRlF3UFE9PQ=="))))))));
			this.loginHotmailToolStripMenuItem.Click += new global::System.EventHandler(this.loginHotmailToolStripMenuItem_Click);
			this.loginYandexToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_yandex_international_32px;
			this.loginYandexToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0ak5XSnRSbGhPVm5CYVZucFdjbGRzYUc5V1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.loginYandexToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.loginYandexToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWak5XSnRSbGhPUjJSWVZqQmFNVmRyWkZkT1FUMDk="))))))));
			this.loginYandexToolStripMenuItem.Click += new global::System.EventHandler(this.loginYandexToolStripMenuItem_Click);
			this.toolStripMenuItem1.Image = global::maxcare.Properties.Resources.icons8_gmail;
			this.toolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XUnRTa2RVYWtKcVlsZDRNMVpHWkZka1YxSldZa1JDWVZaNlFqUT0="))))))));
			this.toolStripMenuItem1.Size = new global::System.Drawing.Size(215, 22);
			this.toolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWak5XSnRSbGhPUjJSVFRXcEdiMWxXWkROUVVUMDk="))))))));
			this.toolStripMenuItem1.Click += new global::System.EventHandler(this.toolStripMenuItem1_Click);
			this.loginGmailToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_gmail;
			this.loginGmailToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0ak5XSnRSbGhPVldocFZqQmFkMWxyV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvdw=="))))))));
			this.loginGmailToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.loginGmailToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWak5XSnRSbGhPUjJSVFRXcEdiMWxXWkROYU1IUkdWa1ZTTVZaNlZuVlRWVnBEWlZkSmVWZHVRbWxTTVZaMw=="))))))));
			this.loginGmailToolStripMenuItem.Click += new global::System.EventHandler(this.loginGmailToolStripMenuItem_Click);
			this.lToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_mail_filter_24px1;
			this.lToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0YVUyUnRTWGxsUmxKclUwVndkMWt3VlhoaVIwcDFWbXR3YTFJeFdqQT0="))))))));
			this.lToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.lToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVNVNFNHljRmhVVjJSaFVqQmFNVmxWVGtObGJtTXlVbTF3YUZFd1NYZFpWV1JYWkd0c1IxWnJjRk5SVkRBNQ=="))))))));
			this.lToolStripMenuItem.Click += new global::System.EventHandler(this.lToolStripMenuItem_Click);
			this.mởFormQuảnLýTinNhắnToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_group_message;
			this.mởFormQuảnLýTinNhắnToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNHlOSGRYYmxwcVlsUkdVMXBIVmtoT2JUaDVUbFV4TTA1NlJsWlpWbU14VkRKR1VGSjZXbmxOYWxaV1dXcEpOV014VlhwVmJteG9WMFZLVDFkc1l6Rk5WazVaVlcxNGFWVlVNRGs9"))))))));
			this.mởFormQuảnLýTinNhắnToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.mởFormQuảnLýTinNhắnToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkV1NFNHlOVFZSYlRGcFRUQndNRk5WYUVkTlZGSnBZMWR3YVdGVlNucGtlbU4zV2pKU1NHSklWa3BTZWxaMlRrZEtlR1J0U201UVZEQTk="))))))));
			this.mởFormQuảnLýTinNhắnToolStripMenuItem.Click += new global::System.EventHandler(this.mởFormQuảnLýTinNhắnToolStripMenuItem_Click);
			this.khôiPhụcMậtKhẩuToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_reset_1;
			this.khôiPhụcMậtKhẩuToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2NWSklVa2hpUmtab1ZEQmpNMk5HWkU5VWFsSnBZMWhTYTFKWVVuWk9SMHA0WTBkU1YxVnVXbWxOYm1oVldrVm9TMk5IVGtaTlYzaHBZbXhhUzFwRlpGZGtRVDA5"))))))));
			this.khôiPhụcMậtKhẩuToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.khôiPhụcMậtKhẩuToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhwS2NWSklVa2hoTW1ScVVqSndiMlJVV2xkaGEyeElUVEpvTVdOVVJYZFRWV1F3WW5wU2FXTllRbXRWVkRBNQ=="))))))));
			this.khôiPhụcMậtKhẩuToolStripMenuItem.Click += new global::System.EventHandler(this.khôiPhụcMậtKhẩuToolStripMenuItem_Click);
			this.đổiPassHotmailToolStripMenuItem.Image = global::maxcare.Properties.Resources.password_25px;
			this.đổiPassHotmailToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NXRklWVEZXYmtKV1VqQmFObGw2UW05a2JWSklUVmRvYUZZemFGWlpha2sxWXpGVmVsVnViR2hYUlVwUFYyeGpNVTFXVGxsVmJYaHBWVlF3T1E9PQ=="))))))));
			this.đổiPassHotmailToolStripMenuItem.Size = new global::System.Drawing.Size(215, 22);
			this.đổiPassHotmailToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JXRklWVEZXYmtKS1UwVktiMWw2VGs1YU1rWklUMVJDYVZZd1duZFphMFU1VUZFOVBRPT0="))))))));
			this.đổiPassHotmailToolStripMenuItem.Click += new global::System.EventHandler(this.đổiPassHotmailToolStripMenuItem_Click);
			this.profileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tạoProfileToolStripMenuItem,
				this.checkProfileToolStripMenuItem,
				this.xóaProfileToolStripMenuItem,
				this.donDepProfileToolStripMenuItem,
				this.xóaCacheToolStripMenuItem,
				this.copyProfileToolStripMenuItem
			});
			this.profileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCb1MyUnNjSFJpU0U1aFZteEtNbGxxU2pSV1IxSkpVMjVDYWxKVVJuTlpiVFZYVTIxU1NGWnVVazFoTW5nd1YxWmthMkpCUFQwPQ==")))))))));
			this.profileToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCb1MyUnNjSFJpU0U1aFZteEtNbGxxU2pSV1IxSkpVMjVDYWxKVVJuTlpiVFZYVTIxU1NGWnVVVDA9"))))))));
			this.profileToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.profileToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWb1MyUnNjSFJpU0U1aFZUQktSVmxWYUV0a2JVcFlWbFF3UFE9PQ=="))))))));
			this.tạoProfileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.đăngNhâpBăngUidpassToolStripMenuItem,
				this.đăngNhâpBăngCookieToolStripMenuItem
			});
			this.tạoProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXRPVmhQVmtacVlsUnNkRmxXWkRSaVJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMlJXVGxoTlYyaGhUV3hWT1E9PQ==")))))))));
			this.tạoProfileToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXRPVmhQVmtacVlsUnNkRmxXWkRSaVJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.tạoProfileToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.tạoProfileToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNXRPVmhQUjJScVUwVndNbGR0TVhOak1YQlNVRlF3UFE9PQ=="))))))));
			this.tạoProfileToolStripMenuItem.Click += new global::System.EventHandler(this.TạoProfileToolStripMenuItem_Click);
			this.đăngNhâpBăngUidpassToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSlhZM2xPVnpWVllsZHdSV0l5TlVOUk0yaEtWRzVXWVUxV1duZFhhMmhEWVVkTmVsUnNWbWxOYW14NlZsUk9VMlZYUmxsUmF6VmhWbnBWZUZVeGFGTmlSMHBTVUZRd1BRPT0="))))))));
			this.đăngNhâpBăngUidpassToolStripMenuItem.Size = new global::System.Drawing.Size(233, 22);
			this.đăngNhâpBăngUidpassToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrV21NeFRrVmxhMnhEWkZad05WRnFSbWhXTVVrMFdUQmtSMlZ0VGpWUlZ6bGFaRlZqTTJGdWJISlFVVDA5"))))))));
			this.đăngNhâpBăngUidpassToolStripMenuItem.Visible = false;
			this.đăngNhâpBăngUidpassToolStripMenuItem.Click += new global::System.EventHandler(this.đăngNhâpBăngUidpassToolStripMenuItem_Click);
			this.đăngNhâpBăngCookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSlhZM2xPVnpWVllsZHdSV0l5TlVOUk0yaEtWRzVXWVUxRk5USlpha293WTBad1YxVnVXbWxOYm1oVldrVm9TMk5IVGtaTlYzaHBZbXhhUzFwRlpGZGtRVDA5"))))))));
			this.đăngNhâpBăngCookieToolStripMenuItem.Size = new global::System.Drawing.Size(233, 22);
			this.đăngNhâpBăngCookieToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrV21NeFRrVmxhMnhEWkZad05WRnRjR2xOYW14NVdWWmtWbG93ZEVoVVIyZ3hUa1JvZHc9PQ=="))))))));
			this.đăngNhâpBăngCookieToolStripMenuItem.Visible = false;
			this.đăngNhâpBăngCookieToolStripMenuItem.Click += new global::System.EventHandler(this.đăngNhâpBăngCookieToolStripMenuItem_Click);
			this.checkProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUmtacVlsUnNkRmxXWkRSaVJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMlJXVGxoTlYyaGhUV3hWT1E9PQ==")))))))));
			this.checkProfileToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUmtacVlsUnNkRmxXWkRSaVJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.checkProfileToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.checkProfileToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1ScVUwVndNbGR0TVhOak1YQlNVRlF3UFE9PQ=="))))))));
			this.checkProfileToolStripMenuItem.Click += new global::System.EventHandler(this.checkProfileToolStripMenuItem_Click);
			this.xóaProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRmRSYm14cFRXeHdkMWxyWkZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeE5NVk50U2xoU2JUVmhWVlF3T1E9PQ==")))))))));
			this.xóaProfileToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRmRSYm14cFRXeHdkMWxyWkZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.xóaProfileToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.xóaProfileToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHVnNiRlJSYm1ScVlsUnNkRmxXWkRSaVFUMDk="))))))));
			this.xóaProfileToolStripMenuItem.Click += new global::System.EventHandler(this.xóaProfileToolStripMenuItem_Click);
			this.donDepProfileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0ak5XUldTa2hXYm1SV1UwVndNbGR0TVhOak1YQlhWVzVhYVUxdWFGVmFSV2hMWTBkT1JrMVhlR2xpYkZwTFdrVmtWMlJGZUhKaVNGSmFWakpTY3c9PQ==")))))))));
			this.donDepProfileToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0ak5XUldTa2hXYm1SV1UwVndNbGR0TVhOak1YQlhWVzVhYVUxdWFGVmFSV2hMWTBkT1JrMVhlR2xpYkZwTFdrVmtWMlJCUFQwPQ=="))))))));
			this.donDepProfileToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.donDepProfileToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld0amRsUlhPSGxPUjJSaFVqRm9UbUo2VGtKYU1rNUpVMjVhWVdKWGVIcFhiRVU1VUZFOVBRPT0="))))))));
			this.donDepProfileToolStripMenuItem.Click += new global::System.EventHandler(this.donDepProfileToolStripMenuItem_Click);
			this.xóaCacheToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_delete_bin1;
			this.xóaCacheToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRlpVYldoYVRXMW9jMVpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.xóaCacheToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.xóaCacheToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHVnNiRlJSYTFKYVZqQTFkbGRzVGtOVlYwNTBUMWN4YUZZemFITT0="))))))));
			this.xóaCacheToolStripMenuItem.Click += new global::System.EventHandler(this.xóaCacheToolStripMenuItem_Click);
			this.copyProfileToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_documents_folder_50px;
			this.copyProfileToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUXlWbGRSYm14cFRXeHdkMWxyWkZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.copyProfileToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.copyProfileToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUXlWbFJSYkVacVlsUnNkRmxXWkRSaVFUMDk="))))))));
			this.copyProfileToolStripMenuItem.Click += new global::System.EventHandler(this.copyProfileToolStripMenuItem_Click_1);
			this.backupToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.backupCookieToolStripMenuItem,
				this.taoFileHTMLToolStripMenuItem,
				this.checkBackupToolStripMenuItem,
				this.mởThưMụcBackupToolStripMenuItem,
				this.backupToolStripMenuItem1,
				this.xóaDữLiệuBackupToolStripMenuItem,
				this.dọnDẹpBackupToolStripMenuItem
			});
			this.backupToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUlWbFJXZWtadlYycEtWbEJSUFQwPQ==")))))))));
			this.backupToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUVNRDA9"))))))));
			this.backupToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.backupToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZjeFIyRnRSWHBXYm1SS1VqRlNTR013TVRWU1JXeElaVWhDTTA1dVNrNWllazVXVUZFOVBRPT0="))))))));
			this.backupCookieToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SU1RXcHNNbGxVU25OaVJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMlJXVGxoTlYyaGhUV3hWT1E9PQ==")))))))));
			this.backupCookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SU1RXcHNNbGxVU25OaVJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.backupCookieToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.backupCookieToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2RWSklSbnBsVlVwcFlWVktkbGRYVGpWUlYwcDBXakprVW1KVlduRlpWRTVYWkhjOVBRPT0="))))))));
			this.backupCookieToolStripMenuItem.Click += new global::System.EventHandler(this.BackupCookieToolStripMenuItem_Click);
			this.taoFileHTMLToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa1IyUnNTblJpU0U1aFZsZG9WbFpHVmpSV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeE5NVk50U2xoU2JUVmhWVlF3T1E9PQ==")))))))));
			this.taoFileHTMLToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa1IyUnNTblJpU0U1aFZsZG9WbFpHVmpSV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.taoFileHTMLToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.taoFileHTMLToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1NWUlhPSGxQUjJSVFlsZDRlbGRzVGtOVFZscEdUVlV3UFE9PQ=="))))))));
			this.taoFileHTMLToolStripMenuItem.Click += new global::System.EventHandler(this.taoFileHTMLToolStripMenuItem_Click);
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
				this.fileTxtToolStripMenuItem,
				this.thưMụcToolStripMenuItem
			});
			this.backupToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUlhRTFoTW5nd1YxWmthMkpCUFQwPQ==")))))))));
			this.backupToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUlaejA9"))))))));
			this.backupToolStripMenuItem1.Size = new global::System.Drawing.Size(183, 22);
			this.backupToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUXlWbFJSYlhRMFkydFNUbG96YkVOak1rWnFWRE5HTmxNd05IaFRWVlpMWVVacmVXUkVSbXBSVkRBNQ=="))))))));
			this.backupToolStripMenuItem1.Click += new global::System.EventHandler(this.backupToolStripMenuItem1_Click);
			this.htmlToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZWb1UyUkhTa2RWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVFOVBRPT0="))))))));
			this.htmlToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.htmlToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlcweGMyTXhjRlJSYlRsclVucEdlZz09"))))))));
			this.htmlToolStripMenuItem.Click += new global::System.EventHandler(this.htmlToolStripMenuItem_Click);
			this.fileTxtToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIweGMyTXhjRmRWYWxKclVteEtNbGxxU2pSV1IxSkpVMjVDYWxKVVJuTlpiVFZYVTIxU1NGWnVVVDA9"))))))));
			this.fileTxtToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.fileTxtToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlcweGMyTXhjRlJSYWtKc1UwWkZPUT09"))))))));
			this.fileTxtToolStripMenuItem.Click += new global::System.EventHandler(this.fileTxtToolStripMenuItem_Click);
			this.thưMụcToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2NWSXpUa1pOTW1neFRteGFjVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.thưMụcToolStripMenuItem.Size = new global::System.Drawing.Size(149, 22);
			this.thưMụcToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vlcwd05XTXhjRWhXYm14S1VsVndiMWRVU2pCTlYwNUNVRlF3UFE9PQ=="))))))));
			this.thưMụcToolStripMenuItem.Click += new global::System.EventHandler(this.thưMụcToolStripMenuItem_Click_1);
			this.xóaDữLiệuBackupToolStripMenuItem.Image = global::maxcare.Properties.Resources.close_window_25px;
			this.xóaDữLiệuBackupToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRlpXUjJneFRtcHNUbGxYVmtoT01tZDZWbXRPV2xZd05YbGFSbWhEVmxkSmVVOVlUbFpOTVVvMVdWWm9RMVJzY0ZoT1ZFWlVWMFpLYzFsc1JUbFFVVDA5"))))))));
			this.xóaDữLiệuBackupToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.xóaDữLiệuBackupToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHVnNiRlJSYlhNd1dXNVdNbE5WWkRSalJGSnBaRlZvYTFVd1NrUlhWbVJQWTIxU1dWRlVNRDA9"))))))));
			this.xóaDữLiệuBackupToolStripMenuItem.Click += new global::System.EventHandler(this.xóaDữLiệuBackupToolStripMenuItem_Click);
			this.dọnDẹpBackupToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_broom;
			this.dọnDẹpBackupToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJzNVNFNHljRmhPVlZVd1dXNUZNVmt3Vmt0aFJtdDVaRVJHYWxKc1NqSlpha28wVmtkU1NWTnVRbXBTVkVaeldXMDFWMU50VWtoV2JsRTk="))))))));
			this.dọnDẹpBackupToolStripMenuItem.Size = new global::System.Drawing.Size(183, 22);
			this.dọnDẹpBackupToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldzNVNFNHljRmhPUjJSaFZEQmpNbVJXYUVKYU1VWjBVbTF3YUUweFdqTT0="))))))));
			this.dọnDẹpBackupToolStripMenuItem.Click += new global::System.EventHandler(this.dọnDẹpBackupToolStripMenuItem_Click);
			this.giaiCheckpointToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.giảiCheckpintNgàySinhToolStripMenuItem,
				this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem,
				this.gửiOTPVềMailMbasicbetaToolStripMenuItem,
				this.giảiCP282ToolStripMenuItem
			});
			this.giaiCheckpointToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2MyRkhSbFpVYlRsaFZqQTFlVmt3WXpWalIwcDFWV3hXYVUxcWJIcFdWRTVUWlZkR1dWRnJOV0ZXZWxWNFZURm9VMkpIU2xST1ZYQnBWakJhZFZkc1JUbFFVVDA5")))))))));
			this.giaiCheckpointToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2MyRkhSbFpVYlRsaFZqQTFlVmt3WXpWalIwcDFWV3hXYVUxcWJIcFdWRTVUWlZkR1dWRnJOV0ZXZWxWNFZURm9VMkpIU2xKUVZEQTk="))))))));
			this.giaiCheckpointToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.giaiCheckpointToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldwS2MyRkljRXBpU0VKS1VsVTFkbGRzWkU5amJVNUlUMWhDYVdKc1JUaz0="))))))));
			this.giảiCheckpintNgàySinhToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RXRklWbmhVYmtKU1RXMW9jMWRVU2pCa01rWllUbFJDVldKWFdrVmlNR2h6VmtkR1dFNVhPVmRTZW13eVdXdGFUMDFIVG5SaVNHUlZWakZhTVZwR1ZuTk5SbkJZVFVRd1BRPT0="))))))));
			this.giảiCheckpintNgàySinhToolStripMenuItem.Size = new global::System.Drawing.Size(252, 22);
			this.giảiCheckpintNgàySinhToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGJWSkhPVWxoTW1ScVRXMTRNVmxWVGtKaU1VbDVZa2RvYVdWVlNuSlpWMVpJVGpKbmVVNUhaRnBQUm1SM1V6RkZPVkJSUFQwPQ=="))))))));
			this.giảiCheckpintNgàySinhToolStripMenuItem.Click += new global::System.EventHandler(this.giảiCheckpintNgàySinhToolStripMenuItem_Click);
			this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJsMFNFNHpTbGhpUmtKWFVtdEtXRTVIU2pGUmJGSllVbTVDYVZKWFVuZFhWbU0xVWxkR2JGSjZaRzlOYWxaUFRrZEtNVmx0UmxkVmJscHBUVzVvVlZwRmFFdGpSMDVHVFZkNGFXSnNXa3RhUldSWFpFRTlQUT09"))))))));
			this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem.Size = new global::System.Drawing.Size(252, 22);
			this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldsMFNFNHpTbGhoTW1SVlRWWktVbE5WYUdsaFNGVXdVbGRrYVZZd1duZFphMDVDWWpKR1NFOVVRbWxXTUZwM1dXdE5OVTVXYkZoT1YzUmhWMGRrZHc9PQ=="))))))));
			this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem.Click += new global::System.EventHandler(this.gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem_Click);
			this.gửiOTPVềMailMbasicbetaToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJsMFNFNHpTbGhpUmtKWFVtdEtXRTVIU2pGUmJGSllVbTVDYVZKVVJuQlhWbWhQWTBacmVWTnRlR3RTTUZwV1dXcEpOV014VlhwVmJteG9WMFZLVDFkc1l6Rk5WazVaVlcxNGFWVlVNRGs9"))))))));
			this.gửiOTPVềMailMbasicbetaToolStripMenuItem.Size = new global::System.Drawing.Size(252, 22);
			this.gửiOTPVềMailMbasicbetaToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldsMFNFNHpTbGhoTW1SVlRWWktVbE5WYUdsaFNGVXdVbGRrYVZZd1duZFphMDVEWkVac2RGSnVjR2hXTURBNQ=="))))))));
			this.gửiOTPVềMailMbasicbetaToolStripMenuItem.Click += new global::System.EventHandler(this.gửiOTPVềMailMbasicbetaToolStripMenuItem_Click);
			this.giảiCP282ToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RXRklWbmhVYmtKU1RWVkdOVlF3VWt0V1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.giảiCP282ToolStripMenuItem.Size = new global::System.Drawing.Size(252, 22);
			this.giảiCP282ToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldwS2RXRklWbmhVYmtKS1VsVTFVbE5WVWtwT1JURnVVRlF3UFE9PQ=="))))))));
			this.giảiCP282ToolStripMenuItem.Click += new global::System.EventHandler(this.giảiCP282ToolStripMenuItem_Click);
			this.tảiLạiDanhSáchToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXRPSGxpUlRBd1dXNUdiMWxXVmxOaFIwcDBZVVpTTTA1clduRlpWVnBUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUZSSGRITmtSbXhZV2tkM1BRPT0=")))))))));
			this.tảiLạiDanhSáchToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXRPSGxpUlRBd1dXNUdiMWxXVmxOaFIwcDBZVVpTTTA1clduRlpWVnBUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUE9PQ=="))))))));
			this.tảiLạiDanhSáchToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.tảiLạiDanhSáchToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNXRPSGxoTW1ScFZEQmpNbUl4WkhKYU1YQklVbTVXYUZFd1NqWmtlbHBIWVcxR1FsQlVNRDA9"))))))));
			this.tảiLạiDanhSáchToolStripMenuItem.Click += new global::System.EventHandler(this.TảiLạiDanhSáchToolStripMenuItem_Click);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.pnlHeader;
			this.bunifuDragControl1.Vertical = true;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.lblNotify);
			this.pnlHeader.Controls.Add(this.lblStatusUpdate);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.button2);
			this.pnlHeader.Controls.Add(this.button1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(2, 5);
			this.pnlHeader.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCak1XTXhUa2hXYldoaFVqRmFOUT09"))))))));
			this.pnlHeader.Size = new global::System.Drawing.Size(1242, 29);
			this.pnlHeader.TabIndex = 0;
			this.lblNotify.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblNotify.AutoSize = true;
			this.lblNotify.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblNotify.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblNotify.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblNotify.LinkColor = global::System.Drawing.Color.Red;
			this.lblNotify.Location = new global::System.Drawing.Point(715, 6);
			this.lblNotify.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhVblJQVkVKb1ZqRnZNUT09"))))))));
			this.lblNotify.Size = new global::System.Drawing.Size(428, 16);
			this.lblNotify.TabIndex = 13;
			this.lblNotify.TabStop = true;
			this.lblNotify.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlRCa2RXRklWVEJhU0ZaS1UwWlNiMlJZUmtkalJXeEdUVlZ3VldGVlNsVldSRUpoVmxaWmQxSnNUbE5WTUZKR1lUSk9VR0ZyYkVoVlJWSjZaVlZLTTFsVk9VaE9ia0Y1VGtka2FWcFZZek5hTVdOM1dqSktkVmRGVWpCU01uUnVXVzB4YzJGdFJqVlJha0pxWXpBNWVGbHRiRU5pYlVac1VucGFkbVZWU25wT1IwcDRaRWRPUkZGck1WTlNhMHA2VjFab2MySkhUbkJTVkRBOQ=="))))))));
			this.lblNotify.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblNotify.Visible = false;
			this.lblNotify.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.lblStatusUpdate.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblStatusUpdate.AutoSize = true;
			this.lblStatusUpdate.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblStatusUpdate.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatusUpdate.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblStatusUpdate.LinkColor = global::System.Drawing.Color.Red;
			this.lblStatusUpdate.Location = new global::System.Drawing.Point(835, 6);
			this.lblStatusUpdate.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhWWHBWYldoclUwWmFObFpzYUVOaE1XeFpWVzEzUFE9PQ=="))))))));
			this.lblStatusUpdate.Size = new global::System.Drawing.Size(308, 16);
			this.lblStatusUpdate.TabIndex = 13;
			this.lblStatusUpdate.TabStop = true;
			this.lblStatusUpdate.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGRZVmtoT2JUaDVUa2RrYTFkRlNuSlhWbWhUWWtWc1NFMHlhREZPV0ZKM1ZFVk9RMDVHY0ZoTlIyUmFUVzFvZDFOVmFGTmpSRkpwWTFNNWExRXdTakZPUjBveFYyMUdWRkZ0ZEd0V2VsWjFVMVZvVjJReGNFaFNha0poVlRCVk9RPT0="))))))));
			this.lblStatusUpdate.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblStatusUpdate.Visible = false;
			this.lblStatusUpdate.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblStatusUpdate_LinkClicked);
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
			this.button2.Location = new global::System.Drawing.Point(1146, 0);
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
			this.button1.Location = new global::System.Drawing.Point(1178, 0);
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
			this.btnMinimize.Location = new global::System.Drawing.Point(1210, 0);
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
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(576, 16);
			this.bunifuCustomLabel1.TabIndex = 3;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtaV1IxZFZiRVpVYTBwV1lURldibFJyVFRCT1JYaHhWbGRrVFZVd1NsSlpWVGxJVG01QmVVNUhaRlZhVldNeldqRmpkMW94VmxsWFIyZ3hZMVUxTVZOVlZqWlNTRnBVVVd4a1dsa3piRUpUVlZaUFlqTm9TbFJ1VWtwU2F6VXlaV3RzUjJGcmJFZFdSVkoyVWpKMGJsVjZTbTlrYWxKcFkxZHdhV0ZWU2toWFZtUlBZa1pzZEU5WVdtaGxWVVl3VTFWVmVGTnNVbkJSYkZKVlRVWndWbFpxUWtkVk1VcFNVRlF3UFE9PQ=="))))))));
			this.bunifuCards1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.RoyalBlue;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(1, 0);
			this.bunifuCards1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RXdGFOVmRyYUU1bFFUMDk="))))))));
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(1243, 38);
			this.bunifuCards1.TabIndex = 0;
			this.menuStrip1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Dock = global::System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.hệThốngToolStripMenuItem,
				this.càiĐặtToolStripMenuItem,
				this.thoátToolStripMenuItem,
				this.taiKhoanĐaXoaToolStripMenuItem,
				this.tiệnÍchToolStripMenuItem,
				this.liênHệToolStripMenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(1, 37);
			this.menuStrip1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1YyUlhVbGRVYWtKcVlsZDRNMVJXUlRsUVVUMDk="))))))));
			this.menuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new global::System.Drawing.Size(1241, 25);
			this.menuStrip1.Stretch = false;
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1YyUlhVbGRVYWtKcVlsZDRNMVJXUlRsUVVUMDk="))))))));
			this.menuStrip1.ItemClicked += new global::System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			this.hệThốngToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_job;
			this.hệThốngToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZVNVNFNHlaM2hWYlRnd1dXNVdVMWx0TVd0V1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.hệThốngToolStripMenuItem.Size = new global::System.Drawing.Size(124, 21);
			this.hệThốngToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSb1VHRlljRXBTYWtaS1VqSm9kMlZyYkVOa1YwWkVVVzF3YUZOR1dqRlhibU01VUZFOVBRPT0="))))))));
			this.hệThốngToolStripMenuItem.Click += new global::System.EventHandler(this.mnuCauHinhChung_Click);
			this.càiĐặtToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_opposite_opinion;
			this.càiĐặtToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSb1VGb3lSbXBWTVVVd1dXNUZlbHBGV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvdw=="))))))));
			this.càiĐặtToolStripMenuItem.Size = new global::System.Drawing.Size(144, 21);
			this.càiĐặtToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSb1VHRlljRXBTYWtaS1VqSm9kMlZyYkVOa1YwWkVVV3BDTkdOclVraGlNV014WW10c1NWVnRhRFpUVlZweA=="))))))));
			this.càiĐặtToolStripMenuItem.TextDirection = global::System.Windows.Forms.ToolStripTextDirection.Horizontal;
			this.càiĐặtToolStripMenuItem.Click += new global::System.EventHandler(this.càiĐặtToolStripMenuItem_Click_1);
			this.thoátToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_show_property_48px;
			this.thoátToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2IyUnVZekpTYWtKWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUVNRDA9"))))))));
			this.thoátToolStripMenuItem.Size = new global::System.Drawing.Size(132, 21);
			this.thoátToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSb1VHRlljRXBTYWtaS1VqSm9kMlZyYkVOa1YwWkVVVzA1YUZrd09YaGxhMnh6WkZWc1NWVnRPV2haTTJ4eA=="))))))));
			this.thoátToolStripMenuItem.Click += new global::System.EventHandler(this.câuHinhHiênThiToolStripMenuItem_Click);
			this.taiKhoanĐaXoaToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_delete_bin_21;
			this.taiKhoanĐaXoaToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa1IyTkdUWGxoU0ZwYVZucGtSbUV3WkVkWFYwbDVVbXhXYVUxcWJIcFdWRTVUWlZkR1dWRnJOV0ZXZWxWNFZURm9VMkpIU2xKUVZEQTk="))))))));
			this.taiKhoanĐaXoaToolStripMenuItem.Size = new global::System.Drawing.Size(134, 21);
			this.taiKhoanĐaXoaToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1NWUlhaRWhoTW1Sb1RXMW9NbGRYVGpWVGJVcHdVa1ZXY2xZd2FFNWFNMnhEVGtkSk5HVlZTbHBWVkRBNQ=="))))))));
			this.taiKhoanĐaXoaToolStripMenuItem.Click += new global::System.EventHandler(this.taiKhoanĐaXoaToolStripMenuItem_Click);
			this.tiệnÍchToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.checkLiveUidToolStripMenuItem,
				this.checkProxyToolStripMenuItem1,
				this.checkHotmailToolStripMenuItem,
				this.lọcTrùngDữLiệuToolStripMenuItem,
				this.xửLýChuỗiOnlineToolStripMenuItem
			});
			this.tiệnÍchToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_circled_menu;
			this.tiệnÍchToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWa2RXRklWVEJhU0ZZelRrUkdjVmxWV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvdw=="))))))));
			this.tiệnÍchToolStripMenuItem.Size = new global::System.Drawing.Size(81, 21);
			this.tiệnÍchToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2RXRklWVEJhU0ZaS1ZGVTVNRmRVU201UVVUMDk="))))))));
			this.checkLiveUidToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_checkmark_26px;
			this.checkLiveUidToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUlRGb1YwWndjMVpzWkhOaE1WcElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.checkLiveUidToolStripMenuItem.Size = new global::System.Drawing.Size(260, 22);
			this.checkLiveUidToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVlVqSjNlVmRzVGtOV2JVWllWVlF3UFE9PQ=="))))))));
			this.checkLiveUidToolStripMenuItem.Click += new global::System.EventHandler(this.checkLiveUidToolStripMenuItem_Click);
			this.checkProxyToolStripMenuItem1.Image = global::maxcare.Properties.Resources.icons8_cloud_firewall_64px1;
			this.checkProxyToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUmtacVlsUnJNRnBXV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvd1ZGWkZPVkJSUFQwPQ=="))))))));
			this.checkProxyToolStripMenuItem1.Size = new global::System.Drawing.Size(260, 22);
			this.checkProxyToolStripMenuItem1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SV1UwVndNbHBWYUhKUVVUMDk="))))))));
			this.checkProxyToolStripMenuItem1.Click += new global::System.EventHandler(this.checkProxyToolStripMenuItem1_Click);
			this.checkHotmailToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_mail;
			this.checkHotmailToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrUld4cFRURktNRmRXWkhOak1WcElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.checkHotmailToolStripMenuItem.Size = new global::System.Drawing.Size(260, 22);
			this.checkHotmailToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SU1RXcHNNVmx0TVZkaGJWSkVVVzE0YVZZd1duZFphMDVEWVZSU2FXTllhR2xpVjA1dVZURmplR0ZIVGtKUVZEQTk="))))))));
			this.checkHotmailToolStripMenuItem.Click += new global::System.EventHandler(this.checkHotmailToolStripMenuItem_Click);
			this.lọcTrùngDữLiệuToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_mail_filter_24px;
			this.lọcTrùngDữLiệuToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1dzNVNFNHljRmhVYkZacVl6QTRNVmx0TVd0U1ZGSnBaRmhhVlZJeU5XOWtWRkpyVFZaYVNFOVlXbWxTYXpSM1dUSXhjMlF4VWxoV2JsWnJWbGQzZDFkc1kzZFFVVDA5"))))))));
			this.lọcTrùngDữLiệuToolStripMenuItem.Size = new global::System.Drawing.Size(260, 22);
			this.lọcTrùngDữLiệuToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVNVNFNHljRmhVVjJSclUwVjRSV1JXWXpGaWEyeElWa2RvTVU1cWFHNVphMlIxWVVoVk1GcEVSVDA9"))))))));
			this.lọcTrùngDữLiệuToolStripMenuItem.Click += new global::System.EventHandler(this.lọcTrùngDữLiệuToolStripMenuItem_Click);
			this.xửLýChuỗiOnlineToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_rss;
			this.xửLýChuỗiOnlineToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVNVNFNHpTbFpsYTFJeVZsVTFkbHBIVmtoT01uZDVZa1pDYVdKWWFIZFpiVEZYVmxkSmVVOVlUbFpOTVVvMVdWWm9RMVJzY0ZoT1ZFWlVWMFpLYzFsc1JUbFFVVDA5"))))))));
			this.xửLýChuỗiOnlineToolStripMenuItem.Size = new global::System.Drawing.Size(260, 22);
			this.xửLýChuỗiOnlineToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBNVNFNHpTbFJSYms0elRucENibGRVU205TlZGSnBaRlpvYUZVd1NuRmxTRVpHV2pGc01WSjZXblpOYWxFNQ=="))))))));
			this.xửLýChuỗiOnlineToolStripMenuItem.Click += new global::System.EventHandler(this.xửLýChuỗiOnlineToolStripMenuItem_Click);
			this.liênHệToolStripMenuItem.Image = global::maxcare.Properties.Resources.icons8_safety_float;
			this.liênHệToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a2RWSklSblJPVldzd1dXNVdTVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.liênHệToolStripMenuItem.Size = new global::System.Drawing.Size(77, 21);
			this.liênHệToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWa2RWSklSblJPUjJSb1ZEQmpNMkZJWXpsUVVUMDk="))))))));
			this.liênHệToolStripMenuItem.Click += new global::System.EventHandler(this.liênHệToolStripMenuItem_Click);
			this.grQuanLyThuMuc.Controls.Add(this.btnLoadAcc);
			this.grQuanLyThuMuc.Controls.Add(this.btnEditFile);
			this.grQuanLyThuMuc.Controls.Add(this.btnDeleteFile);
			this.grQuanLyThuMuc.Controls.Add(this.AddFileAccount);
			this.grQuanLyThuMuc.Controls.Add(this.cbbTinhTrang);
			this.grQuanLyThuMuc.Controls.Add(this.cbbThuMuc);
			this.grQuanLyThuMuc.Controls.Add(this.label2);
			this.grQuanLyThuMuc.Controls.Add(this.label1);
			this.grQuanLyThuMuc.Controls.Add(this.button9);
			this.grQuanLyThuMuc.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.grQuanLyThuMuc.Location = new global::System.Drawing.Point(572, 65);
			this.grQuanLyThuMuc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwT1MxVnRVbGhTYmxaVlUwZDRWbGxWYUZkVWJWSllWRlF3UFE9PQ=="))))))));
			this.grQuanLyThuMuc.Size = new global::System.Drawing.Size(662, 53);
			this.grQuanLyThuMuc.TabIndex = 5;
			this.grQuanLyThuMuc.TabStop = false;
			this.grQuanLyThuMuc.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmxab1dXRklWbmhVYmxaS1VqTndSV1JzVGtOTlIwWk9XVmhrU2xKNlRtOWtWRnBYWVdjOVBRPT0="))))))));
			this.btnLoadAcc.BackgroundImage = global::maxcare.Properties.Resources.available_updates_25px;
			this.btnLoadAcc.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.btnLoadAcc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnLoadAcc.Location = new global::System.Drawing.Point(498, 19);
			this.btnLoadAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVa2hQVjJoaFVsVmFjVmRZWXpsUVVUMDk="))))))));
			this.btnLoadAcc.Size = new global::System.Drawing.Size(25, 25);
			this.btnLoadAcc.TabIndex = 6;
			this.toolTip1.SetToolTip(this.btnLoadAcc, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWak5XRkdjRVJSYmswd1dXNUdiMWxXVGtOaE1XeFlUbGM1U2xOR1FrVmlNV1JQWW5jOVBRPT0=")))))))));
			this.btnLoadAcc.UseSelectable = true;
			this.btnLoadAcc.Click += new global::System.EventHandler(this.BtnLoadAcc_Click);
			this.btnEditFile.BackColor = global::System.Drawing.Color.Gray;
			this.btnEditFile.BackgroundImage = global::maxcare.Properties.Resources.icons8_edit_24px1;
			this.btnEditFile.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.btnEditFile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnEditFile.Enabled = false;
			this.btnEditFile.Location = new global::System.Drawing.Point(435, 19);
			this.btnEditFile.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldTbGhWYmtKclVsWndkMWxyWkZaUVVUMDk="))))))));
			this.btnEditFile.Size = new global::System.Drawing.Size(25, 25);
			this.btnEditFile.TabIndex = 5;
			this.toolTip1.SetToolTip(this.btnEditFile, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxOMFNFNHpTbGhTVjJSclZGVTVlRmx0YkVOTlIwWk9XVmhrU2xKNlRtOWtWRnBYWVdjOVBRPT0=")))))))));
			this.btnEditFile.UseSelectable = true;
			this.btnEditFile.Click += new global::System.EventHandler(this.metroButton2_Click_1);
			this.btnDeleteFile.BackColor = global::System.Drawing.Color.Gray;
			this.btnDeleteFile.BackgroundImage = global::maxcare.Properties.Resources.icons8_subtract_25px;
			this.btnDeleteFile.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.btnDeleteFile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnDeleteFile.Enabled = false;
			this.btnDeleteFile.Location = new global::System.Drawing.Point(466, 19);
			this.btnDeleteFile.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldTa2hXYms1aFYwWktjMVZ0TVhOak1YQlNVRlF3UFE9PQ=="))))))));
			this.btnDeleteFile.Size = new global::System.Drawing.Size(25, 25);
			this.btnDeleteFile.TabIndex = 5;
			this.toolTip1.SetToolTip(this.btnDeleteFile, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHVnNiRlJSYWtKb1ZGZEdNMU5WWTNwaFNGVXlWbTF2UFE9PQ==")))))))));
			this.btnDeleteFile.UseSelectable = true;
			this.btnDeleteFile.Click += new global::System.EventHandler(this.BtnDeleteFile_Click);
			this.AddFileAccount.BackgroundImage = global::maxcare.Properties.Resources.icons8_plus_math_25px1;
			this.AddFileAccount.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.AddFileAccount.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.AddFileAccount.Location = new global::System.Drawing.Point(404, 19);
			this.AddFileAccount.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZaa1UyRXhTblJpU0U1aFZsVmFjVmRVU1RWTlYwcDFWVlF3UFE9PQ=="))))))));
			this.AddFileAccount.Size = new global::System.Drawing.Size(25, 25);
			this.AddFileAccount.TabIndex = 4;
			this.toolTip1.SetToolTip(this.AddFileAccount, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSklSblJOUjJSclVqSndTR013VGtOa1JGSnBaRmQ0V21SNk1Eaz0=")))))))));
			this.AddFileAccount.UseSelectable = true;
			this.AddFileAccount.Click += new global::System.EventHandler(this.AddFileAccount_Click_1);
			this.cbbTinhTrang.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cbbTinhTrang.DropDownWidth = 300;
			this.cbbTinhTrang.FontSize = global::MetroFramework.MetroComboBoxSize.Small;
			this.cbbTinhTrang.FormattingEnabled = true;
			this.cbbTinhTrang.ItemHeight = 19;
			this.cbbTinhTrang.Items.AddRange(new object[]
			{
				global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm5wR1ZXRklWbmhXYWtKS1VqRkNiMlJZUms1YU1sSk9WRE5PYVdKWFpHNWFSV2hOWVVoV2VGSnVWbUZOVkVFNQ=="))))))))
			});
			this.cbbTinhTrang.Location = new global::System.Drawing.Point(277, 19);
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
			this.cbbThuMuc.Location = new global::System.Drawing.Point(72, 19);
			this.cbbThuMuc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS1MyRldXa2hoUkVaVlYwWmFjUT09"))))))));
			this.cbbThuMuc.Size = new global::System.Drawing.Size(167, 25);
			this.cbbThuMuc.TabIndex = 1;
			this.cbbThuMuc.UseSelectable = true;
			this.cbbThuMuc.SelectedIndexChanged += new global::System.EventHandler(this.CbbThuMuc_SelectedIndexChanged);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(241, 22);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(32, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVNVNFNHljRmhVVkZrOQ=="))))))));
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(8, 23);
			this.label1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJjOQ=="))))))));
			this.label1.Size = new global::System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXpUa1JSYmxFd1dXNVdjMWRZY0haUVVUMDk="))))))));
			this.button9.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button9.BackColor = global::System.Drawing.Color.White;
			this.button9.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button9.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button9.Image = global::maxcare.Properties.Resources.upload_to_ftp_25px;
			this.button9.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button9.Location = new global::System.Drawing.Point(530, 18);
			this.button9.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUVZWUXdPUT09"))))))));
			this.button9.Size = new global::System.Drawing.Size(130, 27);
			this.button9.TabIndex = 7;
			this.button9.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1UwWlNSV0l3WkhKYU1rVjVZVWhaTUZsdVJuRlpiV001VUZFOVBRPT0="))))))));
			this.button9.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new global::System.EventHandler(this.Button3_Click);
			this.grTimKiem.Controls.Add(this.BtnSearch);
			this.grTimKiem.Controls.Add(this.cbbSearch);
			this.grTimKiem.Controls.Add(this.txbSearch);
			this.grTimKiem.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.grTimKiem.Location = new global::System.Drawing.Point(282, 65);
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
			this.statusStrip1.BackColor = global::System.Drawing.SystemColors.Control;
			this.statusStrip1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel1,
				this.lblStatus,
				this.toolStripStatusLabel3,
				this.lblKey,
				this.toolStripStatusLabel8,
				this.txbUid,
				this.lblUser,
				this.toolStripStatusLabel9,
				this.toolStripStatusLabel10,
				this.lblDateExpried,
				this.toolStripStatusLabel4,
				this.lblCountHighline,
				this.toolStripStatusLabel5,
				this.lblCountSelect,
				this.toolStripStatusLabel7,
				this.lblCountTotal
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 586);
			this.statusStrip1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1hwT1UyRkhVa2xXYm5CV1RURktOVmxXYUVKbFFUMDk="))))))));
			this.statusStrip1.Size = new global::System.Drawing.Size(1242, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1hwT1UyRkhVa2xXYm5CV1RURktOVmxXYUVKbFFUMDk="))))))));
			this.statusStrip1.ItemClicked += new global::System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
			this.toolStripStatusLabel1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XUnRTa2RVYWtKcVlsZDRNMVpVVGxOaFIxSkpWbTV3VlZJd1duQlhiR1F6WlVFOVBRPT0="))))))));
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(79, 17);
			this.toolStripStatusLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10b1RXRklWbmhTYmxaaFpWVkpkMWxWTVZCaFIwWlZZbm93UFE9PQ=="))))))));
			this.lblStatus.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatus.ForeColor = global::System.Drawing.Color.Green;
			this.lblStatus.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhWWHBWYldoclUwWmFOZz09"))))))));
			this.lblStatus.Size = new global::System.Drawing.Size(97, 17);
			this.lblStatus.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1EyRkhTblJaTW1Sb1RXMDFSV05ZVGpWVGJVcFVVV3BDYW1KVlZqRlVSMnN3VUZFOVBRPT0="))))))));
			this.toolStripStatusLabel3.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XUnRTa2RVYWtKcVlsZDRNMVpVVGxOaFIxSkpWbTV3VlZJd1duQlhiR1F6WldjOVBRPT0="))))))));
			this.toolStripStatusLabel3.Size = new global::System.Drawing.Size(82, 17);
			this.toolStripStatusLabel3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkT1VHRnJiRWxWYlRsb1dsVmpNbVJxVGxKYU1Xd3hVbnBrY0dWdE9Eaz0="))))))));
			this.lblKey.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblKey.ForeColor = global::System.Drawing.Color.Teal;
			this.lblKey.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhUWGxXYWxVOQ=="))))))));
			this.lblKey.Size = new global::System.Drawing.Size(49, 17);
			this.lblKey.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VXpKc2RtTlZkSEJpTTBVOQ=="))))))));
			this.toolStripStatusLabel8.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel8.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XUnRTa2RVYWtKcVlsZDRNMVpVVGxOaFIxSkpWbTV3VlZJd1duQlhiR1F6VGtFOVBRPT0="))))))));
			this.toolStripStatusLabel8.Size = new global::System.Drawing.Size(42, 17);
			this.toolStripStatusLabel8.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14b1QySkhUbkZpZWpBOQ=="))))))));
			this.txbUid.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IyRldXbGhpUjNNOQ=="))))))));
			this.txbUid.Size = new global::System.Drawing.Size(0, 17);
			this.lblUser.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhXbGxVYlhocVdub3dPUT09"))))))));
			this.lblUser.Size = new global::System.Drawing.Size(56, 17);
			this.lblUser.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VXpKc2RtTlZkSEJpTTBVOQ=="))))))));
			this.toolStripStatusLabel9.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel9.IsLink = true;
			this.toolStripStatusLabel9.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XUnRTa2RVYWtKcVlsZDRNMVpVVGxOaFIxSkpWbTV3VlZJd1duQlhiR1F6VGxFOVBRPT0="))))))));
			this.toolStripStatusLabel9.Size = new global::System.Drawing.Size(66, 17);
			this.toolStripStatusLabel9.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1UwZG5lR1I2V2sxVVYyUlpWVlF3UFE9PQ=="))))))));
			this.toolStripStatusLabel9.Click += new global::System.EventHandler(this.ToolStripStatusLabel9_Click);
			this.toolStripStatusLabel10.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel10.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XUnRTa2RVYWtKcVlsZDRNMVpVVGxOaFIxSkpWbTV3VlZJd1duQlhiR1F6WlVVeFFsQlVNRDA9"))))))));
			this.toolStripStatusLabel10.Size = new global::System.Drawing.Size(99, 17);
			this.toolStripStatusLabel10.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGJWSkhPVWxoTW1Sb1ZEQmpNbVJxVGxKYU1rWlFVbnBhZGxaNlVUST0="))))))));
			this.lblDateExpried.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhTa2hTYWtKaFZsWlpNRmt3YUV0alJuQllWVlF3UFE9PQ=="))))))));
			this.lblDateExpried.Size = new global::System.Drawing.Size(74, 17);
			this.lblDateExpried.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZkd1FtUnJNVlZSV0ZwT1lXdEdOVlJWUlRsUVVUMDk="))))))));
			this.toolStripStatusLabel4.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.toolStripStatusLabel4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XUnRTa2RVYWtKcVlsZDRNMVpVVGxOaFIxSkpWbTV3VlZJd1duQlhiR1F6VFVFOVBRPT0="))))))));
			this.toolStripStatusLabel4.Size = new global::System.Drawing.Size(60, 17);
			this.toolStripStatusLabel4.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZoT1VFMUhSbFJTUlZaeVZqRmFNVlF5WXpsUVVUMDk="))))))));
			this.lblCountHighline.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCountHighline.ForeColor = global::System.Drawing.Color.Blue;
			this.lblCountHighline.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhSWGxQVkVacFlteEtTbGxXWkd0aU1rcElZa2hXWVZWVU1Eaz0="))))))));
			this.lblCountHighline.Size = new global::System.Drawing.Size(16, 17);
			this.lblCountHighline.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
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
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl2.Vertical = true;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 30000;
			this.toolTip1.InitialDelay = 0;
			this.toolTip1.ReshowDelay = 40;
			this.btnViewLivestream.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnViewLivestream.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnViewLivestream.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldXblJpUjNoclRVaG9kMXBITVZkbGJWSkpVMjE0V2xaNlFqRlZNV040WVVadmVWWlVNRDA9")))))))));
			this.btnViewLivestream.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnViewLivestream.Location = new global::System.Drawing.Point(275, 1);
			this.btnViewLivestream.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldXblJpUjNoclRVaG9kMXBITVZkbGJWSkpVMjE0V2xaNlFUaz0="))))))));
			this.btnViewLivestream.Size = new global::System.Drawing.Size(128, 29);
			this.btnViewLivestream.TabIndex = 4;
			this.btnViewLivestream.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZab1YwMUhTalZSYWxKaFZucENibGxyWkhOTmJIQlNVRlF3UFE9PQ=="))))))));
			this.btnViewLivestream.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.btnViewLivestream, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NWSXpUazVsVlVwYVpWVktNV1ZGYkU5a1ZuQTFVV3BDTkdOclVrNWlNMnhGVWxkMGFsUjZRalpUTURVeFYyNXNRMDVHY0ZoTlIyUnBVakozZVZkc2FFOU5SMDUwVm0xb2FWVlVNRGs9")))))))));
			this.btnViewLivestream.UseVisualStyleBackColor = false;
			this.btnViewLivestream.Click += new global::System.EventHandler(this.BtnViewLivestream_Click);
			this.btnShare.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnShare.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnShare.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWWGxoUjJocVlsWldNVlV4WTNoaFJtOTVWbFF3UFE9PQ==")))))))));
			this.btnShare.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnShare.Location = new global::System.Drawing.Point(139, 1);
			this.btnShare.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWWGxoUjJocVlsWlZPUT09"))))))));
			this.btnShare.Size = new global::System.Drawing.Size(128, 29);
			this.btnShare.TabIndex = 1;
			this.btnShare.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZab1YwMUhTalZSYlhCb1VqSjRiMU5WYUZGaFNGWjVZM293UFE9PQ=="))))))));
			this.btnShare.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.btnShare, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NWSXpUazVsVlVwYVpWVktNV1ZGYkU5a1ZuQTFVV3BDTkdOclVrNWlNMnhGVWxkMGFsUjZRalpUTURVeFYyNXNRMkZ0UmtoaVIyaEtVMFUxYzJWcmJISlFVVDA5")))))))));
			this.btnShare.UseVisualStyleBackColor = false;
			this.btnShare.Click += new global::System.EventHandler(this.BtnShare_Click);
			this.btnPost.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnPost.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnPost.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWa2hQV0hCclVYcFdTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.btnPost.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnPost.Location = new global::System.Drawing.Point(3, 1);
			this.btnPost.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWa2hQV0hCclVWUXdPUT09"))))))));
			this.btnPost.Size = new global::System.Drawing.Size(128, 29);
			this.btnPost.TabIndex = 0;
			this.btnPost.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZab1YwMUhTalZTUlZaeVdURk9SVmx0TVdwYU1XeDZWREprYUZWVU1Eaz0="))))))));
			this.btnPost.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.btnPost, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NWSXpUazVsVlVwYVpWVktNV1ZGYkU5a1ZuQTFVV3BDTkdOclVrNWlNMnhGVWxkMGFsUjZRalpUTURVeFYyNXNSVkpYZEdwVk1GSnBZbGRPYmxkWE1VbFVWMlJJWVhvd1BRPT0=")))))))));
			this.btnPost.UseVisualStyleBackColor = false;
			this.btnPost.Click += new global::System.EventHandler(this.BtnPost_Click);
			this.btnPause.BackColor = global::System.Drawing.Color.White;
			this.btnPause.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnPause.Enabled = false;
			this.btnPause.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnPause.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWa2hTYWtacVRXeFdNVlV4WTNoaFJtOTVWbFF3UFE9PQ==")))))))));
			this.btnPause.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnPause.Location = new global::System.Drawing.Point(145, 79);
			this.btnPause.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWa2hTYWtacVRXeFZPUT09"))))))));
			this.btnPause.Size = new global::System.Drawing.Size(128, 32);
			this.btnPause.TabIndex = 3;
			this.btnPause.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldzNVNFNHpSWGxPVnpWS1VteFNTR013TVdoaFIwcDBXVEprVjFSVk9XOVhXR001VUZFOVBRPT0="))))))));
			this.btnPause.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.btnPause, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldzeGFHUXpjRXBSYmxaaFpWVkpkMlZJU2tWU01qbFlUbGMxU2xOR1NtOWxhMnhIWVdjOVBRPT0=")))))))));
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += new global::System.EventHandler(this.BtnPause_Click);
			this.btnInteract.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnInteract.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnInteract.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldUbGhPVkVKaFYwVndiMWRVVGxKa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.btnInteract.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnInteract.Location = new global::System.Drawing.Point(9, 79);
			this.btnInteract.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldUbGhPVkVKaFYwVndiMWRVVGxKUVVUMDk="))))))));
			this.btnInteract.Size = new global::System.Drawing.Size(128, 32);
			this.btnInteract.TabIndex = 2;
			this.btnInteract.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWbmhTYWxaS1VteFNTR013TVdoaFIwcDBXVEprVjFSVk9XOVhXR001VUZFOVBRPT0="))))))));
			this.btnInteract.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTip1.SetToolTip(this.btnInteract, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZoT1ZGSkljRXBTYWtKS1ZGWk9VMlI2V2sxVVYyUkpWbGRrV2sxdGFHOWxhM1JQVGxWc1NWWkZaSHBVVjBadldXMHhhbG95VWtoVFJURnVWakF3T1E9PQ==")))))))));
			this.btnInteract.UseVisualStyleBackColor = false;
			this.btnInteract.Click += new global::System.EventHandler(this.BtnInteract_Click);
			this.plChucNang.Controls.Add(this.button8);
			this.plChucNang.Controls.Add(this.button4);
			this.plChucNang.Controls.Add(this.button7);
			this.plChucNang.Controls.Add(this.btnViewLivestream);
			this.plChucNang.Controls.Add(this.button6);
			this.plChucNang.Controls.Add(this.btnShare);
			this.plChucNang.Controls.Add(this.btnPost);
			this.plChucNang.Location = new global::System.Drawing.Point(6, 120);
			this.plChucNang.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GSkhSa2xXYlhCVllsVmFNVmR1WXpsUVVUMDk="))))))));
			this.plChucNang.Size = new global::System.Drawing.Size(805, 30);
			this.plChucNang.TabIndex = 6;
			this.button8.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button8.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button8.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUVVYcFdTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.button8.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button8.Location = new global::System.Drawing.Point(997, 1);
			this.button8.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUVVWUXdPUT09"))))))));
			this.button8.Size = new global::System.Drawing.Size(128, 29);
			this.button8.TabIndex = 8;
			this.button8.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa1IyVlhSWGxXYWtKcVVqTm9iMWRVU2xaUVVUMDk="))))))));
			this.button8.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new global::System.EventHandler(this.button4_Click);
			this.button4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button4.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUFVYcFdTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.button4.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button4.Location = new global::System.Drawing.Point(411, 1);
			this.button4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUFVWUXdPUT09"))))))));
			this.button4.Size = new global::System.Drawing.Size(128, 29);
			this.button4.TabIndex = 5;
			this.button4.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JXRklWVEZXYmtKS1UwWktkbVI2WkZOa1ZuQTFVV3BDYUZaNlVUaz0="))))))));
			this.button4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button7.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.button7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUFpWUldTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.button7.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.Location = new global::System.Drawing.Point(686, 1);
			this.button7.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUFpIb3dPUT09"))))))));
			this.button7.Size = new global::System.Drawing.Size(105, 29);
			this.button7.TabIndex = 7;
			this.button7.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VtdEtOVmxxVG05T1VUMDk="))))))));
			this.button7.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.button6.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button6.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.button6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUFlWUldTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.button6.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.Location = new global::System.Drawing.Point(547, 1);
			this.button6.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUFdub3dPUT09"))))))));
			this.button6.Size = new global::System.Drawing.Size(131, 29);
			this.button6.TabIndex = 6;
			this.button6.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VteGFObGRzYUV0aFJtOTVWbTVXYTFGVU1Eaz0="))))))));
			this.button6.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.metroButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.metroButton1.Location = new global::System.Drawing.Point(1112, 121);
			this.metroButton1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4a1YwMUhUblJQVlU1clYwWkpkMWxxU1RCbFFUMDk="))))))));
			this.metroButton1.Size = new global::System.Drawing.Size(122, 29);
			this.metroButton1.TabIndex = 7;
			this.metroButton1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS05HUnRUWGxXVjJSU1RXMW9OVmxxU1hoaVJuQkpVMjVDYTJKV1dqVT0="))))))));
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new global::System.EventHandler(this.metroButton1_Click);
			this.btnRandomIndexRow.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.btnRandomIndexRow.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnRandomIndexRow.Location = new global::System.Drawing.Point(1015, 121);
			this.btnRandomIndexRow.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWblJTYmxaaFVucHNNRlV4WXpGaE1YQlpZVVpPYVUweVRUaz0="))))))));
			this.btnRandomIndexRow.Size = new global::System.Drawing.Size(88, 29);
			this.btnRandomIndexRow.TabIndex = 7;
			this.btnRandomIndexRow.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxjeFIyUldjRWhQV0ZFOQ=="))))))));
			this.btnRandomIndexRow.UseSelectable = true;
			this.btnRandomIndexRow.Click += new global::System.EventHandler(this.metroButton2_Click);
			this.plTrangThai.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.plTrangThai.BackColor = global::System.Drawing.Color.Gainsboro;
			this.plTrangThai.Controls.Add(this.lblTrangThai);
			this.plTrangThai.Location = new global::System.Drawing.Point(868, 36);
			this.plTrangThai.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWlhUblJTYmxaaFRWWktkbGRXWkhKUVVUMDk="))))))));
			this.plTrangThai.Size = new global::System.Drawing.Size(373, 26);
			this.plTrangThai.TabIndex = 10;
			this.plTrangThai.Visible = false;
			this.lblTrangThai.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblTrangThai.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTrangThai.Location = new global::System.Drawing.Point(0, 0);
			this.lblTrangThai.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhXa2xUYldocFlsZFNWbGxWWkVkalFUMDk="))))))));
			this.lblTrangThai.Size = new global::System.Drawing.Size(373, 26);
			this.lblTrangThai.TabIndex = 0;
			this.lblTrangThai.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.statusStrip1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTJjOQ=="))))))));
			this.panel1.Size = new global::System.Drawing.Size(1244, 610);
			this.panel1.TabIndex = 11;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.timer1.Enabled = true;
			this.timer1.Interval = 1800000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1244, 610);
			base.Controls.Add(this.plTrangThai);
			base.Controls.Add(this.btnRandomIndexRow);
			base.Controls.Add(this.metroButton1);
			base.Controls.Add(this.plChucNang);
			base.Controls.Add(this.grTimKiem);
			base.Controls.Add(this.btnPause);
			base.Controls.Add(this.btnInteract);
			base.Controls.Add(this.grQuanLyThuMuc);
			base.Controls.Add(this.bunifuCards1);
			base.Controls.Add(this.menuStrip1);
			base.Controls.Add(this.dtgvAcc);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VTJ0b1UySXlSbGxVV0ZaVVZqQTFNbGx0WXpsUVVUMDk=")))))))));
			base.MainMenuStrip = this.menuStrip1;
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxemVHRkhSbGhPUkRBOQ=="))))))));
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
			this.grQuanLyThuMuc.PerformLayout();
			this.grTimKiem.ResumeLayout(false);
			this.grTimKiem.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.plChucNang.ResumeLayout(false);
			this.plTrangThai.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04001938 RID: 6456
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400193A RID: 6458
		public global::System.Windows.Forms.DataGridView dtgvAcc;

		// Token: 0x0400193B RID: 6459
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x0400193C RID: 6460
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x0400193D RID: 6461
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400193E RID: 6462
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400193F RID: 6463
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04001940 RID: 6464
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04001941 RID: 6465
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04001942 RID: 6466
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04001943 RID: 6467
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x04001944 RID: 6468
		private global::System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;

		// Token: 0x04001945 RID: 6469
		private global::System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;

		// Token: 0x04001946 RID: 6470
		private global::System.Windows.Forms.GroupBox grQuanLyThuMuc;

		// Token: 0x04001947 RID: 6471
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001948 RID: 6472
		private global::MetroFramework.Controls.MetroComboBox cbbThuMuc;

		// Token: 0x04001949 RID: 6473
		private global::MetroFramework.Controls.MetroContextMenu ctmsAcc;

		// Token: 0x0400194A RID: 6474
		private global::System.Windows.Forms.ToolStripMenuItem chọnLiveToolStripMenuItem;

		// Token: 0x0400194B RID: 6475
		private global::System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;

		// Token: 0x0400194C RID: 6476
		private global::System.Windows.Forms.ToolStripMenuItem mởTrìnhDuyệtToolStripMenuItem;

		// Token: 0x0400194D RID: 6477
		private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

		// Token: 0x0400194E RID: 6478
		private global::System.Windows.Forms.ToolStripMenuItem tokenToolStripMenuItem;

		// Token: 0x0400194F RID: 6479
		private global::System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem;

		// Token: 0x04001950 RID: 6480
		private global::System.Windows.Forms.ToolStripMenuItem uidPassToolStripMenuItem;

		// Token: 0x04001951 RID: 6481
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

		// Token: 0x04001952 RID: 6482
		private global::System.Windows.Forms.ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;

		// Token: 0x04001953 RID: 6483
		private global::System.Windows.Forms.ToolStripMenuItem chuyểnThưMụcToolStripMenuItem;

		// Token: 0x04001954 RID: 6484
		private global::System.Windows.Forms.ToolStripMenuItem checkCookieToolStripMenuItem;

		// Token: 0x04001955 RID: 6485
		private global::System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;

		// Token: 0x04001956 RID: 6486
		private global::System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem;

		// Token: 0x04001957 RID: 6487
		private global::System.Windows.Forms.ToolStripMenuItem bỏChọnTấtCảToolStripMenuItem;

		// Token: 0x04001958 RID: 6488
		private global::System.Windows.Forms.ToolStripMenuItem passToolStripMenuItem;

		// Token: 0x04001959 RID: 6489
		private global::System.Windows.Forms.Button btnInteract;

		// Token: 0x0400195A RID: 6490
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraCookieToolStripMenuItem;

		// Token: 0x0400195B RID: 6491
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraTokenToolStripMenuItem;

		// Token: 0x0400195C RID: 6492
		private global::System.Windows.Forms.ToolStripMenuItem tảiLạiDanhSáchToolStripMenuItem;

		// Token: 0x0400195D RID: 6493
		private global::System.Windows.Forms.ToolStripMenuItem cậpNhậtDữLiệuToolStripMenuItem;

		// Token: 0x0400195E RID: 6494
		private global::System.Windows.Forms.ToolStripMenuItem mậtKhẩuToolStripMenuItem1;

		// Token: 0x0400195F RID: 6495
		private global::System.Windows.Forms.ToolStripMenuItem tokenToolStripMenuItem2;

		// Token: 0x04001960 RID: 6496
		private global::System.Windows.Forms.ToolStripMenuItem tựĐộngLấyToolStripMenuItem1;

		// Token: 0x04001961 RID: 6497
		private global::System.Windows.Forms.ToolStripMenuItem tokenBussinessToolStripMenuItem;

		// Token: 0x04001962 RID: 6498
		private global::System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuToolStripMenuItem2;

		// Token: 0x04001963 RID: 6499
		private global::System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem3;

		// Token: 0x04001964 RID: 6500
		private global::System.Windows.Forms.Button btnPause;

		// Token: 0x04001965 RID: 6501
		private global::System.Windows.Forms.ToolStripMenuItem backupCookieToolStripMenuItem;

		// Token: 0x04001966 RID: 6502
		private global::System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem1;

		// Token: 0x04001967 RID: 6503
		private global::System.Windows.Forms.ToolStripMenuItem mailPassMailToolStripMenuItem;

		// Token: 0x04001968 RID: 6504
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieMailPassMailToolStripMenuItem;

		// Token: 0x04001969 RID: 6505
		private global::System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;

		// Token: 0x0400196A RID: 6506
		private global::System.Windows.Forms.ToolStripMenuItem tạoProfileToolStripMenuItem;

		// Token: 0x0400196B RID: 6507
		private global::System.Windows.Forms.ToolStripMenuItem trạngTháiToolStripMenuItem;

		// Token: 0x0400196C RID: 6508
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraWallToolStripMenuItem;

		// Token: 0x0400196D RID: 6509
		private global::System.Windows.Forms.GroupBox grTimKiem;

		// Token: 0x0400196E RID: 6510
		private global::WindowsFormsControlLibrary1.BunifuCustomTextbox txbSearch;

		// Token: 0x0400196F RID: 6511
		private global::System.Windows.Forms.ToolStripMenuItem mailToolStripMenuItem;

		// Token: 0x04001970 RID: 6512
		private global::System.Windows.Forms.ToolStripMenuItem mailKhôiPhụcToolStripMenuItem;

		// Token: 0x04001971 RID: 6513
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;

		// Token: 0x04001972 RID: 6514
		private global::System.Windows.Forms.Button btnShare;

		// Token: 0x04001973 RID: 6515
		private global::System.Windows.Forms.Button btnPost;

		// Token: 0x04001974 RID: 6516
		private global::System.Windows.Forms.Button btnViewLivestream;

		// Token: 0x04001975 RID: 6517
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04001976 RID: 6518
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x04001977 RID: 6519
		private global::System.Windows.Forms.ToolStripStatusLabel lblStatus;

		// Token: 0x04001978 RID: 6520
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;

		// Token: 0x04001979 RID: 6521
		private global::System.Windows.Forms.ToolStripStatusLabel lblKey;

		// Token: 0x0400197A RID: 6522
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;

		// Token: 0x0400197B RID: 6523
		private global::System.Windows.Forms.ToolStripStatusLabel lblCountTotal;

		// Token: 0x0400197C RID: 6524
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;

		// Token: 0x0400197D RID: 6525
		private global::System.Windows.Forms.ToolStripStatusLabel txbUid;

		// Token: 0x0400197E RID: 6526
		private global::System.Windows.Forms.ToolStripStatusLabel lblUser;

		// Token: 0x0400197F RID: 6527
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;

		// Token: 0x04001980 RID: 6528
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;

		// Token: 0x04001981 RID: 6529
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;

		// Token: 0x04001982 RID: 6530
		private global::System.Windows.Forms.ToolStripStatusLabel lblCountSelect;

		// Token: 0x04001983 RID: 6531
		private global::System.Windows.Forms.ToolStripMenuItem xóaProfileToolStripMenuItem;

		// Token: 0x04001984 RID: 6532
		private global::System.Windows.Forms.ToolStripMenuItem checkProfileToolStripMenuItem;

		// Token: 0x04001985 RID: 6533
		private global::System.Windows.Forms.ToolStripMenuItem fAToolStripMenuItem;

		// Token: 0x04001986 RID: 6534
		private global::System.Windows.Forms.ToolStripMenuItem đăngNhâpBăngUidpassToolStripMenuItem;

		// Token: 0x04001987 RID: 6535
		private global::System.Windows.Forms.ToolStripMenuItem đăngNhâpBăngCookieToolStripMenuItem;

		// Token: 0x04001988 RID: 6536
		private global::System.Windows.Forms.ToolStripMenuItem tinhTrangToolStripMenuItem;

		// Token: 0x04001989 RID: 6537
		private global::System.Windows.Forms.ToolStripMenuItem locTrungToolStripMenuItem;

		// Token: 0x0400198A RID: 6538
		private global::System.Windows.Forms.ToolStripMenuItem uidPass2FaToolStripMenuItem;

		// Token: 0x0400198B RID: 6539
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400198C RID: 6540
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x0400198D RID: 6541
		private global::System.Windows.Forms.ToolStripMenuItem taoFileHTMLToolStripMenuItem;

		// Token: 0x0400198E RID: 6542
		private global::System.Windows.Forms.ToolStripMenuItem đinhDangKhacToolStripMenuItem;

		// Token: 0x0400198F RID: 6543
		private global::System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem1;

		// Token: 0x04001990 RID: 6544
		private global::System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem;

		// Token: 0x04001991 RID: 6545
		private global::System.Windows.Forms.ToolStripMenuItem thưMụcToolStripMenuItem;

		// Token: 0x04001992 RID: 6546
		private global::System.Windows.Forms.ToolStripMenuItem tokenEAAAAZToolStripMenuItem;

		// Token: 0x04001993 RID: 6547
		private global::System.Windows.Forms.ToolStripMenuItem câpNhâtThôngTinCaNhânToolStripMenuItem;

		// Token: 0x04001994 RID: 6548
		private global::System.Windows.Forms.ToolStripMenuItem sưDungTokenTrungGianToolStripMenuItem;

		// Token: 0x04001995 RID: 6549
		private global::System.Windows.Forms.ToolStripMenuItem maBaoMât6SôToolStripMenuItem;

		// Token: 0x04001996 RID: 6550
		private global::System.Windows.Forms.ToolStripMenuItem donDepProfileToolStripMenuItem;

		// Token: 0x04001997 RID: 6551
		private global::System.Windows.Forms.Panel plChucNang;

		// Token: 0x04001998 RID: 6552
		private global::System.Windows.Forms.ToolStripMenuItem mã2FAToolStripMenuItem;

		// Token: 0x04001999 RID: 6553
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400199A RID: 6554
		private global::System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;

		// Token: 0x0400199B RID: 6555
		private global::System.Windows.Forms.Button button6;

		// Token: 0x0400199C RID: 6556
		private global::System.Windows.Forms.ToolStripMenuItem useragentToolStripMenuItem;

		// Token: 0x0400199D RID: 6557
		private global::System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem;

		// Token: 0x0400199E RID: 6558
		private global::System.Windows.Forms.Button button7;

		// Token: 0x0400199F RID: 6559
		private global::System.Windows.Forms.ToolStripMenuItem useragentToolStripMenuItem1;

		// Token: 0x040019A0 RID: 6560
		private global::System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem1;

		// Token: 0x040019A1 RID: 6561
		private global::System.Windows.Forms.ToolStripMenuItem giaiCheckpointToolStripMenuItem;

		// Token: 0x040019A2 RID: 6562
		private global::System.Windows.Forms.ComboBox cbbSearch;

		// Token: 0x040019A3 RID: 6563
		private global::System.Windows.Forms.ToolStripMenuItem mởThưMụcBackupToolStripMenuItem;

		// Token: 0x040019A4 RID: 6564
		private global::System.Windows.Forms.Button button8;

		// Token: 0x040019A5 RID: 6565
		private global::System.Windows.Forms.ToolStripMenuItem ghiChuToolStripMenuItem;

		// Token: 0x040019A6 RID: 6566
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x040019A7 RID: 6567
		private global::System.Windows.Forms.ToolStripMenuItem ngàySinhToolStripMenuItem;

		// Token: 0x040019A8 RID: 6568
		private global::MetroFramework.Controls.MetroButton AddFileAccount;

		// Token: 0x040019A9 RID: 6569
		private global::MetroFramework.Controls.MetroButton btnDeleteFile;

		// Token: 0x040019AA RID: 6570
		private global::MetroFramework.Controls.MetroButton btnLoadAcc;

		// Token: 0x040019AB RID: 6571
		private global::MetroFramework.Controls.MetroComboBox cbbTinhTrang;

		// Token: 0x040019AC RID: 6572
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040019AD RID: 6573
		private global::System.Windows.Forms.Button button9;

		// Token: 0x040019AE RID: 6574
		private global::System.Windows.Forms.ToolStripMenuItem taoShortcutChromeToolStripMenuItem;

		// Token: 0x040019AF RID: 6575
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraMailpassMailToolStripMenuItem;

		// Token: 0x040019B0 RID: 6576
		private global::System.Windows.Forms.ToolStripMenuItem loginHotmailToolStripMenuItem;

		// Token: 0x040019B1 RID: 6577
		private global::MetroFramework.Controls.MetroButton BtnSearch;

		// Token: 0x040019B2 RID: 6578
		private global::MetroFramework.Controls.MetroButton btnRandomIndexRow;

		// Token: 0x040019B3 RID: 6579
		private global::System.Windows.Forms.Panel plTrangThai;

		// Token: 0x040019B4 RID: 6580
		private global::System.Windows.Forms.Label lblTrangThai;

		// Token: 0x040019B5 RID: 6581
		private global::System.Windows.Forms.ToolStripMenuItem uidToolStripMenuItem;

		// Token: 0x040019B6 RID: 6582
		private global::System.Windows.Forms.ToolStripMenuItem checkAvatarToolStripMenuItem;

		// Token: 0x040019B7 RID: 6583
		private global::System.Windows.Forms.ToolStripMenuItem checkProxyToolStripMenuItem;

		// Token: 0x040019B8 RID: 6584
		private global::System.Windows.Forms.ToolStripMenuItem checkProfileToolStripMenuItem1;

		// Token: 0x040019B9 RID: 6585
		private global::System.Windows.Forms.ToolStripMenuItem tảiXuốngAvatarToolStripMenuItem;

		// Token: 0x040019BA RID: 6586
		private global::System.Windows.Forms.ToolStripMenuItem xóaDữLiệuBackupToolStripMenuItem;

		// Token: 0x040019BB RID: 6587
		private global::System.Windows.Forms.ToolStripMenuItem mởFolderBackupToolStripMenuItem;

		// Token: 0x040019BC RID: 6588
		private global::System.Windows.Forms.ToolStripMenuItem mởFileHTMLToolStripMenuItem;

		// Token: 0x040019BD RID: 6589
		private global::System.Windows.Forms.ToolStripMenuItem checkBackupToolStripMenuItem;

		// Token: 0x040019BE RID: 6590
		private global::System.Windows.Forms.ToolStripMenuItem checkInfoUIDToolStripMenuItem;

		// Token: 0x040019BF RID: 6591
		private global::System.Windows.Forms.ToolStripMenuItem checkBackupToolStripMenuItem1;

		// Token: 0x040019C0 RID: 6592
		private global::System.Windows.Forms.ToolStripMenuItem taiKhoanĐaXoaToolStripMenuItem;

		// Token: 0x040019C1 RID: 6593
		private global::System.Windows.Forms.ToolStripMenuItem xóaCacheToolStripMenuItem;

		// Token: 0x040019C2 RID: 6594
		private global::System.Windows.Forms.ToolStripMenuItem tiệnÍchToolStripMenuItem;

		// Token: 0x040019C3 RID: 6595
		private global::System.Windows.Forms.ToolStripMenuItem lọcTrùngDữLiệuToolStripMenuItem;

		// Token: 0x040019C4 RID: 6596
		private global::System.Windows.Forms.ToolStripMenuItem xửLýChuỗiOnlineToolStripMenuItem;

		// Token: 0x040019C5 RID: 6597
		private global::System.Windows.Forms.ToolStripMenuItem checkHotmailToolStripMenuItem;

		// Token: 0x040019C6 RID: 6598
		private global::MetroFramework.Controls.MetroButton btnEditFile;

		// Token: 0x040019C7 RID: 6599
		private global::System.Windows.Forms.ToolStripMenuItem checkProxyToolStripMenuItem1;

		// Token: 0x040019C8 RID: 6600
		private global::System.Windows.Forms.ToolStripMenuItem sửDụngCookieTrungGianToolStripMenuItem;

		// Token: 0x040019C9 RID: 6601
		private global::System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;

		// Token: 0x040019CA RID: 6602
		private global::System.Windows.Forms.ToolStripMenuItem giảiCheckpintNgàySinhToolStripMenuItem;

		// Token: 0x040019CB RID: 6603
		private global::System.Windows.Forms.ToolStripMenuItem cậpToolStripMenuItem;

		// Token: 0x040019CC RID: 6604
		private global::System.Windows.Forms.ToolStripMenuItem loginYandexToolStripMenuItem;

		// Token: 0x040019CD RID: 6605
		private global::System.Windows.Forms.ToolStripMenuItem gửiOTPVềMailGiaoDiệnMớiToolStripMenuItem;

		// Token: 0x040019CE RID: 6606
		private global::System.Windows.Forms.ToolStripMenuItem copyProfileToolStripMenuItem;

		// Token: 0x040019CF RID: 6607
		private global::System.Windows.Forms.ToolStripMenuItem checkLiveUidToolStripMenuItem;

		// Token: 0x040019D0 RID: 6608
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040019D1 RID: 6609
		private global::System.Windows.Forms.ToolStripMenuItem càiĐặtCấuHìnhMởToolStripMenuItem;

		// Token: 0x040019D2 RID: 6610
		private global::System.Windows.Forms.ToolStripMenuItem mởLuônToolStripMenuItem;

		// Token: 0x040019D3 RID: 6611
		private global::System.Windows.Forms.ToolStripMenuItem dọnDẹpBackupToolStripMenuItem;

		// Token: 0x040019D4 RID: 6612
		private global::System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;

		// Token: 0x040019D5 RID: 6613
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn cChose;

		// Token: 0x040019D6 RID: 6614
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x040019D7 RID: 6615
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cId;

		// Token: 0x040019D8 RID: 6616
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cUid;

		// Token: 0x040019D9 RID: 6617
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cToken;

		// Token: 0x040019DA RID: 6618
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cCookies;

		// Token: 0x040019DB RID: 6619
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cEmail;

		// Token: 0x040019DC RID: 6620
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPhone;

		// Token: 0x040019DD RID: 6621
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cName;

		// Token: 0x040019DE RID: 6622
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFollow;

		// Token: 0x040019DF RID: 6623
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFriend;

		// Token: 0x040019E0 RID: 6624
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGroup;

		// Token: 0x040019E1 RID: 6625
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cBirthday;

		// Token: 0x040019E2 RID: 6626
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGender;

		// Token: 0x040019E3 RID: 6627
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPassword;

		// Token: 0x040019E4 RID: 6628
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cMailRecovery;

		// Token: 0x040019E5 RID: 6629
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPassMail;

		// Token: 0x040019E6 RID: 6630
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cBackup;

		// Token: 0x040019E7 RID: 6631
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFa2;

		// Token: 0x040019E8 RID: 6632
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cUseragent;

		// Token: 0x040019E9 RID: 6633
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cProxy;

		// Token: 0x040019EA RID: 6634
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cDateCreateAcc;

		// Token: 0x040019EB RID: 6635
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cAvatar;

		// Token: 0x040019EC RID: 6636
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cProfile;

		// Token: 0x040019ED RID: 6637
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cThuMuc;

		// Token: 0x040019EE RID: 6638
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cInteractEnd;

		// Token: 0x040019EF RID: 6639
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cInfo;

		// Token: 0x040019F0 RID: 6640
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;

		// Token: 0x040019F1 RID: 6641
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStatus;

		// Token: 0x040019F2 RID: 6642
		public global::System.Windows.Forms.ToolStripStatusLabel lblDateExpried;

		// Token: 0x040019F3 RID: 6643
		private global::System.Windows.Forms.ToolStripMenuItem fileTxtToolStripMenuItem;

		// Token: 0x040019F4 RID: 6644
		private global::System.Windows.Forms.LinkLabel lblStatusUpdate;

		// Token: 0x040019F5 RID: 6645
		private global::System.Windows.Forms.LinkLabel lblNotify;

		// Token: 0x040019F6 RID: 6646
		private global::System.Windows.Forms.ToolStripMenuItem loginGmailToolStripMenuItem;

		// Token: 0x040019F7 RID: 6647
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040019F8 RID: 6648
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

		// Token: 0x040019F9 RID: 6649
		private global::System.Windows.Forms.ToolStripMenuItem passMailToolStripMenuItem;

		// Token: 0x040019FA RID: 6650
		private global::System.Windows.Forms.ToolStripMenuItem mởFormQuảnLýTinNhắnToolStripMenuItem;

		// Token: 0x040019FB RID: 6651
		private global::System.Windows.Forms.ToolStripMenuItem khôiPhụcMậtKhẩuToolStripMenuItem;

		// Token: 0x040019FC RID: 6652
		private global::System.Windows.Forms.ToolStripMenuItem gửiOTPVềMailMbasicbetaToolStripMenuItem;

		// Token: 0x040019FD RID: 6653
		private global::System.Windows.Forms.ToolStripMenuItem đổiPassHotmailToolStripMenuItem;

		// Token: 0x040019FE RID: 6654
		private global::System.Windows.Forms.ToolStripMenuItem giảiCP282ToolStripMenuItem;

		// Token: 0x040019FF RID: 6655
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;

		// Token: 0x04001A00 RID: 6656
		private global::System.Windows.Forms.ToolStripStatusLabel lblCountHighline;
	}
}
