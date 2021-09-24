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
	// Token: 0x0200008C RID: 140
	public partial class fNhapMailAdd : Form
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x000955B8 File Offset: 0x000937B8
		public fNhapMailAdd()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			Common.CreateFile(this.linkPath);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00095684 File Offset: 0x00093884
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblTitle);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.lblFooter);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000956E8 File Offset: 0x000938E8
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
			this.txtComment.Lines = File.ReadAllLines(this.linkPath);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00069C18 File Offset: 0x00067E18
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00069C18 File Offset: 0x00067E18
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00095718 File Offset: 0x00093918
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				File.WriteAllText(this.linkPath, this.txtComment.Text.Trim());
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeGFHUXlVbFJSYWtKb1ZGVTVibGx0TVc1YU1XczBWSHBDYVdKWFRucFRWV1JMWVVod1RGUnVWa3BTTURVeVpXdHNSbG95U2xsWFJWSXdWRmhzUTFsdGJFVlNWM1JZVERBeGJsWjZWblZUVldSUlVqTk9UbVZWY0ZwVk1FbzJaSHBrVlZSWGJGVlBSREE5")))))))))) == DialogResult.Yes;
				if (flag)
				{
					base.Close();
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGxyT1VoT01uZDVZVEprYkZRd1l6SmllazV5V2pKT2RGSllUa3BUUm05NFdWWk9RMk16WXpOVGJsWmhaVlZKZDFsVk9VaE9NMHBVVVc1Tk1GbHVSbTlaVms1RFpXeHNXVlpYWnowPQ=="))))))))), 2);
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00095834 File Offset: 0x00093A34
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtComment.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.lblStatus.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5BelRtdGFjVmxWVGtOU2JVcFlVbTVDYVZFd1JuWT0=")))))))) + list.Count.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGU2RsQlJQVDA9"))))))));
			}
			catch
			{
			}
		}

		// Token: 0x04000447 RID: 1095
		private string linkPath = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWRvWVZJeFNqQlhWbVJ6WXpGb1NHRklXbXRTZWtadldWWmtNMlJYVWtsaFJFRTk="))))))));

		// Token: 0x04000448 RID: 1096
		private string status = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
	}
}
