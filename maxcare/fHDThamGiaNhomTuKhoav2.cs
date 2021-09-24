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

namespace maxcare
{
	// Token: 0x020000BA RID: 186
	public partial class fHDThamGiaNhomTuKhoav2 : Form
	{
		// Token: 0x06000713 RID: 1811 RVA: 0x000F813C File Offset: 0x000F633C
		public fHDThamGiaNhomTuKhoav2(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDThamGiaNhomTuKhoav2.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxWlhSa2hTYmxKVFRXMTRiMVpITVc5a2JVcFhWV3BHVkUxdGFESlhWbWhhWlZFOVBRPT0="))))))))).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1HeDBUVmRvYUZaNlVuQlVSMnhMVmxkU1dFOVlWbUZOVkd4V1YxWmtUbUZWYkVSYU1teFhVakZhTVZacmFGZGtiVXAwV2taV1dsWXdNWEJVUlU1Q1lWWlNXRTlXVmxwVk1HeDNVMVZhWVZGc1VrZFdhMXBXWlZWR2RsTnFRbTlTVmxwSVlVZG9hVlpYVW5kWFZsVXhZakpKZVUxV1ZtdFdXRkoyV1dwS1IwMXJNWEJaTTA1S1VUSlNWbGxWWkVka1JXeElXa2hDV2xVd1NqRlpWVEZRWlcxS1ZGRnFRbWhTTVZveVUxVm9WV0ZJVlRKak1tUm9UVzF3UldONlNrWmFNbEp4VTFjMVRGWklUVGs9")))))))));
			}
			string jsonStringOrPathFile = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxWlhSa2hTYmxKVFRXMTRiMVpITVc5a2JVcFhWV3BHVkUxdGFESlhWbWhhWlZFOVBRPT0=")))))))));
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

		// Token: 0x06000714 RID: 1812 RVA: 0x000F85C4 File Offset: 0x000F67C4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.label4);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.label8);
			Language.GetValue(this.ckbTuDongTraLoiCauHoi);
			Language.GetValue(this.lblStatusComment);
			Language.GetValue(this.label9);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000F86D4 File Offset: 0x000F68D4
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUW1GbFYwbDVUVVF3UFE9PQ==")))))))), 1);
				this.nudSoLuongTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxOa1p6MDk=")))))))), 3);
				this.nudDelayFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), 2);
				this.nudDelayTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), 4);
				this.txtTuKhoa.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXa2xXYTNob1VucHNidz09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				this.ckbTuDongTraLoiCauHoi.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYTFacFRXcFdkVlpyYUV0aFJsSklUMWhDVWsxcldYaFZNR00xWTBFOVBRPT0=")))))))), false);
				this.txtCauTraLoi.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSWGxTYWtaWFUwVndiMVpGWXpWalFUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000F8AA4 File Offset: 0x000F6CA4
		private void CheckedChangeFull()
		{
			this.ckbTuongTac_CheckedChanged(null, null);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x000F8AC0 File Offset: 0x000F6CC0
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
				List<string> list = this.txtTuKhoa.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV1JUWVVkS2RGb3laR3BQUlRsdlYxUktibG95VWxCU2VtUjRaVlZLZVZsVk1WQmxiR3hVVWxRd1BRPT0="))))))))), 3);
				}
				else
				{
					bool @checked = this.ckbTuDongTraLoiCauHoi.Checked;
					if (@checked)
					{
						list = this.txtCauTraLoi.Lines.ToList<string>();
						list = Common.RemoveEmptyItems(list);
						bool flag3 = list.Count == 0;
						if (flag3)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV1JUWVVkS2RGb3laR3BQUlRsdlYxUktibG94YXpSVU1teHJWVEJKZDFrelZraE9iVGsxVVc1Tk1GbHVWbXRaVms1R1VGRTlQUT09"))))))))), 3);
							return;
						}
					}
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUW1GbFYwbDVUVVF3UFE9PQ==")))))))), this.nudSoLuongFrom.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxOa1p6MDk=")))))))), this.nudSoLuongTo.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), this.nudDelayFrom.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), this.nudDelayTo.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXa2xXYTNob1VucHNidz09")))))))), this.txtTuKhoa.Text.Trim());
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYTFacFRXcFdkVlpyYUV0aFJsSklUMWhDVWsxcldYaFZNR00xWTBFOVBRPT0=")))))))), this.ckbTuDongTraLoiCauHoi.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSWGxTYWtaWFUwVndiMVpGWXpWalFUMDk=")))))))), this.txtCauTraLoi.Text.Trim());
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
								fHDThamGiaNhomTuKhoav2.isSave = true;
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
								fHDThamGiaNhomTuKhoav2.isSave = true;
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

		// Token: 0x06000719 RID: 1817 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000F9198 File Offset: 0x000F7398
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

		// Token: 0x0600071B RID: 1819 RVA: 0x00069C18 File Offset: 0x00067E18
		private void txtComment_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000F925C File Offset: 0x000F745C
		private void txtComment_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtTuKhoa.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.lblStatus.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1sSlFVbnBrZUdWVlNubFpWVEZRWld4c1ZGRlhPV3hsYTBrMVV6RlNkbEJSUFQwPQ=="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000F9320 File Offset: 0x000F7520
		private void txtComment_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtCauTraLoi.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.lblStatusComment.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5BelRtdGFjVmxWVGtOaGJtTXlVMnBHU2xOR1NqVk9SMHA0WVd0c1NHVnRhREZPVkVaM1UxVk9iMDR3TVVsTlNFSlFXbm93T1E9PQ=="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000F93E4 File Offset: 0x000F75E4
		private void ckbTuongTac_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTac.Enabled = this.ckbTuDongTraLoiCauHoi.Checked;
		}

		// Token: 0x040007F1 RID: 2033
		private JSON_Settings setting;

		// Token: 0x040007F2 RID: 2034
		private string id_KichBan;

		// Token: 0x040007F3 RID: 2035
		private string id_TuongTac;

		// Token: 0x040007F4 RID: 2036
		private string Id_HanhDong;

		// Token: 0x040007F5 RID: 2037
		private int type;

		// Token: 0x040007F6 RID: 2038
		public static bool isSave;
	}
}
