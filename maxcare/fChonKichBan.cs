using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x020000EA RID: 234
	public partial class fChonKichBan : Form
	{
		// Token: 0x0600096F RID: 2415 RVA: 0x0019491C File Offset: 0x00192B1C
		public fChonKichBan()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVVZucFZkMWRzYUV0aFJtdDZWV3RvWVZaNlZuTlpNakZIWTNjOVBRPT0=")))))))), false);
			this.ChangeLanguage();
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00194998 File Offset: 0x00192B98
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.label2);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.label1);
			Language.GetValue(this.label7);
			Language.GetValue(this.btnSave);
			Language.GetValue(this.btnCancel);
			foreach (object obj in this.dtgvKichBan.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
			foreach (object obj2 in this.dtgvKichBanChoose.Columns)
			{
				DataGridViewColumn control2 = (DataGridViewColumn)obj2;
				Language.GetValue(control2);
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00194B00 File Offset: 0x00192D00
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			this.LoadKichBan(null);
			this.LoadKichBan(this.settings.GetValueList(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0b1QwMUdUbGhWYTNob1ZqQTFkbFZYTVVka1VUMDk=")))))))), 0));
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00194B84 File Offset: 0x00192D84
		private void LoadKichBan(List<string> lstIdKichBan = null)
		{
			try
			{
				bool flag = lstIdKichBan != null && lstIdKichBan.Count > 0;
				if (flag)
				{
					this.dtgvKichBanChoose.Rows.Clear();
					for (int i = 0; i < lstIdKichBan.Count; i++)
					{
						DataTable kichBanById = InteractSQL.GetKichBanById(lstIdKichBan[i]);
						bool flag2 = kichBanById.Rows.Count > 0;
						if (flag2)
						{
							DataRow dataRow = kichBanById.Rows[0];
							this.dtgvKichBanChoose.Rows.Add(new object[]
							{
								this.dtgvKichBanChoose.RowCount + 1,
								dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))],
								dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))]
							});
						}
					}
				}
				else
				{
					this.dtgvKichBan.Rows.Clear();
					DataTable allKichBan = InteractSQL.GetAllKichBan();
					bool flag3 = allKichBan.Rows.Count > 0;
					if (flag3)
					{
						for (int j = 0; j < allKichBan.Rows.Count; j++)
						{
							DataRow dataRow2 = allKichBan.Rows[j];
							this.dtgvKichBan.Rows.Add(new object[]
							{
								j + 1,
								dataRow2[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))],
								dataRow2[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))]
							});
						}
					}
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00194F0C File Offset: 0x0019310C
		public void DoiChoDgv(ref DataGridView dgv, int oldRow, int newRow)
		{
			string status = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			for (int i = 1; i < dgv.Columns.Count; i++)
			{
				status = DatagridviewHelper.GetStatusDataGridView(dgv, oldRow, i);
				DatagridviewHelper.SetStatusDataGridView(dgv, oldRow, i, DatagridviewHelper.GetStatusDataGridView(dgv, newRow, i));
				DatagridviewHelper.SetStatusDataGridView(dgv, newRow, i, status);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00194FAC File Offset: 0x001931AC
		private void button2_Click(object sender, EventArgs e)
		{
			int index = this.dtgvKichBanChoose.SelectedRows[0].Index;
			bool flag = index == 0;
			if (!flag)
			{
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBanChoose, index - 1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhUWGxpUjNCb1VsVndiMWx0ZEU5aU1rbDVUMWh3WVZWVU1Eaz0=")))))))));
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBanChoose, index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhUWGxpUjNCb1VsVndiMWx0ZEU5aU1rbDVUMWh3WVZWVU1Eaz0=")))))))));
				bool flag2 = statusDataGridView + statusDataGridView2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag2)
				{
					this.DoiChoDgv(ref this.dtgvKichBanChoose, index, index - 1);
					this.dtgvKichBanChoose.Rows[index - 1].Selected = true;
				}
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00195144 File Offset: 0x00193344
		private void button3_Click(object sender, EventArgs e)
		{
			int index = this.dtgvKichBanChoose.SelectedRows[0].Index;
			bool flag = index == this.dtgvKichBanChoose.RowCount - 1;
			if (!flag)
			{
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBanChoose, index + 1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhUWGxpUjNCb1VsVndiMWx0ZEU5aU1rbDVUMWh3WVZWVU1Eaz0=")))))))));
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBanChoose, index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhUWGxpUjNCb1VsVndiMWx0ZEU5aU1rbDVUMWh3WVZWVU1Eaz0=")))))))));
				bool flag2 = statusDataGridView + statusDataGridView2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag2)
				{
					this.DoiChoDgv(ref this.dtgvKichBanChoose, index, index + 1);
					this.dtgvKichBanChoose.Rows[index + 1].Selected = true;
				}
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x001952F0 File Offset: 0x001934F0
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			bool flag = this.panel1.BorderStyle == BorderStyle.FixedSingle;
			if (flag)
			{
				int num = 1;
				int num2 = num / 2;
				using (Pen pen = new Pen(Color.DarkViolet, (float)num))
				{
					e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, this.panel1.ClientSize.Width - num, this.panel1.ClientSize.Height - num));
				}
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x001953B4 File Offset: 0x001935B4
		private bool CheckTrung(string id)
		{
			bool result = false;
			for (int i = 0; i < this.dtgvKichBanChoose.RowCount; i++)
			{
				bool flag = id == this.dtgvKichBanChoose.Rows[i].Cells[1].Value.ToString();
				if (flag)
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00195450 File Offset: 0x00193650
		private void dtgvKichBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int num = Convert.ToInt32(this.dtgvKichBan.SelectedRows[0].Cells[1].Value);
			string text = this.dtgvKichBan.SelectedRows[0].Cells[2].Value.ToString();
			bool flag = !this.CheckTrung(num.ToString());
			if (flag)
			{
				this.dtgvKichBanChoose.Rows.Add(new object[]
				{
					this.dtgvKichBanChoose.RowCount + 1,
					num,
					text
				});
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00195540 File Offset: 0x00193740
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.dtgvKichBanChoose.Rows.RemoveAt(this.dtgvKichBanChoose.SelectedRows[0].Index);
			for (int i = 0; i < this.dtgvKichBanChoose.RowCount; i++)
			{
				DatagridviewHelper.SetStatusDataGridView(this.dtgvKichBanChoose, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QxWldXa1pVYlRscFRXcHNObGRzUlRsUVVUMDk=")))))))), i + 1);
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00195614 File Offset: 0x00193814
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				for (int i = 0; i < this.dtgvKichBanChoose.RowCount; i++)
				{
					list.Add(DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBanChoose, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhUWGxpUjNCb1VsVndiMWx0ZEU5aU1rbDVUMWh3WVZWVU1Eaz0="))))))))));
				}
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0b1QwMUdUbGhWYTNob1ZqQTFkbFZYTVVka1VUMDk=")))))))), list);
				this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				base.Close();
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGxyT1VoT01uZDVZVEprYkZRd1l6SmllazV5V2pKT2RGSllUa3BUUm05NFdWWk9RMk16WXpOVGJsWmhaVlZKZDFsVk9VaE9NMHBVVVc1Tk1GbHVSbTlaVms1RFpXeHNXVlpYWnowPQ=="))))))))), 3);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00195844 File Offset: 0x00193A44
		private void dtgvKichBanChoose_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.lblCountAcc.Text = this.dtgvKichBanChoose.RowCount.ToString();
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00195844 File Offset: 0x00193A44
		private void dtgvKichBanChoose_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.lblCountAcc.Text = this.dtgvKichBanChoose.RowCount.ToString();
		}

		// Token: 0x04000D85 RID: 3461
		private JSON_Settings settings;
	}
}
