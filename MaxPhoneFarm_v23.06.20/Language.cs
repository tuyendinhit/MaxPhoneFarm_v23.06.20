using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class Language
{
	public static string GetValue(string CF0CF716)
	{
		string text = "";
		if (Base.smethod_0() == "VN")
		{
			return CF0CF716;
		}
		if (CF0CF716 == "")
		{
			return CF0CF716;
		}
		//text = D4A6442A(CF0CF716);
		if (text == "")
		{
			text = CF0CF716;
		}
		return text;
	}

	public static void smethod_1(Control control_0, string string_0 = "VN")
	{
		if (control_0.Text.ToLower().Contains("(ẩn)"))
		{
			if (Base.bool_0)
			{
				control_0.Text = control_0.Text.Replace("(ẩn)", "");
			}
			else
			{
				control_0.Visible = false;
			}
		}
		control_0.Text = GetValue(control_0.Text);
	}

	public static void smethod_2(ToolStripItem toolStripItem_0, string E48A2B83 = "VN")
	{
		if (toolStripItem_0.Text.ToLower().Contains("(ẩn)"))
		{
			if (Base.bool_0)
			{
				toolStripItem_0.Text = toolStripItem_0.Text.Replace("(ẩn)", "");
			}
			else
			{
				toolStripItem_0.Visible = false;
			}
		}
		toolStripItem_0.Text = GetValue(toolStripItem_0.Text);
	}

	public static void E3937E81(DataGridViewColumn dataGridViewColumn_0, string string_0 = "VN")
	{
		dataGridViewColumn_0.HeaderText = GetValue(dataGridViewColumn_0.HeaderText);
	}

	public static IEnumerable<Control> smethod_3(Control control_0)
	{
		IEnumerable<Control> enumerable = control_0.Controls.Cast<Control>();
		return enumerable.SelectMany((Control A70B1005) => smethod_3(A70B1005)).Concat(enumerable);
	}

	public static void SetLanguage(Control control_0)
	{
		IEnumerable<Control> enumerable = smethod_3(control_0);
		foreach (Control item in enumerable)
		{
			if (item is DataGridView)
			{
				foreach (DataGridViewColumn column in (item as DataGridView).Columns)
				{
					E3937E81(column);
				}
			}
			else if (item is MenuStrip)
			{
				foreach (ToolStripMenuItem item2 in (item as MenuStrip).Items)
				{
					smethod_2(item2);
					if (item2.HasDropDownItems)
					{
						smethod_6(item2);
					}
				}
			}
			else if (item is StatusStrip)
			{
				foreach (ToolStripItem item3 in (item as StatusStrip).Items)
				{
					smethod_2(item3);
				}
			}
			else
			{
				smethod_1(item);
			}
		}
	}

	public static void smethod_5(ContextMenuStrip contextMenuStrip_0)
	{
		foreach (ToolStripMenuItem item in contextMenuStrip_0.Items)
		{
			smethod_2(item);
			if (item.HasDropDownItems)
			{
				smethod_6(item);
			}
		}
	}

	public static void smethod_6(ToolStripMenuItem BB3A8229)
	{
		foreach (ToolStripMenuItem dropDownItem in BB3A8229.DropDownItems)
		{
			smethod_2(dropDownItem);
			if (dropDownItem.HasDropDownItems)
			{
				smethod_6(dropDownItem);
			}
		}
	}

	public static void F31FF919()
	{
		JSON_Settings f72FAFBC = new JSON_Settings("configLanguage");
		Dictionary<string, object> dictionary = f72FAFBC.ConvertToDictionary();
		JSON_Settings f72FAFBC2 = new JSON_Settings("configLanguage_VN");
		foreach (KeyValuePair<string, object> item in dictionary)
		{
			f72FAFBC2.GetValue(item.Value.ToString(), (object)item.Key);
		}
		f72FAFBC2.method_5();
	}

	/*[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetLanguage(byte[] byte_0);

	public static string D4A6442A(string string_0)
	{
		byte[] byte_ = Common.smethod_1(string_0);
		return Common.DCA2B4A5(GetLanguage(byte_));
	}*/
}
