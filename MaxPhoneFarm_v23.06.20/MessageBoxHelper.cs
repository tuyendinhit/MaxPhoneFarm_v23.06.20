using System.Windows.Forms;

public class MessageBoxHelper
{
	public static void Show(object ED3F8381, int int_0 = 1)
	{
		MessageBoxIcon icon = MessageBoxIcon.None;
		switch (int_0)
		{
		case 1:
			icon = MessageBoxIcon.Asterisk;
			break;
		case 2:
			icon = MessageBoxIcon.Hand;
			break;
		case 3:
			icon = MessageBoxIcon.Exclamation;
			break;
		case 4:
			icon = MessageBoxIcon.Exclamation;
			break;
		}
		MessageBox.Show(Language.GetValue(ED3F8381.ToString()), "MINSoftware", MessageBoxButtons.OK, icon);
	}

	public static DialogResult smethod_1(string string_0)
	{
		return MessageBox.Show(Language.GetValue(string_0), "MINSoftware", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
	}
}
