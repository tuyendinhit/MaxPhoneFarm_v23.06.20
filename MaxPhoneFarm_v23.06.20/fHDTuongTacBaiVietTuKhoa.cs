using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacBaiVietTuKhoa : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string F03C4783;

	internal string CAA0472A;

	internal int int_0;

	internal static bool BE923BA3;

	internal List<CheckBox> C6A08F3C;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl D9A81100;

	internal Panel panel1;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudSoLuongBaiVietTo;

	internal NumericUpDown nudDelayFrom;

	internal NumericUpDown nudSoLuongBaiVietFrom;

	internal TextBox txtTenHanhDong;

	internal Label A8121A37;

	internal Label label3;

	internal Label label6;

	internal Label C5A97B97;

	internal Label B0B48398;

	internal Label label1;

	internal Button btnCancel;

	internal Button BB115D86;

	internal BunifuCards bunifuCards1;

	internal Panel E901B8A1;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel E3829C23;

	internal Label A223C801;

	internal Label EE155620;

	internal CheckBox ckbComment;

	internal Label label19;

	internal RichTextBox txtComment;

	internal RadioButton AC206C85;

	internal RadioButton D2A7A3A9;

	internal Label label9;

	internal Button button3;

	internal Button button2;

	internal LinkLabel linkLabel1;

	internal CheckBox ckbInteract;

	internal Panel plAnh;

	internal TextBox DF2B13A3;

	internal Label F9BD1099;

	internal CheckBox ckbAnh;

	internal RichTextBox txtTuKhoa;

	internal Label D1005012;

	internal Label label10;

	internal Panel EC9D2328;

	internal CheckBox C5A11505;

	internal CheckBox A2B10D80;

	internal CheckBox C4A53406;

	internal CheckBox ckbHaha;

	internal CheckBox ckbThuong;

	internal CheckBox ckbTym;

	internal CheckBox ckbLike;

	internal Panel panel7;

	internal RadioButton radioButton3;

	internal RadioButton radioButton4;

	internal Label EC08D11F;

	public fHDTuongTacBaiVietTuKhoa(string string_1, int B3237C0D = 0, string string_2 = "")
	{
		InitializeComponent();
		BE923BA3 = false;
		string_0 = string_1;
		CAA0472A = string_2;
		int_0 = B3237C0D;
		if (Class123.C7BE863B("", "HDTuongTacBaiVietTuKhoa").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBaiVietTuKhoa', 'Tương tác Ba\u0300i viê\u0301t từ khóa');");
		}
		string d399C = "";
		switch (B3237C0D)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDTuongTacBaiVietTuKhoa");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			F03C4783 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			BB115D86.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void E2B32B33(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongBaiVietFrom.Value = f72FAFBC_0.method_0("nudSoLuongBaiVietFrom", 1);
			nudSoLuongBaiVietTo.Value = f72FAFBC_0.method_0("nudSoLuongBaiVietTo", 1);
			nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			txtTuKhoa.Text = f72FAFBC_0.GetValue("txtTuKhoa");
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			string text = f72FAFBC_0.GetValue("typeReaction");
			C6A08F3C = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, ckbHaha, C4A53406, A2B10D80, C5A11505 };
			for (int i = 0; i < C6A08F3C.Count; i++)
			{
				C6A08F3C[i].Checked = text.Contains(i.ToString());
			}
			ckbComment.Checked = f72FAFBC_0.AA824D29("ckbComment");
			txtComment.Text = f72FAFBC_0.GetValue("txtComment");
			if (f72FAFBC_0.method_0("typeNganCach") == 1)
			{
				AC206C85.Checked = true;
			}
			else
			{
				D2A7A3A9.Checked = true;
			}
			ckbAnh.Checked = f72FAFBC_0.AA824D29("ckbAnh");
			DF2B13A3.Text = f72FAFBC_0.GetValue("txtPathAnh");
		}
		catch
		{
		}
		method_0();
	}

	private void AB2DC898(object sender, EventArgs e)
	{
		Close();
	}

	private void EF881D9B(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
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
		f72FAFBC.GetValue("txtTuKhoa", (object)txtTuKhoa.Text.Trim());
		f72FAFBC.GetValue("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		f72FAFBC.GetValue("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		for (int i = 0; i < C6A08F3C.Count; i++)
		{
			text2 += (C6A08F3C[i].Checked ? (i.ToString() ?? "") : "");
		}
		f72FAFBC.GetValue("typeReaction", (object)text2);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		int num = 0;
		if (AC206C85.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		f72FAFBC.GetValue("ckbAnh", ckbAnh.Checked);
		f72FAFBC.GetValue("txtPathAnh", (object)DF2B13A3.Text.Trim());
		string text3 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, F03C4783, text3))
				{
					BE923BA3 = true;
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
			if (Class123.smethod_14(CAA0472A, text, text3))
			{
				BE923BA3 = true;
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

	private void B4186589(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void CEA11310(object sender, EventArgs e)
	{
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		BE9B79A7();
	}

	private void BE9B79A7()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!D2A7A3A9.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			EE155620.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_0()
	{
		ckbInteract_CheckedChanged(null, null);
		BDAC750A(null, null);
		ckbAnh_CheckedChanged(null, null);
	}

	private void BDAC750A(object sender, EventArgs e)
	{
		E3829C23.Enabled = ckbComment.Checked;
	}

	private void BF0E1F01(object sender, EventArgs e)
	{
	}

	private void txtComment_MouseEnter(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void method_1(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Chú ý: Nếu là ID Fanpage thì cần thêm /posts vào sau ID.") + "\r\n" + Language.GetValue("Ví dụ") + ": 15465478242/posts");
	}

	private void D681D11C(object sender, EventArgs e)
	{
		BE9B79A7();
	}

	private void EA3B2D02(object sender, EventArgs e)
	{
		BE9B79A7();
	}

	private void DE108A31(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		EC9D2328.Enabled = ckbInteract.Checked;
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void ckbAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnh.Checked;
	}

	private void CF3F278F(object sender, EventArgs e)
	{
		Common.D936DD84(txtTuKhoa, label10);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacBaiVietTuKhoa));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D9A81100 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		E901B8A1 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		txtTuKhoa = new System.Windows.Forms.RichTextBox();
		D1005012 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		plAnh = new System.Windows.Forms.Panel();
		DF2B13A3 = new System.Windows.Forms.TextBox();
		F9BD1099 = new System.Windows.Forms.Label();
		ckbAnh = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		E3829C23 = new System.Windows.Forms.Panel();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		button3 = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		AC206C85 = new System.Windows.Forms.RadioButton();
		D2A7A3A9 = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		txtComment = new System.Windows.Forms.RichTextBox();
		A223C801 = new System.Windows.Forms.Label();
		EE155620 = new System.Windows.Forms.Label();
		label19 = new System.Windows.Forms.Label();
		ckbComment = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		A8121A37 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		C5A97B97 = new System.Windows.Forms.Label();
		B0B48398 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		BB115D86 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		EC9D2328 = new System.Windows.Forms.Panel();
		C5A11505 = new System.Windows.Forms.CheckBox();
		A2B10D80 = new System.Windows.Forms.CheckBox();
		C4A53406 = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbThuong = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		panel7 = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		radioButton4 = new System.Windows.Forms.RadioButton();
		EC08D11F = new System.Windows.Forms.Label();
		E901B8A1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plAnh.SuspendLayout();
		E3829C23.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		EC9D2328.SuspendLayout();
		panel7.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(709, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Ba\u0300i viê\u0301t từ khóa";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D9A81100.Fixed = true;
		D9A81100.Horizontal = true;
		D9A81100.TargetControl = E901B8A1;
		D9A81100.Vertical = true;
		E901B8A1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E901B8A1.BackColor = System.Drawing.Color.White;
		E901B8A1.Controls.Add(button1);
		E901B8A1.Controls.Add(pictureBox1);
		E901B8A1.Controls.Add(bunifuCustomLabel1);
		E901B8A1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		E901B8A1.Location = new System.Drawing.Point(0, 3);
		E901B8A1.Name = "pnlHeader";
		E901B8A1.Size = new System.Drawing.Size(709, 31);
		E901B8A1.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(678, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(AB2DC898);
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
		panel1.Controls.Add(EC9D2328);
		panel1.Controls.Add(txtTuKhoa);
		panel1.Controls.Add(D1005012);
		panel1.Controls.Add(label10);
		panel1.Controls.Add(plAnh);
		panel1.Controls.Add(ckbAnh);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(E3829C23);
		panel1.Controls.Add(label19);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudSoLuongBaiVietTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(nudSoLuongBaiVietFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(A8121A37);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(C5A97B97);
		panel1.Controls.Add(B0B48398);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(BB115D86);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(712, 450);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(B4186589);
		txtTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtTuKhoa.Location = new System.Drawing.Point(31, 153);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new System.Drawing.Size(295, 222);
		txtTuKhoa.TabIndex = 179;
		txtTuKhoa.Text = "";
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += new System.EventHandler(CF3F278F);
		D1005012.AutoSize = true;
		D1005012.Location = new System.Drawing.Point(28, 377);
		D1005012.Name = "label2";
		D1005012.Size = new System.Drawing.Size(259, 16);
		D1005012.TabIndex = 177;
		D1005012.Text = "(Mỗi từ khóa 1 dòng, spin nội dung {a|b|c})";
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(27, 134);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(139, 16);
		label10.TabIndex = 178;
		label10.Text = "Danh sa\u0301ch từ khóa (0):";
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(DF2B13A3);
		plAnh.Controls.Add(F9BD1099);
		plAnh.Location = new System.Drawing.Point(366, 363);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(313, 31);
		plAnh.TabIndex = 176;
		DF2B13A3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DF2B13A3.Location = new System.Drawing.Point(90, 3);
		DF2B13A3.Name = "txtPathAnh";
		DF2B13A3.Size = new System.Drawing.Size(218, 23);
		DF2B13A3.TabIndex = 1;
		F9BD1099.AutoSize = true;
		F9BD1099.Location = new System.Drawing.Point(3, 6);
		F9BD1099.Name = "label14";
		F9BD1099.Size = new System.Drawing.Size(88, 16);
		F9BD1099.TabIndex = 0;
		F9BD1099.Text = "Thư mu\u0323c ảnh:";
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAnh.Location = new System.Drawing.Point(349, 339);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new System.Drawing.Size(103, 20);
		ckbAnh.TabIndex = 175;
		ckbAnh.Text = "Bình luận ảnh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += new System.EventHandler(ckbAnh_CheckedChanged);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(349, 51);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(112, 20);
		ckbInteract.TabIndex = 169;
		ckbInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		E3829C23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E3829C23.Controls.Add(linkLabel1);
		E3829C23.Controls.Add(button3);
		E3829C23.Controls.Add(button2);
		E3829C23.Controls.Add(AC206C85);
		E3829C23.Controls.Add(D2A7A3A9);
		E3829C23.Controls.Add(label9);
		E3829C23.Controls.Add(txtComment);
		E3829C23.Controls.Add(A223C801);
		E3829C23.Controls.Add(EE155620);
		E3829C23.Location = new System.Drawing.Point(367, 142);
		E3829C23.Name = "plComment";
		E3829C23.Size = new System.Drawing.Size(312, 193);
		E3829C23.TabIndex = 10;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.Location = new System.Drawing.Point(191, 126);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(81, 16);
		linkLabel1.TabIndex = 192;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(DE108A31);
		button3.Cursor = System.Windows.Forms.Cursors.Help;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(229, 168);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(21, 23);
		button3.TabIndex = 4;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(229, 145);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 23);
		button2.TabIndex = 4;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		AC206C85.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		AC206C85.AutoSize = true;
		AC206C85.Cursor = System.Windows.Forms.Cursors.Hand;
		AC206C85.Location = new System.Drawing.Point(70, 168);
		AC206C85.Name = "rbNganCachKyTu";
		AC206C85.Size = new System.Drawing.Size(159, 20);
		AC206C85.TabIndex = 3;
		AC206C85.Text = "Nội dung có nhiều dòng";
		AC206C85.UseVisualStyleBackColor = true;
		AC206C85.CheckedChanged += new System.EventHandler(EA3B2D02);
		D2A7A3A9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		D2A7A3A9.AutoSize = true;
		D2A7A3A9.Checked = true;
		D2A7A3A9.Cursor = System.Windows.Forms.Cursors.Hand;
		D2A7A3A9.Location = new System.Drawing.Point(70, 147);
		D2A7A3A9.Name = "rbNganCachMoiDong";
		D2A7A3A9.Size = new System.Drawing.Size(155, 20);
		D2A7A3A9.TabIndex = 3;
		D2A7A3A9.TabStop = true;
		D2A7A3A9.Text = "Nội dung chỉ có 1 dòng";
		D2A7A3A9.UseVisualStyleBackColor = true;
		D2A7A3A9.CheckedChanged += new System.EventHandler(D681D11C);
		label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(5, 147);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(64, 16);
		label9.TabIndex = 2;
		label9.Text = "Tùy chọn:";
		txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtComment.Location = new System.Drawing.Point(7, 25);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(294, 99);
		txtComment.TabIndex = 1;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		txtComment.MouseEnter += new System.EventHandler(txtComment_MouseEnter);
		txtComment.MouseLeave += new System.EventHandler(BF0E1F01);
		A223C801.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		A223C801.AutoSize = true;
		A223C801.Location = new System.Drawing.Point(4, 127);
		A223C801.Name = "label8";
		A223C801.Size = new System.Drawing.Size(143, 16);
		A223C801.TabIndex = 0;
		A223C801.Text = "(Spin nội dung {a|b|c})";
		EE155620.AutoSize = true;
		EE155620.Location = new System.Drawing.Point(3, 5);
		EE155620.Name = "lblStatus";
		EE155620.Size = new System.Drawing.Size(139, 16);
		EE155620.TabIndex = 0;
		EE155620.Text = "Nội dung bình luận (0):";
		label19.AutoSize = true;
		label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label19.Location = new System.Drawing.Point(27, 80);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(72, 16);
		label19.TabIndex = 101;
		label19.Text = "Sô\u0301 ba\u0300i viết:";
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(349, 118);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(127, 20);
		ckbComment.TabIndex = 9;
		ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(BDAC750A);
		nudDelayTo.Location = new System.Drawing.Point(234, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 6;
		nudSoLuongBaiVietTo.Location = new System.Drawing.Point(234, 78);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(137, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(137, 78);
		nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(137, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(189, 23);
		txtTenHanhDong.TabIndex = 0;
		A8121A37.Location = new System.Drawing.Point(199, 109);
		A8121A37.Name = "label7";
		A8121A37.Size = new System.Drawing.Size(29, 16);
		A8121A37.TabIndex = 38;
		A8121A37.Text = "đê\u0301n";
		A8121A37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Location = new System.Drawing.Point(199, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(292, 109);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		C5A97B97.AutoSize = true;
		C5A97B97.Location = new System.Drawing.Point(292, 80);
		C5A97B97.Name = "label4";
		C5A97B97.Size = new System.Drawing.Size(24, 16);
		C5A97B97.TabIndex = 35;
		C5A97B97.Text = "ba\u0300i";
		B0B48398.AutoSize = true;
		B0B48398.Location = new System.Drawing.Point(27, 109);
		B0B48398.Name = "label5";
		B0B48398.Size = new System.Drawing.Size(89, 16);
		B0B48398.TabIndex = 34;
		B0B48398.Text = "Thơ\u0300i gian chơ\u0300:";
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
		btnCancel.Location = new System.Drawing.Point(364, 408);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		BB115D86.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		BB115D86.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		BB115D86.Cursor = System.Windows.Forms.Cursors.Hand;
		BB115D86.FlatAppearance.BorderSize = 0;
		BB115D86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BB115D86.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BB115D86.ForeColor = System.Drawing.Color.White;
		BB115D86.Location = new System.Drawing.Point(257, 408);
		BB115D86.Name = "btnAdd";
		BB115D86.Size = new System.Drawing.Size(92, 29);
		BB115D86.TabIndex = 11;
		BB115D86.Text = "Thêm";
		BB115D86.UseVisualStyleBackColor = false;
		BB115D86.Click += new System.EventHandler(EF881D9B);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(E901B8A1);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(709, 37);
		bunifuCards1.TabIndex = 28;
		EC9D2328.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EC9D2328.Controls.Add(C5A11505);
		EC9D2328.Controls.Add(A2B10D80);
		EC9D2328.Controls.Add(C4A53406);
		EC9D2328.Controls.Add(ckbHaha);
		EC9D2328.Controls.Add(ckbThuong);
		EC9D2328.Controls.Add(ckbTym);
		EC9D2328.Controls.Add(ckbLike);
		EC9D2328.Controls.Add(panel7);
		EC9D2328.Controls.Add(EC08D11F);
		EC9D2328.Location = new System.Drawing.Point(367, 77);
		EC9D2328.Name = "plInteract";
		EC9D2328.Size = new System.Drawing.Size(312, 33);
		EC9D2328.TabIndex = 181;
		C5A11505.Cursor = System.Windows.Forms.Cursors.Hand;
		C5A11505.Image = Resource.Bitmap_5;
		C5A11505.Location = new System.Drawing.Point(266, 1);
		C5A11505.Name = "ckbGian";
		C5A11505.Size = new System.Drawing.Size(40, 30);
		C5A11505.TabIndex = 179;
		C5A11505.UseVisualStyleBackColor = true;
		A2B10D80.Cursor = System.Windows.Forms.Cursors.Hand;
		A2B10D80.Image = Resource.Bitmap_174;
		A2B10D80.Location = new System.Drawing.Point(222, 1);
		A2B10D80.Name = "ckbBuon";
		A2B10D80.Size = new System.Drawing.Size(40, 30);
		A2B10D80.TabIndex = 178;
		A2B10D80.UseVisualStyleBackColor = true;
		C4A53406.Cursor = System.Windows.Forms.Cursors.Hand;
		C4A53406.Image = Resource.F391A116;
		C4A53406.Location = new System.Drawing.Point(178, 1);
		C4A53406.Name = "ckbWow";
		C4A53406.Size = new System.Drawing.Size(40, 30);
		C4A53406.TabIndex = 177;
		C4A53406.UseVisualStyleBackColor = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Image = Resource.Bitmap_38;
		ckbHaha.Location = new System.Drawing.Point(134, 1);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(40, 30);
		ckbHaha.TabIndex = 176;
		ckbHaha.UseVisualStyleBackColor = true;
		ckbThuong.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbThuong.Image = Resource.DD3ED6B8;
		ckbThuong.Location = new System.Drawing.Point(90, 1);
		ckbThuong.Name = "ckbThuong";
		ckbThuong.Size = new System.Drawing.Size(40, 30);
		ckbThuong.TabIndex = 175;
		ckbThuong.UseVisualStyleBackColor = true;
		ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTym.Image = Resource.C8AF3BB6;
		ckbTym.Location = new System.Drawing.Point(46, 1);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new System.Drawing.Size(40, 30);
		ckbTym.TabIndex = 174;
		ckbTym.UseVisualStyleBackColor = true;
		ckbLike.Checked = true;
		ckbLike.CheckState = System.Windows.Forms.CheckState.Checked;
		ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike.Image = Resource.Bitmap_163;
		ckbLike.Location = new System.Drawing.Point(2, 1);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new System.Drawing.Size(40, 30);
		ckbLike.TabIndex = 173;
		ckbLike.UseVisualStyleBackColor = true;
		panel7.Controls.Add(radioButton3);
		panel7.Controls.Add(radioButton4);
		panel7.Location = new System.Drawing.Point(67, 300);
		panel7.Name = "panel7";
		panel7.Size = new System.Drawing.Size(200, 43);
		panel7.TabIndex = 43;
		radioButton3.AutoSize = true;
		radioButton3.Checked = true;
		radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton3.Location = new System.Drawing.Point(3, 2);
		radioButton3.Name = "radioButton3";
		radioButton3.Size = new System.Drawing.Size(201, 20);
		radioButton3.TabIndex = 3;
		radioButton3.TabStop = true;
		radioButton3.Text = "Comment theo thứ tự nội dung";
		radioButton3.UseVisualStyleBackColor = true;
		radioButton4.AutoSize = true;
		radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton4.Location = new System.Drawing.Point(3, 23);
		radioButton4.Name = "radioButton4";
		radioButton4.Size = new System.Drawing.Size(200, 20);
		radioButton4.TabIndex = 3;
		radioButton4.Text = "Comment ngẫu nhiên nội dung";
		radioButton4.UseVisualStyleBackColor = true;
		EC08D11F.AutoSize = true;
		EC08D11F.Location = new System.Drawing.Point(4, 302);
		EC08D11F.Name = "label26";
		EC08D11F.Size = new System.Drawing.Size(64, 16);
		EC08D11F.TabIndex = 2;
		EC08D11F.Text = "Tùy chọn:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(712, 450);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacBaiVietTuKhoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(E2B32B33);
		E901B8A1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		E3829C23.ResumeLayout(false);
		E3829C23.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		EC9D2328.ResumeLayout(false);
		EC9D2328.PerformLayout();
		panel7.ResumeLayout(false);
		panel7.PerformLayout();
		ResumeLayout(false);
	}
}
