using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangBaiNhom : Form
{
	internal JSON_Settings B505438A;

	internal string E59290BC;

	internal string B2B8C832;

	internal string F68196AE;

	internal int int_0;

	internal static bool B503039D;

	internal List<string> A3291E2D = new List<string>();

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl D412E794;

	internal Panel C6009F9C;

	internal TextBox F42D0F23;

	internal Label DBA61BB0;

	internal Button C42BD19C;

	internal Button btnAdd;

	internal BunifuCards D60160A8;

	internal Panel A0AF3236;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal CheckBox C7BAC338;

	internal Panel plVanBan;

	internal Label E6B61E2B;

	internal Label lblStatus;

	internal RichTextBox F71B57A4;

	internal RadioButton A281CE3A;

	internal RadioButton rbNganCachMoiDong;

	internal Label EFA35D1F;

	internal CheckBox D03A79AB;

	internal Label label19;

	internal Label D6B36815;

	internal NumericUpDown D2ADDBBC;

	internal NumericUpDown nudKhoangCachFrom;

	internal Label label18;

	internal Label label17;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal Label label16;

	internal Label label15;

	internal CheckBox ckbXoaNguyenLieuDaDung;

	internal LinkLabel linkLabel1;

	internal Button F237E938;

	internal Button button2;

	internal Panel plNhomChiDinh;

	internal CheckBox ckbTuDongXoaUid;

	internal Label D52EDC8A;

	internal RichTextBox txtIdNhomChiDinh;

	internal RadioButton rbNhomChiDinh;

	internal RadioButton E1126107;

	internal Panel D9B47B35;

	internal NumericUpDown E9B0D124;

	internal NumericUpDown A592FC9D;

	internal TextBox txtPathAnh;

	internal Label label10;

	internal Label E7266B16;

	internal Label A317E084;

	internal Label BE1A6523;

	internal CheckBox ckbAnh;

	internal Panel F2B33B8B;

	internal Label A681839B;

	internal RichTextBox txtLinkShare;

	internal CheckBox ckbXoaLink;

	internal CheckBox D3071605;

	internal GroupBox groupBox2;

	internal Panel plNhomNgauNhien;

	internal CheckBox BE2B1F3D;

	internal CheckBox A82AAF83;

	internal CheckBox C38EAEAB;

	internal CheckBox EABA219D;

	internal Button btnDown;

	internal Button btnUp;

	internal Button btnNhapDanhSachNhom;

	internal CheckBox ckbChiShareNhomThuocDanhSach;

	internal Panel A4258EBB;

	internal TextBox F203DFAF;

	internal Label label11;

	internal CheckBox B9B17B05;

	internal CheckBox ckbXuatLinkBaiViet;

	internal RadioButton A9088A8B;

	internal Panel plTaoNhomMoi;

	internal Label C80183A9;

	internal RichTextBox txtTenNhom;

	public fHDDangBaiNhom(string string_0, int int_1 = 0, string B4B58684 = "")
	{
		InitializeComponent();
		B503039D = false;
		E59290BC = string_0;
		F68196AE = B4B58684;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đăng ba\u0300i lên nho\u0301m";
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
			B2B8C832 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			F42D0F23.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(B4B58684);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			F42D0F23.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		B505438A = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDDangBaiNhom_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = B505438A.method_0("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = B505438A.method_0("nudSoLuongTo", 1);
			nudKhoangCachFrom.Value = B505438A.method_0("nudKhoangCachFrom", 5);
			D2ADDBBC.Value = B505438A.method_0("nudKhoangCachTo", 10);
			switch (B505438A.method_0("typeNhom"))
			{
			case 0:
				E1126107.Checked = true;
				break;
			case 1:
				rbNhomChiDinh.Checked = true;
				break;
			case 2:
				A9088A8B.Checked = true;
				break;
			}
			EABA219D.Checked = B505438A.AA824D29("ckbChiShareNhomKKD");
			C38EAEAB.Checked = B505438A.AA824D29("ckbUuTienShareNhomNhieuThanhVien");
			BE2B1F3D.Checked = B505438A.AA824D29("ckbBackupDanhSachNhom");
			A82AAF83.Checked = B505438A.AA824D29("ckbKhongShareTrungNhom");
			ckbChiShareNhomThuocDanhSach.Checked = B505438A.AA824D29("ckbChiShareNhomThuocDanhSach");
			A3291E2D = B505438A.EC378D8A("lstNhomTuNhap");
			txtIdNhomChiDinh.Text = B505438A.GetValue("txtIdNhomChiDinh");
			ckbTuDongXoaUid.Checked = B505438A.AA824D29("ckbTuDongXoaUid");
			txtTenNhom.Text = B505438A.GetValue("txtTenNhom");
			C7BAC338.Checked = B505438A.AA824D29("ckbVanBan");
			D03A79AB.Checked = B505438A.AA824D29("ckbUseBackground");
			ckbXoaNguyenLieuDaDung.Checked = B505438A.AA824D29("ckbXoaNguyenLieuDaDung");
			F71B57A4.Text = B505438A.GetValue("txtNoiDung");
			if (B505438A.method_0("typeNganCach") == 1)
			{
				A281CE3A.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			ckbAnh.Checked = B505438A.AA824D29("ckbAnh");
			txtPathAnh.Text = B505438A.GetValue("txtPathAnh");
			A592FC9D.Value = B505438A.method_0("nudSoLuongAnhFrom", 1);
			E9B0D124.Value = B505438A.method_0("nudSoLuongAnhTo", 1);
			D3071605.Checked = B505438A.AA824D29("ckbDangLink");
			txtLinkShare.Text = B505438A.GetValue("txtLinkShare");
			ckbXoaLink.Checked = B505438A.AA824D29("ckbXoaLink", A72188BC: true);
			B9B17B05.Checked = B505438A.AA824D29("ckbEvent");
			F203DFAF.Text = B505438A.GetValue("txtEvent");
			ckbXuatLinkBaiViet.Checked = B505438A.AA824D29("ckbXuatLinkBaiViet");
		}
		catch (Exception)
		{
		}
		BA27B026();
	}

	private void FB192587(object sender, EventArgs e)
	{
		Close();
	}

	private void D53A1A09(object sender, EventArgs e)
	{
		string text = F42D0F23.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudKhoangCachFrom", nudKhoangCachFrom.Value);
		f72FAFBC.GetValue("nudKhoangCachTo", D2ADDBBC.Value);
		if (E1126107.Checked)
		{
			f72FAFBC.GetValue("typeNhom", 0);
		}
		else if (rbNhomChiDinh.Checked)
		{
			f72FAFBC.GetValue("typeNhom", 1);
		}
		else
		{
			f72FAFBC.GetValue("typeNhom", 2);
		}
		f72FAFBC.GetValue("ckbChiShareNhomKKD", EABA219D.Checked);
		f72FAFBC.GetValue("ckbUuTienShareNhomNhieuThanhVien", C38EAEAB.Checked);
		f72FAFBC.GetValue("ckbBackupDanhSachNhom", BE2B1F3D.Checked);
		f72FAFBC.GetValue("ckbKhongShareTrungNhom", A82AAF83.Checked);
		f72FAFBC.GetValue("ckbChiShareNhomThuocDanhSach", ckbChiShareNhomThuocDanhSach.Checked);
		f72FAFBC.method_3("lstNhomTuNhap", A3291E2D);
		f72FAFBC.GetValue("txtIdNhomChiDinh", (object)txtIdNhomChiDinh.Text.Trim());
		f72FAFBC.GetValue("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		f72FAFBC.GetValue("txtTenNhom", (object)txtTenNhom.Text);
		f72FAFBC.GetValue("ckbVanBan", C7BAC338.Checked);
		f72FAFBC.GetValue("ckbUseBackground", D03A79AB.Checked);
		f72FAFBC.GetValue("ckbXoaNguyenLieuDaDung", ckbXoaNguyenLieuDaDung.Checked);
		f72FAFBC.GetValue("txtNoiDung", (object)F71B57A4.Text.Trim());
		int num = 0;
		if (A281CE3A.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		f72FAFBC.GetValue("ckbAnh", ckbAnh.Checked);
		f72FAFBC.GetValue("txtPathAnh", (object)txtPathAnh.Text.Trim());
		f72FAFBC.GetValue("nudSoLuongAnhFrom", A592FC9D.Value);
		f72FAFBC.GetValue("nudSoLuongAnhTo", E9B0D124.Value);
		f72FAFBC.GetValue("ckbDangLink", D3071605.Checked);
		f72FAFBC.GetValue("txtLinkShare", (object)txtLinkShare.Text.Trim());
		f72FAFBC.GetValue("ckbXoaLink", ckbXoaLink.Checked);
		f72FAFBC.GetValue("ckbEvent", B9B17B05.Checked);
		f72FAFBC.GetValue("txtEvent", (object)F203DFAF.Text.Trim());
		f72FAFBC.GetValue("ckbXuatLinkBaiViet", ckbXuatLinkBaiViet.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(E59290BC, text, B2B8C832, text2))
				{
					B503039D = true;
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
			if (Class123.smethod_14(F68196AE, text, text2))
			{
				B503039D = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void D9A27532(object sender, EventArgs e)
	{
		Close();
	}

	private void C6009F9C_Paint(object sender, PaintEventArgs e)
	{
		if (C6009F9C.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C6009F9C.ClientSize.Width - num, C6009F9C.ClientSize.Height - num));
		}
	}

	private void BA27B026()
	{
		C7BAC338_CheckedChanged(null, null);
		E62C80AB(null, null);
		F3960795(null, null);
		C9B7C439(null, null);
		A9088A8B_CheckedChanged(null, null);
		D3071605_CheckedChanged(null, null);
		ckbChiShareNhomThuocDanhSach_CheckedChanged(null, null);
		B9B17B05_CheckedChanged(null, null);
	}

	private void C7BAC338_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = C7BAC338.Checked;
		if (!C7BAC338.Checked)
		{
			D03A79AB.Checked = false;
		}
	}

	private void F71B57A4_TextChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? F71B57A4.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : F71B57A4.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch nô\u0323i dung ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void B13DE427(object sender, EventArgs e)
	{
	}

	private void B7BFA31F(object sender, EventArgs e)
	{
		method_0();
	}

	private void A281CE3A_CheckedChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void D03A79AB_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	private void F237E938_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
	}

	private void F3960795(object sender, EventArgs e)
	{
		plNhomNgauNhien.Enabled = E1126107.Checked;
	}

	private void C9B7C439(object sender, EventArgs e)
	{
		plNhomChiDinh.Enabled = rbNhomChiDinh.Checked;
	}

	private void txtIdNhomChiDinh_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtIdNhomChiDinh, D52EDC8A);
	}

	private void E62C80AB(object sender, EventArgs e)
	{
		D9B47B35.Enabled = ckbAnh.Checked;
		D03A79AB.Enabled = !ckbAnh.Checked;
		if (ckbAnh.Checked)
		{
			D03A79AB.Checked = false;
		}
	}

	private void D3071605_CheckedChanged(object sender, EventArgs e)
	{
		F2B33B8B.Enabled = D3071605.Checked;
	}

	private void txtLinkShare_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtLinkShare, A681839B);
	}

	private void EABA219D_Click(object sender, EventArgs e)
	{
		if (EABA219D.Checked && MessageBoxHelper.smethod_1(Language.GetValue("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) == DialogResult.No)
		{
			EABA219D.Checked = false;
		}
	}

	private void AC8346B3(object sender, EventArgs e)
	{
		plVanBan.Height = 120;
		D3071605.Visible = true;
	}

	private void BB25A434(object sender, EventArgs e)
	{
		plVanBan.Height = 248;
		D3071605.Visible = false;
	}

	private void method_1(object sender, EventArgs e)
	{
		F2B33B8B.Visible = D3071605.Visible;
	}

	private void ckbChiShareNhomThuocDanhSach_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapDanhSachNhom.Enabled = ckbChiShareNhomThuocDanhSach.Checked;
	}

	private void btnNhapDanhSachNhom_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(A3291E2D, "Nhâ\u0323p danh sa\u0301ch Id nhóm", "Danh sa\u0301ch Id nhóm", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		A3291E2D = fNhapDuLieu4.list_0;
	}

	private void EABA219D_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void B9B17B05_CheckedChanged(object sender, EventArgs e)
	{
		A4258EBB.Enabled = B9B17B05.Checked;
	}

	private void F3954F08(object sender, EventArgs e)
	{
		Common.D936DD84(txtTenNhom, C80183A9);
	}

	private void A9088A8B_CheckedChanged(object sender, EventArgs e)
	{
		plTaoNhomMoi.Enabled = A9088A8B.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangBaiNhom));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D412E794 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		A0AF3236 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		C6009F9C = new System.Windows.Forms.Panel();
		btnDown = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		groupBox2 = new System.Windows.Forms.GroupBox();
		plNhomNgauNhien = new System.Windows.Forms.Panel();
		btnNhapDanhSachNhom = new System.Windows.Forms.Button();
		ckbChiShareNhomThuocDanhSach = new System.Windows.Forms.CheckBox();
		BE2B1F3D = new System.Windows.Forms.CheckBox();
		A82AAF83 = new System.Windows.Forms.CheckBox();
		C38EAEAB = new System.Windows.Forms.CheckBox();
		EABA219D = new System.Windows.Forms.CheckBox();
		E1126107 = new System.Windows.Forms.RadioButton();
		rbNhomChiDinh = new System.Windows.Forms.RadioButton();
		plNhomChiDinh = new System.Windows.Forms.Panel();
		ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		D52EDC8A = new System.Windows.Forms.Label();
		txtIdNhomChiDinh = new System.Windows.Forms.RichTextBox();
		A4258EBB = new System.Windows.Forms.Panel();
		F203DFAF = new System.Windows.Forms.TextBox();
		label11 = new System.Windows.Forms.Label();
		D9B47B35 = new System.Windows.Forms.Panel();
		E9B0D124 = new System.Windows.Forms.NumericUpDown();
		A592FC9D = new System.Windows.Forms.NumericUpDown();
		txtPathAnh = new System.Windows.Forms.TextBox();
		label10 = new System.Windows.Forms.Label();
		E7266B16 = new System.Windows.Forms.Label();
		A317E084 = new System.Windows.Forms.Label();
		BE1A6523 = new System.Windows.Forms.Label();
		ckbXuatLinkBaiViet = new System.Windows.Forms.CheckBox();
		B9B17B05 = new System.Windows.Forms.CheckBox();
		ckbAnh = new System.Windows.Forms.CheckBox();
		label19 = new System.Windows.Forms.Label();
		D6B36815 = new System.Windows.Forms.Label();
		D2ADDBBC = new System.Windows.Forms.NumericUpDown();
		nudKhoangCachFrom = new System.Windows.Forms.NumericUpDown();
		label18 = new System.Windows.Forms.Label();
		label17 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		label16 = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		plVanBan = new System.Windows.Forms.Panel();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		F237E938 = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		A281CE3A = new System.Windows.Forms.RadioButton();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		EFA35D1F = new System.Windows.Forms.Label();
		F71B57A4 = new System.Windows.Forms.RichTextBox();
		E6B61E2B = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		D03A79AB = new System.Windows.Forms.CheckBox();
		ckbXoaNguyenLieuDaDung = new System.Windows.Forms.CheckBox();
		btnAdd = new System.Windows.Forms.Button();
		C7BAC338 = new System.Windows.Forms.CheckBox();
		F42D0F23 = new System.Windows.Forms.TextBox();
		DBA61BB0 = new System.Windows.Forms.Label();
		C42BD19C = new System.Windows.Forms.Button();
		D60160A8 = new Bunifu.Framework.UI.BunifuCards();
		F2B33B8B = new System.Windows.Forms.Panel();
		A681839B = new System.Windows.Forms.Label();
		txtLinkShare = new System.Windows.Forms.RichTextBox();
		ckbXoaLink = new System.Windows.Forms.CheckBox();
		D3071605 = new System.Windows.Forms.CheckBox();
		A9088A8B = new System.Windows.Forms.RadioButton();
		plTaoNhomMoi = new System.Windows.Forms.Panel();
		C80183A9 = new System.Windows.Forms.Label();
		txtTenNhom = new System.Windows.Forms.RichTextBox();
		A0AF3236.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		C6009F9C.SuspendLayout();
		groupBox2.SuspendLayout();
		plNhomNgauNhien.SuspendLayout();
		plNhomChiDinh.SuspendLayout();
		A4258EBB.SuspendLayout();
		D9B47B35.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E9B0D124).BeginInit();
		((System.ComponentModel.ISupportInitialize)A592FC9D).BeginInit();
		((System.ComponentModel.ISupportInitialize)D2ADDBBC).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		plVanBan.SuspendLayout();
		D60160A8.SuspendLayout();
		F2B33B8B.SuspendLayout();
		plTaoNhomMoi.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(1027, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đăng ba\u0300i lên nho\u0301m";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D412E794.Fixed = true;
		D412E794.Horizontal = true;
		D412E794.TargetControl = A0AF3236;
		D412E794.Vertical = true;
		A0AF3236.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A0AF3236.BackColor = System.Drawing.Color.White;
		A0AF3236.Controls.Add(button1);
		A0AF3236.Controls.Add(pictureBox1);
		A0AF3236.Controls.Add(bunifuCustomLabel1);
		A0AF3236.Cursor = System.Windows.Forms.Cursors.SizeAll;
		A0AF3236.Location = new System.Drawing.Point(0, 3);
		A0AF3236.Name = "pnlHeader";
		A0AF3236.Size = new System.Drawing.Size(1027, 31);
		A0AF3236.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(996, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 0;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(FB192587);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(B13DE427);
		C6009F9C.BackColor = System.Drawing.Color.White;
		C6009F9C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C6009F9C.Controls.Add(btnDown);
		C6009F9C.Controls.Add(btnUp);
		C6009F9C.Controls.Add(groupBox2);
		C6009F9C.Controls.Add(A4258EBB);
		C6009F9C.Controls.Add(D9B47B35);
		C6009F9C.Controls.Add(ckbXuatLinkBaiViet);
		C6009F9C.Controls.Add(B9B17B05);
		C6009F9C.Controls.Add(ckbAnh);
		C6009F9C.Controls.Add(label19);
		C6009F9C.Controls.Add(D6B36815);
		C6009F9C.Controls.Add(D2ADDBBC);
		C6009F9C.Controls.Add(nudKhoangCachFrom);
		C6009F9C.Controls.Add(label18);
		C6009F9C.Controls.Add(label17);
		C6009F9C.Controls.Add(nudSoLuongTo);
		C6009F9C.Controls.Add(nudSoLuongFrom);
		C6009F9C.Controls.Add(label16);
		C6009F9C.Controls.Add(label15);
		C6009F9C.Controls.Add(plVanBan);
		C6009F9C.Controls.Add(btnAdd);
		C6009F9C.Controls.Add(C7BAC338);
		C6009F9C.Controls.Add(F42D0F23);
		C6009F9C.Controls.Add(DBA61BB0);
		C6009F9C.Controls.Add(C42BD19C);
		C6009F9C.Controls.Add(D60160A8);
		C6009F9C.Controls.Add(F2B33B8B);
		C6009F9C.Controls.Add(D3071605);
		C6009F9C.Cursor = System.Windows.Forms.Cursors.Arrow;
		C6009F9C.Dock = System.Windows.Forms.DockStyle.Fill;
		C6009F9C.Location = new System.Drawing.Point(0, 0);
		C6009F9C.Name = "panel1";
		C6009F9C.Size = new System.Drawing.Size(1030, 609);
		C6009F9C.TabIndex = 0;
		C6009F9C.Paint += new System.Windows.Forms.PaintEventHandler(C6009F9C_Paint);
		btnDown.BackgroundImage = Resource.Bitmap_91;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Location = new System.Drawing.Point(619, 129);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 202;
		btnDown.Click += new System.EventHandler(BB25A434);
		btnUp.BackgroundImage = Resource.Bitmap_73;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Location = new System.Drawing.Point(588, 129);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 203;
		btnUp.Click += new System.EventHandler(AC8346B3);
		groupBox2.Controls.Add(plNhomNgauNhien);
		groupBox2.Controls.Add(E1126107);
		groupBox2.Controls.Add(A9088A8B);
		groupBox2.Controls.Add(rbNhomChiDinh);
		groupBox2.Controls.Add(plTaoNhomMoi);
		groupBox2.Controls.Add(plNhomChiDinh);
		groupBox2.Location = new System.Drawing.Point(676, 136);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(312, 416);
		groupBox2.TabIndex = 63;
		groupBox2.TabStop = false;
		groupBox2.Text = "Tùy chọn nhóm";
		plNhomNgauNhien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plNhomNgauNhien.Controls.Add(btnNhapDanhSachNhom);
		plNhomNgauNhien.Controls.Add(ckbChiShareNhomThuocDanhSach);
		plNhomNgauNhien.Controls.Add(BE2B1F3D);
		plNhomNgauNhien.Controls.Add(A82AAF83);
		plNhomNgauNhien.Controls.Add(C38EAEAB);
		plNhomNgauNhien.Controls.Add(EABA219D);
		plNhomNgauNhien.Location = new System.Drawing.Point(28, 45);
		plNhomNgauNhien.Name = "plNhomNgauNhien";
		plNhomNgauNhien.Size = new System.Drawing.Size(277, 132);
		plNhomNgauNhien.TabIndex = 58;
		btnNhapDanhSachNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapDanhSachNhom.Location = new System.Drawing.Point(217, 102);
		btnNhapDanhSachNhom.Name = "btnNhapDanhSachNhom";
		btnNhapDanhSachNhom.Size = new System.Drawing.Size(55, 25);
		btnNhapDanhSachNhom.TabIndex = 6;
		btnNhapDanhSachNhom.Text = "Nhập";
		btnNhapDanhSachNhom.UseVisualStyleBackColor = true;
		btnNhapDanhSachNhom.Click += new System.EventHandler(btnNhapDanhSachNhom_Click);
		ckbChiShareNhomThuocDanhSach.AutoSize = true;
		ckbChiShareNhomThuocDanhSach.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChiShareNhomThuocDanhSach.Location = new System.Drawing.Point(4, 105);
		ckbChiShareNhomThuocDanhSach.Name = "ckbChiShareNhomThuocDanhSach";
		ckbChiShareNhomThuocDanhSach.Size = new System.Drawing.Size(214, 20);
		ckbChiShareNhomThuocDanhSach.TabIndex = 5;
		ckbChiShareNhomThuocDanhSach.Text = "Chỉ đăng nhóm thuộc danh sách:";
		ckbChiShareNhomThuocDanhSach.UseVisualStyleBackColor = true;
		ckbChiShareNhomThuocDanhSach.CheckedChanged += new System.EventHandler(ckbChiShareNhomThuocDanhSach_CheckedChanged);
		BE2B1F3D.AutoSize = true;
		BE2B1F3D.Cursor = System.Windows.Forms.Cursors.Hand;
		BE2B1F3D.Location = new System.Drawing.Point(4, 80);
		BE2B1F3D.Name = "ckbBackupDanhSachNhom";
		BE2B1F3D.Size = new System.Drawing.Size(234, 20);
		BE2B1F3D.TabIndex = 3;
		BE2B1F3D.Text = "Sử dụng danh sách nhóm đã backup";
		BE2B1F3D.UseVisualStyleBackColor = true;
		A82AAF83.AutoSize = true;
		A82AAF83.Cursor = System.Windows.Forms.Cursors.Hand;
		A82AAF83.Location = new System.Drawing.Point(4, 55);
		A82AAF83.Name = "ckbKhongShareTrungNhom";
		A82AAF83.Size = new System.Drawing.Size(269, 20);
		A82AAF83.TabIndex = 3;
		A82AAF83.Text = "Không đăng tru\u0300ng nho\u0301m với tài khoản khác";
		A82AAF83.UseVisualStyleBackColor = true;
		C38EAEAB.AutoSize = true;
		C38EAEAB.Cursor = System.Windows.Forms.Cursors.Hand;
		C38EAEAB.Location = new System.Drawing.Point(4, 29);
		C38EAEAB.Name = "ckbUuTienShareNhomNhieuThanhVien";
		C38EAEAB.Size = new System.Drawing.Size(250, 20);
		C38EAEAB.TabIndex = 3;
		C38EAEAB.Text = "Ưu tiên đăng nho\u0301m co\u0301 nhiê\u0300u tha\u0300nh viên";
		C38EAEAB.UseVisualStyleBackColor = true;
		EABA219D.AutoSize = true;
		EABA219D.Cursor = System.Windows.Forms.Cursors.Hand;
		EABA219D.Location = new System.Drawing.Point(4, 3);
		EABA219D.Name = "ckbChiShareNhomKKD";
		EABA219D.Size = new System.Drawing.Size(216, 20);
		EABA219D.TabIndex = 3;
		EABA219D.Text = "Chi\u0309 đăng nho\u0301m không kiê\u0309m duyê\u0323t";
		EABA219D.UseVisualStyleBackColor = true;
		EABA219D.CheckedChanged += new System.EventHandler(EABA219D_CheckedChanged);
		EABA219D.Click += new System.EventHandler(EABA219D_Click);
		E1126107.AutoSize = true;
		E1126107.Cursor = System.Windows.Forms.Cursors.Hand;
		E1126107.Location = new System.Drawing.Point(9, 21);
		E1126107.Name = "rbNhomNgauNhien";
		E1126107.Size = new System.Drawing.Size(197, 20);
		E1126107.TabIndex = 57;
		E1126107.TabStop = true;
		E1126107.Text = "Ngẫu nhiên nhóm đã tham gia";
		E1126107.UseVisualStyleBackColor = true;
		E1126107.CheckedChanged += new System.EventHandler(F3960795);
		rbNhomChiDinh.AutoSize = true;
		rbNhomChiDinh.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNhomChiDinh.Location = new System.Drawing.Point(9, 179);
		rbNhomChiDinh.Name = "rbNhomChiDinh";
		rbNhomChiDinh.Size = new System.Drawing.Size(106, 20);
		rbNhomChiDinh.TabIndex = 57;
		rbNhomChiDinh.TabStop = true;
		rbNhomChiDinh.Text = "Nho\u0301m chi\u0309 đi\u0323nh";
		rbNhomChiDinh.UseVisualStyleBackColor = true;
		rbNhomChiDinh.CheckedChanged += new System.EventHandler(C9B7C439);
		plNhomChiDinh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plNhomChiDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plNhomChiDinh.Controls.Add(ckbTuDongXoaUid);
		plNhomChiDinh.Controls.Add(D52EDC8A);
		plNhomChiDinh.Controls.Add(txtIdNhomChiDinh);
		plNhomChiDinh.Location = new System.Drawing.Point(28, 201);
		plNhomChiDinh.Name = "plNhomChiDinh";
		plNhomChiDinh.Size = new System.Drawing.Size(277, 115);
		plNhomChiDinh.TabIndex = 58;
		ckbTuDongXoaUid.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaUid.Location = new System.Drawing.Point(5, 91);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new System.Drawing.Size(164, 20);
		ckbTuDongXoaUid.TabIndex = 168;
		ckbTuDongXoaUid.Text = "Tự động xóa ID đã dùng";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		D52EDC8A.AutoSize = true;
		D52EDC8A.Location = new System.Drawing.Point(2, 2);
		D52EDC8A.Name = "label12";
		D52EDC8A.Size = new System.Drawing.Size(115, 16);
		D52EDC8A.TabIndex = 0;
		D52EDC8A.Text = "Nhâ\u0323p ID Nho\u0301m (0):";
		txtIdNhomChiDinh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtIdNhomChiDinh.Location = new System.Drawing.Point(5, 21);
		txtIdNhomChiDinh.Name = "txtIdNhomChiDinh";
		txtIdNhomChiDinh.Size = new System.Drawing.Size(264, 68);
		txtIdNhomChiDinh.TabIndex = 34;
		txtIdNhomChiDinh.Text = "";
		txtIdNhomChiDinh.WordWrap = false;
		txtIdNhomChiDinh.TextChanged += new System.EventHandler(txtIdNhomChiDinh_TextChanged);
		A4258EBB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A4258EBB.Controls.Add(F203DFAF);
		A4258EBB.Controls.Add(label11);
		A4258EBB.Location = new System.Drawing.Point(47, 521);
		A4258EBB.Name = "plEvent";
		A4258EBB.Size = new System.Drawing.Size(597, 31);
		A4258EBB.TabIndex = 60;
		F203DFAF.Location = new System.Drawing.Point(113, 3);
		F203DFAF.Name = "txtEvent";
		F203DFAF.Size = new System.Drawing.Size(479, 23);
		F203DFAF.TabIndex = 1;
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(3, 6);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(79, 16);
		label11.TabIndex = 0;
		label11.Text = "Tên sự kiện:";
		D9B47B35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D9B47B35.Controls.Add(E9B0D124);
		D9B47B35.Controls.Add(A592FC9D);
		D9B47B35.Controls.Add(txtPathAnh);
		D9B47B35.Controls.Add(label10);
		D9B47B35.Controls.Add(E7266B16);
		D9B47B35.Controls.Add(A317E084);
		D9B47B35.Controls.Add(BE1A6523);
		D9B47B35.Location = new System.Drawing.Point(47, 435);
		D9B47B35.Name = "plAnh";
		D9B47B35.Size = new System.Drawing.Size(597, 58);
		D9B47B35.TabIndex = 60;
		E9B0D124.Location = new System.Drawing.Point(191, 30);
		E9B0D124.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		E9B0D124.Name = "nudSoLuongAnhTo";
		E9B0D124.Size = new System.Drawing.Size(45, 23);
		E9B0D124.TabIndex = 3;
		A592FC9D.Location = new System.Drawing.Point(113, 30);
		A592FC9D.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		A592FC9D.Name = "nudSoLuongAnhFrom";
		A592FC9D.Size = new System.Drawing.Size(45, 23);
		A592FC9D.TabIndex = 3;
		txtPathAnh.Location = new System.Drawing.Point(113, 3);
		txtPathAnh.Name = "txtPathAnh";
		txtPathAnh.Size = new System.Drawing.Size(479, 23);
		txtPathAnh.TabIndex = 1;
		label10.Location = new System.Drawing.Point(160, 32);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(29, 16);
		label10.TabIndex = 0;
		label10.Text = "đến";
		label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E7266B16.AutoSize = true;
		E7266B16.Location = new System.Drawing.Point(236, 32);
		E7266B16.Name = "label4";
		E7266B16.Size = new System.Drawing.Size(28, 16);
		E7266B16.TabIndex = 0;
		E7266B16.Text = "a\u0309nh";
		A317E084.AutoSize = true;
		A317E084.Location = new System.Drawing.Point(3, 32);
		A317E084.Name = "label3";
		A317E084.Size = new System.Drawing.Size(110, 16);
		A317E084.TabIndex = 0;
		A317E084.Text = "Sô\u0301 lươ\u0323ng a\u0309nh/bài:";
		BE1A6523.AutoSize = true;
		BE1A6523.Location = new System.Drawing.Point(3, 6);
		BE1A6523.Name = "label5";
		BE1A6523.Size = new System.Drawing.Size(88, 16);
		BE1A6523.TabIndex = 0;
		BE1A6523.Text = "Thư mu\u0323c ảnh:";
		ckbXuatLinkBaiViet.AutoSize = true;
		ckbXuatLinkBaiViet.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXuatLinkBaiViet.Location = new System.Drawing.Point(481, 497);
		ckbXuatLinkBaiViet.Name = "ckbXuatLinkBaiViet";
		ckbXuatLinkBaiViet.Size = new System.Drawing.Size(170, 20);
		ckbXuatLinkBaiViet.TabIndex = 59;
		ckbXuatLinkBaiViet.Text = "Xuất link bài viết đã đăng";
		ckbXuatLinkBaiViet.UseVisualStyleBackColor = true;
		B9B17B05.AutoSize = true;
		B9B17B05.Cursor = System.Windows.Forms.Cursors.Hand;
		B9B17B05.Location = new System.Drawing.Point(33, 497);
		B9B17B05.Name = "ckbEvent";
		B9B17B05.Size = new System.Drawing.Size(115, 20);
		B9B17B05.TabIndex = 59;
		B9B17B05.Text = "Gắn thẻ sự kiện";
		B9B17B05.UseVisualStyleBackColor = true;
		B9B17B05.CheckedChanged += new System.EventHandler(B9B17B05_CheckedChanged);
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAnh.Location = new System.Drawing.Point(33, 411);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new System.Drawing.Size(48, 20);
		ckbAnh.TabIndex = 59;
		ckbAnh.Text = "A\u0309nh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += new System.EventHandler(E62C80AB);
		label19.AutoSize = true;
		label19.Location = new System.Drawing.Point(291, 108);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(30, 16);
		label19.TabIndex = 43;
		label19.Text = "giây";
		D6B36815.Location = new System.Drawing.Point(205, 108);
		D6B36815.Name = "label20";
		D6B36815.Size = new System.Drawing.Size(29, 16);
		D6B36815.TabIndex = 42;
		D6B36815.Text = "đến";
		D6B36815.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D2ADDBBC.Location = new System.Drawing.Point(236, 106);
		D2ADDBBC.Name = "nudKhoangCachTo";
		D2ADDBBC.Size = new System.Drawing.Size(51, 23);
		D2ADDBBC.TabIndex = 41;
		nudKhoangCachFrom.Location = new System.Drawing.Point(151, 106);
		nudKhoangCachFrom.Name = "nudKhoangCachFrom";
		nudKhoangCachFrom.Size = new System.Drawing.Size(51, 23);
		nudKhoangCachFrom.TabIndex = 40;
		label18.AutoSize = true;
		label18.Location = new System.Drawing.Point(291, 83);
		label18.Name = "label18";
		label18.Size = new System.Drawing.Size(39, 16);
		label18.TabIndex = 39;
		label18.Text = "nho\u0301m";
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
		nudSoLuongFrom.Location = new System.Drawing.Point(151, 78);
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(51, 23);
		nudSoLuongFrom.TabIndex = 36;
		label16.AutoSize = true;
		label16.Location = new System.Drawing.Point(30, 108);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(116, 16);
		label16.TabIndex = 35;
		label16.Text = "Khoảng cách đăng:";
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(30, 83);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(99, 16);
		label15.TabIndex = 34;
		label15.Text = "Số lượng nho\u0301m:";
		plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plVanBan.Controls.Add(linkLabel1);
		plVanBan.Controls.Add(F237E938);
		plVanBan.Controls.Add(button2);
		plVanBan.Controls.Add(A281CE3A);
		plVanBan.Controls.Add(rbNganCachMoiDong);
		plVanBan.Controls.Add(EFA35D1F);
		plVanBan.Controls.Add(F71B57A4);
		plVanBan.Controls.Add(E6B61E2B);
		plVanBan.Controls.Add(lblStatus);
		plVanBan.Controls.Add(D03A79AB);
		plVanBan.Controls.Add(ckbXoaNguyenLieuDaDung);
		plVanBan.Location = new System.Drawing.Point(47, 159);
		plVanBan.Name = "plVanBan";
		plVanBan.Size = new System.Drawing.Size(597, 248);
		plVanBan.TabIndex = 33;
		linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.Location = new System.Drawing.Point(154, 198);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(81, 16);
		linkLabel1.TabIndex = 195;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		F237E938.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		F237E938.Cursor = System.Windows.Forms.Cursors.Help;
		F237E938.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F237E938.Location = new System.Drawing.Point(571, 220);
		F237E938.Name = "button3";
		F237E938.Size = new System.Drawing.Size(21, 23);
		F237E938.TabIndex = 193;
		F237E938.Text = "?";
		F237E938.UseVisualStyleBackColor = true;
		F237E938.Click += new System.EventHandler(F237E938_Click);
		button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(571, 197);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 23);
		button2.TabIndex = 194;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		A281CE3A.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		A281CE3A.AutoSize = true;
		A281CE3A.Cursor = System.Windows.Forms.Cursors.Hand;
		A281CE3A.Location = new System.Drawing.Point(412, 221);
		A281CE3A.Name = "rbNganCachKyTu";
		A281CE3A.Size = new System.Drawing.Size(159, 20);
		A281CE3A.TabIndex = 37;
		A281CE3A.Text = "Nội dung có nhiều dòng";
		A281CE3A.UseVisualStyleBackColor = true;
		A281CE3A.CheckedChanged += new System.EventHandler(A281CE3A_CheckedChanged);
		rbNganCachMoiDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(412, 199);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		rbNganCachMoiDong.TabIndex = 36;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += new System.EventHandler(B7BFA31F);
		EFA35D1F.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		EFA35D1F.AutoSize = true;
		EFA35D1F.Location = new System.Drawing.Point(347, 199);
		EFA35D1F.Name = "label9";
		EFA35D1F.Size = new System.Drawing.Size(64, 16);
		EFA35D1F.TabIndex = 35;
		EFA35D1F.Text = "Tùy chọn:";
		F71B57A4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F71B57A4.Location = new System.Drawing.Point(7, 24);
		F71B57A4.Name = "txtNoiDung";
		F71B57A4.Size = new System.Drawing.Size(585, 172);
		F71B57A4.TabIndex = 34;
		F71B57A4.Text = "";
		F71B57A4.WordWrap = false;
		F71B57A4.TextChanged += new System.EventHandler(F71B57A4_TextChanged);
		E6B61E2B.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		E6B61E2B.AutoSize = true;
		E6B61E2B.Location = new System.Drawing.Point(4, 198);
		E6B61E2B.Name = "label8";
		E6B61E2B.Size = new System.Drawing.Size(143, 16);
		E6B61E2B.TabIndex = 0;
		E6B61E2B.Text = "(Spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(145, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		D03A79AB.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		D03A79AB.AutoSize = true;
		D03A79AB.Cursor = System.Windows.Forms.Cursors.Hand;
		D03A79AB.Location = new System.Drawing.Point(6, 221);
		D03A79AB.Name = "ckbUseBackground";
		D03A79AB.Size = new System.Drawing.Size(144, 20);
		D03A79AB.TabIndex = 32;
		D03A79AB.Text = "Sử dụng Background";
		D03A79AB.UseVisualStyleBackColor = true;
		D03A79AB.CheckedChanged += new System.EventHandler(D03A79AB_CheckedChanged);
		ckbXoaNguyenLieuDaDung.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		ckbXoaNguyenLieuDaDung.AutoSize = true;
		ckbXoaNguyenLieuDaDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaNguyenLieuDaDung.Location = new System.Drawing.Point(157, 221);
		ckbXoaNguyenLieuDaDung.Name = "ckbXoaNguyenLieuDaDung";
		ckbXoaNguyenLieuDaDung.Size = new System.Drawing.Size(151, 20);
		ckbXoaNguyenLieuDaDung.TabIndex = 32;
		ckbXoaNguyenLieuDaDung.Text = "Xóa nội dung đã đăng";
		ckbXoaNguyenLieuDaDung.UseVisualStyleBackColor = true;
		ckbXoaNguyenLieuDaDung.CheckedChanged += new System.EventHandler(C7BAC338_CheckedChanged);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(419, 568);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(D53A1A09);
		C7BAC338.AutoSize = true;
		C7BAC338.Cursor = System.Windows.Forms.Cursors.Hand;
		C7BAC338.Location = new System.Drawing.Point(33, 136);
		C7BAC338.Name = "ckbVanBan";
		C7BAC338.Size = new System.Drawing.Size(73, 20);
		C7BAC338.TabIndex = 32;
		C7BAC338.Text = "Văn ba\u0309n";
		C7BAC338.UseVisualStyleBackColor = true;
		C7BAC338.CheckedChanged += new System.EventHandler(C7BAC338_CheckedChanged);
		F42D0F23.Location = new System.Drawing.Point(151, 49);
		F42D0F23.Name = "txtTenHanhDong";
		F42D0F23.Size = new System.Drawing.Size(174, 23);
		F42D0F23.TabIndex = 0;
		DBA61BB0.AutoSize = true;
		DBA61BB0.Location = new System.Drawing.Point(30, 52);
		DBA61BB0.Name = "label1";
		DBA61BB0.Size = new System.Drawing.Size(98, 16);
		DBA61BB0.TabIndex = 31;
		DBA61BB0.Text = "Tên ha\u0300nh đô\u0323ng:";
		C42BD19C.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		C42BD19C.BackColor = System.Drawing.Color.Maroon;
		C42BD19C.Cursor = System.Windows.Forms.Cursors.Hand;
		C42BD19C.FlatAppearance.BorderSize = 0;
		C42BD19C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C42BD19C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C42BD19C.ForeColor = System.Drawing.Color.White;
		C42BD19C.Location = new System.Drawing.Point(518, 568);
		C42BD19C.Name = "btnCancel";
		C42BD19C.Size = new System.Drawing.Size(92, 29);
		C42BD19C.TabIndex = 4;
		C42BD19C.Text = "Đóng";
		C42BD19C.UseVisualStyleBackColor = false;
		C42BD19C.Click += new System.EventHandler(D9A27532);
		D60160A8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D60160A8.BackColor = System.Drawing.Color.White;
		D60160A8.BorderRadius = 0;
		D60160A8.BottomSahddow = true;
		D60160A8.color = System.Drawing.Color.DarkViolet;
		D60160A8.Controls.Add(A0AF3236);
		D60160A8.LeftSahddow = false;
		D60160A8.Location = new System.Drawing.Point(1, 0);
		D60160A8.Name = "bunifuCards1";
		D60160A8.RightSahddow = true;
		D60160A8.ShadowDepth = 20;
		D60160A8.Size = new System.Drawing.Size(1027, 37);
		D60160A8.TabIndex = 28;
		F2B33B8B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F2B33B8B.Controls.Add(A681839B);
		F2B33B8B.Controls.Add(txtLinkShare);
		F2B33B8B.Controls.Add(ckbXoaLink);
		F2B33B8B.Location = new System.Drawing.Point(47, 305);
		F2B33B8B.Name = "plDangLink";
		F2B33B8B.Size = new System.Drawing.Size(597, 102);
		F2B33B8B.TabIndex = 58;
		A681839B.AutoSize = true;
		A681839B.Location = new System.Drawing.Point(2, 2);
		A681839B.Name = "lblDanhSachLink";
		A681839B.Size = new System.Drawing.Size(115, 16);
		A681839B.TabIndex = 0;
		A681839B.Text = "Danh sách link (0):";
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
		D3071605.AutoSize = true;
		D3071605.Cursor = System.Windows.Forms.Cursors.Hand;
		D3071605.Location = new System.Drawing.Point(33, 283);
		D3071605.Name = "ckbDangLink";
		D3071605.Size = new System.Drawing.Size(79, 20);
		D3071605.TabIndex = 32;
		D3071605.Text = "Đăng link";
		D3071605.UseVisualStyleBackColor = true;
		D3071605.Visible = false;
		D3071605.CheckedChanged += new System.EventHandler(D3071605_CheckedChanged);
		A9088A8B.AutoSize = true;
		A9088A8B.Cursor = System.Windows.Forms.Cursors.Hand;
		A9088A8B.Location = new System.Drawing.Point(9, 318);
		A9088A8B.Name = "rbNhomMoiTao";
		A9088A8B.Size = new System.Drawing.Size(108, 20);
		A9088A8B.TabIndex = 57;
		A9088A8B.TabStop = true;
		A9088A8B.Text = "Tạo nhóm mới";
		A9088A8B.UseVisualStyleBackColor = true;
		A9088A8B.CheckedChanged += new System.EventHandler(A9088A8B_CheckedChanged);
		plTaoNhomMoi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plTaoNhomMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTaoNhomMoi.Controls.Add(C80183A9);
		plTaoNhomMoi.Controls.Add(txtTenNhom);
		plTaoNhomMoi.Location = new System.Drawing.Point(28, 340);
		plTaoNhomMoi.Name = "plTaoNhomMoi";
		plTaoNhomMoi.Size = new System.Drawing.Size(277, 69);
		plTaoNhomMoi.TabIndex = 58;
		C80183A9.AutoSize = true;
		C80183A9.Location = new System.Drawing.Point(2, 2);
		C80183A9.Name = "label2";
		C80183A9.Size = new System.Drawing.Size(120, 16);
		C80183A9.TabIndex = 0;
		C80183A9.Text = "Nhâ\u0323p tên nho\u0301m (0):";
		txtTenNhom.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtTenNhom.Location = new System.Drawing.Point(5, 21);
		txtTenNhom.Name = "txtTenNhom";
		txtTenNhom.Size = new System.Drawing.Size(264, 43);
		txtTenNhom.TabIndex = 34;
		txtTenNhom.Text = "";
		txtTenNhom.WordWrap = false;
		txtTenNhom.TextChanged += new System.EventHandler(F3954F08);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1030, 609);
		base.Controls.Add(C6009F9C);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangBaiNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDangBaiNhom_Load);
		A0AF3236.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		C6009F9C.ResumeLayout(false);
		C6009F9C.PerformLayout();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		plNhomNgauNhien.ResumeLayout(false);
		plNhomNgauNhien.PerformLayout();
		plNhomChiDinh.ResumeLayout(false);
		plNhomChiDinh.PerformLayout();
		A4258EBB.ResumeLayout(false);
		A4258EBB.PerformLayout();
		D9B47B35.ResumeLayout(false);
		D9B47B35.PerformLayout();
		((System.ComponentModel.ISupportInitialize)E9B0D124).EndInit();
		((System.ComponentModel.ISupportInitialize)A592FC9D).EndInit();
		((System.ComponentModel.ISupportInitialize)D2ADDBBC).EndInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		plVanBan.ResumeLayout(false);
		plVanBan.PerformLayout();
		D60160A8.ResumeLayout(false);
		F2B33B8B.ResumeLayout(false);
		F2B33B8B.PerformLayout();
		plTaoNhomMoi.ResumeLayout(false);
		plTaoNhomMoi.PerformLayout();
		ResumeLayout(false);
	}
}
