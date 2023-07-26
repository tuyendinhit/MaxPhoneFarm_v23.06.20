using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDCapNhatThongTin : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string D515922C;

	internal int int_0;

	internal static bool E7ADA1B0;

	internal string F8103108 = "";

	internal int int_1 = 0;

	internal List<string> list_0 = new List<string>();

	internal List<string> EC23F5AD = new List<string>();

	internal List<string> DA9C6530 = new List<string>();

	internal List<string> list_1 = new List<string>();

	internal List<string> list_2 = new List<string>();

	internal List<string> list_3 = new List<string>();

	internal List<string> list_4 = new List<string>();

	internal List<string> list_5 = new List<string>();

	internal List<string> list_6 = new List<string>
	{
		"Single", "In a relationship", "Engaged", "Married", "In a civil union", "In a domestic partnership", "In an open relationship", "It's complicated", "Separated", "Divorced",
		"Widowed"
	};

	internal List<string> list_7 = new List<string> { "Female", "Male" };

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl B1BA403E;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button B48D6E8E;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel F19FA493;

	internal Button A19F6907;

	internal CheckBox ckbRelationship;

	internal CheckBox ckbCurrentCity;

	internal CheckBox ckbCollege;

	internal CheckBox ckbHighSchool;

	internal CheckBox ckbWork;

	internal Button btnNhapCurrentCity;

	internal Button A637B019;

	internal Button btnNhapHighSchool;

	internal Button btnNhapWork;

	internal CheckBox FD81F187;

	internal ComboBox EDAC1D39;

	internal CheckBox D9AB050C;

	internal Button A299E485;

	internal CheckBox ckbSkipWhenHave;

	internal ComboBox cbbGender;

	internal CheckBox DA00CB2C;

	internal CheckBox ckbBirthday;

	internal Button E536A139;

	internal Button D9850487;

	internal Button btnDay;

	public fHDCapNhatThongTin(string D0B50D16, int int_2 = 0, string B28506B6 = "")
	{
		InitializeComponent();
		E7ADA1B0 = false;
		string_0 = D0B50D16;
		D515922C = B28506B6;
		int_0 = int_2;
		string text = base.Name.Substring(1);
		string text2 = "Cập nhật thông tin";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (int_2)
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
			DataTable dataTable = Class123.smethod_10(B28506B6);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDCapNhatThongTin_Load(object sender, EventArgs e)
	{
		method_0();
		D4AEE3AC();
		try
		{
			FD81F187.Checked = f72FAFBC_0.AA824D29("ckbBio");
			ckbWork.Checked = f72FAFBC_0.AA824D29("ckbWork");
			ckbHighSchool.Checked = f72FAFBC_0.AA824D29("ckbHighSchool");
			ckbCollege.Checked = f72FAFBC_0.AA824D29("ckbCollege");
			ckbCurrentCity.Checked = f72FAFBC_0.AA824D29("ckbCurrentCity");
			D9AB050C.Checked = f72FAFBC_0.AA824D29("ckbHometown");
			ckbRelationship.Checked = f72FAFBC_0.AA824D29("ckbRelationship");
			DA00CB2C.Checked = f72FAFBC_0.AA824D29("ckbGender");
			ckbBirthday.Checked = f72FAFBC_0.AA824D29("ckbBirthday");
			F8103108 = f72FAFBC_0.GetValue("txtBio");
			int_1 = f72FAFBC_0.method_0("typeSplitBio");
			list_0 = f72FAFBC_0.EC378D8A("lstWork");
			EC23F5AD = f72FAFBC_0.EC378D8A("lstHighSchool");
			DA9C6530 = f72FAFBC_0.EC378D8A("lstCollege");
			list_1 = f72FAFBC_0.EC378D8A("lstCurrentCity");
			list_2 = f72FAFBC_0.EC378D8A("lstHometown");
			EDAC1D39.Text = ((f72FAFBC_0.GetValue("cbbRelationship").Split('|').Length == 1) ? f72FAFBC_0.GetValue("cbbRelationship", "Random") : "Random");
			ckbSkipWhenHave.Checked = f72FAFBC_0.AA824D29("ckbSkipWhenHave");
			cbbGender.Text = ((f72FAFBC_0.GetValue("cbbGender").Split('|').Length == 1) ? f72FAFBC_0.GetValue("cbbGender", "Random") : "Random");
			list_3 = f72FAFBC_0.EC378D8A("lstDay");
			list_4 = f72FAFBC_0.EC378D8A("lstMonth");
			list_5 = f72FAFBC_0.EC378D8A("lstYear");
			FAB711BD(null, null);
			ckbWork_CheckedChanged(null, null);
			E5A0349C(null, null);
			AC99313E(null, null);
			ckbCurrentCity_CheckedChanged(null, null);
			B9B70FB8(null, null);
			ckbRelationship_CheckedChanged(null, null);
			DA00CB2C_CheckedChanged(null, null);
			ckbBirthday_CheckedChanged(null, null);
			Common.DB181F2D(btnNhapCurrentCity, list_1.Count);
			Common.DB181F2D(A299E485, list_2.Count);
			Common.DB181F2D(A637B019, DA9C6530.Count);
			Common.DB181F2D(btnNhapHighSchool, EC23F5AD.Count);
			Common.DB181F2D(btnNhapWork, list_0.Count);
			Common.DB181F2D(A19F6907, F8103108.Split(new string[1] { (int_1 == 0) ? "\n" : "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).Length);
		}
		catch
		{
		}
	}

	private void D4AEE3AC()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < list_7.Count; i++)
		{
			dictionary.Add(i.ToString(), list_7[i]);
		}
		dictionary.Add(list_7.Count.ToString(), "Random");
		cbbGender.DataSource = new BindingSource(dictionary, null);
		cbbGender.DisplayMember = "Value";
		cbbGender.ValueMember = "Key";
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < list_6.Count; i++)
		{
			dictionary.Add(i.ToString(), list_6[i]);
		}
		dictionary.Add(list_6.Count.ToString(), "Random");
		EDAC1D39.DataSource = new BindingSource(dictionary, null);
		EDAC1D39.DisplayMember = "Value";
		EDAC1D39.ValueMember = "Key";
	}

	private void B48D6E8E_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F0B85220(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("ckbBio", FD81F187.Checked);
		f72FAFBC.GetValue("ckbWork", ckbWork.Checked);
		f72FAFBC.GetValue("ckbHighSchool", ckbHighSchool.Checked);
		f72FAFBC.GetValue("ckbCollege", ckbCollege.Checked);
		f72FAFBC.GetValue("ckbCurrentCity", ckbCurrentCity.Checked);
		f72FAFBC.GetValue("ckbHometown", D9AB050C.Checked);
		f72FAFBC.GetValue("ckbRelationship", ckbRelationship.Checked);
		f72FAFBC.GetValue("ckbGender", DA00CB2C.Checked);
		f72FAFBC.GetValue("ckbBirthday", ckbBirthday.Checked);
		f72FAFBC.GetValue("txtBio", (object)F8103108);
		f72FAFBC.GetValue("typeSplitBio", int_1);
		f72FAFBC.method_3("lstWork", list_0);
		f72FAFBC.method_3("lstHighSchool", EC23F5AD);
		f72FAFBC.method_3("lstCollege", DA9C6530);
		f72FAFBC.method_3("lstCurrentCity", list_1);
		f72FAFBC.method_3("lstHometown", list_2);
		string text2 = EDAC1D39.Text;
		text2 = ((text2 == "Random") ? string.Join("|", list_6) : text2);
		f72FAFBC.GetValue("cbbRelationship", (object)text2);
		string text3 = cbbGender.Text;
		text3 = ((text3 == "Random") ? string.Join("|", list_7) : text3);
		f72FAFBC.GetValue("cbbGender", (object)text3);
		f72FAFBC.method_3("lstDay", list_3);
		f72FAFBC.method_3("lstMonth", list_4);
		f72FAFBC.method_3("lstYear", list_5);
		f72FAFBC.GetValue("ckbSkipWhenHave", ckbSkipWhenHave.Checked);
		string text4 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text4))
				{
					E7ADA1B0 = true;
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
			if (Class123.smethod_14(D515922C, text, text4))
			{
				E7ADA1B0 = true;
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

	private void FAB711BD(object sender, EventArgs e)
	{
		A19F6907.Enabled = FD81F187.Checked;
	}

	private void ckbWork_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapWork.Enabled = ckbWork.Checked;
	}

	private void E5A0349C(object sender, EventArgs e)
	{
		btnNhapHighSchool.Enabled = ckbHighSchool.Checked;
	}

	private void AC99313E(object sender, EventArgs e)
	{
		A637B019.Enabled = ckbCollege.Checked;
	}

	private void ckbCurrentCity_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapCurrentCity.Enabled = ckbCurrentCity.Checked;
	}

	private void ckbRelationship_CheckedChanged(object sender, EventArgs e)
	{
		EDAC1D39.Enabled = ckbRelationship.Checked;
	}

	private void A19F6907_Click(object sender, EventArgs e)
	{
		fNhapDuLieu3 fNhapDuLieu4 = new fNhapDuLieu3(F8103108, int_1, "Nhâ\u0323p danh sa\u0301ch Bio", "Danh sa\u0301ch Bio");
		Common.smethod_16(fNhapDuLieu4);
		F8103108 = fNhapDuLieu4.D30E479D;
		int_1 = fNhapDuLieu4.int_0;
		Common.DB181F2D(A19F6907, F8103108.Split(new string[1] { (int_1 == 0) ? "\n" : "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).Length);
	}

	private void D91498B4(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch Work", "Danh sa\u0301ch Work", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		list_0 = fNhapDuLieu4.list_0;
		Common.DB181F2D(btnNhapWork, list_0.Count);
	}

	private void btnNhapHighSchool_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(EC23F5AD, "Nhâ\u0323p danh sa\u0301ch High School", "Danh sa\u0301ch High School", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		EC23F5AD = fNhapDuLieu4.list_0;
		Common.DB181F2D(btnNhapHighSchool, EC23F5AD.Count);
	}

	private void A637B019_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(DA9C6530, "Nhâ\u0323p danh sa\u0301ch College", "Danh sa\u0301ch College", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		DA9C6530 = fNhapDuLieu4.list_0;
		Common.DB181F2D(A637B019, DA9C6530.Count);
	}

	private void btnNhapCurrentCity_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_1, "Nhâ\u0323p danh sa\u0301ch Current City", "Danh sa\u0301ch Current City", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		list_1 = fNhapDuLieu4.list_0;
		Common.DB181F2D(btnNhapCurrentCity, list_1.Count);
	}

	private void B9B70FB8(object sender, EventArgs e)
	{
		A299E485.Enabled = D9AB050C.Checked;
	}

	private void A299E485_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_2, "Nhâ\u0323p danh sa\u0301ch Hometown", "Danh sa\u0301ch Hometown", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		list_2 = fNhapDuLieu4.list_0;
		Common.DB181F2D(A299E485, list_2.Count);
	}

	private void E033E681(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_3, "Nhâ\u0323p danh sa\u0301ch ngày", "Danh sa\u0301ch ngày", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		list_3 = fNhapDuLieu4.list_0;
	}

	private void ED31412B(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_4, "Nhâ\u0323p danh sa\u0301ch tháng", "Danh sa\u0301ch tháng", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		list_4 = fNhapDuLieu4.list_0;
	}

	private void E536A139_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_5, "Nhâ\u0323p danh sa\u0301ch năm", "Danh sa\u0301ch năm", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		list_5 = fNhapDuLieu4.list_0;
	}

	private void DA00CB2C_CheckedChanged(object sender, EventArgs e)
	{
		cbbGender.Enabled = DA00CB2C.Checked;
	}

	private void ckbBirthday_CheckedChanged(object sender, EventArgs e)
	{
		btnDay.Enabled = ckbBirthday.Checked;
		D9850487.Enabled = ckbBirthday.Checked;
		E536A139.Enabled = ckbBirthday.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDCapNhatThongTin));
		B1BA403E = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		F19FA493 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		B48D6E8E = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		E536A139 = new System.Windows.Forms.Button();
		D9850487 = new System.Windows.Forms.Button();
		btnDay = new System.Windows.Forms.Button();
		ckbSkipWhenHave = new System.Windows.Forms.CheckBox();
		cbbGender = new System.Windows.Forms.ComboBox();
		ckbBirthday = new System.Windows.Forms.CheckBox();
		EDAC1D39 = new System.Windows.Forms.ComboBox();
		DA00CB2C = new System.Windows.Forms.CheckBox();
		ckbRelationship = new System.Windows.Forms.CheckBox();
		D9AB050C = new System.Windows.Forms.CheckBox();
		ckbCurrentCity = new System.Windows.Forms.CheckBox();
		ckbCollege = new System.Windows.Forms.CheckBox();
		ckbHighSchool = new System.Windows.Forms.CheckBox();
		ckbWork = new System.Windows.Forms.CheckBox();
		A299E485 = new System.Windows.Forms.Button();
		btnNhapCurrentCity = new System.Windows.Forms.Button();
		A637B019 = new System.Windows.Forms.Button();
		btnNhapHighSchool = new System.Windows.Forms.Button();
		btnNhapWork = new System.Windows.Forms.Button();
		FD81F187 = new System.Windows.Forms.CheckBox();
		A19F6907 = new System.Windows.Forms.Button();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		B1BA403E.Fixed = true;
		B1BA403E.Horizontal = true;
		B1BA403E.TargetControl = F19FA493;
		B1BA403E.Vertical = true;
		F19FA493.BackColor = System.Drawing.Color.Transparent;
		F19FA493.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F19FA493.Dock = System.Windows.Forms.DockStyle.Fill;
		F19FA493.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F19FA493.ForeColor = System.Drawing.Color.Black;
		F19FA493.Location = new System.Drawing.Point(0, 0);
		F19FA493.Name = "bunifuCustomLabel1";
		F19FA493.Size = new System.Drawing.Size(476, 31);
		F19FA493.TabIndex = 12;
		F19FA493.Text = "Cấu hình Cập nhật thông tin";
		F19FA493.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(B48D6E8E);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(F19FA493);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(476, 31);
		pnlHeader.TabIndex = 9;
		B48D6E8E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B48D6E8E.Cursor = System.Windows.Forms.Cursors.Hand;
		B48D6E8E.FlatAppearance.BorderSize = 0;
		B48D6E8E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B48D6E8E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B48D6E8E.ForeColor = System.Drawing.Color.White;
		B48D6E8E.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		B48D6E8E.Location = new System.Drawing.Point(445, 1);
		B48D6E8E.Name = "button1";
		B48D6E8E.Size = new System.Drawing.Size(30, 30);
		B48D6E8E.TabIndex = 77;
		B48D6E8E.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B48D6E8E.UseVisualStyleBackColor = true;
		B48D6E8E.Click += new System.EventHandler(B48D6E8E_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(E536A139);
		panel1.Controls.Add(D9850487);
		panel1.Controls.Add(btnDay);
		panel1.Controls.Add(ckbSkipWhenHave);
		panel1.Controls.Add(cbbGender);
		panel1.Controls.Add(ckbBirthday);
		panel1.Controls.Add(EDAC1D39);
		panel1.Controls.Add(DA00CB2C);
		panel1.Controls.Add(ckbRelationship);
		panel1.Controls.Add(D9AB050C);
		panel1.Controls.Add(ckbCurrentCity);
		panel1.Controls.Add(ckbCollege);
		panel1.Controls.Add(ckbHighSchool);
		panel1.Controls.Add(ckbWork);
		panel1.Controls.Add(A299E485);
		panel1.Controls.Add(btnNhapCurrentCity);
		panel1.Controls.Add(A637B019);
		panel1.Controls.Add(btnNhapHighSchool);
		panel1.Controls.Add(btnNhapWork);
		panel1.Controls.Add(FD81F187);
		panel1.Controls.Add(A19F6907);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(479, 447);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		E536A139.Cursor = System.Windows.Forms.Cursors.Hand;
		E536A139.Location = new System.Drawing.Point(384, 335);
		E536A139.Name = "btnYear";
		E536A139.Size = new System.Drawing.Size(61, 25);
		E536A139.TabIndex = 128;
		E536A139.Text = "Năm";
		E536A139.UseVisualStyleBackColor = true;
		E536A139.Click += new System.EventHandler(E536A139_Click);
		D9850487.Cursor = System.Windows.Forms.Cursors.Hand;
		D9850487.Location = new System.Drawing.Point(317, 335);
		D9850487.Name = "btnMonth";
		D9850487.Size = new System.Drawing.Size(61, 25);
		D9850487.TabIndex = 128;
		D9850487.Text = "Tháng";
		D9850487.UseVisualStyleBackColor = true;
		D9850487.Click += new System.EventHandler(ED31412B);
		btnDay.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDay.Location = new System.Drawing.Point(250, 335);
		btnDay.Name = "btnDay";
		btnDay.Size = new System.Drawing.Size(61, 25);
		btnDay.TabIndex = 128;
		btnDay.Text = "Ngày";
		btnDay.UseVisualStyleBackColor = true;
		btnDay.Click += new System.EventHandler(E033E681);
		ckbSkipWhenHave.AutoSize = true;
		ckbSkipWhenHave.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSkipWhenHave.Location = new System.Drawing.Point(29, 366);
		ckbSkipWhenHave.Name = "ckbSkipWhenHave";
		ckbSkipWhenHave.Size = new System.Drawing.Size(228, 20);
		ckbSkipWhenHave.TabIndex = 127;
		ckbSkipWhenHave.Text = "Không cập nhật thông tin nếu đã có";
		ckbSkipWhenHave.UseVisualStyleBackColor = true;
		cbbGender.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbGender.FormattingEnabled = true;
		cbbGender.Location = new System.Drawing.Point(250, 306);
		cbbGender.Name = "cbbGender";
		cbbGender.Size = new System.Drawing.Size(195, 24);
		cbbGender.TabIndex = 126;
		ckbBirthday.AutoSize = true;
		ckbBirthday.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBirthday.Location = new System.Drawing.Point(29, 338);
		ckbBirthday.Name = "ckbBirthday";
		ckbBirthday.Size = new System.Drawing.Size(141, 20);
		ckbBirthday.TabIndex = 125;
		ckbBirthday.Text = "Ngày sinh (Birthday)";
		ckbBirthday.UseVisualStyleBackColor = true;
		ckbBirthday.CheckedChanged += new System.EventHandler(ckbBirthday_CheckedChanged);
		EDAC1D39.Cursor = System.Windows.Forms.Cursors.Hand;
		EDAC1D39.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		EDAC1D39.FormattingEnabled = true;
		EDAC1D39.Location = new System.Drawing.Point(250, 276);
		EDAC1D39.Name = "cbbRelationship";
		EDAC1D39.Size = new System.Drawing.Size(195, 24);
		EDAC1D39.TabIndex = 126;
		DA00CB2C.AutoSize = true;
		DA00CB2C.Cursor = System.Windows.Forms.Cursors.Hand;
		DA00CB2C.Location = new System.Drawing.Point(29, 308);
		DA00CB2C.Name = "ckbGender";
		DA00CB2C.Size = new System.Drawing.Size(127, 20);
		DA00CB2C.TabIndex = 125;
		DA00CB2C.Text = "Giới tính (Gender)";
		DA00CB2C.UseVisualStyleBackColor = true;
		DA00CB2C.CheckedChanged += new System.EventHandler(DA00CB2C_CheckedChanged);
		ckbRelationship.AutoSize = true;
		ckbRelationship.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbRelationship.Location = new System.Drawing.Point(29, 278);
		ckbRelationship.Name = "ckbRelationship";
		ckbRelationship.Size = new System.Drawing.Size(218, 20);
		ckbRelationship.TabIndex = 125;
		ckbRelationship.Text = "Tình trạng quan hệ (Relationship)";
		ckbRelationship.UseVisualStyleBackColor = true;
		ckbRelationship.CheckedChanged += new System.EventHandler(ckbRelationship_CheckedChanged);
		D9AB050C.AutoSize = true;
		D9AB050C.Cursor = System.Windows.Forms.Cursors.Hand;
		D9AB050C.Location = new System.Drawing.Point(29, 247);
		D9AB050C.Name = "ckbHometown";
		D9AB050C.Size = new System.Drawing.Size(156, 20);
		D9AB050C.TabIndex = 125;
		D9AB050C.Text = "Quê quán (Hometown)";
		D9AB050C.UseVisualStyleBackColor = true;
		D9AB050C.CheckedChanged += new System.EventHandler(B9B70FB8);
		ckbCurrentCity.AutoSize = true;
		ckbCurrentCity.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCurrentCity.Location = new System.Drawing.Point(29, 214);
		ckbCurrentCity.Name = "ckbCurrentCity";
		ckbCurrentCity.Size = new System.Drawing.Size(215, 20);
		ckbCurrentCity.TabIndex = 125;
		ckbCurrentCity.Text = "Thành phố hiện tại (Current City)";
		ckbCurrentCity.UseVisualStyleBackColor = true;
		ckbCurrentCity.CheckedChanged += new System.EventHandler(ckbCurrentCity_CheckedChanged);
		ckbCollege.AutoSize = true;
		ckbCollege.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCollege.Location = new System.Drawing.Point(29, 181);
		ckbCollege.Name = "ckbCollege";
		ckbCollege.Size = new System.Drawing.Size(169, 20);
		ckbCollege.TabIndex = 125;
		ckbCollege.Text = "Trường đại học (College)";
		ckbCollege.UseVisualStyleBackColor = true;
		ckbCollege.CheckedChanged += new System.EventHandler(AC99313E);
		ckbHighSchool.AutoSize = true;
		ckbHighSchool.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHighSchool.Location = new System.Drawing.Point(29, 148);
		ckbHighSchool.Name = "ckbHighSchool";
		ckbHighSchool.Size = new System.Drawing.Size(207, 20);
		ckbHighSchool.TabIndex = 125;
		ckbHighSchool.Text = "Trường trung học (High School)";
		ckbHighSchool.UseVisualStyleBackColor = true;
		ckbHighSchool.CheckedChanged += new System.EventHandler(E5A0349C);
		ckbWork.AutoSize = true;
		ckbWork.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWork.Location = new System.Drawing.Point(29, 115);
		ckbWork.Name = "ckbWork";
		ckbWork.Size = new System.Drawing.Size(125, 20);
		ckbWork.TabIndex = 125;
		ckbWork.Text = "Công việc (Work)";
		ckbWork.UseVisualStyleBackColor = true;
		ckbWork.CheckedChanged += new System.EventHandler(ckbWork_CheckedChanged);
		A299E485.Cursor = System.Windows.Forms.Cursors.Hand;
		A299E485.Location = new System.Drawing.Point(250, 243);
		A299E485.Name = "btnNhapHometown";
		A299E485.Size = new System.Drawing.Size(195, 27);
		A299E485.TabIndex = 124;
		A299E485.Text = "Nhập (0)";
		A299E485.UseVisualStyleBackColor = true;
		A299E485.Click += new System.EventHandler(A299E485_Click);
		btnNhapCurrentCity.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapCurrentCity.Location = new System.Drawing.Point(250, 210);
		btnNhapCurrentCity.Name = "btnNhapCurrentCity";
		btnNhapCurrentCity.Size = new System.Drawing.Size(195, 27);
		btnNhapCurrentCity.TabIndex = 124;
		btnNhapCurrentCity.Text = "Nhập (0)";
		btnNhapCurrentCity.UseVisualStyleBackColor = true;
		btnNhapCurrentCity.Click += new System.EventHandler(btnNhapCurrentCity_Click);
		A637B019.Cursor = System.Windows.Forms.Cursors.Hand;
		A637B019.Location = new System.Drawing.Point(250, 177);
		A637B019.Name = "btnNhapCollege";
		A637B019.Size = new System.Drawing.Size(195, 27);
		A637B019.TabIndex = 124;
		A637B019.Text = "Nhập (0)";
		A637B019.UseVisualStyleBackColor = true;
		A637B019.Click += new System.EventHandler(A637B019_Click);
		btnNhapHighSchool.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapHighSchool.Location = new System.Drawing.Point(250, 144);
		btnNhapHighSchool.Name = "btnNhapHighSchool";
		btnNhapHighSchool.Size = new System.Drawing.Size(195, 27);
		btnNhapHighSchool.TabIndex = 124;
		btnNhapHighSchool.Text = "Nhập (0)";
		btnNhapHighSchool.UseVisualStyleBackColor = true;
		btnNhapHighSchool.Click += new System.EventHandler(btnNhapHighSchool_Click);
		btnNhapWork.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapWork.Location = new System.Drawing.Point(250, 111);
		btnNhapWork.Name = "btnNhapWork";
		btnNhapWork.Size = new System.Drawing.Size(195, 27);
		btnNhapWork.TabIndex = 124;
		btnNhapWork.Text = "Nhập (0)";
		btnNhapWork.UseVisualStyleBackColor = true;
		btnNhapWork.Click += new System.EventHandler(D91498B4);
		FD81F187.AutoSize = true;
		FD81F187.Cursor = System.Windows.Forms.Cursors.Hand;
		FD81F187.Location = new System.Drawing.Point(29, 82);
		FD81F187.Name = "ckbBio";
		FD81F187.Size = new System.Drawing.Size(191, 20);
		FD81F187.TabIndex = 125;
		FD81F187.Text = "Tiểu sử mô tả bản thân (Bio)";
		FD81F187.UseVisualStyleBackColor = true;
		FD81F187.CheckedChanged += new System.EventHandler(FAB711BD);
		A19F6907.Cursor = System.Windows.Forms.Cursors.Hand;
		A19F6907.Location = new System.Drawing.Point(250, 78);
		A19F6907.Name = "btnNhapBio";
		A19F6907.Size = new System.Drawing.Size(195, 27);
		A19F6907.TabIndex = 124;
		A19F6907.Text = "Nhập (0)";
		A19F6907.UseVisualStyleBackColor = true;
		A19F6907.Click += new System.EventHandler(A19F6907_Click);
		txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(320, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(26, 52);
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
		btnCancel.Location = new System.Drawing.Point(246, 402);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(139, 402);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(F0B85220);
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
		bunifuCards1.Size = new System.Drawing.Size(476, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(479, 447);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDCapNhatThongTin";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDCapNhatThongTin_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
