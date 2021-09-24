using System;

namespace maxcare.Helper
{
	// Token: 0x020001A2 RID: 418
	public class StringHelper
	{
		// Token: 0x06001209 RID: 4617 RVA: 0x00413044 File Offset: 0x00411244
		public static bool CheckStringIsNumber(string content)
		{
			try
			{
				int num = Convert.ToInt32(content);
				return true;
			}
			catch
			{
			}
			return false;
		}
	}
}
