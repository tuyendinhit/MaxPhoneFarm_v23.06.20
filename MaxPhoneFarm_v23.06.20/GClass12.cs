using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

public class GClass12
{
	public static bool smethod_0(Chrome gclass9_0)
	{
		if (gclass9_0.AB2275A9().StartsWith("https://m.facebook.com/feature_limit_notice/") || gclass9_0.method_26(0.0, "[href=\"https://www.facebook.com/help/177066345680802\"]", "[href*=\"https://m.facebook.com/help/contact/\"]") != 0)
		{
			return true;
		}
		return false;
	}

	public static void smethod_1(Chrome gclass9_0, List<string> list_0)
	{
		List<string> list = new List<string>();
		string text = "";
		int num = gclass9_0.DE832319("textarea");
		gclass9_0.method_27("document.querySelector('textarea')");
		gclass9_0.method_21();
		for (int i = 0; i < num; i++)
		{
			if (list.Count == 0)
			{
				list = Common.smethod_11(list_0);
			}
			text = list[Base.rd.Next(0, list.Count)];
			text = Common.SpinText(text);
			list.Remove(text);
			gclass9_0.AEA28F33(4, "textarea", i, text, 0.1);
			gclass9_0.method_21();
		}
	}

	public static bool EB06FB06(Chrome gclass9_0)
	{
		try
		{
			return gclass9_0.C6B3E9B0("#captcha_response") == 1 || gclass9_0.C6B3E9B0("[name=\"captcha_response\"]") == 1 || gclass9_0.C6B3E9B0("[name=\"verification_method\"]") == 1 || gclass9_0.C6B3E9B0("[name=\"password_new\"]") == 1 || gclass9_0.C6B3E9B0("[href=\"https://www.facebook.com/communitystandards/\"]") == 1;
		}
		catch
		{
			return false;
		}
	}

	public static int A53507BE(Chrome gclass9_0, string string_0, string string_1, string C11AD9A3 = "", string C88990A2 = "https://www.facebook.com")
	{
		new Random();
		int result = 0;
		try
		{
			int num = 0;
			num = CD8A77A9(gclass9_0.AB2275A9());
			if (num != 0)
			{
				goto IL_003e;
			}
			if (gclass9_0.D920192A(C88990A2) != -2)
			{
				num = CD8A77A9(gclass9_0.AB2275A9());
				goto IL_003e;
			}
			result = -2;
			goto end_IL_0008;
			IL_003e:
			if (gclass9_0.C6B3E9B0("[data-cookiebanner=\"accept_button\"]") == 1)
			{
				gclass9_0.method_14(4, "[data-cookiebanner=\"accept_button\"]");
				gclass9_0.C2B42BB6(1.0);
			}
			if (num == 1)
			{
				gclass9_0.method_9("https://www.facebook.com/login");
				if (gclass9_0.C6B3E9B0("[data-cookiebanner=\"accept_button\"]") == 1)
				{
					gclass9_0.method_14(4, "[data-cookiebanner=\"accept_button\"]");
					gclass9_0.C2B42BB6(1.0);
				}
				if (gclass9_0.method_19(1, "email", string_0, 0.1) == -2)
				{
					result = -2;
				}
				else
				{
					gclass9_0.C2B42BB6(1.0);
					if (gclass9_0.method_19(1, "pass", string_1, 0.1) == -2)
					{
						result = -2;
					}
					else
					{
						gclass9_0.C2B42BB6(1.0);
						if (gclass9_0.method_14(1, "loginbutton") != -2)
						{
							gclass9_0.C2B42BB6(1.0);
							if (gclass9_0.C6B3E9B0("#approvals_code", 5.0) == 1 && C11AD9A3 != "")
							{
								string text = Common.GetTotp(C11AD9A3.Replace(" ", "").Replace("\n", ""));
								if (text != "")
								{
									gclass9_0.method_19(1, "approvals_code", text, 0.1);
									gclass9_0.C2B42BB6(1.0);
									gclass9_0.method_14(1, "checkpointSubmitButton");
									gclass9_0.C2B42BB6(1.0);
								}
							}
							int num2 = 0;
							while (gclass9_0.C6B3E9B0("#checkpointSubmitButton", 3.0) == 1)
							{
								if (gclass9_0.F125B9B1())
								{
									if (EB06FB06(gclass9_0) || num2 == 7)
									{
										break;
									}
									gclass9_0.method_14(1, "checkpointSubmitButton");
									gclass9_0.C2B42BB6(1.0);
									num2++;
									continue;
								}
								result = -2;
								goto end_IL_0008;
							}
							goto IL_05e0;
						}
						result = -2;
					}
				}
			}
			else
			{
				int num3 = gclass9_0.method_9("https://m.facebook.com/login");
				if (gclass9_0.C6B3E9B0("[data-cookiebanner=\"accept_button\"]") == 1)
				{
					gclass9_0.method_14(4, "[data-cookiebanner=\"accept_button\"]");
					gclass9_0.C2B42BB6(1.0);
				}
				num3 = gclass9_0.C6B3E9B0("[data-sigil=\"login_profile_form\"] div[role=\"button\"]", 1.0);
				int num4 = num3;
				int num5 = num4;
				if (num5 != -2)
				{
					if (num5 != 1)
					{
						if (gclass9_0.method_19(1, "m_login_email", string_0, 0.1) == 1)
						{
							gclass9_0.method_21();
							string string_2 = ((gclass9_0.method_26(3.0, "#m_login_password", "[name=\"pass\"]") == 1) ? "#m_login_password" : "[name=\"pass\"]");
							gclass9_0.method_19(4, string_2, string_1, 0.1);
							gclass9_0.method_21();
							gclass9_0.method_14(2, "login");
							gclass9_0.method_21();
						}
						goto IL_04a5;
					}
					gclass9_0.method_21();
					if (gclass9_0.method_14(4, "[data-sigil=\"login_profile_form\"] div[role=\"button\"]") != -2)
					{
						gclass9_0.method_21(2);
						switch (gclass9_0.method_26(10.0, "[name=\"pass\"]", "#approvals_code"))
						{
						case -2:
							result = -2;
							goto end_IL_0008;
						case 1:
							if (gclass9_0.method_19(2, "pass", string_1, 0.1) == 1)
							{
								gclass9_0.method_21();
								if (gclass9_0.method_14(4, gclass9_0.method_3("button", "data-sigil", "password_login_button")) == 1)
								{
									gclass9_0.C2B42BB6(1.0);
								}
							}
							break;
						}
						goto IL_04a5;
					}
					result = -2;
				}
				else
				{
					result = -2;
				}
			}
			goto end_IL_0008;
			IL_05e0:
			gclass9_0.C2B42BB6(1.0);
			return F4857091(gclass9_0);
			IL_04a5:
			int num6;
			int num7;
			switch (gclass9_0.C6B3E9B0("#approvals_code", 5.0))
			{
			case -2:
				result = -2;
				goto end_IL_0008;
			case 1:
				num6 = ((C11AD9A3.Trim() != "") ? 1 : 0);
				goto IL_04e3;
			default:
				{
					num6 = 0;
					goto IL_04e3;
				}
				IL_04e3:
				if (num6 != 0)
				{
					string text2 = Common.GetTotp(C11AD9A3.Replace(" ", "").Replace("\n", ""));
					if (text2 != "")
					{
						gclass9_0.method_19(1, "approvals_code", text2, 0.1);
						gclass9_0.method_21(-1);
						gclass9_0.method_14(1, "checkpointSubmitButton-actual-button");
						gclass9_0.method_21();
					}
				}
				num7 = 0;
				while (gclass9_0.C6B3E9B0("#checkpointSubmitButton-actual-button", 3.0) == 1 && gclass9_0.C6B3E9B0("[name=\"password_new\"]") != 1)
				{
					if (gclass9_0.F125B9B1())
					{
						if (BB97109D(gclass9_0) || num7 == 7)
						{
							break;
						}
						gclass9_0.method_14(1, "checkpointSubmitButton-actual-button");
						gclass9_0.method_21();
						num7++;
						continue;
					}
					result = -2;
					goto end_IL_0008;
				}
				break;
			}
			goto IL_05e0;
			end_IL_0008:;
		}
		catch (Exception exception_)
		{
			Common.ExportError(gclass9_0, exception_, "Login Uid Pass Fail");
		}
		return result;
	}

