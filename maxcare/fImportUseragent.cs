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
	// Token: 0x020000ED RID: 237
	public partial class fImportUseragent : Form
	{
		// Token: 0x06000992 RID: 2450 RVA: 0x00002FD9 File Offset: 0x000011D9
		public fImportUseragent()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0019D5C8 File Offset: 0x0019B7C8
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label1);
			Language.GetValue(this.label8);
			Language.GetValue(this.label2);
			Language.GetValue(this.rbLanLuot);
			Language.GetValue(this.rbNgauNhien);
			Language.GetValue(this.ckbKhongNhapTaiKhoanDaCo);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0019D680 File Offset: 0x0019B880
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUseragent.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				List<string> list2 = new List<string>();
				bool flag = list.Count == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV2hUWWpOak1tTklVa3BTYkZvMlYyeG9TMkZHYjNsV2JsWnJVVEJWT1E9PQ=="))))))))), 3);
				}
				else
				{
					int num = Convert.ToInt32(this.nudTaiKhoanPerUa.Value);
					for (int i = 0; i < list.Count; i++)
					{
						for (int j = 0; j < num; j++)
						{
							list2.Add(list[i]);
						}
					}
					bool @checked = this.rbNgauNhien.Checked;
					if (@checked)
					{
						list2 = Common.ShuffleList(list2);
					}
					Queue<string> queue = new Queue<string>(list2);
					int k = 0;
					while (k < fMain.remote.dtgvAcc.Rows.Count)
					{
						bool flag2 = Convert.ToBoolean(fMain.remote.GetCellAccount(k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))));
						if (flag2)
						{
							bool flag3 = fMain.remote.GetCellAccount(k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk="))))))))) != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) && this.ckbKhongNhapTaiKhoanDaCo.Checked;
							if (!flag3)
							{
								bool flag4 = queue.Count == 0;
								if (flag4)
								{
									break;
								}
								string text = queue.Dequeue().Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9")))))))));
								bool flag5 = CommonSQL.UpdateFieldToAccount(fMain.remote.GetCellAccount(k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1QySkhUblJTYlRWaFZucFZkdz09")))))))), text);
								if (flag5)
								{
									fMain.remote.SetCellAccount(k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk=")))))))), text, true);
								}
							}
						}
						IL_419:
						k++;
						continue;
						goto IL_419;
					}
					bool flag6 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQkpkMWxWTVZCYU1rcDBXakprV2s5Rk9IZFpiVEZxWXpCc1NGTnRhRFpUTURVeFUxVmtUMlJ1Y0VwU1YyUnBWMFpvUldSRk1UVlJiVXB3VWtWV2NsWjVPVTVhTVdNeFltdHNTRlZGWkhwVVdHeExWMVpPUTJWdVl6TldSVEZ3VmtSbk9RPT0=")))))))))) == DialogResult.Yes;
					if (flag6)
					{
						base.Close();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25KYU1sWklVMFV4Y0ZkSGRHNVpNakZHWXpCc1NWZHFSbWhWTUVwNldXcG9OVkZYU25SWk1tUnJVakp3U0dNd01UVlRhMnhJWlVkb05sTXdOWGRUVldoUFlVZFNWRkpVTUQwPQ=="))))))))), 2);
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0019DBC8 File Offset: 0x0019BDC8
		private void txbNameFile_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.BtnAdd_Click(null, null);
			}
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0019DC00 File Offset: 0x0019BE00
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUseragent.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1WcFpWRzE0YW1KVlduVlhiR014VFVWc1JHRkVaRTVUUkVKM1ZESmpPVkJSUFQwPQ=="))))))))), list.Count);
			}
			catch
			{
			}
		}
	}
}
