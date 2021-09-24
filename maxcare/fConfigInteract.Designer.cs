namespace maxcare
{
	// Token: 0x02000131 RID: 305
	public partial class fConfigInteract : global::System.Windows.Forms.Form
	{
		// Token: 0x06000E42 RID: 3650 RVA: 0x002E3CC0 File Offset: 0x002E1EC0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x002E3D20 File Offset: 0x002E1F20
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fConfigInteract));
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.plTuongTacCMSN = new global::System.Windows.Forms.Panel();
			this.rbTuongTacCMSNDangBai = new global::System.Windows.Forms.RadioButton();
			this.rbTuongTacCMSNNhanTin = new global::System.Windows.Forms.RadioButton();
			this.label11 = new global::System.Windows.Forms.Label();
			this.nudTuongTacCMSNSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label28 = new global::System.Windows.Forms.Label();
			this.label35 = new global::System.Windows.Forms.Label();
			this.nudTuongTacCMSNDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label80 = new global::System.Windows.Forms.Label();
			this.label37 = new global::System.Windows.Forms.Label();
			this.nudTuongTacCMSNSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.label79 = new global::System.Windows.Forms.Label();
			this.nudTuongTacCMSNDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label45 = new global::System.Windows.Forms.Label();
			this.plTuongTacNhanTin = new global::System.Windows.Forms.Panel();
			this.btnInbox = new global::System.Windows.Forms.Button();
			this.label92 = new global::System.Windows.Forms.Label();
			this.label41 = new global::System.Windows.Forms.Label();
			this.nudTuongTacNhanTinSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label42 = new global::System.Windows.Forms.Label();
			this.nudTuongTacNhanTinDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label84 = new global::System.Windows.Forms.Label();
			this.label43 = new global::System.Windows.Forms.Label();
			this.nudTuongTacNhanTinDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudTuongTacNhanTinSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.label83 = new global::System.Windows.Forms.Label();
			this.label44 = new global::System.Windows.Forms.Label();
			this.plTuongTacChoc = new global::System.Windows.Forms.Panel();
			this.label36 = new global::System.Windows.Forms.Label();
			this.nudTuongTacChocSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label38 = new global::System.Windows.Forms.Label();
			this.nudTuongTacChocSoLuongDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label82 = new global::System.Windows.Forms.Label();
			this.label39 = new global::System.Windows.Forms.Label();
			this.nudTuongTacChocSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.label81 = new global::System.Windows.Forms.Label();
			this.nudTuongTacChocSoLuongDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label40 = new global::System.Windows.Forms.Label();
			this.ckbTuongTacNhanTin = new global::System.Windows.Forms.CheckBox();
			this.ckbTuongTacChoc = new global::System.Windows.Forms.CheckBox();
			this.ckbTuongTacCMSN = new global::System.Windows.Forms.CheckBox();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.plTuongTacFanpage = new global::System.Windows.Forms.Panel();
			this.label91 = new global::System.Windows.Forms.Label();
			this.label56 = new global::System.Windows.Forms.Label();
			this.nudTuongTacFanpageSoLuongPageFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label58 = new global::System.Windows.Forms.Label();
			this.label87 = new global::System.Windows.Forms.Label();
			this.label85 = new global::System.Windows.Forms.Label();
			this.button7 = new global::System.Windows.Forms.Button();
			this.nudTuongTacFanpageSoLuongBaiVietFrom = new global::System.Windows.Forms.NumericUpDown();
			this.ckbTuongTacFanpageComment = new global::System.Windows.Forms.CheckBox();
			this.btnTuongTacFanpageComment = new global::System.Windows.Forms.Button();
			this.ckbTuongTacFanpageLike = new global::System.Windows.Forms.CheckBox();
			this.label59 = new global::System.Windows.Forms.Label();
			this.label60 = new global::System.Windows.Forms.Label();
			this.nudTuongTacFanpageDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label61 = new global::System.Windows.Forms.Label();
			this.nudTuongTacFanpageDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudTuongTacFanpageSoLuongPageTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudTuongTacFanpageSoLuongBaiVietTo = new global::System.Windows.Forms.NumericUpDown();
			this.label86 = new global::System.Windows.Forms.Label();
			this.label62 = new global::System.Windows.Forms.Label();
			this.label57 = new global::System.Windows.Forms.Label();
			this.plTuongTacGroup = new global::System.Windows.Forms.Panel();
			this.label7 = new global::System.Windows.Forms.Label();
			this.nudTuongTacGroupSoLuongNhomFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label89 = new global::System.Windows.Forms.Label();
			this.label18 = new global::System.Windows.Forms.Label();
			this.nudTuongTacGroupSoLuongBaiVietFrom = new global::System.Windows.Forms.NumericUpDown();
			this.ckbTuongTacGroupComment = new global::System.Windows.Forms.CheckBox();
			this.btnTuongTacGroupComment = new global::System.Windows.Forms.Button();
			this.ckbTuongTacGroupLike = new global::System.Windows.Forms.CheckBox();
			this.label90 = new global::System.Windows.Forms.Label();
			this.label50 = new global::System.Windows.Forms.Label();
			this.label51 = new global::System.Windows.Forms.Label();
			this.nudTuongTacGroupSoLuongBaiVietTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudTuongTacGroupDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label55 = new global::System.Windows.Forms.Label();
			this.label52 = new global::System.Windows.Forms.Label();
			this.nudTuongTacGroupDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label53 = new global::System.Windows.Forms.Label();
			this.nudTuongTacGroupSoLuongNhomTo = new global::System.Windows.Forms.NumericUpDown();
			this.label88 = new global::System.Windows.Forms.Label();
			this.plTuongTacFriend = new global::System.Windows.Forms.Panel();
			this.label49 = new global::System.Windows.Forms.Label();
			this.nudTuongTacFriendSoLuongBanBeFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label68 = new global::System.Windows.Forms.Label();
			this.label54 = new global::System.Windows.Forms.Label();
			this.label19 = new global::System.Windows.Forms.Label();
			this.nudTuongTacFriendSoLuongBaiVietFrom = new global::System.Windows.Forms.NumericUpDown();
			this.ckbTuongTacFriendComment = new global::System.Windows.Forms.CheckBox();
			this.btnTuongTacFriendComment = new global::System.Windows.Forms.Button();
			this.ckbTuongTacFriendLike = new global::System.Windows.Forms.CheckBox();
			this.label33 = new global::System.Windows.Forms.Label();
			this.label46 = new global::System.Windows.Forms.Label();
			this.nudTuongTacFriendDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label47 = new global::System.Windows.Forms.Label();
			this.nudTuongTacFriendSoLuongBaiVietTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudTuongTacFriendSoLuongBanBeTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudTuongTacFriendDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label67 = new global::System.Windows.Forms.Label();
			this.label66 = new global::System.Windows.Forms.Label();
			this.label48 = new global::System.Windows.Forms.Label();
			this.plTuongTacNewsfeed = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.nudTuongTacNewsfeedSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.ckbTuongTacNewsfeedComment = new global::System.Windows.Forms.CheckBox();
			this.btnTuongTacNewsfeedComment = new global::System.Windows.Forms.Button();
			this.ckbTuongTacNewsfeedLike = new global::System.Windows.Forms.CheckBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label24 = new global::System.Windows.Forms.Label();
			this.nudTuongTacNewsfeedDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label65 = new global::System.Windows.Forms.Label();
			this.label29 = new global::System.Windows.Forms.Label();
			this.nudTuongTacNewsfeedSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudTuongTacNewsfeedDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label64 = new global::System.Windows.Forms.Label();
			this.label25 = new global::System.Windows.Forms.Label();
			this.ckbTuongTacFanpage = new global::System.Windows.Forms.CheckBox();
			this.ckbTuongTacGroup = new global::System.Windows.Forms.CheckBox();
			this.ckbTuongTacNewsfeed = new global::System.Windows.Forms.CheckBox();
			this.ckbTuongTacFriend = new global::System.Windows.Forms.CheckBox();
			this.groupBox8 = new global::System.Windows.Forms.GroupBox();
			this.ckbKetBanTuKhoa = new global::System.Windows.Forms.CheckBox();
			this.plKetBanTepUid = new global::System.Windows.Forms.Panel();
			this.ckbKetBanTepUidTrungNhau = new global::System.Windows.Forms.CheckBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.nudKetBanTepUidSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label21 = new global::System.Windows.Forms.Label();
			this.nudKetBanTepUidDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label22 = new global::System.Windows.Forms.Label();
			this.label74 = new global::System.Windows.Forms.Label();
			this.nudKetBanTepUidDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudKetBanTepUidSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.label73 = new global::System.Windows.Forms.Label();
			this.button8 = new global::System.Windows.Forms.Button();
			this.label23 = new global::System.Windows.Forms.Label();
			this.plKetBanTuKhoa = new global::System.Windows.Forms.Panel();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.txtKetBanTuKhoaTuKhoa = new global::System.Windows.Forms.TextBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.nudKetBanTuKhoaSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label9 = new global::System.Windows.Forms.Label();
			this.nudKetBanTuKhoaDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label70 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.nudKetBanTuKhoaSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.label69 = new global::System.Windows.Forms.Label();
			this.nudKetBanTuKhoaDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label15 = new global::System.Windows.Forms.Label();
			this.ckbKetBanGoiY = new global::System.Windows.Forms.CheckBox();
			this.plXacNhanKetBan = new global::System.Windows.Forms.Panel();
			this.label26 = new global::System.Windows.Forms.Label();
			this.nudXacNhanKetBanSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label27 = new global::System.Windows.Forms.Label();
			this.nudXacNhanKetBanDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label30 = new global::System.Windows.Forms.Label();
			this.nudXacNhanKetBanDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label31 = new global::System.Windows.Forms.Label();
			this.label76 = new global::System.Windows.Forms.Label();
			this.nudXacNhanKetBanSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.label75 = new global::System.Windows.Forms.Label();
			this.plKetBanGoiY = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.nudKetBanGoiYSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label4 = new global::System.Windows.Forms.Label();
			this.nudKetBanGoiYDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label5 = new global::System.Windows.Forms.Label();
			this.nudKetBanGoiYDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label72 = new global::System.Windows.Forms.Label();
			this.nudKetBanGoiYSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.label71 = new global::System.Windows.Forms.Label();
			this.ckbKetBanTepUid = new global::System.Windows.Forms.CheckBox();
			this.ckbXacNhanKetBan = new global::System.Windows.Forms.CheckBox();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.ckbThamGiaNhom = new global::System.Windows.Forms.CheckBox();
			this.plThamGiaNhom = new global::System.Windows.Forms.Panel();
			this.ckbThamGiaNhomTrungNhau = new global::System.Windows.Forms.CheckBox();
			this.ckbThamGiaNhomTraLoiCauHoi = new global::System.Windows.Forms.CheckBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.nudThamGiaNhomSoLuongFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label32 = new global::System.Windows.Forms.Label();
			this.nudThamGiaNhomDelayFrom = new global::System.Windows.Forms.NumericUpDown();
			this.label78 = new global::System.Windows.Forms.Label();
			this.label34 = new global::System.Windows.Forms.Label();
			this.nudThamGiaNhomSoLuongTo = new global::System.Windows.Forms.NumericUpDown();
			this.nudThamGiaNhomDelayTo = new global::System.Windows.Forms.NumericUpDown();
			this.btnThamGiaNhomTraLoiCauHoi = new global::System.Windows.Forms.Button();
			this.label77 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label63 = new global::System.Windows.Forms.Label();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCards1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.groupBox5.SuspendLayout();
			this.plTuongTacCMSN.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNSoLuongFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNDelayTo).BeginInit();
			this.plTuongTacNhanTin.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinSoLuongFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinSoLuongTo).BeginInit();
			this.plTuongTacChoc.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongDelayTo).BeginInit();
			this.groupBox4.SuspendLayout();
			this.plTuongTacFanpage.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongPageFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongBaiVietFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongPageTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongBaiVietTo).BeginInit();
			this.plTuongTacGroup.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongNhomFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongBaiVietFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongBaiVietTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongNhomTo).BeginInit();
			this.plTuongTacFriend.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBanBeFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBaiVietFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBaiVietTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBanBeTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendDelayTo).BeginInit();
			this.plTuongTacNewsfeed.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedSoLuongFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedDelayTo).BeginInit();
			this.groupBox8.SuspendLayout();
			this.plKetBanTepUid.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidSoLuongFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidSoLuongTo).BeginInit();
			this.plKetBanTuKhoa.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaSoLuongFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaDelayTo).BeginInit();
			this.plXacNhanKetBan.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanSoLuongFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanSoLuongTo).BeginInit();
			this.plKetBanGoiY.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYSoLuongFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYDelayTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYSoLuongTo).BeginInit();
			this.groupBox7.SuspendLayout();
			this.plThamGiaNhom.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomSoLuongFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomDelayFrom).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomSoLuongTo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomDelayTo).BeginInit();
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
			this.bunifuCards1.Size = new global::System.Drawing.Size(1012, 38);
			this.bunifuCards1.TabIndex = 0;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCak1XTXhUa2hXYldoaFVqRmFOUT09"))))))));
			this.pnlHeader.Size = new global::System.Drawing.Size(1012, 30);
			this.pnlHeader.TabIndex = 9;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.pictureBox1.Location = new global::System.Drawing.Point(5, 1);
			this.pictureBox1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaUVVUMDk="))))))));
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 77;
			this.pictureBox1.TabStop = false;
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.bunifuCustomLabel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCustomLabel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RURmFObHBGWXpWa1JsSklVbTFzWVZZelpEUT0="))))))));
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(980, 30);
			this.bunifuCustomLabel1.TabIndex = 0;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1WcE9XVmhrTkdOVldqRlhibXhEVFVoak1sSnRjRXBTZWxaMlYxWmpNV0ozUFQwPQ=="))))))));
			this.bunifuCustomLabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.btnMinimize.Location = new global::System.Drawing.Point(980, 0);
			this.btnMinimize.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaUVVUMDk="))))))));
			this.btnMinimize.Size = new global::System.Drawing.Size(32, 30);
			this.btnMinimize.TabIndex = 9;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new global::System.EventHandler(this.BtnMinimize_Click);
			this.btnCancel.BackColor = global::System.Drawing.Color.Maroon;
			this.btnCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.ForeColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(513, 675);
			this.btnCancel.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxTYmxaYVRXeGFlZz09"))))))));
			this.btnCancel.Size = new global::System.Drawing.Size(92, 29);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSklUWGxPVnpROQ=="))))))));
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new global::System.EventHandler(this.BtnCancel_Click);
			this.btnAdd.BackColor = global::System.Drawing.Color.FromArgb(53, 120, 229);
			this.btnAdd.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(409, 675);
			this.btnAdd.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSbGhWYlhNOQ=="))))))));
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtVeGFHUXlVbEpRVkRBOQ=="))))))));
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			this.groupBox5.Controls.Add(this.plTuongTacCMSN);
			this.groupBox5.Controls.Add(this.plTuongTacNhanTin);
			this.groupBox5.Controls.Add(this.plTuongTacChoc);
			this.groupBox5.Controls.Add(this.ckbTuongTacNhanTin);
			this.groupBox5.Controls.Add(this.ckbTuongTacChoc);
			this.groupBox5.Controls.Add(this.ckbTuongTacCMSN);
			this.groupBox5.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.groupBox5.Location = new global::System.Drawing.Point(662, 37);
			this.groupBox5.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwT1MyUnRVbGxSYTA1cFRUSmplQT09"))))))));
			this.groupBox5.Size = new global::System.Drawing.Size(344, 381);
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeGFHUXphSGhTYmxaaFpWVkpkMWRYVGpWUmJHdzFVVzFzV2xremJIRlpiV3hEWVZad2FtVlZSVDA9"))))))));
			this.plTuongTacCMSN.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plTuongTacCMSN.Controls.Add(this.rbTuongTacCMSNDangBai);
			this.plTuongTacCMSN.Controls.Add(this.rbTuongTacCMSNNhanTin);
			this.plTuongTacCMSN.Controls.Add(this.label11);
			this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNSoLuongFrom);
			this.plTuongTacCMSN.Controls.Add(this.button2);
			this.plTuongTacCMSN.Controls.Add(this.label28);
			this.plTuongTacCMSN.Controls.Add(this.label35);
			this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNDelayFrom);
			this.plTuongTacCMSN.Controls.Add(this.label10);
			this.plTuongTacCMSN.Controls.Add(this.label80);
			this.plTuongTacCMSN.Controls.Add(this.label37);
			this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNSoLuongTo);
			this.plTuongTacCMSN.Controls.Add(this.label79);
			this.plTuongTacCMSN.Controls.Add(this.nudTuongTacCMSNDelayTo);
			this.plTuongTacCMSN.Controls.Add(this.label45);
			this.plTuongTacCMSN.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plTuongTacCMSN.Location = new global::System.Drawing.Point(42, 256);
			this.plTuongTacCMSN.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWlhVbGhQV0ZaaFRWWktiMWRVUWs5VWJGVjNUa1F3UFE9PQ=="))))))));
			this.plTuongTacCMSN.Size = new global::System.Drawing.Size(288, 118);
			this.plTuongTacCMSN.TabIndex = 5;
			this.rbTuongTacCMSNDangBai.AutoSize = true;
			this.rbTuongTacCMSNDangBai.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbTuongTacCMSNDangBai.Location = new global::System.Drawing.Point(199, 59);
			this.rbTuongTacCMSNDangBai.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxWlhVbGhQV0ZaaFRWWktiMWRVUWs5VWJGVjNUbFZXV2xaNlZuVlZWekZIWTBFOVBRPT0="))))))));
			this.rbTuongTacCMSNDangBai.Size = new global::System.Drawing.Size(77, 20);
			this.rbTuongTacCMSNDangBai.TabIndex = 4;
			this.rbTuongTacCMSNDangBai.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VqQndiMlZyYkVOalFUMDk="))))))));
			this.rbTuongTacCMSNDangBai.UseVisualStyleBackColor = true;
			this.rbTuongTacCMSNNhanTin.AutoSize = true;
			this.rbTuongTacCMSNNhanTin.Checked = true;
			this.rbTuongTacCMSNNhanTin.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.rbTuongTacCMSNNhanTin.Location = new global::System.Drawing.Point(122, 61);
			this.rbTuongTacCMSNNhanTin.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RJeFMxWlhVbGhQV0ZaaFRWWktiMWRVUWs5VWJGVjNUbFU1YUZJd1dqRldhMlJ6WkZFOVBRPT0="))))))));
			this.rbTuongTacCMSNNhanTin.Size = new global::System.Drawing.Size(73, 20);
			this.rbTuongTacCMSNNhanTin.TabIndex = 3;
			this.rbTuongTacCMSNNhanTin.TabStop = true;
			this.rbTuongTacCMSNNhanTin.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSlhZelJsVlVwcFlWVkpkMWxXWXpCUVVUMDk="))))))));
			this.rbTuongTacCMSNNhanTin.UseVisualStyleBackColor = true;
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label11.Location = new global::System.Drawing.Point(7, 7);
			this.label11.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1ZWUXdPUT09"))))))));
			this.label11.Size = new global::System.Drawing.Size(102, 16);
			this.label11.TabIndex = 89;
			this.label11.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxU2xJd2NHOWxhM1JQWkZWc1NGTnRlRFpUVlVVNQ=="))))))));
			this.nudTuongTacCMSNSoLuongFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacCMSNSoLuongFrom.Location = new global::System.Drawing.Point(122, 4);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudTuongTacCMSNSoLuongFrom;
			int[] array = new int[4];
			array[0] = 1000;
			numericUpDown.Maximum = new decimal(array);
			this.nudTuongTacCMSNSoLuongFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ=="))))))));
			this.nudTuongTacCMSNSoLuongFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacCMSNSoLuongFrom.TabIndex = 0;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudTuongTacCMSNSoLuongFrom;
			int[] array2 = new int[4];
			array2[0] = 5;
			numericUpDown2.Value = new decimal(array2);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.button2.Location = new global::System.Drawing.Point(122, 84);
			this.button2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1dub3dPUT09"))))))));
			this.button2.Size = new global::System.Drawing.Size(58, 27);
			this.button2.TabIndex = 5;
			this.button2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVWUXdPUT09"))))))));
			this.toolTip1.SetToolTip(this.button2, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWkZoak0xWkZNWFpOYlhSdVYydG9WMlJXY0RWUmJYQm9VMFpvVGxveFpFNWFNa3BxV1Zoa05sTlZTakZYYm14RFpXMUdXRTVYT1VwU2VsWjJaSHBhVFZSWE9IcFZWREE5")))))))));
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label28.AutoSize = true;
			this.label28.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label28.Location = new global::System.Drawing.Point(7, 61);
			this.label28.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4UVVWUXdPUT09"))))))));
			this.label28.Size = new global::System.Drawing.Size(67, 16);
			this.label28.TabIndex = 89;
			this.label28.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlRCa2RWUlhaRWhPVnpsS1UwWktkbVZJU2tWVVYyUllWRlJaUFE9PQ=="))))))));
			this.label35.AutoSize = true;
			this.label35.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label35.Location = new global::System.Drawing.Point(7, 36);
			this.label35.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCUFZWUXdPUT09"))))))));
			this.label35.Size = new global::System.Drawing.Size(100, 16);
			this.label35.TabIndex = 89;
			this.label35.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudTuongTacCMSNDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacCMSNDelayFrom.Location = new global::System.Drawing.Point(122, 33);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudTuongTacCMSNDelayFrom;
			int[] array3 = new int[4];
			array3[0] = 1000;
			numericUpDown3.Maximum = new decimal(array3);
			this.nudTuongTacCMSNDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VTFJeFducFhWbWh6VWpKT2RFOVlVVDA9"))))))));
			this.nudTuongTacCMSNDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacCMSNDelayFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudTuongTacCMSNDelayFrom;
			int[] array4 = new int[4];
			array4[0] = 5;
			numericUpDown4.Value = new decimal(array4);
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label10.Location = new global::System.Drawing.Point(7, 89);
			this.label10.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1VWUXdPUT09"))))))));
			this.label10.Size = new global::System.Drawing.Size(63, 16);
			this.label10.TabIndex = 89;
			this.label10.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtoT1VFMUljRXhVYmtKS1VqRkplRmx0TVdwT1p6MDk="))))))));
			this.label80.AutoSize = true;
			this.label80.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label80.Location = new global::System.Drawing.Point(246, 8);
			this.label80.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxKT1VWUXdPUT09"))))))));
			this.label80.Size = new global::System.Drawing.Size(29, 16);
			this.label80.TabIndex = 91;
			this.label80.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhPSGxPUkRBOQ=="))))))));
			this.label37.AutoSize = true;
			this.label37.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label37.Location = new global::System.Drawing.Point(246, 38);
			this.label37.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCUFpIb3dPUT09"))))))));
			this.label37.Size = new global::System.Drawing.Size(31, 16);
			this.label37.TabIndex = 91;
			this.label37.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.nudTuongTacCMSNSoLuongTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacCMSNSoLuongTo.Location = new global::System.Drawing.Point(199, 4);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.nudTuongTacCMSNSoLuongTo;
			int[] array5 = new int[4];
			array5[0] = 1000;
			numericUpDown5.Maximum = new decimal(array5);
			this.nudTuongTacCMSNSoLuongTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9"))))))));
			this.nudTuongTacCMSNSoLuongTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacCMSNSoLuongTo.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.nudTuongTacCMSNSoLuongTo;
			int[] array6 = new int[4];
			array6[0] = 10;
			numericUpDown6.Value = new decimal(array6);
			this.label79.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label79.Location = new global::System.Drawing.Point(167, 8);
			this.label79.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWs1UVZWUXdPUT09"))))))));
			this.label79.Size = new global::System.Drawing.Size(29, 16);
			this.label79.TabIndex = 91;
			this.label79.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label79.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudTuongTacCMSNDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacCMSNDelayTo.Location = new global::System.Drawing.Point(199, 33);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.nudTuongTacCMSNDelayTo;
			int[] array7 = new int[4];
			array7[0] = 1000;
			numericUpDown7.Maximum = new decimal(array7);
			this.nudTuongTacCMSNDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VTFJeFducFhWbWh6VmxkS00xQlVNRDA9"))))))));
			this.nudTuongTacCMSNDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacCMSNDelayTo.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.nudTuongTacCMSNDelayTo;
			int[] array8 = new int[4];
			array8[0] = 10;
			numericUpDown8.Value = new decimal(array8);
			this.label45.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label45.Location = new global::System.Drawing.Point(167, 38);
			this.label45.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtKUFZWUXdPUT09"))))))));
			this.label45.Size = new global::System.Drawing.Size(29, 16);
			this.label45.TabIndex = 91;
			this.label45.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label45.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.plTuongTacNhanTin.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plTuongTacNhanTin.Controls.Add(this.btnInbox);
			this.plTuongTacNhanTin.Controls.Add(this.label92);
			this.plTuongTacNhanTin.Controls.Add(this.label41);
			this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinSoLuongFrom);
			this.plTuongTacNhanTin.Controls.Add(this.label42);
			this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinDelayFrom);
			this.plTuongTacNhanTin.Controls.Add(this.label84);
			this.plTuongTacNhanTin.Controls.Add(this.label43);
			this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinDelayTo);
			this.plTuongTacNhanTin.Controls.Add(this.nudTuongTacNhanTinSoLuongTo);
			this.plTuongTacNhanTin.Controls.Add(this.label83);
			this.plTuongTacNhanTin.Controls.Add(this.label44);
			this.plTuongTacNhanTin.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plTuongTacNhanTin.Location = new global::System.Drawing.Point(42, 45);
			this.plTuongTacNhanTin.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWlhVbGhQV0ZaaFRWWktiMWRVUVRGaU1XeFlUbFpXYUZaNlVUaz0="))))))));
			this.plTuongTacNhanTin.Size = new global::System.Drawing.Size(288, 90);
			this.plTuongTacNhanTin.TabIndex = 1;
			this.btnInbox.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnInbox.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnInbox.Location = new global::System.Drawing.Point(122, 2);
			this.btnInbox.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldUbGhPVjJ4cFRUSmpPUT09"))))))));
			this.btnInbox.Size = new global::System.Drawing.Size(78, 27);
			this.btnInbox.TabIndex = 1;
			this.btnInbox.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVWUXdPUT09"))))))));
			this.toolTip1.SetToolTip(this.btnInbox, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVFVkR1dFNUhaR2xpVjNCR1ducG9OVkZ0U201UVZEQTk=")))))))));
			this.btnInbox.UseVisualStyleBackColor = true;
			this.btnInbox.Click += new global::System.EventHandler(this.btnInbox_Click);
			this.label92.AutoSize = true;
			this.label92.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label92.Location = new global::System.Drawing.Point(3, 6);
			this.label92.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxaT1dub3dPUT09"))))))));
			this.label92.Size = new global::System.Drawing.Size(122, 16);
			this.label92.TabIndex = 0;
			this.label92.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5BelRtdGFjVmxWVGtOTlIwWllUa2RrYVdKWGNHOWtXRVUxWkZVNWJsQlVNRDA9"))))))));
			this.label41.AutoSize = true;
			this.label41.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label41.Location = new global::System.Drawing.Point(3, 36);
			this.label41.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtKT1ZWUXdPUT09"))))))));
			this.label41.Size = new global::System.Drawing.Size(107, 16);
			this.label41.TabIndex = 89;
			this.label41.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxU2xJd2NHOWxhM1JQWkZWc1NGTnRlRFpUVlVVeQ=="))))))));
			this.nudTuongTacNhanTinSoLuongFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacNhanTinSoLuongFrom.Location = new global::System.Drawing.Point(123, 33);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.nudTuongTacNhanTinSoLuongFrom;
			int[] array9 = new int[4];
			array9[0] = 1000;
			numericUpDown9.Maximum = new decimal(array9);
			this.nudTuongTacNhanTinSoLuongFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERldWRWsxVkZkU1dFOVlWbUZOUm5BMVdXcEpkMUJSUFQwPQ=="))))))));
			this.nudTuongTacNhanTinSoLuongFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacNhanTinSoLuongFrom.TabIndex = 0;
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.nudTuongTacNhanTinSoLuongFrom;
			int[] array10 = new int[4];
			array10[0] = 5;
			numericUpDown10.Value = new decimal(array10);
			this.label42.AutoSize = true;
			this.label42.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label42.Location = new global::System.Drawing.Point(3, 63);
			this.label42.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtKT1dub3dPUT09"))))))));
			this.label42.Size = new global::System.Drawing.Size(100, 16);
			this.label42.TabIndex = 89;
			this.label42.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudTuongTacNhanTinDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacNhanTinDelayFrom.Location = new global::System.Drawing.Point(123, 60);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.nudTuongTacNhanTinDelayFrom;
			int[] array11 = new int[4];
			array11[0] = 1000;
			numericUpDown11.Maximum = new decimal(array11);
			this.nudTuongTacNhanTinDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERlZhMlJYWXpGc1dXSkZaR3BpVkd3dw=="))))))));
			this.nudTuongTacNhanTinDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacNhanTinDelayFrom.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.nudTuongTacNhanTinDelayFrom;
			int[] array12 = new int[4];
			array12[0] = 5;
			numericUpDown12.Value = new decimal(array12);
			this.label84.AutoSize = true;
			this.label84.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label84.Location = new global::System.Drawing.Point(247, 37);
			this.label84.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxKUFVWUXdPUT09"))))))));
			this.label84.Size = new global::System.Drawing.Size(29, 16);
			this.label84.TabIndex = 91;
			this.label84.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhPSGxPUkRBOQ=="))))))));
			this.label43.AutoSize = true;
			this.label43.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label43.Location = new global::System.Drawing.Point(247, 65);
			this.label43.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtKT1pIb3dPUT09"))))))));
			this.label43.Size = new global::System.Drawing.Size(31, 16);
			this.label43.TabIndex = 91;
			this.label43.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.nudTuongTacNhanTinDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacNhanTinDelayTo.Location = new global::System.Drawing.Point(200, 61);
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.nudTuongTacNhanTinDelayTo;
			int[] array13 = new int[4];
			array13[0] = 1000;
			numericUpDown13.Maximum = new decimal(array13);
			this.nudTuongTacNhanTinDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERlZhMlJYWXpGc1dXSkdWbWxrZWpBNQ=="))))))));
			this.nudTuongTacNhanTinDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacNhanTinDelayTo.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.nudTuongTacNhanTinDelayTo;
			int[] array14 = new int[4];
			array14[0] = 10;
			numericUpDown14.Value = new decimal(array14);
			this.nudTuongTacNhanTinSoLuongTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacNhanTinSoLuongTo.Location = new global::System.Drawing.Point(200, 33);
			global::System.Windows.Forms.NumericUpDown numericUpDown15 = this.nudTuongTacNhanTinSoLuongTo;
			int[] array15 = new int[4];
			array15[0] = 1000;
			numericUpDown15.Maximum = new decimal(array15);
			this.nudTuongTacNhanTinSoLuongTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERldWRWsxVkZkU1dFOVlWbUZOVmtveQ=="))))))));
			this.nudTuongTacNhanTinSoLuongTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacNhanTinSoLuongTo.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown16 = this.nudTuongTacNhanTinSoLuongTo;
			int[] array16 = new int[4];
			array16[0] = 10;
			numericUpDown16.Value = new decimal(array16);
			this.label83.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label83.Location = new global::System.Drawing.Point(168, 37);
			this.label83.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxKT1pIb3dPUT09"))))))));
			this.label83.Size = new global::System.Drawing.Size(29, 16);
			this.label83.TabIndex = 91;
			this.label83.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label83.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label44.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label44.Location = new global::System.Drawing.Point(168, 65);
			this.label44.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtKUFVWUXdPUT09"))))))));
			this.label44.Size = new global::System.Drawing.Size(29, 16);
			this.label44.TabIndex = 91;
			this.label44.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label44.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.plTuongTacChoc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plTuongTacChoc.Controls.Add(this.label36);
			this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongFrom);
			this.plTuongTacChoc.Controls.Add(this.label38);
			this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongDelayFrom);
			this.plTuongTacChoc.Controls.Add(this.label82);
			this.plTuongTacChoc.Controls.Add(this.label39);
			this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongTo);
			this.plTuongTacChoc.Controls.Add(this.label81);
			this.plTuongTacChoc.Controls.Add(this.nudTuongTacChocSoLuongDelayTo);
			this.plTuongTacChoc.Controls.Add(this.label40);
			this.plTuongTacChoc.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plTuongTacChoc.Location = new global::System.Drawing.Point(42, 163);
			this.plTuongTacChoc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWlhVbGhQV0ZaaFRWWktiMWRVUWs5aU1rbDVWRlF3UFE9PQ=="))))))));
			this.plTuongTacChoc.Size = new global::System.Drawing.Size(288, 65);
			this.plTuongTacChoc.TabIndex = 3;
			this.label36.AutoSize = true;
			this.label36.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label36.Location = new global::System.Drawing.Point(3, 8);
			this.label36.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCUFdub3dPUT09"))))))));
			this.label36.Size = new global::System.Drawing.Size(107, 16);
			this.label36.TabIndex = 89;
			this.label36.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxU2xJd2NHOWxhM1JQWkZWc1NGTnRlRFpUVlVVeQ=="))))))));
			this.nudTuongTacChocSoLuongFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacChocSoLuongFrom.Location = new global::System.Drawing.Point(122, 5);
			global::System.Windows.Forms.NumericUpDown numericUpDown17 = this.nudTuongTacChocSoLuongFrom;
			int[] array17 = new int[4];
			array17[0] = 1000;
			numericUpDown17.Maximum = new decimal(array17);
			this.nudTuongTacChocSoLuongFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ=="))))))));
			this.nudTuongTacChocSoLuongFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacChocSoLuongFrom.TabIndex = 0;
			global::System.Windows.Forms.NumericUpDown numericUpDown18 = this.nudTuongTacChocSoLuongFrom;
			int[] array18 = new int[4];
			array18[0] = 5;
			numericUpDown18.Value = new decimal(array18);
			this.label38.AutoSize = true;
			this.label38.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label38.Location = new global::System.Drawing.Point(3, 37);
			this.label38.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCUVVWUXdPUT09"))))))));
			this.label38.Size = new global::System.Drawing.Size(100, 16);
			this.label38.TabIndex = 89;
			this.label38.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudTuongTacChocSoLuongDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacChocSoLuongDelayFrom.Location = new global::System.Drawing.Point(122, 34);
			global::System.Windows.Forms.NumericUpDown numericUpDown19 = this.nudTuongTacChocSoLuongDelayFrom;
			int[] array19 = new int[4];
			array19[0] = 1000;
			numericUpDown19.Maximum = new decimal(array19);
			this.nudTuongTacChocSoLuongDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmQxVnRlR2xTTUZreFZXMDFTMlJ0U2xKUVZEQTk="))))))));
			this.nudTuongTacChocSoLuongDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacChocSoLuongDelayFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown20 = this.nudTuongTacChocSoLuongDelayFrom;
			int[] array20 = new int[4];
			array20[0] = 5;
			numericUpDown20.Value = new decimal(array20);
			this.label82.AutoSize = true;
			this.label82.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label82.Location = new global::System.Drawing.Point(246, 10);
			this.label82.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxKT1dub3dPUT09"))))))));
			this.label82.Size = new global::System.Drawing.Size(29, 16);
			this.label82.TabIndex = 91;
			this.label82.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhPSGxPUkRBOQ=="))))))));
			this.label39.AutoSize = true;
			this.label39.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label39.Location = new global::System.Drawing.Point(246, 39);
			this.label39.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCUVZWUXdPUT09"))))))));
			this.label39.Size = new global::System.Drawing.Size(31, 16);
			this.label39.TabIndex = 91;
			this.label39.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.nudTuongTacChocSoLuongTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacChocSoLuongTo.Location = new global::System.Drawing.Point(199, 5);
			global::System.Windows.Forms.NumericUpDown numericUpDown21 = this.nudTuongTacChocSoLuongTo;
			int[] array21 = new int[4];
			array21[0] = 1000;
			numericUpDown21.Maximum = new decimal(array21);
			this.nudTuongTacChocSoLuongTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9"))))))));
			this.nudTuongTacChocSoLuongTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacChocSoLuongTo.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown22 = this.nudTuongTacChocSoLuongTo;
			int[] array22 = new int[4];
			array22[0] = 10;
			numericUpDown22.Value = new decimal(array22);
			this.label81.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label81.Location = new global::System.Drawing.Point(167, 10);
			this.label81.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxKT1ZWUXdPUT09"))))))));
			this.label81.Size = new global::System.Drawing.Size(29, 16);
			this.label81.TabIndex = 91;
			this.label81.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label81.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudTuongTacChocSoLuongDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacChocSoLuongDelayTo.Location = new global::System.Drawing.Point(199, 34);
			global::System.Windows.Forms.NumericUpDown numericUpDown23 = this.nudTuongTacChocSoLuongDelayTo;
			int[] array23 = new int[4];
			array23[0] = 1000;
			numericUpDown23.Maximum = new decimal(array23);
			this.nudTuongTacChocSoLuongDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmQxVnRlR2xTTUZreFZtdGpORkJSUFQwPQ=="))))))));
			this.nudTuongTacChocSoLuongDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacChocSoLuongDelayTo.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown24 = this.nudTuongTacChocSoLuongDelayTo;
			int[] array24 = new int[4];
			array24[0] = 10;
			numericUpDown24.Value = new decimal(array24);
			this.label40.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label40.Location = new global::System.Drawing.Point(167, 39);
			this.label40.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtKT1VWUXdPUT09"))))))));
			this.label40.Size = new global::System.Drawing.Size(29, 16);
			this.label40.TabIndex = 91;
			this.label40.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label40.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ckbTuongTacNhanTin.AutoSize = true;
			this.ckbTuongTacNhanTin.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacNhanTin.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacNhanTin.Location = new global::System.Drawing.Point(23, 22);
			this.ckbTuongTacNhanTin.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERT0="))))))));
			this.ckbTuongTacNhanTin.Size = new global::System.Drawing.Size(74, 20);
			this.ckbTuongTacNhanTin.TabIndex = 0;
			this.ckbTuongTacNhanTin.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSlhZelJsVlVwcFlWVkpkMWxXWXpCUVVUMDk="))))))));
			this.ckbTuongTacNhanTin.UseVisualStyleBackColor = true;
			this.ckbTuongTacNhanTin.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacNhanTin_CheckedChanged);
			this.ckbTuongTacChoc.AutoSize = true;
			this.ckbTuongTacChoc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacChoc.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacChoc.Location = new global::System.Drawing.Point(23, 140);
			this.ckbTuongTacChoc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR2UFE9PQ=="))))))));
			this.ckbTuongTacChoc.Size = new global::System.Drawing.Size(98, 20);
			this.ckbTuongTacChoc.TabIndex = 2;
			this.ckbTuongTacChoc.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IyUnVjRXhVYlhCS1VqQndiMlZyZEU5a1ZXeElVMjE0TmxOVlJUaz0="))))))));
			this.ckbTuongTacChoc.UseVisualStyleBackColor = true;
			this.ckbTuongTacChoc.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacChoc_CheckedChanged);
			this.ckbTuongTacCMSN.AutoSize = true;
			this.ckbTuongTacCMSN.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacCMSN.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacCMSN.Location = new global::System.Drawing.Point(23, 233);
			this.ckbTuongTacCMSN.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M0UFE9PQ=="))))))));
			this.ckbTuongTacCMSN.Size = new global::System.Drawing.Size(148, 20);
			this.ckbTuongTacCMSN.TabIndex = 4;
			this.ckbTuongTacCMSN.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IwMVljRXBTYlhCS1VucE9TR013TVRWUlYwcDBXVEprYWsxdGVERlpWVTVEWkZkR1RsUXliRFpUTURSMw=="))))))));
			this.ckbTuongTacCMSN.UseVisualStyleBackColor = true;
			this.ckbTuongTacCMSN.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacCMSN_CheckedChanged);
			this.groupBox4.Controls.Add(this.plTuongTacFanpage);
			this.groupBox4.Controls.Add(this.plTuongTacGroup);
			this.groupBox4.Controls.Add(this.plTuongTacFriend);
			this.groupBox4.Controls.Add(this.plTuongTacNewsfeed);
			this.groupBox4.Controls.Add(this.ckbTuongTacFanpage);
			this.groupBox4.Controls.Add(this.ckbTuongTacGroup);
			this.groupBox4.Controls.Add(this.ckbTuongTacNewsfeed);
			this.groupBox4.Controls.Add(this.ckbTuongTacFriend);
			this.groupBox4.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.groupBox4.Location = new global::System.Drawing.Point(7, 37);
			this.groupBox4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwT1MyUnRVbGxSYTA1cFRUSmpkdz09"))))))));
			this.groupBox4.Size = new global::System.Drawing.Size(649, 381);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeGFHUXphSGhTYmxaaFpWVkpkMWRYVGpWUmJHdzFVVzFzV2xremJFSlpWazVEVFcxR2FsUXpSalpUVlZsMw=="))))))));
			this.plTuongTacFanpage.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plTuongTacFanpage.Controls.Add(this.label91);
			this.plTuongTacFanpage.Controls.Add(this.label56);
			this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongPageFrom);
			this.plTuongTacFanpage.Controls.Add(this.label58);
			this.plTuongTacFanpage.Controls.Add(this.button7);
			this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongBaiVietFrom);
			this.plTuongTacFanpage.Controls.Add(this.ckbTuongTacFanpageComment);
			this.plTuongTacFanpage.Controls.Add(this.btnTuongTacFanpageComment);
			this.plTuongTacFanpage.Controls.Add(this.ckbTuongTacFanpageLike);
			this.plTuongTacFanpage.Controls.Add(this.label59);
			this.plTuongTacFanpage.Controls.Add(this.label60);
			this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageDelayFrom);
			this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageDelayTo);
			this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongPageTo);
			this.plTuongTacFanpage.Controls.Add(this.nudTuongTacFanpageSoLuongBaiVietTo);
			this.plTuongTacFanpage.Controls.Add(this.label86);
			this.plTuongTacFanpage.Controls.Add(this.label62);
			this.plTuongTacFanpage.Controls.Add(this.label57);
			this.plTuongTacFanpage.Controls.Add(this.label87);
			this.plTuongTacFanpage.Controls.Add(this.label85);
			this.plTuongTacFanpage.Controls.Add(this.label61);
			this.plTuongTacFanpage.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plTuongTacFanpage.Location = new global::System.Drawing.Point(41, 198);
			this.plTuongTacFanpage.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWlhVbGhQV0ZaaFRWWktiMWRVUW1GaFIwcDFVVzFvWVUxc1ZUaz0="))))))));
			this.plTuongTacFanpage.Size = new global::System.Drawing.Size(278, 176);
			this.plTuongTacFanpage.TabIndex = 97;
			this.label91.AutoSize = true;
			this.label91.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label91.Location = new global::System.Drawing.Point(7, 8);
			this.label91.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxaT1ZWUXdPUT09"))))))));
			this.label91.Size = new global::System.Drawing.Size(90, 16);
			this.label91.TabIndex = 0;
			this.label91.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VsZDRSbE5WV2tOaFJtOTVWbFJaUFE9PQ=="))))))));
			this.label56.AutoSize = true;
			this.label56.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label56.Location = new global::System.Drawing.Point(7, 38);
			this.label56.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaUFdub3dPUT09"))))))));
			this.label56.Size = new global::System.Drawing.Size(96, 16);
			this.label56.TabIndex = 0;
			this.label56.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxU2xORlNtOVhha3BXVG1jOVBRPT0="))))))));
			this.nudTuongTacFanpageSoLuongPageFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFanpageSoLuongPageFrom.Location = new global::System.Drawing.Point(117, 35);
			global::System.Windows.Forms.NumericUpDown numericUpDown25 = this.nudTuongTacFanpageSoLuongPageFrom;
			int[] array25 = new int[4];
			array25[0] = 1000;
			numericUpDown25.Maximum = new decimal(array25);
			this.nudTuongTacFanpageSoLuongPageFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOVlVwdlYycEtWMUl5VG5SUFdGRTk="))))))));
			this.nudTuongTacFanpageSoLuongPageFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacFanpageSoLuongPageFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown26 = this.nudTuongTacFanpageSoLuongPageFrom;
			int[] array26 = new int[4];
			array26[0] = 5;
			numericUpDown26.Value = new decimal(array26);
			this.label58.AutoSize = true;
			this.label58.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label58.Location = new global::System.Drawing.Point(7, 67);
			this.label58.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaUVVWUXdPUT09"))))))));
			this.label58.Size = new global::System.Drawing.Size(106, 16);
			this.label58.TabIndex = 89;
			this.label58.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJSYVlsVm9UbG93WkhKYU1sSjBZbXRTZUdNemJFTmFSVTAxWkRGc1dGcEhlRkJhZWpBNQ=="))))))));
			this.label87.AutoSize = true;
			this.label87.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label87.Location = new global::System.Drawing.Point(239, 38);
			this.label87.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxKUFpIb3dPUT09"))))))));
			this.label87.Size = new global::System.Drawing.Size(36, 16);
			this.label87.TabIndex = 89;
			this.label87.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IySnNjRkpRVkRBOQ=="))))))));
			this.label85.AutoSize = true;
			this.label85.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label85.Location = new global::System.Drawing.Point(239, 67);
			this.label85.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxKUFZWUXdPUT09"))))))));
			this.label85.Size = new global::System.Drawing.Size(25, 16);
			this.label85.TabIndex = 89;
			this.label85.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhaRWhoZWpBOQ=="))))))));
			this.button7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button7.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.button7.Location = new global::System.Drawing.Point(116, 3);
			this.button7.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUFpIb3dPUT09"))))))));
			this.button7.Size = new global::System.Drawing.Size(75, 27);
			this.button7.TabIndex = 2;
			this.button7.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNXRklWbmhOV0dNOQ=="))))))));
			this.toolTip1.SetToolTip(this.button7, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVTJ4S1JGRnNSbHBXTWxKeg==")))))))));
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.nudTuongTacFanpageSoLuongBaiVietFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFanpageSoLuongBaiVietFrom.Location = new global::System.Drawing.Point(117, 64);
			global::System.Windows.Forms.NumericUpDown numericUpDown27 = this.nudTuongTacFanpageSoLuongBaiVietFrom;
			int[] array27 = new int[4];
			array27[0] = 1000;
			numericUpDown27.Maximum = new decimal(array27);
			this.nudTuongTacFanpageSoLuongBaiVietFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOUlhCdldWWmFZV05HY0ZsVmEyUnFZbFJzTUE9PQ=="))))))));
			this.nudTuongTacFanpageSoLuongBaiVietFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacFanpageSoLuongBaiVietFrom.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown28 = this.nudTuongTacFanpageSoLuongBaiVietFrom;
			int[] array28 = new int[4];
			array28[0] = 5;
			numericUpDown28.Value = new decimal(array28);
			this.ckbTuongTacFanpageComment.AutoSize = true;
			this.ckbTuongTacFanpageComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacFanpageComment.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacFanpageComment.Location = new global::System.Drawing.Point(117, 144);
			this.ckbTuongTacFanpageComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTlZWRWsxWkVkS1dGWnVWbXRSVkRBNQ=="))))))));
			this.ckbTuongTacFanpageComment.Size = new global::System.Drawing.Size(82, 20);
			this.ckbTuongTacFanpageComment.TabIndex = 7;
			this.ckbTuongTacFanpageComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUkhTbGhXYmxaclVWUXdPUT09"))))))));
			this.ckbTuongTacFanpageComment.UseVisualStyleBackColor = true;
			this.ckbTuongTacFanpageComment.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacFanpageComment_CheckedChanged);
			this.btnTuongTacFanpageComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnTuongTacFanpageComment.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.btnTuongTacFanpageComment.Location = new global::System.Drawing.Point(208, 140);
			this.btnTuongTacFanpageComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTlZWRWsxWkVkS1dGWnVWbXRSVkRBNQ=="))))))));
			this.btnTuongTacFanpageComment.Size = new global::System.Drawing.Size(58, 27);
			this.btnTuongTacFanpageComment.TabIndex = 8;
			this.btnTuongTacFanpageComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVWUXdPUT09"))))))));
			this.toolTip1.SetToolTip(this.btnTuongTacFanpageComment, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWVZkR2FtVlZSbWxpVjJSdVdXdG9XVkpIT1hwbFYzQnBXbm93T1E9PQ==")))))))));
			this.btnTuongTacFanpageComment.UseVisualStyleBackColor = true;
			this.btnTuongTacFanpageComment.Click += new global::System.EventHandler(this.button6_Click);
			this.ckbTuongTacFanpageLike.AutoSize = true;
			this.ckbTuongTacFanpageLike.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacFanpageLike.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacFanpageLike.Location = new global::System.Drawing.Point(117, 121);
			this.ckbTuongTacFanpageLike.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldSV1J6WTJ4d1VsQlVNRDA9"))))))));
			this.ckbTuongTacFanpageLike.Size = new global::System.Drawing.Size(49, 20);
			this.ckbTuongTacFanpageLike.TabIndex = 6;
			this.ckbTuongTacFanpageLike.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWa2MyTnNjRkpRVkRBOQ=="))))))));
			this.ckbTuongTacFanpageLike.UseVisualStyleBackColor = true;
			this.label59.AutoSize = true;
			this.label59.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label59.Location = new global::System.Drawing.Point(7, 122);
			this.label59.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaUVZWUXdPUT09"))))))));
			this.label59.Size = new global::System.Drawing.Size(94, 16);
			this.label59.TabIndex = 89;
			this.label59.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWak5XRkljRXhVYmtKS1UwWlNTR013TVdoaFIwcDBXVEprYTFJd2FFNWFNV1JPVG1jOVBRPT0="))))))));
			this.label60.AutoSize = true;
			this.label60.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label60.Location = new global::System.Drawing.Point(7, 96);
			this.label60.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtwT1VWUXdPUT09"))))))));
			this.label60.Size = new global::System.Drawing.Size(100, 16);
			this.label60.TabIndex = 89;
			this.label60.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudTuongTacFanpageDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFanpageDelayFrom.Location = new global::System.Drawing.Point(117, 93);
			global::System.Windows.Forms.NumericUpDown numericUpDown29 = this.nudTuongTacFanpageDelayFrom;
			int[] array29 = new int[4];
			array29[0] = 1000;
			numericUpDown29.Maximum = new decimal(array29);
			this.nudTuongTacFanpageDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTlZhMlJYWXpGc1dXSkZaR3BpVkd3dw=="))))))));
			this.nudTuongTacFanpageDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacFanpageDelayFrom.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown30 = this.nudTuongTacFanpageDelayFrom;
			int[] array30 = new int[4];
			array30[0] = 5;
			numericUpDown30.Value = new decimal(array30);
			this.label61.AutoSize = true;
			this.label61.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label61.Location = new global::System.Drawing.Point(239, 98);
			this.label61.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtwT1ZWUXdPUT09"))))))));
			this.label61.Size = new global::System.Drawing.Size(31, 16);
			this.label61.TabIndex = 91;
			this.label61.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.nudTuongTacFanpageDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFanpageDelayTo.Location = new global::System.Drawing.Point(194, 94);
			global::System.Windows.Forms.NumericUpDown numericUpDown31 = this.nudTuongTacFanpageDelayTo;
			int[] array31 = new int[4];
			array31[0] = 1000;
			numericUpDown31.Maximum = new decimal(array31);
			this.nudTuongTacFanpageDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTlZhMlJYWXpGc1dXSkdWbWxrZWpBNQ=="))))))));
			this.nudTuongTacFanpageDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacFanpageDelayTo.TabIndex = 5;
			global::System.Windows.Forms.NumericUpDown numericUpDown32 = this.nudTuongTacFanpageDelayTo;
			int[] array32 = new int[4];
			array32[0] = 10;
			numericUpDown32.Value = new decimal(array32);
			this.nudTuongTacFanpageSoLuongPageTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFanpageSoLuongPageTo.Location = new global::System.Drawing.Point(194, 36);
			global::System.Windows.Forms.NumericUpDown numericUpDown33 = this.nudTuongTacFanpageSoLuongPageTo;
			int[] array33 = new int[4];
			array33[0] = 1000;
			numericUpDown33.Maximum = new decimal(array33);
			this.nudTuongTacFanpageSoLuongPageTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOVlVwdlYycEtWMVpYU2pOUVZEQTk="))))))));
			this.nudTuongTacFanpageSoLuongPageTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacFanpageSoLuongPageTo.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown34 = this.nudTuongTacFanpageSoLuongPageTo;
			int[] array34 = new int[4];
			array34[0] = 10;
			numericUpDown34.Value = new decimal(array34);
			this.nudTuongTacFanpageSoLuongBaiVietTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFanpageSoLuongBaiVietTo.Location = new global::System.Drawing.Point(194, 65);
			global::System.Windows.Forms.NumericUpDown numericUpDown35 = this.nudTuongTacFanpageSoLuongBaiVietTo;
			int[] array35 = new int[4];
			array35[0] = 1000;
			numericUpDown35.Maximum = new decimal(array35);
			this.nudTuongTacFanpageSoLuongBaiVietTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOUlhCdldWWmFZV05HY0ZsVmJGWnBaSG93T1E9PQ=="))))))));
			this.nudTuongTacFanpageSoLuongBaiVietTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacFanpageSoLuongBaiVietTo.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown36 = this.nudTuongTacFanpageSoLuongBaiVietTo;
			int[] array36 = new int[4];
			array36[0] = 10;
			numericUpDown36.Value = new decimal(array36);
			this.label86.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label86.Location = new global::System.Drawing.Point(162, 38);
			this.label86.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxKUFdub3dPUT09"))))))));
			this.label86.Size = new global::System.Drawing.Size(29, 16);
			this.label86.TabIndex = 91;
			this.label86.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label86.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label62.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label62.Location = new global::System.Drawing.Point(162, 98);
			this.label62.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtwT1dub3dPUT09"))))))));
			this.label62.Size = new global::System.Drawing.Size(29, 16);
			this.label62.TabIndex = 91;
			this.label62.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label62.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label57.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label57.Location = new global::System.Drawing.Point(162, 67);
			this.label57.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaUFpIb3dPUT09"))))))));
			this.label57.Size = new global::System.Drawing.Size(29, 16);
			this.label57.TabIndex = 91;
			this.label57.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label57.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.plTuongTacGroup.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plTuongTacGroup.Controls.Add(this.label7);
			this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongNhomFrom);
			this.plTuongTacGroup.Controls.Add(this.label18);
			this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongBaiVietFrom);
			this.plTuongTacGroup.Controls.Add(this.ckbTuongTacGroupComment);
			this.plTuongTacGroup.Controls.Add(this.btnTuongTacGroupComment);
			this.plTuongTacGroup.Controls.Add(this.ckbTuongTacGroupLike);
			this.plTuongTacGroup.Controls.Add(this.label50);
			this.plTuongTacGroup.Controls.Add(this.label51);
			this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongBaiVietTo);
			this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupDelayFrom);
			this.plTuongTacGroup.Controls.Add(this.label55);
			this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupDelayTo);
			this.plTuongTacGroup.Controls.Add(this.label53);
			this.plTuongTacGroup.Controls.Add(this.nudTuongTacGroupSoLuongNhomTo);
			this.plTuongTacGroup.Controls.Add(this.label88);
			this.plTuongTacGroup.Controls.Add(this.label89);
			this.plTuongTacGroup.Controls.Add(this.label90);
			this.plTuongTacGroup.Controls.Add(this.label52);
			this.plTuongTacGroup.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plTuongTacGroup.Location = new global::System.Drawing.Point(358, 225);
			this.plTuongTacGroup.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWlhVbGhQV0ZaaFRWWktiMWRVUW10bFYwbDZWbTVqUFE9PQ=="))))))));
			this.plTuongTacGroup.Size = new global::System.Drawing.Size(278, 149);
			this.plTuongTacGroup.TabIndex = 6;
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label7.Location = new global::System.Drawing.Point(7, 8);
			this.label7.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWswOQ=="))))))));
			this.label7.Size = new global::System.Drawing.Size(100, 16);
			this.label7.TabIndex = 89;
			this.label7.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxU2xKNlZuWlphbWcxVVcxS1ZXSjZNRDA9"))))))));
			this.nudTuongTacGroupSoLuongNhomFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacGroupSoLuongNhomFrom.Location = new global::System.Drawing.Point(117, 5);
			global::System.Windows.Forms.NumericUpDown numericUpDown37 = this.nudTuongTacGroupSoLuongNhomFrom;
			int[] array37 = new int[4];
			array37[0] = 1000;
			numericUpDown37.Maximum = new decimal(array37);
			this.nudTuongTacGroupSoLuongNhomFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZPV2hTZW13d1ZXMDFTMlJ0U2xKUVZEQTk="))))))));
			this.nudTuongTacGroupSoLuongNhomFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacGroupSoLuongNhomFrom.TabIndex = 0;
			global::System.Windows.Forms.NumericUpDown numericUpDown38 = this.nudTuongTacGroupSoLuongNhomFrom;
			int[] array38 = new int[4];
			array38[0] = 5;
			numericUpDown38.Value = new decimal(array38);
			this.label89.AutoSize = true;
			this.label89.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label89.Location = new global::System.Drawing.Point(239, 8);
			this.label89.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxKUVZWUXdPUT09"))))))));
			this.label89.Size = new global::System.Drawing.Size(40, 16);
			this.label89.TabIndex = 89;
			this.label89.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cweGIyUnVjRXBTYmxFOQ=="))))))));
			this.label18.AutoSize = true;
			this.label18.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label18.Location = new global::System.Drawing.Point(7, 37);
			this.label18.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUVVWUXdPUT09"))))))));
			this.label18.Size = new global::System.Drawing.Size(110, 16);
			this.label18.TabIndex = 89;
			this.label18.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJSYVlsVm9UbG93WkhKYU1sSjBZbXRTZUdNemJFTmFSVTAxWkZkR1NFd3dNVzVXZWtFeQ=="))))))));
			this.nudTuongTacGroupSoLuongBaiVietFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacGroupSoLuongBaiVietFrom.Location = new global::System.Drawing.Point(117, 34);
			global::System.Windows.Forms.NumericUpDown numericUpDown39 = this.nudTuongTacGroupSoLuongBaiVietFrom;
			int[] array39 = new int[4];
			array39[0] = 1000;
			numericUpDown39.Maximum = new decimal(array39);
			this.nudTuongTacGroupSoLuongBaiVietFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZUbHBXTW5oWVdWWmtWMDFHU25WVGJscHBWVlF3T1E9PQ=="))))))));
			this.nudTuongTacGroupSoLuongBaiVietFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacGroupSoLuongBaiVietFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown40 = this.nudTuongTacGroupSoLuongBaiVietFrom;
			int[] array40 = new int[4];
			array40[0] = 5;
			numericUpDown40.Value = new decimal(array40);
			this.ckbTuongTacGroupComment.AutoSize = true;
			this.ckbTuongTacGroupComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacGroupComment.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacGroupComment.Location = new global::System.Drawing.Point(117, 117);
			this.ckbTuongTacGroupComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKVk5USlpiR040WWtkS2RWVlVNRDA9"))))))));
			this.ckbTuongTacGroupComment.Size = new global::System.Drawing.Size(82, 20);
			this.ckbTuongTacGroupComment.TabIndex = 5;
			this.ckbTuongTacGroupComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUkhTbGhXYmxaclVWUXdPUT09"))))))));
			this.ckbTuongTacGroupComment.UseVisualStyleBackColor = true;
			this.ckbTuongTacGroupComment.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacGroupComment_CheckedChanged);
			this.btnTuongTacGroupComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnTuongTacGroupComment.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.btnTuongTacGroupComment.Location = new global::System.Drawing.Point(208, 113);
			this.btnTuongTacGroupComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKVk5USlpiR040WWtkS2RWVlVNRDA9"))))))));
			this.btnTuongTacGroupComment.Size = new global::System.Drawing.Size(58, 27);
			this.btnTuongTacGroupComment.TabIndex = 6;
			this.btnTuongTacGroupComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVWUXdPUT09"))))))));
			this.toolTip1.SetToolTip(this.btnTuongTacGroupComment, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWVZkR2FtVlZSbWxpVjJSdVdXdG9XVkpIT1hwbFYzQnBXbm93T1E9PQ==")))))))));
			this.btnTuongTacGroupComment.UseVisualStyleBackColor = true;
			this.btnTuongTacGroupComment.Click += new global::System.EventHandler(this.button4_Click);
			this.ckbTuongTacGroupLike.AutoSize = true;
			this.ckbTuongTacGroupLike.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacGroupLike.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacGroupLike.Location = new global::System.Drawing.Point(117, 92);
			this.ckbTuongTacGroupLike.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKWWFIZFpWRXBXVUZFOVBRPT0="))))))));
			this.ckbTuongTacGroupLike.Size = new global::System.Drawing.Size(49, 20);
			this.ckbTuongTacGroupLike.TabIndex = 4;
			this.ckbTuongTacGroupLike.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWa2MyTnNjRkpRVkRBOQ=="))))))));
			this.ckbTuongTacGroupLike.UseVisualStyleBackColor = true;
			this.label90.AutoSize = true;
			this.label90.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label90.Location = new global::System.Drawing.Point(240, 38);
			this.label90.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxaT1VWUXdPUT09"))))))));
			this.label90.Size = new global::System.Drawing.Size(25, 16);
			this.label90.TabIndex = 91;
			this.label90.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhaRWhoZWpBOQ=="))))))));
			this.label50.AutoSize = true;
			this.label50.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label50.Location = new global::System.Drawing.Point(7, 93);
			this.label50.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaT1VWUXdPUT09"))))))));
			this.label50.Size = new global::System.Drawing.Size(94, 16);
			this.label50.TabIndex = 89;
			this.label50.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWak5XRkljRXhVYmtKS1UwWlNTR013TVdoaFIwcDBXVEprYTFJd2FFNWFNV1JPVG1jOVBRPT0="))))))));
			this.label51.AutoSize = true;
			this.label51.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label51.Location = new global::System.Drawing.Point(7, 66);
			this.label51.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaT1ZWUXdPUT09"))))))));
			this.label51.Size = new global::System.Drawing.Size(100, 16);
			this.label51.TabIndex = 89;
			this.label51.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudTuongTacGroupSoLuongBaiVietTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacGroupSoLuongBaiVietTo.Location = new global::System.Drawing.Point(194, 35);
			global::System.Windows.Forms.NumericUpDown numericUpDown41 = this.nudTuongTacGroupSoLuongBaiVietTo;
			int[] array41 = new int[4];
			array41[0] = 1000;
			numericUpDown41.Maximum = new decimal(array41);
			this.nudTuongTacGroupSoLuongBaiVietTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZUbHBXTW5oWVdWWmtWMDFHV2toUFJEQTk="))))))));
			this.nudTuongTacGroupSoLuongBaiVietTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacGroupSoLuongBaiVietTo.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown42 = this.nudTuongTacGroupSoLuongBaiVietTo;
			int[] array42 = new int[4];
			array42[0] = 10;
			numericUpDown42.Value = new decimal(array42);
			this.nudTuongTacGroupDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacGroupDelayFrom.Location = new global::System.Drawing.Point(117, 63);
			global::System.Windows.Forms.NumericUpDown numericUpDown43 = this.nudTuongTacGroupDelayFrom;
			int[] array43 = new int[4];
			array43[0] = 1000;
			numericUpDown43.Maximum = new decimal(array43);
			this.nudTuongTacGroupDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKV1NuTlphMlJIVGxaS2RWTnVXbWxWVkRBNQ=="))))))));
			this.nudTuongTacGroupDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacGroupDelayFrom.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown44 = this.nudTuongTacGroupDelayFrom;
			int[] array44 = new int[4];
			array44[0] = 5;
			numericUpDown44.Value = new decimal(array44);
			this.label55.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label55.Location = new global::System.Drawing.Point(162, 38);
			this.label55.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaUFZWUXdPUT09"))))))));
			this.label55.Size = new global::System.Drawing.Size(29, 16);
			this.label55.TabIndex = 91;
			this.label55.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label55.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label52.AutoSize = true;
			this.label52.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label52.Location = new global::System.Drawing.Point(240, 68);
			this.label52.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaT1dub3dPUT09"))))))));
			this.label52.Size = new global::System.Drawing.Size(31, 16);
			this.label52.TabIndex = 91;
			this.label52.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.nudTuongTacGroupDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacGroupDelayTo.Location = new global::System.Drawing.Point(194, 64);
			global::System.Windows.Forms.NumericUpDown numericUpDown45 = this.nudTuongTacGroupDelayTo;
			int[] array45 = new int[4];
			array45[0] = 1000;
			numericUpDown45.Maximum = new decimal(array45);
			this.nudTuongTacGroupDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKV1NuTlphMlJIVGxaYVNFOUVNRDA9"))))))));
			this.nudTuongTacGroupDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacGroupDelayTo.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown46 = this.nudTuongTacGroupDelayTo;
			int[] array46 = new int[4];
			array46[0] = 10;
			numericUpDown46.Value = new decimal(array46);
			this.label53.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label53.Location = new global::System.Drawing.Point(162, 68);
			this.label53.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaT1pIb3dPUT09"))))))));
			this.label53.Size = new global::System.Drawing.Size(29, 16);
			this.label53.TabIndex = 91;
			this.label53.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label53.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudTuongTacGroupSoLuongNhomTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacGroupSoLuongNhomTo.Location = new global::System.Drawing.Point(194, 5);
			global::System.Windows.Forms.NumericUpDown numericUpDown47 = this.nudTuongTacGroupSoLuongNhomTo;
			int[] array47 = new int[4];
			array47[0] = 1000;
			numericUpDown47.Maximum = new decimal(array47);
			this.nudTuongTacGroupSoLuongNhomTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZPV2hTZW13d1ZtdGpORkJSUFQwPQ=="))))))));
			this.nudTuongTacGroupSoLuongNhomTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacGroupSoLuongNhomTo.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown48 = this.nudTuongTacGroupSoLuongNhomTo;
			int[] array48 = new int[4];
			array48[0] = 10;
			numericUpDown48.Value = new decimal(array48);
			this.label88.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label88.Location = new global::System.Drawing.Point(162, 8);
			this.label88.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxKUVVWUXdPUT09"))))))));
			this.label88.Size = new global::System.Drawing.Size(29, 16);
			this.label88.TabIndex = 91;
			this.label88.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label88.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.plTuongTacFriend.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plTuongTacFriend.Controls.Add(this.label49);
			this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBanBeFrom);
			this.plTuongTacFriend.Controls.Add(this.label19);
			this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBaiVietFrom);
			this.plTuongTacFriend.Controls.Add(this.ckbTuongTacFriendComment);
			this.plTuongTacFriend.Controls.Add(this.btnTuongTacFriendComment);
			this.plTuongTacFriend.Controls.Add(this.ckbTuongTacFriendLike);
			this.plTuongTacFriend.Controls.Add(this.label33);
			this.plTuongTacFriend.Controls.Add(this.label46);
			this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendDelayFrom);
			this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBaiVietTo);
			this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendSoLuongBanBeTo);
			this.plTuongTacFriend.Controls.Add(this.nudTuongTacFriendDelayTo);
			this.plTuongTacFriend.Controls.Add(this.label67);
			this.plTuongTacFriend.Controls.Add(this.label66);
			this.plTuongTacFriend.Controls.Add(this.label48);
			this.plTuongTacFriend.Controls.Add(this.label68);
			this.plTuongTacFriend.Controls.Add(this.label54);
			this.plTuongTacFriend.Controls.Add(this.label47);
			this.plTuongTacFriend.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plTuongTacFriend.Location = new global::System.Drawing.Point(356, 46);
			this.plTuongTacFriend.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWlhVbGhQV0ZaaFRWWktiMWRVUW1GbFYwWllWbTVXWVZGVU1Eaz0="))))))));
			this.plTuongTacFriend.Size = new global::System.Drawing.Size(278, 151);
			this.plTuongTacFriend.TabIndex = 4;
			this.label49.AutoSize = true;
			this.label49.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label49.Location = new global::System.Drawing.Point(7, 8);
			this.label49.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtKUVZWUXdPUT09"))))))));
			this.label49.Size = new global::System.Drawing.Size(107, 16);
			this.label49.TabIndex = 0;
			this.label49.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxU2xJd2NHOWxhM1JQWkZWc1NGTnRlRFpUVlVVeQ=="))))))));
			this.nudTuongTacFriendSoLuongBanBeFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFriendSoLuongBanBeFrom.Location = new global::System.Drawing.Point(117, 5);
			global::System.Windows.Forms.NumericUpDown numericUpDown49 = this.nudTuongTacFriendSoLuongBanBeFrom;
			int[] array49 = new int[4];
			array49[0] = 1000;
			numericUpDown49.Maximum = new decimal(array49);
			this.nudTuongTacFriendSoLuongBanBeFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NsVlpha0kwVFZkSmVVNVhOVkppVlZveFZWY3hWMUl5VG5SUFdGRTk="))))))));
			this.nudTuongTacFriendSoLuongBanBeFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacFriendSoLuongBanBeFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown50 = this.nudTuongTacFriendSoLuongBanBeFrom;
			int[] array50 = new int[4];
			array50[0] = 5;
			numericUpDown50.Value = new decimal(array50);
			this.label68.AutoSize = true;
			this.label68.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label68.Location = new global::System.Drawing.Point(240, 8);
			this.label68.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtwUVVWUXdPUT09"))))))));
			this.label68.Size = new global::System.Drawing.Size(29, 16);
			this.label68.TabIndex = 89;
			this.label68.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhPSGxPUkRBOQ=="))))))));
			this.label54.AutoSize = true;
			this.label54.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label54.Location = new global::System.Drawing.Point(240, 37);
			this.label54.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtaUFVWUXdPUT09"))))))));
			this.label54.Size = new global::System.Drawing.Size(25, 16);
			this.label54.TabIndex = 89;
			this.label54.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhaRWhoZWpBOQ=="))))))));
			this.label19.AutoSize = true;
			this.label19.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label19.Location = new global::System.Drawing.Point(7, 37);
			this.label19.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUVZWUXdPUT09"))))))));
			this.label19.Size = new global::System.Drawing.Size(99, 16);
			this.label19.TabIndex = 89;
			this.label19.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJSYVlsVm9UbG93WkhKYU1sSjBZbXRTZUdNemJFTmFSVTAxWVZac2FtVlhjR2xoYlRnNQ=="))))))));
			this.nudTuongTacFriendSoLuongBaiVietFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFriendSoLuongBaiVietFrom.Location = new global::System.Drawing.Point(117, 34);
			global::System.Windows.Forms.NumericUpDown numericUpDown51 = this.nudTuongTacFriendSoLuongBaiVietFrom;
			int[] array51 = new int[4];
			array51[0] = 1000;
			numericUpDown51.Maximum = new decimal(array51);
			this.nudTuongTacFriendSoLuongBaiVietFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NsVlpha0kwVFZkSmVVNVhOVkppVlZwM1ZtMHhjMkpIVWtaWGJteHBUV3BCT1E9PQ=="))))))));
			this.nudTuongTacFriendSoLuongBaiVietFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacFriendSoLuongBaiVietFrom.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown52 = this.nudTuongTacFriendSoLuongBaiVietFrom;
			int[] array52 = new int[4];
			array52[0] = 5;
			numericUpDown52.Value = new decimal(array52);
			this.ckbTuongTacFriendComment.AutoSize = true;
			this.ckbTuongTacFriendComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacFriendComment.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacFriendComment.Location = new global::System.Drawing.Point(117, 118);
			this.ckbTuongTacFriendComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrVlpha2w0WkVad1dFNVVRVDA9"))))))));
			this.ckbTuongTacFriendComment.Size = new global::System.Drawing.Size(82, 20);
			this.ckbTuongTacFriendComment.TabIndex = 6;
			this.ckbTuongTacFriendComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUkhTbGhXYmxaclVWUXdPUT09"))))))));
			this.ckbTuongTacFriendComment.UseVisualStyleBackColor = true;
			this.ckbTuongTacFriendComment.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacFriendComment_CheckedChanged);
			this.btnTuongTacFriendComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnTuongTacFriendComment.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.btnTuongTacFriendComment.Location = new global::System.Drawing.Point(208, 114);
			this.btnTuongTacFriendComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrVlpha2w0WkVad1dFNVVRVDA9"))))))));
			this.btnTuongTacFriendComment.Size = new global::System.Drawing.Size(58, 27);
			this.btnTuongTacFriendComment.TabIndex = 7;
			this.btnTuongTacFriendComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVWUXdPUT09"))))))));
			this.toolTip1.SetToolTip(this.btnTuongTacFriendComment, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWVZkR2FtVlZSbWxpVjJSdVdXdG9XVkpIT1hwbFYzQnBXbm93T1E9PQ==")))))))));
			this.btnTuongTacFriendComment.UseVisualStyleBackColor = true;
			this.btnTuongTacFriendComment.Click += new global::System.EventHandler(this.button3_Click);
			this.ckbTuongTacFriendLike.AutoSize = true;
			this.ckbTuongTacFriendLike.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacFriendLike.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacFriendLike.Location = new global::System.Drawing.Point(117, 93);
			this.ckbTuongTacFriendLike.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrNVpWbVF3WWtFOVBRPT0="))))))));
			this.ckbTuongTacFriendLike.Size = new global::System.Drawing.Size(49, 20);
			this.ckbTuongTacFriendLike.TabIndex = 5;
			this.ckbTuongTacFriendLike.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWa2MyTnNjRkpRVkRBOQ=="))))))));
			this.ckbTuongTacFriendLike.UseVisualStyleBackColor = true;
			this.label33.AutoSize = true;
			this.label33.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label33.Location = new global::System.Drawing.Point(7, 94);
			this.label33.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCT1pIb3dPUT09"))))))));
			this.label33.Size = new global::System.Drawing.Size(94, 16);
			this.label33.TabIndex = 89;
			this.label33.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWak5XRkljRXhVYmtKS1UwWlNTR013TVdoaFIwcDBXVEprYTFJd2FFNWFNV1JPVG1jOVBRPT0="))))))));
			this.label46.AutoSize = true;
			this.label46.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label46.Location = new global::System.Drawing.Point(7, 66);
			this.label46.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtKUFdub3dPUT09"))))))));
			this.label46.Size = new global::System.Drawing.Size(100, 16);
			this.label46.TabIndex = 89;
			this.label46.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudTuongTacFriendDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFriendDelayFrom.Location = new global::System.Drawing.Point(117, 63);
			global::System.Windows.Forms.NumericUpDown numericUpDown53 = this.nudTuongTacFriendDelayFrom;
			int[] array53 = new int[4];
			array53[0] = 1000;
			numericUpDown53.Maximum = new decimal(array53);
			this.nudTuongTacFriendDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrWlhiR1EwWVVkV1ZsZHViR2xOYWtFNQ=="))))))));
			this.nudTuongTacFriendDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacFriendDelayFrom.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown54 = this.nudTuongTacFriendDelayFrom;
			int[] array54 = new int[4];
			array54[0] = 5;
			numericUpDown54.Value = new decimal(array54);
			this.label47.AutoSize = true;
			this.label47.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label47.Location = new global::System.Drawing.Point(240, 68);
			this.label47.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtKUFpIb3dPUT09"))))))));
			this.label47.Size = new global::System.Drawing.Size(31, 16);
			this.label47.TabIndex = 91;
			this.label47.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.nudTuongTacFriendSoLuongBaiVietTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFriendSoLuongBaiVietTo.Location = new global::System.Drawing.Point(194, 35);
			global::System.Windows.Forms.NumericUpDown numericUpDown55 = this.nudTuongTacFriendSoLuongBaiVietTo;
			int[] array55 = new int[4];
			array55[0] = 1000;
			numericUpDown55.Maximum = new decimal(array55);
			this.nudTuongTacFriendSoLuongBaiVietTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NsVlpha0kwVFZkSmVVNVhOVkppVlZwM1ZtMHhjMkpIVWtkVmJsazk="))))))));
			this.nudTuongTacFriendSoLuongBaiVietTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacFriendSoLuongBaiVietTo.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown56 = this.nudTuongTacFriendSoLuongBaiVietTo;
			int[] array56 = new int[4];
			array56[0] = 10;
			numericUpDown56.Value = new decimal(array56);
			this.nudTuongTacFriendSoLuongBanBeTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFriendSoLuongBanBeTo.Location = new global::System.Drawing.Point(194, 6);
			global::System.Windows.Forms.NumericUpDown numericUpDown57 = this.nudTuongTacFriendSoLuongBanBeTo;
			int[] array57 = new int[4];
			array57[0] = 1000;
			numericUpDown57.Maximum = new decimal(array57);
			this.nudTuongTacFriendSoLuongBanBeTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NsVlpha0kwVFZkSmVVNVhOVkppVlZveFZWY3hWMVpYU2pOUVZEQTk="))))))));
			this.nudTuongTacFriendSoLuongBanBeTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacFriendSoLuongBanBeTo.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown58 = this.nudTuongTacFriendSoLuongBanBeTo;
			int[] array58 = new int[4];
			array58[0] = 10;
			numericUpDown58.Value = new decimal(array58);
			this.nudTuongTacFriendDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacFriendDelayTo.Location = new global::System.Drawing.Point(194, 64);
			global::System.Windows.Forms.NumericUpDown numericUpDown59 = this.nudTuongTacFriendDelayTo;
			int[] array59 = new int[4];
			array59[0] = 1000;
			numericUpDown59.Maximum = new decimal(array59);
			this.nudTuongTacFriendDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrWlhiR1EwWVVkV1YxVnVXVDA9"))))))));
			this.nudTuongTacFriendDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacFriendDelayTo.TabIndex = 4;
			global::System.Windows.Forms.NumericUpDown numericUpDown60 = this.nudTuongTacFriendDelayTo;
			int[] array60 = new int[4];
			array60[0] = 10;
			numericUpDown60.Value = new decimal(array60);
			this.label67.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label67.Location = new global::System.Drawing.Point(162, 37);
			this.label67.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtwUFpIb3dPUT09"))))))));
			this.label67.Size = new global::System.Drawing.Size(29, 16);
			this.label67.TabIndex = 91;
			this.label67.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label67.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label66.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label66.Location = new global::System.Drawing.Point(162, 8);
			this.label66.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtwUFdub3dPUT09"))))))));
			this.label66.Size = new global::System.Drawing.Size(29, 16);
			this.label66.TabIndex = 91;
			this.label66.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label66.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label48.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label48.Location = new global::System.Drawing.Point(162, 68);
			this.label48.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtKUVVWUXdPUT09"))))))));
			this.label48.Size = new global::System.Drawing.Size(29, 16);
			this.label48.TabIndex = 91;
			this.label48.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label48.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.plTuongTacNewsfeed.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plTuongTacNewsfeed.Controls.Add(this.label1);
			this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedSoLuongFrom);
			this.plTuongTacNewsfeed.Controls.Add(this.ckbTuongTacNewsfeedComment);
			this.plTuongTacNewsfeed.Controls.Add(this.btnTuongTacNewsfeedComment);
			this.plTuongTacNewsfeed.Controls.Add(this.ckbTuongTacNewsfeedLike);
			this.plTuongTacNewsfeed.Controls.Add(this.label8);
			this.plTuongTacNewsfeed.Controls.Add(this.label24);
			this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedDelayFrom);
			this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedSoLuongTo);
			this.plTuongTacNewsfeed.Controls.Add(this.nudTuongTacNewsfeedDelayTo);
			this.plTuongTacNewsfeed.Controls.Add(this.label64);
			this.plTuongTacNewsfeed.Controls.Add(this.label25);
			this.plTuongTacNewsfeed.Controls.Add(this.label65);
			this.plTuongTacNewsfeed.Controls.Add(this.label29);
			this.plTuongTacNewsfeed.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plTuongTacNewsfeed.Location = new global::System.Drawing.Point(41, 46);
			this.plTuongTacNewsfeed.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWlhVbGhQV0ZaaFRWWktiMWRVUVRGaVIxRjZWRzB4WVZZeFduST0="))))))));
			this.plTuongTacNewsfeed.Size = new global::System.Drawing.Size(278, 123);
			this.plTuongTacNewsfeed.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label1.Location = new global::System.Drawing.Point(7, 9);
			this.label1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJjOQ=="))))))));
			this.label1.Size = new global::System.Drawing.Size(109, 16);
			this.label1.TabIndex = 89;
			this.label1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxU2xJd2NHOWxhMnhEWTBWc1NWZHVRak5PYmtwT1dqRm9VazVuUFQwPQ=="))))))));
			this.nudTuongTacNewsfeedSoLuongFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacNewsfeedSoLuongFrom.Location = new global::System.Drawing.Point(117, 6);
			global::System.Windows.Forms.NumericUpDown numericUpDown61 = this.nudTuongTacNewsfeedSoLuongFrom;
			int[] array61 = new int[4];
			array61[0] = 1000;
			numericUpDown61.Maximum = new decimal(array61);
			this.nudTuongTacNewsfeedSoLuongFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMXBQWkd4U1NWWnVXbWxpVjFKSVdUSXdOV1JCUFQwPQ=="))))))));
			this.nudTuongTacNewsfeedSoLuongFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacNewsfeedSoLuongFrom.TabIndex = 0;
			global::System.Windows.Forms.NumericUpDown numericUpDown62 = this.nudTuongTacNewsfeedSoLuongFrom;
			int[] array62 = new int[4];
			array62[0] = 5;
			numericUpDown62.Value = new decimal(array62);
			this.ckbTuongTacNewsfeedComment.AutoSize = true;
			this.ckbTuongTacNewsfeedComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacNewsfeedComment.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacNewsfeedComment.Location = new global::System.Drawing.Point(117, 90);
			this.ckbTuongTacNewsfeedComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVpQWkcxS1dFMVhlR2xpYkVVNQ=="))))))));
			this.ckbTuongTacNewsfeedComment.Size = new global::System.Drawing.Size(82, 20);
			this.ckbTuongTacNewsfeedComment.TabIndex = 4;
			this.ckbTuongTacNewsfeedComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUkhTbGhXYmxaclVWUXdPUT09"))))))));
			this.ckbTuongTacNewsfeedComment.UseVisualStyleBackColor = true;
			this.ckbTuongTacNewsfeedComment.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacNewsfeedComment_CheckedChanged);
			this.btnTuongTacNewsfeedComment.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnTuongTacNewsfeedComment.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.btnTuongTacNewsfeedComment.Location = new global::System.Drawing.Point(208, 86);
			this.btnTuongTacNewsfeedComment.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVpQWkcxS1dFMVhlR2xpYkVVNQ=="))))))));
			this.btnTuongTacNewsfeedComment.Size = new global::System.Drawing.Size(58, 27);
			this.btnTuongTacNewsfeedComment.TabIndex = 5;
			this.btnTuongTacNewsfeedComment.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVWUXdPUT09"))))))));
			this.toolTip1.SetToolTip(this.btnTuongTacNewsfeedComment, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWVZkR2FtVlZSbWxpVjJSdVdXdG9XVkpIT1hwbFYzQnBXbm93T1E9PQ==")))))))));
			this.btnTuongTacNewsfeedComment.UseVisualStyleBackColor = true;
			this.btnTuongTacNewsfeedComment.Click += new global::System.EventHandler(this.btnOpenComment_Click_1);
			this.ckbTuongTacNewsfeedLike.AutoSize = true;
			this.ckbTuongTacNewsfeedLike.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacNewsfeedLike.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacNewsfeedLike.Location = new global::System.Drawing.Point(117, 65);
			this.ckbTuongTacNewsfeedLike.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVkwWTBkRmVWWlVNRDA9"))))))));
			this.ckbTuongTacNewsfeedLike.Size = new global::System.Drawing.Size(49, 20);
			this.ckbTuongTacNewsfeedLike.TabIndex = 3;
			this.ckbTuongTacNewsfeedLike.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWa2MyTnNjRkpRVkRBOQ=="))))))));
			this.ckbTuongTacNewsfeedLike.UseVisualStyleBackColor = true;
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label8.Location = new global::System.Drawing.Point(7, 66);
			this.label8.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxFOQ=="))))))));
			this.label8.Size = new global::System.Drawing.Size(94, 16);
			this.label8.TabIndex = 89;
			this.label8.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtWak5XRkljRXhVYmtKS1UwWlNTR013TVdoaFIwcDBXVEprYTFJd2FFNWFNV1JPVG1jOVBRPT0="))))))));
			this.label24.AutoSize = true;
			this.label24.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label24.Location = new global::System.Drawing.Point(7, 39);
			this.label24.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4UFVWUXdPUT09"))))))));
			this.label24.Size = new global::System.Drawing.Size(100, 16);
			this.label24.TabIndex = 89;
			this.label24.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudTuongTacNewsfeedDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacNewsfeedDelayFrom.Location = new global::System.Drawing.Point(117, 36);
			global::System.Windows.Forms.NumericUpDown numericUpDown63 = this.nudTuongTacNewsfeedDelayFrom;
			int[] array63 = new int[4];
			array63[0] = 1000;
			numericUpDown63.Maximum = new decimal(array63);
			this.nudTuongTacNewsfeedDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVpUWWtkS1NGSnFWbE5pYTNBeVdXeEZPVkJSUFQwPQ=="))))))));
			this.nudTuongTacNewsfeedDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudTuongTacNewsfeedDelayFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown64 = this.nudTuongTacNewsfeedDelayFrom;
			int[] array64 = new int[4];
			array64[0] = 5;
			numericUpDown64.Value = new decimal(array64);
			this.label65.AutoSize = true;
			this.label65.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label65.Location = new global::System.Drawing.Point(240, 11);
			this.label65.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtwUFZWUXdPUT09"))))))));
			this.label65.Size = new global::System.Drawing.Size(25, 16);
			this.label65.TabIndex = 91;
			this.label65.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhaRWhoZWpBOQ=="))))))));
			this.label29.AutoSize = true;
			this.label29.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label29.Location = new global::System.Drawing.Point(240, 40);
			this.label29.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4UVZWUXdPUT09"))))))));
			this.label29.Size = new global::System.Drawing.Size(31, 16);
			this.label29.TabIndex = 91;
			this.label29.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.nudTuongTacNewsfeedSoLuongTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacNewsfeedSoLuongTo.Location = new global::System.Drawing.Point(194, 7);
			global::System.Windows.Forms.NumericUpDown numericUpDown65 = this.nudTuongTacNewsfeedSoLuongTo;
			int[] array65 = new int[4];
			array65[0] = 1000;
			numericUpDown65.Maximum = new decimal(array65);
			this.nudTuongTacNewsfeedSoLuongTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMXBQWkd4U1NWWnVXbWxpVjFKV1dXNWpPVkJSUFQwPQ=="))))))));
			this.nudTuongTacNewsfeedSoLuongTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacNewsfeedSoLuongTo.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown66 = this.nudTuongTacNewsfeedSoLuongTo;
			int[] array66 = new int[4];
			array66[0] = 10;
			numericUpDown66.Value = new decimal(array66);
			this.nudTuongTacNewsfeedDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudTuongTacNewsfeedDelayTo.Location = new global::System.Drawing.Point(194, 37);
			global::System.Windows.Forms.NumericUpDown numericUpDown67 = this.nudTuongTacNewsfeedDelayTo;
			int[] array67 = new int[4];
			array67[0] = 1000;
			numericUpDown67.Maximum = new decimal(array67);
			this.nudTuongTacNewsfeedDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVpUWWtkS1NGSnFWbGRTZW1jNQ=="))))))));
			this.nudTuongTacNewsfeedDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudTuongTacNewsfeedDelayTo.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown68 = this.nudTuongTacNewsfeedDelayTo;
			int[] array68 = new int[4];
			array68[0] = 10;
			numericUpDown68.Value = new decimal(array68);
			this.label64.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label64.Location = new global::System.Drawing.Point(162, 11);
			this.label64.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtwUFVWUXdPUT09"))))))));
			this.label64.Size = new global::System.Drawing.Size(29, 16);
			this.label64.TabIndex = 91;
			this.label64.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label64.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label25.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label25.Location = new global::System.Drawing.Point(162, 41);
			this.label25.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4UFZWUXdPUT09"))))))));
			this.label25.Size = new global::System.Drawing.Size(29, 16);
			this.label25.TabIndex = 91;
			this.label25.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label25.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ckbTuongTacFanpage.AutoSize = true;
			this.ckbTuongTacFanpage.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacFanpage.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacFanpage.Location = new global::System.Drawing.Point(21, 175);
			this.ckbTuongTacFanpage.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTT0="))))))));
			this.ckbTuongTacFanpage.Size = new global::System.Drawing.Size(76, 20);
			this.ckbTuongTacFanpage.TabIndex = 7;
			this.ckbTuongTacFanpage.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlcweFIyUlhUa2hTYlRWaFZWUXdPUT09"))))))));
			this.ckbTuongTacFanpage.UseVisualStyleBackColor = true;
			this.ckbTuongTacFanpage.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacFanpage_CheckedChanged);
			this.ckbTuongTacGroup.AutoSize = true;
			this.ckbTuongTacGroup.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacGroup.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacGroup.Location = new global::System.Drawing.Point(338, 204);
			this.ckbTuongTacGroup.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxGVU1Eaz0="))))))));
			this.ckbTuongTacGroup.Size = new global::System.Drawing.Size(61, 20);
			this.ckbTuongTacGroup.TabIndex = 5;
			this.ckbTuongTacGroup.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldwT1MyUnRVbGxSVkRBOQ=="))))))));
			this.ckbTuongTacGroup.UseVisualStyleBackColor = true;
			this.ckbTuongTacGroup.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacGroup_CheckedChanged);
			this.ckbTuongTacNewsfeed.AutoSize = true;
			this.ckbTuongTacNewsfeed.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacNewsfeed.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacNewsfeed.Location = new global::System.Drawing.Point(23, 22);
			this.ckbTuongTacNewsfeed.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMFU1VUZFOVBRPT0="))))))));
			this.ckbTuongTacNewsfeed.Size = new global::System.Drawing.Size(83, 20);
			this.ckbTuongTacNewsfeed.TabIndex = 0;
			this.ckbTuongTacNewsfeed.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeFYwMHlUWGxYYlhoaFZqRkZPUT09"))))))));
			this.ckbTuongTacNewsfeed.UseVisualStyleBackColor = true;
			this.ckbTuongTacNewsfeed.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacNewsfeed_CheckedChanged);
			this.ckbTuongTacFriend.AutoSize = true;
			this.ckbTuongTacFriend.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbTuongTacFriend.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbTuongTacFriend.Location = new global::System.Drawing.Point(338, 22);
			this.ckbTuongTacFriend.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1JUaz0="))))))));
			this.ckbTuongTacFriend.Size = new global::System.Drawing.Size(63, 20);
			this.ckbTuongTacFriend.TabIndex = 3;
			this.ckbTuongTacFriend.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlcwMVMyTkdjRmhPVjNNOQ=="))))))));
			this.ckbTuongTacFriend.UseVisualStyleBackColor = true;
			this.ckbTuongTacFriend.CheckedChanged += new global::System.EventHandler(this.ckbTuongTacFriend_CheckedChanged);
			this.groupBox8.Controls.Add(this.ckbKetBanTuKhoa);
			this.groupBox8.Controls.Add(this.plKetBanTepUid);
			this.groupBox8.Controls.Add(this.plKetBanTuKhoa);
			this.groupBox8.Controls.Add(this.ckbKetBanGoiY);
			this.groupBox8.Controls.Add(this.plXacNhanKetBan);
			this.groupBox8.Controls.Add(this.plKetBanGoiY);
			this.groupBox8.Controls.Add(this.ckbKetBanTepUid);
			this.groupBox8.Controls.Add(this.ckbXacNhanKetBan);
			this.groupBox8.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.groupBox8.Location = new global::System.Drawing.Point(7, 424);
			this.groupBox8.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwT1MyUnRVbGxSYTA1cFRUSmpNQT09"))))))));
			this.groupBox8.Size = new global::System.Drawing.Size(649, 243);
			this.groupBox8.TabIndex = 3;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vlhwb1VHTlljRXBTYWtKS1VqQndiMlZyZEU5a1VUMDk="))))))));
			this.ckbKetBanTuKhoa.AutoSize = true;
			this.ckbKetBanTuKhoa.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbKetBanTuKhoa.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbKetBanTuKhoa.Location = new global::System.Drawing.Point(23, 20);
			this.ckbKetBanTuKhoa.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRuUFE9PQ=="))))))));
			this.ckbKetBanTuKhoa.Size = new global::System.Drawing.Size(146, 20);
			this.ckbKetBanTuKhoa.TabIndex = 0;
			this.ckbKetBanTuKhoa.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhsMFNFNXVXWHBWVjJSYVpGVmpNbUl4WXpCYU1sSklZVWQ0YVdWVlNYZGxTRXBGVkZka1JGRnVTbWhTZVRsT1dqRmtSbEJSUFQwPQ=="))))))));
			this.ckbKetBanTuKhoa.UseVisualStyleBackColor = true;
			this.ckbKetBanTuKhoa.CheckedChanged += new global::System.EventHandler(this.ckbKetBanTuKhoa_CheckedChanged);
			this.plKetBanTepUid.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plKetBanTepUid.Controls.Add(this.ckbKetBanTepUidTrungNhau);
			this.plKetBanTepUid.Controls.Add(this.label17);
			this.plKetBanTepUid.Controls.Add(this.label20);
			this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidSoLuongFrom);
			this.plKetBanTepUid.Controls.Add(this.label21);
			this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidDelayFrom);
			this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidDelayTo);
			this.plKetBanTepUid.Controls.Add(this.nudKetBanTepUidSoLuongTo);
			this.plKetBanTepUid.Controls.Add(this.label73);
			this.plKetBanTepUid.Controls.Add(this.button8);
			this.plKetBanTepUid.Controls.Add(this.label23);
			this.plKetBanTepUid.Controls.Add(this.label22);
			this.plKetBanTepUid.Controls.Add(this.label74);
			this.plKetBanTepUid.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plKetBanTepUid.Location = new global::System.Drawing.Point(358, 43);
			this.plKetBanTepUid.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GUkdjRmxWYTA1YVZucFdWbGRzYUVOV2JVWllWVlF3UFE9PQ=="))))))));
			this.plKetBanTepUid.Size = new global::System.Drawing.Size(278, 105);
			this.plKetBanTepUid.TabIndex = 5;
			this.ckbKetBanTepUidTrungNhau.AutoSize = true;
			this.ckbKetBanTepUidTrungNhau.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbKetBanTepUidTrungNhau.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbKetBanTepUidTrungNhau.Location = new global::System.Drawing.Point(10, 82);
			this.ckbKetBanTepUidTrungNhau.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVjFORmIzaFpiVEZyVkRKR1NGSnFSVDA9"))))))));
			this.ckbKetBanTepUidTrungNhau.Size = new global::System.Drawing.Size(193, 20);
			this.ckbKetBanTepUidTrungNhau.TabIndex = 112;
			this.ckbKetBanTepUidTrungNhau.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IyUnJiRWxSYlRrelRtMTRNMU5WWkRKaFNGWjVUMVJDU2xJd2VHOWtXRVpIWkZWc1NWVnViRE5PTW5neFYyNXNRMlJYUmtoU2FrVTk="))))))));
			this.ckbKetBanTepUidTrungNhau.UseVisualStyleBackColor = true;
			this.ckbKetBanTepUidTrungNhau.CheckedChanged += new global::System.EventHandler(this.ckbThamGiaNhomTraLoiCauHoi_CheckedChanged);
			this.label17.AutoSize = true;
			this.label17.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label17.Location = new global::System.Drawing.Point(7, 7);
			this.label17.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUFpIb3dPUT09"))))))));
			this.label17.Size = new global::System.Drawing.Size(88, 16);
			this.label17.TabIndex = 89;
			this.label17.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQkpkMlI2V25sVVZ6aDZVVmRrVjFaWGVFWlVNbU01VUZFOVBRPT0="))))))));
			this.label20.AutoSize = true;
			this.label20.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label20.Location = new global::System.Drawing.Point(7, 34);
			this.label20.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4T1VWUXdPUT09"))))))));
			this.label20.Size = new global::System.Drawing.Size(64, 16);
			this.label20.TabIndex = 89;
			this.label20.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxVUZwNk1Eaz0="))))))));
			this.nudKetBanTepUidSoLuongFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanTepUidSoLuongFrom.Location = new global::System.Drawing.Point(117, 31);
			global::System.Windows.Forms.NumericUpDown numericUpDown69 = this.nudKetBanTepUidSoLuongFrom;
			int[] array69 = new int[4];
			array69[0] = 1000;
			numericUpDown69.Maximum = new decimal(array69);
			this.nudKetBanTepUidSoLuongFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ=="))))))));
			this.nudKetBanTepUidSoLuongFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudKetBanTepUidSoLuongFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown70 = this.nudKetBanTepUidSoLuongFrom;
			int[] array70 = new int[4];
			array70[0] = 5;
			numericUpDown70.Value = new decimal(array70);
			this.label21.AutoSize = true;
			this.label21.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label21.Location = new global::System.Drawing.Point(7, 61);
			this.label21.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4T1ZWUXdPUT09"))))))));
			this.label21.Size = new global::System.Drawing.Size(100, 16);
			this.label21.TabIndex = 89;
			this.label21.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudKetBanTepUidDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanTepUidDelayFrom.Location = new global::System.Drawing.Point(117, 57);
			global::System.Windows.Forms.NumericUpDown numericUpDown71 = this.nudKetBanTepUidDelayFrom;
			int[] array71 = new int[4];
			array71[0] = 1000;
			numericUpDown71.Maximum = new decimal(array71);
			this.nudKetBanTepUidDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVTFJeFducFhWbWh6VWpKT2RFOVlVVDA9"))))))));
			this.nudKetBanTepUidDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudKetBanTepUidDelayFrom.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown72 = this.nudKetBanTepUidDelayFrom;
			int[] array72 = new int[4];
			array72[0] = 5;
			numericUpDown72.Value = new decimal(array72);
			this.label22.AutoSize = true;
			this.label22.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label22.Location = new global::System.Drawing.Point(239, 61);
			this.label22.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4T1dub3dPUT09"))))))));
			this.label22.Size = new global::System.Drawing.Size(31, 16);
			this.label22.TabIndex = 91;
			this.label22.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.label74.AutoSize = true;
			this.label74.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label74.Location = new global::System.Drawing.Point(239, 36);
			this.label74.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWs1UFVWUXdPUT09"))))))));
			this.label74.Size = new global::System.Drawing.Size(29, 16);
			this.label74.TabIndex = 91;
			this.label74.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhPSGxPUkRBOQ=="))))))));
			this.nudKetBanTepUidDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanTepUidDelayTo.Location = new global::System.Drawing.Point(194, 58);
			global::System.Windows.Forms.NumericUpDown numericUpDown73 = this.nudKetBanTepUidDelayTo;
			int[] array73 = new int[4];
			array73[0] = 1000;
			numericUpDown73.Maximum = new decimal(array73);
			this.nudKetBanTepUidDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVTFJeFducFhWbWh6VmxkS00xQlVNRDA9"))))))));
			this.nudKetBanTepUidDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudKetBanTepUidDelayTo.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown74 = this.nudKetBanTepUidDelayTo;
			int[] array74 = new int[4];
			array74[0] = 10;
			numericUpDown74.Value = new decimal(array74);
			this.nudKetBanTepUidSoLuongTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanTepUidSoLuongTo.Location = new global::System.Drawing.Point(194, 32);
			global::System.Windows.Forms.NumericUpDown numericUpDown75 = this.nudKetBanTepUidSoLuongTo;
			int[] array75 = new int[4];
			array75[0] = 1000;
			numericUpDown75.Maximum = new decimal(array75);
			this.nudKetBanTepUidSoLuongTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9"))))))));
			this.nudKetBanTepUidSoLuongTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudKetBanTepUidSoLuongTo.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown76 = this.nudKetBanTepUidSoLuongTo;
			int[] array76 = new int[4];
			array76[0] = 10;
			numericUpDown76.Value = new decimal(array76);
			this.label73.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label73.Location = new global::System.Drawing.Point(162, 36);
			this.label73.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWs1T1pIb3dPUT09"))))))));
			this.label73.Size = new global::System.Drawing.Size(29, 16);
			this.label73.TabIndex = 91;
			this.label73.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label73.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.button8.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button8.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.button8.Location = new global::System.Drawing.Point(116, 2);
			this.button8.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaUVVWUXdPUT09"))))))));
			this.button8.Size = new global::System.Drawing.Size(80, 27);
			this.button8.TabIndex = 0;
			this.button8.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVWUXdPUT09"))))))));
			this.toolTip1.SetToolTip(this.button8, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVm14T1ZsVlhaRnBQUlRsd1pXdHNRMlJWYkVoa2ExSjRZek5zUTFwRlRrTmhWbXhxWlZkd2FWcDZNRGs9")))))))));
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.label23.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label23.Location = new global::System.Drawing.Point(162, 61);
			this.label23.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4T1pIb3dPUT09"))))))));
			this.label23.Size = new global::System.Drawing.Size(29, 16);
			this.label23.TabIndex = 91;
			this.label23.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label23.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.plKetBanTuKhoa.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plKetBanTuKhoa.Controls.Add(this.pictureBox2);
			this.plKetBanTuKhoa.Controls.Add(this.txtKetBanTuKhoaTuKhoa);
			this.plKetBanTuKhoa.Controls.Add(this.label16);
			this.plKetBanTuKhoa.Controls.Add(this.label3);
			this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaSoLuongFrom);
			this.plKetBanTuKhoa.Controls.Add(this.label9);
			this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaDelayFrom);
			this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaSoLuongTo);
			this.plKetBanTuKhoa.Controls.Add(this.label69);
			this.plKetBanTuKhoa.Controls.Add(this.nudKetBanTuKhoaDelayTo);
			this.plKetBanTuKhoa.Controls.Add(this.label15);
			this.plKetBanTuKhoa.Controls.Add(this.label70);
			this.plKetBanTuKhoa.Controls.Add(this.label14);
			this.plKetBanTuKhoa.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plKetBanTuKhoa.Location = new global::System.Drawing.Point(41, 43);
			this.plKetBanTuKhoa.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GUkdjRmxWYTA1YVZucFdWbHBHVmpCaU1rbDVVbFF3UFE9PQ=="))))))));
			this.plKetBanTuKhoa.Size = new global::System.Drawing.Size(278, 91);
			this.plKetBanTuKhoa.TabIndex = 1;
			this.pictureBox2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtwa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.pictureBox2.Location = new global::System.Drawing.Point(249, 3);
			this.pictureBox2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtwUVVUMDk="))))))));
			this.pictureBox2.Size = new global::System.Drawing.Size(25, 25);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 92;
			this.pictureBox2.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox2, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSb1VHVnJiRWxWYlRnd1dXNVdSVk5WWXpGaWVsSnBZMWhTYWxFd1NqRlpWV1IxWVVoVk1GSnFSa3BUUmxKdlpGUmFlbG95UlhsaGExSjZUV3RXZWxOVll6RmlibWhLVkc1V1NsSXhRa1ZpTVdSUFlqQnNTRTVYT1ZwWFJsWnVWMWhXU0U0eU5IbGhNbVJoVkRCak1tTkdhRlphTWxwQ1VGUXdQUT09")))))))));
			this.txtKetBanTuKhoaTuKhoa.Location = new global::System.Drawing.Point(117, 4);
			this.txtKetBanTuKhoaTuKhoa.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWb2IwMUdUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVjFOR1drMVpWV00xWVVFOVBRPT0="))))))));
			this.txtKetBanTuKhoaTuKhoa.Size = new global::System.Drawing.Size(129, 23);
			this.txtKetBanTuKhoaTuKhoa.TabIndex = 0;
			this.label16.AutoSize = true;
			this.label16.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label16.Location = new global::System.Drawing.Point(7, 7);
			this.label16.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUFdub3dPUT09"))))))));
			this.label16.Size = new global::System.Drawing.Size(60, 16);
			this.label16.TabIndex = 89;
			this.label16.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeGFHUXpjRXBSVjJSb1RXMW9NbVZyYkVkaFJUbHVVRlF3UFE9PQ=="))))))));
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label3.Location = new global::System.Drawing.Point(7, 35);
			this.label3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTI4OQ=="))))))));
			this.label3.Size = new global::System.Drawing.Size(64, 16);
			this.label3.TabIndex = 89;
			this.label3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxVUZwNk1Eaz0="))))))));
			this.nudKetBanTuKhoaSoLuongFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanTuKhoaSoLuongFrom.Location = new global::System.Drawing.Point(117, 32);
			global::System.Windows.Forms.NumericUpDown numericUpDown77 = this.nudKetBanTuKhoaSoLuongFrom;
			int[] array77 = new int[4];
			array77[0] = 1000;
			numericUpDown77.Maximum = new decimal(array77);
			this.nudKetBanTuKhoaSoLuongFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ=="))))))));
			this.nudKetBanTuKhoaSoLuongFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudKetBanTuKhoaSoLuongFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown78 = this.nudKetBanTuKhoaSoLuongFrom;
			int[] array78 = new int[4];
			array78[0] = 5;
			numericUpDown78.Value = new decimal(array78);
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label9.Location = new global::System.Drawing.Point(7, 64);
			this.label9.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWxVOQ=="))))))));
			this.label9.Size = new global::System.Drawing.Size(100, 16);
			this.label9.TabIndex = 89;
			this.label9.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudKetBanTuKhoaDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanTuKhoaDelayFrom.Location = new global::System.Drawing.Point(117, 62);
			global::System.Windows.Forms.NumericUpDown numericUpDown79 = this.nudKetBanTuKhoaDelayFrom;
			int[] array79 = new int[4];
			array79[0] = 1000;
			numericUpDown79.Maximum = new decimal(array79);
			this.nudKetBanTuKhoaDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVTFJeFducFhWbWh6VWpKT2RFOVlVVDA9"))))))));
			this.nudKetBanTuKhoaDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudKetBanTuKhoaDelayFrom.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown80 = this.nudKetBanTuKhoaDelayFrom;
			int[] array80 = new int[4];
			array80[0] = 5;
			numericUpDown80.Value = new decimal(array80);
			this.label70.AutoSize = true;
			this.label70.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label70.Location = new global::System.Drawing.Point(239, 36);
			this.label70.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWs1T1VWUXdPUT09"))))))));
			this.label70.Size = new global::System.Drawing.Size(29, 16);
			this.label70.TabIndex = 91;
			this.label70.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhPSGxPUkRBOQ=="))))))));
			this.label14.AutoSize = true;
			this.label14.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label14.Location = new global::System.Drawing.Point(239, 66);
			this.label14.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUFVWUXdPUT09"))))))));
			this.label14.Size = new global::System.Drawing.Size(31, 16);
			this.label14.TabIndex = 91;
			this.label14.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.nudKetBanTuKhoaSoLuongTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanTuKhoaSoLuongTo.Location = new global::System.Drawing.Point(194, 32);
			global::System.Windows.Forms.NumericUpDown numericUpDown81 = this.nudKetBanTuKhoaSoLuongTo;
			int[] array81 = new int[4];
			array81[0] = 1000;
			numericUpDown81.Maximum = new decimal(array81);
			this.nudKetBanTuKhoaSoLuongTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9"))))))));
			this.nudKetBanTuKhoaSoLuongTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudKetBanTuKhoaSoLuongTo.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown82 = this.nudKetBanTuKhoaSoLuongTo;
			int[] array82 = new int[4];
			array82[0] = 10;
			numericUpDown82.Value = new decimal(array82);
			this.label69.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label69.Location = new global::System.Drawing.Point(162, 36);
			this.label69.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtwUVZWUXdPUT09"))))))));
			this.label69.Size = new global::System.Drawing.Size(29, 16);
			this.label69.TabIndex = 91;
			this.label69.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label69.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.nudKetBanTuKhoaDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanTuKhoaDelayTo.Location = new global::System.Drawing.Point(194, 62);
			global::System.Windows.Forms.NumericUpDown numericUpDown83 = this.nudKetBanTuKhoaDelayTo;
			int[] array83 = new int[4];
			array83[0] = 1000;
			numericUpDown83.Maximum = new decimal(array83);
			this.nudKetBanTuKhoaDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVTFJeFducFhWbWh6VmxkS00xQlVNRDA9"))))))));
			this.nudKetBanTuKhoaDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudKetBanTuKhoaDelayTo.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown84 = this.nudKetBanTuKhoaDelayTo;
			int[] array84 = new int[4];
			array84[0] = 10;
			numericUpDown84.Value = new decimal(array84);
			this.label15.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label15.Location = new global::System.Drawing.Point(162, 66);
			this.label15.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoUFZWUXdPUT09"))))))));
			this.label15.Size = new global::System.Drawing.Size(29, 16);
			this.label15.TabIndex = 91;
			this.label15.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label15.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ckbKetBanGoiY.AutoSize = true;
			this.ckbKetBanGoiY.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbKetBanGoiY.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbKetBanGoiY.Location = new global::System.Drawing.Point(23, 140);
			this.ckbKetBanGoiY.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlZxU1RWalJtUlNVRlF3UFE9PQ=="))))))));
			this.ckbKetBanGoiY.Size = new global::System.Drawing.Size(130, 20);
			this.ckbKetBanGoiY.TabIndex = 2;
			this.ckbKetBanGoiY.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhsMFNFNXVXWHBWVjJSYVpGVmpNbUl4WXpCYU1sSklZVWQ0YVdWVlNuVk9SMG94WVcxR1ZGSkZVakpWVkRBNQ=="))))))));
			this.ckbKetBanGoiY.UseVisualStyleBackColor = true;
			this.ckbKetBanGoiY.CheckedChanged += new global::System.EventHandler(this.ckbKetBanGoiY_CheckedChanged);
			this.plXacNhanKetBan.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plXacNhanKetBan.Controls.Add(this.label26);
			this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanSoLuongFrom);
			this.plXacNhanKetBan.Controls.Add(this.label27);
			this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanDelayFrom);
			this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanDelayTo);
			this.plXacNhanKetBan.Controls.Add(this.label31);
			this.plXacNhanKetBan.Controls.Add(this.nudXacNhanKetBanSoLuongTo);
			this.plXacNhanKetBan.Controls.Add(this.label75);
			this.plXacNhanKetBan.Controls.Add(this.label30);
			this.plXacNhanKetBan.Controls.Add(this.label76);
			this.plXacNhanKetBan.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plXacNhanKetBan.Location = new global::System.Drawing.Point(358, 176);
			this.plXacNhanKetBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GZFdiRmhVYXpsb1VqQmFNVlY2U2xkTlJrWjBVbTVWUFE9PQ=="))))))));
			this.plXacNhanKetBan.Size = new global::System.Drawing.Size(278, 61);
			this.plXacNhanKetBan.TabIndex = 97;
			this.label26.AutoSize = true;
			this.label26.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label26.Location = new global::System.Drawing.Point(7, 7);
			this.label26.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4UFdub3dPUT09"))))))));
			this.label26.Size = new global::System.Drawing.Size(64, 16);
			this.label26.TabIndex = 89;
			this.label26.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxVUZwNk1Eaz0="))))))));
			this.nudXacNhanKetBanSoLuongFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudXacNhanKetBanSoLuongFrom.Location = new global::System.Drawing.Point(117, 4);
			global::System.Windows.Forms.NumericUpDown numericUpDown85 = this.nudXacNhanKetBanSoLuongFrom;
			int[] array85 = new int[4];
			array85[0] = 1000;
			numericUpDown85.Maximum = new decimal(array85);
			this.nudXacNhanKetBanSoLuongFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdKRk5USldSV2hYWkcxS2RGcEZaR3BpVkd3dw=="))))))));
			this.nudXacNhanKetBanSoLuongFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudXacNhanKetBanSoLuongFrom.TabIndex = 0;
			global::System.Windows.Forms.NumericUpDown numericUpDown86 = this.nudXacNhanKetBanSoLuongFrom;
			int[] array86 = new int[4];
			array86[0] = 5;
			numericUpDown86.Value = new decimal(array86);
			this.label27.AutoSize = true;
			this.label27.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label27.Location = new global::System.Drawing.Point(7, 34);
			this.label27.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJ4UFpIb3dPUT09"))))))));
			this.label27.Size = new global::System.Drawing.Size(100, 16);
			this.label27.TabIndex = 89;
			this.label27.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudXacNhanKetBanDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudXacNhanKetBanDelayFrom.Location = new global::System.Drawing.Point(117, 31);
			global::System.Windows.Forms.NumericUpDown numericUpDown87 = this.nudXacNhanKetBanDelayFrom;
			int[] array87 = new int[4];
			array87[0] = 1000;
			numericUpDown87.Maximum = new decimal(array87);
			this.nudXacNhanKetBanDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdFeFNuTlphMlJIVGxaS2RWTnVXbWxWVkRBNQ=="))))))));
			this.nudXacNhanKetBanDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudXacNhanKetBanDelayFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown88 = this.nudXacNhanKetBanDelayFrom;
			int[] array88 = new int[4];
			array88[0] = 5;
			numericUpDown88.Value = new decimal(array88);
			this.label30.AutoSize = true;
			this.label30.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label30.Location = new global::System.Drawing.Point(239, 36);
			this.label30.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCT1VWUXdPUT09"))))))));
			this.label30.Size = new global::System.Drawing.Size(31, 16);
			this.label30.TabIndex = 91;
			this.label30.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.nudXacNhanKetBanDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudXacNhanKetBanDelayTo.Location = new global::System.Drawing.Point(194, 32);
			global::System.Windows.Forms.NumericUpDown numericUpDown89 = this.nudXacNhanKetBanDelayTo;
			int[] array89 = new int[4];
			array89[0] = 1000;
			numericUpDown89.Maximum = new decimal(array89);
			this.nudXacNhanKetBanDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdFeFNuTlphMlJIVGxaYVNFOUVNRDA9"))))))));
			this.nudXacNhanKetBanDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudXacNhanKetBanDelayTo.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown90 = this.nudXacNhanKetBanDelayTo;
			int[] array90 = new int[4];
			array90[0] = 10;
			numericUpDown90.Value = new decimal(array90);
			this.label31.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label31.Location = new global::System.Drawing.Point(162, 36);
			this.label31.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCT1ZWUXdPUT09"))))))));
			this.label31.Size = new global::System.Drawing.Size(29, 16);
			this.label31.TabIndex = 91;
			this.label31.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label31.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label76.AutoSize = true;
			this.label76.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label76.Location = new global::System.Drawing.Point(239, 9);
			this.label76.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWs1UFdub3dPUT09"))))))));
			this.label76.Size = new global::System.Drawing.Size(29, 16);
			this.label76.TabIndex = 91;
			this.label76.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhPSGxPUkRBOQ=="))))))));
			this.nudXacNhanKetBanSoLuongTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudXacNhanKetBanSoLuongTo.Location = new global::System.Drawing.Point(194, 5);
			global::System.Windows.Forms.NumericUpDown numericUpDown91 = this.nudXacNhanKetBanSoLuongTo;
			int[] array91 = new int[4];
			array91[0] = 1000;
			numericUpDown91.Maximum = new decimal(array91);
			this.nudXacNhanKetBanSoLuongTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdKRk5USldSV2hYWkcxS2RGcEdWbWxrZWpBNQ=="))))))));
			this.nudXacNhanKetBanSoLuongTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudXacNhanKetBanSoLuongTo.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown92 = this.nudXacNhanKetBanSoLuongTo;
			int[] array92 = new int[4];
			array92[0] = 10;
			numericUpDown92.Value = new decimal(array92);
			this.label75.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label75.Location = new global::System.Drawing.Point(162, 9);
			this.label75.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWs1UFZWUXdPUT09"))))))));
			this.label75.Size = new global::System.Drawing.Size(29, 16);
			this.label75.TabIndex = 91;
			this.label75.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label75.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.plKetBanGoiY.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plKetBanGoiY.Controls.Add(this.label2);
			this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYSoLuongFrom);
			this.plKetBanGoiY.Controls.Add(this.label4);
			this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYDelayFrom);
			this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYDelayTo);
			this.plKetBanGoiY.Controls.Add(this.label6);
			this.plKetBanGoiY.Controls.Add(this.nudKetBanGoiYSoLuongTo);
			this.plKetBanGoiY.Controls.Add(this.label71);
			this.plKetBanGoiY.Controls.Add(this.label5);
			this.plKetBanGoiY.Controls.Add(this.label72);
			this.plKetBanGoiY.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plKetBanGoiY.Location = new global::System.Drawing.Point(41, 162);
			this.plKetBanGoiY.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GUkdjRmxWYTA1YVZucFdTVmxxU25OWFp6MDk="))))))));
			this.plKetBanGoiY.Size = new global::System.Drawing.Size(278, 64);
			this.plKetBanGoiY.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label2.Location = new global::System.Drawing.Point(7, 7);
			this.label2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJzOQ=="))))))));
			this.label2.Size = new global::System.Drawing.Size(64, 16);
			this.label2.TabIndex = 89;
			this.label2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxVUZwNk1Eaz0="))))))));
			this.nudKetBanGoiYSoLuongFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanGoiYSoLuongFrom.Location = new global::System.Drawing.Point(117, 4);
			global::System.Windows.Forms.NumericUpDown numericUpDown93 = this.nudKetBanGoiYSoLuongFrom;
			int[] array93 = new int[4];
			array93[0] = 1000;
			numericUpDown93.Maximum = new decimal(array93);
			this.nudKetBanGoiYSoLuongFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUlhWRzVhVlZOR1dqSlpiVEZyVWpKT2RFOVlVVDA9"))))))));
			this.nudKetBanGoiYSoLuongFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudKetBanGoiYSoLuongFrom.TabIndex = 0;
			global::System.Windows.Forms.NumericUpDown numericUpDown94 = this.nudKetBanGoiYSoLuongFrom;
			int[] array94 = new int[4];
			array94[0] = 5;
			numericUpDown94.Value = new decimal(array94);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label4.Location = new global::System.Drawing.Point(7, 36);
			this.label4.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtFOQ=="))))))));
			this.label4.Size = new global::System.Drawing.Size(100, 16);
			this.label4.TabIndex = 89;
			this.label4.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudKetBanGoiYDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanGoiYDelayFrom.Location = new global::System.Drawing.Point(117, 33);
			global::System.Windows.Forms.NumericUpDown numericUpDown95 = this.nudKetBanGoiYDelayFrom;
			int[] array95 = new int[4];
			array95[0] = 1000;
			numericUpDown95.Maximum = new decimal(array95);
			this.nudKetBanGoiYDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUldWVzE0YVZJd1dURlZiVFZMWkcxS1VsQlVNRDA9"))))))));
			this.nudKetBanGoiYDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudKetBanGoiYDelayFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown96 = this.nudKetBanGoiYDelayFrom;
			int[] array96 = new int[4];
			array96[0] = 5;
			numericUpDown96.Value = new decimal(array96);
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label5.Location = new global::System.Drawing.Point(239, 38);
			this.label5.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtVOQ=="))))))));
			this.label5.Size = new global::System.Drawing.Size(31, 16);
			this.label5.TabIndex = 91;
			this.label5.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.nudKetBanGoiYDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanGoiYDelayTo.Location = new global::System.Drawing.Point(194, 34);
			global::System.Windows.Forms.NumericUpDown numericUpDown97 = this.nudKetBanGoiYDelayTo;
			int[] array97 = new int[4];
			array97[0] = 1000;
			numericUpDown97.Maximum = new decimal(array97);
			this.nudKetBanGoiYDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUldWVzE0YVZJd1dURldhMk0wVUZFOVBRPT0="))))))));
			this.nudKetBanGoiYDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudKetBanGoiYDelayTo.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown98 = this.nudKetBanGoiYDelayTo;
			int[] array98 = new int[4];
			array98[0] = 10;
			numericUpDown98.Value = new decimal(array98);
			this.label6.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label6.Location = new global::System.Drawing.Point(162, 38);
			this.label6.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtrOQ=="))))))));
			this.label6.Size = new global::System.Drawing.Size(29, 16);
			this.label6.TabIndex = 91;
			this.label6.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label6.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label72.AutoSize = true;
			this.label72.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label72.Location = new global::System.Drawing.Point(239, 9);
			this.label72.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWs1T1dub3dPUT09"))))))));
			this.label72.Size = new global::System.Drawing.Size(29, 16);
			this.label72.TabIndex = 91;
			this.label72.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFNWUlhPSGxPUkRBOQ=="))))))));
			this.nudKetBanGoiYSoLuongTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudKetBanGoiYSoLuongTo.Location = new global::System.Drawing.Point(194, 5);
			global::System.Windows.Forms.NumericUpDown numericUpDown99 = this.nudKetBanGoiYSoLuongTo;
			int[] array99 = new int[4];
			array99[0] = 1000;
			numericUpDown99.Maximum = new decimal(array99);
			this.nudKetBanGoiYSoLuongTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUlhWRzVhVlZOR1dqSlpiVEZyVmxkS00xQlVNRDA9"))))))));
			this.nudKetBanGoiYSoLuongTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudKetBanGoiYSoLuongTo.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown100 = this.nudKetBanGoiYSoLuongTo;
			int[] array100 = new int[4];
			array100[0] = 10;
			numericUpDown100.Value = new decimal(array100);
			this.label71.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label71.Location = new global::System.Drawing.Point(162, 9);
			this.label71.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWs1T1ZWUXdPUT09"))))))));
			this.label71.Size = new global::System.Drawing.Size(29, 16);
			this.label71.TabIndex = 91;
			this.label71.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label71.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ckbKetBanTepUid.AutoSize = true;
			this.ckbKetBanTepUid.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbKetBanTepUid.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbKetBanTepUid.Location = new global::System.Drawing.Point(338, 20);
			this.ckbKetBanTepUid.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2R6UFE9PQ=="))))))));
			this.ckbKetBanTepUid.Size = new global::System.Drawing.Size(145, 20);
			this.ckbKetBanTepUid.TabIndex = 4;
			this.ckbKetBanTepUid.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlhsMFNFNXVXWHBWVjJSYVpGVmpNbUl4WXpCYU1sSklZVWQ0YVdWVlNYZE9SMG94VTBkT1JGRnNXbFJXVmtVNQ=="))))))));
			this.ckbKetBanTepUid.UseVisualStyleBackColor = true;
			this.ckbKetBanTepUid.CheckedChanged += new global::System.EventHandler(this.ckbKetBanTepUid_CheckedChanged);
			this.ckbXacNhanKetBan.AutoSize = true;
			this.ckbXacNhanKetBan.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbXacNhanKetBan.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbXacNhanKetBan.Location = new global::System.Drawing.Point(338, 154);
			this.ckbXacNhanKetBan.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVZwNk1Eaz0="))))))));
			this.ckbXacNhanKetBan.Size = new global::System.Drawing.Size(126, 20);
			this.ckbXacNhanKetBan.TabIndex = 6;
			this.ckbXacNhanKetBan.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHRkdiRFZSYmxab1ZEQmpNbU5zWXpCYU1rVnlVbnBhTWsweFJtNVhXRlpJVG0wNVdFNUVNRDA9"))))))));
			this.ckbXacNhanKetBan.UseVisualStyleBackColor = true;
			this.ckbXacNhanKetBan.CheckedChanged += new global::System.EventHandler(this.ckbXacNhanKetBan_CheckedChanged);
			this.groupBox7.Controls.Add(this.ckbThamGiaNhom);
			this.groupBox7.Controls.Add(this.plThamGiaNhom);
			this.groupBox7.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.groupBox7.Location = new global::System.Drawing.Point(662, 424);
			this.groupBox7.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwT1MyUnRVbGxSYTA1cFRUSmplZz09"))))))));
			this.groupBox7.Size = new global::System.Drawing.Size(344, 243);
			this.groupBox7.TabIndex = 4;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2IyRkhTbFJSYlRWb1ZqQldibGx0TVc5a2JuQktVbTVSUFE9PQ=="))))))));
			this.ckbThamGiaNhom.AutoSize = true;
			this.ckbThamGiaNhom.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbThamGiaNhom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbThamGiaNhom.Location = new global::System.Drawing.Point(23, 22);
			this.ckbThamGiaNhom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVVF3UFE9PQ=="))))))));
			this.ckbThamGiaNhom.Size = new global::System.Drawing.Size(184, 20);
			this.ckbThamGiaNhom.TabIndex = 0;
			this.ckbThamGiaNhom.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2IyRkhTbFJSYlRWb1ZqQldibGx0TVhGU1NFMTVUVWRrYTFJeWFITlpibXhEVFVoak1tTnJNWFpOTUVadVZURldVbEJSUFQwPQ=="))))))));
			this.ckbThamGiaNhom.UseVisualStyleBackColor = true;
			this.ckbThamGiaNhom.CheckedChanged += new global::System.EventHandler(this.ckbThamGiaNhom_CheckedChanged);
			this.plThamGiaNhom.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.plThamGiaNhom.Controls.Add(this.ckbThamGiaNhomTrungNhau);
			this.plThamGiaNhom.Controls.Add(this.ckbThamGiaNhomTraLoiCauHoi);
			this.plThamGiaNhom.Controls.Add(this.label12);
			this.plThamGiaNhom.Controls.Add(this.label13);
			this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomSoLuongFrom);
			this.plThamGiaNhom.Controls.Add(this.label32);
			this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomDelayFrom);
			this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomSoLuongTo);
			this.plThamGiaNhom.Controls.Add(this.nudThamGiaNhomDelayTo);
			this.plThamGiaNhom.Controls.Add(this.btnThamGiaNhomTraLoiCauHoi);
			this.plThamGiaNhom.Controls.Add(this.label77);
			this.plThamGiaNhom.Controls.Add(this.button1);
			this.plThamGiaNhom.Controls.Add(this.label63);
			this.plThamGiaNhom.Controls.Add(this.label78);
			this.plThamGiaNhom.Controls.Add(this.label34);
			this.plThamGiaNhom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.plThamGiaNhom.Location = new global::System.Drawing.Point(39, 43);
			this.plThamGiaNhom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa05GWlhSa2hTYmxKVFRXMTRiMVpITVc5a2JVcFNVRlF3UFE9PQ=="))))))));
			this.plThamGiaNhom.Size = new global::System.Drawing.Size(291, 148);
			this.plThamGiaNhom.TabIndex = 1;
			this.ckbThamGiaNhomTrungNhau.AutoSize = true;
			this.ckbThamGiaNhomTrungNhau.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbThamGiaNhomTrungNhau.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbThamGiaNhomTrungNhau.Location = new global::System.Drawing.Point(10, 92);
			this.ckbThamGiaNhomTrungNhau.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpXYW1Kc1dqRlhha0V4WWpGc1dWWlVNRDA9"))))))));
			this.ckbThamGiaNhomTrungNhau.Size = new global::System.Drawing.Size(237, 20);
			this.ckbThamGiaNhomTrungNhau.TabIndex = 112;
			this.ckbThamGiaNhomTrungNhau.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2IyUnJiRWxSYlRrelRtMTRNMU5WYUZOaU1XeFlUVWRrWVUxdGVHOVRWV014WWpOak0xUnVVa3BUUmtvMVpIcGtjMlJXY0RWUmJsWm9VakJaZUE9PQ=="))))))));
			this.ckbThamGiaNhomTrungNhau.UseVisualStyleBackColor = true;
			this.ckbThamGiaNhomTrungNhau.CheckedChanged += new global::System.EventHandler(this.ckbThamGiaNhomTraLoiCauHoi_CheckedChanged);
			this.ckbThamGiaNhomTraLoiCauHoi.AutoSize = true;
			this.ckbThamGiaNhomTraLoiCauHoi.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ckbThamGiaNhomTraLoiCauHoi.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.ckbThamGiaNhomTraLoiCauHoi.Location = new global::System.Drawing.Point(10, 118);
			this.ckbThamGiaNhomTraLoiCauHoi.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS01HRldXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpXYW1KVldrNVpha3B6VWtac1dWWnJiR2xOYlhNNQ=="))))))));
			this.ckbThamGiaNhomTraLoiCauHoi.Size = new global::System.Drawing.Size(157, 20);
			this.ckbThamGiaNhomTraLoiCauHoi.TabIndex = 112;
			this.ckbThamGiaNhomTraLoiCauHoi.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeGFHUXpjRXhVVjJRMFUydG9SV1JGTVRWaGJVcDBXVEprYTFORmNHOWxhMnh5V2pKS1RsbFhhRFpUVlVwM1UxVmtVVkpIT1hWV1YyUm9Vbms1VG1GV1pISlFVVDA5"))))))));
			this.ckbThamGiaNhomTraLoiCauHoi.UseVisualStyleBackColor = true;
			this.ckbThamGiaNhomTraLoiCauHoi.CheckedChanged += new global::System.EventHandler(this.ckbThamGiaNhomTraLoiCauHoi_CheckedChanged);
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label12.Location = new global::System.Drawing.Point(10, 7);
			this.label12.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1dub3dPUT09"))))))));
			this.label12.Size = new global::System.Drawing.Size(80, 16);
			this.label12.TabIndex = 89;
			this.label12.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQkpkMlI2V25sVVZ6aDZVVmRrVkZaV1JUST0="))))))));
			this.label13.AutoSize = true;
			this.label13.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label13.Location = new global::System.Drawing.Point(10, 35);
			this.label13.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTJoT1pIb3dPUT09"))))))));
			this.label13.Size = new global::System.Drawing.Size(64, 16);
			this.label13.TabIndex = 89;
			this.label13.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSb1VFMUljRXBTVjJScFZGZEdNMlZJUmtsVVZ6aDVUbGMxVUZwNk1Eaz0="))))))));
			this.nudThamGiaNhomSoLuongFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudThamGiaNhomSoLuongFrom.Location = new global::System.Drawing.Point(127, 33);
			global::System.Windows.Forms.NumericUpDown numericUpDown101 = this.nudThamGiaNhomSoLuongFrom;
			int[] array101 = new int[4];
			array101[0] = 1000;
			numericUpDown101.Maximum = new decimal(array101);
			this.nudThamGiaNhomSoLuongFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpTYVUxSVozaFpha2t4WW14S2RWTnVXbWxWVkRBNQ=="))))))));
			this.nudThamGiaNhomSoLuongFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudThamGiaNhomSoLuongFrom.TabIndex = 1;
			global::System.Windows.Forms.NumericUpDown numericUpDown102 = this.nudThamGiaNhomSoLuongFrom;
			int[] array102 = new int[4];
			array102[0] = 5;
			numericUpDown102.Value = new decimal(array102);
			this.label32.AutoSize = true;
			this.label32.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label32.Location = new global::System.Drawing.Point(10, 64);
			this.label32.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCT1dub3dPUT09"))))))));
			this.label32.Size = new global::System.Drawing.Size(100, 16);
			this.label32.TabIndex = 89;
			this.label32.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a2NWSXlPV3BsVlVab1ZUQktkVmxXWkVka1ZXeElWVzE0YVZJd1dURlVNbU01VUZFOVBRPT0="))))))));
			this.nudThamGiaNhomDelayFrom.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudThamGiaNhomDelayFrom.Location = new global::System.Drawing.Point(127, 62);
			global::System.Windows.Forms.NumericUpDown numericUpDown103 = this.nudThamGiaNhomDelayFrom;
			int[] array103 = new int[4];
			array103[0] = 1000;
			numericUpDown103.Maximum = new decimal(array103);
			this.nudThamGiaNhomDelayFrom.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlZXWVZZemFHOWFWbFpoWlZkSmVVMUVNRDA9"))))))));
			this.nudThamGiaNhomDelayFrom.Size = new global::System.Drawing.Size(42, 23);
			this.nudThamGiaNhomDelayFrom.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown104 = this.nudThamGiaNhomDelayFrom;
			int[] array104 = new int[4];
			array104[0] = 5;
			numericUpDown104.Value = new decimal(array104);
			this.label78.AutoSize = true;
			this.label78.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label78.Location = new global::System.Drawing.Point(250, 37);
			this.label78.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWs1UVVWUXdPUT09"))))))));
			this.label78.Size = new global::System.Drawing.Size(40, 16);
			this.label78.TabIndex = 91;
			this.label78.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cweGIyUnVjRXBTYmxFOQ=="))))))));
			this.label34.AutoSize = true;
			this.label34.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label34.Location = new global::System.Drawing.Point(250, 65);
			this.label34.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrTTNCUFVWUXdPUT09"))))))));
			this.label34.Size = new global::System.Drawing.Size(31, 16);
			this.label34.TabIndex = 91;
			this.label34.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RWSkhPWFZoZWpBOQ=="))))))));
			this.nudThamGiaNhomSoLuongTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudThamGiaNhomSoLuongTo.Location = new global::System.Drawing.Point(204, 32);
			global::System.Windows.Forms.NumericUpDown numericUpDown105 = this.nudThamGiaNhomSoLuongTo;
			int[] array105 = new int[4];
			array105[0] = 1000;
			numericUpDown105.Maximum = new decimal(array105);
			this.nudThamGiaNhomSoLuongTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpTYVUxSVozaFpha2t4WW14YVNFOUVNRDA9"))))))));
			this.nudThamGiaNhomSoLuongTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudThamGiaNhomSoLuongTo.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown106 = this.nudThamGiaNhomSoLuongTo;
			int[] array106 = new int[4];
			array106[0] = 10;
			numericUpDown106.Value = new decimal(array106);
			this.nudThamGiaNhomDelayTo.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.nudThamGiaNhomDelayTo.Location = new global::System.Drawing.Point(204, 62);
			global::System.Windows.Forms.NumericUpDown numericUpDown107 = this.nudThamGiaNhomDelayTo;
			int[] array107 = new int[4];
			array107[0] = 1000;
			numericUpDown107.Maximum = new decimal(array107);
			this.nudThamGiaNhomDelayTo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlZXWVZZemFHOWFWbHBUWkdjOVBRPT0="))))))));
			this.nudThamGiaNhomDelayTo.Size = new global::System.Drawing.Size(47, 23);
			this.nudThamGiaNhomDelayTo.TabIndex = 3;
			global::System.Windows.Forms.NumericUpDown numericUpDown108 = this.nudThamGiaNhomDelayTo;
			int[] array108 = new int[4];
			array108[0] = 10;
			numericUpDown108.Value = new decimal(array108);
			this.btnThamGiaNhomTraLoiCauHoi.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnThamGiaNhomTraLoiCauHoi.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.btnThamGiaNhomTraLoiCauHoi.Location = new global::System.Drawing.Point(170, 114);
			this.btnThamGiaNhomTraLoiCauHoi.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpXYW1KVldrNVpha3B6VWtac1dWWnJiR2xOYlhNNQ=="))))))));
			this.btnThamGiaNhomTraLoiCauHoi.Size = new global::System.Drawing.Size(103, 27);
			this.btnThamGiaNhomTraLoiCauHoi.TabIndex = 4;
			this.btnThamGiaNhomTraLoiCauHoi.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibU01VUZFOVBRPT0="))))))));
			this.toolTip1.SetToolTip(this.btnThamGiaNhomTraLoiCauHoi, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWkZoak0xWkZNWFpOYlhSdVYydG9WMlJXY0RWUmJYQXpUbXR2ZUZOVmFGTmxWbXhxWlZWd1NsSXpjRWhpTWs0MVVWZEdVbEJVTUQwPQ==")))))))));
			this.btnThamGiaNhomTraLoiCauHoi.UseVisualStyleBackColor = true;
			this.btnThamGiaNhomTraLoiCauHoi.Click += new global::System.EventHandler(this.button5_Click);
			this.label77.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label77.Location = new global::System.Drawing.Point(172, 37);
			this.label77.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWs1UFpIb3dPUT09"))))))));
			this.label77.Size = new global::System.Drawing.Size(29, 16);
			this.label77.TabIndex = 91;
			this.label77.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label77.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.button1.Location = new global::System.Drawing.Point(126, 2);
			this.button1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1ZWUXdPUT09"))))))));
			this.button1.Size = new global::System.Drawing.Size(80, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVWUXdPUT09"))))))));
			this.toolTip1.SetToolTip(this.button1, global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVTJ4S1JGRnVWbWhTZVRsT1dqRmpkMW94YXpSVU1tdzJVMVZLTVZOVmFGTmlNV3hZVFVka1lVMXRlRzg9")))))))));
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.label63.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label63.Location = new global::System.Drawing.Point(172, 65);
			this.label63.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWtwT1pIb3dPUT09"))))))));
			this.label63.Size = new global::System.Drawing.Size(29, 16);
			this.label63.TabIndex = 91;
			this.label63.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSklSbnBsVlVwcFdub3dPUT09"))))))));
			this.label63.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.AutomaticDelay = 0;
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 200;
			this.toolTip1.ReshowDelay = 40;
			this.toolTip1.ToolTipTitle = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NWSklWbkJSYWtKb1ZGVTVNRmRVU201UVVUMDk="))))))));
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.pnlHeader;
			this.bunifuDragControl1.Vertical = true;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.bunifuCustomLabel1;
			this.bunifuDragControl2.Vertical = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1012, 716);
			base.Controls.Add(this.groupBox5);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.groupBox8);
			base.Controls.Add(this.groupBox7);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnAdd);
			base.Controls.Add(this.bunifuCards1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMFQyUnRTblJYYmtKaFRVZDRNVnBGWkZkbFZteFlWR3BCUFE9PQ=="))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1YU1sSk9XVmhrTkdOVldqRlhibXhEVFVoak1sSnRiejA9"))))))));
			base.Load += new global::System.EventHandler(this.FConfigInteract_Load);
			this.bunifuCards1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.plTuongTacCMSN.ResumeLayout(false);
			this.plTuongTacCMSN.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNSoLuongFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacCMSNDelayTo).EndInit();
			this.plTuongTacNhanTin.ResumeLayout(false);
			this.plTuongTacNhanTin.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinSoLuongFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNhanTinSoLuongTo).EndInit();
			this.plTuongTacChoc.ResumeLayout(false);
			this.plTuongTacChoc.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacChocSoLuongDelayTo).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.plTuongTacFanpage.ResumeLayout(false);
			this.plTuongTacFanpage.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongPageFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongBaiVietFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongPageTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFanpageSoLuongBaiVietTo).EndInit();
			this.plTuongTacGroup.ResumeLayout(false);
			this.plTuongTacGroup.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongNhomFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongBaiVietFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongBaiVietTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacGroupSoLuongNhomTo).EndInit();
			this.plTuongTacFriend.ResumeLayout(false);
			this.plTuongTacFriend.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBanBeFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBaiVietFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBaiVietTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendSoLuongBanBeTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacFriendDelayTo).EndInit();
			this.plTuongTacNewsfeed.ResumeLayout(false);
			this.plTuongTacNewsfeed.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedSoLuongFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudTuongTacNewsfeedDelayTo).EndInit();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.plKetBanTepUid.ResumeLayout(false);
			this.plKetBanTepUid.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidSoLuongFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTepUidSoLuongTo).EndInit();
			this.plKetBanTuKhoa.ResumeLayout(false);
			this.plKetBanTuKhoa.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaSoLuongFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanTuKhoaDelayTo).EndInit();
			this.plXacNhanKetBan.ResumeLayout(false);
			this.plXacNhanKetBan.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanSoLuongFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudXacNhanKetBanSoLuongTo).EndInit();
			this.plKetBanGoiY.ResumeLayout(false);
			this.plKetBanGoiY.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYSoLuongFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYDelayTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudKetBanGoiYSoLuongTo).EndInit();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.plThamGiaNhom.ResumeLayout(false);
			this.plThamGiaNhom.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomSoLuongFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomDelayFrom).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomSoLuongTo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.nudThamGiaNhomDelayTo).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001817 RID: 6167
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04001818 RID: 6168
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04001819 RID: 6169
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x0400181A RID: 6170
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x0400181B RID: 6171
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x0400181C RID: 6172
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x0400181D RID: 6173
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x0400181E RID: 6174
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x0400181F RID: 6175
		private global::System.Windows.Forms.Panel plTuongTacCMSN;

		// Token: 0x04001820 RID: 6176
		private global::System.Windows.Forms.RadioButton rbTuongTacCMSNDangBai;

		// Token: 0x04001821 RID: 6177
		private global::System.Windows.Forms.RadioButton rbTuongTacCMSNNhanTin;

		// Token: 0x04001822 RID: 6178
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04001823 RID: 6179
		private global::System.Windows.Forms.NumericUpDown nudTuongTacCMSNSoLuongFrom;

		// Token: 0x04001824 RID: 6180
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04001825 RID: 6181
		private global::System.Windows.Forms.Label label28;

		// Token: 0x04001826 RID: 6182
		private global::System.Windows.Forms.Label label35;

		// Token: 0x04001827 RID: 6183
		private global::System.Windows.Forms.NumericUpDown nudTuongTacCMSNDelayFrom;

		// Token: 0x04001828 RID: 6184
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04001829 RID: 6185
		private global::System.Windows.Forms.Label label37;

		// Token: 0x0400182A RID: 6186
		private global::System.Windows.Forms.NumericUpDown nudTuongTacCMSNDelayTo;

		// Token: 0x0400182B RID: 6187
		private global::System.Windows.Forms.Label label45;

		// Token: 0x0400182C RID: 6188
		private global::System.Windows.Forms.Panel plTuongTacNhanTin;

		// Token: 0x0400182D RID: 6189
		private global::System.Windows.Forms.Button btnInbox;

		// Token: 0x0400182E RID: 6190
		private global::System.Windows.Forms.Label label41;

		// Token: 0x0400182F RID: 6191
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNhanTinSoLuongFrom;

		// Token: 0x04001830 RID: 6192
		private global::System.Windows.Forms.Label label42;

		// Token: 0x04001831 RID: 6193
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNhanTinDelayFrom;

		// Token: 0x04001832 RID: 6194
		private global::System.Windows.Forms.Label label43;

		// Token: 0x04001833 RID: 6195
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNhanTinDelayTo;

		// Token: 0x04001834 RID: 6196
		private global::System.Windows.Forms.Label label44;

		// Token: 0x04001835 RID: 6197
		private global::System.Windows.Forms.Panel plTuongTacChoc;

		// Token: 0x04001836 RID: 6198
		private global::System.Windows.Forms.Label label36;

		// Token: 0x04001837 RID: 6199
		private global::System.Windows.Forms.NumericUpDown nudTuongTacChocSoLuongFrom;

		// Token: 0x04001838 RID: 6200
		private global::System.Windows.Forms.Label label38;

		// Token: 0x04001839 RID: 6201
		private global::System.Windows.Forms.NumericUpDown nudTuongTacChocSoLuongDelayFrom;

		// Token: 0x0400183A RID: 6202
		private global::System.Windows.Forms.Label label39;

		// Token: 0x0400183B RID: 6203
		private global::System.Windows.Forms.NumericUpDown nudTuongTacChocSoLuongDelayTo;

		// Token: 0x0400183C RID: 6204
		private global::System.Windows.Forms.Label label40;

		// Token: 0x0400183D RID: 6205
		private global::System.Windows.Forms.CheckBox ckbTuongTacNhanTin;

		// Token: 0x0400183E RID: 6206
		private global::System.Windows.Forms.CheckBox ckbTuongTacChoc;

		// Token: 0x0400183F RID: 6207
		private global::System.Windows.Forms.CheckBox ckbTuongTacCMSN;

		// Token: 0x04001840 RID: 6208
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04001841 RID: 6209
		private global::System.Windows.Forms.Panel plTuongTacFanpage;

		// Token: 0x04001842 RID: 6210
		private global::System.Windows.Forms.Label label56;

		// Token: 0x04001843 RID: 6211
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageSoLuongPageFrom;

		// Token: 0x04001844 RID: 6212
		private global::System.Windows.Forms.Label label58;

		// Token: 0x04001845 RID: 6213
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageSoLuongBaiVietFrom;

		// Token: 0x04001846 RID: 6214
		private global::System.Windows.Forms.CheckBox ckbTuongTacFanpageComment;

		// Token: 0x04001847 RID: 6215
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04001848 RID: 6216
		private global::System.Windows.Forms.Button btnTuongTacFanpageComment;

		// Token: 0x04001849 RID: 6217
		private global::System.Windows.Forms.CheckBox ckbTuongTacFanpageLike;

		// Token: 0x0400184A RID: 6218
		private global::System.Windows.Forms.Label label59;

		// Token: 0x0400184B RID: 6219
		private global::System.Windows.Forms.Label label60;

		// Token: 0x0400184C RID: 6220
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageDelayFrom;

		// Token: 0x0400184D RID: 6221
		private global::System.Windows.Forms.Label label61;

		// Token: 0x0400184E RID: 6222
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageDelayTo;

		// Token: 0x0400184F RID: 6223
		private global::System.Windows.Forms.Label label62;

		// Token: 0x04001850 RID: 6224
		private global::System.Windows.Forms.Panel plTuongTacGroup;

		// Token: 0x04001851 RID: 6225
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04001852 RID: 6226
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupSoLuongNhomFrom;

		// Token: 0x04001853 RID: 6227
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04001854 RID: 6228
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupSoLuongBaiVietFrom;

		// Token: 0x04001855 RID: 6229
		private global::System.Windows.Forms.CheckBox ckbTuongTacGroupComment;

		// Token: 0x04001856 RID: 6230
		private global::System.Windows.Forms.Button btnTuongTacGroupComment;

		// Token: 0x04001857 RID: 6231
		private global::System.Windows.Forms.CheckBox ckbTuongTacGroupLike;

		// Token: 0x04001858 RID: 6232
		private global::System.Windows.Forms.Label label50;

		// Token: 0x04001859 RID: 6233
		private global::System.Windows.Forms.Label label51;

		// Token: 0x0400185A RID: 6234
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupDelayFrom;

		// Token: 0x0400185B RID: 6235
		private global::System.Windows.Forms.Label label52;

		// Token: 0x0400185C RID: 6236
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupDelayTo;

		// Token: 0x0400185D RID: 6237
		private global::System.Windows.Forms.Label label53;

		// Token: 0x0400185E RID: 6238
		private global::System.Windows.Forms.Panel plTuongTacFriend;

		// Token: 0x0400185F RID: 6239
		private global::System.Windows.Forms.Label label49;

		// Token: 0x04001860 RID: 6240
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendSoLuongBanBeFrom;

		// Token: 0x04001861 RID: 6241
		private global::System.Windows.Forms.Label label54;

		// Token: 0x04001862 RID: 6242
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04001863 RID: 6243
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendSoLuongBaiVietFrom;

		// Token: 0x04001864 RID: 6244
		private global::System.Windows.Forms.CheckBox ckbTuongTacFriendComment;

		// Token: 0x04001865 RID: 6245
		private global::System.Windows.Forms.Button btnTuongTacFriendComment;

		// Token: 0x04001866 RID: 6246
		private global::System.Windows.Forms.CheckBox ckbTuongTacFriendLike;

		// Token: 0x04001867 RID: 6247
		private global::System.Windows.Forms.Label label33;

		// Token: 0x04001868 RID: 6248
		private global::System.Windows.Forms.Label label46;

		// Token: 0x04001869 RID: 6249
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendDelayFrom;

		// Token: 0x0400186A RID: 6250
		private global::System.Windows.Forms.Label label47;

		// Token: 0x0400186B RID: 6251
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendDelayTo;

		// Token: 0x0400186C RID: 6252
		private global::System.Windows.Forms.Label label48;

		// Token: 0x0400186D RID: 6253
		private global::System.Windows.Forms.Panel plTuongTacNewsfeed;

		// Token: 0x0400186E RID: 6254
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400186F RID: 6255
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNewsfeedSoLuongFrom;

		// Token: 0x04001870 RID: 6256
		private global::System.Windows.Forms.CheckBox ckbTuongTacNewsfeedComment;

		// Token: 0x04001871 RID: 6257
		private global::System.Windows.Forms.Button btnTuongTacNewsfeedComment;

		// Token: 0x04001872 RID: 6258
		private global::System.Windows.Forms.CheckBox ckbTuongTacNewsfeedLike;

		// Token: 0x04001873 RID: 6259
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04001874 RID: 6260
		private global::System.Windows.Forms.Label label24;

		// Token: 0x04001875 RID: 6261
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNewsfeedDelayFrom;

		// Token: 0x04001876 RID: 6262
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04001877 RID: 6263
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNewsfeedDelayTo;

		// Token: 0x04001878 RID: 6264
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04001879 RID: 6265
		private global::System.Windows.Forms.CheckBox ckbTuongTacFanpage;

		// Token: 0x0400187A RID: 6266
		private global::System.Windows.Forms.CheckBox ckbTuongTacGroup;

		// Token: 0x0400187B RID: 6267
		private global::System.Windows.Forms.CheckBox ckbTuongTacNewsfeed;

		// Token: 0x0400187C RID: 6268
		private global::System.Windows.Forms.CheckBox ckbTuongTacFriend;

		// Token: 0x0400187D RID: 6269
		private global::System.Windows.Forms.GroupBox groupBox8;

		// Token: 0x0400187E RID: 6270
		private global::System.Windows.Forms.CheckBox ckbKetBanGoiY;

		// Token: 0x0400187F RID: 6271
		private global::System.Windows.Forms.CheckBox ckbXacNhanKetBan;

		// Token: 0x04001880 RID: 6272
		private global::System.Windows.Forms.CheckBox ckbKetBanTepUid;

		// Token: 0x04001881 RID: 6273
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04001882 RID: 6274
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x04001883 RID: 6275
		private global::System.Windows.Forms.CheckBox ckbThamGiaNhom;

		// Token: 0x04001884 RID: 6276
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04001885 RID: 6277
		private global::System.Windows.Forms.CheckBox ckbKetBanTuKhoa;

		// Token: 0x04001886 RID: 6278
		private global::System.Windows.Forms.Panel plKetBanTepUid;

		// Token: 0x04001887 RID: 6279
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04001888 RID: 6280
		private global::System.Windows.Forms.Label label20;

		// Token: 0x04001889 RID: 6281
		private global::System.Windows.Forms.NumericUpDown nudKetBanTepUidSoLuongFrom;

		// Token: 0x0400188A RID: 6282
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400188B RID: 6283
		private global::System.Windows.Forms.NumericUpDown nudKetBanTepUidDelayFrom;

		// Token: 0x0400188C RID: 6284
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400188D RID: 6285
		private global::System.Windows.Forms.NumericUpDown nudKetBanTepUidDelayTo;

		// Token: 0x0400188E RID: 6286
		private global::System.Windows.Forms.Label label23;

		// Token: 0x0400188F RID: 6287
		private global::System.Windows.Forms.Panel plKetBanTuKhoa;

		// Token: 0x04001890 RID: 6288
		private global::System.Windows.Forms.TextBox txtKetBanTuKhoaTuKhoa;

		// Token: 0x04001891 RID: 6289
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04001892 RID: 6290
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001893 RID: 6291
		private global::System.Windows.Forms.NumericUpDown nudKetBanTuKhoaSoLuongFrom;

		// Token: 0x04001894 RID: 6292
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04001895 RID: 6293
		private global::System.Windows.Forms.NumericUpDown nudKetBanTuKhoaDelayFrom;

		// Token: 0x04001896 RID: 6294
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04001897 RID: 6295
		private global::System.Windows.Forms.NumericUpDown nudKetBanTuKhoaDelayTo;

		// Token: 0x04001898 RID: 6296
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04001899 RID: 6297
		private global::System.Windows.Forms.Panel plXacNhanKetBan;

		// Token: 0x0400189A RID: 6298
		private global::System.Windows.Forms.Label label26;

		// Token: 0x0400189B RID: 6299
		private global::System.Windows.Forms.NumericUpDown nudXacNhanKetBanSoLuongFrom;

		// Token: 0x0400189C RID: 6300
		private global::System.Windows.Forms.Label label27;

		// Token: 0x0400189D RID: 6301
		private global::System.Windows.Forms.NumericUpDown nudXacNhanKetBanDelayFrom;

		// Token: 0x0400189E RID: 6302
		private global::System.Windows.Forms.Label label30;

		// Token: 0x0400189F RID: 6303
		private global::System.Windows.Forms.NumericUpDown nudXacNhanKetBanDelayTo;

		// Token: 0x040018A0 RID: 6304
		private global::System.Windows.Forms.Label label31;

		// Token: 0x040018A1 RID: 6305
		private global::System.Windows.Forms.Panel plKetBanGoiY;

		// Token: 0x040018A2 RID: 6306
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040018A3 RID: 6307
		private global::System.Windows.Forms.NumericUpDown nudKetBanGoiYSoLuongFrom;

		// Token: 0x040018A4 RID: 6308
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040018A5 RID: 6309
		private global::System.Windows.Forms.NumericUpDown nudKetBanGoiYDelayFrom;

		// Token: 0x040018A6 RID: 6310
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040018A7 RID: 6311
		private global::System.Windows.Forms.NumericUpDown nudKetBanGoiYDelayTo;

		// Token: 0x040018A8 RID: 6312
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040018A9 RID: 6313
		private global::System.Windows.Forms.Panel plThamGiaNhom;

		// Token: 0x040018AA RID: 6314
		private global::System.Windows.Forms.CheckBox ckbThamGiaNhomTraLoiCauHoi;

		// Token: 0x040018AB RID: 6315
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040018AC RID: 6316
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040018AD RID: 6317
		private global::System.Windows.Forms.NumericUpDown nudThamGiaNhomSoLuongFrom;

		// Token: 0x040018AE RID: 6318
		private global::System.Windows.Forms.Label label32;

		// Token: 0x040018AF RID: 6319
		private global::System.Windows.Forms.NumericUpDown nudThamGiaNhomDelayFrom;

		// Token: 0x040018B0 RID: 6320
		private global::System.Windows.Forms.Label label34;

		// Token: 0x040018B1 RID: 6321
		private global::System.Windows.Forms.NumericUpDown nudThamGiaNhomDelayTo;

		// Token: 0x040018B2 RID: 6322
		private global::System.Windows.Forms.Button btnThamGiaNhomTraLoiCauHoi;

		// Token: 0x040018B3 RID: 6323
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040018B4 RID: 6324
		private global::System.Windows.Forms.Label label63;

		// Token: 0x040018B5 RID: 6325
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040018B6 RID: 6326
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040018B7 RID: 6327
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040018B8 RID: 6328
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x040018B9 RID: 6329
		private global::System.Windows.Forms.CheckBox ckbKetBanTepUidTrungNhau;

		// Token: 0x040018BA RID: 6330
		private global::System.Windows.Forms.CheckBox ckbThamGiaNhomTrungNhau;

		// Token: 0x040018BB RID: 6331
		private global::System.Windows.Forms.Label label80;

		// Token: 0x040018BC RID: 6332
		private global::System.Windows.Forms.NumericUpDown nudTuongTacCMSNSoLuongTo;

		// Token: 0x040018BD RID: 6333
		private global::System.Windows.Forms.Label label79;

		// Token: 0x040018BE RID: 6334
		private global::System.Windows.Forms.Label label84;

		// Token: 0x040018BF RID: 6335
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNhanTinSoLuongTo;

		// Token: 0x040018C0 RID: 6336
		private global::System.Windows.Forms.Label label83;

		// Token: 0x040018C1 RID: 6337
		private global::System.Windows.Forms.Label label82;

		// Token: 0x040018C2 RID: 6338
		private global::System.Windows.Forms.NumericUpDown nudTuongTacChocSoLuongTo;

		// Token: 0x040018C3 RID: 6339
		private global::System.Windows.Forms.Label label81;

		// Token: 0x040018C4 RID: 6340
		private global::System.Windows.Forms.Label label87;

		// Token: 0x040018C5 RID: 6341
		private global::System.Windows.Forms.Label label85;

		// Token: 0x040018C6 RID: 6342
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageSoLuongPageTo;

		// Token: 0x040018C7 RID: 6343
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFanpageSoLuongBaiVietTo;

		// Token: 0x040018C8 RID: 6344
		private global::System.Windows.Forms.Label label86;

		// Token: 0x040018C9 RID: 6345
		private global::System.Windows.Forms.Label label57;

		// Token: 0x040018CA RID: 6346
		private global::System.Windows.Forms.Label label89;

		// Token: 0x040018CB RID: 6347
		private global::System.Windows.Forms.Label label90;

		// Token: 0x040018CC RID: 6348
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupSoLuongBaiVietTo;

		// Token: 0x040018CD RID: 6349
		private global::System.Windows.Forms.Label label55;

		// Token: 0x040018CE RID: 6350
		private global::System.Windows.Forms.NumericUpDown nudTuongTacGroupSoLuongNhomTo;

		// Token: 0x040018CF RID: 6351
		private global::System.Windows.Forms.Label label88;

		// Token: 0x040018D0 RID: 6352
		private global::System.Windows.Forms.Label label68;

		// Token: 0x040018D1 RID: 6353
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendSoLuongBaiVietTo;

		// Token: 0x040018D2 RID: 6354
		private global::System.Windows.Forms.NumericUpDown nudTuongTacFriendSoLuongBanBeTo;

		// Token: 0x040018D3 RID: 6355
		private global::System.Windows.Forms.Label label67;

		// Token: 0x040018D4 RID: 6356
		private global::System.Windows.Forms.Label label66;

		// Token: 0x040018D5 RID: 6357
		private global::System.Windows.Forms.Label label65;

		// Token: 0x040018D6 RID: 6358
		private global::System.Windows.Forms.NumericUpDown nudTuongTacNewsfeedSoLuongTo;

		// Token: 0x040018D7 RID: 6359
		private global::System.Windows.Forms.Label label64;

		// Token: 0x040018D8 RID: 6360
		private global::System.Windows.Forms.Label label74;

		// Token: 0x040018D9 RID: 6361
		private global::System.Windows.Forms.NumericUpDown nudKetBanTepUidSoLuongTo;

		// Token: 0x040018DA RID: 6362
		private global::System.Windows.Forms.Label label73;

		// Token: 0x040018DB RID: 6363
		private global::System.Windows.Forms.Label label70;

		// Token: 0x040018DC RID: 6364
		private global::System.Windows.Forms.NumericUpDown nudKetBanTuKhoaSoLuongTo;

		// Token: 0x040018DD RID: 6365
		private global::System.Windows.Forms.Label label69;

		// Token: 0x040018DE RID: 6366
		private global::System.Windows.Forms.Label label76;

		// Token: 0x040018DF RID: 6367
		private global::System.Windows.Forms.NumericUpDown nudXacNhanKetBanSoLuongTo;

		// Token: 0x040018E0 RID: 6368
		private global::System.Windows.Forms.Label label75;

		// Token: 0x040018E1 RID: 6369
		private global::System.Windows.Forms.Label label72;

		// Token: 0x040018E2 RID: 6370
		private global::System.Windows.Forms.NumericUpDown nudKetBanGoiYSoLuongTo;

		// Token: 0x040018E3 RID: 6371
		private global::System.Windows.Forms.Label label71;

		// Token: 0x040018E4 RID: 6372
		private global::System.Windows.Forms.Label label78;

		// Token: 0x040018E5 RID: 6373
		private global::System.Windows.Forms.NumericUpDown nudThamGiaNhomSoLuongTo;

		// Token: 0x040018E6 RID: 6374
		private global::System.Windows.Forms.Label label77;

		// Token: 0x040018E7 RID: 6375
		private global::System.Windows.Forms.Label label92;

		// Token: 0x040018E8 RID: 6376
		private global::System.Windows.Forms.Label label91;
	}
}
