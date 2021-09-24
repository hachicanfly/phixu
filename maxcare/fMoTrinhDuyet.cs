using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000A6 RID: 166
	public partial class fMoTrinhDuyet : Form
	{
		// Token: 0x06000634 RID: 1588 RVA: 0x00002D00 File Offset: 0x00000F00
		public fMoTrinhDuyet()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fMoTrinhDuyet.isOK = false;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000BD7B0 File Offset: 0x000BB9B0
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label3);
			Language.GetValue(this.btnCauHinh);
			Language.GetValue(this.label1);
			Language.GetValue(this.rbSuDungProfile);
			Language.GetValue(this.rbKhongDungProfile);
			Language.GetValue(this.label2);
			Language.GetValue(this.label4);
			Language.GetValue(this.ckbKhongLuuTrinhDuyet);
			Language.GetValue(this.ckbGetCookie);
			Language.GetValue(this.ckbAutoCloseChromeLoginFail);
			Language.GetValue(this.ckbAutoOpenLink);
			Language.GetValue(this.btnSave);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00097C18 File Offset: 0x00095E18
		private void metroButton1_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fCauHinhChung());
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000BD8AC File Offset: 0x000BBAAC
		private void fMoTrinhDuyet_Load(object sender, EventArgs e)
		{
			JSON_Settings json_Settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVlRUQktjMWx0ZEV0bFYwbDZXa2h3WVZkRmF6az0=")))))))), false);
			bool valueBool = json_Settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1QxWnRUWGxXYkVacVlsUnNkRmxXWkRSaVFUMDk=")))))))), true);
			if (valueBool)
			{
				this.rbSuDungProfile.Checked = true;
			}
			else
			{
				this.rbKhongDungProfile.Checked = true;
			}
			bool flag = json_Settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), 0) == 0;
			if (flag)
			{
				this.rbLoginMFB.Checked = true;
			}
			else
			{
				this.rbLoginWWW.Checked = true;
			}
			switch (json_Settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 0))
			{
			case 0:
				this.rbLoginUidPass.Checked = true;
				break;
			case 1:
				this.rbLoginEmailPass.Checked = true;
				break;
			case 2:
				this.rbLoginCookie.Checked = true;
				break;
			}
			this.ckbAddChromeIntoForm.Checked = json_Settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSU1RXMW9OVmxxU1hoaVJrNVlUbFJDYVUxR2NESlpNakIzVUZFOVBRPT0=")))))))), false);
			this.nudWidthChrome.Value = json_Settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXWGxpUjNSclVqSm9SVmxWYUV0a2JVcFlWbFF3UFE9PQ==")))))))), 520);
			this.nudHeighChrome.Value = json_Settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUa2hXYmtKaFRXMW9SVmxWYUV0a2JVcFlWbFF3UFE9PQ==")))))))), 480);
			this.cbbColumnChrome.Text = ((json_Settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldSWGxQV0U1clZucEdNVlZVU205bFYwbDVUVmQzUFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkd4Rk9WQlJQVDA9")))))))) : json_Settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldSWGxQV0U1clZucEdNVlZVU205bFYwbDVUVmQzUFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			this.cbbRowChrome.Text = ((json_Settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldWblJQVkU1U1RXMW9OVmxxU1hoaVFUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkak9WQlJQVDA9")))))))) : json_Settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldWblJQVkU1U1RXMW9OVmxxU1hoaVFUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			this.ckbKhongLuuTrinhDuyet.Checked = json_Settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNUbHBHYUZkV1YwNTBZa2hXYUZKV1NYaGFWbVJYVFVFOVBRPT0=")))))))), false);
			this.ckbGetCookie.Checked = json_Settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1QxTkdjRmxWYTFKcFRXcHNlVmxXWkZaUVVUMDk=")))))))), false);
			this.ckbAutoCloseChromeLoginFail.Checked = json_Settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1QxRnRVbGxWYmxwU1RXNW9NbGw2U2xkU1IwWkpVMjVhYVZZeFdrNVpha3ByWTBkS2NsZHRhR2hXTTJNNQ==")))))))), false);
			this.ckbAutoOpenLink.Checked = json_Settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVUnNNMWRzWXpGVVYwWllUbGhKUFE9PQ==")))))))), false);
			this.txtLink.Text = json_Settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1pIb3dPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.ckbLoginHotmail.Checked = json_Settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVa2hQVnpWb1ZucFdTbGxxVGxOa1JteFlZa2hOUFE9PQ==")))))))), false);
			this.ckbAutoOpenLink_CheckedChanged(null, null);
			this.ckbCaptcha_CheckedChanged(null, null);
			this.ckbAddChromeIntoForm_CheckedChanged(null, null);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000BE254 File Offset: 0x000BC454
		private void btnSave_Click(object sender, EventArgs e)
		{
			JSON_Settings json_Settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVlRUQktjMWx0ZEV0bFYwbDZXa2h3WVZkRmF6az0=")))))))), false);
			bool @checked = this.rbSuDungProfile.Checked;
			if (@checked)
			{
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1QxWnRUWGxXYkVacVlsUnNkRmxXWkRSaVFUMDk=")))))))), true);
			}
			else
			{
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1QxWnRUWGxXYkVacVlsUnNkRmxXWkRSaVFUMDk=")))))))), false);
			}
			bool checked2 = this.rbLoginUidPass.Checked;
			if (checked2)
			{
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 0);
			}
			else
			{
				bool checked3 = this.rbLoginEmailPass.Checked;
				if (checked3)
				{
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 1);
				}
				else
				{
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 2);
				}
			}
			bool checked4 = this.rbLoginMFB.Checked;
			if (checked4)
			{
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), 0);
			}
			else
			{
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), 1);
			}
			json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSU1RXMW9OVmxxU1hoaVJrNVlUbFJDYVUxR2NESlpNakIzVUZFOVBRPT0=")))))))), this.ckbAddChromeIntoForm.Checked);
			json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXWGxpUjNSclVqSm9SVmxWYUV0a2JVcFlWbFF3UFE9PQ==")))))))), this.nudWidthChrome.Value);
			json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUa2hXYmtKaFRXMW9SVmxWYUV0a2JVcFlWbFF3UFE9PQ==")))))))), this.nudHeighChrome.Value);
			json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldSWGxQV0U1clZucEdNVlZVU205bFYwbDVUVmQzUFE9PQ==")))))))), this.cbbColumnChrome.Text);
			json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldWblJQVkU1U1RXMW9OVmxxU1hoaVFUMDk=")))))))), this.cbbRowChrome.Text);
			json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1QxTkdjRmxWYTFKcFRXcHNlVmxXWkZaUVVUMDk=")))))))), this.ckbGetCookie.Checked);
			json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNUbHBHYUZkV1YwNTBZa2hXYUZKV1NYaGFWbVJYVFVFOVBRPT0=")))))))), this.ckbKhongLuuTrinhDuyet.Checked);
			json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1QxRnRVbGxWYmxwU1RXNW9NbGw2U2xkU1IwWkpVMjVhYVZZeFdrNVpha3ByWTBkS2NsZHRhR2hXTTJNNQ==")))))))), this.ckbAutoCloseChromeLoginFail.Checked);
			json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVUnNNMWRzWXpGVVYwWllUbGhKUFE9PQ==")))))))), this.ckbAutoOpenLink.Checked);
			json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1pIb3dPUT09")))))))), this.txtLink.Text);
			json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVa2hQVnpWb1ZucFdTbGxxVGxOa1JteFlZa2hOUFE9PQ==")))))))), this.ckbLoginHotmail.Checked);
			json_Settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			fMoTrinhDuyet.isOK = true;
			base.Close();
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00069C18 File Offset: 0x00067E18
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000BE9FC File Offset: 0x000BCBFC
		private void ckbAutoOpenLink_CheckedChanged(object sender, EventArgs e)
		{
			this.txtLink.Enabled = this.ckbAutoOpenLink.Checked;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbCaptcha_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000BEA2C File Offset: 0x000BCC2C
		private void ckbAddChromeIntoForm_CheckedChanged(object sender, EventArgs e)
		{
			this.plAddChromeVaoFormView.Enabled = this.ckbAddChromeIntoForm.Checked;
			this.plSapXepCuaSoChrome.Enabled = !this.ckbAddChromeIntoForm.Checked;
		}

		// Token: 0x040005C4 RID: 1476
		public static bool isOK;
	}
}
