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
	// Token: 0x020000FF RID: 255
	public partial class fHDTuongTacBanBe : Form
	{
		// Token: 0x06000A68 RID: 2664 RVA: 0x001DA72C File Offset: 0x001D892C
		public fHDTuongTacBanBe(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDTuongTacBanBe.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxWlhVbGhQV0ZaaFRWWktiMWRVUWt0aFIwcHlVMjEzUFE9PQ=="))))))))).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1HeDBUVmRvYUZaNlVuQlVSMnhMVmxkU1dFOVlWbUZOVkd4V1YxWmtUbUZWYkVSYU1teFhVakZhTVZacmFGZGtiVXAwV2taV1dsWXdNWEJVUlU1Q1lWWlNXRTlXVmxwVk1HeDNVMVZhWVZGc1VrZFdhMXBXWlZWR2RsTnFRbTlTVmxwSlZtNWFhV0pYVWxaWFZtUlBVVEZzV0U1VlRtRlZNazU2VTFWT2ExWllhSGxTUldSMlZucFdkVk5WYUZWU1J6bFlWRmRrVW1SVll6SmlNV013V2pGc2VsUXlPVXRsVjNNeg==")))))))));
			}
			string jsonStringOrPathFile = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxWlhVbGhQV0ZaaFRWWktiMWRVUWt0aFIwcHlVMjEzUFE9PQ==")))))))));
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

		// Token: 0x06000A69 RID: 2665 RVA: 0x001DABB8 File Offset: 0x001D8DB8
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label49);
			Language.GetValue(this.label66);
			Language.GetValue(this.label68);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.label21);
			Language.GetValue(this.label16);
			Language.GetValue(this.label18);
			Language.GetValue(this.label20);
			Language.GetValue(this.label15);
			Language.GetValue(this.label17);
			Language.GetValue(this.label10);
			Language.GetValue(this.label2);
			Language.GetValue(this.label12);
			Language.GetValue(this.label11);
			Language.GetValue(this.label14);
			Language.GetValue(this.label13);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.button2);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x001DAD50 File Offset: 0x001D8F50
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongBanBeFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWt0aFIwcHlVMjE0VTJKcmNESlpiRVU1VUZFOVBRPT0=")))))))), 1);
				this.nudSoLuongBanBeTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWt0aFIwcHlVMjE0VjFKNlp6az0=")))))))), 3);
				this.nudTimeFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZsWndOVmxxU1hkUVVUMDk=")))))))), 10);
				this.nudTimeTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZteEtNZz09")))))))), 30);
				this.nudDelayFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), 1);
				this.nudDelayTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), 3);
				this.nudCountLikeFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtUbGxXWkRCaVJrcDFVMjVhYVZWVU1Eaz0=")))))))), 1);
				this.nudCountLikeTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtUbGxXWkRCaVJscElUMFF3UFE9PQ==")))))))), 3);
				this.nudCountShareFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtWVmxWWkVkbFZuQldWMjVzYVUxcVFUaz0=")))))))), 1);
				this.nudCountShareTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtWVmxWWkVkbFZuQlhWVzVaUFE9PQ==")))))))), 3);
				this.nudCountCommentFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtSVmxxU1hoa1JuQllUbFJDVTJKcmNESlpiRVU1VUZFOVBRPT0=")))))))), 1);
				this.nudCountCommentTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtSVmxxU1hoa1JuQllUbFJDVjFKNlp6az0=")))))))), 3);
				this.ckbInteract.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUbGhPVkVKaFYwVndiMWRVVGxKUVVUMDk=")))))))), false);
				this.ckbShareWall.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFXVmRXWkRSamR6MDk=")))))))), false);
				this.ckbComment.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxQV0ZKcFZqRmFNVnBGUlRsUVVUMDk=")))))))), false);
				this.ckbCommentText.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxQV0ZKcFZqRmFNVnBGV2xOaVIxWkpWVlF3UFE9PQ==")))))))), false);
				this.txtComment.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSWGxQV0ZKcFZqRmFNVnBGUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.ckbSendAnh.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxXYmxaaFVsVmFNVmxWUlRsUVVUMDk=")))))))), false);
				this.txtAnh.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGhPVnpnOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
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
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x001DB6E8 File Offset: 0x001D98E8
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
				bool @checked = this.ckbComment.Checked;
				if (@checked)
				{
					List<string> list = this.txtComment.Lines.ToList<string>();
					list = Common.RemoveEmptyItems(list);
					bool flag2 = list.Count == 0;
					if (flag2)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV016VWtoU1RtVlhjR2hWTUVweVdrWmpNV0pyYkVoVGJrSTJVMVZLTVZsVlRrTmpNbEpxVkRKc05sTXdOVEZUVmtVNVVGRTlQUT09"))))))))), 3);
						return;
					}
				}
				JSON_Settings json_Settings = new JSON_Settings();
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWt0aFIwcHlVMjE0VTJKcmNESlpiRVU1VUZFOVBRPT0=")))))))), this.nudSoLuongBanBeFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWt0aFIwcHlVMjE0VjFKNlp6az0=")))))))), this.nudSoLuongBanBeTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZsWndOVmxxU1hkUVVUMDk=")))))))), this.nudTimeFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZteEtNZz09")))))))), this.nudTimeTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), this.nudDelayFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), this.nudDelayTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUbGhPVkVKaFYwVndiMWRVVGxKUVVUMDk=")))))))), this.ckbInteract.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoUjJocVlsWmFXVmRXWkRSamR6MDk=")))))))), this.ckbShareWall.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxQV0ZKcFZqRmFNVnBGUlRsUVVUMDk=")))))))), this.ckbComment.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxQV0ZKcFZqRmFNVnBGV2xOaVIxWkpWVlF3UFE9PQ==")))))))), this.ckbCommentText.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSWGxQV0ZKcFZqRmFNVnBGUlRsUVVUMDk=")))))))), this.txtComment.Text.Trim());
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtUbGxXWkRCaVJrcDFVMjVhYVZWVU1Eaz0=")))))))), this.nudCountLikeFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtUbGxXWkRCaVJscElUMFF3UFE9PQ==")))))))), this.nudCountLikeTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtWVmxWWkVkbFZuQldWMjVzYVUxcVFUaz0=")))))))), this.nudCountShareFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtWVmxWWkVkbFZuQlhWVzVaUFE9PQ==")))))))), this.nudCountShareTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtSVmxxU1hoa1JuQllUbFJDVTJKcmNESlpiRVU1VUZFOVBRPT0=")))))))), this.nudCountCommentFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhSWGxQVkVacFlteEtSVmxxU1hoa1JuQllUbFJDVjFKNlp6az0=")))))))), this.nudCountCommentTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxXYmxaaFVsVmFNVmxWUlRsUVVUMDk=")))))))), this.ckbSendAnh.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGhPVnpnOQ==")))))))), this.txtAnh.Text.Trim());
				int num = 0;
				bool checked2 = this.rbNganCachKyTu.Checked;
				if (checked2)
				{
					num = 1;
				}
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpPVnpWYVZucFdSVmRXWkU5aWR6MDk=")))))))), num);
				string fullString = json_Settings.GetFullString();
				bool flag3 = this.type == 0;
				if (flag3)
				{
					bool flag4 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOa1IxSnFWSHBDTmxOVldqRlRWV2hUWWpOak1tTklVa3BTTW1odlpXdHNRMlJYUmtSU1JWWnlXVEE0ZDJWcmRFOWtWbkExVVc1U05HTlZhRTVhTVdSeVRIYzlQUT09")))))))))) == DialogResult.Yes;
					if (flag4)
					{
						bool flag5 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
						if (flag5)
						{
							fHDTuongTacBanBe.isSave = true;
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
					bool flag6 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOa1IxSnFWSHBDTmxOVldqRlRWV1JSVWtjNWVtVlhjR3BSTUVveFdWVXhVR0ZZY0V4VWFrSktVakpvYjJWcmJFTmtWMFpFVWtWV2Nsa3dPSGRsYTNSUFpGWndOazlFTUQwPQ==")))))))))) == DialogResult.Yes;
					if (flag6)
					{
						bool flag7 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
						if (flag7)
						{
							fHDTuongTacBanBe.isSave = true;
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

		// Token: 0x06000A6D RID: 2669 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x001DC238 File Offset: 0x001DA438
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

		// Token: 0x06000A6F RID: 2671 RVA: 0x001DC2FC File Offset: 0x001DA4FC
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x001DC318 File Offset: 0x001DA518
		private void UpdateSoLuongBinhLuan()
		{
			try
			{
				List<string> list = new List<string>();
				bool @checked = this.rbNganCachMoiDong.Checked;
				if (@checked)
				{
					list = this.txtComment.Lines.ToList<string>();
				}
				else
				{
					list = this.txtComment.Text.Split(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VVRJMU0xTjNQVDA9"))))))))
					}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				}
				list = Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtoV1NFNHlNVmhoTW1SaFUwWmFNVmR1YkVOaFdHTXlaVWhXYUZFd1NucGFSMVpJVG01S1dFNUhaRXhUU0U0eldteE9jazVuUFQwPQ=="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x001DC480 File Offset: 0x001DA680
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.ckbShareWall_CheckedChanged(null, null);
			this.ckbCommentText_CheckedChanged(null, null);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x001DC4C8 File Offset: 0x001DA6C8
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbComment.Checked;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x001DC4F8 File Offset: 0x001DA6F8
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 162;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x001DC51C File Offset: 0x001DA71C
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.plCommentText.Height = 210;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x001DC540 File Offset: 0x001DA740
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x001DC2FC File Offset: 0x001DA4FC
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x001DC2FC File Offset: 0x001DA4FC
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x001DC5B4 File Offset: 0x001DA7B4
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
			this.plCountLike.Enabled = this.ckbInteract.Checked;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x001DC5E4 File Offset: 0x001DA7E4
		private void ckbShareWall_CheckedChanged(object sender, EventArgs e)
		{
			this.plCountShareWall.Enabled = this.ckbShareWall.Checked;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x000C98D0 File Offset: 0x000C7AD0
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHVnJiRWxWYlRnd1dXNVdSVk5WWkZWU1NGWllUbGMxU2xKdVVYaFhSazVGVWxkMGJGSjZaRzVsVlVsM1dWVmtSMDVWYkVsVmJUZ3dXVzVGZGxOVmFGVlNTRVowVGtka1drc3dZek5qUkVwR1dqSktkRnByWkhwVU1HTXpZbXhrY2xvemFFdFRSVlp1VFdwV2RWTlZaRTFTUnpsSVlUSm5QUT09"))))))))), 1);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x001DC614 File Offset: 0x001DA814
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NqQk9SMG94VjBkR1ZGRnRkRE5PTUhBeFYyNXNRMk16WXpKUlYyUk9WVEJLTVU1SFNqRlhiVVpVVVcxMGExWjZWblZUVmtVNVVGRTlQUT09"))))))))), 1);
			this.txtComment.Focus();
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x001DC688 File Offset: 0x001DA888
		private void button3_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHelpNhapComment());
			this.txtComment.Focus();
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000A530C File Offset: 0x000A350C
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x001DC6B4 File Offset: 0x001DA8B4
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x001DC6E4 File Offset: 0x001DA8E4
		private void ckbCommentText_CheckedChanged(object sender, EventArgs e)
		{
			this.plCommentText.Enabled = this.ckbCommentText.Checked;
		}

		// Token: 0x04000F10 RID: 3856
		private JSON_Settings setting;

		// Token: 0x04000F11 RID: 3857
		private string id_KichBan;

		// Token: 0x04000F12 RID: 3858
		private string id_TuongTac;

		// Token: 0x04000F13 RID: 3859
		private string Id_HanhDong;

		// Token: 0x04000F14 RID: 3860
		private int type;

		// Token: 0x04000F15 RID: 3861
		public static bool isSave;
	}
}
