using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using ConversionBack;

namespace MCommon
{
	// Token: 0x02000051 RID: 81
	internal class Tinsoft
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000275D File Offset: 0x0000095D
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00002765 File Offset: 0x00000965
		public string api_key { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000276E File Offset: 0x0000096E
		// (set) Token: 0x06000322 RID: 802 RVA: 0x00002776 File Offset: 0x00000976
		public string proxy { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000323 RID: 803 RVA: 0x0000277F File Offset: 0x0000097F
		// (set) Token: 0x06000324 RID: 804 RVA: 0x00002787 File Offset: 0x00000987
		public string ip { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00002790 File Offset: 0x00000990
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00002798 File Offset: 0x00000998
		public int port { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000327 RID: 807 RVA: 0x000027A1 File Offset: 0x000009A1
		// (set) Token: 0x06000328 RID: 808 RVA: 0x000027A9 File Offset: 0x000009A9
		public int timeout { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000027B2 File Offset: 0x000009B2
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000027BA File Offset: 0x000009BA
		public int next_change { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600032B RID: 811 RVA: 0x000027C3 File Offset: 0x000009C3
		// (set) Token: 0x0600032C RID: 812 RVA: 0x000027CB File Offset: 0x000009CB
		public int location { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600032D RID: 813 RVA: 0x000027D4 File Offset: 0x000009D4
		// (set) Token: 0x0600032E RID: 814 RVA: 0x000027DC File Offset: 0x000009DC
		public int countConnected { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600032F RID: 815 RVA: 0x000027E5 File Offset: 0x000009E5
		// (set) Token: 0x06000330 RID: 816 RVA: 0x000027ED File Offset: 0x000009ED
		public int connecting { get; set; }

		// Token: 0x06000331 RID: 817 RVA: 0x000525A0 File Offset: 0x000507A0
		public Tinsoft(string api_key, int location = 0)
		{
			this.api_key = api_key;
			this.proxy = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.port = 0;
			this.timeout = 0;
			this.next_change = 0;
			this.location = location;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00052714 File Offset: 0x00050914
		public bool changeProxy()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1064432, 2832, 501, parameters);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0005275C File Offset: 0x0005095C
		public void stopProxy()
		{
			this.errorCode = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.proxy = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.port = 0;
			this.timeout = 0;
			bool flag = this.api_key != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				this.getSVContent(this.svUrl + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1IyUXlSbFJQV0hCclVucHNNMVpWYUV0a2JWWkpZVE5XYWxJeWFETlZSRW93WWtkV1ZVMUVNRDA9")))))))) + this.api_key);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00052948 File Offset: 0x00050B48
		public bool getProxyStatus()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1068080, 2336, 503, parameters);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00052990 File Offset: 0x00050B90
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

		// Token: 0x06000336 RID: 822 RVA: 0x00052A54 File Offset: 0x00050C54
		private string getSVContent(string url)
		{
			Console.WriteLine(url);
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				using (WebClient webClient = new WebClient())
				{
					webClient.Headers.Add(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1QySkhUbkJOVjJoaFRXeGFNVnBGUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaak5VNXRSbGhsU0U1YVZYcG5kMVJIY0VKYU1IUklWRzVhYVZkRlNtOWFSV1J6WVZkS1NGWlVaRXBTVkVaVlZURldWbG93TlhCT1NHUlFaVlZLV1ZsV1l6RmhNa2w2V2tod1NsSlVWbFpUVlZKV1pGVXhjV015WkUxaGVsWkhWbXRPUTFKR1VrZFRWMlJPVlhwU00xUkhjRTVOTURGRlZsUmtURlZVTURrPQ==")))))))));
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

		// Token: 0x06000337 RID: 823 RVA: 0x00052C68 File Offset: 0x00050E68
		public static List<string> GetListKey(string api_user)
		{
			object[] parameters = new object[]
			{
				api_user
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1071904, 1632, 506, parameters);
		}

		// Token: 0x0400024F RID: 591
		public string errorCode = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x04000251 RID: 593
		private string svUrl = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlRUQktOVmxxVG05T1ZYaDFWVzVDYVdKck5USlhiVFZUWlcxU2NFNVhjR2xOYWtFNQ=="))))))));

		// Token: 0x04000252 RID: 594
		private int lastRequest = 0;
	}
}
