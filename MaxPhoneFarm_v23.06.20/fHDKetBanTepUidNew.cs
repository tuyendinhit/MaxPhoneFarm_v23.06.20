using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanTepUidNew : Form
{
	internal JSON_Settings f72FAFBC_0 = null;

	internal string string_0;

	internal string string_1;

	internal string F0127722;

	internal int D4099A9A;

	internal static bool C48F14B3;

	internal IContainer C8B5B822 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button E7B11192;

	internal Button btnAdd;

	internal BunifuCards A38E7D9E;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label B0B561BD;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown A49F8B21;

	internal Label label7;

	internal Label label6;

	internal Label D28D8A24;

	internal NumericUpDown D7B5F39D;

	internal NumericUpDown A713AC0B;

	internal Label CB116728;

	internal Label label4;

	internal Label label8;

	internal RichTextBox C01A431E;

	internal Label label10;

	public fHDKetBanTepUidNew(string string_2, int int_0 = 0, string string_3 = "")
	{
		InitializeComponent();
		C48F14B3 = false;
		string_0 = string_2;
		F0127722 = string_3;
		D4099A9A = int_0;
		if (Class123.C7BE863B("", "HDKetBanTepUidNew").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanTepUidNew', 'Kết bạn theo tệp Uid v2');");
		}
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDKetBanTepUidNew");
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(label8);
		Language.smethod_1(CB116728);
		Language.smethod_1(label4);
		Language.smethod_1(D28D8A24);
		Language.smethod_1(label7);
		Language.smethod_1(label6);
		Language.smethod_1(B0B561BD);
		Language.smethod_1(label10);
		Language.smethod_1(btnAdd);
		Language.smethod_1(E7B11192);
	}

	private void fHDKetBanTepUidNew_Load(object sender, EventArgs e)
	{
		try
		{
			C01A431E.Text = f72FAFBC_0.GetValue("txtLink");
			A49F8B21.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			A713AC0B.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 3);
			D7B5F39D.Value = f72FAFBC_0.method_0("nudSoLuongTo", 3);
		}
		catch
		{
		}
	}

	private void DF9C23AA(object sender, EventArgs e)
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
		f72FAFBC.GetValue("txtLink", (object)C01A431E.Text);
		f72FAFBC.GetValue("nudDelayFrom", A49F8B21.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("nudSoLuongFrom", A713AC0B.Value);
		f72FAFBC.GetValue("nudSoLuongTo", D7B5F39D.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (D4099A9A == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text2))
				{
					C48F14B3 = true;
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
			if (Class123.smethod_14(F0127722, text, text2))
			{
				C48F14B3 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void B7055F86(object sender, EventArgs e)
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

	private void C01A431E_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = C01A431E.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			B0B561BD.Text = string.Format(Language.GetValue("Danh sách Link bài viết ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && C8B5B822 != null)
		{
			C8B5B822.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		C8B5B822 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanTepUidNew));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(C8B5B822);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(C8B5B822);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		A49F8B21 = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		D28D8A24 = new System.Windows.Forms.Label();
		D7B5F39D = new System.Windows.Forms.NumericUpDown();
		A713AC0B = new System.Windows.Forms.NumericUpDown();
		CB116728 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		B0B561BD = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		E7B11192 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		A38E7D9E = new Bunifu.Framework.UI.BunifuCards();
		C01A431E = new System.Windows.Forms.RichTextBox();
		label10 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)A49F8B21).BeginInit();
		((System.ComponentModel.ISupportInitialize)D7B5F39D).BeginInit();
		((System.ComponentModel.ISupportInitialize)A713AC0B).BeginInit();
		A38E7D9E.SuspendLayout();
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
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn theo tệp Uid v2";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
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
		button1.Click += new System.EventHandler(DF9C23AA);
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
		panel1.Controls.Add(C01A431E);
		panel1.Controls.Add(label10);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(A49F8B21);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(D28D8A24);
		panel1.Controls.Add(D7B5F39D);
		panel1.Controls.Add(A713AC0B);
		panel1.Controls.Add(CB116728);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(B0B561BD);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(E7B11192);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(A38E7D9E);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 417);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		nudDelayTo.Location = new System.Drawing.Point(231, 109);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 50;
		A49F8B21.Location = new System.Drawing.Point(134, 109);
		A49F8B21.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A49F8B21.Name = "nudDelayFrom";
		A49F8B21.Size = new System.Drawing.Size(56, 23);
		A49F8B21.TabIndex = 49;
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(196, 111);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 56;
		label7.Text = "đê\u0301n";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(292, 111);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 55;
		label6.Text = "giây";
		D28D8A24.AutoSize = true;
		D28D8A24.Location = new System.Drawing.Point(27, 111);
		D28D8A24.Name = "label2";
		D28D8A24.Size = new System.Drawing.Size(90, 16);
		D28D8A24.TabIndex = 54;
		D28D8A24.Text = "Thơ\u0300i gian chơ\u0300:";
		D7B5F39D.Location = new System.Drawing.Point(231, 78);
		D7B5F39D.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D7B5F39D.Name = "nudSoLuongTo";
		D7B5F39D.Size = new System.Drawing.Size(56, 23);
		D7B5F39D.TabIndex = 48;
		A713AC0B.Location = new System.Drawing.Point(134, 78);
		A713AC0B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A713AC0B.Name = "nudSoLuongFrom";
		A713AC0B.Size = new System.Drawing.Size(56, 23);
		A713AC0B.TabIndex = 47;
		CB116728.AutoSize = true;
		CB116728.Location = new System.Drawing.Point(196, 80);
		CB116728.Name = "label3";
		CB116728.Size = new System.Drawing.Size(29, 16);
		CB116728.TabIndex = 53;
		CB116728.Text = "đê\u0301n";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(292, 80);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 52;
		label4.Text = "ba\u0323n";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(27, 80);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(89, 16);
		label8.TabIndex = 51;
		label8.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		B0B561BD.AutoSize = true;
		B0B561BD.Location = new System.Drawing.Point(27, 141);
		B0B561BD.Name = "label5";
		B0B561BD.Size = new System.Drawing.Size(164, 16);
		B0B561BD.TabIndex = 31;
		B0B561BD.Text = "Danh sách Link bài viết (0):";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		E7B11192.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		E7B11192.BackColor = System.Drawing.Color.Maroon;
		E7B11192.Cursor = System.Windows.Forms.Cursors.Hand;
		E7B11192.FlatAppearance.BorderSize = 0;
		E7B11192.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E7B11192.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E7B11192.ForeColor = System.Drawing.Color.White;
		E7B11192.Location = new System.Drawing.Point(189, 373);
		E7B11192.Name = "btnCancel";
		E7B11192.Size = new System.Drawing.Size(92, 29);
		E7B11192.TabIndex = 10;
		E7B11192.Text = "Đóng";
		E7B11192.UseVisualStyleBackColor = false;
		E7B11192.Click += new System.EventHandler(B7055F86);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 373);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		A38E7D9E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A38E7D9E.BackColor = System.Drawing.Color.White;
		A38E7D9E.BorderRadius = 0;
		A38E7D9E.BottomSahddow = true;
		A38E7D9E.color = System.Drawing.Color.DarkViolet;
		A38E7D9E.Controls.Add(pnlHeader);
		A38E7D9E.LeftSahddow = false;
		A38E7D9E.Location = new System.Drawing.Point(1, 0);
		A38E7D9E.Name = "bunifuCards1";
		A38E7D9E.RightSahddow = true;
		A38E7D9E.ShadowDepth = 20;
		A38E7D9E.Size = new System.Drawing.Size(359, 37);
		A38E7D9E.TabIndex = 28;
		C01A431E.Location = new System.Drawing.Point(31, 160);
		C01A431E.Name = "txtLink";
		C01A431E.Size = new System.Drawing.Size(297, 189);
		C01A431E.TabIndex = 57;
		C01A431E.Text = "";
		C01A431E.WordWrap = false;
		C01A431E.TextChanged += new System.EventHandler(C01A431E_TextChanged);
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(29, 352);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(97, 16);
		label10.TabIndex = 58;
		label10.Text = "(Mỗi ID 1 dòng)";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 417);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanTepUidNew";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanTepUidNew_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)A49F8B21).EndInit();
		((System.ComponentModel.ISupportInitialize)D7B5F39D).EndInit();
		((System.ComponentModel.ISupportInitialize)A713AC0B).EndInit();
		A38E7D9E.ResumeLayout(false);
		ResumeLayout(false);
	}
}
