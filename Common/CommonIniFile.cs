using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Common
{
	// Token: 0x02000060 RID: 96
	public class CommonIniFile
	{
		// Token: 0x060003B0 RID: 944
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

		// Token: 0x060003B1 RID: 945
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

		// Token: 0x060003B2 RID: 946
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Unicode, EntryPoint = "GetPrivateProfileStringW")]
		private static extern uint GetPrivateProfileStringByByteArray(string lpAppName, string lpKeyName, string lpDefault, byte[] lpReturnedString, uint nSize, string lpFileName);

		// Token: 0x060003B3 RID: 947 RVA: 0x00057354 File Offset: 0x00055554
		public CommonIniFile(string IniPath = null)
		{
			this.Path = new FileInfo(IniPath ?? (this.EXE + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGMyUlhSbEpRVkRBOQ==")))))))))).FullName.ToString();
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000573EC File Offset: 0x000555EC
		public string ReadUnicode(string Key, string Section = null)
		{
			byte[] array = new byte[1024];
			uint privateProfileStringByByteArray = CommonIniFile.GetPrivateProfileStringByByteArray(Section ?? this.EXE, Key, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), array, (uint)array.Length, this.Path);
			return Encoding.Unicode.GetString(array, 0, (int)(privateProfileStringByByteArray * 2U));
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000574A0 File Offset: 0x000556A0
		public string Read(string Key, string Section = null)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			CommonIniFile.GetPrivateProfileString(Section ?? this.EXE, Key, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), stringBuilder, 255, this.Path);
			return stringBuilder.ToString();
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00057540 File Offset: 0x00055740
		public void Write(string Key, string Value, string Section = null)
		{
			CommonIniFile.WritePrivateProfileString(Section ?? this.EXE, Key, Value, this.Path);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00057584 File Offset: 0x00055784
		public void DeleteKey(string Key, string Section = null)
		{
			this.Write(Key, null, Section ?? this.EXE);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000575C0 File Offset: 0x000557C0
		public void DeleteSection(string Section = null)
		{
			this.Write(null, null, Section ?? this.EXE);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000575F4 File Offset: 0x000557F4
		public bool KeyExists(string Key, string Section = null)
		{
			return this.Read(Key, Section).Length > 0;
		}

		// Token: 0x0400029B RID: 667
		private string Path;

		// Token: 0x0400029C RID: 668
		private string EXE = Assembly.GetExecutingAssembly().GetName().Name;
	}
}
