using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

public class Chrome
{
	[CompilerGenerated]
	private sealed class F40E5229
	{
		internal string string_0;

		internal Func<Process, bool> func_0;

		internal bool method_0(Process process_0)
		{
			return process_0.MainWindowTitle.Contains(string_0);
		}
	}

	internal int D3147317;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Process process_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal ChromeDriver F32955AA;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal bool bool_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal bool FCA84B06;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal bool bool_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal bool bool_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal bool C5B2BF1A;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Point point_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Point point_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int DA96A817;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int BB348492;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string BF0B639F;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal bool F11D2C93;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal bool bool_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal Point point_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal GEnum4 genum4_0;

	internal Random A8B9D238;

	public Process Process_0
	{
		[CompilerGenerated]
		get
		{
			return process_0;
		}
		[CompilerGenerated]
		set
		{
			process_0 = value;
		}
	}

	public ChromeDriver D90E7D3E
	{
		[CompilerGenerated]
		get
		{
			return F32955AA;
		}
		[CompilerGenerated]
		set
		{
			F32955AA = value;
		}
	}

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool DFB79037
	{
		[CompilerGenerated]
		get
		{
			return FCA84B06;
		}
		[CompilerGenerated]
		set
		{
			FCA84B06 = value;
		}
	}

	public bool A58D4D9A
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool Boolean_1
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public bool Boolean_2
	{
		[CompilerGenerated]
		get
		{
			return C5B2BF1A;
		}
		[CompilerGenerated]
		set
		{
			C5B2BF1A = value;
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

	public Point Point_0
	{
		[CompilerGenerated]
		get
		{
			return point_0;
		}
		[CompilerGenerated]
		set
		{
			point_0 = value;
		}
	}

	public Point B3B5AFAB
	{
		[CompilerGenerated]
		get
		{
			return point_1;
		}
		[CompilerGenerated]
		set
		{
			point_1 = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return DA96A817;
		}
		[CompilerGenerated]
		set
		{
			DA96A817 = value;
		}
	}

	public int Int32_2
	{
		[CompilerGenerated]
		get
		{
			return BB348492;
		}
		[CompilerGenerated]
		set
		{
			BB348492 = value;
		}
	}

	public string String_2
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

	public int Int32_3
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

	public string E728E4AB
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public string String_3
	{
		[CompilerGenerated]
		get
		{
			return BF0B639F;
		}
		[CompilerGenerated]
		set
		{
			BF0B639F = value;
		}
	}

	public string String_4
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	public bool Boolean_3
	{
		[CompilerGenerated]
		get
		{
			return F11D2C93;
		}
		[CompilerGenerated]
		set
		{
			F11D2C93 = value;
		}
	}

	public bool Boolean_4
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public string String_5
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
		[CompilerGenerated]
		set
		{
			string_5 = value;
		}
	}

	public Point Point_1
	{
		[CompilerGenerated]
		get
		{
			return point_2;
		}
		[CompilerGenerated]
		set
		{
			point_2 = value;
		}
	}

	public GEnum4 GEnum4_0
	{
		[CompilerGenerated]
		get
		{
			return genum4_0;
		}
		[CompilerGenerated]
		set
		{
			genum4_0 = value;
		}
	}

	public Chrome()
	{
		D3147317 = 0;
		Boolean_0 = false;
		A58D4D9A = false;
		Boolean_1 = false;
		DFB79037 = false;
		String_0 = "";
		String_1 = "";
		Point_0 = new Point(300, 300);
		Point_0 = new Point(Point_0.X, Point_0.Y);
		String_2 = "";
		Int32_3 = 0;
		B3B5AFAB = new Point(B3B5AFAB.X, B3B5AFAB.Y);
		Int32_1 = 0;
		Int32_2 = 5;
		E728E4AB = "";
		Boolean_2 = false;
		String_3 = "";
		String_4 = "data\\extension";
		Boolean_3 = false;
		Point_1 = new Point(300, 300);
		GEnum4_0 = GEnum4.AAB8BCAF;
		Boolean_4 = false;
		String_5 = "";
		A8B9D238 = new Random();
	}

	public bool method_0()
	{
		bool result = false;
		try
		{
			ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
			chromeDriverService.HideCommandPromptWindow = true;
			ChromeOptions chromeOptions = new ChromeOptions();
			chromeOptions.AddArguments("--disable-3d-apis", "--disable-background-networking", "--disable-bundled-ppapi-flash", "--disable-client-side-phishing-detection", "--disable-default-apps", "--disable-hang-monitor", "--disable-prompt-on-repost", "--disable-sync", "--disable-webgl", "--enable-blink-features=ShadowDOMV0", "--enable-logging", "--disable-notifications", "--window-size=" + Point_0.X + "," + Point_0.Y, "--window-position=" + B3B5AFAB.X + "," + B3B5AFAB.Y, "--no-sandbox", "--disable-gpu", "--disable-dev-shm-usage", "--disable-web-security", "--disable-rtc-smoothness-algorithm", "--disable-webrtc-hw-decoding", "--disable-webrtc-hw-encoding", "--disable-webrtc-multiple-routes", "--disable-webrtc-hw-vp8-encoding", "--enforce-webrtc-ip-permission-check", "--force-webrtc-ip-handling-policy", "--ignore-certificate-errors", "--disable-infobars", "--disable-blink-features=\"BlockCredentialedSubresources\"", "--disable-popup-blocking");
			chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.geolocation", 0);
			if (Boolean_1)
			{
				chromeOptions.AddArgument("--mute-audio");
			}
			if (String_3 != "" && File.Exists(String_3))
			{
				chromeOptions.BinaryLocation = String_3;
			}
			if (Boolean_4)
			{
				if (!string.IsNullOrEmpty(String_1.Trim()))
				{
					if (!Directory.Exists(String_1))
					{
						ZipFile.ExtractToDirectory(String_5, String_1);
					}
					chromeOptions.BinaryLocation = String_1 + "\\App\\Chrome-bin\\chrome.exe";
					if (!Boolean_0)
					{
						if (A58D4D9A)
						{
							chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
						}
						chromeOptions.AddArgument("--user-data-dir=" + String_1 + "\\Data\\profile");
					}
					else
					{
						chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
						chromeOptions.AddArgument("--headless");
					}
				}
			}
			else if (!Boolean_0)
			{
				if (A58D4D9A)
				{
					chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
				}
				if (!string.IsNullOrEmpty(String_1.Trim()))
				{
					chromeOptions.AddArgument("--user-data-dir=" + String_1);
				}
			}
			else
			{
				chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
				chromeOptions.AddArgument("--headless");
			}
			if (DFB79037)
			{
				chromeOptions.AddArguments("--incognito");
			}
			if (!string.IsNullOrEmpty(String_2.Trim()))
			{
				switch (String_2.Split(':').Count())
				{
				case 1:
					if (Int32_3 == 0)
					{
						chromeOptions.AddArgument("--proxy-server= 127.0.0.1:" + String_2);
					}
					else
					{
						chromeOptions.AddArgument("--proxy-server= socks5://127.0.0.1:" + String_2);
					}
					break;
				case 2:
					if (Int32_3 == 0)
					{
						chromeOptions.AddArgument("--proxy-server= " + String_2);
					}
					else
					{
						chromeOptions.AddArgument("--proxy-server= socks5://" + String_2);
					}
					break;
				case 4:
					if (Int32_3 == 0)
					{
						chromeOptions.AddArgument("--proxy-server= " + String_2.Split(':')[0] + ":" + String_2.Split(':')[1]);
						chromeOptions.AddExtension("extension\\proxy.crx");
					}
					else
					{
						chromeOptions.AddArgument("--proxy-server= socks5://" + String_2.Split(':')[0] + ":" + String_2.Split(':')[1]);
						chromeOptions.AddExtension("extension\\proxy.crx");
					}
					break;
				}
			}
			bool flag = false;
			if (!Boolean_0 && String_4.Trim() != "")
			{
				if (!Directory.Exists(String_4))
				{
					Directory.CreateDirectory(String_4);
				}
				string[] files = Directory.GetFiles(String_4);
				if (files.Length != 0)
				{
					flag = true;
				}
				for (int i = 0; i < files.Length; i++)
				{
					chromeOptions.AddExtension(files[i]);
				}
			}
			if (!flag && !string.IsNullOrEmpty(E728E4AB.Trim()))
			{
				chromeOptions.AddArgument("--app= " + E728E4AB);
			}
			if (String_0 != "")
			{
				if (String_2.Split(':').Count() == 4)
				{
					chromeOptions.AddArgument("--user-agent=" + String_0 + "$PC$" + String_2.Split(':')[2] + ":" + String_2.Split(':')[3]);
				}
				else
				{
					chromeOptions.AddArgument("--user-agent=" + String_0);
				}
			}
			if (Boolean_3)
			{
				ChromeMobileEmulationDeviceSettings deviceSettings = new ChromeMobileEmulationDeviceSettings
				{
					EnableTouchEvents = true,
					Width = Point_1.X,
					Height = Point_1.Y,
					UserAgent = String_0,
					PixelRatio = Int32_0
				};
				chromeOptions.EnableMobileEmulation(deviceSettings);
			}
			if (Boolean_2)
			{
				chromeOptions.AddArgument("--autoplay-policy=no-user-gesture-required");
			}
			D90E7D3E = new ChromeDriver(chromeDriverService, chromeOptions);
			D90E7D3E.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Int32_1);
			D90E7D3E.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(Int32_2);
			result = true;
			return result;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.Open()");
			return result;
		}
	}

