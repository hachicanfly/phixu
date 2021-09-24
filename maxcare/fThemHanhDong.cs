using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x02000124 RID: 292
	public partial class fThemHanhDong : Form
	{
		// Token: 0x06000CE3 RID: 3299 RVA: 0x000030A5 File Offset: 0x000012A5
		public fThemHanhDong(string id_KichBan)
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.id_KichBan = id_KichBan;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0028BF44 File Offset: 0x0028A144
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.groupBox2);
			Language.GetValue(this.btnDocThongBao);
			Language.GetValue(this.metroButton2);
			Language.GetValue(this.metroButton3);
			Language.GetValue(this.metroButton12);
			Language.GetValue(this.metroButton11);
			Language.GetValue(this.metroButton10);
			Language.GetValue(this.metroButton4);
			Language.GetValue(this.metroButton19);
			Language.GetValue(this.groupBox1);
			Language.GetValue(this.metroButton29);
			Language.GetValue(this.metroButton34);
			Language.GetValue(this.metroButton8);
			Language.GetValue(this.metroButton7);
			Language.GetValue(this.metroButton6);
			Language.GetValue(this.metroButton5);
			Language.GetValue(this.groupBox4);
			Language.GetValue(this.metroButton14);
			Language.GetValue(this.metroButton13);
			Language.GetValue(this.metroButton18);
			Language.GetValue(this.metroButton16);
			Language.GetValue(this.metroButton9);
			Language.GetValue(this.metroButton15);
			Language.GetValue(this.metroButton17);
			Language.GetValue(this.groupBox5);
			Language.GetValue(this.metroButton38);
			Language.GetValue(this.metroButton23);
			Language.GetValue(this.metroButton21);
			Language.GetValue(this.metroButton22);
			Language.GetValue(this.metroButton20);
			Language.GetValue(this.groupBox3);
			Language.GetValue(this.metroButton26);
			Language.GetValue(this.metroButton25);
			Language.GetValue(this.metroButton31);
			Language.GetValue(this.metroButton27);
			Language.GetValue(this.metroButton1);
			Language.GetValue(this.metroButton24);
			Language.GetValue(this.metroButton36);
			Language.GetValue(this.metroButton37);
			Language.GetValue(this.groupBox6);
			Language.GetValue(this.metroButton28);
			Language.GetValue(this.metroButton32);
			Language.GetValue(this.metroButton33);
			Language.GetValue(this.metroButton35);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00069C18 File Offset: 0x00067E18
		private void FConfigInteract_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0028C250 File Offset: 0x0028A450
		private void btnDocThongBao_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDDocThongBao(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDDocThongBao.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0028C2D8 File Offset: 0x0028A4D8
		private void metroButton2_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDXemStory(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDXemStory.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0028C360 File Offset: 0x0028A560
		private void metroButton3_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDXemWatch(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDXemWatch.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0028C3E8 File Offset: 0x0028A5E8
		private void metroButton12_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDNhanTinBanBe(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDNhanTinBanBe.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0028C470 File Offset: 0x0028A670
		private void metroButton11_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDChocBanBe(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDChocBanBe.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0028C4F8 File Offset: 0x0028A6F8
		private void metroButton10_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDChucMungSinhNhat(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDChucMungSinhNhat.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0028C580 File Offset: 0x0028A780
		private void metroButton4_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDPhanHoiTinNhan(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDPhanHoiTinNhan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0028C608 File Offset: 0x0028A808
		private void metroButton8_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDBaiVietNewsfeed(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDBaiVietNewsfeed.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0028C690 File Offset: 0x0028A890
		private void metroButton7_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDBaiVietBanBe(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDBaiVietBanBe.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0028C718 File Offset: 0x0028A918
		private void metroButton6_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDBaiVietNhom(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDBaiVietNhom.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0028C7A0 File Offset: 0x0028A9A0
		private void metroButton5_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDBaiVietFanpage(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDBaiVietFanpage.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0028C828 File Offset: 0x0028AA28
		private void metroButton14_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanTheoTuKhoa(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanTheoTuKhoa.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0028C8B0 File Offset: 0x0028AAB0
		private void metroButton13_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanGoiY(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanGoiY.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00069C18 File Offset: 0x00067E18
		private void groupBox5_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0028C938 File Offset: 0x0028AB38
		private void metroButton18_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDXacNhanKetBan(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDXacNhanKetBan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0028C9C0 File Offset: 0x0028ABC0
		private void metroButton9_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanTepUid(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanTepUid.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0028CA48 File Offset: 0x0028AC48
		private void metroButton16_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanThanhVienNhom(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanThanhVienNhom.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x0028CAD0 File Offset: 0x0028ACD0
		private void metroButton15_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDHuyLoiMoiKetBan(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDHuyLoiMoiKetBan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0028CB58 File Offset: 0x0028AD58
		private void metroButton17_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDHuyKetBan(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDHuyKetBan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0028CBE0 File Offset: 0x0028ADE0
		private void metroButton23_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDThamGiaNhomUid(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDThamGiaNhomUid.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0028CC68 File Offset: 0x0028AE68
		private void metroButton19_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanVoiBanBeCuaUid(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanVoiBanBeCuaUid.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0028CCF0 File Offset: 0x0028AEF0
		private void metroButton23_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDThamGiaNhomTuKhoa(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDThamGiaNhomTuKhoa.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0028CD78 File Offset: 0x0028AF78
		private void metroButton22_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDRoiNhom(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDRoiNhom.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x0028CE00 File Offset: 0x0028B000
		private void metroButton20_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDMoiBanBeVaoNhom(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDMoiBanBeVaoNhom.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0028CE88 File Offset: 0x0028B088
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

		// Token: 0x06000D00 RID: 3328 RVA: 0x0028CF4C File Offset: 0x0028B14C
		private void metroButton1_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDTuongTacNewsfeed(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDTuongTacNewsfeed.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0028CFD4 File Offset: 0x0028B1D4
		private void metroButton26_Click(object sender, EventArgs e)
		{
			try
			{
				Common.ShowForm(new fHDBuffLikeComment(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
				bool isSave = fHDBuffLikeComment.isSave;
				if (isSave)
				{
					base.Close();
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1YwMUhUblJQVlU1clYwWkpkMWxxU1RCbFZUVnpUMVZTYVZJeWVIRlpXR001VUZFOVBRPT0=")))))))));
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGxyT1VoT01uZDVZVEprYkZRd1l6SmllazV5V2pKT2RGSllUa3BUUm05NFdWWk9RMk16WXpOVGJsWmhaVlZLZWxsWFRsQmpWMHB3VVcwNE1GbHVWa2xUVlZaSFlUSktXR0pJVmtwVlZEQTU="))))))))), 2);
			}
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0028D124 File Offset: 0x0028B324
		private void metroButton31_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDBuffFollowLikePage(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDBuffFollowLikePage.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0028D1AC File Offset: 0x0028B3AC
		private void metroButton25_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDBuffFollowCaNhan(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDBuffFollowCaNhan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0028D234 File Offset: 0x0028B434
		private void metroButton28_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDBackupData(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDBackupData.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0028D2BC File Offset: 0x0028B4BC
		private void metroButton19_Click_2(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDDangStatus(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDDangStatus.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0028D344 File Offset: 0x0028B544
		private void metroButton24_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDSpamBaiViet(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDSpamBaiViet.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x0028D3CC File Offset: 0x0028B5CC
		private void metroButton27_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDBuffTinNhanProfile(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDBuffTinNhanProfile.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x0028D454 File Offset: 0x0028B654
		private void metroButton1_Click_2(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDSeedingByVideo(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDSeedingByVideo.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0028D4DC File Offset: 0x0028B6DC
		private void metroButton32_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDTruyCapWebsite(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDTruyCapWebsite.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0028D564 File Offset: 0x0028B764
		private void metroButton32_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDTimKiemGoogle(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDTimKiemGoogle.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x0028D5EC File Offset: 0x0028B7EC
		private void metroButton34_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDTuongTacBanBe(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDTuongTacBanBe.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0028D674 File Offset: 0x0028B874
		private void metroButton30_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanTepUidNew(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanTepUidNew.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0028D6FC File Offset: 0x0028B8FC
		private void metroButton35_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDNghiGiaiLao(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDNghiGiaiLao.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0028D784 File Offset: 0x0028B984
		private void metroButton36_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDDangBai(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDDangBai.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0028D80C File Offset: 0x0028BA0C
		private void metroButton37_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDShareBai(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDShareBai.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0028D894 File Offset: 0x0028BA94
		private void metroButton38_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDThamGiaNhomGoiY(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDThamGiaNhomGoiY.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x0028D91C File Offset: 0x0028BB1C
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control;
			if (flag)
			{
				base.Height = 508;
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x0028D974 File Offset: 0x0028BB74
		private void metroButton40_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanNewfeed(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanNewfeed.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0028D9FC File Offset: 0x0028BBFC
		private void metroButton41_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanVoiBanCuaBanBe(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanVoiBanCuaBanBe.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0028CC68 File Offset: 0x0028AE68
		private void metroButton39_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanVoiBanBeCuaUid(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanVoiBanBeCuaUid.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0028DA84 File Offset: 0x0028BC84
		private void metroButton30_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDXemStoryChiDinh(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDXemStoryChiDinh.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0028DB0C File Offset: 0x0028BD0C
		private void metroButton40_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDDangStory(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDDangStory.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00069C18 File Offset: 0x00067E18
		private void metroButton42_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x0028DB94 File Offset: 0x0028BD94
		private void metroButton40_Click_2(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDDocThongBaov2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDDocThongBaov2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x0028DC1C File Offset: 0x0028BE1C
		private void metroButton43_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanTepUidv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanTepUidv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x0028DCA4 File Offset: 0x0028BEA4
		private void metroButton42_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDTuongTacNewsfeedv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDTuongTacNewsfeedv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x0028DD2C File Offset: 0x0028BF2C
		private void metroButton44_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDThamGiaNhomUidv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDThamGiaNhomUidv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x0028DDB4 File Offset: 0x0028BFB4
		private void metroButton45_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDDangStatusV2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDDangStatusV2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0028DE3C File Offset: 0x0028C03C
		private void metroButton46_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDTuongTacBaiVietNhomv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDTuongTacBaiVietNhomv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x0028DEC4 File Offset: 0x0028C0C4
		private void metroButton47_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDXacNhanKetBanv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDXacNhanKetBanv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x0028DF4C File Offset: 0x0028C14C
		private void metroButton49_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDBuffViewVideo(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDBuffViewVideo.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0028DFD4 File Offset: 0x0028C1D4
		private void metroButton48_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDTuongTacBaiVietTheoID(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDTuongTacBaiVietTheoID.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0028E05C File Offset: 0x0028C25C
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			base.Width = 1462;
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00069C18 File Offset: 0x00067E18
		private void metroButton52_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0028E07C File Offset: 0x0028C27C
		private void metroButton54_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanTheoTuKhoav2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanTheoTuKhoav2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0028E104 File Offset: 0x0028C304
		private void metroButton55_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanGoiYv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanGoiYv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0028E18C File Offset: 0x0028C38C
		private void metroButton56_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDMoiLikePage(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDMoiLikePage.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0028DB0C File Offset: 0x0028BD0C
		private void metroButton57_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDDangStory(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDDangStory.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0028E214 File Offset: 0x0028C414
		private void metroButton59_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDThamGiaNhomTuKhoav2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDDangStory.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0028E29C File Offset: 0x0028C49C
		private void metroButton30_Click_2(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDXoaBaiPage(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDXoaBaiPage.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0028E324 File Offset: 0x0028C524
		private void metroButton58_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDThamGiaNhomGoiYv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDThamGiaNhomGoiYv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0028E104 File Offset: 0x0028C304
		private void metroButton30_Click_3(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanGoiYv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanGoiYv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0028E07C File Offset: 0x0028C27C
		private void metroButton57_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDKetBanTheoTuKhoav2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDKetBanTheoTuKhoav2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0028DA84 File Offset: 0x0028BC84
		private void metroButton61_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDXemStoryChiDinh(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDXemStoryChiDinh.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0028DB0C File Offset: 0x0028BD0C
		private void metroButton62_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDDangStory(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDDangStory.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0028E3AC File Offset: 0x0028C5AC
		private void metroButton50_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDXemStoryv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDXemStoryv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0028E434 File Offset: 0x0028C634
		private void metroButton51_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDXemWatchv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDXemWatchv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00069C18 File Offset: 0x00067E18
		private void metroButton54_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00069C18 File Offset: 0x00067E18
		private void metroButton55_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0028E4BC File Offset: 0x0028C6BC
		private void metroButton30_Click_5(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDXoaBaiTuong(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDXoaBaiTuong.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0028E544 File Offset: 0x0028C744
		private void metroButton52_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDThamGiaNhomTuKhoav2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDThamGiaNhomTuKhoav2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0028E324 File Offset: 0x0028C524
		private void metroButton53_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDThamGiaNhomGoiYv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDThamGiaNhomGoiYv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00069C18 File Offset: 0x00067E18
		private void metroButton57_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0028E5CC File Offset: 0x0028C7CC
		private void metroButton58_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDPhanHoiBinhLuan(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDPhanHoiBinhLuan.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0028E654 File Offset: 0x0028C854
		private void metroButton57_Click_3(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDHuyLikePage(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDHuyLikePage.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0028E6DC File Offset: 0x0028C8DC
		private void metroButton59_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDBaiVietTrenTuong(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDBaiVietTrenTuong.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0028E764 File Offset: 0x0028C964
		private void metroButton60_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDDangBaiTheoID(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDDangBaiTheoID.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0028E7EC File Offset: 0x0028C9EC
		private void metroButton61_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDChangeSoThich(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDChangeSoThich.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0028E874 File Offset: 0x0028CA74
		private void metroButton62_Click_1(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDChangeTenPhu(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDChangeTenPhu.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0028E8FC File Offset: 0x0028CAFC
		private void metroButton63_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDLinkToInstagram(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDLinkToInstagram.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0028E984 File Offset: 0x0028CB84
		private void metroButton58_Click_2(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDShareBaiv2(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDShareBaiv2.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x0028EA0C File Offset: 0x0028CC0C
		private void metroButton65_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDAnMail(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDAnMail.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x0028EA94 File Offset: 0x0028CC94
		private void metroButton66_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fHDCongKhaiBaiVietGanThe(this.id_KichBan, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			bool isSave = fHDCongKhaiBaiVietGanThe.isSave;
			if (isSave)
			{
				base.Close();
			}
		}

		// Token: 0x0400159A RID: 5530
		private string id_KichBan;
	}
}
