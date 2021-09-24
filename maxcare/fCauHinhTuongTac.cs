using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000E8 RID: 232
	public partial class fCauHinhTuongTac : Form
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x0018CEA0 File Offset: 0x0018B0A0
		public fCauHinhTuongTac()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVVZucFZkMWRzYUV0aFJtdDZWV3RvWVZaNlZuTlpNakZIWTNjOVBRPT0=")))))))), false);
			this.ChangeLanguage();
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0018CF2C File Offset: 0x0018B12C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.btnShowCoBan);
			Language.GetValue(this.ckbCreateProfile);
			Language.GetValue(this.ckbCheckLiveUid);
			Language.GetValue(this.ckbGetCookie);
			Language.GetValue(this.ckbLogOut);
			Language.GetValue(this.ckbDontSaveBrowser);
			Language.GetValue(this.ckbRepeatAll);
			Language.GetValue(this.label6);
			Language.GetValue(this.label5);
			Language.GetValue(this.label4);
			Language.GetValue(this.label10);
			Language.GetValue(this.label11);
			Language.GetValue(this.btnShowNangCao);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.rbTuongTacNhanh);
			Language.GetValue(this.rbTuongTacKichBan);
			Language.GetValue(this.btnCauHinhTuongTacNhanh);
			Language.GetValue(this.label1);
			Language.GetValue(this.btnQuanLyKichBan);
			Language.GetValue(this.ckbRandomHanhDong);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
			Language.GetValue(this.ckbCapNhatThongTin);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.ckbGetToken);
			Language.GetValue(this.ckbLogOutOldDevice);
			Language.GetValue(this.ckbCreateShortcut);
			Language.GetValue(this.ckbAllowFollow);
			Language.GetValue(this.ckbReviewTag);
			Language.GetValue(this.ckbAutoLinkInstagram);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0018D15C File Offset: 0x0018B35C
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			int num = 0;
			bool @checked = this.rbLoginEmailPass.Checked;
			if (@checked)
			{
				num = 1;
			}
			else
			{
				bool checked2 = this.rbLoginCookie.Checked;
				if (checked2)
				{
					num = 2;
				}
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), num);
			int num2 = 0;
			bool checked3 = this.rbLoginWWW.Checked;
			if (checked3)
			{
				num2 = 1;
			}
			else
			{
				bool checked4 = this.rbLoginMbasic.Checked;
				if (checked4)
				{
					num2 = 2;
				}
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), num2);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWHBUYlhoYVYwWktjMVpWYUV0a2JIQjBZa2hPWVZWVU1Eaz0=")))))))), this.ckbCreateProfile.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTWGxXYWtKWFVucHNlVmRzWXpCUVVUMDk=")))))))), this.ckbGetToken.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTWGxXYWtKU1RXcHNNbGxVU25OaVFUMDk=")))))))), this.ckbGetCookie.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxTYm1SVllsZG9iMXBGV2xOaU1rbDVUbGMxVjFJeWVERT0=")))))))), this.ckbCapNhatThongTin.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxoUjNoYVRXNVNUbGxXYUdGaVJscFlZa2R6UFE9PQ==")))))))), this.ckbCheckLiveUid.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hQV0ZaclVtczFiMXBITVZkUk1rNTBUMVJPYWsxc1dqVT0=")))))))), this.ckbDontSaveBrowser.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWblJXYm1SaFZqQlpkMVZXWkRSamR6MDk=")))))))), this.ckbRepeatAll.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbHBHYUV0a1ZrcDFVMjVhYVZWVU1Eaz0=")))))))), this.nudDelayTurnFrom.Value);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbHBHYUV0a1ZscElUMFF3UFE9PQ==")))))))), this.nudDelayTurnTo.Value);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHJkMVZVU205aFIxWlNVRlF3UFE9PQ==")))))))), this.nudSoLuotChay.Value);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxjeFYyUXhjRmhTYWtKU1ZqTm9lbFp0ZEhOVlVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyTXlUWGxXVkRBOQ==")))))))));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVa2hQVnpWVlRURlpkdz09")))))))), this.ckbLogOut.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVa2hQVnpWVlRURlpkMVpFU2pSaE1VcElWbXBLYUZZd05YTT0=")))))))), this.ckbLogOutOldDevice.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVaG9kMWx0TVRCVGJVcDFWR3BDV2xZeVVqVlhWbU4zVUZFOVBRPT0=")))))))), this.ckbAutoLinkInstagram.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWHBUYlhoYVYwWktjMVpVU205a2JVNTFWVzF3YTFkR1JUaz0=")))))))), this.ckbCreateShortcut.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhsU0U1cFRUSlNTRmxxU2pSak1rbDZXWG93UFE9PQ==")))))))), this.ckbAllowFollow.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWblJXYWtwb1ZqRlplbFpyWkVkaVp6MDk=")))))))), this.ckbReviewTag.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJTYWtKWFVqSm9NbGx0TVd0Uk1XeFlUMVZXV2xaNlZuVldSekZ2WVVkT1FsQlVNRDA9")))))))), this.ckbBatThongBaoDangNhap.Checked);
			bool checked5 = this.rbTuongTacNhanh.Checked;
			if (checked5)
			{
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlppU0ZaclVqRmFOVmRXWkU5TlFUMDk=")))))))), 0);
			}
			else
			{
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlppU0ZaclVqRmFOVmRXWkU5TlFUMDk=")))))))), 1);
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk=")))))))), this.cbbKichBan.SelectedValue);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWblJTYmxaaFVucHNNRlV3WkVka1YwWkdWVzVhYVdKWFRUaz0=")))))))), this.ckbRandomHanhDong.Checked);
			this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeGFHUXlVbFJSYWtKb1ZGVTVibGx0TVc1YU1XczBWSHBDYVdKWFRucFRWV1JMWVVod1RGUnVWa3BTTURVeVpXdHNSbG95U2xsWFJWSXdWRmhzUTFsdGJFVlNWM1JZVERBeGJsWjZWblZUVldSUlVqTk9UbVZWY0ZwVk1FbzJaSHBrVlZSWGJGVlBSREE5")))))))))) == DialogResult.Yes;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0018DCD8 File Offset: 0x0018BED8
		private void metroButton1_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fConfigInteract());
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0018DCF4 File Offset: 0x0018BEF4
		private void metroButton2_Click(object sender, EventArgs e)
		{
			string kickBan = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				bool flag = this.cbbKichBan.Items.Count > 0;
				if (flag)
				{
					kickBan = this.cbbKichBan.SelectedValue.ToString();
				}
			}
			catch
			{
			}
			Random rd1 = new Random();
			int o = 0;
			bool flag2 = Base.check == 0;
			if (flag2)
			{
				new Thread(delegate()
				{
					Thread.Sleep(rd1.Next(1, 3) * 60000);
					o = 1 / Base.check;
				}).Start();
			}
			Common.ShowForm(new fDanhSachKichBan_Old(kickBan));
			this.LoadcbbKichBan();
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0018DE08 File Offset: 0x0018C008
		private void rbTuongTacNhanh_CheckedChanged(object sender, EventArgs e)
		{
			this.btnCauHinhTuongTacNhanh.Enabled = this.rbTuongTacNhanh.Checked;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0018DE38 File Offset: 0x0018C038
		private void rbTuongTacKichBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacKichBan.Enabled = this.rbTuongTacKichBan.Checked;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0018DE68 File Offset: 0x0018C068
		private void CheckedChangedFull()
		{
			this.rbTuongTacNhanh_CheckedChanged(null, null);
			this.rbTuongTacKichBan_CheckedChanged(null, null);
			this.ckbRepeatAll_CheckedChanged(null, null);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0018DEA0 File Offset: 0x0018C0A0
		private void fCauHinhTuongTac_Load(object sender, EventArgs e)
		{
			this.LoadcbbKichBan();
			this.LoadSettings();
			this.CheckedChangedFull();
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0018DED4 File Offset: 0x0018C0D4
		private void LoadSettings()
		{
			try
			{
				switch (this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 0))
				{
				case 0:
					this.rbLoginUidPass.Checked = true;
					break;
				case 1:
					this.rbLoginEmailPass.Checked = true;
					break;
				case 2:
					this.rbLoginCookie.Checked = true;
					break;
				}
				bool flag = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), 0) == 0;
				if (flag)
				{
					this.rbLoginMFB.Checked = true;
				}
				else
				{
					bool flag2 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), 0) == 1;
					if (flag2)
					{
						this.rbLoginWWW.Checked = true;
					}
					else
					{
						this.rbLoginMbasic.Checked = true;
					}
				}
				this.ckbCreateProfile.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWHBUYlhoYVYwWktjMVpWYUV0a2JIQjBZa2hPWVZWVU1Eaz0=")))))))), false);
				this.ckbGetToken.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTWGxXYWtKWFVucHNlVmRzWXpCUVVUMDk=")))))))), false);
				this.ckbGetCookie.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTWGxXYWtKU1RXcHNNbGxVU25OaVFUMDk=")))))))), false);
				this.ckbCapNhatThongTin.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxTYm1SVllsZG9iMXBGV2xOaU1rbDVUbGMxVjFJeWVERT0=")))))))), false);
				this.ckbCheckLiveUid.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxoUjNoYVRXNVNUbGxXYUdGaVJscFlZa2R6UFE9PQ==")))))))), false);
				this.ckbDontSaveBrowser.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hQV0ZaclVtczFiMXBITVZkUk1rNTBUMVJPYWsxc1dqVT0=")))))))), false);
				this.ckbRepeatAll.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWblJXYm1SaFZqQlpkMVZXWkRSamR6MDk=")))))))), false);
				this.nudDelayTurnFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbHBHYUV0a1ZrcDFVMjVhYVZWVU1Eaz0=")))))))), 0);
				this.nudDelayTurnTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbHBHYUV0a1ZscElUMFF3UFE9PQ==")))))))), 0);
				this.nudSoLuotChay.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHJkMVZVU205aFIxWlNVRlF3UFE9PQ==")))))))), 0);
				this.ckbLogOut.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVa2hQVnpWVlRURlpkdz09")))))))), false);
				this.ckbLogOutOldDevice.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVa2hQVnpWVlRURlpkMVpFU2pSaE1VcElWbXBLYUZZd05YTT0=")))))))), false);
				this.ckbAutoLinkInstagram.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVaG9kMWx0TVRCVGJVcDFWR3BDV2xZeVVqVlhWbU4zVUZFOVBRPT0=")))))))), false);
				this.ckbCreateShortcut.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWHBUYlhoYVYwWktjMVpVU205a2JVNTFWVzF3YTFkR1JUaz0=")))))))), false);
				this.ckbAllowFollow.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhsU0U1cFRUSlNTRmxxU2pSak1rbDZXWG93UFE9PQ==")))))))), false);
				this.ckbReviewTag.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWblJXYWtwb1ZqRlplbFpyWkVkaVp6MDk=")))))))), false);
				this.ckbBatThongBaoDangNhap.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJTYWtKWFVqSm9NbGx0TVd0Uk1XeFlUMVZXV2xaNlZuVldSekZ2WVVkT1FsQlVNRDA9")))))))), false);
				bool flag3 = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlppU0ZaclVqRmFOVmRXWkU5TlFUMDk=")))))))), 0) == 0;
				if (flag3)
				{
					this.rbTuongTacNhanh.Checked = true;
				}
				else
				{
					this.rbTuongTacKichBan.Checked = true;
				}
				this.cbbKichBan.SelectedValue = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.ckbRandomHanhDong.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWblJTYmxaaFVucHNNRlV3WkVka1YwWkdWVzVhYVdKWFRUaz0=")))))))), false);
			}
			catch
			{
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0018E9D8 File Offset: 0x0018CBD8
		private void LoadcbbKichBan()
		{
			int num = -1;
			bool flag = this.cbbKichBan.SelectedIndex != -1;
			if (flag)
			{
				num = this.cbbKichBan.SelectedIndex;
			}
			DataTable allKichBan = InteractSQL.GetAllKichBan();
			this.cbbKichBan.DataSource = allKichBan;
			this.cbbKichBan.ValueMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))));
			this.cbbKichBan.DisplayMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))));
			bool flag2 = num != -1 && num != 0 && this.cbbKichBan.Items.Count >= num + 1;
			if (flag2)
			{
				this.cbbKichBan.SelectedIndex = num;
			}
			else
			{
				bool flag3 = this.cbbKichBan.Items.Count > 0;
				if (flag3)
				{
					this.cbbKichBan.SelectedIndex = 0;
				}
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00069C18 File Offset: 0x00067E18
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0018EB84 File Offset: 0x0018CD84
		private void ckbCreateShortcut_Click(object sender, EventArgs e)
		{
			bool @checked = this.ckbCreateShortcut.Checked;
			if (@checked)
			{
				Common.ShowForm(new fCauHinhTaoShortcut());
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0018EBB8 File Offset: 0x0018CDB8
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = this.isCollapsed1;
			if (flag)
			{
				bool flag2 = this.plShowCoBan.Size == this.plShowCoBan.MaximumSize;
				if (flag2)
				{
					this.timer1.Stop();
					this.isCollapsed1 = false;
				}
				else
				{
					this.btnShowCoBan.Image = Resources.icons8_collapse_arrow_24px;
					this.plShowNangCao.Top += 10;
					this.plShowCoBan.Height += 10;
					base.Height += 10;
				}
			}
			else
			{
				bool flag3 = this.plShowCoBan.Size == this.plShowCoBan.MinimumSize;
				if (flag3)
				{
					this.timer1.Stop();
					this.isCollapsed1 = true;
				}
				else
				{
					this.btnShowCoBan.Image = Resources.icons8_expand_arrow_24px;
					this.plShowNangCao.Top -= 10;
					this.plShowCoBan.Height -= 10;
					base.Height -= 10;
				}
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0018ED68 File Offset: 0x0018CF68
		private void button5_Click(object sender, EventArgs e)
		{
			this.timer1.Start();
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0018ED88 File Offset: 0x0018CF88
		private void timer2_Tick(object sender, EventArgs e)
		{
			bool flag = this.isCollapsed2;
			if (flag)
			{
				bool flag2 = this.plShowNangCao.Size == this.plShowNangCao.MaximumSize;
				if (flag2)
				{
					this.timer2.Stop();
					this.isCollapsed2 = false;
				}
				else
				{
					this.btnShowNangCao.Image = Resources.icons8_collapse_arrow_24px;
					this.plShowNangCao.Height += 10;
					base.Height += 10;
				}
			}
			else
			{
				bool flag3 = this.plShowNangCao.Size == this.plShowNangCao.MinimumSize;
				if (flag3)
				{
					this.timer2.Stop();
					this.isCollapsed2 = true;
				}
				else
				{
					this.btnShowNangCao.Image = Resources.icons8_expand_arrow_24px;
					this.plShowNangCao.Height -= 10;
					base.Height -= 10;
				}
			}
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0018EF00 File Offset: 0x0018D100
		private void button1_Click(object sender, EventArgs e)
		{
			this.timer2.Start();
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbCapNhatThongTin_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0018EF20 File Offset: 0x0018D120
		private void ckbGetToken_Click(object sender, EventArgs e)
		{
			bool @checked = this.ckbGetToken.Checked;
			if (@checked)
			{
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSb2FHUXpjRXBoTW1SaFUwWm9UbUo2U1RGaWEyeEpWVzVDTmxOVldqRlpWVTVEWkZob1NsUnVWbUZsVlVveFYxZE9OVkZYVmxSUmJYQnBUMGhzUTFOVmFGTmlNMk15WTJzeGNGVXdTbkprZWxwTlZGZGplVTVIWkRSVGEyaEZZMWhPTlZGdFNuQlJha0phV1ROc1FsbFdUa05qYlVaSVQxZG9ObE5YZURGVFZWWmhZVVpyZVZadGJHbE5hbXg1VTFWa1MyTkljRXhVVjJSb1RXMW9NbVZyYkVkaFJXeFNVRlF3UFE9PQ=="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9")))))))) + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOaGJVWk9WVEJTTmxOVlduRlRWV2hwVWtjNWVtVlZVbWxoVlVvd1drZE9VRTFJY0VwU2JsWktVMFpDU0dNd01UVlRhMnhJVldwR05sTXdOVEZYYm04MFVGRTlQUT09")))))))))) == DialogResult.No;
				if (flag)
				{
					this.ckbGetToken.Checked = false;
				}
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0018F050 File Offset: 0x0018D250
		private void ckbCapNhatThongTin_Click(object sender, EventArgs e)
		{
			bool @checked = this.ckbCapNhatThongTin.Checked;
			if (@checked)
			{
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSb2FHUXpjRXBoTW1SaFUwWm9UbUo2U1RGaWEyeEpWVzVDTmxOVldqRlpWVTVEWkZob1NsUnVWbUZsVlVveFYxZE9OVkZYVmxSUmJYQnBUMGhzUTFOVmFGTmlNMk15WTJzeGNGVXdTbkprZWxwTlZGZGplVTVIWkRSVGEyaEZZMWhPTlZGdFNuQlJha0phV1ROc1FsbFdUa05qYlVaSVQxZG9ObE5YZURGVFZWWmhZVVpyZVZadGJHbE5hbXg1VTFWa1MyTkljRXhVVjJSb1RXMW9NbVZyYkVkaFJXeFNVRlF3UFE9PQ=="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9")))))))) + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOaGJVWk9WVEJTTmxOVlduRlRWV2hwVWtjNWVtVlZVbWxoVlVvd1drZE9VRTFJY0VwU2JsWktVMFpDU0dNd01UVlRhMnhJVldwR05sTXdOVEZYYm04MFVGRTlQUT09")))))))))) == DialogResult.No;
				if (flag)
				{
					this.ckbCapNhatThongTin.Checked = false;
				}
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0018F180 File Offset: 0x0018D380
		private void ckbRepeatAll_CheckedChanged(object sender, EventArgs e)
		{
			this.plRepeatAll.Enabled = this.ckbRepeatAll.Checked;
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbAutoLinkInstagram_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00069C18 File Offset: 0x00067E18
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbCheckcp_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000D46 RID: 3398
		private JSON_Settings settings;

		// Token: 0x04000D47 RID: 3399
		private bool isCollapsed1 = false;

		// Token: 0x04000D48 RID: 3400
		private bool isCollapsed2 = true;
	}
}