	public string method_1()
	{
		if (!F125B9B1())
		{
			return "-2";
		}
		try
		{
			return D90E7D3E.PageSource;
		}
		catch
		{
		}
		return "";
	}

	public bool F125B9B1()
	{
		return !B2277F30();
	}

	public bool B2277F30()
	{
		if (Process_0 != null)
		{
			return Process_0.HasExited;
		}
		bool result = true;
		try
		{
			_ = D90E7D3E.Title;
			result = false;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.CheckChromeClosed()");
		}
		return result;
	}

	public bool method_2(string BB0A773C, string string_6, string string_7 = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico", string AB810B12 = "\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe\"")
	{
		bool result = false;
		try
		{
			Common.E08E7930(BB0A773C, string_6, AB810B12, "--user-data-dir=\"" + String_1 + "\"", AB810B12.Substring(0, AB810B12.LastIndexOf("\\")), string_7);
			return result;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.CreateShortcut(" + BB0A773C + "," + string_6 + "," + AB810B12 + ")");
			return result;
		}
	}

	public string method_3(string string_6, string string_7, string string_8)
	{
		string result = "";
		if (!F125B9B1())
		{
			return "-2";
		}
		try
		{
			result = D90E7D3E.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; function GetCssSelector(selector, attribute, value){var c = document.querySelectorAll(selector); for (i = 0; i < c.length; i++) { if (c[i].getAttribute(attribute)!=null && c[i].getAttribute(attribute).includes(value)) { return GetSelector(c[i])} }; return '';}; return GetCssSelector('" + string_6 + "','" + string_7 + "','" + string_8 + "')").ToString();
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.GetCssSelector(" + string_6 + "," + string_7 + "," + string_8 + ")");
		}
		return result;
	}

	public string method_4(string string_6)
	{
		string result = "";
		if (!F125B9B1())
		{
			return "-2";
		}
		try
		{
			result = D90E7D3E.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; return GetSelector(" + string_6 + ")").ToString();
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.GetCssSelector(" + string_6 + ")");
		}
		return result;
	}

