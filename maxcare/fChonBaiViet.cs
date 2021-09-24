using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000090 RID: 144
	public partial class fChonBaiViet : Form
	{
		// Token: 0x06000564 RID: 1380 RVA: 0x0009D6E0 File Offset: 0x0009B8E0
		public fChonBaiViet(ref List<string> lstData)
		{
			this.InitializeComponent();
			this.LoadcbbChuDe(false);
			this.lstData = lstData;
			this.RefreshDtgvDaChon();
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0009D72C File Offset: 0x0009B92C
		private void RefreshDtgvDaChon()
		{
			bool flag = this.lstData.Count > 0;
			if (flag)
			{
				this.dgvBaiVietDaChon.Rows.Clear();
				for (int i = 0; i < this.lstData.Count; i++)
				{
					try
					{
						BaiViet infoPosyByID = this.GetInfoPosyByID(this.lstData[i]);
						this.dgvBaiVietDaChon.Rows.Add(new object[]
						{
							i + 1,
							infoPosyByID.tenChuDe,
							infoPosyByID.id,
							infoPosyByID.tieuDe,
							infoPosyByID.anh.Split(new char[]
							{
								'|'
							}).Length - 1,
							infoPosyByID.video.Split(new char[]
							{
								'|'
							}).Length - 1
						});
					}
					catch
					{
						this.lstData.RemoveAt(i--);
					}
				}
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0009D8C8 File Offset: 0x0009BAC8
		private BaiViet GetInfoPosyByID(string id)
		{
			BaiViet result = new BaiViet();
			try
			{
				result = CommonSQL.GetListBaiVietByID(id)[0];
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0009D924 File Offset: 0x0009BB24
		private void LoadcbbChuDe(bool check = false)
		{
			int selectedIndex = this.cbbChuDe.SelectedIndex;
			this.cbbChuDe.Items.Clear();
			List<string> listChuDe = CommonSQL.GetListChuDe();
			for (int i = 0; i < listChuDe.Count; i++)
			{
				this.cbbChuDe.Items.Add(listChuDe[i]);
			}
			bool flag = this.cbbChuDe.Items.Count == 0;
			if (flag)
			{
				this.cbbChuDe.SelectedIndex = -1;
			}
			else
			{
				bool flag2 = this.cbbChuDe.Items.Count == 1;
				if (flag2)
				{
					this.cbbChuDe.SelectedIndex = 0;
				}
				else
				{
					bool flag3 = selectedIndex == -1;
					if (flag3)
					{
						this.cbbChuDe.SelectedIndex = 0;
					}
					else
					{
						bool flag4 = this.cbbChuDe.Items.Count - 1 < selectedIndex;
						if (flag4)
						{
							this.cbbChuDe.SelectedIndex = this.cbbChuDe.Items.Count - 1;
						}
						else
						{
							this.cbbChuDe.SelectedIndex = selectedIndex;
						}
					}
				}
			}
			this.LoadDsBaiVietByChuDe(check);
			this.RefreshDtgvDaChon();
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		private void LoadDsBaiVietByChuDe(bool isLoadAll = true)
		{
			try
			{
				this.dgvDSBaiViet.Rows.Clear();
				List<BaiViet> list = new List<BaiViet>();
				bool flag = !isLoadAll;
				if (flag)
				{
					list = CommonSQL.GetListBaiViet(this.cbbChuDe.SelectedItem.ToString());
				}
				else
				{
					list = CommonSQL.GetListBaiViet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				}
				BaiViet baiViet = new BaiViet();
				for (int i = 0; i < list.Count; i++)
				{
					baiViet = list[i];
					this.dgvDSBaiViet.Rows.Add(new object[]
					{
						i + 1,
						baiViet.tenChuDe,
						baiViet.id,
						baiViet.tieuDe,
						baiViet.anh.Split(new char[]
						{
							'|'
						}).Length - 1,
						baiViet.video.Split(new char[]
						{
							'|'
						}).Length - 1
					});
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00069C18 File Offset: 0x00067E18
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0009DCB8 File Offset: 0x0009BEB8
		private void BtnSave_Click(object sender, EventArgs e)
		{
			this.lstData.Clear();
			for (int i = 0; i < this.dgvBaiVietDaChon.RowCount; i++)
			{
				this.lstData.Add(this.dgvBaiVietDaChon.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))].Value.ToString());
			}
			bool flag = MessageBox.Show(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeGFHUXlVbFJSYWtKb1ZGVTVibGx0TVc1YU1XczBWSHBDYVdKWFRucFRWV1JOWVVoV2VGSnVWa3BTTVVKRll6TnNRMlJIVW14U2VtUnlWbnBTYm1WRmNFbFNTRTE1VGxjMVNsSXhRbTlrVkZsNFlVVnNTVlZIYURGT1ZsVjI=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk=")))))))), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0009DE3C File Offset: 0x0009C03C
		private void metroButton1_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fDanhSachChuDe());
			this.LoadcbbChuDe(this.checkAll);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0009DE6C File Offset: 0x0009C06C
		private void thêmBàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				int count = CommonSQL.GetListBaiViet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Count;
				Common.ShowForm(new fThemBaiViet(this.cbbChuDe.SelectedIndex));
				int count2 = CommonSQL.GetListBaiViet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Count;
				bool flag = count2 > count;
				if (flag)
				{
					BaiViet baiViet = CommonSQL.GetBaiVietNewest()[0];
					this.dgvDSBaiViet.Rows.Add(new object[]
					{
						this.dgvDSBaiViet.RowCount + 1,
						baiViet.tenChuDe,
						baiViet.id,
						baiViet.tieuDe,
						baiViet.anh.Split(new char[]
						{
							'|'
						}).Length - 1,
						baiViet.video.Split(new char[]
						{
							'|'
						}).Length - 1
					});
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0009E060 File Offset: 0x0009C260
		private void sửaBàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				DataGridViewRow dataGridViewRow = this.dgvDSBaiViet.SelectedRows[0];
				int idBaiviet = Convert.ToInt32(dataGridViewRow.Cells[2].Value);
				Common.ShowForm(new fSuaBaiViet(idBaiviet));
				BaiViet baiViet = CommonSQL.GetListBaiVietByID(idBaiviet.ToString())[0];
				Common.SetStatusDataGridView(this.dgvDSBaiViet, dataGridViewRow.Index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyTkdjRmxXYTFaaFZWUXdPUT09")))))))), baiViet.tieuDe);
				Common.SetStatusDataGridView(this.dgvDSBaiViet, dataGridViewRow.Index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1IyUlhSa0pRVkRBOQ==")))))))), baiViet.anh.Split(new char[]
				{
					'|'
				}).Length - 1);
				Common.SetStatusDataGridView(this.dgvDSBaiViet, dataGridViewRow.Index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1lXTkdjRWhXYmxrOQ==")))))))), baiViet.video.Split(new char[]
				{
					'|'
				}).Length - 1);
				this.RefreshDtgvDaChon();
			}
			catch
			{
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0009E280 File Offset: 0x0009C480
		private bool checkTrung(string id)
		{
			bool result = false;
			for (int i = 0; i < this.dgvBaiVietDaChon.Rows.Count; i++)
			{
				bool flag = id == this.dgvBaiVietDaChon.Rows[i].Cells[2].Value.ToString();
				if (flag)
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0009E320 File Offset: 0x0009C520
		private void dtgvKichBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int num = Convert.ToInt32(this.dgvDSBaiViet.SelectedRows[0].Cells[2].Value);
			List<BaiViet> listBaiVietByID = CommonSQL.GetListBaiVietByID(num.ToString());
			BaiViet baiViet = new BaiViet();
			for (int i = 0; i < listBaiVietByID.Count; i++)
			{
				bool flag = this.checkTrung(num.ToString());
				if (flag)
				{
					break;
				}
				baiViet = listBaiVietByID[i];
				this.dgvBaiVietDaChon.Rows.Add(new object[]
				{
					this.dgvBaiVietDaChon.Rows.Count + 1,
					baiViet.tenChuDe,
					baiViet.id,
					baiViet.tieuDe,
					baiViet.anh.Split(new char[]
					{
						'|'
					}).Length - 1,
					baiViet.video.Split(new char[]
					{
						'|'
					}).Length - 1
				});
				this.lstData.Add(baiViet.id.ToString());
			}
			this.lblCountAcc.Text = this.dgvBaiVietDaChon.Rows.Count.ToString();
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0009E4F4 File Offset: 0x0009C6F4
		private void chiTiếtBàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				int idBaiviet = Convert.ToInt32(this.dgvDSBaiViet.SelectedRows[0].Cells[2].Value);
				fChiTietBaiViet fChiTietBaiViet = new fChiTietBaiViet(idBaiviet);
				fChiTietBaiViet.Show();
			}
			catch
			{
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0009E570 File Offset: 0x0009C770
		private void UpdateSTTOnDtgvAcc()
		{
			for (int i = 0; i < this.dgvBaiVietDaChon.RowCount; i++)
			{
				Common.SetStatusDataGridView(this.dgvBaiVietDaChon, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUhVa1ZTVkRBOQ==")))))))), i + 1);
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0009E610 File Offset: 0x0009C810
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.dgvDSBaiViet.Rows.Clear();
			List<BaiViet> listBaiViet = CommonSQL.GetListBaiViet(this.cbbChuDe.SelectedItem.ToString());
			BaiViet baiViet = new BaiViet();
			for (int i = 0; i < listBaiViet.Count; i++)
			{
				try
				{
					baiViet = listBaiViet[i];
					this.dgvDSBaiViet.Rows.Add(new object[]
					{
						i + 1,
						baiViet.tenChuDe,
						baiViet.id,
						baiViet.tieuDe,
						baiViet.anh.Split(new char[]
						{
							'|'
						}).Length - 1,
						baiViet.video.Split(new char[]
						{
							'|'
						}).Length - 1
					});
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0009E774 File Offset: 0x0009C974
		private void làmMớiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LoadDsBaiVietByChuDe(this.checkAll);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00069C18 File Offset: 0x00067E18
		private void cbbChuDe_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0009E79C File Offset: 0x0009C99C
		private void hiểnThịTấtCảBàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.checkAll = true;
			this.dgvDSBaiViet.Rows.Clear();
			this.LoadDsBaiVietByChuDe(this.checkAll);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00069C18 File Offset: 0x00067E18
		private void cbbChuDe_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0009E7E8 File Offset: 0x0009C9E8
		private void dgvBaiVietDaChon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach (object obj in this.dgvBaiVietDaChon.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				this.dgvBaiVietDaChon.Rows.RemoveAt(dataGridViewRow.Index);
			}
			this.lblCountAcc.Text = this.dgvBaiVietDaChon.Rows.Count.ToString();
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0009E8A8 File Offset: 0x0009CAA8
		private void xóaBàiViếtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				DataGridViewRow dataGridViewRow = this.dgvDSBaiViet.SelectedRows[0];
				bool flag = dataGridViewRow != null;
				if (flag)
				{
					bool flag2 = MessageBox.Show(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWTNoTlZGSnBaRlpLYVdGVlNUQmtlbVJQWVVWc1NGUkZVblpTTW5SdVdrY3hkV0ZJVm5sUFZFSktVbnBrUldJd2FISmFNa1Y1WVd0U01GSjZWblZWU0dNNVVGRTlQUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk=")))))))), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
					if (flag2)
					{
						int id = Convert.ToInt32(dataGridViewRow.Cells[2].Value);
						CommonSQL.DeleteBaiViet(id);
						this.dgvDSBaiViet.Rows.Remove(dataGridViewRow);
						this.RefreshDtgvDaChon();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00069C18 File Offset: 0x00067E18
		private void dgvDSBaiViet_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00069C18 File Offset: 0x00067E18
		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0009EA04 File Offset: 0x0009CC04
		private void dgvBaiVietDaChon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.UpdateSTTOnDtgvAcc();
			this.lblCountAcc.Text = this.dgvBaiVietDaChon.Rows.Count.ToString();
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0009EA04 File Offset: 0x0009CC04
		private void dgvBaiVietDaChon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.UpdateSTTOnDtgvAcc();
			this.lblCountAcc.Text = this.dgvBaiVietDaChon.Rows.Count.ToString();
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0009EA4C File Offset: 0x0009CC4C
		private void cbbChuDe_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkAll = false;
			this.LoadDsBaiVietByChuDe(this.checkAll);
		}

		// Token: 0x04000494 RID: 1172
		private bool checkAll = false;

		// Token: 0x04000495 RID: 1173
		private List<string> lstData = new List<string>();
	}
}
