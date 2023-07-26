using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDChiaSeLivestream : Form
{
	internal JSON_Settings EC3EE8B2;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int A1BF5C03;

	internal static bool bool_0;

	internal IContainer B2B029B3 = null;

	internal BunifuDragControl D639E681;

	internal BunifuDragControl DE937D16;

	internal Panel panel1;

	internal TextBox FB3E5CAB;

	internal Label label1;

	internal Button btnCancel;

	internal Button BFAFFAAC;

	internal BunifuCards D3B630A3;

	internal Panel pnlHeader;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel B03B0E1E;

	internal CheckBox ckbVanBan;

	internal Panel plVanBan;

	internal Label label8;

	internal Label ACB1BE95;

	internal RadioButton A19B4095;

	internal RadioButton D9077FA7;

	internal Label label9;

	internal Button btnDown;

	internal Button CD249525;

	internal Button btnMinimize;

	internal GroupBox groupBox1;

	internal NumericUpDown C2B3A1A2;

	internal NumericUpDown nudDelayFrom;

	internal Label ABAE34B4;

	internal Label label14;

	internal Label D1825884;

	internal GroupBox groupBox2;

	internal Panel CD3BE802;

	internal CheckBox ckbChiaSeLenNhom;

	internal CheckBox ckbChiaSeLenTuong;

	internal NumericUpDown nudCountGroupTo;

	internal NumericUpDown nudCountGroupFrom;

	internal Label BF8961A0;

	internal Label label17;

	internal Label label18;

	internal Label E29FF63A;

	internal TextBox txtLinkChiaSe;

	internal RichTextBox txtNoiDung;

	internal Panel AD8C1F82;

	internal CheckBox A1BCE21F;

	internal Panel D022641B;

	internal Panel plBinhLuanNhieuLan;

	internal NumericUpDown nudBinhLuanNhieuLanDelayTo;

	internal Label FB1EB012;

	internal NumericUpDown nudBinhLuanNhieuLanDelayFrom;

	internal Label label5;

	internal Label E3AF6C98;

	internal CheckBox ckbBinhLuanNhieuLan;

	internal Label label3;

	internal TextBox EF01CE0F;

	internal Label B7986418;

	internal Panel plInteract;

	internal Label label25;

	internal Label B4986CB4;

	internal Label C1396F2B;

	internal Label label29;

	internal Label label30;

	internal CheckBox ckbGian;

	internal CheckBox ckbBuon;

	internal CheckBox ckbWow;

	internal CheckBox ckbHaha;

	internal CheckBox ckbTym;

	internal CheckBox BE3BAA30;

	internal Label label32;

	internal CheckBox F71FA9BD;

	internal CheckBox ckbInteract;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal Label label10;

	internal Label EB0F782E;

	internal Label F3A1BF8E;

	internal Button CEAA9BB0;

	internal Button C229CDB6;

	public fHDChiaSeLivestream(string string_3, int int_0 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		A1BF5C03 = int_0;
		if (Class123.C7BE863B("", "HDChiaSeLivestream").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDChiaSeLivestream', 'Chia sẻ livestream');");
		}
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDChiaSeLivestream");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			FB3E5CAB.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_4);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			BFAFFAAC.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			FB3E5CAB.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		EC3EE8B2 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void D307BA81(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = EC3EE8B2.method_0("nudDelayFrom", 3);
			C2B3A1A2.Value = EC3EE8B2.method_0("nudDelayTo", 5);
			ckbChiaSeLenTuong.Checked = EC3EE8B2.AA824D29("ckbChiaSeLenTuong");
			ckbChiaSeLenNhom.Checked = EC3EE8B2.AA824D29("ckbChiaSeLenNhom");
			nudCountGroupFrom.Value = EC3EE8B2.method_0("nudCountGroupFrom", 1);
			nudCountGroupTo.Value = EC3EE8B2.method_0("nudCountGroupTo", 3);
			ckbVanBan.Checked = EC3EE8B2.AA824D29("ckbVanBan");
			txtNoiDung.Text = EC3EE8B2.GetValue("txtNoiDung");
			if (EC3EE8B2.method_0("typeNganCach") == 1)
			{
				A19B4095.Checked = true;
			}
			else
			{
				D9077FA7.Checked = true;
			}
			txtLinkChiaSe.Text = EC3EE8B2.GetValue("txtLinkChiaSe");
			A1BCE21F.Checked = EC3EE8B2.AA824D29("ckbTuongTacLivestream");
			nudSoLuongFrom.Value = EC3EE8B2.method_0("nudSoLuongFrom", 30);
			nudSoLuongTo.Value = EC3EE8B2.method_0("nudSoLuongTo", 30);
			ckbInteract.Checked = EC3EE8B2.AA824D29("ckbInteract");
			string text = EC3EE8B2.GetValue("typeReaction");
			List<CheckBox> list = new List<CheckBox> { BE3BAA30, ckbTym, ckbHaha, ckbWow, ckbBuon, ckbGian };
			for (int i = 0; i < list.Count; i++)
			{
				if (text.Contains(i.ToString()))
				{
					list[i].Checked = true;
				}
			}
			F71FA9BD.Checked = EC3EE8B2.AA824D29("ckbComment");
			EF01CE0F.Text = EC3EE8B2.GetValue("txtComment");
			ckbBinhLuanNhieuLan.Checked = EC3EE8B2.AA824D29("ckbBinhLuanNhieuLan");
			nudBinhLuanNhieuLanDelayFrom.Value = EC3EE8B2.method_0("nudBinhLuanNhieuLanDelayFrom", 10);
			nudBinhLuanNhieuLanDelayTo.Value = EC3EE8B2.method_0("nudBinhLuanNhieuLanDelayTo", 10);
		}
		catch
		{
		}
		C6336C3E();
	}

	private void E5097BBB(object sender, EventArgs e)
	{
		Close();
	}

	private void BFAFFAAC_Click(object sender, EventArgs e)
	{
		string text = FB3E5CAB.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("ckbChiaSeLenTuong", ckbChiaSeLenTuong.Checked);
		f72FAFBC.GetValue("ckbChiaSeLenNhom", ckbChiaSeLenNhom.Checked);
		f72FAFBC.GetValue("nudCountGroupFrom", nudCountGroupFrom.Value);
		f72FAFBC.GetValue("nudCountGroupTo", nudCountGroupTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", C2B3A1A2.Value);
		f72FAFBC.GetValue("txtLinkChiaSe", (object)txtLinkChiaSe.Text.Trim());
		f72FAFBC.GetValue("ckbVanBan", ckbVanBan.Checked);
		f72FAFBC.GetValue("txtNoiDung", (object)txtNoiDung.Text.Trim());
		int num = 0;
		if (A19B4095.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		f72FAFBC.GetValue("ckbTuongTacLivestream", A1BCE21F.Checked);
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		List<CheckBox> list = new List<CheckBox> { BE3BAA30, ckbTym, ckbHaha, ckbWow, ckbBuon, ckbGian };
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Checked)
			{
				text2 += i;
			}
		}
		f72FAFBC.GetValue("typeReaction", (object)text2);
		f72FAFBC.GetValue("ckbComment", F71FA9BD.Checked);
		f72FAFBC.GetValue("txtComment", (object)EF01CE0F.Text.Trim());
		f72FAFBC.GetValue("ckbBinhLuanNhieuLan", ckbBinhLuanNhieuLan.Checked);
		f72FAFBC.GetValue("nudBinhLuanNhieuLanDelayFrom", nudBinhLuanNhieuLanDelayFrom.Value);
		f72FAFBC.GetValue("nudBinhLuanNhieuLanDelayTo", nudBinhLuanNhieuLanDelayTo.Value);
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (A1BF5C03 == 0)
		{
			if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, d9253C2E))
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
		else if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class123.smethod_14(string_2, text, d9253C2E))
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

	private void CBAF3A2F(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void C6336C3E()
	{
		ckbVanBan_CheckedChanged(null, null);
		ckbChiaSeLenNhom_CheckedChanged(null, null);
		A1BCE21F_CheckedChanged(null, null);
		E7811700(null, null);
		F71FA9BD_CheckedChanged(null, null);
		ckbBinhLuanNhieuLan_CheckedChanged(null, null);
	}

	private void ckbVanBan_CheckedChanged(object sender, EventArgs e)
	{
		plVanBan.Enabled = ckbVanBan.Checked;
	}

	private void CB1ADF82(object sender, EventArgs e)
	{
		E5ACCF1E();
	}

	private void E5ACCF1E()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!D9077FA7.Checked) ? txtNoiDung.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtNoiDung.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			ACB1BE95.Text = string.Format(Language.GetValue("Danh sa\u0301ch nô\u0323i dung ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void B997D100(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			CD249525.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		groupBox1.Height = 290;
	}

	private void C20B543C(object sender, EventArgs e)
	{
		groupBox1.Height = 246;
	}

	private void D9077FA7_CheckedChanged(object sender, EventArgs e)
	{
		E5ACCF1E();
	}

	private void A48C7529(object sender, EventArgs e)
	{
		E5ACCF1E();
	}

	private void ckbChiaSeLenNhom_CheckedChanged(object sender, EventArgs e)
	{
		CD3BE802.Enabled = ckbChiaSeLenNhom.Checked;
	}

	private void A1BCE21F_CheckedChanged(object sender, EventArgs e)
	{
		AD8C1F82.Enabled = A1BCE21F.Checked;
	}

	private void E7811700(object sender, EventArgs e)
	{
		plInteract.Enabled = ckbInteract.Checked;
	}

	private void F71FA9BD_CheckedChanged(object sender, EventArgs e)
	{
		D022641B.Enabled = F71FA9BD.Checked;
	}

	private void ckbBinhLuanNhieuLan_CheckedChanged(object sender, EventArgs e)
	{
		plBinhLuanNhieuLan.Enabled = ckbBinhLuanNhieuLan.Checked;
	}

	private void EF01CE0F_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!D9077FA7.Checked) ? EF01CE0F.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : EF01CE0F.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			B7986418.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void BC24A503(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	private void B2B00620(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && B2B029B3 != null)
		{
			B2B029B3.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		B2B029B3 = new System.ComponentModel.Container();
		D639E681 = new Bunifu.Framework.UI.BunifuDragControl(B2B029B3);
		B03B0E1E = new Bunifu.Framework.UI.BunifuCustomLabel();
		DE937D16 = new Bunifu.Framework.UI.BunifuDragControl(B2B029B3);
		pnlHeader = new System.Windows.Forms.Panel();
		btnMinimize = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		AD8C1F82 = new System.Windows.Forms.Panel();
		D022641B = new System.Windows.Forms.Panel();
		plBinhLuanNhieuLan = new System.Windows.Forms.Panel();
		nudBinhLuanNhieuLanDelayTo = new System.Windows.Forms.NumericUpDown();
		FB1EB012 = new System.Windows.Forms.Label();
		nudBinhLuanNhieuLanDelayFrom = new System.Windows.Forms.NumericUpDown();
		label5 = new System.Windows.Forms.Label();
		E3AF6C98 = new System.Windows.Forms.Label();
		ckbBinhLuanNhieuLan = new System.Windows.Forms.CheckBox();
		label3 = new System.Windows.Forms.Label();
		EF01CE0F = new System.Windows.Forms.TextBox();
		B7986418 = new System.Windows.Forms.Label();
		plInteract = new System.Windows.Forms.Panel();
		label25 = new System.Windows.Forms.Label();
		B4986CB4 = new System.Windows.Forms.Label();
		C1396F2B = new System.Windows.Forms.Label();
		label29 = new System.Windows.Forms.Label();
		label30 = new System.Windows.Forms.Label();
		ckbGian = new System.Windows.Forms.CheckBox();
		ckbBuon = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		BE3BAA30 = new System.Windows.Forms.CheckBox();
		label32 = new System.Windows.Forms.Label();
		F71FA9BD = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		label10 = new System.Windows.Forms.Label();
		EB0F782E = new System.Windows.Forms.Label();
		F3A1BF8E = new System.Windows.Forms.Label();
		groupBox2 = new System.Windows.Forms.GroupBox();
		CD3BE802 = new System.Windows.Forms.Panel();
		nudCountGroupTo = new System.Windows.Forms.NumericUpDown();
		nudCountGroupFrom = new System.Windows.Forms.NumericUpDown();
		BF8961A0 = new System.Windows.Forms.Label();
		label17 = new System.Windows.Forms.Label();
		label18 = new System.Windows.Forms.Label();
		ckbChiaSeLenNhom = new System.Windows.Forms.CheckBox();
		ckbChiaSeLenTuong = new System.Windows.Forms.CheckBox();
		C2B3A1A2 = new System.Windows.Forms.NumericUpDown();
		A1BCE21F = new System.Windows.Forms.CheckBox();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		ABAE34B4 = new System.Windows.Forms.Label();
		label14 = new System.Windows.Forms.Label();
		D1825884 = new System.Windows.Forms.Label();
		groupBox1 = new System.Windows.Forms.GroupBox();
		ckbVanBan = new System.Windows.Forms.CheckBox();
		plVanBan = new System.Windows.Forms.Panel();
		btnDown = new System.Windows.Forms.Button();
		CD249525 = new System.Windows.Forms.Button();
		A19B4095 = new System.Windows.Forms.RadioButton();
		D9077FA7 = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		txtNoiDung = new System.Windows.Forms.RichTextBox();
		label8 = new System.Windows.Forms.Label();
		ACB1BE95 = new System.Windows.Forms.Label();
		E29FF63A = new System.Windows.Forms.Label();
		txtLinkChiaSe = new System.Windows.Forms.TextBox();
		BFAFFAAC = new System.Windows.Forms.Button();
		FB3E5CAB = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		D3B630A3 = new Bunifu.Framework.UI.BunifuCards();
		CEAA9BB0 = new System.Windows.Forms.Button();
		C229CDB6 = new System.Windows.Forms.Button();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		AD8C1F82.SuspendLayout();
		D022641B.SuspendLayout();
		plBinhLuanNhieuLan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayFrom).BeginInit();
		plInteract.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		groupBox2.SuspendLayout();
		CD3BE802.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountGroupTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountGroupFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)C2B3A1A2).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		groupBox1.SuspendLayout();
		plVanBan.SuspendLayout();
		D3B630A3.SuspendLayout();
		SuspendLayout();
		D639E681.Fixed = true;
		D639E681.Horizontal = true;
		D639E681.TargetControl = B03B0E1E;
		D639E681.Vertical = true;
		B03B0E1E.BackColor = System.Drawing.Color.Transparent;
		B03B0E1E.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B03B0E1E.Dock = System.Windows.Forms.DockStyle.Fill;
		B03B0E1E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B03B0E1E.ForeColor = System.Drawing.Color.Black;
		B03B0E1E.Location = new System.Drawing.Point(0, 0);
		B03B0E1E.Name = "bunifuCustomLabel1";
		B03B0E1E.Size = new System.Drawing.Size(875, 31);
		B03B0E1E.TabIndex = 12;
		B03B0E1E.Text = "Cấu hình Chia sẻ livestream";
		B03B0E1E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DE937D16.Fixed = true;
		DE937D16.Horizontal = true;
		DE937D16.TargetControl = pnlHeader;
		DE937D16.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(B03B0E1E);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(875, 31);
		pnlHeader.TabIndex = 9;
		btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = Resource.Bitmap_9;
		btnMinimize.Location = new System.Drawing.Point(842, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 79;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(E5097BBB);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(B997D100);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(AD8C1F82);
		panel1.Controls.Add(groupBox2);
		panel1.Controls.Add(C2B3A1A2);
		panel1.Controls.Add(A1BCE21F);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(ABAE34B4);
		panel1.Controls.Add(label14);
		panel1.Controls.Add(D1825884);
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(BFAFFAAC);
		panel1.Controls.Add(FB3E5CAB);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(D3B630A3);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(878, 501);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(CBAF3A2F);
		AD8C1F82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		AD8C1F82.Controls.Add(D022641B);
		AD8C1F82.Controls.Add(plInteract);
		AD8C1F82.Controls.Add(F71FA9BD);
		AD8C1F82.Controls.Add(ckbInteract);
		AD8C1F82.Controls.Add(nudSoLuongTo);
		AD8C1F82.Controls.Add(nudSoLuongFrom);
		AD8C1F82.Controls.Add(label10);
		AD8C1F82.Controls.Add(EB0F782E);
		AD8C1F82.Controls.Add(F3A1BF8E);
		AD8C1F82.Location = new System.Drawing.Point(530, 89);
		AD8C1F82.Name = "plTuongTacLivestream";
		AD8C1F82.Size = new System.Drawing.Size(315, 351);
		AD8C1F82.TabIndex = 53;
		D022641B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D022641B.Controls.Add(plBinhLuanNhieuLan);
		D022641B.Controls.Add(ckbBinhLuanNhieuLan);
		D022641B.Controls.Add(label3);
		D022641B.Controls.Add(EF01CE0F);
		D022641B.Controls.Add(B7986418);
		D022641B.Location = new System.Drawing.Point(25, 128);
		D022641B.Name = "plComment";
		D022641B.Size = new System.Drawing.Size(278, 213);
		D022641B.TabIndex = 43;
		plBinhLuanNhieuLan.Controls.Add(nudBinhLuanNhieuLanDelayTo);
		plBinhLuanNhieuLan.Controls.Add(FB1EB012);
		plBinhLuanNhieuLan.Controls.Add(nudBinhLuanNhieuLanDelayFrom);
		plBinhLuanNhieuLan.Controls.Add(label5);
		plBinhLuanNhieuLan.Controls.Add(E3AF6C98);
		plBinhLuanNhieuLan.Location = new System.Drawing.Point(19, 182);
		plBinhLuanNhieuLan.Name = "plBinhLuanNhieuLan";
		plBinhLuanNhieuLan.Size = new System.Drawing.Size(254, 27);
		plBinhLuanNhieuLan.TabIndex = 134;
		nudBinhLuanNhieuLanDelayTo.Cursor = System.Windows.Forms.Cursors.Hand;
		nudBinhLuanNhieuLanDelayTo.Location = new System.Drawing.Point(174, 2);
		nudBinhLuanNhieuLanDelayTo.Maximum = new decimal(new int[4] { 100000000, 0, 0, 0 });
		nudBinhLuanNhieuLanDelayTo.Name = "nudBinhLuanNhieuLanDelayTo";
		nudBinhLuanNhieuLanDelayTo.Size = new System.Drawing.Size(50, 23);
		nudBinhLuanNhieuLanDelayTo.TabIndex = 22;
		FB1EB012.AutoSize = true;
		FB1EB012.Location = new System.Drawing.Point(4, 4);
		FB1EB012.Name = "lblmc1";
		FB1EB012.Size = new System.Drawing.Size(73, 16);
		FB1EB012.TabIndex = 18;
		FB1EB012.Text = "Delay time:";
		nudBinhLuanNhieuLanDelayFrom.Cursor = System.Windows.Forms.Cursors.Hand;
		nudBinhLuanNhieuLanDelayFrom.Location = new System.Drawing.Point(86, 2);
		nudBinhLuanNhieuLanDelayFrom.Maximum = new decimal(new int[4] { 100000000, 0, 0, 0 });
		nudBinhLuanNhieuLanDelayFrom.Name = "nudBinhLuanNhieuLanDelayFrom";
		nudBinhLuanNhieuLanDelayFrom.Size = new System.Drawing.Size(45, 23);
		nudBinhLuanNhieuLanDelayFrom.TabIndex = 21;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(226, 4);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(31, 16);
		label5.TabIndex = 20;
		label5.Text = "giây";
		E3AF6C98.Location = new System.Drawing.Point(133, 4);
		E3AF6C98.Name = "label6";
		E3AF6C98.Size = new System.Drawing.Size(39, 16);
		E3AF6C98.TabIndex = 20;
		E3AF6C98.Text = "đến";
		E3AF6C98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ckbBinhLuanNhieuLan.AutoSize = true;
		ckbBinhLuanNhieuLan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBinhLuanNhieuLan.Location = new System.Drawing.Point(7, 163);
		ckbBinhLuanNhieuLan.Name = "ckbBinhLuanNhieuLan";
		ckbBinhLuanNhieuLan.Size = new System.Drawing.Size(135, 20);
		ckbBinhLuanNhieuLan.TabIndex = 133;
		ckbBinhLuanNhieuLan.Text = "Bình luận nhiều lần";
		ckbBinhLuanNhieuLan.UseVisualStyleBackColor = true;
		ckbBinhLuanNhieuLan.CheckedChanged += new System.EventHandler(ckbBinhLuanNhieuLan_CheckedChanged);
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(3, 141);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(266, 16);
		label3.TabIndex = 2;
		label3.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		EF01CE0F.Location = new System.Drawing.Point(7, 27);
		EF01CE0F.Multiline = true;
		EF01CE0F.Name = "txtComment";
		EF01CE0F.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		EF01CE0F.Size = new System.Drawing.Size(261, 111);
		EF01CE0F.TabIndex = 1;
		EF01CE0F.WordWrap = false;
		EF01CE0F.TextChanged += new System.EventHandler(EF01CE0F_TextChanged);
		B7986418.AutoSize = true;
		B7986418.Location = new System.Drawing.Point(3, 5);
		B7986418.Name = "label4";
		B7986418.Size = new System.Drawing.Size(140, 16);
		B7986418.TabIndex = 0;
		B7986418.Text = "Nội dung bình luận (0):";
		plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plInteract.Controls.Add(label25);
		plInteract.Controls.Add(B4986CB4);
		plInteract.Controls.Add(C1396F2B);
		plInteract.Controls.Add(label29);
		plInteract.Controls.Add(label30);
		plInteract.Controls.Add(ckbGian);
		plInteract.Controls.Add(ckbBuon);
		plInteract.Controls.Add(ckbWow);
		plInteract.Controls.Add(ckbHaha);
		plInteract.Controls.Add(ckbTym);
		plInteract.Controls.Add(BE3BAA30);
		plInteract.Controls.Add(label32);
		plInteract.Location = new System.Drawing.Point(25, 59);
		plInteract.Name = "plInteract";
		plInteract.Size = new System.Drawing.Size(278, 40);
		plInteract.TabIndex = 41;
		label25.Cursor = System.Windows.Forms.Cursors.Hand;
		label25.Location = new System.Drawing.Point(4, 1);
		label25.Name = "label25";
		label25.Size = new System.Drawing.Size(30, 16);
		label25.TabIndex = 0;
		label25.Text = "Like";
		label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B4986CB4.Cursor = System.Windows.Forms.Cursors.Hand;
		B4986CB4.Location = new System.Drawing.Point(46, 1);
		B4986CB4.Name = "label26";
		B4986CB4.Size = new System.Drawing.Size(39, 16);
		B4986CB4.TabIndex = 2;
		B4986CB4.Text = "Tym";
		B4986CB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C1396F2B.Cursor = System.Windows.Forms.Cursors.Hand;
		C1396F2B.Location = new System.Drawing.Point(93, 1);
		C1396F2B.Name = "label28";
		C1396F2B.Size = new System.Drawing.Size(37, 16);
		C1396F2B.TabIndex = 6;
		C1396F2B.Text = "Haha";
		C1396F2B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label29.Cursor = System.Windows.Forms.Cursors.Hand;
		label29.Location = new System.Drawing.Point(140, 1);
		label29.Name = "label29";
		label29.Size = new System.Drawing.Size(37, 16);
		label29.TabIndex = 8;
		label29.Text = "Wow";
		label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label30.Cursor = System.Windows.Forms.Cursors.Hand;
		label30.Location = new System.Drawing.Point(187, 1);
		label30.Name = "label30";
		label30.Size = new System.Drawing.Size(36, 16);
		label30.TabIndex = 10;
		label30.Text = "Buồn";
		label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ckbGian.AutoSize = true;
		ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGian.Location = new System.Drawing.Point(246, 20);
		ckbGian.Name = "ckbGian";
		ckbGian.Size = new System.Drawing.Size(15, 14);
		ckbGian.TabIndex = 13;
		ckbGian.UseVisualStyleBackColor = true;
		ckbBuon.AutoSize = true;
		ckbBuon.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBuon.Location = new System.Drawing.Point(199, 20);
		ckbBuon.Name = "ckbBuon";
		ckbBuon.Size = new System.Drawing.Size(15, 14);
		ckbBuon.TabIndex = 11;
		ckbBuon.UseVisualStyleBackColor = true;
		ckbWow.AutoSize = true;
		ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWow.Location = new System.Drawing.Point(152, 20);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new System.Drawing.Size(15, 14);
		ckbWow.TabIndex = 9;
		ckbWow.UseVisualStyleBackColor = true;
		ckbHaha.AutoSize = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Location = new System.Drawing.Point(105, 20);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(15, 14);
		ckbHaha.TabIndex = 7;
		ckbHaha.UseVisualStyleBackColor = true;
		ckbTym.AutoSize = true;
		ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTym.Location = new System.Drawing.Point(58, 20);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new System.Drawing.Size(15, 14);
		ckbTym.TabIndex = 3;
		ckbTym.UseVisualStyleBackColor = true;
		BE3BAA30.AutoSize = true;
		BE3BAA30.Cursor = System.Windows.Forms.Cursors.Hand;
		BE3BAA30.Location = new System.Drawing.Point(11, 20);
		BE3BAA30.Name = "ckbLike";
		BE3BAA30.Size = new System.Drawing.Size(15, 14);
		BE3BAA30.TabIndex = 1;
		BE3BAA30.UseVisualStyleBackColor = true;
		label32.Cursor = System.Windows.Forms.Cursors.Hand;
		label32.Location = new System.Drawing.Point(230, 1);
		label32.Name = "label32";
		label32.Size = new System.Drawing.Size(44, 16);
		label32.TabIndex = 12;
		label32.Text = "Giận";
		label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F71FA9BD.AutoSize = true;
		F71FA9BD.Cursor = System.Windows.Forms.Cursors.Hand;
		F71FA9BD.Location = new System.Drawing.Point(7, 103);
		F71FA9BD.Name = "ckbComment";
		F71FA9BD.Size = new System.Drawing.Size(131, 20);
		F71FA9BD.TabIndex = 42;
		F71FA9BD.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		F71FA9BD.UseVisualStyleBackColor = true;
		F71FA9BD.CheckedChanged += new System.EventHandler(F71FA9BD_CheckedChanged);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(7, 35);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(113, 20);
		ckbInteract.TabIndex = 40;
		ckbInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(E7811700);
		nudSoLuongTo.Location = new System.Drawing.Point(206, 6);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 39;
		nudSoLuongFrom.Location = new System.Drawing.Point(109, 6);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 38;
		label10.Location = new System.Drawing.Point(171, 8);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(29, 16);
		label10.TabIndex = 46;
		label10.Text = "đê\u0301n";
		label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		EB0F782E.AutoSize = true;
		EB0F782E.Location = new System.Drawing.Point(267, 8);
		EB0F782E.Name = "label11";
		EB0F782E.Size = new System.Drawing.Size(31, 16);
		EB0F782E.TabIndex = 45;
		EB0F782E.Text = "giây";
		F3A1BF8E.AutoSize = true;
		F3A1BF8E.Location = new System.Drawing.Point(4, 8);
		F3A1BF8E.Name = "label12";
		F3A1BF8E.Size = new System.Drawing.Size(94, 16);
		F3A1BF8E.TabIndex = 44;
		F3A1BF8E.Text = "Thời gian xem:";
		groupBox2.Controls.Add(CD3BE802);
		groupBox2.Controls.Add(ckbChiaSeLenNhom);
		groupBox2.Controls.Add(ckbChiaSeLenTuong);
		groupBox2.Location = new System.Drawing.Point(30, 107);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(475, 81);
		groupBox2.TabIndex = 52;
		groupBox2.TabStop = false;
		groupBox2.Text = "Tùy chọn chia sẻ";
		CD3BE802.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		CD3BE802.Controls.Add(nudCountGroupTo);
		CD3BE802.Controls.Add(nudCountGroupFrom);
		CD3BE802.Controls.Add(BF8961A0);
		CD3BE802.Controls.Add(label17);
		CD3BE802.Controls.Add(label18);
		CD3BE802.Location = new System.Drawing.Point(157, 47);
		CD3BE802.Name = "plDangBaiLenNhom";
		CD3BE802.Size = new System.Drawing.Size(310, 27);
		CD3BE802.TabIndex = 1;
		nudCountGroupTo.Location = new System.Drawing.Point(205, 1);
		nudCountGroupTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountGroupTo.Name = "nudCountGroupTo";
		nudCountGroupTo.Size = new System.Drawing.Size(56, 23);
		nudCountGroupTo.TabIndex = 53;
		nudCountGroupFrom.Location = new System.Drawing.Point(108, 1);
		nudCountGroupFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountGroupFrom.Name = "nudCountGroupFrom";
		nudCountGroupFrom.Size = new System.Drawing.Size(56, 23);
		nudCountGroupFrom.TabIndex = 52;
		BF8961A0.Location = new System.Drawing.Point(170, 3);
		BF8961A0.Name = "label16";
		BF8961A0.Size = new System.Drawing.Size(29, 16);
		BF8961A0.TabIndex = 56;
		BF8961A0.Text = "đê\u0301n";
		BF8961A0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label17.AutoSize = true;
		label17.Location = new System.Drawing.Point(264, 3);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(40, 16);
		label17.TabIndex = 55;
		label17.Text = "nhóm";
		label18.AutoSize = true;
		label18.Location = new System.Drawing.Point(3, 3);
		label18.Name = "label18";
		label18.Size = new System.Drawing.Size(100, 16);
		label18.TabIndex = 54;
		label18.Text = "Số lượng nhóm:";
		ckbChiaSeLenNhom.AutoSize = true;
		ckbChiaSeLenNhom.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChiaSeLenNhom.Location = new System.Drawing.Point(11, 49);
		ckbChiaSeLenNhom.Name = "ckbChiaSeLenNhom";
		ckbChiaSeLenNhom.Size = new System.Drawing.Size(126, 20);
		ckbChiaSeLenNhom.TabIndex = 0;
		ckbChiaSeLenNhom.Text = "Chia sẻ lên nhóm";
		ckbChiaSeLenNhom.UseVisualStyleBackColor = true;
		ckbChiaSeLenNhom.CheckedChanged += new System.EventHandler(ckbChiaSeLenNhom_CheckedChanged);
		ckbChiaSeLenTuong.AutoSize = true;
		ckbChiaSeLenTuong.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChiaSeLenTuong.Location = new System.Drawing.Point(11, 23);
		ckbChiaSeLenTuong.Name = "ckbChiaSeLenTuong";
		ckbChiaSeLenTuong.Size = new System.Drawing.Size(127, 20);
		ckbChiaSeLenTuong.TabIndex = 0;
		ckbChiaSeLenTuong.Text = "Chia sẻ lên tường";
		ckbChiaSeLenTuong.UseVisualStyleBackColor = true;
		C2B3A1A2.Location = new System.Drawing.Point(220, 78);
		C2B3A1A2.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C2B3A1A2.Name = "nudDelayTo";
		C2B3A1A2.Size = new System.Drawing.Size(56, 23);
		C2B3A1A2.TabIndex = 48;
		A1BCE21F.AutoSize = true;
		A1BCE21F.Cursor = System.Windows.Forms.Cursors.Hand;
		A1BCE21F.Location = new System.Drawing.Point(530, 66);
		A1BCE21F.Name = "ckbTuongTacLivestream";
		A1BCE21F.Size = new System.Drawing.Size(238, 20);
		A1BCE21F.TabIndex = 0;
		A1BCE21F.Text = "Tương tác livestream trước khi share";
		A1BCE21F.UseVisualStyleBackColor = true;
		A1BCE21F.CheckedChanged += new System.EventHandler(A1BCE21F_CheckedChanged);
		nudDelayFrom.Location = new System.Drawing.Point(123, 78);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 47;
		ABAE34B4.Location = new System.Drawing.Point(185, 80);
		ABAE34B4.Name = "label15";
		ABAE34B4.Size = new System.Drawing.Size(29, 16);
		ABAE34B4.TabIndex = 51;
		ABAE34B4.Text = "đê\u0301n";
		ABAE34B4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label14.AutoSize = true;
		label14.Location = new System.Drawing.Point(279, 80);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(31, 16);
		label14.TabIndex = 50;
		label14.Text = "giây";
		D1825884.AutoSize = true;
		D1825884.Location = new System.Drawing.Point(27, 80);
		D1825884.Name = "label13";
		D1825884.Size = new System.Drawing.Size(90, 16);
		D1825884.TabIndex = 49;
		D1825884.Text = "Thời gian chờ:";
		groupBox1.Controls.Add(ckbVanBan);
		groupBox1.Controls.Add(plVanBan);
		groupBox1.Controls.Add(E29FF63A);
		groupBox1.Controls.Add(txtLinkChiaSe);
		groupBox1.Location = new System.Drawing.Point(30, 194);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(475, 246);
		groupBox1.TabIndex = 34;
		groupBox1.TabStop = false;
		groupBox1.Text = "Cấu hình nội dung chia sẻ";
		ckbVanBan.AutoSize = true;
		ckbVanBan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbVanBan.Location = new System.Drawing.Point(11, 50);
		ckbVanBan.Name = "ckbVanBan";
		ckbVanBan.Size = new System.Drawing.Size(121, 20);
		ckbVanBan.TabIndex = 32;
		ckbVanBan.Text = "Nội dung chia sẻ";
		ckbVanBan.UseVisualStyleBackColor = true;
		ckbVanBan.CheckedChanged += new System.EventHandler(ckbVanBan_CheckedChanged);
		plVanBan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plVanBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plVanBan.Controls.Add(CEAA9BB0);
		plVanBan.Controls.Add(C229CDB6);
		plVanBan.Controls.Add(btnDown);
		plVanBan.Controls.Add(CD249525);
		plVanBan.Controls.Add(A19B4095);
		plVanBan.Controls.Add(D9077FA7);
		plVanBan.Controls.Add(label9);
		plVanBan.Controls.Add(txtNoiDung);
		plVanBan.Controls.Add(label8);
		plVanBan.Controls.Add(ACB1BE95);
		plVanBan.Location = new System.Drawing.Point(28, 74);
		plVanBan.Name = "plVanBan";
		plVanBan.Size = new System.Drawing.Size(439, 163);
		plVanBan.TabIndex = 33;
		btnDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnDown.BackgroundImage = Resource.Bitmap_91;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.Location = new System.Drawing.Point(382, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 38;
		btnDown.Visible = false;
		btnDown.Click += new System.EventHandler(btnDown_Click);
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CD249525.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		CD249525.BackgroundImage = Resource.Bitmap_73;
		CD249525.Cursor = System.Windows.Forms.Cursors.Hand;
		CD249525.Location = new System.Drawing.Point(413, -1);
		CD249525.Name = "btnUp";
		CD249525.Size = new System.Drawing.Size(25, 25);
		CD249525.TabIndex = 39;
		CD249525.Visible = false;
		CD249525.Click += new System.EventHandler(C20B543C);
		CD249525.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		CD249525.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A19B4095.AutoSize = true;
		A19B4095.Cursor = System.Windows.Forms.Cursors.Hand;
		A19B4095.Location = new System.Drawing.Point(69, 183);
		A19B4095.Name = "rbNganCachKyTu";
		A19B4095.Size = new System.Drawing.Size(160, 20);
		A19B4095.TabIndex = 37;
		A19B4095.Text = "Nội dung có nhiều dòng";
		A19B4095.UseVisualStyleBackColor = true;
		A19B4095.CheckedChanged += new System.EventHandler(A48C7529);
		D9077FA7.AutoSize = true;
		D9077FA7.Checked = true;
		D9077FA7.Cursor = System.Windows.Forms.Cursors.Hand;
		D9077FA7.Location = new System.Drawing.Point(69, 162);
		D9077FA7.Name = "rbNganCachMoiDong";
		D9077FA7.Size = new System.Drawing.Size(156, 20);
		D9077FA7.TabIndex = 36;
		D9077FA7.TabStop = true;
		D9077FA7.Text = "Nội dung chỉ có 1 dòng";
		D9077FA7.UseVisualStyleBackColor = true;
		D9077FA7.CheckedChanged += new System.EventHandler(D9077FA7_CheckedChanged);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(4, 162);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(65, 16);
		label9.TabIndex = 35;
		label9.Text = "Tùy chọn:";
		txtNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtNoiDung.Location = new System.Drawing.Point(7, 24);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new System.Drawing.Size(424, 114);
		txtNoiDung.TabIndex = 34;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += new System.EventHandler(CB1ADF82);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 141);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(266, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		ACB1BE95.AutoSize = true;
		ACB1BE95.Location = new System.Drawing.Point(3, 5);
		ACB1BE95.Name = "lblStatus";
		ACB1BE95.Size = new System.Drawing.Size(146, 16);
		ACB1BE95.TabIndex = 0;
		ACB1BE95.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		E29FF63A.AutoSize = true;
		E29FF63A.Location = new System.Drawing.Point(8, 26);
		E29FF63A.Name = "label2";
		E29FF63A.Size = new System.Drawing.Size(98, 16);
		E29FF63A.TabIndex = 31;
		E29FF63A.Text = "Link livestream:";
		txtLinkChiaSe.Location = new System.Drawing.Point(112, 23);
		txtLinkChiaSe.Name = "txtLinkChiaSe";
		txtLinkChiaSe.Size = new System.Drawing.Size(355, 23);
		txtLinkChiaSe.TabIndex = 0;
		BFAFFAAC.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		BFAFFAAC.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		BFAFFAAC.Cursor = System.Windows.Forms.Cursors.Hand;
		BFAFFAAC.FlatAppearance.BorderSize = 0;
		BFAFFAAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BFAFFAAC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BFAFFAAC.ForeColor = System.Drawing.Color.White;
		BFAFFAAC.Location = new System.Drawing.Point(343, 454);
		BFAFFAAC.Name = "btnAdd";
		BFAFFAAC.Size = new System.Drawing.Size(92, 29);
		BFAFFAAC.TabIndex = 3;
		BFAFFAAC.Text = "Thêm";
		BFAFFAAC.UseVisualStyleBackColor = false;
		BFAFFAAC.Click += new System.EventHandler(BFAFFAAC_Click);
		FB3E5CAB.Location = new System.Drawing.Point(123, 49);
		FB3E5CAB.Name = "txtTenHanhDong";
		FB3E5CAB.Size = new System.Drawing.Size(193, 23);
		FB3E5CAB.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(442, 454);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		D3B630A3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D3B630A3.BackColor = System.Drawing.Color.White;
		D3B630A3.BorderRadius = 0;
		D3B630A3.BottomSahddow = true;
		D3B630A3.color = System.Drawing.Color.DarkViolet;
		D3B630A3.Controls.Add(pnlHeader);
		D3B630A3.LeftSahddow = false;
		D3B630A3.Location = new System.Drawing.Point(1, 0);
		D3B630A3.Name = "bunifuCards1";
		D3B630A3.RightSahddow = true;
		D3B630A3.ShadowDepth = 20;
		D3B630A3.Size = new System.Drawing.Size(875, 37);
		D3B630A3.TabIndex = 28;
		CEAA9BB0.Cursor = System.Windows.Forms.Cursors.Help;
		CEAA9BB0.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CEAA9BB0.Location = new System.Drawing.Point(223, 185);
		CEAA9BB0.Name = "button3";
		CEAA9BB0.Size = new System.Drawing.Size(21, 23);
		CEAA9BB0.TabIndex = 195;
		CEAA9BB0.Text = "?";
		CEAA9BB0.UseVisualStyleBackColor = true;
		CEAA9BB0.Click += new System.EventHandler(B2B00620);
		C229CDB6.Cursor = System.Windows.Forms.Cursors.Help;
		C229CDB6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C229CDB6.Location = new System.Drawing.Point(223, 162);
		C229CDB6.Name = "button2";
		C229CDB6.Size = new System.Drawing.Size(21, 23);
		C229CDB6.TabIndex = 196;
		C229CDB6.Text = "?";
		C229CDB6.UseVisualStyleBackColor = true;
		C229CDB6.Click += new System.EventHandler(BC24A503);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(878, 501);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChiaSeLivestream";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D307BA81);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		AD8C1F82.ResumeLayout(false);
		AD8C1F82.PerformLayout();
		D022641B.ResumeLayout(false);
		D022641B.PerformLayout();
		plBinhLuanNhieuLan.ResumeLayout(false);
		plBinhLuanNhieuLan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayFrom).EndInit();
		plInteract.ResumeLayout(false);
		plInteract.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		CD3BE802.ResumeLayout(false);
		CD3BE802.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountGroupTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountGroupFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)C2B3A1A2).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		plVanBan.ResumeLayout(false);
		plVanBan.PerformLayout();
		D3B630A3.ResumeLayout(false);
		ResumeLayout(false);
	}
}
