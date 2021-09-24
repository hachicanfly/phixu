using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ConversionBack;
using DeviceId;
using MCommon;
using OpenQA.Selenium.Chrome;

namespace maxcare
{
	// Token: 0x02000067 RID: 103
	public class Comon
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x00058AB0 File Offset: 0x00056CB0
		public static string GetTokenBussinessFromCookie(string cookie)
		{
			object[] parameters = new object[]
			{
				cookie
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1166704, 2144, 597, parameters);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00058AF8 File Offset: 0x00056CF8
		public static void QuitChrome(ChromeDriver chrome)
		{
			object[] parameters = new object[]
			{
				chrome
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1168848, 96, 598, parameters);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00058B40 File Offset: 0x00056D40
		public static ChromeDriver OpenChrome(ChromeDriver chrome, bool isHideCMD, bool isHideImage, string UserAgent, string LinkProfile, bool isHideChrome, Point Size, Point Position, string Proxy, int TimeForSearchingElement = 0, int TimeforLoadingPage = 0)
		{
			object[] parameters = new object[]
			{
				chrome,
				isHideCMD,
				isHideImage,
				UserAgent,
				LinkProfile,
				isHideChrome,
				Size,
				Position,
				Proxy,
				TimeForSearchingElement,
				TimeforLoadingPage
			};
			return (ChromeDriver)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1168944, 11600, 599, parameters);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00058C28 File Offset: 0x00056E28
		public static List<string> RemoveEmptyItems(List<string> lst)
		{
			for (int i = 0; i < lst.Count; i++)
			{
				bool flag = lst[i].Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					lst.RemoveAt(i--);
				}
			}
			return lst;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00058CE4 File Offset: 0x00056EE4
		public static string CountNumberGroupUsingCookie(string cookie)
		{
			object[] parameters = new object[]
			{
				cookie
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1180912, 1968, 601, parameters);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00058D2C File Offset: 0x00056F2C
		public static string CountNumberFriendUsingCookie(string cookie)
		{
			object[] parameters = new object[]
			{
				cookie
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1182880, 2736, 602, parameters);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00058D74 File Offset: 0x00056F74
		public static string ConvertToShortCookie(string cookie)
		{
			string result;
			try
			{
				string value = Regex.Match(cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Value;
				string value2 = Regex.Match(cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xWb1RrOVZkRVJPU0VaUlpWZHpNdz09"))))))))).Value;
				string value3 = Regex.Match(cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIwMVNrOVZkRVJPU0VaUlpWZHpNdz09"))))))))).Value;
				string value4 = Regex.Match(cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwMUhUbkZOUnpsTllWYzRkbE14VW5wUVVUMDk="))))))))).Value;
				result = value + value2 + value3 + value4;
			}
			catch
			{
				result = cookie;
			}
			return result;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00058F24 File Offset: 0x00057124
		public static bool SearchElement(ChromeDriver chrome, int typeSearch, string value)
		{
			object[] parameters = new object[]
			{
				chrome,
				typeSearch,
				value
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1186448, 208, 604, parameters);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00058F8C File Offset: 0x0005718C
		public static bool CheckWall(string uid)
		{
			object[] parameters = new object[]
			{
				uid
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1186656, 1136, 605, parameters);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00058FD4 File Offset: 0x000571D4
		public static bool CheckAvatar(string uid)
		{
			object[] parameters = new object[]
			{
				uid
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1187792, 1840, 606, parameters);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0005901C File Offset: 0x0005721C
		public static string CheckAccMailYahoo(string username, string pass)
		{
			object[] parameters = new object[]
			{
				username,
				pass
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1189632, 11216, 607, parameters);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00059074 File Offset: 0x00057274
		public static string CheckAccMailYahooCookie(string username, string cookieMail)
		{
			object[] parameters = new object[]
			{
				username,
				cookieMail
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1200848, 2640, 608, parameters);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000590CC File Offset: 0x000572CC
		public static string GetOtpYahooFromCookie(string cook, int timeout)
		{
			object[] parameters = new object[]
			{
				cook,
				timeout
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1203488, 2816, 609, parameters);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00059124 File Offset: 0x00057324
		public static string CheckMailHotmailAndDeleteAllMessage(string username, string password)
		{
			object[] parameters = new object[]
			{
				username,
				password
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1206304, 1360, 610, parameters);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0005917C File Offset: 0x0005737C
		public static void ExportError(ChromeDriver chrome, string error)
		{
			object[] parameters = new object[]
			{
				chrome,
				error
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1207664, 2992, 611, parameters);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000591D4 File Offset: 0x000573D4
		public static string GetOtpHotMailFromEaag(string username, string password, int timeout)
		{
			object[] parameters = new object[]
			{
				username,
				password,
				timeout
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1210656, 1552, 612, parameters);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0005923C File Offset: 0x0005743C
		public static bool AddFriendAcceptFriendUidFromCookie(string cookie, string uid)
		{
			object[] parameters = new object[]
			{
				cookie,
				uid
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1212208, 3744, 613, parameters);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00059294 File Offset: 0x00057494
		public static string InviteLikePageCookie(string cookie, string idPage, int timeSleep = 0)
		{
			object[] parameters = new object[]
			{
				cookie,
				idPage,
				timeSleep
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1215952, 3664, 614, parameters);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000592FC File Offset: 0x000574FC
		public static string CheckLiveCookie(string cookie)
		{
			object[] parameters = new object[]
			{
				cookie
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1219616, 2656, 615, parameters);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00059344 File Offset: 0x00057544
		public static string GetFbdtsg(string cookie, string uA = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36")
		{
			object[] parameters = new object[]
			{
				cookie,
				uA
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1222272, 1888, 616, parameters);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0005939C File Offset: 0x0005759C
		public static string AutoShare(string cookie, string content, string link, string id_group)
		{
			object[] parameters = new object[]
			{
				cookie,
				content,
				link,
				id_group
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1224160, 12368, 617, parameters);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00059414 File Offset: 0x00057614
		public static string GetIdPost(string Link)
		{
			object[] parameters = new object[]
			{
				Link
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1236528, 2048, 618, parameters);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0005945C File Offset: 0x0005765C
		public static void PublicPost(string cookie)
		{
			object[] parameters = new object[]
			{
				cookie
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1238576, 2784, 619, parameters);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000594A4 File Offset: 0x000576A4
		public static List<string> GetListFriendsFromCookie(string cookie)
		{
			object[] parameters = new object[]
			{
				cookie
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1241360, 3824, 620, parameters);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000594EC File Offset: 0x000576EC
		public static bool PublicListFriends(string cookie)
		{
			object[] parameters = new object[]
			{
				cookie
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1245184, 3840, 621, parameters);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00059534 File Offset: 0x00057734
		public static List<string> CheckMyPages(string token)
		{
			object[] parameters = new object[]
			{
				token
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1249024, 2736, 622, parameters);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0005957C File Offset: 0x0005777C
		public static List<string> CheckMyBM(string token)
		{
			object[] parameters = new object[]
			{
				token
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1251760, 2736, 623, parameters);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000595C4 File Offset: 0x000577C4
		public static List<string> CheckMyTkqc(string token)
		{
			object[] parameters = new object[]
			{
				token
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1254496, 3712, 624, parameters);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0005960C File Offset: 0x0005780C
		public static List<string> CheckMyGroupAdmin(string token)
		{
			object[] parameters = new object[]
			{
				token
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1258208, 3376, 625, parameters);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00059654 File Offset: 0x00057854
		public static Dictionary<string, string> GetInforUserFromUid(string token, string uid, string cookie = "")
		{
			object[] parameters = new object[]
			{
				token,
				uid,
				cookie
			};
			return (Dictionary<string, string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1261584, 7712, 626, parameters);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000596BC File Offset: 0x000578BC
		public static List<string> GetRandomFriendFromToken(string token, int limit)
		{
			object[] parameters = new object[]
			{
				token,
				limit
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1269296, 2512, 627, parameters);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00059714 File Offset: 0x00057914
		public static Dictionary<string, string> GetInforUserFromToken(string token)
		{
			object[] parameters = new object[]
			{
				token
			};
			return (Dictionary<string, string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1271808, 7008, 628, parameters);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0005975C File Offset: 0x0005795C
		public static string GetTokenAndroidFromUidPass(string username, string password)
		{
			object[] parameters = new object[]
			{
				username,
				password
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1278816, 4432, 629, parameters);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000597B4 File Offset: 0x000579B4
		public static string GetTokenIosFromUidPass(string username, string password)
		{
			object[] parameters = new object[]
			{
				username,
				password
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1283248, 4432, 630, parameters);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0005980C File Offset: 0x00057A0C
		public static string CheckAccountUidPass(string username, string password)
		{
			object[] parameters = new object[]
			{
				username,
				password
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1287680, 11200, 631, parameters);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00059864 File Offset: 0x00057A64
		public static string SwapCheckpoint(string username, string password, string userAgent, string ip, int port)
		{
			object[] parameters = new object[]
			{
				username,
				password,
				userAgent,
				ip,
				port
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1298880, 5584, 632, parameters);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000598EC File Offset: 0x00057AEC
		public static string GetCheckpointFromIdMethod(string idMethod)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			uint num = <PrivateImplementationDetails>.ComputeStringHash(idMethod);
			if (num <= 923577301U)
			{
				if (num <= 401286136U)
				{
					if (num != 334175660U)
					{
						if (num == 401286136U)
						{
							if (idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaU1VsQlJQVDA9")))))))))
							{
								@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2IyTkVVbWxqVXpsclVUQktjRTVIU2pGVVFUMDk="))))))));
							}
						}
					}
					else if (idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaU2JsQlJQVDA9")))))))))
					{
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoT1VHTXlTblJhTW1ScFUwWm9iMlJZUlhoa1VUMDk="))))))));
					}
				}
				else if (num != 822911587U)
				{
					if (num != 906799682U)
					{
						if (num == 923577301U)
						{
							if (idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkak9WQlJQVDA9")))))))))
							{
								@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtjeGJWSkhPVWxoTW1ScVRXMTRNVmxWUlRsUVVUMDk="))))))));
							}
						}
					}
					else if (idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZoak9WQlJQVDA9")))))))))
					{
						@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VGtkS2VHRlhTblJhZWpBOQ=="))))))));
					}
				}
				else if (idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkd0Rk9WQlJQVDA9")))))))))
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtST1UyUjNQVDA9"))))))));
				}
			}
			else if (num <= 2347784130U)
			{
				if (num != 1153637868U)
				{
					if (num == 2347784130U)
					{
						if (idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZod1VsQlJQVDA9")))))))))
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtST1UyUjNQVDA9"))))))));
						}
					}
				}
				else if (idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkc1d1MySjNQVDA9")))))))))
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkc1d1MySjNQVDA9"))))))));
				}
			}
			else if (num != 2347931225U)
			{
				if (num != 2381486463U)
				{
					if (num == 2517938561U)
					{
						if (idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeGIySjNQVDA9")))))))))
						{
							@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm01T1VFMUZiRWhoU0VFd1dXNVdTVnBHVGtOaU0yTXpWRzFuUFE9PQ=="))))))));
						}
					}
				}
				else if (idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkd1FsQlJQVDA9")))))))))
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2MyUlZiRWhPVnpnd1dXNUdNbGx0WXpsUVVUMDk="))))))));
				}
			}
			else if (idMethod == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZkd1dsQlJQVDA9")))))))))
			{
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZoV1NFNXRPVmhPUjJSYVl6QTVkZz09"))))))));
			}
			return @string;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0005A060 File Offset: 0x00058260
		public static List<string> RequestLoginUidPassMbasic(string username, string password)
		{
			object[] parameters = new object[]
			{
				username,
				password
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1307984, 6640, 634, parameters);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0005A0B8 File Offset: 0x000582B8
		public static bool CheckMailYahoo(string mail)
		{
			object[] parameters = new object[]
			{
				mail
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1314624, 3920, 635, parameters);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0005A100 File Offset: 0x00058300
		public static bool CheckMailHotmail(string mail)
		{
			object[] parameters = new object[]
			{
				mail
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1318544, 3648, 636, parameters);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0005A148 File Offset: 0x00058348
		public static bool ChangePryvacyMail(string cookie)
		{
			object[] parameters = new object[]
			{
				cookie
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1322192, 5104, 637, parameters);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0005A190 File Offset: 0x00058390
		public static string LoadErrorFromErrorcode(string temp)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag = temp.Split(new char[]
			{
				'|'
			})[0] == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9"))))))));
			if (flag)
			{
				int num = Convert.ToInt32(temp.Split(new char[]
				{
					'|'
				})[1]);
				int num2 = num;
				int num3 = num2;
				if (num3 <= 400)
				{
					if (num3 == 104)
					{
						result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1ScVVqSndiMlJZUm10a1ZXeElUVEpvTVU1RldqQT0="))))))));
						goto IL_315;
					}
					if (num3 == 400)
					{
						result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1zeFVGb3lSbFJSYmtwb1VuazViMlJZUms5a1ZXeElaRWM1TTA0eFNqRlhibXhEVFVSU2FXUldVbWxoVlVsM1RrZEtlR0ZIUmxKUVZEQTk="))))))));
						goto IL_315;
					}
				}
				else
				{
					if (num3 == 401)
					{
						result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhTblJhUjNoaFVUQktNMWRXYUU5bFp6MDk="))))))));
						goto IL_315;
					}
					if (num3 == 405)
					{
						result = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGUlRsUVVUMDk=")))))))));
						goto IL_315;
					}
					if (num3 == 613)
					{
						result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VldwS2RXRklWVEZrU0VKS1VqSndiMlJZUmtka1ZXeElaVzFvTVdOV1dURlRWV2hUWkcxRmVWWnVWVDA9"))))))));
						goto IL_315;
					}
				}
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtVNVNFNHlkM2xoTW1Sb1ZEQmpNMkZJYkVOTlIwWlFVbnBrY2xaNlZuVT0="))))))));
				IL_315:;
			}
			return result;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0005A4C0 File Offset: 0x000586C0
		public static string Encryptor(string str)
		{
			MD5 md = MD5.Create();
			byte[] bytes = Encoding.ASCII.GetBytes(str);
			byte[] array = md.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpCU1NsQlJQVDA9"))))))))));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0005A584 File Offset: 0x00058784
		public static void resetDcom(string profileName)
		{
			Process process = new Process();
			process.StartInfo.FileName = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFIyVnNjRWhpUjJocFVYcFdjMXBWWkZaUVVUMDk="))))))));
			process.StartInfo.Arguments = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))) + profileName + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkc1FtUnNjRWhpU0hCYVRXcHNNVmx0TVZkaGJWSkNVRlF3UFE9PQ=="))))))));
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			process.WaitForExit();
			Thread.Sleep(1000);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00017084 File Offset: 0x00015284
		public static void DelayTime(double second)
		{
			Application.DoEvents();
			Thread.Sleep(Convert.ToInt32(second * 1000.0));
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0005A6D8 File Offset: 0x000588D8
		public static void startDcom(string profileName)
		{
			Thread.Sleep(1000);
			Process process = new Process();
			process.StartInfo.FileName = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFIyVnNjRWhpUjJocFVYcFdjMXBWWkZaUVVUMDk="))))))));
			process.StartInfo.Arguments = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))) + profileName + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9"))))))));
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			process.WaitForExit();
			Thread.Sleep(1500);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000588F4 File Offset: 0x00056AF4
		public static bool ChangeIP(int typeChangeIP, string profileDcom, int iTypeHotspot, string sLinkNord)
		{
			return true;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00016F14 File Offset: 0x00015114
		private static string RunCMD(string cmd)
		{
			Process process = new Process();
			process.StartInfo.FileName = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSmVHRXdlSFJXYWxKaFZWUXdPUT09"))))))));
			process.StartInfo.Arguments = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1RscDNQVDA9")))))))) + cmd;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			bool flag = string.IsNullOrEmpty(text);
			string result;
			if (flag)
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0005A838 File Offset: 0x00058A38
		public static void KillProcessChromeDriver()
		{
			Process[] processesByName = Process.GetProcessesByName(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyVlhTWGxOVjNoaFUwVndkMXBITVZkbFVUMDk=")))))))));
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0005A8C0 File Offset: 0x00058AC0
		public static Point GetPointFromIndexPosition(int indexPos, int maxApp = 6)
		{
			Point result = default(Point);
			int num = 2 * Comon.getWidthScreen / maxApp;
			int num2 = maxApp / 2;
			while (indexPos > 5)
			{
				indexPos -= 6;
			}
			bool flag = indexPos <= num2 - 1;
			if (flag)
			{
				result.Y = 0;
			}
			else
			{
				bool flag2 = indexPos < maxApp;
				if (flag2)
				{
					result.Y = Comon.getHeightScreen / 2;
					indexPos -= num2;
				}
			}
			result.X = indexPos * num;
			return result;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0005A9AC File Offset: 0x00058BAC
		public static DataTable SearchAccount(string field, string keyword, int idfile)
		{
			DataTable result = new DataTable();
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				uint num = <PrivateImplementationDetails>.ComputeStringHash(field);
				if (num <= 2071622424U)
				{
					if (num <= 1605967500U)
					{
						if (num <= 850372319U)
						{
							if (num != 321211332U)
							{
								if (num == 850372319U)
								{
									if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeFIyRnRSWHBXYm1NOQ==")))))))))
									{
										text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCa1MyRkdhM2xrUkVacVVUQktlbGxXWkRCaVJXeEVXVEo0YkdWclNUVlRiRTVxWTBFOVBRPT0="))))))));
										text = string.Format(text, keyword);
										goto IL_CE0;
									}
								}
							}
							else if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaa05HTjNQVDA9")))))))))
							{
								text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCb1YyTkdjRVJSYms1b1ZqTlNjMU5WVG1waVIxWTJVV3BzUzFVeVRtNVdSRVpLV2pKU1NFOVlTbUZXZWxKdVdXdGtjMk5zY0ZSUlZ6VkxWMGhPTTFwc1RsWmlhMnhHVDFaT1NsSXhXakJYVm1Sell6QnNTR1ZJUW1oTmJGWnVVMjVzVjA0d01VbE5SM2hMWlZWS1VWWlhiRU5rTWtaSVQxaFdZVlV3U25wWlZtUXdZa1ZzUkZreWVHeGxhMGsxVTJ4T2Fsb3hVWGhUVjJScFlsVmFNRmRzVGtOak1rWllaRWQ0U2xFeVRuTmFXSEJEVDFWd1ZGa3laRlZOVld4dVYyMDFTMk5HY0ZoT1YzUnFaVlZLZWxsV1pEQmlSV3hFV1RKNGJHVnJTVFZUYkU1cVdqRlJlRk5YWkdGTk1IQXlXa1pvUTJWcmJFaGxTRUpvVFd4V2JsTnViRmRPTURGSlRVZDRTMlZWU2xGV1YyeERZbXh3V0U1WGRHRlhSV3h1V1d0a2MyTnNjRlJSVnpWTFYwaE9NMXBzVGxaaWEyeEdUMVpPU2xJd2NHOVhWRW93VFZkT1JGRnVUbWhXTTFKelUxVk9hbUpIVmpaUmFteExWVEpPYmxaRVJrcGFNa1pZVGxjeGFXVlZTbnBaVm1Rd1lrVnNSRmt5ZUd4bGEwazFVMnhPYWxveFVYaFRWMlJxVWpCYU5sa3piRU5qTWtaWVpFZDRTbEV5VG5OYVdIQkRUMVZ3VkZreVpGVk5WV3h1VjFSSk5XUnRSWGxpUjNoS1VqTm9kMWxVU2xaYU1IQTFWbXBrVGxORVFuTlRibXhEVlVaV2NGRnVVbHBXTW5oNldUSXhWMkZ0U1hwWGJYaHFZbTEwYmxsclpITmpiSEJVVVZjMVMxZElUak5hYkU1V1ltdHNSazlXVGtwVFJVcHZXWHBPVDJSR2JGaGlTRTVLVWpOb2QxbFVTbFphTUhBMVZtcGtUbE5FUW5OVGJteHlVRkU5UFE9PQ=="))))))));
								text = string.Format(text, keyword);
								goto IL_CE0;
							}
						}
						else if (num != 1556604621U)
						{
							if (num == 1605967500U)
							{
								if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwT1MyUnRVbGxSVkRBOQ==")))))))))
								{
									text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCa2EyVlhTWHBXYm1ScVpWVktlbGxXWkRCaVJXeEVXVEo0YkdWclNUVlRiRTVxWTBFOVBRPT0="))))))));
									text = string.Format(text, keyword);
									goto IL_CE0;
								}
							}
						}
						else if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2taa2MyRjNQVDA9")))))))))
						{
							text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCb1YyTkdjRVJSYms1b1ZqTlNjMU5WVG1waVIxWTJVV3BzUzFVeVRuYz0="))))))));
							text = string.Format(text, keyword);
							goto IL_CE0;
						}
					}
					else if (num <= 2000032175U)
					{
						if (num != 1841097094U)
						{
							if (num == 2000032175U)
							{
								if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa2IyUnRTblJXVkRBOQ==")))))))))
								{
									text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCb1EySXlTWGxPVjNoS1VqTm9kMWxVU2xaYU1IQTFWbXBrVGxORVFuTlRibXh5VUZFOVBRPT0="))))))));
									text = string.Format(text, keyword);
									goto IL_CE0;
								}
							}
						}
						else if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa2MyUlhSa2xWYm14YVZucFdkUT09")))))))))
						{
							text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCa2MyUldjSFJQUjJScFVqSjRlVmRzVGtKaWEzQlpZek5rYlZVeFZuVlRNVVU1VUZFOVBRPT0="))))))));
							text = string.Format(text, keyword);
							goto IL_CE0;
						}
					}
					else if (num != 2007449791U)
					{
						if (num == 2071622424U)
						{
							if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))))
							{
								text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCb1EyRkhUWHBVVjJScFVqSjRlVmRzVGtKaWEzQlpZek5rYlZVeFZuVlRNVVU1VUZFOVBRPT0="))))))));
								text = string.Format(text, keyword);
								goto IL_CE0;
							}
						}
					}
					else if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNjOQ==")))))))))
					{
						text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCa1QyUnRTWGxrU0VKaFZUQktlbGxXWkRCaVJXeEVXVEo0YkdWclNUVlRiRTVxWTBFOVBRPT0="))))))));
						text = string.Format(text, keyword);
						goto IL_CE0;
					}
				}
				else if (num <= 3416301453U)
				{
					if (num <= 2369371622U)
					{
						if (num != 2324124615U)
						{
							if (num == 2369371622U)
							{
								if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRkpRVkRBOQ==")))))))))
								{
									text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCak1XRkhTbGhXVjJScFVqSjRlVmRzVGtKaWEzQlpZek5rYlZVeFZuVlRNVVU1VUZFOVBRPT0="))))))));
									text = string.Format(text, keyword);
									goto IL_CE0;
								}
							}
						}
						else if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhrZWpBOQ==")))))))))
						{
							text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCa1YyUkdiRmhpU0U1S1VqTm9kMWxVU2xaYU1IQTFWbXBrVGxORVFuTlRibXh5VUZFOVBRPT0="))))))));
							text = string.Format(text, keyword);
							goto IL_CE0;
						}
					}
					else if (num != 2491017778U)
					{
						if (num == 3416301453U)
						{
							if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIwMVMyTkdjRmhPVjNNOQ==")))))))))
							{
								text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCa1lXVlhSbGhXYmxaaFUwVXhibGxyWkhOamJIQlVVVmMxUzFkSVRqTmFiRTVXWW10MFVsQlVNRDA9"))))))));
								text = string.Format(text, keyword);
								goto IL_CE0;
							}
						}
					}
					else if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XTnNjRmhPUkRBOQ==")))))))))
					{
						text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCb1UyUnRSWGxXYmxaS1VqTm9kMWxVU2xaYU1IQTFWbXBrVGxORVFuTlRibXh5VUZFOVBRPT0="))))))));
						text = string.Format(text, keyword);
						goto IL_CE0;
					}
				}
				else if (num <= 3979810479U)
				{
					if (num != 3968918830U)
					{
						if (num == 3979810479U)
						{
							if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWGxOVjJob1ZqTmpPUT09")))))))))
							{
								text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCb1EyRkhUWHBVYmxKYVZqSjRlbE5WWkRSalIwVjVWbGRrUzJWV1dUTlVWV2QzWWtWd05XRjZNRDA9"))))))));
								text = string.Format(text, keyword);
								goto IL_CE0;
							}
						}
					}
					else if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTa0pRVkRBOQ==")))))))))
					{
						text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCamVHRkhSbGhsU0d4aFZqQTFNbHBITVZkbFYxWlVVVzVPYUZZelVuTlRWVTVxWWtkV05sRnFiRXRWTWs1Mw=="))))))));
						text = string.Format(text, keyword);
						goto IL_CE0;
					}
				}
				else if (num != 4025178668U)
				{
					if (num == 4280007968U)
					{
						if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJwS2MyUnRSbGxWYmtKcFlsZGpPUT09")))))))))
						{
							text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCa2EySkhTblJWYlhocVlWVktlbGxXWkRCaVJXeEVXVEo0YkdWclNUVlRiRTVxWTBFOVBRPT0="))))))));
							text = string.Format(text, keyword);
							goto IL_CE0;
						}
					}
				}
				else if (field == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeGMyVlhVa2hoUjNSYVYwZHpPUT09")))))))))
				{
					text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCa1MyTkhUblZWYlRsaFVqQlpNVk5WWkRSalIwVjVWbGRrUzJWV1dUTlVWV2QzWWtWd05XRjZNRDA9"))))))));
					text = string.Format(text, keyword);
					goto IL_CE0;
				}
				text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCU1Fsb3hRbFJSV0doTVZWUXdPUT09"))))))));
				IL_CE0:
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VUSTVibFZ0ZUV0VlJsSlVVVzFvV2sxck5USmFSbU14VFVkT05WRnNhRlJTVmxwVVZXeE9RMk5HY0VoWGJrSnBVakZXYmxWR1RrSlFVVDA5")))))))) + idfile.ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWV1IxUXhTa1JSVkRBOQ==")))))))) + text;
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0005B780 File Offset: 0x00059980
		private static string PrivateKey(string s)
		{
			return s + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a2MyUlhUWGxQVnpGclUwZFNiMWt5TVZaa1YxSklZM293UFE9PQ=="))))))));
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0005B7E8 File Offset: 0x000599E8
		public static string CreateRandomPassword(int length = 15)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaV1MxSkdTa1pXYTJSVFRVZG9URlY2UWpSVWJGSnlUMVpHVmxacmNGVldhMXBYVmpGWmVHRkdjRmhpVlZwd1YxUktVMkpHY0hSYVJ6bG9Wak5DZVZsclkzaGtWMGw2VVc1b2FtSnJOSGRhUm1oaFRUSldTV0pFV2s1U1JWWTFWRmh3VWsxVk5YRlplbEpRVlZRd09RPT0="))))))));
			Random random = new Random();
			char[] array = new char[length];
			for (int i = 0; i < length - 2; i++)
			{
				array[i] = @string[random.Next(0, @string.Length)];
			}
			array[13] = '1';
			array[14] = 'T';
			return new string(array);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0005B8BC File Offset: 0x00059ABC
		public static bool HasMethod(object objectToCheck, string methodName)
		{
			Type type = objectToCheck.GetType();
			return type.GetMethod(methodName) != null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0005B8F0 File Offset: 0x00059AF0
		public static string Decode_UTF8(string s)
		{
			byte[] bytes = Encoding.Default.GetBytes(s);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0005B924 File Offset: 0x00059B24
		public static double CompareTwoString(string str1, string str2)
		{
			double num = 0.0;
			string[] array = str2.Split(new char[]
			{
				' '
			});
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = str2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) && str1.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9")))))))) + array[i] + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9")))))))));
				if (flag)
				{
					num += 1.0;
				}
			}
			return num / (double)array.Length;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0005BAA0 File Offset: 0x00059CA0
		public static string CheckSsh(string ssh)
		{
			int portAvailable = BitviseHandle.GetPortAvailable();
			string result;
			try
			{
				result = (BitviseHandle.Connect(ssh.Split(new char[]
				{
					'|'
				})[0], ssh.Split(new char[]
				{
					'|'
				})[1], ssh.Split(new char[]
				{
					'|'
				})[2], portAvailable) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZab00xQlJQVDA9")))))))) + portAvailable.ToString()) : (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9")))))))) + portAvailable.ToString()));
			}
			catch
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWb00xQlJQVDA9")))))))) + portAvailable.ToString();
			}
			return result;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0005BC64 File Offset: 0x00059E64
		private static string MaHoa(string x)
		{
			MD5 md = MD5.Create();
			byte[] bytes = Encoding.ASCII.GetBytes(x);
			byte[] array = md.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpCRk9WQlJQVDA9"))))))))));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0005BD28 File Offset: 0x00059F28
		public static string GetIdKey(string a = "")
		{
			string x = new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber().AddSystemDriveSerialNumber().ToString();
			return Comon.MaHoa(x);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0005BD64 File Offset: 0x00059F64
		public static string GetAccessKey(string a = "")
		{
			bool flag = a.Equals(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			if (flag)
			{
				a = Comon.GetIdKey(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			return Comon.EncodeMD5(Comon.PrivateKey(a));
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0005BE30 File Offset: 0x0005A030
		public static string EncodeMD5(string txt)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			byte[] array = Encoding.UTF8.GetBytes(txt);
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			array = md5CryptoServiceProvider.ComputeHash(array);
			foreach (byte b in array)
			{
				text += b.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpCU1NsQlJQVDA9")))))))));
			}
			return text.ToLower();
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0005BF30 File Offset: 0x0005A130
		public static string GetUUID()
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSQmVGSlZlSFJXYWxKaFZWUXdPUT09")))))))),
				Arguments = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSQ1Rsb3lVWGxOV0VKYVpWVktjVmw2VGtObFYwbDVWV3BHV2sweFJtNVhha3BYVFVWc1IxWnNXbFJXVmtVNQ=="))))))))
			};
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			process.WaitForExit();
			string text = process.StandardOutput.ReadToEnd();
			return text.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVYxTnNTa0pRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VVRKak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0005C314 File Offset: 0x0005A514
		public static string GetIdCpu()
		{
			string result = string.Empty;
			ManagementClass managementClass = new ManagementClass(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tSS2MyUlZNVFpUYlZwcVUwVndNbGRVU2xkbGJVMTVUMWhyUFE9PQ==")))))))));
			ManagementObjectCollection instances = managementClass.GetInstances();
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					result = managementObject.Properties[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnNhM2xXYm5CcVRXcHNOVlV4VmxKUVVUMDk="))))))))].Value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0005C434 File Offset: 0x0005A634
		public static void Shutdown()
		{
			ManagementClass managementClass = new ManagementClass(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1wS2MyUlZNVFpUYlZwVlRUQktjMWt5TVVkTlIwWllUbGMxVmsweWVEWmFSV1JYWkVFOVBRPT0=")))))))));
			managementClass.Get();
			managementClass.Scope.Options.EnablePrivileges = true;
			ManagementBaseObject methodParameters = managementClass.GetMethodParameters(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1wS2MyUlZNVFpUYkZKb1UwWlpkMWRyWXpWTk1rcHVVRlF3UFE9PQ==")))))))));
			methodParameters[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweE5HRkdiM3BVVkRBOQ=="))))))))] = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9"))))))));
			methodParameters[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxjeFYyVnNjRmxUYWtwaFZqRkZPUT09"))))))))] = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
			foreach (ManagementBaseObject managementBaseObject in managementClass.GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				ManagementBaseObject managementBaseObject2 = managementObject.InvokeMethod(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1wS2MyUlZNVFpUYkZKb1UwWlpkMWRyWXpWTk1rcHVVRlF3UFE9PQ==")))))))), methodParameters, null);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0005C6C0 File Offset: 0x0005A8C0
		public static string CheckKeyAndLoginPro(string userName, string passWord, string idKey = "", int softIndex = 11)
		{
			object[] parameters = new object[]
			{
				userName,
				passWord,
				idKey,
				softIndex
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1348400, 2464, 661, parameters);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00004374 File Offset: 0x00002574
		public static string Base64Decode(string base64EncodedData)
		{
			byte[] bytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00016B0C File Offset: 0x00014D0C
		public static bool IsValidMail(string emailaddress)
		{
			bool result;
			try
			{
				MailAddress mailAddress = new MailAddress(emailaddress);
				result = true;
			}
			catch (FormatException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00058D74 File Offset: 0x00056F74
		public static string ConvertToStandardCookie(string cookie)
		{
			string result;
			try
			{
				string value = Regex.Match(cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSRk5VMVhUWGxXYm14UlZUSmtNVk15YnpSalJUa3pVRlF3UFE9PQ=="))))))))).Value;
				string value2 = Regex.Match(cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xWb1RrOVZkRVJPU0VaUlpWZHpNdz09"))))))))).Value;
				string value3 = Regex.Match(cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIwMVNrOVZkRVJPU0VaUlpWZHpNdz09"))))))))).Value;
				string value4 = Regex.Match(cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwMUhUbkZOUnpsTllWYzRkbE14VW5wUVVUMDk="))))))))).Value;
				result = value + value2 + value3 + value4;
			}
			catch
			{
				result = cookie;
			}
			return result;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0005C738 File Offset: 0x0005A938
		public static void DisconnectSshPort(int port)
		{
			try
			{
				BitviseHandle.Disconnect(port);
			}
			catch
			{
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0005C77C File Offset: 0x0005A97C
		public static List<string> GetGroupFromCookie(string cookie, string uA = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36")
		{
			object[] parameters = new object[]
			{
				cookie,
				uA
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1352016, 2160, 666, parameters);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0005C7D4 File Offset: 0x0005A9D4
		public static string ToUnicode(string str)
		{
			for (int i = 1; i < Comon.VietNamChar.Length; i++)
			{
				for (int j = 0; j < Comon.VietNamChar[i].Length; j++)
				{
					str = str.Replace(Comon.VietNamChar[i][j], Comon.VietNamChar[0][i - 1]);
				}
			}
			return str;
		}

		// Token: 0x040002C0 RID: 704
		public static int getWidthScreen;

		// Token: 0x040002C1 RID: 705
		public static int getHeightScreen;

		// Token: 0x040002C2 RID: 706
		public static string userName;

		// Token: 0x040002C3 RID: 707
		public static string passWord;

		// Token: 0x040002C4 RID: 708
		public static string valueReturnApiKey;

		// Token: 0x040002C5 RID: 709
		private static string[] VietNamChar = new string[]
		{
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaV1IySkdTbGhQVmtKclZteGFkMVV4WkZOU1YxWlhZWG93UFE9PQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WkhwYVNWSkhPVkJTZWxwMldsVmpNbUo2YUZCaGJtTXlWRWRvTVdOV2FHOWtXRVp0WVVoV2VFMHlhREZqVnpWdlpGaEdNbEpYWTNKU2VscDVTekJqTW1NeVZraE9ibEZ5VW5wYWVrc3dZekprUmtVNVVGRTlQUT09")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WkhwU1NWSkhaRkJTZWxwMlZEQmpNbUl6VGxCU1NHTXdWRWRvTVdOV1VtOWtXRVpwWVVoV2VHVnRhREZqVjNCdlpGaEdlVkpYWkRGU2VscDVaRlZqTW1Nd09VaE9ibEl4VW5wYWVtUlZZekprUlVVNVVGRTlQUT09")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WkhwYWRWSklSbEJTZWxveFdsVmpNbVJUZEVoT2JscHFWRE5GTUZsdVJYWk9SMG94VVdwU2FXUlZaekJaYmxaRlRrZEtNVkpuUFQwPQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WkhwU2RWSkhiRkJTZWxveFZEQmpNbVJZVmtoT2JscE9WREJ6TUZsdVJYSk9SMG94VVZSU2FXUlZZekJaYmxaRVRrZEtNVkpSUFQwPQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Wkhwa1VWSklUakZTZW1SeFdsVmpNMkZxYUZCTldHTXpWa2RvTVU1VmFHOWtWRlpSWVVoVk1XSnRhREZPVm1odlpGUldiVkl5T1d4U2VtUjBTekJqTTJKdFZraE9Namh5VW5wa2RVc3dZek5pTVVVNVVGRTlQUT09")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WkhwV1VWSkhkREZTZW1SeFZEQmpNMkZ1VGxCV2JtTXhWa2RvTVU1VlVtOWtWRlpOWVVoVk1XRnRhREZPVmxKdlpGUldhVkl5T1ZCU2VtUjBaRlZqTTJKck9VaE9Namt4VW5wa2RXUlZZek5pTUVVNVVGRTlQUT09")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Wkhwa2VWSklWbXhTZW1SM1dsVmpNMk5FYUZoalNHaDVVa2RvTVU1dE5XOWtWRm95WVVoVk0xTkhhREZPYWs1dlpGUlpORkJSUFQwPQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WkhwV2VWSkhNV3hTZW1SM1ZEQmpNMk5JVGxoaU0yaDRUREpvTVU1dGNHOWtWRnA1WVVoVk0xSkhhREZPYm5CdlpGUlpNRkJSUFQwPQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WkhwWmVsSklTbEJTZW1Sd1N6QmpNMkZYVGxSalFUMDk=")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WkhwUmVsSkhjRkJTZW1Sd1pGVmpNMkZWTVZSaWR6MDk=")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1JsQlJQVDA9")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1FsQlJQVDA9")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WkhwamVtRklWVE5WUjJneFRqRm9iMlJVWkcxaFNGVXpZWG93UFE9PQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WkhwVmVtRklWVE5VUjJneFRqRlNiMlJVWkdsaFNGVXpXbm93UFE9PQ=="))))))))
		};
	}
}
