using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace maxcare
{
	// Token: 0x020000A8 RID: 168
	public partial class fHelpNhapComment : Form
	{
		// Token: 0x06000647 RID: 1607 RVA: 0x00002D44 File Offset: 0x00000F44
		public fHelpNhapComment()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000C43B0 File Offset: 0x000C25B0
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
