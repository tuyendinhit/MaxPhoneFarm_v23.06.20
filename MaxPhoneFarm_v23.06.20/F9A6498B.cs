using System.IO;

public class F9A6498B
{
	internal uint uint_0;

	internal uint uint_1 = 1u;

	internal uint uint_2;

	internal uint uint_3;

	internal uint uint_4;

	internal Stream stream_0;

	internal byte[] byte_0;

	public void method_0()
	{
	}

	public byte DF075D16(uint uint_5)
	{
		if (0 < uint_2)
		{
		}
		return byte_0[0];
	}

	public void method_1()
	{
		method_0();
		stream_0 = null;
	}

	public void CF16FBB2(uint A3AC7E15, uint B0A6A8BD)
	{
		if (0 >= uint_2)
		{
		}
		while (B0A6A8BD != 0)
		{
			if (0 < uint_2)
			{
			}
			byte_0[uint_3++] = byte_0[0];
			if (uint_3 >= uint_2)
			{
				method_0();
			}
			B0A6A8BD--;
		}
	}

	public void method_2(byte byte_1)
	{
		byte_0[uint_3++] = byte_1;
		if (uint_3 >= uint_2)
		{
			method_0();
		}
	}

	public void method_3(Stream stream_1, bool bool_0)
	{
		method_1();
		stream_0 = stream_1;
		if (!bool_0)
		{
			uint_4 = 0u;
			uint_3 = 0u;
			uint_0 = 0u;
		}
	}

	public void method_4(uint A888288E)
	{
		if (uint_2 != A888288E)
		{
			byte_0 = new byte[A888288E];
		}
		uint_2 = A888288E;
		uint_3 = 0u;
		uint_4 = 0u;
	}
}
