using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x0200008B RID: 139
	public partial class fChonThuMuc : Form
	{
		// Token: 0x06000528 RID: 1320 RVA: 0x00002A97 File Offset: 0x00000C97
		public fChonThuMuc(bool isFromBin = false)
		{
			this.InitializeComponent();
			fChonThuMuc.isAdd = false;
			this.isFromBin = isFromBin;
			this.ChangeLanguage();
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00092244 File Offset: 0x00090444
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.label1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
			foreach (object obj in this.dtgvAcc.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00092324 File Offset: 0x00090524
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			fChonThuMuc.isAdd = true;
			bool flag = this.isFromBin;
			if (flag)
			{
				fChonThuMuc.lstChooseIdFilesFromBin = new List<string>();
				for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
				{
					bool flag2 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
					if (flag2)
					{
						fChonThuMuc.lstChooseIdFilesFromBin.Add(DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))));
					}
				}
				bool flag3 = fChonThuMuc.lstChooseIdFilesFromBin.Count == 0;
				if (flag3)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkU5aWVsSnBaRlUxYVdGVlVrVmpiR2hTV2pKS2RHRnRhREZqVmxsM1UxVlNSbG95VWtoaGEyUjZVVEJLTUU1SFNqRmlSbXcxVWxRd1BRPT0="))))))))), 2);
					return;
				}
			}
			else
			{
				fChonThuMuc.lstChooseIdFiles = new List<string>();
				for (int j = 0; j < this.dtgvAcc.Rows.Count; j++)
				{
					bool flag4 = Convert.ToBoolean(this.dtgvAcc.Rows[j].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
					if (flag4)
					{
						fChonThuMuc.lstChooseIdFiles.Add(DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))));
					}
				}
				bool flag5 = fChonThuMuc.lstChooseIdFiles.Count == 0;
				if (flag5)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkU5aWVsSnBaRlUxYVdGVlVrVmpiR2hTV2pKS2RHRnRhREZqVmxsM1UxVlNSbG95VWtoaGEyUjZVVEJLTUU1SFNqRmlSbXcxVWxRd1BRPT0="))))))))), 2);
					return;
				}
			}
			base.Close();
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00092684 File Offset: 0x00090884
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			bool flag = this.isFromBin;
			if (flag)
			{
				bool flag2 = fChonThuMuc.lstChooseIdFilesFromBin == null;
				if (flag2)
				{
					fChonThuMuc.lstChooseIdFilesFromBin = new List<string>();
				}
				this.LoadListFiles(fChonThuMuc.lstChooseIdFilesFromBin);
			}
			else
			{
				bool flag3 = fChonThuMuc.lstChooseIdFiles == null;
				if (flag3)
				{
					fChonThuMuc.lstChooseIdFiles = new List<string>();
				}
				this.LoadListFiles(fChonThuMuc.lstChooseIdFiles);
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00092704 File Offset: 0x00090904
		private void LoadListFiles(List<string> lstIdFile = null)
		{
			try
			{
				bool flag = this.isFromBin;
				DataTable dataTable;
				if (flag)
				{
					dataTable = CommonSQL.GetAllFilesFromDatabaseForBin(false);
				}
				else
				{
					dataTable = CommonSQL.GetAllFilesFromDatabase(false);
				}
				bool flag2 = lstIdFile != null && lstIdFile.Count > 0;
				if (flag2)
				{
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						bool flag3 = lstIdFile.Contains(dataTable.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VsQlJQVDA9"))))))))].ToString());
						if (flag3)
						{
							this.dtgvAcc.Rows.Add(new object[]
							{
								true,
								i + 1,
								dataTable.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VsQlJQVDA9"))))))))],
								dataTable.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRkpRVkRBOQ=="))))))))]
							});
						}
						else
						{
							this.dtgvAcc.Rows.Add(new object[]
							{
								false,
								i + 1,
								dataTable.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VsQlJQVDA9"))))))))],
								dataTable.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRkpRVkRBOQ=="))))))))]
							});
						}
					}
				}
				else
				{
					for (int j = 0; j < dataTable.Rows.Count; j++)
					{
						this.dtgvAcc.Rows.Add(new object[]
						{
							false,
							j + 1,
							dataTable.Rows[j][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VsQlJQVDA9"))))))))],
							dataTable.Rows[j][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRkpRVkRBOQ=="))))))))]
						});
					}
				}
				this.UpdateSelectCountRecord();
				this.UpdateTotalCountRecord();
				bool flag4 = this.CountSelectRow() == this.dtgvAcc.RowCount;
				if (flag4)
				{
					this.checkBox1.Checked = true;
				}
				else
				{
					this.checkBox1.Checked = false;
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWak5XRkdjRVpsU0VKcVRURktTRmxXWkRSaVIwNHpVRlF3UFE9PQ==")))))))));
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHVnJiRWhsYldneFRsZFNkMU5WYUhGaFNGWjRWR3BXU2xORmNHOVVSVTVEVFcxU1dHRXlaR2xVVlRrMVdXMHhhbG95VWtoaGJXZ3hUbXBDYmxsck9VaE9iVGxZWVRKa2FrMXJXWGhUVmtVNVVGRTlQUT09"))))))))), 2);
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00092C88 File Offset: 0x00090E88
		private void UpdateSelectCountRecord()
		{
			try
			{
				this.lblCountChoose.Text = this.CountSelectRow().ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00092CE4 File Offset: 0x00090EE4
		private void DtgvAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.ColumnIndex == 0;
			if (flag)
			{
				this.UpdateSelectCountRecord();
				bool flag2 = this.CountSelectRow() == this.dtgvAcc.RowCount;
				if (flag2)
				{
					this.checkBox1.Checked = true;
				}
				else
				{
					this.checkBox1.Checked = false;
				}
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00092D70 File Offset: 0x00090F70
		private void UpdateTotalCountRecord()
		{
			try
			{
				this.lblCountTotal.Text = this.dtgvAcc.Rows.Count.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00092DD8 File Offset: 0x00090FD8
		private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				bool flag = Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
				if (flag)
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

		// Token: 0x06000533 RID: 1331 RVA: 0x00092F70 File Offset: 0x00091170
		private int CountSelectRow()
		{
			int num = 0;
			for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
			{
				bool flag = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
				if (flag)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00093040 File Offset: 0x00091240
		private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
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

		// Token: 0x06000535 RID: 1333 RVA: 0x000931F4 File Offset: 0x000913F4
		private void checkBox1_Click(object sender, EventArgs e)
		{
			bool @checked = this.checkBox1.Checked;
			if (@checked)
			{
				for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
				{
					DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ==")))))))), true);
				}
			}
			else
			{
				for (int j = 0; j < this.dtgvAcc.Rows.Count; j++)
				{
					DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ==")))))))), false);
				}
			}
		}

		// Token: 0x0400042F RID: 1071
		private bool isFromBin = false;

		// Token: 0x04000430 RID: 1072
		public static List<string> lstChooseIdFiles;

		// Token: 0x04000431 RID: 1073
		public static List<string> lstChooseIdFilesFromBin;

		// Token: 0x04000432 RID: 1074
		public static bool isAdd;
	}
}
