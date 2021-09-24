using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ConversionBack;
using IWshRuntimeLibrary;
using maxcare;
using Microsoft.CSharp.RuntimeBinder;

namespace MCommon
{
	// Token: 0x0200003B RID: 59
	public class Common
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x00014450 File Offset: 0x00012650
		public static double ConvertDatetimeToTimestamp(DateTime value)
		{
			return (value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000144AC File Offset: 0x000126AC
		public static string ConvertListParamsToString(object lstParams)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				foreach (PropertyInfo propertyInfo in lstParams.GetType().GetProperties())
				{
					string str = text;
					object value = propertyInfo.GetValue(lstParams);
					text = str + ((value != null) ? value.ToString() : null) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9"))))))));
				}
				text = text.TrimEnd(new char[]
				{
					','
				});
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000145EC File Offset: 0x000127EC
		public static string GetFbDtag(string cookie, string useragent, string proxy, int typeProxy)
		{
			string result;
			try
			{
				string input = new RequestXNet(cookie, useragent, proxy, typeProxy).RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNNRlJITVdGaFJtdDVWbTFzYVUxcWJIbFVSekZQWkcxS1ZFOVhPV0ZXTTJnelZFaGpPVkJSUFQwPQ==")))))))));
				result = Regex.Match(input, Common.Base64Decode(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGamVGVXdNVWhVV0d4aFVqRndZVlpxU2s5alJsRjVUbGh3YUZZeFNrbFVNV2hMV1ZaYU5sVnVRbFZOYlhoTFdXcENOR05IU2pWUFZYaFdUVWR6TlE9PQ==")))))))))).Groups[1].Value;
			}
			catch
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			return result;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00014738 File Offset: 0x00012938
		public static List<string> GetIntersectItemBetweenTwoList(List<string> lstRoot, List<string> lstCompare)
		{
			List<string> result = new List<string>();
			try
			{
				result = lstRoot.Intersect(lstCompare).ToList<string>();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00014794 File Offset: 0x00012994
		public static List<string> GetExceptItemBetweenTwoList(List<string> lstRoot, List<string> lstCompare)
		{
			List<string> result = new List<string>();
			try
			{
				result = lstRoot.Except(lstCompare).ToList<string>();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000147F0 File Offset: 0x000129F0
		private static void Enable(string interfaceName)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFYwMUhUWGxhZWpBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1VMUdjRmxUYlRGYVZqQTFjMU5WYUU5aVIxSkVVVzVDYVdKc1NuTlpNakZoWVVacmVWWlhaRXBhZWpBNQ==")))))))) + interfaceName + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkc1EySkhTblJTYld4cFVqRlZPUT09")))))))));
			new Process
			{
				StartInfo = startInfo
			}.Start();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000148F4 File Offset: 0x00012AF4
		private static void Disable(string interfaceName)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweFYwMUhUWGxhZWpBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1VMUdjRmxUYlRGYVZqQTFjMU5WYUU5aVIxSkVVVzVDYVdKc1NuTlpNakZoWVVacmVWWlhaRXBhZWpBNQ==")))))))) + interfaceName + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkc1EyRXlSbGxVYldoYVlsaG9jdz09")))))))));
			new Process
			{
				StartInfo = startInfo
			}.Start();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000149F8 File Offset: 0x00012BF8
		public static string GetDateCreatFolder(string pathFolder)
		{
			try
			{
				return Directory.GetCreationTime(pathFolder).ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xab2MwNVhWbFJQVlRWVlZYcHNjbGRyVGtOVFZrNUZZMGhTYVZaSVFqWlpNMk01VUZFOVBRPT0=")))))))));
			}
			catch (Exception)
			{
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00014AD4 File Offset: 0x00012CD4
		public static string GetDateCreatFile(string pathFile)
		{
			try
			{
				return File.GetCreationTime(pathFile).ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xab2MwNVhWbFJQVlRWVlZYcHNjbGRyVGtOVFZrNUZZMGhTYVZaSVFqWlpNMk01VUZFOVBRPT0=")))))))));
			}
			catch (Exception)
			{
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00014BB0 File Offset: 0x00012DB0
		public static string GetRandomItemFromList(ref List<string> lst, Random rd)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				text = lst[rd.Next(0, lst.Count)];
				lst.Remove(text);
			}
			catch (Exception)
			{
				throw;
			}
			return text;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00014C48 File Offset: 0x00012E48
		public static string CheckAccountHotmail(string username, string password, string imap = "")
		{
			object[] parameters = new object[]
			{
				username,
				password,
				imap
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(164256, 2880, 224, parameters);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00014CB0 File Offset: 0x00012EB0
		public static string CheckAccountEmail(string username, string password, string imap)
		{
			object[] parameters = new object[]
			{
				username,
				password,
				imap
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(167136, 896, 225, parameters);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00014D18 File Offset: 0x00012F18
		public static string ConvertSecondsToTime(int seconds)
		{
			string result;
			try
			{
				TimeSpan timeSpan = TimeSpan.FromSeconds((double)seconds);
				bool flag = seconds < 60;
				if (flag)
				{
					result = TimeSpan.FromSeconds((double)seconds).ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwT1RsQlJQVDA9")))))))));
				}
				else
				{
					bool flag2 = seconds < 3600;
					if (flag2)
					{
						result = TimeSpan.FromSeconds((double)seconds).ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4amVGa3dPWFZVYm04OQ==")))))))));
					}
					else
					{
						result = TimeSpan.FromSeconds((double)seconds).ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWa2Ixa3dPWFJOV0ZKWlVraENObGt6WXpsUVVUMDk=")))))))));
					}
				}
			}
			catch
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			return result;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00014EF0 File Offset: 0x000130F0
		public static bool CreateShortcutChrome(string shortcutName, string shortcutPath, string profilePath, string icon = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico", string targetFileLocation = "\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\"")
		{
			bool result = false;
			try
			{
				Common.CreateShortcut(shortcutName, shortcutPath, targetFileLocation, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaTmVFMVhUWGxXYm14TlZqRktiMXBGWkVaa1JuQklZa2hzVVZVd2F6az0=")))))))) + profilePath + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), targetFileLocation.Substring(0, targetFileLocation.LastIndexOf(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))))), icon);
				result = true;
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSS2IyVlhTWGxOVjNoTllUQTFOVmRzWkVkTlJuQlhWRzA1YVUwd2IzZFhWRTVYVFVWMFFsQlVNRDA9")))))))),
					shortcutName,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))),
					shortcutPath,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))),
					targetFileLocation,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGb1QySkhTa2hXYlhCclVWUXdPUT09"))))))))
				}));
			}
			return result;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000151C8 File Offset: 0x000133C8
		public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation, string arg, string WorkingDirectory = "C:\\Program Files (x86)\\Google\\Chrome\\Application", string icon = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico")
		{
			string pathLink = Path.Combine(shortcutPath, shortcutName + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeE5HUlhSak5RVkRBOQ==")))))))));
			WshShell wshShell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vkc1d1MxSkZNWEZWYTFaVFVrWldNRlZyVW1wa01VWlVUVVJDVG1WdGFFUlVSbEp2VVdzMVJWTllVbEJXUjJOM1ZGZHdVMUV3T1VWaFJVcFRZVEJyTUE9PQ==")))))))))));
			if (Common.<>o__15.<>p__0 == null)
			{
				Common.<>o__15.<>p__0 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(Common)));
			}
			IWshShortcut wshShortcut = Common.<>o__15.<>p__0.Target(Common.<>o__15.<>p__0, wshShell.CreateShortcut(pathLink));
			wshShortcut.Description = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSS2IyUnRUblZWYlhCclYwWkdibFZVU205bFYwbDVUVmQ0U2xKVVJrdFdSMnhEVmtkSmVWZHFRbXROYTFvMVYyeEZPVkJSUFQwPQ=="))))))));
			wshShortcut.WorkingDirectory = WorkingDirectory;
			wshShortcut.IconLocation = icon;
			wshShortcut.TargetPath = targetFileLocation;
			wshShortcut.Arguments = arg;
			wshShortcut.Save();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00015368 File Offset: 0x00013568
		public static void ShowMessageBox(object s, int type)
		{
			switch (type)
			{
			case 1:
				MessageBox.Show(s.ToString(), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk=")))))))), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			case 2:
				MessageBox.Show(s.ToString(), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk=")))))))), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				break;
			case 3:
				MessageBox.Show(s.ToString(), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk=")))))))), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000154D0 File Offset: 0x000136D0
		public static void SetStatusDataGridView(DataGridView dgv, int row, string colName, object status)
		{
			try
			{
				Application.DoEvents();
				dgv.Invoke(new MethodInvoker(delegate()
				{
					dgv.Rows[row].Cells[colName].Value = status;
				}));
			}
			catch
			{
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0001555C File Offset: 0x0001375C
		public static int CompareImage(string pathFile1, string pathFile2)
		{
			int result = 0;
			try
			{
				List<bool> hash = Common.GetHash(new Bitmap(pathFile1));
				List<bool> hash2 = Common.GetHash(new Bitmap(pathFile1));
				result = hash.Zip(hash2, (bool i, bool j) => i == j).Count((bool eq) => eq);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00015614 File Offset: 0x00013814
		public static bool SetTextToClipboard(string content)
		{
			bool isSuccess = false;
			try
			{
				Thread thread = new Thread(delegate()
				{
					try
					{
						Clipboard.SetText(content);
						isSuccess = true;
					}
					catch
					{
					}
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				thread.Join();
			}
			catch
			{
			}
			return isSuccess;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000156A4 File Offset: 0x000138A4
		public static List<bool> GetHash(Bitmap bmpSource)
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

		// Token: 0x060001B5 RID: 437 RVA: 0x0001574C File Offset: 0x0001394C
		public static List<string> CloneList(List<string> lstFrom)
		{
			List<string> list = new List<string>();
			try
			{
				for (int i = 0; i < lstFrom.Count; i++)
				{
					list.Add(lstFrom[i]);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000157D0 File Offset: 0x000139D0
		public static string SpinText(string text, Random rand)
		{
			int num = -1;
			char[] anyOf = new char[]
			{
				'{',
				'}'
			};
			text += Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V20xak9WQlJQVDA9"))))))));
			do
			{
				int num2 = num;
				num = -1;
				while ((num2 = text.IndexOf('{', num2 + 1)) != -1)
				{
					int num3 = num2;
					while ((num3 = text.IndexOfAny(anyOf, num3 + 1)) != -1 && text[num3] != '}')
					{
						bool flag = num == -1;
						if (flag)
						{
							num = num2;
						}
						num2 = num3;
					}
					bool flag2 = num3 != -1;
					if (flag2)
					{
						string[] array = text.Substring(num2 + 1, num3 - 1 - (num2 + 1 - 1)).Split(new char[]
						{
							'|'
						});
						text = text.Remove(num2, num3 - (num2 - 1)).Insert(num2, array[rand.Next(array.Length)]);
					}
				}
			}
			while (num-- != -1);
			return text.Remove(text.Length - 1);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000159E0 File Offset: 0x00013BE0
		public static void OpenFileAndPressData(string linkPathFile, string title = "Nhập danh sách Uid cần clone", string status = "Danh sách Uid", string footer = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})")
		{
			try
			{
				bool flag = !File.Exists(linkPathFile);
				if (flag)
				{
					Common.CreateFile(linkPathFile);
				}
				Common.ShowForm(new fNhapDuLieu1(linkPathFile, title, status, footer, null));
			}
			catch
			{
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00015A60 File Offset: 0x00013C60
		public static DateTime ConvertTimeStampToDateTime(double timestamp)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			result = result.AddSeconds(timestamp).ToLocalTime();
			return result;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00015ABC File Offset: 0x00013CBC
		public static Form GetFormByName(string name, string para)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			foreach (Type type in executingAssembly.GetTypes())
			{
				bool flag = type.BaseType != null && type.BaseType.FullName == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxST2MyVnRVa2hXYmxKTllrZFNkMWx0TVZOa2JWRjZWRmhXVTJKVWJEVlpiR2hPWkZaS2RFOVliR2xWVkRBNQ=="))))))));
				if (flag)
				{
					bool flag2 = type.FullName == name;
					if (flag2)
					{
						return Activator.CreateInstance(Type.GetType(name), new object[]
						{
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))),
							1,
							para
						}) as Form;
					}
				}
			}
			return null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00015C64 File Offset: 0x00013E64
		public static void CreateFile(string pathFile)
		{
			try
			{
				bool flag = !File.Exists(pathFile);
				if (flag)
				{
					File.AppendAllText(pathFile, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00015D08 File Offset: 0x00013F08
		public static void ClearSelectedOnDatagridview(DataGridView dtgv)
		{
			for (int i = 0; i < dtgv.RowCount; i++)
			{
				dtgv.Rows[i].Selected = false;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00015D5C File Offset: 0x00013F5C
		public static void CreateFolder(string pathFolder)
		{
			try
			{
				bool flag = !Directory.Exists(pathFolder);
				if (flag)
				{
					Directory.CreateDirectory(pathFolder);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00015DB8 File Offset: 0x00013FB8
		public static void ShowForm(Form f)
		{
			try
			{
				f.ShowInTaskbar = false;
				f.ShowDialog();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00015E0C File Offset: 0x0001400C
		public static List<int> ShuffleList(List<int> lst)
		{
			int i = lst.Count;
			while (i != 0)
			{
				int index = Base.rd.Next(0, lst.Count);
				i--;
				int value = lst[i];
				lst[i] = lst[index];
				lst[index] = value;
			}
			return lst;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00015EB0 File Offset: 0x000140B0
		public static List<string> ShuffleList(List<string> lst)
		{
			string value = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			int i = lst.Count;
			while (i != 0)
			{
				int index = Base.rd.Next(0, lst.Count);
				i--;
				value = lst[i];
				lst[i] = lst[index];
				lst[index] = value;
			}
			return lst;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00015F94 File Offset: 0x00014194
		public static List<string> RemoveEmptyItems(List<string> lst)
		{
			List<string> list = new List<string>();
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			for (int i = 0; i < lst.Count; i++)
			{
				text = lst[i].Trim();
				bool flag = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					list.Add(text);
				}
			}
			return list;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00016090 File Offset: 0x00014290
		public static string TrimEnd(string text, string value)
		{
			bool flag = !text.EndsWith(value);
			string result;
			if (flag)
			{
				result = text;
			}
			else
			{
				result = text.Remove(text.LastIndexOf(value));
			}
			return result;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000160EC File Offset: 0x000142EC
		public static void SaveDatagridview(DataGridView dgv, string FilePath, char splitChar = '|')
		{
			List<string> list = new List<string>();
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			for (int i = 0; i < dgv.RowCount; i++)
			{
				text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				for (int j = 0; j < dgv.ColumnCount; j++)
				{
					object value = dgv.Rows[i].Cells[j].Value;
					text += ((value == null) ? splitChar.ToString() : (((value != null) ? value.ToString() : null) + splitChar.ToString()));
				}
				text = text.TrimEnd(new char[]
				{
					splitChar
				});
				list.Add(text);
			}
			File.WriteAllLines(FilePath, list);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00016280 File Offset: 0x00014480
		public static void LoadDatagridview(DataGridView dgv, string namePath, char splitChar = '|')
		{
			bool flag = !File.Exists(namePath);
			if (flag)
			{
				Common.CreateFile(namePath);
			}
			List<string> list = File.ReadAllLines(namePath).ToList<string>();
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag2 = list.Count > 0;
			if (flag2)
			{
				for (int i = 0; i < list.Count; i++)
				{
					text = list[i];
					DataGridViewRowCollection rows = dgv.Rows;
					object[] values = text.Split(new char[]
					{
						splitChar
					});
					rows.Add(values);
				}
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00016388 File Offset: 0x00014588
		public static string SelectFolder()
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
				{
					DialogResult dialogResult = folderBrowserDialog.ShowDialog();
					bool flag = dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath);
					if (flag)
					{
						result = folderBrowserDialog.SelectedPath;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00016478 File Offset: 0x00014678
		public static string SelectFile(string title = "Chọn File txt", string typeFile = "txt Files (*.txt)|*.txt|")
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Filter = typeFile + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaa05HTXdiRWhYYmtKcFVqRmFObE5WVG01alZYaHdZak5DYlZFeU9URlRNbU01VUZFOVBRPT0="))))))));
					openFileDialog.InitialDirectory = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZod2QxbDNQVDA9"))))))));
					openFileDialog.Title = title;
					bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
					if (flag)
					{
						result = openFileDialog.FileName;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000165F8 File Offset: 0x000147F8
		public static void KillProcess(string nameProcess)
		{
			try
			{
				foreach (Process process in Process.GetProcessesByName(nameProcess))
				{
					process.Kill();
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00016668 File Offset: 0x00014868
		public static bool CheckBasicString(string text)
		{
			bool result = true;
			foreach (char c in text)
			{
				bool flag = (c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != '.';
				if (flag)
				{
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00016718 File Offset: 0x00014918
		public static string RemoveCharNotLatin(string text)
		{
			string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			foreach (char c in text)
			{
				bool flag = (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
				if (flag)
				{
					text2 += c.ToString();
				}
			}
			return text2;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001680C File Offset: 0x00014A0C
		public static string ConvertToUTF8(string text)
		{
			byte[] bytes = Encoding.Default.GetBytes(text);
			text = Encoding.UTF8.GetString(bytes);
			return text;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0001684C File Offset: 0x00014A4C
		public static bool IsNumber(string pValue)
		{
			bool flag = pValue == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				foreach (char c in pValue)
				{
					bool flag2 = !char.IsDigit(c);
					if (flag2)
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0001691C File Offset: 0x00014B1C
		public static bool IsContainNumber(string pValue)
		{
			foreach (char c in pValue)
			{
				bool flag = char.IsDigit(c);
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00016984 File Offset: 0x00014B84
		public static void ReadHtmlText(string html)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xjMWQwNXJPVlZoZWxaTllsZG5kMWxzWkROUVVUMDk="))))))));
			File.WriteAllText(@string, html);
			Process.Start(@string);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000169EC File Offset: 0x00014BEC
		public static string ReadHTMLCode(string Url)
		{
			string result;
			try
			{
				result = new RequestHttp(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0).RequestGet(Url);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00016B0C File Offset: 0x00014D0C
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

		// Token: 0x060001CF RID: 463 RVA: 0x00016B5C File Offset: 0x00014D5C
		public static string Md5Encode(string text, string type = "X2")
		{
			MD5 md = MD5.Create();
			byte[] array = md.ComputeHash(Encoding.UTF8.GetBytes(text));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString(type));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000053A0 File Offset: 0x000035A0
		public static string Base64Encode(string base64Decoded)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(base64Decoded);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00004374 File Offset: 0x00002574
		public static string Base64Decode(string base64Encoded)
		{
			byte[] bytes = Convert.FromBase64String(base64Encoded);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00016BDC File Offset: 0x00014DDC
		public static string CreateRandomStringNumber(int lengText, Random rd = null)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag = rd == null;
			if (flag)
			{
				rd = new Random();
			}
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaa1MyRnNjRWhXYlRGaFRXMW9kMWxYTVRCak1rcFlUbGhhYWxORldqVlplazVUVFZkU2RWcEVVbXhYUnprelZGWlNTbVZyTlVWV1ZFcFBaVzFqTVZWV1ZrdFNSa3BHVm10a1UwMUhhRXRWTW5Rd1ZGWlNWazVXUWxaU2ExcFVWbFJHVTFac1duTmFSbXhZVm0wNE9RPT0="))))))));
			for (int i = 0; i < lengText; i++)
			{
				text += @string[rd.Next(0, @string.Length)].ToString();
			}
			return text;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00016CEC File Offset: 0x00014EEC
		public static string CreateRandomString(int lengText, Random rd = null)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag = rd == null;
			if (flag)
			{
				rd = new Random();
			}
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaa1MyRnNjRWhXYlRGaFRXMW9kMWxYTVRCak1rcFlUbGhhYWxORldqVlplazVUVFZkU2RWcEVVbXhYUnpnNQ=="))))))));
			for (int i = 0; i < lengText; i++)
			{
				text += @string[rd.Next(0, @string.Length)].ToString();
			}
			return text;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00016E00 File Offset: 0x00015000
		public static string CreateRandomNumber(int leng, Random rd = null)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag = rd == null;
			if (flag)
			{
				rd = new Random();
			}
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZWU1JtVlZNVFpWVkVaUFlXMU5NRlF4UlRsUVVUMDk="))))))));
			for (int i = 0; i < leng; i++)
			{
				text += @string[rd.Next(0, @string.Length)].ToString();
			}
			return text;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00016F14 File Offset: 0x00015114
		public static string RunCMD(string cmd)
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

		// Token: 0x060001D6 RID: 470 RVA: 0x00017084 File Offset: 0x00015284
		public static void DelayTime(double second)
		{
			Application.DoEvents();
			Thread.Sleep(Convert.ToInt32(second * 1000.0));
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000170B4 File Offset: 0x000152B4
		public static string HtmlDecode(string text)
		{
			return WebUtility.HtmlDecode(text);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000170D4 File Offset: 0x000152D4
		public static string HtmlEncode(string text)
		{
			return WebUtility.HtmlEncode(text);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000170F4 File Offset: 0x000152F4
		public static string UrlDecode(string text)
		{
			return WebUtility.UrlDecode(text);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00017114 File Offset: 0x00015314
		public static string UrlEncode(string text)
		{
			return WebUtility.UrlEncode(text);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00017134 File Offset: 0x00015334
		public static Point GetSizeChrome(int column, int row)
		{
			JSON_Settings json_Settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWU1RXMW9OVmxxU1hoaVFUMDk=")))))))), false);
			bool flag = json_Settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tSS2MyRXlVa2hhZWpBOQ==")))))))), 0) == 0;
			if (flag)
			{
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tSS2MyRXlVa2hhZWpBOQ==")))))))), Common.getWidthScreen);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWa1YyTkdiM2xhZWpBOQ==")))))))), Common.getHeightScreen);
				json_Settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			Common.getWidthScreen = json_Settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tSS2MyRXlVa2hhZWpBOQ==")))))))), 0);
			Common.getHeightScreen = json_Settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWa1YyTkdiM2xhZWpBOQ==")))))))), 0);
			int x = Common.getWidthScreen / column + 15;
			int y = Common.getHeightScreen / row + 10;
			return new Point(x, y);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000173CC File Offset: 0x000155CC
		public static Point GetPointFromIndexPosition(int indexPos, int column, int row)
		{
			JSON_Settings json_Settings = new JSON_Settings(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWU1RXMW9OVmxxU1hoaVFUMDk=")))))))), false);
			bool flag = json_Settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tSS2MyRXlVa2hhZWpBOQ==")))))))), 0) == 0;
			if (flag)
			{
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tSS2MyRXlVa2hhZWpBOQ==")))))))), Common.getWidthScreen);
				json_Settings.Update(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWa1YyTkdiM2xhZWpBOQ==")))))))), Common.getHeightScreen);
				json_Settings.Save(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			Common.getWidthScreen = json_Settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tSS2MyRXlVa2hhZWpBOQ==")))))))), 0);
			Common.getHeightScreen = json_Settings.GetValueInt(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWa1YyTkdiM2xhZWpBOQ==")))))))), 0);
			Point result = default(Point);
			while (indexPos >= column * row)
			{
				indexPos -= column * row;
			}
			switch (row)
			{
			case 1:
				result.Y = 0;
				break;
			case 2:
			{
				bool flag2 = indexPos < column;
				if (flag2)
				{
					result.Y = 0;
				}
				else
				{
					bool flag3 = indexPos < column * 2;
					if (flag3)
					{
						int num = indexPos / column;
						result.Y = Common.getHeightScreen / 2;
						indexPos -= column;
					}
				}
				break;
			}
			case 3:
			{
				bool flag4 = indexPos < column;
				if (flag4)
				{
					result.Y = 0;
				}
				else
				{
					bool flag5 = indexPos < column * 2;
					if (flag5)
					{
						result.Y = Common.getHeightScreen / 3;
						indexPos -= column;
					}
					else
					{
						bool flag6 = indexPos < column * 3;
						if (flag6)
						{
							result.Y = Common.getHeightScreen / 3 * 2;
							indexPos -= column * 2;
						}
					}
				}
				break;
			}
			case 4:
			{
				bool flag7 = indexPos < column;
				if (flag7)
				{
					result.Y = 0;
				}
				else
				{
					bool flag8 = indexPos < column * 2;
					if (flag8)
					{
						result.Y = Common.getHeightScreen / 4;
						indexPos -= column;
					}
					else
					{
						bool flag9 = indexPos < column * 3;
						if (flag9)
						{
							result.Y = Common.getHeightScreen / 4 * 2;
							indexPos -= column * 2;
						}
						else
						{
							bool flag10 = indexPos < column * 4;
							if (flag10)
							{
								result.Y = Common.getHeightScreen / 4 * 3;
								indexPos -= column * 3;
							}
						}
					}
				}
				break;
			}
			case 5:
			{
				bool flag11 = indexPos < column;
				if (flag11)
				{
					result.Y = 0;
				}
				else
				{
					bool flag12 = indexPos < column * 2;
					if (flag12)
					{
						result.Y = Common.getHeightScreen / 5;
						indexPos -= column;
					}
					else
					{
						bool flag13 = indexPos < column * 3;
						if (flag13)
						{
							result.Y = Common.getHeightScreen / 5 * 2;
							indexPos -= column * 2;
						}
						else
						{
							bool flag14 = indexPos < column * 4;
							if (flag14)
							{
								result.Y = Common.getHeightScreen / 5 * 3;
								indexPos -= column * 3;
							}
							else
							{
								result.Y = Common.getHeightScreen / 5 * 4;
								indexPos -= column * 4;
							}
						}
					}
				}
				break;
			}
			}
			int num2 = Common.getWidthScreen / column;
			result.X = indexPos * num2 - 10;
			return result;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00017AB8 File Offset: 0x00015CB8
		public static int GetIndexOfPossitionApp(ref List<int> lstPossition)
		{
			int result = 0;
			List<int> obj = lstPossition;
			lock (obj)
			{
				for (int i = 0; i < lstPossition.Count; i++)
				{
					bool flag2 = lstPossition[i] == 0;
					if (flag2)
					{
						result = i;
						lstPossition[i] = 1;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00017B4C File Offset: 0x00015D4C
		public static void FillIndexPossition(ref List<int> lstPossition, int indexPos)
		{
			List<int> obj = lstPossition;
			lock (obj)
			{
				lstPossition[indexPos] = 0;
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00017B98 File Offset: 0x00015D98
		public static string CheckProxy(string proxy, int typeProxy, int timeOut = 30)
		{
			object[] parameters = new object[]
			{
				proxy,
				typeProxy,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(189744, 1648, 273, parameters);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00017C00 File Offset: 0x00015E00
		public static string CheckProxyNew(string proxy, int typeProxy, int timeOut = 30)
		{
			object[] parameters = new object[]
			{
				proxy,
				typeProxy,
				timeOut
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(191392, 1648, 274, parameters);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00017C68 File Offset: 0x00015E68
		public static string CheckProxy3(string proxy, int typeProxy)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				RequestXNet requestXNet = new RequestXNet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), SetupFolder.GetUseragentIPhone(Common.rd), proxy, typeProxy);
				result = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNiMWt3WkhKTmF6VkVUbGhDYWxJeWVIUmFWazB4WkcxT2RGa3pXVDA9")))))))));
			}
			catch (Exception ex)
			{
				result = Common.CheckProxy2(proxy, typeProxy);
			}
			return result;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00017DAC File Offset: 0x00015FAC
		public static string CheckProxy2(string proxy, int typeProxy)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				RequestXNet requestXNet = new RequestXNet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), SetupFolder.GetUseragentIPhone(Common.rd), proxy, typeProxy);
				string input = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa2xVVkZwTlpWUnNObGxWWXpWTk1rWlpVVmhXYVdKV1dYZFVTR001VUZFOVBRPT0=")))))))));
				result = Regex.Match(input, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyTXlVbGhXVkd4S1lWZGtNVk15YnpSalJXeHVVRlF3UFE9PQ=="))))))))).Groups[1].Value;
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SV1UwVndNbHBWYUhKbFVUMDk=")))))))));
			}
			return result;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00017F9C File Offset: 0x0001619C
		public static string CheckProxyOnlyV4(string proxy, int typeProxy)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				RequestXNet requestXNet = new RequestXNet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), proxy, typeProxy);
				string text = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlRXNW5lRmxzYUZOaVIwMTZWVmhXV2sxcWJEQlVSRWw0VGxkR1dWRllWbWhpYXpVeVdXMWpPVkJSUFQwPQ==")))))))));
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1FsQlJQVDA9")))))))).ToString();
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xqTW1SV1UwVndNbHBWYUhKUVVUMDk=")))))))));
			}
			return result;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000181B0 File Offset: 0x000163B0
		public static string CheckIP()
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				RequestXNet requestXNet = new RequestXNet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0);
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				text = requestXNet.RequestGet(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlRXNW5lRmxzYUZOaVIwMTZWVmhXV2sxcWJEQlVSRWw0VGxkR1dWRllWbWhpYXpVeVdXMWpPVkJSUFQwPQ==")))))))));
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zab1FsQlJQVDA9")))))))).ToString();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000183FC File Offset: 0x000165FC
		public static void ExportError(Chrome chrome, Exception ex, string error = "")
		{
			try
			{
				bool flag = !Directory.Exists(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSm5QVDA9")))))))));
				if (flag)
				{
					Directory.CreateDirectory(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSm5QVDA9")))))))));
				}
				bool flag2 = !Directory.Exists(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhoUkVKcFZqTmpPUT09")))))))));
				if (flag2)
				{
					Directory.CreateDirectory(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhoUkVKcFZqTmpPUT09")))))))));
				}
				bool flag3 = !Directory.Exists(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhpU0ZKYVZqSlNjMWt6WXpsUVVUMDk=")))))))));
				if (flag3)
				{
					Directory.CreateDirectory(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhpU0ZKYVZqSlNjMWt6WXpsUVVUMDk=")))))))));
				}
				Random random = new Random();
				string text = string.Concat(new string[]
				{
					DateTime.Now.Day.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Month.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Year.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Hour.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Minute.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Second.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					random.Next(1000, 9999).ToString()
				});
				bool flag4 = chrome != null;
				if (flag4)
				{
					string contents = chrome.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhOVjJocVlsaFJlRmt3VGtKUFZXeElWVzVhV2sweFdqQlhiR014VFVWNGRGVnVXbHBOTVZvd1YyeGpNVTFHU2xobFIzaHBWakZhTVZwRlRURmpSMHAwVGxkNGFtRXlhRlpXUmxZelRqSk9kRlpxUW10WFJYQXhVMVZqZUdGSFRuUmtSRVpxVWtoTk9RPT0="))))))))).ToString();
					chrome.ScreenCapture(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhpU0ZKYVZqSlNjMWw2UmpOUVVUMDk=")))))))), text);
					File.WriteAllText(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhoUkVKcFZqTm9hZz09")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGIwMUhTbGhrZWpBOQ==")))))))), contents);
				}
				using (StreamWriter streamWriter = new StreamWriter(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhsU0ZwaFpWUlZkMXBWYUZKUVVUMDk=")))))))), true))
				{
					streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaTmQyUkZlRlJOU0ZKTlZYcENNRlJHVFhka1JYaFVUVWhTVFZWNlFqQlVSazEzWkVWNFZFMUlVazFWZWtJd1ZFWk5kMlJGZUZSTlNGSk5WWHBDTUZSR1RYZGtSWGhVVFVoU1RWVjZRakJVUmsxM1pFVjRWRTFJVWsxVmVrSXdWRVpOZDJSRmVGUk5TRkpOVlhwQ01GUkdUWGRrUlhoVVRVaFNUVlY2UWpCVVJrMTNaRVY0VkUxRU1EMD0=")))))))));
					streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IwMUdjRlZpTW1NOQ==")))))))) + DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1VtUnNVbFpOU0Zwc1YwZDNNVnBXVGtOVFZrNUZZMGhTYVZaSVFqWlpNMk01VUZFOVBRPT0="))))))))));
					streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweGMyTXhjRlZpTW1NOQ==")))))))) + text);
					bool flag5 = error != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag5)
					{
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4b1MyVlhTWHBUVkZwS1VWUXdPUT09")))))))) + error);
					}
					streamWriter.WriteLine();
					bool flag6 = ex != null;
					if (flag6)
					{
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10b2MyUXhjRlZpTW1NOQ==")))))))) + ex.GetType().FullName);
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaa1YyVnRUWGxTYlRWaFZrYzViZz09")))))))) + ex.Message);
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxST1UyRkdhM2xrUmxacVlsVmFjVmRzVW5aYWR6MDk=")))))))) + ex.StackTrace);
						ex = ex.InnerException;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00018E50 File Offset: 0x00017050
		public static void ExportError(Exception ex, string error = "")
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhsU0ZwaFpWUlZkMXBWYUZKUVVUMDk=")))))))), true))
				{
					streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaTmQyUkZlRlJOU0ZKTlZYcENNRlJHVFhka1JYaFVUVWhTVFZWNlFqQlVSazEzWkVWNFZFMUlVazFWZWtJd1ZFWk5kMlJGZUZSTlNGSk5WWHBDTUZSR1RYZGtSWGhVVFVoU1RWVjZRakJVUmsxM1pFVjRWRTFJVWsxVmVrSXdWRVpOZDJSRmVGUk5TRkpOVlhwQ01GUkdUWGRrUlhoVVRVaFNUVlY2UWpCVVJrMTNaRVY0VkUxRU1EMD0=")))))))));
					streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IwMUdjRlZpTW1NOQ==")))))))) + DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1VtUnNVbFpOU0Zwc1YwZDNNVnBXVGtOVFZrNUZZMGhTYVZaSVFqWlpNMk01VUZFOVBRPT0="))))))))));
					bool flag = error != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag)
					{
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4b1MyVlhTWHBUVkZwS1VWUXdPUT09")))))))) + error);
					}
					streamWriter.WriteLine();
					bool flag2 = ex != null;
					if (flag2)
					{
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10b2MyUXhjRlZpTW1NOQ==")))))))) + ex.GetType().FullName);
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaa1YyVnRUWGxTYlRWaFZrYzViZz09")))))))) + ex.Message);
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxST1UyRkdhM2xrUmxacVlsVmFjVmRzVW5aYWR6MDk=")))))))) + ex.StackTrace);
						ex = ex.InnerException;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00019208 File Offset: 0x00017408
		public static string RunCMD(string fileName, string cmd, int timeout = 10)
		{
			Process process = new Process();
			process.StartInfo.FileName = fileName;
			process.StartInfo.Arguments = cmd;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
			process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
			StringBuilder output = new StringBuilder();
			process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
			{
				bool flag2 = !string.IsNullOrEmpty(e.Data);
				if (flag2)
				{
					output.Append(e.Data + "\n");
				}
			};
			process.Start();
			process.BeginOutputReadLine();
			bool flag = timeout < 0;
			if (flag)
			{
				process.WaitForExit();
			}
			else
			{
				process.WaitForExit(timeout * 1000);
			}
			process.Close();
			return output.ToString();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00019324 File Offset: 0x00017524
		public static bool ResetDcom(string profileDcom)
		{
			bool flag = false;
			string text = Common.RunCMD(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFIyVnNjRWhpUjJocFVYcFdjMXBWWkZaUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))) + profileDcom + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), 3);
			bool flag2 = text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxST1YyRnNhM2xXYm5CcVRXeHZlRmxyWkRST1ZXeElWRzVhYVdKVVZuTlhWRTVUWWtad1JGRnFRbWxsVlVVNQ==")))))))));
			if (flag2)
			{
				flag = true;
			}
			else
			{
				bool flag3 = text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpGak5VMVZiRWhTYm14aFZUQktiMWxyYUV0aVJteFlWV3BXU2xJd05USlpiVEF4WWtacmVsVnRlR0ZSTUVsM1dXNXNRbEJSUFQwPQ==")))))))));
				if (flag3)
				{
					for (int i = 0; i < 3; i++)
					{
						text = Common.RunCMD(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFIyVnNjRWhpUjJocFVYcFdjMXBWWkZaUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))) + profileDcom + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkc1FtUnNjRWhpU0hCYVRXcHNNVmx0TVZkaGJWSkNVRlF3UFE9PQ==")))))))), 3);
						bool flag4 = text.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSk5XUkhTbGhTYmxaaFVUQktjVmxxU1hoa01rcElWbXBDWVZZeFJtNVplazVYWVd4cmVWWnVjR3BOYkc5NFdXdGtORTVWZUc1UVZEQTk="))))))));
						if (flag4)
						{
							flag = true;
							break;
						}
						Common.DelayTime(1.0);
					}
					Common.DelayTime(1.0);
					bool flag5 = flag;
					if (flag5)
					{
						for (int j = 0; j < 3; j++)
						{
							text = Common.RunCMD(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFIyVnNjRWhpUjJocFVYcFdjMXBWWkZaUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))) + profileDcom + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), 3);
							bool flag6 = text.Contains(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxST1YyRnNhM2xXYm5CcVRXeHZlRmxyWkRST1ZXeElWRzVhYVdKVVZuTlhWRTVUWWtad1JGRnFRbWxsVlVVNQ==")))))))));
							if (flag6)
							{
								flag = true;
								break;
							}
							Common.DelayTime(1.0);
						}
					}
					Common.DelayTime(1.0);
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00019814 File Offset: 0x00017A14
		public static bool ChangeIP(int typeChangeIP, int typeDcom, string profileDcom, string urlHilink, int iTypeHotspot, string sLinkNord)
		{
			bool result = false;
			string a = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				bool flag = typeChangeIP == 0;
				if (flag)
				{
					return true;
				}
				bool flag2 = typeChangeIP == 1;
				if (flag2)
				{
					string b = Common.CheckIP();
					IntPtr intPtr = AutoControl.FindWindowHandle(null, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCVmVGRnJiRWRYYkVaVldub3dPUT09")))))))));
					AutoControl.BringToFront(intPtr);
					AutoControl.SendClickOnPosition(AutoControl.FindHandle(intPtr, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyVlhTWGxOVjNoWlRWVndjMWx0TVZOaVIwNXpXa2hDWVZJeVVuTmFSVlp2WkcxTmVsVnJiRmROUkZaRw==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyVlhTWGxOVjNoS1VsaG9jMWRxU2tkaGJWWlVVV3hvYUZaNlZuSlphazVxVUZFOVBRPT0="))))))))), 356, 286, EMouseKey.LEFT, 1);
					Thread.Sleep(5000);
					string b2 = Common.CheckIP();
					AutoControl.SendClickOnPosition(AutoControl.FindHandle(intPtr, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyVlhTWGxOVjNoWlRWVndjMWx0TVZOaVIwNXpXa2hDWVZJeVVuTmFSVlp2WkcxTmVsVnJiRmROUkZaRw==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyVlhTWGxOVjNoS1VsaG9jMWRxU2tkaGJWWlVVV3hvYUZaNlZuSlphazVxVUZFOVBRPT0="))))))))), 356, 286, EMouseKey.LEFT, 1);
					int tickCount = Environment.TickCount;
					do
					{
						a = Common.CheckIP();
						bool flag3 = Environment.TickCount - tickCount > 20000;
						if (flag3)
						{
							break;
						}
					}
					while (a == b || a == b2);
					bool flag4 = a != b;
					if (flag4)
					{
						result = true;
					}
				}
				else
				{
					bool flag5 = typeChangeIP == 2;
					if (flag5)
					{
						bool flag6 = typeDcom == 0;
						if (flag6)
						{
							result = Common.ResetDcom(profileDcom);
						}
						else
						{
							int num = Common.ResetHilink(urlHilink);
							bool flag7 = num == 0;
							if (flag7)
							{
								Thread.Sleep(2000);
								num = Common.ResetHilink(urlHilink);
							}
							result = (num == 1);
						}
					}
					else
					{
						bool flag8 = typeChangeIP == 4;
						if (!flag8)
						{
							bool flag9 = typeChangeIP == 5;
							if (!flag9)
							{
								bool flag10 = typeChangeIP == 6;
								if (flag10)
								{
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4b1MyVlhTWHBUVjJSU1RXMW9iMWx0TVd0aVJrNVhVVlF3UFE9PQ==")))))))));
			}
			return result;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00019C44 File Offset: 0x00017E44
		public static bool CheckStringIsContainIcon(string content)
		{
			return content.Length != Regex.Replace(content, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWb1EwNHhSWHBVYW1zOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Length;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00019D08 File Offset: 0x00017F08
		public static int ResetHilink(string urlHilink)
		{
			object[] parameters = new object[]
			{
				urlHilink
			};
			return (int)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(202464, 8032, 283, parameters);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00019D50 File Offset: 0x00017F50
		public static DateTime ConvertStringToDatetime(string datetime, string format = "dd/MM/yyyy HH:mm:ss")
		{
			return DateTime.ParseExact(datetime, format, CultureInfo.InvariantCulture);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00019D7C File Offset: 0x00017F7C
		public static string GetTotp(string input)
		{
			string text = Common.GetTotpServer(input);
			bool flag = text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			if (flag)
			{
				text = Common.GetTotpClient(input);
			}
			return text;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00019DFC File Offset: 0x00017FFC
		public static string GetTotpServer(string input)
		{
			object[] parameters = new object[]
			{
				input
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(210816, 2400, 286, parameters);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00019E44 File Offset: 0x00018044
		public static string GetTotpClient(string input)
		{
			object[] parameters = new object[]
			{
				input
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(213216, 832, 287, parameters);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00019E8C File Offset: 0x0001808C
		private static int RemainingSeconds()
		{
			return 30 - (int)((DateTime.UtcNow.Ticks - 621355968000000000L) / 10000000L % 30L);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00019ED0 File Offset: 0x000180D0
		private static byte[] GetBigEndianBytes(long input)
		{
			byte[] bytes = BitConverter.GetBytes(input);
			Array.Reverse(bytes);
			return bytes;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00019EFC File Offset: 0x000180FC
		private static long CalculateTime30FromTimestamp(DateTime timestamp)
		{
			long num = (timestamp.Ticks - 621355968000000000L) / 10000000L;
			return num / 30L;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00019F38 File Offset: 0x00018138
		private static string Digits(long input, int digitCount)
		{
			return ((int)input % (int)Math.Pow(10.0, (double)digitCount)).ToString().PadLeft(digitCount, '0');
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00019F84 File Offset: 0x00018184
		private static byte[] ToBytes(string input)
		{
			bool flag = string.IsNullOrEmpty(input);
			if (flag)
			{
				throw new ArgumentNullException(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1XUXlVbGxWVkRBOQ==")))))))));
			}
			input = input.TrimEnd(new char[]
			{
				'='
			});
			int num = input.Length * 5 / 8;
			byte[] array = new byte[num];
			byte b = 0;
			byte b2 = 8;
			int num2 = 0;
			foreach (char c in input)
			{
				int num3 = Common.CharToValue(c);
				bool flag2 = b2 > 5;
				if (flag2)
				{
					int num4 = num3 << (int)(b2 - 5);
					b = (byte)((int)b | num4);
					b2 -= 5;
				}
				else
				{
					int num4 = num3 >> (int)(5 - b2);
					b = (byte)((int)b | num4);
					array[num2++] = b;
					b = (byte)(num3 << (int)(3 + b2));
					b2 += 3;
				}
			}
			bool flag3 = num2 != num;
			if (flag3)
			{
				array[num2] = b;
			}
			return array;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0001A138 File Offset: 0x00018338
		private static int CharToValue(char c)
		{
			bool flag = c < '[' && c > '@';
			int result;
			if (flag)
			{
				result = (int)(c - 'A');
			}
			else
			{
				bool flag2 = c < '8' && c > '1';
				if (flag2)
				{
					result = (int)(c - '\u0018');
				}
				else
				{
					bool flag3 = c < '{' && c > '`';
					if (!flag3)
					{
						throw new ArgumentException(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IyRkhUblJTYlhCclVqRmFOVk5WWkhObGEyeElUbGhhYTFFd1NtOVRWVlpMWVVkTmVWWlljRTVoVlVweFdWVmtSMlZXYkZoVWFrSmhWMFZzTVE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFoak9WQlJQVDA9")))))))));
					}
					result = (int)(c - 'a');
				}
			}
			return result;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0001A278 File Offset: 0x00018478
		public static DataTable ShuffleDataTable(DataTable dt)
		{
			DataTable result = new DataTable();
			try
			{
				result = (from DataRow r in dt.Rows
				orderby Base.rd.Next()
				select r).CopyToDataTable<DataRow>();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0001A2FC File Offset: 0x000184FC
		public static bool CopyFolder(string pathFrom, string pathTo)
		{
			try
			{
				Common.CreateFolder(pathTo);
				foreach (string text in Directory.GetDirectories(pathFrom, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKak9WQlJQVDA9")))))))), SearchOption.AllDirectories))
				{
					Directory.CreateDirectory(text.Replace(pathFrom, pathTo));
				}
				foreach (string text2 in Directory.GetFiles(pathFrom, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpKck1HTlJQVDA9")))))))), SearchOption.AllDirectories))
				{
					File.Copy(text2, text2.Replace(pathFrom, pathTo), true);
				}
				return true;
			}
			catch (Exception ex)
			{
			}
			return false;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0001A48C File Offset: 0x0001868C
		public static bool MoveFolder(string pathFrom, string pathTo)
		{
			try
			{
				Directory.Move(pathFrom, pathTo);
				return true;
			}
			catch (Exception ex)
			{
			}
			return false;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0001A4E8 File Offset: 0x000186E8
		public static bool DeleteFolder(string pathFolder)
		{
			try
			{
				Directory.Delete(pathFolder, true);
				return true;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0001A544 File Offset: 0x00018744
		public static bool IsVNName(string ten)
		{
			ten = ten.Trim();
			bool flag = ten == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			return !flag && ten != Common.ConvertToUnSign(ten) && Common.IsContainsVNChar(ten);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0001A5FC File Offset: 0x000187FC
		public static bool IsContainsVNChar(string text)
		{
			bool result = true;
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWa1IyRldhM2xWYlhoaFlsZFNkbGxXWkhkamJVcElUVmhXYVUwd1NqUlpNalZQVFVkU1dWZHFUbXhUUjNjeVZWWldTMUpHU2taV2EyUlRUVWRvUzFVeWREQlVWbEpXVGxaQ1ZsSnJXbFJXVkVaVFZteGFjMXBHYkZoV2JrSnZWVlprVjFKdFNYZFBWRVpYVmpKNFMxZHJWbE5PVm1ScVZESm9NMDVyVW05a1dFWkpZVWhXZUZWRlVuWlBSVGx3VGtkS2VHSkVVbWxqVnpRd1dXNUdNRTVIU25oalJGSnBZMWhLTkZOV1FtOWtXRVYyWVVoV2VWTkhhREZqYlZwdlpGaEtVV0ZJVm5sWFJWSnVXVEE1UWs1SFNuaGFlbEpwWTFkc00wNUdRa1ZhTTFaSVRtNUNVRko2V25ka1ZXTXlZMnM1U0U1dVJsQlNlbHA0WXpGT1JFNUhTbmhrVkZKcFkxaGpNRmx1UlhsT1IwcDRaVlJTYVdOVVFqTk9iVFZGWTFVNVNFNXVWbXhTZWxveFN6QmpNbVJ0VGxCalZGSnBZMU00TUZsdVZrTk9SMG94VTBSU2FXUlZVVEJaYmxaSFpIcFNkVkpIYkZCU2Vsb3hWREJqTW1SWVZraE9ibHBPVkRCek1GbHVSWEpPUjBveFVWUlNhV1JWWXpCWmJsWkVUa2RLTVZKWVl6TlZSVko2WkZWak0yRnRWa2hPTW04MFZIcEdNMDR4VW05a1ZGWkpZVWhWTVZWSGFERk9WelZ2WkZSV1dXRklWVEZhYTJSMldsVmpNMkpUZEVoT01qVnNVbnBrZGtzd1l6TmlhWFJJVGpJNWFsUXhVak5PVlhodlpGUlNObUZJVlRCT01GSnpXVEE1Vms1SFNqRlZWRkpwWkZaTk1GbHVWbHBPUjBveFZsUlNhV1JXWkRSalZWSnZaRlJXZVdGSVZURmxiV2d4VG10NGIyUlVWVE5oU0ZVeVVrVlNNV013T0RGT1Iwb3hZa1JTYVdSWE5UUlpWelZJWXpBNVNFNHpSbXhTZW1SNFN6QmpNMk15VmtoT00wcHNVbnBrZVU5Rk9XaGtlbFoxWVVoVk1sWkhhREZPYlVwSFkxVXhhR1JxVW1sa1Z6Z3dXVzVXZUU1SFNqRmtlbEpwWkZoTk1GbHVWakZrZWxsNlVraEtVRko2WkhCTE1HTXpZVmRPVkdOSVl6Qk5NRkp4VkRCak0yRllWa2hPTW14T1ZUSTVORk5yYUVaaE1ERlFUMVJTYVdSWWJ6QlpibFY0VGtkS01VMTZVbWxrVkZZelRsUk9iMlJVWkUxaFNGVXpWa2RvTVU0eVNtOWtWR1J1VUZFOVBRPT0="))))))));
			foreach (char value in text)
			{
				bool flag = !@string.ToCharArray().Contains(value);
				if (flag)
				{
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0001A6BC File Offset: 0x000188BC
		public static string ConvertToUnSign(string s)
		{
			Regex regex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWb1EwNHhUbGxVYTFKcFRXcEdjRmxXWXpGalIwcDBXa1ZXYUZZd1duRlpNakZ6VFVkR1dGUnRhR2xTVkVadldUSXhNR1Z0V2xSamVqQTk=")))))))));
			string input = s.Normalize(NormalizationForm.FormD);
			return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
		}

		// Token: 0x04000202 RID: 514
		private static Random rd = new Random();

		// Token: 0x04000203 RID: 515
		private static int getWidthScreen = Screen.PrimaryScreen.WorkingArea.Width;

		// Token: 0x04000204 RID: 516
		private static int getHeightScreen = Screen.PrimaryScreen.WorkingArea.Height;

		// Token: 0x04000205 RID: 517
		private static object k = new object();
	}
}
