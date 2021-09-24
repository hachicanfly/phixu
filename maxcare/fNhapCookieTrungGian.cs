using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000A5 RID: 165
	public partial class fNhapCookieTrungGian : Form
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x000BBF18 File Offset: 0x000BA118
		public fNhapCookieTrungGian()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
			this.ChangeLanguage();
			fNhapCookieTrungGian.isOK = false;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000BBF9C File Offset: 0x000BA19C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label2);
			Language.GetValue(this.label2);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000BC000 File Offset: 0x000BA200
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNjOQ==")))))))), this.txtCookie.Text);
			this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			fNhapCookieTrungGian.isOK = true;
			base.Close();
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000BC0E0 File Offset: 0x000BA2E0
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.txtCookie.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNjOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x000BC19C File Offset: 0x000BA39C
		private void btnCheckLiveTokenTg_Click(object sender, EventArgs e)
		{
			bool flag = CommonRequest.CheckLiveCookie(this.txtCookie.Text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0).StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))));
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNoS1VqTm9kMXBITVZaaFFUMDk=")))))))), 1);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNoS1VqRktkMWRzVGtaUVVUMDk=")))))))), 1);
			}
		}

		// Token: 0x040005B6 RID: 1462
		public static bool isOK;

		// Token: 0x040005B7 RID: 1463
		private JSON_Settings settings;
	}
}
