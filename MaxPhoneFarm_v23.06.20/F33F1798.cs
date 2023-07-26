using System;

public static class F33F1798
{
	internal static uint[] E3273918;

	public unsafe static uint E79C481B(IntPtr intptr_0, uint uint_0)
	{
		intptr_0.ToPointer();
		for (int i = 0; i < uint_0; i++)
		{
		}
		return uint.MaxValue;
	}

	static F33F1798()
	{
		E3273918 = new uint[256];
		for (int i = 0; i < E3273918.Length; i++)
		{
			uint num = (uint)i;
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ 0xEDB88320u));
			}
			E3273918[i] = num;
		}
	}
}
