using System;
using System.Runtime.InteropServices;

namespace MCommon
{
	// Token: 0x0200002D RID: 45
	[StructLayout(LayoutKind.Explicit)]
	public struct MOUSEKEYBDHARDWAREINPUT
	{
		// Token: 0x040001BC RID: 444
		[FieldOffset(0)]
		public HARDWAREINPUT Hardware;

		// Token: 0x040001BD RID: 445
		[FieldOffset(0)]
		public KEYBDINPUT Keyboard;

		// Token: 0x040001BE RID: 446
		[FieldOffset(0)]
		public MOUSEINPUT Mouse;
	}
}
