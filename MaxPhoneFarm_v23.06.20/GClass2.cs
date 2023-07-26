using System;
using System.Runtime.InteropServices;
using OpenCvSharp;

public class GClass2
{
	[DllImport("user32.dll", SetLastError = true)]
	public static extern long SetParent(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr intptr_0, int int_0, int D2A2C029, int int_1, int ACAA6094, bool bool_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool SetForegroundWindow(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr D50AF511, ref Rect B43E201A);

	[DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
	public static extern IntPtr FindWindow(string string_0, string string_1);
}
