using System;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

public class ImapHelper
{
    public static bool CheckConnectImap(string email, string passmail)
	{
        return PhoneFarmLib.ImapHelper.CheckConnectImap(email, passmail);
    }

	public static string GetOtpFromMail(int type, string email, string passmail, int timeout, string string_1, string B1AEEC18)
	{
		string text = "";
		try
		{
			if (type == 5)
			{
				type = 4;
			}
			int tickCount = Environment.TickCount;
			do
			{
				text = PhoneFarmLib.ImapHelper.ConnectImap(type, email, passmail);
                if (!(text != ""))
				{
					Common.DelayTime(1.0);
					continue;
				}
				break;
			}
			while (Environment.TickCount - tickCount < timeout * 1000);
		}
		catch
		{
		}
		return text;
	}
}
