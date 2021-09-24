using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Common;
using ConversionBack;
using maxcare.Enum;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x020000EE RID: 238
	public partial class fChange : Form
	{
		// Token: 0x0600099B RID: 2459 RVA: 0x0019FD08 File Offset: 0x0019DF08
		public fChange(List<string> listAcc)
		{
			this.InitializeComponent();
			bool flag = listAcc != null && listAcc.Count > 0;
			if (flag)
			{
				for (int i = 0; i < listAcc.Count; i++)
				{
					this.dtgvAcc.Rows.Add(new object[]
					{
						true,
						listAcc[i].Split(new char[]
						{
							'|'
						})[0],
						listAcc[i].Split(new char[]
						{
							'|'
						})[1],
						listAcc[i].Split(new char[]
						{
							'|'
						})[2],
						listAcc[i].Split(new char[]
						{
							'|'
						})[3],
						listAcc[i].Split(new char[]
						{
							'|'
						})[4],
						listAcc[i].Split(new char[]
						{
							'|'
						})[5],
						listAcc[i].Split(new char[]
						{
							'|'
						})[6],
						listAcc[i].Split(new char[]
						{
							'|'
						})[7],
						listAcc[i].Split(new char[]
						{
							'|'
						})[8],
						listAcc[i].Split(new char[]
						{
							'|'
						})[9],
						listAcc[i].Split(new char[]
						{
							'|'
						})[10],
						listAcc[i].Split(new char[]
						{
							'|'
						})[11],
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))
					});
				}
			}
			this.CountAcc();
			this.LoadConfig();
			this.ChangeLanguage();
			fChange.isAdd = false;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x001A03CC File Offset: 0x0019E5CC
		private void LoadConfig()
		{
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWU1RXMW9iMWx0TVd0aVFUMDk=")))))))), false);
			this.setting_general = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
			this.settingg = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWU1RXMW9jMWRVU2pCa01rbDVZa2hXYTFGVU1Eaz0=")))))))), false);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x001A04E8 File Offset: 0x0019E6E8
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = base.WindowState == FormWindowState.Maximized;
			if (flag)
			{
				base.WindowState = FormWindowState.Normal;
			}
			else
			{
				base.WindowState = FormWindowState.Maximized;
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0006F080 File Offset: 0x0006D280
		private void Button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x001A053C File Offset: 0x0019E73C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.btnStart);
			Language.GetValue(this.btnPause);
			Language.GetValue(this.btnConfig);
			Language.GetValue(this.button3);
			Language.GetValue(this.bunifuCustomLabel2);
			Language.GetValue(this.label7);
			foreach (object obj in this.dtgvAcc.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
			Language.GetValue(this.chọnTấtCảToolStripMenuItem);
			Language.GetValue(this.bỏChọnTấtCảToolStripMenuItem);
			Language.GetValue(this.ctmsChonTrangThai);
			Language.GetValue(this.xóaToolStripMenuItem);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x001A0670 File Offset: 0x0019E870
		private void rControl(string dt)
		{
			try
			{
				bool flag = dt == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1UyRkhUblZWVkRBOQ=="))))))));
				if (flag)
				{
					base.Invoke(new MethodInvoker(delegate()
					{
						this.btnPause.Enabled = true;
						this.btnStart.Enabled = false;
					}));
				}
				else
				{
					bool flag2 = dt == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1UyUnRUa0pRVkRBOQ=="))))))));
					if (flag2)
					{
						base.Invoke(new MethodInvoker(delegate()
						{
							this.btnPause.Text = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1NWUlhPSGxOUjJSaFZGZEdNMlZyYkVOa1ZuQXpVRlF3UFE9PQ==")))))))));
							this.btnPause.Enabled = false;
							this.btnStart.Enabled = true;
						}));
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x001A0798 File Offset: 0x0019E998
		private void CountAcc()
		{
			try
			{
				this.lblCountAcc.Text = this.dtgvAcc.RowCount.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x001A07F8 File Offset: 0x0019E9F8
		private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool flag = e.ColumnIndex == 0;
				if (flag)
				{
					try
					{
						bool flag2 = Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
						if (flag2)
						{
							this.dtgvAcc.CurrentRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = false;
						}
						else
						{
							this.dtgvAcc.CurrentRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = true;
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			this.UpdateSelectCountRecord();
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x001A09E8 File Offset: 0x0019EBE8
		private void UpdateSelectCountRecord()
		{
			int count = 0;
			for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
			{
				bool flag = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
				if (flag)
				{
					int count2 = count;
					count = count2 + 1;
				}
			}
			try
			{
				this.lblChoosed.Invoke(new MethodInvoker(delegate()
				{
					this.lblChoosed.Text = count.ToString();
				}));
			}
			catch
			{
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x001A0B1C File Offset: 0x0019ED1C
		private void dtgvAcc_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyValue == 32;
				if (flag)
				{
					for (int i = 0; i < this.dtgvAcc.SelectedRows.Count; i++)
					{
						int index = this.dtgvAcc.SelectedRows[i].Index;
						bool flag2 = Convert.ToBoolean(this.dtgvAcc.Rows[index].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
						if (flag2)
						{
							this.dtgvAcc.Rows[index].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = false;
						}
						else
						{
							this.dtgvAcc.Rows[index].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = true;
						}
					}
				}
			}
			catch
			{
			}
			this.UpdateSelectCountRecord();
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x001A0D44 File Offset: 0x0019EF44
		private void chọnTấtCảToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
				{
					this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = true;
				}
			}
			catch
			{
			}
			this.UpdateSelectCountRecord();
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x001A0E30 File Offset: 0x0019F030
		private void bỏChọnTấtCảToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
				{
					this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = false;
				}
			}
			catch
			{
			}
			this.UpdateSelectCountRecord();
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ctmsChonTrangThai_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x001A0F1C File Offset: 0x0019F11C
		private void xóaToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				string input = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
				{
					bool flag = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
					if (flag)
					{
						input = this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))))].Value.ToString();
						text = Regex.Match(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Groups[1].Value;
						this.dtgvAcc.Rows.RemoveAt(i);
						i--;
					}
				}
				input = this.dtgvAcc.SelectedRows[0].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))))].Value.ToString();
				text = Regex.Match(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Groups[1].Value;
			}
			catch (Exception)
			{
			}
			this.UpdateSelectCountRecord();
			this.CountAcc();
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x001A1274 File Offset: 0x0019F474
		private void ctmsAcc_Opening(object sender, CancelEventArgs e)
		{
			this.ctmsChonTrangThai.DropDownItems.Clear();
			List<string> list = new List<string>();
			for (int i = 0; i < this.dtgvAcc.RowCount; i++)
			{
				bool flag = this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09"))))))))].Value != null && !this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09"))))))))].Value.ToString().Equals(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) && !list.Contains(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09"))))))))].Value.ToString());
				if (flag)
				{
					string text = this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09"))))))))].Value.ToString();
					string value = Regex.Match(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWT2IxTnNWa1ZpTW1STVVYcFNlRlZJYkhOWk1IUlNVRlF3UFE9PQ=="))))))))).Value;
					bool flag2 = value != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag2)
					{
						text = text.Replace(value, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Trim();
					}
					value = Regex.Match(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWYWVtSXdlSEJpZVRsTVZtNW9hdz09"))))))))).Value;
					bool flag3 = value != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag3)
					{
						text = text.Replace(value, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Trim();
					}
					bool flag4 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) && !list.Contains(text);
					if (flag4)
					{
						list.Add(text);
					}
				}
			}
			for (int j = 0; j < list.Count; j++)
			{
				this.ctmsChonTrangThai.DropDownItems.Add(list[j]);
				this.ctmsChonTrangThai.DropDownItems[j].Click += this.SelectGridByStatus;
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x001A17E0 File Offset: 0x0019F9E0
		private void SelectGridByStatus(object sender, EventArgs e)
		{
			for (int i = 0; i < this.dtgvAcc.RowCount; i++)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
				string text = toolStripMenuItem.Text;
				this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09"))))))))].Value.ToString().Contains(text);
			}
			this.UpdateSelectCountRecord();
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x001A1924 File Offset: 0x0019FB24
		private void btnConfig_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fChangeConfig());
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x001A1940 File Offset: 0x0019FB40
		public List<string> CloneList(List<string> lstFrom)
		{
			List<string> list = new List<string>();
			try
			{
				for (int i = 0; i < lstFrom.Count; i++)
				{
					list.Add(lstFrom[i]);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x001A19C4 File Offset: 0x0019FBC4
		public List<string> GetListKeyTinsoft()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3598304, 2512, 1874, parameters);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x001A1A0C File Offset: 0x0019FC0C
		private void btnShare_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.LoadConfig();
				int maxThread = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyV2xOaU1rNTBWbTFvWVZGVU1Eaz0=")))))))), 3);
				bool flag = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEd0alJteFlZa1ZTYUZJeFduRlpWRVpEWkcxR1dFNVVRVDA9")))))))), false) && this.settingg.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUbGhOVjJoaFRXeFZPUT09")))))))), false);
				if (flag)
				{
					string value = this.settingg.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdUbGhOVjJoaFRXeFZPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					bool flag2 = value == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag2)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOaGJVWlFVbnBrY1ZaNlVtNWxSWEJKVWpOT1VGSjZaSFZXZWxaMVUxVmtWV0ZJVm5oa1NGWktVakZ3TWxsclpGTmlSMDV3VVcxd2FGUXdZek5qVm1SR1ducFNhV05YY0dsaVYyTTU="))))))))), 2);
						return;
					}
					bool flag3 = Directory.GetFiles(value).Length == 0;
					if (flag3)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOTlIwWk9WRE5HYVZVd1NtOWxhMnh6WkZkR1JGSlVNRDA9"))))))))), 2);
						return;
					}
					this.lstPathImage = Directory.GetFiles(value).ToList<string>();
				}
				bool valueBool = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldVbXBLV2xkR1NtOVpNbU01VUZFOVBRPT0=")))))))), false);
				if (valueBool)
				{
					this.pathFolderAvatar = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNRnBGV2tOaFIxSklZVVZLYTJKVldYZFhWbWhLVUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					bool flag4 = this.pathFolderAvatar == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag4)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOaGJVWlFVbnBrY1ZaNlVtNWxSWEJKVWpOT1VGSjZaSFZXZWxaMVUxVmtWV0ZJVm5oa1NGWktVakZ3TWxsclpGTmlSMDV3VVcxd2FGUXdZek5qVm1SR1dqRnNXVmR0YUd0U01GbzFVMVpGT1ZCUlBUMD0="))))))))), 2);
						return;
					}
					bool flag5 = Directory.GetFiles(this.pathFolderAvatar).Length == 0;
					if (flag5)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOTlIwWk9WRE5HYVZVd1NtOWxhMnh6WkZkR1JGRnRhR3RpVlZsM1YxWm9TbUZCUFQwPQ=="))))))))), 2);
						return;
					}
					this.lstPathFolderAvatar = Directory.GetFiles(this.pathFolderAvatar).ToList<string>();
					this.lstPathFolderAvatarTemp = this.CloneList(this.lstPathFolderAvatar);
				}
				bool flag6 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldVbTVXYUZKVmNIZFhWa1U1VUZFOVBRPT0=")))))))), false) && this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkV2JVNUdWRzVhYTJKV1dqVT0=")))))))), 0) == 0;
				if (flag6)
				{
					this.pathFolderCover = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNRnBGV2tOaFIxSklZVVZTYVUweGNITlpNbU01VUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					bool flag7 = this.pathFolderCover == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag7)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOaGJVWlFVbnBrY1ZaNlVtNWxSWEJKVWpOT1VGSjZaSFZXZWxaMVUxVmtWV0ZJVm5oa1NGWktVakZ3TWxsclpGTmlSMDV3VVcxd2FGUXdZek5qVm1SR1ducFNhV05YY0dsaVYyUnVWMWhPVUdNeGJGUlNWREE5"))))))))), 2);
						return;
					}
					bool flag8 = Directory.GetFiles(this.pathFolderCover).Length == 0;
					if (flag8)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOTlIwWk9WRE5HYVZVd1NtOWxhMnh6WkZkR1JGRnRiR2haTTJ4Q1YxWk9SbEJSUFQwPQ=="))))))))), 2);
						return;
					}
					this.lstPathFolderCover = Directory.GetFiles(this.pathFolderCover).ToList<string>();
					this.lstPathFolderCoverTemp = this.CloneList(this.lstPathFolderCover);
				}
				bool valueBool2 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUZOaU1YQllUVlUxYVUxV1NtOD0=")))))))), false);
				if (valueBool2)
				{
					bool flag9 = Directory.GetFiles(this.pathFolderTieuSu).Length == 0;
					if (flag9)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOTlIwWk9WRE5HYVZVd1NYZFpWMDVRWTFod1NtSkVSa3BUUmtKSVl6QXhOVk5yYkZKUVZEQTk="))))))))), 2);
						return;
					}
					this.lstPathFileTieuSu = Directory.GetFiles(this.pathFolderTieuSu).ToList<string>();
					this.lstPathFileTieuSuTemp = this.CloneList(this.lstPathFileTieuSu);
				}
				bool valueBool3 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEU5aFIwNUdUbGM1V2xkR1NsWlpWV00xWkZadmVGVnVRbWxhZWpBNQ==")))))))), false);
				if (valueBool3)
				{
					this.lstNoiLamViec = File.ReadAllLines(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJDYUZKNmJERlhhazVUWTBkS2RGUnRhR2xpVjJodldXMTRORlF5U1hsaVJURmFWbnBHV0ZsV1pGZGhhM2gxVldwU2ExRlVNRGs9"))))))))).ToList<string>();
					this.lstQueQuan = File.ReadAllLines(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJDYUZKNmJERlhhazVUWTBkS2RGUnRhR2xpVjJodldXMTRORlZ0VWxoV2JFcHJWakJhTVZSSE5WTk9SMUpDVUZRd1BRPT0="))))))))).ToList<string>();
					this.lstThanhPho = File.ReadAllLines(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJDYUZKNmJERlhhazVUWTBkS2RGUnRhR2xpVjJodldXMTRORlpYUmtoU2JsWm9VbXRLZGxsdWF6Rk5SMVpKVlZRd1BRPT0="))))))))).ToList<string>();
					this.lstTruongDH = File.ReadAllLines(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJDYUZKNmJERlhhazVUWTBkS2RGUnRhR2xpVjJodldXMTRORlpYVG5WV2JscHBZbGRTUmxVd1RURk5SMVpKVlZRd1BRPT0="))))))))).ToList<string>();
					this.lstTruongTHPT = File.ReadAllLines(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJDYUZKNmJERlhhazVUWTBkS2RGUnRhR2xpVjJodldXMTRORlpYVG5WV2JscHBZbGRTVmxVd1drTldWWGgxVldwU2ExRlVNRGs9"))))))))).ToList<string>();
					this.lstNoiLamViec = Common.RemoveEmptyItems(this.lstNoiLamViec);
					this.lstNoiLamViecTemp = Common.CloneList(this.lstNoiLamViec);
					this.lstQueQuan = Common.RemoveEmptyItems(this.lstQueQuan);
					this.lstQueQuanTemp = Common.CloneList(this.lstQueQuan);
					this.lstThanhPho = Common.RemoveEmptyItems(this.lstThanhPho);
					this.lstThanhPhoTemp = Common.CloneList(this.lstThanhPho);
					this.lstTruongDH = Common.RemoveEmptyItems(this.lstTruongDH);
					this.lstTruongDHTemp = Common.CloneList(this.lstTruongDH);
					this.lstTruongTHPT = Common.RemoveEmptyItems(this.lstTruongTHPT);
					this.lstTruongTHPTTemp = Common.CloneList(this.lstTruongTHPT);
				}
				bool valueBool4 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWlhWVzE0YVZwNk1Eaz0=")))))))), false);
				if (valueBool4)
				{
					bool flag10 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkU1ZteFpWV3hXWVZaNlVUaz0=")))))))), 0) == 0;
					if (flag10)
					{
						this.lstHo = File.ReadAllLines(this.pathFileHo).ToList<string>();
						this.lstHo = Common.RemoveEmptyItems(this.lstHo);
						bool flag11 = this.lstHo.Count == 0;
						if (flag11)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV2hUWWpOak1tTklVa3BTVjJneVpXdDBUbUZCUFQwPQ=="))))))))), 2);
							return;
						}
						this.lstTen = File.ReadAllLines(this.pathFileTen).ToList<string>();
						this.lstTen = Common.RemoveEmptyItems(this.lstTen);
						bool flag12 = this.lstTen.Count == 0;
						if (flag12)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV2hUWWpOak1tTklVa3BTYkZKRlkxY3dNR0ZCUFQwPQ=="))))))))), 2);
							return;
						}
						this.lstTenDem = File.ReadAllLines(this.pathFileTenDem).ToList<string>();
						this.lstTenDem = Common.RemoveEmptyItems(this.lstTenDem);
					}
					else
					{
						bool flag13 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkV1ZuQllUbFpPV2xaNlZuSlpha2wzVUZFOVBRPT0=")))))))), 0) == 0;
						if (flag13)
						{
							this.lstHo = SetupFolder.GetListHoVN();
							this.lstTenDem = SetupFolder.GetListTenDemVN();
							this.lstTen = SetupFolder.GetListTenVN();
						}
						else
						{
							this.lstHo = SetupFolder.GetListHoEN();
							this.lstTenDem = new List<string>();
							this.lstTen = SetupFolder.GetListTenEN();
						}
					}
				}
				bool valueBool5 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWlhVVzFvYWswd01Eaz0=")))))))), false);
				if (valueBool5)
				{
					bool flag14 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkU1YwbDVZa1pHV2xkRk5UWT0=")))))))), 0) == 0;
					if (flag14)
					{
						this.lstPassword = Common.RemoveEmptyItems(File.ReadAllLines(this.pathFileMatKhau).ToList<string>());
						bool flag15 = this.lstPassword.Count == 0;
						if (flag15)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV2hUWWpOak1tTklVa3BTVkU1RllqTk9OV0Z0VWtSUmJrcG9WRlU1Y0dWcmJITk5WV3hTVUZRd1BRPT0="))))))))), 2);
							return;
						}
					}
				}
				int num = 0;
				for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
				{
					bool flag16 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
					if (flag16)
					{
						num++;
					}
				}
				bool valueBool6 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVlZqQmFkMWxyUlRsUVVUMDk=")))))))), false);
				if (valueBool6)
				{
					bool flag17 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa2IySkhTbFpOVjJob1ZqTmpPUT09")))))))), 0) == 1;
					if (flag17)
					{
						this.lstMailAdd = File.ReadAllLines(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWRvWVZJeFNqQlhWbVJ6WXpGb1NHRklXbXRTZWtadldWWmtNMlJYVWtsaFJFRTk="))))))))).ToList<string>();
						this.lstMailAdd = Common.RemoveEmptyItems(this.lstMailAdd);
						bool flag18 = this.lstMailAdd.Count < num && !this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYmtKcFVteHdkMWt3UlRsUVVUMDk=")))))))), false);
						if (flag18)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NYZFpWVEZRWTFkS1ZGRnVVbHBXTW5oNlUxVmtVV0ZJVm5oYVNGWktVakJhY2xkclRrWlFVVDA5"))))))))), 3);
							return;
						}
					}
				}
				bool flag19 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUdGaVIwNTBZa2N4YkZWVU1Eaz0=")))))))), false) && this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkVWJHeFlZa2hOUFE9PQ==")))))))), 0) == 0;
				if (flag19)
				{
					this.lstMailVerify = File.ReadAllLines(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJLWVZkRmNIZFhiVFZ6V1RKR1NFOVVRbWxXTUZwM1dXdE5NVTFIVmtsVlZEQTk="))))))))).ToList<string>();
					this.lstMailVerify = Common.RemoveEmptyItems(this.lstMailVerify);
					bool flag20 = this.lstMailVerify.Count < num;
					if (flag20)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NYZFpWVEZRWTFkS1ZGRnVVbHBXTW5oNlUxVmtVV0ZJVm5oYVNGWktVakJhY2xkclRrWlFVVDA5"))))))))), 3);
						return;
					}
				}
				for (int j = 0; j < maxThread; j++)
				{
					this.lstPossition.Add(0);
				}
				switch (this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0))
				{
				case 7:
				{
					this.listApiTinsoft = this.GetListKeyTinsoft();
					bool flag21 = this.listApiTinsoft.Count == 0;
					if (flag21)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWb1MyUnRWa2xoTW1SWFVqSjRNVmw2U1RWaVYxSkVVVzVLYUZSVk9IZFpiVEZxV2pOb1MxTkhhREZPYlU1NlUxVm9ZVTFYUmxSUmJrNHpUakJ3TVZkdWJFTmtSMUpZVWxka2ExSXljRVZqVnpCM1lVRTlQUT09"))))))))), 2);
						return;
					}
					this.listTinsoft = new List<TinsoftProxy>();
					for (int k = 0; k < this.listApiTinsoft.Count; k++)
					{
						TinsoftProxy item = new TinsoftProxy(this.listApiTinsoft[k], this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWVzVDYVdKck5USlhiVFZTVUZFOVBRPT0=")))))))), 0), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldVa2hQVjNCYVYwWktkMWxxU1RGV1YwWllUbGh3YVUxc2IzYz0=")))))))), 0));
						this.listTinsoft.Add(item);
					}
					bool flag22 = this.listApiTinsoft.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWVzVDYVdKck5USlhiVFZTVUZFOVBRPT0=")))))))), 0) < maxThread;
					if (flag22)
					{
						maxThread = this.listApiTinsoft.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWVzVDYVdKck5USlhiVFZTVUZFOVBRPT0=")))))))), 0);
					}
					break;
				}
				case 8:
				{
					this.listProxyXproxy = this.setting_general.GetValueList(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0hCclVtdEtOVmxxVG05T1VUMDk=")))))))), 0);
					bool flag23 = this.listProxyXproxy.Count == 0;
					if (flag23)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpCYVEyVlhTWHBoUkZaS1VqTlNkbVI2WkZOa1ZuQTFVa1ZXY2xwVll6TmpTR3d6V2pKU2RWWnVRa3BTTTNCRll6SXdNV0pyYkVoTlZFWmFWVEJKZDFsVk1WQmpWMHBVVWxRd1BRPT0="))))))))), 2);
						return;
					}
					this.listxProxy = new List<XproxyProxy>();
					for (int l = 0; l < this.listProxyXproxy.Count; l++)
					{
						XproxyProxy item2 = new XproxyProxy(this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWWGxXYm14cllsZDRjVmRzV2xkVk1WSkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))), this.listProxyXproxy[l], this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRSYm14cFRUSm5NUT09")))))))), 0), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), 0));
						this.listxProxy.Add(item2);
					}
					bool flag24 = this.listProxyXproxy.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), 0) < maxThread;
					if (flag24)
					{
						maxThread = this.listProxyXproxy.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), 0);
					}
					break;
				}
				case 10:
				{
					this.listProxyTMProxy = this.setting_general.GetValueList(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKVVRXeFpNVlpyVlhoVlYwNTBUMVJTYkZWVU1Eaz0=")))))))), 0);
					bool flag25 = this.listProxyTMProxy.Count == 0;
					if (flag25)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10VmVGVlhUblJQVkZKc1ZUQktlVmxWTVZCTlIwcDBXVEprTkZOcmFHOWtWRnBxWXpCc1NWZHFSbWhWTUVwNlpIcGtTMlJXY0RWUmJsSnJWakJXYmxwRlpIRlNTRVowVFVkblBRPT0="))))))))), 2);
						return;
					}
					this.listTMProxy = new List<TMProxy>();
					for (int m = 0; m < this.listProxyTMProxy.Count; m++)
					{
						TMProxy item3 = new TMProxy(this.listProxyTMProxy[m], 0, this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWV3MxVmxORmNESmFWV2h5VUZFOVBRPT0=")))))))), 0));
						this.listTMProxy.Add(item3);
					}
					bool flag26 = this.listProxyTMProxy.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWV3MxVmxORmNESmFWV2h5VUZFOVBRPT0=")))))))), 0) < maxThread;
					if (flag26)
					{
						maxThread = this.listProxyTMProxy.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWV3MxVmxORmNESmFWV2h5VUZFOVBRPT0=")))))))), 0);
					}
					break;
				}
				case 11:
				{
					this.listProxyProxyv6 = this.setting_general.GetValueList(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0hCclVtdEtOVmxxVG05T1YxSnhWMVF3UFE9PQ==")))))))), 0);
					bool flag27 = this.listProxyProxyv6.Count == 0;
					if (flag27)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWb1MyUnRWa2xoTW1Sb1RXMXdSV1JGWXpGaWEyeE9WVEZKTUZsdVZuVlVSVTVEVFcxU1dHRXlaR2xVVlRrMVdXMHhhbG94YTNKU2VscDNWMFpXYmxsVk1WQmpNa3AwV2pKa2FWUXdZekppTVdSeVlVRTlQUT09"))))))))), 2);
						return;
					}
					this.listProxyWeb = new List<ProxyWeb>();
					for (int n = 0; n < this.listProxyProxyv6.Count; n++)
					{
						bool flag28 = false;
						bool flag29 = !flag28;
						if (flag29)
						{
							ProxyWeb item4 = new ProxyWeb(this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKV1UwVndNbHBWYUhOTmF6VnVVRlF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))), this.listProxyProxyv6[n], 0, this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhVVzVzYVUweVp6RmFSM0JhVUZFOVBRPT0=")))))))), 0));
							this.listProxyWeb.Add(item4);
						}
					}
					bool flag30 = this.listProxyProxyv6.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhVVzVzYVUweVp6RmFSM0JhVUZFOVBRPT0=")))))))), 0) < maxThread;
					if (flag30)
					{
						maxThread = this.listProxyProxyv6.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhVVzVzYVUweVp6RmFSM0JhVUZFOVBRPT0=")))))))), 0);
					}
					break;
				}
				case 12:
				{
					this.listProxyShopLike = this.setting_general.GetValueList(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKV1RXMW9NbGt3VmpSalIwVjVWbFF3UFE9PQ==")))))))), 0);
					bool flag31 = this.listProxyShopLike.Count == 0;
					if (flag31)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10VmVGVlhUblJQVkZKc1ZUQktlVmxWTVZCTlIwcDBXVEprTkZOcmFHOWtWRnBxWXpCc1NWZHFSbWhWTUVwNlpIcGtTMlJXY0RWUmJsSnJWakJXYmxwRlpIRlNTRVowVFVkblBRPT0="))))))))), 2);
						return;
					}
					this.listShopLike = new List<ShopLike>();
					for (int num2 = 0; num2 < this.listProxyShopLike.Count; num2++)
					{
						ShopLike item5 = new ShopLike(this.listProxyShopLike[num2], 0, this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWRzA1YVUwd1NrNVpWbVF3WWtFOVBRPT0=")))))))), 0));
						this.listShopLike.Add(item5);
					}
					bool flag32 = this.listProxyShopLike.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWRzA1YVUwd1NrNVpWbVF3WWtFOVBRPT0=")))))))), 0) < maxThread;
					if (flag32)
					{
						maxThread = this.listProxyShopLike.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWRzA1YVUwd1NrNVpWbVF3WWtFOVBRPT0=")))))))), 0);
					}
					break;
				}
				case 13:
				{
					this.listProxyMinProxy = this.setting_general.GetValueList(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKVVRXeFpNVlpHWkhOa1ZsWkpVMjVhYkZOSGN6az0=")))))))), 0);
					bool flag33 = this.listProxyMinProxy.Count == 0;
					if (flag33)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaa2MyUldWa2xUYmxwc1UwZDBibGxVU25GU1NGSklUbGMxU2xSV1RsTk9SMG94WW10NFJGRnFTbXRXTW5SdVdXc3hVR1ZYU25SWk1tUnBWMFphYjFOVmFGTmlNMk15WTBoU1NsVlVNRGs9"))))))))), 2);
						return;
					}
					this.listMinProxy = new List<MinProxy>();
					for (int num3 = 0; num3 < this.listProxyMinProxy.Count; num3++)
					{
						MinProxy item6 = new MinProxy(this.listProxyMinProxy[num3], 0, this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkdUVmhDYVdKRlNqVlphazV2VGxFOVBRPT0=")))))))), 0));
						this.listMinProxy.Add(item6);
					}
					bool flag34 = this.listProxyMinProxy.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkdUVmhDYVdKRlNqVlphazV2VGxFOVBRPT0=")))))))), 0) < maxThread;
					if (flag34)
					{
						maxThread = this.listProxyMinProxy.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkdUVmhDYVdKRlNqVlphazV2VGxFOVBRPT0=")))))))), 0);
					}
					break;
				}
				}
				this.rControl(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1UyRkhUblZWVkRBOQ==")))))))));
				fChange.isAdd = true;
				this.isStop = false;
				int curChangeIp = 0;
				bool isChangeIPSuccess = false;
				int checkDelayChrome = 0;
				this.lstThread = new List<Thread>();
				new Thread(delegate()
				{
					try
					{
						bool flag35 = this.setting_general.GetValueInt("ip_iTypeChangeIp", 0) == 8 && this.setting_general.GetValueInt("typeRunXproxy", 0) == 1;
						if (flag35)
						{
							for (int num4 = 0; num4 < this.listxProxy.Count; num4++)
							{
								this.listxProxy[num4].ResetProxy();
							}
						}
						int num5 = 0;
						while (num5 < this.dtgvAcc.Rows.Count)
						{
							bool flag36 = this.isStop;
							if (flag36)
							{
								break;
							}
							bool flag37 = Convert.ToBoolean(this.dtgvAcc.Rows[num5].Cells["cChose"].Value);
							if (flag37)
							{
								bool flag38 = this.lstThread.Count < maxThread;
								if (flag38)
								{
									bool flag39 = this.isStop;
									if (flag39)
									{
										break;
									}
									int row = num5++;
									int checkDelayChrome;
									bool flag40 = checkDelayChrome > 0;
									if (flag40)
									{
										Common.DelayTime((double)this.setting_general.GetValueInt("nudDelayOpenChrome", 1));
									}
									checkDelayChrome = checkDelayChrome;
									checkDelayChrome++;
									Thread thread = new Thread(delegate()
									{
										try
										{
											int indexOfPossitionApp = Common.GetIndexOfPossitionApp(ref this.lstPossition);
											this.ExcuteOneThread(row, indexOfPossitionApp);
											Common.FillIndexPossition(ref this.lstPossition, indexOfPossitionApp);
											DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, row, "cChose", false);
										}
										catch (Exception ex3)
										{
											Common.ExportError(null, ex3, "");
										}
									});
									this.lstThread.Add(thread);
									thread.Start();
								}
								else
								{
									bool flag41 = this.setting_general.GetValueInt("ip_iTypeChangeIp", 0) != 0 && this.setting_general.GetValueInt("ip_iTypeChangeIp", 0) != 7 && this.setting_general.GetValueInt("ip_iTypeChangeIp", 0) != 8 && this.setting_general.GetValueInt("ip_iTypeChangeIp", 0) != 9 && this.setting_general.GetValueInt("ip_iTypeChangeIp", 0) != 10 && this.setting_general.GetValueInt("ip_iTypeChangeIp", 0) != 11 && this.setting_general.GetValueInt("ip_iTypeChangeIp", 0) != 12 && this.setting_general.GetValueInt("ip_iTypeChangeIp", 0) != 13;
									if (flag41)
									{
										for (int num6 = 0; num6 < this.lstThread.Count; num6++)
										{
											this.lstThread[num6].Join();
											this.lstThread.RemoveAt(num6--);
										}
										bool flag42 = this.isStop;
										if (flag42)
										{
											break;
										}
										Interlocked.Increment(ref curChangeIp);
										bool flag43 = curChangeIp >= Convert.ToInt32((this.setting_general.GetValue("ip_nudChangeIpCount", "") == "") ? "1" : this.setting_general.GetValue("ip_nudChangeIpCount", ""));
										if (flag43)
										{
											bool isChangeIPSuccess;
											for (int num7 = 0; num7 < 3; num7++)
											{
												isChangeIPSuccess = Common.ChangeIP(this.setting_general.GetValueInt("ip_iTypeChangeIp", 0), this.setting_general.GetValueInt("typeDcom", 0), this.setting_general.GetValue("ip_txtProfileNameDcom", ""), this.setting_general.GetValue("txtUrlHilink", ""), this.setting_general.GetValueInt("ip_cbbHostpot", 0), this.setting_general.GetValue("ip_txtNordVPN", ""));
												isChangeIPSuccess = isChangeIPSuccess;
												if (isChangeIPSuccess)
												{
													break;
												}
											}
											bool flag44 = !isChangeIPSuccess;
											if (flag44)
											{
												MessageBoxHelper.ShowMessageBox(Language.GetValue("Không thể đổi ip!"), 1);
												goto IL_53E;
											}
											curChangeIp = 0;
										}
									}
									else
									{
										for (int num8 = 0; num8 < this.lstThread.Count; num8++)
										{
											bool flag45 = !this.lstThread[num8].IsAlive;
											if (flag45)
											{
												this.lstThread.RemoveAt(num8--);
											}
										}
									}
								}
							}
							else
							{
								num5++;
							}
							bool flag46 = this.isStop;
							if (flag46)
							{
								break;
							}
						}
						for (int num9 = 0; num9 < this.lstThread.Count; num9++)
						{
							this.lstThread[num9].Join();
						}
					}
					catch (Exception ex2)
					{
						Common.ExportError(null, ex2, "");
					}
					IL_53E:
					this.rControl("stop");
					bool valueBool7 = this.settings.GetValueBool("ckbAddMail", false);
					if (valueBool7)
					{
						bool flag47 = this.settings.GetValueInt("themMail", 0) == 1 && !this.settings.GetValueBool("ckbMailVip", false);
						if (flag47)
						{
							File.WriteAllLines("configschange\\addmail\\hotmail.txt", this.lstMailAdd);
						}
						Common.CreateFolder("configschange\\addmail");
						File.WriteAllLines("configschange\\addmail\\MailLoi.txt", this.lstMailLoi);
					}
					bool valueBool8 = this.settings.GetValueBool("change_ckbVerify", false);
					if (valueBool8)
					{
						Common.CreateFolder("configschange\\verify");
						File.WriteAllLines("configschange\\verify\\hotmail.txt", this.lstMailVerify);
					}
				}).Start();
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x001A43E8 File Offset: 0x001A25E8
		private int CheckStatusChrome(Chrome chrome)
		{
			int result = 0;
			try
			{
				bool flag = chrome.CheckChromeClosed();
				if (flag)
				{
					result = 2;
				}
				else
				{
					bool flag2 = CommonChrome.IsCheckpoint(chrome);
					if (flag2)
					{
						result = 3;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x001A4464 File Offset: 0x001A2664
		public static int ChangeNgaySinh(Chrome chrome, int ngay, int thang, int nam)
		{
			bool flag = false;
			try
			{
				chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhlR0ZTTW5kM1dUQm9TMlJzY0hSaVNFNWhWWHBXTTFsVmFFSk1NbEpKWWtoa1lWWkVSbkJYVm1oUFkwWnNOVmR0ZUdGU01uZDNWVVprUzJOSFRuVlZiVGxoVWpCWk1RPT0=")))))))));
				chrome.DelayTime(3.0);
				bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MyUnRTWHBWVjJSUllWVktjbGxXYUZwYU1VSndVVzB4YVUwd2NEQlRWVkV3V2pKU1NGSnRiR2xTTVZadVZVZHNRMDFHYkhSUFYzUnNWVEJGY2xOVmFGTmxWVGwwVGxSQ2FGRjZSbkZaVldSell6RndSRm96YkV4Vk1FVnlVMVZvVTJFd2JFVk9SMlJoVWpKM2VRPT0=")))))))), 5.0) != 1;
				if (flag2)
				{
					chrome.Select(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwNVJQVDA9")))))))), ngay.ToString());
					chrome.DelayTime(1.0);
					chrome.Select(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4ak5XUlhVa2hhZWpBOQ==")))))))), thang.ToString());
					chrome.DelayTime(0.5);
					chrome.Select(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xaa1YyRkhUbTVRVkRBOQ==")))))))), nam.ToString());
					chrome.DelayTime(0.5);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(2.0);
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVndkMWt5TlZOaU1YQklVbXBXV1Uxck5USlpiVEZoWTBkT2RFMVhhR3RTTW5neVdXMXNTMXBCUFQwPQ==")))))))), 5.0) == 1;
					if (flag3)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVndkMWt5TlZOaU1YQklVbXBXV1Uxck5USlpiVEZoWTBkT2RFMVhhR3RTTW5neVdXMXNTMXBCUFQwPQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
					}
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(1.0);
					bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFVVzVzYVUxc2NIZFphMlJXWkVacmVWSnViR0ZSZWtaMlYyeGtSMkV4Y0ZsVFYyeFpWVlF3T1E9PQ==")))))))), 10.0) == 1;
					if (flag4)
					{
						flag = true;
					}
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x001A4A28 File Offset: 0x001A2C28
		private void LoadStatusDatagridView(int row, string status)
		{
			DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), status);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x001A4A28 File Offset: 0x001A2C28
		public void SetStatusAccount(int indexRow, string value)
		{
			DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), value);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x001A4A98 File Offset: 0x001A2C98
		public void SetInfoAccount(string id, int indexRow, string value)
		{
			DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ==")))))))), value);
			CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1XSlhTak5RVkRBOQ==")))))))), value);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x001A4B60 File Offset: 0x001A2D60
		private void ExcuteOneThread(object data, int indexPos)
		{
			int num = 0;
			int num2 = 0;
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			int num3 = (int)data;
			Chrome chrome = null;
			string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9")))))))));
			string text2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ==")))))))));
			string text3 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09")))))))));
			string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09")))))))));
			string text4 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ==")))))))));
			string text5 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk=")))))))));
			bool flag = text2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				text2 = Regex.Match(statusDataGridView2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Groups[1].Value;
			}
			TinsoftProxy tinsoftProxy = null;
			XproxyProxy xproxyProxy = null;
			TMProxy tmproxy = null;
			ProxyWeb proxyWeb = null;
			ShopLike shopLike = null;
			MinProxy minProxy = null;
			string text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			int typeProxy = 0;
			string text7 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			for (;;)
			{
				bool flag2 = this.isStop;
				if (flag2)
				{
					break;
				}
				switch (this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0))
				{
				case 7:
				{
					this.LoadStatusDatagridView(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZEQmpNbU5HYUhKYU1rNUpVMjVhYkZOSGRHNVdhMlJ6WkZkTmVVOVhNV3RSZWxJeFZFZGpPVkJSUFQwPQ=="))))))))));
					object obj = this.lock_StartProxy;
					lock (obj)
					{
						for (;;)
						{
							bool flag4 = this.isStop;
							if (flag4)
							{
								break;
							}
							tinsoftProxy = null;
							do
							{
								bool flag5 = this.isStop;
								if (flag5)
								{
									break;
								}
								foreach (TinsoftProxy tinsoftProxy2 in this.listTinsoft)
								{
									bool flag6 = tinsoftProxy == null || tinsoftProxy2.daSuDung < tinsoftProxy.daSuDung;
									if (flag6)
									{
										tinsoftProxy = tinsoftProxy2;
									}
								}
							}
							while (tinsoftProxy.daSuDung == tinsoftProxy.limit_theads_use);
							IL_61B:
							bool flag7 = this.isStop;
							if (flag7)
							{
								break;
							}
							bool flag8 = tinsoftProxy.daSuDung > 0 || tinsoftProxy.ChangeProxy();
							if (flag8)
							{
								goto Block_54;
							}
							continue;
							goto IL_61B;
						}
						goto IL_70E;
						Block_54:
						text = tinsoftProxy.proxy;
						bool flag9 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag9)
						{
							text = tinsoftProxy.GetProxy();
						}
						TinsoftProxy tinsoftProxy3 = tinsoftProxy;
						TinsoftProxy tinsoftProxy4 = tinsoftProxy3;
						int num4 = tinsoftProxy3.dangSuDung;
						tinsoftProxy4.dangSuDung = num4 + 1;
						tinsoftProxy3 = tinsoftProxy;
						TinsoftProxy tinsoftProxy5 = tinsoftProxy3;
						num4 = tinsoftProxy3.daSuDung;
						tinsoftProxy5.daSuDung = num4 + 1;
						IL_70E:
						bool flag10 = this.isStop;
						if (flag10)
						{
							this.LoadStatusDatagridView(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
							num = 1;
							goto IL_C1FE;
						}
						bool flag11 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0) > 0;
						if (flag11)
						{
							DatagridviewHelper.SetStatusDataGridViewWithWait(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0), text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1YyTXhiRmxoTW1SYVZqRnZkMWRzYUVwYU1XdDVZVWRvYVdKWFVuTlRWV1J6WkRCc1NXUkVRbWhXZWtaeldteG9UbVJWZUhCT1JEQTk=")))))))));
						}
						bool flag12 = true;
						bool flag13 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
						if (flag13)
						{
							text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text.Split(new char[]
							{
								':'
							})[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
							this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZtdEdNVlJIYXpCUVVUMDk=")))))))));
							text7 = Common.CheckProxyNew(text, 0, 30);
							bool flag14 = text7 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag14)
							{
								flag12 = false;
							}
						}
						bool flag15 = !flag12;
						if (flag15)
						{
							tinsoftProxy3 = tinsoftProxy;
							TinsoftProxy tinsoftProxy6 = tinsoftProxy3;
							num4 = tinsoftProxy3.dangSuDung;
							tinsoftProxy6.dangSuDung = num4 - 1;
							tinsoftProxy3 = tinsoftProxy;
							TinsoftProxy tinsoftProxy7 = tinsoftProxy3;
							num4 = tinsoftProxy3.daSuDung;
							tinsoftProxy7.daSuDung = num4 - 1;
							continue;
						}
					}
					break;
				}
				case 8:
				{
					this.LoadStatusDatagridView(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZEQmpNbU5HYUhKYU1WWkpVMjVhYkZOSGRERlVSMnN3VUZFOVBRPT0="))))))))));
					object obj2 = this.lock_StartProxy;
					lock (obj2)
					{
						bool flag17 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRUYWtacFlrZG9NMWt5TURWT1IxWlNVRlF3UFE9PQ==")))))))), 0) == 0;
						if (flag17)
						{
							for (;;)
							{
								bool flag18 = this.isStop;
								if (flag18)
								{
									break;
								}
								xproxyProxy = null;
								do
								{
									bool flag19 = this.isStop;
									if (flag19)
									{
										break;
									}
									foreach (XproxyProxy xproxyProxy2 in this.listxProxy)
									{
										bool flag20 = xproxyProxy2.isProxyLive && (xproxyProxy == null || xproxyProxy2.daSuDung < xproxyProxy.daSuDung);
										if (flag20)
										{
											xproxyProxy = xproxyProxy2;
										}
									}
								}
								while (xproxyProxy.daSuDung == xproxyProxy.limit_theads_use);
								IL_D10:
								bool flag21 = this.isStop;
								if (flag21)
								{
									break;
								}
								bool flag22 = xproxyProxy.isProxyLive && (xproxyProxy.daSuDung > 0 || xproxyProxy.ChangeProxy());
								if (flag22)
								{
									goto Block_75;
								}
								xproxyProxy.isProxyLive = false;
								continue;
								goto IL_D10;
							}
							goto IL_DD4;
							Block_75:
							text = xproxyProxy.proxy;
							typeProxy = xproxyProxy.typeProxy;
							XproxyProxy xproxyProxy3 = xproxyProxy;
							XproxyProxy xproxyProxy4 = xproxyProxy3;
							int num4 = xproxyProxy3.dangSuDung;
							xproxyProxy4.dangSuDung = num4 + 1;
							xproxyProxy3 = xproxyProxy;
							XproxyProxy xproxyProxy5 = xproxyProxy3;
							num4 = xproxyProxy3.daSuDung;
							xproxyProxy5.daSuDung = num4 + 1;
							IL_DD4:;
						}
						else
						{
							int num4;
							for (;;)
							{
								bool flag23 = this.isStop;
								if (flag23)
								{
									break;
								}
								xproxyProxy = null;
								List<XproxyProxy> list = new List<XproxyProxy>();
								foreach (XproxyProxy xproxyProxy6 in this.listxProxy)
								{
									bool flag24 = !xproxyProxy6.isProxyLive;
									if (!flag24)
									{
										bool flag25 = xproxyProxy6.daSuDung < xproxyProxy6.limit_theads_use;
										if (flag25)
										{
											list.Add(xproxyProxy6);
										}
										else
										{
											bool flag26 = xproxyProxy6.dangSuDung == 0;
											if (flag26)
											{
												xproxyProxy6.ResetProxy();
												xproxyProxy6.daSuDung = 0;
											}
										}
									}
								}
								for (int i = 0; i < list.Count; i = num4 + 1)
								{
									bool flag27 = list[i].CheckLiveProxy(0);
									if (flag27)
									{
										xproxyProxy = list[i];
										break;
									}
									num4 = i;
								}
								bool flag28 = xproxyProxy != null;
								if (flag28)
								{
									goto Block_79;
								}
							}
							goto IL_F80;
							Block_79:
							text = xproxyProxy.proxy;
							typeProxy = xproxyProxy.typeProxy;
							XproxyProxy xproxyProxy3 = xproxyProxy;
							XproxyProxy xproxyProxy7 = xproxyProxy3;
							num4 = xproxyProxy3.dangSuDung;
							xproxyProxy7.dangSuDung = num4 + 1;
							xproxyProxy3 = xproxyProxy;
							XproxyProxy xproxyProxy8 = xproxyProxy3;
							num4 = xproxyProxy3.daSuDung;
							xproxyProxy8.daSuDung = num4 + 1;
							IL_F80:;
						}
						bool flag29 = this.isStop;
						if (flag29)
						{
							this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
							goto IL_C1FE;
						}
						bool flag30 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0) > 0;
						if (flag30)
						{
							DatagridviewHelper.SetStatusDataGridViewWithWait(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0), text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1YyTXhiRmxoTW1SYVZqRnZkMWRzYUVwYU1XdDVZVWRvYVdKWFVuTlRWV1J6WkRCc1NXUkVRbWhXZWtaeldteG9UbVJWZUhCT1JEQTk=")))))))));
						}
						bool flag31 = true;
						bool flag32 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
						if (flag32)
						{
							text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
							this.SetStatusAccount(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZtdEdNVlJIYXpCUVVUMDk=")))))))));
							text7 = Common.CheckProxyNew(text, typeProxy, this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWRmRzYUU5aVIxSkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), 1) * 60);
							bool flag33 = text7 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag33)
							{
								xproxyProxy.isProxyLive = false;
								flag31 = false;
							}
						}
						bool flag34 = !flag31;
						if (flag34)
						{
							XproxyProxy xproxyProxy3 = xproxyProxy;
							XproxyProxy xproxyProxy9 = xproxyProxy3;
							int num4 = xproxyProxy3.dangSuDung;
							xproxyProxy9.dangSuDung = num4 - 1;
							xproxyProxy3 = xproxyProxy;
							XproxyProxy xproxyProxy10 = xproxyProxy3;
							num4 = xproxyProxy3.daSuDung;
							xproxyProxy10.daSuDung = num4 - 1;
							continue;
						}
					}
					break;
				}
				case 9:
					goto IL_1403;
				case 10:
				{
					this.LoadStatusDatagridView(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZEQmpNbU5HYUhKYU1WcEdUVlpHYW1KVWF6QmFWazVDWkZWNGNFNUVNRDA9"))))))))));
					object obj3 = this.lock_StartProxy;
					lock (obj3)
					{
						for (;;)
						{
							bool flag36 = this.isStop;
							if (flag36)
							{
								break;
							}
							tmproxy = null;
							do
							{
								bool flag37 = this.isStop;
								if (flag37)
								{
									break;
								}
								foreach (TMProxy tmproxy2 in this.listTMProxy)
								{
									bool flag38 = tmproxy == null || tmproxy2.daSuDung < tmproxy.daSuDung;
									if (flag38)
									{
										tmproxy = tmproxy2;
									}
								}
							}
							while (tmproxy.daSuDung == tmproxy.limit_theads_use);
							IL_16CA:
							bool flag39 = this.isStop;
							if (flag39)
							{
								break;
							}
							bool flag40 = tmproxy.daSuDung > 0 || tmproxy.ChangeProxy();
							if (flag40)
							{
								goto Block_105;
							}
							continue;
							goto IL_16CA;
						}
						goto IL_17BD;
						Block_105:
						text = tmproxy.proxy;
						bool flag41 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag41)
						{
							text = tmproxy.GetProxy();
						}
						TMProxy tmproxy3 = tmproxy;
						TMProxy tmproxy4 = tmproxy3;
						int num4 = tmproxy3.dangSuDung;
						tmproxy4.dangSuDung = num4 + 1;
						tmproxy3 = tmproxy;
						TMProxy tmproxy5 = tmproxy3;
						num4 = tmproxy3.daSuDung;
						tmproxy5.daSuDung = num4 + 1;
						IL_17BD:
						bool flag42 = this.isStop;
						if (flag42)
						{
							this.LoadStatusDatagridView(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
							num = 1;
							goto IL_C1FE;
						}
						bool flag43 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0) > 0;
						if (flag43)
						{
							DatagridviewHelper.SetStatusDataGridViewWithWait(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0), text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1YyTXhiRmxoTW1SYVZqRnZkMWRzYUVwYU1XdDVZVWRvYVdKWFVuTlRWV1J6WkRCc1NXUkVRbWhXZWtaeldteG9UbVJWZUhCT1JEQTk=")))))))));
						}
						bool flag44 = true;
						bool flag45 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
						if (flag45)
						{
							text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text.Split(new char[]
							{
								':'
							})[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
							this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZtdEdNVlJIYXpCUVVUMDk=")))))))));
							text7 = Common.CheckProxyNew(text, 0, 30);
							bool flag46 = text7 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag46)
							{
								flag44 = false;
							}
						}
						bool flag47 = !flag44;
						if (flag47)
						{
							tmproxy3 = tmproxy;
							TMProxy tmproxy6 = tmproxy3;
							num4 = tmproxy3.dangSuDung;
							tmproxy6.dangSuDung = num4 - 1;
							tmproxy3 = tmproxy;
							TMProxy tmproxy7 = tmproxy3;
							num4 = tmproxy3.daSuDung;
							tmproxy7.daSuDung = num4 - 1;
							continue;
						}
					}
					break;
				}
				case 11:
				{
					this.SetStatusAccount(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZEQmpNbU5HYUhKYU1WWkpVMjVhYkZOSGQzbFViV3N3WkZWNGJsQlVNRDA9"))))))))));
					object obj4 = this.lock_StartProxy;
					lock (obj4)
					{
						for (;;)
						{
							bool flag49 = this.isStop;
							if (flag49)
							{
								break;
							}
							proxyWeb = null;
							do
							{
								bool flag50 = this.isStop;
								if (flag50)
								{
									break;
								}
								foreach (ProxyWeb proxyWeb2 in this.listProxyWeb)
								{
									bool flag51 = proxyWeb == null || proxyWeb2.daSuDung < proxyWeb.daSuDung;
									if (flag51)
									{
										proxyWeb = proxyWeb2;
									}
								}
							}
							while (proxyWeb.daSuDung == proxyWeb.limit_theads_use);
							IL_1D3E:
							bool flag52 = this.isStop;
							if (flag52)
							{
								break;
							}
							bool flag53 = proxyWeb.daSuDung > 0 || proxyWeb.ChangeProxy();
							if (flag53)
							{
								goto Block_125;
							}
							continue;
							goto IL_1D3E;
						}
						goto IL_1DDE;
						Block_125:
						text = proxyWeb.proxy;
						typeProxy = proxyWeb.typeProxy;
						ProxyWeb proxyWeb3 = proxyWeb;
						ProxyWeb proxyWeb4 = proxyWeb3;
						int num4 = proxyWeb3.dangSuDung;
						proxyWeb4.dangSuDung = num4 + 1;
						proxyWeb3 = proxyWeb;
						ProxyWeb proxyWeb5 = proxyWeb3;
						num4 = proxyWeb3.daSuDung;
						proxyWeb5.daSuDung = num4 + 1;
						IL_1DDE:
						bool flag54 = this.isStop;
						if (flag54)
						{
							this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
							num = 1;
							goto IL_C1FE;
						}
						bool flag55 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0) > 0;
						if (flag55)
						{
							DatagridviewHelper.SetStatusDataGridViewWithWait(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0), text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1YyTXhiRmxoTW1SYVZqRnZkMWRzYUVwYU1XdDVZVWRvYVdKWFVuTlRWV1J6WkRCc1NXUkVRbWhXZWtaeldteG9UbVJWZUhCT1JEQTk=")))))))));
						}
						bool flag56 = true;
						bool flag57 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
						if (flag57)
						{
							text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text.Split(new char[]
							{
								':'
							})[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
							this.SetStatusAccount(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZtdEdNVlJIYXpCUVVUMDk=")))))))));
							for (int j = 0; j < 30; j = num4 + 1)
							{
								Common.DelayTime(1.0);
								text7 = Common.CheckProxyNew(text, typeProxy, 30);
								bool flag58 = text7 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								if (flag58)
								{
									break;
								}
								bool flag59 = this.isStop;
								if (flag59)
								{
									this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
									num = 1;
									goto IL_C1FE;
								}
								num4 = j;
							}
							bool flag60 = text7 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag60)
							{
								flag56 = false;
							}
						}
						bool flag61 = !flag56;
						if (flag61)
						{
							proxyWeb3 = proxyWeb;
							ProxyWeb proxyWeb6 = proxyWeb3;
							num4 = proxyWeb3.dangSuDung;
							proxyWeb6.dangSuDung = num4 - 1;
							proxyWeb3 = proxyWeb;
							ProxyWeb proxyWeb7 = proxyWeb3;
							num4 = proxyWeb3.daSuDung;
							proxyWeb7.daSuDung = num4 - 1;
							continue;
						}
					}
					break;
				}
				case 12:
				{
					this.LoadStatusDatagridView(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZEQmpNbU5HYUhKYU1WWkpVMjVhYkZOSGRHNVdWRXB2WkcxT1JtVklRbWhOYkZadVZFZHJNR1JSUFQwPQ=="))))))))));
					object obj5 = this.lock_StartProxy;
					lock (obj5)
					{
						for (;;)
						{
							bool flag63 = this.isStop;
							if (flag63)
							{
								break;
							}
							shopLike = null;
							do
							{
								bool flag64 = this.isStop;
								if (flag64)
								{
									break;
								}
								foreach (ShopLike shopLike2 in this.listShopLike)
								{
									bool flag65 = shopLike == null || shopLike2.daSuDung < shopLike.daSuDung;
									if (flag65)
									{
										shopLike = shopLike2;
									}
								}
							}
							while (shopLike.daSuDung == shopLike.limit_theads_use);
							IL_2471:
							bool flag66 = this.isStop;
							if (flag66)
							{
								break;
							}
							bool flag67 = shopLike.daSuDung > 0 || shopLike.ChangeProxy();
							if (flag67)
							{
								goto Block_146;
							}
							continue;
							goto IL_2471;
						}
						goto IL_2564;
						Block_146:
						text = shopLike.proxy;
						bool flag68 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag68)
						{
							text = shopLike.GetProxy();
						}
						ShopLike shopLike3 = shopLike;
						ShopLike shopLike4 = shopLike3;
						int num4 = shopLike3.dangSuDung;
						shopLike4.dangSuDung = num4 + 1;
						shopLike3 = shopLike;
						ShopLike shopLike5 = shopLike3;
						num4 = shopLike3.daSuDung;
						shopLike5.daSuDung = num4 + 1;
						IL_2564:
						bool flag69 = this.isStop;
						if (flag69)
						{
							this.LoadStatusDatagridView(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
							num = 1;
							goto IL_C1FE;
						}
						bool flag70 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0) > 0;
						if (flag70)
						{
							DatagridviewHelper.SetStatusDataGridViewWithWait(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0), text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1YyTXhiRmxoTW1SYVZqRnZkMWRzYUVwYU1XdDVZVWRvYVdKWFVuTlRWV1J6WkRCc1NXUkVRbWhXZWtaeldteG9UbVJWZUhCT1JEQTk=")))))))));
						}
						bool flag71 = true;
						bool flag72 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
						if (flag72)
						{
							text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text.Split(new char[]
							{
								':'
							})[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
							this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZtdEdNVlJIYXpCUVVUMDk=")))))))));
							text7 = Common.CheckProxyNew(text, 0, 30);
							bool flag73 = text7 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag73)
							{
								flag71 = false;
							}
						}
						bool flag74 = !flag71;
						if (flag74)
						{
							shopLike3 = shopLike;
							ShopLike shopLike6 = shopLike3;
							num4 = shopLike3.dangSuDung;
							shopLike6.dangSuDung = num4 - 1;
							shopLike3 = shopLike;
							ShopLike shopLike7 = shopLike3;
							num4 = shopLike3.daSuDung;
							shopLike7.daSuDung = num4 - 1;
							continue;
						}
					}
					break;
				}
				case 13:
				{
					this.SetStatusAccount(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZEQmpNbU5HYUhKYU1VWlpVVzVDU2xKVVJuZFpiWGhEWlZkSmVtRkVWazFoVkZJeA=="))))))))));
					minProxy = null;
					bool flag75 = false;
					int num5 = 0;
					bool flag76 = this.listMinProxy.Count == 0;
					if (flag76)
					{
						goto Block_12;
					}
					object obj6 = this.lock_StartProxy;
					lock (obj6)
					{
						do
						{
							bool flag78 = this.isStop;
							if (flag78)
							{
								break;
							}
							foreach (MinProxy minProxy2 in this.listMinProxy)
							{
								bool flag79 = minProxy2.dangSuDung == 0;
								if (flag79)
								{
									minProxy = minProxy2;
									break;
								}
								bool flag80 = minProxy == null || minProxy2.daSuDung < minProxy.daSuDung;
								if (flag80)
								{
									minProxy = minProxy2;
								}
							}
						}
						while (minProxy.daSuDung >= minProxy.limit_theads_use);
						bool flag81 = minProxy == null;
						if (flag81)
						{
							goto IL_33CF;
						}
						MinProxy minProxy3 = minProxy;
						MinProxy minProxy4 = minProxy3;
						int num4 = minProxy3.dangSuDung;
						minProxy4.dangSuDung = num4 + 1;
						minProxy3 = minProxy;
						MinProxy minProxy5 = minProxy3;
						num4 = minProxy3.daSuDung;
						minProxy5.daSuDung = num4 + 1;
						num5 = minProxy.daSuDung;
					}
					this.SetStatusAccount(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZEQmpNbU5HYUhKYU1WWkpVMjVhYkZOSGRHNWFSVGxJVGpOR05WRnJTbFpTVjNReFZFZHJNRkJSUFQwPQ=="))))))))));
					bool flag82 = num5 > 1;
					if (flag82)
					{
						while (minProxy.isBlock)
						{
							Common.DelayTime(1.0);
						}
						text = minProxy.GetProxy();
					}
					else
					{
						for (;;)
						{
							switch (minProxy.ChangeProxy())
							{
							case -2:
								goto IL_2CC6;
							case -1:
								goto IL_2D6E;
							case 0:
							{
								this.SetStatusAccount(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZEQmpNbU5HYUhKYU1WWkpVMjVhYkZOSGRHNWFSVGxJVGpOR05WRnJTbFpTVjNNeVUxVldUMko2VW1sa1YxSktVVlF3T1E9PQ==")))))))) + minProxy.next_change.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWb1RsQlJQVDA9"))))))))));
								bool flag83 = minProxy.next_change > 10;
								if (flag83)
								{
									Common.DelayTime(10.0);
								}
								else
								{
									bool flag84 = minProxy.next_change > 0;
									if (flag84)
									{
										Common.DelayTime((double)minProxy.next_change);
									}
								}
								break;
							}
							case 1:
								text = minProxy.proxy;
								minProxy.isBlock = false;
								break;
							}
							bool flag85 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag85)
							{
								goto Block_21;
							}
						}
						IL_2CC6:
						this.SetStatusAccount(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZab1EyTkZiRWhrUnprelRqRktNVmR1YkVWU1YzUnFWSHBhYVdKWFRUaz0="))))))))));
						object obj7 = this.lock_StartProxy;
						lock (obj7)
						{
							this.listMinProxy.Remove(minProxy);
						}
						continue;
						IL_2D6E:
						this.SetStatusAccount(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZab1EyTkZiRWhoYldneFkycHJkMU5WWkhGaFNGWjRVbTVWUFE9PQ=="))))))))));
						object obj8 = this.lock_StartProxy;
						lock (obj8)
						{
							this.listMinProxy.Remove(minProxy);
						}
						continue;
						Block_21:;
					}
					bool flag88 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (!flag88)
					{
						this.SetStatusAccount(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1Sb1RXMDFiMlJVVWs5a1JXeEpWVzVzV2xVd1NqTlpNakExVGtkV1ZFNUlWazFhZWpBNQ=="))))))))));
						bool flag89 = Common.CheckProxyNew(text, 0, 30) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (!flag89)
						{
							flag75 = true;
							bool flag90 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0) > 0;
							if (flag90)
							{
								this.SetStatusAccount(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1YyTXhiRmxoTW1SYVRXMW9jMWRVU25wYU1VNVhVVmhXVFdGVVVUaz0=")))))))));
								Common.DelayTime((double)this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0));
							}
							bool flag91 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
							if (flag91)
							{
								text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text.Split(new char[]
								{
									':'
								})[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
								this.SetStatusAccount(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZtdEdNVlJIYXpCUVVUMDk=")))))))));
								text7 = Common.CheckProxyNew(text, 0, 30);
								bool flag92 = text7 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								if (flag92)
								{
									flag75 = false;
								}
							}
						}
					}
					IL_33CF:
					bool flag93 = !flag75;
					if (flag93)
					{
						object obj9 = this.lock_StartProxy;
						lock (obj9)
						{
							MinProxy minProxy3 = minProxy;
							MinProxy minProxy6 = minProxy3;
							int num4 = minProxy3.dangSuDung;
							minProxy6.dangSuDung = num4 - 1;
							minProxy3 = minProxy;
							MinProxy minProxy7 = minProxy3;
							num4 = minProxy3.daSuDung;
							minProxy7.daSuDung = num4 - 1;
						}
						continue;
					}
					break;
				}
				}
				goto Block_3;
			}
			this.LoadStatusDatagridView(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
			num = 1;
			goto IL_C1FE;
			Block_3:
			goto IL_3461;
			IL_1403:
			text = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ==")))))))));
			bool flag95 = text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
			if (flag95)
			{
				typeProxy = 1;
			}
			else
			{
				typeProxy = 0;
			}
			bool flag96 = text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1FsQlJQVDA9"))))))))) || text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
			if (flag96)
			{
				text = text.Substring(0, text.Length - 2);
			}
			goto IL_3461;
			Block_12:
			this.SetStatusAccount(num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRBNVNFNXVXWHBWVjJScVUwVndNbHBWYUhKa1VUMDk="))))))))));
			goto IL_C1FE;
			IL_3461:
			bool flag97 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
			if (flag97)
			{
				bool flag98 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0) == 7 || this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0) == 8 || this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0) == 10;
				if (!flag98)
				{
					bool flag99 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag99)
					{
						text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text.Split(new char[]
						{
							':'
						})[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
					}
					this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZtdEdNVlJIYXpCUVVUMDk=")))))))));
					bool flag100 = false;
					int num4;
					for (int k = 0; k < 30; k = num4 + 1)
					{
						Common.DelayTime(1.0);
						text7 = Common.CheckProxyNew(text, typeProxy, 30);
						bool flag101 = text7 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag101)
						{
							flag100 = true;
							break;
						}
						num4 = k;
					}
					bool flag102 = !flag100;
					if (flag102)
					{
						this.LoadStatusDatagridView(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkazVIU2pGU1JXeElaRzFvTVdOcWEzZFRWV016WVVoVk1WSnVRa3BUUlVvMVdXcE9iMDVWYkZKUVZEQTk="))))))))));
						num = 1;
						goto IL_C1FE;
					}
				}
				text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text7 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
			}
			bool flag103 = text5 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || text.Split(new char[]
			{
				':'
			}).Length == 4;
			if (flag103)
			{
				text5 = Base.useragentDefault;
			}
			try
			{
				this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFdUSkdiMlZyYkhKYU1sSkpVMjVDTmxOVlNqRlpWVTVEWVRKU1dXSnJVbmhqTTJ4eFdrVk5NR1JWZUc1UVZEQTk="))))))))));
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwMUdiRlZpTTAwOQ=="))))))));
				Point pointFromIndexPosition = Common.GetPointFromIndexPosition(indexPos, this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldSWGxQV0U1clZucEdNVlZVU205bFYwbDVUVmQzUFE9PQ==")))))))), 3), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldWblJQVkU1U1RXMW9OVmxxU1hoaVFUMDk=")))))))), 2));
				Point sizeChrome = Common.GetSizeChrome(this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldSWGxQV0U1clZucEdNVlZVU205bFYwbDVUVmQzUFE9PQ==")))))))), 3), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldWblJQVkU1U1RXMW9OVmxxU1hoaVFUMDk=")))))))), 2));
				bool flag104 = text5 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag104)
				{
					text5 = Base.useragentDefault;
				}
				string text8 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag105 = text2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag105)
				{
					text8 = ConfigHelper.GetPathProfile() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + text2;
					bool flag106 = !this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWHBUYlhoYVYwWktjMVpWYUV0a2JIQjBZa2hPWVZWVU1Eaz0=")))))))), false) && !Directory.Exists(text8);
					if (flag106)
					{
						text8 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					}
				}
				chrome = new Chrome
				{
					IndexChrome = num3,
					DisableImage = !Convert.ToBoolean((this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoU0ZwclRVZDRNRmRXWkd0aVJrNVlUbFJDWVZkRmNHOVhWRTVTVUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyTXlUWGxXVkRBOQ==")))))))) : this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoU0ZwclRVZDRNRmRXWkd0aVJrNVlUbFJDWVZkRmNHOVhWRTVTVUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))))),
					UserAgent = text5,
					ProfilePath = text8,
					Size = sizeChrome,
					Position = pointFromIndexPosition,
					TimeWaitForSearchingElement = 3,
					TimeWaitForLoadingPage = 120,
					Proxy = text,
					TypeProxy = typeProxy,
					DisableSound = true,
					App = @string,
					IsUsePortable = this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhoV1VucHNOVnBGWkVkaFYwcElWbFF3UFE9PQ==")))))))), false),
					PathToPortableZip = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VteEtNbFpWWXpWbFYxSklVbTFzYVZJeFdtaFpWbWhDVUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))))
				};
				bool flag107 = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS2MwNXNjRlpVYlRscVlsUnNNRmRzUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xWRk9WQlJQVDA9")))))))));
				if (flag107)
				{
					chrome.IsUseEmulator = true;
					string text9 = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS2MwNXNjRlpVYlRscVlsUnNNRmRzUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Substring(0, this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS2MwNXNjRlpVYlRscVlsUnNNRmRzUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).LastIndexOf('x'));
					int pixelRatio = Convert.ToInt32(this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS2MwNXNjRlpVYlRscVlsUnNNRmRzUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Split(new char[]
					{
						'x'
					})[2]);
					chrome.Size_Emulator = new Point(Convert.ToInt32(text9.Split(new char[]
					{
						'x'
					})[0]), Convert.ToInt32(text9.Split(new char[]
					{
						'x'
					})[1]));
					bool flag108 = text5 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag108)
					{
						chrome.UserAgent = Base.useragentDefault;
					}
					chrome.PixelRatio = pixelRatio;
				}
				bool flag109 = this.isStop;
				if (flag109)
				{
					this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
					num = 1;
				}
				else
				{
					bool flag110 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUVwUVVUMDk=")))))))), 0) != 0;
					if (flag110)
					{
						chrome.LinkToOtherBrowser = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1RWWktNbFpFVGxOaU1YQlpVMnRPYW1KVWEzcFpla3BYWlZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					}
					int num6 = 0;
					for (;;)
					{
						bool flag111 = !chrome.Open(false);
						if (flag111)
						{
							break;
						}
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVnBGWkhOTlIwcElWbFJzU21KclNqVlphazV2VGxac1dWWnFRbWhTUkVFNQ==")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))));
						chrome.DelayTime(2.0);
						bool flag112 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
						if (!flag112)
						{
							goto IL_49EB;
						}
						bool flag113 = text.Split(new char[]
						{
							':'
						}).Length > 1;
						if (!flag113)
						{
							goto IL_49EA;
						}
						chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNiMWt3WkhKa1YwcFpZa2hDYWxGNlZuRlpha2wzWkdjOVBRPT0=")))))))));
						chrome.DelayTime(1.0);
						string pageSource = chrome.GetPageSource();
						bool flag114 = !pageSource.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1FsQlJQVDA9")))))))));
						if (!flag114)
						{
							goto IL_49E9;
						}
						chrome.Close();
						int num4 = num6;
						num6 = num4 + 1;
						bool flag115 = num6 < 3;
						if (!flag115)
						{
							goto IL_497F;
						}
					}
					this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1ScFdsVmpNMkp1YkVOTlIwNTZWRE5PYVdKWFpHNVhhMmhYVGxSU2FXUlZhR3RSTUZVNQ=="))))))))));
					num = 1;
					goto IL_C1FE;
					IL_497F:
					this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1Sb1N6QmpNbVJxVGxKYU1rb3hVbnBrY2xZeWRHNVpNR2hMWkcxV1NXRXlaejA9"))))))))));
					num = 1;
					goto IL_C1FE;
					IL_49E9:
					IL_49EA:
					IL_49EB:
					bool flag116 = !chrome.GetProcess();
					if (flag116)
					{
						this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFkbGRzWkU5amEyeE9WVEZLTkdOclVraGlNazQxWVd4c05WRnRjR2hUUlhBeVdXeGtWbUZCUFQwPQ=="))))))))));
						num = 1;
					}
					else
					{
						this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1RMFUydG9SbHA2U1RGaWEyeElUbGM1TTA1cmVFNWllazVDWkZWNGNFNUVNRDA9"))))))))));
						bool flag117 = false;
						string string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFrZWpBNQ=="))))))));
						bool flag118 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), 0) == 0;
						if (flag118)
						{
							string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOUVNRDA9"))))))));
						}
						else
						{
							bool flag119 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), 0) == 2;
							if (flag119)
							{
								string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFaGpPVkJSUFQwPQ=="))))))));
							}
						}
						bool flag120 = text8.Trim() != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag120)
						{
							num2 = CommonChrome.CheckLiveCookie(chrome, string2);
							bool flag121 = chrome.GetURL().Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDVWRzVhYVdKV2NIZFpNakIzVUZFOVBRPT0=")))))))));
							if (flag121)
							{
								goto IL_5AE8;
							}
							switch (num2)
							{
							case -3:
								chrome.Status = StatusChromeAccount.NoInternet;
								goto IL_C1FE;
							case -2:
								chrome.Status = StatusChromeAccount.ChromeClosed;
								goto IL_C1FE;
							case 1:
								flag117 = true;
								break;
							case 2:
								chrome.Status = StatusChromeAccount.Checkpoint;
								goto IL_5AE7;
							}
						}
						bool flag122 = !flag117;
						if (flag122)
						{
							string text10 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							int valueInt = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 0);
							int num7 = valueInt;
							if (num7 != 0)
							{
								if (num7 == 1)
								{
									bool flag123 = statusDataGridView2.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
									if (flag123)
									{
										this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkMlZyYkVOa1JXeEpWVzA1TTA1cmVFNWFNV2h5V2pGRmVVOVlXbWhOYlhoelUxWkZPVkJSUFQwPQ=="))))))))));
										num = 1;
										goto IL_C1FE;
									}
									this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrV21NeFRrVmxhMnhEWkZad05WRnRjR2xOYW14NVdWWmtWbVJWZUhCT1JEQTk="))))))))));
									num2 = Convert.ToInt32(CommonChrome.LoginFacebookUsingCookie(chrome, statusDataGridView2, string2));
								}
							}
							else
							{
								bool flag124 = text2.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || text3.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								if (flag124)
								{
									bool flag125 = text2.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
									if (flag125)
									{
										this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkMlZyYkVOa1JXeEpWVzA1TTA1cmVFNWFNV2h5V2pGYVZtSkZWa3BWVkRBNQ=="))))))))));
									}
									else
									{
										bool flag126 = text3.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
										if (flag126)
										{
											this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkMlZyYkVOa1JXeEpWVzA1TTA1cmVFNWFNV2h5V2pGV1NGSnVjR3BsVlZVNQ=="))))))))));
										}
									}
									num = 1;
									goto IL_C1FE;
								}
								this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrV21NeFRrVmxhMnhEWkZad05WRnFSbWhXTVVrMFdUQmtSMlZ0VGpWT1NGWk5Xbm93T1E9PQ=="))))))))));
								bool valueBool = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEd0alJteFlZa1ZTYUZJeFduRlpWRVpEWkcxR1dFNVVRVDA9")))))))), false);
								if (valueBool)
								{
									text10 = CommonChrome.LoginFacebookUsingUidPassNew(chrome, text2, text3, text4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVVDA9")))))))), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XRnNTa2hQVldocFRWWndiMWx0ZEV0aFIwcHVVRlF3UFE9PQ==")))))))), 0), this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hQV0ZaclVtczFiMXBITVZkUk1rNTBUMVJPYWsxc1dqVT0=")))))))), false), 120);
								}
								else
								{
									text10 = CommonChrome.LoginFacebookUsingUidPassNew(chrome, text2, text3, text4, string2, this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XRnNTa2hQVldocFRWWndiMWx0ZEV0aFIwcHVVRlF3UFE9PQ==")))))))), 0), this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hQV0ZaclVtczFiMXBITVZkUk1rNTBUMVJPYWsxc1dqVT0=")))))))), false), 120);
								}
								try
								{
									num2 = Convert.ToInt32(text10);
								}
								catch
								{
									num2 = -1;
								}
							}
							bool flag127 = chrome.GetURL().Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDVWRzVhYVdKV2NIZFpNakIzVUZFOVBRPT0=")))))))));
							if (!flag127)
							{
								bool flag128 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 0) != 1;
								if (flag128)
								{
									switch (num2)
									{
									case -2:
										chrome.Status = StatusChromeAccount.ChromeClosed;
										break;
									case -1:
										this.SetStatusAccount(num3, text6 + text10);
										break;
									case 0:
										this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkazVIU25oa1IwNUVVV3BDYUZRd1l6SmpSbWhTV2pGc01WSjZXblpXTW5Sdg=="))))))))));
										break;
									case 1:
										flag117 = true;
										break;
									case 2:
										chrome.Status = StatusChromeAccount.Checkpoint;
										this.SetInfoAccount(statusDataGridView, num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk="))))))))));
										goto IL_5AE7;
									case 3:
										this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNSV016YkVKbFZuQjBVbGRuUFE9PQ=="))))))))));
										break;
									case 4:
										this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVGb3lSbFJSYmtwb1VuazViMlJZUms5a1ZXeElaRWM1TTA0eFNqRlhibXhGVWxkMGFsUjZXbWxpVjA1dg=="))))))))));
										break;
									case 5:
										this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtkV1NFNXVTbGxWVjJSb1RXMXdiMlJZUm5OTlZXeElaRWM1TTA0eFNqRlhibXhGVWxkMGFsUjZXbWxpVjA1dg=="))))))))));
										this.SetInfoAccount(statusDataGridView, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhTblJhUjNoaFVUQktNMWRXYUU5bFp6MDk=")))))))));
										break;
									case 6:
										this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtkT1VHRnJiRVZUYlRGYVZUQktlVmxWTVZCTlIwcDBXVEprTkZOcmFFVmtWekF4WW10c1VsQlVNRDA9"))))))))));
										break;
									case 7:
										chrome.Status = StatusChromeAccount.NoInternet;
										break;
									}
									bool flag129 = !flag117;
									if (flag129)
									{
										this.ScreenCaptureError(chrome, text2, 1);
										num = 1;
										goto IL_C1FE;
									}
								}
								else
								{
									switch (num2)
									{
									case -3:
										chrome.Status = StatusChromeAccount.NoInternet;
										goto IL_C1FE;
									case -2:
										chrome.Status = StatusChromeAccount.ChromeClosed;
										goto IL_C1FE;
									case 1:
										flag117 = true;
										break;
									case 2:
										chrome.Status = StatusChromeAccount.Checkpoint;
										this.SetInfoAccount(statusDataGridView, num3, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk="))))))))));
										goto IL_5AE7;
									case 3:
									{
										bool valueBool2 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUdGaVIwNTBZa2N4YkZWVU1Eaz0=")))))))), false);
										if (valueBool2)
										{
											flag117 = true;
										}
										break;
									}
									}
									bool flag130 = !flag117;
									if (flag130)
									{
										this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrYTFJeWNFVmlNMDQxVVcxU1JGRnRiRnBaTTJ4eFdWWk9SbEJSUFQwPQ=="))))))))));
										this.ScreenCaptureError(chrome, text2, 1);
										num = 1;
										goto IL_C1FE;
									}
								}
							}
						}
						IL_5AE7:
						IL_5AE8:
						this.SetStatusAccount(num3, text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrYTFJeWFHOWxhMnhEWkZkR1JGRnRjRE5PTVVveFYyNXNSbEJSUFQwPQ=="))))))))));
						bool flag131 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR2hWZW14dlYxUk9VMlJ0VG5OUFYzaHNVMFZLYzFreU1YTmlSMHAwVkcxNFRVMXJXbkZhUldNMVpWWm5lVnBIYUd0U01WbDZWMVpvY21SdFNuVlZXRms5")))))))));
						if (flag131)
						{
							chrome.ClickWithAction(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1EyRkhTbTVRVkRBOQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
							chrome.DelayTime(2.0);
						}
						bool flag132 = chrome.GetURL().Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwS1YwMUhVa2hpU0ZaaFRUQTBkMWRXYUV0TlJuQllWVlF3UFE9PQ==")))))))));
						if (flag132)
						{
							int num4;
							for (int l = 0; l < 5; l = num4 + 1)
							{
								bool flag133 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa1JOV0ZaYVYwWnNNRmRYTlZkTlIxSklUMWhWUFE9PQ==")))))))), 3.0) == 1;
								if (!flag133)
								{
									break;
								}
								chrome.Click(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYwNUZlRmhPVjJocllWUkdjRnBHYUZOTlIwbDVUa1F3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
								chrome.DelayTime(2.0);
								num4 = l;
							}
						}
						bool valueBool3 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldUbGMxYVUxcVZsQlhhazVXVUZFOVBRPT0=")))))))), false);
						if (valueBool3)
						{
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSklVazVsVlhCb1ZUQktNVmRxYUZCTlIwcHdVVzVXWVU5SFJqTmxhMnhPWkZWNGNFNUVNRDA9"))))))))));
							num2 = this.ChangeLanguage(chrome, this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFjRmRYY3pGaWJVbDVUbFU1WVUweFZUaz0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
							switch (num2)
							{
							case -2:
								num = 2;
								goto IL_C1FE;
							case 0:
								switch (CommonChrome.CheckStatusChrome(chrome))
								{
								case -3:
									num = 1;
									this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
									break;
								case -2:
									num = 2;
									break;
								case -1:
									num = 3;
									break;
								}
								goto IL_C1FE;
							}
						}
						bool valueBool4 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUdGaVIwNTBZa2N4YkZWVU1Eaz0=")))))))), false);
						if (valueBool4)
						{
							chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9")))))))));
							chrome.DelayTime(1.0);
							bool flag134 = chrome.GetURL().Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDVWRzVhYVdKV2NIZFpNakIzVUZFOVBRPT0=")))))))));
							if (flag134)
							{
								int valueInt2 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkVWJHeFlZa2hOUFE9PQ==")))))))), 0);
								num2 = this.VerifyAccount(chrome, num3, text6, statusDataGridView, valueInt2);
								switch (num2)
								{
								case 0:
									DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0weFYyVlhSbGhYYWxaS1VqRndiMWxXWkROaFFUMDk="))))))))));
									this.WriteFile(num3, 2);
									num = 1;
									goto IL_C1FE;
								case 1:
									DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0weFYyVlhSbGhYYWxaS1VtczBlRmRVU2s5aVIwMTZWRmhXVFdGVVVUaz0="))))))))));
									break;
								case 2:
									num = 4;
									goto IL_C1FE;
								case 3:
									DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRBNVNFNXVXWHBWVjJScFZqQmFkMWxyVGtaUVVUMDk="))))))))));
									this.isStop = true;
									num = 1;
									goto IL_C1FE;
								case 5:
									DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweFNsb3lSWGxoYTFJd1VucFdkVk5WWkcxU00wNU9aVlZ3YUZVd1NqSmFSV2hDV2pKU2VsUXpSalpUVlVadVdXeGtSMk5IU2tSU1ZEQTk="))))))))));
									num = 1;
									goto IL_C1FE;
								}
								switch (CommonChrome.CheckStatusChrome(chrome))
								{
								case -3:
									num = 1;
									this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
									goto IL_C1FE;
								case -2:
									num = 2;
									goto IL_C1FE;
								case -1:
									num = 3;
									goto IL_C1FE;
								default:
								{
									chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9")))))))));
									chrome.DelayRandom(2, 3);
									bool flag135 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaYU1HSXlUblJXYlRGTVlXcENjRlJFVG5kaVIwNTBUMGhhYVUwd1NYZFpWbU13WkcxUmVsTnVRbXRTTVZZeVZVUktSMkZ0VWtoaVNGcHBZV3BHY1ZkV1l6RmhiSEJZWkRJeGFsSXdXblZYYkZGNFlUSkdXRkp1VG10U2Vtd3hWMnhaTldSdFRrbFZia0pwWWtSc00xZFdaR3RpUld4elRVUXdQUT09")))))))), 5.0) == 1;
									if (flag135)
									{
										chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBXYmxKMldUSXhWMkpWZEhGTlIyeE5UVE5DYzFreU1EUmtiVWw2VVdwQ2FGWjZVakphUkU1TFkwZFNTRlpZV2xGTmExcHhXa1ZrYzJSdFNuRk5WM0JhVm5wV2NWZHNaRE5pVjA1SVVtMDFZVlpFUm5KWlZtUkhZekpTU0U5WVZtRldhbXd5V1RCb1UyTkhTbk5QV0dSYVZqSlNjMU5YZDNkaWEzUlVUbGR3YVZJeWVIRlpXR3h1WTBFOVBRPT0=")))))))));
										chrome.DelayTime(3.0);
										bool flag136 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1IyRnRVa2hpU0ZwcFlXcENjRlJFVG5kaVIwNTBUMGhhYVUwd1NYZFpWbU13WkcxUmVsTnVRbXRTTVZZeVZVUktSMkZ0VWtoaVNGcHBZV3BHY1ZscVNURmlWMFpaVTI1U1MySnJTbTlYYWtwV1QxZE9kRlp0Y0dsTmFsWTJXVlprVTJKSFRuTlBXRnBxVTBaS2QxbHRkelZoTWtaWVVtNU9hVTF0VG5CWFJrNURZVmRTV1ZWcVFtbE5hbEU1")))))))), 10.0) == 1;
										if (flag136)
										{
											chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYTFweFdrVmtjMlJ0U25GTlIyeE5UVE5DYzFreU1EUmtiVWw2VVdwQ2FGWjZVakphUkU1TFkwZFNTRlpZV2xGTmExcHhXa1ZrYzJSdFNuRk5WM0JwVFdwV2RGbFdhRXRrUlhCMVVXMW9ZVTFzVlRWWk1qRlhZVzFKZVU1WWNHaFdNVXB6V1RKM05XUnRUa2xWYmtKcFlrUnNjbGxXWkVkak1rbDVXVEpzV1ZVd1NuQmFSbWhUVFVkSmVVNUhOVXhWZWxaeFdXdGtjMkZ0UmpWYU0wRTk=")))))))));
											chrome.DelayTime(3.0);
										}
									}
									break;
								}
								}
							}
						}
						bool valueBool5 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEVkaE1YQkhVVzA1YVUxcVZuTT0=")))))))), false);
						if (valueBool5)
						{
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklSblJOUjJScVQwVTRkMlZyYkVaYU0yaExVbTVDTTA1dVNrNWlla2t3V2pKU1NHRklXbHBaTTJ4eFdWWk5NR1JWZUc1UVZEQTk="))))))))));
							num2 = this.AddPhone(chrome, this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNRnBGV2tOaU1rbDVUbGQzUFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))), this.rd);
							switch (num2)
							{
							case -2:
								num = 2;
								goto IL_C1FE;
							case 0:
								switch (CommonChrome.CheckStatusChrome(chrome))
								{
								case -3:
									num = 1;
									this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
									break;
								case -2:
									num = 2;
									break;
								case -1:
									num = 3;
									break;
								}
								goto IL_C1FE;
							}
						}
						bool valueBool6 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldVbXBLV2xkR1NtOVpNbU01VUZFOVBRPT0=")))))))), false);
						if (valueBool6)
						{
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSklVazVsVlhCb1ZUQktiMXBITVVkTlJteFpVMWhXVFdGVVVUaz0="))))))))));
							string text11 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							List<string> obj10 = this.lstPathFolderAvatarTemp;
							lock (obj10)
							{
								bool flag138 = this.lstPathFolderAvatarTemp.Count == 0;
								if (flag138)
								{
									this.lstPathFolderAvatarTemp = this.CloneList(this.lstPathFolderAvatar);
								}
								bool flag139 = !this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEVkTmJHeFpWVzFvYW1KR1NuWmFSbHBUVFZFOVBRPT0=")))))))), false);
								if (flag139)
								{
									text11 = this.lstPathFolderAvatarTemp[this.rd.Next(this.rd.Next(0, this.lstPathFolderAvatarTemp.Count))];
									this.lstPathFolderAvatarTemp.Remove(text11);
								}
								else
								{
									text11 = this.lstPathFolderAvatarTemp[num3];
								}
							}
							num2 = this.UpAvatar(chrome, text11, this.rd);
							switch (num2)
							{
							case -2:
								num = 2;
								goto IL_C1FE;
							case 0:
								switch (CommonChrome.CheckStatusChrome(chrome))
								{
								case -3:
									num = 1;
									this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
									break;
								case -2:
									num = 2;
									break;
								case -1:
									num = 3;
									break;
								}
								goto IL_C1FE;
							case 1:
							{
								CommonSQL.UpdateFieldToAccount(statusDataGridView, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1lXRkhVa2hTYm1zOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRkpRVkRBOQ==")))))))));
								bool flag140 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVWktjMWxyWkZkTlJuQldWMjVDYVZJeFZUaz0=")))))))), false) && File.Exists(text11);
								if (flag140)
								{
									File.Delete(text11);
								}
								break;
							}
							}
						}
						bool valueBool7 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldVbTVXYUZKVmNIZFhWa1U1VUZFOVBRPT0=")))))))), false);
						if (valueBool7)
						{
							num2 = 0;
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSklVazVsVlhCb1ZUQktiMlZyYkhOa1YwWkVVVzFzYUZremJFSlhWazB3WkZWNGJsQlVNRDA9"))))))))));
							string text12 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							bool flag141 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkV2JVNUdWRzVhYTJKV1dqVT0=")))))))), 0) == 0;
							if (flag141)
							{
								List<string> obj11 = this.lstPathFolderCoverTemp;
								lock (obj11)
								{
									bool flag143 = this.lstPathFolderCoverTemp.Count == 0;
									if (flag143)
									{
										this.lstPathFolderCoverTemp = this.CloneList(this.lstPathFolderCover);
									}
									bool flag144 = !this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEU5a2JWSjBWbTVzVjFJeVozaFdhMmhXVUZFOVBRPT0=")))))))), false);
									if (flag144)
									{
										text12 = this.lstPathFolderCoverTemp[this.rd.Next(0, this.lstPathFolderCoverTemp.Count)];
										this.lstPathFolderCoverTemp.Remove(text12);
									}
									else
									{
										text12 = this.lstPathFolderCoverTemp[num3];
									}
								}
								num2 = this.UpCover(chrome, text12, this.rd);
							}
							else
							{
								num2 = this.UpCoverNgheThuat(chrome, this.rd);
							}
							switch (num2)
							{
							case -2:
								num = 2;
								goto IL_C1FE;
							case 0:
								switch (CommonChrome.CheckStatusChrome(chrome))
								{
								case -3:
									num = 1;
									this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
									break;
								case -2:
									num = 2;
									break;
								case -1:
									num = 3;
									break;
								}
								goto IL_C1FE;
							case 1:
							{
								bool flag145 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVWktjMWxyWkZkTlJuQldWMjVDYVZJeFZUaz0=")))))))), false) && text12 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) && File.Exists(text12);
								if (flag145)
								{
									File.Delete(text12);
								}
								break;
							}
							}
						}
						bool valueBool8 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUZOaU1YQllUVlUxYVUxV1NtOD0=")))))))), false);
						if (valueBool8)
						{
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHRlljRXhVYm1SS1VucFdkbVI2V2sxVVZ6aDZWVmRrYTFJeU5VVmpXRTQxVTIxU1ZGRnVjRFJqYTFKT1lWWk5NR1JWZUc1UVZEQTk="))))))))));
							string tieuSu = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							List<string> obj12 = this.lstPathFileTieuSuTemp;
							lock (obj12)
							{
								bool flag147 = this.lstPathFileTieuSuTemp.Count == 0;
								if (flag147)
								{
									this.lstPathFileTieuSuTemp = this.CloneList(this.lstPathFileTieuSu);
								}
								string text13 = this.lstPathFileTieuSuTemp[this.rd.Next(0, this.lstPathFileTieuSuTemp.Count)];
								this.lstPathFileTieuSuTemp.Remove(text13);
								tieuSu = File.ReadAllText(text13);
							}
							num2 = this.ChangeTieuSu(chrome, tieuSu, true);
							switch (num2)
							{
							case -2:
								num = 2;
								goto IL_C1FE;
							case 0:
								switch (CommonChrome.CheckStatusChrome(chrome))
								{
								case -3:
									num = 1;
									this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
									break;
								case -2:
									num = 2;
									break;
								case -1:
									num = 3;
									break;
								}
								goto IL_C1FE;
							}
						}
						bool valueBool9 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEU5aFIwNUdUbGM1V2xkR1NsWlpWV00xWkZadmVGVnVRbWxhZWpBNQ==")))))))), false);
						if (valueBool9)
						{
							num2 = 0;
							string text14 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							List<string> obj13 = this.lstNoiLamViecTemp;
							lock (obj13)
							{
								bool flag149 = this.lstNoiLamViecTemp.Count == 0;
								if (flag149)
								{
									this.lstNoiLamViecTemp = Common.CloneList(this.lstNoiLamViec);
								}
								bool flag150 = this.lstNoiLamViecTemp.Count > 0;
								if (flag150)
								{
									text14 = this.lstNoiLamViecTemp[this.rd.Next(0, this.lstNoiLamViecTemp.Count)];
									this.lstNoiLamViecTemp.Remove(text14);
								}
							}
							bool flag151 = text14 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag151)
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeElUakJrZGxZeWRHNVphekZRV2pKS1ZGRnFTbWhhVldNellVUktUbVJWZUhCT1JEQTk="))))))))));
								num2 = this.ChangeWork(chrome, text14);
								switch (num2)
								{
								case -2:
									num = 2;
									goto IL_C1FE;
								case 0:
									switch (CommonChrome.CheckStatusChrome(chrome))
									{
									case -3:
										num = 1;
										this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
										break;
									case -2:
										num = 2;
										break;
									case -1:
										num = 3;
										break;
									}
									goto IL_C1FE;
								}
							}
							string text15 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							List<string> obj14 = this.lstQueQuanTemp;
							lock (obj14)
							{
								bool flag153 = this.lstQueQuanTemp.Count == 0;
								if (flag153)
								{
									this.lstQueQuanTemp = Common.CloneList(this.lstQueQuan);
								}
								bool flag154 = this.lstQueQuanTemp.Count > 0;
								if (flag154)
								{
									text15 = this.lstQueQuanTemp[this.rd.Next(0, this.lstQueQuanTemp.Count)];
									this.lstQueQuanTemp.Remove(text15);
								}
							}
							bool flag155 = text15 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag155)
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeEpVbXBHTTA1dE9XNVpNV2hYWVVod1NsSnVWazFoVkZJeA=="))))))))));
								num2 = this.ChangeHomeTown(chrome, text15);
								switch (num2)
								{
								case -2:
									num = 2;
									goto IL_C1FE;
								case 0:
									switch (CommonChrome.CheckStatusChrome(chrome))
									{
									case -3:
										num = 1;
										this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
										break;
									case -2:
										num = 2;
										break;
									case -1:
										num = 3;
										break;
									}
									goto IL_C1FE;
								}
							}
							string text16 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							List<string> obj15 = this.lstThanhPhoTemp;
							lock (obj15)
							{
								bool flag157 = this.lstThanhPhoTemp.Count == 0;
								if (flag157)
								{
									this.lstThanhPhoTemp = Common.CloneList(this.lstThanhPho);
								}
								bool flag158 = this.lstThanhPhoTemp.Count > 0;
								if (flag158)
								{
									text16 = this.lstThanhPhoTemp[this.rd.Next(0, this.lstThanhPhoTemp.Count)];
									this.lstThanhPhoTemp.Remove(text16);
								}
							}
							bool flag159 = text16 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag159)
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeEpWVzA1TTA1clNqRlpWVTVEWkRKR1VGSjZaSEpWZWxJeFZFZGpPVkJSUFQwPQ=="))))))))));
								num2 = this.ChangeCity(chrome, text16);
								switch (num2)
								{
								case -2:
									num = 2;
									goto IL_C1FE;
								case 0:
									switch (CommonChrome.CheckStatusChrome(chrome))
									{
									case -3:
										num = 1;
										this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
										break;
									case -2:
										num = 2;
										break;
									case -1:
										num = 3;
										break;
									}
									goto IL_C1FE;
								}
							}
							string text17 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							List<string> obj16 = this.lstTruongDHTemp;
							lock (obj16)
							{
								bool flag161 = this.lstTruongDHTemp.Count == 0;
								if (flag161)
								{
									this.lstTruongDHTemp = Common.CloneList(this.lstTruongDH);
								}
								bool flag162 = this.lstTruongDHTemp.Count > 0;
								if (flag162)
								{
									text17 = this.lstTruongDHTemp[this.rd.Next(0, this.lstTruongDHTemp.Count)];
									this.lstTruongDHTemp.Remove(text17);
								}
							}
							bool flag163 = text17 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag163)
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeEpWVzVzTkdOclVtOWtWRlY0WkZad05WSkZWbkpTVjJReFZFZHJNRkJSUFQwPQ=="))))))))));
								num2 = this.ChangeDaiHoc(chrome, text17);
								switch (num2)
								{
								case -2:
									num = 2;
									goto IL_C1FE;
								case 0:
									switch (CommonChrome.CheckStatusChrome(chrome))
									{
									case -3:
										num = 1;
										this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
										break;
									case -2:
										num = 2;
										break;
									case -1:
										num = 3;
										break;
									}
									goto IL_C1FE;
								}
							}
							string text18 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							List<string> obj17 = this.lstTruongTHPTTemp;
							lock (obj17)
							{
								bool flag165 = this.lstTruongTHPTTemp.Count == 0;
								if (flag165)
								{
									this.lstTruongTHPTTemp = Common.CloneList(this.lstTruongTHPT);
								}
								bool flag166 = this.lstTruongTHPTTemp.Count > 0;
								if (flag166)
								{
									text18 = this.lstTruongTHPTTemp[this.rd.Next(0, this.lstTruongTHPTTemp.Count)];
									this.lstTruongTHPTTemp.Remove(text18);
								}
							}
							bool flag167 = text18 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag167)
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeEpWVzVzTkdOclVtOWtWRlY0WkZad05WRnNWbFJTYTBwV1ZFZHJNR1JSUFQwPQ=="))))))))));
								num2 = this.ChangePTTH(chrome, text18);
								switch (num2)
								{
								case -2:
									num = 2;
									goto IL_C1FE;
								case 0:
									switch (CommonChrome.CheckStatusChrome(chrome))
									{
									case -3:
										num = 1;
										this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
										break;
									case -2:
										num = 2;
										break;
									case -1:
										num = 3;
										break;
									}
									goto IL_C1FE;
								}
							}
						}
						bool valueBool10 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEd0alIwbDVZa1pXYUZaNlZuWT0=")))))))), false);
						if (valueBool10)
						{
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JXRklWVEZXYmtKS1VqSlNkMDVIU2pGWmJVWlVVV3BDTTA1cVJqRlpWVVU1VUZFOVBRPT0="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVkck1HUlJQVDA9")))))))));
							int valueInt3 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkVFIwWllUMWhDVjFJeWVERlpWVVU1VUZFOVBRPT0=")))))))), 0);
							num2 = this.ChangeGender(chrome, valueInt3, statusDataGridView);
							switch (num2)
							{
							case -2:
								num = 2;
								goto IL_C1FE;
							case 0:
								switch (CommonChrome.CheckStatusChrome(chrome))
								{
								case -3:
									num = 1;
									this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
									break;
								case -2:
									num = 2;
									break;
								case -1:
									num = 3;
									break;
								}
								goto IL_C1FE;
							}
						}
						bool valueBool11 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldUbGMxV2xkSGVGVlpWbU14WW5jOVBRPT0=")))))))), false);
						if (valueBool11)
						{
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JXRklWVEZXYmtKS1VucFdkV1I2V2tOT1ZXeEpWRzVDYVdKWFpERlVSMnN3VUZFOVBRPT0="))))))))));
							int num8 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaWJHeFpZa1ZrYW1KVWJEQT0=")))))))), 0);
							int num9 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaWJHeFpZa1pXYVdSNk1Eaz0=")))))))), 0);
							int valueInt4 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyV2xOaU1XeFlUbGMxVTJKcmNESlpiRVU1VUZFOVBRPT0=")))))))), 0);
							int valueInt5 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyV2xOaU1XeFlUbGMxVjFKNlp6az0=")))))))), 0);
							int valueInt6 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaFIwcFdWMjVzYVUxcVFUaz0=")))))))), 0);
							int valueInt7 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaFIwcFhWVzVaUFE9PQ==")))))))), 0);
							bool flag168 = num8 == 31;
							if (flag168)
							{
								num8 = 30;
							}
							bool flag169 = num9 == 31;
							if (flag169)
							{
								num9 = 30;
							}
							int num10 = this.rd.Next(num8, num9 + 1);
							int num11 = this.rd.Next(valueInt4, valueInt5 + 1);
							int num12 = this.rd.Next(valueInt6, valueInt7 + 1);
							bool flag170 = num11 == 2 && num10 > 28;
							if (flag170)
							{
								num10 = 28;
							}
							num2 = fChange.ChangeNgaySinh(chrome, num10, num11, num12);
							switch (num2)
							{
							case -2:
								num = 2;
								goto IL_C1FE;
							case 0:
								switch (CommonChrome.CheckStatusChrome(chrome))
								{
								case -3:
									num = 1;
									this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
									break;
								case -2:
									num = 2;
									break;
								case -1:
									num = 3;
									break;
								}
								goto IL_C1FE;
							case 1:
							{
								string arg = (num11 < 10) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9")))))))) + num11.ToString()) : (num11.ToString() ?? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
								string arg2 = (num10 < 10) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9")))))))) + num10.ToString()) : (num10.ToString() ?? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
								CommonSQL.UpdateFieldToAccount(statusDataGridView, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeGMyVlhVa2hoUjNSYVYwZHpPUT09")))))))), string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xod1EwOVZkM3BqTTJodFZYcHJNMVJYTkhkUVVUMDk=")))))))), arg, arg2, num12));
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1MyTkhUblZWYlRsaFVqQlpNUT09")))))))), string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xod1EwOVZkM3BqTTJodFZYcHJNMVJYTkhkUVVUMDk=")))))))), arg, arg2, num12));
								break;
							}
							}
						}
						bool valueBool12 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWlhWVzE0YVZwNk1Eaz0=")))))))), false);
						if (valueBool12)
						{
							for (;;)
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JXRklWVEZXYmtKS1UwWlNSV05YTURCa1ZYaHdUa1F3UFE9PQ=="))))))))));
								string text19 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								string text20 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								string text21 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								text19 = this.lstHo[this.rd.Next(0, this.lstHo.Count)];
								bool flag171 = this.lstTenDem.Count > 0;
								if (flag171)
								{
									text20 = this.lstTenDem[this.rd.Next(0, this.lstTenDem.Count)];
								}
								text21 = this.lstTen[this.rd.Next(0, this.lstTen.Count)];
								string hoTen = string.Concat(new string[]
								{
									text19,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9")))))))),
									text20,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9")))))))),
									text21
								}).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWT1FsQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9")))))))));
								num2 = this.ChangeName(chrome, hoTen, text3);
								switch (num2)
								{
								case -2:
									goto IL_9B75;
								case 0:
									goto IL_9B80;
								case 2:
									continue;
								}
								break;
							}
							goto IL_9C55;
							IL_9B75:
							num = 2;
							goto IL_C1FE;
							IL_9B80:
							switch (CommonChrome.CheckStatusChrome(chrome))
							{
							case -3:
								num = 1;
								this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
								break;
							case -2:
								num = 2;
								break;
							case -1:
								num = 3;
								break;
							}
							goto IL_C1FE;
							IL_9C55:;
						}
						bool valueBool13 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWlhVVzFvYWswd01Eaz0=")))))))), false);
						if (valueBool13)
						{
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JXRklWVEZXYmtKS1VucE9iMlJZUlhoTlJXeElaRWM0TUZsdVJuZGFSazB3WkZWNGJsQlVNRDA9"))))))))));
							string text22 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							bool flag172 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkU1YwbDVZa1pHV2xkRk5UWT0=")))))))), 0) == 0;
							if (flag172)
							{
								text22 = this.lstPassword[this.rd.Next(0, this.lstPassword.Count)];
							}
							else
							{
								text22 = Common.CreateRandomString(15, this.rd);
							}
							bool flag173 = text22.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKak9WQlJQVDA9")))))))));
							if (flag173)
							{
								string[] array = text22.Split(new char[]
								{
									'*'
								});
								text22 = array[0];
								int num4;
								for (int m = 1; m < array.Length; m = num4 + 1)
								{
									text22 += Common.CreateRandomString(1, this.rd);
									text22 += array[m];
									num4 = m;
								}
							}
							bool valueBool14 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWlhVVzFvYWswd05WZFpla3BYVkZkR1dFNVlTbFJTTUZweFdWUktWMkYzUFQwPQ==")))))))), false);
							if (valueBool14)
							{
								num2 = this.ChangePassUseLinkHacked(chrome, text3, text22);
							}
							else
							{
								num2 = this.ChangePass(chrome, text3, text22);
							}
							switch (num2)
							{
							case -2:
								num = 2;
								goto IL_C1FE;
							case 0:
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSklVazVsVlhCb1ZUQktNMWRXYUU5bGEyeEpWVzA1TTA1cmVFNWFNV2hTV2pGc2RGTkZNWFpOYlhReFZFZHJNRkJSUFQwPQ=="))))))))));
								this.WriteFile(num3, 1);
								num = 1;
								goto IL_C1FE;
							case 1:
								CommonSQL.UpdateFieldToAccount(statusDataGridView, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))), text22);
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09")))))))), text22);
								text3 = text22;
								break;
							case 2:
								num = 4;
								goto IL_C1FE;
							}
						}
						bool valueBool15 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYY0V0aVZteFNVRlF3UFE9PQ==")))))))), false);
						if (valueBool15)
						{
							bool flag174 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZabFZuQjBVbFF3UFE9PQ==")))))))), 0) == 0;
							if (flag174)
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoT1VHRlljRXhVYWtKS1VrVndkRmRXVFRCa1ZYaHVVRlF3UFE9PQ=="))))))))));
								text4 = this.Create2FA(chrome, text3);
								bool flag175 = text4.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))));
								if (flag175)
								{
									text4 = text4.Split(new char[]
									{
										'|'
									})[1];
									CommonSQL.UpdateFieldToAccount(statusDataGridView, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFJtVlJQVDA9")))))))), text4);
									DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ==")))))))), text4);
								}
							}
							else
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFZGSkljRXBTYWtKS1VrVndkRmRXVFRCa1ZYaHVVRlF3UFE9PQ=="))))))))));
								bool flag176 = this.Remove2FA(chrome, text3);
								if (flag176)
								{
									CommonSQL.UpdateFieldToAccount(statusDataGridView, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFJtVlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
									DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
								}
							}
							switch (CommonChrome.CheckStatusChrome(chrome))
							{
							case -3:
								num = 1;
								this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
								goto IL_C1FE;
							case -2:
								num = 2;
								goto IL_C1FE;
							case -1:
								num = 3;
								goto IL_C1FE;
							}
						}
						bool valueBool16 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVlZqQmFkMWxyUlRsUVVUMDk=")))))))), false);
						if (valueBool16)
						{
							bool flag177 = !this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVlZqQmFkMWxyVmpSalIwcDBaRVZzV2xZd05YbFhiR1JTVUZFOVBRPT0=")))))))), false);
							if (flag177)
							{
								num2 = this.ChangeMail(chrome, text3, num3, text6, statusDataGridView);
							}
							else
							{
								num2 = this.ChangeMailHacked(chrome, text3, num3, text6, statusDataGridView);
							}
							switch (num2)
							{
							case 0:
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1SU1ZqRktjbE5WWTNoaFIwWllaREpuUFE9PQ=="))))))))));
								this.WriteFile(num3, 2);
								break;
							case 1:
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklSblJOUjJScFZqQmFkMWxyVGtOTlIwWklVMFV4YmxKNlZuWlRWV1JSVWtoU1NFNVhOVTFoVkZJeA=="))))))))));
								break;
							case 2:
								num = 4;
								goto IL_C1FE;
							case 3:
							{
								bool flag178 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa2IySkhTbFpOVjJob1ZqTmpPUT09")))))))), 0) == 1;
								if (flag178)
								{
									DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRBNVNFNXVXWHBWVjJScFZqQmFkMWxyVGtaUVVUMDk="))))))))));
								}
								else
								{
									DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqTndiMlJZUmxkT1ZXeE9WVEZLTkdOclVtOWtWRnBQWVd0c1IxVnRlR2xYUlVZd1dXeGtSMk5IU2tSU1ZEQTk="))))))))));
								}
								this.isStop = true;
								break;
							}
							case 4:
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweFNsb3hiREZTZWxwNVRURkdibGx0TVhGaFNGWjRUVmhrU2xORlNtOVplazVPWVVFOVBRPT0="))))))))));
								break;
							case 5:
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweFNsb3lSWGxoYTFJd1VucFdkVk5WWkcxU00wNU9aVlZ3YUZVd1NqSmFSV2hDV2pKU2VsUXpSalpUVlVadVdXeGtSMk5IU2tSU1ZEQTk="))))))))));
								break;
							}
							bool flag179 = num2 != 1 && this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxsU0ZwcVRXeGFSVmxWYUV0a2JVcFlWbFF3UFE9PQ==")))))))), false);
							if (flag179)
							{
								num = 1;
								goto IL_C1FE;
							}
							switch (CommonChrome.CheckStatusChrome(chrome))
							{
							case -3:
								num = 1;
								this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
								goto IL_C1FE;
							case -2:
								num = 2;
								goto IL_C1FE;
							case -1:
								num = 3;
								goto IL_C1FE;
							}
						}
						bool flag180 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVlRWYVZqSjRlbFZXWkRSamR6MDk=")))))))), false) && !this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVlZqQmFkMWxyUlRsUVVUMDk=")))))))), false);
						if (flag180)
						{
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1RelRtdDRUbUZXWXpCYU1rcFlVbTVDYVZGNlVqRlVSMk01VUZFOVBRPT0="))))))))));
							chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFYzaHBWakJhZDFsclRUUlFVVDA5")))))))));
							chrome.DelayTime(3.0);
							int num13 = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExUVmhTY2xkV2FGTmhSWGhaVkc1Q1lVMXRlSHBWUms1TFlUSkdXRkp1VG1sTmJVNHdXV3RrYzJSWFJqVlRiVkpMWlZkME1WbHJaRmRrVm05NlZXMDRQUT09"))))))))).ToString());
							int num4;
							for (int n = 0; n < num13; n = num4 + 1)
							{
								bool flag181 = !Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExUVmhTY2xkV2FGTmhSWGhaVkc1Q1lVMXRlSHBWUms1TFlUSkdXRkp1VG1sTmJVNHdXV3RrYzJSWFJqVlRiVkpMWlZkNGFRPT0=")))))))) + n.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBaTk1XSnNjRmxWYTBwclUwWktOVmxXWkV0TlYxSklWbGM1UzAxc1NtOWFSV1JHWkVkTmVsVnVXbXBpVmxaMVV6Rk5NV05IU25SVWJrNXJWakZLYzFremJHNWliVTE1Vm01T1VWWkZhekJVYlhCeVRWVTVSVkpVU2s1V1JrWXpWRzF3UmsxRk9VUlpNMEU5"))))))))).ToString());
								if (flag181)
								{
									chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWVzVDV2xZemFESlhibXQ0WXpKR1dFNVlTa3BpUkVFNQ==")))))))), n, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
									chrome.DelayTime(1.0);
									bool flag182 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBVbXBHWVZJeWVITlpiVEZQWWtWNFdFOVlaR3RTTW5neVdXMDFUbVJIU2toaVNIQnJVVEJ3YXc9PQ==")))))))), 15.0) == 1;
									if (flag182)
									{
										chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBVbXBHWVZJeWVITlpiVEZQWWtWNFdFOVlaR3RTTW5neVdXMDFUbVJIU2toaVNIQnJVVEJ3YTFWSE1UUmhSbXgwVm01T1VHSlVWWGRaVlUxNFlXMUdTR0pJVG1GUk1tUTJVekZGT1ZCUlBUMD0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
										chrome.DelayTime(1.0);
									}
								}
								num4 = n;
							}
							chrome.DelayTime(1.0);
						}
						bool flag183 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhQVjJoVlZqQmFkMWxyVms5TlZURnVVRlF3UFE9PQ==")))))))), false) && !this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVlZqQmFkMWxyUlRsUVVUMDk=")))))))), false);
						if (flag183)
						{
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1Sc1VuazVUbG94WkVaYU1rcFlVbTVDYVZFd1NuRmFSMDQxVWtWNGNFNUlWVDA9"))))))))));
							chrome.DelayTime(2.0);
							switch (this.RemoveMail(chrome, text3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))))
							{
							case 0:
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpBeFVHVnNiRlJSYmxKYVZqSjRlbE5WYUZOaWVsSnBZMWQ0YTFFd1NuQk9SMHA0WVVkR1ZGSlVNRDA9"))))))))));
								break;
							case 1:
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpBeFVHVnNiRlJSYmxKYVZqSjRlbE5WYUZOaU0yTXlVVzVXYUZFd1NuRmtlbVJUWkZad05WSlVNRDA9"))))))))));
								break;
							case 2:
								num = 4;
								goto IL_C1FE;
							}
						}
						bool valueBool17 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhQVjJoV1RXeEpkdz09")))))))), false);
						if (valueBool17)
						{
							num2 = this.RemovePhone(chrome, text3);
							switch (num2)
							{
							case 0:
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1Sc1ZGVTVObGRXVGtOV1NHaExVV3hXU2xWVU1Eaz0="))))))))));
								this.WriteFile(num3, 2);
								CommonSQL.UpdateFieldToAccount(statusDataGridView, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwS2IyTkdSWGxoUkVVOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1Sc1ZGVTVObGRXVGtObGJtaExVbXBDU2xWVU1Eaz0=")))))))));
								num = 1;
								goto IL_C1FE;
							case 1:
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpBeFVHVnNiRlJSYkZJMFUydEtWbE5WYUZOaU1XeHFaVlZHYVdKWFpHNVhWR2hRVFVkS2RGa3pWazFoVkZFNQ=="))))))))));
								break;
							case 2:
								num = 4;
								goto IL_C1FE;
							}
							switch (CommonChrome.CheckStatusChrome(chrome))
							{
							case -3:
								num = 1;
								this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
								goto IL_C1FE;
							case -2:
								num = 2;
								goto IL_C1FE;
							case -1:
								num = 3;
								goto IL_C1FE;
							}
						}
						bool valueBool18 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUc5a2JHeFhWVzA1YUZZeFdYZFZWekZ6VmxkR1dFNVZVbHBYUjNNNQ==")))))))), false);
						if (valueBool18)
						{
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1Sc1ZGVTVObGRXVGtOTlIwWklZbTFvTVdOcWEzZFRWV1JOWVVoVk1HTXlaR3RTTW5neFUxVmtVV0ZJVm5oTlZGWk5ZVlJTTVE9PQ=="))))))))));
							chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFdIQmhWakEwZUZreU1YTk5SMVpVVDFSQ2EwMXFiRzFYYlRGSFlXMVNTRTlZYkUxTmJFcHpXa2N4YzJGc2NGbFVXRms5")))))))));
							chrome.DelayThaoTacNho(0, null);
							bool flag184 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFVMjE0YVZaNmEzbFhWbVJMWXpGd1ZFMVhhR3BpVmxwdlUxVmplR0ZIVG5SV2JXaEtZa1JDYmxkWE5WZE5SMUpJVDFoVlBRPT0=")))))))), 10.0) == 1;
							if (flag184)
							{
								chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWxhZW14aFVucHNjVnBHWTNoaVIwcDFWVmhXYWxkR1duTlpNalZ6Vmtad1dHVkhlRnBOTVVveVdUSjBSMk15U2tSYU1qVllUV3hLYjFwRlpFWmtSMDE1WWtjMWFGWXpZelZUVnpWVFpHMVNXRlJ0T1ZwV01IQjZWMnhPUTJWV2NGaE5XRnByWWxWYWNGbHJaRlprUm14WlUyMTRXbFY2Um5CYVJtaFRUVWRKZVU1SGJGbFZNazUzVkVjeE5HSkhTblJhUkVKb1VraFNkRmxxVGtwaU1sSjBVbTVzU2xJeWN6VlVWbEl3WTBaQ1JVMVVVbEJOYlhSNVV6TnNjMDR4Y0VoUFYzQnJWbnBHYzFsdE5WSmtWMDVaVm0xNGFtSnRlRlZYYkdRMFlrWnJlbFZ1V21waE1GcDZXV3RPYm1Kc1kzbFZiV2hyVWpCV01GbDZTbk5pYlVaWVpIcHNTbUpzU2pKYVJtUlBZakZzV0ZOdVRtRlZNRW8xVjJ4amVHUnRVblJTYld4cFVqRldNRmRXYUV0aVJteFVUVmRzYTFkR1NYZFpha2t3WVZab1ZGa3pRbGhOTW1Rd1dWWlpkMlJXYTNsbFNFSmFUVzVPZGxNeFozZFFVVDA5")))))))));
								chrome.DelayTime(1.0);
							}
						}
						bool valueBool19 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVa2hQVnpWVlRURlpkdz09")))))))), false);
						if (valueBool19)
						{
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1RMFUydG9SbHA2U1RGaWEyeEpZVVJHTTA1cmVFNWFNV2hTV2pGcmVWTkZNVzVXTURGdVdrVmtiMk5JWXpKamF6RnVWMFpHYmxkWE1YVlVWemsxVGtoV1RWcDZNRGs9"))))))))));
							bool flag185 = this.Logout(chrome);
							if (flag185)
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkljRXBVVjJRMFUydG9SbHA2U1RGaWEyeEpZVVJHTTA1cmVFNWFNV2hTV2pGcmVWTkZNVzVXTURGdVdrVmtiMk5JWXpKamF6RnVWMFpHYmxkWE1YVlVWemsxVWxRd1BRPT0="))))))))));
							}
							else
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeFVFMUljRXBVYmtKS1ZGWk9VMlZGYkU5a1ZuQTFVV3BTYTFrd09YQmxhMnhIVFVWc1NGUnRhRFpUVlZweFUxVm9VMkl5Um1wVU0wWTJVMVZaZDFOVlpFdGpTSEJNVkZkblBRPT0="))))))))));
							}
							switch (CommonChrome.CheckStatusChrome(chrome))
							{
							case -3:
								num = 1;
								this.LoadStatusDatagridView(num3, text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MyVnNhM2xQV0ZacFlsWmFjVnBGVGtOVGJVcDFWVzE0YW1KVVZuTmFSVTVHVUZFOVBRPT0=")))))))));
								break;
							case -2:
								num = 2;
								break;
							case -1:
								num = 3;
								break;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeFVFMUljRXBVYmtKS1VqTlNkbVI2WkZOa1ZuQTFVV3BTV2xremJFTlhXR3hGVWxkMFdHSnJNWFpOYWxaMlUxWkZPVkJSUFQwPQ=="))))))))));
				Common.ExportError(chrome, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			IL_C1FE:
			switch (num)
			{
			case 1:
			{
				StatusChromeAccount status = chrome.Status;
				StatusChromeAccount statusChromeAccount = status;
				if (statusChromeAccount == StatusChromeAccount.ChromeClosed || statusChromeAccount == StatusChromeAccount.Checkpoint || statusChromeAccount == StatusChromeAccount.NoInternet)
				{
					DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + GetContentStatusChrome.GetContent(chrome.Status));
				}
				break;
			}
			case 2:
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkMlZyYkVOa1JXeEpWVzA1TTA1cmVFNWFNV2h5V2pGcmVXRkliR2xOYWtaelUxWkZPVkJSUFQwPQ=="))))))))));
				break;
			case 3:
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGVGtaUVVUMDk=")))))))));
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9")))))))));
				CommonSQL.UpdateFieldToAccount(statusDataGridView, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1XSlhTak5RVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9")))))))));
				this.WriteFile(num3, 4);
				break;
			case 4:
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSS1IyTkZiRWxSYldocVRUQXhidz09"))))))))));
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhTblJhUjNoaFVUQktNMWRXYUU5bFp6MDk=")))))))));
				CommonSQL.UpdateFieldToAccount(statusDataGridView, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1XSlhTak5RVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhTblJhUjNoaFVUQktNMWRXYUU5bFp6MDk=")))))))));
				this.WriteFile(num3, 3);
				break;
			default:
			{
				bool flag186 = CommonChrome.IsCheckpoint(chrome);
				if (flag186)
				{
					DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGVGtaUVVUMDk=")))))))));
					DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9")))))))));
					CommonSQL.UpdateFieldToAccount(statusDataGridView, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1XSlhTak5RVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9")))))))));
					this.WriteFile(num3, 4);
				}
				else
				{
					bool flag187 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVlZqQmFkMWxyUlRsUVVUMDk=")))))))), false) && num2 != 1;
					if (!flag187)
					{
						DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), text6 + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeEpWVzA1TTA0eFNqRlhibXhEVFVkR1dFNUhaR3hTZW13eFYyNXNSbEJSUFQwPQ=="))))))))));
					}
				}
				break;
			}
			}
			try
			{
				chrome.Close();
			}
			catch
			{
			}
			object obj18 = this.lock_FinishProxy;
			lock (obj18)
			{
				switch (this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0))
				{
				case 7:
				{
					bool flag189 = tinsoftProxy != null;
					if (flag189)
					{
						tinsoftProxy.DecrementDangSuDung();
					}
					break;
				}
				case 8:
				{
					bool flag190 = xproxyProxy != null;
					if (flag190)
					{
						xproxyProxy.DecrementDangSuDung(this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRUYWtacFlrZG9NMWt5TURWT1IxWlNVRlF3UFE9PQ==")))))))), 0));
					}
					break;
				}
				case 10:
				{
					bool flag191 = tmproxy != null;
					if (flag191)
					{
						tmproxy.DecrementDangSuDung();
					}
					break;
				}
				case 11:
				{
					bool flag192 = proxyWeb != null;
					if (flag192)
					{
						proxyWeb.DecrementDangSuDung();
					}
					break;
				}
				case 12:
				{
					bool flag193 = shopLike != null;
					if (flag193)
					{
						shopLike.DecrementDangSuDung();
					}
					break;
				}
				case 13:
				{
					bool flag194 = minProxy != null;
					if (flag194)
					{
						minProxy.DecrementDangSuDung();
					}
					break;
				}
				}
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x001B1B20 File Offset: 0x001AFD20
		private int ChangeMailHacked(Chrome chrome, string password, int indexRow, string statusProxy, string id)
		{
			int result = 0;
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string imap = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string username = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text4 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text5 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa2IySkhTbFpOVjJob1ZqTmpPUT09")))))))), 0) == 1;
				if (flag)
				{
					bool valueBool = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYmtKcFVteHdkMWt3UlRsUVVUMDk=")))))))), false);
					if (valueBool)
					{
						bool flag2 = this.lstMailAdd.Count == 0;
						if (flag2)
						{
							return 3;
						}
						text4 = this.lstMailAdd[this.rd.Next(0, this.lstMailAdd.Count)];
						username = text4.Split(new char[]
						{
							'|'
						})[0];
						text2 = text4.Split(new char[]
						{
							'|'
						})[1];
						text4 = text4.Split(new char[]
						{
							'|',
							'@'
						})[1];
						text = this.GeneratorEmail(text4);
					}
					else
					{
						List<string> obj = this.lstMailAdd;
						lock (obj)
						{
							bool flag4 = this.lstMailAdd.Count == 0;
							if (flag4)
							{
								return 3;
							}
							text3 = this.lstMailAdd[0];
							this.lstMailAdd.RemoveAt(0);
						}
						string[] array = text3.Split(new char[]
						{
							'|'
						});
						text = array[0];
						text2 = array[1];
						bool flag5 = array.Length > 2;
						if (flag5)
						{
							imap = array[2];
						}
						DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1ScFZqQmFkMWxyVFRCa1ZYaHVVRlF3UFE9PQ==")))))))));
						EmailHelper.DeleteMail(text, text2, imap);
					}
				}
				else
				{
					text = this.GetMailFromTempMail(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJkMWRzWTNoa01IaFlUVmRvYUZZelpERlphazVMWW10NE0xQlVNRDA9")))))))), 30);
					bool flag6 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (!flag6)
					{
						return 3;
					}
					text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				}
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SclVqSndSV05YTUhkYU1rcFlVbTVDYVZGNlVqRlVSMk01VUZFOVBRPT0="))))))))));
				for (int i = 0; i < 10; i++)
				{
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhPVnBXTURWNVYyeGtVbEJSUFQwPQ==")))))))));
					bool flag7 = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) == 2;
					if (flag7)
					{
						break;
					}
				}
				bool flag8 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1lXRkhTa2xXYlhoUlZUQndObGxxU1hoaVIwbDVUbGQ0V1UxclduRlhWRXBYWlcxTmVWWnRkRXBpUkVFNQ==")))))))), 10.0) == 1;
				if (flag8)
				{
					chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOTVhCdldXdG9WMkpHUWxSVGJuQnBUV3BHYzFscVNURmlSbWQ1VW0xd1drMXNXalpaZWtwWFlUQnNjMDFITlV4VmVsWnhXV3RrYzJGdFJqVmFNMEU5")))))))));
					chrome.DelayTime(1.0);
					chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOTVVreFdUQmtWazlWYkhWVWFrWmFZbFJHZDFwRlRrdGFSWEExWVhvd1BRPT0=")))))))));
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1UwNVhUa2hXVkd4S1ltczBlRmRYTUhoalIxSkVVMjFSUFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(1.0);
					bool flag9 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOUk1sSlpWV3BDYVUxcVZrbFhiR2hUVmtkU1NGSnViR3RTTVZweVZFWmtSMkZ0VWtsV2JXaHBVWHBHY0ZwR2FGTk5SMGw1VGtRd1BRPT0=")))))))), 15.0) == 1;
					if (flag9)
					{
						chrome.Click(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IySkdhM2xrU0dScFRXMTRNVnBGVmt0TlYxSkpWVzVhYVdFeVVuTmFSVnBQVFVac1dWTnFRbUZXTVVZd1YxWmtUMDFIVWxoU2JrNU5WakJ2ZUZwRmFGTmtiVXB1VUZRd1BRPT0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(3.0);
						bool flag10 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUlVbHBXTURSM1drWmtSMk13ZUZoVGFrWnJVMFpLTWxsdFl6bFFVVDA5")))))))), 30.0) == 1;
						if (flag10)
						{
							chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1YyRlhTbGhpUkVKWVRVVTFNbGx0TlZOalIwcDFWbTE0V1ZWVU1Eaz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							chrome.DelayTime(1.0);
							for (;;)
							{
								switch (chrome.CheckExistElements(10.0, new string[]
								{
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1UxcWJIcFhhMDVMV2tFOVBRPT0=")))))))),
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1UxcVZuTmFTR3hMV2tFOVBRPT0=")))))))),
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFjMWxyWkZkaGJWSklWbTEwV0UxVVFuQlhSa1U1VUZFOVBRPT0="))))))))
								}))
								{
								case 1:
								{
									bool valueBool2 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWblJTYmxaaFVucHNNRlpWWkVkbGJVMTNUVmRvYUZZemFFcFhWbVJQWTJ4d1dGVlVNRDA9")))))))), false);
									if (valueBool2)
									{
										text5 = Common.CreateRandomString(8, null) + Common.CreateRandomNumber(4, null);
									}
									else
									{
										text5 = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYm5CcVRVUkdiMWxXWkRSVFZteFlWRzVLWVZZeFJUaz0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
									}
									chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWHBhU0ZwcVlsWktiVmxxU2pSaGR6MDk=")))))))), password, true, 0.1);
									chrome.DelayTime(1.0);
									chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWHBhU0ZwcVlsWktiVmx0TVZkTmR6MDk=")))))))), text5, true, 0.1);
									chrome.DelayTime(1.0);
									chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWHBhU0ZwcVlsWktiVmRVU1RWa1ZuQjBZa2hzYVZWVU1Eaz0=")))))))), text5, true, 0.1);
									chrome.DelayTime(1.0);
									chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1YyRlhTbGhpUkVKWVRVVTFNbGx0TlZOalIwcDFWbTE0V1ZWVU1Eaz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
									CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))), text5);
									DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09")))))))), text5);
									continue;
								}
								case 2:
								{
									bool valueBool3 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWblJTYmxaaFVucHNNRlpWWkVkbGJVMTNUVmRvYUZZemFFcFhWbVJQWTJ4d1dGVlVNRDA9")))))))), false);
									if (valueBool3)
									{
										text5 = Common.CreateRandomString(8, null) + Common.CreateRandomNumber(4, null);
									}
									else
									{
										text5 = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYm5CcVRVUkdiMWxXWkRSVFZteFlWRzVLWVZZeFJUaz0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
									}
									chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWHBhU0ZwcVlsWktiVmx0TVZkTmR6MDk=")))))))), text5, true, 0.1);
									chrome.DelayTime(1.0);
									chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1YyRlhTbGhpUkVKWVRVVTFNbGx0TlZOalIwcDFWbTE0V1ZWVU1Eaz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
									CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))), text5);
									DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09")))))))), text5);
									continue;
								}
								case 3:
									goto IL_141C;
								}
								break;
							}
							goto IL_20F4;
							IL_141C:
							chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWxhZW14aFVucHNjVnBHWTNoaVIwcDFWVmhXYWxkR1duTlpNalZ6Vmtad1dHVkhlRnBOTVVveVdUSjBSMk15U2tSYU1qVllUV3BXYjFsc1pGWlBWV3gxVkcxNGFWSXhXbkZhUldSWFlURmplRTFIYkZsVk1rNTNWSHBLWVdSdFRuQmhTRUpSVmtWRk0xbFdValJPUlhoMFpVZDRhV0pYVVhkWlZWSXdZMFYwTldNelFteE5NMUV3Vm5wS2MxcEZlSFJVYms1b1ZqQTFlVk13VG5KT01scFpUVVF3UFE9PQ==")))))))));
							chrome.DelayTime(1.0);
							chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1YyRlhTbGhpUkVKWVRVVTFNbGx0TlZOalIwcDFWbTE0V1ZWVU1Eaz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							chrome.DelayTime(1.0);
							for (;;)
							{
								int num = chrome.CheckExistElements(10.0, new string[]
								{
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsUldjMXBFUlRWaGJVNUVVMjFSUFE9PQ==")))))))),
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczBlRmRYTUhoalIxSkhaRVZLWVZJeFJtNVdSekZYVFRCc1JsWnVVbHBXTW5oNlYwWk9TMXBCUFQwPQ=="))))))))
								});
								bool flag11 = num == 1;
								if (flag11)
								{
									break;
								}
								bool flag12 = num == 2;
								if (!flag12)
								{
									goto IL_20EA;
								}
								chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1YyRlhTbGhpUkVKWVRVVmFjbGRyVGtOVU1YQlpXVEprVTFaNlJtOVpWbVEwV2tFOVBRPT0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
								chrome.DelayTime(1.0);
							}
							chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFYwMHhaM2xVYm1NOQ==")))))))), text, true, 0.1);
							chrome.DelayTime(1.0);
							chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1YyRlhTbGhpUkVKWVRVVmFjbGRyV1hkUVVUMDk=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							chrome.DelayTime(3.0);
							DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZGVTVjR1ZyYkVkT1ZXeElUMVJDYWxGNlVqRlVSMk01VUZFOVBRPT0="))))))))));
							string text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							bool flag13 = !this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYmtKcFVteHdkMWt3UlRsUVVUMDk=")))))))), false);
							if (flag13)
							{
								text6 = EmailHelper.GetOtpFromMail(3, text, text2, 30, imap);
							}
							else
							{
								text6 = EmailHelper.GetOtpFromMail2(3, username, text2, text, 30, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZaamVHRkhUa1JPVkZaYVZucFdjbGRzYUc1a1ZtdDVUMWhSUFE9PQ==")))))))));
							}
							bool flag14 = text6.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag14)
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweFNsb3lSWGxoYTFJd1VucFdkVk5WWkcxU00wNU9aVlZ3YUZVd1NqSmFSV2hDV2pKU2VsUXpSalpUVlVadVdXeGtSMk5IU2tSU1ZEQTk="))))))))));
								object obj2 = this.k;
								lock (obj2)
								{
									this.lstMailLoi.Add(text3);
								}
								return 5;
							}
							chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XRXhjRkpRVkRBOQ==")))))))), text6, true, 0.1);
							chrome.DelayTime(1.0);
							chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1YyRlhTbGhpUkVKWVRVVTFNbGx0TVdGalIwNTBUVmRSUFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							chrome.DelayTime(3.0);
							for (int j = 0; j < 5; j++)
							{
								bool flag16 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXV0VaUlZUQndObHBHWkV0a1IwWlpWVmRzV1ZWVU1Eaz0=")))))))), 5.0) == 1;
								if (!flag16)
								{
									break;
								}
								chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXV0VaUlZUQndObHBHWkV0a1IwWlpWVmRzV1ZWVU1Eaz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							}
							result = 1;
							CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhrZWpBOQ==")))))))), text);
							CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWGxOVjJob1ZqTmpPUT09")))))))), text2);
							bool valueBool4 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVlRWYVZqSjRlbFpHWXpWalFUMDk=")))))))), false);
							if (valueBool4)
							{
								DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1RelRtdDRUbUZXWXpCYU1rcFlVbTVDYVZGNlVqRlVSMk01VUZFOVBRPT0="))))))))));
								chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFYzaHBWakJhZDFsclRUUlFVVDA5")))))))));
								chrome.DelayTime(3.0);
								chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVXBOTUhBeVdXcE9Va3N4Y0VoaVJFcFFZbFJWZDFsVlRYaGhiVVpJWWtoT1lWRXlaRFJUTVZFeFlUSkdXVmRUZEdGU01uZDVWVWN4VTJOSFVuQk9WMmhhVFRKT01WZFdhRU5qTVVKMFZXNUNhMkZxVm5KWlZtaGFUbTFLZFZWdE9VMVdNRFYyV1Zaa05HRXdkRVZTV0VKUllsWktkMXBIYnpGaE1rWlpWMU4wWVZJeWQzbFVNakF4VFVkR1JFMVhjR2hTTW5oNlYydE9ibVZWZEZWT1IyUmFWVEpPZDFSSE1VOWpNa1pZVkc1S1RGRXljems9")))))))));
								chrome.DelayTime(2.0);
								chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmRxU2xkTlJrcFlaVWQ0YVZZeFdqRmFSV2hQVVRKV1ZrNVhhR2xXTVZaMlUycE9RMDVGY0RWaVIwcE9Za1JDTVZkVVNqUmpSbXQ1WXpJNVRGVlVNRGs9")))))))));
								chrome.DelayTime(1.0);
							}
							IL_20EA:
							IL_20F4:;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaa1UyRXdiRVpOVjJob1ZqTmpPUT09")))))))));
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaa1UyRXdiRWhOVjJob1ZqTmtibHBGWkhGaFNGWjRWbXBDU2xJd2VHOWtXRVpIWTBWc1VsQlVNRDA9"))))))))));
			}
			return result;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x001B3D94 File Offset: 0x001B1F94
		public static string GetPhoneOtpmmo(string apikey, int timeOut = 60)
		{
			RequestHttp requestHttp = new RequestHttp(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			for (int i = 0; i < timeOut; i++)
			{
				try
				{
					text = requestHttp.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNbHBGYUVOa1IwcFlUMGhXYkZOSGR6SlVSRTVUWWtkV1NWVnVWbWxOTWs0eVYxWm9RMk5GZUhWUmJUbHFVa1JzYjFrd1pITmpiSEJaWVhwclBRPT0=")))))))) + apikey + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIwMVUwNVhUa2hXVkd4aFRXeFpkMWt3Wkc5a2JVcDBWbGN4YWxkR1NURlZSbEpHVUZFOVBRPT0=")))))))));
					bool flag = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag)
					{
						return text;
					}
				}
				catch
				{
				}
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x001B4064 File Offset: 0x001B2264
		public static string GetOtpOtpmmo(string apikey, string sdt, int timeOut = 60)
		{
			object[] parameters = new object[]
			{
				apikey,
				sdt,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3756656, 2000, 1884, parameters);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x001B40CC File Offset: 0x001B22CC
		public static string GetPhonePrimeOtp(string apikey, int timeOut = 60)
		{
			object[] parameters = new object[]
			{
				apikey,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3758656, 2400, 1885, parameters);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x001B4124 File Offset: 0x001B2324
		public static string GetOtpPrimeOtp(string apikey, string id_order, int timeOut = 60)
		{
			object[] parameters = new object[]
			{
				apikey,
				id_order,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3761056, 2080, 1886, parameters);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x001B418C File Offset: 0x001B238C
		private int CheckFacebookLogout(Chrome chrome, string uid, string pass, string fa2, bool isSendRequest = false)
		{
			int result = 0;
			CommonChrome.CheckStatusAccount(chrome, isSendRequest);
			switch (chrome.Status)
			{
			case StatusChromeAccount.ChromeClosed:
				result = -2;
				break;
			case StatusChromeAccount.LoginWithUserPass:
			case StatusChromeAccount.LoginWithSelectAccount:
			{
				string a = CommonChrome.LoginFacebookUsingUidPassNew(chrome, uid, pass, fa2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOUVNRDA9")))))))), 2, false, 120);
				bool flag = a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9"))))))));
				if (flag)
				{
					result = 1;
				}
				else
				{
					result = 2;
				}
				break;
			}
			case StatusChromeAccount.Checkpoint:
				result = -1;
				break;
			case StatusChromeAccount.NoInternet:
				result = -3;
				break;
			}
			return result;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x001B4300 File Offset: 0x001B2500
		public int ChangeGender(Chrome chrome, int type, string id)
		{
			bool flag = false;
			try
			{
				int num = chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlaR3BpVkd4MFdWWmtOR0pGZDNsV2JYUm9WMFpHTWxsV1l6RmlWMGw2Vlcxb1dtRlViRFpYYkdSUFRVZEdXRTlZVmsxTmJIQXlXVEl3ZUdWcmVEWlBXSEJoVmpBMGQxbFdZelZrVmtKWVUyMW9hazF0ZUhGVVJtUnpaRlp3ZEU5RU1EMD0=")))))))));
				bool flag2 = num == -2;
				if (flag2)
				{
					return -2;
				}
				bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBXa2Q0YVdKV1NuTlpNbXQ0Wld4d1dHVkhlRnBOTVVveVdUSnNTMXBCUFQwPQ==")))))))), 30.0) == 1;
				if (flag3)
				{
					chrome.ScrollSmooth(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYkVwdldrVmtSbVJIVFhsaVJ6Vm9Wak5qTlZOWE1XdGlSMHAwVlcxNGFtRlVSalpYYkdRMFlrWnJlbFZ1V21waFZYQnJVMjVzY2xCUlBUMD0=")))))))));
					chrome.DelayTime(1.0);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUMWhrYTFJeWVESlpiV3hEVFVkSmVsWnRjR2hTTUZwd1dXdGtWbUZXYUZKUVZEQTk=")))))))), type, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(1.0);
					chrome.ScrollSmooth(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYWxadldXeGtWazlWYkhWVWJXaHJZbFpXY0ZkR1RtcGpRVDA5")))))))));
					chrome.DelayTime(1.0);
					chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1IwMXNjRkpRVkRBOQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(1.0);
					for (int i = 0; i < 30; i++)
					{
						bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1MyRkhUWGxpUjNCTlZqSjRNVmR0TURSUVVUMDk=")))))))), 0.0) == 1;
						if (flag4)
						{
							break;
						}
						Thread.Sleep(1000);
					}
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					bool flag5 = type == 0;
					if (flag5)
					{
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFYyUkdiRmhsUjNjOQ=="))))))));
					}
					else
					{
						bool flag6 = type == 1;
						if (flag6)
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTXhjRkpRVkRBOQ=="))))))));
						}
					}
					CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwS1YyUldjRWhXYm1zOQ==")))))))), @string);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x001B4894 File Offset: 0x001B2A94
		public int ChangePassUseLinkHacked(Chrome chrome, string old_pass, string new_pass)
		{
			int num = 0;
			try
			{
				bool flag = !chrome.CheckIsLive();
				if (flag)
				{
					return -2;
				}
				chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhPVnBXTURWNVYyeGtVbEJSUFQwPQ==")))))))));
				chrome.DelayTime(1.0);
				bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1lXRkhTa2xXYlhoUlZUQndObGxxU1hoaVIwbDVUbGQ0V1UxclduRlhWRXBYWlcxTmVWWnRkRXBpUkVFNQ==")))))))), 10.0) == 1;
				if (flag2)
				{
					chrome.DelayTime(1.0);
					chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOTVhCdldXdG9WMkpHUWxSVGJuQnBUV3BHYzFscVNURmlSbWQ1VW0xd1drMXNXalpaZWtwWFlUQnNjMDFITlV4VmVsWnhXVlZrVjJGdFJYbFdiWFJSVjBaS05WcEdaRlpRVVQwOQ==")))))))));
					chrome.DelayTime(1.0);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1UwNVhUa2hXVkd4S1ltczBlRmRYTUhoalIxSkVVMjFSUFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(1.0);
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOUk1sSlpWV3BDYVUxcVZrbFhiR2hUVmtkU1NGSnViR3RTTVZweVZFWmtSMkZ0VWtsV2JXaHBVWHBHY0ZwR2FGTk5SMGw1VGtRd1BRPT0=")))))))), 10.0) == 1;
					if (flag3)
					{
						chrome.DelayTime(1.0);
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOUk1sSlpWV3BDYVUxcVZrbFhiR2hUVmtkU1NGSnViR3RTTVZweVZFWmtSMkZ0VWtsV2JXaHBVWHBHY0ZwR2FGTk5SMGw1VGtRd1BRPT0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(3.0);
						bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUlVbHBXTURSM1drWmtSMk13ZUZoVGFrWnJVMFpLTWxsdFl6bFFVVDA5")))))))), 60.0) == 1;
						if (flag4)
						{
							chrome.DelayTime(1.0);
							int num2 = 0;
							for (int i = 0; i < 10; i++)
							{
								bool flag5 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1UxcVZuTmFTR3hMV2tFOVBRPT0=")))))))), 0.0) == 1;
								if (flag5)
								{
									bool flag6 = num2 > 0;
									if (flag6)
									{
										num = 0;
										goto IL_A8A;
									}
									chrome.DelayTime(1.0);
									bool flag7 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1UxcWJIcFhhMDVMV2tFOVBRPT0=")))))))), 0.0) == 1;
									if (flag7)
									{
										chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWHBhU0ZwcVlsWktiVmxxU2pSaGR6MDk=")))))))), old_pass, true, 0.1);
										chrome.DelayTime(2.0);
									}
									chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWHBhU0ZwcVlsWktiVmx0TVZkTmR6MDk=")))))))), new_pass, true, 0.1);
									chrome.DelayTime(2.0);
									bool flag8 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1Uxck5USlpiVEZoWTBkT2RFMUhiRmxWVkRBNQ==")))))))), 0.0) == 1;
									if (flag8)
									{
										chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWHBhU0ZwcVlsWktiVmRVU1RWa1ZuQjBZa2hzYVZWVU1Eaz0=")))))))), new_pass, true, 0.1);
										chrome.DelayTime(2.0);
									}
									num2++;
									num = 1;
								}
								string text = chrome.CheckExistElementsv2(0.0, new string[]
								{
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUlVbHBXTURSM1drWmtSMk13ZUZoVGFrWnJVMFpLTWxsdFl6bFFVVDA5")))))))),
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOUk1sSlpWV3BDYVUxcVZrVlpha2t4VFVkR1dFNVVSbUZWZWtadlYxUk9VMDFXYkZoa00xSmFZbXhaZDFwRll6VmtVVDA5"))))))))
								});
								bool flag9 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								if (flag9)
								{
									bool flag10 = chrome.GetURL().StartsWith(CommonChrome.GetWebsiteFacebook(chrome, 2) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS2IyUnRTbGhXV0ZacVVqSm9Ndz09"))))))))) || chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYV0VaUlZUQnNNbGR0TlV0alJuQllUbGQwYW1WVWFIQlhSa1U1VUZFOVBRPT0=")))))))), 0.0) == 1;
									if (flag10)
									{
										goto IL_A8A;
									}
								}
								else
								{
									bool flag11 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1NsQlJQVDA9"))))))));
									if (flag11)
									{
										num = -2;
										goto IL_A8A;
									}
									chrome.Click(4, text, 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
									chrome.DelayTime(1.0);
								}
							}
						}
					}
				}
			}
			catch
			{
			}
			bool flag12 = num == 0;
			if (flag12)
			{
				Common.ExportError(chrome, null, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0ak5XTkZiRWRSYldocVRUQXhibFZ0TVVkalIwcENVRlF3UFE9PQ==")))))))));
			}
			IL_A8A:
			return num;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x001B5350 File Offset: 0x001B3550
		private int VerifyAccount(Chrome chrome, int indexRow, string statusProxy, string id, int typeMail)
		{
			int result = 0;
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = typeMail == 0;
				if (flag)
				{
					List<string> obj = this.lstMailVerify;
					lock (obj)
					{
						bool flag3 = this.lstMailVerify.Count == 0;
						if (flag3)
						{
							return 3;
						}
						text3 = this.lstMailVerify[0];
						this.lstMailVerify.RemoveAt(0);
					}
					text = text3.Split(new char[]
					{
						'|'
					})[0];
					text2 = text3.Split(new char[]
					{
						'|'
					})[1];
				}
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1ScFZqQmFkMWxyVFRCa1ZYaHVVRlF3UFE9PQ==")))))))));
				EmailHelper.DeleteMail(text, text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0weFYyVlhSbGhYYWxaS1VqQmFjVmRVU1RWTlYwcDFWVmhXVFdGVVVUaz0="))))))))));
				for (int i = 0; i < 10; i++)
				{
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOTURWeldrVm9VMk5IU25SYVNIQlJUVEZLYjFkWGIzaGhSbXQ1Vkc1YWExWjZWWGM9")))))))));
					bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MySkhTa2hQVjJoaFVYcEdjRnBHYUZOTlIwbDVUa1F3UFE9PQ==")))))))), 0.0) == 1;
					if (!flag4)
					{
						bool flag5 = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) == 1;
						if (flag5)
						{
							break;
						}
					}
				}
				bool flag6 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MySkhTa2hQVjJoaFVYcEdjRnBHYUZOTlIwbDVUa1F3UFE9PQ==")))))))), 0.0) == 1;
				if (flag6)
				{
					return 0;
				}
				string value = Regex.Match(chrome.GetURL(), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUm9kbFJIYkhaTU1IUlVUbGN4V2xZd05YTlhWekExWkcxR05VNVhjR2xOYWtFNQ=="))))))))).Value;
				chrome.ExecuteScript(string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIwMVYyUldhM3BWYmtKcFRXcFNibFZXWkZOaE1WSllVbTVDYVZFeWFITlpiR1JIWTBkS1JHSkVaR3RpVlZvMVUxVm9UMlF5UmxoT1ZrNUtVa1JDYmxreU1WZGxSMUpZWWtoc1lWVXlhR2xUVjNoUFkwZFNTRlpyVmxwWFJrcHZVMWQzZDJORmVITlBWMXBxVFRCS2QxbHRkelZsVlRrMVVXcEtXbGRGYkc1WmVrNURZMGRLY2xOWFpGRlZNRW8xVjJ4b1IwMVhSbGxUYlhoTVVtNU9jRlpVU25OTlJuQldWVzFvYTFJd1ZuQlhSazV5WkZabmVFOVljR3BTTW5neFYwUktTazR3YkVsWGJXaHFZVlZLTmxrd1pITmtWbHBFVVZSc1NsTkZjSE5aTVdoWFkwZE9kRlpYT1ZobFZYQlZXVlpvVTJKR1NraFNha0phVlRCd2ExTXhUVEZhYkdkNlZHNWthRlo2Vm0xYVJWSjZXakpTZEZKdWJFcFNNMEp2V2xjd05XSkhUWHBWVjJSUlZUQktOVmRzYUVkTlYwWlpVMjE0VEZKdVRuQldWRTVEWlZkR1dFNVlTbWxTTVZwRldXcEpNV0pYUmxoWk1teFpWVEowTVZsWE1VZE9iVWw1Vm01d2ExSklUbTVhUnpGSFpWVnNTRmR0YkdGVFJrbzJWMjVzUWs5VmJFbFRiWGhxVjBaYWQxa3lNVlppTVdRMVUydFdWMUpyTlVsVk1XTXhZMGRTUmxWdGFHdFNNRlp3VjBaT2NtUlhVa2hQV0VwaFZucFJNMU5WYUdGaFIwNXdVV3BHYWsxc1dqVlZNV1JTV2pGQ1ZGRnViR0ZYUlZsNFdWWm9TMkpGZEVkak1teFNUVEZhTlZreU1WZGtWMUpIVm01d1lWZEZjRXRaYlRGelRVZEdXRkp1VGxOU01GbDNWMVpPUzFwRmRGUk9WbHBXVFVaYVZGZEVRbk5TVlRrMVVXcEtXbGRGYkc1WlZXaFBZMFZzUlUxSFpHcGlWbG8wV2taa2MyVldjRlJoUjBwS1lrVTFkMXBGWkZkU1ZteFpWVzFvU21KRVFuZFVSekZ2WlcxR1ZXTXlaR3RpVlZvMVUxVm9RMkZIVFhwVVYyUlJWVEJHY0ZOWGNIcGFNbEowVW01c1NsTkdXalZaYTA1Q1QxVnNSRk5VTUQwPQ==")))))))),
					value,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1IyRXhjRWRQVjNCcFRXcFZkMWRXWkU5TlIwNUlUMWhDYVdKc1JqSlhhMlJ6WVVkS1NFOVhOVTFOTURSNFYxY3dlR05IVWtSUFIyeFFaVlZKZVZkV2FFcGFNWEJJVW1wQ1dsVXdSVFZUVlU1TFkxWnNXV05JV21GWFJUUjNWVVpTU21WVk1WVlVWRUpMWWxad2NGZEVTbE5OUjAxNVdYcHNTbUZWUm5sVFZXUmhZVlp3U1ZWdWNHRmxWVVo1VTFWT1NtSlhTblJXYWxKclVrUkNkRmRVU1RWa1YxSklVbTF3YTFORlNqSlpWbU14VFVaQ1ZGTlhaRXhsVlVweldXeGtSMk5IU2tSUldFcEtVVEJzZEZkRVJUVk5WMDE1Vm01c1VWVXdiRzVUTTJ4RFRWZE5lVlp1YkZSV01VWnVVek5zUW1GVmNITlBWMXBhVmtSQ05GTnRkelZhYkhCSllraFdVVlV4Y0cxWFJFNUxZa2RPVlUxSWFFdGlSR3h0VjFjeFZrOVZNVlJYYlZwWlRUQktjVlZHV2tOVFZrWlhWR3RhVTFFeFZqWlZWbFpUVW14S2NsSnNXbFZTYkVaMFYydG9RMlZXUWxWU1Z6RlpUVlJzTlZkc2FGcFBWWEJ6VDFkYWFtVnFRblJYUkVVMVlqSk5lV0Y2YkVwaFZVWjVVMVZrYjJWdFJsUlJXRXBLVVRCc2RGZEVSVFZsYlU1SVlraFdXVTB3YXpWVFYyeENZMnRzU1ZSdVpHaFdlbFpVVTFWT2Vsb3diSEJYYlZwWlRUQTFNMWxXWXpGYWJHeHhUVWRzU2xFelRtNVplazVEWTBkS2NsTlhaRXhsVlVad1UyMTNOVnB0VFhwUmJrSnBZa1JyZDFWR1RrcGFNSFExVVc1d2FsSXllREZXYTFKNldqRndkRlpxUWxwTmJXUjJXa1pvUzJNd2VFUlJhbVJLVW5wR2MxcEZaRzlrYkhCRllqSmtTMDFWU2xGV1ZFWlNZbXQ0UkZGdGJHbE5iRWt4VkRKc1EyRXhiRmxWYldoTlVUQktkbGRzWkVkaE1YQlpVMjV3VUdGVlNUTlRWVTVyVWtkSmVVNVVRbUZXZWxWM1ZFWmFVMDVYVGtoV1Z6VlFZVlZHZFZkV2FFTmtNa3BJWWtkd1dsZEdTbmRaYWtrd1pHMVdSRTFVVG10Tk1rNHdWMjB3TldWWFNsUk5WRVpxWWxob2MxbHRNVTlrYkhCSVZtMTBTMlZWU1RWVFZXZDNZMFY0ZFZWdE9XRldlbEoyVjJ4T1FrOVdRbkJSYlhoTllteEtjMXBWYUZKaU1IUlVZVE5XYTFJeWFITlpiV3h2WWtWc1JVMURkRXBUU0ZFMVV6RlNNRTlWT0hkU2JYUmhVbFJHYjFsV1pETmlNR3h1VUZRd1BRPT0=")))))))),
					text,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkc2NrNTNQVDA9"))))))))
				}));
				chrome.DelayTime(2.0);
				chrome.GotoURL(value + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1QySkhVa2xWYmtKcFlsZFNObFZFVGxOaFJteHhUVmRvV2sxck5USmFSbU14VFVFOVBRPT0=")))))))));
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZGVTVjR1ZyYkVkT1ZXeElUMVJDYWxGNlVqRlVSMk01VUZFOVBRPT0="))))))))));
				string text4 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag7 = typeMail == 0;
				if (flag7)
				{
					text4 = EmailHelper.GetOtpFromMail(2, text, text2, 10, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				}
				bool flag8 = text4 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag8)
				{
					chrome.Refresh();
					chrome.DelayTime(1.0);
					bool flag9 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1MySkhTa1ZOUjJ4aFVqSjRiMWxyWXpWaWEzaFpVVzVhYWsweFJuQlhSa1U1VUZFOVBRPT0=")))))))), 10.0) == 1;
					if (flag9)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1MySkhTa1ZOUjJ4aFVqSjRiMWxyWXpWaWEzaFpVVzVhYWsweFJuQlhSa1U1VUZFOVBRPT0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(2.0);
						text4 = EmailHelper.GetOtpFromMail(2, text, text2, 10, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					}
				}
				bool flag10 = text4.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag10)
				{
					DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweFNsb3lSWGxoYTFJd1VucFdkVk5WWkcxU00wNU9aVlZ3YUZVd1NqSmFSV2hDV2pKU2VsUXpSalpUVlVadVdXeGtSMk5IU2tSU1ZEQTk="))))))))));
					object obj2 = this.k;
					lock (obj2)
					{
						this.lstMailLoi.Add(text3);
					}
					return 5;
				}
				for (int j = 0; j < 3; j++)
				{
					chrome.GotoURL(text4);
					chrome.DelayTime(2.0);
					bool flag12 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkbGRzWkRSa01IZzJUMWhzWVZZeGF6VlVhMUpDVFVWc2MwMUVNRDA9")))))))), 0.0) != 1;
					if (flag12)
					{
						break;
					}
				}
				result = 1;
				CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhrZWpBOQ==")))))))), text);
				CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWGxOVjJob1ZqTmpPUT09")))))))), text2);
			}
			catch (Exception ex)
			{
				Common.ExportError(ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0weFYyVlhSbGhYYWxVOQ==")))))))));
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0weFYyVlhSbGhYYWxaS1VqRndiMWxXWkROaFFUMDk="))))))))));
			}
			return result;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x001B61D4 File Offset: 0x001B43D4
		private string GetMailFromTempMail(Chrome chrome, string url, int timeOut = 30)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				for (int i = 0; i < timeOut; i++)
				{
					bool flag = !chrome.GetURL().Contains(url);
					if (flag)
					{
						chrome.GotoURL(url);
					}
					string[] array = chrome.GetCookieFromChrome(Regex.Match(url, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUm9kbFJIYkhaTU1IUlhaRE5WUFE9PQ=="))))))))).Groups[1].Value).Split(new char[]
					{
						';'
					});
					for (int j = 0; j < array.Length; j++)
					{
						bool flag2 = array[j].Split(new char[]
						{
							'='
						})[0] == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhrZWpBOQ=="))))))));
						if (flag2)
						{
							text = WebUtility.UrlDecode(array[j].Split(new char[]
							{
								'='
							})[1]);
							break;
						}
					}
					bool flag3 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag3)
					{
						break;
					}
					Common.DelayTime(1.0);
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x001B6488 File Offset: 0x001B4688
		private string GetOTPFromTempMail(string email, int timeOut = 60)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				string str = this.CreateMD5(email);
				RequestXNet requestXNet = new RequestXNet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
				string input = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				int tickCount = Environment.TickCount;
				while (Environment.TickCount - tickCount < timeOut * 1000)
				{
					input = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNiMWt3WkhKTlJYaDFWVzE0YVZkRlJqQlpiR1JIWTBkS1JFNVlXbXBpVjA0eVdUSXhWMlZIVWxoV2JuQnJVWHBzTUZkV1pITmpNSGQ1WWtkMFRXUjZNRGs9")))))))) + str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1lXUnRUblJOVjJoclVYcHNlRmw2U1RWa1VUMDk=")))))))));
					text = Regex.Match(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYXpVeVdXMHhZV05IVG5STlYzQnBUV3BWZDFkV1pFOU5SWGgxVVcwNWFsRXlaREZUTW04MFkwVnNibEJVTUQwPQ=="))))))))).Value;
					text = text.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaamVHUXdPVE5RVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					bool flag = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag)
					{
						break;
					}
					Thread.Sleep(2000);
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x001B6978 File Offset: 0x001B4B78
		public string CreateMD5(string input)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				byte[] bytes = Encoding.ASCII.GetBytes(input);
				byte[] array = md.ComputeHash(bytes);
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xWU1NsQlJQVDA9"))))))))));
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x001B6A60 File Offset: 0x001B4C60
		private void ScreenCaptureError(Chrome chrome, string uid, int type)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					string text = Application.StartupPath + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa05HUnNiM2hQVjNCYVYwVkpkMXBHYUV0aVFUMDk="))))))));
					switch (type)
					{
					case 0:
						text += Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1QySXhjRmhVYmtwcVVucHNkMWx0TlZKUVVUMDk="))))))));
						break;
					case 1:
						text += Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa05HUnNiM2xpU0ZaaFlsVmFkMWxyUlRsUVVUMDk="))))))));
						break;
					case 2:
						text += Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1UyTkhUWGxVYmxwcFlsUldjMWRVVGxKUVVUMDk="))))))));
						break;
					}
					Common.CreateFolder(text);
					chrome.ScreenCapture(text, uid);
					string contents = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhOVjJocVlsaFJlRmt3VGtKUFZXeElWVzVhV2sweFdqQlhiR014VFVWNGRGVnVXbHBOTVZvd1YyeGpNVTFHU2xobFIzaHBWakZhTVZwRlRURmpSMHAwVGxkNGFtRXlhRlpXUmxZelRqSk9kRlpxUW10WFJYQXhVMVZqZUdGSFRuUmtSRVpxVWtoTk9RPT0="))))))))).ToString();
					File.WriteAllText(text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + uid + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGIwMUhTbGhrZWpBOQ==")))))))), contents);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x001B6D2C File Offset: 0x001B4F2C
		private int ChangeMail(Chrome chrome, string pass, int indexRow, string statusProxy, string id)
		{
			int result = 0;
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string imap = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string username = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text4 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa2IySkhTbFpOVjJob1ZqTmpPUT09")))))))), 0) == 1;
				if (flag)
				{
					bool valueBool = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYmtKcFVteHdkMWt3UlRsUVVUMDk=")))))))), false);
					if (valueBool)
					{
						bool flag2 = this.lstMailAdd.Count == 0;
						if (flag2)
						{
							return 3;
						}
						text4 = this.lstMailAdd[this.rd.Next(0, this.lstMailAdd.Count)];
						username = text4.Split(new char[]
						{
							'|'
						})[0];
						text2 = text4.Split(new char[]
						{
							'|'
						})[1];
						text4 = text4.Split(new char[]
						{
							'|',
							'@'
						})[1];
						text = this.GeneratorEmail(text4);
					}
					else
					{
						List<string> obj = this.lstMailAdd;
						lock (obj)
						{
							bool flag4 = this.lstMailAdd.Count == 0;
							if (flag4)
							{
								return 3;
							}
							text3 = this.lstMailAdd[0];
							this.lstMailAdd.RemoveAt(0);
						}
						string[] array = text3.Split(new char[]
						{
							'|'
						});
						text = array[0];
						text2 = array[1];
						bool flag5 = array.Length > 2;
						if (flag5)
						{
							imap = array[2];
						}
						DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1ScFZqQmFkMWxyVFRCa1ZYaHVVRlF3UFE9PQ==")))))))));
						EmailHelper.DeleteMail(text, text2, imap);
					}
				}
				else
				{
					text = this.GetMailFromTempMail(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJkMWRzWTNoa01IaFlUVmRvYUZZelpERlphazVMWW10NE0xQlVNRDA9")))))))), 30);
					bool flag6 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (!flag6)
					{
						return 3;
					}
					text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				}
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SclVqSndSV05YTUhkYU1rcFlVbTVDYVZGNlVqRlVSMk01VUZFOVBRPT0="))))))))));
				for (int i = 0; i < 10; i++)
				{
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOTURWeldrVm9VMk5IU25SYVNIQlJUVEZLYjFkWGIzaGhSbXQ1Vkc1YWExWjZWWGM9")))))))));
					bool flag7 = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) == 1;
					if (flag7)
					{
						break;
					}
				}
				chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIwMVYyUldhM3BWYmtKcFRXcFNibFZXWkZOaE1WSllVbTVDYVZFeWFITlpiR1JIWTBkS1JHSkVaR3RpVlZvMVUxVm9UMlF5UmxoT1ZrNUtVa1JDYmxreU1WZGxSMUpZWWtoc1lWVXlhR2xUVjNoUFkwZFNTRlpyVmxwWFJrcHZVMWQzZDJORmVITlBWMXBxVFRCS2QxbHRkelZsVlRrMVVXcEtXbGRGYkc1WmVrNURZMGRLY2xOWFpGRlZNRW8xVjJ4b1IwMVhSbGxUYlhoTVVtNU9jRlpVU25OTlJuQldWVzFvYTFJd1ZuQlhSazV5WkZabmVFOVljR3BTTW5neFYwUktTazR3YkVsWGJXaHFZVlZLTmxrd1pITmtWbHBFVVZSc1NsTkZjSE5aTVdoWFkwZE9kRlpYT1ZobFZYQlZXVlpvVTJKR1NraFNha0phVlRCd2ExTXhUVEZhYkdkNlZHNWthRlo2Vm0xYVJWSjZXakpTZEZKdWJFcFNNMEp2V2xjd05XSkhUWHBWVjJSUlZUQktOVmRzYUVkTlYwWlpVMjE0VEZKdVRuQldWRTVEWlZkR1dFNVlTbWxTTVZwRldXcEpNV0pYUmxoWk1teFpWVEowTVZsWE1VZE9iVWw1Vm01d2ExSklUbTVhUnpGSFpWVnNTRmR0YkdGVFJrbzJWMjVzUWs5VmJFbFRiWGhxVjBaYWQxa3lNVlppTVdRMVUydFdWMUpyTlVsVk1XTXhZMGRTUmxWdGFHdFNNRlp3VjBaT2NtUlhVa2hQV0VwaFZucFJNMU5WYUdGaFIwNXdVV3BHYWsxc1dqVlZNV1JTV2pGQ1ZGRnViR0ZYUlZsNFdWWm9TMkpGZEVkak1teFNUVEZhTlZreU1WZGtWMUpIVm01d1lWZEZjRXRaYlRGelRVZEdXRkp1VGxOU01GbDNWMVpPUzFwRmRGUk9WbHBXVFVaYVZGZEVRbk5TVlRrMVVXcEtXbGRGYkc1WlZXaFBZMFZzUlUxSFpHcGlWbG8wV2taa2MyVldjRlJoUjBwS1lrVTFkMXBGWkZkU1ZteFpWVzFvU21KRVFuZFVSekZ2WlcxR1ZXTXlaR3RpVlZvMVUxVm9RMkZIVFhwVVYyUlJWVEJHY0ZOWGNIcGFNbEowVW01c1NsTkdXalZaYTA1Q1QxVnNSRk50T1d0VFJrb3pXVE53ZG1ScmQzcGFSRTVyWlZSV2RGZFdaRTlpUm14MFQxaGFhR1ZVVm5GWmFrbDNaR3hzV0ZWdGRGbE5helV5V1cwMVUyRkdhM3BWYm1ScFRXMTRNVnBGVFRWaE1rWllVbTVPYVUxdFRqSlplazVYWVZkS1dHSkVRazFsVldzelUxVm9ZV0ZIVG5CUmJYUmFWMFpLYjFOVlVYZGFNR3gwWTBkb2JHSlViSE5aZWs1U1QxVXhjVk5ZYUU1bGJFWjBWMjB4UzFwc2NFbFZibkJoWldwQ2NGTlZUbnBhTVhCMFUyMTBhMU5GTlhWVFZVNTZXakJzY0ZkdVZtRlhSMmQzVlVaT1lXRnRTWGxPVkVKYVZqQTBkMWt3WXpWalIwcDFWVlJzU21GVlJubFRWV1JYWkVac1dHSklUa3BSTTA1dVUxZHNZVnBzWjNwV2JuQmhWMFZyTlZOWGJFSmphMnhKVm01d1lWZEZjRXRYYTA1Q1kydHNSRk5YTVZsTlZHeHZWVVpTUm1KV1ozaFBWM1JzVm5wUk5WTnRkelZhYlU1MFZtNW9VVlpGVm5SWFJFVTFZVlp3VlUxSWFFdGlSR3h0V1RCa1RrOVdWa1poUlVwV1RVWmFSbE5zVWs5UmJFcEdWbXRrVWxac1drNVdhMDVoWVRKT1NWTlViRTVWTVhCdFYwUk9TMkpIVW5GTlJ6RlpUVlJzTmxWR1RtRmFiR2Q1WVVod2FGWkVRbkJUVlU1NldqSkdTVlJ1UWtwUk0wNXVVMWRzWVZwc1ozcFVibVJvVm5wV2JWa3liM2RoVld4RVl6SmthazB3U25kWmJYaEtXakIwTlZGWGJFdGlSR3h0V1hwT1EyTkhTbk5QVjJ4UlZUQnNibE16YkVObGJVNUlZa2hXVW1GVlJubFRWVTVLWWxabmVFOVljR3BTTW5neFYwUk9VazlWYkhCUldFcEtVMFUxTTFsV1l6RldWVGsxVVcweFlWZEdTbkZaVlU1dlRWZE9kR1F6VGtwVFNFNXVXV3hrVjAxSFJraFBWM1JRWVZWR2RWWlZWVFZXUmxwRVdUTk9TbEl3Y0RKWGEyaHlUbXRzU0ZWdGFHdFNNRlo2VTFWa2IySkdiRmhWYlhocVltc3dNbE5WYUhwYU1HOTNWRzVhYVdKc1NuTlpiVFZTWkVaYVNXSklaR0ZWTWsweVUxVk9hMkZIVGtsUmJrNW9WakExYjFwRlpITmtiVXB3VDFSU1RWZEhVWHBhU0d0NFlsZEplbE51VWsxWFJsbzFXV3RrVjJSV2EzbFBWM1JoVmpGR2RWTlZaM2RhTWxwVVlUTldhMUl5YUhOWmJXeHZZa1ZzUlUxRGRFcFNNVll4V2tWa1YwNUhVa1JhTTBKTVZYcFZkMWxWWkZka1ZYUklWbGRrVVZaRVVtNWFWRTEzWTBVNGVrMUVaRkpXTVVweVZrWmtSMk5IU2tSYU1tczk=")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkc2NrNTNQVDA9")))))))));
				chrome.DelayTime(2.0);
				string text5 = CommonChrome.RequestGet(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlWbXRTTVVweldXdGtWMkpzYkZsVmJYaHFUV3MxTlZkc1pGZGtWWGcyVDFoa1dsZEZjRzlaYkdoT1QxVndWVnBGVGt0V1JXdzFWMnhqTVUxSFRuVmhNMUpxVW5wc2QxbHROVkppUlRGeFUxZDRUazFGVm5OVVYzQkxaV3h3V1ZWcVFtaFdlbFoxV1ROc1ZtVlZNWEJXVkU1VFVURndNMWRXYUZOaU1VSlVWbGhzVTJKVk5USlpiVFZUWVVacmVsVnVjRXRXUlhCSVdXeGtSMlJXYkZoYVIzaHBWakZhTVZwRlRsWmxWa3B1VUZRd1BRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOUVNRDA9")))))))));
				bool flag8 = !text5.Contains(Common.UrlEncode(text.ToLower()));
				if (flag8)
				{
					return 0;
				}
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZGVTVjR1ZyYkVkT1ZXeElUMVJDYWxGNlVqRlVSMk01VUZFOVBRPT0="))))))))));
				string text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag9 = !this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYmtKcFVteHdkMWt3UlRsUVVUMDk=")))))))), false);
				if (flag9)
				{
					text6 = EmailHelper.GetOtpFromMail(0, text, text2, 30, imap);
				}
				else
				{
					text6 = EmailHelper.GetOtpFromMail2(0, username, text2, text, 30, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZaamVHRkhUa1JPVkZaYVZucFdjbGRzYUc1a1ZtdDVUMWhSUFE9PQ==")))))))));
				}
				bool flag10 = text6.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag10)
				{
					DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweFNsb3lSWGxoYTFJd1VucFdkVk5WWkcxU00wNU9aVlZ3YUZVd1NqSmFSV2hDV2pKU2VsUXpSalpUVlVadVdXeGtSMk5IU2tSU1ZEQTk="))))))))));
					object obj2 = this.k;
					lock (obj2)
					{
						this.lstMailLoi.Add(text3);
					}
					return 5;
				}
				for (int j = 0; j < 3; j++)
				{
					chrome.GotoURL(text6);
					chrome.DelayTime(2.0);
					bool flag12 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkbGRzWkRSa01IZzJUMWhzWVZZeGF6VlVhMUpDVFVWc2MwMUVNRDA9")))))))), 0.0) != 1;
					if (flag12)
					{
						break;
					}
				}
				bool flag13 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))), 0.0) == 1;
				if (flag13)
				{
					bool flag14 = pass != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (!flag14)
					{
						result = 4;
						goto IL_16B9;
					}
					chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))), pass, 0.1, true, 0.1);
					chrome.DelayTime(1.0);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKclVqRmFObHBGWkhOaE1VSlVVMjV3WVZZd05XMVhWbVJQV214c2RWWnFRbXRTZW13eFUxZDNkMUJSUFQwPQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(3.0);
					try
					{
						bool flag15 = Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCa1UyUnNhM3BXYmxKaFZucFZkMVJITlVkTlZuQlpVMnBXVmsxc1ducFhiR1JQVFVkSmVsTlhPVXROV0ZJeFYxWmplR0pHUWxSVGJtUmFWMFUxTmxOWGQzZGlhM1JVVGxSS1dsWXpaM2hYYkZGM1QxVndOVmt6UWt4bFYwNTE="))))))))));
						if (flag15)
						{
							return 2;
						}
					}
					catch
					{
					}
				}
				result = 1;
				CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhrZWpBOQ==")))))))), text);
				CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWGxOVjJob1ZqTmpPUT09")))))))), text2);
				bool valueBool2 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVlRWYVZqSjRlbFpHWXpWalFUMDk=")))))))), false);
				if (valueBool2)
				{
					DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1RelRtdDRUbUZXWXpCYU1rcFlVbTVDYVZGNlVqRlVSMk01VUZFOVBRPT0="))))))))));
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFYzaHBWakJhZDFsclRUUlFVVDA5")))))))));
					chrome.DelayTime(3.0);
					chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVXBOTUhBeVdXcE9Va3N4Y0VoaVJFcFFZbFJWZDFsVlRYaGhiVVpJWWtoT1lWRXlaRFJUTVZFeFlUSkdXVmRUZEdGU01uZDVWVWN4VTJOSFVuQk9WMmhhVFRKT01WZFdhRU5qTVVKMFZXNUNhMkZxVm5KWlZtaGFUbTFLZFZWdE9VMVdNRFYyV1Zaa05HRXdkRVZTV0VKUllsWktkMXBIYnpGaE1rWlpWMU4wWVZJeWQzbFVNakF4VFVkR1JFMVhjR2hTTW5oNlYydE9ibVZWZEZWT1IyUmFWVEpPZDFSSE1VOWpNa1pZVkc1S1RGRXljems9")))))))));
					chrome.DelayTime(2.0);
					chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmRxU2xkTlJrcFlaVWQ0YVZZeFdqRmFSV2hQVVRKV1ZrNVhhR2xXTVZaMlUycE9RMDVGY0RWaVIwcE9Za1JDTVZkVVNqUmpSbXQ1WXpJNVRGVlVNRGs9")))))))));
					chrome.DelayTime(1.0);
				}
				bool valueBool3 = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhQVjJoVlZqQmFkMWxyVms5TlVUMDk=")))))))), false);
				if (valueBool3)
				{
					DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1Sc1VuazVUbG94WkVaYU1rcFlVbTVDYVZFd1NuRmFSMDQxVWtWNGNFNUlWVDA9"))))))))));
					chrome.DelayTime(2.0);
					switch (this.RemoveMail(chrome, pass, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))))
					{
					case 0:
						DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpBeFVHVnNiRlJSYmxKYVZqSjRlbE5WYUZOaWVsSnBZMWQ0YTFFd1NuQk9SMHA0WVVkR1ZGSlVNRDA9"))))))))));
						break;
					case 1:
						DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpBeFVHVnNiRlJSYmxKYVZqSjRlbE5WYUZOaU0yTXlVVzVXYUZFd1NuRmtlbVJUWkZad05WSlVNRDA9"))))))))));
						break;
					case 2:
						result = 4;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaa1UyRXdiRVpOVjJob1ZqTmpPUT09")))))))));
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), statusProxy + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaa1UyRXdiRWhOVjJob1ZqTmtibHBGWkhGaFNGWjRWbXBDU2xJd2VHOWtXRVpIWTBWc1VsQlVNRDA9"))))))))));
			}
			IL_16B9:
			return result;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x001B8464 File Offset: 0x001B6664
		private string GeneratorEmail(string domain)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				result = CommonCSharp.CreateRandomString(10, null) + CommonCSharp.CreateRandomNumber(4, null) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZWRk9WQlJQVDA9")))))))) + domain;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x001B8550 File Offset: 0x001B6750
		private int RemovePhone(Chrome chrome, string pass)
		{
			int result = 0;
			try
			{
				chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFdIQnBWMFV4TWc9PQ==")))))))));
				chrome.DelayTime(3.0);
				string cssSelector = chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1MySkdjRzVRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1QySkhVa2xWYmtKcFlsZFNObFJFVGs5a1IwNDFUME01YW1KV1dqQlphazVoWWtFOVBRPT0=")))))))));
				for (;;)
				{
					bool flag = cssSelector != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (!flag)
					{
						goto IL_B61;
					}
					int num = 0;
					if (num >= 10)
					{
						goto IL_B5B;
					}
					chrome.Click(4, cssSelector, 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					int num2 = chrome.CheckExistElements(10.0, new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdHdjMWxzWXpWTmJIQlhUMWhrYUZKNmJERlhiRmsxVFRGc1dWTnVWbWhXZWxaMVYwUktSMkZ0UlhsT1ZFNXBUVzVvYzFkclpHdGlSbkJFVTIxUlBRPT0=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVTFNbGx0TlZOaFJtdDZWVzFhYWxKNmJIZFpiVFZTWVZab1VsQlVNRDA9")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZkYWJVNUlVbTV3YWsweVVqSlpNakZTWVZab1VsQlVNRDA9"))))))))
					});
					bool flag2 = num2 == 1;
					if (flag2)
					{
						chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYyUkhTWHBYYlhoWlRUQktkbGxxU1RGaVJtZDZXa2RvYW1KVVZuZFpiVEZyV214c1dGUnVTbWxpYlZJeVdXdGtWMkV4YjNsV2JYTTk=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZVOQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(3.0);
						bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZkYWJVNUlVbTV3YWsweVVqSlpNakZTWVZab1VsQlVNRDA9")))))))), 0.0) == 1;
						if (flag3)
						{
							chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1IwMXNjRmRQV0dSYVYwVTFObHBFU1RWbFZuQkNVRlF3UFE9PQ==")))))))), pass, true, 0.1);
							chrome.DelayTime(1.0);
							chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1IwMXNjRkpRVkRBOQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							chrome.DelayTime(3.0);
							try
							{
								bool flag4 = chrome.GetURL().Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYyUkhTWHBYYlhoWlRUQktkbGxxU1RGaVJYQjFVVzA1YVUxcVZuTlhSRWt4VFZkS1dGTnRlR3BhZWpBNQ==")))))))));
								if (flag4)
								{
									return 0;
								}
								bool flag5 = Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWxhZW14TFpXdFdkVlF6YkVOalJuQndZVWQwYVUxck5IaFpiR1JYWkZkU1JFNVlhR3RXTVZvMVdsWmFUMkpIU2toV2JYQnJVbnBzTlZNd1RtdFpiVXAwVW01U1lWWkVRbkJaZWtwSFRXeHdWMDlZWkZwWFJUVTJXa1JKTldWV2NFUlRiVkpMWlZkMGIxVkdZekZOVjBwSVpETkNTbE5IWXpWWGEyTTFZVzFTV0UxWGVHbGliRVl4V1RGb1YySkhUblZpUmxKaFZqTm9jMWRVVGxOa2JVNXdXakkxV0UxcVZtOVpiR1JXVDFWc2RWUnRhR3RpVmxwdFdUQmtSMlZ0VFhwYVNGcHFZbFpHY0ZkR1RtcGpSWGgxVjIxb2FWTkdXbk5VTTJ4RFpWWndXVlZxUm1waVZGSnVVekJvYms5V1FsUlpNalZNVlROT2RWTnVZemxRVVQwOQ=="))))))))));
								if (flag5)
								{
									return 2;
								}
							}
							catch
							{
							}
						}
					}
					else
					{
						bool flag6 = num2 == 2;
						if (flag6)
						{
							break;
						}
						chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1IwMXNjRmRQV0dSYVYwVTFObHBFU1RWbFZuQkNVRlF3UFE9PQ==")))))))), pass, true, 0.1);
						chrome.DelayTime(1.0);
						chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1IwMXNjRkpRVkRBOQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(3.0);
						try
						{
							bool flag7 = chrome.GetURL().Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYyUkhTWHBYYlhoWlRUQktkbGxxU1RGaVJYQjFVVzA1YVUxcVZuTlhSRWt4VFZkS1dGTnRlR3BhZWpBNQ==")))))))));
							if (flag7)
							{
								return 0;
							}
							bool flag8 = Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWxhZW14TFpXdFdkVlF6YkVOalJuQndZVWQwYVUxck5IaFpiR1JYWkZkU1JFNVlhR3RXTVZvMVdsWmFUMkpIU2toV2JYQnJVbnBzTlZNd1RtdFpiVXAwVW01U1lWWkVRbkJaZWtwSFRXeHdWMDlZWkZwWFJUVTJXa1JKTldWV2NFUlRiVkpMWlZkMGIxVkdZekZOVjBwSVpETkNTbE5IWXpWWGEyTTFZVzFTV0UxWGVHbGliRVl4V1RGb1YySkhUblZpUmxKaFZqTm9jMWRVVGxOa2JVNXdXakkxV0UxcVZtOVpiR1JXVDFWc2RWUnRhR3RpVmxwdFdUQmtSMlZ0VFhwYVNGcHFZbFpHY0ZkR1RtcGpSWGgxVjIxb2FWTkdXbk5VTTJ4RFpWWndXVlZxUm1waVZGSnVVekJvYms5V1FsUlpNalZNVlROT2RWTnVZemxRVVQwOQ=="))))))))));
							if (flag8)
							{
								return 2;
							}
						}
						catch
						{
						}
					}
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFdIQnBWMFV4TWc9PQ==")))))))));
					chrome.DelayTime(1.0);
					cssSelector = chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1MySkdjRzVRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1QySkhVa2xWYmtKcFlsZFNObFJFVGs5a1IwNDFUME01YW1KV1dqQlphazVoWWtFOVBRPT0=")))))))));
					bool flag9 = cssSelector == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag9)
					{
						goto Block_9;
					}
				}
				result = 1;
				goto IL_B5B;
				Block_9:
				result = 1;
				IL_B5B:
				goto IL_B69;
				IL_B61:
				result = 1;
				IL_B69:;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x001B9134 File Offset: 0x001B7334
		private int RemoveMail(Chrome chrome, string pass, string emailMoiAdd = "")
		{
			int result = 0;
			try
			{
				for (int i = 0; i < 2; i++)
				{
					bool flag = !chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFYzaHBWakJhZDFsclRUUlFVVDA5")))))))));
					if (flag)
					{
						chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFYzaHBWakJhZDFsclRUUlFVVDA5")))))))));
						chrome.DelayTime(3.0);
					}
					string input = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKV1NqSlhWRTVYWkVad1dFNVVRbE5XTTJoeldXeGtWMlJYVWtST1dFSnBZbFJXYzFreWRHOVdWbEpXWkhvd1BRPT0="))))))))).ToString();
					MatchCollection matchCollection = Regex.Matches(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1QySkhVa2xWYmtKcFlsZFNObFJFU2xka1JteFlZa2hPVFUxWVkzWlpNakZYWkVkSmVsZHRlRmxOYkZvd1YxWmtjMk13Y0hCYU0xWk1ZV3BvZDFOWFl6bFFVVDA5")))))))));
					for (int j = 0; j < matchCollection.Count; j++)
					{
						string text = matchCollection[j].Value.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaamVHUXdPVE5RVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
						string text2 = Regex.Match(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhrZW14TVVYcFNlRlZJYkhKaVVUMDk="))))))))).Groups[1].Value;
						text2 = Common.UrlDecode(text2);
						bool flag2 = text2 != emailMoiAdd && chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VUSm9jbGxxU2s5TlYwcFlWbTVXYTFGNlZuSlpha3BQVFZkS1dGWnVWbXRTVmxwNlYyeGplR0pIU25WVldGWm9WbnBXTVZkc2FFdFdWbkJaWVVSQ1RXSlVSbTlhUldSUFlqQjBTRTVYZUd0bFZVcFVWMnhrYTFKdFZrbFJWemxMWkhvd09RPT0=")))))))) + text2 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xb3diM2xaTWpWTVZUSjBibHByYUROYU1XTjRUVWhDVFdKWWFITlpiVEZyVFVkR1JHTXlOVXRrZWpBNQ=="))))))))).ToString() != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkak9WQlJQVDA9"))))))));
						if (flag2)
						{
							chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9")))))))) + text);
							bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 10.0) == 1;
							if (flag3)
							{
								chrome.DelayTime(3.0);
								int num;
								for (;;)
								{
									num = chrome.CheckExistElements(0.0, new string[]
									{
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))),
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZkYWJVNUlVbTV3YWsweVVqSlpNakZTWVZab1VsQlVNRDA9")))))))),
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lsZG5kMXBGYUVObGF6bHdUMGhhYTAweVVYcFVSekZoWVVacmVWWnRiR2xOYW14NVZFY3hUMlJ0U2xSUFZ6bGhWak5vTTFSSWNFWk5NRFUyVVZSS1QyRnJNSGRVYkZKYVRrVXhSVm96WkU1aFZYQnI="))))))))
									});
									bool flag4 = num != 0;
									if (flag4)
									{
										goto Block_7;
									}
									bool flag5 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0.0) == 1;
									if (!flag5)
									{
										break;
									}
									chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1IwMXNjRkpRVkRBOQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
									chrome.DelayTime(3.0);
								}
								goto IL_C19;
								Block_7:
								switch (num)
								{
								case 1:
								{
									chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))), pass, true, 0.1);
									chrome.DelayTime(1.0);
									chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1IwMXNjRkpRVkRBOQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
									chrome.DelayTime(3.0);
									try
									{
										bool flag6 = Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCa1UyUnNhM3BXYmxKaFZucFZkMVJITlVkTlZuQlpVMnBXVmsxc1ducFhiR1JQVFVkSmVsTlhPVXROV0ZJeFYxWmplR0pHUWxSVGJtUmFWMFUxTmxOWGQzZGlhM1JVVGxSS1dsWXpaM2hYYkZGM1QxVndOVmt6UWt4bFYwNTE="))))))))));
										if (flag6)
										{
											return 2;
										}
									}
									catch
									{
									}
									bool flag7 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lsZG5kMXBGYUVObGF6bHdUMGhhYTAweVVYcFVSekZoWVVacmVWWnRiR2xOYW14NVZFY3hUMlJ0U2xSUFZ6bGhWak5vTTFSSWNFWk5NRFUyVVZSS1QyRnJNSGRVYkZKYVRrVXhSVm96WkU1aFZYQnI=")))))))), 0.0) == 1;
									if (flag7)
									{
										return 3;
									}
									break;
								}
								case 2:
								{
									chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1IwMXNjRmRQV0dSYVYwVTFObHBFU1RWbFZuQkNVRlF3UFE9PQ==")))))))), pass, true, 0.1);
									chrome.DelayTime(1.0);
									chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1IwMXNjRkpRVkRBOQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
									chrome.DelayTime(3.0);
									try
									{
										bool flag8 = Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCa1UyUnNhM3BXYmxKaFZucFZkMVJITlVkTlZuQlpVMnBXVmsxc1ducFhiR1JQVFVkSmVsTlhPVXROV0ZJeFYxWmplR0pHUWxSVGJuQmFWMFp3YzFkRVRrTmhSMDE2VkdwT2FVMHdjSEpUVjNkM1ltdDBWRTVVU2xwV00yZDRWMnhSZDA5VmNEVlpNMEpNWlZkT2RRPT0="))))))))));
										if (flag8)
										{
											return 2;
										}
									}
									catch
									{
									}
									bool flag9 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lsZG5kMXBGYUVObGF6bHdUMGhhYTAweVVYcFVSekZoWVVacmVWWnRiR2xOYW14NVZFY3hUMlJ0U2xSUFZ6bGhWak5vTTFSSWNFWk5NRFUyVVZSS1QyRnJNSGRVYkZKYVRrVXhSVm96WkU1aFZYQnI=")))))))), 0.0) == 1;
									if (flag9)
									{
										return 3;
									}
									break;
								}
								case 3:
									return 3;
								}
							}
							IL_C19:;
						}
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x001B9E04 File Offset: 0x001B8004
		private bool Logout(Chrome chrome)
		{
			bool result = false;
			try
			{
				chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFdIQmhWakEwZUZreU1YTk5SMVpYVDFoT2FVMXRVbmRaYldzMVpXeHdXVlJ1Y0doV2Vtd3hXVE5yTldNeVNYbGFSMXBwVFRGWmQxZEVTa2RqTWtwRVQxZHdhVTFxVm5SWlZtaExaRVY0TTFCVU1EMD0=")))))))));
				chrome.DelayTime(1.0);
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				for (int i = 0; i < 10; i++)
				{
					text = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKV1NqSlhWRTVYWkVad1dFNVVRbE5XTTJoeldXeGtWMlJYVWtST1dFSnBZbFJXYzFreWRHOVdWbEpXWkROV2FWWXdXWGRYVkVwdVlqSktkRlpxVGtwU2EzQnpWMnBDVjA1SFRrUmFNalZOVFRBMWMxZFVUbGRsVjBaWlZXcFdUVTB3TlhOYVJXaFRZMGRLZEZwSWNFMU5NRFZ6V1hwT1QyTkhTWGxPV0hCTlRXNW9NbGRxUlRWa2JWSlpWVzFhV2xZemFIcFVTR3h1WkZWMGNVOUlRa3BoVjA1M1V6RmFlbVF4YUZST1dHeGhWMFZLZWxkV1pFOWlSWFJFV1RKc1MyVllaSFZUYm14eVpGZE5lbEZ1VG1oWFJrWjJVMnBLUjJSSFRrVmpNalZNVlhwV2VGbHFTbk5rVlhSRVdUSTFURlpJVFRrPQ=="))))))))).ToString();
					bool flag = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag)
					{
						chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9")))))))) + text);
						result = true;
						break;
					}
					chrome.DelayTime(1.0);
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x001BA04C File Offset: 0x001B824C
		public string Create2FA(Chrome chrome, string pass)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				int num = 0;
				string totp;
				for (;;)
				{
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZXTURSNFdUSXhjMDFIVmxSUFNHeGhZbFZhY1ZSRVRrOWlSMUpKVm01a1RVMXRlREZhUldoTFpHdDRNMUJVTUQwPQ==")))))))));
					chrome.DelayTime(1.0);
					int num2 = chrome.CheckExistElements(20.0, new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaYU1HRXhiRmxWYldoTlYwVTFkMWRxU25Oak1VSlVVMnBDYVUweFduRlpWV1JIWVZkS1NGWlhiRmxWVkRBNQ==")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKclVqRmFObHBGWkhOaE1VSlVVMnBDWVdKck5XMVpWV1JYWVVad1NGWnViRmxOYTI5NFdrVm9VMlJ0U25CVGJWRTk="))))))))
					});
					bool flag = num2 == 0;
					if (flag)
					{
						break;
					}
					bool flag2 = num2 == 3;
					if (flag2)
					{
						goto Block_5;
					}
					bool flag3 = num2 == 2;
					if (flag3)
					{
						goto Block_6;
					}
					string text3 = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKV1NqSlhWRTVYWkVad1dFNVVRbE5XTTJoeldXeGtWMlJYVWtST1dFSnBZbFJXYzFreWRHOVdWbEpXWkROV2FWWXdXWGRYVkVwdVlqSktkRlpxVGtwU2EzQnpWMnBDVjA1SFRrUmFNalZvVTBaSmQxa3dhRTVPYTNnMVQxaFNUV0pXY0c5WFZFcFhZVmRKZVU5WVNrMWlWVFV5V1d4Tk5HVldjSFJTYlhCTlRUQTFjMXBGYUZka01IZDZVbTVzV2sxcWJISlhiRTAxWW14d1dFNVhlR3BpVlZsM1YyeE9ibVJWZEhGUFNFSktZVmRPZDFNeFducGtNV2hVVGxoc1lWZEZTbnBYVm1SUFlrVjBSRmt5YkV0bFdHUjFVMjVzY21SWFRYcFJiazVvVjBaR2RsTnFTa2RrUjA1Rll6STFURlY2Vm5oWmFrcHpaRlYwUkZreU5VeFdTRTA1"))))))))).ToString();
					bool flag4 = text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag4)
					{
						text3 = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKV1NqSlhWRTVYWkVad1dFNVVRbE5XTTJoeldXeGtWMlJYVWtST1dFSnBZbFJXYzFreWRHOVdWbEpXWkROV2FWWXdXWGRYVkVwdVlqSktkRlpxVGtwU2EzQnpWMnBDVjA1SFRrUmFNalZvVTBaSmQxa3dhRTVPYTNnMVQxaFNUV0pXY0c5WFZFcFhZVmRKZVU5WVNrMWlWVFV5V1d4Tk5XVnNjRmhVYWtacVlsZDNkMXBXVFRSbFZuQjBVbTF3VFUwd05YTmFSV2hYWkRCM2VsSnViRnBOYW14eVYyeE5OV0pzY0ZoT1YzaHFZbFZaZDFkc1RtNWtWWFJ4VDBoQ1NtRlhUbmRUTVZwNlpERm9WRTVZYkdGWFJVcDZWMVprVDJKRmRFUlpNbXhMWlZoa2RWTnViSEprVjAxNlVXNU9hRmRHUm5aVGFrcEhaRWRPUldNeU5VeFZlbFo0V1dwS2MyUlZkRVJaTWpWTVZraE5PUT09"))))))))).ToString();
					}
					bool flag5 = text3 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (!flag5)
					{
						break;
					}
					chrome.GotoURL(text3);
					chrome.DelayTime(1.0);
					num2 = chrome.CheckExistElements(20.0, new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKclVqRmFObHBGWkhOaE1VSlVVMjVLWVZkSGRIQlhSa1U1VUZFOVBRPT0=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUVNRDA9")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QyRkhUa2xWYlhCb1VqQmFiVmt5TVZkbGJVNUlUMWhXYWsxc1ZUaz0=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOUk1rbDZWV3BDYVUxcVJrUlhWbWhLVUZFOVBRPT0="))))))))
					});
					bool flag6 = num2 == 1 || num2 == 2;
					if (!flag6)
					{
						break;
					}
					bool flag7 = num2 == 1;
					if (flag7)
					{
						chrome.DelayTime(1.0);
						chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))), pass, 0.1, true, 0.1);
						chrome.DelayThaoTacNho(0, null);
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					}
					bool flag8 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKclVqRmFObHBGWkhOaE1VSlVVMjVLWVZkSGRIQlhSa1U1VUZFOVBRPT0=")))))))), 20.0) == 1;
					if (!flag8)
					{
						break;
					}
					text2 = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3YjNoa1IzUmFWMFpLYjFSR2FGTmlSMDE2Vlc1Q1lWSkVRbkJaVkVwWFRsVnNjMDFITlV4VmVsWjNXVzB3TVdKSFRuTlZiWGhzVTBaRk9RPT0="))))))))).ToString().Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVTFNbGx0TVdGalIwNTBUVlZPYTFkR1NYZFpha2t3WVZab1VsQlVNRDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					bool flag9 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVTFNbGRyWkZaaFZtaFNVRlF3UFE9PQ==")))))))), 20.0) == 1;
					if (!flag9)
					{
						break;
					}
					chrome.DelayTime(1.0);
					totp = Common.GetTotp(text2);
					bool flag10 = totp == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (!flag10)
					{
						goto IL_CC0;
					}
					num++;
					bool flag11 = num == 1;
					if (!flag11)
					{
						goto IL_CBF;
					}
				}
				goto IL_F1A;
				Block_5:
				text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9")))))))) + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkljRXBVVjJSclVqQm9UbUo2U1RSYU1ERjBWMjFvU2xOR1NqVmxTRXBGVWpJNWFtVlZTbHBsVlZKR1lURmpkbFJYWkZSU1ZEQTk=")))))))));
				goto IL_F02;
				Block_6:
				chrome.DelayTime(1.0);
				chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))), pass, 0.1, true, 0.1);
				chrome.DelayThaoTacNho(0, null);
				chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
				bool flag12 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKclVqRmFObHBGWkhOaE1VSlVVMnBDWVdKck5XMVpWV1JYWVVad1NGWnViRmxOYTI5NFdrVm9VMlJ0U25CVGJWRTk=")))))))), 10.0) == 1;
				if (flag12)
				{
					text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9")))))))) + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkljRXBVVjJSclVqQm9UbUo2U1RSYU1ERjBWMjFvU2xOR1NqVmxTRXBGVWpJNWFtVlZTbHBsVlZKR1lURmpkbFJYWkZSU1ZEQTk=")))))))));
				}
				goto IL_F02;
				IL_CBF:
				IL_CC0:
				bool flag13 = totp != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag13)
				{
					chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVTFNbGRyWkZaaFZtaFNVRlF3UFE9PQ==")))))))), totp, 0.1, true, 0.1);
					chrome.DelayThaoTacNho(0, null);
					chrome.Click(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1YyRlhTbGhpUkVKWlRXczFNbGRyWkZkYWJHeDFWbXBDYTFKNmJERT0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(2.0);
				}
				else
				{
					text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9")))))))) + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktiMlZyZEU5a2EyeE9WVEZLTkdOclVraGlNazQxWVd4c05WRnVVbHBaTTJ4RlUxVlNXbG95VFRSVWVrSTJVMVZXYnc9PQ==")))))))));
				}
				IL_F02:;
			}
			catch
			{
			}
			IL_F1A:
			bool flag14 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag14)
			{
				text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))) + text2;
			}
			return text;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x001BB03C File Offset: 0x001B923C
		public bool Remove2FA(Chrome chrome, string pass)
		{
			bool result = false;
			try
			{
				chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZXTURSNFdUSXhjMDFIVmxSUFNHeGhZbFZhY1ZSRVRrOWlSMUpKVm01a1RVMHhTWGhaTWpBeFdtMUplVmR0TVUxa2VqQTU=")))))))));
				chrome.DelayTime(1.0);
				bool flag = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKclVqRmFObHBGWkhOaE1VSlVVMnBDWVdKVldtMVpla3BYVFVkU1dWRnRXbUZTTW5odldXdGpOV0pzWjNwUmJteG9WbnBHYjFreU5YTmFiR3gxVm1wQ2ExSjZiREZUVjNkM1VGRTlQUT09")))))))), 20.0) == 1;
				if (flag)
				{
					chrome.DelayTime(1.0);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKclVqRmFObHBGWkhOaE1VSlVVMnBDWVdKVldtMVpla3BYVFVkU1dWRnRXbUZTTW5odldXdGpOV0pzWjNwUmJteG9WbnBHYjFreU5YTmFiR3gxVm1wQ2ExSjZiREZUVjNkM1VGRTlQUT09")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(2.0);
					switch (chrome.CheckExistElements(10.0, new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaYU1HRXhiRmxWYldoTlYwVTFkMWRxU25Oak1VSlVVMnBDYVUweFduRlpWV1JIWVZkS1NGWlhiRmxWVkRBNQ==")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUVNRDA9")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QyRkhUa2xWYlhCb1VqQmFiVmt5TVZkbGJVNUlUMWhXYWsxc1ZUaz0=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOUk1rbDZWV3BDYVUxcVJrUlhWbWhLVUZFOVBRPT0="))))))))
					}))
					{
					case 1:
					{
						chrome.DelayTime(1.0);
						chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))), pass, 0.1, true, 0.1);
						chrome.DelayThaoTacNho(0, null);
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaYU1HRXhiRmxWYldoTlYwVTFkMWRxU25Oak1VSlVVMnBDYVUweFduRlpWV1JIWVZkS1NGWlhiRmxWVkRBNQ==")))))))), 10.0) == 1;
						if (flag2)
						{
							result = true;
						}
						break;
					}
					case 2:
						result = true;
						break;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x001BB5D8 File Offset: 0x001B97D8
		public int ChangeHomeTown(Chrome chrome, string homeTown)
		{
			bool flag = false;
			try
			{
				chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlaR3BpVkd4MFdWWmtOR0pGZDNsV2JYUm9WMFpHTWxsV1l6RmlWMGw2Vlcxb1dtRlViRFpYYkdSUFRVZEdXRTlZVmsxTmJIQXlXVEl3ZUdWcmVEWlBXRTVvVmpGd2MxZEVTbGROYkhCWVRsUkNXVTB3TkhoWk1qRmhZVVpyZVZaVWJHbFhSa295V2taa1QySXhaM3BSYm14cFRXeHdkMWxyWkZaaVYwMTVWbTF3YTFJeWVESlpiVzk0WXpKR1dWZHVRbWxpVjAwNQ==")))))))));
				chrome.DelayTime(2.0);
				bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlpWV00xWkVad1dWVnVXbXROYWxJd1drVmtWMDVIVWtSUmFrSmhWMGRuZDFsV1l6RmtNbEpaVlZkc1dWVlVNRGs9")))))))), 10.0) == 1;
				if (flag2)
				{
					chrome.ClearText(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlpWV00xWkVad1dWVnVXbXROYWxJd1drVmtWMDVIVWtSUmFrSmhWMGRuZDFsV1l6RmtNbEpaVlZkc1dWVlVNRGs9")))))))));
					chrome.DelayTime(1.0);
					chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlpWV00xWkVad1dWVnVXbXROYWxJd1drVmtWMDVIVWtSUmFrSmhWMGRuZDFsV1l6RmtNbEpaVlZkc1dWVlVNRGs9")))))))), homeTown, 0.1, true, 0.1);
					chrome.DelayThaoTacNho(0, null);
					chrome.SendKeyDown(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlpWV00xWkVad1dWVnVXbXROYWxJd1drVmtWMDVIVWtSUmFrSmhWMGRuZDFsV1l6RmtNbEpaVlZkc1dWVlVNRGs9")))))))));
					chrome.DelayTime(1.0);
					chrome.SendEnter(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlpWV00xWkVad1dWVnVXbXROYWxJd1drVmtWMDVIVWtSUmFrSmhWMGRuZDFsV1l6RmtNbEpaVlZkc1dWVlVNRGs9")))))))));
					chrome.DelayThaoTacNho(1, null);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(2.0);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x001BB9A0 File Offset: 0x001B9BA0
		public int ChangeCity(Chrome chrome, string city)
		{
			bool flag = false;
			try
			{
				chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlaR3BpVkd4MFdWWmtOR0pGZDNsV2JYUm9WMFpHTWxsV1l6RmlWMGw2Vlcxb1dtRlViRFpYYkdSUFRVZEdXRTlZVmsxTmJIQXlXVEl3ZUdWcmVEWlBXRTVvVmpGd2MxZEVTbGROYkhCWVRsUkNXVTB3TkhoWk1qRmhZVVpyZVZaVWJHbFhSa295V2taa1QySXhaM3BSYm14cFRXeHdkMWxyWkZaaVYwMTVWbTF3YTFJeWVESlpiVzk0WXpKR1dWZHVRbWxpVjAwNQ==")))))))));
				chrome.DelayTime(2.0);
				bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhWRTVYWlZkT2RGWnVWbXRTYW14eFdWWm9VMDVWZUZsVmJYaHNVMFpHYmxwRlpGZE9SMUpJWWtoV2FsTkdXWGRUVjNkM1VGRTlQUT09")))))))), 10.0) == 1;
				if (flag2)
				{
					chrome.ClearText(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhWRTVYWlZkT2RGWnVWbXRTYW14eFdWWm9VMDVWZUZsVmJYaHNVMFpHYmxwRlpGZE9SMUpJWWtoV2FsTkdXWGRUVjNkM1VGRTlQUT09")))))))));
					chrome.DelayTime(1.0);
					chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhWRTVYWlZkT2RGWnVWbXRTYW14eFdWWm9VMDVWZUZsVmJYaHNVMFpHYmxwRlpGZE9SMUpJWWtoV2FsTkdXWGRUVjNkM1VGRTlQUT09")))))))), city, 0.1, true, 0.1);
					chrome.DelayTime(1.0);
					chrome.SendKeyDown(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhWRTVYWlZkT2RGWnVWbXRTYW14eFdWWm9VMDVWZUZsVmJYaHNVMFpHYmxwRlpGZE9SMUpJWWtoV2FsTkdXWGRUVjNkM1VGRTlQUT09")))))))));
					chrome.DelayTime(1.0);
					chrome.SendEnter(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhWRTVYWlZkT2RGWnVWbXRTYW14eFdWWm9VMDVWZUZsVmJYaHNVMFpHYmxwRlpGZE9SMUpJWWtoV2FsTkdXWGRUVjNkM1VGRTlQUT09")))))))));
					chrome.DelayThaoTacNho(1, null);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x001BBD54 File Offset: 0x001B9F54
		public int ChangeWork(Chrome chrome, string work)
		{
			bool flag = false;
			try
			{
				chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlVbUZWZW14dlYxY3dOVTFYVWtKUVZEQTk=")))))))));
				chrome.DelayTime(1.0);
				bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1UyTkhTbGhXYms1b1ZucFdjMVZYTURWaE1sWlNVRlF3UFE9PQ==")))))))), 10.0) == 1;
				if (flag2)
				{
					int num = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExaVlJXY2xkV2FFdGpiRnBJVDFSR1drMXRaREZaYTA1cVkwVjRkR1ZIZUdsaVYxRjNXVlZGT1ZCUlBUMD0="))))))))).ToString());
				}
				int num2 = chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlaR3BpVkd4MFdWWmtOR0pGZDNsV2JYUm9WMFpHTWxsV1l6RmlWMGw2Vlcxb1dtRlViRFpYYkdSUFRVZEdXRTlZVmsxTmJIQXlXVEl3ZUdWcmVEWlBXRTVvVmpGd2MxZEVTbGROYkhCWVRsUkNXVTB3TkhoWk1qRmhZVVpyZVZaVWJHbFhSa295V2taa1QySXhaM3BSYm14cFRXeHdkMWxyWkZaaVYwMTVWbTF3YTFJeWVESlpiVzk0VFRKSmVsTnVTa3RpVmxrd1dUQmtWMlZYUmxoV2JsWmFUV3hhYlZwRmFITmtNWEJWVFVoc1RsSkZSalU9")))))))));
				bool flag3 = num2 == -2;
				if (flag3)
				{
					return -2;
				}
				chrome.DelayTime(3.0);
				bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhiR040WkRKS1NFOVVWbUZYUld3d1drVmtWMDVIVWtSUmFrSmhWMGRuZDFsV1l6RmtNbEpaVlZkc1dWVlVNRGs9")))))))), 10.0) == 1;
				if (flag4)
				{
					chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhiR040WkRKS1NFOVVWbUZYUld3d1drVmtWMDVIVWtSUmFrSmhWMGRuZDFsV1l6RmtNbEpaVlZkc1dWVlVNRGs9")))))))), work, 0.1, true, 0.1);
					chrome.DelayThaoTacNho(0, null);
					chrome.SendKeyDown(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhiR040WkRKS1NFOVVWbUZYUld3d1drVmtWMDVIVWtSUmFrSmhWMGRuZDFsV1l6RmtNbEpaVlZkc1dWVlVNRGs9")))))))));
					chrome.DelayTime(1.0);
					chrome.SendEnter(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhiR040WkRKS1NFOVVWbUZYUld3d1drVmtWMDVIVWtSUmFrSmhWMGRuZDFsV1l6RmtNbEpaVlZkc1dWVlVNRGs9")))))))));
					chrome.DelayTime(1.0);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBZMFJHYVdKWVRqQmFSV1JYVGtkU1JGTnRVVDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(0.5);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhWRTVYWlZkT2RGWnVWbXRSTUVsM1dXcE9WMkZ0UmtoU2JXeHBVakZXY0ZkR1JUbFFVVDA5")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayThaoTacNho(0, null);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(2.0);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x001BC390 File Offset: 0x001BA590
		public int ChangePTTH(Chrome chrome, string ptth)
		{
			bool flag = false;
			try
			{
				chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlVbUZWZW14dlYxY3dOVTFYVWtKUVZEQTk=")))))))));
				chrome.DelayTime(1.0);
				bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1UyTkhTbGhXYms1b1ZucFdjMVZYTURWaE1sWlNVRlF3UFE9PQ==")))))))), 10.0) == 1;
				if (flag2)
				{
					int num = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExaVlJXY2xkV2FFdGpiRnBJVDFSR1drMXRaREZaYTA1cVkwVjRkR1ZIZUdsaVYxRjNXVlZGT1ZCUlBUMD0="))))))))).ToString());
				}
				int num2 = chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlaR3BpVkd4MFdWWmtOR0pGZDNsV2JYUm9WMFpHTWxsV1l6RmlWMGw2Vlcxb1dtRlViRFpYYkdSUFRVZEdXRTlZVmsxTmJIQXlXVEl3ZUdWcmVEWlBXRTVvVmpGd2MxZEVTbGROYkhCWVRsUkNXVTB3TkhoWk1qRmhZVVpyZVZaVWJHbFhSa295V2taa1QySXhaM3BSYm14cFRXeHdkMWxyWkZaaVYwMTVWbTF3YTFJeWVESlpiVzk0WWtad1NWWnRjRnBYUmtwM1dXcEpNR0pXY0ZsaFNHUmhWMFZ3ZDFkc1l6RmhiSEJYVDFSQ2JGZEZTbk5WUmxKS1pEQXhSVlJVTUQwPQ==")))))))));
				bool flag3 = num2 == -2;
				if (flag3)
				{
					return -2;
				}
				chrome.DelayTime(3.0);
				bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlpWV2hQV20xTmVWUnRPV2xOYW14NlZFWm9VMkpIVmtsVlYyUnJVakZaTUZwRlpITmtWMDVKVm1wQ1NtSkVRVGs9")))))))), 10.0) == 1;
				if (flag4)
				{
					chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlpWV2hQV20xTmVWUnRPV2xOYW14NlZFWm9VMkpIVmtsVlYyUnJVakZaTUZwRlpITmtWMDVKVm1wQ1NtSkVRVGs9")))))))), ptth, 0.1, true, 0.1);
					chrome.DelayThaoTacNho(0, null);
					chrome.SendKeyDown(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlpWV2hQV20xTmVWUnRPV2xOYW14NlZFWm9VMkpIVmtsVlYyUnJVakZaTUZwRlpITmtWMDVKVm1wQ1NtSkVRVGs9")))))))));
					chrome.DelayTime(1.0);
					chrome.SendEnter(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlpWV2hQV20xTmVWUnRPV2xOYW14NlZFWm9VMkpIVmtsVlYyUnJVakZaTUZwRlpITmtWMDVKVm1wQ1NtSkVRVGs9")))))))));
					chrome.DelayTime(1.0);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsZFNOVmRXWkZOTlZteFpWVzE0WVZFd2NHcz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayThaoTacNho(0, null);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(2.0);
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlVbUZWZW14dlYxY3dOVTFYVWtKUVZEQTk=")))))))));
					chrome.DelayTime(2.0);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x001BC970 File Offset: 0x001BAB70
		public int ChangeDaiHoc(Chrome chrome, string daiHoc)
		{
			bool flag = false;
			try
			{
				chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlVbUZWZW14dlYxY3dOVTFYVWtKUVZEQTk=")))))))));
				chrome.DelayTime(1.0);
				bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1UyTkhTbGhXYms1b1ZucFdjMVZYTURWaE1sWlNVRlF3UFE9PQ==")))))))), 10.0) == 1;
				if (flag2)
				{
					int num = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExaVlJXY2xkV2FFdGpiRnBJVDFSR1drMXRaREZaYTA1cVkwVjRkR1ZIZUdsaVYxRjNXVlZGT1ZCUlBUMD0="))))))))).ToString());
				}
				int num2 = chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlaR3BpVkd4MFdWWmtOR0pGZDNsV2JYUm9WMFpHTWxsV1l6RmlWMGw2Vlcxb1dtRlViRFpYYkdSUFRVZEdXRTlZVmsxTmJIQXlXVEl3ZUdWcmVEWlBXRTVvVmpGd2MxZEVTbGROYkhCWVRsUkNXVTB3TkhoWk1qRmhZVVpyZVZaVWJHbFhSa295V2taa1QySXhaM3BSYm14cFRXeHdkMWxyWkZaaVYwMTVWbTF3YTFJeWVESlpiVzk0WWtad1NWWnRjRnBYUmtwM1dXcEpNR0pXY0ZsaFNHUmhWMFZ3ZDFkc1l6RmhiSEJYVDFSQ2JGZEZTbk5WUmxKS1pEQXhSVlZVTUQwPQ==")))))))));
				bool flag3 = num2 == -2;
				if (flag3)
				{
					return -2;
				}
				chrome.DelayTime(3.0);
				bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhWRWsxWXpKS1NGWnROV0ZXYW13MlYxUktiMlJ0U1hsa00xSnJVakZaTUZwRlRrTk5SbkJaWVVSQ2FGWjZWak5hUm1oU1lWWm9VbEJVTUQwPQ==")))))))), 10.0) == 1;
				if (flag4)
				{
					chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhWRWsxWXpKS1NGWnROV0ZXYW13MlYxUktiMlJ0U1hsa00xSnJVakZaTUZwRlRrTk5SbkJaWVVSQ2FGWjZWak5hUm1oU1lWWm9VbEJVTUQwPQ==")))))))), daiHoc, 0.1, true, 0.1);
					chrome.DelayThaoTacNho(0, null);
					chrome.SendKeyDown(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhWRWsxWXpKS1NGWnROV0ZXYW13MlYxUktiMlJ0U1hsa00xSnJVakZaTUZwRlRrTk5SbkJaWVVSQ2FGWjZWak5hUm1oU1lWWm9VbEJVTUQwPQ==")))))))));
					chrome.DelayTime(1.0);
					chrome.SendEnter(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBWbTEwYUZkR1JqQlhWRWsxWXpKS1NGWnROV0ZXYW13MlYxUktiMlJ0U1hsa00xSnJVakZaTUZwRlRrTk5SbkJaWVVSQ2FGWjZWak5hUm1oU1lWWm9VbEJVTUQwPQ==")))))))));
					chrome.DelayTime(1.0);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsZFNOVmRXWkZOTlZteFpWVzE0WVZFd2NHcz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayThaoTacNho(0, null);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(2.0);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x001BCEE8 File Offset: 0x001BB0E8
		public int ChangePass(Chrome chrome, string old_pass, string new_pass)
		{
			int num = 0;
			try
			{
				bool flag = !chrome.CheckIsLive();
				if (flag)
				{
					return -2;
				}
				chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFdIQmhWakEwZUZreU1YTk5SMVpVVDFoa1dsZEZOVFphUkVrMVpWWndSRTlFTUQwPQ==")))))))));
				chrome.DelayTime(1.0);
				bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1UxcWJIcFhhMDVMV2tFOVBRPT0=")))))))), 10.0) == 1;
				if (flag2)
				{
					chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1UxcWJIcFhhMDVMV2tFOVBRPT0=")))))))), old_pass, 0.1, true, 0.1);
					chrome.DelayThaoTacNho(0, null);
					chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1UxcVZuTmFTR3hMV2tFOVBRPT0=")))))))), new_pass, 0.1, true, 0.1);
					chrome.DelayThaoTacNho(0, null);
					chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1Uxck5USlpiVEZoWTBkT2RFMUhiRmxWVkRBNQ==")))))))), new_pass, 0.1, true, 0.1);
					chrome.DelayThaoTacNho(0, null);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(5.0);
					num = 1;
					int tickCount = Environment.TickCount;
					for (;;)
					{
						bool flag3 = !chrome.CheckIsLive();
						if (flag3)
						{
							break;
						}
						bool flag4 = Environment.TickCount - tickCount > 20000;
						if (flag4)
						{
							goto Block_7;
						}
						bool flag5 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFjMWw2VGs5alIwbDVUbGRhYUZaNlZYbFhWbVEwWTBad1NGSnFRbWhXZW13eFYwUkpOV1F5VWtoaVNGcHBZbXN4Y0ZkR1JUbFFVVDA5")))))))), 0.0) == 1;
						if (flag5)
						{
							goto Block_8;
						}
					}
					return -2;
					Block_7:
					goto IL_558;
					Block_8:
					chrome.DelayTime(1.0);
					chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NsSnVUbWxSTW1Sd1UxUkplRnBzYTNsaFIzaGFUVzVTYlZsclpITmxiVkpIVDFkb2FtSlhlRzlYUkVvMFlVWnNkRlp1VGtwU1JGSnVXVlpqTVdReVVsbFZWMnhNVm01T05GZEdUVEZoYlVwSVlrZHdhR1ZYWkhjPQ==")))))))));
					chrome.DelayTime(1.0);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczBlRmRYTUhoalIxSkhUMWRvV2sweFNuZFpha2t3WVZab1VsQlVNRDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					IL_558:;
				}
			}
			catch
			{
			}
			bool flag6 = num == 0;
			if (flag6)
			{
				Common.ExportError(chrome, null, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0ak5XTkZiRWRSYldocVRUQXhibFZ0TVVkalIwcENVRlF3UFE9PQ==")))))))));
			}
			return num;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x001BD4F0 File Offset: 0x001BB6F0
		public int ChangeLanguage(Chrome chrome, string country_code)
		{
			bool flag = false;
			try
			{
				chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlUbHBXZWxaMVdrWmtSMkpzY0ZST1dHUm9VMFZGT1E9PQ==")))))))));
				int tickCount = Environment.TickCount;
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				while (Environment.TickCount - tickCount < 10000)
				{
					text = chrome.ExecuteScript(string.Concat(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWxhZW14TFpWZE5NMWxXWkZwaU1YQklUMWR3YTFaNlJuTlpiVFZTWkZad1NFOVhjR3RXZWtaeldXMDFVMUp0U2toV2JsSmhWbnBWZDFSSE1YTmtWMHAwVm01c1ZGSnNTazlXUlUweFkwZEtkRlJ1VG10V01VcHpXVE5zYm1KcmQzbFNXRnBwVWpCYU1WZHFUbGRoUm05NVZsaFdhbEl5YUROVlJFb3pUMUU5UFE9PQ==")))))))),
						country_code,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NtTkZiRWxhZW14TVVUSlNkbHBGYUZOa01rNDJZak5hVFUxcVFqRlhiVEZIWVd4d1dGTnVXbWxOYms0eFYxUkpOV1JGY0RWa1IzUnBUV3MwZUZsc1pGZGtWMUpFVGxkMGFVMXJOSGhaYkdSWFpGZFNSbFp1VG1GV2VrWnpXVzAxVW1SWFJsaE9XRlpoVjBWd1NsWnJWWGhVVlhoMFRWZG9hMUl3TlhaVE1HTXhZa2RTTlZGc1RtRldNbEpIV2xWb1FtSXdjRFZQVjJoTlRXNW9iMWx0TVd0TlZteFlXa2Q0VFdKclNuWlpNRm8wV1RGQmVXUjZhejA9")))))))),
						country_code,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCTk1HTldRalZoTW14TFpWZDBkMVl6Y0VOYVJYUlVUbGhzWVZkRlNucFhWbVJQWWtWMFJGa3liRXRsV0dSMVUyNXNjbVJYVFhwUmJrNW9WMFpHZGxOcVNrZGtSMDVGWXpJMVRGVjZWbmhaYWtwelpGVjBSRmt5TlV4V1NFNXVWMnhrTkdWc2NGUlJhbEpSVlRKT2RWUXpiRU5sVm5CWlZXcEdhbUpVVW01YVZWSjZVRkU5UFE9PQ=="))))))))
					})).ToString();
					bool flag2 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag2)
					{
						chrome.GotoURL(text);
						flag = true;
						break;
					}
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1lXRkhTa2xXYlhoUlZUQnJPUT09")))))))) + country_code + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkM2QxQlJQVDA9")))))))), 0.0) == 1;
					if (flag3)
					{
						bool flag4 = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1lXRkhTa2xXYlhoUlZUQnJPUT09")))))))) + country_code + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkM2QxQlJQVDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
						if (flag4)
						{
							chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNlbGRXWXpGaWJWSllVbTAxWVZWNlZqTlpWV2hDWVZab1VsQlVNRDA9")))))))), 5.0);
							flag = true;
							break;
						}
					}
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x001BD9CC File Offset: 0x001BBBCC
		public int AddPhone(Chrome chrome, string phone, Random rd)
		{
			bool flag = false;
			try
			{
				int num3;
				do
				{
					string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					for (int i = 0; i < phone.Length; i++)
					{
						text2 = phone[i].ToString();
						bool flag2 = text2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xWRk9WQlJQVDA9"))))))));
						if (flag2)
						{
							text2 = rd.Next(0, 10).ToString();
						}
						text += text2;
					}
					bool flag3 = text.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9")))))))));
					if (flag3)
					{
						text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpOd2JrMUJQVDA9")))))))) + text.Substring(1);
					}
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlaR2hTZW13eFYyeGtSMkZ0VGxsV2JrSnFZbFpXTWxWRVRrOWtiVkpaVTIxd1lWWkVSbkZaYWtreFRVWnNXRlJxUW1wU2VteDNXVzAxVTFwdFRYbFdha0pyVWpKNE1WZHFUazVpVm5CWVRsUkNhbUp0ZUcxWk1HTTFZMGRLZFZWVWJHcE5iRmwzV2tWa2MyUldiM3BVVkRBOQ==")))))))));
					bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVTFNbGx0TlZOaFJtdDZWVzFhYWxKNmJIZFpiVFZTWVZab1VsQlVNRDA9")))))))), 10.0) == 1;
					if (!flag4)
					{
						goto IL_50D;
					}
					chrome.DelayTime(1.0);
					chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVTFNbGx0TlZOaFJtdDZWVzFhYWxKNmJIZFpiVFZTWVZab1VsQlVNRDA9")))))))), text, 0.1, true, 0.1);
					chrome.DelayThaoTacNho(0, null);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeFMwMVhVa2xWYmxwcFlUQmFOVmRzWkVaTE1XeDFWbXBDYTFKNmJERT0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(2.0);
					int num = chrome.CheckExistElements(10.0, new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MyUnRTWHBWVjJSUllWVktjbGxXYUZwYU1VSndVVzEwYUZkR2JHNVZSMnhEWVRKR1dWZFhaRkZoVlVweVdWWm9XazV0U25WVmJUbE5WakExZGxsV1pEUmhNSFJGVWxoQ1NsSkVVbTVYYTJSelRXdHNSVTVIWkdGU01uZDU=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtkMWx0YkV0YVFUMDk="))))))))
					});
					int num2 = num;
					num3 = num2;
				}
				while (num3 == 1);
				if (num3 == 2)
				{
					flag = true;
				}
				IL_50D:;
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x001BDF38 File Offset: 0x001BC138
		public int UpAvatar(Chrome chrome, string pathImage, Random rd)
		{
			bool flag = false;
			try
			{
				int num;
				for (;;)
				{
					IL_08:
					chrome.DelayTime(3.0);
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlVbUZWVkRBNQ==")))))))));
					num = chrome.CheckExistElements(20.0, new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmQyUkhVa2hpU0ZKaFZqTm9kMWx0TVZaa1JtdDVUMVJLWVZkRmJEQlpla3BYWVcxU1NHSklXbWxoYWxaeVdWWm9Xa3N4Y0VoaVJFcFJZbFpLZDFwSGNIZGtWMUpJV2pOU1drMXRhSGRaYTJSU1lqQXhjR0Y1ZEZwVlZEQTU=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmQyUkhVa2hpU0ZKaFZqTm9kMWx0TVZaa1JtdDVUMVJLWVZkRmJEQlpla3BYWVcxU1NHSklXbWxoYWxaeVdWWm9Xa3N4Y0VoaVJFcFJZbFpLZDFwSGNIZGtWMUpJV2pOU1drMXRhSGRaYTJSU1lqQXhjR0Y1ZEdGU01uZDVWVWN4UmxCUlBUMD0="))))))))
					});
					bool flag2 = num == -2;
					if (flag2)
					{
						break;
					}
					bool flag3 = num != 0;
					if (!flag3)
					{
						goto IL_92A;
					}
					bool flag4 = num == 1;
					if (flag4)
					{
						chrome.DelayTime(1.0);
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmQyUkhVa2hpU0ZKaFZqTm9kMWx0TVZaa1JtdDVUMVJLWVZkRmJEQlpla3BYWVcxU1NHSklXbWxoYWxaeVdWWm9Xa3N4Y0VoaVJFcFJZbFpLZDFwSGNIZGtWMUpJV2pOU1drMXRhSGRaYTJSU1lqQXhjR0Y1ZEZwVlZEQTU=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					}
					else
					{
						bool flag5 = num == 2;
						if (flag5)
						{
							chrome.DelayTime(1.0);
							chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmQyUkhVa2hpU0ZKaFZqTm9kMWx0TVZaa1JtdDVUMVJLWVZkRmJEQlpla3BYWVcxU1NHSklXbWxoYWxaeVdWWm9Xa3N4Y0VoaVJFcFJZbFpLZDFwSGNIZGtWMUpJV2pOU1drMXRhSGRaYTJSU1lqQXhjR0Y1ZEdGU01uZDVWVWN4UmxCUlBUMD0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						}
					}
					bool flag6 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa2RSYmtKYVRVWndkMWxyWkZkVGJVcDFVV3BHYTFGVU1Eaz0=")))))))), 20.0) == 1;
					if (flag6)
					{
						chrome.DelayTime(3.0);
						chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYwNUdWa2hpUjNCVFlsZDRlbGRzVm5Oa1YwNUpWbXBCUFE9PQ==")))))))), pathImage, false, 0.1);
						chrome.DelayTime(2.0);
						int num2 = 0;
						for (int i = 0; i < 30; i++)
						{
							bool flag7 = Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3Y0RWVWJsWnJWMGRvVWxsV1pFOVNNa1pZWlVkNFZGWjZWak5hUm1oVFdtMU9TVk50ZUd0aVYzaHpXa2hzYW1ORmVIUmFSM2hyVWxWWmQxcEZhRXRqUm14MVZtcENZVlV5WkhWWmVrNVRUbGRLU0ZaWE5VeFZlbFozV1cweFQyTXlVbGhWYlhocVpWZGtkVmRYTVVkaGJVVjVXa2hzYVUweFdqRlhhMDE0WTBkS1dGSnROV0ZWTWs1M1V6TnNhbUpuUFQwPQ=="))))))))));
							if (flag7)
							{
								goto Block_8;
							}
							bool flag8 = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3Y0RWVWJsWnJWMGRvVWxsV1pFOVNNa1pZWlVkNFZGWjZWak5hUm1oU1ltdDBWRTVVU2xwV00yZDRWMnhPZW1KcmNETlFWREE5"))))))))).ToString() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag8)
							{
								chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYwNUdWa2hpUjNCVFlsZDRlbGRzVm5Oa1YwNUpWbXBCUFE9PQ==")))))))), pathImage, false, 0.1);
								chrome.DelayTime(2.0);
							}
							else
							{
								num2++;
								bool flag9 = num2 == 3;
								if (flag9)
								{
									goto IL_08;
								}
							}
						}
						goto IL_928;
					}
					goto IL_929;
				}
				return -2;
				Block_8:
				chrome.DelayTime(1.0);
				num = chrome.CheckExistElements(10.0, new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa2RXYm1ScFVucHNiMWRyV2tOaU1rbDZWVzVhVW1Kc1dYZGFSV00xWkZaQ2RGTnFSbXRUUmtveVdXMWpPVkJSUFQwPQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa2RXYm1ScFVucHNiMWRyV2tOaU1rbDZWVzVhVW1Kc1dYZGFSV00xWkZaQ2RGVnVRbXRoYWxad1drWm9VMDFIU1hsT1JEQTk="))))))))
				});
				int num3 = num;
				int num4 = num3;
				if (num4 != 1)
				{
					if (num4 != 2)
					{
						Common.ExportError(chrome, null, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwSk5Gb3lVbGxSVjJSaFUwWmFNbGRZYkVOaFIxSjBVbXBDV2xkRmF6az0=")))))))));
					}
					else
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa2RXYm1ScFVucHNiMWRyV2tOaU1rbDZWVzVhVW1Kc1dYZGFSV00xWkZaQ2RGVnVRbXRoYWxad1drWm9VMDFIU1hsT1JEQTk=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					}
				}
				else
				{
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa2RXYm1ScFVucHNiMWRyV2tOaU1rbDZWVzVhVW1Kc1dYZGFSV00xWkZaQ2RGTnFSbXRUUmtveVdXMWpPVkJSUFQwPQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
				}
				bool flag10 = chrome.WaitForSearchElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa2RXYm1ScFVucHNiMWRyV2tOaU1rbDZWVzVhVW1Kc1dYZGFSV00xWkZaQ2RGVnVRbXRoYWxad1drWm9VMDFIU1hsT1JEQTk=")))))))), 1, 20.0) == 1;
				if (flag10)
				{
					chrome.DelayTime(1.0);
					flag = true;
				}
				IL_928:
				IL_929:
				IL_92A:;
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x001BE8C0 File Offset: 0x001BCAC0
		public int UpCover(Chrome chrome, string pathImage, Random rd)
		{
			bool flag = false;
			try
			{
				chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlVbUZWVkRBNQ==")))))))));
				chrome.DelayTime(2.0);
				bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmQyUkhVa2hpU0ZKaFZqTm9kMWx0TVZaa1JtdDVUMVJLWVZkRmJEQlpla3BYWVcxU1NHSklXbWxoVlVWeVUxVmtVMk5IVW5CUlUzUktVakZLZDFwSGNIZGtWMUpJV2pOU1drMXRhSGRaYTJSU1lqQXhWR0V5WkZGaFZVcHlXVlpvV2xveFFuQlJiWFJvVjBac2JsVkhiRU5oUVQwOQ==")))))))), 20.0) == 1;
				if (flag2)
				{
					chrome.DelayTime(1.0);
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmQyUkhVa2hpU0ZKaFZqTm9kMWx0TVZaa1JtdDVUMVJLWVZkRmJEQlpla3BYWVcxU1NHSklXbWxoVlVWeVUxVmtVMk5IVW5CUlUzUktVakZLZDFwSGNIZGtWMUpJV2pOU1drMXRhSGRaYTJSU1lqQXhWR0V5WkZGaFZVcHlXVlpvV2xveFFuQlJiWFJvVjBac2JsVkhiRU5oUVQwOQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(1.0);
					int num = chrome.CheckExistElements(20.0, new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmVHUnNjRWhTYms1VFVqSjRiMWxyWXpWaWJGcDBZa2Q0YTJWVlJYSlRWV1JUWTBkU2NGRlRkRXBTTVVwM1drZHdkMlJYVWtoYU0xSmFUVzFvZDFsclpGSmlNREZVWVRKa1VXRlZTbkpaVm1oYVdqRkNjRkZ0ZEdoWFJteHVWVWRzUTJGQlBUMD0=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa2RSYmtKYVRVWndkMWxyWkZkVGJVcDFVV3BHYTFGVU1Eaz0="))))))))
					});
					bool flag3 = num == 1;
					if (flag3)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmVHUnNjRWhTYms1VFVqSjRiMWxyWXpWaWJGcDBZa2Q0YTJWVlJYSlRWV1JUWTBkU2NGRlRkRXBTTVVwM1drZHdkMlJYVWtoYU0xSmFUVzFvZDFsclpGSmlNREZVWVRKa1VXRlZTbkpaVm1oYVdqRkNjRkZ0ZEdoWFJteHVWVWRzUTJGQlBUMD0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa2RSYmtKYVRVWndkMWxyWkZkVGJVcDFVV3BHYTFGVU1Eaz0=")))))))), 10.0) == 1;
					if (flag4)
					{
						chrome.DelayTime(1.0);
						chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYwNUdWa2hpUjNCVFlsZDRlbGRzVm5Oa1YwNUpWbXBCUFE9PQ==")))))))), pathImage, true, 0.1);
						chrome.DelayTime(5.0);
						bool flag5 = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa2RXYm1ScFVucHNiMWRyV2tOaU1rbDZWVzVhVW1Kc1dYZGFSV00xWkZWc1NGTnFSbXRUUmtveVdXMWpPVkJSUFQwPQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) != 1;
						if (flag5)
						{
							chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVXBOYWxWNFdsVmFWMlF5U2toUFYyaGhVbXRLZGxscVRsTmtiRVoxVm1wQ2ExSjZiREZUVldSTFRWZFNTVlZ1V21saFYwNTNWRWN4VDJNeVJsaFVia3BNVVRKek9RPT0=")))))))));
						}
						bool flag6 = chrome.WaitForSearchElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa2RXYm1ScFVucHNiMWRyV2tOaU1rbDZWVzVhVW1Kc1dYZGFSV00xWkZWc1NGTnFSbXRUUmtveVdXMWpPVkJSUFQwPQ==")))))))), 1, 20.0) == 1;
						if (flag6)
						{
							chrome.DelayTime(1.0);
							flag = true;
						}
					}
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x001BEEFC File Offset: 0x001BD0FC
		public int UpCoverNgheThuat(Chrome chrome, Random rd)
		{
			bool flag = false;
			try
			{
				chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFUk9RMkl5U1hwVmJscHFaVlJzY1ZsVlpFZGtWbTk1VmxoYVdrMXFhM2xYYkdoTFdtMU9TR0ZJV210U2VtZ3lWVVJPUTJJeVNYcFZibHBaVFRGSk1Wa3daRlpQVm14WlUycENhMDFxYkRWWlZFVTFaREpHU0U5VVFtbE5NREE1")))))))));
				bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MyUnRTWHBWVjJSUllWVkpkMWRXWkV0ak1YQlVVVk4wU2xOR1NuQlpha3BUVGxWc1JVNUhaR3RUUld4dVZVZHNRMDFHY0VSUlUzUktVakZLZDFwSGJFSkxNR3hJVlc1Q2EyRlZSWEpUVldSVFkwZFNjRkZUZEVwVFJUVXpWMVpqTUZveFFuQlJiV2M5")))))))), 10.0) == 1;
				if (flag2)
				{
					int num = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExaVlUxTlZscVNUVk5SV3hGVGtka2ExSXdXbkJaYTJSV1dqRkNjRkZxUWxwaVZHeHlXbFpPUWtzd2JFbFZibXhLVWtSU2JscEZaRkphTVVKd1VXMTBhRmRHYkc1VlIyeERZVEpHV1ZkWFpGRmhWVXB5V1Zab1dsb3hRbkJSYm5CcVVqQmFNVk5WVVRCYU1XeFVXVE5DVFdKWWFITlpiVEZyVFVkR1JHTXlOVXRrZWpBNQ=="))))))))).ToString());
					bool flag3 = num > 0;
					if (flag3)
					{
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NsSnVUbWxSTW1SMVUxUk9TMlJ0U1hwVlYyUlJZVlZKZDFkV1pFdGpNWEJVVVZOMFNsTkdTbkJaYWtwVFRsVnNSVTVIWkd0VFJXeHVWVWRzUTAxR2NFUlJVM1JLVWpGS2QxcEhiRUpMTUd4SVZXNUNhMkZWUlhKVFZXUlRZMGRTY0ZGVGRFcFRSVFV6VjFaak1Gb3hRbkJSYldoTFpWZDRhUT09")))))))) + rd.Next(0, num).ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBaTk1XRnRTa2hpUjNCb1pWZGtkdz09")))))))));
						chrome.DelayTime(1.0);
						bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MyUnRTWHBWVjJSUllWVkpkMWRXWkV0ak1YQlVVVk4wU2xOR1NuQlpha3BUVGxWc1JVNUhaR3RUUld4dVZVZHNRMDFHY0VSUlUzUktVakZLZDFwSGJFSkxNR3hJVlc1Q2EyRlZSWEpUVldSVFkwZFNjRkZUZEVwU01VcDNXa2RzUWtzd2JFaFhibHBxWWxSQ2JsVkhiRU5oTWtaWlYxZGtVV0ZWU25kWmJUVkRUVmRTUWxCVU1EMD0=")))))))), 10.0) == 1;
						if (flag4)
						{
							chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MyUnRTWHBWVjJSUllWVkpkMWRXWkV0ak1YQlVVVk4wU2xOR1NuQlpha3BUVGxWc1JVNUhaR3RUUld4dVZVZHNRMDFHY0VSUlUzUktVakZLZDFwSGJFSkxNR3hJVlc1Q2EyRlZSWEpUVldSVFkwZFNjRkZUZEVwU01VcDNXa2RzUWtzd2JFaFhibHBxWWxSQ2JsVkhiRU5oTWtaWlYxZGtVV0ZWU25kWmJUVkRUVmRTUWxCVU1EMD0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						}
						chrome.DelayTime(2.0);
						flag = true;
					}
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x001BF288 File Offset: 0x001BD488
		public int ChangeTieuSu(Chrome chrome, string tieuSu, bool isPostWall = true)
		{
			bool flag = false;
			try
			{
				chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFUk9RMlZYU1hsWGJrSnBVakZXTWxkWE1VZGxiVVpZVkZoYWFGWjZWWGRaTWpBMFpHeHNkR0pJV2sxbGFtdzFWMnhrWVdOR2NFVk5TR2hQWkhvd09RPT0=")))))))));
				bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVndkMWx1YkV0YVFUMDk=")))))))), 10.0) == 1;
				if (flag2)
				{
					chrome.ClearText(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVndkMWx1YkV0YVFUMDk=")))))))));
					tieuSu = tieuSu.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWb1Mxa3lTbTVRVkRBOQ==")))))))));
					chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYWxadldXeGtWazlWYkhSVGJrSnBaVlZ3YTFOdWJISmtWMUowVW01T2ExWXhWVFZUVjJNNVVGRTlQUT09")))))))) + tieuSu + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))));
					if (isPostWall)
					{
						chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1YyRlhTa2hpU0hCb1VtcHJkMWxxUlRWaVZuQllWbTF6UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag3 = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1lXRkhTa2hpUnpWcFlXcENjRnBGWXpWa01HeHpUVU4wYUZaNlZqTmFSbWhTVUZFOVBRPT0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) != 1;
					if (flag3)
					{
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOTVhCdldXdGtjMkp0U25GTlIyeHJVbnBzTTFOWGQzZExNa1pZVGxoa2ExZEdSblZUTVUweFlXMUtTR0pIY0dobFYyUjM=")))))))));
					}
					chrome.DelayTime(2.0);
					flag = true;
				}
			}
			catch
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x001BF740 File Offset: 0x001BD940
		public int ChangeName(Chrome chrome, string hoTen, string password)
		{
			int result = 0;
			try
			{
				chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFYyaGFUV3MxTWxwR1l6Rk5SWGcyVDFoV1dsWjZSbk09")))))))));
				int num = chrome.CheckExistElements(20.0, new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkbGRzWkRSa01IZzJVbGhvVG1GclZYZFViWEJxWkRBMVZWWlljRkJTUmxWNlZHMXNTMXBCUFQwPQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkbGRzWkRSa01IZzJWVlJDVUZKR1ZqTlViRkphVGtVMVZWTllaRTlXUjJRMFZGaHNTMXBCUFQwPQ=="))))))))
				});
				bool flag = num == 1;
				if (flag)
				{
					string[] array = hoTen.Split(new char[]
					{
						' '
					});
					int num2 = array.Length;
					string content = array[0];
					string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					string content2 = array[num2 - 1];
					bool flag2 = num2 > 2;
					if (flag2)
					{
						for (int i = 1; i < num2 - 1; i++)
						{
							text = text + array[i] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9"))))))));
						}
					}
					text = text.Trim();
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtOVmxXWTNoaFIwNTFZa2RhYVZJd1dqWmFSVmsxWkZac1dFMVhlRXBpUkVFNQ==")))))))), 10.0) == 1;
					if (flag3)
					{
						chrome.DelayTime(1.0);
						string b = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3YjNoa1NGWmFWbnBHYzFWR1RrdGtNazUwWWtoU1dsZEZiekZYUkVvMFlVZE5lbFZ0V21saVZWb3dWMnhPUzFwRmNEVmhNMVpyWWxWYWVscEdaRlpRVVQwOQ=="))))))))).ToString();
						chrome.ClearText(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtOVmxXWTNoaFIwNTFZa2RhYVZJd1dqWmFSVmsxWkZac1dFMVhlRXBpUkVFNQ==")))))))));
						chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtOVmxXWTNoaFIwNTFZa2RhYVZJd1dqWmFSVmsxWkZac1dFMVhlRXBpUkVFNQ==")))))))), content, 0.1, true, 0.1);
						chrome.DelayTime(1.0);
						chrome.ClearText(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtOVmxXWTNoaFIwNTFZa2RhYVZZeWVISlhhMlEwWWtabmVVNVhhR2xXTVZad1YwWkZPVkJSUFQwPQ==")))))))));
						bool flag4 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag4)
						{
							chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtOVmxXWTNoaFIwNTFZa2RhYVZZeWVISlhhMlEwWWtabmVVNVhhR2xXTVZad1YwWkZPVkJSUFQwPQ==")))))))), text, 0.1, true, 0.1);
						}
						chrome.DelayTime(1.0);
						chrome.ClearText(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtOVmxXWTNoaFIwNTFZa2RhWVdKWGVEVlplazVUV20xS2RGSnVVbUZWTUhCcg==")))))))));
						chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtOVmxXWTNoaFIwNTFZa2RhWVdKWGVEVlplazVUV20xS2RGSnVVbUZWTUhCcg==")))))))), content2, 0.1, true, 0.1);
						chrome.DelayTime(2.0);
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(5.0);
						bool flag5 = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3YjNoa1NGWmFWbnBHYzFWR1RrdGtNazUwWWtoU1dsZEZiekZYUkVvMFlVZE5lbFZ0V21saVZWb3dWMnhPUzFwRmNEVmhNMVpyWWxWYWVscEdaRlpRVVQwOQ=="))))))))).ToString() == b;
						if (flag5)
						{
							return 2;
						}
						int num3 = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExaVlUxTUZSR2FFOWlSMUpKVlc1Q2FXSlhValpVUm1SaFpHMU9kRTFIWkZGaFZVcHlXVlpvV2s1dFNuVlZiVGxOVmpBMWRsbFdaRFJoTUhSRlZWaENVV0pXY0hkWGJHUTBZVEpOZVZacVFsRmlXR2h2VjFjeFYyTXdjRFZoTTFacFVqRmFNVmRxVGxOaWR6MDk="))))))))).ToString());
						for (int j = 0; j < num3; j++)
						{
							string b2 = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3Y0RWVWJsSk5WMFUxYzFwRmFGTmpSMHAwV2tod1RWWXhjREpaTWpCM1dqRkNjRkZ0ZEdoWFJtc3lXVzAxVTJJd2VGaFViVGxvVmpOb2NsTXdVbEpqUmtKMFYyNUNZVll6YUhKWmVrcFhUVVpDZEdWSGFGcGlWbHA2VkRJd01VMUhSa1JOVjNCb1VqSjRlbGRyVG01UVVUMDk=")))))))) + (j + 1).ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGUk1XRXlSbGxYVTNSaFVqSjNlVlZITlU5a01XeFlUa2MxVEZWNlZuZFpiVEF4WWtkT2MxVnRlR3hUUmtVNQ=="))))))))).ToString();
							bool flag6 = hoTen == b2;
							if (flag6)
							{
								chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmQyUkhUWGxXYWtKclVqSjRNVmRxVGs1a1JuQjBUMWhzYVZVd1JYSlRWV1JUWTBkU2NXTklWbXRTTW1Rd1YxUktiMk5IU2toVlZ6bFBVVEp6Y2xkdE1YTmlSMHBJVlc1d1lWZEdSWEpaYTJSSFlWWndXR1I2V21saWJFcDJWRVprVDJJeVJsaGxSM1JNVVZRd09RPT0=")))))))) + (j + 1).ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGUk1XRXlSbGxYVTNSaFVqSjNlVlF5TURGTlIwWkVUVmR3YUZJeWVIcFhhMDV1WlZWMFZVNVlRbWxpYTBsNFdrVkZPVkJSUFQwPQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
								break;
							}
						}
						bool flag7 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZkYWJVNUlVbTV3YWsweVVqSlpNakZTWVZab1VsQlVNRDA9")))))))), 10.0) == 1;
						if (flag7)
						{
							chrome.DelayTime(1.0);
							chrome.SendKeys(Base.rd, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZkYWJVNUlVbTV3YWsweVVqSlpNakZTWVZab1VsQlVNRDA9")))))))), password, 0.1, true, 0.1);
							chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFiMXBITVZaaFZtaFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							chrome.DelayTime(2.0);
						}
						result = 1;
					}
				}
				else
				{
					bool flag8 = num == 2;
					if (flag8)
					{
						return 0;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x001C030C File Offset: 0x001BE50C
		private void btnPause_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.isStop = true;
				this.btnPause.Enabled = false;
				this.btnPause.Text = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SaFZGZEdNMlZyYkVOa1ZuQTFUa2hXVFZwNk1Eaz0=")))))))));
			}
			catch
			{
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x001C03C4 File Offset: 0x001BE5C4
		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				Common.CreateFolder(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWN4V2xZeWVIbz0=")))))))));
				Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWN4V2xZeWVIbz0=")))))))));
			}
			catch
			{
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x001C0494 File Offset: 0x001BE694
		public static byte[] BitmapToByte2(Bitmap bm)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bm.Save(memoryStream, ImageFormat.Png);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x001C04EC File Offset: 0x001BE6EC
		private void WriteFile(int row, int type)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				text = string.Concat(new string[]
				{
					text,
					DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
					DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
					DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ=="))))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
					DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))))
				});
				switch (type)
				{
				case 1:
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0ak5XTkdWa2hTYm5CcVRWWktkbGRXYUZOUk1XeFlZVE5XYTFOSFozYz0="))))))));
					break;
				case 2:
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2IySkhTbFpOVjJob1ZqTm9WbGxWWkVkTlJrWjBVbTVDVFdKc1NUQmFSVVU1VUZFOVBRPT0="))))))));
					break;
				case 3:
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSS1IyTkdWa2hTYm5CcVpWUlZkMXBWYUZKUVVUMDk="))))))));
					break;
				case 4:
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGVFRGTlIxWkpWVlF3UFE9PQ=="))))))));
					break;
				case 5:
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWak5XTkZlSFZWYWxKclVWUXdPUT09"))))))));
					break;
				}
				object obj = this.lock1;
				lock (obj)
				{
					File.AppendAllText(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWN4V2xZeWVIcFhSVVU1VUZFOVBRPT0=")))))))) + @string, text);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x001C0ADC File Offset: 0x001BECDC
		private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				this.dtgvAcc.CurrentRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = !Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
				this.UpdateSelectCountRecord();
			}
			catch
			{
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x001C0BFC File Offset: 0x001BEDFC
		public static string GetPhoneTextNow(string apikey, int timeOut = 60)
		{
			object[] parameters = new object[]
			{
				apikey,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3885136, 2768, 1921, parameters);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x001C0C54 File Offset: 0x001BEE54
		public static string GetOTPTextNow(string apikey, string id_order, int timeOut = 120)
		{
			object[] parameters = new object[]
			{
				apikey,
				id_order,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3887904, 1920, 1922, parameters);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x001C0CBC File Offset: 0x001BEEBC
		public static string GetPhoneOtpSim(string apikey, int service_id = 7, int timeOut = 60)
		{
			object[] parameters = new object[]
			{
				apikey,
				service_id,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3889824, 2576, 1923, parameters);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x001C0D24 File Offset: 0x001BEF24
		public static string GetOTPOtpSim(string apikey, string id_order, int timeOut = 120)
		{
			object[] parameters = new object[]
			{
				apikey,
				id_order,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3892400, 1856, 1924, parameters);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x001C0D8C File Offset: 0x001BEF8C
		public static string GetPhoneSimCode(string apikey, int service_id = 1001, int timeOut = 60)
		{
			object[] parameters = new object[]
			{
				apikey,
				service_id,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3894256, 2176, 1925, parameters);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x001C0DF4 File Offset: 0x001BEFF4
		public static string GetOTPSimCode(string apikey, string id_order, int timeOut = 120)
		{
			object[] parameters = new object[]
			{
				apikey,
				id_order,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3896432, 1856, 1926, parameters);
		}

		// Token: 0x04000DDB RID: 3547
		private Random rd = new Random();

		// Token: 0x04000DDC RID: 3548
		private bool isStop = false;

		// Token: 0x04000DDD RID: 3549
		public static bool isAdd;

		// Token: 0x04000DDE RID: 3550
		private JSON_Settings settings;

		// Token: 0x04000DDF RID: 3551
		private JSON_Settings setting_general;

		// Token: 0x04000DE0 RID: 3552
		private JSON_Settings settingg;

		// Token: 0x04000DE1 RID: 3553
		private object k = new object();

		// Token: 0x04000DE2 RID: 3554
		private List<int> lstPossition = new List<int>();

		// Token: 0x04000DE3 RID: 3555
		private List<Thread> lstThread = null;

		// Token: 0x04000DE4 RID: 3556
		private Queue<string> lstProxyTinsoft = new Queue<string>();

		// Token: 0x04000DE5 RID: 3557
		private Queue<string> lstXproxy = new Queue<string>();

		// Token: 0x04000DE6 RID: 3558
		private Queue<string> lstUid = new Queue<string>();

		// Token: 0x04000DE7 RID: 3559
		private string pathFolderAvatar = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x04000DE8 RID: 3560
		private string pathFolderCover = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x04000DE9 RID: 3561
		private string pathFolderTieuSu = Path.GetDirectoryName(Application.ExecutablePath) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1QyUnRTblJYYmtKaFRUQTFjVmxWWkVka1ZtOTVWbTFPYTFJeWVITmFSbWhQVFZFOVBRPT0="))))))));

		// Token: 0x04000DEA RID: 3562
		private string pathFolderThongTinCaNhan = Path.GetDirectoryName(Application.ExecutablePath) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1QyUnRTblJYYmtKaFRUQTFjVmxWWkVka1ZtOTVWbTFPYTFJeWFESlpiVEZyVFVkR1dFNVhjRnBXZWxaMlYxWmpNRkJSUFQwPQ=="))))))));

		// Token: 0x04000DEB RID: 3563
		private string pathFileHo = Path.GetDirectoryName(Application.ExecutablePath) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1QyUnRTblJYYmtKaFRUQTFjVmxWWkVka1ZtOTVWbTFPWVZKNmJIZGFSV1JYWkZab1NHRklXazFpYkVrd1drVkZPVkJSUFQwPQ=="))))))));

		// Token: 0x04000DEC RID: 3564
		private string pathFileTenDem = Path.GetDirectoryName(Application.ExecutablePath) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1QyUnRTblJYYmtKaFRUQTFjVmxWWkVka1ZtOTVWbTFPWVZKNmJIZGFSV1JYWkZab1NWVnRlR2xpVmtweldXeE5NVTFIVmtsVlZEQTk="))))))));

		// Token: 0x04000DED RID: 3565
		private string pathFileTen = Path.GetDirectoryName(Application.ExecutablePath) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1QyUnRTblJYYmtKaFRUQTFjVmxWWkVka1ZtOTVWbTFPWVZKNmJIZGFSV1JYWkZab1NWVnRlR2xoVkZWM1dsVm9VbEJSUFQwPQ=="))))))));

		// Token: 0x04000DEE RID: 3566
		private string pathFileMatKhau = Path.GetDirectoryName(Application.ExecutablePath) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1QyUnRTblJYYmtKaFRUQTFjVmxWWkVka1ZtOTVWbTFPWVZKNmJIZFpiR1I2WkZkU1NXRkVRVDA9"))))))));

		// Token: 0x04000DEF RID: 3567
		private List<string> lstHo = new List<string>();

		// Token: 0x04000DF0 RID: 3568
		private List<string> lstTenDem = new List<string>();

		// Token: 0x04000DF1 RID: 3569
		private List<string> lstTen = new List<string>();

		// Token: 0x04000DF2 RID: 3570
		private List<string> lstTenRandom = new List<string>();

		// Token: 0x04000DF3 RID: 3571
		private List<string> lstPassword = new List<string>();

		// Token: 0x04000DF4 RID: 3572
		private List<string> lstNoiLamViec = new List<string>();

		// Token: 0x04000DF5 RID: 3573
		private List<string> lstNoiLamViecTemp = new List<string>();

		// Token: 0x04000DF6 RID: 3574
		private List<string> lstQueQuan = new List<string>();

		// Token: 0x04000DF7 RID: 3575
		private List<string> lstQueQuanTemp = new List<string>();

		// Token: 0x04000DF8 RID: 3576
		private List<string> lstThanhPho = new List<string>();

		// Token: 0x04000DF9 RID: 3577
		private List<string> lstThanhPhoTemp = new List<string>();

		// Token: 0x04000DFA RID: 3578
		private List<string> lstTruongDH = new List<string>();

		// Token: 0x04000DFB RID: 3579
		private List<string> lstTruongDHTemp = new List<string>();

		// Token: 0x04000DFC RID: 3580
		private List<string> lstTruongTHPT = new List<string>();

		// Token: 0x04000DFD RID: 3581
		private List<string> lstTruongTHPTTemp = new List<string>();

		// Token: 0x04000DFE RID: 3582
		private List<string> lstMailAdd = new List<string>();

		// Token: 0x04000DFF RID: 3583
		private List<string> lstMailVerify = new List<string>();

		// Token: 0x04000E00 RID: 3584
		private List<string> lstMailLoi = new List<string>();

		// Token: 0x04000E01 RID: 3585
		private List<string> lstPathFileTieuSu = new List<string>();

		// Token: 0x04000E02 RID: 3586
		private List<string> lstPathFileTieuSuTemp = new List<string>();

		// Token: 0x04000E03 RID: 3587
		private List<string> lstPathFolderAvatar = new List<string>();

		// Token: 0x04000E04 RID: 3588
		private List<string> lstPathFolderAvatarTemp = new List<string>();

		// Token: 0x04000E05 RID: 3589
		private List<string> lstPathFolderCover = new List<string>();

		// Token: 0x04000E06 RID: 3590
		private List<string> lstPathFolderCoverTemp = new List<string>();

		// Token: 0x04000E07 RID: 3591
		private List<string> lstPathImage = new List<string>();

		// Token: 0x04000E08 RID: 3592
		private List<TinsoftProxy> listTinsoft = null;

		// Token: 0x04000E09 RID: 3593
		private List<XproxyProxy> listxProxy = null;

		// Token: 0x04000E0A RID: 3594
		private List<TMProxy> listTMProxy = null;

		// Token: 0x04000E0B RID: 3595
		private List<ProxyWeb> listProxyWeb = null;

		// Token: 0x04000E0C RID: 3596
		private List<ShopLike> listShopLike = null;

		// Token: 0x04000E0D RID: 3597
		private List<MinProxy> listMinProxy = null;

		// Token: 0x04000E0E RID: 3598
		private List<string> listApiTinsoft = null;

		// Token: 0x04000E0F RID: 3599
		private List<string> listProxyXproxy = null;

		// Token: 0x04000E10 RID: 3600
		private List<string> listProxyTMProxy = null;

		// Token: 0x04000E11 RID: 3601
		private List<string> listProxyProxyv6 = null;

		// Token: 0x04000E12 RID: 3602
		private List<string> listProxyShopLike = null;

		// Token: 0x04000E13 RID: 3603
		private List<string> listProxyMinProxy = null;

		// Token: 0x04000E14 RID: 3604
		private object lock_StartProxy = new object();

		// Token: 0x04000E15 RID: 3605
		private object lock_FinishProxy = new object();

		// Token: 0x04000E16 RID: 3606
		private object lock1 = new object();
	}
}
