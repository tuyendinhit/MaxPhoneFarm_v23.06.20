using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

internal class Class27
{
	internal Random E02074B7 = new Random();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string A6BCF0BC;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string EA1AF397;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int B4854916;

	internal object D2319EA0 = new object();

	internal object object_0 = new object();

	internal int D422C29C = 0;

	internal int int_3 = 0;

	internal int int_4 = 3;

	public string A0A8A8A3
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

	public string A82E6C25
	{
		[CompilerGenerated]
		get
		{
			return A6BCF0BC;
		}
		[CompilerGenerated]
		set
		{
			A6BCF0BC = value;
		}
	}

	public int Int32_0
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

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return EA1AF397;
		}
		[CompilerGenerated]
		set
		{
			EA1AF397 = value;
		}
	}

	public int Int32_1
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

	public int CA04930B
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

	public int Int32_2
	{
		[CompilerGenerated]
		get
		{
			return B4854916;
		}
		[CompilerGenerated]
		set
		{
			B4854916 = value;
		}
	}

	public Class27(string string_1, int int_5, int CE955B1A)
	{
		A0A8A8A3 = string_1;
		A82E6C25 = "";
		String_0 = "";
		CA04930B = 0;
		Int32_2 = 0;
		Int32_0 = int_5;
		int_4 = CE955B1A;
		D422C29C = 0;
		int_3 = 0;
	}

	public static bool smethod_0(string string_1)
	{
		string aB11AF2B = "{\"api_key\": \"" + string_1 + "\"}";
		string text = DF150A02("https://tmproxy.com/api/proxy/stats", aB11AF2B);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				string string_2 = jObject["data"]!["expired_at"]!.ToString();
				DateTime t = Common.F11F4A37(string_2, "HH:mm:ss dd/MM/yyyy");
				if (DateTime.Compare(t, DateTime.Now) > 0)
				{
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string B4B59F37()
	{
		lock (D2319EA0)
		{
			if (D422C29C == 0)
			{
				if (int_3 > 0 && int_3 < int_4)
				{
					if (FA11982C() < 30 && !FAB161BB())
					{
						return "0";
					}
				}
				else if (!FAB161BB())
				{
					return "0";
				}
			}
			else
			{
				if (int_3 >= int_4)
				{
					return "2";
				}
				if (FA11982C() < 30 && !FAB161BB())
				{
					return "0";
				}
			}
			int_3++;
			D422C29C++;
			return "1";
		}
	}

	public int FA11982C()
	{
		method_3();
		return Int32_1;
	}

	public void method_0()
	{
		lock (object_0)
		{
			D422C29C--;
			if (D422C29C == 0 && int_3 == int_4)
			{
				int_3 = 0;
			}
		}
	}

	public string method_1(string CC93EB26)
	{
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(CC93EB26));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	public bool FAB161BB()
	{
		Int32_2 = 0;
		A82E6C25 = "";
		String_0 = "";
		CA04930B = 0;
		string arg = "abccd9f3bf38f38414cb87e36f76c8e4";
		int num = 8989;
		string value = method_2("https://tmproxy.com/api/proxy/current-time");
		long num2 = 0L;
		try
		{
			num2 = Convert.ToInt64(value);
		}
		catch
		{
			num2 = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
		}
		long num3 = Convert.ToInt64(num2 / 60L) + num;
		string cC93EB = $"{arg}{A0A8A8A3}{num3}";
		string text = method_1(cC93EB);
		string aB11AF2B = "{\"api_key\": \"" + A0A8A8A3 + "\",\"sign\": \"" + text + "\"}";
		string text2 = DF150A02("https://tmproxy.com/api/proxy/get-new-proxy", aB11AF2B);
		if (text2 != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text2);
				string value2 = Regex.Match(JObject.Parse(text2)["message"]!.ToString(), "\\d+").Value;
				Int32_2 = ((!(value2 == "")) ? int.Parse(value2) : 0);
				if (Int32_2 == 0)
				{
					if (Int32_0 == 0)
					{
						A82E6C25 = jObject["data"]!["https"]!.ToString();
						string[] array = A82E6C25.Split(':');
						String_0 = array[0];
						CA04930B = int.Parse(array[1]);
					}
					else
					{
						A82E6C25 = jObject["data"]!["socks5"]!.ToString();
						string[] array2 = A82E6C25.Split(':');
						String_0 = array2[0];
						CA04930B = int.Parse(array2[1]);
					}
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	private string method_2(string BB97AC0C)
	{
		string text = "";
		try
		{
			text = new GClass13().method_0(BB97AC0C);
			if (string.IsNullOrEmpty(text))
			{
				text = "";
			}
		}
		catch
		{
		}
		return text;
	}

	public bool method_3()
	{
		Int32_2 = 0;
		A82E6C25 = "";
		String_0 = "";
		CA04930B = 0;
		Int32_1 = 0;
		string aB11AF2B = "{\"api_key\": \"" + A0A8A8A3 + "\"}";
		string text = DF150A02("https://tmproxy.com/api/proxy/get-current-proxy", aB11AF2B);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["code"]!.ToString() == "0")
				{
					Int32_2 = Convert.ToInt32(jObject["data"]!["next_request"]!.ToString());
					Int32_1 = Convert.ToInt32(jObject["data"]!["timeout"]!.ToString());
					if (Int32_0 == 0)
					{
						A82E6C25 = jObject["data"]!["https"]!.ToString();
						string[] array = A82E6C25.Split(':');
						String_0 = array[0];
						CA04930B = int.Parse(array[1]);
					}
					else
					{
						A82E6C25 = jObject["data"]!["socks5"]!.ToString();
						string[] array2 = A82E6C25.Split(':');
						String_0 = array2[0];
						CA04930B = int.Parse(array2[1]);
					}
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string C6036886()
	{
		while (!method_3())
		{
		}
		return A82E6C25;
	}

	private static string DF150A02(string string_1, string AB11AF2B)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			HttpContent httpContent_0 = new StringContent(AB11AF2B, Encoding.UTF8, "application/json");
			Task<string> task = Task.Run(() => RequestHelper.PostURI(new Uri(string_1), httpContent_0));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Request Post");
			return "";
		}
	}

	public static string smethod_1(string D42EC2B5)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Task<string> task = Task.Run(() => RequestHelper.GetURI(new Uri(D42EC2B5)));
			task.Wait();
			return task.Result;
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Request get");
			return "";
		}
	}
}
