using System;
using System.Text;
using System.Threading;

namespace MCommon
{
	// Token: 0x02000016 RID: 22
	internal class ProxyWeb
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00007620 File Offset: 0x00005820
		public ProxyWeb(string apiKey, string proxy, int typeProxy, int limit_theads_use)
		{
			this.apiKey = apiKey;
			this.proxy = proxy;
			this.limit_theads_use = limit_theads_use;
			this.ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.typeProxy = typeProxy;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007714 File Offset: 0x00005914
		public bool ChangeProxy()
		{
			bool result = false;
			try
			{
				string url = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNiMWt3WkhKa1YwNUpVMjVhYkZOSGQzbFViV3N4WkZad1dWVllXbHBYUlVwM1ZFUk9TMkpIVFhsV2FrSk5Wako0TTFSR1kzaGhSMHAxVm0xb2FWSkViRzlaTUdSeldtMUZlVlpxVmxGVlZEQTU=")))))))) + this.apiKey;
				string data = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xoc1MySXlTWHBVYWtKS1lXMDVibE5YWXpsUVVUMDk=")))))))),
					this.proxy.Split(new char[]
					{
						':'
					})[0],
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkc00xb3diSFZSYmxwcVlteEdjRlF5YkVKUVVUMDk=")))))))),
					this.proxy.Split(new char[]
					{
						':'
					})[1],
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V214Rk9WQlJQVDA9"))))))))
				});
				RequestXNet requestXNet = new RequestXNet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
				string text = requestXNet.RequestPost(url, data, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlTa2hpUjNCYVYwWktkMWxxU1RCa2JVWjFWRzVhYVZwNk1Eaz0=")))))))));
				bool flag = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1YyVnRUWGxTYlRWaFZWUXdPUT09")))))))).ToString() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSR1YxSkdSWGRXYkZKV1pIb3dPUT09"))))))));
				if (flag)
				{
					for (int i = 0; i < 120; i++)
					{
						bool flag2 = this.CheckLiveProxy();
						if (flag2)
						{
							Thread.Sleep(1000);
							return true;
						}
						Thread.Sleep(1000);
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007B48 File Offset: 0x00005D48
		public void DecrementDangSuDung()
		{
			object obj = this.k;
			lock (obj)
			{
				this.dangSuDung--;
				bool flag2 = this.dangSuDung == 0 && this.daSuDung == this.limit_theads_use;
				if (flag2)
				{
					this.daSuDung = 0;
				}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007C04 File Offset: 0x00005E04
		public bool CheckLiveProxy()
		{
			/*
An exception occurred when decompiling this method (0600006C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean MCommon.ProxyWeb::CheckLiveProxy()
 ---> System.Exception: Inconsistent stack size at IL_550
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 279
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0400003D RID: 61
		private object k = new object();

		// Token: 0x0400003E RID: 62
		private object k1 = new object();

		// Token: 0x0400003F RID: 63
		public int typeProxy;

		// Token: 0x04000040 RID: 64
		private string apiKey;

		// Token: 0x04000041 RID: 65
		public string proxy;

		// Token: 0x04000042 RID: 66
		public string ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x04000043 RID: 67
		public int dangSuDung = 0;

		// Token: 0x04000044 RID: 68
		public int daSuDung = 0;

		// Token: 0x04000045 RID: 69
		public int limit_theads_use = 3;
	}
}
