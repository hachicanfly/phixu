using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06001220 RID: 4640 RVA: 0x00003520 File Offset: 0x00001720
	public static void setup()
	{
		if (Debugger.IsAttached)
		{
			Environment.Exit(0);
		}
		using (Stream manifestResourceStream = Assembly.GetCallingAssembly().GetManifestResourceStream("KXT"))
		{
			using (new StreamReader(manifestResourceStream))
			{
				<Module>.array = new byte[manifestResourceStream.Length];
				manifestResourceStream.Read(<Module>.array, 0, <Module>.array.Length);
			}
		}
		AppDomain.CurrentDomain.AssemblyResolve += <Module>.ResolveAssembly;
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x00002050 File Offset: 0x00000250
	public static Assembly ResolveAssembly(object A_0, ResolveEventArgs A_1)
	{
		if (!A_1.Name.Contains("Runtime"))
		{
			return null;
		}
		return Assembly.Load(<Module>.array);
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x00002076 File Offset: 0x00000276
	static <Module>()
	{
		<Module>.setup();
	}

	// Token: 0x04001B60 RID: 7008
	private static byte[] array;
}
