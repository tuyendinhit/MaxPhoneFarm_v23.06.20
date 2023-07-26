using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDSpamNhom : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string F4A9660D;

	internal int E38F69B1;

	internal static bool B519430C;

	internal List<CheckBox> list_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl C8832530;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudSoLuongBaiVietTo;

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

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button B3B2B212;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label label8;

	internal Label ECB85601;

	internal CheckBox DE89EB14;

	internal Label D7B78E9F;

	internal NumericUpDown nudSoLuongUidFrom;

	internal Label label68;

	internal Label label19;

	internal NumericUpDown nudSoLuongUidTo;

	internal Label F1B9E782;

	internal RichTextBox txtComment;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton FB13F11E;

	internal Label label9;

	internal Button button3;

	internal Button button2;

	internal LinkLabel linkLabel1;

	internal CheckBox ckbInteract;

	internal Panel plAnh;

	internal TextBox txtPathAnh;

	internal Label label14;

	internal CheckBox ckbAnh;

	internal Panel CDA81485;

	internal CheckBox ckbGian;

	internal CheckBox B6144832;

	internal CheckBox ckbWow;

	internal CheckBox ckbHaha;

	internal CheckBox FE0DB10E;

	internal CheckBox ckbTym;

	internal CheckBox BAB80A33;

	internal Panel panel7;

	internal RadioButton radioButton3;

	internal RadioButton radioButton4;

	internal Label label26;

	public fHDSpamNhom(string string_2, int E73C99A1 = 0, string string_3 = "")
	{
		InitializeComponent();
		Language.SetLanguage(this);
		B519430C = false;
		string_0 = string_2;
		F4A9660D = string_3;
		E38F69B1 = E73C99A1;
		if (Class123.C7BE863B("", "HDSpamNhom").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDSpamNhom', 'Spam nhóm');");
		}
		string d399C = "";
		switch (E73C99A1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDSpamNhom");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
	}

	private void fHDSpamNhom_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongUidFrom.Value = f72FAFBC_0.method_0("nudSoLuongUidFrom", 1);
			nudSoLuongUidTo.Value = f72FAFBC_0.method_0("nudSoLuongUidTo", 1);
			nudSoLuongBaiVietFrom.Value = f72FAFBC_0.method_0("nudSoLuongBaiVietFrom", 1);
			nudSoLuongBaiVietTo.Value = f72FAFBC_0.method_0("nudSoLuongBaiVietTo", 1);
			nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			string text = f72FAFBC_0.GetValue("typeReaction");
			list_0 = new List<CheckBox> { BAB80A33, ckbTym, FE0DB10E, ckbHaha, ckbWow, B6144832, ckbGian };
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].Checked = text.Contains(i.ToString());
			}
			DE89EB14.Checked = f72FAFBC_0.AA824D29("ckbComment");
			txtComment.Text = f72FAFBC_0.GetValue("txtComment");
			if (f72FAFBC_0.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				FB13F11E.Checked = true;
			}
			ckbAnh.Checked = f72FAFBC_0.AA824D29("ckbAnh");
			txtPathAnh.Text = f72FAFBC_0.GetValue("txtPathAnh");
		}
		catch
		{
		}
		method_2();
	}

	private void B3B2B212_Click(object sender, EventArgs e)
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
		if (DE89EB14.Checked)
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
		f72FAFBC.GetValue("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		f72FAFBC.GetValue("nudSoLuongUidTo", nudSoLuongUidTo.Value);
		f72FAFBC.GetValue("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		f72FAFBC.GetValue("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			text2 += (list_0[i].Checked ? (i.ToString() ?? "") : "");
		}
		f72FAFBC.GetValue("typeReaction", (object)text2);
		f72FAFBC.GetValue("ckbComment", DE89EB14.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		f72FAFBC.GetValue("ckbAnh", ckbAnh.Checked);
		f72FAFBC.GetValue("txtPathAnh", (object)txtPathAnh.Text.Trim());
		string text3 = f72FAFBC.C71A4EA4();
		if (E38F69B1 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text3))
				{
					B519430C = true;
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
			if (Class123.smethod_14(F4A9660D, text, text3))
			{
				B519430C = true;
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
			list = ((!FB13F11E.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			ECB85601.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_2()
	{
		ckbInteract_CheckedChanged(null, null);
		FF229D08(null, null);
		F02A0F94(null, null);
	}

	private void FF229D08(object sender, EventArgs e)
	{
		plComment.Enabled = DE89EB14.Checked;
	}

	private void FD224D04(object sender, EventArgs e)
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

	private void CB1C0785(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void BB04069D(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Chú ý: Nếu là ID Fanpage thì cần thêm /posts vào sau ID.") + "\r\n" + Language.GetValue("Ví dụ") + ": 15465478242/posts");
	}

	private void FB13F11E_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void CA1D6F9F(object sender, EventArgs e)
	{
		method_1();
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		CDA81485.Enabled = ckbInteract.Checked;
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void F02A0F94(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnh.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDSpamNhom));
		C8832530 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		B3B2B212 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plAnh = new System.Windows.Forms.Panel();
		txtPathAnh = new System.Windows.Forms.TextBox();
		label14 = new System.Windows.Forms.Label();
		ckbAnh = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		plComment = new System.Windows.Forms.Panel();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		button3 = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		FB13F11E = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		txtComment = new System.Windows.Forms.RichTextBox();
		label8 = new System.Windows.Forms.Label();
		ECB85601 = new System.Windows.Forms.Label();
		D7B78E9F = new System.Windows.Forms.Label();
		nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		label68 = new System.Windows.Forms.Label();
		label19 = new System.Windows.Forms.Label();
		nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
		F1B9E782 = new System.Windows.Forms.Label();
		DE89EB14 = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
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
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		CDA81485 = new System.Windows.Forms.Panel();
		ckbGian = new System.Windows.Forms.CheckBox();
		B6144832 = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		FE0DB10E = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		BAB80A33 = new System.Windows.Forms.CheckBox();
		panel7 = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		radioButton4 = new System.Windows.Forms.RadioButton();
		label26 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plAnh.SuspendLayout();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		CDA81485.SuspendLayout();
		panel7.SuspendLayout();
		SuspendLayout();
		C8832530.Fixed = true;
		C8832530.Horizontal = true;
		C8832530.TargetControl = bunifuCustomLabel1;
		C8832530.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(391, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Spam nhóm";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(B3B2B212);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(391, 31);
		pnlHeader.TabIndex = 9;
		B3B2B212.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B3B2B212.Cursor = System.Windows.Forms.Cursors.Hand;
		B3B2B212.FlatAppearance.BorderSize = 0;
		B3B2B212.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B3B2B212.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B3B2B212.ForeColor = System.Drawing.Color.White;
		B3B2B212.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		B3B2B212.Location = new System.Drawing.Point(360, 1);
		B3B2B212.Name = "button1";
		B3B2B212.Size = new System.Drawing.Size(30, 30);
		B3B2B212.TabIndex = 77;
		B3B2B212.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B3B2B212.UseVisualStyleBackColor = true;
		B3B2B212.Click += new System.EventHandler(B3B2B212_Click);
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
		panel1.Controls.Add(CDA81485);
		panel1.Controls.Add(plAnh);
		panel1.Controls.Add(ckbAnh);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(D7B78E9F);
		panel1.Controls.Add(nudSoLuongUidFrom);
		panel1.Controls.Add(label68);
		panel1.Controls.Add(label19);
		panel1.Controls.Add(nudSoLuongUidTo);
		panel1.Controls.Add(F1B9E782);
		panel1.Controls.Add(DE89EB14);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudSoLuongBaiVietTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(nudSoLuongBaiVietFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(394, 566);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(txtPathAnh);
		plAnh.Controls.Add(label14);
		plAnh.Location = new System.Drawing.Point(47, 478);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(313, 31);
		plAnh.TabIndex = 176;
		txtPathAnh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtPathAnh.Location = new System.Drawing.Point(90, 3);
		txtPathAnh.Name = "txtPathAnh";
		txtPathAnh.Size = new System.Drawing.Size(218, 23);
		txtPathAnh.TabIndex = 1;
		label14.AutoSize = true;
		label14.Location = new System.Drawing.Point(3, 6);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(88, 16);
		label14.TabIndex = 0;
		label14.Text = "Thư mu\u0323c ảnh:";
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAnh.Location = new System.Drawing.Point(30, 454);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new System.Drawing.Size(103, 20);
		ckbAnh.TabIndex = 175;
		ckbAnh.Text = "Bình luận ảnh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += new System.EventHandler(F02A0F94);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 166);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(112, 20);
		ckbInteract.TabIndex = 169;
		ckbInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(linkLabel1);
		plComment.Controls.Add(button3);
		plComment.Controls.Add(button2);
		plComment.Controls.Add(rbNganCachKyTu);
		plComment.Controls.Add(FB13F11E);
		plComment.Controls.Add(label9);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(ECB85601);
		plComment.Location = new System.Drawing.Point(48, 257);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(312, 193);
		plComment.TabIndex = 10;
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
		button3.Click += new System.EventHandler(CB1C0785);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(229, 145);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 23);
		button2.TabIndex = 4;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		rbNganCachKyTu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(70, 168);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		rbNganCachKyTu.TabIndex = 3;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(CA1D6F9F);
		FB13F11E.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		FB13F11E.AutoSize = true;
		FB13F11E.Checked = true;
		FB13F11E.Cursor = System.Windows.Forms.Cursors.Hand;
		FB13F11E.Location = new System.Drawing.Point(70, 147);
		FB13F11E.Name = "rbNganCachMoiDong";
		FB13F11E.Size = new System.Drawing.Size(155, 20);
		FB13F11E.TabIndex = 3;
		FB13F11E.TabStop = true;
		FB13F11E.Text = "Nội dung chỉ có 1 dòng";
		FB13F11E.UseVisualStyleBackColor = true;
		FB13F11E.CheckedChanged += new System.EventHandler(FB13F11E_CheckedChanged);
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
		txtComment.MouseLeave += new System.EventHandler(FD224D04);
		label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 127);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(143, 16);
		label8.TabIndex = 0;
		label8.Text = "(Spin nội dung {a|b|c})";
		ECB85601.AutoSize = true;
		ECB85601.Location = new System.Drawing.Point(3, 5);
		ECB85601.Name = "lblStatus";
		ECB85601.Size = new System.Drawing.Size(139, 16);
		ECB85601.TabIndex = 0;
		ECB85601.Text = "Nội dung bình luận (0):";
		D7B78E9F.AutoSize = true;
		D7B78E9F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D7B78E9F.Location = new System.Drawing.Point(27, 81);
		D7B78E9F.Name = "label49";
		D7B78E9F.Size = new System.Drawing.Size(99, 16);
		D7B78E9F.TabIndex = 92;
		D7B78E9F.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongUidFrom.Location = new System.Drawing.Point(137, 79);
		nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongUidFrom.TabIndex = 1;
		nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label68.AutoSize = true;
		label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label68.Location = new System.Drawing.Point(292, 81);
		label68.Name = "label68";
		label68.Size = new System.Drawing.Size(39, 16);
		label68.TabIndex = 99;
		label68.Text = "nhóm";
		label19.AutoSize = true;
		label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label19.Location = new System.Drawing.Point(27, 110);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(109, 16);
		label19.TabIndex = 101;
		label19.Text = "Sô\u0301 ba\u0300i viết/nhóm:";
		nudSoLuongUidTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongUidTo.Location = new System.Drawing.Point(234, 79);
		nudSoLuongUidTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidTo.Name = "nudSoLuongUidTo";
		nudSoLuongUidTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongUidTo.TabIndex = 2;
		nudSoLuongUidTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		F1B9E782.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F1B9E782.Location = new System.Drawing.Point(199, 81);
		F1B9E782.Name = "label66";
		F1B9E782.Size = new System.Drawing.Size(29, 16);
		F1B9E782.TabIndex = 105;
		F1B9E782.Text = "đê\u0301n";
		F1B9E782.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DE89EB14.AutoSize = true;
		DE89EB14.Cursor = System.Windows.Forms.Cursors.Hand;
		DE89EB14.Location = new System.Drawing.Point(30, 233);
		DE89EB14.Name = "ckbComment";
		DE89EB14.Size = new System.Drawing.Size(127, 20);
		DE89EB14.TabIndex = 9;
		DE89EB14.Text = "Bi\u0300nh luâ\u0323n văn bản";
		DE89EB14.UseVisualStyleBackColor = true;
		DE89EB14.CheckedChanged += new System.EventHandler(FF229D08);
		nudDelayTo.Location = new System.Drawing.Point(234, 137);
		nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 6;
		nudSoLuongBaiVietTo.Location = new System.Drawing.Point(234, 108);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(137, 137);
		nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(137, 108);
		nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(137, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(223, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Location = new System.Drawing.Point(199, 139);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Location = new System.Drawing.Point(199, 110);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(292, 139);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(292, 110);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(24, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0300i";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 139);
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
		btnCancel.Location = new System.Drawing.Point(205, 524);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
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
		btnAdd.Location = new System.Drawing.Point(98, 524);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 11;
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
		bunifuCards1.Size = new System.Drawing.Size(391, 37);
		bunifuCards1.TabIndex = 28;
		CDA81485.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		CDA81485.Controls.Add(ckbGian);
		CDA81485.Controls.Add(B6144832);
		CDA81485.Controls.Add(ckbWow);
		CDA81485.Controls.Add(ckbHaha);
		CDA81485.Controls.Add(FE0DB10E);
		CDA81485.Controls.Add(ckbTym);
		CDA81485.Controls.Add(BAB80A33);
		CDA81485.Controls.Add(panel7);
		CDA81485.Controls.Add(label26);
		CDA81485.Location = new System.Drawing.Point(48, 192);
		CDA81485.Name = "plInteract";
		CDA81485.Size = new System.Drawing.Size(312, 33);
		CDA81485.TabIndex = 181;
		ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGian.Image = Resource.Bitmap_5;
		ckbGian.Location = new System.Drawing.Point(266, 1);
		ckbGian.Name = "ckbGian";
		ckbGian.Size = new System.Drawing.Size(40, 30);
		ckbGian.TabIndex = 179;
		ckbGian.UseVisualStyleBackColor = true;
		B6144832.Cursor = System.Windows.Forms.Cursors.Hand;
		B6144832.Image = Resource.Bitmap_174;
		B6144832.Location = new System.Drawing.Point(222, 1);
		B6144832.Name = "ckbBuon";
		B6144832.Size = new System.Drawing.Size(40, 30);
		B6144832.TabIndex = 178;
		B6144832.UseVisualStyleBackColor = true;
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
		FE0DB10E.Cursor = System.Windows.Forms.Cursors.Hand;
		FE0DB10E.Image = Resource.DD3ED6B8;
		FE0DB10E.Location = new System.Drawing.Point(90, 1);
		FE0DB10E.Name = "ckbThuong";
		FE0DB10E.Size = new System.Drawing.Size(40, 30);
		FE0DB10E.TabIndex = 175;
		FE0DB10E.UseVisualStyleBackColor = true;
		ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTym.Image = Resource.C8AF3BB6;
		ckbTym.Location = new System.Drawing.Point(46, 1);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new System.Drawing.Size(40, 30);
		ckbTym.TabIndex = 174;
		ckbTym.UseVisualStyleBackColor = true;
		BAB80A33.Checked = true;
		BAB80A33.CheckState = System.Windows.Forms.CheckState.Checked;
		BAB80A33.Cursor = System.Windows.Forms.Cursors.Hand;
		BAB80A33.Image = Resource.Bitmap_163;
		BAB80A33.Location = new System.Drawing.Point(2, 1);
		BAB80A33.Name = "ckbLike";
		BAB80A33.Size = new System.Drawing.Size(40, 30);
		BAB80A33.TabIndex = 173;
		BAB80A33.UseVisualStyleBackColor = true;
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
		label26.AutoSize = true;
		label26.Location = new System.Drawing.Point(4, 302);
		label26.Name = "label26";
		label26.Size = new System.Drawing.Size(64, 16);
		label26.TabIndex = 2;
		label26.Text = "Tùy chọn:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(394, 566);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDSpamNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDSpamNhom_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		CDA81485.ResumeLayout(false);
		CDA81485.PerformLayout();
		panel7.ResumeLayout(false);
		panel7.PerformLayout();
		ResumeLayout(false);
	}
}
