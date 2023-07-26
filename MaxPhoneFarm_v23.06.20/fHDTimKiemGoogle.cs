using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTimKiemGoogle : Form
{
	internal JSON_Settings CC3D9AB0 = null;

	internal string A83A859F;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal TextBox A3A7ECA7;

	internal Label label2;

	internal Label label1;

	internal Button btnCancel;

	internal Button C7105902;

	internal BunifuCards bunifuCards1;

	internal Panel A029E9A5;

	internal Button B503C50D;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel AA2E9ABB;

	internal Label label8;

	internal Label lblStatus;

	internal RichTextBox C89CF723;

	internal NumericUpDown EE1C3980;

	internal NumericUpDown CBAA9480;

	internal NumericUpDown DD153D80;

	internal NumericUpDown nudCountTuKhoaTo;

	internal NumericUpDown B2134934;

	internal NumericUpDown nudCountLinkClickFrom;

	internal NumericUpDown CB32349F;

	internal NumericUpDown nudCountTuKhoaFrom;

	internal Label label4;

	internal Label label17;

	internal Label label14;

	internal Label label3;

	internal Label label13;

	internal Label F62D9C9F;

	internal Label label12;

	internal Label AC3C9A9D;

	internal Label label15;

	internal Label label10;

	internal Label FBA75C30;

	public fHDTimKiemGoogle(string string_2, int D2903BB8 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		A83A859F = string_2;
		string_1 = string_3;
		int_0 = D2903BB8;
		if (Class123.C7BE863B("", "HDTimKiemGoogle").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTimKiemGoogle', 'Ti\u0300m kiê\u0301m Google');");
		}
		string d399C = "";
		switch (D2903BB8)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDTimKiemGoogle");
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			A3A7ECA7.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			C7105902.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			A3A7ECA7.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		CC3D9AB0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(AA2E9ABB);
		Language.smethod_1(label1);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(FBA75C30);
		Language.smethod_1(label13);
		Language.smethod_1(AC3C9A9D);
		Language.smethod_1(label10);
		Language.smethod_1(label14);
		Language.smethod_1(label12);
		Language.smethod_1(label15);
		Language.smethod_1(label17);
		Language.smethod_1(F62D9C9F);
		Language.smethod_1(label2);
		Language.smethod_1(label4);
		Language.smethod_1(label3);
		Language.smethod_1(C7105902);
		Language.smethod_1(btnCancel);
	}

	private void fHDTimKiemGoogle_Load(object sender, EventArgs e)
	{
		try
		{
			nudCountTuKhoaFrom.Value = CC3D9AB0.method_0("nudCountTuKhoaFrom", 1);
			nudCountTuKhoaTo.Value = CC3D9AB0.method_0("nudCountTuKhoaTo", 1);
			CB32349F.Value = CC3D9AB0.method_0("nudCountPageFrom", 3);
			DD153D80.Value = CC3D9AB0.method_0("nudCountPageTo", 3);
			nudCountLinkClickFrom.Value = CC3D9AB0.method_0("nudCountLinkClickFrom", 3);
			CBAA9480.Value = CC3D9AB0.method_0("nudCountLinkClickTo", 5);
			B2134934.Value = CC3D9AB0.method_0("nudCountTimeScrollFrom", 30);
			EE1C3980.Value = CC3D9AB0.method_0("nudCountTimeScrollTo", 30);
			C89CF723.Text = CC3D9AB0.GetValue("txtTuKhoa");
		}
		catch
		{
		}
	}

	private void B503C50D_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B7330A39(object sender, EventArgs e)
	{
		string text = A3A7ECA7.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudCountTuKhoaFrom", nudCountTuKhoaFrom.Value);
		f72FAFBC.GetValue("nudCountTuKhoaTo", nudCountTuKhoaTo.Value);
		f72FAFBC.GetValue("nudCountPageFrom", CB32349F.Value);
		f72FAFBC.GetValue("nudCountPageTo", DD153D80.Value);
		f72FAFBC.GetValue("nudCountLinkClickFrom", nudCountLinkClickFrom.Value);
		f72FAFBC.GetValue("nudCountLinkClickTo", CBAA9480.Value);
		f72FAFBC.GetValue("nudCountTimeScrollFrom", B2134934.Value);
		f72FAFBC.GetValue("nudCountTimeScrollTo", EE1C3980.Value);
		f72FAFBC.GetValue("txtTuKhoa", (object)C89CF723.Text.Trim());
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(A83A859F, text, string_0, text2))
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

	private void FCBB1686(object sender, EventArgs e)
	{
		Close();
	}

	private void DBA296A3(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void E08DE9A7(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = C89CF723.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch Tư\u0300 kho\u0301a|Link Web ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTimKiemGoogle));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		AA2E9ABB = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		A029E9A5 = new System.Windows.Forms.Panel();
		B503C50D = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		C89CF723 = new System.Windows.Forms.RichTextBox();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		EE1C3980 = new System.Windows.Forms.NumericUpDown();
		CBAA9480 = new System.Windows.Forms.NumericUpDown();
		DD153D80 = new System.Windows.Forms.NumericUpDown();
		nudCountTuKhoaTo = new System.Windows.Forms.NumericUpDown();
		B2134934 = new System.Windows.Forms.NumericUpDown();
		nudCountLinkClickFrom = new System.Windows.Forms.NumericUpDown();
		CB32349F = new System.Windows.Forms.NumericUpDown();
		nudCountTuKhoaFrom = new System.Windows.Forms.NumericUpDown();
		label4 = new System.Windows.Forms.Label();
		A3A7ECA7 = new System.Windows.Forms.TextBox();
		label17 = new System.Windows.Forms.Label();
		label14 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label13 = new System.Windows.Forms.Label();
		F62D9C9F = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		AC3C9A9D = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		FBA75C30 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		C7105902 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		A029E9A5.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)EE1C3980).BeginInit();
		((System.ComponentModel.ISupportInitialize)CBAA9480).BeginInit();
		((System.ComponentModel.ISupportInitialize)DD153D80).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountTuKhoaTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)B2134934).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkClickFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)CB32349F).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountTuKhoaFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = AA2E9ABB;
		bunifuDragControl_0.Vertical = true;
		AA2E9ABB.BackColor = System.Drawing.Color.Transparent;
		AA2E9ABB.Cursor = System.Windows.Forms.Cursors.SizeAll;
		AA2E9ABB.Dock = System.Windows.Forms.DockStyle.Fill;
		AA2E9ABB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AA2E9ABB.ForeColor = System.Drawing.Color.Black;
		AA2E9ABB.Location = new System.Drawing.Point(0, 0);
		AA2E9ABB.Name = "bunifuCustomLabel1";
		AA2E9ABB.Size = new System.Drawing.Size(359, 31);
		AA2E9ABB.TabIndex = 12;
		AA2E9ABB.Text = "Cấu hình Ti\u0300m kiê\u0301m Google";
		AA2E9ABB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = A029E9A5;
		bunifuDragControl_1.Vertical = true;
		A029E9A5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A029E9A5.BackColor = System.Drawing.Color.White;
		A029E9A5.Controls.Add(B503C50D);
		A029E9A5.Controls.Add(pictureBox1);
		A029E9A5.Controls.Add(AA2E9ABB);
		A029E9A5.Cursor = System.Windows.Forms.Cursors.SizeAll;
		A029E9A5.Location = new System.Drawing.Point(0, 3);
		A029E9A5.Name = "pnlHeader";
		A029E9A5.Size = new System.Drawing.Size(359, 31);
		A029E9A5.TabIndex = 9;
		B503C50D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B503C50D.Cursor = System.Windows.Forms.Cursors.Hand;
		B503C50D.FlatAppearance.BorderSize = 0;
		B503C50D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B503C50D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B503C50D.ForeColor = System.Drawing.Color.White;
		B503C50D.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		B503C50D.Location = new System.Drawing.Point(328, 1);
		B503C50D.Name = "button1";
		B503C50D.Size = new System.Drawing.Size(30, 30);
		B503C50D.TabIndex = 77;
		B503C50D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B503C50D.UseVisualStyleBackColor = true;
		B503C50D.Click += new System.EventHandler(B503C50D_Click);
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
		panel1.Controls.Add(C89CF723);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(EE1C3980);
		panel1.Controls.Add(CBAA9480);
		panel1.Controls.Add(DD153D80);
		panel1.Controls.Add(nudCountTuKhoaTo);
		panel1.Controls.Add(B2134934);
		panel1.Controls.Add(nudCountLinkClickFrom);
		panel1.Controls.Add(CB32349F);
		panel1.Controls.Add(nudCountTuKhoaFrom);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(A3A7ECA7);
		panel1.Controls.Add(label17);
		panel1.Controls.Add(label14);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label13);
		panel1.Controls.Add(F62D9C9F);
		panel1.Controls.Add(label12);
		panel1.Controls.Add(AC3C9A9D);
		panel1.Controls.Add(label15);
		panel1.Controls.Add(label10);
		panel1.Controls.Add(FBA75C30);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(C7105902);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 428);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(DBA296A3);
		C89CF723.Location = new System.Drawing.Point(30, 94);
		C89CF723.Name = "txtTuKhoa";
		C89CF723.Size = new System.Drawing.Size(298, 142);
		C89CF723.TabIndex = 42;
		C89CF723.Text = "";
		C89CF723.WordWrap = false;
		C89CF723.TextChanged += new System.EventHandler(E08DE9A7);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(28, 239);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(134, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 do\u0300ng)";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(27, 75);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(202, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch Tư\u0300 kho\u0301a|Link Web (0):";
		EE1C3980.Location = new System.Drawing.Point(263, 344);
		EE1C3980.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		EE1C3980.Name = "nudCountTimeScrollTo";
		EE1C3980.Size = new System.Drawing.Size(36, 23);
		EE1C3980.TabIndex = 2;
		CBAA9480.Location = new System.Drawing.Point(263, 316);
		CBAA9480.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CBAA9480.Name = "nudCountLinkClickTo";
		CBAA9480.Size = new System.Drawing.Size(36, 23);
		CBAA9480.TabIndex = 2;
		DD153D80.Location = new System.Drawing.Point(263, 288);
		DD153D80.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DD153D80.Name = "nudCountPageTo";
		DD153D80.Size = new System.Drawing.Size(36, 23);
		DD153D80.TabIndex = 2;
		nudCountTuKhoaTo.Location = new System.Drawing.Point(263, 260);
		nudCountTuKhoaTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountTuKhoaTo.Name = "nudCountTuKhoaTo";
		nudCountTuKhoaTo.Size = new System.Drawing.Size(36, 23);
		nudCountTuKhoaTo.TabIndex = 2;
		B2134934.Location = new System.Drawing.Point(192, 344);
		B2134934.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B2134934.Name = "nudCountTimeScrollFrom";
		B2134934.Size = new System.Drawing.Size(36, 23);
		B2134934.TabIndex = 1;
		nudCountLinkClickFrom.Location = new System.Drawing.Point(192, 316);
		nudCountLinkClickFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
		nudCountLinkClickFrom.Size = new System.Drawing.Size(36, 23);
		nudCountLinkClickFrom.TabIndex = 1;
		CB32349F.Location = new System.Drawing.Point(192, 288);
		CB32349F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CB32349F.Name = "nudCountPageFrom";
		CB32349F.Size = new System.Drawing.Size(36, 23);
		CB32349F.TabIndex = 1;
		nudCountTuKhoaFrom.Location = new System.Drawing.Point(192, 260);
		nudCountTuKhoaFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountTuKhoaFrom.Name = "nudCountTuKhoaFrom";
		nudCountTuKhoaFrom.Size = new System.Drawing.Size(36, 23);
		nudCountTuKhoaFrom.TabIndex = 1;
		label4.Location = new System.Drawing.Point(231, 346);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 37;
		label4.Text = "đê\u0301n";
		label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A3A7ECA7.Location = new System.Drawing.Point(134, 49);
		A3A7ECA7.Name = "txtTenHanhDong";
		A3A7ECA7.Size = new System.Drawing.Size(194, 23);
		A3A7ECA7.TabIndex = 0;
		label17.Location = new System.Drawing.Point(231, 318);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(29, 16);
		label17.TabIndex = 37;
		label17.Text = "đê\u0301n";
		label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label14.Location = new System.Drawing.Point(231, 290);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(29, 16);
		label14.TabIndex = 37;
		label14.Text = "đê\u0301n";
		label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(299, 346);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(31, 16);
		label3.TabIndex = 35;
		label3.Text = "giây";
		label13.Location = new System.Drawing.Point(231, 262);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(29, 16);
		label13.TabIndex = 37;
		label13.Text = "đê\u0301n";
		label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F62D9C9F.AutoSize = true;
		F62D9C9F.Location = new System.Drawing.Point(299, 318);
		F62D9C9F.Name = "label16";
		F62D9C9F.Size = new System.Drawing.Size(27, 16);
		F62D9C9F.TabIndex = 35;
		F62D9C9F.Text = "link";
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(299, 290);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(38, 16);
		label12.TabIndex = 35;
		label12.Text = "trang";
		AC3C9A9D.AutoSize = true;
		AC3C9A9D.Location = new System.Drawing.Point(299, 262);
		AC3C9A9D.Name = "label11";
		AC3C9A9D.Size = new System.Drawing.Size(51, 16);
		AC3C9A9D.TabIndex = 35;
		AC3C9A9D.Text = "tư\u0300 khóa";
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(28, 318);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(165, 16);
		label15.TabIndex = 34;
		label15.Text = "Click random link trên web:";
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(27, 290);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(151, 16);
		label10.TabIndex = 34;
		label10.Text = "Sô\u0301 trang ti\u0300m kiê\u0301m tô\u0301i đa:";
		FBA75C30.AutoSize = true;
		FBA75C30.Location = new System.Drawing.Point(27, 262);
		FBA75C30.Name = "label9";
		FBA75C30.Size = new System.Drawing.Size(121, 16);
		FBA75C30.TabIndex = 32;
		FBA75C30.Text = "Sô\u0301 tư\u0300 kho\u0301a câ\u0300n ti\u0300m:";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 346);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(147, 16);
		label2.TabIndex = 32;
		label2.Text = "Thơ\u0300i gian lươ\u0301t trên web:";
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
		btnCancel.Location = new System.Drawing.Point(189, 384);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(FCBB1686);
		C7105902.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		C7105902.Cursor = System.Windows.Forms.Cursors.Hand;
		C7105902.FlatAppearance.BorderSize = 0;
		C7105902.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C7105902.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C7105902.ForeColor = System.Drawing.Color.White;
		C7105902.Location = new System.Drawing.Point(82, 384);
		C7105902.Name = "btnAdd";
		C7105902.Size = new System.Drawing.Size(92, 29);
		C7105902.TabIndex = 9;
		C7105902.Text = "Thêm";
		C7105902.UseVisualStyleBackColor = false;
		C7105902.Click += new System.EventHandler(B7330A39);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(A029E9A5);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 428);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTimKiemGoogle";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTimKiemGoogle_Load);
		A029E9A5.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)EE1C3980).EndInit();
		((System.ComponentModel.ISupportInitialize)CBAA9480).EndInit();
		((System.ComponentModel.ISupportInitialize)DD153D80).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountTuKhoaTo).EndInit();
		((System.ComponentModel.ISupportInitialize)B2134934).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkClickFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)CB32349F).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountTuKhoaFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
