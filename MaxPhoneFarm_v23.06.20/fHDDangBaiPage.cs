using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangBaiPage : Form
{
	internal JSON_Settings DB159813;

	internal string D99C9432;

	internal string string_0;

	internal string E5385D27;

	internal int int_0;

	internal static bool BF3FA92A;

	internal IContainer B897F082 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label F632B600;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button A2A58132;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal CheckBox ckbVanBan;

	internal Panel plVanBan;

	internal Label C93A5C94;

	internal Label B0306306;

	internal RichTextBox txtNoiDung;

	internal RadioButton CBBC4290;

	internal RadioButton BE2E7010;

	internal Label label9;

	internal CheckBox F69D5137;

	internal Label label19;

	internal Label label20;

	internal NumericUpDown nudKhoangCachTo;

	internal NumericUpDown C337BAA9;

	internal Label B9125AA5;

	internal Label label17;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown CE99F024;

	internal Label EAAD769B;

	internal Label label15;

	internal CheckBox E4BA21AF;

	internal LinkLabel FA29662F;

	internal Button button3;

	internal Button button2;

	internal CheckBox E730C3A0;

	internal Panel plNhomChiDinh;

	internal CheckBox ckbTuDongXoaUid;

	internal Label label12;

	internal RichTextBox A2AAC317;

	internal Panel AA9BC098;

	internal RadioButton rbNhomChiDinh;

	internal RadioButton rbNhomNgauNhien;

	internal Label label2;

	internal Panel plAnh;

	internal NumericUpDown nudSoLuongAnhTo;

	internal NumericUpDown nudSoLuongAnhFrom;

	internal TextBox txtPathAnh;

	internal Label label10;

	internal Label label4;

	internal Label FB22EF00;

	internal Label label5;

	internal CheckBox ckbAnh;

	internal CheckBox ckbXoaAnhDaDang;

	internal CheckBox ckbHashtag;

	internal Panel plHashtag;

	internal RichTextBox txtHashtag;

	internal Label E39B2EBF;

	internal Label label6;

	internal NumericUpDown nudSoHashtagFrom;

	internal Label EBA74716;

	internal NumericUpDown nudSoHashtagTo;

	internal Label label7;

	internal Button btnDown;

	internal Button btnUp;

	public fHDDangBaiPage(string CF293CB5, int int_1 = 0, string string_1 = "")
	{
		InitializeComponent();
		BF3FA92A = false;
		D99C9432 = CF293CB5;
		E5385D27 = string_1;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đăng ba\u0300i lên page";
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
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_1);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		DB159813 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(F632B600);
		Language.smethod_1(label15);
		Language.smethod_1(label17);
		Language.smethod_1(B9125AA5);
		Language.smethod_1(EAAD769B);
		Language.smethod_1(label20);
		Language.smethod_1(label19);
		Language.smethod_1(ckbVanBan);
		Language.smethod_1(B0306306);
		Language.smethod_1(C93A5C94);
		Language.smethod_1(F69D5137);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
		Language.smethod_1(E730C3A0);
		Language.smethod_1(label9);
		Language.smethod_1(BE2E7010);
		Language.smethod_1(CBBC4290);
		Language.smethod_1(E4BA21AF);
	}

	private void fHDDangBaiPage_Load(object sender, EventArgs e)
	{
		try
		{
			CE99F024.Value = DB159813.method_0("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = DB159813.method_0("nudSoLuongTo", 1);
			C337BAA9.Value = DB159813.method_0("nudKhoangCachFrom", 5);
			nudKhoangCachTo.Value = DB159813.method_0("nudKhoangCachTo", 10);
			if (DB159813.method_0("typeNhom") == 0)
			{
				rbNhomNgauNhien.Checked = true;
			}
			else
			{
				rbNhomChiDinh.Checked = true;
			}
			E730C3A0.Checked = DB159813.AA824D29("ckbChiDangNhomKKD");
			A2AAC317.Text = DB159813.GetValue("txtIdNhomChiDinh");
			ckbTuDongXoaUid.Checked = DB159813.AA824D29("ckbTuDongXoaUid");
			ckbVanBan.Checked = DB159813.AA824D29("ckbVanBan");
			F69D5137.Checked = DB159813.AA824D29("ckbUseBackground");
			E4BA21AF.Checked = DB159813.AA824D29("ckbXoaNguyenLieuDaDung");
			txtNoiDung.Text = DB159813.GetValue("txtNoiDung");
			if (DB159813.method_0("typeNganCach") == 1)
			{
				CBBC4290.Checked = true;
			}
			else
			{
				BE2E7010.Checked = true;
			}
			ckbHashtag.Checked = DB159813.AA824D29("ckbHashtag");
			txtHashtag.Text = DB159813.GetValue("txtHashtag");
			nudSoHashtagFrom.Value = DB159813.method_0("nudSoHashtagFrom", 1);
			nudSoHashtagTo.Value = DB159813.method_0("nudSoHashtagTo", 1);
			ckbAnh.Checked = DB159813.AA824D29("ckbAnh");
			txtPathAnh.Text = DB159813.GetValue("txtPathAnh");
			ckbXoaAnhDaDang.Checked = DB159813.AA824D29("ckbXoaAnhDaDang");
			nudSoLuongAnhFrom.Value = DB159813.method_0("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = DB159813.method_0("nudSoLuongAnhTo", 1);
		}
		catch (Exception)
		{
		}
		method_1();
	}

	private void A2A58132_Click(object sender, EventArgs e)
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
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", CE99F024.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudKhoangCachFrom", C337BAA9.Value);
		f72FAFBC.GetValue("nudKhoangCachTo", nudKhoangCachTo.Value);
		if (rbNhomNgauNhien.Checked)
		{
			f72FAFBC.GetValue("typeNhom", 0);
		}
		else
		{
			f72FAFBC.GetValue("typeNhom", 1);
		}
		f72FAFBC.GetValue("txtIdNhomChiDinh", (object)A2AAC317.Text.Trim());
		f72FAFBC.GetValue("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		f72FAFBC.GetValue("ckbChiDangNhomKKD", E730C3A0.Checked);
		f72FAFBC.GetValue("ckbVanBan", ckbVanBan.Checked);
		f72FAFBC.GetValue("ckbUseBackground", F69D5137.Checked);
		f72FAFBC.GetValue("ckbXoaNguyenLieuDaDung", E4BA21AF.Checked);
		f72FAFBC.GetValue("txtNoiDung", (object)txtNoiDung.Text.Trim());
		int num = 0;
		if (CBBC4290.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		f72FAFBC.GetValue("ckbHashtag", ckbHashtag.Checked);
		f72FAFBC.GetValue("txtHashtag", (object)txtHashtag.Text.Trim());
		f72FAFBC.GetValue("nudSoHashtagFrom", nudSoHashtagFrom.Value);
		f72FAFBC.GetValue("nudSoHashtagTo", nudSoHashtagTo.Value);
		f72FAFBC.GetValue("ckbAnh", ckbAnh.Checked);
		f72FAFBC.GetValue("txtPathAnh", (object)txtPathAnh.Text.Trim());
		f72FAFBC.GetValue("ckbXoaAnhDaDang", ckbXoaAnhDaDang.Checked);
		f72FAFBC.GetValue("nudSoLuongAnhFrom", nudSoLuongAnhFrom.Value);
		f72FAFBC.GetValue("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(D99C9432, text, string_0, text2))
				{
					BF3FA92A = true;
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
			if (Class123.smethod_14(E5385D27, text, text2))
			{
				BF3FA92A = true;
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

	private void method_1()
	{
		ckbVanBan_CheckedChanged(null, null);
		CFBE5A33(null, null);
		rbNhomNgauNhien_CheckedChanged(null, null);
		rbNhomChiDinh_CheckedChanged(null, null);
	}

	private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = ckbVanBan.Checked;
		if (!ckbVanBan.Checked)
		{
			F69D5137.Checked = false;
		}
	}

	private void DA07472E(object sender, EventArgs e)
	{
		BC06E29F();
	}

	private void BC06E29F()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!BE2E7010.Checked) ? txtNoiDung.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtNoiDung.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			B0306306.Text = string.Format(Language.GetValue("Danh sa\u0301ch nô\u0323i dung ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void D1974239(object sender, EventArgs e)
	{
		BC06E29F();
	}

	private void CBBC4290_CheckedChanged(object sender, EventArgs e)
	{
		BC06E29F();
	}

	private void F69D5137_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void BD017796(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	private void CC91C3B7(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
	}

	private void rbNhomNgauNhien_CheckedChanged(object sender, EventArgs e)
	{
		AA9BC098.Enabled = rbNhomNgauNhien.Checked;
	}

	private void rbNhomChiDinh_CheckedChanged(object sender, EventArgs e)
	{
		plNhomChiDinh.Enabled = rbNhomChiDinh.Checked;
	}

	private void A2AAC317_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(A2AAC317, label12);
	}

	private void CFBE5A33(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnh.Checked;
		F69D5137.Enabled = !ckbAnh.Checked;
		if (ckbAnh.Checked)
		{
			F69D5137.Checked = false;
		}
	}

	private void FE053199(object sender, EventArgs e)
	{
		plVanBan.Height = 392;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plVanBan.Height = 247;
	}

	private void ckbHashtag_CheckedChanged(object sender, EventArgs e)
	{
		plHashtag.Enabled = ckbHashtag.Checked;
	}

	private void txtHashtag_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtHashtag, E39B2EBF);
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && B897F082 != null)
		{
			B897F082.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		B897F082 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangBaiPage));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(B897F082);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(B897F082);
		pnlHeader = new System.Windows.Forms.Panel();
		A2A58132 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plVanBan = new System.Windows.Forms.Panel();
		btnDown = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		ckbHashtag = new System.Windows.Forms.CheckBox();
		plHashtag = new System.Windows.Forms.Panel();
		txtHashtag = new System.Windows.Forms.RichTextBox();
		E39B2EBF = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		nudSoHashtagFrom = new System.Windows.Forms.NumericUpDown();
		EBA74716 = new System.Windows.Forms.Label();
		nudSoHashtagTo = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		FA29662F = new System.Windows.Forms.LinkLabel();
		button3 = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		CBBC4290 = new System.Windows.Forms.RadioButton();
		BE2E7010 = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		txtNoiDung = new System.Windows.Forms.RichTextBox();
		C93A5C94 = new System.Windows.Forms.Label();
		B0306306 = new System.Windows.Forms.Label();
		F69D5137 = new System.Windows.Forms.CheckBox();
		E4BA21AF = new System.Windows.Forms.CheckBox();
		plAnh = new System.Windows.Forms.Panel();
		ckbXoaAnhDaDang = new System.Windows.Forms.CheckBox();
		nudSoLuongAnhTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongAnhFrom = new System.Windows.Forms.NumericUpDown();
		txtPathAnh = new System.Windows.Forms.TextBox();
		label10 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		FB22EF00 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		ckbAnh = new System.Windows.Forms.CheckBox();
		label19 = new System.Windows.Forms.Label();
		label20 = new System.Windows.Forms.Label();
		AA9BC098 = new System.Windows.Forms.Panel();
		E730C3A0 = new System.Windows.Forms.CheckBox();
		nudKhoangCachTo = new System.Windows.Forms.NumericUpDown();
		C337BAA9 = new System.Windows.Forms.NumericUpDown();
		B9125AA5 = new System.Windows.Forms.Label();
		label17 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		CE99F024 = new System.Windows.Forms.NumericUpDown();
		EAAD769B = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		btnAdd = new System.Windows.Forms.Button();
		ckbVanBan = new System.Windows.Forms.CheckBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		F632B600 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		plNhomChiDinh = new System.Windows.Forms.Panel();
		ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		label12 = new System.Windows.Forms.Label();
		A2AAC317 = new System.Windows.Forms.RichTextBox();
		rbNhomChiDinh = new System.Windows.Forms.RadioButton();
		rbNhomNgauNhien = new System.Windows.Forms.RadioButton();
		label2 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plVanBan.SuspendLayout();
		plHashtag.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoHashtagFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoHashtagTo).BeginInit();
		plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhFrom).BeginInit();
		AA9BC098.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)C337BAA9).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)CE99F024).BeginInit();
		bunifuCards1.SuspendLayout();
		plNhomChiDinh.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(674, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đăng ba\u0300i lên page";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(A2A58132);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(674, 31);
		pnlHeader.TabIndex = 9;
		A2A58132.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		A2A58132.Cursor = System.Windows.Forms.Cursors.Hand;
		A2A58132.FlatAppearance.BorderSize = 0;
		A2A58132.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A2A58132.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A2A58132.ForeColor = System.Drawing.Color.White;
		A2A58132.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		A2A58132.Location = new System.Drawing.Point(643, 1);
		A2A58132.Name = "button1";
		A2A58132.Size = new System.Drawing.Size(30, 30);
		A2A58132.TabIndex = 0;
		A2A58132.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		A2A58132.UseVisualStyleBackColor = true;
		A2A58132.Click += new System.EventHandler(A2A58132_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(plVanBan);
		panel1.Controls.Add(plAnh);
		panel1.Controls.Add(ckbAnh);
		panel1.Controls.Add(label19);
		panel1.Controls.Add(label20);
		panel1.Controls.Add(AA9BC098);
		panel1.Controls.Add(nudKhoangCachTo);
		panel1.Controls.Add(C337BAA9);
		panel1.Controls.Add(B9125AA5);
		panel1.Controls.Add(label17);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(CE99F024);
		panel1.Controls.Add(EAAD769B);
		panel1.Controls.Add(label15);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(ckbVanBan);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(F632B600);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(bunifuCards1);
		panel1.Controls.Add(plNhomChiDinh);
		panel1.Controls.Add(rbNhomChiDinh);
		panel1.Controls.Add(rbNhomNgauNhien);
		panel1.Controls.Add(label2);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(677, 551);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plVanBan.Controls.Add(btnDown);
		plVanBan.Controls.Add(btnUp);
		plVanBan.Controls.Add(ckbHashtag);
		plVanBan.Controls.Add(plHashtag);
		plVanBan.Controls.Add(FA29662F);
		plVanBan.Controls.Add(button3);
		plVanBan.Controls.Add(button2);
		plVanBan.Controls.Add(CBBC4290);
		plVanBan.Controls.Add(BE2E7010);
		plVanBan.Controls.Add(label9);
		plVanBan.Controls.Add(txtNoiDung);
		plVanBan.Controls.Add(C93A5C94);
		plVanBan.Controls.Add(B0306306);
		plVanBan.Controls.Add(F69D5137);
		plVanBan.Controls.Add(E4BA21AF);
		plVanBan.Location = new System.Drawing.Point(47, 158);
		plVanBan.Name = "plVanBan";
		plVanBan.Size = new System.Drawing.Size(597, 247);
		plVanBan.TabIndex = 33;
		btnDown.BackgroundImage = Resource.Bitmap_91;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.Location = new System.Drawing.Point(535, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 198;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Click += new System.EventHandler(FE053199);
		btnUp.BackgroundImage = Resource.Bitmap_73;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.Location = new System.Drawing.Point(566, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 199;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Click += new System.EventHandler(btnUp_Click);
		ckbHashtag.AutoSize = true;
		ckbHashtag.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHashtag.Location = new System.Drawing.Point(6, 247);
		ckbHashtag.Name = "ckbHashtag";
		ckbHashtag.Size = new System.Drawing.Size(101, 20);
		ckbHashtag.TabIndex = 196;
		ckbHashtag.Text = "Kèm Hashtag";
		ckbHashtag.UseVisualStyleBackColor = true;
		ckbHashtag.CheckedChanged += new System.EventHandler(ckbHashtag_CheckedChanged);
		plHashtag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plHashtag.Controls.Add(txtHashtag);
		plHashtag.Controls.Add(E39B2EBF);
		plHashtag.Controls.Add(label6);
		plHashtag.Controls.Add(nudSoHashtagFrom);
		plHashtag.Controls.Add(EBA74716);
		plHashtag.Controls.Add(nudSoHashtagTo);
		plHashtag.Controls.Add(label7);
		plHashtag.Location = new System.Drawing.Point(22, 267);
		plHashtag.Name = "plHashtag";
		plHashtag.Size = new System.Drawing.Size(570, 120);
		plHashtag.TabIndex = 197;
		txtHashtag.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtHashtag.Location = new System.Drawing.Point(7, 22);
		txtHashtag.Name = "txtHashtag";
		txtHashtag.Size = new System.Drawing.Size(555, 66);
		txtHashtag.TabIndex = 34;
		txtHashtag.Text = "";
		txtHashtag.WordWrap = false;
		txtHashtag.TextChanged += new System.EventHandler(txtHashtag_TextChanged);
		E39B2EBF.AutoSize = true;
		E39B2EBF.Location = new System.Drawing.Point(3, 3);
		E39B2EBF.Name = "lblHashtag";
		E39B2EBF.Size = new System.Drawing.Size(141, 16);
		E39B2EBF.TabIndex = 0;
		E39B2EBF.Text = "Danh sa\u0301ch hashtag (0):";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(3, 94);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(166, 16);
		label6.TabIndex = 35;
		label6.Text = "Số lượng hashtag/nội dung:";
		nudSoHashtagFrom.Location = new System.Drawing.Point(169, 92);
		nudSoHashtagFrom.Name = "nudSoHashtagFrom";
		nudSoHashtagFrom.Size = new System.Drawing.Size(51, 23);
		nudSoHashtagFrom.TabIndex = 40;
		EBA74716.AutoSize = true;
		EBA74716.Location = new System.Drawing.Point(307, 94);
		EBA74716.Name = "label11";
		EBA74716.Size = new System.Drawing.Size(52, 16);
		EBA74716.TabIndex = 43;
		EBA74716.Text = "hashtag";
		nudSoHashtagTo.Location = new System.Drawing.Point(254, 92);
		nudSoHashtagTo.Name = "nudSoHashtagTo";
		nudSoHashtagTo.Size = new System.Drawing.Size(51, 23);
		nudSoHashtagTo.TabIndex = 41;
		label7.Location = new System.Drawing.Point(223, 94);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 42;
		label7.Text = "đến";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FA29662F.AutoSize = true;
		FA29662F.Cursor = System.Windows.Forms.Cursors.Hand;
		FA29662F.Location = new System.Drawing.Point(154, 198);
		FA29662F.Name = "linkLabel1";
		FA29662F.Size = new System.Drawing.Size(81, 16);
		FA29662F.TabIndex = 195;
		FA29662F.TabStop = true;
		FA29662F.Text = "Random icon";
		FA29662F.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(BD017796);
		button3.Cursor = System.Windows.Forms.Cursors.Help;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(571, 220);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(21, 23);
		button3.TabIndex = 193;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(CC91C3B7);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(571, 197);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 23);
		button2.TabIndex = 194;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		CBBC4290.AutoSize = true;
		CBBC4290.Cursor = System.Windows.Forms.Cursors.Hand;
		CBBC4290.Location = new System.Drawing.Point(412, 221);
		CBBC4290.Name = "rbNganCachKyTu";
		CBBC4290.Size = new System.Drawing.Size(159, 20);
		CBBC4290.TabIndex = 37;
		CBBC4290.Text = "Nội dung có nhiều dòng";
		CBBC4290.UseVisualStyleBackColor = true;
		CBBC4290.CheckedChanged += new System.EventHandler(CBBC4290_CheckedChanged);
		BE2E7010.AutoSize = true;
		BE2E7010.Checked = true;
		BE2E7010.Cursor = System.Windows.Forms.Cursors.Hand;
		BE2E7010.Location = new System.Drawing.Point(412, 199);
		BE2E7010.Name = "rbNganCachMoiDong";
		BE2E7010.Size = new System.Drawing.Size(155, 20);
		BE2E7010.TabIndex = 36;
		BE2E7010.TabStop = true;
		BE2E7010.Text = "Nội dung chỉ có 1 dòng";
		BE2E7010.UseVisualStyleBackColor = true;
		BE2E7010.CheckedChanged += new System.EventHandler(D1974239);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(347, 199);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(64, 16);
		label9.TabIndex = 35;
		label9.Text = "Tùy chọn:";
		txtNoiDung.Location = new System.Drawing.Point(7, 24);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new System.Drawing.Size(585, 172);
		txtNoiDung.TabIndex = 34;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += new System.EventHandler(DA07472E);
		C93A5C94.AutoSize = true;
		C93A5C94.Location = new System.Drawing.Point(4, 198);
		C93A5C94.Name = "label8";
		C93A5C94.Size = new System.Drawing.Size(143, 16);
		C93A5C94.TabIndex = 0;
		C93A5C94.Text = "(Spin nội dung {a|b|c})";
		B0306306.AutoSize = true;
		B0306306.Location = new System.Drawing.Point(3, 5);
		B0306306.Name = "lblStatus";
		B0306306.Size = new System.Drawing.Size(145, 16);
		B0306306.TabIndex = 0;
		B0306306.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		F69D5137.AutoSize = true;
		F69D5137.Cursor = System.Windows.Forms.Cursors.Hand;
		F69D5137.Location = new System.Drawing.Point(6, 221);
		F69D5137.Name = "ckbUseBackground";
		F69D5137.Size = new System.Drawing.Size(144, 20);
		F69D5137.TabIndex = 32;
		F69D5137.Text = "Sử dụng Background";
		F69D5137.UseVisualStyleBackColor = true;
		F69D5137.CheckedChanged += new System.EventHandler(F69D5137_CheckedChanged);
		E4BA21AF.AutoSize = true;
		E4BA21AF.Cursor = System.Windows.Forms.Cursors.Hand;
		E4BA21AF.Location = new System.Drawing.Point(157, 221);
		E4BA21AF.Name = "ckbXoaNguyenLieuDaDung";
		E4BA21AF.Size = new System.Drawing.Size(151, 20);
		E4BA21AF.TabIndex = 32;
		E4BA21AF.Text = "Xóa nội dung đã đăng";
		E4BA21AF.UseVisualStyleBackColor = true;
		E4BA21AF.CheckedChanged += new System.EventHandler(ckbVanBan_CheckedChanged);
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(ckbXoaAnhDaDang);
		plAnh.Controls.Add(nudSoLuongAnhTo);
		plAnh.Controls.Add(nudSoLuongAnhFrom);
		plAnh.Controls.Add(txtPathAnh);
		plAnh.Controls.Add(label10);
		plAnh.Controls.Add(label4);
		plAnh.Controls.Add(FB22EF00);
		plAnh.Controls.Add(label5);
		plAnh.Location = new System.Drawing.Point(47, 434);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(597, 58);
		plAnh.TabIndex = 60;
		ckbXoaAnhDaDang.AutoSize = true;
		ckbXoaAnhDaDang.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaAnhDaDang.Location = new System.Drawing.Point(466, 5);
		ckbXoaAnhDaDang.Name = "ckbXoaAnhDaDang";
		ckbXoaAnhDaDang.Size = new System.Drawing.Size(123, 20);
		ckbXoaAnhDaDang.TabIndex = 33;
		ckbXoaAnhDaDang.Text = "Xóa ảnh đã đăng";
		ckbXoaAnhDaDang.UseVisualStyleBackColor = true;
		nudSoLuongAnhTo.Location = new System.Drawing.Point(191, 30);
		nudSoLuongAnhTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
		nudSoLuongAnhTo.Size = new System.Drawing.Size(45, 23);
		nudSoLuongAnhTo.TabIndex = 3;
		nudSoLuongAnhFrom.Location = new System.Drawing.Point(113, 30);
		nudSoLuongAnhFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
		nudSoLuongAnhFrom.Size = new System.Drawing.Size(45, 23);
		nudSoLuongAnhFrom.TabIndex = 3;
		txtPathAnh.Location = new System.Drawing.Point(113, 3);
		txtPathAnh.Name = "txtPathAnh";
		txtPathAnh.Size = new System.Drawing.Size(347, 23);
		txtPathAnh.TabIndex = 1;
		label10.Location = new System.Drawing.Point(160, 32);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(29, 16);
		label10.TabIndex = 0;
		label10.Text = "đến";
		label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(236, 32);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(28, 16);
		label4.TabIndex = 0;
		label4.Text = "a\u0309nh";
		FB22EF00.AutoSize = true;
		FB22EF00.Location = new System.Drawing.Point(3, 32);
		FB22EF00.Name = "label3";
		FB22EF00.Size = new System.Drawing.Size(110, 16);
		FB22EF00.TabIndex = 0;
		FB22EF00.Text = "Sô\u0301 lươ\u0323ng a\u0309nh/bài:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(3, 6);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(88, 16);
		label5.TabIndex = 0;
		label5.Text = "Thư mu\u0323c ảnh:";
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAnh.Location = new System.Drawing.Point(33, 411);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new System.Drawing.Size(48, 20);
		ckbAnh.TabIndex = 59;
		ckbAnh.Text = "A\u0309nh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += new System.EventHandler(CFBE5A33);
		label19.AutoSize = true;
		label19.Location = new System.Drawing.Point(291, 109);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(30, 16);
		label19.TabIndex = 43;
		label19.Text = "giây";
		label20.Location = new System.Drawing.Point(205, 109);
		label20.Name = "label20";
		label20.Size = new System.Drawing.Size(29, 16);
		label20.TabIndex = 42;
		label20.Text = "đến";
		label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		AA9BC098.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		AA9BC098.Controls.Add(E730C3A0);
		AA9BC098.Location = new System.Drawing.Point(681, 155);
		AA9BC098.Name = "plNhomNgauNhien";
		AA9BC098.Size = new System.Drawing.Size(299, 27);
		AA9BC098.TabIndex = 2;
		E730C3A0.AutoSize = true;
		E730C3A0.Cursor = System.Windows.Forms.Cursors.Hand;
		E730C3A0.Location = new System.Drawing.Point(5, 3);
		E730C3A0.Name = "ckbChiDangNhomKKD";
		E730C3A0.Size = new System.Drawing.Size(216, 20);
		E730C3A0.TabIndex = 32;
		E730C3A0.Text = "Chi\u0309 đăng nho\u0301m không kiê\u0309m duyê\u0323t";
		E730C3A0.UseVisualStyleBackColor = true;
		nudKhoangCachTo.Location = new System.Drawing.Point(236, 107);
		nudKhoangCachTo.Name = "nudKhoangCachTo";
		nudKhoangCachTo.Size = new System.Drawing.Size(51, 23);
		nudKhoangCachTo.TabIndex = 41;
		C337BAA9.Location = new System.Drawing.Point(151, 107);
		C337BAA9.Name = "nudKhoangCachFrom";
		C337BAA9.Size = new System.Drawing.Size(51, 23);
		C337BAA9.TabIndex = 40;
		B9125AA5.AutoSize = true;
		B9125AA5.Location = new System.Drawing.Point(291, 83);
		B9125AA5.Name = "label18";
		B9125AA5.Size = new System.Drawing.Size(35, 16);
		B9125AA5.TabIndex = 39;
		B9125AA5.Text = "page";
		label17.Location = new System.Drawing.Point(205, 83);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(29, 16);
		label17.TabIndex = 38;
		label17.Text = "đến";
		label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudSoLuongTo.Location = new System.Drawing.Point(236, 78);
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(51, 23);
		nudSoLuongTo.TabIndex = 37;
		CE99F024.Location = new System.Drawing.Point(151, 78);
		CE99F024.Name = "nudSoLuongFrom";
		CE99F024.Size = new System.Drawing.Size(51, 23);
		CE99F024.TabIndex = 36;
		EAAD769B.AutoSize = true;
		EAAD769B.Location = new System.Drawing.Point(30, 109);
		EAAD769B.Name = "label16";
		EAAD769B.Size = new System.Drawing.Size(116, 16);
		EAAD769B.TabIndex = 35;
		EAAD769B.Text = "Khoảng cách đăng:";
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(30, 83);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(95, 16);
		label15.TabIndex = 34;
		label15.Text = "Số lượng page:";
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(242, 510);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		ckbVanBan.AutoSize = true;
		ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbVanBan.Location = new System.Drawing.Point(33, 135);
		ckbVanBan.Name = "ckbVanBan";
		ckbVanBan.Size = new System.Drawing.Size(73, 20);
		ckbVanBan.TabIndex = 32;
		ckbVanBan.Text = "Văn ba\u0309n";
		ckbVanBan.UseVisualStyleBackColor = true;
		ckbVanBan.CheckedChanged += new System.EventHandler(ckbVanBan_CheckedChanged);
		txtTenHanhDong.Location = new System.Drawing.Point(151, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(174, 23);
		txtTenHanhDong.TabIndex = 0;
		F632B600.AutoSize = true;
		F632B600.Location = new System.Drawing.Point(30, 52);
		F632B600.Name = "label1";
		F632B600.Size = new System.Drawing.Size(98, 16);
		F632B600.TabIndex = 31;
		F632B600.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(341, 510);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(674, 37);
		bunifuCards1.TabIndex = 28;
		plNhomChiDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plNhomChiDinh.Controls.Add(ckbTuDongXoaUid);
		plNhomChiDinh.Controls.Add(label12);
		plNhomChiDinh.Controls.Add(A2AAC317);
		plNhomChiDinh.Location = new System.Drawing.Point(49, 619);
		plNhomChiDinh.Name = "plNhomChiDinh";
		plNhomChiDinh.Size = new System.Drawing.Size(262, 109);
		plNhomChiDinh.TabIndex = 58;
		plNhomChiDinh.Visible = false;
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaUid.Location = new System.Drawing.Point(5, 85);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new System.Drawing.Size(164, 20);
		ckbTuDongXoaUid.TabIndex = 168;
		ckbTuDongXoaUid.Text = "Tự động xóa ID đã dùng";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(2, 2);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(110, 16);
		label12.TabIndex = 0;
		label12.Text = "Nhâ\u0323p ID Page (0):";
		A2AAC317.Location = new System.Drawing.Point(5, 21);
		A2AAC317.Name = "txtIdNhomChiDinh";
		A2AAC317.Size = new System.Drawing.Size(252, 62);
		A2AAC317.TabIndex = 34;
		A2AAC317.Text = "";
		A2AAC317.TextChanged += new System.EventHandler(A2AAC317_TextChanged);
		rbNhomChiDinh.AutoSize = true;
		rbNhomChiDinh.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNhomChiDinh.Location = new System.Drawing.Point(33, 597);
		rbNhomChiDinh.Name = "rbNhomChiDinh";
		rbNhomChiDinh.Size = new System.Drawing.Size(101, 20);
		rbNhomChiDinh.TabIndex = 57;
		rbNhomChiDinh.TabStop = true;
		rbNhomChiDinh.Text = "Page chi\u0309 đi\u0323nh";
		rbNhomChiDinh.UseVisualStyleBackColor = true;
		rbNhomChiDinh.Visible = false;
		rbNhomChiDinh.CheckedChanged += new System.EventHandler(rbNhomChiDinh_CheckedChanged);
		rbNhomNgauNhien.AutoSize = true;
		rbNhomNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNhomNgauNhien.Location = new System.Drawing.Point(33, 574);
		rbNhomNgauNhien.Name = "rbNhomNgauNhien";
		rbNhomNgauNhien.Size = new System.Drawing.Size(198, 20);
		rbNhomNgauNhien.TabIndex = 57;
		rbNhomNgauNhien.TabStop = true;
		rbNhomNgauNhien.Text = "Ngẫu nhiên page đang quản lý";
		rbNhomNgauNhien.UseVisualStyleBackColor = true;
		rbNhomNgauNhien.Visible = false;
		rbNhomNgauNhien.CheckedChanged += new System.EventHandler(rbNhomNgauNhien_CheckedChanged);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(30, 555);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(96, 16);
		label2.TabIndex = 35;
		label2.Text = "Tùy chọn page:";
		label2.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(677, 551);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangBaiPage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDangBaiPage_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plVanBan.ResumeLayout(false);
		plVanBan.PerformLayout();
		plHashtag.ResumeLayout(false);
		plHashtag.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoHashtagFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoHashtagTo).EndInit();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhFrom).EndInit();
		AA9BC098.ResumeLayout(false);
		AA9BC098.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachTo).EndInit();
		((System.ComponentModel.ISupportInitialize)C337BAA9).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)CE99F024).EndInit();
		bunifuCards1.ResumeLayout(false);
		plNhomChiDinh.ResumeLayout(false);
		plNhomChiDinh.PerformLayout();
		ResumeLayout(false);
	}
}
