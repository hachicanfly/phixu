using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;

namespace maxcare
{
	// Token: 0x02000126 RID: 294
	public partial class fCopy : Form
	{
		// Token: 0x06000D4B RID: 3403 RVA: 0x00298E78 File Offset: 0x00297078
		public fCopy(List<string> lstAcc)
		{
			this.InitializeComponent();
			this.lst = lstAcc;
			this.ChangeLanguage();
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
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00298F34 File Offset: 0x00297134
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.button1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00298F98 File Offset: 0x00297198
		private void SaveDinhDang()
		{
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
				{
					text = text + this.lstCbbDinhDang[i].SelectedIndex.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9"))))))));
				}
				text = text.TrimEnd(new char[]
				{
					'|'
				});
				File.WriteAllText(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YwMUhVa2hpU0ZaaFRUQTFhbGR0TURWbFYwcFlVbXBDV1Uxck5USlpNR2h5WkZkU1NXRkVRVDA9")))))))), text);
			}
			catch
			{
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00299124 File Offset: 0x00297324
		private void LoadDinhDang()
		{
			try
			{
				bool flag = File.Exists(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YwMUhVa2hpU0ZaaFRUQTFhbGR0TURWbFYwcFlVbXBDV1Uxck5USlpNR2h5WkZkU1NXRkVRVDA9")))))))));
				if (flag)
				{
					string text = File.ReadAllText(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YwMUhVa2hpU0ZaaFRUQTFhbGR0TURWbFYwcFlVbXBDV1Uxck5USlpNR2h5WkZkU1NXRkVRVDA9")))))))));
					for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
					{
						this.lstCbbDinhDang[i].SelectedIndex = Convert.ToInt32(text.Split(new char[]
						{
							'|'
						})[i]);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0029926C File Offset: 0x0029746C
		private void ResetDinhDang()
		{
			try
			{
				for (int i = 0; i < this.lstCbbDinhDang.Count; i++)
				{
					this.lstCbbDinhDang[i].SelectedIndex = -1;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x002992EC File Offset: 0x002974EC
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				int num = 0;
				for (int i = this.lstCbbDinhDang.Count - 1; i >= 0; i--)
				{
					bool flag = this.lstCbbDinhDang[i].SelectedIndex != -1;
					if (flag)
					{
						num = i + 1;
						break;
					}
				}
				bool flag2 = num == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOaGJVWklUREF4ZGsxcVVtNWxSWEJIWTBod1RGUnVWbWhSTUVweVYxZE9OV0Z0U25SWk1tUmFUMFU1Y0dWcmJFTmtWV3hJVkc1YWFsTkhkRzg9"))))))))), 3);
				}
				else
				{
					this.SaveDinhDang();
					for (int j = 0; j < this.lst.Count; j++)
					{
						text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						string[] array = this.lst[j].Split(new char[]
						{
							'|'
						});
						for (int k = 0; k < this.lstCbbDinhDang.Count; k++)
						{
							bool flag3 = this.lstCbbDinhDang[k].SelectedIndex != -1;
							if (flag3)
							{
								text += array[this.lstCbbDinhDang[k].SelectedIndex];
							}
							text += Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9"))))))));
						}
						text = text.TrimEnd(new char[]
						{
							'|'
						});
						for (int l = text.Split(new char[]
						{
							'|'
						}).Count<string>(); l < num; l++)
						{
							text += Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9"))))))));
						}
						list.Add(text);
					}
					string text2 = string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9")))))))), list);
					Clipboard.SetText(text2);
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSk5XUXlWbFJSYWtKb1VqQm9UbG93WXpGaU1HeElWVVZTTUZKNlZuVlRWa1U1VUZFOVBRPT0="))))))))), 1);
					base.Close();
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHVnJiRWhsYldneFRsZFNkMU5WYUhGaFNGWjRWR3BXU2xORmNHOVVSVTVEVFcxU1dHRXlaR2xVVlRrMVdXMHhhbG95VWtoaGJXZ3hUbXBDYmxsck9VaE9iVGxZWVRKa2FrMXJXWGhUVmtVNVVGRTlQUT09"))))))))), 2);
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x002997B8 File Offset: 0x002979B8
		private void button1_Click(object sender, EventArgs e)
		{
			this.ResetDinhDang();
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x002997D4 File Offset: 0x002979D4
		private void fCopy_Load(object sender, EventArgs e)
		{
			this.LoadDinhDang();
		}

		// Token: 0x04001605 RID: 5637
		private List<ComboBox> lstCbbDinhDang;

		// Token: 0x04001606 RID: 5638
		private List<string> lst = new List<string>();
	}
}
