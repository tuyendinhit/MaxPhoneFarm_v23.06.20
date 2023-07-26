using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacVideo : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string DA827A32;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal List<CheckBox> CD19529E;

	internal IContainer C93AC916 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl E69DA38D;

	internal Panel E383869B;

	internal NumericUpDown F121AB13;

	internal NumericUpDown F781A39C;

	internal TextBox txtTenHanhDong;

	internal Label label3;

	internal Label label4;

	internal Label AE847B3C;

	internal Label label1;

	internal Button btnCancel;

	internal Button A238AB1F;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label lblStatus;

	internal CheckBox ckbComment;

	internal CheckBox ckbInteract;

	internal Label label8;

	internal Panel plBinhLuanNhieuLan;

	internal NumericUpDown nudBinhLuanNhieuLanDelayTo;

	internal Label F183BE8B;

	internal NumericUpDown nudBinhLuanNhieuLanDelayFrom;

	internal Label label5;

	internal Label label7;

	internal Label label6;

	internal CheckBox ckbBinhLuanNhieuLan;

	internal TextBox txtLinkVideo;

	internal Label label9;

	internal LinkLabel linkLabel1;

	internal Panel DC0DF6BF;

	internal CheckBox ckbGian;

	internal CheckBox ckbBuon;

	internal CheckBox CF9169B2;

	internal CheckBox ckbHaha;

	internal CheckBox ckbThuong;

	internal CheckBox ckbTym;

	internal CheckBox ckbLike;

	internal Panel panel7;

	internal RadioButton radioButton3;

	internal RadioButton ABAC2FBD;

	internal Label label26;

	internal CheckBox E21C4AAE;

	internal RichTextBox EC1981BF;

	public fHDTuongTacVideo(string string_2, int int_1 = 0, string E49BF087 = "")
	{
		InitializeComponent();
		bool_0 = false;
		DA827A32 = string_2;
		string_1 = E49BF087;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Tương tác Video";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\",\"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(E49BF087);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			A238AB1F.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDTuongTacVideo_Load(object sender, EventArgs e)
	{
		try
		{
			txtLinkVideo.Text = f72FAFBC_0.GetValue("txtLinkVideo");
			F781A39C.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 30);
			F121AB13.Value = f72FAFBC_0.method_0("nudSoLuongTo", 30);
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			string text = f72FAFBC_0.GetValue("typeReaction");
			CD19529E = new List<CheckBox> { ckbLike, ckbTym, ckbThuong, ckbHaha, CF9169B2, ckbBuon, ckbGian };
			for (int i = 0; i < CD19529E.Count; i++)
			{
				CD19529E[i].Checked = text.Contains(i.ToString());
			}
			ckbComment.Checked = f72FAFBC_0.AA824D29("ckbComment");
			EC1981BF.Text = f72FAFBC_0.GetValue("txtComment");
			ckbBinhLuanNhieuLan.Checked = f72FAFBC_0.AA824D29("ckbBinhLuanNhieuLan");
			nudBinhLuanNhieuLanDelayFrom.Value = f72FAFBC_0.method_0("nudBinhLuanNhieuLanDelayFrom", 10);
			nudBinhLuanNhieuLanDelayTo.Value = f72FAFBC_0.method_0("nudBinhLuanNhieuLanDelayTo", 10);
			E21C4AAE.Checked = f72FAFBC_0.AA824D29("ckbTuDongXoaNoiDung");
		}
		catch
		{
		}
		method_0();
	}

	private void CA263E2A(object sender, EventArgs e)
	{
		Close();
	}

	private void A238AB1F_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> f1808BA = EC1981BF.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtLinkVideo", (object)txtLinkVideo.Text.Trim());
		f72FAFBC.GetValue("nudSoLuongFrom", F781A39C.Value);
		f72FAFBC.GetValue("nudSoLuongTo", F121AB13.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		for (int i = 0; i < CD19529E.Count; i++)
		{
			text2 += (CD19529E[i].Checked ? (i.ToString() ?? "") : "");
		}
		f72FAFBC.GetValue("typeReaction", (object)text2);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)EC1981BF.Text.Trim());
		f72FAFBC.GetValue("ckbBinhLuanNhieuLan", ckbBinhLuanNhieuLan.Checked);
		f72FAFBC.GetValue("nudBinhLuanNhieuLanDelayFrom", nudBinhLuanNhieuLanDelayFrom.Value);
		f72FAFBC.GetValue("nudBinhLuanNhieuLanDelayTo", nudBinhLuanNhieuLanDelayTo.Value);
		f72FAFBC.GetValue("ckbTuDongXoaNoiDung", E21C4AAE.Checked);
		string text3 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(DA827A32, text, string_0, text3))
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

	private void E383869B_Paint(object sender, PaintEventArgs e)
	{
		if (E383869B.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, E383869B.ClientSize.Width - num, E383869B.ClientSize.Height - num));
		}
	}

	private void method_0()
	{
		ckbInteract_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
		ckbBinhLuanNhieuLan_CheckedChanged(null, null);
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		DC0DF6BF.Enabled = ckbInteract.Checked;
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void F52DA2A5(object sender, EventArgs e)
	{
		ckbLike.Checked = !ckbLike.Checked;
	}

	private void method_1(object sender, EventArgs e)
	{
		ckbTym.Checked = !ckbTym.Checked;
	}

	private void EABDB828(object sender, EventArgs e)
	{
		ckbHaha.Checked = !ckbHaha.Checked;
	}

	private void method_2(object sender, EventArgs e)
	{
		CF9169B2.Checked = !CF9169B2.Checked;
	}

	private void F0034FB8(object sender, EventArgs e)
	{
		ckbBuon.Checked = !ckbBuon.Checked;
	}

	private void method_3(object sender, EventArgs e)
	{
		ckbGian.Checked = !ckbGian.Checked;
	}

	private void ckbBinhLuanNhieuLan_CheckedChanged(object sender, EventArgs e)
	{
		plBinhLuanNhieuLan.Enabled = ckbBinhLuanNhieuLan.Checked;
	}

	private void F53D2A07(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void EC1981BF_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(EC1981BF, lblStatus);
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && C93AC916 != null)
		{
			C93AC916.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		C93AC916 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacVideo));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(C93AC916);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		E69DA38D = new Bunifu.Framework.UI.BunifuDragControl(C93AC916);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		E383869B = new System.Windows.Forms.Panel();
		DC0DF6BF = new System.Windows.Forms.Panel();
		ckbGian = new System.Windows.Forms.CheckBox();
		ckbBuon = new System.Windows.Forms.CheckBox();
		CF9169B2 = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbThuong = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		panel7 = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		ABAC2FBD = new System.Windows.Forms.RadioButton();
		label26 = new System.Windows.Forms.Label();
		plComment = new System.Windows.Forms.Panel();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		plBinhLuanNhieuLan = new System.Windows.Forms.Panel();
		nudBinhLuanNhieuLanDelayTo = new System.Windows.Forms.NumericUpDown();
		F183BE8B = new System.Windows.Forms.Label();
		nudBinhLuanNhieuLanDelayFrom = new System.Windows.Forms.NumericUpDown();
		label5 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		ckbBinhLuanNhieuLan = new System.Windows.Forms.CheckBox();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		ckbComment = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		F121AB13 = new System.Windows.Forms.NumericUpDown();
		F781A39C = new System.Windows.Forms.NumericUpDown();
		txtLinkVideo = new System.Windows.Forms.TextBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		AE847B3C = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		A238AB1F = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		E21C4AAE = new System.Windows.Forms.CheckBox();
		EC1981BF = new System.Windows.Forms.RichTextBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		E383869B.SuspendLayout();
		DC0DF6BF.SuspendLayout();
		panel7.SuspendLayout();
		plComment.SuspendLayout();
		plBinhLuanNhieuLan.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)F121AB13).BeginInit();
		((System.ComponentModel.ISupportInitialize)F781A39C).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(392, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Video";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E69DA38D.Fixed = true;
		E69DA38D.Horizontal = true;
		E69DA38D.TargetControl = pnlHeader;
		E69DA38D.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(392, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(361, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(CA263E2A);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		E383869B.BackColor = System.Drawing.Color.White;
		E383869B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E383869B.Controls.Add(DC0DF6BF);
		E383869B.Controls.Add(plComment);
		E383869B.Controls.Add(ckbComment);
		E383869B.Controls.Add(ckbInteract);
		E383869B.Controls.Add(F121AB13);
		E383869B.Controls.Add(F781A39C);
		E383869B.Controls.Add(txtLinkVideo);
		E383869B.Controls.Add(txtTenHanhDong);
		E383869B.Controls.Add(label3);
		E383869B.Controls.Add(label4);
		E383869B.Controls.Add(label9);
		E383869B.Controls.Add(AE847B3C);
		E383869B.Controls.Add(label1);
		E383869B.Controls.Add(btnCancel);
		E383869B.Controls.Add(A238AB1F);
		E383869B.Controls.Add(bunifuCards1);
		E383869B.Cursor = System.Windows.Forms.Cursors.Arrow;
		E383869B.Dock = System.Windows.Forms.DockStyle.Fill;
		E383869B.Location = new System.Drawing.Point(0, 0);
		E383869B.Name = "panel1";
		E383869B.Size = new System.Drawing.Size(395, 526);
		E383869B.TabIndex = 0;
		E383869B.Paint += new System.Windows.Forms.PaintEventHandler(E383869B_Paint);
		DC0DF6BF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		DC0DF6BF.Controls.Add(ckbGian);
		DC0DF6BF.Controls.Add(ckbBuon);
		DC0DF6BF.Controls.Add(CF9169B2);
		DC0DF6BF.Controls.Add(ckbHaha);
		DC0DF6BF.Controls.Add(ckbThuong);
		DC0DF6BF.Controls.Add(ckbTym);
		DC0DF6BF.Controls.Add(ckbLike);
		DC0DF6BF.Controls.Add(panel7);
		DC0DF6BF.Controls.Add(label26);
		DC0DF6BF.Location = new System.Drawing.Point(48, 162);
		DC0DF6BF.Name = "plInteract";
		DC0DF6BF.Size = new System.Drawing.Size(312, 33);
		DC0DF6BF.TabIndex = 181;
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
		CF9169B2.Cursor = System.Windows.Forms.Cursors.Hand;
		CF9169B2.Image = Resource.F391A116;
		CF9169B2.Location = new System.Drawing.Point(178, 1);
		CF9169B2.Name = "ckbWow";
		CF9169B2.Size = new System.Drawing.Size(40, 30);
		CF9169B2.TabIndex = 177;
		CF9169B2.UseVisualStyleBackColor = true;
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
		panel7.Controls.Add(radioButton3);
		panel7.Controls.Add(ABAC2FBD);
		panel7.Location = new System.Drawing.Point(67, 300);
		panel7.Name = "panel7";
		panel7.Size = new System.Drawing.Size(200, 43);
		panel7.TabIndex = 43;
		radioButton3.AutoSize = true;
		radioButton3.Checked = true;
		radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton3.Location = new System.Drawing.Point(3, 2);
		radioButton3.Name = "radioButton3";
		radioButton3.Size = new System.Drawing.Size(201, 20);
		radioButton3.TabIndex = 3;
		radioButton3.TabStop = true;
		radioButton3.Text = "Comment theo thứ tự nội dung";
		radioButton3.UseVisualStyleBackColor = true;
		ABAC2FBD.AutoSize = true;
		ABAC2FBD.Cursor = System.Windows.Forms.Cursors.Hand;
		ABAC2FBD.Location = new System.Drawing.Point(3, 23);
		ABAC2FBD.Name = "radioButton4";
		ABAC2FBD.Size = new System.Drawing.Size(200, 20);
		ABAC2FBD.TabIndex = 3;
		ABAC2FBD.Text = "Comment ngẫu nhiên nội dung";
		ABAC2FBD.UseVisualStyleBackColor = true;
		label26.AutoSize = true;
		label26.Location = new System.Drawing.Point(4, 302);
		label26.Name = "label26";
		label26.Size = new System.Drawing.Size(64, 16);
		label26.TabIndex = 2;
		label26.Text = "Tùy chọn:";
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(EC1981BF);
		plComment.Controls.Add(E21C4AAE);
		plComment.Controls.Add(linkLabel1);
		plComment.Controls.Add(plBinhLuanNhieuLan);
		plComment.Controls.Add(ckbBinhLuanNhieuLan);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(lblStatus);
		plComment.Location = new System.Drawing.Point(48, 226);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(312, 236);
		plComment.TabIndex = 8;
		linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.Location = new System.Drawing.Point(224, 141);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(81, 16);
		linkLabel1.TabIndex = 192;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(F53D2A07);
		plBinhLuanNhieuLan.Controls.Add(nudBinhLuanNhieuLanDelayTo);
		plBinhLuanNhieuLan.Controls.Add(F183BE8B);
		plBinhLuanNhieuLan.Controls.Add(nudBinhLuanNhieuLanDelayFrom);
		plBinhLuanNhieuLan.Controls.Add(label5);
		plBinhLuanNhieuLan.Controls.Add(label7);
		plBinhLuanNhieuLan.Controls.Add(label6);
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
		F183BE8B.AutoSize = true;
		F183BE8B.Location = new System.Drawing.Point(4, 4);
		F183BE8B.Name = "lblmc1";
		F183BE8B.Size = new System.Drawing.Size(72, 16);
		F183BE8B.TabIndex = 18;
		F183BE8B.Text = "Delay time:";
		nudBinhLuanNhieuLanDelayFrom.Cursor = System.Windows.Forms.Cursors.Hand;
		nudBinhLuanNhieuLanDelayFrom.Location = new System.Drawing.Point(96, 2);
		nudBinhLuanNhieuLanDelayFrom.Maximum = new decimal(new int[4] { 100000000, 0, 0, 0 });
		nudBinhLuanNhieuLanDelayFrom.Name = "nudBinhLuanNhieuLanDelayFrom";
		nudBinhLuanNhieuLanDelayFrom.Size = new System.Drawing.Size(45, 23);
		nudBinhLuanNhieuLanDelayFrom.TabIndex = 21;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(226, 4);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(30, 16);
		label5.TabIndex = 20;
		label5.Text = "giây";
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(75, 4);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(19, 16);
		label7.TabIndex = 20;
		label7.Text = "từ";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(143, 4);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(28, 16);
		label6.TabIndex = 20;
		label6.Text = "đến";
		ckbBinhLuanNhieuLan.AutoSize = true;
		ckbBinhLuanNhieuLan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBinhLuanNhieuLan.Location = new System.Drawing.Point(7, 163);
		ckbBinhLuanNhieuLan.Name = "ckbBinhLuanNhieuLan";
		ckbBinhLuanNhieuLan.Size = new System.Drawing.Size(134, 20);
		ckbBinhLuanNhieuLan.TabIndex = 133;
		ckbBinhLuanNhieuLan.Text = "Bình luận nhiều lần";
		ckbBinhLuanNhieuLan.UseVisualStyleBackColor = true;
		ckbBinhLuanNhieuLan.CheckedChanged += new System.EventHandler(ckbBinhLuanNhieuLan_CheckedChanged);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(3, 141);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(143, 16);
		label8.TabIndex = 2;
		label8.Text = "(Spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(30, 201);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(130, 20);
		ckbComment.TabIndex = 7;
		ckbComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 136);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(112, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		F121AB13.Location = new System.Drawing.Point(229, 107);
		F121AB13.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F121AB13.Name = "nudSoLuongTo";
		F121AB13.Size = new System.Drawing.Size(56, 23);
		F121AB13.TabIndex = 2;
		F781A39C.Location = new System.Drawing.Point(132, 107);
		F781A39C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F781A39C.Name = "nudSoLuongFrom";
		F781A39C.Size = new System.Drawing.Size(56, 23);
		F781A39C.TabIndex = 1;
		txtLinkVideo.Location = new System.Drawing.Point(132, 78);
		txtLinkVideo.Name = "txtLinkVideo";
		txtLinkVideo.Size = new System.Drawing.Size(228, 23);
		txtLinkVideo.TabIndex = 0;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(228, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.Location = new System.Drawing.Point(194, 109);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(290, 109);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(30, 16);
		label4.TabIndex = 35;
		label4.Text = "giây";
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(27, 81);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(68, 16);
		label9.TabIndex = 31;
		label9.Text = "Link video:";
		AE847B3C.AutoSize = true;
		AE847B3C.Location = new System.Drawing.Point(27, 109);
		AE847B3C.Name = "label2";
		AE847B3C.Size = new System.Drawing.Size(93, 16);
		AE847B3C.TabIndex = 32;
		AE847B3C.Text = "Thời gian xem:";
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
		btnCancel.Location = new System.Drawing.Point(205, 482);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		A238AB1F.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A238AB1F.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		A238AB1F.Cursor = System.Windows.Forms.Cursors.Hand;
		A238AB1F.FlatAppearance.BorderSize = 0;
		A238AB1F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A238AB1F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A238AB1F.ForeColor = System.Drawing.Color.White;
		A238AB1F.Location = new System.Drawing.Point(98, 482);
		A238AB1F.Name = "btnAdd";
		A238AB1F.Size = new System.Drawing.Size(92, 29);
		A238AB1F.TabIndex = 9;
		A238AB1F.Text = "Thêm";
		A238AB1F.UseVisualStyleBackColor = false;
		A238AB1F.Click += new System.EventHandler(A238AB1F_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(392, 37);
		bunifuCards1.TabIndex = 28;
		E21C4AAE.AutoSize = true;
		E21C4AAE.Cursor = System.Windows.Forms.Cursors.Hand;
		E21C4AAE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		E21C4AAE.Location = new System.Drawing.Point(7, 213);
		E21C4AAE.Name = "ckbTuDongXoaNoiDung";
		E21C4AAE.Size = new System.Drawing.Size(219, 20);
		E21C4AAE.TabIndex = 193;
		E21C4AAE.Text = "Tư\u0323 đô\u0323ng xo\u0301a nô\u0323i dung đa\u0303 sư\u0309 du\u0323ng";
		E21C4AAE.UseVisualStyleBackColor = true;
		EC1981BF.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		EC1981BF.Location = new System.Drawing.Point(7, 24);
		EC1981BF.Name = "txtComment";
		EC1981BF.Size = new System.Drawing.Size(298, 114);
		EC1981BF.TabIndex = 194;
		EC1981BF.Text = "";
		EC1981BF.WordWrap = false;
		EC1981BF.TextChanged += new System.EventHandler(EC1981BF_TextChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(395, 526);
		base.Controls.Add(E383869B);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacVideo";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTuongTacVideo_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		E383869B.ResumeLayout(false);
		E383869B.PerformLayout();
		DC0DF6BF.ResumeLayout(false);
		DC0DF6BF.PerformLayout();
		panel7.ResumeLayout(false);
		panel7.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		plBinhLuanNhieuLan.ResumeLayout(false);
		plBinhLuanNhieuLan.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudBinhLuanNhieuLanDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)F121AB13).EndInit();
		((System.ComponentModel.ISupportInitialize)F781A39C).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
