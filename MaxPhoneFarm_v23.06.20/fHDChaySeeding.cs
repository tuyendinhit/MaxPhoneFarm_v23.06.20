using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDChaySeeding : Form
{
	internal JSON_Settings f72FAFBC_0 = null;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int int_0;

	internal static bool CC99763A;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl ADBFD886;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal TextBox F188D88C;

	internal Label label1;

	internal Button btnCancel;

	internal Button E6B34226;

	internal BunifuCards bunifuCards1;

	internal Panel C5176612;

	internal Button EA2FF7B0;

	internal PictureBox F2B10C21;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal NumericUpDown FC2727B9;

	internal NumericUpDown nudDelayFrom;

	internal Label label7;

	internal Label label6;

	internal Label label5;

	internal CheckedListBox FD345D86;

	internal Label F31F84B4;

	public fHDChaySeeding(string string_3, int A4A7390A = 0, string BFA00230 = "")
	{
		InitializeComponent();
		CC99763A = false;
		string_0 = string_3;
		string_2 = BFA00230;
		int_0 = A4A7390A;
		string text = base.Name.Substring(1);
		string text2 = "Chạy Seeding";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (A4A7390A)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			F188D88C.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(BFA00230);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			E6B34226.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			F188D88C.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDChaySeeding_Load(object sender, EventArgs e)
	{
		D8B277B2();
		nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
		FC2727B9.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
		List<string> source = f72FAFBC_0.GetValue("lstType").Split('|').ToList();
		for (int i = 0; i < FD345D86.Items.Count; i++)
		{
			if (source.Contains(FD345D86.Items[i]))
			{
				FD345D86.SetItemChecked(i, value: true);
			}
		}
	}

	private void D8B277B2()
	{
		FD345D86.Items.Add("like");
		FD345D86.Items.Add("reaction");
		FD345D86.Items.Add("like_page");
		FD345D86.Items.Add("share");
		FD345D86.Items.Add("sub");
		FD345D86.Items.Add("cmt");
		FD345D86.Items.Add("group");
		FD345D86.Items.Add("reviews");
		FD345D86.Items.Add("kbsub");
		FD345D86.Items.Add("reellike");
		FD345D86.Items.Add("reelcmt");
	}

	private void EA2FF7B0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E20E1D34(object sender, EventArgs e)
	{
		string text = F188D88C.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		f72FAFBC_0.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC_0.GetValue("nudDelayTo", FC2727B9.Value);
		List<string> list = new List<string>();
		foreach (string checkedItem in FD345D86.CheckedItems)
		{
			list.Add(checkedItem);
		}
        f72FAFBC_0.GetValue("lstType", (object)string.Join("|", list));
		string d9253C2E = f72FAFBC_0.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, d9253C2E))
				{
					CC99763A = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (Class123.smethod_14(string_2, text, d9253C2E))
			{
				CC99763A = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void C4179D2D(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDChaySeeding));
		ADBFD886 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		C5176612 = new System.Windows.Forms.Panel();
		EA2FF7B0 = new System.Windows.Forms.Button();
		F2B10C21 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		FC2727B9 = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		F188D88C = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		E6B34226 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		F31F84B4 = new System.Windows.Forms.Label();
		FD345D86 = new System.Windows.Forms.CheckedListBox();
		C5176612.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F2B10C21).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FC2727B9).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		ADBFD886.Fixed = true;
		ADBFD886.Horizontal = true;
		ADBFD886.TargetControl = bunifuCustomLabel1;
		ADBFD886.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Chạy Seeding";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = C5176612;
		bunifuDragControl_0.Vertical = true;
		C5176612.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C5176612.BackColor = System.Drawing.Color.White;
		C5176612.Controls.Add(EA2FF7B0);
		C5176612.Controls.Add(F2B10C21);
		C5176612.Controls.Add(bunifuCustomLabel1);
		C5176612.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C5176612.Location = new System.Drawing.Point(0, 3);
		C5176612.Name = "pnlHeader";
		C5176612.Size = new System.Drawing.Size(359, 31);
		C5176612.TabIndex = 9;
		EA2FF7B0.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		EA2FF7B0.Cursor = System.Windows.Forms.Cursors.Hand;
		EA2FF7B0.FlatAppearance.BorderSize = 0;
		EA2FF7B0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EA2FF7B0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EA2FF7B0.ForeColor = System.Drawing.Color.White;
		EA2FF7B0.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		EA2FF7B0.Location = new System.Drawing.Point(328, 1);
		EA2FF7B0.Name = "button1";
		EA2FF7B0.Size = new System.Drawing.Size(30, 30);
		EA2FF7B0.TabIndex = 77;
		EA2FF7B0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		EA2FF7B0.UseVisualStyleBackColor = true;
		EA2FF7B0.Click += new System.EventHandler(EA2FF7B0_Click);
		F2B10C21.Cursor = System.Windows.Forms.Cursors.Default;
		F2B10C21.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		F2B10C21.Location = new System.Drawing.Point(3, 2);
		F2B10C21.Name = "pictureBox1";
		F2B10C21.Size = new System.Drawing.Size(34, 27);
		F2B10C21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		F2B10C21.TabIndex = 76;
		F2B10C21.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(FD345D86);
		panel1.Controls.Add(FC2727B9);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(F31F84B4);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(F188D88C);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(E6B34226);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 327);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		FC2727B9.Location = new System.Drawing.Point(229, 78);
		FC2727B9.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FC2727B9.Name = "nudDelayTo";
		FC2727B9.Size = new System.Drawing.Size(56, 23);
		FC2727B9.TabIndex = 40;
		nudDelayFrom.Location = new System.Drawing.Point(132, 78);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 39;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(194, 80);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 43;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(287, 80);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 42;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 80);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(105, 16);
		label5.TabIndex = 41;
		label5.Text = "Delay giữa 2 job:";
		F188D88C.Location = new System.Drawing.Point(132, 49);
		F188D88C.Name = "txtTenHanhDong";
		F188D88C.Size = new System.Drawing.Size(194, 23);
		F188D88C.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 283);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(C4179D2D);
		E6B34226.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E6B34226.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		E6B34226.Cursor = System.Windows.Forms.Cursors.Hand;
		E6B34226.FlatAppearance.BorderSize = 0;
		E6B34226.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E6B34226.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E6B34226.ForeColor = System.Drawing.Color.White;
		E6B34226.Location = new System.Drawing.Point(82, 283);
		E6B34226.Name = "btnAdd";
		E6B34226.Size = new System.Drawing.Size(92, 29);
		E6B34226.TabIndex = 9;
		E6B34226.Text = "Thêm";
		E6B34226.UseVisualStyleBackColor = false;
		E6B34226.Click += new System.EventHandler(E20E1D34);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(C5176612);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		F31F84B4.AutoSize = true;
		F31F84B4.Location = new System.Drawing.Point(27, 110);
		F31F84B4.Name = "label2";
		F31F84B4.Size = new System.Drawing.Size(63, 16);
		F31F84B4.TabIndex = 41;
		F31F84B4.Text = "Type Job:";
		FD345D86.FormattingEnabled = true;
		FD345D86.Location = new System.Drawing.Point(132, 110);
		FD345D86.Name = "checkedListBox1";
		FD345D86.Size = new System.Drawing.Size(194, 148);
		FD345D86.TabIndex = 44;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 327);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChaySeeding";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDChaySeeding_Load);
		C5176612.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)F2B10C21).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)FC2727B9).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
