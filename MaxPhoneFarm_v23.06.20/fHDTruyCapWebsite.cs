using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTruyCapWebsite : Form
{
	internal JSON_Settings C22B4299 = null;

	internal string DC88FC3A;

	internal string B6376838;

	internal string EC27901B;

	internal int FD1074A0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl A1279A11;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label A78190AD;

	internal Button btnCancel;

	internal Button EBA1433C;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox A23DE4A8;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label label8;

	internal Label lblStatus;

	internal RichTextBox F68C571F;

	internal NumericUpDown nudCountLinkClickTo;

	internal NumericUpDown nudCountLinkTo;

	internal NumericUpDown nudCountLinkClickFrom;

	internal NumericUpDown nudCountLinkFrom;

	internal Label label17;

	internal Label label13;

	internal Label label16;

	internal Label label11;

	internal Label label15;

	internal Label D2BFB999;

	internal CheckBox ckbLuot;

	internal NumericUpDown DA3C072B;

	internal Label C62013BD;

	internal Label C50529BE;

	internal Label label4;

	internal NumericUpDown F80B7938;

	public fHDTruyCapWebsite(string E1A1C30A, int BF99C935 = 0, string EEB16CB2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		DC88FC3A = E1A1C30A;
		EC27901B = EEB16CB2;
		FD1074A0 = BF99C935;
		if (Class123.C7BE863B("", "HDTruyCapWebsite").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTruyCapWebsite', 'Truy cập Website');");
		}
		string d399C = "";
		switch (BF99C935)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDTruyCapWebsite");
			B6376838 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(EEB16CB2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			EBA1433C.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		C22B4299 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void EDA72A07()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(A78190AD);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(D2BFB999);
		Language.smethod_1(label13);
		Language.smethod_1(label11);
		Language.smethod_1(label15);
		Language.smethod_1(label17);
		Language.smethod_1(label16);
		Language.smethod_1(C62013BD);
		Language.smethod_1(label4);
		Language.smethod_1(C50529BE);
		Language.smethod_1(ckbLuot);
		Language.smethod_1(EBA1433C);
		Language.smethod_1(btnCancel);
	}

	private void fHDTruyCapWebsite_Load(object sender, EventArgs e)
	{
		try
		{
			nudCountLinkFrom.Value = C22B4299.method_0("nudCountLinkFrom", 1);
			nudCountLinkTo.Value = C22B4299.method_0("nudCountLinkTo", 1);
			nudCountLinkClickFrom.Value = C22B4299.method_0("nudCountLinkClickFrom", 3);
			nudCountLinkClickTo.Value = C22B4299.method_0("nudCountLinkClickTo", 5);
			F80B7938.Value = C22B4299.method_0("nudCountTimeScrollFrom", 30);
			DA3C072B.Value = C22B4299.method_0("nudCountTimeScrollTo", 30);
			F68C571F.Text = C22B4299.GetValue("txtLinkWeb");
			ckbLuot.Checked = C22B4299.AA824D29("ckbLuot", A72188BC: true);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void EBA1433C_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudCountLinkFrom", nudCountLinkFrom.Value);
		f72FAFBC.GetValue("nudCountLinkTo", nudCountLinkTo.Value);
		f72FAFBC.GetValue("nudCountLinkClickFrom", nudCountLinkClickFrom.Value);
		f72FAFBC.GetValue("nudCountLinkClickTo", nudCountLinkClickTo.Value);
		f72FAFBC.GetValue("nudCountTimeScrollFrom", F80B7938.Value);
		f72FAFBC.GetValue("nudCountTimeScrollTo", DA3C072B.Value);
		f72FAFBC.GetValue("txtLinkWeb", (object)F68C571F.Text.Trim());
		f72FAFBC.GetValue("ckbLuot", ckbLuot.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (FD1074A0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(DC88FC3A, text, B6376838, text2))
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
			if (Class123.smethod_14(EC27901B, text, text2))
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

	private void CCBECCA3(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = F68C571F.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch Link Web ({0}):"), f1808BA.Count.ToString());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTruyCapWebsite));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		A1279A11 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		A23DE4A8 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		DA3C072B = new System.Windows.Forms.NumericUpDown();
		C62013BD = new System.Windows.Forms.Label();
		C50529BE = new System.Windows.Forms.Label();
		ckbLuot = new System.Windows.Forms.CheckBox();
		label4 = new System.Windows.Forms.Label();
		F68C571F = new System.Windows.Forms.RichTextBox();
		F80B7938 = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		nudCountLinkClickTo = new System.Windows.Forms.NumericUpDown();
		nudCountLinkTo = new System.Windows.Forms.NumericUpDown();
		nudCountLinkClickFrom = new System.Windows.Forms.NumericUpDown();
		nudCountLinkFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label17 = new System.Windows.Forms.Label();
		label13 = new System.Windows.Forms.Label();
		label16 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		D2BFB999 = new System.Windows.Forms.Label();
		A78190AD = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		EBA1433C = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A23DE4A8).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DA3C072B).BeginInit();
		((System.ComponentModel.ISupportInitialize)F80B7938).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkClickTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkClickFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkFrom).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Truy cập Website";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A1279A11.Fixed = true;
		A1279A11.Horizontal = true;
		A1279A11.TargetControl = pnlHeader;
		A1279A11.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(A23DE4A8);
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
		button1.Click += new System.EventHandler(button1_Click);
		A23DE4A8.Cursor = System.Windows.Forms.Cursors.Default;
		A23DE4A8.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		A23DE4A8.Location = new System.Drawing.Point(3, 2);
		A23DE4A8.Name = "pictureBox1";
		A23DE4A8.Size = new System.Drawing.Size(34, 27);
		A23DE4A8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A23DE4A8.TabIndex = 76;
		A23DE4A8.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(DA3C072B);
		panel1.Controls.Add(C62013BD);
		panel1.Controls.Add(C50529BE);
		panel1.Controls.Add(ckbLuot);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(F68C571F);
		panel1.Controls.Add(F80B7938);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(nudCountLinkClickTo);
		panel1.Controls.Add(nudCountLinkTo);
		panel1.Controls.Add(nudCountLinkClickFrom);
		panel1.Controls.Add(nudCountLinkFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label17);
		panel1.Controls.Add(label13);
		panel1.Controls.Add(label16);
		panel1.Controls.Add(label11);
		panel1.Controls.Add(label15);
		panel1.Controls.Add(D2BFB999);
		panel1.Controls.Add(A78190AD);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(EBA1433C);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 419);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		DA3C072B.Location = new System.Drawing.Point(263, 316);
		DA3C072B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DA3C072B.Name = "nudCountTimeScrollTo";
		DA3C072B.Size = new System.Drawing.Size(36, 23);
		DA3C072B.TabIndex = 2;
		C62013BD.AutoSize = true;
		C62013BD.Location = new System.Drawing.Point(28, 318);
		C62013BD.Name = "label2";
		C62013BD.Size = new System.Drawing.Size(121, 16);
		C62013BD.TabIndex = 32;
		C62013BD.Text = "Thời gian trên web:";
		C50529BE.AutoSize = true;
		C50529BE.Location = new System.Drawing.Point(299, 318);
		C50529BE.Name = "label3";
		C50529BE.Size = new System.Drawing.Size(31, 16);
		C50529BE.TabIndex = 35;
		C50529BE.Text = "giây";
		ckbLuot.AutoSize = true;
		ckbLuot.Checked = true;
		ckbLuot.CheckState = System.Windows.Forms.CheckState.Checked;
		ckbLuot.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLuot.Location = new System.Drawing.Point(30, 343);
		ckbLuot.Name = "ckbLuot";
		ckbLuot.Size = new System.Drawing.Size(158, 20);
		ckbLuot.TabIndex = 43;
		ckbLuot.Text = "Tự động lướt trên Web";
		ckbLuot.UseVisualStyleBackColor = true;
		label4.Location = new System.Drawing.Point(231, 318);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 37;
		label4.Text = "đê\u0301n";
		label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F68C571F.Location = new System.Drawing.Point(30, 94);
		F68C571F.Name = "txtLinkWeb";
		F68C571F.Size = new System.Drawing.Size(298, 142);
		F68C571F.TabIndex = 42;
		F68C571F.Text = "";
		F68C571F.WordWrap = false;
		F68C571F.TextChanged += new System.EventHandler(CCBECCA3);
		F80B7938.Location = new System.Drawing.Point(192, 316);
		F80B7938.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F80B7938.Name = "nudCountTimeScrollFrom";
		F80B7938.Size = new System.Drawing.Size(36, 23);
		F80B7938.TabIndex = 1;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(28, 239);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(134, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 do\u0300ng)";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(27, 75);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(149, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch Link Web (0):";
		nudCountLinkClickTo.Location = new System.Drawing.Point(263, 288);
		nudCountLinkClickTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLinkClickTo.Name = "nudCountLinkClickTo";
		nudCountLinkClickTo.Size = new System.Drawing.Size(36, 23);
		nudCountLinkClickTo.TabIndex = 2;
		nudCountLinkTo.Location = new System.Drawing.Point(263, 260);
		nudCountLinkTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLinkTo.Name = "nudCountLinkTo";
		nudCountLinkTo.Size = new System.Drawing.Size(36, 23);
		nudCountLinkTo.TabIndex = 2;
		nudCountLinkClickFrom.Location = new System.Drawing.Point(192, 288);
		nudCountLinkClickFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
		nudCountLinkClickFrom.Size = new System.Drawing.Size(36, 23);
		nudCountLinkClickFrom.TabIndex = 1;
		nudCountLinkFrom.Location = new System.Drawing.Point(192, 260);
		nudCountLinkFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLinkFrom.Name = "nudCountLinkFrom";
		nudCountLinkFrom.Size = new System.Drawing.Size(36, 23);
		nudCountLinkFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label17.Location = new System.Drawing.Point(231, 290);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(29, 16);
		label17.TabIndex = 37;
		label17.Text = "đê\u0301n";
		label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label13.Location = new System.Drawing.Point(231, 262);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(29, 16);
		label13.TabIndex = 37;
		label13.Text = "đê\u0301n";
		label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label16.AutoSize = true;
		label16.Location = new System.Drawing.Point(299, 290);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(27, 16);
		label16.TabIndex = 35;
		label16.Text = "link";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(299, 262);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(27, 16);
		label11.TabIndex = 35;
		label11.Text = "link";
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(28, 290);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(165, 16);
		label15.TabIndex = 34;
		label15.Text = "Click random link trên web:";
		D2BFB999.AutoSize = true;
		D2BFB999.Location = new System.Drawing.Point(27, 262);
		D2BFB999.Name = "label9";
		D2BFB999.Size = new System.Drawing.Size(153, 16);
		D2BFB999.TabIndex = 32;
		D2BFB999.Text = "Sô\u0301 link web cần truy cập:";
		A78190AD.AutoSize = true;
		A78190AD.Location = new System.Drawing.Point(27, 52);
		A78190AD.Name = "label1";
		A78190AD.Size = new System.Drawing.Size(99, 16);
		A78190AD.TabIndex = 31;
		A78190AD.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 375);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		EBA1433C.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		EBA1433C.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		EBA1433C.Cursor = System.Windows.Forms.Cursors.Hand;
		EBA1433C.FlatAppearance.BorderSize = 0;
		EBA1433C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EBA1433C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EBA1433C.ForeColor = System.Drawing.Color.White;
		EBA1433C.Location = new System.Drawing.Point(82, 375);
		EBA1433C.Name = "btnAdd";
		EBA1433C.Size = new System.Drawing.Size(92, 29);
		EBA1433C.TabIndex = 9;
		EBA1433C.Text = "Thêm";
		EBA1433C.UseVisualStyleBackColor = false;
		EBA1433C.Click += new System.EventHandler(EBA1433C_Click);
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
		base.ClientSize = new System.Drawing.Size(362, 419);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTruyCapWebsite";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTruyCapWebsite_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A23DE4A8).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)DA3C072B).EndInit();
		((System.ComponentModel.ISupportInitialize)F80B7938).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkClickTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkClickFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
