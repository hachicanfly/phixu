using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000130 RID: 304
	public partial class fCauHinhChung : Form
	{
		// Token: 0x06000DD8 RID: 3544 RVA: 0x002C1B90 File Offset: 0x002BFD90
		public fCauHinhChung()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
			this.ChangeLanguage();
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x002C1C0C File Offset: 0x002BFE0C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.label3);
			Language.GetValue(this.label6);
			Language.GetValue(this.label4);
			Language.GetValue(this.label5);
			Language.GetValue(this.label9);
			Language.GetValue(this.grChrome);
			Language.GetValue(this.ckbShowImageInteract);
			Language.GetValue(this.ckbAddChromeIntoForm);
			Language.GetValue(this.label10);
			Language.GetValue(this.label20);
			Language.GetValue(this.label29);
			Language.GetValue(this.label21);
			Language.GetValue(this.label2);
			Language.GetValue(this.label32);
			Language.GetValue(this.label31);
			Language.GetValue(this.label30);
			Language.GetValue(this.rbTocDoGoCham);
			Language.GetValue(this.rbTocDoGoBinhThuong);
			Language.GetValue(this.rbTocDoGoNhanh);
			Language.GetValue(this.linkLabel2);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.label23);
			Language.GetValue(this.rbPhanBietMauNen);
			Language.GetValue(this.rbPhanBietMauChu);
			Language.GetValue(this.groupBox3);
			Language.GetValue(this.ckbKhongCheckIP);
			Language.GetValue(this.label26);
			Language.GetValue(this.label27);
			Language.GetValue(this.button5);
			Language.GetValue(this.rbNone);
			Language.GetValue(this.rbProxy);
			Language.GetValue(this.rbHma);
			Language.GetValue(this.rbDcom);
			Language.GetValue(this.button4);
			Language.GetValue(this.rbTinsoft);
			Language.GetValue(this.linkLabel3);
			Language.GetValue(this.rbApiUser);
			Language.GetValue(this.ckbWaitDoneAllTinsoft);
			Language.GetValue(this.rbApiProxy);
			Language.GetValue(this.label7);
			Language.GetValue(this.label8);
			Language.GetValue(this.label16);
			Language.GetValue(this.label17);
			Language.GetValue(this.ckbWaitDoneAllXproxy);
			Language.GetValue(this.label18);
			Language.GetValue(this.linkLabel1);
			Language.GetValue(this.label24);
			Language.GetValue(this.ckbWaitDoneAllTMProxy);
			Language.GetValue(this.label25);
			Language.GetValue(this.btnSave);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x002C1FA0 File Offset: 0x002C01A0
		private void LoadCbbLocation()
		{
			Dictionary<string, string> dataSource = this.TinsoftGetListLocation();
			this.cbbLocationTinsoft.DataSource = new BindingSource(dataSource, null);
			this.cbbLocationTinsoft.ValueMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS1YwNVJQVDA9"))))))));
			this.cbbLocationTinsoft.DisplayMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0weFIyTXlVbGhXVkRBOQ=="))))))));
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x002C2080 File Offset: 0x002C0280
		public Dictionary<string, string> TinsoftGetListLocation()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			List<string> listCountryTinsoft = SetupFolder.GetListCountryTinsoft();
			for (int i = 0; i < listCountryTinsoft.Count; i++)
			{
				string[] array = listCountryTinsoft[i].Split(new char[]
				{
					'|'
				});
				dictionary.Add(array[0], array[1]);
			}
			return dictionary;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x002C2104 File Offset: 0x002C0304
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
			this.LoadCbbLocation();
			this.LoadCbbSizeChrome();
			this.nudInteractThread.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUbGhPVkVKaFYwVndiMWRVVGxOV1YwWkpVMjE0V2xZeFJUaz0=")))))))), 3);
			this.nudHideThread.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUa2hpUjNSaFZteEtkbGt5TVZkaFJuQkNVRlF3UFE9PQ==")))))))), 5);
			this.txbPathProfile.Text = ((this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? (Application.StartupPath + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWb1EyVlhTWGxYYmtKcFVqRmFOZz09"))))))))) : this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool flag = !Directory.Exists(this.txbPathProfile.Text) || this.txbPathProfile.Text.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnNjSFJpU0U1aFYwVXdPUT09"))))))));
			if (flag)
			{
				this.txbPathProfile.Text = Application.StartupPath + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWb1EyVlhTWGxYYmtKcFVqRmFOZz09"))))))));
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), this.txbPathProfile.Text);
			this.ckbShowImageInteract.Checked = Convert.ToBoolean((this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoU0ZwclRVZDRNRmRXWkd0aVJrNVlUbFJDWVZkRmNHOVhWRTVTVUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyTXlUWGxXVkRBOQ==")))))))) : this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoU0ZwclRVZDRNRmRXWkd0aVJrNVlUbFJDWVZkRmNHOVhWRTVTVUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			this.ckbAddChromeIntoForm.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSU1RXMW9OVmxxU1hoaVJrNVlUbFJDYVUxR2NESlpNakIzVUZFOVBRPT0=")))))))), false);
			this.nudWidthChrome.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXWGxpUjNSclVqSm9SVmxWYUV0a2JVcFlWbFF3UFE9PQ==")))))))), 320);
			this.nudHeighChrome.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUa2hXYmtKaFRXMW9SVmxWYUV0a2JVcFlWbFF3UFE9PQ==")))))))), 480);
			this.nudDelayOpenChromeFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRVVmt3WkZka1ZrVjVZVWhzYVUxcVJuTlZiVFZMWkcxS1VsQlVNRDA9")))))))), 1);
			this.nudDelayOpenChromeTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRVVmt3WkZka1ZrVjVZVWhzYVUxcVJuTldhMk0wVUZFOVBRPT0=")))))))), 1);
			this.nudDelayCloseChromeFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxyWXpWbGJIQldWRzA1YW1KVWJEQlhiRlpoWlZkSmVVMUVNRDA9")))))))), 0);
			this.nudDelayCloseChromeTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxyWXpWbGJIQldWRzA1YW1KVWJEQlhiRnBUWkdjOVBRPT0=")))))))), 0);
			this.cbbColumnChrome.Text = ((this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldSWGxQV0U1clZucEdNVlZVU205bFYwbDVUVmQzUFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZoak9WQlJQVDA9")))))))) : this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldSWGxQV0U1clZucEdNVlZVU205bFYwbDVUVmQzUFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			this.cbbRowChrome.Text = ((this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldWblJQVkU1U1RXMW9OVmxxU1hoaVFUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkak9WQlJQVDA9")))))))) : this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldWblJQVkU1U1RXMW9OVmxxU1hoaVFUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			int valueInt = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUVwUVVUMDk=")))))))), 0);
			int num = valueInt;
			int num2 = num;
			if (num2 != 0)
			{
				if (num2 == 1)
				{
					this.rbChromium.Checked = true;
				}
			}
			else
			{
				this.rbChrome.Checked = true;
			}
			this.txtLinkToOtherBrowser.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1RWWktNbFpFVGxOaU1YQlpVMnRPYW1KVWEzcFpla3BYWlZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.ckbUsePortable.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhoV1VucHNOVnBGWkVkaFYwcElWbFF3UFE9PQ==")))))))), false);
			this.txtPathToPortableZip.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VteEtNbFpWWXpWbFYxSklVbTFzYVZJeFdtaFpWbWhDVUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.cbbSizeChrome.SelectedValue = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS2MwNXNjRlpVYlRscVlsUnNNRmRzUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YySldiRmxXYms1clVWUXdPUT09"))))))))).ToString();
			bool flag2 = this.cbbSizeChrome.SelectedValue == null;
			if (flag2)
			{
				this.cbbSizeChrome.SelectedValue = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YySldiRmxXYms1clVWUXdPUT09"))))))));
			}
			switch (this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XRnNTa2hQVldocFRWWndiMWx0ZEV0aFIwcHVVRlF3UFE9PQ==")))))))), 0))
			{
			case 0:
				this.rbTocDoGoCham.Checked = true;
				break;
			case 1:
				this.rbTocDoGoBinhThuong.Checked = true;
				break;
			case 2:
				this.rbTocDoGoNhanh.Checked = true;
				break;
			}
			this.ckbKhongCheckIP.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
			this.nudChangeIpCount.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRTblZXYlhSU1RXMW9iMWx0TVd0aVJrNVpVV3RTYVUweFdqRmFSVVU1VUZFOVBRPT0=")))))))), 1);
			this.nudDelayCheckIP.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0);
			int valueInt2 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0);
			bool flag3 = valueInt2 == 0;
			if (flag3)
			{
				this.rbNone.Checked = true;
			}
			else
			{
				bool flag4 = valueInt2 == 1;
				if (flag4)
				{
					this.rbHma.Checked = true;
				}
				else
				{
					bool flag5 = valueInt2 == 2;
					if (flag5)
					{
						this.rbDcom.Checked = true;
					}
					else
					{
						bool flag6 = valueInt2 == 3;
						if (flag6)
						{
							this.rbSSH.Checked = true;
						}
						else
						{
							bool flag7 = valueInt2 == 4;
							if (flag7)
							{
								this.rbExpressVPN.Checked = true;
							}
							else
							{
								bool flag8 = valueInt2 == 5;
								if (flag8)
								{
									this.rbHotspot.Checked = true;
								}
								else
								{
									bool flag9 = valueInt2 == 6;
									if (flag9)
									{
										this.rbNordVPN.Checked = true;
									}
									else
									{
										bool flag10 = valueInt2 == 7;
										if (flag10)
										{
											this.rbTinsoft.Checked = true;
										}
										else
										{
											bool flag11 = valueInt2 == 8;
											if (flag11)
											{
												this.rbXproxy.Checked = true;
											}
											else
											{
												bool flag12 = valueInt2 == 9;
												if (flag12)
												{
													this.rbProxy.Checked = true;
												}
												else
												{
													bool flag13 = valueInt2 == 10;
													if (flag13)
													{
														this.rbTMProxy.Checked = true;
													}
													else
													{
														bool flag14 = valueInt2 == 11;
														if (flag14)
														{
															this.rbProxyv6.Checked = true;
														}
														else
														{
															bool flag15 = valueInt2 == 12;
															if (flag15)
															{
																this.rbShopLike.Checked = true;
															}
															else
															{
																bool flag16 = valueInt2 == 13;
																if (flag16)
																{
																	this.rbMinProxy.Checked = true;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			bool flag17 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpWYlhCcFRXcEJPUT09")))))))), 0) == 0;
			if (flag17)
			{
				this.rbDcomThuong.Checked = true;
			}
			else
			{
				this.rbDcomHilink.Checked = true;
			}
			this.txtProfileNameDcom.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRVa2xoUkVKV1UwVndNbGR0TVhOak1YQldUbGRvYVZZeFdrWlhWRWsxWkVFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.txtUrlHilink.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXbGxUYms1VVVqSjRlbGxXWXpGalp6MDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlpXdFZNVlJYYXpCbFJUVnhXak5XVGxWNlVqUlVSRXB2VFVkS1dHUXpXbWhTZW13d1YyeE5NV0l5VWtoTldFMDk=")))))))));
			this.txtNordVPN.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRVa2xoUkVKVllsUnNOVmRyV21GVlZsSnVVRlF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.cbbHostpot.SelectedIndex = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHNhM2xUYld4VVVucHNObHBGYUVOa2JWSkNVRlF3UFE9PQ==")))))))), 0);
			bool flag18 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpTYm1Sb1ZteEtkMWx0TlU5a2JIQjFWVlF3UFE9PQ==")))))))), 0) == 0;
			if (flag18)
			{
				this.rbApiUser.Checked = true;
			}
			else
			{
				this.rbApiProxy.Checked = true;
			}
			this.txtApiUser.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKWFYwVTFjMWt5WXpsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.txtApiProxy.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKV1UwVndNbHBWYUhKUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.cbbLocationTinsoft.SelectedValue = ((this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldVa2hQVjNCYVYwWktkMWxxU1RGV1YwWllUbGh3YVUxc2IzYz0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9")))))))) : this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldVa2hQVjNCYVYwWktkMWxxU1RGV1YwWllUbGh3YVUxc2IzYz0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			this.nudLuongPerIPTinsoft.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWVzVDYVdKck5USlhiVFZTVUZFOVBRPT0=")))))))), 0);
			this.ckbWaitDoneAllTinsoft.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXWGxTYmtKclVsWktNbGx0TVZkUmJVcElaVVpXYUZaNlZqWlpha3BoVFVFOVBRPT0=")))))))), false);
			this.txtServiceURLXProxy.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWWGxXYm14cllsZDRjVmRzV2xkVk1WSkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			int valueInt3 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRSYm14cFRUSm5NUT09")))))))), 0);
			bool flag19 = valueInt3 == 0;
			if (flag19)
			{
				this.rbHttpProxy.Checked = true;
			}
			else
			{
				this.rbSock5Proxy.Checked = true;
			}
			this.txtListProxy.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0hCclVtdEtOVmxxVG05T1VUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.nudLuongPerIPXProxy.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), 0);
			this.nudDelayResetXProxy.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWRmRzYUU5aVIxSkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), 5);
			this.ckbWaitDoneAllXproxy.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXWGxTYmtKclVsWktNbGx0TVZkUmJVcElaVVpzYWxORmNESmFWV2h5VUZFOVBRPT0=")))))))), false);
			bool flag20 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRUYWtacFlrZG9NMWt5TURWT1IxWlNVRlF3UFE9PQ==")))))))), 0) == 0;
			if (flag20)
			{
				this.rbXproxyResetEachProxy.Checked = true;
			}
			else
			{
				this.rbXproxyResetAllProxy.Checked = true;
			}
			this.txtApiKeyTMProxy.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKVVRXeFpNVlpyVlhoVlYwNTBUMVJTYkZWVU1Eaz0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.nudLuongPerIPTMProxy.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWV3MxVmxORmNESmFWV2h5VUZFOVBRPT0=")))))))), 1);
			this.ckbWaitDoneAllTMProxy.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXWGxTYmtKclVsWktNbGx0TVZkUmJVcElaVVpXVlZaclNqVlphazV2VGxFOVBRPT0=")))))))), false);
			this.txtApiProxyv6.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKV1UwVndNbHBWYUhOTmF6VnVVRlF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.txtListProxyv6.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0hCclVtdEtOVmxxVG05T1YxSnhWMVF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.nudLuongPerIPProxyv6.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhVVzVzYVUweVp6RmFSM0JhVUZFOVBRPT0=")))))))), 0);
			this.txtApiShopLike.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKV1RXMW9NbGt3VmpSalIwVjVWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.nudLuongPerIPShopLike.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWRzA1YVUwd1NrNVpWbVF3WWtFOVBRPT0=")))))))), 0);
			this.txtApiKeyMinProxy.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKVVRXeFpNVlpHWkhOa1ZsWkpVMjVhYkZOSGN6az0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.nudLuongPerIPMinProxy.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkdUVmhDYVdKRlNqVlphazV2VGxFOVBRPT0=")))))))), 0);
			bool flag21 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRSYlRsYVZucFdSRmxXWkZkTlJsSllVbXBGUFE9PQ==")))))))), 0) == 0;
			if (flag21)
			{
				this.rbPhanBietMauNen.Checked = true;
			}
			else
			{
				this.rbPhanBietMauChu.Checked = true;
			}
			this.CheckedChangedFull();
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x002C4814 File Offset: 0x002C2A14
		private void BtnSave_Click(object sender, EventArgs e)
		{
			try
			{
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUbGhPVkVKaFYwVndiMWRVVGxOV1YwWkpVMjE0V2xZeFJUaz0=")))))))), this.nudInteractThread.Value);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUa2hpUjNSaFZteEtkbGt5TVZkaFJuQkNVRlF3UFE9PQ==")))))))), this.nudHideThread.Value);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), this.txbPathProfile.Text);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoU0ZwclRVZDRNRmRXWkd0aVJrNVlUbFJDWVZkRmNHOVhWRTVTVUZFOVBRPT0=")))))))), this.ckbShowImageInteract.Checked);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSU1RXMW9OVmxxU1hoaVJrNVlUbFJDYVUxR2NESlpNakIzVUZFOVBRPT0=")))))))), this.ckbAddChromeIntoForm.Checked);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXWGxpUjNSclVqSm9SVmxWYUV0a2JVcFlWbFF3UFE9PQ==")))))))), this.nudWidthChrome.Value);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUa2hXYmtKaFRXMW9SVmxWYUV0a2JVcFlWbFF3UFE9PQ==")))))))), this.nudHeighChrome.Value);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRVVmt3WkZka1ZrVjVZVWhzYVUxcVJuTlZiVFZMWkcxS1VsQlVNRDA9")))))))), this.nudDelayOpenChromeFrom.Value);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRVVmt3WkZka1ZrVjVZVWhzYVUxcVJuTldhMk0wVUZFOVBRPT0=")))))))), this.nudDelayOpenChromeTo.Value);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxyWXpWbGJIQldWRzA1YW1KVWJEQlhiRlpoWlZkSmVVMUVNRDA9")))))))), this.nudDelayCloseChromeFrom.Value);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxyWXpWbGJIQldWRzA1YW1KVWJEQlhiRnBUWkdjOVBRPT0=")))))))), this.nudDelayCloseChromeTo.Value);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldSWGxQV0U1clZucEdNVlZVU205bFYwbDVUVmQzUFE9PQ==")))))))), this.cbbColumnChrome.Text);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldWblJQVkU1U1RXMW9OVmxxU1hoaVFUMDk=")))))))), this.cbbRowChrome.Text);
				int num = 0;
				bool @checked = this.rbChromium.Checked;
				if (@checked)
				{
					num = 1;
				}
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUVwUVVUMDk=")))))))), num);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1RWWktNbFpFVGxOaU1YQlpVMnRPYW1KVWEzcFpla3BYWlZFOVBRPT0=")))))))), this.txtLinkToOtherBrowser.Text.Trim());
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhoV1VucHNOVnBGWkVkaFYwcElWbFF3UFE9PQ==")))))))), this.ckbUsePortable.Checked);
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VteEtNbFpWWXpWbFYxSklVbTFzYVZJeFdtaFpWbWhDVUZFOVBRPT0=")))))))), this.txtPathToPortableZip.Text.Trim());
				bool flag = num != 0 && this.txtLinkToOtherBrowser.Text.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					switch (num)
					{
					case 1:
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyVlhTWGxOV0VKclZucEJPUT09"))))))));
						break;
					case 2:
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VFMUljRXBTYlhCS1VqRkNSV1JGTVRWUmJHd3pVRlF3UFE9PQ=="))))))));
						break;
					case 3:
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSS05HTkhTbGhqUjNoclVWUXdPUT09"))))))));
						break;
					}
					MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWVEZVVlc1b2VWSkZaSFpaTTJ4Q1dXMHhhbG94Y0U1VU1tdzJVMVUxTVZOVk1WUlZibU15WTJzeGJsWjZVbTVYYlRGell6RndWRkZ0Y0doU01HaE9ZbnBPY2xveGEzcFhSVEZ3VmpCV2JscEZhRXRqU0hCS1VXNVdhRkV3U25KYVJtaDFVa2hHZW1WWGNHdFJNRWt6VkZWbmQyRkJQVDA9"))))))))), @string), 2);
				}
				else
				{
					bool flag2 = this.cbbSizeChrome.Items.Count > 0;
					if (flag2)
					{
						bool flag3 = this.cbbSizeChrome.SelectedValue.ToString() != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag3)
						{
							this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS2MwNXNjRlpVYlRscVlsUnNNRmRzUlRsUVVUMDk=")))))))), this.cbbSizeChrome.SelectedValue.ToString());
						}
					}
					bool checked2 = this.rbTocDoGoCham.Checked;
					if (checked2)
					{
						this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XRnNTa2hQVldocFRWWndiMWx0ZEV0aFIwcHVVRlF3UFE9PQ==")))))))), 0);
					}
					else
					{
						bool checked3 = this.rbTocDoGoBinhThuong.Checked;
						if (checked3)
						{
							this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XRnNTa2hQVldocFRWWndiMWx0ZEV0aFIwcHVVRlF3UFE9PQ==")))))))), 1);
						}
						else
						{
							this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XRnNTa2hQVldocFRWWndiMWx0ZEV0aFIwcHVVRlF3UFE9PQ==")))))))), 2);
						}
					}
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), this.ckbKhongCheckIP.Checked);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRTblZXYlhSU1RXMW9iMWx0TVd0aVJrNVpVV3RTYVUweFdqRmFSVVU1VUZFOVBRPT0=")))))))), this.nudChangeIpCount.Value);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), this.nudDelayCheckIP.Value);
					int num2 = 0;
					bool checked4 = this.rbNone.Checked;
					if (checked4)
					{
						num2 = 0;
					}
					else
					{
						bool checked5 = this.rbHma.Checked;
						if (checked5)
						{
							num2 = 1;
						}
						else
						{
							bool checked6 = this.rbDcom.Checked;
							if (checked6)
							{
								num2 = 2;
							}
							else
							{
								bool checked7 = this.rbSSH.Checked;
								if (checked7)
								{
									num2 = 3;
								}
								else
								{
									bool checked8 = this.rbExpressVPN.Checked;
									if (checked8)
									{
										num2 = 4;
									}
									else
									{
										bool checked9 = this.rbHotspot.Checked;
										if (checked9)
										{
											num2 = 5;
										}
										else
										{
											bool checked10 = this.rbNordVPN.Checked;
											if (checked10)
											{
												num2 = 6;
											}
											else
											{
												bool checked11 = this.rbTinsoft.Checked;
												if (checked11)
												{
													num2 = 7;
												}
												else
												{
													bool checked12 = this.rbXproxy.Checked;
													if (checked12)
													{
														num2 = 8;
													}
													else
													{
														bool checked13 = this.rbProxy.Checked;
														if (checked13)
														{
															num2 = 9;
														}
														else
														{
															bool checked14 = this.rbTMProxy.Checked;
															if (checked14)
															{
																num2 = 10;
															}
															else
															{
																bool checked15 = this.rbProxyv6.Checked;
																if (checked15)
																{
																	num2 = 11;
																}
																else
																{
																	bool checked16 = this.rbShopLike.Checked;
																	if (checked16)
																	{
																		num2 = 12;
																	}
																	else
																	{
																		bool checked17 = this.rbMinProxy.Checked;
																		if (checked17)
																		{
																			num2 = 13;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), num2);
					bool checked18 = this.rbDcomThuong.Checked;
					if (checked18)
					{
						this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpWYlhCcFRXcEJPUT09")))))))), 0);
					}
					else
					{
						this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpWYlhCcFRXcEJPUT09")))))))), 1);
					}
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXbGxUYms1VVVqSjRlbGxXWXpGalp6MDk=")))))))), this.txtUrlHilink.Text);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRVa2xoUkVKV1UwVndNbGR0TVhOak1YQldUbGRvYVZZeFdrWlhWRWsxWkVFOVBRPT0=")))))))), this.txtProfileNameDcom.Text);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRVa2xoUkVKVllsUnNOVmRyV21GVlZsSnVVRlF3UFE9PQ==")))))))), this.txtNordVPN.Text);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHNhM2xUYld4VVVucHNObHBGYUVOa2JWSkNVRlF3UFE9PQ==")))))))), this.cbbHostpot.SelectedIndex);
					bool checked19 = this.rbApiUser.Checked;
					if (checked19)
					{
						this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpTYm1Sb1ZteEtkMWx0TlU5a2JIQjFWVlF3UFE9PQ==")))))))), 0);
					}
					else
					{
						this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpTYm1Sb1ZteEtkMWx0TlU5a2JIQjFWVlF3UFE9PQ==")))))))), 1);
					}
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKWFYwVTFjMWt5WXpsUVVUMDk=")))))))), this.txtApiUser.Text);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKV1UwVndNbHBWYUhKUVVUMDk=")))))))), this.txtApiProxy.Text);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldVa2hQVjNCYVYwWktkMWxxU1RGV1YwWllUbGh3YVUxc2IzYz0=")))))))), this.cbbLocationTinsoft.SelectedValue);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWVzVDYVdKck5USlhiVFZTVUZFOVBRPT0=")))))))), this.nudLuongPerIPTinsoft.Value);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXWGxTYmtKclVsWktNbGx0TVZkUmJVcElaVVpXYUZaNlZqWlpha3BoVFVFOVBRPT0=")))))))), this.ckbWaitDoneAllTinsoft.Checked);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWWGxXYm14cllsZDRjVmRzV2xkVk1WSkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), this.txtServiceURLXProxy.Text);
					int num3 = 0;
					bool checked20 = this.rbSock5Proxy.Checked;
					if (checked20)
					{
						num3 = 1;
					}
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRSYm14cFRUSm5NUT09")))))))), num3);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0hCclVtdEtOVmxxVG05T1VUMDk=")))))))), this.txtListProxy.Text);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), this.nudLuongPerIPXProxy.Value);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWRmRzYUU5aVIxSkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), this.nudDelayResetXProxy.Value);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXWGxTYmtKclVsWktNbGx0TVZkUmJVcElaVVpzYWxORmNESmFWV2h5VUZFOVBRPT0=")))))))), this.ckbWaitDoneAllXproxy.Checked);
					bool checked21 = this.rbXproxyResetEachProxy.Checked;
					if (checked21)
					{
						this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRUYWtacFlrZG9NMWt5TURWT1IxWlNVRlF3UFE9PQ==")))))))), 0);
					}
					else
					{
						this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRUYWtacFlrZG9NMWt5TURWT1IxWlNVRlF3UFE9PQ==")))))))), 1);
					}
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKVVRXeFpNVlpyVlhoVlYwNTBUMVJTYkZWVU1Eaz0=")))))))), this.txtApiKeyTMProxy.Text);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWV3MxVmxORmNESmFWV2h5VUZFOVBRPT0=")))))))), this.nudLuongPerIPTMProxy.Value);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXWGxTYmtKclVsWktNbGx0TVZkUmJVcElaVVpXVlZaclNqVlphazV2VGxFOVBRPT0=")))))))), this.ckbWaitDoneAllTMProxy.Checked);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKV1UwVndNbHBWYUhOTmF6VnVVRlF3UFE9PQ==")))))))), this.txtApiProxyv6.Text);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0hCclVtdEtOVmxxVG05T1YxSnhWMVF3UFE9PQ==")))))))), this.txtListProxyv6.Text);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhVVzVzYVUweVp6RmFSM0JhVUZFOVBRPT0=")))))))), this.nudLuongPerIPProxyv6.Value);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKV1RXMW9NbGt3VmpSalIwVjVWbFF3UFE9PQ==")))))))), this.txtApiShopLike.Text);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWRzA1YVUwd1NrNVpWbVF3WWtFOVBRPT0=")))))))), this.nudLuongPerIPShopLike.Value);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKVVRXeFpNVlpHWkhOa1ZsWkpVMjVhYkZOSGN6az0=")))))))), this.txtApiKeyMinProxy.Text);
					this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkdUVmhDYVdKRlNqVlphazV2VGxFOVBRPT0=")))))))), this.nudLuongPerIPMinProxy.Value);
					bool checked22 = this.rbPhanBietMauNen.Checked;
					if (checked22)
					{
						this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRSYlRsYVZucFdSRmxXWkZkTlJsSllVbXBGUFE9PQ==")))))))), 0);
					}
					else
					{
						this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRSYlRsYVZucFdSRmxXWkZkTlJsSllVbXBGUFE9PQ==")))))))), 1);
					}
					this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					bool flag4 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeGFHUXlVbFJSYWtKb1ZGVTVibGx0TVc1YU1XczBWSHBDYVdKWFRucFRWV1JMWVVod1RGUnVWa3BTTURVeVpXdHNSbG95U2xsWFJWSXdWRmhzUTFsdGJFVlNWM1JZVERBeGJsWjZWblZUVldSUlVqTk9UbVZWY0ZwVk1FbzJaSHBrVlZSWGJGVlBSREE5")))))))))) == DialogResult.Yes;
					if (flag4)
					{
						base.Close();
					}
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1jOQ=="))))))))), 1);
			}
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x002C6668 File Offset: 0x002C4868
		private void button5_Click(object sender, EventArgs e)
		{
			bool flag = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0) == 0;
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkU5aWVsSnBaRlUxYVdGVlNucFphWFJJVG0wNVdHRXlaRFJUYTJodlpGUldWMk5GYkVaaVJrVTk="))))))))), 3);
			}
			else
			{
				bool flag2 = Common.ChangeIP(this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0), this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpWYlhCcFRXcEJPUT09")))))))), 0), this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRVa2xoUkVKV1UwVndNbGR0TVhOak1YQldUbGRvYVZZeFdrWlhWRWsxWkVFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))), this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXbGxUYms1VVVqSjRlbGxXWXpGalp6MDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))), this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHNhM2xUYld4VVVucHNObHBGYUVOa2JWSkNVRlF3UFE9PQ==")))))))), 0), this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRVa2xoUkVKVllsUnNOVmRyV21GVlZsSnVVRlF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JXRklWVEZXYmtKS1VsZDRVbE5WYUZOaU0yTXlVVzVXYUZFd1NuRmtlbVJUWkZad05WSlVNRDA9"))))))))), 1);
				}
				else
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JXRklWVEZXYmtKS1VsZDRVbE5WYUZOaWVsSnBZMWQ0YTFFd1NuQk9SMHA0WVVkR1ZGSlVNRDA9"))))))))), 2);
				}
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x002C6AD0 File Offset: 0x002C4CD0
		private void btnSSH_Click(object sender, EventArgs e)
		{
			Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNob1YwVkthbGw2VGs5aU1IaDFWV3BTYTFGVU1Eaz0=")))))))));
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x002C6B2C File Offset: 0x002C4D2C
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = CommonChrome.GetUserAgentDefault() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkZGaFNGWjRUVmhrU2xKNlZuWk9SMHA0WkVkU1JGRnRjR2hUUlhBeVdXeGtWMkV5VG5SaVJFcGhWMFZzYnc9PQ=="))))))))), 3);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWa2IyTklZekpqU0ZaS1VqQjRiMlJZUms5a1ZXeElWRzA1YW1KVWJEQlhiR1JUWlZkR1dWZHRlR3BoVlVwNVdWVTVTRTV0T1RWUmJYTXdXVzVXYzFsdE1XcGhRVDA5"))))))))), 1);
			}
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x002C6C44 File Offset: 0x002C4E44
		private void rbTinsoft_CheckedChanged(object sender, EventArgs e)
		{
			this.plTinsoft.Enabled = this.rbTinsoft.Checked;
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x002C6C74 File Offset: 0x002C4E74
		private void rbNordVPN_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.rbNordVPN.Checked;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x002C6CA4 File Offset: 0x002C4EA4
		private void CheckedChangedFull()
		{
			this.rbTinsoft_CheckedChanged(null, null);
			this.rbNordVPN_CheckedChanged(null, null);
			this.rbDcom_CheckedChanged(null, null);
			this.rbXproxy_CheckedChanged(null, null);
			this.rbHma_CheckedChanged(null, null);
			this.rbChrome_CheckedChanged(null, null);
			this.rbTMProxy_CheckedChanged(null, null);
			this.rbApiUser_CheckedChanged(null, null);
			this.rbApiProxy_CheckedChanged(null, null);
			this.ckbAddChromeIntoForm_CheckedChanged(null, null);
			this.ckbUsePortable_CheckedChanged(null, null);
			this.rbDcomHilink_CheckedChanged(null, null);
			this.radioButton1_CheckedChanged(null, null);
			this.rbProxyv6_CheckedChanged(null, null);
			this.rbShopLike_CheckedChanged(null, null);
			this.rbMinProxy_CheckedChanged(null, null);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x002C6D94 File Offset: 0x002C4F94
		private void button3_Click(object sender, EventArgs e)
		{
			string api_user = this.txtApiUser.Text.Trim();
			List<string> listKey = TinsoftProxy.GetListKey(api_user);
			bool flag = listKey.Count > 0;
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SYVQwVTVObE5WYUhwa01scFVVVzVrYW1KVWF6QmFWazVEWTIxR1VGSjZXblpsVlVweVRrZEtNV0pIU25SWk1tYzk="))))))))), listKey.Count), 1);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNSV016YkVOa01rNTBUMVJTYkZVd1NubFpWVGxJVG0wNU5WRnRjekJaYmxaeldXMHhhbUZCUFQwPQ=="))))))))), 2);
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x002C6E98 File Offset: 0x002C5098
		private void rbDcom_CheckedChanged(object sender, EventArgs e)
		{
			this.plDcom.Enabled = this.rbDcom.Checked;
			this.CheckDoiIPEnable();
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x002C6ED4 File Offset: 0x002C50D4
		private void rbXproxy_CheckedChanged(object sender, EventArgs e)
		{
			this.plXproxy.Enabled = this.rbXproxy.Checked;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x002C6F04 File Offset: 0x002C5104
		private void CheckDoiIPEnable()
		{
			this.plCheckDoiIP.Enabled = (this.rbDcom.Checked || this.rbHma.Checked);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x002C6F54 File Offset: 0x002C5154
		private void rbHma_CheckedChanged(object sender, EventArgs e)
		{
			this.CheckDoiIPEnable();
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x002C6F70 File Offset: 0x002C5170
		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				ProcessStartInfo startInfo = new ProcessStartInfo(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFIyVnNjRWhpUjJocFVYcFdjMXBWWkZaUVVUMDk=")))))))))
				{
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				};
				Process process = Process.Start(startInfo);
				string text = process.StandardOutput.ReadToEnd();
				bool flag = text.Split(new char[]
				{
					'\n'
				}).Length <= 3;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkRKaFNGWjVUMVJDU2xKNlpHOWtWRlpIWTBWc1JsVnRjR2xOYWtKdVdrVm9UVkl6VGxCU2VtUjBUV3N4Ync9PQ=="))))))))), 2);
				}
				else
				{
					this.txtProfileNameDcom.Text = text.Split(new char[]
					{
						'\n'
					}).ToList<string>()[1];
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNXVRbGxoTW1SclZGVTVlRmx0YkVOaGFsSnBZMWQ0YTFVd1NuWmtlbG8wWkZkR1JGRnJWbHBOYW13d1UxVm9VMkl6WXpKUmJsWm9VVEJLY1dSNlpGTmtWbkExVWxRd1BRPT0="))))))))), 1);
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoS1VqSjRNMU5WWkZOaGJVbDVUVVF3UFE9PQ==")))))))));
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHVnJiRWhsYldneFRsZFNkMU5WYUhGaFNGWjRWR3BXU2xORmNHOVVSVTVEVFcxU1dHRXlaR2xVVlRrMVdXMHhhbG95VWtoaGJXZ3hUbXBDYmxsck9VaE9iVGxZWVRKa2FrMXJXWGhUVmtVNVVGRTlQUT09"))))))))), 2);
			}
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x002C71FC File Offset: 0x002C53FC
		private void ChangeVisibleBrowser()
		{
			bool @checked = this.rbChrome.Checked;
			if (@checked)
			{
				this.plLinkToOtherBrowser.Visible = false;
			}
			else
			{
				this.plLinkToOtherBrowser.Visible = true;
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x002C7254 File Offset: 0x002C5454
		private void rbChrome_CheckedChanged(object sender, EventArgs e)
		{
			this.ChangeVisibleBrowser();
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x002C7270 File Offset: 0x002C5470
		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				Common.CreateFolder(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwMUdiRmRsUjNoc1UwWktjMWx0TlU5alIwbDVUa1F3UFE9PQ==")))))))));
				Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwMUdiRmRsUjNoc1UwWktjMWx0TlU5alIwbDVUa1F3UFE9PQ==")))))))));
			}
			catch
			{
			}
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x002C7340 File Offset: 0x002C5540
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
			else
			{
				bool flag2 = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt;
				if (flag2)
				{
					this.plSizeChrome.Visible = false;
				}
			}
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x002C7408 File Offset: 0x002C5608
		private void rbTMProxy_CheckedChanged(object sender, EventArgs e)
		{
			this.plTMProxy.Enabled = this.rbTMProxy.Checked;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x002C7438 File Offset: 0x002C5638
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJNVmxxVGxkTlIxSlVUbGRzWVZWNmJITlhiR2h2VW14S1JsUnFWbFpTTUhCVVZEQkZPVkJSUFQwPQ==")))))))));
			}
			catch
			{
			}
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x002C74BC File Offset: 0x002C56BC
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1YxWllUMVJHYTFOR1duQlhiRTB4WVcxSmVVMUlXbXROYTFsM1YxUktia3d5VW5GTlNHUnJVa1ZhUzFwRVFqQk9SMFY2WWtWNGEyUjZNRGs9")))))))));
			}
			catch
			{
			}
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x002C7540 File Offset: 0x002C5740
		private void txtApiProxy_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtApiProxy.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.lblCountApiProxy.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCRk9WQlJQVDA9")))))))) + list.Count.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))));
			}
			catch
			{
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x002C7644 File Offset: 0x002C5844
		private void rbApiUser_CheckedChanged(object sender, EventArgs e)
		{
			this.plApiUser.Enabled = this.rbApiUser.Checked;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x002C7674 File Offset: 0x002C5874
		private void rbApiProxy_CheckedChanged(object sender, EventArgs e)
		{
			this.plApiProxy.Enabled = this.rbApiProxy.Checked;
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x002C76A4 File Offset: 0x002C58A4
		private void button7_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			List<string> list2 = this.txtApiProxy.Lines.ToList<string>();
			list2 = Common.RemoveEmptyItems(list2);
			foreach (string text in list2)
			{
				bool flag = TinsoftProxy.CheckApiProxy(text);
				if (flag)
				{
					list.Add(text);
				}
			}
			this.txtApiProxy.Lines = list.ToArray();
			bool flag2 = list.Count > 0;
			if (flag2)
			{
				MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SYVQwVTVObE5WYUhwa01scFVVVzVrYW1KVWF6QmFWazVEWTIxR1VGSjZXblpsVlVweVRrZEtNV0pIU25SWk1tYzk="))))))))), list.Count), 1);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNSV016YkVOa01rNTBUMVJTYkZVd1NubFpWVGxJVG0wNU5WRnRjekJaYmxaeldXMHhhbUZCUFQwPQ=="))))))))), 2);
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x002C782C File Offset: 0x002C5A2C
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1YxWllUMVJHYTFOR1duQlhiRTB4WVcxSmVVMUlXbXROYTFsM1YxUktia3d5VW5GTlZteFlZa1pKZVZkc1ZqQmphM2haVm1wQ1dGVlVNRGs9")))))))));
			}
			catch
			{
			}
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x002C78B0 File Offset: 0x002C5AB0
		private void plXproxy_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.ckbWaitDoneAllXproxy.Visible = true;
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x002C7910 File Offset: 0x002C5B10
		private void plTinsoft_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.ckbWaitDoneAllTinsoft.Visible = true;
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x002C7970 File Offset: 0x002C5B70
		private void plTMProxy_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.ckbWaitDoneAllTMProxy.Visible = true;
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x002C79D0 File Offset: 0x002C5BD0
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.grChrome.Height = 318;
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x002C79F4 File Offset: 0x002C5BF4
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.grChrome.Height = 233;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x002C7A18 File Offset: 0x002C5C18
		private void AddFileAccount_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fThemSizeChrome());
			this.LoadCbbSizeChrome();
			JSON_Settings json_Settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
			this.cbbSizeChrome.SelectedValue = json_Settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS2MwNXNjRlpVYlRscVlsUnNNRmRzUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YySldiRmxXYms1clVWUXdPUT09"))))))))).ToString();
			bool flag = this.cbbSizeChrome.SelectedValue == null;
			if (flag)
			{
				this.cbbSizeChrome.SelectedValue = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YySldiRmxXYms1clVWUXdPUT09"))))))));
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x002C7BA4 File Offset: 0x002C5DA4
		private void LoadCbbSizeChrome()
		{
			/*
An exception occurred when decompiling this method (06000DFD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void maxcare.fCauHinhChung::LoadCbbSizeChrome()
 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x002C7F90 File Offset: 0x002C6190
		private void button8_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			List<string> list2 = this.txtApiKeyTMProxy.Lines.ToList<string>();
			list2 = Common.RemoveEmptyItems(list2);
			foreach (string text in list2)
			{
				bool flag = TMProxy.CheckApiProxy(text);
				if (flag)
				{
					list.Add(text);
				}
			}
			this.txtApiKeyTMProxy.Lines = list.ToArray();
			bool flag2 = list.Count > 0;
			if (flag2)
			{
				MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SYVQwVTVObE5WYUhwa01scFVVVzVrYW1KVWF6QmFWazVEWTIxR1VGSjZXblpsVlVweVRrZEtNV0pIU25SWk1tYzk="))))))))), list.Count), 1);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNSV016YkVOa01rNTBUMVJTYkZVd1NubFpWVGxJVG0wNU5WRnRjekJaYmxaeldXMHhhbUZCUFQwPQ=="))))))))), 2);
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x002C8118 File Offset: 0x002C6318
		private void txtApiKeyTMProxy_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtApiKeyTMProxy.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.label24.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VsVmFVbFV4VGtOVVJrcFhZVEprVEZOSVRqTmFiRTV5VG1jOVBRPT0="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x002C81DC File Offset: 0x002C63DC
		private void txtListProxy_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtListProxy.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.label17.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VtdEtOVmxxVG05T1ZXeEVZVVJrVGxORVFuZFVNbU01VUZFOVBRPT0="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x002C82A0 File Offset: 0x002C64A0
		private void txbPathProfile_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				Process.Start(this.txbPathProfile.Text.Trim());
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x002C8300 File Offset: 0x002C6500
		private void ckbAddChromeIntoForm_CheckedChanged(object sender, EventArgs e)
		{
			this.plAddChromeVaoFormView.Enabled = this.ckbAddChromeIntoForm.Checked;
			this.plSapXepCuaSoChrome.Enabled = !this.ckbAddChromeIntoForm.Checked;
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x002C8358 File Offset: 0x002C6558
		private void button9_Click(object sender, EventArgs e)
		{
			this.txbPathProfile.Text = Common.SelectFolder();
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x002C837C File Offset: 0x002C657C
		private void ckbUsePortable_CheckedChanged(object sender, EventArgs e)
		{
			this.lblFileZip.Enabled = this.ckbUsePortable.Checked;
			this.txtPathToPortableZip.Enabled = this.ckbUsePortable.Checked;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x002C83CC File Offset: 0x002C65CC
		private void panel3_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.plUsePortable.BringToFront();
			}
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x002C8424 File Offset: 0x002C6624
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.button4.Enabled = this.rbDcomThuong.Checked;
			this.txtProfileNameDcom.Enabled = this.rbDcomThuong.Checked;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x002C8474 File Offset: 0x002C6674
		private void rbDcomHilink_CheckedChanged(object sender, EventArgs e)
		{
			this.label36.Enabled = this.rbDcomHilink.Checked;
			this.txtUrlHilink.Enabled = this.rbDcomHilink.Checked;
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x002C84C4 File Offset: 0x002C66C4
		private void rbNone_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.rbNone.Checked;
			if (@checked)
			{
				this.ckbKhongCheckIP.Checked = true;
			}
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x002C8500 File Offset: 0x002C6700
		private void txtListProxyv6_TextChanged(object sender, EventArgs e)
		{
			List<string> list = this.txtListProxyv6.Lines.ToList<string>();
			list = Common.RemoveEmptyItems(list);
			this.label43.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VtdEtOVmxxVG05T1ZXeEVZVVJrVGxORVFuZFVNbU01VUZFOVBRPT0="))))))))), list.Count.ToString());
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x002C859C File Offset: 0x002C679C
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			List<string> list = this.txtListProxyVitech.Lines.ToList<string>();
			list = Common.RemoveEmptyItems(list);
			this.label41.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VtdEtOVmxxVG05T1ZXeEVZVVJrVGxORVFuZFVNbU01VUZFOVBRPT0="))))))))), list.Count.ToString());
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x002C8638 File Offset: 0x002C6838
		private void rbProxyv6_CheckedChanged(object sender, EventArgs e)
		{
			this.plProxyv6.Enabled = this.rbProxyv6.Checked;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x002C8668 File Offset: 0x002C6868
		private void rbVitech_CheckedChanged(object sender, EventArgs e)
		{
			this.plVitech.Enabled = this.rbVitech.Checked;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x002C8698 File Offset: 0x002C6898
		private void rbShopLike_CheckedChanged(object sender, EventArgs e)
		{
			this.plShopLike.Enabled = this.rbShopLike.Checked;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x002C86C8 File Offset: 0x002C68C8
		private void txtApiProxyShopLike_TextChanged(object sender, EventArgs e)
		{
			List<string> list = this.txtApiShopLike.Lines.ToList<string>();
			list = Common.RemoveEmptyItems(list);
			this.label47.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VsVmFVbFV4VGtOVVJrcFhZVEprVEZOSVRqTmFiRTV5VG1jOVBRPT0="))))))))), list.Count.ToString());
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00069C18 File Offset: 0x00067E18
		private void txbPathProfile_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x002C8764 File Offset: 0x002C6964
		private void rbMinProxy_CheckedChanged(object sender, EventArgs e)
		{
			this.panel5.Enabled = this.rbMinProxy.Checked;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x002C8794 File Offset: 0x002C6994
		private void txtApiKeyMinProxy_TextChanged(object sender, EventArgs e)
		{
			List<string> list = this.txtApiKeyMinProxy.Lines.ToList<string>();
			list = Common.RemoveEmptyItems(list);
			this.label49.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VsVmFVbFV4VGtOVVJrcFhZVEprVEZOSVRqTmFiRTV5VG1jOVBRPT0="))))))))), list.Count.ToString());
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x002C8830 File Offset: 0x002C6A30
		private void metroButton1_Click(object sender, EventArgs e)
		{
			bool flag = this.plXproxy.Height == 260;
			if (flag)
			{
				this.plXproxy.Height = 170;
				(sender as Button).BackgroundImage = Resources.icons8_expand_arrow_24px;
			}
			else
			{
				this.plXproxy.Height = 260;
				(sender as Button).BackgroundImage = Resources.icons8_collapse_arrow_24px;
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x002C88C0 File Offset: 0x002C6AC0
		private void button10_Click(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			List<string> list2 = this.txtApiKeyMinProxy.Lines.ToList<string>();
			list2 = Common.RemoveEmptyItems(list2);
			foreach (string text in list2)
			{
				bool flag = MinProxy.CheckApiProxy(text);
				if (flag)
				{
					list.Add(text);
				}
			}
			this.txtApiKeyMinProxy.Lines = list.ToArray();
			bool flag2 = list.Count > 0;
			if (flag2)
			{
				MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SYVQwVTVObE5WYUhwa01scFVVVzVrYW1KVWF6QmFWazVEWTIxR1VGSjZXblpsVlVweVRrZEtNV0pIU25SWk1tYzk="))))))))), list.Count), 1);
			}
			else
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNSV016YkVOa01rNTBUMVJTYkZVd1NubFpWVGxJVG0wNU5WRnRjekJaYmxaeldXMHhhbUZCUFQwPQ=="))))))))), 2);
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x002C8A48 File Offset: 0x002C6C48
		private void metroButton2_Click(object sender, EventArgs e)
		{
			base.Size = new Size(1158, 930);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x002C8A74 File Offset: 0x002C6C74
		private void metroButton3_Click(object sender, EventArgs e)
		{
			base.Size = new Size(1158, 544);
		}

		// Token: 0x0400174F RID: 5967
		private JSON_Settings settings;
	}
}
