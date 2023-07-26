using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckLiveUid : Form
{
	[CompilerGenerated]
	private sealed class F22CE59C
	{
		internal int int_0;

		internal fTienIchCheckLiveUid fTienIchCheckLiveUid_0;
	}

	[CompilerGenerated]
	private sealed class A42BDD3E
	{
		internal string CA04B798;

		internal F22CE59C f22CE59C_0;

		internal void A19DB9AC()
		{
			string text = EA98BF20.CheckLiveWall(CA04B798);
			if (text.StartsWith("0|"))
			{
				f22CE59C_0.fTienIchCheckLiveUid_0.method_1(f22CE59C_0.fTienIchCheckLiveUid_0.EF37342D, CA04B798);
			}
			else if (text.StartsWith("1|"))
			{
				f22CE59C_0.fTienIchCheckLiveUid_0.method_1(f22CE59C_0.fTienIchCheckLiveUid_0.F2263DB0, CA04B798);
			}
			else
			{
				f22CE59C_0.fTienIchCheckLiveUid_0.method_1(f22CE59C_0.fTienIchCheckLiveUid_0.txtKhongCheckDuoc, CA04B798);
			}
			Interlocked.Decrement(ref f22CE59C_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class81
	{
		internal RichTextBox richTextBox_0;

		internal string E51B650A;

		internal void F4282E11()
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + E51B650A + "\r\n";
		}
	}

	internal IContainer icontainer_0 = null;

	internal BunifuCards A28C3D0A;

	internal Panel panel1;

	internal BunifuDragControl bunifuDragControl_0;

	internal ToolTip toolTip_0;

	internal BunifuCards bunifuCards2;

	internal Panel pnlHeader;

	internal Button FA37CA3C;

	internal PictureBox pictureBox1;

	internal Button btnMinimize;

	internal BunifuCustomLabel lblTitle;

	internal Button btnAdd;

	internal RichTextBox B92E2E9D;

	internal GroupBox grDaTao;

	internal RichTextBox F2263DB0;

	internal GroupBox C282B588;

	internal GroupBox grChuaTao;

	internal RichTextBox EF37342D;

	internal Label lblStatus;

	internal GroupBox C4AC22B6;

	internal RichTextBox txtKhongCheckDuoc;

	internal NumericUpDown nudThread;

	internal Label label2;

	public fTienIchCheckLiveUid()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(C282B588);
	}

	private void FA37CA3C_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			list = B92E2E9D.Lines.ToList();
			int int_0 = 0;
			int num = Convert.ToInt32(nudThread.Value);
			if (num == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Số luồng phải >0, vui lòng nhập lại!"), 3);
				return;
			}
			if (list.Count < num)
			{
				num = list.Count;
			}
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Visible = true;
			});
			int num2 = 0;
			while (num2 < list.Count)
			{
				if (int_0 < num)
				{
					Interlocked.Increment(ref int_0);
					string CA04B798 = list[num2++];
					Thread thread = new Thread((ThreadStart)delegate
					{
						string text = EA98BF20.CheckLiveWall(CA04B798);
						if (text.StartsWith("0|"))
						{
							method_1(EF37342D, CA04B798);
						}
						else if (text.StartsWith("1|"))
						{
							method_1(F2263DB0, CA04B798);
						}
						else
						{
							method_1(txtKhongCheckDuoc, CA04B798);
						}
						Interlocked.Decrement(ref int_0);
					});
					thread.IsBackground = true;
					thread.Start();
				}
				else
				{
					Application.DoEvents();
					Common.DelayTime(1.0);
				}
			}
			while (int_0 > 0)
			{
				Common.DelayTime(1.0);
			}
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Visible = false;
			});
			MessageBoxHelper.Show(Language.GetValue("Đã check xong!"));
		}
		catch (Exception)
		{
			MessageBoxHelper.Show(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void method_1(RichTextBox DBB94BB6, string E6AC21B1)
	{
		DBB94BB6.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = DBB94BB6;
			richTextBox.Text = richTextBox.Text + E6AC21B1 + "\r\n";
		});
	}

	private void E7306689(object sender, EventArgs e)
	{
		Common.D936DD84(B92E2E9D, C282B588);
	}

	private void D7ACE718(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = F2263DB0.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			grDaTao.Text = "LIVE (" + f1808BA.Count + ")";
		}
		catch
		{
		}
	}

	private void D20BCC8D(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchCheckLiveUid_Load(object sender, EventArgs e)
	{
	}

	private void EF37342D_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = EF37342D.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			grChuaTao.Text = "DIE (" + f1808BA.Count + ")";
		}
		catch
		{
		}
	}

	private void B6A597AE(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtKhongCheckDuoc.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			C4AC22B6.Text = string.Format(Language.GetValue("Không check được ({0})"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool AA864B1A)
	{
		if (AA864B1A && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(AA864B1A);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		A28C3D0A = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		nudThread = new System.Windows.Forms.NumericUpDown();
		label2 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		C4AC22B6 = new System.Windows.Forms.GroupBox();
		txtKhongCheckDuoc = new System.Windows.Forms.RichTextBox();
		grChuaTao = new System.Windows.Forms.GroupBox();
		EF37342D = new System.Windows.Forms.RichTextBox();
		grDaTao = new System.Windows.Forms.GroupBox();
		F2263DB0 = new System.Windows.Forms.RichTextBox();
		C282B588 = new System.Windows.Forms.GroupBox();
		B92E2E9D = new System.Windows.Forms.RichTextBox();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		FA37CA3C = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudThread).BeginInit();
		C4AC22B6.SuspendLayout();
		grChuaTao.SuspendLayout();
		grDaTao.SuspendLayout();
		C282B588.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		A28C3D0A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A28C3D0A.BackColor = System.Drawing.Color.White;
		A28C3D0A.BorderRadius = 5;
		A28C3D0A.BottomSahddow = true;
		A28C3D0A.color = System.Drawing.Color.SaddleBrown;
		A28C3D0A.LeftSahddow = false;
		A28C3D0A.Location = new System.Drawing.Point(0, 0);
		A28C3D0A.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		A28C3D0A.Name = "bunifuCards1";
		A28C3D0A.RightSahddow = true;
		A28C3D0A.ShadowDepth = 20;
		A28C3D0A.Size = new System.Drawing.Size(649, 47);
		A28C3D0A.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(nudThread);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(C4AC22B6);
		panel1.Controls.Add(grChuaTao);
		panel1.Controls.Add(grDaTao);
		panel1.Controls.Add(C282B588);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(978, 406);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(D20BCC8D);
		nudThread.Location = new System.Drawing.Point(360, 60);
		nudThread.Maximum = new decimal(new int[4] { 999999999, 0, 0, 0 });
		nudThread.Name = "nudThread";
		nudThread.Size = new System.Drawing.Size(69, 23);
		nudThread.TabIndex = 54;
		nudThread.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(294, 62);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(60, 16);
		label2.TabIndex = 53;
		label2.Text = "Threads:";
		lblStatus.AutoSize = true;
		lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
		lblStatus.Location = new System.Drawing.Point(617, 62);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(71, 16);
		lblStatus.TabIndex = 52;
		lblStatus.Text = "Checking...";
		lblStatus.Visible = false;
		C4AC22B6.Controls.Add(txtKhongCheckDuoc);
		C4AC22B6.ForeColor = System.Drawing.Color.Red;
		C4AC22B6.Location = new System.Drawing.Point(748, 91);
		C4AC22B6.Name = "grKhongCheckDuoc";
		C4AC22B6.Size = new System.Drawing.Size(221, 307);
		C4AC22B6.TabIndex = 51;
		C4AC22B6.TabStop = false;
		C4AC22B6.Text = "Can't check (0)";
		txtKhongCheckDuoc.Dock = System.Windows.Forms.DockStyle.Fill;
		txtKhongCheckDuoc.Location = new System.Drawing.Point(3, 19);
		txtKhongCheckDuoc.Name = "txtKhongCheckDuoc";
		txtKhongCheckDuoc.Size = new System.Drawing.Size(215, 285);
		txtKhongCheckDuoc.TabIndex = 50;
		txtKhongCheckDuoc.Text = "";
		txtKhongCheckDuoc.WordWrap = false;
		txtKhongCheckDuoc.TextChanged += new System.EventHandler(B6A597AE);
		grChuaTao.Controls.Add(EF37342D);
		grChuaTao.ForeColor = System.Drawing.Color.DarkRed;
		grChuaTao.Location = new System.Drawing.Point(521, 91);
		grChuaTao.Name = "grChuaTao";
		grChuaTao.Size = new System.Drawing.Size(221, 307);
		grChuaTao.TabIndex = 51;
		grChuaTao.TabStop = false;
		grChuaTao.Text = "DIE (0)";
		EF37342D.Dock = System.Windows.Forms.DockStyle.Fill;
		EF37342D.Location = new System.Drawing.Point(3, 19);
		EF37342D.Name = "txtDie";
		EF37342D.Size = new System.Drawing.Size(215, 285);
		EF37342D.TabIndex = 50;
		EF37342D.Text = "";
		EF37342D.WordWrap = false;
		EF37342D.TextChanged += new System.EventHandler(EF37342D_TextChanged);
		grDaTao.Controls.Add(F2263DB0);
		grDaTao.ForeColor = System.Drawing.Color.DarkGreen;
		grDaTao.Location = new System.Drawing.Point(294, 91);
		grDaTao.Name = "grDaTao";
		grDaTao.Size = new System.Drawing.Size(221, 307);
		grDaTao.TabIndex = 51;
		grDaTao.TabStop = false;
		grDaTao.Text = "LIVE (0)";
		F2263DB0.Dock = System.Windows.Forms.DockStyle.Fill;
		F2263DB0.Location = new System.Drawing.Point(3, 19);
		F2263DB0.Name = "txtLive";
		F2263DB0.Size = new System.Drawing.Size(215, 285);
		F2263DB0.TabIndex = 50;
		F2263DB0.Text = "";
		F2263DB0.WordWrap = false;
		F2263DB0.TextChanged += new System.EventHandler(D7ACE718);
		C282B588.Controls.Add(B92E2E9D);
		C282B588.Location = new System.Drawing.Point(6, 40);
		C282B588.Name = "groupBox1";
		C282B588.Size = new System.Drawing.Size(282, 358);
		C282B588.TabIndex = 51;
		C282B588.TabStop = false;
		C282B588.Text = "Nhập Uid (0)";
		B92E2E9D.Location = new System.Drawing.Point(9, 19);
		B92E2E9D.Name = "txtInput";
		B92E2E9D.Size = new System.Drawing.Size(267, 336);
		B92E2E9D.TabIndex = 50;
		B92E2E9D.Text = "";
		B92E2E9D.WordWrap = false;
		B92E2E9D.TextChanged += new System.EventHandler(E7306689);
		btnAdd.BackColor = System.Drawing.Color.Green;
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(476, 52);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(135, 36);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Check";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuCards2.BackColor = System.Drawing.Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new System.Drawing.Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new System.Drawing.Size(976, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(FA37CA3C);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(lblTitle);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(976, 31);
		pnlHeader.TabIndex = 9;
		FA37CA3C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		FA37CA3C.Cursor = System.Windows.Forms.Cursors.Hand;
		FA37CA3C.FlatAppearance.BorderSize = 0;
		FA37CA3C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FA37CA3C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FA37CA3C.ForeColor = System.Drawing.Color.White;
		FA37CA3C.Image = Resource.Bitmap_9;
		FA37CA3C.Location = new System.Drawing.Point(945, 1);
		FA37CA3C.Name = "button2";
		FA37CA3C.Size = new System.Drawing.Size(30, 30);
		FA37CA3C.TabIndex = 77;
		FA37CA3C.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		FA37CA3C.UseVisualStyleBackColor = true;
		FA37CA3C.Click += new System.EventHandler(FA37CA3C_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Location = new System.Drawing.Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		lblTitle.BackColor = System.Drawing.Color.Transparent;
		lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
		lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblTitle.ForeColor = System.Drawing.Color.Black;
		lblTitle.Location = new System.Drawing.Point(0, 0);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new System.Drawing.Size(976, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Check Live Uid";
		lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = lblTitle;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(978, 406);
		base.Controls.Add(panel1);
		base.Controls.Add(A28C3D0A);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchCheckLiveUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fTienIchCheckLiveUid_Load);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudThread).EndInit();
		C4AC22B6.ResumeLayout(false);
		grChuaTao.ResumeLayout(false);
		grDaTao.ResumeLayout(false);
		C282B588.ResumeLayout(false);
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_2()
	{
		lblStatus.Visible = true;
	}

	[CompilerGenerated]
	private void FDBB6B34()
	{
		lblStatus.Visible = false;
	}
}
