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
	// Token: 0x020000D6 RID: 214
	public partial class fTienIchCheckLiveUid : Form
	{
		// Token: 0x060008CD RID: 2253 RVA: 0x00002DD7 File Offset: 0x00000FD7
		public fTienIchCheckLiveUid()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00173B4C File Offset: 0x00171D4C
		private void ChangeLanguage()
		{
			Language.GetValue(this.groupBox1);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00173B6C File Offset: 0x00171D6C
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				list = this.txtInput.Lines.ToList<string>();
				int iThread = 0;
				int num = Convert.ToInt32(this.nudThread.Value);
				bool flag = num == 0;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxOMFNFNHlkRlJSYms1cldsVmpNMkY2U1RGaWEyeEpVVzA0TUZsdVJuRlpWazVDU3pBeFJHUXlaR3RpYkZwM1UxVmtObEpJVG5ST1Z6VktVbnBXZGs1SFNuaGtSMDVFVVc1Tk1GbHVSbTlaVms1R1VGRTlQUT09"))))))))), 3);
				}
				else
				{
					bool flag2 = list.Count < num;
					if (flag2)
					{
						num = list.Count;
					}
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
							string uid = list[i++];
							new Thread(delegate()
							{
								string text = CommonRequest.CheckLiveWall(uid);
								bool flag4 = text.StartsWith("0|");
								if (flag4)
								{
									this.AddRowIntoTextbox(this.txtDie, uid);
								}
								else
								{
									bool flag5 = text.StartsWith("1|");
									if (flag5)
									{
										this.AddRowIntoTextbox(this.txtLive, uid);
									}
									else
									{
										this.AddRowIntoTextbox(this.txtKhongCheckDuoc, uid);
									}
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
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGxyT1VoT01uZDVZVEprYkZRd1l6SmllazV5V2pKT2RGSllUa3BUUm05NFdWWk9RMk16WXpOVGJsWmhaVlZKZDFsVk9VaE9NMHBVVVc1Tk1GbHVSbTlaVms1RFpXeHNXVlpYWnowPQ=="))))))))), 2);
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00173E3C File Offset: 0x0017203C
		private void AddRowIntoTextbox(RichTextBox txt, string content)
		{
			txt.Invoke(new MethodInvoker(delegate()
			{
				Application.DoEvents();
				RichTextBox txt2 = txt;
				txt2.Text = txt2.Text + content + "\r\n";
			}));
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00173E80 File Offset: 0x00172080
		private void TxtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtInput.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.groupBox1.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VteGFkMWRyVGtKaU1sWTJVV3BzVEZWVU1Eaz0="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00173F44 File Offset: 0x00172144
		private void txtOutput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtLive.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.grDaTao.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWV2MxWXhTbFJSVnpnOQ==")))))))) + list.Count.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))));
			}
			catch
			{
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00069C18 File Offset: 0x00067E18
		private void fTienIchLocTrung_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00174048 File Offset: 0x00172248
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtDie.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.grChuaTao.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0V2MxSnJiRVJhZWpBOQ==")))))))) + list.Count.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))));
			}
			catch
			{
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0017414C File Offset: 0x0017234C
		private void txtKhongCheckDuoc_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtKhongCheckDuoc.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.grKhongCheckDuoc.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFkbGRzWkU5amEyeE9WVEZLTkdOclVtOWtWRnBQWVd0c1JHRkVaRTVUUkVKMw=="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}
	}
}
