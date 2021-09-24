using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x020000F6 RID: 246
	public partial class fNhapDuLieu2 : Form
	{
		// Token: 0x06000A02 RID: 2562 RVA: 0x001C7EB4 File Offset: 0x001C60B4
		public fNhapDuLieu2(string linkPathFolder, string title)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.linkPathFolder = linkPathFolder;
			this.lblTitle.Text = title;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x001C7F50 File Offset: 0x001C6150
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblTitle);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.groupBox2);
			foreach (object obj in this.dtgvDanhSach.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnSave);
			Language.GetValue(this.btnHuy);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x001C8030 File Offset: 0x001C6230
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
			Common.CreateFolder(this.linkPathFolder);
			this.LoadDsFile(this.linkPathFolder);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x001C8068 File Offset: 0x001C6268
		private void LoadContentFileFromDtgv(int row)
		{
			this.txtContent.Lines = File.ReadAllLines(DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))))));
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x001C80E8 File Offset: 0x001C62E8
		private void LoadDsFile(string linkPathFolder)
		{
			int num = -1;
			int rowCount = this.dtgvDanhSach.RowCount;
			int num2 = rowCount;
			if (num2 != 0)
			{
				if (num2 != 1)
				{
					num = this.dtgvDanhSach.SelectedRows[0].Index;
				}
				else
				{
					num = 0;
				}
			}
			this.dtgvDanhSach.Rows.Clear();
			List<string> list = Directory.GetFiles(linkPathFolder).ToList<string>();
			for (int i = 0; i < list.Count; i++)
			{
				this.dtgvDanhSach.Rows.Add(new object[]
				{
					i + 1,
					list[i],
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyTkZiRWxWYmtJelRtNUtUbG94YUZKUVVUMDk="))))))))),
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSb2FHUXpjRXBpUjJjOQ=="))))))))),
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpCamRsUlhaRmhTVkRBOQ==")))))))))
				});
			}
			bool flag = num == -1 && this.dtgvDanhSach.RowCount > 0;
			if (flag)
			{
				num = 0;
			}
			else
			{
				bool flag2 = num + 1 > this.dtgvDanhSach.RowCount;
				if (flag2)
				{
					num = this.dtgvDanhSach.RowCount - 1;
				}
			}
			bool flag3 = num == -1;
			if (flag3)
			{
				this.txtContent.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			else
			{
				Common.ClearSelectedOnDatagridview(this.dtgvDanhSach);
				this.dtgvDanhSach.Rows[num].Selected = true;
				this.LoadContentFileFromDtgv(num);
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x001C8410 File Offset: 0x001C6610
		private void rControl(int type)
		{
			bool flag = type == 1;
			if (flag)
			{
				this.dtgvDanhSach.Enabled = false;
				this.btnAdd.Enabled = false;
				this.btnSave.Enabled = true;
				this.btnHuy.Enabled = true;
				this.txtContent.ReadOnly = false;
				this.txtContent.Focus();
			}
			else
			{
				this.dtgvDanhSach.Enabled = true;
				this.btnAdd.Enabled = true;
				this.btnSave.Enabled = false;
				this.btnHuy.Enabled = false;
				this.txtContent.ReadOnly = true;
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x001C8528 File Offset: 0x001C6728
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text2;
				bool flag;
				do
				{
					text2 = DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1UxcHNVbFpOVjFwc1YwZDNNVnBXV1RWVFZrNUhUMWhTYVZacWJEWlpla1UwVUZFOVBRPT0="))))))))) + Common.CreateRandomString(3, this.rd) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMVUwNUhVa0pRVkRBOQ=="))))))));
					flag = File.Exists(text2);
				}
				while (flag);
				text = this.linkPathFolder + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + text2;
				Common.CreateFile(text);
				this.txtContent.Lines = File.ReadAllLines(text);
				this.dtgvDanhSach.Rows.Add(new object[]
				{
					this.dtgvDanhSach.RowCount + 1,
					text,
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyTkZiRWxWYmtJelRtNUtUbG94YUZKUVVUMDk="))))))))),
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSb2FHUXpjRXBpUjJjOQ=="))))))))),
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpCamRsUlhaRmhTVkRBOQ==")))))))))
				});
				Common.ClearSelectedOnDatagridview(this.dtgvDanhSach);
				this.dtgvDanhSach.Rows[this.dtgvDanhSach.RowCount - 1].Selected = true;
				this.rControl(1);
				this.isAdd = true;
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGxyT1VoT01uZDVZVEprYkZRd1l6SmllazV5V2pKT2RGSllUa3BUUm05NFdWWk9RMk16WXpOVGJsWmhaVlZKZDFsVk9VaE9NMHBVVVc1Tk1GbHVSbTlaVms1RFpXeHNXVlpYWnowPQ=="))))))))), 2);
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00069C18 File Offset: 0x00067E18
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00069C18 File Offset: 0x00067E18
		private void dtgvDanhSach_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x001C88E8 File Offset: 0x001C6AE8
		private void dtgvDanhSach_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			string name = this.dtgvDanhSach.Columns[e.ColumnIndex].Name;
			bool flag = name != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlSbGRWYmtKaFYwWkZPUT09")))))))) && name != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMVdiRkpRVkRBOQ==")))))))) && name != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR2IyUnNiRkpRVkRBOQ=="))))))));
			if (flag)
			{
				this.dtgvDanhSach.Cursor = Cursors.Default;
			}
			else
			{
				bool flag2 = e.RowIndex < this.dtgvDanhSach.RowCount;
				if (flag2)
				{
					this.dtgvDanhSach.Cursor = Cursors.Hand;
				}
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x001C8A70 File Offset: 0x001C6C70
		private void dtgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			bool flag = dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0;
			if (flag)
			{
				string name = dataGridView.Columns[e.ColumnIndex].Name;
				string a = name;
				if (!(a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlSbGRWYmtKaFYwWkZPUT09"))))))))))
				{
					if (!(a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMVdiRkpRVkRBOQ=="))))))))))
					{
						if (a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR2IyUnNiRkpRVkRBOQ==")))))))))
						{
							bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWTNoTlZGSnBaRlpLYVdGVlNUQmtlbVJQWVVaQ00xQlVNRDA9")))))))))) == DialogResult.Yes;
							if (flag2)
							{
								File.Delete(DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, e.RowIndex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))))));
								this.LoadDsFile(this.linkPathFolder);
							}
						}
					}
					else
					{
						this.txtContent.Lines = File.ReadAllLines(DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, e.RowIndex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))))));
						this.isAdd = false;
						this.rControl(1);
					}
				}
				else
				{
					this.LoadContentFileFromDtgv(e.RowIndex);
				}
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x001C8D8C File Offset: 0x001C6F8C
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.dtgvDanhSach.SelectedRows[0].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))))].Value.ToString();
				Common.CreateFile(text);
				bool flag = this.txtContent.Text.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NqRk9SMG94VjIxR1ZGRnRkR3RXZWxaMVUxVmtVV0ZJVm5oYVNGWktVak53U0dNd2FGWmhRVDA5"))))))))), 3);
				}
				else
				{
					bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWTNoTlZGSnBaRlpLYVdGVlNucGxTRXBEVFZWc1NHVnRhREZqVlZwM1ZVaGpPVkJSUFQwPQ==")))))))))) == DialogResult.Yes;
					if (flag2)
					{
						File.WriteAllLines(text, this.txtContent.Lines);
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeGFHUXlVbFJSYWtKb1ZGVTVibGx0TVc1YU1XczBWSHBDYVdKWFRtOD0="))))))))), 1);
						this.rControl(2);
					}
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGxyT1VoT01uZDVZVEprYkZRd1l6SmllazV5V2pKT2RGSllUa3BUUm05NFdWWk9RMk16WXpOVGJsWmhaVlZKZDFsVk9VaE9NMHBVVVc1Tk1GbHVSbTlaVms1RFpXeHNXVlpYWnowPQ=="))))))))), 2);
			}
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x001C903C File Offset: 0x001C723C
		private void btnHuy_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.dtgvDanhSach.SelectedRows[0].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))))].Value.ToString();
				Common.CreateFile(text);
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWTNoTlZGSnBaRlpLYVdGVlNuWk9SMG94WW0xV1ZVOUVNRDA9")))))))))) == DialogResult.Yes;
				if (flag)
				{
					bool flag2 = this.isAdd;
					if (flag2)
					{
						File.Delete(text);
					}
					this.rControl(2);
					this.LoadDsFile(this.linkPathFolder);
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGxyT1VoT01uZDVZVEprYkZRd1l6SmllazV5V2pKT2RGSllUa3BUUm05NFdWWk9RMk16WXpOVGJsWmhaVlZKZDFsVk9VaE9NMHBVVVc1Tk1GbHVSbTlaVms1RFpXeHNXVlpYWnowPQ=="))))))))), 2);
			}
		}

		// Token: 0x04000E83 RID: 3715
		private string linkPathFolder = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x04000E84 RID: 3716
		private Random rd = new Random();

		// Token: 0x04000E85 RID: 3717
		private bool isAdd = false;
	}
}
