using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Rush_it_redesign.Properties
{
	// Token: 0x0200000F RID: 15
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000C96C File Offset: 0x0000AB6C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000C984 File Offset: 0x0000AB84
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000020F5 File Offset: 0x000002F5
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string Username
		{
			get
			{
				return (string)this["Username"];
			}
			set
			{
				this["Username"] = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002105 File Offset: 0x00000305
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x0400006A RID: 106
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
