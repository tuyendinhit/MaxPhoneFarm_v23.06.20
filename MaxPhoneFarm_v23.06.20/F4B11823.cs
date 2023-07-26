using System;
using System.Runtime.CompilerServices;
using System.Threading;

public static class F4B11823
{
	[Serializable]
	[CompilerGenerated]
	private sealed class FF82B702
	{
		internal static readonly FF82B702 _003C_003E9 = new FF82B702();

		internal static ThreadStart _003C_003E9__1_0;

		internal void FC24B112()
		{
			while (bool_0)
			{
				try
				{
					string text = GClass1.D22E1AB1("adb devices", 5);
					if (!text.Split('|')[0].Trim().Contains("List of devices attached"))
					{
						GClass1.smethod_2();
						GClass1.smethod_3();
					}
				}
				catch (Exception)
				{
				}
				if (bool_0)
				{
					Common.DelayTime(60.0);
					continue;
				}
				break;
			}
		}
	}

	internal static bool bool_0;

	public static void smethod_0()
	{
		if (bool_0)
		{
			return;
		}
		bool_0 = true;
		Thread thread = new Thread((ThreadStart)delegate
		{
			while (bool_0)
			{
				try
				{
					string text = GClass1.D22E1AB1("adb devices", 5);
					if (!text.Split('|')[0].Trim().Contains("List of devices attached"))
					{
						GClass1.smethod_2();
						GClass1.smethod_3();
					}
				}
				catch (Exception)
				{
				}
				if (!bool_0)
				{
					break;
				}
				Common.DelayTime(60.0);
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	public static void EE87B2B7()
	{
		bool_0 = false;
	}
}
