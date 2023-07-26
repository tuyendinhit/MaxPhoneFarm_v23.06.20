using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

internal class Class4
{
	internal Random C4846E00 = new Random();

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int E8A55336;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string B0A3631F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int E4A4308F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int int_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string BC064984;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_2;

	internal object A30B5503 = new object();

	internal object object_0 = new object();

	internal int CA374431 = 0;

	internal int int_3 = 0;

	internal int int_4 = 0;

	internal int int_5 = 3;

	internal bool CDB12D8A = true;

	public int A8B1FA31
	{
		[CompilerGenerated]
		get
		{
			return E8A55336;
		}
		[CompilerGenerated]
		set
		{
			E8A55336 = value;
		}
	}

	public string String_0
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

	public string A9913D3C
	{
		[CompilerGenerated]
		get
		{
			return B0A3631F;
		}
		[CompilerGenerated]
		set
		{
			B0A3631F = value;
		}
	}

	public int F69E6E89
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

	public string String_1
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

	public int F6A292A1
	{
		[CompilerGenerated]
		get
		{
			return E4A4308F;
		}
		[CompilerGenerated]
		set
		{
			E4A4308F = value;
		}
	}

	public int F9AA4D9B
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

	public int A82C391B
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

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return BC064984;
		}
		[CompilerGenerated]
		set
		{
			BC064984 = value;
		}
	}

	public string String_3
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public Class4(int int_6, string string_3, int int_7, int int_8)
	{
		A8B1FA31 = int_6;
		String_0 = string_3;
		A9913D3C = "";
		String_1 = "";
		F9AA4D9B = 0;
		A82C391B = 0;
		F69E6E89 = int_7;
		int_5 = int_8;
		CA374431 = 0;
		int_3 = 0;
		int_4 = 0;
		String_2 = "";
		String_3 = "";
	}

	public static bool smethod_0(int int_6, string D7A58C92)
	{
		string text = "";
		text = ((int_6 != 0) ? A6998C86("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-status?api_key=" + D7A58C92) : A6998C86("http://dash.minproxy.vn/api/rotating/v1/proxy/get-status?api_key=" + D7A58C92));
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["code"]!.ToString() == "1")
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

	public string CC8F46AA()
	{
		lock (A30B5503)
		{
			if (int_3 == 0)
			{
				if (int_4 > 0 && int_4 < int_5)
				{
					if (method_0() < 30 && CF9AF989() != 1)
					{
						return "0";
					}
				}
				else if (CF9AF989() != 1)
				{
					return "0";
				}
			}
			else
			{
				if (int_4 >= int_5)
				{
					return "2";
				}
				if (method_0() < 30 && CF9AF989() != 1)
				{
					return "0";
				}
			}
			int_4++;
			int_3++;
			return "1";
		}
	}

	public int method_0()
	{
		method_1();
		return F6A292A1;
	}

	public void A6964C31()
	{
		lock (object_0)
		{
			int_3--;
			if (int_3 == 0 && int_4 == int_5)
			{
				CDB12D8A = true;
				int_4 = 0;
			}
		}
	}

	public int CF9AF989()
	{
		A9913D3C = "";
		String_1 = "";
		F9AA4D9B = 0;
		string text = "";
		text = ((A8B1FA31 != 0) ? A6998C86("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-new-proxy?api_key=" + String_0) : A6998C86("http://dash.minproxy.vn/api/rotating/v1/proxy/get-new-proxy?api_key=" + String_0));
		if (text != "")
		{
			if (text.Contains("api expired"))
			{
				return -1;
			}
			if (text.Contains("api wrong") || text.Contains("error"))
			{
				return -2;
			}
			try
			{
				JObject jObject = JObject.Parse(text);
				string value = Regex.Match(jObject["data"]!["next_request"]!.ToString(), "\\d+").Value;
				A82C391B = ((!(value == "")) ? int.Parse(value) : 0);
				if (jObject["code"]!.ToString() == "2")
				{
					String_2 = jObject["data"]!["ip_allow"]!.ToString();
					String_3 = jObject["data"]!["your_ip"]!.ToString();
					if (A8B1FA31 == 0)
					{
						A9913D3C = jObject["data"]!["http_proxy"]!.ToString();
						string[] array = A9913D3C.Split(':');
						String_1 = array[0];
						F9AA4D9B = int.Parse(array[1]);
						return 1;
					}
					if (A8B1FA31 == 1)
					{
						if (F69E6E89 == 0)
						{
							A9913D3C = jObject["data"]!["http_proxy_ipv4"]!.ToString();
							string[] array2 = A9913D3C.Split(':');
							String_1 = array2[0];
							F9AA4D9B = int.Parse(array2[1]);
						}
						else if (F69E6E89 == 1)
						{
							A9913D3C = jObject["data"]!["http_proxy_ipv6"]!.ToString();
							string[] array3 = A9913D3C.Split(':');
							String_1 = array3[0];
							F9AA4D9B = int.Parse(array3[1]);
						}
						else if (F69E6E89 == 2)
						{
							A9913D3C = jObject["data"]!["sock_proxy_ipv4"]!.ToString();
							string[] array4 = A9913D3C.Split(':');
							String_1 = array4[0];
							F9AA4D9B = int.Parse(array4[1]);
						}
						else
						{
							A9913D3C = jObject["data"]!["sock_proxy_ipv6"]!.ToString();
							string[] array5 = A9913D3C.Split(':');
							String_1 = array5[0];
							F9AA4D9B = int.Parse(array5[1]);
						}
						return 1;
					}
				}
				return 0;
			}
			catch
			{
			}
		}
		A82C391B = 0;
		return 0;
	}

	public bool method_1()
	{
		A82C391B = 0;
		A9913D3C = "";
		String_1 = "";
		F9AA4D9B = 0;
		F6A292A1 = 0;
		string text = "";
		text = ((A8B1FA31 != 0) ? A6998C86("http://dash.minproxy.vn/api/rotating/v1/proxy_v4/get-current-proxy?api_key=" + String_0) : A6998C86("http://dash.minproxy.vn/api/rotating/v1/proxy/get-current-proxy?api_key=" + String_0));
		if (text != "")
		{
			try
			{
				JObject jObject = JObject.Parse(text);
				if (jObject["code"]!.ToString() == "1")
				{
					A82C391B = Convert.ToInt32(jObject["data"]!["next_request"]!.ToString());
					F6A292A1 = Convert.ToInt32(jObject["data"]!["timeout"]!.ToString());
					String_2 = jObject["data"]!["ip_allow"]!.ToString();
					String_3 = jObject["data"]!["your_ip"]!.ToString();
					if (A8B1FA31 == 0)
					{
						A9913D3C = jObject["data"]!["http_proxy"]!.ToString();
						string[] array = A9913D3C.Split(':');
						String_1 = array[0];
						F9AA4D9B = int.Parse(array[1]);
						return true;
					}
					if (A8B1FA31 == 1)
					{
						if (F69E6E89 == 0)
						{
							A9913D3C = jObject["data"]!["http_proxy_ipv4"]!.ToString();
							string[] array2 = A9913D3C.Split(':');
							String_1 = array2[0];
							F9AA4D9B = int.Parse(array2[1]);
						}
						else if (F69E6E89 == 1)
						{
							A9913D3C = jObject["data"]!["http_proxy_ipv6"]!.ToString();
							string[] array3 = A9913D3C.Split(':');
							String_1 = array3[0];
							F9AA4D9B = int.Parse(array3[1]);
						}
						else if (F69E6E89 == 2)
						{
							A9913D3C = jObject["data"]!["sock_proxy_ipv4"]!.ToString();
							string[] array4 = A9913D3C.Split(':');
							String_1 = array4[0];
							F9AA4D9B = int.Parse(array4[1]);
						}
						else
						{
							A9913D3C = jObject["data"]!["sock_proxy_ipv6"]!.ToString();
							string[] array5 = A9913D3C.Split(':');
							String_1 = array5[0];
							F9AA4D9B = int.Parse(array5[1]);
						}
						return true;
					}
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public string F22B1D13()
	{
		while (!method_1())
		{
		}
		return A9913D3C;
	}

	public static string A6998C86(string string_3)
	{
		string text = "";
		try
		{
			new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Task<string> task = Task.Run(() => RequestHelper.GetURI(new Uri(string_3)));
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
