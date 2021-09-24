using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;
using ConversionBack;

namespace MCommon
{
	// Token: 0x02000038 RID: 56
	public class Connector
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
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

		// Token: 0x06000120 RID: 288 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		private Connector()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000C45C File Offset: 0x0000A65C
		private void CheckConnectServer()
		{
			object[] parameters = new object[]
			{
				this
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(66896, 416, 139, parameters);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000C4A4 File Offset: 0x0000A6A4
		public DataTable ExecuteQuery(string query)
		{
			object[] parameters = new object[]
			{
				this,
				query
			};
			return (DataTable)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(67312, 400, 140, parameters);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000C4FC File Offset: 0x0000A6FC
		public DataTable ExecuteQuery(List<string> lstQuery)
		{
			object[] parameters = new object[]
			{
				this,
				lstQuery
			};
			return (DataTable)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(67712, 528, 141, parameters);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000C554 File Offset: 0x0000A754
		public int ExecuteNonQuery(List<string> lstQuery)
		{
			object[] parameters = new object[]
			{
				this,
				lstQuery
			};
			return (int)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(68240, 512, 142, parameters);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000C5AC File Offset: 0x0000A7AC
		public int ExecuteNonQuery(string query)
		{
			object[] parameters = new object[]
			{
				this,
				query
			};
			return (int)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(68752, 400, 143, parameters);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000C604 File Offset: 0x0000A804
		public int ExecuteScalar(string query)
		{
			object[] parameters = new object[]
			{
				this,
				query
			};
			return (int)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(69152, 432, 144, parameters);
		}

		// Token: 0x040001E3 RID: 483
		private static Connector instance;

		// Token: 0x040001E4 RID: 484
		private string connectionSTR = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IwMUdiRlJSYkZKcFRURmFOVmRVU2xaUFZuQklVbXBDV2xZd2NHOVpla3BXWkd4d1NGTnRXbWxXTUZrd1YxUktSMlZXY0ZST1dIQnFWak5vZDFwRlpGWk9NVnAwVm01c2FrMXRlREpaYlc5M1pXczVNMUJVTUQwPQ=="))))))));

		// Token: 0x040001E5 RID: 485
		private SQLiteConnection connection = null;
	}
}
