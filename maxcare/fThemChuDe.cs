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
	// Token: 0x02000095 RID: 149
	public partial class fThemChuDe : Form
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x00002B3A File Offset: 0x00000D3A
		public fThemChuDe()
		{
			this.InitializeComponent();
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00069C18 File Offset: 0x00067E18
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00069C18 File Offset: 0x00067E18
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00069C18 File Offset: 0x00067E18
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x000AD630 File Offset: 0x000AB830
		private void btnAdd_Click(object sender, EventArgs e)
		{
			List<string> listChuDe = CommonSQL.GetListChuDe();
			string text = this.txtChuDe.Text;
			bool flag = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				Common.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NYZGtlbHAzWkZWc1NGUnRPREJaYmxaMVUxVXhWRlZxVW1sa1ZVcEtVbnBPYjJSVVZqQmpSV3hTVUZRd1BRPT0=")))))))), 2);
			}
			else
			{
				bool flag2 = !listChuDe.Contains(text);
				if (flag2)
				{
					CommonSQL.AddChuDe(text);
					bool flag3 = MessageBox.Show(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklSblJOUjJSclVqSndSV0l3WXpGaU1HeElWVVZTTUZKNlZuVlVSVTVEWVZSU2FXTlhhR2xoVlVweFpIcGtUbG95U2xsWFIyZ3hUbFZhTVZOVk1WUlZibU16Vkc1V1lXVlZTbkZPUjBveFpFWnNWRkZ1YnpCWmJsWlhWVWhqT1ZCUlBUMD0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk=")))))))), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
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

		// Token: 0x060005D0 RID: 1488 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
