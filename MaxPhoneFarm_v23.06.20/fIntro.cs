using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using maxcare.Properties;

public class fIntro : Form
{
	internal IContainer D7BAEB09;

	internal ProgressBar progressBar;

	internal Timer timer_0;

	internal Timer timer_1;

	internal Label C82BAF10;

	internal ucContact FB068337;

	[DllImport("kernel32.dll")]
	private static extern long GetVolumeInformation(string string_0, StringBuilder FE175C82, uint D20C161E, ref uint AF86AB90, ref uint uint_0, ref uint uint_1, StringBuilder stringBuilder_0, uint B8914E16);

	public fIntro()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void fIntro_Load(object sender, EventArgs e)
	{
		timer_0.Tick += timer_0_Tick;
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (base.Opacity >= 1.0)
		{
			timer_0.Stop();
			try
			{						
				try
				{
                    Hide();

                    new fMain("1||01/01/2050|1|999|9999").ShowDialog();
                }
				catch (Exception)
				{
					Application.Exit();
				}
			}
			catch (Exception exception_)
			{
				MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng liên hê\u0323 Admin đê\u0309 đươ\u0323c hô\u0303 trơ\u0323!"), 2);
				Common.ExportError(null, exception_, "Run Program");
				Close();
			}
		}
		else
		{
			base.Opacity += 0.05;
		}
	}

	private void D4B0A731(object sender, EventArgs e)
	{
		if (base.Opacity <= 0.0)
		{
			timer_0.Stop();
			Close();
		}
		else
		{
			base.Opacity -= 0.05;
		}
	}

	private void A827638D(object sender, EventArgs e)
	{
		if (progressBar.Value < 90)
		{
			progressBar.Value += 10;
		}
		else
		{
			timer_1.Stop();
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && D7BAEB09 != null)
		{
			D7BAEB09.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		D7BAEB09 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIntro));
		progressBar = new System.Windows.Forms.ProgressBar();
		timer_0 = new System.Windows.Forms.Timer(D7BAEB09);
		timer_1 = new System.Windows.Forms.Timer(D7BAEB09);
		C82BAF10 = new System.Windows.Forms.Label();
		FB068337 = new ucContact();
		SuspendLayout();
		progressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		progressBar.Location = new System.Drawing.Point(38, 514);
		progressBar.Name = "progressBar";
		progressBar.Size = new System.Drawing.Size(678, 23);
		progressBar.Step = 50;
		progressBar.TabIndex = 7;
		timer_0.Interval = 30;
		timer_1.Enabled = true;
		timer_1.Tick += new System.EventHandler(A827638D);
		C82BAF10.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		C82BAF10.AutoSize = true;
		C82BAF10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C82BAF10.ForeColor = System.Drawing.Color.DarkViolet;
		C82BAF10.Location = new System.Drawing.Point(566, 494);
		C82BAF10.Name = "label7";
		C82BAF10.Size = new System.Drawing.Size(154, 16);
		C82BAF10.TabIndex = 9;
		C82BAF10.Text = "Đang kiểm tra thông tin...";
		FB068337.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FB068337.Location = new System.Drawing.Point(19, 13);
		FB068337.Margin = new System.Windows.Forms.Padding(4);
		FB068337.Name = "ucContact1";
		FB068337.Size = new System.Drawing.Size(714, 473);
		FB068337.TabIndex = 10;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.WhiteSmoke;
		base.ClientSize = new System.Drawing.Size(756, 549);
		base.Controls.Add(FB068337);
		base.Controls.Add(C82BAF10);
		base.Controls.Add(progressBar);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "fIntro";
		base.Opacity = 0.0;
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Kiểm tra thông tin";
		base.TopMost = true;
		base.Load += new System.EventHandler(fIntro_Load);
		ResumeLayout(false);
		PerformLayout();
	}
}
