using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000070 RID: 112
	public partial class fEditFile : Form
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x00002A5C File Offset: 0x00000C5C
		public fEditFile(string idFile, string namefile)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.idFile = idFile;
			this.nameFileOld = namefile;
			this.isSuccess = false;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0006B4C4 File Offset: 0x000696C4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0006B528 File Offset: 0x00069728
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			string text = this.txtNameFileNew.Text.Trim();
			bool flag = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WTVZSVmJVWnNVbnBrYmxaNlVtNWFSVEZRWTFkS2NGRnFRbWhVVjBZelUxVmplbUZJVlRKV2JYQktVbnBPYjJSVVZqQmpSV3hTVUZRd1BRPT0="))))))))), 3);
				this.txtNameFileNew.Focus();
			}
			else
			{
				bool flag2 = CommonSQL.CheckExitsFile(text);
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVHTlhTbkJSYWtKb1ZGZEdNMU5WWTNwaFNGVXlWbTF3U2xKNlpFVmlNR2h5V2pOb1MxTkZVblpsVlVsM1RrZEtNVlpIU25CUmFrRXdXVzVHYjFsV1RqTmFNbEoxVm01Q1NsSXpjRVZqTWpBeFltdHNTRTVYT0RCWmJrWXdXVEJPUTAxSVl6SmpTRlpLVWpOU2RtUjZXa2RoYTJ4U1VGUXdQUT09"))))))))), 3);
					this.txtNameFileNew.Focus();
				}
				else
				{
					bool flag3 = text.Equals(this.txtNameFileOld.Text.Trim());
					if (flag3)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVHTlhTbkJSYWtKb1ZGZEdNMU5WWTNwaFNGVXlWbTF3U2xKNlRtOWtWRll3WTBWc1NWRnRPREJaYmtaeFdWWk9RMk50Ums1VU1taGFaVlZKZDFsVk1XaGtNR3hJVFRKb01VNXNXbkZUVldSUlVtNUdWRkpVTUQwPQ=="))))))))), 3);
						this.txtNameFileNew.Focus();
					}
					else
					{
						bool flag4 = CommonSQL.UpdateFileNameToDatabase(this.idFile, text);
						if (flag4)
						{
							this.isSuccess = true;
							bool flag5 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeEpWVzA1TTA1clNqRlpWVTVEWVc1ak0xVnVWbUZsV0dSdVYxY3hTVlJYT0hsT1IyUmFUV2s1VGxveFRrTmtSMUpxVkhwQ05sTlZXakZUVlRGVVZXMUpOR1ZWU21saVYwNXVWMVJvYUdRemNFcGlSMmhLVTBaQ1JXUkZNVFZUYkVJelVGUXdQUT09")))))))))) == DialogResult.Yes;
							if (flag5)
							{
								base.Close();
							}
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZOMFNFNXVTbGxSVjJScFlsZHdiMlJZUlhoTlJXeEpWa1ZTZUdKVVVtNWFSV1J4VWpOT1JGRnVVVEJaYmxaelYxaHNRMk42VW1sa1ZtaG9WVEJWT1E9PQ=="))))))))), 1);
						}
					}
				}
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0006B804 File Offset: 0x00069A04
		private void txbNameFile_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.BtnAdd_Click(null, null);
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0006B83C File Offset: 0x00069A3C
		private void fEditFile_Load(object sender, EventArgs e)
		{
			this.txtNameFileOld.Text = this.nameFileOld;
		}

		// Token: 0x0400033C RID: 828
		private string idFile;

		// Token: 0x0400033D RID: 829
		private string nameFileOld;

		// Token: 0x0400033E RID: 830
		public bool isSuccess = false;
	}
}
