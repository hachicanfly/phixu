namespace maxcare
{
	// Token: 0x020000EE RID: 238
	public partial class fChange : global::System.Windows.Forms.Form
	{
		// Token: 0x060009E3 RID: 2531 RVA: 0x001C0E5C File Offset: 0x001BF05C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x001C0EBC File Offset: 0x001BF0BC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fChange));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.tấtCảToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.liveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.checkpointToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.đăngNhậpProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cookieToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.đăngNhậpTrìnhDuyệtMớiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cookieToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.passToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uidPassTokenCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchChọnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSáchKhôngChọnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.giữNguyênỞThưMụcCũToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mnsCutAccount = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraTàiKhoảnToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kiểmTraTokenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupTokenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupCookieToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.backupCookieTrungGianToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mậtKhẩuToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nhậpDữLiệuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tựĐộngLấyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenBussinessToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenInstagramToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenIosToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tokenAndroidToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nhậpDữLiệuToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cookieToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tựĐộngLấyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nhậpDữLiệuToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.pnlHeader = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.bunifuCustomLabel1 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuCards1 = new global::Bunifu.Framework.UI.BunifuCards();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.lblChoosed = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new global::Bunifu.Framework.UI.BunifuCustomLabel();
			this.lblCountAcc = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.ctmsAcc = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.chọnTấtCảToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bỏChọnTấtCảToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ctmsChonTrangThai = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xóaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dtgvAcc = new global::System.Windows.Forms.DataGridView();
			this.btnConfig = new global::System.Windows.Forms.Button();
			this.btnPause = new global::System.Windows.Forms.Button();
			this.btnStart = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.cChose = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.cStt = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cId = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUid = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cCookies = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cBirthday = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cGender = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cPassword = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFa2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cUseragent = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cProxy = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cInfo = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.ctmsAcc.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dtgvAcc).BeginInit();
			base.SuspendLayout();
			this.tấtCảToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNXVRbGxWYTFFd1dXNUdjVlpyWXpWa2JVcEhWR3BDYW1KWGVETldSbVJYWkZkU1ZtSkVRbUZXZWtFNQ=="))))))));
			this.tấtCảToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.liveToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a2MwMXNjRmRWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVFOVBRPT0="))))))));
			this.liveToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.dieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0a2MySkdXa2hQV0ZwcFVtczBkMWt5TVhOa01WSllWbTVXYTFaWGQzZFhiR04zVUZFOVBRPT0="))))))));
			this.dieToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.checkpointToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IySkdhM2xrU0dScFRXMTRNVnBGV2xOa2JVbDVaVVpTYTFORmNIZFpNRlY0WWtkS2RWWnJjR3RTTVZvdw=="))))))));
			this.checkpointToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.changePasswordToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoV1VqQmFObGw2VG10a2JVNTBWV3hXYVUxcWJIcFdWRTVUWlZkR1dWRnJOV0ZXZWxWNFZURm9VMkpIU2xKUVZEQTk="))))))));
			this.changePasswordToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.đăngNhậpProfileToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSlhZM2xPVnpWVllsZHdiMlJZUlhoa01WWkpVMjVhWVdKWGVIcFhiRnBUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUE9PQ=="))))))));
			this.đăngNhậpProfileToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.cookieToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUlaejA9"))))))));
			this.cookieToolStripMenuItem1.Size = new global::System.Drawing.Size(32, 19);
			this.uidPassToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxxU2pSV1IxSkpVMjVDYWxKVVJuTlpiVFZYVTIxU1NGWnVVazVWVkRBNQ=="))))))));
			this.uidPassToolStripMenuItem1.Size = new global::System.Drawing.Size(32, 19);
			this.đăngNhậpTrìnhDuyệtMớiToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1NWSlhZM2xPVnpWVllsZHdiMlJZUlhoa01WcEpWRVZTZVZKNlZuWlZhMmhYVGxSU2FXUlZhR3RTVkU1dlpGUldNR05HV2toUFdGcHBVbXMwZDFreU1YTmtNVkpZVm01V2ExWlhkM2RYYkdOM1VGRTlQUT09"))))))));
			this.đăngNhậpTrìnhDuyệtMớiToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.cookieToolStripMenuItem2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUlhejA9"))))))));
			this.cookieToolStripMenuItem2.Size = new global::System.Drawing.Size(32, 19);
			this.uidPassToolStripMenuItem2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxxU2pSV1IxSkpVMjVDYWxKVVJuTlpiVFZYVTIxU1NGWnVVazVhZWpBNQ=="))))))));
			this.uidPassToolStripMenuItem2.Size = new global::System.Drawing.Size(32, 19);
			this.tokenToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVmxacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1VsQlVNRDA9"))))))));
			this.tokenToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.cookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUVNRDA9"))))))));
			this.cookieToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.uidToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhXa2hQV0ZwcFVtczBkMWt5TVhOa01WSllWbTVXYTFaWGQzZFhiR04zVUZFOVBRPT0="))))))));
			this.uidToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.passToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyVnRUWGhWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVFOVBRPT0="))))))));
			this.passToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.uidPassToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxxU2pSV1IxSkpVMjVDYWxKVVJuTlpiVFZYVTIxU1NGWnVVVDA9"))))))));
			this.uidPassToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.uidPassTokenCookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2taa2MyRXhWa2hTYm5CcVRWWktNbGxVU2xka1ZrVjVUMWhhYUUxdGVITldhMk0xWkcxS1IxUnFRbXBpVjNnelZrWmtWMlJYVWxaaVJFSmhWbnBCT1E9PQ=="))))))));
			this.uidPassTokenCookieToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.danhSáchChọnToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0a1IyUlhSa2RWUlZKMlZqQTFkbFZVU25GaFNGVXdUVmhXVjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlJEQTk="))))))));
			this.danhSáchChọnToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.danhSáchKhôngChọnToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0a1IyUlhSa2RWUlZKMlZqQTFkbFY2U25GU1NGSklUbGMxVWsxdGNHOWtWRkY0WkZaYVNFOVlXbWxTYXpSM1dUSXhjMlF4VWxoV2JsWnJWbGQzZDFkc1kzZFFVVDA5"))))))));
			this.danhSáchKhôngChọnToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.giữNguyênỞThưMụcCũToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJwS2RXRklWVEpQVlRsaFRURlpNV1I2V25ka1ZGSnBaRmRXVjFJeWNFaGpNRlY2WVVoVk1sWnRjRkpQUm1SM1ZtdGpOV1J0U2tkVWFrSnFZbGQ0TTFaR1pGZGtWMUpXWWtSQ1lWWjZRVGs9"))))))));
			this.giữNguyênỞThưMụcCũToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.mnsCutAccount.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d4ak1XVnNSWHBXYWtKU1ZqQTFjVmxxVGxka1YxSkNVRlF3UFE9PQ=="))))))));
			this.mnsCutAccount.Size = new global::System.Drawing.Size(32, 19);
			this.kiểmTraTàiKhoảnToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVpyTVZCYU1rWldaRWM1YVVzd1l6Smlla2t4VmxkSmVVOVlUbFpOTVVvMVdWWm9RMVJzY0ZoT1ZFWlVWMFpLYzFsc1JUbFFVVDA5"))))))));
			this.kiểmTraTàiKhoảnToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.kiểmTraCookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVZVU1RWa2JVVjVZa2Q0VjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlJEQTk="))))))));
			this.kiểmTraCookieToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.kiểmTraTokenToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1ZSS2RXRklWVEJVYmxKWFUwVndiMVpyWXpWamJIQllUbFpXYVUxcWJIcFdWRTVUWlZkR1dWRnJOV0ZXZWxWNFZURm9VMkpIU2xKUVZEQTk="))))))));
			this.kiểmTraTokenToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.backupTokenToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWFVucHNlVmRzWXpGV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeEZPVkJSUFQwPQ=="))))))));
			this.backupTokenToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.backupCookieToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SU1RXcHNNbGxVU25OaVJscElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMUJSUFQwPQ=="))))))));
			this.backupCookieToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.backupCookieTrungGianToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SU1RXcHNNbGxVU25OaVJscEpVMnBHYVdKWFVrbFpWbVJIWkZaYVNFOVlXbWxTYXpSM1dUSXhjMlF4VWxoV2JsWnJWbGQzZDFkc1kzZFFVVDA5"))))))));
			this.backupCookieTrungGianToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.mậtKhẩuToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cxV1NFNXVTbGxWYTNob1ZEQmpNbU5XYUZkV1YwbDVUMWhPVmsweFNqVlpWbWhEVkd4d1dFNVVSbFJYUmtweldXeFNSbEJSUFQwPQ=="))))))));
			this.mậtKhẩuToolStripMenuItem1.Size = new global::System.Drawing.Size(32, 19);
			this.nhậpDữLiệuToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cweGNXRklWbmhOV0dSVFZEQmpNMk5xUWpSalJGSnBaRlZvYTFac1NqSlpha28wVmtkU1NWTnVRbXBTVkVaeldXMDFWMU50VWtoV2JsRTk="))))))));
			this.nhậpDữLiệuToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.tokenToolStripMenuItem2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVmxacFRXcHNlbFpVVGxObFYwWlpVV3MxWVZaNlZYaFZNV2hUWWtkS1ZWTlVNRDA9"))))))));
			this.tokenToolStripMenuItem2.Size = new global::System.Drawing.Size(32, 19);
			this.tựĐộngLấyToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNHpUbXBWTVVVd1dXNVdZVmx0TVd0VVZGSnBZMWQ0YkZac1NqSlpha28wVmtkU1NWTnVRbXBTVkVaeldXMDFWMU50VWtoV2JsSk9WVlF3T1E9PQ=="))))))));
			this.tựĐộngLấyToolStripMenuItem1.Size = new global::System.Drawing.Size(32, 19);
			this.tokenBussinessToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVlU1clYwVTFObGxXWXpGaVIwMTZWR3hXYVUxcWJIcFdWRTVUWlZkR1dWRnJOV0ZXZWxWNFZURm9VMkpIU2xKUVZEQTk="))))))));
			this.tokenBussinessToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.tokenInstagramToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVlhCcFltczBkMWRXWkd0bFZteFlUVlpXYVUxcWJIcFdWRTVUWlZkR1dWRnJOV0ZXZWxWNFZURm9VMkpIU2xWU1ZEQTk="))))))));
			this.tokenInstagramToolStripMenuItem1.Size = new global::System.Drawing.Size(32, 19);
			this.tokenIosToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVlhCcFRUQTFWbGxxU1RWak1WVjZWVzVzYUZkRlNrOVhiR014VFZaT1dWVnRlR2xWVkRBNQ=="))))))));
			this.tokenIosToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.tokenAndroidToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tWak5XTnNjRmhPVlVwcFlsWktOVmxxU25OaE1WcElUMWhhYVZKck5IZFpNakZ6WkRGU1dGWnVWbXRXVjNkM1YyeGpkMlZCUFQwPQ=="))))))));
			this.tokenAndroidToolStripMenuItem1.Size = new global::System.Drawing.Size(32, 19);
			this.nhậpDữLiệuToolStripMenuItem2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cweGNXRklWbmhOV0dSVFZEQmpNMk5xUWpSalJGSnBaRlZvYTFac1NqSlpha28wVmtkU1NWTnVRbXBTVkVaeldXMDFWMU50VWtoV2JsSk9Xbm93T1E9PQ=="))))))));
			this.nhậpDữLiệuToolStripMenuItem2.Size = new global::System.Drawing.Size(32, 19);
			this.cookieToolStripMenuItem3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoWFVucHNNbGxyV2s5TlIwNTBZa2hrVlZZeFdqRmFSbFp6VFVad1dFMUliejA9"))))))));
			this.cookieToolStripMenuItem3.Size = new global::System.Drawing.Size(32, 19);
			this.tựĐộngLấyToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2tVNVNFNHpUbXBWTVVVd1dXNVdZVmx0TVd0VVZGSnBZMWQ0YkZac1NqSlpha28wVmtkU1NWTnVRbXBTVkVaeldXMDFWMU50VWtoV2JsRTk="))))))));
			this.tựĐộngLấyToolStripMenuItem.Size = new global::System.Drawing.Size(32, 19);
			this.nhậpDữLiệuToolStripMenuItem1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1cweGNXRklWbmhOV0dSVFZEQmpNMk5xUWpSalJGSnBaRlZvYTFac1NqSlpha28wVmtkU1NWTnVRbXBTVkVaeldXMDFWMU50VWtoV2JsSk9WVlF3T1E9PQ=="))))))));
			this.nhậpDữLiệuToolStripMenuItem1.Size = new global::System.Drawing.Size(32, 19);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.pnlHeader;
			this.bunifuDragControl1.Vertical = true;
			this.pnlHeader.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pnlHeader.BackColor = global::System.Drawing.Color.White;
			this.pnlHeader.Controls.Add(this.button2);
			this.pnlHeader.Controls.Add(this.button1);
			this.pnlHeader.Controls.Add(this.btnMinimize);
			this.pnlHeader.Controls.Add(this.pictureBox1);
			this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
			this.pnlHeader.Cursor = global::System.Windows.Forms.Cursors.SizeAll;
			this.pnlHeader.Location = new global::System.Drawing.Point(0, 5);
			this.pnlHeader.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCak1XTXhUa2hXYldoaFVqRmFOUT09"))))))));
			this.pnlHeader.Size = new global::System.Drawing.Size(986, 32);
			this.pnlHeader.TabIndex = 9;
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.Enabled = false;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1lWUldTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.button2.Location = new global::System.Drawing.Point(890, -1);
			this.button2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1dub3dPUT09"))))))));
			this.button2.Size = new global::System.Drawing.Size(30, 30);
			this.button2.TabIndex = 15;
			this.button2.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.Button2_Click);
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.Enabled = false;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1ZYcFdTMWxzWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
			this.button1.Location = new global::System.Drawing.Point(922, -1);
			this.button1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1ZWUXdPUT09"))))))));
			this.button1.Size = new global::System.Drawing.Size(30, 30);
			this.button1.TabIndex = 14;
			this.button1.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.btnMinimize.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnMinimize.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vmtaa2MyRnRUblJQV0hCcFRXeHZkMU5WV2s5aFIwcDFWRmRrVmsxc1dqVlpWbVJhVUZFOVBRPT0=")))))))), 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.Color.White;
			this.btnMinimize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.btnMinimize.Location = new global::System.Drawing.Point(954, -1);
			this.btnMinimize.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldVbGhpU0Zab1ZucEdkMXBYTVZaUVVUMDk="))))))));
			this.btnMinimize.Size = new global::System.Drawing.Size(30, 30);
			this.btnMinimize.TabIndex = 13;
			this.btnMinimize.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new global::System.EventHandler(this.BtnMinimize_Click);
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaa1ZrNVlUVmRvWVUxc1ZUaz0=")))))))));
			this.pictureBox1.Location = new global::System.Drawing.Point(7, 3);
			this.pictureBox1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa2MyRnRVa2xXYm14aFZsVndNbHBWVWtaUVVUMDk="))))))));
			this.pictureBox1.Size = new global::System.Drawing.Size(34, 27);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.bunifuCustomLabel1.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuCustomLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.bunifuCustomLabel1.Location = new global::System.Drawing.Point(43, 9);
			this.bunifuCustomLabel1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RURmFObHBGWXpWa1JsSklVbTFzWVZZelpEUT0="))))))));
			this.bunifuCustomLabel1.Size = new global::System.Drawing.Size(259, 16);
			this.bunifuCustomLabel1.TabIndex = 7;
			this.bunifuCustomLabel1.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtaV1IxZFZiRVpVYTBwV1lURldibFJHVGtOU1JrNVFVbnBrZUZKVk1XNVdTRTVVVVRGU2Nsa3laRFJUYTFKdlpGUldVMU5yYkVkVmEyd3pUbFpLVUZWdWJFTldWazVXVGtRd1BRPT0="))))))));
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = null;
			this.bunifuDragControl2.Vertical = true;
			this.bunifuCards1.BackColor = global::System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 0;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = global::System.Drawing.Color.RoyalBlue;
			this.bunifuCards1.Controls.Add(this.pnlHeader);
			this.bunifuCards1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new global::System.Drawing.Point(0, 0);
			this.bunifuCards1.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RXdGFOVmRyYUU1bFFUMDk="))))))));
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new global::System.Drawing.Size(986, 38);
			this.bunifuCards1.TabIndex = 10;
			this.panel3.BackColor = global::System.Drawing.SystemColors.Control;
			this.panel3.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new global::System.Drawing.Point(0, 558);
			this.panel3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1RCa1IyUldjRmhrTTI4OQ=="))))))));
			this.panel3.Size = new global::System.Drawing.Size(986, 26);
			this.panel3.TabIndex = 11;
			this.panel3.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			this.lblChoosed.AutoSize = true;
			this.lblChoosed.BackColor = global::System.Drawing.Color.White;
			this.lblChoosed.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.lblChoosed.ForeColor = global::System.Drawing.Color.Maroon;
			this.lblChoosed.Location = new global::System.Drawing.Point(690, 514);
			this.lblChoosed.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhSWGxoU0ZwcFRUQTFjMWRyUlRsUVVUMDk="))))))));
			this.lblChoosed.Size = new global::System.Drawing.Size(16, 16);
			this.lblChoosed.TabIndex = 120;
			this.lblChoosed.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.BackColor = global::System.Drawing.Color.White;
			this.bunifuCustomLabel2.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.bunifuCustomLabel2.Location = new global::System.Drawing.Point(626, 514);
			this.bunifuCustomLabel2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYyUlhSbGhYYWtaU1RURmFObHBGWXpWa1JsSklVbTFzWVZZelpEVT0="))))))));
			this.bunifuCustomLabel2.Size = new global::System.Drawing.Size(70, 16);
			this.bunifuCustomLabel2.TabIndex = 121;
			this.bunifuCustomLabel2.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhCb1ZEQmpNMkZzWXpCT2EyeENVRlF3UFE9PQ=="))))))));
			this.lblCountAcc.AutoSize = true;
			this.lblCountAcc.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.lblCountAcc.ForeColor = global::System.Drawing.Color.Blue;
			this.lblCountAcc.Location = new global::System.Drawing.Point(807, 514);
			this.lblCountAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1MyTXhSWGxQVkVacFlteEtRMWRVU2s1UVVUMDk="))))))));
			this.lblCountAcc.Size = new global::System.Drawing.Size(16, 16);
			this.lblCountAcc.TabIndex = 76;
			this.lblCountAcc.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
			this.label7.Location = new global::System.Drawing.Point(765, 514);
			this.label7.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V1d0a1IyRldjRmhrZWswOQ=="))))))));
			this.label7.Size = new global::System.Drawing.Size(44, 16);
			this.label7.TabIndex = 77;
			this.label7.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNHllRmhPVnpWUVdub3dPUT09"))))))));
			this.ctmsAcc.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ctmsAcc.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chọnTấtCảToolStripMenuItem,
				this.bỏChọnTấtCảToolStripMenuItem,
				this.ctmsChonTrangThai,
				this.xóaToolStripMenuItem
			});
			this.ctmsAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFST1UyUkhUWGRTYlhCYVpIb3dPUT09"))))))));
			this.ctmsAcc.Size = new global::System.Drawing.Size(160, 92);
			this.ctmsAcc.Opening += new global::System.ComponentModel.CancelEventHandler(this.ctmsAcc_Opening);
			this.chọnTấtCảToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSS2NXRklWVEJOV0ZaWFZEQmpNbU5HYUZOU1JGSnBZMWR3VjFKNmJESlphMXBQVFVkT2RHSklaRlZXTVZveFdrWldjMDFHY0ZoTlJEQTk="))))))));
			this.chọnTấtCảToolStripMenuItem.Size = new global::System.Drawing.Size(159, 22);
			this.chọnTấtCảToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEJOV0ZaS1UwWlNiMlJZUmxkTlJXeElWVWRvTVdOVk1Eaz0="))))))));
			this.chọnTấtCảToolStripMenuItem.Click += new global::System.EventHandler(this.chọnTấtCảToolStripMenuItem_Click_1);
			this.bỏChọnTấtCảToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFoV1NFNHliM2RVYlRnd1dXNVdUMWx0ZUZWaFNGWjRWbXBDVWtzd1l6Smlla1pUWkcxSmVXVkdVbXRUUlhCM1dUQlZlR0pIU25WV2EzQnJVakZhTUE9PQ=="))))))));
			this.bỏChọnTấtCảToolStripMenuItem.Size = new global::System.Drawing.Size(159, 22);
			this.bỏChọnTấtCảToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZoV1NFNHljRFZSYlhCb1ZEQmpNMkZzWXpCYU1sSlFVbnBhZDFkR1JtNVhVM1JJVG0wNU0xQlVNRDA9"))))))));
			this.bỏChọnTấtCảToolStripMenuItem.Click += new global::System.EventHandler(this.bỏChọnTấtCảToolStripMenuItem_Click_1);
			this.ctmsChonTrangThai.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFST1UyUkhUWGRVYlRscFRXcFdWbGt5TVVka1ZtOTRWVzA1V2xZeWN6az0="))))))));
			this.ctmsChonTrangThai.Size = new global::System.Drawing.Size(159, 22);
			this.ctmsChonTrangThai.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEJOV0ZaS1UwWktOVmRYVGpWaGJVcDBXVEprYTFJeWFHOWxhMnhIWTBFOVBRPT0="))))))));
			this.ctmsChonTrangThai.Click += new global::System.EventHandler(this.ctmsChonTrangThai_Click);
			this.xóaToolStripMenuItem.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("V2xVeFVHVnNiRmRWYmxwcFRXNW9WVnBGYUV0alIwNUdUVmQ0YVdKc1drdGFSV1JYWkVFOVBRPT0="))))))));
			this.xóaToolStripMenuItem.Size = new global::System.Drawing.Size(159, 22);
			this.xóaToolStripMenuItem.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmpBeFVHVnNiRlJTUlZaeVdUQTVjVk5WWkU5aWVsSnBaRlUxYVZwNk1Eaz0="))))))));
			this.xóaToolStripMenuItem.Click += new global::System.EventHandler(this.xóaToolStripMenuItem_Click_1);
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
				this.cCookies,
				this.cName,
				this.cBirthday,
				this.cGender,
				this.cPassword,
				this.cFa2,
				this.cUseragent,
				this.cProxy,
				this.cInfo,
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
			this.dtgvAcc.Location = new global::System.Drawing.Point(5, 43);
			this.dtgvAcc.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjJ0b1UySnRVbkpTYlhCYVpIb3dPUT09"))))))));
			this.dtgvAcc.ReadOnly = true;
			this.dtgvAcc.RowHeadersVisible = false;
			this.dtgvAcc.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvAcc.Size = new global::System.Drawing.Size(976, 465);
			this.dtgvAcc.TabIndex = 125;
			this.dtgvAcc.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAcc_CellClick);
			this.dtgvAcc.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAcc_CellDoubleClick);
			this.dtgvAcc.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.dtgvAcc_KeyDown);
			this.btnConfig.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnConfig.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.btnConfig.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxQV0ZaaFlsZDRkVlJIZEhOa1JteFlXa2QzUFE9PQ==")))))))));
			this.btnConfig.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnConfig.Location = new global::System.Drawing.Point(235, 514);
			this.btnConfig.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldSWGxQV0ZaaFlsZDRkUT09"))))))));
			this.btnConfig.Size = new global::System.Drawing.Size(109, 40);
			this.btnConfig.TabIndex = 71;
			this.btnConfig.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZOMFNFNXVRbGxXVjJSb1ZGVTVlbGx0TVc1UVVUMDk="))))))));
			this.btnConfig.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConfig.UseVisualStyleBackColor = false;
			this.btnConfig.Click += new global::System.EventHandler(this.btnConfig_Click_1);
			this.btnPause.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnPause.Enabled = false;
			this.btnPause.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.btnPause.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWa2hTYWtacVRXeFdNVlV4WTNoaFJtOTVWbFF3UFE9PQ==")))))))));
			this.btnPause.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnPause.Location = new global::System.Drawing.Point(120, 514);
			this.btnPause.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWa2hTYWtacVRXeFZPUT09"))))))));
			this.btnPause.Size = new global::System.Drawing.Size(109, 40);
			this.btnPause.TabIndex = 70;
			this.btnPause.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zNVNFNXRPVmhOUjJSaFZEQmpNMk5VU1RGaVp6MDk="))))))));
			this.btnPause.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPause.UseVisualStyleBackColor = false;
			this.btnPause.Click += new global::System.EventHandler(this.btnPause_Click_1);
			this.btnStart.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnStart.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.btnStart.Image = (global::System.Drawing.Image)componentResourceManager.GetObject(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWWHBWYldocVlteEdNVlV4WTNoaFJtOTVWbFF3UFE9PQ==")))))))));
			this.btnStart.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.btnStart.Location = new global::System.Drawing.Point(5, 514);
			this.btnStart.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVUyUldWWHBWYldocVlteEZPUT09"))))))));
			this.btnStart.Size = new global::System.Drawing.Size(109, 40);
			this.btnStart.TabIndex = 69;
			this.btnStart.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZoV1NFNXVTWHBWVjJRMFUydG9iMlJZUm10TlVUMDk="))))))));
			this.btnStart.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new global::System.EventHandler(this.btnShare_Click_1);
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button3.Font = new global::System.Drawing.Font(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1IySXlTWGxOVjJjOQ==")))))))), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
			this.button3.Image = global::maxcare.Properties.Resources.icons8_opened_folder_37px;
			this.button3.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button3.Location = new global::System.Drawing.Point(350, 514);
			this.button3.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaT1pIb3dPUT09"))))))));
			this.button3.Size = new global::System.Drawing.Size(126, 40);
			this.button3.TabIndex = 71;
			this.button3.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10a1NWUlhaRWhoTW1Sb1RXMW9NbGRYVGpWVGJVcHdVV3N4TTA0eFVrNWFla3B5VUZFOVBRPT0="))))))));
			this.button3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.cChose.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSS2NXRklWVEJOV0ZVOQ=="))))))));
			this.cChose.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))));
			this.cChose.ReadOnly = true;
			this.cChose.Width = 40;
			this.cStt.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxSR1UxWlJQVDA9"))))))));
			this.cStt.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1QwMUhVa0pRVkRBOQ=="))))))));
			this.cStt.ReadOnly = true;
			this.cStt.Width = 50;
			this.cId.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlRGa1VsQlJQVDA9"))))))));
			this.cId.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))));
			this.cId.ReadOnly = true;
			this.cId.Visible = false;
			this.cId.Width = 90;
			this.cUid.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14V2MxSlJQVDA9"))))))));
			this.cUid.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))));
			this.cUid.ReadOnly = true;
			this.cUid.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cUid.Width = 70;
			this.cCookies.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNjOQ=="))))))));
			this.cCookies.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))));
			this.cCookies.ReadOnly = true;
			this.cCookies.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cCookies.Width = 60;
			this.cName.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtjeFIyUkdjRkpRVkRBOQ=="))))))));
			this.cName.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))));
			this.cName.ReadOnly = true;
			this.cName.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cName.Width = 75;
			this.cBirthday.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VlZjeGMyVlhVa2hoUjNSYVYwZHpPUT09"))))))));
			this.cBirthday.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1MyTkhUblZWYlRsaFVqQlpNUT09"))))))));
			this.cBirthday.ReadOnly = true;
			this.cBirthday.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cBirthday.Width = 70;
			this.cGender.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VldwS2RXRklWVEZrU0VKS1VteFNSV05zWXpGaWR6MDk="))))))));
			this.cGender.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2EySkhTblJWYlhocVdub3dPUT09"))))))));
			this.cGender.ReadOnly = true;
			this.cGender.Width = 80;
			this.cPassword.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtkV1NFNXVTbGxWVjJSb1RXMXdiMlJZUm5OTlVUMDk="))))))));
			this.cPassword.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))));
			this.cPassword.ReadOnly = true;
			this.cPassword.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cPassword.Width = 70;
			this.cFa2.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VkZkMFlWRm5QVDA9"))))))));
			this.cFa2.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ=="))))))));
			this.cFa2.ReadOnly = true;
			this.cFa2.Width = 40;
			this.cUseragent.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm14b1QySkhUblJTYlRWaFZucFZkdz09"))))))));
			this.cUseragent.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk="))))))));
			this.cUseragent.ReadOnly = true;
			this.cUseragent.Width = 70;
			this.cProxy.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmxWb1MyUnRWa2xoZWpBOQ=="))))))));
			this.cProxy.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ=="))))))));
			this.cProxy.ReadOnly = true;
			this.cProxy.Width = 50;
			this.cInfo.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.cInfo.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm1zeFVHTXlTblJhTW1SWFUwVjRiMlJZUmtka1ZuQXpVRlF3UFE9PQ=="))))))));
			this.cInfo.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ=="))))))));
			this.cInfo.ReadOnly = true;
			this.cInfo.Width = 90;
			this.cStatus.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cStatus.HeaderText = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("Vm10b1RXRklWbmhTYmxaaFpWVktWbGxWTVZCaFIwWlNVRlF3UFE9PQ=="))))))));
			this.cStatus.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09"))))))));
			this.cStatus.ReadOnly = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(986, 584);
			base.Controls.Add(this.lblChoosed);
			base.Controls.Add(this.dtgvAcc);
			base.Controls.Add(this.bunifuCustomLabel2);
			base.Controls.Add(this.lblCountAcc);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.btnConfig);
			base.Controls.Add(this.btnPause);
			base.Controls.Add(this.btnStart);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.bunifuCards1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VjIxMFQySXhiRmhPVnpWaFZWUXdPUT09"))))))));
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String(global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("VmtaV1IxZFZiRVpVYTBwV1lURldibFJHVGtOU1JrNVFVbnBrZUZKVk1XNVdTRTVVVVRGU2Nsa3laRlpTVkd4VlZtdEZPVkJSUFQwPQ=="))))))));
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.ctmsAcc.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dtgvAcc).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000E17 RID: 3607
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000E18 RID: 3608
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000E19 RID: 3609
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x04000E1A RID: 3610
		private global::Bunifu.Framework.UI.BunifuCards bunifuCards1;

		// Token: 0x04000E1B RID: 3611
		private global::System.Windows.Forms.Panel pnlHeader;

		// Token: 0x04000E1C RID: 3612
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

		// Token: 0x04000E1D RID: 3613
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000E1E RID: 3614
		private global::System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;

		// Token: 0x04000E1F RID: 3615
		private global::System.Windows.Forms.ToolStripMenuItem dieToolStripMenuItem;

		// Token: 0x04000E20 RID: 3616
		private global::System.Windows.Forms.ToolStripMenuItem checkpointToolStripMenuItem;

		// Token: 0x04000E21 RID: 3617
		private global::System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;

		// Token: 0x04000E22 RID: 3618
		private global::System.Windows.Forms.ToolStripMenuItem tokenToolStripMenuItem;

		// Token: 0x04000E23 RID: 3619
		private global::System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem;

		// Token: 0x04000E24 RID: 3620
		private global::System.Windows.Forms.ToolStripMenuItem uidPassToolStripMenuItem;

		// Token: 0x04000E25 RID: 3621
		private global::System.Windows.Forms.ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

		// Token: 0x04000E26 RID: 3622
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchChọnToolStripMenuItem;

		// Token: 0x04000E27 RID: 3623
		private global::System.Windows.Forms.ToolStripMenuItem danhSáchKhôngChọnToolStripMenuItem;

		// Token: 0x04000E28 RID: 3624
		private global::System.Windows.Forms.ToolStripMenuItem tấtCảToolStripMenuItem;

		// Token: 0x04000E29 RID: 3625
		private global::System.Windows.Forms.ToolStripMenuItem uidToolStripMenuItem;

		// Token: 0x04000E2A RID: 3626
		private global::System.Windows.Forms.ToolStripMenuItem passToolStripMenuItem;

		// Token: 0x04000E2B RID: 3627
		private global::System.Windows.Forms.ToolStripMenuItem giữNguyênỞThưMụcCũToolStripMenuItem;

		// Token: 0x04000E2C RID: 3628
		private global::System.Windows.Forms.ToolStripMenuItem mnsCutAccount;

		// Token: 0x04000E2D RID: 3629
		private global::System.Windows.Forms.ToolStripMenuItem đăngNhậpProfileToolStripMenuItem;

		// Token: 0x04000E2E RID: 3630
		private global::System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem1;

		// Token: 0x04000E2F RID: 3631
		private global::System.Windows.Forms.ToolStripMenuItem uidPassToolStripMenuItem1;

		// Token: 0x04000E30 RID: 3632
		private global::System.Windows.Forms.ToolStripMenuItem đăngNhậpTrìnhDuyệtMớiToolStripMenuItem;

		// Token: 0x04000E31 RID: 3633
		private global::System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem2;

		// Token: 0x04000E32 RID: 3634
		private global::System.Windows.Forms.ToolStripMenuItem uidPassToolStripMenuItem2;

		// Token: 0x04000E33 RID: 3635
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraCookieToolStripMenuItem;

		// Token: 0x04000E34 RID: 3636
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraTokenToolStripMenuItem;

		// Token: 0x04000E35 RID: 3637
		private global::System.Windows.Forms.ToolStripMenuItem kiểmTraTàiKhoảnToolStripMenuItem;

		// Token: 0x04000E36 RID: 3638
		private global::System.Windows.Forms.ToolStripMenuItem mậtKhẩuToolStripMenuItem1;

		// Token: 0x04000E37 RID: 3639
		private global::System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuToolStripMenuItem;

		// Token: 0x04000E38 RID: 3640
		private global::System.Windows.Forms.ToolStripMenuItem tokenToolStripMenuItem2;

		// Token: 0x04000E39 RID: 3641
		private global::System.Windows.Forms.ToolStripMenuItem tựĐộngLấyToolStripMenuItem1;

		// Token: 0x04000E3A RID: 3642
		private global::System.Windows.Forms.ToolStripMenuItem tokenBussinessToolStripMenuItem;

		// Token: 0x04000E3B RID: 3643
		private global::System.Windows.Forms.ToolStripMenuItem tokenInstagramToolStripMenuItem1;

		// Token: 0x04000E3C RID: 3644
		private global::System.Windows.Forms.ToolStripMenuItem tokenIosToolStripMenuItem;

		// Token: 0x04000E3D RID: 3645
		private global::System.Windows.Forms.ToolStripMenuItem tokenAndroidToolStripMenuItem1;

		// Token: 0x04000E3E RID: 3646
		private global::System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuToolStripMenuItem2;

		// Token: 0x04000E3F RID: 3647
		private global::System.Windows.Forms.ToolStripMenuItem cookieToolStripMenuItem3;

		// Token: 0x04000E40 RID: 3648
		private global::System.Windows.Forms.ToolStripMenuItem tựĐộngLấyToolStripMenuItem;

		// Token: 0x04000E41 RID: 3649
		private global::System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuToolStripMenuItem1;

		// Token: 0x04000E42 RID: 3650
		private global::System.Windows.Forms.ToolStripMenuItem backupTokenToolStripMenuItem;

		// Token: 0x04000E43 RID: 3651
		private global::System.Windows.Forms.ToolStripMenuItem backupCookieToolStripMenuItem;

		// Token: 0x04000E44 RID: 3652
		private global::System.Windows.Forms.ToolStripMenuItem backupCookieTrungGianToolStripMenuItem;

		// Token: 0x04000E45 RID: 3653
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000E46 RID: 3654
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000E47 RID: 3655
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000E48 RID: 3656
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000E49 RID: 3657
		private global::Bunifu.Framework.UI.BunifuCustomLabel lblChoosed;

		// Token: 0x04000E4A RID: 3658
		private global::Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;

		// Token: 0x04000E4B RID: 3659
		private global::System.Windows.Forms.Label lblCountAcc;

		// Token: 0x04000E4C RID: 3660
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000E4D RID: 3661
		private global::System.Windows.Forms.ContextMenuStrip ctmsAcc;

		// Token: 0x04000E4E RID: 3662
		private global::System.Windows.Forms.ToolStripMenuItem chọnTấtCảToolStripMenuItem;

		// Token: 0x04000E4F RID: 3663
		private global::System.Windows.Forms.ToolStripMenuItem bỏChọnTấtCảToolStripMenuItem;

		// Token: 0x04000E50 RID: 3664
		private global::System.Windows.Forms.ToolStripMenuItem ctmsChonTrangThai;

		// Token: 0x04000E51 RID: 3665
		private global::System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;

		// Token: 0x04000E52 RID: 3666
		private global::System.Windows.Forms.Button btnConfig;

		// Token: 0x04000E53 RID: 3667
		private global::System.Windows.Forms.Button btnPause;

		// Token: 0x04000E54 RID: 3668
		private global::System.Windows.Forms.Button btnStart;

		// Token: 0x04000E55 RID: 3669
		public global::System.Windows.Forms.DataGridView dtgvAcc;

		// Token: 0x04000E56 RID: 3670
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000E57 RID: 3671
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn cChose;

		// Token: 0x04000E58 RID: 3672
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStt;

		// Token: 0x04000E59 RID: 3673
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cId;

		// Token: 0x04000E5A RID: 3674
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cUid;

		// Token: 0x04000E5B RID: 3675
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cCookies;

		// Token: 0x04000E5C RID: 3676
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cName;

		// Token: 0x04000E5D RID: 3677
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cBirthday;

		// Token: 0x04000E5E RID: 3678
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cGender;

		// Token: 0x04000E5F RID: 3679
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cPassword;

		// Token: 0x04000E60 RID: 3680
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cFa2;

		// Token: 0x04000E61 RID: 3681
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cUseragent;

		// Token: 0x04000E62 RID: 3682
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cProxy;

		// Token: 0x04000E63 RID: 3683
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cInfo;

		// Token: 0x04000E64 RID: 3684
		private global::System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
	}
}
