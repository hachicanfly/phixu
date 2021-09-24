using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Helper;
using maxcare.Properties;
using MCommon;

namespace maxcare
{
	// Token: 0x020000E3 RID: 227
	public partial class fThemSizeChrome : Form
	{
		// Token: 0x06000919 RID: 2329 RVA: 0x00002F34 File Offset: 0x00001134
		public fThemSizeChrome()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0017E11C File Offset: 0x0017C31C
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblTitle);
			Language.GetValue(this.grDanhSach);
			Language.GetValue(this.label1);
			foreach (object obj in this.dtgvDanhSach.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
			Language.GetValue(this.btnAdd);
			Language.GetValue(this.label2);
			Language.GetValue(this.label3);
			Language.GetValue(this.btnSave);
			Language.GetValue(this.btnHuy);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0017E21C File Offset: 0x0017C41C
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
			this.LoadDsFile();
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0017E238 File Offset: 0x0017C438
		private void LoadContentFileFromDtgv(int row)
		{
			try
			{
				this.txtTen.Text = DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ==")))))))));
				string statusDataGridView = DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QyTkhWblJXVkRBOQ==")))))))));
				this.txtPixelRatio.Text = ((DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyTkhWa2hXYms1V1lsVlpkMWxXWXpSUVVUMDk="))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9")))))))) : DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, row, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1EyTkhWa2hXYms1V1lsVlpkMWxXWXpSUVVUMDk="))))))))));
				this.nudWidth.Value = Convert.ToInt32(statusDataGridView.Split(new char[]
				{
					'x'
				})[0]);
				this.nudHeight.Value = Convert.ToInt32(statusDataGridView.Split(new char[]
				{
					'x'
				})[1]);
			}
			catch
			{
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0017E520 File Offset: 0x0017C720
		private void LoadDsFile()
		{
			/*
An exception occurred when decompiling this method (0600091D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void maxcare.fThemSizeChrome::LoadDsFile()
 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0017EC1C File Offset: 0x0017CE1C
		private void rControl(int type)
		{
			switch (type)
			{
			case 1:
				this.grDanhSach.Enabled = false;
				this.grChiTiet.Enabled = true;
				this.txtTen.Clear();
				this.txtTen.Focus();
				this.nudWidth.Value = 0m;
				this.nudHeight.Value = 0m;
				break;
			case 2:
				this.grDanhSach.Enabled = true;
				this.grChiTiet.Enabled = false;
				break;
			case 3:
				this.grDanhSach.Enabled = false;
				this.grChiTiet.Enabled = true;
				break;
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0017ED38 File Offset: 0x0017CF38
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			this.rControl(1);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0017ED58 File Offset: 0x0017CF58
		private void dtgvDanhSach_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
			string name = this.dtgvDanhSach.Columns[e.ColumnIndex].Name;
			bool flag = name != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMVdiRkpRVkRBOQ==")))))))) && name != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR2IyUnNiRkpRVkRBOQ=="))))))));
			if (flag)
			{
				this.dtgvDanhSach.Cursor = Cursors.Default;
			}
			else
			{
				bool flag2 = e.RowIndex < this.dtgvDanhSach.RowCount;
				if (flag2)
				{
					this.dtgvDanhSach.Cursor = Cursors.Hand;
				}
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0017EE90 File Offset: 0x0017D090
		private void dtgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			bool flag = dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0;
			if (flag)
			{
				string name = dataGridView.Columns[e.ColumnIndex].Name;
				string a = name;
				if (!(a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR1QwMVdiRkpRVkRBOQ=="))))))))))
				{
					if (a == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSR2IyUnNiRkpRVkRBOQ==")))))))))
					{
						bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWTNoTlZGSnBaRlpLYVdGVlNUQmtlbVJQWVVaQ00xQlVNRDA9")))))))))) == DialogResult.Yes;
						if (flag2)
						{
							JSON_Settings json_Settings = new JSON_Settings(new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWU1RXMW9OVmxxU1hoaVFUMDk=")))))))), false).GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS2MwNXNjRlpVYlRscVlsUnNNRmRzUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))), true);
							json_Settings.Remove(DatagridviewHelper.GetStatusDataGridView(this.dtgvDanhSach, this.dtgvDanhSach.CurrentRow.Index, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSQk1XRkhTbGhXVkRBOQ=="))))))))));
							JSON_Settings json_Settings2 = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWU1RXMW9OVmxxU1hoaVFUMDk=")))))))), false);
							json_Settings2.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS2MwNXNjRlpVYlRscVlsUnNNRmRzUlRsUVVUMDk=")))))))), json_Settings.GetFullString());
							json_Settings2.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
							this.LoadDsFile();
						}
					}
				}
				else
				{
					this.rControl(3);
				}
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0017F294 File Offset: 0x0017D494
		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.txtTen.Text.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WTVZSVmJVWnNVbnBrYmxaNlVtNWFSVEZRWTFkS2NGRnFRbWhTTWpWdlpGaEpOVTFGYkVoVVIyZ3hUa2hPYnc9PQ=="))))))))), 3);
				}
				else
				{
					bool flag2 = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWTNoTlZGSnBaRlpLYVdGVlNucGxTRXBEVFZWc1NHVnRhREZqVlZwM1ZVaGpPVkJSUFQwPQ==")))))))))) == DialogResult.Yes;
					if (flag2)
					{
						JSON_Settings json_Settings = new JSON_Settings(new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWU1RXMW9OVmxxU1hoaVFUMDk=")))))))), false).GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS2MwNXNjRlpVYlRscVlsUnNNRmRzUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))), true);
						json_Settings.Update(this.txtTen.Text.Trim(), string.Concat(new string[]
						{
							this.nudWidth.Value.ToString(),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xWRk9WQlJQVDA9")))))))),
							this.nudHeight.Value.ToString(),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xWRk9WQlJQVDA9")))))))),
							this.txtPixelRatio.Text.Trim()
						}));
						JSON_Settings json_Settings2 = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWU1RXMW9OVmxxU1hoaVFUMDk=")))))))), false);
						json_Settings2.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS2MwNXNjRlpVYlRscVlsUnNNRmRzUlRsUVVUMDk=")))))))), json_Settings.GetFullString());
						json_Settings2.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
						this.LoadDsFile();
						this.rControl(2);
					}
				}
			}
			catch
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JWSkhPVFZSYlhBelRqQXhibGxyT1VoT01uZDVZVEprYkZRd1l6SmllazV5V2pKT2RGSllUa3BUUm05NFdWWk9RMk16WXpOVGJsWmhaVlZKZDFsVk9VaE9NMHBVVVc1Tk1GbHVSbTlaVms1RFpXeHNXVlpYWnowPQ=="))))))))), 2);
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0017F760 File Offset: 0x0017D960
		private void btnHuy_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = MessageBoxHelper.ShowMessageBoxWithQuestion(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVQwVTVObE5WWTNoTlZGSnBaRlpLYVdGVlNuWk9SMG94WW0xV1ZVOUVNRDA9")))))))))) == DialogResult.Yes;
				if (flag)
				{
					this.rControl(2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0017F808 File Offset: 0x0017DA08
		private void dtgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			this.LoadContentFileFromDtgv(this.dtgvDanhSach.CurrentRow.Index);
		}

		// Token: 0x04000CD7 RID: 3287
		private Random rd = new Random();
	}
}
