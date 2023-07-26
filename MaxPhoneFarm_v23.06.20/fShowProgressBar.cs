using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public class fShowProgressBar : Form
{
	[CompilerGenerated]
	private sealed class F30CEE3A
	{
		internal int CF34BE34;

		internal int int_0;

		internal fShowProgressBar fShowProgressBar_0;

		internal void EC96728E()
		{
			fShowProgressBar_0.lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), CF34BE34, int_0);
		}
	}

	[CompilerGenerated]
	private sealed class CD95BCBA
	{
		internal double double_0;

		internal F30CEE3A f30CEE3A_0;

		internal void B08A2806()
		{
			f30CEE3A_0.fShowProgressBar_0.lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), f30CEE3A_0.CF34BE34, f30CEE3A_0.int_0);
			f30CEE3A_0.fShowProgressBar_0.B219BC8E.Value = int.Parse(Math.Truncate(double_0).ToString());
		}
	}

	internal List<string> list_0 = new List<string>();

	internal IContainer B2349584 = null;

	internal Label lblproccess;

	internal ProgressBar B219BC8E;

	public fShowProgressBar(List<string> CEBA55AB)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		list_0 = CEBA55AB;
	}

	private void method_0()
	{
		Language.smethod_1(lblproccess);
	}

	private void CA2C6ABA(object sender, EventArgs e)
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				string text = "";
				string text2 = "";
				int CF34BE34 = 0;
				int int_0 = list_0.Count;
				BeginInvoke((MethodInvoker)delegate
				{
					lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), CF34BE34, int_0);
				});
				for (int i = 0; i < list_0.Count; i++)
				{
					text = list_0[i].Split('|')[0];
					text2 = list_0[i].Split('|')[1];
					if (FileHelper.smethod_2(text, text2, bool_0: true))
					{
						int num = CF34BE34;
						CF34BE34 = num + 1;
					}
					double double_0 = (double)CF34BE34 * 1.0 / (double)int_0 * 100.0;
					BeginInvoke((MethodInvoker)delegate
					{
						lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), CF34BE34, int_0);
						B219BC8E.Value = int.Parse(Math.Truncate(double_0).ToString());
					});
				}
				BeginInvoke((MethodInvoker)delegate
				{
					Close();
				});
			});
			thread.IsBackground = true;
			thread.Start();
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show("Error: " + ex.Message, 2);
			Close();
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && B2349584 != null)
		{
			B2349584.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		lblproccess = new System.Windows.Forms.Label();
		B219BC8E = new System.Windows.Forms.ProgressBar();
		SuspendLayout();
		lblproccess.AutoSize = true;
		lblproccess.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblproccess.Location = new System.Drawing.Point(34, 22);
		lblproccess.Name = "lblproccess";
		lblproccess.Size = new System.Drawing.Size(189, 16);
		lblproccess.TabIndex = 1;
		lblproccess.Text = "Đang copy, vui lo\u0300ng chơ\u0300 (0/0)...";
		B219BC8E.Location = new System.Drawing.Point(37, 52);
		B219BC8E.Name = "progressBar1";
		B219BC8E.Size = new System.Drawing.Size(219, 23);
		B219BC8E.TabIndex = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		base.ClientSize = new System.Drawing.Size(294, 104);
		base.Controls.Add(B219BC8E);
		base.Controls.Add(lblproccess);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fShowProgressBar";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "frm_progress";
		base.Load += new System.EventHandler(CA2C6ABA);
		ResumeLayout(false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void method_1()
	{
		string text = "";
		string text2 = "";
		int CF34BE34 = 0;
		int int_0 = list_0.Count;
		BeginInvoke((MethodInvoker)delegate
		{
			lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), CF34BE34, int_0);
		});
		for (int i = 0; i < list_0.Count; i++)
		{
			text = list_0[i].Split('|')[0];
			text2 = list_0[i].Split('|')[1];
			if (FileHelper.smethod_2(text, text2, bool_0: true))
			{
				int num = CF34BE34;
				CF34BE34 = num + 1;
			}
			double double_0 = (double)CF34BE34 * 1.0 / (double)int_0 * 100.0;
			BeginInvoke((MethodInvoker)delegate
			{
				lblproccess.Text = string.Format(Language.GetValue("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), CF34BE34, int_0);
				B219BC8E.Value = int.Parse(Math.Truncate(double_0).ToString());
			});
		}
		BeginInvoke((MethodInvoker)delegate
		{
			Close();
		});
	}

	[CompilerGenerated]
	private void B9B3C3A3()
	{
		Close();
	}
}
