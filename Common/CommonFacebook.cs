using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using ConversionBack;
using MCommon;

namespace Common
{
	// Token: 0x0200005F RID: 95
	public class CommonFacebook
	{
		// Token: 0x060003AB RID: 939 RVA: 0x00056C04 File Offset: 0x00054E04
		public static string CheckLiveCookie(string cookie, string userAgent, string proxy, int typeProxy)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9"))))))));
			string value = Regex.Match(cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Groups[1].Value;
			RequestXNet requestXNet = new RequestXNet(cookie, userAgent, proxy, typeProxy);
			bool flag = value != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				try
				{
					string text = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYWtaeg=="))))))))).ToString();
					bool flag2 = text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VrOVZiSFJVYmxwaFVqRmFiVmxXWXpGYWJHdDVaVWhDWVdKV2JIQT0=")))))))));
					if (flag2)
					{
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00yUjNQVDA9"))))))));
					}
					else
					{
						bool flag3 = Regex.Match(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkNFYxWkdTbGRUYlZwVVZsWkdjRlF5YkVwaU1IaHdZbms1VEZVd2F6az0="))))))))).Groups[1].Value.Trim() == value.Trim() && !text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IySkdhM2xrU0dScFRXMTRNVnBGV2s5TlZteDBUVmhDYTFKVmIzaGFSV2hUWkcxS2JsQlVNRDA9")))))))));
						if (flag3)
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00yVkJQVDA9"))))))));
						}
					}
				}
				catch
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZjMU0xQlJQVDA9"))))))));
				}
			}
			return @string;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00056FC8 File Offset: 0x000551C8
		public static string GetFbdtsg(string cookie, string userAgent, string proxy, int typeProxy)
		{
			string result;
			try
			{
				string input = new RequestXNet(cookie, userAgent, proxy, typeProxy).RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhhR2hpVlZrd1ZFUktVMDFIVFhsWk0xcFJUVlJzYlZkV1pIZGhSMVpIVDFkYVVWZEdTalZhUm1SV1VGRTlQUT09"))))))))).ToString();
				string value = Regex.Match(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFjMVUyUnRSWGxXYmxaS1lXMDVjRk13VFRCalZrSTFZVEpyUFE9PQ=="))))))))).Groups[1].Value;
				result = value;
			}
			catch
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			return result;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00057114 File Offset: 0x00055314
		public static string GetCookieFromFacebookAccount(string email, string pass, string userAgent, string proxy, int typeProxy)
		{
			string data = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhrZW1zOQ==")))))))) + WebUtility.UrlEncode(email) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIwMVEyRkhUWHBVVkdzOQ==")))))))) + WebUtility.UrlEncode(pass);
			RequestXNet requestXNet = new RequestXNet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), userAgent, proxy, typeProxy);
			requestXNet.RequestPost(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFUktOR1JzYjNsaVNGWk5UV3hLYzFwSE1YTmhiSEJVVFZkc1dsZEZOWE5YYTAwMVpWWndXRnBFUm1sU01GbzFWRVJLTkdSc2IzbGlTRlpOWldwc05WZHNaR0ZsYlU1MFZGUnNhRk5HU1hkWk1HaE9Za1V3ZDFKWGVFNWhNV3h6VkZkMFlXUkdiSFJTYm5Cb1ZqQXhNVmR0TVVkaGJIQllVMjVhYVUxdVRqRlhWRWsxWkVWd1ZWTnJaRXRpV0dkNldrZHZkMlZGTVVWUlZ6RnFZbFphZEZsV1pGSlBWVGxDVUZRd1BRPT0=")))))))), data, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlTa2hpUjNCYVYwWktkMWxxU1RCa2JWWkVUVlJPYTAweVRqQlhiVEExWlZkS1ZFMVVSbXBpV0doeldXMHhUMlJzY0VoV2JYTTk="))))))))).ToString();
			return requestXNet.GetCookie();
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000572CC File Offset: 0x000554CC
		public static string GetNameByUID(string uid, string token, string useragent, string proxy, int typeProxy)
		{
			object[] parameters = new object[]
			{
				uid,
				token,
				useragent,
				proxy,
				typeProxy
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1143696, 944, 576, parameters);
		}
	}
}
