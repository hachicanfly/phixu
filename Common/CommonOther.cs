using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using ConversionBack;
using MCommon;

namespace Common
{
	// Token: 0x02000061 RID: 97
	public class CommonOther
	{
		// Token: 0x060003BA RID: 954 RVA: 0x0005762C File Offset: 0x0005582C
		public static string CreateMailGenerator(string tenMail = "")
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			int num = 0;
			while (text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))))
			{
				num++;
				text = CommonOther.GetDuoiMail();
				bool flag = num == 10;
				if (flag)
				{
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				}
			}
			bool flag2 = tenMail == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag2)
			{
				tenMail = CommonCSharp.CreateRandomString(10, null);
			}
			return tenMail + text;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000577C8 File Offset: 0x000559C8
		public static string GetDuoiMail()
		{
			RequestHttp requestHttp = new RequestHttp(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
			string input = requestHttp.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNkVmRzWXpGaVIwNTBVbXBDYVUwd2JERlhiR040WVVkR1dHUXpXVDA9")))))))));
			MatchCollection matchCollection = Regex.Matches(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoWlRXeEtOVmxxVGtOaE1rbDZXa2hXV1UxdWFIZFplazVUV1RCMFNWVnRPV2hYUlRFeFdWWmpNV1JXY0ZsVGEyeFhVbFJHVGxkRlRuSmhWV3hJWWtkMFVWVXdiSFpVUjJ4MlREQjBWRk5VTUQwPQ==")))))))));
			List<string> list = new List<string>();
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			for (int i = 0; i < matchCollection.Count; i++)
			{
				text = matchCollection[i].Groups[1].Value;
				bool flag = CommonCSharp.CheckBasicString(text) && !CommonCSharp.IsContainNumber(text) && !text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaRk9WQlJQVDA9"))))))))) && (text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeFQyUnRTbEpRVkRBOQ=="))))))))) || text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjd05XVldjRE5RVkRBOQ=="))))))))) || text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGMyUldjSFJQUkRBOQ=="))))))))));
				if (flag)
				{
					list.Add(text);
				}
			}
			bool flag2 = list.Count <= 0;
			string result;
			if (flag2)
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			else
			{
				Random random = new Random();
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZWRk9WQlJQVDA9")))))))) + list[random.Next(0, list.Count)];
			}
			return result;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00057C38 File Offset: 0x00055E38
		public static string GetOTPGenerator(string mail, int timeOut = 30)
		{
			RequestHttp requestHttp = new RequestHttp(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text2 = string.Concat(new string[]
			{
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))),
				mail.Split(new char[]
				{
					'@'
				})[1],
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))),
				mail.Split(new char[]
				{
					'@'
				})[0],
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoc2JtUlZkSEZQU0VKS1dub3dPUT09"))))))))
			});
			int tickCount = Environment.TickCount;
			bool flag2;
			do
			{
				bool flag = Environment.TickCount - tickCount > timeOut * 1000;
				if (flag)
				{
					break;
				}
				string input = requestHttp.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNkVmRzWXpGaVIwNTBVbXBDYVUwd2JERlhiR040WVVkR1dHUXpXVDA9")))))))) + mail);
				text = Regex.Match(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYWxJeVYwVlJOV0Z0U1hsT1Z6Rm9WMFZ3TUZkc1kzaGhSMFpZWkROV2FsSXlhRE5UTUUwd1kxWkNOV0V5YXowPQ=="))))))))).Value.TrimEnd(new char[]
				{
					'"'
				});
				text = Regex.Match(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFodmQySXdlSEJpZVRsTVZURnJPUT09"))))))))).Groups[1].Value;
				flag2 = (text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			while (!flag2);
			return text;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0005807C File Offset: 0x0005627C
		public static bool DelAllMail(string mail)
		{
			RequestHttp requestHttp = new RequestHttp(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
			string text = requestHttp.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNkVmRzWXpGaVIwNTBVbXBDYVUwd2JERlhiR040WVVkR1dHUXpXVDA9")))))))) + mail);
			string value = Regex.Match(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YyTXlTa2hrZWxwS1VUQnNkbFJIYkhaTU1IUlVVMVF3UFE9PQ=="))))))))).Groups[1].Value;
			string data = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YyTXlTa2hrZW1zOQ==")))))))) + value;
			text = requestHttp.RequestPost(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNkVmRzWXpGaVIwNTBVbXBDYVUwd2JERlhiR040WVVkR1dHUXpXbUZTTVZwNlYwUkplR0ZIUmxoa00xWnFVakpvTXc9PQ==")))))))), data);
			return text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1YyRnNhM2xXYm5CcVRXeHZlRmxyWkRST1VUMDk=")))))))));
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00058324 File Offset: 0x00056524
		public static string CheckCountry(string hometown)
		{
			object[] parameters = new object[]
			{
				hometown
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1151968, 2160, 587, parameters);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0005836C File Offset: 0x0005656C
		public static string CheckBalance(string apikey)
		{
			object[] parameters = new object[]
			{
				apikey
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1154128, 1616, 588, parameters);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000583B4 File Offset: 0x000565B4
		public static string GetPhoneRentcode(string apikey, int id_service = 3, int id_provider = 2, int timeOut = 60)
		{
			object[] parameters = new object[]
			{
				apikey,
				id_service,
				id_provider,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1155744, 3936, 589, parameters);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0005842C File Offset: 0x0005662C
		public static string GetOTPRentcode(string apikey, string id_order, int timeOut = 60)
		{
			object[] parameters = new object[]
			{
				apikey,
				id_order,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1159680, 2848, 590, parameters);
		}
	}
}
