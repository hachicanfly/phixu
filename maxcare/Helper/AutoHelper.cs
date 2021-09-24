using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace maxcare.Helper
{
	// Token: 0x0200018E RID: 398
	public class AutoHelper
	{
		// Token: 0x060011BE RID: 4542 RVA: 0x0041145C File Offset: 0x0040F65C
		public static void CaptureApplication(Process proc, string pathToSave)
		{
			AutoHelper.User32.Rect rect = default(AutoHelper.User32.Rect);
			AutoHelper.User32.GetWindowRect(proc.MainWindowHandle, ref rect);
			int width = rect.right - rect.left;
			int height = rect.bottom - rect.top;
			Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
			}
			bitmap.Save(pathToSave, ImageFormat.Png);
		}

		// Token: 0x0200018F RID: 399
		private class User32
		{
			// Token: 0x060011C0 RID: 4544
			[DllImport("user32.dll")]
			public static extern IntPtr GetWindowRect(IntPtr hWnd, ref AutoHelper.User32.Rect rect);

			// Token: 0x02000190 RID: 400
			public struct Rect
			{
				// Token: 0x04001B27 RID: 6951
				public int left;

				// Token: 0x04001B28 RID: 6952
				public int top;

				// Token: 0x04001B29 RID: 6953
				public int right;

				// Token: 0x04001B2A RID: 6954
				public int bottom;
			}
		}
	}
}
