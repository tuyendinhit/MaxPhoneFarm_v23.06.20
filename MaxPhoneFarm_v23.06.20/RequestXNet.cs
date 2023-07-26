using System;
using System.Linq;
using xNet;

public class RequestXNet
{
	internal xNet.HttpRequest http;

	public RequestXNet(string string_0, string useragent, string proxy, int AE340096)
	{
		if (useragent == "")
		{
			useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
		}
		http = new xNet.HttpRequest
		{
			KeepAlive = true,
			AllowAutoRedirect = true,
			Cookies = new CookieDictionary(),
			UserAgent = useragent
		};
		http.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
		http.AddHeader("Accept-Language", "en-US,en;q=0.9");
		if (string_0 != "")
		{
			D323D02C(string_0);
		}
		if (!(proxy != ""))
		{
			return;
		}
		switch (proxy.Split(':').Count())
		{
		case 1:
			if (AE340096 == 0)
			{
				http.Proxy = HttpProxyClient.Parse("127.0.0.1:" + proxy);
			}
			else
			{
				http.Proxy = Socks5ProxyClient.Parse("127.0.0.1:" + proxy);
			}
			break;
		case 2:
			if (AE340096 == 0)
			{
				http.Proxy = HttpProxyClient.Parse(proxy);
			}
			else
			{
				http.Proxy = Socks5ProxyClient.Parse(proxy);
			}
			break;
		case 4:
			if (AE340096 == 0)
			{
				http.Proxy = new HttpProxyClient(proxy.Split(':')[0], Convert.ToInt32(proxy.Split(':')[1]), proxy.Split(':')[2], proxy.Split(':')[3]);
			}
			else
			{
				http.Proxy = new Socks5ProxyClient(proxy.Split(':')[0], Convert.ToInt32(proxy.Split(':')[1]), proxy.Split(':')[2], proxy.Split(':')[3]);
			}
			break;
		case 3:
			break;
		}
	}

	public string RequestGet(string string_0)
	{
		try
		{
			http.AddHeader("Cache-Control", "no-cache");
			return http.Get(string_0).ToString();
		}
		catch (Exception aE86FC)
		{
			return E915B6A4(aE86FC);
		}
	}

	public string method_1(string string_0, string string_1 = "", string string_2 = "application/x-www-form-urlencoded")
	{
		try
		{
			http.AddHeader("Cache-Control", "no-cache");
			if (string_1 == "" || string_2 == "")
			{
				return http.Post(string_0).ToString();
			}
			return http.Post(string_0, string_1, string_2).ToString();
		}
		catch (Exception aE86FC)
		{
			return E915B6A4(aE86FC);
		}
	}

	public string E915B6A4(Exception AE86FC85)
	{
		if (AE86FC85.ToString().Contains("Thread was being aborted."))
		{
			return "";
		}
		if (AE86FC85.ToString().Contains("Не удалось соединиться с HTTP-сервером"))
		{
			return "cannot_connect";
		}
		return http.Response.ToString();
	}

	public byte[] method_2(string A60F61B2)
	{
		return http.Get(A60F61B2).ToBytes();
	}

	public void D323D02C(string F0B29A94)
	{
		string[] array = F0B29A94.Split(';');
		string[] array2 = array;
		foreach (string text in array2)
		{
			string[] array3 = text.Split('=');
			if (array3.Count() > 1)
			{
				try
				{
					http.Cookies.Add(array3[0], text.Substring(text.IndexOf("=") + 1));
				}
				catch
				{
				}
			}
		}
	}

	public string BC82EA37()
	{
		return http.Cookies.ToString();
	}
}
