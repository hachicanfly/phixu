using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using ConversionBack;

namespace maxcare
{
	// Token: 0x02000064 RID: 100
	internal class BitviseHandle
	{
		// Token: 0x060003D4 RID: 980
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int SendMessage(int hWnd, int msg, int wParam, IntPtr lParam);

		// Token: 0x060003D5 RID: 981 RVA: 0x00058760 File Offset: 0x00056960
		public static int GetPortAvailable()
		{
			BitviseHandle.PortIndex++;
			bool flag = BitviseHandle.PortIndex >= 1280;
			if (flag)
			{
				BitviseHandle.PortIndex = 1079;
			}
			Process value = new Process();
			try
			{
				BitviseHandle.BitviseList.Add(BitviseHandle.PortIndex, value);
			}
			catch
			{
			}
			return BitviseHandle.PortIndex;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000587F4 File Offset: 0x000569F4
		public static bool Connect(string Host, string User, string Pass, int ForwardPort)
		{
			object[] parameters = new object[]
			{
				Host,
				User,
				Pass,
				ForwardPort
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1162784, 3040, 592, parameters);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0005886C File Offset: 0x00056A6C
		public static void Disconnect(int ForwardPort)
		{
			bool flag = BitviseHandle.BitviseList[ForwardPort] == null;
			if (!flag)
			{
				try
				{
					Process process = BitviseHandle.BitviseList[ForwardPort] as Process;
					process.Kill();
					process.Dispose();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000588F4 File Offset: 0x00056AF4
		private static bool GetPort(string Host, int Port)
		{
			return true;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00058910 File Offset: 0x00056B10
		public static void DisconnectAllBiviseRunning()
		{
			foreach (Process process in Process.GetProcesses())
			{
				bool flag = process.ProcessName == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZjMVlWWkhUWGxhZWpBOQ=="))))))));
				if (flag)
				{
					process.Kill();
				}
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000589AC File Offset: 0x00056BAC
		public static Process FindProcess(IntPtr yourHandle)
		{
			foreach (Process process in Process.GetProcesses())
			{
				bool flag = process.Handle == yourHandle;
				if (flag)
				{
					return process;
				}
			}
			return null;
		}

		// Token: 0x040002B3 RID: 691
		private const int WM_CLOSE = 16;

		// Token: 0x040002B4 RID: 692
		private const int BN_CLICKED = 245;

		// Token: 0x040002B5 RID: 693
		private const int WM_LBUTTONDOWN = 513;

		// Token: 0x040002B6 RID: 694
		private const int WM_LBUTTONUP = 514;

		// Token: 0x040002B7 RID: 695
		private static Hashtable BitviseList = new Hashtable();

		// Token: 0x040002B8 RID: 696
		public static int TimeoutSeconds = 30;

		// Token: 0x040002B9 RID: 697
		private static int PortIndex = 1079;
	}
}
