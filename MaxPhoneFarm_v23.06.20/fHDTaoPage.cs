using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTaoPage : Form
{
	internal JSON_Settings D8BCBD3E = null;

	internal string string_0;

	internal string F421E73D;

	internal string B524B52C;

	internal int EAB901BB;

	internal static bool BB9D9C33;

	internal IContainer BAB05B0B = null;

	internal BunifuDragControl D13B3BA7;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal TextBox D3B8D90F;

	internal Label D8897493;

	internal Button btnCancel;

	internal Button C71FA9A3;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button EDB7DB02;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal RichTextBox txtTenNhom;

	internal Label label2;

	internal NumericUpDown D5BBE38C;

	internal NumericUpDown nudSoLuongFrom;

	internal Label label3;

	internal Label B02250A4;

	internal RichTextBox F1317598;

	internal Label lblCatagory;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown F29569BC;

	internal Label EBAB489D;

	internal Label B5A7A935;

	public fHDTaoPage(string string_1, int int_0 = 0, string string_2 = "")
	{
		InitializeComponent();
		BB9D9C33 = false;
		string_0 = string_1;
		B524B52C = string_2;
		EAB901BB = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Tạo page";
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
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			F421E73D = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			D3B8D90F.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			C71FA9A3.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			D3B8D90F.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		D8BCBD3E = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void D8BFD499(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = D8BCBD3E.method_0("nudSoLuongFrom", 1);
			D5BBE38C.Value = D8BCBD3E.method_0("nudSoLuongTo", 1);
			F29569BC.Value = D8BCBD3E.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = D8BCBD3E.method_0("nudDelayTo", 5);
			txtTenNhom.Text = D8BCBD3E.GetValue("txtTenNhom", "MIN ********");
			F1317598.Text = D8BCBD3E.GetValue("txtCatagory", "Digital creator");
		}
		catch
		{
		}
	}

	private void EDB7DB02_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C71FA9A3_Click(object sender, EventArgs e)
	{
		string text = D3B8D90F.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", D5BBE38C.Value);
		f72FAFBC.GetValue("nudDelayFrom", F29569BC.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("txtTenNhom", (object)txtTenNhom.Text);
		f72FAFBC.GetValue("txtCatagory", (object)F1317598.Text);
		string text2 = f72FAFBC.C71A4EA4();
		if (EAB901BB == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, F421E73D, text2))
				{
					BB9D9C33 = true;
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
			if (Class123.smethod_14(B524B52C, text, text2))
			{
				BB9D9C33 = true;
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
		string text = E3A31B0C.smethod_2();
		string text2 = "avatar_";
		if (B524B52C == "")
		{
			B524B52C = (Class123.A3A46880() + 1).ToString() ?? "";
		}
		text2 += B524B52C;
		Common.CreateFolder(text + "\\" + text2);
		Process.Start(text + "\\" + text2);
	}

	private void txtTenNhom_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtTenNhom, B02250A4);
	}

	private void F1317598_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(F1317598, lblCatagory);
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && BAB05B0B != null)
		{
			BAB05B0B.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		BAB05B0B = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTaoPage));
		D13B3BA7 = new Bunifu.Framework.UI.BunifuDragControl(BAB05B0B);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(BAB05B0B);
		pnlHeader = new System.Windows.Forms.Panel();
		EDB7DB02 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		D5BBE38C = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		label3 = new System.Windows.Forms.Label();
		txtTenNhom = new System.Windows.Forms.RichTextBox();
		D3B8D90F = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		D8897493 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		C71FA9A3 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		F29569BC = new System.Windows.Forms.NumericUpDown();
		EBAB489D = new System.Windows.Forms.Label();
		B5A7A935 = new System.Windows.Forms.Label();
		F1317598 = new System.Windows.Forms.RichTextBox();
		lblCatagory = new System.Windows.Forms.Label();
		B02250A4 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D5BBE38C).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)F29569BC).BeginInit();
		SuspendLayout();
		D13B3BA7.Fixed = true;
		D13B3BA7.Horizontal = true;
		D13B3BA7.TargetControl = bunifuCustomLabel1;
		D13B3BA7.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tạo page";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(EDB7DB02);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		EDB7DB02.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		EDB7DB02.Cursor = System.Windows.Forms.Cursors.Hand;
		EDB7DB02.FlatAppearance.BorderSize = 0;
		EDB7DB02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EDB7DB02.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EDB7DB02.ForeColor = System.Drawing.Color.White;
		EDB7DB02.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		EDB7DB02.Location = new System.Drawing.Point(328, 1);
		EDB7DB02.Name = "button1";
		EDB7DB02.Size = new System.Drawing.Size(30, 30);
		EDB7DB02.TabIndex = 77;
		EDB7DB02.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		EDB7DB02.UseVisualStyleBackColor = true;
		EDB7DB02.Click += new System.EventHandler(EDB7DB02_Click);
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
		panel1.Controls.Add(B02250A4);
		panel1.Controls.Add(F1317598);
		panel1.Controls.Add(lblCatagory);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(F29569BC);
		panel1.Controls.Add(EBAB489D);
		panel1.Controls.Add(B5A7A935);
		panel1.Controls.Add(D5BBE38C);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(txtTenNhom);
		panel1.Controls.Add(D3B8D90F);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(D8897493);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(C71FA9A3);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 457);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		D5BBE38C.Location = new System.Drawing.Point(229, 78);
		D5BBE38C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D5BBE38C.Name = "nudSoLuongTo";
		D5BBE38C.Size = new System.Drawing.Size(56, 23);
		D5BBE38C.TabIndex = 39;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 38;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(194, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 42;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		txtTenNhom.Location = new System.Drawing.Point(30, 156);
		txtTenNhom.Name = "txtTenNhom";
		txtTenNhom.Size = new System.Drawing.Size(296, 109);
		txtTenNhom.TabIndex = 35;
		txtTenNhom.Text = "";
		txtTenNhom.WordWrap = false;
		txtTenNhom.TextChanged += new System.EventHandler(txtTenNhom_TextChanged);
		D3B8D90F.Location = new System.Drawing.Point(132, 49);
		D3B8D90F.Name = "txtTenHanhDong";
		D3B8D90F.Size = new System.Drawing.Size(194, 23);
		D3B8D90F.TabIndex = 0;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(59, 16);
		label2.TabIndex = 34;
		label2.Text = "Số page:";
		D8897493.AutoSize = true;
		D8897493.Location = new System.Drawing.Point(27, 52);
		D8897493.Name = "label1";
		D8897493.Size = new System.Drawing.Size(98, 16);
		D8897493.TabIndex = 31;
		D8897493.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 412);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		C71FA9A3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		C71FA9A3.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		C71FA9A3.Cursor = System.Windows.Forms.Cursors.Hand;
		C71FA9A3.FlatAppearance.BorderSize = 0;
		C71FA9A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C71FA9A3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C71FA9A3.ForeColor = System.Drawing.Color.White;
		C71FA9A3.Location = new System.Drawing.Point(82, 412);
		C71FA9A3.Name = "btnAdd";
		C71FA9A3.Size = new System.Drawing.Size(92, 29);
		C71FA9A3.TabIndex = 9;
		C71FA9A3.Text = "Thêm";
		C71FA9A3.UseVisualStyleBackColor = false;
		C71FA9A3.Click += new System.EventHandler(C71FA9A3_Click);
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
		nudDelayTo.Location = new System.Drawing.Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 48;
		F29569BC.Location = new System.Drawing.Point(132, 107);
		F29569BC.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F29569BC.Name = "nudDelayFrom";
		F29569BC.Size = new System.Drawing.Size(56, 23);
		F29569BC.TabIndex = 47;
		EBAB489D.AutoSize = true;
		EBAB489D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EBAB489D.Location = new System.Drawing.Point(199, 109);
		EBAB489D.Name = "label7";
		EBAB489D.Size = new System.Drawing.Size(18, 16);
		EBAB489D.TabIndex = 51;
		EBAB489D.Text = ">";
		B5A7A935.AutoSize = true;
		B5A7A935.Location = new System.Drawing.Point(27, 109);
		B5A7A935.Name = "label4";
		B5A7A935.Size = new System.Drawing.Size(92, 16);
		B5A7A935.TabIndex = 49;
		B5A7A935.Text = "Delay time (s):";
		F1317598.Location = new System.Drawing.Point(30, 287);
		F1317598.Name = "txtCatagory";
		F1317598.Size = new System.Drawing.Size(295, 110);
		F1317598.TabIndex = 53;
		F1317598.Text = "";
		F1317598.WordWrap = false;
		F1317598.TextChanged += new System.EventHandler(F1317598_TextChanged);
		lblCatagory.AutoSize = true;
		lblCatagory.Location = new System.Drawing.Point(27, 268);
		lblCatagory.Name = "lblCatagory";
		lblCatagory.Size = new System.Drawing.Size(122, 16);
		lblCatagory.TabIndex = 52;
		lblCatagory.Text = "Danh mục page (0):";
		B02250A4.AutoSize = true;
		B02250A4.Location = new System.Drawing.Point(27, 137);
		B02250A4.Name = "lblPageName";
		B02250A4.Size = new System.Drawing.Size(87, 16);
		B02250A4.TabIndex = 54;
		B02250A4.Text = "Tên page (0):";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 457);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTaoPage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D8BFD499);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)D5BBE38C).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)F29569BC).EndInit();
		ResumeLayout(false);
	}
}
