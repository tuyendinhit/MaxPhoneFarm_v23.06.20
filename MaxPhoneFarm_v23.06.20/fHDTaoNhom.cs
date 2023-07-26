using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTaoNhom : Form
{
	internal JSON_Settings f72FAFBC_0 = null;

	internal string string_0;

	internal string string_1;

	internal string B18D7FB6;

	internal int D781E790;

	internal static bool bool_0;

	internal IContainer AE03F6AE = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl C110DA3D;

	internal Panel B794AE0E;

	internal TextBox txtTenHanhDong;

	internal Label F7B10499;

	internal Label D28D14B4;

	internal Button BF39729A;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal RichTextBox txtTenNhom;

	internal Label label2;

	internal NumericUpDown EA0B48A8;

	internal NumericUpDown FE953492;

	internal Label F83AF902;

	public fHDTaoNhom(string string_2, int int_0 = 0, string D4355230 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		B18D7FB6 = D4355230;
		D781E790 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Tạo nhóm";
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
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(D4355230);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void E986C111()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(D28D14B4);
		Language.smethod_1(F7B10499);
		Language.smethod_1(btnAdd);
		Language.smethod_1(BF39729A);
	}

	private void DF147A80(object sender, EventArgs e)
	{
		try
		{
			FE953492.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 1);
			EA0B48A8.Value = f72FAFBC_0.method_0("nudSoLuongTo", 1);
			txtTenNhom.Text = f72FAFBC_0.GetValue("txtTenNhom", "MIN ********");
		}
		catch
		{
		}
	}

	private void DF1EC2BD(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", FE953492.Value);
		f72FAFBC.GetValue("nudSoLuongTo", EA0B48A8.Value);
		f72FAFBC.GetValue("txtTenNhom", (object)txtTenNhom.Text);
		string text2 = f72FAFBC.C71A4EA4();
		if (D781E790 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text2))
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
			if (Class123.smethod_14(B18D7FB6, text, text2))
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

	private void AF9D660C(object sender, EventArgs e)
	{
		Close();
	}

	private void B794AE0E_Paint(object sender, PaintEventArgs e)
	{
		if (B794AE0E.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, B794AE0E.ClientSize.Width - num, B794AE0E.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		string text = E3A31B0C.smethod_2();
		string text2 = "avatar_";
		if (B18D7FB6 == "")
		{
			B18D7FB6 = (Class123.A3A46880() + 1).ToString() ?? "";
		}
		text2 += B18D7FB6;
		Common.CreateFolder(text + "\\" + text2);
		Process.Start(text + "\\" + text2);
	}

	protected override void Dispose(bool DD0AABA6)
	{
		if (DD0AABA6 && AE03F6AE != null)
		{
			AE03F6AE.Dispose();
		}
		base.Dispose(DD0AABA6);
	}

	private void InitializeComponent()
	{
		AE03F6AE = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTaoNhom));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(AE03F6AE);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		C110DA3D = new Bunifu.Framework.UI.BunifuDragControl(AE03F6AE);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		B794AE0E = new System.Windows.Forms.Panel();
		txtTenNhom = new System.Windows.Forms.RichTextBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		F7B10499 = new System.Windows.Forms.Label();
		D28D14B4 = new System.Windows.Forms.Label();
		BF39729A = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		label2 = new System.Windows.Forms.Label();
		EA0B48A8 = new System.Windows.Forms.NumericUpDown();
		FE953492 = new System.Windows.Forms.NumericUpDown();
		F83AF902 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		B794AE0E.SuspendLayout();
		bunifuCards1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)EA0B48A8).BeginInit();
		((System.ComponentModel.ISupportInitialize)FE953492).BeginInit();
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
		bunifuCustomLabel1.Text = "Cấu hình Tạo nhóm";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C110DA3D.Fixed = true;
		C110DA3D.Horizontal = true;
		C110DA3D.TargetControl = pnlHeader;
		C110DA3D.Vertical = true;
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
		button1.Click += new System.EventHandler(DF1EC2BD);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		B794AE0E.BackColor = System.Drawing.Color.White;
		B794AE0E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B794AE0E.Controls.Add(EA0B48A8);
		B794AE0E.Controls.Add(FE953492);
		B794AE0E.Controls.Add(F83AF902);
		B794AE0E.Controls.Add(txtTenNhom);
		B794AE0E.Controls.Add(txtTenHanhDong);
		B794AE0E.Controls.Add(label2);
		B794AE0E.Controls.Add(F7B10499);
		B794AE0E.Controls.Add(D28D14B4);
		B794AE0E.Controls.Add(BF39729A);
		B794AE0E.Controls.Add(btnAdd);
		B794AE0E.Controls.Add(bunifuCards1);
		B794AE0E.Cursor = System.Windows.Forms.Cursors.Arrow;
		B794AE0E.Dock = System.Windows.Forms.DockStyle.Fill;
		B794AE0E.Location = new System.Drawing.Point(0, 0);
		B794AE0E.Name = "panel1";
		B794AE0E.Size = new System.Drawing.Size(362, 314);
		B794AE0E.TabIndex = 0;
		B794AE0E.Paint += new System.Windows.Forms.PaintEventHandler(B794AE0E_Paint);
		txtTenNhom.Location = new System.Drawing.Point(132, 107);
		txtTenNhom.Name = "txtTenNhom";
		txtTenNhom.Size = new System.Drawing.Size(194, 147);
		txtTenNhom.TabIndex = 35;
		txtTenNhom.Text = "";
		txtTenNhom.WordWrap = false;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		F7B10499.AutoSize = true;
		F7B10499.Location = new System.Drawing.Point(27, 110);
		F7B10499.Name = "label5";
		F7B10499.Size = new System.Drawing.Size(70, 16);
		F7B10499.TabIndex = 34;
		F7B10499.Text = "Tên nhóm:";
		D28D14B4.AutoSize = true;
		D28D14B4.Location = new System.Drawing.Point(27, 52);
		D28D14B4.Name = "label1";
		D28D14B4.Size = new System.Drawing.Size(98, 16);
		D28D14B4.TabIndex = 31;
		D28D14B4.Text = "Tên ha\u0300nh đô\u0323ng:";
		BF39729A.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		BF39729A.BackColor = System.Drawing.Color.Maroon;
		BF39729A.Cursor = System.Windows.Forms.Cursors.Hand;
		BF39729A.FlatAppearance.BorderSize = 0;
		BF39729A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BF39729A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BF39729A.ForeColor = System.Drawing.Color.White;
		BF39729A.Location = new System.Drawing.Point(189, 269);
		BF39729A.Name = "btnCancel";
		BF39729A.Size = new System.Drawing.Size(92, 29);
		BF39729A.TabIndex = 10;
		BF39729A.Text = "Đóng";
		BF39729A.UseVisualStyleBackColor = false;
		BF39729A.Click += new System.EventHandler(AF9D660C);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 269);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
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
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(63, 16);
		label2.TabIndex = 34;
		label2.Text = "Số nhóm:";
		EA0B48A8.Location = new System.Drawing.Point(229, 78);
		EA0B48A8.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		EA0B48A8.Name = "nudSoLuongTo";
		EA0B48A8.Size = new System.Drawing.Size(56, 23);
		EA0B48A8.TabIndex = 39;
		FE953492.Location = new System.Drawing.Point(132, 78);
		FE953492.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FE953492.Name = "nudSoLuongFrom";
		FE953492.Size = new System.Drawing.Size(56, 23);
		FE953492.TabIndex = 38;
		F83AF902.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F83AF902.Location = new System.Drawing.Point(194, 80);
		F83AF902.Name = "label3";
		F83AF902.Size = new System.Drawing.Size(29, 16);
		F83AF902.TabIndex = 42;
		F83AF902.Text = ">";
		F83AF902.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 314);
		base.Controls.Add(B794AE0E);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTaoNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(DF147A80);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		B794AE0E.ResumeLayout(false);
		B794AE0E.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)EA0B48A8).EndInit();
		((System.ComponentModel.ISupportInitialize)FE953492).EndInit();
		ResumeLayout(false);
	}
}
