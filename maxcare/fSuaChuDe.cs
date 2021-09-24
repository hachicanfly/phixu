using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Properties;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000093 RID: 147
	public partial class fSuaChuDe : Form
	{
		// Token: 0x060005AB RID: 1451 RVA: 0x00002AE9 File Offset: 0x00000CE9
		public fSuaChuDe(string oldChude)
		{
			this.InitializeComponent();
			this.txtChude.Text = oldChude;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00069C18 File Offset: 0x00067E18
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00069C18 File Offset: 0x00067E18
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00069C18 File Offset: 0x00067E18
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000A7D04 File Offset: 0x000A5F04
		private void btnAdd_Click(object sender, EventArgs e)
		{
			List<string> listChuDe = CommonSQL.GetListChuDe();
			string text = this.txtChude.Text;
			string text2 = this.txtNewChuDe.Text;
			bool flag = text2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				Common.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NYZGtlbHAzWkZWc1NGUnRPREJaYmxaMVUxVXhWRlZxVW1sa1ZVcEtVbnBPYjJSVVZqQmpSV3hTVUZRd1BRPT0=")))))))), 2);
			}
			else
			{
				bool flag2 = !listChuDe.Contains(text2);
				if (flag2)
				{
					CommonSQL.UpdateChuDe(text, text2);
					bool flag3 = MessageBox.Show(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeEpWVzA1TTA1clNqRlpWVTVEWVc1ak0xVnVWbUZsV0dSdVYxaFdTRTV0T1ZoT1IyUmFUMFU1TmxOVlkzaE5WRkpwWkZaS2FXRlZVa1poTWs1UVpXMUtkRmt5WkZwTE1HTXpZMnhrUmxveVRYSlNlbVJ6VmtSbk9RPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk=")))))))), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
					if (flag3)
					{
						base.Close();
					}
				}
				else
				{
					Common.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVHTlhTbkJSYlhCb1ZEQmpNMk5JYkVWU1YzUnNVbnBrYmxVd1VrWmhNazVRWVd0c1NWWkhhREZPVlRVeFUxVm9WV0ZJVm5oU2JrSk5VVEJKZVZwR1pISmFNa3BPVkROc2FXSlhUbTVsUlhCSllVaFZNVlp1UWtwVFJsSkZZMWN3TUZveVJYbGhhMUoyVmpBeGJ3PT0=")))))))), 2);
				}
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00069C18 File Offset: 0x00067E18
		private void fSuaChuDe_FormClosing(object sender, FormClosingEventArgs e)
		{
		}
	}
}
