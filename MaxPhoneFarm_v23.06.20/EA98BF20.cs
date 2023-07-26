using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

internal class EA98BF20
{
	[CompilerGenerated]
	private sealed class DC034420
	{
		internal List<string> list_0;

		internal string string_0;

		internal string string_1;

		internal string EBAC7137;

		internal int int_0;
	}

	[CompilerGenerated]
	private sealed class Class25
	{
		internal int BF85B329;

		internal DC034420 dc034420_0;
	}

	[CompilerGenerated]
	private sealed class E930E410
	{
		internal int int_0;

		internal Class25 class25_0;

		internal void E80A2E26()
		{
			string text = class25_0.dc034420_0.list_0[int_0];
			bool flag = true;
			try
			{
				string text2 = text.Split('|')[0];
				RequestXNet b01F5C = new RequestXNet(class25_0.dc034420_0.string_0, class25_0.dc034420_0.string_1, class25_0.dc034420_0.EBAC7137, class25_0.dc034420_0.int_0);
				string text3 = b01F5C.RequestGet("https://mobile.facebook.com/groups/" + text2 + "/madminpanel");
				flag = text3.Contains("madminpanel/pending/");
			}
			catch
			{
			}
			class25_0.dc034420_0.list_0[int_0] = $"{text}|{flag}";
			Interlocked.Decrement(ref class25_0.BF85B329);
		}
	}

