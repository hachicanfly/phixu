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
	// Token: 0x0200012F RID: 303
	public partial class fAddFile : Form
	{
		// Token: 0x06000DD0 RID: 3536 RVA: 0x0000323C File Offset: 0x0000143C
		public fAddFile()
		{
			this.InitializeComponent();
			fAddFile.isAdd = false;
			this.ChangeLanguage();
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x002C036C File Offset: 0x002BE56C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x002C03C0 File Offset: 0x002BE5C0
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			string text = this.txbNameFile.Text.Trim();
			bool flag = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WTVZSVmJVWnNVbnBrYmxaNlVtNWFSVEZRWTFkS2NGRnFRbWhVVjBZelUxVmplbUZJVlRKV2JYQktWVlF3T1E9PQ=="))))))))), 1);
				this.txbNameFile.Focus();
			}
			else
			{
				bool flag2 = CommonSQL.CheckExitsFile(text);
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVHTlhTbkJSYWtKb1ZGZEdNMU5WWTNwaFNGVXlWbTF3U2xKNlpFVmlNR2h5V2pOb1MxTkZVblpsVlVsM1RrZEtNVlpIU25CUmFrRXdXVzVHYjFsV1RqTmFNbEoxVm01Q1NsSXpjRVZqTWpBeFltdHNTRTVYT0RCWmJrWXdXVEJPUTAxSVl6SmpTRlpLVWpOU2RtUjZXa2RoYTJ4U1VGUXdQUT09"))))))))), 1);
					this.txbNameFile.Focus();
				}
				else
				{
					bool flag3 = CommonSQL.InsertFileToDatabase(text);
					if (flag3)
					{
						fAddFile.isAdd = true;
						bool flag4 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklSblJOUjJSclVqSndSV0l3WXpGaU1HeElWVVZTTUZKNlZuVlVSVTVEWVZac2FtVlhjR2xoVlVweFdXcG9OVkZyYkVoTlZFWXpUakZTVGxveFl6QmFNMmhMVW01YU5sTlZXakZYYm14RFlXNW9lVkpGTVhCV01GWnVXWHBvVUUxSWNFcGhlVGc5")))))))))) == DialogResult.Yes;
						if (flag4)
						{
							base.Close();
						}
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklSblJOUjJSclVqSndTR013VGtOa1JGSnBaRmQ0V21WVlNucE9SMG94VjBkR1ZGSlVNRDA9"))))))))), 1);
					}
				}
			}
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x002C05FC File Offset: 0x002BE7FC
		private void txbNameFile_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.BtnAdd_Click(null, null);
			}
		}

		// Token: 0x04001743 RID: 5955
		public static bool isAdd;
	}
}
