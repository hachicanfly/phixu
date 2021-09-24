using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ConversionBack;

namespace MCommon
{
	// Token: 0x0200001D RID: 29
	internal class MinProxy
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002266 File Offset: 0x00000466
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000226E File Offset: 0x0000046E
		public string api_key { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002277 File Offset: 0x00000477
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000227F File Offset: 0x0000047F
		public string proxy { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002288 File Offset: 0x00000488
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002290 File Offset: 0x00000490
		public int typeProxy { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002299 File Offset: 0x00000499
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000022A1 File Offset: 0x000004A1
		public string ip { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000022AA File Offset: 0x000004AA
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000022B2 File Offset: 0x000004B2
		public int timeout { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000022BB File Offset: 0x000004BB
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000022C3 File Offset: 0x000004C3
		public int port { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000022CC File Offset: 0x000004CC
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000022D4 File Offset: 0x000004D4
		public int next_change { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000022DD File Offset: 0x000004DD
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000022E5 File Offset: 0x000004E5
		public string ip_allow { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000022EE File Offset: 0x000004EE
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000022F6 File Offset: 0x000004F6
		public string your_ip { get; set; }

		// Token: 0x0600009D RID: 157 RVA: 0x00008C50 File Offset: 0x00006E50
		public MinProxy(string api_key, int typeProxy, int limit_theads_use)
		{
			this.api_key = api_key;
			this.proxy = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.port = 0;
			this.next_change = 0;
			this.typeProxy = typeProxy;
			this.limit_theads_use = limit_theads_use;
			this.lastRequest = 0;
			this.dangSuDung = 0;
			this.daSuDung = 0;
			this.ip_allow = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.your_ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00008E18 File Offset: 0x00007018
		public static bool CheckApiProxy(string apiProxy)
		{
			object[] parameters = new object[]
			{
				apiProxy
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(37728, 944, 70, parameters);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00008E60 File Offset: 0x00007060
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
							bool flag5 = this.ChangeProxy() == 1;
							if (!flag5)
							{
								return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
							}
						}
					}
					else
					{
						bool flag6 = this.ChangeProxy() == 1;
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
						bool flag9 = this.ChangeProxy() == 1;
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

		// Token: 0x060000A0 RID: 160 RVA: 0x00009190 File Offset: 0x00007390
		public int GetTimeOut()
		{
			this.CheckStatusProxy();
			return this.timeout;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000091BC File Offset: 0x000073BC
		public void DecrementDangSuDung()
		{
			object obj = this.k;
			lock (obj)
			{
				this.dangSuDung--;
				bool flag2 = this.dangSuDung == 0 && this.daSuDung == this.limit_theads_use;
				if (flag2)
				{
					this.isBlock = true;
					this.daSuDung = 0;
				}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00009288 File Offset: 0x00007488
		public int ChangeProxy()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (int)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(40480, 3984, 74, parameters);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000092D0 File Offset: 0x000074D0
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

		// Token: 0x060000A4 RID: 164 RVA: 0x00009390 File Offset: 0x00007590
		public bool CheckStatusProxy()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(44832, 3472, 76, parameters);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000093D8 File Offset: 0x000075D8
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

		// Token: 0x060000A6 RID: 166 RVA: 0x0000941C File Offset: 0x0000761C
		private static string RequestPost(string url, string data)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				HttpClient httpClient = new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				HttpContent c = new StringContent(data, Encoding.UTF8, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlTa2hpUjNCYVYwWktkMWxxU1RCa2JVWjFWRzVhYVZwNk1Eaz0=")))))))));
				Task<string> task = Task.Run<string>(() => MinProxy.PostURI(new Uri(url), c));
				task.Wait();
				result = task.Result;
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxjeFYyVkhVbGhXYm5CclVUQktVbGxxVGs5TlFUMDk=")))))))));
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			return result;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000095F4 File Offset: 0x000077F4
		public static string RequestGet(string url)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				HttpClient httpClient = new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				Task<string> task = Task.Run<string>(() => MinProxy.GetURI(new Uri(url)));
				task.Wait();
				result = task.Result;
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxjeFYyVkhVbGhXYm5CclVUQktkVmRzYUZKUVVUMDk=")))))))));
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			return result;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00009760 File Offset: 0x00007960
		[DebuggerStepThrough]
		private static Task<string> PostURI(Uri u, HttpContent c)
		{
			MinProxy.<PostURI>d__50 <PostURI>d__ = new MinProxy.<PostURI>d__50();
			<PostURI>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<PostURI>d__.u = u;
			<PostURI>d__.c = c;
			<PostURI>d__.<>1__state = -1;
			<PostURI>d__.<>t__builder.Start<MinProxy.<PostURI>d__50>(ref <PostURI>d__);
			return <PostURI>d__.<>t__builder.Task;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000097BC File Offset: 0x000079BC
		[DebuggerStepThrough]
		private static Task<string> GetURI(Uri u)
		{
			MinProxy.<GetURI>d__51 <GetURI>d__ = new MinProxy.<GetURI>d__51();
			<GetURI>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetURI>d__.u = u;
			<GetURI>d__.<>1__state = -1;
			<GetURI>d__.<>t__builder.Start<MinProxy.<GetURI>d__51>(ref <GetURI>d__);
			return <GetURI>d__.<>t__builder.Task;
		}

		// Token: 0x04000069 RID: 105
		private Random rd = new Random();

		// Token: 0x04000073 RID: 115
		private object k1 = new object();

		// Token: 0x04000074 RID: 116
		private object k = new object();

		// Token: 0x04000075 RID: 117
		private int lastRequest = 0;

		// Token: 0x04000076 RID: 118
		public int dangSuDung = 0;

		// Token: 0x04000077 RID: 119
		public int daSuDung = 0;

		// Token: 0x04000078 RID: 120
		public int limit_theads_use = 3;

		// Token: 0x04000079 RID: 121
		public bool isBlock = true;
	}
}
