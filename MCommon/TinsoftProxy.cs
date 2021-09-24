using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using ConversionBack;

namespace MCommon
{
	// Token: 0x02000052 RID: 82
	internal class TinsoftProxy
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000338 RID: 824 RVA: 0x000027F6 File Offset: 0x000009F6
		// (set) Token: 0x06000339 RID: 825 RVA: 0x000027FE File Offset: 0x000009FE
		public string api_key { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00002807 File Offset: 0x00000A07
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000280F File Offset: 0x00000A0F
		public string proxy { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00002818 File Offset: 0x00000A18
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00002820 File Offset: 0x00000A20
		public string ip { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00002829 File Offset: 0x00000A29
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00002831 File Offset: 0x00000A31
		public int port { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000283A File Offset: 0x00000A3A
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00002842 File Offset: 0x00000A42
		public int timeout { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000284B File Offset: 0x00000A4B
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00002853 File Offset: 0x00000A53
		public int next_change { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000285C File Offset: 0x00000A5C
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00002864 File Offset: 0x00000A64
		public int location { get; set; }

		// Token: 0x06000346 RID: 838 RVA: 0x00052CB0 File Offset: 0x00050EB0
		public TinsoftProxy(string api_key, int limit_theads_use, int location = 0)
		{
			this.api_key = api_key;
			this.proxy = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.port = 0;
			this.timeout = 0;
			this.next_change = 0;
			this.location = location;
			this.limit_theads_use = limit_theads_use;
			this.dangSuDung = 0;
			this.daSuDung = 0;
			this.canChangeIP = true;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00052E70 File Offset: 0x00051070
		public string TryToGetMyIP()
		{
			object obj = this.k1;
			string @string;
			lock (obj)
			{
				bool flag2 = this.dangSuDung == 0;
				if (flag2)
				{
					bool flag3 = this.daSuDung > 0 && this.daSuDung < this.limit_theads_use;
					if (flag3)
					{
						bool flag4 = this.GetTimeOut() < 30;
						if (flag4)
						{
							bool flag5 = this.ChangeProxy();
							if (!flag5)
							{
								return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
							}
						}
					}
					else
					{
						bool flag6 = this.ChangeProxy();
						if (!flag6)
						{
							return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
						}
					}
				}
				else
				{
					bool flag7 = this.daSuDung < this.limit_theads_use;
					if (!flag7)
					{
						return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkak9WQlJQVDA9"))))))));
					}
					bool flag8 = this.GetTimeOut() < 30;
					if (flag8)
					{
						bool flag9 = this.ChangeProxy();
						if (!flag9)
						{
							return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
						}
					}
				}
				this.daSuDung++;
				this.dangSuDung++;
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9"))))))));
			}
			return @string;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0005318C File Offset: 0x0005138C
		public void DecrementDangSuDung()
		{
			object obj = this.k;
			lock (obj)
			{
				this.dangSuDung--;
				bool flag2 = this.dangSuDung == 0 && this.daSuDung == this.limit_theads_use;
				if (flag2)
				{
					this.daSuDung = 0;
				}
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00053248 File Offset: 0x00051448
		public bool ChangeProxy()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1075216, 3136, 509, parameters);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00053290 File Offset: 0x00051490
		public string GetProxy()
		{
			bool flag;
			do
			{
				flag = this.CheckStatusProxy();
			}
			while (!flag);
			return this.proxy;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000532D4 File Offset: 0x000514D4
		public int GetTimeOut()
		{
			bool flag;
			do
			{
				flag = this.CheckStatusProxy();
			}
			while (!flag);
			return this.timeout;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00053318 File Offset: 0x00051518
		public int GetNextChange()
		{
			bool flag;
			do
			{
				flag = this.CheckStatusProxy();
			}
			while (!flag);
			return this.next_change;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0005335C File Offset: 0x0005155C
		public bool CheckStatusProxy()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1078784, 2896, 513, parameters);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000533A4 File Offset: 0x000515A4
		private bool checkLastRequest()
		{
			try
			{
				DateTime dateTime = new DateTime(2001, 1, 1);
				long ticks = DateTime.Now.Ticks - dateTime.Ticks;
				TimeSpan timeSpan = new TimeSpan(ticks);
				int num = (int)timeSpan.TotalSeconds;
				bool flag = num - this.lastRequest >= 10;
				if (flag)
				{
					this.lastRequest = num;
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00053464 File Offset: 0x00051664
		private string getSVContent(string url)
		{
			Console.WriteLine(url);
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				using (WebClient webClient = new WebClient())
				{
					text = webClient.DownloadString(url);
				}
				bool flag = string.IsNullOrEmpty(text);
				if (flag)
				{
					text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				}
			}
			catch
			{
				text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			return text;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000535CC File Offset: 0x000517CC
		private static string GetSVContent(string url)
		{
			Console.WriteLine(url);
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				using (WebClient webClient = new WebClient())
				{
					text = webClient.DownloadString(url);
				}
				bool flag = string.IsNullOrEmpty(text);
				if (flag)
				{
					text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				}
			}
			catch
			{
				text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			return text;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00053734 File Offset: 0x00051934
		public static bool CheckApiProxy(string apiProxy)
		{
			object[] parameters = new object[]
			{
				apiProxy
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1083264, 736, 517, parameters);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0005377C File Offset: 0x0005197C
		public static List<string> GetListKey(string api_user)
		{
			object[] parameters = new object[]
			{
				api_user
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1084000, 1632, 518, parameters);
		}

		// Token: 0x0400025C RID: 604
		private object k1 = new object();

		// Token: 0x0400025D RID: 605
		private object k = new object();

		// Token: 0x0400025E RID: 606
		public string errorCode = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x0400025F RID: 607
		private string svUrl = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlRUQktOVmxxVG05T1ZYaDFWVzVDYVdKck5USlhiVFZUWlcxU2NFNVhjR2xOYWtFNQ=="))))))));

		// Token: 0x04000260 RID: 608
		private int lastRequest = 0;

		// Token: 0x04000261 RID: 609
		public bool canChangeIP = true;

		// Token: 0x04000262 RID: 610
		public int dangSuDung = 0;

		// Token: 0x04000263 RID: 611
		public int daSuDung = 0;

		// Token: 0x04000264 RID: 612
		public int limit_theads_use = 3;
	}
}
