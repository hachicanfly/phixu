﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.KichBan;
using MCommon;

namespace maxcare
{
	// Token: 0x020000B2 RID: 178
	public partial class fHDHuyLikePage : Form
	{
		// Token: 0x060006AC RID: 1708 RVA: 0x000DA88C File Offset: 0x000D8A8C
		public fHDHuyLikePage(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDHuyLikePage.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxTlhVbGxpUlRGb1ZqTlNjMVpWWkVkaWJIQlNVRlF3UFE9PQ=="))))))))).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1HeDBUVmRvYUZaNlVuQlVSMnhMVmxkU1dFOVlWbUZOVkd4V1YxWmtUbUZWYkVSYU1teFhVakZhTVZacmFGZGtiVXAwV2taV1dsWXdNWEJVUlU1Q1lWWlNXRTlXVmxwVk1HeDNVMVZhWVZGc1VrZFdhMXBXWlZWR2RsTnFRbTlTVms1SlZtcFdWVkl5ZUhsWGJGcERZVVp2ZVZaWE5VMVJNRVoxVlRBNVNFNHpRWHBoTW1ScFVqSjRlVmRzVGtOa01XeFlXa2Q0UzJWWGN6TT0=")))))))));
			}
			string jsonStringOrPathFile = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxTlhVbGxpUlRGb1ZqTlNjMVpWWkVkaWJIQlNVRlF3UFE9PQ==")))))))));
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

		// Token: 0x060006AD RID: 1709 RVA: 0x000DAD14 File Offset: 0x000D8F14
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
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000DADCC File Offset: 0x000D8FCC
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudSoLuongFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUW1GbFYwbDVUVVF3UFE9PQ==")))))))), 1);
				this.nudSoLuongTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxOa1p6MDk=")))))))), 3);
				this.nudDelayFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), 3);
				this.nudDelayTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), 5);
			}
			catch
			{
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000DAFD0 File Offset: 0x000D91D0
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
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUW1GbFYwbDVUVVF3UFE9PQ==")))))))), this.nudSoLuongFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxOa1p6MDk=")))))))), this.nudSoLuongTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), this.nudDelayFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), this.nudDelayTo.Value);
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
							fHDHuyLikePage.isSave = true;
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
							fHDHuyLikePage.isSave = true;
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

		// Token: 0x060006B1 RID: 1713 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000DB44C File Offset: 0x000D964C
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

		// Token: 0x040006CD RID: 1741
		private JSON_Settings setting;

		// Token: 0x040006CE RID: 1742
		private string id_KichBan;

		// Token: 0x040006CF RID: 1743
		private string id_TuongTac;

		// Token: 0x040006D0 RID: 1744
		private string Id_HanhDong;

		// Token: 0x040006D1 RID: 1745
		private int type;

		// Token: 0x040006D2 RID: 1746
		public static bool isSave;
	}
}
