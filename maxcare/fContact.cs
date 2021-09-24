using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Properties;

namespace maxcare
{
	// Token: 0x0200009E RID: 158
	public partial class fContact : Form
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x00002BF1 File Offset: 0x00000DF1
		public fContact()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x000B5290 File Offset: 0x000B3490
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label10);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00069C18 File Offset: 0x00067E18
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000B52D4 File Offset: 0x000B34D4
		private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string text = (sender as LinkLabel).Text;
			try
			{
				Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyVlhTWGxOVjNoTllsWlpNRmRzUlRsUVVUMDk=")))))))), text);
			}
			catch
			{
				Process.Start(text);
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000B52D4 File Offset: 0x000B34D4
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string text = (sender as LinkLabel).Text;
			try
			{
				Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyVlhTWGxOVjNoTllsWlpNRmRzUlRsUVVUMDk=")))))))), text);
			}
			catch
			{
				Process.Start(text);
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x000B52D4 File Offset: 0x000B34D4
		private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string text = (sender as LinkLabel).Text;
			try
			{
				Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyVlhTWGxOVjNoTllsWlpNRmRzUlRsUVVUMDk=")))))))), text);
			}
			catch
			{
				Process.Start(text);
			}
		}
	}
}
