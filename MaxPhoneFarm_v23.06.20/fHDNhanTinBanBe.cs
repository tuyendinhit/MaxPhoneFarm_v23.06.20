using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDNhanTinBanBe : Form
{
	internal JObject jobject_0;

	internal string FD0479B1;

	internal string F619F6AA;

	internal string FBADCE31;

	internal int F194A9BE;

	internal static bool A4093DAE;

	internal IContainer A63269A8 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl F30CA4A9;

	internal Panel panel1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown F5AD4338;

	internal TextBox txtTenHanhDong;

	internal Label label3;

	internal Label B4207805;

	internal Label label2;

	internal Label label1;

	internal Button btnCancel;

	internal Button DF004EBC;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox FB8CF58B;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label label8;

	internal Label lblStatus;

	internal TextBox C903978A;

	internal NumericUpDown B0A7B329;

	internal NumericUpDown E5A8DC0D;

	internal Label label7;

	internal Label D10C7117;

	internal Label label5;

	internal RadioButton E71645A4;

	internal RadioButton BB1BBF1B;

	internal Label A7281190;

	internal Panel plUidChiDinh;

	internal TextBox txtUidChiDinh;

	internal Label CB1C3B18;

	internal Label lblStatusUid;

	internal RadioButton rbTrucTuyen;

	internal Button C381FD37;

	public fHDNhanTinBanBe(string string_0, int A5808A06 = 0, string string_1 = "")
	{
		InitializeComponent();
		A4093DAE = false;
		FD0479B1 = string_0;
		FBADCE31 = string_1;
		F194A9BE = A5808A06;
		string json = "";
		switch (A5808A06)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDNhanTinBanBe");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			F619F6AA = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_1);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			DF004EBC.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void B4AA0A1F()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(label2);
		Language.smethod_1(label3);
		Language.smethod_1(B4207805);
		Language.smethod_1(label5);
		Language.smethod_1(label7);
		Language.smethod_1(D10C7117);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(A7281190);
		Language.smethod_1(BB1BBF1B);
		Language.smethod_1(E71645A4);
		Language.smethod_1(rbTrucTuyen);
		Language.smethod_1(lblStatusUid);
		Language.smethod_1(CB1C3B18);
		Language.smethod_1(DF004EBC);
		Language.smethod_1(btnCancel);
	}

	private void fHDNhanTinBanBe_Load(object sender, EventArgs e)
	{
		try
		{
			F5AD4338.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			E5A8DC0D.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			B0A7B329.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			C903978A.Text = jobject_0["txtTinNhan"]!.ToString();
			switch (Convert.ToInt32(jobject_0["typeDoiTuong"]))
			{
			case 0:
				BB1BBF1B.Checked = true;
				break;
			case 1:
				E71645A4.Checked = true;
				break;
			case 2:
				rbTrucTuyen.Checked = true;
				break;
			}
			txtUidChiDinh.Text = jobject_0["txtUidChiDinh"]!.ToString();
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

	private void B13380A0(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> f1808BA = C903978A.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhă\u0301n!"), 3);
			return;
		}
		if (E71645A4.Checked)
		{
			f1808BA = txtUidChiDinh.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sách UID cần nhắn tin!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", F5AD4338.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", E5A8DC0D.Value);
		f72FAFBC.GetValue("nudDelayTo", B0A7B329.Value);
		f72FAFBC.GetValue("txtTinNhan", (object)C903978A.Text.Trim());
		if (BB1BBF1B.Checked)
		{
			f72FAFBC.GetValue("typeDoiTuong", 0);
		}
		else if (E71645A4.Checked)
		{
			f72FAFBC.GetValue("typeDoiTuong", 1);
		}
		else
		{
			f72FAFBC.GetValue("typeDoiTuong", 2);
		}
		f72FAFBC.GetValue("txtUidChiDinh", (object)txtUidChiDinh.Text.Trim());
		string text2 = f72FAFBC.C71A4EA4();
		if (F194A9BE == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(FD0479B1, text, F619F6AA, text2))
				{
					A4093DAE = true;
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
			if (Class123.smethod_14(FBADCE31, text, text2))
			{
				A4093DAE = true;
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

	private void method_0(object sender, EventArgs e)
	{
	}

	private void C903978A_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = C903978A.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch tin nhă\u0301n ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void C8A90036(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		plUidChiDinh.Enabled = E71645A4.Checked;
	}

	private void BB1BBF1B_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void txtUidChiDinh_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUidChiDinh.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatusUid.Text = string.Format(Language.GetValue("Danh sách UID ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void CE128881(object sender, EventArgs e)
	{
	}

	private void FB8CF58B_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			rbTrucTuyen.Visible = true;
		}
	}

	private void C381FD37_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người nhận tin nhắn!"));
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && A63269A8 != null)
		{
			A63269A8.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		A63269A8 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDNhanTinBanBe));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(A63269A8);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		F30CA4A9 = new Bunifu.Framework.UI.BunifuDragControl(A63269A8);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		FB8CF58B = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plUidChiDinh = new System.Windows.Forms.Panel();
		txtUidChiDinh = new System.Windows.Forms.TextBox();
		CB1C3B18 = new System.Windows.Forms.Label();
		lblStatusUid = new System.Windows.Forms.Label();
		E71645A4 = new System.Windows.Forms.RadioButton();
		rbTrucTuyen = new System.Windows.Forms.RadioButton();
		BB1BBF1B = new System.Windows.Forms.RadioButton();
		A7281190 = new System.Windows.Forms.Label();
		C903978A = new System.Windows.Forms.TextBox();
		B0A7B329 = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		E5A8DC0D = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		D10C7117 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		F5AD4338 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		B4207805 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		DF004EBC = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		C381FD37 = new System.Windows.Forms.Button();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FB8CF58B).BeginInit();
		panel1.SuspendLayout();
		plUidChiDinh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B0A7B329).BeginInit();
		((System.ComponentModel.ISupportInitialize)E5A8DC0D).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)F5AD4338).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(687, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Nhă\u0301n tin ba\u0323n be\u0300";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F30CA4A9.Fixed = true;
		F30CA4A9.Horizontal = true;
		F30CA4A9.TargetControl = pnlHeader;
		F30CA4A9.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(FB8CF58B);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(687, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(656, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		FB8CF58B.Cursor = System.Windows.Forms.Cursors.Default;
		FB8CF58B.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		FB8CF58B.Location = new System.Drawing.Point(3, 2);
		FB8CF58B.Name = "pictureBox1";
		FB8CF58B.Size = new System.Drawing.Size(34, 27);
		FB8CF58B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		FB8CF58B.TabIndex = 76;
		FB8CF58B.TabStop = false;
		FB8CF58B.Click += new System.EventHandler(FB8CF58B_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(C381FD37);
		panel1.Controls.Add(plUidChiDinh);
		panel1.Controls.Add(E71645A4);
		panel1.Controls.Add(rbTrucTuyen);
		panel1.Controls.Add(BB1BBF1B);
		panel1.Controls.Add(A7281190);
		panel1.Controls.Add(C903978A);
		panel1.Controls.Add(B0A7B329);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(E5A8DC0D);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(D10C7117);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(F5AD4338);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(B4207805);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(DF004EBC);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(690, 349);
		panel1.TabIndex = 0;
		panel1.Click += new System.EventHandler(CE128881);
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plUidChiDinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plUidChiDinh.Controls.Add(txtUidChiDinh);
		plUidChiDinh.Controls.Add(CB1C3B18);
		plUidChiDinh.Controls.Add(lblStatusUid);
		plUidChiDinh.Location = new System.Drawing.Point(375, 120);
		plUidChiDinh.Name = "plUidChiDinh";
		plUidChiDinh.Size = new System.Drawing.Size(281, 164);
		plUidChiDinh.TabIndex = 49;
		txtUidChiDinh.Location = new System.Drawing.Point(7, 27);
		txtUidChiDinh.Multiline = true;
		txtUidChiDinh.Name = "txtUidChiDinh";
		txtUidChiDinh.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtUidChiDinh.Size = new System.Drawing.Size(266, 111);
		txtUidChiDinh.TabIndex = 1;
		txtUidChiDinh.WordWrap = false;
		txtUidChiDinh.TextChanged += new System.EventHandler(txtUidChiDinh_TextChanged);
		CB1C3B18.AutoSize = true;
		CB1C3B18.Location = new System.Drawing.Point(4, 141);
		CB1C3B18.Name = "label10";
		CB1C3B18.Size = new System.Drawing.Size(105, 16);
		CB1C3B18.TabIndex = 0;
		CB1C3B18.Text = "(Mỗi UID 1 dòng)";
		lblStatusUid.AutoSize = true;
		lblStatusUid.Location = new System.Drawing.Point(3, 5);
		lblStatusUid.Name = "lblStatusUid";
		lblStatusUid.Size = new System.Drawing.Size(117, 16);
		lblStatusUid.TabIndex = 0;
		lblStatusUid.Text = "Danh sách UID (0):";
		E71645A4.AutoSize = true;
		E71645A4.Cursor = System.Windows.Forms.Cursors.Hand;
		E71645A4.Location = new System.Drawing.Point(375, 94);
		E71645A4.Name = "rbUidChiDinh";
		E71645A4.Size = new System.Drawing.Size(94, 20);
		E71645A4.TabIndex = 48;
		E71645A4.Text = "UID chỉ định";
		E71645A4.UseVisualStyleBackColor = true;
		E71645A4.CheckedChanged += new System.EventHandler(C8A90036);
		rbTrucTuyen.AutoSize = true;
		rbTrucTuyen.Checked = true;
		rbTrucTuyen.Cursor = System.Windows.Forms.Cursors.Hand;
		rbTrucTuyen.Location = new System.Drawing.Point(479, 94);
		rbTrucTuyen.Name = "rbTrucTuyen";
		rbTrucTuyen.Size = new System.Drawing.Size(187, 20);
		rbTrucTuyen.TabIndex = 48;
		rbTrucTuyen.TabStop = true;
		rbTrucTuyen.Text = "Đang trực tuyến (Chưa làm)";
		rbTrucTuyen.UseVisualStyleBackColor = true;
		rbTrucTuyen.Visible = false;
		rbTrucTuyen.CheckedChanged += new System.EventHandler(BB1BBF1B_CheckedChanged);
		BB1BBF1B.AutoSize = true;
		BB1BBF1B.Checked = true;
		BB1BBF1B.Cursor = System.Windows.Forms.Cursors.Hand;
		BB1BBF1B.Location = new System.Drawing.Point(375, 71);
		BB1BBF1B.Name = "rbNgauNhien";
		BB1BBF1B.Size = new System.Drawing.Size(177, 20);
		BB1BBF1B.TabIndex = 48;
		BB1BBF1B.TabStop = true;
		BB1BBF1B.Text = "Ngẫu nhiên danh sách bạn";
		BB1BBF1B.UseVisualStyleBackColor = true;
		BB1BBF1B.CheckedChanged += new System.EventHandler(BB1BBF1B_CheckedChanged);
		A7281190.AutoSize = true;
		A7281190.Location = new System.Drawing.Point(372, 49);
		A7281190.Name = "label9";
		A7281190.Size = new System.Drawing.Size(173, 16);
		A7281190.TabIndex = 47;
		A7281190.Text = "Tùy chọn đối tượng nhắn tin:";
		C903978A.Location = new System.Drawing.Point(31, 158);
		C903978A.Multiline = true;
		C903978A.Name = "txtTinNhan";
		C903978A.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		C903978A.Size = new System.Drawing.Size(295, 107);
		C903978A.TabIndex = 5;
		C903978A.WordWrap = false;
		C903978A.TextChanged += new System.EventHandler(C903978A_TextChanged);
		B0A7B329.Location = new System.Drawing.Point(229, 111);
		B0A7B329.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B0A7B329.Name = "nudDelayTo";
		B0A7B329.Size = new System.Drawing.Size(56, 23);
		B0A7B329.TabIndex = 4;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(27, 268);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(266, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(27, 139);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(143, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch tin nhă\u0301n (0):";
		E5A8DC0D.Location = new System.Drawing.Point(132, 111);
		E5A8DC0D.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E5A8DC0D.Name = "nudDelayFrom";
		E5A8DC0D.Size = new System.Drawing.Size(56, 23);
		E5A8DC0D.TabIndex = 3;
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(194, 113);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		D10C7117.AutoSize = true;
		D10C7117.Location = new System.Drawing.Point(290, 113);
		D10C7117.Name = "label6";
		D10C7117.Size = new System.Drawing.Size(31, 16);
		D10C7117.TabIndex = 45;
		D10C7117.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 113);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(90, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		F5AD4338.Location = new System.Drawing.Point(132, 80);
		F5AD4338.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F5AD4338.Name = "nudSoLuongFrom";
		F5AD4338.Size = new System.Drawing.Size(56, 23);
		F5AD4338.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(194, 82);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		B4207805.AutoSize = true;
		B4207805.Location = new System.Drawing.Point(290, 82);
		B4207805.Name = "label4";
		B4207805.Size = new System.Drawing.Size(29, 16);
		B4207805.TabIndex = 35;
		B4207805.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 82);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(89, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(353, 305);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		DF004EBC.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		DF004EBC.Cursor = System.Windows.Forms.Cursors.Hand;
		DF004EBC.FlatAppearance.BorderSize = 0;
		DF004EBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DF004EBC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DF004EBC.ForeColor = System.Drawing.Color.White;
		DF004EBC.Location = new System.Drawing.Point(246, 305);
		DF004EBC.Name = "btnAdd";
		DF004EBC.Size = new System.Drawing.Size(92, 29);
		DF004EBC.TabIndex = 6;
		DF004EBC.Text = "Thêm";
		DF004EBC.UseVisualStyleBackColor = false;
		DF004EBC.Click += new System.EventHandler(B13380A0);
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
		bunifuCards1.Size = new System.Drawing.Size(687, 37);
		bunifuCards1.TabIndex = 28;
		C381FD37.Cursor = System.Windows.Forms.Cursors.Help;
		C381FD37.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C381FD37.Location = new System.Drawing.Point(304, 265);
		C381FD37.Name = "button2";
		C381FD37.Size = new System.Drawing.Size(23, 23);
		C381FD37.TabIndex = 47;
		C381FD37.Text = "?";
		C381FD37.UseVisualStyleBackColor = true;
		C381FD37.Click += new System.EventHandler(C381FD37_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(690, 349);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDNhanTinBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDNhanTinBanBe_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)FB8CF58B).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plUidChiDinh.ResumeLayout(false);
		plUidChiDinh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)B0A7B329).EndInit();
		((System.ComponentModel.ISupportInitialize)E5A8DC0D).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)F5AD4338).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
