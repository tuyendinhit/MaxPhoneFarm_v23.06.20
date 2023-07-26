using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

internal class E004ED11
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string DFBF20B4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int C1A7652A;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int EA98C385;

	internal string BC9FAC39 = "";

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_1;

	internal string string_2 = "http://proxy.tinsoftsv.com";

	internal int E82DB69A = 0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int int_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_3;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return DFBF20B4;
		}
		[CompilerGenerated]
		set
		{
			DFBF20B4 = value;
		}
	}

	public string String_1
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

	public string CE0AE8B5
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return C1A7652A;
		}
		[CompilerGenerated]
		set
		{
			C1A7652A = value;
		}
	}

	public int B62506BF
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

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return EA98C385;
		}
		[CompilerGenerated]
		set
		{
			EA98C385 = value;
		}
	}

	public int Int32_2
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

	public int Int32_3
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public int C10D278B
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		set
		{
			int_3 = value;
		}
	}

	public E004ED11(string C31C1288, int int_4 = 0)
	{
		String_0 = C31C1288;
		String_1 = "";
		CE0AE8B5 = "";
		Int32_0 = 0;
		B62506BF = 0;
		Int32_1 = 0;
		Int32_2 = int_4;
	}

	public bool method_0()
	{
		if (method_2())
		{
			BC9FAC39 = "";
			Int32_1 = 0;
			String_1 = "";
			CE0AE8B5 = "";
			Int32_0 = 0;
			B62506BF = 0;
			string text = EE87E11D(string_2 + "/api/changeProxy.php?key=" + String_0 + "&location=" + Int32_2);
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					if (bool.Parse(jObject["success"]!.ToString()))
					{
						String_1 = jObject["proxy"]!.ToString();
						string[] array = String_1.Split(':');
						CE0AE8B5 = array[0];
						Int32_0 = int.Parse(array[1]);
						B62506BF = int.Parse(jObject["timeout"]!.ToString());
						Int32_1 = int.Parse(jObject["next_change"]!.ToString());
						BC9FAC39 = "";
						return true;
					}
					BC9FAC39 = jObject["description"]!.ToString();
				}
				catch
				{
				}
			}
			else
			{
				BC9FAC39 = "request server timeout!";
			}
		}
		else
		{
			BC9FAC39 = "Request so fast!";
		}
		return false;
	}

	public void method_1()
	{
		BC9FAC39 = "";
		String_1 = "";
		CE0AE8B5 = "";
		Int32_0 = 0;
		B62506BF = 0;
		if (String_0 != "")
		{
			EE87E11D(string_2 + "/api/stopProxy.php?key=" + String_0);
		}
	}

	public bool A91F8B85()
	{
		if (method_2())
		{
			BC9FAC39 = "";
			String_1 = "";
			CE0AE8B5 = "";
			Int32_0 = 0;
			B62506BF = 0;
			string text = EE87E11D(string_2 + "/api/getProxy.php?key=" + String_0);
			if (text != "")
			{
				try
				{
					JObject jObject = JObject.Parse(text);
					if (bool.Parse(jObject["success"]!.ToString()))
					{
						String_1 = jObject["proxy"]!.ToString();
						string[] array = String_1.Split(':');
						CE0AE8B5 = array[0];
						Int32_0 = int.Parse(array[1]);
						B62506BF = int.Parse(jObject["timeout"]!.ToString());
						Int32_1 = int.Parse(jObject["next_change"]!.ToString());
						BC9FAC39 = "";
						return true;
					}
					BC9FAC39 = jObject["description"]!.ToString();
				}
				catch
				{
				}
			}
		}
		else
		{
			BC9FAC39 = "Request so fast!";
		}
		return false;
	}

	private bool method_2()
	{
		try
		{
			DateTime dateTime = new DateTime(2001, 1, 1);
			long ticks = DateTime.Now.Ticks - dateTime.Ticks;
			int num = (int)new TimeSpan(ticks).TotalSeconds;
			if (num - E82DB69A >= 10)
			{
				E82DB69A = num;
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private string EE87E11D(string string_3)
	{
		Console.WriteLine(string_3);
		string text = "";
		try
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
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

	public static List<string> smethod_0(string D72D28B8)
	{
		List<string> list = new List<string>();
		try
		{
			RequestXNet b01F5C = new RequestXNet("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0);
			string json = b01F5C.RequestGet("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + D72D28B8);
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
