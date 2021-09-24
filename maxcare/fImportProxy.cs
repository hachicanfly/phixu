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
	// Token: 0x020000EC RID: 236
	public partial class fImportProxy : Form
	{
		// Token: 0x06000989 RID: 2441 RVA: 0x00002FAD File Offset: 0x000011AD
		public fImportProxy()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.cbbTypeProxy.SelectedIndex = 0;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0019A738 File Offset: 0x00198938
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.label3);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
			Language.GetValue(this.rbLanLuot);
			Language.GetValue(this.rbNgauNhien);
			Language.GetValue(this.ckbKhongNhapTaiKhoanDaCo);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0019A804 File Offset: 0x00198A04
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtProxy.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				List<string> list2 = new List<string>();
				bool flag = list.Count == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV2hUWWpOak1tTklVa3BTYTBvMVdXcE9iMDVWYkZKUVZEQTk="))))))))), 3);
				}
				else
				{
					int num = Convert.ToInt32(this.nudTaiKhoanPerUa.Value);
					for (int i = 0; i < num; i++)
					{
						list2.AddRange(list);
					}
					bool @checked = this.rbNgauNhien.Checked;
					if (@checked)
					{
						list2 = Common.ShuffleList(list2);
					}
					Queue<string> queue = new Queue<string>(list2);
					int selectedIndex = this.cbbTypeProxy.SelectedIndex;
					List<string> list3 = new List<string>();
					int j = 0;
					while (j < fMain.remote.dtgvAcc.Rows.Count)
					{
						bool flag2 = Convert.ToBoolean(fMain.remote.GetCellAccount(j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))));
						if (flag2)
						{
							bool flag3 = fMain.remote.GetCellAccount(j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ=="))))))))) != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) && this.ckbKhongNhapTaiKhoanDaCo.Checked;
							if (!flag3)
							{
								bool flag4 = queue.Count == 0;
								if (flag4)
								{
									break;
								}
								string str = (queue.Dequeue() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKak9WQlJQVDA9")))))))) + selectedIndex.ToString()).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9")))))))));
								list3.Add(fMain.remote.GetCellAccount(j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))) + str);
							}
						}
						IL_3FA:
						j++;
						continue;
						goto IL_3FA;
					}
					bool flag5 = CommonSQL.UpdateMultiField(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnRWa2xoZWpBOQ==")))))))), list3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaa1QyRnRTWHBXYmxaclUwVXdPUT09")))))))));
					bool flag6 = flag5;
					if (flag6)
					{
						queue = new Queue<string>(list2);
						int k = 0;
						while (k < fMain.remote.dtgvAcc.Rows.Count)
						{
							bool flag7 = Convert.ToBoolean(fMain.remote.GetCellAccount(k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))));
							if (flag7)
							{
								bool flag8 = fMain.remote.GetCellAccount(k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ=="))))))))) != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) && this.ckbKhongNhapTaiKhoanDaCo.Checked;
								if (!flag8)
								{
									bool flag9 = queue.Count == 0;
									if (flag9)
									{
										break;
									}
									string value = (queue.Dequeue() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKak9WQlJQVDA9")))))))) + selectedIndex.ToString()).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9")))))))));
									fMain.remote.SetCellAccount(k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ==")))))))), value, true);
								}
							}
							IL_75E:
							k++;
							continue;
							goto IL_75E;
						}
					}
					bool flag10 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQkpkMWxWTVZCYU1rcDBXakprV2s5Rk9IZFpiVEZxWXpCc1NGTnRhRFpUTURVeFUxVmtUMlJ1Y0VwU1YyUnBWMFpvUldSRk1UVlJiVXB3VWtWV2NsWjVPVTVhTVdNeFltdHNTRlZGWkhwVVdHeExWMVpPUTJWdVl6TldSVEZ3VmtSbk9RPT0=")))))))))) == DialogResult.Yes;
					if (flag10)
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

		// Token: 0x0600098D RID: 2445 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0019B090 File Offset: 0x00199290
		private void txbNameFile_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.BtnAdd_Click(null, null);
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0019B0C8 File Offset: 0x001992C8
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtProxy.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1WWkpVMjVhYkZOSGRHNVRNR2g2WkRKYVZHRjZXVDA9"))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}
	}
}
