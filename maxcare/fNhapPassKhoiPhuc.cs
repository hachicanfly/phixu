using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MCommon;

namespace maxcare
{
	// Token: 0x0200008E RID: 142
	public partial class fNhapPassKhoiPhuc : Form
	{
		// Token: 0x0600054E RID: 1358 RVA: 0x000996FC File Offset: 0x000978FC
		public fNhapPassKhoiPhuc()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
			fNhapPassKhoiPhuc.isOK = false;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00099780 File Offset: 0x00097980
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000997C4 File Offset: 0x000979C4
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			int num = 0;
			bool @checked = this.rbPassNgauNhien.Checked;
			if (@checked)
			{
				num = 1;
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRSYldocVRUQXdPUT09")))))))), num);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYm5CcVpIb3dPUT09")))))))), this.txtPass.Text);
			this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			fNhapPassKhoiPhuc.isOK = true;
			base.Close();
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00099924 File Offset: 0x00097B24
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			int valueInt = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRSYldocVRUQXdPUT09")))))))), 0);
			bool flag = valueInt == 0;
			if (flag)
			{
				this.rbPassTuDat.Checked = true;
			}
			else
			{
				this.rbPassNgauNhien.Checked = true;
			}
			this.txtPass.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYm5CcVpIb3dPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.rbPassTuDat_CheckedChanged(null, null);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00099A88 File Offset: 0x00097C88
		private void rbPassTuDat_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPass.Enabled = this.rbPassTuDat.Checked;
		}

		// Token: 0x0400046E RID: 1134
		public static bool isOK;

		// Token: 0x0400046F RID: 1135
		private JSON_Settings settings;
	}
}
