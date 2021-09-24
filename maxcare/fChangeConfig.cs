using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
	// Token: 0x02000127 RID: 295
	public partial class fChangeConfig : Form
	{
		// Token: 0x06000D57 RID: 3415 RVA: 0x0029F434 File Offset: 0x0029D634
		public fChangeConfig()
		{
			this.InitializeComponent();
			this.Load_cbbNgonNgu();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWU1RXMW9iMWx0TVd0aVFUMDk=")))))))), false);
			this.LoadSettings();
			this.CheckedChangedFull();
			this.ChangeLanguage();
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0029F4C4 File Offset: 0x0029D6C4
		private void Load_cbbNgonNgu()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			List<string> listCountryCountryCode = SetupFolder.GetListCountryCountryCode();
			for (int i = 0; i < listCountryCountryCode.Count; i++)
			{
				string[] array = listCountryCountryCode[i].Split(new char[]
				{
					'|'
				});
				dictionary.Add(array[0], array[1]);
			}
			this.cbbNgonNgu.DataSource = new BindingSource(dictionary, null);
			this.cbbNgonNgu.ValueMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS1YwNVJQVDA9"))))))));
			this.cbbNgonNgu.DisplayMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0weFIyTXlVbGhXVkRBOQ=="))))))));
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0029F604 File Offset: 0x0029D804
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox5);
			Language.GetValue(this.label10);
			Language.GetValue(this.label11);
			Language.GetValue(this.label14);
			Language.GetValue(this.label12);
			Language.GetValue(this.metroButton1);
			Language.GetValue(this.ckbCreateProfile);
			Language.GetValue(this.groupBox3);
			Language.GetValue(this.ckbDoiNgonNgu);
			Language.GetValue(this.ckbAddPhone);
			Language.GetValue(this.ckbDoiAvatar);
			Language.GetValue(this.ckbDoiAnhBia);
			Language.GetValue(this.ckbAutoDeleteFile);
			Language.GetValue(this.rdAnhNguoiDungDat);
			Language.GetValue(this.rdAnhNgheThuat);
			Language.GetValue(this.ckbThemMoTa);
			Language.GetValue(this.btnThemMoTa);
			Language.GetValue(this.ckbDoiNgaySinh);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.label5);
			Language.GetValue(this.label6);
			Language.GetValue(this.label7);
			Language.GetValue(this.label8);
			Language.GetValue(this.label9);
			Language.GetValue(this.label13);
			Language.GetValue(this.ckbCapNhatThongTin);
			Language.GetValue(this.btnCapNhatThongTin);
			Language.GetValue(this.button3);
			Language.GetValue(this.button4);
			Language.GetValue(this.button5);
			Language.GetValue(this.button9);
			Language.GetValue(this.ckbAddMail);
			Language.GetValue(this.btnNhapHotmail);
			Language.GetValue(this.ckbAnMailMoi);
			Language.GetValue(this.ckbXoaMailCu);
			Language.GetValue(this.ckbDoiTen);
			Language.GetValue(this.rdTenTuDat);
			Language.GetValue(this.button6);
			Language.GetValue(this.button7);
			Language.GetValue(this.button8);
			Language.GetValue(this.rdTenRandom);
			Language.GetValue(this.rdTenRandomViet);
			Language.GetValue(this.rdTenRandomNgoai);
			Language.GetValue(this.ckb2fa);
			Language.GetValue(this.rdBat2fa);
			Language.GetValue(this.rdTat2fa);
			Language.GetValue(this.ckbDoiPass);
			Language.GetValue(this.rdPassTuNhap);
			Language.GetValue(this.btnNhapPass);
			Language.GetValue(this.rdPassRandom);
			Language.GetValue(this.ckbXoaSdt);
			Language.GetValue(this.ckbLogOut);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0029F9DC File Offset: 0x0029DBDC
		private void LoadSettings()
		{
			this.nudThread.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyV2xOaU1rNTBWbTFvWVZGVU1Eaz0=")))))))), 3);
			this.ckbVerify.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUdGaVIwNTBZa2N4YkZWVU1Eaz0=")))))))), false);
			this.ckbDoiNgonNgu.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldUbGMxYVUxcVZsQlhhazVXVUZFOVBRPT0=")))))))), false);
			this.cbbNgonNgu.SelectedValue = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFjRmRYY3pGaWJVbDVUbFU1WVUweFZUaz0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeGMxcHNXbkpPUkRBOQ==")))))))));
			this.ckbAddPhone.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEVkaE1YQkhVVzA1YVUxcVZuTT0=")))))))), false);
			this.txtPhone.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNRnBGV2tOaU1rbDVUbGQzUFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWU2MwNUhWa2xoUkZKc1UwZG5NRnBWUlRsUVVUMDk=")))))))));
			this.txtPathAvatar.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNRnBGV2tOaFIxSklZVVZLYTJKVldYZFhWbWhLVUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.txtPathCover.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNRnBGV2tOaFIxSklZVVZTYVUweGNITlpNbU01VUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.ckbDoiAvatar.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldVbXBLV2xkR1NtOVpNbU01VUZFOVBRPT0=")))))))), false);
			this.ckbAvatarThuTu.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEVkTmJHeFpWVzFvYW1KR1NuWmFSbHBUVFZFOVBRPT0=")))))))), false);
			this.ckbDoiAnhBia.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldVbTVXYUZKVmNIZFhWa1U1VUZFOVBRPT0=")))))))), false);
			int valueInt = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkV2JVNUdWRzVhYTJKV1dqVT0=")))))))), 0);
			bool flag = valueInt == 0;
			if (flag)
			{
				this.rdAnhNguoiDungDat.Checked = true;
			}
			else
			{
				this.rdAnhNgheThuat.Checked = true;
			}
			this.ckbCoverThuTu.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEU5a2JWSjBWbTVzVjFJeVozaFdhMmhXVUZFOVBRPT0=")))))))), false);
			this.ckbThemMoTa.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUZOaU1YQllUVlUxYVUxV1NtOD0=")))))))), false);
			this.ckbCapNhatThongTin.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEU5aFIwNUdUbGM1V2xkR1NsWlpWV00xWkZadmVGVnVRbWxhZWpBNQ==")))))))), false);
			this.ckbDoiNgaySinh.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldUbGMxV2xkSGVGVlpWbU14WW5jOVBRPT0=")))))))), false);
			this.nudNgayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaWJHeFpZa1ZrYW1KVWJEQT0=")))))))), 1);
			this.nudNgayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaWJHeFpZa1pXYVdSNk1Eaz0=")))))))), 30);
			this.nudThangFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyV2xOaU1XeFlUbGMxVTJKcmNESlpiRVU1VUZFOVBRPT0=")))))))), 1);
			this.nudThangTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyV2xOaU1XeFlUbGMxVjFKNlp6az0=")))))))), 12);
			this.nudNamFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaFIwcFdWMjVzYVUxcVFUaz0=")))))))), 1980);
			this.nudNamTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaFIwcFhWVzVaUFE9PQ==")))))))), 2000);
			this.ckbGioiTinh.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEd0alIwbDVZa1pXYUZaNlZuWT0=")))))))), false);
			int valueInt2 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkVFIwWllUMWhDVjFJeWVERlpWVVU1VUZFOVBRPT0=")))))))), 0);
			bool flag2 = valueInt2 == 0;
			if (flag2)
			{
				this.rbNu.Checked = true;
			}
			else
			{
				bool flag3 = valueInt2 == 1;
				if (flag3)
				{
					this.rbNam.Checked = true;
				}
			}
			this.ckbDoiTen.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWlhWVzE0YVZwNk1Eaz0=")))))))), false);
			int valueInt3 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkU1ZteFpWV3hXWVZaNlVUaz0=")))))))), 0);
			bool flag4 = valueInt3 == 0;
			if (flag4)
			{
				this.rdTenTuDat.Checked = true;
			}
			else
			{
				this.rdTenRandom.Checked = true;
			}
			int valueInt4 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkV1ZuQllUbFpPV2xaNlZuSlpha2wzVUZFOVBRPT0=")))))))), 0);
			bool flag5 = valueInt4 == 0;
			if (flag5)
			{
				this.rdTenRandomViet.Checked = true;
			}
			else
			{
				this.rdTenRandomNgoai.Checked = true;
			}
			this.ckbDoiPass.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWlhVVzFvYWswd01Eaz0=")))))))), false);
			int valueInt5 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkU1YwbDVZa1pHV2xkRk5UWT0=")))))))), 0);
			bool flag6 = valueInt5 == 0;
			if (flag6)
			{
				this.rdPassTuNhap.Checked = true;
			}
			else
			{
				this.rdPassRandom.Checked = true;
			}
			this.ckbChangePassLinkHacked.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWlhVVzFvYWswd05WZFpla3BYVkZkR1dFNVlTbFJTTUZweFdWUktWMkYzUFQwPQ==")))))))), false);
			this.ckb2fa.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYY0V0aVZteFNVRlF3UFE9PQ==")))))))), false);
			int valueInt6 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZabFZuQjBVbFF3UFE9PQ==")))))))), 0);
			bool flag7 = valueInt6 == 0;
			if (flag7)
			{
				this.rdBat2fa.Checked = true;
			}
			else
			{
				this.rdTat2fa.Checked = true;
			}
			this.ckbAddMail.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVlZqQmFkMWxyUlRsUVVUMDk=")))))))), false);
			this.ckbMailVip.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYmtKcFVteHdkMWt3UlRsUVVUMDk=")))))))), false);
			this.ckbXoaMailCu.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhQVjJoVlZqQmFkMWxyVms5TlVUMDk=")))))))), false);
			this.ckbAnMailMoi.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVlRWYVZqSjRlbFpHWXpWalFUMDk=")))))))), false);
			this.ckbCloseChrome.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxsU0ZwcVRXeGFSVmxWYUV0a2JVcFlWbFF3UFE9PQ==")))))))), false);
			this.ckbAddMailLinkHacked.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVlZqQmFkMWxyVmpSalIwcDBaRVZzV2xZd05YbFhiR1JTVUZFOVBRPT0=")))))))), false);
			this.txtPassMailHacked.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYm5CcVRVUkdiMWxXWkRSVFZteFlWRzVLWVZZeFJUaz0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.ckbRandomPassMailHacked.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWblJTYmxaaFVucHNNRlpWWkVkbGJVMTNUVmRvYUZZemFFcFhWbVJQWTJ4d1dGVlVNRDA9")))))))), false);
			this.ckbAnMailAll.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVlRWYVZqSjRlbFZXWkRSamR6MDk=")))))))), false);
			this.ckbXoaMailCu2.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhQVjJoVlZqQmFkMWxyVms5TlZURnVVRlF3UFE9PQ==")))))))), false);
			this.ckbLogOut.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVa2hQVnpWVlRURlpkdz09")))))))), false);
			this.ckbXoaSdt.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhQVjJoV1RXeEpkdz09")))))))), false);
			this.ckbXoaMail.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhQVjJoVlZqQmFkMWxyUlRsUVVUMDk=")))))))), false);
			int valueInt7 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xWak5XRkdVbGhTYmtKcFVWUXdPUT09")))))))), 0);
			bool flag8 = valueInt7 == 1;
			if (flag8)
			{
				this.rdXoaLinkHacked.Checked = true;
			}
			else
			{
				this.rdXoaTrucTiep.Checked = true;
			}
			this.ckbPassRandomXoaMail.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWa2hTYm5CcVRWVndiMWx0TVZOa2JVcFhZVWhhV2xaVVJtOVpWbVF6VUZFOVBRPT0=")))))))), false);
			this.ckbAutoDeleteFile.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVWktjMWxyWkZkTlJuQldWMjVDYVZJeFZUaz0=")))))))), false);
			bool flag9 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 0) == 0;
			if (flag9)
			{
				this.rbLoginUidPass.Checked = true;
			}
			else
			{
				this.rbLoginCookie.Checked = true;
			}
			bool flag10 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), 0) == 0;
			if (flag10)
			{
				this.rbLoginMFB.Checked = true;
			}
			else
			{
				this.rbLoginWWW.Checked = true;
			}
			this.ckbCreateProfile.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWHBUYlhoYVYwWktjMVpWYUV0a2JIQjBZa2hPWVZWVU1Eaz0=")))))))), false);
			this.ckbXoaThietBiTinCay.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUc5a2JHeFhWVzA1YUZZeFdYZFZWekZ6VmxkR1dFNVZVbHBYUjNNNQ==")))))))), false);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x002A12E0 File Offset: 0x0029F4E0
		private void SaveSettings()
		{
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyV2xOaU1rNTBWbTFvWVZGVU1Eaz0=")))))))), Convert.ToInt32(this.nudThread.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUdGaVIwNTBZa2N4YkZWVU1Eaz0=")))))))), this.ckbVerify.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldUbGMxYVUxcVZsQlhhazVXVUZFOVBRPT0=")))))))), this.ckbDoiNgonNgu.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFjRmRYY3pGaWJVbDVUbFU1WVUweFZUaz0=")))))))), this.cbbNgonNgu.SelectedValue);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEVkaE1YQkhVVzA1YVUxcVZuTT0=")))))))), this.ckbAddPhone.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNRnBGV2tOaU1rbDVUbGQzUFE9PQ==")))))))), this.txtPhone.Text);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNRnBGV2tOaFIxSklZVVZLYTJKVldYZFhWbWhLVUZFOVBRPT0=")))))))), this.txtPathAvatar.Text);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEVkTmJHeFpWVzFvYW1KR1NuWmFSbHBUVFZFOVBRPT0=")))))))), this.ckbAvatarThuTu.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNRnBGV2tOaFIxSklZVVZTYVUweGNITlpNbU01VUZFOVBRPT0=")))))))), this.txtPathCover.Text);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldVbXBLV2xkR1NtOVpNbU01VUZFOVBRPT0=")))))))), this.ckbDoiAvatar.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldVbTVXYUZKVmNIZFhWa1U1VUZFOVBRPT0=")))))))), this.ckbDoiAnhBia.Checked);
			int num = 0;
			bool @checked = this.rdAnhNgheThuat.Checked;
			if (@checked)
			{
				num = 1;
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkV2JVNUdWRzVhYTJKV1dqVT0=")))))))), num);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUZOaU1YQllUVlUxYVUxV1NtOD0=")))))))), this.ckbThemMoTa.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEU5aFIwNUdUbGM1V2xkR1NsWlpWV00xWkZadmVGVnVRbWxhZWpBNQ==")))))))), this.ckbCapNhatThongTin.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEU5a2JWSjBWbTVzVjFJeVozaFdhMmhXVUZFOVBRPT0=")))))))), this.ckbCoverThuTu.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWldUbGMxV2xkSGVGVlpWbU14WW5jOVBRPT0=")))))))), this.ckbDoiNgaySinh.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaWJHeFpZa1ZrYW1KVWJEQT0=")))))))), Convert.ToInt32(this.nudNgayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaWJHeFpZa1pXYVdSNk1Eaz0=")))))))), Convert.ToInt32(this.nudNgayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyV2xOaU1XeFlUbGMxVTJKcmNESlpiRVU1VUZFOVBRPT0=")))))))), Convert.ToInt32(this.nudThangFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyV2xOaU1XeFlUbGMxVjFKNlp6az0=")))))))), Convert.ToInt32(this.nudThangTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaFIwcFdWMjVzYVUxcVFUaz0=")))))))), Convert.ToInt32(this.nudNamFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXcFZlRmRyVlRGaFIwcFhWVzVaUFE9PQ==")))))))), Convert.ToInt32(this.nudNamTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEd0alIwbDVZa1pXYUZaNlZuWT0=")))))))), this.ckbGioiTinh.Checked);
			int num2 = 0;
			bool checked2 = this.rbNam.Checked;
			if (checked2)
			{
				num2 = 1;
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkVFIwWllUMWhDVjFJeWVERlpWVVU1VUZFOVBRPT0=")))))))), num2);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWlhWVzE0YVZwNk1Eaz0=")))))))), this.ckbDoiTen.Checked);
			int num3 = 0;
			bool checked3 = this.rdTenRandom.Checked;
			if (checked3)
			{
				num3 = 1;
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkU1ZteFpWV3hXWVZaNlVUaz0=")))))))), num3);
			int num4 = 0;
			bool checked4 = this.rdTenRandomNgoai.Checked;
			if (checked4)
			{
				num4 = 1;
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkV1ZuQllUbFpPV2xaNlZuSlpha2wzVUZFOVBRPT0=")))))))), num4);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWlhVVzFvYWswd01Eaz0=")))))))), this.ckbDoiPass.Checked);
			int num5 = 0;
			bool checked5 = this.rdPassRandom.Checked;
			if (checked5)
			{
				num5 = 1;
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZkU1YwbDVZa1pHV2xkRk5UWT0=")))))))), num5);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZEZOa2JVWlhVVzFvYWswd05WZFpla3BYVkZkR1dFNVlTbFJTTUZweFdWUktWMkYzUFQwPQ==")))))))), this.ckbChangePassLinkHacked.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYY0V0aVZteFNVRlF3UFE9PQ==")))))))), this.ckb2fa.Checked);
			int num6 = 0;
			bool checked6 = this.rdTat2fa.Checked;
			if (checked6)
			{
				num6 = 1;
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRURkpNVmt3WkZabFZuQjBVbFF3UFE9PQ==")))))))), num6);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVlZqQmFkMWxyUlRsUVVUMDk=")))))))), this.ckbAddMail.Checked.ToString());
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa2IySkhTbFpOVjJob1ZqTmpPUT09")))))))), 1);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYmtKcFVteHdkMWt3UlRsUVVUMDk=")))))))), this.ckbMailVip.Checked.ToString());
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhQVjJoVlZqQmFkMWxyVms5TlVUMDk=")))))))), this.ckbXoaMailCu.Checked.ToString());
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVlRWYVZqSjRlbFpHWXpWalFUMDk=")))))))), this.ckbAnMailMoi.Checked.ToString());
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxsU0ZwcVRXeGFSVmxWYUV0a2JVcFlWbFF3UFE9PQ==")))))))), this.ckbCloseChrome.Checked.ToString());
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVlZqQmFkMWxyVmpSalIwcDBaRVZzV2xZd05YbFhiR1JTVUZFOVBRPT0=")))))))), this.ckbAddMailLinkHacked.Checked.ToString());
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYm5CcVRVUkdiMWxXWkRSVFZteFlWRzVLWVZZeFJUaz0=")))))))), this.txtPassMailHacked.Text.Trim());
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWblJTYmxaaFVucHNNRlpWWkVkbGJVMTNUVmRvYUZZemFFcFhWbVJQWTJ4d1dGVlVNRDA9")))))))), this.ckbRandomPassMailHacked.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVlRWYVZqSjRlbFZXWkRSamR6MDk=")))))))), this.ckbAnMailAll.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhQVjJoVlZqQmFkMWxyVms5TlZURnVVRlF3UFE9PQ==")))))))), this.ckbXoaMailCu2.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVa2hQVnpWVlRURlpkdz09")))))))), this.ckbLogOut.Checked.ToString());
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhQVjJoV1RXeEpkdz09")))))))), this.ckbXoaSdt.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhQVjJoVlZqQmFkMWxyUlRsUVVUMDk=")))))))), this.ckbXoaMail.Checked);
			int num7 = 0;
			bool checked7 = this.rdXoaLinkHacked.Checked;
			if (checked7)
			{
				num7 = 1;
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xWak5XRkdVbGhTYmtKcFVWUXdPUT09")))))))), num7.ToString());
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWa2hTYm5CcVRWVndiMWx0TVZOa2JVcFhZVWhhV2xaVVJtOVpWbVF6VUZFOVBRPT0=")))))))), this.ckbPassRandomXoaMail.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVWktjMWxyWkZkTlJuQldWMjVDYVZJeFZUaz0=")))))))), this.ckbAutoDeleteFile.Checked);
			bool checked8 = this.rbLoginUidPass.Checked;
			if (checked8)
			{
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 0);
			}
			else
			{
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 1);
			}
			int num8 = this.rbLoginMFB.Checked ? 0 : 1;
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), num8);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWHBUYlhoYVYwWktjMVpWYUV0a2JIQjBZa2hPWVZWVU1Eaz0=")))))))), this.ckbCreateProfile.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXczFlVmRYZUc5a2JHeFhWVzA1YUZZeFdYZFZWekZ6VmxkR1dFNVZVbHBYUjNNNQ==")))))))), this.ckbXoaThietBiTinCay.Checked);
			this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00069C18 File Offset: 0x00067E18
		private void fShareConfig_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00097C18 File Offset: 0x00095E18
		private void btnOpenShare_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fCauHinhChung());
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00069C18 File Offset: 0x00067E18
		private void groupBox5_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ChứcNăngToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x002A2ABC File Offset: 0x002A0CBC
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveSettings();
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeGFHUXlVbFJSYWtKb1ZGVTVibGx0TVc1YU1XczBWSHBDYVdKWFRucFRWV1JMWVVod1RGUnVWa3BTTURVeVpXdHNSbG95U2xsWFJWSXdWRmhzUTFsdGJFVlNWM1JZVERBeGJsWjZWblZUVldSUlVqTk9UbVZWY0ZwVk1FbzJaSHBrVlZSWGJGVlBSREE5")))))))))) == DialogResult.Yes;
				if (flag)
				{
					base.Close();
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WYUZOaWVsSnBaRmhTU2xJemNHOWtXRVpIWTBWc1NWUnRhR3RWTUZVNQ=="))))))))), 2);
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x002A2BC0 File Offset: 0x002A0DC0
		private void CheckedChangedFull()
		{
			this.ckbDoiNgonNgu_CheckedChanged(null, null);
			this.ckbAddPhone_CheckedChanged(null, null);
			this.ckbDoiAvatar_CheckedChanged(null, null);
			this.ckbDoiAnhBia_CheckedChanged(null, null);
			this.rdAnhNguoiDungDat_CheckedChanged(null, null);
			this.ckbThemMoTa_CheckedChanged(null, null);
			this.ckbCapNhatThongTin_CheckedChanged(null, null);
			this.ckbDoiTen_CheckedChanged(null, null);
			this.rdTenTuDat_CheckedChanged(null, null);
			this.rdTenRandom_CheckedChanged(null, null);
			this.ckbDoiPass_CheckedChanged(null, null);
			this.rdPassTuNhap_CheckedChanged(null, null);
			this.ckb2fa_CheckedChanged(null, null);
			this.checkBox1_CheckedChanged(null, null);
			this.ckbAddMail_CheckedChanged(null, null);
			this.rdXoaLinkHacked_CheckedChanged(null, null);
			this.ckbXoaMail_CheckedChanged(null, null);
			this.ckbPassRandomXoaMail_CheckedChanged(null, null);
			this.ckbCloseChrome_CheckedChanged(null, null);
			this.ckbGioiTinh_CheckedChanged(null, null);
			this.ckbGiaiCheckPoint_CheckedChanged(null, null);
			this.ckbAnMailMoi_CheckedChanged(null, null);
			this.ckbXoaMailCu_CheckedChanged(null, null);
			this.ckbAnMailAll_CheckedChanged(null, null);
			this.ckbXoaMailCu2_CheckedChanged(null, null);
			this.ckbAddMailLinkHacked_CheckedChanged(null, null);
			this.ckbRandomPassMailHacked_CheckedChanged(null, null);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x002A2D48 File Offset: 0x002A0F48
		private void ckbDoiNgonNgu_CheckedChanged(object sender, EventArgs e)
		{
			this.cbbNgonNgu.Enabled = this.ckbDoiNgonNgu.Checked;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x002A2D78 File Offset: 0x002A0F78
		private void ckbAddPhone_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPhone.Enabled = this.ckbAddPhone.Checked;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x002A2DA8 File Offset: 0x002A0FA8
		private void ckbDoiAvatar_CheckedChanged(object sender, EventArgs e)
		{
			this.plAvatar.Enabled = this.ckbDoiAvatar.Checked;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x002A2DD8 File Offset: 0x002A0FD8
		private void ckbDoiAnhBia_CheckedChanged(object sender, EventArgs e)
		{
			this.plDoiAnhBia.Enabled = this.ckbDoiAnhBia.Checked;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x002A2E08 File Offset: 0x002A1008
		private void rdAnhNguoiDungDat_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPathCover.Enabled = this.rdAnhNguoiDungDat.Checked;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x002A2E38 File Offset: 0x002A1038
		private void ckbThemMoTa_CheckedChanged(object sender, EventArgs e)
		{
			this.btnThemMoTa.Enabled = this.ckbThemMoTa.Checked;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x002A2E68 File Offset: 0x002A1068
		private void ckbCapNhatThongTin_CheckedChanged(object sender, EventArgs e)
		{
			this.panel3.Enabled = this.ckbCapNhatThongTin.Checked;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x002A2E98 File Offset: 0x002A1098
		private void ckbDoiTen_CheckedChanged(object sender, EventArgs e)
		{
			this.plDoiTen.Enabled = this.ckbDoiTen.Checked;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x002A2EC8 File Offset: 0x002A10C8
		private void rdTenTuDat_CheckedChanged(object sender, EventArgs e)
		{
			this.plTenTuDat.Enabled = this.rdTenTuDat.Checked;
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x002A2EF8 File Offset: 0x002A10F8
		private void rdTenRandom_CheckedChanged(object sender, EventArgs e)
		{
			this.plTenNgauNhien.Enabled = this.rdTenRandom.Checked;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x002A2F28 File Offset: 0x002A1128
		private void ckbDoiPass_CheckedChanged(object sender, EventArgs e)
		{
			this.plDoiMatKhau.Enabled = this.ckbDoiPass.Checked;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x002A2F58 File Offset: 0x002A1158
		private void rdPassTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.btnNhapPass.Enabled = this.rdPassTuNhap.Checked;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x002A2F88 File Offset: 0x002A1188
		private void btnOpenAvatar_Click(object sender, EventArgs e)
		{
			this.txtPathAvatar.Text = Common.SelectFolder();
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x002A2FAC File Offset: 0x002A11AC
		private void btnAnhNguoiDungDat_Click(object sender, EventArgs e)
		{
			Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWRvYVdKWGFIQlpWbVJHVUZFOVBRPT0=")))))))));
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x002A3008 File Offset: 0x002A1208
		private void btnThemMoTa_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fNhapDuLieu2(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJDYUZZeFdYaFplazVXVUZFOVBRPT0=")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVFVkR2FsUXpSalpUVjNkNFUxVm9VVkl6VGs1bFZXODk=")))))))))));
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x002A30B0 File Offset: 0x002A12B0
		private void btnCapNhatThongTin_Click(object sender, EventArgs e)
		{
			Common.OpenFileAndPressData(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJDYUZKNmJERlhhazVUWTBkS2RGUnRhR2xpVjJodldXMTRORlF5U1hsaVJURmFWbnBHV0ZsV1pGZGhhM2gxVldwU2ExRlVNRGs9")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVkROb2VGSnVRa3BTTTJodlpXdHNRMlJGYkVsWGJrSXpUbTVLVG1KNlNrNVFVVDA5"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1sSk9XVmhrTmxOVlJtNVpWRXB2Wkc1d1NsSnRaejA9"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x002A31E8 File Offset: 0x002A13E8
		private void button6_Click(object sender, EventArgs e)
		{
			Common.OpenFileAndPressData(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWQwYVUxdGQzZFhiR014V1RKR1NFOUlWbXRUUjJkMw==")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVTFkSk5HVlhiejA9"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1VNUlUREF4ZG1SNk1Eaz0="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x002A3320 File Offset: 0x002A1520
		private void button7_Click(object sender, EventArgs e)
		{
			Common.OpenFileAndPressData(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWQwYVUxdGQzZFhiR014V1RKU1NGWnVWbUZTTVZvd1ZFYzFVMDVIVWtKUVZEQTk=")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVmxoak1tTklWa3BVVms1VFpIcGFlVlJYT0hsTlJEQTk="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1WcE9WRE5HYVdGVlVrWmhNazVRWTFod1RGUnVVVDA9"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x002A3458 File Offset: 0x002A1658
		private void button8_Click(object sender, EventArgs e)
		{
			Common.OpenFileAndPressData(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWQwYVUxdGQzZFhiR014V1RKU1NGWnVWazFpYkVrd1drVkZPVkJSUFQwPQ==")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVmxoak1tTklWVDA9"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1WcE9WRE5HYVZwNk1Eaz0="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x002A3590 File Offset: 0x002A1790
		private void btnNhapPass_Click(object sender, EventArgs e)
		{
			Common.OpenFileAndPressData(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWQwYVUxdGVEQlpXR3N4VFVkV1NWVlVNRDA9")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWkVoak1sUkZNWFpOTVVadVdWUktjVkpIT1hwbFZYQnJWVEJLY1dSNldrMVVWMlJJVGtka05GTnJhRVZrUlRFMVUyMUdVbEJVTUQwPQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1rcHFWREpzTmxNd05IZFRWV1F3WWpOak1sUkZNWEJYUmxVNQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x002A36C8 File Offset: 0x002A18C8
		private void ckb2fa_CheckedChanged(object sender, EventArgs e)
		{
			this.pl2fa.Enabled = this.ckb2fa.Checked;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x002A36F8 File Offset: 0x002A18F8
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.panel1.Enabled = this.ckbDoiNgaySinh.Checked;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x002A3728 File Offset: 0x002A1928
		private void btnOpenCover_Click(object sender, EventArgs e)
		{
			this.txtPathCover.Text = Common.SelectFolder();
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x002A374C File Offset: 0x002A194C
		private void button3_Click(object sender, EventArgs e)
		{
			Common.OpenFileAndPressData(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJDYUZKNmJERlhhazVUWTBkS2RGUnRhR2xpVjJodldXMTRORlZ0VWxoV2JFcHJWakJhTVZSSE5WTk9SMUpDVUZRd1BRPT0=")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVlcxU2FsUXpSa3BUUlZsNFYxZE9OVkZ0U201UVZEQTk="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1sSk9XVmhrTmxOVlJtNVpWRXB2Wkc1d1NsSnRaejA9"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x002A3884 File Offset: 0x002A1A84
		private void button4_Click(object sender, EventArgs e)
		{
			Common.OpenFileAndPressData(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJDYUZKNmJERlhhazVUWTBkS2RGUnRhR2xpVjJodldXMTRORlpYUmtoU2JsWm9VbXRLZGxsdWF6Rk5SMVpKVlZRd1BRPT0=")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVmxkR1NGTkZNVzVTZWxaMlUxVm9RMkl6WXpOV1JURnVWVlF3T1E9PQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1sSk9XVmhrTmxOVlJtNVpWRXB2Wkc1d1NsSnRaejA9"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x002A39BC File Offset: 0x002A1BBC
		private void button5_Click(object sender, EventArgs e)
		{
			Common.OpenFileAndPressData(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJDYUZKNmJERlhhazVUWTBkS2RGUnRhR2xpVjJodldXMTRORlpYVG5WV2JscHBZbGRTUmxVd1RURk5SMVpKVlZRd1BRPT0=")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVmxkT2VsbFlaRFJqVldoT1dqQmpNV0pyYkU1Vk1VWlVVVlF3T1E9PQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1sSk9XVmhrTmxOVlJtNVpWRXB2Wkc1d1NsSnRaejA9"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x002A3AF4 File Offset: 0x002A1CF4
		private void button9_Click(object sender, EventArgs e)
		{
			Common.OpenFileAndPressData(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJDYUZKNmJERlhhazVUWTBkS2RGUnRhR2xpVjJodldXMTRORlpYVG5WV2JscHBZbGRTVmxVd1drTldWWGgxVldwU2ExRlVNRGs9")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVmxkT2VsbFlaRFJqVldoT1dqQmpNV0pyYkVkVmEyeFdVbXhGT1E9PQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1sSk9XVmhrTmxOVlJtNVpWRXB2Wkc1d1NsSnRaejA9"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x002A3C2C File Offset: 0x002A1E2C
		private void btnNhapHotmail_Click(object sender, EventArgs e)
		{
			Common.CreateFolder(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWRvWVZJeFNqQlhWbVJ6WTNjOVBRPT0=")))))))));
			Common.ShowForm(new fNhapMailAdd());
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x002A3C90 File Offset: 0x002A1E90
		private void ckbAddMail_CheckedChanged(object sender, EventArgs e)
		{
			this.plDoiMail.Enabled = this.ckbAddMail.Checked;
			this.ckbXoaMailCu2.Enabled = !this.ckbAddMail.Checked;
			this.ckbAnMailAll.Enabled = !this.ckbAddMail.Checked;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x002A3D10 File Offset: 0x002A1F10
		private void btnNhapPassXoaMail_Click(object sender, EventArgs e)
		{
			Common.OpenFileAndPressData(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVWQwYVUxdGVEQlpXSEJLWkZkU1NXRkVRVDA9")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWkVoak1sUkZNWFpOTVVadVdWUktjVkpIT1hwbFZYQnJWVEJLTUdWSVJrbFVWMlJZWVhvd1BRPT0="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1rcHFWREpzTmxNd05IZFRWV1F3WWpOak1sUkZNWEJYUmxVNQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x002A3E48 File Offset: 0x002A2048
		private void ckbXoaMail_CheckedChanged(object sender, EventArgs e)
		{
			this.plXoaMail.Enabled = this.ckbXoaMail.Checked;
			bool @checked = this.ckbXoaMail.Checked;
			if (@checked)
			{
				bool flag = this.ckbAddMail.Checked && this.ckbXoaMailCu.Checked;
				if (flag)
				{
					this.ckbXoaMailCu.Checked = false;
				}
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x002A3EDC File Offset: 0x002A20DC
		private void rdXoaLinkHacked_CheckedChanged(object sender, EventArgs e)
		{
			this.plXoaMailLinkHacked.Enabled = this.rdXoaLinkHacked.Checked;
			bool @checked = this.rdXoaLinkHacked.Checked;
			if (@checked)
			{
				this.ckbDoiPass.Checked = false;
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x002A3F38 File Offset: 0x002A2138
		private void ckbPassRandomXoaMail_CheckedChanged(object sender, EventArgs e)
		{
			this.btnNhapPassXoaMail.Enabled = !this.ckbPassRandomXoaMail.Checked;
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x002A3F70 File Offset: 0x002A2170
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.ckbAutoDeleteFile.Visible = true;
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbCloseChrome_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x002A3FD0 File Offset: 0x002A21D0
		private void button1_Click(object sender, EventArgs e)
		{
			Common.CreateFolder(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJLWVZkRmNIZFhiVFZ5VUZFOVBRPT0=")))))))));
			Common.ShowForm(new fNhapDuLieu1(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWcVRXczFkbGRXWXpGaWJIQlhaVVJLWVZkRmNIZFhiVFZ6V1RKR1NFOVVRbWxXTUZwM1dXdE5NVTFIVmtsVlZEQTk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWWpKSmVsVnVVbHBXTW5oNlZFUkpOVTFYVWtobFNGcHBUVzVPYmxkck1WQk9WMHAwV1RKa05GTnJhRzlrVkZKT1dqSlNkRlp1YkdoV01XOHg=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1YQllUVmRvYUZZelp6UlpNR1JIWlcxT05WRnVVbHBXTW5oNg==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ==")))))))), null));
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x002A414C File Offset: 0x002A234C
		private void ckbVerify_CheckedChanged(object sender, EventArgs e)
		{
			this.button1.Enabled = this.ckbVerify.Checked;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x002A417C File Offset: 0x002A237C
		private void ckbGioiTinh_CheckedChanged(object sender, EventArgs e)
		{
			this.panel5.Enabled = this.ckbGioiTinh.Checked;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbGiaiCheckPoint_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x002A41AC File Offset: 0x002A23AC
		private void btnConfigCheckpoint_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fCheckPoint());
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00069C18 File Offset: 0x00067E18
		private void groupBox3_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00069C18 File Offset: 0x00067E18
		private void plDoiMail_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbAnMailMoi_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbXoaMailCu_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbAnMailAll_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbXoaMailCu2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x002A41C8 File Offset: 0x002A23C8
		private void ckbAddMailLinkHacked_CheckedChanged(object sender, EventArgs e)
		{
			this.plPassMailHacked.Enabled = this.ckbAddMailLinkHacked.Checked;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x002A41F8 File Offset: 0x002A23F8
		private void ckbRandomPassMailHacked_CheckedChanged(object sender, EventArgs e)
		{
			this.txtPassMailHacked.Enabled = !this.ckbRandomPassMailHacked.Checked;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00069C18 File Offset: 0x00067E18
		private void plDoiMatKhau_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x002A4230 File Offset: 0x002A2430
		private void button2_Click_1(object sender, EventArgs e)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHVnJiRWxWYlRnd1dXNVdSVk5WYUZGaFNGVXlUVWRrWVZRd1l6TmpSbU14WW10c1NHUnJVakpWTUVsM1RrZEtNV1ZGYkVSaU1tUTBVMnRvYjJSVVVrNWFNazUwVW01V1lWSjZiREJUVlZKR1dqSkZORlI2YkVwVFJsSnZaRlJrUmxveVNuUmFiV2d4WTFoUmVGTlZZekZpTWtacVZETkdhV0ZWVms5Uk1uaHBVa2hLVkZGdGN6QlpibFp6VkRKc1ExUnNUbFpPU0VaTVlWYzVlRk15YkhaYU1VSlZUa2RrVlZaWGVGQlhhMlJoWW0xR1NWVnRaejA9"))))))));
			MessageBoxHelper.ShowMessageBox(@string, 1);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x04001622 RID: 5666
		private JSON_Settings settings;
	}
}
