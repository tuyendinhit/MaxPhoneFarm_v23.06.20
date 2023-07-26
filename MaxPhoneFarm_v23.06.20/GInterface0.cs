using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[CompilerGenerated]
[DefaultMember("FullName")]
[TypeIdentifier]
[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
public interface GInterface0
{
	[DispId(0)]
	string C6BE3F30
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1000)]
	string String_0
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1000)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1000)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1001)]
	string String_1
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1001)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1001)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1003)]
	string String_2
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1003)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1003)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1005)]
	string C18140B5
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1005)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1005)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1007)]
	string D8BF1F8D
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1007)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1007)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap1_2();

	void _VtblGap2_1();

	void _VtblGap3_2();

	void _VtblGap4_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2001)]
	void imethod_0();
}
