using System;
using System.Data;
using System.Data.SQLite;
using System.Text;
using ConversionBack;

namespace maxcare.KichBan
{
	// Token: 0x0200018B RID: 395
	public class Connector
	{
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0040E1B0 File Offset: 0x0040C3B0
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x0040E1E4 File Offset: 0x0040C3E4
		public static Connector Instance
		{
			get
			{
				bool flag = Connector.instance == null;
				if (flag)
				{
					Connector.instance = new Connector();
				}
				return Connector.instance;
			}
			private set
			{
				Connector.instance = value;
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0040E200 File Offset: 0x0040C400
		private Connector()
		{
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0040E268 File Offset: 0x0040C468
		private void CheckConnectServer()
		{
			object[] parameters = new object[]
			{
				this
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8394352, 416, 3294, parameters);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0040E2B0 File Offset: 0x0040C4B0
		public DataTable ExecuteQuery(string query)
		{
			object[] parameters = new object[]
			{
				this,
				query
			};
			return (DataTable)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8394768, 224, 3295, parameters);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0040E308 File Offset: 0x0040C508
		public int ExecuteNonQuery(string query)
		{
			object[] parameters = new object[]
			{
				this,
				query
			};
			return (int)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8394992, 208, 3296, parameters);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0040E360 File Offset: 0x0040C560
		public int ExecuteScalar(string query)
		{
			object[] parameters = new object[]
			{
				this,
				query
			};
			return (int)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8395200, 224, 3297, parameters);
		}

		// Token: 0x04001B24 RID: 6948
		private static Connector instance;

		// Token: 0x04001B25 RID: 6949
		private string connectionSTR = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IwMUdiRlJSYkZKcFRURmFOVmRVU2xaUFYwWllUbFJDWVZkRmNHOVhWRTVUV1RKR1dFNVVRbUZYUlhCdlYxUk9VbVJYVFhwU2JrNW9WMFpLYzFSNlJtRmlSMDUxVkc1Q2FVMXFVVFZVV0hCNlVGRTlQUT09"))))))));

		// Token: 0x04001B26 RID: 6950
		private SQLiteConnection connection = null;
	}
}
