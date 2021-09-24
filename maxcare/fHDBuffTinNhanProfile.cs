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
	// Token: 0x02000104 RID: 260
	public partial class fHDBuffTinNhanProfile : Form
	{
		// Token: 0x06000AC2 RID: 2754 RVA: 0x001F5EF0 File Offset: 0x001F40F0
		public fHDBuffTinNhanProfile(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBuffTinNhanProfile.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxRXlVbGhYYlRGWFVqSjRNVlpITVc5aFIwcHpVVzVzYVUxc2NIZFphMlJXVUZFOVBRPT0="))))))))).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1HeDBUVmRvYUZaNlVuQlVSMnhMVmxkU1dFOVlWbUZOVkd4V1YxWmtUbUZWYkVSYU1teFhVakZhTVZacmFGZGtiVXAwV2taV1dsWXdNWEJVUlU1Q1lWWkZlVkpxUmxSU01uZ3hXVlZPU21Nd2JFUlRhelZwVFZaS2IxTlhiSEphTVZweVVtc3hWMVpXV2xWVFZVNXVZbXhPUmxWclRtdFdNWEIwVm10a2MyUldVblJoUjJocFlrVktOVmxxU21GalIwcElWbGMxVFZFd1JuVmFXR3hDV2pCc2RFNVVSbUZTYXpVeVZrVm9WMlJ0U25SYVJscG9WakZLU0ZreU1EVmtSV3h4WWpKa1NtRnJWbkJVUlU1Q1dqQnNkRTVVUm1GU2F6VXlWa1ZvVjJSdFNuUmFSbHBvVmpGS1ZsbHViRXBPYTJ4RVUxaHdTbUZZWkc1VFZ6QXhUVlp3UjFSdVdsVlRSbG95V1cweGExRnRTblJoUldScVlsUnNNRk5YY0haYU1HeHhVbGRzVFZFd1JuQlpiVFZYWVRGVmVVOVZNV3RXZW13eFYycENSMlJYUmtkVmJscEtZVzA1YmxOWGNFWmhWWGhFVVZka1NtSlVWWGhYYTFaVFlrZEtTRkpxVmxOaWEzQXlXV3hPU2s1cmJFUlRXSEJLWVZoa2JsTlZUa3RrVjFKWVZXdFdZVll6YUc5YVZscFRaR3RzY1dJeVpFcGhiRlp3VkVWT1Fsb3diSFZWYWxKclVteGFkMWRyVGtwT2EyeEVVMWRzVFZFd1JtNVRWekZQWTJ4c2NrNVhPVnBXZWxaV1dWWmpNVll4YkZoT1ZVNWFWbnBTY0ZReWJFSmhWbHBKVTJwR1lWVXdiSHBUVlU1Q1lWZFNTV0ZFUWxWaVZHeDNWV3RvVjJSV2NEVlRWRnBLVVRCd2RsZHNaRFJqTWtvMVUxaE9TbEV3Um5CWFZFb3dZVlpWZVZadVZtRlNWVm94V1ZWT1NrNXJiRVJUYTJSYVZqTm9ObGRzVGtwak1HeEVVVmRzYTFOSFozZFZWbU14WWpCc2NXSXlaRXBoVld4NlUxVk9RbUZXYTNsa1IyeFhVMFphUmxscVNURmliR1JJVDFkb1YxWXllSEpUVjNCMldqQnNjbGR0YUdsVFJUVnpVMWMwZDJKcmVFUlJWelZTWW14YWRGZHRiRU5XVjBaWVRrZGthV0pYY0c5a1dFVTFaRlZzUjFGdWJHbE5iSEIzV1d0a1ZtSnJkRlZqZWpBOQ==")))))))));
			}
			string jsonStringOrPathFile = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxRXlVbGhYYlRGWFVqSjRNVlpITVc5aFIwcHpVVzVzYVUxc2NIZFphMlJXVUZFOVBRPT0=")))))))));
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

		// Token: 0x06000AC3 RID: 2755 RVA: 0x001F6378 File Offset: 0x001F4578
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label49);
			Language.GetValue(this.label66);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.lblStatusUid);
			Language.GetValue(this.label2);
			Language.GetValue(this.ckbTuDongXoaUid);
			Language.GetValue(this.ckbNhanTinVanBan);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.ckbSendAnh);
			Language.GetValue(this.label10);
			Language.GetValue(this.label3);
			Language.GetValue(this.label9);
			Language.GetValue(this.label4);
			Language.GetValue(this.ckbTuongTacKhiNhanTin);
			Language.GetValue(this.label15);
			Language.GetValue(this.rbTuongTacTruocKhiNhanTin);
			Language.GetValue(this.rbTuongTacSauKhiNhanTin);
			Language.GetValue(this.label16);
			Language.GetValue(this.label14);
			Language.GetValue(this.label12);
			Language.GetValue(this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong);
			Language.GetValue(this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x001F6574 File Offset: 0x001F4774
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongUidFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxkalJuQkdWMjVzYVUxcVFUaz0=")))))))), 1);
				this.nudSoLuongUidTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxkalJuQkhWVzVaUFE9PQ==")))))))), 3);
				this.nudSoLuongAnhFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkdWMjVzYVUxcVFUaz0=")))))))), 1);
				this.nudSoLuongAnhTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkhWVzVaUFE9PQ==")))))))), 1);
				this.nudDelayFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), 3);
				this.nudDelayTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), 5);
				this.txtUid.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXbGhpUjNNOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.ckbAddFriend.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVFltdHdkMWRzWXpGaGR6MDk=")))))))), false);
				this.ckbNhanTinVanBan.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJoUjJocFlrWktkMWx0ZUdGaFIwcHlVMjFvYVZwNk1Eaz0=")))))))), false);
				this.txtNoiDung.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVblJQV0VKVFUwWmFNVmR1WXpsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.ckbSendAnh.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxXYmxaaFVsVmFNVmxWUlRsUVVUMDk=")))))))), false);
				this.txtAnh.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGhPVnpnOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.ckbTuongTacKhiNhanTin.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VVIwWklZa1U1YUZJd1dqRldhMlJ6WkZFOVBRPT0=")))))))), false);
				bool flag = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRWYWtacFRXcFdkVlpyWkVkaGJFMTVZVWhDVldKWGFHOVpiWGhUWTBkS2JsQlVNRDA9")))))))), 0) == 0;
				if (flag)
				{
					this.rbTuongTacTruocKhiNhanTin.Checked = true;
				}
				else
				{
					this.rbTuongTacSauKhiNhanTin.Checked = true;
				}
				this.ckbTuongTacKhiNhanTinLike.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VVIwWklZa1U1YUZJd1dqRldhMlJ6WkZaU1NHSklTbUZWVkRBNQ==")))))))), false);
				this.ckbTuongTacKhiNhanTinComment.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VVIwWklZa1U1YUZJd1dqRldhMlJ6WkZaRmVVOVlVbWxXTVZveFdrVkZPVkJSUFQwPQ==")))))))), false);
				this.txtTuongTacKhiNhanTinComment.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXa2xXYmxwcFlsZFNWbGRXWkU5VVIwWklZa1U1YUZJd1dqRldhMlJ6WkZaRmVVOVlVbWxXTVZveFdrVkZPVkJSUFQwPQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				bool flag2 = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpPVnpWYVZucFdSVmRXWkU5aU1VVjVUMWhTYVZZeFdqRmFSVVU1VUZFOVBRPT0=")))))))), 0) == 1;
				if (flag2)
				{
					this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked = true;
				}
				else
				{
					this.ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Checked = true;
				}
				this.ckbTuDongXoaUid.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYTFacFRXcFdkVll3WXpWaFJscFlZa2R6UFE9PQ==")))))))), false);
				bool flag3 = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpPVnpWYVZucFdSVmRXWkU5aWR6MDk=")))))))), 0) == 1;
				if (flag3)
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

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x001F6FC8 File Offset: 0x001F51C8
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
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV1JUWVVkS2RGb3laR3BOYTJoT1dqRmtUMkl3YkVkV2JrSmhVVEJWT1E9PQ=="))))))))), 3);
				}
				else
				{
					bool @checked = this.ckbNhanTinVanBan.Checked;
					if (@checked)
					{
						list = this.txtNoiDung.Lines.ToList<string>();
						list = Common.RemoveEmptyItems(list);
						bool flag3 = list.Count == 0;
						if (flag3)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV016VWtoU1RtVlhjR2hWTUVweVdrWmpNV0pyYkVsVmJrSnBZVlZLTVZsVk9VaE9ia2w1VGtkblBRPT0="))))))))), 3);
							return;
						}
					}
					bool checked2 = this.ckbSendAnh.Checked;
					if (checked2)
					{
						bool flag4 = this.txtAnh.Text.Trim().Length == 0;
						if (flag4)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOaGJVWlFVbnBrY1ZaNlVtNVhiVEExWXpGd1NGWnViRXBVTUdNeVlucEpNV0l3YkZKUVZEQTk="))))))))), 3);
							return;
						}
					}
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxkalJuQkdWMjVzYVUxcVFUaz0=")))))))), this.nudSoLuongUidFrom.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxkalJuQkhWVzVaUFE9PQ==")))))))), this.nudSoLuongUidTo.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkdWMjVzYVUxcVFUaz0=")))))))), this.nudSoLuongAnhFrom.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkhWVzVaUFE9PQ==")))))))), this.nudSoLuongAnhTo.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), this.nudDelayFrom.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), this.nudDelayTo.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXbGhpUjNNOQ==")))))))), this.txtUid.Text.Trim());
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhWYlhSVFltdHdkMWRzWXpGaGR6MDk=")))))))), this.ckbAddFriend.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJoUjJocFlrWktkMWx0ZUdGaFIwcHlVMjFvYVZwNk1Eaz0=")))))))), this.ckbNhanTinVanBan.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVblJQV0VKVFUwWmFNVmR1WXpsUVVUMDk=")))))))), this.txtNoiDung.Text.Trim());
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxXYmxaaFVsVmFNVmxWUlRsUVVUMDk=")))))))), this.ckbSendAnh.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGhPVnpnOQ==")))))))), this.txtAnh.Text.Trim());
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYTFacFRXcFdkVll3WXpWaFJscFlZa2R6UFE9PQ==")))))))), this.ckbTuDongXoaUid.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VVIwWklZa1U1YUZJd1dqRldhMlJ6WkZFOVBRPT0=")))))))), this.ckbTuongTacKhiNhanTin.Checked);
					bool checked3 = this.rbTuongTacTruocKhiNhanTin.Checked;
					if (checked3)
					{
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRWYWtacFRXcFdkVlpyWkVkaGJFMTVZVWhDVldKWGFHOVpiWGhUWTBkS2JsQlVNRDA9")))))))), 0);
					}
					else
					{
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRWYWtacFRXcFdkVlpyWkVkaGJFMTVZVWhDVldKWGFHOVpiWGhUWTBkS2JsQlVNRDA9")))))))), 1);
					}
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VVIwWklZa1U1YUZJd1dqRldhMlJ6WkZaU1NHSklTbUZWVkRBNQ==")))))))), this.ckbTuongTacKhiNhanTinLike.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VVIwWklZa1U1YUZJd1dqRldhMlJ6WkZaRmVVOVlVbWxXTVZveFdrVkZPVkJSUFQwPQ==")))))))), this.ckbTuongTacKhiNhanTinComment.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXa2xXYmxwcFlsZFNWbGRXWkU5VVIwWklZa1U1YUZJd1dqRldhMlJ6WkZaRmVVOVlVbWxXTVZveFdrVkZPVkJSUFQwPQ==")))))))), this.txtTuongTacKhiNhanTinComment.Text.Trim());
					int num = 0;
					bool checked4 = this.ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked;
					if (checked4)
					{
						num = 1;
					}
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpPVnpWYVZucFdSVmRXWkU5aU1VVjVUMWhTYVZZeFdqRmFSVVU1VUZFOVBRPT0=")))))))), num);
					int num2 = 0;
					bool checked5 = this.rbNganCachKyTu.Checked;
					if (checked5)
					{
						num2 = 1;
					}
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpPVnpWYVZucFdSVmRXWkU5aWR6MDk=")))))))), num2);
					string fullString = json_Settings.GetFullString();
					bool flag5 = this.type == 0;
					if (flag5)
					{
						bool flag6 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOa1IxSnFWSHBDTmxOVldqRlRWV2hUWWpOak1tTklVa3BTTW1odlpXdHNRMlJYUmtSU1JWWnlXVEE0ZDJWcmRFOWtWbkExVVc1U05HTlZhRTVhTVdSeVRIYzlQUT09")))))))))) == DialogResult.Yes;
						if (flag6)
						{
							bool flag7 = InteractSQL.InsertHanhDong(this.id_KichBan, text, this.id_TuongTac, fullString);
							if (flag7)
							{
								fHDBuffTinNhanProfile.isSave = true;
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
						bool flag8 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFNWUlhPSGxPUjJSYVRXazVUbG94VGtOa1IxSnFWSHBDTmxOVldqRlRWV1JSVWtjNWVtVlhjR3BSTUVveFdWVXhVR0ZZY0V4VWFrSktVakpvYjJWcmJFTmtWMFpFVWtWV2Nsa3dPSGRsYTNSUFpGWndOazlFTUQwPQ==")))))))))) == DialogResult.Yes;
						if (flag8)
						{
							bool flag9 = InteractSQL.UpdateHanhDong(this.Id_HanhDong, text, fullString);
							if (flag9)
							{
								fHDBuffTinNhanProfile.isSave = true;
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

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x001F7CC8 File Offset: 0x001F5EC8
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

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00069C18 File Offset: 0x00067E18
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x001F7D8C File Offset: 0x001F5F8C
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x001F7DA8 File Offset: 0x001F5FA8
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
				this.lblStatus.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtoV1NFNHlNVmhoTW1SaFUwWmFNVmR1YkVOTlIwWllUa2RrYVdKWGNHOWtXRVUxWkZWc1JHRkVaRTVUUkVKM1ZESmpPVkJSUFQwPQ=="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x001F7F10 File Offset: 0x001F6110
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.ckbTuongTacTruocKhiNhanTin_CheckedChanged(null, null);
			this.ckbTuongTacTruocKhiNhanTinComment_CheckedChanged(null, null);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x001F7F58 File Offset: 0x001F6158
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbNhanTinVanBan.Checked;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x001F7F88 File Offset: 0x001F6188
		private void txtUid_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.lblStatusUid.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1WcFlZa2QwU2xJd05XOWxhMnhHV2pKS2RHRnJVblppVkZKdVYxTjBTRTV1UVhsT1IyUnBZbGR3YjJSWVJUVmtWV3hKVlc1Q2FXRlZSblphV0hCRFQxVjBWV0o2TUQwPQ=="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x001F804C File Offset: 0x001F624C
		private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbSendAnh.Checked;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x001F807C File Offset: 0x001F627C
		private void button2_Click(object sender, EventArgs e)
		{
			this.txtAnh.Text = Common.SelectFolder();
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x001F80A0 File Offset: 0x001F62A0
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 235;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x001F80C4 File Offset: 0x001F62C4
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.plComment.Height = 185;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x001F7D8C File Offset: 0x001F5F8C
		private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x001F7D8C File Offset: 0x001F5F8C
		private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
		{
			this.UpdateSoLuongBinhLuan();
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x001F80E8 File Offset: 0x001F62E8
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				this.btnUp.Visible = true;
				this.btnDown.Visible = true;
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x001F815C File Offset: 0x001F635C
		private void ckbTuongTacTruocKhiNhanTin_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacTruocKhiNhanTin.Enabled = this.ckbTuongTacKhiNhanTin.Checked;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x001F818C File Offset: 0x001F638C
		private void ckbTuongTacTruocKhiNhanTinComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacTruocKhiNhanTinComment.Enabled = this.ckbTuongTacKhiNhanTinComment.Checked;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x001F81BC File Offset: 0x001F63BC
		private void button2_Click_1(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NqQk9SMG94VjBkR1ZGRnRkRE5PTUhBeFYyNXNRMk16WXpKUlYyUk9WVEJLTVU1SFNqRlhiVVpVVVcxMGExWjZWblZUVmtVNVVGRTlQUT09"))))))))), 1);
			this.txtTuongTacKhiNhanTinComment.Focus();
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x001F8230 File Offset: 0x001F6430
		private void button3_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHelpNhapComment());
			this.txtTuongTacKhiNhanTinComment.Focus();
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0010CAFC File Offset: 0x0010ACFC
		private void button4_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHVnJiRWxWYlRnd1dXNVdSVk5WWkZWU1NGWllUbGMxU2xKdVVYaFhSazVGVWxkMGJGSjZaRzVsVlVsM1dWVmtSMDVWYkVsVmJUZ3dXVzVGZGxOVmFGVlNTRVowVGtka1drc3dZek5qUkVwR1dqRmFWbUpGVmtwVlZEQTU=")))))))), 1);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x000A530C File Offset: 0x000A350C
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Common.ShowForm(new fHuongDanRandom());
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x001F825C File Offset: 0x001F645C
		private void button6_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NqQk9SMG94VjBkR1ZGRnRkRE5PTUhBeFYyNXNRMk16WXpKUlYyUk9WVEJLTVU1SFNqRlhiVVpVVVcxMGExWjZWblZUVmtVNVVGRTlQUT09"))))))))), 1);
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x001F82C0 File Offset: 0x001F64C0
		private void button5_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHelpNhapComment());
		}

		// Token: 0x04001013 RID: 4115
		private JSON_Settings setting;

		// Token: 0x04001014 RID: 4116
		private string id_KichBan;

		// Token: 0x04001015 RID: 4117
		private string id_TuongTac;

		// Token: 0x04001016 RID: 4118
		private string Id_HanhDong;

		// Token: 0x04001017 RID: 4119
		private int type;

		// Token: 0x04001018 RID: 4120
		public static bool isSave;
	}
}
