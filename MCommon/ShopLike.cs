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
	// Token: 0x02000017 RID: 23
	internal class ShopLike
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000021E0 File Offset: 0x000003E0
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000021E8 File Offset: 0x000003E8
		public string api_key { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000021F1 File Offset: 0x000003F1
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000021F9 File Offset: 0x000003F9
		public string proxy { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002202 File Offset: 0x00000402
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0000220A File Offset: 0x0000040A
		public int typeProxy { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002213 File Offset: 0x00000413
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000221B File Offset: 0x0000041B
		public string ip { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002224 File Offset: 0x00000424
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000222C File Offset: 0x0000042C
		public int port { get; set; }

		// Token: 0x06000077 RID: 119 RVA: 0x000081B0 File Offset: 0x000063B0
		public ShopLike(string api_key, int typeProxy, int limit_theads_use)
		{
			this.api_key = api_key;
			this.proxy = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.port = 0;
			this.typeProxy = typeProxy;
			this.limit_theads_use = limit_theads_use;
			this.dangSuDung = 0;
			this.daSuDung = 0;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000082B8 File Offset: 0x000064B8
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

		// Token: 0x06000079 RID: 121 RVA: 0x00008374 File Offset: 0x00006574
		public bool ChangeProxy()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(32400, 1664, 63, parameters);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000083BC File Offset: 0x000065BC
		public bool CheckStatusProxy()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(34064, 1632, 64, parameters);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00008404 File Offset: 0x00006604
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

		// Token: 0x0600007C RID: 124 RVA: 0x00008448 File Offset: 0x00006648
		private static string RequestPost(string url, string data)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				HttpClient httpClient = new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				HttpContent c = new StringContent(data, Encoding.UTF8, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlTa2hpUjNCYVYwWktkMWxxU1RCa2JVWjFWRzVhYVZwNk1Eaz0=")))))))));
				Task<string> task = Task.Run<string>(() => ShopLike.PostURI(new Uri(url), c));
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

		// Token: 0x0600007D RID: 125 RVA: 0x00008620 File Offset: 0x00006820
		public static string RequestGet(string url)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				HttpClient httpClient = new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				Task<string> task = Task.Run<string>(() => ShopLike.GetURI(new Uri(url)));
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

		// Token: 0x0600007E RID: 126 RVA: 0x0000878C File Offset: 0x0000698C
		[DebuggerStepThrough]
		private static Task<string> PostURI(Uri u, HttpContent c)
		{
			ShopLike.<PostURI>d__29 <PostURI>d__ = new ShopLike.<PostURI>d__29();
			<PostURI>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<PostURI>d__.u = u;
			<PostURI>d__.c = c;
			<PostURI>d__.<>1__state = -1;
			<PostURI>d__.<>t__builder.Start<ShopLike.<PostURI>d__29>(ref <PostURI>d__);
			return <PostURI>d__.<>t__builder.Task;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000087E8 File Offset: 0x000069E8
		[DebuggerStepThrough]
		private static Task<string> GetURI(Uri u)
		{
			ShopLike.<GetURI>d__30 <GetURI>d__ = new ShopLike.<GetURI>d__30();
			<GetURI>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetURI>d__.u = u;
			<GetURI>d__.<>1__state = -1;
			<GetURI>d__.<>t__builder.Start<ShopLike.<GetURI>d__30>(ref <GetURI>d__);
			return <GetURI>d__.<>t__builder.Task;
		}

		// Token: 0x04000046 RID: 70
		private Random rd = new Random();

		// Token: 0x0400004C RID: 76
		private object k = new object();

		// Token: 0x0400004D RID: 77
		public int dangSuDung = 0;

		// Token: 0x0400004E RID: 78
		public int daSuDung = 0;

		// Token: 0x0400004F RID: 79
		public int limit_theads_use = 3;
	}
}
