using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x020000A4 RID: 164
	public partial class fLocTheoDanhSachUid : Form
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x00002CCB File Offset: 0x00000ECB
		public fLocTheoDanhSachUid()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fLocTheoDanhSachUid.lstUID = new List<string>();
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000BA76C File Offset: 0x000B896C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x000BA7D0 File Offset: 0x000B89D0
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUseragent.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				bool flag = list.Count == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV2hUWWpOak1tTklVa3BTYkZwTFZXdE9SbEJSUFQwPQ=="))))))))), 3);
				}
				else
				{
					fLocTheoDanhSachUid.lstUID = Common.CloneList(list);
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25KYU1sWklVMFV4Y0ZkSGRHNVpNakZHWXpCc1NWZHFSbWhWTUVwNldXcG9OVkZYU25SWk1tUnJVakp3U0dNd01UVlRhMnhJWlVkb05sTXdOWGRUVldoUFlVZFNWRkpVTUQwPQ=="))))))))), 2);
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x000BA900 File Offset: 0x000B8B00
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUseragent.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1WcFdZa1ZXU2xFeVp6TlVWV2QzWTBVNWJsQlVNRDA9"))))))))), list.Count);
			}
			catch
			{
			}
		}

		// Token: 0x040005A9 RID: 1449
		public static List<string> lstUID = new List<string>();
	}
}
