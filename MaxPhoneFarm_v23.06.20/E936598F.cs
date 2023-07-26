using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

public class E936598F
{
	internal FirefoxDriver EBA85AA8;

	internal bool ED94178B = false;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal bool bool_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal bool E212B7B8;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal bool bool_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal bool F6995030;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string EF89D728;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal Point point_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int int_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal Point point_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int int_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int D812288C;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int F2242188;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string C13FE72F;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal int int_4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string E439FA39;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_2;

	public bool F6AA5B0D
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

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return E212B7B8;
		}
		[CompilerGenerated]
		set
		{
			E212B7B8 = value;
		}
	}

	public bool B316EDAE
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

	public bool C7977DA7
	{
		[CompilerGenerated]
		get
		{
			return F6995030;
		}
		[CompilerGenerated]
		set
		{
			F6995030 = value;
		}
	}

	public string A8260710
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

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return EF89D728;
		}
		[CompilerGenerated]
		set
		{
			EF89D728 = value;
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

	public int C91C9E9D
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

	public int Int32_0
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

	public Point Point_1
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

	public int C237B28F
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

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return D812288C;
		}
		[CompilerGenerated]
		set
		{
			D812288C = value;
		}
	}

	public int CC07DB1D
	{
		[CompilerGenerated]
		get
		{
			return F2242188;
		}
		[CompilerGenerated]
		set
		{
			F2242188 = value;
		}
	}

	public int Int32_2
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

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return C13FE72F;
		}
		[CompilerGenerated]
		set
		{
			C13FE72F = value;
		}
	}

	public int Int32_3
	{
		[CompilerGenerated]
		get
		{
			return int_4;
		}
		[CompilerGenerated]
		set
		{
			int_4 = value;
		}
	}

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return E439FA39;
		}
		[CompilerGenerated]
		set
		{
			E439FA39 = value;
		}
	}

	public string String_3
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

	public string String_4
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

	public E936598F()
	{
		Boolean_0 = true;
		B316EDAE = false;
		A8260710 = "";
		String_0 = "";
		C91C9E9D = 300;
		Int32_0 = 300;
		Point_0 = new Point(Int32_0, C91C9E9D);
		C237B28F = 300;
		Int32_1 = 0;
		String_1 = "";
		Int32_3 = 0;
		Point_1 = new Point(C237B28F, Int32_1);
		CC07DB1D = 0;
		Int32_2 = 5;
		String_2 = "";
		C7977DA7 = false;
		String_3 = "";
		String_4 = "data\\extension";
	}

	public bool method_0()
	{
		bool result = false;
		ED94178B = true;
		try
		{
			FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService();
			firefoxDriverService.HideCommandPromptWindow = true;
			FirefoxOptions firefoxOptions = new FirefoxOptions();
			firefoxOptions.SetPreference("security.notification_enable_delay", 0);
			firefoxOptions.SetPreference("dom.webnotifications.enabled", preferenceValue: false);
			firefoxOptions.SetPreference("permissions.default.image", Boolean_0 ? 1 : 0);
			firefoxOptions.SetPreference("browser.download.folderList", 2);
			firefoxOptions.SetPreference("browser.download.manager.alertOnEXEOpen", preferenceValue: false);
			firefoxOptions.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/msword, application/csv, application/ris, text/csv, image/png, application/pdf, text/html, text/plain, application/zip, application/x-zip, application/x-zip-compressed, application/download, application/octet-stream");
			firefoxOptions.SetPreference("browser.download.manager.showWhenStarting", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.focusWhenStarting", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.useDownloadDir", preferenceValue: true);
			firefoxOptions.SetPreference("browser.helperApps.alwaysAsk.force", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.alertOnEXEOpen", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.closeWhenDone", preferenceValue: true);
			firefoxOptions.SetPreference("browser.download.manager.showAlertOnComplete", preferenceValue: false);
			firefoxOptions.SetPreference("browser.download.manager.useWindow", preferenceValue: false);
			firefoxOptions.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", preferenceValue: false);
			firefoxOptions.SetPreference("pdfjs.disabled", preferenceValue: true);
			firefoxOptions.AddArguments("-width=" + Point_0.X, "-height=" + Point_0.Y);
			if (A8260710 != "")
			{
				firefoxOptions.SetPreference("general.useragent.override", A8260710);
			}
			else
			{
				firefoxOptions.SetPreference("general.useragent.override", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:82.0) Gecko/20100101 Firefox/82.0");
			}
			new FirefoxProfileManager();
			EBA85AA8 = new FirefoxDriver(firefoxDriverService, firefoxOptions);
			EBA85AA8.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(Int32_2);
			EBA85AA8.Manage().Window.Position = Point_1;
			result = true;
			return result;
		}
		catch (Exception dAB8D)
		{
			smethod_1(null, dAB8D, "firefox.Open()");
			return result;
		}
	}

	public static string smethod_0(FirefoxOptions F2330680, int BE9F93BB)
	{
		int num = 0;
		int num2 = 0;
		int width = Screen.PrimaryScreen.Bounds.Width;
		int height = Screen.PrimaryScreen.Bounds.Height;
		int num3 = width / 3;
		int num4 = height / 2;
		if (BE9F93BB < 3)
		{
			num = num3 * BE9F93BB;
			num2 = 0;
		}
		else
		{
			num = num3 * (BE9F93BB % 3);
			int num5 = BE9F93BB / 2;
			num2 = ((num5 % 2 != 0) ? num4 : 0);
		}
		F2330680.AddArgument($"--width={num3}");
		F2330680.AddArgument($"--height={num4}");
		return num + "|" + num2;
	}

	public string method_1(string E52B67AA, string string_3, string string_4)
	{
		string result = "";
		if (ED94178B)
		{
			try
			{
				result = EBA85AA8.ExecuteScript("function GetSelector(el){let path=[],parent;while(parent=el.parentNode){path.unshift(`${el.tagName}:nth-child(${[].indexOf.call(parent.children, el)+1})`);el=parent}return `${path.join('>')}`.toLowerCase()}; function GetCssSelector(selector, attribute, value){var c = document.querySelectorAll(selector); for (i = 0; i < c.length; i++) { if (c[i].getAttribute(attribute)!=null && c[i].getAttribute(attribute).includes(value)) { return GetSelector(c[i])} }; return '';}; return GetCssSelector('" + E52B67AA + "','" + string_3 + "','" + string_4 + "')").ToString();
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.GetCssSelector(" + E52B67AA + "," + string_3 + "," + string_4 + ")");
			}
		}
		return result;
	}

	public string D7B9BA0D(string string_3, string string_4)
	{
		string result = "";
		if (ED94178B)
		{
			try
			{
				result = EBA85AA8.ExecuteScript("return document.querySelector('" + string_3 + "').getAttribute('" + string_4 + "')").ToString();
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.GetAttributeValue(" + string_3 + "," + string_4 + ")");
			}
		}
		return result;
	}

	public void CC1C5607(int BD9E1620)
	{
		if (ED94178B)
		{
			try
			{
				EBA85AA8.ExecuteScript("window.scrollBy({ top: " + BD9E1620 + ",behavior: 'smooth'});");
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"chrome.ScrollSmooth({BD9E1620})");
			}
		}
	}

	public string F5BA2E37()
	{
		string result = "";
		try
		{
			result = EBA85AA8.ExecuteScript("return navigator.userAgent").ToString();
		}
		catch
		{
		}
		return result;
	}

	public bool D1062D91(int int_5, string string_3)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				switch (int_5)
				{
				case 1:
					EBA85AA8.FindElementById(string_3).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 2:
					EBA85AA8.FindElementByName(string_3).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 3:
					EBA85AA8.FindElementByXPath(string_3).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				case 4:
					EBA85AA8.FindElementByCssSelector(string_3).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.SendKeyDown({int_5},{string_3})");
				return result;
			}
		}
		return result;
	}

	public string method_2()
	{
		if (ED94178B)
		{
			try
			{
				return EBA85AA8.Url;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.GetURL()");
			}
		}
		return "";
	}

	public bool method_3(string string_3)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				EBA85AA8.Navigate().GoToUrl(string_3);
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.GotoURL(" + string_3 + ")");
				return result;
			}
		}
		return result;
	}

	public bool method_4()
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				EBA85AA8.Navigate().Refresh();
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.Refresh()");
				return result;
			}
		}
		return result;
	}

	public bool F7129BB4()
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				EBA85AA8.Navigate().Back();
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.GotoBackPage()");
				return result;
			}
		}
		return result;
	}

	public bool method_5(int A720263D, string string_3, double D58F9E1D)
	{
		if (ED94178B)
		{
			try
			{
				switch (A720263D)
				{
				case 1:
					new Actions(EBA85AA8).MoveToElement(EBA85AA8.FindElement(By.Id(string_3))).Perform();
					break;
				case 2:
					new Actions(EBA85AA8).MoveToElement(EBA85AA8.FindElement(By.Name(string_3))).Perform();
					break;
				case 3:
					new Actions(EBA85AA8).MoveToElement(EBA85AA8.FindElement(By.XPath(string_3))).Perform();
					break;
				case 4:
					new Actions(EBA85AA8).MoveToElement(EBA85AA8.FindElement(By.CssSelector(string_3))).Perform();
					break;
				}
				Thread.Sleep(Convert.ToInt32(D58F9E1D * 1000.0));
				return true;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.HoverElement({A720263D}, {string_3}, {D58F9E1D})");
			}
		}
		return false;
	}

	public bool B8BB4232(int DB383C0D, string string_3, int F4A5EE85 = 0, int DAAC60A2 = 0, string string_4 = "", int int_5 = 0)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				if (DAAC60A2 == 0)
				{
					switch (DB383C0D)
					{
					case 1:
						EBA85AA8.FindElementsById(string_3)[F4A5EE85].Click();
						break;
					case 2:
						EBA85AA8.FindElementsByName(string_3)[F4A5EE85].Click();
						break;
					case 3:
						EBA85AA8.FindElementsByXPath(string_3)[F4A5EE85].Click();
						break;
					case 4:
						EBA85AA8.FindElementsByCssSelector(string_3)[F4A5EE85].Click();
						break;
					}
				}
				else
				{
					switch (DB383C0D)
					{
					case 1:
						EBA85AA8.FindElementsById(string_3)[F4A5EE85].FindElements(By.Id(string_4))[int_5].Click();
						break;
					case 2:
						EBA85AA8.FindElementsByName(string_3)[F4A5EE85].FindElements(By.Name(string_4))[int_5].Click();
						break;
					case 3:
						EBA85AA8.FindElementsByXPath(string_3)[F4A5EE85].FindElements(By.XPath(string_4))[int_5].Click();
						break;
					case 4:
						EBA85AA8.FindElementsByCssSelector(string_3)[F4A5EE85].FindElements(By.CssSelector(string_4))[int_5].Click();
						break;
					}
				}
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.Click({DB383C0D},{string_3})");
				return result;
			}
		}
		return result;
	}

	public bool method_6(int ED321239, string string_3, int E99B6996 = 0, int BE1230A0 = 0, string string_4 = "", int int_5 = 0)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				if (BE1230A0 != 0)
				{
					switch (ED321239)
					{
					case 1:
						new Actions(EBA85AA8).Click(EBA85AA8.FindElementsById(string_3)[E99B6996].FindElements(By.Id(string_4))[int_5]).Perform();
						break;
					case 2:
						new Actions(EBA85AA8).Click(EBA85AA8.FindElementsByName(string_3)[E99B6996].FindElements(By.Name(string_4))[int_5]).Perform();
						break;
					case 3:
						new Actions(EBA85AA8).Click(EBA85AA8.FindElementsByXPath(string_3)[E99B6996].FindElements(By.XPath(string_4))[int_5]).Perform();
						break;
					case 4:
						new Actions(EBA85AA8).Click(EBA85AA8.FindElementsByCssSelector(string_3)[E99B6996].FindElements(By.CssSelector(string_4))[int_5]).Perform();
						break;
					}
				}
				else
				{
					switch (ED321239)
					{
					case 1:
						new Actions(EBA85AA8).Click(EBA85AA8.FindElementsById(string_3)[E99B6996]).Perform();
						break;
					case 2:
						new Actions(EBA85AA8).Click(EBA85AA8.FindElementsByName(string_3)[E99B6996]).Perform();
						break;
					case 3:
						new Actions(EBA85AA8).Click(EBA85AA8.FindElementsByXPath(string_3)[E99B6996]).Perform();
						break;
					case 4:
						new Actions(EBA85AA8).Click(EBA85AA8.FindElementsByCssSelector(string_3)[E99B6996]).Perform();
						break;
					}
				}
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.ClickWithAction({ED321239},{string_3})");
				return result;
			}
		}
		return result;
	}

	public bool method_7(int int_5, string F239BF83, string string_3, bool bool_2 = true)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				if (bool_2)
				{
					B8BB4232(int_5, F239BF83);
				}
				switch (int_5)
				{
				case 1:
					EBA85AA8.FindElementById(F239BF83).SendKeys(string_3);
					break;
				case 2:
					EBA85AA8.FindElementByName(F239BF83).SendKeys(string_3);
					break;
				case 3:
					EBA85AA8.FindElementByXPath(F239BF83).SendKeys(string_3);
					break;
				case 4:
					EBA85AA8.FindElementByCssSelector(F239BF83).SendKeys(string_3);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.SendKeys({int_5},{F239BF83},{string_3},{bool_2})");
				return result;
			}
		}
		return result;
	}

	public bool DD9C95AF(int int_5, string string_3, string string_4, double double_0, bool bool_2 = true)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				if (bool_2)
				{
					B8BB4232(int_5, string_3);
				}
				for (int i = 0; i < string_4.Length; i++)
				{
					switch (int_5)
					{
					case 1:
						EBA85AA8.FindElementById(string_3).SendKeys(string_4[i].ToString());
						break;
					case 2:
						EBA85AA8.FindElementByName(string_3).SendKeys(string_4[i].ToString());
						break;
					case 3:
						EBA85AA8.FindElementByXPath(string_3).SendKeys(string_4[i].ToString());
						break;
					case 4:
						EBA85AA8.FindElementByCssSelector(string_3).SendKeys(string_4[i].ToString());
						break;
					}
					Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
				}
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.SendKeys({int_5},{string_3},{string_4},{double_0},{bool_2})");
				return result;
			}
		}
		return result;
	}

	public bool FBA43A3C(int A4AE0108, string AC9AC81E)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				switch (A4AE0108)
				{
				case 1:
					EBA85AA8.FindElementById(AC9AC81E).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 2:
					EBA85AA8.FindElementByName(AC9AC81E).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 3:
					EBA85AA8.FindElementByXPath(AC9AC81E).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				case 4:
					EBA85AA8.FindElementByCssSelector(AC9AC81E).SendKeys(OpenQA.Selenium.Keys.Control + "a");
					break;
				}
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.SelectText({A4AE0108},{AC9AC81E})");
				return result;
			}
		}
		return result;
	}

	public bool method_8(int E822A98B, string B7A3E6A6)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				switch (E822A98B)
				{
				case 1:
					EBA85AA8.FindElementById(B7A3E6A6).Clear();
					break;
				case 2:
					EBA85AA8.FindElementByName(B7A3E6A6).Clear();
					break;
				case 3:
					EBA85AA8.FindElementByXPath(B7A3E6A6).Clear();
					break;
				case 4:
					EBA85AA8.FindElementByCssSelector(B7A3E6A6).Clear();
					break;
				}
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.ClearText({E822A98B},{B7A3E6A6})");
				return result;
			}
		}
		return result;
	}

	public bool B3B314A7(string DB0BF688, double F10B203C = 0.0)
	{
		bool result = true;
		if (ED94178B)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)EBA85AA8.ExecuteScript("return document.querySelectorAll('" + DB0BF688 + "').length+''") == "0")
				{
					if ((double)(Environment.TickCount - tickCount) > F10B203C * 1000.0)
					{
						return false;
					}
					Thread.Sleep(1000);
				}
				return result;
			}
			catch (Exception dAB8D)
			{
				result = false;
				smethod_1(null, dAB8D, $"firefox.CheckExistElement({DB0BF688},{F10B203C})");
				return result;
			}
		}
		return result;
	}

	public bool method_9(string string_3, double B00EBB36 = 0.0)
	{
		bool result = true;
		if (ED94178B)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while ((string)EBA85AA8.ExecuteScript("return " + string_3 + ".length+''") == "0")
				{
					if ((double)(Environment.TickCount - tickCount) > B00EBB36 * 1000.0)
					{
						return false;
					}
					Thread.Sleep(1000);
				}
				return result;
			}
			catch (Exception dAB8D)
			{
				result = false;
				smethod_1(null, dAB8D, $"firefox.CheckExistElement({string_3},{B00EBB36})");
				return result;
			}
		}
		return result;
	}

	public bool method_10()
	{
		bool result = true;
		if (ED94178B)
		{
			try
			{
				_ = EBA85AA8.Title;
				result = false;
				return result;
			}
			catch (Exception dAB8D)
			{
				ED94178B = false;
				smethod_1(null, dAB8D, "firefox.CheckChromeClosed()");
				return result;
			}
		}
		return result;
	}

	public bool method_11(string AB07E9B9, int DF11F606 = 0, double double_0 = 0.0)
	{
		bool result = true;
		if (ED94178B)
		{
			try
			{
				int tickCount = Environment.TickCount;
				if (DF11F606 != 0)
				{
					while ((string)EBA85AA8.ExecuteScript("return document.querySelectorAll('" + AB07E9B9 + "').length+''") != "0")
					{
						if ((double)(Environment.TickCount - tickCount) > double_0 * 1000.0)
						{
							return false;
						}
						Thread.Sleep(1000);
					}
					return result;
				}
				while ((string)EBA85AA8.ExecuteScript("return document.querySelectorAll('" + AB07E9B9 + "').length+''") == "0")
				{
					if ((double)(Environment.TickCount - tickCount) > double_0 * 1000.0)
					{
						return false;
					}
					Thread.Sleep(1000);
				}
				return result;
			}
			catch (Exception dAB8D)
			{
				result = false;
				smethod_1(null, dAB8D, $"firefox.WaitForSearchElement({AB07E9B9},{DF11F606},{double_0})");
				return result;
			}
		}
		return result;
	}

	public int method_12(double double_0 = 0.0, params string[] string_3)
	{
		int result = 0;
		if (ED94178B)
		{
			try
			{
				int tickCount = Environment.TickCount;
				while (true)
				{
					for (int i = 0; i < string_3.Length; i++)
					{
						if (B3B314A7(string_3[i]))
						{
							return i + 1;
						}
					}
					if (!((double)(Environment.TickCount - tickCount) > double_0 * 1000.0))
					{
						Thread.Sleep(1000);
						continue;
					}
					break;
				}
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, string.Format("firefox.CheckExistElements({0},{1})", double_0, string.Join("|", string_3)));
			}
		}
		return result;
	}

	public bool method_13(int int_5, string E4897F37)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				switch (int_5)
				{
				case 1:
					EBA85AA8.FindElementById(E4897F37).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 2:
					EBA85AA8.FindElementByName(E4897F37).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 3:
					EBA85AA8.FindElementByXPath(E4897F37).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				case 4:
					EBA85AA8.FindElementByCssSelector(E4897F37).SendKeys(OpenQA.Selenium.Keys.Enter);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.SendEnter({int_5},{E4897F37})");
				return result;
			}
		}
		return result;
	}

	public bool method_14(int AA20388B, int int_5)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				string script = $"window.scrollTo({AA20388B}, {int_5})";
				EBA85AA8.ExecuteScript(script);
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.Scroll({AA20388B},{int_5})");
				return result;
			}
		}
		return result;
	}

	public void method_15(string string_3)
	{
		if (ED94178B)
		{
			try
			{
				EBA85AA8.ExecuteScript(string_3 + ".scrollIntoView({ behavior: 'smooth', block: 'center'});");
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.ScrollSmooth(" + string_3 + ")");
			}
		}
	}

	public int method_16(string D1885F81)
	{
		int result = -2;
		if (ED94178B)
		{
			try
			{
				result = Convert.ToInt32(EBA85AA8.ExecuteScript("var check='';x=" + D1885F81 + ";if(x.getBoundingClientRect().top<=0) check='-1'; else if(x.getBoundingClientRect().top+x.getBoundingClientRect().height>window.innerHeight) check='1'; else check='0'; return check;"));
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.CheckExistElementOnScreen(" + D1885F81 + ")");
			}
		}
		return result;
	}

	public Point method_17()
	{
		Point result = new Point(0, 0);
		if (ED94178B)
		{
			try
			{
				string text = EBA85AA8.ExecuteScript("return window.innerHeight+'|'+window.innerWidth").ToString();
				result.X = Convert.ToInt32(text.Split('|')[1]);
				result.Y = Convert.ToInt32(text.Split('|')[0]);
			}
			catch
			{
			}
		}
		return result;
	}

	public void method_18()
	{
		try
		{
			if (EBA85AA8 != null)
			{
				EBA85AA8.Quit();
			}
			ED94178B = false;
		}
		catch (Exception dAB8D)
		{
			smethod_1(null, dAB8D, "firefox.Close()");
		}
	}

	public void CF03E333(string BB0A0725, string string_3 = ".facebook.com")
	{
		if (!ED94178B)
		{
			return;
		}
		try
		{
			string[] array = BB0A0725.Split(';');
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.Trim() != "")
				{
					string[] array3 = text.Split('=');
					if (array3.Count() > 1 && array3[0].Trim() != "")
					{
						Cookie cookie = new Cookie(array3[0].Trim(), text.Substring(text.IndexOf('=') + 1).Trim(), string_3, "/", DateTime.Now.AddDays(10.0));
						EBA85AA8.Manage().Cookies.AddCookie(cookie);
					}
				}
			}
		}
		catch (Exception dAB8D)
		{
			smethod_1(null, dAB8D, "firefox.AddCookieIntoChrome(" + BB0A0725 + "," + string_3 + ")");
		}
	}

	public string method_19(string string_3 = "facebook")
	{
		string text = "";
		if (ED94178B)
		{
			try
			{
				Cookie[] array = EBA85AA8.Manage().Cookies.AllCookies.ToArray();
				Cookie[] array2 = array;
				foreach (Cookie cookie in array2)
				{
					if (cookie.Domain.Contains(string_3))
					{
						text = text + cookie.Name + "=" + cookie.Value + ";";
					}
				}
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.GetCookieFromChrome(" + string_3 + ")");
			}
		}
		return text;
	}

	public void method_20(string string_3, bool E8844C91 = true)
	{
		if (!ED94178B)
		{
			return;
		}
		try
		{
			EBA85AA8.ExecuteScript("window.open('" + string_3 + "', '_blank').focus();");
			if (E8844C91)
			{
				EBA85AA8.SwitchTo().Window(EBA85AA8.WindowHandles.Last());
			}
		}
		catch (Exception dAB8D)
		{
			smethod_1(null, dAB8D, $"firefox.OpenNewTab({string_3},{E8844C91})");
		}
	}

	public void method_21()
	{
		if (ED94178B)
		{
			try
			{
				EBA85AA8.Close();
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.CloseCurrentTab()");
			}
		}
	}

	public void D6B8A52F()
	{
		if (ED94178B)
		{
			try
			{
				EBA85AA8.SwitchTo().Window(EBA85AA8.WindowHandles.First());
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.SwitchToFirstTab()");
			}
		}
	}

	public void F21B7696()
	{
		if (ED94178B)
		{
			try
			{
				EBA85AA8.SwitchTo().Window(EBA85AA8.WindowHandles.Last());
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.SwitchToLastTab()");
			}
		}
	}

	public void method_22(double double_0)
	{
		if (ED94178B)
		{
			try
			{
				Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.DelayTime({double_0})");
			}
		}
	}

	public bool method_23(int int_5, string CFB4C61E, string A41AF90F)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				switch (int_5)
				{
				case 1:
					new SelectElement(EBA85AA8.FindElementById(CFB4C61E)).SelectByValue(A41AF90F);
					break;
				case 2:
					new SelectElement(EBA85AA8.FindElementByName(CFB4C61E)).SelectByValue(A41AF90F);
					break;
				case 3:
					new SelectElement(EBA85AA8.FindElementByXPath(CFB4C61E)).SelectByValue(A41AF90F);
					break;
				case 4:
					new SelectElement(EBA85AA8.FindElementByCssSelector(CFB4C61E)).SelectByValue(A41AF90F);
					break;
				}
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, $"firefox.Select({int_5},{CFB4C61E},{A41AF90F})");
				return result;
			}
		}
		return result;
	}

	public bool method_24(string string_3, string string_4)
	{
		bool result = false;
		if (ED94178B)
		{
			try
			{
				Screenshot screenshot = ((ITakesScreenshot)EBA85AA8).GetScreenshot();
				screenshot.SaveAsFile(string_3 + (string_3.EndsWith("\\") ? "" : "\\") + string_4 + ".png");
				result = true;
				return result;
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "chrome.ScreenCapture(" + string_3 + "," + string_4 + ")");
				return result;
			}
		}
		return result;
	}

	public object method_25(string string_3)
	{
		if (ED94178B)
		{
			try
			{
				return EBA85AA8.ExecuteScript(string_3);
			}
			catch (Exception dAB8D)
			{
				smethod_1(null, dAB8D, "firefox.ExecuteScript(" + string_3 + ")");
			}
		}
		return "";
	}

	public static void smethod_1(Chrome C79D2D9C, Exception DAB8D436, string D73E1A9C = "")
	{
		try
		{
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
			if (C79D2D9C != null)
			{
				string contents = C79D2D9C.F4AF93AB("var markup = document.documentElement.innerHTML;return markup;").ToString();
				C79D2D9C.method_32("log\\images\\", text);
				File.WriteAllText("log\\html\\" + text + ".html", contents);
			}
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			streamWriter.WriteLine("File: " + text);
			if (D73E1A9C != "")
			{
				streamWriter.WriteLine("Error: " + D73E1A9C);
			}
			streamWriter.WriteLine();
			if (DAB8D436 != null)
			{
				streamWriter.WriteLine("Type: " + DAB8D436.GetType().FullName);
				streamWriter.WriteLine("Message: " + DAB8D436.Message);
				streamWriter.WriteLine("StackTrace: " + DAB8D436.StackTrace);
				DAB8D436 = DAB8D436.InnerException;
			}
		}
		catch
		{
		}
	}
}