	public string method_5(string AA86EA3E, string A83BC222)
	{
		string result = "";
		if (!F125B9B1())
		{
			return "-2";
		}
		try
		{
			result = D90E7D3E.ExecuteScript("return document.querySelector('" + AA86EA3E + "').getAttribute('" + A83BC222 + "')").ToString();
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.GetAttributeValue(" + AA86EA3E + "," + A83BC222 + ")");
		}
		return result;
	}

	public int method_6(int DB91CB3D)
	{
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			int num = Convert.ToInt32(D90E7D3E.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
			D90E7D3E.ExecuteScript("window.scrollBy({ top: " + DB91CB3D + ",behavior: 'smooth'});");
			C2B42BB6(0.1);
			if (num == Convert.ToInt32(D90E7D3E.ExecuteScript("return document.querySelector('html').getBoundingClientRect().y+''").ToString()))
			{
				return 2;
			}
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.ScrollSmooth({DB91CB3D})");
		}
		return 1;
	}

	public string A89FE936()
	{
		string result = "";
		if (!F125B9B1())
		{
			return "-2";
		}
		try
		{
			result = D90E7D3E.ExecuteScript("return navigator.userAgent").ToString();
		}
		catch
		{
		}
		return result;
	}

	public int method_7(int int_2, string string_6)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			switch (int_2)
			{
			case 1:
				D90E7D3E.FindElementById(string_6).SendKeys(Keys.ArrowDown);
				break;
			case 2:
				D90E7D3E.FindElementByName(string_6).SendKeys(Keys.ArrowDown);
				break;
			case 3:
				D90E7D3E.FindElementByXPath(string_6).SendKeys(Keys.ArrowDown);
				break;
			case 4:
				D90E7D3E.FindElementByCssSelector(string_6).SendKeys(Keys.ArrowDown);
				break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.SendKeyDown({int_2},{string_6})");
		}
		return flag ? 1 : 0;
	}

	public string AB2275A9()
	{
		if (!F125B9B1())
		{
			return "-2";
		}
		try
		{
			return D90E7D3E.Url;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.GetURL()");
		}
		return "";
	}

	public int D920192A(string D70ED80D)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			D90E7D3E.Navigate().GoToUrl(D70ED80D);
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.GotoURL(" + D70ED80D + ")");
		}
		return flag ? 1 : 0;
	}

	public int method_8(int int_2)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			switch (int_2)
			{
			case 1:
				D920192A("https://www.facebook.com/login");
				break;
			case 2:
				D920192A("https://m.facebook.com/login");
				break;
			case 3:
				D920192A("https://mbasic.facebook.com/login");
				break;
			}
			flag = true;
			C2B42BB6(1.0);
		}
		catch (Exception exception_)
		{
		}
		return flag ? 1 : 0;
	}

	public int method_9(string FC07E127)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			if (AB2275A9() != FC07E127)
			{
				D90E7D3E.Navigate().GoToUrl(FC07E127);
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.GotoURL(" + FC07E127 + ")");
		}
		return flag ? 1 : 0;
	}

	public int method_10()
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			D90E7D3E.Navigate().Refresh();
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.Refresh()");
		}
		return flag ? 1 : 0;
	}

	public int method_11(int int_2 = 1)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			for (int i = 0; i < int_2; i++)
			{
				D90E7D3E.Navigate().Back();
				C2B42BB6(0.5);
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.GotoBackPage()");
		}
		return flag ? 1 : 0;
	}

	public int E2BF06BC(int A73E89A9, string string_6, int int_2, double double_0)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			new WebDriverWait(D90E7D3E, TimeSpan.FromSeconds(10.0));
			switch (A73E89A9)
			{
			case 1:
				new Actions(D90E7D3E).MoveToElement(D90E7D3E.FindElementsById(string_6)[int_2]).Perform();
				break;
			case 2:
				new Actions(D90E7D3E).MoveToElement(D90E7D3E.FindElementsByName(string_6)[int_2]).Perform();
				break;
			case 3:
				new Actions(D90E7D3E).MoveToElement(D90E7D3E.FindElementsByXPath(string_6)[int_2]).Perform();
				break;
			case 4:
				new Actions(D90E7D3E).MoveToElement(D90E7D3E.FindElementsByCssSelector(string_6)[int_2]).Perform();
				break;
			}
			Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.HoverElement({A73E89A9}, {string_6}, {double_0})");
		}
		return flag ? 1 : 0;
	}

	public int method_12(int BC2E5F34, string string_6, double double_0)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			WebDriverWait webDriverWait = new WebDriverWait(D90E7D3E, TimeSpan.FromSeconds(10.0));
			switch (BC2E5F34)
			{
			case 1:
				new Actions(D90E7D3E).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.Id(string_6)))).Perform();
				break;
			case 2:
				new Actions(D90E7D3E).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.Name(string_6)))).Perform();
				break;
			case 3:
				new Actions(D90E7D3E).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(string_6)))).Perform();
				break;
			case 4:
				new Actions(D90E7D3E).MoveToElement(webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(string_6)))).Perform();
				break;
			}
			Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.HoverElement({BC2E5F34}, {string_6}, {double_0})");
		}
		return flag ? 1 : 0;
	}

	public bool method_13(int int_2, string D4B28423, int int_3)
	{
		bool result = true;
		try
		{
			switch (int_2)
			{
			case 1:
				new Actions(D90E7D3E).MoveToElement(D90E7D3E.FindElementsById(D4B28423)[int_3]).Build().Perform();
				break;
			case 2:
				new Actions(D90E7D3E).MoveToElement(D90E7D3E.FindElementsByName(D4B28423)[int_3]).Build().Perform();
				break;
			case 3:
				new Actions(D90E7D3E).MoveToElement(D90E7D3E.FindElementsByXPath(D4B28423)[int_3]).Build().Perform();
				break;
			case 4:
				new Actions(D90E7D3E).MoveToElement(D90E7D3E.FindElementsByCssSelector(D4B28423)[int_3]).Build().Perform();
				break;
			}
			result = true;
			return result;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.MoveToElement({int_2},{D4B28423},{int_3})");
			return result;
		}
	}

	public object F4AF93AB(string string_6)
	{
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			return D90E7D3E.ExecuteScript(string_6);
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.ExecuteScript(" + string_6 + ")");
		}
		return "";
	}

	public int method_14(int EB894C8C, string string_6, int int_2 = 0, int int_3 = 0, string string_7 = "", int int_4 = 0, int int_5 = 1)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		for (int i = 0; i < int_5; C2B42BB6(1.0), i++)
		{
			try
			{
				if (int_3 == 0)
				{
					switch (EB894C8C)
					{
					case 1:
						D90E7D3E.FindElementsById(string_6)[int_2].Click();
						break;
					case 2:
						D90E7D3E.FindElementsByName(string_6)[int_2].Click();
						break;
					case 3:
						D90E7D3E.FindElementsByXPath(string_6)[int_2].Click();
						break;
					case 4:
						D90E7D3E.FindElementsByCssSelector(string_6)[int_2].Click();
						break;
					}
				}
				else
				{
					switch (EB894C8C)
					{
					case 1:
						D90E7D3E.FindElementsById(string_6)[int_2].FindElements(By.Id(string_7))[int_4].Click();
						break;
					case 2:
						D90E7D3E.FindElementsByName(string_6)[int_2].FindElements(By.Name(string_7))[int_4].Click();
						break;
					case 3:
						D90E7D3E.FindElementsByXPath(string_6)[int_2].FindElements(By.XPath(string_7))[int_4].Click();
						break;
					case 4:
						D90E7D3E.FindElementsByCssSelector(string_6)[int_2].FindElements(By.CssSelector(string_7))[int_4].Click();
						break;
					}
				}
				flag = true;
			}
			catch (Exception exception_)
			{
				EAB97586(null, exception_, $"chrome.Click({EB894C8C},{string_6})");
				continue;
			}
			break;
		}
		return flag ? 1 : 0;
	}

	public int method_15(double E8B2F10B, int int_2, string string_6, int int_3 = 0, int CE23B425 = 0, string string_7 = "", int BE3DBCAA = 0)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				try
				{
					if (CE23B425 == 0)
					{
						switch (int_2)
						{
						case 1:
							D90E7D3E.FindElementsById(string_6)[int_3].Click();
							break;
						case 2:
							D90E7D3E.FindElementsByName(string_6)[int_3].Click();
							break;
						case 3:
							D90E7D3E.FindElementsByXPath(string_6)[int_3].Click();
							break;
						case 4:
							D90E7D3E.FindElementsByCssSelector(string_6)[int_3].Click();
							break;
						}
					}
					else
					{
						switch (int_2)
						{
						case 1:
							D90E7D3E.FindElementsById(string_6)[int_3].FindElements(By.Id(string_7))[BE3DBCAA].Click();
							break;
						case 2:
							D90E7D3E.FindElementsByName(string_6)[int_3].FindElements(By.Name(string_7))[BE3DBCAA].Click();
							break;
						case 3:
							D90E7D3E.FindElementsByXPath(string_6)[int_3].FindElements(By.XPath(string_7))[BE3DBCAA].Click();
							break;
						case 4:
							D90E7D3E.FindElementsByCssSelector(string_6)[int_3].FindElements(By.CssSelector(string_7))[BE3DBCAA].Click();
							break;
						}
					}
					flag = true;
					C2B42BB6(1.0);
				}
				catch (Exception)
				{
					goto IL_01b4;
				}
				break;
				IL_01b4:
				if (!((double)(Environment.TickCount - tickCount) >= E8B2F10B * 1000.0))
				{
					C2B42BB6(1.0);
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.FindAndClick({E8B2F10B},{int_2},{string_6},{int_3},{CE23B425},{string_7},{BE3DBCAA}");
		}
		return flag ? 1 : 0;
	}

	public int method_16(int int_2, string D3AFF29E, int int_3 = 0, int int_4 = 0, string string_6 = "", int FE9B6AA8 = 0)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			if (int_4 != 0)
			{
				switch (int_2)
				{
				case 1:
					new Actions(D90E7D3E).Click(D90E7D3E.FindElementsById(D3AFF29E)[int_3].FindElements(By.Id(string_6))[FE9B6AA8]).Perform();
					break;
				case 2:
					new Actions(D90E7D3E).Click(D90E7D3E.FindElementsByName(D3AFF29E)[int_3].FindElements(By.Name(string_6))[FE9B6AA8]).Perform();
					break;
				case 3:
					new Actions(D90E7D3E).Click(D90E7D3E.FindElementsByXPath(D3AFF29E)[int_3].FindElements(By.XPath(string_6))[FE9B6AA8]).Perform();
					break;
				case 4:
					new Actions(D90E7D3E).Click(D90E7D3E.FindElementsByCssSelector(D3AFF29E)[int_3].FindElements(By.CssSelector(string_6))[FE9B6AA8]).Perform();
					break;
				}
			}
			else
			{
				switch (int_2)
				{
				case 1:
					new Actions(D90E7D3E).Click(D90E7D3E.FindElementsById(D3AFF29E)[int_3]).Perform();
					break;
				case 2:
					new Actions(D90E7D3E).Click(D90E7D3E.FindElementsByName(D3AFF29E)[int_3]).Perform();
					break;
				case 3:
					new Actions(D90E7D3E).Click(D90E7D3E.FindElementsByXPath(D3AFF29E)[int_3]).Perform();
					break;
				case 4:
					new Actions(D90E7D3E).Click(D90E7D3E.FindElementsByCssSelector(D3AFF29E)[int_3]).Perform();
					break;
				}
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.ClickWithAction({int_2},{D3AFF29E})");
		}
		return flag ? 1 : 0;
	}

	public int method_17(int A8B4B681, string string_6, string string_7, bool bool_4 = true, double double_0 = 0.1)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			if (bool_4)
			{
				method_14(A8B4B681, string_6);
				C2B42BB6(double_0);
			}
			switch (A8B4B681)
			{
			case 1:
				D90E7D3E.FindElementById(string_6).SendKeys(string_7);
				break;
			case 2:
				D90E7D3E.FindElementByName(string_6).SendKeys(string_7);
				break;
			case 3:
				D90E7D3E.FindElementByXPath(string_6).SendKeys(string_7);
				break;
			case 4:
				D90E7D3E.FindElementByCssSelector(string_6).SendKeys(string_7);
				break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.SendKeys({A8B4B681},{string_6},{string_7},{bool_4})");
		}
		return flag ? 1 : 0;
	}

	public int method_18(int int_2, string string_6, int BBA40A11, string BAA92E34, bool A921FFB9 = true, double F2869B2C = 0.1)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			if (A921FFB9)
			{
				method_14(int_2, string_6);
				C2B42BB6(F2869B2C);
			}
			switch (int_2)
			{
			case 1:
				D90E7D3E.FindElementsById(string_6)[BBA40A11].SendKeys(BAA92E34);
				break;
			case 2:
				D90E7D3E.FindElementsByName(string_6)[BBA40A11].SendKeys(BAA92E34);
				break;
			case 3:
				D90E7D3E.FindElementsByXPath(string_6)[BBA40A11].SendKeys(BAA92E34);
				break;
			case 4:
				D90E7D3E.FindElementsByCssSelector(string_6)[BBA40A11].SendKeys(BAA92E34);
				break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.SendKeys({int_2},{string_6},{BAA92E34},{A921FFB9})");
		}
		return flag ? 1 : 0;
	}

	public int method_19(int F917788F, string string_6, string C995B812, double double_0, bool bool_4 = true, double double_1 = 0.1)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			if (bool_4)
			{
				method_14(F917788F, string_6);
				C2B42BB6(double_1);
			}
			for (int i = 0; i < C995B812.Length; i++)
			{
				switch (F917788F)
				{
				case 1:
					D90E7D3E.FindElementById(string_6).SendKeys(C995B812[i].ToString());
					break;
				case 2:
					D90E7D3E.FindElementByName(string_6).SendKeys(C995B812[i].ToString());
					break;
				case 3:
					D90E7D3E.FindElementByXPath(string_6).SendKeys(C995B812[i].ToString());
					break;
				case 4:
					D90E7D3E.FindElementByCssSelector(string_6).SendKeys(C995B812[i].ToString());
					break;
				}
				if (double_0 > 0.0)
				{
					int num = Convert.ToInt32(double_0 * 1000.0);
					if (num < 100)
					{
						num = 100;
					}
					Thread.Sleep(Base.rd.Next(num, num + 50));
				}
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.SendKeys({F917788F},{string_6},{C995B812},{double_0},{bool_4})");
		}
		return flag ? 1 : 0;
	}

	public int AEA28F33(int F00D3F25, string string_6, int int_2, string string_7, double double_0, bool bool_4 = true, double double_1 = 0.1)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			if (bool_4)
			{
				method_14(F00D3F25, string_6);
				C2B42BB6(double_1);
			}
			for (int i = 0; i < string_7.Length; i++)
			{
				switch (F00D3F25)
				{
				case 1:
					D90E7D3E.FindElementsById(string_6)[int_2].SendKeys(string_7[i].ToString());
					break;
				case 2:
					D90E7D3E.FindElementsByName(string_6)[int_2].SendKeys(string_7[i].ToString());
					break;
				case 3:
					D90E7D3E.FindElementsByXPath(string_6)[int_2].SendKeys(string_7[i].ToString());
					break;
				case 4:
					D90E7D3E.FindElementsByCssSelector(string_6)[int_2].SendKeys(string_7[i].ToString());
					break;
				}
				if (double_0 > 0.0)
				{
					int num = Convert.ToInt32(double_0 * 1000.0);
					if (num < 100)
					{
						num = 100;
					}
					Thread.Sleep(Base.rd.Next(num, num + 50));
				}
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.SendKeys({F00D3F25},{string_6},{string_7},{double_0},{bool_4})");
		}
		return flag ? 1 : 0;
	}

	public int B0381A81(Random random_0, int D885E0AC, string string_6, string string_7, double double_0, bool E1386436 = true, double C9960290 = 0.1)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			if (E1386436)
			{
				method_14(D885E0AC, string_6);
				C2B42BB6(C9960290);
			}
			int num = 0;
			int num2 = random_0.Next(1, 1000) % 3;
			if (string_7.Length < 3)
			{
				num2 = 2;
				int num3 = 2;
				int num4 = 2;
			}
			else
			{
				num = random_0.Next(1, string_7.Length * 3 / 4);
				switch (num2)
				{
				case 0:
				{
					string c995B3 = string_7.Substring(0, num);
					method_19(D885E0AC, string_6, c995B3, Convert.ToDouble(random_0.Next(10, 100)) / 1000.0);
					C2B42BB6(random_0.Next(1, 3));
					int num5 = random_0.Next(1, num);
					for (int i = 0; i < num5; i++)
					{
						D82A303A(D885E0AC, string_6);
						C2B42BB6(Convert.ToDouble(random_0.Next(1000, 2000)) / 10000.0);
					}
					string text = "";
					switch (D885E0AC)
					{
					case 1:
						text = "#" + string_6;
						break;
					case 2:
						text = "[name=\"" + string_6 + "\"]";
						break;
					case 4:
						text = string_6;
						break;
					}
					c995B3 = string_7.Substring(D90E7D3E.ExecuteScript("return document.querySelector('" + text + "').value+''").ToString().Length);
					C2B42BB6(random_0.Next(1, 3));
					method_19(D885E0AC, string_6, c995B3, Convert.ToDouble(random_0.Next(100, 300)) / 1000.0, bool_4: false);
					C2B42BB6(random_0.Next(1, 3));
					goto IL_02d1;
				}
				case 1:
				{
					string c995B = string_7.Substring(0, num);
					string c995B2 = string_7.Substring(num);
					method_19(D885E0AC, string_6, c995B, Convert.ToDouble(random_0.Next(10, 100)) / 1000.0);
					C2B42BB6(random_0.Next(1, 3));
					method_19(D885E0AC, string_6, c995B2, Convert.ToDouble(random_0.Next(100, 300)) / 1000.0, bool_4: false);
					C2B42BB6(random_0.Next(1, 3));
					goto IL_02d1;
				}
				case 2:
					break;
				default:
					goto IL_02d1;
				}
			}
			method_19(D885E0AC, string_6, string_7, Convert.ToDouble(random_0.Next(100, 200)) / 1000.0);
			C2B42BB6(random_0.Next(1, 3));
			goto IL_02d1;
			IL_02d1:
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.SendKeys({D885E0AC},{string_6},{string_7},{double_0},{E1386436})");
		}
		return flag ? 1 : 0;
	}

	public int method_20(int int_2, int F397A3BD, string FC080703, string BE2DE731, double FD308687, bool bool_4 = true, double double_0 = 0.1)
	{
		if (!F125B9B1())
		{
			return -2;
		}
		int result = 0;
		switch (int_2)
		{
		case 0:
			result = B0381A81(Base.rd, F397A3BD, FC080703, BE2DE731, FD308687, bool_4, double_0);
			break;
		case 1:
			result = method_19(F397A3BD, FC080703, BE2DE731, FD308687, bool_4, double_0);
			break;
		case 2:
			result = method_17(F397A3BD, FC080703, BE2DE731, bool_4, double_0);
			break;
		}
		return result;
	}

	public int D82A303A(int int_2, string string_6)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			switch (int_2)
			{
			case 1:
				D90E7D3E.FindElementById(string_6).SendKeys(Keys.Backspace);
				break;
			case 2:
				D90E7D3E.FindElementByName(string_6).SendKeys(Keys.Backspace);
				break;
			case 3:
				D90E7D3E.FindElementByXPath(string_6).SendKeys(Keys.Backspace);
				break;
			case 4:
				D90E7D3E.FindElementByCssSelector(string_6).SendKeys(Keys.Backspace);
				break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.SendBackspace({int_2},{string_6})");
		}
		return flag ? 1 : 0;
	}

	public void method_21(int int_2 = 0, Random random_0 = null)
	{
		if (random_0 == null)
		{
			random_0 = new Random();
		}
		C2B42BB6(random_0.Next(int_2 + 1, int_2 + 4));
	}

	public void method_22(int int_2, int EC0C1728)
	{
		C2B42BB6(Base.rd.Next(int_2, EC0C1728 + 1));
	}

	public int method_23(int int_2, string string_6, int int_3)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			switch (int_2)
			{
			case 1:
				D90E7D3E.FindElementsById(string_6)[int_3].SendKeys(Keys.Enter);
				break;
			case 2:
				D90E7D3E.FindElementsByTagName(string_6)[int_3].SendKeys(Keys.Enter);
				break;
			case 3:
				D90E7D3E.FindElementsByXPath(string_6)[int_3].SendKeys(Keys.Enter);
				break;
			case 4:
				D90E7D3E.FindElementsByCssSelector(string_6)[int_3].SendKeys(Keys.Enter);
				break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.SendEnter({int_2},{string_6},{int_3})");
		}
		return flag ? 1 : 0;
	}

	public int E7B6218B(int int_2, string string_6, int int_3 = 0, bool bool_4 = true, int CE306E2E = 0)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			if (bool_4)
			{
				method_14(int_2, string_6);
				Thread.Sleep(Convert.ToInt32(CE306E2E * 1000));
			}
			switch (int_2)
			{
			case 1:
				D90E7D3E.FindElementsById(string_6)[int_3].SendKeys(Keys.Control + "v");
				break;
			case 2:
				D90E7D3E.FindElementsByName(string_6)[int_3].SendKeys(Keys.Control + "v");
				break;
			case 3:
				D90E7D3E.FindElementsByXPath(string_6)[int_3].SendKeys(Keys.Control + "v");
				break;
			case 4:
				D90E7D3E.FindElementsByCssSelector(string_6)[int_3].SendKeys(Keys.Control + "v");
				break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.PasteContent({int_2},{string_6},{bool_4})");
		}
		return flag ? 1 : 0;
	}

	public int A2920FB9(int int_2, string AD3DA197)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			switch (int_2)
			{
			case 1:
				D90E7D3E.FindElementById(AD3DA197).SendKeys(Keys.Control + "a");
				break;
			case 2:
				D90E7D3E.FindElementByName(AD3DA197).SendKeys(Keys.Control + "a");
				break;
			case 3:
				D90E7D3E.FindElementByXPath(AD3DA197).SendKeys(Keys.Control + "a");
				break;
			case 4:
				D90E7D3E.FindElementByCssSelector(AD3DA197).SendKeys(Keys.Control + "a");
				break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.SelectText({int_2},{AD3DA197})");
		}
		return flag ? 1 : 0;
	}

	public int F4036238(int CE0D9019, string F79D7AA2)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			switch (CE0D9019)
			{
			case 1:
				D90E7D3E.FindElementById(F79D7AA2).Clear();
				break;
			case 2:
				D90E7D3E.FindElementByName(F79D7AA2).Clear();
				break;
			case 3:
				D90E7D3E.FindElementByXPath(F79D7AA2).Clear();
				break;
			case 4:
				D90E7D3E.FindElementByCssSelector(F79D7AA2).Clear();
				break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.ClearText({CE0D9019},{F79D7AA2})");
		}
		return flag ? 1 : 0;
	}

	public int DE832319(string CFA3D084)
	{
		int result = 0;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			result = Convert.ToInt32(D90E7D3E.ExecuteScript("return document.querySelectorAll('" + CFA3D084 + "').length+''").ToString());
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.CountElement(" + CFA3D084 + ")");
		}
		return result;
	}

	public int C6B3E9B0(string string_6, double double_0 = 0.0)
	{
		bool flag = true;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			int tickCount = Environment.TickCount;
			while ((string)D90E7D3E.ExecuteScript("return document.querySelectorAll('" + string_6 + "').length+''") == "0")
			{
				if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
				{
					if (F125B9B1())
					{
						Thread.Sleep(1000);
						continue;
					}
					return -2;
				}
				flag = false;
				break;
			}
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.CheckExistElement({string_6},{double_0})");
		}
		return flag ? 1 : 0;
	}

	public int method_24(string C288D721, double double_0 = 0.0)
	{
		bool flag = true;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			int tickCount = Environment.TickCount;
			while ((string)D90E7D3E.ExecuteScript("return " + C288D721 + ".length+''") == "0")
			{
				if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
				{
					Thread.Sleep(1000);
					continue;
				}
				flag = false;
				break;
			}
		}
		catch (Exception exception_)
		{
			flag = false;
			EAB97586(null, exception_, $"chrome.CheckExistElement({C288D721},{double_0})");
		}
		return flag ? 1 : 0;
	}

	public int method_25(string string_6, int int_2 = 0, double D3A86286 = 0.0)
	{
		bool flag = true;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			int tickCount = Environment.TickCount;
			if (int_2 == 0)
			{
				while ((string)D90E7D3E.ExecuteScript("return document.querySelectorAll('" + string_6 + "').length+''") == "0")
				{
					if (!((double)(Environment.TickCount - tickCount) > D3A86286 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					flag = false;
					break;
				}
			}
			else
			{
				while ((string)D90E7D3E.ExecuteScript("return document.querySelectorAll('" + string_6 + "').length+''") != "0")
				{
					if (!((double)(Environment.TickCount - tickCount) > D3A86286 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					flag = false;
					break;
				}
			}
		}
		catch (Exception exception_)
		{
			flag = false;
			EAB97586(null, exception_, $"chrome.WaitForSearchElement({string_6},{int_2},{D3A86286})");
		}
		return flag ? 1 : 0;
	}

	public int method_26(double double_0 = 0.0, params string[] string_6)
	{
		int num = 0;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				num = Convert.ToInt32(D90E7D3E.ExecuteScript("var arr='" + string.Join("|", string_6) + "'.split('|');var output=0;for(i=0;i<arr.length;i++){ if (document.querySelectorAll(arr[i]).length > 0) { output = i + 1; break;}; }return (output + ''); "));
				if (num == 0)
				{
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					break;
				}
				return num;
			}
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, string.Format("chrome.CheckExistElements({0},{1})", double_0, string.Join("|", string_6)));
		}
		return num;
	}

	public int A7978C22(int FCA69B9A, string string_6)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			switch (FCA69B9A)
			{
			case 1:
				D90E7D3E.FindElementById(string_6).SendKeys(Keys.Enter);
				break;
			case 2:
				D90E7D3E.FindElementByName(string_6).SendKeys(Keys.Enter);
				break;
			case 3:
				D90E7D3E.FindElementByXPath(string_6).SendKeys(Keys.Enter);
				break;
			case 4:
				D90E7D3E.FindElementByCssSelector(string_6).SendKeys(Keys.Enter);
				break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.SendEnter({FCA69B9A},{string_6})");
		}
		return flag ? 1 : 0;
	}

	public int DD235031(int int_2, int FE3DD50A)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			string script = $"window.scrollTo({int_2}, {FE3DD50A})";
			D90E7D3E.ExecuteScript(script);
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.Scroll({int_2},{FE3DD50A})");
		}
		return flag ? 1 : 0;
	}

	public int method_27(string string_6)
	{
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			D90E7D3E.ExecuteScript(string_6 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
			return 1;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.ScrollSmooth(" + string_6 + ")");
			return 0;
		}
	}

	public int method_28(string string_6)
	{
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			if (method_29(string_6) != 0)
			{
				D90E7D3E.ExecuteScript(string_6 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
			}
			return 1;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.ScrollSmoothIfNotExistOnScreen(" + string_6 + ")");
			return 0;
		}
	}

	public int method_29(string string_6)
	{
		int result = 0;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			result = Convert.ToInt32(D90E7D3E.ExecuteScript("var check='';x=" + string_6 + ";if(x.getBoundingClientRect().top<=0) check='-1'; else if(x.getBoundingClientRect().top+x.getBoundingClientRect().height>window.innerHeight) check='1'; else check='0'; return check;"));
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.CheckExistElementOnScreen(" + string_6 + ")");
		}
		return result;
	}

	public Point method_30()
	{
		Point result = new Point(0, 0);
		if (F125B9B1())
		{
			try
			{
				string text = D90E7D3E.ExecuteScript("return window.innerHeight+'|'+window.innerWidth").ToString();
				result.X = Convert.ToInt32(text.Split('|')[1]);
				result.Y = Convert.ToInt32(text.Split('|')[0]);
			}
			catch
			{
			}
		}
		return result;
	}

	public int method_31()
	{
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			try
			{
				D90E7D3E.Quit();
			}
			catch
			{
			}
			if (Process_0 != null)
			{
				try
				{
					Process_0.Kill();
				}
				catch
				{
				}
			}
			return 1;
		}
		catch
		{
			return 0;
		}
	}

	public int method_32(string AFAF0180, string string_6)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			Screenshot screenshot = ((ITakesScreenshot)D90E7D3E).GetScreenshot();
			screenshot.SaveAsFile(AFAF0180 + (AFAF0180.EndsWith("\\") ? "" : "\\") + string_6 + ".png");
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.ScreenCapture(" + AFAF0180 + "," + string_6 + ")");
		}
		return flag ? 1 : 0;
	}

	public int E0863C08(string string_6, string string_7 = ".facebook.com")
	{
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			string[] array = string_6.Split(';');
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.Trim() != "")
				{
					string[] array3 = text.Split('=');
					if (array3.Count() > 1 && array3[0].Trim() != "")
					{
						Cookie cookie = new Cookie(array3[0].Trim(), text.Substring(text.IndexOf('=') + 1).Trim(), string_7, "/", DateTime.Now.AddDays(10.0));
						D90E7D3E.Manage().Cookies.AddCookie(cookie);
					}
				}
			}
			return 1;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.AddCookieIntoChrome(" + string_6 + "," + string_7 + ")");
			return 0;
		}
	}

	public string method_33(string string_6 = "facebook")
	{
		string text = "";
		if (!F125B9B1())
		{
			return "-2";
		}
		try
		{
			Cookie[] array = D90E7D3E.Manage().Cookies.AllCookies.ToArray();
			Cookie[] array2 = array;
			foreach (Cookie cookie in array2)
			{
				if (cookie.Domain.Contains(string_6))
				{
					text = text + cookie.Name + "=" + cookie.Value + ";";
				}
			}
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.GetCookieFromChrome(" + string_6 + ")");
		}
		return text;
	}

	public int D7BF9A1B(string string_6, bool bool_4 = true)
	{
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			D90E7D3E.ExecuteScript("window.open('" + string_6 + "', '_blank').focus();");
			if (bool_4)
			{
				D90E7D3E.SwitchTo().Window(D90E7D3E.WindowHandles.Last());
			}
			return 1;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.OpenNewTab({string_6},{bool_4})");
			return 0;
		}
	}

	public int A890D696()
	{
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			D90E7D3E.Close();
			return 1;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.CloseCurrentTab()");
			return 0;
		}
	}

	public int FFB0DBB0()
	{
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			D90E7D3E.SwitchTo().Window(D90E7D3E.WindowHandles.First());
			return 1;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.SwitchToFirstTab()");
			return 0;
		}
	}

	public int method_34()
	{
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			D90E7D3E.SwitchTo().Window(D90E7D3E.WindowHandles.Last());
			return 1;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, "chrome.SwitchToLastTab()");
			return 0;
		}
	}

	public void C2B42BB6(double B7A93BB4)
	{
		try
		{
			if (!B2277F30())
			{
				Thread.Sleep(Convert.ToInt32(B7A93BB4 * 1000.0));
			}
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.DelayTime({B7A93BB4})");
		}
	}

	public static void EAB97586(Chrome B3001829, Exception exception_0, string B6A94590 = "")
	{
		try
		{
			if (!(B6A94590 == "chrome.Open()"))
			{
				return;
			}
			if (!Directory.Exists("log"))
			{
				Directory.CreateDirectory("log");
			}
			if (!Directory.Exists("log\\html"))
			{
				Directory.CreateDirectory("log\\html");
			}
			if (!Directory.Exists("log\\images"))
			{
				Directory.CreateDirectory("log\\images");
			}
			Random random = new Random();
			string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1000, 9999);
			if (B3001829 != null)
			{
				string contents = B3001829.F4AF93AB("var markup = document.documentElement.innerHTML;return markup;").ToString();
				B3001829.method_32("log\\images\\", text);
				File.WriteAllText("log\\html\\" + text + ".html", contents);
			}
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			streamWriter.WriteLine("File: " + text);
			if (B6A94590 != "")
			{
				streamWriter.WriteLine("Error: " + B6A94590);
			}
			streamWriter.WriteLine();
			if (exception_0 != null)
			{
				streamWriter.WriteLine("Type: " + exception_0.GetType().FullName);
				streamWriter.WriteLine("Message: " + exception_0.Message);
				streamWriter.WriteLine("StackTrace: " + exception_0.StackTrace);
				exception_0 = exception_0.InnerException;
			}
		}
		catch
		{
		}
	}

	public int method_35(int int_2, string string_6, string string_7)
	{
		bool flag = false;
		if (!F125B9B1())
		{
			return -2;
		}
		try
		{
			switch (int_2)
			{
			case 1:
				new SelectElement(D90E7D3E.FindElementById(string_6)).SelectByValue(string_7);
				break;
			case 2:
				new SelectElement(D90E7D3E.FindElementByName(string_6)).SelectByValue(string_7);
				break;
			case 3:
				new SelectElement(D90E7D3E.FindElementByXPath(string_6)).SelectByValue(string_7);
				break;
			case 4:
				new SelectElement(D90E7D3E.FindElementByCssSelector(string_6)).SelectByValue(string_7);
				break;
			}
			flag = true;
		}
		catch (Exception exception_)
		{
			EAB97586(null, exception_, $"chrome.Select({int_2},{string_6},{string_7})");
		}
		return flag ? 1 : 0;
	}

	internal bool DAB02C11()
	{
		try
		{
			if (Process_0 != null)
			{
				return true;
			}
			string string_0 = "";
			for (int i = 0; i < 10; i++)
			{
				try
				{
					try
					{
						string_0 = D90E7D3E.CurrentWindowHandle;
					}
					catch
					{
						string_0 = Common.CreateRandomStringNumber(15);
					}
					if (string_0 != "")
					{
						for (int j = 0; j < 30; j++)
						{
							D90E7D3E.ExecuteScript("document.title='" + string_0 + "'");
							C2B42BB6(1.0);
							Process_0 = (from process_0 in Process.GetProcessesByName("chrome")
								where process_0.MainWindowTitle.Contains(string_0)
								select process_0).FirstOrDefault();
							if (Process_0 != null)
							{
								return true;
							}
						}
					}
				}
				catch
				{
				}
				C2B42BB6(1.0);
			}
		}
		catch
		{
		}
		return false;
	}
}
