using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;

namespace maxcare
{
	// Token: 0x0200009D RID: 157
	public partial class fSelectFolder : Form
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x000B3D30 File Offset: 0x000B1F30
		public fSelectFolder()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fSelectFolder.pathFolder = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000B3DA4 File Offset: 0x000B1FA4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label2);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000B3DF8 File Offset: 0x000B1FF8
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			fSelectFolder.pathFolder = this.txtPathFolder.Text.Trim();
			bool flag = fSelectFolder.pathFolder == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWVEZVVlc1b2VWSkZaSFpaTTJ4Q1dXMHhhbG94Y0U1VU1tdzJVMVUxTVZOVlZtRmtiVXBJVlcxNGFtRlZWVGs9"))))))))), 2);
				this.txtPathFolder.Focus();
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000B3EF0 File Offset: 0x000B20F0
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			fSelectFolder.pathFolder = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x04000567 RID: 1383
		public static string pathFolder = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
	}
}
