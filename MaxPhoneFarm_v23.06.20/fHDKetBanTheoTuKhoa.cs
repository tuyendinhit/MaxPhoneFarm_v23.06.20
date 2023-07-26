using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanTheoTuKhoa : Form
{
	internal JSON_Settings f72FAFBC_0 = null;

	internal string string_0;

	internal string EC2CD68D;

	internal string string_1;

	internal int AC021681;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl AF238E9D;

	internal BunifuDragControl D287DF2A;

	internal Panel panel1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown E8BC4E26;

	internal TextBox F9930DB0;

	internal Label label3;

	internal Label label4;

	internal Label label2;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label label8;

	internal Label lblStatus;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudDelayFrom;

	internal Label B18A0EBF;

	internal Label BF13219F;

	internal Label A5993392;

	internal GroupBox B589BA9B;

	internal RichTextBox txtTuKhoa;

	internal Label FD3A7B35;

	internal Label CD1EDAA0;

	internal Label E2192CB9;

	internal NumericUpDown CC0CDE1C;

	internal NumericUpDown DE39B426;

	public fHDKetBanTheoTuKhoa(string DC917685, int int_0 = 0, string F8A86B3D = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = DC917685;
		string_1 = F8A86B3D;
		AC021681 = int_0;
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDKetBanTheoTuKhoa");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			EC2CD68D = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			F9930DB0.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(F8A86B3D);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			F9930DB0.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void FB8A07AA()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(label2);
		Language.smethod_1(label3);
		Language.smethod_1(label4);
		Language.smethod_1(A5993392);
		Language.smethod_1(B18A0EBF);
		Language.smethod_1(BF13219F);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void fHDKetBanTheoTuKhoa_Load(object sender, EventArgs e)
	{
		try
		{
			E8BC4E26.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = f72FAFBC_0.method_0("nudSoLuongTo", 5);
			nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			DE39B426.Value = f72FAFBC_0.method_0("nudSoLuongKetBanMoiTuKhoaFrom", 1);
			CC0CDE1C.Value = f72FAFBC_0.method_0("nudSoLuongKetBanMoiTuKhoaTo", 2);
			txtTuKhoa.Text = f72FAFBC_0.GetValue("txtTuKhoa");
		}
		catch
		{
		}
	}

	private void E11B7939(object sender, EventArgs e)
	{
		Close();
	}

	private void C9083608(object sender, EventArgs e)
	{
		string text = F9930DB0.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> f1808BA = txtTuKhoa.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p từ khóa!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", E8BC4E26.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("nudSoLuongKetBanMoiTuKhoaFrom", DE39B426.Value);
		f72FAFBC.GetValue("nudSoLuongKetBanMoiTuKhoaTo", CC0CDE1C.Value);
		f72FAFBC.GetValue("txtTuKhoa", (object)txtTuKhoa.Text.Trim());
		string text2 = f72FAFBC.C71A4EA4();
		if (AC021681 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, EC2CD68D, text2))
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

	private void C32C7A1C(object sender, EventArgs e)
	{
		Common.D936DD84(txtTuKhoa, lblStatus);
	}

	private void B589BA9B_Enter(object sender, EventArgs e)
	{
	}

	private void E8BC4E26_ValueChanged(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanTheoTuKhoa));
		AF238E9D = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D287DF2A = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		B589BA9B = new System.Windows.Forms.GroupBox();
		txtTuKhoa = new System.Windows.Forms.RichTextBox();
		lblStatus = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		FD3A7B35 = new System.Windows.Forms.Label();
		CD1EDAA0 = new System.Windows.Forms.Label();
		E2192CB9 = new System.Windows.Forms.Label();
		CC0CDE1C = new System.Windows.Forms.NumericUpDown();
		DE39B426 = new System.Windows.Forms.NumericUpDown();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		B18A0EBF = new System.Windows.Forms.Label();
		BF13219F = new System.Windows.Forms.Label();
		A5993392 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		E8BC4E26 = new System.Windows.Forms.NumericUpDown();
		F9930DB0 = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		B589BA9B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)CC0CDE1C).BeginInit();
		((System.ComponentModel.ISupportInitialize)DE39B426).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)E8BC4E26).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		AF238E9D.Fixed = true;
		AF238E9D.Horizontal = true;
		AF238E9D.TargetControl = bunifuCustomLabel1;
		AF238E9D.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn theo từ khóa";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D287DF2A.Fixed = true;
		D287DF2A.Horizontal = true;
		D287DF2A.TargetControl = pnlHeader;
		D287DF2A.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(328, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(E11B7939);
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
		panel1.Controls.Add(B589BA9B);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(B18A0EBF);
		panel1.Controls.Add(BF13219F);
		panel1.Controls.Add(A5993392);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(E8BC4E26);
		panel1.Controls.Add(F9930DB0);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 433);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		B589BA9B.Controls.Add(txtTuKhoa);
		B589BA9B.Controls.Add(lblStatus);
		B589BA9B.Controls.Add(label8);
		B589BA9B.Controls.Add(FD3A7B35);
		B589BA9B.Controls.Add(CD1EDAA0);
		B589BA9B.Controls.Add(E2192CB9);
		B589BA9B.Controls.Add(CC0CDE1C);
		B589BA9B.Controls.Add(DE39B426);
		B589BA9B.Location = new System.Drawing.Point(30, 140);
		B589BA9B.Name = "groupBox1";
		B589BA9B.Size = new System.Drawing.Size(295, 236);
		B589BA9B.TabIndex = 47;
		B589BA9B.TabStop = false;
		B589BA9B.Text = "Cấu hình từ khóa";
		B589BA9B.Enter += new System.EventHandler(B589BA9B_Enter);
		txtTuKhoa.Location = new System.Drawing.Point(10, 39);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new System.Drawing.Size(279, 140);
		txtTuKhoa.TabIndex = 1;
		txtTuKhoa.Text = "";
		txtTuKhoa.TextChanged += new System.EventHandler(C32C7A1C);
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(6, 19);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch từ khóa (0):";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(7, 182);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(259, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi từ khóa 1 dòng, spin nội dung {a|b|c})";
		FD3A7B35.AutoSize = true;
		FD3A7B35.Location = new System.Drawing.Point(7, 208);
		FD3A7B35.Name = "label9";
		FD3A7B35.Size = new System.Drawing.Size(128, 16);
		FD3A7B35.TabIndex = 32;
		FD3A7B35.Text = "Số lượng kb/từ khóa:";
		CD1EDAA0.AutoSize = true;
		CD1EDAA0.Location = new System.Drawing.Point(260, 208);
		CD1EDAA0.Name = "label10";
		CD1EDAA0.Size = new System.Drawing.Size(28, 16);
		CD1EDAA0.TabIndex = 35;
		CD1EDAA0.Text = "ba\u0323n";
		E2192CB9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E2192CB9.Location = new System.Drawing.Point(183, 208);
		E2192CB9.Name = "label11";
		E2192CB9.Size = new System.Drawing.Size(29, 16);
		E2192CB9.TabIndex = 37;
		E2192CB9.Text = ">";
		E2192CB9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		CC0CDE1C.Location = new System.Drawing.Point(218, 206);
		CC0CDE1C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CC0CDE1C.Name = "nudSoLuongKetBanMoiTuKhoaTo";
		CC0CDE1C.Size = new System.Drawing.Size(40, 23);
		CC0CDE1C.TabIndex = 2;
		DE39B426.Location = new System.Drawing.Point(137, 206);
		DE39B426.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DE39B426.Name = "nudSoLuongKetBanMoiTuKhoaFrom";
		DE39B426.Size = new System.Drawing.Size(40, 23);
		DE39B426.TabIndex = 1;
		nudDelayTo.Location = new System.Drawing.Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		B18A0EBF.Location = new System.Drawing.Point(194, 113);
		B18A0EBF.Name = "label7";
		B18A0EBF.Size = new System.Drawing.Size(29, 16);
		B18A0EBF.TabIndex = 46;
		B18A0EBF.Text = "đê\u0301n";
		B18A0EBF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		BF13219F.AutoSize = true;
		BF13219F.Location = new System.Drawing.Point(287, 113);
		BF13219F.Name = "label6";
		BF13219F.Size = new System.Drawing.Size(30, 16);
		BF13219F.TabIndex = 45;
		BF13219F.Text = "giây";
		A5993392.AutoSize = true;
		A5993392.Location = new System.Drawing.Point(27, 113);
		A5993392.Name = "label5";
		A5993392.Size = new System.Drawing.Size(89, 16);
		A5993392.TabIndex = 44;
		A5993392.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		E8BC4E26.Location = new System.Drawing.Point(132, 80);
		E8BC4E26.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E8BC4E26.Name = "nudSoLuongFrom";
		E8BC4E26.Size = new System.Drawing.Size(56, 23);
		E8BC4E26.TabIndex = 1;
		E8BC4E26.ValueChanged += new System.EventHandler(E8BC4E26_ValueChanged);
		F9930DB0.Location = new System.Drawing.Point(132, 49);
		F9930DB0.Name = "txtTenHanhDong";
		F9930DB0.Size = new System.Drawing.Size(194, 23);
		F9930DB0.TabIndex = 0;
		label3.Location = new System.Drawing.Point(194, 82);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(287, 82);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(28, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 82);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(83, 16);
		label2.TabIndex = 32;
		label2.Text = "Tổng số ba\u0323n:";
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
		btnCancel.Location = new System.Drawing.Point(185, 391);
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
		btnAdd.Location = new System.Drawing.Point(78, 391);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(C9083608);
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
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 433);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanTheoTuKhoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanTheoTuKhoa_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		B589BA9B.ResumeLayout(false);
		B589BA9B.PerformLayout();
		((System.ComponentModel.ISupportInitialize)CC0CDE1C).EndInit();
		((System.ComponentModel.ISupportInitialize)DE39B426).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)E8BC4E26).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
