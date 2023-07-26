using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXemReel : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string F0934795;

	internal string B39064A6;

	internal string D70BDD18;

	internal int E53E5D82;

	internal static bool EBA69495;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel EF2F5A11;

	internal NumericUpDown ED0A4813;

	internal NumericUpDown nudTimeFrom;

	internal TextBox DC1E9C95;

	internal Label CFAD1134;

	internal Label F888D5B0;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button EE95000D;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel EDA1511C;

	internal Label lblStatus;

	internal CheckBox EB859C35;

	internal CheckBox ckbInteract;

	internal CheckBox ckbShareWall;

	internal RichTextBox txtComment;

	internal Label label6;

	internal Panel panel2;

	internal Button C1A0039F;

	internal RadioButton FB1244B4;

	internal Button button2;

	internal RadioButton BDA0F506;

	internal Label label2;

	internal Label label11;

	public fHDXemReel(string CA9A7A2D, int int_0 = 0, string string_0 = "")
	{
		InitializeComponent();
		EBA69495 = false;
		F0934795 = CA9A7A2D;
		D70BDD18 = string_0;
		E53E5D82 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Xem Reel";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			B39064A6 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			DC1E9C95.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_0);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			DC1E9C95.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDXemReel_Load(object sender, EventArgs e)
	{
		try
		{
			nudTimeFrom.Value = f72FAFBC_0.method_0("nudTimeFrom", 15);
			ED0A4813.Value = f72FAFBC_0.method_0("nudTimeTo", 30);
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			EB859C35.Checked = f72FAFBC_0.AA824D29("ckbComment");
			ckbShareWall.Checked = f72FAFBC_0.AA824D29("ckbShareWall");
			txtComment.Text = f72FAFBC_0.GetValue("txtComment");
			if (f72FAFBC_0.method_0("typeNganCach") == 1)
			{
				BDA0F506.Checked = true;
			}
			else
			{
				FB1244B4.Checked = true;
			}
		}
		catch
		{
		}
		method_0();
	}

	private void D2BB16AE(object sender, EventArgs e)
	{
		Close();
	}

	private void AFA852BC(object sender, EventArgs e)
	{
		string text = DC1E9C95.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (EB859C35.Checked)
		{
			List<string> f1808BA = txtComment.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudTimeFrom", nudTimeFrom.Value);
		f72FAFBC.GetValue("nudTimeTo", ED0A4813.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		f72FAFBC.GetValue("ckbShareWall", ckbShareWall.Checked);
		f72FAFBC.GetValue("ckbComment", EB859C35.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		int num = 0;
		if (BDA0F506.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		string text2 = f72FAFBC.C71A4EA4();
		if (E53E5D82 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(F0934795, text, B39064A6, text2))
				{
					EBA69495 = true;
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
			if (Class123.smethod_14(D70BDD18, text, text2))
			{
				EBA69495 = true;
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

	private void EF2F5A11_Paint(object sender, PaintEventArgs e)
	{
		if (EF2F5A11.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, EF2F5A11.ClientSize.Width - num, EF2F5A11.ClientSize.Height - num));
		}
	}

	private void D22AC60A(object sender, EventArgs e)
	{
		Common.D936DD84(txtComment, lblStatus, BDA0F506.Checked ? 1 : 0);
	}

	private void method_0()
	{
		ckbInteract_CheckedChanged(null, null);
		EB859C35_CheckedChanged(null, null);
		A71129A6(null, null);
	}

	private void EB859C35_CheckedChanged(object sender, EventArgs e)
	{
		EDA1511C.Enabled = EB859C35.Checked;
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void A71129A6(object sender, EventArgs e)
	{
	}

	private void A1112B15(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void B98D5303(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void AC21E895(object sender, EventArgs e)
	{
		Common.D936DD84(txtComment, lblStatus, BDA0F506.Checked ? 1 : 0);
	}

	private void BDA0F506_CheckedChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtComment, lblStatus, BDA0F506.Checked ? 1 : 0);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXemReel));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		EE95000D = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		EF2F5A11 = new System.Windows.Forms.Panel();
		EDA1511C = new System.Windows.Forms.Panel();
		txtComment = new System.Windows.Forms.RichTextBox();
		lblStatus = new System.Windows.Forms.Label();
		EB859C35 = new System.Windows.Forms.CheckBox();
		ckbShareWall = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		ED0A4813 = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		DC1E9C95 = new System.Windows.Forms.TextBox();
		CFAD1134 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		F888D5B0 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel2 = new System.Windows.Forms.Panel();
		C1A0039F = new System.Windows.Forms.Button();
		FB1244B4 = new System.Windows.Forms.RadioButton();
		button2 = new System.Windows.Forms.Button();
		BDA0F506 = new System.Windows.Forms.RadioButton();
		label2 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		EF2F5A11.SuspendLayout();
		EDA1511C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)ED0A4813).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		panel2.SuspendLayout();
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
		bunifuCustomLabel1.Text = "Cấu hình Xem Reel";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(EE95000D);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		EE95000D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		EE95000D.Cursor = System.Windows.Forms.Cursors.Hand;
		EE95000D.FlatAppearance.BorderSize = 0;
		EE95000D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EE95000D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EE95000D.ForeColor = System.Drawing.Color.White;
		EE95000D.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		EE95000D.Location = new System.Drawing.Point(328, 1);
		EE95000D.Name = "button1";
		EE95000D.Size = new System.Drawing.Size(30, 30);
		EE95000D.TabIndex = 77;
		EE95000D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		EE95000D.UseVisualStyleBackColor = true;
		EE95000D.Click += new System.EventHandler(D2BB16AE);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		EF2F5A11.BackColor = System.Drawing.Color.White;
		EF2F5A11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EF2F5A11.Controls.Add(EDA1511C);
		EF2F5A11.Controls.Add(EB859C35);
		EF2F5A11.Controls.Add(ckbShareWall);
		EF2F5A11.Controls.Add(ckbInteract);
		EF2F5A11.Controls.Add(ED0A4813);
		EF2F5A11.Controls.Add(nudTimeFrom);
		EF2F5A11.Controls.Add(DC1E9C95);
		EF2F5A11.Controls.Add(CFAD1134);
		EF2F5A11.Controls.Add(label6);
		EF2F5A11.Controls.Add(F888D5B0);
		EF2F5A11.Controls.Add(label1);
		EF2F5A11.Controls.Add(btnCancel);
		EF2F5A11.Controls.Add(btnAdd);
		EF2F5A11.Controls.Add(bunifuCards1);
		EF2F5A11.Cursor = System.Windows.Forms.Cursors.Arrow;
		EF2F5A11.Dock = System.Windows.Forms.DockStyle.Fill;
		EF2F5A11.Location = new System.Drawing.Point(0, 0);
		EF2F5A11.Name = "panel1";
		EF2F5A11.Size = new System.Drawing.Size(362, 450);
		EF2F5A11.TabIndex = 0;
		EF2F5A11.Paint += new System.Windows.Forms.PaintEventHandler(EF2F5A11_Paint);
		EDA1511C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EDA1511C.Controls.Add(panel2);
		EDA1511C.Controls.Add(label2);
		EDA1511C.Controls.Add(label11);
		EDA1511C.Controls.Add(txtComment);
		EDA1511C.Controls.Add(lblStatus);
		EDA1511C.Location = new System.Drawing.Point(48, 159);
		EDA1511C.Name = "plComment";
		EDA1511C.Size = new System.Drawing.Size(278, 232);
		EDA1511C.TabIndex = 8;
		txtComment.Location = new System.Drawing.Point(6, 24);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(264, 136);
		txtComment.TabIndex = 45;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(D22AC60A);
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		EB859C35.AutoSize = true;
		EB859C35.Cursor = System.Windows.Forms.Cursors.Hand;
		EB859C35.Location = new System.Drawing.Point(30, 133);
		EB859C35.Name = "ckbComment";
		EB859C35.Size = new System.Drawing.Size(81, 20);
		EB859C35.TabIndex = 7;
		EB859C35.Text = "Comment";
		EB859C35.UseVisualStyleBackColor = true;
		EB859C35.CheckedChanged += new System.EventHandler(EB859C35_CheckedChanged);
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareWall.Location = new System.Drawing.Point(132, 107);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new System.Drawing.Size(89, 20);
		ckbShareWall.TabIndex = 6;
		ckbShareWall.Text = "Share Wall";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbShareWall.CheckedChanged += new System.EventHandler(A71129A6);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 107);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(48, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Like";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		ED0A4813.Location = new System.Drawing.Point(229, 78);
		ED0A4813.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		ED0A4813.Name = "nudTimeTo";
		ED0A4813.Size = new System.Drawing.Size(56, 23);
		ED0A4813.TabIndex = 4;
		nudTimeFrom.Location = new System.Drawing.Point(132, 78);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 3;
		DC1E9C95.Location = new System.Drawing.Point(132, 49);
		DC1E9C95.Name = "txtTenHanhDong";
		DC1E9C95.Size = new System.Drawing.Size(194, 23);
		DC1E9C95.TabIndex = 0;
		CFAD1134.Location = new System.Drawing.Point(194, 80);
		CFAD1134.Name = "label7";
		CFAD1134.Size = new System.Drawing.Size(29, 16);
		CFAD1134.TabIndex = 38;
		CFAD1134.Text = "đê\u0301n";
		CFAD1134.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(290, 80);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		F888D5B0.AutoSize = true;
		F888D5B0.Location = new System.Drawing.Point(27, 80);
		F888D5B0.Name = "label5";
		F888D5B0.Size = new System.Drawing.Size(93, 16);
		F888D5B0.TabIndex = 34;
		F888D5B0.Text = "Thơ\u0300i gian xem:";
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
		btnCancel.Location = new System.Drawing.Point(189, 407);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
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
		btnAdd.Location = new System.Drawing.Point(82, 407);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(AFA852BC);
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
		panel2.Controls.Add(C1A0039F);
		panel2.Controls.Add(FB1244B4);
		panel2.Controls.Add(button2);
		panel2.Controls.Add(BDA0F506);
		panel2.Location = new System.Drawing.Point(65, 183);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(200, 43);
		panel2.TabIndex = 176;
		C1A0039F.Cursor = System.Windows.Forms.Cursors.Help;
		C1A0039F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C1A0039F.Location = new System.Drawing.Point(165, 22);
		C1A0039F.Name = "button3";
		C1A0039F.Size = new System.Drawing.Size(21, 21);
		C1A0039F.TabIndex = 172;
		C1A0039F.Text = "?";
		C1A0039F.UseVisualStyleBackColor = true;
		C1A0039F.Click += new System.EventHandler(B98D5303);
		FB1244B4.AutoSize = true;
		FB1244B4.Checked = true;
		FB1244B4.Cursor = System.Windows.Forms.Cursors.Hand;
		FB1244B4.Location = new System.Drawing.Point(3, 3);
		FB1244B4.Name = "rbNganCachMoiDong";
		FB1244B4.Size = new System.Drawing.Size(155, 20);
		FB1244B4.TabIndex = 3;
		FB1244B4.TabStop = true;
		FB1244B4.Text = "Nội dung chỉ có 1 dòng";
		FB1244B4.UseVisualStyleBackColor = true;
		FB1244B4.CheckedChanged += new System.EventHandler(AC21E895);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(165, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 21);
		button2.TabIndex = 173;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(A1112B15);
		BDA0F506.AutoSize = true;
		BDA0F506.Cursor = System.Windows.Forms.Cursors.Hand;
		BDA0F506.Location = new System.Drawing.Point(3, 24);
		BDA0F506.Name = "rbNganCachKyTu";
		BDA0F506.Size = new System.Drawing.Size(159, 20);
		BDA0F506.TabIndex = 3;
		BDA0F506.Text = "Nội dung có nhiều dòng";
		BDA0F506.UseVisualStyleBackColor = true;
		BDA0F506.CheckedChanged += new System.EventHandler(BDA0F506_CheckedChanged);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(2, 186);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(64, 16);
		label2.TabIndex = 175;
		label2.Text = "Tùy chọn:";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(3, 164);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(133, 16);
		label11.TabIndex = 174;
		label11.Text = "Spin nội dung {a|b|c}";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 450);
		base.Controls.Add(EF2F5A11);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXemReel";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXemReel_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		EF2F5A11.ResumeLayout(false);
		EF2F5A11.PerformLayout();
		EDA1511C.ResumeLayout(false);
		EDA1511C.PerformLayout();
		((System.ComponentModel.ISupportInitialize)ED0A4813).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		ResumeLayout(false);
	}
}
