using System;
using System.Runtime.InteropServices;

namespace maxcare
{
	// Token: 0x020000FB RID: 251
	internal class InternetConnection
	{
		// Token: 0x06000A31 RID: 2609
		[DllImport("wininet.dll")]
		private static extern bool InternetGetConnectedState(out int description, int reservedValuine);

		// Token: 0x06000A32 RID: 2610 RVA: 0x001CE468 File Offset: 0x001CC668
		public static bool IsConnectedToInternet()
		{
			int num;
			return InternetConnection.InternetGetConnectedState(out num, 0);
		}
	}
}
