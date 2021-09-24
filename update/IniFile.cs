using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace update
{
	// Token: 0x02000004 RID: 4
	public class IniFile
	{
		// Token: 0x0600000D RID: 13
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

		// Token: 0x0600000E RID: 14
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

		// Token: 0x0600000F RID: 15
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Unicode, EntryPoint = "GetPrivateProfileStringW")]
		private static extern uint GetPrivateProfileStringByByteArray(string lpAppName, string lpKeyName, string lpDefault, byte[] lpReturnedString, uint nSize, string lpFileName);

		// Token: 0x06000010 RID: 16 RVA: 0x00003810 File Offset: 0x00001A10
		public IniFile(string IniPath = null)
		{
			this.Path = new FileInfo(IniPath ?? (this.EXE + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGMyUlhSbEpRVkRBOQ==")))))))))).FullName.ToString();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000038A8 File Offset: 0x00001AA8
		public string ReadUnicode(string Key, string Section = null)
		{
			byte[] array = new byte[1024];
			uint privateProfileStringByByteArray = IniFile.GetPrivateProfileStringByByteArray(Section ?? this.EXE, Key, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), array, (uint)array.Length, this.Path);
			return Encoding.Unicode.GetString(array, 0, (int)(privateProfileStringByByteArray * 2U));
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000395C File Offset: 0x00001B5C
		public string Read(string Key, string Section = null)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			IniFile.GetPrivateProfileString(Section ?? this.EXE, Key, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), stringBuilder, 255, this.Path);
			return stringBuilder.ToString();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000039FC File Offset: 0x00001BFC
		public void Write(string Key, string Value, string Section = null)
		{
			IniFile.WritePrivateProfileString(Section ?? this.EXE, Key, Value, this.Path);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003A40 File Offset: 0x00001C40
		public void DeleteKey(string Key, string Section = null)
		{
			this.Write(Key, null, Section ?? this.EXE);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003A7C File Offset: 0x00001C7C
		public void DeleteSection(string Section = null)
		{
			this.Write(null, null, Section ?? this.EXE);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003AB0 File Offset: 0x00001CB0
		public bool KeyExists(string Key, string Section = null)
		{
			return this.Read(Key, Section).Length > 0;
		}

		// Token: 0x04000005 RID: 5
		private string Path;

		// Token: 0x04000006 RID: 6
		private string EXE = Assembly.GetExecutingAssembly().GetName().Name;
	}
}
