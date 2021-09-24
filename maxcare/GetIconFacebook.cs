using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using MCommon;

namespace maxcare
{
	// Token: 0x02000186 RID: 390
	internal class GetIconFacebook
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x00403834 File Offset: 0x00401A34
		private static string GetNumber(string input)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				List<string> list = GetIconFacebook.number.Split(new char[]
				{
					'|'
				}).ToList<string>();
				for (int i = 0; i < input.Length; i++)
				{
					text2 = input[i].ToString();
					bool flag = Common.IsNumber(text2);
					if (flag)
					{
						text2 = list[Convert.ToInt32(text2)];
					}
					text += text2;
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00403990 File Offset: 0x00401B90
		private static string GetIcon(string type, Random rd)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			List<string> list = new List<string>();
			try
			{
				uint num = <PrivateImplementationDetails>.ComputeStringHash(type);
				if (num <= 2059200309U)
				{
					if (num <= 312791236U)
					{
						if (num != 311070023U)
						{
							if (num == 312791236U)
							{
								if (type == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NtVnNhRkpRVkRBOQ==")))))))))
								{
									list = GetIconFacebook.icon3.Split(new char[]
									{
										'|'
									}).ToList<string>();
									result = list[rd.Next(0, list.Count)];
								}
							}
						}
						else if (type == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrNUdhRkpRVkRBOQ==")))))))))
						{
							list = GetIconFacebook.icon8.Split(new char[]
							{
								'|'
							}).ToList<string>();
							result = list[rd.Next(0, list.Count)];
						}
					}
					else if (num != 313482784U)
					{
						if (num != 380446165U)
						{
							if (num == 2059200309U)
							{
								if (type == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1UxcEJQVDA9")))))))))
								{
									result = DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV2JrNXRTbGhOUkZwcVRUQXdPUT09")))))))));
								}
							}
						}
						else if (type == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMXNhRkpRVkRBOQ==")))))))))
						{
							list = GetIconFacebook.icon6.Split(new char[]
							{
								'|'
							}).ToList<string>();
							result = list[rd.Next(0, list.Count)];
						}
					}
					else if (type == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMHhhRkpRVkRBOQ==")))))))))
					{
						list = GetIconFacebook.icon7.Split(new char[]
						{
							'|'
						}).ToList<string>();
						result = list[rd.Next(0, list.Count)];
					}
				}
				else if (num <= 3534241179U)
				{
					if (num != 3135527781U)
					{
						if (num == 3534241179U)
						{
							if (type == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMUdhRkpRVkRBOQ==")))))))))
							{
								list = GetIconFacebook.icon4.Split(new char[]
								{
									'|'
								}).ToList<string>();
								result = list[rd.Next(0, list.Count)];
							}
						}
					}
					else if (type == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UxcEJQVDA9")))))))))
					{
						result = DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1VtUnNVbFpOU0Zwc1YwZDNNVnBXUlRsUVVUMDk=")))))))));
					}
				}
				else if (num != 3600807202U)
				{
					if (num != 3600954297U)
					{
						if (num == 3601498750U)
						{
							if (type == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMVdhRkpRVkRBOQ==")))))))))
							{
								list = GetIconFacebook.icon5.Split(new char[]
								{
									'|'
								}).ToList<string>();
								result = list[rd.Next(0, list.Count)];
							}
						}
					}
					else if (type == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NtVldhRkpRVkRBOQ==")))))))))
					{
						list = GetIconFacebook.icon2.Split(new char[]
						{
							'|'
						}).ToList<string>();
						result = list[rd.Next(0, list.Count)];
					}
				}
				else if (type == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NtVkdhRkpRVkRBOQ==")))))))))
				{
					list = GetIconFacebook.icon1.Split(new char[]
					{
						'|'
					}).ToList<string>();
					result = list[rd.Next(0, list.Count)];
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00404154 File Offset: 0x00402354
		public static string ProcessString(string input, Random rd)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				for (int i = 0; i < GetIconFacebook.lstKey.Count; i++)
				{
					text2 = GetIconFacebook.lstKey[i];
					bool flag = input.Contains(text2);
					if (flag)
					{
						List<string> list = input.Split(new string[]
						{
							text2
						}, StringSplitOptions.None).ToList<string>();
						for (int j = 0; j < list.Count - 1; j++)
						{
							text = text + list[j] + GetIconFacebook.GetIcon(text2, rd);
						}
						text += list[list.Count - 1];
						input = text;
						text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					}
				}
				MatchCollection matchCollection = Regex.Matches(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWYU1HUlZkRVJPU0VaUlpWZDRhbGRHUlRsUVVUMDk=")))))))));
				for (int k = 0; k < matchCollection.Count; k++)
				{
					List<string> list2 = input.Split(new string[]
					{
						matchCollection[k].Value
					}, StringSplitOptions.None).ToList<string>();
					for (int l = 0; l < list2.Count - 1; l++)
					{
						text = text + list2[l] + Common.CreateRandomNumber(Convert.ToInt32(matchCollection[k].Groups[1].Value), rd);
					}
					text += list2[list2.Count - 1];
					input = text;
					text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				}
				matchCollection = Regex.Matches(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWYU1HVnJkRVJPU0VaUlpWZDRhbGRHUlRsUVVUMDk=")))))))));
				for (int m = 0; m < matchCollection.Count; m++)
				{
					List<string> list3 = input.Split(new string[]
					{
						matchCollection[m].Value
					}, StringSplitOptions.None).ToList<string>();
					for (int n = 0; n < list3.Count - 1; n++)
					{
						text = text + list3[n] + Common.CreateRandomString(Convert.ToInt32(matchCollection[m].Groups[1].Value), rd);
					}
					text += list3[list3.Count - 1];
					input = text;
					text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				}
				matchCollection = Regex.Matches(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWYU1HVkZkRVJPU0VaUlpWZDRhbGRHUlRsUVVUMDk=")))))))));
				for (int num = 0; num < matchCollection.Count; num++)
				{
					List<string> list4 = input.Split(new string[]
					{
						matchCollection[num].Value
					}, StringSplitOptions.None).ToList<string>();
					for (int num2 = 0; num2 < list4.Count - 1; num2++)
					{
						text = text + list4[num2] + GetIconFacebook.GetNumber(matchCollection[num].Groups[1].Value);
					}
					text += list4[list4.Count - 1];
					input = text;
					text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				}
			}
			catch
			{
			}
			return input;
		}

		// Token: 0x04001B15 RID: 6933
		private static string icon1 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VDBWdmNsZHRaSFZsYm1SMVRsZHNRbHBzUWtSYWJURktWV3BuTkZOcGRGcGhSelUyWkRJME1XRlZXbTFWUlU1dFlsVnNTMDlFYUV0TE1uUjJUVE53TTJKcVZuQlRNbHBSVVRKYWRGTllaelJQUlc5eVYxZHNXV1Z1WkhWT1YyeFJXbXhDUkZwdE1VcE5WR2MwVTJsMFdtSlZhRFprTWpReFlWWm9iVlZGVG0xaVZYQnpUMFJvUzBzeGJIUmlibkF6WW1wYVZGZEhXbEZSTWxwMFZFVTBORTlGYjNKWGJXTjZaVzVrZFU1WGJFbGFiRUpFV20weFNtRkVaelJUYVhSYVlsUk9ObVF5TkRGaFYxSnRWVVZPYldKVmNEUlBSR2hMU3pGc2NFMHpjRE5pYWxwVVlUSmFVVkV5V25kVGF6UTBUMFZ2Y2xkWGNIVmxibVIxVG14T1UxcHNRa1JhYlRGTFUycG5ORk5wZEdGYU1XZzJZVmN4VFdKdVdqRlRWR3MwVDBWdmNsZFhOWFZsYm1SMVRsZHNWbHBzUWtSYWJURkxWMnBuTkZOcGRGcGhlazQyWkRJME1XRlhiRzFWUlU1dFlsVjBTMDlFYUV0TE1XeDVWMGh3TTJKcVZuQmFiVnBSVVRKYWRGTXdORFJQUlc5eVYxaEdXV1Z1WkhWT1YyeDVXbXhDUkZwdE1VdFdhbWMwVTJsMGNtSkZhRFprTWpReFlsVldiVlZGVG0xaVZYUlRUMFJvUzBzeGJIWlRTSEF6WW1wV2NHRkhXbEZSTWxwMFZFWnZORTlGYjNKaE1uUkpaVzVrZFU1WGJGSmFiRUpFV20weFMxSnFaelJUYVhSYVkycE9ObVF5TkRGaFdHeHRWVVZPYldKVmRHdFBSR2hMU3pGc2VGTkljRE5pYWxad1pESmFVVkV5V25SVVJWazBUMFZ2Y2xkWVJuVmxibVIxVGxkcmQxcHNRa1JhYlRGTVpVUm5ORk5wZEhKalJtZzJaREkwTWxVeU5XMVZSVTV0WTBWd1MwOUVhRXRMTVd3d1RUTndNMkpxV2xSV2JWcFJVVEphZEZSR1dUUlBSVzl5WVRJNWRXVnVaSFZPYkU1dVdteENSRnB1UWt4U2FtYzBVMmwwVTJScVRqWmtNalF4VW5wV2JWVkZUbTFoTWtwM1QwUm9TMHN4U2pGTk0zQXpZbXBXVEZGWFdsRlJNbHB5V1dwRk5FOUZiM0pWYmxwMVpXNWtkVTVzVGxoYWJFSkVXbTEwZUdKRVp6UlRhWFJRV2pOak9WQlJQVDA9"))))))));

		// Token: 0x04001B16 RID: 6934
		private static string icon2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VGtoQ2RHSkVZek5oVmtKdFZEQjBhMk5GT0hKT1IyOTZaVzVrZFU1VmRHbGFiRUpFV20xMGQyTkVaelJUYVhSVVlsWm9ObVF5TkRGVE1rNXRWVVZPYldKSVJsTlBSR2hMU3pGT2MySnVjRE5pYWxaTVdrZGFVVkV5V25KalJrazBUa2hCZVdGcVl6TmhWa0p0VlVWT2JXRXpRbGRQUkdoTFN6Rk9kV0p1Y0ROaWFsWk1Wa2RhVVZFeVduSmpSMUUwVDBWdmNsVXlNVWxsYm1SMVRsVjBiVnBzUWtSYWJYUjJaVVJuTkZOcGRGUmhWRTQyWkRJME1WSXdWbTFWUlU1dFlUSTVVMDlFYUV0TE1VNXhWMGh3TTJKcVZsQk1NbHBSVVRKYWNXSXdXVFJQUlc5eVZXMHhXV1Z1WkhWT1ZXUlpXbXhDUkZwdGRHRmpSR2MwVTJsMFUySkdhRFprTWpReFVqRnNiVlZGVG0xaGJrbDRUMFJvUzBzeFNuUlRTSEF6WW1wV1NGWXlXbEZSTWxweVdWVkpORTlGYjNKVmJUbFpaVzVrZFU1VlpIQmFiRUpFV20xMFlVOVVaelJUYVhSVFltMDFObVF5TkRGU01VNXRWVVZPYldGdVJuTlBSR2hMU3pBNWNrMHpjRE5pYWxaSVZXMWFVRk15U25KYVUzTXdZV3BPTm1ReU5ERlNNVkp0VlVWT2JXSkhTbWxrYmxaS1QxUm5ORk5wZEU1YU1qVTJaREkwTVZJeVNtMVZSVTV0WVRGdmVFOUVhRXRMTVVwMVUwaHdNMkpxVmt4UFIxcFJVVEphY1dORmJ6UlBSVzl5V1cxd2JFdDZVbkZOTTNBelltcFdNVlV5V2xGUk1scHhZMVJGTkU5RmIzSlVNMEoxWlc1a2RVNUVXblphYkVKRVdtNUNUV0pFWnpSVGFYUlFZVmMxTm1ReU5EQk9hM0J0VlVWT2JXRnRPVzlQUkdoTFN6QTVkMDB6Y0ROaWFsRXlUVEphVVZFeVduRmpia0UwVDBWdmNsUXpWa2xsYm1SMVRrUlpNMXBzUWtSYWJrSmFVbXBuTkZOcGRGQmtWbWcyWkRJME1FNXRkRzFWUlU1dFlXNUtWMDlFYUV0TE1Ea3dZbTV3TTJKcVVUSlBSMXBRVXpKR01sZEljRE5pYWxGeVVWZGFVVkV5V25GT1IyYzBUa2hDZUVzeVdsRlJNbHB4VGxWSk5FOUZiM0pWUjJ4WlpXNWtkVTVFV2pSYWJFSkVXbTF3ZVU1VVp6UlRhWFJSWkZWb05tUXlOREJMTVZKdFZVVk9iV0ZxVVRWUFJHaExTekZDY2xkSWNETmlhbEZ5VlRKYVVWRXlXbmRYVmxrMFRraENNVTVFWXpOaFZrSnRWVVZPYldGdVNUVlBSR2hMU3pKNGNHSnVjRE5pYWxwWVZFZGFVRk15U25wTk0zQXpZbXBSTW1WdFdsRlJNbHB4VGpKM05FOUZiM0pVTWpoNlpXNWtkVTVFV2pKYWJFSkVXbTB4ZVZacVp6UlRhWFJRWWtoVmNrNUhiM3BsYm1SMVRrTjBSMXBzUWtSYWJrSmFXa1JuTkZOcGRITmhWV2cyWkRJME1sWXdjRzFWUlU1dFlXcFNXbEJSUFQwPQ=="))))))));

		// Token: 0x04001B17 RID: 6935
		private static string icon3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VDBWdmNsUnRiM3BsYm1SMVRrUktVRnBzUWtSYWJYQmhVV3BuTkZOcGRFOWhWelUyWkRJME1FMXJlRzFWUlU1dFlXeHNORTlFYUV0TE1EVndWMGh3TTJKcVVYbFRSMXBSVVRKYWNWZHJORFJQUlc5eVZHMXNTV1Z1WkhWT2JHUnJXbXhDUkZwdVFtRlNhbWMwVTJsMFQyRnNhRFprTWpRd1RXeE9iVlZGVG0xaGJIQkhUMFJvUzBzd05XOWlibkF6WW1wYVdGVXlXbEZSTWxwM1YyeFpORTlGYjNKVVdGSjFaVzVrZFU1SWF6VmFiRUpFV20xd1dsWnFaelJUYVhSellrVm9ObVF5TkRCTmJXUnRWVVZPYldGcmVFTlBSR2hMU3pKNGRWTkljRE5pYWxGNVpHMWFVVkV5V25kWGEwazBUMFZ2Y2xSdE5YVmxibVIxVG14a1dGcHNRa1JhYmtFd1VXcG5ORk5wZEhOaVZ6VTJaREkwTUUxdWNHMVZSVTV0WTBad1QwOUVhRXRMTURWM1UwaHdNMkpxVVhsWFIxcFJVVEphY1Zkc2J6UlBSVzl5VkcxNFdXVnVaSFZPU0d3d1dteENSRnB0Y0dGVmFtYzBVMmwwVDJKcVRqWmtNalF5VmpGd2JWVkZUbTFoYTNNeFQwUm9TMHN3TVhsTk0zQXpZbXBhV0ZkSFdsRlJNbHAzVjIxbk5FOUZiM0pVYlRWWlpXNWtkVTVFU21wYWJFSkVXbTF3YVZOcVp6UlRhWFJQWW5wT05tUXlOREJOYm1odFZVVk9iV0ZzY0RCUFJHaExTekExZEdKdWNETmlhbEY1VjIxYVVWRXlXbkZYYldjMFQwVnZjbFJ0T1hWbGJtUjFUa1JLYjFwc1FrUmFiWEJvV2tSbk5GTnBkRTlqVldnMlpESTBNRTF0TVcxVlJVNXRZMFp2TVU5RWFFdExNRFY2VTBod00ySnFVVEpSTWxwUlVUSmFjVmxVVlRSUFJXOXlWRzVLV1dWdVpIVk9SRXB6V214Q1JGcHRjR2hsUkdjMFUybDBUMk5VVGpaa01qUXdUV2s1YlZWRlRtMWhiVVp6VDBSb1Mwc3dOWGhpYm5BelltcFJlVTlIV2xGUk1scDNWMjVSTkU1SVFuQldiVnBSVVRKYWNWbHNXVFJQUlc5eVZHNVNkV1Z1WkhWT1JFa3lXbXhDUkZwdGNHbGtSR2MwVTJsMGMxb3lOVFprTWpRd1RXcE9iVlZGVG0xalJteFBUMFJvUzBzd05URlRTSEF6WW1wUmVVNVhXbEZSTWxweFdXcFZORTlGYjNKaVIyaEpaVzVrZFU1RVNYZGFiRUpFV20xd2FVMUVNRDA9"))))))));

		// Token: 0x04001B18 RID: 6936
		private static string icon4 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VDBWdmNsZFlWblZsYm1SMVRsZHJNRnBzUWtSYWJURk5Za1JuTkZOcGRGcGtWRTQyWkRJME1XRlVhRzFWUlU1dFlsVjNlRTlFYUV0TE1YQnVVMGh3TTJKcVZuQk1NbHBSVVRKYWRGUkVWVFJQUlc5eVZWaE9XV1Z1WkhWT1ZVMTVXbXhDUkZwdGRFMVJhbWMwVTJsMFVtTnNhRFprTWpReFVYcFdiVlZGVG0xalJ6bDNUMFJvUzBzeFJqRk5NM0F6WW1wV1JFOUhXbEZSTWxweVV6Sm5ORTlGYjNKVldFbDZaVzVrZFU1dFJrTmFiRUpFV20xMFRFNVVaelJUYVhSU1lrUk9ObVF5TkRGUmVrNXRWVVZPYldFd2QzaFBSR2hMU3pGR01WTkljRE5pYWxaRVRWZGFVVkV5V25SWFYyYzBUMFZ2Y2xkdGJGbGxibVIxVGxjeFRGcHNRa1JhYmtKMlRWUm5ORk5wZEZKa1Z6VTJaREkwTVZFeFNtMVZSVTV0WVRCd1EwOUVhRXRMTVVaeFRUTndNMkpxVmtSTlIxcFJVVEphZDJJeFNUUlBSVzl5WWxkd1NXVnVaSFZPYlVaUldteENSRnB1UW5aV2FtYzBVMmwwVW1ORmFEWmtNalF4VVRKd2JWVkZUbTFoTUhSWFQwUm9TMHN4Um5OVFNIQXpZbXBXUkZaSFdsRlJNbHAzWWpBME5FOUZiM0pWV0VKMVpXNWtkVTV0UmtoYWJFSkVXbTVDZGxwRVp6UlRhWFIwWVZab05tUXlOREZXTUhNelRqSnNVVnBzUWtSYWJYUk1Xa1JuTkZOcGRGSmlSbWcyWkRJME1WRXpRbTFWUlU1dFlUQnNiMDlFYUV0TE1VWnZUVE53TTJKcVZrUlJiVnBSVVRKYWNsTlZTVFJQUlc5eVZWaFplbVZ1WkhWT1ZVNVVXbXhDUkZwdGRFdFhhbWMwVTJsMFVtRkhOVFprTWpReFVUQmFiVlZGVG0xaE1HeFBUMFJvUzBzeFJtNWlibkF6WW1wV1JGSlhXbEZSTWxweVUxUlZORTlGYjNKVldFWjFaVzVrZFU1VlRubGFiRUpFV20xMFMyRkVaelJUYVhSU1lWYzFObVF5TkRGUk1teHRWVVZPYldFd2RFTlBSR2hMU3pGR2RVMHpjRE5pYWxaRVlVZGFVVkV5V25KVE0yYzBUMFZ2Y21KWGJFbGxibVIxVGxWT05scHNRa1JhYlhSS1pFUm5ORk5wZEhSaE1XZzJaREkwTVZFeGNHMVZSVTV0WTBoQ1EwOUVhRXRMTVVaMFltNXdNMkpxV21oUlYxcFJVVEphZDJJd2J6UlBSVzl5WWxkd2RXVnVaSFZPVlU1UFdteENSRnB0ZEV0a1JHYzBVMmwwVW1KcmFEWmtNalF4Vm5wTk0wNHliRkZhYkVKRVdtMTRhV0Z1V2pGVFZHczBUMFZ2Y2xWWE5YVmxibVIxVG0xR1RWcHNRa1JhYlhSTFRWUm5ORk5wZEZKaGEyZzJaREkwTVZFemJHMVZSVTV0WVRCc2MwOUVhRXRMTVVZeVdub3dPUT09"))))))));

		// Token: 0x04001B19 RID: 6937
		private static string icon5 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VDBWdmNsUllXa2xsYm1SMVRraHJNRnBzUWtSYWJYQk5ZMFJuTkZOcGRGRmtSMVZ5VGtkdmVtVnVaSFZPU0dzeldteENSRnB0Y0UxYVJHYzBVMmwwVG1SV2FEWmtNalF5VmpCR2JWVkZUbTFoTTBKRFQwUm9TMHN3TVRKaWJuQXpZbXBSTWxSSFdsQlRNV3gwVTBod00ySnFVWGxSVjFwUlVUSmFjVmRWTkRSUFJXOXlWRzFrZFdWdVpIVk9SRXBEV214Q1JGcHRjRTFTYW1jMFUybDBUbVJxVGpaa01qUXdUbXMxYlZWRlRtMWhhM2hYVDBSb1Mwc3dNVEJUU0hBelltcFNOV1Z0V2xGUk1scHhWRVUwTkU5RmIzSlVNbWhKWlc1a2RVNUVTa1phYkVKRVdtMXdTazVVWnpSVGFYUk9ZV3hvTm1ReU5EQmxWa0p0VlVWT2JXRnJjRFJQUkdoTFN6QXhkRTB6Y0ROaWFsSTFWbTFhVVZFeVduRlRiRzgwVDBWdmNsUlhkM3BsYm1SMVRraHNXbHBzUWtSYWJYQkxVbXBuTkZOcGRFNWhNalUyWkRJME1HVldVbTFWUlU1dFlXdHdVMDlFYUV0TE1ERjBZbTV3TTJKcVVqVmFSMXBSVVRKYWNWTnRkelJQUlc5eVZUTkZlbVZ0YkhsWGEwazBUMFZ2Y2xSWE5IcGxiV3gxVXpKbk5FNUlRbmhoUjFwUlVUSmFjMU14V1RSUFJXOXlWVE5DV1dWdGJIUlRWbEl5WkZWck5VOUVhRXRMTURGMVltNXdjR0pWYkVWa2JsWktUMVJuTkZOcGRFNWpSVGh5VGtkdmVtVnRiSFJPUmxrMFQwVnZjbFJZUW14TGVsSnhUVE53TTJKcVVqVmlWR016WVZaQ2JWUXdkRnBhTWxWeVRrZHZlbVZ1WkhWT1NHeDFUbnBrY0ZWSFdsQlRNa3B3Vkhsek1HRnFUalprTWpRd1pWaEJNMDR5YkZGYWJFSkVXbTF3VEdGdVdqRlRWR3MwVDBWdmNsUlhiRWxsYm1SMVRsVjBkVnBzUWtSYWJYUjRWMnBuTUdOSGJFUk9lbVJ3VlVkYVVGTXhiSE5UU0hBelltcFNOVk15V2xGUk1scHhVek5STkU5RmIzSlVXRVoxWlc1a2RVNVZkSFphYXpsTVdrZG9TV1Z1WkhWT1NHeDZXbXM1VEZsdGFFbGxiV3gwVTFaQ01tUlZhelJRVVQwOQ=="))))))));

		// Token: 0x04001B1A RID: 6938
		private static string icon6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VDBWdmNsbFhkM3BsYm1SMVRsaEdWMXBzUWtSYWJURjNZa1JuTkZOcGRHaGhhMmcyWkRJME1XTlZPVzFWUlU1dFlXcFJNVTlFYUV0TE1rWnlUVE53TTJKcVZuaFZiVnBSVVRKYWRHTkZielJQUlc5eVdWZDBTV1Z1WkhWT1dFWm9XbXhDUkZwdE1YZGtSR2MwVTJsMGFHSnJhRFprTWpReFpGUkNiVlZGVG0xaVdFcExUMFJvUzBzeVNqQlhTSEF6WW1wUmNsUnRXbEZSTWxwMFkwZG5ORTlGYjNKWlYzaDFaVzVrZFU1WVJrOWFiRUpFV20weGQxVnFaelJUYVhSb1kxVm9ObVF5TkRGVGVscHRWREIwYW1GVmFEWmtNalF4WkZoS2JWVkZUbTFpVkZvMFQwUm9TMHN5U25oWFNIQXpZbXBXZUZGdFdsRlJNbHAwWWpCSk5FOUZiM0paYms1SlpXNWtkVTVZUm05YWJFSkVXbTB4ZUZGcVp6UlRhWFJvWW1wT05tUXlOREZqVlZKdFZVVk9iV0pYT1RCUFJHaExTekpHZFdKdWNETmlhbFo0V2tkYVVWRXlXblJpTVVrMFQwVnZjbGxYYUZsbGJtUjFUbGhHU2xwc1FrUmFiVEYyVTJwbk5GTnBkR2hoUnpVMlpESTBNV05WZEcxVlJVNXRZbGM1YTA5RWFFdExNa1p3VjBod00ySnFWakZOYlZwUVV6SktNRmRJY0ROaWFsWXhZa2RhVVZFeVduUmpWa2swVDBWdmNsbFhPWFZsYld4MFRqRkpORTlGYjNKWmJrMTZaVzFzZEdORk5EUlBSVzl5V1ZoQmVtVnRiSFJPZWtVMFQwVnZjbGxYYjNwbGJtUjFUbGhHZEZwc1FrUmFiVEY0Vm1wbk5GTnBkR2xpZWs0MlpESTBNV1JYZEcxVlJVNXRZV3BXYTA5RWFFdExNVUo1VjBod00ySnFVWEphTWxwUlVUSmFjVTVyV1RSUFJXOXlWVWN4U1dWdVpIVk9RM1JvV214Q1JGcHRiekpUYW1jMFUybDBVV05yYURaa01qUXdTekowYlZWRlRtMWhhbHBQVDBSb1Mwc3hRbmRYU0hBelltcFJjbUpYV2xGUk1scHhUbTVCTkU5RmIzSlZTRVY2Wlc1a2RVNURkSFphYkVKRVdtMXZNbUpFWnpSVGFYUlJZbFJPTm1ReU5EQkxNMlJ0VlVWT2JXRnFXVFZQUkdoTFN6RkNkVXQ1Y3pCaGFrNDJZVmN3TW1ORVp6UlRhWFJVWVRJMU5tUXlOREZXTURGdFZVVk9iV0pHYTNoUFJHaExTekZhY0UwemNIQmlWRnB6VDBSb1Mwc3hhREpUU0hBelltcFdiRXd5V2xGUk1scHpUbnBGTkU5RmIzSlhTRloxWlc1a2RVNUVXbmhhYkVKRVdtMXdlRkZxWnpSVGFYUlFZakZvTm1ReU5EQk9iV3h0VkRCMGFXTXlOVFpoVnpBelVtcG5ORk5wZEZGaVJ6VTJaREkwTUVzeVVtMVZSVTV0WVdwV1YwOUVVbmRrVkZwdFZVVk9iV0pFWXpGUFJGSjNaRmhrYlZWRlRtMWhhbFpUVDBSb1Mwc3hhREZOTTNBelltcFNOVlJIV2xGUk1scHhUbFJWTkU5RmIzSlZSelZKWlc1a2RVNUliRWRhYkVKRVdtMXdTbFZxWnpSVGFYUlFZVEZvTm1ReU5EQmxWMlJ0VlVWT2JXRnRPV3RQUkdoTFN6QTViMkp1Y0ROaWFsRnlWMjFhVVZFeVduRlRWMUUwVDBWdmNsUlhhSFZsYm1SMVRraHNSVnBzUWtSYWJYQktaVVJuTkZOcGRFNWhWbWcyWkRJME1HVlZTVDA9"))))))));

		// Token: 0x04001B1B RID: 6939
		private static string icon7 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VDBWdmNsWklUbGxsYm1SMVRsVTVOVnBzUWtSYWJYUjVaRVJuTkZOcGRGaGpSbWcyWVZkd1RHRkVaelJUYVhSWVkxVm9ObVF5TkRGWldHaHRWVVZPYldKSVNrdFBSR2hMU3pGYU1WZEljRE5pYWxFeVpGZGFVVkV5V25KamFrVTBUMFZ2Y2xVelduVmxibVIxVGxWemRscHNRa1JhYlhNd1VXcG5ORk5wZEZWa2EyZzJaREkwTVZSNlRtMVZSVTV0WVhwa2IwOUVhRXRMTVZJeFYwaHdNMkpxVVRKaVIxcFJVVEphY2s1NlJUUlBSVzl5VkRJMWRXVnVaSFZPUkZwNldteENSRnB0Y3pGT1ZHY3dZMGRzVUZwc1FrUmFiWE14VDFSbk5GTnBkRlZpTUdnMlpESTBNVlI2V20xVlJVNXRZWHBrTUU5RWFFdExNRGwwVjBod00ySnFVVEpaVjFwUlVUSmFjV05JVVRSUFJXOXlWa2M1V1dWdVpIVk9WVGx3V214Q1JGcHRjekpVYW1jMFUybDBWbUpGYURaa01qUXhVekpvYlZWRlRtMWlSMFUxVDBSb1Mwc3hWbmRpYm5BelltcFdWRlJIV2xGUk1scHpVMWhuTkU1SE9UVlpWMXBRVXpGQ2VsZEljSEJoYW1STFQwUlNka3N6WkcxVlJVNXRZa2RLUTA5RVVuWmxWMHB0VkRCMFVXTjZUalprTWpReFZUTldiVlZGVG0xaE1qZ3hUMFJvUzBzd09YcGlibkF6WW1wUk1tUXlXbEZSTWxweVkyMW5ORTlGYjNKVk0xSlpaVzVrZFU1VmMzZGFiRUpFV20xMGVWZHFaelJUYVhSVVpFUk9ObVF5TkRGVE0yUnRWVVZPYldFelNrOVBSR2hMU3pGT2VtSnVjRE5pYWxaTVpVZGFVRk15Um5OaWJuQXpZbXBXVkdOdFdsRlJNbHB5WTFVME5FOUZiM0pXV0VaMVpXNWtkVTVYVm05YWF6bE1XVmQ0U1dWdVpIVk9XRlp2V214Q1JGcHRNWGhsUkdjd1kwaEdNMXByT1V4WldFNVpaVzVrZFU1WFZtcE9lbVJ3VlVkYVVWRXlXbk5UTWxFMFQwVnZjbFpZUmtsbGJXeDBZMFZ2TkU5RmIzSlpiVGxKWlcxc2RFNUVhelJQUlc5eVZsaEdXV1Z0YkhSalIzYzBUa2hDTVZaSFdsRlJNbHB5WWpKbk5FOUZiM0pVVnpsWlpXNWtkVTVWZEV4YWJFSkVXbTEwZG1KRVp6QmpTRVpaV214Q1JGcHRlRXhsUkdjMFUybDBWbU5zYURaa01qUXhZMU01YlZWRlRtMWlWRkpIVDBSb1Mwc3lSakpYU0hBelltcFdNVlF5V2xGUk1scHpVMnRaTkU5RmIzSlhSelZaWlc1a2RVNVlSbmhhYkVKRVdtMHdNR1JFWnpSVGFYUnBZV3BPTm1ReU5ERlpWR2h0VlVWT2JXRnFaSGRQUkdoTFN6Rm9jbGRJY0ROaWFsWXhZVmRhVVZFeVduTlphelEwVDBWdmNsVklTblZsYm1SMVRrUmFVVnBzUWtSYWJYQjJUbFJuTkZOcGRGQmhNR2cyWkRJME1FNXVTbTFWUlU1dFlXNUJkbVJ1VmtwUFZHYzBVMmwwVUZvd2FEWmtNalF3VG14bk0wNHliRkZhYkVKRVdtMXpNazlVWnpCalNHeExXbXhDUkZwdGN6SmlSR2MwVTJsMFZXTlZhRFprTWpReFZESTFiVlZGVG0xaGVscGhUMFJvUzBzeFVuaGlibkF6WW1wV1VHTnRXbEZSTWxweVRtNW5ORTlGYjNKV1NFcFpaVzVrZFU1Vk9URmFiRUpFV20xek1sWnFaelJUYVhSVlkwVm9ObVF5TkRGVU1rNXRWVVZPYldGNlVrOVBSR2hMU3pGU2IxTkljRE5pYWxaUVZXMWFVVkV5V25KT1NFRTBUMFZ2Y2xaSGJFbGxibVIxVGxVNVMxcHNRa1JhYlhjeFUycG5ORk5wZEZWaFJtZzJaREkwTVZRd1pHMVZSVTV0WWtSV1QwOUVhRXRMTVZKdlRUTndNMkpxVm14U1IxcFJVVEphYzA0d05EUlBSVzl5VjBkb1NXVnVaSFZPVlRsTldteENSRnB0Y3pCU2FtYzBVMmwwVlZveU5UWmtNalF4V2xWT2JWVkZUbTFoZWxaUFQwUm9TMHN4VW5OVFNIQXpZbXBXVUZVeVdsRlJNbHB5VGxaWk5FOUZiM0pXUjNkNlpXNWtkVTVWT1ZwYWJFSkVXbTF6TVdKRVp6UlRhWFJWWWxjMU5tUXlOREZVTVdSdFZVVk9iV0pFVlRGUFJHaExTekZTZWxOSWNETmlhbFpRV2tkYVVGTXlUbkZOTTNBelltcFdhRk15V2xGUk1scHpZbnBGTkU5RmIzSldNbkJKWlc1a2RVNVhSazFhYXpsTVdUSjBkV1Z1WkhWT1ZUbE9XbXhDUkZwdGN6Qk5WR2MwVTJsMFZXRnROVFprTWpReFdWVm9iVlZGVG0xaVJYQmhUMFJvUzBzeFFqQk5NM0F6WW1wV1ZGZEhXbEZSTWxwelUxUkZORTlGYjNKV1YzQjFaVzVrZFU1Vk9WSmFiRUpFV20xek1FOVVaekJqU0d4RVdteENSRnB0ZUV0VGFtYzBVMmwwVm1GNlRqWmtNalF4VlRGQ2JWVkZUbTFpUlhCQ1VGRTlQUT09"))))))));

		// Token: 0x04001B1C RID: 6940
		private static string icon8 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VDBWdmNsZHRaSFZsYm1SMVRsZHNRbHBzUWtSYWJURktWV3BuTkZOcGRGcGhSelUyWkRJME1XRlZXbTFWUlU1dFlsVnNTMDlFYUV0TE1uUjJUVE53TTJKcVZuQlRNbHBSVVRKYWRGTllaelJQUlc5eVYxZHNXV1Z1WkhWT1YyeFBXbXhDUkZwdE1VdGhSR2MwVTJsMFdtSkVUalprTWpReFlWWndiVlZGVG0xaVZYQjNUMFJvUzBzeWRITk5NM0F6WW1wV2NHVnRXbEZSTWxwMFYxVTBORTlGYjNKWFZ6QjZaVzVrZFU1WGJHdGFiRUpFV20weFMyVkVaelJUYVhSYVlWUk9ObVF5TkRKVk1uUnRWVVZPYldORmNFOVBSR2hMU3pGc2NWcDZNRGs9"))))))));

		// Token: 0x04001B1D RID: 6941
		private static string number = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZVNGNrNUhiM0pUTUZKMlRUTmtORTU2WkhCVlJGSjJWREp3YlZKRmVESmtWV3QyWVZkak1sUnFhRTVMZVhNd1lXbDBURkpIT0hwa2VrRXpUakpzVVU1SE9WQmhiVnBGVjBoYU1WTlRPWEJhZWxwUFQwVTFNVXQ2VW5GTE1IUkZZbnBPTTAxNll6TmhWa0V3WWpBNWNWcHJVbkZrYmxaS1RESnNiazVyTkRSVU1sVnlUa2R2Y2xNd1VuWmtlakE1"))))))));

		// Token: 0x04001B1E RID: 6942
		private static List<string> lstKey = new List<string>
		{
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NtVkdhRkpRVkRBOQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NtVldhRkpRVkRBOQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NtVnNhRkpRVkRBOQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMUdhRkpRVkRBOQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMVdhRkpRVkRBOQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMXNhRkpRVkRBOQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMHhhRkpRVkRBOQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrNUdhRkpRVkRBOQ==")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UxcEJQVDA9")))))))),
			Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1UxcEJQVDA9"))))))))
		};
	}
}
