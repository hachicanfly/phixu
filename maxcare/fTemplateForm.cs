using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace maxcare
{
	// Token: 0x020000A7 RID: 167
	public partial class fTemplateForm : Form
	{
		// Token: 0x06000641 RID: 1601 RVA: 0x00002D25 File Offset: 0x00000F25
		public fTemplateForm()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000C34F0 File Offset: 0x000C16F0
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
