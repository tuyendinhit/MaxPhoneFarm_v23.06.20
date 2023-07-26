using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public static class GClass15
{
	internal static Dictionary<Control, bool> dictionary_0 = new Dictionary<Control, bool>();

	internal static Size size_0;

	public static void smethod_0(this Control A4A76319, bool bool_0)
	{
		if (bool_0)
		{
			if (!dictionary_0.ContainsKey(A4A76319))
			{
				dictionary_0.Add(A4A76319, value: false);
				A4A76319.MouseDown += smethod_1;
				A4A76319.MouseMove += BEB34281;
			}
		}
		else if (dictionary_0.ContainsKey(A4A76319))
		{
			A4A76319.MouseDown -= smethod_1;
			A4A76319.MouseMove -= BEB34281;
			dictionary_0.Remove(A4A76319);
		}
	}

	private static void smethod_1(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			size_0 = new Size(e.Location);
			dictionary_0[(Control)sender] = true;
			(sender as Control).BringToFront();
		}
	}

	private static void BEB34281(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left && dictionary_0[(Control)sender])
		{
			Point point = e.Location - size_0;
			((Control)sender).Left += point.X;
			((Control)sender).Top += point.Y;
		}
	}
}
