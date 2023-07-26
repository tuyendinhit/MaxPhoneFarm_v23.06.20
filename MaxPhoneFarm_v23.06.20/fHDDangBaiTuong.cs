using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangBaiTuong : Form
{
	internal JSON_Settings DC1A578A;

	internal string string_0;

	internal string string_1;

	internal string DD19D800;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl C23373A4;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel D316AB1E;

	internal Button button1;

	internal PictureBox E51CE89C;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal CheckBox A2009002;

	internal Panel plVanBan;

	internal Label B1A8A1BB;

	internal Label D397662B;

	internal RichTextBox D225402C;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton EBA4AC3C;

	internal Label E69CEB83;

	internal CheckBox BF165C93;

	internal Label D6BC6102;

	internal Label label20;

	internal NumericUpDown nudKhoangCachTo;

	internal NumericUpDown nudKhoangCachFrom;

	internal Label FD150C04;

	internal Label label17;

	internal NumericUpDown F391713F;

	internal NumericUpDown C913DC8A;

	internal Label label16;

	internal Label E9B44A22;

	internal CheckBox ckbXoaNguyenLieuDaDung;

	internal LinkLabel EE36BE15;

	internal Button button3;

	internal Button button2;

	internal Panel plAnh;

	internal NumericUpDown nudSoLuongAnhTo;

	internal NumericUpDown nudSoLuongAnhFrom;

	internal TextBox txtPathAnh;

	internal Label F31C7294;

	internal Label label4;

	internal Label label2;

	internal Label label3;

	internal CheckBox ckbAnh;

	internal Panel B71AF213;

	internal Label FC0AD185;

	internal RichTextBox txtLinkShare;

	internal CheckBox ckbXoaLink;

	internal CheckBox F903A19C;

	internal Button B2AA5B25;

	internal Button btnUp;

	public fHDDangBaiTuong(string FE8A5185, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = FE8A5185;
		DD19D800 = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đăng ba\u0300i lên tươ\u0300ng";
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
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		DC1A578A = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDDangBaiTuong_Load(object sender, EventArgs e)
	{
		try
		{
			C913DC8A.Value = DC1A578A.method_0("nudSoLuongFrom", 1);
			F391713F.Value = DC1A578A.method_0("nudSoLuongTo", 1);
			nudKhoangCachFrom.Value = DC1A578A.method_0("nudKhoangCachFrom", 5);
			nudKhoangCachTo.Value = DC1A578A.method_0("nudKhoangCachTo", 10);
			A2009002.Checked = DC1A578A.AA824D29("ckbVanBan");
			BF165C93.Checked = DC1A578A.AA824D29("ckbUseBackground");
			ckbXoaNguyenLieuDaDung.Checked = DC1A578A.AA824D29("ckbXoaNguyenLieuDaDung");
			D225402C.Text = DC1A578A.GetValue("txtNoiDung");
			if (DC1A578A.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				EBA4AC3C.Checked = true;
			}
			ckbAnh.Checked = DC1A578A.AA824D29("ckbAnh");
			txtPathAnh.Text = DC1A578A.GetValue("txtPathAnh");
			nudSoLuongAnhFrom.Value = DC1A578A.method_0("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = DC1A578A.method_0("nudSoLuongAnhTo", 1);
			F903A19C.Checked = DC1A578A.AA824D29("ckbDangLink");
			txtLinkShare.Text = DC1A578A.GetValue("txtLinkShare");
			ckbXoaLink.Checked = DC1A578A.AA824D29("ckbXoaLink", A72188BC: true);
		}
		catch (Exception)
		{
		}
		method_0();
	}

	private void E918BDB5(object sender, EventArgs e)
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
		f72FAFBC.GetValue("nudSoLuongFrom", C913DC8A.Value);
		f72FAFBC.GetValue("nudSoLuongTo", F391713F.Value);
		f72FAFBC.GetValue("nudKhoangCachFrom", nudKhoangCachFrom.Value);
		f72FAFBC.GetValue("nudKhoangCachTo", nudKhoangCachTo.Value);
		f72FAFBC.GetValue("ckbVanBan", A2009002.Checked);
		f72FAFBC.GetValue("ckbUseBackground", BF165C93.Checked);
		f72FAFBC.GetValue("ckbXoaNguyenLieuDaDung", ckbXoaNguyenLieuDaDung.Checked);
		f72FAFBC.GetValue("txtNoiDung", (object)D225402C.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		f72FAFBC.GetValue("ckbAnh", ckbAnh.Checked);
		f72FAFBC.GetValue("txtPathAnh", (object)txtPathAnh.Text.Trim());
		f72FAFBC.GetValue("nudSoLuongAnhFrom", nudSoLuongAnhFrom.Value);
		f72FAFBC.GetValue("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		f72FAFBC.GetValue("ckbDangLink", F903A19C.Checked);
		f72FAFBC.GetValue("txtLinkShare", (object)txtLinkShare.Text.Trim());
		f72FAFBC.GetValue("ckbXoaLink", ckbXoaLink.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
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
			if (Class123.smethod_14(DD19D800, text, text2))
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

	private void B9A26F28(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_0()
	{
		A2009002_CheckedChanged(null, null);
		ckbAnh_CheckedChanged(null, null);
		A5A5029C(null, null);
	}

	private void A2009002_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = A2009002.Checked;
		if (!A2009002.Checked)
		{
			BF165C93.Checked = false;
		}
	}

	private void D225402C_TextChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!EBA4AC3C.Checked) ? D225402C.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : D225402C.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			D397662B.Text = string.Format(Language.GetValue("Danh sa\u0301ch nô\u0323i dung ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void DAAD0D9F(object sender, EventArgs e)
	{
	}

	private void E711329B(object sender, EventArgs e)
	{
		method_1();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void E81ADFA2(object sender, EventArgs e)
	{
	}

	private void EE36BE15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void AF86B826(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
	}

	private void ckbAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnh.Checked;
		BF165C93.Enabled = !ckbAnh.Checked;
		if (ckbAnh.Checked)
		{
			BF165C93.Checked = false;
		}
	}

	private void A5A5029C(object sender, EventArgs e)
	{
		B71AF213.Enabled = F903A19C.Checked;
	}

	private void txtLinkShare_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtLinkShare, FC0AD185);
	}

	private void F903A19C_VisibleChanged(object sender, EventArgs e)
	{
		B71AF213.Visible = F903A19C.Visible;
	}

	private void C0969A81(object sender, EventArgs e)
	{
		plVanBan.Height = 122;
		F903A19C.Visible = true;
	}

	private void B2AA5B25_Click(object sender, EventArgs e)
	{
		plVanBan.Height = 250;
		F903A19C.Visible = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangBaiTuong));
		C23373A4 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D316AB1E = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		E51CE89C = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		B2AA5B25 = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		plAnh = new System.Windows.Forms.Panel();
		nudSoLuongAnhTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongAnhFrom = new System.Windows.Forms.NumericUpDown();
		txtPathAnh = new System.Windows.Forms.TextBox();
		F31C7294 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		ckbAnh = new System.Windows.Forms.CheckBox();
		D6BC6102 = new System.Windows.Forms.Label();
		label20 = new System.Windows.Forms.Label();
		nudKhoangCachTo = new System.Windows.Forms.NumericUpDown();
		nudKhoangCachFrom = new System.Windows.Forms.NumericUpDown();
		FD150C04 = new System.Windows.Forms.Label();
		label17 = new System.Windows.Forms.Label();
		F391713F = new System.Windows.Forms.NumericUpDown();
		C913DC8A = new System.Windows.Forms.NumericUpDown();
		label16 = new System.Windows.Forms.Label();
		E9B44A22 = new System.Windows.Forms.Label();
		plVanBan = new System.Windows.Forms.Panel();
		EE36BE15 = new System.Windows.Forms.LinkLabel();
		button3 = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		EBA4AC3C = new System.Windows.Forms.RadioButton();
		E69CEB83 = new System.Windows.Forms.Label();
		D225402C = new System.Windows.Forms.RichTextBox();
		B1A8A1BB = new System.Windows.Forms.Label();
		D397662B = new System.Windows.Forms.Label();
		BF165C93 = new System.Windows.Forms.CheckBox();
		ckbXoaNguyenLieuDaDung = new System.Windows.Forms.CheckBox();
		btnAdd = new System.Windows.Forms.Button();
		A2009002 = new System.Windows.Forms.CheckBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		B71AF213 = new System.Windows.Forms.Panel();
		FC0AD185 = new System.Windows.Forms.Label();
		txtLinkShare = new System.Windows.Forms.RichTextBox();
		ckbXoaLink = new System.Windows.Forms.CheckBox();
		F903A19C = new System.Windows.Forms.CheckBox();
		D316AB1E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E51CE89C).BeginInit();
		panel1.SuspendLayout();
		plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)F391713F).BeginInit();
		((System.ComponentModel.ISupportInitialize)C913DC8A).BeginInit();
		plVanBan.SuspendLayout();
		bunifuCards1.SuspendLayout();
		B71AF213.SuspendLayout();
		SuspendLayout();
		C23373A4.Fixed = true;
		C23373A4.Horizontal = true;
		C23373A4.TargetControl = bunifuCustomLabel1;
		C23373A4.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(674, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đăng ba\u0300i lên tươ\u0300ng";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = D316AB1E;
		bunifuDragControl_0.Vertical = true;
		D316AB1E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D316AB1E.BackColor = System.Drawing.Color.White;
		D316AB1E.Controls.Add(button1);
		D316AB1E.Controls.Add(E51CE89C);
		D316AB1E.Controls.Add(bunifuCustomLabel1);
		D316AB1E.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D316AB1E.Location = new System.Drawing.Point(0, 3);
		D316AB1E.Name = "pnlHeader";
		D316AB1E.Size = new System.Drawing.Size(674, 31);
		D316AB1E.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(643, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 0;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(E918BDB5);
		E51CE89C.Cursor = System.Windows.Forms.Cursors.Default;
		E51CE89C.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		E51CE89C.Location = new System.Drawing.Point(3, 2);
		E51CE89C.Name = "pictureBox1";
		E51CE89C.Size = new System.Drawing.Size(34, 27);
		E51CE89C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		E51CE89C.TabIndex = 76;
		E51CE89C.TabStop = false;
		E51CE89C.Click += new System.EventHandler(DAAD0D9F);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(B2AA5B25);
		panel1.Controls.Add(btnUp);
		panel1.Controls.Add(plAnh);
		panel1.Controls.Add(ckbAnh);
		panel1.Controls.Add(D6BC6102);
		panel1.Controls.Add(label20);
		panel1.Controls.Add(nudKhoangCachTo);
		panel1.Controls.Add(nudKhoangCachFrom);
		panel1.Controls.Add(FD150C04);
		panel1.Controls.Add(label17);
		panel1.Controls.Add(F391713F);
		panel1.Controls.Add(C913DC8A);
		panel1.Controls.Add(label16);
		panel1.Controls.Add(E9B44A22);
		panel1.Controls.Add(plVanBan);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(A2009002);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(bunifuCards1);
		panel1.Controls.Add(B71AF213);
		panel1.Controls.Add(F903A19C);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(677, 546);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(B9A26F28);
		B2AA5B25.BackgroundImage = Resource.Bitmap_91;
		B2AA5B25.Cursor = System.Windows.Forms.Cursors.Hand;
		B2AA5B25.Location = new System.Drawing.Point(619, 126);
		B2AA5B25.Name = "btnDown";
		B2AA5B25.Size = new System.Drawing.Size(25, 25);
		B2AA5B25.TabIndex = 200;
		B2AA5B25.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		B2AA5B25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B2AA5B25.Click += new System.EventHandler(B2AA5B25_Click);
		btnUp.BackgroundImage = Resource.Bitmap_73;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.Location = new System.Drawing.Point(588, 126);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 201;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Click += new System.EventHandler(C0969A81);
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(nudSoLuongAnhTo);
		plAnh.Controls.Add(nudSoLuongAnhFrom);
		plAnh.Controls.Add(txtPathAnh);
		plAnh.Controls.Add(F31C7294);
		plAnh.Controls.Add(label4);
		plAnh.Controls.Add(label2);
		plAnh.Controls.Add(label3);
		plAnh.Location = new System.Drawing.Point(47, 433);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(597, 58);
		plAnh.TabIndex = 45;
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
		txtPathAnh.Size = new System.Drawing.Size(476, 23);
		txtPathAnh.TabIndex = 1;
		F31C7294.Location = new System.Drawing.Point(160, 32);
		F31C7294.Name = "label10";
		F31C7294.Size = new System.Drawing.Size(29, 16);
		F31C7294.TabIndex = 0;
		F31C7294.Text = "đến";
		F31C7294.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(236, 32);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(28, 16);
		label4.TabIndex = 0;
		label4.Text = "a\u0309nh";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(3, 32);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(110, 16);
		label2.TabIndex = 0;
		label2.Text = "Sô\u0301 lươ\u0323ng a\u0309nh/bài:";
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(3, 6);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(88, 16);
		label3.TabIndex = 0;
		label3.Text = "Thư mu\u0323c ảnh:";
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAnh.Location = new System.Drawing.Point(33, 409);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new System.Drawing.Size(48, 20);
		ckbAnh.TabIndex = 44;
		ckbAnh.Text = "A\u0309nh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += new System.EventHandler(ckbAnh_CheckedChanged);
		D6BC6102.AutoSize = true;
		D6BC6102.Location = new System.Drawing.Point(291, 109);
		D6BC6102.Name = "label19";
		D6BC6102.Size = new System.Drawing.Size(30, 16);
		D6BC6102.TabIndex = 43;
		D6BC6102.Text = "giây";
		label20.Location = new System.Drawing.Point(205, 109);
		label20.Name = "label20";
		label20.Size = new System.Drawing.Size(29, 16);
		label20.TabIndex = 42;
		label20.Text = "đến";
		label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudKhoangCachTo.Location = new System.Drawing.Point(236, 107);
		nudKhoangCachTo.Name = "nudKhoangCachTo";
		nudKhoangCachTo.Size = new System.Drawing.Size(51, 23);
		nudKhoangCachTo.TabIndex = 41;
		nudKhoangCachFrom.Location = new System.Drawing.Point(151, 107);
		nudKhoangCachFrom.Name = "nudKhoangCachFrom";
		nudKhoangCachFrom.Size = new System.Drawing.Size(51, 23);
		nudKhoangCachFrom.TabIndex = 40;
		FD150C04.AutoSize = true;
		FD150C04.Location = new System.Drawing.Point(291, 83);
		FD150C04.Name = "label18";
		FD150C04.Size = new System.Drawing.Size(24, 16);
		FD150C04.TabIndex = 39;
		FD150C04.Text = "bài";
		label17.Location = new System.Drawing.Point(205, 83);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(29, 16);
		label17.TabIndex = 38;
		label17.Text = "đến";
		label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F391713F.Location = new System.Drawing.Point(236, 78);
		F391713F.Name = "nudSoLuongTo";
		F391713F.Size = new System.Drawing.Size(51, 23);
		F391713F.TabIndex = 37;
		C913DC8A.Location = new System.Drawing.Point(151, 78);
		C913DC8A.Name = "nudSoLuongFrom";
		C913DC8A.Size = new System.Drawing.Size(51, 23);
		C913DC8A.TabIndex = 36;
		label16.AutoSize = true;
		label16.Location = new System.Drawing.Point(30, 109);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(116, 16);
		label16.TabIndex = 35;
		label16.Text = "Khoảng cách đăng:";
		E9B44A22.AutoSize = true;
		E9B44A22.Location = new System.Drawing.Point(30, 83);
		E9B44A22.Name = "label15";
		E9B44A22.Size = new System.Drawing.Size(108, 16);
		E9B44A22.TabIndex = 34;
		E9B44A22.Text = "Số lượng bài viết:";
		plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plVanBan.Controls.Add(EE36BE15);
		plVanBan.Controls.Add(button3);
		plVanBan.Controls.Add(button2);
		plVanBan.Controls.Add(rbNganCachKyTu);
		plVanBan.Controls.Add(EBA4AC3C);
		plVanBan.Controls.Add(E69CEB83);
		plVanBan.Controls.Add(D225402C);
		plVanBan.Controls.Add(B1A8A1BB);
		plVanBan.Controls.Add(D397662B);
		plVanBan.Controls.Add(BF165C93);
		plVanBan.Controls.Add(ckbXoaNguyenLieuDaDung);
		plVanBan.Location = new System.Drawing.Point(47, 155);
		plVanBan.Name = "plVanBan";
		plVanBan.Size = new System.Drawing.Size(597, 250);
		plVanBan.TabIndex = 33;
		EE36BE15.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		EE36BE15.AutoSize = true;
		EE36BE15.Cursor = System.Windows.Forms.Cursors.Hand;
		EE36BE15.Location = new System.Drawing.Point(154, 199);
		EE36BE15.Name = "linkLabel1";
		EE36BE15.Size = new System.Drawing.Size(81, 16);
		EE36BE15.TabIndex = 195;
		EE36BE15.TabStop = true;
		EE36BE15.Text = "Random icon";
		EE36BE15.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(EE36BE15_LinkClicked);
		button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		button3.Cursor = System.Windows.Forms.Cursors.Help;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(571, 221);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(21, 23);
		button3.TabIndex = 193;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(571, 198);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 23);
		button2.TabIndex = 194;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(AF86B826);
		rbNganCachKyTu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(412, 222);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		rbNganCachKyTu.TabIndex = 37;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		EBA4AC3C.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		EBA4AC3C.AutoSize = true;
		EBA4AC3C.Checked = true;
		EBA4AC3C.Cursor = System.Windows.Forms.Cursors.Hand;
		EBA4AC3C.Location = new System.Drawing.Point(412, 200);
		EBA4AC3C.Name = "rbNganCachMoiDong";
		EBA4AC3C.Size = new System.Drawing.Size(155, 20);
		EBA4AC3C.TabIndex = 36;
		EBA4AC3C.TabStop = true;
		EBA4AC3C.Text = "Nội dung chỉ có 1 dòng";
		EBA4AC3C.UseVisualStyleBackColor = true;
		EBA4AC3C.CheckedChanged += new System.EventHandler(E711329B);
		E69CEB83.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		E69CEB83.AutoSize = true;
		E69CEB83.Location = new System.Drawing.Point(347, 200);
		E69CEB83.Name = "label9";
		E69CEB83.Size = new System.Drawing.Size(64, 16);
		E69CEB83.TabIndex = 35;
		E69CEB83.Text = "Tùy chọn:";
		D225402C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D225402C.Location = new System.Drawing.Point(7, 24);
		D225402C.Name = "txtNoiDung";
		D225402C.Size = new System.Drawing.Size(585, 173);
		D225402C.TabIndex = 34;
		D225402C.Text = "";
		D225402C.WordWrap = false;
		D225402C.TextChanged += new System.EventHandler(D225402C_TextChanged);
		B1A8A1BB.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		B1A8A1BB.AutoSize = true;
		B1A8A1BB.Location = new System.Drawing.Point(4, 199);
		B1A8A1BB.Name = "label8";
		B1A8A1BB.Size = new System.Drawing.Size(143, 16);
		B1A8A1BB.TabIndex = 0;
		B1A8A1BB.Text = "(Spin nội dung {a|b|c})";
		D397662B.AutoSize = true;
		D397662B.Location = new System.Drawing.Point(3, 5);
		D397662B.Name = "lblStatus";
		D397662B.Size = new System.Drawing.Size(145, 16);
		D397662B.TabIndex = 0;
		D397662B.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		BF165C93.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		BF165C93.AutoSize = true;
		BF165C93.Cursor = System.Windows.Forms.Cursors.Hand;
		BF165C93.Location = new System.Drawing.Point(6, 222);
		BF165C93.Name = "ckbUseBackground";
		BF165C93.Size = new System.Drawing.Size(144, 20);
		BF165C93.TabIndex = 32;
		BF165C93.Text = "Sử dụng Background";
		BF165C93.UseVisualStyleBackColor = true;
		BF165C93.CheckedChanged += new System.EventHandler(E81ADFA2);
		ckbXoaNguyenLieuDaDung.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		ckbXoaNguyenLieuDaDung.AutoSize = true;
		ckbXoaNguyenLieuDaDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaNguyenLieuDaDung.Location = new System.Drawing.Point(157, 222);
		ckbXoaNguyenLieuDaDung.Name = "ckbXoaNguyenLieuDaDung";
		ckbXoaNguyenLieuDaDung.Size = new System.Drawing.Size(151, 20);
		ckbXoaNguyenLieuDaDung.TabIndex = 32;
		ckbXoaNguyenLieuDaDung.Text = "Xóa nội dung đã đăng";
		ckbXoaNguyenLieuDaDung.UseVisualStyleBackColor = true;
		ckbXoaNguyenLieuDaDung.CheckedChanged += new System.EventHandler(A2009002_CheckedChanged);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(242, 505);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		A2009002.AutoSize = true;
		A2009002.Cursor = System.Windows.Forms.Cursors.Hand;
		A2009002.Location = new System.Drawing.Point(33, 131);
		A2009002.Name = "ckbVanBan";
		A2009002.Size = new System.Drawing.Size(73, 20);
		A2009002.TabIndex = 32;
		A2009002.Text = "Văn ba\u0309n";
		A2009002.UseVisualStyleBackColor = true;
		A2009002.CheckedChanged += new System.EventHandler(A2009002_CheckedChanged);
		txtTenHanhDong.Location = new System.Drawing.Point(151, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(174, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(30, 52);
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
		btnCancel.Location = new System.Drawing.Point(341, 505);
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
		bunifuCards1.Controls.Add(D316AB1E);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(674, 37);
		bunifuCards1.TabIndex = 28;
		B71AF213.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B71AF213.Controls.Add(FC0AD185);
		B71AF213.Controls.Add(txtLinkShare);
		B71AF213.Controls.Add(ckbXoaLink);
		B71AF213.Location = new System.Drawing.Point(47, 303);
		B71AF213.Name = "plDangLink";
		B71AF213.Size = new System.Drawing.Size(597, 102);
		B71AF213.TabIndex = 60;
		B71AF213.Visible = false;
		FC0AD185.AutoSize = true;
		FC0AD185.Location = new System.Drawing.Point(2, 2);
		FC0AD185.Name = "lblDanhSachLink";
		FC0AD185.Size = new System.Drawing.Size(115, 16);
		FC0AD185.TabIndex = 0;
		FC0AD185.Text = "Danh sách link (0):";
		txtLinkShare.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtLinkShare.Location = new System.Drawing.Point(5, 21);
		txtLinkShare.Name = "txtLinkShare";
		txtLinkShare.Size = new System.Drawing.Size(587, 55);
		txtLinkShare.TabIndex = 34;
		txtLinkShare.Text = "";
		txtLinkShare.WordWrap = false;
		txtLinkShare.TextChanged += new System.EventHandler(txtLinkShare_TextChanged);
		ckbXoaLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		ckbXoaLink.AutoSize = true;
		ckbXoaLink.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaLink.Location = new System.Drawing.Point(5, 77);
		ckbXoaLink.Name = "ckbXoaLink";
		ckbXoaLink.Size = new System.Drawing.Size(253, 20);
		ckbXoaLink.TabIndex = 168;
		ckbXoaLink.Text = "Tự động xóa link sau khi hiện thumbnail";
		ckbXoaLink.UseVisualStyleBackColor = true;
		F903A19C.AutoSize = true;
		F903A19C.Cursor = System.Windows.Forms.Cursors.Hand;
		F903A19C.Location = new System.Drawing.Point(33, 281);
		F903A19C.Name = "ckbDangLink";
		F903A19C.Size = new System.Drawing.Size(79, 20);
		F903A19C.TabIndex = 59;
		F903A19C.Text = "Đăng link";
		F903A19C.UseVisualStyleBackColor = true;
		F903A19C.Visible = false;
		F903A19C.CheckedChanged += new System.EventHandler(A5A5029C);
		F903A19C.VisibleChanged += new System.EventHandler(F903A19C_VisibleChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(677, 546);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangBaiTuong";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDangBaiTuong_Load);
		D316AB1E.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E51CE89C).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)F391713F).EndInit();
		((System.ComponentModel.ISupportInitialize)C913DC8A).EndInit();
		plVanBan.ResumeLayout(false);
		plVanBan.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		B71AF213.ResumeLayout(false);
		B71AF213.PerformLayout();
		ResumeLayout(false);
	}
}
