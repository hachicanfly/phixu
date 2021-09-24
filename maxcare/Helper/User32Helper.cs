using System;
using System.Runtime.InteropServices;

namespace maxcare.Helper
{
	// Token: 0x0200018D RID: 397
	public class User32Helper
	{
		// Token: 0x060011BB RID: 4539
		[DllImport("user32.dll", SetLastError = true)]
		public static extern long SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

		// Token: 0x060011BC RID: 4540
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);
	}
}
