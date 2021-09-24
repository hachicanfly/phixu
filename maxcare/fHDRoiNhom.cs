using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ConversionBack;
using maxcare.Helper;
using maxcare.KichBan;
using MCommon;
using Newtonsoft.Json.Linq;

namespace maxcare
{
	// Token: 0x02000110 RID: 272
	public partial class fHDRoiNhom : Form
	{
		// Token: 0x06000BC7 RID: 3015 RVA: 0x0023B59C File Offset: 0x0023979C
		public fHDRoiNhom(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDRoiNhom.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag = type == 0;
			if (flag)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxVXlTWGxpUlRsb1VucHNNQT09")))))))));
				text = tuongTac.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS1IwMVdUa2hpU0Zab1VWUXdPUT09"))))))))].ToString();
				this.id_TuongTac = tuongTac.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNXa2xXYmxwcFlsZFNWbGRXWkU1UVVUMDk="))))))))].ToString();
				this.txtTenHanhDong.Text = Language.GetValue(tuongTac.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaak5WWldiRkpRVkRBOQ=="))))))))].ToString());
			}
			else
			{
				bool flag2 = type == 1;
				if (flag2)
				{
					DataTable hanhDongById = InteractSQL.GetHanhDongById(id_HanhDong);
					text = hanhDongById.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS1IwMVdUa2hpU0Zab1VWUXdPUT09"))))))))].ToString();
					this.btnAdd.Text = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHRlljRXhVYm1SS1VucFdkbVI2V2sxVVZ6aDZWVlF3UFE9PQ==")))))))));
					this.txtTenHanhDong.Text = hanhDongById.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUa2hTYmxab1VsWktNbGx0TVdwUVVUMDk="))))))))].ToString();
				}
			}
			this.setting = JObject.Parse(text);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0023B930 File Offset: 0x00239B30
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
			Language.GetValue(this.label9);
			Language.GetValue(this.rbNgauNhien);
			Language.GetValue(this.rbNhomKiemDuyet);
			Language.GetValue(this.rbRoiTheoDieuKien);
			Language.GetValue(this.ckbDieuKienThanhVien);
			Language.GetValue(this.ckbDieuKienTuKhoa);
			Language.GetValue(this.lblStatusUid);
			Language.GetValue(this.label10);
			Language.GetValue(this.label8);
			Language.GetValue(this.label12);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0023BA94 File Offset: 0x00239C94
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			object[] parameters = new object[]
			{
				this,
				sender,
				e
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(4760640, 2912, 2359, parameters);
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0023BAFC File Offset: 0x00239CFC
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
				bool @checked = this.rbRoiTheoDieuKien.Checked;
				if (@checked)
				{
					bool flag2 = !this.ckbDieuKienThanhVien.Checked && !this.ckbDieuKienTuKhoa.Checked && !this.ckbDieuKienID.Checked;
					if (flag2)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOaGJVWklUREF4ZGsxcVVtNVpWMDQxVVcxU1JGRnVWbWhVVlRsd1pXdHNSMDFGYkVoTk1GSXdWRmhzY1ZwRlRrVlNWM1JZWW10U2VHTXpiRUphUms1RFkyMUdhbFF6UmpaVE1EVXhVMVZvVFZJeU9XcGxWVVpvVlRCS01WbFZZM1pVVjJSWVRVZG5QUT09"))))))))), 3);
						return;
					}
					bool checked2 = this.ckbDieuKienTuKhoa.Checked;
					if (checked2)
					{
						List<string> list = this.txtTuKhoa.Lines.ToList<string>();
						list = Common.RemoveEmptyItems(list);
						bool flag3 = list.Count == 0;
						if (flag3)
						{
							MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV1JUWVVkS2RGb3laR3BOYTJoT1dqRmtUMkl3YkVsV1JXUjZWRmhzUWxOVlpEQmlNa2swWlZWS1dsVXdWVGs9"))))))))), 3);
							return;
						}
					}
					else
					{
						bool checked3 = this.ckbDieuKienID.Checked;
						if (checked3)
						{
							List<string> list2 = this.txtIdNhomRoi.Lines.ToList<string>();
							list2 = Common.RemoveEmptyItems(list2);
							bool flag4 = list2.Count == 0;
							if (flag4)
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOa1YwWk9WREpzTmxNd05UTlRWV1JUWVVkS2RGb3laR3BOYTJoT1dqRmtUMkl3YkVoT1Z6a3pUakExTUZOVlpGRmhTRlo0V2toV1NsTkZlRzlrVkZWNFkwVnNVbEJVTUQwPQ=="))))))))), 3);
								return;
							}
						}
					}
				}
				JSON_Settings json_Settings = new JSON_Settings();
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUW1GbFYwbDVUVVF3UFE9PQ==")))))))), this.nudSoLuongFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUmxOa1p6MDk=")))))))), this.nudSoLuongTo.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRTRmt5TURWa1FUMDk=")))))))), this.nudDelayFrom.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWbGx1WXpsUVVUMDk=")))))))), this.nudDelayTo.Value);
				bool checked4 = this.rbNgauNhien.Checked;
				if (checked4)
				{
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRUYmxwb1ZsUldkbGxxU1hkUVVUMDk=")))))))), 0);
				}
				else
				{
					bool checked5 = this.rbNhomKiemDuyet.Checked;
					if (checked5)
					{
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRUYmxwb1ZsUldkbGxxU1hkUVVUMDk=")))))))), 1);
					}
					else
					{
						json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRUYmxwb1ZsUldkbGxxU1hkUVVUMDk=")))))))), 2);
					}
				}
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hpUjNoclZsaFNkMWRzWXpGV1YwWklVbTVXYUZKc2NIZFhiR013VUZFOVBRPT0=")))))))), this.ckbDieuKienThanhVien.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFlsZG9XRmxXWkZka1ZscElUMWhDVTFJd1ZUaz0=")))))))), this.nudThanhVienToiDa.Value);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hpUjNoclZsaFNkMWRzWXpGV1YxSldaRWM1YVUxclZUaz0=")))))))), this.ckbDieuKienTuKhoa.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdXa2xXYTNob1VucHNidz09")))))))), this.txtTuKhoa.Text.Trim());
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdUbFpWYXpsb1VucHNNRlZxU25OTlZsSklVbTVCUFE9PQ==")))))))), this.txtIDNhomGiuLai.Text);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTa2hpUjNoclZsaFNkMWRzWXpGVGJFcENVRlF3UFE9PQ==")))))))), this.ckbDieuKienID.Checked);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdUbGhWYXpsb1VucHNNRlpYTURWalFUMDk=")))))))), this.txtIdNhomRoi.Text.Trim());
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
							fHDRoiNhom.isSave = true;
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
							fHDRoiNhom.isSave = true;
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

		// Token: 0x06000BCC RID: 3020 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0023C580 File Offset: 0x0023A780
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

		// Token: 0x06000BCE RID: 3022 RVA: 0x0023C644 File Offset: 0x0023A844
		private void rbUidChiDinh_CheckedChanged(object sender, EventArgs e)
		{
			this.CheckTypeDoiTuong();
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0023C660 File Offset: 0x0023A860
		private void CheckTypeDoiTuong()
		{
			this.plUidChiDinh.Enabled = this.rbRoiTheoDieuKien.Checked;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0023C690 File Offset: 0x0023A890
		private void txtComment_TextChanged_1(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtTuKhoa.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.lblStatusUid.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5BelRtdGFjVmxWVGtOTlNHaDVVa1V4YmxFd1NubFpWV04yVkZka1dGSlhaRXhUU0U0eldteE9jazVuUFQwPQ=="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0023C754 File Offset: 0x0023A954
		private void CheckedChangedFull()
		{
			this.ckbThanhVienToiDa_CheckedChanged(null, null);
			this.ckbDieuKienTuKhoa_CheckedChanged(null, null);
			this.CheckTypeDoiTuong();
			this.txtIdNhomRoi_TextChanged(null, null);
			this.ckbDieuKienID_CheckedChanged(null, null);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0023C7A8 File Offset: 0x0023A9A8
		private void ckbThanhVienToiDa_CheckedChanged(object sender, EventArgs e)
		{
			this.nudThanhVienToiDa.Enabled = this.ckbDieuKienThanhVien.Checked;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0023C7D8 File Offset: 0x0023A9D8
		private void ckbDieuKienTuKhoa_CheckedChanged(object sender, EventArgs e)
		{
			this.plDieuKienTuKhoa.Enabled = this.ckbDieuKienTuKhoa.Checked;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00069C18 File Offset: 0x00067E18
		private void label8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0023C808 File Offset: 0x0023AA08
		private void txtUidKhongHuyKetBan_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtIDNhomGiuLai.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.label8.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5BelRtdGFjVmxWVGtOVGJFcEVVVzVXYUZSVk9UWlpiRTVEWVdwU2FXTlhOV2xoVlVwMVdWZFdTRTR6U2pWUmJrMHdXVzVHYjFsV1RrSmlNbFkyVVdwc1RGWkhPRGs9"))))))))), list.Count);
			}
			catch
			{
			}
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00069C18 File Offset: 0x00067E18
		private void label12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0023C8C8 File Offset: 0x0023AAC8
		private void txtIdNhomRoi_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<string> list = this.txtIdNhomRoi.Lines.ToList<string>();
				list = Common.RemoveEmptyItems(list);
				this.label11.Text = string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5BelRtdGFjVmxWVGtOVGJFcEVVVzVXYUZSVk9UWlpiRTVDWWpKV05sRnFiRXhXUnpnNQ=="))))))))), list.Count.ToString());
			}
			catch
			{
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0023C98C File Offset: 0x0023AB8C
		private void ckbDieuKienID_CheckedChanged(object sender, EventArgs e)
		{
			this.panel2.Enabled = this.ckbDieuKienID.Checked;
		}

		// Token: 0x0400127F RID: 4735
		private JObject setting;

		// Token: 0x04001280 RID: 4736
		private string id_KichBan;

		// Token: 0x04001281 RID: 4737
		private string id_TuongTac;

		// Token: 0x04001282 RID: 4738
		private string Id_HanhDong;

		// Token: 0x04001283 RID: 4739
		private int type;

		// Token: 0x04001284 RID: 4740
		public static bool isSave;
	}
}
