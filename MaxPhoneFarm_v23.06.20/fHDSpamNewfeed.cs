using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDSpamNewfeed : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string AA32E712;

	internal int int_0;

	internal static bool bool_0;

	internal List<CheckBox> F0272199;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl B181CA17;

	internal BunifuDragControl BA1C2725;

	internal Panel B827BDBA;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown C6A8DCB6;

	internal NumericUpDown nudDelayFrom;

	internal NumericUpDown nudSoLuongBaiVietFrom;

	internal TextBox txtTenHanhDong;

	internal Label label7;

	internal Label label3;

	internal Label label6;

	internal Label label4;

	internal Label label5;

	internal Label label1;

	internal Button btnCancel;

	internal Button A71B6216;

	internal BunifuCards A918822F;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel DAAD8E3A;

	internal Label label8;

	internal Label EB9A62A7;

	internal CheckBox ckbComment;

	internal Label C03D4B27;

	internal RichTextBox txtComment;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton rbNganCachMoiDong;

	internal Label label9;

	internal Button button3;

	internal Button button2;

	internal LinkLabel linkLabel1;

	internal CheckBox BE17EC1A;

	internal Panel A639BB33;

	internal TextBox AB399583;

	internal Label C78CD6A9;

	internal CheckBox ckbAnh;

	internal Panel plInteract;

	internal CheckBox ckbGian;

	internal CheckBox ckbBuon;

	internal CheckBox ckbWow;

	internal CheckBox ckbHaha;

	internal CheckBox ckbThuong;

	internal CheckBox ckbTym;

	internal CheckBox ckbLike;

	internal Panel CE373DB5;

	internal RadioButton A82CCFBF;

	internal RadioButton EF8F9F95;

	internal Label label26;

	public fHDSpamNewfeed(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		Language.SetLanguage(this);
		bool_0 = false;
		string_0 = string_2;
		AA32E712 = string_3;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Spam Newfeed";
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
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			A71B6216.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
	}

	private void FC1FF487(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongBaiVietFrom.Value = f72FAFBC_0.method_0("nudSoLuongBaiVietFrom", 1);
			C6A8DCB6.Value = f72FAFBC_0.method_0("nudSoLuongBaiVietTo", 1);
			nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			BE17EC1A.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			string text = f72FAFBC_0.GetValue("typeReaction");
			F0272199 = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, ckbHaha, ckbWow, ckbBuon, ckbGian };
			for (int i = 0; i < F0272199.Count; i++)
			{
				F0272199[i].Checked = text.Contains(i.ToString());
			}
			ckbComment.Checked = f72FAFBC_0.AA824D29("ckbComment");
			txtComment.Text = f72FAFBC_0.GetValue("txtComment");
			if (f72FAFBC_0.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			ckbAnh.Checked = f72FAFBC_0.AA824D29("ckbAnh");
			AB399583.Text = f72FAFBC_0.GetValue("txtPathAnh");
		}
		catch
		{
		}
		FC27F1BD();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void EC1F9209(object sender, EventArgs e)
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
		f72FAFBC.GetValue("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		f72FAFBC.GetValue("nudSoLuongBaiVietTo", C6A8DCB6.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("ckbInteract", BE17EC1A.Checked);
		string text2 = "";
		for (int i = 0; i < F0272199.Count; i++)
		{
			text2 += (F0272199[i].Checked ? (i.ToString() ?? "") : "");
		}
		f72FAFBC.GetValue("typeReaction", (object)text2);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		f72FAFBC.GetValue("ckbAnh", ckbAnh.Checked);
		f72FAFBC.GetValue("txtPathAnh", (object)AB399583.Text.Trim());
		string text3 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text3))
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
			if (Class123.smethod_14(AA32E712, text, text3))
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

	private void B827BDBA_Paint(object sender, PaintEventArgs e)
	{
		if (B827BDBA.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, B827BDBA.ClientSize.Width - num, B827BDBA.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			EB9A62A7.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void FC27F1BD()
	{
		BE17EC1A_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
		E68D1917(null, null);
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		DAAD8E3A.Enabled = ckbComment.Checked;
	}

	private void txtComment_MouseLeave(object sender, EventArgs e)
	{
	}

	private void txtComment_MouseEnter(object sender, EventArgs e)
	{
	}

	private void F4382921(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void method_2(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Chú ý: Nếu là ID Fanpage thì cần thêm /posts vào sau ID.") + "\r\n" + Language.GetValue("Ví dụ") + ": 15465478242/posts");
	}

	private void C9A49B04(object sender, EventArgs e)
	{
		method_1();
	}

	private void EEACA023(object sender, EventArgs e)
	{
		method_1();
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void BE17EC1A_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = BE17EC1A.Checked;
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void E68D1917(object sender, EventArgs e)
	{
		A639BB33.Enabled = ckbAnh.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDSpamNewfeed));
		B181CA17 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		BA1C2725 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		B827BDBA = new System.Windows.Forms.Panel();
		A639BB33 = new System.Windows.Forms.Panel();
		AB399583 = new System.Windows.Forms.TextBox();
		C78CD6A9 = new System.Windows.Forms.Label();
		ckbAnh = new System.Windows.Forms.CheckBox();
		BE17EC1A = new System.Windows.Forms.CheckBox();
		DAAD8E3A = new System.Windows.Forms.Panel();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		button3 = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		txtComment = new System.Windows.Forms.RichTextBox();
		label8 = new System.Windows.Forms.Label();
		EB9A62A7 = new System.Windows.Forms.Label();
		C03D4B27 = new System.Windows.Forms.Label();
		ckbComment = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		C6A8DCB6 = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		A71B6216 = new System.Windows.Forms.Button();
		A918822F = new Bunifu.Framework.UI.BunifuCards();
		plInteract = new System.Windows.Forms.Panel();
		ckbGian = new System.Windows.Forms.CheckBox();
		ckbBuon = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbThuong = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		CE373DB5 = new System.Windows.Forms.Panel();
		A82CCFBF = new System.Windows.Forms.RadioButton();
		EF8F9F95 = new System.Windows.Forms.RadioButton();
		label26 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		B827BDBA.SuspendLayout();
		A639BB33.SuspendLayout();
		DAAD8E3A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)C6A8DCB6).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).BeginInit();
		A918822F.SuspendLayout();
		plInteract.SuspendLayout();
		CE373DB5.SuspendLayout();
		SuspendLayout();
		B181CA17.Fixed = true;
		B181CA17.Horizontal = true;
		B181CA17.TargetControl = bunifuCustomLabel1;
		B181CA17.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(390, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Spam Newfeed";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		BA1C2725.Fixed = true;
		BA1C2725.Horizontal = true;
		BA1C2725.TargetControl = pnlHeader;
		BA1C2725.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(390, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(359, 1);
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
		B827BDBA.BackColor = System.Drawing.Color.White;
		B827BDBA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B827BDBA.Controls.Add(plInteract);
		B827BDBA.Controls.Add(A639BB33);
		B827BDBA.Controls.Add(ckbAnh);
		B827BDBA.Controls.Add(BE17EC1A);
		B827BDBA.Controls.Add(DAAD8E3A);
		B827BDBA.Controls.Add(C03D4B27);
		B827BDBA.Controls.Add(ckbComment);
		B827BDBA.Controls.Add(nudDelayTo);
		B827BDBA.Controls.Add(C6A8DCB6);
		B827BDBA.Controls.Add(nudDelayFrom);
		B827BDBA.Controls.Add(nudSoLuongBaiVietFrom);
		B827BDBA.Controls.Add(txtTenHanhDong);
		B827BDBA.Controls.Add(label7);
		B827BDBA.Controls.Add(label3);
		B827BDBA.Controls.Add(label6);
		B827BDBA.Controls.Add(label4);
		B827BDBA.Controls.Add(label5);
		B827BDBA.Controls.Add(label1);
		B827BDBA.Controls.Add(btnCancel);
		B827BDBA.Controls.Add(A71B6216);
		B827BDBA.Controls.Add(A918822F);
		B827BDBA.Cursor = System.Windows.Forms.Cursors.Arrow;
		B827BDBA.Dock = System.Windows.Forms.DockStyle.Fill;
		B827BDBA.Location = new System.Drawing.Point(0, 0);
		B827BDBA.Name = "panel1";
		B827BDBA.Size = new System.Drawing.Size(393, 533);
		B827BDBA.TabIndex = 0;
		B827BDBA.Paint += new System.Windows.Forms.PaintEventHandler(B827BDBA_Paint);
		A639BB33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A639BB33.Controls.Add(AB399583);
		A639BB33.Controls.Add(C78CD6A9);
		A639BB33.Location = new System.Drawing.Point(47, 448);
		A639BB33.Name = "plAnh";
		A639BB33.Size = new System.Drawing.Size(313, 31);
		A639BB33.TabIndex = 176;
		AB399583.Location = new System.Drawing.Point(90, 3);
		AB399583.Name = "txtPathAnh";
		AB399583.Size = new System.Drawing.Size(218, 23);
		AB399583.TabIndex = 1;
		C78CD6A9.AutoSize = true;
		C78CD6A9.Location = new System.Drawing.Point(3, 6);
		C78CD6A9.Name = "label14";
		C78CD6A9.Size = new System.Drawing.Size(88, 16);
		C78CD6A9.TabIndex = 0;
		C78CD6A9.Text = "Thư mu\u0323c ảnh:";
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAnh.Location = new System.Drawing.Point(30, 424);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new System.Drawing.Size(103, 20);
		ckbAnh.TabIndex = 175;
		ckbAnh.Text = "Bình luận ảnh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += new System.EventHandler(E68D1917);
		BE17EC1A.AutoSize = true;
		BE17EC1A.Cursor = System.Windows.Forms.Cursors.Hand;
		BE17EC1A.Location = new System.Drawing.Point(30, 136);
		BE17EC1A.Name = "ckbInteract";
		BE17EC1A.Size = new System.Drawing.Size(112, 20);
		BE17EC1A.TabIndex = 169;
		BE17EC1A.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		BE17EC1A.UseVisualStyleBackColor = true;
		BE17EC1A.CheckedChanged += new System.EventHandler(BE17EC1A_CheckedChanged);
		DAAD8E3A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		DAAD8E3A.Controls.Add(linkLabel1);
		DAAD8E3A.Controls.Add(button3);
		DAAD8E3A.Controls.Add(button2);
		DAAD8E3A.Controls.Add(rbNganCachKyTu);
		DAAD8E3A.Controls.Add(rbNganCachMoiDong);
		DAAD8E3A.Controls.Add(label9);
		DAAD8E3A.Controls.Add(txtComment);
		DAAD8E3A.Controls.Add(label8);
		DAAD8E3A.Controls.Add(EB9A62A7);
		DAAD8E3A.Location = new System.Drawing.Point(48, 227);
		DAAD8E3A.Name = "plComment";
		DAAD8E3A.Size = new System.Drawing.Size(312, 193);
		DAAD8E3A.TabIndex = 10;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.Location = new System.Drawing.Point(191, 126);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(81, 16);
		linkLabel1.TabIndex = 192;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
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
		button2.Click += new System.EventHandler(F4382921);
		rbNganCachKyTu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(70, 168);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		rbNganCachKyTu.TabIndex = 3;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(EEACA023);
		rbNganCachMoiDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(70, 147);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		rbNganCachMoiDong.TabIndex = 3;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += new System.EventHandler(C9A49B04);
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
		txtComment.MouseLeave += new System.EventHandler(txtComment_MouseLeave);
		label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 127);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(143, 16);
		label8.TabIndex = 0;
		label8.Text = "(Spin nội dung {a|b|c})";
		EB9A62A7.AutoSize = true;
		EB9A62A7.Location = new System.Drawing.Point(3, 5);
		EB9A62A7.Name = "lblStatus";
		EB9A62A7.Size = new System.Drawing.Size(139, 16);
		EB9A62A7.TabIndex = 0;
		EB9A62A7.Text = "Nội dung bình luận (0):";
		C03D4B27.AutoSize = true;
		C03D4B27.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C03D4B27.Location = new System.Drawing.Point(27, 80);
		C03D4B27.Name = "label19";
		C03D4B27.Size = new System.Drawing.Size(72, 16);
		C03D4B27.TabIndex = 101;
		C03D4B27.Text = "Sô\u0301 ba\u0300i viết:";
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(30, 203);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(127, 20);
		ckbComment.TabIndex = 9;
		ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		nudDelayTo.Location = new System.Drawing.Point(234, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 6;
		C6A8DCB6.Location = new System.Drawing.Point(234, 78);
		C6A8DCB6.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		C6A8DCB6.Name = "nudSoLuongBaiVietTo";
		C6A8DCB6.Size = new System.Drawing.Size(56, 23);
		C6A8DCB6.TabIndex = 4;
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
		txtTenHanhDong.Size = new System.Drawing.Size(223, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Location = new System.Drawing.Point(199, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(292, 80);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(24, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0300i";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(99, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian delay:";
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
		btnCancel.Location = new System.Drawing.Point(204, 491);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		A71B6216.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A71B6216.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		A71B6216.Cursor = System.Windows.Forms.Cursors.Hand;
		A71B6216.FlatAppearance.BorderSize = 0;
		A71B6216.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A71B6216.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A71B6216.ForeColor = System.Drawing.Color.White;
		A71B6216.Location = new System.Drawing.Point(97, 491);
		A71B6216.Name = "btnAdd";
		A71B6216.Size = new System.Drawing.Size(92, 29);
		A71B6216.TabIndex = 11;
		A71B6216.Text = "Thêm";
		A71B6216.UseVisualStyleBackColor = false;
		A71B6216.Click += new System.EventHandler(EC1F9209);
		A918822F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A918822F.BackColor = System.Drawing.Color.White;
		A918822F.BorderRadius = 0;
		A918822F.BottomSahddow = true;
		A918822F.color = System.Drawing.Color.DarkViolet;
		A918822F.Controls.Add(pnlHeader);
		A918822F.LeftSahddow = false;
		A918822F.Location = new System.Drawing.Point(1, 0);
		A918822F.Name = "bunifuCards1";
		A918822F.RightSahddow = true;
		A918822F.ShadowDepth = 20;
		A918822F.Size = new System.Drawing.Size(390, 37);
		A918822F.TabIndex = 28;
		plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plInteract.Controls.Add(ckbGian);
		plInteract.Controls.Add(ckbBuon);
		plInteract.Controls.Add(ckbWow);
		plInteract.Controls.Add(ckbHaha);
		plInteract.Controls.Add(ckbThuong);
		plInteract.Controls.Add(ckbTym);
		plInteract.Controls.Add(ckbLike);
		plInteract.Controls.Add(CE373DB5);
		plInteract.Controls.Add(label26);
		plInteract.Location = new System.Drawing.Point(48, 162);
		plInteract.Name = "plInteract";
		plInteract.Size = new System.Drawing.Size(312, 33);
		plInteract.TabIndex = 181;
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
		CE373DB5.Controls.Add(A82CCFBF);
		CE373DB5.Controls.Add(EF8F9F95);
		CE373DB5.Location = new System.Drawing.Point(67, 300);
		CE373DB5.Name = "panel7";
		CE373DB5.Size = new System.Drawing.Size(200, 43);
		CE373DB5.TabIndex = 43;
		A82CCFBF.AutoSize = true;
		A82CCFBF.Checked = true;
		A82CCFBF.Cursor = System.Windows.Forms.Cursors.Hand;
		A82CCFBF.Location = new System.Drawing.Point(3, 2);
		A82CCFBF.Name = "radioButton3";
		A82CCFBF.Size = new System.Drawing.Size(201, 20);
		A82CCFBF.TabIndex = 3;
		A82CCFBF.TabStop = true;
		A82CCFBF.Text = "Comment theo thứ tự nội dung";
		A82CCFBF.UseVisualStyleBackColor = true;
		EF8F9F95.AutoSize = true;
		EF8F9F95.Cursor = System.Windows.Forms.Cursors.Hand;
		EF8F9F95.Location = new System.Drawing.Point(3, 23);
		EF8F9F95.Name = "radioButton4";
		EF8F9F95.Size = new System.Drawing.Size(200, 20);
		EF8F9F95.TabIndex = 3;
		EF8F9F95.Text = "Comment ngẫu nhiên nội dung";
		EF8F9F95.UseVisualStyleBackColor = true;
		label26.AutoSize = true;
		label26.Location = new System.Drawing.Point(4, 302);
		label26.Name = "label26";
		label26.Size = new System.Drawing.Size(64, 16);
		label26.TabIndex = 2;
		label26.Text = "Tùy chọn:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(393, 533);
		base.Controls.Add(B827BDBA);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDSpamNewfeed";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(FC1FF487);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		B827BDBA.ResumeLayout(false);
		B827BDBA.PerformLayout();
		A639BB33.ResumeLayout(false);
		A639BB33.PerformLayout();
		DAAD8E3A.ResumeLayout(false);
		DAAD8E3A.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)C6A8DCB6).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).EndInit();
		A918822F.ResumeLayout(false);
		plInteract.ResumeLayout(false);
		plInteract.PerformLayout();
		CE373DB5.ResumeLayout(false);
		CE373DB5.PerformLayout();
		ResumeLayout(false);
	}
}
