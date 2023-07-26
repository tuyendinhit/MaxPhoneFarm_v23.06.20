using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanGoiY : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string A4BDCAA2;

	internal string string_1;

	internal int CD090F99;

	internal static bool A19EB291;

	internal IContainer D91F0D22 = null;

	internal BunifuDragControl C5171F0F;

	internal BunifuDragControl EC8804B0;

	internal Panel panel1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox C4BFB707;

	internal Label label3;

	internal Label E888C2B3;

	internal Label label2;

	internal Label F51D5CAF;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel B8164D2A;

	internal Button button1;

	internal PictureBox EA889415;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown C3A737B1;

	internal Label label7;

	internal Label D1BBD58F;

	internal Label label5;

	internal CheckBox A49C1403;

	internal CheckBox ckbChiKetBanTenCoDau;

	internal NumericUpDown nudTimesWarning;

	internal Label FC24838F;

	internal Label label8;

	internal NumericUpDown DFA0ABB8;

	internal Label label10;

	public fHDKetBanGoiY(string CB108B8C, int int_0 = 0, string C9227D12 = "")
	{
		InitializeComponent();
		A19EB291 = false;
		string_0 = CB108B8C;
		string_1 = C9227D12;
		CD090F99 = int_0;
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDKetBanGoiY");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			A4BDCAA2 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			C4BFB707.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(C9227D12);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			C4BFB707.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(F51D5CAF);
		Language.smethod_1(label2);
		Language.smethod_1(label3);
		Language.smethod_1(E888C2B3);
		Language.smethod_1(label5);
		Language.smethod_1(label7);
		Language.smethod_1(D1BBD58F);
		Language.smethod_1(ckbChiKetBanTenCoDau);
		Language.smethod_1(A49C1403);
		Language.smethod_1(label8);
		Language.smethod_1(FC24838F);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void fHDKetBanGoiY_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom");
			nudSoLuongTo.Value = f72FAFBC_0.method_0("nudSoLuongTo");
			C3A737B1.Value = f72FAFBC_0.method_0("nudDelayFrom");
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo");
			DFA0ABB8.Value = f72FAFBC_0.method_0("nudDelayCheck", 10);
			ckbChiKetBanTenCoDau.Checked = f72FAFBC_0.AA824D29("ckbChiKetBanTenCoDau");
			A49C1403.Checked = f72FAFBC_0.AA824D29("ckbOnlyAddFriendWithMutualFriends");
			nudTimesWarning.Value = f72FAFBC_0.method_0("nudTimesWarning", 3);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = C4BFB707.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", C3A737B1.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("nudDelayCheck", DFA0ABB8.Value);
		f72FAFBC.GetValue("ckbChiKetBanTenCoDau", ckbChiKetBanTenCoDau.Checked);
		f72FAFBC.GetValue("ckbOnlyAddFriendWithMutualFriends", A49C1403.Checked);
		f72FAFBC.GetValue("nudTimesWarning", nudTimesWarning.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (CD090F99 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, A4BDCAA2, text2))
				{
					A19EB291 = true;
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
				A19EB291 = true;
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

	private void D0012839(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && D91F0D22 != null)
		{
			D91F0D22.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		D91F0D22 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanGoiY));
		C5171F0F = new Bunifu.Framework.UI.BunifuDragControl(D91F0D22);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		EC8804B0 = new Bunifu.Framework.UI.BunifuDragControl(D91F0D22);
		B8164D2A = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		EA889415 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		A49C1403 = new System.Windows.Forms.CheckBox();
		ckbChiKetBanTenCoDau = new System.Windows.Forms.CheckBox();
		nudTimesWarning = new System.Windows.Forms.NumericUpDown();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		C3A737B1 = new System.Windows.Forms.NumericUpDown();
		FC24838F = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		D1BBD58F = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		C4BFB707 = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		E888C2B3 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		F51D5CAF = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		label10 = new System.Windows.Forms.Label();
		DFA0ABB8 = new System.Windows.Forms.NumericUpDown();
		B8164D2A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)EA889415).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudTimesWarning).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)C3A737B1).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DFA0ABB8).BeginInit();
		SuspendLayout();
		C5171F0F.Fixed = true;
		C5171F0F.Horizontal = true;
		C5171F0F.TargetControl = bunifuCustomLabel1;
		C5171F0F.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn gợi ý";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		EC8804B0.Fixed = true;
		EC8804B0.Horizontal = true;
		EC8804B0.TargetControl = B8164D2A;
		EC8804B0.Vertical = true;
		B8164D2A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B8164D2A.BackColor = System.Drawing.Color.White;
		B8164D2A.Controls.Add(button1);
		B8164D2A.Controls.Add(EA889415);
		B8164D2A.Controls.Add(bunifuCustomLabel1);
		B8164D2A.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B8164D2A.Location = new System.Drawing.Point(0, 3);
		B8164D2A.Name = "pnlHeader";
		B8164D2A.Size = new System.Drawing.Size(359, 31);
		B8164D2A.TabIndex = 9;
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
		EA889415.Cursor = System.Windows.Forms.Cursors.Default;
		EA889415.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		EA889415.Location = new System.Drawing.Point(3, 2);
		EA889415.Name = "pictureBox1";
		EA889415.Size = new System.Drawing.Size(34, 27);
		EA889415.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		EA889415.TabIndex = 76;
		EA889415.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(A49C1403);
		panel1.Controls.Add(ckbChiKetBanTenCoDau);
		panel1.Controls.Add(nudTimesWarning);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(DFA0ABB8);
		panel1.Controls.Add(C3A737B1);
		panel1.Controls.Add(FC24838F);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(D1BBD58F);
		panel1.Controls.Add(label10);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(C4BFB707);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(E888C2B3);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(F51D5CAF);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 191);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(D0012839);
		A49C1403.AutoSize = true;
		A49C1403.Cursor = System.Windows.Forms.Cursors.Hand;
		A49C1403.Location = new System.Drawing.Point(30, 280);
		A49C1403.Name = "ckbOnlyAddFriendWithMutualFriends";
		A49C1403.Size = new System.Drawing.Size(226, 20);
		A49C1403.TabIndex = 47;
		A49C1403.Text = "Chỉ kết bạn với người có bạn chung";
		A49C1403.UseVisualStyleBackColor = true;
		ckbChiKetBanTenCoDau.AutoSize = true;
		ckbChiKetBanTenCoDau.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChiKetBanTenCoDau.Location = new System.Drawing.Point(30, 254);
		ckbChiKetBanTenCoDau.Name = "ckbChiKetBanTenCoDau";
		ckbChiKetBanTenCoDau.Size = new System.Drawing.Size(303, 20);
		ckbChiKetBanTenCoDau.TabIndex = 47;
		ckbChiKetBanTenCoDau.Text = "Chỉ kết bạn với tên có dấu (Kết bạn với nick Việt)";
		ckbChiKetBanTenCoDau.UseVisualStyleBackColor = true;
		nudTimesWarning.Location = new System.Drawing.Point(253, 306);
		nudTimesWarning.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimesWarning.Name = "nudTimesWarning";
		nudTimesWarning.Size = new System.Drawing.Size(43, 23);
		nudTimesWarning.TabIndex = 4;
		nudDelayTo.Location = new System.Drawing.Point(229, 110);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		C3A737B1.Location = new System.Drawing.Point(132, 110);
		C3A737B1.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C3A737B1.Name = "nudDelayFrom";
		C3A737B1.Size = new System.Drawing.Size(56, 23);
		C3A737B1.TabIndex = 3;
		FC24838F.AutoSize = true;
		FC24838F.Location = new System.Drawing.Point(299, 308);
		FC24838F.Name = "label9";
		FC24838F.Size = new System.Drawing.Size(24, 16);
		FC24838F.TabIndex = 45;
		FC24838F.Text = "lần";
		label7.Location = new System.Drawing.Point(194, 112);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D1BBD58F.AutoSize = true;
		D1BBD58F.Location = new System.Drawing.Point(287, 112);
		D1BBD58F.Name = "label6";
		D1BBD58F.Size = new System.Drawing.Size(30, 16);
		D1BBD58F.TabIndex = 45;
		D1BBD58F.Text = "giây";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(27, 308);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(225, 16);
		label8.TabIndex = 44;
		label8.Text = "Dừng khi gặp cảnh báo của Facebook:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 112);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(89, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
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
		C4BFB707.Location = new System.Drawing.Point(132, 49);
		C4BFB707.Name = "txtTenHanhDong";
		C4BFB707.Size = new System.Drawing.Size(194, 23);
		C4BFB707.TabIndex = 0;
		label3.Location = new System.Drawing.Point(194, 83);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E888C2B3.AutoSize = true;
		E888C2B3.Location = new System.Drawing.Point(287, 83);
		E888C2B3.Name = "label4";
		E888C2B3.Size = new System.Drawing.Size(28, 16);
		E888C2B3.TabIndex = 35;
		E888C2B3.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 83);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(88, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		F51D5CAF.AutoSize = true;
		F51D5CAF.Location = new System.Drawing.Point(27, 52);
		F51D5CAF.Name = "label1";
		F51D5CAF.Size = new System.Drawing.Size(98, 16);
		F51D5CAF.TabIndex = 31;
		F51D5CAF.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(187, 149);
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
		btnAdd.Location = new System.Drawing.Point(80, 149);
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
		bunifuCards1.Controls.Add(B8164D2A);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(27, 219);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(101, 16);
		label10.TabIndex = 44;
		label10.Text = "Delay Check (s):";
		DFA0ABB8.Location = new System.Drawing.Point(132, 217);
		DFA0ABB8.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DFA0ABB8.Name = "nudDelayCheck";
		DFA0ABB8.Size = new System.Drawing.Size(56, 23);
		DFA0ABB8.TabIndex = 3;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 191);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanGoiY";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanGoiY_Load);
		B8164D2A.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)EA889415).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudTimesWarning).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)C3A737B1).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)DFA0ABB8).EndInit();
		ResumeLayout(false);
	}
}
