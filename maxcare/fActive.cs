using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Common;
using DeviceId;
using License.RNCryptor;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x02000128 RID: 296
	public partial class fActive : Form
	{
		// Token: 0x06000D98 RID: 3480 RVA: 0x002B33BC File Offset: 0x002B15BC
		public fActive(int typeError, string idKey)
		{
			this.InitializeComponent();
			this.typeError = typeError;
			this.lblStatus.Text = this.GetStatusFromCode(typeError);
			bool flag = idKey == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				idKey = CommonCSharp.Md5Encode(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber().AddSystemDriveSerialNumber().ToString());
			}
			this.lblKey.Text = idKey;
			this.ChangeLanguage();
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x002B348C File Offset: 0x002B168C
		private void ChangeLanguage()
		{
			Language.GetValue(this);
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.bunifuCustomLabel3);
			Language.GetValue(this.btnLogin);
			Language.GetValue(this.label1);
			Language.GetValue(this.linkLabel1);
			Language.GetValue(this.bunifuCustomLabel7);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x002B350C File Offset: 0x002B170C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x002B3528 File Offset: 0x002B1728
		private string GetStatusFromCode(int typeError = 0)
		{
			string result;
			switch (typeError)
			{
			case 0:
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				break;
			case 1:
				result = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WTVZSVmJtaEtWRzVXWVdWVlNqRlpWVGxJVG01S1dWRlhaRFJUYTJodlpGUlNUbG95VFhKU2VtUjVWVEJLY2s1SFNqRmlSMHAwV1RKa2FsSXljRzlrV0VaclpGVnNTRTB5YURGT1JWb3dVMVpPUm1GQlBUMD0=")))))))));
				break;
			case 2:
				result = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2IyTkVVbWxqVXpsclVUQktjRTVIU2pGVVJXeElWVWRvTVU1dFVtOVRWV1JOWVVoV2VGSnVWa3BTTURWMlpVaEtRMkZGYkU1Vk1VbzBZMnRTYjJSVVdrOWhhMnhJWkd0U2VWWXdOWFpUVldSdlpHcFNhV05YYUd0Uk1GWnZVMVpGT1ZCUlBUMD0=")))))))));
				break;
			case 3:
				result = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2IyTkVVbWxqVXpsclVUQktjRTVIU2pGVVJXeElWVWRvTVU1dFVtOVRWV1JOWVVoV2VGSnVWa3BVVms1VFpIcGFUbG95UmxCU2Vsb3lUVEZHYmxsVk9VaE9iVGxZVGtka2Frc3dZek5qYkU1RFlYcFNhV1JYZUdsaVYwNXZVMVpPUmxCUlBUMD0=")))))))));
				break;
			case 4:
				result = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVGb3lSbFJSYmtwb1VuazViMlJZUms5a1ZXeElZVWhaTUZsdVJYcFhXR3hEWkVSU2FXTllVbXRSTUVwNVdWVTVTRTV1UmxsV1YyUmFaRlZqTW1JeFl6QmFNa3AwWVcxb01XTlVSak5UVldRd1lqTmpNMVZ1Vm1GbFZWSkdZVEpPVUU1dFNuUlpNbWhLVlRCVk9RPT0=")))))))));
				break;
			default:
				result = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1Sb1RXMXdSV1JGWXpGaWEyeEpZV3RTZGxZd01XNWxSWEJKWVVoVk1HUklWbWhSTUZadlUxWkZPVkJSUFQwPQ==")))))))));
				break;
			}
			return result;
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x002B373C File Offset: 0x002B193C
		private void BtnLogin_Click(object sender, EventArgs e)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1UyVlhSbGxYYlhocVltczFhbGRzYUZOaGJHaElZVWhhYWsweFNqWT0="))))))));
			bool flag = File.Exists(path);
			if (flag)
			{
				try
				{
					List<string> list = new List<string>
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXdlSFJOV0VKcFltczFNbGR0TlZOTk1XeFpVMjE0VFdKc2NERT0=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a2MyUlhUWGxQVnpGclUwZFNiMWt5TVZaa1YxSjBUa1F3UFE9PQ=="))))))))
					};
					using (StreamReader streamReader = new StreamReader(path))
					{
						string text = string.Empty;
						while ((text = streamReader.ReadLine()) != null)
						{
							foreach (string value in list)
							{
								bool flag2 = text.ToLower().Contains(value);
								if (flag2)
								{
									MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkZGaFNGWjRWbXBHU2xJeWNFVmphMk14WWpCc1NHVnRhREZqVlZwM1UxVmtZV05IU2toV1YyUm9VbnBzTmxwRmFFNWFNa294VW5wYU1rMHhWbTVaYkdoWllVaFZNVkp1VmtwU2VrNXZaRlJWTkZveVRraGhiV2d4WTFkU01WTlZZM3BoU0ZVd1VtNVNTbFZVTURrPQ=="))))))))), 2);
									Environment.Exit(0);
								}
							}
						}
					}
				}
				catch
				{
				}
			}
			string userName = this.txbUserName.Text.Trim();
			string pass = this.txbPassword.Text.Trim();
			bool flag3 = userName == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || pass == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag3)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WTVZSVmJVWnNVbnBrYmxaNlVtNWxSWEJKWVVoV2VGcEVWa3BVVms1VFRrZEtNV0pyYkVsVmJUa3pUakZLTVZkdWJFTk5SMFpZVGtkblBRPT0="))))))))), 3);
			}
			else
			{
				bool flag4 = !CommonCSharp.IsValidMail(this.txbUserName.Text);
				if (flag4)
				{
					this.lblStatus.Invoke(new MethodInvoker(delegate()
					{
						this.lblStatus.Text = Language.GetValue("Email bạn nhập không đúng định dạng!");
					}));
				}
				else
				{
					MethodInvoker <>9__2;
					MethodInvoker <>9__3;
					MethodInvoker <>9__5;
					MethodInvoker <>9__6;
					MethodInvoker <>9__7;
					MethodInvoker <>9__8;
					MethodInvoker <>9__9;
					MethodInvoker <>9__10;
					MethodInvoker <>9__11;
					MethodInvoker <>9__12;
					MethodInvoker <>9__13;
					MethodInvoker <>9__14;
					MethodInvoker <>9__15;
					MethodInvoker <>9__4;
					new Thread(delegate()
					{
						Control control = this.btnLogin;
						MethodInvoker method;
						if ((method = <>9__2) == null)
						{
							method = (<>9__2 = delegate()
							{
								this.btnLogin.Enabled = false;
							});
						}
						control.Invoke(method);
						Control control2 = this.lblStatus;
						MethodInvoker method2;
						if ((method2 = <>9__3) == null)
						{
							method2 = (<>9__3 = delegate()
							{
								this.lblStatus.Text = Language.GetValue("Đang kiểm tra đăng nhập...");
							});
						}
						control2.Invoke(method2);
						try
						{
							Encryptor encryptor = new Encryptor();
							string text2 = CommonCSharp.Md5Encode(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber().AddSystemDriveSerialNumber().ToString());
							RequestHttp requestHttp = new RequestHttp("", "", "", 0);
							Decryptor decryptor = new Decryptor();
							Random random = new Random();
							string text3 = CommonCSharp.ReadHTMLCode("http://app.minsoftware.vn/api/auth?datavery=" + CommonCSharp.Base64Encode(userName + "|" + pass)).Replace("\"", "");
							bool flag5 = text3.Trim() == "";
							if (flag5)
							{
								Control control3 = this.lblStatus;
								MethodInvoker method3;
								if ((method3 = <>9__5) == null)
								{
									method3 = (<>9__5 = delegate()
									{
										this.lblStatus.Text = this.GetStatusFromCode(4);
									});
								}
								control3.Invoke(method3);
								Control control4 = this.btnLogin;
								MethodInvoker method4;
								if ((method4 = <>9__6) == null)
								{
									method4 = (<>9__6 = delegate()
									{
										this.btnLogin.Enabled = true;
									});
								}
								control4.Invoke(method4);
								return;
							}
							int num = random.Next(0, 10000) + random.Next(100, 1000);
							string str = "http://app.minsoftware.vn/minapi/minapi/api.php/active32345?data=";
							string plaintext = string.Concat(new string[]
							{
								text2,
								"|",
								text3,
								"|",
								11.ToString(),
								"|",
								num.ToString(),
								"|code1"
							});
							string str2 = encryptor.Encrypt(plaintext, "pass1");
							string text4 = requestHttp.RequestGet(str + str2).Replace("\"", "");
							text4 = CommonCSharp.Base64Decode(text4);
							text4 = decryptor.Decrypt(text4, "pass1" + num.ToString());
							bool flag6 = text4.Contains("chuakichhoat");
							if (flag6)
							{
								Control control5 = this.lblStatus;
								MethodInvoker method5;
								if ((method5 = <>9__7) == null)
								{
									method5 = (<>9__7 = delegate()
									{
										this.lblStatus.Text = this.GetStatusFromCode(2);
									});
								}
								control5.Invoke(method5);
								Control control6 = this.btnLogin;
								MethodInvoker method6;
								if ((method6 = <>9__8) == null)
								{
									method6 = (<>9__8 = delegate()
									{
										this.btnLogin.Enabled = true;
									});
								}
								control6.Invoke(method6);
								return;
							}
							bool flag7 = text4.Contains("error");
							if (flag7)
							{
								Control control7 = this.lblStatus;
								MethodInvoker method7;
								if ((method7 = <>9__9) == null)
								{
									method7 = (<>9__9 = delegate()
									{
										this.lblStatus.Text = this.GetStatusFromCode(5);
									});
								}
								control7.Invoke(method7);
								Control control8 = this.btnLogin;
								MethodInvoker method8;
								if ((method8 = <>9__10) == null)
								{
									method8 = (<>9__10 = delegate()
									{
										this.btnLogin.Enabled = true;
									});
								}
								control8.Invoke(method8);
								return;
							}
							bool flag8 = text4.Contains("hethan");
							if (flag8)
							{
								Control control9 = this.lblStatus;
								MethodInvoker method9;
								if ((method9 = <>9__11) == null)
								{
									method9 = (<>9__11 = delegate()
									{
										this.lblStatus.Text = this.GetStatusFromCode(3);
									});
								}
								control9.Invoke(method9);
								Control control10 = this.btnLogin;
								MethodInvoker method10;
								if ((method10 = <>9__12) == null)
								{
									method10 = (<>9__12 = delegate()
									{
										this.btnLogin.Enabled = true;
									});
								}
								control10.Invoke(method10);
								return;
							}
							string text5 = text4.Split(new char[]
							{
								'|'
							})[0];
							string a = text4.Split(new char[]
							{
								'|'
							})[1];
							string text6 = text4.Split(new char[]
							{
								'|'
							})[2];
							string b = text4.Split(new char[]
							{
								'|'
							})[3];
							string a2 = text4.Split(new char[]
							{
								'|'
							})[4];
							string a3 = text4.Split(new char[]
							{
								'|'
							})[5];
							bool flag9 = text2 != b || a != text3 || a2 != num.ToString() || a3 != "code1";
							if (flag9)
							{
								Control control11 = this.lblStatus;
								MethodInvoker method11;
								if ((method11 = <>9__13) == null)
								{
									method11 = (<>9__13 = delegate()
									{
										this.lblStatus.Text = Language.GetValue("Không thể kích hoạt tài khoản của bạn, vui lòng thử lại!!!");
									});
								}
								control11.Invoke(method11);
								Control control12 = this.btnLogin;
								MethodInvoker method12;
								if ((method12 = <>9__14) == null)
								{
									method12 = (<>9__14 = delegate()
									{
										this.btnLogin.Enabled = true;
									});
								}
								control12.Invoke(method12);
								return;
							}
							Control control13 = this.lblStatus;
							MethodInvoker method13;
							if ((method13 = <>9__15) == null)
							{
								method13 = (<>9__15 = delegate()
								{
									this.lblStatus.Text = Language.GetValue("Đăng nhập thành công!");
								});
							}
							control13.Invoke(method13);
							MessageBoxHelper.ShowMessageBox(Language.GetValue("Thiết bị của bạn đã được kích hoạt, cảm ơn đã sử dụng phần mềm của Min Software.") + "\r\n" + Language.GetValue("Vui lòng mở lại phần mềm để sử dụng!"), 1);
							Settings.Default.UserName = this.txbUserName.Text;
							Settings.Default.PassWord = this.txbPassword.Text;
							Settings.Default.Save();
							Environment.Exit(0);
						}
						catch (Exception ex)
						{
							Common.ExportError(null, ex, "Active error");
							MessageBoxHelper.ShowMessageBox("Lỗi không xác định!!!", 2);
						}
						Control control14 = this.btnLogin;
						MethodInvoker method14;
						if ((method14 = <>9__4) == null)
						{
							method14 = (<>9__4 = delegate()
							{
								this.btnLogin.Enabled = true;
							});
						}
						control14.Invoke(method14);
					}).Start();
				}
			}
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x002B350C File Offset: 0x002B170C
		private void FActive_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x002B3B6C File Offset: 0x002B1D6C
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyVlhTWGxOVjNoTllsWlpNRmRzUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlRXdGFNMWt3VFRGa1IwWllUbGh3YVUxc2IzZGFSRXBIWlZad1ZFNVVTbWxoVkd3MldWWmthMlJYVWxsUlZEQTk=")))))))));
			}
			catch
			{
				Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlRXdGFNMWt3VFRGa1IwWllUbGh3YVUxc2IzZGFSRXBIWlZad1ZFNVVTbWxoVkd3MldWWmthMlJYVWxsUlZEQTk=")))))))));
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x002B3C80 File Offset: 0x002B1E80
		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
			Clipboard.SetText(this.lblKey.Text);
			MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhCcFRUQkpNVk5WWTNwU1J6azFVV3BDYUZJeU5XOWtXRWsxVFVWc1NGUkhhREZPU0U1dg=="))))))))), 1);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x002B3CFC File Offset: 0x002B1EFC
		private void txbUserName_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.BtnLogin_Click(null, null);
			}
		}

		// Token: 0x040016D5 RID: 5845
		private int typeError = 0;
	}
}
