using System;
using System.Threading;
using Newtonsoft.Json.Linq;

public class GClass4
{
	internal int int_0;

	internal string string_0;

	internal string C338638E;

	internal string string_1 = "";

	internal bool E1992BA5 = true;

	internal int int_1 = 0;

	internal int int_2 = 0;

	internal int int_3 = 3;

	internal string string_2 = "";

	public GClass4(string string_3, string D9A54115, int int_4, int B29D00BF, string string_4)
	{
		string_0 = string_3;
		C338638E = D9A54115;
		int_3 = B29D00BF;
		string_1 = "";
		int_0 = int_4;
		method_0(string_4);
	}

	private void EC2D3084(string D4840F3F)
	{
	}

	public bool EC293F16()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/reset?proxy=" + C338638E;
			RequestXNet b01F5C = new RequestXNet("", "", "", 0);
			string text2 = b01F5C.RequestGet(text);
			EC2D3084(text + ": " + text2);
			JObject jObject = JObject.Parse(text2);
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"]!.ToString() == "command_sent" || JObject.Parse(text2)["msg"]!.ToString() == "OK" || JObject.Parse(text2)["msg"]!.ToString().ToLower() == "ok"))
			{
				result = true;
				return result;
			}
			if (jObject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"]!.ToString().ToLower() == "0")
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public bool F7064A95()
	{
		bool result = false;
		try
		{
			_ = Environment.TickCount;
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/reset?proxy=" + C338638E;
			RequestXNet b01F5C = new RequestXNet("", "", "", 0);
			string text2 = b01F5C.RequestGet(text);
			EC2D3084(text + ": " + text2);
			JObject jObject = JObject.Parse(text2);
			bool flag = false;
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"]!.ToString() == "command_sent" || JObject.Parse(text2)["msg"]!.ToString() == "OK" || JObject.Parse(text2)["msg"]!.ToString().ToLower() == "ok"))
			{
				flag = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"]!.ToString().ToLower() == "0")
			{
				flag = true;
			}
			if (flag)
			{
				return C63D9EB0();
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	public void F618B2B9(int int_4 = 1)
	{
		int_1--;
		if (int_4 == 0 && int_1 == 0 && int_2 == int_3)
		{
			int_2 = 0;
		}
	}

	public bool C63D9EB0(int int_4 = -1)
	{
		if (int_4 == -1)
		{
			int_4 = SettingsTool.GetSettings("configGeneral").method_0("nudDelayCheckIPObcProxy", 5) * 60;
		}
		int tickCount = Environment.TickCount;
		bool flag = false;
		try
		{
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/status?proxy=" + C338638E;
			RequestXNet b01F5C = new RequestXNet("", "", "", 0);
			string text2 = "";
			do
			{
				text2 = b01F5C.RequestGet(text);
				EC2D3084(text + ": " + text2);
				try
				{
					if (!text2.Contains("public_ip_v6") && !text2.Contains("public_ip"))
					{
						flag = Convert.ToBoolean(JObject.Parse(text2)["status"]!.ToString());
					}
					else
					{
						string text3 = C338638E.Split(':')[1];
						if (text3.StartsWith("4") || text3.StartsWith("5"))
						{
							flag = JObject.Parse(text2)["public_ip"]!.ToString() != "" && JObject.Parse(text2)["public_ip"]!.ToString() != "CONNECT_INTERNET_ERROR";
						}
						else if (text3.StartsWith("6") || text3.StartsWith("7"))
						{
							flag = JObject.Parse(text2)["public_ip_v6"]!.ToString() != "" && JObject.Parse(text2)["public_ip_v6"]!.ToString() != "CONNECT_INTERNET_ERROR";
						}
					}
				}
				catch
				{
					flag = JObject.Parse(text2)["error_code"]!.ToString() == "0";
				}
				Thread.Sleep(1000);
				if (flag)
				{
					return flag;
				}
			}
			while (Environment.TickCount - tickCount < int_4 * 1000);
			return flag;
		}
		catch
		{
			return flag;
		}
	}

	public string D09F8792()
	{
		return string_2;
	}

	public void method_0(string DD1BAD8D)
	{
		string_2 = DD1BAD8D;
	}

	public string F90D0C17()
	{
		return string_0;
	}

	public string AA11A98C()
	{
		return C338638E.Split(':')[1];
	}
}
