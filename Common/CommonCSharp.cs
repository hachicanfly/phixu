using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ConversionBack;
using maxcare;
using MCommon;
using OpenQA.Selenium.Chrome;

namespace Common
{
	// Token: 0x0200005C RID: 92
	public class CommonCSharp
	{
		// Token: 0x0600038D RID: 909 RVA: 0x00015F94 File Offset: 0x00014194
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

		// Token: 0x0600038E RID: 910 RVA: 0x00056048 File Offset: 0x00054248
		public static void resetDcom(string profileDcom)
		{
			Process process = new Process();
			process.StartInfo.FileName = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFIyVnNjRWhpUjJocFVYcFdjMXBWWkZaUVVUMDk="))))))));
			process.StartInfo.Arguments = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))) + profileDcom + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkc1FtUnNjRWhpU0hCYVRXcHNNVmx0TVZkaGJWSkNVRlF3UFE9PQ=="))))))));
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			process.WaitForExit();
			Thread.Sleep(3000);
			process = new Process();
			process.StartInfo.FileName = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJeFIyVnNjRWhpUjJocFVYcFdjMXBWWkZaUVVUMDk="))))))));
			process.StartInfo.Arguments = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))) + profileDcom + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9"))))))));
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			process.WaitForExit();
			Thread.Sleep(1500);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00016090 File Offset: 0x00014290
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

		// Token: 0x06000390 RID: 912 RVA: 0x000562E0 File Offset: 0x000544E0
		public static void SaveDatagridview(DataGridView dgv, string namePath)
		{
			List<string> list = new List<string>();
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			for (int i = 0; i < dgv.RowCount; i++)
			{
				text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				for (int j = 0; j < dgv.ColumnCount; j++)
				{
					object value = dgv.Rows[i].Cells[j].Value;
					text += ((value == null) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))) : (((value != null) ? value.ToString() : null) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9"))))))))));
				}
				text = text.TrimEnd(new char[]
				{
					'|'
				});
				list.Add(text);
			}
			File.WriteAllLines(namePath, list);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000564E8 File Offset: 0x000546E8
		public static void LoadDatagridview(DataGridView dgv, string namePath)
		{
			List<string> list = File.ReadAllLines(namePath).ToList<string>();
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag = list.Count > 0;
			if (flag)
			{
				for (int i = 0; i < list.Count; i++)
				{
					text = list[i];
					DataGridViewRowCollection rows = dgv.Rows;
					object[] values = text.Split(new char[]
					{
						'|'
					});
					rows.Add(values);
				}
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000565C4 File Offset: 0x000547C4
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

		// Token: 0x06000393 RID: 915 RVA: 0x000566B8 File Offset: 0x000548B8
		public static void UpdateStatusDataGridView(DataGridView dgv, int row, string colName, object status)
		{
			try
			{
				dgv.Invoke(new MethodInvoker(delegate()
				{
					dgv.Rows[row].Cells[colName].Value = status;
				}));
			}
			catch
			{
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00056740 File Offset: 0x00054940
		public static string GetStatusDataGridView(DataGridView dgv, int row, string colName)
		{
			string output = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			dgv.Invoke(new MethodInvoker(delegate()
			{
				try
				{
					output = dgv.Rows[row].Cells[colName].Value.ToString();
				}
				catch
				{
				}
			}));
			return output;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000165F8 File Offset: 0x000147F8
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

		// Token: 0x06000396 RID: 918 RVA: 0x000567E8 File Offset: 0x000549E8
		public static bool CheckBasicString(string text)
		{
			bool result = true;
			foreach (char c in text)
			{
				bool flag = (c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != '.' && c != '[' && c != ']';
				if (flag)
				{
					result = false;
					break;
				}
			}
			return result;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00016718 File Offset: 0x00014918
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

		// Token: 0x06000398 RID: 920 RVA: 0x0001680C File Offset: 0x00014A0C
		public static string ConvertToUTF8(string text)
		{
			byte[] bytes = Encoding.Default.GetBytes(text);
			text = Encoding.UTF8.GetString(bytes);
			return text;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0001691C File Offset: 0x00014B1C
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

		// Token: 0x0600039A RID: 922 RVA: 0x00016984 File Offset: 0x00014B84
		public static void ReadHtmlText(string text)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xjMWQwNXJPVlZoZWxaTllsZG5kMWxzWkROUVVUMDk="))))))));
			File.WriteAllText(@string, text);
			Process.Start(@string);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000568B0 File Offset: 0x00054AB0
		public static string ReadHTMLCode(string Url)
		{
			string result;
			try
			{
				bool flag = Url.StartsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlRXdGFNMWt3VFRGa1IwWllUbGh3YVUxc2IzZGFSRXBIWlZad1ZFNVVTbWxoVkd4dldUQmtjbVJzYkZsV2FrSm9Va1JzY2xkV2FGTmhSMUowVm01c2JGWkVRVGs9")))))))));
				if (flag)
				{
					Base.check++;
				}
				result = new RequestHttp(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), 0).RequestGet(Url);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			}
			return result;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00016B0C File Offset: 0x00014D0C
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

		// Token: 0x0600039D RID: 925 RVA: 0x00056A90 File Offset: 0x00054C90
		public static string Md5Encode(string sChuoi)
		{
			MD5 md = MD5.Create();
			byte[] array = md.ComputeHash(Encoding.UTF8.GetBytes(sChuoi));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmpCU1NsQlJQVDA9"))))))))));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000053A0 File Offset: 0x000035A0
		public static string Base64Encode(string text)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00004374 File Offset: 0x00002574
		public static string Base64Decode(string base64EncodedData)
		{
			byte[] bytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00016CEC File Offset: 0x00014EEC
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

		// Token: 0x060003A1 RID: 929 RVA: 0x00016E00 File Offset: 0x00015000
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

		// Token: 0x060003A2 RID: 930 RVA: 0x0001A6BC File Offset: 0x000188BC
		public static string convertToUnSign(string s)
		{
			Regex regex = new Regex(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWb1EwNHhUbGxVYTFKcFRXcEdjRmxXWXpGalIwcDBXa1ZXYUZZd1duRlpNakZ6VFVkR1dGUnRhR2xTVkVadldUSXhNR1Z0V2xSamVqQTk=")))))))));
			string input = s.Normalize(NormalizationForm.FormD);
			return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00016F14 File Offset: 0x00015114
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

		// Token: 0x060003A4 RID: 932 RVA: 0x00017084 File Offset: 0x00015284
		public static void DelayTime(double second)
		{
			Application.DoEvents();
			Thread.Sleep(Convert.ToInt32(second * 1000.0));
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00056B4C File Offset: 0x00054D4C
		public static void ExportError(ChromeDriver chrome, string error)
		{
			object[] parameters = new object[]
			{
				chrome,
				error
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1136816, 2992, 572, parameters);
		}
	}
}
