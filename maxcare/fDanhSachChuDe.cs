using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x02000091 RID: 145
	public partial class fDanhSachChuDe : Form
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x00002ACA File Offset: 0x00000CCA
		public fDanhSachChuDe()
		{
			this.InitializeComponent();
			this.LoadcbbChuDe();
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000A2608 File Offset: 0x000A0808
		private void LoadcbbChuDe()
		{
			List<string> listChuDe = CommonSQL.GetListChuDe();
			for (int i = 0; i < listChuDe.Count; i++)
			{
				this.dgvChuDe.Rows.Add(new object[]
				{
					i + 1,
					listChuDe[i]
				});
			}
			this.lblCountChuDe.Text = listChuDe.Count<string>().ToString();
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00069C18 File Offset: 0x00067E18
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000A26A4 File Offset: 0x000A08A4
		private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fThemChuDe());
			this.dgvChuDe.Rows.Clear();
			this.LoadcbbChuDe();
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000A26E0 File Offset: 0x000A08E0
		private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string oldChude = this.dgvChuDe.SelectedRows[0].Cells[1].Value.ToString();
			Common.ShowForm(new fSuaChuDe(oldChude));
			this.dgvChuDe.Rows.Clear();
			this.LoadcbbChuDe();
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00069C18 File Offset: 0x00067E18
		private void label7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00069C18 File Offset: 0x00067E18
		private void lblCountChuDe_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00069C18 File Offset: 0x00067E18
		private void btnThem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00069C18 File Offset: 0x00067E18
		private void btnSua_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00069C18 File Offset: 0x00067E18
		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000A2750 File Offset: 0x000A0950
		private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = MessageBox.Show(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWTNoTlZGSnBaRlpLYVdGVlNUQmtlbVJQWVVWc1NGUnRPREJaYmxaMVUxVXhWRlZxVW1sa1ZVcEtVbnBrUldJd2FISmFNa1Y1WVd0U01GSjZWblZWU0dNNVVGRTlQUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk=")))))))), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
			if (flag)
			{
				string text = this.dgvChuDe.SelectedRows[0].Cells[1].Value.ToString();
				CommonSQL.DeleteChuDe(text);
				CommonSQL.DeleteBaiVietByChuDe(text);
				this.dgvChuDe.Rows.Clear();
				this.LoadcbbChuDe();
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x000A286C File Offset: 0x000A0A6C
		private void tảiLạiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.dgvChuDe.Rows.Clear();
			this.LoadcbbChuDe();
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00069C18 File Offset: 0x00067E18
		private void dgvChuDe_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00069C18 File Offset: 0x00067E18
		private void dgvChuDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00069C18 File Offset: 0x00067E18
		private void fDanhSachChuDe_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00069C18 File Offset: 0x00067E18
		private void GroupBox2_Enter(object sender, EventArgs e)
		{
		}
	}
}
