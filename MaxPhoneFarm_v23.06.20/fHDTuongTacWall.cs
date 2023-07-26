using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacWall : Form
{
	internal JSON_Settings F2116907 = null;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl F21B288C;

	internal Panel panel1;

	internal NumericUpDown nudTimeTo;

	internal NumericUpDown nudTimeFrom;

	internal TextBox txtTenHanhDong;

	internal Label ED01C6B5;

	internal Label label4;

	internal Label label2;

	internal Label EBB6D734;

	internal Button F815F62F;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button ACAAAE0C;

	internal PictureBox D72C322E;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal CheckBox D6BA7827;

	internal CheckBox ckbInteract;

	internal CheckBox E29FC911;

	internal Panel E592CC2C;

	internal NumericUpDown nudCountCommentFrom;

	internal Label D6A51FB4;

	internal Label B82FB828;

	internal NumericUpDown nudCountCommentTo;

	internal Panel plCountShareWall;

	internal NumericUpDown nudCountShareFrom;

	internal Label label11;

	internal Label label12;

	internal NumericUpDown C40917A4;

	internal Panel plCountLike;

	internal NumericUpDown F6B8E211;

	internal Label label9;

	internal Label label10;

	internal NumericUpDown nudCountLikeTo;

	internal Panel ABA18338;

	internal RichTextBox txtComment;

	internal Button C4BE4289;

	internal Button BBBCDA96;

	internal Label label8;

	internal Label EE24C4BA;

	internal Label lblStatus;

	internal Button FA8BFE3C;

	internal Button button2;

	internal RadioButton E92EBCBE;

	internal RadioButton E908A434;

	public fHDTuongTacWall(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDTuongTacWall").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacWall', 'Tương tác Wall');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDTuongTacWall");
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
		F2116907 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void B7AF8692()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(EBB6D734);
		Language.smethod_1(label2);
		Language.smethod_1(ED01C6B5);
		Language.smethod_1(label4);
		Language.smethod_1(label10);
		Language.smethod_1(label9);
		Language.smethod_1(label12);
		Language.smethod_1(label11);
		Language.smethod_1(B82FB828);
		Language.smethod_1(D6A51FB4);
		Language.smethod_1(lblStatus);
		Language.smethod_1(EE24C4BA);
		Language.smethod_1(btnAdd);
		Language.smethod_1(F815F62F);
		Language.smethod_1(ckbInteract);
	}

	private void CE9CA594(object sender, EventArgs e)
	{
		try
		{
			nudTimeFrom.Value = F2116907.method_0("nudTimeFrom", 10);
			nudTimeTo.Value = F2116907.method_0("nudTimeTo", 30);
			F6B8E211.Value = F2116907.method_0("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = F2116907.method_0("nudCountLikeTo", 3);
			nudCountShareFrom.Value = F2116907.method_0("nudCountShareFrom", 1);
			C40917A4.Value = F2116907.method_0("nudCountShareTo", 3);
			nudCountCommentFrom.Value = F2116907.method_0("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = F2116907.method_0("nudCountCommentTo", 3);
			ckbInteract.Checked = F2116907.AA824D29("ckbInteract");
			E29FC911.Checked = F2116907.AA824D29("ckbShareWall");
			D6BA7827.Checked = F2116907.AA824D29("ckbComment");
			txtComment.Text = F2116907.GetValue("txtComment");
			if (F2116907.method_0("typeNganCach") == 1)
			{
				E92EBCBE.Checked = true;
			}
			else
			{
				E908A434.Checked = true;
			}
		}
		catch
		{
		}
		method_1();
	}

	private void ACAAAE0C_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (D6BA7827.Checked)
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
		f72FAFBC.GetValue("nudTimeFrom", nudTimeFrom.Value);
		f72FAFBC.GetValue("nudTimeTo", nudTimeTo.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		f72FAFBC.GetValue("ckbShareWall", E29FC911.Checked);
		f72FAFBC.GetValue("ckbComment", D6BA7827.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		f72FAFBC.GetValue("nudCountLikeFrom", F6B8E211.Value);
		f72FAFBC.GetValue("nudCountLikeTo", nudCountLikeTo.Value);
		f72FAFBC.GetValue("nudCountShareFrom", nudCountShareFrom.Value);
		f72FAFBC.GetValue("nudCountShareTo", C40917A4.Value);
		f72FAFBC.GetValue("nudCountCommentFrom", nudCountCommentFrom.Value);
		f72FAFBC.GetValue("nudCountCommentTo", nudCountCommentTo.Value);
		int num = 0;
		if (E92EBCBE.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
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

	private void F815F62F_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BDB9BAA4(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!E908A434.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		CD95CFB2(null, null);
		D6BA7827_CheckedChanged(null, null);
		E29FC911_CheckedChanged(null, null);
	}

	private void CD95CFB2(object sender, EventArgs e)
	{
		plCountLike.Enabled = ckbInteract.Checked;
	}

	private void D6BA7827_CheckedChanged(object sender, EventArgs e)
	{
		E592CC2C.Enabled = D6BA7827.Checked;
		ABA18338.Enabled = D6BA7827.Checked;
	}

	private void E29FC911_CheckedChanged(object sender, EventArgs e)
	{
		plCountShareWall.Enabled = E29FC911.Checked;
	}

	private void B5277A8C(object sender, EventArgs e)
	{
		ABA18338.Height = 207;
	}

	private void BBBCDA96_Click(object sender, EventArgs e)
	{
		ABA18338.Height = 163;
	}

	private void D72C322E_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			BBBCDA96.Visible = true;
			C4BE4289.Visible = true;
		}
	}

	private void D4131936(object sender, EventArgs e)
	{
		method_0();
	}

	private void C21E4536(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_2(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	private void C0236BA5(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacWall));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		F21B288C = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		ACAAAE0C = new System.Windows.Forms.Button();
		D72C322E = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		ABA18338 = new System.Windows.Forms.Panel();
		FA8BFE3C = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		E92EBCBE = new System.Windows.Forms.RadioButton();
		E908A434 = new System.Windows.Forms.RadioButton();
		txtComment = new System.Windows.Forms.RichTextBox();
		C4BE4289 = new System.Windows.Forms.Button();
		BBBCDA96 = new System.Windows.Forms.Button();
		label8 = new System.Windows.Forms.Label();
		EE24C4BA = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		E592CC2C = new System.Windows.Forms.Panel();
		nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		D6A51FB4 = new System.Windows.Forms.Label();
		B82FB828 = new System.Windows.Forms.Label();
		nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		plCountShareWall = new System.Windows.Forms.Panel();
		nudCountShareFrom = new System.Windows.Forms.NumericUpDown();
		label11 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		C40917A4 = new System.Windows.Forms.NumericUpDown();
		plCountLike = new System.Windows.Forms.Panel();
		F6B8E211 = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		D6BA7827 = new System.Windows.Forms.CheckBox();
		E29FC911 = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudTimeTo = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		ED01C6B5 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		EBB6D734 = new System.Windows.Forms.Label();
		F815F62F = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D72C322E).BeginInit();
		panel1.SuspendLayout();
		ABA18338.SuspendLayout();
		E592CC2C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).BeginInit();
		plCountShareWall.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)C40917A4).BeginInit();
		plCountLike.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F6B8E211).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
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
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Wall";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F21B288C.Fixed = true;
		F21B288C.Horizontal = true;
		F21B288C.TargetControl = pnlHeader;
		F21B288C.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(ACAAAE0C);
		pnlHeader.Controls.Add(D72C322E);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		ACAAAE0C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		ACAAAE0C.Cursor = System.Windows.Forms.Cursors.Hand;
		ACAAAE0C.FlatAppearance.BorderSize = 0;
		ACAAAE0C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		ACAAAE0C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ACAAAE0C.ForeColor = System.Drawing.Color.White;
		ACAAAE0C.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		ACAAAE0C.Location = new System.Drawing.Point(328, 1);
		ACAAAE0C.Name = "button1";
		ACAAAE0C.Size = new System.Drawing.Size(30, 30);
		ACAAAE0C.TabIndex = 77;
		ACAAAE0C.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		ACAAAE0C.UseVisualStyleBackColor = true;
		ACAAAE0C.Click += new System.EventHandler(ACAAAE0C_Click);
		D72C322E.Cursor = System.Windows.Forms.Cursors.Default;
		D72C322E.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		D72C322E.Location = new System.Drawing.Point(3, 2);
		D72C322E.Name = "pictureBox1";
		D72C322E.Size = new System.Drawing.Size(34, 27);
		D72C322E.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		D72C322E.TabIndex = 76;
		D72C322E.TabStop = false;
		D72C322E.Click += new System.EventHandler(D72C322E_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(ABA18338);
		panel1.Controls.Add(E592CC2C);
		panel1.Controls.Add(plCountShareWall);
		panel1.Controls.Add(plCountLike);
		panel1.Controls.Add(D6BA7827);
		panel1.Controls.Add(E29FC911);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(nudTimeTo);
		panel1.Controls.Add(nudTimeFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(ED01C6B5);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(EBB6D734);
		panel1.Controls.Add(F815F62F);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 415);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(BDB9BAA4);
		ABA18338.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ABA18338.Controls.Add(FA8BFE3C);
		ABA18338.Controls.Add(button2);
		ABA18338.Controls.Add(E92EBCBE);
		ABA18338.Controls.Add(E908A434);
		ABA18338.Controls.Add(txtComment);
		ABA18338.Controls.Add(C4BE4289);
		ABA18338.Controls.Add(BBBCDA96);
		ABA18338.Controls.Add(label8);
		ABA18338.Controls.Add(EE24C4BA);
		ABA18338.Controls.Add(lblStatus);
		ABA18338.Location = new System.Drawing.Point(50, 192);
		ABA18338.Name = "plComment";
		ABA18338.Size = new System.Drawing.Size(281, 163);
		ABA18338.TabIndex = 42;
		FA8BFE3C.Cursor = System.Windows.Forms.Cursors.Help;
		FA8BFE3C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FA8BFE3C.Location = new System.Drawing.Point(224, 183);
		FA8BFE3C.Name = "button3";
		FA8BFE3C.Size = new System.Drawing.Size(21, 23);
		FA8BFE3C.TabIndex = 111;
		FA8BFE3C.Text = "?";
		FA8BFE3C.UseVisualStyleBackColor = true;
		FA8BFE3C.Click += new System.EventHandler(C0236BA5);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(224, 160);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 23);
		button2.TabIndex = 112;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		E92EBCBE.AutoSize = true;
		E92EBCBE.Cursor = System.Windows.Forms.Cursors.Hand;
		E92EBCBE.Location = new System.Drawing.Point(69, 181);
		E92EBCBE.Name = "rbNganCachKyTu";
		E92EBCBE.Size = new System.Drawing.Size(159, 20);
		E92EBCBE.TabIndex = 110;
		E92EBCBE.Text = "Nội dung có nhiều dòng";
		E92EBCBE.UseVisualStyleBackColor = true;
		E908A434.AutoSize = true;
		E908A434.Checked = true;
		E908A434.Cursor = System.Windows.Forms.Cursors.Hand;
		E908A434.Location = new System.Drawing.Point(69, 160);
		E908A434.Name = "rbNganCachMoiDong";
		E908A434.Size = new System.Drawing.Size(155, 20);
		E908A434.TabIndex = 109;
		E908A434.TabStop = true;
		E908A434.Text = "Nội dung chỉ có 1 dòng";
		E908A434.UseVisualStyleBackColor = true;
		txtComment.Location = new System.Drawing.Point(7, 27);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(266, 111);
		txtComment.TabIndex = 106;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		C4BE4289.BackgroundImage = Resource.Bitmap_91;
		C4BE4289.Cursor = System.Windows.Forms.Cursors.Hand;
		C4BE4289.Location = new System.Drawing.Point(224, -1);
		C4BE4289.Name = "btnDown";
		C4BE4289.Size = new System.Drawing.Size(25, 25);
		C4BE4289.TabIndex = 7;
		C4BE4289.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		C4BE4289.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C4BE4289.Visible = false;
		C4BE4289.Click += new System.EventHandler(B5277A8C);
		BBBCDA96.BackgroundImage = Resource.Bitmap_73;
		BBBCDA96.Cursor = System.Windows.Forms.Cursors.Hand;
		BBBCDA96.Location = new System.Drawing.Point(255, -1);
		BBBCDA96.Name = "btnUp";
		BBBCDA96.Size = new System.Drawing.Size(25, 25);
		BBBCDA96.TabIndex = 7;
		BBBCDA96.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		BBBCDA96.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BBBCDA96.Visible = false;
		BBBCDA96.Click += new System.EventHandler(BBBCDA96_Click);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 161);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(64, 16);
		label8.TabIndex = 4;
		label8.Text = "Tùy chọn:";
		EE24C4BA.AutoSize = true;
		EE24C4BA.Location = new System.Drawing.Point(4, 141);
		EE24C4BA.Name = "label15";
		EE24C4BA.Size = new System.Drawing.Size(265, 16);
		EE24C4BA.TabIndex = 0;
		EE24C4BA.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		E592CC2C.Controls.Add(nudCountCommentFrom);
		E592CC2C.Controls.Add(D6A51FB4);
		E592CC2C.Controls.Add(B82FB828);
		E592CC2C.Controls.Add(nudCountCommentTo);
		E592CC2C.Location = new System.Drawing.Point(136, 163);
		E592CC2C.Name = "plCountComment";
		E592CC2C.Size = new System.Drawing.Size(195, 25);
		E592CC2C.TabIndex = 41;
		nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentFrom.Name = "nudCountCommentFrom";
		nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		nudCountCommentFrom.TabIndex = 1;
		D6A51FB4.AutoSize = true;
		D6A51FB4.Location = new System.Drawing.Point(157, 3);
		D6A51FB4.Name = "label13";
		D6A51FB4.Size = new System.Drawing.Size(24, 16);
		D6A51FB4.TabIndex = 35;
		D6A51FB4.Text = "lần";
		B82FB828.Location = new System.Drawing.Point(63, 3);
		B82FB828.Name = "label14";
		B82FB828.Size = new System.Drawing.Size(29, 16);
		B82FB828.TabIndex = 37;
		B82FB828.Text = "đê\u0301n";
		B82FB828.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
		nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentTo.Name = "nudCountCommentTo";
		nudCountCommentTo.Size = new System.Drawing.Size(56, 23);
		nudCountCommentTo.TabIndex = 2;
		plCountShareWall.Controls.Add(nudCountShareFrom);
		plCountShareWall.Controls.Add(label11);
		plCountShareWall.Controls.Add(label12);
		plCountShareWall.Controls.Add(C40917A4);
		plCountShareWall.Location = new System.Drawing.Point(136, 134);
		plCountShareWall.Name = "plCountShareWall";
		plCountShareWall.Size = new System.Drawing.Size(195, 25);
		plCountShareWall.TabIndex = 40;
		nudCountShareFrom.Location = new System.Drawing.Point(1, 1);
		nudCountShareFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountShareFrom.Name = "nudCountShareFrom";
		nudCountShareFrom.Size = new System.Drawing.Size(56, 23);
		nudCountShareFrom.TabIndex = 1;
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(157, 3);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(24, 16);
		label11.TabIndex = 35;
		label11.Text = "lần";
		label12.Location = new System.Drawing.Point(63, 3);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(29, 16);
		label12.TabIndex = 37;
		label12.Text = "đê\u0301n";
		label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C40917A4.Location = new System.Drawing.Point(98, 1);
		C40917A4.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C40917A4.Name = "nudCountShareTo";
		C40917A4.Size = new System.Drawing.Size(56, 23);
		C40917A4.TabIndex = 2;
		plCountLike.Controls.Add(F6B8E211);
		plCountLike.Controls.Add(label9);
		plCountLike.Controls.Add(label10);
		plCountLike.Controls.Add(nudCountLikeTo);
		plCountLike.Location = new System.Drawing.Point(136, 105);
		plCountLike.Name = "plCountLike";
		plCountLike.Size = new System.Drawing.Size(195, 25);
		plCountLike.TabIndex = 39;
		F6B8E211.Location = new System.Drawing.Point(1, 1);
		F6B8E211.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F6B8E211.Name = "nudCountLikeFrom";
		F6B8E211.Size = new System.Drawing.Size(56, 23);
		F6B8E211.TabIndex = 1;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(157, 3);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(24, 16);
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
		D6BA7827.AutoSize = true;
		D6BA7827.Cursor = System.Windows.Forms.Cursors.Hand;
		D6BA7827.Location = new System.Drawing.Point(30, 165);
		D6BA7827.Name = "ckbComment";
		D6BA7827.Size = new System.Drawing.Size(81, 20);
		D6BA7827.TabIndex = 7;
		D6BA7827.Text = "Comment";
		D6BA7827.UseVisualStyleBackColor = true;
		D6BA7827.CheckedChanged += new System.EventHandler(D6BA7827_CheckedChanged);
		E29FC911.AutoSize = true;
		E29FC911.Cursor = System.Windows.Forms.Cursors.Hand;
		E29FC911.Location = new System.Drawing.Point(30, 136);
		E29FC911.Name = "ckbShareWall";
		E29FC911.Size = new System.Drawing.Size(89, 20);
		E29FC911.TabIndex = 6;
		E29FC911.Text = "Share Wall";
		E29FC911.UseVisualStyleBackColor = true;
		E29FC911.CheckedChanged += new System.EventHandler(E29FC911_CheckedChanged);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 107);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(75, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Cảm xúc";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(CD95CFB2);
		nudTimeTo.Location = new System.Drawing.Point(234, 77);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new System.Drawing.Size(56, 23);
		nudTimeTo.TabIndex = 2;
		nudTimeFrom.Location = new System.Drawing.Point(137, 77);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(137, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		ED01C6B5.Location = new System.Drawing.Point(199, 79);
		ED01C6B5.Name = "label3";
		ED01C6B5.Size = new System.Drawing.Size(29, 16);
		ED01C6B5.TabIndex = 37;
		ED01C6B5.Text = "đê\u0301n";
		ED01C6B5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(292, 79);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(30, 16);
		label4.TabIndex = 35;
		label4.Text = "giây";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 79);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(91, 16);
		label2.TabIndex = 32;
		label2.Text = "Thơ\u0300i gian lươ\u0301t:";
		EBB6D734.AutoSize = true;
		EBB6D734.Location = new System.Drawing.Point(27, 52);
		EBB6D734.Name = "label1";
		EBB6D734.Size = new System.Drawing.Size(98, 16);
		EBB6D734.TabIndex = 31;
		EBB6D734.Text = "Tên ha\u0300nh đô\u0323ng:";
		F815F62F.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F815F62F.BackColor = System.Drawing.Color.Maroon;
		F815F62F.Cursor = System.Windows.Forms.Cursors.Hand;
		F815F62F.FlatAppearance.BorderSize = 0;
		F815F62F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F815F62F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F815F62F.ForeColor = System.Drawing.Color.White;
		F815F62F.Location = new System.Drawing.Point(189, 371);
		F815F62F.Name = "btnCancel";
		F815F62F.Size = new System.Drawing.Size(92, 29);
		F815F62F.TabIndex = 10;
		F815F62F.Text = "Đóng";
		F815F62F.UseVisualStyleBackColor = false;
		F815F62F.Click += new System.EventHandler(F815F62F_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 371);
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
		base.ClientSize = new System.Drawing.Size(362, 415);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacWall";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(CE9CA594);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)D72C322E).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		ABA18338.ResumeLayout(false);
		ABA18338.PerformLayout();
		E592CC2C.ResumeLayout(false);
		E592CC2C.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).EndInit();
		plCountShareWall.ResumeLayout(false);
		plCountShareWall.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)C40917A4).EndInit();
		plCountLike.ResumeLayout(false);
		plCountLike.PerformLayout();
		((System.ComponentModel.ISupportInitialize)F6B8E211).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
