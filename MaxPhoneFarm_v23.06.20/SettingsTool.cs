using System.Collections.Generic;
using System.IO;
using System.Linq;

public class SettingsTool
{
	internal static Dictionary<string, JSON_Settings> B230C093 = new Dictionary<string, JSON_Settings>();

	public static JSON_Settings GetSettings(string F720EB17, bool E786F014 = false)
	{
		if (E786F014)
		{
			A89CD79D(F720EB17);
		}
		else if (!B230C093.ContainsKey(F720EB17))
		{
			B230C093.Add(F720EB17, new JSON_Settings(F720EB17));
		}
		return B230C093[F720EB17];
	}

	private static void A89CD79D(string string_0)
	{
		if (B230C093.ContainsKey(string_0))
		{
			B230C093[string_0] = new JSON_Settings(string_0);
		}
		else
		{
			B230C093.Add(string_0, new JSON_Settings(string_0));
		}
	}

	public static void smethod_0(string string_0)
	{
		if (B230C093.ContainsKey(string_0))
		{
			B230C093[string_0].method_5();
		}
		A89CD79D(string_0);
	}

	public static string smethod_1()
	{
		string text = B230C093["configGeneral"].GetValue("txbPathProfile");
		if (!text.Contains('\\'))
		{
			text = FileHelper.GetPathToCurrentFolder() + "\\" + ((text == "") ? "profiles" : text);
		}
		if (!Directory.Exists(text))
		{
			return FileHelper.GetPathToCurrentFolder() + "\\profiles";
		}
		return text;
	}

	public static string AC3A549C()
	{
		return FileHelper.GetPathToCurrentFolder() + "\\backup";
	}
}
