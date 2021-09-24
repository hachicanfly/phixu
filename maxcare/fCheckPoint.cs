using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x0200006B RID: 107
	public partial class fCheckPoint : Form
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x00065014 File Offset: 0x00063214
		public fCheckPoint()
		{
			this.InitializeComponent();
			fCheckPoint.isOK = false;
			this.setting = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWU1RXMW9jMWRVU2pCa01rbDVZa2hXYTFGVU1Eaz0=")))))))), false);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00065090 File Offset: 0x00063290
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.ckbCaptcha.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxTYm1SclVqQTFkbGRXUlRsUVVUMDk=")))))))), false);
				int valueInt = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpVYldocVUwWktjVmxWWkVaUVVUMDk=")))))))), 0);
				bool flag = valueInt == 0;
				if (flag)
				{
					this.rb2Captcha.Checked = true;
				}
				else
				{
					bool flag2 = valueInt == 1;
					if (flag2)
					{
						this.rbGuru.Checked = true;
					}
					else
					{
						this.rbAnyCaptcha.Checked = true;
					}
				}
				this.txt2Captcha.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUZNWEpVYldocVUwWktjVmxWWkVaUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.txtGuru.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdTWHBXYm14clZWUXdPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.txtAnyCaptcha.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGhPVkZaU1RXdGFNMXBGWkU5aU1XeFNVRlF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.ckbPhone.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWa2hoU0ZwcFlsWlZPUT09")))))))), false);
				int valueInt2 = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRVYmtKcFZWUXdPUT09")))))))), 0);
				bool flag3 = valueInt2 == 0;
				if (flag3)
				{
					this.rbTextNow.Checked = true;
				}
				else
				{
					bool flag4 = valueInt2 == 1;
					if (flag4)
					{
						this.rbOtpSim.Checked = true;
					}
					else
					{
						bool flag5 = valueInt2 == 2;
						if (flag5)
						{
							this.rbSimCode.Checked = true;
						}
						else
						{
							bool flag6 = valueInt2 == 3;
							if (flag6)
							{
								this.rbOtpmmo.Checked = true;
							}
							else
							{
								this.rbPrimeOtp.Checked = true;
							}
						}
					}
				}
				this.txtTextNow.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXa2hXYWxKclVsUldNbHBJWXpsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.txtOtpSim.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVWHBWYm1SV1RXMTRNQT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.txtSimCode.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWWGxpU0ZKU1RXcHNjbGRzUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.txtOtpmmo.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVWHBWYm1ScFZucEdNZz09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.txtPrimeOtp.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2xUYmtKcFZqRmFVVnBGYUVKUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.nudTime.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZWUXdPUT09")))))))), 120);
				this.ckbImage.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUbGhOVjJoaFRXeFZPUT09")))))))), false);
				this.txtImage.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdUbGhOVjJoaFRXeFZPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00065A7C File Offset: 0x00063C7C
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxTYm1SclVqQTFkbGRXUlRsUVVUMDk=")))))))), this.ckbCaptcha.Checked);
				int num = 0;
				bool @checked = this.rb2Captcha.Checked;
				if (@checked)
				{
					num = 0;
				}
				bool checked2 = this.rbGuru.Checked;
				if (checked2)
				{
					num = 1;
				}
				else
				{
					bool checked3 = this.rbAnyCaptcha.Checked;
					if (checked3)
					{
						num = 2;
					}
				}
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpVYldocVUwWktjVmxWWkVaUVVUMDk=")))))))), num);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUZNWEpVYldocVUwWktjVmxWWkVaUVVUMDk=")))))))), this.txt2Captcha.Text);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdTWHBXYm14clZWUXdPUT09")))))))), this.txtGuru.Text);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGhPVkZaU1RXdGFNMXBGWkU5aU1XeFNVRlF3UFE9PQ==")))))))), this.txtAnyCaptcha.Text);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWa2hoU0ZwcFlsWlZPUT09")))))))), this.ckbPhone.Checked);
				int num2 = 0;
				bool checked4 = this.rbTextNow.Checked;
				if (checked4)
				{
					num2 = 0;
				}
				bool checked5 = this.rbOtpSim.Checked;
				if (checked5)
				{
					num2 = 1;
				}
				else
				{
					bool checked6 = this.rbSimCode.Checked;
					if (checked6)
					{
						num2 = 2;
					}
					else
					{
						bool checked7 = this.rbOtpmmo.Checked;
						if (checked7)
						{
							num2 = 3;
						}
						else
						{
							bool checked8 = this.rbPrimeOtp.Checked;
							if (checked8)
							{
								num2 = 4;
							}
						}
					}
				}
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRVYmtKcFZWUXdPUT09")))))))), num2);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXa2hXYWxKclVsUldNbHBJWXpsUVVUMDk=")))))))), this.txtTextNow.Text);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVWHBWYm1SV1RXMTRNQT09")))))))), this.txtOtpSim.Text);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWWGxpU0ZKU1RXcHNjbGRzUlRsUVVUMDk=")))))))), this.txtSimCode.Text);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVWHBWYm1ScFZucEdNZz09")))))))), this.txtOtpmmo.Text);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2xUYmtKcFZqRmFVVnBGYUVKUVVUMDk=")))))))), this.txtPrimeOtp.Text);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZWUXdPUT09")))))))), this.nudTime.Value);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUbGhOVjJoaFRXeFZPUT09")))))))), this.ckbImage.Checked);
				this.setting.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdUbGhOVjJoaFRXeFZPUT09")))))))), this.txtImage.Text);
				this.setting.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				fCheckPoint.isOK = true;
				base.Close();
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaWVsSnBaRmhTU2xJemNHOWtXRVpIWTBWc1NWUnRhR3RWTUZVNQ=="))))))))), 2);
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00066290 File Offset: 0x00064490
		private void CheckedChangeFull()
		{
			this.checkBox1_CheckedChanged(null, null);
			this.ckbPhone_CheckedChanged(null, null);
			this.ckbImage_CheckedChanged(null, null);
			this.rbTextNow_CheckedChanged(null, null);
			this.rbOtpSim_CheckedChanged(null, null);
			this.rbSimCode_CheckedChanged(null, null);
			this.rb2Captcha_CheckedChanged(null, null);
			this.rbGuru_CheckedChanged(null, null);
			this.rbAnyCaptcha_CheckedChanged(null, null);
			this.rbOtpmmo_CheckedChanged(null, null);
			this.rbPrimeOtp_CheckedChanged(null, null);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00066338 File Offset: 0x00064538
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

		// Token: 0x06000447 RID: 1095 RVA: 0x000663FC File Offset: 0x000645FC
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.panel3.Enabled = this.ckbCaptcha.Checked;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0006642C File Offset: 0x0006462C
		private void ckbPhone_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.ckbPhone.Checked;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0006645C File Offset: 0x0006465C
		private void ckbImage_CheckedChanged(object sender, EventArgs e)
		{
			this.txtImage.Enabled = this.ckbImage.Checked;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0006648C File Offset: 0x0006468C
		private void rbTextNow_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbTextNow.Checked;
			if (@checked)
			{
				this.txtTextNow.Enabled = true;
				this.txtOtpSim.Enabled = false;
				this.txtSimCode.Enabled = false;
				this.txtOtpmmo.Enabled = false;
				this.txtPrimeOtp.Enabled = false;
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00066524 File Offset: 0x00064724
		private void rbOtpSim_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbOtpSim.Checked;
			if (@checked)
			{
				this.txtTextNow.Enabled = false;
				this.txtOtpSim.Enabled = true;
				this.txtSimCode.Enabled = false;
				this.txtOtpmmo.Enabled = false;
				this.txtPrimeOtp.Enabled = false;
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000665BC File Offset: 0x000647BC
		private void rbSimCode_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbSimCode.Checked;
			if (@checked)
			{
				this.txtTextNow.Enabled = false;
				this.txtOtpSim.Enabled = false;
				this.txtSimCode.Enabled = true;
				this.txtOtpmmo.Enabled = false;
				this.txtPrimeOtp.Enabled = false;
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00066654 File Offset: 0x00064854
		private void rb2Captcha_CheckedChanged(object sender, EventArgs e)
		{
			this.txt2Captcha.Enabled = this.rb2Captcha.Checked;
			this.txtGuru.Enabled = !this.rb2Captcha.Checked;
			this.txtAnyCaptcha.Enabled = !this.rb2Captcha.Checked;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000666D4 File Offset: 0x000648D4
		private void rbOtpmmo_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbOtpmmo.Checked;
			if (@checked)
			{
				this.txtTextNow.Enabled = false;
				this.txtOtpSim.Enabled = false;
				this.txtSimCode.Enabled = false;
				this.txtOtpmmo.Enabled = true;
				this.txtPrimeOtp.Enabled = false;
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0006676C File Offset: 0x0006496C
		private void rbAnyCaptcha_CheckedChanged(object sender, EventArgs e)
		{
			this.txt2Captcha.Enabled = !this.rbAnyCaptcha.Checked;
			this.txtGuru.Enabled = !this.rbAnyCaptcha.Checked;
			this.txtAnyCaptcha.Enabled = this.rbAnyCaptcha.Checked;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000667EC File Offset: 0x000649EC
		private void rbGuru_CheckedChanged(object sender, EventArgs e)
		{
			this.txt2Captcha.Enabled = !this.rbGuru.Checked;
			this.txtGuru.Enabled = this.rbGuru.Checked;
			this.txtAnyCaptcha.Enabled = !this.rbGuru.Checked;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0006686C File Offset: 0x00064A6C
		private void rbPrimeOtp_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbPrimeOtp.Checked;
			if (@checked)
			{
				this.txtTextNow.Enabled = false;
				this.txtOtpSim.Enabled = false;
				this.txtSimCode.Enabled = false;
				this.txtOtpmmo.Enabled = false;
				this.txtPrimeOtp.Enabled = true;
			}
		}

		// Token: 0x04000300 RID: 768
		private JSON_Settings setting;

		// Token: 0x04000301 RID: 769
		public static bool isOK;
	}
}
