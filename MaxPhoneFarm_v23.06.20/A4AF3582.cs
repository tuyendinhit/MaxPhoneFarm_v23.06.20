using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

internal class A4AF3582
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string AC8D6D3F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string A7148C39;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int D90BC4A9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int E1A83081;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_1;

	internal object object_0 = new object();

	internal object FA11C8A7 = new object();

	internal string string_1 = "";

	internal string string_2 = "http://proxy.tinsoftsv.com";

	internal int B109DEA2 = 0;

	internal bool C68AB0BF = true;

	internal int B42BE12D = 0;

	internal int E4BD2CB9 = 0;

	internal int int_2 = 3;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return AC8D6D3F;
		}
		[CompilerGenerated]
		set
		{
			AC8D6D3F = value;
		}
	}

	public string FB3FBD84
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return A7148C39;
		}
		[CompilerGenerated]
		set
		{
			A7148C39 = value;
		}
	}

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return D90BC4A9;
		}
		[CompilerGenerated]
		set
		{
			D90BC4A9 = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return E1A83081;
		}
		[CompilerGenerated]
		set
		{
			E1A83081 = value;
		}
	}

	public int Int32_2
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public int D380452C
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public A4AF3582(string string_3, int D5B9A182, int B58FFD22 = 0)
	{
		String_0 = string_3;
		FB3FBD84 = "";
		String_1 = "";
		Int32_0 = 0;
		Int32_1 = 0;
		Int32_2 = 0;
		D380452C = B58FFD22;
		int_2 = D5B9A182;
		B42BE12D = 0;
		E4BD2CB9 = 0;
		C68AB0BF = true;
	}

	public string BB86882A()
	{
		lock (object_0)
		{
			if (B42BE12D == 0)
			{
				if (E4BD2CB9 > 0 && E4BD2CB9 < int_2)
				{
					if (C5B54607() < 30 && !method_0())
					{
						return "0";
					}
				}
				else if (!method_0())
				{
					return "0";
				}
			}
			else
			{
				if (E4BD2CB9 >= int_2)
				{
					return "2";
				}
				if (C5B54607() < 30 && !method_0())
				{
					return "0";
				}
			}
			E4BD2CB9++;
			B42BE12D++;
			return "1";
		}
	}

	public void F5BB9188()
	{
		lock (FA11C8A7)
		{
			B42BE12D--;
			if (B42BE12D == 0 && E4BD2CB9 == int_2)
			{
				E4BD2CB9 = 0;
			}
		}
	}

	public bool method_0()
	{
		lock (FA11C8A7)
		{
			if (method_3())
			{
				string_1 = "";
				Int32_2 = 0;
				FB3FBD84 = "";
				String_1 = "";
				Int32_0 = 0;
				Int32_1 = 0;
				string text = F7260300(string_2 + "/api/changeProxy.php?key=" + String_0 + "&location=" + D380452C);
				if (text != "")
				{
					try
					{
						JObject jObject = JObject.Parse(text);
						if (bool.Parse(jObject["success"]!.ToString()))
						{
							FB3FBD84 = jObject["proxy"]!.ToString();
							string[] array = FB3FBD84.Split(':');
							String_1 = array[0];
							Int32_0 = int.Parse(array[1]);
							Int32_1 = int.Parse(jObject["timeout"]!.ToString());
							Int32_2 = int.Parse(jObject["next_change"]!.ToString());
							string_1 = "";
							return true;
						}
						string_1 = jObject["description"]!.ToString();
						Int32_2 = int.Parse(jObject["next_change"]!.ToString());
					}
					catch
					{
					}
				}
				else
				{
					string_1 = "request server timeout!";
				}
			}
			else
			{
				string_1 = "Request so fast!";
			}
			return false;
		}
	}

	public string method_1()
	{
		while (!method_2())
		{
		}
		return FB3FBD84;
	}

	public int C5B54607()
	{
		while (!method_2())
		{
		}
		return Int32_1;
	}

	public int EF01E391()
	{
		while (!method_2())
		{
		}
		return Int32_2;
	}

	public bool method_2()
	{
		lock (FA11C8A7)
		{
			string_1 = "";
			Int32_2 = 0;
			FB3FBD84 = "";
			String_1 = "";
			Int32_0 = 0;
			Int32_1 = 0;
			string text = F7260300(string.Concat(new object[3] { string_2, "/api/getProxy.php?key=", String_0 }));
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					if (bool.Parse(jObject["success"]!.ToString()))
					{
						FB3FBD84 = jObject["proxy"]!.ToString();
						string[] array = FB3FBD84.Split(':');
						String_1 = array[0];
						Int32_0 = int.Parse(array[1]);
						Int32_1 = int.Parse(jObject["timeout"]!.ToString());
						Int32_2 = int.Parse(jObject["next_change"]!.ToString());
						string_1 = "";
						return true;
					}
					string_1 = jObject["description"]!.ToString();
					if (jObject["next_change"] != null)
					{
						Int32_2 = int.Parse(jObject["next_change"]!.ToString());
					}
				}
				catch (Exception)
				{
				}
			}
			else
			{
				string_1 = "request server timeout!";
			}
			return false;
		}
	}

	private bool method_3()
	{
		try
		{
			DateTime dateTime = new DateTime(2001, 1, 1);
			long ticks = DateTime.Now.Ticks - dateTime.Ticks;
			int num = (int)new TimeSpan(ticks).TotalSeconds;
			if (num - B109DEA2 >= 10)
			{
				B109DEA2 = num;
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private string F7260300(string string_3)
	{
		Console.WriteLine(string_3);
		string text = "";
		try
		{
			using (WebClient webClient = new WebClient())
			{
				text = webClient.DownloadString(string_3);
			}
			if (string.IsNullOrEmpty(text))
			{
				text = "";
			}
		}
		catch
		{
			text = "";
		}
		return text;
	}

	private static string B11558B6(string string_3)
	{
		Console.WriteLine(string_3);
		string text = "";
		try
		{
			using (WebClient webClient = new WebClient())
			{
				text = webClient.DownloadString(string_3);
			}
			if (string.IsNullOrEmpty(text))
			{
				text = "";
			}
		}
		catch
		{
			text = "";
		}
		return text;
	}

	public static bool smethod_0(string string_3)
	{
		string text = B11558B6("http://proxy.tinsoftsv.com/api/getKeyInfo.php?key=" + string_3);
		if (text != "")
		{
			JObject jObject = JObject.Parse(text);
			if (bool.Parse(jObject["success"]!.ToString()))
			{
				return true;
			}
		}
		return false;
	}

	public static List<string> E213E5B4(string DD15C73C)
	{
		List<string> list = new List<string>();
		try
		{
			RequestXNet b01F5C = new RequestXNet("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0);
			string json = b01F5C.RequestGet("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + DD15C73C);
			JObject jObject = JObject.Parse(json);
			foreach (JToken item in (IEnumerable<JToken>)(jObject["data"]!))
			{
				if (Convert.ToBoolean(item["success"]!.ToString()))
				{
					list.Add(item["key"]!.ToString());
				}
			}
		}
		catch
		{
		}
		return list;
	}
}
