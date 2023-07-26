using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBuffTinNhanProfile : Form
{
	internal JSON_Settings AD80EB0A;

	internal string FB005816;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl D102B527;

	internal BunifuDragControl E2895902;

	internal Panel panel1;

	internal NumericUpDown FBA2C09F;

	internal NumericUpDown nudDelayFrom;

	internal TextBox txtTenHanhDong;

	internal Label A5A1591D;

	internal Label label6;

	internal Label CA8972B9;

	internal Label B8B354AD;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel F5A15532;

	internal Button AFB72E3E;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel F497230F;

	internal Panel CF25A7A0;

	internal Label C5A46E9C;

	internal Label lblStatus;

	internal CheckBox EE353027;

	internal Label label49;

	internal NumericUpDown nudSoLuongUidFrom;

	internal Label label68;

	internal NumericUpDown AB28FCAC;

	internal Label label66;

	internal Label C7BD1F8B;

	internal Label lblStatusUid;

	internal RichTextBox txtUid;

	internal Panel plAnh;

	internal CheckBox ckbSendAnh;

	internal RichTextBox txtNoiDung;

	internal CheckBox EA2F55B8;

	internal ToolTip toolTip_0;

	internal Label label3;

	internal Label label4;

	internal Label label9;

	internal NumericUpDown nudSoLuongAnhFrom;

	internal NumericUpDown nudSoLuongAnhTo;

	internal Button btnDown;

	internal Button btnUp;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton D32E06A3;

	internal Label label11;

	internal Panel C8A52024;

	internal CheckBox DEB78713;

	internal CheckBox C683F73B;

	internal CheckBox ckbTuongTacKhiNhanTin;

	internal Panel plTuongTacTruocKhiNhanTinComment;

	internal RadioButton ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong;

	internal RadioButton ckbTuongTacKhiNhanTinCommentNoiDung1Dong;

	internal Label label12;

	internal RichTextBox D9B7A52A;

	internal Label label13;

	internal Label DE27FF80;

	internal RadioButton rbTuongTacSauKhiNhanTin;

	internal RadioButton rbTuongTacTruocKhiNhanTin;

	internal Label BF8CD9AE;

	internal Label label16;

	internal Label FFA7EE11;

	internal TextBox txtAnh;

	public fHDBuffTinNhanProfile(string string_2, int F12B7923 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		FB005816 = string_2;
		string_1 = string_3;
		int_0 = F12B7923;
		if (Class123.C7BE863B("", "HDBuffTinNhanProfile").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBuffTinNhanProfile', '{  \"nudSoLuongUidFrom\": \"1\",  \"nudSoLuongUidTo\": \"3\", \"nudSoLuongAnhFrom\": \"1\", \"nudSoLuongAnhTo\": \"1\",  \"nudDelayFrom\": \"3\",  \"nudDelayTo\": \"5\",  \"txtUid\": \"\",  \"ckbNhanTinVanBan\": \"True\",  \"txtNoiDung\": \"hello\",  \"ckbSendAnh\": \"False\",  \"txtAnh\": \"\",  \"ckbTuDongXoaUid\": \"False\"}', 'Buff Tin nhắn Profile');");
		}
		string d399C = "";
		switch (F12B7923)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDBuffTinNhanProfile");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
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
		AD80EB0A = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void A31A1B29()
	{
		Language.smethod_1(F497230F);
		Language.smethod_1(B8B354AD);
		Language.smethod_1(label49);
		Language.smethod_1(label66);
		Language.smethod_1(CA8972B9);
		Language.smethod_1(A5A1591D);
		Language.smethod_1(label6);
		Language.smethod_1(lblStatusUid);
		Language.smethod_1(C7BD1F8B);
		Language.smethod_1(EA2F55B8);
		Language.smethod_1(EE353027);
		Language.smethod_1(lblStatus);
		Language.smethod_1(C5A46E9C);
		Language.smethod_1(ckbSendAnh);
		Language.smethod_1(FFA7EE11);
		Language.smethod_1(label3);
		Language.smethod_1(label9);
		Language.smethod_1(label4);
		Language.smethod_1(ckbTuongTacKhiNhanTin);
		Language.smethod_1(BF8CD9AE);
		Language.smethod_1(rbTuongTacTruocKhiNhanTin);
		Language.smethod_1(rbTuongTacSauKhiNhanTin);
		Language.smethod_1(label16);
		Language.smethod_1(DE27FF80);
		Language.smethod_1(label13);
		Language.smethod_1(label12);
		Language.smethod_1(ckbTuongTacKhiNhanTinCommentNoiDung1Dong);
		Language.smethod_1(ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void fHDBuffTinNhanProfile_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongUidFrom.Value = AD80EB0A.method_0("nudSoLuongUidFrom", 1);
			AB28FCAC.Value = AD80EB0A.method_0("nudSoLuongUidTo", 3);
			nudSoLuongAnhFrom.Value = AD80EB0A.method_0("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = AD80EB0A.method_0("nudSoLuongAnhTo", 1);
			nudDelayFrom.Value = AD80EB0A.method_0("nudDelayFrom", 3);
			FBA2C09F.Value = AD80EB0A.method_0("nudDelayTo", 5);
			txtUid.Text = AD80EB0A.GetValue("txtUid");
			EE353027.Checked = AD80EB0A.AA824D29("ckbNhanTinVanBan");
			txtNoiDung.Text = AD80EB0A.GetValue("txtNoiDung");
			ckbSendAnh.Checked = AD80EB0A.AA824D29("ckbSendAnh");
			txtAnh.Text = AD80EB0A.GetValue("txtAnh");
			ckbTuongTacKhiNhanTin.Checked = AD80EB0A.AA824D29("ckbTuongTacKhiNhanTin");
			if (AD80EB0A.method_0("typeTuongTacKhiNhanTin") == 0)
			{
				rbTuongTacTruocKhiNhanTin.Checked = true;
			}
			else
			{
				rbTuongTacSauKhiNhanTin.Checked = true;
			}
			C683F73B.Checked = AD80EB0A.AA824D29("ckbTuongTacKhiNhanTinLike");
			DEB78713.Checked = AD80EB0A.AA824D29("ckbTuongTacKhiNhanTinComment");
			D9B7A52A.Text = AD80EB0A.GetValue("txtTuongTacKhiNhanTinComment");
			if (AD80EB0A.method_0("typeNganCachComment") == 1)
			{
				ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked = true;
			}
			else
			{
				ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Checked = true;
			}
			EA2F55B8.Checked = AD80EB0A.AA824D29("ckbTuDongXoaUid");
			if (AD80EB0A.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				D32E06A3.Checked = true;
			}
		}
		catch
		{
		}
		C211C884();
	}

	private void FC3EE83B(object sender, EventArgs e)
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
		List<string> f1808BA = txtUid.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid!"), 3);
			return;
		}
		if (EE353027.Checked)
		{
			f1808BA = txtNoiDung.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhắn!"), 3);
				return;
			}
		}
		if (ckbSendAnh.Checked && txtAnh.Text.Trim().Length == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng chọn folder ảnh!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		f72FAFBC.GetValue("nudSoLuongUidTo", AB28FCAC.Value);
		f72FAFBC.GetValue("nudSoLuongAnhFrom", nudSoLuongAnhFrom.Value);
		f72FAFBC.GetValue("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", FBA2C09F.Value);
		f72FAFBC.GetValue("txtUid", (object)txtUid.Text.Trim());
		f72FAFBC.GetValue("ckbNhanTinVanBan", EE353027.Checked);
		f72FAFBC.GetValue("txtNoiDung", (object)txtNoiDung.Text.Trim());
		f72FAFBC.GetValue("ckbSendAnh", ckbSendAnh.Checked);
		f72FAFBC.GetValue("txtAnh", (object)txtAnh.Text.Trim());
		f72FAFBC.GetValue("ckbTuDongXoaUid", EA2F55B8.Checked);
		f72FAFBC.GetValue("ckbTuongTacKhiNhanTin", ckbTuongTacKhiNhanTin.Checked);
		if (rbTuongTacTruocKhiNhanTin.Checked)
		{
			f72FAFBC.GetValue("typeTuongTacKhiNhanTin", 0);
		}
		else
		{
			f72FAFBC.GetValue("typeTuongTacKhiNhanTin", 1);
		}
		f72FAFBC.GetValue("ckbTuongTacKhiNhanTinLike", C683F73B.Checked);
		f72FAFBC.GetValue("ckbTuongTacKhiNhanTinComment", DEB78713.Checked);
		f72FAFBC.GetValue("txtTuongTacKhiNhanTinComment", (object)D9B7A52A.Text.Trim());
		int num = 0;
		if (ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCachComment", num);
		int num2 = 0;
		if (rbNganCachKyTu.Checked)
		{
			num2 = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num2);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(FB005816, text, string_0, text2))
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
			if (Class123.smethod_14(string_1, text, text2))
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

	private void ABA2312F(object sender, EventArgs e)
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

	private void txtNoiDung_TextChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!D32E06A3.Checked) ? txtNoiDung.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtNoiDung.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung tin nhắn ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void C211C884()
	{
		A81651A9(null, null);
		EE353027_CheckedChanged(null, null);
		A527B28E(null, null);
		BF1EE981(null, null);
	}

	private void A81651A9(object sender, EventArgs e)
	{
	}

	private void EE353027_CheckedChanged(object sender, EventArgs e)
	{
		CF25A7A0.Enabled = EE353027.Checked;
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUid.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatusUid.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid ca\u0301 nhân cần nhắn tin ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void B21DCE9F(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbSendAnh.Checked;
	}

	private void E52FC028(object sender, EventArgs e)
	{
		CF25A7A0.Height = 235;
	}

	private void A8A22006(object sender, EventArgs e)
	{
		CF25A7A0.Height = 185;
	}

	private void D32E06A3_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void A12E6FA3(object sender, EventArgs e)
	{
		method_1();
	}

	private void E031BA2B(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void A527B28E(object sender, EventArgs e)
	{
		C8A52024.Enabled = ckbTuongTacKhiNhanTin.Checked;
	}

	private void BF1EE981(object sender, EventArgs e)
	{
		plTuongTacTruocKhiNhanTinComment.Enabled = DEB78713.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBuffTinNhanProfile));
		D102B527 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		F497230F = new Bunifu.Framework.UI.BunifuCustomLabel();
		E2895902 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		F5A15532 = new System.Windows.Forms.Panel();
		AFB72E3E = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		C8A52024 = new System.Windows.Forms.Panel();
		rbTuongTacSauKhiNhanTin = new System.Windows.Forms.RadioButton();
		DEB78713 = new System.Windows.Forms.CheckBox();
		rbTuongTacTruocKhiNhanTin = new System.Windows.Forms.RadioButton();
		BF8CD9AE = new System.Windows.Forms.Label();
		C683F73B = new System.Windows.Forms.CheckBox();
		label16 = new System.Windows.Forms.Label();
		plTuongTacTruocKhiNhanTinComment = new System.Windows.Forms.Panel();
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong = new System.Windows.Forms.RadioButton();
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong = new System.Windows.Forms.RadioButton();
		label12 = new System.Windows.Forms.Label();
		D9B7A52A = new System.Windows.Forms.RichTextBox();
		label13 = new System.Windows.Forms.Label();
		DE27FF80 = new System.Windows.Forms.Label();
		CF25A7A0 = new System.Windows.Forms.Panel();
		btnDown = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		D32E06A3 = new System.Windows.Forms.RadioButton();
		label11 = new System.Windows.Forms.Label();
		txtNoiDung = new System.Windows.Forms.RichTextBox();
		C5A46E9C = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		plAnh = new System.Windows.Forms.Panel();
		FFA7EE11 = new System.Windows.Forms.Label();
		txtAnh = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		nudSoLuongAnhFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongAnhTo = new System.Windows.Forms.NumericUpDown();
		ckbSendAnh = new System.Windows.Forms.CheckBox();
		txtUid = new System.Windows.Forms.RichTextBox();
		C7BD1F8B = new System.Windows.Forms.Label();
		lblStatusUid = new System.Windows.Forms.Label();
		label49 = new System.Windows.Forms.Label();
		nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		label68 = new System.Windows.Forms.Label();
		AB28FCAC = new System.Windows.Forms.NumericUpDown();
		label66 = new System.Windows.Forms.Label();
		ckbTuongTacKhiNhanTin = new System.Windows.Forms.CheckBox();
		EE353027 = new System.Windows.Forms.CheckBox();
		EA2F55B8 = new System.Windows.Forms.CheckBox();
		FBA2C09F = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		A5A1591D = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		CA8972B9 = new System.Windows.Forms.Label();
		B8B354AD = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		F5A15532.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		C8A52024.SuspendLayout();
		plTuongTacTruocKhiNhanTinComment.SuspendLayout();
		CF25A7A0.SuspendLayout();
		plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)AB28FCAC).BeginInit();
		((System.ComponentModel.ISupportInitialize)FBA2C09F).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D102B527.Fixed = true;
		D102B527.Horizontal = true;
		D102B527.TargetControl = F497230F;
		D102B527.Vertical = true;
		F497230F.BackColor = System.Drawing.Color.Transparent;
		F497230F.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F497230F.Dock = System.Windows.Forms.DockStyle.Fill;
		F497230F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F497230F.ForeColor = System.Drawing.Color.Black;
		F497230F.Location = new System.Drawing.Point(0, 0);
		F497230F.Name = "bunifuCustomLabel1";
		F497230F.Size = new System.Drawing.Size(1009, 31);
		F497230F.TabIndex = 12;
		F497230F.Text = "Cấu hình Buff Tin nhắn Profile";
		F497230F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E2895902.Fixed = true;
		E2895902.Horizontal = true;
		E2895902.TargetControl = F5A15532;
		E2895902.Vertical = true;
		F5A15532.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F5A15532.BackColor = System.Drawing.Color.White;
		F5A15532.Controls.Add(AFB72E3E);
		F5A15532.Controls.Add(pictureBox1);
		F5A15532.Controls.Add(F497230F);
		F5A15532.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F5A15532.Location = new System.Drawing.Point(0, 3);
		F5A15532.Name = "pnlHeader";
		F5A15532.Size = new System.Drawing.Size(1009, 31);
		F5A15532.TabIndex = 9;
		AFB72E3E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		AFB72E3E.Cursor = System.Windows.Forms.Cursors.Hand;
		AFB72E3E.FlatAppearance.BorderSize = 0;
		AFB72E3E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AFB72E3E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		AFB72E3E.ForeColor = System.Drawing.Color.White;
		AFB72E3E.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		AFB72E3E.Location = new System.Drawing.Point(978, 1);
		AFB72E3E.Name = "button1";
		AFB72E3E.Size = new System.Drawing.Size(30, 30);
		AFB72E3E.TabIndex = 77;
		AFB72E3E.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		AFB72E3E.UseVisualStyleBackColor = true;
		AFB72E3E.Click += new System.EventHandler(FC3EE83B);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(E031BA2B);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(C8A52024);
		panel1.Controls.Add(CF25A7A0);
		panel1.Controls.Add(plAnh);
		panel1.Controls.Add(ckbSendAnh);
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(C7BD1F8B);
		panel1.Controls.Add(lblStatusUid);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(nudSoLuongUidFrom);
		panel1.Controls.Add(label68);
		panel1.Controls.Add(AB28FCAC);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(ckbTuongTacKhiNhanTin);
		panel1.Controls.Add(EE353027);
		panel1.Controls.Add(EA2F55B8);
		panel1.Controls.Add(FBA2C09F);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(A5A1591D);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(CA8972B9);
		panel1.Controls.Add(B8B354AD);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(1012, 416);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		C8A52024.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C8A52024.Controls.Add(rbTuongTacSauKhiNhanTin);
		C8A52024.Controls.Add(DEB78713);
		C8A52024.Controls.Add(rbTuongTacTruocKhiNhanTin);
		C8A52024.Controls.Add(BF8CD9AE);
		C8A52024.Controls.Add(C683F73B);
		C8A52024.Controls.Add(label16);
		C8A52024.Controls.Add(plTuongTacTruocKhiNhanTinComment);
		C8A52024.Enabled = false;
		C8A52024.Location = new System.Drawing.Point(688, 75);
		C8A52024.Name = "plTuongTacTruocKhiNhanTin";
		C8A52024.Size = new System.Drawing.Size(297, 272);
		C8A52024.TabIndex = 163;
		rbTuongTacSauKhiNhanTin.AutoSize = true;
		rbTuongTacSauKhiNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		rbTuongTacSauKhiNhanTin.Location = new System.Drawing.Point(77, 28);
		rbTuongTacSauKhiNhanTin.Name = "rbTuongTacSauKhiNhanTin";
		rbTuongTacSauKhiNhanTin.Size = new System.Drawing.Size(178, 20);
		rbTuongTacSauKhiNhanTin.TabIndex = 105;
		rbTuongTacSauKhiNhanTin.Text = "Tương tác sau khi nhắn tin";
		rbTuongTacSauKhiNhanTin.UseVisualStyleBackColor = true;
		DEB78713.AutoSize = true;
		DEB78713.Cursor = System.Windows.Forms.Cursors.Hand;
		DEB78713.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		DEB78713.Location = new System.Drawing.Point(161, 52);
		DEB78713.Name = "ckbTuongTacKhiNhanTinComment";
		DEB78713.Size = new System.Drawing.Size(82, 20);
		DEB78713.TabIndex = 96;
		DEB78713.Text = "Comment";
		DEB78713.UseVisualStyleBackColor = true;
		DEB78713.CheckedChanged += new System.EventHandler(BF1EE981);
		rbTuongTacTruocKhiNhanTin.AutoSize = true;
		rbTuongTacTruocKhiNhanTin.Checked = true;
		rbTuongTacTruocKhiNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		rbTuongTacTruocKhiNhanTin.Location = new System.Drawing.Point(77, 6);
		rbTuongTacTruocKhiNhanTin.Name = "rbTuongTacTruocKhiNhanTin";
		rbTuongTacTruocKhiNhanTin.Size = new System.Drawing.Size(188, 20);
		rbTuongTacTruocKhiNhanTin.TabIndex = 106;
		rbTuongTacTruocKhiNhanTin.TabStop = true;
		rbTuongTacTruocKhiNhanTin.Text = "Tương tác trước khi nhắn tin";
		rbTuongTacTruocKhiNhanTin.UseVisualStyleBackColor = true;
		BF8CD9AE.AutoSize = true;
		BF8CD9AE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		BF8CD9AE.Location = new System.Drawing.Point(6, 8);
		BF8CD9AE.Name = "label15";
		BF8CD9AE.Size = new System.Drawing.Size(65, 16);
		BF8CD9AE.TabIndex = 103;
		BF8CD9AE.Text = "Tùy chọn:";
		C683F73B.AutoSize = true;
		C683F73B.Cursor = System.Windows.Forms.Cursors.Hand;
		C683F73B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C683F73B.Location = new System.Drawing.Point(106, 52);
		C683F73B.Name = "ckbTuongTacKhiNhanTinLike";
		C683F73B.Size = new System.Drawing.Size(49, 20);
		C683F73B.TabIndex = 95;
		C683F73B.Text = "Like";
		C683F73B.UseVisualStyleBackColor = true;
		label16.AutoSize = true;
		label16.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label16.Location = new System.Drawing.Point(6, 53);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(94, 16);
		label16.TabIndex = 104;
		label16.Text = "Loa\u0323i tương ta\u0301c:";
		plTuongTacTruocKhiNhanTinComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuongTacTruocKhiNhanTinComment.Controls.Add(ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong);
		plTuongTacTruocKhiNhanTinComment.Controls.Add(ckbTuongTacKhiNhanTinCommentNoiDung1Dong);
		plTuongTacTruocKhiNhanTinComment.Controls.Add(label12);
		plTuongTacTruocKhiNhanTinComment.Controls.Add(D9B7A52A);
		plTuongTacTruocKhiNhanTinComment.Controls.Add(label13);
		plTuongTacTruocKhiNhanTinComment.Controls.Add(DE27FF80);
		plTuongTacTruocKhiNhanTinComment.Location = new System.Drawing.Point(9, 75);
		plTuongTacTruocKhiNhanTinComment.Name = "plTuongTacTruocKhiNhanTinComment";
		plTuongTacTruocKhiNhanTinComment.Size = new System.Drawing.Size(281, 191);
		plTuongTacTruocKhiNhanTinComment.TabIndex = 101;
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.AutoSize = true;
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Location = new System.Drawing.Point(70, 164);
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Name = "ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong";
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Size = new System.Drawing.Size(203, 20);
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.TabIndex = 3;
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.Text = "Các nội dung ngăn cách bởi \"|\"";
		ckbTuongTacKhiNhanTinCommentNoiDungNhieuDong.UseVisualStyleBackColor = true;
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong.AutoSize = true;
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Checked = true;
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Location = new System.Drawing.Point(70, 143);
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Name = "ckbTuongTacKhiNhanTinCommentNoiDung1Dong";
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Size = new System.Drawing.Size(171, 20);
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong.TabIndex = 3;
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong.TabStop = true;
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong.Text = "Mỗi dòng là một nội dung";
		ckbTuongTacKhiNhanTinCommentNoiDung1Dong.UseVisualStyleBackColor = true;
		label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(5, 143);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(65, 16);
		label12.TabIndex = 2;
		label12.Text = "Tùy chọn:";
		D9B7A52A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D9B7A52A.Location = new System.Drawing.Point(7, 23);
		D9B7A52A.Name = "txtTuongTacKhiNhanTinComment";
		D9B7A52A.Size = new System.Drawing.Size(263, 97);
		D9B7A52A.TabIndex = 1;
		D9B7A52A.Text = "";
		D9B7A52A.WordWrap = false;
		label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(4, 123);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(268, 16);
		label13.TabIndex = 0;
		label13.Text = "(Spin nội dung {a|b|c} - [u]: Họ tên của UID)";
		DE27FF80.AutoSize = true;
		DE27FF80.Location = new System.Drawing.Point(3, 3);
		DE27FF80.Name = "label14";
		DE27FF80.Size = new System.Drawing.Size(119, 16);
		DE27FF80.TabIndex = 0;
		DE27FF80.Text = "Nội dung bình luận:";
		CF25A7A0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		CF25A7A0.Controls.Add(btnDown);
		CF25A7A0.Controls.Add(btnUp);
		CF25A7A0.Controls.Add(rbNganCachKyTu);
		CF25A7A0.Controls.Add(D32E06A3);
		CF25A7A0.Controls.Add(label11);
		CF25A7A0.Controls.Add(txtNoiDung);
		CF25A7A0.Controls.Add(C5A46E9C);
		CF25A7A0.Controls.Add(lblStatus);
		CF25A7A0.Location = new System.Drawing.Point(369, 75);
		CF25A7A0.Name = "plComment";
		CF25A7A0.Size = new System.Drawing.Size(281, 185);
		CF25A7A0.TabIndex = 10;
		btnDown.BackgroundImage = Resource.Bitmap_91;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.Location = new System.Drawing.Point(224, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 11;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Visible = false;
		btnDown.Click += new System.EventHandler(E52FC028);
		btnUp.BackgroundImage = Resource.Bitmap_73;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.Location = new System.Drawing.Point(255, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 12;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Visible = false;
		btnUp.Click += new System.EventHandler(A8A22006);
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(68, 209);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(203, 20);
		rbNganCachKyTu.TabIndex = 10;
		rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(A12E6FA3);
		D32E06A3.AutoSize = true;
		D32E06A3.Checked = true;
		D32E06A3.Cursor = System.Windows.Forms.Cursors.Hand;
		D32E06A3.Location = new System.Drawing.Point(68, 188);
		D32E06A3.Name = "rbNganCachMoiDong";
		D32E06A3.Size = new System.Drawing.Size(171, 20);
		D32E06A3.TabIndex = 9;
		D32E06A3.TabStop = true;
		D32E06A3.Text = "Mỗi dòng là một nội dung";
		D32E06A3.UseVisualStyleBackColor = true;
		D32E06A3.CheckedChanged += new System.EventHandler(D32E06A3_CheckedChanged);
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(3, 188);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(65, 16);
		label11.TabIndex = 8;
		label11.Text = "Tùy chọn:";
		txtNoiDung.Location = new System.Drawing.Point(7, 24);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new System.Drawing.Size(263, 137);
		txtNoiDung.TabIndex = 1;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += new System.EventHandler(txtNoiDung_TextChanged);
		C5A46E9C.AutoSize = true;
		C5A46E9C.Location = new System.Drawing.Point(4, 163);
		C5A46E9C.Name = "label8";
		C5A46E9C.Size = new System.Drawing.Size(266, 16);
		C5A46E9C.TabIndex = 0;
		C5A46E9C.Text = "(Spin nội dung {a|b|c} - [u]: Họ tên của Uid)";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 3);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(134, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung tin nhắn (0):";
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(FFA7EE11);
		plAnh.Controls.Add(txtAnh);
		plAnh.Controls.Add(label3);
		plAnh.Controls.Add(label4);
		plAnh.Controls.Add(label9);
		plAnh.Controls.Add(nudSoLuongAnhFrom);
		plAnh.Controls.Add(nudSoLuongAnhTo);
		plAnh.Enabled = false;
		plAnh.Location = new System.Drawing.Point(369, 289);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(281, 58);
		plAnh.TabIndex = 162;
		FFA7EE11.AutoSize = true;
		FFA7EE11.Location = new System.Drawing.Point(3, 6);
		FFA7EE11.Name = "label10";
		FFA7EE11.Size = new System.Drawing.Size(138, 16);
		FFA7EE11.TabIndex = 159;
		FFA7EE11.Text = "Đường dẫn folder ảnh:";
		txtAnh.Location = new System.Drawing.Point(143, 3);
		txtAnh.Name = "txtAnh";
		txtAnh.Size = new System.Drawing.Size(133, 23);
		txtAnh.TabIndex = 158;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(3, 31);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(104, 16);
		label3.TabIndex = 34;
		label3.Text = "Số ảnh/tin nhắn:";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(240, 31);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 36;
		label4.Text = "ảnh";
		label9.Location = new System.Drawing.Point(164, 31);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 38;
		label9.Text = "đê\u0301n";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudSoLuongAnhFrom.Location = new System.Drawing.Point(118, 29);
		nudSoLuongAnhFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
		nudSoLuongAnhFrom.Size = new System.Drawing.Size(43, 23);
		nudSoLuongAnhFrom.TabIndex = 5;
		nudSoLuongAnhTo.Location = new System.Drawing.Point(195, 29);
		nudSoLuongAnhTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
		nudSoLuongAnhTo.Size = new System.Drawing.Size(43, 23);
		nudSoLuongAnhTo.TabIndex = 6;
		ckbSendAnh.AutoSize = true;
		ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSendAnh.Location = new System.Drawing.Point(351, 266);
		ckbSendAnh.Name = "ckbSendAnh";
		ckbSendAnh.Size = new System.Drawing.Size(71, 20);
		ckbSendAnh.TabIndex = 161;
		ckbSendAnh.Text = "Gửi ảnh";
		ckbSendAnh.UseVisualStyleBackColor = true;
		ckbSendAnh.CheckedChanged += new System.EventHandler(B21DCE9F);
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(31, 154);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(299, 152);
		txtUid.TabIndex = 117;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		C7BD1F8B.AutoSize = true;
		C7BD1F8B.Location = new System.Drawing.Point(230, 308);
		C7BD1F8B.Name = "label2";
		C7BD1F8B.Size = new System.Drawing.Size(103, 16);
		C7BD1F8B.TabIndex = 115;
		C7BD1F8B.Text = "(Mỗi Uid 1 dòng)";
		lblStatusUid.AutoSize = true;
		lblStatusUid.Location = new System.Drawing.Point(28, 135);
		lblStatusUid.Name = "lblStatusUid";
		lblStatusUid.Size = new System.Drawing.Size(238, 16);
		lblStatusUid.TabIndex = 116;
		lblStatusUid.Text = "Danh sa\u0301ch Uid ca\u0301 nhân cần nhắn tin (0):";
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(27, 81);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(102, 16);
		label49.TabIndex = 92;
		label49.Text = "Sô\u0301 lươ\u0323ng Uid(?):";
		toolTip_0.SetToolTip(label49, "Mỗi tài khoản chỉ nhắn tin được tối đa 50 người tại 1 thời điểm!");
		nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongUidFrom.Location = new System.Drawing.Point(135, 79);
		nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongUidFrom.TabIndex = 1;
		nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label68.AutoSize = true;
		label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label68.Location = new System.Drawing.Point(290, 81);
		label68.Name = "label68";
		label68.Size = new System.Drawing.Size(26, 16);
		label68.TabIndex = 99;
		label68.Text = "Uid";
		AB28FCAC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		AB28FCAC.Location = new System.Drawing.Point(232, 79);
		AB28FCAC.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		AB28FCAC.Name = "nudSoLuongUidTo";
		AB28FCAC.Size = new System.Drawing.Size(56, 23);
		AB28FCAC.TabIndex = 2;
		AB28FCAC.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label66.Location = new System.Drawing.Point(197, 81);
		label66.Name = "label66";
		label66.Size = new System.Drawing.Size(29, 16);
		label66.TabIndex = 105;
		label66.Text = "đê\u0301n";
		label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ckbTuongTacKhiNhanTin.AutoSize = true;
		ckbTuongTacKhiNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuongTacKhiNhanTin.Location = new System.Drawing.Point(670, 51);
		ckbTuongTacKhiNhanTin.Name = "ckbTuongTacKhiNhanTin";
		ckbTuongTacKhiNhanTin.Size = new System.Drawing.Size(155, 20);
		ckbTuongTacKhiNhanTin.TabIndex = 9;
		ckbTuongTacKhiNhanTin.Text = "Tương tác khi nhắn tin";
		ckbTuongTacKhiNhanTin.UseVisualStyleBackColor = true;
		ckbTuongTacKhiNhanTin.CheckedChanged += new System.EventHandler(A527B28E);
		EE353027.AutoSize = true;
		EE353027.Cursor = System.Windows.Forms.Cursors.Hand;
		EE353027.Location = new System.Drawing.Point(351, 51);
		EE353027.Name = "ckbNhanTinVanBan";
		EE353027.Size = new System.Drawing.Size(123, 20);
		EE353027.TabIndex = 9;
		EE353027.Text = "Nhắn tin văn bản";
		EE353027.UseVisualStyleBackColor = true;
		EE353027.CheckedChanged += new System.EventHandler(EE353027_CheckedChanged);
		EA2F55B8.AutoSize = true;
		EA2F55B8.Cursor = System.Windows.Forms.Cursors.Hand;
		EA2F55B8.Location = new System.Drawing.Point(31, 324);
		EA2F55B8.Name = "ckbTuDongXoaUid";
		EA2F55B8.Size = new System.Drawing.Size(296, 20);
		EA2F55B8.TabIndex = 8;
		EA2F55B8.Text = "Tự động xóa Uid đã nhắn tin (Không trùng UID)";
		EA2F55B8.UseVisualStyleBackColor = true;
		FBA2C09F.Location = new System.Drawing.Point(232, 108);
		FBA2C09F.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		FBA2C09F.Name = "nudDelayTo";
		FBA2C09F.Size = new System.Drawing.Size(56, 23);
		FBA2C09F.TabIndex = 6;
		nudDelayFrom.Location = new System.Drawing.Point(135, 108);
		nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		txtTenHanhDong.Location = new System.Drawing.Point(135, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(195, 23);
		txtTenHanhDong.TabIndex = 0;
		A5A1591D.Location = new System.Drawing.Point(197, 110);
		A5A1591D.Name = "label7";
		A5A1591D.Size = new System.Drawing.Size(29, 16);
		A5A1591D.TabIndex = 38;
		A5A1591D.Text = "đê\u0301n";
		A5A1591D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(290, 110);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		CA8972B9.AutoSize = true;
		CA8972B9.Location = new System.Drawing.Point(27, 110);
		CA8972B9.Name = "label5";
		CA8972B9.Size = new System.Drawing.Size(90, 16);
		CA8972B9.TabIndex = 34;
		CA8972B9.Text = "Thơ\u0300i gian chơ\u0300:";
		B8B354AD.AutoSize = true;
		B8B354AD.Location = new System.Drawing.Point(27, 52);
		B8B354AD.Name = "label1";
		B8B354AD.Size = new System.Drawing.Size(99, 16);
		B8B354AD.TabIndex = 31;
		B8B354AD.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(513, 367);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(ABA2312F);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(406, 367);
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
		bunifuCards1.Controls.Add(F5A15532);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(1009, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 20000;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ToolTipTitle = "Chú ý";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1012, 416);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffTinNhanProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBuffTinNhanProfile_Load);
		F5A15532.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		C8A52024.ResumeLayout(false);
		C8A52024.PerformLayout();
		plTuongTacTruocKhiNhanTinComment.ResumeLayout(false);
		plTuongTacTruocKhiNhanTinComment.PerformLayout();
		CF25A7A0.ResumeLayout(false);
		CF25A7A0.PerformLayout();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)AB28FCAC).EndInit();
		((System.ComponentModel.ISupportInitialize)FBA2C09F).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
