using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;

internal class Class64
{
	internal static object FBB26D25 = new object();

	internal static int A42EF119 = 0;

	internal static int AF176B18 = 10;

	internal static object object_0 = new object();

	private static string F18E57AD()
	{
		string result = "";
		string text = Common.RunCMD("netstat -ano | findstr :4723");
		if (text != "")
		{
			List<string> list = text.Split('\n').ToList();
			foreach (string item in list)
			{
				if (item.Contains("LISTENING"))
				{
					result = item.Split(' ').Last();
				}
			}
			return result;
		}
		return "";
	}

	public static bool smethod_0()
	{
		return F18E57AD() != "";
	}

	public static void CloseServerAppium()
	{
        string text = F18E57AD();
        if (!string.IsNullOrEmpty(text))
        {
            Common.RunCMD("taskkill /pid " + text + " /F");
        }
    }

	public static void smethod_1()
	{
		lock (FBB26D25)
		{
			if (smethod_0())
			{
				return;
			}
            if (!File.Exists("appium.bat"))
            {
                string contents = "node \"%appdata%\\npm\\node_modules\\appium\\build\\lib\\main\"";
                File.WriteAllText("appium.bat", contents);
            }

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c appium.bat";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            for (int i = 0; i < 30; i++)
			{
				if (smethod_0())
				{
					break;
				}
				Common.DelayTime(1.0);
			}
		}
	}

	public static string smethod_2(string DEB90628)
	{
		string result = "";
		try
		{
			List<string> list = new List<string>();
			string json = BB83C02C();
			JToken jToken = JObject.Parse(json)["value"];
			foreach (JToken item in (IEnumerable<JToken>)jToken)
			{
				if (item["capabilities"]!["deviceName"]!.ToString() == DEB90628)
				{
					list.Add(item["id"]!.ToString());
				}
			}
			if (list.Count == 1)
			{
				result = list[0];
			}
			else if (list.Count > 1)
			{
				foreach (string item2 in list)
				{
					AC28BD29 aC28BD = new AC28BD29("");
					aC28BD.method_3(item2);
					aC28BD.method_11();
				}
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static string BB83C02C()
	{
		try
		{
			string text;
			while (true)
			{
				text = new RequestXNet("", "", "", 0).RequestGet("http://localhost:4723/wd/hub/sessions");
				if (!text.Contains("cannot_connect"))
				{
					break;
				}
				smethod_1();
			}
			return text;
		}
		catch (Exception)
		{
		}
		return "";
	}
}
