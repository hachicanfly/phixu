using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Common;
using DeviceId;
using License.RNCryptor;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000FC RID: 252
	public partial class fIntro : Form
	{
		// Token: 0x06000A34 RID: 2612
		[DllImport("kernel32.dll")]
		private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, uint VolumeNameSize, ref uint VolumeSerialNumber, ref uint MaximumComponentLength, ref uint FileSystemFlags, StringBuilder FileSystemNameBuffer, uint FileSystemNameSize);

		// Token: 0x06000A35 RID: 2613 RVA: 0x0000308D File Offset: 0x0000128D
		public fIntro()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x001CE48C File Offset: 0x001CC68C
		private void ChangeLanguage()
		{
			Language.GetValue(this.label1);
			Language.GetValue(this.label3);
			Language.GetValue(this.label10);
			Language.GetValue(this.label7);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x001CE4E0 File Offset: 0x001CC6E0
		private void Intro_Load(object sender, EventArgs e)
		{
			Program.intro++;
			this.timer1.Tick += this.fadeIn;
			this.timer1.Start();
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x001CE534 File Offset: 0x001CC734
		private void fadeIn(object sender, EventArgs e)
		{
			bool flag = base.Opacity >= 1.0;
			if (flag)
			{
				this.timer1.Stop();
				try
				{
					string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1UyVlhSbGxYYlhocVltczFhbGRzYUZOaGJHaElZVWhhYWsweFNqWT0="))))))));
					bool flag2 = File.Exists(path);
					if (flag2)
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
										bool flag3 = text.ToLower().Contains(value);
										if (flag3)
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
					string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					string text3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					text2 = Settings.Default.UserName;
					text3 = Settings.Default.PassWord;
					string text4 = CommonCSharp.Md5Encode(new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber().AddSystemDriveSerialNumber().ToString());
					Base.deviceId = text4;
					bool flag4 = text2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag4)
					{
						base.Hide();
						new fActive(1, text4).ShowDialog();
					}
					else
					{
						bool flag5 = !CommonCSharp.IsValidMail(text2);
						if (flag5)
						{
							base.Hide();
							new fActive(1, text4).ShowDialog();
						}
						else
						{
							RequestHttp requestHttp = new RequestHttp(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
							Decryptor decryptor = new Decryptor();
							Random random = new Random();
							int num = random.Next(0, 999999);
							string text5 = CommonCSharp.ReadHTMLCode(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlRXdGFNMWt3VFRGa1IwWllUbGh3YVUxc2IzZGFSRXBIWlZad1ZFNVVTbWxoVkd4dldUQmtjbVJzYkZsV2FrSm9Va1JzY2xkV2FGTmhSMUowVm01c2JGWkVRVGs9")))))))) + CommonCSharp.Base64Encode(text2 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))) + text3)).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
							bool flag6 = text5.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag6)
							{
								base.Hide();
								new fActive(1, text4).ShowDialog();
							}
							else
							{
								Base.nameSoftTool += Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9"))))))));
								int num2 = random.Next(0, 10000) + random.Next(100, 1000);
								string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlRXdGFNMWt3VFRGa1IwWllUbGh3YVUxc2IzZGFSRXBIWlZad1ZFNVVTbWxoVkd3d1dWWmpNV0ZIVGtoaE0xcHBWako0TVZkV2FFTmpSWGQ1VW01a2FGVjZWak5aVldoQ1pHeHNXRlJxUW1oWFJuQnpWRmh3U21Wck5VVldVemxoVWpCWmQxZFdVWGRRVVQwOQ=="))))))));
								string plaintext = string.Concat(new string[]
								{
									text4,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									text5,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									11.ToString(),
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
									num2.ToString(),
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210a1QyUnNjRWhXV0djOQ=="))))))))
								});
								Encryptor encryptor = new Encryptor();
								string str = encryptor.Encrypt(plaintext, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUalpTVkRBOQ==")))))))));
								string text6 = requestHttp.RequestGet(@string + str).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
								Base.api_token = text5;
								Base.checkLisence = text6;
								Base.codeKeyRandom = num2.ToString();
								text6 = CommonCSharp.Base64Decode(text6);
								text6 = decryptor.Decrypt(text6, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUalpTVkRBOQ==")))))))) + num2.ToString());
								bool flag7 = text6 == null || text6 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyTXlTa0pRVkRBOQ=="))))))));
								if (flag7)
								{
									base.Hide();
									MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1Sb1ZEQmpNMkZJYkVOTlIwWlFVbnBrY2xaNlZuVT0="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFaT1JtRkJQVDA9")))))))), 1);
								}
								else
								{
									bool flag8 = text6.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IwMVdiRmhrU0VKYVRXMW9kbGxxU2tkTlFUMDk=")))))))));
									if (flag8)
									{
										base.Hide();
										new fActive(3, text4).ShowDialog();
									}
									else
									{
										bool flag9 = text6.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4b1MyVlhTWHBUVkRBOQ==")))))))));
										if (flag9)
										{
											base.Hide();
											new fActive(1, text4).ShowDialog();
										}
										else
										{
											bool flag10 = text6.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWa1YwMUhSa2hTYmxVOQ==")))))))));
											if (flag10)
											{
												base.Hide();
												new fActive(3, text4).ShowDialog();
											}
											else
											{
												string text7 = text6.Split(new char[]
												{
													'|'
												})[0];
												string a = text6.Split(new char[]
												{
													'|'
												})[1];
												string text8 = text6.Split(new char[]
												{
													'|'
												})[2];
												string b = text6.Split(new char[]
												{
													'|'
												})[3];
												string a2 = text6.Split(new char[]
												{
													'|'
												})[4];
												string a3 = text6.Split(new char[]
												{
													'|'
												})[5];
												base.Hide();
												bool flag11 = text4 != b || a != text5 || a2 != num2.ToString() || a3 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XRXhjRlZTVkRBOQ=="))))))));
												if (flag11)
												{
													new fActive(1, text4).ShowDialog();
												}
												else
												{
													new fMain(text6).ShowDialog();
												}
												this.timer1.Tick += this.fadeOut;
												this.timer1.Start();
											}
										}
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25KYU1sWklVMFV4Y0ZkSGRHNVpNakZHWXpCc1NWZHFSbWhWTUVwNldXcG9OVkZYU25SWk1tUnBVakkxUldOWE1EQmFNa1pPVkROR05sTXdNVzVWVm1SVFpFZEdXRTVIWkRSVGEyaEZZMWhPTlZOcmJFNVZNVW8wWTJ0U1NHSXlUalZoYkd3MVVXMDVNMDR4VWs1YU0yeERUVWRPZWxsWGFEWlRNREZ2"))))))))), 2);
					Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxjMVYyUlZiRWRSYm14cFRXMVNOVmRXWTNkUVVUMDk=")))))))));
					base.Close();
				}
			}
			else
			{
				base.Opacity += 0.05;
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x001CF578 File Offset: 0x001CD778
		private void fadeOut(object sender, EventArgs e)
		{
			bool flag = base.Opacity <= 0.0;
			if (flag)
			{
				this.timer1.Stop();
				base.Close();
			}
			else
			{
				base.Opacity -= 0.05;
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x001CF5F0 File Offset: 0x001CD7F0
		private void timer2_Tick(object sender, EventArgs e)
		{
			bool flag = this.progressBar.Value < 90;
			if (flag)
			{
				this.progressBar.Value += 10;
			}
			else
			{
				this.timer2.Stop();
			}
		}
	}
}
