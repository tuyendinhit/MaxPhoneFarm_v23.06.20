using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

internal class Class7
{
	internal Random random_0 = new Random();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string E221BBA8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string BA1F169C;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int A819631F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int B895F6BA;

	internal object object_0 = new object();

	internal int int_0 = 0;

	internal int int_1 = 0;

	internal int int_2 = 3;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return E221BBA8;
		}
		[CompilerGenerated]
		set
		{
			E221BBA8 = value;
		}
	}

	public string FF94CC90
	{
		[CompilerGenerated]
		get
		{
			return BA1F169C;
		}
		[CompilerGenerated]
		set
		{
			BA1F169C = value;
		}
	}

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return A819631F;
		}
		[CompilerGenerated]
		set
		{
			A819631F = value;
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

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return B895F6BA;
		}
		[CompilerGenerated]
		set
		{
			B895F6BA = value;
		}
	}

	public Class7(string A88A23B8, int int_3, int F81D7A1E)
	{
		String_0 = A88A23B8;
		FF94CC90 = "";
		String_1 = "";
		Int32_1 = 0;
		Int32_0 = int_3;
		int_2 = F81D7A1E;
		int_0 = 0;
		int_1 = 0;
	}

	public void method_0()
	{
		lock (object_0)
		{
			int_0--;
			if (int_0 == 0 && int_1 == int_2)
			{
				int_1 = 0;
			}
		}
	}

	public bool method_1()
	{
		FF94CC90 = "";
		String_1 = "";
		Int32_1 = 0;
		string text = smethod_1("http://proxy.shoplike.vn/Api/getNewProxy?access_token=" + String_0);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["status"]!.ToString() == "success")
				{
					if (Int32_0 == 0)
					{
						FF94CC90 = jObject["data"]!["proxy"]!.ToString();
						string[] array = FF94CC90.Split(':');
						String_1 = array[0];
						Int32_1 = int.Parse(array[1]);
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

	public bool method_2()
	{
		FF94CC90 = "";
		String_1 = "";
		Int32_1 = 0;
		string text = smethod_1("http://proxy.shoplike.vn/Api/getCurrentProxy?access_token=" + String_0);
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["status"]!.ToString() == "success")
				{
					FF94CC90 = jObject["data"]!["proxy"]!.ToString();
					string[] array = FF94CC90.Split(':');
					String_1 = array[0];
					Int32_1 = int.Parse(array[1]);
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string BA00E998()
	{
		while (!method_2())
		{
		}
		return FF94CC90;
	}

	private static string smethod_0(string string_1, string FA82B115)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			HttpContent httpContent_0 = new StringContent(FA82B115, Encoding.UTF8, "application/json");
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

	public static string smethod_1(string B10FB62B)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Task<string> task = Task.Run(() => RequestHelper.GetURI(new Uri(B10FB62B)));
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
