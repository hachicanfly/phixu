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
	// Token: 0x020000F7 RID: 247
	public partial class fNhapDuLieu1 : Form
	{
		// Token: 0x06000A13 RID: 2579 RVA: 0x001CB658 File Offset: 0x001C9858
		public fNhapDuLieu1(string linkPath, string title = "Nhập danh sách Uid cần clone", string status = "Danh sách Uid", string footer = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})", List<string> lstData = null)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			Common.CreateFile(linkPath);
			this.linkPath = linkPath;
			this.status = status;
			this.lblTitle.Text = title;
			this.lblStatus.Text = status + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWT2JtUXdkRlZpZWpBOQ=="))))))));
			this.lblFooter.Text = footer;
			bool flag = lstData != null;
			if (flag)
			{
				File.WriteAllLines(linkPath, lstData);
				this.txtComment.Lines = lstData.ToArray();
			}
			else
			{
				this.txtComment.Lines = File.ReadAllLines(linkPath);
			}
			this.TxtComment_TextChanged(null, null);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x001CB7EC File Offset: 0x001C99EC
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblTitle);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.lblFooter);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00069C18 File Offset: 0x00067E18
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00069C18 File Offset: 0x00067E18
		private void BtnSave_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00069C18 File Offset: 0x00067E18
		private void metroButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x001CB850 File Offset: 0x001C9A50
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

		// Token: 0x06000A1C RID: 2588 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x001CB96C File Offset: 0x001C9B6C
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtComment.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.lblStatus.Text = this.status + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWT2JsQlJQVDA9")))))))) + list.Count.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGU2RsQlJQVDA9"))))))));
			}
			catch
			{
			}
		}

		// Token: 0x04000E9D RID: 3741
		private string linkPath = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x04000E9E RID: 3742
		private string status = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
	}
}
