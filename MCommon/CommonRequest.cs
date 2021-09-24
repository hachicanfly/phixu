using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ConversionBack;
using maxcare;

namespace MCommon
{
	// Token: 0x02000042 RID: 66
	internal class CommonRequest
	{
		// Token: 0x06000248 RID: 584 RVA: 0x0002C9D8 File Offset: 0x0002ABD8
		public static List<string> GetListPeople(string cookie, string page_id)
		{
			object[] parameters = new object[]
			{
				cookie,
				page_id
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(433072, 7872, 362, parameters);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0002CA30 File Offset: 0x0002AC30
		public static string RandomText(int length = 16)
		{
			Random random = new Random();
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaa1MyRnNjRWhXYlRGT1ZrVnNObFJyVWxaTmF6VTJXbnBXVGxGVU1Eaz0="))))))));
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			for (int i = 0; i < length; i++)
			{
				text += Convert.ToString(@string[random.Next(0, @string.Length)]);
			}
			return text;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0002CB24 File Offset: 0x0002AD24
		public static string CheckLiveCookie(string cookie, string userAgent, string proxy, int typeProxy)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00yUjNQVDA9"))))))));
			string value = Regex.Match(cookie + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkROak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Groups[1].Value;
			try
			{
				RequestXNet requestXNet = new RequestXNet(cookie, userAgent, proxy, typeProxy);
				bool flag = value != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					string text = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlVbUZWVkRBNQ=="))))))))).ToString();
					bool flag2 = text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VrOVZiSFJVYmxwaFVqRmFiVmxXWXpGYWJHdDVaVWhDWVdKV2JIQT0="))))))))) || text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRlZOUjJ4cFlsWlplbE5YWXpsUVVUMDk="))))))))) || text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRlZOUjJ4YVpWVnJPUT09"))))))))) || text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyRkhTblJhUjNoaFZucEdiMWxXWkROUVVUMDk=")))))))));
					if (flag2)
					{
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00yUjNQVDA9"))))))));
					}
					else
					{
						bool flag3 = Regex.Match(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkNFYxWkdTbGRUYlZwVVZsWkdjRlF5YkVwaU1IaHdZbms1VEZVd2F6az0="))))))))).Groups[1].Value.Trim() == value.Trim() && text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1lXVlhSbGhXYmxaaFUwVXhNZz09"))))))))) && !text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IySkdhM2xrU0dScFRXMTRNVnBGV2s5TlZteDBUVmhDYTFKVmIzaGFSV2hUWkcxS2JsQlVNRDA9"))))))))) && !text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZKa2JIQkpZa2hCUFE9PQ=="))))))))) && !text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IySkdhM2xrU0dScFRXMTRNVnBGVmt0a2JWSkpWVzVhYVZaVmNHOVpNbU01VUZFOVBRPT0="))))))))) && !text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1IyUXlVa2hVYlRsYVZtcHNOVmRzYUU5a01rbDVUbGh3WVZWVU1Eaz0="))))))))) && !text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYXpVeVdXeGplRTFYU25SaVJFSnNWMFUwZDFkV1l6RmhNV3haVTIxMGFtVlVaems9"))))))))) && !text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS2IySkhTa2xSV0ZwT1lXdEdObFJZY0VKTlZUbEZZVE53VGxKR1JqTlVWbEpxVGxFOVBRPT0="))))))))) && !text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcxMFNrNXNSbFpVYkZaVVZsUnNVRlF5Y3pWVlZrcFdUbGRhVldKR1NtMVdWRUpQVlRGS1ZsWnJPRDA9")))))))));
						if (flag3)
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00yVkJQVDA9"))))))));
						}
					}
				}
			}
			catch
			{
			}
			return @string;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0002D220 File Offset: 0x0002B420
		public static List<string> GetMyListUidNameFriend(string cookie, string token, string userAgent, string proxy, int typeProxy)
		{
			object[] parameters = new object[]
			{
				cookie,
				token,
				userAgent,
				proxy,
				typeProxy
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(445248, 2192, 365, parameters);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0002D2A8 File Offset: 0x0002B4A8
		public static List<string> BackupImageOne(string uids, string cookie, string token, string userAgent, string proxy, int typeProxy, int countImage = 20, bool isBackupNangCao = false)
		{
			object[] parameters = new object[]
			{
				uids,
				cookie,
				token,
				userAgent,
				proxy,
				typeProxy,
				countImage,
				isBackupNangCao
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(447440, 9232, 366, parameters);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0002D360 File Offset: 0x0002B560
		public static List<string> GetMyListComments(string cookie, string userAgent, string proxy, int typeProxy)
		{
			List<string> list = new List<string>();
			try
			{
				RequestXNet requestXNet = new RequestXNet(cookie, userAgent, proxy, typeProxy);
				string value = Regex.Match(cookie + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkROak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Groups[1].Value;
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFUk9lbVF5V2xSUFYyaHBVak5vYjFkVVRsTmpSMUowWWtSQ2JGVjZaM1pYVkVwSFRVWndXRnBJV21waWJYaHRXVlJLVjA1V1FsaFVibHBwVm5wR2MxbHROVk5sYkd0NVpVUkdhazB4U25OWk1teGhUVWRHV0UxWGVHcE5NVXB2V1RJMVVrOVhWalpTYW14TFlteEtkMWxzWkZkaVIwcDBWVlJzYkdWcmJ6VT0="))))))));
				string arg = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string arg2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				List<string> list2 = new List<string>();
				for (int i = 0; i < 5; i++)
				{
					DateTime dateTime = DateTime.Now.AddMonths(2 - i);
					DateTime dateTime2 = DateTime.Now.AddMonths(1 - i);
					arg = Common.ConvertDatetimeToTimestamp(new DateTime(dateTime.Year, dateTime.Month, 1)).ToString();
					arg2 = Common.ConvertDatetimeToTimestamp(new DateTime(dateTime2.Year, dateTime2.Month, 1)).ToString();
					text = string.Format(@string, value, arg, arg2);
					list2.Add(text);
				}
				for (int j = 0; j < list2.Count; j++)
				{
					text = list2[j];
					bool flag;
					do
					{
						flag = false;
						text2 = requestXNet.RequestGet(text);
						text2 = WebUtility.HtmlDecode(text2);
						MatchCollection matchCollection = Regex.Matches(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlVWb1QyUXhiRmhPUTNSTVVYcFNlRlZJYkhKUFJYZDVXbnBDVVZwNk1Eaz0=")))))))));
						for (int k = 0; k < matchCollection.Count; k++)
						{
							string text3 = matchCollection[k].Groups[1].Value;
							text3 = text3.Substring(0, text3.LastIndexOf('<'));
							MatchCollection matchCollection2 = Regex.Matches(text3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlVWT2JtUlZkSEZQU0VKUldub3dPUT09")))))))));
							for (int l = 0; l < matchCollection2.Count; l++)
							{
								text3 = text3.Replace(matchCollection2[l].Value, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
							}
							bool flag2 = text3 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) && !list.Contains(text3);
							if (flag2)
							{
								list.Add(text3);
							}
						}
						bool flag3 = Regex.IsMatch(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))) + value + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1IyTXlTa2hTYlhCclVqSjNlVmxXYUZOT1ZYZDRaSGs1V2sxcldYZFhiR1JyWkcxT2RXSkhXbWhOYkZreFZVWmtUMlJ0U2xoTlYzaHBZbXhLTmxkVVNqUk5WMDE2VlcxNGFtRldiM2RaVm1ONFlrWndXRTVYZEV4UmVsSjRWVWhzY21GUlBUMD0=")))))))));
						if (flag3)
						{
							text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13dw==")))))))) + Regex.Match(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))) + value + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1IyTXlTa2hTYlhCclVqSjNlVmxXYUZOT1ZYZDRaSGs1V2sxcldYZFhiR1JyWkcxT2RXSkhXbWhOYkZreFZVWmtUMlJ0U2xoTlYzaHBZbXhLTmxkVVNqUk5WMDE2VlcxNGFtRldiM2RaVm1ONFlrWndXRTVYZEV4UmVsSjRWVWhzY21GUlBUMD0="))))))))).Value.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
							flag = true;
						}
					}
					while (flag);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0002DB38 File Offset: 0x0002BD38
		public static List<string> GetMyListUidMessage(string cookie, string userAgent, string proxy, int typeProxy)
		{
			List<string> list = new List<string>();
			try
			{
				RequestXNet requestXNet = new RequestXNet(cookie, userAgent, proxy, typeProxy);
				int num = 1;
				string input = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFUkplR0pIVFhwVWJXaGhUV3hhTmxSSVl6bFFVVDA5")))))))));
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				do
				{
					MatchCollection matchCollection = Regex.Matches(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1lVMVdiRlJUVTNSTVVYcFNlRlZJYkhKUFFUMDk=")))))))));
					for (int i = 0; i < matchCollection.Count; i++)
					{
						try
						{
							text2 = matchCollection[i].Groups[1].Value.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
							text2 = Common.HtmlDecode(text2);
							bool flag = !list.Contains(text2);
							if (flag)
							{
								list.Add(text2);
							}
						}
						catch
						{
						}
					}
					text = Regex.Match(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSSmVHSkhUWHBVYldoaFRXeGFObFJJYXpGa01XeFlXa2Q0VldKc1dqQlZSazV1WkZWMGNVOUlRa3BhZWpBNQ=="))))))))).Value.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaamVHUXdPVE5RVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					input = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13dw==")))))))) + text);
					num++;
					bool flag2 = num >= 5;
					if (flag2)
					{
						break;
					}
				}
				while (text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0002DFBC File Offset: 0x0002C1BC
		public static string GetMyBirthday(string cookie, string token, string userAgent, string proxy, int typeProxy)
		{
			object[] parameters = new object[]
			{
				cookie,
				token,
				userAgent,
				proxy,
				typeProxy
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(463392, 1616, 369, parameters);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0002E044 File Offset: 0x0002C244
		public static string GetFbDtsg(string cookie, string useragent, string proxy, int typeProxy)
		{
			string result;
			try
			{
				string input = new RequestXNet(cookie, useragent, proxy, typeProxy).RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhPV0ZXTTJnelZFaGpPVkJSUFQwPQ==")))))))));
				result = Regex.Match(input, Common.Base64Decode(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpKMGIxVXlWbk5qUkZaVVZrWndjMXBXVm5aa01XeHhVMnBDYVZJd2NIZFZNVkpoVTIxR1dGcEVSbFJOYlRnd1dUQldjMkpzUWxWTlJEQTk=")))))))))).Groups[1].Value;
			}
			catch
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			return result;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0002E190 File Offset: 0x0002C390
		public static bool CheckAvatarFromUid(string uid, string filePath = "mau.jpg")
		{
			bool result = false;
			try
			{
				List<bool> hash = CommonRequest.GetHash(new Bitmap(filePath));
				List<bool> hash2 = CommonRequest.GetHash(CommonRequest.GetImageFromUid(uid));
				double num = (double)(hash.Zip(hash2, (bool i, bool j) => i == j).Count((bool eq) => eq) / 256);
				result = (num == 0.0);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0002E260 File Offset: 0x0002C460
		private static Bitmap GetImageFromUid(string uid)
		{
			RequestXNet requestXNet = new RequestXNet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
			string url = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNkVmt5TVVka01rWkVUbGN4V2xZd05YTlhWekExWkcxR05VNVhjR2xOYWtJeQ==")))))))) + uid + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1EyTkdhM3BWYWtacVlsWlZkbGRXWkU5aGJIQlpWRzV3V1UweFNqSlpWRXBYWkZaQ1ZWZFVTazVoYldONFZHMXdibVZyTlRaaVJHaGFaV3RhYzFSdGNFcGtNWEIwVWxST1RsSkhhRzlVVm1SU1RWVTFjV0Y2U21GaVZXc3hWREZTUjJGck1WaFRiWFJoVmtaVmVWUnRjRXBRVVQwOQ=="))))))));
			byte[] bytes = requestXNet.GetBytes(url);
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(bytes, 0, Convert.ToInt32(bytes.Length));
			Bitmap result = new Bitmap(memoryStream, false);
			memoryStream.Dispose();
			return result;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0002E420 File Offset: 0x0002C620
		public static bool DownLoadImageByUid(string uid, string pathFolder)
		{
			bool result;
			try
			{
				string address = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNkVmt5TVVka01rWkVUbGN4V2xZd05YTlhWekExWkcxR05VNVhjR2xOYWtJeQ==")))))))) + uid + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1EyTkdhM3BWYWtacVlsWlZkbHBFU25OaE1sSklXbnBzVDJWck1IbFRiVEZIWVd4cmVWWnVjR3BOVkd0M1dXcEtNR0pIU25GTlJFcFBZV3RyTUZSc1VscE9SVEUyV1hwV2JWSXdNVFJYYkZKYVpWVXhTRmR0YUU5bGEwVXdWMVpTUjJFd05WVlhWRlpQWWxad2NGUXhVbkpsUm13MlVtMXNZVkl4VlhoVWJYQmFaVkU5UFE9PQ=="))))))));
				using (WebClient webClient = new WebClient())
				{
					byte[] buffer = webClient.DownloadData(address);
					using (MemoryStream memoryStream = new MemoryStream(buffer))
					{
						using (Image image = Image.FromStream(memoryStream))
						{
							string str = pathFolder + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + uid;
							try
							{
								image.Save(str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMVEyUldjRE5RVkRBOQ==")))))))), ImageFormat.Png);
							}
							catch
							{
								image.Save(str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGQyUXhjRE5RVkRBOQ==")))))))), ImageFormat.Jpeg);
							}
						}
					}
				}
				result = true;
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4b1MyVlhTWHBUVjJSVFVucHJlbGx0ZERSa2JHeFlWV3R3YVZZd1duVlhiRlpMVGxaYVdHSkhjejA9")))))))));
				result = false;
			}
			return result;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000156A4 File Offset: 0x000138A4
		private static List<bool> GetHash(Bitmap bmpSource)
		{
			List<bool> list = new List<bool>();
			Bitmap bitmap = new Bitmap(bmpSource, new Size(16, 16));
			for (int i = 0; i < bitmap.Height; i++)
			{
				for (int j = 0; j < bitmap.Width; j++)
				{
					list.Add(bitmap.GetPixel(j, i).GetBrightness() < 0.5f);
				}
			}
			return list;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0002E74C File Offset: 0x0002C94C
		public static string CheckLiveWall(string uid)
		{
			RequestXNet requestXNet = new RequestXNet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), SetupFolder.GetUseragentIPhone(Base.rd), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				text = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNkVmt5TVVka01rWkVUbGN4V2xZd05YTlhWekExWkcxR05VNVhjR2xOYWtJeQ==")))))))) + uid + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1EyTkdhM3BWYWtacVlsWlZkbGt5TVZkaE1rWlpVMjE0V2sweFJUVlhiVEZIWXpKTmVWWlVNRDA9")))))))));
				bool flag = !string.IsNullOrEmpty(text);
				if (flag)
				{
					bool flag2 = text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWa1YyTkdiM2xoUkVFOQ=="))))))))) && text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tSS2MyRXlVa2hhZWpBOQ==")))))))));
					if (flag2)
					{
						return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9"))))))));
					}
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9"))))))));
				}
			}
			catch
			{
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZjMU0xQlJQVDA9"))))))));
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0002EAB8 File Offset: 0x0002CCB8
		public static string CheckInfoUsingUid(string uid)
		{
			object[] parameters = new object[]
			{
				uid
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(470848, 7360, 376, parameters);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0002EB00 File Offset: 0x0002CD00
		public static bool CheckLiveToken(string cookie, string token, string useragent, string proxy, int typeProxy = 0)
		{
			bool result = false;
			try
			{
				RequestXNet requestXNet = new RequestXNet(cookie, useragent, proxy, typeProxy);
				string text = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNkVmt5TVVka01rWkVUbGN4V2xZd05YTlhWekExWkcxR05VNVhjR2xOYWtJeVdXeGtWa3d4YkZoVWJYQmhWMFUxTmxkRVRsTmtiVVY1Vm01V1VWVlVNRGs9")))))))) + token);
				result = true;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0002EBC0 File Offset: 0x0002CDC0
		public static string GetTokenEAAAAZ(string cookie, string useragent, string proxy, int typeProxy = 0)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				string value = Regex.Match(cookie + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkROak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Groups[1].Value;
				string fbDtsg = CommonRequest.GetFbDtsg(cookie, useragent, proxy, typeProxy);
				RequestXNet requestXNet = new RequestXNet(cookie, useragent, proxy, typeProxy);
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhjR2xOYWtZeldXcE9UMkpIVG5CUFdGcGFUV3hhZWxscVRsSmtiR3haVkdwV2FXSlZOVzFaYTJNMVlVWndTRlp1YkUxbGFtd3pXa1prUzJNeVJsbFViVGxoVjBWck5WZHRNVmRpUm5CQ1VGUXdQUT09"))))))));
				string input = requestXNet.RequestGet(@string);
				text = Regex.Match(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4V1IxRnNSbFpTYlVaTVVYcFNlRlZJYkhKaFVUMDk="))))))))).Value.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			catch
			{
				bool flag = !CommonRequest.CheckLiveCookie(cookie, useragent, proxy, typeProxy).StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))));
				if (flag)
				{
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9"))))))));
				}
			}
			bool flag2 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag2)
			{
				bool flag3 = !CommonRequest.CheckLiveCookie(cookie, useragent, proxy, typeProxy).StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))));
				if (flag3)
				{
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9"))))))));
				}
			}
			return text;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0002F0DC File Offset: 0x0002D2DC
		public static string GetTokenEAAG(string cookie, string userAgent, string proxy, int typeProxy)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				RequestXNet requestXNet = new RequestXNet(cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), proxy, typeProxy);
				string input = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNjRnBHYUU5alIwcDBWbTV3YW1WVVZuUlhWbVJQWWtac2RFOVlXbWhsVkZaeFdXcEpkMlJzYkhWV2JuQm9WbnBXYzFsNlRrOWFiVXBJVDFkd1dsZEdTbmRaYWtreFpXdDRNMUJVTUQwPQ==")))))))));
				text = Regex.Match(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4V1IxRnNTalZhTTFaTVlXcG9kMU5YWXpsUVVUMDk="))))))))).Value.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			catch
			{
				bool flag = !CommonRequest.CheckLiveCookie(cookie, userAgent, proxy, typeProxy).StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))));
				if (flag)
				{
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9"))))))));
				}
			}
			bool flag2 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag2)
			{
				bool flag3 = !CommonRequest.CheckLiveCookie(cookie, userAgent, proxy, typeProxy).StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))));
				if (flag3)
				{
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1JsQlJQVDA9"))))))));
				}
			}
			return text;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0002F560 File Offset: 0x0002D760
		public static string CheckCheckpoint(string idMethod)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			int num = 0;
			uint num2 = <PrivateImplementationDetails>.ComputeStringHash(idMethod);
			if (num2 <= 1315429348U)
			{
				if (num2 <= 822911587U)
				{
					if (num2 != 334175660U)
					{
						if (num2 != 401286136U)
						{
							if (num2 != 822911587U)
							{
								goto IL_CDD;
							}
							if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkd0Rk9WQlJQVDA9"))))))))))
							{
								goto IL_CDD;
							}
						}
						else
						{
							if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaU1VsQlJQVDA9"))))))))))
							{
								goto IL_CDD;
							}
							bool flag = num == 0;
							if (flag)
							{
								@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2IyTkVVbWxqVXpsclVUQktjRTVIU2pGVVFUMDk="))))))));
							}
							else
							{
								@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YwMXRSbGhVYlhjOQ=="))))))));
							}
							return @string;
						}
					}
					else
					{
						if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaU2JsQlJQVDA9"))))))))))
						{
							goto IL_CDD;
						}
						bool flag2 = num == 0;
						if (flag2)
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoT1VHTXlTblJhTW1ScFUwWm9iMlJZUlhoa1VUMDk="))))))));
						}
						else
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUkhTbGhXYmxaclVWUXdPUT09"))))))));
						}
						return @string;
					}
				}
				else if (num2 <= 923577301U)
				{
					if (num2 != 906799682U)
					{
						if (num2 != 923577301U)
						{
							goto IL_CDD;
						}
						if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkak9WQlJQVDA9"))))))))))
						{
							goto IL_CDD;
						}
						bool flag3 = num == 0;
						if (flag3)
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGJWSkhPVWxoTW1ScVRXMTRNVmxWUlRsUVVUMDk="))))))));
						}
						else
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjeGMyVlhVa2hoUjNSYVYwZHpPUT09"))))))));
						}
						return @string;
					}
					else
					{
						if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZoak9WQlJQVDA9"))))))))))
						{
							goto IL_CDD;
						}
						bool flag4 = num == 0;
						if (flag4)
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VGtkS2VHRlhTblJhZWpBOQ=="))))))));
						}
						else
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGamVHRkdiM2xXVkRBOQ=="))))))));
						}
						return @string;
					}
				}
				else if (num2 != 1153637868U)
				{
					if (num2 != 1315429348U)
					{
						goto IL_CDD;
					}
					if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1UxcHRVbGxSYms1cFRXdGFjZz09"))))))))))
					{
						goto IL_CDD;
					}
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14b1Fsb3hiR3BsVlhCcFlsZGpPUT09"))))))));
				}
				else
				{
					if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkc1d1MySjNQVDA9"))))))))))
					{
						goto IL_CDD;
					}
					bool flag5 = num == 0;
					if (flag5)
					{
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkc1d1MySjNQVDA9"))))))));
					}
					else
					{
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkc1d1Nsb3lSa2hQVkVacVltc3dPUT09"))))))));
					}
					return @string;
				}
			}
			else if (num2 <= 2347784130U)
			{
				if (num2 != 1718322808U)
				{
					if (num2 != 2331006511U)
					{
						if (num2 != 2347784130U)
						{
							goto IL_CDD;
						}
						if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZod1VsQlJQVDA9"))))))))))
						{
							goto IL_CDD;
						}
					}
					else
					{
						if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZod2FsQlJQVDA9"))))))))))
						{
							goto IL_CDD;
						}
						return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vldwb2FHUXpjRXBpU0VKS1VsUnNWbFpWVGtOTmJtTXlZMnN4YmxFd1NqQlhWbVJ6WTNjOVBRPT0="))))))));
					}
				}
				else
				{
					if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZjeFlXRkJQVDA9"))))))))))
					{
						goto IL_CDD;
					}
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSV0d4aFlsVlZPUT09"))))))));
				}
			}
			else if (num2 <= 2364561749U)
			{
				if (num2 != 2347931225U)
				{
					if (num2 != 2364561749U)
					{
						goto IL_CDD;
					}
					if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZod1ZsQlJQVDA9"))))))))))
					{
						goto IL_CDD;
					}
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWak5XSnRSbGhPUjJSVFRXcHNNbGRxU2pSaVFUMDk="))))))));
				}
				else
				{
					if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkd1dsQlJQVDA9"))))))))))
					{
						goto IL_CDD;
					}
					bool flag6 = num == 0;
					if (flag6)
					{
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGNWSXlPV3BsVlVaS1VqQjRiMlJZUmtka1ZXeElWRVZTZUZGVU1Eaz0="))))))));
					}
					else
					{
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcwMVMyTkdjRmhPVjNNOQ=="))))))));
					}
					return @string;
				}
			}
			else if (num2 != 2381486463U)
			{
				if (num2 != 2517938561U)
				{
					goto IL_CDD;
				}
				if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeGIySjNQVDA9"))))))))))
				{
					goto IL_CDD;
				}
				bool flag7 = num == 0;
				if (flag7)
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm01T1VFMUZiRWhoU0VFd1dXNVdTVnBHVGtOaU0yTXpWRzFuUFE9PQ=="))))))));
				}
				else
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a2MyVnNiRmhUYms1aFZWUXdPUT09"))))))));
				}
				return @string;
			}
			else
			{
				if (!(idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkd1FsQlJQVDA9"))))))))))
				{
					goto IL_CDD;
				}
				bool flag8 = num == 0;
				if (flag8)
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2MyUlZiRWhPVnpnd1dXNUdNbGx0WXpsUVVUMDk="))))))));
				}
				else
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaa1YyVnRUWGxTYlRWaFZWUXdPUT09"))))))));
				}
				return @string;
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtST1UyUjNQVDA9"))))))));
			IL_CDD:
			File.AppendAllText(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwMUdiRmRsUjNSYVZucFdkVmRVVGtKa1YxSkpZVVJCUFE9PQ==")))))))), idMethod);
			return @string;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000302AC File Offset: 0x0002E4AC
		public static string CheckFacebookAccount(string email, string pass, string userAgent, string proxy, int typeProxy)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				string data = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhrZW1zOQ==")))))))) + WebUtility.UrlEncode(email) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIwMVEyRkhUWHBVVkdzOQ==")))))))) + WebUtility.UrlEncode(pass);
				RequestXNet requestXNet = new RequestXNet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), userAgent, proxy, typeProxy);
				string text2 = requestXNet.RequestPost(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFUktOR1JzYjNsaVNGWk5UV3hLYzFwSE1YTmhiSEJVVFZkc1dsZEZOWE5YYTAwMVpWWndXRnBFUm1sU01GbzFWRVJLTkdSc2IzbGlTRlpOWldwc05WZHNaR0ZsYlU1MFZGUnNhRk5HU1hkWk1HaE9Za1V3ZDFKWGVFNWhNV3h6VkZkMFlXUkdiSFJTYm5Cb1ZqQXhNVmR0TVVkaGJIQllVMjVhYVUxdVRqRlhWRWsxWkVWd1ZWTnJaRXRpV0dkNldrZHZkMlZGTVVWUlZ6RnFZbFphZEZsV1pGSlBWVGxDVUZRd1BRPT0=")))))))), data, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlTa2hpUjNCYVYwWktkMWxxU1RCa2JWWkVUVlJPYTAweVRqQlhiVEExWlZkS1ZFMVVSbXBpV0doeldXMHhUMlJzY0VoV2JYTTk="))))))))).ToString();
				bool flag = text2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VrOVZiSFJVYlRsaFZqQTFlVmt3WXpWalIwcDFWV3hTYTFZd2NEQlpWbWhUVVRKU1dWVnFRbWxOYWxKdw==")))))))));
				if (flag)
				{
					bool flag2 = text2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaa1VrOVZiSFJTYm1ScVUwVndNbHBITVVkak1rMTRUMWR3YVUxc1NuTlRWMk01VUZFOVBRPT0=")))))))));
					if (flag2)
					{
						text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkd4b00xQlJQVDA9"))))))));
					}
					else
					{
						text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZjMU0xQlJQVDA9"))))))));
						requestXNet = new RequestXNet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), userAgent, proxy, typeProxy);
						requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVVDA9"))))))))).ToString();
						text2 = requestXNet.RequestPost(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYm1neVYycEtjMlJWZDNsVmJYaHJZbGQ0Y1Zkc1RYaGhWbXhaVkcxNFlWRjZiRFZYYkdSclRWZEtTRkp1YkUxTmJtZ3lWMnBLYzJSVmVEWlBXRTVwVFcxU2QxbHRkelZoUjFKSlZXMTRhVmRGU1hkVlJsSkdZbGRLU1ZwRVNsRldSVll6VkZWRk9WQlJQVDA9")))))))), data, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlTa2hpUjNCYVYwWktkMWxxU1RCa2JWWkVUVlJPYTAweVRqQlhiVEExWlZkS1ZFMVVSbXBpV0doeldXMHhUMlJzY0VoV2JYTTk="))))))))).ToString();
						string value = Regex.Match(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRlZOUjJ4aFlsVndiVmRyYUZObGJIQTFVMWRrYTJKVlducGFSbVJXVDFWc2NGb3pWa3hoYW1oM1UxZGpPVkJSUFQwPQ=="))))))))).Groups[1].Value;
						string value2 = Regex.Match(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRlZOUjJ4b1lsVlpNbGxxU2xkbGJWSkVVMWRrYTJKVlducGFSbVJXVDFWc2NGb3pWa3hoYW1oM1UxZGpPVkJSUFQwPQ=="))))))))).Groups[1].Value;
						string value3 = Regex.Match(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRlZOUjJ4cFlsZGtjRk5WYUdGaFIwcEpWbTE0VVZVd2JIWlVSMngyVERCMFZGTlVNRDA9"))))))))).Groups[1].Value;
						string value4 = Regex.Match(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkM05WcHRUWHBSYmtKcFlrUnNOVk5YY0haaU1IaHdZbms1VEZVell6az0="))))))))).Groups[1].Value;
						string value5 = Regex.Match(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkM05WcHRUWHBSYmtKcFlrUnJkMU5YY0haaU1IaHdZbms1VEZVell6az0="))))))))).Groups[1].Value;
						string data2 = string.Concat(new string[]
						{
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZjeFIwNXRTWGxXYm5CclVrUkJPUT09")))))))),
							value2,
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIweFlXRldaM2xWYWtKcVRXMU5OUT09")))))))),
							value,
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIwd01XSXhRbEpRVkRBOQ==")))))))),
							value3,
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIwMVQwMVdiSFJOV0VKclVtNVNSVmxxU1RGTlIwWllUbFJHWVZacVFUVldhMlJ5WWtaS1ZWSlhlRkpoTUZaelZWZDBZV1F3Y0ZWVFdHUnJVVEZhUjFSV1RsZFJNVVp3Vm10S1QxWXdNWFJYUkVVMVRWZE5lVlp1YkZGV1JVWjBWMFJGTldGR1FsVlNWekZaVFZSc2NscFdZekJQVlRSNllVZDRUMkV4Y0RKVWExVTFWV3N4VjFGcVZsZFdNbWN3VmtSSk1WSXlVWGxPUkZKUFVqQldOVmxXVWxkV2F6VklWbGhvVTJKdFpEQlhiR2hyVmtkUmQwMVVVbGRsYTBwR1ZteGtWMVp0UmtsWmVrWmFUVEpqZVZSVldtRmthekZaVm01a1UxWkdTbGxVVlZVMVVtc3hjMXBFVWxWbGEwcFZXV3BLUzFKc2JGVmFlazVvVmtWS01WUlhlRmRXUlRGWlYycE9UMUpzV25WWFZtTTBUa1U1UlZKclpGZFdSVFUxV2toc1lWcHNaM2xVYm5CcVlXcENkRmRFUlRWbFZuQlpVbFJzVDFVeGNHMVhSRXBMWWtkSmVWSlViRTVSTVhCdFYwUk9RMkZzUWxkUmEyeFNWbXMxUjFWclRsWmxiRVpXVld0YVUyRXdXbGRXUlZwU1lsWndTVkZ1YkZGV1JWWjBWMFJGTldWV2NGbFhWR3M5")))))))),
							value4,
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIxM05WcHRUalpOV0ZwcVVrWlpkMWxVU1hkaVJUQjNVbGhzWVZKR1NtOVVNV04zWWtVd2QxSlljRTlOTWpneFZGY3hTbUpXWjNoUFZ6bHFUVzF6TlZSdGNHcE9SVGxWVWxSR1RtVnNhekZVYm5CV1RrVTVSVlpZY0U5bGJGWTFWR3hOZDJRd2NITlBWMXBxVFRCS2QxbHRkelZsVmtKU1VGUXdQUT09")))))))),
							value4,
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIxM05WcHRUWHBSYmtKcFlrUnNjRlZHYUZObFYxSllUbGhLUzJKRWJHMVplazVEWTBkS2MwOVVRbEZWVkRBNQ==")))))))),
							value5
						});
						text2 = requestXNet.RequestPost(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYXpWMlYyeGtUMk50VGtoUFdFSnBZbXhHTWxkV2FFOU9WMHAwVkZNNWFXSldXVEJhUlZGNFlqSlNTVlZ1WkdwbFZsWTJWVlpPVm1WV1NuQldXR3hUWW0xUmVscElhekZpVm14WVZHMTRXbUpVYkRKWldHc3hZVzFKZVUxSGVFNWhNV3M1")))))))), data2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlTa2hpUjNCYVYwWktkMWxxU1RCa2JWWkVUVlJPYTAweVRqQlhiVEExWlZkS1ZFMVVSbXBpV0doeldXMHhUMlJzY0VoV2JYTTk=")))))))));
						text2 = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYXpWMlYyeGtUMk50VGtoUFdFSnBZbXhHTWxWRVNURmlSMVpKVlZRd1BRPT0=")))))))));
						MatchCollection matchCollection = Regex.Matches(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFYyVlhSbGhYYmtKYVRXdFpkMWxXWXpWa1ZtZDVUVmQ0YTFJeWFESlhhMDVLV2pKU2RGSnVUbXRXTVZVMVUxZHNibVJWZEhGUFNFSktXbm93T1E9PQ==")))))))));
						bool flag3 = matchCollection.Count > 0;
						if (flag3)
						{
							for (int i = 0; i < matchCollection.Count; i++)
							{
								text = text + CommonRequest.CheckCheckpoint(matchCollection[i].Groups[1].Value) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaRk9WQlJQVDA9"))))))));
							}
							text = text.TrimEnd(new char[]
							{
								'-'
							});
						}
						else
						{
							bool flag4 = text2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZKa2JIQkpZa2hDVFdWcWJEVlhiR1JoWWtkT2RWTnRlR3BoYWtaeVdWWm9UMkZHYkhSbFIzaGhVbXBzY1ZsVlpGZGhiVVY2VVc1YWFGWjZWWGM9")))))))));
							if (flag4)
							{
								text += CommonRequest.CheckCheckpoint(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeGIySjNQVDA9")))))))));
							}
							else
							{
								bool flag5 = text2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1IyUXlVa2hVYlRsYVZYcEdOVmRzWkU5aFIwNUpWVzF3YUZJd1ZUaz0=")))))))));
								if (flag5)
								{
									text += CommonRequest.CheckCheckpoint(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkc1d1MySjNQVDA9")))))))));
								}
								else
								{
									bool flag6 = text2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRlZOUjJ4cVRURmFjRmxzWkhOTlJtTjNaVWhhWVdWVlNsRmFSbWhUV2tWc2JsQlVNRDA9"))))))))) || text2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRlZOUjJ4cVRURmFjRmxzWkhOTlJtTjRUMWRhYWxJemFHOVhWRXBYWWpKSmVXVkhkR0ZYUlhCdFYwUkZkMkZSUFQwPQ==")))))))));
									if (flag6)
									{
										text += Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZSS2NWSklVa2hPVnpWS1UwWktkbVI2V25sVVYyeFVVV3BTYVZZeFNYYz0="))))))));
									}
									else
									{
										bool flag7 = text2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRlZOUjJ4cVRURmFjRmxzWkhOTlJtTjNWRzVhYVdKc1NuZFpiVFZYWWtab1ZGTlVNRDA9")))))))));
										if (flag7)
										{
											text += Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2IyTklZekpqYXpGdVYwWkdibGRYTVhWVVZ6a3pVRlF3UFE9PQ=="))))))));
										}
									}
								}
							}
						}
					}
				}
				else
				{
					bool flag8 = text2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnRSbGhPVjFwaFYwVndOVmxxVGtwUVVUMDk=")))))))));
					if (flag8)
					{
						bool flag9 = text2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4Wk5XTXlTWGxhU0VKcFlrUnNjMWxzWkVkalIwcENVRlF3UFE9PQ==")))))))));
						if (flag9)
						{
							text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZST00xQlJQVDA9"))))))));
						}
						else
						{
							text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9"))))))));
						}
					}
					else
					{
						bool flag10 = text2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaa1QwMUhSbGhQV0ZaWlRUQTFjMXBGV1RWaGJVbDVUbFJDV2xZd05IZFhSRTVEWkcxR1dFNVVRVDA9")))))))));
						if (flag10)
						{
							text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZjMU0xQlJQVDA9")))))))) + CommonRequest.CheckCheckpoint(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZod1VsQlJQVDA9")))))))));
						}
						else
						{
							string cookie = requestXNet.GetCookie();
							bool flag11 = CommonRequest.CheckLiveCookie(cookie, userAgent, proxy, typeProxy).StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))));
							if (flag11)
							{
								text = text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))) + cookie;
							}
							else
							{
								text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZjMU0xQlJQVDA9"))))))));
							}
						}
					}
				}
			}
			catch
			{
				text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9"))))))));
			}
			return text;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000313D8 File Offset: 0x0002F5D8
		public static string GetInfoAccountFromUidUsingToken(string tokenTrungGian, string uid, string useragent, string proxy, int typeProxy)
		{
			object[] parameters = new object[]
			{
				tokenTrungGian,
				uid,
				useragent,
				proxy,
				typeProxy
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(500928, 5584, 382, parameters);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00031460 File Offset: 0x0002F660
		public static string GetInfoAccountFromUidUsingCookie(string cookie, string useragent, string proxy, int typeProxy)
		{
			object[] parameters = new object[]
			{
				cookie,
				useragent,
				proxy,
				typeProxy
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(506512, 7248, 383, parameters);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000314D8 File Offset: 0x0002F6D8
		public static string GetInfoAccountFromUidUsingCookieTrungGian(string uid, string cookie_ori)
		{
			object[] parameters = new object[]
			{
				uid,
				cookie_ori
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(513760, 7456, 384, parameters);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00031530 File Offset: 0x0002F730
		public static List<string> GetListGroup(string cookie, string useragent, string proxy, int typeProxy)
		{
			object[] parameters = new object[]
			{
				cookie,
				useragent,
				proxy,
				typeProxy
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(521216, 3648, 385, parameters);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000315A8 File Offset: 0x0002F7A8
		public static List<string> GetGroupKhongKiemDuyet(List<string> lstGroup, string cookie, string useragent, string proxy, int typeProxy)
		{
			try
			{
				int iThread = 0;
				int num = (lstGroup.Count < 100) ? lstGroup.Count : 100;
				int i = 0;
				while (i < lstGroup.Count)
				{
					bool flag = iThread < num;
					if (flag)
					{
						Interlocked.Increment(ref iThread);
						int row = i++;
						new Thread(delegate()
						{
							string text = lstGroup[row];
							bool flag2 = true;
							try
							{
								string str = text.Split(new char[]
								{
									'|'
								})[0];
								RequestXNet requestXNet = new RequestXNet(cookie, useragent, proxy, typeProxy);
								string text2 = requestXNet.RequestGet("https://mobile.facebook.com/groups/" + str + "/madminpanel");
								flag2 = text2.Contains("madminpanel/pending/");
							}
							catch
							{
							}
							lstGroup[row] = string.Format("{0}|{1}", text, flag2);
							Interlocked.Decrement(ref iThread);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				while (iThread > 0)
				{
					Application.DoEvents();
					Thread.Sleep(100);
				}
			}
			catch
			{
			}
			return lstGroup;
		}
	}
}
