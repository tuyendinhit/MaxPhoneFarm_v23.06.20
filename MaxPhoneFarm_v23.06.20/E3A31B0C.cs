using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

public class E3A31B0C
{
	public static string F39D0C1A()
	{
		string text = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile");
		if (!text.Contains('\\'))
		{
			text = FileHelper.GetPathToCurrentFolder() + "\\" + ((SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") == "") ? "profiles" : SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile"));
		}
		return text;
	}

	public static string smethod_0()
	{
		return FileHelper.GetPathToCurrentFolder() + "\\backup";
	}

	public static string smethod_1(int int_0 = 0)
	{
		switch (int_0)
		{
		default:
			if (SettingsTool.GetSettings("configGeneral").AA824D29("isRunSwap"))
			{
				return SettingsTool.GetSettings("configGeneral").GetValue("txtLDPathSwap").Trim();
			}
			return SettingsTool.GetSettings("configGeneral").GetValue("txtLDPathThuong").Trim();
		case 2:
			return SettingsTool.GetSettings("configGeneral").GetValue("txtLDPathSwap").Trim();
		case 1:
			return SettingsTool.GetSettings("configGeneral").GetValue("txtLDPathThuong").Trim();
		}
	}

	public static string smethod_2()
	{
		string result = "";
		try
		{
			string path = smethod_1() + "\\vms\\config\\leidian0.config";
			string text = smethod_1() + "\\vms\\config\\leidian1.config";
			if (File.Exists(text))
			{
				path = text;
			}
			JObject jObject = JObject.Parse(File.ReadAllText(path));
			result = jObject["statusSettings.sharedPictures"]!.ToString();
		}
		catch
		{
		}
		return result;
	}
}
