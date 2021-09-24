using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary
{
	// Token: 0x020001A9 RID: 425
	[CompilerGenerated]
	[DefaultMember("FullName")]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	[TypeIdentifier]
	[ComImport]
	public interface IWshShortcut
	{
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06001210 RID: 4624
		[DispId(0)]
		[IndexerName("FullName")]
		string FullName { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06001211 RID: 4625
		// (set) Token: 0x06001212 RID: 4626
		[DispId(1000)]
		string Arguments { [DispId(1000)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1000)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06001213 RID: 4627
		// (set) Token: 0x06001214 RID: 4628
		[DispId(1001)]
		string Description { [DispId(1001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1001)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001215 RID: 4629
		void _VtblGap1_2();

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06001216 RID: 4630
		// (set) Token: 0x06001217 RID: 4631
		[DispId(1003)]
		string IconLocation { [DispId(1003)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06001218 RID: 4632
		void _VtblGap2_1();

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06001219 RID: 4633
		// (set) Token: 0x0600121A RID: 4634
		[DispId(1005)]
		string TargetPath { [DispId(1005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600121B RID: 4635
		void _VtblGap3_2();

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600121C RID: 4636
		// (set) Token: 0x0600121D RID: 4637
		[DispId(1007)]
		string WorkingDirectory { [DispId(1007)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1007)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x0600121E RID: 4638
		void _VtblGap4_1();

		// Token: 0x0600121F RID: 4639
		[DispId(2001)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Save();
	}
}
