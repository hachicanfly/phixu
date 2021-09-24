using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using maxcare.Helper;
using MCommon;

namespace maxcare
{
	// Token: 0x02000187 RID: 391
	internal static class Program
	{
		// Token: 0x06001066 RID: 4198 RVA: 0x00404D98 File Offset: 0x00402F98
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBWa1UyVlhSbGxYYlhocVltczFhbGRzYUZOaGJHaElZVWhhYWsweFNqWT0="))))))));
				bool flag = File.Exists(path);
				if (flag)
				{
					try
					{
						List<string> list = new List<string>
						{
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyUXdlSFJOV0VKcFltczFNbGR0TlZOTk1XeFpVMjE0VFdKc2NERT0=")))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a2MyUlhUWGxQVnpGclUwZFNiMWt5TVZaa1YxSjBUa1F3UFE9PQ=="))))))))
						};
						using (StreamReader streamReader = new StreamReader(path))
						{
							string text = string.Empty;
							while ((text = streamReader.ReadLine()) != null)
							{
								foreach (string value in list)
								{
									bool flag2 = text.ToLower().Contains(value);
									if (flag2)
									{
										MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm0wMVYyTkZiRWhsYTFKNllsUldkVk5WWkZGaFNGWjRWbXBHU2xJeWNFVmphMk14WWpCc1NHVnRhREZqVlZwM1UxVmtZV05IU2toV1YyUm9VbnBzTmxwRmFFNWFNa294VW5wYU1rMHhWbTVaYkdoWllVaFZNVkp1VmtwU2VrNXZaRlJWTkZveVRraGhiV2d4WTFkU01WTlZZM3BoU0ZVd1VtNVNTbFZVTURrPQ=="))))))))), 2);
										Environment.Exit(0);
									}
								}
							}
						}
					}
					catch
					{
					}
				}
				Application.Run(new fIntro());
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSSmRsUlhaRlJSYms0elRqRlNUbHA2U25KYU1sWklVMFV4Y0ZkSGRHNVpNakZHWXpCc1NWZHFSbWhWTUVwNldXcG9OVkZYU25SWk1tUnBVakkxUldOWE1EQmFNa1pPVkROR05sTXdNVzVWVm1SVFpFZEdXRTVIWkRSVGEyaEZZMWhPTlZOcmJFNVZNVW8wWTJ0U1NHSXlUalZoYkd3MVVXMDVNMDR4VWs1YU0yeERUVWRPZWxsWGFEWlRNREZ2"))))))))), 2);
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxjMVYyUlZiRWRSYm14cFRXMVNOVmRXWTNkbFVUMDk=")))))))));
				Environment.Exit(0);
			}
		}

		// Token: 0x04001B1F RID: 6943
		public static int intro;
	}
}
