using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MCommon;

namespace maxcare
{
	// Token: 0x020000E7 RID: 231
	public partial class fCauHinhHienThi : Form
	{
		// Token: 0x06000947 RID: 2375 RVA: 0x00187EC8 File Offset: 0x001860C8
		public fCauHinhHienThi()
		{
			this.InitializeComponent();
			this.settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFVqQlpkMWRXWkd0bFYwWllWV3BLYUZZeFdYbz0=")))))))), false);
			this.ChangeLanguage();
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00187F44 File Offset: 0x00186144
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.lblStatus);
			Language.GetValue(this.ckbTen);
			Language.GetValue(this.ckbFollow);
			Language.GetValue(this.ckbBanBe);
			Language.GetValue(this.ckbNhom);
			Language.GetValue(this.ckbNgaySinh);
			Language.GetValue(this.ckbGioiTinh);
			Language.GetValue(this.ckbMatKhau);
			Language.GetValue(this.ckbMatKhauMail);
			Language.GetValue(this.ckbMa2FA);
			Language.GetValue(this.ckbNgayTao);
			Language.GetValue(this.ckbInteractEnd);
			Language.GetValue(this.ckbTinhTrang);
			Language.GetValue(this.ckbThuMuc);
			Language.GetValue(this.ckbGhiChu);
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.btnCancel);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00188084 File Offset: 0x00186284
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ==")))))))), this.ckbToken.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxQV0Zwb1RXMTRjdz09")))))))), this.ckbCookie.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTbGhOVjJob1ZqTmpPUT09")))))))), this.ckbEmail.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hXYmxVOQ==")))))))), this.ckbTen.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJTYmxaU1lsWlZPUT09")))))))), this.ckbBanBe.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJoU0ZwcFZWUXdPUT09")))))))), this.ckbNhom.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJhUjJoc1ZtczFkMWx0TVc1UVVUMDk=")))))))), this.ckbNgaySinh.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTWGxpU0Zwb1ZteEtkMWx0TVc1UVVUMDk=")))))))), this.ckbGioiTinh.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYWtKVVRXMW9iMXBHUlRsUVVUMDk=")))))))), this.ckbMatKhau.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYWtKVVRXMW9iMXBHVlhoaFIwWllaSG93UFE9PQ==")))))))), this.ckbMatKhauMail.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJTYlhCb1RURmFNdz09")))))))), this.ckbBackup.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTV0d4VFlUQlZPUT09")))))))), this.ckbMa2FA.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhocVlsVmFkVmRzWXpGTlFUMDk=")))))))), this.ckbUseragent.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWa2xUYmxwc1UwZHpPUT09")))))))), this.ckbProxy.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJhUjJoc1ZteEtiMWx1WXpsUVVUMDk=")))))))), this.ckbNgayTao.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxYYldoclVqQmFOUT09")))))))), this.ckbAvatar.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWa2xUYmxwaFlsZDRlbGRzUlRsUVVUMDk=")))))))), this.ckbProfile.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hpU0Zab1VteEtOVmRXWXpGaVp6MDk=")))))))), this.ckbTinhTrang.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hoUkVaVlYwWmFjUT09")))))))), this.ckbThuMuc.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTWGxoU0VKU1RXMW5lQT09")))))))), this.ckbGhiChu.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTblJQV0U1cFVucHJlZz09")))))))), this.ckbFollow.Checked);
			this.settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUbGhPVkVKaFYwVndiMWRVVGxOU2JVcDBWVlF3UFE9PQ==")))))))), this.ckbInteractEnd.Checked);
			this.settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			base.Close();
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00069C18 File Offset: 0x00067E18
		private void bunifuCustomLabel2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00188A28 File Offset: 0x00186C28
		private void fClearProfile_Load(object sender, EventArgs e)
		{
			this.ckbToken.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ==")))))))), false);
			this.ckbCookie.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxQV0Zwb1RXMTRjdz09")))))))), false);
			this.ckbEmail.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTbGhOVjJob1ZqTmpPUT09")))))))), false);
			this.ckbTen.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hXYmxVOQ==")))))))), false);
			this.ckbBanBe.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJTYmxaU1lsWlZPUT09")))))))), false);
			this.ckbNhom.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJoU0ZwcFZWUXdPUT09")))))))), false);
			this.ckbNgaySinh.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJhUjJoc1ZtczFkMWx0TVc1UVVUMDk=")))))))), false);
			this.ckbGioiTinh.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTWGxpU0Zwb1ZteEtkMWx0TVc1UVVUMDk=")))))))), false);
			this.ckbMatKhau.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYWtKVVRXMW9iMXBHUlRsUVVUMDk=")))))))), false);
			this.ckbMatKhauMail.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYWtKVVRXMW9iMXBHVlhoaFIwWllaSG93UFE9PQ==")))))))), false);
			this.ckbBackup.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJTYlhCb1RURmFNdz09")))))))), false);
			this.ckbMa2FA.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTV0d4VFlUQlZPUT09")))))))), false);
			this.ckbUseragent.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhocVlsVmFkVmRzWXpGTlFUMDk=")))))))), false);
			this.ckbProxy.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWa2xUYmxwc1UwZHpPUT09")))))))), false);
			this.ckbNgayTao.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJhUjJoc1ZteEtiMWx1WXpsUVVUMDk=")))))))), false);
			this.ckbAvatar.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxYYldoclVqQmFOUT09")))))))), false);
			this.ckbProfile.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWa2xUYmxwaFlsZDRlbGRzUlRsUVVUMDk=")))))))), false);
			this.ckbTinhTrang.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hpU0Zab1VteEtOVmRXWXpGaVp6MDk=")))))))), false);
			this.ckbThuMuc.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hoUkVaVlYwWmFjUT09")))))))), false);
			this.ckbGhiChu.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTWGxoU0VKU1RXMW5lQT09")))))))), false);
			this.ckbFollow.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTblJQV0U1cFVucHJlZz09")))))))), false);
			this.ckbInteractEnd.Checked = this.settings.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUbGhPVkVKaFYwVndiMWRVVGxOU2JVcDBWVlF3UFE9PQ==")))))))), false);
		}

		// Token: 0x04000D25 RID: 3365
		private JSON_Settings settings;
	}
}
