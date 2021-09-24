using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x0200008A RID: 138
	public partial class fCauHinhKhoiPhucTaiKhoan : Form
	{
		// Token: 0x0600051C RID: 1308 RVA: 0x00090550 File Offset: 0x0008E750
		public fCauHinhKhoiPhucTaiKhoan()
		{
			this.InitializeComponent();
			this.Load_cbbThuMuc();
			this.ChangeLanguage();
			fCauHinhKhoiPhucTaiKhoan.isOK = false;
			fCauHinhKhoiPhucTaiKhoan.typeThuMuc = 0;
			fCauHinhKhoiPhucTaiKhoan.idFile = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000905E0 File Offset: 0x0008E7E0
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.rbThuMucCu);
			Language.GetValue(this.rbThuMucKhac);
			Language.GetValue(this.button1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00090654 File Offset: 0x0008E854
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			bool @checked = this.rbThuMucKhac.Checked;
			if (@checked)
			{
				bool flag = this.cbbThuMuc.SelectedIndex == -1;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaU0yTXlZMGhTU2xOR1NuWmxTRXBDV2pKS2JGSjZaSGRXTURGdVpVVndTV0ZJVlRCVVYyUnBWRmRHTTFwR1RrTk5TR015VVc1Q1NsSXpVblpaYVhSSVRtMDRlVTVIWnowPQ=="))))))))), 3);
					return;
				}
				fCauHinhKhoiPhucTaiKhoan.typeThuMuc = 1;
				fCauHinhKhoiPhucTaiKhoan.idFile = this.cbbThuMuc.SelectedValue.ToString();
			}
			fCauHinhKhoiPhucTaiKhoan.isOK = true;
			base.Close();
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00090730 File Offset: 0x0008E930
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.rbThuMucKhac_CheckedChanged(null, null);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0009074C File Offset: 0x0008E94C
		private void button1_Click(object sender, EventArgs e)
		{
			fAddFile f = new fAddFile();
			Common.ShowForm(f);
			bool isAdd = fAddFile.isAdd;
			if (isAdd)
			{
				this.Load_cbbThuMuc();
				this.cbbThuMuc.SelectedIndex = this.cbbThuMuc.Items.Count - 1;
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000907B0 File Offset: 0x0008E9B0
		private void Load_cbbThuMuc()
		{
			this.indexOld = this.cbbThuMuc.SelectedIndex;
			DataTable allFilesFromDatabase = CommonSQL.GetAllFilesFromDatabase(false);
			bool flag = allFilesFromDatabase.Rows.Count > 0;
			if (flag)
			{
				this.cbbThuMuc.DataSource = allFilesFromDatabase;
				this.cbbThuMuc.ValueMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VsQlJQVDA9"))))))));
				this.cbbThuMuc.DisplayMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRkpRVkRBOQ=="))))))));
				bool flag2 = this.indexOld == -1;
				if (flag2)
				{
					this.indexOld = 0;
				}
				this.cbbThuMuc.SelectedIndex = this.indexOld;
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00090904 File Offset: 0x0008EB04
		private void rbThuMucKhac_CheckedChanged(object sender, EventArgs e)
		{
			this.plThuMucKhac.Enabled = this.rbThuMucKhac.Checked;
		}

		// Token: 0x0400041D RID: 1053
		public static bool isOK = false;

		// Token: 0x0400041E RID: 1054
		public static int typeThuMuc = 0;

		// Token: 0x0400041F RID: 1055
		public static string idFile = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x04000420 RID: 1056
		private int indexOld = 0;
	}
}
