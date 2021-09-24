using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
	// Token: 0x02000106 RID: 262
	public partial class fHDDangStatus : Form
	{
		// Token: 0x06000B05 RID: 2821 RVA: 0x00207ADC File Offset: 0x00205CDC
		public fHDDangStatus(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDDangStatus.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxSldiRmhPVnpWV1RURktiMXBGYUZkbFp6MDk="))))))))).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1HeDBUVmRvYUZaNlVuQlVSMnhMVmxkU1dFOVlWbUZOVkd4V1YxWmtUbUZWYkVSYU1teFhVakZhTVZacmFGZGtiVXAwV2taV1dsWXdNWEJVUlU1Q1lWWkZlVkpxUmxSU01uZ3hXVlZPU21Nd2JFUlRhelZwVFZaS2IxTlhiSEphTVZweVVtc3hWMVpXV2xWVFZVNXVZbXhPUmxWclZscFdlbFoxVmxST1UyRkhVa2xXYm5CTFpWaGtibE5xVG5wYU1HeEVVMjF3YUUxcmNGaFhWbU14VVRGc1dFNUhiRkJoVlVad1ZXMHhSMk15VFhsV1YyeE5VVEJ2ZDFwVmFGTlVNa2w1WWtWV2ExWjZWblZUVjNCMldqQnNjRk5ZVGtwUk1FWnVVMWN4VDJOc2JISlNibFpvVVRCck1sTlZUa3RTTVd4WVpVaHdZVlV3YkhwVFZ6VlRUa2RTUjFGdGFHdFNNbWhEV1cweGJtRlZPWEJUVjJ4TlVUQndNVnBHWkZOV1IwbDNaVVJHYVUxcVZuVlZWbU14WWpCc2NXSXlaRXBoYTFad1ZFVk9RbG93YkhSVWJrcGFZa1p3ZDFkclpGZGthMnh4WWpKa1NtRXhjRzlaYTJoUFlrVnNjR1F5Ykd0VFIyZDNWbFZrUjAxSFJrZFhia0poVWpGYU1sTlhjSFpoVld4d1pESnNhV0pzV25KV1ZFazFWRmRTV0U5WVZtRk5WbkIzVjJ0a1YyUnJiSEZpTW1SS1lXdFdjRnBzVG1wak1HeEVXbXRXY2xSV1RrVlpiVEZxV2pKTmVsVnRhR3RUUmxvMlUyNXNjazUzUFQwPQ==")))))))));
			}
			string jsonStringOrPathFile = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxSldiRmhPVnpWV1RURktiMXBGYUZkbFp6MDk=")))))))));
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

		// Token: 0x06000B06 RID: 2822 RVA: 0x00207F64 File Offset: 0x00206164
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label15);
			Language.GetValue(this.label17);
			Language.GetValue(this.label18);
			Language.GetValue(this.label16);
			Language.GetValue(this.label20);
			Language.GetValue(this.label19);
			Language.GetValue(this.ckbVanBan);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.button2);
			Language.GetValue(this.label8);
			Language.GetValue(this.ckbAnh);
			Language.GetValue(this.label3);
			Language.GetValue(this.label21);
			Language.GetValue(this.label2);
			Language.GetValue(this.label4);
			Language.GetValue(this.ckbUseBackground);
			Language.GetValue(this.ckbVideo);
			Language.GetValue(this.label7);
			Language.GetValue(this.label22);
			Language.GetValue(this.label5);
			Language.GetValue(this.label6);
			Language.GetValue(this.ckbTag);
			Language.GetValue(this.label10);
			Language.GetValue(this.label13);
			Language.GetValue(this.label12);
			Language.GetValue(this.rbUidBanBe);
			Language.GetValue(this.rbUidTuNhap);
			Language.GetValue(this.lbUid);
			Language.GetValue(this.label11);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x002081A4 File Offset: 0x002063A4
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUW1GbFYwbDVUVVF3UFE9PQ==")))))))), 1);
				this.nudSoLuongTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxOa1p6MDk=")))))))), 1);
				this.nudKhoangCachFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxoU0ZwYVZucFdkVlZVU2tkaGJVWkdWMjVzYVUxcVFUaz0=")))))))), 5);
				this.nudKhoangCachTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxoU0ZwYVZucFdkVlZVU2tkaGJVWkhWVzVaUFE9PQ==")))))))), 10);
				this.ckbVanBan.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXblJTYmxaU1lsVmFNUT09")))))))), false);
				this.ckbUseBackground.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhoU1lsVmFjVmxVU210bFYwbDZWbTVXWVZGVU1Eaz0=")))))))), false);
				this.txtNoiDung.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVblJQV0VKVFUwWmFNVmR1WXpsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.ckbAnh.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVnpnOQ==")))))))), false);
				this.ckbVideo.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXblJpUjNSaFZucG5PUT09")))))))), false);
				this.nudSoLuongAnhFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkdWMjVzYVUxcVFUaz0=")))))))), 1);
				this.nudSoLuongAnhTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkhWVzVaUFE9PQ==")))))))), 1);
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
				bool flag2 = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRXYmtKaFVteEtiMWR1WXpsUVVUMDk=")))))))), 0) == 0;
				if (flag2)
				{
					this.rbUidBanBe.Checked = true;
				}
				else
				{
					this.rbUidTuNhap.Checked = true;
				}
				this.ckbTag.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hTYlRROQ==")))))))), false);
				this.txtUidTag.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXbGhpUjNSWFVqQmFkUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.nudUidFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXbGhpUjNSVFltdHdNbGxzUlRsUVVUMDk=")))))))), 1);
				this.nudUidTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXbGhpUjNSWFVucG5PUT09")))))))), 1);
			}
			catch (Exception ex)
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00208C48 File Offset: 0x00206E48
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
				bool flag2 = this.ckbAnh.Checked && !Directory.Exists(this.txtPathAnh.Text.Trim());
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSXpUbEJTZW1SMVZucFdkVk5WWkZWaFNGWjRaRWhXU2xRd1l6Smlla2t4WWpCc1NHUkhPVE5PTVVveFYyNXNRMDFFVW1sa1ZsSnBZVlZKZDA1SFNuaGhSMFpVVWxRd1BRPT0="))))))))), 3);
				}
				else
				{
					bool flag3 = this.ckbVideo.Checked && !Directory.Exists(this.txtPathVideo.Text.Trim());
					if (flag3)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSXpUbEJTZW1SMVZucFdkVk5WWkZWaFNGWjRaRWhXU2xOR2NIZFhhMlJYWkd0c1NHUkhPVE5PTVVveFYyNXNRMDFFVW1sa1ZsSnBZVlZKZDA1SFNuaGhSMFpVVWxRd1BRPT0="))))))))), 3);
					}
					else
					{
						JSON_Settings json_Settings = new JSON_Settings();
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUW1GbFYwbDVUVVF3UFE9PQ==")))))))), this.nudSoLuongFrom.Value);
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxOa1p6MDk=")))))))), this.nudSoLuongTo.Value);
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxoU0ZwYVZucFdkVlZVU2tkaGJVWkdWMjVzYVUxcVFUaz0=")))))))), this.nudKhoangCachFrom.Value);
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxoU0ZwYVZucFdkVlZVU2tkaGJVWkhWVzVaUFE9PQ==")))))))), this.nudKhoangCachTo.Value);
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXblJTYmxaU1lsVmFNUT09")))))))), this.ckbVanBan.Checked);
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhoU1lsVmFjVmxVU210bFYwbDZWbTVXWVZGVU1Eaz0=")))))))), this.ckbUseBackground.Checked);
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVnpnOQ==")))))))), this.ckbAnh.Checked);
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXblJpUjNSaFZucG5PUT09")))))))), this.ckbVideo.Checked);
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkdWMjVzYVUxcVFUaz0=")))))))), this.nudSoLuongAnhFrom.Value);
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkhWVzVaUFE9PQ==")))))))), this.nudSoLuongAnhTo.Value);
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
						bool checked2 = this.rbUidBanBe.Checked;
						if (checked2)
						{
							json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRXYmtKaFVteEtiMWR1WXpsUVVUMDk=")))))))), 0);
						}
						else
						{
							bool checked3 = this.rbUidTuNhap.Checked;
							if (checked3)
							{
								json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRXYmtKaFVteEtiMWR1WXpsUVVUMDk=")))))))), 1);
							}
						}
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hTYlRROQ==")))))))), this.ckbTag.Checked);
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXbGhpUjNSWFVqQmFkUT09")))))))), this.txtUidTag.Text.Trim());
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXbGhpUjNSVFltdHdNbGxzUlRsUVVUMDk=")))))))), this.nudUidFrom.Value);
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXbGhpUjNSWFVucG5PUT09")))))))), this.nudUidTo.Value);
						string fullString = json_Settings.GetFullString();
						bool flag4 = this.type == 0;
						if (flag4)
						{
							bool flag5 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOa1IxSnFWSHBDTmxOVldqRlRWV2hUWWpOak1tTklVa3BTTW1odlpXdHNRMlJYUmtSU1JWWnlXVEE0ZDJWcmRFOWtWbkExVVc1U05HTlZhRTVhTVdSeVRIYzlQUT09")))))))))) == DialogResult.Yes;
							if (flag5)
							{
								bool flag6 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
								if (flag6)
								{
									fHDDangStatus.isSave = true;
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
							bool flag7 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOa1IxSnFWSHBDTmxOVldqRlRWV1JSVWtjNWVtVlhjR3BSTUVveFdWVXhVR0ZZY0V4VWFrSktVakpvYjJWcmJFTmtWMFpFVWtWV2Nsa3dPSGRsYTNSUFpGWndOazlFTUQwPQ==")))))))))) == DialogResult.Yes;
							if (flag7)
							{
								bool flag8 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
								if (flag8)
								{
									fHDDangStatus.isSave = true;
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
			}
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00209914 File Offset: 0x00207B14
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

		// Token: 0x06000B0C RID: 2828 RVA: 0x002099D8 File Offset: 0x00207BD8
		private void CheckedChangeFull()
		{
			this.ckbVanBan_CheckedChanged(null, null);
			this.ckbAnh_CheckedChanged(null, null);
			this.ckbVideo_CheckedChanged(null, null);
			this.ckbTag_CheckedChanged(null, null);
			this.rbUidTuNhap_CheckedChanged(null, null);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00209A2C File Offset: 0x00207C2C
		private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plVanBan.Enabled = this.ckbVanBan.Checked;
			bool flag = !this.ckbVanBan.Checked;
			if (flag)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00209A90 File Offset: 0x00207C90
		private void ckbAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbAnh.Checked;
			bool @checked = this.ckbAnh.Checked;
			if (@checked)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00209AEC File Offset: 0x00207CEC
		private void ckbVideo_CheckedChanged(object sender, EventArgs e)
		{
			this.plVideo.Enabled = this.ckbVideo.Checked;
			bool @checked = this.ckbVideo.Checked;
			if (@checked)
			{
				this.ckbUseBackground.Checked = false;
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00209B48 File Offset: 0x00207D48
		private void txtNoiDung_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00209B64 File Offset: 0x00207D64
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

		// Token: 0x06000B12 RID: 2834 RVA: 0x00209CCC File Offset: 0x00207ECC
		private void UpdateSoLuongUid()
		{
			try
			{
				List<string> list = new List<string>();
				bool @checked = this.rbNganCachMoiDong.Checked;
				if (@checked)
				{
					list = this.txtUidTag.Lines.ToList<string>();
				}
				else
				{
					list = this.txtUidTag.Text.Split(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VVRJMU0xTjNQVDA9"))))))))
					}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				}
				list = Common.RemoveEmptyItems(list);
				this.lbUid.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5BelRtdGFjVmxWVGtOV2JVWllWVmRrVEZOSVRqTmFiRTV5VG1jOVBRPT0="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00209E34 File Offset: 0x00208034
		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.txtPathAnh.Text = Common.SelectFolder();
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00209E58 File Offset: 0x00208058
		private void metroButton2_Click(object sender, EventArgs e)
		{
			this.txtPathVideo.Text = Common.SelectFolder();
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00209E7C File Offset: 0x0020807C
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00209EF0 File Offset: 0x002080F0
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 325;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00209F14 File Offset: 0x00208114
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 276;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00209B48 File Offset: 0x00207D48
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00209B48 File Offset: 0x00207D48
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbUseBackground_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00209F38 File Offset: 0x00208138
		private void ckbTag_CheckedChanged(object sender, EventArgs e)
		{
			this.plTag.Enabled = this.ckbTag.Checked;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00209F68 File Offset: 0x00208168
		private void txtUid_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongUid();
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00069C18 File Offset: 0x00067E18
		private void lbUid_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00069C18 File Offset: 0x00067E18
		private void label11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00209F84 File Offset: 0x00208184
		private void rbUidTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.plUidTuNhap.Enabled = this.rbUidTuNhap.Checked;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00069C18 File Offset: 0x00067E18
		private void txtPathAnh_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00209FB4 File Offset: 0x002081B4
		private void button2_Click_1(object sender, EventArgs e)
		{
			string s = string.Concat(new string[]
			{
				Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHVnJiRWxWYlRnd1dXNVdSVk5WWkZWU1NGWllUbGMxVUZwNk1Eaz0="))))))))),
				Environment.NewLine,
				Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaT1ExbHNjSFZXYms1cFVtcHNNVmRXWTNoaVJtaFVVa1ZXY2xwVll6TmFNMnhEVFVkR1NGSnFWa3BUUmtwMlRrZEtlRXd3YkVoaGJXZ3hUa1JDYmxwRk1WQmpWMHB3VVcxdk1GbHVWblZYVms1RFRVaGpNbEZ1UWtwU00xSjJXV2wwU0U1dE9IbE9SMmM5"))))))))),
				Environment.NewLine,
				Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaT1ExbHRTblJTYmxKaFZtcENibVZGY0VsaFNGVXdWRmRrYTFJeWFHOWFWazVEVFVkR1VGSjZXakpsVlVsM1pIcGFkMlJWYkVoVlIyZ3hUbTFTYjFOVmFGVlNSemxJWVRKa2FFMXRhREpPUjBwNFlXMUtjRkpVTUQwPQ==")))))))))
			});
			MessageBoxHelper.ShowMessageBox(s, 1);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0020A0EC File Offset: 0x002082EC
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NqQk9SMG94VjBkR1ZGRnRkRE5PTUhBeFYyNXNRMk16WXpKUlYyUk9WVEJLTVU1SFNqRlhiVVpVVVcxMGExWjZWblZUVmtVNVVGRTlQUT09"))))))))), 1);
			this.txtNoiDung.Focus();
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0020A160 File Offset: 0x00208360
		private void button3_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHelpNhapComment());
			this.txtNoiDung.Focus();
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x000A530C File Offset: 0x000A350C
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x040010A3 RID: 4259
		private JSON_Settings setting;

		// Token: 0x040010A4 RID: 4260
		private string id_KichBan;

		// Token: 0x040010A5 RID: 4261
		private string id_TuongTac;

		// Token: 0x040010A6 RID: 4262
		private string Id_HanhDong;

		// Token: 0x040010A7 RID: 4263
		private int type;

		// Token: 0x040010A8 RID: 4264
		public static bool isSave;
	}
}
