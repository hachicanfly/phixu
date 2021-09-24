using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x0200008F RID: 143
	public partial class fChiTietBaiViet : Form
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x0009AFC0 File Offset: 0x000991C0
		public fChiTietBaiViet(int idBaiviet)
		{
			this.InitializeComponent();
			List<BaiViet> listBaiVietByID = CommonSQL.GetListBaiVietByID(idBaiviet.ToString());
			foreach (BaiViet baiViet in listBaiVietByID)
			{
				this.txtChuDe.Text = baiViet.tenChuDe;
				this.txtName.Text = baiViet.tieuDe;
				this.txtConten.Text = baiViet.noiDung;
				string[] array = baiViet.anh.Split(new char[]
				{
					'|'
				});
				this.lblNanh.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VGtkS2VHRlhTblJhTW1STVVWUXdPUT09")))))))) + (array.Length - 1).ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGU2RsQlJQVDA9"))))))));
				string[] array2 = baiViet.video.Split(new char[]
				{
					'|'
				});
				for (int i = 0; i < array.Length - 1; i++)
				{
					this.dgvPic.Rows.Add(new object[]
					{
						array[i]
					});
				}
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00069C18 File Offset: 0x00067E18
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00069C18 File Offset: 0x00067E18
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00069C18 File Offset: 0x00067E18
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0009B194 File Offset: 0x00099394
		private void dgvPic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				Process.Start(this.dgvPic.SelectedRows[0].Cells[0].Value.ToString());
			}
			catch (Exception)
			{
				MessageBox.Show(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MyUlhSalZTUjJneFkxVTFNVmxWVGtOamJVWk9WSHBDYVdKWFRtNWFSVGxJVGpKemVVNUhaR3RVTUdNeVlqRmtjbEJSUFQwPQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoZWpBOQ==")))))))));
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00069C18 File Offset: 0x00067E18
		private void LblVideo_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00069C18 File Offset: 0x00067E18
		private void DgvVideo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00069C18 File Offset: 0x00067E18
		private void DgvPic_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
