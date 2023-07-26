using System;
using System.IO;
using System.Threading;
using Newtonsoft.Json.Linq;

public class D59F6E91
{
	internal int int_0;

	internal string string_0;

	internal string string_1;

	internal string F0B80632 = "";

	internal bool bool_0 = true;

	internal int B682241D = 0;

	internal int FE351F18 = 0;

	internal int E995AF92 = 3;

	public D59F6E91(string string_2, string B83C8C10, int int_1, int E9B30629)
	{
		string_0 = string_2;
		string_1 = B83C8C10;
		E995AF92 = E9B30629;
		F0B80632 = "";
		int_0 = int_1;
	}

	private void B624C02E(string AEA65A2C)
	{
		try
		{
			File.AppendAllText("GetProxy.txt", AEA65A2C + "\r\n");
		}
		catch
		{
		}
	}

	public int method_0()
	{
		bool flag = false;
		try
		{
			_ = Environment.TickCount;
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/reset?proxy=" + string_1;
			RequestXNet b01F5C = new RequestXNet("", "", "", 0);
			string text2 = b01F5C.RequestGet(text);
			if (text2.Contains("reset_too_much"))
			{
				Thread.Sleep(10000);
				return 2;
			}
			JObject jObject = JObject.Parse(text2);
			if (jObject.ContainsKey("msg") && (JObject.Parse(text2)["msg"]!.ToString() == "command_sent" || JObject.Parse(text2)["msg"]!.ToString() == "OK" || JObject.Parse(text2)["msg"]!.ToString().ToLower() == "ok"))
			{
				flag = true;
			}
			else if (jObject.ContainsKey("error_code") && JObject.Parse(text2)["error_code"]!.ToString().ToLower() == "0")
			{
				flag = true;
			}
			else
			{
				B624C02E(text + ": " + text2);
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	public int B51E7096()
	{
		try
		{
			int num = 0;
			for (int i = 0; i < 5; i++)
			{
				num = method_0();
				if (num == 1)
				{
					num = (C9360086() ? 1 : 0);
				}
				if (num == 1)
				{
					break;
				}
			}
			return num;
		}
		catch
		{
		}
		return 0;
	}

	public void E82C7A27(int A2A9D798)
	{
		B682241D--;
		if (A2A9D798 == 0 && B682241D == 0 && FE351F18 == E995AF92)
		{
			FE351F18 = 0;
		}
	}

	public bool C9360086(int B0B54A30 = 300)
	{
		int tickCount = Environment.TickCount;
		bool flag = false;
		try
		{
			string_0 = string_0.TrimEnd('/');
			string text = string_0 + "/status?proxy=" + string_1;
			RequestXNet b01F5C = new RequestXNet("", "", "", 0);
			string text2 = "";
			do
			{
				text2 = b01F5C.RequestGet(text);
				try
				{
					if (!(flag = Convert.ToBoolean(JObject.Parse(text2)["status"]!.ToString())))
					{
						string text3 = string_1.Split(':')[1];
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
					try
					{
						flag = JObject.Parse(text2)["error_code"]!.ToString() == "0";
					}
					catch
					{
					}
				}
				if (!flag)
				{
					Thread.Sleep(1000);
					continue;
				}
				return flag;
			}
			while (Environment.TickCount - tickCount < B0B54A30 * 1000);
			return flag;
		}
		catch
		{
			return flag;
		}
	}
}
