using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public static class GClass17
{
	[CompilerGenerated]
	private sealed class Class52
	{
		internal Control control_0;

		internal bool B031D00C;

		internal void C61735B4()
		{
			control_0.Enabled = B031D00C;
		}
	}

	public static Bitmap smethod_0(this string F8AF8F8F)
	{
		try
		{
			byte[] array = Convert.FromBase64String(F8AF8F8F);
			MemoryStream memoryStream = new MemoryStream(array, 0, array.Length);
			memoryStream.Write(array, 0, array.Length);
			Image original = Image.FromStream(memoryStream, useEmbeddedColorManagement: true);
			return new Bitmap(original);
		}
		catch
		{
		}
		return null;
	}

	public static void smethod_1(this Control control_0, bool D23E97A8)
	{
		try
		{
			control_0.Invoke((MethodInvoker)delegate
			{
				control_0.Enabled = D23E97A8;
			});
		}
		catch
		{
		}
	}

	public static string AB16AD0E(this string string_0)
	{
		return WebUtility.UrlEncode(string_0);
	}

	public static string DD35E3BD(this string string_0)
	{
		return WebUtility.HtmlDecode(string_0);
	}

	public static void smethod_2(this Form form_0)
	{
		if (form_0.WindowState == FormWindowState.Maximized)
		{
			form_0.WindowState = FormWindowState.Normal;
			return;
		}
		Rectangle workingArea = Screen.FromHandle(form_0.Handle).WorkingArea;
		workingArea.Location = new Point(0, 0);
		form_0.MaximumSize = workingArea.Size;
		form_0.WindowState = FormWindowState.Maximized;
	}

	public static void smethod_3(this Control control_0)
	{
		control_0.Text = "Search...";
		control_0.ForeColor = Color.Gray;
		control_0.Leave += A3118799;
		control_0.Enter += BD342498;
	}

	private static void BD342498(object sender, EventArgs e)
	{
		Control control = sender as Control;
		if (control.Text == "Search...")
		{
			control.Text = "";
			control.ForeColor = Color.Black;
		}
	}

	private static void A3118799(object sender, EventArgs e)
	{
		Control control = sender as Control;
		if (control.Text == "")
		{
			control.Text = "Search...";
			control.ForeColor = Color.Gray;
		}
	}
}
