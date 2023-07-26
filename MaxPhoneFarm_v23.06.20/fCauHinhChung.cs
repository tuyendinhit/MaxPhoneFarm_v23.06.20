using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhChung : Form
{
	internal Dictionary<string, bool> E4870B9E = new Dictionary<string, bool>();

	internal string string_0 = "";

	internal IContainer A500F933 = null;

	internal BunifuCards bunifuCards1;

	internal Label AC3D3598;

	internal NumericUpDown EC086238;

	internal Label label6;

	internal Panel panel1;

	internal GroupBox D02CE704;

	internal GroupBox DC158F12;

	internal ComboBox cbbHostpot;

	internal Button button5;

	internal Panel D8B05C8D;

	internal Label label14;

	internal TextBox txtNordVPN;

	internal Button btnSSH;

	internal Label E816F606;

	internal Label label27;

	internal RadioButton DB21D419;

	internal RadioButton EAAE1628;

	internal NumericUpDown FB2C7495;

	internal RadioButton rbNordVPN;

	internal RadioButton B79E7F90;

	internal RadioButton rbDcom;

	internal RadioButton rbHma;

	internal BunifuDragControl C1B491B5;

	internal ToolTip C59DF58E;

	internal Button btnCancel;

	internal Button DB248F81;

	internal BunifuCards bunifuCards2;

	internal Panel pnlHeader;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button button2;

	internal Panel plTinsoft;

	internal ComboBox A51AE311;

	internal Label E239E097;

	internal Label A6A51D25;

	internal TextBox txtApiUser;

	internal Label F7B3919B;

	internal NumericUpDown nudLuongPerIPTinsoft;

	internal RadioButton rbTinsoft;

	internal Button button3;

	internal Panel panel2;

	internal Label label12;

	internal TextBox A821B6A8;

	internal RadioButton A5808136;

	internal RadioButton radioButton4;

	internal RadioButton D8BD4834;

	internal RadioButton C5BA703B;

	internal Panel A69C8A9A;

	internal Label D532E936;

	internal Label label13;

	internal TextBox txtServiceURLXProxy;

	internal RadioButton rbXproxy;

	internal RichTextBox txtListProxy;

	internal Panel E30BFE8A;

	internal RadioButton D7B048B6;

	internal Panel A908042A;

	internal RichTextBox txtApiKeyTMProxy;

	internal Label label24;

	internal Label label25;

	internal NumericUpDown BB07EF37;

	internal RadioButton rbTMProxy;

	internal GroupBox groupBox1;

	internal RadioButton rbPhanBietMauChu;

	internal RadioButton rbPhanBietMauNen;

	internal Label label23;

	internal LinkLabel linkLabel3;

	internal Panel plApiProxy;

	internal Label lblCountApiProxy;

	internal Label label28;

	internal TextBox D13B9598;

	internal Button D00D64B3;

	internal Panel D599320F;

	internal RadioButton BA85668E;

	internal RadioButton rbApiUser;

	internal CheckBox B2B88C33;

	internal CheckBox BFBAC297;

	internal Button button8;

	internal Panel C5B61B17;

	internal CheckBox ckbKhongCheckIP;

	internal RadioButton rbNone;

	internal Panel plDongBoMaxCare;

	internal Label D035FCBC;

	internal TextBox A4A18D89;

	internal CheckBox ckbDongBoMaxCare;

	internal Panel plDcom;

	internal Button button4;

	internal TextBox txtUrlHilink;

	internal TextBox txtProfileNameDcom;

	internal RadioButton FBA6D680;

	internal Label D2ABCC15;

	internal RadioButton rbDcomThuong;

	internal Panel B696502E;

	internal RichTextBox txtApiShopLike;

	internal Label label47;

	internal Label label48;

	internal NumericUpDown nudLuongPerIPShopLike;

	internal RadioButton rbShopLike;

	internal Panel BF84E596;

	internal RichTextBox txtListProxyv6;

	internal Label AAAE12A7;

	internal Label BD0D4690;

	internal NumericUpDown nudLuongPerIPProxyv6;

	internal Label label45;

	internal TextBox txtApiProxyv6;

	internal RadioButton B013D5A6;

	internal CheckBox ckbLuuTrangThai;

	internal Label label37;

	internal NumericUpDown A499EB0E;

	internal Label label38;

	internal Panel CFB60F91;

	internal Label DB81A52F;

	internal RadioButton rbObcResetDaiIP;

	internal RadioButton F49A4B22;

	internal RichTextBox txtListObcProxy;

	internal Label A08E4787;

	internal Label F52C1436;

	internal Label EF10790C;

	internal NumericUpDown nudLuongPerIPObcProxy;

	internal Label label39;

	internal Label label41;

	internal NumericUpDown nudDelayCheckIPObcProxy;

	internal TextBox txtLinkWebObcProxy;

	internal RadioButton BBABF381;

	internal TabControl tabChangeIP;

	internal TabPage tabDcom;

	internal TabPage E92DE81F;

	internal TabPage tabXProxy;

	internal TabPage DC9FCF2C;

	internal TabPage tabProxyV6;

	internal TabPage A7848002;

	internal TabPage tabTMProxy;

	internal TabPage FC84E1AE;

	internal Panel panel5;

	internal RadioButton rbMinProxy;

	internal TabPage AB344289;

	internal Panel C00C431C;

	internal Panel plTypeProxy;

	internal RadioButton rbHttpv6;

	internal RadioButton rbHttpv4;

	internal Label label56;

	internal RadioButton rbProxyDanCu;

	internal RadioButton rbProxyDong;

	internal Button button10;

	internal RichTextBox txtApiKeyMinProxy;

	internal Label label49;

	internal NumericUpDown nudLuongPerIPMinProxy;

	internal Label label42;

	internal RadioButton C49CCEB2;

	internal Label label2;

	internal Label B4B5BF08;

	internal NumericUpDown nudDelayConnectXproxy;

	internal CheckBox ckbTatADBKhiDungTool;

	internal CheckBox E694B48E;

	internal GroupBox groupBox4;

	internal Label CC04DC17;

	internal Panel plChangeDevice;

	internal Button A39228AE;

	internal TextBox txtBrandDevice;

	internal CheckBox ckbShowProxy;

	internal Label label4;

	internal CheckBox BB975F11;

	public fCauHinhChung()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	public fCauHinhChung(ref Dictionary<string, bool> B387D294)
	{
		InitializeComponent();
		E4870B9E = B387D294;
		Language.SetLanguage(this);
	}

	private void E08ACCB7()
	{
		Dictionary<string, string> dataSource = method_0();
		A51AE311.DataSource = new BindingSource(dataSource, null);
		A51AE311.ValueMember = "Key";
		A51AE311.DisplayMember = "Value";
	}

	public Dictionary<string, string> method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		List<string> list = SetupFolder.smethod_1();
		for (int i = 0; i < list.Count; i++)
		{
			string[] array = list[i].Split('|');
			dictionary.Add(array[0], array[1]);
		}
		return dictionary;
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fCauHinhChung_Load(object sender, EventArgs e)
	{
		E08ACCB7();
		EC086238.Value = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 5);
		ckbDongBoMaxCare.Checked = SettingsTool.GetSettings("configGeneral").AA824D29("ckbDongBoMaxCare");
		A4A18D89.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtPathMaxCare");
		if (ckbDongBoMaxCare.Checked)
		{
			string_0 = A4A18D89.Text;
		}
		else
		{
			string_0 = "";
		}
		txtBrandDevice.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtBrandDevice", "Random");
		E694B48E.Checked = SettingsTool.GetSettings("configGeneral").AA824D29("ckbKhongChangeDevice");
		BB975F11.Checked = SettingsTool.GetSettings("configGeneral").AA824D29("ckbRemoveAccountsInSettings");
		ckbKhongCheckIP.Checked = SettingsTool.GetSettings("configGeneral").AA824D29("ckbKhongCheckIP");
		FB2C7495.Value = Convert.ToInt32((SettingsTool.GetSettings("configGeneral").GetValue("ip_nudChangeIpCount") == "") ? "1" : SettingsTool.GetSettings("configGeneral").GetValue("ip_nudChangeIpCount"));
		A499EB0E.Value = SettingsTool.GetSettings("configGeneral").method_0("nudDelayCheckIP");
		switch (Convert.ToInt32((SettingsTool.GetSettings("configGeneral").GetValue("ip_iTypeChangeIp") == "") ? "0" : SettingsTool.GetSettings("configGeneral").GetValue("ip_iTypeChangeIp")))
		{
		case 0:
			rbNone.Checked = true;
			break;
		case 1:
			rbHma.Checked = true;
			break;
		case 2:
			rbDcom.Checked = true;
			break;
		case 3:
			DB21D419.Checked = true;
			break;
		case 4:
			EAAE1628.Checked = true;
			break;
		case 5:
			B79E7F90.Checked = true;
			break;
		case 6:
			rbNordVPN.Checked = true;
			break;
		case 7:
			rbTinsoft.Checked = true;
			break;
		case 8:
			rbXproxy.Checked = true;
			break;
		case 9:
			D7B048B6.Checked = true;
			break;
		case 10:
			rbTMProxy.Checked = true;
			break;
		case 11:
			B013D5A6.Checked = true;
			break;
		case 12:
			rbShopLike.Checked = true;
			break;
		case 13:
			rbMinProxy.Checked = true;
			break;
		case 14:
			BBABF381.Checked = true;
			break;
		case 15:
			C49CCEB2.Checked = true;
			break;
		}
		if (SettingsTool.GetSettings("configGeneral").method_0("typeDcom") == 0)
		{
			rbDcomThuong.Checked = true;
		}
		else
		{
			FBA6D680.Checked = true;
		}
		txtProfileNameDcom.Text = SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom");
		txtUrlHilink.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink", "http://192.168.1.1/html/home.html");
		txtNordVPN.Text = SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN");
		cbbHostpot.SelectedIndex = Convert.ToInt32((SettingsTool.GetSettings("configGeneral").GetValue("ip_cbbHostpot") == "") ? "0" : SettingsTool.GetSettings("configGeneral").GetValue("ip_cbbHostpot"));
		if (SettingsTool.GetSettings("configGeneral").method_0("typeApiTinsoft") == 0)
		{
			rbApiUser.Checked = true;
		}
		else
		{
			BA85668E.Checked = true;
		}
		txtApiUser.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiUser");
		D13B9598.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiProxy");
		A51AE311.SelectedValue = ((SettingsTool.GetSettings("configGeneral").GetValue("cbbLocationTinsoft") == "") ? "0" : SettingsTool.GetSettings("configGeneral").GetValue("cbbLocationTinsoft"));
		nudLuongPerIPTinsoft.Value = SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPTinsoft");
		B2B88C33.Checked = SettingsTool.GetSettings("configGeneral").AA824D29("ckbWaitDoneAllTinsoft");
		txtServiceURLXProxy.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtServiceURLXProxy");
		txtListProxy.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtListProxy");
		ckbShowProxy.Checked = SettingsTool.GetSettings("configGeneral").AA824D29("ckbShowProxy");
		nudDelayConnectXproxy.Value = SettingsTool.GetSettings("configGeneral").method_0("nudDelayConnectXproxy", 5);
		txtApiKeyTMProxy.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiKeyTMProxy");
		BB07EF37.Value = SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPTMProxy", 1);
		BFBAC297.Checked = SettingsTool.GetSettings("configGeneral").AA824D29("ckbWaitDoneAllTMProxy");
		txtApiProxyv6.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiProxyv6");
		txtListProxyv6.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtListProxyv6");
		nudLuongPerIPProxyv6.Value = SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPProxyv6", 1);
		txtApiShopLike.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiShopLike");
		nudLuongPerIPShopLike.Value = SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPShopLike", 1);
		if (SettingsTool.GetSettings("configGeneral").method_0("typeMin") == 0)
		{
			rbProxyDong.Checked = true;
		}
		else
		{
			rbProxyDanCu.Checked = true;
		}
		switch (SettingsTool.GetSettings("configGeneral").method_0("typeProxyMin"))
		{
		case 0:
			rbHttpv4.Checked = true;
			break;
		case 1:
			rbHttpv6.Checked = true;
			break;
		}
		txtApiKeyMinProxy.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtApiKeyMinProxy");
		nudLuongPerIPMinProxy.Value = SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPMinProxy");
		txtLinkWebObcProxy.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtLinkWebObcProxy");
		txtListObcProxy.Text = SettingsTool.GetSettings("configGeneral").GetValue("txtListObcProxy");
		nudLuongPerIPObcProxy.Value = SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPObcProxy", 1);
		if (SettingsTool.GetSettings("configGeneral").method_0("typeRunObcProxy") == 0)
		{
			F49A4B22.Checked = true;
		}
		else
		{
			rbObcResetDaiIP.Checked = true;
		}
		nudDelayCheckIPObcProxy.Value = SettingsTool.GetSettings("configGeneral").method_0("nudDelayCheckIPObcProxy", 1);
		if (SettingsTool.GetSettings("configGeneral").method_0("typePhanBietMau") == 0)
		{
			rbPhanBietMauNen.Checked = true;
		}
		else
		{
			rbPhanBietMauChu.Checked = true;
		}
		ckbLuuTrangThai.Checked = SettingsTool.GetSettings("configGeneral").AA824D29("ckbLuuTrangThai");
		ckbTatADBKhiDungTool.Checked = SettingsTool.GetSettings("configGeneral").AA824D29("ckbTatADBKhiDungTool");
		AC8A629E();
		F590058C();
	}

	private void F590058C()
	{
		D13B9598_TextChanged(null, null);
		txtListProxy_TextChanged(null, null);
		txtListObcProxy_TextChanged(null, null);
		txtApiKeyMinProxy_TextChanged(null, null);
		txtApiKeyTMProxy_TextChanged(null, null);
		A58ED52F(null, null);
		txtListProxyv6_TextChanged(null, null);
	}

	private void DB248F81_Click(object sender, EventArgs e)
	{
		try
		{
			SettingsTool.GetSettings("configGeneral").GetValue("nudHideThread", EC086238.Value);
			SettingsTool.GetSettings("configGeneral").GetValue("ckbDongBoMaxCare", ckbDongBoMaxCare.Checked);
			string text = A4A18D89.Text.Trim();
			if (ckbDongBoMaxCare.Checked && !File.Exists(text + "\\database\\db_maxcare.sqlite"))
			{
				MessageBoxHelper.Show("Đươ\u0300ng dâ\u0303n MaxCare không hơ\u0323p lê\u0323!", 3);
				return;
			}
            SettingsTool.GetSettings("configGeneral").GetValue("txtPathMaxCare", (object)text);
			if (!ckbDongBoMaxCare.Checked)
			{
				text = "";
			}
            SettingsTool.GetSettings("configGeneral").GetValue("txtBrandDevice", (object)txtBrandDevice.Text);
			SettingsTool.GetSettings("configGeneral").GetValue("ckbKhongChangeDevice", E694B48E.Checked);
			SettingsTool.GetSettings("configGeneral").GetValue("ckbRemoveAccountsInSettings", BB975F11.Checked);
			SettingsTool.GetSettings("configGeneral").GetValue("ckbKhongCheckIP", ckbKhongCheckIP.Checked);
			SettingsTool.GetSettings("configGeneral").GetValue("ip_nudChangeIpCount", FB2C7495.Value);
			SettingsTool.GetSettings("configGeneral").GetValue("nudDelayCheckIP", A499EB0E.Value);
			int num = 0;
			if (rbNone.Checked)
			{
				num = 0;
			}
			else if (rbHma.Checked)
			{
				num = 1;
			}
			else if (rbDcom.Checked)
			{
				num = 2;
			}
			else if (DB21D419.Checked)
			{
				num = 3;
			}
			else if (EAAE1628.Checked)
			{
				num = 4;
			}
			else if (B79E7F90.Checked)
			{
				num = 5;
			}
			else if (rbNordVPN.Checked)
			{
				num = 6;
			}
			else if (rbTinsoft.Checked)
			{
				num = 7;
			}
			else if (rbXproxy.Checked)
			{
				num = 8;
			}
			else if (D7B048B6.Checked)
			{
				num = 9;
			}
			else if (rbTMProxy.Checked)
			{
				num = 10;
			}
			else if (B013D5A6.Checked)
			{
				num = 11;
			}
			else if (rbShopLike.Checked)
			{
				num = 12;
			}
			else if (rbMinProxy.Checked)
			{
				num = 13;
			}
			else if (BBABF381.Checked)
			{
				num = 14;
			}
			else if (C49CCEB2.Checked)
			{
				num = 15;
			}
			SettingsTool.GetSettings("configGeneral").GetValue("ip_iTypeChangeIp", num);
			if (rbDcomThuong.Checked)
			{
				SettingsTool.GetSettings("configGeneral").GetValue("typeDcom", 0);
			}
			else
			{
				SettingsTool.GetSettings("configGeneral").GetValue("typeDcom", 1);
			}
            SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink", (object)txtUrlHilink.Text);
            SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom", (object)txtProfileNameDcom.Text);
            SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN", (object)txtNordVPN.Text);
			SettingsTool.GetSettings("configGeneral").GetValue("ip_cbbHostpot", cbbHostpot.SelectedIndex);
			if (rbApiUser.Checked)
			{
				SettingsTool.GetSettings("configGeneral").GetValue("typeApiTinsoft", 0);
			}
			else
			{
				SettingsTool.GetSettings("configGeneral").GetValue("typeApiTinsoft", 1);
			}
            SettingsTool.GetSettings("configGeneral").GetValue("txtApiUser", (object)txtApiUser.Text);
            SettingsTool.GetSettings("configGeneral").GetValue("txtApiProxy", (object)D13B9598.Text);
			SettingsTool.GetSettings("configGeneral").GetValue("cbbLocationTinsoft", A51AE311.SelectedValue);
			SettingsTool.GetSettings("configGeneral").GetValue("nudLuongPerIPTinsoft", nudLuongPerIPTinsoft.Value);
			SettingsTool.GetSettings("configGeneral").GetValue("ckbWaitDoneAllTinsoft", B2B88C33.Checked);
            SettingsTool.GetSettings("configGeneral").GetValue("txtServiceURLXProxy", (object)txtServiceURLXProxy.Text);
            SettingsTool.GetSettings("configGeneral").GetValue("txtListProxy", (object)txtListProxy.Text);
			SettingsTool.GetSettings("configGeneral").GetValue("ckbShowProxy", ckbShowProxy.Checked);
			SettingsTool.GetSettings("configGeneral").GetValue("nudDelayConnectXproxy", nudDelayConnectXproxy.Value);
            SettingsTool.GetSettings("configGeneral").GetValue("txtApiKeyTMProxy", (object)txtApiKeyTMProxy.Text);
			SettingsTool.GetSettings("configGeneral").GetValue("nudLuongPerIPTMProxy", BB07EF37.Value);
			SettingsTool.GetSettings("configGeneral").GetValue("ckbWaitDoneAllTMProxy", BFBAC297.Checked);
            SettingsTool.GetSettings("configGeneral").GetValue("txtApiProxyv6", (object)txtApiProxyv6.Text);
            SettingsTool.GetSettings("configGeneral").GetValue("txtListProxyv6", (object)txtListProxyv6.Text);
			SettingsTool.GetSettings("configGeneral").GetValue("nudLuongPerIPProxyv6", nudLuongPerIPProxyv6.Value);
            SettingsTool.GetSettings("configGeneral").GetValue("txtApiShopLike", (object)txtApiShopLike.Text);
			SettingsTool.GetSettings("configGeneral").GetValue("nudLuongPerIPShopLike", nudLuongPerIPShopLike.Value);
			int num2 = 0;
			if (rbProxyDanCu.Checked)
			{
				num2 = 1;
			}
			SettingsTool.GetSettings("configGeneral").GetValue("typeMin", num2);
			int num3 = 0;
			if (rbHttpv6.Checked)
			{
				num3 = 1;
			}
			SettingsTool.GetSettings("configGeneral").GetValue("typeProxyMin", num3);
            SettingsTool.GetSettings("configGeneral").GetValue("txtApiKeyMinProxy", (object)txtApiKeyMinProxy.Text);
			SettingsTool.GetSettings("configGeneral").GetValue("nudLuongPerIPMinProxy", nudLuongPerIPMinProxy.Value);
            SettingsTool.GetSettings("configGeneral").GetValue("txtLinkWebObcProxy", (object)txtLinkWebObcProxy.Text);
            SettingsTool.GetSettings("configGeneral").GetValue("txtListObcProxy", (object)txtListObcProxy.Text);
			SettingsTool.GetSettings("configGeneral").GetValue("nudLuongPerIPObcProxy", nudLuongPerIPObcProxy.Value);
			if (F49A4B22.Checked)
			{
				SettingsTool.GetSettings("configGeneral").GetValue("typeRunObcProxy", 0);
			}
			else
			{
				SettingsTool.GetSettings("configGeneral").GetValue("typeRunObcProxy", 1);
			}
			SettingsTool.GetSettings("configGeneral").GetValue("nudDelayCheckIPObcProxy", nudDelayCheckIPObcProxy.Value);
			if (rbPhanBietMauNen.Checked)
			{
				SettingsTool.GetSettings("configGeneral").GetValue("typePhanBietMau", 0);
			}
			else
			{
				SettingsTool.GetSettings("configGeneral").GetValue("typePhanBietMau", 1);
			}
			SettingsTool.GetSettings("configGeneral").GetValue("ckbLuuTrangThai", ckbLuuTrangThai.Checked);
			SettingsTool.GetSettings("configGeneral").GetValue("ckbTatADBKhiDungTool", ckbTatADBKhiDungTool.Checked);
			UpdateStatus.isSaveSettings = ckbLuuTrangThai.Checked;
			SettingsTool.smethod_0("configGeneral");
			if (MessageBoxHelper.smethod_1(Language.GetValue("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?")) == DialogResult.Yes)
			{
				Close();
			}
			if (string_0 != text)
			{
				Base.string_2 = Base.BD8E591F();
				E4870B9E["isChangePathDatabase"] = true;
			}
		}
		catch
		{
			MessageBoxHelper.Show(Language.GetValue("Lỗi!"));
		}
	}

	private void EA9C3D9A(object sender, EventArgs e)
	{
		if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn loại đổi IP"), 3);
		}
		else if (Common.smethod_44(SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp"), SettingsTool.GetSettings("configGeneral").method_0("typeDcom"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom"), SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink"), SettingsTool.GetSettings("configGeneral").method_0("ip_cbbHostpot"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN")))
		{
			MessageBoxHelper.Show(Language.GetValue("Đổi IP thành công!"));
		}
		else
		{
			MessageBoxHelper.Show(Language.GetValue("Đổi IP thất bại!"), 2);
		}
	}

	private void btnSSH_Click(object sender, EventArgs e)
	{
		Process.Start("changeip\\ssh.txt");
	}

	private void method_1(object sender, EventArgs e)
	{
		if (!GClass12.E18E0CBD())
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lòng cập nhật chromedriver!"), 3);
		}
		else
		{
			MessageBoxHelper.Show(Language.GetValue("Phiên bản chromedriver khả dụng!"));
		}
	}

	private void EA20E199(object sender, EventArgs e)
	{
		plTinsoft.Enabled = rbTinsoft.Checked;
		method_2(rbTinsoft);
	}

	private void D8BD4834_CheckedChanged(object sender, EventArgs e)
	{
		panel2.Enabled = rbNordVPN.Checked;
	}

	private void AC8A629E()
	{
		method_4(null, null);
		method_5(null, null);
		method_6(null, null);
		EA20E199(null, null);
		D8BD4834_CheckedChanged(null, null);
		E2A8C61E(null, null);
		D70AEC3E(null, null);
		CC838B1F(null, null);
		CBB2F013(null, null);
		rbApiUser_CheckedChanged(null, null);
		B394661E(null, null);
		D10E8000(null, null);
		A1116010(null, null);
		rbShopLike_CheckedChanged(null, null);
		method_8(null, null);
		BBABF381_CheckedChanged(null, null);
		rbDcomThuong_CheckedChanged(null, null);
		AC898311(null, null);
		rbMinProxy_CheckedChanged(null, null);
		CDAE55AD(null, null);
		D7B048B6_CheckedChanged(null, null);
		rbProxyDanCu_CheckedChanged(null, null);
		C49CCEB2_CheckedChanged(null, null);
	}

	private void button3_Click(object sender, EventArgs e)
	{
		string dD15C73C = txtApiUser.Text.Trim();
		List<string> list = A4AF3582.E213E5B4(dD15C73C);
		if (list.Count > 0)
		{
			MessageBoxHelper.Show(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			MessageBoxHelper.Show(Language.GetValue("Không có proxy khả dụng!"), 2);
		}
	}

	private void E2A8C61E(object sender, EventArgs e)
	{
		plDcom.Enabled = rbDcom.Checked;
		B2A535BC();
		method_2(rbDcom);
	}

	private void method_2(RadioButton radioButton_0)
	{
		if (radioButton_0 != null && radioButton_0.Checked)
		{
			if (radioButton_0.Name == rbDcom.Name)
			{
				tabChangeIP.SelectedTab = tabDcom;
			}
			else if (radioButton_0.Name == rbXproxy.Name)
			{
				tabChangeIP.SelectedTab = tabXProxy;
			}
			else if (radioButton_0.Name == rbTinsoft.Name)
			{
				tabChangeIP.SelectedTab = E92DE81F;
			}
			else if (radioButton_0.Name == rbTMProxy.Name)
			{
				tabChangeIP.SelectedTab = tabTMProxy;
			}
			else if (radioButton_0.Name == BBABF381.Name)
			{
				tabChangeIP.SelectedTab = DC9FCF2C;
			}
			else if (radioButton_0.Name == B013D5A6.Name)
			{
				tabChangeIP.SelectedTab = tabProxyV6;
			}
			else if (radioButton_0.Name == rbShopLike.Name)
			{
				tabChangeIP.SelectedTab = A7848002;
			}
			else if (radioButton_0.Name == rbMinProxy.Name)
			{
				tabChangeIP.SelectedTab = AB344289;
			}
			else
			{
				tabChangeIP.SelectedTab = FC84E1AE;
			}
		}
	}

	private void D70AEC3E(object sender, EventArgs e)
	{
		A69C8A9A.Enabled = rbXproxy.Checked;
		method_2(rbXproxy);
	}

	private void B2A535BC()
	{
		E30BFE8A.Enabled = rbDcom.Checked || rbHma.Checked;
	}

	private void CC838B1F(object sender, EventArgs e)
	{
		B2A535BC();
		method_2(rbHma);
	}

	private void button4_Click(object sender, EventArgs e)
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("rasdial.exe")
			{
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			};
			Process process = Process.Start(startInfo);
			string text = process.StandardOutput.ReadToEnd();
			if (text.Split('\n').Length <= 3)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng kết nối Dcom trước!"), 2);
				return;
			}
			txtProfileNameDcom.Text = text.Split('\n').ToList()[1];
			MessageBoxHelper.Show(Language.GetValue("Lấy tên cấu hình Dcom thành công!"));
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "change ip dcom");
			MessageBoxHelper.Show(Language.GetValue("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void CBB2F013(object sender, EventArgs e)
	{
		A908042A.Enabled = rbTMProxy.Checked;
		method_2(rbTMProxy);
	}

	private void method_3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("https://youtu.be/eexEDCyPbR8");
		}
		catch
		{
		}
	}

	private void D13B9598_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = D13B9598.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblCountApiProxy.Text = "(" + f1808BA.Count + ")";
		}
		catch
		{
		}
	}

	private void rbApiUser_CheckedChanged(object sender, EventArgs e)
	{
		D599320F.Enabled = rbApiUser.Checked;
	}

	private void B394661E(object sender, EventArgs e)
	{
		plApiProxy.Enabled = BA85668E.Checked;
	}

	private void A5A15003(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> f1808BA = D13B9598.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		foreach (string item in f1808BA)
		{
			if (A4AF3582.smethod_0(item))
			{
				list.Add(item);
			}
		}
		D13B9598.Lines = list.ToArray();
		if (list.Count > 0)
		{
			MessageBoxHelper.Show(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			MessageBoxHelper.Show(Language.GetValue("Không có proxy khả dụng!"), 2);
		}
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("https://www.youtube.com/watch?v=XZTveKk-utY");
		}
		catch
		{
		}
	}

	private void CFB60F91_Click(object sender, EventArgs e)
	{
	}

	private void plTinsoft_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			B2B88C33.Visible = true;
		}
	}

	private void BC8FC2B6(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			BFBAC297.Visible = true;
		}
	}

	private void C61CAAA1(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> f1808BA = txtApiKeyTMProxy.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		foreach (string item in f1808BA)
		{
			if (Class27.smethod_0(item))
			{
				list.Add(item);
			}
		}
		txtApiKeyTMProxy.Lines = list.ToArray();
		if (list.Count > 0)
		{
			MessageBoxHelper.Show(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			MessageBoxHelper.Show(Language.GetValue("Không có proxy khả dụng!"), 2);
		}
	}

	private void txtApiKeyTMProxy_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtApiKeyTMProxy.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			label24.Text = string.Format(Language.GetValue("Nhập API KEY ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtListProxy_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtListProxy, D532E936);
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void method_6(object sender, EventArgs e)
	{
	}

	private void D10E8000(object sender, EventArgs e)
	{
		plDongBoMaxCare.Enabled = ckbDongBoMaxCare.Checked;
	}

	private void rbDcomThuong_CheckedChanged(object sender, EventArgs e)
	{
		button4.Enabled = rbDcomThuong.Checked;
		txtProfileNameDcom.Enabled = rbDcomThuong.Checked;
	}

	private void AC898311(object sender, EventArgs e)
	{
		txtUrlHilink.Enabled = FBA6D680.Checked;
		D2ABCC15.Enabled = FBA6D680.Checked;
	}

	private void A58ED52F(object sender, EventArgs e)
	{
		List<string> f1808BA = txtApiShopLike.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		label47.Text = string.Format(Language.GetValue("Nhập API KEY ({0}):"), f1808BA.Count.ToString());
	}

	private void txtListProxyv6_TextChanged(object sender, EventArgs e)
	{
		List<string> f1808BA = txtListProxyv6.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		AAAE12A7.Text = string.Format(Language.GetValue("Nhập Proxy ({0}):"), f1808BA.Count.ToString());
	}

	private void rbShopLike_CheckedChanged(object sender, EventArgs e)
	{
		B696502E.Enabled = rbShopLike.Checked;
		method_2(rbShopLike);
	}

	private void A1116010(object sender, EventArgs e)
	{
		BF84E596.Enabled = B013D5A6.Checked;
		method_2(B013D5A6);
	}

	private void C73F9680(object sender, EventArgs e)
	{
	}

	private void method_7(object sender, EventArgs e)
	{
		if (A69C8A9A.Height == 242)
		{
			A69C8A9A.Height = 170;
			(sender as Button).BackgroundImage = Resource.Bitmap_91;
		}
		else
		{
			A69C8A9A.Height = 242;
			(sender as Button).BackgroundImage = Resource.Bitmap_73;
		}
	}

	private void method_8(object sender, EventArgs e)
	{
	}

	private void txtListObcProxy_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtListObcProxy, A08E4787);
	}

	private void BBABF381_CheckedChanged(object sender, EventArgs e)
	{
		CFB60F91.Enabled = BBABF381.Checked;
		method_2(BBABF381);
	}

	private void CDAE55AD(object sender, EventArgs e)
	{
		method_2(rbNone);
	}

	private void D7B048B6_CheckedChanged(object sender, EventArgs e)
	{
		method_2(D7B048B6);
	}

	private void rbMinProxy_CheckedChanged(object sender, EventArgs e)
	{
		panel5.Enabled = rbMinProxy.Checked;
		method_2(rbMinProxy);
	}

	private void txtApiKeyMinProxy_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtApiKeyMinProxy, label49);
	}

	private void EA10699A(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> f1808BA = txtApiKeyMinProxy.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		int int_ = 0;
		if (rbProxyDanCu.Checked)
		{
			int_ = 1;
		}
		foreach (string item in f1808BA)
		{
			if (Class4.smethod_0(int_, item))
			{
				list.Add(item);
			}
		}
		txtApiKeyMinProxy.Lines = list.ToArray();
		if (list.Count > 0)
		{
			MessageBoxHelper.Show(string.Format(Language.GetValue("Đang có {0} proxy khả dụng!"), list.Count));
		}
		else
		{
			MessageBoxHelper.Show(Language.GetValue("Không có proxy khả dụng!"), 2);
		}
	}

	private void rbProxyDanCu_CheckedChanged(object sender, EventArgs e)
	{
		plTypeProxy.Enabled = rbProxyDanCu.Checked;
	}

	private void C49CCEB2_CheckedChanged(object sender, EventArgs e)
	{
		method_2(C49CCEB2);
	}

	private void ckbShowProxy_CheckedChanged(object sender, EventArgs e)
	{
		plChangeDevice.Enabled = !E694B48E.Checked;
	}

	private void D1AE8FBC(object sender, EventArgs e)
	{
		List<string> d5016B1F = txtBrandDevice.Text.Split('|').ToList();
		fChonBrandDevice fChonBrandDevice2 = new fChonBrandDevice(d5016B1F);
		fChonBrandDevice2.ShowDialog();
		if (fChonBrandDevice2.list_0.Count == 0)
		{
			txtBrandDevice.Text = "Random";
		}
		else
		{
			txtBrandDevice.Text = string.Join("|", fChonBrandDevice2.list_0);
		}
	}

	private void txtBrandDevice_TextChanged(object sender, EventArgs e)
	{
		Common.DB181F2D(CC04DC17, txtBrandDevice.Text.Split('|').Length);
	}

	protected override void Dispose(bool C2B0C2BF)
	{
		if (C2B0C2BF && A500F933 != null)
		{
			A500F933.Dispose();
		}
		base.Dispose(C2B0C2BF);
	}

	private void InitializeComponent()
	{
		A500F933 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhChung));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		AC3D3598 = new System.Windows.Forms.Label();
		EC086238 = new System.Windows.Forms.NumericUpDown();
		label6 = new System.Windows.Forms.Label();
		panel1 = new System.Windows.Forms.Panel();
		groupBox4 = new System.Windows.Forms.GroupBox();
		plChangeDevice = new System.Windows.Forms.Panel();
		A39228AE = new System.Windows.Forms.Button();
		txtBrandDevice = new System.Windows.Forms.TextBox();
		CC04DC17 = new System.Windows.Forms.Label();
		E694B48E = new System.Windows.Forms.CheckBox();
		label37 = new System.Windows.Forms.Label();
		rbMinProxy = new System.Windows.Forms.RadioButton();
		cbbHostpot = new System.Windows.Forms.ComboBox();
		E30BFE8A = new System.Windows.Forms.Panel();
		button5 = new System.Windows.Forms.Button();
		E816F606 = new System.Windows.Forms.Label();
		FB2C7495 = new System.Windows.Forms.NumericUpDown();
		label27 = new System.Windows.Forms.Label();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		panel2 = new System.Windows.Forms.Panel();
		label12 = new System.Windows.Forms.Label();
		A821B6A8 = new System.Windows.Forms.TextBox();
		DB248F81 = new System.Windows.Forms.Button();
		rbShopLike = new System.Windows.Forms.RadioButton();
		BBABF381 = new System.Windows.Forms.RadioButton();
		D8B05C8D = new System.Windows.Forms.Panel();
		label14 = new System.Windows.Forms.Label();
		txtNordVPN = new System.Windows.Forms.TextBox();
		B013D5A6 = new System.Windows.Forms.RadioButton();
		groupBox1 = new System.Windows.Forms.GroupBox();
		C5B61B17 = new System.Windows.Forms.Panel();
		rbPhanBietMauNen = new System.Windows.Forms.RadioButton();
		rbPhanBietMauChu = new System.Windows.Forms.RadioButton();
		label23 = new System.Windows.Forms.Label();
		linkLabel3 = new System.Windows.Forms.LinkLabel();
		D02CE704 = new System.Windows.Forms.GroupBox();
		plDongBoMaxCare = new System.Windows.Forms.Panel();
		D035FCBC = new System.Windows.Forms.Label();
		A4A18D89 = new System.Windows.Forms.TextBox();
		ckbDongBoMaxCare = new System.Windows.Forms.CheckBox();
		ckbTatADBKhiDungTool = new System.Windows.Forms.CheckBox();
		ckbLuuTrangThai = new System.Windows.Forms.CheckBox();
		btnSSH = new System.Windows.Forms.Button();
		rbTMProxy = new System.Windows.Forms.RadioButton();
		radioButton4 = new System.Windows.Forms.RadioButton();
		rbDcom = new System.Windows.Forms.RadioButton();
		rbTinsoft = new System.Windows.Forms.RadioButton();
		B79E7F90 = new System.Windows.Forms.RadioButton();
		A5808136 = new System.Windows.Forms.RadioButton();
		rbNordVPN = new System.Windows.Forms.RadioButton();
		C5BA703B = new System.Windows.Forms.RadioButton();
		DB21D419 = new System.Windows.Forms.RadioButton();
		rbHma = new System.Windows.Forms.RadioButton();
		D8BD4834 = new System.Windows.Forms.RadioButton();
		EAAE1628 = new System.Windows.Forms.RadioButton();
		DC158F12 = new System.Windows.Forms.GroupBox();
		A499EB0E = new System.Windows.Forms.NumericUpDown();
		label38 = new System.Windows.Forms.Label();
		C49CCEB2 = new System.Windows.Forms.RadioButton();
		tabChangeIP = new System.Windows.Forms.TabControl();
		tabDcom = new System.Windows.Forms.TabPage();
		plDcom = new System.Windows.Forms.Panel();
		button4 = new System.Windows.Forms.Button();
		txtUrlHilink = new System.Windows.Forms.TextBox();
		txtProfileNameDcom = new System.Windows.Forms.TextBox();
		FBA6D680 = new System.Windows.Forms.RadioButton();
		D2ABCC15 = new System.Windows.Forms.Label();
		rbDcomThuong = new System.Windows.Forms.RadioButton();
		E92DE81F = new System.Windows.Forms.TabPage();
		plTinsoft = new System.Windows.Forms.Panel();
		B2B88C33 = new System.Windows.Forms.CheckBox();
		plApiProxy = new System.Windows.Forms.Panel();
		lblCountApiProxy = new System.Windows.Forms.Label();
		label28 = new System.Windows.Forms.Label();
		D13B9598 = new System.Windows.Forms.TextBox();
		D00D64B3 = new System.Windows.Forms.Button();
		D599320F = new System.Windows.Forms.Panel();
		A6A51D25 = new System.Windows.Forms.Label();
		txtApiUser = new System.Windows.Forms.TextBox();
		button3 = new System.Windows.Forms.Button();
		A51AE311 = new System.Windows.Forms.ComboBox();
		BA85668E = new System.Windows.Forms.RadioButton();
		rbApiUser = new System.Windows.Forms.RadioButton();
		E239E097 = new System.Windows.Forms.Label();
		F7B3919B = new System.Windows.Forms.Label();
		nudLuongPerIPTinsoft = new System.Windows.Forms.NumericUpDown();
		tabXProxy = new System.Windows.Forms.TabPage();
		A69C8A9A = new System.Windows.Forms.Panel();
		B4B5BF08 = new System.Windows.Forms.Label();
		ckbShowProxy = new System.Windows.Forms.CheckBox();
		nudDelayConnectXproxy = new System.Windows.Forms.NumericUpDown();
		label4 = new System.Windows.Forms.Label();
		txtListProxy = new System.Windows.Forms.RichTextBox();
		D532E936 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label13 = new System.Windows.Forms.Label();
		txtServiceURLXProxy = new System.Windows.Forms.TextBox();
		DC9FCF2C = new System.Windows.Forms.TabPage();
		CFB60F91 = new System.Windows.Forms.Panel();
		DB81A52F = new System.Windows.Forms.Label();
		rbObcResetDaiIP = new System.Windows.Forms.RadioButton();
		F49A4B22 = new System.Windows.Forms.RadioButton();
		txtListObcProxy = new System.Windows.Forms.RichTextBox();
		A08E4787 = new System.Windows.Forms.Label();
		F52C1436 = new System.Windows.Forms.Label();
		EF10790C = new System.Windows.Forms.Label();
		nudLuongPerIPObcProxy = new System.Windows.Forms.NumericUpDown();
		label39 = new System.Windows.Forms.Label();
		label41 = new System.Windows.Forms.Label();
		nudDelayCheckIPObcProxy = new System.Windows.Forms.NumericUpDown();
		txtLinkWebObcProxy = new System.Windows.Forms.TextBox();
		tabProxyV6 = new System.Windows.Forms.TabPage();
		BF84E596 = new System.Windows.Forms.Panel();
		txtListProxyv6 = new System.Windows.Forms.RichTextBox();
		AAAE12A7 = new System.Windows.Forms.Label();
		BD0D4690 = new System.Windows.Forms.Label();
		nudLuongPerIPProxyv6 = new System.Windows.Forms.NumericUpDown();
		label45 = new System.Windows.Forms.Label();
		txtApiProxyv6 = new System.Windows.Forms.TextBox();
		A7848002 = new System.Windows.Forms.TabPage();
		B696502E = new System.Windows.Forms.Panel();
		txtApiShopLike = new System.Windows.Forms.RichTextBox();
		label47 = new System.Windows.Forms.Label();
		label48 = new System.Windows.Forms.Label();
		nudLuongPerIPShopLike = new System.Windows.Forms.NumericUpDown();
		tabTMProxy = new System.Windows.Forms.TabPage();
		A908042A = new System.Windows.Forms.Panel();
		BFBAC297 = new System.Windows.Forms.CheckBox();
		txtApiKeyTMProxy = new System.Windows.Forms.RichTextBox();
		label24 = new System.Windows.Forms.Label();
		button8 = new System.Windows.Forms.Button();
		label25 = new System.Windows.Forms.Label();
		BB07EF37 = new System.Windows.Forms.NumericUpDown();
		FC84E1AE = new System.Windows.Forms.TabPage();
		panel5 = new System.Windows.Forms.Panel();
		AB344289 = new System.Windows.Forms.TabPage();
		C00C431C = new System.Windows.Forms.Panel();
		label42 = new System.Windows.Forms.Label();
		plTypeProxy = new System.Windows.Forms.Panel();
		rbHttpv6 = new System.Windows.Forms.RadioButton();
		rbHttpv4 = new System.Windows.Forms.RadioButton();
		label56 = new System.Windows.Forms.Label();
		rbProxyDanCu = new System.Windows.Forms.RadioButton();
		rbProxyDong = new System.Windows.Forms.RadioButton();
		button10 = new System.Windows.Forms.Button();
		txtApiKeyMinProxy = new System.Windows.Forms.RichTextBox();
		label49 = new System.Windows.Forms.Label();
		nudLuongPerIPMinProxy = new System.Windows.Forms.NumericUpDown();
		D7B048B6 = new System.Windows.Forms.RadioButton();
		rbNone = new System.Windows.Forms.RadioButton();
		ckbKhongCheckIP = new System.Windows.Forms.CheckBox();
		rbXproxy = new System.Windows.Forms.RadioButton();
		C1B491B5 = new Bunifu.Framework.UI.BunifuDragControl(A500F933);
		C59DF58E = new System.Windows.Forms.ToolTip(A500F933);
		BB975F11 = new System.Windows.Forms.CheckBox();
		((System.ComponentModel.ISupportInitialize)EC086238).BeginInit();
		panel1.SuspendLayout();
		groupBox4.SuspendLayout();
		plChangeDevice.SuspendLayout();
		E30BFE8A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FB2C7495).BeginInit();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel2.SuspendLayout();
		D8B05C8D.SuspendLayout();
		groupBox1.SuspendLayout();
		C5B61B17.SuspendLayout();
		D02CE704.SuspendLayout();
		plDongBoMaxCare.SuspendLayout();
		DC158F12.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A499EB0E).BeginInit();
		tabChangeIP.SuspendLayout();
		tabDcom.SuspendLayout();
		plDcom.SuspendLayout();
		E92DE81F.SuspendLayout();
		plTinsoft.SuspendLayout();
		plApiProxy.SuspendLayout();
		D599320F.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPTinsoft).BeginInit();
		tabXProxy.SuspendLayout();
		A69C8A9A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayConnectXproxy).BeginInit();
		DC9FCF2C.SuspendLayout();
		CFB60F91.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPObcProxy).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayCheckIPObcProxy).BeginInit();
		tabProxyV6.SuspendLayout();
		BF84E596.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPProxyv6).BeginInit();
		A7848002.SuspendLayout();
		B696502E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPShopLike).BeginInit();
		tabTMProxy.SuspendLayout();
		A908042A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BB07EF37).BeginInit();
		FC84E1AE.SuspendLayout();
		AB344289.SuspendLayout();
		C00C431C.SuspendLayout();
		plTypeProxy.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPMinProxy).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(14, 38);
		bunifuCards1.TabIndex = 12;
		AC3D3598.AutoSize = true;
		AC3D3598.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		AC3D3598.Location = new System.Drawing.Point(245, 76);
		AC3D3598.Name = "label5";
		AC3D3598.Size = new System.Drawing.Size(41, 16);
		AC3D3598.TabIndex = 28;
		AC3D3598.Text = "Luồng";
		EC086238.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EC086238.Location = new System.Drawing.Point(186, 74);
		EC086238.Maximum = new decimal(new int[4] { 1410065407, 2, 0, 0 });
		EC086238.Name = "nudHideThread";
		EC086238.Size = new System.Drawing.Size(56, 23);
		EC086238.TabIndex = 27;
		label6.AutoSize = true;
		label6.Cursor = System.Windows.Forms.Cursors.Help;
		label6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label6.Location = new System.Drawing.Point(18, 76);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(152, 16);
		label6.TabIndex = 26;
		label6.Text = "Số luồng check thông tin:";
		C59DF58E.SetToolTip(label6, "La\u0300 sô\u0301 luô\u0300ng khi cha\u0323y ca\u0301c chư\u0301c năng không liên quan gi\u0300 đê\u0301n tri\u0300nh duyê\u0323t.\r\nVi\u0301 du\u0323 như: Check wall, Check Avatar,...\r\n(Khuyê\u0301n ca\u0301o nên đê\u0309 10 luô\u0300ng)");
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(groupBox4);
		panel1.Controls.Add(label37);
		panel1.Controls.Add(rbMinProxy);
		panel1.Controls.Add(cbbHostpot);
		panel1.Controls.Add(E30BFE8A);
		panel1.Controls.Add(bunifuCards2);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(DB248F81);
		panel1.Controls.Add(rbShopLike);
		panel1.Controls.Add(BBABF381);
		panel1.Controls.Add(D8B05C8D);
		panel1.Controls.Add(B013D5A6);
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(linkLabel3);
		panel1.Controls.Add(D02CE704);
		panel1.Controls.Add(btnSSH);
		panel1.Controls.Add(rbTMProxy);
		panel1.Controls.Add(radioButton4);
		panel1.Controls.Add(rbDcom);
		panel1.Controls.Add(rbTinsoft);
		panel1.Controls.Add(B79E7F90);
		panel1.Controls.Add(A5808136);
		panel1.Controls.Add(rbNordVPN);
		panel1.Controls.Add(C5BA703B);
		panel1.Controls.Add(DB21D419);
		panel1.Controls.Add(rbHma);
		panel1.Controls.Add(D8BD4834);
		panel1.Controls.Add(EAAE1628);
		panel1.Controls.Add(DC158F12);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(551, 654);
		panel1.TabIndex = 37;
		groupBox4.Controls.Add(plChangeDevice);
		groupBox4.Controls.Add(BB975F11);
		groupBox4.Controls.Add(E694B48E);
		groupBox4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		groupBox4.Location = new System.Drawing.Point(7, 176);
		groupBox4.Name = "groupBox4";
		groupBox4.Size = new System.Drawing.Size(536, 77);
		groupBox4.TabIndex = 162;
		groupBox4.TabStop = false;
		groupBox4.Text = "Cấu hình change device";
		plChangeDevice.Controls.Add(A39228AE);
		plChangeDevice.Controls.Add(txtBrandDevice);
		plChangeDevice.Controls.Add(CC04DC17);
		plChangeDevice.Location = new System.Drawing.Point(17, 22);
		plChangeDevice.Name = "plChangeDevice";
		plChangeDevice.Size = new System.Drawing.Size(495, 28);
		plChangeDevice.TabIndex = 116;
		A39228AE.Cursor = System.Windows.Forms.Cursors.Hand;
		A39228AE.Location = new System.Drawing.Point(423, 1);
		A39228AE.Name = "button1";
		A39228AE.Size = new System.Drawing.Size(69, 25);
		A39228AE.TabIndex = 115;
		A39228AE.Text = "Chọn";
		A39228AE.UseVisualStyleBackColor = true;
		A39228AE.Click += new System.EventHandler(D1AE8FBC);
		txtBrandDevice.Location = new System.Drawing.Point(153, 2);
		txtBrandDevice.Name = "txtBrandDevice";
		txtBrandDevice.ReadOnly = true;
		txtBrandDevice.Size = new System.Drawing.Size(264, 23);
		txtBrandDevice.TabIndex = 114;
		txtBrandDevice.TextChanged += new System.EventHandler(txtBrandDevice_TextChanged);
		CC04DC17.AutoSize = true;
		CC04DC17.Location = new System.Drawing.Point(1, 5);
		CC04DC17.Name = "label9";
		CC04DC17.Size = new System.Drawing.Size(139, 16);
		CC04DC17.TabIndex = 113;
		CC04DC17.Text = "Chọn brand device (0):";
		E694B48E.AutoSize = true;
		E694B48E.Cursor = System.Windows.Forms.Cursors.Hand;
		E694B48E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E694B48E.Location = new System.Drawing.Point(21, 52);
		E694B48E.Name = "ckbKhongChangeDevice";
		E694B48E.Size = new System.Drawing.Size(149, 20);
		E694B48E.TabIndex = 112;
		E694B48E.Text = "Không Change Device";
		E694B48E.UseVisualStyleBackColor = true;
		E694B48E.CheckedChanged += new System.EventHandler(ckbShowProxy_CheckedChanged);
		label37.AutoSize = true;
		label37.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label37.Location = new System.Drawing.Point(552, 257);
		label37.Name = "label37";
		label37.Size = new System.Drawing.Size(123, 16);
		label37.TabIndex = 158;
		label37.Text = "Delay sau khi đô\u0309i IP:";
		rbMinProxy.AutoSize = true;
		rbMinProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		rbMinProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbMinProxy.Location = new System.Drawing.Point(549, 344);
		rbMinProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbMinProxy.Name = "rbMinProxy";
		rbMinProxy.Size = new System.Drawing.Size(142, 20);
		rbMinProxy.TabIndex = 161;
		rbMinProxy.Text = "https://minproxy.vn/";
		rbMinProxy.UseVisualStyleBackColor = true;
		rbMinProxy.CheckedChanged += new System.EventHandler(rbMinProxy_CheckedChanged);
		cbbHostpot.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbHostpot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbHostpot.Enabled = false;
		cbbHostpot.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		cbbHostpot.ForeColor = System.Drawing.Color.Black;
		cbbHostpot.FormattingEnabled = true;
		cbbHostpot.Items.AddRange(new object[2] { "Chi\u0309 trong quô\u0301c gia đang cho\u0323n", "Toa\u0300n bô\u0323 quô\u0301c gia" });
		cbbHostpot.Location = new System.Drawing.Point(1177, 563);
		cbbHostpot.Name = "cbbHostpot";
		cbbHostpot.Size = new System.Drawing.Size(229, 24);
		cbbHostpot.TabIndex = 144;
		E30BFE8A.Controls.Add(button5);
		E30BFE8A.Controls.Add(E816F606);
		E30BFE8A.Controls.Add(FB2C7495);
		E30BFE8A.Controls.Add(label27);
		E30BFE8A.Location = new System.Drawing.Point(549, 222);
		E30BFE8A.Name = "plCheckDoiIP";
		E30BFE8A.Size = new System.Drawing.Size(302, 27);
		E30BFE8A.TabIndex = 146;
		button5.Cursor = System.Windows.Forms.Cursors.Hand;
		button5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		button5.ForeColor = System.Drawing.Color.Black;
		button5.Location = new System.Drawing.Point(220, 0);
		button5.Name = "button5";
		button5.Size = new System.Drawing.Size(77, 27);
		button5.TabIndex = 143;
		button5.Text = "Test";
		button5.UseVisualStyleBackColor = true;
		button5.Click += new System.EventHandler(EA9C3D9A);
		E816F606.AutoSize = true;
		E816F606.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		E816F606.Location = new System.Drawing.Point(3, 5);
		E816F606.Name = "label26";
		E816F606.Size = new System.Drawing.Size(100, 16);
		E816F606.TabIndex = 139;
		E816F606.Text = "Thay đổi IP sau:";
		FB2C7495.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		FB2C7495.Location = new System.Drawing.Point(133, 3);
		FB2C7495.Name = "nudChangeIpCount";
		FB2C7495.Size = new System.Drawing.Size(46, 23);
		FB2C7495.TabIndex = 140;
		FB2C7495.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label27.AutoSize = true;
		label27.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label27.Location = new System.Drawing.Point(181, 5);
		label27.Name = "label27";
		label27.Size = new System.Drawing.Size(29, 16);
		label27.TabIndex = 141;
		label27.Text = "lượt";
		bunifuCards2.BackColor = System.Drawing.Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new System.Drawing.Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new System.Drawing.Size(549, 37);
		bunifuCards2.TabIndex = 40;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(549, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
		button2.Location = new System.Drawing.Point(518, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(btnCancel_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(549, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh chung";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(279, 612);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 20;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel2.Controls.Add(label12);
		panel2.Controls.Add(A821B6A8);
		panel2.Enabled = false;
		panel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		panel2.Location = new System.Drawing.Point(1176, 475);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(232, 30);
		panel2.TabIndex = 142;
		label12.AutoSize = true;
		label12.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label12.Location = new System.Drawing.Point(3, 5);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(75, 16);
		label12.TabIndex = 82;
		label12.Text = "Đường dẫn:";
		A821B6A8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A821B6A8.ForeColor = System.Drawing.Color.Black;
		A821B6A8.Location = new System.Drawing.Point(87, 2);
		A821B6A8.Name = "textBox1";
		A821B6A8.Size = new System.Drawing.Size(142, 23);
		A821B6A8.TabIndex = 83;
		DB248F81.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		DB248F81.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		DB248F81.Cursor = System.Windows.Forms.Cursors.Hand;
		DB248F81.FlatAppearance.BorderSize = 0;
		DB248F81.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DB248F81.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DB248F81.ForeColor = System.Drawing.Color.White;
		DB248F81.Location = new System.Drawing.Point(179, 612);
		DB248F81.Name = "btnSave";
		DB248F81.Size = new System.Drawing.Size(92, 29);
		DB248F81.TabIndex = 19;
		DB248F81.Text = "Lưu";
		DB248F81.UseVisualStyleBackColor = false;
		DB248F81.Click += new System.EventHandler(DB248F81_Click);
		rbShopLike.AutoSize = true;
		rbShopLike.Cursor = System.Windows.Forms.Cursors.Hand;
		rbShopLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbShopLike.Location = new System.Drawing.Point(840, 344);
		rbShopLike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbShopLike.Name = "rbShopLike";
		rbShopLike.Size = new System.Drawing.Size(165, 20);
		rbShopLike.TabIndex = 156;
		rbShopLike.Text = "http://proxy.shoplike.vn/";
		rbShopLike.UseVisualStyleBackColor = true;
		rbShopLike.CheckedChanged += new System.EventHandler(rbShopLike_CheckedChanged);
		BBABF381.AutoSize = true;
		BBABF381.Cursor = System.Windows.Forms.Cursors.Hand;
		BBABF381.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		BBABF381.Location = new System.Drawing.Point(840, 297);
		BBABF381.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		BBABF381.Name = "rbObcProxy";
		BBABF381.Size = new System.Drawing.Size(84, 20);
		BBABF381.TabIndex = 138;
		BBABF381.Text = "OBC Proxy";
		BBABF381.UseVisualStyleBackColor = true;
		BBABF381.CheckedChanged += new System.EventHandler(BBABF381_CheckedChanged);
		D8B05C8D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D8B05C8D.Controls.Add(label14);
		D8B05C8D.Controls.Add(txtNordVPN);
		D8B05C8D.Enabled = false;
		D8B05C8D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D8B05C8D.Location = new System.Drawing.Point(1176, 475);
		D8B05C8D.Name = "plNordVPN";
		D8B05C8D.Size = new System.Drawing.Size(232, 30);
		D8B05C8D.TabIndex = 142;
		label14.AutoSize = true;
		label14.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label14.Location = new System.Drawing.Point(3, 5);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(75, 16);
		label14.TabIndex = 82;
		label14.Text = "Đường dẫn:";
		txtNordVPN.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtNordVPN.ForeColor = System.Drawing.Color.Black;
		txtNordVPN.Location = new System.Drawing.Point(87, 2);
		txtNordVPN.Name = "txtNordVPN";
		txtNordVPN.Size = new System.Drawing.Size(142, 23);
		txtNordVPN.TabIndex = 83;
		B013D5A6.AutoSize = true;
		B013D5A6.Cursor = System.Windows.Forms.Cursors.Hand;
		B013D5A6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B013D5A6.Location = new System.Drawing.Point(840, 321);
		B013D5A6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		B013D5A6.Name = "rbProxyv6";
		B013D5A6.Size = new System.Drawing.Size(139, 20);
		B013D5A6.TabIndex = 154;
		B013D5A6.Text = "https://proxyv6.net/";
		B013D5A6.UseVisualStyleBackColor = true;
		B013D5A6.CheckedChanged += new System.EventHandler(A1116010);
		groupBox1.Controls.Add(C5B61B17);
		groupBox1.Controls.Add(label23);
		groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		groupBox1.Location = new System.Drawing.Point(1111, 493);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(568, 49);
		groupBox1.TabIndex = 38;
		groupBox1.TabStop = false;
		groupBox1.Text = "Cấu hình khác";
		C5B61B17.Controls.Add(rbPhanBietMauNen);
		C5B61B17.Controls.Add(rbPhanBietMauChu);
		C5B61B17.Location = new System.Drawing.Point(239, 17);
		C5B61B17.Name = "panel4";
		C5B61B17.Size = new System.Drawing.Size(309, 25);
		C5B61B17.TabIndex = 156;
		rbPhanBietMauNen.AutoSize = true;
		rbPhanBietMauNen.Checked = true;
		rbPhanBietMauNen.Cursor = System.Windows.Forms.Cursors.Hand;
		rbPhanBietMauNen.Location = new System.Drawing.Point(3, 3);
		rbPhanBietMauNen.Name = "rbPhanBietMauNen";
		rbPhanBietMauNen.Size = new System.Drawing.Size(130, 20);
		rbPhanBietMauNen.TabIndex = 34;
		rbPhanBietMauNen.TabStop = true;
		rbPhanBietMauNen.Text = "Đổi màu nền dòng";
		rbPhanBietMauNen.UseVisualStyleBackColor = true;
		rbPhanBietMauChu.AutoSize = true;
		rbPhanBietMauChu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbPhanBietMauChu.Location = new System.Drawing.Point(190, 3);
		rbPhanBietMauChu.Name = "rbPhanBietMauChu";
		rbPhanBietMauChu.Size = new System.Drawing.Size(98, 20);
		rbPhanBietMauChu.TabIndex = 34;
		rbPhanBietMauChu.Text = "Đổi màu chữ";
		rbPhanBietMauChu.UseVisualStyleBackColor = true;
		label23.AutoSize = true;
		label23.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label23.Location = new System.Drawing.Point(18, 20);
		label23.Name = "label23";
		label23.Size = new System.Drawing.Size(223, 16);
		label23.TabIndex = 33;
		label23.Text = "Phân biệt màu [Tình trạng tài khoản]:";
		linkLabel3.AutoSize = true;
		linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel3.Location = new System.Drawing.Point(727, 369);
		linkLabel3.Name = "linkLabel3";
		linkLabel3.Size = new System.Drawing.Size(85, 16);
		linkLabel3.TabIndex = 147;
		linkLabel3.TabStop = true;
		linkLabel3.Text = "Hươ\u0301ng dâ\u0303n(?)";
		linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked);
		D02CE704.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D02CE704.Controls.Add(plDongBoMaxCare);
		D02CE704.Controls.Add(ckbDongBoMaxCare);
		D02CE704.Controls.Add(ckbTatADBKhiDungTool);
		D02CE704.Controls.Add(ckbLuuTrangThai);
		D02CE704.Controls.Add(AC3D3598);
		D02CE704.Controls.Add(EC086238);
		D02CE704.Controls.Add(label6);
		D02CE704.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D02CE704.Location = new System.Drawing.Point(7, 39);
		D02CE704.Name = "groupBox2";
		D02CE704.Size = new System.Drawing.Size(536, 130);
		D02CE704.TabIndex = 38;
		D02CE704.TabStop = false;
		D02CE704.Text = "Cấu hình chung";
		plDongBoMaxCare.Controls.Add(D035FCBC);
		plDongBoMaxCare.Controls.Add(A4A18D89);
		plDongBoMaxCare.Location = new System.Drawing.Point(34, 40);
		plDongBoMaxCare.Name = "plDongBoMaxCare";
		plDongBoMaxCare.Size = new System.Drawing.Size(478, 29);
		plDongBoMaxCare.TabIndex = 164;
		D035FCBC.AutoSize = true;
		D035FCBC.Location = new System.Drawing.Point(3, 6);
		D035FCBC.Name = "label15";
		D035FCBC.Size = new System.Drawing.Size(129, 16);
		D035FCBC.TabIndex = 158;
		D035FCBC.Text = "Đường dẫn MaxCare:";
		A4A18D89.Location = new System.Drawing.Point(152, 3);
		A4A18D89.Name = "txtPathMaxCare";
		A4A18D89.Size = new System.Drawing.Size(323, 23);
		A4A18D89.TabIndex = 159;
		ckbDongBoMaxCare.AutoSize = true;
		ckbDongBoMaxCare.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDongBoMaxCare.Location = new System.Drawing.Point(21, 22);
		ckbDongBoMaxCare.Name = "ckbDongBoMaxCare";
		ckbDongBoMaxCare.Size = new System.Drawing.Size(191, 20);
		ckbDongBoMaxCare.TabIndex = 29;
		ckbDongBoMaxCare.Text = "Đô\u0300ng bô\u0323 dư\u0303 liê\u0323u vơ\u0301i MaxCare";
		ckbDongBoMaxCare.UseVisualStyleBackColor = true;
		ckbDongBoMaxCare.CheckedChanged += new System.EventHandler(D10E8000);
		ckbTatADBKhiDungTool.AutoSize = true;
		ckbTatADBKhiDungTool.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTatADBKhiDungTool.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbTatADBKhiDungTool.Location = new System.Drawing.Point(366, 103);
		ckbTatADBKhiDungTool.Name = "ckbTatADBKhiDungTool";
		ckbTatADBKhiDungTool.Size = new System.Drawing.Size(150, 20);
		ckbTatADBKhiDungTool.TabIndex = 112;
		ckbTatADBKhiDungTool.Text = "Kill ADB khi chạy xong";
		ckbTatADBKhiDungTool.UseVisualStyleBackColor = true;
		ckbLuuTrangThai.AutoSize = true;
		ckbLuuTrangThai.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLuuTrangThai.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbLuuTrangThai.Location = new System.Drawing.Point(21, 103);
		ckbLuuTrangThai.Name = "ckbLuuTrangThai";
		ckbLuuTrangThai.Size = new System.Drawing.Size(184, 20);
		ckbLuuTrangThai.TabIndex = 112;
		ckbLuuTrangThai.Text = "Lưu dư\u0303 liê\u0323u cô\u0323t [Tra\u0323ng tha\u0301i]";
		ckbLuuTrangThai.UseVisualStyleBackColor = true;
		btnSSH.Cursor = System.Windows.Forms.Cursors.Hand;
		btnSSH.Enabled = false;
		btnSSH.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		btnSSH.ForeColor = System.Drawing.Color.Black;
		btnSSH.Location = new System.Drawing.Point(1263, 508);
		btnSSH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnSSH.Name = "btnSSH";
		btnSSH.Size = new System.Drawing.Size(106, 26);
		btnSSH.TabIndex = 130;
		btnSSH.Text = "Nhập IP SSH";
		btnSSH.UseVisualStyleBackColor = true;
		btnSSH.Click += new System.EventHandler(btnSSH_Click);
		rbTMProxy.AutoSize = true;
		rbTMProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		rbTMProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbTMProxy.Location = new System.Drawing.Point(840, 367);
		rbTMProxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbTMProxy.Name = "rbTMProxy";
		rbTMProxy.Size = new System.Drawing.Size(147, 20);
		rbTMProxy.TabIndex = 145;
		rbTMProxy.Text = "https://tmproxy.com/";
		rbTMProxy.UseVisualStyleBackColor = true;
		rbTMProxy.CheckedChanged += new System.EventHandler(CBB2F013);
		radioButton4.AutoSize = true;
		radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton4.Enabled = false;
		radioButton4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		radioButton4.Location = new System.Drawing.Point(1162, 426);
		radioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		radioButton4.Name = "radioButton4";
		radioButton4.Size = new System.Drawing.Size(130, 20);
		radioButton4.TabIndex = 133;
		radioButton4.Text = "Đổi IP ExpressVPN";
		radioButton4.UseVisualStyleBackColor = true;
		rbDcom.AutoSize = true;
		rbDcom.Cursor = System.Windows.Forms.Cursors.Hand;
		rbDcom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbDcom.Location = new System.Drawing.Point(549, 321);
		rbDcom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbDcom.Name = "rbDcom";
		rbDcom.Size = new System.Drawing.Size(95, 20);
		rbDcom.TabIndex = 137;
		rbDcom.Text = "Đổi IP Dcom";
		rbDcom.UseVisualStyleBackColor = true;
		rbDcom.CheckedChanged += new System.EventHandler(E2A8C61E);
		rbTinsoft.AutoSize = true;
		rbTinsoft.Cursor = System.Windows.Forms.Cursors.Hand;
		rbTinsoft.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbTinsoft.Location = new System.Drawing.Point(549, 367);
		rbTinsoft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbTinsoft.Name = "rbTinsoft";
		rbTinsoft.Size = new System.Drawing.Size(167, 20);
		rbTinsoft.TabIndex = 134;
		rbTinsoft.Text = "https://tinsoftproxy.com/";
		rbTinsoft.UseVisualStyleBackColor = true;
		rbTinsoft.CheckedChanged += new System.EventHandler(EA20E199);
		B79E7F90.AutoSize = true;
		B79E7F90.Enabled = false;
		B79E7F90.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B79E7F90.Location = new System.Drawing.Point(1162, 539);
		B79E7F90.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		B79E7F90.Name = "rbHotspot";
		B79E7F90.Size = new System.Drawing.Size(145, 20);
		B79E7F90.TabIndex = 135;
		B79E7F90.Text = "Đổi IP Hotspot Shield";
		B79E7F90.UseVisualStyleBackColor = true;
		A5808136.AutoSize = true;
		A5808136.Cursor = System.Windows.Forms.Cursors.Hand;
		A5808136.Enabled = false;
		A5808136.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A5808136.Location = new System.Drawing.Point(1162, 511);
		A5808136.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		A5808136.Name = "radioButton5";
		A5808136.Size = new System.Drawing.Size(87, 20);
		A5808136.TabIndex = 132;
		A5808136.Text = "Đổi IP SSH";
		A5808136.UseVisualStyleBackColor = true;
		rbNordVPN.AutoSize = true;
		rbNordVPN.Enabled = false;
		rbNordVPN.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbNordVPN.Location = new System.Drawing.Point(1162, 451);
		rbNordVPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbNordVPN.Name = "rbNordVPN";
		rbNordVPN.Size = new System.Drawing.Size(113, 20);
		rbNordVPN.TabIndex = 134;
		rbNordVPN.Text = "Đổi IP NordVPN";
		rbNordVPN.UseVisualStyleBackColor = true;
		rbNordVPN.CheckedChanged += new System.EventHandler(D8BD4834_CheckedChanged);
		C5BA703B.AutoSize = true;
		C5BA703B.Cursor = System.Windows.Forms.Cursors.Hand;
		C5BA703B.Enabled = false;
		C5BA703B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C5BA703B.Location = new System.Drawing.Point(1162, 539);
		C5BA703B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		C5BA703B.Name = "radioButton2";
		C5BA703B.Size = new System.Drawing.Size(145, 20);
		C5BA703B.TabIndex = 135;
		C5BA703B.Text = "Đổi IP Hotspot Shield";
		C5BA703B.UseVisualStyleBackColor = true;
		DB21D419.AutoSize = true;
		DB21D419.Enabled = false;
		DB21D419.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		DB21D419.Location = new System.Drawing.Point(1162, 511);
		DB21D419.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		DB21D419.Name = "rbSSH";
		DB21D419.Size = new System.Drawing.Size(87, 20);
		DB21D419.TabIndex = 132;
		DB21D419.Text = "Đổi IP SSH";
		DB21D419.UseVisualStyleBackColor = true;
		rbHma.AutoSize = true;
		rbHma.Cursor = System.Windows.Forms.Cursors.Hand;
		rbHma.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbHma.Location = new System.Drawing.Point(676, 321);
		rbHma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbHma.Name = "rbHma";
		rbHma.Size = new System.Drawing.Size(89, 20);
		rbHma.TabIndex = 138;
		rbHma.Text = "Đổi IP HMA";
		rbHma.UseVisualStyleBackColor = true;
		rbHma.CheckedChanged += new System.EventHandler(CC838B1F);
		D8BD4834.AutoSize = true;
		D8BD4834.Cursor = System.Windows.Forms.Cursors.Hand;
		D8BD4834.Enabled = false;
		D8BD4834.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D8BD4834.Location = new System.Drawing.Point(1162, 451);
		D8BD4834.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		D8BD4834.Name = "radioButton3";
		D8BD4834.Size = new System.Drawing.Size(113, 20);
		D8BD4834.TabIndex = 134;
		D8BD4834.Text = "Đổi IP NordVPN";
		D8BD4834.UseVisualStyleBackColor = true;
		D8BD4834.CheckedChanged += new System.EventHandler(D8BD4834_CheckedChanged);
		EAAE1628.AutoSize = true;
		EAAE1628.Enabled = false;
		EAAE1628.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		EAAE1628.Location = new System.Drawing.Point(1162, 426);
		EAAE1628.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		EAAE1628.Name = "rbExpressVPN";
		EAAE1628.Size = new System.Drawing.Size(130, 20);
		EAAE1628.TabIndex = 133;
		EAAE1628.Text = "Đổi IP ExpressVPN";
		EAAE1628.UseVisualStyleBackColor = true;
		DC158F12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DC158F12.Controls.Add(A499EB0E);
		DC158F12.Controls.Add(label38);
		DC158F12.Controls.Add(C49CCEB2);
		DC158F12.Controls.Add(tabChangeIP);
		DC158F12.Controls.Add(D7B048B6);
		DC158F12.Controls.Add(rbNone);
		DC158F12.Controls.Add(ckbKhongCheckIP);
		DC158F12.Controls.Add(rbXproxy);
		DC158F12.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		DC158F12.Location = new System.Drawing.Point(7, 259);
		DC158F12.Name = "groupBox3";
		DC158F12.Size = new System.Drawing.Size(536, 347);
		DC158F12.TabIndex = 39;
		DC158F12.TabStop = false;
		DC158F12.Text = "Cấu hình đổi IP";
		A499EB0E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A499EB0E.Location = new System.Drawing.Point(674, 80);
		A499EB0E.Maximum = new decimal(new int[4] { 99999999, 0, 0, 0 });
		A499EB0E.Name = "nudDelayCheckIP";
		A499EB0E.Size = new System.Drawing.Size(46, 23);
		A499EB0E.TabIndex = 159;
		label38.AutoSize = true;
		label38.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label38.Location = new System.Drawing.Point(722, 84);
		label38.Name = "label38";
		label38.Size = new System.Drawing.Size(30, 16);
		label38.TabIndex = 160;
		label38.Text = "giây";
		C49CCEB2.AutoSize = true;
		C49CCEB2.Cursor = System.Windows.Forms.Cursors.Hand;
		C49CCEB2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C49CCEB2.Location = new System.Drawing.Point(21, 51);
		C49CCEB2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		C49CCEB2.Name = "rb4G";
		C49CCEB2.Size = new System.Drawing.Size(81, 20);
		C49CCEB2.TabIndex = 136;
		C49CCEB2.Text = "4G Mobile";
		C49CCEB2.UseVisualStyleBackColor = true;
		C49CCEB2.CheckedChanged += new System.EventHandler(C49CCEB2_CheckedChanged);
		tabChangeIP.Alignment = System.Windows.Forms.TabAlignment.Bottom;
		tabChangeIP.Controls.Add(tabDcom);
		tabChangeIP.Controls.Add(E92DE81F);
		tabChangeIP.Controls.Add(tabXProxy);
		tabChangeIP.Controls.Add(DC9FCF2C);
		tabChangeIP.Controls.Add(tabProxyV6);
		tabChangeIP.Controls.Add(A7848002);
		tabChangeIP.Controls.Add(tabTMProxy);
		tabChangeIP.Controls.Add(FC84E1AE);
		tabChangeIP.Controls.Add(AB344289);
		tabChangeIP.Cursor = System.Windows.Forms.Cursors.Hand;
		tabChangeIP.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		tabChangeIP.Location = new System.Drawing.Point(21, 133);
		tabChangeIP.Name = "tabChangeIP";
		tabChangeIP.SelectedIndex = 0;
		tabChangeIP.Size = new System.Drawing.Size(495, 238);
		tabChangeIP.TabIndex = 145;
		tabDcom.Controls.Add(plDcom);
		tabDcom.Location = new System.Drawing.Point(4, 4);
		tabDcom.Name = "tabDcom";
		tabDcom.Padding = new System.Windows.Forms.Padding(3);
		tabDcom.Size = new System.Drawing.Size(487, 209);
		tabDcom.TabIndex = 0;
		tabDcom.Text = "Dcom";
		tabDcom.UseVisualStyleBackColor = true;
		plDcom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plDcom.Controls.Add(button4);
		plDcom.Controls.Add(txtUrlHilink);
		plDcom.Controls.Add(txtProfileNameDcom);
		plDcom.Controls.Add(FBA6D680);
		plDcom.Controls.Add(D2ABCC15);
		plDcom.Controls.Add(rbDcomThuong);
		plDcom.Dock = System.Windows.Forms.DockStyle.Fill;
		plDcom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		plDcom.Location = new System.Drawing.Point(3, 3);
		plDcom.Name = "plDcom";
		plDcom.Size = new System.Drawing.Size(481, 203);
		plDcom.TabIndex = 148;
		button4.Anchor = System.Windows.Forms.AnchorStyles.None;
		button4.Cursor = System.Windows.Forms.Cursors.Hand;
		button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		button4.ForeColor = System.Drawing.Color.Black;
		button4.Location = new System.Drawing.Point(301, 61);
		button4.Name = "button4";
		button4.Size = new System.Drawing.Size(93, 25);
		button4.TabIndex = 143;
		button4.Text = "Lâ\u0301y tên Dcom";
		C59DF58E.SetToolTip(button4, "Lâ\u0301y tên dcom");
		button4.UseVisualStyleBackColor = true;
		button4.Click += new System.EventHandler(button4_Click);
		txtUrlHilink.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtUrlHilink.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtUrlHilink.ForeColor = System.Drawing.Color.Black;
		txtUrlHilink.Location = new System.Drawing.Point(175, 109);
		txtUrlHilink.Name = "txtUrlHilink";
		txtUrlHilink.Size = new System.Drawing.Size(219, 23);
		txtUrlHilink.TabIndex = 81;
		txtProfileNameDcom.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtProfileNameDcom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtProfileNameDcom.ForeColor = System.Drawing.Color.Black;
		txtProfileNameDcom.Location = new System.Drawing.Point(107, 62);
		txtProfileNameDcom.Name = "txtProfileNameDcom";
		txtProfileNameDcom.Size = new System.Drawing.Size(189, 23);
		txtProfileNameDcom.TabIndex = 81;
		FBA6D680.Anchor = System.Windows.Forms.AnchorStyles.None;
		FBA6D680.AutoSize = true;
		FBA6D680.Cursor = System.Windows.Forms.Cursors.Hand;
		FBA6D680.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		FBA6D680.Location = new System.Drawing.Point(88, 88);
		FBA6D680.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		FBA6D680.Name = "rbDcomHilink";
		FBA6D680.Size = new System.Drawing.Size(55, 20);
		FBA6D680.TabIndex = 136;
		FBA6D680.Text = "Hilink";
		FBA6D680.UseVisualStyleBackColor = true;
		FBA6D680.CheckedChanged += new System.EventHandler(AC898311);
		D2ABCC15.Anchor = System.Windows.Forms.AnchorStyles.None;
		D2ABCC15.AutoSize = true;
		D2ABCC15.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D2ABCC15.Location = new System.Drawing.Point(104, 112);
		D2ABCC15.Name = "label19";
		D2ABCC15.Size = new System.Drawing.Size(64, 16);
		D2ABCC15.TabIndex = 79;
		D2ABCC15.Text = "Link Web:";
		rbDcomThuong.Anchor = System.Windows.Forms.AnchorStyles.None;
		rbDcomThuong.AutoSize = true;
		rbDcomThuong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbDcomThuong.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbDcomThuong.Location = new System.Drawing.Point(88, 41);
		rbDcomThuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbDcomThuong.Name = "rbDcomThuong";
		rbDcomThuong.Size = new System.Drawing.Size(69, 20);
		rbDcomThuong.TabIndex = 136;
		rbDcomThuong.Text = "Thươ\u0300ng";
		rbDcomThuong.UseVisualStyleBackColor = true;
		rbDcomThuong.CheckedChanged += new System.EventHandler(rbDcomThuong_CheckedChanged);
		E92DE81F.Controls.Add(plTinsoft);
		E92DE81F.Location = new System.Drawing.Point(4, 4);
		E92DE81F.Name = "tabTinsoft";
		E92DE81F.Padding = new System.Windows.Forms.Padding(3);
		E92DE81F.Size = new System.Drawing.Size(487, 209);
		E92DE81F.TabIndex = 1;
		E92DE81F.Text = "https://tinsoftproxy.com/";
		E92DE81F.UseVisualStyleBackColor = true;
		plTinsoft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTinsoft.Controls.Add(B2B88C33);
		plTinsoft.Controls.Add(plApiProxy);
		plTinsoft.Controls.Add(D599320F);
		plTinsoft.Controls.Add(A51AE311);
		plTinsoft.Controls.Add(BA85668E);
		plTinsoft.Controls.Add(rbApiUser);
		plTinsoft.Controls.Add(E239E097);
		plTinsoft.Controls.Add(F7B3919B);
		plTinsoft.Controls.Add(nudLuongPerIPTinsoft);
		plTinsoft.Dock = System.Windows.Forms.DockStyle.Fill;
		plTinsoft.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		plTinsoft.Location = new System.Drawing.Point(3, 3);
		plTinsoft.Name = "plTinsoft";
		plTinsoft.Size = new System.Drawing.Size(481, 203);
		plTinsoft.TabIndex = 142;
		plTinsoft.Click += new System.EventHandler(plTinsoft_Click);
		B2B88C33.Anchor = System.Windows.Forms.AnchorStyles.None;
		B2B88C33.AutoSize = true;
		B2B88C33.Cursor = System.Windows.Forms.Cursors.Hand;
		B2B88C33.Location = new System.Drawing.Point(221, 48);
		B2B88C33.Name = "ckbWaitDoneAllTinsoft";
		B2B88C33.Size = new System.Drawing.Size(128, 20);
		B2B88C33.TabIndex = 145;
		B2B88C33.Text = "Đợi chạy xong hết";
		B2B88C33.UseVisualStyleBackColor = true;
		B2B88C33.Visible = false;
		plApiProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		plApiProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plApiProxy.Controls.Add(lblCountApiProxy);
		plApiProxy.Controls.Add(label28);
		plApiProxy.Controls.Add(D13B9598);
		plApiProxy.Controls.Add(D00D64B3);
		plApiProxy.Location = new System.Drawing.Point(95, 122);
		plApiProxy.Name = "plApiProxy";
		plApiProxy.Size = new System.Drawing.Size(292, 58);
		plApiProxy.TabIndex = 35;
		lblCountApiProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		lblCountApiProxy.Location = new System.Drawing.Point(1, 24);
		lblCountApiProxy.Name = "lblCountApiProxy";
		lblCountApiProxy.Size = new System.Drawing.Size(32, 16);
		lblCountApiProxy.TabIndex = 82;
		lblCountApiProxy.Text = "(0)";
		lblCountApiProxy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label28.AutoSize = true;
		label28.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label28.Location = new System.Drawing.Point(1, 5);
		label28.Name = "label28";
		label28.Size = new System.Drawing.Size(31, 16);
		label28.TabIndex = 82;
		label28.Text = "API:";
		D13B9598.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D13B9598.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D13B9598.ForeColor = System.Drawing.Color.Black;
		D13B9598.Location = new System.Drawing.Point(35, 2);
		D13B9598.Multiline = true;
		D13B9598.Name = "txtApiProxy";
		D13B9598.Size = new System.Drawing.Size(200, 51);
		D13B9598.TabIndex = 83;
		D13B9598.WordWrap = false;
		D13B9598.TextChanged += new System.EventHandler(D13B9598_TextChanged);
		D00D64B3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		D00D64B3.Cursor = System.Windows.Forms.Cursors.Hand;
		D00D64B3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D00D64B3.ForeColor = System.Drawing.Color.Black;
		D00D64B3.Location = new System.Drawing.Point(238, 1);
		D00D64B3.Name = "button7";
		D00D64B3.Size = new System.Drawing.Size(52, 27);
		D00D64B3.TabIndex = 143;
		D00D64B3.Text = "Check";
		D00D64B3.UseVisualStyleBackColor = true;
		D00D64B3.Click += new System.EventHandler(A5A15003);
		D599320F.Anchor = System.Windows.Forms.AnchorStyles.None;
		D599320F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D599320F.Controls.Add(A6A51D25);
		D599320F.Controls.Add(txtApiUser);
		D599320F.Controls.Add(button3);
		D599320F.Location = new System.Drawing.Point(95, 69);
		D599320F.Name = "plApiUser";
		D599320F.Size = new System.Drawing.Size(292, 29);
		D599320F.TabIndex = 35;
		A6A51D25.AutoSize = true;
		A6A51D25.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A6A51D25.Location = new System.Drawing.Point(1, 5);
		A6A51D25.Name = "label1";
		A6A51D25.Size = new System.Drawing.Size(31, 16);
		A6A51D25.TabIndex = 82;
		A6A51D25.Text = "API:";
		txtApiUser.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtApiUser.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtApiUser.ForeColor = System.Drawing.Color.Black;
		txtApiUser.Location = new System.Drawing.Point(35, 2);
		txtApiUser.Name = "txtApiUser";
		txtApiUser.Size = new System.Drawing.Size(200, 23);
		txtApiUser.TabIndex = 83;
		button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button3.Cursor = System.Windows.Forms.Cursors.Hand;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		button3.ForeColor = System.Drawing.Color.Black;
		button3.Location = new System.Drawing.Point(238, 0);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(52, 27);
		button3.TabIndex = 143;
		button3.Text = "Check";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		A51AE311.Anchor = System.Windows.Forms.AnchorStyles.None;
		A51AE311.Cursor = System.Windows.Forms.Cursors.Hand;
		A51AE311.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		A51AE311.DropDownWidth = 120;
		A51AE311.FormattingEnabled = true;
		A51AE311.Location = new System.Drawing.Point(150, 186);
		A51AE311.Name = "cbbLocationTinsoft";
		A51AE311.Size = new System.Drawing.Size(104, 24);
		A51AE311.TabIndex = 84;
		BA85668E.Anchor = System.Windows.Forms.AnchorStyles.None;
		BA85668E.AutoSize = true;
		BA85668E.Cursor = System.Windows.Forms.Cursors.Hand;
		BA85668E.Location = new System.Drawing.Point(92, 101);
		BA85668E.Name = "rbApiProxy";
		BA85668E.Size = new System.Drawing.Size(135, 20);
		BA85668E.TabIndex = 34;
		BA85668E.Text = "Sử dụng Api Proxy:";
		BA85668E.UseVisualStyleBackColor = true;
		BA85668E.CheckedChanged += new System.EventHandler(B394661E);
		rbApiUser.Anchor = System.Windows.Forms.AnchorStyles.None;
		rbApiUser.AutoSize = true;
		rbApiUser.Checked = true;
		rbApiUser.Cursor = System.Windows.Forms.Cursors.Hand;
		rbApiUser.Location = new System.Drawing.Point(92, 48);
		rbApiUser.Name = "rbApiUser";
		rbApiUser.Size = new System.Drawing.Size(130, 20);
		rbApiUser.TabIndex = 34;
		rbApiUser.TabStop = true;
		rbApiUser.Text = "Sử dụng Api User:";
		rbApiUser.UseVisualStyleBackColor = true;
		rbApiUser.CheckedChanged += new System.EventHandler(rbApiUser_CheckedChanged);
		E239E097.Anchor = System.Windows.Forms.AnchorStyles.None;
		E239E097.AutoSize = true;
		E239E097.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		E239E097.Location = new System.Drawing.Point(92, 189);
		E239E097.Name = "label7";
		E239E097.Size = new System.Drawing.Size(59, 16);
		E239E097.TabIndex = 82;
		E239E097.Text = "Location:";
		F7B3919B.Anchor = System.Windows.Forms.AnchorStyles.None;
		F7B3919B.AutoSize = true;
		F7B3919B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F7B3919B.Location = new System.Drawing.Point(259, 189);
		F7B3919B.Name = "label8";
		F7B3919B.Size = new System.Drawing.Size(78, 16);
		F7B3919B.TabIndex = 139;
		F7B3919B.Text = "Số luồng/IP:";
		C59DF58E.SetToolTip(F7B3919B, "Là số tài khoản cùng chạy trên 1 Proxy (hay 1 IP)");
		nudLuongPerIPTinsoft.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudLuongPerIPTinsoft.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudLuongPerIPTinsoft.Location = new System.Drawing.Point(341, 187);
		nudLuongPerIPTinsoft.Name = "nudLuongPerIPTinsoft";
		nudLuongPerIPTinsoft.Size = new System.Drawing.Size(46, 23);
		nudLuongPerIPTinsoft.TabIndex = 140;
		nudLuongPerIPTinsoft.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		tabXProxy.Controls.Add(A69C8A9A);
		tabXProxy.Location = new System.Drawing.Point(4, 4);
		tabXProxy.Name = "tabXProxy";
		tabXProxy.Padding = new System.Windows.Forms.Padding(3);
		tabXProxy.Size = new System.Drawing.Size(487, 209);
		tabXProxy.TabIndex = 2;
		tabXProxy.Text = "Xproxy";
		tabXProxy.UseVisualStyleBackColor = true;
		A69C8A9A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A69C8A9A.Controls.Add(B4B5BF08);
		A69C8A9A.Controls.Add(ckbShowProxy);
		A69C8A9A.Controls.Add(nudDelayConnectXproxy);
		A69C8A9A.Controls.Add(label4);
		A69C8A9A.Controls.Add(txtListProxy);
		A69C8A9A.Controls.Add(D532E936);
		A69C8A9A.Controls.Add(label2);
		A69C8A9A.Controls.Add(label13);
		A69C8A9A.Controls.Add(txtServiceURLXProxy);
		A69C8A9A.Dock = System.Windows.Forms.DockStyle.Fill;
		A69C8A9A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A69C8A9A.Location = new System.Drawing.Point(3, 3);
		A69C8A9A.Name = "plXproxy";
		A69C8A9A.Size = new System.Drawing.Size(481, 203);
		A69C8A9A.TabIndex = 142;
		A69C8A9A.Click += new System.EventHandler(CFB60F91_Click);
		B4B5BF08.AutoSize = true;
		B4B5BF08.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B4B5BF08.Location = new System.Drawing.Point(274, 156);
		B4B5BF08.Name = "label3";
		B4B5BF08.Size = new System.Drawing.Size(30, 16);
		B4B5BF08.TabIndex = 147;
		B4B5BF08.Text = "giây";
		ckbShowProxy.AutoSize = true;
		ckbShowProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShowProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbShowProxy.Location = new System.Drawing.Point(16, 178);
		ckbShowProxy.Name = "ckbShowProxy";
		ckbShowProxy.Size = new System.Drawing.Size(208, 20);
		ckbShowProxy.TabIndex = 112;
		ckbShowProxy.Text = "Hiển thị thông tin proxy khi chạy";
		ckbShowProxy.UseVisualStyleBackColor = true;
		ckbShowProxy.CheckedChanged += new System.EventHandler(ckbShowProxy_CheckedChanged);
		nudDelayConnectXproxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		nudDelayConnectXproxy.Location = new System.Drawing.Point(217, 154);
		nudDelayConnectXproxy.Maximum = new decimal(new int[4] { 1410065407, 2, 0, 0 });
		nudDelayConnectXproxy.Name = "nudDelayConnectXproxy";
		nudDelayConnectXproxy.Size = new System.Drawing.Size(56, 23);
		nudDelayConnectXproxy.TabIndex = 146;
		label4.AutoSize = true;
		label4.Cursor = System.Windows.Forms.Cursors.Arrow;
		label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label4.Location = new System.Drawing.Point(13, 156);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(203, 16);
		label4.TabIndex = 145;
		label4.Text = "Delay connect proxy sau khi reset:";
		txtListProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtListProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtListProxy.Location = new System.Drawing.Point(16, 49);
		txtListProxy.Name = "txtListProxy";
		txtListProxy.Size = new System.Drawing.Size(447, 80);
		txtListProxy.TabIndex = 144;
		txtListProxy.Text = "";
		txtListProxy.WordWrap = false;
		txtListProxy.TextChanged += new System.EventHandler(txtListProxy_TextChanged);
		D532E936.Anchor = System.Windows.Forms.AnchorStyles.None;
		D532E936.AutoSize = true;
		D532E936.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D532E936.Location = new System.Drawing.Point(13, 30);
		D532E936.Name = "label17";
		D532E936.Size = new System.Drawing.Size(159, 16);
		D532E936.TabIndex = 79;
		D532E936.Text = "Nhập danh sách Proxy (0):";
		label2.Anchor = System.Windows.Forms.AnchorStyles.None;
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label2.Location = new System.Drawing.Point(13, 132);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(385, 16);
		label2.TabIndex = 79;
		label2.Text = "(Mỗi phone sẽ sử dụng 1 proxy riêng - Chỉ sử dụng với Http Proxy)";
		label13.Anchor = System.Windows.Forms.AnchorStyles.None;
		label13.AutoSize = true;
		label13.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label13.Location = new System.Drawing.Point(13, 8);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(80, 16);
		label13.TabIndex = 79;
		label13.Text = "Service URL:";
		txtServiceURLXProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtServiceURLXProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtServiceURLXProxy.ForeColor = System.Drawing.Color.Black;
		txtServiceURLXProxy.Location = new System.Drawing.Point(100, 5);
		txtServiceURLXProxy.Name = "txtServiceURLXProxy";
		txtServiceURLXProxy.Size = new System.Drawing.Size(363, 23);
		txtServiceURLXProxy.TabIndex = 81;
		DC9FCF2C.Controls.Add(CFB60F91);
		DC9FCF2C.Location = new System.Drawing.Point(4, 4);
		DC9FCF2C.Name = "tabObcProxy";
		DC9FCF2C.Padding = new System.Windows.Forms.Padding(3);
		DC9FCF2C.Size = new System.Drawing.Size(487, 209);
		DC9FCF2C.TabIndex = 3;
		DC9FCF2C.Text = "OBC Proxy";
		DC9FCF2C.UseVisualStyleBackColor = true;
		CFB60F91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		CFB60F91.Controls.Add(DB81A52F);
		CFB60F91.Controls.Add(rbObcResetDaiIP);
		CFB60F91.Controls.Add(F49A4B22);
		CFB60F91.Controls.Add(txtListObcProxy);
		CFB60F91.Controls.Add(A08E4787);
		CFB60F91.Controls.Add(F52C1436);
		CFB60F91.Controls.Add(EF10790C);
		CFB60F91.Controls.Add(nudLuongPerIPObcProxy);
		CFB60F91.Controls.Add(label39);
		CFB60F91.Controls.Add(label41);
		CFB60F91.Controls.Add(nudDelayCheckIPObcProxy);
		CFB60F91.Controls.Add(txtLinkWebObcProxy);
		CFB60F91.Dock = System.Windows.Forms.DockStyle.Fill;
		CFB60F91.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		CFB60F91.Location = new System.Drawing.Point(3, 3);
		CFB60F91.Name = "plObcProxy";
		CFB60F91.Size = new System.Drawing.Size(481, 203);
		CFB60F91.TabIndex = 142;
		CFB60F91.Click += new System.EventHandler(CFB60F91_Click);
		DB81A52F.Anchor = System.Windows.Forms.AnchorStyles.None;
		DB81A52F.AutoSize = true;
		DB81A52F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		DB81A52F.Location = new System.Drawing.Point(251, 115);
		DB81A52F.Name = "label33";
		DB81A52F.Size = new System.Drawing.Size(82, 16);
		DB81A52F.TabIndex = 151;
		DB81A52F.Text = "Chế độ chạy:";
		rbObcResetDaiIP.Anchor = System.Windows.Forms.AnchorStyles.None;
		rbObcResetDaiIP.AutoSize = true;
		rbObcResetDaiIP.Cursor = System.Windows.Forms.Cursors.Hand;
		rbObcResetDaiIP.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbObcResetDaiIP.Location = new System.Drawing.Point(336, 137);
		rbObcResetDaiIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbObcResetDaiIP.Name = "rbObcResetDaiIP";
		rbObcResetDaiIP.Size = new System.Drawing.Size(110, 20);
		rbObcResetDaiIP.TabIndex = 149;
		rbObcResetDaiIP.Text = "Reset cả dải IP";
		rbObcResetDaiIP.UseVisualStyleBackColor = true;
		F49A4B22.Anchor = System.Windows.Forms.AnchorStyles.None;
		F49A4B22.AutoSize = true;
		F49A4B22.Checked = true;
		F49A4B22.Cursor = System.Windows.Forms.Cursors.Hand;
		F49A4B22.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F49A4B22.Location = new System.Drawing.Point(336, 113);
		F49A4B22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		F49A4B22.Name = "rbObcResetTungIP";
		F49A4B22.Size = new System.Drawing.Size(102, 20);
		F49A4B22.TabIndex = 150;
		F49A4B22.TabStop = true;
		F49A4B22.Text = "Reset từng IP";
		F49A4B22.UseVisualStyleBackColor = true;
		txtListObcProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtListObcProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtListObcProxy.Location = new System.Drawing.Point(16, 84);
		txtListObcProxy.Name = "txtListObcProxy";
		txtListObcProxy.Size = new System.Drawing.Size(229, 115);
		txtListObcProxy.TabIndex = 144;
		txtListObcProxy.Text = "";
		txtListObcProxy.WordWrap = false;
		txtListObcProxy.TextChanged += new System.EventHandler(txtListObcProxy_TextChanged);
		A08E4787.Anchor = System.Windows.Forms.AnchorStyles.None;
		A08E4787.AutoSize = true;
		A08E4787.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A08E4787.Location = new System.Drawing.Point(13, 62);
		A08E4787.Name = "label34";
		A08E4787.Size = new System.Drawing.Size(97, 16);
		A08E4787.TabIndex = 79;
		A08E4787.Text = "Nhập Proxy (0):";
		F52C1436.Anchor = System.Windows.Forms.AnchorStyles.None;
		F52C1436.AutoSize = true;
		F52C1436.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F52C1436.Location = new System.Drawing.Point(430, 161);
		F52C1436.Name = "label35";
		F52C1436.Size = new System.Drawing.Size(32, 16);
		F52C1436.TabIndex = 139;
		F52C1436.Text = "phút";
		EF10790C.Anchor = System.Windows.Forms.AnchorStyles.None;
		EF10790C.AutoSize = true;
		EF10790C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		EF10790C.Location = new System.Drawing.Point(251, 86);
		EF10790C.Name = "label40";
		EF10790C.Size = new System.Drawing.Size(78, 16);
		EF10790C.TabIndex = 139;
		EF10790C.Text = "Số luồng/IP:";
		nudLuongPerIPObcProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudLuongPerIPObcProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudLuongPerIPObcProxy.Location = new System.Drawing.Point(336, 85);
		nudLuongPerIPObcProxy.Name = "nudLuongPerIPObcProxy";
		nudLuongPerIPObcProxy.Size = new System.Drawing.Size(67, 23);
		nudLuongPerIPObcProxy.TabIndex = 140;
		nudLuongPerIPObcProxy.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label39.Anchor = System.Windows.Forms.AnchorStyles.None;
		label39.AutoSize = true;
		label39.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label39.Location = new System.Drawing.Point(251, 161);
		label39.Name = "label39";
		label39.Size = new System.Drawing.Size(123, 16);
		label39.TabIndex = 139;
		label39.Text = "Chờ Check IP tối đa:";
		label41.Anchor = System.Windows.Forms.AnchorStyles.None;
		label41.AutoSize = true;
		label41.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label41.Location = new System.Drawing.Point(13, 38);
		label41.Name = "label41";
		label41.Size = new System.Drawing.Size(64, 16);
		label41.TabIndex = 79;
		label41.Text = "Link Web:";
		nudDelayCheckIPObcProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudDelayCheckIPObcProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudDelayCheckIPObcProxy.Location = new System.Drawing.Point(377, 159);
		nudDelayCheckIPObcProxy.Name = "nudDelayCheckIPObcProxy";
		nudDelayCheckIPObcProxy.Size = new System.Drawing.Size(50, 23);
		nudDelayCheckIPObcProxy.TabIndex = 140;
		nudDelayCheckIPObcProxy.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		txtLinkWebObcProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtLinkWebObcProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtLinkWebObcProxy.ForeColor = System.Drawing.Color.Black;
		txtLinkWebObcProxy.Location = new System.Drawing.Point(100, 35);
		txtLinkWebObcProxy.Name = "txtLinkWebObcProxy";
		txtLinkWebObcProxy.Size = new System.Drawing.Size(363, 23);
		txtLinkWebObcProxy.TabIndex = 81;
		tabProxyV6.Controls.Add(BF84E596);
		tabProxyV6.Location = new System.Drawing.Point(4, 4);
		tabProxyV6.Name = "tabProxyV6";
		tabProxyV6.Padding = new System.Windows.Forms.Padding(3);
		tabProxyV6.Size = new System.Drawing.Size(487, 209);
		tabProxyV6.TabIndex = 4;
		tabProxyV6.Text = "https://proxyv6.net/vi";
		tabProxyV6.UseVisualStyleBackColor = true;
		BF84E596.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BF84E596.Controls.Add(txtListProxyv6);
		BF84E596.Controls.Add(AAAE12A7);
		BF84E596.Controls.Add(BD0D4690);
		BF84E596.Controls.Add(nudLuongPerIPProxyv6);
		BF84E596.Controls.Add(label45);
		BF84E596.Controls.Add(txtApiProxyv6);
		BF84E596.Dock = System.Windows.Forms.DockStyle.Fill;
		BF84E596.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		BF84E596.Location = new System.Drawing.Point(3, 3);
		BF84E596.Name = "plProxyv6";
		BF84E596.Size = new System.Drawing.Size(481, 203);
		BF84E596.TabIndex = 155;
		txtListProxyv6.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtListProxyv6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtListProxyv6.Location = new System.Drawing.Point(88, 93);
		txtListProxyv6.Name = "txtListProxyv6";
		txtListProxyv6.Size = new System.Drawing.Size(309, 92);
		txtListProxyv6.TabIndex = 144;
		txtListProxyv6.Text = "";
		txtListProxyv6.WordWrap = false;
		txtListProxyv6.TextChanged += new System.EventHandler(txtListProxyv6_TextChanged);
		AAAE12A7.Anchor = System.Windows.Forms.AnchorStyles.None;
		AAAE12A7.AutoSize = true;
		AAAE12A7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		AAAE12A7.Location = new System.Drawing.Point(85, 74);
		AAAE12A7.Name = "label43";
		AAAE12A7.Size = new System.Drawing.Size(97, 16);
		AAAE12A7.TabIndex = 79;
		AAAE12A7.Text = "Nhập Proxy (0):";
		BD0D4690.Anchor = System.Windows.Forms.AnchorStyles.None;
		BD0D4690.AutoSize = true;
		BD0D4690.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		BD0D4690.Location = new System.Drawing.Point(87, 189);
		BD0D4690.Name = "label44";
		BD0D4690.Size = new System.Drawing.Size(78, 16);
		BD0D4690.TabIndex = 139;
		BD0D4690.Text = "Số luồng/IP:";
		nudLuongPerIPProxyv6.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudLuongPerIPProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudLuongPerIPProxyv6.Location = new System.Drawing.Point(172, 188);
		nudLuongPerIPProxyv6.Name = "nudLuongPerIPProxyv6";
		nudLuongPerIPProxyv6.Size = new System.Drawing.Size(67, 23);
		nudLuongPerIPProxyv6.TabIndex = 140;
		nudLuongPerIPProxyv6.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label45.Anchor = System.Windows.Forms.AnchorStyles.None;
		label45.AutoSize = true;
		label45.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label45.Location = new System.Drawing.Point(85, 51);
		label45.Name = "label45";
		label45.Size = new System.Drawing.Size(55, 16);
		label45.TabIndex = 79;
		label45.Text = "API Key:";
		txtApiProxyv6.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtApiProxyv6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		txtApiProxyv6.ForeColor = System.Drawing.Color.Black;
		txtApiProxyv6.Location = new System.Drawing.Point(157, 48);
		txtApiProxyv6.Name = "txtApiProxyv6";
		txtApiProxyv6.Size = new System.Drawing.Size(240, 23);
		txtApiProxyv6.TabIndex = 81;
		A7848002.Controls.Add(B696502E);
		A7848002.Location = new System.Drawing.Point(4, 4);
		A7848002.Name = "tabProxyShopLike";
		A7848002.Padding = new System.Windows.Forms.Padding(3);
		A7848002.Size = new System.Drawing.Size(487, 209);
		A7848002.TabIndex = 5;
		A7848002.Text = "http://proxy.shoplike.vn/";
		A7848002.UseVisualStyleBackColor = true;
		B696502E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B696502E.Controls.Add(txtApiShopLike);
		B696502E.Controls.Add(label47);
		B696502E.Controls.Add(label48);
		B696502E.Controls.Add(nudLuongPerIPShopLike);
		B696502E.Dock = System.Windows.Forms.DockStyle.Fill;
		B696502E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B696502E.Location = new System.Drawing.Point(3, 3);
		B696502E.Name = "plShopLike";
		B696502E.Size = new System.Drawing.Size(481, 203);
		B696502E.TabIndex = 157;
		txtApiShopLike.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtApiShopLike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtApiShopLike.Location = new System.Drawing.Point(93, 75);
		txtApiShopLike.Name = "txtApiShopLike";
		txtApiShopLike.Size = new System.Drawing.Size(309, 100);
		txtApiShopLike.TabIndex = 144;
		txtApiShopLike.Text = "";
		txtApiShopLike.WordWrap = false;
		txtApiShopLike.TextChanged += new System.EventHandler(A58ED52F);
		label47.Anchor = System.Windows.Forms.AnchorStyles.None;
		label47.AutoSize = true;
		label47.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label47.Location = new System.Drawing.Point(90, 55);
		label47.Name = "label47";
		label47.Size = new System.Drawing.Size(110, 16);
		label47.TabIndex = 79;
		label47.Text = "Nhập API KEY (0):";
		label48.Anchor = System.Windows.Forms.AnchorStyles.None;
		label48.AutoSize = true;
		label48.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label48.Location = new System.Drawing.Point(91, 182);
		label48.Name = "label48";
		label48.Size = new System.Drawing.Size(78, 16);
		label48.TabIndex = 139;
		label48.Text = "Số luồng/IP:";
		nudLuongPerIPShopLike.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudLuongPerIPShopLike.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudLuongPerIPShopLike.Location = new System.Drawing.Point(176, 179);
		nudLuongPerIPShopLike.Name = "nudLuongPerIPShopLike";
		nudLuongPerIPShopLike.Size = new System.Drawing.Size(67, 23);
		nudLuongPerIPShopLike.TabIndex = 140;
		nudLuongPerIPShopLike.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		tabTMProxy.Controls.Add(A908042A);
		tabTMProxy.Location = new System.Drawing.Point(4, 4);
		tabTMProxy.Name = "tabTMProxy";
		tabTMProxy.Padding = new System.Windows.Forms.Padding(3);
		tabTMProxy.Size = new System.Drawing.Size(487, 209);
		tabTMProxy.TabIndex = 6;
		tabTMProxy.Text = "https://tmproxy.com/";
		tabTMProxy.UseVisualStyleBackColor = true;
		A908042A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A908042A.Controls.Add(BFBAC297);
		A908042A.Controls.Add(txtApiKeyTMProxy);
		A908042A.Controls.Add(label24);
		A908042A.Controls.Add(button8);
		A908042A.Controls.Add(label25);
		A908042A.Controls.Add(BB07EF37);
		A908042A.Dock = System.Windows.Forms.DockStyle.Fill;
		A908042A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A908042A.Location = new System.Drawing.Point(3, 3);
		A908042A.Name = "plTMProxy";
		A908042A.Size = new System.Drawing.Size(481, 203);
		A908042A.TabIndex = 146;
		A908042A.Click += new System.EventHandler(BC8FC2B6);
		BFBAC297.Anchor = System.Windows.Forms.AnchorStyles.None;
		BFBAC297.AutoSize = true;
		BFBAC297.Cursor = System.Windows.Forms.Cursors.Hand;
		BFBAC297.Location = new System.Drawing.Point(229, 54);
		BFBAC297.Name = "ckbWaitDoneAllTMProxy";
		BFBAC297.Size = new System.Drawing.Size(128, 20);
		BFBAC297.TabIndex = 145;
		BFBAC297.Text = "Đợi chạy xong hết";
		BFBAC297.UseVisualStyleBackColor = true;
		BFBAC297.Visible = false;
		txtApiKeyTMProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtApiKeyTMProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtApiKeyTMProxy.Location = new System.Drawing.Point(61, 75);
		txtApiKeyTMProxy.Name = "txtApiKeyTMProxy";
		txtApiKeyTMProxy.Size = new System.Drawing.Size(363, 100);
		txtApiKeyTMProxy.TabIndex = 144;
		txtApiKeyTMProxy.Text = "";
		txtApiKeyTMProxy.WordWrap = false;
		txtApiKeyTMProxy.TextChanged += new System.EventHandler(txtApiKeyTMProxy_TextChanged);
		label24.Anchor = System.Windows.Forms.AnchorStyles.None;
		label24.AutoSize = true;
		label24.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label24.Location = new System.Drawing.Point(58, 55);
		label24.Name = "label24";
		label24.Size = new System.Drawing.Size(110, 16);
		label24.TabIndex = 79;
		label24.Text = "Nhập API KEY (0):";
		button8.Anchor = System.Windows.Forms.AnchorStyles.None;
		button8.Cursor = System.Windows.Forms.Cursors.Hand;
		button8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		button8.ForeColor = System.Drawing.Color.Black;
		button8.Location = new System.Drawing.Point(372, 177);
		button8.Name = "button8";
		button8.Size = new System.Drawing.Size(52, 27);
		button8.TabIndex = 143;
		button8.Text = "Check";
		button8.UseVisualStyleBackColor = true;
		button8.Click += new System.EventHandler(C61CAAA1);
		label25.Anchor = System.Windows.Forms.AnchorStyles.None;
		label25.AutoSize = true;
		label25.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label25.Location = new System.Drawing.Point(59, 182);
		label25.Name = "label25";
		label25.Size = new System.Drawing.Size(78, 16);
		label25.TabIndex = 139;
		label25.Text = "Số luồng/IP:";
		BB07EF37.Anchor = System.Windows.Forms.AnchorStyles.None;
		BB07EF37.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		BB07EF37.Location = new System.Drawing.Point(144, 181);
		BB07EF37.Name = "nudLuongPerIPTMProxy";
		BB07EF37.Size = new System.Drawing.Size(67, 23);
		BB07EF37.TabIndex = 140;
		BB07EF37.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		FC84E1AE.Controls.Add(panel5);
		FC84E1AE.Location = new System.Drawing.Point(4, 4);
		FC84E1AE.Name = "tabNone";
		FC84E1AE.Padding = new System.Windows.Forms.Padding(3);
		FC84E1AE.Size = new System.Drawing.Size(487, 209);
		FC84E1AE.TabIndex = 7;
		FC84E1AE.Text = "tabPage1";
		FC84E1AE.UseVisualStyleBackColor = true;
		panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel5.Dock = System.Windows.Forms.DockStyle.Fill;
		panel5.Location = new System.Drawing.Point(3, 3);
		panel5.Name = "panel5";
		panel5.Size = new System.Drawing.Size(481, 203);
		panel5.TabIndex = 0;
		AB344289.Controls.Add(C00C431C);
		AB344289.Location = new System.Drawing.Point(4, 4);
		AB344289.Name = "tabMinProxy";
		AB344289.Padding = new System.Windows.Forms.Padding(3);
		AB344289.Size = new System.Drawing.Size(487, 209);
		AB344289.TabIndex = 8;
		AB344289.Text = "https://minproxy.vn/";
		AB344289.UseVisualStyleBackColor = true;
		C00C431C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C00C431C.Controls.Add(label42);
		C00C431C.Controls.Add(plTypeProxy);
		C00C431C.Controls.Add(label56);
		C00C431C.Controls.Add(rbProxyDanCu);
		C00C431C.Controls.Add(rbProxyDong);
		C00C431C.Controls.Add(button10);
		C00C431C.Controls.Add(txtApiKeyMinProxy);
		C00C431C.Controls.Add(label49);
		C00C431C.Controls.Add(nudLuongPerIPMinProxy);
		C00C431C.Dock = System.Windows.Forms.DockStyle.Fill;
		C00C431C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C00C431C.Location = new System.Drawing.Point(3, 3);
		C00C431C.Name = "panel6";
		C00C431C.Size = new System.Drawing.Size(481, 203);
		C00C431C.TabIndex = 154;
		label42.Anchor = System.Windows.Forms.AnchorStyles.None;
		label42.AutoSize = true;
		label42.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label42.Location = new System.Drawing.Point(86, 202);
		label42.Name = "label42";
		label42.Size = new System.Drawing.Size(78, 16);
		label42.TabIndex = 166;
		label42.Text = "Số luồng/IP:";
		plTypeProxy.Controls.Add(rbHttpv6);
		plTypeProxy.Controls.Add(rbHttpv4);
		plTypeProxy.Enabled = false;
		plTypeProxy.Location = new System.Drawing.Point(149, 24);
		plTypeProxy.Name = "plTypeProxy";
		plTypeProxy.Size = new System.Drawing.Size(142, 25);
		plTypeProxy.TabIndex = 165;
		rbHttpv6.AutoSize = true;
		rbHttpv6.Cursor = System.Windows.Forms.Cursors.Hand;
		rbHttpv6.Location = new System.Drawing.Point(74, 2);
		rbHttpv6.Name = "rbHttpv6";
		rbHttpv6.Size = new System.Drawing.Size(63, 20);
		rbHttpv6.TabIndex = 161;
		rbHttpv6.Text = "HttpV6";
		rbHttpv6.UseVisualStyleBackColor = true;
		rbHttpv4.AutoSize = true;
		rbHttpv4.Checked = true;
		rbHttpv4.Cursor = System.Windows.Forms.Cursors.Hand;
		rbHttpv4.Location = new System.Drawing.Point(2, 2);
		rbHttpv4.Name = "rbHttpv4";
		rbHttpv4.Size = new System.Drawing.Size(63, 20);
		rbHttpv4.TabIndex = 160;
		rbHttpv4.TabStop = true;
		rbHttpv4.Text = "HttpV4";
		rbHttpv4.UseVisualStyleBackColor = true;
		label56.AutoSize = true;
		label56.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label56.Location = new System.Drawing.Point(76, 28);
		label56.Name = "label56";
		label56.Size = new System.Drawing.Size(70, 16);
		label56.TabIndex = 155;
		label56.Text = "Loại Proxy:";
		rbProxyDanCu.AutoSize = true;
		rbProxyDanCu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbProxyDanCu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbProxyDanCu.Location = new System.Drawing.Point(198, 4);
		rbProxyDanCu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbProxyDanCu.Name = "rbProxyDanCu";
		rbProxyDanCu.Size = new System.Drawing.Size(99, 20);
		rbProxyDanCu.TabIndex = 164;
		rbProxyDanCu.Text = "Proxy dân cư";
		rbProxyDanCu.UseVisualStyleBackColor = true;
		rbProxyDanCu.CheckedChanged += new System.EventHandler(rbProxyDanCu_CheckedChanged);
		rbProxyDong.AutoSize = true;
		rbProxyDong.Checked = true;
		rbProxyDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbProxyDong.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbProxyDong.Location = new System.Drawing.Point(79, 4);
		rbProxyDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbProxyDong.Name = "rbProxyDong";
		rbProxyDong.Size = new System.Drawing.Size(107, 20);
		rbProxyDong.TabIndex = 163;
		rbProxyDong.TabStop = true;
		rbProxyDong.Text = "Proxy V6 động";
		rbProxyDong.UseVisualStyleBackColor = true;
		button10.Anchor = System.Windows.Forms.AnchorStyles.None;
		button10.Cursor = System.Windows.Forms.Cursors.Hand;
		button10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		button10.ForeColor = System.Drawing.Color.Black;
		button10.Location = new System.Drawing.Point(346, 198);
		button10.Name = "button10";
		button10.Size = new System.Drawing.Size(52, 27);
		button10.TabIndex = 162;
		button10.Text = "Check";
		button10.UseVisualStyleBackColor = true;
		button10.Click += new System.EventHandler(EA10699A);
		txtApiKeyMinProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		txtApiKeyMinProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtApiKeyMinProxy.Location = new System.Drawing.Point(89, 101);
		txtApiKeyMinProxy.Name = "txtApiKeyMinProxy";
		txtApiKeyMinProxy.Size = new System.Drawing.Size(309, 95);
		txtApiKeyMinProxy.TabIndex = 161;
		txtApiKeyMinProxy.Text = "";
		txtApiKeyMinProxy.WordWrap = false;
		txtApiKeyMinProxy.TextChanged += new System.EventHandler(txtApiKeyMinProxy_TextChanged);
		label49.Anchor = System.Windows.Forms.AnchorStyles.None;
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(86, 82);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(110, 16);
		label49.TabIndex = 159;
		label49.Text = "Nhập API KEY (0):";
		nudLuongPerIPMinProxy.Anchor = System.Windows.Forms.AnchorStyles.None;
		nudLuongPerIPMinProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudLuongPerIPMinProxy.Location = new System.Drawing.Point(171, 200);
		nudLuongPerIPMinProxy.Name = "nudLuongPerIPMinProxy";
		nudLuongPerIPMinProxy.Size = new System.Drawing.Size(67, 23);
		nudLuongPerIPMinProxy.TabIndex = 160;
		nudLuongPerIPMinProxy.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		D7B048B6.AutoSize = true;
		D7B048B6.Cursor = System.Windows.Forms.Cursors.Hand;
		D7B048B6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D7B048B6.Location = new System.Drawing.Point(21, 79);
		D7B048B6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		D7B048B6.Name = "rbProxy";
		D7B048B6.Size = new System.Drawing.Size(266, 20);
		D7B048B6.TabIndex = 136;
		D7B048B6.Text = "Sử dụng Proxy (đã gán cho mỗi tài khoản)";
		D7B048B6.UseVisualStyleBackColor = true;
		D7B048B6.CheckedChanged += new System.EventHandler(D7B048B6_CheckedChanged);
		rbNone.AutoSize = true;
		rbNone.Checked = true;
		rbNone.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNone.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbNone.Location = new System.Drawing.Point(21, 23);
		rbNone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbNone.Name = "rbNone";
		rbNone.Size = new System.Drawing.Size(96, 20);
		rbNone.TabIndex = 136;
		rbNone.TabStop = true;
		rbNone.Text = "Không đổi IP";
		rbNone.UseVisualStyleBackColor = true;
		rbNone.CheckedChanged += new System.EventHandler(CDAE55AD);
		ckbKhongCheckIP.AutoSize = true;
		ckbKhongCheckIP.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbKhongCheckIP.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbKhongCheckIP.Location = new System.Drawing.Point(319, 24);
		ckbKhongCheckIP.Name = "ckbKhongCheckIP";
		ckbKhongCheckIP.Size = new System.Drawing.Size(198, 20);
		ckbKhongCheckIP.TabIndex = 112;
		ckbKhongCheckIP.Text = "Không Check IP trước khi chạy";
		ckbKhongCheckIP.UseVisualStyleBackColor = true;
		rbXproxy.AutoSize = true;
		rbXproxy.Cursor = System.Windows.Forms.Cursors.Hand;
		rbXproxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		rbXproxy.Location = new System.Drawing.Point(21, 107);
		rbXproxy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		rbXproxy.Name = "rbXproxy";
		rbXproxy.Size = new System.Drawing.Size(64, 20);
		rbXproxy.TabIndex = 138;
		rbXproxy.Text = "Xproxy";
		rbXproxy.UseVisualStyleBackColor = true;
		rbXproxy.CheckedChanged += new System.EventHandler(D70AEC3E);
		C1B491B5.Fixed = true;
		C1B491B5.Horizontal = true;
		C1B491B5.TargetControl = bunifuCustomLabel1;
		C1B491B5.Vertical = true;
		C59DF58E.AutomaticDelay = 0;
		C59DF58E.AutoPopDelay = 10000;
		C59DF58E.InitialDelay = 200;
		C59DF58E.ReshowDelay = 40;
		BB975F11.AutoSize = true;
		BB975F11.Cursor = System.Windows.Forms.Cursors.Hand;
		BB975F11.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BB975F11.Location = new System.Drawing.Point(324, 52);
		BB975F11.Name = "ckbRemoveAccountsInSettings";
		BB975F11.Size = new System.Drawing.Size(191, 20);
		BB975F11.TabIndex = 112;
		BB975F11.Text = "Remove Accounts in Settings";
		BB975F11.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(551, 654);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhChung";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fCauHinhChung_Load);
		((System.ComponentModel.ISupportInitialize)EC086238).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		groupBox4.ResumeLayout(false);
		groupBox4.PerformLayout();
		plChangeDevice.ResumeLayout(false);
		plChangeDevice.PerformLayout();
		E30BFE8A.ResumeLayout(false);
		E30BFE8A.PerformLayout();
		((System.ComponentModel.ISupportInitialize)FB2C7495).EndInit();
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		D8B05C8D.ResumeLayout(false);
		D8B05C8D.PerformLayout();
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		C5B61B17.ResumeLayout(false);
		C5B61B17.PerformLayout();
		D02CE704.ResumeLayout(false);
		D02CE704.PerformLayout();
		plDongBoMaxCare.ResumeLayout(false);
		plDongBoMaxCare.PerformLayout();
		DC158F12.ResumeLayout(false);
		DC158F12.PerformLayout();
		((System.ComponentModel.ISupportInitialize)A499EB0E).EndInit();
		tabChangeIP.ResumeLayout(false);
		tabDcom.ResumeLayout(false);
		plDcom.ResumeLayout(false);
		plDcom.PerformLayout();
		E92DE81F.ResumeLayout(false);
		plTinsoft.ResumeLayout(false);
		plTinsoft.PerformLayout();
		plApiProxy.ResumeLayout(false);
		plApiProxy.PerformLayout();
		D599320F.ResumeLayout(false);
		D599320F.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPTinsoft).EndInit();
		tabXProxy.ResumeLayout(false);
		A69C8A9A.ResumeLayout(false);
		A69C8A9A.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayConnectXproxy).EndInit();
		DC9FCF2C.ResumeLayout(false);
		CFB60F91.ResumeLayout(false);
		CFB60F91.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPObcProxy).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayCheckIPObcProxy).EndInit();
		tabProxyV6.ResumeLayout(false);
		BF84E596.ResumeLayout(false);
		BF84E596.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPProxyv6).EndInit();
		A7848002.ResumeLayout(false);
		B696502E.ResumeLayout(false);
		B696502E.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPShopLike).EndInit();
		tabTMProxy.ResumeLayout(false);
		A908042A.ResumeLayout(false);
		A908042A.PerformLayout();
		((System.ComponentModel.ISupportInitialize)BB07EF37).EndInit();
		FC84E1AE.ResumeLayout(false);
		AB344289.ResumeLayout(false);
		C00C431C.ResumeLayout(false);
		C00C431C.PerformLayout();
		plTypeProxy.ResumeLayout(false);
		plTypeProxy.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudLuongPerIPMinProxy).EndInit();
		ResumeLayout(false);
	}
}
