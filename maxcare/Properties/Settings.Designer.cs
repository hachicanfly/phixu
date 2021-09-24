using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace maxcare.Properties
{
	// Token: 0x0200018A RID: 394
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x0040DF48 File Offset: 0x0040C148
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x0040DF64 File Offset: 0x0040C164
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x0040DFCC File Offset: 0x0040C1CC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string UserName
		{
			get
			{
				return (string)this[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14b1QySkhUbkpPVjJocFZqRlZPUT09"))))))))];
			}
			set
			{
				this[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14b1QySkhUbkpPVjJocFZqRlZPUT09"))))))))] = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x0040E028 File Offset: 0x0040C228
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0040E090 File Offset: 0x0040C290
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string PassWord
		{
			get
			{
				return (string)this[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWa1IyVnRUWGhhU0ZwcVlsWkZPUT09"))))))))];
			}
			set
			{
				this[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWa1IyVnRUWGhhU0ZwcVlsWkZPUT09"))))))))] = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0040E0EC File Offset: 0x0040C2EC
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0040E154 File Offset: 0x0040C354
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string PathChrome
		{
			get
			{
				return (string)this[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWa1IwMUhSa1pVYlRscVlsUnNNRmRzUlRsUVVUMDk="))))))))];
			}
			set
			{
				this[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxWa1IwMUhSa1pVYlRscVlsUnNNRmRzUlRsUVVUMDk="))))))))] = value;
			}
		}

		// Token: 0x04001B23 RID: 6947
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
