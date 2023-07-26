using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class JobHelper
{
	public static List<OrderDetail> D7AC96A4(string F6801FBE)
	{
		List<OrderDetail> result = new List<OrderDetail>();
		try
		{
			string json = new RequestXNet("", "", "", 0).RequestGet("https://tool.baostar.pro/api/jobs?fb_id=" + F6801FBE);
			if (JObject.Parse(json)["success"]!.ToString().ToLower() == "true")
			{
				result = JsonConvert.DeserializeObject<List<OrderDetail>>(JObject.Parse(json)["data"]!.ToString());
			}
		}
		catch
		{
		}
		return result;
	}

	public static void EC3BF620(string string_0, OrderDetail F191D687, bool BD8609A4, string FF2F04A8 = "")
	{
		try
		{
			if (F191D687.A2BDAC1E != 0)
			{
				RequestXNet b01F5C = new RequestXNet("", "", "", 0);
				string string_ = "{\"fb_id\":\"" + string_0 + "\", \"job_id\":" + F191D687.A2BDAC1E + ", \"success\":" + BD8609A4.ToString().ToLower() + ", \"message\":\"" + FF2F04A8 + "\"}";
				b01F5C.method_1("https://tool.baostar.pro/api/complete", string_, "application/json");
			}
		}
		catch
		{
		}
	}
}
