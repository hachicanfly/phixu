using System;
using System.Linq;
using System.Text;

namespace maxcare.Helper
{
	// Token: 0x02000192 RID: 402
	public class ConfigHelper
	{
		// Token: 0x060011C8 RID: 4552 RVA: 0x0041171C File Offset: 0x0040F91C
		public static string GetPathProfile()
		{
			JsonHelper jsonHelper = new JsonHelper(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUldjSFJpUnpWVFRXeGFNVmRzYUV0aFIwcENVRlF3UFE9PQ==")))))))), false);
			string text = jsonHelper.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			bool flag = !text.Contains('\\');
			if (flag)
			{
				text = FileHelper.GetPathToCurrentFolder() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWRk9WQlJQVDA9")))))))) + ((jsonHelper.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnNjSFJpU0U1aFYwVXdPUT09")))))))) : jsonHelper.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWb2IyRldWa2hTYWtKb1VtdEtOVmxxU21GalIwcElWbFF3UFE9PQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))));
			}
			return text;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00411A38 File Offset: 0x0040FC38
		public static string GetPathBackup()
		{
			return FileHelper.GetPathToCurrentFolder() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1MyRkdhM2xrUkVacVVWUXdPUT09"))))))));
		}
	}
}
