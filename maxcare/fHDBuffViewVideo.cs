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
	// Token: 0x020000AE RID: 174
	public partial class fHDBuffViewVideo : Form
	{
		// Token: 0x0600067D RID: 1661 RVA: 0x000CDA70 File Offset: 0x000CBC70
		public fHDBuffViewVideo(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBuffViewVideo.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxRXlVbGhYYlRGWFlsZDRjMXBFUm1GalJuQklWbTVaUFE9PQ=="))))))))).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1HeDBUVmRvYUZaNlVuQlVSMnhMVmxkU1dFOVlWbUZOVkd4V1YxWmtUbUZWYkVSYU1teFhVakZhTVZacmFGZGtiVXAwV2taV1dsWXdNWEJVUlU1Q1lWWlNXRTlXVmxwVk1HeDNVMVZhWVZGc1VrZFdhMXBXWlZWR2RsTnFRbTlTVmtaMVZtMHhZV0pHY0hkWGJHaHJWakpHV0ZWdGVHbGxWMDU2VTFWT2ExRXlVbGhYYlRGS1VteHdkMWRzYUdwYU1WcDBZa2QwWVZaNmFIVlRNVko2VUZFOVBRPT0=")))))))));
			}
			string jsonStringOrPathFile = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxRXlVbGhYYlRGWFlsZDRjMXBFUm1GalJuQklWbTVaUFE9PQ==")))))))));
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

		// Token: 0x0600067E RID: 1662 RVA: 0x000CDEF8 File Offset: 0x000CC0F8
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.label5);
			Language.GetValue(this.label7);
			Language.GetValue(this.label6);
			Language.GetValue(this.label2);
			Language.GetValue(this.label10);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000CDFA0 File Offset: 0x000CC1A0
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.nudTimeFrom.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZsWndOVmxxU1hkUVVUMDk=")))))))), 30);
				this.nudTimeTo.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZteEtNZz09")))))))), 30);
				this.txtUid.Text = this.setting.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXbGhpUjNNOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			catch
			{
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x000CE170 File Offset: 0x000CC370
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
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV1JUWVVkS2RGb3laR3BOYTJoT1dqRmtUMkl3YkVkV2JrSmhVVEJLY1ZkWFRqVlJhMnhJVGxjNU0wNXJjREZUVmtVNVVGRTlQUT09"))))))))), 3);
				}
				else
				{
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZsWndOVmxxU1hkUVVUMDk=")))))))), this.nudTimeFrom.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hpU0ZKaFZteEtNZz09")))))))), this.nudTimeTo.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXbGhpUjNNOQ==")))))))), this.txtUid.Text.Trim());
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
								fHDBuffViewVideo.isSave = true;
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
								fHDBuffViewVideo.isSave = true;
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

		// Token: 0x06000682 RID: 1666 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000CE618 File Offset: 0x000CC818
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

		// Token: 0x06000684 RID: 1668 RVA: 0x000CE6DC File Offset: 0x000CC8DC
		private void txtIdPost_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtUid.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.label2.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNXRklWbmhOV0dSS1VqRktiMWx0TVc1YU1rMDBWREpvV2sxdFpHNVZNVlpTV2pGYWRHSkhkR0ZXZW1odVV6Qm9lbVF5V2xSaGVsazk="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x04000651 RID: 1617
		private JSON_Settings setting;

		// Token: 0x04000652 RID: 1618
		private string id_KichBan;

		// Token: 0x04000653 RID: 1619
		private string id_TuongTac;

		// Token: 0x04000654 RID: 1620
		private string Id_HanhDong;

		// Token: 0x04000655 RID: 1621
		private int type;

		// Token: 0x04000656 RID: 1622
		public static bool isSave;
	}
}
