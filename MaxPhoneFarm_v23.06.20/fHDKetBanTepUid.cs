using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanTepUid : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string FB3EF198;

	internal string A0952D8E;

	internal string string_0;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer A8A75092 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel A63CCAA9;

	internal NumericUpDown EAA30B09;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox txtTenHanhDong;

	internal Label label3;

	internal Label label4;

	internal Label A38D0B16;

	internal Label label1;

	internal Button btnCancel;

	internal Button D7960AAA;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel F31CD1A3;

	internal Label label8;

	internal Label DB13F9BE;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudDelayFrom;

	internal Label D492E21B;

	internal Label B127CC3F;

	internal Label label5;

	internal RichTextBox EB81228F;

	internal CheckBox ckbTuDongXoaUid;

	internal ToolTip B68D3537;

	internal Panel AC966804;

	internal CheckBox C60BEA0C;

	internal Panel E3804C35;

	internal RichTextBox txtComment;

	internal Label F2112629;

	internal Label FDA0D8AF;

	internal CheckBox C79FDE2D;

	internal Panel A7AB011F;

	internal NumericUpDown AE391331;

	internal Label label13;

	internal Label label14;

	internal NumericUpDown nudCountCommentTo;

	internal Label label21;

	internal NumericUpDown nudTimeFrom;

	internal CheckBox ckbTuongTacLike;

	internal NumericUpDown E7A2A080;

	internal Label label18;

	internal Label label16;

	internal Panel E00F5D87;

	internal NumericUpDown nudCountLikeFrom;

	internal Label label10;

	internal Label label11;

	internal NumericUpDown nudCountLikeTo;

	public fHDKetBanTepUid(string string_1, int DE3FA987 = 0, string F9A551B7 = "")
	{
		InitializeComponent();
		bool_0 = false;
		FB3EF198 = string_1;
		string_0 = F9A551B7;
		int_0 = DE3FA987;
		string d399C = "";
		switch (DE3FA987)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDKetBanTepUid");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			A0952D8E = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(F9A551B7);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			D7960AAA.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(F31CD1A3);
		Language.smethod_1(label1);
		Language.smethod_1(A38D0B16);
		Language.smethod_1(label3);
		Language.smethod_1(label4);
		Language.smethod_1(label5);
		Language.smethod_1(D492E21B);
		Language.smethod_1(B127CC3F);
		Language.smethod_1(DB13F9BE);
		Language.smethod_1(label8);
		Language.smethod_1(ckbTuDongXoaUid);
		Language.smethod_1(C60BEA0C);
		Language.smethod_1(C79FDE2D);
		Language.smethod_1(FDA0D8AF);
		Language.smethod_1(F2112629);
		Language.smethod_1(D7960AAA);
		Language.smethod_1(btnCancel);
	}

	private void fHDKetBanTepUid_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom");
			EAA30B09.Value = f72FAFBC_0.method_0("nudSoLuongTo");
			nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom");
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo");
			ckbTuDongXoaUid.Checked = f72FAFBC_0.AA824D29("ckbKetBanTrungNhau");
			EB81228F.Text = f72FAFBC_0.GetValue("txtUid");
			C60BEA0C.Checked = f72FAFBC_0.AA824D29("ckbTuongTac");
			nudTimeFrom.Value = f72FAFBC_0.method_0("nudTimeFrom", 5);
			E7A2A080.Value = f72FAFBC_0.method_0("nudTimeTo", 10);
			nudCountLikeFrom.Value = f72FAFBC_0.method_0("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = f72FAFBC_0.method_0("nudCountLikeTo", 3);
			AE391331.Value = f72FAFBC_0.method_0("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = f72FAFBC_0.method_0("nudCountCommentTo", 3);
			ckbTuongTacLike.Checked = f72FAFBC_0.AA824D29("ckbTuongTacLike");
			C79FDE2D.Checked = f72FAFBC_0.AA824D29("ckbTuongTacComment");
			ckbTuDongXoaUid.Checked = f72FAFBC_0.AA824D29("ckbTuDongXoaUid");
			txtComment.Text = f72FAFBC_0.GetValue("txtComment");
		}
		catch
		{
		}
		B5B66591();
	}

	private void B5B66591()
	{
		C60BEA0C_CheckedChanged(null, null);
		ckbTuongTacLike_CheckedChanged(null, null);
		C79FDE2D_CheckedChanged(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D7960AAA_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> f1808BA = EB81228F.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sách uid cần kết bạn!"), 3);
			return;
		}
		if (C60BEA0C.Checked && C79FDE2D.Checked)
		{
			f1808BA = txtComment.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nội dung bình luận!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", EAA30B09.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("ckbKetBanTrungNhau", ckbTuDongXoaUid.Checked);
		f72FAFBC.GetValue("txtUid", (object)EB81228F.Text.Trim());
		f72FAFBC.GetValue("ckbTuongTac", C60BEA0C.Checked);
		f72FAFBC.GetValue("nudTimeFrom", nudTimeFrom.Value);
		f72FAFBC.GetValue("nudTimeTo", E7A2A080.Value);
		f72FAFBC.GetValue("nudCountLikeFrom", nudCountLikeFrom.Value);
		f72FAFBC.GetValue("nudCountLikeTo", nudCountLikeTo.Value);
		f72FAFBC.GetValue("nudCountCommentFrom", AE391331.Value);
		f72FAFBC.GetValue("nudCountCommentTo", nudCountCommentTo.Value);
		f72FAFBC.GetValue("ckbTuongTacLike", ckbTuongTacLike.Checked);
		f72FAFBC.GetValue("ckbTuongTacComment", C79FDE2D.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		f72FAFBC.GetValue("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(FB3EF198, text, A0952D8E, text2))
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
			if (Class123.smethod_14(string_0, text, text2))
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

	private void BFA1633F(object sender, EventArgs e)
	{
		Close();
	}

	private void B005C1A0(object sender, PaintEventArgs e)
	{
		if (A63CCAA9.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A63CCAA9.ClientSize.Width - num, A63CCAA9.ClientSize.Height - num));
		}
	}

	private void D2B86089(object sender, EventArgs e)
	{
	}

	private void EB81228F_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = EB81228F.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			DB13F9BE.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid cần kết bạn ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtComment.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			FDA0D8AF.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void C60BEA0C_CheckedChanged(object sender, EventArgs e)
	{
		AC966804.Enabled = C60BEA0C.Checked;
	}

	private void C79FDE2D_CheckedChanged(object sender, EventArgs e)
	{
		A7AB011F.Enabled = C79FDE2D.Checked;
		E3804C35.Enabled = C79FDE2D.Checked;
	}

	private void ckbTuongTacLike_CheckedChanged(object sender, EventArgs e)
	{
		E00F5D87.Enabled = ckbTuongTacLike.Checked;
	}

	protected override void Dispose(bool A589AD3B)
	{
		if (A589AD3B && A8A75092 != null)
		{
			A8A75092.Dispose();
		}
		base.Dispose(A589AD3B);
	}

	private void InitializeComponent()
	{
		A8A75092 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanTepUid));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(A8A75092);
		F31CD1A3 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(A8A75092);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		A63CCAA9 = new System.Windows.Forms.Panel();
		AC966804 = new System.Windows.Forms.Panel();
		E3804C35 = new System.Windows.Forms.Panel();
		txtComment = new System.Windows.Forms.RichTextBox();
		F2112629 = new System.Windows.Forms.Label();
		FDA0D8AF = new System.Windows.Forms.Label();
		C79FDE2D = new System.Windows.Forms.CheckBox();
		A7AB011F = new System.Windows.Forms.Panel();
		AE391331 = new System.Windows.Forms.NumericUpDown();
		label13 = new System.Windows.Forms.Label();
		label14 = new System.Windows.Forms.Label();
		nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		label21 = new System.Windows.Forms.Label();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		ckbTuongTacLike = new System.Windows.Forms.CheckBox();
		E7A2A080 = new System.Windows.Forms.NumericUpDown();
		label18 = new System.Windows.Forms.Label();
		label16 = new System.Windows.Forms.Label();
		E00F5D87 = new System.Windows.Forms.Panel();
		nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		label10 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		C60BEA0C = new System.Windows.Forms.CheckBox();
		EB81228F = new System.Windows.Forms.RichTextBox();
		ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		DB13F9BE = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		D492E21B = new System.Windows.Forms.Label();
		B127CC3F = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		EAA30B09 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		A38D0B16 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		D7960AAA = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		B68D3537 = new System.Windows.Forms.ToolTip(A8A75092);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		A63CCAA9.SuspendLayout();
		AC966804.SuspendLayout();
		E3804C35.SuspendLayout();
		A7AB011F.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)AE391331).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)E7A2A080).BeginInit();
		E00F5D87.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)EAA30B09).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = F31CD1A3;
		bunifuDragControl_0.Vertical = true;
		F31CD1A3.BackColor = System.Drawing.Color.Transparent;
		F31CD1A3.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F31CD1A3.Dock = System.Windows.Forms.DockStyle.Fill;
		F31CD1A3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F31CD1A3.ForeColor = System.Drawing.Color.Black;
		F31CD1A3.Location = new System.Drawing.Point(0, 0);
		F31CD1A3.Name = "bunifuCustomLabel1";
		F31CD1A3.Size = new System.Drawing.Size(687, 31);
		F31CD1A3.TabIndex = 12;
		F31CD1A3.Text = "Cấu hình Kết bạn theo tệp UID";
		F31CD1A3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(F31CD1A3);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(687, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(656, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		A63CCAA9.BackColor = System.Drawing.Color.White;
		A63CCAA9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A63CCAA9.Controls.Add(AC966804);
		A63CCAA9.Controls.Add(C60BEA0C);
		A63CCAA9.Controls.Add(EB81228F);
		A63CCAA9.Controls.Add(ckbTuDongXoaUid);
		A63CCAA9.Controls.Add(nudDelayTo);
		A63CCAA9.Controls.Add(label8);
		A63CCAA9.Controls.Add(DB13F9BE);
		A63CCAA9.Controls.Add(nudDelayFrom);
		A63CCAA9.Controls.Add(D492E21B);
		A63CCAA9.Controls.Add(B127CC3F);
		A63CCAA9.Controls.Add(label5);
		A63CCAA9.Controls.Add(EAA30B09);
		A63CCAA9.Controls.Add(nudSoLuongFrom);
		A63CCAA9.Controls.Add(txtTenHanhDong);
		A63CCAA9.Controls.Add(label3);
		A63CCAA9.Controls.Add(label4);
		A63CCAA9.Controls.Add(A38D0B16);
		A63CCAA9.Controls.Add(label1);
		A63CCAA9.Controls.Add(btnCancel);
		A63CCAA9.Controls.Add(D7960AAA);
		A63CCAA9.Controls.Add(bunifuCards1);
		A63CCAA9.Cursor = System.Windows.Forms.Cursors.Arrow;
		A63CCAA9.Dock = System.Windows.Forms.DockStyle.Fill;
		A63CCAA9.Location = new System.Drawing.Point(0, 0);
		A63CCAA9.Name = "panel1";
		A63CCAA9.Size = new System.Drawing.Size(690, 406);
		A63CCAA9.TabIndex = 0;
		A63CCAA9.Paint += new System.Windows.Forms.PaintEventHandler(B005C1A0);
		AC966804.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		AC966804.Controls.Add(E3804C35);
		AC966804.Controls.Add(C79FDE2D);
		AC966804.Controls.Add(A7AB011F);
		AC966804.Controls.Add(label21);
		AC966804.Controls.Add(nudTimeFrom);
		AC966804.Controls.Add(ckbTuongTacLike);
		AC966804.Controls.Add(E7A2A080);
		AC966804.Controls.Add(label18);
		AC966804.Controls.Add(label16);
		AC966804.Controls.Add(E00F5D87);
		AC966804.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		AC966804.Location = new System.Drawing.Point(360, 74);
		AC966804.Name = "plTuongTac";
		AC966804.Size = new System.Drawing.Size(310, 272);
		AC966804.TabIndex = 116;
		E3804C35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E3804C35.Controls.Add(txtComment);
		E3804C35.Controls.Add(F2112629);
		E3804C35.Controls.Add(FDA0D8AF);
		E3804C35.Location = new System.Drawing.Point(24, 94);
		E3804C35.Name = "plTuongTacComment";
		E3804C35.Size = new System.Drawing.Size(278, 169);
		E3804C35.TabIndex = 135;
		txtComment.Location = new System.Drawing.Point(6, 24);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(266, 120);
		txtComment.TabIndex = 107;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		F2112629.AutoSize = true;
		F2112629.Location = new System.Drawing.Point(2, 147);
		F2112629.Name = "label9";
		F2112629.Size = new System.Drawing.Size(266, 16);
		F2112629.TabIndex = 0;
		F2112629.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		FDA0D8AF.AutoSize = true;
		FDA0D8AF.Location = new System.Drawing.Point(3, 5);
		FDA0D8AF.Name = "lblStatusComment";
		FDA0D8AF.Size = new System.Drawing.Size(140, 16);
		FDA0D8AF.TabIndex = 0;
		FDA0D8AF.Text = "Nội dung bình luận (0):";
		C79FDE2D.AutoSize = true;
		C79FDE2D.Cursor = System.Windows.Forms.Cursors.Hand;
		C79FDE2D.Location = new System.Drawing.Point(6, 65);
		C79FDE2D.Name = "ckbTuongTacComment";
		C79FDE2D.Size = new System.Drawing.Size(82, 20);
		C79FDE2D.TabIndex = 133;
		C79FDE2D.Text = "Comment";
		C79FDE2D.UseVisualStyleBackColor = true;
		C79FDE2D.CheckedChanged += new System.EventHandler(C79FDE2D_CheckedChanged);
		A7AB011F.Controls.Add(AE391331);
		A7AB011F.Controls.Add(label13);
		A7AB011F.Controls.Add(label14);
		A7AB011F.Controls.Add(nudCountCommentTo);
		A7AB011F.Location = new System.Drawing.Point(113, 64);
		A7AB011F.Name = "plCountComment";
		A7AB011F.Size = new System.Drawing.Size(189, 25);
		A7AB011F.TabIndex = 134;
		AE391331.Location = new System.Drawing.Point(1, 1);
		AE391331.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AE391331.Name = "nudCountCommentFrom";
		AE391331.Size = new System.Drawing.Size(56, 23);
		AE391331.TabIndex = 1;
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(157, 3);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(30, 16);
		label13.TabIndex = 35;
		label13.Text = "lươ\u0323t";
		label14.AutoSize = true;
		label14.Location = new System.Drawing.Point(63, 3);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(29, 16);
		label14.TabIndex = 37;
		label14.Text = "đê\u0301n";
		nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
		nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentTo.Name = "nudCountCommentTo";
		nudCountCommentTo.Size = new System.Drawing.Size(56, 23);
		nudCountCommentTo.TabIndex = 2;
		label21.AutoSize = true;
		label21.Location = new System.Drawing.Point(3, 7);
		label21.Name = "label21";
		label21.Size = new System.Drawing.Size(92, 16);
		label21.TabIndex = 129;
		label21.Text = "Thơ\u0300i gian lươ\u0301t:";
		nudTimeFrom.Location = new System.Drawing.Point(114, 5);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 127;
		ckbTuongTacLike.AutoSize = true;
		ckbTuongTacLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuongTacLike.Location = new System.Drawing.Point(6, 35);
		ckbTuongTacLike.Name = "ckbTuongTacLike";
		ckbTuongTacLike.Size = new System.Drawing.Size(49, 20);
		ckbTuongTacLike.TabIndex = 126;
		ckbTuongTacLike.Text = "Like";
		ckbTuongTacLike.UseVisualStyleBackColor = true;
		ckbTuongTacLike.CheckedChanged += new System.EventHandler(ckbTuongTacLike_CheckedChanged);
		E7A2A080.Location = new System.Drawing.Point(211, 5);
		E7A2A080.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E7A2A080.Name = "nudTimeTo";
		E7A2A080.Size = new System.Drawing.Size(56, 23);
		E7A2A080.TabIndex = 128;
		label18.AutoSize = true;
		label18.Location = new System.Drawing.Point(272, 7);
		label18.Name = "label18";
		label18.Size = new System.Drawing.Size(31, 16);
		label18.TabIndex = 130;
		label18.Text = "giây";
		label16.AutoSize = true;
		label16.Location = new System.Drawing.Point(176, 7);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(29, 16);
		label16.TabIndex = 131;
		label16.Text = "đê\u0301n";
		E00F5D87.Controls.Add(nudCountLikeFrom);
		E00F5D87.Controls.Add(label10);
		E00F5D87.Controls.Add(label11);
		E00F5D87.Controls.Add(nudCountLikeTo);
		E00F5D87.Location = new System.Drawing.Point(113, 33);
		E00F5D87.Name = "plCountLike";
		E00F5D87.Size = new System.Drawing.Size(189, 25);
		E00F5D87.TabIndex = 132;
		nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeFrom.Name = "nudCountLikeFrom";
		nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		nudCountLikeFrom.TabIndex = 1;
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(157, 3);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(30, 16);
		label10.TabIndex = 35;
		label10.Text = "lươ\u0323t";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(63, 3);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(29, 16);
		label11.TabIndex = 37;
		label11.Text = "đê\u0301n";
		nudCountLikeTo.Location = new System.Drawing.Point(98, 1);
		nudCountLikeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeTo.Name = "nudCountLikeTo";
		nudCountLikeTo.Size = new System.Drawing.Size(56, 23);
		nudCountLikeTo.TabIndex = 2;
		C60BEA0C.AutoSize = true;
		C60BEA0C.Cursor = System.Windows.Forms.Cursors.Hand;
		C60BEA0C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C60BEA0C.Location = new System.Drawing.Point(342, 51);
		C60BEA0C.Name = "ckbTuongTac";
		C60BEA0C.Size = new System.Drawing.Size(185, 20);
		C60BEA0C.TabIndex = 115;
		C60BEA0C.Text = "Tương tác trước khi kết bạn";
		C60BEA0C.UseVisualStyleBackColor = true;
		C60BEA0C.CheckedChanged += new System.EventHandler(C60BEA0C_CheckedChanged);
		EB81228F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EB81228F.Location = new System.Drawing.Point(24, 163);
		EB81228F.Name = "txtUid";
		EB81228F.Size = new System.Drawing.Size(295, 141);
		EB81228F.TabIndex = 114;
		EB81228F.Text = "";
		EB81228F.WordWrap = false;
		EB81228F.TextChanged += new System.EventHandler(EB81228F_TextChanged);
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaUid.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongXoaUid.Location = new System.Drawing.Point(23, 326);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new System.Drawing.Size(249, 20);
		ckbTuDongXoaUid.TabIndex = 113;
		ckbTuDongXoaUid.Text = "Tư\u0323 đô\u0323ng xo\u0301a Uid đa\u0303 gư\u0309i lơ\u0300i mơ\u0300i kê\u0301t ba\u0323n";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new System.Drawing.Point(222, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(220, 307);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(103, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi Uid 1 dòng)";
		DB13F9BE.AutoSize = true;
		DB13F9BE.Location = new System.Drawing.Point(20, 141);
		DB13F9BE.Name = "lblStatus";
		DB13F9BE.Size = new System.Drawing.Size(185, 16);
		DB13F9BE.TabIndex = 0;
		DB13F9BE.Text = "Danh sa\u0301ch Uid cần kết bạn (0):";
		nudDelayFrom.Location = new System.Drawing.Point(125, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		D492E21B.Location = new System.Drawing.Point(187, 113);
		D492E21B.Name = "label7";
		D492E21B.Size = new System.Drawing.Size(29, 16);
		D492E21B.TabIndex = 46;
		D492E21B.Text = "đê\u0301n";
		D492E21B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B127CC3F.AutoSize = true;
		B127CC3F.Location = new System.Drawing.Point(280, 113);
		B127CC3F.Name = "label6";
		B127CC3F.Size = new System.Drawing.Size(31, 16);
		B127CC3F.TabIndex = 45;
		B127CC3F.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(20, 113);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(90, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		EAA30B09.Location = new System.Drawing.Point(222, 80);
		EAA30B09.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		EAA30B09.Name = "nudSoLuongTo";
		EAA30B09.Size = new System.Drawing.Size(56, 23);
		EAA30B09.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(125, 80);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.Location = new System.Drawing.Point(187, 82);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(280, 82);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		A38D0B16.AutoSize = true;
		A38D0B16.Location = new System.Drawing.Point(20, 82);
		A38D0B16.Name = "label2";
		A38D0B16.Size = new System.Drawing.Size(89, 16);
		A38D0B16.TabIndex = 32;
		A38D0B16.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(20, 52);
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
		btnCancel.Location = new System.Drawing.Point(355, 362);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(BFA1633F);
		D7960AAA.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		D7960AAA.Cursor = System.Windows.Forms.Cursors.Hand;
		D7960AAA.FlatAppearance.BorderSize = 0;
		D7960AAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D7960AAA.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D7960AAA.ForeColor = System.Drawing.Color.White;
		D7960AAA.Location = new System.Drawing.Point(248, 362);
		D7960AAA.Name = "btnAdd";
		D7960AAA.Size = new System.Drawing.Size(92, 29);
		D7960AAA.TabIndex = 6;
		D7960AAA.Text = "Thêm";
		D7960AAA.UseVisualStyleBackColor = false;
		D7960AAA.Click += new System.EventHandler(D7960AAA_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(687, 37);
		bunifuCards1.TabIndex = 28;
		B68D3537.AutomaticDelay = 0;
		B68D3537.AutoPopDelay = 0;
		B68D3537.InitialDelay = 0;
		B68D3537.ReshowDelay = 0;
		B68D3537.ShowAlways = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(690, 406);
		base.Controls.Add(A63CCAA9);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanTepUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanTepUid_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		A63CCAA9.ResumeLayout(false);
		A63CCAA9.PerformLayout();
		AC966804.ResumeLayout(false);
		AC966804.PerformLayout();
		E3804C35.ResumeLayout(false);
		E3804C35.PerformLayout();
		A7AB011F.ResumeLayout(false);
		A7AB011F.PerformLayout();
		((System.ComponentModel.ISupportInitialize)AE391331).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)E7A2A080).EndInit();
		E00F5D87.ResumeLayout(false);
		E00F5D87.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)EAA30B09).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
