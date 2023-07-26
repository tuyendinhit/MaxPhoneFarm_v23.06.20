using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

public class JSON_Settings
{
	internal string string_0;

	internal JObject json;

	public JSON_Settings(string D399C293, bool D7BE7F11 = false)
	{
		if (D7BE7F11)
		{
			if (D399C293.Trim() == "")
			{
				D399C293 = "{}";
			}
			json = JObject.Parse(D399C293);
			return;
		}
		try
		{
			if (D399C293.Contains("\\") || D399C293.Contains("/"))
			{
				string_0 = D399C293;
			}
			else
			{
				string_0 = FileHelper.GetPathToCurrentFolder() + "\\settings\\" + D399C293 + ".json";
			}
			if (!File.Exists(string_0))
			{
				using (File.AppendText(string_0))
				{
				}
			}
			json = JObject.Parse(File.ReadAllText(string_0));
		}
		catch
		{
			json = new JObject();
		}
	}

	public Dictionary<string, object> ConvertToDictionary(JObject jObject = null)
	{
        Dictionary<string, object> dic = new Dictionary<string, object>();
        try
        {
            dic = jObject.ToObject<Dictionary<string, object>>();
            List<string> list = (from x in dic.Select(delegate (KeyValuePair<string, object> r) { return new { value = r, key = r.Key }; }) where x.value.GetType() == typeof(JObject) select x.key).ToList();
            List<string> list2 = (from x in dic.Select(delegate (KeyValuePair<string, object> r) { return new { value = r, key = r.Key }; }) where x.value.GetType() == typeof(JObject) select x.key).ToList();
            list2.ForEach(delegate (string key)
            {
                dic[key] = (from x in ((JArray)dic[key]).Values()
                            select ((JValue)x).Value).ToArray();
            });
            list.ForEach(delegate (string key)
            {
                dic[key] = ConvertToDictionary(dic[key] as JObject);
            });
        }
        catch
        {
        }
        return dic;
    }

	public JSON_Settings()
	{
		json = new JObject();
	}

	public string GetValue(string F6B684A6, string string_1 = "")
	{
		string result = string_1;
		try
		{
			result = ((json[F6B684A6] == null) ? string_1 : json[F6B684A6]!.ToString());
		}
		catch
		{
		}
		return result;
	}

	public List<string> EC378D8A(string string_1, int int_0 = 0)
	{
		List<string> list = new List<string>();
		try
		{
			list = ((int_0 != 0) ? GetValue(string_1).Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : GetValue(string_1).Split('\n').ToList());
			list = Common.RemoveEmptyItems(list);
		}
		catch
		{
		}
		return list;
	}

	public int method_0(string string_1, int E726A73C = 0)
	{
		int result = E726A73C;
		try
		{
			result = ((json[string_1] == null) ? E726A73C : Convert.ToInt32(json[string_1]!.ToString()));
		}
		catch
		{
		}
		return result;
	}

	public bool AA824D29(string A322801C, bool A72188BC = false)
	{
		bool result = A72188BC;
		try
		{
			result = ((json[A322801C] == null) ? A72188BC : Convert.ToBoolean(json[A322801C]!.ToString()));
			return result;
		}
		catch
		{
			return result;
		}
	}

	public void method_1(string C502B50B, string CB1A7F9D)
	{
		try
		{
			if (!json.ContainsKey(C502B50B))
			{
				json.Add(C502B50B, (JToken)CB1A7F9D);
			}
			else
			{
				json[C502B50B] = (JToken)CB1A7F9D;
			}
		}
		catch (Exception)
		{
		}
	}

	public void GetValue(string F91DD196, object A71AE78F)
	{
		try
		{
			json[F91DD196] = (JToken)A71AE78F.ToString();
		}
		catch
		{
		}
	}

	public void A53F37B4(string string_1, List<string> B208E73B, int F2240292 = 0)
	{
		try
		{
			json[string_1] = (JToken)string.Join("\n", B208E73B).ToString();
			if (F2240292 == 0)
			{
				json[string_1] = (JToken)string.Join("\n", B208E73B).ToString();
			}
			else
			{
				json[string_1] = (JToken)string.Join("\n|\n", B208E73B).ToString();
			}
		}
		catch
		{
		}
	}

	public void method_3(string string_1, List<string> list_0)
	{
		try
		{
			bool flag = false;
			foreach (string item in list_0)
			{
				if (item.Contains("\n"))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				json[string_1] = (JToken)string.Join("\n|\n", list_0).ToString();
			}
			else
			{
				json[string_1] = (JToken)string.Join("\n", list_0).ToString();
			}
		}
		catch
		{
		}
	}

	public void method_4(string string_1)
	{
		try
		{
			json.Remove(string_1);
		}
		catch
		{
		}
	}

	public void method_5(string string_1 = "")
	{
		try
		{
			if (string_1 == "")
			{
				string_1 = string_0;
			}
			File.WriteAllText(string_1, json.ToString());
		}
		catch
		{
		}
	}

	public string C71A4EA4()
	{
		string result = "";
		try
		{
			result = json.ToString().Replace("\r\n", "");
		}
		catch (Exception)
		{
		}
		return result;
	}
}
