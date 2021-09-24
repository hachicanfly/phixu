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
	// Token: 0x02000068 RID: 104
	public partial class fCapNhatDuLieu : Form
	{
		// Token: 0x0600042C RID: 1068 RVA: 0x0005CCD0 File Offset: 0x0005AED0
		public fCapNhatDuLieu()
		{
			this.InitializeComponent();
			this.cbbDinhDangNhap.SelectedIndex = 0;
			this.lstCbbDinhDang = new List<ComboBox>
			{
				this.cbbDinhDang1,
				this.cbbDinhDang2,
				this.cbbDinhDang3,
				this.cbbDinhDang4,
				this.cbbDinhDang5,
				this.cbbDinhDang6,
				this.cbbDinhDang7,
				this.cbbDinhDang8
			};
			fCapNhatDuLieu.isAdd = false;
			this.ChangeLanguage();
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0005CDA4 File Offset: 0x0005AFA4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label3);
			Language.GetValue(this.label4);
			Language.GetValue(this.label7);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0005CE58 File Offset: 0x0005B058
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.lstAccountNotError = new List<string>();
			this.lstAccountError = new List<string>();
			try
			{
				List<string> list = this.txbAccount.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				bool flag = list.Count == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaU0yTXlWRVV4ZGswd1JtNWFSV1J4VWtoU1NFNVhOVXBUUmtwM1dXMXNRMDFHYkdwbFZVWm9WVEJLZVZsVll6VmhTSEJLWWtoV1NsVlVNRGs9"))))))))), 1);
					this.txbAccount.Focus();
				}
				else
				{
					int selectedIndex = this.cbbDinhDangNhap.SelectedIndex;
					bool flag2 = selectedIndex == 5;
					if (flag2)
					{
						bool flag3 = false;
						for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
						{
							bool flag4 = this.lstCbbDinhDang[i].SelectedIndex > -1;
							if (flag4)
							{
								flag3 = true;
								break;
							}
						}
						bool flag5 = !flag3;
						if (flag5)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOaGJVWklUREF4ZGsxcVVtNWxSWEJIWTBod1RGUnVWbWhSTUVweVYxZE9OV0Z0U25SWk1tUnJVakJvVGxvd1pISmFNa1Y1WVVoYVdsa3piRXRaYld4R1VGRTlQUT09"))))))))), 1);
							return;
						}
					}
					this.lblSuccess.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
					this.lblError.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
					this.lstAccount = new List<string>();
					switch (selectedIndex)
					{
					case 0:
					{
						int num = 2;
						for (int j = 0; j < list.Count; j++)
						{
							string[] array = list[j].Split(new char[]
							{
								'|'
							});
							bool flag6 = array.Count<string>() >= num;
							if (flag6)
							{
								this.lstAccount.Add(array[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))) + array[1] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUhXa2xsUkdodFVWUXdPUT09")))))))));
								this.lstAccountNotError.Add(list[j]);
							}
							else
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[j]);
							}
						}
						break;
					}
					case 1:
					{
						int num = 3;
						for (int k = 0; k < list.Count; k++)
						{
							string[] array = list[k].Split(new char[]
							{
								'|'
							});
							bool flag7 = array.Count<string>() >= num;
							if (flag7)
							{
								this.lstAccount.Add(string.Concat(new string[]
								{
									array[0],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[1],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUhXa2xrZWpBOQ==")))))))),
									array[2],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b00xQlJQVDA9"))))))))
								}));
								this.lstAccountNotError.Add(list[k]);
							}
							else
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[k]);
							}
						}
						break;
					}
					case 2:
					{
						int num = 4;
						for (int l = 0; l < list.Count; l++)
						{
							string[] array = list[l].Split(new char[]
							{
								'|'
							});
							bool flag8 = array.Count<string>() >= num;
							if (flag8)
							{
								this.lstAccount.Add(string.Concat(new string[]
								{
									array[0],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[1],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[2],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[3],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUhXa2xrZWpBOQ=="))))))))
								}));
								this.lstAccountNotError.Add(list[l]);
							}
							else
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[l]);
							}
						}
						break;
					}
					case 3:
					{
						int num = 6;
						for (int m = 0; m < list.Count; m++)
						{
							string[] array = list[m].Split(new char[]
							{
								'|'
							});
							bool flag9 = array.Count<string>() >= num;
							if (flag9)
							{
								this.lstAccount.Add(string.Concat(new string[]
								{
									array[0],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[1],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[2],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[3],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[4],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[5],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUJQVDA9"))))))))
								}));
								this.lstAccountNotError.Add(list[m]);
							}
							else
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[m]);
							}
						}
						break;
					}
					case 4:
					{
						int num = 7;
						for (int n = 0; n < list.Count; n++)
						{
							string[] array = list[n].Split(new char[]
							{
								'|'
							});
							bool flag10 = array.Count<string>() >= num;
							if (flag10)
							{
								this.lstAccount.Add(string.Concat(new string[]
								{
									array[0],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[1],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[2],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[3],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[4],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[5],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									array[6],
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b00xQlJQVDA9"))))))))
								}));
								this.lstAccountNotError.Add(list[n]);
							}
							else
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[n]);
							}
						}
						break;
					}
					case 5:
					{
						string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						string text3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						string text4 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						string text5 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						string text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						string text7 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						string text8 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						string text9 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						for (int num2 = 0; num2 < list.Count; num2++)
						{
							string[] array = list[num2].Split(new char[]
							{
								'|'
							});
							text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							text3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							text4 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							text5 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							text7 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							text8 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							text9 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							try
							{
								text = array[0];
								for (int num3 = 1; num3 < this.lstCbbDinhDang.Count; num3++)
								{
									switch (this.lstCbbDinhDang[num3 - 1].SelectedIndex)
									{
									case 0:
										text = array[num3];
										break;
									case 1:
										text2 = array[num3];
										break;
									case 2:
										text3 = array[num3];
										break;
									case 3:
										text4 = array[num3];
										break;
									case 4:
										text5 = array[num3];
										break;
									case 5:
										text6 = array[num3];
										break;
									case 6:
										text7 = array[num3];
										break;
									case 7:
										text8 = array[num3];
										break;
									case 8:
										text9 = ((array[num3] == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) : (array[num3] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKak9WQlJQVDA9")))))))) + this.cbbTypeProxy.SelectedIndex.ToString()));
										break;
									}
								}
								this.lstAccount.Add(string.Concat(new string[]
								{
									text,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									text2,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									text3,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									text4,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									text5,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									text6,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									text7,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									text8,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									text9
								}));
								this.lstAccountNotError.Add(list[num2]);
							}
							catch
							{
								this.IncrementLabel(this.lblError);
								this.lstAccountError.Add(list[num2]);
							}
						}
						break;
					}
					}
					this.btnAdd.Invoke(new MethodInvoker(delegate()
					{
						this.btnAdd.Enabled = false;
					}));
					this.UpdateStatus(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SYVN6QmpNbU5zYUVKYU1rcDBZVzFvTVdOVVJYZFRWV1JWWVVoVk1rOUhaR2xTTWpWdlpGUlNhMDFWZUhCT1NGVTk="))))))))));
					for (int num4 = 0; num4 < this.lstAccount.Count; num4++)
					{
						bool flag11 = CommonSQL.UpdateAccountByUid(this.lstAccount[num4]);
						if (flag11)
						{
							this.IncrementLabel(this.lblSuccess);
						}
						else
						{
							this.IncrementLabel(this.lblError);
						}
					}
					this.btnAdd.Invoke(new MethodInvoker(delegate()
					{
						this.btnAdd.Enabled = true;
					}));
					this.lstAccountNotError.AddRange(this.lstAccountError);
					this.txbAccount.Lines = this.lstAccountNotError.ToArray();
					this.UpdateStatus(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeElWa2RvTVU1cWFHNVphMlIxWVVoVk1GcEVSa3BUUjJneVdXMHhhbUZCUFQwPQ=="))))))))));
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeElWa2RvTVU1cWFHNVphMlIxWVVoVk1GcEVSa3BUUjJneVdXMHhhbUZCUFQwPQ=="))))))))), 1);
					fCapNhatDuLieu.isAdd = true;
				}
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkljRXBVVjJSYVRXazVUbG94VGtOak0yTXpWa1V4YmsxdGRHNWFWV1JKVkZkc1dXRXlaR3BpVlZaNlUxVm9ZVTFYUmxSUmJrNXBUMGhzUWxsdE1XcGFNbEpJWVd0a2VsUlliRXRUVldRMFlVaHdURlJ1UWtwVFJUVnZXa1pPUmxCUlBUMD0="))))))))), 1);
				Common.ExportError(ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14b1EyRXhiRmxWYlhoU1ZqQTFjVmxxVGxka1YxSkNVRlF3UFE9PQ==")))))))));
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0005EAAC File Offset: 0x0005CCAC
		private void UpdateStatus(string content)
		{
			Application.DoEvents();
			this.lblStatus.Invoke(new MethodInvoker(delegate()
			{
				this.lblStatus.Text = content;
			}));
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0005EAFC File Offset: 0x0005CCFC
		private void TxbAccount_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txbAccount.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.lblTotal.Text = list.Count.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0005EB70 File Offset: 0x0005CD70
		private void IncrementLabel(Label lbl)
		{
			Application.DoEvents();
			Label lbl2 = lbl;
			lock (lbl2)
			{
				lbl.Invoke(new MethodInvoker(delegate()
				{
					int num = Convert.ToInt32(lbl.Text);
					num++;
					lbl.Text = num.ToString();
				}));
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0005EBF0 File Offset: 0x0005CDF0
		private void cbbDinhDangNhap_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.plDinhDangNhap.Visible = (this.cbbDinhDangNhap.SelectedIndex == this.cbbDinhDangNhap.Items.Count - 1);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0005EC3C File Offset: 0x0005CE3C
		private bool CheckExistDinhDang()
		{
			bool result = false;
			List<int> list = new List<int>();
			for (int i = 0; i <= 6; i++)
			{
				int selectedIndex = this.lstCbbDinhDang[i].SelectedIndex;
				bool flag = selectedIndex != -1;
				if (flag)
				{
					bool flag2 = list.Contains(selectedIndex);
					if (flag2)
					{
						result = true;
						break;
					}
					list.Add(selectedIndex);
				}
			}
			return result;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0005ECEC File Offset: 0x0005CEEC
		private void cbbDinhDang1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool visible = false;
			for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
			{
				bool flag = this.lstCbbDinhDang[i].Text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWb1MyUnRWa2xoZWpBOQ=="))))))));
				if (flag)
				{
					visible = true;
					break;
				}
			}
			this.label2.Visible = visible;
			this.cbbTypeProxy.Visible = visible;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0005EDC8 File Offset: 0x0005CFC8
		private void fCapNhatDuLieu_Load(object sender, EventArgs e)
		{
			this.cbbTypeProxy.SelectedIndex = 0;
		}

		// Token: 0x040002C6 RID: 710
		public static bool isAdd;

		// Token: 0x040002C7 RID: 711
		private List<ComboBox> lstCbbDinhDang;

		// Token: 0x040002C8 RID: 712
		private List<string> lstAccount = new List<string>();

		// Token: 0x040002C9 RID: 713
		private List<string> lstAccountNotError = new List<string>();

		// Token: 0x040002CA RID: 714
		private List<string> lstAccountError = new List<string>();
	}
}
