using System;
using System.Linq;
using System.Text;
using ConversionBack;
using xNet;

namespace MCommon
{
	// Token: 0x0200004E RID: 78
	public class RequestXNet
	{
		// Token: 0x06000309 RID: 777 RVA: 0x0003A8A4 File Offset: 0x00038AA4
		public RequestXNet(string cookie, string userAgent, string proxy, int typeProxy)
		{
			bool flag = userAgent == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				userAgent = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaak5VNXRSbGhsU0U1YVZYcG5lRlJIY0VKYU1IUkhXa2hDYVdKV1NqSmFSRTVPV2pGU2MxVlhaRTVXUlVZeFZGVlNlbG94V1hsaVNGWlBZV3hGTTFOVmFHNU5helZFWVRKa1VsZEZTak5aYTJSWFYwWndXRk5yZUdoWFJrWXlWR3hTVGswd2VIRlVWRXBLVVRKb1RWVXdXbE5VYkZKRVpESmthVkl5ZUhsWGJFNURVMFp3V0ZSdVNtbGxWM1J1VlZSS2IyVlhTWGxOVjNoTlpXMU5kMVJIY0VKa1ZURTJXVE5zVUZWNlVqUlVXSEJHV2pGVmVWSnRNVnBYUlhCM1ZFaHdWbVZyTlRWT1NIQlBXbm93T1E9PQ=="))))))));
			}
			this.request = new HttpRequest
			{
				KeepAlive = true,
				AllowAutoRedirect = true,
				Cookies = new CookieDictionary(false),
				UserAgent = userAgent
			};
			this.request.AddHeader(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaa1QyRnNjRmxSYWtFOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa1YwNUhVa1JQVnpsclVucEdlbFJGWkVka01rNUlaVWhDV2sxcldYZFpWbU0xWkZWM2VtRkhPV3RTZWtaNlUzcE9iMlJIU2tSbFIyaHFVMFZLZWxsV1pFOWhSMUpJWWtoYWFXRlVhekJaYkdRelRqSk9WVTFJWkUxaGJYUjZXVlpqZUdGR2IzbFdXRnByVFd4YWNGa3dUalJqUjBwWVVtMDFZVlY2Ykc5Wk1HTXhZbXQ0UkdJeldreGhibEkwVlVaU1FtUlZPVUpRVkRBOQ==")))))))));
			this.request.AddHeader(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaa1QyRnNjRmxSYWtKTlZsaG9iMWx0TVd0TlZteFlXa2QzUFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4ak1HUkdXbGRVV0U1aFZucFJNMWt4VVhka01IaHhZWG93UFE9PQ==")))))))));
			bool flag2 = cookie != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag2)
			{
				this.AddCookie(cookie);
			}
			bool flag3 = proxy != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag3)
			{
				switch (proxy.Split(new char[]
				{
					':'
				}).Count<string>())
				{
				case 1:
				{
					bool flag4 = typeProxy == 0;
					if (flag4)
					{
						this.request.Proxy = HttpProxyClient.Parse(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaU1NrMHdlSEZSV0ZaT1VYcFNORlF5WXpsUVVUMDk=")))))))) + proxy);
					}
					else
					{
						this.request.Proxy = Socks5ProxyClient.Parse(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaU1NrMHdlSEZSV0ZaT1VYcFNORlF5WXpsUVVUMDk=")))))))) + proxy);
					}
					break;
				}
				case 2:
				{
					bool flag5 = typeProxy == 0;
					if (flag5)
					{
						this.request.Proxy = HttpProxyClient.Parse(proxy);
					}
					else
					{
						this.request.Proxy = Socks5ProxyClient.Parse(proxy);
					}
					break;
				}
				case 4:
				{
					bool flag6 = typeProxy == 0;
					if (flag6)
					{
						this.request.Proxy = new HttpProxyClient(proxy.Split(new char[]
						{
							':'
						})[0], Convert.ToInt32(proxy.Split(new char[]
						{
							':'
						})[1]), proxy.Split(new char[]
						{
							':'
						})[2], proxy.Split(new char[]
						{
							':'
						})[3]);
					}
					else
					{
						this.request.Proxy = new Socks5ProxyClient(proxy.Split(new char[]
						{
							':'
						})[0], Convert.ToInt32(proxy.Split(new char[]
						{
							':'
						})[1]), proxy.Split(new char[]
						{
							':'
						})[2], proxy.Split(new char[]
						{
							':'
						})[3]);
					}
					break;
				}
				}
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0003AD88 File Offset: 0x00038F88
		public string RequestGet(string url)
		{
			object[] parameters = new object[]
			{
				this,
				url
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(636944, 656, 483, parameters);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0003ADE0 File Offset: 0x00038FE0
		public byte[] GetBytes(string url)
		{
			object[] parameters = new object[]
			{
				this,
				url
			};
			return (byte[])PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(637600, 80, 484, parameters);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0003AE38 File Offset: 0x00039038
		public string RequestPost(string url, string data = "", string contentType = "application/x-www-form-urlencoded")
		{
			object[] parameters = new object[]
			{
				this,
				url,
				data,
				contentType
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(637680, 432, 485, parameters);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0003AEB0 File Offset: 0x000390B0
		public void AddCookie(string cookie)
		{
			object[] parameters = new object[]
			{
				this,
				cookie
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(638112, 448, 486, parameters);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0003AF08 File Offset: 0x00039108
		public string GetCookie()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(638560, 80, 487, parameters);
		}

		// Token: 0x04000247 RID: 583
		public HttpRequest request;
	}
}
