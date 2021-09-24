using System;
using ConversionBack;

namespace maxcare.Helper
{
	// Token: 0x0200019C RID: 412
	internal class EmailHelper
	{
		// Token: 0x060011E0 RID: 4576 RVA: 0x00412200 File Offset: 0x00410400
		public static void DeleteMail(string username, string password, string imap = "")
		{
			object[] parameters = new object[]
			{
				username,
				password,
				imap
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8430016, 3392, 3338, parameters);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00412268 File Offset: 0x00410468
		public static string GetOtpFromMail(int type, string username, string password, int timeout = 10, string imap = "")
		{
			object[] parameters = new object[]
			{
				type,
				username,
				password,
				timeout,
				imap
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8433408, 6544, 3339, parameters);
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x004122F0 File Offset: 0x004104F0
		public static string GetOtpFromMail2(int type, string username, string password, string subUser, int timeout = 10, string imap = "")
		{
			object[] parameters = new object[]
			{
				type,
				username,
				password,
				subUser,
				timeout,
				imap
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8439952, 4944, 3340, parameters);
		}
	}
}
