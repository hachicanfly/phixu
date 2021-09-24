using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x0200009F RID: 159
	public partial class fUpdateData2 : Form
	{
		// Token: 0x0600060B RID: 1547 RVA: 0x00002C10 File Offset: 0x00000E10
		public fUpdateData2(fQuanLyTinNhan main, string mode)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.main = main;
			this.cbbTypeUpdate.Text = mode;
			this.cbbTypeProxy.SelectedIndex = 0;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000B7D50 File Offset: 0x000B5F50
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000B7DC4 File Offset: 0x000B5FC4
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = false;
				bool flag2 = this.txbData.Text.Equals(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) || this.txbData.Text.Equals(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))));
				if (flag2)
				{
					bool flag3 = MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOaGJVWk9WVEJTTmxOVlduRlRWV040VFZoak0xWkZNVzVXZWxKdVdsVmpkbFJYWkZoU1YyUmhWRmRHTTJWcmJFNWFNa3BJWW10U2VHTXpiSEZhUms1RFlXcFNhV1JYTlZwVk1Fa3pWRlZuZDFveVVrNVVNbVJvVlRCS2VWbFZZM1poU0ZaNFZHNVdVV1I2TURrPQ=="))))))))), this.main.CountChooseRowInDatagridview())) == DialogResult.Yes;
					if (flag3)
					{
						flag = true;
					}
				}
				else
				{
					bool flag4 = MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOaGJVWk9WVEJTTmxOVlduRlRWV040VFZoak0xWkZNVzVXZWxKdVYxUm9VR0ZZY0V4VWJtUktVbnBXZG1SNldrMVVWemg2VlZka1lWUlhSak5sYTJ4T1dqSktTR0pyVW5oak0yeHhXa1pPUTJGcVVtbGtWelZhVlRCSk0xUlZaM2RhTWxKT1ZESmthRlV3U25sWlZXTjJZVWhXZUZSdVZsRmtlakE1"))))))))), this.main.CountChooseRowInDatagridview())) == DialogResult.Yes;
					if (flag4)
					{
						flag = true;
					}
				}
				bool flag5 = flag;
				if (flag5)
				{
					List<string> list = new List<string>();
					string text = this.txbData.Text;
					for (int i = 0; i < this.main.dgvTaiKhoan.SelectedRows.Count; i++)
					{
						list.Add(this.main.GetCellAccount(this.main.dgvTaiKhoan.SelectedRows[i].Index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))));
					}
					string text2 = this.cbbTypeUpdate.Text;
					string a = text2;
					if (a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtjd05VMUdjRmxVVkRBOQ==")))))))))
					{
						bool flag6 = CommonSQL.UpdateFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwS2IyTkdSWGxoUkVVOQ==")))))))), text);
						if (flag6)
						{
							for (int j = 0; j < this.main.dgvTaiKhoan.SelectedRows.Count; j++)
							{
								this.main.SetCellAccount(this.main.dgvTaiKhoan.SelectedRows[j].Index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EySXlSbFpVYlRsclZWUXdPUT09")))))))), text, true);
							}
						}
					}
					base.Close();
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaWVsSnBaRmhTU2xJemNHOWtXRVpIWTBWc1NWUnRhR3RWTUZVNQ=="))))))))), 2);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000B82AC File Offset: 0x000B64AC
		private void cbbTypeUpdate_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool visible = this.cbbTypeUpdate.Text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWb1MyUnRWa2xoZWpBOQ=="))))))));
			this.label3.Visible = visible;
			this.cbbTypeProxy.Visible = visible;
		}

		// Token: 0x0400058C RID: 1420
		private fQuanLyTinNhan main;
	}
}
