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
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000E2 RID: 226
	public partial class fTienIchLocTrung : Form
	{
		// Token: 0x0600090C RID: 2316 RVA: 0x00002F15 File Offset: 0x00001115
		public fTienIchLocTrung()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0017BC88 File Offset: 0x00179E88
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblTitle);
			Language.GetValue(this.rbNhapTuFile);
			Language.GetValue(this.btnNhapTuFile);
			Language.GetValue(this.rbTuNhap);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0017BCDC File Offset: 0x00179EDC
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> source = new List<string>();
				string text = this.txtNhapTuFile.Text.Trim();
				bool @checked = this.rbNhapTuFile.Checked;
				if (@checked)
				{
					bool flag = text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMVUwNUhVa0pRVkRBOQ==")))))))));
					if (flag)
					{
						bool flag2 = !File.Exists(text);
						if (flag2)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweGMyTXhjRlJSYlhNd1dXNVdNbE5WWkRSalJGSnBaRlZvYTFVd1NqRlpWVGxJVG01S1dWRlhaR2hOYlhCRlpFVmpNV0pyYkVsV1IyZ3hUbFUxTVZOVmFGVmhTRlo0VW01Q1NsVlVNRGs9"))))))))), 2);
						}
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweGMyTXhjRlJSYmxab1ZEQmpNbU5zYUVKYU1sSjZWREprYVdWVlNuRlpWVGxJVGpKc1ZGRnRPREJaYmxaWlUxVm9VMlZVVW1sa1YzQktWRlpPVTA1SFNqRlZiVVpVVVdwSk1GbHVWbWxaVms1RFVqSkdXR1ZIZUVwUk1tUXhXa1ZvYjAxRmRGUlNWREE5"))))))))), 2);
					}
				}
				bool checked2 = this.rbNhapTuFile.Checked;
				if (checked2)
				{
					source = File.ReadAllLines(text).ToList<string>();
				}
				else
				{
					bool checked3 = this.rbTuNhap.Checked;
					if (checked3)
					{
						source = this.txtInput.Lines.ToList<string>();
					}
				}
				List<string> list = source.Distinct<string>().ToList<string>();
				this.txtOutput.Lines = list.ToArray();
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYmswd1dXNVdUMWRZYkVOT1IwbDVUbGMxU2xWVU1Eaz0="))))))))), 1);
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGxyT1VoT01uZDVZVEprYkZRd1l6SmllazV5V2pKT2RGSllUa3BUUm05NFdWWk9RMk16WXpOVGJsWmhaVlZKZDFsVk9VaE9NMHBVVVc1Tk1GbHVSbTlaVms1RFpXeHNXVlpYWnowPQ=="))))))))), 2);
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0017BF98 File Offset: 0x0017A198
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtInput.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.rbTuNhap.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zNVNFNHpUbFJSYmxab1ZEQmpNbU5zYUVKYU1IUkpZek5rYlZVeWN6az0="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0017C05C File Offset: 0x0017A25C
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNhapTuFile.Enabled = this.rbNhapTuFile.Checked;
			this.btnNhapTuFile.Enabled = this.rbNhapTuFile.Checked;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0017C0AC File Offset: 0x0017A2AC
		private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.txtInput.Enabled = this.rbTuNhap.Checked;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0017C0DC File Offset: 0x0017A2DC
		private void btnNhapTuFile_Click(object sender, EventArgs e)
		{
			this.txtNhapTuFile.Text = Common.SelectFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NXRklWVEJOV0ZaS1VsWndkMWxyWkZaYU1sSkpZVVJCUFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUZiRVpYYmtKcFVqRmFObE5WVG01alZYaDFWV3BTYTFFeWR6UlRNbXN4VFVkV1NWVnFaejA9")))))))));
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0017C18C File Offset: 0x0017A38C
		private void txtOutput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtOutput.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.groupBox2.Text = string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtST1YwMUhUa2xXYWtKS1VUSm5NMVJWWjNkalFUMDk=")))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0017C24C File Offset: 0x0017A44C
		private void fTienIchLocTrung_Load(object sender, EventArgs e)
		{
			this.radioButton1_CheckedChanged(null, null);
			this.rbTuNhap_CheckedChanged(null, null);
		}
	}
}
