using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacLivestream : Form
{
	internal JSON_Settings BC137619;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer B8A29018 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel D40EFC97;

	internal NumericUpDown DF2D25A4;

	internal NumericUpDown B4A0FE83;

	internal TextBox txtTenHanhDong;

	internal Label E691D613;

	internal Label label4;

	internal Label CA181A0D;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel ED313EBB;

	internal Label lblStatus;

	internal Panel plInteract;

	internal Label label25;

	internal Label label26;

	internal Label label28;

	internal Label label29;

	internal Label label30;

	internal CheckBox ckbGian;

	internal CheckBox E435752A;

	internal CheckBox ckbWow;

	internal CheckBox ckbHaha;

	internal CheckBox ckbTym;

	internal CheckBox ckbLike;

	internal Label label32;

	internal CheckBox ckbComment;

	internal CheckBox CB386F34;

	internal TextBox B81B4118;

	internal Label label8;

	internal Panel CCB774B5;

	internal NumericUpDown E086B590;

	internal Label lblmc1;

	internal NumericUpDown nudBinhLuanNhieuLanDelayFrom;

	internal Label label5;

	internal Label BEBFAA3C;

	internal CheckBox ckbBinhLuanNhieuLan;

	internal TextBox txtLinkVideo;

	internal Label label9;

	internal LinkLabel linkLabel1;

	public fHDTuongTacLivestream(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Tương tác Livestream";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_4);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		BC137619 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(CA181A0D);
		Language.smethod_1(E691D613);
		Language.smethod_1(label4);
		Language.smethod_1(CB386F34);
		Language.smethod_1(label26);
		Language.smethod_1(label30);
		Language.smethod_1(label32);
		Language.smethod_1(ckbComment);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
		Language.smethod_1(ckbBinhLuanNhieuLan);
		Language.smethod_1(BEBFAA3C);
		Language.smethod_1(label5);
	}

	private void D1A4CB24(object sender, EventArgs e)
	{
		try
		{
			txtLinkVideo.Text = BC137619.GetValue("txtLinkVideo");
			B4A0FE83.Value = BC137619.method_0("nudSoLuongFrom", 30);
			DF2D25A4.Value = BC137619.method_0("nudSoLuongTo", 30);
			CB386F34.Checked = BC137619.AA824D29("ckbInteract");
			string text = BC137619.GetValue("typeReaction");
			List<CheckBox> list = new List<CheckBox> { ckbLike, ckbTym, ckbHaha, ckbWow, E435752A, ckbGian };
			for (int i = 0; i < list.Count; i++)
			{
				if (text.Contains(i.ToString()))
				{
					list[i].Checked = true;
				}
			}
			ckbComment.Checked = BC137619.AA824D29("ckbComment");
			B81B4118.Text = BC137619.GetValue("txtComment");
			ckbBinhLuanNhieuLan.Checked = BC137619.AA824D29("ckbBinhLuanNhieuLan");
			nudBinhLuanNhieuLanDelayFrom.Value = BC137619.method_0("nudBinhLuanNhieuLanDelayFrom", 10);
			E086B590.Value = BC137619.method_0("nudBinhLuanNhieuLanDelayTo", 10);
		}
		catch
		{
		}
		method_1();
	}

	private void C8A4DF83(object sender, EventArgs e)
	{
		Close();
	}

	private void A30B6B22(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> f1808BA = B81B4118.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtLinkVideo", (object)txtLinkVideo.Text.Trim());
		f72FAFBC.GetValue("nudSoLuongFrom", B4A0FE83.Value);
		f72FAFBC.GetValue("nudSoLuongTo", DF2D25A4.Value);
		f72FAFBC.GetValue("ckbInteract", CB386F34.Checked);
		string text2 = "";
		List<CheckBox> list = new List<CheckBox> { ckbLike, ckbTym, ckbHaha, ckbWow, E435752A, ckbGian };
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Checked)
			{
				text2 += i;
			}
		}
		f72FAFBC.GetValue("typeReaction", (object)text2);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)B81B4118.Text.Trim());
		f72FAFBC.GetValue("ckbBinhLuanNhieuLan", ckbBinhLuanNhieuLan.Checked);
		f72FAFBC.GetValue("nudBinhLuanNhieuLanDelayFrom", nudBinhLuanNhieuLanDelayFrom.Value);
		f72FAFBC.GetValue("nudBinhLuanNhieuLanDelayTo", E086B590.Value);
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, d9253C2E))
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
			if (Class123.smethod_14(string_2, text, d9253C2E))
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A88AB3A2(object sender, PaintEventArgs e)
	{
		if (D40EFC97.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, D40EFC97.ClientSize.Width - num, D40EFC97.ClientSize.Height - num));
		}
	}

	private void B81B4118_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = B81B4118.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		CB386F34_CheckedChanged(null, null);
		C799CA05(null, null);
		B58EB425(null, null);
	}

	private void CB386F34_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = CB386F34.Checked;
	}

	private void C799CA05(object sender, EventArgs e)
	{
		ED313EBB.Enabled = ckbComment.Checked;
	}

	private void label25_Click(object sender, EventArgs e)
	{
		ckbLike.Checked = !ckbLike.Checked;
	}

	private void DB945F85(object sender, EventArgs e)
	{
		ckbTym.Checked = !ckbTym.Checked;
	}

	private void label28_Click(object sender, EventArgs e)
	{
		ckbHaha.Checked = !ckbHaha.Checked;
	}

	private void FD9DDF2F(object sender, EventArgs e)
	{
		ckbWow.Checked = !ckbWow.Checked;
	}

	private void ED2DE23F(object sender, EventArgs e)
	{
		E435752A.Checked = !E435752A.Checked;
	}

	private void label32_Click(object sender, EventArgs e)
	{
		ckbGian.Checked = !ckbGian.Checked;
	}

	private void B58EB425(object sender, EventArgs e)
	{
		CCB774B5.Enabled = ckbBinhLuanNhieuLan.Checked;
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void label8_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && B8A29018 != null)
		{
			B8A29018.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		B8A29018 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacLivestream));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(B8A29018);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(B8A29018);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		D40EFC97 = new System.Windows.Forms.Panel();
		ED313EBB = new System.Windows.Forms.Panel();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		CCB774B5 = new System.Windows.Forms.Panel();
		E086B590 = new System.Windows.Forms.NumericUpDown();
		lblmc1 = new System.Windows.Forms.Label();
		nudBinhLuanNhieuLanDelayFrom = new System.Windows.Forms.NumericUpDown();
		label5 = new System.Windows.Forms.Label();
		BEBFAA3C = new System.Windows.Forms.Label();
		ckbBinhLuanNhieuLan = new System.Windows.Forms.CheckBox();
		label8 = new System.Windows.Forms.Label();
		B81B4118 = new System.Windows.Forms.TextBox();
		lblStatus = new System.Windows.Forms.Label();
		plInteract = new System.Windows.Forms.Panel();
		label25 = new System.Windows.Forms.Label();
		label26 = new System.Windows.Forms.Label();
		label28 = new System.Windows.Forms.Label();
		label29 = new System.Windows.Forms.Label();
		label30 = new System.Windows.Forms.Label();
		ckbGian = new System.Windows.Forms.CheckBox();
		E435752A = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		label32 = new System.Windows.Forms.Label();
		ckbComment = new System.Windows.Forms.CheckBox();
		CB386F34 = new System.Windows.Forms.CheckBox();
		DF2D25A4 = new System.Windows.Forms.NumericUpDown();
		B4A0FE83 = new System.Windows.Forms.NumericUpDown();
		txtLinkVideo = new System.Windows.Forms.TextBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		E691D613 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		CA181A0D = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		D40EFC97.SuspendLayout();
		ED313EBB.SuspendLayout();
		CCB774B5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E086B590).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayFrom).BeginInit();
		plInteract.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DF2D25A4).BeginInit();
		((System.ComponentModel.ISupportInitialize)B4A0FE83).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Livestream";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(328, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(C8A4DF83);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		D40EFC97.BackColor = System.Drawing.Color.White;
		D40EFC97.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D40EFC97.Controls.Add(ED313EBB);
		D40EFC97.Controls.Add(plInteract);
		D40EFC97.Controls.Add(ckbComment);
		D40EFC97.Controls.Add(CB386F34);
		D40EFC97.Controls.Add(DF2D25A4);
		D40EFC97.Controls.Add(B4A0FE83);
		D40EFC97.Controls.Add(txtLinkVideo);
		D40EFC97.Controls.Add(txtTenHanhDong);
		D40EFC97.Controls.Add(E691D613);
		D40EFC97.Controls.Add(label4);
		D40EFC97.Controls.Add(label9);
		D40EFC97.Controls.Add(CA181A0D);
		D40EFC97.Controls.Add(label1);
		D40EFC97.Controls.Add(btnCancel);
		D40EFC97.Controls.Add(btnAdd);
		D40EFC97.Controls.Add(bunifuCards1);
		D40EFC97.Cursor = System.Windows.Forms.Cursors.Arrow;
		D40EFC97.Dock = System.Windows.Forms.DockStyle.Fill;
		D40EFC97.Location = new System.Drawing.Point(0, 0);
		D40EFC97.Name = "panel1";
		D40EFC97.Size = new System.Drawing.Size(362, 503);
		D40EFC97.TabIndex = 0;
		D40EFC97.Paint += new System.Windows.Forms.PaintEventHandler(A88AB3A2);
		ED313EBB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ED313EBB.Controls.Add(linkLabel1);
		ED313EBB.Controls.Add(CCB774B5);
		ED313EBB.Controls.Add(ckbBinhLuanNhieuLan);
		ED313EBB.Controls.Add(label8);
		ED313EBB.Controls.Add(B81B4118);
		ED313EBB.Controls.Add(lblStatus);
		ED313EBB.Location = new System.Drawing.Point(48, 229);
		ED313EBB.Name = "plComment";
		ED313EBB.Size = new System.Drawing.Size(278, 213);
		ED313EBB.TabIndex = 8;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.Location = new System.Drawing.Point(190, 141);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(82, 16);
		linkLabel1.TabIndex = 192;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		CCB774B5.Controls.Add(E086B590);
		CCB774B5.Controls.Add(lblmc1);
		CCB774B5.Controls.Add(nudBinhLuanNhieuLanDelayFrom);
		CCB774B5.Controls.Add(label5);
		CCB774B5.Controls.Add(BEBFAA3C);
		CCB774B5.Location = new System.Drawing.Point(19, 182);
		CCB774B5.Name = "plBinhLuanNhieuLan";
		CCB774B5.Size = new System.Drawing.Size(254, 27);
		CCB774B5.TabIndex = 134;
		E086B590.Cursor = System.Windows.Forms.Cursors.Hand;
		E086B590.Location = new System.Drawing.Point(166, 2);
		E086B590.Maximum = new decimal(new int[4] { 100000000, 0, 0, 0 });
		E086B590.Name = "nudBinhLuanNhieuLanDelayTo";
		E086B590.Size = new System.Drawing.Size(50, 23);
		E086B590.TabIndex = 22;
		lblmc1.AutoSize = true;
		lblmc1.Location = new System.Drawing.Point(4, 4);
		lblmc1.Name = "lblmc1";
		lblmc1.Size = new System.Drawing.Size(73, 16);
		lblmc1.TabIndex = 18;
		lblmc1.Text = "Delay time:";
		nudBinhLuanNhieuLanDelayFrom.Cursor = System.Windows.Forms.Cursors.Hand;
		nudBinhLuanNhieuLanDelayFrom.Location = new System.Drawing.Point(88, 2);
		nudBinhLuanNhieuLanDelayFrom.Maximum = new decimal(new int[4] { 100000000, 0, 0, 0 });
		nudBinhLuanNhieuLanDelayFrom.Name = "nudBinhLuanNhieuLanDelayFrom";
		nudBinhLuanNhieuLanDelayFrom.Size = new System.Drawing.Size(45, 23);
		nudBinhLuanNhieuLanDelayFrom.TabIndex = 21;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(218, 4);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(31, 16);
		label5.TabIndex = 20;
		label5.Text = "giây";
		BEBFAA3C.Location = new System.Drawing.Point(135, 4);
		BEBFAA3C.Name = "label6";
		BEBFAA3C.Size = new System.Drawing.Size(29, 16);
		BEBFAA3C.TabIndex = 20;
		BEBFAA3C.Text = "đến";
		BEBFAA3C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ckbBinhLuanNhieuLan.AutoSize = true;
		ckbBinhLuanNhieuLan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBinhLuanNhieuLan.Location = new System.Drawing.Point(7, 163);
		ckbBinhLuanNhieuLan.Name = "ckbBinhLuanNhieuLan";
		ckbBinhLuanNhieuLan.Size = new System.Drawing.Size(135, 20);
		ckbBinhLuanNhieuLan.TabIndex = 133;
		ckbBinhLuanNhieuLan.Text = "Bình luận nhiều lần";
		ckbBinhLuanNhieuLan.UseVisualStyleBackColor = true;
		ckbBinhLuanNhieuLan.CheckedChanged += new System.EventHandler(B58EB425);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(3, 141);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(144, 16);
		label8.TabIndex = 2;
		label8.Text = "(Spin nội dung {a|b|c})";
		label8.Click += new System.EventHandler(label8_Click);
		B81B4118.Location = new System.Drawing.Point(7, 27);
		B81B4118.Multiline = true;
		B81B4118.Name = "txtComment";
		B81B4118.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		B81B4118.Size = new System.Drawing.Size(261, 111);
		B81B4118.TabIndex = 1;
		B81B4118.WordWrap = false;
		B81B4118.TextChanged += new System.EventHandler(B81B4118_TextChanged);
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(140, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plInteract.Controls.Add(label25);
		plInteract.Controls.Add(label26);
		plInteract.Controls.Add(label28);
		plInteract.Controls.Add(label29);
		plInteract.Controls.Add(label30);
		plInteract.Controls.Add(ckbGian);
		plInteract.Controls.Add(E435752A);
		plInteract.Controls.Add(ckbWow);
		plInteract.Controls.Add(ckbHaha);
		plInteract.Controls.Add(ckbTym);
		plInteract.Controls.Add(ckbLike);
		plInteract.Controls.Add(label32);
		plInteract.Location = new System.Drawing.Point(48, 160);
		plInteract.Name = "plInteract";
		plInteract.Size = new System.Drawing.Size(278, 40);
		plInteract.TabIndex = 6;
		label25.Cursor = System.Windows.Forms.Cursors.Hand;
		label25.Location = new System.Drawing.Point(4, 1);
		label25.Name = "label25";
		label25.Size = new System.Drawing.Size(30, 16);
		label25.TabIndex = 0;
		label25.Text = "Like";
		label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label25.Click += new System.EventHandler(label25_Click);
		label26.Cursor = System.Windows.Forms.Cursors.Hand;
		label26.Location = new System.Drawing.Point(46, 1);
		label26.Name = "label26";
		label26.Size = new System.Drawing.Size(39, 16);
		label26.TabIndex = 2;
		label26.Text = "Tym";
		label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label26.Click += new System.EventHandler(DB945F85);
		label28.Cursor = System.Windows.Forms.Cursors.Hand;
		label28.Location = new System.Drawing.Point(93, 1);
		label28.Name = "label28";
		label28.Size = new System.Drawing.Size(37, 16);
		label28.TabIndex = 6;
		label28.Text = "Haha";
		label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label28.Click += new System.EventHandler(label28_Click);
		label29.Cursor = System.Windows.Forms.Cursors.Hand;
		label29.Location = new System.Drawing.Point(140, 1);
		label29.Name = "label29";
		label29.Size = new System.Drawing.Size(37, 16);
		label29.TabIndex = 8;
		label29.Text = "Wow";
		label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label29.Click += new System.EventHandler(FD9DDF2F);
		label30.Cursor = System.Windows.Forms.Cursors.Hand;
		label30.Location = new System.Drawing.Point(187, 1);
		label30.Name = "label30";
		label30.Size = new System.Drawing.Size(36, 16);
		label30.TabIndex = 10;
		label30.Text = "Buồn";
		label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label30.Click += new System.EventHandler(ED2DE23F);
		ckbGian.AutoSize = true;
		ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGian.Location = new System.Drawing.Point(246, 20);
		ckbGian.Name = "ckbGian";
		ckbGian.Size = new System.Drawing.Size(15, 14);
		ckbGian.TabIndex = 13;
		ckbGian.UseVisualStyleBackColor = true;
		E435752A.AutoSize = true;
		E435752A.Cursor = System.Windows.Forms.Cursors.Hand;
		E435752A.Location = new System.Drawing.Point(199, 20);
		E435752A.Name = "ckbBuon";
		E435752A.Size = new System.Drawing.Size(15, 14);
		E435752A.TabIndex = 11;
		E435752A.UseVisualStyleBackColor = true;
		ckbWow.AutoSize = true;
		ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWow.Location = new System.Drawing.Point(152, 20);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new System.Drawing.Size(15, 14);
		ckbWow.TabIndex = 9;
		ckbWow.UseVisualStyleBackColor = true;
		ckbHaha.AutoSize = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Location = new System.Drawing.Point(105, 20);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(15, 14);
		ckbHaha.TabIndex = 7;
		ckbHaha.UseVisualStyleBackColor = true;
		ckbTym.AutoSize = true;
		ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTym.Location = new System.Drawing.Point(58, 20);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new System.Drawing.Size(15, 14);
		ckbTym.TabIndex = 3;
		ckbTym.UseVisualStyleBackColor = true;
		ckbLike.AutoSize = true;
		ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike.Location = new System.Drawing.Point(11, 20);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new System.Drawing.Size(15, 14);
		ckbLike.TabIndex = 1;
		ckbLike.UseVisualStyleBackColor = true;
		label32.Cursor = System.Windows.Forms.Cursors.Hand;
		label32.Location = new System.Drawing.Point(233, 1);
		label32.Name = "label32";
		label32.Size = new System.Drawing.Size(41, 16);
		label32.TabIndex = 12;
		label32.Text = "Giận";
		label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label32.Click += new System.EventHandler(label32_Click);
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(30, 204);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(131, 20);
		ckbComment.TabIndex = 7;
		ckbComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(C799CA05);
		CB386F34.AutoSize = true;
		CB386F34.Cursor = System.Windows.Forms.Cursors.Hand;
		CB386F34.Location = new System.Drawing.Point(30, 136);
		CB386F34.Name = "ckbInteract";
		CB386F34.Size = new System.Drawing.Size(113, 20);
		CB386F34.TabIndex = 5;
		CB386F34.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		CB386F34.UseVisualStyleBackColor = true;
		CB386F34.CheckedChanged += new System.EventHandler(CB386F34_CheckedChanged);
		DF2D25A4.Location = new System.Drawing.Point(229, 107);
		DF2D25A4.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DF2D25A4.Name = "nudSoLuongTo";
		DF2D25A4.Size = new System.Drawing.Size(56, 23);
		DF2D25A4.TabIndex = 2;
		B4A0FE83.Location = new System.Drawing.Point(132, 107);
		B4A0FE83.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B4A0FE83.Name = "nudSoLuongFrom";
		B4A0FE83.Size = new System.Drawing.Size(56, 23);
		B4A0FE83.TabIndex = 1;
		txtLinkVideo.Location = new System.Drawing.Point(132, 78);
		txtLinkVideo.Name = "txtLinkVideo";
		txtLinkVideo.Size = new System.Drawing.Size(194, 23);
		txtLinkVideo.TabIndex = 0;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		E691D613.Location = new System.Drawing.Point(194, 109);
		E691D613.Name = "label3";
		E691D613.Size = new System.Drawing.Size(29, 16);
		E691D613.TabIndex = 37;
		E691D613.Text = "đê\u0301n";
		E691D613.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(290, 109);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(31, 16);
		label4.TabIndex = 35;
		label4.Text = "giây";
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(27, 81);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(98, 16);
		label9.TabIndex = 31;
		label9.Text = "Link livestream:";
		CA181A0D.AutoSize = true;
		CA181A0D.Location = new System.Drawing.Point(27, 109);
		CA181A0D.Name = "label2";
		CA181A0D.Size = new System.Drawing.Size(94, 16);
		CA181A0D.TabIndex = 32;
		CA181A0D.Text = "Thời gian xem:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 459);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 459);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(A30B6B22);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 503);
		base.Controls.Add(D40EFC97);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacLivestream";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D1A4CB24);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		D40EFC97.ResumeLayout(false);
		D40EFC97.PerformLayout();
		ED313EBB.ResumeLayout(false);
		ED313EBB.PerformLayout();
		CCB774B5.ResumeLayout(false);
		CCB774B5.PerformLayout();
		((System.ComponentModel.ISupportInitialize)E086B590).EndInit();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayFrom).EndInit();
		plInteract.ResumeLayout(false);
		plInteract.PerformLayout();
		((System.ComponentModel.ISupportInitialize)DF2D25A4).EndInit();
		((System.ComponentModel.ISupportInitialize)B4A0FE83).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
