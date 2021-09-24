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
	// Token: 0x0200008D RID: 141
	public partial class fCauHinhQuetNhom : Form
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x000979BC File Offset: 0x00095BBC
		public fCauHinhQuetNhom()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
			fCauHinhQuetNhom.isOK = false;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00097A40 File Offset: 0x00095C40
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00097A84 File Offset: 0x00095C84
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			bool @checked = this.rbXuatNhomKiemDuyet.Checked;
			if (!@checked)
			{
				bool checked2 = this.rbXuatNhomKhongKiemDuyet.Checked;
				if (checked2)
				{
				}
			}
			this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			fCauHinhQuetNhom.isOK = true;
			base.Close();
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00097B44 File Offset: 0x00095D44
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			int valueInt = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRTYWtaaFYwWktVRmxWWXpWa1FUMDk=")))))))), 0);
			bool flag = valueInt == 0;
			if (flag)
			{
				this.rbXuatAll.Checked = true;
			}
			else
			{
				bool flag2 = valueInt == 1;
				if (flag2)
				{
					this.rbXuatNhomKiemDuyet.Checked = true;
				}
				else
				{
					this.rbXuatNhomKhongKiemDuyet.Checked = true;
				}
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00097C18 File Offset: 0x00095E18
		private void metroButton1_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fCauHinhChung());
		}

		// Token: 0x0400045D RID: 1117
		public static bool isOK;

		// Token: 0x0400045E RID: 1118
		private JSON_Settings settings;
	}
}
