using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using ConversionBack;
using maxcare;
using maxcare.Enum;

namespace MCommon
{
	// Token: 0x02000041 RID: 65
	public class CommonChrome
	{
		// Token: 0x0600020A RID: 522 RVA: 0x0001A820 File Offset: 0x00018A20
		public static bool CheckFacebookBlocked(Chrome chrome)
		{
			return chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhNV0ZXTUZsM1drWm9TMkpHWjNsbFNFSnBWakozZDFkRVNURmtiVkpJWWtkd1lWVjZaems9"))))))))) || chrome.CheckExistElements(0.0, new string[]
			{
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYV0VaUlZUQndkRmRXWkU5aVJteDBUMWhhYUdWVVZuRlpha2wzWkcxR1NGWnVUbXBSZW1nMFZHNXdhbVF3TlhGWFdIQlBVa1pWZVZRd1VrSk9SVEZGVTFkc1dWVlVNRGs9")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYV0VaUlZUQndkRmRXWkU5aVJteDBUMWhhYUdWVVZuRlpha2wzWkcxR1NGWnVUbXBSZW14eFdXcEpNVTFHYkZoVWFrSk5aVlZ3YXc9PQ=="))))))))
			}) != 0 || chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR2hWZW14dlYxUk9VMlJ0VG5OUFYzaHNVMFZLYzFreU1YTmlSMHAwVkcxNFRVMXJXbkZhUldNMVpWWm5lVnBIYUd0U01WbDZWMVpvY2xCUlBUMD0=")))))))));
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001A9C0 File Offset: 0x00018BC0
		public static void AnswerQuestionWhenJoinGroup(Chrome chrome, List<string> lstCauTraLoi)
		{
			List<string> list = new List<string>();
			int num = chrome.CountElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa1YwNUhVa2hTYm14aFZqQlZPUT09")))))))));
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			for (int i = 0; i < num; i++)
			{
				bool flag = list.Count == 0;
				if (flag)
				{
					list = Common.CloneList(lstCauTraLoi);
				}
				text = list[Base.rd.Next(0, list.Count)];
				text = Common.SpinText(text, Base.rd);
				list.Remove(text);
				chrome.ScrollSmooth(string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NsSnVUbWxSTW1SMVdrVmtWMDVIVWtoU2JteGhWakJXZFZNeFdqQk9NREZKVFZkUlBRPT0=")))))))), num));
				chrome.DelayRandom(1, 2);
				chrome.SendKeys(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa1YwNUhVa2hTYm14aFZqQlZPUT09")))))))), i, text, 0.1, true, 0.1);
				chrome.DelayRandom(1, 2);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0001ABD8 File Offset: 0x00018DD8
		public static void AnswerQuestionWhenJoinGroupWWW(Chrome chrome, List<string> lstCauTraLoi)
		{
			List<string> list = new List<string>();
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1IyVlhSbGhTV0ZKcFVqQmFjRmRzWkROUFZXeHlVbTVXYWsweVVuTlpNbXhEVlcxU1dGWnVjR3RTTW5neVdXMDFUbUZXYUZka1NHeHBUVzVvYzFWR1RrdGhNa1pZVW01T2FVMXRUbkJYUms1RFdXeHdTRkpxUWxwVmVrVjVXVlpvVDAxV2JGaGxSM0JwVFdwR00xbHJaRmROUjBaWVQxaFdVVlV3Y0hkWGFra3haRzFPZEZaWVVtRlRSM2d4VjFaamVHTkdiRFZUYlZFOQ=="))))))));
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			int num = 0;
			int num2 = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExaSG93T1E9PQ==")))))))) + @string + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NtUlhTa2hXYmxaaFRURktkZz09"))))))))).ToString());
			for (int i = 0; i < num2; i++)
			{
				bool flag = chrome.ExecuteScript(string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExaSG93T1E9PQ==")))))))),
					@string,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2MxbG5QVDA9")))))))),
					i.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBaTk1XVkhVbGhXYm14c1ZtczFjMWxyWkZkaGJWSklUMWhzVEZFeVVtbFpiVEZIWkVad1ZVMUhiR3BpVlZweVdWWmpOR0ZXYUZSWk0wSk1aVmRPZFE9PQ=="))))))))
				})).ToString() != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyTXlTa0pRVkRBOQ=="))))))));
				if (flag)
				{
					num = 1;
				}
				else
				{
					bool flag2 = chrome.ExecuteScript(string.Concat(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExaSG93T1E9PQ==")))))))),
						@string,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2MxbG5QVDA9")))))))),
						i.ToString(),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBaTk1XVkhVbGhXYm14c1ZtczFjMWxyWkZkaGJWSklUMWhzVEZFeVVYZFhiR2h2VFVac1dWTnRlRnBWTWs1M1V6TnNhbUpuUFQwPQ=="))))))))
					})).ToString() != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyTXlTa0pRVkRBOQ=="))))))));
					if (flag2)
					{
						num = 2;
					}
					else
					{
						bool flag3 = chrome.ExecuteScript(string.Concat(new string[]
						{
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExaSG93T1E9PQ==")))))))),
							@string,
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2MxbG5QVDA9")))))))),
							i.ToString(),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBaTk1XVkhVbGhXYm14c1ZtczFjMWxyWkZkaGJWSklUMWhzVEZFeVVtbFpiVEZIWkVad1ZVMUhiRnBOYldoelYxUktNR0ZYU1hwYU1teFpWVEpPZDFNemJHcGlaejA5"))))))))
						})).ToString() != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyTXlTa0pRVkRBOQ=="))))))));
						if (flag3)
						{
							num = 3;
						}
					}
				}
				chrome.ScrollSmoothIfNotExistOnScreen(string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NsSnVUbWxSTW1SMQ==")))))))),
					@string,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2MxbG5QVDA9")))))))),
					i.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBaRk9WQlJQVDA9"))))))))
				}));
				chrome.DelayTime(1.0);
				switch (num)
				{
				case 1:
					chrome.ExecuteScript(string.Concat(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NsSnVUbWxSTW1SMQ==")))))))),
						@string,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2MxbG5QVDA9")))))))),
						i.ToString(),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBaTk1XVkhVbGhXYm14c1ZtczFjMWxyWkZkaGJWSklUMWhzVEZFeVVtbFpiVEZIWkVad1ZVMUhiR3BpVlZweVdWWmpOR0ZXYUZSWk0wSk5ZbFUxZWxsV1pFOWphM1JFWVhvd1BRPT0="))))))))
					}));
					chrome.DelayTime(1.0);
					break;
				case 2:
				{
					bool flag4 = list.Count == 0;
					if (flag4)
					{
						list = Common.CloneList(lstCauTraLoi);
					}
					text = list[Base.rd.Next(0, list.Count)];
					list.Remove(text);
					chrome.SendKeysv2(4, @string ?? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), i, 4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa1YwNUhVa2hTYm14aFZqQlZPUT09")))))))), 0, text, true, 0.1);
					chrome.DelayTime(1.0);
					break;
				}
				case 3:
					chrome.ExecuteScript(string.Concat(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NsSnVUbWxSTW1SMQ==")))))))),
						@string,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2MxbG5QVDA9")))))))),
						i.ToString(),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBaTk1XVkhVbGhXYm14c1ZtczFjMWxyWkZkaGJWSklUMWhzVEZFeVVtbFpiVEZIWkVad1ZVMUhiRnBOYldoelYxUktNR0ZYU1hwYU1teFpWVEpPZDFSSE1VOWpNa1pZVkc1S1RGRXljems9"))))))))
					}));
					chrome.DelayTime(1.0);
					break;
				}
			}
			bool flag5 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVmFkVmt5TVZkaVJYaFpWVzVhVFZZeVVqVlphazVYWkRCNFdWTnFSbWxTTVZvMlUxZDNkMUJSUFQwPQ==")))))))), 0.0) == 1;
			if (flag5)
			{
				chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaa2EyVldjRmhXV0ZKclVucG9NRmRxVGt0a2JWSlpVVmhTYW1Kc1ducFhiR2hPVUZFOVBRPT0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
				chrome.DelayTime(1.0);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0001B7AC File Offset: 0x000199AC
		public static bool IsCheckpointWhenLoginWhenGiaiCP(Chrome chrome)
		{
			bool result;
			try
			{
				List<string> list = new List<string>
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QyRkhUa2xWYlhCb1VqQmFiVmt5TVZkbGJVNUlUMWhXYWsxc1ZUaz0=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVTFiMWt3YUZOaGJVWklVbTFhYW1KV1dqWlpNR00xWkZkTmVWWlhiRmxWVkRBNQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lteHdjMWt5TVhOaVYwWllWRzFvYTFJeWVESlpiWGMxWkVad1dWVnRPV2xOYkVad1YwWkZPVkJSUFQwPQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1UxcVZuTmFTR3hMV2tFOVBRPT0=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lsZG5kMXBGYUVObGF6bHdUMGhhYTAweVVYcFVSekZoWVVacmVWWnRiR2xOYW14NVZFY3hUMlJ0U2xSUFYzQnBUV3BHTUZwR1l6RmpSMUpKWWtod2ExSXdXakZYYTJSSFpWWndTVlJZV2twaVJFRTU="))))))))
				};
				result = (chrome.CheckExistElements(0.0, list.ToArray()) > 0);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0001B998 File Offset: 0x00019B98
		public static int LoginFacebookUsingUidPassWhenGiaiCP(Chrome chrome, string uid, string pass, string fa2 = "", string URL = "https://www.facebook.com")
		{
			Random random = new Random();
			int result = 0;
			try
			{
				int num = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL());
				bool flag = num == 0;
				if (flag)
				{
					bool flag2 = chrome.GotoURL(URL) == -2;
					if (flag2)
					{
						result = -2;
						goto IL_19F9;
					}
					num = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL());
				}
				bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0.0) == 1;
				if (flag3)
				{
					chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					chrome.DelayTime(1.0);
				}
				bool flag4 = num == 1;
				if (flag4)
				{
					chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYm1neVYycEtjMlJSUFQwPQ==")))))))));
					bool flag5 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0.0) == 1;
					if (flag5)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag6 = chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhrZWpBOQ==")))))))), uid, 0.1, true, 0.1) == -2;
					if (flag6)
					{
						result = -2;
						goto IL_19F9;
					}
					chrome.DelayTime(1.0);
					bool flag7 = chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))), pass, 0.1, true, 0.1) == -2;
					if (flag7)
					{
						result = -2;
						goto IL_19F9;
					}
					chrome.DelayTime(1.0);
					bool flag8 = chrome.Click(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnRSbGhPVjJ4clYwWkpkMWxxU1RCUVVUMDk=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == -2;
					if (flag8)
					{
						result = -2;
						goto IL_19F9;
					}
					chrome.DelayTime(1.0);
					bool flag9 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1IyUXlUa2xUYmxwcllsVmFlbGw2UlRWaGJVbDVWVzEzUFE9PQ==")))))))), 5.0) == 1 && fa2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag9)
					{
						string totp = Common.GetTotp(fa2.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VVRKak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
						bool flag10 = totp != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag10)
						{
							chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlUblJQVkVwYVZqTm9ObGRFU2s5a2JIQklWbFF3UFE9PQ==")))))))), totp, 0.1, true, 0.1);
							chrome.DelayTime(1.0);
							chrome.Click(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IySkdhM2xrU0dScFRXMTRNVnBGV2s5TlZteDBUVmhDYTFKVmIzaGFSV2hUWkcxS2JsQlVNRDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							chrome.DelayTime(1.0);
						}
					}
					int num2 = 0;
					while (chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUVNRDA9")))))))), 3.0) == 1)
					{
						bool flag11 = !chrome.CheckIsLive();
						if (flag11)
						{
							result = -2;
							goto IL_19F9;
						}
						bool flag12 = CommonChrome.IsCheckpointWhenLoginWhenGiaiCP(chrome) || num2 == 7;
						if (flag12)
						{
							break;
						}
						chrome.Click(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IySkdhM2xrU0dScFRXMTRNVnBGV2s5TlZteDBUVmhDYTFKVmIzaGFSV2hUWkcxS2JsQlVNRDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
						num2++;
					}
				}
				else
				{
					int num3 = chrome.GotoURLIfNotExist(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlUbWxOYlZKM1dXMWpPVkJSUFQwPQ==")))))))));
					bool flag13 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0.0) == 1;
					if (flag13)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
					}
					num3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBaVWhhWVUxdGVERlhSRTVEWlZkSmVWZHVRbWxTTVZwdFYyMHdOV1ZYU2xSVGJWSktVakZLZDFwSGVEQmxWMGw1WlVkNFVWVXdjSEJhUm1oVFRVZEplVTVIYkZsVlZEQTU=")))))))), 1.0);
					int num4 = num3;
					int num5 = num4;
					if (num5 == -2)
					{
						result = -2;
						goto IL_19F9;
					}
					if (num5 != 1)
					{
						bool flag14 = chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4Wk5XTXlTWGxhU0VKcFlrUnNjMWxzWkVkalIwcENVRlF3UFE9PQ==")))))))), uid, 0.1, true, 0.1) == 1;
						if (flag14)
						{
							chrome.DelayThaoTacNho(0, null);
							string attributeValue = (chrome.CheckExistElements(3.0, new string[]
							{
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmVGcHRTa2hQVnpWb1ZucFdiVmt3WkVkbGJVMTZXa2hhYW1KV1JUaz0=")))))))),
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ=="))))))))
							}) == 1) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmVGcHRTa2hQVnpWb1ZucFdiVmt3WkVkbGJVMTZXa2hhYW1KV1JUaz0=")))))))) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ=="))))))));
							chrome.SendKeys(4, attributeValue, pass, 0.1, true, 0.1);
							chrome.DelayThaoTacNho(0, null);
							chrome.Click(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnRSbGhPUkRBOQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							chrome.DelayThaoTacNho(0, null);
						}
					}
					else
					{
						chrome.DelayThaoTacNho(0, null);
						bool flag15 = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBaVWhhWVUxdGVERlhSRTVEWlZkSmVWZHVRbWxTTVZwdFYyMHdOV1ZYU2xSVGJWSktVakZLZDFwSGVEQmxWMGw1WlVkNFVWVXdjSEJhUm1oVFRVZEplVTVIYkZsVlZEQTU=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == -2;
						if (flag15)
						{
							result = -2;
							goto IL_19F9;
						}
						chrome.DelayThaoTacNho(2, null);
						num3 = chrome.CheckExistElements(10.0, new string[]
						{
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1IyUXlUa2xUYmxwcllsVmFlbGw2UlRWaGJVbDVWVzEzUFE9PQ=="))))))))
						});
						bool flag16 = num3 == -2;
						if (flag16)
						{
							result = -2;
							goto IL_19F9;
						}
						bool flag17 = num3 == 1;
						if (flag17)
						{
							bool flag18 = chrome.SendKeys(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))), pass, 0.1, true, 0.1) == 1;
							if (flag18)
							{
								chrome.DelayThaoTacNho(0, null);
								bool flag19 = chrome.Click(4, chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZVOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwMUdiRlJOV0hCb1ZqSlNkMWxyUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWHBhU0ZwcVlsWktiVmxyWXpWaWJVWllUbGRhV21Kc1dYZGFSV00xWkZFOVBRPT0="))))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
								if (flag19)
								{
									chrome.DelayTime(1.0);
								}
							}
						}
					}
					num3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1IyUXlUa2xUYmxwcllsVmFlbGw2UlRWaGJVbDVWVzEzUFE9PQ==")))))))), 5.0);
					bool flag20 = num3 == -2;
					if (flag20)
					{
						result = -2;
						goto IL_19F9;
					}
					bool flag21 = num3 == 1 && fa2.Trim() != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag21)
					{
						string totp2 = Common.GetTotp(fa2.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VVRKak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
						bool flag22 = totp2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag22)
						{
							chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlUblJQVkVwYVZqTm9ObGRFU2s5a2JIQklWbFF3UFE9PQ==")))))))), totp2, 0.1, true, 0.1);
							chrome.DelayThaoTacNho(-1, null);
							chrome.Click(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IySkdhM2xrU0dScFRXMTRNVnBGV2s5TlZteDBUVmhDYTFKVmIzaGFSV2hUWkcxS2NFMVhhRnBOTVVsNFYxWmtNMlJHYkhWV2FrSnJVbnBzTVE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							chrome.DelayThaoTacNho(0, null);
						}
					}
					int num6 = 0;
					while (chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUlVbHBXTURSM1drWmtSMk13ZUZoVGFrWnJVMFpLTWxsdFl6bFFVVDA5")))))))), 3.0) == 1)
					{
						bool flag23 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1UxcVZuTmFTR3hMV2tFOVBRPT0=")))))))), 0.0) == 1;
						if (flag23)
						{
							break;
						}
						bool flag24 = !chrome.CheckIsLive();
						if (flag24)
						{
							result = -2;
							goto IL_19F9;
						}
						bool flag25 = CommonChrome.IsCheckpointWhenLogin(chrome) || num6 == 7;
						if (flag25)
						{
							break;
						}
						chrome.Click(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IySkdhM2xrU0dScFRXMTRNVnBGV2s5TlZteDBUVmhDYTFKVmIzaGFSV2hUWkcxS2NFMVhhRnBOTVVsNFYxWmtNMlJHYkhWV2FrSnJVbnBzTVE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayThaoTacNho(0, null);
						num6++;
					}
				}
				chrome.DelayTime(1.0);
				return CommonChrome.CheckLiveCookie(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9")))))))));
			}
			catch (Exception ex)
			{
				Common.ExportError(chrome, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtWak5XSnRSbGhPUjJSWFZqSjRjbE5WV2tOaFIwMTZWRmRrVTJKVlduZFphMFU1VUZFOVBRPT0=")))))))));
			}
			IL_19F9:
			return result;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0001D3C8 File Offset: 0x0001B5C8
		public static string GetNameFromPost(Chrome chrome)
		{
			string text = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWxhZW14TFpWZE5NMWRyWXpWaGJWSllUVmQ0YVdKc1JqRlpNV2hYWWtkT2RXSkdVbUZXTTJoelYxUk9VMlJ0VG5KU2JrNXBVVEprZFZaNlRrTmxWMGw2VVcxNGFtSnNTVEZWUms1TFpHeHdObU5FUW1oWFJrcDZWMnhPUzFwRmNEVmhNMVpwVWpGYU1WZHFUbE5pTVVKeFVWY3hTMkZYWnpCVlJtUlRaR3hyZWxadVVtRldlbFYzVkVjMVIwMVdjRmxUYWxaV1RXeGFlbGRzWkU5TlIwbDZVMWM1UzAxWVVqTlpNakExWkRGd1dWTnFRbXhXUkVKd1dXcEthazV0VWtoaVJFSnBVakZXY0ZkR1RtcGpSWGgwV2tkNGExSlZXWGRhUldoTFkwWnNkVlpxUW1GVk1tUjFWMVJKTldSWFVraFdibFpyVVRKT2QxTXhUak5pYTNBMlRVUnNiRkV4YkhSWGEyTTFZVzFTV0UxWGVHbGliRVl4V1RGb1YySkhUblZpUmxKaFZqTm9jMWRVVGxOa2JVNXlVbTVPYVZFeVpIVldla3BUWVVkU1NGSllVbUZOTVVwclUxVmtSbUpyZEZST1dFNWhWbnBXZFZwRlpHNUxNREZFVjFjeFRGTkhZelZYYTJNMVlXMVNXRTFYZUdsaWJFWXhXVEZvVjJKSFRuVmlSbEpoVmpOb2MxZFVUbE5rYlU1d1dqSTFXRTFzU205YVJXUkdaRVp2ZWxWdFVrcFNNRloxVXpGTk1XTkhTblJPVjNocVlrWktjMXBWYUZKalJYaEVXVEkxVVZaRVJUQlRiV3hoWVRKSmVWUnFSbWxXTVZveFdrVk5NV1ZIVWxoV2JteHNWbXMxYzFsclpGZGhiVkpJVDFoc1VsWXphSHBUTUU1cVpGWnNXRlJxUW1sTk1HeDFVekZOTVdNeGNGaE9WelZyVWpKamNsUlZUbHBpVlhSSlducHNZVko2YkhGYVJtTjRZa2RLZFZWWVZtcFhSbHB6V1RJMWMxWkdjRmhsUjNoYVRURktNbGt5Ykc1aWEzaDBVbTF3YTFKNmJEVlRibXh5WkZkR1dFNVlWbUZYUlhCV1YyeG9iMDFGZEZSa01tUnNVVE5PZFZOdWNIcGFNazUwVm1wQ2ExZEZjREZUVldodVRuYzlQUT09"))))))))).ToString();
			bool flag = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				text = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKc1NuZGFSV1EwWWtFOVBRPT0="))))))))).ToString().Split(new char[]
				{
					'-',
					'|'
				})[0].Trim();
			}
			return text;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0001D510 File Offset: 0x0001B710
		public static string GetNameFromStory(Chrome chrome)
		{
			return chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWxhZW14TFpWZE5NMWRyWXpWaGJWSllUVmQ0YVdKc1JqRlpNV2hYWWtkT2RXSkdVbUZXTTJoelYxUk9VMlJ0VG5KU2JrNXBVVEprZFZSSE1EVk5iSEJaVTIweGFWSjZhM3BXYTJSWFRrZFNSRmt6UWsxaVdHaHpXVzB4YTAxSFJrVk9TR1JMWVZac2RscFZVWGhoTWtsNVZHcEdhVll4V2pGYVJVMHhaVWRTV0ZadWJHeFdhelZ6V1d0a1YyRnRVa2hQV0d4TVVUSk9NVmxxVG1GaVIwNTBWMjVPYVUweVVsWlhiR2h2VFVWd05XRXpWbWhXZWxZeFYyeG9TMVpXY0ZsaFJFSk1WVE5rYmxwVlRucGlhM0EyWXpKa2FtSldXWGRhUm1oTFpGVnNTVnA2WXowPQ=="))))))))).ToString();
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0001D57C File Offset: 0x0001B77C
		public static int GoToHome(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = !(chrome.GetURL() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhPV2xOYWtaelZFYzFRMkl5VGtKUVZEQTk="))))))))) && !(chrome.GetURL() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9")))))))));
					if (flag3)
					{
						bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1lXSkdjRmhWYlZwb1lsWlplbGRzWkROYU1XeFNVRlF3UFE9PQ==")))))))), 0.0) == 1;
						if (flag4)
						{
							chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVXBOYkhCelYyeGtVMXB0Um5SV2FrNWhWak5rYmxkV1RtcGpRVDA5")))))))));
							chrome.DelayThaoTacNho(0, null);
						}
						bool flag5 = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1lXSkdjRmhWYlZwb1lsWlplbGRzWkROYU1XeFNVRlF3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) != 1;
						if (flag5)
						{
							chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhPV2xOYWtaelZFYzFRMkl5VGtKUVZEQTk=")))))))));
						}
						chrome.DelayTime(1.0);
						bool flag6 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa1JOV0ZaYVYwWnNNRmRYTlZkTlIxSklUMWhWUFE9PQ==")))))))), 2.0) == 1;
						if (flag6)
						{
							chrome.ClickWithAction(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYwNUZlRmhPVjJocllWUkdjRnBHYUZOTlIwbDVUa1F3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
							chrome.DelayTime(2.0);
						}
					}
					bool flag7 = chrome.CheckChromeClosed();
					if (flag7)
					{
						return -2;
					}
					bool flag8 = chrome.GetURL() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhPV2xOYWtaelZFYzFRMkl5VGtKUVZEQTk=")))))))) || chrome.GetURL() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhPV2xOYWtaelZFYzFRMkl5VGtWUFdHeGhWakZyTlZwRVNuTk9iR3haVTIxMFMySkViRFZYYTJoS1VGRTlQUT09")))))))) || chrome.GetURL() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9"))))))));
					if (flag8)
					{
						return 1;
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001DB2C File Offset: 0x0001BD2C
		public static int GoToFriend(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MySkhUbGxXYlhocVRURktObGRFU25kaVIxRjVWbTVPU2xJd1ZUaz0=")))))))), 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVXBOTUhCeldURm9WMkpIVFhwVmJuQlpUVzVDYzFwRVNsZGpNR3hJVWxjMVRGVlVNRGs9")))))))));
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MySkhUbGxXYlhocVRURktObGRFU25kaVIxRjVWbTVPU2xJd1ZUaz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MySkhUbGxXYlhocVRURktObGRFU25kaVIxRjVWbTVPU2xJd1ZUaz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						bool flag6 = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkRmt5TVhOaVIwcDBWVzV3VFUxck5YTlpiVFZUWWtkT2NFOVhNV3BpVjNoeldXMHhVMlZyZURaUFdGSmhZbFp3YlZsdE1VZE5iRUpWVWxkc1dWVlVNRGs9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
						if (flag6)
						{
							chrome.DelayThaoTacNho(0, null);
							return 1;
						}
					}
					return chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhNV3BpVjNoeldXMHhVMlZyZDNsVWJYaHBZbXhLYzFreWF6VmlWMDUwWWtkNGFXSldTalpVU0c4MVpFWndkRmR0V21saVZWbDVWVVpTUmxCUlBUMD0=")))))))));
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001DF64 File Offset: 0x0001C164
		public static int GoToFriendSuggest(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MySkhUbGxXYlhocVRURktObGRFU25kaVIxRjVWbTVPU2xJd1ZUaz0=")))))))), 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVXBOTUhCeldURm9WMkpIVFhwVmJuQlpUVzVDYzFwRVNsZGpNR3hJVWxjMVRGVlVNRGs9")))))))));
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MySkhUbGxXYlhocVRURktObGRFU25kaVIxRjVWbTVPU2xJd1ZUaz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1MySkhUbGxXYlhocVRURktObGRFU25kaVIxRjVWbTVPU2xJd1ZUaz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						bool flag6 = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkRmt5TVhOaVIwcDBWVzV3VFUxck5YTlpiVFZUWWtkT2NFOVljR3RXTWxKMVYyeG9UMDFIUmxoUFdGWnFaVlJuZGxsc1pHRmlWbWQ1VGxkb2EyRnFRalJUYlRWTFlrWndjVTFYYkdsTmFteDVXV3hrUjJWWFJYcFVWMnhaVlZRd09RPT0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
						if (flag6)
						{
							chrome.DelayThaoTacNho(0, null);
							return 1;
						}
					}
					return chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhNV3BpVjNoeldXMHhVMlZyZDNsVWJYaHBZbXhLYzFreWF6VmxiVkpZV2tjMVlWZEZOSGRaVm1NMVpGZE9OVTlET1dsV01YQjBWMFJKTVdGSFVuRk5TR2hMWW10d2MxZHRiM2hoVjBsNVQxaEthVll3V2pWWlZFNU9VRkU5UFE9PQ==")))))))));
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001E39C File Offset: 0x0001C59C
		public static int GoToGroup(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUbGRvYTJGVVJqTlphazVEWkcxU2RGWnViRXBTTUhBeVdXcEtNR1JHYkZsVGJrcHFaVlZ3YTFWSE1VWlFVVDA5")))))))), 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYkVwdldrVmtSbVJIVFhsaVJ6Vm9Wak5qTlZOWE1ERmhSMUp3VFZoa2FVMHdTakphUnpGWFpWVnNTRk51V21sTmJsSXdWMVpvUzJOdFRqVlRiVkpSWWxWV2RWTXhSVGxRVVQwOQ==")))))))));
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUbGRvYTJGVVJqTlphazVEWkcxU2RGWnViRXBTTUhBeVdXcEtNR1JHYkZsVGJrcHFaVlZ3YTFWSE1VWlFVVDA5")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUbGRvYTJGVVJqTlphazVEWkcxU2RGWnViRXBTTUhBeVdXcEtNR1JHYkZsVGJrcHFaVlZ3YTFWSE1VWlFVVDA5")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						string cssSelector = chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1MySkdjRzVRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS2EyVlhTWHBXYm1ScVpWUm5PUT09")))))))));
						bool flag6 = cssSelector != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag6)
						{
							chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lORDA9")))))))) + cssSelector + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9")))))))));
							chrome.DelayThaoTacNho(0, null);
							bool flag7 = chrome.Click(4, cssSelector, 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
							if (flag7)
							{
								chrome.DelayThaoTacNho(2, null);
								bool flag8 = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkVmt5TURWTlYwNUpWRzFhV21KcmNESmFSRTVQWWtWM2VtSklXbXRYUlhCdFYycE9TMlJ0VWxsUmJuQk5aVlZ3YXc9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
								if (flag8)
								{
									chrome.DelayThaoTacNho(0, null);
									return 1;
								}
							}
						}
					}
					return chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhOV3BpVkd0NFdUQm9UMXBzYkhWVGJscHJUVEExYzFSRVRuTmtiVkpaVTIxYVlVMHdjREphUm1oRFpXdDRNMUJVTUQwPQ==")))))))));
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001EA48 File Offset: 0x0001CC48
		public static int GoToWatch(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUbGRvYTJGVVJqTlphazVEWkcxU2RGWnViRXBTTUhBeVdXcEtNR1JHYkZsVGJrcHFaVlZ3YTFWSE1VWlFVVDA5")))))))), 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYkVwdldrVmtSbVJIVFhsaVJ6Vm9Wak5qTlZOWE1ERmhSMUp3VFZoa2FVMHdTakphUnpGWFpWVnNTRk51V21sTmJsSXdWMVpvUzJOdFRqVlRiVkpSWWxWV2RWTXhSVGxRVVQwOQ==")))))))));
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUbGRvYTJGVVJqTlphazVEWkcxU2RGWnViRXBTTUhBeVdXcEtNR1JHYkZsVGJrcHFaVlZ3YTFWSE1VWlFVVDA5")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUbGRvYTJGVVJqTlphazVEWkcxU2RGWnViRXBTTUhBeVdXcEtNR1JHYkZsVGJrcHFaVlZ3YTFWSE1VWlFVVDA5")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						string cssSelector = chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1MySkdjRzVRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST2EyRkhVa2hVYlRsTlpIb3dPUT09")))))))));
						bool flag6 = cssSelector != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag6)
						{
							chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lORDA9")))))))) + cssSelector + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9")))))))));
							chrome.DelayThaoTacNho(0, null);
							bool flag7 = chrome.Click(4, cssSelector, 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
							if (flag7)
							{
								chrome.DelayThaoTacNho(0, null);
								return 1;
							}
						}
					}
					return chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVVUbHBYUmtweFdWVk5ORXd5VG5SV2JURlJWakJ3TWxscVNqQmtSbXhaVTI1S2FtUjZNRGs9")))))))));
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0001F020 File Offset: 0x0001D220
		public static int GoToSetting(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUbGRvYTJGVVJqTlphazVEWkcxU2RGWnViRXBTTUhBeVdXcEtNR1JHYkZsVGJrcHFaVlZ3YTFWSE1VWlFVVDA5")))))))), 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYkVwdldrVmtSbVJIVFhsaVJ6Vm9Wak5qTlZOWE1ERmhSMUp3VFZoa2FVMHdTakphUnpGWFpWVnNTRk51V21sTmJsSXdWMVpvUzJOdFRqVlRiVkpSWWxWV2RWTXhSVGxRVVQwOQ==")))))))));
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUbGRvYTJGVVJqTlphazVEWkcxU2RGWnViRXBTTUhBeVdXcEtNR1JHYkZsVGJrcHFaVlZ3YTFWSE1VWlFVVDA5")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUbGRvYTJGVVJqTlphazVEWkcxU2RGWnViRXBTTUhBeVdXcEtNR1JHYkZsVGJrcHFaVlZ3YTFWSE1VWlFVVDA5")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						string cssSelector = chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1MySkdjRzVRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1QySkhVa2xWYmtKcFlsZFNObFJJWXpsUVVUMDk=")))))))));
						bool flag6 = cssSelector != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (flag6)
						{
							chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lORDA9")))))))) + cssSelector + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9")))))))));
							chrome.DelayThaoTacNho(0, null);
							bool flag7 = chrome.Click(4, cssSelector, 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
							if (flag7)
							{
								chrome.DelayThaoTacNho(0, null);
								return 1;
							}
						}
					}
					return chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZYUmtsM1dWWmpNV0p0VGpWUFF6bGhWbnBWZDFreU5YTmFiVTVJVDFoQ2FXSnNSVFZYVnpBMVpHMUZlVTFYYUdwaVdFMDU=")))))))));
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001F5F8 File Offset: 0x0001D7F8
		public static int GoToSetting_TimelineAndTagging(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					CommonChrome.GoToSetting(chrome);
					string cssSelector = chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1MySkdjRzVRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1EyVlhSbGxYYldoYVRUSjBNbHBGWXpWTlZtdDVXak5hYTFJeWVEQlhiR1EwWTBkS2RGWnRXbHBXZWxaeVYwUk9VMkZHYjNsYVNFSnBZbGRPTWc9PQ==")))))))));
					bool flag3 = cssSelector != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lORDA9")))))))) + cssSelector + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9")))))))));
						chrome.DelayThaoTacNho(0, null);
						bool flag4 = chrome.Click(4, cssSelector, 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
						if (flag4)
						{
							chrome.DelayThaoTacNho(0, null);
							return 1;
						}
					}
					return chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlaR3BpVjNkNVYxWmtUMDVWZDNwVmJscHJWakExZGxSRVRsTmpSMHBZVm01T2FGWjZWbk5YUkVwSFpGWndSMDlVUWxwV01sSjFXVlpqTVdKcmVETlFWREE5")))))))));
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0001F950 File Offset: 0x0001DB50
		public static int GoToNotifications(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1XUnRVa2hpUnpGb1ZqQTFiMXBGWkhOa2JVcDFWRzFhYUdKV1dYcFhiR1F6V2pGc1VsQlVNRDA9")))))))), 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVXBOYWxZeVdrVmtjMkpYUmxoVWJXaHJVako0TWxsdE5VOWFiVVowVm1wT1lWWXpaRzVYVms1cVkwRTlQUT09")))))))));
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1XUnRVa2hpUnpGb1ZqQTFiMXBGWkhOa2JVcDFWRzFhYUdKV1dYcFhiR1F6V2pGc1VsQlVNRDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1XUnRVa2hpUnpGb1ZqQTFiMXBGWkhOa2JVcDFWRzFhYUdKV1dYcFhiR1F6V2pGc1VsQlVNRDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						return 1;
					}
					return chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlWbWxOTVVwM1YyMHhjMkZzYkZsVmJrSnBUV3BXTmxSSE5VTmlNazVGVDFoc1lWWXhhelZYVnpBMVpHMUZlVTFYYUdwaVdGSTI=")))))))));
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0001FCA4 File Offset: 0x0001DEA4
		public static int GoToMessages(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmVHSkhUWHBVYldoaFRXeGFObGRFU25kaVIxRjVWbTVPU2xJd1ZUaz0=")))))))), 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVXBOYWtaeldYcE9UMkZHYjNsV2JuQlpUVzVDYzFwRVNsZGpNR3hJVWxjMVRGVlVNRGs9")))))))));
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmVHSkhUWHBVYldoaFRXeGFObGRFU25kaVIxRjVWbTVPU2xJd1ZUaz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmVHSkhUWHBVYldoaFRXeGFObGRFU25kaVIxRjVWbTVPU2xJd1ZUaz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					}
					bool flag5 = num == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						return 1;
					}
					return chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlVbUZYUlRVMlYxWmthMkpIVGpWUFF6bGhWbnBWZDFreU5YTmtNa2w1WWtoV2ExSkVSbmhYYkdocllrZEtSRmR1Vm1sTlZHeDJXVlpvVDAxR1FsVlNWekZxWWxaYWRGVkdaRXRrYlVsNVpFaFNXbGRGY0hsWk0yTTVVRkU5UFE9PQ==")))))))));
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0002000C File Offset: 0x0001E20C
		public static int GoToMessagesUnread(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = CommonChrome.GoToMessages(chrome) == 1;
					if (flag2)
					{
						bool flag3 = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNNRmRzYUU5bGJHeFlXa2Q0YW1WVVozWlhiVEExWXpGd1NGWnViRkZYUmxveFdUSXhWMkZHY0VSWGJteGhWakZ3ZDFkclVYZGxSVEZVVjI1c1lWWXhhelZYVnpBMVpHMUZlVTFYYUdwaVdGSTJVMWQzZDFCUlBUMD0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
						if (flag3)
						{
							chrome.DelayRandom(3, 5);
							return 1;
						}
					}
					return chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlVbUZYUlRVMlYxWmthMkpIVGpWUFF6bGhZbFJzZWxkclpGZGxWa0paVm01V2FtSldXbTlYYTA1aFpWWndXRmRVYkZwaVZHd3lXVlJKZUdGSFRuUmtTRzg5")))))))));
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000201BC File Offset: 0x0001E3BC
		public static int GoToSearch(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1XUnRVa2hpUnpGb1ZqQTFiMXBGWkhOa2JVcDFWRzFhYUdKV1dYcFhiR1F6V2pGc1VsQlVNRDA9")))))))), 0.0) == 1;
					if (flag3)
					{
						chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVXBOTURWelYxWm9TMkZ0UmtkUFdFWmhWMGRTYzFsclRrTmhSWEExWVhvd1BRPT0=")))))))));
						chrome.DelayThaoTacNho(0, null);
					}
					int num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1QySkdiRmxUYlhCb1VtcHNlRmRzYUd0aVIwcEVVVzFuUFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					bool flag4 = num != 1;
					if (flag4)
					{
						CommonChrome.GoToHome(chrome);
						chrome.DelayThaoTacNho(2, null);
						num = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1QySkdiRmxUYlhCb1VtcHNlRmRzYUd0aVIwcEVVVzFuUFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
					}
					bool flag5 = num == 1 && chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmVHRkhSbGhPU0ZKcVRXeGFiMWt5TVU5aU1IaFlZa2hXYWxOR1dYYz0=")))))))), 0.0) == 1;
					if (flag5)
					{
						chrome.DelayThaoTacNho(1, null);
						return 1;
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0002053C File Offset: 0x0001E73C
		public static int GoToSearchGroup(Chrome chrome, string tuKhoa, int tocDoGoVanBan = 0)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = CommonChrome.GoToSearch(chrome) == 1;
					if (flag3)
					{
						bool flag4 = false;
						bool flag5 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmVHRkhSbGhPU0ZKcVRXeGFiMWt5TVU5aU1IaFlZa2hXYWxOR1dYYz0=")))))))), 0.0) == 1;
						if (flag5)
						{
							tuKhoa = Common.SpinText(tuKhoa, Base.rd);
							switch (tocDoGoVanBan)
							{
							case 0:
								chrome.SendKeys(Base.rd, 1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTbkJOV0hCaFZqQmFOVmRVU201a1IwWllUbGhrYTFkR1JUaz0=")))))))), tuKhoa, 0.1, true, 0.1);
								break;
							case 1:
								chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTbkJOV0hCaFZqQmFOVmRVU201a1IwWllUbGhrYTFkR1JUaz0=")))))))), tuKhoa, 0.1, true, 0.1);
								break;
							case 2:
								chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTbkJOV0hCaFZqQmFOVmRVU201a1IwWllUbGhrYTFkR1JUaz0=")))))))), tuKhoa, true, 0.1);
								break;
							}
							chrome.DelayThaoTacNho(0, null);
							chrome.SendEnter(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTbkJOV0hCaFZqQmFOVmRVU201a1IwWllUbGhrYTFkR1JUaz0=")))))))));
							chrome.DelayThaoTacNho(2, null);
							string cssSelector = chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUVmhPV2xkSGVITlpNbXQ0WWpKR1dGVnRlRTFXZW13eFZFWmtUMk15UmxoVWJrcEtVMFUxYzFkV2FFdGhiVVpFVFZSQ1dsWXdjSEJYVm1oS1pFZFNTRkp0YkVwaVJFRTU=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1MySkdjRzVRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1QySkdiRmxUYlhCb1VYcHNkVmt5TURWTlYwNUpWRlF3UFE9PQ==")))))))));
							bool flag6 = cssSelector != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag6)
							{
								bool flag7 = chrome.Click(4, cssSelector, 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 0;
								if (flag7)
								{
									bool flag8 = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeHdVVzB4YVZOSGVESmFSbWhTWkVacmVWSnFSbXBOYTFwNlUxZDNkMUJSUFQwPQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
									if (flag8)
									{
										chrome.DelayThaoTacNho(0, null);
										cssSelector = chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUVmhPV2xkSGVITlpNbXQ0WWpKR1dGVnRlRTFXZW13eFZFWmtUMk15UmxoVWJrcEtVMFUxYzFkV2FFdGhiVVpFVFZSQ1dsWXdjSEJYVm1oS1pFZFNTRkp0YkVwaVJFRTU=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1MySkdjRzVRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1QySkdiRmxUYlhCb1VYcHNkVmt5TURWTlYwNUpWRlF3UFE9PQ==")))))))));
										bool flag9 = cssSelector != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
										if (flag9)
										{
											flag4 = true;
											chrome.Click(4, cssSelector, 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
											chrome.DelayThaoTacNho(2, null);
										}
									}
								}
								else
								{
									flag4 = true;
									chrome.DelayThaoTacNho(2, null);
								}
							}
						}
						bool flag10 = !flag4;
						if (flag10)
						{
							chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZXTUZvMVYxUktibVJzYjNwVGJscHJWMFZLTmxSSWJ6VmxSa0pTVUZRd1BRPT0=")))))))) + tuKhoa);
							chrome.DelayThaoTacNho(2, null);
							flag4 = true;
						}
						bool flag11 = flag4;
						if (flag11)
						{
							chrome.DelayThaoTacNho(1, null);
							return 1;
						}
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00020D70 File Offset: 0x0001EF70
		public static int GoToSearchFriend(Chrome chrome, string tuKhoa, int tocDoGoVanBan = 0)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					bool flag3 = CommonChrome.GoToSearch(chrome) == 1;
					if (flag3)
					{
						bool flag4 = false;
						bool flag5 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmVHRkhSbGhPU0ZKcVRXeGFiMWt5TVU5aU1IaFlZa2hXYWxOR1dYYz0=")))))))), 0.0) == 1;
						if (flag5)
						{
							tuKhoa = Common.SpinText(tuKhoa, Base.rd);
							switch (tocDoGoVanBan)
							{
							case 0:
								chrome.SendKeys(Base.rd, 1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTbkJOV0hCaFZqQmFOVmRVU201a1IwWllUbGhrYTFkR1JUaz0=")))))))), tuKhoa, 0.1, true, 0.1);
								break;
							case 1:
								chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTbkJOV0hCaFZqQmFOVmRVU201a1IwWllUbGhrYTFkR1JUaz0=")))))))), tuKhoa, 0.1, true, 0.1);
								break;
							case 2:
								chrome.SendKeys(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTbkJOV0hCaFZqQmFOVmRVU201a1IwWllUbGhrYTFkR1JUaz0=")))))))), tuKhoa, true, 0.1);
								break;
							}
							chrome.DelayThaoTacNho(0, null);
							chrome.SendEnter(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1IyTkhTbkJOV0hCaFZqQmFOVmRVU201a1IwWllUbGhrYTFkR1JUaz0=")))))))));
							chrome.DelayThaoTacNho(2, null);
							string cssSelector = chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUVmhPV2xkSGVITlpNbXQ0WWpKR1dGVnRlRTFXZW13eFZFWmtUMk15UmxoVWJrcEtVMFUxYzFkV2FFdGhiVVpFVFZSQ1dsWXdjSEJYVm1oS1pFZFNTRkp0YkVwaVJFRTU=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1MySkdjRzVRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1QySkdiRmxUYlhCb1VYcHNNMWRzWXpWa01rcElWbFF3UFE9PQ==")))))))));
							bool flag6 = cssSelector != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag6)
							{
								bool flag7 = chrome.Click(4, cssSelector, 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 0;
								if (flag7)
								{
									bool flag8 = chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeHdVVzB4YVZOSGVESmFSbWhTWkVacmVWSnFSbXBOYTFwNlUxZDNkMUJSUFQwPQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
									if (flag8)
									{
										chrome.DelayThaoTacNho(0, null);
										cssSelector = chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBUVmhPV2xkSGVITlpNbXQ0WWpKR1dGVnRlRTFXZW13eFZFWmtUMk15UmxoVWJrcEtVMFUxYzFkV2FFdGhiVVpFVFZSQ1dsWXdjSEJYVm1oS1pFZFNTRkp0YkVwaVJFRTU=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1MySkdjRzVRVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1QySkdiRmxUYlhCb1VYcHNNMWRzWXpWa01rcElWbFF3UFE9PQ==")))))))));
										bool flag9 = cssSelector != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
										if (flag9)
										{
											flag4 = true;
											chrome.Click(4, cssSelector, 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
											chrome.DelayThaoTacNho(2, null);
										}
									}
								}
								else
								{
									flag4 = true;
									chrome.DelayThaoTacNho(2, null);
								}
							}
						}
						bool flag10 = !flag4;
						if (flag10)
						{
							chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR0ZXTUZvMVYxUktibVJ0VGtoV2JscHFVak5vYzFSSWJ6VmxSa0pTVUZRd1BRPT0=")))))))) + tuKhoa + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIwMVQyUnRVbGxUYlhCaFZrUkdkRmxXWkRSTlJuQlpVMWN4YUZkRk5WWlpNakZYWkZad1NHSklWbUZsYWtJeg==")))))))));
							chrome.DelayThaoTacNho(2, null);
							flag4 = true;
						}
						bool flag11 = flag4;
						if (flag11)
						{
							chrome.DelayThaoTacNho(1, null);
							return 1;
						}
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000215EC File Offset: 0x0001F7EC
		public static int GoToBirthday(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhiR3BpVkd0NldYcEtWbVJzYkhSaVNHeHJVakpvY2xkV2FITmxhM2d6VUZRd1BRPT0="))))))))) != -2;
					if (flag2)
					{
						chrome.DelayRandom(2, 5);
						return 1;
					}
					return -2;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000216D4 File Offset: 0x0001F8D4
		public static int GoToPoke(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlaR2xOYmxKeldUTnJORkJSUFQwPQ=="))))))))) != -2;
					if (flag2)
					{
						chrome.DelayRandom(2, 5);
						return 1;
					}
					return -2;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000217BC File Offset: 0x0001F9BC
		public static int ScrollRandom(Chrome chrome, int from = 3, int to = 5)
		{
			try
			{
				bool flag = chrome.CheckChromeClosed();
				if (flag)
				{
					return -2;
				}
				int num = Base.rd.Next(from, to + 1);
				int num2 = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3YjNsaFJFSnBWak5rZFZNeFRURmliSEJaVld0T2FVMHhXakZYYTJSelpGWnZkMVJ1VG1oV01Wb3hXa1ZhUzJKR2EzcFZWemxNVlhwVk1WTXpiR3BpWnowOQ=="))))))))).ToString());
				bool flag2 = chrome.ScrollSmooth(Base.rd.Next(chrome.GetSizeChrome().Y / 2, chrome.GetSizeChrome().Y)) == 1;
				if (flag2)
				{
					chrome.DelayRandom(1, 3);
					int num3 = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3YjNsaFJFSnBWak5rZFZNeFRURmliSEJaVld0T2FVMHhXakZYYTJSelpGWnZkMVJ1VG1oV01Wb3hXa1ZhUzJKR2EzcFZWemxNVlhwVk1WTXpiR3BpWnowOQ=="))))))))).ToString());
					bool flag3 = num2 != num3;
					if (flag3)
					{
						for (int i = 0; i < num - 1; i++)
						{
							num2 = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3YjNsaFJFSnBWak5rZFZNeFRURmliSEJaVld0T2FVMHhXakZYYTJSelpGWnZkMVJ1VG1oV01Wb3hXa1ZhUzJKR2EzcFZWemxNVlhwVk1WTXpiR3BpWnowOQ=="))))))))).ToString());
							bool flag4 = chrome.ScrollSmooth(((Base.rd.Next(1, 1000) % 5 != 0) ? 1 : -1) * Base.rd.Next(chrome.GetSizeChrome().Y / 2, chrome.GetSizeChrome().Y)) == -2;
							if (flag4)
							{
								return -2;
							}
							chrome.DelayRandom(1, 3);
							num3 = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3YjNsaFJFSnBWak5rZFZNeFRURmliSEJaVld0T2FVMHhXakZYYTJSelpGWnZkMVJ1VG1oV01Wb3hXa1ZhUzJKR2EzcFZWemxNVlhwVk1WTXpiR3BpWnowOQ=="))))))))).ToString());
							bool flag5 = num2 != num3;
							if (!flag5)
							{
								break;
							}
							chrome.DelayRandom(1, 2);
						}
					}
					return 1;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00021B44 File Offset: 0x0001FD44
		public static int CheckStatusChrome(Chrome chrome)
		{
			try
			{
				bool flag = chrome != null;
				if (flag)
				{
					bool flag2 = chrome.CheckChromeClosed();
					if (flag2)
					{
						return -2;
					}
					int num = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2QyVnRUWGxXYms1aFZqQTBkMVZHVGt0bGJWSllXa2MxWVZkRk5IZFpWbU0xWkZkTmVGUnFSbWxXZWtadldUSTFjMVJYUmxsVWFrSktZa1JCT1E9PQ==")))))))), 0.0);
					int num2 = num;
					int num3 = num2;
					if (num3 == -2)
					{
						return -2;
					}
					if (num3 == 1)
					{
						return -3;
					}
					bool flag3 = CommonChrome.IsCheckpoint(chrome);
					if (flag3)
					{
						return -1;
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00021C74 File Offset: 0x0001FE74
		public static string GetUserAgentDefault()
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				JSON_Settings json_Settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
				Chrome chrome = new Chrome
				{
					HideBrowser = true,
					PathExtension = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))
				};
				bool flag = json_Settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2MyUXhjRlpUYm14cFRUSlNObGRzYUVwUVVUMDk=")))))))), 0) != 0;
				if (flag)
				{
					chrome.LinkToOtherBrowser = json_Settings.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IwMUdVa2hpU0Zab1RWWktNbFpFVGxOaU1YQlpVMnRPYW1KVWEzcFpla3BYWlZFOVBRPT0=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				}
				bool flag2 = chrome.Open(true);
				if (flag2)
				{
					text = chrome.GetUseragent();
					text = text.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCa1YyRkdjRWhsUjNocVRUQXdPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					chrome.Close();
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00021F60 File Offset: 0x00020160
		public static string LoginFacebookUsingCookie(Chrome chrome, string cookie, string URL = "https://www.facebook.com")
		{
			try
			{
				bool flag = chrome.GotoURLIfNotExist(URL) == -2;
				if (flag)
				{
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1NsQlJQVDA9"))))))));
				}
				bool flag2 = chrome.AddCookieIntoChrome(cookie, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeFlXRkdhM2xXYld4cFRXcHNlVlJITVU5a2JVcFNVRlF3UFE9PQ=="))))))))) == -2;
				if (flag2)
				{
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1NsQlJQVDA9"))))))));
				}
				bool flag3 = chrome.Refresh() == -2;
				if (flag3)
				{
					return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1NsQlJQVDA9"))))))));
				}
				return CommonChrome.CheckLiveCookie(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9"))))))))).ToString() ?? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			catch
			{
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWRk9WQlJQVDA9"))))))));
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00022214 File Offset: 0x00020414
		public static int CheckTypeWebFacebookFromUrl(string url)
		{
			int result = 0;
			bool flag = url.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2VUZFOVBRPT0="))))))))) || url.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNkRmRXWkU5aVJteDBUMWhhYUdSNk1Eaz0="))))))))) || url.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbGRzWkVwa1ZuQjBVbTF3WVZZd2NESlpha3A2VUZFOVBRPT0=")))))))));
			if (flag)
			{
				result = 1;
			}
			else
			{
				bool flag2 = url.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIaz0="))))))))) || url.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNjbFJITVdGaFJtdDVWbTFzYVUxcWJIaz0="))))))))) || url.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmxxU2t0alIwcElWbGhXWVdKVlduRlhiR1JMWkcxSmVXTjZNRDA9")))))))));
				if (flag2)
				{
					result = 2;
				}
				else
				{
					bool flag3 = url.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTjZNRDA9")))))))));
					if (flag3)
					{
						result = 3;
					}
				}
			}
			return result;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000224BC File Offset: 0x000206BC
		public static int CheckFacebookWebsite(Chrome chrome, string url)
		{
			bool flag = !chrome.CheckIsLive();
			int result;
			if (flag)
			{
				result = -2;
			}
			else
			{
				int num = 0;
				for (int i = 0; i < 2; i++)
				{
					num = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL());
					bool flag2 = num == 0;
					if (!flag2)
					{
						break;
					}
					chrome.GotoURL(url);
					chrome.DelayTime(1.0);
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00022578 File Offset: 0x00020778
		public static List<string> GetListLinkFromWebsite(Chrome chrome)
		{
			List<string> result = new List<string>();
			try
			{
				result = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhTYm14cVlXcEdhVmRHVW5wYU1YQklUMWR3YTFaNlJuTlpiVFZTWkZkT1dWWnRlR3BpYlhoVlYyeGtOR0pHYTNwVmJscHFZVEJhZWxsclRtNWliR3hVV1ROQ1RXSldjREpaTW5SWFlVWnJlVm95T1dGV1JFRnlXbFJLUjJWWFRuQk9XR1JyVjBVMWRsTXdaRlprVjBaSlUyMTRZV0ZYZHpWVE1WSXdUV3hzV1ZOWFpHcGxha1p2V1RJMVNtUlhSblJQV0VKcFlWZGtkVnByVG1walJUazFVVzVzWVZkR1NYaFpNakF3V2pKT00xQlVNRDA9"))))))))).ToString().Split(new char[]
				{
					'|'
				}).ToList<string>();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00022634 File Offset: 0x00020834
		public static int GotoLogin(Chrome chrome, int typeWeb)
		{
			bool flag = false;
			try
			{
				switch (typeWeb)
				{
				case 1:
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYm1neVYycEtjMlJSUFQwPQ==")))))))));
					break;
				case 2:
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlUbWxOYlZKM1dXMWpPVkJSUFQwPQ==")))))))));
					break;
				case 3:
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFUktOR1JzYjNsaVNGVTk=")))))))));
					break;
				}
				flag = true;
				chrome.DelayTime(1.0);
			}
			catch (Exception ex)
			{
			}
			return flag ? 1 : 0;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000227E4 File Offset: 0x000209E4
		public static string LoginFacebookUsingUidPassNew(Chrome chrome, string uid, string pass, string fa2 = "", string Url = "https://m.facebook.com", int tocDoGoVanBan = 0, bool isDontSaveBrowser = false, int timeOut = 120)
		{
			int num = 0;
			int num2 = 0;
			int tickCount = Environment.TickCount;
			try
			{
				bool flag = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) != CommonChrome.CheckTypeWebFacebookFromUrl(Url);
				if (flag)
				{
					chrome.GotoURL(Url);
				}
				string text;
				for (;;)
				{
					int num3 = CommonChrome.CheckFacebookWebsite(chrome, chrome.GetURL());
					bool flag2 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0.0) == 1;
					if (flag2)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						bool flag3 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))), 0.0) != 1;
						if (flag3)
						{
							CommonChrome.GotoLogin(chrome, num3);
							bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0.0) == 1;
							if (flag4)
							{
								chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							}
						}
					}
					else
					{
						bool flag5 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsWmFNRmRXWkhOak1HeHpUVVF3UFE9PQ==")))))))), 0.0) == 1 && chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))), 0.0) == 1 && chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsaG9NbGRxU25Oa1ZXeHpUVVF3UFE9PQ==")))))))), 0.0) == 1;
						bool flag6 = chrome.CheckExistElements(0.0, new string[]
						{
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1IyTldiRmxoU0VKaFltMTBlRlZHVGtwa2JVcElUMWMxYUZaNlVqSlhhMlJYVFcxR1dGUnRlRTFXTUhCdldYcEtWMkV3ZDNsU2JuQnNWbnBXY1ZSRVRrdGlSMHBZVDFSS1lWVjZhSEJYUmtVNVVGRTlQUT09")))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBaVWhhWVUxdGVERlhSRTVEWlZkSmVWZHVRbWxTTVZwdFYyMHdOV1ZYU2xSVGJWSktVakZLZDFwSGVEQmxWMGw1WlVkNFVWVXdjSEJhUm1oVFRVZEplVTVIYkZsVlZEQTU=")))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1IyRnRVa2hpU0ZwcFlXcENjRlJFU2pSa2JHOTVZa2hXVFUxc1NuTmFSekZ6WVd4d1ZFMVhiRnBYUlRWelYydE5OVTFzYkZobFNFSmhVakJaZDFkc1RYaGtNa1pZVGtoYVNtSkVRbTVaVm1NeFpESlNXVlZ0U210VFIzZ3pWMnhSZDJGWFRYcFdiV3hwVmpKM2QxTlhkM2RRVVQwOQ=="))))))))
						}) > 0;
						bool flag7 = !flag5 && !flag6;
						if (flag7)
						{
							CommonChrome.GotoLogin(chrome, num3);
							bool flag8 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0.0) == 1;
							if (flag8)
							{
								chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKYVRXcHNNbGxVU25OaVJteDBVbTVXYVdKV1dqVlZSazVMWVVacmVWUnRlR3BUUmtwdFYxYzFWMDFIVWtoUFdGWktZa1JCT1E9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							}
						}
					}
					bool flag9 = CommonChrome.CheckCheckpoint(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					if (flag9)
					{
						break;
					}
					int num4 = chrome.CheckExistElements(0.0, new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDBaVWhhWVUxdGVERlhSRTVEWlZkSmVWZHVRbWxTTVZwdFYyMHdOV1ZYU2xSVGJWSktVakZLZDFwSGVEQmxWMGw1WlVkNFVWVXdjSEJhUm1oVFRVZEplVTVIYkZsVlZEQTU=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1IyRnRVa2hpU0ZwcFlXcENjRlJFU2pSa2JHOTVZa2hXVFUxc1NuTmFSekZ6WVd4d1ZFMVhiRnBYUlRWelYydE5OVTFzYkZobFNFSmhVakJaZDFkc1RYaGtNa1pZVGtoYVNtSkVRbTVaVm1NeFpESlNXVlZ0U210VFIzZ3pWMnhSZDJGWFRYcFdiV3hwVmpKM2QxTlhkM2RRVVQwOQ=="))))))))
					});
					bool flag10 = num3 == 2 && num4 > 0;
					if (flag10)
					{
						int num5 = num4;
						int num6 = num5;
						if (num6 != 1)
						{
							if (num6 == 2)
							{
								chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYTFweFdrVmtjMlJ0U25GTlIyeE5UVzVvTWxkcVNuTmtWWGQ1VlcxNGEySlhlSEZYYkUxNFlWWnNXVlJ0ZUdGUmVtdDVWMVprTkdOR2NFaFNha0poVlhwR00xbFdZekJrYTJ4elRVZGthRlo2VmpOYVJtaFRXVzFTU1dKSVpHRldSRUp3V1hwT1YyRlhTbGhpUkVKS1lrUkNkVk14VFRGaGJVcElZa2R3YUdWWFpIYz0=")))))))));
							}
						}
						else
						{
							chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYkVwdldrVmtSbVJIVFhsaVJ6Vm9Wak5qTlZOWE1UUmtiRzk1WWtoV1dVMHdTalZaYWtwaFkwZEtTRlp0V21GaVZHdzFXV3hPUzFwRmJFaFZia0pyWWtoU05WbHFTalJpUmtKVVUyMXNhMWRHU1hkWmFra3dZVlpvVkZrelFrMWlWVFY2V1Zaa1QyTnJkRVJoZWpBOQ==")))))))));
						}
						chrome.DelayTime(1.0);
						num2 = chrome.CheckExistElements(5.0, new string[]
						{
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs1aFZtaFNVRlF3UFE9PQ==")))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1IyUXlUa2xUYmxwcllsVmFlbGw2UlRWaGJVbDVWVzEzUFE9PQ=="))))))))
						});
						bool flag11 = num2 == 1;
						if (flag11)
						{
							bool flag12 = chrome.SendKeysWithSpeed(tocDoGoVanBan, 2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))), pass, 0.1, true, 0.1) == 1;
							if (flag12)
							{
								chrome.DelayTime(1.0);
								bool flag13 = chrome.Click(4, chrome.GetCssSelector(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZVOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwMUdiRlJOV0hCb1ZqSlNkMWxyUlRsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWHBhU0ZwcVlsWktiVmxyWXpWaWJVWllUbGRhV21Kc1dYZGFSV00xWkZFOVBRPT0="))))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1) == 1;
								if (flag13)
								{
									chrome.DelayTime(1.0);
								}
							}
						}
					}
					else
					{
						bool flag14 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFWVzVhYTFZd05YWlhWbVJMWXpGd1ZGTnRVVDA9")))))))), 0.0) == 1 && chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSmVGcHRTa2hQVnpWb1ZucFdiVmRXYUZkTlIwbDRUMWh3WVZZd1dqVlhWRXB2V214d2RFOVliR2xXYW14MFdXcE9TMkp0U1hwVmJWcHFVakJhTmxsNlRtdGtiVTUwVlcxYVdtSnNXWGRhUldNMVpGRTlQUT09")))))))), 0.0) != 1;
						if (flag14)
						{
							chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFWVzVhYTFZd05YWlhWbVJMWXpGd1ZGTnRVVDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						}
						int num7 = 1;
						bool flag15 = false;
						do
						{
							switch (num7)
							{
							case 1:
								num2 = chrome.SendKeysWithSpeed(tocDoGoVanBan, 2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhrZWpBOQ==")))))))), uid, 0.1, true, 0.1);
								break;
							case 2:
								num2 = chrome.SendKeysWithSpeed(tocDoGoVanBan, 2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))), pass, 0.1, true, 0.1);
								break;
							case 3:
								num2 = chrome.SendEnter(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ==")))))))));
								chrome.DelayTime(3.0);
								flag15 = true;
								break;
							default:
								flag15 = true;
								break;
							}
							bool flag16 = num2 == -2;
							if (flag16)
							{
								goto Block_24;
							}
							chrome.DelayTime(1.0);
							num7++;
						}
						while (!flag15);
					}
					Dictionary<int, List<string>> dic = new Dictionary<int, List<string>>
					{
						{
							1,
							new List<string>
							{
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsaG9NbGRxU25Oa1ZXeHpUVVF3UFE9PQ==")))))))),
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdHdjMWw2U2xkTlJtZDVVbTF3YTFJeWVESlpiV3hMV2tFOVBRPT0="))))))))
							}
						},
						{
							2,
							new List<string>
							{
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVmFNMWt3YUV0a2JWSjBVbTVPYWsxVWJIRlpha3BUWWtWc2MwMUVNRDA9"))))))))
							}
						},
						{
							3,
							new List<string>
							{
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOYWJWSklZa1JDYVZJeFZUaz0="))))))))
							}
						},
						{
							4,
							new List<string>
							{
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUVNRDA9")))))))),
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOUk1rbDZWV3BDYVUxcVJrUlhWbWhLVUZFOVBRPT0="))))))))
							}
						},
						{
							5,
							new List<string>
							{
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1IySldaM3BVYmtwb1YwVktiVmRyWkhOaFIwcElUMWMxV1Uwd05YbFpWbWhEV20xS1NHSklWbWhrZWpBNQ=="))))))))
							}
						},
						{
							6,
							new List<string>
							{
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa1JOV0ZaYVYwWnNNRmRYTlZkTlIxSklUMWhWUFE9PQ=="))))))))
							}
						},
						{
							7,
							new List<string>
							{
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsUlNjRmRHUlRsUVVUMDk="))))))))
							}
						},
						{
							8,
							new List<string>
							{
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS2MyRXhjRmhPVkVKb1ZqRnZNVmRFVGs5aVJteFpVMjF3YUZKcWEzZFhiR2h2VFVabmVXSklWbXBUUmxsMw=="))))))))
							}
						}
					};
					int num8 = 0;
					int num9 = 0;
					for (;;)
					{
						bool flag17 = Environment.TickCount - tickCount >= timeOut * 1000;
						if (flag17)
						{
							goto Block_25;
						}
						num2 = chrome.CheckExistElements(0.0, dic);
						switch (num2)
						{
						case 1:
						{
							bool flag18 = num8 == 0 && num9 == 0;
							if (flag18)
							{
								text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								int num10 = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL());
								int num11 = num10;
								if (num11 != 1)
								{
									if (num11 == 2)
									{
										text = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhQVkVaclVrUkNkVk51Y0RCTmJHeFpVMWRrYkZKRVJuSlpha3BQVFZkS1dGWnVWbXRSZWxZMFdrWmtWMlZYVmxkVWJYaHBVakZhY1ZwRll6VmxWWFJFV1RKd2FWSjZiSFZaVm1NeFdteHdXVk51YkdsTk1HeDFVekZTTUdOR2NIQmhSRkpLVmtSR01WcEdaRFJqTUhSVVVXNWFhMWRHUlRWYVZVMHhZMGRLZEU1WGVHcGlSa3B6V2xWb1VrNHlUblJXYWtKclYwVndNVk5WWXpWTlYxSkZZM293UFE9PQ=="))))))))).ToString();
									}
								}
								else
								{
									text = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhQVkVaclVrUkNkVk51Y0RCTmJHeFpVMWRrYkZKRVJuSlpha3BQVFZkS1dGWnVWbXRSZWxZMFdrWmtWMlZYVmxkVWJYaHBVakZhY1ZwRll6VmxWWFJFV1RKd1lWZEZjRFZaYWs1TFdteHNkRTlVVWt0bFYzTXpXVlprV21JeVZrUlNWR3hwWW14YWVsbHJUbkphTWtsNlZtcENVVmRIWkRGWlZtTXhaRlp3V1ZOc1ZtRlhSMmQzVkhwT1MySkhVa2xXYm14cFlWVktNbHBHYUZKT2R6MDk="))))))))).ToString();
									text = ((text.Split(new string[]
									{
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))))
									}, StringSplitOptions.RemoveEmptyEntries).Count<string>() > 1) ? text.Split(new string[]
									{
										Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VWtaR2RsQlJQVDA9"))))))))
									}, StringSplitOptions.RemoveEmptyEntries)[1] : text);
								}
								bool flag19 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								if (flag19)
								{
									goto Block_32;
								}
								bool flag20 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNlbGxxU210alIwcHdUMWhDWVZJeFdqRmFSV1J6WWxkV1ZFOUhiRmxWVkRBNQ==")))))))), 0.0) == 1;
								if (flag20)
								{
									num = 4;
								}
								else
								{
									bool flag21 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1IyRnNhM2xQVkVacFlteEtiVmt5TVZkaGJVbDZWMjE0YW1KdGVHMVpWbU14WTBkU1NHSkhhR3RTTVZwdFdrY3hjMkpIVVhoUFdFNWFWakJ3YzFsclJUbFFVVDA5")))))))), 0.0) == 1;
									if (flag21)
									{
										num = 5;
									}
									else
									{
										bool flag22 = !Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VUSm9jbGxxU2s5TlYwcFlWbTVXYTFGNlZqUmFSbVJYWlZkV1YxUnRlR2xTTVZweFdrVmpOV1ZWZEVSYVIwcHBZbFZhTUZkc1VYZGhWbkJZVFZkb2FGWXpaSEJYUms1cVkwVjRkVmR0YUdsVFJscHpVMVpSZDJKcmNEVlJWekZMWVZWS2NsbHFTazlOVjBwWVZtNVdhMUY2VmpSYVJtUlhaVmRXVjFSdGVHbFNNVnB4V2tWak5XVlZkRVJhUjBwcFlsVmFNRmRzVVhkaFYwNUlVbTV3YW1WVmNHdFRibXh5WkZkU2RGSnVUbXRXTVZadlZVWk9hbUpyZEZSak1qVkxaSG93T1E9PQ=="))))))))).ToString());
										if (flag22)
										{
											bool flag23 = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3YjNoa1NGWmFWbnBHYzFWR1RrdGlSMHBZVW01Q2FWRXdjR3RUYm14eVpGZFNkRkp1VG10V01WVTU="))))))))).ToString().Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
											if (flag23)
											{
												num = 4;
											}
											else
											{
												bool flag24 = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3YjNoa1NGWmFWbnBHYzFWR1RrdGtNV3haVkc1d1NtSkVRblZUTVUweFRXeHNXR1ZFUm1GVlZEQTU="))))))))).ToString().Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
												if (flag24)
												{
													num = 5;
												}
											}
										}
									}
								}
							}
							else
							{
								bool flag25 = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TbUl3YjNoa1NGWmFWbnBHYzFWR1RrdGlSMHBZVW01Q2FWRXdjR3RUYm14eVpGZFNkRkp1VG10V01WVTU="))))))))).ToString().Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
								if (flag25)
								{
									goto Block_38;
								}
							}
							break;
						}
						case 2:
						{
							bool flag26 = fa2 == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
							if (flag26)
							{
								num = 3;
							}
							else
							{
								num8++;
								bool flag27 = num8 > 2;
								if (flag27)
								{
									goto Block_40;
								}
								string totp = Common.GetTotp(fa2.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VVRKak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Trim());
								bool flag28 = string.IsNullOrEmpty(totp);
								if (flag28)
								{
									goto Block_41;
								}
								chrome.SendKeysWithSpeed(tocDoGoVanBan, 2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlUblJQVkVwYVZqTm9ObGRFU2s5a2JIQklWbFF3UFE9PQ==")))))))), totp, 0.1, true, 0.1);
								chrome.DelayTime(1.0);
								chrome.SendEnter(2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXlUblJQVkVwYVZqTm9ObGRFU2s5a2JIQklWbFF3UFE9PQ==")))))))));
								chrome.DelayTime(1.0);
							}
							break;
						}
						case 3:
						{
							bool flag29 = num8 > 1;
							if (flag29)
							{
								num = 6;
							}
							else
							{
								bool flag30 = CommonChrome.CheckCheckpoint(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
								if (flag30)
								{
									goto Block_43;
								}
								num2 = chrome.CheckExistElements(0.0, new string[]
								{
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaS1RXczFkbGRzWkU5amJVNUlUMWhDYVdKc1NsVmFSbVJMWkVkR1dWVnJUbXRYUmtsM1dXcEpNRkJSUFQwPQ==")))))))),
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUhaRmhOTVVreFdUQmtWazlWYkhWVWFrWmFZbFJHZDFwRlRrdGFRVDA5"))))))))
								});
								num9++;
								bool flag31 = num9 > 10;
								if (flag31)
								{
									goto Block_44;
								}
								bool flag32 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1lXRkhTa2xXYlhoUlZUQndjbGxxU1RGTlJtZDZWRzFvYTJKV1ZuQlhSa1U1VUZFOVBRPT0=")))))))), 0.0) == 1 && isDontSaveBrowser;
								if (flag32)
								{
									chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1lXRkhTa2xXYlhoUlZUQndjbGxxU1RGTlJtZDZWRzFvYTJKV1ZuQlhSa1U1VUZFOVBRPT0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
								}
								bool flag33 = num2 == 1;
								if (flag33)
								{
									chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaS1RXczFkbGRzWkU5amJVNUlUMWhDYVdKc1NsVmFSbVJMWkVkR1dWVnJUbXRYUmtsM1dXcEpNRkJSUFQwPQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
								}
								else
								{
									chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUhaRmhOTVVreFdUQmtWazlWYkhWVWFrWmFZbFJHZDFwRlRrdGFRVDA5")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
								}
								chrome.DelayTime(1.0);
							}
							break;
						}
						case 4:
						{
							bool flag34 = num8 > 1;
							if (flag34)
							{
								num = 6;
							}
							else
							{
								bool flag35 = CommonChrome.CheckCheckpoint(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
								if (flag35)
								{
									goto Block_48;
								}
								num2 = chrome.CheckExistElements(0.0, new string[]
								{
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaS1RXczFkbGRzWkU5amJVNUlUMWhDYVdKc1NsVmFSbVJMWkVkR1dWVnJUbXRYUmtsM1dXcEpNRkJSUFQwPQ==")))))))),
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUhaRmhOTVVreFdUQmtWazlWYkhWVWFrWmFZbFJHZDFwRlRrdGFRVDA5"))))))))
								});
								num9++;
								bool flag36 = num9 > 10;
								if (flag36)
								{
									goto Block_49;
								}
								bool flag37 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1lXRkhTa2xXYlhoUlZUQndjbGxxU1RGTlJtZDZWRzFvYTJKV1ZuQlhSa1U1VUZFOVBRPT0=")))))))), 0.0) == 1 && isDontSaveBrowser;
								if (flag37)
								{
									chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1lXRkhTa2xXYlhoUlZUQndjbGxxU1RGTlJtZDZWRzFvYTJKV1ZuQlhSa1U1VUZFOVBRPT0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
								}
								bool flag38 = num2 == 1;
								if (flag38)
								{
									chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaS1RXczFkbGRzWkU5amJVNUlUMWhDYVdKc1NsVmFSbVJMWkVkR1dWVnJUbXRYUmtsM1dXcEpNRkJSUFQwPQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
								}
								else
								{
									chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUhaRmhOTVVreFdUQmtWazlWYkhWVWFrWmFZbFJHZDFwRlRrdGFRVDA5")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
								}
								chrome.DelayTime(1.0);
							}
							break;
						}
						case 5:
							chrome.ClickWithAction(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RGa1lWcHRUWGxrU0VKcVVtcHNjbGxXWkVkak1rbDVXa2RhYWsxdVVuZFpNRmsxWXpKR1dFNVlTVDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
							chrome.DelayTime(2.0);
							break;
						case 6:
							chrome.Click(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYwNUZlRmhPVjJocllWUkdjRnBHYUZOTlIwbDVUa1F3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							chrome.DelayTime(2.0);
							break;
						case 7:
							num = 5;
							break;
						case 8:
							goto IL_26CA;
						default:
						{
							bool flag39 = chrome.GetURL().Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDVWRzVhYVdKV2NIZFpNakIzVUZFOVBRPT0=")))))))));
							if (flag39)
							{
								goto Block_52;
							}
							bool flag40 = CommonChrome.CheckCheckpoint(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
							if (flag40)
							{
								goto Block_53;
							}
							bool flag41 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaYU1HSXlUblJXYlRGTVlXcENjRlJFVG5kaVIwNTBUMGhhYVUwd1NYZFpWbU13WkcxUmVsTnVRbXRTTVZZeVZVUktSMkZ0VWtoaVNGcHBZV3BHY1ZkV1l6RmhiSEJZWkRJeGFsSXdXblZYYkZGNFlUSkdXRkp1VG10U2Vtd3hWMnhaTldSdFRrbFZia0pwWWtSc00xZFdaR3RpUld4elRVUXdQUT09")))))))), 0.0) == 1;
							if (flag41)
							{
								chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBXYmxKMldUSXhWMkpWZEhGTlIyeE5UVE5DYzFreU1EUmtiVWw2VVdwQ2FGWjZVakphUkU1TFkwZFNTRlpZV2xGTmExcHhXa1ZrYzJSdFNuRk5WM0JhVm5wV2NWZHNaRE5pVjA1SVVtMDFZVlpFUm5KWlZtUkhZekpTU0U5WVZtRldhbXd5V1RCb1UyTkhTbk5QV0dSYVZqSlNjMU5YZDNkaWEzUlVUbGR3YVZJeWVIRlpXR3h1WTBFOVBRPT0=")))))))));
								chrome.DelayTime(3.0);
								bool flag42 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1IyRnRVa2hpU0ZwcFlXcENjRlJFVG5kaVIwNTBUMGhhYVUwd1NYZFpWbU13WkcxUmVsTnVRbXRTTVZZeVZVUktSMkZ0VWtoaVNGcHBZV3BHY1ZscVNURmlWMFpaVTI1U1MySnJTbTlYYWtwV1QxZE9kRlp0Y0dsTmFsWTJXVlprVTJKSFRuTlBXRnBxVTBaS2QxbHRkelZoTWtaWVVtNU9hVTF0VG5CWFJrNURZVmRTV1ZWcVFtbE5hbEU1")))))))), 10.0) == 1;
								if (flag42)
								{
									chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYTFweFdrVmtjMlJ0U25GTlIyeE5UVE5DYzFreU1EUmtiVWw2VVdwQ2FGWjZVakphUkU1TFkwZFNTRlpZV2xGTmExcHhXa1ZrYzJSdFNuRk5WM0JwVFdwV2RGbFdhRXRrUlhCMVVXMW9ZVTFzVlRWWk1qRlhZVzFKZVU1WWNHaFdNVXB6V1RKM05XUnRUa2xWYmtKcFlrUnNjbGxXWkVkak1rbDVXVEpzV1ZVd1NuQmFSbWhUVFVkSmVVNUhOVXhWZWxaeFdXdGtjMkZ0UmpWYU0wRTk=")))))))));
									chrome.DelayTime(3.0);
								}
							}
							else
							{
								bool flag43 = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) == 2;
								if (flag43)
								{
									bool flag44 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVVXbUZYUlhBeVZFUk9RMlJ0U2toaVIzQnNWWHBzTWxrd2FGTmpSMHB1VUZRd1BRPT0=")))))))));
									if (flag44)
									{
										chrome.DelayTime(1.0);
										chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBXYmxKeVYxWm9VMkZGZUZsVWJrSmhUVzE0ZWxWR1RrdE5SMGw2Vm0xd2FGSXdXbkJaYTJSV1lWWm9WRmt6UWsxaVZUVjZXVlprVDJOcmRFUmhlakE5")))))))));
										chrome.DelayTime(3.0);
										bool flag45 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaWVRXeEtiMXBGWkVaa1IwMTVZa2MxYUZZell6VlRWelZUWkcxU1dGUnRPVnBXTUhCNlYyeE9TMXBCUFQwPQ==")))))))), 10.0) == 1;
										if (flag45)
										{
											chrome.DelayTime(1.0);
											chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpYkZsM1drVmpOV1JXWTNsVmJXaHJVakJXTUZsNlNuTmliVVpZWkhwc1NtSnNTakphUm1SUFlqRnNXRk51VG1GVk1IQnJVMjVzY21SV2EzbGxTRUphVFc1T2RsTXhSVGxRVVQwOQ==")))))))));
											chrome.DelayTime(3.0);
										}
									}
									bool flag46 = Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhVYlRsaFZqQTFlVlZHVG10aVZteFlaVWh3WVZVeVRUTmFSekZIWlZWc1NWcDZiR0ZTZW14eFdrWmplR0pIU25WVldGWnFWMFphYzFreU5YTldSbkJZWlVkNFdrMHhTakpaTW5SSFl6SktSRm95TlZwVk1rNTNWSHBLWVdSdFRuQmhTRUpSVmtWRk0xbFdValJPUlhoMFpVZDRhV0pYVVhkWlZWSXdZMFYwTldNelFteE5iWGgwVXpCb2IxbHRSbGROU0Zab1UwVndjMWR0YXpGalIwcDBWRzVPYTFZeFNuTlpNMnh1WW0xS1NGWnROVnBXTTJodFYxUkpOV1JYVFhsV2JsWnJVWHBzY0ZkV2FFOWpSbXcxVDBNNVdrMXFiREZaZWtwWFpGZFNSMDlZY0d0U01Wb3pWVVpTUm1KcmRGUmlSR1JzVW01U2QxZEdUVEZoYlVwSVlrZHdhR1ZYWkhkVWVrcExaVlp3V0ZKdVNsQk5helYyVjJ4a1QyTnNRbFJhUkVKcVlteGFjMU5xVFhoUFZXeEpVMjE0YTFOR1dqVlpiV3hEWVcxR1NGWnRjR2hrZWpBNQ=="))))))))));
									if (flag46)
									{
										for (int i = 0; i < 5; i++)
										{
											Common.DelayTime(2.0);
											bool flag47 = !Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhVYlRsaFZqQTFlVlZHVG10aVZteFlaVWh3WVZVeVRUTmFSekZIWlZWc1NWcDZiR0ZTZW14eFdrWmplR0pIU25WVldGWnFWMFphYzFreU5YTldSbkJZWlVkNFdrMHhTakpaTW5SSFl6SktSRm95TlZwVk1rNTNWSHBLWVdSdFRuQmhTRUpSVmtWRk0xbFdValJPUlhoMFpVZDRhV0pYVVhkWlZWSXdZMFYwTldNelFteE5iWGgwVXpCb2IxbHRSbGROU0Zab1UwVndjMWR0YXpGalIwcDBWRzVPYTFZeFNuTlpNMnh1WW0xS1NGWnROVnBXTTJodFYxUkpOV1JYVFhsV2JsWnJVWHBzY0ZkV2FFOWpSbXcxVDBNNVdrMXFiREZaZWtwWFpGZFNSMDlZY0d0U01Wb3pWVVpTUm1KcmRGUmlSR1JzVW01U2QxZEdUVEZoYlVwSVlrZHdhR1ZYWkhkVWVrcExaVlp3V0ZKdVNsQk5helYyVjJ4a1QyTnNRbFJhUkVKcVlteGFjMU5xVFhoUFZXeEpVMjE0YTFOR1dqVlpiV3hEWVcxR1NGWnRjR2hrZWpBNQ=="))))))))));
											if (flag47)
											{
												break;
											}
										}
										for (int j = 0; j < 5; j++)
										{
											Common.DelayTime(2.0);
											bool flag48 = !Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhVYlRsaFZqQTFlVlZHVG10aVZteFlaVWh3WVZVeVRUTmFSekZIWlZWc1NWcDZiR0ZTZW14eFdrWmplR0pIU25WVldGWnFWMFphYzFreU5YTldSbkJZWlVkNFdrMHhTakpaTW5SSFl6SktSRm95TlZwVk1rNTNWSHBLWVdSdFRuQmhTRUpSVmtWRk0xbFdValJPUlhoMFpVZDRhV0pYVVhkWlZWSXdZMFYwTldNelFteE5iWGgwVXpCb2IxbHRSbGROU0Zab1UwVndjMWR0YXpGalIwcDBWRzVPYTFZeFNuTlpNMnh1WW14cmVVOVlWbXBOYkZveFdrVk5OV0ZXYkZsVWJrSmFaVlJzZWxscVNtcGlhM1JVWWtSa2JGSnVVbmRYUmsweFlXMUtTR0pIY0dobFYyUjNWSHBLUzJWV2NGaFNia3BRVFdzMWRsZHNaRTlqYkVKVVdrUkNhbUpzV25OVGFrMTRUMVZzU1ZOdGVHdFRSbG8xV1cxc1EyRnRSa2hXYlhCb1pIb3dPUT09"))))))))));
											if (flag48)
											{
												break;
											}
										}
										bool flag49 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkbGxxU1hoaVJYaDFVVzA1YWxFd2NHcz0=")))))))), 0.0) == 1;
										if (flag49)
										{
											chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkbGxxU1hoaVJYaDFVVzA1YWxFd2NHcz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
										}
									}
									for (;;)
									{
										bool flag50 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlUbUZXTWxKdldXdFpOV0Z0U1hsT1dIQmhWbnBWZHc9PQ==")))))))));
										if (!flag50)
										{
											break;
										}
										int num12 = Convert.ToInt32(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VqRktNbGRVVGxka1JuQllUbFJDVFdKcldYaFhiR2hMVGxaVmVWWnVUbUZXTURSM1dXcE9TMUZ0U2toa01qbExUV3R2ZUZwRmFGTmtiVXB3V1ROQ1RXSllhSE5aYlRGclRVZEdRbEJVTUQwPQ=="))))))))).ToString());
										bool flag51 = num12 == 3;
										if (flag51)
										{
											chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZVOQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
										}
										else
										{
											bool flag52 = num12 == 4;
											if (flag52)
											{
												chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZVOQ==")))))))), 1, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
											}
										}
										chrome.DelayTime(2.0);
									}
									bool flag53 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR2hWZW14dlYxUk9VMlJ0VG5OUFYzaHNVMFZLYzFreU1YTmlSMHAwVkcxNFRVMXJXbkZhUldNMVpWWm5lVnBIYUd0U01WbDZWMVpvY2xCUlBUMD0=")))))))));
									if (flag53)
									{
										bool flag54 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcFlteEZOVk5YY3pGV1ZUbHlZa1UxVWxaWFVrZFRWM2QzVUZFOVBRPT0=")))))))), 15.0) == 1;
										if (flag54)
										{
											chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYkVwdldrVmtSbVJIU25WVlZHeEtZWHBXVmxReWRITlViRVpXV2tWYVNtSkVRblZUTVUweFlXMUtTR0pIY0dobFYyUjM=")))))))));
											chrome.DelayTime(2.0);
										}
									}
									bool flag55 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaWVRURndiMWxyYUZkaVJrSlVVMnhDVkdWVmNHcz0=")))))))), 0.0) == 1;
									if (flag55)
									{
										chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaWVRURndiMWxyYUZkaVJrSlVVMnhDVkdWVmNHcz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
										chrome.DelayTime(1.0);
									}
									bool flag56 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRURktNbGt5TVZaa1IwWllWVlJzU21GcmJIQlhSbEV4WlcxT1NGSnVWVDA9")))))))), 0.0) == 1;
									if (flag56)
									{
										chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRURktNbGt5TVZaa1IwWllWVlJzU21GcmJIQlhSbEV4WlcxT1NGSnVWVDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
										chrome.DelayTime(1.0);
									}
									bool flag57 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcFlteEZOVk5YZEdGUk1EbHlZVVZhVWxaV1NrZFdWM2MxVWpGUmQwOVdWbE5XYTNCdFZtMTBjMUpzV2pWVGJWSlJZbFpLZDFwSGJ6RmhNa1paVjFOMFlWSXlkM2xWUnpWUFpERnNXRTVEZEdwTk1FcHZXVzFqT1ZCUlBUMD0=")))))))), 0.0) == 1;
									if (flag57)
									{
										chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcFlteEZOVk5YZEdGUk1EbHlZVVZhVWxaV1NrZFdWM2MxVWpGUmQwOVdWbE5XYTNCdFZtMTBjMUpzV2pWVGJWSlJZbFpLZDFwSGJ6RmhNa1paVjFOMFlWSXlkM2xWUnpWUFpERnNXRTVEZEdwTk1FcHZXVzFqT1ZCUlBUMD0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
										chrome.DelayTime(3.0);
									}
								}
								else
								{
									bool flag58 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYm1oelYycEtSMk14WjNsVWJscHBZbXMxYzFsdE5WSlFVVDA5")))))))));
									if (flag58)
									{
										for (int k = 0; k < 5; k++)
										{
											bool flag59 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZVOQ==")))))))), 0.0) != 1;
											if (flag59)
											{
												break;
											}
											chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpYkZsM1drVmpOV1JWY0RWaE0xWmFUVzVvZDFkVVNucGlNSFJTVUZRd1BRPT0=")))))))));
											chrome.DelayTime(1.0);
										}
									}
								}
							}
							bool flag60 = CommonChrome.CheckLoginSuccess(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
							if (flag60)
							{
								num = 1;
							}
							break;
						}
						}
						if (num != 0)
						{
							goto IL_37D1;
						}
					}
					IL_26CA:
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVVDA9")))))))));
					chrome.DelayTime(1.0);
				}
				num = 2;
				goto IL_383D;
				Block_24:
				num = -2;
				Block_25:
				goto IL_37D1;
				Block_32:
				return text;
				Block_38:
				num = 0;
				goto IL_383D;
				Block_40:
				num = 6;
				goto IL_383D;
				Block_41:
				num = 6;
				goto IL_383D;
				Block_43:
				num = 2;
				Block_44:
				goto IL_383D;
				Block_48:
				num = 2;
				Block_49:
				goto IL_383D;
				Block_52:
				num = 1;
				goto IL_383D;
				Block_53:
				num = 2;
				IL_37D1:;
			}
			catch (Exception ex)
			{
				Common.ExportError(chrome, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4b1MyVlhTWHBUVjJSVlVucHNkVmxXWXpCYU1WcFlZa2QwU2xKclNtOVplazVPVUZFOVBRPT0=")))))))));
			}
			IL_383D:
			return num.ToString() ?? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000260A8 File Offset: 0x000242A8
		public static string GetInfoAccountFromUidUsingCookie(Chrome chrome)
		{
			object[] parameters = new object[]
			{
				chrome
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(326928, 10704, 332, parameters);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000260F0 File Offset: 0x000242F0
		public static string GetInfoAccountFromUidUsingToken(Chrome chrome, string token)
		{
			object[] parameters = new object[]
			{
				chrome,
				token
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(337632, 2832, 333, parameters);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00026148 File Offset: 0x00024348
		public static string GetTokenEAAAAZ(Chrome chrome)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				string input = CommonChrome.RequestGet(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhjR2xOYWtZeldXcE9UMkpIVG5CUFdGcGFUV3hhZWxscVRsSmtiR3haVkdwV2FXSlZOVzFaYTJNMVlVWndTRlp1YkUxbGFtd3pXa1prUzJNeVJsbFViVGxoVjBWck5WZHRNVmRpUm5CQ1VGUXdQUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9")))))))));
				result = Regex.Match(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4V1IxRnNSbFpTYlVaTVVYcFNlRlZJYkhKaFVUMDk="))))))))).Value.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000263E0 File Offset: 0x000245E0
		public static int CheckLiveCookie(Chrome chrome, string url = "https://m.facebook.com")
		{
			try
			{
				bool flag = chrome.CheckChromeClosed();
				if (flag)
				{
					return -2;
				}
				bool flag2 = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) != CommonChrome.CheckTypeWebFacebookFromUrl(url);
				if (flag2)
				{
					chrome.GotoURL(url);
				}
				string url2 = chrome.GetURL();
				bool flag3 = url2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDVWRzA1WVZZd05YbFpNR00xWTBkS2RWVllXVDA9"))))))))) || url2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDVUbFJDVFUwd05YRlpNakZYWWtkS2NFOURPV3BTTUZvMVYxWmplR1ZzUWxSV1ZFNVNZVlpXTlZSWE5WTmtiVVY1Vm01VlBRPT0="))))))))) || url2.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDZXak5hV2sxdGFITlhWRW93WkRKSmVXSklWbXRSZW1jNQ==")))))))));
				if (flag3)
				{
					return 2;
				}
				int num = CommonChrome.CheckFacebookWebsite(chrome, url);
				bool flag4 = num == 2;
				if (flag4)
				{
					bool flag5 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaYU1HSXlUblJXYlRGTVlXcENjRlJFVG5kaVIwNTBUMGhhYVUwd1NYZFpWbU13WkcxUmVsTnVRbXRTTVZZeVZVUktSMkZ0VWtoaVNGcHBZV3BHY1ZkV1l6RmhiSEJZWkRJeGFsSXdXblZYYkZGNFlUSkdXRkp1VG10U2Vtd3hWMnhaTldSdFRrbFZia0pwWWtSc00xZFdaR3RpUld4elRVUXdQUT09")))))))), 5.0) == 1;
					if (flag5)
					{
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBXYmxKMldUSXhWMkpWZEhGTlIyeE5UVE5DYzFreU1EUmtiVWw2VVdwQ2FGWjZVakphUkU1TFkwZFNTRlpZV2xGTmExcHhXa1ZrYzJSdFNuRk5WM0JhVm5wV2NWZHNaRE5pVjA1SVVtMDFZVlpFUm5KWlZtUkhZekpTU0U5WVZtRldhbXd5V1RCb1UyTkhTbk5QV0dSYVZqSlNjMU5YZDNkaWEzUlVUbGR3YVZJeWVIRlpXR3h1WTBFOVBRPT0=")))))))));
						chrome.DelayTime(3.0);
						bool flag6 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1IyRnRVa2hpU0ZwcFlXcENjRlJFVG5kaVIwNTBUMGhhYVUwd1NYZFpWbU13WkcxUmVsTnVRbXRTTVZZeVZVUktSMkZ0VWtoaVNGcHBZV3BHY1ZscVNURmlWMFpaVTI1U1MySnJTbTlYYWtwV1QxZE9kRlp0Y0dsTmFsWTJXVlprVTJKSFRuTlBXRnBxVTBaS2QxbHRkelZoTWtaWVVtNU9hVTF0VG5CWFJrNURZVmRTV1ZWcVFtbE5hbEU1")))))))), 10.0) == 1;
						if (flag6)
						{
							chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYTFweFdrVmtjMlJ0U25GTlIyeE5UVE5DYzFreU1EUmtiVWw2VVdwQ2FGWjZVakphUkU1TFkwZFNTRlpZV2xGTmExcHhXa1ZrYzJSdFNuRk5WM0JwVFdwV2RGbFdhRXRrUlhCMVVXMW9ZVTFzVlRWWk1qRlhZVzFKZVU1WWNHaFdNVXB6V1RKM05XUnRUa2xWYmtKcFlrUnNjbGxXWkVkak1rbDVXVEpzV1ZVd1NuQmFSbWhUVFVkSmVVNUhOVXhWZWxaeFdXdGtjMkZ0UmpWYU0wRTk=")))))))));
							chrome.DelayTime(3.0);
						}
					}
					bool flag7 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVVXbUZYUlhBeVZFUkpOV1F5VWtoaVNGWk5UVEpTTlZsV2FGTmlSWGd6VUZRd1BRPT0=")))))))));
					if (flag7)
					{
						chrome.DelayTime(1.0);
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYTFweFdrVmtjMlJ0U25GTlIyeE5UVE5DYzFreU1EUmtiVWw2VVdwQ2FGWjZVakphUkU1TFkwZFNTRlpZV2xGTmExcHhXa1ZrYzJSdFNuRk5WM0JwVFdwV2RGbFdhRXRrUlhCMVVXMW9ZVTFzVlRWWk1qRlhZVzFKZVU1WWNHaFdNVXB6V1RKM05XUnRUa2xWYmtKcFlrUnNjbGxXWkVkak1rbDVXVEpzV1ZVd1NuQmFSbWhUVFVkSmVVNUhOVXhWZWxaeFdXdGtjMkZ0UmpWYU0wRTk=")))))))));
						chrome.DelayTime(3.0);
					}
					bool flag8 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVVXbUZYUlhBeVZFUk9RMlJ0U2toaVIzQnNWWHBzTWxrd2FGTmpSMHB1VUZRd1BRPT0=")))))))));
					if (flag8)
					{
						chrome.DelayTime(1.0);
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBXYmxKeVYxWm9VMkZGZUZsVWJrSmhUVzE0ZWxWR1RrdE5SMGw2Vm0xd2FGSXdXbkJaYTJSV1lWWm9WRmt6UWsxaVZUVjZXVlprVDJOcmRFUmhlakE5")))))))));
						chrome.DelayTime(3.0);
						bool flag9 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaWVRXeEtiMXBGWkVaa1IwMTVZa2MxYUZZell6VlRWelZUWkcxU1dGUnRPVnBXTUhCNlYyeE9TMXBCUFQwPQ==")))))))), 10.0) == 1;
						if (flag9)
						{
							chrome.DelayTime(1.0);
							chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpYkZsM1drVmpOV1JXWTNsVmJXaHJVakJXTUZsNlNuTmliVVpZWkhwc1NtSnNTakphUm1SUFlqRnNXRk51VG1GVk1IQnJVMjVzY21SV2EzbGxTRUphVFc1T2RsTXhSVGxRVVQwOQ==")))))))));
							chrome.DelayTime(3.0);
						}
					}
					bool flag10 = Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhVYlRsaFZqQTFlVlZHVG10aVZteFlaVWh3WVZVeVRUTmFSekZIWlZWc1NWcDZiR0ZTZW14eFdrWmplR0pIU25WVldGWnFWMFphYzFreU5YTldSbkJZWlVkNFdrMHhTakpaTW5SSFl6SktSRm95TlZwVk1rNTNWSHBLWVdSdFRuQmhTRUpSVmtWRk0xbFdValJPUlhoMFpVZDRhV0pYVVhkWlZWSXdZMFYwTldNelFteE5iWGgwVXpCb2IxbHRSbGROU0Zab1UwVndjMWR0YXpGalIwcDBWRzVPYTFZeFNuTlpNMnh1WW0xS1NGWnROVnBXTTJodFYxUkpOV1JYVFhsV2JsWnJVWHBzY0ZkV2FFOWpSbXcxVDBNNVdrMXFiREZaZWtwWFpGZFNSMDlZY0d0U01Wb3pWVVpTUm1KcmRGUmlSR1JzVW01U2QxZEdUVEZoYlVwSVlrZHdhR1ZYWkhkVWVrcExaVlp3V0ZKdVNsQk5helYyVjJ4a1QyTnNRbFJhUkVKcVlteGFjMU5xVFhoUFZXeEpVMjE0YTFOR1dqVlpiV3hEWVcxR1NGWnRjR2hrZWpBNQ=="))))))))));
					if (flag10)
					{
						for (int i = 0; i < 5; i++)
						{
							Common.DelayTime(2.0);
							bool flag11 = !Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhVYlRsaFZqQTFlVlZHVG10aVZteFlaVWh3WVZVeVRUTmFSekZIWlZWc1NWcDZiR0ZTZW14eFdrWmplR0pIU25WVldGWnFWMFphYzFreU5YTldSbkJZWlVkNFdrMHhTakpaTW5SSFl6SktSRm95TlZwVk1rNTNWSHBLWVdSdFRuQmhTRUpSVmtWRk0xbFdValJPUlhoMFpVZDRhV0pYVVhkWlZWSXdZMFYwTldNelFteE5iWGgwVXpCb2IxbHRSbGROU0Zab1UwVndjMWR0YXpGalIwcDBWRzVPYTFZeFNuTlpNMnh1WW0xS1NGWnROVnBXTTJodFYxUkpOV1JYVFhsV2JsWnJVWHBzY0ZkV2FFOWpSbXcxVDBNNVdrMXFiREZaZWtwWFpGZFNSMDlZY0d0U01Wb3pWVVpTUm1KcmRGUmlSR1JzVW01U2QxZEdUVEZoYlVwSVlrZHdhR1ZYWkhkVWVrcExaVlp3V0ZKdVNsQk5helYyVjJ4a1QyTnNRbFJhUkVKcVlteGFjMU5xVFhoUFZXeEpVMjE0YTFOR1dqVlpiV3hEWVcxR1NGWnRjR2hrZWpBNQ=="))))))))));
							if (flag11)
							{
								break;
							}
						}
						for (int j = 0; j < 5; j++)
						{
							Common.DelayTime(2.0);
							bool flag12 = !Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhVYlRsaFZqQTFlVlZHVG10aVZteFlaVWh3WVZVeVRUTmFSekZIWlZWc1NWcDZiR0ZTZW14eFdrWmplR0pIU25WVldGWnFWMFphYzFreU5YTldSbkJZWlVkNFdrMHhTakpaTW5SSFl6SktSRm95TlZwVk1rNTNWSHBLWVdSdFRuQmhTRUpSVmtWRk0xbFdValJPUlhoMFpVZDRhV0pYVVhkWlZWSXdZMFYwTldNelFteE5iWGgwVXpCb2IxbHRSbGROU0Zab1UwVndjMWR0YXpGalIwcDBWRzVPYTFZeFNuTlpNMnh1WW14cmVVOVlWbXBOYkZveFdrVk5OV0ZXYkZsVWJrSmFaVlJzZWxscVNtcGlhM1JVWWtSa2JGSnVVbmRYUmsweFlXMUtTR0pIY0dobFYyUjNWSHBLUzJWV2NGaFNia3BRVFdzMWRsZHNaRTlqYkVKVVdrUkNhbUpzV25OVGFrMTRUMVZzU1ZOdGVHdFRSbG8xV1cxc1EyRnRSa2hXYlhCb1pIb3dPUT09"))))))))));
							if (flag12)
							{
								break;
							}
						}
						bool flag13 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkbGxxU1hoaVJYaDFVVzA1YWxFd2NHcz0=")))))))), 0.0) == 1;
						if (flag13)
						{
							chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkbGxxU1hoaVJYaDFVVzA1YWxFd2NHcz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						}
					}
					bool flag14 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlUbUZXTWxKdldXdFpOV0Z0U1hsT1dIQmhWbnBWZHc9PQ==")))))))));
					if (flag14)
					{
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpYkZsM1drVmpOV1JWY0RWaE0xWmFUVzVvZDFkVVNucGlNSFJTVUZRd1BRPT0=")))))))));
						chrome.DelayTime(1.0);
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NsSnVUbWxSTW1SMVYxYzFWMDFIVWtoUFdGWkxaVmQ0YVZSV1dYZGtWbXQ1WlVoQ1drMXVUblpUTVVVNVVGRTlQUT09")))))))));
						chrome.DelayTime(1.0);
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpYkZsM1drVmpOV1JWY0RWaE0xWmFUVzVvZDFkVVNucGlNSFJTVUZRd1BRPT0=")))))))));
						chrome.DelayTime(1.0);
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NsSnVUbWxSTW1SMVYxYzFWMDFIVWtoUFdGWkxaVmQ0YVZSV1dYZGtWbXQ1WlVoQ1drMXVUblpUTVVVNVVGRTlQUT09")))))))));
						chrome.DelayTime(1.0);
					}
					bool flag15 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR2hWZW14dlYxUk9VMlJ0VG5OUFYzaHNVMFZLYzFreU1YTmlSMHAwVkcxNFRVMXJXbkZhUldNMVpWWm5lVnBIYUd0U01WbDZWMVpvY2xCUlBUMD0=")))))))));
					if (flag15)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFWVzVhYTFZd05YWlhWbVJMWXpGd1ZGTnRVVDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag16 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaWVRURndiMWxyYUZkaVJrSlVVMnhDVkdWVmNHcz0=")))))))), 0.0) == 1;
					if (flag16)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaWVRURndiMWxyYUZkaVJrSlVVMnhDVkdWVmNHcz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag17 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRURktNbGt5TVZaa1IwWllWVlJzU21GcmJIQlhSbEV4WlcxT1NGSnVWVDA9")))))))), 0.0) == 1;
					if (flag17)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRURktNbGt5TVZaa1IwWllWVlJzU21GcmJIQlhSbEV4WlcxT1NGSnVWVDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag18 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcFlteEZOVk5YZEdGUk1EbHlZVVZhVWxaV1NrZFdWM2MxVWpGUmQwOVdWbE5XYTNCdFZtMTBjMUpzV2pWVGJWSlJZbFpLZDFwSGJ6RmhNa1paVjFOMFlWSXlkM2xWUnpWUFpERnNXRTVEZEdwTk1FcHZXVzFqT1ZCUlBUMD0=")))))))), 0.0) == 1;
					if (flag18)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcFlteEZOVk5YZEdGUk1EbHlZVVZhVWxaV1NrZFdWM2MxVWpGUmQwOVdWbE5XYTNCdFZtMTBjMUpzV2pWVGJWSlJZbFpLZDFwSGJ6RmhNa1paVjFOMFlWSXlkM2xWUnpWUFpERnNXRTVEZEdwTk1FcHZXVzFqT1ZCUlBUMD0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(3.0);
					}
					bool flag19 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa1JOV0ZaYVYwWnNNRmRYTlZkTlIxSklUMWhWUFE9PQ==")))))))), 0.0) == 1;
					if (flag19)
					{
						bool flag20 = false;
						for (int k = 0; k < 5; k++)
						{
							bool flag21 = flag20;
							if (flag21)
							{
								break;
							}
							int num2 = chrome.CheckExistElements(3.0, new string[]
							{
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFST1IySldaM3BVYmtwb1YwVktiVmRyWkhOaFIwcElUMWMxV1Uwd05YbFpWbWhEV20xS1NHSklWbWhrZWpBNQ==")))))))),
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSSk1VMVhWa1JOV0ZaYVYwWnNNRmRYTlZkTlIxSklUMWhWUFE9PQ=="))))))))
							});
							int num3 = num2;
							int num4 = num3;
							if (num4 != 1)
							{
								if (num4 != 2)
								{
									flag20 = true;
								}
								else
								{
									chrome.Click(1, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYwNUZlRmhPVjJocllWUkdjRnBHYUZOTlIwbDVUa1F3UFE9PQ==")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
									chrome.DelayTime(2.0);
								}
							}
							else
							{
								chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVXBOTUZwMFYwUk9UMk50UmxsUmJWcGhVako0YjFscll6VmliR2Q2Vkc1S2FGZEZTbTFaYTJSelpGZEdOVmt6UWsxaVZUVjZXVlprVDJOcmRFUmhlakE5")))))))));
								chrome.DelayTime(1.0);
							}
						}
					}
				}
				else
				{
					bool flag22 = num == 1;
					if (flag22)
					{
						bool flag23 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYm1oelYycEtSMk14WjNsVWJscHBZbXMxYzFsdE5WSlFVVDA5")))))))));
						if (flag23)
						{
							for (int l = 0; l < 5; l++)
							{
								bool flag24 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZVOQ==")))))))), 0.0) != 1;
								if (flag24)
								{
									break;
								}
								chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpYkZsM1drVmpOV1JWY0RWaE0xWmFUVzVvZDFkVVNucGlNSFJTVUZRd1BRPT0=")))))))));
								chrome.DelayTime(1.0);
							}
						}
					}
				}
				CommonChrome.CheckStatusAccount(chrome, true);
				switch (chrome.Status)
				{
				case StatusChromeAccount.ChromeClosed:
					return -2;
				case StatusChromeAccount.LoginWithUserPass:
				case StatusChromeAccount.LoginWithSelectAccount:
					return 0;
				case StatusChromeAccount.Checkpoint:
					return 2;
				case StatusChromeAccount.Logined:
					return 1;
				case StatusChromeAccount.NoInternet:
					return -3;
				case StatusChromeAccount.Noveri:
					return 3;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00027850 File Offset: 0x00025A50
		public static int CheckLiveCookieWhenGiaiCP(Chrome chrome, string url = "https://m.facebook.com")
		{
			try
			{
				bool flag = chrome.CheckChromeClosed();
				if (flag)
				{
					return -2;
				}
				bool flag2 = chrome.GetURL().Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVVVazFOYXpWMlYyeGtUMk50VGtoUFdFSnBZbXhHTWxsVlpFZGhiVVY1Vm0xMFdVMXJOWHBYYkdSSFpGZFNXVkZVTUQwPQ=="))))))))) || chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOUk1sSlpWV3BDYVUxcVZrbFhiR2hUVmtkU1NGSnViR3RTTVZweQ==")))))))), 0.0) == 1;
				if (flag2)
				{
					return 1;
				}
				bool flag3 = CommonChrome.CheckTypeWebFacebookFromUrl(chrome.GetURL()) == 0;
				if (flag3)
				{
					chrome.GotoURL(url);
				}
				int num = CommonChrome.CheckFacebookWebsite(chrome, url);
				bool flag4 = num == 2;
				if (flag4)
				{
					bool flag5 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaYU1HSXlUblJXYlRGTVlXcENjRlJFVG5kaVIwNTBUMGhhYVUwd1NYZFpWbU13WkcxUmVsTnVRbXRTTVZZeVZVUktSMkZ0VWtoaVNGcHBZV3BHY1ZkV1l6RmhiSEJZWkRJeGFsSXdXblZYYkZGNFlUSkdXRkp1VG10U2Vtd3hWMnhaTldSdFRrbFZia0pwWWtSc00xZFdaR3RpUld4elRVUXdQUT09")))))))), 5.0) == 1;
					if (flag5)
					{
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBXYmxKMldUSXhWMkpWZEhGTlIyeE5UVE5DYzFreU1EUmtiVWw2VVdwQ2FGWjZVakphUkU1TFkwZFNTRlpZV2xGTmExcHhXa1ZrYzJSdFNuRk5WM0JhVm5wV2NWZHNaRE5pVjA1SVVtMDFZVlpFUm5KWlZtUkhZekpTU0U5WVZtRldhbXd5V1RCb1UyTkhTbk5QV0dSYVZqSlNjMU5YZDNkaWEzUlVUbGR3YVZJeWVIRlpXR3h1WTBFOVBRPT0=")))))))));
						chrome.DelayTime(3.0);
						bool flag6 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1IyRnRVa2hpU0ZwcFlXcENjRlJFVG5kaVIwNTBUMGhhYVUwd1NYZFpWbU13WkcxUmVsTnVRbXRTTVZZeVZVUktSMkZ0VWtoaVNGcHBZV3BHY1ZscVNURmlWMFpaVTI1U1MySnJTbTlYYWtwV1QxZE9kRlp0Y0dsTmFsWTJXVlprVTJKSFRuTlBXRnBxVTBaS2QxbHRkelZoTWtaWVVtNU9hVTF0VG5CWFJrNURZVmRTV1ZWcVFtbE5hbEU1")))))))), 10.0) == 1;
						if (flag6)
						{
							chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYTFweFdrVmtjMlJ0U25GTlIyeE5UVE5DYzFreU1EUmtiVWw2VVdwQ2FGWjZVakphUkU1TFkwZFNTRlpZV2xGTmExcHhXa1ZrYzJSdFNuRk5WM0JwVFdwV2RGbFdhRXRrUlhCMVVXMW9ZVTFzVlRWWk1qRlhZVzFKZVU1WWNHaFdNVXB6V1RKM05XUnRUa2xWYmtKcFlrUnNjbGxXWkVkak1rbDVXVEpzV1ZVd1NuQmFSbWhUVFVkSmVVNUhOVXhWZWxaeFdXdGtjMkZ0UmpWYU0wRTk=")))))))));
							chrome.DelayTime(3.0);
						}
					}
					bool flag7 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVVXbUZYUlhBeVZFUkpOV1F5VWtoaVNGWk5UVEpTTlZsV2FGTmlSWGd6VUZRd1BRPT0=")))))))));
					if (flag7)
					{
						chrome.DelayTime(1.0);
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVmhOYTFweFdrVmtjMlJ0U25GTlIyeE5UVE5DYzFreU1EUmtiVWw2VVdwQ2FGWjZVakphUkU1TFkwZFNTRlpZV2xGTmExcHhXa1ZrYzJSdFNuRk5WM0JwVFdwV2RGbFdhRXRrUlhCMVVXMW9ZVTFzVlRWWk1qRlhZVzFKZVU1WWNHaFdNVXB6V1RKM05XUnRUa2xWYmtKcFlrUnNjbGxXWkVkak1rbDVXVEpzV1ZVd1NuQmFSbWhUVFVkSmVVNUhOVXhWZWxaeFdXdGtjMkZ0UmpWYU0wRTk=")))))))));
						chrome.DelayTime(3.0);
					}
					bool flag8 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVVXbUZYUlhBeVZFUk9RMlJ0U2toaVIzQnNWWHBzTWxrd2FGTmpSMHB1VUZRd1BRPT0=")))))))));
					if (flag8)
					{
						chrome.DelayTime(1.0);
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBXYmxKeVYxWm9VMkZGZUZsVWJrSmhUVzE0ZWxWR1RrdE5SMGw2Vm0xd2FGSXdXbkJaYTJSV1lWWm9WRmt6UWsxaVZUVjZXVlprVDJOcmRFUmhlakE5")))))))));
						chrome.DelayTime(3.0);
						bool flag9 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaWVRXeEtiMXBGWkVaa1IwMTVZa2MxYUZZell6VlRWelZUWkcxU1dGUnRPVnBXTUhCNlYyeE9TMXBCUFQwPQ==")))))))), 10.0) == 1;
						if (flag9)
						{
							chrome.DelayTime(1.0);
							chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpYkZsM1drVmpOV1JXWTNsVmJXaHJVakJXTUZsNlNuTmliVVpZWkhwc1NtSnNTakphUm1SUFlqRnNXRk51VG1GVk1IQnJVMjVzY21SV2EzbGxTRUphVFc1T2RsTXhSVGxRVVQwOQ==")))))))));
							chrome.DelayTime(3.0);
						}
					}
					bool flag10 = Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhVYlRsaFZqQTFlVlZHVG10aVZteFlaVWh3WVZVeVRUTmFSekZIWlZWc1NWcDZiR0ZTZW14eFdrWmplR0pIU25WVldGWnFWMFphYzFreU5YTldSbkJZWlVkNFdrMHhTakpaTW5SSFl6SktSRm95TlZwVk1rNTNWSHBLWVdSdFRuQmhTRUpSVmtWRk0xbFdValJPUlhoMFpVZDRhV0pYVVhkWlZWSXdZMFYwTldNelFteE5iWGgwVXpCb2IxbHRSbGROU0Zab1UwVndjMWR0YXpGalIwcDBWRzVPYTFZeFNuTlpNMnh1WW0xS1NGWnROVnBXTTJodFYxUkpOV1JYVFhsV2JsWnJVWHBzY0ZkV2FFOWpSbXcxVDBNNVdrMXFiREZaZWtwWFpGZFNSMDlZY0d0U01Wb3pWVVpTUm1KcmRGUmlSR1JzVW01U2QxZEdUVEZoYlVwSVlrZHdhR1ZYWkhkVWVrcExaVlp3V0ZKdVNsQk5helYyVjJ4a1QyTnNRbFJhUkVKcVlteGFjMU5xVFhoUFZXeEpVMjE0YTFOR1dqVlpiV3hEWVcxR1NGWnRjR2hrZWpBNQ=="))))))))));
					if (flag10)
					{
						for (int i = 0; i < 5; i++)
						{
							Common.DelayTime(2.0);
							bool flag11 = !Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhVYlRsaFZqQTFlVlZHVG10aVZteFlaVWh3WVZVeVRUTmFSekZIWlZWc1NWcDZiR0ZTZW14eFdrWmplR0pIU25WVldGWnFWMFphYzFreU5YTldSbkJZWlVkNFdrMHhTakpaTW5SSFl6SktSRm95TlZwVk1rNTNWSHBLWVdSdFRuQmhTRUpSVmtWRk0xbFdValJPUlhoMFpVZDRhV0pYVVhkWlZWSXdZMFYwTldNelFteE5iWGgwVXpCb2IxbHRSbGROU0Zab1UwVndjMWR0YXpGalIwcDBWRzVPYTFZeFNuTlpNMnh1WW0xS1NGWnROVnBXTTJodFYxUkpOV1JYVFhsV2JsWnJVWHBzY0ZkV2FFOWpSbXcxVDBNNVdrMXFiREZaZWtwWFpGZFNSMDlZY0d0U01Wb3pWVVpTUm1KcmRGUmlSR1JzVW01U2QxZEdUVEZoYlVwSVlrZHdhR1ZYWkhkVWVrcExaVlp3V0ZKdVNsQk5helYyVjJ4a1QyTnNRbFJhUkVKcVlteGFjMU5xVFhoUFZXeEpVMjE0YTFOR1dqVlpiV3hEWVcxR1NGWnRjR2hrZWpBNQ=="))))))))));
							if (flag11)
							{
								break;
							}
						}
						for (int j = 0; j < 5; j++)
						{
							Common.DelayTime(2.0);
							bool flag12 = !Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhVYlRsaFZqQTFlVlZHVG10aVZteFlaVWh3WVZVeVRUTmFSekZIWlZWc1NWcDZiR0ZTZW14eFdrWmplR0pIU25WVldGWnFWMFphYzFreU5YTldSbkJZWlVkNFdrMHhTakpaTW5SSFl6SktSRm95TlZwVk1rNTNWSHBLWVdSdFRuQmhTRUpSVmtWRk0xbFdValJPUlhoMFpVZDRhV0pYVVhkWlZWSXdZMFYwTldNelFteE5iWGgwVXpCb2IxbHRSbGROU0Zab1UwVndjMWR0YXpGalIwcDBWRzVPYTFZeFNuTlpNMnh1WW14cmVVOVlWbXBOYkZveFdrVk5OV0ZXYkZsVWJrSmFaVlJzZWxscVNtcGlhM1JVWWtSa2JGSnVVbmRYUmsweFlXMUtTR0pIY0dobFYyUjNWSHBLUzJWV2NGaFNia3BRVFdzMWRsZHNaRTlqYkVKVVdrUkNhbUpzV25OVGFrMTRUMVZzU1ZOdGVHdFRSbG8xV1cxc1EyRnRSa2hXYlhCb1pIb3dPUT09"))))))))));
							if (flag12)
							{
								break;
							}
						}
						bool flag13 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkbGxxU1hoaVJYaDFVVzA1YWxFd2NHcz0=")))))))), 0.0) == 1;
						if (flag13)
						{
							chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lWUnNkbGxxU1hoaVJYaDFVVzA1YWxFd2NHcz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						}
					}
					bool flag14 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVlUbUZXTWxKdldXdFpOV0Z0U1hsT1dIQmhWbnBWZHc9PQ==")))))))));
					if (flag14)
					{
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpYkZsM1drVmpOV1JWY0RWaE0xWmFUVzVvZDFkVVNucGlNSFJTVUZRd1BRPT0=")))))))));
						chrome.DelayTime(1.0);
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NsSnVUbWxSTW1SMVYxYzFWMDFIVWtoUFdGWkxaVmQ0YVZSV1dYZGtWbXQ1WlVoQ1drMXVUblpUTVVVNVVGRTlQUT09")))))))));
						chrome.DelayTime(1.0);
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpYkZsM1drVmpOV1JWY0RWaE0xWmFUVzVvZDFkVVNucGlNSFJTVUZRd1BRPT0=")))))))));
						chrome.DelayTime(1.0);
						chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NsSnVUbWxSTW1SMVYxYzFWMDFIVWtoUFdGWkxaVmQ0YVZSV1dYZGtWbXQ1WlVoQ1drMXVUblpUTVVVNVVGRTlQUT09")))))))));
						chrome.DelayTime(1.0);
					}
					bool flag15 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVljR2hWZW14dlYxUk9VMlJ0VG5OUFYzaHNVMFZLYzFreU1YTmlSMHAwVkcxNFRVMXJXbkZhUldNMVpWWm5lVnBIYUd0U01WbDZWMVpvY2xCUlBUMD0=")))))))));
					if (flag15)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFWVzVhYTFZd05YWlhWbVJMWXpGd1ZGTnRVVDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag16 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaWVRURndiMWxyYUZkaVJrSlVVMnhDVkdWVmNHcz0=")))))))), 0.0) == 1;
					if (flag16)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZaWVRURndiMWxyYUZkaVJrSlVVMnhDVkdWVmNHcz0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag17 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRURktNbGt5TVZaa1IwWllWVlJzU21GcmJIQlhSbEV4WlcxT1NGSnVWVDA9")))))))), 0.0) == 1;
					if (flag17)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRURktNbGt5TVZaa1IwWllWVlJzU21GcmJIQlhSbEV4WlcxT1NGSnVWVDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(1.0);
					}
					bool flag18 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcFlteEZOVk5YZEdGUk1EbHlZVVZhVWxaV1NrZFdWM2MxVWpGUmQwOVdWbE5XYTNCdFZtMTBjMUpzV2pWVGJWSlJZbFpLZDFwSGJ6RmhNa1paVjFOMFlWSXlkM2xWUnpWUFpERnNXRTVEZEdwTk1FcHZXVzFqT1ZCUlBUMD0=")))))))), 0.0) == 1;
					if (flag18)
					{
						chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcFlteEZOVk5YZEdGUk1EbHlZVVZhVWxaV1NrZFdWM2MxVWpGUmQwOVdWbE5XYTNCdFZtMTBjMUpzV2pWVGJWSlJZbFpLZDFwSGJ6RmhNa1paVjFOMFlWSXlkM2xWUnpWUFpERnNXRTVEZEdwTk1FcHZXVzFqT1ZCUlBUMD0=")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
						chrome.DelayTime(3.0);
					}
				}
				else
				{
					bool flag19 = num == 1;
					if (flag19)
					{
						bool flag20 = chrome.GetURL().StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYm1oelYycEtSMk14WjNsVWJscHBZbXMxYzFsdE5WSlFVVDA5")))))))));
						if (flag20)
						{
							for (int k = 0; k < 5; k++)
							{
								bool flag21 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjMVYwMUhVa2hQV0ZVOQ==")))))))), 0.0) != 1;
								if (flag21)
								{
									break;
								}
								chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpYkZsM1drVmpOV1JWY0RWaE0xWmFUVzVvZDFkVVNucGlNSFJTVUZRd1BRPT0=")))))))));
								chrome.DelayTime(1.0);
							}
						}
					}
				}
				CommonChrome.CheckStatusAccount(chrome, true);
				switch (chrome.Status)
				{
				case StatusChromeAccount.ChromeClosed:
					return -2;
				case StatusChromeAccount.LoginWithUserPass:
				case StatusChromeAccount.LoginWithSelectAccount:
					return 0;
				case StatusChromeAccount.Checkpoint:
					return 2;
				case StatusChromeAccount.Logined:
					return 1;
				case StatusChromeAccount.NoInternet:
					return -3;
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00028994 File Offset: 0x00026B94
		public static bool IsCheckpoint(Chrome chrome)
		{
			try
			{
				bool flag = chrome.CheckExistElements(0.0, new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOV1IxSllVMjVTYUZkR1NrUmFSbWhUVFVkSmVVNUVNRDA9")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QyRkhUa2xWYlhCb1VqQmFiVmt5TVZkbGJVNUlUMWhXYWsxc1ZUaz0=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lteHdjMWt5TVhOaVYwWllWRzFvYTFJeWVESlpiWGMxWkVad1dWVnRPV2xOYkVad1YwWkZPVkJSUFQwPQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZOUk1rbDZWV3BDYVUxcVJrUlhWbWhLVUZFOVBRPT0=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVjJSUlZUQndkbHBGYUZOa01rNDJZak5hVFUweVVYcGFTR3N4WWxac1dGUnRlRnBpVkd3eVdWaHJNV0Z0U1hsTlNGcGFUV3BzTUZsc2FGZGtWMFpaVldwV2FrMHhTbTlaYlRGVFlVZE9kRlZ1Y0UxbFZYQnI="))))))))
				}) > 0;
				if (flag)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00028B98 File Offset: 0x00026D98
		public static bool IsCheckpointWhenLogin(Chrome chrome)
		{
			try
			{
				bool flag = chrome.CheckExistElements(0.0, new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVTFiMWt3YUZOaGJVWklVbTFhYW1KV1dqWlpNR00xWkZkTmVWWlhiRmxWVkRBNQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QyRkhUa2xWYlhCb1VqQmFiVmt5TVZkbGJVNUlUMWhXYWsxc1ZUaz0=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltdEtiMWw2VGs5Tk1rbDZVMjEwV1UxcVZuTmFTR3hMV2tFOVBRPT0=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lteHdjMWt5TVhOaVYwWllWRzFvYTFJeWVESlpiWGMxWkVad1dWVnRPV2xOYkVad1YwWkZPVkJSUFQwPQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVjJSUlZUQndkbHBGYUZOa01rNDJZak5hVFUweVVYcGFTR3N4WWxac1dGUnRlRnBpVkd3eVdWaHJNV0Z0U1hsTlNGcGFUV3BzTUZsc2FGZGtWMFpaVldwV2FrMHhTbTlaYlRGVFlVZE9kRlZ1Y0UxbFZYQnI="))))))))
				}) > 0;
				if (flag)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00028D9C File Offset: 0x00026F9C
		public static string GetTokenEAAG(Chrome chrome)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				bool flag = !chrome.GetURL().Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNjRnBHYUU5alIwcDBWbTV3YW1WVVZuUlhWbVJQWWtac2RFOVlXbWhsVkZaeFdXcEpkMlJuUFQwPQ==")))))))));
				if (flag)
				{
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNjRnBHYUU5alIwcDBWbTV3YW1WVVZuUlhWbVJQWWtac2RFOVlXbWhsVkZaeFdXcEpkMlJuUFQwPQ==")))))))));
				}
				result = (string)chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1QwNVhTblJVVjJSaFlteGFNVmRVVGxOalIwbDVUa2RrVTAxc1dYZFdhMk0xWTJ4d1dFNVZXbHBXTUZwMVV6Qk9jbG95VmpWUmFrcGFWMFZzYmxscVRsZE5SMDVKVm1wQ1NsSkVRbTVUYm14cVRqQnNTVlZ1Ykd4Vk1Fa3pVMVZvWVdGSFRuQlJibXhoVjBVMU0xbHFTVEZsYkhCVVVWUnNTbEl3V1hwWFZtUnpUVVZzU0ZkdGVHdFNNRFYyVXpCT2EySXlVa2xWYm1ScVpXMDVNbFJFU2t0TlYwMTVZa2hXWVZkRk5UWlVSekZoWVVacmVWWnRiR2xOYW14NVZFY3hUMlJ0U2xSUFYyeHJWMFUxZDFsdE1WZGxiVTE0VDFoT2FVMXJOVzlhUldSelpHMUtkVlJZV2t0bFYzTXpVMVZrYzJKVmJFUmhTR3hoVjBVMU0xbHFTVEZsYkhCVVRsaGFhR1ZYZEc1YVdHeERUV3hzV1ZOWFpGcGlWR3h5V2xaT1FrOVZiRWhTYWs1YVZqSjNkMU5WYUV0aVIwMTZVVzVhYVdKck5YTlVSelZUWWtkV1NWVlhPVXhXU0U1dVdXcE9WMDFIVGtsV2FrSlJWakJ3TWxkcmFISmtWMHBZVW1wQ1drMXRaSFpaYlRGWFRUQnNSMU50ZUdGTlJsa3dXVEJPYm1Kc1NsWlNhMHBUWlZka01WTXlielJqUld4d1dUTkNURlp1VGpOWFJrMHhaVlp3V1ZGdVRscFdNRFZ6VXpCT2FtRlZjRFZrTWpWTFpWZHpNMU5WWjNkYU1scFVVVzF3V2xkR1NuRlpWVTVEVGpKYVZGRnViR0ZYUmtsNFdUSXdNRm95U1hwV2FrSnFVMFpaZDFRemJFTlBWVGsxVVdwS1dsZEZiRzVYV0d4Q1QxVnNTRkpxVGxwV01uZDNVMVZXYTJKSFVrZFZibHBvVFd4YU1WVnNaRWRoUm5BMVdqTkNVR1ZWU2pWWGJHaFRUVmRPZEU1SFpGcGxiazA1")))))))));
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00028F38 File Offset: 0x00027138
		public static string RequestGet(Chrome chrome, string url, string website)
		{
			try
			{
				bool flag = website.Split(new char[]
				{
					'/'
				}).Length > 2;
				if (flag)
				{
					website = website.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVock5GQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBSRk5GQlJQVDA9")))))))));
					website = website.Split(new char[]
					{
						'/'
					})[0];
					website = website.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBSRk5GQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVock5GQlJQVDA9")))))))));
				}
				bool flag2 = !chrome.GetURL().StartsWith(website);
				if (flag2)
				{
					chrome.GotoURL(website);
					chrome.DelayTime(1.0);
					chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpVkd4eVdsWk9hbU5GZUhSaVNGWnBZbFphTlZVd1dsTlViRkpGVFVjMVZWWlhlRkJUVlZwUFZVWktjMVZzYUZKV2EzQkhVMjV3ZWxveGNFaFBWM0JyVm5wR2MxbHROVkprVjA1WlZtMTRhbUp0ZUZWWGJHUTBZa1pyZWxWdVdtcGhWMlIxVjFjd05XRXlWbFJaTTBKTlltczBkMXBXWkRSaVJXeEZUVWRrUzAweFNuTmFWV2hTWkVac1dHVklRbUZOYWxFeVUxVmtUMkpIU25WVmJYaHFZVzVPYmxkWE1VZGhiVVY1V2toc2FVMHhXakZYYTAxNFlXMUplV1ZJV21waGJUbHhWMjB4WVdKVmNETlFWREE5")))))))));
				}
				return (string)chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1QwNVhTblJVVjJSaFlteGFNVmRVVGxOalIwbDVUa2RrVm1KV1dqUmFSbVJYWlcxU1JscEhlR3RSTW1SM1UxVm9lbG95VW5SU2JteEtVbnByZUZwRmFFTk5WMUpFVVZSc1NsRXlUblZVTTJ4RFRVZE9kV0V5Wkd4bFZVbDVWMVpvU2xveVRuUldibkJxVW5wc01WbDZTbFphTVVKVVVXMW9hMDFyV25kYVJVNURZbFp3V1ZWdGNHaFJNbVIx")))))))) + url + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NrNHdiRWhpUnpGS1VUSm9OVmRzYUU5a01rbDVUbGh3WVZWNlZqSlpXR3h5V2pKV05WRnFTbHBYUld4dVYxY3dOV0V5VmxSUlZHeEtVakJaZWxkV1pITk5SV3hKVTIxNGFrMHdTakpaYlRWUFlrVjRkVlZ0ZUd4VFJrWjJVekZTZWxveVRuUldha0pyVjBWd01WTlZaRXRrYkhCSllYcGtTbE5FUW01YWJFNURZV3hzV1ZWdGNHaFJNRWt6V214T1EyVldjRmxWYWtacVlsUlNibGxxVGxkTlIwNUpWbXBDVUdWVlNUVlVNMnhEVFd4c1dWTlhaRnBsVlVVMVUxVmtSMDB4YkZoaVJFSktVbXR3YzFreGFGZGlSMDE2Vld0b1lWZEdSblpUTVZKNldqSk9kRlpxUW10WFJYQXhVMVZrVGs1M1BUMD0=")))))))));
			}
			catch
			{
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000292A4 File Offset: 0x000274A4
		public static string RequestPost(Chrome chrome, string url, string data, string website, string contentType = "application/x-www-form-urlencoded")
		{
			try
			{
				bool flag = !chrome.GetURL().StartsWith(website);
				if (flag)
				{
					chrome.GotoURL(website);
					chrome.DelayTime(1.0);
					chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lOVnBpVkd4eVdsWk9hbU5GZUhSaVNGWnBZbFphTlZVd1dsTlViRkpGVFVjMVZWWlhlRkJUVlZwUFZVWktjMVZzYUZKV2EzQkhVMjV3ZWxveGNFaFBWM0JyVm5wR2MxbHROVkprVjA1WlZtMTRhbUp0ZUZWWGJHUTBZa1pyZWxWdVdtcGhWMlIxVjFjd05XRXlWbFJaTTBKTlltczBkMXBXWkRSaVJXeEZUVWRrUzAweFNuTmFWV2hTWkVac1dHVklRbUZOYWxFeVUxVmtUMkpIU25WVmJYaHFZVzVPYmxkWE1VZGhiVVY1V2toc2FVMHhXakZYYTAxNFlXMUplV1ZJV21waGJUbHhWMjB4WVdKVmNETlFWREE5")))))))));
				}
				chrome.DelayTime(1.0);
				data = data.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VVRKak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWak1GQlJQVDA9"))))))))).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWT1NsQlJQVDA9")))))))));
				return (string)chrome.ExecuteScript(string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1QwNVhTblJVVjJSaFlteGFNVmRVVGxOalIwbDVUa2RrVm1KV1dqUmFSbVJYWlcxU1IxRnVXbXBOTVVaMlV6Rk9RMDR3YkVsWGJXaHFZVlZLTWxwR2FGTmtNbEpaVlZka1VWVXdSblZUYm5CNldqSlNTVk5xVmtwVFNFNXVXa2N4UjJWVmJFbFRiWGhxVFRCS01sbHROVTlpUld4RlRVZGtXbGRIVW05WlZtaFNXakZ3ZEZacVFscE5iV1IyVTI1ak9WQlJQVDA9")))))))),
					url,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xb3lWalZSYmxKaFYwWktkbGxxU2xKT2EyeEVXa1pHVlUxVk5WWlRibXd6V2pGc2RFOVhkR3hXUnpsdVUyNWpPVkJSUFQwPQ==")))))))),
					data,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xb3lSa2hXYldoaFVqRmFOVmt6Y0haYU1sWTFVVmMxVWsxcWJERmFSV1JYWkZkU1JFMVdWbXhYUlVwelUyNXdkbG93Y0ROUVZEQTk=")))))))),
					contentType,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1EwOVZiRWxOU0VKUVpWVktkMWR0YkVKaU1rNTBWbTV3YWxKNmJERlpla3BXWkZkSmVXTXpRa3BUU0U1dVdrY3hSMlZWYkVoVGJscGhVMGQwYmxWR1RrTmhSMUY1VW01Q2ExRXdTalZYYkdoUFpESkplVTVZY0dGVmVsVjNWMnhvYjAxRmRFUmhlbVJLVTBWd2MxcEZhRmRsVjBwd1VXMXNhVTFzU1RGVU0yeERUMVZzU1UxSFpGcE5hMWwzVjFSS2Jsb3lWWHBOUjJScVlsWlpkMXBHYUV0a1ZXeElUMVJHYTFORlNYaGFSVko2V2pKYVZXTXlaR3RpVlZvMVUxVmtUbG94UWxSUmJXaHJUV3RhZDFwRlRrTlZNWEJaVW1wR1lWZEZOSGRXVldNMVpXMVNSRm96UWxCbFZVbzFWMnhvVTAxWFRuUk9SMlJhWlc1Tk9RPT0="))))))))
				}));
			}
			catch
			{
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00029688 File Offset: 0x00027888
		public static string GetBirthday(Chrome chrome, string token)
		{
			object[] parameters = new object[]
			{
				chrome,
				token
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(379824, 2624, 342, parameters);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000296E0 File Offset: 0x000278E0
		public static List<string> GetMyListUidMessage(Chrome chrome)
		{
			List<string> list = new List<string>();
			try
			{
				bool flag = !chrome.GetURL().Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFaGpPVkJSUFQwPQ==")))))))));
				if (flag)
				{
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFaGpPVkJSUFQwPQ==")))))))));
				}
				string input = (string)chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1QwNVhTblJVVjJSaFlteGFNVmRVVGxOalIwbDVUa2RrVTAxc1dYZFdSV1J6WlcxU1IxWnVRbUZTVkZadldXeGtWMUl5VG5SaVIzaHBZbFpHZGxNeFRrTk9NR3hKVjIxb2FtRlZTakphUm1oVFpESlNXVlZYWkZGVk1FWjFVMjV3ZWxveVVrbFRhbFpLVTBoT2JscEhNVWRsVld4SlUyMTRhazB3U2pKWmJUVlBZa1ZzUlUxSFpGcFhSMUp2V1Zab1Vsb3hjSFJXYWtKYVRXMWtkbE5xU205TlIxSkpVVzV3VUdGVWFESlpiR1JMWVVkTmVXSkhjRTFpVm5CdlYxUktWMkZYU1hsUFdFcE5ZbFUxTWxsc1RUVmtSbkJaVkc1d1dsWXlVbk5aTTJzMFltdDBWV015WkdoV01XeHVVekJvUzJKSFRYcFJibHBwWW1zMWMxUkhNRFZqYTNSVVVXcGtTbE5HY0c5Wk1teERZVmRKZVZWcVZrcFNSRUp1VjFab2EyRkhSbGxWVjJScVlsWmFObGt3WXpWa1YwMTVWbGhXYTFJeFdUQmFSVTV1WTBVNU5WRnViR0ZYUmtsNFdUSXdNRm94YkhSUFYzUnNWa2hPYmxwc1RrTlBWV3hJVkcxb2ExSXdOWFpUVldnd1QxVnNTVk50ZUd0VFJsbzFXVzFzUTJSdFVsbFZibVJyVjBaRk0xTlZaM2RPTUd4SlYyMW9hbUZWU25GVFZWRjNXakZzV1ZwSGFHaFhSa1p1VldwS1YwMUdVa2hpU0hCclVteGFkMWRyVlRGaFIwcFlWbXRrYW1KWGVITlpiVEZTWWpCMFZXTXlaR3BpVmxsM1drWm9TMlJWYkVoVVZHTTk=")))))))));
				int num = 1;
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
							text2 = WebUtility.HtmlDecode(text2);
							bool flag2 = !list.Contains(text2);
							if (flag2)
							{
								list.Add(text2);
							}
						}
						catch
						{
						}
					}
					text = Regex.Match(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSSmVHSkhUWHBVYldoaFRXeGFObFJJYXpGa01XeFlXa2Q0VldKc1dqQlZSazV1WkZWMGNVOUlRa3BhZWpBNQ=="))))))))).Value.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaamVHUXdPVE5RVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					input = (string)chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1QwNVhTblJVVjJSaFlteGFNVmRVVGxOalIwbDVUa2RrVTAxc1dYZFdSV1J6WlcxU1IxWnVRbUZTVkZadldXeGtWMUl5VG5SaVIzaHBZbFpHZGxNeFRrTk9NR3hKVjIxb2FtRlZTakphUm1oVFpESlNXVlZYWkZGVk1FWjFVMjV3ZWxveVVrbFRhbFpLVTBoT2JscEhNVWRsVld4SlUyMTRhazB3U2pKWmJUVlBZa1ZzUlUxSFpGcFhSMUp2V1Zab1Vsb3hjSFJXYWtKYVRXMWtkbE5xU205TlIxSkpVVzV3VUdGVWFESlpiR1JMWVVkTmVXSkhjRTFpVm5CdlYxUktWMkZYU1hsUFdFcE5ZbFUxTWxsc1JUbFFVVDA5")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NrNHdiRWhpUnpGS1VUSm9OVmRzYUU5a01rbDVUbGh3WVZWNlZqSlpXR3h5V2pKV05WRnFTbHBYUld4dVYxY3dOV0V5VmxSUlZHeEtVakJaZWxkV1pITk5SV3hKVTIxNGFrMHdTakpaYlRWUFlrVjRkVlZ0ZUd4VFJrWjJVekZTZWxveVRuUldha0pyVjBWd01WTlZaRXRrYkhCSllYcGtTbE5FUW01YWJFNURZV3hzV1ZWdGNHaFJNRWt6V214T1EyVldjRmxWYWtacVlsUlNibGxxVGxkTlIwNUpWbXBDVUdWVlNUVlVNMnhEVFd4c1dWTlhaRnBsVlVVMVUxVmtSMDB4YkZoaVJFSktVbGRTYzFwRlZqUmpSMDE2Vld4YWFGWXhTbEJYVm1ONFlrWktkVk51UW1GV2VsWnlVekJPY2s0d2JFbFRiWGhyVTBaYU5WbHRiRU5oYXprelVGUXdQUT09")))))))));
					num++;
					bool flag3 = num >= 5;
					if (flag3)
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

		// Token: 0x06000235 RID: 565 RVA: 0x00029C54 File Offset: 0x00027E54
		public static List<string> GetMyListComments(Chrome chrome, int numberMonth)
		{
			List<string> list = new List<string>();
			try
			{
				bool flag = !chrome.GetURL().Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFaGpPVkJSUFQwPQ==")))))))));
				if (flag)
				{
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFaGpPVkJSUFQwPQ==")))))))));
				}
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFUk9lbVF5V2xSUFYyaHBVak5vYjFkVVRsTmpSMUowWWtSQ2JGVjZaM1pYVkVwSFRVWndXRnBJV21waWJYaHRXVlJLVjA1V1FsaFVibHBwVm5wR2MxbHROVk5sYkd0NVpVUkdhazB4U25OWk1teGhUVWRHV0UxWGVHcE5NVXB2V1RJMVVrOVhWalpTYW14TFlteEtkMWxzWkZkaVIwcDBWVlJzYkdWcmJ6VT0="))))))));
				string text = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFYwMUhVbGxUYmxaS1VUSm9jbGxxU2s5TlYwcFlWbTVXYTFGNlZuRlpha2sxWTIxR1dGWlhaRXhsVlVaMVZETnNhbU5GZUhSTlYyaHJVakExZGxNd1l6RmlSMUkxVVd4T1lWWXlVa2RhVldoQ1lqQnZlVlJ0V210WFJUVnpXVEp2ZDJJd2VIQmllVGxNVmtoT2RWTXhUbk5aYXpGWFRVUXdQUT09"))))))))).ToString();
				string arg = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string arg2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string text3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				List<string> list2 = new List<string>();
				for (int i = 0; i < numberMonth; i++)
				{
					DateTime dateTime = DateTime.Now.AddMonths(2 - i);
					DateTime dateTime2 = DateTime.Now.AddMonths(1 - i);
					arg = Common.ConvertDatetimeToTimestamp(new DateTime(dateTime.Year, dateTime.Month, 1)).ToString();
					arg2 = Common.ConvertDatetimeToTimestamp(new DateTime(dateTime2.Year, dateTime2.Month, 1)).ToString();
					text2 = string.Format(@string, text, arg, arg2);
					list2.Add(text2);
				}
				for (int j = 0; j < list2.Count; j++)
				{
					text2 = list2[j];
					bool flag2;
					do
					{
						flag2 = false;
						text3 = CommonChrome.RequestGet(chrome, text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13d1ZFaGpPVkJSUFQwPQ==")))))))));
						text3 = WebUtility.HtmlDecode(text3);
						MatchCollection matchCollection = Regex.Matches(text3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlVWb1QyUXhiRmhPUTNSTVVYcFNlRlZJYkhKUFJYZDVXbnBDVVZwNk1Eaz0=")))))))));
						for (int k = 0; k < matchCollection.Count; k++)
						{
							string text4 = matchCollection[k].Groups[1].Value;
							text4 = text4.Substring(0, text4.LastIndexOf('<'));
							MatchCollection matchCollection2 = Regex.Matches(text4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlVWT2JtUlZkSEZQU0VKUldub3dPUT09")))))))));
							for (int l = 0; l < matchCollection2.Count; l++)
							{
								text4 = text4.Replace(matchCollection2[l].Value, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
							}
							bool flag3 = text4 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) && !list.Contains(text4);
							if (flag3)
							{
								list.Add(text4);
							}
						}
						bool flag4 = Regex.IsMatch(text3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1IyTXlTa2hTYlhCclVqSjNlVmxXYUZOT1ZYZDRaSGs1V2sxcldYZFhiR1JyWkcxT2RXSkhXbWhOYkZreFZVWmtUMlJ0U2xoTlYzaHBZbXhLTmxkVVNqUk5WMDE2VlcxNGFtRldiM2RaVm1ONFlrWndXRTVYZEV4UmVsSjRWVWhzY21GUlBUMD0=")))))))));
						if (flag4)
						{
							text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13dw==")))))))) + Regex.Match(text3, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1IyTXlTa2hTYlhCclVqSjNlVmxXYUZOT1ZYZDRaSGs1V2sxcldYZFhiR1JyWkcxT2RXSkhXbWhOYkZreFZVWmtUMlJ0U2xoTlYzaHBZbXhLTmxkVVNqUk5WMDE2VlcxNGFtRldiM2RaVm1ONFlrWndXRTVYZEV4UmVsSjRWVWhzY21GUlBUMD0="))))))))).Value.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
							flag2 = true;
						}
					}
					while (flag2);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0002A4B0 File Offset: 0x000286B0
		public static List<string> GetMyListUidNameFriend(Chrome chrome)
		{
			object[] parameters = new object[]
			{
				chrome
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(391904, 3056, 345, parameters);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0002A4F8 File Offset: 0x000286F8
		internal static void CheckStatusAccount(Chrome chrome, bool isSendRequest)
		{
			try
			{
				bool flag = chrome.CheckChromeClosed();
				if (flag)
				{
					chrome.Status = StatusChromeAccount.ChromeClosed;
				}
				else
				{
					string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (isSendRequest)
					{
						string text2 = chrome.GetURL();
						text2 = Regex.Match(text2, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUm9kbFJIYkhaTU1IUllWMjFvV2sxc1duQlpha2sxWTJ0NGRGUnVXbWxWVkRBNQ=="))))))))).Value + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS05HUnNiM2xpU0ZVOQ=="))))))));
						text = CommonChrome.RequestGet(chrome, text2, text2);
					}
					else
					{
						text = chrome.GetPageSource();
					}
					bool flag2 = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaU1NsQlJQVDA9"))))))));
					if (flag2)
					{
						chrome.Status = StatusChromeAccount.ChromeClosed;
					}
					else
					{
						bool flag3 = Regex.IsMatch(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnRSbGhPVjFwaFlsUnNOVmxzUlRsUVVUMDk="))))))))) || text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS05HUnNiM2xpU0ZaTlpXcHNNVmRzYUc5TlFUMDk=")))))))));
						if (flag3)
						{
							bool flag4 = chrome.CheckExistElement(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYV0VaUlZUQnNNbGxyWXpWaWJVWllUa2hhVVUxcVZuTmFWV2hTWVZab1VsQlVNRDA9")))))))), 0.0) == 1;
							if (flag4)
							{
								chrome.Click(4, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYV0VaUlZUQnNNbGxyWXpWaWJVWllUa2hhVVUxcVZuTmFWV2hTWVZab1VsQlVNRDA9")))))))), 0, 0, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0, 1);
							}
							chrome.Status = StatusChromeAccount.LoginWithUserPass;
						}
						else
						{
							bool flag5 = Regex.IsMatch(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnRSbGhPVjFwcVUwVndNbGR0TVhOak1YQlhUMWN4YVUwd2NEQT0="))))))))) || Regex.IsMatch(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS05HUnNiM2xpU0ZaTlRXeEtjMXBITVhOaGJIQlVUVmRzV2xkRk5YTlhhMDAxVFd4c1dHVklRbUZTTUZsM1YyeE5lR1IzUFQwPQ==")))))))));
							if (flag5)
							{
								chrome.Status = StatusChromeAccount.LoginWithSelectAccount;
							}
							else
							{
								bool flag6 = Convert.ToBoolean(chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhrU0doUlZqRndiMWxyYUU5aVJUaDVZa2N4VEZJeFNqSlhWRTVYWkVad1dFNVVRazFpYTFsNFYyeG9TMDVXVlhsV2JrNWhWakEwZDFscVRrcGlNSEExVkc1U1UxZEZjRFZaYWs1TFZqSkdXRlpxVGt0bFYzUnZWVVpqTVUxWFNraGtNbVJMWVZac2JsTldaRk5rYkd0NlZtNVNZVlo2VlhkVVJ6VkhUVlp3V1ZOcVZsWk5iRnA2VjJ4a1QwMUhTWHBUVnpsTFpWVTFNRlZzYUV0bFYwbDZVMnhrYUZZeFdYcFRibXh5WkZadmVWWnFRbEpYUmtsM1dUSXhjMkZYVWxsVmJYaE1VVEpTTmxwRmFITmpNWEJVV1ROQ1RXSlhlREZYVkVvMFRWWndTRlp1Y0V4Uk1sSnlXVlpvVDJReVNraFNhbFpRWWxSV01sbHRNVlppYTNSVVlUSmthRTB3VlRWYVJXaExUVlp3VldSSWJHRlhSa2w0V1RJd01Gb3lSWHBTV0VwTFpWZE5PUT09")))))))))) || Regex.IsMatch(text, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1MySkdjSEZOUjJ4b1UwWkpkMWt3YUU1T2EzZzFUMWhTVFdKV2NHOVhWRXBYWVZkSmVVOVlTazFpVlRVeVdXeE5OV015U1hsYVNFSnBZVlJXTTFsVmFFSlFVVDA5")))))))));
								if (flag6)
								{
									chrome.Status = StatusChromeAccount.LoginWithSelectAccount;
								}
								else
								{
									bool flag7 = CommonChrome.CheckNoveri(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
									if (flag7)
									{
										chrome.Status = StatusChromeAccount.Noveri;
									}
									else
									{
										bool flag8 = CommonChrome.CheckCheckpoint(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
										if (flag8)
										{
											chrome.Status = StatusChromeAccount.Checkpoint;
										}
										else
										{
											bool flag9 = text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4b1MyVlhTWHBUV0ZKb1ZucFdkRmxxVGt0a1JteFpWVzVDYVUxcVVqQlpNR00xWkRKU1dWRllVbHBOYW13eFdrVmtWMlJYVWtKUVZEQTk="))))))))) || text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1YySnNiM2xXYm5CclVqSjRNbGx0TlU5V1IxSllUVmhTV2xkRmJ6RldSV1J6WlcxU1FsQlVNRDA9")))))))));
											if (flag9)
											{
												chrome.Status = StatusChromeAccount.NoInternet;
											}
											else
											{
												bool flag10 = CommonChrome.CheckLoginSuccess(chrome, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
												if (flag10)
												{
													chrome.Status = StatusChromeAccount.Logined;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0002AD3C File Offset: 0x00028F3C
		public static bool CheckNoveri(Chrome chrome, string currentUrl = "", string html = "")
		{
			bool flag = currentUrl == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				currentUrl = chrome.GetURL();
			}
			List<string> lstKerword = new List<string>
			{
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDVWRzVhYVdKV2NIZFpNakI0WWtkS1dGSnVRbWxSZWxZeldWVm9RbEJSUFQwPQ=="))))))))
			};
			bool flag2 = CommonChrome.CheckStringContainKeyword(currentUrl, lstKerword);
			bool result;
			if (flag2)
			{
				result = true;
			}
			else
			{
				List<string> list = new List<string>
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVXhjRmRHUlRsUVVUMDk="))))))))
				};
				bool flag3 = chrome.CheckExistElements(0.0, list.ToArray()) > 0;
				result = flag3;
			}
			return result;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0002AEBC File Offset: 0x000290BC
		public static bool CheckCheckpoint(Chrome chrome, string currentUrl = "", string html = "")
		{
			bool flag = currentUrl == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				currentUrl = chrome.GetURL();
			}
			List<string> lstKerword = new List<string>
			{
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDVWRzA1WVZZd05YbFpNR00xWTBkS2RWVllXbEJTUldzd1ZGZHdibVZGTVVWVVdHUlFWa1ZyZWxReFVsWk5aejA5")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDVWRzA1WVZZd05YbFpNR00xWTBkS2RWVllXazVXUmxZelZGWlNRazVWTVhGYU0yeE9aV3hXTlZSc1VrcE9SVEZ1VUZRd1BRPT0=")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDVUbFJDVFUwd05YRlpNakZYWWtkS2NFOURPV3BTTUZvMVYxWmplR1ZzUWxSV1ZFNVNZVlpXTlZSWE5WTmtiVVY1Vm01VlBRPT0=")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFIyRnNjRmhUYmxwcFRXNU9NVmRVU1RWa1JYZDZXak5hV2sxdGFITlhWRW93WkRKSmVXSklWbXRSZW1jNQ=="))))))))
			};
			bool flag2 = CommonChrome.CheckStringContainKeyword(currentUrl, lstKerword);
			bool result;
			if (flag2)
			{
				result = true;
			}
			else
			{
				bool flag3 = html == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag3)
				{
					html = chrome.GetPageSource();
				}
				List<string> lstKerword2 = new List<string>
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFYyVlhSbGhYYmtKYVRXdFpkMWxXWXpWa1ZtZDVUVmQ0YTFJeWFESlhhMFU1VUZFOVBRPT0=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1YyRlhTbGhpUkVKWVRWZDRjMWw2UlhkUVVUMDk=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YyUldjRWRQVjNCcFRXeEtjdz09")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1QySXhjRmhVYmtwcVVucHNkMWx0TlZKa2JIQkpZa2hCUFE9PQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS1IyUXlVa2hVYlRsYVZtcHNOVmRzYUU5a01rbDVUbGh3WVZWVU1Eaz0=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVazFOYXpVeVdXeGplRTFYU25SaVJFSnNWMFUwZDFkV1l6RmhNV3haVTIxMGFtVlVaems9")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWa1YyTXlUa1JQU0doT1lXdFdORlJWVWxKTlJUbEZVbGh3VGxKR1JqWlVNVkpXVUZFOVBRPT0=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWa1YyTXlUa1JQU0doUFlXeHJNRlJ0Y0U1a01ERlZVVmhrVDJWdFkzaFVWbEpLVUZFOVBRPT0=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWa1YyTXlUa1JQU0doT1ZrZE5kMVJzVWtKTmF6RlZWbGhrVGxKR2EzcFVWbEpXVUZFOVBRPT0=")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IySkdhM2xrU0dScFRXMTRNVnBGVFRSbFJUVlZVVmhvVGxKSGREVlVNRkpLWldzMVZWTlVSazVoYldRMQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IySkdhM2xrU0dScFRXMTRNVnBGVFRST1JURnhXak5zVUZKRlZqTlVXSEJDVGxVeGNWbDZWazlXUm1zNQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFIyUkdjRlZOUjJ4YVRXcHNjbGRzV1RSbFJXeHVVRlF3UFE9PQ=="))))))))
				};
				bool flag4 = CommonChrome.CheckStringContainKeyword(html, lstKerword2);
				if (flag4)
				{
					result = true;
				}
				else
				{
					List<string> list = new List<string>
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lteHdjMWt5TVhOaVYwWllWRzFvYTFJeWVESlpiWGMxWkVad1dWVnRPV2xOYkVad1YwWkZPVkJSUFQwPQ==")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczBlRmRYTUhoalIxSkhaRVp3WVZkRk5XdFRWM2QzVUZFOVBRPT0=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1ltczFjMWx0TVZOYWJHdDVUMWQwWVZVd2NHcz0=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSS1QyRkhUa2xWYlhCb1VqQmFiVmt5TVZkbGJVNUlUMWhXYWsxc1ZUaz0=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS2IyVldjRmhYVkd4S1lsZG5kMXBGYUVObGF6bHdUMGhhYTAweVVYcFVSekZoWVVacmVWWnRiR2xOYW14NVZFY3hUMlJ0U2xSUFYzQnBUV3BHTUZwR1l6RmpSMUpKWWtod2ExSXdXakZYYTJSSFpWWndTVlJZV2twaVJFRTU=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1XRkhTbGhXVkd4S1lsVTFNbGRyWkZkYWF6RlVVMjFSUFE9PQ==")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1IyRnRVa2hpU0ZwcFlXcENjRlJFU2pSa2JHOTVZa2hXVFUxck5YWlhiR1JQWTIxT1NFOVlRbWxpYkVZeVUxZDNkMW94WTNsT1YyaHBWakZWTlZOWE1VOWtiVXAxVlcxb1drMHhTbTFaVm1NeFlURndXVm95YkZsVlZEQTU="))))))))
					};
					bool flag5 = chrome.CheckExistElements(0.0, list.ToArray()) > 0;
					result = flag5;
				}
			}
			return result;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0002B708 File Offset: 0x00029908
		public static bool CheckLoginSuccess(Chrome chrome, string currentUrl = "", string html = "")
		{
			bool flag = currentUrl == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				currentUrl = chrome.GetURL();
			}
			List<string> lstKerword = new List<string>
			{
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhPV2xOYWtaelZFYzFRMkl5VGtKUVZEQTk="))))))))
			};
			bool flag2 = CommonChrome.CheckStringContainKeyword(currentUrl, lstKerword);
			bool result;
			if (flag2)
			{
				result = true;
			}
			else
			{
				bool flag3 = html == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag3)
				{
					html = chrome.GetPageSource();
				}
				List<string> lstKerword2 = new List<string>
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS1lXVlhSbGhXYmxaaFUwVXhNZz09")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS05HUnNiM2xQVkVaclVYcFdNMWxWYUVKTU1XeDFWbXBDYTFKNmJERlhSRW8wWkd4cmVWSnFRbWhXZW13eFZVWm9UMkpIVWtsVmJrSnBZbGRTTmxOdE1VZGtSMDVGWkVkc2ExZEdTWGRaYWtreFdtMUtkRkp1VW1GV1JFWjZXV3BLYTJSdFVsbFZWREE5"))))))))
				};
				bool flag4 = CommonChrome.CheckStringContainKeyword(html, lstKerword2);
				if (flag4)
				{
					result = true;
				}
				else
				{
					List<string> list = new List<string>
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaYU1HSXlUblJXYlRGTVlXcENjRlJFU21GbFYwWllWbTVXWVZORk1USlRWM2QzVUZFOVBRPT0=")))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1IyRnRVa2hpU0ZwcFlXcENjRlJFU2pSa2JHOTVUMVJHYTFGNlZqTlpWV2hDVERGc2RWWnFRbXRTZW13eFYwUktOR1JzYTNsU2FrSm9WbnBzTVZWR2FFOWlSMUpKVlc1Q2FXSlhValpUYlRGTFRWZFNTVlZ1V21saVJHd3hWMVpqZUdKR1FsaGxTRnBoVFdwcmVGcEZUa3RhUVQwOQ=="))))))))
					};
					bool flag5 = chrome.CheckExistElements(0.0, list.ToArray()) > 0;
					result = flag5;
				}
			}
			return result;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0002B9FC File Offset: 0x00029BFC
		private static bool CheckStringContainKeyword(string content, List<string> lstKerword)
		{
			for (int i = 0; i < lstKerword.Count; i++)
			{
				bool flag = Regex.IsMatch(content, lstKerword[i]) || content.Contains(lstKerword[i]);
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0002BA90 File Offset: 0x00029C90
		public static List<string> BackupImageOne(Chrome chrome, string uidFr, string nameFr, string token, int countImage = 20)
		{
			object[] parameters = new object[]
			{
				chrome,
				uidFr,
				nameFr,
				token,
				countImage
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(407888, 5024, 351, parameters);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0002BB18 File Offset: 0x00029D18
		public static List<string> GetMyListUidFriend(Chrome chrome)
		{
			object[] parameters = new object[]
			{
				chrome
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(412912, 2624, 352, parameters);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0002BB60 File Offset: 0x00029D60
		public static List<string> GetMyListNameFriend(Chrome chrome, bool isOnlyGetVNName = false)
		{
			object[] parameters = new object[]
			{
				chrome,
				isOnlyGetVNName
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(415536, 2608, 353, parameters);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0002BBB8 File Offset: 0x00029DB8
		public static bool SkipNotifyWhenAddFriend(Chrome chrome)
		{
			bool result = true;
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			switch (chrome.CheckExistElements(2.0, new string[]
			{
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeHdVVzVTVFZaNmEzbFhiR2hMWXpGc1dXRXpVbWxTTUZreFYyeG9TbUZXYUZSUmJXeHJWMFpKZDFscVNUQlFVVDA5")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeHdVVzVTVFZaNmEzbFhiR2hMWXpGc1dXRXpVbWxTTUZreFYyeG9TbUZXYUZSUmJVcHJZbFZhZWxwR1pGWlBWV3h5VDFWNFNtSkVRVGs9")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFWVzVhYTFZd05YWlhWbVJMWXpGd1ZGRnVVazFXTVZvMVdUSXdOV1ZWZUZoUFZFcGhWMFZ3ZWxkV2FISmtSbkJJVDFoV1lWVXdjR3M9")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFWVzVhYTFZd05YWlhWbVJMWXpGd1ZGRnVVazFXZW10NVYyeG9TMk14YkZsaE0xSnBVakJaTVZkc2FFcGhWbWhTVUZRd1BRPT0=")))))))),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFWVzVhYTFZd05YWlhWbVJMWXpGd1ZGRnVVazFXTVZvMVdUSXdOV1ZWZUZoUFZFcGhWMFZ3ZWxkV2FISmtSbXQ1VW01V1drMXNXbnBUVjNkM1VGRTlQUT09"))))))))
			}))
			{
			case 0:
				result = false;
				break;
			case 1:
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeHdVVzVTVFZaNmEzbFhiR2hMWXpGc1dXRXpVbWxTTUZreFYyeG9TbUZXYUZSUmJXeHJWMFpKZDFscVNUQlFVVDA5"))))))));
				break;
			case 2:
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeHdVVzVTVFZaNmEzbFhiR2hMWXpGc1dXRXpVbWxTTUZreFYyeG9TbUZXYUZSUmJVcHJZbFZhZWxwR1pGWlBWV3h5VDFWNFNtSkVRVGs9"))))))));
				break;
			case 3:
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFWVzVhYTFZd05YWlhWbVJMWXpGd1ZGRnVVazFXTVZvMVdUSXdOV1ZWZUZoUFZFcGhWMFZ3ZWxkV2FISmtSbkJJVDFoV1lWVXdjR3M9"))))))));
				break;
			case 4:
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFWVzVhYTFZd05YWlhWbVJMWXpGd1ZGRnVVazFXZW10NVYyeG9TMk14YkZsaE0xSnBVakJaTVZkc2FFcGhWbWhTVUZRd1BRPT0="))))))));
				break;
			case 5:
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UyRkhVa2hTV0ZKcVRXMTRkVmxXWkROUFZXeDFWVzVhYTFZd05YWlhWbVJMWXpGd1ZGRnVVazFXTVZvMVdUSXdOV1ZWZUZoUFZFcGhWMFZ3ZWxkV2FISmtSbXQ1VW01V1drMXNXbnBUVjNkM1VGRTlQUT09"))))))));
				break;
			}
			bool flag = @string != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lORDA9")))))))) + @string + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NtUldhM2xsU0VKYVRXNU9kbE14VW5wUVVUMDk=")))))))));
			}
			return result;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0002C054 File Offset: 0x0002A254
		public static string GetFbDtag(Chrome chrome)
		{
			string result;
			try
			{
				string text = chrome.GetURL();
				bool flag = CommonChrome.CheckTypeWebFacebookFromUrl(text) != 2;
				if (flag)
				{
					chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9")))))))));
				}
				text = Regex.Match(chrome.GetURL(), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUm9kbFJIYkhaTU1IUllWMjFvV2sxc1duQlpha2sxWTJ0NGRGUnVXbWxWVkRBNQ=="))))))))).Value;
				string input = CommonChrome.RequestGet(chrome, text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS2IySkhTa2xSV0ZrOQ==")))))))), text);
				result = Regex.Match(input, Common.Base64Decode(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGamVGVXdNVWhVV0d4aFVqRndZVlpxU2s5alJsRjVUbGh3YUZZeFNrbFVNV2hMV1ZaYU5sVnVRbFZOYlhoTFdXcENOR05IU2pWUFZYaFdUVWR6TlE9PQ==")))))))))).Groups[1].Value;
			}
			catch
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			return result;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0002C26C File Offset: 0x0002A46C
		public static string GetHostFacebook(Chrome chrome, int typeWeb = 2)
		{
			try
			{
				string url = chrome.GetURL();
				bool flag = CommonChrome.CheckTypeWebFacebookFromUrl(url) != typeWeb;
				if (flag)
				{
					switch (typeWeb)
					{
					case 1:
						chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVVDA9")))))))));
						break;
					case 2:
						chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9")))))))));
						break;
					case 3:
						chrome.GotoURL(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13dw==")))))))));
						break;
					}
				}
				return Regex.Match(chrome.GetURL(), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUm9kbFJIYkhaTU1IUllWMjFvV2sxc1duQlpha2sxWTJ0NGRGUnVXbWxWVkRBNQ=="))))))))).Value;
			}
			catch
			{
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0002C4AC File Offset: 0x0002A6AC
		public static List<string> GetListGroup(Chrome chrome)
		{
			object[] parameters = new object[]
			{
				chrome
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(423920, 3344, 357, parameters);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0002C4F4 File Offset: 0x0002A6F4
		public static List<string> GetListPage(Chrome chrome)
		{
			object[] parameters = new object[]
			{
				chrome
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(427264, 1504, 358, parameters);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0002C53C File Offset: 0x0002A73C
		public static List<string> GetListPage2(Chrome chrome)
		{
			object[] parameters = new object[]
			{
				chrome
			};
			return (List<string>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(428768, 1520, 359, parameters);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0002C584 File Offset: 0x0002A784
		public static string GetWebsiteFacebook(Chrome chrome, int typeWeb)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			switch (typeWeb)
			{
			case 1:
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnJlbHBFVG1wa1ZuQjBVbTF3WVZZd2NESlpha3A2WkZacmVVOVlVVDA9"))))))));
				break;
			case 2:
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1VsQlVNRDA9"))))))));
				break;
			case 3:
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRmRYTVVkbGJVWllWRmhXWVdKVlduRlhiR1JMWkcxSmVXTXpWbHBOYW13dw=="))))))));
				break;
			}
			string url = chrome.GetURL();
			bool flag = CommonChrome.CheckTypeWebFacebookFromUrl(url) != typeWeb;
			if (flag)
			{
				chrome.GotoURL(@string);
			}
			return Regex.Match(chrome.GetURL(), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUm9kbFJIYkhaTU1IUllWMjFvV2sxc1duQlpha2sxWTJ0NGRGUnVXbWxWVkRBNQ=="))))))))).Value;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0002C780 File Offset: 0x0002A980
		public static Bitmap CropImageFromChrome(Chrome chrome, string cssSelector)
		{
			chrome.ScrollSmoothIfNotExistOnScreen(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0ak5XRnRVbGhOVjNocFlteEdNVmt4YUZkaVIwNTFZa1pTWVZZemFITlhWRTVUWkcxT2NGb3lORDA9")))))))) + cssSelector + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9")))))))));
			chrome.DelayTime(1.0);
			string text = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhpU0ZKaFpXcEdjbGxxU2s5TlYwcFlWbTVXYTFGNlZqUmFSbVJYWlZkV1YxUnRlR2xTTVZweFdrVmpOV1ZWZEVSWmVqQTk=")))))))) + cssSelector + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NtUldiM2xXYWtKU1lsUnJlRmx0TVZOalIwcDBXa1ZTYVZJeWVITlpiVFZUVlRGd1dGUnFRa3hSTW5NelUxVm9TMkpIVWtsV2JteHBZVlZLVDFkV2FGTmlNSGgwVjI1T2FVMXFiRFZUTUdSelpFWndOVTVVVWt4Vk0wNTFXbXRPYW1Oc1VsaFNha0pvVVhwV2RGbHJZelZrYlU1d1lVaENhVll5VGpGYVZrNXlZMnR2ZW1ReU5VeE5SRVp2V2tWa2JtUldhM2xXYmtKcFVUSm9kMWxzWkdwa1YxRjVZa2QwYTFJeVpIZFRNMnhyVDBWd05XUkZOVnBYUmtwMlZFY3hUMkpIUmxoa01qbG9WbnBHZFZSSE1XOWlSMFpZV2tjNWExRXljek09"))))))))).ToString();
			int num = Convert.ToInt32(text.Split(new char[]
			{
				'|'
			})[0]) + 10;
			int num2 = Convert.ToInt32(text.Split(new char[]
			{
				'|'
			})[1]) + 30;
			int width = Convert.ToInt32(text.Split(new char[]
			{
				'|'
			})[2]);
			int height = Convert.ToInt32(text.Split(new char[]
			{
				'|'
			})[3]);
			Bitmap image = chrome.ScreenCapture(1);
			Bitmap bitmap = new Bitmap(width, height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.DrawImage(image, -num, -num2);
			return bitmap;
		}
	}
}
