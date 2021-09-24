using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x02000096 RID: 150
	public partial class fQuanLyTinNhan : Form
	{
		// Token: 0x060005D3 RID: 1491
		[DllImport("user32.dll", SetLastError = true)]
		public static extern long SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		// Token: 0x060005D4 RID: 1492
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);

		// Token: 0x060005D5 RID: 1493 RVA: 0x000AF6D8 File Offset: 0x000AD8D8
		public fQuanLyTinNhan(List<string> lstData)
		{
			this.InitializeComponent();
			Common.CreateFolder(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1lXRkhVa2hTYm1zOQ==")))))))));
			this.lstData = lstData;
			base.Width = Screen.PrimaryScreen.WorkingArea.Width;
			base.Height = Screen.PrimaryScreen.WorkingArea.Height;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x000AF7F0 File Offset: 0x000AD9F0
		public int CountChooseRowInDatagridview()
		{
			int result = 0;
			try
			{
				result = this.dgvTaiKhoan.SelectedRows.Count;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0005CE3C File Offset: 0x0005B03C
		public void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0006EF50 File Offset: 0x0006D150
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = base.Width == Screen.PrimaryScreen.WorkingArea.Width && base.Height == Screen.PrimaryScreen.WorkingArea.Height;
			bool flag2 = flag;
			if (flag2)
			{
				base.Width = Base.width;
				base.Height = Base.heigh;
				base.Top = Base.top;
				base.Left = Base.left;
			}
			else
			{
				Base.top = base.Top;
				Base.left = base.Left;
				base.Top = 0;
				base.Left = 0;
				base.Width = Screen.PrimaryScreen.WorkingArea.Width;
				base.Height = Screen.PrimaryScreen.WorkingArea.Height;
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000AF84C File Offset: 0x000ADA4C
		public void SetCellAccount(int indexRow, string column, object value, bool isAllowEmptyValue = true)
		{
			bool flag = !isAllowEmptyValue && value.ToString().Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (!flag)
			{
				DatagridviewHelper.SetStatusDataGridView(this.dgvTaiKhoan, indexRow, column, value);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000AF8F8 File Offset: 0x000ADAF8
		public string GetCellAccount(int indexRow, string column)
		{
			return DatagridviewHelper.GetStatusDataGridView(this.dgvTaiKhoan, indexRow, column);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0006F080 File Offset: 0x0006D280
		private void Button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000AF92C File Offset: 0x000ADB2C
		private void AddDataIntoDgv()
		{
			for (int i = 0; i < this.lstData.Count; i++)
			{
				string[] array = this.lstData[i].Split(new char[]
				{
					'|'
				});
				this.dgvTaiKhoan.Rows.Add(new object[]
				{
					this.dgvTaiKhoan.RowCount + 1,
					Image.FromFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZaamVHRkdiM2xXYm5CWlVucFdNbGRFU2tkTmJHeFpWVzFvYW1GVVZqTlpiVEZxVUZFOVBRPT0="))))))))),
					array[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9")))))))) + array[5],
					array[0],
					array[1],
					array[2],
					array[3],
					array[4],
					array[6],
					array[7]
				});
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000AFAEC File Offset: 0x000ADCEC
		private void fQuanLyTinNhan_Load(object sender, EventArgs e)
		{
			this.AddDataIntoDgv();
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00069C18 File Offset: 0x00067E18
		private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000AFB08 File Offset: 0x000ADD08
		private void AddChromeIntoControl(Chrome chrome, Control control)
		{
			base.Invoke(new MethodInvoker(delegate()
			{
				fQuanLyTinNhan.SetParent(chrome.process.MainWindowHandle, control.Handle);
				fQuanLyTinNhan.MoveWindow(chrome.process.MainWindowHandle, -10, 0, control.Size.Width + 20, control.Size.Height + 20, false);
			}));
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000AFB4C File Offset: 0x000ADD4C
		public int ShowChrome(int indexRow, string uid, string pass, string pass2fa, TabPage tabPage1, string cookie = "", string proxy = "")
		{
			int result = 0;
			int num = 0;
			try
			{
				string text = uid;
				bool flag = uid == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					uid = Regex.Match(cookie + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkROak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Groups[1].Value;
				}
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag2 = uid != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag2)
				{
					text2 = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + uid;
					bool flag3 = !Directory.Exists(text2);
					if (flag3)
					{
						text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					}
				}
				Chrome chrome = new Chrome
				{
					DisableImage = false,
					Size = new Point(300, 500),
					Position = new Point(0, -1000),
					TimeWaitForSearchingElement = 3,
					TimeWaitForLoadingPage = 60,
					ProfilePath = text2,
					UserAgent = Base.useragentDefault
				};
				bool flag4 = proxy != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag4)
				{
					int typeProxy = 0;
					bool flag5 = proxy.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
					if (flag5)
					{
						typeProxy = 1;
					}
					bool flag6 = proxy.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1FsQlJQVDA9"))))))))) || proxy.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
					if (flag6)
					{
						proxy = proxy.Substring(0, proxy.Length - 2);
					}
					chrome.Proxy = proxy;
					chrome.TypeProxy = typeProxy;
				}
				bool flag11;
				do
				{
					bool flag7 = !chrome.Open(false);
					if (flag7)
					{
						break;
					}
					chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVnBGWkhOTlIwcElWbFJzU21KclNqVlphazV2VGxac1dWWnFRbWhTUkVFNQ==")))))))) + proxy + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))));
					chrome.DelayTime(2.0);
					bool flag8 = !this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
					if (!flag8)
					{
						goto IL_7B1;
					}
					bool flag9 = proxy.Split(new char[]
					{
						':'
					}).Length > 1;
					if (!flag9)
					{
						goto IL_7B0;
					}
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNiMWt3WkhKa1YwcFpZa2hDYWxGNlZuRlpha2wzWkdjOVBRPT0=")))))))));
					chrome.DelayTime(1.0);
					string pageSource = chrome.GetPageSource();
					bool flag10 = !pageSource.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1FsQlJQVDA9")))))))));
					if (!flag10)
					{
						goto IL_7AF;
					}
					chrome.Close();
					num++;
					flag11 = (num < 3);
				}
				while (flag11);
				return result;
				IL_7AF:
				IL_7B0:
				IL_7B1:
				chrome.GetProcess();
				this.AddChromeIntoControl(chrome, tabPage1);
				bool flag12 = CommonChrome.CheckLiveCookie(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOUVNRDA9"))))))))) == 1;
				bool flag13 = !flag12;
				if (flag13)
				{
					bool flag14 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) && pass != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag14)
					{
						flag12 = (CommonChrome.LoginFacebookUsingUidPassNew(chrome, text, pass, pass2fa, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOUVNRDA9")))))))), 2, false, 120) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9")))))))));
					}
					else
					{
						bool flag15 = cookie != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag15)
						{
							flag12 = (CommonChrome.LoginFacebookUsingCookie(chrome, cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOUVNRDA9"))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9")))))))));
						}
					}
				}
				bool flag16 = !flag12;
				if (flag16)
				{
					this.SetRowColor(indexRow, 1);
					string idTap = this.dgvTaiKhoan.Rows[indexRow].Cells[3].Value.ToString();
					this.tabMain.Invoke(new MethodInvoker(delegate()
					{
						this.tabMain.TabPages.Remove(this.tabMain.TabPages[idTap]);
					}));
				}
				else
				{
					this.SetRowColor(indexRow, 2);
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlVbUZYUlRVMlYxWmthMkpIVGpWUFZFSk5aSG93T1E9PQ==")))))))));
					CommonRequest.DownLoadImageByUid(uid, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1lXRkhVa2hTYm1zOQ==")))))))));
					bool flag17 = File.Exists(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1lXRkhVa2hTYm14WlVWUXdPUT09")))))))) + uid + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMVEyUldjRE5RVkRBOQ==")))))))));
					if (flag17)
					{
						this.dgvTaiKhoan.Rows[indexRow].Cells[1].Value = Image.FromFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1lXRkhVa2hTYm14WlVWUXdPUT09")))))))) + uid + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMVEyUldjRE5RVkRBOQ==")))))))));
					}
				}
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000B08E4 File Offset: 0x000AEAE4
		private void SetRowColor(int indexRow, int typeColor)
		{
			switch (typeColor)
			{
			case 1:
				this.dgvTaiKhoan.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
				break;
			case 2:
				this.dgvTaiKhoan.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
				break;
			case 3:
				this.dgvTaiKhoan.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
				break;
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000B09DC File Offset: 0x000AEBDC
		private void DownloadImage(string url, string filePath)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] buffer = webClient.DownloadData(url);
					using (MemoryStream memoryStream = new MemoryStream(buffer))
					{
						using (Image image = Image.FromStream(memoryStream))
						{
							try
							{
								image.Save(filePath + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMVEyUldjRE5RVkRBOQ==")))))))), ImageFormat.Png);
							}
							catch
							{
								image.Save(filePath + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGQyUXhjRE5RVkRBOQ==")))))))), ImageFormat.Jpeg);
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000B0BC4 File Offset: 0x000AEDC4
		private void hiểnThịToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.lstThread = new List<Thread>();
				List<int> lstRow = new List<int>();
				foreach (object obj in this.dgvTaiKhoan.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					lstRow.Add(dataGridViewRow.Index);
				}
				int maxThread = lstRow.Count;
				new Thread(delegate()
				{
					try
					{
						int i = 0;
						while (i < lstRow.Count)
						{
							bool flag = this.lstThread.Count < maxThread;
							if (!flag)
							{
								break;
							}
							int row = lstRow[i++];
							bool flag2 = row != 0;
							if (flag2)
							{
								Thread.Sleep(this.rd.Next(this.settings.GetValueInt("nudDelayOpenChromeFrom", 0), this.settings.GetValueInt("nudDelayOpenChromeTo", 0) + 1) * 1000);
							}
							Thread thread = new Thread(delegate()
							{
								try
								{
									this.MoTrinhDuyetOneThread(row);
								}
								catch (Exception ex3)
								{
									Common.ExportError(null, ex3, "");
								}
							});
							thread.Name = row.ToString();
							this.lstThread.Add(thread);
							Common.DelayTime(1.0);
							thread.Start();
						}
						for (int j = 0; j < this.lstThread.Count; j++)
						{
							this.lstThread[j].Join();
						}
					}
					catch (Exception ex2)
					{
						Common.ExportError(null, ex2, "");
					}
				}).Start();
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000B0D10 File Offset: 0x000AEF10
		private void MoTrinhDuyetOneThread(int index)
		{
			int num = 0;
			string cookie = this.dgvTaiKhoan.Rows[index].Cells[6].Value.ToString();
			string text = this.dgvTaiKhoan.Rows[index].Cells[3].Value.ToString();
			string pass = this.dgvTaiKhoan.Rows[index].Cells[4].Value.ToString();
			string pass2fa = this.dgvTaiKhoan.Rows[index].Cells[5].Value.ToString();
			string proxy = this.dgvTaiKhoan.Rows[index].Cells[7].Value.ToString();
			TabPage tabPage1 = new TabPage();
			tabPage1.Name = text;
			tabPage1.Text = text;
			tabPage1.BackColor = Color.White;
			tabPage1.ForeColor = Color.White;
			for (int i = 0; i < this.tabMain.TabPages.Count; i++)
			{
				bool flag = this.tabMain.TabPages[i].Name.ToString() == tabPage1.Name;
				if (flag)
				{
					num++;
					break;
				}
			}
			bool flag2 = num == 0;
			if (flag2)
			{
				this.tabMain.Invoke(new MethodInvoker(delegate()
				{
					this.tabMain.ItemSize = new Size(0, 1);
					this.tabMain.TabPages.Add(tabPage1);
				}));
				this.ShowChrome(index, text, pass, pass2fa, tabPage1, cookie, proxy);
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000B0F5C File Offset: 0x000AF15C
		private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string idTap = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				MethodInvoker <>9__0;
				for (int i = 0; i < this.dgvTaiKhoan.SelectedRows.Count; i++)
				{
					idTap = this.dgvTaiKhoan.SelectedRows[i].Cells[3].Value.ToString();
					bool flag = this.tabMain.TabPages.Contains(this.tabMain.TabPages[idTap]);
					if (flag)
					{
						Control control = this.tabMain;
						MethodInvoker method;
						if ((method = <>9__0) == null)
						{
							method = (<>9__0 = delegate()
							{
								this.tabMain.TabPages.Remove(this.tabMain.TabPages[idTap]);
							});
						}
						control.Invoke(method);
						this.SetRowColor(this.dgvTaiKhoan.SelectedRows[i].Index, 3);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000B1100 File Offset: 0x000AF300
		private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string text = this.dgvTaiKhoan.SelectedRows[0].Cells[3].Value.ToString();
			for (int i = 0; i < this.tabMain.TabPages.Count; i++)
			{
				bool flag = this.tabMain.TabPages[i].Name.ToString() == text;
				if (flag)
				{
					this.tabMain.SelectedTab = this.tabMain.TabPages[text];
					break;
				}
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000B11D0 File Offset: 0x000AF3D0
		private void sửaGhiChúToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenFormUpdate(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtjd05VMUdjRmxVVkRBOQ==")))))))));
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000B1230 File Offset: 0x000AF430
		private void OpenFormUpdate(string type)
		{
			try
			{
				List<string> list = new List<string>();
				for (int i = 0; i < this.dgvTaiKhoan.SelectedRows.Count; i++)
				{
					list.Add(this.GetCellAccount(this.dgvTaiKhoan.SelectedRows[i].Index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))));
				}
				bool flag = list.Count == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOaGJVWklUREF4ZGsxcVVtNWFSV1JKVkZka1NHRXlaR2hOYldneVYxZE9OVk50U25CUmJYQXpUbXQ0VGxvd1l6QmFNV3MwVkRKc05sTXdOVE5UVldNeFlqTmpNbFJGTVhaTk1VWnY="))))))))), 3);
				}
				else
				{
					Common.ShowForm(new fUpdateData2(this, type));
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000538 RID: 1336
		private Random rd = new Random();

		// Token: 0x04000539 RID: 1337
		private JSON_Settings settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);

		// Token: 0x0400053A RID: 1338
		private List<string> lstData = new List<string>();

		// Token: 0x0400053B RID: 1339
		private List<Thread> lstThread = null;
	}
}
