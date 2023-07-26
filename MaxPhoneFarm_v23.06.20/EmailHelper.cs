using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

internal class EmailHelper
{
	public static string GetOtp(string body, int type, string uidFb = "")
	{
        string text = "";
        switch (type)
        {
            case 0:
                text = Regex.Match(body, "https://www.facebook.com/confirmcontact.php(.*?)\"").Value.Trim().Replace("&amp;", "&").Replace("\"", "");
                if (text == "")
                {
                    text = Regex.Match(body, "https://www.facebook.com/confirmcontact.php(.*?)\n").Value.Trim().Replace("&amp;", "&").Replace("\"", "");
                }
                if (text == "")
                {
                    text = Regex.Match(body, "https://www.facebook.com/n/\\?confirmemail.php(.*?)\n").Value.Trim().Replace("&amp;", "&").Replace("\"", "");
                }
                break;
            case 1:
                text = Regex.Match(body, ">(\\d{8})<").Groups[1].Value.Trim();
                if (text == "")
                {
                    text = Regex.Match(body, "\\d{8}").Value.Trim();
                }
                if (uidFb.StartsWith(text))
                {
                    text = "";
                }
                break;
            case 2:
                {
                    string value = Regex.Match(body, "\\?n=(.*?)&").Groups[1].Value;
                    if (value == "")
                    {
                        value = Regex.Match(body, "reset code:(\\d+)").Groups[1].Value;
                    }
                    if (value == "")
                    {
                        value = Regex.Match(body, ":(\\d+)N").Groups[1].Value;
                    }
                    string text2 = Regex.Match(body, ";id=(.*?)&").Groups[1].Value;
                    if (text2 == "")
                    {
                        text2 = uidFb;
                    }
                    if (value != "" && text2 != "")
                    {
                        text = "https://m.facebook.com/recover/password/?u=" + text2 + "&n=" + value + "&fl=default_recover&sih=0&msgr=0";
                    }
                    break;
                }
            case 3:
                text = Regex.Match(body, ">\\d+<").Value.Trim().Replace(">", "").Replace("<", "");
                if (text == "")
                {
                    text = Regex.Match(body, "Security code: \\d+").Value;
                    text = Regex.Match(text, "\\d+").Value;
                }
                break;
            case 4:
                text = Regex.Match(body, "c=(\\d+)&").Groups[1].Value;
                break;
            case 5:
                text = Regex.Match(body, "code=(\\d+)&").Groups[1].Value;
                break;
        }
        return text;
    }

	internal static string D8097D8F(int int_0, string string_0, string string_1, string string_2 = "", int int_1 = 60)
	{
		RequestXNet b01F5C = new RequestXNet("", "", "", 0);
		string_0 = string_0.Substring(0, string_0.LastIndexOf("=") + 1) + string_1;
		int tickCount = Environment.TickCount;
		do
		{
			string text = b01F5C.RequestGet(string_0);
			try
			{
				text = "{\"data\":" + text + "}";
				JObject jObject = JObject.Parse(text);
				for (int num = jObject["data"].Count() - 1; num >= 0; num--)
				{
					jObject["data"]![num]!["created_at"]!.ToString();
					string string_3 = jObject["data"]![num]!["body"]!.ToString();
					string text2 = GetOtp(string_3, int_0, string_2);
					if (text2 != "")
					{
						text2 = Regex.Match(text2, "c=(\\d+)&").Value;
						if (text2 != "")
						{
							return text2;
						}
					}
				}
			}
			catch
			{
			}
			Common.DelayTime(3.0);
		}
		while (Environment.TickCount - tickCount < int_1 * 1000);
		return "";
	}

	internal static string smethod_1(int int_0, string string_0, string string_1, string C42261B9 = "", int int_1 = 60)
	{
		RequestXNet b01F5C = new RequestXNet("", "", "", 0);
		string_0 = string_0.Substring(0, string_0.LastIndexOf("=") + 1) + string_1;
		int tickCount = Environment.TickCount;
		do
		{
			string text = b01F5C.RequestGet(string_0);
			try
			{
				text = "{\"data\":" + text + "}";
				JObject jObject = JObject.Parse(text);
				int num = jObject["data"].Count() - 1;
				while (num >= 0)
				{
					jObject["data"]![num]!["created_at"]!.ToString();
					string input = jObject["data"]![num]!["body"]!.ToString();
					string value = Regex.Match(input, ">(\\d+)<").Groups[1].Value;
					if (!(value != ""))
					{
						num--;
						continue;
					}
					return value;
				}
			}
			catch
			{
			}
			Common.DelayTime(3.0);
		}
		while (Environment.TickCount - tickCount < int_1 * 1000);
		return "";
	}

	public static string smethod_2(string string_0, int B7A6412B, string C39E049F, string string_1, int int_0 = 60, string string_2 = "")
	{
		try
		{
			string text = "";
			GClass13 gClass = new GClass13();
			int tickCount = Environment.TickCount;
			do
			{
				string text2 = gClass.method_0(string_0 + "/laycode.php?mail=" + C39E049F + "&pass=" + string_1 + "&type=facebook");
				if (!(text2 == "Err"))
				{
					if (text2 != "")
					{
						if (text2.Contains("AUTHENTICATE failed"))
						{
							return "fail";
						}
						try
						{
							JObject jObject = JObject.Parse(text2);
							foreach (JToken item in (IEnumerable<JToken>)(jObject["emails"]!))
							{
								if (item["title"]!.ToString().Contains("Facebook"))
								{
									string string_3 = item["body"]!.ToString();
									DateTime value = Common.DC8AAF95(Convert.ToDouble(item["sendUDate"]!.ToString()));
									double totalMinutes = DateTime.Now.Subtract(value).TotalMinutes;
									if (totalMinutes > 5.0)
									{
										break;
									}
									text = GetOtp(string_3, B7A6412B, string_2);
									if (text != "")
									{
										return text;
									}
								}
							}
						}
						catch
						{
						}
					}
					Common.DelayTime(3.0);
					continue;
				}
				return "";
			}
			while (Environment.TickCount - tickCount <= int_0 * 1000);
		}
		catch (Exception)
		{
		}
		return "";
	}
}
