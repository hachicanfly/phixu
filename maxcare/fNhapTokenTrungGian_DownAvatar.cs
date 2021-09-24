using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000E4 RID: 228
	public partial class fNhapTokenTrungGian_DownAvatar : Form
	{
		// Token: 0x06000929 RID: 2345 RVA: 0x00182680 File Offset: 0x00180880
		public fNhapTokenTrungGian_DownAvatar()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
			fNhapTokenTrungGian_DownAvatar.isOK = false;
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00182704 File Offset: 0x00180904
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.metroButton1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00182768 File Offset: 0x00180968
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IwMUhSa1pYYmxwcFVqRktjMWt5ZEVkTmJHeFpWVzFvYWxwNk1Eaz0=")))))))), this.txtPathFolder.Text);
			this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			fNhapTokenTrungGian_DownAvatar.isOK = true;
			base.Close();
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00182848 File Offset: 0x00180A48
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.txtPathFolder.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IwMUhSa1pYYmxwcFVqRktjMWt5ZEVkTmJHeFpWVzFvYWxwNk1Eaz0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00069C18 File Offset: 0x00067E18
		private void btnCheckLiveTokenTg_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00182904 File Offset: 0x00180B04
		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.txtPathFolder.Text = Common.SelectFolder();
		}

		// Token: 0x04000CF7 RID: 3319
		public static bool isOK;

		// Token: 0x04000CF8 RID: 3320
		private JSON_Settings settings;
	}
}
