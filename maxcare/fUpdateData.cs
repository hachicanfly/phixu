using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000185 RID: 389
	public partial class fUpdateData : Form
	{
		// Token: 0x06001059 RID: 4185 RVA: 0x00003367 File Offset: 0x00001567
		public fUpdateData(fMain main, string mode)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.main = main;
			this.cbbTypeUpdate.Text = mode;
			this.cbbTypeProxy.SelectedIndex = 0;
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x004001E4 File Offset: 0x003FE3E4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00400258 File Offset: 0x003FE458
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = false;
				bool flag2 = this.txbData.Text.Equals(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) || this.txbData.Text.Equals(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))));
				if (flag2)
				{
					bool flag3 = MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOaGJVWk9WVEJTTmxOVlduRlRWV040VFZoak0xWkZNVzVXZWxKdVdsVmpkbFJYWkZoU1YyUmhWRmRHTTJWcmJFNWFNa3BJWW10U2VHTXpiSEZhUms1RFlXcFNhV1JYTlZwVk1Fa3pWRlZuZDFveVVrNVVNbVJvVlRCS2VWbFZZM1poU0ZaNFZHNVdVV1I2TURrPQ=="))))))))), this.main.CountChooseRowInDatagridview())) == DialogResult.Yes;
					if (flag3)
					{
						flag = true;
					}
				}
				else
				{
					bool flag4 = MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOaGJVWk9WVEJTTmxOVlduRlRWV040VFZoak0xWkZNVzVXZWxKdVYxUm9VR0ZZY0V4VWJtUktVbnBXZG1SNldrMVVWemg2VlZka1lWUlhSak5sYTJ4T1dqSktTR0pyVW5oak0yeHhXa1pPUTJGcVVtbGtWelZhVlRCSk0xUlZaM2RhTWxKT1ZESmthRlV3U25sWlZXTjJZVWhXZUZSdVZsRmtlakE1"))))))))), this.main.CountChooseRowInDatagridview())) == DialogResult.Yes;
					if (flag4)
					{
						flag = true;
					}
				}
				bool flag5 = flag;
				if (flag5)
				{
					List<string> list = new List<string>();
					string text = this.txbData.Text;
					for (int i = 0; i < this.main.dtgvAcc.Rows.Count; i++)
					{
						bool flag6 = Convert.ToBoolean(this.main.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
						if (flag6)
						{
							list.Add(this.main.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))));
						}
					}
					string text2 = this.cbbTypeUpdate.Text;
					string text3 = text2;
					uint num = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num <= 1335761915U)
					{
						if (num <= 267393898U)
						{
							if (num != 96026087U)
							{
								if (num == 267393898U)
								{
									if (text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtjd05VMUdjRmxVVkRBOQ==")))))))))
									{
										bool flag7 = CommonSQL.UpdateFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwS2IyTkdSWGxoUkVVOQ==")))))))), text);
										if (flag7)
										{
											for (int j = 0; j < this.main.dtgvAcc.Rows.Count; j++)
											{
												bool flag8 = Convert.ToBoolean(this.main.dtgvAcc.Rows[j].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
												if (flag8)
												{
													this.main.SetCellAccount(j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EySXlSbFpVYlRsclZWUXdPUT09")))))))), text, true);
												}
											}
										}
									}
								}
							}
							else if (text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaa1IyTkhTa2xsU0dSYVYwVTFOZz09")))))))))
							{
								bool flag9 = text.Split(new char[]
								{
									'|'
								}).Length != 2;
								if (flag9)
								{
									MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV1EwWVVod1RGUnVRa3BVVms1VFdWZE9OV0Z0U25SYU1tUmhVakJvVG1KNlNURmlhMnhHVFZkb2FGWXpaelJXVldSSFpXMU9OVkZyTlZwV01uaDZVMVpGT1ZCUlBUMD0="))))))))), 3);
									return;
								}
								bool flag10 = CommonSQL.UpdateMultiFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhsUkdocVVqQmFObGw2U1hoaFIwWllaSG93UFE9PQ==")))))))), text);
								if (flag10)
								{
									for (int k = 0; k < this.main.dtgvAcc.Rows.Count; k++)
									{
										bool flag11 = Convert.ToBoolean(this.main.dtgvAcc.Rows[k].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
										if (flag11)
										{
											this.main.SetCellAccount(k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ==")))))))), text.Split(new char[]
											{
												'|'
											})[0], true);
											this.main.SetCellAccount(k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYXpWYVZqSjRlZz09")))))))), text.Split(new char[]
											{
												'|'
											})[1], true);
										}
									}
								}
							}
						}
						else if (num != 750979128U)
						{
							if (num != 976575442U)
							{
								if (num == 1335761915U)
								{
									if (text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWb1MyUnRWa2xoZWpBOQ==")))))))))
									{
										int selectedIndex = this.cbbTypeProxy.SelectedIndex;
										string text4 = (text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) : (text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKak9WQlJQVDA9")))))))) + selectedIndex.ToString());
										bool flag12 = CommonSQL.UpdateFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnRWa2xoZWpBOQ==")))))))), text4);
										if (flag12)
										{
											for (int l = 0; l < this.main.dtgvAcc.Rows.Count; l++)
											{
												bool flag13 = Convert.ToBoolean(this.main.dtgvAcc.Rows[l].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
												if (flag13)
												{
													this.main.SetCellAccount(l, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ==")))))))), text4, true);
												}
											}
										}
									}
								}
							}
							else if (text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10ak5XTnNjRmhPUkRBOQ==")))))))))
							{
								bool flag14 = CommonSQL.UpdateFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XTnNjRmhPUkRBOQ==")))))))), text);
								if (flag14)
								{
									for (int m = 0; m < this.main.dtgvAcc.Rows.Count; m++)
									{
										bool flag15 = Convert.ToBoolean(this.main.dtgvAcc.Rows[m].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
										if (flag15)
										{
											this.main.SetCellAccount(m, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ==")))))))), text, true);
										}
									}
								}
							}
						}
						else if (text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWa1IyVnRUWHBhU0ZwcVlsWkZPUT09")))))))))
						{
							bool flag16 = CommonSQL.UpdateFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))), text);
							if (flag16)
							{
								for (int n = 0; n < this.main.dtgvAcc.Rows.Count; n++)
								{
									bool flag17 = Convert.ToBoolean(this.main.dtgvAcc.Rows[n].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
									if (flag17)
									{
										this.main.SetCellAccount(n, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09")))))))), text, true);
									}
								}
							}
						}
					}
					else if (num <= 2249983736U)
					{
						if (num != 1669390511U)
						{
							if (num == 2249983736U)
							{
								if (text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkMFlWRm5QVDA9")))))))))
								{
									bool flag18 = CommonSQL.UpdateFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFJtVlJQVDA9")))))))), text);
									if (flag18)
									{
										for (int num2 = 0; num2 < this.main.dtgvAcc.Rows.Count; num2++)
										{
											bool flag19 = Convert.ToBoolean(this.main.dtgvAcc.Rows[num2].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
											if (flag19)
											{
												this.main.SetCellAccount(num2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ==")))))))), text, true);
											}
										}
									}
								}
							}
						}
						else if (text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWa1IyVnRUWGROVjJob1ZqTmpPUT09")))))))))
						{
							bool flag20 = CommonSQL.UpdateMultiFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWa1IyVnRUWGROVjJob1ZqTmpPUT09")))))))), text);
							if (flag20)
							{
								for (int num3 = 0; num3 < this.main.dtgvAcc.Rows.Count; num3++)
								{
									bool flag21 = Convert.ToBoolean(this.main.dtgvAcc.Rows[num3].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
									if (flag21)
									{
										this.main.SetCellAccount(num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYXpWYVZqSjRlZz09")))))))), text, true);
									}
								}
							}
						}
					}
					else if (num != 3183131359U)
					{
						if (num != 3243292492U)
						{
							if (num == 3646757383U)
							{
								if (text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14b1QySkhUblJTYlRWaFZucFZkdz09")))))))))
								{
									bool flag22 = CommonSQL.UpdateFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1QySkhUblJTYlRWaFZucFZkdz09")))))))), text);
									if (flag22)
									{
										for (int num4 = 0; num4 < this.main.dtgvAcc.Rows.Count; num4++)
										{
											bool flag23 = Convert.ToBoolean(this.main.dtgvAcc.Rows[num4].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
											if (flag23)
											{
												this.main.SetCellAccount(num4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk=")))))))), text, true);
											}
										}
									}
								}
							}
						}
						else if (text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeGMyVlhVa2hoUjNSYVYwZHpPUT09")))))))))
						{
							bool flag24 = CommonSQL.UpdateFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeGMyVlhVa2hoUjNSYVYwZHpPUT09")))))))), text);
							if (flag24)
							{
								for (int num5 = 0; num5 < this.main.dtgvAcc.Rows.Count; num5++)
								{
									bool flag25 = Convert.ToBoolean(this.main.dtgvAcc.Rows[num5].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
									if (flag25)
									{
										this.main.SetCellAccount(num5, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1MyTkhUblZWYlRsaFVqQlpNUT09")))))))), text, true);
									}
								}
							}
						}
					}
					else if (text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNjOQ==")))))))))
					{
						bool flag26 = CommonSQL.UpdateFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoT1ZWUXdPUT09")))))))), text);
						if (flag26)
						{
							for (int num6 = 0; num6 < this.main.dtgvAcc.Rows.Count; num6++)
							{
								bool flag27 = Convert.ToBoolean(this.main.dtgvAcc.Rows[num6].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
								if (flag27)
								{
									this.main.SetCellAccount(num6, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09")))))))), text, true);
								}
							}
						}
					}
					base.Close();
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaWVsSnBaRmhTU2xJemNHOWtXRVpIWTBWc1NWUnRhR3RWTUZVNQ=="))))))))), 2);
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00401B5C File Offset: 0x003FFD5C
		private void cbbTypeUpdate_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool visible = this.cbbTypeUpdate.Text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWb1MyUnRWa2xoZWpBOQ=="))))))));
			this.label3.Visible = visible;
			this.cbbTypeProxy.Visible = visible;
		}

		// Token: 0x04001B06 RID: 6918
		private fMain main;
	}
}
