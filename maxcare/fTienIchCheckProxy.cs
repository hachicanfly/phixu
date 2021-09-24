using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x020000DA RID: 218
	public partial class fTienIchCheckProxy : Form
	{
		// Token: 0x060008E1 RID: 2273 RVA: 0x00002E41 File Offset: 0x00001041
		public fTienIchCheckProxy()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00176610 File Offset: 0x00174810
		private void ChangeLanguage()
		{
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.label3);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00176640 File Offset: 0x00174840
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				int typeProxy = this.cbbTypeProxy.SelectedIndex;
				List<string> list = new List<string>();
				list = this.txtInput.Lines.ToList<string>();
				int iThread = 0;
				int num = 10;
				this.lblStatus.Invoke(new MethodInvoker(delegate()
				{
					this.lblStatus.Visible = true;
				}));
				int i = 0;
				while (i < list.Count)
				{
					bool flag = iThread < num;
					if (flag)
					{
						Interlocked.Increment(ref iThread);
						string mail = list[i++];
						new Thread(delegate()
						{
							bool flag2 = this.CheckAccountMail(mail, typeProxy);
							if (flag2)
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

		// Token: 0x060008E5 RID: 2277 RVA: 0x00176890 File Offset: 0x00174A90
		private void AddRowIntoTextbox(RichTextBox txt, string content)
		{
			txt.Invoke(new MethodInvoker(delegate()
			{
				Application.DoEvents();
				RichTextBox txt2 = txt;
				txt2.Text = txt2.Text + content + "\r\n";
			}));
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x001768D4 File Offset: 0x00174AD4
		private bool CheckAccountMail(string proxy, int typeProxy)
		{
			try
			{
				bool flag = Common.CheckProxy(proxy, typeProxy, 30) != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0017698C File Offset: 0x00174B8C
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtInput.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.groupBox1.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VtdEtOVmxxVG05T1ZXeEVZVVJrVGxORVFuYz0="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00176A50 File Offset: 0x00174C50
		private void txtOutput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtDaTao.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.grDaTao.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWV2MxWXhTbFJSVnpnOQ==")))))))) + list.Count.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))));
			}
			catch
			{
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00176B54 File Offset: 0x00174D54
		private void fTienIchLocTrung_Load(object sender, EventArgs e)
		{
			this.cbbTypeProxy.SelectedIndex = 0;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00176B78 File Offset: 0x00174D78
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtChuaTao.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.grChuaTao.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0V2MxSnJiRVJhZWpBOQ==")))))))) + list.Count.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))));
			}
			catch
			{
			}
		}
	}
}
