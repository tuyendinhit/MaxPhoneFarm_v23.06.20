using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fDanhSachKichBan_Old : Form
{
	internal string string_0 = "";

	internal IContainer D3A4401B = null;

	internal ToolTip toolTip_0;

	internal BunifuDragControl E51786A7;

	internal BunifuDragControl bunifuDragControl_0;

	internal GroupBox groupBox1;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal PictureBox EAB95097;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button button1;

	internal GroupBox groupBox2;

	internal DataGridView dtgvKichBan;

	internal DataGridView CFB2D93B;

	internal ContextMenuStrip contextMenuStrip1;

	internal ToolStripMenuItem FDA07981;

	internal ToolStripMenuItem A596C6A3;

	internal ToolStripMenuItem toolStripMenuItem_0;

	internal ToolStripMenuItem toolStripMenuItem_1;

	internal Button A7B05614;

	internal Button D4194A28;

	internal ContextMenuStrip contextMenuStrip1_1;

	internal ToolStripMenuItem toolStripMenuItem1;

	internal ToolStripMenuItem toolStripMenuItem3;

	internal ToolStripMenuItem toolStripMenuItem4;

	internal ToolStripMenuItem EC1F980D;

	internal Panel panel1;

	internal SplitContainer splitContainer1;

	internal DataGridViewTextBoxColumn cStt;

	internal DataGridViewTextBoxColumn B4B06EAB;

	internal DataGridViewTextBoxColumn cTenKichBan;

	internal DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

	internal DataGridViewTextBoxColumn cId_HanhDong;

	internal DataGridViewTextBoxColumn B5360880;

	internal DataGridViewTextBoxColumn cTheLoai;

	public fDanhSachKichBan_Old(string string_1)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		Language.smethod_5(contextMenuStrip1);
		Language.smethod_5(contextMenuStrip1_1);
		string_0 = string_1;
	}

	private void fDanhSachKichBan_Old_Load(object sender, EventArgs e)
	{
		method_4(string_0);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DE344CBC(object sender, EventArgs e)
	{
		D603FF0A();
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		method_5();
	}

	private void toolStripMenuItem4_Click(object sender, EventArgs e)
	{
		method_1();
	}

	public void method_0(ref DataGridView A8150C84, int DE165D13, int int_0)
	{
		string text = "";
		for (int i = 1; i < A8150C84.Columns.Count; i++)
		{
			text = DatagridviewHelper.smethod_0(A8150C84, DE165D13, i);
			DatagridviewHelper.smethod_1(A8150C84, DE165D13, i, DatagridviewHelper.smethod_0(A8150C84, int_0, i));
			DatagridviewHelper.smethod_1(A8150C84, int_0, i, text);
		}
	}

	private void D4194A28_Click(object sender, EventArgs e)
	{
		int index = CFB2D93B.SelectedRows[0].Index;
		if (index == 0)
		{
			return;
		}
		string text = DatagridviewHelper.E83E252C(CFB2D93B, index - 1, "cId_HanhDong");
		string text2 = DatagridviewHelper.E83E252C(CFB2D93B, index, "cId_HanhDong");
		if (text + text2 != "")
		{
			if (Class123.E2AD70B8(text, text2))
			{
				method_0(ref CFB2D93B, index, index - 1);
				CFB2D93B.Rows[index - 1].Selected = true;
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void CAA4D495(object sender, EventArgs e)
	{
		int index = CFB2D93B.SelectedRows[0].Index;
		if (index == CFB2D93B.RowCount - 1)
		{
			return;
		}
		string text = DatagridviewHelper.E83E252C(CFB2D93B, index + 1, "cId_HanhDong");
		string text2 = DatagridviewHelper.E83E252C(CFB2D93B, index, "cId_HanhDong");
		if (text + text2 != "")
		{
			if (Class123.E2AD70B8(text, text2))
			{
				method_0(ref CFB2D93B, index, index + 1);
				CFB2D93B.Rows[index + 1].Selected = true;
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void A6A1153A(object sender, EventArgs e)
	{
		D6875180();
	}

	private void E899B83E(object sender, EventArgs e)
	{
		B6A18216();
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		B6017929();
	}

	private void EB1E7C03(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex > -1)
		{
			C79DD99A();
		}
	}

	private void toolStripMenuItem3_Click(object sender, EventArgs e)
	{
		method_2();
	}

	private void D61941B3(object sender, EventArgs e)
	{
		A782AB96();
	}

	private void FA24DBA5(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Delete:
			method_1();
			break;
		case Keys.Insert:
		case Keys.F1:
			B6A18216();
			break;
		case Keys.F2:
			method_2();
			break;
		case Keys.F5:
			C79DD99A();
			break;
		case Keys.D:
			if (e.Modifiers == Keys.Control)
			{
				A782AB96();
			}
			break;
		}
	}

	private void A782AB96()
	{
		try
		{
			if (CFB2D93B.RowCount == 0)
			{
				MessageBoxHelper.Show("Vui lòng thêm hành động trước!", 3);
				return;
			}
			DataGridViewRow dataGridViewRow = CFB2D93B.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_HanhDong"].Value.ToString();
			string text2 = dataGridViewRow.Cells["cTenHanhDong"].Value.ToString();
			string text3 = text2 + " - Copy";
			int num = 2;
			while (Class123.CC3CE6AB(text3))
			{
				text3 = text2 + $" - Copy ({num++})";
			}
			if (Class123.smethod_13(text, text3))
			{
				DataTable dataTable = Class123.smethod_11();
				CFB2D93B.Rows.Add(CFB2D93B.RowCount + 1, dataTable.Rows[0]["Id_HanhDong"], dataTable.Rows[0]["TenHanhDong"], dataTable.Rows[0]["MoTa"]);
				CFB2D93B.Rows[CFB2D93B.RowCount - 1].Selected = true;
				CFB2D93B.CurrentCell = CFB2D93B.Rows[CFB2D93B.RowCount - 1].Cells["cTenHanhDong"];
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
		catch
		{
		}
	}

	private void C79DD99A()
	{
		try
		{
			CFB2D93B.Rows.Clear();
			if (dtgvKichBan.RowCount != 0)
			{
				DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
				string a3B81BA = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
				DataTable dataTable = Class123.smethod_9(a3B81BA);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					CFB2D93B.Rows.Add(CFB2D93B.RowCount + 1, dataTable.Rows[i]["Id_HanhDong"], dataTable.Rows[i]["TenHanhDong"], dataTable.Rows[i]["MoTa"]);
				}
			}
		}
		catch
		{
		}
	}

	private void method_1()
	{
		try
		{
			if (CFB2D93B.RowCount == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng thêm hành động trước!"), 3);
			}
			else
			{
				if (MessageBoxHelper.smethod_1(Language.GetValue("Bạn có chắc muốn xóa hoạt động này?")) != DialogResult.Yes)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = CFB2D93B.SelectedRows[0];
				if (Class123.smethod_15(dataGridViewRow.Cells["cId_HanhDong"].Value.ToString()))
				{
					int index = dataGridViewRow.Index;
					for (int i = index; i < CFB2D93B.Rows.Count - 1; i++)
					{
						method_0(ref CFB2D93B, i, i + 1);
					}
					CFB2D93B.Rows.RemoveAt(CFB2D93B.Rows.Count - 1);
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
				return;
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void B6A18216()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng thêm kịch bản trước!"), 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			int count = Class123.smethod_9(text).Rows.Count;
			Common.smethod_16(new fThemHanhDong(text));
			DataTable dataTable = Class123.smethod_9(text);
			int count2 = dataTable.Rows.Count;
			if (count2 > count)
			{
				CFB2D93B.Rows.Add(CFB2D93B.RowCount + 1, dataTable.Rows[count2 - 1]["Id_HanhDong"], dataTable.Rows[count2 - 1]["TenHanhDong"], dataTable.Rows[count2 - 1]["MoTa"]);
				CFB2D93B.Rows[CFB2D93B.RowCount - 1].Selected = true;
				CFB2D93B.CurrentCell = CFB2D93B.Rows[CFB2D93B.RowCount - 1].Cells["cTenHanhDong"];
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void method_2()
	{
		try
		{
			if (CFB2D93B.RowCount == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng thêm hành động trước!"), 3);
				return;
			}
			DataGridViewRow dataGridViewRow = CFB2D93B.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_HanhDong"].Value.ToString();
			DataTable dataTable = Class123.smethod_10(text);
			Form form = null;
			string text2 = dataTable.Rows[0]["TenTuongTac"].ToString();
			string text3 = text2;
			string text4 = text3;
			switch (HashString.DA8CEBAB(text4))
			{
			case 31913242u:
				if (text4 == "HDReportVideo")
				{
					form = new fHDReportVideo("", 1, text);
				}
				break;
			case 18769620u:
				if (text4 == "HDNhanTinPage")
				{
					form = new fHDNhanTinPage("", 1, text);
				}
				break;
			case 115118702u:
				if (text4 == "HDSpamNhom")
				{
					form = new fHDSpamNhom("", 1, text);
				}
				break;
			case 105160162u:
				if (text4 == "HDDangBaiTuong")
				{
					form = new fHDDangBaiTuong("", 1, text);
				}
				break;
			case 34992592u:
				if (text4 == "HDXemWatchTheoTuKhoa")
				{
					form = new fHDXemWatchTheoTuKhoa("", 1, text);
				}
				break;
			case 167896116u:
				if (text4 == "HDTuongTacBaiVietTuKhoa")
				{
					form = new fHDTuongTacBaiVietTuKhoa("", 1, text);
				}
				break;
			case 155455705u:
				if (text4 == "HDDangBaiNhom")
				{
					form = new fHDDangBaiNhom("", 1, text);
				}
				break;
			case 152310871u:
				if (text4 == "HDUpCover")
				{
					form = new fHDUpCover("", 1, text);
				}
				break;
			case 311671696u:
				if (text4 == "HDKetBanGoiY")
				{
					form = new fHDKetBanGoiY("", 1, text);
				}
				break;
			case 271171672u:
				if (text4 == "HDTruyCapWebsite")
				{
					form = new fHDTruyCapWebsite("", 1, text);
				}
				break;
			case 183716342u:
				if (text4 == "HDTuongTacBaiVietIA")
				{
					form = new fHDTuongTacBaiVietIA("", 1, text);
				}
				break;
			case 444757497u:
				if (text4 == "HDKetBanTepUidNew")
				{
					form = new fHDKetBanTepUidNew("", 1, text);
				}
				break;
			case 327820411u:
				if (text4 == "HDBuffTinNhanProfile")
				{
					form = new fHDBuffTinNhanProfile("", 1, text);
				}
				break;
			case 532292684u:
				if (text4 == "HDBuffLikeComment")
				{
					form = new fHDBuffLikeComment("", 1, text);
				}
				break;
			case 523366477u:
				if (text4 == "HDBuffFollowUID")
				{
					form = new fHDBuffFollowUID("", 1, text);
				}
				break;
			case 516966741u:
				if (text4 == "HDDangReel")
				{
					form = new fHDDangReel("", 1, text);
				}
				break;
			case 614517095u:
				if (text4 == "HDReport")
				{
					form = new fHDReport("", 1, text);
				}
				break;
			case 582938346u:
				if (text4 == "HDXemStory")
				{
					form = new fHDXemStory("", 1, text);
				}
				break;
			case 551470432u:
				if (text4 == "HDSpamBanBe")
				{
					form = new fHDSpamBanBe("", 1, text);
				}
				break;
			case 852508141u:
				if (text4 == "HDKetBanTepUid")
				{
					form = new fHDKetBanTepUid("", 1, text);
				}
				break;
			case 786238800u:
				if (text4 == "HDXemWatch")
				{
					form = new fHDXemWatch("", 1, text);
				}
				break;
			case 745266353u:
				if (text4 == "HDXemReel")
				{
					form = new fHDXemReel("", 1, text);
				}
				break;
			case 1340375996u:
				if (text4 == "HDBatCheDoChuyenNghiep")
				{
					form = new fHDBatCheDoChuyenNghiep("", 1, text);
				}
				break;
			case 894688135u:
				if (text4 == "HDTuongTacReelChiDinh")
				{
					form = new fHDTuongTacReelChiDinh("", 1, text);
				}
				break;
			case 1613435342u:
				if (text4 == "HDChiaSeLivestream")
				{
					form = new fHDChiaSeLivestream("", 1, text);
				}
				break;
			case 1577102954u:
				if (text4 == "HDSpamNewfeed")
				{
					form = new fHDSpamNewfeed("", 1, text);
				}
				break;
			case 1526944464u:
				if (text4 == "HDTuongTacBanBe")
				{
					form = new fHDTuongTacBanBe("", 1, text);
				}
				break;
			case 1697418988u:
				if (text4 == "HDTimKiemGoogle")
				{
					form = new fHDTimKiemGoogle("", 1, text);
				}
				break;
			case 1653385921u:
				if (text4 == "HDNghiGiaiLao")
				{
					form = new fHDNghiGiaiLao("", 1, text);
				}
				break;
			case 1640113110u:
				if (text4 == "HDKetBanVoiBanCuaBanBe")
				{
					form = new fHDKetBanVoiBanCuaBanBe("", 1, text);
				}
				break;
			case 1810740917u:
				if (text4 == "HDNhanTinBanBe")
				{
					form = new fHDNhanTinBanBe("", 1, text);
				}
				break;
			case 1807592900u:
				if (text4 == "HDSeedingByVideo")
				{
					form = new fHDSeedingByVideo("", 1, text);
				}
				break;
			case 1780458336u:
				if (text4 == "HDDangBaiPage")
				{
					form = new fHDDangBaiPage("", 1, text);
				}
				break;
			case 1906272025u:
				if (text4 == "HDKetBanVoiBanBeCuaUid")
				{
					form = new fHDKetBanVoiBanBeCuaUid("", 1, text);
				}
				break;
			case 1884305945u:
				if (text4 == "HDDocThongBao")
				{
					form = new fHDDocThongBao("", 1, text);
				}
				break;
			case 1823818229u:
				if (text4 == "HDUpAvatar")
				{
					form = new fHDUpAvatar("", 1, text);
				}
				break;
			case 2004466602u:
				if (text4 == "HDDoiTen")
				{
					form = new fHDDoiTen("", 1, text);
				}
				break;
			case 1984335833u:
				if (text4 == "HDBaiVietBanBe")
				{
					form = new fHDBaiVietBanBe("", 1, text);
				}
				break;
			case 1952866892u:
				if (text4 == "HDKetBanTheoTuKhoa")
				{
					form = new fHDKetBanTheoTuKhoa("", 1, text);
				}
				break;
			case 2081285240u:
				if (text4 == "HDChocBanBe")
				{
					form = new fHDChocBanBe("", 1, text);
				}
				break;
			case 2065195933u:
				if (text4 == "HDBuffFollowLikePage")
				{
					form = new fHDBuffFollowLikePage("", 1, text);
				}
				break;
			case 2030328732u:
				if (text4 == "HDOnOff2FA")
				{
					form = new fHDOnOff2FA("", 1, text);
				}
				break;
			case 2277183375u:
				if (text4 == "HDRoiNhom")
				{
					form = new fHDRoiNhom("", 1, text);
				}
				break;
			case 2149398608u:
				if (text4 == "HDBuffLikePage")
				{
					form = new fHDBuffLikePage("", 1, text);
				}
				break;
			case 2117563667u:
				if (text4 == "HDKhangSpam")
				{
					form = new fHDKhangSpam("", 1, text);
				}
				break;
			case 2419354813u:
				if (text4 == "HDTaoNhom")
				{
					form = new fHDTaoNhom("", 1, text);
				}
				break;
			case 2345355553u:
				if (text4 == "HDSeedingEvents")
				{
					form = new fHDSeedingEvents("", 1, text);
				}
				break;
			case 2437988220u:
				if (text4 == "HDMoiBanBeLikePage")
				{
					form = new fHDMoiBanBeLikePage("", 1, text);
				}
				break;
			case 2433475627u:
				if (text4 == "HDChaySeeding")
				{
					form = new fHDChaySeeding("", 1, text);
				}
				break;
			case 2421286761u:
				if (text4 == "HDBaiVietNhom")
				{
					form = new fHDBaiVietNhom("", 1, text);
				}
				break;
			case 2553440797u:
				if (text4 == "HDCapNhatThongTin")
				{
					form = new fHDCapNhatThongTin("", 1, text);
				}
				break;
			case 2550743232u:
				if (text4 == "HDTuongTacWall")
				{
					form = new fHDTuongTacWall("", 1, text);
				}
				break;
			case 2540878680u:
				if (text4 == "HDThamGiaNhomTuKhoa")
				{
					form = new fHDThamGiaNhomTuKhoa("", 1, text);
				}
				break;
			case 2821037716u:
				if (text4 == "HDHuyKetBan")
				{
					form = new fHDHuyKetBan("", 1, text);
				}
				break;
			case 2735851020u:
				if (text4 == "HDBaiVietNewsfeedv2")
				{
					form = new fHDBaiVietNewsfeedv2("", 1, text);
				}
				break;
			case 2703861858u:
				if (text4 == "HDChucMungSinhNhat")
				{
					form = new fHDChucMungSinhNhat("", 1, text);
				}
				break;
			case 2887418612u:
				if (text4 == "HDDangStory_Old")
				{
					form = new fHDDangStory("", 1, text);
				}
				break;
			case 2862981448u:
				if (text4 == "HDCauHinhTaiKhoan")
				{
					form = new fHDCauHinhTaiKhoan("", 1, text);
				}
				break;
			case 2837141903u:
				if (text4 == "HDBaiVietFanpage")
				{
					form = new fHDBaiVietFanpage("", 1, text);
				}
				break;
			case 2924758840u:
				if (text4 == "HDMoiBanBeVaoNhom")
				{
					form = new fHDMoiBanBeVaoNhom("", 1, text);
				}
				break;
			case 2922412940u:
				if (text4 == "HDTaoPage")
				{
					form = new fHDTaoPage("", 1, text);
				}
				break;
			case 2889092958u:
				if (text4 == "HDXemWatch_Old")
				{
					form = new fHDXemWatch_Old("", 1, text);
				}
				break;
			case 3035546143u:
				if (text4 == "HDTuongTacNewsfeed")
				{
					form = new fHDTuongTacNewsfeed("", 1, text);
				}
				break;
			case 3010844127u:
				if (text4 == "HDXoaReel")
				{
					form = new fHDXoaReel("", 1, text);
				}
				break;
			case 2944435598u:
				if (text4 == "HDThamGiaNhomUid")
				{
					form = new fHDThamGiaNhomUid("", 1, text);
				}
				break;
			case 3102074063u:
				if (text4 == "HDTuongTacVideo")
				{
					form = new fHDTuongTacVideo("", 1, text);
				}
				break;
			case 3099572506u:
				if (text4 == "HDDangXuatThietBiCu")
				{
					form = new fHDDangXuatThietBiCu("", 1, text);
				}
				break;
			case 3094399544u:
				if (text4 == "HDDongBoDanhBa")
				{
					form = new fHDDongBoDanhBa("", 1, text);
				}
				break;
			case 3255732838u:
				if (text4 == "HDDoiMatKhau")
				{
					form = new fHDDoiMatKhau("", 1, text);
				}
				break;
			case 3182739171u:
				if (text4 == "HDTuongTacBaiVietChiDinh")
				{
					form = new fHDTuongTacBaiVietChiDinh("", 1, text);
				}
				break;
			case 3495710863u:
				if (text4 == "HDShareBaiNangCao")
				{
					form = new fHDShareBaiNangCao("", 1, text);
				}
				break;
			case 3375859832u:
				if (text4 == "HDDanhGiaPage")
				{
					form = new fHDDanhGiaPage("", 1, text);
				}
				break;
			case 3363219176u:
				if (text4 == "HDTuongTacReelTuKhoa")
				{
					form = new fHDTuongTacReelTuKhoa("", 1, text);
				}
				break;
			case 3598280146u:
				if (text4 == "HDKetBanNewfeed")
				{
					form = new fHDKetBanNewfeed("", 1, text);
				}
				break;
			case 3550581772u:
				if (text4 == "HDPhanHoiTinNhan")
				{
					form = new fHDPhanHoiTinNhan("", 1, text);
				}
				break;
			case 3503341118u:
				if (text4 == "HDTuongTacNhom")
				{
					form = new fHDTuongTacNhom("", 1, text);
				}
				break;
			case 3677432718u:
				if (text4 == "HDDangStory")
				{
					form = new fHDDangStory("", 1, text);
				}
				break;
			case 3671364376u:
				if (text4 == "HDThamGiaNhomGoiY")
				{
					form = new fHDThamGiaNhomGoiY("", 1, text);
				}
				break;
			case 3609367991u:
				if (text4 == "HDAddMail")
				{
					form = new fHDAddMail("", 1, text);
				}
				break;
			case 3779638787u:
				if (text4 == "HDBackupData")
				{
					form = new fHDBackupData("", 1, text);
				}
				break;
			case 3744161854u:
				if (text4 == "HDTuongTacNhomV2")
				{
					form = new fHDTuongTacNhomV2("", 1, text);
				}
				break;
			case 3742679556u:
				if (text4 == "HDBaiVietNewsfeed")
				{
					form = new fHDBaiVietNewsfeed("", 1, text);
				}
				break;
			case 4033341327u:
				if (text4 == "HDVerifyAccount")
				{
					form = new fHDVerifyAccount("", 1, text);
				}
				break;
			case 3917587807u:
				if (text4 == "HDHuyLoiMoiKetBan")
				{
					form = new fHDHuyLoiMoiKetBan("", 1, text);
				}
				break;
			case 3877387086u:
				if (text4 == "HDTuongTacLivestream")
				{
					form = new fHDTuongTacLivestream("", 1, text);
				}
				break;
			case 4095834327u:
				if (text4 == "HDXacNhanKetBan")
				{
					form = new fHDXacNhanKetBan("", 1, text);
				}
				break;
			case 4080982511u:
				if (text4 == "HDTuongTacPage")
				{
					form = new fHDTuongTacPage("", 1, text);
				}
				break;
			case 4062736188u:
				if (text4 == "HDXoaSdt")
				{
					form = new fHDXoaSdt("", 1, text);
				}
				break;
			case 4226158249u:
				if (text4 == "HDKetBanThanhVienNhom")
				{
					form = new fHDKetBanThanhVienNhom("", 1, text);
				}
				break;
			case 4198930712u:
				if (text4 == "HDXoaThietBiTinCay")
				{
					form = new fHDXoaThietBiTinCay("", 1, text);
				}
				break;
			case 4189681400u:
				if (text4 == "HDSpamBaiViet")
				{
					form = new fHDSpamBaiViet("", 1, text);
				}
				break;
			}
			if (form != null)
			{
				Common.smethod_16(form);
			}
			dataTable = Class123.smethod_10(text);
			DatagridviewHelper.AD3DF791(CFB2D93B, dataGridViewRow.Index, "cTenHanhDong", dataTable.Rows[0]["TenHanhDong"].ToString());
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void method_3(object sender, KeyEventArgs e)
	{
	}

	private void method_4(string string_1 = "")
	{
		try
		{
			dtgvKichBan.Rows.Clear();
			DataTable dataTable = Class123.smethod_3();
			if (dataTable.Rows.Count > 0)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					DataRow dataRow = dataTable.Rows[i];
					dtgvKichBan.Rows.Add(i + 1, dataRow["Id_KichBan"], dataRow["TenKichBan"]);
				}
			}
			if (string_1 != "")
			{
				for (int j = 0; j < dtgvKichBan.RowCount; j++)
				{
					if (DatagridviewHelper.E83E252C(dtgvKichBan, j, "cId_KichBan") == string_1)
					{
						dtgvKichBan.Rows[j].Selected = true;
						break;
					}
				}
			}
			C79DD99A();
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
		}
	}

	private void method_5()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng thêm kịch bản trước!"), 3);
			}
			else
			{
				if (MessageBoxHelper.smethod_1(Language.GetValue("Bạn có chắc muốn xóa kịch bản này?")) != DialogResult.Yes)
				{
					return;
				}
				DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
				if (Class123.FBBA661D(dataGridViewRow.Cells["cId_KichBan"].Value.ToString()))
				{
					int index = dataGridViewRow.Index;
					for (int i = index; i < dtgvKichBan.Rows.Count - 1; i++)
					{
						method_0(ref dtgvKichBan, i, i + 1);
					}
					dtgvKichBan.Rows.RemoveAt(dtgvKichBan.Rows.Count - 1);
					C79DD99A();
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
				return;
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void D603FF0A()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng thêm kịch bản trước!"), 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			Common.smethod_16(new fThemKichBan(1, text));
			string object_ = Class123.D22C6CAB(text).Rows[0]["TenKichBan"].ToString();
			DatagridviewHelper.AD3DF791(dtgvKichBan, dataGridViewRow.Index, "cTenKichBan", object_);
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void D6875180()
	{
		try
		{
			string text = "";
			try
			{
				text = Class123.smethod_4().Rows[0]["Id_KichBan"].ToString();
			}
			catch
			{
			}
			Common.smethod_16(new fThemKichBan(0));
			DataTable dataTable = Class123.smethod_4();
			string text2 = "";
			try
			{
				text2 = dataTable.Rows[0]["Id_KichBan"].ToString();
			}
			catch
			{
			}
			if (text != text2)
			{
				dtgvKichBan.Rows.Add(dtgvKichBan.RowCount + 1, dataTable.Rows[0]["Id_KichBan"], dataTable.Rows[0]["TenKichBan"]);
				dtgvKichBan.Rows[dtgvKichBan.RowCount - 1].Selected = true;
				dtgvKichBan.CurrentCell = dtgvKichBan.Rows[dtgvKichBan.RowCount - 1].Cells["cTenKichBan"];
				C79DD99A();
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void B6017929()
	{
		try
		{
			if (dtgvKichBan.RowCount == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng thêm kịch bản trước!"), 3);
				return;
			}
			DataGridViewRow dataGridViewRow = dtgvKichBan.SelectedRows[0];
			string text = dataGridViewRow.Cells["cId_KichBan"].Value.ToString();
			string text2 = dataGridViewRow.Cells["cTenKichBan"].Value.ToString();
			string string_ = text2 + " - Copy";
			int num = 2;
			while (Class123.smethod_6(string_))
			{
				string_ = text2 + $" - Copy ({num++})";
			}
			if (Class123.smethod_8(text, string_))
			{
				DataTable dataTable = Class123.smethod_4();
				dtgvKichBan.Rows.Add(dtgvKichBan.RowCount + 1, dataTable.Rows[0]["Id_KichBan"], dataTable.Rows[0]["TenKichBan"]);
				dtgvKichBan.Rows[dtgvKichBan.RowCount - 1].Selected = true;
				dtgvKichBan.CurrentCell = dtgvKichBan.Rows[dtgvKichBan.RowCount - 1].Cells["cTenKichBan"];
				C79DD99A();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
		catch
		{
		}
	}

	private void dtgvKichBan_KeyUp(object sender, KeyEventArgs e)
	{
		switch (e.KeyCode)
		{
		case Keys.Up:
		case Keys.Down:
			C79DD99A();
			break;
		case Keys.Insert:
		case Keys.F1:
			D6875180();
			break;
		case Keys.F2:
			D603FF0A();
			break;
		case Keys.F5:
			method_4();
			break;
		case Keys.D:
			if (e.Modifiers == Keys.Control)
			{
				B6017929();
			}
			break;
		case Keys.Delete:
			method_5();
			break;
		}
	}

	private void fDanhSachKichBan_Old_Paint(object sender, PaintEventArgs e)
	{
	}

	private void B8B4A593(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool AEA0DEBD)
	{
		if (AEA0DEBD && D3A4401B != null)
		{
			D3A4401B.Dispose();
		}
		base.Dispose(AEA0DEBD);
	}

	private void InitializeComponent()
	{
		D3A4401B = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhSachKichBan_Old));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		toolTip_0 = new System.Windows.Forms.ToolTip(D3A4401B);
		E51786A7 = new Bunifu.Framework.UI.BunifuDragControl(D3A4401B);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(D3A4401B);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		EAB95097 = new System.Windows.Forms.PictureBox();
		groupBox1 = new System.Windows.Forms.GroupBox();
		dtgvKichBan = new System.Windows.Forms.DataGridView();
		cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B4B06EAB = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cTenKichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
		contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(D3A4401B);
		FDA07981 = new System.Windows.Forms.ToolStripMenuItem();
		A596C6A3 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		groupBox2 = new System.Windows.Forms.GroupBox();
		A7B05614 = new System.Windows.Forms.Button();
		D4194A28 = new System.Windows.Forms.Button();
		CFB2D93B = new System.Windows.Forms.DataGridView();
		dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cId_HanhDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B5360880 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
		contextMenuStrip1_1 = new System.Windows.Forms.ContextMenuStrip(D3A4401B);
		toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		EC1F980D = new System.Windows.Forms.ToolStripMenuItem();
		panel1 = new System.Windows.Forms.Panel();
		splitContainer1 = new System.Windows.Forms.SplitContainer();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)EAB95097).BeginInit();
		groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dtgvKichBan).BeginInit();
		contextMenuStrip1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)CFB2D93B).BeginInit();
		contextMenuStrip1_1.SuspendLayout();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
		splitContainer1.Panel1.SuspendLayout();
		splitContainer1.Panel2.SuspendLayout();
		splitContainer1.SuspendLayout();
		SuspendLayout();
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		toolTip_0.ToolTipTitle = "Chú thích";
		E51786A7.Fixed = true;
		E51786A7.Horizontal = true;
		E51786A7.TargetControl = bunifuCustomLabel1;
		E51786A7.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(859, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Qua\u0309n ly\u0301 ki\u0323ch ba\u0309n";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(EAB95097);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(859, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(830, 2);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		EAB95097.Cursor = System.Windows.Forms.Cursors.Default;
		EAB95097.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		EAB95097.Location = new System.Drawing.Point(3, 2);
		EAB95097.Name = "pictureBox1";
		EAB95097.Size = new System.Drawing.Size(34, 27);
		EAB95097.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		EAB95097.TabIndex = 76;
		EAB95097.TabStop = false;
		groupBox1.BackColor = System.Drawing.Color.White;
		groupBox1.Controls.Add(dtgvKichBan);
		groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		groupBox1.Location = new System.Drawing.Point(0, 0);
		groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		groupBox1.Name = "groupBox1";
		groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		groupBox1.Size = new System.Drawing.Size(291, 494);
		groupBox1.TabIndex = 1;
		groupBox1.TabStop = false;
		groupBox1.Text = "Danh sách kịch bản";
		dtgvKichBan.AllowUserToAddRows = false;
		dtgvKichBan.AllowUserToDeleteRows = false;
		dtgvKichBan.AllowUserToResizeRows = false;
		dtgvKichBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dtgvKichBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dtgvKichBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvKichBan.Columns.AddRange(cStt, B4B06EAB, cTenKichBan);
		dtgvKichBan.ContextMenuStrip = contextMenuStrip1;
		dtgvKichBan.Dock = System.Windows.Forms.DockStyle.Fill;
		dtgvKichBan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		dtgvKichBan.Location = new System.Drawing.Point(3, 20);
		dtgvKichBan.MultiSelect = false;
		dtgvKichBan.Name = "dtgvKichBan";
		dtgvKichBan.RowHeadersVisible = false;
		dtgvKichBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dtgvKichBan.Size = new System.Drawing.Size(285, 470);
		dtgvKichBan.TabIndex = 76;
		dtgvKichBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(EB1E7C03);
		dtgvKichBan.KeyUp += new System.Windows.Forms.KeyEventHandler(dtgvKichBan_KeyUp);
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.Width = 35;
		B4B06EAB.HeaderText = "Column1";
		B4B06EAB.Name = "cId_KichBan";
		B4B06EAB.Visible = false;
		cTenKichBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cTenKichBan.HeaderText = "Tên kịch bản";
		cTenKichBan.Name = "cTenKichBan";
		contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { FDA07981, A596C6A3, toolStripMenuItem_0, toolStripMenuItem_1 });
		contextMenuStrip1.Name = "contextMenuStrip1";
		contextMenuStrip1.Size = new System.Drawing.Size(162, 92);
		FDA07981.Image = Resource.Bitmap_52;
		FDA07981.Name = "thêmMớiToolStripMenuItem";
		FDA07981.Size = new System.Drawing.Size(161, 22);
		FDA07981.Text = "Thêm ki\u0323ch ba\u0309n";
		FDA07981.Click += new System.EventHandler(A6A1153A);
		A596C6A3.Image = Resource.Bitmap_88;
		A596C6A3.Name = "sửaToolStripMenuItem";
		A596C6A3.Size = new System.Drawing.Size(161, 22);
		A596C6A3.Text = "Sửa tên ki\u0323ch ba\u0309n";
		A596C6A3.Click += new System.EventHandler(DE344CBC);
		toolStripMenuItem_0.Image = Resource.Bitmap_86;
		toolStripMenuItem_0.Name = "xóaToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(161, 22);
		toolStripMenuItem_0.Text = "Xóa ki\u0323ch ba\u0309n";
		toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		toolStripMenuItem_1.Image = Resource.B82A181B;
		toolStripMenuItem_1.Name = "nhânBảnToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(161, 22);
		toolStripMenuItem_1.Text = "Nhân bản";
		toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(862, 37);
		bunifuCards1.TabIndex = 12;
		groupBox2.BackColor = System.Drawing.Color.White;
		groupBox2.Controls.Add(A7B05614);
		groupBox2.Controls.Add(D4194A28);
		groupBox2.Controls.Add(CFB2D93B);
		groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
		groupBox2.Location = new System.Drawing.Point(0, 0);
		groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		groupBox2.Name = "groupBox2";
		groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		groupBox2.Size = new System.Drawing.Size(550, 494);
		groupBox2.TabIndex = 1;
		groupBox2.TabStop = false;
		groupBox2.Text = "Danh sách hành động";
		A7B05614.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		A7B05614.Cursor = System.Windows.Forms.Cursors.Hand;
		A7B05614.Image = Resource.F385FA99;
		A7B05614.Location = new System.Drawing.Point(505, 64);
		A7B05614.Name = "button3";
		A7B05614.Size = new System.Drawing.Size(41, 38);
		A7B05614.TabIndex = 78;
		A7B05614.UseVisualStyleBackColor = true;
		A7B05614.Click += new System.EventHandler(CAA4D495);
		D4194A28.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		D4194A28.Cursor = System.Windows.Forms.Cursors.Hand;
		D4194A28.Image = Resource.BB37B2AA;
		D4194A28.Location = new System.Drawing.Point(505, 19);
		D4194A28.Name = "button2";
		D4194A28.Size = new System.Drawing.Size(41, 38);
		D4194A28.TabIndex = 78;
		D4194A28.UseVisualStyleBackColor = true;
		D4194A28.Click += new System.EventHandler(D4194A28_Click);
		CFB2D93B.AllowUserToAddRows = false;
		CFB2D93B.AllowUserToDeleteRows = false;
		CFB2D93B.AllowUserToResizeRows = false;
		CFB2D93B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CFB2D93B.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		CFB2D93B.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		CFB2D93B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		CFB2D93B.Columns.AddRange(dataGridViewTextBoxColumn1, cId_HanhDong, B5360880, cTheLoai);
		CFB2D93B.ContextMenuStrip = contextMenuStrip1_1;
		CFB2D93B.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		CFB2D93B.Location = new System.Drawing.Point(6, 20);
		CFB2D93B.MultiSelect = false;
		CFB2D93B.Name = "dtgvHanhDong";
		CFB2D93B.RowHeadersVisible = false;
		CFB2D93B.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		CFB2D93B.Size = new System.Drawing.Size(496, 470);
		CFB2D93B.TabIndex = 77;
		CFB2D93B.KeyDown += new System.Windows.Forms.KeyEventHandler(FA24DBA5);
		dataGridViewTextBoxColumn1.HeaderText = "STT";
		dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
		dataGridViewTextBoxColumn1.Width = 35;
		cId_HanhDong.HeaderText = "Column1";
		cId_HanhDong.Name = "cId_HanhDong";
		cId_HanhDong.Visible = false;
		B5360880.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		B5360880.HeaderText = "Tên hành động";
		B5360880.Name = "cTenHanhDong";
		cTheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cTheLoai.HeaderText = "Loại tương tác";
		cTheLoai.Name = "cTheLoai";
		contextMenuStrip1_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { toolStripMenuItem1, toolStripMenuItem3, toolStripMenuItem4, EC1F980D });
		contextMenuStrip1_1.Name = "contextMenuStrip1";
		contextMenuStrip1_1.Size = new System.Drawing.Size(166, 92);
		toolStripMenuItem1.Image = Resource.Bitmap_51;
		toolStripMenuItem1.Name = "toolStripMenuItem1";
		toolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
		toolStripMenuItem1.Text = "Thêm ha\u0300nh đô\u0323ng";
		toolStripMenuItem1.Click += new System.EventHandler(E899B83E);
		toolStripMenuItem3.Image = Resource.Bitmap_87;
		toolStripMenuItem3.Name = "toolStripMenuItem3";
		toolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
		toolStripMenuItem3.Text = "Sửa ha\u0300nh đô\u0323ng";
		toolStripMenuItem3.Click += new System.EventHandler(toolStripMenuItem3_Click);
		toolStripMenuItem4.Image = Resource.Bitmap_85;
		toolStripMenuItem4.Name = "toolStripMenuItem4";
		toolStripMenuItem4.Size = new System.Drawing.Size(165, 22);
		toolStripMenuItem4.Text = "Xóa ha\u0300nh đô\u0323ng";
		toolStripMenuItem4.Click += new System.EventHandler(toolStripMenuItem4_Click);
		EC1F980D.Image = Resource.Bitmap_75;
		EC1F980D.Name = "toolStripMenuItem2";
		EC1F980D.Size = new System.Drawing.Size(165, 22);
		EC1F980D.Text = "Nhân bản";
		EC1F980D.Click += new System.EventHandler(D61941B3);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(splitContainer1);
		panel1.Controls.Add(bunifuCards1);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(865, 542);
		panel1.TabIndex = 13;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(B8B4A593);
		splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		splitContainer1.Location = new System.Drawing.Point(4, 43);
		splitContainer1.Name = "splitContainer1";
		splitContainer1.Panel1.Controls.Add(groupBox1);
		splitContainer1.Panel2.Controls.Add(groupBox2);
		splitContainer1.Size = new System.Drawing.Size(856, 494);
		splitContainer1.SplitterDistance = 291;
		splitContainer1.SplitterWidth = 15;
		splitContainer1.TabIndex = 14;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(865, 542);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fDanhSachKichBan_Old";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fDanhSachKichBan_Old_Load);
		base.Paint += new System.Windows.Forms.PaintEventHandler(fDanhSachKichBan_Old_Paint);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)EAB95097).EndInit();
		groupBox1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dtgvKichBan).EndInit();
		contextMenuStrip1.ResumeLayout(false);
		bunifuCards1.ResumeLayout(false);
		groupBox2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)CFB2D93B).EndInit();
		contextMenuStrip1_1.ResumeLayout(false);
		panel1.ResumeLayout(false);
		splitContainer1.Panel1.ResumeLayout(false);
		splitContainer1.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
		splitContainer1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
