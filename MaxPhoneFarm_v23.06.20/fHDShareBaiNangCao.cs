using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDShareBaiNangCao : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string AA875C27;

	internal string string_1;

	internal int CF87BFA4;

	internal static bool bool_0;

	internal List<CheckBox> B83D9A3A;

	internal List<string> list_0 = new List<string>();

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel E7203128;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button F817240A;

	internal PictureBox B03C479B;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal GroupBox CD0E8118;

	internal Panel plShareBaiLenNhom;

	internal NumericUpDown F2374705;

	internal NumericUpDown nudCountGroupFrom;

	internal Label label24;

	internal Label label25;

	internal Label A508BC8B;

	internal CheckBox ckbShareBaiLenNhom;

	internal CheckBox ckbShareBaiLenTuong;

	internal Panel FC9A9D9E;

	internal CheckBox ckbChiShareNhomKKD;

	internal CheckBox ckbUuTienShareNhomNhieuThanhVien;

	internal CheckBox ckbKhongShareTrungNhom;

	internal CheckBox ckbShareNhomNangCao;

	internal GroupBox groupBox1;

	internal RichTextBox txtLinkChiaSe;

	internal Panel C7096999;

	internal Label label22;

	internal Panel FE812AA5;

	internal LinkLabel linkLabel2;

	internal Panel plBinhLuanNhieuLan;

	internal NumericUpDown C22047BD;

	internal Label F1A0CD00;

	internal NumericUpDown nudBinhLuanNhieuLanDelayFrom;

	internal Label label9;

	internal Label AE16D73F;

	internal CheckBox D5977B1F;

	internal Label label14;

	internal TextBox A0217238;

	internal Label label15;

	internal Label label21;

	internal Label CF917E3C;

	internal CheckBox C6ABB007;

	internal NumericUpDown nudSoLuongFrom;

	internal CheckBox ckbInteract;

	internal NumericUpDown nudSoLuongTo;

	internal Panel plVanBan;

	internal RichTextBox txtNoiDung;

	internal Label D135B7B0;

	internal Label lblNoiDung;

	internal RadioButton rbShareOther;

	internal RadioButton C012FA84;

	internal CheckBox ckbTuongTacTruocKhiShare;

	internal Label BD37D316;

	internal Label F432E4BF;

	internal CheckBox ckbVanBan;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown BE2E11A7;

	internal Label label20;

	internal Label F8990085;

	internal Label label2;

	internal CheckBox ckbBackupDanhSachNhom;

	internal RadioButton rbShareReel;

	internal Button B6B2F98F;

	internal CheckBox ckbChiShareNhomThuocDanhSach;

	internal Panel C2BB709D;

	internal CheckBox ckbGian;

	internal CheckBox ckbBuon;

	internal CheckBox DEA87210;

	internal CheckBox ckbHaha;

	internal CheckBox ckbThuong;

	internal CheckBox ckbTym;

	internal CheckBox ckbLike;

	internal Panel panel7;

	internal RadioButton E52AA81D;

	internal RadioButton D6A64593;

	internal Label FE902220;

	internal CheckBox ckbTuDongXoaNoiDung;

	internal ComboBox D2388F21;

	internal Button btnHuongDanNhapNoiDung;

	internal Label label5;

	public fHDShareBaiNangCao(string string_2, int AC0832B1 = 0, string F59BDB3D = "")
	{
		InitializeComponent();
		Language.SetLanguage(this);
		bool_0 = false;
		string_0 = string_2;
		string_1 = F59BDB3D;
		CF87BFA4 = AC0832B1;
		string text = base.Name.Substring(1);
		string text2 = "Share bài nâng cao";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (AC0832B1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			AA875C27 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(F59BDB3D);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		B83D9A3A = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, ckbHaha, DEA87210, ckbBuon, ckbGian };
	}

	private void E6A0448C(object sender, EventArgs e)
	{
		D72CDDBB();
		try
		{
			BE2E11A7.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			ckbShareBaiLenTuong.Checked = f72FAFBC_0.AA824D29("ckbShareBaiLenTuong");
			ckbShareBaiLenNhom.Checked = f72FAFBC_0.AA824D29("ckbShareBaiLenNhom");
			nudCountGroupFrom.Value = f72FAFBC_0.method_0("nudCountGroupFrom", 1);
			F2374705.Value = f72FAFBC_0.method_0("nudCountGroupTo", 1);
			ckbShareNhomNangCao.Checked = f72FAFBC_0.AA824D29("ckbShareNhomNangCao");
			ckbChiShareNhomKKD.Checked = f72FAFBC_0.AA824D29("ckbChiShareNhomKKD");
			ckbUuTienShareNhomNhieuThanhVien.Checked = f72FAFBC_0.AA824D29("ckbUuTienShareNhomNhieuThanhVien");
			ckbBackupDanhSachNhom.Checked = f72FAFBC_0.AA824D29("ckbBackupDanhSachNhom");
			ckbKhongShareTrungNhom.Checked = f72FAFBC_0.AA824D29("ckbKhongShareTrungNhom");
			ckbChiShareNhomThuocDanhSach.Checked = f72FAFBC_0.AA824D29("ckbChiShareNhomThuocDanhSach");
			list_0 = f72FAFBC_0.EC378D8A("lstNhomTuNhap");
			ckbTuDongXoaNoiDung.Checked = f72FAFBC_0.AA824D29("ckbTuDongXoaNoiDung");
			txtLinkChiaSe.Text = f72FAFBC_0.GetValue("txtLinkChiaSe");
			if (f72FAFBC_0.method_0("typeLinkShare") == 1)
			{
				rbShareOther.Checked = true;
			}
			else if (f72FAFBC_0.method_0("typeLinkShare") == 2)
			{
				rbShareReel.Checked = true;
			}
			else
			{
				C012FA84.Checked = true;
			}
			ckbVanBan.Checked = f72FAFBC_0.AA824D29("ckbVanBan");
			txtNoiDung.Text = f72FAFBC_0.GetValue("txtNoiDung");
			D2388F21.SelectedIndex = f72FAFBC_0.method_0("typeNganCach");
			ckbTuongTacTruocKhiShare.Checked = f72FAFBC_0.AA824D29("ckbTuongTacTruocKhiShare");
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 30);
			nudSoLuongTo.Value = f72FAFBC_0.method_0("nudSoLuongTo", 30);
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			string text = f72FAFBC_0.GetValue("typeReaction");
			B83D9A3A = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, ckbHaha, DEA87210, ckbBuon, ckbGian };
			for (int i = 0; i < B83D9A3A.Count; i++)
			{
				B83D9A3A[i].Checked = text.Contains(i.ToString());
			}
			C6ABB007.Checked = f72FAFBC_0.AA824D29("ckbComment");
			A0217238.Text = f72FAFBC_0.GetValue("txtComment");
			D5977B1F.Checked = f72FAFBC_0.AA824D29("ckbBinhLuanNhieuLan");
			nudBinhLuanNhieuLanDelayFrom.Value = f72FAFBC_0.method_0("nudBinhLuanNhieuLanDelayFrom", 10);
			C22047BD.Value = f72FAFBC_0.method_0("nudBinhLuanNhieuLanDelayTo", 10);
		}
		catch
		{
		}
		method_0();
		F42D2738();
	}

	private void D72CDDBB()
	{
		List<string> f0B9E2B = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		Common.BEBCBE97(D2388F21, f0B9E2B);
	}

	private void FC00E73F(object sender, EventArgs e)
	{
		Close();
	}

	private void C58B4595(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudDelayFrom", BE2E11A7.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("ckbShareBaiLenTuong", ckbShareBaiLenTuong.Checked);
		f72FAFBC.GetValue("ckbShareBaiLenNhom", ckbShareBaiLenNhom.Checked);
		f72FAFBC.GetValue("nudCountGroupFrom", nudCountGroupFrom.Value);
		f72FAFBC.GetValue("nudCountGroupTo", F2374705.Value);
		f72FAFBC.GetValue("ckbShareNhomNangCao", ckbShareNhomNangCao.Checked);
		f72FAFBC.GetValue("ckbChiShareNhomKKD", ckbChiShareNhomKKD.Checked);
		f72FAFBC.GetValue("ckbUuTienShareNhomNhieuThanhVien", ckbUuTienShareNhomNhieuThanhVien.Checked);
		f72FAFBC.GetValue("ckbBackupDanhSachNhom", ckbBackupDanhSachNhom.Checked);
		f72FAFBC.GetValue("ckbKhongShareTrungNhom", ckbKhongShareTrungNhom.Checked);
		f72FAFBC.GetValue("ckbChiShareNhomThuocDanhSach", ckbChiShareNhomThuocDanhSach.Checked);
		f72FAFBC.method_3("lstNhomTuNhap", list_0);
		f72FAFBC.GetValue("ckbTuDongXoaNoiDung", ckbTuDongXoaNoiDung.Checked);
		if (txtLinkChiaSe.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p Link câ\u0300n share!", 3);
			return;
		}
		f72FAFBC.GetValue("txtLinkChiaSe", (object)txtLinkChiaSe.Text.Trim());
		int num = 0;
		if (rbShareOther.Checked)
		{
			num = 1;
		}
		else if (rbShareReel.Checked)
		{
			num = 2;
		}
		f72FAFBC.GetValue("typeLinkShare", num);
		f72FAFBC.GetValue("ckbVanBan", ckbVanBan.Checked);
		f72FAFBC.GetValue("txtNoiDung", (object)txtNoiDung.Text.Trim());
		f72FAFBC.GetValue("typeNganCach", D2388F21.SelectedIndex);
		f72FAFBC.GetValue("ckbTuongTacTruocKhiShare", ckbTuongTacTruocKhiShare.Checked);
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		for (int i = 0; i < B83D9A3A.Count; i++)
		{
			text2 += (B83D9A3A[i].Checked ? (i.ToString() ?? "") : "");
		}
		f72FAFBC.GetValue("typeReaction", (object)text2);
		f72FAFBC.GetValue("ckbComment", C6ABB007.Checked);
		f72FAFBC.GetValue("txtComment", (object)A0217238.Text.Trim());
		f72FAFBC.GetValue("ckbBinhLuanNhieuLan", D5977B1F.Checked);
		f72FAFBC.GetValue("nudBinhLuanNhieuLanDelayFrom", nudBinhLuanNhieuLanDelayFrom.Value);
		f72FAFBC.GetValue("nudBinhLuanNhieuLanDelayTo", C22047BD.Value);
		string text3 = f72FAFBC.C71A4EA4();
		if (CF87BFA4 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, AA875C27, text3))
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
			if (Class123.smethod_14(string_1, text, text3))
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

	private void E7203128_Paint(object sender, PaintEventArgs e)
	{
		if (E7203128.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, E7203128.ClientSize.Width - num, E7203128.ClientSize.Height - num));
		}
	}

	private void F42D2738()
	{
		ckbVanBan_CheckedChanged(null, null);
		F62B2D01(null, null);
		D19B0FA6(null, null);
		C6ABB007_CheckedChanged(null, null);
		D5977B1F_CheckedChanged(null, null);
		D3ACF830(null, null);
		ckbShareBaiLenNhom_CheckedChanged(null, null);
		CF8FA93F(null, null);
	}

	private void B03C479B_Click(object sender, EventArgs e)
	{
	}

	private void txtLinkChiaSe_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtLinkChiaSe, F432E4BF);
	}

	private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = ckbVanBan.Checked;
	}

	private void txtNoiDung_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtNoiDung, lblNoiDung, D2388F21.SelectedIndex);
	}

	private void A0217238_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = A0217238.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			label15.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void F62B2D01(object sender, EventArgs e)
	{
		C7096999.Enabled = ckbTuongTacTruocKhiShare.Checked;
	}

	private void ckbShareBaiLenNhom_CheckedChanged(object sender, EventArgs e)
	{
		plShareBaiLenNhom.Enabled = ckbShareBaiLenNhom.Checked;
	}

	private void D19B0FA6(object sender, EventArgs e)
	{
		C2BB709D.Enabled = ckbInteract.Checked;
	}

	private void C6ABB007_CheckedChanged(object sender, EventArgs e)
	{
		FE812AA5.Enabled = C6ABB007.Checked;
	}

	private void D5977B1F_CheckedChanged(object sender, EventArgs e)
	{
		plBinhLuanNhieuLan.Enabled = D5977B1F.Checked;
	}

	private void D3ACF830(object sender, EventArgs e)
	{
		FC9A9D9E.Enabled = ckbShareNhomNangCao.Checked;
	}

	private void rbShareOther_CheckedChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void D3AE021D(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		if (rbShareOther.Checked || rbShareReel.Checked)
		{
			D5977B1F.Checked = false;
		}
		D5977B1F.Enabled = C012FA84.Checked;
		plBinhLuanNhieuLan.Enabled = C012FA84.Checked;
	}

	private void A3275D87(object sender, EventArgs e)
	{
		if (ckbShareNhomNangCao.Checked && MessageBoxHelper.smethod_1(Language.GetValue("Tính năng này có thể khiến tài khoản bị khóa và làm giảm tốc độ chia sẻ, bạn vẫn muốn sử dụng?")) == DialogResult.No)
		{
			ckbShareNhomNangCao.Checked = false;
		}
	}

	private void B6B2F98F_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch Id nhóm", "Danh sa\u0301ch Id nhóm", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		list_0 = fNhapDuLieu4.list_0;
	}

	private void CF8FA93F(object sender, EventArgs e)
	{
		B6B2F98F.Enabled = ckbChiShareNhomThuocDanhSach.Checked;
	}

	private void ckbChiShareNhomKKD_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void B02714AB(object sender, EventArgs e)
	{
		if (ckbChiShareNhomKKD.Checked && MessageBoxHelper.smethod_1(Language.GetValue("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) == DialogResult.No)
		{
			ckbChiShareNhomKKD.Checked = false;
		}
	}

	private void E038F397(object sender, EventArgs e)
	{
		if (D2388F21.SelectedIndex == 0)
		{
			MessageBoxHelper.Show("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			Common.smethod_16(new fHelpNhapComment());
		}
		txtNoiDung.Focus();
	}

	private void D2388F21_SelectedIndexChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtNoiDung, lblNoiDung, D2388F21.SelectedIndex);
	}

	protected override void Dispose(bool B594662B)
	{
		if (B594662B && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B594662B);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDShareBaiNangCao));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		F817240A = new System.Windows.Forms.Button();
		B03C479B = new System.Windows.Forms.PictureBox();
		E7203128 = new System.Windows.Forms.Panel();
		groupBox1 = new System.Windows.Forms.GroupBox();
		txtLinkChiaSe = new System.Windows.Forms.RichTextBox();
		C7096999 = new System.Windows.Forms.Panel();
		C2BB709D = new System.Windows.Forms.Panel();
		ckbGian = new System.Windows.Forms.CheckBox();
		ckbBuon = new System.Windows.Forms.CheckBox();
		DEA87210 = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbThuong = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		panel7 = new System.Windows.Forms.Panel();
		E52AA81D = new System.Windows.Forms.RadioButton();
		D6A64593 = new System.Windows.Forms.RadioButton();
		FE902220 = new System.Windows.Forms.Label();
		label22 = new System.Windows.Forms.Label();
		FE812AA5 = new System.Windows.Forms.Panel();
		linkLabel2 = new System.Windows.Forms.LinkLabel();
		plBinhLuanNhieuLan = new System.Windows.Forms.Panel();
		C22047BD = new System.Windows.Forms.NumericUpDown();
		nudBinhLuanNhieuLanDelayFrom = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		AE16D73F = new System.Windows.Forms.Label();
		F1A0CD00 = new System.Windows.Forms.Label();
		D5977B1F = new System.Windows.Forms.CheckBox();
		label14 = new System.Windows.Forms.Label();
		A0217238 = new System.Windows.Forms.TextBox();
		label15 = new System.Windows.Forms.Label();
		label21 = new System.Windows.Forms.Label();
		CF917E3C = new System.Windows.Forms.Label();
		C6ABB007 = new System.Windows.Forms.CheckBox();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		plVanBan = new System.Windows.Forms.Panel();
		ckbTuDongXoaNoiDung = new System.Windows.Forms.CheckBox();
		txtNoiDung = new System.Windows.Forms.RichTextBox();
		D135B7B0 = new System.Windows.Forms.Label();
		lblNoiDung = new System.Windows.Forms.Label();
		rbShareReel = new System.Windows.Forms.RadioButton();
		rbShareOther = new System.Windows.Forms.RadioButton();
		C012FA84 = new System.Windows.Forms.RadioButton();
		ckbTuongTacTruocKhiShare = new System.Windows.Forms.CheckBox();
		BD37D316 = new System.Windows.Forms.Label();
		F432E4BF = new System.Windows.Forms.Label();
		ckbVanBan = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		BE2E11A7 = new System.Windows.Forms.NumericUpDown();
		label20 = new System.Windows.Forms.Label();
		F8990085 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		CD0E8118 = new System.Windows.Forms.GroupBox();
		plShareBaiLenNhom = new System.Windows.Forms.Panel();
		FC9A9D9E = new System.Windows.Forms.Panel();
		B6B2F98F = new System.Windows.Forms.Button();
		ckbChiShareNhomThuocDanhSach = new System.Windows.Forms.CheckBox();
		ckbBackupDanhSachNhom = new System.Windows.Forms.CheckBox();
		ckbKhongShareTrungNhom = new System.Windows.Forms.CheckBox();
		ckbUuTienShareNhomNhieuThanhVien = new System.Windows.Forms.CheckBox();
		ckbChiShareNhomKKD = new System.Windows.Forms.CheckBox();
		ckbShareNhomNangCao = new System.Windows.Forms.CheckBox();
		F2374705 = new System.Windows.Forms.NumericUpDown();
		nudCountGroupFrom = new System.Windows.Forms.NumericUpDown();
		label24 = new System.Windows.Forms.Label();
		label25 = new System.Windows.Forms.Label();
		A508BC8B = new System.Windows.Forms.Label();
		ckbShareBaiLenNhom = new System.Windows.Forms.CheckBox();
		ckbShareBaiLenTuong = new System.Windows.Forms.CheckBox();
		btnAdd = new System.Windows.Forms.Button();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		D2388F21 = new System.Windows.Forms.ComboBox();
		btnHuongDanNhapNoiDung = new System.Windows.Forms.Button();
		label5 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B03C479B).BeginInit();
		E7203128.SuspendLayout();
		groupBox1.SuspendLayout();
		C7096999.SuspendLayout();
		C2BB709D.SuspendLayout();
		panel7.SuspendLayout();
		FE812AA5.SuspendLayout();
		plBinhLuanNhieuLan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C22047BD).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		plVanBan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)BE2E11A7).BeginInit();
		CD0E8118.SuspendLayout();
		plShareBaiLenNhom.SuspendLayout();
		FC9A9D9E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F2374705).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountGroupFrom).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(1153, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Share bài nâng cao";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(F817240A);
		pnlHeader.Controls.Add(B03C479B);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(1153, 31);
		pnlHeader.TabIndex = 9;
		F817240A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		F817240A.Cursor = System.Windows.Forms.Cursors.Hand;
		F817240A.FlatAppearance.BorderSize = 0;
		F817240A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F817240A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F817240A.ForeColor = System.Drawing.Color.White;
		F817240A.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		F817240A.Location = new System.Drawing.Point(1122, 1);
		F817240A.Name = "button1";
		F817240A.Size = new System.Drawing.Size(30, 30);
		F817240A.TabIndex = 0;
		F817240A.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		F817240A.UseVisualStyleBackColor = true;
		F817240A.Click += new System.EventHandler(FC00E73F);
		B03C479B.Cursor = System.Windows.Forms.Cursors.Default;
		B03C479B.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		B03C479B.Location = new System.Drawing.Point(3, 2);
		B03C479B.Name = "pictureBox1";
		B03C479B.Size = new System.Drawing.Size(34, 27);
		B03C479B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B03C479B.TabIndex = 76;
		B03C479B.TabStop = false;
		B03C479B.Click += new System.EventHandler(B03C479B_Click);
		E7203128.BackColor = System.Drawing.Color.White;
		E7203128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E7203128.Controls.Add(groupBox1);
		E7203128.Controls.Add(CD0E8118);
		E7203128.Controls.Add(btnAdd);
		E7203128.Controls.Add(txtTenHanhDong);
		E7203128.Controls.Add(label1);
		E7203128.Controls.Add(btnCancel);
		E7203128.Controls.Add(bunifuCards1);
		E7203128.Cursor = System.Windows.Forms.Cursors.Arrow;
		E7203128.Dock = System.Windows.Forms.DockStyle.Fill;
		E7203128.Location = new System.Drawing.Point(0, 0);
		E7203128.Name = "panel1";
		E7203128.Size = new System.Drawing.Size(1156, 582);
		E7203128.TabIndex = 0;
		E7203128.Paint += new System.Windows.Forms.PaintEventHandler(E7203128_Paint);
		groupBox1.Controls.Add(txtLinkChiaSe);
		groupBox1.Controls.Add(C7096999);
		groupBox1.Controls.Add(plVanBan);
		groupBox1.Controls.Add(rbShareReel);
		groupBox1.Controls.Add(rbShareOther);
		groupBox1.Controls.Add(C012FA84);
		groupBox1.Controls.Add(ckbTuongTacTruocKhiShare);
		groupBox1.Controls.Add(BD37D316);
		groupBox1.Controls.Add(F432E4BF);
		groupBox1.Controls.Add(ckbVanBan);
		groupBox1.Controls.Add(nudDelayTo);
		groupBox1.Controls.Add(BE2E11A7);
		groupBox1.Controls.Add(label20);
		groupBox1.Controls.Add(F8990085);
		groupBox1.Controls.Add(label2);
		groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		groupBox1.Location = new System.Drawing.Point(30, 80);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(745, 447);
		groupBox1.TabIndex = 8;
		groupBox1.TabStop = false;
		groupBox1.Text = "Câ\u0301u hi\u0300nh cha\u0323y";
		txtLinkChiaSe.Location = new System.Drawing.Point(17, 67);
		txtLinkChiaSe.Name = "txtLinkChiaSe";
		txtLinkChiaSe.Size = new System.Drawing.Size(349, 93);
		txtLinkChiaSe.TabIndex = 73;
		txtLinkChiaSe.Text = "";
		txtLinkChiaSe.WordWrap = false;
		txtLinkChiaSe.TextChanged += new System.EventHandler(txtLinkChiaSe_TextChanged);
		C7096999.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C7096999.Controls.Add(C2BB709D);
		C7096999.Controls.Add(label22);
		C7096999.Controls.Add(FE812AA5);
		C7096999.Controls.Add(label21);
		C7096999.Controls.Add(CF917E3C);
		C7096999.Controls.Add(C6ABB007);
		C7096999.Controls.Add(nudSoLuongFrom);
		C7096999.Controls.Add(ckbInteract);
		C7096999.Controls.Add(nudSoLuongTo);
		C7096999.Font = new System.Drawing.Font("Tahoma", 9.75f);
		C7096999.Location = new System.Drawing.Point(391, 90);
		C7096999.Name = "plTuongTacTruocKhiShare";
		C7096999.Size = new System.Drawing.Size(345, 345);
		C7096999.TabIndex = 10;
		C2BB709D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C2BB709D.Controls.Add(ckbGian);
		C2BB709D.Controls.Add(ckbBuon);
		C2BB709D.Controls.Add(DEA87210);
		C2BB709D.Controls.Add(ckbHaha);
		C2BB709D.Controls.Add(ckbThuong);
		C2BB709D.Controls.Add(ckbTym);
		C2BB709D.Controls.Add(ckbLike);
		C2BB709D.Controls.Add(panel7);
		C2BB709D.Controls.Add(FE902220);
		C2BB709D.Location = new System.Drawing.Point(24, 53);
		C2BB709D.Name = "plInteract";
		C2BB709D.Size = new System.Drawing.Size(312, 33);
		C2BB709D.TabIndex = 182;
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
		DEA87210.Cursor = System.Windows.Forms.Cursors.Hand;
		DEA87210.Image = Resource.F391A116;
		DEA87210.Location = new System.Drawing.Point(178, 1);
		DEA87210.Name = "ckbWow";
		DEA87210.Size = new System.Drawing.Size(40, 30);
		DEA87210.TabIndex = 177;
		DEA87210.UseVisualStyleBackColor = true;
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
		panel7.Controls.Add(E52AA81D);
		panel7.Controls.Add(D6A64593);
		panel7.Location = new System.Drawing.Point(67, 300);
		panel7.Name = "panel7";
		panel7.Size = new System.Drawing.Size(200, 43);
		panel7.TabIndex = 43;
		E52AA81D.AutoSize = true;
		E52AA81D.Checked = true;
		E52AA81D.Cursor = System.Windows.Forms.Cursors.Hand;
		E52AA81D.Location = new System.Drawing.Point(3, 2);
		E52AA81D.Name = "radioButton3";
		E52AA81D.Size = new System.Drawing.Size(201, 20);
		E52AA81D.TabIndex = 3;
		E52AA81D.TabStop = true;
		E52AA81D.Text = "Comment theo thứ tự nội dung";
		E52AA81D.UseVisualStyleBackColor = true;
		D6A64593.AutoSize = true;
		D6A64593.Cursor = System.Windows.Forms.Cursors.Hand;
		D6A64593.Location = new System.Drawing.Point(3, 23);
		D6A64593.Name = "radioButton4";
		D6A64593.Size = new System.Drawing.Size(200, 20);
		D6A64593.TabIndex = 3;
		D6A64593.Text = "Comment ngẫu nhiên nội dung";
		D6A64593.UseVisualStyleBackColor = true;
		FE902220.AutoSize = true;
		FE902220.Location = new System.Drawing.Point(4, 302);
		FE902220.Name = "label4";
		FE902220.Size = new System.Drawing.Size(64, 16);
		FE902220.TabIndex = 2;
		FE902220.Text = "Tùy chọn:";
		label22.AutoSize = true;
		label22.Location = new System.Drawing.Point(3, 7);
		label22.Name = "label22";
		label22.Size = new System.Drawing.Size(93, 16);
		label22.TabIndex = 44;
		label22.Text = "Thời gian xem:";
		FE812AA5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FE812AA5.Controls.Add(linkLabel2);
		FE812AA5.Controls.Add(plBinhLuanNhieuLan);
		FE812AA5.Controls.Add(D5977B1F);
		FE812AA5.Controls.Add(label14);
		FE812AA5.Controls.Add(A0217238);
		FE812AA5.Controls.Add(label15);
		FE812AA5.Location = new System.Drawing.Point(24, 117);
		FE812AA5.Name = "plComment";
		FE812AA5.Size = new System.Drawing.Size(312, 213);
		FE812AA5.TabIndex = 43;
		linkLabel2.AutoSize = true;
		linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel2.Location = new System.Drawing.Point(228, 146);
		linkLabel2.Name = "linkLabel2";
		linkLabel2.Size = new System.Drawing.Size(81, 16);
		linkLabel2.TabIndex = 192;
		linkLabel2.TabStop = true;
		linkLabel2.Text = "Random icon";
		linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked);
		plBinhLuanNhieuLan.Controls.Add(C22047BD);
		plBinhLuanNhieuLan.Controls.Add(nudBinhLuanNhieuLanDelayFrom);
		plBinhLuanNhieuLan.Controls.Add(label9);
		plBinhLuanNhieuLan.Controls.Add(AE16D73F);
		plBinhLuanNhieuLan.Controls.Add(F1A0CD00);
		plBinhLuanNhieuLan.Location = new System.Drawing.Point(19, 183);
		plBinhLuanNhieuLan.Name = "plBinhLuanNhieuLan";
		plBinhLuanNhieuLan.Size = new System.Drawing.Size(254, 27);
		plBinhLuanNhieuLan.TabIndex = 134;
		C22047BD.Cursor = System.Windows.Forms.Cursors.Hand;
		C22047BD.Location = new System.Drawing.Point(177, 2);
		C22047BD.Maximum = new decimal(new int[4] { 100000000, 0, 0, 0 });
		C22047BD.Name = "nudBinhLuanNhieuLanDelayTo";
		C22047BD.Size = new System.Drawing.Size(50, 23);
		C22047BD.TabIndex = 22;
		nudBinhLuanNhieuLanDelayFrom.Cursor = System.Windows.Forms.Cursors.Hand;
		nudBinhLuanNhieuLanDelayFrom.Location = new System.Drawing.Point(104, 2);
		nudBinhLuanNhieuLanDelayFrom.Maximum = new decimal(new int[4] { 100000000, 0, 0, 0 });
		nudBinhLuanNhieuLanDelayFrom.Name = "nudBinhLuanNhieuLanDelayFrom";
		nudBinhLuanNhieuLanDelayFrom.Size = new System.Drawing.Size(45, 23);
		nudBinhLuanNhieuLanDelayFrom.TabIndex = 21;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(226, 4);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(30, 16);
		label9.TabIndex = 20;
		label9.Text = "giây";
		AE16D73F.AutoSize = true;
		AE16D73F.Location = new System.Drawing.Point(149, 4);
		AE16D73F.Name = "label13";
		AE16D73F.Size = new System.Drawing.Size(28, 16);
		AE16D73F.TabIndex = 20;
		AE16D73F.Text = "đến";
		F1A0CD00.AutoSize = true;
		F1A0CD00.Location = new System.Drawing.Point(4, 4);
		F1A0CD00.Name = "lblmc1";
		F1A0CD00.Size = new System.Drawing.Size(100, 16);
		F1A0CD00.TabIndex = 18;
		F1A0CD00.Text = "Delay comment:";
		D5977B1F.AutoSize = true;
		D5977B1F.Cursor = System.Windows.Forms.Cursors.Hand;
		D5977B1F.Location = new System.Drawing.Point(7, 164);
		D5977B1F.Name = "ckbBinhLuanNhieuLan";
		D5977B1F.Size = new System.Drawing.Size(134, 20);
		D5977B1F.TabIndex = 133;
		D5977B1F.Text = "Bình luận nhiều lần";
		D5977B1F.UseVisualStyleBackColor = true;
		D5977B1F.CheckedChanged += new System.EventHandler(D5977B1F_CheckedChanged);
		label14.AutoSize = true;
		label14.Location = new System.Drawing.Point(4, 146);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(143, 16);
		label14.TabIndex = 2;
		label14.Text = "(Spin nội dung {a|b|c})";
		A0217238.Location = new System.Drawing.Point(7, 27);
		A0217238.Multiline = true;
		A0217238.Name = "txtComment";
		A0217238.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		A0217238.Size = new System.Drawing.Size(299, 117);
		A0217238.TabIndex = 1;
		A0217238.WordWrap = false;
		A0217238.TextChanged += new System.EventHandler(A0217238_TextChanged);
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(3, 5);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(139, 16);
		label15.TabIndex = 0;
		label15.Text = "Nội dung bình luận (0):";
		label21.AutoSize = true;
		label21.Location = new System.Drawing.Point(266, 7);
		label21.Name = "label21";
		label21.Size = new System.Drawing.Size(30, 16);
		label21.TabIndex = 45;
		label21.Text = "giây";
		CF917E3C.Location = new System.Drawing.Point(170, 7);
		CF917E3C.Name = "label18";
		CF917E3C.Size = new System.Drawing.Size(29, 16);
		CF917E3C.TabIndex = 46;
		CF917E3C.Text = "đê\u0301n";
		CF917E3C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C6ABB007.AutoSize = true;
		C6ABB007.Cursor = System.Windows.Forms.Cursors.Hand;
		C6ABB007.Location = new System.Drawing.Point(6, 92);
		C6ABB007.Name = "ckbComment";
		C6ABB007.Size = new System.Drawing.Size(130, 20);
		C6ABB007.TabIndex = 42;
		C6ABB007.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		C6ABB007.UseVisualStyleBackColor = true;
		C6ABB007.CheckedChanged += new System.EventHandler(C6ABB007_CheckedChanged);
		nudSoLuongFrom.Location = new System.Drawing.Point(108, 5);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 38;
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(6, 31);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(112, 20);
		ckbInteract.TabIndex = 40;
		ckbInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(D19B0FA6);
		nudSoLuongTo.Location = new System.Drawing.Point(205, 5);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 39;
		plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plVanBan.Controls.Add(D2388F21);
		plVanBan.Controls.Add(btnHuongDanNhapNoiDung);
		plVanBan.Controls.Add(label5);
		plVanBan.Controls.Add(ckbTuDongXoaNoiDung);
		plVanBan.Controls.Add(txtNoiDung);
		plVanBan.Controls.Add(D135B7B0);
		plVanBan.Controls.Add(lblNoiDung);
		plVanBan.Location = new System.Drawing.Point(35, 211);
		plVanBan.Name = "plVanBan";
		plVanBan.Size = new System.Drawing.Size(331, 224);
		plVanBan.TabIndex = 72;
		ckbTuDongXoaNoiDung.AutoSize = true;
		ckbTuDongXoaNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongXoaNoiDung.Location = new System.Drawing.Point(6, 199);
		ckbTuDongXoaNoiDung.Name = "ckbTuDongXoaNoiDung";
		ckbTuDongXoaNoiDung.Size = new System.Drawing.Size(219, 20);
		ckbTuDongXoaNoiDung.TabIndex = 196;
		ckbTuDongXoaNoiDung.Text = "Tư\u0323 đô\u0323ng xo\u0301a nô\u0323i dung đa\u0303 sư\u0309 du\u0323ng";
		ckbTuDongXoaNoiDung.UseVisualStyleBackColor = true;
		txtNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtNoiDung.Location = new System.Drawing.Point(7, 24);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new System.Drawing.Size(319, 141);
		txtNoiDung.TabIndex = 34;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += new System.EventHandler(txtNoiDung_TextChanged);
		D135B7B0.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		D135B7B0.AutoSize = true;
		D135B7B0.Location = new System.Drawing.Point(185, 5);
		D135B7B0.Name = "label8";
		D135B7B0.Size = new System.Drawing.Size(143, 16);
		D135B7B0.TabIndex = 0;
		D135B7B0.Text = "(Spin nội dung {a|b|c})";
		lblNoiDung.AutoSize = true;
		lblNoiDung.Location = new System.Drawing.Point(3, 5);
		lblNoiDung.Name = "lblNoiDung";
		lblNoiDung.Size = new System.Drawing.Size(145, 16);
		lblNoiDung.TabIndex = 0;
		lblNoiDung.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		rbShareReel.AutoSize = true;
		rbShareReel.Cursor = System.Windows.Forms.Cursors.Hand;
		rbShareReel.Location = new System.Drawing.Point(279, 163);
		rbShareReel.Name = "rbShareReel";
		rbShareReel.Size = new System.Drawing.Size(50, 20);
		rbShareReel.TabIndex = 71;
		rbShareReel.TabStop = true;
		rbShareReel.Text = "Reel";
		rbShareReel.UseVisualStyleBackColor = true;
		rbShareOther.AutoSize = true;
		rbShareOther.Cursor = System.Windows.Forms.Cursors.Hand;
		rbShareOther.Location = new System.Drawing.Point(207, 163);
		rbShareOther.Name = "rbShareOther";
		rbShareOther.Size = new System.Drawing.Size(66, 20);
		rbShareOther.TabIndex = 71;
		rbShareOther.TabStop = true;
		rbShareOther.Text = "Bài viết";
		rbShareOther.UseVisualStyleBackColor = true;
		rbShareOther.CheckedChanged += new System.EventHandler(rbShareOther_CheckedChanged);
		C012FA84.AutoSize = true;
		C012FA84.Cursor = System.Windows.Forms.Cursors.Hand;
		C012FA84.Location = new System.Drawing.Point(114, 163);
		C012FA84.Name = "rbShareLivestream";
		C012FA84.Size = new System.Drawing.Size(87, 20);
		C012FA84.TabIndex = 71;
		C012FA84.TabStop = true;
		C012FA84.Text = "Livestream";
		C012FA84.UseVisualStyleBackColor = true;
		C012FA84.CheckedChanged += new System.EventHandler(D3AE021D);
		ckbTuongTacTruocKhiShare.AutoSize = true;
		ckbTuongTacTruocKhiShare.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuongTacTruocKhiShare.Location = new System.Drawing.Point(391, 67);
		ckbTuongTacTruocKhiShare.Name = "ckbTuongTacTruocKhiShare";
		ckbTuongTacTruocKhiShare.Size = new System.Drawing.Size(174, 20);
		ckbTuongTacTruocKhiShare.TabIndex = 3;
		ckbTuongTacTruocKhiShare.Text = "Tương ta\u0301c trươ\u0301c khi share";
		ckbTuongTacTruocKhiShare.UseVisualStyleBackColor = true;
		ckbTuongTacTruocKhiShare.CheckedChanged += new System.EventHandler(F62B2D01);
		BD37D316.AutoSize = true;
		BD37D316.Location = new System.Drawing.Point(14, 165);
		BD37D316.Name = "label7";
		BD37D316.Size = new System.Drawing.Size(94, 16);
		BD37D316.TabIndex = 70;
		BD37D316.Text = "Loa\u0323i link share:";
		F432E4BF.AutoSize = true;
		F432E4BF.Location = new System.Drawing.Point(14, 49);
		F432E4BF.Name = "label3";
		F432E4BF.Size = new System.Drawing.Size(115, 16);
		F432E4BF.TabIndex = 70;
		F432E4BF.Text = "Link cần share (0):";
		ckbVanBan.AutoSize = true;
		ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbVanBan.Location = new System.Drawing.Point(17, 188);
		ckbVanBan.Name = "ckbVanBan";
		ckbVanBan.Size = new System.Drawing.Size(112, 20);
		ckbVanBan.TabIndex = 67;
		ckbVanBan.Text = "Nội dung share";
		ckbVanBan.UseVisualStyleBackColor = true;
		ckbVanBan.CheckedChanged += new System.EventHandler(ckbVanBan_CheckedChanged);
		nudDelayTo.Location = new System.Drawing.Point(238, 22);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 63;
		BE2E11A7.Location = new System.Drawing.Point(141, 22);
		BE2E11A7.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BE2E11A7.Name = "nudDelayFrom";
		BE2E11A7.Size = new System.Drawing.Size(56, 23);
		BE2E11A7.TabIndex = 62;
		label20.AutoSize = true;
		label20.Location = new System.Drawing.Point(203, 24);
		label20.Name = "label20";
		label20.Size = new System.Drawing.Size(28, 16);
		label20.TabIndex = 66;
		label20.Text = "đê\u0301n";
		F8990085.AutoSize = true;
		F8990085.Location = new System.Drawing.Point(297, 24);
		F8990085.Name = "label19";
		F8990085.Size = new System.Drawing.Size(30, 16);
		F8990085.TabIndex = 65;
		F8990085.Text = "giây";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(14, 24);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(120, 16);
		label2.TabIndex = 64;
		label2.Text = "Khoảng cách share:";
		CD0E8118.Controls.Add(plShareBaiLenNhom);
		CD0E8118.Controls.Add(ckbShareBaiLenNhom);
		CD0E8118.Controls.Add(ckbShareBaiLenTuong);
		CD0E8118.Location = new System.Drawing.Point(781, 80);
		CD0E8118.Name = "groupBox2";
		CD0E8118.Size = new System.Drawing.Size(343, 275);
		CD0E8118.TabIndex = 62;
		CD0E8118.TabStop = false;
		CD0E8118.Text = "Tùy chọn share";
		plShareBaiLenNhom.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plShareBaiLenNhom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plShareBaiLenNhom.Controls.Add(FC9A9D9E);
		plShareBaiLenNhom.Controls.Add(ckbShareNhomNangCao);
		plShareBaiLenNhom.Controls.Add(F2374705);
		plShareBaiLenNhom.Controls.Add(nudCountGroupFrom);
		plShareBaiLenNhom.Controls.Add(label24);
		plShareBaiLenNhom.Controls.Add(label25);
		plShareBaiLenNhom.Controls.Add(A508BC8B);
		plShareBaiLenNhom.Location = new System.Drawing.Point(23, 73);
		plShareBaiLenNhom.Name = "plShareBaiLenNhom";
		plShareBaiLenNhom.Size = new System.Drawing.Size(312, 195);
		plShareBaiLenNhom.TabIndex = 1;
		FC9A9D9E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FC9A9D9E.Controls.Add(B6B2F98F);
		FC9A9D9E.Controls.Add(ckbChiShareNhomThuocDanhSach);
		FC9A9D9E.Controls.Add(ckbBackupDanhSachNhom);
		FC9A9D9E.Controls.Add(ckbKhongShareTrungNhom);
		FC9A9D9E.Controls.Add(ckbUuTienShareNhomNhieuThanhVien);
		FC9A9D9E.Controls.Add(ckbChiShareNhomKKD);
		FC9A9D9E.Location = new System.Drawing.Point(19, 55);
		FC9A9D9E.Name = "plShareNhomNangCao";
		FC9A9D9E.Size = new System.Drawing.Size(285, 133);
		FC9A9D9E.TabIndex = 58;
		B6B2F98F.Cursor = System.Windows.Forms.Cursors.Hand;
		B6B2F98F.Location = new System.Drawing.Point(218, 103);
		B6B2F98F.Name = "btnNhapDanhSachNhom";
		B6B2F98F.Size = new System.Drawing.Size(62, 25);
		B6B2F98F.TabIndex = 4;
		B6B2F98F.Text = "Nhập";
		B6B2F98F.UseVisualStyleBackColor = true;
		B6B2F98F.Click += new System.EventHandler(B6B2F98F_Click);
		ckbChiShareNhomThuocDanhSach.AutoSize = true;
		ckbChiShareNhomThuocDanhSach.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChiShareNhomThuocDanhSach.Location = new System.Drawing.Point(4, 105);
		ckbChiShareNhomThuocDanhSach.Name = "ckbChiShareNhomThuocDanhSach";
		ckbChiShareNhomThuocDanhSach.Size = new System.Drawing.Size(218, 20);
		ckbChiShareNhomThuocDanhSach.TabIndex = 3;
		ckbChiShareNhomThuocDanhSach.Text = "Chỉ share nhóm thuộc danh sách:";
		ckbChiShareNhomThuocDanhSach.UseVisualStyleBackColor = true;
		ckbChiShareNhomThuocDanhSach.CheckedChanged += new System.EventHandler(CF8FA93F);
		ckbBackupDanhSachNhom.AutoSize = true;
		ckbBackupDanhSachNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBackupDanhSachNhom.Location = new System.Drawing.Point(4, 80);
		ckbBackupDanhSachNhom.Name = "ckbBackupDanhSachNhom";
		ckbBackupDanhSachNhom.Size = new System.Drawing.Size(234, 20);
		ckbBackupDanhSachNhom.TabIndex = 3;
		ckbBackupDanhSachNhom.Text = "Sử dụng danh sách nhóm đã backup";
		ckbBackupDanhSachNhom.UseVisualStyleBackColor = true;
		ckbKhongShareTrungNhom.AutoSize = true;
		ckbKhongShareTrungNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbKhongShareTrungNhom.Location = new System.Drawing.Point(4, 55);
		ckbKhongShareTrungNhom.Name = "ckbKhongShareTrungNhom";
		ckbKhongShareTrungNhom.Size = new System.Drawing.Size(273, 20);
		ckbKhongShareTrungNhom.TabIndex = 3;
		ckbKhongShareTrungNhom.Text = "Không share tru\u0300ng nho\u0301m với tài khoản khác";
		ckbKhongShareTrungNhom.UseVisualStyleBackColor = true;
		ckbUuTienShareNhomNhieuThanhVien.AutoSize = true;
		ckbUuTienShareNhomNhieuThanhVien.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbUuTienShareNhomNhieuThanhVien.Location = new System.Drawing.Point(4, 29);
		ckbUuTienShareNhomNhieuThanhVien.Name = "ckbUuTienShareNhomNhieuThanhVien";
		ckbUuTienShareNhomNhieuThanhVien.Size = new System.Drawing.Size(254, 20);
		ckbUuTienShareNhomNhieuThanhVien.TabIndex = 3;
		ckbUuTienShareNhomNhieuThanhVien.Text = "Ưu tiên share nho\u0301m co\u0301 nhiê\u0300u tha\u0300nh viên";
		ckbUuTienShareNhomNhieuThanhVien.UseVisualStyleBackColor = true;
		ckbChiShareNhomKKD.AutoSize = true;
		ckbChiShareNhomKKD.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChiShareNhomKKD.Location = new System.Drawing.Point(4, 3);
		ckbChiShareNhomKKD.Name = "ckbChiShareNhomKKD";
		ckbChiShareNhomKKD.Size = new System.Drawing.Size(220, 20);
		ckbChiShareNhomKKD.TabIndex = 3;
		ckbChiShareNhomKKD.Text = "Chi\u0309 share nho\u0301m không kiê\u0309m duyê\u0323t";
		ckbChiShareNhomKKD.UseVisualStyleBackColor = true;
		ckbChiShareNhomKKD.CheckedChanged += new System.EventHandler(ckbChiShareNhomKKD_CheckedChanged);
		ckbChiShareNhomKKD.Click += new System.EventHandler(B02714AB);
		ckbShareNhomNangCao.AutoSize = true;
		ckbShareNhomNangCao.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareNhomNangCao.Location = new System.Drawing.Point(6, 33);
		ckbShareNhomNangCao.Name = "ckbShareNhomNangCao";
		ckbShareNhomNangCao.Size = new System.Drawing.Size(132, 20);
		ckbShareNhomNangCao.TabIndex = 57;
		ckbShareNhomNangCao.Text = "Câ\u0301u hi\u0300nh nâng cao";
		ckbShareNhomNangCao.UseVisualStyleBackColor = true;
		ckbShareNhomNangCao.CheckedChanged += new System.EventHandler(D3ACF830);
		ckbShareNhomNangCao.Click += new System.EventHandler(A3275D87);
		F2374705.Location = new System.Drawing.Point(205, 4);
		F2374705.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F2374705.Name = "nudCountGroupTo";
		F2374705.Size = new System.Drawing.Size(56, 23);
		F2374705.TabIndex = 53;
		nudCountGroupFrom.Location = new System.Drawing.Point(108, 4);
		nudCountGroupFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountGroupFrom.Name = "nudCountGroupFrom";
		nudCountGroupFrom.Size = new System.Drawing.Size(56, 23);
		nudCountGroupFrom.TabIndex = 52;
		label24.AutoSize = true;
		label24.Location = new System.Drawing.Point(170, 6);
		label24.Name = "label24";
		label24.Size = new System.Drawing.Size(28, 16);
		label24.TabIndex = 56;
		label24.Text = "đê\u0301n";
		label25.AutoSize = true;
		label25.Location = new System.Drawing.Point(264, 6);
		label25.Name = "label25";
		label25.Size = new System.Drawing.Size(39, 16);
		label25.TabIndex = 55;
		label25.Text = "nhóm";
		A508BC8B.AutoSize = true;
		A508BC8B.Location = new System.Drawing.Point(3, 6);
		A508BC8B.Name = "label26";
		A508BC8B.Size = new System.Drawing.Size(99, 16);
		A508BC8B.TabIndex = 54;
		A508BC8B.Text = "Số lượng nhóm:";
		ckbShareBaiLenNhom.AutoSize = true;
		ckbShareBaiLenNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareBaiLenNhom.Location = new System.Drawing.Point(11, 50);
		ckbShareBaiLenNhom.Name = "ckbShareBaiLenNhom";
		ckbShareBaiLenNhom.Size = new System.Drawing.Size(138, 20);
		ckbShareBaiLenNhom.TabIndex = 0;
		ckbShareBaiLenNhom.Text = "Share bài lên nhóm";
		ckbShareBaiLenNhom.UseVisualStyleBackColor = true;
		ckbShareBaiLenNhom.CheckedChanged += new System.EventHandler(ckbShareBaiLenNhom_CheckedChanged);
		ckbShareBaiLenTuong.AutoSize = true;
		ckbShareBaiLenTuong.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareBaiLenTuong.Location = new System.Drawing.Point(11, 23);
		ckbShareBaiLenTuong.Name = "ckbShareBaiLenTuong";
		ckbShareBaiLenTuong.Size = new System.Drawing.Size(139, 20);
		ckbShareBaiLenTuong.TabIndex = 0;
		ckbShareBaiLenTuong.Text = "Share bài lên tường";
		ckbShareBaiLenTuong.UseVisualStyleBackColor = true;
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(482, 540);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(C58B4595);
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(193, 23);
		txtTenHanhDong.TabIndex = 0;
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
		btnCancel.Location = new System.Drawing.Point(581, 540);
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
		bunifuCards1.Size = new System.Drawing.Size(1153, 37);
		bunifuCards1.TabIndex = 28;
		D2388F21.Cursor = System.Windows.Forms.Cursors.Hand;
		D2388F21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		D2388F21.FormattingEnabled = true;
		D2388F21.Location = new System.Drawing.Point(66, 171);
		D2388F21.Name = "cbbTuyChonNoiDung";
		D2388F21.Size = new System.Drawing.Size(228, 24);
		D2388F21.TabIndex = 199;
		D2388F21.SelectedIndexChanged += new System.EventHandler(D2388F21_SelectedIndexChanged);
		btnHuongDanNhapNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		btnHuongDanNhapNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnHuongDanNhapNoiDung.Location = new System.Drawing.Point(300, 170);
		btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		btnHuongDanNhapNoiDung.Size = new System.Drawing.Size(26, 26);
		btnHuongDanNhapNoiDung.TabIndex = 198;
		btnHuongDanNhapNoiDung.Text = "?";
		btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		btnHuongDanNhapNoiDung.Click += new System.EventHandler(E038F397);
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(3, 174);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(64, 16);
		label5.TabIndex = 197;
		label5.Text = "Tùy chọn:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1156, 582);
		base.Controls.Add(E7203128);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDShareBaiNangCao";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(E6A0448C);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)B03C479B).EndInit();
		E7203128.ResumeLayout(false);
		E7203128.PerformLayout();
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		C7096999.ResumeLayout(false);
		C7096999.PerformLayout();
		C2BB709D.ResumeLayout(false);
		C2BB709D.PerformLayout();
		panel7.ResumeLayout(false);
		panel7.PerformLayout();
		FE812AA5.ResumeLayout(false);
		FE812AA5.PerformLayout();
		plBinhLuanNhieuLan.ResumeLayout(false);
		plBinhLuanNhieuLan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C22047BD).EndInit();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		plVanBan.ResumeLayout(false);
		plVanBan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)BE2E11A7).EndInit();
		CD0E8118.ResumeLayout(false);
		CD0E8118.PerformLayout();
		plShareBaiLenNhom.ResumeLayout(false);
		plShareBaiLenNhom.PerformLayout();
		FC9A9D9E.ResumeLayout(false);
		FC9A9D9E.PerformLayout();
		((System.ComponentModel.ISupportInitialize)F2374705).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountGroupFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
