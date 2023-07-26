using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json.Linq;
using OpenCvSharp;
using OpenCvSharp.Extensions;

public class AC28BD29
{
	public enum DB353F82
	{
		const_0 = 0,
		A68480B5 = 1,
		const_2 = 2,
		const_3 = 3,
		FF99AA2C = 4,
		const_5 = 5,
		const_6 = 6,
		const_7 = 7,
		FE272F39 = 8,
		const_9 = 9,
		const_10 = 10,
		const_11 = 11,
		E8BB1B8A = 12,
		const_13 = 13,
		C4924FBB = 14,
		EA96758C = 0xF,
		F492C82E = 0x10,
		BCB4BA89 = 17,
		F59812A3 = 18,
		const_19 = 19,
		E1B15FAB = 20,
		const_21 = 21,
		const_22 = 22,
		B7AD8015 = 23,
		const_24 = 24,
		BF9E93B5 = 25,
		const_26 = 26,
		const_27 = 27,
		const_28 = 28,
		const_29 = 29,
		const_30 = 30,
		const_31 = 0x1F,
		C033E210 = 0x20,
		A9350CB8 = 33,
		const_34 = 34,
		const_35 = 35,
		const_36 = 36,
		ADB6BD11 = 37,
		B5AE930C = 38,
		const_39 = 39,
		const_40 = 40,
		B1A16900 = 41,
		const_42 = 42,
		B5928E01 = 43,
		B783EC8C = 44,
		const_45 = 45,
		const_46 = 46,
		const_47 = 47,
		const_48 = 48,
		B1170B1D = 49,
		C72580B1 = 50,
		const_51 = 51,
		const_52 = 52,
		EB15C1BA = 53,
		const_54 = 54,
		CB80A3B6 = 55,
		D0AC67AA = 56,
		const_57 = 57,
		const_58 = 58,
		const_59 = 59,
		const_60 = 60,
		D1A3BB0E = 61,
		const_62 = 62,
		const_63 = 0x3F,
		const_64 = 0x40,
		const_65 = 65,
		E22EE10E = 66,
		const_67 = 67,
		BD19AC99 = 68,
		E9063BAE = 69,
		const_70 = 70,
		C62BF52F = 71,
		const_72 = 72,
		const_73 = 73,
		B43EFE95 = 74,
		const_75 = 75,
		const_76 = 76,
		B9271707 = 77,
		const_78 = 78,
		const_79 = 79,
		const_80 = 80,
		const_81 = 81,
		F996F823 = 82,
		DF3C87BA = 83,
		const_84 = 187,
		const_85 = 164
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class D2969D1C
	{
		internal static readonly D2969D1C _003C_003E9 = new D2969D1C();

		internal static Func<string, int> _003C_003E9__87_0;

		internal static Func<string, int> _003C_003E9__87_1;

		internal static Func<Rect, int> _003C_003E9__172_0;

		internal static Func<Rect, int> _003C_003E9__172_1;

		internal static Func<string, Guid> _003C_003E9__191_0;

		internal static Func<string, Guid> _003C_003E9__191_1;

		internal static Func<string, bool> _003C_003E9__196_0;

		internal static Func<string, bool> _003C_003E9__207_0;

		internal static Func<string, string> _003C_003E9__231_0;

		internal int method_0(string string_0)
		{
			return new Class65(string_0).B9898119;
		}

		internal int method_1(string string_0)
		{
			return new Class65(string_0).int_0;
		}

		internal int method_2(Rect rect_0)
		{
			return rect_0.Y;
		}

		internal int method_3(Rect BF27A196)
		{
			return BF27A196.X;
		}

		internal Guid method_4(string string_0)
		{
			return Guid.NewGuid();
		}

		internal Guid method_5(string string_0)
		{
			return Guid.NewGuid();
		}

		internal bool method_6(string B91B3085)
		{
			return !string.IsNullOrEmpty(B91B3085);
		}

		internal bool method_7(string FE18813D)
		{
			return FE18813D.StartsWith("com.facebook.ka");
		}

		internal string method_8(string AB151FB5)
		{
			return AB151FB5;
		}
	}

	[CompilerGenerated]
	private sealed class Class29
	{
		internal string F8B79789;

		internal string string_0;

		internal void method_0(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				F8B79789 = F8B79789 + e.Data + "\n";
			}
		}

