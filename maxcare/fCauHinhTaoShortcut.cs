using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000E6 RID: 230
	public partial class fCauHinhTaoShortcut : Form
	{
		// Token: 0x0600093C RID: 2364 RVA: 0x00185698 File Offset: 0x00183898
		public fCauHinhTaoShortcut()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVVZucFZkMWRzYUV0aFJtdDZWV3RvWVZaNlZuTlpNakZIWTNjOVBRPT0=")))))))), false);
			this.ChangeLanguage();
			fCauHinhTaoShortcut.isOK = false;
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZod2Qxa3hWa2xUYmxwaFRUQndiMWxzVGtOU01rWllaVWQ0YW1WVlJuWmFWVkp1VFd0MFYyVkZhR2xOYW14MVdXdGtWMWt4UlhsaFNHeHBUV3BHYzFkRlZrZGtNazVJWlVoQ1drMXJXWGRaVm1NMVpGWm9TRlJ0T1dwaVZHd3dWMnhOTVdKSFZraFdWREE5"))))))));
			string string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZod2Qxa3hWa2xUYmxwaFRUQndiMWxzVGtOU01rWllaVWQ0YW1WVlJuWmFWVkphVFVWMFYyVkZhR2xOYW14MVdXdGtWMWt4UlhsaFNHeHBUV3BHYzFkRlZrZGtNazVJWlVoQ1drMXJXWGRaVm1NMVpGWm9TRlJ0T1dwaVZHd3dWMnhOTVdKSFZraFdWREE5"))))))));
			string string3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZod2Qxa3hWa2xUYmxwaFRUQndiMWxzVGtOU01rWllaVWQ0YWsxWWFFbFpha2sxWW0xS1NGWnRUbEpOYldnMVdXcEplR0pHYUVaU2JtUnFVak5vZDFkVVNrZE5SMFpZVDFoV1dWSXdOWFpaTWpBMVpFWndWRTVYZUd4U01WVTU="))))))));
			bool flag = !File.Exists(@string);
			if (flag)
			{
				bool flag2 = !File.Exists(string2);
				if (flag2)
				{
					bool flag3 = File.Exists(string3);
					if (flag3)
					{
						this.pathChromeOrigin = string3;
					}
				}
				else
				{
					this.pathChromeOrigin = string2;
				}
			}
			else
			{
				this.pathChromeOrigin = @string;
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00185890 File Offset: 0x00183A90
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.metroButton1);
			Language.GetValue(this.label2);
			Language.GetValue(this.metroButton2);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00185918 File Offset: 0x00183B18
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			bool flag = this.txtPathShortcut.Text.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWVEZVVlc1b2VWSkZaSFpaTTJ4Q1dXMHhhbG94Y0U1VU1tdzJVMVUxTVZOVk1WUlZibU15WTJzeGJsWjZVbTVXYTJSeFVqTk9SRkZ1VW10Wk0yeHhWMWhzUTJNemFIbFJha1pLVW1zMWRsbHFUa3ROUm10NlZtcENTbFZVTURrPQ=="))))))))), 3);
			}
			else
			{
				bool flag2 = this.txtPathChromeOrigin.Text.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWVEZVVlc1b2VWSkZaSFpaTTJ4Q1dXMHhhbG94Y0U1VU1tdzJVMVUxTVZOVk1WUlZibU15WTJzeGJsWjZVbTVYVkVwdlpWZEplVTFYZUUxaVZsa3dWMnhPUmxCUlBUMD0="))))))))), 3);
				}
				else
				{
					bool flag3 = !this.txtPathChromeOrigin.Text.Trim().EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyVlhTWGxOVjNoTllsWlpNRmRzUlRsUVVUMDk=")))))))));
					if (flag3)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSXpUazVaVjJnMlUxVktNVmR1YkVOaE0yTXlWRVV4YmsxcVVtNWxSWEJKVWtoR2VtVlZTbWxoVlVweFdWVm9TMlJ0U2xoV1dGWmhWMGRvYzFOVlpEQmlNMk16Vlc1V1lXVlZTblpsU0VaSlZGYzRlbEZYWkdsVVZUbDRaV3QwVG1GQlBUMD0="))))))))), 3);
					}
					else
					{
						this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VtczFkbGxxVGt0TlJtdDZWbXBCUFE9PQ==")))))))), this.txtPathShortcut.Text.Trim());
						this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VsVTFkbGt5TURWa1JuQldUMWhzYUZZeVVuZFpiV001VUZFOVBRPT0=")))))))), this.txtPathChromeOrigin.Text.Trim());
						this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
						fCauHinhTaoShortcut.isOK = true;
						base.Close();
					}
				}
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00069C18 File Offset: 0x00067E18
		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00185CB4 File Offset: 0x00183EB4
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.txtPathShortcut.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VtczFkbGxxVGt0TlJtdDZWbXBCUFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			bool flag = this.txtPathShortcut.Text.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || !Directory.Exists(this.txtPathShortcut.Text.Trim());
			if (flag)
			{
				this.txtPathShortcut.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			}
			bool flag2 = File.Exists(this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VsVTFkbGt5TURWa1JuQldUMWhzYUZZeVVuZFpiV001VUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			if (flag2)
			{
				this.txtPathChromeOrigin.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VsVTFkbGt5TURWa1JuQldUMWhzYUZZeVVuZFpiV001VUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			else
			{
				this.txtPathChromeOrigin.Text = this.pathChromeOrigin;
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00185F90 File Offset: 0x00184190
		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.txtPathShortcut.Text = Common.SelectFolder();
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00185FB4 File Offset: 0x001841B4
		private void metroButton2_Click(object sender, EventArgs e)
		{
			this.txtPathChromeOrigin.Text = Common.SelectFile(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyUnVjRXhVYmxaS1VsWndkMWxyWkZaUVVUMDk="))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
		}

		// Token: 0x04000D13 RID: 3347
		public static bool isOK;

		// Token: 0x04000D14 RID: 3348
		private string pathChromeOrigin = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x04000D15 RID: 3349
		private JSON_Settings settings;
	}
}
