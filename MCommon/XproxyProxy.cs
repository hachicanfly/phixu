using System;
using System.Text;
using ConversionBack;

namespace MCommon
{
	// Token: 0x02000059 RID: 89
	internal class XproxyProxy
	{
		// Token: 0x0600037A RID: 890 RVA: 0x0005488C File Offset: 0x00052A8C
		public XproxyProxy(string ServicesURL, string proxy, int typeProxy, int limit_theads_use)
		{
			this.ServicesURL = ServicesURL;
			this.proxy = proxy;
			this.limit_theads_use = limit_theads_use;
			this.ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.typeProxy = typeProxy;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00054970 File Offset: 0x00052B70
		private void ExportToFile(string content)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00054984 File Offset: 0x00052B84
		public bool ResetProxy()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1098768, 2528, 533, parameters);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000549CC File Offset: 0x00052BCC
		public bool ChangeProxy()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1101296, 2624, 534, parameters);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00054A14 File Offset: 0x00052C14
		public void DecrementDangSuDung(int typeRun)
		{
			this.dangSuDung--;
			bool flag = typeRun == 0;
			if (flag)
			{
				bool flag2 = this.dangSuDung == 0 && this.daSuDung == this.limit_theads_use;
				if (flag2)
				{
					this.daSuDung = 0;
				}
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00054AA0 File Offset: 0x00052CA0
		public bool CheckLiveProxy(int timeOut = -1)
		{
			/*
An exception occurred when decompiling this method (0600037F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean MCommon.XproxyProxy::CheckLiveProxy(System.Int32)
 ---> System.Exception: Inconsistent stack size at IL_800
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 279
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0400028B RID: 651
		public int typeProxy;

		// Token: 0x0400028C RID: 652
		private string ServicesURL;

		// Token: 0x0400028D RID: 653
		public string proxy;

		// Token: 0x0400028E RID: 654
		public string ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x0400028F RID: 655
		public bool isProxyLive = true;

		// Token: 0x04000290 RID: 656
		public int dangSuDung = 0;

		// Token: 0x04000291 RID: 657
		public int daSuDung = 0;

		// Token: 0x04000292 RID: 658
		public int limit_theads_use = 3;
	}
}
