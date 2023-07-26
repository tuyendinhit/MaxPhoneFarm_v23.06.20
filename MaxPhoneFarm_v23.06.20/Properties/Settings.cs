using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace maxcare.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		internal static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());

		public static Settings Default => settings_0;

		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string UserName
		{
			get
			{
				return (string)this["UserName"];
			}
			set
			{
				this["UserName"] = value;
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string PassWord
		{
			get
			{
				return (string)this["PassWord"];
			}
			set
			{
				this["PassWord"] = value;
			}
		}
	}
}
