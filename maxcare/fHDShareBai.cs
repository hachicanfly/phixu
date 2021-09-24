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
	// Token: 0x020000C6 RID: 198
	public partial class fHDShareBai : Form
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x0012FA70 File Offset: 0x0012DC70
		public fHDShareBai(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDShareBai.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string text = base.Name.Substring(1);
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSS2IyRkhUblJXVjJSYVl6QTVibGxXUlRsUVVUMDk="))))))));
			bool flag = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), text).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1HeDBUVmRvYUZaNlVuQlVSMnhMVmxkU1dFOVlWbUZOVkd4V1YxWmtUbUZWYkVSYU1teFhVakZhTVZacmFGZGtiVXAwV2taV1dsWXdNWEJVUlU1TFZHMUplRlZ0YUVwaFYzUnVWbTEwUjFSV1dsWldiRkpLVVRKa2RRPT0=")))))))),
					text,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xb3djRE5RVkRBOQ==")))))))),
					@string,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NrNTNQVDA9"))))))))
				}));
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

		// Token: 0x060007D5 RID: 2005 RVA: 0x0012FF7C File Offset: 0x0012E17C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label15);
			Language.GetValue(this.label20);
			Language.GetValue(this.label19);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.ckbShareBaiLenTuong);
			Language.GetValue(this.ckbShareBaiLenNhom);
			Language.GetValue(this.label26);
			Language.GetValue(this.label24);
			Language.GetValue(this.label25);
			Language.GetValue(this.ckbOnlyShareNhomKhongKiemDuyet);
			Language.GetValue(this.ckbShareBaiLenPage);
			Language.GetValue(this.label21);
			Language.GetValue(this.label23);
			Language.GetValue(this.label22);
			Language.GetValue(this.label2);
			Language.GetValue(this.ckbVanBan);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
			Language.GetValue(this.rbNganCachMoiDong);
			Language.GetValue(this.rbNganCachKyTu);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00130124 File Offset: 0x0012E324
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudDelayFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), 3);
				this.nudDelayTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), 5);
				this.ckbShareBaiLenTuong.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFSRmRXWkhOVVZuQllUbFpXYTFaNmJERlhibU01VUZFOVBRPT0=")))))))), false);
				this.ckbShareBaiLenNhom.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFSRmRXWkhOVVZuQllUbFU1YUZKNmJEQT0=")))))))), false);
				this.nudCountGroupFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtTVmt5TURWTlYwNUdWMjVzYVUxcVFUaz0=")))))))), 1);
				this.nudCountGroupTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtTVmt5TURWTlYwNUhWVzVaUFE9PQ==")))))))), 1);
				int valueInt = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRVYlRsYVYwVndjdz09")))))))), 0);
				bool flag = valueInt == 0;
				if (flag)
				{
					this.rbRandom.Checked = true;
				}
				else
				{
					this.rbTuNhap.Checked = true;
				}
				this.lstNhomTuNhap = this.setting.GetValueList(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0b1QwMUdVblJoU0ZwcFZteEplRlpITVc5aFIwNUNVRlF3UFE9PQ==")))))))), 0);
				this.ckbCauHinhNangCao.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxTYWtaVVVqSjRNVmxWVlRGaFIwcDBXa1ZTV2xaNlp6az0=")))))))), false);
				this.ckbOnlyShareNhomKhongKiemDuyet.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVWGxPV0U1c1ZtczFkbGRXYUV0aVJsSjBZVWhhYVZaWVVuWlpha2t4WW14TmVXSkhlR2xXVmtsNFdsWmtWMDFCUFQwPQ==")))))))), false);
				this.ckbUuTienNhomNhieuThanhVien.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxXYkZab1ZqRmFNVlpITVc5a2JVcFdUbGM1YUZZeFdYaFdhMlJ2WVVkS2RHRkdaR2hXTVZveA==")))))))), false);
				this.ckbKhongShareTrung.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNWVmxWWkVkbFZuQlhWVzVzYTFaNlZuVT0=")))))))), false);
				this.ckbTuongTac.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU1UVVUMDk=")))))))), false);
				this.nudTuongTacFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBUMWhSUFE9PQ==")))))))), 3);
				this.nudTuongTacTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5V1Ywb3pVRlF3UFE9PQ==")))))))), 5);
				this.nudTuongTacDelayFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1ZuQllaVWRvYkZaV2NEVlpha2wzVUZFOVBRPT0=")))))))), 5);
				this.nudTuongTacDelayTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1ZuQllaVWRvYkZac1NqST0=")))))))), 7);
				this.ckbTuongTacLike.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VVYwWllaRWQzUFE9PQ==")))))))), false);
				this.ckbTuongTacComment.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U1IwbDVUVmhTWVZaNlZYYz0=")))))))), false);
				this.txtComment.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSWGxQV0ZKcFZqRmFNVnBGUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.ckbShareBaiLenPage.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFSRmRXWkhOVVZuQllUbFpHV2xZeVVuTT0=")))))))), false);
				this.nudCountPageFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtVbGRXWkd0aVJrcDFVMjVhYVZWVU1Eaz0=")))))))), 1);
				this.nudCountPageTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtVbGRXWkd0aVJscElUMFF3UFE9PQ==")))))))), 1);
				this.txtLinkChiaSe.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1RVVTFkbGxXWkVkV1JuQlNVRlF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.rbShareThuong.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFMxWkhSa2hTYm14aFZteEtkbHBHWXpWa1ZuQXpVRlF3UFE9PQ==")))))))), true);
				this.rbShareVip.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFMxWkhSa2hTYm14aFZteHdkMWt3UlRsUVVUMDk=")))))))), false);
				this.ckbKhongPhaiLinkFacebook.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNVbGxWWkVkalJsSklZa2hXYUUxR2NHOVhWRXBYWVZkSmVVOVlTVDA9")))))))), false);
				this.ckbVanBan.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXblJTYmxaU1lsVmFNUT09")))))))), false);
				this.txtNoiDung.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVblJQV0VKVFUwWmFNVmR1WXpsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				bool flag2 = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpPVnpWYVZucFdSVmRXWkU5aWR6MDk=")))))))), 0) == 1;
				if (flag2)
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

		// Token: 0x060007D7 RID: 2007 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00130F48 File Offset: 0x0012F148
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
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFSRmRXWkhOVVZuQllUbFpXYTFaNmJERlhibU01VUZFOVBRPT0=")))))))), this.ckbShareBaiLenTuong.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFSRmRXWkhOVVZuQllUbFU1YUZKNmJEQT0=")))))))), this.ckbShareBaiLenNhom.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtTVmt5TURWTlYwNUdWMjVzYVUxcVFUaz0=")))))))), this.nudCountGroupFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtTVmt5TURWTlYwNUhWVzVaUFE9PQ==")))))))), this.nudCountGroupTo.Value);
				int num = 0;
				bool @checked = this.rbTuNhap.Checked;
				if (@checked)
				{
					num = 1;
				}
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRVYlRsYVYwVndjdz09")))))))), num);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0b1QwMUdVblJoU0ZwcFZteEplRlpITVc5aFIwNUNVRlF3UFE9PQ==")))))))), this.lstNhomTuNhap);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxTYWtaVVVqSjRNVmxWVlRGaFIwcDBXa1ZTV2xaNlp6az0=")))))))), this.ckbCauHinhNangCao.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVWGxPV0U1c1ZtczFkbGRXYUV0aVJsSjBZVWhhYVZaWVVuWlpha2t4WW14TmVXSkhlR2xXVmtsNFdsWmtWMDFCUFQwPQ==")))))))), this.ckbOnlyShareNhomKhongKiemDuyet.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxXYkZab1ZqRmFNVlpITVc5a2JVcFdUbGM1YUZZeFdYaFdhMlJ2WVVkS2RHRkdaR2hXTVZveA==")))))))), this.ckbUuTienNhomNhieuThanhVien.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNWVmxWWkVkbFZuQlhWVzVzYTFaNlZuVT0=")))))))), this.ckbKhongShareTrung.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU1UVVUMDk=")))))))), this.ckbTuongTac.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBUMWhSUFE9PQ==")))))))), this.nudTuongTacFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5V1Ywb3pVRlF3UFE9PQ==")))))))), this.nudTuongTacFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1ZuQllaVWRvYkZaV2NEVlpha2wzVUZFOVBRPT0=")))))))), this.nudTuongTacDelayFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1ZuQllaVWRvYkZac1NqST0=")))))))), this.nudTuongTacDelayTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VVYwWllaRWQzUFE9PQ==")))))))), this.ckbTuongTacLike.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U1IwbDVUVmhTWVZaNlZYYz0=")))))))), this.ckbTuongTacComment.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSWGxQV0ZKcFZqRmFNVnBGUlRsUVVUMDk=")))))))), this.txtComment.Text);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFSRmRXWkhOVVZuQllUbFpHV2xZeVVuTT0=")))))))), this.ckbShareBaiLenPage.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtVbGRXWkd0aVJrcDFVMjVhYVZWVU1Eaz0=")))))))), this.nudCountPageFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtVbGRXWkd0aVJscElUMFF3UFE9PQ==")))))))), this.nudCountPageTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1RVVTFkbGxXWkVkV1JuQlNVRlF3UFE9PQ==")))))))), this.txtLinkChiaSe.Text.Trim());
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFMxWkhSa2hTYm14aFZteEtkbHBHWXpWa1ZuQXpVRlF3UFE9PQ==")))))))), this.rbShareThuong.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFMxWkhSa2hTYm14aFZteHdkMWt3UlRsUVVUMDk=")))))))), this.rbShareVip.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNVbGxWWkVkalJsSklZa2hXYUUxR2NHOVhWRXBYWVZkSmVVOVlTVDA9")))))))), this.ckbKhongPhaiLinkFacebook.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXblJTYmxaU1lsVmFNUT09")))))))), this.ckbVanBan.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVblJQV0VKVFUwWmFNVmR1WXpsUVVUMDk=")))))))), this.txtNoiDung.Text.Trim());
				int num2 = 0;
				bool checked2 = this.rbNganCachKyTu.Checked;
				if (checked2)
				{
					num2 = 1;
				}
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpPVnpWYVZucFdSVmRXWkU5aWR6MDk=")))))))), num2);
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
							fHDShareBai.isSave = true;
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
							fHDShareBai.isSave = true;
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

		// Token: 0x060007D9 RID: 2009 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00131DC0 File Offset: 0x0012FFC0
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

		// Token: 0x060007DB RID: 2011 RVA: 0x00131E84 File Offset: 0x00130084
		private void CheckedChangeFull()
		{
			this.rbMfb_CheckedChanged(null, null);
			this.rbWww_CheckedChanged(null, null);
			this.ckbShareBaiLenTuong_CheckedChanged(null, null);
			this.ckbDangBaiLenNhom_CheckedChanged(null, null);
			this.ckbDangBaiLenPage_CheckedChanged(null, null);
			this.ckbVanBan_CheckedChanged(null, null);
			this.rbShareThuong_CheckedChanged(null, null);
			this.rbShareVip_CheckedChanged(null, null);
			this.ckbTuongTac_CheckedChanged(null, null);
			this.ckbTuongTacComment_CheckedChanged(null, null);
			this.rbTuNhap_CheckedChanged(null, null);
			this.ckbCauHinhNangCao_CheckedChanged(null, null);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00131F3C File Offset: 0x0013013C
		private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plVanBan.Enabled = this.ckbVanBan.Checked;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00131F6C File Offset: 0x0013016C
		private void txtNoiDung_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00131F88 File Offset: 0x00130188
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

		// Token: 0x060007DF RID: 2015 RVA: 0x001320F0 File Offset: 0x001302F0
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00132164 File Offset: 0x00130364
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 216;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00132188 File Offset: 0x00130388
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plVanBan.Height = 169;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x001321AC File Offset: 0x001303AC
		private void ckbDangBaiLenNhom_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenNhom.Enabled = this.ckbShareBaiLenNhom.Checked;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x001321DC File Offset: 0x001303DC
		private void ckbDangBaiLenPage_CheckedChanged(object sender, EventArgs e)
		{
			this.plDangBaiLenPage.Enabled = this.ckbShareBaiLenPage.Checked;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0013220C File Offset: 0x0013040C
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NqQk9SMG94VjBkR1ZGRnRkRE5PTUhBeFYyNXNRMk16WXpKUlYyUk9WVEJLTVU1SFNqRlhiVVpVVVcxMGExWjZWblZUVmtVNVVGRTlQUT09"))))))))), 1);
			this.txtNoiDung.Focus();
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00132280 File Offset: 0x00130480
		private void button3_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHelpNhapComment());
			this.txtNoiDung.Focus();
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00131F6C File Offset: 0x0013016C
		private void rbNganCachMoiDong_CheckedChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00131F6C File Offset: 0x0013016C
		private void rbNganCachKyTu_CheckedChanged_1(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbShareBaiLenTuong_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00069C18 File Offset: 0x00067E18
		private void rbMfb_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00069C18 File Offset: 0x00067E18
		private void rbWww_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x001322AC File Offset: 0x001304AC
		private void txtLinkChiaSe_TextChanged(object sender, EventArgs e)
		{
			List<string> list = this.txtLinkChiaSe.Lines.ToList<string>();
			list = Common.RemoveEmptyItems(list);
			this.label2.Text = string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MyUlhSalZSYld3elRtdEtkMU5WWkZGaFNGWjRXa2hXU2xORk5YWlhWbWhMWWtWc1JHRkVaRTVUUkVKM1ZESmpPVkJSUFQwPQ==")))))))), list.Count);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00132340 File Offset: 0x00130540
		private void rbShareVip_CheckedChanged(object sender, EventArgs e)
		{
			this.ckbKhongPhaiLinkFacebook.Enabled = !this.rbShareVip.Checked;
			bool @checked = this.rbShareVip.Checked;
			if (@checked)
			{
				this.ckbKhongPhaiLinkFacebook.Checked = false;
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbKhongPhaiLinkFacebook_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00069C18 File Offset: 0x00067E18
		private void rbShareThuong_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x001323A4 File Offset: 0x001305A4
		private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
		{
			this.plInteractGroup.Enabled = this.ckbTuongTac.Checked;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00069C18 File Offset: 0x00067E18
		private void btnComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x001323D4 File Offset: 0x001305D4
		private void ckbTuongTacComment_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.ckbTuongTacComment.Checked;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00132404 File Offset: 0x00130604
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			list = this.txtComment.Lines.ToList<string>();
			list = Common.RemoveEmptyItems(list);
			this.lblComment.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1XdDVUMWhTYVZZeFdqRmFSVTVDWWpKV05sRnFiRXhXUnpnNQ=="))))))))), list.Count.ToString());
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x000A530C File Offset: 0x000A350C
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x001324A4 File Offset: 0x001306A4
		private void button6_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHVnJiRWxWYlRnd1dXNVdSVk5WWkZWU1NGWllUbGMxU2xKdVVYaFhSazVGVWxkMGJGSjZaRzVsVlVsM1dWVmtSMDVWYkVsVmJUZ3dXVzVGZGxOVmFGVlNTRVowVGtka1drc3dZek5qUkVwR1dqSktkRnByWkhwVU1HTXpZbXhrY2xveVNuUmhiV2d4WTFSR01WTlZhRk5qUjBwd1VXNVdhRlF3WXpKamFra3dZVUU5UFE9PQ=="))))))))), 1);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000A530C File Offset: 0x000A350C
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x001324A4 File Offset: 0x001306A4
		private void button7_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHVnJiRWxWYlRnd1dXNVdSVk5WWkZWU1NGWllUbGMxU2xKdVVYaFhSazVGVWxkMGJGSjZaRzVsVlVsM1dWVmtSMDVWYkVsVmJUZ3dXVzVGZGxOVmFGVlNTRVowVGtka1drc3dZek5qUkVwR1dqSktkRnByWkhwVU1HTXpZbXhrY2xveVNuUmhiV2d4WTFSR01WTlZhRk5qUjBwd1VXNVdhRlF3WXpKamFra3dZVUU5UFE9PQ=="))))))))), 1);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00132508 File Offset: 0x00130708
		private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
		{
			this.button8.Enabled = this.rbTuNhap.Checked;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00132538 File Offset: 0x00130738
		private void ckbCauHinhNangCao_CheckedChanged(object sender, EventArgs e)
		{
			this.panel4.Enabled = this.ckbCauHinhNangCao.Checked;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00132568 File Offset: 0x00130768
		private void button8_Click(object sender, EventArgs e)
		{
			string text = Guid.NewGuid().ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMVUwNUhVa0pRVkRBOQ=="))))))));
			Common.ShowForm(new fNhapDuLieu1(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVTJ4S1JGRnVWbWhTZVRsT1dqRmpkMUJSUFQwPQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1VNVdWVmRrYVdKWGFESmxhMnhIWkVFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ==")))))))), this.lstNhomTuNhap));
			this.lstNhomTuNhap = File.ReadAllLines(text).ToList<string>();
			try
			{
				File.Delete(text);
			}
			catch
			{
			}
		}

		// Token: 0x040009ED RID: 2541
		private JSON_Settings setting;

		// Token: 0x040009EE RID: 2542
		private string id_KichBan;

		// Token: 0x040009EF RID: 2543
		private string id_TuongTac;

		// Token: 0x040009F0 RID: 2544
		private string Id_HanhDong;

		// Token: 0x040009F1 RID: 2545
		private int type;

		// Token: 0x040009F2 RID: 2546
		public static bool isSave;

		// Token: 0x040009F3 RID: 2547
		private List<string> lstNhomTuNhap = new List<string>();
	}
}
