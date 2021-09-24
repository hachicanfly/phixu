using System;
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
	// Token: 0x02000108 RID: 264
	public partial class fHDBackupData : Form
	{
		// Token: 0x06000B42 RID: 2882 RVA: 0x00217BB4 File Offset: 0x00215DB4
		public fHDBackupData(string id_KichBan, int type = 0, string id_HanhDong = "")
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fHDBackupData.isSave = false;
			this.id_KichBan = id_KichBan;
			this.Id_HanhDong = id_HanhDong;
			this.type = type;
			bool flag = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxRXhiRmhVYmtwclYwVktSbGRXYUZOaFFUMDk="))))))))).Rows.Count == 0;
			if (flag)
			{
				maxcare.KichBan.Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1HeDBUVmRvYUZaNlVuQlVSMnhMVmxkU1dFOVlWbUZOVkd4V1YxWmtUbUZWYkVSYU1teFhVakZhTVZacmFGZGtiVXAwV2taV1dsWXdNWEJVUlU1Q1lWWkZlVkpxUmxSU01uZ3hXVlZPU21Nd2JFUlRhelZwVFZaS2IxTlhiSEphTVZweVVtc3hWMVpXV2xWVFZVNXVZbXhPUmxWclRscFdNRFY1V2tab1ExSldiRmxWYldoTFpWaGtibE5xVG5wYU1HeEVVMjF3YUUxcmNGQlhha3BIVGxaVmVXSklWbWhSTUdzeVUxVk9TMVpYVG5WV2JYaEtZVmhrYmxOVlRrdGhiVVY1VTJ0S2FXSlhhRVJYVm1NeFVURndWRk5VV2twUk1IQldXVEkxVjJKRmJIQmtNbVJLVVRCd01WcEdaRk5XUjBsM1pVUkdhVTFxVm5WVlZtTXhZakJzY1dJeVpFcGhhMnd6VTFkc00xb3diRVJUYlhCb1RXdHdVRmxWWkVka1ZscElZa2hXU21GdE9XNVRWM2hUWlZkU1dGWlhiRTFSTUVadVUxY3hUMk5zYkhKVGJrSnBZbGRvVGxwR1pFZGtWV3h4WWpKa1NtSkdTalZhUm1SV1lWVjRSRkZYWkVwaVZUVjVWMWQwVDJWV2NGaFNha0poVmxkb1ZsWkdWak5oVlRsd1VWZHNWMU5GYjNoWGJFNUxUMVZ3TldReVpFdE5SWEJ2VjFSS01FMVhUa1JSYlhNd1dXNVdNbE5WWkRSalJGSnBaRlZvYTFVeVRuZFVNMk01VUZFOVBRPT0=")))))))));
			}
			string jsonStringOrPathFile = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag2 = type == 0;
			if (flag2)
			{
				DataTable tuongTac = InteractSQL.GetTuongTac(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV1UxRXhiRmhVYmtwclYwVktSbGRXYUZOaFFUMDk=")))))))));
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

		// Token: 0x06000B43 RID: 2883 RVA: 0x00218040 File Offset: 0x00216240
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.label1);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.ckbNgaySinh);
			Language.GetValue(this.ckbAnhBanBe);
			Language.GetValue(this.label7);
			Language.GetValue(this.label10);
			Language.GetValue(this.ckbBackupImageNangCao);
			Language.GetValue(this.button2);
			Language.GetValue(this.ckbNhanTin);
			Language.GetValue(this.ckbBinhLuan);
			Language.GetValue(this.label4);
			Language.GetValue(this.label2);
			Language.GetValue(this.ckbCreateHTML);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00218160 File Offset: 0x00216360
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			try
			{
				this.ckbNgaySinh.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJhUjJoc1ZtczFkMWx0TVc1UVVUMDk=")))))))), true);
				this.ckbAnhBanBe.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVnpsU1lsVmFNVlZYTVZaUVVUMDk=")))))))), true);
				this.ckbBackupImageNangCao.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJTYlhCb1RURmFNMVV4WTNoaFJtOTVWbXM1V2xaNlZuVlZWRXBIWkdjOVBRPT0=")))))))), false);
				this.nudSoLuongAnh.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkNVRlF3UFE9PQ==")))))))), 20);
				this.nudSoThang.Value = this.setting.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVmxab1VqQmFNVmR1WXpsUVVUMDk=")))))))), 5);
				this.ckbNhanTin.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJoUjJocFlrWktkMWx0WXpsUVVUMDk=")))))))), true);
				this.ckbBinhLuan.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJpU0Zab1VsaG5lRmRXWXpCUVVUMDk=")))))))), true);
				this.ckbCreateHTML.Checked = this.setting.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWHBUYlhoYVYwWktjMVV3V2xOVWJGSkNVRlF3UFE9PQ==")))))))), true);
			}
			catch
			{
			}
			this.CheckedChangeFull();
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00218514 File Offset: 0x00216714
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
				bool flag2 = !this.ckbNgaySinh.Checked && !this.ckbAnhBanBe.Checked && !this.ckbNhanTin.Checked && !this.ckbBinhLuan.Checked;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOaGJVWlFVbnBrY1ZaNlVtNVhVM1JJVG01Q1dWWlhaR2hVVlRsNldXMHhibG94YkhSU2JYQm9UVEZhTTFOV1JUbFFVVDA5"))))))))), 3);
				}
				else
				{
					JSON_Settings json_Settings = new JSON_Settings();
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJhUjJoc1ZtczFkMWx0TVc1UVVUMDk=")))))))), this.ckbNgaySinh.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGhPVnpsU1lsVmFNVlZYTVZaUVVUMDk=")))))))), this.ckbAnhBanBe.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJTYlhCb1RURmFNMVV4WTNoaFJtOTVWbXM1V2xaNlZuVlZWRXBIWkdjOVBRPT0=")))))))), this.ckbBackupImageNangCao.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVlRGclZucHNNVmRxUWtka1YwWkNVRlF3UFE9PQ==")))))))), this.nudSoLuongAnh.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJoUjJocFlrWktkMWx0WXpsUVVUMDk=")))))))), this.ckbNhanTin.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJpU0Zab1VsaG5lRmRXWXpCUVVUMDk=")))))))), this.ckbBinhLuan.Checked);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhWWGxQVmxab1VqQmFNVmR1WXpsUVVUMDk=")))))))), this.nudSoThang.Value);
					json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWHBUYlhoYVYwWktjMVV3V2xOVWJGSkNVRlF3UFE9PQ==")))))))), this.ckbCreateHTML.Checked);
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
								fHDBackupData.isSave = true;
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
								fHDBackupData.isSave = true;
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

		// Token: 0x06000B47 RID: 2887 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00218BD8 File Offset: 0x00216DD8
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

		// Token: 0x06000B49 RID: 2889 RVA: 0x00218C9C File Offset: 0x00216E9C
		private void CheckedChangeFull()
		{
			this.ckbInteract_CheckedChanged(null, null);
			this.ckbComment_CheckedChanged(null, null);
			this.ckbBinhLuan_CheckedChanged(null, null);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00069C18 File Offset: 0x00067E18
		private void ckbInteract_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00218CD4 File Offset: 0x00216ED4
		private void ckbComment_CheckedChanged(object sender, EventArgs e)
		{
			this.plAnh.Enabled = this.ckbAnhBanBe.Checked;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00218D04 File Offset: 0x00216F04
		private void ckbBinhLuan_CheckedChanged(object sender, EventArgs e)
		{
			this.plComment.Enabled = this.ckbBinhLuan.Checked;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00218D34 File Offset: 0x00216F34
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtoV1NFNXVXWHBXVjJSclZGVTVNRmRVU201YU1sSk9WSHBXYkZVd1NuRlpWVGxJVGpKd1dFNUhaR2xqTURsdVdsWk9RMDFIUms1VU0wNUtVMFpDYjJSWVNYZGFNV3gwVW0xd2FFMHhXak5UVlRGVVZXNW9lVkpIYURGT2F6VnhVMVZqTVdJeVJteFNlbVJ1VjBaV2JrNUhTbmhoYlVwMFdqSmtXbVJWWXpKaU1XTXdXakZzZWxReU9VcFNNbkJJWWpGak1HUlJQVDA9"))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9")))))))) + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JXRklWVEZVYmxaaFpWVktNVmRxU25GU1dFWllVbGRrYTJSVll6TmlWRXB5V2pKU2RHSnRhREZPUjFKeFUxVm9WV0ZJVlRGU2JYQktWRlpPVTA1SFNqRlhhMnhJVTIxb1drMXVVWGhaTUU1RFpXcFNhV05VYkVwU01EVjJUa2RLZUdSSFNsUlJiVGswWTFWYU1WTldSVGxRVVQwOQ=="))))))))), 1);
		}

		// Token: 0x04001132 RID: 4402
		private JSON_Settings setting;

		// Token: 0x04001133 RID: 4403
		private string id_KichBan;

		// Token: 0x04001134 RID: 4404
		private string id_TuongTac;

		// Token: 0x04001135 RID: 4405
		private string Id_HanhDong;

		// Token: 0x04001136 RID: 4406
		private int type;

		// Token: 0x04001137 RID: 4407
		public static bool isSave;
	}
}
