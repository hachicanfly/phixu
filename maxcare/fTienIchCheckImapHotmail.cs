using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000DE RID: 222
	public partial class fTienIchCheckImapHotmail : Form
	{
		// Token: 0x060008F5 RID: 2293 RVA: 0x00002EAB File Offset: 0x000010AB
		public fTienIchCheckImapHotmail()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00178EB4 File Offset: 0x001770B4
		private void ChangeLanguage()
		{
			Language.GetValue(this.rbNhapTuFile);
			Language.GetValue(this.btnNhapTuFile);
			Language.GetValue(this.rbTuNhap);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00178EF8 File Offset: 0x001770F8
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
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
					list = File.ReadAllLines(text).ToList<string>();
				}
				else
				{
					bool checked3 = this.rbTuNhap.Checked;
					if (checked3)
					{
						list = this.txtInput.Lines.ToList<string>();
					}
				}
				int iThread = 0;
				int num = 10;
				this.lblStatus.Invoke(new MethodInvoker(delegate()
				{
					this.lblStatus.Visible = true;
				}));
				int i = 0;
				while (i < list.Count)
				{
					bool flag3 = iThread < num;
					if (flag3)
					{
						Interlocked.Increment(ref iThread);
						string mail = list[i++];
						new Thread(delegate()
						{
							bool flag4 = this.CheckAccountMail(mail);
							if (flag4)
							{
								this.AddRowIntoTextbox(this.txtDaTao, mail);
							}
							else
							{
								this.AddRowIntoTextbox(this.txtChuaTao, mail);
							}
							Interlocked.Decrement(ref iThread);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Common.DelayTime(1.0);
					}
				}
				while (iThread > 0)
				{
					Common.DelayTime(1.0);
				}
				this.lblStatus.Invoke(new MethodInvoker(delegate()
				{
					this.lblStatus.Visible = false;
				}));
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhCb1VqRmFjVmxZYkVOT1IwbDVUbGMxU2xWVU1Eaz0="))))))))), 1);
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGxyT1VoT01uZDVZVEprYkZRd1l6SmllazV5V2pKT2RGSllUa3BUUm05NFdWWk9RMk16WXpOVGJsWmhaVlZKZDFsVk9VaE9NMHBVVVc1Tk1GbHVSbTlaVms1RFpXeHNXVlpYWnowPQ=="))))))))), 2);
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x001792C8 File Offset: 0x001774C8
		private void AddRowIntoTextbox(RichTextBox txt, string content)
		{
			txt.Invoke(new MethodInvoker(delegate()
			{
				Application.DoEvents();
				RichTextBox txt2 = txt;
				txt2.Text = txt2.Text + content + "\r\n";
			}));
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0017930C File Offset: 0x0017750C
		private bool CheckAccountMail(string mail)
		{
			bool result;
			try
			{
				string[] array = mail.Split(new char[]
				{
					'|'
				});
				string imap = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text = array[0];
				string text2 = array[1];
				bool flag = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || text2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					result = false;
				}
				else
				{
					bool flag2 = array.Length > 2;
					if (flag2)
					{
						imap = array[2];
					}
					result = (Common.CheckAccountHotmail(text, text2, imap) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9")))))))));
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x001794F8 File Offset: 0x001776F8
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

		// Token: 0x060008FC RID: 2300 RVA: 0x001795BC File Offset: 0x001777BC
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNhapTuFile.Enabled = this.rbNhapTuFile.Checked;
			this.btnNhapTuFile.Enabled = this.rbNhapTuFile.Checked;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0017960C File Offset: 0x0017780C
		private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.txtInput.Enabled = this.rbTuNhap.Checked;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0017963C File Offset: 0x0017783C
		private void btnNhapTuFile_Click(object sender, EventArgs e)
		{
			this.txtNhapTuFile.Text = Common.SelectFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NXRklWVEJOV0ZaS1VsWndkMWxyWkZaYU1sSkpZVVJCUFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUZiRVpYYmtKcFVqRmFObE5WVG01alZYaDFWV3BTYTFFeWR6UlRNbXN4VFVkV1NWVnFaejA9")))))))));
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x001796EC File Offset: 0x001778EC
		private void txtOutput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtDaTao.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.grDaTao.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRlJSVnpsc1pXdEpOVk14UlRsUVVUMDk="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x001797B0 File Offset: 0x001779B0
		private void fTienIchLocTrung_Load(object sender, EventArgs e)
		{
			this.radioButton1_CheckedChanged(null, null);
			this.rbTuNhap_CheckedChanged(null, null);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x001797DC File Offset: 0x001779DC
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtChuaTao.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.grChuaTao.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkZiRVJoUkdST1UwUkNkdz09"))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}
	}
}
