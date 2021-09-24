using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Common;
using ConversionBack;
using maxcare.Enum;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;
using MetroFramework;
using MetroFramework.Controls;
using WindowsFormsControlLibrary1;

namespace maxcare
{
	// Token: 0x02000071 RID: 113
	public partial class fBin : Form
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x0006D394 File Offset: 0x0006B594
		public fBin()
		{
			this.InitializeComponent();
			this.LoadSetting();
			this.LoadConfigManHinh();
			this.LoadcbbSearch();
			this.menuStrip1.Cursor = Cursors.Hand;
			this.ChangeLanguage();
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0006D4E4 File Offset: 0x0006B6E4
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			Language.GetValue(this.thoátToolStripMenuItem);
			Language.GetValue(this.grTimKiem);
			Language.GetValue(this.grQuanLyThuMuc);
			Language.GetValue(this.label1);
			Language.GetValue(this.label2);
			Language.GetValue(this.button9);
			Language.GetValue(this.button3);
			Language.GetValue(this.toolStripStatusLabel5);
			Language.GetValue(this.toolStripStatusLabel7);
			Language.GetValue(this.label3);
			foreach (object obj in this.dtgvAcc.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
			Language.GetValue(this.chọnLiveToolStripMenuItem);
			Language.GetValue(this.tấtCảToolStripMenuItem);
			Language.GetValue(this.liveToolStripMenuItem);
			Language.GetValue(this.tinhTrangToolStripMenuItem);
			Language.GetValue(this.trạngTháiToolStripMenuItem);
			Language.GetValue(this.bỏChọnTấtCảToolStripMenuItem);
			Language.GetValue(this.khôiPhucTaiKhoanToolStripMenuItem);
			Language.GetValue(this.xóaTàiKhoảnToolStripMenuItem);
			Language.GetValue(this.mởTrìnhDuyệtToolStripMenuItem);
			Language.GetValue(this.tiếnHànhMởToolStripMenuItem);
			Language.GetValue(this.càiĐặtCấuHìnhMởToolStripMenuItem);
			Language.GetValue(this.maBaoMât6SôToolStripMenuItem);
			Language.GetValue(this.đinhDangKhacToolStripMenuItem);
			Language.GetValue(this.checkCookieToolStripMenuItem);
			Language.GetValue(this.profileToolStripMenuItem);
			Language.GetValue(this.xóaProfileToolStripMenuItem);
			Language.GetValue(this.donDepProfileToolStripMenuItem);
			Language.GetValue(this.backupToolStripMenuItem);
			Language.GetValue(this.mởThưMụcBackupToolStripMenuItem);
			Language.GetValue(this.backupToolStripMenuItem1);
			Language.GetValue(this.xóaDữLiệuBackupToolStripMenuItem);
			Language.GetValue(this.tảiLạiDanhSáchToolStripMenuItem);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0006D790 File Offset: 0x0006B990
		private void LoadcbbSearch()
		{
			Dictionary<string, string> dataSource = new Dictionary<string, string>
			{
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14V2MxSlJQVDA9"))))))))
				},
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10ak5XTnNjRmhPUkRBOQ=="))))))))
				},
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNjOQ=="))))))))
				},
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4amVHRkhSbGhrZWpBOQ=="))))))))
				},
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYXpWYVZqSjRlZz09")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWa1IyVnRUalZSYlhocFZqQmFkMWxyUlRsUVVUMDk="))))))))
				},
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ==")))))))),
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVHTlhTbTVRVkRBOQ==")))))))))
				},
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1MyTkhUblZWYlRsaFVqQlpNUT09")))))))),
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGJWSkhPVWxoTW1ScVRXMTRNVmxWUlRsUVVUMDk=")))))))))
				},
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EySkhTblJWYlhocVdub3dPUT09")))))))),
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VldwS2RXRklWVEZrU0VKS1UwWlNSV05zWXpGaWR6MDk=")))))))))
				},
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09")))))))),
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtkV1NFNXVTbGxWVjJSb1RXMXdiMlJZUm5OTlVUMDk=")))))))))
				},
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EySXlSbFpVYlRsclZWUXdPUT09")))))))),
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VldwS2IyTkZiRWhVYlRscldUTnNRdz09")))))))))
				},
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUlhVa2hXYm14YVZqQTBkMVZzWXpGaGR6MDk=")))))))),
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeGFHUXphSGhTYmxaaFpWVkpkMWRYVGpWUmJHdzFVVzF3YTFrd09IZGxhMnhIWTBFOVBRPT0=")))))))))
				}
			};
			this.cbbSearch.DataSource = new BindingSource(dataSource, null);
			this.cbbSearch.ValueMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS1YwNVJQVDA9"))))))));
			this.cbbSearch.DisplayMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0weFIyTXlVbGhXVkRBOQ=="))))))));
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0006DEC4 File Offset: 0x0006C0C4
		private void LoadConfigManHinh()
		{
			this.setting_ShowDtgv = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFVqQlpkMWRXWkd0bFYwWllWV3BLYUZZeFdYbz0=")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ=="))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ==")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSWGxQV0Zwb1RXMTRjdz09")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ=="))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTbGhOVjJob1ZqTmpPUT09")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hXYmxVOQ==")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXVlhSbGhXYmxaaFVWUXdPUT09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJTYmxaU1lsWlZPUT09")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EyVlhTWHBXYm1NOQ=="))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJoU0ZwcFZWUXdPUT09")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1MyTkhUblZWYlRsaFVqQlpNUT09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJhUjJoc1ZtczFkMWx0TVc1UVVUMDk=")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EySkhTblJWYlhocVdub3dPUT09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTWGxpU0Zwb1ZteEtkMWx0TVc1UVVUMDk=")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYWtKVVRXMW9iMXBHUlRsUVVUMDk=")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYXpWYVZqSjRlZz09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTYWtKVVRXMW9iMXBHVlhoaFIwWllaSG93UFE9PQ==")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1MyRkdhM2xrUkVacVVWUXdPUT09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSblJTYlhCb1RURmFNdz09")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ=="))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVbGhTV0d4VFlUQlZPUT09")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk="))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhocVlsVmFkVmRzWXpGTlFUMDk=")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ=="))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWa2xUYmxwc1UwZHpPUT09")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1UyRkhVa2hXYTFKcVlsWmFiMXBGWkZkUmJHdDVWRlF3UFE9PQ=="))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldVblJhUjJoc1ZteEtiMWx1WXpsUVVUMDk=")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1IwMXNiRmxWYldocVdub3dPUT09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxYYldoclVqQmFOUT09")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWGxYYmtKcFVqRlZPUT09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWa2xUYmxwaFlsZDRlbGRzUlRsUVVUMDk=")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ=="))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hpU0Zab1VteEtOVmRXWXpGaVp6MDk=")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UySXlVbFpOVkVaYVpIb3dPUT09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXa2hoUkVaVlYwWmFjUT09")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EySXlSbFpVYlRsclZWUXdPUT09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTWGxoU0VKU1RXMW5lQT09")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXUnRTa2hsU0ZwclpIb3dPUT09"))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldTblJQV0U1cFVucHJlZz09")))))))), false);
			this.dtgvAcc.Columns[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUlhVa2hXYm14YVZqQTBkMVZzWXpGaGR6MDk="))))))))].Visible = this.setting_ShowDtgv.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUbGhPVkVKaFYwVndiMWRVVGxOU2JVcDBWVlF3UFE9PQ==")))))))), false);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0006EF28 File Offset: 0x0006D128
		protected override void OnLoad(EventArgs args)
		{
			Application.Idle += this.OnLoaded;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0006EF50 File Offset: 0x0006D150
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = base.Width == Screen.PrimaryScreen.WorkingArea.Width && base.Height == Screen.PrimaryScreen.WorkingArea.Height;
			bool flag2 = flag;
			if (flag2)
			{
				base.Width = Base.width;
				base.Height = Base.heigh;
				base.Top = Base.top;
				base.Left = Base.left;
			}
			else
			{
				Base.top = base.Top;
				Base.left = base.Left;
				base.Top = 0;
				base.Left = 0;
				base.Width = Screen.PrimaryScreen.WorkingArea.Width;
				base.Height = Screen.PrimaryScreen.WorkingArea.Height;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0006F080 File Offset: 0x0006D280
		private void Button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0006F0A0 File Offset: 0x0006D2A0
		private void BtnLoadAcc_Click(object sender, EventArgs e)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag = this.cbbThuMuc.SelectedValue != null;
			if (flag)
			{
				text = this.cbbThuMuc.SelectedValue.ToString();
			}
			this.LoadCbbThuMuc();
			bool flag2 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkRGU2NrNVZPVlZoZWxVOQ==")))))))) && text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9"))))))));
			if (flag2)
			{
				this.indexCbbThuMucOld = -1;
				this.cbbThuMuc.SelectedValue = text;
			}
			else
			{
				this.isExcute_CbbThuMuc_SelectedIndexChanged = false;
				this.cbbThuMuc.SelectedValue = text;
				this.isExcute_CbbThuMuc_SelectedIndexChanged = true;
				this.LoadCbbTinhTrang(fChonThuMuc.lstChooseIdFilesFromBin);
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0006F24C File Offset: 0x0006D44C
		private List<string> GetIdFile()
		{
			List<string> result = null;
			try
			{
				string text = this.cbbThuMuc.SelectedValue.ToString();
				string a = text;
				if (!(a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9"))))))))))
				{
					if (!(a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkRGU2NrNVZPVlZoZWxVOQ=="))))))))))
					{
						result = new List<string>
						{
							this.cbbThuMuc.SelectedValue.ToString()
						};
					}
					else
					{
						result = CollectionHelper.CloneList(fChonThuMuc.lstChooseIdFilesFromBin);
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0006F394 File Offset: 0x0006D594
		private void LoadAccountFromFile(List<string> lstIdFile = null, string info = "", bool isGetActive = false)
		{
			try
			{
				this.dtgvAcc.Rows.Clear();
				bool flag = info == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wR1ZXRklWbmhXYWtKS1VqRkNiMlJZUms1YU1sSk9WRE5PYVdKWFpHNWFSV2hOWVVoV2VGSnVWbUZOVkVFNQ==")))))))) || info == Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wR1ZXRklWbmhXYWtKS1VqRkNiMlJZUms1YU1sSk9WRE5PYVdKWFpHNWFSV2hOWVVoV2VGSnVWbUZOVkVFNQ==")))))))));
				if (flag)
				{
					info = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				}
				DataTable accFromFile = CommonSQL.GetAccFromFile(lstIdFile, info, isGetActive);
				this.LoadDtgvAccFromDatatable(accFromFile);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0006F518 File Offset: 0x0006D718
		private void LoadDtgvAccFromDatatable(DataTable tableAccount)
		{
			for (int i = 0; i < tableAccount.Rows.Count; i++)
			{
				DataRow dataRow = tableAccount.Rows[i];
				this.dtgvAcc.Rows.Add(new object[]
				{
					false,
					this.dtgvAcc.RowCount + 1,
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VsQlJQVDA9"))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRjNQVDA9"))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XTnNjRmhPUkRBOQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoT1ZWUXdPUT09"))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhrZWpBOQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa2IyUnRTblJXVkRBOQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRkpRVkRBOQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIwd05XTXlTa2hQVkUwOQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIwMVMyTkdjRmhPVjNScVpIb3dPUT09"))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwT1MyUnRVbGxSYm04OQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeGMyVlhVa2hoUjNSYVYwZHpPUT09"))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwS1YyUldjRWhXYm1zOQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ=="))))))))],
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))),
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWGxOVjJob1ZqTmpPUT09"))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1NOQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFJtVlJQVDA9"))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1QySkhUblJTYlRWaFZucFZkdz09"))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnRWa2xoZWpBOQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwMUdjRlpVYm14aFZqQlpkMWRzVmtkaGJHd3pVRlF3UFE9PQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1lXRkhVa2hTYm1zOQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnNjSFJpU0U1aFZWUXdPUT09"))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRlpYYmtKcFVqRlZPUT09"))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1VMUdjRmxUYldoYVRURktSMWx0TVZKUVVUMDk="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1XSlhTak5RVkRBOQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwS2IyTkdSWGxoUkVVOQ=="))))))))],
					dataRow[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwMUdjRlpWYlhocFVqRlpkMWRzUlRsUVVUMDk="))))))))],
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))
				});
			}
			this.CountCheckedAccount(0);
			this.SetRowColor(-1);
			this.CountTotalAccount();
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0006FED4 File Offset: 0x0006E0D4
		private void SetRowColor(int indexRow, int typeColor)
		{
			if (typeColor != 1)
			{
				if (typeColor == 2)
				{
					this.dtgvAcc.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
				}
			}
			else
			{
				this.dtgvAcc.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0006FF90 File Offset: 0x0006E190
		private void SetRowColor(int indexRow = -1)
		{
			this.LoadSetting();
			bool flag = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRSYlRsYVZucFdSRmxXWkZkTlJsSllVbXBGUFE9PQ==")))))))), 0) == 0;
			if (flag)
			{
				bool flag2 = indexRow == -1;
				if (flag2)
				{
					for (int i = 0; i < this.dtgvAcc.RowCount; i++)
					{
						string infoAccount = this.GetInfoAccount(i);
						bool flag3 = infoAccount == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ=="))))))));
						if (flag3)
						{
							this.dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
						}
						else
						{
							bool flag4 = infoAccount.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9"))))))))) || infoAccount.Contains(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk=")))))))))) || infoAccount.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhTblJhUjNoaFVUQktNMWRXYUU5bFp6MDk=")))))))));
							if (flag4)
							{
								this.dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
							}
						}
					}
				}
				else
				{
					string infoAccount2 = this.GetInfoAccount(indexRow);
					bool flag5 = infoAccount2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ=="))))))));
					if (flag5)
					{
						this.dtgvAcc.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					}
					else
					{
						bool flag6 = infoAccount2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9"))))))))) || infoAccount2.Contains(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk=")))))))))) || infoAccount2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhTblJhUjNoaFVUQktNMWRXYUU5bFp6MDk=")))))))));
						if (flag6)
						{
							this.dtgvAcc.Rows[indexRow].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
						}
					}
				}
			}
			else
			{
				bool flag7 = indexRow == -1;
				if (flag7)
				{
					for (int j = 0; j < this.dtgvAcc.RowCount; j++)
					{
						string infoAccount3 = this.GetInfoAccount(j);
						bool flag8 = infoAccount3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ=="))))))));
						if (flag8)
						{
							this.dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Green;
						}
						else
						{
							bool flag9 = infoAccount3.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9"))))))))) || infoAccount3.Contains(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk=")))))))))) || infoAccount3.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhTblJhUjNoaFVUQktNMWRXYUU5bFp6MDk=")))))))));
							if (flag9)
							{
								this.dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Red;
							}
						}
					}
				}
				else
				{
					string infoAccount4 = this.GetInfoAccount(indexRow);
					bool flag10 = infoAccount4 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ=="))))))));
					if (flag10)
					{
						this.dtgvAcc.Rows[indexRow].DefaultCellStyle.ForeColor = Color.Green;
					}
					else
					{
						bool flag11 = infoAccount4.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9"))))))))) || infoAccount4.Contains(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk=")))))))))) || infoAccount4.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhTblJhUjNoaFVUQktNMWRXYUU5bFp6MDk=")))))))));
						if (flag11)
						{
							this.dtgvAcc.Rows[indexRow].DefaultCellStyle.ForeColor = Color.Red;
						}
					}
				}
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00070800 File Offset: 0x0006EA00
		public void SetStatusAccount(int indexRow, string value)
		{
			DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), value);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00070870 File Offset: 0x0006EA70
		public void SetInfoAccount(string id, int indexRow, string value)
		{
			DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ==")))))))), value);
			this.SetRowColor(indexRow);
			CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1XSlhTak5RVkRBOQ==")))))))), value);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0007094C File Offset: 0x0006EB4C
		public void SetCellAccount(int indexRow, string column, object value)
		{
			DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, column, value);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00070980 File Offset: 0x0006EB80
		public void SetCellAccount(int indexRow, int column, object value)
		{
			DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, indexRow, column, value);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000709B4 File Offset: 0x0006EBB4
		public string GetStatusAccount(int indexRow)
		{
			return DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))));
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00070A24 File Offset: 0x0006EC24
		public string GetInfoAccount(int indexRow)
		{
			return DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ==")))))))));
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00070A94 File Offset: 0x0006EC94
		public string GetCellAccount(int indexRow, string column)
		{
			return DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, indexRow, column);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00070AC8 File Offset: 0x0006ECC8
		public string GetCellAccount(int indexRow, int column)
		{
			return DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, indexRow, column);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00070AFC File Offset: 0x0006ECFC
		private void CountTotalAccount()
		{
			try
			{
				this.lblCountTotal.Text = this.dtgvAcc.Rows.Count.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00070B64 File Offset: 0x0006ED64
		private void CountCheckedAccount(int count = -1)
		{
			bool flag = count == -1;
			if (flag)
			{
				count = 0;
				for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
				{
					bool flag2 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
					if (flag2)
					{
						count++;
					}
				}
			}
			this.lblCountSelect.Text = count.ToString();
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00070C6C File Offset: 0x0006EE6C
		private void LoadRowColor(int rowIndex = -1)
		{
			this.LoadSetting();
			bool flag = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRSYlRsYVZucFdSRmxXWkZkTlJsSllVbXBGUFE9PQ==")))))))), 0) == 0;
			if (flag)
			{
				bool flag2 = rowIndex == -1;
				if (flag2)
				{
					for (int i = 0; i < this.dtgvAcc.RowCount; i++)
					{
						string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ==")))))))));
						bool flag3 = statusDataGridView == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ=="))))))));
						if (flag3)
						{
							this.dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
						}
						else
						{
							bool flag4 = statusDataGridView.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9"))))))))) || statusDataGridView.Contains(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk=")))))))))) || statusDataGridView.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhTblJhUjNoaFVUQktNMWRXYUU5bFp6MDk=")))))))));
							if (flag4)
							{
								this.dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
							}
						}
					}
				}
				else
				{
					string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, rowIndex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ==")))))))));
					string a = statusDataGridView2;
					if (!(a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ=="))))))))))
					{
						if (a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9")))))))))
						{
							this.dtgvAcc.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
						}
					}
					else
					{
						this.dtgvAcc.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					}
				}
			}
			else
			{
				bool flag5 = rowIndex == -1;
				if (flag5)
				{
					for (int j = 0; j < this.dtgvAcc.RowCount; j++)
					{
						string statusDataGridView3 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ==")))))))));
						bool flag6 = statusDataGridView3.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9"))))))))) || statusDataGridView3.Contains(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk="))))))))));
						if (flag6)
						{
							this.dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Red;
						}
					}
				}
				else
				{
					string statusDataGridView4 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, rowIndex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ==")))))))));
					string a2 = statusDataGridView4;
					if (!(a2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ=="))))))))))
					{
						if (a2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9")))))))))
						{
							this.dtgvAcc.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
						}
					}
				}
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000713B8 File Offset: 0x0006F5B8
		private void LoadStatusGrid(string status, string colname, int rowIndex, int typeColor, DataGridView gv)
		{
			bool flag = !this.isLookStatus;
			if (flag)
			{
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, rowIndex, colname, status);
			}
			bool flag2 = colname == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ=="))))))));
			if (flag2)
			{
				this.LoadRowColor(rowIndex);
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0007146C File Offset: 0x0006F66C
		private void ChoseRowInDatagrid(string modeChose)
		{
			if (!(modeChose == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaa05HTjNQVDA9"))))))))))
			{
				if (!(modeChose == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14ak1WRnRTa2hrZWpBOQ=="))))))))))
				{
					if (!(modeChose == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSS1YyTXhjRmhVYWtKVVVqSjRkVmxWWkRSalIwcDBWbFF3UFE9PQ=="))))))))))
					{
						if (modeChose == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10ak5XSnNiM2xsUjNoU1RXMW9jMWRVU25wUVVUMDk=")))))))))
						{
							for (int i = 0; i < this.dtgvAcc.SelectedRows.Count; i++)
							{
								int index = this.dtgvAcc.SelectedRows[i].Index;
								this.SetCellAccount(index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ==")))))))), !Convert.ToBoolean(this.GetCellAccount(index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ==")))))))))));
							}
							this.CountCheckedAccount(-1);
						}
					}
					else
					{
						DataGridViewSelectedRowCollection selectedRows = this.dtgvAcc.SelectedRows;
						for (int j = 0; j < selectedRows.Count; j++)
						{
							this.SetCellAccount(selectedRows[j].Index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ==")))))))), true);
						}
						this.CountCheckedAccount(-1);
					}
				}
				else
				{
					for (int k = 0; k < this.dtgvAcc.RowCount; k++)
					{
						this.SetCellAccount(k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ==")))))))), false);
					}
					this.CountCheckedAccount(0);
				}
			}
			else
			{
				for (int l = 0; l < this.dtgvAcc.RowCount; l++)
				{
					this.SetCellAccount(l, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ==")))))))), true);
				}
				this.CountCheckedAccount(this.dtgvAcc.RowCount);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000718F8 File Offset: 0x0006FAF8
		private void CopyRowDatagrid(string modeCopy)
		{
			try
			{
				List<string> list = new List<string>();
				for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
				{
					bool flag = Convert.ToBoolean(DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))));
					if (flag)
					{
						list.Add(DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))));
						break;
					}
				}
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkU5aWVsSnBaRlUxYVdGVlNuSlhWbU14WWpCc1NWVkZVblpXTURWMlUxVm9WVkpIT1VoaE1tUm9UVzFvTWs1SFNuaGhiVXB3VVc1U2ExcFZZek5oTVdNd1dqRnJlVTlZWkd4Vk1FbDNXVlV4VUUxSFNuUlpNbVJyVWpKNE1WTldSVGxRVVQwOQ=="))))))))), 3);
				}
				else
				{
					string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					uint num = <PrivateImplementationDetails>.ComputeStringHash(modeCopy);
					if (num <= 2071622424U)
					{
						if (num <= 1329202400U)
						{
							if (num <= 457434463U)
							{
								if (num != 159575910U)
								{
									if (num == 457434463U)
									{
										if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRXlXa2xSYldocVRUQTBORnBGWXpWamJIQllUbFJvV2sxcWJESlpWRXB6WWtFOVBRPT0=")))))))))
										{
											for (int j = 0; j < this.dtgvAcc.RowCount; j++)
											{
												bool flag3 = Convert.ToBoolean(this.dtgvAcc.Rows[j].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
												if (flag3)
												{
													try
													{
														text = string.Concat(new string[]
														{
															text,
															DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))),
															Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
															DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))))),
															Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
															DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ=="))))))))),
															Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
															DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))))),
															Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))))
														});
													}
													catch
													{
													}
												}
											}
											Clipboard.SetText(text);
										}
									}
								}
								else if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRXlXa2xSYldocVRUQXdPUT09")))))))))
								{
									for (int k = 0; k < this.dtgvAcc.RowCount; k++)
									{
										bool flag4 = Convert.ToBoolean(this.dtgvAcc.Rows[k].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
										if (flag4)
										{
											try
											{
												text = string.Concat(new string[]
												{
													text,
													DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))),
													Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
													DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))))),
													Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))))
												});
											}
											catch
											{
											}
										}
									}
									Clipboard.SetText(text);
								}
							}
							else if (num != 738560386U)
							{
								if (num == 1329202400U)
								{
									if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTa2xsU0dSYVYwVTFObGxzWkVkalIwcENVRlF3UFE9PQ==")))))))))
									{
										for (int l = 0; l < this.dtgvAcc.RowCount; l++)
										{
											bool flag5 = Convert.ToBoolean(this.dtgvAcc.Rows[l].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
											if (flag5)
											{
												try
												{
													text = string.Concat(new string[]
													{
														text,
														DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, l, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ=="))))))))),
														Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
														DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, l, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYXpWYVZqSjRlZz09"))))))))),
														Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))))
													});
												}
												catch
												{
												}
											}
										}
										Clipboard.SetText(text);
									}
								}
							}
							else if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1JtVldjSFJTVkRBOQ==")))))))))
							{
								for (int m = 0; m < this.dtgvAcc.RowCount; m++)
								{
									bool flag6 = Convert.ToBoolean(this.dtgvAcc.Rows[m].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
									if (flag6)
									{
										try
										{
											text = text + Common.GetTotp(DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, m, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ==")))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))));
										}
										catch
										{
										}
									}
								}
								Clipboard.SetText(text);
							}
						}
						else if (num <= 1718322808U)
						{
							if (num != 1556604621U)
							{
								if (num == 1718322808U)
								{
									if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZjeFlXRkJQVDA9")))))))))
									{
										for (int n = 0; n < this.dtgvAcc.RowCount; n++)
										{
											bool flag7 = Convert.ToBoolean(this.dtgvAcc.Rows[n].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
											if (flag7)
											{
												try
												{
													text = text + DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, n, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ=="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))));
												}
												catch
												{
												}
											}
										}
										Clipboard.SetText(text);
									}
								}
							}
							else if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRjNQVDA9")))))))))
							{
								for (int num2 = 0; num2 < this.dtgvAcc.RowCount; num2++)
								{
									bool flag8 = Convert.ToBoolean(this.dtgvAcc.Rows[num2].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
									if (flag8)
									{
										try
										{
											text = text + DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))));
										}
										catch
										{
										}
									}
								}
								Clipboard.SetText(text);
							}
						}
						else if (num != 2007449791U)
						{
							if (num == 2071622424U)
							{
								if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))))
								{
									for (int num3 = 0; num3 < this.dtgvAcc.RowCount; num3++)
									{
										bool flag9 = Convert.ToBoolean(this.dtgvAcc.Rows[num3].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
										if (flag9)
										{
											try
											{
												text = text + DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))));
											}
											catch
											{
											}
										}
									}
									Clipboard.SetText(text);
								}
							}
						}
						else if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNjOQ==")))))))))
						{
							for (int num4 = 0; num4 < this.dtgvAcc.RowCount; num4++)
							{
								bool flag10 = Convert.ToBoolean(this.dtgvAcc.Rows[num4].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
								if (flag10)
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))));
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
						}
					}
					else if (num <= 2491017778U)
					{
						if (num <= 2337339239U)
						{
							if (num != 2107770459U)
							{
								if (num == 2337339239U)
								{
									if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1QySkhUblJTYlRWaFZucFZkdz09")))))))))
									{
										for (int num5 = 0; num5 < this.dtgvAcc.RowCount; num5++)
										{
											bool flag11 = Convert.ToBoolean(this.dtgvAcc.Rows[num5].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
											if (flag11)
											{
												try
												{
													text = text + DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num5, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))));
												}
												catch
												{
												}
											}
										}
										Clipboard.SetText(text);
									}
								}
							}
							else if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnRWa2xoZWpBOQ==")))))))))
							{
								for (int num6 = 0; num6 < this.dtgvAcc.RowCount; num6++)
								{
									bool flag12 = Convert.ToBoolean(this.dtgvAcc.Rows[num6].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
									if (flag12)
									{
										try
										{
											text = text + DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num6, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ=="))))))))).Split(new char[]
											{
												'*'
											})[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))));
										}
										catch
										{
										}
									}
								}
								Clipboard.SetText(text);
							}
						}
						else if (num != 2369371622U)
						{
							if (num == 2491017778U)
							{
								if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XTnNjRmhPUkRBOQ==")))))))))
								{
									for (int num7 = 0; num7 < this.dtgvAcc.RowCount; num7++)
									{
										bool flag13 = Convert.ToBoolean(this.dtgvAcc.Rows[num7].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
										if (flag13)
										{
											try
											{
												text = text + DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num7, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ=="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))));
											}
											catch
											{
											}
										}
									}
									Clipboard.SetText(text);
								}
							}
						}
						else if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRkpRVkRBOQ==")))))))))
						{
							for (int num8 = 0; num8 < this.dtgvAcc.RowCount; num8++)
							{
								bool flag14 = Convert.ToBoolean(this.dtgvAcc.Rows[num8].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
								if (flag14)
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num8, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))));
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text.TrimEnd(new char[]
							{
								'\r',
								'\n'
							}));
						}
					}
					else if (num <= 3144981877U)
					{
						if (num != 2703251604U)
						{
							if (num == 3144981877U)
							{
								if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRXlXa2xSYldocVRUQTBORlJYTVdGaFFUMDk=")))))))))
								{
									for (int num9 = 0; num9 < this.dtgvAcc.RowCount; num9++)
									{
										bool flag15 = Convert.ToBoolean(this.dtgvAcc.Rows[num9].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
										if (flag15)
										{
											try
											{
												text = string.Concat(new string[]
												{
													text,
													DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num9, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))),
													Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
													DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num9, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))))),
													Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
													DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num9, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ=="))))))))),
													Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))))
												});
											}
											catch
											{
											}
										}
									}
									Clipboard.SetText(text);
								}
							}
						}
						else if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRXlXa2xSYldocVRUQTBORnBGWXpWamJIQllUbFJvV2sxcWJESlpWRXB6WWtkYVNFMVhhR2hXTTJjMFdUQmtSMlZ0VFhsTlYyaG9Wak5qT1E9PQ==")))))))))
						{
							for (int num10 = 0; num10 < this.dtgvAcc.RowCount; num10++)
							{
								bool flag16 = Convert.ToBoolean(this.dtgvAcc.Rows[num10].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
								if (flag16)
								{
									try
									{
										text = string.Concat(new string[]
										{
											text,
											DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num10, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))),
											Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
											DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num10, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))))),
											Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
											DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num10, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ=="))))))))),
											Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
											DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num10, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))))),
											Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
											DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num10, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ=="))))))))),
											Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
											DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num10, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYXpWYVZqSjRlZz09"))))))))),
											Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))))
										});
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
						}
					}
					else if (num != 3728375369U)
					{
						if (num != 3968918830U)
						{
							if (num == 4025178668U)
							{
								if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeGMyVlhVa2hoUjNSYVYwZHpPUT09")))))))))
								{
									for (int num11 = 0; num11 < this.dtgvAcc.RowCount; num11++)
									{
										bool flag17 = Convert.ToBoolean(this.dtgvAcc.Rows[num11].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
										if (flag17)
										{
											try
											{
												text = text + DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num11, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1MyTkhUblZWYlRsaFVqQlpNUT09"))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))));
											}
											catch
											{
											}
										}
									}
									Clipboard.SetText(text.TrimEnd(new char[]
									{
										'\r',
										'\n'
									}));
								}
							}
						}
						else if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTa0pRVkRBOQ==")))))))))
						{
							for (int num12 = 0; num12 < this.dtgvAcc.RowCount; num12++)
							{
								bool flag18 = Convert.ToBoolean(this.dtgvAcc.Rows[num12].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
								if (flag18)
								{
									try
									{
										text = text + DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num12, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ=="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))));
									}
									catch
									{
									}
								}
							}
							Clipboard.SetText(text);
						}
					}
					else if (modeCopy == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRXlXa2xSYldocVRUQTBORnBGWXpWamJIQllUbFJvV2sxcWJESlpWRXB6WWtkYVNFMVhhR2hXTTJjMFdUQmtSMlZ0VFhsTlYyaG9Wak5uTkZkdE1VWmxVVDA5")))))))))
					{
						for (int num13 = 0; num13 < this.dtgvAcc.RowCount; num13++)
						{
							bool flag19 = Convert.ToBoolean(this.dtgvAcc.Rows[num13].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
							if (flag19)
							{
								try
								{
									text = string.Concat(new string[]
									{
										text,
										DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num13, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))),
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num13, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))))),
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num13, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ=="))))))))),
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num13, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))))),
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num13, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ=="))))))))),
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num13, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYXpWYVZqSjRlZz09"))))))))),
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
										DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, num13, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ=="))))))))),
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))))
									});
								}
								catch
								{
								}
							}
						}
						Clipboard.SetText(text);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000749E8 File Offset: 0x00072BE8
		private void TấtCảToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ChoseRowInDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaa05HTjNQVDA9")))))))));
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00074A48 File Offset: 0x00072C48
		private void LiveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ChoseRowInDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSS1YyTXhjRmhVYWtKVVVqSjRkVmxWWkRSalIwcDBWbFF3UFE9PQ==")))))))));
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00074AA8 File Offset: 0x00072CA8
		private void BỏChọnTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ChoseRowInDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14ak1WRnRTa2hrZWpBOQ==")))))))));
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00074B08 File Offset: 0x00072D08
		private void TokenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XTnNjRmhPUkRBOQ==")))))))));
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00074B68 File Offset: 0x00072D68
		private void CookieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNjOQ==")))))))));
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00074BC8 File Offset: 0x00072DC8
		private void UidToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRjNQVDA9")))))))));
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00074C28 File Offset: 0x00072E28
		private void PassToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))));
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00074C88 File Offset: 0x00072E88
		private void UidPassToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRXlXa2xSYldocVRUQXdPUT09")))))))));
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00074CE8 File Offset: 0x00072EE8
		private void UidPassTokenCookieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRXlXa2xSYldocVRUQTBORnBGWXpWamJIQllUbFJvV2sxcWJESlpWRXB6WWtFOVBRPT0=")))))))));
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00069C18 File Offset: 0x00067E18
		private void FMain_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00074D48 File Offset: 0x00072F48
		private void CtmsAcc_Opening(object sender, CancelEventArgs e)
		{
			this.trạngTháiToolStripMenuItem.DropDownItems.Clear();
			List<string> list = new List<string>();
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			for (int i = 0; i < this.dtgvAcc.RowCount; i++)
			{
				text = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))));
				bool flag = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					text2 = Regex.Match(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWT2IxTnNWa1ZpTW1STVVYcFNlRlZJYkhOWk1IUlNVRlF3UFE9PQ=="))))))))).Value;
					bool flag2 = text2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag2)
					{
						text = text.Replace(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Trim();
					}
					text2 = Regex.Match(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWYWVtSXdlSEJpZVRsTVZtNW9hdz09"))))))))).Value;
					bool flag3 = text2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag3)
					{
						text = text.Replace(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Trim();
					}
					bool flag4 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) && !list.Contains(text);
					if (flag4)
					{
						list.Add(text);
					}
				}
			}
			for (int j = 0; j < list.Count; j++)
			{
				this.trạngTháiToolStripMenuItem.DropDownItems.Add(list[j]);
				this.trạngTháiToolStripMenuItem.DropDownItems[j].Click += this.SelectGridByStatus;
			}
			this.tinhTrangToolStripMenuItem.DropDownItems.Clear();
			list = new List<string>();
			for (int k = 0; k < this.dtgvAcc.RowCount; k++)
			{
				bool flag5 = this.dtgvAcc.Rows[k].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ=="))))))))].Value != null && !DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ=="))))))))).Equals(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) && !list.Contains(DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ=="))))))))));
				if (flag5)
				{
					list.Add(DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, k, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ=="))))))))));
				}
			}
			for (int l = 0; l < list.Count; l++)
			{
				this.tinhTrangToolStripMenuItem.DropDownItems.Add(list[l]);
				this.tinhTrangToolStripMenuItem.DropDownItems[l].Click += this.SelectGridByStatus1;
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00075470 File Offset: 0x00073670
		private void SelectGridByStatus1(object sender, EventArgs e)
		{
			for (int i = 0; i < this.dtgvAcc.RowCount; i++)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
				string text = toolStripMenuItem.Text;
				bool flag = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyUldjSFJQUkRBOQ=="))))))))).Equals(text);
				if (flag)
				{
					this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = true;
				}
				else
				{
					this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = false;
				}
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00075618 File Offset: 0x00073818
		private void SelectGridByStatus(object sender, EventArgs e)
		{
			for (int i = 0; i < this.dtgvAcc.RowCount; i++)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
				string text = toolStripMenuItem.Text;
				bool flag = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09"))))))))).Contains(text);
				if (flag)
				{
					this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = true;
				}
				else
				{
					this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = false;
				}
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000757C0 File Offset: 0x000739C0
		private void DeleteAccount()
		{
			List<string> list = new List<string>();
			for (int i = 0; i < this.dtgvAcc.RowCount; i++)
			{
				bool flag = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
				if (flag)
				{
					list.Add(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))].Value.ToString());
				}
			}
			bool flag2 = list.Count == 0;
			if (flag2)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkU5aWVsSnBaRlUxYVdGVlNYZGtlbHBEWTBWc1NHUkhPV2xMTUdNeVlucEpNRm94YTNKU2VscDNUV3BTYmxwVk1WQmxiR3hVVWxRd1BRPT0="))))))))), 3);
			}
			else
			{
				bool flag3 = MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WYUZOaWVsSnBaRmhvV21WVlNqWk9SMG94WlVWc1NFMVVSVEJaYmxaVFdXMXNRMDVJWXpOVWJXaEtVMGhPTTFwc1RrTk5TR015VVc1Q1NsSXpVblpaYVhSSVRtMDRlVTVIWkRSVGEyaEZZak5zUTJGdFJsQlNlbVJ4Vm5wUmRnPT0="))))))))), this.CountChooseRowInDatagridview()) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsUnJUbTVRVkRBOQ==")))))))) + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IwMVljRXBTVjJSc1dUTnNRMVF5YkVOV1ZteHFaVlZHYUZVd1NubFpWV00xWVVod1NtSklWa3BVVms1VFYxZE9OVkpGYkVsaFNGbzJVMVZhYjFOVmFGTmlNa1pxWlZWR1NsSXpVblprZW1SVFpGWndOVkZxUW1oVVZUbDRaV3RzY2xveVJYbGhhMUl3VWpKMGJsa3daRzlOV0hCTVZHMXdTbEl6YUc5bGEzUlBZMFZzVGxVeFNqUmphMUpJWWpKT05XRnNiRFZSYmxZMFkydFNUbHA2U2taaFFUMDk=")))))))))) == DialogResult.Yes;
				if (flag3)
				{
					bool flag4 = CommonSQL.DeleteAccountToDatabase(list, true);
					if (flag4)
					{
						for (int j = 0; j < this.dtgvAcc.RowCount; j++)
						{
							bool flag5 = Convert.ToBoolean(this.dtgvAcc.Rows[j].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
							if (flag5)
							{
								this.dtgvAcc.Rows.RemoveAt(j--);
							}
						}
						bool flag6 = CommonSQL.DeleteFileToDatabaseIfEmptyAccount();
						if (flag6)
						{
							this.RefreshDtgvAcc();
						}
					}
					else
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpBeFVHVnNiRlJSYWtKb1ZEQmpNbU5HYUZKYU1Xd3hVbnBhZGxZeWRIcFRWV2hoVFZkR1ZGRnVUak5PTUhBeFYyNXNRMDFIUmxCU2VtUjVWVEJLZWs1SFNuaGhSMFpVVVc1d1dsZEdWbTg9"))))))))), 2);
					}
					this.UpdateSTTOnDtgvAcc();
				}
				this.UpdateTotalCountRecord();
				this.UpdateSelectCountRecord();
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00075BEC File Offset: 0x00073DEC
		private void RefreshDtgvAcc()
		{
			this.LoadRowColor(-1);
			this.UpdateSTTOnDtgvAcc();
			this.UpdateTotalCountRecord();
			this.UpdateSelectCountRecord();
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00075C30 File Offset: 0x00073E30
		private bool CheckIsUidFacebook(string uid)
		{
			return Common.IsNumber(uid) && !uid.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9")))))))));
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00075CB8 File Offset: 0x00073EB8
		private void cControl(string dt)
		{
			base.Invoke(new MethodInvoker(delegate()
			{
				try
				{
					bool flag = dt == "start";
					if (flag)
					{
						this.grTimKiem.Enabled = false;
						this.grQuanLyThuMuc.Enabled = false;
					}
					else
					{
						bool flag2 = dt == "stop";
						if (flag2)
						{
							this.grTimKiem.Enabled = true;
							this.grQuanLyThuMuc.Enabled = true;
						}
					}
				}
				catch (Exception ex)
				{
				}
			}));
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00075CFC File Offset: 0x00073EFC
		private void DtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			bool flag = e.ColumnIndex == 0;
			if (flag)
			{
				try
				{
					this.dtgvAcc.CurrentRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = !Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
					this.CountCheckedAccount(-1);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00075E3C File Offset: 0x0007403C
		private void DtgvAcc_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyValue == 32;
			if (flag)
			{
				this.ChoseRowInDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10ak5XSnNiM2xsUjNoU1RXMW9jMWRVU25wUVVUMDk=")))))))));
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00075EB4 File Offset: 0x000740B4
		private void LoadStatusDatagridView(int row, string status)
		{
			bool flag = !this.isLookStatus;
			if (flag)
			{
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), status);
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00075F40 File Offset: 0x00074140
		private void TảiLạiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BtnLoadAcc_Click(null, null);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00075F5C File Offset: 0x0007415C
		private void CbbFileAccount_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.isExcute_CbbThuMuc_SelectedIndexChanged;
			if (!flag)
			{
				bool flag2 = this.cbbThuMuc.SelectedValue == null || !StringHelper.CheckStringIsNumber(this.cbbThuMuc.SelectedValue.ToString());
				if (!flag2)
				{
					bool flag3 = this.cbbThuMuc.SelectedValue.ToString() != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkRGU2NrNVZPVlZoZWxVOQ==")))))))) && this.indexCbbThuMucOld == this.cbbThuMuc.SelectedIndex;
					if (!flag3)
					{
						string text = this.cbbThuMuc.SelectedValue.ToString();
						string a = text;
						if (!(a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9"))))))))))
						{
							if (!(a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkRGU2NrNVZPVlZoZWxVOQ=="))))))))))
							{
								this.LoadCbbTinhTrang(this.GetIdFile());
							}
							else
							{
								Common.ShowForm(new fChonThuMuc(true));
								bool flag4 = !fChonThuMuc.isAdd || fChonThuMuc.lstChooseIdFilesFromBin == null || fChonThuMuc.lstChooseIdFilesFromBin.Count == 0;
								if (flag4)
								{
									this.isExcute_CbbThuMuc_SelectedIndexChanged = false;
									this.cbbThuMuc.SelectedIndex = ((this.indexCbbThuMucOld == -1) ? 0 : this.indexCbbThuMucOld);
									this.isExcute_CbbThuMuc_SelectedIndexChanged = true;
								}
								else
								{
									this.LoadCbbTinhTrang(fChonThuMuc.lstChooseIdFilesFromBin);
								}
							}
						}
						else
						{
							this.LoadCbbTinhTrang(null);
						}
						this.indexCbbThuMucOld = this.cbbThuMuc.SelectedIndex;
					}
				}
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00076238 File Offset: 0x00074438
		private void MailPassMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTa2xsU0dSYVYwVTFObGxzWkVkalIwcENVRlF3UFE9PQ==")))))))));
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00076298 File Offset: 0x00074498
		private void UidPassTokenCookieMailPassMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRXlXa2xSYldocVRUQTBORnBGWXpWamJIQllUbFJvV2sxcWJESlpWRXB6WWtkYVNFMVhhR2hXTTJjMFdUQmtSMlZ0VFhsTlYyaG9Wak5qT1E9PQ==")))))))));
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000762F8 File Offset: 0x000744F8
		private void UpdateSelectCountRecord()
		{
			int num = 0;
			for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
			{
				bool flag = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
				if (flag)
				{
					num++;
				}
			}
			try
			{
				this.lblCountSelect.Text = num.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00076404 File Offset: 0x00074604
		private void checkAvatarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fNhapTokenTrungGian());
			bool isOK = fNhapTokenTrungGian.isOK;
			if (isOK)
			{
				this.LoadSetting();
				string token = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XTnNjRmhPUkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				bool flag = !CommonRequest.CheckLiveToken(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), token, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkRCalJGSnBaRlZTYVZVd1NYZFpNakZHV2pKS1VGSjZXblpXTW5SdVdrVmpOV05zY0ZoT1IyUnJVMFZ2ZUZsdE1XcGFNVzk1WWtkb2FXRlZWVGs9"))))))))), 1);
				}
				else
				{
					int iThread = 0;
					int maxThread = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUa2hpUjNSaFZteEtkbGt5TVZkaFJuQkNVRlF3UFE9PQ==")))))))), 10);
					this.isStop = false;
					new Thread(delegate()
					{
						this.cControl("start");
						int i = 0;
						while (i < this.dtgvAcc.Rows.Count)
						{
							Application.DoEvents();
							bool flag2 = this.isStop;
							if (flag2)
							{
								break;
							}
							bool flag3 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells["cChose"].Value);
							if (flag3)
							{
								bool flag4 = iThread < maxThread;
								if (flag4)
								{
									Interlocked.Increment(ref iThread);
									int row = i++;
									new Thread(delegate()
									{
										this.LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row, 0, this.dtgvAcc);
										this.CheckMyAvatar(row, token);
										Interlocked.Decrement(ref iThread);
									}).Start();
								}
								else
								{
									Application.DoEvents();
									Thread.Sleep(200);
								}
							}
							else
							{
								i++;
							}
						}
						int tickCount = Environment.TickCount;
						while (iThread > 0)
						{
							bool flag5 = Environment.TickCount - tickCount > 30000;
							if (flag5)
							{
								break;
							}
							Application.DoEvents();
							Thread.Sleep(300);
						}
						this.cControl("stop");
					}).Start();
				}
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000766C4 File Offset: 0x000748C4
		private void CheckMyAvatar(int row, string token)
		{
			try
			{
				string uid = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))].Value.ToString();
				string id = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))].Value.ToString();
				bool flag = CommonRequest.CheckAvatarFromUid(uid, token);
				bool flag2 = flag;
				if (flag2)
				{
					this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkljRXBVVjJSYVRXazVUbG94VGtOaFIxSjBVbXBDV2xkRmJHOD0="))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
					this.LoadStatusGrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpGa1YyVm5QVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1IwMXNiRmxWYldocVdub3dPUT09")))))))), row, 0, this.dtgvAcc);
					CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1lXRkhVa2hTYm1zOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpGa1YyVm5QVDA9")))))))));
				}
				else
				{
					this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFNbVZyYkVaYU1XeFpWMjFvYTFJd1dqVlRWa1U1VUZFOVBRPT0="))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
					this.LoadStatusGrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtjd05GQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1IwMXNiRmxWYldocVdub3dPUT09")))))))), row, 0, this.dtgvAcc);
					CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1lXRkhVa2hTYm1zOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtjd05GQlJQVDA9")))))))));
				}
			}
			catch
			{
				this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1oS1ZUQlZPUT09"))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00070AFC File Offset: 0x0006ECFC
		private void UpdateTotalCountRecord()
		{
			try
			{
				this.lblCountTotal.Text = this.dtgvAcc.Rows.Count.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00076C9C File Offset: 0x00074E9C
		private void OnLoaded(object sender, EventArgs e)
		{
			Application.Idle -= this.OnLoaded;
			this.LoadConfigManHinh();
			this.LoadCbbThuMuc();
			this.LoadCbbTinhTrang(null);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00076CE8 File Offset: 0x00074EE8
		private void LoadCbbThuMuc()
		{
			this.isExcute_CbbThuMuc_SelectedIndexChanged = false;
			DataTable allFilesFromDatabaseForBin = CommonSQL.GetAllFilesFromDatabaseForBin(true);
			this.cbbThuMuc.DataSource = allFilesFromDatabaseForBin;
			this.cbbThuMuc.ValueMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VsQlJQVDA9"))))))));
			this.cbbThuMuc.DisplayMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRkpRVkRBOQ=="))))))));
			this.isExcute_CbbThuMuc_SelectedIndexChanged = true;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00076DE0 File Offset: 0x00074FE0
		private void LoadCbbTinhTrang(List<string> lstIdFile = null)
		{
			try
			{
				DataTable allInfoFromAccount = CommonSQL.GetAllInfoFromAccount(lstIdFile, false);
				this.cbbTinhTrang.DataSource = allInfoFromAccount;
				this.cbbTinhTrang.ValueMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VsQlJQVDA9"))))))));
				this.cbbTinhTrang.DisplayMember = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRkpRVkRBOQ=="))))))));
			}
			catch
			{
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00076EE8 File Offset: 0x000750E8
		private void KiemTraTaiKhoan(int type)
		{
			this.LoadSetting();
			int iThread = 0;
			int maxThread = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUa2hpUjNSaFZteEtkbGt5TVZkaFJuQkNVRlF3UFE9PQ==")))))))), 10);
			string tokenTrungGian = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XTnNjRmhPUkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			this.isStop = false;
			new Thread(delegate()
			{
				this.cControl("start");
				switch (type)
				{
				case 0:
				{
					int i = 0;
					while (i < this.dtgvAcc.Rows.Count)
					{
						bool flag = this.isStop;
						if (flag)
						{
							break;
						}
						bool flag2 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells["cChose"].Value);
						if (flag2)
						{
							bool flag3 = iThread < maxThread;
							if (flag3)
							{
								Interlocked.Increment(ref iThread);
								int row = i++;
								new Thread(delegate()
								{
									this.LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row, 0, this.dtgvAcc);
									this.CheckMyWall(row, tokenTrungGian);
									Interlocked.Decrement(ref iThread);
								}).Start();
							}
							else
							{
								Application.DoEvents();
								Thread.Sleep(200);
							}
						}
						else
						{
							i++;
						}
					}
					break;
				}
				case 1:
				{
					int j = 0;
					while (j < this.dtgvAcc.Rows.Count)
					{
						bool flag4 = this.isStop;
						if (flag4)
						{
							break;
						}
						bool flag5 = Convert.ToBoolean(this.dtgvAcc.Rows[j].Cells["cChose"].Value);
						if (flag5)
						{
							bool flag6 = iThread < maxThread;
							if (flag6)
							{
								Interlocked.Increment(ref iThread);
								int row = j++;
								new Thread(delegate()
								{
									this.LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row, 0, this.dtgvAcc);
									this.CheckMyToken(row);
									Interlocked.Decrement(ref iThread);
								}).Start();
							}
							else
							{
								Application.DoEvents();
								Thread.Sleep(200);
							}
						}
						else
						{
							j++;
						}
					}
					break;
				}
				case 2:
				{
					int k = 0;
					while (k < this.dtgvAcc.Rows.Count)
					{
						bool flag7 = this.isStop;
						if (flag7)
						{
							break;
						}
						bool flag8 = Convert.ToBoolean(this.dtgvAcc.Rows[k].Cells["cChose"].Value);
						if (flag8)
						{
							bool flag9 = iThread < maxThread;
							if (flag9)
							{
								Interlocked.Increment(ref iThread);
								int row = k++;
								new Thread(delegate()
								{
									this.LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row, 0, this.dtgvAcc);
									this.CheckMyCookie(row);
									Interlocked.Decrement(ref iThread);
								}).Start();
							}
							else
							{
								Application.DoEvents();
								Thread.Sleep(200);
							}
						}
						else
						{
							k++;
						}
					}
					break;
				}
				case 3:
				{
					int l = 0;
					while (l < this.dtgvAcc.Rows.Count)
					{
						bool flag10 = this.isStop;
						if (flag10)
						{
							break;
						}
						bool flag11 = Convert.ToBoolean(this.dtgvAcc.Rows[l].Cells["cChose"].Value);
						if (flag11)
						{
							bool flag12 = iThread < maxThread;
							if (flag12)
							{
								Interlocked.Increment(ref iThread);
								int row = l++;
								new Thread(delegate()
								{
									this.LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row, 0, this.dtgvAcc);
									this.CheckDangCheckpoint(row);
									Interlocked.Decrement(ref iThread);
								}).Start();
							}
							else
							{
								Application.DoEvents();
								Thread.Sleep(200);
							}
						}
						else
						{
							l++;
						}
					}
					break;
				}
				case 4:
				{
					int m = 0;
					while (m < this.dtgvAcc.Rows.Count)
					{
						bool flag13 = this.isStop;
						if (flag13)
						{
							break;
						}
						bool flag14 = Convert.ToBoolean(this.dtgvAcc.Rows[m].Cells["cChose"].Value);
						if (flag14)
						{
							bool flag15 = iThread < maxThread;
							if (flag15)
							{
								Interlocked.Increment(ref iThread);
								int row = m++;
								new Thread(delegate()
								{
									this.LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row, 0, this.dtgvAcc);
									this.CheckAccountMail(row);
									Interlocked.Decrement(ref iThread);
								}).Start();
							}
							else
							{
								Application.DoEvents();
								Thread.Sleep(200);
							}
						}
						else
						{
							m++;
						}
					}
					break;
				}
				case 5:
				{
					int n = 0;
					while (n < this.dtgvAcc.Rows.Count)
					{
						bool flag16 = this.isStop;
						if (flag16)
						{
							break;
						}
						bool flag17 = Convert.ToBoolean(this.dtgvAcc.Rows[n].Cells["cChose"].Value);
						if (flag17)
						{
							bool flag18 = iThread < maxThread;
							if (flag18)
							{
								Interlocked.Increment(ref iThread);
								int row = n++;
								new Thread(delegate()
								{
									this.LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row, 0, this.dtgvAcc);
									this.CheckInfoUid(row);
									Interlocked.Decrement(ref iThread);
								}).Start();
							}
							else
							{
								Application.DoEvents();
								Thread.Sleep(200);
							}
						}
						else
						{
							n++;
						}
					}
					break;
				}
				}
				int tickCount = Environment.TickCount;
				while (iThread > 0)
				{
					bool flag19 = Environment.TickCount - tickCount > 60000;
					if (flag19)
					{
						break;
					}
					Common.DelayTime(1.0);
				}
				this.cControl("stop");
			}).Start();
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00077054 File Offset: 0x00075254
		private void CheckInfoUid(int row)
		{
			try
			{
				string cellAccount = this.GetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9")))))))));
				string cellAccount2 = this.GetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ==")))))))));
				bool flag = !this.CheckIsUidFacebook(cellAccount2);
				if (flag)
				{
					this.SetStatusAccount(row, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14a2MyRXdiRWhrUnprelRqRktNVmR1YkVOaWVsSnBaRmR3YWxFd1NucE9SMG94VTBWc1VsQlVNRDA9"))))))))));
				}
				else
				{
					string value = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					string text = CommonRequest.CheckInfoUsingUid(cellAccount2);
					bool flag2 = text.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9")))))))));
					if (flag2)
					{
						bool flag3 = CommonRequest.CheckLiveWall(cellAccount2).StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9")))))))));
						if (flag3)
						{
							this.SetStatusAccount(row, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVGb3lSbFJSYmtwb1VuazViMlJZUms5a1ZXeEdWVzVDWVZVd1ZUaz0="))))))))));
							this.SetInfoAccount(cellAccount, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9")))))))));
						}
						else
						{
							this.SetStatusAccount(row, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFkbGRzWkU5amEyeE9WVEZLTkdOclVraGlNazQxWVd4c05WSlVNRDA9"))))))))));
						}
					}
					else
					{
						bool flag4 = text.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))));
						if (flag4)
						{
							string[] array = text.Split(new char[]
							{
								'|'
							});
							string text2 = array[2];
							string text3 = array[3].ToLower();
							string text4 = array[4];
							string text5 = array[5];
							string text6 = array[6];
							CommonSQL.UpdateMultiFieldToAccount(cellAccount, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRmxsUnpWaFZucFdjbGRzYUV0UFJuQjFVMjVDWVZaNlZuSlplazQwWW0xT2RFOVVSbXBUUlRBNQ==")))))))), string.Concat(new string[]
							{
								text2,
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
								text3,
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
								text5,
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
								text6
							}), true);
							this.SetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ==")))))))), text2);
							this.SetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EySkhTblJWYlhocVdub3dPUT09")))))))), text3);
							this.SetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXVlhSbGhXYmxaaFVWUXdPUT09")))))))), text5);
							this.SetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EyVlhTWHBXYm1NOQ==")))))))), text6);
							bool flag5 = text4 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag5)
							{
								this.SetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1MyTkhUblZWYlRsaFVqQlpNUT09")))))))), text4);
								CommonSQL.UpdateFieldToAccount(cellAccount, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeGMyVlhVa2hoUjNSYVYwZHpPUT09")))))))), text4);
							}
							this.SetInfoAccount(cellAccount, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ==")))))))));
							value = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSb1VHRlljRXhVYm1SS1VucFdkbVI2V2sxVVZ6aDZWVmRrYTFJeWNFVmtSV014WW10c1NWVnVRbWxoVlVsM1dWVmtTVlJYWkVoT1Z6bEtVakZDUldSRll6RmlhMnhTVUZRd1BRPT0=")))))))));
							this.SetStatusAccount(row, value);
						}
						else
						{
							this.SetStatusAccount(row, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFkbGRzWkU5amEyeE9WVEZLTkdOclVraGlNazQxWVd4c05WSlVNRDA9"))))))))));
						}
					}
				}
			}
			catch
			{
				this.SetStatusAccount(row, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFkbGRzWkU5amEyeE9WVEZLTkdOclVraGlNazQxWVd4c05WSlVNRDA9"))))))))));
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000779C8 File Offset: 0x00075BC8
		private void CheckAccountMail(int row)
		{
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				text = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ=="))))))))].Value.ToString();
				text2 = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYXpWYVZqSjRlZz09"))))))))].Value.ToString();
				bool flag = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || text2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWlNSV05yWTNkYU1sSklZVzFvTVdOV1dURlRWV040WVVkR1dHUjZNRDA9"))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFaT1JtRkJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
				}
				else
				{
					bool flag2 = text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZWa2IyUnRVa2hOVjJob1ZqTmtNUT09"))))))))) || text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZWak5VMVhVa2hsU0ZwcFRXNU9NUT09")))))))));
					if (flag2)
					{
						string text3 = Common.CheckAccountHotmail(text, text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
						bool flag3 = text3.Equals(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9")))))))));
						if (flag3)
						{
							this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVGb3lSbFJSYmtwb1VuazViMlJZUms5a1ZXeElUVmRvYUZZell6SlRWV1EwWTBkU2RGWlhaejA9"))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 0, this.dtgvAcc);
						}
						else
						{
							this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVGb3lSbFJSYmtwb1VuazViMlJZUms5a1ZXeElUVmRvYUZZell6SlRWV1JUWTBad1ZGSlVNRDA9"))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 1, this.dtgvAcc);
						}
					}
					else
					{
						this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaa1IyTkhTa1JSYlhCb1ZGZEdNMWRXVGtOaWVsSnBaRlpvU2xOR1NqVk9SMG94WVdjOVBRPT0="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFaT1JtRkJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
					}
				}
			}
			catch
			{
				this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1oS1ZUQlZPUT09"))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000781A0 File Offset: 0x000763A0
		private void CheckMyWall(int row, string tokenTg)
		{
			try
			{
				string cellAccount = this.GetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9")))))))));
				string cellAccount2 = this.GetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ==")))))))));
				bool flag = !this.CheckIsUidFacebook(cellAccount2);
				if (flag)
				{
					this.SetStatusAccount(row, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14a2MyRXdiRWhrUnprelRqRktNVmR1YkVOaWVsSnBaRmR3YWxFd1NucE9SMG94VTBWc1VsQlVNRDA9"))))))))));
				}
				else
				{
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					string value = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					string text = CommonRequest.CheckLiveWall(cellAccount2);
					bool flag2 = text.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9")))))))));
					if (flag2)
					{
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a2MySkJQVDA9"))))))));
						value = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1wS1IyTXlTa1JSYlhSb1ZqRlZPUT09"))))))));
					}
					else
					{
						bool flag3 = text.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))));
						if (flag3)
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ=="))))))));
							value = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1wS1IyTXlTa1JSYms1b1YwWndjdz09"))))))));
						}
						else
						{
							value = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFkbGRzWkU5amEyeE9WVEZLTkdOclVraGlNazQxWVd4c05WSlVNRDA9")))))))));
						}
					}
					this.SetStatusAccount(row, value);
					bool flag4 = @string != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag4)
					{
						this.SetInfoAccount(cellAccount, row, @string);
					}
				}
			}
			catch
			{
				this.SetStatusAccount(row, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFkbGRzWkU5amEyeE9WVEZLTkdOclVraGlNazQxWVd4c05WSlVNRDA9"))))))))));
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00078698 File Offset: 0x00076898
		private void CheckMyToken(int row)
		{
			try
			{
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9")))))))));
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09")))))))));
				string statusDataGridView3 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ==")))))))));
				string text = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk=")))))))));
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				int typeProxy = 0;
				bool flag = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0) == 9;
				if (flag)
				{
					text2 = this.GetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ==")))))))));
					bool flag2 = text2.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
					if (flag2)
					{
						typeProxy = 1;
					}
					else
					{
						typeProxy = 0;
					}
					bool flag3 = text2.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1FsQlJQVDA9"))))))))) || text2.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
					if (flag3)
					{
						text2 = text2.Substring(0, text2.Length - 2);
					}
				}
				bool flag4 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || text2.Split(new char[]
				{
					':'
				}).Length == 4;
				if (flag4)
				{
					text = Base.useragentDefault;
				}
				string string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag5 = !CommonRequest.CheckLiveToken(statusDataGridView2, statusDataGridView3, text, text2, typeProxy);
				if (flag5)
				{
					string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10ak5XTnNjRmhPUjJSaFVqSjRjdz09"))))))));
				}
				else
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ=="))))))));
					string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10ak5XTnNjRmhPUjJScFVqSjNlVmRzUlRsUVVUMDk="))))))));
				}
				this.LoadStatusGrid(string2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
				bool flag6 = @string != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag6)
				{
					this.SetInfoAccount(statusDataGridView, row, @string);
				}
			}
			catch
			{
				this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFkbGRzWkU5amEyeE9WVEZLTkdOclVraGlNazQxWVd4c05WSlVNRDA9"))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00078E2C File Offset: 0x0007702C
		private void CheckMyCookie(int row)
		{
			try
			{
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9")))))))));
				string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09")))))))));
				string text = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk=")))))))));
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				int typeProxy = 0;
				bool flag = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0) == 9;
				if (flag)
				{
					text2 = this.GetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ==")))))))));
					bool flag2 = text2.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
					if (flag2)
					{
						typeProxy = 1;
					}
					else
					{
						typeProxy = 0;
					}
					bool flag3 = text2.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1FsQlJQVDA9"))))))))) || text2.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
					if (flag3)
					{
						text2 = text2.Substring(0, text2.Length - 2);
					}
				}
				bool flag4 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || text2.Split(new char[]
				{
					':'
				}).Length == 4;
				if (flag4)
				{
					text = Base.useragentDefault;
				}
				string string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag5 = !CommonRequest.CheckLiveCookie(statusDataGridView2, text, text2, typeProxy).StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))));
				if (flag5)
				{
					string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNoS1VqRktkMWRzUlRsUVVUMDk="))))))));
				}
				else
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ=="))))))));
					string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSk5XUnRSWGxpUjNoS1VqTm9kMXBITVZaUVVUMDk="))))))));
				}
				this.LoadStatusGrid(string2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
				bool flag6 = @string != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag6)
				{
					this.SetInfoAccount(statusDataGridView, row, @string);
				}
			}
			catch
			{
				this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFkbGRzWkU5amEyeE9WVEZLTkdOclVraGlNazQxWVd4c05WSlVNRDA9"))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000795A8 File Offset: 0x000777A8
		private void CheckDangCheckpoint(int row)
		{
			string id = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))].Value.ToString();
			string email = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))].Value.ToString();
			string pass = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))))].Value.ToString();
			string a = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk=")))))))));
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			int typeProxy = 0;
			bool flag = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0) == 9;
			if (flag)
			{
				text = this.GetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ==")))))))));
				bool flag2 = text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
				if (flag2)
				{
					typeProxy = 1;
				}
				else
				{
					typeProxy = 0;
				}
				bool flag3 = text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1FsQlJQVDA9"))))))))) || text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
				if (flag3)
				{
					text = text.Substring(0, text.Length - 2);
				}
			}
			bool flag4 = a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || text.Split(new char[]
			{
				':'
			}).Length == 4;
			if (flag4)
			{
				a = Base.useragentDefault;
			}
			string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text4 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text5 = CommonRequest.CheckFacebookAccount(email, pass, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), text, typeProxy);
			string text6 = text5.Split(new char[]
			{
				'|'
			})[0];
			string a2 = text6;
			if (!(a2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))))) && !(a2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkd0Rk9WQlJQVDA9"))))))))))
			{
				if (!(a2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkd4Rk9WQlJQVDA9"))))))))))
				{
					if (!(a2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9"))))))))))
					{
						if (!(a2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkak9WQlJQVDA9"))))))))))
						{
							if (a2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZoak9WQlJQVDA9")))))))))
							{
								text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhTblJhUjNoaFVUQktNMWRXYUU5bFp6MDk="))))))));
							}
						}
						else
						{
							bool flag5 = text5.Split(new char[]
							{
								'|'
							})[1].Trim() != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag5)
							{
								text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGVW5aYWR6MDk=")))))))) + text5.Split(new char[]
								{
									'|'
								})[1];
							}
							else
							{
								text2 = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk=")))))))));
							}
						}
					}
					else
					{
						text4 = text5.Split(new char[]
						{
							'|'
						})[1];
						text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWa2MwMXNjRkpRVkRBOQ=="))))))));
					}
				}
				else
				{
					text3 = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFkbGRzWkU5amEyeE9WVEZLTkdOclVraGlNazQxWVd4c05WRlhPVkpOYVRsT1dqRk9RbVZXY0hSU1dFSktWVlF3T1E9PQ==")))))))));
				}
			}
			else
			{
				text3 = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFkbGRzWkU5amEyeE9WVEZLTkdOclVraGlNazQxWVd4c05WSlVNRDA9")))))))));
			}
			bool flag6 = text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag6)
			{
				text3 = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkljRXBVVjJSYVRXMW9jMWRVU25wYU1sWklUMWhXWVdWVlZUaz0=")))))))));
			}
			bool flag7 = text4 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag7)
			{
				CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoT1ZWUXdPUT09")))))))), text4);
				this.LoadStatusGrid(text4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09")))))))), row, 1, this.dtgvAcc);
			}
			bool flag8 = text2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag8)
			{
				this.SetInfoAccount(id, row, text2);
			}
			this.LoadStatusGrid(text3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 1, this.dtgvAcc);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0007A2A8 File Offset: 0x000784A8
		private void KiểmTraWallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.KiemTraTaiKhoan(0);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0007A2C8 File Offset: 0x000784C8
		private void KiểmTraTokenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVHUkhTblJhTW1ScFl6Rk9SVmx0TVdwYU1rcDZWREprYkZVd1NuRmtlbVJPV2pKU1NHRnRhREZPUlRGdVdWUktiMk5FVW1salV6bHBZVlZKZDJSNldrTmpSV3hJWkVjNWFVc3dZekppZWtrd1dqRnNNVko2WkhCbFZVcDVXVlV4VUdWc2JGUmtNbVJhWkZWak1tSXhZekJhTWxJeFVucGFlRTFxVW01WmJHaFpZVWhWTVZKdVZrcFRSa0p2WkZSWmQxb3hjRkJTZW1SM1ZucFdkVlZJWXpsUVVUMDk=")))))))))) == DialogResult.Yes;
			if (flag)
			{
				this.KiemTraTaiKhoan(1);
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0007A344 File Offset: 0x00078544
		private void KiểmTraCookieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.KiemTraTaiKhoan(2);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0007A364 File Offset: 0x00078564
		private void KiểmTraTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.KiemTraTaiKhoan(3);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0007A384 File Offset: 0x00078584
		private void MailToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTa0pRVkRBOQ==")))))))));
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0007A3E4 File Offset: 0x000785E4
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cbbSearch.SelectedIndex == -1;
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkU5aWVsSnBaRlUxYVdGVlNubFpWMVpJVGpKamVsWlhaR3RVVlRsNldXeE9RMk50Um14U2Vsb3lUV3BDYnc9PQ=="))))))))), 1);
				}
				else
				{
					string columnName = this.cbbSearch.SelectedValue.ToString();
					string text = this.txbSearch.Text.Trim();
					bool flag2 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag2)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWXpGaWVsSnBZMWhTYWxFd1NqRk9SMG94VjIxR1ZGRnRkR3RXZWxaMVUxVm9WVkpJU2toTlIyUm9UVzAxYjJSWVNUVmtSV3hTVUZRd1BRPT0="))))))))), 1);
					}
					else
					{
						List<int> list = new List<int>();
						text = Common.ConvertToUnSign(text.ToLower());
						for (int i = 0; i < this.dtgvAcc.RowCount; i++)
						{
							string text2 = this.dtgvAcc.Rows[i].Cells[columnName].Value.ToString();
							text2 = Common.ConvertToUnSign(text2.ToLower());
							text = Common.ConvertToUnSign(text.ToLower());
							bool flag3 = text2.Contains(text);
							if (flag3)
							{
								list.Add(i);
							}
						}
						int index = 0;
						bool flag4 = list.Count > 0;
						if (flag4)
						{
							int index2 = this.dtgvAcc.CurrentRow.Index;
							bool flag5 = index2 >= list[list.Count - 1];
							if (flag5)
							{
								index = 0;
							}
							else
							{
								for (int j = 0; j < list.Count; j++)
								{
									bool flag6 = index2 < list[j];
									if (flag6)
									{
										index = j;
										break;
									}
								}
							}
							int index3 = list[index];
							this.dtgvAcc.CurrentCell = this.dtgvAcc.Rows[index3].Cells[columnName];
							this.dtgvAcc.ClearSelection();
							this.dtgvAcc.Rows[index3].Selected = true;
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0007A748 File Offset: 0x00078948
		private void UidPassTokenCookieMailPassMail2faToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRXlXa2xSYldocVRUQTBORnBGWXpWamJIQllUbFJvV2sxcWJESlpWRXB6WWtkYVNFMVhhR2hXTTJjMFdUQmtSMlZ0VFhsTlYyaG9Wak5uTkZkdE1VWmxVVDA5")))))))));
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0007A7A8 File Offset: 0x000789A8
		private void UpdateSTTOnDtgvAcc()
		{
			for (int i = 0; i < this.dtgvAcc.RowCount; i++)
			{
				DatagridviewHelper.SetStatusDataGridView(this.dtgvAcc, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QxWldXa0pRVkRBOQ==")))))))), i + 1);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0007A848 File Offset: 0x00078A48
		private void fAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZjeFlXRkJQVDA9")))))))));
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0007A8A8 File Offset: 0x00078AA8
		private void xóaProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWkU5aWVsSnBZMWhhV21WVlNqQmFSMVpJVGpKMFdFNUhaR3hVVlRrMlYxWk9RMVZYVG5SUFZ6Rm9Wak5vYzFOVlpGRmhTRlV5V2tkb1NsTklUak5hYkU1RFRVaGpNbEZ1UWtwU00xSjJXV2wwU0U1dE9IbE9Remc5"))))))))), this.CountChooseRowInDatagridview())) == DialogResult.Yes;
			if (flag)
			{
				this.LoadSetting();
				int iThread = 0;
				int maxThread = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUa2hpUjNSaFZteEtkbGt5TVZkaFJuQkNVRlF3UFE9PQ==")))))))), 10);
				new Thread(delegate()
				{
					int i = 0;
					while (i < this.dtgvAcc.Rows.Count)
					{
						bool flag2 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells["cChose"].Value);
						if (flag2)
						{
							bool flag3 = iThread < maxThread;
							if (flag3)
							{
								Interlocked.Increment(ref iThread);
								int row = i++;
								new Thread(delegate()
								{
									this.LoadStatusGrid(Language.GetValue("Đang xóa profile..."), "cStatus", row, 0, this.dtgvAcc);
									this.DeleteProfile(row);
									Interlocked.Decrement(ref iThread);
								}).Start();
							}
							else
							{
								Application.DoEvents();
								Thread.Sleep(200);
							}
						}
						else
						{
							i++;
						}
					}
				}).Start();
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0007A9CC File Offset: 0x00078BCC
		private void DeleteProfile(int row)
		{
			try
			{
				string id = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))].Value.ToString();
				string text = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))].Value.ToString();
				bool flag = text.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NWSXpUa2hTVjJSclZEQmpNbUl4WXpSYU1rNUpVMjVhWVdKWGVIcFhiRTVHVUZFOVBRPT0="))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 0, this.dtgvAcc);
				}
				else
				{
					string path = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + text;
					bool flag2 = Directory.Exists(path);
					if (flag2)
					{
						Directory.Delete(path, true);
						this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpBeFVHVnNiRlJSYm1ScVlsUnNkRmxXWkRSaVJXeEpWVzA1TTA1clNqRlpWVTVEWVc1ak0xVnVWbUZsVlZVNQ=="))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 0, this.dtgvAcc);
						this.LoadStatusGrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtjd05GQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWGxYYmtKcFVqRlZPUT09")))))))), row, 0, this.dtgvAcc);
						CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnNjSFJpU0U1aFZWUXdPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtjd05GQlJQVDA9")))))))));
					}
					else
					{
						this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NWSXpUa2hTVjJSclZEQmpNbUl4WXpSYU1rNUpVMjVhWVdKWGVIcFhiRTVHVUZFOVBRPT0="))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 0, this.dtgvAcc);
					}
				}
			}
			catch
			{
				this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpBeFVHVnNiRlJSYm1ScVlsUnNkRmxXWkRSaVJXeEpWVzA0TUZsdVJuTmFSVTVEWVZSU2FXTlhhR2hWTUZVNQ=="))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 0, this.dtgvAcc);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0007B064 File Offset: 0x00079264
		private void checkProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int iThread = 0;
			int maxThread = 10;
			new Thread(delegate()
			{
				int i = 0;
				while (i < this.dtgvAcc.Rows.Count)
				{
					bool flag = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells["cChose"].Value);
					if (flag)
					{
						bool flag2 = iThread < maxThread;
						if (flag2)
						{
							Interlocked.Increment(ref iThread);
							int row = i++;
							new Thread(delegate()
							{
								this.LoadStatusGrid(Language.GetValue("Đang check profile..."), "cStatus", row, 0, this.dtgvAcc);
								this.CheckProfile(row);
								Interlocked.Decrement(ref iThread);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						i++;
					}
				}
			}).Start();
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0007B0B4 File Offset: 0x000792B4
		private void CheckProfile(int row)
		{
			try
			{
				string id = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))].Value.ToString();
				string str = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))].Value.ToString();
				string path = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + str;
				bool flag = Directory.Exists(path);
				if (flag)
				{
					this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGt3YUV0a2JIQjBZa2hPWVZVd1ZUaz0="))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 0, this.dtgvAcc);
					this.LoadStatusGrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpGa1YyVm5QVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWGxYYmtKcFVqRlZPUT09")))))))), row, 0, this.dtgvAcc);
					CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnNjSFJpU0U1aFZWUXdPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpGa1YyVm5QVDA9")))))))));
				}
				else
				{
					this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NWSXpUa2hTVjJSclZEQmpNbUl4WXpSYU1rNUpVMjVhWVdKWGVIcFhiRTVHVUZFOVBRPT0="))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 0, this.dtgvAcc);
					this.LoadStatusGrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtjd05GQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWGxYYmtKcFVqRlZPUT09")))))))), row, 0, this.dtgvAcc);
					CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnNjSFJpU0U1aFZWUXdPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtjd05GQlJQVDA9")))))))));
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0007B6BC File Offset: 0x000798BC
		private void donDepProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Common.ShowForm(new fClearProfile());
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(ex.ToString(), 3);
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0007B710 File Offset: 0x00079910
		public void CloseProcess(string nameProcess)
		{
			try
			{
				foreach (Process process in Process.GetProcessesByName(nameProcess))
				{
					process.Kill();
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0007B780 File Offset: 0x00079980
		private void pictureBox1_DoubleClick(object sender, EventArgs e)
		{
			this.CloseProcess(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyVlhTWGxOVjNjOQ==")))))))));
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0007B7E0 File Offset: 0x000799E0
		private void uidPass2FaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRXlXa2xSYldocVRUQTBORlJYTVdGaFFUMDk=")))))))));
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0007B840 File Offset: 0x00079A40
		private void đinhDangKhacToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				List<string> list = new List<string>();
				for (int i = 0; i < this.dtgvAcc.RowCount; i++)
				{
					bool flag = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
					if (flag)
					{
						list.Add(string.Concat(new string[]
						{
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09"))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ=="))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09"))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ=="))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYXpWYVZqSjRlZz09"))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ=="))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk="))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ=="))))))))).Split(new char[]
							{
								'*'
							})[0],
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EySkhTblJWYlhocVdub3dPUT09"))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXUnRTa2hsU0ZwclpIb3dPUT09"))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXVlhSbGhXYmxaaFVWUXdPUT09"))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EyVlhTWHBXYm1NOQ=="))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1MyTkhUblZWYlRsaFVqQlpNUT09"))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
							this.GetCellAccount(i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1UyRkhVa2hXYTFKcVlsWmFiMXBGWkZkUmJHdDVWRlF3UFE9PQ==")))))))))
						}));
					}
				}
				bool flag2 = list.Count <= 0;
				if (flag2)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkU5aWVsSnBaRlUxYVdGVlNuSlhWbU14WWpCc1NWVkZVblpXTURWMlUxVm9WVkpIT1VoaE1tUm9UVzFvTWs1SFNuaGhiVXB3VVc1U2ExcFZZek5oTVdNd1dqRnJlVTlZWkd4Vk1FbDNXVlV4VUUxSFNuUlpNbVJyVWpKNE1WTldSVGxRVVQwOQ=="))))))))), 3);
				}
				else
				{
					Common.ShowForm(new fCopy(list));
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4b1MyVlhTWHBUVjJSU1RXcHNNMXBXUlRsUVVUMDk=")))))))));
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0007C42C File Offset: 0x0007A62C
		private void maBaoMât6SôToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1JtVldjSFJTVkRBOQ==")))))))));
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00069C18 File Offset: 0x00067E18
		private void trạngTháiToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0007C48C File Offset: 0x0007A68C
		private void LoadSetting()
		{
			this.setting_general = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0007C4F4 File Offset: 0x0007A6F4
		private void mơFileHTMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int iThread = 0;
			int maxThread = 10;
			new Thread(delegate()
			{
				try
				{
					int i = 0;
					while (i < this.dtgvAcc.Rows.Count)
					{
						bool flag = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells["cChose"].Value);
						if (flag)
						{
							bool flag2 = iThread < maxThread;
							if (flag2)
							{
								Interlocked.Increment(ref iThread);
								int row = i++;
								new Thread(delegate()
								{
									try
									{
										string statusDataGridView = CommonCSharp.GetStatusDataGridView(this.dtgvAcc, row, "cCookies");
										string text = CommonCSharp.GetStatusDataGridView(this.dtgvAcc, row, "cUid");
										bool flag3 = text == "";
										if (flag3)
										{
											text = Regex.Match(statusDataGridView, "c_user=(.*?);").Groups[1].Value;
										}
										bool flag4 = File.Exists(string.Concat(new string[]
										{
											"backup\\",
											text,
											"\\",
											text,
											".html"
										}));
										if (flag4)
										{
											Process.Start(string.Concat(new string[]
											{
												Path.GetDirectoryName(Application.ExecutablePath),
												"\\backup\\",
												text,
												"\\",
												text,
												".html"
											}));
										}
										else
										{
											CommonCSharp.UpdateStatusDataGridView(this.dtgvAcc, row, "cStatus", Language.GetValue("Chưa tạo html!"));
										}
										Interlocked.Decrement(ref iThread);
									}
									catch (Exception ex2)
									{
										CommonCSharp.ExportError(null, ex2.ToString());
									}
								}).Start();
							}
							else
							{
								CommonCSharp.DelayTime(1.0);
							}
						}
						else
						{
							i++;
						}
					}
					while (iThread > 0)
					{
						CommonCSharp.DelayTime(1.0);
					}
				}
				catch (Exception ex)
				{
					CommonCSharp.ExportError(null, ex.ToString());
				}
			}).Start();
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0007C544 File Offset: 0x0007A744
		private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string str = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				DialogResult dialogResult = folderBrowserDialog.ShowDialog();
				bool flag = dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath);
				if (!flag)
				{
					return;
				}
				str = folderBrowserDialog.SelectedPath;
			}
			int num = 0;
			for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
			{
				try
				{
					bool flag2 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
					if (flag2)
					{
						string text = this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))].Value.ToString();
						try
						{
							bool flag3 = File.Exists(string.Concat(new string[]
							{
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWlVWUXdPUT09")))))))),
								text,
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))),
								text,
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGIwMUhTbGhrZWpBOQ=="))))))))
							}));
							if (flag3)
							{
								File.Copy(string.Concat(new string[]
								{
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWlVWUXdPUT09")))))))),
									text,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))),
									text,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGIwMUhTbGhrZWpBOQ=="))))))))
								}), str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGIwMUhTbGhrZWpBOQ==")))))))));
								num++;
							}
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSk5XUXlWbFJSYWtKb1ZGVTVibGx0TVc1YU1XczBWSHBDYVdKWFRtNWFXSEJEVDFWc1NWWkhhREZPUjFJelUxVmtTMkZHYTNsa1JFWnFVVEJLZGxwRlkzaGpNR3hTVUZRd1BRPT0="))))))))), num), 1);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0007CACC File Offset: 0x0007ACCC
		private void thưMụcToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				DialogResult dialogResult = folderBrowserDialog.ShowDialog();
				bool flag = dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath);
				if (!flag)
				{
					return;
				}
				text = folderBrowserDialog.SelectedPath;
			}
			int num = 0;
			for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
			{
				try
				{
					bool flag2 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
					if (flag2)
					{
						string text2 = this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))].Value.ToString();
						try
						{
							bool flag3 = !Directory.Exists(text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + text2);
							if (flag3)
							{
								Directory.CreateDirectory(text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + text2);
							}
							string[] files = Directory.GetFiles(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWlVWUXdPUT09")))))))) + text2);
							for (int j = 0; j < files.Length; j++)
							{
								File.Copy(files[j], string.Concat(new string[]
								{
									text,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))),
									text2,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))),
									Path.GetFileName(files[j])
								}));
							}
							num++;
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
			MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSk5XUXlWbFJSYWtKb1ZGVTVibGx0TVc1YU1XczBWSHBDYVdKWFRtNWFXSEJEVDFWc1NWVnRPVFJqYTBadVdXMVdTRTR6UWxoVVYyUmFZbFZhY1ZsVVRsZGtNR3hTVUZRd1BRPT0="))))))))), num), 1);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0007CFA4 File Offset: 0x0007B1A4
		private void dtgvAcc_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			List<string> list = new List<string>
			{
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUhVa0pRVkRBOQ==")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXVlhSbGhXYmxaaFVWUXdPUT09")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2EyVlhTWHBXYm1NOQ==")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXUnRTa2hsU0ZwclpIb3dPUT09"))))))))
			};
			bool flag = list.Contains(e.Column.Name);
			if (flag)
			{
				e.SortResult = int.Parse((e.CellValue1.ToString() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9")))))))) : e.CellValue1.ToString()).CompareTo(int.Parse((e.CellValue2.ToString() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9")))))))) : e.CellValue2.ToString()));
				e.Handled = true;
			}
			else
			{
				e.SortResult = ((e.CellValue1.ToString() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) : e.CellValue1.ToString()).CompareTo((e.CellValue2.ToString() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) : e.CellValue2.ToString());
				e.Handled = true;
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0007D444 File Offset: 0x0007B644
		private void câuHinhHiênThiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fCauHinhHienThi());
			this.LoadConfigManHinh();
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0007D46C File Offset: 0x0007B66C
		private void checkProxyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int iThread = 0;
			int maxThread = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUa2hpUjNSaFZteEtkbGt5TVZkaFJuQkNVRlF3UFE9PQ==")))))))), 10);
			this.isStop = false;
			new Thread(delegate()
			{
				this.cControl("start");
				int i = 0;
				while (i < this.dtgvAcc.Rows.Count)
				{
					Application.DoEvents();
					bool flag = this.isStop;
					if (flag)
					{
						break;
					}
					bool flag2 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells["cChose"].Value);
					if (flag2)
					{
						bool flag3 = iThread < maxThread;
						if (flag3)
						{
							Interlocked.Increment(ref iThread);
							int row = i++;
							new Thread(delegate()
							{
								this.LoadStatusGrid(Language.GetValue("Đang kiểm tra..."), "cStatus", row, 0, this.dtgvAcc);
								this.CheckProxy(row);
								Interlocked.Decrement(ref iThread);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						i++;
					}
				}
				int tickCount = Environment.TickCount;
				while (iThread > 0)
				{
					bool flag4 = Environment.TickCount - tickCount > 30000;
					if (flag4)
					{
						break;
					}
					Application.DoEvents();
					Thread.Sleep(300);
				}
				this.cControl("stop");
			}).Start();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0007D520 File Offset: 0x0007B720
		private void CheckProxy(int row)
		{
			try
			{
				string text = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ=="))))))))].Value.ToString();
				int typeProxy = 0;
				bool flag = text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
				if (flag)
				{
					typeProxy = 1;
				}
				text = text.Substring(0, text.Length - 2);
				int num = 0;
				int num2 = 0;
				string a = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag2 = false;
				for (int i = 0; i < 10; i++)
				{
					a = Common.CheckProxyNew(text, typeProxy, 30);
					bool flag3 = a != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag3)
					{
						num++;
						bool flag4 = num == 3;
						if (flag4)
						{
							flag2 = true;
							break;
						}
					}
					else
					{
						num2++;
						bool flag5 = num2 == 3;
						if (flag5)
						{
							break;
						}
					}
				}
				bool flag6 = !flag2;
				if (flag6)
				{
					this.LoadStatusGrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWb1MyUnRWa2xoTW1SVFVqSjRjMU5XUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
				}
				else
				{
					this.LoadStatusGrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWb1MyUnRWa2xoTW1SVlVqSjNlVmRzVGtaUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
				}
			}
			catch
			{
				this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1oS1ZUQlZPUT09"))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 2, this.dtgvAcc);
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0007D9AC File Offset: 0x0007BBAC
		private void useragentToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1QySkhUblJTYlRWaFZucFZkdz09")))))))));
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0007DA0C File Offset: 0x0007BC0C
		private void proxyToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnRWa2xoZWpBOQ==")))))))));
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0007DA6C File Offset: 0x0007BC6C
		private void mởThưMụcBackupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
			{
				bool flag = this.isStop;
				if (flag)
				{
					break;
				}
				bool flag2 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
				if (flag2)
				{
					string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWlVWUXdPUT09")))))))) + DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ==")))))))));
					bool flag3 = Directory.Exists(text);
					if (flag3)
					{
						try
						{
							Process.Start(text);
							this.LoadStatusDatagridView(i, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtkV1NFNHlOVFZSYWtKb1ZGVTVibGx0TVc1YU1XczBWSHBDYVdKWFRtOD0="))))))))));
						}
						catch
						{
							this.LoadStatusDatagridView(i, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtkV1NFNHlOVFZSYWtKb1ZEQmpNbU5HYUZKYU1Xd3hVbnBhZGxZeWRHOD0="))))))))));
						}
					}
					else
					{
						this.LoadStatusDatagridView(i, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NWSXpUa2hTVjJSYVlsVmFjVmxVVGxka01HeFNVRlF3UFE9PQ=="))))))))));
					}
				}
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0007DD30 File Offset: 0x0007BF30
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			bool flag = (e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt;
			if (flag)
			{
				try
				{
					Process.Start(Path.GetDirectoryName(Application.ExecutablePath));
				}
				catch
				{
				}
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0007DDB0 File Offset: 0x0007BFB0
		private void cbbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.isExcute_CbbTinhTrang_SelectedIndexChanged;
			if (!flag)
			{
				bool flag2 = this.cbbTinhTrang.SelectedValue == null || !StringHelper.CheckStringIsNumber(this.cbbTinhTrang.SelectedValue.ToString());
				if (!flag2)
				{
					bool flag3 = this.cbbTinhTrang.SelectedValue.ToString() != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9")))))))) && this.indexCbbTinhTrangOld == this.cbbTinhTrang.SelectedIndex;
					if (!flag3)
					{
						string text = this.cbbThuMuc.SelectedValue.ToString();
						string a = text;
						if (!(a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9"))))))))))
						{
							if (!(a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkRGU2NrNVZPVlZoZWxVOQ=="))))))))))
							{
								this.LoadAccountFromFile(this.GetIdFile(), this.cbbTinhTrang.Text, false);
							}
							else
							{
								this.LoadAccountFromFile(fChonThuMuc.lstChooseIdFilesFromBin, this.cbbTinhTrang.Text, false);
							}
						}
						else
						{
							this.LoadAccountFromFile(null, this.cbbTinhTrang.Text, false);
						}
						this.indexCbbTinhTrangOld = this.cbbTinhTrang.SelectedIndex;
					}
				}
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0007E01C File Offset: 0x0007C21C
		private void giưLaiProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.DeleteAccount();
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0007E038 File Offset: 0x0007C238
		private void kiểmTraMailpassMailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.KiemTraTaiKhoan(4);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0007E058 File Offset: 0x0007C258
		private void tênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRkpRVkRBOQ==")))))))));
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0007E0B8 File Offset: 0x0007C2B8
		private void ngàySinhToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.CopyRowDatagrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeGMyVlhVa2hoUjNSYVYwZHpPUT09")))))))));
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0007E118 File Offset: 0x0007C318
		public int CountChooseRowInDatagridview()
		{
			int num = 0;
			try
			{
				for (int i = 0; i < this.dtgvAcc.Rows.Count; i++)
				{
					bool flag = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
					if (flag)
					{
						num++;
					}
				}
			}
			catch
			{
			}
			return num;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0007E214 File Offset: 0x0007C414
		private void xóaDữLiệuBackupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWkU5aWVsSnBZMWhhV21WVlNqQmFSMVpJVGpKMFdFNUhaR3hVVlRrMlYxWk9RMkY2VW1sa1dGcEtVak5vZDA1SFNqRlRSMUpVVVcxc1dsWXdOWGxhUm1oQ1dqRnJjbEo2WkhkTmExWnVXbGh3UTA5VmJFbFdSVkoyVWpKMGJsbFVTbTlrYWxKcFkxZHdhV0ZxWnprPQ=="))))))))), this.CountChooseRowInDatagridview())) == DialogResult.Yes;
			if (flag)
			{
				int iThread = 0;
				int maxThread = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhUa2hpUjNSaFZteEtkbGt5TVZkaFJuQkNVRlF3UFE9PQ==")))))))), 10);
				new Thread(delegate()
				{
					int i = 0;
					while (i < this.dtgvAcc.Rows.Count)
					{
						bool flag2 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells["cChose"].Value);
						if (flag2)
						{
							bool flag3 = iThread < maxThread;
							if (flag3)
							{
								Interlocked.Increment(ref iThread);
								int row = i++;
								new Thread(delegate()
								{
									this.LoadStatusGrid(Language.GetValue("Đang xóa dữ liệu backup..."), "cStatus", row, 0, this.dtgvAcc);
									this.DeleteBackup(row);
									Interlocked.Decrement(ref iThread);
								}).Start();
							}
							else
							{
								Application.DoEvents();
								Thread.Sleep(200);
							}
						}
						else
						{
							i++;
						}
					}
				}).Start();
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0007E32C File Offset: 0x0007C52C
		private void DeleteBackup(int row)
		{
			try
			{
				string id = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))].Value.ToString();
				string text = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))].Value.ToString();
				bool flag = text.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NWSXpUa2hTVjJSYVlsVmFjVmxVVGxka01HeFNVRlF3UFE9PQ=="))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 0, this.dtgvAcc);
				}
				else
				{
					string path = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1SWlVWUXdPUT09")))))))) + text;
					bool flag2 = Directory.Exists(path);
					if (flag2)
					{
						Directory.Delete(path, true);
						this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpBeFVHVnNiRlJSYlhNd1dXNVdNbE5WWkRSalJGSnBaRlZvYTFVd1NuQlhWbVJQWTIxU1dWRlhaR3RTTW5CRllqQmpNV0l3YkVoVlJWSXdVbnBXZFZOV1JUbFFVVDA5"))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 0, this.dtgvAcc);
						this.LoadStatusGrid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1MyRkdhM2xrUkVacVVWUXdPUT09")))))))), row, 0, this.dtgvAcc);
						CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1NOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					}
					else
					{
						this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NWSXpUa2hTVjJSYVlsVmFjVmxVVGxka01HeFNVRlF3UFE9PQ=="))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 0, this.dtgvAcc);
					}
				}
			}
			catch
			{
				this.LoadStatusGrid(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpBeFVHVnNiRlJSYlhNd1dXNVdNbE5WWkRSalJGSnBaRlZvYTFVd1NuQlhWbVJQWTIxU1dWRlhaR3RTTW5CdlpGaEdWMDFGYkVoVVIyZ3hZMVZhZDFOV1JUbFFVVDA5"))))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), row, 0, this.dtgvAcc);
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0007E92C File Offset: 0x0007CB2C
		private void checkBackupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int iThread = 0;
			int maxThread = 10;
			string pathBackup = ConfigHelper.GetPathBackup();
			new Thread(delegate()
			{
				int i = 0;
				while (i < this.dtgvAcc.Rows.Count)
				{
					bool flag = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells["cChose"].Value);
					if (flag)
					{
						bool flag2 = iThread < maxThread;
						if (flag2)
						{
							Interlocked.Increment(ref iThread);
							int row = i++;
							new Thread(delegate()
							{
								this.SetStatusAccount(row, Language.GetValue("Đang check backup..."));
								this.CheckBackup(row, pathBackup);
								Interlocked.Decrement(ref iThread);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						i++;
					}
				}
			}).Start();
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0007E984 File Offset: 0x0007CB84
		private void CheckBackup(int row, string backupPath)
		{
			try
			{
				string id = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9"))))))))].Value.ToString();
				string text = this.dtgvAcc.Rows[row].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ=="))))))))].Value.ToString();
				backupPath = string.Concat(new string[]
				{
					backupPath,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))),
					text,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))),
					text,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMVUwNUhVa0pRVkRBOQ=="))))))))
				});
				bool flag = File.Exists(backupPath);
				if (flag)
				{
					this.SetStatusAccount(row, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYld4YVZqQTFlVnBHYUVKaFFUMDk="))))))))));
					this.SetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1MyRkdhM2xrUkVacVVWUXdPUT09")))))))), Common.GetDateCreatFile(backupPath));
					CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1NOQ==")))))))), Common.GetDateCreatFile(backupPath));
				}
				else
				{
					this.SetStatusAccount(row, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NWSXpUa2hTVjJSYVlsVmFjVmxVVGxka01HeFNVRlF3UFE9PQ=="))))))))));
					this.SetCellAccount(row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1MyRkdhM2xrUkVacVVWUXdPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					CommonSQL.UpdateFieldToAccount(id, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1NOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				}
			}
			catch
			{
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0007EE80 File Offset: 0x0007D080
		private void checkInfoUIDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.KiemTraTaiKhoan(5);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0007EEA0 File Offset: 0x0007D0A0
		private void button9_Click(object sender, EventArgs e)
		{
			this.KhoiPhucTaiKhoan();
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0007EEBC File Offset: 0x0007D0BC
		private void KhoiPhucTaiKhoan()
		{
			bool flag = this.CountChooseRowInDatagridview() == 0;
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsU0ZvMlUxVktNVmR1YkVOaGJVWklUREF4ZGsxcVVtNWFSV1JKVkZka1NHRXlaR2hOYldneVYxZE9OVk50U25CUmJYQXpUbXQ0VGxvd1l6QmFNa1Y1WVd0U01GSXlkRzVaTUdSdlRWaHdURlJ0Y0VwVlZEQTU="))))))))), 3);
			}
			else
			{
				Common.ShowForm(new fCauHinhKhoiPhucTaiKhoan());
				bool isOK = fCauHinhKhoiPhucTaiKhoan.isOK;
				if (isOK)
				{
					try
					{
						bool flag2 = fCauHinhKhoiPhucTaiKhoan.typeThuMuc == 0;
						if (flag2)
						{
							List<string> list = new List<string>();
							List<string> list2 = new List<string>();
							for (int i = 0; i < this.dtgvAcc.RowCount; i++)
							{
								bool flag3 = Convert.ToBoolean(this.dtgvAcc.Rows[i].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
								if (flag3)
								{
									string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, i, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9")))))))));
									string idFileFromIdAccount = CommonSQL.GetIdFileFromIdAccount(statusDataGridView);
									list.Add(statusDataGridView);
									list2.Add(idFileFromIdAccount);
									this.dtgvAcc.Rows.RemoveAt(i--);
								}
							}
							this.UpdateSTTOnDtgvAcc();
							CommonSQL.UpdateFieldToFile(list2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaa1QwMUhSbGxYYlhjOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9")))))))));
							bool flag4 = CommonSQL.UpdateFieldToAccount(list, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaa1QwMUhSbGxYYlhjOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9")))))))));
							if (flag4)
							{
								MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkljRXBVVjJSb1RXMXdSV1JGWkhKYU1rNUlZVVJHTmxNd05YRlRWV2hUWWpGc2FtVlZSbWxpVjJSdVYxUm9VRTFIU25SWk1tUnNaV3RKTlZOVmFGTmhTSEJLVVc1Q1NsSXpVblpaYWtwSlZGZHNXRTVIWnowPQ=="))))))))), list.Count), 1);
							}
							else
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeFVFMUljRXBVYmtKS1VqTlNkbVI2WkZOalJXeEpVVzA1YTFremJIRlhXR3hEVFVac2FtVlZSbWhWTUVwNVdWVmpOV0ZJY0VwaVNGWk5VVEJKZVZwR1pISmFNa3BJVERBeGJsSjZWblZUVldoVFlqTm9lVkpGTVhCVk1FcDZWMWRPTldGdFJsUlJibkJhVjBaV2J3PT0="))))))))), 2);
							}
						}
						else
						{
							string idFile = fCauHinhKhoiPhucTaiKhoan.idFile;
							List<string> list3 = new List<string>();
							for (int j = 0; j < this.dtgvAcc.RowCount; j++)
							{
								bool flag5 = Convert.ToBoolean(this.dtgvAcc.Rows[j].Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
								if (flag5)
								{
									string statusDataGridView2 = DatagridviewHelper.GetStatusDataGridView(this.dtgvAcc, j, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9")))))))));
									list3.Add(statusDataGridView2);
									this.dtgvAcc.Rows.RemoveAt(j--);
								}
							}
							this.UpdateSTTOnDtgvAcc();
							bool flag6 = CommonSQL.UpdateFieldToAccount(list3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1UxSXlSbGhsUjNjOQ==")))))))), idFile) && CommonSQL.UpdateFieldToAccount(list3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaa1QwMUhSbGxYYlhjOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9")))))))));
							if (flag6)
							{
								MessageBoxHelper.ShowMessageBox(string.Format(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkljRXBVVjJSb1RXMXdSV1JGWkhKYU1rNUlZVVJHTmxNd05YRlRWV2hUWWpGc2FtVlZSbWxpVjJSdVYxUm9VRTFIU25SWk1tUnNaV3RKTlZOVmFGTmhTSEJLVVc1Q1NsSXpVblpaYWtwSlZGZHNXRTVIWnowPQ=="))))))))), list3.Count), 1);
							}
							else
							{
								MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeFVFMUljRXBVYmtKS1VqTlNkbVI2WkZOalJXeEpVVzA1YTFremJIRlhXR3hEVFVac2FtVlZSbWhWTUVwNVdWVmpOV0ZJY0VwaVNGWk5VVEJKZVZwR1pISmFNa3BJVERBeGJsSjZWblZUVldoVFlqTm9lVkpGTVhCVk1FcDZWMWRPTldGdFJsUlJibkJhVjBaV2J3PT0="))))))))), 2);
							}
						}
					}
					catch (Exception ex)
					{
						Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2IyUnRSbFJSYkVab1UwWmFjVk5WV2xOaFIwWlVVV3Q0YUZKNmJHOVpiV001VUZFOVBRPT0=")))))))));
					}
				}
				this.UpdateTotalCountRecord();
				this.UpdateSelectCountRecord();
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0007E01C File Offset: 0x0007C21C
		private void button3_Click_1(object sender, EventArgs e)
		{
			this.DeleteAccount();
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0007EEA0 File Offset: 0x0007D0A0
		private void khôiPhucTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.KhoiPhucTaiKhoan();
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0007F660 File Offset: 0x0007D860
		public List<string> GetListKeyTinsoft()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1604544, 2512, 830, parameters);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0007F6A8 File Offset: 0x0007D8A8
		private void MoTrinhDuyet()
		{
			try
			{
				this.setting_MoTrinhDuyet = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVlRUQktjMWx0ZEV0bFYwbDZXa2h3WVZkRmF6az0=")))))))), false);
				string profilePath = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool valueBool = this.setting_MoTrinhDuyet.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1QxWnRUWGxXYkVacVlsUnNkRmxXWkRSaVFUMDk=")))))))), false);
				if (valueBool)
				{
					profilePath = ConfigHelper.GetPathProfile();
					bool flag = !Directory.Exists(profilePath);
					if (flag)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSXpUbEJTZW1SMVZucFdkVk5WWkZWaFNGWjRaRWhXU2xORlNqVlpha3BoWTBkS1NGWlhaR2hOYlhCRlpFVmpNV0pyYkVoaGJXZ3hUbXMxTTFOVlpEWmhTRlV3V1RKblBRPT0="))))))))), 3);
						return;
					}
				}
				bool flag2 = Base.useragentDefault == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag2)
				{
					Base.useragentDefault = CommonChrome.GetUserAgentDefault();
					bool flag3 = Base.useragentDefault == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag3)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWa2IyTklZekpqU0ZaS1VqQjRiMlJZUms5a1ZXeEdWRzA1YW1KVWJEQlhiR1JUWlZkR1dWZHRlR3BoVlVwMldWZFdTRTR5WjNsT1IyUnJWREJqTW1JeFpISmFNa1Y1WVd0U01GSjZWblZUVldRd1lucFNhV05YY0VwU01WSnZaRlJhVjJSV2NEVmtNbVJyWW14YWQxTlZaRFpTU0U1MFRsYzFTbEl4UW05a1dFVjRaREJzU0U1WE9EQlpia1l3V2tWT1JsQlJQVDA9"))))))))), 3);
						return;
					}
				}
				this.LoadSetting();
				int maxThread = this.CountChooseRowInDatagridview();
				switch (this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0))
				{
				case 7:
				{
					this.listApiTinsoft = this.GetListKeyTinsoft();
					bool flag4 = this.listApiTinsoft.Count == 0;
					if (flag4)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWb1MyUnRWa2xoTW1SWFVqSjRNVmw2U1RWaVYxSkVVVzVLYUZSVk9IZFpiVEZxV2pOb1MxTkhhREZPYlU1NlUxVm9ZVTFYUmxSUmJrNHpUakJ3TVZkdWJFTmtSMUpZVWxka2ExSXljRVZqVnpCM1lVRTlQUT09"))))))))), 2);
						return;
					}
					this.listTinsoft = new List<TinsoftProxy>();
					for (int i = 0; i < this.listApiTinsoft.Count; i++)
					{
						TinsoftProxy item = new TinsoftProxy(this.listApiTinsoft[i], this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWVzVDYVdKck5USlhiVFZTVUZFOVBRPT0=")))))))), 0), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1MyRldVa2hQVjNCYVYwWktkMWxxU1RGV1YwWllUbGh3YVUxc2IzYz0=")))))))), 0));
						this.listTinsoft.Add(item);
					}
					bool flag5 = this.listApiTinsoft.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWVzVDYVdKck5USlhiVFZTVUZFOVBRPT0=")))))))), 0) < maxThread;
					if (flag5)
					{
						maxThread = this.listApiTinsoft.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWVzVDYVdKck5USlhiVFZTVUZFOVBRPT0=")))))))), 0);
					}
					break;
				}
				case 8:
				{
					this.listProxyXproxy = this.setting_general.GetValueList(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0hCclVtdEtOVmxxVG05T1VUMDk=")))))))), 0);
					bool flag6 = this.listProxyXproxy.Count == 0;
					if (flag6)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWb1MyUnRWa2xoTW1Sb1RXMXdSV1JGWXpGaWEyeE9WVEZKTUZsdVZuVlVSVTVEVFcxU1dHRXlaR2xVVlRrMVdXMHhhbG94YTNKU2VscDNWMFpXYmxsVk1WQmpNa3AwV2pKa2FWUXdZekppTVdSeVlVRTlQUT09"))))))))), 2);
						return;
					}
					this.listxProxy = new List<XproxyProxy>();
					for (int j = 0; j < this.listProxyXproxy.Count; j++)
					{
						XproxyProxy item2 = new XproxyProxy(this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWWGxXYm14cllsZDRjVmRzV2xkVk1WSkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))), this.listProxyXproxy[j], this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRSYm14cFRUSm5NUT09")))))))), 0), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), 0));
						this.listxProxy.Add(item2);
					}
					bool flag7 = this.listProxyXproxy.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), 0) < maxThread;
					if (flag7)
					{
						maxThread = this.listProxyXproxy.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), 0);
					}
					break;
				}
				case 10:
				{
					this.listProxyTMProxy = this.setting_general.GetValueList(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdSbGxSYmtKVVRXeFpNVlpyVlhoVlYwNTBUMVJTYkZWVU1Eaz0=")))))))), 0);
					bool flag8 = this.listProxyTMProxy.Count == 0;
					if (flag8)
					{
						MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10VmVGVlhUblJQVkZKc1ZUQktlVmxWTVZCTlIwcDBXVEprTkZOcmFHOWtWRnBxWXpCc1NWZHFSbWhWTUVwNlpIcGtTMlJXY0RWUmJsSnJWakJXYmxwRlpIRlNTRVowVFVkblBRPT0="))))))))), 2);
						return;
					}
					this.listTMProxy = new List<TMProxy>();
					for (int k = 0; k < this.listProxyTMProxy.Count; k++)
					{
						TMProxy item3 = new TMProxy(this.listProxyTMProxy[k], 0, this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWV3MxVmxORmNESmFWV2h5VUZFOVBRPT0=")))))))), 0));
						this.listTMProxy.Add(item3);
					}
					bool flag9 = this.listProxyTMProxy.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWV3MxVmxORmNESmFWV2h5VUZFOVBRPT0=")))))))), 0) < maxThread;
					if (flag9)
					{
						maxThread = this.listProxyTMProxy.Count * this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhVa2xXYmxwcFlsZFNVbGRzYUV0VGJGWkhWV3MxVmxORmNESmFWV2h5VUZFOVBRPT0=")))))))), 0);
					}
					break;
				}
				}
				this.isStop = false;
				List<int> lstPossition = new List<int>();
				for (int l = 0; l < this.CountChooseRowInDatagridview(); l++)
				{
					lstPossition.Add(0);
				}
				this.checkDelayChrome = 0;
				this.lstThread = new List<Thread>();
				new Thread(delegate()
				{
					try
					{
						bool flag10 = this.setting_general.GetValueInt("ip_iTypeChangeIp", 0) == 8 && this.setting_general.GetValueInt("typeRunXproxy", 0) == 1;
						if (flag10)
						{
							for (int m = 0; m < this.listxProxy.Count; m++)
							{
								this.listxProxy[m].ResetProxy();
							}
						}
						int n = 0;
						while (n < this.dtgvAcc.Rows.Count)
						{
							bool flag11 = this.isStop;
							if (flag11)
							{
								break;
							}
							bool flag12 = Convert.ToBoolean(this.dtgvAcc.Rows[n].Cells["cChose"].Value);
							if (flag12)
							{
								bool flag13 = this.isStop;
								if (flag13)
								{
									break;
								}
								bool flag14 = this.lstThread.Count < maxThread;
								if (!flag14)
								{
									break;
								}
								bool flag15 = this.isStop;
								if (flag15)
								{
									break;
								}
								int row = n++;
								Thread thread = new Thread(delegate()
								{
									try
									{
										int indexOfPossitionApp = Common.GetIndexOfPossitionApp(ref lstPossition);
										this.MoTrinhDuyetOneThread(row, indexOfPossitionApp, profilePath);
									}
									catch (Exception ex3)
									{
										Common.ExportError(null, ex3, "");
									}
								});
								thread.Name = row.ToString();
								this.lstThread.Add(thread);
								Common.DelayTime(1.0);
								thread.Start();
							}
							else
							{
								n++;
							}
							bool flag16 = this.isStop;
							if (flag16)
							{
								break;
							}
						}
						for (int num = 0; num < this.lstThread.Count; num++)
						{
							this.lstThread[num].Join();
						}
					}
					catch (Exception ex2)
					{
						Common.ExportError(null, ex2, "");
					}
				}).Start();
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000803F4 File Offset: 0x0007E5F4
		private void MoTrinhDuyetOneThread(int indexRow, int indexPos, string profilePath)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			Chrome chrome = null;
			int num = 0;
			bool flag = false;
			string str = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			int typeProxy = 0;
			string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			TinsoftProxy tinsoftProxy = null;
			XproxyProxy xproxyProxy = null;
			TMProxy tmproxy = null;
			bool flag2 = false;
			string str2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text3 = this.GetCellAccount(indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ==")))))))));
			string cellAccount = this.GetCellAccount(indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ2MyRjNQVDA9")))))))));
			string cellAccount2 = this.GetCellAccount(indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1YyUkdiRmhpU0UwOQ==")))))))));
			string cellAccount3 = this.GetCellAccount(indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1lXRkZNVzVRVkRBOQ==")))))))));
			string cellAccount4 = this.GetCellAccount(indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyRkhUWHBVYWs1cFRUQndjZz09")))))))));
			string text4 = this.GetCellAccount(indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09")))))))));
			string cellAccount5 = this.GetCellAccount(indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1UyUnRSWGxXYmxVOQ==")))))))));
			string text5 = this.GetCellAccount(indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyVnNjRmxUYldoaFRXeGFNVnBGUlRsUVVUMDk=")))))))));
			bool flag3 = text3 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag3)
			{
				text3 = Regex.Match(text4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Groups[1].Value;
			}
			bool flag4 = this.isStop;
			if (flag4)
			{
				this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
			}
			else
			{
				for (;;)
				{
					switch (this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0))
					{
					case 7:
					{
						this.SetStatusAccount(indexRow, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZEQmpNbU5HYUhKYU1rNUpVMjVhYkZOSGRHNVdhMlJ6WkZkTmVVOVhNV3RSZWxJeFZFZGpPVkJSUFQwPQ=="))))))))));
						object obj = this.lock_StartProxy;
						lock (obj)
						{
							for (;;)
							{
								bool flag6 = this.isStop;
								if (flag6)
								{
									break;
								}
								tinsoftProxy = null;
								do
								{
									bool flag7 = this.isStop;
									if (flag7)
									{
										break;
									}
									foreach (TinsoftProxy tinsoftProxy2 in this.listTinsoft)
									{
										bool flag8 = tinsoftProxy == null || tinsoftProxy2.daSuDung < tinsoftProxy.daSuDung;
										if (flag8)
										{
											tinsoftProxy = tinsoftProxy2;
										}
									}
								}
								while (tinsoftProxy.daSuDung == tinsoftProxy.limit_theads_use);
								IL_6FB:
								bool flag9 = this.isStop;
								if (flag9)
								{
									break;
								}
								bool flag10 = tinsoftProxy.daSuDung > 0 || tinsoftProxy.ChangeProxy();
								if (flag10)
								{
									goto Block_39;
								}
								continue;
								goto IL_6FB;
							}
							goto IL_7DC;
							Block_39:
							text = tinsoftProxy.proxy;
							bool flag11 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag11)
							{
								text = tinsoftProxy.GetProxy();
							}
							tinsoftProxy.dangSuDung++;
							tinsoftProxy.daSuDung++;
							IL_7DC:
							bool flag12 = this.isStop;
							if (flag12)
							{
								this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
								goto IL_4513;
							}
							bool flag13 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0) > 0;
							if (flag13)
							{
								DatagridviewHelper.SetStatusDataGridViewWithWait(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0), str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1YyTXhiRmxoTW1SYVZqRnZkMWRzYUVwYU1XdDVZVWRvYVdKWFVuTlRWV1J6WkRCc1NXUkVRbWhXZWtaeldteG9UbVJWZUhCT1JEQTk=")))))))));
							}
							bool flag14 = true;
							bool flag15 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
							if (flag15)
							{
								str = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text.Split(new char[]
								{
									':'
								})[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
								this.SetStatusAccount(indexRow, str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZtdEdNVlJIYXpCUVVUMDk=")))))))));
								text2 = Common.CheckProxyNew(text, 0, 30);
								bool flag16 = text2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								if (flag16)
								{
									flag14 = false;
								}
							}
							bool flag17 = !flag14;
							if (flag17)
							{
								tinsoftProxy.dangSuDung--;
								tinsoftProxy.daSuDung--;
								continue;
							}
						}
						break;
					}
					case 8:
					{
						this.SetStatusAccount(indexRow, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZEQmpNbU5HYUhKYU1WWkpVMjVhYkZOSGRERlVSMnN3VUZFOVBRPT0="))))))))));
						object obj2 = this.lock_StartProxy;
						lock (obj2)
						{
							bool flag19 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRUYWtacFlrZG9NMWt5TURWT1IxWlNVRlF3UFE9PQ==")))))))), 0) == 0;
							if (flag19)
							{
								for (;;)
								{
									bool flag20 = this.isStop;
									if (flag20)
									{
										break;
									}
									xproxyProxy = null;
									do
									{
										bool flag21 = this.isStop;
										if (flag21)
										{
											break;
										}
										foreach (XproxyProxy xproxyProxy2 in this.listxProxy)
										{
											bool flag22 = xproxyProxy2.isProxyLive && (xproxyProxy == null || xproxyProxy2.daSuDung < xproxyProxy.daSuDung);
											if (flag22)
											{
												xproxyProxy = xproxyProxy2;
											}
										}
									}
									while (xproxyProxy.daSuDung == xproxyProxy.limit_theads_use);
									IL_DDA:
									bool flag23 = this.isStop;
									if (flag23)
									{
										break;
									}
									bool flag24 = xproxyProxy.isProxyLive && (xproxyProxy.daSuDung > 0 || xproxyProxy.ChangeProxy());
									if (flag24)
									{
										goto Block_60;
									}
									xproxyProxy.isProxyLive = false;
									continue;
									goto IL_DDA;
								}
								goto IL_E8C;
								Block_60:
								text = xproxyProxy.proxy;
								typeProxy = xproxyProxy.typeProxy;
								xproxyProxy.dangSuDung++;
								xproxyProxy.daSuDung++;
								IL_E8C:;
							}
							else
							{
								for (;;)
								{
									bool flag25 = this.isStop;
									if (flag25)
									{
										break;
									}
									xproxyProxy = null;
									List<XproxyProxy> list = new List<XproxyProxy>();
									foreach (XproxyProxy xproxyProxy3 in this.listxProxy)
									{
										bool flag26 = !xproxyProxy3.isProxyLive;
										if (!flag26)
										{
											bool flag27 = xproxyProxy3.daSuDung < xproxyProxy3.limit_theads_use;
											if (flag27)
											{
												list.Add(xproxyProxy3);
											}
											else
											{
												bool flag28 = xproxyProxy3.dangSuDung == 0;
												if (flag28)
												{
													xproxyProxy3.ResetProxy();
													xproxyProxy3.daSuDung = 0;
												}
											}
										}
									}
									for (int i = 0; i < list.Count; i++)
									{
										bool flag29 = list[i].CheckLiveProxy(0);
										if (flag29)
										{
											xproxyProxy = list[i];
											break;
										}
									}
									bool flag30 = xproxyProxy != null;
									if (flag30)
									{
										goto Block_64;
									}
								}
								goto IL_1022;
								Block_64:
								text = xproxyProxy.proxy;
								typeProxy = xproxyProxy.typeProxy;
								xproxyProxy.dangSuDung++;
								xproxyProxy.daSuDung++;
								IL_1022:;
							}
							bool flag31 = this.isStop;
							if (flag31)
							{
								this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
								goto IL_4513;
							}
							bool flag32 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0) > 0;
							if (flag32)
							{
								DatagridviewHelper.SetStatusDataGridViewWithWait(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0), str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1YyTXhiRmxoTW1SYVZqRnZkMWRzYUVwYU1XdDVZVWRvYVdKWFVuTlRWV1J6WkRCc1NXUkVRbWhXZWtaeldteG9UbVJWZUhCT1JEQTk=")))))))));
							}
							bool flag33 = true;
							bool flag34 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
							if (flag34)
							{
								str = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
								this.SetStatusAccount(indexRow, str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZtdEdNVlJIYXpCUVVUMDk=")))))))));
								text2 = Common.CheckProxyNew(text, typeProxy, this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRWRmRzYUU5aVIxSkhZVVpHYW1KVWF6QmFWa1U1VUZFOVBRPT0=")))))))), 1) * 60);
								bool flag35 = text2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								if (flag35)
								{
									xproxyProxy.isProxyLive = false;
									flag33 = false;
								}
							}
							bool flag36 = !flag33;
							if (flag36)
							{
								xproxyProxy.dangSuDung--;
								xproxyProxy.daSuDung--;
								continue;
							}
						}
						break;
					}
					case 9:
						goto IL_14A2;
					case 10:
					{
						this.SetStatusAccount(indexRow, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFZEQmpNbU5HYUhKYU1WcEdUVlpHYW1KVWF6QmFWazB3WkZWNGJsQlVNRDA9"))))))))));
						object obj3 = this.lock_StartProxy;
						lock (obj3)
						{
							for (;;)
							{
								bool flag38 = this.isStop;
								if (flag38)
								{
									break;
								}
								tmproxy = null;
								do
								{
									bool flag39 = this.isStop;
									if (flag39)
									{
										break;
									}
									foreach (TMProxy tmproxy2 in this.listTMProxy)
									{
										bool flag40 = tmproxy == null || tmproxy2.daSuDung < tmproxy.daSuDung;
										if (flag40)
										{
											tmproxy = tmproxy2;
										}
									}
								}
								while (tmproxy.daSuDung == tmproxy.limit_theads_use);
								IL_176E:
								bool flag41 = this.isStop;
								if (flag41)
								{
									break;
								}
								bool flag42 = tmproxy.daSuDung > 0 || tmproxy.ChangeProxy();
								if (flag42)
								{
									goto Block_90;
								}
								continue;
								goto IL_176E;
							}
							goto IL_184F;
							Block_90:
							text = tmproxy.proxy;
							bool flag43 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag43)
							{
								text = tmproxy.GetProxy();
							}
							tmproxy.dangSuDung++;
							tmproxy.daSuDung++;
							IL_184F:
							bool flag44 = this.isStop;
							if (flag44)
							{
								this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
								goto IL_4513;
							}
							bool flag45 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0) > 0;
							if (flag45)
							{
								DatagridviewHelper.SetStatusDataGridViewWithWait(this.dtgvAcc, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMUdiRmxWYWtacVpIb3dPUT09")))))))), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), 0), str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1YyTXhiRmxoTW1SYVZqRnZkMWRzYUVwYU1XdDVZVWRvYVdKWFVuTlRWV1J6WkRCc1NXUkVRbWhXZWtaeldteG9UbVJWZUhCT1JEQTk=")))))))));
							}
							bool flag46 = true;
							bool flag47 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
							if (flag47)
							{
								str = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text.Split(new char[]
								{
									':'
								})[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
								this.SetStatusAccount(indexRow, str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZtdEdNVlJIYXpCUVVUMDk=")))))))));
								text2 = Common.CheckProxyNew(text, 0, 30);
								bool flag48 = text2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								if (flag48)
								{
									flag46 = false;
								}
							}
							bool flag49 = !flag46;
							if (flag49)
							{
								tmproxy.dangSuDung--;
								tmproxy.daSuDung--;
								continue;
							}
						}
						break;
					}
					}
					break;
				}
				goto IL_1C89;
				IL_14A2:
				text = this.GetCellAccount(indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyVlhTWHBoUkZVOQ==")))))))));
				bool flag50 = text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
				if (flag50)
				{
					typeProxy = 1;
				}
				else
				{
					typeProxy = 0;
				}
				bool flag51 = text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1FsQlJQVDA9"))))))))) || text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKd1JsQlJQVDA9")))))))));
				if (flag51)
				{
					text = text.Substring(0, text.Length - 2);
				}
				IL_1C89:
				bool flag52 = this.isStop;
				if (flag52)
				{
					this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
				}
				else
				{
					bool flag53 = !this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldUWGxoU0ZwcFlsZFNSVmxWWkZkaGJVVjNZa1pGUFE9PQ==")))))))), false);
					if (flag53)
					{
						bool flag54 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0) == 7 || this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0) == 8 || this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0) == 10;
						if (!flag54)
						{
							bool flag55 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag55)
							{
								str = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text.Split(new char[]
								{
									':'
								})[0] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
							}
							this.SetStatusAccount(indexRow, str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SVVZtdEdNVlJIYXpCUVVUMDk=")))))))));
							bool flag56 = false;
							for (int j = 0; j < 30; j++)
							{
								Common.DelayTime(1.0);
								text2 = Common.CheckProxyNew(text, typeProxy, 30);
								bool flag57 = text2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								if (flag57)
								{
									flag56 = true;
									break;
								}
								bool flag58 = this.isStop;
								if (flag58)
								{
									this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
									goto IL_4513;
								}
							}
							bool flag59 = !flag56;
							if (flag59)
							{
								bool flag60 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								if (flag60)
								{
									this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkazVIU2pGU1JXeElaRzFvTVdOcWEzZFRWV016WVVoVk1WSnVRa3BUUlVvMVdXcE9iMDVWYkZKUVZEQTk="))))))))));
								}
								else
								{
									this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNSV016YkVOamFsSnBZMU01YTFFd1NqRk9SMG94VlcxR1ZGRnJjR2xpYkVweldUSXdNV0pIVWtSU1ZEQTk="))))))))));
								}
								goto IL_4513;
							}
						}
						str = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCV2MxVlZPWEJSVkRBOQ==")))))))) + text2 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1FsQlJQVDA9"))))))));
					}
					bool flag61 = this.isStop;
					if (flag61)
					{
						this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
					}
					else
					{
						try
						{
							this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2NXRklWVEZOUjJRMFUydG9iMlJZU1RWa1ZXeElaV3RrZWxRd1l6TmllazVTWkZWNGNFNUVNRDA9"))))))))));
							object obj4 = this.lock_checkDelayChrome;
							lock (obj4)
							{
								bool flag63 = this.checkDelayChrome > 0;
								if (flag63)
								{
									int num2 = this.rd.Next(this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRVVmt3WkZka1ZrVjVZVWhzYVUxcVJuTlZiVFZMWkcxS1VsQlVNRDA9")))))))), 1), this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyRXhTa2hXYms1YVYwZDRVVmt3WkZka1ZrVjVZVWhzYVUxcVJuTldhMk0wVUZFOVBRPT0=")))))))), 1) + 1);
									bool flag64 = num2 > 0;
									if (flag64)
									{
										int tickCount = Environment.TickCount;
										while ((Environment.TickCount - tickCount) / 1000 - num2 < 0)
										{
											this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtkV1NFNHlOVFZSYWtKcVlsYzFUbG93WXpGaU1HeElWV3BHYkZrd09YaGxhM1JQVFVWc1NWUnRhR3RWVkRBNQ=="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWb01FMUhSbGhOVjNodFYwVXhNVlJIYXpCUVVUMDk=")))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xST1UyTkhTbGhXYW1zOQ==")))))))), (num2 - (Environment.TickCount - tickCount) / 1000).ToString()));
											Common.DelayTime(0.5);
											bool flag65 = this.isStop;
											if (flag65)
											{
												this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
												goto IL_4513;
											}
										}
									}
								}
								else
								{
									this.checkDelayChrome++;
								}
							}
							this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1ScFdUSkdiMlZyYkhKYU1sSkpVMjVDTmxOVlNqRlpWVTVEWVRKU1dXSnJVbmhqTTJ4eFdrVk5NR1JWZUc1UVZEQTk="))))))))));
							bool flag66 = text5 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || text.Split(new char[]
							{
								':'
							}).Length == 4;
							if (flag66)
							{
								text5 = Base.useragentDefault;
							}
							string text6 = profilePath + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + text3;
							bool flag67 = !this.setting_MoTrinhDuyet.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1QxWnRUWGxXYkVacVlsUnNkRmxXWkRSaVFUMDk=")))))))), false);
							if (flag67)
							{
								text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							}
							Point pointFromIndexPosition = Common.GetPointFromIndexPosition(indexPos, 5, 2);
							Point sizeChrome = Common.GetSizeChrome(5, 2);
							chrome = new Chrome
							{
								DisableImage = !Convert.ToBoolean((this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoU0ZwclRVZDRNRmRXWkd0aVJrNVlUbFJDWVZkRmNHOVhWRTVTVUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyTXlUWGxXVkRBOQ==")))))))) : this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldWWGxoU0ZwclRVZDRNRmRXWkd0aVJrNVlUbFJDWVZkRmNHOVhWRTVTVUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))))),
								UserAgent = text5,
								ProfilePath = text6,
								Size = sizeChrome,
								Position = pointFromIndexPosition,
								TimeWaitForSearchingElement = 3,
								TimeWaitForLoadingPage = 120,
								Proxy = text,
								TypeProxy = typeProxy,
								IsUsePortable = this.setting_general.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldXbGxVYlhoV1VucHNOVnBGWkVkaFYwcElWbFF3UFE9PQ==")))))))), false),
								PathToPortableZip = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdWa2hTYWtKb1VteEtNbFpWWXpWbFYxSklVbTFzYVZJeFdtaFpWbWhDVUZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))))
							};
							bool flag68 = this.isStop;
							if (flag68)
							{
								this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhNd1dXNVdlVmx0TVdwaFFUMDk="))))))))));
							}
							else
							{
								bool flag69 = this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUVwUVVUMDk=")))))))), 0) != 0;
								if (flag69)
								{
									chrome.LinkToOtherBrowser = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1RWWktNbFpFVGxOaU1YQlpVMnRPYW1KVWEzcFpla3BYWlZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
								}
								bool flag70 = !chrome.Open(false);
								if (flag70)
								{
									this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1ScFdsVmpNMkp1YkVOTlIwNTZWRE5PYVdKWFpHNVhhMmhYVGxSU2FXUlZhR3RSTUZVNQ=="))))))))));
								}
								else
								{
									this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1RMFUydG9SbHA2U1RGaWEyeElUbGM1TTA1cmVFNWllazVDWkZWNGNFNUVNRDA9"))))))))));
									string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
									bool flag71 = this.setting_MoTrinhDuyet.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), 0) == 0;
									if (flag71)
									{
										@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOUVNRDA9"))))))));
									}
									else
									{
										@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFrZWpBNQ=="))))))));
									}
									bool flag72 = text6.Trim() != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
									if (flag72)
									{
										num = CommonChrome.CheckLiveCookie(chrome, @string);
										switch (num)
										{
										case -3:
											chrome.Status = StatusChromeAccount.NoInternet;
											goto IL_4513;
										case -2:
											chrome.Status = StatusChromeAccount.ChromeClosed;
											goto IL_4513;
										case 1:
											flag = true;
											break;
										case 2:
											chrome.Status = StatusChromeAccount.Checkpoint;
											this.SetInfoAccount(cellAccount, indexRow, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk="))))))))));
											goto IL_4513;
										}
									}
									bool flag73 = !flag;
									if (flag73)
									{
										string text7 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
										switch (this.setting_MoTrinhDuyet.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 0))
										{
										case 0:
										{
											bool flag74 = text3.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || cellAccount4.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
											if (flag74)
											{
												bool flag75 = text3.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
												if (flag75)
												{
													this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkMlZyYkVOa1JXeEpWVzA1TTA1cmVFNWFNV2h5V2pGYVZtSkZWa3BWVkRBNQ=="))))))))));
												}
												else
												{
													bool flag76 = cellAccount4.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
													if (flag76)
													{
														this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkMlZyYkVOa1JXeEpWVzA1TTA1cmVFNWFNV2h5V2pGV1NGSnVjR3BsVlZVNQ=="))))))))));
													}
												}
												goto IL_4513;
											}
											this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrV21NeFRrVmxhMnhEWkZad05WRnFSbWhXTVVrMFdUQmtSMlZ0VGpWT1NGWk5Xbm93T1E9PQ=="))))))))));
											text7 = CommonChrome.LoginFacebookUsingUidPassNew(chrome, text3, cellAccount4, cellAccount3, @string, 2, false, 120);
											try
											{
												num = Convert.ToInt32(text7);
											}
											catch
											{
												num = -1;
											}
											break;
										}
										case 1:
										{
											bool flag77 = cellAccount2.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) || cellAccount4.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
											if (flag77)
											{
												bool flag78 = cellAccount2.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
												if (flag78)
												{
													this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkMlZyYkVOa1JXeEpWVzA1TTA1cmVFNWFNV2h5V2pGS1dFMVhhR2hXTTJSdg=="))))))))));
												}
												else
												{
													bool flag79 = cellAccount4.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
													if (flag79)
													{
														this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkMlZyYkVOa1JXeEpWVzA1TTA1cmVFNWFNV2h5V2pGV1NGSnVjR3BsVlZVNQ=="))))))))));
													}
												}
												goto IL_4513;
											}
											this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrV21NeFRrVmxhMnhEWkZad05WRnRlR2xXTUZwM1dXdG9OR1F4YkZsVWJuQk5ZVlJTTVE9PQ=="))))))))));
											text7 = CommonChrome.LoginFacebookUsingUidPassNew(chrome, cellAccount2, cellAccount4, cellAccount3, @string, 2, false, 120);
											try
											{
												num = Convert.ToInt32(text7);
											}
											catch
											{
												num = -1;
											}
											break;
										}
										case 2:
										{
											bool flag80 = text4.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
											if (flag80)
											{
												this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkMlZyYkVOa1JXeEpWVzA1TTA1cmVFNWFNV2h5V2pGRmVVOVlXbWhOYlhoelUxWkZPVkJSUFQwPQ=="))))))))));
												goto IL_4513;
											}
											this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrV21NeFRrVmxhMnhEWkZad05WRnRjR2xOYW14NVdWWmtWbVJWZUhCT1JEQTk="))))))))));
											num = Convert.ToInt32(CommonChrome.LoginFacebookUsingCookie(chrome, text4, @string));
											break;
										}
										}
										bool flag81 = this.setting_MoTrinhDuyet.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpsU0ZwaFRXMTRNUT09")))))))), 0) != 2;
										if (flag81)
										{
											switch (num)
											{
											case -2:
												chrome.Status = StatusChromeAccount.ChromeClosed;
												break;
											case -1:
												this.SetStatusAccount(indexRow, str + text7);
												break;
											case 0:
											{
												this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkazVIU25oa1IwNUVVV3BDYUZRd1l6SmpSbWhTV2pGc01WSjZXblpXTW5Sdg=="))))))))));
												CommonChrome.CheckStatusAccount(chrome, true);
												bool flag82 = chrome.Status == StatusChromeAccount.Logined;
												if (flag82)
												{
													flag = true;
												}
												break;
											}
											case 1:
												flag = true;
												break;
											case 2:
												chrome.Status = StatusChromeAccount.Checkpoint;
												this.SetInfoAccount(cellAccount, indexRow, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk="))))))))));
												break;
											case 3:
												this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNSV016YkVKbFZuQjBVbGRuUFE9PQ=="))))))))));
												break;
											case 4:
												this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVGb3lSbFJSYmtwb1VuazViMlJZUms5a1ZXeElaRWM1TTA0eFNqRlhibXhGVWxkMGFsUjZXbWxpVjA1dg=="))))))))));
												break;
											case 5:
												this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtkV1NFNXVTbGxWVjJSb1RXMXdiMlJZUm5OTlZXeElaRWM1TTA0eFNqRlhibXhGVWxkMGFsUjZXbWxpVjA1dg=="))))))))));
												this.SetInfoAccount(cellAccount, indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhTblJhUjNoaFVUQktNMWRXYUU5bFp6MDk=")))))))));
												break;
											case 6:
												this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtkT1VHRnJiRVZUYlRGYVZUQktlVmxWTVZCTlIwcDBXVEprTkZOcmFFVmtWekF4WW10c1VsQlVNRDA9"))))))))));
												break;
											case 7:
												chrome.Status = StatusChromeAccount.NoInternet;
												break;
											}
											bool flag83 = !flag;
											if (flag83)
											{
												this.SetRowColor(indexRow, 1);
												goto IL_4513;
											}
										}
										else
										{
											switch (num)
											{
											case -3:
												chrome.Status = StatusChromeAccount.NoInternet;
												goto IL_4513;
											case -2:
												chrome.Status = StatusChromeAccount.ChromeClosed;
												goto IL_4513;
											case 1:
												flag = true;
												break;
											case 2:
												chrome.Status = StatusChromeAccount.Checkpoint;
												this.SetInfoAccount(cellAccount, indexRow, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk="))))))))));
												goto IL_4513;
											}
											bool flag84 = !flag;
											if (flag84)
											{
												this.SetRowColor(indexRow, 1);
												this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrYTFJeWNFVmlNMDQxVVcxU1JGRnRiRnBaTTJ4eFdWWk9SbEJSUFQwPQ=="))))))))));
												goto IL_4513;
											}
										}
									}
									bool flag85 = this.setting_MoTrinhDuyet.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUV0VVYwbDVXa2hDYVZwNk1Eaz0=")))))))), 0) == 1 && !chrome.GetURL().StartsWith(@string);
									if (flag85)
									{
										chrome.GotoURL(@string);
									}
									this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSlhZM2xPVnpWS1VucFdkbVI2V2sxVVZ6aDZVVmRrYTFJeWFHOWxhMnhEWkZkR1JGRnRjRE5PTVVveFYyNXNSbEJSUFQwPQ=="))))))))));
									this.SetRowColor(indexRow, 2);
									bool valueBool = this.setting_MoTrinhDuyet.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS01HRldSbGxXYWtKcFRVUnNNMWRzWXpGVVYwWllUbGhKUFE9PQ==")))))))), false);
									if (valueBool)
									{
										chrome.GotoURL(this.setting_MoTrinhDuyet.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1pIb3dPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
									}
									flag2 = !this.CheckIsUidFacebook(text3);
									bool flag86 = flag2;
									if (flag86)
									{
										str2 = text3;
										text3 = Regex.Match(chrome.GetCookieFromChrome(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU5PUT09"))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkROak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Groups[1].Value;
										CommonSQL.UpdateFieldToAccount(cellAccount, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRjNQVDA9")))))))), text3);
										this.SetCellAccount(indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1YyTkdjRUpRVkRBOQ==")))))))), text3);
									}
									bool valueBool2 = this.setting_MoTrinhDuyet.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1QxTkdjRmxWYTFKcFRXcHNlVmxXWkZaUVVUMDk=")))))))), false);
									if (valueBool2)
									{
										text4 = chrome.GetCookieFromChrome(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU5PUT09")))))))));
										CommonSQL.UpdateFieldToAccount(cellAccount, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRjNQVDA9")))))))), text3);
										CommonSQL.UpdateFieldToAccount(cellAccount, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoT1ZWUXdPUT09")))))))), text4);
										this.SetCellAccount(indexRow, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QyUnRTWGxrU0VKaFYwVXdPUT09")))))))), text4);
									}
								}
							}
						}
						catch (Exception ex)
						{
							this.SetStatusAccount(indexRow, str + Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVeFVFMUljRXBVYmtKS1VqTlNkbVI2WkZOa1ZuQTFVV3BTV2xremJFTlhXR3hGVWxkMFdHSnJNWFpOYWxaMlUxWkZPVkJSUFQwPQ=="))))))))));
							Common.ExportError(chrome, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
						}
					}
				}
			}
			IL_4513:
			bool flag87 = chrome != null;
			if (flag87)
			{
				StatusChromeAccount status = chrome.Status;
				StatusChromeAccount statusChromeAccount = status;
				if (statusChromeAccount == StatusChromeAccount.ChromeClosed || statusChromeAccount == StatusChromeAccount.Checkpoint || statusChromeAccount == StatusChromeAccount.NoInternet)
				{
					this.SetRowColor(indexRow, 1);
					this.SetStatusAccount(indexRow, str + GetContentStatusChrome.GetContent(chrome.Status));
				}
			}
			bool flag88 = !flag && this.setting_MoTrinhDuyet.GetValueBool(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1QxRnRVbGxWYmxwU1RXNW9NbGw2U2xkU1IwWkpVMjVhYVZZeFdrNVpha3ByWTBkS2NsZHRhR2hXTTJNNQ==")))))))), false);
			if (flag88)
			{
				try
				{
					chrome.Close();
				}
				catch
				{
				}
			}
			bool flag89 = flag2 && Directory.Exists(this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + str2);
			if (flag89)
			{
				string text8 = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + str2;
				string pathTo = this.setting_general.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + text3;
				bool flag90 = !Common.MoveFolder(text8, pathTo);
				if (flag90)
				{
					bool flag91 = Common.CopyFolder(text8, pathTo);
					if (flag91)
					{
						Common.DeleteFolder(text8);
					}
				}
			}
			object obj5 = this.lock_FinishProxy;
			lock (obj5)
			{
				switch (this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1ExcHRSbGRWYWxacVVqRmFSVmxWWkVka1ZtOTVWbXR3YWxGVU1Eaz0=")))))))), 0))
				{
				case 7:
				{
					bool flag93 = tinsoftProxy != null;
					if (flag93)
					{
						tinsoftProxy.DecrementDangSuDung();
					}
					break;
				}
				case 8:
				{
					bool flag94 = xproxyProxy != null;
					if (flag94)
					{
						xproxyProxy.DecrementDangSuDung(this.setting_general.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRmRUYWtacFlrZG9NMWt5TURWT1IxWlNVRlF3UFE9PQ==")))))))), 0));
					}
					break;
				}
				case 10:
				{
					bool flag95 = tmproxy != null;
					if (flag95)
					{
						tmproxy.DecrementDangSuDung();
					}
					break;
				}
				}
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00084FF0 File Offset: 0x000831F0
		private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				this.dtgvAcc.CurrentRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value = !Convert.ToBoolean(this.dtgvAcc.CurrentRow.Cells[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQ1QySXlTWHBVYlhjOQ=="))))))))].Value);
				this.CountCheckedAccount(-1);
			}
			catch
			{
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00085114 File Offset: 0x00083314
		private void càiĐặtCấuHìnhMởToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Common.ShowForm(new fMoTrinhDuyet());
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00085130 File Offset: 0x00083330
		private void tiếnHànhMởToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.CountChooseRowInDatagridview() == 0;
			if (flag)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkU5aWVsSnBaRlUxYVdGVlNYZGtlbHBEWTBWc1NHUkhPV2xMTUdNeVlucEpNRm94YTNKU2VscDNUV3BTYmxsdFZraE9NalUxVVdwQ2FtTXdPWHBaYlRGdVdqRndTVlpxVlRCWmJsWkpXa1ZPUmxCUlBUMD0="))))))))), 3);
			}
			else
			{
				this.MoTrinhDuyet();
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00069C18 File Offset: 0x00067E18
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400034C RID: 844
		private Random rd = new Random();

		// Token: 0x0400034D RID: 845
		private bool isStop;

		// Token: 0x0400034E RID: 846
		private JSON_Settings setting_general;

		// Token: 0x0400034F RID: 847
		private JSON_Settings setting_ShowDtgv;

		// Token: 0x04000350 RID: 848
		private object lock_StartProxy = new object();

		// Token: 0x04000351 RID: 849
		private object lock_FinishProxy = new object();

		// Token: 0x04000352 RID: 850
		private int checkDelayChrome = 0;

		// Token: 0x04000353 RID: 851
		private object lock_checkDelayChrome = new object();

		// Token: 0x04000354 RID: 852
		private List<string> LstKey = new List<string>();

		// Token: 0x04000355 RID: 853
		private List<string> LstLink = new List<string>();

		// Token: 0x04000356 RID: 854
		private List<string> lstua = new List<string>();

		// Token: 0x04000357 RID: 855
		private object _lockbackup = new object();

		// Token: 0x04000358 RID: 856
		private List<int> listPossitionApp = new List<int>();

		// Token: 0x04000359 RID: 857
		private bool isLookStatus = false;

		// Token: 0x0400035A RID: 858
		private object lockStatus = new object();

		// Token: 0x0400035B RID: 859
		private int indexCbbThuMucOld = -1;

		// Token: 0x0400035C RID: 860
		private bool isExcute_CbbThuMuc_SelectedIndexChanged = true;

		// Token: 0x0400035D RID: 861
		private object objLock = new object();

		// Token: 0x0400035E RID: 862
		private object _lock = new object();

		// Token: 0x0400035F RID: 863
		private object _lock2 = new object();

		// Token: 0x04000360 RID: 864
		private object _lock3 = new object();

		// Token: 0x04000361 RID: 865
		private object _lock4 = new object();

		// Token: 0x04000362 RID: 866
		private int indexCbbTinhTrangOld = -1;

		// Token: 0x04000363 RID: 867
		private bool isExcute_CbbTinhTrang_SelectedIndexChanged = true;

		// Token: 0x04000364 RID: 868
		private JSON_Settings setting_MoTrinhDuyet;

		// Token: 0x04000365 RID: 869
		private List<TinsoftProxy> listTinsoft = null;

		// Token: 0x04000366 RID: 870
		private List<XproxyProxy> listxProxy = null;

		// Token: 0x04000367 RID: 871
		private List<TMProxy> listTMProxy = null;

		// Token: 0x04000368 RID: 872
		private List<string> listApiTinsoft = null;

		// Token: 0x04000369 RID: 873
		private List<string> listProxyXproxy = null;

		// Token: 0x0400036A RID: 874
		private List<string> listProxyTMProxy = null;

		// Token: 0x0400036B RID: 875
		private List<Thread> lstThread = null;
	}
}