		internal void method_1(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				string_0 = string_0 + e.Data + "\n";
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class30
	{
		internal string string_0;

		internal AC28BD29 ac28BD29_0;

		internal void method_0()
		{
			ac28BD29_0.RunCMD("shell am start -n " + string_0 + "/v.q -c android.intent.category.LAUNCHER -a android.intent.action.MAIN");
		}
	}

	[CompilerGenerated]
	private sealed class Class31
	{
		internal AC28BD29 ac28BD29_0;

		internal int A1B4F68B;

		internal void method_0()
		{
			lock (ac28BD29_0.B3A1E897)
			{
				int tickCount = Environment.TickCount;
				do
				{
					ac28BD29_0.bool_1 = ac28BD29_0.d59F6E91_0.method_0() == 1;
				}
				while (!ac28BD29_0.bool_1 && Environment.TickCount - tickCount < A1B4F68B * 1000);
			}
		}
	}

	internal Random F639F68B = new Random();

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_0 = "http://127.0.0.1";

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string B2975A2A = "4723";

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal int int_0 = 360000;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_1 = "";

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string BE271400 = "";

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	internal string string_2 = "";

	internal bool bool_0 = false;

	internal string C1A4E80C = "";

	internal string FacebookPacker = "com.facebook.katana";

	internal string string_4 = "com.ss.android.ugc.trill";

	internal string string_5 = "com.instagram.android";

	internal bool searchComplete = false;

	internal System.Drawing.Point? CE83A732 = null;

	internal int int_1 = 0;

	internal string Proxy = "";

	internal D59F6E91 d59F6E91_0;

	internal bool bool_1 = false;

	internal object B3A1E897 = new object();

	internal int B0B83885 = 0;

	internal int int_2 = 10;

	internal string NameFake = "";

	internal object object_0 = new object();

	internal string EA987635 = "";

	private string String_0
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

	private string BBBFC33D
	{
		[CompilerGenerated]
		get
		{
			return B2975A2A;
		}
		[CompilerGenerated]
		set
		{
			B2975A2A = value;
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

	private string CF2ABEA0
	{
		[CompilerGenerated]
		get
		{
			return BE271400;
		}
		[CompilerGenerated]
		set
		{
			BE271400 = value;
		}
	}

	private string FDBC403C
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

	public void E985C0AA(string string_7)
	{
		FDBC403C = string_7;
	}

	public string method_0()
	{
		return CommonSQL.smethod_14(FDBC403C);
	}

	public string GetAndroidVersion()
	{
		if (CF2ABEA0 == "")
		{
			CF2ABEA0 = RunCMD("shell getprop ro.build.version.release");
        }
		return CF2ABEA0;
	}

	public string method_2(bool A8A5122B = false)
	{
		if (C1A4E80C == "")
		{
			C1A4E80C = Class64.smethod_2(String_1);
			if (C1A4E80C == "")
			{
				if (A8A5122B)
				{
					return "";
				}
				B3039BB3();
			}
		}
		return C1A4E80C;
	}

	public void method_3(string string_7 = "")
	{
		C1A4E80C = string_7;
	}

	public void E0068C33(int A489CE8B, string string_7)
	{
		int_1 = A489CE8B;
		Proxy = string_7;
	}

	public void RemoveProxy()
	{
        RunCMD("shell settings put global http_proxy :0");
        RunCMD("shell settings delete global http_proxy");
        RunCMD("shell settings delete global global_http_proxy_host");
        RunCMD("shell settings delete global global_http_proxy_port");
        ClearDataApp("com.cell47.College_Proxy");
		int_1 = 0;
		Proxy = "";
	}

	public bool ConnectHttpProxy()
	{
		if (string.IsNullOrEmpty(Proxy))
		{
			return true;
		}
		if (Proxy.Split(':').Length == 2)
		{
			RunCMD("shell settings put global http_proxy " + Proxy);
			return true;
		}
		if (Proxy.Split(':').Length == 4)
		{
			return method_22(Proxy);
		}
		return false;
	}

	public void EE33D530(string string_7, string string_8)
	{
		d59F6E91_0 = new D59F6E91(string_7, string_8, 0, 1);
	}

	public string E2B66888()
	{
		bool_1 = false;
		return d59F6E91_0.string_1;
	}

	public void AABD1000(int int_3 = 60)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			lock (B3A1E897)
			{
				int tickCount = Environment.TickCount;
				do
				{
					bool_1 = d59F6E91_0.method_0() == 1;
				}
				while (!bool_1 && Environment.TickCount - tickCount < int_3 * 1000);
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	public bool method_6(int FA39ABAE = 300)
	{
		lock (B3A1E897)
		{
		}
		int tickCount = Environment.TickCount;
		do
		{
			if (bool_1)
			{
				if (d59F6E91_0.C9360086())
				{
					return true;
				}
			}
			else
			{
				AABD1000();
				lock (B3A1E897)
				{
				}
				TimeDelay(5.0);
			}
		}
		while (Environment.TickCount - tickCount < FA39ABAE * 1000);
		return false;
	}

	private string method_7(int D0A7A724, string E204DA16, string string_7 = "")
	{
		try
		{
			string text3;
			while (true)
			{
				if (!searchComplete)
				{
					string text = $"{String_0}:{BBBFC33D}/wd/hub";
					if (E204DA16.Contains("{this.sessionId}"))
					{
						string text2 = method_2();
						if (text2 == "")
						{
							return "";
						}
						text += E204DA16.Replace("{this.sessionId}", text2);
					}
					else
					{
						text += E204DA16;
					}
					RequestXNet b01F5C = new RequestXNet("", "", "", 0);
					text3 = ((D0A7A724 == 0) ? b01F5C.RequestGet(text) : b01F5C.method_1(text, string_7, "application/json"));
					if (!searchComplete)
					{
						if (text3.Contains("cannot be proxied to UiAutomator2 server because the instrumentation process is not running (probably crashed)"))
						{
							if (B0B83885 >= int_2)
							{
								B0B83885 = 0;
								Class64.CloseServerAppium();
								Class64.smethod_1();
							}
							B0B83885++;
							continue;
						}
						B0B83885 = 0;
						if (text3.Contains("Cannot find any free port in range 8200..8299"))
						{
							GClass1.smethod_2();
							GClass1.smethod_3();
							continue;
						}
						if (text3.Contains("cannot_connect") || text3.Contains("A session is either terminated or not started") || text3.Contains("Could not proxy command to the remote server") || text3.Contains("The requested resource could not be found, or a request was received using an HTTP method that is not supported by the mapped resource"))
						{
							Class64.smethod_1();
							method_11();
							continue;
						}
						if (!(Regex.Match(text3, "device (.*?) not found").Groups[1].Value != "") && !text3.Contains("was not in the list of connected devices") && !text3.Contains("Could not find a connected Android device"))
						{
							break;
						}
						if (DB3DB1A4())
						{
							continue;
						}
						return "disconnect";
					}
					return "disconnect";
				}
				return "disconnect";
			}
			return text3;
		}
		catch (Exception)
		{
			return "";
		}
	}

	private bool B2309AB0()
	{
		List<string> list = GClass1.GetDevices();
		if (list.Contains(String_1))
		{
			return true;
		}
		if (String_1.StartsWith("127.0.0.1:") || String_1.StartsWith("emulator-"))
		{
			if (String_1.StartsWith("127.0.0.1:"))
			{
				String_1 = string.Format("emulator-{0}", Convert.ToInt32(String_1.Replace("127.0.0.1:", "")) - 1);
			}
			else if (String_1.StartsWith("emulator-"))
			{
				String_1 = string.Format("127.0.0.1:{0}", Convert.ToInt32(String_1.Replace("emulator-", "")) + 1);
			}
			return list.Contains(String_1);
		}
		return false;
	}

	private bool DB3DB1A4(int B1BBD71B = 60)
	{
		try
		{
			if (B2309AB0())
			{
				return true;
			}
			int tickCount = Environment.TickCount;
			bool flag = false;
			while (!searchComplete)
			{
				string input = RunCMD("reconnect");
				if (!(flag = Regex.Match(input, "device (.*?) not found").Groups[1].Value == "") && (String_1.StartsWith("127.0.0.1:") || String_1.StartsWith("emulator-")))
				{
					int num = 0;
					if (String_1.StartsWith("127.0.0.1:"))
					{
						num = Convert.ToInt32(String_1.Replace("127.0.0.1:", ""));
					}
					else if (String_1.StartsWith("emulator-"))
					{
						num = Convert.ToInt32(String_1.Replace("emulator-", "")) + 1;
					}
					flag = !GClass1.D22E1AB1($"adb connect 127.0.0.1:{num}").Contains("cannot connect to");
				}
				if (flag)
				{
					TimeDelay(3.0);
					if (B2309AB0())
					{
						return true;
					}
				}
				if (Environment.TickCount - tickCount >= B1BBD71B * 1000)
				{
					break;
				}
			}
			searchComplete = true;
			Base.FA2640AB.E7154231(this);
		}
		catch (Exception)
		{
		}
		return false;
	}

	private string method_8(string string_7)
	{
		return method_7(0, string_7);
	}

	public string method_9(string A837B134, string string_7)
	{
		return method_7(1, A837B134, string_7);
	}

	public AC28BD29(string string_7)
	{
		String_1 = string_7;
		GetAndroidVersion();
	}

	private string method_10()
	{
		string string_ = "/session/{this.sessionId}";
		return method_8(string_);
	}

	private bool B3039BB3()
	{
		while (Class64.A42EF119 >= Class64.AF176B18)
		{
			Common.DelayTime(1.0);
		}
		Class64.A42EF119++;
		string text = "";
		string a837B = "/session";
		try
		{
			JSON_Settings f72FAFBC = new JSON_Settings();
			f72FAFBC.GetValue("platformName", (object)"Android");
			f72FAFBC.GetValue("platformVersion", (object)GetAndroidVersion());
			f72FAFBC.GetValue("deviceName", (object)String_1);
			f72FAFBC.GetValue("udid", (object)String_1);
			f72FAFBC.GetValue("automationName", (object)"UiAutomator2");
			f72FAFBC.GetValue("noReset", true);
			f72FAFBC.GetValue("disableWindowAnimation", true);
			f72FAFBC.GetValue("gpsEnabled", false);
			f72FAFBC.GetValue("skipLogcatCapture", true);
			f72FAFBC.GetValue("dontStopAppOnReset", true);
			f72FAFBC.GetValue("ignoreHiddenApiPolicyError", true);
			f72FAFBC.GetValue("noSign", false);
			f72FAFBC.GetValue("newCommandTimeout", Int32_0);
			string text2 = "{ \"desiredCapabilities\":" + f72FAFBC.C71A4EA4() + "}";
			string text3 = method_9(a837B, text2);
			try
			{
				text = JObject.Parse(text3)["sessionId"]!.ToString();
			}
			catch (Exception)
			{
			}
			if (text != "")
			{
				method_3(text);
				method_12(text3);
			}
			else
			{
				lock (Class64.object_0)
				{
					File.AppendAllText("device.txt", text2 + Environment.NewLine);
					File.AppendAllText("device.txt", text3 + Environment.NewLine);
					File.AppendAllText("device.txt", "-----------------------------" + Environment.NewLine);
				}
			}
		}
		catch (Exception)
		{
		}
		Class64.A42EF119--;
		return text != "";
	}

	public bool method_11()
	{
		string text = method_2(A8A5122B: true);
		if (text == "")
		{
			return false;
		}
		string text2 = "/session/" + text;
		string requestUriString = $"{String_0}:{BBBFC33D}/wd/hub" + text2.Replace("{this.sessionId}", text);
		bool result = false;
		try
		{
			WebRequest webRequest = WebRequest.Create(requestUriString);
			webRequest.Method = "DELETE";
			webRequest.Headers["Cache-Control"] = "no-cache";
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
			{
				streamReader.ReadToEnd();
			}
			result = true;
		}
		catch (Exception)
		{
		}
		method_3();
		return result;
	}

	private string AB9B6E39(int int_3, List<string> BE18C886 = null)
	{
		string result = "";
		try
		{
			if (BE18C886 == null || BE18C886.Count == 0)
			{
				BE18C886 = GClass1.GetDevices();
			}
			new List<string>
			{
				"127.0.0.1:" + (int_3 * 2 + 5555),
				"emulator-" + (int_3 * 2 + 5554)
			};
		}
		catch
		{
		}
		return result;
	}

	public System.Drawing.Point? method_12(string string_7 = "")
	{
		try
		{
			if (!CE83A732.HasValue)
			{
				if (string.IsNullOrEmpty(string_7))
				{
					string_7 = method_10();
				}
				if (string_7.Contains("deviceScreenSize"))
				{
					string text = JObject.Parse(string_7)["value"]!["deviceScreenSize"]!.ToString();
					CE83A732 = new System.Drawing.Point(Convert.ToInt32(text.Split('x')[0]), Convert.ToInt32(text.Split('x')[1]));
				}
			}
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return CE83A732;
	}

	public int method_13()
	{
		return method_12().Value.Y;
	}

	public int method_14()
	{
		return method_12().Value.X;
	}

	public string method_15()
	{
		try
		{
			string string_ = "/session/{this.sessionId}/appium/device/current_activity";
			string json = method_8(string_);
			return JObject.Parse(json)["value"]!.ToString();
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return "";
	}

	private bool method_16(string string_7)
	{
		try
		{
			NoteLog("Open app " + FacebookPacker + "...");
			string a837B = "/session/{this.sessionId}/appium/device/activate_app";
			string string_8 = "{\"bundleId\": \"" + string_7 + "\"}";
			method_9(a837B, string_8);
			return true;
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	public void method_17()
	{
		RunCMD("reboot recovery");
		for (int i = 0; i < 2; i++)
		{
			RunCMD("wait-for-recovery");
			if (i == 0)
			{
				TimeDelay(5.0);
			}
		}
	}

	internal void C3933D9C(string string_7)
	{
		RunCMD("shell twrp format data");
		RunCMD("shell twrp wipe data");
		RunCMD("shell twrp wipe cache");
		RunCMD("shell twrp wipe dalvik");
		RunCMD("shell twrp wipe system");
		List<string> list = Directory.GetFiles(string_7).ToList();
		for (int i = 0; i < list.Count; i++)
		{
			RunCMD("shell rm -r /sdcard/");
			RunCMD("push \"" + list[i] + "\" /sdcard/" + Path.GetFileName(list[i]), 600);
			RunCMD("shell twrp install /sdcard/" + Path.GetFileName(list[i]), 600);
		}
		RunCMD("reboot");
	}

	private int B0B3EE2F(string F5899B15)
	{
		try
		{
			string a837B = "/session/{this.sessionId}/appium/device/app_state";
			string string_ = "{\"bundleId\": \"" + F5899B15 + "\"}";
			string json = method_9(a837B, string_);
			return Convert.ToInt32(JObject.Parse(json)["value"]!.ToString());
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return -1;
	}

	public bool method_18(string string_7)
	{
		try
		{
			RunCMD("shell su -c am start -n " + string_7);
			return true;
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	public bool method_19(int BB12F1A1 = 1, double F530A98E = 0.5)
	{
		try
		{
			NoteLog("Back...");
			string a837B = "/session/{this.sessionId}/back";
			for (int i = 0; i < BB12F1A1; i++)
			{
				method_9(a837B, "");
				TimeDelay(F530A98E);
			}
			return true;
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	public string method_20()
	{
		try
		{
			NoteLog("Back...");
			string a837B = "/session/{this.sessionId}/appium/device/get_clipboard";
			string json = method_9(a837B, "");
			return Common.B537BA12(JObject.Parse(json)["value"]!.ToString());
		}
		catch (Exception)
		{
		}
		return "";
	}

	public string FindElement(int int_3, string string_7, List<string> C8A46E25)
	{
		return CB3C4B8A(int_3, ref string_7, C8A46E25);
	}

	public string CB3C4B8A(int int_3, ref string string_7, List<string> list_0)
	{
		int tickCount = Environment.TickCount;
		do
		{
			if (!searchComplete)
			{
				if (string_7 == "")
				{
					string_7 = GetPageSource();
				}
				for (int i = 0; i < list_0.Count; i++)
				{
					if (DoesElementExist(0, string_7, list_0[i]))
					{
						return list_0[i];
					}
				}
				if (int_3 == 0 || Environment.TickCount - tickCount > int_3 * 1000)
				{
					break;
				}
				TimeDelay(1.0);
				string_7 = "";
				continue;
			}
			return "";
		}
		while (Environment.TickCount - tickCount < int_3 * 1000);
		return "";
	}

	public bool DoesElementExist(int BC1CC395, string C13EC68A, string string_7)
	{
		return FindElements(BC1CC395, C13EC68A, string_7).Count > 0;
	}

	internal bool method_22(string string_7)
	{
		if (!method_120().Contains("com.cell47.College_Proxy"))
		{
			C03D049A(FileHelper.GetPathToCurrentFolder() + "\\app\\collegeproxy.apk");
			TimeDelay(3.0);
		}
		ClearDataApp("com.cell47.College_Proxy");
		method_58("com.cell47.College_Proxy");
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 120;
		while (!searchComplete)
		{
			text = GetPageSource();
			text2 = FindElement(0, text, new List<string> { "//*[@text='STOP PROXY SERVICE']", "(//*[starts-with(@text,'Proxy Host:')]/parent::*/child::*)[last()]", "//android.widget.Button[@text='START SERVICE']", "//*[@text='Please enter a valid IPV4 server address.']", "//*[@text='OK']" });
			switch (text2)
			{
			case "//android.widget.Button[@text='START SERVICE']":
				if (!ED9CDB24(text, "Things are good and ready to go"))
				{
					TapByXPath(text2, text);
					break;
				}
				TapByXPath(text2, text);
				return true;
			case "//*[@text='OK']":
				TapByXPath(text2, text);
				break;
			case "(//*[starts-with(@text,'Proxy Host:')]/parent::*/child::*)[last()]":
				SendByXPath("(//*[starts-with(@text,'Proxy Host:')]/parent::*/child::*)[last()]", string_7.Split(':')[0]);
				SendByXPath("(//*[starts-with(@text,'Proxy Port:')]/parent::*/child::*)[last()]", string_7.Split(':')[1]);
				if (string_7.Split(':').Length > 3)
				{
					SendByXPath("(//*[starts-with(@text,'Username:')]/parent::*/child::*)[last()]", string_7.Split(':')[2]);
					SendByXPath("(//*[starts-with(@text,'Password:')]/parent::*/child::*)[last()]", string_7.Split(':')[3]);
				}
				TapByXPath("//*[@text='START PROXY SERVICE']");
				break;
			case "//*[@text='STOP PROXY SERVICE']":
				DC949F30();
				return true;
			case "//*[@text='Please enter a valid IPV4 server address.']":
				return false;
			}
			TimeDelay(2.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	public bool C60AEB35(int int_3, ref string string_7, string A2B506B6)
	{
		return method_26(int_3, ref string_7, A2B506B6).Count > 0;
	}

	public List<string> method_23(string string_7, string string_8, string string_9 = "bounds")
	{
		List<string> list = new List<string>();
		try
		{
			if (string_7 == "")
			{
				string_7 = GetPageSource();
			}
			string_7 = string_7.ToLower();
			string_8 = string_8.ToLower();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(string_7);
			XmlNodeList xmlNodeList = xmlDocument.SelectNodes(string_8);
			for (int i = 0; i < xmlNodeList.Count; i++)
			{
				try
				{
					list.Add(xmlNodeList[i].Attributes[string_9].Value);
				}
				catch
				{
				}
			}
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return list;
	}

	public List<string> method_24(int int_3, string D889A80C)
	{
		List<string> list = new List<string>();
		try
		{
			int tickCount = Environment.TickCount;
			while (!searchComplete)
			{
				if (D889A80C == "")
				{
					D889A80C = GetPageSource();
				}
				D889A80C = D889A80C.ToLower();
				MatchCollection matchCollection = Regex.Matches(D889A80C, "bounds=\"(.*?)\"");
				for (int i = 0; i < matchCollection.Count; i++)
				{
					list.Add(matchCollection[i].Groups[1].Value);
				}
				if (list.Count <= 0 && int_3 != 0)
				{
					TimeDelay(1.0);
					D889A80C = "";
					if (Environment.TickCount - tickCount >= int_3 * 1000)
					{
						break;
					}
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return list.Distinct().ToList();
	}

	public List<string> EB158100(int int_3, string string_7, string C3159CB4)
	{
		List<string> list = new List<string>();
		try
		{
			int tickCount = Environment.TickCount;
			while (!searchComplete)
			{
				if (string_7 == "")
				{
					string_7 = GetPageSource();
				}
				string_7 = string_7.ToLower();
				MatchCollection matchCollection = Regex.Matches(string_7, Regex.Replace(C3159CB4.ToLower(), "\\p{Cs}", "").Replace("(", "\\(").Replace(")", "\\)")
					.Replace("[", "\\[")
					.Replace("]", "\\]") + "(.*?)/>");
				if (matchCollection.Count == 0 && C3159CB4.Contains("&"))
				{
					matchCollection = Regex.Matches(string_7, Regex.Replace(C3159CB4.ToLower(), "\\p{Cs}", "").Replace("&", "&amp;").Replace("(", "\\(")
						.Replace(")", "\\)")
						.Replace("[", "\\[")
						.Replace("]", "\\]") + "(.*?)/>");
				}
				for (int i = 0; i < matchCollection.Count; i++)
				{
					list.Add(Regex.Match(matchCollection[i].Value, "bounds=\"(.*?)\"").Groups[1].Value);
				}
				if (list.Count <= 0 && int_3 != 0)
				{
					TimeDelay(1.0);
					string_7 = "";
					if (Environment.TickCount - tickCount >= int_3 * 1000)
					{
						break;
					}
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return list.Distinct().ToList();
	}

	public List<string> FindElements(int F81F5820, string string_7, string string_8)
	{
		List<string> list = new List<string>();
		try
		{
			int tickCount = Environment.TickCount;
			while (!searchComplete)
			{
				if (string_7 == "")
				{
					string_7 = GetPageSource();
				}
				list = method_23(string_7, string_8);
				if (list.Count <= 0 && F81F5820 != 0)
				{
					TimeDelay(1.0);
					string_7 = "";
					if (Environment.TickCount - tickCount >= F81F5820 * 1000)
					{
						break;
					}
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return list.Distinct().ToList();
	}

	public List<string> method_26(int int_3, ref string string_7, string string_8)
	{
		List<string> list = new List<string>();
		try
		{
			int tickCount = Environment.TickCount;
			while (!searchComplete)
			{
				if (string_7 == "")
				{
					string_7 = GetPageSource();
				}
				list = method_23(string_7, string_8);
				if (list.Count <= 0 && int_3 != 0 && Environment.TickCount - tickCount <= int_3 * 1000)
				{
					TimeDelay(1.0);
					string_7 = "";
					if (Environment.TickCount - tickCount >= int_3 * 1000)
					{
						break;
					}
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return list.Distinct().ToList();
	}

	internal void method_27()
	{
		RunCMD("shell media volume --show --stream 0 --set 1");
		RunCMD("shell media volume --show --stream 1 --set 0");
		RunCMD("shell media volume --show --stream 3 --set 0");
		RunCMD("shell media volume --show --stream 4 --set 1");
		RunCMD("shell media volume --show --stream 5 --set 0");
		RunCMD("shell cmd media_session volume --show --stream 0 --set 1");
		RunCMD("shell cmd media_session volume --show --stream 1 --set 0");
		RunCMD("shell cmd media_session volume --show --stream 3 --set 0");
		RunCMD("shell cmd media_session volume --show --stream 4 --set 1");
		RunCMD("shell cmd media_session volume --show --stream 5 --set 0");
	}

	public List<string> method_28(int int_3, string A00A61A2, List<string> list_0)
	{
		return method_29(int_3, ref A00A61A2, list_0);
	}

	public List<string> method_29(int C53A70B1, ref string C1A6F90A, List<string> A43650AB)
	{
		List<string> list = new List<string>();
		try
		{
			int tickCount = Environment.TickCount;
			while (!searchComplete)
			{
				if (C1A6F90A == "")
				{
					C1A6F90A = GetPageSource();
				}
				for (int i = 0; i < A43650AB.Count; i++)
				{
					list.AddRange(FindElements(0, C1A6F90A, A43650AB[i]));
				}
				if (list.Count <= 0 && C53A70B1 != 0)
				{
					TimeDelay(1.0);
					C1A6F90A = "";
					if (Environment.TickCount - tickCount >= C53A70B1 * 1000)
					{
						break;
					}
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return (from string_0 in list
			orderby new Class65(string_0).B9898119, new Class65(string_0).int_0
			select string_0).ToList();
	}

	public bool method_30(int E40D7F04)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (!searchComplete)
			{
				if (ED9CDB24("", "android.widget.ProgressBar", "Row showing that your post is", "Sharing", "Uploading", "Finishing up", "Updating", "Posting"))
				{
					if (Environment.TickCount - tickCount < E40D7F04 * 1000)
					{
						TimeDelay(2.0);
						continue;
					}
					break;
				}
				return true;
			}
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return false;
	}

	internal bool F2BCA293()
	{
		string text = RunCMD("shell ime set com.android.adbkeyboard/.AdbIME");
		if (text == "")
		{
			RunCMD("shell am start -a android.settings.INPUT_METHOD_SETTINGS");
			int tickCount = Environment.TickCount;
			while (!searchComplete)
			{
				string string_ = GetPageSource();
				string text2 = FindElement(0, string_, new List<string> { "//*[@text='ADB Keyboard']/parent::*/parent::*/child::*/child::*[@checked='true']", "//*[@text='ADB Keyboard']", "//android.widget.Button[@text='OK']" });
				switch (text2)
				{
				case "//*[@text='ADB Keyboard']":
				case "//android.widget.Button[@text='OK']":
					TapByXPath(text2, string_);
					break;
				case "//*[@text='ADB Keyboard']/parent::*/parent::*/child::*/child::*[@checked='true']":
					text = RunCMD("shell ime set com.android.adbkeyboard/.AdbIME");
					return true;
				}
				TimeDelay(1.0);
				if (Environment.TickCount - tickCount >= 60000)
				{
					break;
				}
			}
		}
		return false;
	}

	internal void C73BF637()
	{
		RunCMD("reboot");
		RunCMD("wait-for-device", 120);
		while (!RunCMD("shell getprop sys.boot_completed").Equals("1"))
		{
			Common.DelayTime(1.0);
		}
	}

	internal void CE0F9911()
	{
		RunCMD("shell reboot -p");
	}

	public bool method_31(string E1006D1E, int C18DAE8A = 0)
	{
		string text = E48B0A31(E1006D1E, C18DAE8A).FirstOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			return method_32(text);
		}
		return false;
	}

	private bool method_32(string AA9F2FA6)
	{
		try
		{
			string a837B = "/session/{this.sessionId}/element/" + AA9F2FA6 + "/clear";
			string json = method_9(a837B, "");
			return JObject.Parse(json)["status"]!.ToString() == "0";
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	public List<string> E48B0A31(string string_7, int int_3 = 0)
	{
		List<string> list = new List<string>();
		int tickCount = Environment.TickCount;
		while (!searchComplete)
		{
			try
			{
				string a837B = "/session/{this.sessionId}/elements";
				JSON_Settings f72FAFBC = new JSON_Settings();
				f72FAFBC.GetValue("using", (object)"xpath");
				f72FAFBC.GetValue("value", (object)string_7);
				string string_8 = f72FAFBC.C71A4EA4();
				string json = method_9(a837B, string_8);
				JToken jToken = JObject.Parse(json)["value"];
				foreach (JToken item in (IEnumerable<JToken>)jToken)
				{
					list.Add(item["ELEMENT"]!.ToString());
				}
				if (list.Count > 0 || int_3 == 0)
				{
					break;
				}
				TimeDelay(1.0);
				goto IL_00df;
			}
			catch (Exception exception_)
			{
				B6924899(exception_);
				goto IL_00df;
			}
			IL_00df:
			if (Environment.TickCount - tickCount >= int_3 * 1000)
			{
				break;
			}
		}
		return list;
	}

	internal void D332771F(string string_7)
	{
		NoteLog("Uninstall app " + FacebookPacker + "...");
		RunCMD("uninstall \"" + string_7 + "\"", 120);
	}

	public bool SendByXPath(string C19C0E93, string string_7, int F89FA307 = 0, bool bool_2 = false, bool F238009E = true)
	{
		string_7 = Common.SpinText(string_7);
		NoteLog("Send key " + string_7 + "...");
		string text = E48B0A31(C19C0E93, F89FA307).FirstOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			method_32(text);
			if (F238009E)
			{
				method_39(text);
			}
			if (Common.smethod_58(string_7))
			{
				if (bool_2)
				{
					string text2 = string_7;
					foreach (char c in text2)
					{
						RunCMD("shell am broadcast -a ADB_INPUT_B64 --es msg '" + Convert.ToBase64String(Encoding.UTF8.GetBytes(c.ToString())) + "'");
					}
				}
				else
				{
					RunCMD("shell am broadcast -a ADB_INPUT_B64 --es msg '" + Convert.ToBase64String(Encoding.UTF8.GetBytes(string_7)) + "'");
				}
				return true;
			}
			try
			{
				string a837B = "/session/{this.sessionId}/element/" + text + "/value";
				JSON_Settings f72FAFBC = new JSON_Settings();
				f72FAFBC.GetValue("text", (object)string_7);
				string string_8 = f72FAFBC.C71A4EA4();
				string json = method_9(a837B, string_8);
				return JObject.Parse(json)["status"]!.ToString() == "0";
			}
			catch (Exception exception_)
			{
				B6924899(exception_);
			}
		}
		return false;
	}

	public bool D5975B8E(string string_7, string string_8, int int_3 = 0)
	{
		NoteLog("Send key " + string_8 + "...");
		string text = E48B0A31(string_7, int_3).FirstOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			method_32(text);
			method_39(text);
			string_8 = string_8.Replace(" ", "%s").Replace("&", "\\&").Replace("<", "\\<")
				.Replace(">", "\\>")
				.Replace("?", "\\?")
				.Replace(":", "\\:")
				.Replace("{", "\\{")
				.Replace("}", "\\}")
				.Replace("[", "\\[")
				.Replace("]", "\\]")
				.Replace("|", "\\|")
				.Replace("'", "\\'");
			RunCMD("shell input text \"" + string_8 + "\"");
			return true;
		}
		return false;
	}

	internal void method_34()
	{
		RunCMD("shell input keyevent 3");
		RunCMD("shell input keyevent 187");
		for (int i = 0; i < 10; i++)
		{
			RunCMD("shell input touchscreen swipe 700 1000 700 50");
		}
		RunCMD("shell input keyevent 3");
	}

	public string GetPageSource()
	{
		string result = "";
		try
		{
			string string_ = "/session/{this.sessionId}/source";
			string json = method_8(string_);
			result = JObject.Parse(json)["value"]!.ToString();
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return result;
	}

	public bool method_36(System.Drawing.Point point_0, int int_3 = 1, int int_4 = 100)
	{
		return method_37(point_0.X, point_0.Y, int_3, int_4);
	}

	public bool method_37(int C1B3609E, int int_3, int int_4 = 1, int int_5 = 100)
	{
		try
		{
			string a837B = "/session/{this.sessionId}/touch/perform";
			string text = "{ \"actions\": [ { \"action\": \"tap\", \"options\": { \"x\": " + C1B3609E + ", \"y\": " + int_3 + " } },";
			for (int i = 1; i < int_4; i++)
			{
				text = text + "{ \"action\": \"wait\", \"options\": { \"ms\": " + int_5 + " } }, { \"action\": \"tap\", \"options\": { \"x\": " + C1B3609E + ", \"y\": " + int_3 + " } },";
			}
			text += "{ \"action\": \"release\", \"options\": {} } ] }";
			method_9(a837B, text);
			return true;
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	public bool method_38(int B3109E31, int int_3, int B80D2A35 = 1, int E08DEF07 = 100)
	{
		try
		{
			string text = $"shell \"input tap {B3109E31} {int_3}";
			for (int i = 1; i < B80D2A35; i++)
			{
				text += $" && sleep {(double)E08DEF07 * 1.0 / 1000.0} && ";
				text += $"input tap {B3109E31} {int_3}";
			}
			text += "\"";
			RunCMD(text);
			return true;
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	private bool method_39(string string_7, int int_3 = 1, int int_4 = 100)
	{
		string a837B = "/session/{this.sessionId}/touch/perform";
		string text = "{ \"actions\": [ { \"action\": \"tap\", \"options\": { \"element\": \"" + string_7 + "\"} },";
		for (int i = 1; i < int_3; i++)
		{
			text = text + "{ \"action\": \"wait\", \"options\": { \"ms\": " + int_4 + " } }, { \"action\": \"tap\", \"options\": { \"element\": \"" + string_7 + "\"} },";
		}
		text += "{ \"action\": \"release\", \"options\": {} } ] }";
		method_9(a837B, text);
		return true;
	}

	public bool E80B893F(string F313B8B8, int D7925A97 = 0, int int_3 = 1, int D836AEA2 = 100)
	{
		NoteLog("Tap " + F313B8B8 + "...");
		string text = E48B0A31(F313B8B8, D7925A97).FirstOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			return method_39(text, int_3, D836AEA2);
		}
		return false;
	}

	internal void E0A70A3E()
	{
		if (!method_113())
		{
			RunCMD("shell input keyevent 26");
		}
	}

	public bool TapByXPath(string A28409BD, string string_7 = "", int int_3 = 1, int BF1E24B3 = 100)
	{
		NoteLog("Tap " + A28409BD + "...");
		return method_40(0, A28409BD, string_7, int_3, BF1E24B3);
	}

	public bool method_40(int A824B925, string string_7, string AD9ACFB5, int int_3 = 1, int int_4 = 100)
	{
		NoteLog("Tap " + string_7 + "...");
		string text = FindElements(A824B925, AD9ACFB5, string_7).FirstOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			return E832B991(text, int_3, int_4);
		}
		return false;
	}

	public bool method_41(string string_7, string A49F5A3E = "", int int_3 = 1, int int_4 = 100)
	{
		NoteLog("Tap " + string_7 + "...");
		return method_42(0, string_7, A49F5A3E, int_3, int_4);
	}

	public bool method_42(int int_3, string string_7, string string_8, int int_4 = 1, int C38538B3 = 100)
	{
		NoteLog("Tap " + string_7 + "...");
		string text = FindElements(int_3, string_8, string_7).FirstOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			return method_36(new Class65(text).method_0());
		}
		return false;
	}

	public bool method_43(string F8A44A09, int int_3, params string[] B9029F31)
	{
		string a28409BD = CB3C4B8A(int_3, ref F8A44A09, B9029F31.ToList());
		return TapByXPath(a28409BD, F8A44A09);
	}

	public bool method_44(int CD931E21, string string_7, string string_8, int E534EAB5 = 1, int int_3 = 100)
	{
		NoteLog("Tap " + string_7 + "...");
		string text = EB158100(CD931E21, string_8, string_7).LastOrDefault();
		if (!string.IsNullOrEmpty(text))
		{
			return E832B991(text, E534EAB5, int_3);
		}
		return false;
	}

	public bool E832B991(string string_7, int ECB700AF = 1, int int_3 = 100)
	{
		try
		{
			System.Drawing.Point point = method_51(string_7);
			int x = point.X;
			int y = point.Y;
			return method_37(x, y, ECB700AF, int_3);
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	public bool method_45(string string_7, string string_8, int int_3 = 1, int int_4 = 100)
	{
		try
		{
			string text = FindElements(0, string_8, string_7).FirstOrDefault();
			if (!string.IsNullOrEmpty(text))
			{
				return method_46(text, int_3, int_4);
			}
			return false;
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	public bool method_46(string string_7, int int_3 = 1, int int_4 = 100)
	{
		try
		{
			System.Drawing.Point point = method_51(string_7);
			int x = point.X;
			int y = point.Y;
			return method_38(x, y, int_3, int_4);
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	internal void method_47()
	{
		if (method_113())
		{
			RunCMD("shell input keyevent 26");
			TimeDelay(1.0);
		}
		RunCMD("shell input keyevent 82");
	}

	internal bool method_48(string C19E3D8F)
	{
		method_96(new List<string> { C19E3D8F });
		RunCMD("shell am start -a android.settings.DISPLAY_SETTINGS");
		TimeDelay(2.0);
		bool flag = false;
		int tickCount = Environment.TickCount;
		while (!searchComplete)
		{
			string text = GetPageSource();
			string text2 = FindElement(0, text, new List<string> { "//*[contains(@text,'Styles & wallpapers')]", "//*[contains(@text,'Wallpaper, ')]", "//*[@text='Wallpaper']", "//*[@text='set wallpaper']", "//*[@text='Gallery']", "//*[@content-desc='Show roots']", "//*[@text='Select item']" });
			string text3 = text2;
			string text4 = text3;
			uint num = HashString.DA8CEBAB(text4);
			if (num <= 1313485990)
			{
				if (num != 779380289)
				{
					if (num != 1309555867)
					{
						if (num == 1313485990 && text4 == "//*[contains(@text,'Wallpaper, ')]")
						{
							goto IL_0150;
						}
					}
					else if (text4 == "//*[@text='Wallpaper']")
					{
						if (DoesElementExist(0, text, "//*[@text='Wallpaper categories']/following-sibling::*"))
						{
							TapByXPath("//*[@text='Wallpaper categories']/following-sibling::*", text);
						}
						else
						{
							E832B991(FindElements(0, text, text2).LastOrDefault());
						}
					}
				}
				else if (text4 == "//*[contains(@text,'Styles & wallpapers')]")
				{
					goto IL_0150;
				}
			}
			else if (num <= 1627569214)
			{
				switch (num)
				{
				case 1627569214u:
					if (text4 == "//*[@text='Select item']")
					{
						method_37(370, 605);
					}
					break;
				case 1593376715u:
					if (text4 == "//*[@text='set wallpaper']")
					{
						if (DoesElementExist(0, text, "//*[@text='Home screen and lock screen']"))
						{
							TapByXPath("//*[@text='Home screen and lock screen']", text);
							TimeDelay(2.0);
							B2016D94(DB353F82.const_3);
							return true;
						}
						flag = DoesElementExist(0, text, "//android.widget.CheckBox[@text='Preview']");
						method_41(text2, text);
						if (!flag)
						{
							TimeDelay(2.0);
							B2016D94(DB353F82.const_3);
							return true;
						}
					}
					break;
				}
			}
			else if (num != 3107109781u)
			{
				if (num == 3959138999u && text4 == "//*[@text='Gallery']")
				{
					goto IL_027c;
				}
			}
			else if (text4 == "//*[@content-desc='Show roots']")
			{
				goto IL_027c;
			}
			goto IL_02b6;
			IL_027c:
			if (DoesElementExist(0, text, "//android.widget.LinearLayout/android.widget.RelativeLayout"))
			{
				TapByXPath("//android.widget.LinearLayout/android.widget.RelativeLayout", text);
			}
			else if (text2 == "//*[@text='Gallery']")
			{
				TapByXPath(text2, text);
			}
			goto IL_02b6;
			IL_0150:
			if (DoesElementExist(0, text, "//*[@text='Allow']"))
			{
				TapByXPath("//*[@text='Allow']", text);
			}
			else if (DoesElementExist(0, text, "//*[@text='Allow access']"))
			{
				method_41("//*[@text='Allow access']", text);
			}
			else
			{
				E832B991(FindElements(0, text, text2).LastOrDefault());
			}
			goto IL_02b6;
			IL_02b6:
			TimeDelay(1.0);
			if (Environment.TickCount - tickCount >= 60000)
			{
				break;
			}
		}
		return false;
	}

	internal void AE85CB30()
	{
		bool flag = method_113();
		RunCMD("shell \"input keyevent 26\"");
		if (!flag)
		{
			TimeDelay(1.0);
			RunCMD("shell \"input keyevent 26\"");
		}
	}

	public bool method_49(int int_3, int int_4, int int_5 = 500)
	{
		try
		{
			string a837B = "/session/{this.sessionId}/touch/perform";
			string string_ = "{ \"actions\": [ { \"action\": \"press\", \"options\": { \"x\": " + int_3 + ", \"y\": " + int_4 + " } }, { \"action\": \"wait\", \"options\": { \"ms\": " + int_5 + " } }, { \"action\": \"release\", \"options\": {} } ] }";
			method_9(a837B, string_);
			return true;
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	public bool method_50(int int_3, int E52A41B7, int D985B285, int int_4, int int_5 = 500)
	{
		try
		{
			string a837B = "/session/{this.sessionId}/touch/perform";
			string text = "{ \"actions\": [ ";
			text = text + "{ \"action\": \"press\", \"options\": { \"x\": " + int_3 + ", \"y\": " + E52A41B7 + " } },";
			text = text + "{ \"action\": \"wait\", \"options\": { \"ms\": " + int_5 + " } },";
			text = text + "{ \"action\": \"moveTo\", \"options\": { \"x\": " + D985B285 + ", \"y\": " + int_4 + " } },";
			text += "{ \"action\": \"release\", \"options\": {} } ] }";
			method_9(a837B, text);
			return true;
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	public System.Drawing.Point method_51(string F8393D2C)
	{
		try
		{
			string[] array = F8393D2C.Split('[', ',', ']');
            int x = F639F68B.Next(Convert.ToInt32(array[1]), Convert.ToInt32(array[4]));
			int y = F639F68B.Next(Convert.ToInt32(array[2]), Convert.ToInt32(array[5]));
			return new System.Drawing.Point(x, y);
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return default(System.Drawing.Point);
	}

	public bool method_52(string B91DA580, string string_7, int int_3 = 500)
	{
		System.Drawing.Point point = method_51(B91DA580);
		int x = point.X;
		int y = point.Y;
		System.Drawing.Point point2 = method_51(string_7);
		int x2 = point2.X;
		int y2 = point2.Y;
		return method_50(x, y, x2, y2, int_3);
	}

	public bool FB3ACF2E(int int_3 = 1, int int_4 = 1, int F903D50C = 0)
	{
		int num = method_13();
		int num2 = method_14();
		string text = $"[{num2 / 4},{num / 4}][{num2 / 4 * 3},{num / 4 + 50}]";
		string text2 = $"[{num2 / 4},{num / 4 * 3}][{num2 / 4 * 3},{num / 4 * 3 + 50}]";
		if (F903D50C == 0)
		{
			F903D50C = F639F68B.Next(2000000, 2560000) / num;
		}
		for (int i = 0; i < int_4; i++)
		{
			if (int_3 == 1)
			{
				method_52(text2, text, F903D50C);
			}
			else
			{
				method_52(text, text2, F903D50C);
			}
		}
		return true;
	}

	public bool method_53(string string_7, string A92A88A3, int BFAC5B04 = 500, int int_3 = 1, int int_4 = 1)
	{
		string text = GetPageSource();
		for (int i = 0; i < int_4; i++)
		{
			if (int_3 == 1)
			{
				method_52(string_7, A92A88A3, BFAC5B04);
			}
			else
			{
				method_52(A92A88A3, string_7, BFAC5B04);
			}
		}
		TimeDelay(1.0);
		return GetPageSource() == text;
	}

	public bool CE16082B(int F5B01D99 = 1, int int_3 = 1, int E71E7E3D = 0)
	{
		NoteLog("Scroll...");
		int num = method_13();
		int num2 = method_14();
		string a92A88A = $"[{num2 / 4},{num / 4}][{num2 / 4 * 3},{num / 4 + 50}]";
		string string_ = $"[{num2 / 4},{num / 4 * 3}][{num2 / 4 * 3},{num / 4 * 3 + 50}]";
		if (F5B01D99 == 2)
		{
			string_ = $"[{num2 / 4},{num / 4 * 2}][{num2 / 4 * 2},{num / 4 * 2 + 50}]";
			F5B01D99 = 1;
		}
		if (E71E7E3D == 0)
		{
			E71E7E3D = F639F68B.Next(2000000, 2560000) / num;
		}
		return method_53(string_, a92A88A, E71E7E3D, F5B01D99, int_3);
	}

	public bool B2016D94(DB353F82 db353F82_0)
	{
		try
		{
			string a837B = "/session/{this.sessionId}/appium/device/press_keycode";
			JSON_Settings f72FAFBC = new JSON_Settings();
			f72FAFBC.GetValue("keycode", (int)db353F82_0);
			string string_ = f72FAFBC.C71A4EA4();
			method_9(a837B, string_);
			return true;
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
	}

	public void method_54(double double_0, double double_1)
	{
		NoteLog("Delay...");
		Thread.Sleep(F639F68B.Next(Convert.ToInt32(double_0 * 1000.0), Convert.ToInt32(double_1 * 1000.0 + 1.0)));
		Application.DoEvents();
	}

	public void TimeDelay(double double_0)
	{
		Thread.Sleep(Convert.ToInt32(double_0 * 1000.0));
		Application.DoEvents();
	}

	private bool B6924899(Exception exception_0)
	{
		return false;
	}

	internal bool method_56()
	{
		RunCMD("shell am force-stop ru.andr7e.deviceinfohw");
		if (ChangeDeviceInfo())
		{
			RunCMD("shell monkey -p ru.andr7e.deviceinfohw -c android.intent.category.LAUNCHER 1");
			return true;
		}
		return false;
	}

	public void method_57()
	{
		RunCMD("shell pm grant " + FacebookPacker + " android.permission.READ_CONTACTS");
		RunCMD("shell pm grant " + FacebookPacker + " android.permission.READ_EXTERNAL_STORAGE");
		RunCMD("shell pm grant " + FacebookPacker + " android.permission.WRITE_EXTERNAL_STORAGE");
	}

	public int method_58(string string_7, int FE90DCB0 = 10)
	{
		NoteLog("Open app " + FacebookPacker + "...");
		int num = 0;
		int tickCount = Environment.TickCount;
		while (!searchComplete)
		{
			num++;
			switch (B0B3EE2F(string_7))
			{
			case 4:
				if (num == 1)
				{
					return 2;
				}
				return 1;
			case 0:
				return 0;
			}
			method_57();
			method_16(string_7);
			RunCMD("shell content insert --uri content://settings/system --bind name:s:accelerometer_rotation --bind value:i:0");
			TimeDelay(1.0);
			if (Environment.TickCount - tickCount >= FE90DCB0 * 1000)
			{
				break;
			}
		}
		return 0;
	}

	public bool method_59(string B13BB587, double C736F308 = 10.0)
	{
		try
		{
			NoteLog("Close app " + FacebookPacker + "...");
			RunCMD("shell am force-stop " + B13BB587);
		}
		catch (Exception exception_)
		{
			return B6924899(exception_);
		}
		return false;
	}

	public int C4B7B817(int F988D70A, int E234B221)
	{
		return F639F68B.Next(F988D70A, E234B221 + 1);
	}

	private string GetDeviceNameFake(int EC9D5A13 = 0)
	{
        NoteLog("Get device name fake....");
        int tickCount = Environment.TickCount;
        do
        {
            string text = RunCMD("shell su -c \"cat /data/data/com.minsoftware.maxchanger/shared_prefs/Device.xml");
            if (text != "")
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(text);
                    XmlNode xmlNode = xmlDocument.SelectSingleNode("//*[@name='fingerprint']");
                    XmlNode xmlNode2 = xmlDocument.SelectSingleNode("//*[@name='time_check']");
                    if (xmlNode != null && xmlNode.InnerText != "" && xmlNode2 != null && xmlNode2.InnerText != "")
                    {
                        NameFake = xmlNode.InnerText + xmlNode2.InnerText;
                        return NameFake;
                    }
                }
                catch (Exception)
                {
                }
            }
            if (EC9D5A13 == 0)
            {
                break;
            }
            TimeDelay(2.0);
        }
        while (Environment.TickCount - tickCount < EC9D5A13 * 1000);
        return "";
    }

	public bool ChangeDeviceInfo()
	{
        RunCMD("shell pm grant com.minsoftware.maxchanger android.permission.READ_EXTERNAL_STORAGE");
        RunCMD("shell pm grant com.minsoftware.maxchanger android.permission.WRITE_EXTERNAL_STORAGE");
        string text = GetDeviceNameFake();
        NoteLog("Get device name fake old => " + text);
        int tickCount = Environment.TickCount;
        bool flag = false;
        if (bool_1)
        {
            flag = true;
            GetDeviceNameFake();
        }
        int num = 1;
        do
        {
            if (num > 1 && !flag)
            {
                flag = true;
                GetDeviceNameFake();
            }
            string text2 = "shell am broadcast -a com.minsoftware.maxchanger.CHANGE -n com.minsoftware.maxchanger/.AdbCaller";
            string text3 = SettingsTool.GetSettings("configGeneral").GetValue("txtBrandDevice", "Random");
            if (text3 != "Random")
            {
                string text4 = (from string_0 in text3.Split('|').ToList()
                                orderby Guid.NewGuid()
                                select string_0).Last();
                text2 = "shell am broadcast -a com.minsoftware.maxchanger.CHANGE --es \"brand\" \"" + text4 + "\" -n com.minsoftware.maxchanger/.AdbCaller";
            }
            NoteLog($"{num}. Run cmd: adb {text2}...");
            bool flag2 = RunCMD(text2, 120).Contains("Broadcast completed");
            NoteLog($"{num}. Run cmd => " + flag2);
            if (flag2)
            {
                TimeDelay(2.0);
                string text5 = GetDeviceNameFake(10);
                NoteLog($"{num}. Get device name fake new => " + text5);
                if (text5 != "" && text5 != text)
                {
                    return true;
                }
            }
            num++;
        }
        while (Environment.TickCount - tickCount < 300000);
        return false;
    }

	internal bool ChangerTuongTac(string uid)
	{
		NoteLog("Change info...");
		bool flag = false;
		if (RestoreAppMaxChange(uid))
		{
			string text = GetDeviceNameFake(10);
			flag = text != "";
		}
		if (!flag && (flag = ChangeDeviceInfo()))
		{
			BackupAppMaxChange(uid);
		}
		return flag;
	}

	internal bool RestoreAppMaxChange(string uid)
	{
        if (uid != "")
        {
            //ClearDataApp("com.minsoftware.maxchanger");
            RunCMD("shell pm grant com.minsoftware.maxchanger android.permission.READ_EXTERNAL_STORAGE");
            RunCMD("shell pm grant com.minsoftware.maxchanger android.permission.WRITE_EXTERNAL_STORAGE");
            string text = Path.GetDirectoryName(Application.ExecutablePath) + "\\device\\" + uid + ".tar.gz";
            if (File.Exists(text))
            {
                bool flag = false;
                for (int i = 0; i < 10; i++)
                {
                    string text2 = RunCMD("push \"" + text + "\" /sdcard");
                    text2 = RunCMD("shell su -c cp /sdcard/" + uid + ".tar.gz /data/data/com.minsoftware.maxchanger/" + uid + ".tar.gz");
                    text2 = RunCMD("shell su -c tar -xzvf /data/data/com.minsoftware.maxchanger/" + uid + ".tar.gz");
                    text2 = RunCMD("shell su -c \"ls -l /data/data | grep com.minsoftware.maxchanger | awk '{print $3\\\":\\\"$4}'\"");
                    flag = text2 != "";
                    text2 = RunCMD("shell su -c chown -R " + text2 + " /data/data/com.minsoftware.maxchanger");
                    if (!flag)
                    {
                        TimeDelay(2.0);
                        continue;
                    }
                    return true;
                }
            }
        }
        return false;
    }
    /*public void TimeDelay(double E9A4FCB1)
    {
        Thread.Sleep(Convert.ToInt32(E9A4FCB1 * 1000.0));
        Application.DoEvents();
    }*/

    public static DateTime DatimeParseExact(string string_1, string AB0FF028 = "dd/MM/yyyy HH:mm:ss")
    {
        try
        {
            if (string_1.Trim() != "")
            {
                return DateTime.ParseExact(string_1, AB0FF028, CultureInfo.InvariantCulture);
            }
        }
        catch (Exception)
        {
        }
        return DateTime.MinValue;
    }

    internal bool BackupAppMaxChange(string uid)
	{
        if (uid != "")
        {
            string text = Path.GetDirectoryName(Application.ExecutablePath) + "\\device\\" + uid + ".tar.gz";
            if (File.Exists(text))
            {
                DatimeParseExact(text);
            }
            // ClearDataApp("com.minsoftware.maxchanger");
            for (int i = 0; i < 10; i++)
            {
                if (searchComplete)
                {
                    break;
                }
                RunCMD("shell su -c tar -czvf /data/data/com.minsoftware.maxchanger/device.tar.gz /data/data/com.minsoftware.maxchanger/shared_prefs/*");
                RunCMD("shell su -c cp /data/data/com.minsoftware.maxchanger/device.tar.gz /sdcard/device.tar.gz");
                RunCMD("pull /sdcard/device.tar.gz \"" + text + "\"");
                RunCMD("shell su -c rm -rf /data/data/com.minsoftware.maxchanger/*.tar.gz");
                RunCMD("shell su -c rm -rf /sdcard/*.tar.gz");
                if (!File.Exists(text))
                {
                    TimeDelay(3.0);
                    continue;
                }
                return true;
            }
        }
        return false;
    }

	internal bool RestoreAppFb(string uid)
	{
        NoteLog("Restore data Fb...");
        ClearDataApp(FacebookPacker);
        if (string.IsNullOrEmpty(uid))
        {
            return false;
        }
        string text = Path.GetDirectoryName(Application.ExecutablePath) + "\\profile\\" + uid + ".tar.gz";
        if (File.Exists(text))
        {
            bool flag = false;
            for (int i = 0; i < 10; i++)
            {
                string text2 = RunCMD("push \"" + text + "\" /sdcard");
                text2 = RunCMD("shell su -c cp /sdcard/" + uid + ".tar.gz /data/data/" + FacebookPacker + "/" + uid + ".tar.gz");
                text2 = RunCMD("shell su -c tar -xpf /data/data/" + FacebookPacker + "/" + uid + ".tar.gz");
                text2 = RunCMD("shell su -c \"ls -l /data/data | grep " + FacebookPacker + " | awk '{print $3\\\":\\\"$4}'\"");
                flag = text2 != "";
                text2 = RunCMD("shell su -c chown -R " + text2 + " /data/data/" + FacebookPacker);
                if (!flag)
                {
                    TimeDelay(2.0);
                    continue;
                }
                return true;
            }
        }
        return false;
    }

	internal bool BackupAppFb(string uid, string F29C9F27 = "")
	{
        if (uid != "")
        {
            NoteLog("Backup data Fb...");
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\profile\\" + uid + ".txt";
            if (File.Exists(path))
            {
                Common.F11F4A37(path);
            }
            string text = method_0();
            if (text != "")
            {
                File.AppendAllText(path, text);
            }
            path = Path.GetDirectoryName(Application.ExecutablePath) + "\\profile\\" + uid + ".tar.gz";
            if (File.Exists(path))
            {
                Common.F11F4A37(path);
            }
            for (int i = 0; i < 10; i++)
            {
                if (searchComplete)
                {
                    break;
                }
                RunCMD("shell su -c tar -czvpf /data/data/" + FacebookPacker + "/backup.tar.gz /data/data/" + FacebookPacker + "/databases /data/data/" + FacebookPacker + "/app_light_prefs /data/data/" + FacebookPacker + "/shared_prefs /data/data/" + FacebookPacker + "/files/mobileconfig");
                RunCMD("shell su -c cp /data/data/" + FacebookPacker + "/backup.tar.gz /sdcard/backup.tar.gz");
                RunCMD("pull /sdcard/backup.tar.gz \"" + path + "\"");
                RunCMD("shell su -c rm -rf /data/data/" + FacebookPacker + "/*.tar.gz");
                RunCMD("shell su -c rm -rf /sdcard/*.tar.gz");
                if (!File.Exists(path))
                {
                    TimeDelay(3.0);
                    continue;
                }
                return true;
            }
        }
        return false;
    }

	public string RunCMD(string BA32E58D, int int_3 = 10)
	{
		string text;
		string F8B79789;
		string string_0;
		while (true)
		{
			if (!searchComplete)
			{
				int num = 0;
				int num2 = 3;
				text = "";
				try
				{
					string text2 = "adb -s " + String_1 + " " + BA32E58D;
					Process process = new Process();
					process.StartInfo.FileName = "cmd.exe";
					process.StartInfo.Arguments = "/c " + Environment.GetEnvironmentVariable("ANDROID_HOME", EnvironmentVariableTarget.Machine) + "\\platform-tools\\" + text2;
					process.StartInfo.Verb = "runas";
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.RedirectStandardError = true;
					process.StartInfo.RedirectStandardOutput = true;
					process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
					process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
					F8B79789 = "";
					process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
					{
						if (!string.IsNullOrEmpty(e.Data))
						{
							F8B79789 = F8B79789 + e.Data + "\n";
						}
					};
					F8B79789 = F8B79789.Trim();
					string_0 = "";
					process.ErrorDataReceived += delegate(object sender, DataReceivedEventArgs e)
					{
						if (!string.IsNullOrEmpty(e.Data))
						{
							string_0 = string_0 + e.Data + "\n";
						}
					};
					string_0 = string_0.Trim();
					process.Start();
					process.BeginOutputReadLine();
					process.BeginErrorReadLine();
					bool flag = !process.WaitForExit((int_3 < 0) ? (-1) : (int_3 * 1000));
					process.Close();
					if (flag)
					{
						if (num > 0 && num % num2 == 0)
						{
							GClass1.smethod_2();
						}
						num++;
						continue;
					}
					text = F8B79789;
					if (!(string_0 != ""))
					{
						break;
					}
					if (string_0.Contains("/system/bin/sh: curl: not found"))
					{
						return "curl_not_found";
					}
					if (string_0.Contains("daemon not running") && !string_0.Contains("daemon started successfully"))
					{
						continue;
					}
					if (Regex.Match(string_0, "device (.*?) not found").Groups[1].Value != "" || string_0.Contains("device offline"))
					{
						if (DB3DB1A4())
						{
							continue;
						}
						return "disconnect";
					}
					if (!string_0.Contains("inaccessible or not found"))
					{
						lock (Class64.object_0)
						{
							File.AppendAllText("device.txt", "Run ADB error:" + Environment.NewLine);
							File.AppendAllText("device.txt", string_0 + Environment.NewLine);
							File.AppendAllText("device.txt", "-----------------------------" + Environment.NewLine);
						}
					}
					if (text == "")
					{
						text = string_0;
					}
					break;
				}
				catch
				{
					break;
				}
			}
			return "disconnect";
		}
		return text;
	}

	internal void ClearDataApp(string string_7)
	{
		NoteLog("Clear data " + string_7 + "...");
		RunCMD("shell pm clear " + string_7);
	}

	internal int AB03C014(string string_7, string string_8, string D99379A2, string string_9, int int_3 = 0, int int_4 = 0, int DD8FF534 = 300)
	{
		int tickCount = Environment.TickCount;
		if (int_4 != 2 && RestoreAppFb(string_7))
		{
			string text = AF03B30E();
			string input = text.Split('|')[1];
			string value = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
			if (string_7 != value && Common.E001543D(string_7) && Common.E001543D(value))
			{
				ClearDataApp(FacebookPacker);
				string b41F7EA = FileHelper.GetPathToCurrentFolder() + "\\profile\\" + string_7 + ".tar.gz";
				Common.smethod_49(b41F7EA);
			}
		}
		method_58(FacebookPacker);
		string text2 = "";
		int num = 0;
		int num2 = 2;
		int num3 = 0;
		int num4 = 1;
		int num5 = 0;
		int num6 = 1;
		int num7 = 0;
		int num8 = 1;
		int num9 = 0;
		int num10 = ((int_3 != 15) ? (-1) : 0);
		int num11 = 0;
		int num12 = 3;
		int num13 = 0;
		int num14 = 1;
		int num15 = 0;
		int num16 = 5;
		NoteLog("Login Fb " + string_7 + "...");
		while (true)
		{
			string text3;
			if (!searchComplete)
			{
				text3 = GetPageSource();
				text2 = FindElement(0, text3, new List<string>
				{
					"//android.widget.ProgressBar", "//*[@text='NONE OF THE ABOVE']", "//*[@text='Session Expired']", "//android.widget.Button[@content-desc='Menu']", "//android.widget.EditText[@content-desc='Username']", "//*[@text='Mobile number or email']/parent::*/parent::*//android.widget.EditText", "//android.widget.EditText[@text='Password']", "//*[@text='Password']/parent::*/parent::*//android.widget.EditText", "//*[@package='com.google.android.gms']", "//android.widget.TextView[@text=\"Can't Find Account\"]",
					"//android.widget.TextView[@text='Incorrect Password']", "//android.widget.TextView[@text='Invalid username or password']", "//android.widget.TextView[@text='You Entered an Older Password']", "//android.widget.TextView[@text='Login Code Required']", "//android.widget.EditText[@text='login code']", "//*[@text='Go to your authentication app']", "//android.widget.TextView[@text='Authentication Error']", "//*[@text='save your login info']", "//*[@content-desc='skip' or @text='skip']", "//*[@content-desc='deny' or @text='deny']",
					"//android.view.ViewGroup[@content-desc=\"Continue in English (US)\"]", "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]", "//android.view.ViewGroup[@content-desc=\"Allow\"]", "//com.android.packageinstaller:id/do_not_ask_checkbox", "//android.widget.Button[@text=\"NEVER\"]", "//android.widget.TextView[@text=\"Find your account\"]", "//android.widget.Button[@text='FIND ACCOUNT']", "//*[@text ='LOG IN' or @content-desc='Log In']", "//android.widget.TextView[@text='Find Friends']", "//*[@text='Enter the code from your email']",
					"//*[@text='Enter the code from your SMS']", "//*[@text='Confirm by phone number']", "//android.widget.Button[@text='Confirm']", "//*[@content-desc='Send login code']", "//android.widget.Button[@text='TRY AGAIN']", "//android.widget.EditText[@text='Enter code']", "//*[@text='No thanks']", "//android.view.ViewGroup[@content-desc='Use login code instead']", "//*[@content-desc='I ACCEPT']", "//*[@content-desc='Allow all cookies']",
					"//*[@text=\"You can't log in right now\"]", "//*[@text=\"You Can't Use This Feature Right Now\"]", "//*[@text='An unexpected error occurred. Please try logging in again.']", "//*[@text='Facebook will be back soon']", "//*[@text='Login Failed']", "(//android.widget.EditText)[7]", "//*[@text='Connection lost']", "//*[@text='Trouble Loading']", "//*[@content-desc='Yes, continue']", "//*[@text='Enter password to log in']",
					"//android.view.ViewGroup[@content-desc='•']", "//*[@text='Take photo']", "//*[@text='Not now' or @content-desc='Not now']", "//android.widget.Button[@text='GET STARTED']", "//android.widget.Button[@content-desc='Log into another account']", "//*[@content-desc='Next']", "//*[@content-desc='Done']", "//android.widget.Button[@text='Enable Two-Factor Authentication']", "//*[@text='Check your notifications on another device']", "//*[@text='Choose a way to confirm it’s you']",
					"//*[@content-desc='Continue']"
				});
				string text4 = text2;
				string text5 = text4;
				uint num17 = HashString.DA8CEBAB(text5);
				if (num17 <= 1526972647)
				{
					if (num17 <= 532719482)
					{
						if (num17 <= 241868935)
						{
							if (num17 <= 51955880)
							{
								if (num17 != 14426572)
								{
									if (num17 != 38614762)
									{
										if (num17 == 51955880 && text5 == "//*[@text='Not now' or @content-desc='Not now']")
										{
											goto IL_103b;
										}
									}
									else if (text5 == "//android.view.ViewGroup[@content-desc=\"Allow\"]")
									{
										goto IL_103b;
									}
								}
								else if (text5 == "//*[@content-desc='deny' or @text='deny']")
								{
									TapByXPath(text2, text3);
									goto IL_13af;
								}
							}
							else if (num17 <= 181913694)
							{
								if (num17 != 62961010)
								{
									if (num17 == 181913694 && text5 == "//*[@text='Enter the code from your email']")
									{
										goto IL_1421;
									}
								}
								else if (text5 == "//android.widget.Button[@text='Confirm']")
								{
									goto IL_103b;
								}
							}
							else if (num17 != 199939915)
							{
								if (num17 == 241868935 && text5 == "//*[@text='Choose a way to confirm it’s you']")
								{
									if (TapByXPath("//*[@text='Authentication app']", text3))
									{
										TapByXPath("//android.widget.Button[@content-desc='Continue']", text3);
										goto IL_13af;
									}
									return 2;
								}
							}
							else if (text5 == "//android.widget.EditText[@text='login code']")
							{
								goto IL_0d60;
							}
						}
						else if (num17 <= 385932458)
						{
							if (num17 <= 300361078)
							{
								if (num17 != 288814156)
								{
									if (num17 == 300361078 && text5 == "//*[@content-desc='Allow all cookies']")
									{
										goto IL_103b;
									}
								}
								else if (text5 == "//*[@text='NONE OF THE ABOVE']")
								{
									goto IL_103b;
								}
							}
							else if (num17 != 355810260)
							{
								if (num17 == 385932458 && text5 == "//android.widget.EditText[@text='Enter code']")
								{
									goto IL_1403;
								}
							}
							else if (text5 == "//android.widget.Button[@content-desc='Log into another account']")
							{
								goto IL_103b;
							}
						}
						else if (num17 <= 454760892)
						{
							if (num17 != 440181498)
							{
								if (num17 == 454760892 && text5 == "//android.widget.Button[@text=\"NEVER\"]")
								{
									goto IL_103b;
								}
							}
							else if (text5 == "//*[@text=\"You Can't Use This Feature Right Now\"]")
							{
								goto IL_105e;
							}
						}
						else if (num17 != 498126038)
						{
							if (num17 == 532719482 && text5 == "//android.widget.ProgressBar")
							{
								num9++;
								if (num9 % 5 == 0)
								{
									if (AF365B16(text3))
									{
										return 1;
									}
									TapByXPath("//*[@content-desc='skip' or @text='skip']", text3);
								}
								goto IL_13af;
							}
						}
						else if (text5 == "//android.widget.TextView[@text='You Entered an Older Password']")
						{
							break;
						}
					}
					else if (num17 <= 1094531760)
					{
						if (num17 <= 728177876)
						{
							if (num17 != 588426016)
							{
								if (num17 != 601041107)
								{
									if (num17 == 728177876 && text5 == "//com.android.packageinstaller:id/do_not_ask_checkbox")
									{
										goto IL_103b;
									}
								}
								else if (text5 == "//android.widget.Button[@content-desc='Menu']")
								{
									TapByXPath("//android.widget.TextView", text3);
									goto IL_13af;
								}
							}
							else if (text5 == "//*[@text='Check your notifications on another device']")
							{
								if (!TapByXPath("//android.widget.Button[@content-desc='Try another way']", text3))
								{
									return 2;
								}
								goto IL_13af;
							}
						}
						else if (num17 <= 1029426508)
						{
							if (num17 != 827023039)
							{
								if (num17 == 1029426508 && text5 == "//*[@text='Session Expired']")
								{
									if (num11 >= num12)
									{
										ClearDataApp(FacebookPacker);
										method_58(FacebookPacker);
										num11 = 0;
									}
									else
									{
										num11++;
										TapByXPath("//android.widget.Button[@text='OK']", text3);
									}
									goto IL_13af;
								}
							}
							else if (text5 == "//*[@text='Connection lost']")
							{
								goto IL_0e11;
							}
						}
						else if (num17 != 1080039791)
						{
							if (num17 == 1094531760 && text5 == "//*[@text='save your login info']")
							{
								goto IL_0b89;
							}
						}
						else if (text5 == "//android.widget.Button[@text='TRY AGAIN']")
						{
							if (num3 < num4)
							{
								TapByXPath(text2, text3);
								TimeDelay(1.0);
								num3++;
								goto IL_13af;
							}
							return 5;
						}
					}
					else if (num17 <= 1378667548)
					{
						if (num17 <= 1236015078)
						{
							if (num17 != 1156007901)
							{
								if (num17 == 1236015078 && text5 == "//android.widget.TextView[@text='Authentication Error']")
								{
									num++;
									if (num < num2)
									{
										TapByXPath("//android.widget.Button[@text ='OK']", text3);
										goto IL_13af;
									}
									return 6;
								}
							}
							else if (text5 == "//*[@content-desc='Yes, continue']")
							{
								goto IL_103b;
							}
						}
						else if (num17 != 1290144582)
						{
							if (num17 == 1378667548 && text5 == "//android.view.ViewGroup[@content-desc=\"Continue in English (US)\"]")
							{
								goto IL_103b;
							}
						}
						else if (text5 == "//*[@text ='LOG IN' or @content-desc='Log In']")
						{
							if (DoesElementExist(0, text3, "//android.widget.Button[@content-desc='Log into another account']"))
							{
								text2 = "//android.widget.Button[@content-desc='Log into another account']";
							}
							TapByXPath(text2, text3);
							goto IL_13af;
						}
					}
					else if (num17 <= 1454989584)
					{
						if (num17 != 1451300114)
						{
							if (num17 == 1454989584 && text5 == "//*[@text='Password']/parent::*/parent::*//android.widget.EditText")
							{
								goto IL_0cf8;
							}
						}
						else if (text5 == "//android.widget.Button[@text='FIND ACCOUNT']")
						{
							goto IL_0f41;
						}
					}
					else if (num17 != 1514243556)
					{
						if (num17 == 1526972647 && text5 == "//android.widget.Button[@text='Enable Two-Factor Authentication']")
						{
							return 2;
						}
					}
					else if (text5 == "//*[@text=\"You can't log in right now\"]")
					{
						goto IL_105e;
					}
				}
				else if (num17 <= 2698810085u)
				{
					if (num17 <= 1997336986)
					{
						if (num17 <= 1734832791)
						{
							if (num17 != 1580217180)
							{
								if (num17 != 1684149593)
								{
									if (num17 == 1734832791 && text5 == "//*[@content-desc='Send login code']")
									{
										goto IL_1403;
									}
								}
								else if (text5 == "//android.view.ViewGroup[@content-desc='•']")
								{
									goto IL_0cbd;
								}
							}
							else if (text5 == "//android.widget.TextView[@text='Incorrect Password']")
							{
								break;
							}
						}
						else if (num17 <= 1792698548)
						{
							if (num17 != 1761617051)
							{
								if (num17 == 1792698548 && text5 == "//*[@content-desc='Next']")
								{
									goto IL_103b;
								}
							}
							else if (text5 == "//android.widget.EditText[@content-desc='Username']")
							{
								goto IL_0e90;
							}
						}
						else if (num17 != 1878701109)
						{
							if (num17 == 1997336986 && text5 == "//android.widget.TextView[@text='Find Friends']")
							{
								TapByXPath("//android.widget.Button[@text='Get started']");
								goto IL_13af;
							}
						}
						else if (text5 == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]")
						{
							goto IL_0e11;
						}
					}
					else if (num17 <= 2492217505u)
					{
						if (num17 <= 2283011030u)
						{
							if (num17 != 2146469799)
							{
								if (num17 == 2283011030u && text5 == "//*[@text='Enter password to log in']")
								{
									goto IL_103b;
								}
							}
							else if (text5 == "//*[@text='Enter the code from your SMS']")
							{
								goto IL_1421;
							}
						}
						else if (num17 != 2329336095u)
						{
							if (num17 == 2492217505u && text5 == "//android.widget.TextView[@text=\"Can't Find Account\"]")
							{
								return 4;
							}
						}
						else if (text5 == "//*[@text='An unexpected error occurred. Please try logging in again.']")
						{
							goto IL_105e;
						}
					}
					else if (num17 <= 2526580307u)
					{
						if (num17 != 2507397295u)
						{
							if (num17 == 2526580307u && text5 == "//android.widget.TextView[@text='Login Code Required']")
							{
								goto IL_0b89;
							}
						}
						else if (text5 == "//android.widget.Button[@text='GET STARTED']")
						{
							if (ED9CDB24(text3, "To log into your Facebook account, you need to first confirm your identity"))
							{
								TapByXPath(text2, text3);
								goto IL_13af;
							}
							return 2;
						}
					}
					else if (num17 != 2684704644u)
					{
						if (num17 == 2698810085u && text5 == "//*[@text='No thanks']")
						{
							goto IL_103b;
						}
					}
					else if (text5 == "//android.view.ViewGroup[@content-desc='Use login code instead']")
					{
						goto IL_103b;
					}
				}
				else if (num17 <= 3496844666u)
				{
					if (num17 <= 2934012532u)
					{
						if (num17 <= 2900012396u)
						{
							if (num17 != 2868152009u)
							{
								if (num17 == 2900012396u && text5 == "//*[@package='com.google.android.gms']")
								{
									method_19();
									goto IL_13af;
								}
							}
							else if (text5 == "//*[@content-desc='Done']")
							{
								goto IL_103b;
							}
						}
						else if (num17 != 2928020320u)
						{
							if (num17 == 2934012532u && text5 == "//*[@text='Take photo']")
							{
								goto IL_0cbd;
							}
						}
						else if (text5 == "//android.widget.EditText[@text='Password']")
						{
							goto IL_0cf8;
						}
					}
					else if (num17 <= 3237538576u)
					{
						if (num17 != 3186143151u)
						{
							if (num17 == 3237538576u && text5 == "//*[@text='Go to your authentication app']")
							{
								goto IL_0d60;
							}
						}
						else if (text5 == "//android.widget.TextView[@text='Invalid username or password']")
						{
							break;
						}
					}
					else if (num17 != 3348687647u)
					{
						if (num17 == 3496844666u && text5 == "//*[@text='Trouble Loading']")
						{
							goto IL_0e11;
						}
					}
					else if (text5 == "//*[@text='Mobile number or email']/parent::*/parent::*//android.widget.EditText")
					{
						goto IL_0e90;
					}
				}
				else if (num17 <= 3919975960u)
				{
					if (num17 <= 3606322765u)
					{
						if (num17 != 3528901103u)
						{
							if (num17 == 3606322765u && text5 == "//android.widget.TextView[@text=\"Find your account\"]")
							{
								goto IL_0f41;
							}
						}
						else if (text5 == "//*[@text='Confirm by phone number']")
						{
							goto IL_1421;
						}
					}
					else if (num17 != 3855779225u)
					{
						if (num17 == 3919975960u && text5 == "//*[@content-desc='I ACCEPT']")
						{
							goto IL_103b;
						}
					}
					else if (text5 == "//*[@text='Login Failed']")
					{
						if (num3 < num4)
						{
							TapByXPath("//android.widget.Button[@text='OK']", text3);
							TimeDelay(1.0);
							num3++;
							goto IL_13af;
						}
						return 0;
					}
				}
				else if (num17 <= 4002761936u)
				{
					if (num17 != 3945336632u)
					{
						if (num17 == 4002761936u && text5 == "//*[@content-desc='skip' or @text='skip']")
						{
							goto IL_103b;
						}
					}
					else if (text5 == "//*[@text='Facebook will be back soon']")
					{
						goto IL_105e;
					}
				}
				else if (num17 != 4158470539u)
				{
					if (num17 == 4161201368u && text5 == "//*[@content-desc='Continue']")
					{
						if (!DoesElementExist(0, text3, "//*[@text='Type the text']"))
						{
							TapByXPath(text2, text3);
							goto IL_13af;
						}
						return 2;
					}
				}
				else if (text5 == "(//android.widget.EditText)[7]")
				{
					break;
				}
				if (!method_15().Contains("FacebookSplashScreenActivity"))
				{
					if (ED9CDB24(text3, "Create new account"))
					{
						if (CE16082B())
						{
							return 0;
						}
					}
					else if (ED9CDB24(text3, "You have attempted to share a private intimate image"))
					{
						TapByXPath("//android.widget.Button[@resource-id='checkpointSubmitButton-actual-button']", text3);
					}
					else if (ED9CDB24(text3, "Page isn't available right now"))
					{
						TapByXPath("//android.widget.Button[@text='Refresh']", text3);
					}
					else if (DoesElementExist(0, text3, "//android.widget.ImageView[@content-desc='Unlock']"))
					{
						method_47();
						method_58(FacebookPacker);
					}
					else
					{
						if (text3.Contains("com.android.systemui"))
						{
							method_19();
						}
						if (method_58(FacebookPacker) == 1)
						{
							num15++;
							if (num15 >= num16)
							{
								num15 = 0;
								ClearDataApp(FacebookPacker);
								TimeDelay(2.0);
								method_58(FacebookPacker);
							}
						}
						else
						{
							if (ED9CDB24(text3, "Something went wrong.Please try again"))
							{
								return 0;
							}
							if (ED9CDB24(text3, "You’re Temporarily Blocked", "It looks like you were misusing this feature by going too fast"))
							{
								return 11;
							}
							if (ED9CDB24(text3, "Facebook isn't responding", "Facebook keeps stopping", "has stopped"))
							{
								method_43(text3, 0, "//*[@text='Open app again']", "//android.widget.Button[@text='Close app']");
								if (num7 < num8)
								{
									if (!RestoreAppFb(string_7))
									{
										num7 = num8 - 1;
									}
								}
								else if (num7 == num8)
								{
									ClearDataApp(FacebookPacker);
								}
								else
								{
									D332771F(FacebookPacker);
									C03D049A(FileHelper.GetPathToCurrentFolder() + "\\app\\facebook.apk");
									method_11();
									C73BF637();
									method_47();
									RestoreAppFb(string_7);
								}
								num7++;
								method_58(FacebookPacker);
								TimeDelay(2.0);
								method_58(FacebookPacker);
							}
							else if (C6BD5E0A(text3))
							{
								if (num13 >= num14)
								{
									return 13;
								}
								num13++;
								TapByXPath("//*[@text='Close']", text3);
							}
							else
							{
								if (E2806F01(text3))
								{
									return 2;
								}
								if (!method_68(text3) && AF365B16(text3))
								{
									return 1;
								}
							}
						}
					}
				}
				goto IL_13af;
			}
			return -2;
			IL_103b:
			TapByXPath(text2, text3);
			goto IL_13af;
			IL_0b89:
			TapByXPath("//*[@text='OK']", text3);
			goto IL_13af;
			IL_1421:
			return 8;
			IL_0e11:
			if (num5 >= num6)
			{
				if (num10 != 0 || !A906F3A9())
				{
					return 7;
				}
				num10 = 1;
				method_58(FacebookPacker);
			}
			num5++;
			if (text2 == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]")
			{
				TapByXPath("//android.widget.Button[@text='OK']", text3);
			}
			else
			{
				TapByXPath("//*[@text='Tap to retry']", text3);
			}
			goto IL_13af;
			IL_0f41:
			if (num3 < num4)
			{
				TapByXPath("//android.widget.ImageView[@content-desc=\"Back\"]", text3);
				TimeDelay(1.0);
				num3++;
				goto IL_13af;
			}
			return 4;
			IL_13af:
			TimeDelay(2.0);
			if (Environment.TickCount - tickCount >= DD8FF534 * 1000)
			{
				return 0;
			}
			continue;
			IL_0d60:
			if (!(string_9.Trim() == ""))
			{
				string string_10 = Common.GetTotp(string_9);
				SendByXPath("//android.widget.EditText", string_10);
				TimeDelay(1.0);
				if (text2 == "//*[@text='Go to your authentication app']")
				{
					TapByXPath("//android.widget.Button[@content-desc='Continue']", text3);
				}
				else
				{
					B2016D94(DB353F82.E22EE10E);
				}
				goto IL_13af;
			}
			return 3;
			IL_1403:
			return 2;
			IL_0cf8:
			SendByXPath(text2, D99379A2, 0, bool_2: false, F238009E: false);
			TimeDelay(1.0);
			TapByXPath("//*[@text='Log in' or @content-desc='Log in']", text3);
			goto IL_13af;
			IL_0e90:
			SendByXPath(text2, string_8, 0, bool_2: false, F238009E: false);
			TimeDelay(1.0);
			text2 = FindElement(0, text3, new List<string> { "//android.widget.EditText[@text='Password']", "//*[@text='Password']/parent::*/parent::*//android.widget.EditText" });
			SendByXPath(text2, D99379A2, 0, bool_2: false, F238009E: false);
			TimeDelay(1.0);
			TapByXPath("//*[@text='Log in' or @content-desc='Log in']");
			goto IL_13af;
			IL_0cbd:
			method_59(FacebookPacker);
			method_58(FacebookPacker);
			goto IL_13af;
			IL_105e:
			if (num3 < num4)
			{
				TapByXPath("//*[@text='OK']", text3);
				TimeDelay(1.0);
				num3++;
				goto IL_13af;
			}
			return 12;
		}
		return 5;
	}

	public bool AF365B16(string string_7 = "")
	{
		if (string_7 == "")
		{
			string_7 = GetPageSource();
		}
		return ED9CDB24(string_7, "Feed, Tab", "Notifications, Tab", "Menu, Tab", "Make a post on Facebook", "\"Notifications", "Double tap to create a new post", "Post menu");
	}

	public bool C6BD5E0A(string string_7 = "")
	{
		if (string_7 == "")
		{
			string_7 = GetPageSource();
		}
		return ED9CDB24(string_7, "of your comments go against our standards on spam", "This comment goes against our Community Standards on spam", "Standards on spam");
	}

	public bool method_67(string string_7 = "")
	{
		if (string_7 == "")
		{
			string_7 = GetPageSource();
		}
		return ED9CDB24(string_7, "Turn on data or check your Wi-Fi settings", "Please check your internet connection", "Connection lost", "Trouble Loading");
	}

	public bool E2806F01(string string_7 = "")
	{
		if (string_7 == "")
		{
			string_7 = GetPageSource();
		}
		if (method_104(string_7).Count == 0 && DoesElementExist(0, string_7, "//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup[3]"))
		{
			TapByXPath("//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup[1]", string_7);
			TimeDelay(2.0);
			method_30(30);
			if (ED9CDB24("", "my account been locked"))
			{
				return true;
			}
			if (method_84("dataimage\\956"))
			{
				return true;
			}
			if (method_84("dataimage\\282"))
			{
				return true;
			}
			method_19();
		}
		if (method_84("dataimage\\956"))
		{
			return true;
		}
		if (method_84("dataimage\\282"))
		{
			return true;
		}
		if (method_104(string_7).Count == 1 && ED9CDB24(string_7, "\"Get started", "\"Learn more\"", "\"Start security steps"))
		{
			return true;
		}
		if (ED9CDB24(string_7, "Confirm Your Identity") && !ED9CDB24(string_7, "Contact info"))
		{
			return true;
		}
		return ED9CDB24(string_7, "Record a video of yourself", "To make sure you're a real person, we need you to record a video selfie. We'll ask you to move your head during the recording to help us capture your face at different angles.", "We use this video to help us check that this account belongs to you. We'll delete the video once we've done this, and it will never appear on your profile.", "Request a review", "Download your information", "Your account has been disabled", "Go to Community Standards", "We need more information", "Disagree with decision", "\"Record video", "Type the text", "a few steps to confirm your account on Facebook", "Help us confirm it's you", "checkpointSubmitButton-actual-button", "checkpoint_title", "Confirm your account", "A few steps before we can let you log in", "Get a code by email", "Get a code on your phone", "your account has been locked", "Start security steps", "Send login code");
	}

	public bool method_68(string string_7 = "")
	{
		NoteLog("Check popup...");
		int num = 0;
		int num2 = 1;
		while (true)
		{
			if (string_7 == "")
			{
				string_7 = GetPageSource();
			}
			List<string> list = method_104(string_7.ToLower());
			if (list.Count == 2 && list.Contains("profile picture") && list.Contains("photo"))
			{
				FB3ACF2E(-1);
				TimeDelay(1.0);
				string_7 = GetPageSource();
			}
			if (DoesElementExist(0, string_7, "//android.widget.Button[@text='Continue']"))
			{
				Class65 @class = new Class65(FindElements(0, string_7, "//android.widget.Button[@text='Continue']/parent::*[1]").First());
				if (@class.int_1 - @class.int_0 > 800)
				{
					FB3ACF2E(-1);
					TimeDelay(1.0);
					string_7 = GetPageSource();
				}
			}
			if (DoesElementExist(0, string_7, "//*[@content-desc='Continue']") && DoesElementExist(0, string_7, "//*[@content-desc='No Thanks']"))
			{
				TapByXPath("//*[@content-desc='No Thanks']", string_7);
				TimeDelay(2.0);
				string_7 = GetPageSource();
			}
			if (DoesElementExist(0, string_7, "//*[@content-desc='OK, Use Data']") && DoesElementExist(0, string_7, "//*[@content-desc='Go Back']"))
			{
				TapByXPath("//*[@content-desc='OK, Use Data']", string_7);
				TimeDelay(2.0);
				string_7 = GetPageSource();
			}
			string text = FindElements(0, string_7, "//*[@content-desc='Close']").FirstOrDefault();
			if (string.IsNullOrEmpty(text) || new Class65(text).B9898119 <= 2300)
			{
				string text2 = FindElement(0, string_7, new List<string>
				{
					"//*[@text='Tap to view story']", "//*[@content-desc='Close' or @text='CLOSE']", "//*[@content-desc='Dismiss' or @text='Dismiss']", "//*[@text='New! Post in this group without sharing your name.']", "//*[@content-desc='deny' or @text='deny']", "//*[@text='No thanks']", "//*[@content-desc='I ACCEPT']", "//*[@content-desc='Allow all cookies']", "//*[@text='Try again']", "//*[@text='Dismiss list?']",
					"//*[@content-desc='Unplug charger' or @text='Unplug charger']", "//*[@package='com.android.phone'][@text='CANCEL']", "//*[@text='Accidental touch protection']"
				});
				if (text2 != "")
				{
					if (!(text2 == "//*[@content-desc='Close' or @text='CLOSE']") || !DoesElementExist(0, string_7, "//android.widget.ScrollView"))
					{
						if (text2 == "//*[@text='Try again']")
						{
							if (num >= num2)
							{
								if (!TapByXPath("//*[@text='GO BACK']", string_7))
								{
									method_19();
								}
							}
							else
							{
								num++;
								TapByXPath(text2, string_7);
							}
							TimeDelay(2.0);
							string_7 = "";
							continue;
						}
						if (text2 == "//*[@content-desc='Unplug charger' or @text='Unplug charger']" || text2 == "//*[@text='Accidental touch protection']")
						{
							TapByXPath("//*[@content-desc='OK' or @text='OK']", string_7);
						}
						else
						{
							switch (text2)
							{
							case "//*[@text='Tap to view story']":
								return false;
							case "//*[@content-desc='Dismiss' or @text='Dismiss']":
								if (DoesElementExist(0, string_7, "//*[@content-desc='Show profile']"))
								{
									return false;
								}
								TapByXPath(text2, string_7);
								break;
							case "//*[@text='Dismiss list?']":
								TapByXPath("//*[@text='CONFIRM']", string_7);
								break;
							default:
								TapByXPath(text2, string_7);
								break;
							}
						}
					}
					else
					{
						Class65 class2 = new Class65(FindElements(0, string_7, "//android.widget.ScrollView").First());
						if (class2.int_0 != 0)
						{
							method_50((class2.int_0 + class2.int_1) / 2, class2.B9898119, (class2.int_0 + class2.int_1) / 2, (class2.E42395AA < method_12().Value.Y) ? class2.E42395AA : (class2.E42395AA - 10));
						}
						else
						{
							class2 = new Class65(FindElements(0, string_7, text2).First());
							if (class2.int_0 == 0)
							{
								method_19();
							}
							else
							{
								TapByXPath(text2, string_7);
							}
						}
					}
					method_54(2.0, 3.0);
					return true;
				}
				if (ED9CDB24(string_7, "Review Your Data Settings"))
				{
					TapByXPath("//*[@content-desc='Get Started']", string_7);
					string_7 = "";
				}
				else if (DoesElementExist(0, string_7, "//*[@content-desc='Accept and Continue']"))
				{
					TapByXPath("//*[@content-desc='Accept and Continue']", string_7);
					string_7 = "";
				}
				if (string_7 == "")
				{
					continue;
				}
				switch (method_104(string_7).Distinct().Count())
				{
				case 1:
					if (!CE16082B(-1))
					{
						string_7 = GetPageSource();
						continue;
					}
					break;
				case 0:
					if (string_7 != "" && !method_15().Contains("pagerecommendations"))
					{
						method_19();
						return true;
					}
					break;
				}
				break;
			}
			return false;
		}
		return false;
	}

	public string method_69(string string_7, int int_3 = 10)
	{
		return RunCMD("shell am start -n " + FacebookPacker + "/.IntentUriHandler \"" + string_7 + "\"", int_3);
	}

	public int method_70(string string_7, int FBA505B6 = 10)
	{
		NoteLog("Open gr " + string_7 + "...");
		method_69("fb://group/" + string_7);
		TimeDelay(2.0);
		FBA505B6 -= 2;
		string text = FindElement(FBA505B6, "", new List<string> { "//android.view.ViewGroup[starts-with(@content-desc,\"Cover photo of group\")]", "//android.widget.Button[@content-desc=\"Member Tools\"]", "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]" });
		return (!(text == "")) ? 1 : 0;
	}

	public void D7950A0F()
	{
		NoteLog("Open Timeline...");
		method_69("fb://dbl_login_activity", 3);
		string text = "";
		for (int i = 0; i < 5; i++)
		{
			if (searchComplete)
			{
				break;
			}
			text = "";
			string text2 = CB3C4B8A(3, ref text, new List<string> { "//android.view.ViewGroup[@content-desc='Add more to your post']", "//android.widget.TextView[@text='Create post']", "//android.widget.Button[@content-desc='Discard post']" });
			if (!(text2 == ""))
			{
				if (text2 == "//android.view.ViewGroup[@content-desc='Add more to your post']" || text2 == "//android.widget.TextView[@text='Create post']")
				{
					TapByXPath("//android.widget.ImageView[@content-desc='Back']", text);
				}
				else
				{
					TapByXPath(text2, text);
				}
				continue;
			}
			break;
		}
	}

	public bool method_71(string string_7 = "", string C2189E94 = "people")
	{
		D7950A0F();
		bool flag;
		if (!(flag = method_40(5, "//android.widget.Button[contains(@content-desc, \"Search\")]", "")))
		{
			method_69("fb://search");
			flag = true;
		}
		if (flag && string_7 != "" && SendByXPath("//android.widget.EditText", string_7, 5))
		{
			method_54(1.0, 1.5);
			B2016D94(DB353F82.E22EE10E);
			method_54(1.5, 2.5);
			method_40(10, "//android.view.ViewGroup[@content-desc=\"" + C2189E94 + " search results\"]", "");
		}
		return flag;
	}

	public void method_72(string B1035DAB = "")
	{
		DD071C25();
		if (method_40(5, "//*[@content-desc='Search']", "") && B1035DAB != "" && SendByXPath("//android.widget.EditText", B1035DAB, 5))
		{
			method_54(1.0, 1.5);
			B2016D94(DB353F82.E22EE10E);
			TimeDelay(2.0);
			method_30(60);
		}
	}

	public bool method_73(string string_7 = "")
	{
		string_7 = string_7.Trim();
		if (string_7 == "")
		{
			return false;
		}
		method_69("fb://watch");
		TimeDelay(2.0);
		for (int i = 0; i < 2; i++)
		{
			if (method_40(5, "//*[@content-desc='Search videos']", ""))
			{
				break;
			}
			FB3ACF2E(-1);
		}
		if (SendByXPath("//android.widget.EditText", string_7, 5))
		{
			method_54(1.0, 1.5);
			B2016D94(DB353F82.E22EE10E);
			TimeDelay(2.0);
			method_30(60);
			return method_40(10, "//*[@content-desc='Video']", "");
		}
		return false;
	}

	public bool method_74()
	{
		if (!DoesElementExist(0, "", "//*[starts-with(@content-desc,'Friends, tab')]"))
		{
			D7950A0F();
		}
		if (method_40(5, "//*[starts-with(@content-desc,'Friends, tab')]", ""))
		{
			string string_ = "";
			switch (CB3C4B8A(5, ref string_, new List<string> { "//*[@content-desc='Suggestions']", "//*[contains(@content-desc,'as a friend') or contains(@text,'as a friend')]", "//*[@content-desc='Requests']" }))
			{
			case "//*[@content-desc='Suggestions']":
				return method_40(0, "//*[@content-desc='Suggestions']", string_);
			case "//*[contains(@content-desc,'as a friend') or contains(@text,'as a friend')]":
				return true;
			case "//*[@content-desc='Requests']":
				if (method_40(0, "//*[@content-desc='Requests']", string_))
				{
					return method_40(5, "//*[@content-desc='See friend suggestions']", "");
				}
				break;
			}
		}
		return false;
	}

	public bool B7873BB0()
	{
		if (!DoesElementExist(0, "", "//*[starts-with(@content-desc,'Friends, tab')]"))
		{
			D7950A0F();
		}
		if (method_40(5, "//*[starts-with(@content-desc,'Friends, tab')]", ""))
		{
			return method_43("", 10, "//*[@content-desc='Your Friends']", "//*[@content-desc='All friends']");
		}
		return false;
	}

	public bool method_75()
	{
		NoteLog("Open Notify...");
		int tickCount = Environment.TickCount;
		while (true)
		{
			if (Environment.TickCount - tickCount < 30000 && !searchComplete)
			{
				string string_ = GetPageSource();
				if (FindElement(0, string_, new List<string> { "//android.widget.TextView[@text=\"No notifications\"]", "//*[@text='Notifications']" }) != "")
				{
					break;
				}
				string text = FindElement(0, string_, new List<string> { "//android.view.View[contains(@content-desc,'Notifications, tab')]" });
				if (text == "")
				{
					D7950A0F();
				}
				else
				{
					TapByXPath(text, string_);
				}
				TimeDelay(2.0);
				continue;
			}
			return false;
		}
		return true;
	}

	public bool method_76()
	{
		NoteLog("Open Page...");
		D7950A0F();
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			text = GetPageSource();
			string text2 = FindElement(0, text, new List<string> { "//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/child::*", "//*[starts-with(@content-desc,'Menu, tab')]", "//android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/child::*", "//android.widget.ProgressBar" });
			switch (text2)
			{
			case "//*[starts-with(@content-desc,'Menu, tab')]":
				TapByXPath(text2, text);
				break;
			case "//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/androidx.recyclerview.widget.RecyclerView/child::*":
			{
				List<Class65> list2 = Class65.smethod_2(text, text2);
				if (list2.Count > 0)
				{
					E832B991(list2.First().AA3F9A29());
					return true;
				}
				break;
			}
			case "//android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/child::*":
			{
				List<Class65> list = Class65.smethod_2(text, text2);
				if (list.Count > 0)
				{
					E832B991(list.Last().AA3F9A29());
				}
				break;
			}
			}
			TimeDelay(2.0);
		}
		while (Environment.TickCount - tickCount < 300000);
		return false;
	}

	public bool C628163C(string D80AC780 = "1|2|4|5")
	{
		NoteLog("Reaction...");
		List<string> list = new List<string> { "Like", "Love", "Care", "Haha", "Wow", "Sad", "Angry" };
		string text = "";
		if (D80AC780 == "")
		{
			D80AC780 = "1|2|4|5";
		}
		List<string> list2 = D80AC780.Split('|').ToList();
		if (list2.Count > 0)
		{
			text = list2.smethod_8();
			text = list[Convert.ToInt32(text) - 1];
		}
		if (string.IsNullOrEmpty(text))
		{
			text = list.smethod_8();
		}
		text = $"//*[contains(@content-desc, \"{text}\")]";
		return E80B893F(text);
	}

	public string AF03B30E()
	{
		string text = "";
		string text2 = "";
		string text3 = "";
		try
		{
			for (int i = 0; i < 2; i++)
			{
				if (searchComplete)
				{
					break;
				}
				text3 = ((i != 0) ? RunCMD("shell cat data/data/" + FacebookPacker + "/app_light_prefs/" + FacebookPacker + "/authentication") : RunCMD("shell su -c cat data/data/" + FacebookPacker + "/app_light_prefs/" + FacebookPacker + "/authentication"));
				if (!(text3 == ""))
				{
					try
					{
						text = Regex.Match(text3, "EAAAAU\\S+").Value;
						string value = Regex.Match(text, "\u0005(.*?)$").Value;
						text = text.Replace(value, "");
					}
					catch
					{
					}
					string json = "{\"data\": [" + Regex.Match(text3, "\\[(.*?)\\]").Groups[1].Value + "]}";
					JObject jObject = JObject.Parse(json);
					for (int j = 0; j < jObject["data"].Count(); j++)
					{
						text2 = text2 + jObject["data"]![j]!["name"]!.ToString() + "=" + jObject["data"]![j]!["value"]!.ToString() + ";";
					}
					if (text != "")
					{
						break;
					}
				}
			}
		}
		catch
		{
		}
		return text + "|" + text2;
	}

	public string method_77()
	{
		string result = "";
		try
		{
			string text = method_78();
			if (!(text == ""))
			{
				string text2 = "";
				for (int i = 0; i < 2; i++)
				{
					if (searchComplete)
					{
						break;
					}
					text2 = ((i != 0) ? RunCMD("shell su -c cat data/data/" + FacebookPacker + "/app_light_prefs/" + FacebookPacker + "/logged_in_" + text) : RunCMD("shell cat data/data/" + FacebookPacker + "/app_light_prefs/" + FacebookPacker + "/logged_in_" + text));
					if (!(text2 == ""))
					{
						text2 = Regex.Replace(text2, "[\0-\u001f]+", " ");
						string text3 = Regex.Match(text2, " name(.*?)is_pushable").Groups[1].Value.Trim();
						string text4 = Regex.Match(text2, "gender (.*?)\\s").Groups[1].Value.Trim().ToLower();
						string text5 = Regex.Match(text2, "phone_full_number\":\"(.*?)\"").Groups[1].Value.Trim();
						string text6 = Regex.Match(text2, "emails (.*?) uid").Groups[1].Value.Trim();
						string text7 = (text7 = Regex.Match(text2, "pic_square(.*?)(http.*?)\\s").Groups[2].Value.Trim());
						result = text + "|" + text3 + "|" + text4 + "|" + text5 + "|" + text6 + "|" + text7;
					}
				}
			}
		}
		catch
		{
		}
		return result;
	}

	public string method_78()
	{
		string result = "";
		try
		{
			string text = AF03B30E();
			result = Regex.Match(text.Split('|')[1], "c_user=(\\d+)").Groups[1].Value;
		}
		catch
		{
		}
		return result;
	}

	public bool EE294CB1(double F51199BA = 0.0, params string[] B6AE9B1C)
	{
		try
		{
			List<string> c8A46E = B6AE9B1C.ToArray().ToList();
			int tickCount = Environment.TickCount;
			while (!searchComplete)
			{
				if (!(FindElement(0, "", c8A46E) == ""))
				{
					if (F51199BA != 0.0)
					{
						TimeDelay(1.0);
						if (!((double)(Environment.TickCount - tickCount) < F51199BA * 1000.0))
						{
							break;
						}
						continue;
					}
					break;
				}
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public Rect method_79(Bitmap bitmap_0, Bitmap bitmap_1, double D20B5199 = 0.95)
	{
		try
		{
			using Mat mat = bitmap_0.ToMat();
			using Mat mat2 = bitmap_1.ToMat();
			using Mat mat3 = mat.Clone();
			using Mat mat4 = mat2.Clone();
			using Mat mat5 = new Mat(mat.Rows - mat2.Rows + 1, mat.Cols - mat2.Cols + 1, MatType.CV_32FC1);
			Cv2.MatchTemplate(mat3, mat4, mat5, TemplateMatchModes.CCoeffNormed);
			Cv2.Threshold(mat5, mat5, D20B5199, 1.0, ThresholdTypes.Tozero);
			Cv2.MinMaxLoc(mat5, out var _, out var maxVal, out var _, out var maxLoc);
			if (maxVal >= D20B5199)
			{
				return new Rect(maxLoc.X, maxLoc.Y, mat2.Width, mat2.Height);
			}
		}
		catch (Exception)
		{
		}
		return Rect.Empty;
	}

	public Rect[] method_80(Bitmap bitmap_0, Bitmap bitmap_1, double double_0 = 0.95)
	{
		List<Rect> list = new List<Rect>();
		try
		{
			using Mat mat = bitmap_0.ToMat();
			using Mat mat2 = bitmap_1.ToMat();
			using Mat mat3 = mat.Clone();
			using Mat mat4 = mat2.Clone();
			using Mat mat5 = new Mat(mat.Rows - mat2.Rows + 1, mat.Cols - mat2.Cols + 1, MatType.CV_32FC1);
			Cv2.MatchTemplate(mat3, mat4, mat5, TemplateMatchModes.CCoeffNormed);
			Cv2.Threshold(mat5, mat5, double_0, 1.0, ThresholdTypes.Tozero);
			while (true)
			{
				Cv2.MinMaxLoc(mat5, out var _, out var maxVal, out var _, out var maxLoc);
				if (maxVal >= double_0)
				{
					Rect item = new Rect(new OpenCvSharp.Point(maxLoc.X, maxLoc.Y), new OpenCvSharp.Size(mat2.Width, mat2.Height));
					list.Add(item);
					Cv2.FloodFill(mat5, maxLoc, new Scalar(0.0));
					continue;
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		return list.OrderBy((Rect rect_0) => rect_0.Y).ThenBy((Rect BF27A196) => BF27A196.X).ToArray();
	}

	public string method_81(string string_7, Bitmap BD0B1EAB = null, int int_3 = 0)
	{
		try
		{
			List<Bitmap> list = new List<Bitmap>();
			DirectoryInfo directoryInfo = new DirectoryInfo(string_7);
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				Bitmap item = (Bitmap)Image.FromFile(fileInfo.FullName);
				list.Add(item);
			}
			int tickCount = Environment.TickCount;
			while (true)
			{
				if (BD0B1EAB == null)
				{
					BD0B1EAB = method_87();
				}
				foreach (Bitmap item2 in list)
				{
					Rect rect = method_79(BD0B1EAB, item2);
					if (rect != Rect.Empty)
					{
						return $"[{rect.Left},{rect.Top}][{rect.Right},{rect.Bottom}]";
					}
				}
				if (Environment.TickCount - tickCount < int_3 * 1000)
				{
					TimeDelay(1.0);
					BD0B1EAB = method_87();
					continue;
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	public string B2127B14(Bitmap A6B7E3BC, Bitmap E20A8729 = null, int int_3 = 0)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				if (E20A8729 == null)
				{
					E20A8729 = method_87();
				}
				Rect rect = method_79(E20A8729, A6B7E3BC);
				if (!(rect != Rect.Empty))
				{
					if (Environment.TickCount - tickCount < int_3 * 1000)
					{
						TimeDelay(1.0);
						E20A8729 = method_87();
						continue;
					}
					break;
				}
				return $"[{rect.Left},{rect.Top}][{rect.Right},{rect.Bottom}]";
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	public List<string> method_82(string string_7, Bitmap bitmap_0 = null, int BAA2F838 = 0)
	{
		List<string> list = new List<string>();
		try
		{
			List<Bitmap> list2 = new List<Bitmap>();
			DirectoryInfo directoryInfo = new DirectoryInfo(string_7);
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				Bitmap item = (Bitmap)Image.FromFile(fileInfo.FullName);
				list2.Add(item);
			}
			int tickCount = Environment.TickCount;
			while (true)
			{
				if (bitmap_0 == null)
				{
					bitmap_0 = method_87();
				}
				foreach (Bitmap item2 in list2)
				{
					Rect[] array2 = method_80(bitmap_0, item2);
					if (array2.Length == 0)
					{
						continue;
					}
					for (int j = 0; j < array2.Length; j++)
					{
						if (array2[j].X != 0 && array2[j].Y != 0)
						{
							list.Add($"[{array2[j].Left},{array2[j].Top}][{array2[j].Right},{array2[j].Bottom}]");
						}
					}
					return list;
				}
				if (Environment.TickCount - tickCount < BAA2F838 * 1000)
				{
					TimeDelay(1.0);
					bitmap_0 = method_87();
					continue;
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public bool BD33F0BA(string string_7, Bitmap bitmap_0 = null, int C89CF689 = 0)
	{
		try
		{
			string text = method_81(string_7, bitmap_0, C89CF689);
			if (text != "")
			{
				return E832B991(text);
			}
		}
		catch
		{
		}
		return false;
	}

	public bool B7395922(string string_7, int E33BD820 = 0, int B33EA417 = 10)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				string text = method_81(string_7);
				if (text != "")
				{
					for (int i = 0; i < B33EA417; i++)
					{
						E832B991(text);
						TimeDelay(1.0);
						string text2 = method_81(string_7);
						if (text2 == "" || text2 != text)
						{
							return true;
						}
					}
				}
				if (Environment.TickCount - tickCount < E33BD820 * 1000)
				{
					TimeDelay(1.0);
					continue;
				}
				break;
			}
		}
		catch
		{
		}
		return false;
	}

	public bool method_83(string string_7, double double_0 = 0.0)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				string text = method_81(string_7);
				if (!(text != ""))
				{
					if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
					{
						TimeDelay(1.0);
						continue;
					}
					break;
				}
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public bool A3BD0D03(string string_7, double double_0 = 0.0)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (true)
			{
				string text = method_81(string_7);
				if (!(text == ""))
				{
					if (!((double)(Environment.TickCount - tickCount) >= double_0 * 1000.0))
					{
						TimeDelay(1.0);
						continue;
					}
					break;
				}
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public bool method_84(string E336798B, Bitmap F608D383 = null, int int_3 = 0)
	{
		try
		{
			string text = method_81(E336798B, F608D383, int_3);
			return text != "";
		}
		catch (Exception)
		{
		}
		return false;
	}

	public string method_85(int int_3, ref Bitmap bitmap_0, List<string> list_0)
	{
		int tickCount = Environment.TickCount;
		while (true)
		{
			if (!searchComplete)
			{
				if (bitmap_0 == null)
				{
					bitmap_0 = method_87();
				}
				for (int i = 0; i < list_0.Count; i++)
				{
					if (method_84(list_0[i], bitmap_0))
					{
						return list_0[i];
					}
				}
				if (int_3 == 0 || Environment.TickCount - tickCount > int_3 * 1000)
				{
					break;
				}
				TimeDelay(1.0);
				bitmap_0 = method_87();
				continue;
			}
			return "";
		}
		return "";
	}

	public string method_86(int FE002ABC, Bitmap bitmap_0, List<string> C6032710)
	{
		return method_86(FE002ABC, bitmap_0, C6032710);
	}

	public Bitmap method_87()
	{
		return GClass1.smethod_1(String_1);
	}

	private bool method_88(string string_7)
	{
		List<string> list = method_120();
		return list.Contains(string_7);
	}

	public bool method_89(string string_7, string F5203291)
	{
		RemoveProxy();
		RunCMD("shell su -c 'svc wifi enable'");
		if (!method_88("com.steinwurf.adbjoinwifi"))
		{
			C03D049A(FileHelper.GetPathToCurrentFolder() + "\\app\\adb-join-wifi.apk");
		}
		method_59("com.steinwurf.adbjoinwifi");
		RunCMD("shell am start -n com.steinwurf.adbjoinwifi/.MainActivity -e ssid '" + string_7 + "' -e password_type WPA -e password '" + F5203291 + "'");
		return true;
	}

	public void FB008A0E(int int_3, int int_4, int A9BE2C8A = 1, int int_5 = 2)
	{
		int num = Base.rd.Next(int_3, int_4 + 1);
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount < num * 1000 && !searchComplete && !CE16082B())
		{
			TimeDelay(Base.rd.Next(A9BE2C8A, int_5 + 1));
		}
	}

	public bool method_90(List<string> E231D995, int int_3)
	{
		int tickCount = Environment.TickCount;
		while (!searchComplete && !CE16082B())
		{
			method_54(1.5, 2.5);
			if (!(FindElement(0, "", E231D995) != ""))
			{
				if (Environment.TickCount - tickCount > int_3 * 1000)
				{
					break;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	public void DD071C25()
	{
		NoteLog("Open reel...");
		if (!method_15().Contains("com.facebook.fbshorts"))
		{
			method_18(FacebookPacker + "/com.facebook.fbshorts.viewer.activity.FbShortsViewerActivity");
		}
	}

	internal string method_91(string A40A7AA2, string DCABE605)
	{
		string text = "";
		try
		{
			string d784181C = "[FBAN/FB4A;FBAV/322.0.0.35.121;FBBV/297186297;FBDM/{density=2.75,width=1080,height=2130};FBLC/en_US;FBRV/298570471;FBCR/Viettel;FBMF/Xiaomi;FBBD/xiaomi;FBPN/com.facebook.katana;FBDV/Redmi Note 8;FBSV/10;FBOP/1;FBCA/arm64-v8a:;]";
			RequestXNet b01F5C = new RequestXNet("", d784181C, "", 0);
			b01F5C.http.AddHeader("Authorization", "OAuth " + DCABE605);
			string text2 = "method=POST&challenge_type=PASSWORD&challenge_params={\"password\":\"" + A40A7AA2 + "\"}&locale=en_US&client_country_code=VN&fb_api_req_friendly_name=validate_challenge&fb_api_caller_class=SecuredActionServiceHandler";
			string text3 = b01F5C.method_1("https://graph.facebook.com/secured_action/validate_challenge", text2);
			b01F5C.http.AddHeader("X-FB-Net-HNI", " 45204");
			b01F5C.http.AddHeader("X-FB-SIM-HNI", " 45201");
			b01F5C.http.AddHeader("Authorization", " OAuth " + DCABE605);
			b01F5C.http.AddHeader("X-FB-Connection-Type", " WIFI");
			b01F5C.http.AddHeader("X-Tigon-Is-Retry", " False");
			b01F5C.http.AddHeader("x-fb-rmd", " state=NO_MATCH");
			b01F5C.http.AddHeader("x-fb-session-id", " nid=OMyw5/7ZxImN;pid=Main;tid=947;nc=0;fc=0;bc=0;cid=f36ca4f6f658dd2e6a1f0ff6e43e6051");
			b01F5C.http.AddHeader("x-fb-device-group", " 5120");
			b01F5C.http.AddHeader("X-FB-Friendly-Name", " PageCreationNewPage");
			b01F5C.http.AddHeader("X-FB-Request-Analytics-Tags", " graphservice");
			b01F5C.http.AddHeader("X-FB-HTTP-Engine", " Liger");
			b01F5C.http.AddHeader("X-FB-Client-IP", " True");
			b01F5C.http.AddHeader("X-FB-Server-Cluster", " True");
			b01F5C.http.AddHeader("x-fb-connection-token", " f36ca4f6f658dd2e6a1f0ff6e43e6051");
			text2 = "doc_id=4330798123599254&method=post&locale=en_US&pretty=false&format=json&purpose=fetch&variables={\"params\":{\"nt_context\":{\"using_white_navbar\":true,\"pixel_ratio\":3,\"styles_id\":\"b6ae3d50d6f559cf2e62adb67b77fd9e\",\"bloks_version\":\"3b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1\"},\"path\":\"security/2fac/nt/setup/qr_code\",\"params\":\"{\\\"start_screen_id\\\":\\\"[\\\\\\\"__ntid:uu97dx:0__\\\\\\\",null]\\\"}\",\"extra_client_data\":{}},\"scale\":\"3\",\"nt_context\":{\"using_white_navbar\":true,\"pixel_ratio\":3,\"styles_id\":\"b6ae3d50d6f559cf2e62adb67b77fd9e\",\"bloks_version\":\"3b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1\"}}&fb_api_req_friendly_name=NativeTemplateScreenQuery&fb_api_caller_class=graphservice&fb_api_analytics_tags=[\"GraphServices\"]&server_timestamps=true";
			text3 = b01F5C.method_1("https://graph.facebook.com/graphql/", text2);
			text = Regex.Match(text3, "secret=(.*?)&").Groups[1].Value;
			string text4 = Common.GetTotp(text);
			b01F5C.http.AddHeader("X-FB-Net-HNI", " 45204");
			b01F5C.http.AddHeader("X-FB-SIM-HNI", " 45201");
			b01F5C.http.AddHeader("Authorization", "OAuth " + DCABE605);
			b01F5C.http.AddHeader("X-FB-Connection-Type", " WIFI");
			b01F5C.http.AddHeader("X-Tigon-Is-Retry", " False");
			b01F5C.http.AddHeader("x-fb-rmd", " state=NO_MATCH");
			b01F5C.http.AddHeader("x-fb-session-id", " nid=OMyw5/7ZxImN;pid=Main;tid=947;nc=0;fc=0;bc=0;cid=f36ca4f6f658dd2e6a1f0ff6e43e6051");
			b01F5C.http.AddHeader("x-fb-device-group", " 5120");
			text2 = "doc_id=6091464777534071&method=post&locale=en_US&pretty=false&format=json&variables=%7B%22scale%22%3A%223%22%2C%22params%22%3A%7B%22nt_context%22%3A%7B%22using_white_navbar%22%3Atrue%2C%22pixel_ratio%22%3A3%2C%22styles_id%22%3A%22b6ae3d50d6f559cf2e62adb67b77fd9e%22%2C%22bloks_version%22%3A%223b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1%22%7D%2C%22payload%22%3A%22security%2F2fac%2Fnt%2Fsetup%2Fcode_entry%2Fsubmit%3Fcontent_id%3D%255B%2522__ntid%253Av10gun%253A1__%2522%252Cnull%255D%26error_element_id%3D%255B%2522__ntid%253Av10gun%253A6__%2522%252Cnull%255D%26submit_button_id%3D%255B%2522__ntid%253Av10gun%253A4__%2522%252Cnull%255D%26progress_id%3D%255B%2522__ntid%253Av10gun%253A5__%2522%252Cnull%255D%26form_id%3D%255B%2522__ntid%253Av10gun%253A2__%2522%252Cnull%255D%26start_screen_id%3D%255B%2522__ntid%253Auu97dx%253A0__%2522%252Cnull%255D%22%2C%22client_data%22%3A%7B%22sensitive_string_value%22%3A%22%5B%5B%5C%22code%5B%5D%5C%22%2C%5C%22" + text4 + "%5C%22%5D%2C%5B%5C%22code_handler_type%5C%22%2C%5C%22third_party_qr_auth%5C%22%5D%5D%22%7D%7D%2C%22nt_context%22%3A%7B%22using_white_navbar%22%3Atrue%2C%22pixel_ratio%22%3A3%2C%22styles_id%22%3A%22b6ae3d50d6f559cf2e62adb67b77fd9e%22%2C%22bloks_version%22%3A%223b5a444c99b7214e5eefefb79bcaf6e89b80ae7db8ced15a5588301589a164c1%22%7D%2C%22profile_image_size%22%3A258%2C%22include_image_ranges%22%3Atrue%7D&fb_api_req_friendly_name=NativeTemplateAsyncQuery&fb_api_caller_class=graphservice&fb_api_analytics_tags=%5B%22GraphServices%22%5D&server_timestamps=true";
			text3 = b01F5C.method_1("https://graph.facebook.com/graphql/", text2);
			if (text3.Contains("error"))
			{
				text = "";
			}
		}
		catch
		{
		}
		return text;
	}

	internal int method_92(string F6B5DA2E, string string_7, string F3913CBA, string F29875AD, int int_3 = 0, int E80653A0 = 0, int int_4 = 300)
	{
		int tickCount = Environment.TickCount;
		ClearDataApp(string_4);
		method_58(string_4);
		string text = "";
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		int num4 = ((int_3 != 15) ? (-1) : 0);
		NoteLog("Login Tiktok...");
		do
		{
			string text2;
			if (!searchComplete)
			{
				text2 = GetPageSource();
				text = FindElement(0, text2, new List<string>
				{
					"//*[@text='Log in or sign up']", "//*[@text='Sign up']", "//*[@text='Agree and continue']", "//*[@text='Swipe up for more']", "//*[@text='Start watching']", "//*[@text='Profile']", "//*[@text='Continue with Facebook']", "//android.widget.Button[starts-with(@text,'Continue as')]", "//*[starts-with(@text,'user')]", "//*[@text='Use phone / email / username']",
					"//*[@text='Email / Username']", "//android.widget.EditText[@text='Email or username']", "//*[@text='verify captcha']", "//*[@content-desc='deny' or @text='deny']", "//*[@content-desc='Skip' or @text='Skip']", "//android.widget.Button[@text='Not now']", "//*[@text='This will help us customize your viewing experience.']", "//android.widget.Button[@text='NONE OF THE ABOVE']", "//android.widget.Button[@text='No thanks']", "//*[@text='Already have an account? Log in']",
					"//*[@text='Follow your friends']", "//*[@content-desc='Unplug charger' or @text='Unplug charger']"
				});
				string text3 = text;
				string text4 = text3;
				uint num5 = HashString.DA8CEBAB(text4);
				if (num5 <= 2488835064u)
				{
					if (num5 <= 940370423)
					{
						if (num5 <= 503461667)
						{
							if (num5 != 14426572)
							{
								if (num5 != 491345232)
								{
									if (num5 != 503461667 || !(text4 == "//android.widget.Button[@text='Not now']"))
									{
										goto IL_07da;
									}
								}
								else if (!(text4 == "//*[@content-desc='Skip' or @text='Skip']"))
								{
									goto IL_07da;
								}
							}
							else if (!(text4 == "//*[@content-desc='deny' or @text='deny']"))
							{
								goto IL_07da;
							}
							goto IL_0846;
						}
						if (num5 <= 729358616)
						{
							if (num5 != 532719482)
							{
								if (num5 != 729358616 || !(text4 == "//*[@text='verify captcha']"))
								{
									goto IL_07da;
								}
								method_87();
							}
							else
							{
								if (!(text4 == "//android.widget.ProgressBar"))
								{
									goto IL_07da;
								}
								num3++;
								if (num3 % 5 == 0)
								{
									if (AF365B16(text2))
									{
										return 1;
									}
									TapByXPath("//*[@content-desc='skip' or @text='skip']", text2);
								}
							}
							goto IL_0853;
						}
						if (num5 != 827023039)
						{
							if (num5 == 940370423 && text4 == "//*[@text='Incorrect account or password']")
							{
								return 5;
							}
						}
						else if (text4 == "//*[@text='Connection lost']")
						{
							goto IL_05a1;
						}
					}
					else if (num5 <= 1289675325)
					{
						if (num5 != 975982194)
						{
							if (num5 != 1100426492)
							{
								if (num5 == 1289675325 && text4 == "//android.widget.Button[starts-with(@text,'Continue as')]")
								{
									goto IL_0846;
								}
							}
							else if (text4 == "//*[@content-desc='Unplug charger' or @text='Unplug charger']")
							{
								TapByXPath("//*[@content-desc='OK' or @text='OK']", text2);
								goto IL_0853;
							}
						}
						else if (text4 == "//*[@text='Edit profile']")
						{
							return 1;
						}
					}
					else
					{
						if (num5 <= 1803252991)
						{
							if (num5 != 1450627680)
							{
								if (num5 != 1803252991 || !(text4 == "//*[@text='This will help us customize your viewing experience.']"))
								{
									goto IL_07da;
								}
								TapByXPath("//*[@text='Confirm']", text2);
							}
							else
							{
								if (!(text4 == "//*[starts-with(@text,'user')]"))
								{
									goto IL_07da;
								}
								string_7 = method_23(text2, text, "text").First();
								TapByXPath("//*[starts-with(@text,'user')]/parent::*/parent::*/child::*[last()]/child::*[last()]", text2);
							}
							goto IL_0853;
						}
						if (num5 != 1878701109)
						{
							if (num5 == 2488835064u && text4 == "//*[@text='Follow your friends']")
							{
								method_19();
								goto IL_0853;
							}
						}
						else if (text4 == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]")
						{
							goto IL_05a1;
						}
					}
				}
				else if (num5 <= 3301521716u)
				{
					if (num5 <= 2826808716u)
					{
						if (num5 != 2558777018u)
						{
							if (num5 != 2681761929u)
							{
								if (num5 == 2826808716u && text4 == "//*[@text='Swipe up for more']")
								{
									FB3ACF2E();
									goto IL_0853;
								}
							}
							else if (text4 == "//*[@text='Log in or sign up']")
							{
								goto IL_0846;
							}
						}
						else if (text4 == "//*[@text='Start watching']")
						{
							goto IL_0846;
						}
					}
					else
					{
						if (num5 <= 3036778647u)
						{
							if (num5 != 2893717309u)
							{
								if (num5 != 3036778647u || !(text4 == "//android.widget.Button[@text='NONE OF THE ABOVE']"))
								{
									goto IL_07da;
								}
							}
							else if (!(text4 == "//*[@text='Agree and continue']"))
							{
								goto IL_07da;
							}
							goto IL_0846;
						}
						if (num5 != 3036894654u)
						{
							if (num5 == 3301521716u && text4 == "//android.widget.EditText[@text='Email or username']")
							{
								SendByXPath("//android.widget.EditText[@text='Email or username']", string_7);
								TimeDelay(1.0);
								SendByXPath("//android.widget.EditText[@text='Password']", F3913CBA);
								TimeDelay(1.0);
								TapByXPath("//*[@text='Log in']", text2);
								goto IL_0853;
							}
						}
						else if (text4 == "//*[@text='Continue with Facebook']")
						{
							goto IL_0846;
						}
					}
				}
				else if (num5 <= 3496844666u)
				{
					if (num5 != 3386554506u)
					{
						if (num5 != 3408017596u)
						{
							if (num5 == 3496844666u && text4 == "//*[@text='Trouble Loading']")
							{
								goto IL_05a1;
							}
						}
						else if (text4 == "//*[@text='Profile']")
						{
							if (!DoesElementExist(0, text2, "//*[@text='Edit profile']"))
							{
								TapByXPath(text, text2);
								goto IL_0853;
							}
							string input = "http://45.77.37.128/?type=getcode&mail=aaasasasas2323232@smakit.vn";
							string text5 = "";
							do
							{
								string text6;
								if (!searchComplete)
								{
									text6 = GetPageSource();
									text = FindElement(0, text6, new List<string> { "//*[starts-with(@text,'user')]", "//*[@text='Settings and privacy']", "//*[@text='Manage account']", "//*[@text='Password']", "//*[@text=\"Can't verify your phone? Use email\"]", "//android.widget.EditText[@text='Email address']", "//*[@text='Change email address']", "//*[@text='Enter 6-digit code']", "//*[@text='No thanks']", "//android.widget.EditText[@text='Enter password']" });
									string text7 = text;
									string text8 = text7;
									num5 = HashString.DA8CEBAB(text8);
									if (num5 <= 1450627680)
									{
										if (num5 <= 937886214)
										{
											if (num5 != 802456587)
											{
												if (num5 != 937886214 || !(text8 == "//*[@text='Enter 6-digit code']"))
												{
													goto IL_0c4e;
												}
												if (text5 == "")
												{
													return -1;
												}
												string string_8 = EmailHelper.smethod_1(0, input, text5);
												SendByXPath("//android.widget.EditText", string_8);
											}
											else
											{
												if (!(text8 == "//*[@text='Manage account']"))
												{
													goto IL_0c4e;
												}
												if (F3913CBA != "")
												{
													string text9 = string_7 + "|" + F3913CBA + "|" + text5 + "|";
													lock (object_0)
													{
														File.AppendAllText("tiktok.txt", text9 + "\r\n");
													}
													return 1;
												}
												if (DoesElementExist(0, text6, "//*[@text='Password']"))
												{
													TapByXPath("//*[@text='Password']", text6);
												}
												else
												{
													TapByXPath(text, text6);
												}
											}
										}
										else if (num5 != 1113589947)
										{
											if (num5 != 1450627680 || !(text8 == "//*[starts-with(@text,'user')]"))
											{
												goto IL_0c4e;
											}
											string_7 = method_23(text6, text, "text").First();
											TapByXPath("//*[starts-with(@text,'user')]/parent::*/parent::*/child::*[last()]/child::*[last()]", text6);
										}
										else
										{
											if (!(text8 == "//*[@text='Settings and privacy']"))
											{
												goto IL_0c4e;
											}
											if (DoesElementExist(0, text6, "//*[@text='Manage account']"))
											{
												TapByXPath("//*[@text='Manage account']", text6);
											}
											else
											{
												TapByXPath(text, text6);
											}
										}
										goto IL_0cc7;
									}
									if (num5 <= 2745425442u)
									{
										if (num5 != 2698810085u)
										{
											if (num5 == 2745425442u && text8 == "//android.widget.EditText[@text='Enter password']")
											{
												F3913CBA = "Min@123" + Common.CreateRandomStringNumber(5);
												SendByXPath(text, F3913CBA);
												TapByXPath("//*[@text='Next']", text6);
												goto IL_0cc7;
											}
										}
										else if (text8 == "//*[@text='No thanks']")
										{
											goto IL_0cba;
										}
									}
									else if (num5 != 3054835099u)
									{
										if (num5 != 3234013380u)
										{
											if (num5 == 3691564067u && text8 == "//android.widget.EditText[@text='Email address']")
											{
												text5 = Common.A8AF5A8E((from string_0 in SetupFolder.smethod_3()
													orderby Guid.NewGuid()
													select string_0).First() + (from string_0 in SetupFolder.F68AD388()
													orderby Guid.NewGuid()
													select string_0).First()).Replace(" ", "").ToLower() + Common.CreateRandomNumber(6) + Regex.Match(input, "@\\w+.\\w+").Value;
												SendByXPath(text, text5);
												TapByXPath("//*[@text='Send code']", text6);
												goto IL_0cc7;
											}
										}
										else if (text8 == "//*[@text=\"Can't verify your phone? Use email\"]")
										{
											goto IL_0cba;
										}
									}
									else if (text8 == "//*[@text='Change email address']")
									{
										goto IL_0cba;
									}
									goto IL_0c4e;
								}
								return -2;
								IL_0cba:
								TapByXPath(text, text6);
								goto IL_0cc7;
								IL_0cc7:
								TimeDelay(1.0);
								continue;
								IL_0c4e:
								if (DoesElementExist(0, text6, "//android.widget.ImageView[@content-desc='Unlock']"))
								{
									method_47();
									method_58(string_4);
								}
								else if (text6.Contains("com.android.systemui"))
								{
									method_19();
									method_58(string_4);
								}
								else if (method_58(string_4) != 1)
								{
									goto IL_0cc7;
								}
							}
							while (Environment.TickCount - tickCount < int_4 * 1000);
							break;
						}
					}
					else if (text4 == "//*[@text='Use phone / email / username']")
					{
						goto IL_0846;
					}
				}
				else
				{
					if (num5 > 3971055724u)
					{
						if (num5 != 4180370898u)
						{
							if (num5 != 4245741645u || !(text4 == "//*[@text='Already have an account? Log in']"))
							{
								goto IL_07da;
							}
						}
						else if (!(text4 == "//android.widget.Button[@text='No thanks']"))
						{
							goto IL_07da;
						}
						goto IL_0846;
					}
					if (num5 != 3915792911u)
					{
						if (num5 == 3971055724u && text4 == "//*[@text='Email / Username']")
						{
							goto IL_0846;
						}
					}
					else if (text4 == "//*[@text='Sign up']")
					{
						if (DoesElementExist(0, text2, "//*[@text=\"When’s your birthday?\"]"))
						{
							for (int i = 1; i < 4; i++)
							{
								string string_9 = "//*[@text='Next']/parent::*/child::*[last()]/child::*/child::*[" + i + "]";
								Class65 @class = new Class65(FindElements(0, text2, string_9).First());
								int num6 = C4B7B817(1, 4);
								if (i == 3)
								{
									num6 = 4;
								}
								for (int j = 0; j < num6; j++)
								{
									method_50(@class.int_0 + 5, @class.B9898119 + 5, @class.int_1 - 5, @class.E42395AA - 5, C4B7B817(100, 200));
								}
							}
							TapByXPath("//*[@text='Next']", text2);
						}
						else if (DoesElementExist(0, text2, "//*[@content-desc='Skip' or @text='Skip']"))
						{
							TapByXPath("//*[@content-desc='Skip' or @text='Skip']", text2);
						}
						else
						{
							TapByXPath(text, text2);
						}
						goto IL_0853;
					}
				}
				goto IL_07da;
			}
			return -2;
			IL_0853:
			TimeDelay(1.0);
			continue;
			IL_0846:
			TapByXPath(text, text2);
			goto IL_0853;
			IL_05a1:
			if (num >= num2)
			{
				if (num4 != 0 || !A906F3A9())
				{
					return 7;
				}
				num4 = 1;
				method_58(FacebookPacker);
			}
			num++;
			if (text == "//*[@text=\"Sorry, unable to login. Please check your internet connection.\"]")
			{
				TapByXPath("//android.widget.Button[@text='OK']", text2);
			}
			else
			{
				TapByXPath("//*[@text='Tap to retry']", text2);
			}
			goto IL_0853;
			IL_07da:
			if (DoesElementExist(0, text2, "//android.widget.ImageView[@content-desc='Unlock']"))
			{
				method_47();
				method_58(string_4);
			}
			else if (text2.Contains("com.android.systemui"))
			{
				method_19();
				method_58(string_4);
			}
			else if (method_58(string_4) != 1)
			{
				goto IL_0853;
			}
		}
		while (Environment.TickCount - tickCount < int_4 * 1000);
		return 0;
	}

	internal int D7AD8787(string B99CF506, string F9A9A398, string string_7, int E50EACB7 = 300)
	{
		ClearDataApp(string_5);
		method_58(string_5);
		int num = 0;
		int num2 = 5;
		string text = "";
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		do
		{
			string text4;
			if (!searchComplete)
			{
				text4 = GetPageSource();
				text3 = FindElement(0, text4, new List<string>
				{
					"android.widget.ProgressBar", "//*[starts-with(@text,'Continue as')]", "//*[@text='Log in with Facebook']", "//android.widget.Button[@text='Yes, finish setup']", "//*[@text='CREATE USERNAME']", "//android.widget.Button[@text='Sign up']", "//android.widget.Button[@text='Not now']", "//android.widget.Button[@text='Skip']", "//android.widget.Button[@content-desc='Next']", "//*[@content-desc='Profile']",
					"//*[@text='If you forgot your password, you can reset it with Facebook.']", "//android.widget.Button[@text='Đăng nhập']", "//android.widget.EditText[@text='New password']", "//android.widget.Button[@text='Dismiss']", "//android.widget.Button[@text='NONE OF THE ABOVE']", "//*[@content-desc='Unplug charger' or @text='Unplug charger']", "//*[starts-with(@text,'Log into Instagram as')]", "//*[@text='Current password']", "//*[@text='An unknown network error has occurred.']", "//*[@text=\"We couldn't log you in with Facebook.\"]"
				});
				string text5 = text3;
				string text6 = text5;
				uint num3 = HashString.DA8CEBAB(text6);
				if (num3 <= 1896311505)
				{
					if (num3 <= 532719482)
					{
						if (num3 <= 203803302)
						{
							if (num3 != 101514837)
							{
								if (num3 == 203803302 && text6 == "//*[@content-desc='Profile']")
								{
									if (!(text2 != ""))
									{
										if (DoesElementExist(0, text4, "//android.widget.EditText[@text='Password']"))
										{
											text2 = "Min@123" + Common.CreateRandomStringNumber(5);
											SendByXPath("//android.widget.EditText[@text='Password']", text2);
											TapByXPath("//android.widget.Button[@text='Create']", text4);
										}
										else if (DoesElementExist(0, text4, "//*[@text='Create password']"))
										{
											TapByXPath("//*[@text='Create password']", text4);
										}
										else if (DoesElementExist(0, text4, "//*[@text='Password']"))
										{
											TapByXPath("//*[@text='Password']", text4);
										}
										else if (DoesElementExist(0, text4, "//*[@text='Security']"))
										{
											TapByXPath("//*[@text='Security']", text4);
										}
										else if (DoesElementExist(0, text4, "//android.widget.Button[@content-desc='Settings']"))
										{
											TapByXPath("//android.widget.Button[@content-desc='Settings']", text4);
										}
										else if (DoesElementExist(0, text4, "//android.widget.Button[@content-desc='Options']"))
										{
											if (text == "")
											{
												text = method_23(text4, "//android.widget.Button[@content-desc='Options']/parent::*/child::*[1]/child::*[1]/child::*[1]/child::*[1]", "text").First();
											}
											TapByXPath("//android.widget.Button[@content-desc='Options']", text4);
										}
										else
										{
											TapByXPath(text3, text4);
										}
										goto IL_06ec;
									}
									string text7 = text + "|" + text2;
									lock (object_0)
									{
										File.AppendAllText("instagram.txt", text7 + "\r\n");
									}
									return 1;
								}
							}
							else if (text6 == "//*[@text=\"We couldn't log you in with Facebook.\"]")
							{
								break;
							}
						}
						else if (num3 != 359269505)
						{
							if (num3 != 503461667)
							{
								if (num3 == 532719482 && text6 == "//android.widget.ProgressBar")
								{
									goto IL_06ec;
								}
							}
							else if (text6 == "//android.widget.Button[@text='Not now']")
							{
								goto IL_06af;
							}
						}
						else if (text6 == "//*[starts-with(@text,'Log into Instagram as')]")
						{
							break;
						}
						goto IL_0640;
					}
					if (num3 <= 1100426492)
					{
						if (num3 != 978746329)
						{
							if (num3 != 1100426492 || !(text6 == "//*[@content-desc='Unplug charger' or @text='Unplug charger']"))
							{
								goto IL_0640;
							}
							TapByXPath("//*[@content-desc='OK' or @text='OK']", text4);
						}
						else
						{
							if (!(text6 == "//*[@text='Current password']"))
							{
								goto IL_0640;
							}
							if (!DoesElementExist(0, text4, "//*[@text='If you forgot your password, you can reset it with Facebook.']"))
							{
								return 3;
							}
						}
						goto IL_06ec;
					}
					if (num3 != 1620566430)
					{
						if (num3 != 1753985601)
						{
							if (num3 != 1896311505 || !(text6 == "//android.widget.Button[@content-desc='Next']"))
							{
								goto IL_0640;
							}
						}
						else if (!(text6 == "//android.widget.Button[@text='Skip']"))
						{
							goto IL_0640;
						}
					}
					else if (!(text6 == "//*[@text='Log in with Facebook']"))
					{
						goto IL_0640;
					}
				}
				else if (num3 <= 2853230193u)
				{
					if (num3 > 2467940779u)
					{
						if (num3 != 2621521766u)
						{
							if (num3 != 2746707739u)
							{
								if (num3 != 2853230193u || !(text6 == "//*[@text='If you forgot your password, you can reset it with Facebook.']"))
								{
									goto IL_0640;
								}
								System.Drawing.Point point = new Class65(FindElements(0, text4, text3).First()).method_0();
								method_37(point.X + 200, point.Y);
							}
							else
							{
								if (!(text6 == "//android.widget.Button[@text='Đăng nhập']"))
								{
									goto IL_0640;
								}
								SendByXPath("//android.widget.EditText", F9A9A398);
								TapByXPath(text3, text4);
							}
						}
						else
						{
							if (!(text6 == "//android.widget.EditText[@text='New password']"))
							{
								goto IL_0640;
							}
							text2 = "Min@123" + Common.CreateRandomStringNumber(5);
							SendByXPath(text3, text2);
							SendByXPath("//android.widget.EditText[@text='New password, again']", text2);
							TapByXPath("//android.widget.Button[@content-desc='Done']", text4);
						}
						goto IL_06ec;
					}
					if (num3 != 2032129326)
					{
						if (num3 != 2467940779u || !(text6 == "//android.widget.Button[@text='Yes, finish setup']"))
						{
							goto IL_0640;
						}
					}
					else if (!(text6 == "//android.widget.Button[@text='Dismiss']"))
					{
						goto IL_0640;
					}
				}
				else
				{
					if (num3 <= 2915547065u)
					{
						if (num3 != 2912895069u)
						{
							if (num3 == 2915547065u && text6 == "//*[@text='CREATE USERNAME']")
							{
								text = method_23(text4, "//android.widget.EditText", "text").First();
								TapByXPath("//android.widget.Button[@text='Next']", text4);
								goto IL_06ec;
							}
						}
						else if (text6 == "//*[@text='An unknown network error has occurred.']")
						{
							break;
						}
						goto IL_0640;
					}
					if (num3 != 3036778647u)
					{
						if (num3 != 3556196668u)
						{
							if (num3 != 3850556364u || !(text6 == "//android.widget.Button[@text='Sign up']"))
							{
								goto IL_0640;
							}
						}
						else if (!(text6 == "//*[starts-with(@text,'Continue as')]"))
						{
							goto IL_0640;
						}
					}
					else if (!(text6 == "//android.widget.Button[@text='NONE OF THE ABOVE']"))
					{
						goto IL_0640;
					}
				}
				goto IL_06af;
			}
			return -2;
			IL_06ec:
			TimeDelay(1.0);
			continue;
			IL_06af:
			if (text3 == "//android.widget.Button[@text='Sign up']" || text3 == "//android.widget.Button[@text='Dismiss']")
			{
				if (num >= num2)
				{
					break;
				}
				num++;
			}
			TapByXPath(text3, text4);
			goto IL_06ec;
			IL_0640:
			if (DoesElementExist(0, text4, "//android.widget.ImageView[@content-desc='Unlock']"))
			{
				method_47();
				method_58(string_5);
			}
			else if (text4.Contains("com.android.systemui"))
			{
				method_19();
				method_58(string_5);
			}
			else if (method_58(string_5) != 1)
			{
				goto IL_06ec;
			}
		}
		while (Environment.TickCount - tickCount < E50EACB7 * 1000);
		return 0;
	}

	internal int F0065AB8(string string_7, string A81157B4, string string_8)
	{
		NoteLog("Check status...");
		int result = 0;
		method_58(FacebookPacker);
		string text = "";
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		int num4 = 6;
		int num5 = 0;
		int num6 = 1;
		while (true)
		{
			if (!searchComplete)
			{
				text = GetPageSource();
				if (!ED9CDB24(text, "Tap to view story"))
				{
					if (DoesElementExist(0, text, "//*[@text='Tap to retry']"))
					{
						if (num3 < num4)
						{
							num3++;
							CE16082B(-1);
							continue;
						}
						return 7;
					}
					if (!DoesElementExist(0, text, "//android.widget.ProgressBar"))
					{
					}
					if (ED9CDB24(text, "Save your login info"))
					{
						method_43(text, 0, "//*[@text='OK']", "//*[@text='Not now' or @content-desc='Not now']");
						result = 1;
						continue;
					}
					if (TapByXPath("//*[@text='skip']", text))
					{
						result = 1;
						continue;
					}
					if (DoesElementExist(0, text, "//android.widget.ImageView[@content-desc='Unlock']"))
					{
						method_47();
						method_58(FacebookPacker);
						continue;
					}
					if (text.Contains("com.android.systemui"))
					{
						method_19();
						method_58(FacebookPacker);
						continue;
					}
					if (FindElement(0, text, new List<string> { "//*[@text='Save your login info']", "//*[@text='Next time you log in on this phone, just tap your profile picture instead of typing a password.']" }) != "")
					{
						method_43(text, 0, "//*[@text='OK']", "//*[@text='Not now' or @content-desc='Not now']");
						method_54(2.0, 3.0);
						continue;
					}
					if (ED9CDB24(text, "Facebook isn't responding", "Facebook keeps stopping", "has stopped"))
					{
						method_43(text, 0, "//*[@text='Open app again']", "//android.widget.Button[@text='Close app']");
						if (num < num2)
						{
							if (!RestoreAppFb(string_7))
							{
								num = num2 - 1;
							}
						}
						else if (num == num2)
						{
							ClearDataApp(FacebookPacker);
						}
						else
						{
							D332771F(FacebookPacker);
							C03D049A(FileHelper.GetPathToCurrentFolder() + "\\app\\facebook.apk");
							method_11();
							C73BF637();
							method_47();
							RestoreAppFb(string_7);
						}
						num++;
						method_58(FacebookPacker);
						TimeDelay(2.0);
						continue;
					}
					if (C6BD5E0A(text))
					{
						if (num5 < num6)
						{
							num5++;
							TapByXPath("//*[@text='Close']", text);
							continue;
						}
						return 13;
					}
					if (!E2806F01(text))
					{
						if (method_68(text))
						{
							continue;
						}
						if (!method_93(text))
						{
							if (!AF365B16(text))
							{
								if (method_58(FacebookPacker) != 1)
								{
									break;
								}
								TimeDelay(3.0);
								continue;
							}
							return 0;
						}
						int num7 = AB03C014(string_7, string_7, A81157B4, string_8);
						if (num7 == 0)
						{
							return -1;
						}
						return num7;
					}
					return 2;
				}
				return 0;
			}
			return -2;
		}
		return result;
	}

	private bool method_93(string string_7)
	{
		if (string_7 == "")
		{
			string_7 = GetPageSource();
		}
		return FindElement(0, string_7, new List<string> { "//android.widget.TextView[@text='Session Expired']", "//android.widget.TextView[@text='Please log in again.']", "//android.view.ViewGroup[@content-desc='Reload Menu']", "//*[@text='Log Into Another Account']", "//*[@text='Find Your Account']" }) != "";
	}

	internal void method_94(string string_7, string AB3DA011)
	{
		string text = RunCMD("shell pm path " + string_7);
		text = text.Split('\n')[0];
		text = text.Substring(text.IndexOf(":") + 1);
		text = RunCMD("pull " + text + " " + AB3DA011);
	}

	private void method_95(string E91709A6)
	{
		string text = RunCMD("shell ls " + E91709A6);
		List<string> list = (from B91B3085 in text.Split(new string[2]
			{
				Environment.NewLine,
				"\n"
			}, StringSplitOptions.None)
			where !string.IsNullOrEmpty(B91B3085)
			select B91B3085).ToList();
		string bA32E58D = "shell su -c rm -rf /" + E91709A6 + "/*";
		RunCMD(bA32E58D);
		bA32E58D = "shell su -c rm -r /" + E91709A6 + "/.thumbnails";
		RunCMD(bA32E58D);
		foreach (string item in list)
		{
			RunCMD("shell am broadcast -a android.intent.action.MEDIA_SCANNER_SCAN_FILE -d \"file:///mnt/" + E91709A6 + "/" + Path.GetFileName(item) + "\"");
		}
	}

	internal void method_96(List<string> list_0)
	{
		NoteLog("Up ảnh...");
		method_95("sdcard/dcim/camera");
		method_95("sdcard/pictures");
		method_95("sdcard/movies");
		foreach (string item in list_0)
		{
			string text = Common.CreateRandomString(10).TrimEnd('.') + "." + Path.GetExtension(item).TrimStart('.');
			RunCMD("push \"" + item + "\" \"/sdcard/pictures/" + text + "\"", 300);
			RunCMD("shell am broadcast -a android.intent.action.MEDIA_SCANNER_SCAN_FILE -d \"file:///mnt/sdcard/pictures/" + text + "\"");
		}
	}

	internal bool method_97()
	{
		List<string> list = method_120();
		if (list.Contains("com.minsoftware.maxchanger"))
		{
			D332771F("com.minsoftware.maxchanger");
		}
		if (!list.Contains("ru.andr7e.deviceinfohw"))
		{
			C03D049A(FileHelper.GetPathToCurrentFolder() + "\\app\\DeviceInfoHW.apk");
		}
		C03D049A(FileHelper.GetPathToCurrentFolder() + "\\app\\maxchange.apk");
		TimeDelay(2.0);
		TapByXPath("//android.widget.Button[@text='INSTALL ANYWAY']");
		RunCMD("shell am start -n com.android.shell/.BugreportWarningActivity -c org.lsposed.manager.LAUNCH_MANAGER -p com.android.shell -a android.intent.action.MAIN");
		TimeDelay(2.0);
		RunCMD("shell pm grant com.minsoftware.maxchanger android.permission.READ_EXTERNAL_STORAGE");
		RunCMD("shell pm grant com.minsoftware.maxchanger android.permission.WRITE_EXTERNAL_STORAGE");
		string text = "facebook";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		while (!searchComplete)
		{
			text2 = GetPageSource();
			text3 = FindElement(0, text2, new List<string> { "//android.widget.EditText[@text='Search…']", "//android.widget.Switch[@text='ON']", "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='true']", "//android.widget.Switch[@text='OFF']", "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='false']", "//android.widget.TextView[@text='MaxChanger']", "//android.widget.FrameLayout[contains(@content-desc,'Modules')]" });
			string text4 = text3;
			string text5 = text4;
			uint num2 = HashString.DA8CEBAB(text5);
			if (num2 <= 1582824711)
			{
				if (num2 <= 1265225096)
				{
					if (num2 != 141461479)
					{
						if (num2 == 1265225096 && text5 == "//android.widget.TextView[@text='MaxChanger']")
						{
							goto IL_0348;
						}
					}
					else if (text5 == "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='false']")
					{
						goto IL_0348;
					}
				}
				else if (num2 != 1397864407)
				{
					if (num2 == 1582824711 && text5 == "//android.widget.Switch[@text='ON']")
					{
						goto IL_029c;
					}
				}
				else if (text5 == "//android.widget.FrameLayout[contains(@content-desc,'Modules')]")
				{
					if (flag)
					{
						TapByXPath("//*[@content-desc='More options']/parent::*/child::*[1]", text2);
					}
					else
					{
						flag = true;
						TapByXPath(text3, text2);
					}
				}
			}
			else if (num2 <= 2084351161)
			{
				if (num2 != 1926143043)
				{
					if (num2 == 2084351161 && text5 == "//android.widget.EditText[@text='Search…']")
					{
						SendByXPath("//android.widget.EditText[@text='Search…']", text);
					}
				}
				else if (text5 == "//*[@content-desc='More options']/parent::*/child::*[1]")
				{
					goto IL_0348;
				}
			}
			else if (num2 != 2687307995u)
			{
				if (num2 == 4211664092u && text5 == "//android.widget.Switch[@resource-id='android:id/toggle'][@checked='true']")
				{
					goto IL_029c;
				}
			}
			else if (text5 == "//android.widget.Switch[@text='OFF']")
			{
				goto IL_0348;
			}
			goto IL_0355;
			IL_0348:
			TapByXPath(text3, text2);
			goto IL_0355;
			IL_029c:
			if (!DoesElementExist(0, text2, "//android.widget.textview[contains(@text,'" + text + "')]/parent::*/android.widget.checkbox"))
			{
				TapByXPath("//androidx.appcompat.widget.LinearLayoutCompat[@class='androidx.appcompat.widget.LinearLayoutCompat']/android.widget.TextView", text2);
			}
			else
			{
				if (DoesElementExist(0, text2, "//android.widget.TextView[contains(@text,'" + text + "')]/parent::*/android.widget.checkbox[@checked='false']"))
				{
					TapByXPath("//android.widget.TextView[contains(@text,'" + text + "')]", text2);
				}
				method_31("//android.widget.EditText");
				if (text == "facebook")
				{
					text = "device info hw";
				}
				else
				{
					if (!(text == "device info hw"))
					{
						return true;
					}
					text = "System";
				}
			}
			goto IL_0355;
			IL_0355:
			TimeDelay(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	internal bool method_98()
	{
		List<string> list = method_121();
		foreach (string string_0 in list)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				RunCMD("shell am start -n " + string_0 + "/v.q -c android.intent.category.LAUNCHER -a android.intent.action.MAIN");
			});
			thread.IsBackground = true;
			thread.Start();
		}
		TimeDelay(2.0);
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		bool flag = false;
		while (!searchComplete)
		{
			text = GetPageSource();
			text2 = FindElement(0, text, new List<string> { "//android.widget.TextView[@text='No apps have asked for Superuser permission yet.']", "//android.widget.TextView[@text='Shell']/parent::*/*[@text='OFF']", "//android.widget.TextView[@text='Shell']/parent::*/*[@text='ON']", "//android.widget.FrameLayout[@content-desc='Superuser']", "//android.widget.TextView[@content-desc='Settings']", "//android.widget.TextView[@text='Settings']", "//android.widget.TextView[@text='Grant']" });
			string text3 = text2;
			string text4 = text3;
			uint num2 = HashString.DA8CEBAB(text4);
			if (num2 <= 1133221858)
			{
				switch (num2)
				{
				case 1133221858u:
					if (!(text4 == "//android.widget.TextView[@text='Grant']"))
					{
						break;
					}
					TapByXPath(text2, text);
					return true;
				case 829350801u:
					if (!(text4 == "//android.widget.TextView[@text='Settings']"))
					{
						break;
					}
					while (!TapByXPath("//android.widget.TextView[@text='Automatic Response']"))
					{
						if (CE16082B())
						{
							return false;
						}
					}
					break;
				case 184981057u:
					if (text4 == "//android.widget.FrameLayout[@content-desc='Superuser']")
					{
						if (flag)
						{
							TapByXPath("//android.widget.TextView[@content-desc='Settings']");
							break;
						}
						TapByXPath(text2, text);
						flag = true;
					}
					break;
				}
			}
			else if (num2 <= 2493362195u)
			{
				if (num2 != 1228394547)
				{
					if (num2 == 2493362195u && text4 == "//android.widget.TextView[@text='Shell']/parent::*/*[@text='OFF']")
					{
						goto IL_0202;
					}
				}
				else if (text4 == "//android.widget.TextView[@content-desc='Settings']")
				{
					goto IL_0202;
				}
			}
			else if (num2 != 3190033371u)
			{
				if (num2 == 3353998111u && text4 == "//android.widget.TextView[@text='Shell']/parent::*/*[@text='ON']")
				{
					goto IL_0242;
				}
			}
			else if (text4 == "//android.widget.TextView[@text='No apps have asked for Superuser permission yet.']")
			{
				goto IL_0242;
			}
			goto IL_0253;
			IL_0242:
			method_19();
			goto IL_0253;
			IL_0202:
			TapByXPath(text2, text);
			goto IL_0253;
			IL_0253:
			TimeDelay(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	internal bool method_99()
	{
		if (method_120().Contains("com.builuc1998.max_mobile_app"))
		{
			D332771F("com.builuc1998.max_mobile_app");
		}
		C03D049A(FileHelper.GetPathToCurrentFolder() + "\\app\\maxhelper.apk");
		TimeDelay(2.0);
		RunCMD("shell am start -a android.settings.ACCESSIBILITY_SETTINGS");
		TimeDelay(2.0);
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		while (!searchComplete)
		{
			text = GetPageSource();
			text2 = FindElement(0, text, new List<string> { "//android.widget.Button[@resource-id='com.android.settings:id/permission_disable_stop_button']", "//android.widget.Button[@resource-id='com.android.settings:id/permission_enable_allow_button']", "//android.widget.Switch[@resource-id='com.android.settings:id/switch_widget'][@checked='true']", "//android.widget.Switch[@resource-id='com.android.settings:id/switch_widget'][@checked='false']", "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='true']", "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='false']", "//android.widget.TextView[@text='max_mobile_app']", "//android.widget.Button[@text='OK']", "//android.widget.Button[@text='Got it']" });
			string text3 = text2;
			string text4 = text3;
			uint num2 = HashString.DA8CEBAB(text4);
			if (num2 <= 2286921084u)
			{
				if (num2 <= 675693509)
				{
					if (num2 != 366645833)
					{
						if (num2 == 675693509 && text4 == "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='true']")
						{
							goto IL_0287;
						}
					}
					else if (text4 == "//android.widget.TextView[@text='max_mobile_app']")
					{
						goto IL_0230;
					}
				}
				else if (num2 != 1232705540)
				{
					if (num2 == 2286921084u && text4 == "(//*[@text='Use max_mobile_app']/parent::*/parent::*/child::*/child::*)[last()][@checked='false']")
					{
						goto IL_0230;
					}
				}
				else if (text4 == "//android.widget.Switch[@resource-id='com.android.settings:id/switch_widget'][@checked='false']")
				{
					goto IL_0230;
				}
			}
			else if (num2 <= 2609368340u)
			{
				if (num2 != 2593255712u)
				{
					if (num2 == 2609368340u && text4 == "//android.widget.Button[@resource-id='com.android.settings:id/permission_disable_stop_button']")
					{
						goto IL_0287;
					}
				}
				else if (text4 == "//android.widget.Button[@text='OK']")
				{
					goto IL_0230;
				}
			}
			else if (num2 != 2614915793u)
			{
				if (num2 != 3036346468u)
				{
					if (num2 == 3445947035u && text4 == "//android.widget.Switch[@resource-id='android:id/switch_widget'][@checked='true']")
					{
						goto IL_0287;
					}
				}
				else if (text4 == "//android.widget.Button[@resource-id='com.android.settings:id/permission_enable_allow_button']")
				{
					goto IL_0230;
				}
			}
			else if (text4 == "//android.widget.Button[@text='Got it']")
			{
				goto IL_0230;
			}
			goto IL_0259;
			IL_0259:
			TimeDelay(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
			continue;
			IL_0287:
			return true;
			IL_0230:
			TapByXPath(text2, text);
			if (text2 == "//android.widget.Button[@resource-id='com.android.settings:id/permission_enable_allow_button']" || text2 == "//android.widget.Button[@text='OK']")
			{
				return true;
			}
			goto IL_0259;
		}
		return false;
	}

	internal bool method_100(int FE91FE35 = 300)
	{
		string value = Regex.Match(RunCMD("shell \"dumpsys account | grep Accounts:\""), "\\d+").Value;
		if (Common.smethod_29(value) == 0)
		{
			return true;
		}
		RunCMD("shell am start -a android.settings.SYNC_SETTINGS");
		TimeDelay(2.0);
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		while (!searchComplete)
		{
			text = GetPageSource();
			text2 = FindElement(0, text, new List<string> { "//*[@text='Remove account']", "//*[@text='Facebook']", "//*[@text='Add account']" });
			switch (text2)
			{
			case "//*[@text='Facebook']":
			case "//*[@text='Remove account']":
				TapByXPath(text2, text);
				break;
			case "//*[@text='Add account']":
				return true;
			}
			TimeDelay(1.0);
			if (Environment.TickCount - tickCount >= FE91FE35 * 1000)
			{
				break;
			}
		}
		return false;
	}

	internal bool method_101(int int_3 = 300)
	{
		RunCMD("shell am start -a android.settings.WIFI_SETTINGS");
		TimeDelay(2.0);
		bool flag = false;
		for (int i = 0; i < 10; i++)
		{
			if (!method_40(0, "//*[@text='Saved networks']", ""))
			{
				if (CE16082B(1, 1, 500))
				{
					break;
				}
				TimeDelay(2.0);
				continue;
			}
			flag = true;
			break;
		}
		if (flag)
		{
			TimeDelay(2.0);
			string text = "";
			string text2 = "";
			int tickCount = Environment.TickCount;
			while (!searchComplete)
			{
				text = GetPageSource();
				text2 = FindElement(0, text, new List<string> { "//*[contains(@content-desc,',Secure network')]", "//android.widget.Button[@text='Forget']" });
				string text3 = text2;
				string text4 = text3;
				if (!(text4 == "//android.widget.Button[@text='Forget']") && !(text4 == "//*[contains(@content-desc,',Secure network')]"))
				{
					break;
				}
				TapByXPath(text2, text);
				TimeDelay(2.0);
				if (Environment.TickCount - tickCount >= int_3 * 1000)
				{
					break;
				}
			}
		}
		return true;
	}

	public bool ED9CDB24(string DB92C587, params string[] string_7)
	{
		if (DB92C587 == "")
		{
			DB92C587 = GetPageSource();
		}
		DB92C587 = DB92C587.ToLower();
		int num = 0;
		while (true)
		{
			if (num < string_7.Length)
			{
				if (DB92C587.Contains(string_7[num].ToLower()))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public bool method_102(int int_3, string string_7, params string[] C42C3A1D)
	{
		try
		{
			int tickCount = Environment.TickCount;
			while (!searchComplete)
			{
				if (string_7 == "")
				{
					string_7 = GetPageSource();
				}
				if (!ED9CDB24(string_7, C42C3A1D))
				{
					string_7 = "";
					if (Environment.TickCount - tickCount < int_3 * 1000)
					{
						TimeDelay(1.0);
						continue;
					}
					break;
				}
				return true;
			}
		}
		catch (Exception exception_)
		{
			B6924899(exception_);
		}
		return false;
	}
    public bool BF09921B(string string_8, string string_9, int int_2 = 500)
    {
        System.Drawing.Point point = method_51(string_8);
        int x = point.X;
        int y = point.Y;
        System.Drawing.Point point2 = method_51(string_9);
        int x2 = point2.X;
        int y2 = point2.Y;
        return method_50(x, y, x2, y2, int_2);
    }

    internal bool SetLanguage2()
	{
        RunCMD("shell am start -a android.settings.LOCALE_SETTINGS");
        string text = "";
        string text2 = "";
        int tickCount = Environment.TickCount;
        int num = 300;
        while (!searchComplete)
        {
            text = GetPageSource();
            text2 = FindElement(0, text, new List<string> { "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']", "//android.widget.TextView[@text='United States']", "//android.widget.TextView[@resource-id='android:id/locale_search_menu']", "//android.widget.EditText[@resource-id='android:id/search_src_text']", "//android.widget.Button[@resource-id='com.android.settings:id/add_language']" });
            switch (text2)
            {
                case "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']":
                    if (!DoesElementExist(0, text, "//android.widget.TextView[@text='Languages']"))
                    {
                        if (text.Contains("English"))
                        {
                            List<string> list = FindElements(0, text, "//android.widget.ImageView[@resource-id='com.android.settings:id/dragHandle']");
                            if (list.Count > 1)
                            {
                                string string_ = list.Last();
                                string string_2 = FindElements(0, text, "//android.view.ViewGroup[@resource-id='com.android.settings:id/action_bar']/android.widget.LinearLayout/android.widget.ImageButton").First();
                                BF09921B(string_, string_2);
                                return true;
                            }
                        }
                        method_41("//android.widget.Button[@resource-id='com.android.settings:id/add_language']");
                        break;
                    }
                    return true;
                case "//android.widget.EditText[@resource-id='android:id/search_src_text']":
                    SendByXPath(text2, "English");
                    TimeDelay(2.0);
                    method_40(5, "//android.widget.TextView[@resource-id='android:id/locale']", "");
                    break;
                case "//android.widget.TextView[@resource-id='android:id/locale_search_menu']":
                case "//android.widget.TextView[@text='United States']":
                    TapByXPath(text2, text);
                    break;
                case "//android.widget.Button[@resource-id='com.android.settings:id/add_language']":
                    if (!text.Contains("English (United States)"))
                    {
                        TapByXPath(text2, text);
                        break;
                    }
                    return true;
            }
            TimeDelay(1.0);
            if (Environment.TickCount - tickCount >= num * 1000)
            {
                break;
            }
        }
        return false;
    }

	public List<string> EA82A612()
	{
		List<string> source = method_120();
		return source.Where((string FE18813D) => FE18813D.StartsWith("com.facebook.ka")).ToList();
	}

	public List<string> method_104(string string_7 = "", int int_3 = 0)
	{
		if (string_7 == "")
		{
			string_7 = GetPageSource().ToLower();
		}
		List<string> collection = method_106(string_7, "text=\"(.*?)\"");
		List<string> collection2 = method_106(string_7, "content-desc=\"(.*?)\"");
		List<string> collection3 = method_106(string_7, "text='(.*?)'");
		List<string> collection4 = method_106(string_7, "content-desc='(.*?)'");
		List<string> list = new List<string>();
		switch (int_3)
		{
		case 0:
			list.AddRange(collection);
			list.AddRange(collection2);
			list.AddRange(collection3);
			list.AddRange(collection4);
			break;
		case 1:
			list.AddRange(collection);
			list.AddRange(collection3);
			break;
		case 2:
			list.AddRange(collection2);
			list.AddRange(collection4);
			break;
		}
		return list;
	}

	public string method_105(string string_7)
	{
		string text = method_104(string_7).FirstOrDefault();
		if (string.IsNullOrEmpty(text))
		{
			text = "";
		}
		return text;
	}

	private List<string> method_106(string string_7, string string_8)
	{
		List<string> list = new List<string>();
		try
		{
			MatchCollection matchCollection = Regex.Matches(string_7, string_8);
			for (int i = 0; i < matchCollection.Count; i++)
			{
				if (!string.IsNullOrEmpty(matchCollection[i].Groups[1].Value))
				{
					list.Add(matchCollection[i].Groups[1].Value);
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	private bool method_107()
	{
		return RunCMD("shell settings get global airplane_mode_on").Contains("1");
	}

	private void method_108()
	{
		RunCMD("shell settings put global airplane_mode_on 1");
		TimeDelay(1.0);
		RunCMD("shell su -c am broadcast -a android.intent.action.AIRPLANE_MODE --ez state true");
	}

	private void method_109()
	{
		RunCMD("shell settings put global airplane_mode_on 0");
		TimeDelay(1.0);
		RunCMD("shell su -c am broadcast -a android.intent.action.AIRPLANE_MODE --ez state false");
	}

	public void FF8D742A()
	{
		RunCMD("shell su -c 'svc nfc disable'");
	}

	public void method_110()
	{
		RunCMD("shell su -c 'svc wifi disable'");
	}

	public void method_111()
	{
		RunCMD("shell su -c 'svc wifi enable'");
	}

	public void ABA3A8B5()
	{
		RunCMD("shell settings put secure location_mode 0");
	}

	public void method_112()
	{
		RunCMD("shell settings put secure location_mode 1");
	}

	internal bool A906F3A9()
	{
		RemoveProxy();
		int num = 0;
		while (true)
		{
			if (num < 3)
			{
				if (!method_107())
				{
					method_108();
					TimeDelay(2.0);
				}
				method_109();
				if (DC949F30(60))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public bool method_113()
	{
		string text = "";
		for (int i = 0; i < 10; i++)
		{
			text = RunCMD("shell \"dumpsys power | grep 'Display Power' | grep -oE '(ON|OFF)'\"").Trim();
			if (text != "")
			{
				break;
			}
		}
		return text == "OFF";
	}

	public string BC0B8D27(int BA2DE4AC = 10)
	{
		string text = "";
		string text2 = "";
		string text3 = "ifconfig.co";
		while (true)
		{
			text2 = ((!(Proxy != "") || Proxy.Split(':').Length != 2) ? ("shell curl -s -H 'Cache-Control: no-cache' " + text3) : ("shell curl -s -H 'Cache-Control: no-cache' " + text3 + " -x \"" + Proxy + "\""));
			int tickCount = Environment.TickCount;
			while (true)
			{
				text = RunCMD(text2).ToLower();
				if (!text.Contains("you have authenticated yourself"))
				{
					if (text.Contains("html") || text.Contains("document"))
					{
						if (text3 != "v4v6.ipv6-test.com/api/myip.php")
						{
							break;
						}
						text = "";
					}
					TimeDelay(1.0);
					if (text == "" && Environment.TickCount - tickCount < BA2DE4AC * 1000)
					{
						continue;
					}
				}
				else
				{
					text = "Proxy Authentication Required";
				}
				return text;
			}
			text3 = "v4v6.ipv6-test.com/api/myip.php";
		}
	}

	public bool DC949F30(int int_3 = 15)
	{
		if (Base.bool_1)
		{
			return true;
		}
		int tickCount = Environment.TickCount;
		do
		{
			string text = RunCMD("shell curl -s -H 'Cache-Control: no-cache' \"facebook.com\"");
			if (!(text != ""))
			{
				TimeDelay(2.0);
				continue;
			}
			return true;
		}
		while (Environment.TickCount - tickCount < int_3 * 1000);
		return false;
	}

	public void method_114(string string_7 = "https://ifconfig.co/")
	{
		RunCMD("shell am start -a android.intent.action.VIEW -d \"" + string_7 + "\"");
	}

	public string B61C2D0E()
	{
		string text = "";
		try
		{
			for (int i = 0; i < 3; i++)
			{
				try
				{
					text = RunCMD("shell \"uiautomator dump && cat /sdcard/window_dump.xml && rm /sdcard/window_dump.xml\"").ToLower();
					text = Regex.Match(text, "<\\?xml(.*?)</hierarchy>").Value;
					if (text.Trim() != "")
					{
						break;
					}
					Thread.Sleep(1000);
					continue;
				}
				catch
				{
					continue;
				}
			}
		}
		catch
		{
		}
		return text;
	}

	public string method_115()
	{
		string text = "";
		try
		{
			for (int i = 0; i < 3; i++)
			{
				try
				{
					text = RunCMD("shell \"dumpsys activity | grep top-activity\"").ToLower();
					text = Regex.Match(text, "com(.*?)/").Value.TrimEnd('/');
					if (text.Trim() != "")
					{
						break;
					}
					Thread.Sleep(1000);
					continue;
				}
				catch
				{
					continue;
				}
			}
		}
		catch
		{
		}
		return text;
	}

	public string method_116(string EA1A3F8E)
	{
		string text = "";
		try
		{
			for (int i = 0; i < 3; i++)
			{
				try
				{
					text = RunCMD("shell \"dumpsys package " + EA1A3F8E + " | grep versionName\"").ToLower();
					text = text.Split('=')[1];
					if (text.Trim() != "")
					{
						break;
					}
					Thread.Sleep(1000);
					continue;
				}
				catch
				{
					continue;
				}
			}
		}
		catch
		{
		}
		return text;
	}

	public void NoteLog(string string_7)
	{
	}

	internal bool CFBCF2A7(int BF1D3D98)
	{
		RunCMD("shell am start -a android.settings.NETWORK_OPERATOR_SETTINGS");
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		bool flag = false;
		int num2 = 0;
		int num3 = 2;
		while (!searchComplete)
		{
			text = GetPageSource();
			text2 = FindElement(0, text, new List<string> { "//android.widget.TextView[@text='Advanced']", "//android.widget.TextView[@text='Access Point Names']", "//android.widget.RadioButton[@resource-id='com.android.settings:id/apn_radiobutton']", "//android.widget.CheckedTextView[@class='android.widget.CheckedTextView']", "//android.widget.TextView[@text='APN protocol']", "//android.widget.TextView[@text='Save']" });
			switch (text2)
			{
			default:
				if (CE16082B())
				{
					if (num2 >= num3)
					{
						return false;
					}
					num2++;
				}
				break;
			case "//android.widget.RadioButton[@resource-id='com.android.settings:id/apn_radiobutton']":
			{
				Class65 @class = new Class65(FindElements(0, text, text2).First());
				System.Drawing.Point point = @class.method_0();
				method_37(point.X - 300, point.Y);
				break;
			}
			case "//android.widget.CheckedTextView[@class='android.widget.CheckedTextView']":
				TapByXPath($"({text2})[{BF1D3D98}]", text);
				flag = true;
				break;
			case "//android.widget.TextView[@text='APN protocol']":
				if (flag)
				{
					TapByXPath("//android.widget.ImageButton[@content-desc='More options']");
				}
				else
				{
					TapByXPath(text2, text);
				}
				break;
			case "//android.widget.TextView[@text='Advanced']":
			case "//android.widget.TextView[@text='Access Point Names']":
				TapByXPath(text2, text);
				break;
			case "//android.widget.TextView[@text='Save']":
				TapByXPath(text2, text);
				return true;
			}
			TimeDelay(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	internal bool method_117()
	{
		RunCMD("shell am start -a android.settings.NETWORK_OPERATOR_SETTINGS");
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		int num2 = 0;
		int num3 = 2;
		while (!searchComplete)
		{
			text = GetPageSource();
			text2 = FindElement(0, text, new List<string> { "//*[@text='Preferred network type']" });
			string text3 = text2;
			string text4 = text3;
			if (!(text4 == "//*[@text='Preferred network type']"))
			{
				if (CE16082B())
				{
					if (num2 >= num3)
					{
						return false;
					}
					num2++;
				}
			}
			else
			{
				if (DoesElementExist(0, text, "//android.widget.CheckedTextView[contains(@text,'LTE')]"))
				{
					FB3ACF2E(-1, 4);
					TimeDelay(1.0);
					FB3ACF2E(1, C4B7B817(0, 4));
					E832B991(FindElements(0, "", "//android.widget.CheckedTextView[contains(@text,'LTE')]").smethod_8());
					TimeDelay(1.0);
					return true;
				}
				TapByXPath(text2, text);
			}
			TimeDelay(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	internal bool F487A3B3()
	{
		RunCMD("shell am start -a android.settings.ZEN_MODE_PRIORITY_SETTINGS");
		string text = "";
		string text2 = "";
		int tickCount = Environment.TickCount;
		int num = 300;
		int num2 = 0;
		int num3 = 2;
		while (!searchComplete)
		{
			text = GetPageSource();
			text2 = FindElement(0, text, new List<string> { "//android.widget.Button[@text='Turn on now']", "//android.widget.Button[@text='Turn off now']" });
			string text3 = text2;
			string text4 = text3;
			if (!(text4 == "//android.widget.Button[@text='Turn on now']"))
			{
				if (text4 == "//android.widget.Button[@text='Turn off now']")
				{
					return true;
				}
				if (CE16082B())
				{
					if (num2 >= num3)
					{
						return false;
					}
					num2++;
				}
			}
			else
			{
				TapByXPath(text2, text);
			}
			TimeDelay(1.0);
			if (Environment.TickCount - tickCount >= num * 1000)
			{
				break;
			}
		}
		return false;
	}

	internal List<string> method_118(List<string> list_0)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		foreach (string item in list_0)
		{
			list2.Add(new Class65(item).int_0.ToString());
		}
		string s = "";
		int num = 0;
		foreach (IGrouping<string, string> item2 in from AB151FB5 in list2
			group AB151FB5 by AB151FB5)
		{
			if (item2.Count() > num)
			{
				s = item2.Key;
				num = item2.Count();
			}
		}
		foreach (string item3 in list_0)
		{
			if (new Class65(item3).int_0 == int.Parse(s))
			{
				list.Add(item3);
			}
		}
		return list;
	}

	internal bool EA8FBE3D()
	{
		RunCMD("shell am start -a android.settings.DISPLAY_SETTINGS");
		int tickCount = Environment.TickCount;
		while (!searchComplete)
		{
			string string_ = GetPageSource();
			string text = FindElement(0, string_, new List<string> { "//android.widget.Switch[@content-desc='Dark theme'][@text='ON']", "//android.widget.Switch[@content-desc='Dark theme'][@text='OFF']" });
			string text2 = text;
			string text3 = text2;
			if (!(text3 == "//android.widget.Switch[@content-desc='Dark theme'][@text='OFF']"))
			{
				if (text3 == "//android.widget.Switch[@content-desc='Dark theme'][@text='ON']")
				{
					return true;
				}
			}
			else
			{
				TapByXPath(text, string_);
			}
			TimeDelay(1.0);
			if (Environment.TickCount - tickCount >= 60000)
			{
				break;
			}
		}
		return false;
	}

	internal bool E70E801F()
	{
		RunCMD("shell am start -a android.settings.SECURITY_SETTINGS");
		int tickCount = Environment.TickCount;
		while (!searchComplete)
		{
			string text = GetPageSource();
			string text2 = FindElement(0, text, new List<string> { "//*[@text='Screen lock']", "//*[@text='Choose screen lock']" });
			string text3 = text2;
			string text4 = text3;
			if (!(text4 == "//*[@text='Screen lock']"))
			{
				if (text4 == "//*[@text='Choose screen lock']")
				{
					TapByXPath("//*[@text='None']", text);
				}
			}
			else
			{
				if (DoesElementExist(0, text, "//*[@text='None']"))
				{
					return true;
				}
				TapByXPath(text2, text);
			}
			TimeDelay(2.0);
			if (Environment.TickCount - tickCount >= 60000)
			{
				break;
			}
		}
		return false;
	}

	internal bool E404D302()
	{
		RunCMD("shell am start -S \"com.android.settings/.Settings\\$DeviceAdminSettingsActivity\"");
		int tickCount = Environment.TickCount;
		while (!searchComplete)
		{
			string string_ = GetPageSource();
			string text = FindElement(0, string_, new List<string> { "//android.widget.Switch[@text='ON']", "//android.widget.Switch[@text='OFF']", "//*[@text='Activate this device admin app']", "//*[@text='No device admin apps available']" });
			switch (text)
			{
			case "//android.widget.Switch[@text='OFF']":
			case "//*[@text='Activate this device admin app']":
				TapByXPath(text, string_);
				break;
			case "//*[@text='No device admin apps available']":
			case "//android.widget.Switch[@text='ON']":
				return true;
			}
			TimeDelay(2.0);
			if (Environment.TickCount - tickCount >= 60000)
			{
				break;
			}
		}
		return false;
	}

	internal string method_119()
	{
		string input = RunCMD("shell dumpsys display");
		string value = Regex.Match(input, "deviceWidth=\\d+").Value;
		value = Regex.Match(value, "\\d+").Value;
		string value2 = Regex.Match(input, "deviceHeight=\\d+").Value;
		value2 = Regex.Match(value2, "\\d+").Value;
		return value + "x" + value2;
	}

	public List<string> method_120()
	{
		List<string> result = new List<string>();
		string text = RunCMD("shell pm list packages").Replace("package:", "").Trim();
		if (text != "" && text != "not found emulator!")
		{
			result = text.Split('\n').ToList();
		}
		return result;
	}

	public List<string> method_121()
	{
		List<string> result = new List<string>();
		string text = RunCMD("shell pm list packages -3").Replace("package:", "").Trim();
		if (text != "" && text != "not found emulator!")
		{
			result = text.Split('\n').ToList();
		}
		return result;
	}

	public bool C03D049A(string string_7)
	{
		RunCMD("shell settings put global verifier_verify_adb_installs 0");
		RunCMD("install \"" + string_7 + "\"", 120);
		return true;
	}

	public void method_122(string string_7)
	{
		try
		{
			string text = String_1;
			string text2 = "CheckDevice";
			Common.CreateFolder(text2);
			Common.CreateFolder(text2 + "\\" + text);
			string_7 = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + "- " + string_7;
			File.AppendAllText(text2 + "\\" + text + "\\note.txt", string_7 + "\r\n");
		}
		catch
		{
		}
	}

	public string method_123(string BA1D029F = "")
	{
		try
		{
			string text = String_1;
			string text2 = BA1D029F + "_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
			text2 = text2.Trim('_');
			string text3 = "CheckDevice";
			Common.CreateFolder(text3);
			Common.CreateFolder(text3 + "\\" + text);
			method_87().Save(text3 + "\\" + text + "\\" + text2 + ".png");
			File.AppendAllText(text3 + "\\" + text + "\\" + text2 + ".txt", method_15() + "\r\n");
			File.AppendAllText(text3 + "\\" + text + "\\" + text2 + ".txt", GetPageSource());
			return text2;
		}
		catch
		{
		}
		return BA1D029F;
	}

	public void B1BACBA0(string string_7 = "")
	{
		if (string_7 == "")
		{
			string_7 = GetPageSource();
		}
		EA987635 = string_7;
	}

	public bool A92BECA1(int int_3, ref string string_7)
	{
		int tickCount = Environment.TickCount;
		while (!searchComplete)
		{
			if (string_7 == "")
			{
				string_7 = GetPageSource();
			}
			if (!(EA987635 != string_7))
			{
				if (int_3 == 0)
				{
					break;
				}
				TimeDelay(1.0);
				string_7 = "";
				if (Environment.TickCount - tickCount >= int_3 * 1000)
				{
					break;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	public bool BB2F8438(int CB30E62F = 0, string AC1A33B4 = "")
	{
		return A92BECA1(CB30E62F, ref AC1A33B4);
	}
}