	public static string DF2CC98C(Chrome gclass9_0)
	{
		return gclass9_0.F4AF93AB("var x='';document.querySelectorAll('[property=\"og:title\"]').length>0&&(x=document.querySelector('[property=\"og:title\"]').getAttribute('content')),''==x&&document.querySelectorAll('[data-gt] a').length>0&&(x=document.querySelector('[data-gt] a').innerText),''==x&&document.querySelectorAll('.actor').length>0&&(x=document.querySelector('.actor').innerText), x+''; return x;").ToString();
	}

	public static string smethod_2(Chrome gclass9_0)
	{
		return gclass9_0.F4AF93AB("var x='';document.querySelectorAll('.overflowText').length>0&&(x=document.querySelector('.overflowText').innerText), x+''; return x;").ToString();
	}

	public static int smethod_3(Chrome gclass9_0)
	{
		try
		{
			if (gclass9_0 != null)
			{
				if (gclass9_0.B2277F30())
				{
					return -2;
				}
				if (!(gclass9_0.AB2275A9() == "https://m.facebook.com/home.php") && !(gclass9_0.AB2275A9() == "https://m.facebook.com"))
				{
					if (gclass9_0.C6B3E9B0("#feed_jewel a") == 1)
					{
						gclass9_0.method_28("document.querySelector('#feed_jewel a')");
						gclass9_0.method_21();
					}
					if (gclass9_0.method_14(4, "#feed_jewel a") != 1)
					{
						gclass9_0.D920192A("https://m.facebook.com/home.php");
					}
					gclass9_0.C2B42BB6(1.0);
					if (gclass9_0.C6B3E9B0("#nux-nav-button", 2.0) == 1)
					{
						gclass9_0.method_16(1, "nux-nav-button");
						gclass9_0.C2B42BB6(2.0);
					}
				}
				if (gclass9_0.B2277F30())
				{
					return -2;
				}
				if (gclass9_0.AB2275A9() == "https://m.facebook.com/home.php" || gclass9_0.AB2275A9() == "https://m.facebook.com/home.php?ref=wizard&_rdr" || gclass9_0.AB2275A9() == "https://m.facebook.com")
				{
					return 1;
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int EB82CE09(Chrome C0ADA08F)
	{
		try
		{
			if (C0ADA08F != null)
			{
				if (C0ADA08F.B2277F30())
				{
					return -2;
				}
				if (C0ADA08F.C6B3E9B0("#requests_jewel a") == 1)
				{
					C0ADA08F.method_28("document.querySelector('#requests_jewel a')");
					C0ADA08F.method_21();
				}
				int num = C0ADA08F.method_14(4, "#requests_jewel a");
				if (num != 1)
				{
					smethod_3(C0ADA08F);
					C0ADA08F.method_21(2);
					num = C0ADA08F.method_14(4, "#requests_jewel a");
				}
				if (num == 1)
				{
					C0ADA08F.method_21(1);
					if (C0ADA08F.method_14(4, "[href=\"/friends/center/friends/?mff_nav=1\"]") == 1)
					{
						C0ADA08F.method_21();
						return 1;
					}
				}
				return C0ADA08F.D920192A("https://m.facebook.com/friends/center/friends/?mff_nav=1");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int D6346C23(Chrome gclass9_0)
	{
		try
		{
			if (gclass9_0 != null)
			{
				if (gclass9_0.B2277F30())
				{
					return -2;
				}
				if (gclass9_0.C6B3E9B0("#requests_jewel a") == 1)
				{
					gclass9_0.method_28("document.querySelector('#requests_jewel a')");
					gclass9_0.method_21();
				}
				int num = gclass9_0.method_14(4, "#requests_jewel a");
				if (num != 1)
				{
					smethod_3(gclass9_0);
					gclass9_0.method_21(2);
					num = gclass9_0.method_14(4, "#requests_jewel a");
				}
				if (num == 1)
				{
					gclass9_0.method_21(1);
					if (gclass9_0.method_14(4, "[href=\"/friends/center/suggestions/?mff_nav=1&ref=bookmarks\"]") == 1)
					{
						gclass9_0.method_21();
						return 1;
					}
				}
				return gclass9_0.D920192A("https://m.facebook.com/friends/center/suggestions/?mff_nav=1&ref=bookmarks");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_4(Chrome gclass9_0)
	{
		try
		{
			if (gclass9_0 != null)
			{
				if (gclass9_0.B2277F30())
				{
					return -2;
				}
				if (gclass9_0.C6B3E9B0("[data-sigil=\"nav-popover bookmarks\"]>a") == 1)
				{
					gclass9_0.method_28("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
					gclass9_0.method_21();
				}
				int num = gclass9_0.method_14(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				if (num != 1)
				{
					smethod_3(gclass9_0);
					gclass9_0.method_21(2);
					num = gclass9_0.method_14(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				}
				if (num == 1)
				{
					gclass9_0.method_21(1);
					string text = gclass9_0.method_3("a", "href", "/groups/");
					if (text != "")
					{
						gclass9_0.method_28("document.querySelector('" + text + "')");
						gclass9_0.method_21();
						if (gclass9_0.method_14(4, text) == 1)
						{
							gclass9_0.method_21(2);
							if (gclass9_0.method_14(4, "[href=\"/groups_browse/your_groups/\"]") == 1)
							{
								gclass9_0.method_21();
								return 1;
							}
						}
					}
				}
				return gclass9_0.D920192A("https://m.facebook.com/groups_browse/your_groups/");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int C13A8E25(Chrome gclass9_0)
	{
		try
		{
			if (gclass9_0 != null)
			{
				if (gclass9_0.B2277F30())
				{
					return -2;
				}
				if (gclass9_0.C6B3E9B0("[data-sigil=\"nav-popover bookmarks\"]>a") == 1)
				{
					gclass9_0.method_28("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
					gclass9_0.method_21();
				}
				int num = gclass9_0.method_14(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				if (num != 1)
				{
					smethod_3(gclass9_0);
					gclass9_0.method_21(2);
					num = gclass9_0.method_14(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				}
				if (num == 1)
				{
					gclass9_0.method_21(1);
					string text = gclass9_0.method_3("a", "href", "/watch/");
					if (text != "")
					{
						gclass9_0.method_28("document.querySelector('" + text + "')");
						gclass9_0.method_21();
						if (gclass9_0.method_14(4, text) == 1)
						{
							gclass9_0.method_21();
							return 1;
						}
					}
				}
				return gclass9_0.D920192A("https://m.facebook.com/watch/?ref=bookmarks");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int B3AE5989(Chrome gclass9_0)
	{
		try
		{
			if (gclass9_0 != null)
			{
				if (gclass9_0.B2277F30())
				{
					return -2;
				}
				if (gclass9_0.C6B3E9B0("[data-sigil=\"nav-popover bookmarks\"]>a") == 1)
				{
					gclass9_0.method_28("document.querySelector('[data-sigil=\"nav-popover bookmarks\"]>a')");
					gclass9_0.method_21();
				}
				int num = gclass9_0.method_14(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				if (num != 1)
				{
					smethod_3(gclass9_0);
					gclass9_0.method_21(2);
					num = gclass9_0.method_14(4, "[data-sigil=\"nav-popover bookmarks\"]>a");
				}
				if (num == 1)
				{
					gclass9_0.method_21(1);
					string text = gclass9_0.method_3("a", "href", "/settings/");
					if (text != "")
					{
						gclass9_0.method_28("document.querySelector('" + text + "')");
						gclass9_0.method_21();
						if (gclass9_0.method_14(4, text) == 1)
						{
							gclass9_0.method_21();
							return 1;
						}
					}
				}
				return gclass9_0.D920192A("https://m.facebook.com/settings/?entry_point=bookmark");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_5(Chrome gclass9_0)
	{
		try
		{
			if (gclass9_0 != null)
			{
				if (gclass9_0.B2277F30())
				{
					return -2;
				}
				B3AE5989(gclass9_0);
				string text = gclass9_0.method_3("a", "href", "/privacy/touch/timeline_and_tagging/");
				if (text != "")
				{
					gclass9_0.method_28("document.querySelector('" + text + "')");
					gclass9_0.method_21();
					if (gclass9_0.method_14(4, text) == 1)
					{
						gclass9_0.method_21();
						return 1;
					}
				}
				return gclass9_0.D920192A("https://m.facebook.com/privacy/touch/timeline_and_tagging/");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_6(Chrome CC8E169F)
	{
		try
		{
			if (CC8E169F != null)
			{
				if (CC8E169F.B2277F30())
				{
					return -2;
				}
				if (CC8E169F.C6B3E9B0("#notifications_jewel a") == 1)
				{
					CC8E169F.method_28("document.querySelector('#notifications_jewel a')");
					CC8E169F.method_21();
				}
				int num = CC8E169F.method_14(4, "#notifications_jewel a");
				if (num != 1)
				{
					smethod_3(CC8E169F);
					num = CC8E169F.method_14(4, "#notifications_jewel a");
				}
				if (num == 1)
				{
					CC8E169F.method_21(1);
					return 1;
				}
				return CC8E169F.D920192A("https://m.facebook.com/notifications.php?ref=bookmarks");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_7(Chrome A29AD88A)
	{
		try
		{
			if (A29AD88A != null)
			{
				if (A29AD88A.B2277F30())
				{
					return -2;
				}
				if (A29AD88A.C6B3E9B0("#messages_jewel a") == 1)
				{
					A29AD88A.method_28("document.querySelector('#messages_jewel a')");
					A29AD88A.method_21();
				}
				int num = A29AD88A.method_14(4, "#messages_jewel a");
				if (num != 1)
				{
					smethod_3(A29AD88A);
					A29AD88A.method_21(2);
					num = A29AD88A.method_14(4, "#messages_jewel a");
				}
				if (num == 1)
				{
					A29AD88A.method_21(1);
					return 1;
				}
				return A29AD88A.D920192A("https://m.facebook.com/messages/?entrypoint=jewel&no_hist=1&ref=bookmarks");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_8(Chrome gclass9_0)
	{
		try
		{
			if (gclass9_0 != null)
			{
				if (smethod_7(gclass9_0) == 1 && gclass9_0.method_14(4, "[href=\"/messages/?folder=unread&refid=11&ref=bookmarks\"]") == 1)
				{
					gclass9_0.method_22(3, 5);
					return 1;
				}
				return gclass9_0.D920192A("https://m.facebook.com/messages/?folder=unread&ref=bookmarks");
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_9(Chrome EF16FCA8)
	{
		try
		{
			if (EF16FCA8 != null)
			{
				if (EF16FCA8.B2277F30())
				{
					return -2;
				}
				if (EF16FCA8.C6B3E9B0("#notifications_jewel a") == 1)
				{
					EF16FCA8.method_28("document.querySelector('#search_jewel a')");
					EF16FCA8.method_21();
				}
				int num = EF16FCA8.method_14(4, "#search_jewel a");
				if (num != 1)
				{
					smethod_3(EF16FCA8);
					EF16FCA8.method_21(2);
					num = EF16FCA8.method_14(4, "#search_jewel a");
				}
				if (num == 1 && EF16FCA8.C6B3E9B0("#main-search-input") == 1)
				{
					EF16FCA8.method_21(1);
					return 1;
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_10(Chrome AC88A007, string string_0, int EBA8732C = 0)
	{
		try
		{
			if (AC88A007 != null)
			{
				if (AC88A007.B2277F30())
				{
					return -2;
				}
				if (smethod_9(AC88A007) == 1)
				{
					bool flag = false;
					if (AC88A007.C6B3E9B0("#main-search-input") == 1)
					{
						string_0 = Common.SpinText(string_0);
						switch (EBA8732C)
						{
						case 0:
							AC88A007.B0381A81(Base.rd, 1, "main-search-input", string_0, 0.1);
							break;
						case 1:
							AC88A007.method_19(1, "main-search-input", string_0, 0.1);
							break;
						case 2:
							AC88A007.method_17(1, "main-search-input", string_0);
							break;
						}
						AC88A007.method_21();
						AC88A007.A7978C22(1, "main-search-input");
						AC88A007.method_21(2);
						string text = AC88A007.method_3("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/groups");
						if (text != "")
						{
							if (AC88A007.method_14(4, text) == 0)
							{
								if (AC88A007.method_14(4, "[data-sigil=\" flyout-causal\"]") == 1)
								{
									AC88A007.method_21();
									text = AC88A007.method_3("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/groups");
									if (text != "")
									{
										flag = true;
										AC88A007.method_14(4, text);
										AC88A007.method_21(2);
									}
								}
							}
							else
							{
								flag = true;
								AC88A007.method_21(2);
							}
						}
					}
					if (!flag)
					{
						AC88A007.D920192A("https://m.facebook.com/search/groups/?q=" + string_0);
						AC88A007.method_21(2);
						flag = true;
					}
					if (flag)
					{
						AC88A007.method_21(1);
						return 1;
					}
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_11(Chrome A79CB88F, string string_0, int int_0 = 0)
	{
		try
		{
			if (A79CB88F != null)
			{
				if (A79CB88F.B2277F30())
				{
					return -2;
				}
				if (smethod_9(A79CB88F) == 1)
				{
					bool flag = false;
					if (A79CB88F.C6B3E9B0("#main-search-input") == 1)
					{
						string_0 = Common.SpinText(string_0);
						switch (int_0)
						{
						case 0:
							A79CB88F.B0381A81(Base.rd, 1, "main-search-input", string_0, 0.1);
							break;
						case 1:
							A79CB88F.method_19(1, "main-search-input", string_0, 0.1);
							break;
						case 2:
							A79CB88F.method_17(1, "main-search-input", string_0);
							break;
						}
						A79CB88F.method_21();
						A79CB88F.A7978C22(1, "main-search-input");
						A79CB88F.method_21(2);
						string text = A79CB88F.method_3("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/people");
						if (text != "")
						{
							if (A79CB88F.method_14(4, text) == 0)
							{
								if (A79CB88F.method_14(4, "[data-sigil=\" flyout-causal\"]") == 1)
								{
									A79CB88F.method_21();
									text = A79CB88F.method_3("[data-sigil=\"mlayer-hide-on-click search-tabbar-tab\"]", "href", "/search/people");
									if (text != "")
									{
										flag = true;
										A79CB88F.method_14(4, text);
										A79CB88F.method_21(2);
									}
								}
							}
							else
							{
								flag = true;
								A79CB88F.method_21(2);
							}
						}
					}
					if (!flag)
					{
						A79CB88F.D920192A("https://m.facebook.com/search/people/?q=" + string_0 + "&source=filter&isTrending=0");
						A79CB88F.method_21(2);
						flag = true;
					}
					if (flag)
					{
						A79CB88F.method_21(1);
						return 1;
					}
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int A10E23B5(Chrome gclass9_0)
	{
		try
		{
			if (gclass9_0 != null)
			{
				if (gclass9_0.D920192A("https://m.facebook.com/browse/birthdays/") != -2)
				{
					gclass9_0.method_22(2, 5);
					return 1;
				}
				return -2;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_12(Chrome FCAEC10A)
	{
		try
		{
			if (FCAEC10A != null)
			{
				if (FCAEC10A.D920192A("https://m.facebook.com/pokes/") != -2)
				{
					FCAEC10A.method_22(2, 5);
					return 1;
				}
				return -2;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int smethod_13(Chrome gclass9_0, int int_0 = 3, int int_1 = 5)
	{
		try
		{
			if (gclass9_0.B2277F30())
			{
				return -2;
			}
			int num = Base.rd.Next(int_0, int_1 + 1);
			int num2 = Convert.ToInt32(gclass9_0.F4AF93AB("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
			if (gclass9_0.method_6(Base.rd.Next(gclass9_0.method_30().Y / 2, gclass9_0.method_30().Y)) == 1)
			{
				gclass9_0.method_22(1, 3);
				int num3 = Convert.ToInt32(gclass9_0.F4AF93AB("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
				if (num2 != num3)
				{
					for (int i = 0; i < num - 1; i++)
					{
						num2 = Convert.ToInt32(gclass9_0.F4AF93AB("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
						if (gclass9_0.method_6(((Base.rd.Next(1, 1000) % 5 != 0) ? 1 : (-1)) * Base.rd.Next(gclass9_0.method_30().Y / 2, gclass9_0.method_30().Y)) != -2)
						{
							gclass9_0.method_22(1, 3);
							num3 = Convert.ToInt32(gclass9_0.F4AF93AB("return document.querySelector('html').getBoundingClientRect().y+''").ToString());
							if (num2 == num3)
							{
								break;
							}
							gclass9_0.method_22(1, 2);
							continue;
						}
						return -2;
					}
				}
				return 1;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int D1B28A0A(Chrome gclass9_0)
	{
		try
		{
			if (gclass9_0 != null)
			{
				if (gclass9_0.B2277F30())
				{
					return -2;
				}
				switch (gclass9_0.C6B3E9B0("[jsselect=\"suggestionsSummaryList\"]"))
				{
				default:
					if (smethod_20(gclass9_0))
					{
						return -1;
					}
					break;
				case 1:
					return -3;
				case -2:
					return -2;
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public static int E237D8A3(Chrome gclass9_0, int F686AF9C)
	{
		int result = 0;
		int num = 0;
		try
		{
			string text = "https://www.facebook.com";
			if (gclass9_0.AB2275A9().StartsWith(text))
			{
				goto IL_0032;
			}
			num = gclass9_0.D920192A(text);
			if (num != -2)
			{
				goto IL_0032;
			}
			result = -2;
			goto end_IL_0004;
			IL_0032:
			object obj = gclass9_0.F4AF93AB("async function ConvertFacebook(e) { var t = require([\"DTSGInitData\"]).token, a = require([\"CurrentUserInitialData\"]).USER_ID, r = \"\", o = \"\"; 0 == e ? (r = \"https://www.facebook.com/api/graphql/\", o = \"av=\" + a + \"&__user=\" + a + \"&__a=1&dpr=1&fb_dtsg=\" + t + \"&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=CometTrialParticipationChangeMutation&variables=%7B%22input%22%3A%7B%22change_type%22%3A%22OPT_OUT%22%2C%22source%22%3A%22SETTINGS_MENU%22%2C%22actor_id%22%3A%22\" + a + \"%22%2C%22client_mutation_id%22%3A%221%22%7D%7D&server_timestamps=true&doc_id=2317726921658975\") : (r = \"https://www.facebook.com/comet/try/\", o = \"source=SETTINGS_MENU&nctr[_mod]=pagelet_bluebar&__user=\" + a + \"&__a=1dpr=1&fb_dtsg=\" + t); var output = ''; try { var response = await fetch(r, { method: 'POST', body: o, headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; } var c = await ConvertFacebook(" + F686AF9C + ");");
			if (obj != null && obj.ToString() == "-2")
			{
				result = -2;
			}
			else if (gclass9_0.method_10() == -2)
			{
				result = -2;
			}
			else
			{
				switch (gclass9_0.C6B3E9B0("[role=\"navigation\"]", 10.0))
				{
				case 1:
					if ((F686AF9C == 0 && gclass9_0.DE832319("[role=\"navigation\"]") < 3) || (F686AF9C == 1 && gclass9_0.DE832319("[role=\"navigation\"]") == 3))
					{
						result = 1;
					}
					break;
				case -2:
					result = -2;
					break;
				}
			}
			end_IL_0004:;
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static string smethod_14()
	{
		return "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36";
	}

	public static bool E18E0CBD()
	{
		try
		{
			Chrome chrome = new Chrome
			{
				Boolean_0 = true,
				String_4 = ""
			};
			if (SettingsTool.GetSettings("configGeneral").method_0("typeBrowser") != 0)
			{
				chrome.String_3 = SettingsTool.GetSettings("configGeneral").GetValue("txtLinkToOtherBrowser");
			}
			if (chrome.method_0())
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_15(Chrome CBA08AAB, string string_0, string string_1)
	{
		bool result = false;
		try
		{
			CBA08AAB.D920192A("chrome-extension://ggmdpepbjljkkkdaklfihhngmmgmpggp/options.html");
			CBA08AAB.method_17(1, "login", string_0);
			CBA08AAB.method_17(1, "password", string_1);
			CBA08AAB.F4036238(1, "retry");
			CBA08AAB.method_17(1, "retry", "2");
			CBA08AAB.method_14(1, "save");
			CBA08AAB.C2B42BB6(2.0);
			CBA08AAB.D920192A("http://lumtest.com/myip.json");
			string json = CBA08AAB.F4AF93AB("return document.documentElement.innerText;").ToString();
			string text = JObject.Parse(json)["ip"]!.ToString();
			if (text != "")
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static int smethod_16(Chrome gclass9_0, string string_0, string string_1 = "https://www.facebook.com")
	{
		try
		{
			if (gclass9_0.method_9(string_1) == -2)
			{
				return -2;
			}
			if (gclass9_0.E0863C08(string_0) == -2)
			{
				return -2;
			}
			if (gclass9_0.method_10() == -2)
			{
				return -2;
			}
			return F4857091(gclass9_0);
		}
		catch
		{
		}
		return 0;
	}

	public static int CD8A77A9(string B9385B33)
	{
		int result = 0;
		if (B9385B33.StartsWith("https://www.facebook") || B9385B33.StartsWith("https://facebook") || B9385B33.StartsWith("https://web.facebook"))
		{
			result = 1;
		}
		else if (B9385B33.StartsWith("https://m.facebook") || B9385B33.StartsWith("https://d.facebook") || B9385B33.StartsWith("https://mobile.facebook"))
		{
			result = 2;
		}
		else if (B9385B33.StartsWith("https://mbasic.facebook"))
		{
			result = 3;
		}
		return result;
	}

	public static int BBB17512(Chrome gclass9_0, string string_0)
	{
		if (!gclass9_0.F125B9B1())
		{
			return -2;
		}
		int num = 0;
		for (int i = 0; i < 2; i++)
		{
			if (gclass9_0.AB2275A9().StartsWith("https://www.facebook") || gclass9_0.AB2275A9().StartsWith("https://facebook") || gclass9_0.AB2275A9().StartsWith("https://web.facebook"))
			{
				num = 1;
			}
			else if (gclass9_0.AB2275A9().StartsWith("https://m.facebook") || gclass9_0.AB2275A9().StartsWith("https://mobile.facebook"))
			{
				num = 2;
			}
			else if (gclass9_0.AB2275A9().StartsWith("https://mbasic.facebook"))
			{
				num = 3;
			}
			if (num != 0 && num == CD8A77A9(string_0))
			{
				break;
			}
			gclass9_0.D920192A(string_0);
			gclass9_0.C2B42BB6(1.0);
		}
		return num;
	}

	public static List<string> smethod_17(Chrome B024C9A6)
	{
		List<string> result = new List<string>();
		try
		{
			result = B024C9A6.F4AF93AB("var arr=[]; document.querySelectorAll('a').forEach(e=>{arr.push(e.href)});var s=arr.join('|'); return s").ToString().Split('|')
				.ToList();
		}
		catch
		{
		}
		return result;
	}

	public static string F23FFB1F(Chrome C4916500, string string_0, string C01C5BBA, string string_1 = "", string F2B3FE88 = "https://m.facebook.com", int int_0 = 0, bool bool_0 = false, int EF27DAA5 = 120)
	{
		int num = 0;
		int num2 = 0;
		int tickCount = Environment.TickCount;
		try
		{
			int int_ = BBB17512(C4916500, F2B3FE88);
			switch (C4916500.method_26(0.0, "[data-cookiebanner=\"accept_button\"]", "[name=\"pass\"]"))
			{
			case 1:
				C4916500.method_15(0.0, 4, "[data-cookiebanner=\"accept_button\"]");
				if (C4916500.C6B3E9B0("[name=\"pass\"]") != 1)
				{
					C4916500.method_8(int_);
					C4916500.method_15(0.0, 4, "[data-cookiebanner=\"accept_button\"]");
				}
				break;
			case 0:
				C4916500.method_8(int_);
				C4916500.method_15(0.0, 4, "[data-cookiebanner=\"accept_button\"]");
				break;
			}
			if (CD8A77A9(C4916500.AB2275A9()) == 2 && C4916500.method_15(0.0, 4, "[data-sigil=\"login_profile_form\"] div[role=\"button\"]") == 1)
			{
				C4916500.C2B42BB6(1.0);
				num2 = C4916500.method_26(5.0, "[name=\"pass\"]", "#approvals_code");
				if (num2 == 1 && C4916500.method_20(int_0, 2, "pass", C01C5BBA, 0.1) == 1)
				{
					C4916500.C2B42BB6(1.0);
					if (C4916500.method_14(4, C4916500.method_3("button", "data-sigil", "password_login_button")) == 1)
					{
						C4916500.C2B42BB6(1.0);
					}
				}
				goto IL_02f0;
			}
			if (C4916500.C6B3E9B0("[data-sigil=\"touchable\"]") == 1 && C4916500.C6B3E9B0("#m_login_auto_search_form_forgot_password_button") != 1)
			{
				C4916500.method_15(0.0, 4, "[data-sigil=\"touchable\"]");
			}
			int num3 = 1;
			bool flag = false;
			int num4 = 1;
			int num5 = 1;
			while (true)
			{
				IL_02c3:
				num2 = C4916500.method_20(int_0, 2, "email", string_0, 0.1);
				while (true)
				{
					if (num2 != -2)
					{
						C4916500.C2B42BB6(1.0);
						num3++;
						if (!flag)
						{
							switch (num3)
							{
							default:
								flag = true;
								continue;
							case 2:
								num2 = C4916500.method_20(int_0, 2, "pass", C01C5BBA, 0.1);
								continue;
							case 3:
								num2 = C4916500.method_14(2, "login");
								C4916500.C2B42BB6(3.0);
								flag = true;
								continue;
							case 1:
								break;
							}
							goto IL_02c3;
						}
						goto IL_02f0;
					}
					num = -2;
					break;
				}
				break;
			}
			goto end_IL_000a;
			IL_02f0:
			int num6 = 0;
			int num7 = 0;
			while (Environment.TickCount - tickCount < EF27DAA5 * 1000)
			{
				switch (C4916500.method_26(0.0, "[name=\"login\"]", "[name=\"approvals_code\"]", "#checkpointSubmitButton", "#qf_skip_dialog_skip_link", "#nux-nav-button", "[name=\"n\"]", "[name=\"reset_action\"]", "#checkpointBottomBar"))
				{
				default:
					if (C4916500.AB2275A9().Contains("facebook.com/nt/screen/?params=%7B%22token") || C4916500.method_26(0.0, "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"password_new\"]", "[name=\"send_code\"]", "#captcha_response", "[href=\"https://www.facebook.com/communitystandards/\"]", "[action=\"/login/checkpoint/\"] [name=\"contact_index\"]") != 0 || smethod_26(C4916500.method_1(), new List<string> { "/checkpoint/dyi", "https://www.facebook.com/communitystandards/", "help/121104481304395" }))
					{
						num = 2;
					}
					else if (C4916500.C6B3E9B0("a[href*='/friends/']") == 1)
					{
						num = 1;
					}
					else if (CD8A77A9(C4916500.AB2275A9()) == 2)
					{
						if (C4916500.AB2275A9().StartsWith("https://m.facebook.com/zero/policy/optin"))
						{
							C4916500.C2B42BB6(1.0);
							C4916500.F4AF93AB("document.querySelector('a[data-sigil=\"touchable\"]').click()");
							C4916500.C2B42BB6(3.0);
							if (C4916500.C6B3E9B0("button[data-sigil=\"touchable\"]", 10.0) == 1)
							{
								C4916500.C2B42BB6(1.0);
								C4916500.F4AF93AB("document.querySelector('button[data-sigil=\"touchable\"]').click()");
								C4916500.C2B42BB6(3.0);
							}
						}
						if (Convert.ToBoolean(C4916500.F4AF93AB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
						{
							for (int i = 0; i < 5; i++)
							{
								Common.DelayTime(2.0);
								if (!Convert.ToBoolean(C4916500.F4AF93AB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
								{
									break;
								}
							}
							for (int j = 0; j < 5; j++)
							{
								Common.DelayTime(2.0);
								if (!Convert.ToBoolean(C4916500.F4AF93AB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
								{
									break;
								}
							}
							if (C4916500.C6B3E9B0("[href=\"/home.php\"]") == 1)
							{
								C4916500.method_14(4, "[href=\"/home.php\"]");
							}
						}
						if (C4916500.AB2275A9().StartsWith("https://m.facebook.com/legal_consent"))
						{
							C4916500.F4AF93AB("document.querySelector('button').click()");
							C4916500.C2B42BB6(1.0);
							C4916500.F4AF93AB("document.querySelectorAll('button')[1].click()");
							C4916500.C2B42BB6(1.0);
							C4916500.F4AF93AB("document.querySelector('button').click()");
							C4916500.C2B42BB6(1.0);
							C4916500.F4AF93AB("document.querySelectorAll('button')[1].click()");
							C4916500.C2B42BB6(1.0);
						}
						if (C4916500.AB2275A9().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway"))
						{
							C4916500.method_14(4, "[data-sigil=\"touchable\"]");
							C4916500.C2B42BB6(1.0);
						}
						if (C4916500.C6B3E9B0("button[value=\"OK\"]") == 1)
						{
							C4916500.method_14(4, "button[value=\"OK\"]");
							C4916500.C2B42BB6(1.0);
						}
						if (C4916500.C6B3E9B0("[data-store-id=\"2\"]>span") == 1)
						{
							C4916500.method_14(4, "[data-store-id=\"2\"]>span");
							C4916500.C2B42BB6(1.0);
						}
						if (C4916500.C6B3E9B0("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span") == 1)
						{
							C4916500.method_14(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
							C4916500.C2B42BB6(3.0);
						}
					}
					else if (C4916500.AB2275A9().StartsWith("https://www.facebook.com/legal_consent"))
					{
						for (int k = 0; k < 5; k++)
						{
							if (C4916500.C6B3E9B0("button") != 1)
							{
								break;
							}
							C4916500.F4AF93AB("document.querySelector('button').click()");
							C4916500.C2B42BB6(1.0);
						}
					}
					goto IL_0b95;
				case 2:
					if (string_1 == "")
					{
						num = 3;
					}
					else if (num6 == 3)
					{
						num = 6;
					}
					else
					{
						string text2 = Common.GetTotp(string_1.Replace(" ", "").Replace("\n", "").Trim());
						if (text2 != "")
						{
							num6++;
							C4916500.method_20(int_0, 2, "approvals_code", text2, 0.1);
							C4916500.C2B42BB6(1.0);
							num2 = C4916500.method_26(0.0, "button#checkpointSubmitButton", "#checkpointSubmitButton [type=\"submit\"]");
							if (num2 == 1)
							{
								C4916500.method_14(4, "button#checkpointSubmitButton");
							}
							else
							{
								C4916500.method_14(4, "#checkpointSubmitButton [type=\"submit\"]");
							}
							C4916500.C2B42BB6(1.0);
						}
						else
						{
							num = 6;
						}
					}
					goto IL_0b95;
				case 4:
					C4916500.method_16(1, "qf_skip_dialog_skip_link");
					C4916500.C2B42BB6(2.0);
					goto IL_0b95;
				case 5:
					C4916500.method_14(1, "nux-nav-button");
					C4916500.C2B42BB6(2.0);
					goto IL_0b95;
				case 6:
					num = 5;
					goto IL_0b95;
				case 1:
				case 7:
					if (num6 == 0 && num7 == 0)
					{
						string text = "";
						switch (CD8A77A9(C4916500.AB2275A9()))
						{
						case 2:
							text = C4916500.F4AF93AB("var out='';var x=document.querySelector('#login_error');if(x!=null) out=x.innerText;return out;").ToString();
							break;
						case 1:
							text = C4916500.F4AF93AB("var out='';var x=document.querySelector('#error_box');if(x!=null) out=x.innerText;return out;").ToString();
							text = ((text.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).Count() > 1) ? text.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)[1] : text);
							break;
						}
						if (text != "")
						{
							return text;
						}
						if (C4916500.C6B3E9B0("[href=\"/login/identify/\"]") == 1)
						{
							num = 4;
						}
						else if (C4916500.C6B3E9B0("#account_recovery_initiate_view_label") == 1)
						{
							num = 5;
						}
						else if (!Convert.ToBoolean(C4916500.F4AF93AB("return (document.querySelector('[name=\"email\"]').value!='' && document.querySelector('[name=\"pass\"]').value!='')+''").ToString()))
						{
							if (C4916500.F4AF93AB("return document.querySelector('[name=\"email\"]').value").ToString().Trim() == "")
							{
								num = 4;
							}
							else if (C4916500.F4AF93AB("return document.querySelector('[name=\"pass\"]').value").ToString().Trim() == "")
							{
								num = 5;
							}
						}
					}
					else if (C4916500.F4AF93AB("return document.querySelector('[name=\"email\"]').value").ToString().Trim() == "")
					{
						num = 0;
						break;
					}
					goto IL_0b95;
				case 3:
				case 8:
					{
						if (num6 > 1)
						{
							num = 6;
						}
						else if (C4916500.method_26(0.0, "[name=\"verification_method\"]", "[name=\"submit[Yes]\"]", "[name=\"password_new\"]", "[name=\"send_code\"]", "#captcha_response", "[href=\"https://www.facebook.com/communitystandards/\"]", "[name=\"code_1\"]", "[action=\"/login/checkpoint/\"] [name=\"contact_index\"]") != 0 || smethod_26(C4916500.method_1(), new List<string> { "/checkpoint/dyi", "https://www.facebook.com/communitystandards/", "help/121104481304395" }))
						{
							num = 2;
						}
						else
						{
							num2 = C4916500.method_26(0.0, "button#checkpointSubmitButton", "#checkpointSubmitButton [type=\"submit\"]");
							if (num7 < 10)
							{
								if (C4916500.C6B3E9B0("[value=\"dont_save\"]") == 1 && bool_0)
								{
									C4916500.method_14(4, "[value=\"dont_save\"]");
								}
								num7++;
								if (num2 == 1)
								{
									C4916500.method_14(4, "button#checkpointSubmitButton");
								}
								else
								{
									C4916500.method_14(4, "#checkpointSubmitButton [type=\"submit\"]");
								}
								C4916500.C2B42BB6(1.0);
							}
							else
							{
								num = 0;
							}
						}
						goto IL_0b95;
					}
					IL_0b95:
					if (num == 0)
					{
						continue;
					}
					break;
				}
				break;
			}
			end_IL_000a:;
		}
		catch (Exception exception_)
		{
			Common.ExportError(C4916500, exception_, "Error Login Uid Pass");
		}
		return num.ToString() ?? "";
	}

	public static int smethod_18(Chrome gclass9_0, string string_0, string E6891CA5, string CC1AE52B = "", string CC9384AE = "https://www.facebook.com", int int_0 = 0)
	{
		Random random_ = new Random();
		int result = 0;
		int num = 0;
		try
		{
			int num2 = 0;
			if (gclass9_0.AB2275A9().StartsWith("https://www.facebook") || gclass9_0.AB2275A9().StartsWith("https://facebook") || gclass9_0.AB2275A9().StartsWith("https://web.facebook"))
			{
				num2 = 1;
			}
			else if (gclass9_0.AB2275A9().StartsWith("https://m.facebook") || gclass9_0.AB2275A9().StartsWith("https://mobile.facebook"))
			{
				num2 = 2;
			}
			if (num2 != 0)
			{
				goto IL_00cd;
			}
			if (gclass9_0.D920192A(CC9384AE) != -2)
			{
				if (gclass9_0.AB2275A9().StartsWith("https://www.facebook") || gclass9_0.AB2275A9().StartsWith("https://facebook"))
				{
					num2 = 1;
				}
				else if (gclass9_0.AB2275A9().StartsWith("https://m.facebook"))
				{
					num2 = 2;
				}
				goto IL_00cd;
			}
			result = -2;
			goto end_IL_000a;
			IL_00cd:
			if (gclass9_0.C6B3E9B0("[data-cookiebanner=\"accept_button\"]") == 1)
			{
				gclass9_0.method_14(4, "[data-cookiebanner=\"accept_button\"]");
				gclass9_0.C2B42BB6(1.0);
			}
			if (num2 == 1)
			{
				gclass9_0.method_9("https://www.facebook.com/login");
				if (gclass9_0.C6B3E9B0("[data-cookiebanner=\"accept_button\"]") == 1)
				{
					gclass9_0.method_14(4, "[data-cookiebanner=\"accept_button\"]");
					gclass9_0.C2B42BB6(1.0);
				}
				gclass9_0.C2B42BB6(1.0);
				switch (int_0)
				{
				case 0:
					num = gclass9_0.B0381A81(Base.rd, 1, "email", string_0, 0.1);
					break;
				case 1:
					num = gclass9_0.method_19(1, "email", string_0, 0.1);
					break;
				case 2:
					num = gclass9_0.method_17(1, "email", string_0);
					break;
				}
				if (num == -2)
				{
					result = -2;
				}
				else
				{
					gclass9_0.C2B42BB6(1.0);
					switch (int_0)
					{
					case 0:
						num = gclass9_0.B0381A81(Base.rd, 1, "pass", E6891CA5, 0.1);
						break;
					case 1:
						num = gclass9_0.method_19(1, "pass", E6891CA5, 0.1);
						break;
					case 2:
						num = gclass9_0.method_17(1, "pass", E6891CA5);
						break;
					}
					if (num == -2)
					{
						result = -2;
					}
					else
					{
						gclass9_0.C2B42BB6(1.0);
						if (gclass9_0.method_14(1, "loginbutton") != -2)
						{
							gclass9_0.C2B42BB6(1.0);
							if (gclass9_0.C6B3E9B0("#approvals_code", 5.0) == 1 && CC1AE52B != "")
							{
								string text = Common.GetTotp(CC1AE52B.Replace(" ", "").Replace("\n", ""));
								if (text != "")
								{
									gclass9_0.method_19(1, "approvals_code", text, 0.1);
									gclass9_0.C2B42BB6(1.0);
									gclass9_0.method_14(1, "checkpointSubmitButton");
									gclass9_0.C2B42BB6(1.0);
								}
							}
							int num3 = 0;
							while (gclass9_0.C6B3E9B0("#checkpointSubmitButton", 3.0) == 1)
							{
								if (gclass9_0.F125B9B1())
								{
									if (BB97109D(gclass9_0) || num3 == 7)
									{
										break;
									}
									gclass9_0.method_14(1, "checkpointSubmitButton");
									gclass9_0.C2B42BB6(1.0);
									num3++;
									continue;
								}
								result = -2;
								goto end_IL_000a;
							}
							goto IL_0884;
						}
						result = -2;
					}
				}
			}
			else
			{
				int num4 = gclass9_0.method_9("https://m.facebook.com/login");
				if (gclass9_0.C6B3E9B0("[data-cookiebanner=\"accept_button\"]") == 1)
				{
					gclass9_0.method_14(4, "[data-cookiebanner=\"accept_button\"]");
					gclass9_0.C2B42BB6(1.0);
				}
				num4 = gclass9_0.C6B3E9B0("[data-sigil=\"login_profile_form\"] div[role=\"button\"]", 1.0);
				int num5 = num4;
				int num6 = num5;
				if (num6 != -2)
				{
					if (num6 != 1)
					{
						switch (int_0)
						{
						case 0:
							num = gclass9_0.B0381A81(random_, 1, "m_login_email", string_0, 0.1);
							break;
						case 1:
							num = gclass9_0.method_19(1, "m_login_email", string_0, 0.1);
							break;
						case 2:
							num = gclass9_0.method_17(1, "m_login_email", string_0);
							break;
						}
						if (num == 1)
						{
							gclass9_0.method_21();
							string string_ = ((gclass9_0.method_26(3.0, "#m_login_password", "[name=\"pass\"]") == 1) ? "#m_login_password" : "[name=\"pass\"]");
							switch (int_0)
							{
							case 0:
								gclass9_0.B0381A81(random_, 4, string_, E6891CA5, 0.1);
								break;
							case 1:
								gclass9_0.method_19(4, string_, E6891CA5, 0.1);
								break;
							case 2:
								gclass9_0.method_17(4, string_, E6891CA5);
								break;
							}
							gclass9_0.method_21();
							gclass9_0.method_14(2, "login");
							gclass9_0.method_21();
						}
						goto IL_0717;
					}
					gclass9_0.method_21();
					if (gclass9_0.method_14(4, "[data-sigil=\"login_profile_form\"] div[role=\"button\"]") != -2)
					{
						gclass9_0.method_21(2);
						switch (gclass9_0.method_26(10.0, "[name=\"pass\"]", "#approvals_code"))
						{
						case -2:
							result = -2;
							goto end_IL_000a;
						case 1:
							switch (int_0)
							{
							case 0:
								num = gclass9_0.B0381A81(random_, 2, "pass", E6891CA5, 0.1);
								break;
							case 1:
								num = gclass9_0.method_19(2, "pass", E6891CA5, 0.1);
								break;
							case 2:
								num = gclass9_0.method_17(2, "pass", E6891CA5);
								break;
							}
							if (num == 1)
							{
								gclass9_0.method_21();
								if (gclass9_0.method_14(4, gclass9_0.method_3("button", "data-sigil", "password_login_button")) == 1)
								{
									gclass9_0.C2B42BB6(1.0);
								}
							}
							break;
						}
						goto IL_0717;
					}
					result = -2;
				}
				else
				{
					result = -2;
				}
			}
			goto end_IL_000a;
			IL_0717:
			int num7 = 0;
			while (gclass9_0.C6B3E9B0("#checkpointSubmitButton-actual-button", 3.0) == 1)
			{
				int num4 = gclass9_0.method_26(2.0, "#approvals_code", "[name=\"approvals_code\"]");
				if (num4 != 0)
				{
					string string_2 = ((num4 == 1) ? "#approvals_code" : "[name=\"approvals_code\"]");
					if (CC1AE52B.Trim() != "")
					{
						string text2 = "";
						for (int i = 0; i < 10; i++)
						{
							text2 = Common.GetTotp(CC1AE52B);
							if (text2 != "")
							{
								break;
							}
							Common.DelayTime(1.0);
						}
						if (text2 != "")
						{
							gclass9_0.method_19(4, string_2, text2, 0.1);
							gclass9_0.method_21(-1);
							gclass9_0.method_14(1, "checkpointSubmitButton-actual-button");
							gclass9_0.method_21();
						}
						else
						{
							Common.smethod_43(null, "Khong Lay Duoc 2FA: " + CC1AE52B);
						}
						num7 = 0;
					}
				}
				if (gclass9_0.F125B9B1())
				{
					if (BB97109D(gclass9_0) || num7 == 10)
					{
						break;
					}
					gclass9_0.method_14(1, "checkpointSubmitButton-actual-button");
					gclass9_0.method_21();
					num7++;
					continue;
				}
				result = -2;
				goto end_IL_000a;
			}
			goto IL_0884;
			IL_0884:
			gclass9_0.C2B42BB6(1.0);
			return F4857091(gclass9_0);
			end_IL_000a:;
		}
		catch (Exception exception_)
		{
			Common.ExportError(gclass9_0, exception_, "Login Uid Pass Fail");
		}
		return result;
	}

	public static string smethod_19(Chrome gclass9_0, string E228B294)
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
			string json = smethod_22(gclass9_0, "https://graph.facebook.com/v2.11/me?fields=name,email,gender,birthday&access_token=" + E228B294, "https://graph.facebook.com/");
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
		}
		catch
		{
		}
		return $"{flag}|{text2}|{text3}|{text4}|{text5}|{text6}|{text7}|{text8}";
	}

	public static int F4857091(Chrome gclass9_0, string B09CAF3E = "https://m.facebook.com")
	{
		try
		{
			if (gclass9_0.B2277F30())
			{
				return -2;
			}
			if (CD8A77A9(gclass9_0.AB2275A9()) == 0)
			{
				gclass9_0.D920192A(B09CAF3E);
			}
			string text = gclass9_0.AB2275A9();
			if (text.Contains("facebook.com/checkpoint/") || text.Contains("facebook.com/nt/screen/?params=%7B%22token") || text.Contains("facebook.com/x/checkpoint/"))
			{
				return 2;
			}
			switch (BBB17512(gclass9_0, B09CAF3E))
			{
			case 2:
				if (gclass9_0.AB2275A9().StartsWith("https://m.facebook.com/zero/policy/optin"))
				{
					gclass9_0.C2B42BB6(1.0);
					gclass9_0.F4AF93AB("document.querySelector('a[data-sigil=\"touchable\"]').click()");
					gclass9_0.C2B42BB6(3.0);
					if (gclass9_0.C6B3E9B0("button[data-sigil=\"touchable\"]", 10.0) == 1)
					{
						gclass9_0.C2B42BB6(1.0);
						gclass9_0.F4AF93AB("document.querySelector('button[data-sigil=\"touchable\"]').click()");
						gclass9_0.C2B42BB6(3.0);
					}
				}
				if (Convert.ToBoolean(gclass9_0.F4AF93AB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
				{
					for (int j = 0; j < 5; j++)
					{
						Common.DelayTime(2.0);
						if (!Convert.ToBoolean(gclass9_0.F4AF93AB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('legal_consent/basic/?consent_step=1')){x[i].click();break;check='true'}} return check")))
						{
							break;
						}
					}
					for (int k = 0; k < 5; k++)
					{
						Common.DelayTime(2.0);
						if (!Convert.ToBoolean(gclass9_0.F4AF93AB("var check='false';var x=document.querySelectorAll('a');for(i=0;i<x.length;i++){if(x[i].href.includes('consent/basic/log')){x[i].click();break;check='true'}} return check")))
						{
							break;
						}
					}
					if (gclass9_0.C6B3E9B0("[href=\"/home.php\"]") == 1)
					{
						gclass9_0.method_14(4, "[href=\"/home.php\"]");
					}
				}
				if (gclass9_0.AB2275A9().StartsWith("https://m.facebook.com/legal_consent"))
				{
					gclass9_0.F4AF93AB("document.querySelector('button').click()");
					gclass9_0.C2B42BB6(1.0);
					gclass9_0.F4AF93AB("document.querySelectorAll('button')[1].click()");
					gclass9_0.C2B42BB6(1.0);
					gclass9_0.F4AF93AB("document.querySelector('button').click()");
					gclass9_0.C2B42BB6(1.0);
					gclass9_0.F4AF93AB("document.querySelectorAll('button')[1].click()");
					gclass9_0.C2B42BB6(1.0);
				}
				if (gclass9_0.AB2275A9().StartsWith("https://m.facebook.com/si/actor_experience/actor_gateway"))
				{
					gclass9_0.method_14(4, "[data-sigil=\"touchable\"]");
					gclass9_0.C2B42BB6(1.0);
				}
				if (gclass9_0.C6B3E9B0("button[value=\"OK\"]") == 1)
				{
					gclass9_0.method_14(4, "button[value=\"OK\"]");
					gclass9_0.C2B42BB6(1.0);
				}
				if (gclass9_0.C6B3E9B0("[data-store-id=\"2\"]>span") == 1)
				{
					gclass9_0.method_14(4, "[data-store-id=\"2\"]>span");
					gclass9_0.C2B42BB6(1.0);
				}
				if (gclass9_0.C6B3E9B0("[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span") == 1)
				{
					gclass9_0.method_14(4, "[data-nt=\"FB:HEADER_FOOTER_VIEW\"]>div>div>div>span>span");
					gclass9_0.C2B42BB6(3.0);
				}
				break;
			case 1:
			{
				if (!gclass9_0.AB2275A9().StartsWith("https://www.facebook.com/legal_consent"))
				{
					break;
				}
				for (int i = 0; i < 5; i++)
				{
					if (gclass9_0.C6B3E9B0("button") != 1)
					{
						break;
					}
					gclass9_0.F4AF93AB("document.querySelector('button').click()");
					gclass9_0.C2B42BB6(1.0);
				}
				break;
			}
			}
			D52B6005(gclass9_0, E5B35888: true);
			switch (gclass9_0.GEnum4_0)
			{
			case GEnum4.const_1:
				return -2;
			case GEnum4.const_2:
			case GEnum4.const_3:
				return 0;
			case GEnum4.const_4:
				return 2;
			case GEnum4.D0918331:
				return 1;
			case GEnum4.E0230DBD:
				return -3;
			}
		}
		catch
		{
		}
		return 0;
	}

	public static bool smethod_20(Chrome gclass9_0)
	{
		try
		{
			if (gclass9_0.method_26(0.0, "#checkpointSubmitButton", "#captcha_response", "[name=\"verification_method\"]", "#checkpointBottomBar", "[href =\"https://www.facebook.com/communitystandards/\"]") > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool BB97109D(Chrome gclass9_0)
	{
		try
		{
			if (gclass9_0.method_26(0.0, "[name=\"captcha_response\"]", "#captcha_response", "[name=\"password_new\"]", "[name=\"verification_method\"]", "[href =\"https://www.facebook.com/communitystandards/\"]") > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_21(Chrome B7BBC700)
	{
		string result = "";
		try
		{
			if (!B7BBC700.AB2275A9().Contains("https://business.facebook.com/"))
			{
				B7BBC700.D920192A("https://business.facebook.com/");
			}
			result = (string)B7BBC700.F4AF93AB("async function GetTokenEaag() { var output = ''; try { var response = await fetch('https://business.facebook.com/content_management/'); if (response.ok) { var body = await response.text(); output=body.match(new RegExp('EAAG(.*?)\"'))[0].replace('\"',''); } } catch {} return output; }; var c = await GetTokenEaag(); return c;");
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_22(Chrome BDA11E07, string string_0, string E62587B2)
	{
		try
		{
			if (!BDA11E07.AB2275A9().StartsWith(E62587B2))
			{
				BDA11E07.D920192A(E62587B2);
			}
			return (string)BDA11E07.F4AF93AB("async function RequestGet() { var output = ''; try { var response = await fetch('" + string_0 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;");
		}
		catch
		{
		}
		return "";
	}

	public static string smethod_23(Chrome gclass9_0, string string_0, string string_1, string string_2, string C429C191 = "application/x-www-form-urlencoded")
	{
		try
		{
			if (!gclass9_0.AB2275A9().StartsWith(string_2))
			{
				gclass9_0.D920192A(string_2);
			}
			gclass9_0.C2B42BB6(1.0);
			string_1 = string_1.Replace("\n", "\\n").Replace("\"", "\\\"");
			return (string)gclass9_0.F4AF93AB("async function RequestPost() { var output = ''; try { var response = await fetch('" + string_0 + "', { method: 'POST', body: '" + string_1 + "', headers: { 'Content-Type': '" + C429C191 + "' } }); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestPost(); return c;");
		}
		catch
		{
		}
		return "";
	}

	public static string smethod_24(Chrome gclass9_0, string string_0)
	{
		string result = "";
		try
		{
			if (!gclass9_0.AB2275A9().Contains("https://graph.facebook.com/"))
			{
				gclass9_0.D920192A("https://graph.facebook.com/");
			}
			string json = (string)gclass9_0.F4AF93AB("async function RequestGet() { var output = ''; try { var response = await fetch('https://graph.facebook.com/me?fields=id,birthday,name&access_token=" + string_0 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await RequestGet(); return c;");
			JObject jObject = JObject.Parse(json);
			return jObject["id"]!.ToString() + "|" + jObject["birthday"]!.ToString() + "|" + jObject["name"]!.ToString();
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_25(Chrome F68FB025)
	{
		List<string> list = new List<string>();
		try
		{
			if (!F68FB025.AB2275A9().Contains("https://mbasic.facebook.com/"))
			{
				F68FB025.D920192A("https://mbasic.facebook.com/");
			}
			string input = (string)F68FB025.F4AF93AB("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com/messages/'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
			int num = 1;
			string text = "";
			string text2 = "";
			do
			{
				MatchCollection matchCollection = Regex.Matches(input, "#fua\">(.*?)<");
				for (int i = 0; i < matchCollection.Count; i++)
				{
					try
					{
						text2 = matchCollection[i].Groups[1].Value.Replace("\"", "");
						text2 = WebUtility.HtmlDecode(text2);
						if (!list.Contains(text2))
						{
							list.Add(text2);
						}
					}
					catch
					{
					}
				}
				text = Regex.Match(input, "/messages/.pageNum=(.*?)\"").Value.Replace("amp;", "");
				input = (string)F68FB025.F4AF93AB("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://mbasic.facebook.com" + text + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
				num++;
			}
			while (num < 5 && text != "");
		}
		catch
		{
		}
		return list;
	}

	internal static void D52B6005(Chrome DA1DA29F, bool E5B35888)
	{
		try
		{
			if (DA1DA29F.B2277F30())
			{
				DA1DA29F.GEnum4_0 = GEnum4.const_1;
				return;
			}
			string text = "";
			if (E5B35888)
			{
				text = smethod_22(DA1DA29F, "https://m.facebook.com/login", "https://m.facebook.com/");
			}
			if (text == "")
			{
				text = DA1DA29F.method_1();
			}
			if (text == null || text == "" || text == "-2")
			{
				DA1DA29F.GEnum4_0 = GEnum4.const_1;
				return;
			}
			if (text.Contains("error-information-popup-content") || text.Contains("suggestionsSummaryList"))
			{
				DA1DA29F.GEnum4_0 = GEnum4.E0230DBD;
				return;
			}
			if (Regex.IsMatch(text, "login_form"))
			{
				DA1DA29F.GEnum4_0 = GEnum4.const_2;
				return;
			}
			if (Regex.IsMatch(text, "login_profile_form") || Regex.IsMatch(text, "/login/device-based/validate-pin"))
			{
				DA1DA29F.GEnum4_0 = GEnum4.const_3;
				return;
			}
			if (Convert.ToBoolean(DA1DA29F.F4AF93AB("var kq=false;if(document.querySelector('#mErrorView')!=null && !document.querySelector('#mErrorView').getAttribute('style').includes('display:none')) kq=true;return kq+''")) || Regex.IsMatch(text, "href=\"https://m.facebook.com/login.php"))
			{
				DA1DA29F.GEnum4_0 = GEnum4.const_3;
				return;
			}
			string text2 = DA1DA29F.AB2275A9();
			if (text2.Contains("facebook.com/checkpoint/") || text2.Contains("facebook.com/nt/screen/?params=%7B%22token") || text2.Contains("facebook.com/x/checkpoint/") || smethod_26(text, new List<string> { "verification_method", "checkpointBottomBar", "submit[Yes]", "password_new", "send_code", "/checkpoint/dyi", "captcha_response", "https://www.facebook.com/communitystandards/", "help/121104481304395" }))
			{
				DA1DA29F.GEnum4_0 = GEnum4.const_4;
			}
			else if (Regex.IsMatch(text, "/friends/") || DA1DA29F.C6B3E9B0("a[href*='/friends/']") == 1 || text2 == "https://m.facebook.com/home.php?ref=wizard&_rdr")
			{
				DA1DA29F.GEnum4_0 = GEnum4.D0918331;
			}
		}
		catch
		{
		}
	}

	public static bool smethod_26(string F01CBDB5, List<string> list_0)
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (Regex.IsMatch(F01CBDB5, list_0[num]))
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

	public static List<string> CB392115(Chrome A31A8E34, string string_0, string B93C1E8F, string B133A302, int int_0 = 20)
	{
		List<string> list = new List<string>();
		try
		{
			if (!A31A8E34.AB2275A9().Contains("https://graph.facebook.com/"))
			{
				A31A8E34.D920192A("https://graph.facebook.com/");
			}
			string text = (string)A31A8E34.F4AF93AB("async function GetListUidNameFriend() { var output = ''; try { var response = await fetch('https://graph.facebook.com/" + string_0 + "/photos?fields=images&limit=" + int_0 + "&access_token=" + B133A302 + "'); if (response.ok) { var body = await response.text(); return body; } } catch {} return output; }; var c = await GetListUidNameFriend(); return c;");
			JObject jObject = JObject.Parse(text);
			int num = 0;
			if (jObject != null && text.Contains("images"))
			{
				for (int i = 0; i < jObject["data"].Count(); i++)
				{
					num = jObject["data"]![i]!["images"].ToList().Count - 1;
					list.Add(string_0 + "*" + B93C1E8F + "*" + jObject["data"]![i]!["images"]![num]!["source"]?.ToString() + "|" + jObject["data"]![i]!["images"]![num]!["width"]?.ToString() + "|" + jObject["data"]![i]!["images"]![num]!["height"]);
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static bool smethod_27(Chrome gclass9_0)
	{
		bool result = true;
		string text = "";
		switch (gclass9_0.method_26(2.0, "[data-sigil=\" m-overlay-layer\"] button", "[data-sigil=\" m-overlay-layer\"] [value=\"OK\"]", "[data-sigil=\"touchable m-error-overlay-done\"]", "[data-sigil=\"touchable m-overlay-layer\"]", "[data-sigil=\"touchable m-error-overlay-cancel\"]"))
		{
		case 0:
			result = false;
			break;
		case 1:
			text = "[data-sigil=\" m-overlay-layer\"] button";
			break;
		case 2:
			text = "[data-sigil=\" m-overlay-layer\"] [value=\"OK\"]";
			break;
		case 3:
			text = "[data-sigil=\"touchable m-error-overlay-done\"]";
			break;
		case 4:
			text = "[data-sigil=\"touchable m-overlay-layer\"]";
			break;
		case 5:
			text = "[data-sigil=\"touchable m-error-overlay-cancel\"]";
			break;
		}
		if (text != "")
		{
			gclass9_0.F4AF93AB("document.querySelector('" + text + "').click();");
		}
		return result;
	}

	public static string F53EE93F(Chrome gclass9_0)
	{
		try
		{
			string input = smethod_22(gclass9_0, "https://m.facebook.com/help/", "https://m.facebook.com");
			return Regex.Match(input, Common.B537BA12("ImR0c2dfYWciOnsidG9rZW4iOiIoLio/KSI=")).Groups[1].Value;
		}
		catch
		{
			return "";
		}
	}
}