	public static List<string> smethod_0(string string_0, string A4B36683, int D91E75B2)
	{
		List<string> result = new List<string>();
		try
		{
			RequestXNet b01F5C = new RequestXNet(string_0, "", A4B36683, D91E75B2);
			string input = b01F5C.RequestGet("https://mbasic.facebook.com/pages/?viewallpywo=1");
			List<string> list = new List<string>();
			MatchCollection matchCollection = Regex.Matches(input, "page_suggestion_(\\d+)\"");
			foreach (Match item in matchCollection)
			{
				list.Add(item.Groups[1].Value);
			}
			List<string> list2 = new List<string>();
			matchCollection = Regex.Matches(input, "id=(\\d+)&");
			foreach (Match item2 in matchCollection)
			{
				list2.Add(item2.Groups[1].Value);
			}
			result = list.Except(list2).ToList();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static List<string> smethod_1(string EF90C628, string string_0, int int_0, bool E18D752E)
	{
		List<string> list = new List<string>();
		try
		{
			string value = Regex.Match(EF90C628, "c_user=(\\d+)").Groups[1].Value;
			RequestXNet b01F5C = new RequestXNet(EF90C628, "", string_0, int_0);
			if (E18D752E)
			{
				string input = b01F5C.RequestGet("https://mobile.facebook.com/help/");
				string value2 = Regex.Match(input, "fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
				input = b01F5C.method_1("https://www.facebook.com/api/graphql/", "q=nodes(" + value + "){groups{nodes{id,name,viewer_post_status,visibility,group_member_profiles{count}}}}&fb_dtsg=" + value2).Replace("for (;;);", "");
				JObject jObject = JObject.Parse(input);
				foreach (JToken item in (IEnumerable<JToken>)(jObject[value]!["groups"]!["nodes"]!))
				{
					try
					{
						list.Add(string.Format("{0}|{1}|{2}|{3}", item["id"], item["name"], item["group_member_profiles"]!["count"], (item["viewer_post_status"]!.ToString() == "CAN_POST_WITHOUT_APPROVAL") ? "False" : "True"));
					}
					catch (Exception)
					{
					}
				}
			}
			else
			{
				string input2 = b01F5C.RequestGet("https://mobile.facebook.com/help/");
				string value3 = Regex.Match(input2, Common.B537BA12("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
				string string_ = "https://www.facebook.com/ajax/typeahead/first_degree.php?fb_dtsg_ag=" + value3 + "&filter%5B0%5D=group&viewer=" + value + "&__user=" + value + "&__a=1&__dyn=&__comet_req=0&jazoest=26581";
				input2 = b01F5C.RequestGet(string_).Replace("for (;;);", "");
				JObject jObject2 = JObject.Parse(input2);
				foreach (JToken item2 in (IEnumerable<JToken>)(jObject2["payload"]!["entries"]!))
				{
					try
					{
						list.Add(string.Format("{0}|{1}|{2}", item2["uid"], item2["text"], item2["size"]));
					}
					catch
					{
					}
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	private static List<string> B610BC9E(List<string> list_0, string E2B4362E, string B9A9A628, string F4AE3C82, int int_0)
	{
		try
		{
			int BF85B329 = 0;
			int num = ((list_0.Count < 100) ? list_0.Count : 100);
			int num2 = 0;
			while (num2 < list_0.Count)
			{
				if (BF85B329 < num)
				{
					Interlocked.Increment(ref BF85B329);
					int int_ = num2++;
					Thread thread = new Thread((ThreadStart)delegate
					{
						string text = list_0[int_];
						bool flag = true;
						try
						{
							string text2 = text.Split('|')[0];
							RequestXNet b01F5C = new RequestXNet(E2B4362E, B9A9A628, F4AE3C82, int_0);
							string text3 = b01F5C.RequestGet("https://mobile.facebook.com/groups/" + text2 + "/madminpanel");
							flag = text3.Contains("madminpanel/pending/");
						}
						catch
						{
						}
						list_0[int_] = $"{text}|{flag}";
						Interlocked.Decrement(ref BF85B329);
					});
					thread.IsBackground = true;
					thread.Start();
				}
				else
				{
					Application.DoEvents();
					Thread.Sleep(200);
				}
			}
			while (BF85B329 > 0)
			{
				Application.DoEvents();
				Thread.Sleep(100);
			}
		}
		catch
		{
		}
		return list_0;
	}

	public static string smethod_2(int B4926124 = 16)
	{
		Random random = new Random();
		string text = "abcdef1234567890";
		string text2 = "";
		for (int i = 0; i < B4926124; i++)
		{
			text2 += Convert.ToString(text[random.Next(0, text.Length)]);
		}
		return text2;
	}

	public static string smethod_3(string A42479BB, string string_0, string string_1, int int_0)
	{
		string result = "0|0";
		string value = Regex.Match(A42479BB, "c_user=(\\d+)").Groups[1].Value;
		if (value != "")
		{
			try
			{
				RequestXNet b01F5C = new RequestXNet(A42479BB, string_0, string_1, int_0);
				if (value != "")
				{
					string f01CBDB = b01F5C.RequestGet("https://m.facebook.com/home.php").ToString();
					List<string> list_ = new List<string> { "/friends/", "/logout.php?button_location=settings&amp;button_name=logout" };
					if (GClass12.smethod_26(f01CBDB, list_))
					{
						result = "1|1";
					}
				}
			}
			catch
			{
			}
		}
		return result;
	}

	public static List<string> smethod_4(string string_0, string E1AE403C, int A63B702F)
	{
		List<string> list = new List<string>();
		try
		{
			RequestXNet b01F5C = new RequestXNet("", "", E1AE403C, A63B702F);
			string json = b01F5C.RequestGet("https://graph.facebook.com/v3.0/me/friends?access_token=" + string_0 + "&limit=5000&fields=id,name");
			JObject jObject = JObject.Parse(json);
			foreach (JToken item in (IEnumerable<JToken>)(jObject["data"]!))
			{
				list.Add(item["name"]!.ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_5(string string_0, string D6BB13BF, string string_1, string string_2, string CE228435, int FE84641A, int int_0 = 20, bool bool_0 = false)
	{
		List<string> list = new List<string>();
		try
		{
			Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
			string[] array = string_0.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				dictionary.Add(array[i], new List<string>());
			}
			RequestXNet b01F5C = new RequestXNet(D6BB13BF, string_2, CE228435, FE84641A);
			b01F5C.http.AddHeader("Authorization", "OAuth " + string_1);
			string string_3 = "https://graph.facebook.com/?ids=" + string_0 + "&pretty=0&fields=id,name,photos.limit(" + int_0 + "){images}";
			string text = b01F5C.RequestGet(string_3);
			JObject jObject = JObject.Parse(text);
			if (jObject != null && text.Contains("images"))
			{
				string[] array2 = string_0.Split(',');
				foreach (string text2 in array2)
				{
					string text3 = jObject[text2]!["name"]!.ToString();
					try
					{
						foreach (JToken item in (IEnumerable<JToken>)(jObject[text2]!["photos"]!["data"]!))
						{
							try
							{
								int num = item["images"].ToList().Count - 1;
								dictionary[text2].Add(text2 + "*" + text3 + "*" + item["images"]![num]!["source"]?.ToString() + "|" + item["images"]![num]!["width"]?.ToString() + "|" + item["images"]![num]!["height"]);
							}
							catch
							{
							}
						}
					}
					catch
					{
					}
				}
			}
			if (bool_0)
			{
				RequestXNet b01F5C2 = new RequestXNet(D6BB13BF, string_2, CE228435, FE84641A);
				b01F5C2.http.AddHeader("Authorization", "OAuth " + string_1);
				string string_4 = "https://graph.facebook.com/?ids=" + string_0 + "&pretty=0&fields=name,albums.limit(3){photos.limit(10){width,height,images}}";
				string text4 = b01F5C2.RequestGet(string_4);
				JObject jObject2 = JObject.Parse(text4);
				if (jObject2 != null && text4.Contains("images"))
				{
					string[] array3 = string_0.Split(',');
					foreach (string text5 in array3)
					{
						string text6 = jObject2[text5]!["name"]!.ToString();
						foreach (JToken item2 in (IEnumerable<JToken>)(jObject2[text5]!["albums"]!["data"]!))
						{
							try
							{
								foreach (JToken item3 in (IEnumerable<JToken>)(item2["photos"]!["data"]!))
								{
									try
									{
										int num2 = item3["images"].ToList().Count - 1;
										if (dictionary[text5].Count < int_0)
										{
											dictionary[text5].Add(text5 + "*" + text6 + "*" + item3["images"]![num2]!["source"]?.ToString() + "|" + item3["images"]![num2]!["width"]?.ToString() + "|" + item3["images"]![num2]!["height"]);
											continue;
										}
									}
									catch (Exception)
									{
										continue;
									}
									goto IL_04b6;
								}
							}
							catch (Exception)
							{
							}
						}
						IL_04b6:;
					}
				}
			}
			foreach (KeyValuePair<string, List<string>> item4 in dictionary)
			{
				if (item4.Value.Count > 0)
				{
					list.AddRange(item4.Value);
					list.Add("");
				}
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static string smethod_6(string string_0, string D1298233, string A3913120, int int_0)
	{
		try
		{
			string input = new RequestXNet(string_0, D1298233, A3913120, int_0).RequestGet("https://m.facebook.com/help/");
			return Regex.Match(input, Common.B537BA12("ZHRzZyI6eyJ0b2tlbiI6IiguKj8pIg==")).Groups[1].Value;
		}
		catch
		{
			return "";
		}
	}
	public static string smethod_7(string BE83D726, string string_0 = "", string F0A01FBE = "")
	{
		if (BE83D726.Contains("this-person-does-not-exist.com"))
		{
			BE83D726 = Regex.Match(BE83D726, "(http.*?.com)").Groups[1].Value;
			string input = new RequestXNet("", "", "", 0).RequestGet(BE83D726 + "?new");
			BE83D726 += Regex.Match(input, "src\":\"(.*?)\"").Groups[1].Value.Replace("\\", "");
		}
		string text = "";
		for (int i = 0; i < 2; i++)
		{
			try
			{
				using WebClient webClient = new WebClient();
				byte[] buffer = webClient.DownloadData(BE83D726);
				using MemoryStream stream = new MemoryStream(buffer);
				using Image image = Image.FromStream(stream);
				text = ((string_0 == "") ? (FileHelper.GetPathToCurrentFolder() + "\\photos") : string_0).Trim('\\') + "\\";
				text += ((F0A01FBE == "") ? Guid.NewGuid().ToString() : F0A01FBE);
				try
				{
					image.Save(text + ".png", ImageFormat.Png);
					text += ".png";
				}
				catch
				{
					image.Save(text + ".jpg", ImageFormat.Jpeg);
					text += ".jpg";
				}
			}
			catch (Exception)
			{
			}
			if (text != "")
			{
				break;
			}
			string input2 = new RequestXNet("", "", "", 0).RequestGet(BE83D726);
			BE83D726 = Regex.Match(input2, "src=\"(.*?)\"").Groups[1].Value;
			if (BE83D726 == "")
			{
				break;
			}
		}
		return text;
	}

	private static List<bool> E81B2B8F(Bitmap bitmap_0)
	{
		List<bool> list = new List<bool>();
		Bitmap bitmap = new Bitmap(bitmap_0, new Size(16, 16));
		for (int i = 0; i < bitmap.Height; i++)
		{
			for (int j = 0; j < bitmap.Width; j++)
			{
				list.Add(bitmap.GetPixel(j, i).GetBrightness() < 0.5f);
			}
		}
		return list;
	}

	public static string CheckLiveWall(string uid)
	{
        return PhoneFarmLib.Common.CheckLiveWall(uid);
    }

	public static string smethod_9(string F4BC94AE)
	{
		try
		{
			GClass13 gClass = new GClass13("", "Mozilla/5.0 (iPhone; CPU iPhone OS 10_3_2 like Mac OS X) AppleWebKit/603.2.4 (KHTML, like Gecko) Mobile/14F89");
			string json = gClass.method_1("https://www.facebook.com/api/graphql", "q=node(" + F4BC94AE + "){name}");
			JObject jObject = JObject.Parse(json);
			if (string.IsNullOrEmpty(jObject[F4BC94AE]!.ToString()))
			{
				return "";
			}
			return jObject[F4BC94AE]!["name"]!.ToString();
		}
		catch
		{
		}
		return "";
	}

	public static bool D90D78B1(string string_0, string F008840C, string D9085704, string E789049D, int int_0 = 0)
	{
		bool result = false;
		try
		{
			RequestXNet b01F5C = new RequestXNet(string_0, D9085704, E789049D, int_0);
			string text = b01F5C.RequestGet("https://graph.facebook.com/me?access_token=" + F008840C);
			result = !text.Contains("error");
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static string DB816998(string string_0)
	{
		string result = "";
		int num = 0;
		uint num2 = HashString.DA8CEBAB(string_0);
		if (num2 <= 1315429348)
		{
			if (num2 <= 822911587)
			{
				if (num2 != 334175660)
				{
					if (num2 != 401286136)
					{
						if (num2 == 822911587 && string_0 == "4")
						{
							goto IL_01c8;
						}
					}
					else if (string_0 == "14")
					{
						result = ((num != 0) ? "device" : "Thiết bị");
						goto IL_02c6;
					}
				}
				else if (string_0 == "18")
				{
					result = ((num != 0) ? "comment" : "Bình luận");
					goto IL_02c6;
				}
				goto IL_02a5;
			}
			if (num2 <= 923577301)
			{
				if (num2 != 906799682)
				{
					if (num2 != 923577301 || !(string_0 == "2"))
					{
						goto IL_02a5;
					}
					result = ((num != 0) ? "Birthday" : "Ngày sinh");
				}
				else
				{
					if (!(string_0 == "3"))
					{
						goto IL_02a5;
					}
					result = ((num != 0) ? "Image" : "Ảnh");
				}
			}
			else if (num2 != 1153637868)
			{
				if (num2 != 1315429348 || !(string_0 == "id_upload"))
				{
					goto IL_02a5;
				}
				result = "Up a\u0309nh";
			}
			else
			{
				if (!(string_0 == "72h"))
				{
					goto IL_02a5;
				}
				result = ((num != 0) ? "72 hours" : "72h");
			}
		}
		else
		{
			if (num2 <= 2347784130u)
			{
				if (num2 != 1718322808)
				{
					if (num2 != 2331006511u)
					{
						if (num2 == 2347784130u && string_0 == "34")
						{
							goto IL_01c8;
						}
					}
					else if (string_0 == "37")
					{
						result = "Gư\u0309i OTP vê\u0300 mail";
						goto IL_02c6;
					}
				}
				else if (string_0 == "2fa")
				{
					result = "Co\u0301 2fa";
					goto IL_02c6;
				}
				goto IL_02a5;
			}
			if (num2 <= 2364561749u)
			{
				if (num2 != 2347931225u)
				{
					if (num2 != 2364561749u || !(string_0 == "35"))
					{
						goto IL_02a5;
					}
					result = "Login Google";
				}
				else
				{
					if (!(string_0 == "26"))
					{
						goto IL_02a5;
					}
					result = ((num != 0) ? "Friend" : "Nhơ\u0300 bạn bè");
				}
			}
			else if (num2 != 2381486463u)
			{
				if (num2 != 2517938561u || !(string_0 == "vhh"))
				{
					goto IL_02a5;
				}
				result = ((num != 0) ? "disable" : "Vô hiệu hóa");
			}
			else
			{
				if (!(string_0 == "20"))
				{
					goto IL_02a5;
				}
				result = ((num != 0) ? "Message" : "Tin nhắn");
			}
		}
		goto IL_02c6;
		IL_01c8:
		result = "Otp";
		goto IL_02c6;
		IL_02a5:
		File.AppendAllText("data\\dangcp.txt", string_0);
		goto IL_02c6;
		IL_02c6:
		return result;
	}

	public static string D42B7486(string string_0, string string_1, string D182302C, string F9027207, int int_0)
	{
		string text = "";
		try
		{
			string string_2 = "email=" + WebUtility.UrlEncode(string_0) + "&pass=" + WebUtility.UrlEncode(string_1);
			RequestXNet b01F5C = new RequestXNet("", D182302C, F9027207, int_0);
			string text2 = b01F5C.method_1("https://mbasic.facebook.com/login/device-based/regular/login/?refsrc=https%3A%2F%2Fmbasic.facebook.com%2F&lwv=100&refid=8", string_2).ToString();
			if (text2.Contains("id=\"checkpointSubmitButton\""))
			{
				if (text2.Contains("id=\"approvals_code\""))
				{
					text = "5|";
				}
				else
				{
					text = "2|";
					b01F5C = new RequestXNet("", D182302C, F9027207, int_0);
					b01F5C.RequestGet("https://www.facebook.com").ToString();
					text2 = b01F5C.method_1("https://www.facebook.com/login/device-based/regular/login/?login_attempt=1&lwv=100", string_2).ToString();
					string value = Regex.Match(text2, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
					string value2 = Regex.Match(text2, "name=\"jazoest\" value=\"(.*?)\"").Groups[1].Value;
					string value3 = Regex.Match(text2, "name=\"nh\" value=\"(.*?)\"").Groups[1].Value;
					string value4 = Regex.Match(text2, "\"__spin_r\":(.*?),").Groups[1].Value;
					string value5 = Regex.Match(text2, "\"__spin_t\":(.*?),").Groups[1].Value;
					string string_3 = "jazoest=" + value2 + "&fb_dtsg=" + value + "&nh=" + value3 + "&submit[Continue]=Ti%E1%BA%BFp%20t%E1%BB%A5c&__user=0&__a=1&__dyn=7xe6Fo4OQ1PyUhxOnFwn84a2i5U4e1Fx-ewSwMxW0DUeUhw5cx60Vo1upE4W0OE2WxO0SobEa87i0n2US1vw4Ugao881FU3rw&__csr=&__req=5&__beoa=0&__pc=PHASED%3ADEFAULT&dpr=1&__rev=" + value4 + "&__s=op5tkm%3A2d4a9m%3A37z92b&__hsi=6789153697588537525-0&__spin_r=" + value4 + "&__spin_b=trunk&__spin_t=" + value5;
					text2 = b01F5C.method_1("https://www.facebook.com/checkpoint/async?next=https%3A%2F%2Fwww.facebook.com%2F", string_3);
					text2 = b01F5C.RequestGet("https://www.facebook.com/checkpoint/?next");
					MatchCollection matchCollection = Regex.Matches(text2, "verification_method\" value=\"(.*?)\"");
					if (matchCollection.Count > 0)
					{
						for (int i = 0; i < matchCollection.Count; i++)
						{
							text = text + DB816998(matchCollection[i].Groups[1].Value) + "-";
						}
						text = text.TrimEnd('-');
					}
					else if (text2.Contains("/checkpoint/dyi/?referrer=disabled_checkpoint"))
					{
						text += DB816998("vhh");
					}
					else if (text2.Contains("captcha-recaptcha"))
					{
						text += DB816998("72h");
					}
					else if (text2.Contains("name=\"submit[Log Out]\"") || text2.Contains("name=\"submit[__placeholder__]\""))
					{
						text += "không thê\u0309 xmdt";
					}
					else if (text2.Contains("name=\"submit[Continue]\""))
					{
						text += "Thiê\u0301t bi\u0323";
					}
				}
			}
			else if (text2.Contains("login_error"))
			{
				text = ((!text2.Contains("m_login_email")) ? "0|" : "3|");
			}
			else if (text2.Contains("action_set_contact_point"))
			{
				text = "2|" + DB816998("34");
			}
			else
			{
				string text3 = b01F5C.BC82EA37();
				text = ((!smethod_3(text3, D182302C, F9027207, int_0).StartsWith("1|")) ? "2|" : (text + "1|" + text3));
			}
		}
		catch
		{
			text = "0|";
		}
		return text;
	}

	public static string D0814DB9(string string_0, string string_1, string string_2, string string_3, int D00A4501)
	{
		string text = "";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		try
		{
			RequestXNet b01F5C = new RequestXNet("", string_2, string_3, D00A4501);
			if (string_1 == "")
			{
				string_1 = "me";
			}
			string json = b01F5C.RequestGet("https://graph.facebook.com/v2.11/" + string_1 + "?fields=name,email,gender,birthday,friends.limit(0)&access_token=" + string_0);
			JObject jObject = JObject.Parse(json);
			flag = true;
			text2 = jObject["name"]!.ToString();
			try
			{
				text3 = jObject["gender"]!.ToString();
			}
			catch
			{
			}
			try
			{
				text4 = jObject["birthday"]!.ToString();
			}
			catch
			{
			}
			try
			{
				text6 = jObject["email"]!.ToString();
			}
			catch
			{
			}
			try
			{
				text7 = jObject["friends"]!["summary"]!["total_count"]!.ToString();
			}
			catch
			{
			}
			if (text7 == "")
			{
				text7 = "0";
			}
			json = b01F5C.RequestGet("https://graph.facebook.com/v2.11/" + string_1 + "/groups?fields=id&limit=5000&access_token=" + string_0);
			jObject = JObject.Parse(json);
			try
			{
				text8 = jObject["data"].Count().ToString() ?? "";
			}
			catch
			{
			}
			if (text8 == "")
			{
				text8 = "0";
			}
		}
		catch
		{
			if (!D90D78B1("", string_0, "", ""))
			{
				return "-1";
			}
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}";
	}

	public static string smethod_11(string B880B206, string string_0, string string_1, int int_0)
	{
		string text = "";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		string text9 = "";
		try
		{
			string value = Regex.Match(B880B206, "c_user=(\\d+)").Groups[1].Value;
			RequestXNet b01F5C = new RequestXNet(B880B206, string_0, string_1, int_0);
			string string_2 = "https://m.facebook.com/help/";
			string input = b01F5C.RequestGet(string_2);
			string value2 = Regex.Match(input, "dtsg\":{\"token\":\"(.*?)\"").Groups[1].Value;
			text2 = Regex.Match(input, "\"NAME\":\"(.*?)\"").Groups[1].Value;
			text2 = WebUtility.HtmlDecode(text2);
			string text10 = Common.B537BA12("LS0tLS0tV2ViS2l0Rm9ybUJvdW5kYXJ5MnlnMEV6RHBTWk9DWGdCUgpDb250ZW50LURpc3Bvc2l0aW9uOiBmb3JtLWRhdGE7IG5hbWU9ImZiX2R0c2ciCgp7e2ZiX2R0c2d9fQotLS0tLS1XZWJLaXRGb3JtQm91bmRhcnkyeWcwRXpEcFNaT0NYZ0JSCkNvbnRlbnQtRGlzcG9zaXRpb246IGZvcm0tZGF0YTsgbmFtZT0icSIKCm5vZGUoe3t1aWR9fSl7ZnJpZW5kc3tjb3VudH0sc3Vic2NyaWJlcnN7Y291bnR9LGdyb3VwcyxjcmVhdGVkX3RpbWV9Ci0tLS0tLVdlYktpdEZvcm1Cb3VuZGFyeTJ5ZzBFekRwU1pPQ1hnQlItLQ==");
			text10 = text10.Replace("{{fb_dtsg}}", value2);
			text10 = text10.Replace("{{uid}}", value);
			input = b01F5C.method_1("https://www.facebook.com/api/graphql/", text10, "multipart/form-data; boundary=----WebKitFormBoundary2yg0EzDpSZOCXgBR");
			JObject jObject = JObject.Parse(input);
			text7 = jObject[value]!["friends"]!["count"]!.ToString();
			text8 = jObject[value]!["groups"]!["count"]!.ToString();
			text9 = jObject[value]!["created_time"]!.ToString();
			if (text7 == "")
			{
				text7 = "0";
			}
			if (text8 == "")
			{
				text8 = "0";
			}
		}
		catch
		{
			if (!smethod_3(B880B206, string_0, string_1, int_0).Contains("1|"))
			{
				return "-1";
			}
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}||{text9}";
	}

	public static string smethod_12(string string_0, string string_1)
	{
		string text = "";
		bool flag = false;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		string text8 = "";
		string text9 = "";
		string text10 = "";
		try
		{
			string text11 = "c_user=" + Regex.Match(string_1 + ";", "c_user=(.*?);").Groups[1].Value + "; xs=xs=" + Regex.Match(string_1 + ";", "xs=(.*?);").Groups[1].Value + ";";
			RequestXNet b01F5C = new RequestXNet(text11 + " useragent=TW96aWxsYS81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXQvNTM3LjM2IChLSFRNTCwgbGlrZSBHZWNrbykgQ2hyb21lLzc0LjAuMjMwMi42MSBTYWZhcmkvNTM3LjM2", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:50.0) Gecko/20100101 Firefox/50.0", "", 0);
			string string_2 = "https://www.facebook.com/api/graphql";
			string string_3 = "q=user(" + string_0 + ")%7Bfriends%7Bcount%7D%2Cgroups%7Bcount%7D%2Cid%2Cname%2Cgender%2Cbirthday%2Cemail_addresses%2Cusername%7D";
			string json = b01F5C.method_1(string_2, string_3);
			JObject jObject = JObject.Parse(json);
			text7 = jObject[string_0]!["friends"]!["count"]!.ToString();
			text8 = jObject[string_0]!["groups"]!["count"]!.ToString();
			text2 = jObject[string_0]!["name"]!.ToString();
			text4 = ((jObject[string_0]!["birthday"] != null) ? jObject[string_0]!["birthday"]!.ToString() : "");
			text3 = jObject[string_0]!["gender"]!.ToString().ToLower();
			if (text7 == "")
			{
				text7 = "0";
			}
			if (text8 == "")
			{
				text8 = "0";
			}
			flag = true;
		}
		catch
		{
			if (!smethod_3(string_1, "", "", 0).StartsWith("1|"))
			{
				return "-1";
			}
			flag = false;
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}|{text9}|{text10}";
	}

	public static bool EDB6C3A3(string string_0, string string_1)
	{
		try
		{
			string address = "https://graph.facebook.com/" + string_0 + "/picture?width=736&access_token=6628568379|c1e620fa708a1d5696fb991c1bde5662";
			using (WebClient webClient = new WebClient())
			{
				byte[] buffer = webClient.DownloadData(address);
				using MemoryStream stream = new MemoryStream(buffer);
				using Image image = Image.FromStream(stream);
				string text = string_1 + "\\" + string_0;
				try
				{
					image.Save(text + ".png", ImageFormat.Png);
				}
				catch
				{
					image.Save(text + ".jpg", ImageFormat.Jpeg);
				}
			}
			return true;
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Error DownLoadImageByUid");
			return false;
		}
	}
}
