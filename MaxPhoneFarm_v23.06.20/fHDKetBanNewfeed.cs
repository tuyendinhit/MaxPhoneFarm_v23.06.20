using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanNewfeed : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string E3AE592D;

	internal string string_1;

	internal int int_0;

	internal static bool EEBE79AF;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal NumericUpDown A825F4B1;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox F1AC479E;

	internal Label DC07CF1D;

	internal Label label4;

	internal Label E987E222;

	internal Label F0ADBFB3;

	internal Button D79DDC38;

	internal Button btnAdd;

	internal BunifuCards CF1726AD;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal NumericUpDown F63CCF84;

	internal NumericUpDown nudDelayFrom;

	internal Label label7;

	internal Label label6;

	internal Label label5;

	internal NumericUpDown E481882C;

	internal Label label9;

	internal Label label8;

	public fHDKetBanNewfeed(string A48A25B5, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		EEBE79AF = false;
		string_0 = A48A25B5;
		string_1 = string_2;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDKetBanNewfeed").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanNewfeed', 'Kết bạn Newfeed');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDKetBanNewfeed");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			E3AE592D = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			F1AC479E.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			F1AC479E.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(F0ADBFB3);
		Language.smethod_1(E987E222);
		Language.smethod_1(DC07CF1D);
		Language.smethod_1(label4);
		Language.smethod_1(label5);
		Language.smethod_1(label7);
		Language.smethod_1(label6);
		Language.smethod_1(btnAdd);
		Language.smethod_1(D79DDC38);
	}

	private void fHDKetBanNewfeed_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 3);
			A825F4B1.Value = f72FAFBC_0.method_0("nudSoLuongTo", 5);
			nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			F63CCF84.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			E481882C.Value = f72FAFBC_0.method_0("nudTimesWarning", 3);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void ED806B8B(object sender, EventArgs e)
	{
		string text = F1AC479E.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", A825F4B1.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", F63CCF84.Value);
		f72FAFBC.GetValue("nudTimesWarning", E481882C.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, E3AE592D, text2))
				{
					EEBE79AF = true;
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
				EEBE79AF = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void D79DDC38_Click(object sender, EventArgs e)
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
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		E481882C = new System.Windows.Forms.NumericUpDown();
		F63CCF84 = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		A825F4B1 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		F1AC479E = new System.Windows.Forms.TextBox();
		DC07CF1D = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		E987E222 = new System.Windows.Forms.Label();
		F0ADBFB3 = new System.Windows.Forms.Label();
		D79DDC38 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		CF1726AD = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E481882C).BeginInit();
		((System.ComponentModel.ISupportInitialize)F63CCF84).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)A825F4B1).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		CF1726AD.SuspendLayout();
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
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn Newfeed";
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
		button1.Click += new System.EventHandler(button1_Click);
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
		panel1.Controls.Add(E481882C);
		panel1.Controls.Add(F63CCF84);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(A825F4B1);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(F1AC479E);
		panel1.Controls.Add(DC07CF1D);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(E987E222);
		panel1.Controls.Add(F0ADBFB3);
		panel1.Controls.Add(D79DDC38);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(CF1726AD);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 192);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		E481882C.Location = new System.Drawing.Point(253, 221);
		E481882C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E481882C.Name = "nudTimesWarning";
		E481882C.Size = new System.Drawing.Size(43, 23);
		E481882C.TabIndex = 4;
		F63CCF84.Location = new System.Drawing.Point(229, 112);
		F63CCF84.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F63CCF84.Name = "nudDelayTo";
		F63CCF84.Size = new System.Drawing.Size(56, 23);
		F63CCF84.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(132, 112);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(299, 223);
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
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(290, 114);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(27, 223);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(226, 16);
		label8.TabIndex = 44;
		label8.Text = "Dừng khi gặp cảnh báo của Facebook:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 114);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(90, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		A825F4B1.Location = new System.Drawing.Point(229, 81);
		A825F4B1.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A825F4B1.Name = "nudSoLuongTo";
		A825F4B1.Size = new System.Drawing.Size(56, 23);
		A825F4B1.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 81);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		F1AC479E.Location = new System.Drawing.Point(132, 49);
		F1AC479E.Name = "txtTenHanhDong";
		F1AC479E.Size = new System.Drawing.Size(194, 23);
		F1AC479E.TabIndex = 0;
		DC07CF1D.AutoSize = true;
		DC07CF1D.Location = new System.Drawing.Point(194, 83);
		DC07CF1D.Name = "label3";
		DC07CF1D.Size = new System.Drawing.Size(29, 16);
		DC07CF1D.TabIndex = 37;
		DC07CF1D.Text = "đê\u0301n";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(290, 83);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		E987E222.AutoSize = true;
		E987E222.Location = new System.Drawing.Point(27, 83);
		E987E222.Name = "label2";
		E987E222.Size = new System.Drawing.Size(89, 16);
		E987E222.TabIndex = 32;
		E987E222.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		F0ADBFB3.AutoSize = true;
		F0ADBFB3.Location = new System.Drawing.Point(27, 52);
		F0ADBFB3.Name = "label1";
		F0ADBFB3.Size = new System.Drawing.Size(99, 16);
		F0ADBFB3.TabIndex = 31;
		F0ADBFB3.Text = "Tên ha\u0300nh đô\u0323ng:";
		D79DDC38.BackColor = System.Drawing.Color.Maroon;
		D79DDC38.Cursor = System.Windows.Forms.Cursors.Hand;
		D79DDC38.FlatAppearance.BorderSize = 0;
		D79DDC38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D79DDC38.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D79DDC38.ForeColor = System.Drawing.Color.White;
		D79DDC38.Location = new System.Drawing.Point(191, 148);
		D79DDC38.Name = "btnCancel";
		D79DDC38.Size = new System.Drawing.Size(92, 29);
		D79DDC38.TabIndex = 7;
		D79DDC38.Text = "Đóng";
		D79DDC38.UseVisualStyleBackColor = false;
		D79DDC38.Click += new System.EventHandler(D79DDC38_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(84, 148);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(ED806B8B);
		CF1726AD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CF1726AD.BackColor = System.Drawing.Color.White;
		CF1726AD.BorderRadius = 0;
		CF1726AD.BottomSahddow = true;
		CF1726AD.color = System.Drawing.Color.DarkViolet;
		CF1726AD.Controls.Add(pnlHeader);
		CF1726AD.LeftSahddow = false;
		CF1726AD.Location = new System.Drawing.Point(1, 0);
		CF1726AD.Name = "bunifuCards1";
		CF1726AD.RightSahddow = true;
		CF1726AD.ShadowDepth = 20;
		CF1726AD.Size = new System.Drawing.Size(359, 37);
		CF1726AD.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 192);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanNewfeed";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDKetBanNewfeed_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)E481882C).EndInit();
		((System.ComponentModel.ISupportInitialize)F63CCF84).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)A825F4B1).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		CF1726AD.ResumeLayout(false);
		ResumeLayout(false);
	}
}
