using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class GClass3
{
	internal string B58D4F0B = "";

	internal string string_0 = "";

	internal string CD28D497 = "";

	internal List<GClass4> list_0;

	public GClass3(string C2366431)
	{
		CD28D497 = C2366431;
		list_0 = new List<GClass4>();
	}

	public string F70C22B4()
	{
		return CD28D497;
	}

	public void method_0(GClass4 gclass4_0)
	{
		B58D4F0B = gclass4_0.F90D0C17();
		string_0 = gclass4_0.AA11A98C();
		list_0.Add(gclass4_0);
	}

	public List<GClass4> method_1()
	{
		return list_0;
	}

	public List<GClass4> method_2()
	{
		List<GClass4> list = new List<GClass4>();
		for (int i = 0; i < list_0.Count; i++)
		{
			GClass4 gClass = list_0[i];
			if (gClass.E1992BA5 && gClass.int_2 < gClass.int_3)
			{
				list.Add(gClass);
			}
		}
		return list;
	}

	public bool method_3()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string text = B58D4F0B.TrimEnd('/') + "/reset?proxy=" + string_0 + "&type=deep";
			RequestXNet b01F5C = new RequestXNet("", "", "", 0);
			string json = b01F5C.RequestGet(text);
			JObject jObject = JObject.Parse(json);
			if (jObject.ContainsKey("msg") && (JObject.Parse(json)["msg"]!.ToString() == "command_sent" || JObject.Parse(json)["msg"]!.ToString() == "OK" || JObject.Parse(json)["msg"]!.ToString().ToLower() == "ok"))
			{
				result = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(json)["error_code"]!.ToString().ToLower() == "0")
			{
				result = true;
			}
		}
		catch
		{
		}
		foreach (GClass4 item in list_0)
		{
			item.int_2 = 0;
		}
		return result;
	}

	public bool method_4()
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				GClass4 gClass = list_0[num];
				if (gClass.E1992BA5 && (gClass.int_2 != gClass.int_3 || gClass.int_1 != 0))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static Dictionary<string, List<string>> B0B8FE21(string ED31219E)
	{
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		try
		{
			ED31219E = ED31219E.TrimEnd('/') + "/api/v1/dongles/all";
			string text = new RequestXNet("", "", "", 0).RequestGet(ED31219E);
			text = "{data:" + text + "}";
			JObject jObject = JObject.Parse(text);
			foreach (JToken item2 in (IEnumerable<JToken>)(jObject["data"]!))
			{
				string key = item2["rootId"]!.ToString();
				string item = item2["httpPortV6"]!.ToString();
				if (!dictionary.ContainsKey(key))
				{
					dictionary.Add(key, new List<string>());
				}
				dictionary[key].Add(item);
			}
		}
		catch (Exception)
		{
		}
		return dictionary;
	}

	public static GClass3 smethod_0(List<GClass3> list_1, string string_1)
	{
		GClass3 result = null;
		for (int i = 0; i < list_1.Count; i++)
		{
			if (list_1[i].F70C22B4() == string_1)
			{
				result = list_1[i];
				break;
			}
		}
		return result;
	}
}
