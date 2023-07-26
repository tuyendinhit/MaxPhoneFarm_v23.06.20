using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class GeneratorEmail
{
	internal string string_0 = "";

	internal string string_1 = "";

	internal string EE845F35 = "";

	public GeneratorEmail()
	{
	}

	public GeneratorEmail(string string_2)
	{
		string_0 = string_2;
		string_1 = string_0.Split('@')[1];
		EE845F35 = string_0.Split('@')[0];
	}

	public string method_0(int E8B39B21, int int_0)
	{
		if (string_0.Split('@').Length < 2)
		{
			return "";
		}
		RequestXNet b01F5C = new RequestXNet("", "", "", 0);
		int tickCount = Environment.TickCount;
		do
		{
			List<string> list = new List<string>();
			string input = b01F5C.RequestGet("https://generator.email/" + string_1 + "/" + EE845F35);
			foreach (Match item in Regex.Matches(input, "href=\"(/" + string_1 + "/" + EE845F35 + "/.*?)\""))
			{
				list.Add(item.Groups[1].Value);
			}
			while (true)
			{
				string text = EmailHelper.GetOtp(input, E8B39B21);
				if (text != "")
				{
					text = Regex.Match(text, "c=(\\d+)&").Value;
					if (text != "")
					{
						return text;
					}
				}
				if (list.Count == 0)
				{
					break;
				}
				input = b01F5C.RequestGet("https://generator.email/" + list[0]);
				list.RemoveAt(0);
			}
			Common.DelayTime(3.0);
		}
		while (Environment.TickCount - tickCount < int_0 * 1000);
		return "";
	}

	public string E28B883B()
	{
		if (string_1 == "")
		{
			return "";
		}
		EE845F35 = Common.A8AF5A8E((from F302DA86 in SetupFolder.smethod_3()
			orderby Guid.NewGuid()
			select F302DA86).First() + (from string_0 in SetupFolder.F68AD388()
			orderby Guid.NewGuid()
			select string_0).First()).Replace(" ", "").ToLower() + Common.CreateRandomNumber(6);
		return F6865391();
	}

	public string F6865391()
	{
		return EE845F35 + "@" + string_1;
	}
}
