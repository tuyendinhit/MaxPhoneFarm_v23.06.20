using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacReelTuKhoa : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string B91BF91B;

	internal string E09762A0;

	internal string string_0;

	internal int int_0;

	internal static bool CC1FC914;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl E3184795;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel BC1645AC;

	internal NumericUpDown D48F20B9;

	internal NumericUpDown nudTimeFrom;

	internal TextBox txtTenHanhDong;

	internal Label label7;

	internal Label label5;

	internal Label DE8E3E1C;

	internal Button FEBB75AF;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button C3B08098;

	internal PictureBox CF979304;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label B0A9993E;

	internal CheckBox BBB16916;

	internal CheckBox ckbInteract;

	internal CheckBox ckbShareWall;

	internal RichTextBox F7B5C409;

	internal Label label6;

	internal Label label2;

	internal Panel panel2;

	internal Button button3;

	internal RadioButton rbNganCachMoiDong;

	internal Button B3AA942C;

	internal RadioButton DCADA403;

	internal Label label3;

	internal Label label11;

	internal RichTextBox D6916D2B;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal Label B0AB9AB5;

	internal Label label8;

	internal Label D9AFE30F;

	public fHDTuongTacReelTuKhoa(string A1257508, int int_1 = 0, string A61A3894 = "")
	{
		InitializeComponent();
		CC1FC914 = false;
		B91BF91B = A1257508;
		string_0 = A61A3894;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Tương tác Reel từ khóa";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			E09762A0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(A61A3894);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDTuongTacReelTuKhoa_Load(object sender, EventArgs e)
	{
		try
		{
			D6916D2B.Text = f72FAFBC_0.GetValue("txtTuKhoa");
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = f72FAFBC_0.method_0("nudSoLuongTo", 1);
			nudTimeFrom.Value = f72FAFBC_0.method_0("nudTimeFrom", 15);
			D48F20B9.Value = f72FAFBC_0.method_0("nudTimeTo", 30);
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			BBB16916.Checked = f72FAFBC_0.AA824D29("ckbComment");
			ckbShareWall.Checked = f72FAFBC_0.AA824D29("ckbShareWall");
			F7B5C409.Text = f72FAFBC_0.GetValue("txtComment");
			if (f72FAFBC_0.method_0("typeNganCach") == 1)
			{
				DCADA403.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
		}
		catch
		{
		}
		method_0();
	}

	private void C3B08098_Click(object sender, EventArgs e)
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
		if (BBB16916.Checked)
		{
			List<string> f1808BA = F7B5C409.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtTuKhoa", (object)D6916D2B.Text.Trim());
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudTimeFrom", nudTimeFrom.Value);
		f72FAFBC.GetValue("nudTimeTo", D48F20B9.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		f72FAFBC.GetValue("ckbShareWall", ckbShareWall.Checked);
		f72FAFBC.GetValue("ckbComment", BBB16916.Checked);
		f72FAFBC.GetValue("txtComment", (object)F7B5C409.Text.Trim());
		int num = 0;
		if (DCADA403.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(B91BF91B, text, E09762A0, text2))
				{
					CC1FC914 = true;
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
				CC1FC914 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void D29C54A7(object sender, EventArgs e)
	{
		Close();
	}

	private void BC1645AC_Paint(object sender, PaintEventArgs e)
	{
		if (BC1645AC.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BC1645AC.ClientSize.Width - num, BC1645AC.ClientSize.Height - num));
		}
	}

	private void F7B5C409_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(F7B5C409, B0A9993E, DCADA403.Checked ? 1 : 0);
	}

	private void method_0()
	{
		DD165013(null, null);
		BBB16916_CheckedChanged(null, null);
		C591BC00(null, null);
	}

	private void BBB16916_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = BBB16916.Checked;
	}

	private void DD165013(object sender, EventArgs e)
	{
	}

	private void C591BC00(object sender, EventArgs e)
	{
	}

	private void B3AA942C_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		F7B5C409.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		F7B5C409.Focus();
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		Common.D936DD84(F7B5C409, B0A9993E, DCADA403.Checked ? 1 : 0);
	}

	private void DCADA403_CheckedChanged(object sender, EventArgs e)
	{
		Common.D936DD84(F7B5C409, B0A9993E, DCADA403.Checked ? 1 : 0);
	}

	private void D6916D2B_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(D6916D2B, label2);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacReelTuKhoa));
		E3184795 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		C3B08098 = new System.Windows.Forms.Button();
		CF979304 = new System.Windows.Forms.PictureBox();
		BC1645AC = new System.Windows.Forms.Panel();
		D6916D2B = new System.Windows.Forms.RichTextBox();
		label2 = new System.Windows.Forms.Label();
		plComment = new System.Windows.Forms.Panel();
		panel2 = new System.Windows.Forms.Panel();
		button3 = new System.Windows.Forms.Button();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		B3AA942C = new System.Windows.Forms.Button();
		DCADA403 = new System.Windows.Forms.RadioButton();
		label3 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		F7B5C409 = new System.Windows.Forms.RichTextBox();
		B0A9993E = new System.Windows.Forms.Label();
		BBB16916 = new System.Windows.Forms.CheckBox();
		ckbShareWall = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		D48F20B9 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		B0AB9AB5 = new System.Windows.Forms.Label();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label8 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		D9AFE30F = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		DE8E3E1C = new System.Windows.Forms.Label();
		FEBB75AF = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)CF979304).BeginInit();
		BC1645AC.SuspendLayout();
		plComment.SuspendLayout();
		panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)D48F20B9).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		E3184795.Fixed = true;
		E3184795.Horizontal = true;
		E3184795.TargetControl = bunifuCustomLabel1;
		E3184795.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(683, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Reel từ khóa";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(C3B08098);
		pnlHeader.Controls.Add(CF979304);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(683, 31);
		pnlHeader.TabIndex = 9;
		C3B08098.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		C3B08098.Cursor = System.Windows.Forms.Cursors.Hand;
		C3B08098.FlatAppearance.BorderSize = 0;
		C3B08098.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C3B08098.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C3B08098.ForeColor = System.Drawing.Color.White;
		C3B08098.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		C3B08098.Location = new System.Drawing.Point(652, 1);
		C3B08098.Name = "button1";
		C3B08098.Size = new System.Drawing.Size(30, 30);
		C3B08098.TabIndex = 77;
		C3B08098.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C3B08098.UseVisualStyleBackColor = true;
		C3B08098.Click += new System.EventHandler(C3B08098_Click);
		CF979304.Cursor = System.Windows.Forms.Cursors.Default;
		CF979304.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		CF979304.Location = new System.Drawing.Point(3, 2);
		CF979304.Name = "pictureBox1";
		CF979304.Size = new System.Drawing.Size(34, 27);
		CF979304.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		CF979304.TabIndex = 76;
		CF979304.TabStop = false;
		BC1645AC.BackColor = System.Drawing.Color.White;
		BC1645AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BC1645AC.Controls.Add(D6916D2B);
		BC1645AC.Controls.Add(label2);
		BC1645AC.Controls.Add(plComment);
		BC1645AC.Controls.Add(BBB16916);
		BC1645AC.Controls.Add(ckbShareWall);
		BC1645AC.Controls.Add(ckbInteract);
		BC1645AC.Controls.Add(nudSoLuongTo);
		BC1645AC.Controls.Add(D48F20B9);
		BC1645AC.Controls.Add(nudSoLuongFrom);
		BC1645AC.Controls.Add(nudTimeFrom);
		BC1645AC.Controls.Add(B0AB9AB5);
		BC1645AC.Controls.Add(txtTenHanhDong);
		BC1645AC.Controls.Add(label8);
		BC1645AC.Controls.Add(label7);
		BC1645AC.Controls.Add(D9AFE30F);
		BC1645AC.Controls.Add(label6);
		BC1645AC.Controls.Add(label5);
		BC1645AC.Controls.Add(DE8E3E1C);
		BC1645AC.Controls.Add(FEBB75AF);
		BC1645AC.Controls.Add(btnAdd);
		BC1645AC.Controls.Add(bunifuCards1);
		BC1645AC.Cursor = System.Windows.Forms.Cursors.Arrow;
		BC1645AC.Dock = System.Windows.Forms.DockStyle.Fill;
		BC1645AC.Location = new System.Drawing.Point(0, 0);
		BC1645AC.Name = "panel1";
		BC1645AC.Size = new System.Drawing.Size(686, 482);
		BC1645AC.TabIndex = 0;
		BC1645AC.Paint += new System.Windows.Forms.PaintEventHandler(BC1645AC_Paint);
		D6916D2B.Location = new System.Drawing.Point(364, 120);
		D6916D2B.Name = "txtTuKhoa";
		D6916D2B.Size = new System.Drawing.Size(288, 294);
		D6916D2B.TabIndex = 43;
		D6916D2B.Text = "";
		D6916D2B.WordWrap = false;
		D6916D2B.TextChanged += new System.EventHandler(D6916D2B_TextChanged);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(361, 101);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(109, 16);
		label2.TabIndex = 42;
		label2.Text = "Nhập từ khóa (0):";
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(panel2);
		plComment.Controls.Add(label3);
		plComment.Controls.Add(label11);
		plComment.Controls.Add(F7B5C409);
		plComment.Controls.Add(B0A9993E);
		plComment.Location = new System.Drawing.Point(48, 186);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(278, 228);
		plComment.TabIndex = 8;
		panel2.Controls.Add(button3);
		panel2.Controls.Add(rbNganCachMoiDong);
		panel2.Controls.Add(B3AA942C);
		panel2.Controls.Add(DCADA403);
		panel2.Location = new System.Drawing.Point(65, 181);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(200, 43);
		panel2.TabIndex = 179;
		button3.Cursor = System.Windows.Forms.Cursors.Help;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(165, 22);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(21, 21);
		button3.TabIndex = 172;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(3, 3);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		rbNganCachMoiDong.TabIndex = 3;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		B3AA942C.Cursor = System.Windows.Forms.Cursors.Help;
		B3AA942C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B3AA942C.Location = new System.Drawing.Point(165, 1);
		B3AA942C.Name = "button2";
		B3AA942C.Size = new System.Drawing.Size(21, 21);
		B3AA942C.TabIndex = 173;
		B3AA942C.Text = "?";
		B3AA942C.UseVisualStyleBackColor = true;
		B3AA942C.Click += new System.EventHandler(B3AA942C_Click);
		DCADA403.AutoSize = true;
		DCADA403.Cursor = System.Windows.Forms.Cursors.Hand;
		DCADA403.Location = new System.Drawing.Point(3, 24);
		DCADA403.Name = "rbNganCachKyTu";
		DCADA403.Size = new System.Drawing.Size(159, 20);
		DCADA403.TabIndex = 3;
		DCADA403.Text = "Nội dung có nhiều dòng";
		DCADA403.UseVisualStyleBackColor = true;
		DCADA403.CheckedChanged += new System.EventHandler(DCADA403_CheckedChanged);
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(2, 184);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(64, 16);
		label3.TabIndex = 178;
		label3.Text = "Tùy chọn:";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(3, 162);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(133, 16);
		label11.TabIndex = 177;
		label11.Text = "Spin nội dung {a|b|c}";
		F7B5C409.Location = new System.Drawing.Point(6, 24);
		F7B5C409.Name = "txtComment";
		F7B5C409.Size = new System.Drawing.Size(264, 135);
		F7B5C409.TabIndex = 45;
		F7B5C409.Text = "";
		F7B5C409.WordWrap = false;
		F7B5C409.TextChanged += new System.EventHandler(F7B5C409_TextChanged);
		B0A9993E.AutoSize = true;
		B0A9993E.Location = new System.Drawing.Point(3, 5);
		B0A9993E.Name = "lblStatus";
		B0A9993E.Size = new System.Drawing.Size(139, 16);
		B0A9993E.TabIndex = 0;
		B0A9993E.Text = "Nội dung bình luận (0):";
		BBB16916.AutoSize = true;
		BBB16916.Cursor = System.Windows.Forms.Cursors.Hand;
		BBB16916.Location = new System.Drawing.Point(30, 160);
		BBB16916.Name = "ckbComment";
		BBB16916.Size = new System.Drawing.Size(81, 20);
		BBB16916.TabIndex = 7;
		BBB16916.Text = "Comment";
		BBB16916.UseVisualStyleBackColor = true;
		BBB16916.CheckedChanged += new System.EventHandler(BBB16916_CheckedChanged);
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareWall.Location = new System.Drawing.Point(132, 134);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new System.Drawing.Size(89, 20);
		ckbShareWall.TabIndex = 6;
		ckbShareWall.Text = "Share Wall";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbShareWall.CheckedChanged += new System.EventHandler(C591BC00);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 134);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(48, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Like";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(DD165013);
		nudSoLuongTo.Location = new System.Drawing.Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 4;
		D48F20B9.Location = new System.Drawing.Point(229, 107);
		D48F20B9.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D48F20B9.Name = "nudTimeTo";
		D48F20B9.Size = new System.Drawing.Size(56, 23);
		D48F20B9.TabIndex = 4;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 3;
		nudTimeFrom.Location = new System.Drawing.Point(132, 107);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 3;
		B0AB9AB5.Location = new System.Drawing.Point(194, 80);
		B0AB9AB5.Name = "label9";
		B0AB9AB5.Size = new System.Drawing.Size(29, 16);
		B0AB9AB5.TabIndex = 38;
		B0AB9AB5.Text = "đê\u0301n";
		B0AB9AB5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(290, 80);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(29, 16);
		label8.TabIndex = 36;
		label8.Text = "reel";
		label7.Location = new System.Drawing.Point(194, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D9AFE30F.AutoSize = true;
		D9AFE30F.Location = new System.Drawing.Point(27, 80);
		D9AFE30F.Name = "label4";
		D9AFE30F.Size = new System.Drawing.Size(89, 16);
		D9AFE30F.TabIndex = 34;
		D9AFE30F.Text = "Số lượng reel:";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(290, 109);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(93, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian xem:";
		DE8E3E1C.AutoSize = true;
		DE8E3E1C.Location = new System.Drawing.Point(27, 52);
		DE8E3E1C.Name = "label1";
		DE8E3E1C.Size = new System.Drawing.Size(98, 16);
		DE8E3E1C.TabIndex = 31;
		DE8E3E1C.Text = "Tên ha\u0300nh đô\u0323ng:";
		FEBB75AF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		FEBB75AF.BackColor = System.Drawing.Color.Maroon;
		FEBB75AF.Cursor = System.Windows.Forms.Cursors.Hand;
		FEBB75AF.FlatAppearance.BorderSize = 0;
		FEBB75AF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FEBB75AF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FEBB75AF.ForeColor = System.Drawing.Color.White;
		FEBB75AF.Location = new System.Drawing.Point(351, 440);
		FEBB75AF.Name = "btnCancel";
		FEBB75AF.Size = new System.Drawing.Size(92, 29);
		FEBB75AF.TabIndex = 10;
		FEBB75AF.Text = "Đóng";
		FEBB75AF.UseVisualStyleBackColor = false;
		FEBB75AF.Click += new System.EventHandler(D29C54A7);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(244, 440);
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
		bunifuCards1.Size = new System.Drawing.Size(683, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(686, 482);
		base.Controls.Add(BC1645AC);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacReelTuKhoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTuongTacReelTuKhoa_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)CF979304).EndInit();
		BC1645AC.ResumeLayout(false);
		BC1645AC.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)D48F20B9).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
