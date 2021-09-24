using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using maxcare.Helper;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000A9 RID: 169
	public partial class fShowProgressBar : Form
	{
		// Token: 0x0600064D RID: 1613 RVA: 0x00002D63 File Offset: 0x00000F63
		public fShowProgressBar(List<string> lstPathFolder)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.lstPathFolder = lstPathFolder;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000C55CC File Offset: 0x000C37CC
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblproccess);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000C55EC File Offset: 0x000C37EC
		private void frm_progress_Load(object sender, EventArgs e)
		{
			try
			{
				new Thread(delegate()
				{
					string sourceDirName = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					string destDirName = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					int count = 0;
					int total = this.lstPathFolder.Count;
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						this.lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lòng chờ ({0}/{1})..."), count, total);
					}));
					for (int i = 0; i < this.lstPathFolder.Count; i++)
					{
						sourceDirName = this.lstPathFolder[i].Split(new char[]
						{
							'|'
						})[0];
						destDirName = this.lstPathFolder[i].Split(new char[]
						{
							'|'
						})[1];
						bool flag = FileHelper.DirectoryCopy(sourceDirName, destDirName, true);
						if (flag)
						{
							int count2 = count;
							count = count2 + 1;
						}
						double percentage = (double)count * 1.0 / (double)total * 100.0;
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							this.lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lòng chờ ({0}/{1})..."), count, total);
							this.progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
						}));
					}
					base.BeginInvoke(new MethodInvoker(delegate()
					{
						base.Close();
					}));
				}).Start();
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4b1MyVlhTWHBUVkZwS1VWUXdPUT09")))))))) + ex.Message, 2);
				base.Close();
			}
		}

		// Token: 0x04000603 RID: 1539
		private List<string> lstPathFolder = new List<string>();
	}
}
