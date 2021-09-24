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
	// Token: 0x0200006C RID: 108
	public partial class fClearBackup : Form
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x000699E8 File Offset: 0x00067BE8
		public fClearBackup()
		{
			this.InitializeComponent();
			this.setting_general = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
			this.ChangeLanguage();
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00069A70 File Offset: 0x00067C70
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00069AC4 File Offset: 0x00067CC4
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.btnAdd.Enabled = false;
			this.btnCancel.Enabled = false;
			this.LoadStatus(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SaFZEQmpNMkZzWXpCYU1YQlFVbnBhTVZkRlJtNVhWekZIWVcxRmVsWnVaRXBUU0U0eldteE5OVTR3TVZsTlNGWk5ZVlJST1E9PQ=="))))))))), 0, this.lstProfileRac.Count));
			int iThread = 0;
			int maxThread = 20;
			int count = 0;
			string pathToBackup = FileHelper.GetPathToCurrentFolder() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1MyRkdhM2xrUkVacVVWUXdPUT09"))))))));
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
									string path = pathToBackup + "\\" + this.lstProfileRac[row];
									Directory.Delete(path, true);
									Interlocked.Increment(ref count);
									this.LoadStatus(string.Format(Language.GetValue("Đang dọn dẹp backup {0}/{1}..."), count, this.lstProfileRac.Count));
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
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Đã dọn dẹp file backup xong!"), 1);
						});
					}
					<>4__this.Invoke(method);
				}
				catch
				{
				}
			}).Start();
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00069C18 File Offset: 0x00067E18
		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00069C28 File Offset: 0x00067E28
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

		// Token: 0x0600045B RID: 1115 RVA: 0x00069D08 File Offset: 0x00067F08
		private void LoadStatus(string content)
		{
			base.Invoke(new Action(delegate()
			{
				this.lblStatus.Text = content;
			}));
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00069D4C File Offset: 0x00067F4C
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			new Thread(delegate()
			{
				try
				{
					List<string> list = Directory.GetDirectories(FileHelper.GetPathToCurrentFolder() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1MyRkdhM2xrUkVacVVWUXdPUT09"))))))))).ToList<string>();
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
							this.lblStatus.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVHTXlTbFJSYWtKb1ZEQmpNbU5HYUhKYU1sWTJVV3BzU2xJeGNIZFphMlJXV2pGc2RGSnRjR2hOTVZvelUxVm9UVkpIT1ZoVVYyYzk="))))))))), this.lstProfileRac.Count) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9")))))))) + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWTNoTlZGSnBaRlpLYVdGVlNuSk9SMG94VkcxS2NGRnRjekJaYmtVeFdUQlJORkJSUFQwPQ==")))))))));
							this.btnAdd.Visible = true;
							this.btnCancel.Visible = true;
						}));
					}
					else
					{
						base.Invoke(new Action(delegate()
						{
							base.Close();
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNSV016YkVOaVYwWllaVWQ0U2xJd2NHOVhWRW93VFZkT1JGRnViRE5PYTFweFUxWkZPVkJSUFQwPQ=="))))))))), 1);
						}));
					}
				}
				catch
				{
				}
			}).Start();
		}

		// Token: 0x04000326 RID: 806
		private JSON_Settings setting_general;

		// Token: 0x04000327 RID: 807
		private List<string> lstProfileRac = new List<string>();
	}
}
