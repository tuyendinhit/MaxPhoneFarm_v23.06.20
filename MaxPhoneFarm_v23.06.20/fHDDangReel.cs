using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangReel : Form
{
	internal ucTuongTacReel F62BDD22;

	internal JSON_Settings CB2C03B6;

	internal string D031BAA7;

	internal string E886BC24;

	internal string string_0;

	internal int int_0;

	internal static bool D6877C26;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel FD948E3E;

	internal TextBox C7A8BE14;

	internal Label AE876093;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards A8A0AA3A;

	internal Panel F9060D3A;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel AC89EB8A;

	internal CheckBox DF13EBB3;

	internal Panel plVanBan;

	internal Label BE86F90C;

	internal Label lblStatus;

	internal RichTextBox txtNoiDung;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton rbNganCachMoiDong;

	internal Label label9;

	internal Label C0377E98;

	internal Label label20;

	internal NumericUpDown nudKhoangCachTo;

	internal NumericUpDown nudKhoangCachFrom;

	internal Label BD260794;

	internal Label C2AFD9B1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal Label DA3BEB8E;

	internal Label B819658B;

	internal CheckBox ckbXoaNguyenLieuDaDung;

	internal LinkLabel linkLabel1;

	internal Button button3;

	internal Button E23F35A1;

	internal TextBox txtPathAnh;

	internal Label label3;

	internal RadioButton rbReelFanpage;

	internal RadioButton rbReelProfile;

	internal Label label2;

	internal NumericUpDown EF92E39E;

	internal Label label4;

	internal CheckBox B22F0389;

	internal Panel plHashtag;

	internal RichTextBox txtHashtag;

	internal Label FB8D3F24;

	internal Label CEB5AFA3;

	internal NumericUpDown nudSoHashtagFrom;

	internal Label A6A056B9;

	internal NumericUpDown nudSoHashtagTo;

	internal Label label7;

	internal CheckBox ckbXoaVideoDaDang;

	internal LinkLabel lblCaiDatTuongTacReel;

	internal CheckBox ckbTuongTacReel;

	internal TextBox txtKhoNoiDung;

	internal CheckBox F83E2EB9;

	internal TextBox D816791C;

	internal CheckBox ckbThuMucMedia;

	internal ComboBox cbbWhenTimeout;

	internal Label F6A0620C;

	public fHDDangReel(string D522659C, int int_1 = 0, string AF823F0C = "")
	{
		InitializeComponent();
		D6877C26 = false;
		D031BAA7 = D522659C;
		string_0 = AF823F0C;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đăng Reel";
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
			E886BC24 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			C7A8BE14.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(AF823F0C);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			C7A8BE14.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		CB2C03B6 = new JSON_Settings(d399C, D7BE7F11: true);
		F62BDD22 = new ucTuongTacReel(CB2C03B6)
		{
			Visible = false
		};
		base.Controls.Add(F62BDD22);
		F62BDD22.smethod_0(bool_0: true);
		Language.SetLanguage(this);
	}

	private void fHDDangReel_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = CB2C03B6.method_0("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = CB2C03B6.method_0("nudSoLuongTo", 1);
			nudKhoangCachFrom.Value = CB2C03B6.method_0("nudKhoangCachFrom", 5);
			nudKhoangCachTo.Value = CB2C03B6.method_0("nudKhoangCachTo", 10);
			DF13EBB3.Checked = CB2C03B6.AA824D29("ckbVanBan");
			ckbXoaNguyenLieuDaDung.Checked = CB2C03B6.AA824D29("ckbXoaNguyenLieuDaDung");
			txtNoiDung.Text = CB2C03B6.GetValue("txtNoiDung");
			if (CB2C03B6.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			B22F0389.Checked = CB2C03B6.AA824D29("ckbHashtag");
			txtHashtag.Text = CB2C03B6.GetValue("txtHashtag");
			nudSoHashtagFrom.Value = CB2C03B6.method_0("nudSoHashtagFrom", 1);
			nudSoHashtagTo.Value = CB2C03B6.method_0("nudSoHashtagTo", 1);
			txtPathAnh.Text = CB2C03B6.GetValue("txtPathAnh");
			ckbXoaVideoDaDang.Checked = CB2C03B6.AA824D29("ckbXoaVideoDaDang");
			if (CB2C03B6.method_0("typeReel") == 0)
			{
				rbReelProfile.Checked = true;
			}
			else
			{
				rbReelFanpage.Checked = true;
			}
			EF92E39E.Value = CB2C03B6.method_0("nudTimeOutLoadVideo", 300);
			cbbWhenTimeout.SelectedIndex = CB2C03B6.method_0("cbbWhenTimeout");
			ckbTuongTacReel.Checked = CB2C03B6.AA824D29("ckbTuongTacReel");
			F83E2EB9.Checked = CB2C03B6.AA824D29("ckbKhoNoiDung");
			txtKhoNoiDung.Text = CB2C03B6.GetValue("txtKhoNoiDung");
			ckbThuMucMedia.Checked = CB2C03B6.AA824D29("ckbThuMucMedia");
			D816791C.Text = CB2C03B6.GetValue("txtThuMucMedia");
		}
		catch (Exception)
		{
		}
		method_0();
	}

	private void D6A8A292(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = C7A8BE14.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		CB2C03B6.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		CB2C03B6.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		CB2C03B6.GetValue("nudKhoangCachFrom", nudKhoangCachFrom.Value);
		CB2C03B6.GetValue("nudKhoangCachTo", nudKhoangCachTo.Value);
		CB2C03B6.GetValue("ckbVanBan", DF13EBB3.Checked);
		CB2C03B6.GetValue("ckbXoaNguyenLieuDaDung", ckbXoaNguyenLieuDaDung.Checked);
        CB2C03B6.GetValue("txtNoiDung", (object)txtNoiDung.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		CB2C03B6.GetValue("typeNganCach", num);
		CB2C03B6.GetValue("ckbHashtag", B22F0389.Checked);
        CB2C03B6.GetValue("txtHashtag", (object)txtHashtag.Text.Trim());
		CB2C03B6.GetValue("nudSoHashtagFrom", nudSoHashtagFrom.Value);
		CB2C03B6.GetValue("nudSoHashtagTo", nudSoHashtagTo.Value);
        CB2C03B6.GetValue("txtPathAnh", (object)txtPathAnh.Text.Trim());
		CB2C03B6.GetValue("ckbXoaVideoDaDang", ckbXoaVideoDaDang.Checked);
		int num2 = 0;
		if (rbReelFanpage.Checked)
		{
			num2 = 1;
		}
		CB2C03B6.GetValue("typeReel", num2);
		CB2C03B6.GetValue("nudTimeOutLoadVideo", EF92E39E.Value);
		CB2C03B6.GetValue("cbbWhenTimeout", cbbWhenTimeout.SelectedIndex);
		CB2C03B6.GetValue("ckbTuongTacReel", ckbTuongTacReel.Checked);
		CB2C03B6.GetValue("ckbThuMucMedia", ckbThuMucMedia.Checked);
        CB2C03B6.GetValue("txtThuMucMedia", (object)D816791C.Text);
		CB2C03B6.GetValue("ckbKhoNoiDung", F83E2EB9.Checked);
        CB2C03B6.GetValue("txtKhoNoiDung", (object)txtKhoNoiDung.Text);
		string text2 = CB2C03B6.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(D031BAA7, text, E886BC24, text2))
				{
					D6877C26 = true;
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
			if (Class123.smethod_14(string_0, text, text2))
			{
				D6877C26 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void E6161782(object sender, EventArgs e)
	{
		Close();
	}

	private void A4271710(object sender, PaintEventArgs e)
	{
		if (FD948E3E.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, FD948E3E.ClientSize.Width - num, FD948E3E.ClientSize.Height - num));
		}
	}

	private void method_0()
	{
		DF13EBB3_CheckedChanged(null, null);
		DD0A5CB7(null, null);
		B22F0389_CheckedChanged(null, null);
		ckbTuongTacReel_CheckedChanged(null, null);
		F83E2EB9_CheckedChanged(null, null);
		ckbThuMucMedia_CheckedChanged(null, null);
	}

	private void DF13EBB3_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = DF13EBB3.Checked;
	}

	private void EE83F1A6(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtNoiDung.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtNoiDung.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch nô\u0323i dung ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void C711979F(object sender, EventArgs e)
	{
		method_1();
	}

	private void EB30CF26(object sender, EventArgs e)
	{
	}

	private void E2151294(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void E23F35A1_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
	}

	private void DD0A5CB7(object sender, EventArgs e)
	{
	}

	private void FBB6AE2A(object sender, EventArgs e)
	{
		Common.D936DD84(txtHashtag, FB8D3F24);
	}

	private void B22F0389_CheckedChanged(object sender, EventArgs e)
	{
		plHashtag.Enabled = B22F0389.Checked;
	}

	private void C98FA492(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_63(F62BDD22, this);
	}

	private void ckbTuongTacReel_CheckedChanged(object sender, EventArgs e)
	{
		lblCaiDatTuongTacReel.Enabled = ckbTuongTacReel.Checked;
	}

	private void F83E2EB9_CheckedChanged(object sender, EventArgs e)
	{
		txtKhoNoiDung.Enabled = F83E2EB9.Checked;
	}

	private void ckbThuMucMedia_CheckedChanged(object sender, EventArgs e)
	{
		D816791C.Enabled = ckbThuMucMedia.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangReel));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		AC89EB8A = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		F9060D3A = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		FD948E3E = new System.Windows.Forms.Panel();
		cbbWhenTimeout = new System.Windows.Forms.ComboBox();
		F6A0620C = new System.Windows.Forms.Label();
		D816791C = new System.Windows.Forms.TextBox();
		txtKhoNoiDung = new System.Windows.Forms.TextBox();
		rbReelFanpage = new System.Windows.Forms.RadioButton();
		rbReelProfile = new System.Windows.Forms.RadioButton();
		label2 = new System.Windows.Forms.Label();
		txtPathAnh = new System.Windows.Forms.TextBox();
		C0377E98 = new System.Windows.Forms.Label();
		label20 = new System.Windows.Forms.Label();
		nudKhoangCachTo = new System.Windows.Forms.NumericUpDown();
		label3 = new System.Windows.Forms.Label();
		nudKhoangCachFrom = new System.Windows.Forms.NumericUpDown();
		ckbXoaVideoDaDang = new System.Windows.Forms.CheckBox();
		BD260794 = new System.Windows.Forms.Label();
		C2AFD9B1 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		EF92E39E = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		label4 = new System.Windows.Forms.Label();
		DA3BEB8E = new System.Windows.Forms.Label();
		B819658B = new System.Windows.Forms.Label();
		plVanBan = new System.Windows.Forms.Panel();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		button3 = new System.Windows.Forms.Button();
		E23F35A1 = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		txtNoiDung = new System.Windows.Forms.RichTextBox();
		BE86F90C = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		ckbXoaNguyenLieuDaDung = new System.Windows.Forms.CheckBox();
		B22F0389 = new System.Windows.Forms.CheckBox();
		plHashtag = new System.Windows.Forms.Panel();
		nudSoHashtagFrom = new System.Windows.Forms.NumericUpDown();
		A6A056B9 = new System.Windows.Forms.Label();
		nudSoHashtagTo = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		txtHashtag = new System.Windows.Forms.RichTextBox();
		FB8D3F24 = new System.Windows.Forms.Label();
		CEB5AFA3 = new System.Windows.Forms.Label();
		ckbThuMucMedia = new System.Windows.Forms.CheckBox();
		btnAdd = new System.Windows.Forms.Button();
		F83E2EB9 = new System.Windows.Forms.CheckBox();
		DF13EBB3 = new System.Windows.Forms.CheckBox();
		C7A8BE14 = new System.Windows.Forms.TextBox();
		AE876093 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		A8A0AA3A = new Bunifu.Framework.UI.BunifuCards();
		lblCaiDatTuongTacReel = new System.Windows.Forms.LinkLabel();
		ckbTuongTacReel = new System.Windows.Forms.CheckBox();
		F9060D3A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		FD948E3E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)EF92E39E).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		plVanBan.SuspendLayout();
		plHashtag.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoHashtagFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoHashtagTo).BeginInit();
		A8A0AA3A.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = AC89EB8A;
		bunifuDragControl_0.Vertical = true;
		AC89EB8A.BackColor = System.Drawing.Color.Transparent;
		AC89EB8A.Cursor = System.Windows.Forms.Cursors.SizeAll;
		AC89EB8A.Dock = System.Windows.Forms.DockStyle.Fill;
		AC89EB8A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AC89EB8A.ForeColor = System.Drawing.Color.Black;
		AC89EB8A.Location = new System.Drawing.Point(0, 0);
		AC89EB8A.Name = "bunifuCustomLabel1";
		AC89EB8A.Size = new System.Drawing.Size(593, 31);
		AC89EB8A.TabIndex = 12;
		AC89EB8A.Text = "Cấu hình Đăng Reel";
		AC89EB8A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = F9060D3A;
		bunifuDragControl_1.Vertical = true;
		F9060D3A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F9060D3A.BackColor = System.Drawing.Color.White;
		F9060D3A.Controls.Add(button1);
		F9060D3A.Controls.Add(pictureBox1);
		F9060D3A.Controls.Add(AC89EB8A);
		F9060D3A.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F9060D3A.Location = new System.Drawing.Point(0, 3);
		F9060D3A.Name = "pnlHeader";
		F9060D3A.Size = new System.Drawing.Size(593, 31);
		F9060D3A.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(562, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 0;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(D6A8A292);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		FD948E3E.BackColor = System.Drawing.Color.White;
		FD948E3E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FD948E3E.Controls.Add(cbbWhenTimeout);
		FD948E3E.Controls.Add(F6A0620C);
		FD948E3E.Controls.Add(D816791C);
		FD948E3E.Controls.Add(txtKhoNoiDung);
		FD948E3E.Controls.Add(rbReelFanpage);
		FD948E3E.Controls.Add(rbReelProfile);
		FD948E3E.Controls.Add(label2);
		FD948E3E.Controls.Add(txtPathAnh);
		FD948E3E.Controls.Add(C0377E98);
		FD948E3E.Controls.Add(label20);
		FD948E3E.Controls.Add(nudKhoangCachTo);
		FD948E3E.Controls.Add(label3);
		FD948E3E.Controls.Add(nudKhoangCachFrom);
		FD948E3E.Controls.Add(ckbXoaVideoDaDang);
		FD948E3E.Controls.Add(BD260794);
		FD948E3E.Controls.Add(C2AFD9B1);
		FD948E3E.Controls.Add(nudSoLuongTo);
		FD948E3E.Controls.Add(EF92E39E);
		FD948E3E.Controls.Add(nudSoLuongFrom);
		FD948E3E.Controls.Add(label4);
		FD948E3E.Controls.Add(DA3BEB8E);
		FD948E3E.Controls.Add(B819658B);
		FD948E3E.Controls.Add(plVanBan);
		FD948E3E.Controls.Add(ckbThuMucMedia);
		FD948E3E.Controls.Add(btnAdd);
		FD948E3E.Controls.Add(F83E2EB9);
		FD948E3E.Controls.Add(DF13EBB3);
		FD948E3E.Controls.Add(C7A8BE14);
		FD948E3E.Controls.Add(AE876093);
		FD948E3E.Controls.Add(btnCancel);
		FD948E3E.Controls.Add(A8A0AA3A);
		FD948E3E.Controls.Add(lblCaiDatTuongTacReel);
		FD948E3E.Controls.Add(ckbTuongTacReel);
		FD948E3E.Cursor = System.Windows.Forms.Cursors.Arrow;
		FD948E3E.Dock = System.Windows.Forms.DockStyle.Fill;
		FD948E3E.Location = new System.Drawing.Point(0, 0);
		FD948E3E.Name = "panel1";
		FD948E3E.Size = new System.Drawing.Size(596, 729);
		FD948E3E.TabIndex = 0;
		FD948E3E.Paint += new System.Windows.Forms.PaintEventHandler(A4271710);
		cbbWhenTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbWhenTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbWhenTimeout.FormattingEnabled = true;
		cbbWhenTimeout.Items.AddRange(new object[2] { "Success", "Fail" });
		cbbWhenTimeout.Location = new System.Drawing.Point(458, 647);
		cbbWhenTimeout.Name = "cbbWhenTimeout";
		cbbWhenTimeout.Size = new System.Drawing.Size(103, 24);
		cbbWhenTimeout.TabIndex = 186;
		F6A0620C.Location = new System.Drawing.Point(258, 650);
		F6A0620C.Name = "label13";
		F6A0620C.Size = new System.Drawing.Size(203, 16);
		F6A0620C.TabIndex = 185;
		F6A0620C.Text = "Nếu timeout thì sẽ tính là:";
		F6A0620C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		D816791C.Location = new System.Drawing.Point(168, 830);
		D816791C.Name = "txtThuMucMedia";
		D816791C.Size = new System.Drawing.Size(393, 23);
		D816791C.TabIndex = 1;
		txtKhoNoiDung.Location = new System.Drawing.Point(168, 801);
		txtKhoNoiDung.Name = "txtKhoNoiDung";
		txtKhoNoiDung.Size = new System.Drawing.Size(393, 23);
		txtKhoNoiDung.TabIndex = 1;
		rbReelFanpage.AutoSize = true;
		rbReelFanpage.Cursor = System.Windows.Forms.Cursors.Hand;
		rbReelFanpage.Location = new System.Drawing.Point(290, 624);
		rbReelFanpage.Name = "rbReelFanpage";
		rbReelFanpage.Size = new System.Drawing.Size(212, 20);
		rbReelFanpage.TabIndex = 45;
		rbReelFanpage.TabStop = true;
		rbReelFanpage.Text = "Đăng lên fanpage (page thường)";
		rbReelFanpage.UseVisualStyleBackColor = true;
		rbReelProfile.AutoSize = true;
		rbReelProfile.Cursor = System.Windows.Forms.Cursors.Hand;
		rbReelProfile.Location = new System.Drawing.Point(168, 624);
		rbReelProfile.Name = "rbReelProfile";
		rbReelProfile.Size = new System.Drawing.Size(116, 20);
		rbReelProfile.TabIndex = 45;
		rbReelProfile.TabStop = true;
		rbReelProfile.Text = "Đăng lên profile";
		rbReelProfile.UseVisualStyleBackColor = true;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(30, 626);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(122, 16);
		label2.TabIndex = 44;
		label2.Text = "Tùy chọn đăng reel:";
		txtPathAnh.Location = new System.Drawing.Point(168, 136);
		txtPathAnh.Name = "txtPathAnh";
		txtPathAnh.Size = new System.Drawing.Size(260, 23);
		txtPathAnh.TabIndex = 1;
		C0377E98.AutoSize = true;
		C0377E98.Location = new System.Drawing.Point(308, 109);
		C0377E98.Name = "label19";
		C0377E98.Size = new System.Drawing.Size(30, 16);
		C0377E98.TabIndex = 43;
		C0377E98.Text = "giây";
		label20.Location = new System.Drawing.Point(222, 109);
		label20.Name = "label20";
		label20.Size = new System.Drawing.Size(29, 16);
		label20.TabIndex = 42;
		label20.Text = "đến";
		label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudKhoangCachTo.Location = new System.Drawing.Point(253, 107);
		nudKhoangCachTo.Name = "nudKhoangCachTo";
		nudKhoangCachTo.Size = new System.Drawing.Size(51, 23);
		nudKhoangCachTo.TabIndex = 41;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(30, 139);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(97, 16);
		label3.TabIndex = 0;
		label3.Text = "Thư mu\u0323c video:";
		nudKhoangCachFrom.Location = new System.Drawing.Point(168, 107);
		nudKhoangCachFrom.Name = "nudKhoangCachFrom";
		nudKhoangCachFrom.Size = new System.Drawing.Size(51, 23);
		nudKhoangCachFrom.TabIndex = 40;
		ckbXoaVideoDaDang.AutoSize = true;
		ckbXoaVideoDaDang.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaVideoDaDang.Location = new System.Drawing.Point(436, 138);
		ckbXoaVideoDaDang.Name = "ckbXoaVideoDaDang";
		ckbXoaVideoDaDang.Size = new System.Drawing.Size(132, 20);
		ckbXoaVideoDaDang.TabIndex = 32;
		ckbXoaVideoDaDang.Text = "Xóa video đã đăng";
		ckbXoaVideoDaDang.UseVisualStyleBackColor = true;
		ckbXoaVideoDaDang.CheckedChanged += new System.EventHandler(DF13EBB3_CheckedChanged);
		BD260794.AutoSize = true;
		BD260794.Location = new System.Drawing.Point(308, 83);
		BD260794.Name = "label18";
		BD260794.Size = new System.Drawing.Size(29, 16);
		BD260794.TabIndex = 39;
		BD260794.Text = "reel";
		C2AFD9B1.Location = new System.Drawing.Point(222, 83);
		C2AFD9B1.Name = "label17";
		C2AFD9B1.Size = new System.Drawing.Size(29, 16);
		C2AFD9B1.TabIndex = 38;
		C2AFD9B1.Text = "đến";
		C2AFD9B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudSoLuongTo.Location = new System.Drawing.Point(253, 78);
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(51, 23);
		nudSoLuongTo.TabIndex = 37;
		EF92E39E.Location = new System.Drawing.Point(197, 648);
		EF92E39E.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		EF92E39E.Name = "nudTimeOutLoadVideo";
		EF92E39E.Size = new System.Drawing.Size(51, 23);
		EF92E39E.TabIndex = 36;
		nudSoLuongFrom.Location = new System.Drawing.Point(168, 78);
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(51, 23);
		nudSoLuongFrom.TabIndex = 36;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(30, 650);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(165, 16);
		label4.TabIndex = 34;
		label4.Text = "Timeout chờ load video (s):";
		DA3BEB8E.AutoSize = true;
		DA3BEB8E.Location = new System.Drawing.Point(30, 109);
		DA3BEB8E.Name = "label16";
		DA3BEB8E.Size = new System.Drawing.Size(116, 16);
		DA3BEB8E.TabIndex = 35;
		DA3BEB8E.Text = "Khoảng cách đăng:";
		B819658B.AutoSize = true;
		B819658B.Location = new System.Drawing.Point(30, 80);
		B819658B.Name = "label15";
		B819658B.Size = new System.Drawing.Size(89, 16);
		B819658B.TabIndex = 34;
		B819658B.Text = "Số lượng reel:";
		plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plVanBan.Controls.Add(linkLabel1);
		plVanBan.Controls.Add(button3);
		plVanBan.Controls.Add(E23F35A1);
		plVanBan.Controls.Add(rbNganCachKyTu);
		plVanBan.Controls.Add(rbNganCachMoiDong);
		plVanBan.Controls.Add(label9);
		plVanBan.Controls.Add(txtNoiDung);
		plVanBan.Controls.Add(BE86F90C);
		plVanBan.Controls.Add(lblStatus);
		plVanBan.Controls.Add(ckbXoaNguyenLieuDaDung);
		plVanBan.Controls.Add(B22F0389);
		plVanBan.Controls.Add(plHashtag);
		plVanBan.Location = new System.Drawing.Point(47, 186);
		plVanBan.Name = "plVanBan";
		plVanBan.Size = new System.Drawing.Size(514, 434);
		plVanBan.TabIndex = 33;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.Location = new System.Drawing.Point(154, 197);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(81, 16);
		linkLabel1.TabIndex = 195;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(E2151294);
		button3.Cursor = System.Windows.Forms.Cursors.Help;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(485, 218);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(21, 23);
		button3.TabIndex = 193;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		E23F35A1.Cursor = System.Windows.Forms.Cursors.Help;
		E23F35A1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E23F35A1.Location = new System.Drawing.Point(485, 195);
		E23F35A1.Name = "button2";
		E23F35A1.Size = new System.Drawing.Size(21, 23);
		E23F35A1.TabIndex = 194;
		E23F35A1.Text = "?";
		E23F35A1.UseVisualStyleBackColor = true;
		E23F35A1.Click += new System.EventHandler(E23F35A1_Click);
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(326, 219);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		rbNganCachKyTu.TabIndex = 37;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(C711979F);
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(326, 197);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		rbNganCachMoiDong.TabIndex = 36;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(261, 197);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(64, 16);
		label9.TabIndex = 35;
		label9.Text = "Tùy chọn:";
		txtNoiDung.Location = new System.Drawing.Point(7, 23);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new System.Drawing.Size(499, 172);
		txtNoiDung.TabIndex = 34;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += new System.EventHandler(EE83F1A6);
		BE86F90C.AutoSize = true;
		BE86F90C.Location = new System.Drawing.Point(4, 197);
		BE86F90C.Name = "label8";
		BE86F90C.Size = new System.Drawing.Size(143, 16);
		BE86F90C.TabIndex = 0;
		BE86F90C.Text = "(Spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 4);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(145, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		ckbXoaNguyenLieuDaDung.AutoSize = true;
		ckbXoaNguyenLieuDaDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaNguyenLieuDaDung.Location = new System.Drawing.Point(7, 220);
		ckbXoaNguyenLieuDaDung.Name = "ckbXoaNguyenLieuDaDung";
		ckbXoaNguyenLieuDaDung.Size = new System.Drawing.Size(151, 20);
		ckbXoaNguyenLieuDaDung.TabIndex = 32;
		ckbXoaNguyenLieuDaDung.Text = "Xóa nội dung đã đăng";
		ckbXoaNguyenLieuDaDung.UseVisualStyleBackColor = true;
		ckbXoaNguyenLieuDaDung.CheckedChanged += new System.EventHandler(DF13EBB3_CheckedChanged);
		B22F0389.AutoSize = true;
		B22F0389.Cursor = System.Windows.Forms.Cursors.Hand;
		B22F0389.Location = new System.Drawing.Point(7, 246);
		B22F0389.Name = "ckbHashtag";
		B22F0389.Size = new System.Drawing.Size(101, 20);
		B22F0389.TabIndex = 32;
		B22F0389.Text = "Kèm Hashtag";
		B22F0389.UseVisualStyleBackColor = true;
		B22F0389.CheckedChanged += new System.EventHandler(B22F0389_CheckedChanged);
		plHashtag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plHashtag.Controls.Add(nudSoHashtagFrom);
		plHashtag.Controls.Add(A6A056B9);
		plHashtag.Controls.Add(nudSoHashtagTo);
		plHashtag.Controls.Add(label7);
		plHashtag.Controls.Add(txtHashtag);
		plHashtag.Controls.Add(FB8D3F24);
		plHashtag.Controls.Add(CEB5AFA3);
		plHashtag.Location = new System.Drawing.Point(19, 271);
		plHashtag.Name = "plHashtag";
		plHashtag.Size = new System.Drawing.Size(487, 156);
		plHashtag.TabIndex = 33;
		nudSoHashtagFrom.Location = new System.Drawing.Point(170, 127);
		nudSoHashtagFrom.Name = "nudSoHashtagFrom";
		nudSoHashtagFrom.Size = new System.Drawing.Size(51, 23);
		nudSoHashtagFrom.TabIndex = 40;
		A6A056B9.AutoSize = true;
		A6A056B9.Location = new System.Drawing.Point(308, 129);
		A6A056B9.Name = "label11";
		A6A056B9.Size = new System.Drawing.Size(52, 16);
		A6A056B9.TabIndex = 43;
		A6A056B9.Text = "hashtag";
		nudSoHashtagTo.Location = new System.Drawing.Point(255, 127);
		nudSoHashtagTo.Name = "nudSoHashtagTo";
		nudSoHashtagTo.Size = new System.Drawing.Size(51, 23);
		nudSoHashtagTo.TabIndex = 41;
		label7.Location = new System.Drawing.Point(224, 129);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 42;
		label7.Text = "đến";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		txtHashtag.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtHashtag.Location = new System.Drawing.Point(7, 22);
		txtHashtag.Name = "txtHashtag";
		txtHashtag.Size = new System.Drawing.Size(472, 102);
		txtHashtag.TabIndex = 34;
		txtHashtag.Text = "";
		txtHashtag.WordWrap = false;
		txtHashtag.TextChanged += new System.EventHandler(FBB6AE2A);
		FB8D3F24.AutoSize = true;
		FB8D3F24.Location = new System.Drawing.Point(3, 3);
		FB8D3F24.Name = "lblHashtag";
		FB8D3F24.Size = new System.Drawing.Size(141, 16);
		FB8D3F24.TabIndex = 0;
		FB8D3F24.Text = "Danh sa\u0301ch hashtag (0):";
		CEB5AFA3.AutoSize = true;
		CEB5AFA3.Location = new System.Drawing.Point(4, 129);
		CEB5AFA3.Name = "label6";
		CEB5AFA3.Size = new System.Drawing.Size(166, 16);
		CEB5AFA3.TabIndex = 35;
		CEB5AFA3.Text = "Số lượng hashtag/nội dung:";
		ckbThuMucMedia.AutoSize = true;
		ckbThuMucMedia.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbThuMucMedia.Location = new System.Drawing.Point(33, 832);
		ckbThuMucMedia.Name = "ckbThuMucMedia";
		ckbThuMucMedia.Size = new System.Drawing.Size(121, 20);
		ckbThuMucMedia.TabIndex = 32;
		ckbThuMucMedia.Text = "Thư mục media:";
		ckbThuMucMedia.UseVisualStyleBackColor = true;
		ckbThuMucMedia.CheckedChanged += new System.EventHandler(ckbThuMucMedia_CheckedChanged);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(205, 687);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		F83E2EB9.AutoSize = true;
		F83E2EB9.Cursor = System.Windows.Forms.Cursors.Hand;
		F83E2EB9.Location = new System.Drawing.Point(33, 803);
		F83E2EB9.Name = "ckbKhoNoiDung";
		F83E2EB9.Size = new System.Drawing.Size(140, 20);
		F83E2EB9.TabIndex = 32;
		F83E2EB9.Text = "Kho video/nội dung:";
		F83E2EB9.UseVisualStyleBackColor = true;
		F83E2EB9.CheckedChanged += new System.EventHandler(F83E2EB9_CheckedChanged);
		DF13EBB3.AutoSize = true;
		DF13EBB3.Cursor = System.Windows.Forms.Cursors.Hand;
		DF13EBB3.Location = new System.Drawing.Point(33, 162);
		DF13EBB3.Name = "ckbVanBan";
		DF13EBB3.Size = new System.Drawing.Size(113, 20);
		DF13EBB3.TabIndex = 32;
		DF13EBB3.Text = "Nội dung mô tả";
		DF13EBB3.UseVisualStyleBackColor = true;
		DF13EBB3.CheckedChanged += new System.EventHandler(DF13EBB3_CheckedChanged);
		C7A8BE14.Location = new System.Drawing.Point(168, 49);
		C7A8BE14.Name = "txtTenHanhDong";
		C7A8BE14.Size = new System.Drawing.Size(174, 23);
		C7A8BE14.TabIndex = 0;
		AE876093.AutoSize = true;
		AE876093.Location = new System.Drawing.Point(30, 52);
		AE876093.Name = "label1";
		AE876093.Size = new System.Drawing.Size(98, 16);
		AE876093.TabIndex = 31;
		AE876093.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(304, 687);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(E6161782);
		A8A0AA3A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A8A0AA3A.BackColor = System.Drawing.Color.White;
		A8A0AA3A.BorderRadius = 0;
		A8A0AA3A.BottomSahddow = true;
		A8A0AA3A.color = System.Drawing.Color.DarkViolet;
		A8A0AA3A.Controls.Add(F9060D3A);
		A8A0AA3A.LeftSahddow = false;
		A8A0AA3A.Location = new System.Drawing.Point(1, 0);
		A8A0AA3A.Name = "bunifuCards1";
		A8A0AA3A.RightSahddow = true;
		A8A0AA3A.ShadowDepth = 20;
		A8A0AA3A.Size = new System.Drawing.Size(593, 37);
		A8A0AA3A.TabIndex = 28;
		lblCaiDatTuongTacReel.AutoSize = true;
		lblCaiDatTuongTacReel.Cursor = System.Windows.Forms.Cursors.Hand;
		lblCaiDatTuongTacReel.Location = new System.Drawing.Point(518, 189);
		lblCaiDatTuongTacReel.Name = "lblCaiDatTuongTacReel";
		lblCaiDatTuongTacReel.Size = new System.Drawing.Size(47, 16);
		lblCaiDatTuongTacReel.TabIndex = 184;
		lblCaiDatTuongTacReel.TabStop = true;
		lblCaiDatTuongTacReel.Text = "Cài đặt";
		lblCaiDatTuongTacReel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(C98FA492);
		ckbTuongTacReel.AutoSize = true;
		ckbTuongTacReel.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuongTacReel.Location = new System.Drawing.Point(334, 189);
		ckbTuongTacReel.Name = "ckbTuongTacReel";
		ckbTuongTacReel.Size = new System.Drawing.Size(186, 20);
		ckbTuongTacReel.TabIndex = 32;
		ckbTuongTacReel.Text = "Tương tác reel sau khi đăng";
		ckbTuongTacReel.UseVisualStyleBackColor = true;
		ckbTuongTacReel.CheckedChanged += new System.EventHandler(ckbTuongTacReel_CheckedChanged);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(596, 729);
		base.Controls.Add(FD948E3E);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangReel";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDangReel_Load);
		F9060D3A.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		FD948E3E.ResumeLayout(false);
		FD948E3E.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)EF92E39E).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		plVanBan.ResumeLayout(false);
		plVanBan.PerformLayout();
		plHashtag.ResumeLayout(false);
		plHashtag.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoHashtagFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoHashtagTo).EndInit();
		A8A0AA3A.ResumeLayout(false);
		ResumeLayout(false);
	}
}
