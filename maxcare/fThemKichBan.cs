using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using MetroFramework;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000125 RID: 293
	public partial class fThemKichBan : Form
	{
		// Token: 0x06000D42 RID: 3394 RVA: 0x00297230 File Offset: 0x00295430
		public fThemKichBan(int type, string id = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.type = type;
			this.id = id;
			bool flag = type == 1;
			if (flag)
			{
				this.bunifuCustomLabel1.Text = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHRlljRXhVYm1SS1VucFdkbVI2V2sxVVZ6aDZWVmRrYUUxdE5VNWlla3BQWWpCc1NGTnRhRFpUVjNneA==")))))))));
				this.btnAdd.Text = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHRlljRXhVYm1SS1VucFdkbVI2V2sxVVZ6aDZWVlF3UFE9PQ==")))))))));
				this.txtTen.Text = InteractSQL.GetKichBanById(id).Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))].ToString();
			}
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x002973E0 File Offset: 0x002955E0
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label2);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00069C18 File Offset: 0x00067E18
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00297434 File Offset: 0x00295634
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string text = this.txtTen.Text.Trim();
			bool flag = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV2hWVWtoR2RFNUhaR2hOYlRWT1lucEtUMkl3YkVoVGJXZzJVMWQ0TVZOV1JUbFFVVDA5"))))))))), 2);
			}
			else
			{
				bool flag2 = this.type == 0;
				if (flag2)
				{
					bool flag3 = InteractSQL.InsertKichBan(text);
					if (flag3)
					{
						base.Close();
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
					}
				}
				else
				{
					bool flag4 = InteractSQL.UpdateKichBan(this.id, text);
					if (flag4)
					{
						base.Close();
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25Kak1HeEpWMnBHYUZVd1NucFphbWcxVVZkS2RGa3laR3RTTW5CSVl6QXhOVk5yYkVobFIyZzJVekExZDFOVmFFOWhSMUpVVWxRd1BRPT0="))))))))), 2);
					}
				}
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00297620 File Offset: 0x00295820
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			bool flag = this.panel1.BorderStyle == BorderStyle.FixedSingle;
			if (flag)
			{
				int num = 1;
				int num2 = num / 2;
				using (Pen pen = new Pen(Color.DarkViolet, (float)num))
				{
					e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, this.panel1.ClientSize.Width - num, this.panel1.ClientSize.Height - num));
				}
			}
		}

		// Token: 0x040015F6 RID: 5622
		private int type = 0;

		// Token: 0x040015F7 RID: 5623
		private string id = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
	}
}
