using System;
using System.Threading;
using Newtonsoft.Json.Linq;

internal class Class6
{
	internal object FDA6FA20 = new object();

	internal object E63F2103 = new object();

	internal int int_0;

	internal string CDB456B2;

	internal string A39730A1;

	internal string B8368F29 = "";

	internal int B42E540A = 0;

	internal int int_1 = 0;

	internal int int_2 = 3;

	public Class6(string E60B2701, string string_0, int B115C52F, int int_3)
	{
		CDB456B2 = E60B2701;
		A39730A1 = string_0;
		int_2 = int_3;
		B8368F29 = "";
		int_0 = B115C52F;
	}

	public bool FD9C5987()
	{
		bool result = false;
		try
		{
			string string_ = "https://api.proxyv6.net/api/reset-ip-manual?api_key=" + CDB456B2;
			string string_2 = "{\"host\": \"" + A39730A1.Split(':')[0] + "\", \"port\": " + A39730A1.Split(':')[1] + "}";
			RequestXNet b01F5C = new RequestXNet("", "", "", 0);
			string json = b01F5C.method_1(string_, string_2, "application/json");
			if (JObject.Parse(json)["message"]!.ToString() == "SUCCESS")
			{
				for (int i = 0; i < 120; i++)
				{
					if (!method_1())
					{
						Thread.Sleep(1000);
						continue;
					}
					Thread.Sleep(1000);
					return true;
				}
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public void method_0()
	{
		lock (FDA6FA20)
		{
			B42E540A--;
			if (B42E540A == 0 && int_1 == int_2)
			{
				int_1 = 0;
			}
		}
	}

	public bool method_1()
	{
		bool result = false;
		try
		{
			string string_ = "https://api.proxyv6.net/api/check-list-proxy?api_key=" + CDB456B2;
			string text = A39730A1.Split(':')[2] + ":" + A39730A1.Split(':')[3] + "@" + A39730A1.Split(':')[0] + ":" + A39730A1.Split(':')[1];
			string string_2 = "{\"proxies\": [\"" + text + "\"]}";
			RequestXNet b01F5C = new RequestXNet("", "", "", 0);
			string json = b01F5C.method_1(string_, string_2, "application/json");
			result = Convert.ToBoolean(JObject.Parse(json)["message"]!.ToString() == "SUCCESS" && JObject.Parse(json)["data"]!["ip"]!.ToString() != "");
			return result;
		}
		catch
		{
			return result;
		}
	}
}
