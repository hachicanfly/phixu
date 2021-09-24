using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x0200012A RID: 298
	public partial class fImportAccount : Form
	{
		// Token: 0x06000DB4 RID: 3508 RVA: 0x002B6AF8 File Offset: 0x002B4CF8
		public fImportAccount(string idFile)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.Load_cbbThuMuc();
			bool flag = idFile != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) && idFile != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9")))))))) && idFile != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkRGU2NrNVZPVlZoZWxVOQ=="))))))));
			if (flag)
			{
				this.cbbThuMuc.SelectedValue = idFile;
			}
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
				this.cbbDinhDang8,
				this.cbbDinhDang9
			};
			fImportAccount.isAddFile = false;
			fImportAccount.isAddAccount = false;
			fImportAccount.idFileAdded = -1;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x002B6CF4 File Offset: 0x002B4EF4
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

		// Token: 0x06000DB6 RID: 3510 RVA: 0x002B6E48 File Offset: 0x002B5048
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label3);
			Language.GetValue(this.label4);
			Language.GetValue(this.label5);
			Language.GetValue(this.label6);
			Language.GetValue(this.label2);
			Language.GetValue(this.label7);
			Language.GetValue(this.label16);
			Language.GetValue(this.button1);
			Language.GetValue(this.label8);
			Language.GetValue(this.label15);
			Language.GetValue(this.ckbCheckThongTin);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x002B6F44 File Offset: 0x002B5144
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txbAccount.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				bool flag = list.Count == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaU0yTXlWRVV4ZGswd1JtNWFSV1J4VWtoU1NFNVhOVXBUUmtwM1dXMXNRMDFHYkdwbFZVWm9WVEJLZVZsVll6VmhTSEJLWWtoV1NsVlVNRGs9"))))))))), 3);
					this.txbAccount.Focus();
				}
				else
				{
					bool flag2 = this.cbbThuMuc.SelectedValue == null;
					if (flag2)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkU5aU1razBaVmR3YVdGVlNYZFpWVEZvWkRCc1NFMVVSalpUTURWeFUxWkZPVkJSUFQwPQ=="))))))))), 3);
					}
					else
					{
						string idFile = this.cbbThuMuc.SelectedValue.ToString();
						bool isCheckThongTin = this.ckbCheckThongTin.Checked;
						int selectedIndex = this.cbbDinhDangNhap.SelectedIndex;
						bool flag3 = selectedIndex == 6;
						if (flag3)
						{
							bool flag4 = false;
							for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
							{
								bool flag5 = this.lstCbbDinhDang[i].SelectedIndex > -1;
								if (flag5)
								{
									flag4 = true;
									break;
								}
							}
							bool flag6 = !flag4;
							if (flag6)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOaGJVWklUREF4ZGsxcVVtNWxSWEJIWTBod1RGUnVWbWhSTUVweVYxZE9OV0Z0U25SWk1tUnJVakJvVGxvd1pISmFNa1Y1WVVoYVdsa3piRXRaYld4R1VGRTlQUT09"))))))))), 3);
								return;
							}
						}
						int maxThread = 100;
						bool flag7 = list.Count < 100;
						if (flag7)
						{
							maxThread = list.Count;
						}
						this.lblSuccess.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
						this.lblError.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
						this.lblWallDie.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
						this.lblKhongCheckDuoc.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
						this.lblWallLive.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
						this.lstAccount = new List<string>();
						string[] temp;
						switch (selectedIndex)
						{
						case 0:
						{
							int num = 3;
							for (int j = 0; j < list.Count; j++)
							{
								temp = list[j].Split(new char[]
								{
									'|'
								});
								bool flag8 = temp.Count<string>() >= num;
								if (flag8)
								{
									this.lstAccount.Add(string.Concat(new string[]
									{
										temp[0],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[1],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUhXa2xrZWpBOQ==")))))))),
										temp[2],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUJQVDA9"))))))))
									}));
								}
								else
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						case 1:
							for (int k = 0; k < list.Count; k++)
							{
								this.lstAccount.Add(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUJQVDA9")))))))) + list[k] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUhXa2xsUkdjOQ==")))))))));
							}
							break;
						case 2:
						{
							int num = 2;
							for (int l = 0; l < list.Count; l++)
							{
								temp = list[l].Split(new char[]
								{
									'|'
								});
								bool flag9 = temp.Count<string>() >= num;
								if (flag9)
								{
									this.lstAccount.Add(temp[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))) + temp[1] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUhXa2xsUkdodFUwaGpPUT09")))))))));
								}
								else
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						case 3:
						{
							int num = 4;
							for (int m = 0; m < list.Count; m++)
							{
								temp = list[m].Split(new char[]
								{
									'|'
								});
								bool flag10 = temp.Count<string>() >= num;
								if (flag10)
								{
									this.lstAccount.Add(string.Concat(new string[]
									{
										temp[0],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[1],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[2],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[3],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUhXa2xsUkdjOQ=="))))))))
									}));
								}
								else
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						case 4:
						{
							int num = 6;
							for (int n = 0; n < list.Count; n++)
							{
								temp = list[n].Split(new char[]
								{
									'|'
								});
								bool flag11 = temp.Count<string>() >= num;
								if (flag11)
								{
									this.lstAccount.Add(string.Concat(new string[]
									{
										temp[0],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[1],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[2],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[3],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[4],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[5],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUhXa0pRVkRBOQ=="))))))))
									}));
								}
								else
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						case 5:
						{
							int num = 7;
							for (int num2 = 0; num2 < list.Count; num2++)
							{
								temp = list[num2].Split(new char[]
								{
									'|'
								});
								bool flag12 = temp.Count<string>() >= num;
								if (flag12)
								{
									this.lstAccount.Add(string.Concat(new string[]
									{
										temp[0],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[1],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[2],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[3],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[4],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[5],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										temp[6],
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210b05FOUJQVDA9"))))))))
									}));
								}
								else
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						case 6:
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
							string text10 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							for (int num3 = 0; num3 < list.Count; num3++)
							{
								temp = list[num3].Split(new char[]
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
								text10 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								try
								{
									for (int num4 = 0; num4 < this.lstCbbDinhDang.Count; num4++)
									{
										switch (this.lstCbbDinhDang[num4].SelectedIndex)
										{
										case 0:
											text = temp[num4];
											break;
										case 1:
											text2 = temp[num4];
											break;
										case 2:
											text3 = temp[num4];
											break;
										case 3:
											text4 = temp[num4];
											break;
										case 4:
											text5 = temp[num4];
											break;
										case 5:
											text6 = temp[num4];
											break;
										case 6:
											text7 = temp[num4];
											break;
										case 7:
											text8 = temp[num4];
											break;
										case 8:
										{
											bool flag13 = temp[num4].Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
											if (flag13)
											{
												text9 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
											}
											else
											{
												text9 = temp[num4] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1FsQlJQVDA9"))))))));
											}
											break;
										}
										case 9:
											text10 = temp[num4];
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
										text9,
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										text10
									}));
								}
								catch
								{
									this.IncrementLabel(this.lblError, -1);
								}
							}
							break;
						}
						}
						List<string> lstQuery = new List<string>();
						this.lstThread = new List<Thread>();
						new Thread(delegate()
						{
							try
							{
								this.btnAdd.Invoke(new MethodInvoker(delegate()
								{
									this.btnAdd.Enabled = false;
								}));
								this.UpdateStatus(Language.GetValue("Chuẩn bị thêm tài khoản..."), this.lblStatus);
								bool isCheckThongTin = isCheckThongTin;
								if (isCheckThongTin)
								{
									int num5 = 0;
									while (num5 < this.lstAccount.Count)
									{
										bool flag14 = this.lstThread.Count < maxThread;
										if (flag14)
										{
											int stt = num5++;
											this.UpdateStatus(string.Format(Language.GetValue("Đang check thông tin {0}/{1}..."), num5, this.lstAccount.Count), this.lblStatus);
											Thread thread = new Thread(delegate()
											{
												try
												{
													string text14 = this.lstAccount[stt];
													bool flag19 = text14.Trim() == "";
													if (!flag19)
													{
														string[] array2 = text14.Split(new char[]
														{
															'|'
														});
														string text15 = array2[0];
														string pass2 = array2[1];
														string token2 = array2[2];
														string text16 = array2[3];
														string email2 = array2[4];
														string passMail2 = array2[5];
														string fa2 = array2[6];
														string useragent2 = array2[7];
														string proxy2 = array2[8];
														string birthday2 = array2[9];
														string name2 = "";
														string friends2 = "";
														string groups2 = "";
														string gender2 = "";
														string text17 = "unknow";
														bool flag20 = text15 == "";
														if (flag20)
														{
															text15 = Regex.Match(text16, "c_user=(.*?);").Groups[1].Value;
														}
														bool flag21 = text15 == "";
														if (flag21)
														{
															text17 = "Die";
														}
														else
														{
															string text18 = CommonRequest.CheckInfoUsingUid(text15);
															bool flag22 = text18.StartsWith("0|");
															if (flag22)
															{
																bool flag23 = CommonRequest.CheckLiveWall(text15).StartsWith("0|");
																if (flag23)
																{
																	text17 = "Die";
																}
															}
															else
															{
																bool flag24 = text18.StartsWith("1|");
																if (flag24)
																{
																	temp = text18.Split(new char[]
																	{
																		'|'
																	});
																	name2 = temp[2];
																	gender2 = temp[3].ToLower();
																	birthday2 = temp[4];
																	friends2 = temp[5];
																	groups2 = temp[6];
																	text17 = "Live";
																}
															}
														}
														string text19 = text17;
														string a = text19;
														if (!(a == "Live"))
														{
															if (!(a == "Die"))
															{
																this.IncrementLabel(this.lblKhongCheckDuoc, -1);
															}
															else
															{
																this.IncrementLabel(this.lblWallDie, -1);
															}
														}
														else
														{
															this.IncrementLabel(this.lblWallLive, -1);
														}
														lstQuery.Add(CommonSQL.ConvertToSqlInsertAccount(text15, pass2, token2, text16, email2, name2, friends2, groups2, birthday2, gender2, text17, fa2, idFile, passMail2, useragent2, proxy2));
													}
												}
												catch
												{
												}
											});
											this.lstThread.Add(thread);
											thread.Start();
										}
										else
										{
											for (int num6 = 0; num6 < this.lstThread.Count; num6++)
											{
												bool flag15 = !this.lstThread[num6].IsAlive;
												if (flag15)
												{
													this.lstThread.RemoveAt(num6--);
												}
											}
										}
									}
									for (int num7 = 0; num7 < this.lstThread.Count; num7++)
									{
										this.lstThread[num7].Join();
									}
								}
								else
								{
									for (int num8 = 0; num8 < this.lstAccount.Count; num8++)
									{
										try
										{
											string text11 = this.lstAccount[num8];
											bool flag16 = text11.Trim() == "";
											if (flag16)
											{
												return;
											}
											string[] array = text11.Split(new char[]
											{
												'|'
											});
											string text12 = array[0];
											string pass = array[1];
											string token = array[2];
											string text13 = array[3];
											string email = array[4];
											string passMail = array[5];
											string fa = array[6];
											string useragent = array[7];
											string proxy = array[8];
											string birthday = array[9];
											string name = "";
											string friends = "";
											string groups = "";
											string gender = "";
											string info = "unknow";
											bool flag17 = text12 == "";
											if (flag17)
											{
												text12 = Regex.Match(text13, "c_user=(.*?);").Groups[1].Value;
											}
											lstQuery.Add(CommonSQL.ConvertToSqlInsertAccount(text12, pass, token, text13, email, name, friends, groups, birthday, gender, info, fa, idFile, passMail, useragent, proxy));
										}
										catch
										{
										}
									}
								}
								this.UpdateStatus(Language.GetValue("Đang thêm tài khoản..."), this.lblStatus);
								bool flag18 = lstQuery.Count >= 0;
								if (flag18)
								{
									lstQuery = CommonSQL.ConvertToSqlInsertAccount(lstQuery);
									for (int num9 = 0; num9 < lstQuery.Count; num9++)
									{
										this.IncrementLabel(this.lblSuccess, Connector.Instance.ExecuteNonQuery(lstQuery[num9]));
									}
								}
								this.UpdateStatus((Convert.ToInt32(this.lblTotal.Text) - Convert.ToInt32(this.lblSuccess.Text)).ToString() ?? "", this.lblError);
								this.btnAdd.Invoke(new MethodInvoker(delegate()
								{
									this.btnAdd.Enabled = true;
								}));
								MessageBoxHelper.ShowMessageBox(Language.GetValue("Thêm tài khoản thành công!"), 1);
								this.UpdateStatus(Language.GetValue("Thêm tài khoản thành công!"), this.lblStatus);
								fImportAccount.isAddAccount = true;
								fImportAccount.idFileAdded = Convert.ToInt32(idFile);
							}
							catch (Exception ex2)
							{
								Common.ExportError(null, ex2, "AddAccount");
							}
						}).Start();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkljRXBVVjJSYVRXazVUbG94VGtOak0yTXpWa1V4YmsxdGRHNWFWV1JKVkZkc1dXRXlaR3BpVlZaNlUxVm9ZVTFYUmxSUmJrNXBUMGhzUWxsdE1XcGFNbEpJWVd0a2VsUlliRXRUVldRMFlVaHdURlJ1UWtwVFJUVnZXa1pPUmxCUlBUMD0="))))))))), 2);
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaa1UyRXhSbGhVYlhCcFRURmFNVnBGUlRsUVVUMDk=")))))))));
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x002B8CE8 File Offset: 0x002B6EE8
		private void UpdateStatus(string content, Label lbl)
		{
			lbl.Invoke(new MethodInvoker(delegate()
			{
				Application.DoEvents();
				lbl.Text = content;
			}));
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x002B8D2C File Offset: 0x002B6F2C
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

		// Token: 0x06000DBB RID: 3515 RVA: 0x002B8DA0 File Offset: 0x002B6FA0
		private void IncrementLabel(Label lbl, int count = -1)
		{
			bool flag = count == -1;
			if (flag)
			{
				lbl.Invoke(new MethodInvoker(delegate()
				{
					Application.DoEvents();
					lbl.Text = (Convert.ToInt32(lbl.Text) + ((count == -1) ? 1 : count)).ToString();
				}));
			}
			else
			{
				lbl.Invoke(new MethodInvoker(delegate()
				{
					Application.DoEvents();
					lbl.Text = (Convert.ToInt32(lbl.Text) + count).ToString();
				}));
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x002B8E1C File Offset: 0x002B701C
		private void cbbDinhDangNhap_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.plDinhDangNhap.Visible = (this.cbbDinhDangNhap.SelectedIndex == this.cbbDinhDangNhap.Items.Count - 1);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x002B8E68 File Offset: 0x002B7068
		private void button1_Click(object sender, EventArgs e)
		{
			fAddFile f = new fAddFile();
			Common.ShowForm(f);
			bool isAdd = fAddFile.isAdd;
			if (isAdd)
			{
				this.Load_cbbThuMuc();
				this.cbbThuMuc.SelectedIndex = this.cbbThuMuc.Items.Count - 1;
				fImportAccount.isAddFile = true;
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x002B8ED4 File Offset: 0x002B70D4
		private bool CheckExistDinhDang()
		{
			bool result = false;
			List<int> list = new List<int>();
			for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
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

		// Token: 0x06000DBF RID: 3519 RVA: 0x002B8F88 File Offset: 0x002B7188
		private void cbbDinhDang1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.CheckExistDinhDang();
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10b1dWUlhaRWxoTW1SYVRXMW9NbVZyZEU5a1ZXeElUbGRvTmxOVlNURlRWVEZVVld4c2FtVlZVa3BUUmxKRlpFVXhOVkZYU25CUmFrSmFXVE5zY1ZsV1RqTmFNbEoxVm01Q1NsSXphREpsYTJ4RFpGWndOVkZ0Y0doU2VUbE9ZbnBKTUZveVVrbFhSVEZ1VTBkMGJsZFVTbTlrYm5CTVZHNVdTbEl6VW5aWFYwNDFVV3hzTlZKVU1EMD0="))))))))), 3);
				(sender as ComboBox).SelectedIndex = -1;
			}
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00069C18 File Offset: 0x00067E18
		private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00069C18 File Offset: 0x00067E18
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040016FE RID: 5886
		public static bool isAddAccount = false;

		// Token: 0x040016FF RID: 5887
		public static int idFileAdded = -1;

		// Token: 0x04001700 RID: 5888
		public static bool isAddFile = false;

		// Token: 0x04001701 RID: 5889
		private List<ComboBox> lstCbbDinhDang;

		// Token: 0x04001702 RID: 5890
		private int indexOld = 0;

		// Token: 0x04001703 RID: 5891
		private List<string> lstAccount = new List<string>();

		// Token: 0x04001704 RID: 5892
		private List<Thread> lstThread = null;

		// Token: 0x04001705 RID: 5893
		private object objLock = new object();
	}
}
