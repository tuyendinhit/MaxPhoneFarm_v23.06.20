using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXemStory : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string E415A8AF;

	internal string string_0;

	internal string FA055787;

	internal int int_0;

	internal static bool bool_0;

	internal List<CheckBox> FCB94C96;

	internal IContainer D20DA020 = null;

	internal BunifuDragControl D92F4203;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox A7AABFA4;

	internal Label label3;

	internal Label F7249193;

	internal Label label2;

	internal Label E8928C18;

	internal Button F0898C27;

	internal Button btnAdd;

	internal BunifuCards AE06BF31;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel C58303B9;

	internal Label F826A98D;

	internal CheckBox B789B5AE;

	internal CheckBox ckbInteract;

	internal TextBox D6265D18;

	internal Label label8;

	internal Panel D7085F85;

	internal CheckBox ckbGian;

	internal CheckBox ckbBuon;

	internal CheckBox ckbWow;

	internal CheckBox B0921CB9;

	internal CheckBox E1006810;

	internal CheckBox ckbTym;

	internal CheckBox EF082700;

	internal Panel panel7;

	internal RadioButton AABF6A3A;

	internal RadioButton C88E22B3;

	internal Label C433830F;

	public fHDXemStory(string CC880A2A, int int_1 = 0, string D32A622B = "")
	{
		InitializeComponent();
		bool_0 = false;
		E415A8AF = CC880A2A;
		FA055787 = D32A622B;
		int_0 = int_1;
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDXemStory");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A7AABFA4.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(D32A622B);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			A7AABFA4.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDXemStory_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom");
			nudSoLuongTo.Value = f72FAFBC_0.method_0("nudSoLuongTo");
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			string text = f72FAFBC_0.GetValue("typeReaction");
			FCB94C96 = new List<CheckBox> { EF082700, ckbTym, E1006810, B0921CB9, ckbWow, ckbBuon, ckbGian };
			for (int i = 0; i < FCB94C96.Count; i++)
			{
				FCB94C96[i].Checked = text.Contains(i.ToString());
			}
			B789B5AE.Checked = f72FAFBC_0.AA824D29("ckbComment");
			D6265D18.Text = f72FAFBC_0.GetValue("txtComment");
		}
		catch
		{
		}
		method_0();
	}

	private void BB313027(object sender, EventArgs e)
	{
		Close();
	}

	private void DF052B03(object sender, EventArgs e)
	{
		string text = A7AABFA4.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (B789B5AE.Checked)
		{
			List<string> f1808BA = D6265D18.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		for (int i = 0; i < FCB94C96.Count; i++)
		{
			text2 += (FCB94C96[i].Checked ? (i.ToString() ?? "") : "");
		}
		f72FAFBC.GetValue("typeReaction", (object)text2);
		f72FAFBC.GetValue("ckbComment", B789B5AE.Checked);
		f72FAFBC.GetValue("txtComment", (object)D6265D18.Text.Trim());
		string text3 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(E415A8AF, text, string_0, text3))
				{
					bool_0 = true;
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
			if (Class123.smethod_14(FA055787, text, text3))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void F0898C27_Click(object sender, EventArgs e)
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

	private void D6265D18_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = D6265D18.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			F826A98D.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_0()
	{
		ckbInteract_CheckedChanged(null, null);
		B789B5AE_CheckedChanged(null, null);
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		D7085F85.Enabled = ckbInteract.Checked;
	}

	private void B789B5AE_CheckedChanged(object sender, EventArgs e)
	{
		C58303B9.Enabled = B789B5AE.Checked;
	}

	private void BD2C712D(object sender, EventArgs e)
	{
		EF082700.Checked = !EF082700.Checked;
	}

	private void method_1(object sender, EventArgs e)
	{
		ckbTym.Checked = !ckbTym.Checked;
	}

	private void method_2(object sender, EventArgs e)
	{
		B0921CB9.Checked = !B0921CB9.Checked;
	}

	private void method_3(object sender, EventArgs e)
	{
		ckbWow.Checked = !ckbWow.Checked;
	}

	private void method_4(object sender, EventArgs e)
	{
		ckbBuon.Checked = !ckbBuon.Checked;
	}

	private void method_5(object sender, EventArgs e)
	{
		ckbGian.Checked = !ckbGian.Checked;
	}

	private void method_6(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng story!"));
	}

	protected override void Dispose(bool F7BB8D38)
	{
		if (F7BB8D38 && D20DA020 != null)
		{
			D20DA020.Dispose();
		}
		base.Dispose(F7BB8D38);
	}

	private void InitializeComponent()
	{
		D20DA020 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXemStory));
		D92F4203 = new Bunifu.Framework.UI.BunifuDragControl(D20DA020);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(D20DA020);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		C58303B9 = new System.Windows.Forms.Panel();
		label8 = new System.Windows.Forms.Label();
		D6265D18 = new System.Windows.Forms.TextBox();
		F826A98D = new System.Windows.Forms.Label();
		B789B5AE = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		A7AABFA4 = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		F7249193 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		E8928C18 = new System.Windows.Forms.Label();
		F0898C27 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		AE06BF31 = new Bunifu.Framework.UI.BunifuCards();
		D7085F85 = new System.Windows.Forms.Panel();
		ckbGian = new System.Windows.Forms.CheckBox();
		ckbBuon = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		B0921CB9 = new System.Windows.Forms.CheckBox();
		E1006810 = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		EF082700 = new System.Windows.Forms.CheckBox();
		panel7 = new System.Windows.Forms.Panel();
		AABF6A3A = new System.Windows.Forms.RadioButton();
		C88E22B3 = new System.Windows.Forms.RadioButton();
		C433830F = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		C58303B9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		AE06BF31.SuspendLayout();
		D7085F85.SuspendLayout();
		panel7.SuspendLayout();
		SuspendLayout();
		D92F4203.Fixed = true;
		D92F4203.Horizontal = true;
		D92F4203.TargetControl = bunifuCustomLabel1;
		D92F4203.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(391, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Xem Story";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(391, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(360, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(BB313027);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(D7085F85);
		panel1.Controls.Add(C58303B9);
		panel1.Controls.Add(B789B5AE);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(A7AABFA4);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(F7249193);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(E8928C18);
		panel1.Controls.Add(F0898C27);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(AE06BF31);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(394, 423);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		C58303B9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C58303B9.Controls.Add(label8);
		C58303B9.Controls.Add(D6265D18);
		C58303B9.Controls.Add(F826A98D);
		C58303B9.Location = new System.Drawing.Point(48, 202);
		C58303B9.Name = "plComment";
		C58303B9.Size = new System.Drawing.Size(312, 164);
		C58303B9.TabIndex = 8;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(3, 141);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(265, 16);
		label8.TabIndex = 2;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		D6265D18.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D6265D18.Location = new System.Drawing.Point(7, 27);
		D6265D18.Multiline = true;
		D6265D18.Name = "txtComment";
		D6265D18.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		D6265D18.Size = new System.Drawing.Size(295, 111);
		D6265D18.TabIndex = 1;
		D6265D18.WordWrap = false;
		D6265D18.TextChanged += new System.EventHandler(D6265D18_TextChanged);
		F826A98D.AutoSize = true;
		F826A98D.Location = new System.Drawing.Point(3, 5);
		F826A98D.Name = "lblStatus";
		F826A98D.Size = new System.Drawing.Size(139, 16);
		F826A98D.TabIndex = 0;
		F826A98D.Text = "Nội dung bình luận (0):";
		B789B5AE.AutoSize = true;
		B789B5AE.Cursor = System.Windows.Forms.Cursors.Hand;
		B789B5AE.Location = new System.Drawing.Point(30, 177);
		B789B5AE.Name = "ckbComment";
		B789B5AE.Size = new System.Drawing.Size(130, 20);
		B789B5AE.TabIndex = 7;
		B789B5AE.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		B789B5AE.UseVisualStyleBackColor = true;
		B789B5AE.CheckedChanged += new System.EventHandler(B789B5AE_CheckedChanged);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 109);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(112, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		A7AABFA4.Location = new System.Drawing.Point(132, 49);
		A7AABFA4.Name = "txtTenHanhDong";
		A7AABFA4.Size = new System.Drawing.Size(228, 23);
		A7AABFA4.TabIndex = 0;
		label3.Location = new System.Drawing.Point(194, 82);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F7249193.AutoSize = true;
		F7249193.Location = new System.Drawing.Point(290, 82);
		F7249193.Name = "label4";
		F7249193.Size = new System.Drawing.Size(30, 16);
		F7249193.TabIndex = 35;
		F7249193.Text = "giây";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 82);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(93, 16);
		label2.TabIndex = 32;
		label2.Text = "Thời gian xem:";
		E8928C18.AutoSize = true;
		E8928C18.Location = new System.Drawing.Point(27, 52);
		E8928C18.Name = "label1";
		E8928C18.Size = new System.Drawing.Size(98, 16);
		E8928C18.TabIndex = 31;
		E8928C18.Text = "Tên ha\u0300nh đô\u0323ng:";
		F0898C27.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F0898C27.BackColor = System.Drawing.Color.Maroon;
		F0898C27.Cursor = System.Windows.Forms.Cursors.Hand;
		F0898C27.FlatAppearance.BorderSize = 0;
		F0898C27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F0898C27.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F0898C27.ForeColor = System.Drawing.Color.White;
		F0898C27.Location = new System.Drawing.Point(205, 380);
		F0898C27.Name = "btnCancel";
		F0898C27.Size = new System.Drawing.Size(92, 29);
		F0898C27.TabIndex = 10;
		F0898C27.Text = "Đóng";
		F0898C27.UseVisualStyleBackColor = false;
		F0898C27.Click += new System.EventHandler(F0898C27_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(98, 380);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(DF052B03);
		AE06BF31.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		AE06BF31.BackColor = System.Drawing.Color.White;
		AE06BF31.BorderRadius = 0;
		AE06BF31.BottomSahddow = true;
		AE06BF31.color = System.Drawing.Color.DarkViolet;
		AE06BF31.Controls.Add(pnlHeader);
		AE06BF31.LeftSahddow = false;
		AE06BF31.Location = new System.Drawing.Point(1, 0);
		AE06BF31.Name = "bunifuCards1";
		AE06BF31.RightSahddow = true;
		AE06BF31.ShadowDepth = 20;
		AE06BF31.Size = new System.Drawing.Size(391, 37);
		AE06BF31.TabIndex = 28;
		D7085F85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D7085F85.Controls.Add(ckbGian);
		D7085F85.Controls.Add(ckbBuon);
		D7085F85.Controls.Add(ckbWow);
		D7085F85.Controls.Add(B0921CB9);
		D7085F85.Controls.Add(E1006810);
		D7085F85.Controls.Add(ckbTym);
		D7085F85.Controls.Add(EF082700);
		D7085F85.Controls.Add(panel7);
		D7085F85.Controls.Add(C433830F);
		D7085F85.Location = new System.Drawing.Point(48, 135);
		D7085F85.Name = "plInteract";
		D7085F85.Size = new System.Drawing.Size(312, 33);
		D7085F85.TabIndex = 181;
		ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGian.Image = Resource.Bitmap_5;
		ckbGian.Location = new System.Drawing.Point(266, 1);
		ckbGian.Name = "ckbGian";
		ckbGian.Size = new System.Drawing.Size(40, 30);
		ckbGian.TabIndex = 179;
		ckbGian.UseVisualStyleBackColor = true;
		ckbBuon.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBuon.Image = Resource.Bitmap_174;
		ckbBuon.Location = new System.Drawing.Point(222, 1);
		ckbBuon.Name = "ckbBuon";
		ckbBuon.Size = new System.Drawing.Size(40, 30);
		ckbBuon.TabIndex = 178;
		ckbBuon.UseVisualStyleBackColor = true;
		ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWow.Image = Resource.F391A116;
		ckbWow.Location = new System.Drawing.Point(178, 1);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new System.Drawing.Size(40, 30);
		ckbWow.TabIndex = 177;
		ckbWow.UseVisualStyleBackColor = true;
		B0921CB9.Cursor = System.Windows.Forms.Cursors.Hand;
		B0921CB9.Image = Resource.Bitmap_38;
		B0921CB9.Location = new System.Drawing.Point(134, 1);
		B0921CB9.Name = "ckbHaha";
		B0921CB9.Size = new System.Drawing.Size(40, 30);
		B0921CB9.TabIndex = 176;
		B0921CB9.UseVisualStyleBackColor = true;
		E1006810.Cursor = System.Windows.Forms.Cursors.Hand;
		E1006810.Image = Resource.DD3ED6B8;
		E1006810.Location = new System.Drawing.Point(90, 1);
		E1006810.Name = "ckbThuong";
		E1006810.Size = new System.Drawing.Size(40, 30);
		E1006810.TabIndex = 175;
		E1006810.UseVisualStyleBackColor = true;
		ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTym.Image = Resource.C8AF3BB6;
		ckbTym.Location = new System.Drawing.Point(46, 1);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new System.Drawing.Size(40, 30);
		ckbTym.TabIndex = 174;
		ckbTym.UseVisualStyleBackColor = true;
		EF082700.Checked = true;
		EF082700.CheckState = System.Windows.Forms.CheckState.Checked;
		EF082700.Cursor = System.Windows.Forms.Cursors.Hand;
		EF082700.Image = Resource.Bitmap_163;
		EF082700.Location = new System.Drawing.Point(2, 1);
		EF082700.Name = "ckbLike";
		EF082700.Size = new System.Drawing.Size(40, 30);
		EF082700.TabIndex = 173;
		EF082700.UseVisualStyleBackColor = true;
		panel7.Controls.Add(AABF6A3A);
		panel7.Controls.Add(C88E22B3);
		panel7.Location = new System.Drawing.Point(67, 300);
		panel7.Name = "panel7";
		panel7.Size = new System.Drawing.Size(200, 43);
		panel7.TabIndex = 43;
		AABF6A3A.AutoSize = true;
		AABF6A3A.Checked = true;
		AABF6A3A.Cursor = System.Windows.Forms.Cursors.Hand;
		AABF6A3A.Location = new System.Drawing.Point(3, 2);
		AABF6A3A.Name = "radioButton3";
		AABF6A3A.Size = new System.Drawing.Size(201, 20);
		AABF6A3A.TabIndex = 3;
		AABF6A3A.TabStop = true;
		AABF6A3A.Text = "Comment theo thứ tự nội dung";
		AABF6A3A.UseVisualStyleBackColor = true;
		C88E22B3.AutoSize = true;
		C88E22B3.Cursor = System.Windows.Forms.Cursors.Hand;
		C88E22B3.Location = new System.Drawing.Point(3, 23);
		C88E22B3.Name = "radioButton4";
		C88E22B3.Size = new System.Drawing.Size(200, 20);
		C88E22B3.TabIndex = 3;
		C88E22B3.Text = "Comment ngẫu nhiên nội dung";
		C88E22B3.UseVisualStyleBackColor = true;
		C433830F.AutoSize = true;
		C433830F.Location = new System.Drawing.Point(4, 302);
		C433830F.Name = "label26";
		C433830F.Size = new System.Drawing.Size(64, 16);
		C433830F.TabIndex = 2;
		C433830F.Text = "Tùy chọn:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(394, 423);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXemStory";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXemStory_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		C58303B9.ResumeLayout(false);
		C58303B9.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		AE06BF31.ResumeLayout(false);
		D7085F85.ResumeLayout(false);
		D7085F85.PerformLayout();
		panel7.ResumeLayout(false);
		panel7.PerformLayout();
		ResumeLayout(false);
	}
}
