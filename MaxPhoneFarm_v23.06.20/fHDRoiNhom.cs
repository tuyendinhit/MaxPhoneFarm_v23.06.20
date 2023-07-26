using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDRoiNhom : Form
{
	internal JSON_Settings DA0B1226;

	internal string string_0;

	internal string string_1;

	internal string F9BB08B8;

	internal int int_0;

	internal static bool D8033E8D;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl FC8C2914;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox txtTenHanhDong;

	internal Label D62ABD9D;

	internal Label label4;

	internal Label DB0E3E1D;

	internal Label label1;

	internal Button btnCancel;

	internal Button B5BB1030;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox BA8519BE;

	internal BunifuCustomLabel D19B38B6;

	internal NumericUpDown B8092819;

	internal NumericUpDown nudDelayFrom;

	internal Label label7;

	internal Label B290B7A0;

	internal Label FB87AB17;

	internal RadioButton rbRoiTheoDieuKien;

	internal RadioButton rbNgauNhien;

	internal Label label9;

	internal Panel plUidChiDinh;

	internal TextBox txtTuKhoa;

	internal Label label10;

	internal Label lblStatusUid;

	internal Panel plDieuKienTuKhoa;

	internal CheckBox ckbDieuKienTuKhoa;

	internal CheckBox C7178894;

	internal NumericUpDown nudThanhVienToiDa;

	internal RichTextBox txtIDNhomGiuLai;

	internal Label A38F3B96;

	internal CheckBox F317BDBE;

	internal CheckBox ckbBackupDanhSachNhom;

	public fHDRoiNhom(string string_2, int C9023AA0 = 0, string E03B360C = "")
	{
		InitializeComponent();
		D8033E8D = false;
		string_0 = string_2;
		F9BB08B8 = E03B360C;
		int_0 = C9023AA0;
		string d399C = "";
		switch (C9023AA0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDRoiNhom");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(E03B360C);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			B5BB1030.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		DA0B1226 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDRoiNhom_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = DA0B1226.method_0("nudSoLuongFrom");
			nudSoLuongTo.Value = DA0B1226.method_0("nudSoLuongTo");
			nudDelayFrom.Value = DA0B1226.method_0("nudDelayFrom");
			B8092819.Value = DA0B1226.method_0("nudDelayTo");
			if (DA0B1226.method_0("typeRoiNhom") == 0)
			{
				rbNgauNhien.Checked = true;
			}
			else
			{
				rbRoiTheoDieuKien.Checked = true;
			}
			F317BDBE.Checked = DA0B1226.AA824D29("ckbDieuKienKiemDuyet");
			C7178894.Checked = DA0B1226.AA824D29("ckbDieuKienThanhVien");
			nudThanhVienToiDa.Value = DA0B1226.method_0("nudThanhVienToiDa");
			ckbDieuKienTuKhoa.Checked = DA0B1226.AA824D29("ckbDieuKienTuKhoa");
			txtTuKhoa.Text = DA0B1226.GetValue("txtTuKhoa");
			txtIDNhomGiuLai.Text = DA0B1226.GetValue("txtIDNhomGiuLai");
			ckbBackupDanhSachNhom.Checked = DA0B1226.AA824D29("ckbBackupDanhSachNhom");
		}
		catch
		{
		}
		method_1();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B5BB1030_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (rbRoiTheoDieuKien.Checked)
		{
			if (!C7178894.Checked && !ckbDieuKienTuKhoa.Checked && !F317BDBE.Checked)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng cho\u0323n i\u0301t nhâ\u0301t mô\u0323t điê\u0300u kiê\u0323n rơ\u0300i nho\u0301m!"), 3);
				return;
			}
			if (ckbDieuKienTuKhoa.Checked)
			{
				List<string> f1808BA = txtTuKhoa.Lines.ToList();
				f1808BA = Common.RemoveEmptyItems(f1808BA);
				if (f1808BA.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch tư\u0300 kho\u0301a!"), 3);
					return;
				}
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", B8092819.Value);
		if (rbNgauNhien.Checked)
		{
			f72FAFBC.GetValue("typeRoiNhom", 0);
		}
		else
		{
			f72FAFBC.GetValue("typeRoiNhom", 1);
		}
		f72FAFBC.GetValue("ckbDieuKienKiemDuyet", F317BDBE.Checked);
		f72FAFBC.GetValue("ckbDieuKienThanhVien", C7178894.Checked);
		f72FAFBC.GetValue("nudThanhVienToiDa", nudThanhVienToiDa.Value);
		f72FAFBC.GetValue("ckbDieuKienTuKhoa", ckbDieuKienTuKhoa.Checked);
		f72FAFBC.GetValue("txtTuKhoa", (object)txtTuKhoa.Text.Trim());
		f72FAFBC.GetValue("txtIDNhomGiuLai", (object)txtIDNhomGiuLai.Text);
		f72FAFBC.GetValue("ckbBackupDanhSachNhom", ckbBackupDanhSachNhom.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text2))
				{
					D8033E8D = true;
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
			if (Class123.smethod_14(F9BB08B8, text, text2))
			{
				D8033E8D = true;
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

	private void rbRoiTheoDieuKien_CheckedChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		plUidChiDinh.Enabled = rbRoiTheoDieuKien.Checked;
	}

	private void txtTuKhoa_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtTuKhoa.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatusUid.Text = string.Format(Language.GetValue("Danh sách tư\u0300 kho\u0301a ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		C7178894_CheckedChanged(null, null);
		ckbDieuKienTuKhoa_CheckedChanged(null, null);
		method_0();
	}

	private void C7178894_CheckedChanged(object sender, EventArgs e)
	{
		nudThanhVienToiDa.Enabled = C7178894.Checked;
	}

	private void ckbDieuKienTuKhoa_CheckedChanged(object sender, EventArgs e)
	{
		plDieuKienTuKhoa.Enabled = ckbDieuKienTuKhoa.Checked;
	}

	private void A38F3B96_Click(object sender, EventArgs e)
	{
	}

	private void txtIDNhomGiuLai_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtIDNhomGiuLai.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			A38F3B96.Text = string.Format(Language.GetValue("Danh sách ID nhóm cần giữ lại ({0}):"), f1808BA.Count);
		}
		catch
		{
		}
	}

	private void F317BDBE_Click(object sender, EventArgs e)
	{
		if (F317BDBE.Checked && MessageBoxHelper.smethod_1(Language.GetValue("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) == DialogResult.No)
		{
			F317BDBE.Checked = false;
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDRoiNhom));
		FC8C2914 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D19B38B6 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		BA8519BE = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		ckbBackupDanhSachNhom = new System.Windows.Forms.CheckBox();
		txtIDNhomGiuLai = new System.Windows.Forms.RichTextBox();
		A38F3B96 = new System.Windows.Forms.Label();
		plUidChiDinh = new System.Windows.Forms.Panel();
		plDieuKienTuKhoa = new System.Windows.Forms.Panel();
		lblStatusUid = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		txtTuKhoa = new System.Windows.Forms.TextBox();
		ckbDieuKienTuKhoa = new System.Windows.Forms.CheckBox();
		F317BDBE = new System.Windows.Forms.CheckBox();
		C7178894 = new System.Windows.Forms.CheckBox();
		nudThanhVienToiDa = new System.Windows.Forms.NumericUpDown();
		rbRoiTheoDieuKien = new System.Windows.Forms.RadioButton();
		rbNgauNhien = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		B8092819 = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		B290B7A0 = new System.Windows.Forms.Label();
		FB87AB17 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		D62ABD9D = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		DB0E3E1D = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		B5BB1030 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BA8519BE).BeginInit();
		panel1.SuspendLayout();
		plUidChiDinh.SuspendLayout();
		plDieuKienTuKhoa.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudThanhVienToiDa).BeginInit();
		((System.ComponentModel.ISupportInitialize)B8092819).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		FC8C2914.Fixed = true;
		FC8C2914.Horizontal = true;
		FC8C2914.TargetControl = D19B38B6;
		FC8C2914.Vertical = true;
		D19B38B6.BackColor = System.Drawing.Color.Transparent;
		D19B38B6.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D19B38B6.Dock = System.Windows.Forms.DockStyle.Fill;
		D19B38B6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D19B38B6.ForeColor = System.Drawing.Color.Black;
		D19B38B6.Location = new System.Drawing.Point(0, 0);
		D19B38B6.Name = "bunifuCustomLabel1";
		D19B38B6.Size = new System.Drawing.Size(644, 31);
		D19B38B6.TabIndex = 12;
		D19B38B6.Text = "Cấu hình Rơ\u0300i nho\u0301m";
		D19B38B6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(BA8519BE);
		pnlHeader.Controls.Add(D19B38B6);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(644, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(613, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		BA8519BE.Cursor = System.Windows.Forms.Cursors.Default;
		BA8519BE.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		BA8519BE.Location = new System.Drawing.Point(3, 2);
		BA8519BE.Name = "pictureBox1";
		BA8519BE.Size = new System.Drawing.Size(34, 27);
		BA8519BE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		BA8519BE.TabIndex = 76;
		BA8519BE.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(ckbBackupDanhSachNhom);
		panel1.Controls.Add(txtIDNhomGiuLai);
		panel1.Controls.Add(A38F3B96);
		panel1.Controls.Add(plUidChiDinh);
		panel1.Controls.Add(rbRoiTheoDieuKien);
		panel1.Controls.Add(rbNgauNhien);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(B8092819);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(B290B7A0);
		panel1.Controls.Add(FB87AB17);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(D62ABD9D);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(DB0E3E1D);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(B5BB1030);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(647, 528);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		ckbBackupDanhSachNhom.AutoSize = true;
		ckbBackupDanhSachNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBackupDanhSachNhom.Location = new System.Drawing.Point(31, 453);
		ckbBackupDanhSachNhom.Name = "ckbBackupDanhSachNhom";
		ckbBackupDanhSachNhom.Size = new System.Drawing.Size(262, 20);
		ckbBackupDanhSachNhom.TabIndex = 121;
		ckbBackupDanhSachNhom.Text = "Sử dụng danh sách nhóm đã backup (ẩn)";
		ckbBackupDanhSachNhom.UseVisualStyleBackColor = true;
		txtIDNhomGiuLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtIDNhomGiuLai.Location = new System.Drawing.Point(359, 157);
		txtIDNhomGiuLai.Name = "txtIDNhomGiuLai";
		txtIDNhomGiuLai.Size = new System.Drawing.Size(253, 293);
		txtIDNhomGiuLai.TabIndex = 120;
		txtIDNhomGiuLai.Text = "";
		txtIDNhomGiuLai.WordWrap = false;
		txtIDNhomGiuLai.TextChanged += new System.EventHandler(txtIDNhomGiuLai_TextChanged);
		A38F3B96.AutoSize = true;
		A38F3B96.Location = new System.Drawing.Point(356, 138);
		A38F3B96.Name = "label8";
		A38F3B96.Size = new System.Drawing.Size(207, 16);
		A38F3B96.TabIndex = 118;
		A38F3B96.Text = "Danh sách ID nhóm cần giữ lại (0):";
		A38F3B96.Click += new System.EventHandler(A38F3B96_Click);
		plUidChiDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plUidChiDinh.Controls.Add(plDieuKienTuKhoa);
		plUidChiDinh.Controls.Add(ckbDieuKienTuKhoa);
		plUidChiDinh.Controls.Add(F317BDBE);
		plUidChiDinh.Controls.Add(C7178894);
		plUidChiDinh.Controls.Add(nudThanhVienToiDa);
		plUidChiDinh.Location = new System.Drawing.Point(31, 206);
		plUidChiDinh.Name = "plUidChiDinh";
		plUidChiDinh.Size = new System.Drawing.Size(295, 244);
		plUidChiDinh.TabIndex = 49;
		plDieuKienTuKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plDieuKienTuKhoa.Controls.Add(lblStatusUid);
		plDieuKienTuKhoa.Controls.Add(label10);
		plDieuKienTuKhoa.Controls.Add(txtTuKhoa);
		plDieuKienTuKhoa.Location = new System.Drawing.Point(23, 79);
		plDieuKienTuKhoa.Name = "plDieuKienTuKhoa";
		plDieuKienTuKhoa.Size = new System.Drawing.Size(265, 160);
		plDieuKienTuKhoa.TabIndex = 50;
		lblStatusUid.AutoSize = true;
		lblStatusUid.Location = new System.Drawing.Point(3, 3);
		lblStatusUid.Name = "lblStatusUid";
		lblStatusUid.Size = new System.Drawing.Size(139, 16);
		lblStatusUid.TabIndex = 0;
		lblStatusUid.Text = "Danh sách tư\u0300 kho\u0301a (0):";
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(4, 139);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(127, 16);
		label10.TabIndex = 0;
		label10.Text = "(Mỗi tư\u0300 kho\u0301a 1 dòng)";
		txtTuKhoa.Location = new System.Drawing.Point(7, 25);
		txtTuKhoa.Multiline = true;
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtTuKhoa.Size = new System.Drawing.Size(253, 111);
		txtTuKhoa.TabIndex = 1;
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += new System.EventHandler(txtTuKhoa_TextChanged);
		ckbDieuKienTuKhoa.AutoSize = true;
		ckbDieuKienTuKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDieuKienTuKhoa.Location = new System.Drawing.Point(5, 53);
		ckbDieuKienTuKhoa.Name = "ckbDieuKienTuKhoa";
		ckbDieuKienTuKhoa.Size = new System.Drawing.Size(209, 20);
		ckbDieuKienTuKhoa.TabIndex = 2;
		ckbDieuKienTuKhoa.Text = "Tên nho\u0301m co\u0301 chư\u0301a tư\u0300 kho\u0301a sau:";
		ckbDieuKienTuKhoa.UseVisualStyleBackColor = true;
		ckbDieuKienTuKhoa.CheckedChanged += new System.EventHandler(ckbDieuKienTuKhoa_CheckedChanged);
		F317BDBE.AutoSize = true;
		F317BDBE.Cursor = System.Windows.Forms.Cursors.Hand;
		F317BDBE.Location = new System.Drawing.Point(5, 3);
		F317BDBE.Name = "ckbDieuKienKiemDuyet";
		F317BDBE.Size = new System.Drawing.Size(191, 20);
		F317BDBE.TabIndex = 2;
		F317BDBE.Text = "Rời nhóm kiểm duyệt bài viết";
		F317BDBE.UseVisualStyleBackColor = true;
		F317BDBE.Click += new System.EventHandler(F317BDBE_Click);
		C7178894.AutoSize = true;
		C7178894.Cursor = System.Windows.Forms.Cursors.Hand;
		C7178894.Location = new System.Drawing.Point(5, 27);
		C7178894.Name = "ckbDieuKienThanhVien";
		C7178894.Size = new System.Drawing.Size(181, 20);
		C7178894.TabIndex = 2;
		C7178894.Text = "Sô\u0301 lươ\u0323ng tha\u0300nh viên i\u0301t hơn:";
		C7178894.UseVisualStyleBackColor = true;
		C7178894.CheckedChanged += new System.EventHandler(C7178894_CheckedChanged);
		nudThanhVienToiDa.Location = new System.Drawing.Point(196, 26);
		nudThanhVienToiDa.Maximum = new decimal(new int[4] { 999999999, 0, 0, 0 });
		nudThanhVienToiDa.Name = "nudThanhVienToiDa";
		nudThanhVienToiDa.Size = new System.Drawing.Size(92, 23);
		nudThanhVienToiDa.TabIndex = 1;
		rbRoiTheoDieuKien.AutoSize = true;
		rbRoiTheoDieuKien.Cursor = System.Windows.Forms.Cursors.Hand;
		rbRoiTheoDieuKien.Location = new System.Drawing.Point(31, 182);
		rbRoiTheoDieuKien.Name = "rbRoiTheoDieuKien";
		rbRoiTheoDieuKien.Size = new System.Drawing.Size(163, 20);
		rbRoiTheoDieuKien.TabIndex = 48;
		rbRoiTheoDieuKien.Text = "Rơ\u0300i nho\u0301m theo điê\u0300u kiê\u0323n";
		rbRoiTheoDieuKien.UseVisualStyleBackColor = true;
		rbRoiTheoDieuKien.CheckedChanged += new System.EventHandler(rbRoiTheoDieuKien_CheckedChanged);
		rbNgauNhien.AutoSize = true;
		rbNgauNhien.Checked = true;
		rbNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNgauNhien.Location = new System.Drawing.Point(31, 157);
		rbNgauNhien.Name = "rbNgauNhien";
		rbNgauNhien.Size = new System.Drawing.Size(187, 20);
		rbNgauNhien.TabIndex = 48;
		rbNgauNhien.TabStop = true;
		rbNgauNhien.Text = "Ngẫu nhiên danh sách nho\u0301m";
		rbNgauNhien.UseVisualStyleBackColor = true;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(28, 135);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(137, 16);
		label9.TabIndex = 47;
		label9.Text = "Tùy chọn nho\u0301m đê\u0309 rơ\u0300i:";
		B8092819.Location = new System.Drawing.Point(228, 107);
		B8092819.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B8092819.Name = "nudDelayTo";
		B8092819.Size = new System.Drawing.Size(56, 23);
		B8092819.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(131, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.Location = new System.Drawing.Point(193, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B290B7A0.AutoSize = true;
		B290B7A0.Location = new System.Drawing.Point(286, 109);
		B290B7A0.Name = "label6";
		B290B7A0.Size = new System.Drawing.Size(30, 16);
		B290B7A0.TabIndex = 45;
		B290B7A0.Text = "giây";
		FB87AB17.AutoSize = true;
		FB87AB17.Location = new System.Drawing.Point(26, 109);
		FB87AB17.Name = "label5";
		FB87AB17.Size = new System.Drawing.Size(89, 16);
		FB87AB17.TabIndex = 44;
		FB87AB17.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new System.Drawing.Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		D62ABD9D.Location = new System.Drawing.Point(194, 80);
		D62ABD9D.Name = "label3";
		D62ABD9D.Size = new System.Drawing.Size(29, 16);
		D62ABD9D.TabIndex = 37;
		D62ABD9D.Text = "đê\u0301n";
		D62ABD9D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(287, 80);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(39, 16);
		label4.TabIndex = 35;
		label4.Text = "nho\u0301m";
		DB0E3E1D.AutoSize = true;
		DB0E3E1D.Location = new System.Drawing.Point(27, 80);
		DB0E3E1D.Name = "label2";
		DB0E3E1D.Size = new System.Drawing.Size(99, 16);
		DB0E3E1D.TabIndex = 32;
		DB0E3E1D.Text = "Sô\u0301 lươ\u0323ng nhóm:";
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
		btnCancel.Location = new System.Drawing.Point(331, 486);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		B5BB1030.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B5BB1030.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		B5BB1030.Cursor = System.Windows.Forms.Cursors.Hand;
		B5BB1030.FlatAppearance.BorderSize = 0;
		B5BB1030.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B5BB1030.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B5BB1030.ForeColor = System.Drawing.Color.White;
		B5BB1030.Location = new System.Drawing.Point(224, 486);
		B5BB1030.Name = "btnAdd";
		B5BB1030.Size = new System.Drawing.Size(92, 29);
		B5BB1030.TabIndex = 6;
		B5BB1030.Text = "Thêm";
		B5BB1030.UseVisualStyleBackColor = false;
		B5BB1030.Click += new System.EventHandler(B5BB1030_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(644, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(647, 528);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDRoiNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDRoiNhom_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)BA8519BE).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plUidChiDinh.ResumeLayout(false);
		plUidChiDinh.PerformLayout();
		plDieuKienTuKhoa.ResumeLayout(false);
		plDieuKienTuKhoa.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudThanhVienToiDa).EndInit();
		((System.ComponentModel.ISupportInitialize)B8092819).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
