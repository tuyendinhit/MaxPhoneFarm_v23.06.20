using System;

public static class GClass6
{
	public static bool B62D3203(string D991853E)
	{
		try
		{
			Convert.ToInt32(D991853E);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_0(this string A1AAD797, int int_0 = 0, char char_0 = '*')
	{
		try
		{
			string text = "";
			for (int i = 0; i < A1AAD797.Length; i++)
			{
				if (A1AAD797[i] != char_0)
				{
					text += A1AAD797[i];
					continue;
				}
				switch (int_0)
				{
				case 0:
					text += Common.CreateRandomNumber(1);
					break;
				case 1:
					text += Common.CreateRandomString(1);
					break;
				case 2:
					text += Common.CreateRandomStringNumber(1);
					break;
				}
			}
			return text;
		}
		catch
		{
		}
		return "";
	}
}
