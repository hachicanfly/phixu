using System;
using System.Data;
using System.Text;
using ConversionBack;

namespace maxcare
{
	// Token: 0x020000D5 RID: 213
	public class Connector2
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00173994 File Offset: 0x00171B94
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x001739C8 File Offset: 0x00171BC8
		public static Connector2 Instance
		{
			get
			{
				bool flag = Connector2.instance == null;
				if (flag)
				{
					Connector2.instance = new Connector2();
				}
				return Connector2.instance;
			}
			private set
			{
				Connector2.instance = value;
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x001739E4 File Offset: 0x00171BE4
		private Connector2()
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00173A44 File Offset: 0x00171C44
		public DataTable ExecuteQuery(string query)
		{
			object[] parameters = new object[]
			{
				this,
				query
			};
			return (DataTable)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3279280, 288, 1685, parameters);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00173A9C File Offset: 0x00171C9C
		public int ExecuteNonQuery(string query)
		{
			object[] parameters = new object[]
			{
				this,
				query
			};
			return (int)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3279568, 320, 1686, parameters);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00173AF4 File Offset: 0x00171CF4
		public object ExecuteScalar(string query)
		{
			object[] parameters = new object[]
			{
				this,
				query
			};
			return (object)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(3279888, 304, 1687, parameters);
		}

		// Token: 0x04000C6B RID: 3179
		private static Connector2 instance;

		// Token: 0x04000C6C RID: 3180
		private string connectionSTR = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IwMUdiRlJSYkZKcFRURmFOVmRVU2xaUFZuQklVbXBDV2xZd2NHOVpla3BXWkd4d1NGTnRXbXBTZW13MldrVk5NV0V4YkhGa1JtUmhWMFZ3TmxsV1l6VmtWa0pWVkZSalBRPT0="))))))));
	}
}
