using System;
using System.Linq;
using System.Net;
using System.Text;
using HttpRequest;

public class GClass13
{
	internal RequestHTTP F123C51A;

	internal string E2B8C936;

	internal string string_0;

	public GClass13(string ED8F463A = "", string BDA0549C = "", string B310810D = "", int int_0 = 0)
	{
		if (BDA0549C == "")
		{
			E2B8C936 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
		}
		else
		{
			E2B8C936 = BDA0549C;
		}
		F123C51A = new RequestHTTP();
		F123C51A.SetSSL(SecurityProtocolType.Tls12);
		F123C51A.SetKeepAlive(k: true);
		F123C51A.SetDefaultHeaders(new string[2]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: " + E2B8C936
		});
		if (ED8F463A != "")
		{
			method_2(ED8F463A);
		}
		string_0 = B310810D;
	}

	public string method_0(string F019CC8D)
	{
		try
		{
			if (string_0 != "")
			{
				if (string_0.Contains(":"))
				{
					return F123C51A.Request("GET", F019CC8D, null, null, autoredrirect: true, new WebProxy(string_0.Split(':')[0], Convert.ToInt32(string_0.Split(':')[1]))).ToString();
				}
				return F123C51A.Request("GET", F019CC8D, null, null, autoredrirect: true, new WebProxy("127.0.0.1", Convert.ToInt32(string_0))).ToString();
			}
			return F123C51A.Request("GET", F019CC8D).ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public string method_1(string string_1, string string_2 = "")
	{
		if (string_0 != "")
		{
			if (string_0.Contains(":"))
			{
				return F123C51A.Request("POST", string_1, null, Encoding.ASCII.GetBytes(string_2), autoredrirect: true, new WebProxy(string_0.Split(':')[0], Convert.ToInt32(string_0.Split(':')[1]))).ToString();
			}
			return F123C51A.Request("POST", string_1, null, Encoding.ASCII.GetBytes(string_2), autoredrirect: true, new WebProxy("127.0.0.1", Convert.ToInt32(string_0))).ToString();
		}
		return F123C51A.Request("POST", string_1, null, Encoding.ASCII.GetBytes(string_2)).ToString();
	}

	public void method_2(string string_1)
	{
		string[] array = string_1.Split(';');
		string text = "";
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string[] array3 = text2.Split('=');
			if (array3.Count() > 1)
			{
				try
				{
					text = text + array3[0] + "=" + array3[1] + ";";
				}
				catch
				{
				}
			}
		}
		F123C51A.SetDefaultHeaders(new string[3]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8;charset=UTF-8",
			"user-agent: " + E2B8C936,
			"cookie: " + text
		});
	}

	public string method_3()
	{
		return F123C51A.GetCookiesString();
	}
}
