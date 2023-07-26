using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangStory : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string DF17E30D;

	internal int B98E3897;

	internal static bool bool_0;

	internal IContainer FE8CDFAF = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl D813250B;

	internal Panel panel1;

	internal TextBox DB073A23;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel DE14723D;

	internal Button button1;

	internal PictureBox C0B22FAF;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label lblStatus;

	internal CheckBox ckbUseBackgroundText;

	internal Label label8;

	internal Panel plDangText;

	internal Label D69D4721;

	internal Panel B8AA252F;

	internal Panel D8021B05;

	internal Label F1BD4994;

	internal Label EE221C33;

	internal RadioButton E6915A23;

	internal RadioButton AA216788;

	internal RadioButton FE95ED1D;

	internal RadioButton rbDangText;

	internal Label label5;

	internal NumericUpDown EC9DF4BB;

	internal NumericUpDown nudSoLuongFrom;

	internal Label F330D135;

	internal Label label7;

	internal RichTextBox txtNoiDung;

	internal RichTextBox BCB9D3B0;

	internal CheckBox B48A3FB9;

	internal CheckBox ckbUseBackgroundNhac;

	internal Panel plAnh;

	internal CheckBox ckbXoaAnhDaDang;

	internal TextBox F8BA4883;

	internal Label label12;

	internal RadioButton rbChiDangAnh;

	internal Panel plChiDangAnh;

	internal CheckBox ckbChiDangAnhXoaAnhDaDang;

	internal TextBox txtChiDangAnhPathAnh;

	internal Label label9;

	public fHDDangStory(string A308659E, int AE374A03 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = A308659E;
		DF17E30D = string_2;
		B98E3897 = AE374A03;
		if (Class123.C7BE863B("", "HDDangStory").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDDangStory', 'Đăng story');");
		}
		string d399C = "";
		switch (AE374A03)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDDangStory");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			DB073A23.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			DB073A23.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void CB9F761B(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 1);
			EC9DF4BB.Value = f72FAFBC_0.method_0("nudSoLuongTo", 1);
			if (f72FAFBC_0.method_0("typeDang") == 0)
			{
				rbDangText.Checked = true;
			}
			else if (f72FAFBC_0.method_0("typeDang") == 1)
			{
				FE95ED1D.Checked = true;
			}
			else
			{
				rbChiDangAnh.Checked = true;
			}
			txtNoiDung.Text = f72FAFBC_0.GetValue("txtNoiDung");
			ckbUseBackgroundText.Checked = f72FAFBC_0.AA824D29("ckbUseBackgroundText");
			if (f72FAFBC_0.method_0("typeBaiHat") == 0)
			{
				AA216788.Checked = true;
			}
			else
			{
				E6915A23.Checked = true;
			}
			BCB9D3B0.Text = f72FAFBC_0.GetValue("txtDanhSachBaiHat");
			ckbUseBackgroundNhac.Checked = f72FAFBC_0.AA824D29("ckbUseBackgroundNhac");
			B48A3FB9.Checked = f72FAFBC_0.AA824D29("ckbAnh");
			F8BA4883.Text = f72FAFBC_0.GetValue("txtPathAnh");
			ckbXoaAnhDaDang.Checked = f72FAFBC_0.AA824D29("ckbXoaAnhDaDang");
			txtChiDangAnhPathAnh.Text = f72FAFBC_0.GetValue("txtChiDangAnhPathAnh");
			ckbChiDangAnhXoaAnhDaDang.Checked = f72FAFBC_0.AA824D29("ckbChiDangAnhXoaAnhDaDang");
		}
		catch
		{
		}
		method_1();
	}

	private void FF93B221(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = DB073A23.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", EC9DF4BB.Value);
		if (rbDangText.Checked)
		{
			f72FAFBC.GetValue("typeDang", 0);
		}
		else if (FE95ED1D.Checked)
		{
			f72FAFBC.GetValue("typeDang", 1);
		}
		else
		{
			f72FAFBC.GetValue("typeDang", 2);
		}
		f72FAFBC.GetValue("txtNoiDung", (object)txtNoiDung.Text);
		f72FAFBC.GetValue("ckbUseBackgroundText", ckbUseBackgroundText.Checked);
		if (AA216788.Checked)
		{
			f72FAFBC.GetValue("typeBaiHat", 0);
		}
		else
		{
			f72FAFBC.GetValue("typeBaiHat", 1);
		}
		f72FAFBC.GetValue("txtDanhSachBaiHat", (object)BCB9D3B0.Text);
		f72FAFBC.GetValue("ckbUseBackgroundNhac", ckbUseBackgroundNhac.Checked);
		f72FAFBC.GetValue("ckbAnh", B48A3FB9.Checked);
		f72FAFBC.GetValue("txtPathAnh", (object)F8BA4883.Text);
		f72FAFBC.GetValue("ckbXoaAnhDaDang", ckbXoaAnhDaDang.Checked);
		f72FAFBC.GetValue("txtChiDangAnhPathAnh", (object)txtChiDangAnhPathAnh.Text);
		f72FAFBC.GetValue("ckbChiDangAnhXoaAnhDaDang", ckbChiDangAnhXoaAnhDaDang.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (B98E3897 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text2))
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
			if (Class123.smethod_14(DF17E30D, text, text2))
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

	private void B6AE50AB(object sender, EventArgs e)
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

	private void method_1()
	{
		rbDangText_CheckedChanged(null, null);
		FE95ED1D_CheckedChanged(null, null);
		AF2D1785(null, null);
		B48A3FB9_CheckedChanged(null, null);
		E6B3E133(null, null);
	}

	private void rbDangText_CheckedChanged(object sender, EventArgs e)
	{
		plDangText.Enabled = rbDangText.Checked;
	}

	private void FE95ED1D_CheckedChanged(object sender, EventArgs e)
	{
		B8AA252F.Enabled = FE95ED1D.Checked;
	}

	private void C4973810(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = BCB9D3B0.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			EE221C33.Text = string.Format(Language.GetValue("Danh sa\u0301ch ba\u0300i ha\u0301t ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void AF2D1785(object sender, EventArgs e)
	{
		D8021B05.Enabled = E6915A23.Checked;
	}

	private void F5B9CF2F(object sender, PaintEventArgs e)
	{
	}

	private void txtNoiDung_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtNoiDung, lblStatus);
	}

	private void BCB9D3B0_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(BCB9D3B0, EE221C33);
	}

	private void B48A3FB9_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = B48A3FB9.Checked;
	}

	private void E6B3E133(object sender, EventArgs e)
	{
		plChiDangAnh.Enabled = rbChiDangAnh.Checked;
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && FE8CDFAF != null)
		{
			FE8CDFAF.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		FE8CDFAF = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangStory));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(FE8CDFAF);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D813250B = new Bunifu.Framework.UI.BunifuDragControl(FE8CDFAF);
		DE14723D = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		C0B22FAF = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		EC9DF4BB = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		F330D135 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		B8AA252F = new System.Windows.Forms.Panel();
		plAnh = new System.Windows.Forms.Panel();
		ckbXoaAnhDaDang = new System.Windows.Forms.CheckBox();
		F8BA4883 = new System.Windows.Forms.TextBox();
		label12 = new System.Windows.Forms.Label();
		D8021B05 = new System.Windows.Forms.Panel();
		BCB9D3B0 = new System.Windows.Forms.RichTextBox();
		F1BD4994 = new System.Windows.Forms.Label();
		EE221C33 = new System.Windows.Forms.Label();
		E6915A23 = new System.Windows.Forms.RadioButton();
		B48A3FB9 = new System.Windows.Forms.CheckBox();
		ckbUseBackgroundNhac = new System.Windows.Forms.CheckBox();
		AA216788 = new System.Windows.Forms.RadioButton();
		plChiDangAnh = new System.Windows.Forms.Panel();
		ckbChiDangAnhXoaAnhDaDang = new System.Windows.Forms.CheckBox();
		txtChiDangAnhPathAnh = new System.Windows.Forms.TextBox();
		label9 = new System.Windows.Forms.Label();
		plDangText = new System.Windows.Forms.Panel();
		txtNoiDung = new System.Windows.Forms.RichTextBox();
		label8 = new System.Windows.Forms.Label();
		ckbUseBackgroundText = new System.Windows.Forms.CheckBox();
		lblStatus = new System.Windows.Forms.Label();
		FE95ED1D = new System.Windows.Forms.RadioButton();
		rbChiDangAnh = new System.Windows.Forms.RadioButton();
		rbDangText = new System.Windows.Forms.RadioButton();
		DB073A23 = new System.Windows.Forms.TextBox();
		label5 = new System.Windows.Forms.Label();
		D69D4721 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		DE14723D.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C0B22FAF).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)EC9DF4BB).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		B8AA252F.SuspendLayout();
		plAnh.SuspendLayout();
		D8021B05.SuspendLayout();
		plChiDangAnh.SuspendLayout();
		plDangText.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(807, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đăng Story";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D813250B.Fixed = true;
		D813250B.Horizontal = true;
		D813250B.TargetControl = DE14723D;
		D813250B.Vertical = true;
		DE14723D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DE14723D.BackColor = System.Drawing.Color.White;
		DE14723D.Controls.Add(button1);
		DE14723D.Controls.Add(C0B22FAF);
		DE14723D.Controls.Add(bunifuCustomLabel1);
		DE14723D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DE14723D.Location = new System.Drawing.Point(0, 3);
		DE14723D.Name = "pnlHeader";
		DE14723D.Size = new System.Drawing.Size(807, 31);
		DE14723D.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(776, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(FF93B221);
		C0B22FAF.Cursor = System.Windows.Forms.Cursors.Default;
		C0B22FAF.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		C0B22FAF.Location = new System.Drawing.Point(3, 2);
		C0B22FAF.Name = "pictureBox1";
		C0B22FAF.Size = new System.Drawing.Size(34, 27);
		C0B22FAF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		C0B22FAF.TabIndex = 76;
		C0B22FAF.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(EC9DF4BB);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(F330D135);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(B8AA252F);
		panel1.Controls.Add(plChiDangAnh);
		panel1.Controls.Add(plDangText);
		panel1.Controls.Add(FE95ED1D);
		panel1.Controls.Add(rbChiDangAnh);
		panel1.Controls.Add(rbDangText);
		panel1.Controls.Add(DB073A23);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(D69D4721);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(810, 525);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		EC9DF4BB.Location = new System.Drawing.Point(229, 78);
		EC9DF4BB.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		EC9DF4BB.Name = "nudSoLuongTo";
		EC9DF4BB.Size = new System.Drawing.Size(56, 23);
		EC9DF4BB.TabIndex = 39;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 38;
		F330D135.Location = new System.Drawing.Point(194, 80);
		F330D135.Name = "label6";
		F330D135.Size = new System.Drawing.Size(29, 16);
		F330D135.TabIndex = 41;
		F330D135.Text = "đê\u0301n";
		F330D135.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(290, 80);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(35, 16);
		label7.TabIndex = 40;
		label7.Text = "story";
		B8AA252F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B8AA252F.Controls.Add(plAnh);
		B8AA252F.Controls.Add(D8021B05);
		B8AA252F.Controls.Add(E6915A23);
		B8AA252F.Controls.Add(B48A3FB9);
		B8AA252F.Controls.Add(ckbUseBackgroundNhac);
		B8AA252F.Controls.Add(AA216788);
		B8AA252F.Location = new System.Drawing.Point(132, 129);
		B8AA252F.Name = "plDangNhac";
		B8AA252F.Size = new System.Drawing.Size(305, 330);
		B8AA252F.TabIndex = 33;
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(ckbXoaAnhDaDang);
		plAnh.Controls.Add(F8BA4883);
		plAnh.Controls.Add(label12);
		plAnh.Location = new System.Drawing.Point(18, 265);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(278, 58);
		plAnh.TabIndex = 61;
		ckbXoaAnhDaDang.AutoSize = true;
		ckbXoaAnhDaDang.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaAnhDaDang.Location = new System.Drawing.Point(6, 32);
		ckbXoaAnhDaDang.Name = "ckbXoaAnhDaDang";
		ckbXoaAnhDaDang.Size = new System.Drawing.Size(123, 20);
		ckbXoaAnhDaDang.TabIndex = 33;
		ckbXoaAnhDaDang.Text = "Xóa ảnh đã đăng";
		ckbXoaAnhDaDang.UseVisualStyleBackColor = true;
		F8BA4883.Location = new System.Drawing.Point(97, 3);
		F8BA4883.Name = "txtPathAnh";
		F8BA4883.Size = new System.Drawing.Size(176, 23);
		F8BA4883.TabIndex = 1;
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(3, 6);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(88, 16);
		label12.TabIndex = 0;
		label12.Text = "Thư mu\u0323c ảnh:";
		D8021B05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D8021B05.Controls.Add(BCB9D3B0);
		D8021B05.Controls.Add(F1BD4994);
		D8021B05.Controls.Add(EE221C33);
		D8021B05.Location = new System.Drawing.Point(18, 51);
		D8021B05.Name = "plBaiHatChiDinh";
		D8021B05.Size = new System.Drawing.Size(278, 161);
		D8021B05.TabIndex = 8;
		D8021B05.Paint += new System.Windows.Forms.PaintEventHandler(F5B9CF2F);
		BCB9D3B0.Location = new System.Drawing.Point(6, 22);
		BCB9D3B0.Name = "txtDanhSachBaiHat";
		BCB9D3B0.Size = new System.Drawing.Size(267, 112);
		BCB9D3B0.TabIndex = 8;
		BCB9D3B0.Text = "";
		BCB9D3B0.WordWrap = false;
		BCB9D3B0.TextChanged += new System.EventHandler(BCB9D3B0_TextChanged);
		F1BD4994.AutoSize = true;
		F1BD4994.Location = new System.Drawing.Point(3, 138);
		F1BD4994.Name = "label3";
		F1BD4994.Size = new System.Drawing.Size(133, 16);
		F1BD4994.TabIndex = 2;
		F1BD4994.Text = "(Mỗi nội dung 1 dòng)";
		EE221C33.AutoSize = true;
		EE221C33.Location = new System.Drawing.Point(3, 3);
		EE221C33.Name = "label4";
		EE221C33.Size = new System.Drawing.Size(135, 16);
		EE221C33.TabIndex = 0;
		EE221C33.Text = "Danh sa\u0301ch ba\u0300i ha\u0301t (0):";
		E6915A23.AutoSize = true;
		E6915A23.Cursor = System.Windows.Forms.Cursors.Hand;
		E6915A23.Location = new System.Drawing.Point(6, 29);
		E6915A23.Name = "rbBaiHatChiDinh";
		E6915A23.Size = new System.Drawing.Size(112, 20);
		E6915A23.TabIndex = 32;
		E6915A23.TabStop = true;
		E6915A23.Text = "Ba\u0300i ha\u0301t chi\u0309 đi\u0323nh";
		E6915A23.UseVisualStyleBackColor = true;
		E6915A23.CheckedChanged += new System.EventHandler(AF2D1785);
		B48A3FB9.AutoSize = true;
		B48A3FB9.Cursor = System.Windows.Forms.Cursors.Hand;
		B48A3FB9.Location = new System.Drawing.Point(6, 242);
		B48A3FB9.Name = "ckbAnh";
		B48A3FB9.Size = new System.Drawing.Size(48, 20);
		B48A3FB9.TabIndex = 7;
		B48A3FB9.Text = "Ảnh";
		B48A3FB9.UseVisualStyleBackColor = true;
		B48A3FB9.CheckedChanged += new System.EventHandler(B48A3FB9_CheckedChanged);
		ckbUseBackgroundNhac.AutoSize = true;
		ckbUseBackgroundNhac.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbUseBackgroundNhac.Location = new System.Drawing.Point(6, 216);
		ckbUseBackgroundNhac.Name = "ckbUseBackgroundNhac";
		ckbUseBackgroundNhac.Size = new System.Drawing.Size(144, 20);
		ckbUseBackgroundNhac.TabIndex = 7;
		ckbUseBackgroundNhac.Text = "Sư\u0309 du\u0323ng background";
		ckbUseBackgroundNhac.UseVisualStyleBackColor = true;
		AA216788.AutoSize = true;
		AA216788.Cursor = System.Windows.Forms.Cursors.Hand;
		AA216788.Location = new System.Drawing.Point(6, 3);
		AA216788.Name = "rbBaiHatNgauNhien";
		AA216788.Size = new System.Drawing.Size(131, 20);
		AA216788.TabIndex = 32;
		AA216788.TabStop = true;
		AA216788.Text = "Ba\u0300i ha\u0301t ngâ\u0303u nhiên";
		AA216788.UseVisualStyleBackColor = true;
		plChiDangAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plChiDangAnh.Controls.Add(ckbChiDangAnhXoaAnhDaDang);
		plChiDangAnh.Controls.Add(txtChiDangAnhPathAnh);
		plChiDangAnh.Controls.Add(label9);
		plChiDangAnh.Location = new System.Drawing.Point(472, 403);
		plChiDangAnh.Name = "plChiDangAnh";
		plChiDangAnh.Size = new System.Drawing.Size(305, 56);
		plChiDangAnh.TabIndex = 33;
		ckbChiDangAnhXoaAnhDaDang.AutoSize = true;
		ckbChiDangAnhXoaAnhDaDang.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChiDangAnhXoaAnhDaDang.Location = new System.Drawing.Point(6, 30);
		ckbChiDangAnhXoaAnhDaDang.Name = "ckbChiDangAnhXoaAnhDaDang";
		ckbChiDangAnhXoaAnhDaDang.Size = new System.Drawing.Size(137, 20);
		ckbChiDangAnhXoaAnhDaDang.TabIndex = 33;
		ckbChiDangAnhXoaAnhDaDang.Text = "Xóa media đã đăng";
		ckbChiDangAnhXoaAnhDaDang.UseVisualStyleBackColor = true;
		txtChiDangAnhPathAnh.Location = new System.Drawing.Point(101, 4);
		txtChiDangAnhPathAnh.Name = "txtChiDangAnhPathAnh";
		txtChiDangAnhPathAnh.Size = new System.Drawing.Size(199, 23);
		txtChiDangAnhPathAnh.TabIndex = 1;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(3, 7);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(102, 16);
		label9.TabIndex = 0;
		label9.Text = "Thư mu\u0323c media:";
		plDangText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plDangText.Controls.Add(txtNoiDung);
		plDangText.Controls.Add(label8);
		plDangText.Controls.Add(ckbUseBackgroundText);
		plDangText.Controls.Add(lblStatus);
		plDangText.Location = new System.Drawing.Point(472, 129);
		plDangText.Name = "plDangText";
		plDangText.Size = new System.Drawing.Size(305, 246);
		plDangText.TabIndex = 33;
		txtNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtNoiDung.Location = new System.Drawing.Point(6, 22);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new System.Drawing.Size(294, 175);
		txtNoiDung.TabIndex = 8;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += new System.EventHandler(txtNoiDung_TextChanged);
		label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(3, 200);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(265, 16);
		label8.TabIndex = 2;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		ckbUseBackgroundText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		ckbUseBackgroundText.AutoSize = true;
		ckbUseBackgroundText.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbUseBackgroundText.Location = new System.Drawing.Point(6, 221);
		ckbUseBackgroundText.Name = "ckbUseBackgroundText";
		ckbUseBackgroundText.Size = new System.Drawing.Size(144, 20);
		ckbUseBackgroundText.TabIndex = 7;
		ckbUseBackgroundText.Text = "Sư\u0309 du\u0323ng background";
		ckbUseBackgroundText.UseVisualStyleBackColor = true;
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 3);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(115, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung story (0):";
		FE95ED1D.AutoSize = true;
		FE95ED1D.Cursor = System.Windows.Forms.Cursors.Hand;
		FE95ED1D.Location = new System.Drawing.Point(132, 107);
		FE95ED1D.Name = "rbDangNhac";
		FE95ED1D.Size = new System.Drawing.Size(86, 20);
		FE95ED1D.TabIndex = 32;
		FE95ED1D.TabStop = true;
		FE95ED1D.Text = "Đăng nha\u0323c";
		FE95ED1D.UseVisualStyleBackColor = true;
		FE95ED1D.CheckedChanged += new System.EventHandler(FE95ED1D_CheckedChanged);
		rbChiDangAnh.AutoSize = true;
		rbChiDangAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		rbChiDangAnh.Location = new System.Drawing.Point(472, 381);
		rbChiDangAnh.Name = "rbChiDangAnh";
		rbChiDangAnh.Size = new System.Drawing.Size(115, 20);
		rbChiDangAnh.TabIndex = 32;
		rbChiDangAnh.TabStop = true;
		rbChiDangAnh.Text = "Đăng ảnh/video";
		rbChiDangAnh.UseVisualStyleBackColor = true;
		rbChiDangAnh.CheckedChanged += new System.EventHandler(E6B3E133);
		rbDangText.AutoSize = true;
		rbDangText.Cursor = System.Windows.Forms.Cursors.Hand;
		rbDangText.Location = new System.Drawing.Point(472, 107);
		rbDangText.Name = "rbDangText";
		rbDangText.Size = new System.Drawing.Size(80, 20);
		rbDangText.TabIndex = 32;
		rbDangText.TabStop = true;
		rbDangText.Text = "Đăng text";
		rbDangText.UseVisualStyleBackColor = true;
		rbDangText.CheckedChanged += new System.EventHandler(rbDangText_CheckedChanged);
		DB073A23.Location = new System.Drawing.Point(132, 49);
		DB073A23.Name = "txtTenHanhDong";
		DB073A23.Size = new System.Drawing.Size(305, 23);
		DB073A23.TabIndex = 0;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 80);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(95, 16);
		label5.TabIndex = 31;
		label5.Text = "Sô\u0301 lươ\u0323ng story:";
		D69D4721.AutoSize = true;
		D69D4721.Location = new System.Drawing.Point(27, 109);
		D69D4721.Name = "label2";
		D69D4721.Size = new System.Drawing.Size(96, 16);
		D69D4721.TabIndex = 31;
		D69D4721.Text = "Tu\u0300y cho\u0323n đăng:";
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
		btnCancel.Location = new System.Drawing.Point(413, 482);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(B6AE50AB);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(306, 482);
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
		bunifuCards1.Controls.Add(DE14723D);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(807, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(810, 525);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangStory";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(CB9F761B);
		DE14723D.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)C0B22FAF).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)EC9DF4BB).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		B8AA252F.ResumeLayout(false);
		B8AA252F.PerformLayout();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		D8021B05.ResumeLayout(false);
		D8021B05.PerformLayout();
		plChiDangAnh.ResumeLayout(false);
		plChiDangAnh.PerformLayout();
		plDangText.ResumeLayout(false);
		plDangText.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
