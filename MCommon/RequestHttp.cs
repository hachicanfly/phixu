using System;
using System.Net;
using System.Text;
using ConversionBack;
using HttpRequest;

namespace MCommon
{
	// Token: 0x0200004D RID: 77
	public class RequestHttp
	{
		// Token: 0x06000304 RID: 772 RVA: 0x0003A54C File Offset: 0x0003874C
		public RequestHttp(string cookie = "", string userAgent = "", string proxy = "", int typeProxy = 0)
		{
			bool flag = userAgent == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				this.UserAgent = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaak5VNXRSbGhsU0U1YVZYcG5lRlJIY0VKYU1IUkhXa2hDYVdKV1NqSmFSRTVPV2pGU2MxVlhaRTVXUlVZeFZGVlNlbG94V1hsaVNGWlBZV3hGTTFOVmFHNU5helZFWVRKa1VsZEZTak5aYTJSWFYwWndXRk5yZUdoWFJrWXlWR3hTVGswd2VIRlVWRXBLVVRKb1RWVXdXbE5VYkZKRVpESmthVkl5ZUhsWGJFNURVMFp3V0ZSdVNtbGxWM1J1VlZSS2IyVlhTWGxOVjNoTlpXMU5kMVJIY0VKa1ZURTJXVE5zVUZWNlVqUlVXSEJHV2pGVmVWSnRNVnBYUlhCM1ZFaHdWbVZyTlRWT1NIQlBXbm93T1E9PQ=="))))))));
			}
			else
			{
				this.UserAgent = userAgent;
			}
			this.request = new RequestHTTP();
			this.request.SetSSL(SecurityProtocolType.Tls12);
			this.request.SetKeepAlive(true);
			this.request.SetDefaultHeaders(new string[]
			{
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUlhVa2hXYmxaclVYcEZkMXBXYUVOaVJUbHdVV3BDWVZkSFozZFVSRXB2VFVkS1dHUXpUbHBYUlVveldXdGtjMkZzYkZsVmJrSnBUV3BTTWxwVlpHOU5SMHBZWkROS2JGSjZSbnBVUldSSFpESk9TR1ZJUWxwTmExbDNXVlpqTldSVmQzcGhTRkpwVWtoU05GVkdVa0prVlRsVVpETkdUV1ZYT0ROWk1WRjNaREI0Y1ZwNk1EMD0=")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1QySkhUbkJOVjJoaFRXeGFNVnBGVW5aYWR6MDk=")))))))) + this.UserAgent
			});
			bool flag2 = cookie != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag2)
			{
				this.AddCookie(cookie);
			}
			this.Proxy = proxy;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0003A744 File Offset: 0x00038944
		public string RequestGet(string url)
		{
			object[] parameters = new object[]
			{
				this,
				url
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(632160, 1776, 479, parameters);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0003A79C File Offset: 0x0003899C
		public string RequestPost(string url, string data = "")
		{
			object[] parameters = new object[]
			{
				this,
				url,
				data
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(633936, 1296, 480, parameters);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0003A804 File Offset: 0x00038A04
		public void AddCookie(string cookie)
		{
			object[] parameters = new object[]
			{
				this,
				cookie
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(635232, 1648, 481, parameters);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0003A85C File Offset: 0x00038A5C
		public string GetCookie()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(636880, 64, 482, parameters);
		}

		// Token: 0x04000244 RID: 580
		public RequestHTTP request;

		// Token: 0x04000245 RID: 581
		private string UserAgent;

		// Token: 0x04000246 RID: 582
		private string Proxy;
	}
}
