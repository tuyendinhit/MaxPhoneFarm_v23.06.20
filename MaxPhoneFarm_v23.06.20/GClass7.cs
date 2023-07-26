using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class GClass7
{
	public delegate bool GDelegate0(IntPtr intptr_0, IntPtr intptr_1);

	private delegate bool Delegate0(IntPtr CDA65FA2, IntPtr intptr_0);

	[Flags]
	public enum GEnum2 : uint
	{
		flag_0 = 0x2u,
		flag_1 = 0x4u,
		flag_2 = 0x20u,
		flag_3 = 0x40u,
		flag_4 = 0x1u,
		E42A7893 = 0x8000u,
		flag_6 = 0x8u,
		flag_7 = 0x10u,
		flag_8 = 0x800u,
		flag_9 = 0x80u,
		DFBC4601 = 0x100u,
		flag_11 = 0x1u,
		flag_12 = 0x2u
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("User32.dll")]
	public static extern bool EnumChildWindows(IntPtr C3B1F61A, GDelegate0 gdelegate0_0, IntPtr intptr_0);

	[DllImport("User32.dll")]
	public static extern int GetWindowText(IntPtr EC3571AA, StringBuilder EA0C27BB, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetClassName(IntPtr intptr_0, StringBuilder stringBuilder_0, int C59E6826);

	[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
	private static extern IntPtr FindWindow_1(IntPtr intptr_0, string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_1(IntPtr intptr_0, int D32F0412, int DB89678C, IntPtr C385418A);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_2(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", EntryPoint = "SendMessage")]
	private static extern IntPtr SendMessage_3(IntPtr intptr_0, int C01CD78D, IntPtr intptr_1, string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "SendMessage")]
	public static extern int SendMessage_4(IntPtr A202DCA3, int int_0, int int_1, string string_0);

	[DllImport("user32.dll")]
	private static extern IntPtr GetDlgItem(IntPtr D4812718, int int_0);

	[DllImport("user32.dll")]
	private static extern bool SetDlgItemTextA(IntPtr CAA1CE99, int A7390A08, string E728D835);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr DD18AA05, string B53E21AB, string string_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr C70EE42E, int int_0, IntPtr CCB1B62C, IntPtr intptr_0);

	[DllImport("user32.dll", EntryPoint = "PostMessage")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage_1(IntPtr C72F40A7, int FF1DEE17, IntPtr intptr_0, string string_0);

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr intptr_0);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetWindowRect(IntPtr C8BE9415, ref GStruct0 E726D58F);

	[DllImport("user32", EntryPoint = "EnumChildWindows")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool EnumChildWindows_1(IntPtr intptr_0, Delegate0 AF8CD898, IntPtr intptr_1);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern void mouse_event(uint E00E29B5, int int_0, int int_1, int int_2, UIntPtr F1B12E9E);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr BCA68E84, int int_0, int D696ACA8, int C6BCF33B, int int_1, bool bool_0);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint SendInput(uint uint_0, BA8F7E14[] C3266B20, int int_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr intptr_0);

	public static IntPtr B9243B80(string string_0, string string_1 = null)
	{
		IntPtr intPtr = FindWindow(string_0, string_1);
		SetForegroundWindow(intPtr);
		return intPtr;
	}

	public static IntPtr smethod_0(IntPtr intptr_0)
	{
		SetForegroundWindow(intptr_0);
		return intptr_0;
	}

	public static bool smethod_1(IntPtr intptr_0)
	{
		return IsWindowVisible(intptr_0);
	}

	public static IntPtr smethod_2(string string_0, string string_1)
	{
		return FindWindow(string_0, string_1);
	}

	public static List<IntPtr> F02B8E34(string B734C423, string string_0, int CB277B81 = 1)
	{
		Process[] processes = Process.GetProcesses();
		List<IntPtr> list = new List<IntPtr>();
		int num = 0;
		foreach (Process item in processes.Where((Process EF2CF4B9) => EF2CF4B9.MainWindowHandle != IntPtr.Zero))
		{
			IntPtr mainWindowHandle = item.MainWindowHandle;
			string text = smethod_31(mainWindowHandle);
			string text2 = BEB27015(mainWindowHandle);
			if (text == B734C423 || text2 == string_0)
			{
				list.Add(mainWindowHandle);
				if (num >= CB277B81)
				{
					break;
				}
				num++;
			}
		}
		return list;
	}

	public static IntPtr smethod_3(string string_0, string FA8EF9BB)
	{
		Process[] processes = Process.GetProcesses();
		IntPtr result = IntPtr.Zero;
		foreach (Process item in processes.Where((Process CFA40A34) => CFA40A34.MainWindowHandle != IntPtr.Zero))
		{
			IntPtr mainWindowHandle = item.MainWindowHandle;
			string text = smethod_31(mainWindowHandle);
			string text2 = BEB27015(mainWindowHandle);
			if (text == string_0 || text2 == FA8EF9BB)
			{
				result = mainWindowHandle;
				break;
			}
		}
		return result;
	}

	public static IntPtr smethod_4(IntPtr intptr_0, string string_0, string string_1)
	{
		return FindWindowEx(intptr_0, IntPtr.Zero, string_1, string_0);
	}

	private static IntPtr B40EA614(IntPtr intptr_0, int int_0)
	{
		if (int_0 == 0)
		{
			return intptr_0;
		}
		int num = 0;
		IntPtr intPtr = IntPtr.Zero;
		do
		{
			intPtr = FindWindowEx(intptr_0, intPtr, "Button", null);
			if (intPtr != IntPtr.Zero)
			{
				num++;
			}
		}
		while (num < int_0 && intPtr != IntPtr.Zero);
		return intPtr;
	}

	public static IntPtr B79B8C20(IntPtr C23D4727, int int_0)
	{
		return GetDlgItem(C23D4727, int_0);
	}

	public static List<IntPtr> smethod_5(IntPtr DD813C8A)
	{
		List<IntPtr> list = new List<IntPtr>();
		GCHandle value = GCHandle.Alloc(list);
		IntPtr intptr_ = GCHandle.ToIntPtr(value);
		try
		{
			Delegate0 aF8CD = delegate(IntPtr intptr_0, IntPtr C09EA08A)
			{
				GCHandle gCHandle = GCHandle.FromIntPtr(C09EA08A);
				if (gCHandle.Target == null)
				{
					return false;
				}
				List<IntPtr> list2 = gCHandle.Target as List<IntPtr>;
				list2.Add(intptr_0);
				return true;
			};
			EnumChildWindows_1(DD813C8A, aF8CD, intptr_);
		}
		finally
		{
			value.Free();
		}
		return list;
	}

	public static IntPtr E628EABF(List<IntPtr> list_0, string string_0, string FF3AAD28)
	{
		return list_0.Find(delegate(IntPtr intptr_0)
		{
			string text = smethod_31(intptr_0);
			string text2 = BEB27015(intptr_0);
			return text == string_0 || text2 == FF3AAD28;
		});
	}

	public static List<IntPtr> C1B1270A(List<IntPtr> CE3F5A95, string string_0, string F827560B)
	{
		new List<IntPtr>();
		IEnumerable<IntPtr> source = CE3F5A95.Where(delegate(IntPtr intptr_0)
		{
			string text = smethod_31(intptr_0);
			string text2 = BEB27015(intptr_0);
			return text == string_0 || text2 == F827560B;
		});
		return source.ToList();
	}

	public static IntPtr smethod_6(IntPtr intptr_0, string AF355D81, string C5315688)
	{
		return E628EABF(smethod_5(intptr_0), AF355D81, C5315688);
	}

	public static List<IntPtr> C783668D(IntPtr intptr_0, string string_0, string A2A2FB86)
	{
		return C1B1270A(smethod_5(intptr_0), string_0, A2A2FB86);
	}

	public static bool smethod_7(IntPtr intptr_0, IntPtr E8B27E81)
	{
		string text = BEB27015(intptr_0);
		string text2 = smethod_31(intptr_0);
		if (text == "&Options >>" && text2.StartsWith("ToolbarWindow32"))
		{
			SendMessage_2(intptr_0, 0, IntPtr.Zero, IntPtr.Zero);
			return false;
		}
		return true;
	}

	public static void smethod_8(IntPtr F012B423, int D4033B32)
	{
		IntPtr dlgItem = GetDlgItem(F012B423, D4033B32);
		int dB89678C = 0 | (D4033B32 & 0xFFFF);
		SendMessage_1(F012B423, 273, dB89678C, dlgItem);
	}

	public static void C51B44AA(IntPtr D3883295)
	{
		SendMessage_2(D3883295, 513, IntPtr.Zero, IntPtr.Zero);
		SendMessage_2(D3883295, 514, IntPtr.Zero, IntPtr.Zero);
	}

	public static void smethod_9(IntPtr E635128A, int int_0, int B8A1B4AA, GEnum1 genum1_0 = GEnum1.F61F8CB1, int B126B7AB = 1)
	{
		int int_ = 0;
		int int_2 = 0;
		if (genum1_0 == GEnum1.F61F8CB1)
		{
			int_ = 513;
			int_2 = 514;
		}
		if (genum1_0 == GEnum1.const_1)
		{
			int_ = 516;
			int_2 = 517;
		}
		IntPtr intptr_ = smethod_32(int_0, B8A1B4AA);
		if (genum1_0 == GEnum1.F61F8CB1 || genum1_0 == GEnum1.const_1)
		{
			for (int i = 0; i < B126B7AB; i++)
			{
				PostMessage(E635128A, 6, new IntPtr(1), intptr_);
				PostMessage(E635128A, int_, new IntPtr(1), intptr_);
				PostMessage(E635128A, int_2, new IntPtr(0), intptr_);
			}
			return;
		}
		if (genum1_0 == GEnum1.const_2)
		{
			int_ = 515;
			int_2 = 514;
		}
		if (genum1_0 == GEnum1.const_3)
		{
			int_ = 518;
			int_2 = 517;
		}
		PostMessage(E635128A, int_, new IntPtr(1), intptr_);
		PostMessage(E635128A, int_2, new IntPtr(0), intptr_);
	}

	public static void smethod_10(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, int int_4 = 10, int FE14F21B = 10, double double_0 = 0.05)
	{
		int int_5 = 513;
		int int_6 = 514;
		IntPtr intptr_ = smethod_32(int_0, int_1);
		IntPtr intptr_2 = smethod_32(int_2, int_3);
		if (int_2 < int_0)
		{
			int_4 *= -1;
		}
		if (int_3 < int_1)
		{
			FE14F21B *= -1;
		}
		PostMessage(intptr_0, 6, new IntPtr(1), intptr_);
		PostMessage(intptr_0, int_5, new IntPtr(1), intptr_);
		bool flag = false;
		bool flag2 = false;
		while (true)
		{
			PostMessage(intptr_0, 512, new IntPtr(1), smethod_32(int_0, int_1));
			if (int_4 <= 0)
			{
				if (int_0 > int_2)
				{
					int_0 += int_4;
				}
				else
				{
					flag = true;
				}
			}
			else if (int_0 < int_2)
			{
				int_0 += int_4;
			}
			else
			{
				flag = true;
			}
			if (FE14F21B > 0)
			{
				if (int_1 < int_3)
				{
					int_1 += FE14F21B;
				}
				else
				{
					flag2 = true;
				}
			}
			else if (int_1 > int_3)
			{
				int_1 += FE14F21B;
			}
			else
			{
				flag2 = true;
			}
			if (flag && flag2)
			{
				break;
			}
			Thread.Sleep(TimeSpan.FromSeconds(double_0));
		}
		PostMessage(intptr_0, int_6, new IntPtr(0), intptr_2);
	}

	public static void smethod_11(IntPtr EB357D02, int C93D4438, int A9AF1EB7, GEnum1 genum1_0 = GEnum1.F61F8CB1, int BC90230D = 1)
	{
		int int_ = 0;
		if (genum1_0 == GEnum1.F61F8CB1)
		{
			int_ = 513;
		}
		if (genum1_0 == GEnum1.const_1)
		{
			int_ = 516;
		}
		IntPtr intptr_ = smethod_32(C93D4438, A9AF1EB7);
		for (int i = 0; i < BC90230D; i++)
		{
			PostMessage(EB357D02, 6, new IntPtr(1), intptr_);
			PostMessage(EB357D02, int_, new IntPtr(1), intptr_);
		}
	}

	public static void smethod_12(IntPtr intptr_0, int int_0, int int_1, GEnum1 genum1_0 = GEnum1.F61F8CB1, int int_2 = 1)
	{
		int int_3 = 0;
		if (genum1_0 == GEnum1.F61F8CB1)
		{
			int_3 = 514;
		}
		if (genum1_0 == GEnum1.const_1)
		{
			int_3 = 517;
		}
		IntPtr intPtr = smethod_32(int_0, int_1);
		for (int i = 0; i < int_2; i++)
		{
			PostMessage(intptr_0, 6, new IntPtr(1), intPtr);
			SendMessage_2(intptr_0, int_3, new IntPtr(0), intPtr);
		}
	}

	public static void smethod_13(IntPtr A22B749B, string string_0)
	{
		SendMessage_4(A22B749B, 12, 0, string_0);
	}

	public static void C43F3117(IntPtr intptr_0, AF05EE3D F13F9D10)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 256, new IntPtr((int)F13F9D10), new IntPtr(1));
		PostMessage(intptr_0, 257, new IntPtr((int)F13F9D10), new IntPtr(0));
	}

	public static void smethod_14(IntPtr D11CD210, string string_0, float float_0 = 0.1f)
	{
		string text = string_0.ToLower();
		foreach (char c in text)
		{
			AF05EE3D f13F9D = AF05EE3D.const_31;
			char c2 = c;
			switch (c2)
			{
			default:
				switch (c2)
				{
				case 'a':
					f13F9D = AF05EE3D.const_41;
					break;
				case 'b':
					f13F9D = AF05EE3D.FC108E31;
					break;
				case 'c':
					f13F9D = AF05EE3D.const_62;
					break;
				case 'd':
					f13F9D = AF05EE3D.const_44;
					break;
				case 'e':
					f13F9D = AF05EE3D.const_45;
					break;
				case 'f':
					f13F9D = AF05EE3D.B0A4A38A;
					break;
				case 'g':
					f13F9D = AF05EE3D.const_47;
					break;
				case 'h':
					f13F9D = AF05EE3D.const_48;
					break;
				case 'i':
					f13F9D = AF05EE3D.E23BA719;
					break;
				case 'j':
					f13F9D = AF05EE3D.B60FFF3D;
					break;
				case 'k':
					f13F9D = AF05EE3D.const_51;
					break;
				case 'l':
					f13F9D = AF05EE3D.const_52;
					break;
				case 'm':
					f13F9D = AF05EE3D.const_53;
					break;
				case 'n':
					f13F9D = AF05EE3D.CAB72084;
					break;
				case 'o':
					f13F9D = AF05EE3D.const_55;
					break;
				case 'p':
					f13F9D = AF05EE3D.const_56;
					break;
				case 'q':
					f13F9D = AF05EE3D.const_57;
					break;
				case 'r':
					f13F9D = AF05EE3D.const_58;
					break;
				case 's':
					f13F9D = AF05EE3D.const_59;
					break;
				case 't':
					f13F9D = AF05EE3D.const_60;
					break;
				case 'u':
					f13F9D = AF05EE3D.const_61;
					break;
				case 'v':
					f13F9D = AF05EE3D.const_62;
					break;
				case 'w':
					f13F9D = AF05EE3D.const_63;
					break;
				case 'x':
					f13F9D = AF05EE3D.EC3B55A4;
					break;
				case 'y':
					f13F9D = AF05EE3D.const_65;
					break;
				case 'z':
					f13F9D = AF05EE3D.const_66;
					break;
				}
				break;
			case '0':
				f13F9D = AF05EE3D.const_31;
				break;
			case '1':
				f13F9D = AF05EE3D.const_32;
				break;
			case '2':
				f13F9D = AF05EE3D.const_33;
				break;
			case '3':
				f13F9D = AF05EE3D.C2B6CA80;
				break;
			case '4':
				f13F9D = AF05EE3D.const_35;
				break;
			case '5':
				f13F9D = AF05EE3D.const_36;
				break;
			case '6':
				f13F9D = AF05EE3D.const_37;
				break;
			case '7':
				f13F9D = AF05EE3D.const_38;
				break;
			case '8':
				f13F9D = AF05EE3D.const_39;
				break;
			case '9':
				f13F9D = AF05EE3D.const_40;
				break;
			}
			C43F3117(D11CD210, f13F9D);
			Thread.Sleep(TimeSpan.FromSeconds(float_0));
		}
	}

	public static void smethod_15(IntPtr intptr_0, AF05EE3D af05EE3D_0)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 257, new IntPtr((int)af05EE3D_0), new IntPtr(0));
	}

	public static void smethod_16(IntPtr D1AC1CA0, AF05EE3D af05EE3D_0)
	{
		PostMessage(D1AC1CA0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(D1AC1CA0, 258, new IntPtr((int)af05EE3D_0), new IntPtr(0));
	}

	public static void DE174101(IntPtr intptr_0, int int_0)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 258, new IntPtr(int_0), new IntPtr(0));
	}

	public static void smethod_17(IntPtr intptr_0, AF05EE3D af05EE3D_0)
	{
		PostMessage(intptr_0, 6, new IntPtr(1), new IntPtr(0));
		PostMessage(intptr_0, 256, new IntPtr((int)af05EE3D_0), new IntPtr(0));
	}

	public static void smethod_18(IntPtr E994C082, string D88E7B11, float float_0 = 0.1f)
	{
		string text = D88E7B11.ToLower();
		foreach (char int_ in text)
		{
			DE174101(E994C082, int_);
		}
	}

	public static void EF0BD781(GEnum0 DAAC5CAC)
	{
		smethod_21(DAAC5CAC);
	}

	public static void smethod_19(GEnum0[] genum0_0)
	{
		foreach (GEnum0 genum0_ in genum0_0)
		{
			CF80FE82(genum0_);
		}
		foreach (GEnum0 genum0_2 in genum0_0)
		{
			smethod_23(genum0_2);
		}
	}

	public static void smethod_20(string string_0)
	{
		Clipboard.SetText(string_0);
		smethod_19(new GEnum0[2]
		{
			GEnum0.const_107,
			GEnum0.const_94
		});
	}

	public static void smethod_21(GEnum0 E285389F)
	{
		BA8F7E14 bA8F7E = default(BA8F7E14);
		bA8F7E.uint_0 = 1u;
		BA8F7E14 bA8F7E2 = bA8F7E;
		ref GStruct1 gstruct1_ = ref bA8F7E2.gstruct1_0;
		GStruct3 b5167C = new GStruct3
		{
			ushort_0 = (ushort)E285389F,
			ushort_1 = 0,
			uint_0 = 0u,
			F9AD423F = 0u,
			intptr_0 = IntPtr.Zero
		};
		gstruct1_.B5167C26 = b5167C;
		bA8F7E = default(BA8F7E14);
		bA8F7E.uint_0 = 1u;
		BA8F7E14 bA8F7E3 = bA8F7E;
		ref GStruct1 gstruct1_2 = ref bA8F7E3.gstruct1_0;
		b5167C = new GStruct3
		{
			ushort_0 = (ushort)E285389F,
			ushort_1 = 0,
			uint_0 = 2u,
			F9AD423F = 0u,
			intptr_0 = IntPtr.Zero
		};
		gstruct1_2.B5167C26 = b5167C;
		BA8F7E14[] c3266B = new BA8F7E14[2] { bA8F7E2, bA8F7E3 };
		if (SendInput(2u, c3266B, Marshal.SizeOf(typeof(BA8F7E14))) == 0)
		{
			throw new Exception();
		}
	}

	public static void smethod_22(string string_0, double double_0 = 0.5)
	{
		for (int i = 0; i < string_0.Length; i++)
		{
			switch (string_0[i])
			{
			case '0':
				smethod_21(GEnum0.const_63);
				break;
			case '1':
				smethod_21(GEnum0.BAB8A9BE);
				break;
			case '2':
				smethod_21(GEnum0.A591C51B);
				break;
			case '3':
				smethod_21(GEnum0.const_66);
				break;
			case '4':
				smethod_21(GEnum0.const_67);
				break;
			case '5':
				smethod_21(GEnum0.const_68);
				break;
			case '6':
				smethod_21(GEnum0.const_69);
				break;
			case '7':
				smethod_21(GEnum0.const_70);
				break;
			case '8':
				smethod_21(GEnum0.const_71);
				break;
			case '9':
				smethod_21(GEnum0.const_72);
				break;
			}
			Thread.Sleep(TimeSpan.FromSeconds(double_0));
		}
	}

	public static void CF80FE82(GEnum0 genum0_0)
	{
		BA8F7E14 bA8F7E = default(BA8F7E14);
		bA8F7E.uint_0 = 1u;
		BA8F7E14 bA8F7E2 = bA8F7E;
		bA8F7E2.gstruct1_0.B5167C26 = default(GStruct3);
		bA8F7E2.gstruct1_0.B5167C26.ushort_0 = (ushort)genum0_0;
		bA8F7E2.gstruct1_0.B5167C26.ushort_1 = 0;
		bA8F7E2.gstruct1_0.B5167C26.uint_0 = 0u;
		bA8F7E2.gstruct1_0.B5167C26.F9AD423F = 0u;
		bA8F7E2.gstruct1_0.B5167C26.intptr_0 = IntPtr.Zero;
		BA8F7E14[] c3266B = new BA8F7E14[1] { bA8F7E2 };
		if (SendInput(1u, c3266B, Marshal.SizeOf(typeof(BA8F7E14))) == 0)
		{
			throw new Exception();
		}
	}

	public static void smethod_23(GEnum0 genum0_0)
	{
		BA8F7E14 bA8F7E = default(BA8F7E14);
		bA8F7E.uint_0 = 1u;
		BA8F7E14 bA8F7E2 = bA8F7E;
		bA8F7E2.gstruct1_0.B5167C26 = default(GStruct3);
		bA8F7E2.gstruct1_0.B5167C26.ushort_0 = (ushort)genum0_0;
		bA8F7E2.gstruct1_0.B5167C26.ushort_1 = 0;
		bA8F7E2.gstruct1_0.B5167C26.uint_0 = 2u;
		bA8F7E2.gstruct1_0.B5167C26.F9AD423F = 0u;
		bA8F7E2.gstruct1_0.B5167C26.intptr_0 = IntPtr.Zero;
		BA8F7E14[] c3266B = new BA8F7E14[1] { bA8F7E2 };
		if (SendInput(1u, c3266B, Marshal.SizeOf(typeof(BA8F7E14))) == 0)
		{
			throw new Exception();
		}
	}

	public static void A7BDA591(int int_0, int D830E30D, GEnum1 genum1_0 = GEnum1.F61F8CB1)
	{
		Cursor.Position = new Point(int_0, D830E30D);
		B086E184(genum1_0);
	}

	public static void smethod_24(Point point_0, int int_0, bool bool_0 = false)
	{
		Cursor.Position = point_0;
		mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
		for (int i = 0; i < int_0; i++)
		{
			if (!bool_0)
			{
				mouse_event(1u, 1, 0, 0, UIntPtr.Zero);
			}
			else
			{
				mouse_event(1u, -1, 0, 0, UIntPtr.Zero);
			}
		}
		mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
	}

	public static void smethod_25(Point EFAF978C, int AF2D5C18, bool D2AF0488 = false)
	{
		Cursor.Position = EFAF978C;
		mouse_event(2u, 0, 0, 0, UIntPtr.Zero);
		for (int i = 0; i < AF2D5C18; i++)
		{
			if (!D2AF0488)
			{
				mouse_event(1u, 0, 1, 0, UIntPtr.Zero);
			}
			else
			{
				mouse_event(1u, 0, -1, 0, UIntPtr.Zero);
			}
		}
		mouse_event(32772u, 0, 0, 0, UIntPtr.Zero);
	}

	public static void smethod_26(Point F693D6BC, int int_0, bool bool_0 = false)
	{
		Cursor.Position = F693D6BC;
		mouse_event(2048u, 0, 0, int_0, UIntPtr.Zero);
	}

	public static void smethod_27(Point point_0, GEnum1 genum1_0 = GEnum1.F61F8CB1)
	{
		Cursor.Position = point_0;
		B086E184(genum1_0);
	}

	public static void B086E184(GEnum1 genum1_0 = GEnum1.F61F8CB1)
	{
		switch (genum1_0)
		{
		case GEnum1.F61F8CB1:
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			break;
		case GEnum1.const_1:
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			break;
		case GEnum1.const_2:
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			mouse_event(32774u, 0, 0, 0, UIntPtr.Zero);
			break;
		case GEnum1.const_3:
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			mouse_event(32792u, 0, 0, 0, UIntPtr.Zero);
			break;
		}
	}

	public static GStruct0 smethod_28(IntPtr intptr_0)
	{
		GStruct0 E726D58F = default(GStruct0);
		GetWindowRect(intptr_0, ref E726D58F);
		return E726D58F;
	}

	public static Point smethod_29(IntPtr intptr_0, Point? nullable_0 = null)
	{
		Point result = default(Point);
		GStruct0 gStruct = smethod_28(intptr_0);
		if (!nullable_0.HasValue)
		{
			nullable_0 = default(Point);
		}
		result.X = nullable_0.Value.X + gStruct.int_0;
		result.Y = nullable_0.Value.Y + gStruct.int_1;
		return result;
	}

	public static Point smethod_30(IntPtr C1AA1B2C, int E2018E1B = 0, int FE15D0B3 = 0)
	{
		Point result = default(Point);
		GStruct0 gStruct = smethod_28(C1AA1B2C);
		result.X = E2018E1B + gStruct.int_0;
		result.Y = FE15D0B3 + gStruct.int_1;
		return result;
	}

	public static string BEB27015(IntPtr E6A1629D)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetWindowText(E6A1629D, stringBuilder, 256);
		return stringBuilder.ToString().Trim();
	}

	public static string smethod_31(IntPtr AAA4DD1A)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		GetClassName(AAA4DD1A, stringBuilder, 256);
		return stringBuilder.ToString().Trim();
	}

	public static IntPtr C2344B15(int int_0, int int_1)
	{
		return (IntPtr)((int_1 << 16) | (int_0 & 0xFFFF));
	}

	public static IntPtr smethod_32(int B8A66E8C, int int_0)
	{
		return (IntPtr)((int_0 << 16) | B8A66E8C);
	}
}
