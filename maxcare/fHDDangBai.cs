using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000C7 RID: 199
	public partial class fHDDangBai : Form
	{
		// Token: 0x060007FC RID: 2044 RVA: 0x0013AE9C File Offset: 0x0013909C
		public fHDDangBai(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDDangBai.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string text = base.Name.Substring(1);
			bool flag = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), text).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1HeDBUVmRvYUZaNlVuQlVSMnhMVmxkU1dFOVlWbUZOVkd4V1YxWmtUbUZWYkVSYU1teFhVakZhTVZacmFGZGtiVXAwV2taV1dsWXdNWEJVUlU1TFZHMUplRlZ0YUVwaFYzUnVWbTEwUjFSV1dsWldiRkpLVVRKa2RRPT0=")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xb3dielJWTVVZMFUxVTFNVmR1YkVOaFdHTXlVVzVDU2xOR1NuWlhiR00wV2pGT1ZsVlhOVXhXU0UwNQ==")))))))));
			}
			string jsonStringOrPathFile = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), text);
				jsonStringOrPathFile = tuongTac.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS1IwMVdUa2hpU0Zab1VWUXdPUT09"))))))))].ToString();
				this.id_TuongTac = tuongTac.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNXa2xXYmxwcFlsZFNWbGRXWkU1UVVUMDk="))))))))].ToString();
				this.txtTenHanhDong.Text = Language.GetValue(tuongTac.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaak5WWldiRkpRVkRBOQ=="))))))))].ToString());
			}
			else
			{
				bool flag3 = type == 1;
				if (flag3)
				{
					DataTable hanhDongById = InteractSQL.GetHanhDongById(id_HanhDong);
					jsonStringOrPathFile = hanhDongById.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS1IwMVdUa2hpU0Zab1VWUXdPUT09"))))))))].ToString();
					this.btnAdd.Text = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHRlljRXhVYm1SS1VucFdkbVI2V2sxVVZ6aDZWVlF3UFE9PQ==")))))))));
					this.txtTenHanhDong.Text = hanhDongById.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUa2hTYmxab1VsWktNbGx0TVdwUVVUMDk="))))))))].ToString();
				}
			}
			this.setting = new JSON_Settings(jsonStringOrPathFile, true);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0013B2F8 File Offset: 0x001394F8
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label15);
			Language.GetValue(this.label20);
			Language.GetValue(this.label19);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.ckbDangBaiLenTuong);
			Language.GetValue(this.ckbDangBaiLenNhom);
			Language.GetValue(this.label26);
			Language.GetValue(this.label24);
			Language.GetValue(this.label25);
			Language.GetValue(this.ckbOnlyDangNhomKhongKiemDuyet);
			Language.GetValue(this.ckbDangBaiLenPage);
			Language.GetValue(this.label21);
			Language.GetValue(this.label23);
			Language.GetValue(this.label22);
			Language.GetValue(this.ckbVanBan);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.ckbUseBackground);
			Language.GetValue(this.ckbAnh);
			Language.GetValue(this.label3);
			Language.GetValue(this.label2);
			Language.GetValue(this.label10);
			Language.GetValue(this.label4);
			Language.GetValue(this.ckbVideo);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.label11);
			Language.GetValue(this.label5);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
			Language.GetValue(this.rbNganCachMoiDong);
			Language.GetValue(this.rbNganCachKyTu);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0013B548 File Offset: 0x00139748
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudDelayFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), 3);
				this.nudDelayTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), 5);
				this.ckbDangBaiLenTuong.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hTYmxaaFRVVndiMWxXVmpSaVIwcHpWV3BHYVUxcVZuVT0=")))))))), false);
				this.ckbDangBaiLenNhom.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hTYmxaaFRVVndiMWxXVmpSaVIwcHlUbGM1YVUxcVFUaz0=")))))))), false);
				this.ckbOnlyDangNhomKhongKiemDuyet.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVWGxPV0U1c1ZsWktiMWx0TVd0VU1rWklUMWhTVkUxdGFESlpiVEZyVkVkR1dGWnVVbE5UUmxreFYyeG9VbEJSUFQwPQ==")))))))), false);
				this.nudCountGroupFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtTVmt5TURWTlYwNUdWMjVzYVUxcVFUaz0=")))))))), 1);
				this.nudCountGroupTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtTVmt5TURWTlYwNUhWVzVaUFE9PQ==")))))))), 1);
				this.ckbDangBaiLenPage.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hTYmxaaFRVVndiMWxXVmpSaVIwcHpVVzFvWVUxc1ZUaz0=")))))))), false);
				this.nudCountPageFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtVbGRXWkd0aVJrcDFVMjVhYVZWVU1Eaz0=")))))))), 1);
				this.nudCountPageTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtVbGRXWkd0aVJscElUMFF3UFE9PQ==")))))))), 1);
				this.ckbVanBan.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXblJTYmxaU1lsVmFNUT09")))))))), false);
				this.ckbUseBackground.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhoU1lsVmFjVmxVU210bFYwbDZWbTVXWVZGVU1Eaz0=")))))))), false);
				this.txtNoiDung.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVblJQV0VKVFUwWmFNVmR1WXpsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.ckbAnh.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVnpnOQ==")))))))), false);
				this.ckbVideo.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXblJpUjNSaFZucG5PUT09")))))))), false);
				this.nudSoLuongAnhFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkdWMjVzYVUxcVFUaz0=")))))))), 1);
				this.nudSoLuongAnhTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkhWVzVaUFE9PQ==")))))))), 1);
				this.ckbUseAvatar.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhoU1YwWndiMXBGWkVkbFVUMDk=")))))))), false);
				this.nudSoLuongVideoFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUm1GalJuQklWbTVhVTJKcmNESlpiRVU1VUZFOVBRPT0=")))))))), 1);
				this.nudSoLuongVideoTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUm1GalJuQklWbTVhVjFKNlp6az0=")))))))), 1);
				this.txtPathAnh.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VsVmFNVmxWUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.txtPathVideo.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VteHdkMWRyWkZka1p6MDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				bool flag = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpPVnpWYVZucFdSVmRXWkU5aWR6MDk=")))))))), 0) == 1;
				if (flag)
				{
					this.rbNganCachKyTu.Checked = true;
				}
				else
				{
					this.rbNganCachMoiDong.Checked = true;
				}
			}
			catch (Exception ex)
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0013C054 File Offset: 0x0013A254
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string text = this.txtTenHanhDong.Text.Trim();
			bool flag = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV2hWVWtoR2RFNUhaR2hTTUdoT1dqQmpNV0l3YkU1Vk1Vb3pUakZTVG1KNlNURmlhMnhTVUZRd1BRPT0="))))))))), 3);
			}
			else
			{
				JSON_Settings json_Settings = new JSON_Settings();
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), this.nudDelayFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), this.nudDelayTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hTYmxaaFRVVndiMWxXVmpSaVIwcHpWV3BHYVUxcVZuVT0=")))))))), this.ckbDangBaiLenTuong.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hTYmxaaFRVVndiMWxXVmpSaVIwcHlUbGM1YVUxcVFUaz0=")))))))), this.ckbDangBaiLenNhom.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVWGxPV0U1c1ZsWktiMWx0TVd0VU1rWklUMWhTVkUxdGFESlpiVEZyVkVkR1dGWnVVbE5UUmxreFYyeG9VbEJSUFQwPQ==")))))))), this.ckbOnlyDangNhomKhongKiemDuyet.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtTVmt5TURWTlYwNUdWMjVzYVUxcVFUaz0=")))))))), this.nudCountGroupFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtTVmt5TURWTlYwNUhWVzVaUFE9PQ==")))))))), this.nudCountGroupTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hTYmxaaFRVVndiMWxXVmpSaVIwcHpVVzFvWVUxc1ZUaz0=")))))))), this.ckbDangBaiLenPage.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtVbGRXWkd0aVJrcDFVMjVhYVZWVU1Eaz0=")))))))), this.nudCountPageFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtVbGRXWkd0aVJscElUMFF3UFE9PQ==")))))))), this.nudCountPageTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXblJTYmxaU1lsVmFNUT09")))))))), this.ckbVanBan.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhoU1lsVmFjVmxVU210bFYwbDZWbTVXWVZGVU1Eaz0=")))))))), this.ckbUseBackground.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVnpnOQ==")))))))), this.ckbAnh.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXblJpUjNSaFZucG5PUT09")))))))), this.ckbVideo.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkdWMjVzYVUxcVFUaz0=")))))))), this.nudSoLuongAnhFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkhWVzVaUFE9PQ==")))))))), this.nudSoLuongAnhTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhoU1YwWndiMXBGWkVkbFVUMDk=")))))))), this.ckbUseAvatar.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUm1GalJuQklWbTVhVTJKcmNESlpiRVU1VUZFOVBRPT0=")))))))), this.nudSoLuongVideoFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUm1GalJuQklWbTVhVjFKNlp6az0=")))))))), this.nudSoLuongVideoTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVblJQV0VKVFUwWmFNVmR1WXpsUVVUMDk=")))))))), this.txtNoiDung.Text.Trim());
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VsVmFNVmxWUlRsUVVUMDk=")))))))), this.txtPathAnh.Text.Trim());
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VteHdkMWRyWkZka1p6MDk=")))))))), this.txtPathVideo.Text.Trim());
				int num = 0;
				bool @checked = this.rbNganCachKyTu.Checked;
				if (@checked)
				{
					num = 1;
				}
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpPVnpWYVZucFdSVmRXWkU5aWR6MDk=")))))))), num);
				string fullString = json_Settings.GetFullString();
				bool flag2 = this.type == 0;
				if (flag2)
				{
					bool flag3 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOa1IxSnFWSHBDTmxOVldqRlRWV2hUWWpOak1tTklVa3BTTW1odlpXdHNRMlJYUmtSU1JWWnlXVEE0ZDJWcmRFOWtWbkExVVc1U05HTlZhRTVhTVdSeVRIYzlQUT09")))))))))) == DialogResult.Yes;
					if (flag3)
					{
						bool flag4 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
						if (flag4)
						{
							fHDDangBai.isSave = true;
							base.Close();
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklSblJOUjJSclVqSndSV0l6VGpWUmJWSkVVVzFzV2xremJIRlpWazR6V2pKU2RWWnVRa3BTTTJneVpXdHNRMlJXY0RWUmFrSm9WRmRHTTJWcmJISmFNa3BJVTBVeGRrMXRkRzVaZWtwSFRWVnNVbEJVTUQwPQ=="))))))))), 2);
						}
					}
				}
				else
				{
					bool flag5 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOa1IxSnFWSHBDTmxOVldqRlRWV1JSVWtjNWVtVlhjR3BSTUVveFdWVXhVR0ZZY0V4VWFrSktVakpvYjJWcmJFTmtWMFpFVWtWV2Nsa3dPSGRsYTNSUFpGWndOazlFTUQwPQ==")))))))))) == DialogResult.Yes;
					if (flag5)
					{
						bool flag6 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
						if (flag6)
						{
							fHDDangBai.isSave = true;
							base.Close();
						}
						else
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHRlljRXhVYm1SS1VucFdkbVI2V2sxVVZ6aDZWVmRrYTFJeWNFVmlNMDQxVVcxU1JGRnRiRnBaTTJ4eFdWWk9NMW95VW5WV2JrSktVak5vTW1WcmJFTmtWbkExVVdwQ2FGUlhSak5sYTJ4eVdqSktTRk5GTVhaTmJYUnVXWHBLUjAxVmJGSlFWREE5"))))))))), 2);
						}
					}
				}
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0013CC18 File Offset: 0x0013AE18
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

		// Token: 0x06000803 RID: 2051 RVA: 0x0013CCDC File Offset: 0x0013AEDC
		private void CheckedChangeFull()
		{
			this.ckbDangBaiLenNhom_CheckedChanged(null, null);
			this.ckbDangBaiLenPage_CheckedChanged(null, null);
			this.ckbVanBan_CheckedChanged(null, null);
			this.ckbAnh_CheckedChanged(null, null);
			this.ckbVideo_CheckedChanged(null, null);
			this.checkBox1_CheckedChanged(null, null);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0013CD40 File Offset: 0x0013AF40
		private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plVanBan.Enabled = this.ckbVanBan.Checked;
			bool flag = !this.ckbVanBan.Checked;
			if (flag)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0013CDA4 File Offset: 0x0013AFA4
		private void ckbAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbAnh.Checked;
			bool @checked = this.ckbAnh.Checked;
			if (@checked)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0013CE00 File Offset: 0x0013B000
		private void ckbVideo_CheckedChanged(object sender, EventArgs e)
		{
			this.plVideo.Enabled = this.ckbVideo.Checked;
			bool @checked = this.ckbVideo.Checked;
			if (@checked)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0013CE5C File Offset: 0x0013B05C
		private void txtNoiDung_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0013CE78 File Offset: 0x0013B078
		private void UpdateSoLuongBinhLuan()
		{
			try
			{
				List<string> list = new List<string>();
				bool @checked = this.rbNganCachMoiDong.Checked;
				if (@checked)
				{
					list = this.txtNoiDung.Lines.ToList<string>();
				}
				else
				{
					list = this.txtNoiDung.Text.Split(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VVRJMU0xTjNQVDA9"))))))))
					}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				}
				list = Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1rcDZWSHBDTmxNd05YZFRWV1JUVFZkS2RGa3laRXhUU0U0eldteE9jazVuUFQwPQ=="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0013CFE0 File Offset: 0x0013B1E0
		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.txtPathAnh.Text = Common.SelectFolder();
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0013D004 File Offset: 0x0013B204
		private void metroButton2_Click(object sender, EventArgs e)
		{
			this.txtPathVideo.Text = Common.SelectFolder();
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0013D028 File Offset: 0x0013B228
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0013D09C File Offset: 0x0013B29C
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 279;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0013D0C0 File Offset: 0x0013B2C0
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 196;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0013CE5C File Offset: 0x0013B05C
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0013CE5C File Offset: 0x0013B05C
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbUseBackground_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0013D0E4 File Offset: 0x0013B2E4
		private void ckbDangBaiLenNhom_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenNhom.Enabled = this.ckbDangBaiLenNhom.Checked;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0013D114 File Offset: 0x0013B314
		private void ckbDangBaiLenPage_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenPage.Enabled = this.ckbDangBaiLenPage.Checked;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0013D144 File Offset: 0x0013B344
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NqQk9SMG94VjBkR1ZGRnRkRE5PTUhBeFYyNXNRMk16WXpKUlYyUk9WVEJLTVU1SFNqRlhiVVpVVVcxMGExWjZWblZUVmtVNVVGRTlQUT09"))))))))), 1);
			this.txtNoiDung.Focus();
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0013D1B8 File Offset: 0x0013B3B8
		private void button3_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHelpNhapComment());
			this.txtNoiDung.Focus();
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0013CE5C File Offset: 0x0013B05C
		private void rbNganCachMoiDong_CheckedChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0013CE5C File Offset: 0x0013B05C
		private void rbNganCachKyTu_CheckedChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0013D1E4 File Offset: 0x0013B3E4
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = !this.ckbUseAvatar.Checked;
		}

		// Token: 0x04000A4E RID: 2638
		private JSON_Settings setting;

		// Token: 0x04000A4F RID: 2639
		private string id_KichBan;

		// Token: 0x04000A50 RID: 2640
		private string id_TuongTac;

		// Token: 0x04000A51 RID: 2641
		private string Id_HanhDong;

		// Token: 0x04000A52 RID: 2642
		private int type;

		// Token: 0x04000A53 RID: 2643
		public static bool isSave;
	}
}
