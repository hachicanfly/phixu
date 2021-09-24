using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x020000F2 RID: 242
	public partial class fClearProfile : Form
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x001C64C4 File Offset: 0x001C46C4
		public fClearProfile()
		{
			this.InitializeComponent();
			this.setting_general = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
			this.ChangeLanguage();
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x001C654C File Offset: 0x001C474C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x001C65A0 File Offset: 0x001C47A0
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.btnAdd.Enabled = false;
			this.btnCancel.Enabled = false;
			int count = 0;
			this.LoadStatus(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SaFZEQmpNMkZzWXpCYU1YQlFVbnBhTVZkRlJtNVpNR2hMWkd4d2RHSklUbUZWTUVrelZGVm5kMlJ0VmpaU2FteE5ZVlJTTVE9PQ=="))))))))), count, this.lstProfileRac.Count));
			int iThread = 0;
			int maxThread = 20;
			Action <>9__1;
			new Thread(delegate()
			{
				try
				{
					int i = 0;
					while (i < this.lstProfileRac.Count)
					{
						bool flag = iThread < maxThread;
						if (flag)
						{
							Interlocked.Increment(ref iThread);
							int row = i++;
							new Thread(delegate()
							{
								try
								{
									string path = this.setting_general.GetValue("txbPathProfile", "") + "\\" + this.lstProfileRac[row];
									Directory.Delete(path, true);
									Interlocked.Increment(ref count);
									this.LoadStatus(string.Format(Language.GetValue("Đang dọn dẹp profile {0}/{1}..."), count, this.lstProfileRac.Count));
									Interlocked.Decrement(ref iThread);
								}
								catch
								{
								}
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					while (iThread > 0)
					{
						Common.DelayTime(1.0);
					}
					Control <>4__this = this;
					Action method;
					if ((method = <>9__1) == null)
					{
						method = (<>9__1 = delegate()
						{
							this.Close();
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã dọn dẹp profile xong!"), 1);
						});
					}
					<>4__this.Invoke(method);
				}
				catch
				{
				}
			}).Start();
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00069C18 File Offset: 0x00067E18
		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00069C28 File Offset: 0x00067E28
		private List<string> GetListUidFromDatabase()
		{
			List<string> list = new List<string>();
			try
			{
				DataTable allAccountFromDatabase = CommonSQL.GetAllAccountFromDatabase(true);
				for (int i = 0; i < allAccountFromDatabase.Rows.Count; i++)
				{
					list.Add(allAccountFromDatabase.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRjNQVDA9"))))))))].ToString());
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x001C66A0 File Offset: 0x001C48A0
		private void LoadStatus(string content)
		{
			base.Invoke(new Action(delegate()
			{
				this.lblStatus.Text = content;
			}));
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x001C66E4 File Offset: 0x001C48E4
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			new Thread(delegate()
			{
				try
				{
					List<string> list = Directory.GetDirectories(this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))))).ToList<string>();
					List<string> listUidFromDatabase = this.GetListUidFromDatabase();
					string item = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					for (int i = 0; i < list.Count; i++)
					{
						item = list[i].Substring(list[i].LastIndexOf(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9"))))))))) + 1);
						bool flag = !listUidFromDatabase.Contains(item);
						if (flag)
						{
							this.lstProfileRac.Add(item);
						}
					}
					bool flag2 = this.lstProfileRac.Count > 0;
					if (flag2)
					{
						base.Invoke(new Action(delegate()
						{
							this.lblStatus.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVHTXlTbFJSYWtKb1ZEQmpNbU5HYUhKYU1sWTJVV3BzU2xORlNqVlpha3BoWTBkS1NGWlhaR3BqTURsdlYxaHNSbEJSUFQwPQ=="))))))))), this.lstProfileRac.Count) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9")))))))) + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWTNoTlZGSnBaRlpLYVdGVlNuSk9SMG94VkcxS2NGRnRjekJaYmtVeFdUQlJORkJSUFQwPQ==")))))))));
							this.btnAdd.Visible = true;
							this.btnCancel.Visible = true;
						}));
					}
					else
					{
						base.Invoke(new Action(delegate()
						{
							base.Close();
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNSV016YkVOa01rNTBUMWN4YUZZemFITlRWV2hOVWtjNVdGUlhaejA9"))))))))), 1);
						}));
					}
				}
				catch (Exception ex)
				{
				}
			}).Start();
		}

		// Token: 0x04000E6E RID: 3694
		private JSON_Settings setting_general;

		// Token: 0x04000E6F RID: 3695
		private List<string> lstProfileRac = new List<string>();
	}
}
