using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanVoiBanCuaBanBe : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string CB385E8E;

	internal string string_0;

	internal string C8087E39;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer F61C9494 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel B0ABDFB6;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox txtTenHanhDong;

	internal Label C221AF2B;

	internal Label AA0DD6AB;

	internal Label E5171332;

	internal Label CB1F222D;

	internal Button B4B04483;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudDelayFrom;

	internal Label label7;

	internal Label D39B2E0E;

	internal Label D2B85B29;

	internal NumericUpDown B8B8D8B8;

	internal Label label9;

	internal Label D1009710;

	public fHDKetBanVoiBanCuaBanBe(string BB9FBB02, int int_1 = 0, string string_1 = "")
	{
		InitializeComponent();
		bool_0 = false;
		CB385E8E = BB9FBB02;
		C8087E39 = string_1;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDKetBanVoiBanCuaBanBe").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanVoiBanCuaBanBe', 'Kết bạn với bạn của Bạn bè');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDKetBanVoiBanCuaBanBe");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_1);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void C5B31421()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(CB1F222D);
		Language.smethod_1(E5171332);
		Language.smethod_1(C221AF2B);
		Language.smethod_1(AA0DD6AB);
		Language.smethod_1(D2B85B29);
		Language.smethod_1(label7);
		Language.smethod_1(D39B2E0E);
		Language.smethod_1(btnAdd);
		Language.smethod_1(B4B04483);
	}

	private void fHDKetBanVoiBanCuaBanBe_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = f72FAFBC_0.method_0("nudSoLuongTo", 5);
			nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			B8B8D8B8.Value = f72FAFBC_0.method_0("nudTimesWarning", 3);
		}
		catch
		{
		}
	}

	private void B3AA1095(object sender, EventArgs e)
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
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("nudTimesWarning", B8B8D8B8.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(CB385E8E, text, string_0, text2))
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
			if (Class123.smethod_14(C8087E39, text, text2))
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

	private void B4B04483_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B0ABDFB6_Paint(object sender, PaintEventArgs e)
	{
		if (B0ABDFB6.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, B0ABDFB6.ClientSize.Width - num, B0ABDFB6.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool C29AAC20)
	{
		if (C29AAC20 && F61C9494 != null)
		{
			F61C9494.Dispose();
		}
		base.Dispose(C29AAC20);
	}

	private void InitializeComponent()
	{
		F61C9494 = new System.ComponentModel.Container();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(F61C9494);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(F61C9494);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		B0ABDFB6 = new System.Windows.Forms.Panel();
		B8B8D8B8 = new System.Windows.Forms.NumericUpDown();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		D39B2E0E = new System.Windows.Forms.Label();
		D1009710 = new System.Windows.Forms.Label();
		D2B85B29 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		C221AF2B = new System.Windows.Forms.Label();
		AA0DD6AB = new System.Windows.Forms.Label();
		E5171332 = new System.Windows.Forms.Label();
		CB1F222D = new System.Windows.Forms.Label();
		B4B04483 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		B0ABDFB6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B8B8D8B8).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
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
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn với bạn của Bạn bè";
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
		button1.Image = Resource.Bitmap_9;
		button1.Location = new System.Drawing.Point(328, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(B3AA1095);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		B0ABDFB6.BackColor = System.Drawing.Color.White;
		B0ABDFB6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B0ABDFB6.Controls.Add(B8B8D8B8);
		B0ABDFB6.Controls.Add(nudDelayTo);
		B0ABDFB6.Controls.Add(nudDelayFrom);
		B0ABDFB6.Controls.Add(label9);
		B0ABDFB6.Controls.Add(label7);
		B0ABDFB6.Controls.Add(D39B2E0E);
		B0ABDFB6.Controls.Add(D1009710);
		B0ABDFB6.Controls.Add(D2B85B29);
		B0ABDFB6.Controls.Add(nudSoLuongTo);
		B0ABDFB6.Controls.Add(nudSoLuongFrom);
		B0ABDFB6.Controls.Add(txtTenHanhDong);
		B0ABDFB6.Controls.Add(C221AF2B);
		B0ABDFB6.Controls.Add(AA0DD6AB);
		B0ABDFB6.Controls.Add(E5171332);
		B0ABDFB6.Controls.Add(CB1F222D);
		B0ABDFB6.Controls.Add(B4B04483);
		B0ABDFB6.Controls.Add(btnAdd);
		B0ABDFB6.Controls.Add(bunifuCards1);
		B0ABDFB6.Cursor = System.Windows.Forms.Cursors.Arrow;
		B0ABDFB6.Dock = System.Windows.Forms.DockStyle.Fill;
		B0ABDFB6.Location = new System.Drawing.Point(0, 0);
		B0ABDFB6.Name = "panel1";
		B0ABDFB6.Size = new System.Drawing.Size(362, 187);
		B0ABDFB6.TabIndex = 0;
		B0ABDFB6.Paint += new System.Windows.Forms.PaintEventHandler(B0ABDFB6_Paint);
		B8B8D8B8.Location = new System.Drawing.Point(253, 220);
		B8B8D8B8.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B8B8D8B8.Name = "nudTimesWarning";
		B8B8D8B8.Size = new System.Drawing.Size(43, 23);
		B8B8D8B8.TabIndex = 4;
		nudDelayTo.Location = new System.Drawing.Point(229, 112);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(132, 112);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(299, 222);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(25, 16);
		label9.TabIndex = 45;
		label9.Text = "lần";
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(194, 114);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		D39B2E0E.AutoSize = true;
		D39B2E0E.Location = new System.Drawing.Point(290, 114);
		D39B2E0E.Name = "label6";
		D39B2E0E.Size = new System.Drawing.Size(31, 16);
		D39B2E0E.TabIndex = 45;
		D39B2E0E.Text = "giây";
		D1009710.AutoSize = true;
		D1009710.Location = new System.Drawing.Point(27, 222);
		D1009710.Name = "label8";
		D1009710.Size = new System.Drawing.Size(226, 16);
		D1009710.TabIndex = 44;
		D1009710.Text = "Dừng khi gặp cảnh báo của Facebook:";
		D2B85B29.AutoSize = true;
		D2B85B29.Location = new System.Drawing.Point(27, 114);
		D2B85B29.Name = "label5";
		D2B85B29.Size = new System.Drawing.Size(90, 16);
		D2B85B29.TabIndex = 44;
		D2B85B29.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new System.Drawing.Point(229, 81);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 81);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		C221AF2B.AutoSize = true;
		C221AF2B.Location = new System.Drawing.Point(194, 83);
		C221AF2B.Name = "label3";
		C221AF2B.Size = new System.Drawing.Size(29, 16);
		C221AF2B.TabIndex = 37;
		C221AF2B.Text = "đê\u0301n";
		AA0DD6AB.AutoSize = true;
		AA0DD6AB.Location = new System.Drawing.Point(290, 83);
		AA0DD6AB.Name = "label4";
		AA0DD6AB.Size = new System.Drawing.Size(29, 16);
		AA0DD6AB.TabIndex = 35;
		AA0DD6AB.Text = "ba\u0323n";
		E5171332.AutoSize = true;
		E5171332.Location = new System.Drawing.Point(27, 83);
		E5171332.Name = "label2";
		E5171332.Size = new System.Drawing.Size(89, 16);
		E5171332.TabIndex = 32;
		E5171332.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		CB1F222D.AutoSize = true;
		CB1F222D.Location = new System.Drawing.Point(27, 52);
		CB1F222D.Name = "label1";
		CB1F222D.Size = new System.Drawing.Size(99, 16);
		CB1F222D.TabIndex = 31;
		CB1F222D.Text = "Tên ha\u0300nh đô\u0323ng:";
		B4B04483.BackColor = System.Drawing.Color.Maroon;
		B4B04483.Cursor = System.Windows.Forms.Cursors.Hand;
		B4B04483.FlatAppearance.BorderSize = 0;
		B4B04483.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B4B04483.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B4B04483.ForeColor = System.Drawing.Color.White;
		B4B04483.Location = new System.Drawing.Point(193, 146);
		B4B04483.Name = "btnCancel";
		B4B04483.Size = new System.Drawing.Size(92, 29);
		B4B04483.TabIndex = 7;
		B4B04483.Text = "Đóng";
		B4B04483.UseVisualStyleBackColor = false;
		B4B04483.Click += new System.EventHandler(B4B04483_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(86, 146);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
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
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 187);
		base.Controls.Add(B0ABDFB6);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanVoiBanCuaBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanVoiBanCuaBanBe_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		B0ABDFB6.ResumeLayout(false);
		B0ABDFB6.PerformLayout();
		((System.ComponentModel.ISupportInitialize)B8B8D8B8).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
