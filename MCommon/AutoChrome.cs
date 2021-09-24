using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;
using ConversionBack;

namespace MCommon
{
	// Token: 0x02000011 RID: 17
	public class AutoChrome
	{
		// Token: 0x06000037 RID: 55 RVA: 0x0000217C File Offset: 0x0000037C
		public AutoChrome(Chrome chrome)
		{
			this.process = chrome.process;
			this.intPtrChrome = this.process.MainWindowHandle;
			this.chrome = chrome;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000021AD File Offset: 0x000003AD
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000021B5 File Offset: 0x000003B5
		public Process process { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000021BE File Offset: 0x000003BE
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000021C6 File Offset: 0x000003C6
		public IntPtr intPtrChrome { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000021CF File Offset: 0x000003CF
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000021D7 File Offset: 0x000003D7
		public Chrome chrome { get; set; }

		// Token: 0x0600003E RID: 62 RVA: 0x0000567C File Offset: 0x0000387C
		public Image CaptureWindow(IntPtr handle)
		{
			IntPtr windowDC = User32.GetWindowDC(handle);
			User32.RECT rect = default(User32.RECT);
			User32.GetWindowRect(handle, ref rect);
			int nWidth = rect.right - rect.left;
			int nHeight = rect.bottom - rect.top;
			IntPtr intPtr = GDI32.CreateCompatibleDC(windowDC);
			IntPtr intPtr2 = GDI32.CreateCompatibleBitmap(windowDC, nWidth, nHeight);
			IntPtr hObject = GDI32.SelectObject(intPtr, intPtr2);
			GDI32.BitBlt(intPtr, 0, 0, nWidth, nHeight, windowDC, 0, 0, 13369376);
			GDI32.SelectObject(intPtr, hObject);
			GDI32.DeleteDC(intPtr);
			User32.ReleaseDC(handle, windowDC);
			Image result = Image.FromHbitmap(intPtr2);
			GDI32.DeleteObject(intPtr2);
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005744 File Offset: 0x00003944
		public bool ScreenCapture(string imagePathFolder, string fileName)
		{
			bool result = false;
			try
			{
				(this.CaptureWindow(this.intPtrChrome) as Bitmap).Save(imagePathFolder + (imagePathFolder.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9"))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9"))))))))) + fileName + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMVEyUldjRE5RVkRBOQ==")))))))), ImageFormat.Png);
				result = true;
			}
			catch (Exception ex)
			{
				AutoChrome.ExportError(null, ex, string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZab1YwMUhTWGRVYlRscVlsUnNNRmRzVFRGV1JtdDZVMjE0WVZaNlZrVlhWbWhEVFVkU1dWTnRlRXhSVkRBNQ==")))))))),
					imagePathFolder,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))),
					fileName,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))))
				}));
			}
			return result;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005A10 File Offset: 0x00003C10
		public Bitmap ScreenCapture(int count = 1)
		{
			Bitmap result = null;
			try
			{
				for (int i = 0; i < count; i++)
				{
					try
					{
						result = (Bitmap)this.CaptureWindow(this.intPtrChrome);
						break;
					}
					catch (Exception ex)
					{
						AutoChrome.ExportError(this, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS1IyUXlVa2xXYm14aFZtMVNkMWx0TVZOa2JWSXpVRlF3UFE9PQ==")))))))));
						Common.DelayTime(1.0);
					}
				}
			}
			catch (Exception ex2)
			{
				AutoChrome.ExportError(null, ex2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZab1YwMUhTWGRVYlRscVlsUnNNRmRzVFRGV1JtdDZVMjE0WVZaNlZrVlhWbWhEVFVkU1dWTnRlRXhSTW5NNQ==")))))))));
			}
			return result;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005B68 File Offset: 0x00003D68
		public void DelayTime(double timeDelay_Seconds)
		{
			try
			{
				Thread.Sleep(Convert.ToInt32(timeDelay_Seconds * 1000.0));
			}
			catch (Exception ex)
			{
				AutoChrome.ExportError(null, ex, string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyVlhTWGxOVjNoTllURktjMWxyWkVkT1ZscElZa2hTWVZVeVp6TlVWV2QzWTBFOVBRPT0=")))))))), timeDelay_Seconds));
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005C18 File Offset: 0x00003E18
		public bool CompareImage(Bitmap mainBitmap, Bitmap subBitmap, double percent = 0.9)
		{
			object[] parameters = new object[]
			{
				this,
				mainBitmap,
				subBitmap,
				percent
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(16848, 368, 35, parameters);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005C90 File Offset: 0x00003E90
		public bool CheckCanScroll(int force, double delayPerTimes, int timeDelay = 0, int type = 0)
		{
			Bitmap subBitmap = this.ScreenCapture(1);
			bool flag = type == 0;
			if (flag)
			{
				this.ScrollDown(force, delayPerTimes);
			}
			else
			{
				this.ScrollTop(force, delayPerTimes);
			}
			this.DelayTime((double)timeDelay);
			Bitmap mainBitmap = this.ScreenCapture(1);
			return !this.CompareImage(mainBitmap, subBitmap, 0.9);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005D40 File Offset: 0x00003F40
		public bool CheckCanScrollChrome(int distance, int timeDelay = 0, int type = 0)
		{
			distance *= 100;
			Bitmap subBitmap = this.ScreenCapture(1);
			bool flag = type == 0;
			if (flag)
			{
				this.ScrollChrome(distance);
			}
			else
			{
				this.ScrollChrome(-distance);
			}
			this.DelayTime((double)timeDelay);
			Bitmap mainBitmap = this.ScreenCapture(1);
			return !this.CompareImage(mainBitmap, subBitmap, 0.9);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00005DF8 File Offset: 0x00003FF8
		public Point? FindImage(string ImagePath, int timeSearchImage_Second = 0)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(ImagePath);
			FileInfo[] files = directoryInfo.GetFiles();
			int tickCount = Environment.TickCount;
			Point? point;
			Bitmap bitmap2;
			do
			{
				Bitmap bitmap = this.ScreenCapture(3);
				bool flag = bitmap == null;
				if (flag)
				{
					break;
				}
				point = null;
				foreach (FileInfo fileInfo in files)
				{
					bitmap2 = (Bitmap)Image.FromFile(fileInfo.FullName);
					point = ImageScanOpenCV.FindOutPoint(bitmap, bitmap2, 0.9);
					bool flag2 = point != null;
					if (flag2)
					{
						goto Block_2;
					}
				}
				Common.DelayTime(1.0);
			}
			while (Environment.TickCount - tickCount <= timeSearchImage_Second * 1000);
			goto IL_161;
			Block_2:
			int x = point.Value.X + new Random().Next(0, bitmap2.Width * 3 / 4);
			int y = point.Value.Y + new Random().Next(0, bitmap2.Height * 3 / 4);
			return new Point?(new Point(x, y));
			IL_161:
			return null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005F7C File Offset: 0x0000417C
		public bool CheckExistImage(string ImagePath, int timeSearchImage_Second = 0)
		{
			return this.FindImage(ImagePath, timeSearchImage_Second) != null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005FC8 File Offset: 0x000041C8
		public int CheckExistImages(double timeWait_Second = 0.0, params string[] ImagePaths)
		{
			int result = 0;
			try
			{
				int tickCount = Environment.TickCount;
				int i;
				for (;;)
				{
					for (i = 0; i < ImagePaths.Length; i++)
					{
						bool flag = this.CheckExistImage(ImagePaths[i], 0);
						if (flag)
						{
							goto Block_3;
						}
					}
					bool flag2 = (double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0;
					if (flag2)
					{
						goto Block_5;
					}
					Thread.Sleep(1000);
				}
				Block_3:
				return i + 1;
				Block_5:;
			}
			catch (Exception ex)
			{
				AutoChrome.ExportError(null, ex, string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZab1YwMUhTWGRVYlRscVlsUnNNRmRzVFRGU1IwWklWbTF3YUUxR1dUQlpWbWhQVFVaT1dFMVhhR0ZOYkZvMlV6Qm9lbVF5V2xSbFJHUk9WMFJDZHc9PQ==")))))))), timeWait_Second, string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))), ImagePaths)));
			}
			return result;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006164 File Offset: 0x00004364
		public bool Click(string ImagePath, int timeSearchImage_Second = 3)
		{
			bool result = false;
			try
			{
				Point? point = this.FindImage(ImagePath, timeSearchImage_Second);
				bool flag = point != null;
				if (flag)
				{
					AutoControl.SendClickOnPosition(this.intPtrChrome, point.Value.X, point.Value.Y, EMouseKey.LEFT, 1);
					result = true;
				}
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006214 File Offset: 0x00004414
		public bool SendKeys(string content)
		{
			bool result = false;
			try
			{
				AutoControl.SendTextKeyBoard(this.intPtrChrome, content, 0.1f);
				result = true;
			}
			catch (Exception ex)
			{
				AutoChrome.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZab1YwMUhTWGRVYlRscVlsUnNNRmRzVFRGV1JuQllUbGQwVkUxc1dURlpNMnh1VUZFOVBRPT0=")))))))) + content + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9")))))))));
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006318 File Offset: 0x00004518
		public bool SendKeys(string content, double timeDelay_Second)
		{
			bool result = false;
			try
			{
				for (int i = 0; i < content.Length; i++)
				{
					AutoControl.SendTextKeyBoard(this.intPtrChrome, content[i].ToString(), 0.1f);
					Thread.Sleep(Convert.ToInt32(timeDelay_Second * 1000.0));
				}
				result = true;
			}
			catch (Exception ex)
			{
				AutoChrome.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZab1YwMUhTWGRVYlRscVlsUnNNRmRzVFRGV1JuQllUbGQwVkUxc1dURlpNMnh1VUZFOVBRPT0=")))))))) + content + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9")))))))));
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006474 File Offset: 0x00004674
		public bool SendKeysChrome(string content)
		{
			/*
An exception occurred when decompiling this method (0600004B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean MCommon.AutoChrome::SendKeysChrome(System.String)
 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1589
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1576
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1576
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006570 File Offset: 0x00004770
		public bool SendKeysChrome(string content, double timeDelay_Second)
		{
			/*
An exception occurred when decompiling this method (0600004C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean MCommon.AutoChrome::SendKeysChrome(System.String,System.Double)
 ---> System.Exception: Inconsistent stack size at IL_58
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 279
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 269
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006688 File Offset: 0x00004888
		public bool SendEnter()
		{
			bool result = false;
			try
			{
				AutoControl.SendKeyBoardPress(this.intPtrChrome, VKeys.VK_RETURN);
				result = true;
			}
			catch (Exception ex)
			{
				AutoChrome.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZab1YwMUhTWGRVYlRscVlsUnNNRmRzVFRGV1JuQllUbGQwVTFaNlZYZFhiR2hLWWpCMFVsQlVNRDA9")))))))));
			}
			return result;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006738 File Offset: 0x00004938
		public void Close()
		{
			try
			{
				this.process.Kill();
			}
			catch (Exception ex)
			{
				AutoChrome.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZab1YwMUhTWGRVYlRscVlsUnNNRmRzVFRGU1IwcElUMWh3WVZVeVpIYz0=")))))))));
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000067D0 File Offset: 0x000049D0
		public void ScrollChrome(int distance)
		{
			try
			{
				this.chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tSS2MyUldjRWhQVkU1TlltczFjVmt5TURWak1rcEdVMnBXVEZOSVRtNWFSV00xWkRBNWNGRlVNRDA9")))))))) + distance.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWa1MySkhSa2hTYWtwb1ZucHNOVlF5YkVKaWJVMTVUVmhhYVUweFNuWlRhazEzWTBVNU0xQlVNRDA9")))))))));
			}
			catch
			{
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000068B4 File Offset: 0x00004AB4
		public bool Click(int X, int Y)
		{
			bool result = false;
			try
			{
				AutoControl.SendClickOnPosition(this.intPtrChrome, X, Y, EMouseKey.LEFT, 1);
				result = true;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006928 File Offset: 0x00004B28
		public bool Click(Point? point)
		{
			bool result = false;
			try
			{
				bool flag = point != null;
				if (flag)
				{
					AutoControl.SendClickOnPosition(this.intPtrChrome, point.Value.X, point.Value.Y, EMouseKey.LEFT, 1);
					result = true;
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000069C8 File Offset: 0x00004BC8
		public void ScrollDown(int force = 10, double delay = 100.0)
		{
			try
			{
				for (int i = 0; i < force; i++)
				{
					AutoControl.SendKeyBoardPress(this.intPtrChrome, VKeys.VK_DOWN);
					this.DelayTime(delay);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006A4C File Offset: 0x00004C4C
		public void ScrollTop(int force = 10, double delay = 100.0)
		{
			try
			{
				for (int i = 0; i < force; i++)
				{
					AutoControl.SendKeyBoardPress(this.intPtrChrome, VKeys.VK_UP);
					this.DelayTime(delay);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006AD0 File Offset: 0x00004CD0
		public static void ExportError(AutoChrome autoChrome, Exception ex, string error = "")
		{
			try
			{
				bool flag = !Directory.Exists(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSm5QVDA9")))))))));
				if (flag)
				{
					Directory.CreateDirectory(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSm5QVDA9")))))))));
				}
				bool flag2 = !Directory.Exists(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhpU0ZKYVZqSlNjMWt6WXpsUVVUMDk=")))))))));
				if (flag2)
				{
					Directory.CreateDirectory(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhpU0ZKYVZqSlNjMWt6WXpsUVVUMDk=")))))))));
				}
				Random random = new Random();
				string text = string.Concat(new string[]
				{
					DateTime.Now.Day.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Month.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Year.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Hour.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Minute.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Second.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					random.Next(1000, 9999).ToString()
				});
				bool flag3 = autoChrome != null;
				if (flag3)
				{
					autoChrome.ScreenCapture(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhpU0ZKYVZqSlNjMWw2UmpOUVVUMDk=")))))))), text);
				}
				using (StreamWriter streamWriter = new StreamWriter(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhsU0ZwaFpWUlZkMXBWYUZKUVVUMDk=")))))))), true))
				{
					streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaTmQyUkZlRlJOU0ZKTlZYcENNRlJHVFhka1JYaFVUVWhTVFZWNlFqQlVSazEzWkVWNFZFMUlVazFWZWtJd1ZFWk5kMlJGZUZSTlNGSk5WWHBDTUZSR1RYZGtSWGhVVFVoU1RWVjZRakJVUmsxM1pFVjRWRTFJVWsxVmVrSXdWRVpOZDJSRmVGUk5TRkpOVlhwQ01GUkdUWGRrUlhoVVRVaFNUVlY2UWpCVVJrMTNaRVY0VkUxRU1EMD0=")))))))));
					streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IwMUdjRlZpTW1NOQ==")))))))) + DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1VtUnNVbFpOU0Zwc1YwZDNNVnBXVGtOVFZrNUZZMGhTYVZaSVFqWlpNMk01VUZFOVBRPT0="))))))))));
					streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweGMyTXhjRlZpTW1NOQ==")))))))) + text);
					bool flag4 = error != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag4)
					{
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4b1MyVlhTWHBUVkZwS1VWUXdPUT09")))))))) + error);
					}
					streamWriter.WriteLine();
					bool flag5 = ex != null;
					if (flag5)
					{
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10b2MyUXhjRlZpTW1NOQ==")))))))) + ex.GetType().FullName);
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaa1YyVnRUWGxTYlRWaFZrYzViZz09")))))))) + ex.Message);
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxST1UyRkdhM2xrUmxacVlsVmFjVmRzVW5aYWR6MDk=")))))))) + ex.StackTrace);
						ex = ex.InnerException;
					}
				}
			}
			catch
			{
			}
		}
	}
}
