using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fThemHanhDong : Form
{
	internal string string_0;

	internal IContainer CE925009 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl A696EEB2;

	internal BunifuCards bunifuCards1;

	internal Panel A3BB0C91;

	internal PictureBox A985C488;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button CD19A6A7;

	internal GroupBox groupBox2;

	internal Button DB3EC2A2;

	internal Button metroButton2;

	internal Button btnDocThongBao;

	internal GroupBox DD29738D;

	internal GroupBox E3394FB9;

	internal Button metroButton18;

	internal Button C48F6338;

	internal Button A78A261B;

	internal Button A2AB8A8E;

	internal Button C4AD2E99;

	internal Button F2BC2C39;

	internal Button AA99413A;

	internal PictureBox pictureBox2;

	internal PictureBox pictureBox3;

	internal PictureBox pictureBox5;

	internal Button BA9C3D83;

	internal Panel panel1;

	internal GroupBox groupBox3;

	internal PictureBox E79842BD;

	internal ToolTip C52F3713;

	internal Button A73EFD0B;

	internal Button B58FCAA5;

	internal Button metroButton35;

	internal Button metroButton38;

	internal Button metroButton41;

	internal Button A12AE52B;

	internal Button A6B298AB;

	internal Button metroButton43;

	internal Button CA29ED15;

	internal Button metroButton5;

	internal GroupBox A59954AA;

	internal PictureBox D834E20B;

	internal Button F0354A1F;

	internal Button D43522B7;

	internal Button metroButton15;

	internal Button E29B4909;

	internal Button metroButton19;

	internal Button metroButton1;

	internal Button metroButton20;

	internal Button D397742B;

	internal Button C60CC207;

	internal Button metroButton4;

	internal Button metroButton7;

	internal Button metroButton28;

	internal Button metroButton27;

	internal Button metroButton30;

	internal Button C90CA90E;

	internal Button metroButton32;

	internal Button metroButton36;

	internal Button F6B2A711;

	internal Button metroButton10;

	internal Button metroButton11;

	internal Button EE018E8D;

	internal Button CFB50693;

	internal Button EC3111AA;

	internal Button AF2D1409;

	internal Button A713FE18;

	internal Button A6B40289;

	internal Button metroButton50;

	internal Button C2A4C685;

	internal Button metroButton53;

	internal Button D10C9381;

	internal Button metroButton55;

	internal Button metroButton56;

	internal Button EABAAF10;

	internal Button A128B32B;

	internal Button metroButton61;

	internal Button CC8AA819;

	internal Button button3;

	internal Button A1929E1D;

	internal Button EC98D79C;

	internal Button button6;

	internal Button button7;

	public fThemHanhDong(string string_1)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		string_0 = string_1;
	}

	private void fThemHanhDong_Load(object sender, EventArgs e)
	{
	}

	private void CD19A6A7_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnDocThongBao_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDDocThongBao(string_0));
		if (fHDDocThongBao.bool_0)
		{
			Close();
		}
	}

	private void FF23C89E(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDXemStory(string_0));
		if (fHDXemStory.bool_0)
		{
			Close();
		}
	}

	private void DB3EC2A2_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDXemWatch(string_0));
		if (fHDXemWatch.bool_0)
		{
			Close();
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDNhanTinBanBe(string_0));
		if (fHDNhanTinBanBe.A4093DAE)
		{
			Close();
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDChocBanBe(string_0));
		if (fHDChocBanBe.bool_0)
		{
			Close();
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDChucMungSinhNhat(string_0));
		if (fHDChucMungSinhNhat.B1AE6EA5)
		{
			Close();
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDPhanHoiTinNhan(string_0));
		if (fHDPhanHoiTinNhan.bool_0)
		{
			Close();
		}
	}

	private void ADAF2739(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDBaiVietNewsfeed(string_0));
		if (fHDBaiVietNewsfeed.bool_0)
		{
			Close();
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDBaiVietBanBe(string_0));
		if (fHDBaiVietBanBe.bool_0)
		{
			Close();
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDBaiVietNhom(string_0));
		if (fHDBaiVietNhom.bool_0)
		{
			Close();
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDBaiVietFanpage(string_0));
		if (fHDBaiVietFanpage.bool_0)
		{
			Close();
		}
	}

	private void C4AD2E99_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDKetBanTheoTuKhoa(string_0));
		if (fHDKetBanTheoTuKhoa.bool_0)
		{
			Close();
		}
	}

	private void A2AB8A8E_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDKetBanGoiY(string_0));
		if (fHDKetBanGoiY.A19EB291)
		{
			Close();
		}
	}

	private void groupBox3_Enter(object sender, EventArgs e)
	{
	}

	private void metroButton18_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDXacNhanKetBan(string_0));
		if (fHDXacNhanKetBan.bool_0)
		{
			Close();
		}
	}

	private void C48F6338_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDKetBanTepUid(string_0));
		if (fHDKetBanTepUid.bool_0)
		{
			Close();
		}
	}

	private void B72F182D(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDKetBanThanhVienNhom(string_0));
		if (fHDKetBanThanhVienNhom.bool_0)
		{
			Close();
		}
	}

	private void B11A4B1C(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDHuyLoiMoiKetBan(string_0));
		if (fHDHuyLoiMoiKetBan.E38E79BE)
		{
			Close();
		}
	}

	private void A78A261B_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDHuyKetBan(string_0));
		if (fHDHuyKetBan.bool_0)
		{
			Close();
		}
	}

	private void CAA6E619(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDThamGiaNhomUid(string_0));
		if (fHDThamGiaNhomUid.B1BC6A8A)
		{
			Close();
		}
	}

	private void AA99413A_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDThamGiaNhomTuKhoa(string_0));
		if (fHDThamGiaNhomTuKhoa.E38DA63E)
		{
			Close();
		}
	}

	private void F2BC2C39_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDRoiNhom(string_0));
		if (fHDRoiNhom.D8033E8D)
		{
			Close();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDMoiBanBeVaoNhom(string_0));
		if (fHDMoiBanBeVaoNhom.bool_0)
		{
			Close();
		}
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

	private void A73EFD0B_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTuongTacNewsfeed(string_0));
		if (fHDTuongTacNewsfeed.bool_0)
		{
			Close();
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		try
		{
			Common.smethod_16(new fHDBuffLikeComment(string_0));
			if (fHDBuffLikeComment.bool_0)
			{
				Close();
			}
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "metroButton26_Click");
			MessageBoxHelper.Show(Language.GetValue("Đã có lỗi xảy ra, vui lòng liên hệ Admin!"), 2);
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDBuffFollowLikePage(string_0));
		if (fHDBuffFollowLikePage.bool_0)
		{
			Close();
		}
	}

	private void method_10(object sender, EventArgs e)
	{
	}

	private void BDBC049C(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDBuffTinNhanProfile(string_0));
		if (fHDBuffTinNhanProfile.bool_0)
		{
			Close();
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDSeedingByVideo(string_0));
		if (fHDSeedingByVideo.bool_0)
		{
			Close();
		}
	}

	private void method_12(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTruyCapWebsite(string_0));
		if (fHDTruyCapWebsite.bool_0)
		{
			Close();
		}
	}

	private void F480BBAF(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTimKiemGoogle(string_0));
		if (fHDTimKiemGoogle.bool_0)
		{
			Close();
		}
	}

	private void C1BA89A1(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTuongTacBanBe(string_0));
		if (fHDTuongTacBanBe.bool_0)
		{
			Close();
		}
	}

	private void C2880D8E(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDKetBanTepUidNew(string_0));
		if (fHDKetBanTepUidNew.C48F14B3)
		{
			Close();
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDNghiGiaiLao(string_0));
		if (fHDNghiGiaiLao.bool_0)
		{
			Close();
		}
	}

	private void metroButton38_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDThamGiaNhomGoiY(string_0));
		if (fHDThamGiaNhomGoiY.bool_0)
		{
			Close();
		}
	}

	private void A985C488_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			base.Height = 508;
		}
	}

	private void E63BC581(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDKetBanNewfeed(string_0));
		if (fHDKetBanNewfeed.EEBE79AF)
		{
			Close();
		}
	}

	private void metroButton41_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDKetBanVoiBanCuaBanBe(string_0));
		if (fHDKetBanVoiBanCuaBanBe.bool_0)
		{
			Close();
		}
	}

	private void A6B298AB_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDKetBanVoiBanBeCuaUid(string_0));
		if (fHDKetBanVoiBanBeCuaUid.AF9A8D9B)
		{
			Close();
		}
	}

	private void metroButton43_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTuongTacNhom(string_0));
		if (fHDTuongTacNhom.bool_0)
		{
			Close();
		}
	}

	private void F6B9CFB1(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTuongTacPage(string_0));
		if (fHDTuongTacPage.D700B89E)
		{
			Close();
		}
	}

	private void metroButton5_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDDongBoDanhBa(string_0));
		if (fHDDongBoDanhBa.bool_0)
		{
			Close();
		}
	}

	private void F0354A1F_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDDangBaiTuong(string_0));
		if (fHDDangBaiTuong.bool_0)
		{
			Close();
		}
	}

	private void D43522B7_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTuongTacVideo(string_0));
		if (fHDTuongTacVideo.bool_0)
		{
			Close();
		}
	}

	private void metroButton15_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDDanhGiaPage(string_0));
		if (fHDDanhGiaPage.bool_0)
		{
			Close();
		}
	}

	private void B01920A4(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTuongTacBaiVietChiDinh(string_0));
		if (fHDTuongTacBaiVietChiDinh.DD9D103D)
		{
			Close();
		}
	}

	private void metroButton19_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDSpamBaiViet(string_0));
		if (fHDSpamBaiViet.bool_0)
		{
			Close();
		}
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDBuffLikePage(string_0));
		if (fHDBuffLikePage.E71955B1)
		{
			Close();
		}
	}

	private void metroButton20_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDBuffFollowUID(string_0));
		if (fHDBuffFollowUID.D29ACAAE)
		{
			Close();
		}
	}

	private void FF3C44A8(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDDangStory(string_0));
		if (fHDDangStory.bool_0)
		{
			Close();
		}
	}

	private void C60CC207_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDDangBaiNhom(string_0));
		if (fHDDangBaiNhom.B503039D)
		{
			Close();
		}
	}

	private void F39E7206(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDXemWatchTheoTuKhoa(string_0));
		if (fHDXemWatchTheoTuKhoa.bool_0)
		{
			Close();
		}
	}

	private void DE09F387(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDShareBaiNangCao(string_0));
		if (fHDShareBaiNangCao.bool_0)
		{
			Close();
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTuongTacBaiVietIA(string_0));
		if (fHDTuongTacBaiVietIA.FA290E84)
		{
			Close();
		}
	}

	private void metroButton28_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDMoiBanBeVaoNhom(string_0));
		if (fHDMoiBanBeVaoNhom.bool_0)
		{
			Close();
		}
	}

	private void metroButton27_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDMoiBanBeLikePage(string_0));
		if (fHDMoiBanBeLikePage.bool_0)
		{
			Close();
		}
	}

	private void metroButton32_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDDoiMatKhau(string_0));
		if (fHDDoiMatKhau.bool_0)
		{
			Close();
		}
	}

	private void C90CA90E_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDDangXuatThietBiCu(string_0));
		if (fHDDangXuatThietBiCu.bool_0)
		{
			Close();
		}
	}

	private void metroButton30_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDOnOff2FA(string_0));
		if (fHDOnOff2FA.bool_0)
		{
			Close();
		}
	}

	private void B1828D95(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDKhangSpam(string_0));
		if (fHDKhangSpam.bool_0)
		{
			Close();
		}
	}

	private void metroButton36_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDXoaSdt(string_0));
		if (fHDXoaSdt.bool_0)
		{
			Close();
		}
	}

	private void F6B2A711_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDXemReel(string_0));
		if (fHDXemReel.EBA69495)
		{
			Close();
		}
	}

	private void A7BEC3A3(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDUpAvatar(string_0));
		if (fHDUpAvatar.bool_0)
		{
			Close();
		}
	}

	private void metroButton11_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDUpCover(string_0));
		if (fHDUpCover.bool_0)
		{
			Close();
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDCauHinhTaiKhoan(string_0));
		if (fHDCauHinhTaiKhoan.bool_0)
		{
			Close();
		}
	}

	private void EF14C0BD(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDSpamBanBe(string_0));
		if (fHDSpamBanBe.bool_0)
		{
			Close();
		}
	}

	private void EE018E8D_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDSpamNhom(string_0));
		if (fHDSpamNhom.B519430C)
		{
			Close();
		}
	}

	private void EC3111AA_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDDangReel(string_0));
		if (fHDDangReel.D6877C26)
		{
			Close();
		}
	}

	private void AF2D1409_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTuongTacReelChiDinh(string_0));
		if (fHDTuongTacReelChiDinh.bool_0)
		{
			Close();
		}
	}

	private void A91C699A(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDAddMail(string_0));
		if (fHDAddMail.bool_0)
		{
			Close();
		}
	}

	private void A6B40289_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDDoiTen(string_0));
		if (fHDDoiTen.bool_0)
		{
			Close();
		}
	}

	private void E9051A91(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDCapNhatThongTin(string_0));
		if (fHDCapNhatThongTin.E7ADA1B0)
		{
			Close();
		}
	}

	private void FA988988(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDDangBaiPage(string_0));
		if (fHDDangBaiPage.BF3FA92A)
		{
			Close();
		}
	}

	private void B728479F(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDVerifyAccount(string_0));
		if (fHDVerifyAccount.bool_0)
		{
			Close();
		}
	}

	private void A9A3BCB9(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDSpamNewfeed(string_0));
		if (fHDSpamNewfeed.bool_0)
		{
			Close();
		}
	}

	private void D10C9381_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTuongTacWall(string_0));
		if (fHDTuongTacWall.bool_0)
		{
			Close();
		}
	}

	private void metroButton55_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDChaySeeding(string_0));
		if (fHDChaySeeding.CC99763A)
		{
			Close();
		}
	}

	private void D1A0878D(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTuongTacBaiVietTuKhoa(string_0));
		if (fHDTuongTacBaiVietTuKhoa.BE923BA3)
		{
			Close();
		}
	}

	private void A8201F8E(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDXoaReel(string_0));
		if (fHDXoaReel.bool_0)
		{
			Close();
		}
	}

	private void C996D096(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDXoaThietBiTinCay(string_0));
		if (fHDXoaThietBiTinCay.C7A6FEA7)
		{
			Close();
		}
	}

	private void metroButton61_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDBatCheDoChuyenNghiep(string_0));
		if (fHDBatCheDoChuyenNghiep.bool_0)
		{
			Close();
		}
	}

	private void CC8AA819_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTuongTacReelTuKhoa(string_0));
		if (fHDTuongTacReelTuKhoa.CC1FC914)
		{
			Close();
		}
	}

	private void FBB51194(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTaoNhom(string_0));
		if (fHDTaoNhom.bool_0)
		{
			Close();
		}
	}

	private void A1929E1D_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDTaoPage(string_0));
		if (fHDTaoPage.BB9D9C33)
		{
			Close();
		}
	}

	private void EC98D79C_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDReport(string_0));
		if (fHDReport.bool_0)
		{
			Close();
		}
	}

	private void button6_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDSeedingEvents(string_0));
		if (fHDSeedingEvents.FCA1342B)
		{
			Close();
		}
	}

	private void B1BE4E8C(object sender, EventArgs e)
	{
		Common.smethod_16(new fHDReportVideo(string_0));
		if (fHDReportVideo.D114959C)
		{
			Close();
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && CE925009 != null)
		{
			CE925009.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		CE925009 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemHanhDong));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(CE925009);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		A696EEB2 = new Bunifu.Framework.UI.BunifuDragControl(CE925009);
		A3BB0C91 = new System.Windows.Forms.Panel();
		CD19A6A7 = new System.Windows.Forms.Button();
		A985C488 = new System.Windows.Forms.PictureBox();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		groupBox2 = new System.Windows.Forms.GroupBox();
		pictureBox2 = new System.Windows.Forms.PictureBox();
		F6B2A711 = new System.Windows.Forms.Button();
		metroButton43 = new System.Windows.Forms.Button();
		metroButton4 = new System.Windows.Forms.Button();
		button3 = new System.Windows.Forms.Button();
		DB3EC2A2 = new System.Windows.Forms.Button();
		CA29ED15 = new System.Windows.Forms.Button();
		metroButton2 = new System.Windows.Forms.Button();
		D10C9381 = new System.Windows.Forms.Button();
		A73EFD0B = new System.Windows.Forms.Button();
		B58FCAA5 = new System.Windows.Forms.Button();
		btnDocThongBao = new System.Windows.Forms.Button();
		D397742B = new System.Windows.Forms.Button();
		F0354A1F = new System.Windows.Forms.Button();
		DD29738D = new System.Windows.Forms.GroupBox();
		A1929E1D = new System.Windows.Forms.Button();
		F2BC2C39 = new System.Windows.Forms.Button();
		pictureBox3 = new System.Windows.Forms.PictureBox();
		C4AD2E99 = new System.Windows.Forms.Button();
		metroButton18 = new System.Windows.Forms.Button();
		metroButton35 = new System.Windows.Forms.Button();
		BA9C3D83 = new System.Windows.Forms.Button();
		C48F6338 = new System.Windows.Forms.Button();
		AA99413A = new System.Windows.Forms.Button();
		metroButton38 = new System.Windows.Forms.Button();
		A2AB8A8E = new System.Windows.Forms.Button();
		A78A261B = new System.Windows.Forms.Button();
		A12AE52B = new System.Windows.Forms.Button();
		A6B298AB = new System.Windows.Forms.Button();
		metroButton41 = new System.Windows.Forms.Button();
		EABAAF10 = new System.Windows.Forms.Button();
		D43522B7 = new System.Windows.Forms.Button();
		E29B4909 = new System.Windows.Forms.Button();
		E3394FB9 = new System.Windows.Forms.GroupBox();
		metroButton7 = new System.Windows.Forms.Button();
		pictureBox5 = new System.Windows.Forms.PictureBox();
		C2A4C685 = new System.Windows.Forms.Button();
		C60CC207 = new System.Windows.Forms.Button();
		metroButton19 = new System.Windows.Forms.Button();
		EC3111AA = new System.Windows.Forms.Button();
		CFB50693 = new System.Windows.Forms.Button();
		metroButton53 = new System.Windows.Forms.Button();
		EE018E8D = new System.Windows.Forms.Button();
		button7 = new System.Windows.Forms.Button();
		EC98D79C = new System.Windows.Forms.Button();
		button6 = new System.Windows.Forms.Button();
		metroButton55 = new System.Windows.Forms.Button();
		panel1 = new System.Windows.Forms.Panel();
		A59954AA = new System.Windows.Forms.GroupBox();
		D834E20B = new System.Windows.Forms.PictureBox();
		C90CA90E = new System.Windows.Forms.Button();
		metroButton11 = new System.Windows.Forms.Button();
		A128B32B = new System.Windows.Forms.Button();
		A713FE18 = new System.Windows.Forms.Button();
		metroButton50 = new System.Windows.Forms.Button();
		metroButton10 = new System.Windows.Forms.Button();
		metroButton32 = new System.Windows.Forms.Button();
		metroButton61 = new System.Windows.Forms.Button();
		metroButton30 = new System.Windows.Forms.Button();
		metroButton36 = new System.Windows.Forms.Button();
		A6B40289 = new System.Windows.Forms.Button();
		groupBox3 = new System.Windows.Forms.GroupBox();
		metroButton5 = new System.Windows.Forms.Button();
		AF2D1409 = new System.Windows.Forms.Button();
		E79842BD = new System.Windows.Forms.PictureBox();
		CC8AA819 = new System.Windows.Forms.Button();
		metroButton56 = new System.Windows.Forms.Button();
		metroButton20 = new System.Windows.Forms.Button();
		metroButton28 = new System.Windows.Forms.Button();
		metroButton27 = new System.Windows.Forms.Button();
		metroButton1 = new System.Windows.Forms.Button();
		metroButton15 = new System.Windows.Forms.Button();
		C52F3713 = new System.Windows.Forms.ToolTip(CE925009);
		A3BB0C91.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A985C488).BeginInit();
		bunifuCards1.SuspendLayout();
		groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
		DD29738D.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
		E3394FB9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
		panel1.SuspendLayout();
		A59954AA.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D834E20B).BeginInit();
		groupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E79842BD).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(1039, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Danh sách hành động";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A696EEB2.Fixed = true;
		A696EEB2.Horizontal = true;
		A696EEB2.TargetControl = A3BB0C91;
		A696EEB2.Vertical = true;
		A3BB0C91.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A3BB0C91.BackColor = System.Drawing.Color.White;
		A3BB0C91.Controls.Add(CD19A6A7);
		A3BB0C91.Controls.Add(A985C488);
		A3BB0C91.Controls.Add(bunifuCustomLabel1);
		A3BB0C91.Cursor = System.Windows.Forms.Cursors.SizeAll;
		A3BB0C91.Location = new System.Drawing.Point(0, 3);
		A3BB0C91.Name = "pnlHeader";
		A3BB0C91.Size = new System.Drawing.Size(1039, 31);
		A3BB0C91.TabIndex = 9;
		CD19A6A7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		CD19A6A7.Cursor = System.Windows.Forms.Cursors.Hand;
		CD19A6A7.FlatAppearance.BorderSize = 0;
		CD19A6A7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CD19A6A7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CD19A6A7.ForeColor = System.Drawing.Color.White;
		CD19A6A7.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		CD19A6A7.Location = new System.Drawing.Point(1007, 1);
		CD19A6A7.Name = "button1";
		CD19A6A7.Size = new System.Drawing.Size(30, 30);
		CD19A6A7.TabIndex = 77;
		CD19A6A7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		CD19A6A7.UseVisualStyleBackColor = true;
		CD19A6A7.Click += new System.EventHandler(CD19A6A7_Click);
		A985C488.Cursor = System.Windows.Forms.Cursors.Default;
		A985C488.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		A985C488.Location = new System.Drawing.Point(3, 2);
		A985C488.Name = "pictureBox1";
		A985C488.Size = new System.Drawing.Size(34, 27);
		A985C488.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A985C488.TabIndex = 76;
		A985C488.TabStop = false;
		A985C488.Click += new System.EventHandler(A985C488_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(A3BB0C91);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(1039, 37);
		bunifuCards1.TabIndex = 1;
		groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		groupBox2.Controls.Add(pictureBox2);
		groupBox2.Controls.Add(F6B2A711);
		groupBox2.Controls.Add(metroButton43);
		groupBox2.Controls.Add(metroButton4);
		groupBox2.Controls.Add(button3);
		groupBox2.Controls.Add(DB3EC2A2);
		groupBox2.Controls.Add(CA29ED15);
		groupBox2.Controls.Add(metroButton2);
		groupBox2.Controls.Add(D10C9381);
		groupBox2.Controls.Add(A73EFD0B);
		groupBox2.Controls.Add(B58FCAA5);
		groupBox2.Controls.Add(btnDocThongBao);
		groupBox2.Location = new System.Drawing.Point(9, 43);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(200, 462);
		groupBox2.TabIndex = 0;
		groupBox2.TabStop = false;
		groupBox2.Text = "Tương tác";
		pictureBox2.Image = Resource.Bitmap_3;
		pictureBox2.Location = new System.Drawing.Point(14, 34);
		pictureBox2.Name = "pictureBox2";
		pictureBox2.Size = new System.Drawing.Size(171, 83);
		pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		pictureBox2.TabIndex = 1;
		pictureBox2.TabStop = false;
		F6B2A711.Cursor = System.Windows.Forms.Cursors.Hand;
		F6B2A711.Location = new System.Drawing.Point(14, 165);
		F6B2A711.Name = "metroButton6";
		F6B2A711.Size = new System.Drawing.Size(171, 26);
		F6B2A711.TabIndex = 2;
		F6B2A711.Text = "Xem Reel";
		F6B2A711.Click += new System.EventHandler(F6B2A711_Click);
		metroButton43.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton43.Location = new System.Drawing.Point(14, 339);
		metroButton43.Name = "metroButton43";
		metroButton43.Size = new System.Drawing.Size(171, 26);
		metroButton43.TabIndex = 6;
		metroButton43.Text = "Tương tác Nhóm";
		metroButton43.Click += new System.EventHandler(metroButton43_Click);
		metroButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton4.Location = new System.Drawing.Point(14, 252);
		metroButton4.Name = "metroButton4";
		metroButton4.Size = new System.Drawing.Size(171, 26);
		metroButton4.TabIndex = 3;
		metroButton4.Text = "Xem Watch theo tư\u0300 kho\u0301a";
		metroButton4.Click += new System.EventHandler(F39E7206);
		button3.Cursor = System.Windows.Forms.Cursors.Hand;
		button3.Location = new System.Drawing.Point(14, 426);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(171, 26);
		button3.TabIndex = 0;
		button3.Text = "Nghỉ giải lao";
		button3.Click += new System.EventHandler(button3_Click);
		DB3EC2A2.Cursor = System.Windows.Forms.Cursors.Hand;
		DB3EC2A2.Location = new System.Drawing.Point(14, 223);
		DB3EC2A2.Name = "metroButton3";
		DB3EC2A2.Size = new System.Drawing.Size(171, 26);
		DB3EC2A2.TabIndex = 2;
		DB3EC2A2.Text = "Xem Watch";
		DB3EC2A2.Click += new System.EventHandler(DB3EC2A2_Click);
		CA29ED15.Cursor = System.Windows.Forms.Cursors.Hand;
		CA29ED15.Location = new System.Drawing.Point(14, 368);
		CA29ED15.Name = "metroButton42";
		CA29ED15.Size = new System.Drawing.Size(171, 26);
		CA29ED15.TabIndex = 7;
		CA29ED15.Text = "Tương ta\u0301c Page";
		CA29ED15.Click += new System.EventHandler(F6B9CFB1);
		metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton2.Location = new System.Drawing.Point(14, 194);
		metroButton2.Name = "metroButton2";
		metroButton2.Size = new System.Drawing.Size(171, 26);
		metroButton2.TabIndex = 1;
		metroButton2.Text = "Xem Story";
		metroButton2.Click += new System.EventHandler(FF23C89E);
		D10C9381.Cursor = System.Windows.Forms.Cursors.Hand;
		D10C9381.Location = new System.Drawing.Point(14, 397);
		D10C9381.Name = "metroButton54";
		D10C9381.Size = new System.Drawing.Size(171, 26);
		D10C9381.TabIndex = 4;
		D10C9381.Text = "Tương tác Wall";
		D10C9381.Click += new System.EventHandler(D10C9381_Click);
		A73EFD0B.Cursor = System.Windows.Forms.Cursors.Hand;
		A73EFD0B.Location = new System.Drawing.Point(14, 281);
		A73EFD0B.Name = "metroButton29";
		A73EFD0B.Size = new System.Drawing.Size(171, 26);
		A73EFD0B.TabIndex = 4;
		A73EFD0B.Text = "Tương tác Newsfeed";
		A73EFD0B.Click += new System.EventHandler(A73EFD0B_Click);
		B58FCAA5.Cursor = System.Windows.Forms.Cursors.Hand;
		B58FCAA5.Location = new System.Drawing.Point(14, 310);
		B58FCAA5.Name = "metroButton34";
		B58FCAA5.Size = new System.Drawing.Size(171, 26);
		B58FCAA5.TabIndex = 5;
		B58FCAA5.Text = "Tương ta\u0301c Bạn bè";
		B58FCAA5.Click += new System.EventHandler(C1BA89A1);
		btnDocThongBao.BackColor = System.Drawing.SystemColors.Control;
		btnDocThongBao.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDocThongBao.ForeColor = System.Drawing.Color.Black;
		btnDocThongBao.Location = new System.Drawing.Point(14, 136);
		btnDocThongBao.Name = "btnDocThongBao";
		btnDocThongBao.Size = new System.Drawing.Size(171, 26);
		btnDocThongBao.TabIndex = 0;
		btnDocThongBao.Text = "Đọc thông báo";
		btnDocThongBao.UseVisualStyleBackColor = true;
		btnDocThongBao.Click += new System.EventHandler(btnDocThongBao_Click);
		D397742B.Cursor = System.Windows.Forms.Cursors.Hand;
		D397742B.Location = new System.Drawing.Point(14, 397);
		D397742B.Name = "metroButton24";
		D397742B.Size = new System.Drawing.Size(171, 26);
		D397742B.TabIndex = 0;
		D397742B.Text = "Đăng Story";
		D397742B.Click += new System.EventHandler(FF3C44A8);
		F0354A1F.Cursor = System.Windows.Forms.Cursors.Hand;
		F0354A1F.Location = new System.Drawing.Point(14, 136);
		F0354A1F.Name = "metroButton8";
		F0354A1F.Size = new System.Drawing.Size(171, 26);
		F0354A1F.TabIndex = 1;
		F0354A1F.Text = "Đăng ba\u0300i lên tươ\u0300ng";
		F0354A1F.Click += new System.EventHandler(F0354A1F_Click);
		DD29738D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		DD29738D.Controls.Add(A1929E1D);
		DD29738D.Controls.Add(F2BC2C39);
		DD29738D.Controls.Add(pictureBox3);
		DD29738D.Controls.Add(C4AD2E99);
		DD29738D.Controls.Add(metroButton18);
		DD29738D.Controls.Add(metroButton35);
		DD29738D.Controls.Add(BA9C3D83);
		DD29738D.Controls.Add(C48F6338);
		DD29738D.Controls.Add(AA99413A);
		DD29738D.Controls.Add(metroButton38);
		DD29738D.Controls.Add(A2AB8A8E);
		DD29738D.Controls.Add(A78A261B);
		DD29738D.Controls.Add(A12AE52B);
		DD29738D.Controls.Add(A6B298AB);
		DD29738D.Controls.Add(metroButton41);
		DD29738D.Location = new System.Drawing.Point(215, 43);
		DD29738D.Name = "groupBox1";
		DD29738D.Size = new System.Drawing.Size(200, 462);
		DD29738D.TabIndex = 1;
		DD29738D.TabStop = false;
		DD29738D.Text = "Kê\u0301t ba\u0323n - Tham gia nho\u0301m";
		A1929E1D.Cursor = System.Windows.Forms.Cursors.Hand;
		A1929E1D.Location = new System.Drawing.Point(14, 426);
		A1929E1D.Name = "button4";
		A1929E1D.Size = new System.Drawing.Size(171, 26);
		A1929E1D.TabIndex = 0;
		A1929E1D.Text = "Tạo page";
		A1929E1D.Click += new System.EventHandler(A1929E1D_Click);
		F2BC2C39.Cursor = System.Windows.Forms.Cursors.Hand;
		F2BC2C39.Location = new System.Drawing.Point(14, 368);
		F2BC2C39.Name = "metroButton22";
		F2BC2C39.Size = new System.Drawing.Size(171, 26);
		F2BC2C39.TabIndex = 7;
		F2BC2C39.Text = "Rời nhóm";
		F2BC2C39.Click += new System.EventHandler(F2BC2C39_Click);
		pictureBox3.Image = Resource.D099E10B;
		pictureBox3.Location = new System.Drawing.Point(14, 34);
		pictureBox3.Name = "pictureBox3";
		pictureBox3.Size = new System.Drawing.Size(171, 83);
		pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		pictureBox3.TabIndex = 1;
		pictureBox3.TabStop = false;
		C4AD2E99.Cursor = System.Windows.Forms.Cursors.Hand;
		C4AD2E99.Location = new System.Drawing.Point(14, 136);
		C4AD2E99.Name = "metroButton14";
		C4AD2E99.Size = new System.Drawing.Size(171, 26);
		C4AD2E99.TabIndex = 0;
		C4AD2E99.Text = "Kết bạn theo từ khóa";
		C4AD2E99.Click += new System.EventHandler(C4AD2E99_Click);
		metroButton18.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton18.Location = new System.Drawing.Point(14, 223);
		metroButton18.Name = "metroButton18";
		metroButton18.Size = new System.Drawing.Size(171, 26);
		metroButton18.TabIndex = 2;
		metroButton18.Text = "Xác nhận kết bạn";
		metroButton18.Click += new System.EventHandler(metroButton18_Click);
		metroButton35.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton35.Location = new System.Drawing.Point(14, 397);
		metroButton35.Name = "metroButton35";
		metroButton35.Size = new System.Drawing.Size(171, 26);
		metroButton35.TabIndex = 0;
		metroButton35.Text = "Tạo nhóm";
		metroButton35.Click += new System.EventHandler(FBB51194);
		BA9C3D83.Cursor = System.Windows.Forms.Cursors.Hand;
		BA9C3D83.Location = new System.Drawing.Point(14, 310);
		BA9C3D83.Name = "metroButton21";
		BA9C3D83.Size = new System.Drawing.Size(171, 26);
		BA9C3D83.TabIndex = 6;
		BA9C3D83.Text = "Tham gia nhóm theo tệp UID";
		BA9C3D83.Click += new System.EventHandler(CAA6E619);
		C48F6338.Cursor = System.Windows.Forms.Cursors.Hand;
		C48F6338.Location = new System.Drawing.Point(14, 165);
		C48F6338.Name = "metroButton9";
		C48F6338.Size = new System.Drawing.Size(171, 26);
		C48F6338.TabIndex = 3;
		C48F6338.Text = "Kết bạn theo tệp UID";
		C48F6338.Click += new System.EventHandler(C48F6338_Click);
		AA99413A.Cursor = System.Windows.Forms.Cursors.Hand;
		AA99413A.Location = new System.Drawing.Point(14, 281);
		AA99413A.Name = "metroButton23";
		AA99413A.Size = new System.Drawing.Size(171, 26);
		AA99413A.TabIndex = 5;
		AA99413A.Text = "Tham gia nhóm theo từ khóa";
		AA99413A.Click += new System.EventHandler(AA99413A_Click);
		metroButton38.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton38.Location = new System.Drawing.Point(14, 339);
		metroButton38.Name = "metroButton38";
		metroButton38.Size = new System.Drawing.Size(171, 26);
		metroButton38.TabIndex = 3;
		metroButton38.Text = "Tham gia nhóm theo gợi ý";
		metroButton38.Click += new System.EventHandler(metroButton38_Click);
		A2AB8A8E.Cursor = System.Windows.Forms.Cursors.Hand;
		A2AB8A8E.Location = new System.Drawing.Point(14, 194);
		A2AB8A8E.Name = "metroButton13";
		A2AB8A8E.Size = new System.Drawing.Size(171, 26);
		A2AB8A8E.TabIndex = 1;
		A2AB8A8E.Text = "Kết bạn theo gợi ý";
		A2AB8A8E.Click += new System.EventHandler(A2AB8A8E_Click);
		A78A261B.Cursor = System.Windows.Forms.Cursors.Hand;
		A78A261B.Location = new System.Drawing.Point(14, 252);
		A78A261B.Name = "metroButton17";
		A78A261B.Size = new System.Drawing.Size(171, 26);
		A78A261B.TabIndex = 4;
		A78A261B.Text = "Hủy kết bạn";
		A78A261B.Click += new System.EventHandler(A78A261B_Click);
		A12AE52B.Cursor = System.Windows.Forms.Cursors.Hand;
		A12AE52B.Enabled = false;
		A12AE52B.Location = new System.Drawing.Point(14, 194);
		A12AE52B.Name = "metroButton40";
		A12AE52B.Size = new System.Drawing.Size(171, 26);
		A12AE52B.TabIndex = 6;
		A12AE52B.Text = "Kết bạn Newfeed (ẩn)";
		A12AE52B.Visible = false;
		A12AE52B.Click += new System.EventHandler(E63BC581);
		A6B298AB.Cursor = System.Windows.Forms.Cursors.Hand;
		A6B298AB.Enabled = false;
		A6B298AB.Location = new System.Drawing.Point(14, 252);
		A6B298AB.Name = "metroButton39";
		A6B298AB.Size = new System.Drawing.Size(171, 26);
		A6B298AB.TabIndex = 6;
		A6B298AB.Text = "Kết bạn với bạn bè của Uid (ẩn)";
		A6B298AB.Visible = false;
		A6B298AB.Click += new System.EventHandler(A6B298AB_Click);
		metroButton41.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton41.Enabled = false;
		metroButton41.Location = new System.Drawing.Point(14, 223);
		metroButton41.Name = "metroButton41";
		metroButton41.Size = new System.Drawing.Size(171, 26);
		metroButton41.TabIndex = 6;
		metroButton41.Text = "Kết bạn với bạn của bạn bè (ẩn)";
		metroButton41.Visible = false;
		metroButton41.Click += new System.EventHandler(metroButton41_Click);
		EABAAF10.Cursor = System.Windows.Forms.Cursors.Hand;
		EABAAF10.Location = new System.Drawing.Point(14, 368);
		EABAAF10.Name = "metroButton57";
		EABAAF10.Size = new System.Drawing.Size(171, 26);
		EABAAF10.TabIndex = 4;
		EABAAF10.Text = "Xóa Reel";
		EABAAF10.Click += new System.EventHandler(A8201F8E);
		D43522B7.Cursor = System.Windows.Forms.Cursors.Hand;
		D43522B7.Location = new System.Drawing.Point(14, 281);
		D43522B7.Name = "metroButton12";
		D43522B7.Size = new System.Drawing.Size(171, 26);
		D43522B7.TabIndex = 6;
		D43522B7.Text = "Tương ta\u0301c Video, Livestream";
		D43522B7.Click += new System.EventHandler(D43522B7_Click);
		E29B4909.Cursor = System.Windows.Forms.Cursors.Hand;
		E29B4909.Location = new System.Drawing.Point(14, 252);
		E29B4909.Name = "metroButton16";
		E29B4909.Size = new System.Drawing.Size(171, 26);
		E29B4909.TabIndex = 1;
		E29B4909.Text = "Tương ta\u0301c Ba\u0300i viê\u0301t chi\u0309 đi\u0323nh";
		E29B4909.Click += new System.EventHandler(B01920A4);
		E3394FB9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		E3394FB9.Controls.Add(D397742B);
		E3394FB9.Controls.Add(metroButton7);
		E3394FB9.Controls.Add(pictureBox5);
		E3394FB9.Controls.Add(C2A4C685);
		E3394FB9.Controls.Add(C60CC207);
		E3394FB9.Controls.Add(F0354A1F);
		E3394FB9.Controls.Add(metroButton19);
		E3394FB9.Controls.Add(EC3111AA);
		E3394FB9.Controls.Add(CFB50693);
		E3394FB9.Controls.Add(metroButton53);
		E3394FB9.Controls.Add(EE018E8D);
		E3394FB9.Controls.Add(EABAAF10);
		E3394FB9.Controls.Add(button6);
		E3394FB9.Controls.Add(metroButton55);
		E3394FB9.Controls.Add(button7);
		E3394FB9.Controls.Add(EC98D79C);
		E3394FB9.Location = new System.Drawing.Point(421, 43);
		E3394FB9.Name = "groupBox4";
		E3394FB9.Size = new System.Drawing.Size(200, 462);
		E3394FB9.TabIndex = 2;
		E3394FB9.TabStop = false;
		E3394FB9.Text = "Đăng ba\u0300i - Share ba\u0300i - Spam";
		metroButton7.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton7.Location = new System.Drawing.Point(14, 223);
		metroButton7.Name = "metroButton7";
		metroButton7.Size = new System.Drawing.Size(171, 26);
		metroButton7.TabIndex = 5;
		metroButton7.Text = "Share bài";
		metroButton7.Click += new System.EventHandler(DE09F387);
		pictureBox5.Image = Resource.Bitmap_11;
		pictureBox5.Location = new System.Drawing.Point(14, 34);
		pictureBox5.Name = "pictureBox5";
		pictureBox5.Size = new System.Drawing.Size(171, 83);
		pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		pictureBox5.TabIndex = 1;
		pictureBox5.TabStop = false;
		C2A4C685.Cursor = System.Windows.Forms.Cursors.Hand;
		C2A4C685.Location = new System.Drawing.Point(14, 194);
		C2A4C685.Name = "metroButton51";
		C2A4C685.Size = new System.Drawing.Size(171, 26);
		C2A4C685.TabIndex = 2;
		C2A4C685.Text = "Đăng ba\u0300i lên page";
		C2A4C685.Click += new System.EventHandler(FA988988);
		C60CC207.Cursor = System.Windows.Forms.Cursors.Hand;
		C60CC207.Location = new System.Drawing.Point(14, 165);
		C60CC207.Name = "metroButton25";
		C60CC207.Size = new System.Drawing.Size(171, 26);
		C60CC207.TabIndex = 2;
		C60CC207.Text = "Đăng ba\u0300i lên nho\u0301m";
		C60CC207.Click += new System.EventHandler(C60CC207_Click);
		metroButton19.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton19.Location = new System.Drawing.Point(14, 339);
		metroButton19.Name = "metroButton19";
		metroButton19.Size = new System.Drawing.Size(171, 26);
		metroButton19.TabIndex = 1;
		metroButton19.Text = "Spam ba\u0300i viê\u0301t";
		metroButton19.Click += new System.EventHandler(metroButton19_Click);
		EC3111AA.Cursor = System.Windows.Forms.Cursors.Hand;
		EC3111AA.Location = new System.Drawing.Point(14, 368);
		EC3111AA.Name = "metroButton46";
		EC3111AA.Size = new System.Drawing.Size(171, 26);
		EC3111AA.TabIndex = 4;
		EC3111AA.Text = "Đăng Reel";
		EC3111AA.Click += new System.EventHandler(EC3111AA_Click);
		CFB50693.Cursor = System.Windows.Forms.Cursors.Hand;
		CFB50693.Location = new System.Drawing.Point(14, 281);
		CFB50693.Name = "metroButton45";
		CFB50693.Size = new System.Drawing.Size(171, 26);
		CFB50693.TabIndex = 1;
		CFB50693.Text = "Spam bạn bè";
		CFB50693.Click += new System.EventHandler(EF14C0BD);
		metroButton53.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton53.Location = new System.Drawing.Point(14, 252);
		metroButton53.Name = "metroButton53";
		metroButton53.Size = new System.Drawing.Size(171, 26);
		metroButton53.TabIndex = 1;
		metroButton53.Text = "Spam Newfeed";
		metroButton53.Click += new System.EventHandler(A9A3BCB9);
		EE018E8D.Cursor = System.Windows.Forms.Cursors.Hand;
		EE018E8D.Location = new System.Drawing.Point(14, 310);
		EE018E8D.Name = "metroButton44";
		EE018E8D.Size = new System.Drawing.Size(171, 26);
		EE018E8D.TabIndex = 1;
		EE018E8D.Text = "Spam nhóm";
		EE018E8D.Click += new System.EventHandler(EE018E8D_Click);
		button7.Cursor = System.Windows.Forms.Cursors.Hand;
		button7.Location = new System.Drawing.Point(14, 426);
		button7.Name = "button7";
		button7.Size = new System.Drawing.Size(171, 26);
		button7.TabIndex = 6;
		button7.Text = "Report video";
		button7.Click += new System.EventHandler(B1BE4E8C);
		EC98D79C.Cursor = System.Windows.Forms.Cursors.Hand;
		EC98D79C.Location = new System.Drawing.Point(14, 426);
		EC98D79C.Name = "button5";
		EC98D79C.Size = new System.Drawing.Size(171, 26);
		EC98D79C.TabIndex = 0;
		EC98D79C.Text = "Report (ẩn)";
		EC98D79C.Click += new System.EventHandler(EC98D79C_Click);
		button6.Cursor = System.Windows.Forms.Cursors.Hand;
		button6.Location = new System.Drawing.Point(14, 426);
		button6.Name = "button6";
		button6.Size = new System.Drawing.Size(171, 26);
		button6.TabIndex = 0;
		button6.Text = "Seeding Events";
		button6.Click += new System.EventHandler(button6_Click);
		metroButton55.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton55.Location = new System.Drawing.Point(14, 426);
		metroButton55.Name = "metroButton55";
		metroButton55.Size = new System.Drawing.Size(171, 26);
		metroButton55.TabIndex = 0;
		metroButton55.Text = "Chạy Job Seeding (ẩn)";
		metroButton55.Click += new System.EventHandler(metroButton55_Click);
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(A59954AA);
		panel1.Controls.Add(groupBox3);
		panel1.Controls.Add(bunifuCards1);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(1042, 514);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		A59954AA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		A59954AA.Controls.Add(D834E20B);
		A59954AA.Controls.Add(C90CA90E);
		A59954AA.Controls.Add(metroButton11);
		A59954AA.Controls.Add(A128B32B);
		A59954AA.Controls.Add(A713FE18);
		A59954AA.Controls.Add(metroButton50);
		A59954AA.Controls.Add(metroButton10);
		A59954AA.Controls.Add(metroButton32);
		A59954AA.Controls.Add(metroButton61);
		A59954AA.Controls.Add(metroButton30);
		A59954AA.Controls.Add(metroButton36);
		A59954AA.Controls.Add(A6B40289);
		A59954AA.Location = new System.Drawing.Point(832, 43);
		A59954AA.Name = "groupBox7";
		A59954AA.Size = new System.Drawing.Size(200, 461);
		A59954AA.TabIndex = 2;
		A59954AA.TabStop = false;
		A59954AA.Text = "Đổi thông tin";
		A59954AA.Enter += new System.EventHandler(groupBox3_Enter);
		D834E20B.Image = Resource.Bitmap_2;
		D834E20B.Location = new System.Drawing.Point(14, 33);
		D834E20B.Name = "pictureBox8";
		D834E20B.Size = new System.Drawing.Size(171, 83);
		D834E20B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		D834E20B.TabIndex = 1;
		D834E20B.TabStop = false;
		C90CA90E.Cursor = System.Windows.Forms.Cursors.Hand;
		C90CA90E.Location = new System.Drawing.Point(14, 368);
		C90CA90E.Name = "metroButton31";
		C90CA90E.Size = new System.Drawing.Size(171, 26);
		C90CA90E.TabIndex = 1;
		C90CA90E.Text = "Đăng xuâ\u0301t thiê\u0301t bi\u0323 cu\u0303";
		C90CA90E.Click += new System.EventHandler(C90CA90E_Click);
		metroButton11.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton11.Location = new System.Drawing.Point(14, 194);
		metroButton11.Name = "metroButton11";
		metroButton11.Size = new System.Drawing.Size(171, 26);
		metroButton11.TabIndex = 1;
		metroButton11.Text = "Up Cover";
		metroButton11.Click += new System.EventHandler(metroButton11_Click);
		A128B32B.Cursor = System.Windows.Forms.Cursors.Hand;
		A128B32B.Location = new System.Drawing.Point(14, 397);
		A128B32B.Name = "metroButton58";
		A128B32B.Size = new System.Drawing.Size(171, 26);
		A128B32B.TabIndex = 1;
		A128B32B.Text = "Xóa thiết bị tin cậy";
		A128B32B.Click += new System.EventHandler(C996D096);
		A713FE18.Cursor = System.Windows.Forms.Cursors.Hand;
		A713FE18.Location = new System.Drawing.Point(14, 281);
		A713FE18.Name = "metroButton48";
		A713FE18.Size = new System.Drawing.Size(171, 26);
		A713FE18.TabIndex = 4;
		A713FE18.Text = "Add mail";
		A713FE18.Click += new System.EventHandler(A91C699A);
		metroButton50.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton50.Location = new System.Drawing.Point(14, 339);
		metroButton50.Name = "metroButton50";
		metroButton50.Size = new System.Drawing.Size(171, 26);
		metroButton50.TabIndex = 4;
		metroButton50.Text = "Cập nhật thông tin";
		metroButton50.Click += new System.EventHandler(E9051A91);
		metroButton10.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton10.Location = new System.Drawing.Point(14, 165);
		metroButton10.Name = "metroButton10";
		metroButton10.Size = new System.Drawing.Size(171, 26);
		metroButton10.TabIndex = 1;
		metroButton10.Text = "Up Avatar";
		metroButton10.Click += new System.EventHandler(A7BEC3A3);
		metroButton32.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton32.Location = new System.Drawing.Point(14, 136);
		metroButton32.Name = "metroButton32";
		metroButton32.Size = new System.Drawing.Size(171, 26);
		metroButton32.TabIndex = 1;
		metroButton32.Text = "Đô\u0309i mâ\u0323t khâ\u0309u";
		metroButton32.Click += new System.EventHandler(metroButton32_Click);
		metroButton61.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton61.Location = new System.Drawing.Point(14, 426);
		metroButton61.Name = "metroButton61";
		metroButton61.Size = new System.Drawing.Size(171, 26);
		metroButton61.TabIndex = 4;
		metroButton61.Text = "Bật chế độ chuyên nghiệp";
		metroButton61.Click += new System.EventHandler(metroButton61_Click);
		metroButton30.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton30.Location = new System.Drawing.Point(14, 252);
		metroButton30.Name = "metroButton30";
		metroButton30.Size = new System.Drawing.Size(171, 26);
		metroButton30.TabIndex = 1;
		metroButton30.Text = "Bật - Tắt 2FA";
		metroButton30.Click += new System.EventHandler(metroButton30_Click);
		metroButton36.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton36.Location = new System.Drawing.Point(14, 223);
		metroButton36.Name = "metroButton36";
		metroButton36.Size = new System.Drawing.Size(171, 26);
		metroButton36.TabIndex = 4;
		metroButton36.Text = "Xóa Sđt";
		metroButton36.Click += new System.EventHandler(metroButton36_Click);
		A6B40289.Cursor = System.Windows.Forms.Cursors.Hand;
		A6B40289.Location = new System.Drawing.Point(14, 310);
		A6B40289.Name = "metroButton49";
		A6B40289.Size = new System.Drawing.Size(171, 26);
		A6B40289.TabIndex = 4;
		A6B40289.Text = "Đổi tên";
		A6B40289.Click += new System.EventHandler(A6B40289_Click);
		groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		groupBox3.Controls.Add(metroButton5);
		groupBox3.Controls.Add(AF2D1409);
		groupBox3.Controls.Add(E79842BD);
		groupBox3.Controls.Add(CC8AA819);
		groupBox3.Controls.Add(metroButton56);
		groupBox3.Controls.Add(E29B4909);
		groupBox3.Controls.Add(metroButton20);
		groupBox3.Controls.Add(metroButton28);
		groupBox3.Controls.Add(D43522B7);
		groupBox3.Controls.Add(metroButton27);
		groupBox3.Controls.Add(metroButton1);
		groupBox3.Controls.Add(metroButton15);
		groupBox3.Location = new System.Drawing.Point(626, 42);
		groupBox3.Name = "groupBox3";
		groupBox3.Size = new System.Drawing.Size(200, 462);
		groupBox3.TabIndex = 1;
		groupBox3.TabStop = false;
		groupBox3.Text = "Seeding";
		groupBox3.Enter += new System.EventHandler(groupBox3_Enter);
		metroButton5.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton5.Location = new System.Drawing.Point(14, 426);
		metroButton5.Name = "metroButton5";
		metroButton5.Size = new System.Drawing.Size(171, 26);
		metroButton5.TabIndex = 4;
		metroButton5.Text = "Đồng bộ danh bạ";
		metroButton5.Click += new System.EventHandler(metroButton5_Click);
		AF2D1409.Cursor = System.Windows.Forms.Cursors.Hand;
		AF2D1409.Location = new System.Drawing.Point(14, 368);
		AF2D1409.Name = "metroButton47";
		AF2D1409.Size = new System.Drawing.Size(171, 26);
		AF2D1409.TabIndex = 7;
		AF2D1409.Text = "Tương tác Reel chỉ định";
		AF2D1409.Click += new System.EventHandler(AF2D1409_Click);
		E79842BD.Image = Resource.Bitmap_175;
		E79842BD.Location = new System.Drawing.Point(14, 34);
		E79842BD.Name = "pictureBox6";
		E79842BD.Size = new System.Drawing.Size(171, 83);
		E79842BD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		E79842BD.TabIndex = 1;
		E79842BD.TabStop = false;
		CC8AA819.Cursor = System.Windows.Forms.Cursors.Hand;
		CC8AA819.Location = new System.Drawing.Point(14, 397);
		CC8AA819.Name = "button2";
		CC8AA819.Size = new System.Drawing.Size(171, 26);
		CC8AA819.TabIndex = 1;
		CC8AA819.Text = "Tương tác Reel từ khóa";
		CC8AA819.Click += new System.EventHandler(CC8AA819_Click);
		metroButton56.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton56.Location = new System.Drawing.Point(14, 223);
		metroButton56.Name = "metroButton56";
		metroButton56.Size = new System.Drawing.Size(171, 26);
		metroButton56.TabIndex = 1;
		metroButton56.Text = "Tương tác Ba\u0300i viê\u0301t từ khóa";
		metroButton56.Click += new System.EventHandler(D1A0878D);
		metroButton20.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton20.Location = new System.Drawing.Point(14, 194);
		metroButton20.Name = "metroButton20";
		metroButton20.Size = new System.Drawing.Size(171, 26);
		metroButton20.TabIndex = 6;
		metroButton20.Text = "Buff Follow UID";
		metroButton20.Click += new System.EventHandler(metroButton20_Click);
		metroButton28.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton28.Location = new System.Drawing.Point(14, 339);
		metroButton28.Name = "metroButton28";
		metroButton28.Size = new System.Drawing.Size(171, 26);
		metroButton28.TabIndex = 1;
		metroButton28.Text = "Mơ\u0300i ba\u0323n be\u0300 va\u0300o nho\u0301m";
		metroButton28.Click += new System.EventHandler(metroButton28_Click);
		metroButton27.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton27.Location = new System.Drawing.Point(14, 310);
		metroButton27.Name = "metroButton27";
		metroButton27.Size = new System.Drawing.Size(171, 26);
		metroButton27.TabIndex = 1;
		metroButton27.Text = "Mơ\u0300i ba\u0323n be\u0300 like page";
		metroButton27.Click += new System.EventHandler(metroButton27_Click);
		metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton1.Location = new System.Drawing.Point(14, 165);
		metroButton1.Name = "metroButton1";
		metroButton1.Size = new System.Drawing.Size(171, 26);
		metroButton1.TabIndex = 6;
		metroButton1.Text = "Buff Like Page";
		metroButton1.Click += new System.EventHandler(metroButton1_Click);
		metroButton15.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton15.Location = new System.Drawing.Point(14, 136);
		metroButton15.Name = "metroButton15";
		metroButton15.Size = new System.Drawing.Size(171, 26);
		metroButton15.TabIndex = 6;
		metroButton15.Text = "Đánh giá Page";
		metroButton15.Click += new System.EventHandler(metroButton15_Click);
		C52F3713.AutomaticDelay = 0;
		C52F3713.AutoPopDelay = 0;
		C52F3713.InitialDelay = 500;
		C52F3713.ReshowDelay = 0;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1042, 514);
		base.Controls.Add(E3394FB9);
		base.Controls.Add(DD29738D);
		base.Controls.Add(groupBox2);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fThemHanhDong";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fThemHanhDong_Load);
		A3BB0C91.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A985C488).EndInit();
		bunifuCards1.ResumeLayout(false);
		groupBox2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
		DD29738D.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
		E3394FB9.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
		panel1.ResumeLayout(false);
		A59954AA.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)D834E20B).EndInit();
		groupBox3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E79842BD).EndInit();
		ResumeLayout(false);
	}
}
