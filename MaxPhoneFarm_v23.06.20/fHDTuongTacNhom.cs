using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacNhom : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string AFA8DFBB;

	internal int AA13450A;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl F09EF79C;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal TextBox CE9D22B5;

	internal Label label1;

	internal Button F3284AA1;

	internal Button D9A4FAB1;

	internal BunifuCards A93776B7;

	internal Panel ABA2CC21;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label F31BC439;

	internal Label lblStatus;

	internal CheckBox ckbComment;

	internal CheckBox A99D578C;

	internal CheckBox B026600B;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton rbNganCachMoiDong;

	internal Label label9;

	internal Button btnDown;

	internal Button FD3F4B1E;

	internal RichTextBox FAA4BB96;

	internal Panel F2BFE307;

	internal NumericUpDown nudCountCommentFrom;

	internal Label F219B91C;

	internal Label D6A65CB5;

	internal NumericUpDown D1355439;

	internal Panel plCountShareWall;

	internal NumericUpDown AE9D4B04;

	internal Label label11;

	internal Label F4ADF386;

	internal NumericUpDown nudCountShareTo;

	internal Panel FC0A2836;

	internal NumericUpDown B4B4BE19;

	internal Label label2;

	internal Label D23C1BA7;

	internal NumericUpDown nudCountLikeTo;

	internal NumericUpDown nudTimeTo;

	internal NumericUpDown C08E839E;

	internal Label E482CA33;

	internal Label F4968983;

	internal Label label21;

	internal GroupBox groupBox1;

	internal Label label49;

	internal NumericUpDown nudSoLuongNhomFrom;

	internal Label label68;

	internal NumericUpDown nudSoLuongNhomTo;

	internal Label label66;

	internal Button B4A640B7;

	internal Button button3;

	internal Button CC93B520;

	public fHDTuongTacNhom(string string_2, int int_0 = 0, string D691EC1E = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		AFA8DFBB = D691EC1E;
		AA13450A = int_0;
		if (Class123.C7BE863B("", "HDTuongTacNhom").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacNhom', '" + Language.GetValue("Tương tác Nhóm") + "');");
		}
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDTuongTacNhom");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			CE9D22B5.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(D691EC1E);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			D9A4FAB1.Text = "Câ\u0323p nhâ\u0323t";
			CE9D22B5.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void C92DBF31(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongNhomFrom.Value = f72FAFBC_0.method_0("nudSoLuongNhomFrom", 1);
			nudSoLuongNhomTo.Value = f72FAFBC_0.method_0("nudSoLuongNhomTo", 3);
			C08E839E.Value = f72FAFBC_0.method_0("nudTimeFrom", 10);
			nudTimeTo.Value = f72FAFBC_0.method_0("nudTimeTo", 30);
			B4B4BE19.Value = f72FAFBC_0.method_0("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = f72FAFBC_0.method_0("nudCountLikeTo", 3);
			AE9D4B04.Value = f72FAFBC_0.method_0("nudCountShareFrom", 1);
			nudCountShareTo.Value = f72FAFBC_0.method_0("nudCountShareTo", 3);
			nudCountCommentFrom.Value = f72FAFBC_0.method_0("nudCountCommentFrom", 1);
			D1355439.Value = f72FAFBC_0.method_0("nudCountCommentTo", 3);
			A99D578C.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			B026600B.Checked = f72FAFBC_0.AA824D29("ckbShareWall");
			ckbComment.Checked = f72FAFBC_0.AA824D29("ckbComment");
			FAA4BB96.Text = f72FAFBC_0.GetValue("txtComment");
			if (f72FAFBC_0.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
		}
		catch
		{
		}
		method_2();
	}

	private void B4A640B7_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AC242A90(object sender, EventArgs e)
	{
		string text = CE9D22B5.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> f1808BA = FAA4BB96.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongNhomFrom", nudSoLuongNhomFrom.Value);
		f72FAFBC.GetValue("nudSoLuongNhomTo", nudSoLuongNhomTo.Value);
		f72FAFBC.GetValue("nudTimeFrom", C08E839E.Value);
		f72FAFBC.GetValue("nudTimeTo", nudTimeTo.Value);
		f72FAFBC.GetValue("ckbInteract", A99D578C.Checked);
		f72FAFBC.GetValue("ckbShareWall", B026600B.Checked);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)FAA4BB96.Text.Trim());
		f72FAFBC.GetValue("nudCountLikeFrom", B4B4BE19.Value);
		f72FAFBC.GetValue("nudCountLikeTo", nudCountLikeTo.Value);
		f72FAFBC.GetValue("nudCountShareFrom", AE9D4B04.Value);
		f72FAFBC.GetValue("nudCountShareTo", nudCountShareTo.Value);
		f72FAFBC.GetValue("nudCountCommentFrom", nudCountCommentFrom.Value);
		f72FAFBC.GetValue("nudCountCommentTo", D1355439.Value);
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		string text2 = f72FAFBC.C71A4EA4();
		if (AA13450A == 0)
		{
			if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text2))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class123.smethod_14(AFA8DFBB, text, text2))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void F3284AA1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C7B87839(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void FAA4BB96_TextChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? FAA4BB96.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : FAA4BB96.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_2()
	{
		B99DCF11(null, null);
		ABABF820(null, null);
		D2B88C92(null, null);
	}

	private void ABABF820(object sender, EventArgs e)
	{
		F2BFE307.Enabled = ckbComment.Checked;
		plComment.Enabled = ckbComment.Checked;
	}

	private void E80F8DB1(object sender, EventArgs e)
	{
		groupBox1.Height = 312;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		groupBox1.Height = 353;
	}

	private void C60AA128(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			FD3F4B1E.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void B99DCF11(object sender, EventArgs e)
	{
		FC0A2836.Enabled = A99D578C.Checked;
	}

	private void D2B88C92(object sender, EventArgs e)
	{
		plCountShareWall.Enabled = B026600B.Checked;
	}

	private void DFB45C88(object sender, EventArgs e)
	{
	}

	private void CC93B520_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
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
		F09EF79C = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		ABA2CC21 = new System.Windows.Forms.Panel();
		B4A640B7 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		groupBox1 = new System.Windows.Forms.GroupBox();
		plComment = new System.Windows.Forms.Panel();
		FAA4BB96 = new System.Windows.Forms.RichTextBox();
		btnDown = new System.Windows.Forms.Button();
		FD3F4B1E = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		F31BC439 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		label21 = new System.Windows.Forms.Label();
		A99D578C = new System.Windows.Forms.CheckBox();
		B026600B = new System.Windows.Forms.CheckBox();
		ckbComment = new System.Windows.Forms.CheckBox();
		F2BFE307 = new System.Windows.Forms.Panel();
		nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		F219B91C = new System.Windows.Forms.Label();
		D6A65CB5 = new System.Windows.Forms.Label();
		D1355439 = new System.Windows.Forms.NumericUpDown();
		F4968983 = new System.Windows.Forms.Label();
		plCountShareWall = new System.Windows.Forms.Panel();
		AE9D4B04 = new System.Windows.Forms.NumericUpDown();
		label11 = new System.Windows.Forms.Label();
		F4ADF386 = new System.Windows.Forms.Label();
		nudCountShareTo = new System.Windows.Forms.NumericUpDown();
		FC0A2836 = new System.Windows.Forms.Panel();
		B4B4BE19 = new System.Windows.Forms.NumericUpDown();
		label2 = new System.Windows.Forms.Label();
		D23C1BA7 = new System.Windows.Forms.Label();
		nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		E482CA33 = new System.Windows.Forms.Label();
		nudTimeTo = new System.Windows.Forms.NumericUpDown();
		C08E839E = new System.Windows.Forms.NumericUpDown();
		label49 = new System.Windows.Forms.Label();
		nudSoLuongNhomFrom = new System.Windows.Forms.NumericUpDown();
		label68 = new System.Windows.Forms.Label();
		nudSoLuongNhomTo = new System.Windows.Forms.NumericUpDown();
		label66 = new System.Windows.Forms.Label();
		CE9D22B5 = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		F3284AA1 = new System.Windows.Forms.Button();
		D9A4FAB1 = new System.Windows.Forms.Button();
		A93776B7 = new Bunifu.Framework.UI.BunifuCards();
		button3 = new System.Windows.Forms.Button();
		CC93B520 = new System.Windows.Forms.Button();
		ABA2CC21.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		groupBox1.SuspendLayout();
		plComment.SuspendLayout();
		F2BFE307.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)D1355439).BeginInit();
		plCountShareWall.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)AE9D4B04).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountShareTo).BeginInit();
		FC0A2836.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B4B4BE19).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)C08E839E).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongNhomFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongNhomTo).BeginInit();
		A93776B7.SuspendLayout();
		SuspendLayout();
		F09EF79C.Fixed = true;
		F09EF79C.Horizontal = true;
		F09EF79C.TargetControl = bunifuCustomLabel1;
		F09EF79C.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Nhóm";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = ABA2CC21;
		bunifuDragControl_0.Vertical = true;
		ABA2CC21.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		ABA2CC21.BackColor = System.Drawing.Color.White;
		ABA2CC21.Controls.Add(B4A640B7);
		ABA2CC21.Controls.Add(pictureBox1);
		ABA2CC21.Controls.Add(bunifuCustomLabel1);
		ABA2CC21.Cursor = System.Windows.Forms.Cursors.SizeAll;
		ABA2CC21.Location = new System.Drawing.Point(0, 3);
		ABA2CC21.Name = "pnlHeader";
		ABA2CC21.Size = new System.Drawing.Size(359, 31);
		ABA2CC21.TabIndex = 9;
		B4A640B7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B4A640B7.Cursor = System.Windows.Forms.Cursors.Hand;
		B4A640B7.FlatAppearance.BorderSize = 0;
		B4A640B7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B4A640B7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B4A640B7.ForeColor = System.Drawing.Color.White;
		B4A640B7.Image = Resource.Bitmap_9;
		B4A640B7.Location = new System.Drawing.Point(326, 0);
		B4A640B7.Name = "btnMinimize";
		B4A640B7.Size = new System.Drawing.Size(32, 32);
		B4A640B7.TabIndex = 78;
		B4A640B7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B4A640B7.UseVisualStyleBackColor = true;
		B4A640B7.Click += new System.EventHandler(B4A640B7_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(C60AA128);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(nudSoLuongNhomFrom);
		panel1.Controls.Add(label68);
		panel1.Controls.Add(nudSoLuongNhomTo);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(CE9D22B5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(F3284AA1);
		panel1.Controls.Add(D9A4FAB1);
		panel1.Controls.Add(A93776B7);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 477);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(C7B87839);
		groupBox1.Controls.Add(plComment);
		groupBox1.Controls.Add(label21);
		groupBox1.Controls.Add(A99D578C);
		groupBox1.Controls.Add(B026600B);
		groupBox1.Controls.Add(ckbComment);
		groupBox1.Controls.Add(F2BFE307);
		groupBox1.Controls.Add(F4968983);
		groupBox1.Controls.Add(plCountShareWall);
		groupBox1.Controls.Add(FC0A2836);
		groupBox1.Controls.Add(E482CA33);
		groupBox1.Controls.Add(nudTimeTo);
		groupBox1.Controls.Add(C08E839E);
		groupBox1.Location = new System.Drawing.Point(21, 111);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(321, 312);
		groupBox1.TabIndex = 124;
		groupBox1.TabStop = false;
		groupBox1.Text = " Cấu hình tương tác/Nhóm";
		plComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(button3);
		plComment.Controls.Add(CC93B520);
		plComment.Controls.Add(FAA4BB96);
		plComment.Controls.Add(btnDown);
		plComment.Controls.Add(FD3F4B1E);
		plComment.Controls.Add(rbNganCachKyTu);
		plComment.Controls.Add(rbNganCachMoiDong);
		plComment.Controls.Add(label9);
		plComment.Controls.Add(F31BC439);
		plComment.Controls.Add(lblStatus);
		plComment.Location = new System.Drawing.Point(30, 140);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(281, 164);
		plComment.TabIndex = 10;
		FAA4BB96.Location = new System.Drawing.Point(7, 27);
		FAA4BB96.Name = "txtComment";
		FAA4BB96.Size = new System.Drawing.Size(266, 111);
		FAA4BB96.TabIndex = 106;
		FAA4BB96.Text = "";
		FAA4BB96.WordWrap = false;
		FAA4BB96.TextChanged += new System.EventHandler(FAA4BB96_TextChanged);
		btnDown.BackgroundImage = Resource.Bitmap_91;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.Location = new System.Drawing.Point(224, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 7;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Visible = false;
		btnDown.Click += new System.EventHandler(btnDown_Click);
		FD3F4B1E.BackgroundImage = Resource.Bitmap_73;
		FD3F4B1E.Cursor = System.Windows.Forms.Cursors.Hand;
		FD3F4B1E.Location = new System.Drawing.Point(255, -1);
		FD3F4B1E.Name = "btnUp";
		FD3F4B1E.Size = new System.Drawing.Size(25, 25);
		FD3F4B1E.TabIndex = 7;
		FD3F4B1E.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		FD3F4B1E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FD3F4B1E.Visible = false;
		FD3F4B1E.Click += new System.EventHandler(E80F8DB1);
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(69, 182);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(160, 20);
		rbNganCachKyTu.TabIndex = 6;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(69, 161);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(156, 20);
		rbNganCachMoiDong.TabIndex = 5;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(4, 161);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(65, 16);
		label9.TabIndex = 4;
		label9.Text = "Tùy chọn:";
		F31BC439.AutoSize = true;
		F31BC439.Location = new System.Drawing.Point(4, 141);
		F31BC439.Name = "label8";
		F31BC439.Size = new System.Drawing.Size(266, 16);
		F31BC439.TabIndex = 0;
		F31BC439.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(140, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		label21.AutoSize = true;
		label21.Location = new System.Drawing.Point(6, 25);
		label21.Name = "label21";
		label21.Size = new System.Drawing.Size(92, 16);
		label21.TabIndex = 110;
		label21.Text = "Thơ\u0300i gian lươ\u0301t:";
		A99D578C.AutoSize = true;
		A99D578C.Cursor = System.Windows.Forms.Cursors.Hand;
		A99D578C.Location = new System.Drawing.Point(9, 53);
		A99D578C.Name = "ckbInteract";
		A99D578C.Size = new System.Drawing.Size(76, 20);
		A99D578C.TabIndex = 7;
		A99D578C.Text = "Cảm xúc";
		A99D578C.UseVisualStyleBackColor = true;
		A99D578C.CheckedChanged += new System.EventHandler(B99DCF11);
		B026600B.AutoSize = true;
		B026600B.Cursor = System.Windows.Forms.Cursors.Hand;
		B026600B.Location = new System.Drawing.Point(9, 82);
		B026600B.Name = "ckbShareWall";
		B026600B.Size = new System.Drawing.Size(90, 20);
		B026600B.TabIndex = 8;
		B026600B.Text = "Share Wall";
		B026600B.UseVisualStyleBackColor = true;
		B026600B.CheckedChanged += new System.EventHandler(D2B88C92);
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(9, 111);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(82, 20);
		ckbComment.TabIndex = 9;
		ckbComment.Text = "Comment";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ABABF820);
		F2BFE307.Controls.Add(nudCountCommentFrom);
		F2BFE307.Controls.Add(F219B91C);
		F2BFE307.Controls.Add(D6A65CB5);
		F2BFE307.Controls.Add(D1355439);
		F2BFE307.Location = new System.Drawing.Point(116, 110);
		F2BFE307.Name = "plCountComment";
		F2BFE307.Size = new System.Drawing.Size(196, 25);
		F2BFE307.TabIndex = 118;
		nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentFrom.Name = "nudCountCommentFrom";
		nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		nudCountCommentFrom.TabIndex = 1;
		F219B91C.AutoSize = true;
		F219B91C.Location = new System.Drawing.Point(159, 3);
		F219B91C.Name = "label13";
		F219B91C.Size = new System.Drawing.Size(30, 16);
		F219B91C.TabIndex = 35;
		F219B91C.Text = "lươ\u0323t";
		D6A65CB5.Location = new System.Drawing.Point(63, 3);
		D6A65CB5.Name = "label14";
		D6A65CB5.Size = new System.Drawing.Size(29, 16);
		D6A65CB5.TabIndex = 37;
		D6A65CB5.Text = "đê\u0301n";
		D6A65CB5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D1355439.Location = new System.Drawing.Point(98, 1);
		D1355439.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D1355439.Name = "nudCountCommentTo";
		D1355439.Size = new System.Drawing.Size(56, 23);
		D1355439.TabIndex = 2;
		F4968983.AutoSize = true;
		F4968983.Location = new System.Drawing.Point(275, 25);
		F4968983.Name = "label18";
		F4968983.Size = new System.Drawing.Size(31, 16);
		F4968983.TabIndex = 112;
		F4968983.Text = "giây";
		plCountShareWall.Controls.Add(AE9D4B04);
		plCountShareWall.Controls.Add(label11);
		plCountShareWall.Controls.Add(F4ADF386);
		plCountShareWall.Controls.Add(nudCountShareTo);
		plCountShareWall.Location = new System.Drawing.Point(116, 80);
		plCountShareWall.Name = "plCountShareWall";
		plCountShareWall.Size = new System.Drawing.Size(196, 25);
		plCountShareWall.TabIndex = 117;
		AE9D4B04.Location = new System.Drawing.Point(1, 1);
		AE9D4B04.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AE9D4B04.Name = "nudCountShareFrom";
		AE9D4B04.Size = new System.Drawing.Size(56, 23);
		AE9D4B04.TabIndex = 1;
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(159, 3);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(30, 16);
		label11.TabIndex = 35;
		label11.Text = "lươ\u0323t";
		F4ADF386.Location = new System.Drawing.Point(63, 3);
		F4ADF386.Name = "label12";
		F4ADF386.Size = new System.Drawing.Size(29, 16);
		F4ADF386.TabIndex = 37;
		F4ADF386.Text = "đê\u0301n";
		F4ADF386.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountShareTo.Location = new System.Drawing.Point(98, 1);
		nudCountShareTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountShareTo.Name = "nudCountShareTo";
		nudCountShareTo.Size = new System.Drawing.Size(56, 23);
		nudCountShareTo.TabIndex = 2;
		FC0A2836.Controls.Add(B4B4BE19);
		FC0A2836.Controls.Add(label2);
		FC0A2836.Controls.Add(D23C1BA7);
		FC0A2836.Controls.Add(nudCountLikeTo);
		FC0A2836.Location = new System.Drawing.Point(116, 51);
		FC0A2836.Name = "plCountLike";
		FC0A2836.Size = new System.Drawing.Size(196, 25);
		FC0A2836.TabIndex = 116;
		B4B4BE19.Location = new System.Drawing.Point(1, 1);
		B4B4BE19.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B4B4BE19.Name = "nudCountLikeFrom";
		B4B4BE19.Size = new System.Drawing.Size(56, 23);
		B4B4BE19.TabIndex = 1;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(159, 3);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(30, 16);
		label2.TabIndex = 35;
		label2.Text = "lươ\u0323t";
		D23C1BA7.Location = new System.Drawing.Point(63, 3);
		D23C1BA7.Name = "label10";
		D23C1BA7.Size = new System.Drawing.Size(29, 16);
		D23C1BA7.TabIndex = 37;
		D23C1BA7.Text = "đê\u0301n";
		D23C1BA7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountLikeTo.Location = new System.Drawing.Point(98, 1);
		nudCountLikeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeTo.Name = "nudCountLikeTo";
		nudCountLikeTo.Size = new System.Drawing.Size(56, 23);
		nudCountLikeTo.TabIndex = 2;
		E482CA33.Location = new System.Drawing.Point(179, 25);
		E482CA33.Name = "label16";
		E482CA33.Size = new System.Drawing.Size(29, 16);
		E482CA33.TabIndex = 114;
		E482CA33.Text = "đê\u0301n";
		E482CA33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudTimeTo.Location = new System.Drawing.Point(214, 23);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new System.Drawing.Size(56, 23);
		nudTimeTo.TabIndex = 107;
		C08E839E.Location = new System.Drawing.Point(117, 23);
		C08E839E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C08E839E.Name = "nudTimeFrom";
		C08E839E.Size = new System.Drawing.Size(56, 23);
		C08E839E.TabIndex = 106;
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(18, 82);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(100, 16);
		label49.TabIndex = 121;
		label49.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		nudSoLuongNhomFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongNhomFrom.Location = new System.Drawing.Point(129, 80);
		nudSoLuongNhomFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongNhomFrom.Name = "nudSoLuongNhomFrom";
		nudSoLuongNhomFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongNhomFrom.TabIndex = 119;
		nudSoLuongNhomFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label68.AutoSize = true;
		label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label68.Location = new System.Drawing.Point(287, 82);
		label68.Name = "label68";
		label68.Size = new System.Drawing.Size(40, 16);
		label68.TabIndex = 122;
		label68.Text = "nhóm";
		nudSoLuongNhomTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongNhomTo.Location = new System.Drawing.Point(226, 80);
		nudSoLuongNhomTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongNhomTo.Name = "nudSoLuongNhomTo";
		nudSoLuongNhomTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongNhomTo.TabIndex = 120;
		nudSoLuongNhomTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label66.Location = new System.Drawing.Point(191, 82);
		label66.Name = "label66";
		label66.Size = new System.Drawing.Size(29, 16);
		label66.TabIndex = 123;
		label66.Text = "đê\u0301n";
		label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		CE9D22B5.Location = new System.Drawing.Point(129, 49);
		CE9D22B5.Name = "txtTenHanhDong";
		CE9D22B5.Size = new System.Drawing.Size(213, 23);
		CE9D22B5.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(18, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		label1.Click += new System.EventHandler(DFB45C88);
		F3284AA1.BackColor = System.Drawing.Color.Maroon;
		F3284AA1.Cursor = System.Windows.Forms.Cursors.Hand;
		F3284AA1.FlatAppearance.BorderSize = 0;
		F3284AA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F3284AA1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F3284AA1.ForeColor = System.Drawing.Color.White;
		F3284AA1.Location = new System.Drawing.Point(189, 432);
		F3284AA1.Name = "btnCancel";
		F3284AA1.Size = new System.Drawing.Size(92, 29);
		F3284AA1.TabIndex = 12;
		F3284AA1.Text = "Đóng";
		F3284AA1.UseVisualStyleBackColor = false;
		F3284AA1.Click += new System.EventHandler(F3284AA1_Click);
		D9A4FAB1.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		D9A4FAB1.Cursor = System.Windows.Forms.Cursors.Hand;
		D9A4FAB1.FlatAppearance.BorderSize = 0;
		D9A4FAB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D9A4FAB1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D9A4FAB1.ForeColor = System.Drawing.Color.White;
		D9A4FAB1.Location = new System.Drawing.Point(82, 432);
		D9A4FAB1.Name = "btnAdd";
		D9A4FAB1.Size = new System.Drawing.Size(92, 29);
		D9A4FAB1.TabIndex = 11;
		D9A4FAB1.Text = "Thêm";
		D9A4FAB1.UseVisualStyleBackColor = false;
		D9A4FAB1.Click += new System.EventHandler(AC242A90);
		A93776B7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A93776B7.BackColor = System.Drawing.Color.White;
		A93776B7.BorderRadius = 0;
		A93776B7.BottomSahddow = true;
		A93776B7.color = System.Drawing.Color.DarkViolet;
		A93776B7.Controls.Add(ABA2CC21);
		A93776B7.LeftSahddow = false;
		A93776B7.Location = new System.Drawing.Point(1, 0);
		A93776B7.Name = "bunifuCards1";
		A93776B7.RightSahddow = true;
		A93776B7.ShadowDepth = 20;
		A93776B7.Size = new System.Drawing.Size(359, 37);
		A93776B7.TabIndex = 28;
		button3.Cursor = System.Windows.Forms.Cursors.Help;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(224, 184);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(21, 23);
		button3.TabIndex = 107;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		CC93B520.Cursor = System.Windows.Forms.Cursors.Help;
		CC93B520.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CC93B520.Location = new System.Drawing.Point(224, 161);
		CC93B520.Name = "button2";
		CC93B520.Size = new System.Drawing.Size(21, 23);
		CC93B520.TabIndex = 108;
		CC93B520.Text = "?";
		CC93B520.UseVisualStyleBackColor = true;
		CC93B520.Click += new System.EventHandler(CC93B520_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 477);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(C92DBF31);
		ABA2CC21.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		F2BFE307.ResumeLayout(false);
		F2BFE307.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)D1355439).EndInit();
		plCountShareWall.ResumeLayout(false);
		plCountShareWall.PerformLayout();
		((System.ComponentModel.ISupportInitialize)AE9D4B04).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountShareTo).EndInit();
		FC0A2836.ResumeLayout(false);
		FC0A2836.PerformLayout();
		((System.ComponentModel.ISupportInitialize)B4B4BE19).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)C08E839E).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongNhomFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongNhomTo).EndInit();
		A93776B7.ResumeLayout(false);
		ResumeLayout(false);
	}
}
