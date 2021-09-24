using System;
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
	// Token: 0x020000FD RID: 253
	public partial class fDanhSachKichBan_Old : Form
	{
		// Token: 0x06000A3D RID: 2621 RVA: 0x001D1AC4 File Offset: 0x001CFCC4
		public fDanhSachKichBan_Old(string kickBan)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.kichBan = kickBan;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x001D1B40 File Offset: 0x001CFD40
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox1);
			foreach (object obj in this.dtgvKichBan.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
			Language.GetValue(this.groupBox2);
			foreach (object obj2 in this.dtgvHanhDong.Columns)
			{
				DataGridViewColumn control2 = (DataGridViewColumn)obj2;
				Language.GetValue(control2);
			}
			Language.GetValue(this.thêmMớiToolStripMenuItem);
			Language.GetValue(this.sửaToolStripMenuItem);
			Language.GetValue(this.xóaToolStripMenuItem);
			Language.GetValue(this.nhânBảnToolStripMenuItem);
			Language.GetValue(this.toolStripMenuItem1);
			Language.GetValue(this.toolStripMenuItem3);
			Language.GetValue(this.toolStripMenuItem4);
			Language.GetValue(this.toolStripMenuItem2);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x001D1CDC File Offset: 0x001CFEDC
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			this.LoadKichBan(this.kichBan);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x001D1D04 File Offset: 0x001CFF04
		private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SuaKichBan();
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x001D1D20 File Offset: 0x001CFF20
		private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.XoaKichBan();
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x001D1D3C File Offset: 0x001CFF3C
		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			this.XoaHanhDong();
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00194F0C File Offset: 0x0019310C
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

		// Token: 0x06000A45 RID: 2629 RVA: 0x001D1D58 File Offset: 0x001CFF58
		private void button2_Click(object sender, EventArgs e)
		{
			int index = this.dtgvHanhDong.SelectedRows[0].Index;
			bool flag = index == 0;
			if (!flag)
			{
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvHanhDong, index - 1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RoUjJocFlsZG9SbGxxU1RGaVp6MDk=")))))))));
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvHanhDong, index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RoUjJocFlsZG9SbGxxU1RGaVp6MDk=")))))))));
				bool flag2 = statusDataGridView + statusDataGridView2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag2)
				{
					bool flag3 = InteractSQL.UpdateThuTuHanhDong(statusDataGridView, statusDataGridView2);
					bool flag4 = flag3;
					if (flag4)
					{
						this.DoiChoDgv(ref this.dtgvHanhDong, index, index - 1);
						this.dtgvHanhDong.Rows[index - 1].Selected = true;
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25KYU1sWklVMFV4Y0ZkSGRHNVpNakZHWXpCc1NWZHFSbWhWTUVwNldXcG9OVkZYU25SWk1tUnJVakp3U0dNd01UVlRhMnhJWlVkb05sTXdOWGRUVldoUFlVZFNWRkpVTUQwPQ=="))))))))), 2);
					}
				}
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x001D1F64 File Offset: 0x001D0164
		private void button3_Click(object sender, EventArgs e)
		{
			int index = this.dtgvHanhDong.SelectedRows[0].Index;
			bool flag = index == this.dtgvHanhDong.RowCount - 1;
			if (!flag)
			{
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvHanhDong, index + 1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RoUjJocFlsZG9SbGxxU1RGaVp6MDk=")))))))));
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvHanhDong, index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RoUjJocFlsZG9SbGxxU1RGaVp6MDk=")))))))));
				bool flag2 = statusDataGridView + statusDataGridView2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag2)
				{
					bool flag3 = InteractSQL.UpdateThuTuHanhDong(statusDataGridView, statusDataGridView2);
					bool flag4 = flag3;
					if (flag4)
					{
						this.DoiChoDgv(ref this.dtgvHanhDong, index, index + 1);
						this.dtgvHanhDong.Rows[index + 1].Selected = true;
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25KYU1sWklVMFV4Y0ZkSGRHNVpNakZHWXpCc1NWZHFSbWhWTUVwNldXcG9OVkZYU25SWk1tUnJVakp3U0dNd01UVlRhMnhJWlVkb05sTXdOWGRUVldoUFlVZFNWRkpVTUQwPQ=="))))))))), 2);
					}
				}
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x001D2180 File Offset: 0x001D0380
		private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ThemKichBan();
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x001D219C File Offset: 0x001D039C
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.ThemHanhDong();
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x001D21B8 File Offset: 0x001D03B8
		private void nhânBảnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.NhanBanKichBan();
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x001D21D4 File Offset: 0x001D03D4
		private void dtgvKichBan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.RowIndex > -1;
			if (flag)
			{
				this.LoadHanhDong();
			}
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x001D220C File Offset: 0x001D040C
		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			this.SuaHanhDong();
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x001D2228 File Offset: 0x001D0428
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			this.NhanBanHanhDong();
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x001D2244 File Offset: 0x001D0444
		private void dtgvHanhDong_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			Keys keys = keyCode;
			if (keys <= Keys.Delete)
			{
				if (keys != Keys.Insert)
				{
					if (keys != Keys.Delete)
					{
						return;
					}
					this.XoaHanhDong();
					return;
				}
			}
			else
			{
				if (keys == Keys.D)
				{
					bool flag = e.Modifiers == Keys.Control;
					if (flag)
					{
						this.NhanBanHanhDong();
					}
					return;
				}
				switch (keys)
				{
				case Keys.F1:
					break;
				case Keys.F2:
					this.SuaHanhDong();
					return;
				case Keys.F3:
				case Keys.F4:
					return;
				case Keys.F5:
					this.LoadHanhDong();
					return;
				default:
					return;
				}
			}
			this.ThemHanhDong();
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x001D2334 File Offset: 0x001D0534
		private void NhanBanHanhDong()
		{
			try
			{
				bool flag = this.dtgvHanhDong.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaU0yTXlZMGhTU2xJeWNFVmlNR014WWpCc1RsVXhTVEJaYmxaaFdXMHhhbG95VWtsVVJXUjZWREJqTTJKVVNrNWhRVDA5")))))))), 3);
				}
				else
				{
					DataGridViewRow dataGridViewRow = this.dtgvHanhDong.SelectedRows[0];
					string id_HanhDong = dataGridViewRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RoUjJocFlsZG9SbGxxU1RGaVp6MDk="))))))))].Value.ToString();
					string str = dataGridViewRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UySkhTbkpoUjJocFlsZG9SbGxxU1RGaVp6MDk="))))))))].Value.ToString();
					string text = str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWTmQxb3hSWGxQV0dSc1ZWUXdPUT09"))))))));
					int num = 2;
					while (InteractSQL.CheckExistTenHanhDong(text))
					{
						text = str + string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWTmQxb3hSWGxQV0dSc1ZUQkdkbHBZY0VOUFZYUlNVRlF3UFE9PQ==")))))))), num++);
					}
					bool flag2 = InteractSQL.DuplicateHanhDong(id_HanhDong, text);
					if (flag2)
					{
						DataTable hanhDongMoi = InteractSQL.GetHanhDongMoi();
						this.dtgvHanhDong.Rows.Add(new object[]
						{
							this.dtgvHanhDong.RowCount + 1,
							hanhDongMoi.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUa2hTYmxab1VsWktNbGx0TVdwUVVUMDk="))))))))],
							hanhDongMoi.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUa2hTYmxab1VsWktNbGx0TVdwUVVUMDk="))))))))],
							hanhDongMoi.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaak5WWldiRkpRVkRBOQ=="))))))))]
						});
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x001D2768 File Offset: 0x001D0968
		private void LoadHanhDong()
		{
			try
			{
				this.dtgvHanhDong.Rows.Clear();
				bool flag = this.dtgvKichBan.RowCount == 0;
				if (!flag)
				{
					DataGridViewRow dataGridViewRow = this.dtgvKichBan.SelectedRows[0];
					string idKichBan = dataGridViewRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RrU0VKYVRXMW9SRmRXWXpCUVVUMDk="))))))))].Value.ToString();
					DataTable allHanhDongByKichBan = InteractSQL.GetAllHanhDongByKichBan(idKichBan);
					for (int i = 0; i < allHanhDongByKichBan.Rows.Count; i++)
					{
						this.dtgvHanhDong.Rows.Add(new object[]
						{
							this.dtgvHanhDong.RowCount + 1,
							allHanhDongByKichBan.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUa2hTYmxab1VsWktNbGx0TVdwUVVUMDk="))))))))],
							allHanhDongByKichBan.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUa2hTYmxab1VsWktNbGx0TVdwUVVUMDk="))))))))],
							allHanhDongByKichBan.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaak5WWldiRkpRVkRBOQ=="))))))))]
						});
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x001D29F0 File Offset: 0x001D0BF0
		private void XoaHanhDong()
		{
			try
			{
				bool flag = this.dtgvHanhDong.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaU0yTXlZMGhTU2xJeWNFVmlNR014WWpCc1RsVXhTVEJaYmxaaFdXMHhhbG95VWtsVVJXUjZWREJqTTJKVVNrNWhRVDA5"))))))))), 3);
				}
				else
				{
					bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWkU5aWVsSnBZMWhhV21WVlNqQmFSMVpJVGpKMFdFNUhaR3hVVlRrMlYxWk9RMkl5U1hKU2VscDJWMFpHYm1WRmNFbGhTRlV4WWtoV1lXVlZTakZrZWxwRFRsWkNNMUJVTUQwPQ==")))))))))) == DialogResult.Yes;
					if (flag2)
					{
						DataGridViewRow dataGridViewRow = this.dtgvHanhDong.SelectedRows[0];
						bool flag3 = InteractSQL.DeleteHanhDongByIdHanhDong(dataGridViewRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RoUjJocFlsZG9SbGxxU1RGaVp6MDk="))))))))].Value.ToString());
						if (flag3)
						{
							int index = dataGridViewRow.Index;
							for (int i = index; i < this.dtgvHanhDong.Rows.Count - 1; i++)
							{
								this.DoiChoDgv(ref this.dtgvHanhDong, i, i + 1);
							}
							this.dtgvHanhDong.Rows.RemoveAt(this.dtgvHanhDong.Rows.Count - 1);
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x001D2D28 File Offset: 0x001D0F28
		private void ThemHanhDong()
		{
			try
			{
				bool flag = this.dtgvKichBan.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaU0yTXlZMGhTU2xJeldtOWtWRkl3WVcxR1JGRnRhekJaYmtaeFdXMXNRMDFIVG5wWldHTXdXVzVXYVZkWWJFWlFVVDA5"))))))))), 3);
				}
				else
				{
					DataGridViewRow dataGridViewRow = this.dtgvKichBan.SelectedRows[0];
					string text = dataGridViewRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RrU0VKYVRXMW9SRmRXWXpCUVVUMDk="))))))))].Value.ToString();
					int count = InteractSQL.GetAllHanhDongByKichBan(text).Rows.Count;
					Common.ShowForm(new fThemHanhDong(text));
					DataTable allHanhDongByKichBan = InteractSQL.GetAllHanhDongByKichBan(text);
					int count2 = allHanhDongByKichBan.Rows.Count;
					bool flag2 = count2 > count;
					if (flag2)
					{
						this.dtgvHanhDong.Rows.Add(new object[]
						{
							this.dtgvHanhDong.RowCount + 1,
							allHanhDongByKichBan.Rows[count2 - 1][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUa2hTYmxab1VsWktNbGx0TVdwUVVUMDk="))))))))],
							allHanhDongByKichBan.Rows[count2 - 1][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUa2hTYmxab1VsWktNbGx0TVdwUVVUMDk="))))))))],
							allHanhDongByKichBan.Rows[count2 - 1][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaak5WWldiRkpRVkRBOQ=="))))))))]
						});
					}
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x001D30B0 File Offset: 0x001D12B0
		private void SuaHanhDong()
		{
			try
			{
				bool flag = this.dtgvHanhDong.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaU0yTXlZMGhTU2xJeWNFVmlNR014WWpCc1RsVXhTVEJaYmxaaFdXMHhhbG95VWtsVVJXUjZWREJqTTJKVVNrNWhRVDA5"))))))))), 3);
				}
				else
				{
					DataGridViewRow dataGridViewRow = this.dtgvHanhDong.SelectedRows[0];
					string text = dataGridViewRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RoUjJocFlsZG9SbGxxU1RGaVp6MDk="))))))))].Value.ToString();
					DataTable hanhDongById = InteractSQL.GetHanhDongById(text);
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IwNUdhM2xTYm14aFZYcFdkQT09"))))))));
					object obj = hanhDongById.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldXa2xXYmxwcFlsZFNWbGRXWkU1UVVUMDk="))))))))];
					string name = @string + ((obj != null) ? obj.ToString() : null);
					Form formByName = Common.GetFormByName(name, text);
					bool flag2 = formByName != null;
					if (flag2)
					{
						Common.ShowForm(formByName);
					}
					hanhDongById = InteractSQL.GetHanhDongById(text);
					DatagridviewHelper.SetStatusDataGridView(this.dtgvHanhDong, dataGridViewRow.Index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UySkhTbkpoUjJocFlsZG9SbGxxU1RGaVp6MDk=")))))))), hanhDongById.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUa2hTYmxab1VsWktNbGx0TVdwUVVUMDk="))))))))].ToString());
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x001D3428 File Offset: 0x001D1628
		private void dtgvKichBan_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			Keys keys = keyCode;
			if (keys <= Keys.Delete)
			{
				if (keys != Keys.Insert)
				{
					if (keys != Keys.Delete)
					{
						return;
					}
					this.XoaKichBan();
					return;
				}
			}
			else
			{
				if (keys == Keys.D)
				{
					bool flag = e.Modifiers == Keys.Control;
					if (flag)
					{
						this.NhanBanKichBan();
					}
					return;
				}
				switch (keys)
				{
				case Keys.F1:
					break;
				case Keys.F2:
					this.SuaKichBan();
					return;
				case Keys.F3:
				case Keys.F4:
					return;
				case Keys.F5:
					this.LoadKichBan(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					return;
				default:
					return;
				}
			}
			this.ThemKichBan();
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x001D355C File Offset: 0x001D175C
		private void LoadKichBan(string kichBan = "")
		{
			try
			{
				this.dtgvKichBan.Rows.Clear();
				DataTable allKichBan = InteractSQL.GetAllKichBan();
				bool flag = allKichBan.Rows.Count > 0;
				if (flag)
				{
					for (int i = 0; i < allKichBan.Rows.Count; i++)
					{
						DataRow dataRow = allKichBan.Rows[i];
						this.dtgvKichBan.Rows.Add(new object[]
						{
							i + 1,
							dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))],
							dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))]
						});
					}
				}
				bool flag2 = kichBan != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag2)
				{
					for (int j = 0; j < this.dtgvKichBan.RowCount; j++)
					{
						bool flag3 = DatagridviewHelper.GetStatusDataGridView(this.dtgvKichBan, j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RrU0VKYVRXMW9SRmRXWXpCUVVUMDk="))))))))) == kichBan;
						if (flag3)
						{
							this.dtgvKichBan.Rows[j].Selected = true;
							break;
						}
					}
				}
				this.LoadHanhDong();
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x001D3864 File Offset: 0x001D1A64
		private void XoaKichBan()
		{
			try
			{
				bool flag = this.dtgvKichBan.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaU0yTXlZMGhTU2xJeldtOWtWRkl3WVcxR1JGRnRhekJaYmtaeFdXMXNRMDFIVG5wWldHTXdXVzVXYVZkWWJFWlFVVDA5"))))))))), 3);
				}
				else
				{
					bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWkU5aWVsSnBZMWhhV21WVlNqQmFSMVpJVGpKMFdFNUhaR3hVVlRrMlYxWk9RMk5xVW1sa1ZYaGFUVzFrYmxkWVZraE9iVGg1VGtka2FXTXdPVzVhVmxFMFVGRTlQUT09")))))))))) == DialogResult.Yes;
					if (flag2)
					{
						DataGridViewRow dataGridViewRow = this.dtgvKichBan.SelectedRows[0];
						bool flag3 = InteractSQL.DeleteKichBan(dataGridViewRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RrU0VKYVRXMW9SRmRXWXpCUVVUMDk="))))))))].Value.ToString());
						if (flag3)
						{
							int index = dataGridViewRow.Index;
							for (int i = index; i < this.dtgvKichBan.Rows.Count - 1; i++)
							{
								this.DoiChoDgv(ref this.dtgvKichBan, i, i + 1);
							}
							this.dtgvKichBan.Rows.RemoveAt(this.dtgvKichBan.Rows.Count - 1);
							this.LoadHanhDong();
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x001D3BA8 File Offset: 0x001D1DA8
		private void SuaKichBan()
		{
			try
			{
				bool flag = this.dtgvKichBan.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaU0yTXlZMGhTU2xJeldtOWtWRkl3WVcxR1JGRnRhekJaYmtaeFdXMXNRMDFIVG5wWldHTXdXVzVXYVZkWWJFWlFVVDA5"))))))))), 3);
				}
				else
				{
					DataGridViewRow dataGridViewRow = this.dtgvKichBan.SelectedRows[0];
					string id = dataGridViewRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RrU0VKYVRXMW9SRmRXWXpCUVVUMDk="))))))))].Value.ToString();
					Common.ShowForm(new fThemKichBan(1, id));
					string status = InteractSQL.GetKichBanById(id).Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))].ToString();
					DatagridviewHelper.SetStatusDataGridView(this.dtgvKichBan, dataGridViewRow.Index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UySkhTbkprU0VKYVRXMW9SRmRXWXpCUVVUMDk=")))))))), status);
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
			}
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x001D3E54 File Offset: 0x001D2054
		private void ThemKichBan()
		{
			try
			{
				string a = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				try
				{
					a = InteractSQL.GetKichBanMoi().Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))].ToString();
				}
				catch
				{
				}
				Common.ShowForm(new fThemKichBan(0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
				DataTable kichBanMoi = InteractSQL.GetKichBanMoi();
				string b = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				try
				{
					b = kichBanMoi.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))].ToString();
				}
				catch
				{
				}
				bool flag = a != b;
				if (flag)
				{
					this.dtgvKichBan.Rows.Add(new object[]
					{
						this.dtgvKichBan.RowCount + 1,
						kichBanMoi.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))],
						kichBanMoi.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))]
					});
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x001D425C File Offset: 0x001D245C
		private void NhanBanKichBan()
		{
			try
			{
				bool flag = this.dtgvKichBan.RowCount == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaU0yTXlZMGhTU2xJeldtOWtWRkl3WVcxR1JGRnRhekJaYmtaeFdXMXNRMDFIVG5wWldHTXdXVzVXYVZkWWJFWlFVVDA5"))))))))), 3);
				}
				else
				{
					DataGridViewRow dataGridViewRow = this.dtgvKichBan.SelectedRows[0];
					string id_KichBanCu = dataGridViewRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRXhaM2RrU0VKYVRXMW9SRmRXWXpCUVVUMDk="))))))))].Value.ToString();
					string str = dataGridViewRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UySkhTbkprU0VKYVRXMW9SRmRXWXpCUVVUMDk="))))))))].Value.ToString();
					string text = str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWTmQxb3hSWGxQV0dSc1ZWUXdPUT09"))))))));
					int num = 2;
					while (InteractSQL.CheckExistTenKichBan(text))
					{
						text = str + string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWTmQxb3hSWGxQV0dSc1ZUQkdkbHBZY0VOUFZYUlNVRlF3UFE9PQ==")))))))), num++);
					}
					bool flag2 = InteractSQL.DuplicateKichBan(id_KichBanCu, text);
					if (flag2)
					{
						DataTable kichBanMoi = InteractSQL.GetKichBanMoi();
						this.dtgvKichBan.Rows.Add(new object[]
						{
							this.dtgvKichBan.RowCount + 1,
							kichBanMoi.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))],
							kichBanMoi.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))]
						});
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x001D4630 File Offset: 0x001D2830
		private void dtgvKichBan_KeyUp(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			Keys keys = keyCode;
			if (keys == Keys.Up || keys == Keys.Down)
			{
				this.LoadHanhDong();
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00069C18 File Offset: 0x00067E18
		private void fDanhSachKichBan_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x001D4684 File Offset: 0x001D2884
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

		// Token: 0x04000ECE RID: 3790
		private string kichBan = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
	}
}
