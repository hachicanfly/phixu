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
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000092 RID: 146
	public partial class fSuaBaiViet : Form
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x000A4980 File Offset: 0x000A2B80
		public fSuaBaiViet(int idBaiviet)
		{
			this.InitializeComponent();
			this.LoadcbbChuDe();
			this.idBai = idBaiviet;
			List<BaiViet> listBaiVietByID = CommonSQL.GetListBaiVietByID(idBaiviet.ToString());
			foreach (BaiViet baiViet in listBaiVietByID)
			{
				this.cbbChuDe.Text = baiViet.tenChuDe;
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

		// Token: 0x06000599 RID: 1433 RVA: 0x000A4B60 File Offset: 0x000A2D60
		private void LoadcbbChuDe()
		{
			List<string> listChuDe = CommonSQL.GetListChuDe();
			for (int i = 0; i < listChuDe.Count; i++)
			{
				this.cbbChuDe.Items.Add(listChuDe[i]);
			}
			try
			{
				this.cbbChuDe.SelectedIndex = 0;
			}
			catch
			{
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00069C18 File Offset: 0x00067E18
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00069C18 File Offset: 0x00067E18
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000A4BF8 File Offset: 0x000A2DF8
		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool flag = this.txtName.Text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag2 = this.dgvPic.Rows.Count != 0;
				if (flag2)
				{
					for (int i = 0; i < this.dgvPic.Rows.Count; i++)
					{
						text = text + this.dgvPic.Rows[i].Cells[0].Value.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9"))))))));
					}
				}
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				BaiViet baiviet = new BaiViet
				{
					tieuDe = this.txtName.Text,
					anh = text,
					video = @string,
					noiDung = this.txtConten.Text
				};
				CommonSQL.UpdateBaiViet(this.idBai, baiviet);
				DialogResult dialogResult = MessageBox.Show(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoa01HeEpWVzA1TTA1clNqRlpWVTVEWVc1ak0xVnVWbUZsVkZaRVRrZEtlR0ZIU25CUmJYQXpUakF4Ymxsc2FGbGhTRlV4VW01V1NsTkdTblpaYW1oUVlVZFNSRkZUT0QwPQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				bool flag3 = dialogResult == DialogResult.Yes;
				if (flag3)
				{
					base.Dispose();
				}
			}
			else
			{
				MessageBox.Show(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NWSXpUa2hTVjJScFlsZHdiMlJZUlhoa01HeEpWVzVDTTA1dVFYaFRWVEZVVldwU2FXUlZTVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoZWpBOQ==")))))))));
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000A4F7C File Offset: 0x000A317C
		private void btnAddLink_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGamVHRkdiM2xXVjJSaFlsZDRlbGRzYUU1YU1IUkVZak5XYUdKclNuVlVSVTVDWTFWNGRHTklaR0ZXTWs1NlUxVk9kbVJYUm5WUmJYaE5VVEJHZUZSSE1YZGlWMFpZVjFoT1NsRXlPVEZaTUdNeFltdDBWRkZxYUVwUk1qa3hXVmMxUTJKck9UVlJXRVpOWWxoQ00xZHNaR3BPTUd4RVlqTldhR0pyU25OVU0yeENZMVY0ZEdOSE1XaFdNV3N6VTFWT2RtUlhUa2hPVnpROQ=="))))))));
			openFileDialog.FilterIndex = 0;
			openFileDialog.Multiselect = true;
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				string[] fileNames = openFileDialog.FileNames;
				for (int i = 0; i < fileNames.Length; i++)
				{
					this.dgvPic.Rows.Add(new object[]
					{
						fileNames[i]
					});
				}
				this.lblNanh.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VGtkS2VHRlhTblJhTW1STVVWUXdPUT09")))))))) + this.dgvPic.Rows.Count.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGU2RsQlJQVDA9"))))))));
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000A5120 File Offset: 0x000A3320
		private void btnDelLink_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.dgvPic.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				this.dgvPic.Rows.RemoveAt(dataGridViewRow.Index);
			}
			this.lblNanh.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VGtkS2VHRlhTblJhTW1STVVWUXdPUT09")))))))) + this.dgvPic.Rows.Count.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGU2RsQlJQVDA9"))))))));
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnEdit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000A526C File Offset: 0x000A346C
		private void dgvPic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Process.Start(this.dgvPic.SelectedRows[0].Cells[0].Value.ToString());
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00069C18 File Offset: 0x00067E18
		private void cbbChuDe_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000A52B4 File Offset: 0x000A34B4
		private void fSuaBaiViet_FormClosed(object sender, FormClosedEventArgs e)
		{
			List<string> list = new List<string>();
			fChonBaiViet fChonBaiViet = new fChonBaiViet(ref list);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00069C18 File Offset: 0x00067E18
		private void cbbChuDe_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000A52D0 File Offset: 0x000A34D0
		private void metroButton1_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fDanhSachChuDe());
			this.cbbChuDe.Items.Clear();
			this.LoadcbbChuDe();
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000A530C File Offset: 0x000A350C
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x040004D6 RID: 1238
		private int idBai;
	}
}
