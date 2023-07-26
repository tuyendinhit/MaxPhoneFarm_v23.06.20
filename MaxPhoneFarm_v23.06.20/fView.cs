using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public class fView : Form
{
	[CompilerGenerated]
	private sealed class BF26570E
	{
		internal Control control_0;

		internal string FE994107;

		internal int int_0;

		internal void method_0()
		{
			control_0.Name = "dv" + FE994107;
			control_0.Tag = FE994107;
			control_0.Controls[0].Text = FE994107;
			if (int_0 > 0)
			{
				Control control = control_0.Controls[0];
				control.Text = control.Text + "-TK " + int_0;
			}
			control_0.Controls[0].Name = FE994107;
			control_0.Controls[1].Name = FE994107;
			control_0.Controls[2].Name = FE994107;
			control_0.Controls[3].Name = FE994107;
			control_0.Controls[4].Name = FE994107;
		}
	}

	[CompilerGenerated]
	private sealed class Class70
	{
		internal int int_0;

		internal string string_0;

		internal bool CE937DA4(Control control_0)
		{
			return control_0.Tag.Equals(int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class71
	{
		internal Control control_0;

		internal Class70 BB967208;

		internal void E60F5C18()
		{
			control_0.Controls[4].Name = BB967208.string_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class72
	{
		internal int DF3AD4B7;

		internal bool method_0(Control control_0)
		{
			return control_0.Tag.Equals(DF3AD4B7);
		}
	}

	[CompilerGenerated]
	private sealed class Class73
	{
		internal fView fView_0;

		internal int int_0;

		internal string string_0;

		internal void method_0()
		{
			fView_0.EE854986.Controls["dv" + int_0].Controls[2].Text = string_0;
		}
	}

	[CompilerGenerated]
	private sealed class Class74
	{
		internal fView fView_0;

		internal int E5B29137;

		internal string EF93A3A7;

		internal void B9385F97()
		{
			fView_0.EE854986.Controls["dv" + E5B29137].Controls[1].Text = ">" + EF93A3A7;
		}
	}

	[CompilerGenerated]
	private sealed class Class75
	{
		internal fView D2145193;

		internal int DCA5F381;

		internal void method_0()
		{
			D2145193.EE854986.Controls["dv" + DCA5F381].Controls[3].Visible = true;
			D2145193.EE854986.Controls["dv" + DCA5F381].Controls[4].Visible = true;
		}
	}

	[CompilerGenerated]
	private sealed class Class76
	{
		internal fView fView_0;

		internal int int_0;

		internal void method_0()
		{
			fView_0.EE854986.Controls["dv" + int_0].Controls[3].Visible = false;
			fView_0.EE854986.Controls["dv" + int_0].Controls[4].Visible = false;
		}
	}

	[CompilerGenerated]
	private sealed class Class77
	{
		internal string string_0;

		internal IntPtr FA216706;

		internal fView fView_0;

		internal bool method_0(Control control_0)
		{
			return control_0.Name.Equals("dv" + string_0);
		}

		internal bool method_1(Control control_0)
		{
			return control_0.Name.Equals("view_" + string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class78
	{
		internal Control control_0;

		internal Class77 class77_0;

		internal void method_0()
		{
			GClass2.SetParent(class77_0.FA216706, control_0.Handle);
			GClass2.MoveWindow(class77_0.FA216706, class77_0.fView_0.int_0[2], class77_0.fView_0.int_0[3], class77_0.fView_0.int_0[4], class77_0.fView_0.int_0[5], bool_0: true);
		}
	}

	[CompilerGenerated]
	private sealed class D429072B
	{
		internal Control control_0;

		internal fView fView_0;

		internal void method_0()
		{
			fView_0.EE854986.Controls.Remove(control_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class79
	{
		internal Panel E0A1A6A4;

		internal fView fView_0;

		internal void B53C63AF()
		{
			fView_0.EE854986.Controls.Add(E0A1A6A4);
		}
	}

	internal bool bool_0 = false;

	internal int[] int_0 = new int[6] { 9460301, 3, 4, 65535, 184, 0 };

	internal object object_0 = new object();

	internal static fView fView_0;

	internal IContainer icontainer_0 = null;

	internal ToolTip EC0EA8A8;

	internal FlowLayoutPanel EE854986;

	public fView()
	{
		InitializeComponent();
		fView_0 = this;
	}

	public void method_0(IntPtr intptr_0, int int_1, int int_2)
	{
	}

	public void method_1(IntPtr intptr_0, string E314778E)
	{
		try
		{
			method_4(E314778E);
			Control control_ = (from Control control_0 in EE854986.Controls
				where control_0.Name.Equals("dv" + E314778E)
				select control_0).FirstOrDefault();
			control_ = (from Control control_0 in control_.Controls
				where control_0.Name.Equals("view_" + E314778E)
				select control_0).FirstOrDefault();
			if (control_ != null)
			{
				Invoke((MethodInvoker)delegate
				{
					GClass2.SetParent(intptr_0, control_.Handle);
					GClass2.MoveWindow(intptr_0, int_0[2], int_0[3], int_0[4], int_0[5], bool_0: true);
				});
			}
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "AddDeviceIntoPanel");
		}
	}

	public void method_2(int int_1)
	{
		try
		{
			method_9(int_1, "");
			method_10(int_1, "");
			method_13(int_1);
			if (!bool_0)
			{
				Control a03A88BC = EE854986.Controls["dv" + int_1];
				method_6(a03A88BC, -1);
			}
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "RemovePanelDevice");
		}
	}

	public void method_3(string string_0)
	{
		try
		{
			Control control_0 = EE854986.Controls["dv" + string_0];
			EE854986.Invoke((MethodInvoker)delegate
			{
				EE854986.Controls.Remove(control_0);
			});
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "RemovePanelDevice");
		}
	}

	public void method_4(string string_0)
	{
		try
		{
			Panel E0A1A6A4 = new Panel();
			E0A1A6A4.Name = "dv" + string_0;
			E0A1A6A4.Tag = string_0;
			E0A1A6A4.Size = new Size(int_0[0], int_0[1] + 60);
			E0A1A6A4.BackColor = Color.White;
			E0A1A6A4.BorderStyle = BorderStyle.FixedSingle;
			Panel panel = new Panel();
			panel.Location = new Point(0, 0);
			panel.Name = "view_" + string_0;
			panel.Size = new Size(int_0[0], int_0[1]);
			E0A1A6A4.Controls.Add(panel);
			Label value = new Label
			{
				Text = string_0,
				Location = new Point(0, int_0[1] + 6),
				Size = new Size(int_0[0], 20),
				BackColor = Color.White,
				BorderStyle = BorderStyle.None,
				ForeColor = Color.Black,
				Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0),
				Name = string_0,
				AutoSize = false
			};
			E0A1A6A4.Controls.Add(value);
			Button button = new Button
			{
				Location = new Point(3, int_0[1] + 28),
				Name = string_0,
				Size = new Size(80, 27),
				Cursor = Cursors.Hand,
				Visible = true,
				ForeColor = Color.Black,
				BackColor = Color.FromArgb(255, 182, 193),
				Text = "Close"
			};
			button.Click += method_11;
			E0A1A6A4.Controls.Add(button);
			Button button2 = new Button
			{
				Location = new Point(int_0[0] - 85, int_0[1] + 28),
				Name = string_0,
				Size = new Size(80, 27),
				Cursor = Cursors.Hand,
				Visible = true,
				BackColor = Color.FromArgb(212, 237, 182),
				ForeColor = Color.Black,
				Text = "Xuất lỗi"
			};
			button2.Click += BE151A39;
			E0A1A6A4.Controls.Add(button2);
			lock (object_0)
			{
				EE854986.Invoke((MethodInvoker)delegate
				{
					EE854986.Controls.Add(E0A1A6A4);
				});
			}
			for (int i = 0; i < 5; i++)
			{
				if (EE854986.Controls["dv" + string_0] != null)
				{
					break;
				}
				Thread.Sleep(1000);
			}
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "AddPanelDevice");
		}
	}

	public void method_5(int DB025236)
	{
	}

	public void method_6(Control A03A88BC, int int_1, int D528A41F = 0)
	{
	}

	public void CA2DE0B0(Control control_0, string CE01D10C, int int_1 = 0)
	{
		try
		{
			control_0.Invoke((MethodInvoker)delegate
			{
				control_0.Name = "dv" + CE01D10C;
				control_0.Tag = CE01D10C;
				control_0.Controls[0].Text = CE01D10C;
				if (int_1 > 0)
				{
					Control control = control_0.Controls[0];
					control.Text = control.Text + "-TK " + int_1;
				}
				control_0.Controls[0].Name = CE01D10C;
				control_0.Controls[1].Name = CE01D10C;
				control_0.Controls[2].Name = CE01D10C;
				control_0.Controls[3].Name = CE01D10C;
				control_0.Controls[4].Name = CE01D10C;
			});
		}
		catch
		{
		}
	}

	public void method_7(int int_1, string string_0)
	{
		try
		{
			Control control_ = (from Control control_0 in EE854986.Controls
				where control_0.Tag.Equals(int_1)
				select control_0).FirstOrDefault();
			if (control_ != null)
			{
				control_.Invoke((MethodInvoker)delegate
				{
					control_.Controls[4].Name = string_0;
				});
				Application.DoEvents();
			}
		}
		catch
		{
		}
	}

	public bool method_8(int E884CC30)
	{
		return (from Control control_0 in EE854986.Controls
			where control_0.Tag.Equals(E884CC30)
			select control_0).Count() == 1;
	}

	public void method_9(int AF987E8C, string string_0)
	{
		try
		{
			Application.DoEvents();
			if (string_0.Trim() != "")
			{
				string_0 = string_0.Replace("\"", "");
				string_0 += (string_0.EndsWith("...") ? "" : "...");
			}
			EE854986.Invoke((MethodInvoker)delegate
			{
				EE854986.Controls["dv" + AF987E8C].Controls[2].Text = string_0;
			});
			Application.DoEvents();
		}
		catch (Exception)
		{
		}
	}

	public void method_10(int int_1, string string_0)
	{
		try
		{
			Application.DoEvents();
			if (string_0.Trim() != "")
			{
				string_0 = string_0.Replace("\"", "");
				string_0 += (string_0.EndsWith("...") ? "" : "...");
			}
			EE854986.Invoke((MethodInvoker)delegate
			{
				EE854986.Controls["dv" + int_1].Controls[1].Text = ">" + string_0;
			});
			method_9(int_1, "");
			Application.DoEvents();
		}
		catch (Exception)
		{
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		try
		{
			string name = (sender as Button).Name;
			method_3(name);
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "TurnOffDevice");
		}
	}

	private void BE151A39(object sender, EventArgs e)
	{
		try
		{
			string name = (sender as Button).Name;
			if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
			{
				fCheckAppium fCheckAppium2 = new fCheckAppium(name);
				fCheckAppium2.Show();
				return;
			}
			AC28BD29 aC28BD = new AC28BD29(name);
			if (aC28BD.method_123("CheckDevice") != "CheckDevice")
			{
				MessageBoxHelper.Show("Success!");
			}
			else
			{
				MessageBoxHelper.Show("Fail!", 2);
			}
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "CheckDevice");
		}
	}

	public void method_12(int int_1)
	{
		try
		{
			Invoke((MethodInvoker)delegate
			{
				EE854986.Controls["dv" + int_1].Controls[3].Visible = true;
				EE854986.Controls["dv" + int_1].Controls[4].Visible = true;
			});
		}
		catch (Exception)
		{
		}
	}

	public void method_13(int A902CD8A)
	{
		try
		{
			Invoke((MethodInvoker)delegate
			{
				EE854986.Controls["dv" + A902CD8A].Controls[3].Visible = false;
				EE854986.Controls["dv" + A902CD8A].Controls[4].Visible = false;
			});
		}
		catch (Exception)
		{
		}
	}

	private void fView_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			foreach (Panel control in EE854986.Controls)
			{
				int int_ = Convert.ToInt32(control.Name.Replace("dv", ""));
				method_2(int_);
			}
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "fViewChrome_FormClosing");
		}
	}

	public List<string> method_14()
	{
		List<string> list = new List<string>();
		Control.ControlCollection controls = EE854986.Controls;
		foreach (Control item in controls)
		{
			list.Add(item.Tag.ToString());
		}
		return list;
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fView));
		EC0EA8A8 = new System.Windows.Forms.ToolTip(icontainer_0);
		EE854986 = new System.Windows.Forms.FlowLayoutPanel();
		SuspendLayout();
		EC0EA8A8.AutomaticDelay = 0;
		EC0EA8A8.AutoPopDelay = 5000;
		EC0EA8A8.InitialDelay = 0;
		EC0EA8A8.ReshowDelay = 100;
		EC0EA8A8.ShowAlways = true;
		EE854986.AutoScroll = true;
		EE854986.BackColor = System.Drawing.Color.White;
		EE854986.Dock = System.Windows.Forms.DockStyle.Fill;
		EE854986.Location = new System.Drawing.Point(0, 0);
		EE854986.Name = "panelListDevice";
		EE854986.Padding = new System.Windows.Forms.Padding(10);
		EE854986.Size = new System.Drawing.Size(1044, 441);
		EE854986.TabIndex = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1044, 441);
		base.Controls.Add(EE854986);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fView";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "View Phone - MIN SOFTWARE";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(fView_FormClosing);
		ResumeLayout(false);
	}
}
