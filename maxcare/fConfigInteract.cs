using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x02000131 RID: 305
	public partial class fConfigInteract : Form
	{
		// Token: 0x06000E1A RID: 3610 RVA: 0x002DDB20 File Offset: 0x002DBD20
		public fConfigInteract()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVVZucFZkMWRzYUV0aFJtdDZWVlF3UFE9PQ==")))))))), false);
			this.ChangeLanguage();
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x002DDB9C File Offset: 0x002DBD9C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox4);
			Language.GetValue(this.ckbTuongTacNewsfeed);
			Language.GetValue(this.label1);
			Language.GetValue(this.label64);
			Language.GetValue(this.label65);
			Language.GetValue(this.label24);
			Language.GetValue(this.label25);
			Language.GetValue(this.label29);
			Language.GetValue(this.label8);
			Language.GetValue(this.btnTuongTacNewsfeedComment);
			Language.GetValue(this.ckbTuongTacFriend);
			Language.GetValue(this.label49);
			Language.GetValue(this.label66);
			Language.GetValue(this.label68);
			Language.GetValue(this.label19);
			Language.GetValue(this.label67);
			Language.GetValue(this.label54);
			Language.GetValue(this.label46);
			Language.GetValue(this.label48);
			Language.GetValue(this.label47);
			Language.GetValue(this.label33);
			Language.GetValue(this.btnTuongTacFriendComment);
			Language.GetValue(this.ckbTuongTacFanpage);
			Language.GetValue(this.label91);
			Language.GetValue(this.button7);
			Language.GetValue(this.label56);
			Language.GetValue(this.label86);
			Language.GetValue(this.label87);
			Language.GetValue(this.label58);
			Language.GetValue(this.label57);
			Language.GetValue(this.label85);
			Language.GetValue(this.label60);
			Language.GetValue(this.label62);
			Language.GetValue(this.label61);
			Language.GetValue(this.label59);
			Language.GetValue(this.btnTuongTacFanpageComment);
			Language.GetValue(this.ckbTuongTacGroup);
			Language.GetValue(this.label7);
			Language.GetValue(this.label88);
			Language.GetValue(this.label89);
			Language.GetValue(this.label18);
			Language.GetValue(this.label55);
			Language.GetValue(this.label90);
			Language.GetValue(this.label51);
			Language.GetValue(this.label53);
			Language.GetValue(this.label52);
			Language.GetValue(this.label50);
			Language.GetValue(this.btnTuongTacGroupComment);
			Language.GetValue(this.groupBox5);
			Language.GetValue(this.ckbTuongTacNhanTin);
			Language.GetValue(this.label92);
			Language.GetValue(this.btnInbox);
			Language.GetValue(this.label41);
			Language.GetValue(this.label83);
			Language.GetValue(this.label84);
			Language.GetValue(this.label42);
			Language.GetValue(this.label44);
			Language.GetValue(this.label43);
			Language.GetValue(this.ckbTuongTacChoc);
			Language.GetValue(this.label36);
			Language.GetValue(this.label81);
			Language.GetValue(this.label82);
			Language.GetValue(this.label38);
			Language.GetValue(this.label40);
			Language.GetValue(this.label39);
			Language.GetValue(this.ckbTuongTacCMSN);
			Language.GetValue(this.label11);
			Language.GetValue(this.label79);
			Language.GetValue(this.label80);
			Language.GetValue(this.label35);
			Language.GetValue(this.label45);
			Language.GetValue(this.label37);
			Language.GetValue(this.label28);
			Language.GetValue(this.rbTuongTacCMSNNhanTin);
			Language.GetValue(this.rbTuongTacCMSNDangBai);
			Language.GetValue(this.label10);
			Language.GetValue(this.button2);
			Language.GetValue(this.groupBox8);
			Language.GetValue(this.ckbKetBanTuKhoa);
			Language.GetValue(this.label16);
			Language.GetValue(this.pictureBox2);
			Language.GetValue(this.label3);
			Language.GetValue(this.label69);
			Language.GetValue(this.label70);
			Language.GetValue(this.label9);
			Language.GetValue(this.label15);
			Language.GetValue(this.label14);
			Language.GetValue(this.ckbKetBanGoiY);
			Language.GetValue(this.label2);
			Language.GetValue(this.label71);
			Language.GetValue(this.label72);
			Language.GetValue(this.label4);
			Language.GetValue(this.label6);
			Language.GetValue(this.label5);
			Language.GetValue(this.ckbKetBanTepUid);
			Language.GetValue(this.label17);
			Language.GetValue(this.button8);
			Language.GetValue(this.label20);
			Language.GetValue(this.label73);
			Language.GetValue(this.label74);
			Language.GetValue(this.label21);
			Language.GetValue(this.label23);
			Language.GetValue(this.label22);
			Language.GetValue(this.ckbKetBanTepUidTrungNhau);
			Language.GetValue(this.ckbXacNhanKetBan);
			Language.GetValue(this.label26);
			Language.GetValue(this.label75);
			Language.GetValue(this.label76);
			Language.GetValue(this.label31);
			Language.GetValue(this.label30);
			Language.GetValue(this.groupBox7);
			Language.GetValue(this.label12);
			Language.GetValue(this.button1);
			Language.GetValue(this.label13);
			Language.GetValue(this.label77);
			Language.GetValue(this.label78);
			Language.GetValue(this.label32);
			Language.GetValue(this.label63);
			Language.GetValue(this.label34);
			Language.GetValue(this.ckbThamGiaNhom);
			Language.GetValue(this.ckbThamGiaNhomTrungNhau);
			Language.GetValue(this.ckbThamGiaNhomTraLoiCauHoi);
			Language.GetValue(this.btnThamGiaNhomTraLoiCauHoi);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x002DE408 File Offset: 0x002DC608
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
			this.LoadSetting();
			this.CheckedChangedFull();
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x002DE430 File Offset: 0x002DC630
		private void LoadSetting()
		{
			this.ckbTuongTacNewsfeed.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMFU1VUZFOVBRPT0=")))))))), false);
			this.nudTuongTacNewsfeedSoLuongFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMXBQWkd4U1NWWnVXbWxpVjFKSVdUSXdOV1JCUFQwPQ==")))))))), 1);
			this.nudTuongTacNewsfeedSoLuongTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMXBQWkd4U1NWWnVXbWxpVjFKV1dXNWpPVkJSUFQwPQ==")))))))), 3);
			this.nudTuongTacNewsfeedDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVpUWWtkS1NGSnFWbE5pYTNBeVdXeEZPVkJSUFQwPQ==")))))))), 2);
			this.nudTuongTacNewsfeedDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVpUWWtkS1NGSnFWbGRTZW1jNQ==")))))))), 5);
			this.ckbTuongTacNewsfeedLike.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVkwWTBkRmVWWlVNRDA9")))))))), true);
			this.ckbTuongTacNewsfeedComment.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVpQWkcxS1dFMVhlR2xpYkVVNQ==")))))))), false);
			this.ckbTuongTacFriend.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1JUaz0=")))))))), false);
			this.nudTuongTacFriendSoLuongBanBeFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NsVlpha0kwVFZkSmVVNVhOVkppVlZveFZWY3hWbEJSUFQwPQ==")))))))), 1);
			this.nudTuongTacFriendSoLuongBaiVietFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NsVlpha0kwVFZkSmVVNVhOVkppVlZwM1ZtMHhjMkpIVWtaWGJteHBUV3BCT1E9PQ==")))))))), 1);
			this.nudTuongTacFriendSoLuongBaiVietTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NsVlpha0kwVFZkSmVVNVhOVkppVlZwM1ZtMHhjMkpIVWtkVmJsazk=")))))))), 3);
			this.nudTuongTacFriendDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrWlhiR1EwWVVkV1ZsZHViR2xOYWtFNQ==")))))))), 2);
			this.nudTuongTacFriendDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrWlhiR1EwWVVkV1YxVnVXVDA9")))))))), 5);
			this.ckbTuongTacFriendLike.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrNVpWbVF3WWtFOVBRPT0=")))))))), true);
			this.ckbTuongTacFriendComment.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrVlpha2w0WkVad1dFNVVRVDA9")))))))), true);
			this.ckbTuongTacGroup.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxGVU1Eaz0=")))))))), false);
			this.nudTuongTacGroupSoLuongNhomFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZPV2hTZW13d1ZXMDFTMlJ0U2xKUVZEQTk=")))))))), 1);
			this.nudTuongTacGroupSoLuongNhomTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZPV2hTZW13d1ZtdGpORkJSUFQwPQ==")))))))), 3);
			this.nudTuongTacGroupSoLuongBaiVietFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZUbHBXTW5oWVdWWmtWMDFHU25WVGJscHBWVlF3T1E9PQ==")))))))), 1);
			this.nudTuongTacGroupSoLuongBaiVietTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZUbHBXTW5oWVdWWmtWMDFHV2toUFJEQTk=")))))))), 1);
			this.nudTuongTacGroupDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKV1NuTlphMlJIVGxaS2RWTnVXbWxWVkRBNQ==")))))))), 2);
			this.nudTuongTacGroupDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKV1NuTlphMlJIVGxaYVNFOUVNRDA9")))))))), 5);
			this.ckbTuongTacGroupLike.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKWWFIZFpWRXBXVUZFOVBRPT0=")))))))), true);
			this.ckbTuongTacGroupComment.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKVk5USlpiR040WWtkS2RWVlVNRDA9")))))))), false);
			this.ckbTuongTacFanpage.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTT0=")))))))), false);
			this.nudTuongTacFanpageSoLuongPageFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOVlVwdlYycEtWMUl5VG5SUFdGRTk=")))))))), 1);
			this.nudTuongTacFanpageSoLuongPageTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOVlVwdlYycEtWMVpYU2pOUVZEQTk=")))))))), 1);
			this.nudTuongTacFanpageSoLuongBaiVietFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOUlhCdldWWmFZV05HY0ZsVmEyUnFZbFJzTUE9PQ==")))))))), 2);
			this.nudTuongTacFanpageSoLuongBaiVietTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOUlhCdldWWmFZV05HY0ZsVmJGWnBaSG93T1E9PQ==")))))))), 2);
			this.nudTuongTacFanpageDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTlZhMlJYWXpGc1dXSkZaR3BpVkd3dw==")))))))), 2);
			this.nudTuongTacFanpageDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTlZhMlJYWXpGc1dXSkdWbWxrZWpBNQ==")))))))), 5);
			this.ckbTuongTacFanpageLike.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldSV1J6WTJ4d1VsQlVNRDA9")))))))), true);
			this.ckbTuongTacFanpageComment.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTlZWRWsxWkVkS1dGWnVWbXRSVkRBNQ==")))))))), false);
			this.ckbKetBanTuKhoa.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRuUFE9PQ==")))))))), false);
			this.txtKetBanTuKhoaTuKhoa.Text = this.settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVjFOR1drMVpWV00xWVVFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.nudKetBanTuKhoaSoLuongFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ==")))))))), 1);
			this.nudKetBanTuKhoaSoLuongTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9")))))))), 3);
			this.nudKetBanTuKhoaDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVTFJeFducFhWbWh6VWpKT2RFOVlVVDA9")))))))), 2);
			this.nudKetBanTuKhoaDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVTFJeFducFhWbWh6VmxkS00xQlVNRDA9")))))))), 5);
			this.ckbKetBanGoiY.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlZxU1RWalJtUlNVRlF3UFE9PQ==")))))))), false);
			this.nudKetBanGoiYSoLuongFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUlhWRzVhVlZOR1dqSlpiVEZyVWpKT2RFOVlVVDA9")))))))), 1);
			this.nudKetBanGoiYSoLuongTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUlhWRzVhVlZOR1dqSlpiVEZyVmxkS00xQlVNRDA9")))))))), 3);
			this.nudKetBanGoiYDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUldWVzE0YVZJd1dURlZiVFZMWkcxS1VsQlVNRDA9")))))))), 2);
			this.nudKetBanGoiYDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUldWVzE0YVZJd1dURldhMk0wVUZFOVBRPT0=")))))))), 5);
			this.ckbKetBanTepUid.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2R6UFE9PQ==")))))))), false);
			this.nudKetBanTepUidSoLuongFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ==")))))))), 1);
			this.nudKetBanTepUidSoLuongTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9")))))))), 3);
			this.nudKetBanTepUidDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVTFJeFducFhWbWh6VWpKT2RFOVlVVDA9")))))))), 2);
			this.nudKetBanTepUidDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVTFJeFducFhWbWh6VmxkS00xQlVNRDA9")))))))), 5);
			this.ckbKetBanTepUidTrungNhau.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVjFORmIzaFpiVEZyVkRKR1NGSnFSVDA9")))))))), false);
			this.ckbXacNhanKetBan.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVZwNk1Eaz0=")))))))), false);
			this.nudXacNhanKetBanSoLuongFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdKRk5USldSV2hYWkcxS2RGcEZaR3BpVkd3dw==")))))))), 1);
			this.nudXacNhanKetBanSoLuongTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdKRk5USldSV2hYWkcxS2RGcEdWbWxrZWpBNQ==")))))))), 3);
			this.nudXacNhanKetBanDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdFeFNuTlphMlJIVGxaS2RWTnVXbWxWVkRBNQ==")))))))), 2);
			this.nudXacNhanKetBanDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdFeFNuTlphMlJIVGxaYVNFOUVNRDA9")))))))), 5);
			this.ckbTuongTacNhanTin.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERT0=")))))))), false);
			this.nudTuongTacNhanTinSoLuongFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERldWRWsxVkZkU1dFOVlWbUZOUm5BMVdXcEpkMUJSUFQwPQ==")))))))), 1);
			this.nudTuongTacNhanTinSoLuongTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERldWRWsxVkZkU1dFOVlWbUZOVmtveQ==")))))))), 3);
			this.nudTuongTacNhanTinDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERlZhMlJYWXpGc1dXSkZaR3BpVkd3dw==")))))))), 2);
			this.nudTuongTacNhanTinDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERlZhMlJYWXpGc1dXSkdWbWxrZWpBNQ==")))))))), 5);
			this.ckbTuongTacChoc.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR2UFE9PQ==")))))))), false);
			this.nudTuongTacChocSoLuongFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ==")))))))), 1);
			this.nudTuongTacChocSoLuongTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9")))))))), 3);
			this.nudTuongTacChocSoLuongDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmQxVnRlR2xTTUZreFZXMDFTMlJ0U2xKUVZEQTk=")))))))), 2);
			this.nudTuongTacChocSoLuongDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmQxVnRlR2xTTUZreFZtdGpORkJSUFQwPQ==")))))))), 5);
			this.ckbTuongTacCMSN.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M0UFE9PQ==")))))))), false);
			this.nudTuongTacCMSNSoLuongFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ==")))))))), 1);
			this.nudTuongTacCMSNSoLuongTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9")))))))), 3);
			this.nudTuongTacCMSNDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VTFJeFducFhWbWh6VWpKT2RFOVlVVDA9")))))))), 2);
			this.nudTuongTacCMSNDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VTFJeFducFhWbWh6VmxkS00xQlVNRDA9")))))))), 5);
			bool flag = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10b1YyUnRTblJhUmxaYVZqQTFSVlpHV2s5VU1WcEpZa2hrWVZaVlduRmFSV1J6WkcxS2JsQlVNRDA9")))))))), 0) == 0;
			if (flag)
			{
				this.rbTuongTacCMSNNhanTin.Checked = true;
			}
			else
			{
				this.rbTuongTacCMSNDangBai.Checked = true;
			}
			this.ckbThamGiaNhom.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVVF3UFE9PQ==")))))))), false);
			this.nudThamGiaNhomSoLuongFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpTYVUxSVozaFpha2t4WW14S2RWTnVXbWxWVkRBNQ==")))))))), 1);
			this.nudThamGiaNhomSoLuongTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpTYVUxSVozaFpha2t4WW14YVNFOUVNRDA9")))))))), 3);
			this.nudThamGiaNhomDelayFrom.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlZXWVZZemFHOWFWbFpoWlZkSmVVMUVNRDA9")))))))), 2);
			this.nudThamGiaNhomDelayTo.Value = this.settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlZXWVZZemFHOWFWbHBUWkdjOVBRPT0=")))))))), 5);
			this.ckbThamGiaNhomTraLoiCauHoi.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpXYW1KVldrNVpha3B6VWtac1dWWnJiR2xOYlhNNQ==")))))))), false);
			this.ckbThamGiaNhomTrungNhau.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpXYW1Kc1dqRlhha0V4WWpGc1dWWlVNRDA9")))))))), false);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x002E0650 File Offset: 0x002DE850
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMFU1VUZFOVBRPT0=")))))))), this.ckbTuongTacNewsfeed.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMXBQWkd4U1NWWnVXbWxpVjFKSVdUSXdOV1JCUFQwPQ==")))))))), Convert.ToInt32(this.nudTuongTacNewsfeedSoLuongFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMXBQWkd4U1NWWnVXbWxpVjFKV1dXNWpPVkJSUFQwPQ==")))))))), Convert.ToInt32(this.nudTuongTacNewsfeedSoLuongTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVpUWWtkS1NGSnFWbE5pYTNBeVdXeEZPVkJSUFQwPQ==")))))))), Convert.ToInt32(this.nudTuongTacNewsfeedDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVpUWWtkS1NGSnFWbGRTZW1jNQ==")))))))), Convert.ToInt32(this.nudTuongTacNewsfeedDelayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVkwWTBkRmVWWlVNRDA9")))))))), this.ckbTuongTacNewsfeedLike.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1YQlpXa2h3WVdKV1duTlhhMVpQWkcxS1dFMVhlR2xpYkVVNQ==")))))))), this.ckbTuongTacNewsfeedComment.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1JUaz0=")))))))), this.ckbTuongTacFriend.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NsVlpha0kwVFZkSmVVNVhOVkppVlZveFZWY3hWMUl5VG5SUFdGRTk=")))))))), Convert.ToInt32(this.nudTuongTacFriendSoLuongBanBeFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NsVlpha0kwVFZkSmVVNVhOVkppVlZveFZWY3hWMVpYU2pOUVZEQTk=")))))))), Convert.ToInt32(this.nudTuongTacFriendSoLuongBanBeTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NsVlpha0kwVFZkSmVVNVhOVkppVlZwM1ZtMHhjMkpIVWtaWGJteHBUV3BCT1E9PQ==")))))))), Convert.ToInt32(this.nudTuongTacFriendSoLuongBaiVietFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NsVlpha0kwVFZkSmVVNVhOVkppVlZwM1ZtMHhjMkpIVWtkVmJsazk=")))))))), Convert.ToInt32(this.nudTuongTacFriendSoLuongBaiVietTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrWlhiR1EwWVVkV1ZsZHViR2xOYWtFNQ==")))))))), Convert.ToInt32(this.nudTuongTacFriendDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrWlhiR1EwWVVkV1YxVnVXVDA9")))))))), Convert.ToInt32(this.nudTuongTacFriendDelayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrNVpWbVF3WWtFOVBRPT0=")))))))), this.ckbTuongTacFriendLike.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01rNTBZa2Q0YVdKV1NrVlpha2w0WkVad1dFNVVRVDA9")))))))), this.ckbTuongTacFriendComment.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxGVU1Eaz0=")))))))), this.ckbTuongTacGroup.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZPV2hTZW13d1ZXMDFTMlJ0U2xKUVZEQTk=")))))))), Convert.ToInt32(this.nudTuongTacGroupSoLuongNhomFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZPV2hTZW13d1ZtdGpORkJSUFQwPQ==")))))))), Convert.ToInt32(this.nudTuongTacGroupSoLuongNhomTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZUbHBXTW5oWVdWWmtWMDFHU25WVGJscHBWVlF3T1E9PQ==")))))))), Convert.ToInt32(this.nudTuongTacGroupSoLuongBaiVietFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKck5USldSV2hYWkcxS2RGcEZUbHBXTW5oWVdWWmtWMDFHV2toUFJEQTk=")))))))), Convert.ToInt32(this.nudTuongTacGroupSoLuongBaiVietTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKV1NuTlphMlJIVGxaS2RWTnVXbWxWVkRBNQ==")))))))), Convert.ToInt32(this.nudTuongTacGroupDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKV1NuTlphMlJIVGxaYVNFOUVNRDA9")))))))), Convert.ToInt32(this.nudTuongTacGroupDelayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKWWFIZFpWRXBXVUZFOVBRPT0=")))))))), this.ckbTuongTacGroupLike.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VFIwNTBUMVJHYWxKVk5USlpiR040WWtkS2RWVlVNRDA9")))))))), this.ckbTuongTacGroupComment.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTT0=")))))))), this.ckbTuongTacFanpage.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOVlVwdlYycEtWMUl5VG5SUFdGRTk=")))))))), Convert.ToInt32(this.nudTuongTacFanpageSoLuongPageFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOVlVwdlYycEtWMVpYU2pOUVZEQTk=")))))))), Convert.ToInt32(this.nudTuongTacFanpageSoLuongPageTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOUlhCdldWWmFZV05HY0ZsVmEyUnFZbFJzTUE9PQ==")))))))), Convert.ToInt32(this.nudTuongTacFanpageSoLuongBaiVietFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldWRWsxVkZkU1dFOVlWbUZOUlhCdldWWmFZV05HY0ZsVmJGWnBaSG93T1E9PQ==")))))))), Convert.ToInt32(this.nudTuongTacFanpageSoLuongBaiVietTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTlZhMlJYWXpGc1dXSkZaR3BpVkd3dw==")))))))), Convert.ToInt32(this.nudTuongTacFanpageDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTlZhMlJYWXpGc1dXSkdWbWxrZWpBNQ==")))))))), Convert.ToInt32(this.nudTuongTacFanpageDelayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTldSV1J6WTJ4d1VsQlVNRDA9")))))))), this.ckbTuongTacFanpageLike.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U01XeFlUbGhrV2xZeVVuTlZWRWsxWkVkS1dGWnVWbXRSVkRBNQ==")))))))), this.ckbTuongTacFanpageComment.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRuUFE9PQ==")))))))), this.ckbKetBanTuKhoa.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVjFOR1drMVpWV00xWVVFOVBRPT0=")))))))), this.txtKetBanTuKhoaTuKhoa.Text);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ==")))))))), Convert.ToInt32(this.nudKetBanTuKhoaSoLuongFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9")))))))), Convert.ToInt32(this.nudKetBanTuKhoaSoLuongTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVTFJeFducFhWbWh6VWpKT2RFOVlVVDA9")))))))), Convert.ToInt32(this.nudKetBanTuKhoaDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyYUZkVVIwWklUMWRvVTFJeFducFhWbWh6VmxkS00xQlVNRDA9")))))))), Convert.ToInt32(this.nudKetBanTuKhoaDelayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlZxU1RWalJtUlNVRlF3UFE9PQ==")))))))), this.ckbKetBanGoiY.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUlhWRzVhVlZOR1dqSlpiVEZyVWpKT2RFOVlVVDA9")))))))), Convert.ToInt32(this.nudKetBanGoiYSoLuongFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUlhWRzVhVlZOR1dqSlpiVEZyVmxkS00xQlVNRDA9")))))))), Convert.ToInt32(this.nudKetBanGoiYSoLuongTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUldWVzE0YVZJd1dURlZiVFZMWkcxS1VsQlVNRDA9")))))))), Convert.ToInt32(this.nudKetBanGoiYDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlZxU1RWalJtUldWVzE0YVZJd1dURldhMk0wVUZFOVBRPT0=")))))))), Convert.ToInt32(this.nudKetBanGoiYDelayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2R6UFE9PQ==")))))))), this.ckbKetBanTepUid.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ==")))))))), Convert.ToInt32(this.nudKetBanTepUidSoLuongFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9")))))))), Convert.ToInt32(this.nudKetBanTepUidSoLuongTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVTFJeFducFhWbWh6VWpKT2RFOVlVVDA9")))))))), Convert.ToInt32(this.nudKetBanTepUidDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVTFJeFducFhWbWh6VmxkS00xQlVNRDA9")))))))), Convert.ToInt32(this.nudKetBanTepUidDelayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxXYWtKU1lsVmFNVlpyWkZka01WcFlZa2QwVjFORmIzaFpiVEZyVkRKR1NGSnFSVDA9")))))))), this.ckbKetBanTepUidTrungNhau.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVZwNk1Eaz0=")))))))), this.ckbXacNhanKetBan.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdKRk5USldSV2hYWkcxS2RGcEZaR3BpVkd3dw==")))))))), Convert.ToInt32(this.nudXacNhanKetBanSoLuongFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdKRk5USldSV2hYWkcxS2RGcEdWbWxrZWpBNQ==")))))))), Convert.ToInt32(this.nudXacNhanKetBanSoLuongTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdFeFNuTlphMlJIVGxaS2RWTnVXbWxWVkRBNQ==")))))))), Convert.ToInt32(this.nudXacNhanKetBanDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhaRWhTYlhCVllsZG9iMWx0ZERCaVIxSkdVMjFvYVdFeFNuTlphMlJIVGxaYVNFOUVNRDA9")))))))), Convert.ToInt32(this.nudXacNhanKetBanDelayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERT0=")))))))), this.ckbTuongTacNhanTin.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERldWRWsxVkZkU1dFOVlWbUZOUm5BMVdXcEpkMUJSUFQwPQ==")))))))), Convert.ToInt32(this.nudTuongTacNhanTinSoLuongFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERldWRWsxVkZkU1dFOVlWbUZOVmtveQ==")))))))), Convert.ToInt32(this.nudTuongTacNhanTinSoLuongTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERlZhMlJYWXpGc1dXSkZaR3BpVkd3dw==")))))))), Convert.ToInt32(this.nudTuongTacNhanTinDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5VU1rWklVbTVXVjFJeWVERlZhMlJYWXpGc1dXSkdWbWxrZWpBNQ==")))))))), Convert.ToInt32(this.nudTuongTacNhanTinDelayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR2UFE9PQ==")))))))), this.ckbTuongTacChoc.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ==")))))))), Convert.ToInt32(this.nudTuongTacChocSoLuongFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9")))))))), Convert.ToInt32(this.nudTuongTacChocSoLuongTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmQxVnRlR2xTTUZreFZXMDFTMlJ0U2xKUVZEQTk=")))))))), Convert.ToInt32(this.nudTuongTacChocSoLuongDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1IwWklUMWR3VmsxcWJFNWFSbU0xWkZadmQxVnRlR2xTTUZreFZtdGpORkJSUFQwPQ==")))))))), Convert.ToInt32(this.nudTuongTacChocSoLuongDelayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M0UFE9PQ==")))))))), this.ckbTuongTacCMSN.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VmsxcWJFNWFSbU0xWkZadmQxZHViR2xOYWtFNQ==")))))))), Convert.ToInt32(this.nudTuongTacCMSNSoLuongFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VmsxcWJFNWFSbU0xWkZadmVGVnVXVDA9")))))))), Convert.ToInt32(this.nudTuongTacCMSNSoLuongTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VTFJeFducFhWbWh6VWpKT2RFOVlVVDA9")))))))), Convert.ToInt32(this.nudTuongTacCMSNDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2xXYmxwcFlsZFNWbGRXWkU5U1JsSlhWR3M1VTFJeFducFhWbWh6VmxkS00xQlVNRDA9")))))))), Convert.ToInt32(this.nudTuongTacCMSNDelayTo.Value));
			bool @checked = this.rbTuongTacCMSNNhanTin.Checked;
			if (@checked)
			{
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10b1YyUnRTblJhUmxaYVZqQTFSVlpHV2s5VU1WcEpZa2hrWVZaVlduRmFSV1J6WkcxS2JsQlVNRDA9")))))))), 0);
			}
			else
			{
				this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10b1YyUnRTblJhUmxaYVZqQTFSVlpHV2s5VU1WcEpZa2hrWVZaVlduRmFSV1J6WkcxS2JsQlVNRDA9")))))))), 1);
			}
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVVF3UFE9PQ==")))))))), this.ckbThamGiaNhom.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpTYVUxSVozaFpha2t4WW14S2RWTnVXbWxWVkRBNQ==")))))))), Convert.ToInt32(this.nudThamGiaNhomSoLuongFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpTYVUxSVozaFpha2t4WW14YVNFOUVNRDA9")))))))), Convert.ToInt32(this.nudThamGiaNhomSoLuongTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlZXWVZZemFHOWFWbFpoWlZkSmVVMUVNRDA9")))))))), Convert.ToInt32(this.nudThamGiaNhomDelayFrom.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlZXWVZZemFHOWFWbHBUWkdjOVBRPT0=")))))))), Convert.ToInt32(this.nudThamGiaNhomDelayTo.Value));
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpXYW1KVldrNVpha3B6VWtac1dWWnJiR2xOYlhNNQ==")))))))), this.ckbThamGiaNhomTraLoiCauHoi.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hoUjJocFZsZFNkMWRXVlRGaU1rbDVUVlpXYW1Kc1dqRlhha0V4WWpGc1dWWlVNRDA9")))))))), this.ckbThamGiaNhomTrungNhau.Checked);
			this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeGFHUXlVbFJSYWtKb1ZGVTVibGx0TVc1YU1XczBWSHBDYVdKWFRucFRWV1JMWVVod1RGUnVWa3BTTURVeVpXdHNSbG95U2xsWFJWSXdWRmhzUTFsdGJFVlNWM1JZVERBeGJsWjZWblZUVldSUlVqTk9UbVZWY0ZwVk1FbzJaSHBrVlZSWGJGVlBSREE5")))))))))) == DialogResult.Yes;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x002E299C File Offset: 0x002E0B9C
		private void BtnOpenComment_Click(object sender, EventArgs e)
		{
			Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUkhTbGhXYmxaclUwVXhNVnBGYUc5TlFUMDk=")))))))));
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x002E29F8 File Offset: 0x002E0BF8
		private void BtnUploadUid_Click(object sender, EventArgs e)
		{
			Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRXhiRmhWYlhSaFVqRndOVmxXWkZka1ZuQkVUbFJDYkZOR1JUaz0=")))))))));
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x002E2A54 File Offset: 0x002E0C54
		private void BtnUploadGroup_Click(object sender, EventArgs e)
		{
			Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwT1MyUnRVbGxSYm5CTllteEpNRnBGUlRsUVVUMDk=")))))))));
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x002E2AB0 File Offset: 0x002E0CB0
		private void Button1_Click(object sender, EventArgs e)
		{
			Process.Start(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1XRlhTWHBoU0hCTllteEpNRnBGUlRsUVVUMDk=")))))))));
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x002E2B0C File Offset: 0x002E0D0C
		private void CheckedChangedFull()
		{
			this.ckbTuongTacNewsfeed_CheckedChanged(null, null);
			this.ckbTuongTacFriend_CheckedChanged(null, null);
			this.ckbTuongTacGroup_CheckedChanged(null, null);
			this.ckbTuongTacFanpage_CheckedChanged(null, null);
			this.ckbKetBanTuKhoa_CheckedChanged(null, null);
			this.ckbKetBanTepUid_CheckedChanged(null, null);
			this.ckbKetBanGoiY_CheckedChanged(null, null);
			this.ckbTuongTacNhanTin_CheckedChanged(null, null);
			this.ckbTuongTacChoc_CheckedChanged(null, null);
			this.ckbTuongTacCMSN_CheckedChanged(null, null);
			this.ckbThamGiaNhom_CheckedChanged(null, null);
			this.ckbXacNhanKetBan_CheckedChanged(null, null);
			this.ckbTuongTacNewsfeedComment_CheckedChanged(null, null);
			this.ckbTuongTacFriendComment_CheckedChanged(null, null);
			this.ckbTuongTacGroupComment_CheckedChanged(null, null);
			this.ckbTuongTacFanpageComment_CheckedChanged(null, null);
			this.ckbThamGiaNhomTraLoiCauHoi_CheckedChanged(null, null);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x002E2C08 File Offset: 0x002E0E08
		private void ckbTuongTacNewsfeed_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacNewsfeed.Enabled = this.ckbTuongTacNewsfeed.Checked;
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x002E2C38 File Offset: 0x002E0E38
		private void ckbTuongTacFriend_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacFriend.Enabled = this.ckbTuongTacFriend.Checked;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x002E2C68 File Offset: 0x002E0E68
		private void ckbTuongTacGroup_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacGroup.Enabled = this.ckbTuongTacGroup.Checked;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x002E2C98 File Offset: 0x002E0E98
		private void ckbTuongTacFanpage_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacFanpage.Enabled = this.ckbTuongTacFanpage.Checked;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x002E2CC8 File Offset: 0x002E0EC8
		private void ckbKetBanTuKhoa_CheckedChanged(object sender, EventArgs e)
		{
			this.plKetBanTuKhoa.Enabled = this.ckbKetBanTuKhoa.Checked;
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x002E2CF8 File Offset: 0x002E0EF8
		private void ckbKetBanTepUid_CheckedChanged(object sender, EventArgs e)
		{
			this.plKetBanTepUid.Enabled = this.ckbKetBanTepUid.Checked;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x002E2D28 File Offset: 0x002E0F28
		private void ckbKetBanGoiY_CheckedChanged(object sender, EventArgs e)
		{
			this.plKetBanGoiY.Enabled = this.ckbKetBanGoiY.Checked;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x002E2D58 File Offset: 0x002E0F58
		private void ckbTuongTacNhanTin_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacNhanTin.Enabled = this.ckbTuongTacNhanTin.Checked;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x002E2D88 File Offset: 0x002E0F88
		private void ckbTuongTacChoc_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacChoc.Enabled = this.ckbTuongTacChoc.Checked;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x002E2DB8 File Offset: 0x002E0FB8
		private void ckbTuongTacCMSN_CheckedChanged(object sender, EventArgs e)
		{
			this.plTuongTacCMSN.Enabled = this.ckbTuongTacCMSN.Checked;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x002E2DE8 File Offset: 0x002E0FE8
		private void ckbThamGiaNhom_CheckedChanged(object sender, EventArgs e)
		{
			this.plThamGiaNhom.Enabled = this.ckbThamGiaNhom.Checked;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x002E2E18 File Offset: 0x002E1018
		private void ckbXacNhanKetBan_CheckedChanged(object sender, EventArgs e)
		{
			this.plXacNhanKetBan.Enabled = this.ckbXacNhanKetBan.Checked;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x002E2E48 File Offset: 0x002E1048
		private void btnOpenComment_Click_1(object sender, EventArgs e)
		{
			this.OpenFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFYwMHlUWGxYYlhoaFZqRktjVmxxU1hoa1JuQllUbFJDYW1SNk1Eaz0=")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWVZkR2FtVlZSbWxpVjJSdVdXdG9XVkpIT1hwbFYzQnBXbm93T1E9PQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1XeDBZbXN4YmxKNlZuWlRWV1EwVFZoak1sUkZNWFpOYWxFNQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNNMW95VFhwUmJrSnBZVlZLTVdSNlpGVlVWemg1WVRKa1lWTkdXakZYYm14RFRqRnNXV1ZIYkcxU01EUTFVekZGT1ZCUlBUMD0="))))))))));
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x002E2F88 File Offset: 0x002E1188
		private void OpenFile(string nameFile, string title, string status, string footer)
		{
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYyRkdhM3BWYmtKcFRXcFdObGRGUlRsUVVUMDk=")))))))) + nameFile + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMVUwNUhVa0pRVkRBOQ=="))))))));
				bool flag = !File.Exists(text);
				if (flag)
				{
					Common.CreateFile(text);
				}
				Common.ShowForm(new fNhapDuLieu1(text, title, status, footer, null));
			}
			catch
			{
			}
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x002E3090 File Offset: 0x002E1290
		private void button3_Click(object sender, EventArgs e)
		{
			this.OpenFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIwMVMyTkdjRmhPVjNSYVRXcHNNRmxzWkZka1YxSkpWRlF3UFE9PQ==")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWVZkR2FtVlZSbWxpVjJSdVdXdG9XVkpIT1hwbFYzQnBXbm93T1E9PQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1XeDBZbXN4YmxKNlZuWlRWV1EwVFZoak1sUkZNWFpOYWxFNQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNNMW95VFhwUmJrSnBZVlZLTVdSNlpGVlVWemg1WVRKa1lWTkdXakZYYm14RFRqRnNXV1ZIYkcxU01EUTFVekZGT1ZCUlBUMD0="))))))))));
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x002E31D0 File Offset: 0x002E13D0
		private void button4_Click(object sender, EventArgs e)
		{
			this.OpenFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwT1MyUnRVbGxSYlhCcFRXcEdNRmRzWXpGTlIwNHpVRlF3UFE9PQ==")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWVZkR2FtVlZSbWxpVjJSdVdXdG9XVkpIT1hwbFYzQnBXbm93T1E9PQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1XeDBZbXN4YmxKNlZuWlRWV1EwVFZoak1sUkZNWFpOYWxFNQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNNMW95VFhwUmJrSnBZVlZLTVdSNlpGVlVWemg1WVRKa1lWTkdXakZYYm14RFRqRnNXV1ZIYkcxU01EUTFVekZGT1ZCUlBUMD0="))))))))));
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x002E3310 File Offset: 0x002E1510
		private void button7_Click(object sender, EventArgs e)
		{
			this.OpenFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IySnNjRmxVVkRBOQ==")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVTJ4S1JGRnVaRnBXTWxKeg=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1VNVdWVmRrYWxJd1duVlhiRVU1VUZFOVBRPT0="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x002E3450 File Offset: 0x002E1650
		private void button6_Click(object sender, EventArgs e)
		{
			this.OpenFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IySnNjRmhVYmxwcFZucEdjMWx0TlZObFp6MDk=")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWVZkR2FtVlZSbWxpVjJSdVdXdG9XVkpIT1hwbFYzQnBXbm93T1E9PQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1XeDBZbXN4YmxKNlZuWlRWV1EwVFZoak1sUkZNWFpOYWxFNQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNNMW95VFhwUmJrSnBZVlZLTVdSNlpGVlVWemg1WVRKa1lWTkdXakZYYm14RFRqRnNXV1ZIYkcxU01EUTFVekZGT1ZCUlBUMD0="))))))))));
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x002E3590 File Offset: 0x002E1790
		private void btnInbox_Click(object sender, EventArgs e)
		{
			this.OpenFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1YyVnRUWGxTYlRWaFZWUXdPUT09")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVFVkR1dFNUhaR2xpVjNCR1ducG9OVkZ0U201UVZEQTk="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1sSklZa2hXU2xKNlZuWmxSV3hSVkZka1dFNUVNRDA9"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNNMW95VFhwUmJrSnBZVlZLTVdSNlpGVlVWemg1WVRKa1lWTkdXakZYYm14RFRqRnNXV1ZIYkcxU01EUTFVekZGT1ZCUlBUMD0="))))))))));
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x002E36D0 File Offset: 0x002E18D0
		private void button2_Click(object sender, EventArgs e)
		{
			this.OpenFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeGMyVlhVa2hoUjNSYVYwZDRjVmxxU1RGTlJuQllUbFJCUFE9PQ==")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWXpOb2VGTkZNVzVTTW5SdVYxUktiMDFZY0VwU2JXODk="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1rcE9XVmRvTmxOVlNuZFRWV1JQWWpKU2FtVlZTbHBrZWpBNQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNNMW95VFhwUmJrSnBZVlZLTVdSNlpGVlVWemg1WVRKa1lWTkdXakZYYm14RFRqRnNXV1ZIYkcxU01EUTFVekZGT1ZCUlBUMD0="))))))))));
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x002E3810 File Offset: 0x002E1A10
		private void button8_Click(object sender, EventArgs e)
		{
			this.OpenFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1UxSXlUblJpUjNocFlsWkZPUT09")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVm14T1ZsVlhaRnBQUlRsd1pXdHNRMlJWYkVoa2ExSjRZek5zUTFwRlRrTmhWbXhxWlZkd2FWcDZNRGs9"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1WcFdZa1ZWUFE9PQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x002E3950 File Offset: 0x002E1B50
		private void button1_Click_1(object sender, EventArgs e)
		{
			this.OpenFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1UxTkhUblJQVkVacVVWUXdPUT09")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEVTJ4S1JGRnVWbWhTZVRsT1dqRmpkMW94YXpSVU1tdzJVMVZLTVZOVmFGTmlNV3hZVFVka1lVMXRlRzg9"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1VNVdWVmRrYVdKWGFESmxhMnhIWkVFOVBRPT0="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNjbEJSUFQwPQ=="))))))))));
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x002E3A90 File Offset: 0x002E1C90
		private void button5_Click(object sender, EventArgs e)
		{
			this.OpenFile(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaak1XVnRVWGxXYm1zOQ==")))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSkhPWHBsVjNCcVVUQktjbGRXWXpGaU1HeEpWRzFvTmxOVlduRlpWVTVEWVc1ak1sTnFSa3BUUmtvMVYxZE9OVk5yYkVobGEyUjJXVE5zUWxsV1JUbFFVVDA5"))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IyUlhSa1JSYm5CYVdUTnNRMWRVU201YU1XczBWREpzYTFVd1NYZFpNakZKVkZkc1ZGRnVUalJqVldoT1dqQmtjbEJSUFQwPQ=="))))))))), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCVmVsSklVazVsVlZKb1ZUQktNV1I2WkZWVVZ6aDVZVEprWVZOR1dqRlhibXhDWlVWc1NGVnVXalpUVlVveFYyNXNNMW95VFhwUmJrSnBZVlZLTVdSNlpGVlVWemg1WVRKa1lWTkdXakZYYm14RFRqRnNXV1ZIYkcxU01EUTFVekZGT1ZCUlBUMD0="))))))))));
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x002E3BD0 File Offset: 0x002E1DD0
		private void ckbTuongTacNewsfeedComment_CheckedChanged(object sender, EventArgs e)
		{
			this.btnTuongTacNewsfeedComment.Enabled = this.ckbTuongTacNewsfeedComment.Checked;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x002E3C00 File Offset: 0x002E1E00
		private void ckbTuongTacFriendComment_CheckedChanged(object sender, EventArgs e)
		{
			this.btnTuongTacFriendComment.Enabled = this.ckbTuongTacFriendComment.Checked;
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x002E3C30 File Offset: 0x002E1E30
		private void ckbTuongTacGroupComment_CheckedChanged(object sender, EventArgs e)
		{
			this.btnTuongTacGroupComment.Enabled = this.ckbTuongTacGroupComment.Checked;
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x002E3C60 File Offset: 0x002E1E60
		private void ckbTuongTacFanpageComment_CheckedChanged(object sender, EventArgs e)
		{
			this.btnTuongTacFanpageComment.Enabled = this.ckbTuongTacFanpageComment.Checked;
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x002E3C90 File Offset: 0x002E1E90
		private void ckbThamGiaNhomTraLoiCauHoi_CheckedChanged(object sender, EventArgs e)
		{
			this.btnThamGiaNhomTraLoiCauHoi.Enabled = this.ckbThamGiaNhomTraLoiCauHoi.Checked;
		}

		// Token: 0x04001816 RID: 6166
		private JSON_Settings settings;
	}
}
