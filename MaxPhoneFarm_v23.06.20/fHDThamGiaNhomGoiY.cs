using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDThamGiaNhomGoiY : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string D8BBB891;

	internal string string_0;

	internal string C3162BAA;

	internal int D12321BD;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl B9060AAB;

	internal Panel panel1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown CF9843AD;

	internal TextBox B4987E12;

	internal Label label3;

	internal Label F230CA21;

	internal Label label2;

	internal Label label1;

	internal Button E6236314;

	internal Button D4B2BC9A;

	internal BunifuCards C1339214;

	internal Panel pnlHeader;

	internal Button DC1E5435;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel AB34BA3A;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudDelayFrom;

	internal Label label7;

	internal Label label6;

	internal Label label5;

	internal ToolTip toolTip_0;

	internal Panel plTuongTac;

	internal CheckBox ckbTuDongTraLoiCauHoi;

	internal TextBox txtCauTraLoi;

	internal Label B9B1D6BF;

	internal Label lblStatusComment;

	public fHDThamGiaNhomGoiY(string string_1, int int_0 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		D8BBB891 = string_1;
		C3162BAA = string_2;
		D12321BD = int_0;
		if (Class123.C7BE863B("", "HDThamGiaNhomGoiY").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDThamGiaNhomGoiY', 'Tham gia nhóm gợi ý');");
		}
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDThamGiaNhomGoiY");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B4987E12.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			D4B2BC9A.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			B4987E12.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(AB34BA3A);
		Language.smethod_1(label1);
		Language.smethod_1(label2);
		Language.smethod_1(label3);
		Language.smethod_1(F230CA21);
		Language.smethod_1(label5);
		Language.smethod_1(label7);
		Language.smethod_1(label6);
		Language.smethod_1(ckbTuDongTraLoiCauHoi);
		Language.smethod_1(lblStatusComment);
		Language.smethod_1(B9B1D6BF);
		Language.smethod_1(D4B2BC9A);
		Language.smethod_1(E6236314);
	}

	private void fHDThamGiaNhomGoiY_Load(object sender, EventArgs e)
	{
		try
		{
			CF9843AD.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = f72FAFBC_0.method_0("nudSoLuongTo", 5);
			nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			ckbTuDongTraLoiCauHoi.Checked = f72FAFBC_0.AA824D29("ckbTuDongTraLoiCauHoi");
			txtCauTraLoi.Text = f72FAFBC_0.GetValue("txtCauTraLoi");
		}
		catch
		{
		}
		FB883639();
	}

	private void FB883639()
	{
		C217CCB3(null, null);
	}

	private void B0A6B2BB(object sender, EventArgs e)
	{
		Close();
	}

	private void F4A7A48D(object sender, EventArgs e)
	{
		string text = B4987E12.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (ckbTuDongTraLoiCauHoi.Checked)
		{
			List<string> f1808BA = txtCauTraLoi.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sách câu trả lời!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", CF9843AD.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("ckbTuDongTraLoiCauHoi", ckbTuDongTraLoiCauHoi.Checked);
		f72FAFBC.GetValue("txtCauTraLoi", (object)txtCauTraLoi.Text.Trim());
		string text2 = f72FAFBC.C71A4EA4();
		if (D12321BD == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(D8BBB891, text, string_0, text2))
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
			if (Class123.smethod_14(C3162BAA, text, text2))
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

	private void B43B9693(object sender, EventArgs e)
	{
		Close();
	}

	private void DF8028B4(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void A2BF1383(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtCauTraLoi.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatusComment.Text = string.Format(Language.GetValue("Danh sách câu trả lời ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void C217CCB3(object sender, EventArgs e)
	{
		plTuongTac.Enabled = ckbTuDongTraLoiCauHoi.Checked;
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
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		AB34BA3A = new Bunifu.Framework.UI.BunifuCustomLabel();
		B9060AAB = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		DC1E5435 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plTuongTac = new System.Windows.Forms.Panel();
		txtCauTraLoi = new System.Windows.Forms.TextBox();
		B9B1D6BF = new System.Windows.Forms.Label();
		lblStatusComment = new System.Windows.Forms.Label();
		ckbTuDongTraLoiCauHoi = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		CF9843AD = new System.Windows.Forms.NumericUpDown();
		B4987E12 = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		F230CA21 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		E6236314 = new System.Windows.Forms.Button();
		D4B2BC9A = new System.Windows.Forms.Button();
		C1339214 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plTuongTac.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)CF9843AD).BeginInit();
		C1339214.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = AB34BA3A;
		bunifuDragControl_0.Vertical = true;
		AB34BA3A.BackColor = System.Drawing.Color.Transparent;
		AB34BA3A.Cursor = System.Windows.Forms.Cursors.SizeAll;
		AB34BA3A.Dock = System.Windows.Forms.DockStyle.Fill;
		AB34BA3A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AB34BA3A.ForeColor = System.Drawing.Color.Black;
		AB34BA3A.Location = new System.Drawing.Point(0, 0);
		AB34BA3A.Name = "bunifuCustomLabel1";
		AB34BA3A.Size = new System.Drawing.Size(363, 31);
		AB34BA3A.TabIndex = 12;
		AB34BA3A.Text = "Cấu hình Tham gia nhóm gợi ý";
		AB34BA3A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B9060AAB.Fixed = true;
		B9060AAB.Horizontal = true;
		B9060AAB.TargetControl = pnlHeader;
		B9060AAB.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(DC1E5435);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(AB34BA3A);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(363, 31);
		pnlHeader.TabIndex = 9;
		DC1E5435.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		DC1E5435.Cursor = System.Windows.Forms.Cursors.Hand;
		DC1E5435.FlatAppearance.BorderSize = 0;
		DC1E5435.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DC1E5435.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DC1E5435.ForeColor = System.Drawing.Color.White;
		DC1E5435.Image = Resource.Bitmap_9;
		DC1E5435.Location = new System.Drawing.Point(332, 1);
		DC1E5435.Name = "button1";
		DC1E5435.Size = new System.Drawing.Size(30, 30);
		DC1E5435.TabIndex = 77;
		DC1E5435.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		DC1E5435.UseVisualStyleBackColor = true;
		DC1E5435.Click += new System.EventHandler(B0A6B2BB);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(plTuongTac);
		panel1.Controls.Add(ckbTuDongTraLoiCauHoi);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(CF9843AD);
		panel1.Controls.Add(B4987E12);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(F230CA21);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(E6236314);
		panel1.Controls.Add(D4B2BC9A);
		panel1.Controls.Add(C1339214);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(366, 395);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(DF8028B4);
		plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuongTac.Controls.Add(txtCauTraLoi);
		plTuongTac.Controls.Add(B9B1D6BF);
		plTuongTac.Controls.Add(lblStatusComment);
		plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		plTuongTac.Location = new System.Drawing.Point(48, 158);
		plTuongTac.Name = "plTuongTac";
		plTuongTac.Size = new System.Drawing.Size(278, 179);
		plTuongTac.TabIndex = 116;
		txtCauTraLoi.Location = new System.Drawing.Point(6, 25);
		txtCauTraLoi.Multiline = true;
		txtCauTraLoi.Name = "txtCauTraLoi";
		txtCauTraLoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtCauTraLoi.Size = new System.Drawing.Size(265, 128);
		txtCauTraLoi.TabIndex = 1;
		txtCauTraLoi.WordWrap = false;
		txtCauTraLoi.TextChanged += new System.EventHandler(A2BF1383);
		B9B1D6BF.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		B9B1D6BF.AutoSize = true;
		B9B1D6BF.Location = new System.Drawing.Point(3, 158);
		B9B1D6BF.Name = "label9";
		B9B1D6BF.Size = new System.Drawing.Size(133, 16);
		B9B1D6BF.TabIndex = 0;
		B9B1D6BF.Text = "(Mỗi nội dung 1 dòng)";
		lblStatusComment.AutoSize = true;
		lblStatusComment.Location = new System.Drawing.Point(3, 4);
		lblStatusComment.Name = "lblStatusComment";
		lblStatusComment.Size = new System.Drawing.Size(153, 16);
		lblStatusComment.TabIndex = 0;
		lblStatusComment.Text = "Danh sách câu trả lời (0):";
		ckbTuDongTraLoiCauHoi.AutoSize = true;
		ckbTuDongTraLoiCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongTraLoiCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongTraLoiCauHoi.Location = new System.Drawing.Point(30, 135);
		ckbTuDongTraLoiCauHoi.Name = "ckbTuDongTraLoiCauHoi";
		ckbTuDongTraLoiCauHoi.Size = new System.Drawing.Size(156, 20);
		ckbTuDongTraLoiCauHoi.TabIndex = 115;
		ckbTuDongTraLoiCauHoi.Text = "Tự động trả lời câu hỏi";
		ckbTuDongTraLoiCauHoi.UseVisualStyleBackColor = true;
		ckbTuDongTraLoiCauHoi.CheckedChanged += new System.EventHandler(C217CCB3);
		nudDelayTo.Location = new System.Drawing.Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.Location = new System.Drawing.Point(194, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(287, 109);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(89, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new System.Drawing.Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		CF9843AD.Location = new System.Drawing.Point(132, 78);
		CF9843AD.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CF9843AD.Name = "nudSoLuongFrom";
		CF9843AD.Size = new System.Drawing.Size(56, 23);
		CF9843AD.TabIndex = 1;
		B4987E12.Location = new System.Drawing.Point(132, 49);
		B4987E12.Name = "txtTenHanhDong";
		B4987E12.Size = new System.Drawing.Size(194, 23);
		B4987E12.TabIndex = 0;
		label3.Location = new System.Drawing.Point(194, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F230CA21.AutoSize = true;
		F230CA21.Location = new System.Drawing.Point(287, 80);
		F230CA21.Name = "label4";
		F230CA21.Size = new System.Drawing.Size(39, 16);
		F230CA21.TabIndex = 35;
		F230CA21.Text = "nhóm";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(99, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		E6236314.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E6236314.BackColor = System.Drawing.Color.Maroon;
		E6236314.Cursor = System.Windows.Forms.Cursors.Hand;
		E6236314.FlatAppearance.BorderSize = 0;
		E6236314.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E6236314.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E6236314.ForeColor = System.Drawing.Color.White;
		E6236314.Location = new System.Drawing.Point(193, 352);
		E6236314.Name = "btnCancel";
		E6236314.Size = new System.Drawing.Size(92, 29);
		E6236314.TabIndex = 7;
		E6236314.Text = "Đóng";
		E6236314.UseVisualStyleBackColor = false;
		E6236314.Click += new System.EventHandler(B43B9693);
		D4B2BC9A.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		D4B2BC9A.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		D4B2BC9A.Cursor = System.Windows.Forms.Cursors.Hand;
		D4B2BC9A.FlatAppearance.BorderSize = 0;
		D4B2BC9A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D4B2BC9A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D4B2BC9A.ForeColor = System.Drawing.Color.White;
		D4B2BC9A.Location = new System.Drawing.Point(86, 352);
		D4B2BC9A.Name = "btnAdd";
		D4B2BC9A.Size = new System.Drawing.Size(92, 29);
		D4B2BC9A.TabIndex = 6;
		D4B2BC9A.Text = "Thêm";
		D4B2BC9A.UseVisualStyleBackColor = false;
		D4B2BC9A.Click += new System.EventHandler(F4A7A48D);
		C1339214.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C1339214.BackColor = System.Drawing.Color.White;
		C1339214.BorderRadius = 0;
		C1339214.BottomSahddow = true;
		C1339214.color = System.Drawing.Color.DarkViolet;
		C1339214.Controls.Add(pnlHeader);
		C1339214.LeftSahddow = false;
		C1339214.Location = new System.Drawing.Point(1, 0);
		C1339214.Name = "bunifuCards1";
		C1339214.RightSahddow = true;
		C1339214.ShadowDepth = 20;
		C1339214.Size = new System.Drawing.Size(363, 37);
		C1339214.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(366, 395);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomGoiY";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDThamGiaNhomGoiY_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plTuongTac.ResumeLayout(false);
		plTuongTac.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)CF9843AD).EndInit();
		C1339214.ResumeLayout(false);
		ResumeLayout(false);
	}
}
