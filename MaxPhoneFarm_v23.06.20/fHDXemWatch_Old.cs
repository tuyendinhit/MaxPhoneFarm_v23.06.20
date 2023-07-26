using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXemWatch_Old : Form
{
	internal JSON_Settings D6358527;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int int_0;

	internal static bool B412D02F;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal NumericUpDown nudTimeWatchTo;

	internal NumericUpDown E316D937;

	internal NumericUpDown nudTimeWatchFrom;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox FBA31A30;

	internal Label label7;

	internal Label D384FC33;

	internal Label FAB3EC81;

	internal Label C6B01D32;

	internal Label FAA1AFB5;

	internal Label label2;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button CF113F3B;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label C7AE9FB5;

	internal Label E38CD208;

	internal CheckBox ckbComment;

	internal CheckBox ckbInteract;

	internal CheckBox ckbShareWall;

	internal Panel plCountComment;

	internal NumericUpDown nudCountCommentFrom;

	internal Label label13;

	internal Label label14;

	internal NumericUpDown nudCountCommentTo;

	internal Panel E5315007;

	internal NumericUpDown nudCountShareFrom;

	internal Label D629E3A8;

	internal Label label12;

	internal NumericUpDown A693A284;

	internal Panel A903DD20;

	internal NumericUpDown nudCountLikeFrom;

	internal Label label9;

	internal Label label10;

	internal NumericUpDown nudCountLikeTo;

	internal RichTextBox txtComment;

	public fHDXemWatch_Old(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		B412D02F = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDXemWatch");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			FBA31A30.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_4);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			FBA31A30.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		D6358527 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void FF26BB91()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(label2);
		Language.smethod_1(D384FC33);
		Language.smethod_1(C6B01D32);
		Language.smethod_1(FAA1AFB5);
		Language.smethod_1(label7);
		Language.smethod_1(FAB3EC81);
		Language.smethod_1(label10);
		Language.smethod_1(label9);
		Language.smethod_1(label12);
		Language.smethod_1(D629E3A8);
		Language.smethod_1(label14);
		Language.smethod_1(label13);
		Language.smethod_1(E38CD208);
		Language.smethod_1(C7AE9FB5);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void fHDXemWatch_Old_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = D6358527.method_0("nudSoLuongFrom");
			E316D937.Value = D6358527.method_0("nudSoLuongTo");
			nudTimeWatchFrom.Value = D6358527.method_0("nudTimeWatchFrom");
			nudTimeWatchTo.Value = D6358527.method_0("nudTimeWatchTo");
			ckbInteract.Checked = D6358527.AA824D29("ckbInteract");
			ckbComment.Checked = D6358527.AA824D29("ckbComment");
			ckbShareWall.Checked = D6358527.AA824D29("ckbShareWall");
			txtComment.Text = D6358527.GetValue("txtComment");
			nudCountLikeFrom.Value = D6358527.method_0("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = D6358527.method_0("nudCountLikeTo", 3);
			nudCountShareFrom.Value = D6358527.method_0("nudCountShareFrom", 1);
			A693A284.Value = D6358527.method_0("nudCountShareTo", 3);
			nudCountCommentFrom.Value = D6358527.method_0("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = D6358527.method_0("nudCountCommentTo", 3);
		}
		catch
		{
		}
		method_0();
	}

	private void CF113F3B_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = FBA31A30.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> f1808BA = txtComment.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", E316D937.Value);
		f72FAFBC.GetValue("nudTimeWatchFrom", nudTimeWatchFrom.Value);
		f72FAFBC.GetValue("nudTimeWatchTo", nudTimeWatchTo.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		f72FAFBC.GetValue("ckbShareWall", ckbShareWall.Checked);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		f72FAFBC.GetValue("nudCountLikeFrom", nudCountLikeFrom.Value);
		f72FAFBC.GetValue("nudCountLikeTo", nudCountLikeTo.Value);
		f72FAFBC.GetValue("nudCountShareFrom", nudCountShareFrom.Value);
		f72FAFBC.GetValue("nudCountShareTo", A693A284.Value);
		f72FAFBC.GetValue("nudCountCommentFrom", nudCountCommentFrom.Value);
		f72FAFBC.GetValue("nudCountCommentTo", nudCountCommentTo.Value);
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, d9253C2E))
				{
					B412D02F = true;
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
				B412D02F = true;
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

	private void A1BCF1A0(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void F3901323(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtComment.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			E38CD208.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_0()
	{
		AC290DAE(null, null);
		D603B828(null, null);
		B52C1805(null, null);
	}

	private void D603B828(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
		plCountComment.Enabled = ckbComment.Checked;
	}

	private void AC290DAE(object sender, EventArgs e)
	{
		A903DD20.Enabled = ckbInteract.Checked;
	}

	private void B52C1805(object sender, EventArgs e)
	{
		E5315007.Enabled = ckbShareWall.Checked;
	}

	private void CBAD14BC(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXemWatch_Old));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		CF113F3B = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plCountComment = new System.Windows.Forms.Panel();
		nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		label13 = new System.Windows.Forms.Label();
		label14 = new System.Windows.Forms.Label();
		nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		E5315007 = new System.Windows.Forms.Panel();
		nudCountShareFrom = new System.Windows.Forms.NumericUpDown();
		D629E3A8 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		A693A284 = new System.Windows.Forms.NumericUpDown();
		A903DD20 = new System.Windows.Forms.Panel();
		nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		plComment = new System.Windows.Forms.Panel();
		txtComment = new System.Windows.Forms.RichTextBox();
		C7AE9FB5 = new System.Windows.Forms.Label();
		E38CD208 = new System.Windows.Forms.Label();
		ckbComment = new System.Windows.Forms.CheckBox();
		ckbShareWall = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudTimeWatchTo = new System.Windows.Forms.NumericUpDown();
		E316D937 = new System.Windows.Forms.NumericUpDown();
		nudTimeWatchFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		FBA31A30 = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		D384FC33 = new System.Windows.Forms.Label();
		FAB3EC81 = new System.Windows.Forms.Label();
		C6B01D32 = new System.Windows.Forms.Label();
		FAA1AFB5 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plCountComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).BeginInit();
		E5315007.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)A693A284).BeginInit();
		A903DD20.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).BeginInit();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeWatchTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)E316D937).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeWatchFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
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
		bunifuCustomLabel1.Text = "Cấu hình Xem Watch";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(CF113F3B);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		CF113F3B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		CF113F3B.Cursor = System.Windows.Forms.Cursors.Hand;
		CF113F3B.FlatAppearance.BorderSize = 0;
		CF113F3B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CF113F3B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CF113F3B.ForeColor = System.Drawing.Color.White;
		CF113F3B.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		CF113F3B.Location = new System.Drawing.Point(328, 1);
		CF113F3B.Name = "button1";
		CF113F3B.Size = new System.Drawing.Size(30, 30);
		CF113F3B.TabIndex = 77;
		CF113F3B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		CF113F3B.UseVisualStyleBackColor = true;
		CF113F3B.Click += new System.EventHandler(CF113F3B_Click);
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
		panel1.Controls.Add(plCountComment);
		panel1.Controls.Add(E5315007);
		panel1.Controls.Add(A903DD20);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(ckbShareWall);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(nudTimeWatchTo);
		panel1.Controls.Add(E316D937);
		panel1.Controls.Add(nudTimeWatchFrom);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(FBA31A30);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(D384FC33);
		panel1.Controls.Add(FAB3EC81);
		panel1.Controls.Add(C6B01D32);
		panel1.Controls.Add(FAA1AFB5);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 436);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(A1BCF1A0);
		plCountComment.Controls.Add(nudCountCommentFrom);
		plCountComment.Controls.Add(label13);
		plCountComment.Controls.Add(label14);
		plCountComment.Controls.Add(nudCountCommentTo);
		plCountComment.Location = new System.Drawing.Point(132, 186);
		plCountComment.Name = "plCountComment";
		plCountComment.Size = new System.Drawing.Size(194, 25);
		plCountComment.TabIndex = 44;
		nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentFrom.Name = "nudCountCommentFrom";
		nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		nudCountCommentFrom.TabIndex = 1;
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(159, 3);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(25, 16);
		label13.TabIndex = 35;
		label13.Text = "lần";
		label14.Location = new System.Drawing.Point(63, 3);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(29, 16);
		label14.TabIndex = 37;
		label14.Text = "đê\u0301n";
		label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
		nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentTo.Name = "nudCountCommentTo";
		nudCountCommentTo.Size = new System.Drawing.Size(56, 23);
		nudCountCommentTo.TabIndex = 2;
		E5315007.Controls.Add(nudCountShareFrom);
		E5315007.Controls.Add(D629E3A8);
		E5315007.Controls.Add(label12);
		E5315007.Controls.Add(A693A284);
		E5315007.Location = new System.Drawing.Point(132, 158);
		E5315007.Name = "plCountShareWall";
		E5315007.Size = new System.Drawing.Size(194, 25);
		E5315007.TabIndex = 43;
		nudCountShareFrom.Location = new System.Drawing.Point(1, 1);
		nudCountShareFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountShareFrom.Name = "nudCountShareFrom";
		nudCountShareFrom.Size = new System.Drawing.Size(56, 23);
		nudCountShareFrom.TabIndex = 1;
		D629E3A8.AutoSize = true;
		D629E3A8.Location = new System.Drawing.Point(159, 3);
		D629E3A8.Name = "label11";
		D629E3A8.Size = new System.Drawing.Size(25, 16);
		D629E3A8.TabIndex = 35;
		D629E3A8.Text = "lần";
		label12.Location = new System.Drawing.Point(63, 3);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(29, 16);
		label12.TabIndex = 37;
		label12.Text = "đê\u0301n";
		label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A693A284.Location = new System.Drawing.Point(98, 1);
		A693A284.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A693A284.Name = "nudCountShareTo";
		A693A284.Size = new System.Drawing.Size(56, 23);
		A693A284.TabIndex = 2;
		A903DD20.Controls.Add(nudCountLikeFrom);
		A903DD20.Controls.Add(label9);
		A903DD20.Controls.Add(label10);
		A903DD20.Controls.Add(nudCountLikeTo);
		A903DD20.Location = new System.Drawing.Point(132, 130);
		A903DD20.Name = "plCountLike";
		A903DD20.Size = new System.Drawing.Size(194, 25);
		A903DD20.TabIndex = 42;
		nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeFrom.Name = "nudCountLikeFrom";
		nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		nudCountLikeFrom.TabIndex = 1;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(159, 3);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(25, 16);
		label9.TabIndex = 35;
		label9.Text = "lần";
		label10.Location = new System.Drawing.Point(63, 3);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(29, 16);
		label10.TabIndex = 37;
		label10.Text = "đê\u0301n";
		label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountLikeTo.Location = new System.Drawing.Point(98, 1);
		nudCountLikeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeTo.Name = "nudCountLikeTo";
		nudCountLikeTo.Size = new System.Drawing.Size(56, 23);
		nudCountLikeTo.TabIndex = 2;
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(C7AE9FB5);
		plComment.Controls.Add(E38CD208);
		plComment.Location = new System.Drawing.Point(48, 214);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(278, 164);
		plComment.TabIndex = 8;
		txtComment.Location = new System.Drawing.Point(6, 24);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(264, 114);
		txtComment.TabIndex = 45;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(F3901323);
		C7AE9FB5.AutoSize = true;
		C7AE9FB5.Location = new System.Drawing.Point(4, 141);
		C7AE9FB5.Name = "label8";
		C7AE9FB5.Size = new System.Drawing.Size(266, 16);
		C7AE9FB5.TabIndex = 0;
		C7AE9FB5.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		E38CD208.AutoSize = true;
		E38CD208.Location = new System.Drawing.Point(3, 5);
		E38CD208.Name = "lblStatus";
		E38CD208.Size = new System.Drawing.Size(140, 16);
		E38CD208.TabIndex = 0;
		E38CD208.Text = "Nội dung bình luận (0):";
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(30, 188);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(82, 20);
		ckbComment.TabIndex = 7;
		ckbComment.Text = "Comment";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(D603B828);
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareWall.Location = new System.Drawing.Point(30, 160);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new System.Drawing.Size(90, 20);
		ckbShareWall.TabIndex = 6;
		ckbShareWall.Text = "Share Wall";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbShareWall.CheckedChanged += new System.EventHandler(B52C1805);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 132);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(49, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Like";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(AC290DAE);
		nudTimeWatchTo.Location = new System.Drawing.Point(229, 103);
		nudTimeWatchTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeWatchTo.Name = "nudTimeWatchTo";
		nudTimeWatchTo.Size = new System.Drawing.Size(56, 23);
		nudTimeWatchTo.TabIndex = 4;
		E316D937.Location = new System.Drawing.Point(229, 76);
		E316D937.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E316D937.Name = "nudSoLuongTo";
		E316D937.Size = new System.Drawing.Size(56, 23);
		E316D937.TabIndex = 2;
		nudTimeWatchFrom.Location = new System.Drawing.Point(132, 103);
		nudTimeWatchFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeWatchFrom.Name = "nudTimeWatchFrom";
		nudTimeWatchFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeWatchFrom.TabIndex = 3;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 76);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		FBA31A30.Location = new System.Drawing.Point(132, 49);
		FBA31A30.Name = "txtTenHanhDong";
		FBA31A30.Size = new System.Drawing.Size(194, 23);
		FBA31A30.TabIndex = 0;
		label7.Location = new System.Drawing.Point(194, 105);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D384FC33.Location = new System.Drawing.Point(194, 78);
		D384FC33.Name = "label3";
		D384FC33.Size = new System.Drawing.Size(29, 16);
		D384FC33.TabIndex = 37;
		D384FC33.Text = "đê\u0301n";
		D384FC33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FAB3EC81.AutoSize = true;
		FAB3EC81.Location = new System.Drawing.Point(290, 105);
		FAB3EC81.Name = "label6";
		FAB3EC81.Size = new System.Drawing.Size(31, 16);
		FAB3EC81.TabIndex = 36;
		FAB3EC81.Text = "giây";
		C6B01D32.AutoSize = true;
		C6B01D32.Location = new System.Drawing.Point(290, 78);
		C6B01D32.Name = "label4";
		C6B01D32.Size = new System.Drawing.Size(38, 16);
		C6B01D32.TabIndex = 35;
		C6B01D32.Text = "video";
		FAA1AFB5.AutoSize = true;
		FAA1AFB5.Location = new System.Drawing.Point(27, 105);
		FAA1AFB5.Name = "label5";
		FAA1AFB5.Size = new System.Drawing.Size(94, 16);
		FAA1AFB5.TabIndex = 34;
		FAA1AFB5.Text = "Thơ\u0300i gian xem:";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 78);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(98, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng video:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 393);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 393);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
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
		base.ClientSize = new System.Drawing.Size(362, 436);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXemWatch_Old";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXemWatch_Old_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plCountComment.ResumeLayout(false);
		plCountComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).EndInit();
		E5315007.ResumeLayout(false);
		E5315007.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)A693A284).EndInit();
		A903DD20.ResumeLayout(false);
		A903DD20.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).EndInit();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeWatchTo).EndInit();
		((System.ComponentModel.ISupportInitialize)E316D937).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeWatchFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
