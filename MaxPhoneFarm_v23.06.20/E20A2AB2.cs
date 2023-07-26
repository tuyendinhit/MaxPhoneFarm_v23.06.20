using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class E20A2AB2
{
	public static string B79CC01F(string string_0)
	{
		string text = "";
		if (!string_0.EndsWith("/"))
		{
			string_0 += "/";
		}
		List<string> list = new List<string>
		{
			"story_fbid=(.*?)&", "permalink/(.*?)/", "v=(.*?)&", "post_id=(.*?)&", "v=(.*?)/", "videos/(.*?)/", "videos/(.*?)\\?", "posts/(.*?)/", "posts/(.*?)\\?", "view_tray_pagination/(.*?)/",
			"fbid=(.*?)&", "multi_permalinks=(.*?)&"
		};
		for (int i = 0; i < list.Count; i++)
		{
			text = Regex.Match(string_0, list[i].Replace("(.*?)", "\\d+")).Value;
			if (text != "")
			{
				text = text.Replace(list[i].Split(new string[1] { "(.*?)" }, StringSplitOptions.None)[0], "");
				text = text.Replace(list[i].Split(new string[1] { "(.*?)" }, StringSplitOptions.None)[1], "");
				text = text.Replace("?", "");
				if (!text.StartsWith("0"))
				{
					break;
				}
			}
			else
			{
				text = Regex.Match(string_0, list[i]).Groups[1].Value;
				if (text != "" && !text.Contains("&"))
				{
					break;
				}
			}
		}
		if (text == "" && string_0.Contains("photos"))
		{
			MatchCollection matchCollection = Regex.Matches(string_0, "/\\d+/");
			if (matchCollection.Count > 0)
			{
				text = matchCollection[matchCollection.Count - 1].Value;
				text = text.Replace("/", "");
			}
		}
		return text;
	}
}
