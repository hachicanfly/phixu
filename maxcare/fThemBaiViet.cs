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
	// Token: 0x02000094 RID: 148
	public partial class fThemBaiViet : Form
	{
		// Token: 0x060005B7 RID: 1463 RVA: 0x00002B0E File Offset: 0x00000D0E
		public fThemBaiViet(int cbbChuDeSlectedIndex)
		{
			this.InitializeComponent();
			this.LoadcbbChuDe();
			this.cbbChuDe.SelectedIndex = cbbChuDeSlectedIndex;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000AA368 File Offset: 0x000A8568
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

		// Token: 0x060005B9 RID: 1465 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000AA400 File Offset: 0x000A8600
		private void metroButton1_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fDanhSachChuDe());
			this.cbbChuDe.Items.Clear();
			this.LoadcbbChuDe();
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000AA43C File Offset: 0x000A863C
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

		// Token: 0x060005BD RID: 1469 RVA: 0x000AA5E0 File Offset: 0x000A87E0
		private void btnDelLink_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.dgvPic.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				this.dgvPic.Rows.RemoveAt(dataGridViewRow.Index);
			}
			this.lblNanh.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VGtkS2VHRlhTblJhTW1STVVWUXdPUT09")))))))) + this.dgvPic.Rows.Count.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGU2RsQlJQVDA9"))))))));
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000AA72C File Offset: 0x000A892C
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
				string tenchuDe = this.cbbChuDe.SelectedItem.ToString();
				BaiViet baiviet = new BaiViet
				{
					tieuDe = this.txtName.Text,
					anh = text,
					video = @string,
					ngayTao = DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1VtUnNVbFpOU0Zwc1YwZDNNVnBXUlRsUVVUMDk="))))))))),
					noiDung = this.txtConten.Text
				};
				CommonSQL.AddBaiViet(tenchuDe, baiviet);
				DialogResult dialogResult = MessageBox.Show(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklSblJOUjJSclVqSndSV0l3WXpGaU1HeElWVVZTTUZKNlZuVlVSMnhEVVhwU2FXTlhhR2xoVlVvd1drZFdTRTR5ZEZoT1IyUmFUMFU1TmxOVlkzaE5WRkpwWkZaS2FXRlZVa1poTWs1UVpXMUtkRmt5WkZwTE1HTXpZMnhrUmxveVRYSlNlbVJ6VlRCS2VWbFZNVkJOUjBwMFdYazRQUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk=")))))))), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				bool flag3 = dialogResult == DialogResult.Yes;
				if (flag3)
				{
					base.Close();
				}
			}
			else
			{
				Common.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NWSXpUa2hTVjJScFlsZHdiMlJZUlhoa01HeEpWVzVDTTA1dVFYaFRWVEZVVldwU2FXUlZTa3BWVkRBNQ==")))))))), 2);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnEdit_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000AAAD8 File Offset: 0x000A8CD8
		private void dgvPic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Process.Start(this.dgvPic.SelectedRows[0].Cells[0].Value.ToString());
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00069C18 File Offset: 0x00067E18
		private void cbbChuDe_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00069C18 File Offset: 0x00067E18
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00069C18 File Offset: 0x00067E18
		private void DgvVideo_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00069C18 File Offset: 0x00067E18
		private void BunifuCustomLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000A530C File Offset: 0x000A350C
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Common.ShowForm(new fHuongDanRandom());
		}
	}
}
