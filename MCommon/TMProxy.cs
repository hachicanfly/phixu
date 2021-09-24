using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ConversionBack;

namespace MCommon
{
	// Token: 0x02000053 RID: 83
	internal class TMProxy
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000286D File Offset: 0x00000A6D
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00002875 File Offset: 0x00000A75
		public string api_key { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0000287E File Offset: 0x00000A7E
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00002886 File Offset: 0x00000A86
		public string proxy { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0000288F File Offset: 0x00000A8F
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00002897 File Offset: 0x00000A97
		public int typeProxy { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000359 RID: 857 RVA: 0x000028A0 File Offset: 0x00000AA0
		// (set) Token: 0x0600035A RID: 858 RVA: 0x000028A8 File Offset: 0x00000AA8
		public string ip { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600035B RID: 859 RVA: 0x000028B1 File Offset: 0x00000AB1
		// (set) Token: 0x0600035C RID: 860 RVA: 0x000028B9 File Offset: 0x00000AB9
		public int timeout { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600035D RID: 861 RVA: 0x000028C2 File Offset: 0x00000AC2
		// (set) Token: 0x0600035E RID: 862 RVA: 0x000028CA File Offset: 0x00000ACA
		public int port { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600035F RID: 863 RVA: 0x000028D3 File Offset: 0x00000AD3
		// (set) Token: 0x06000360 RID: 864 RVA: 0x000028DB File Offset: 0x00000ADB
		public int next_change { get; set; }

		// Token: 0x06000361 RID: 865 RVA: 0x000537C4 File Offset: 0x000519C4
		public TMProxy(string api_key, int typeProxy, int limit_theads_use)
		{
			this.api_key = api_key;
			this.proxy = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.port = 0;
			this.next_change = 0;
			this.typeProxy = typeProxy;
			this.limit_theads_use = limit_theads_use;
			this.dangSuDung = 0;
			this.daSuDung = 0;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000538DC File Offset: 0x00051ADC
		public static bool CheckApiProxy(string apiProxy)
		{
			object[] parameters = new object[]
			{
				apiProxy
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1085632, 1408, 519, parameters);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00053924 File Offset: 0x00051B24
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

		// Token: 0x06000364 RID: 868 RVA: 0x00053C40 File Offset: 0x00051E40
		public int GetTimeOut()
		{
			this.CheckStatusProxy();
			return this.timeout;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00053C6C File Offset: 0x00051E6C
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

		// Token: 0x06000366 RID: 870 RVA: 0x00053D28 File Offset: 0x00051F28
		public string Md5Encode(string text)
		{
			MD5 md = MD5.Create();
			byte[] array = md.ComputeHash(Encoding.UTF8.GetBytes(text));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xWU1NsQlJQVDA9"))))))))));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00053DE4 File Offset: 0x00051FE4
		public bool ChangeProxy()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1089200, 3744, 524, parameters);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00053E2C File Offset: 0x0005202C
		private string GetSVContent(string url)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				text = new RequestHttp(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0).RequestGet(url);
				bool flag = string.IsNullOrEmpty(text);
				if (flag)
				{
					text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00053FF8 File Offset: 0x000521F8
		public bool CheckStatusProxy()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1093648, 3056, 526, parameters);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00054040 File Offset: 0x00052240
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

		// Token: 0x0600036B RID: 875 RVA: 0x00054084 File Offset: 0x00052284
		private static string RequestPost(string url, string data)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				HttpClient httpClient = new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				HttpContent c = new StringContent(data, Encoding.UTF8, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlTa2hpUjNCYVYwWktkMWxxU1RCa2JVWjFWRzVhYVZwNk1Eaz0=")))))))));
				Task<string> task = Task.Run<string>(() => TMProxy.PostURI(new Uri(url), c));
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

		// Token: 0x0600036C RID: 876 RVA: 0x0005425C File Offset: 0x0005245C
		public static string RequestGet(string url)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				HttpClient httpClient = new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				Task<string> task = Task.Run<string>(() => TMProxy.GetURI(new Uri(url)));
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

		// Token: 0x0600036D RID: 877 RVA: 0x000543C8 File Offset: 0x000525C8
		[DebuggerStepThrough]
		private static Task<string> PostURI(Uri u, HttpContent c)
		{
			TMProxy.<PostURI>d__43 <PostURI>d__ = new TMProxy.<PostURI>d__43();
			<PostURI>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<PostURI>d__.u = u;
			<PostURI>d__.c = c;
			<PostURI>d__.<>1__state = -1;
			<PostURI>d__.<>t__builder.Start<TMProxy.<PostURI>d__43>(ref <PostURI>d__);
			return <PostURI>d__.<>t__builder.Task;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00054424 File Offset: 0x00052624
		[DebuggerStepThrough]
		private static Task<string> GetURI(Uri u)
		{
			TMProxy.<GetURI>d__44 <GetURI>d__ = new TMProxy.<GetURI>d__44();
			<GetURI>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetURI>d__.u = u;
			<GetURI>d__.<>1__state = -1;
			<GetURI>d__.<>t__builder.Start<TMProxy.<GetURI>d__44>(ref <GetURI>d__);
			return <GetURI>d__.<>t__builder.Task;
		}

		// Token: 0x04000265 RID: 613
		private Random rd = new Random();

		// Token: 0x0400026D RID: 621
		private object k1 = new object();

		// Token: 0x0400026E RID: 622
		private object k = new object();

		// Token: 0x0400026F RID: 623
		public int dangSuDung = 0;

		// Token: 0x04000270 RID: 624
		public int daSuDung = 0;

		// Token: 0x04000271 RID: 625
		public int limit_theads_use = 3;
	}
}
