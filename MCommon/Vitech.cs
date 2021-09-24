using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MCommon
{
	// Token: 0x02000023 RID: 35
	internal class Vitech
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00009C24 File Offset: 0x00007E24
		public Vitech(string apiKey, string proxy, int typeProxy, int limit_theads_use)
		{
			this.apiKey = apiKey;
			this.proxy = proxy;
			this.limit_theads_use = limit_theads_use;
			this.ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.typeProxy = typeProxy;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00009D18 File Offset: 0x00007F18
		public bool ChangeProxy()
		{
			bool result = false;
			try
			{
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNiMWt3WkhOTmF6RndUVmhrYTFZd2NIcFpWbVJPWkZkU2RHSkVRbUZXTURWMlYxUktiMkpHYkZsUldGWmFUV3BzTUZSRVRscGxSWGQ2VVdwR1dtSllhSGRYV0dzMVpWZEplbFZ0YUd0U01WVTU="))))))));
				string data = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xoc1MyUXlUblJQVkZKc1ZUQnJNbE5WVGtwUVVUMDk=")))))))) + this.proxy + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFjMGQxQlJQVDA9"))))))));
				string text = Vitech.RequestPost(@string, this.apiKey, data);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00009E68 File Offset: 0x00008068
		private static string RequestPost(string url, string apiKey, string data)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				HttpClient httpClient = new HttpClient();
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeFYyRkhUblJXYm1zOQ==")))))))), apiKey);
				HttpContent c = new StringContent(data, Encoding.UTF8, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlTa2hpUjNCYVYwWktkMWxxU1RCa2JVWjFWRzVhYVZwNk1Eaz0=")))))))));
				Task<string> task = Task.Run<string>(() => Vitech.PostURI(new Uri(url), c));
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

		// Token: 0x060000B8 RID: 184 RVA: 0x0000A0A8 File Offset: 0x000082A8
		[DebuggerStepThrough]
		private static Task<string> PostURI(Uri u, HttpContent c)
		{
			Vitech.<PostURI>d__6 <PostURI>d__ = new Vitech.<PostURI>d__6();
			<PostURI>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<PostURI>d__.u = u;
			<PostURI>d__.c = c;
			<PostURI>d__.<>1__state = -1;
			<PostURI>d__.<>t__builder.Start<Vitech.<PostURI>d__6>(ref <PostURI>d__);
			return <PostURI>d__.<>t__builder.Task;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000A104 File Offset: 0x00008304
		[DebuggerStepThrough]
		private static Task<string> GetURI(Uri u)
		{
			Vitech.<GetURI>d__7 <GetURI>d__ = new Vitech.<GetURI>d__7();
			<GetURI>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetURI>d__.u = u;
			<GetURI>d__.<>1__state = -1;
			<GetURI>d__.<>t__builder.Start<Vitech.<GetURI>d__7>(ref <GetURI>d__);
			return <GetURI>d__.<>t__builder.Task;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000A154 File Offset: 0x00008354
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

		// Token: 0x060000BB RID: 187 RVA: 0x0000A210 File Offset: 0x00008410
		public bool CheckLiveProxy()
		{
			bool result = false;
			try
			{
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x04000093 RID: 147
		private object k = new object();

		// Token: 0x04000094 RID: 148
		private object k1 = new object();

		// Token: 0x04000095 RID: 149
		public int typeProxy;

		// Token: 0x04000096 RID: 150
		private string apiKey;

		// Token: 0x04000097 RID: 151
		public string proxy;

		// Token: 0x04000098 RID: 152
		public string ip = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x04000099 RID: 153
		public int dangSuDung = 0;

		// Token: 0x0400009A RID: 154
		public int daSuDung = 0;

		// Token: 0x0400009B RID: 155
		public int limit_theads_use = 3;
	}
}
