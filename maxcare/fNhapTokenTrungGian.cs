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
	// Token: 0x020000E5 RID: 229
	public partial class fNhapTokenTrungGian : Form
	{
		// Token: 0x06000933 RID: 2355 RVA: 0x00183E04 File Offset: 0x00182004
		public fNhapTokenTrungGian()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
			fNhapTokenTrungGian.isOK = false;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00183E88 File Offset: 0x00182088
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label2);
			Language.GetValue(this.btnCheckLiveTokenTg);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00183EEC File Offset: 0x001820EC
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XTnNjRmhPUkRBOQ==")))))))), this.token.Text);
			this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			fNhapTokenTrungGian.isOK = true;
			base.Close();
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00183FCC File Offset: 0x001821CC
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.token.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XTnNjRmhPUkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00184088 File Offset: 0x00182288
		private void btnCheckLiveTokenTg_Click(object sender, EventArgs e)
		{
			bool flag = CommonRequest.CheckLiveToken(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), this.token.Text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10ak5XTnNjRmhPUjJScFVqSjNlVmRzVGtaUVVUMDk=")))))))), 1);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10ak5XTnNjRmhPUjJSaFVqSjRjMU5XUlRsUVVUMDk=")))))))), 1);
			}
		}

		// Token: 0x04000D05 RID: 3333
		public static bool isOK;

		// Token: 0x04000D06 RID: 3334
		private JSON_Settings settings;
	}
}
