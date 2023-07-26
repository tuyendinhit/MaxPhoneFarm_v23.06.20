using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDUpAvatar : Form
{
	internal JSON_Settings f72FAFBC_0 = null;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int F7357588;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl E72D023A;

	internal BunifuDragControl F336A0B1;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label label5;

	internal Label D1829B3A;

	internal Button B2B68E2D;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel D5A0E09D;

	internal TextBox txtPathFolder;

	internal CheckBox ckbXoaAnhDaDung;

	public fHDUpAvatar(string string_3, int int_0 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		F7357588 = int_0;
		string text = "HDUpAvatar";
		string text2 = "Up avatar";
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
			DataTable dataTable = Class123.smethod_10(string_4);
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
		Language.smethod_1(D5A0E09D);
		Language.smethod_1(D1829B3A);
		Language.smethod_1(label5);
		Language.smethod_1(btnAdd);
		Language.smethod_1(B2B68E2D);
	}

	private void fHDUpAvatar_Load(object sender, EventArgs e)
	{
		try
		{
			txtPathFolder.Text = f72FAFBC_0.GetValue("txtPathFolder");
			ckbXoaAnhDaDung.Checked = f72FAFBC_0.AA824D29("ckbXoaAnhDaDung");
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
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		_ = txtPathFolder.Text;
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtPathFolder", (object)txtPathFolder.Text);
		f72FAFBC.GetValue("ckbXoaAnhDaDung", ckbXoaAnhDaDung.Checked);
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (F7357588 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, d9253C2E))
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
			if (Class123.smethod_14(string_2, text, d9253C2E))
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

	private void ACBEF692(object sender, EventArgs e)
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

	private void BABBFD29(object sender, EventArgs e)
	{
		string text = E3A31B0C.smethod_2();
		string text2 = "avatar_";
		if (string_2 == "")
		{
			string_2 = (Class123.A3A46880() + 1).ToString() ?? "";
		}
		text2 += string_2;
		Common.CreateFolder(text + "\\" + text2);
		Process.Start(text + "\\" + text2);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDUpAvatar));
		E72D023A = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D5A0E09D = new Bunifu.Framework.UI.BunifuCustomLabel();
		F336A0B1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		ckbXoaAnhDaDung = new System.Windows.Forms.CheckBox();
		txtPathFolder = new System.Windows.Forms.TextBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label5 = new System.Windows.Forms.Label();
		D1829B3A = new System.Windows.Forms.Label();
		B2B68E2D = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		E72D023A.Fixed = true;
		E72D023A.Horizontal = true;
		E72D023A.TargetControl = D5A0E09D;
		E72D023A.Vertical = true;
		D5A0E09D.BackColor = System.Drawing.Color.Transparent;
		D5A0E09D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D5A0E09D.Dock = System.Windows.Forms.DockStyle.Fill;
		D5A0E09D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D5A0E09D.ForeColor = System.Drawing.Color.Black;
		D5A0E09D.Location = new System.Drawing.Point(0, 0);
		D5A0E09D.Name = "bunifuCustomLabel1";
		D5A0E09D.Size = new System.Drawing.Size(359, 31);
		D5A0E09D.TabIndex = 12;
		D5A0E09D.Text = "Cấu hình Up Avatar";
		D5A0E09D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F336A0B1.Fixed = true;
		F336A0B1.Horizontal = true;
		F336A0B1.TargetControl = pnlHeader;
		F336A0B1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(D5A0E09D);
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
		panel1.Controls.Add(ckbXoaAnhDaDung);
		panel1.Controls.Add(txtPathFolder);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(D1829B3A);
		panel1.Controls.Add(B2B68E2D);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 182);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		ckbXoaAnhDaDung.AutoSize = true;
		ckbXoaAnhDaDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaAnhDaDung.Location = new System.Drawing.Point(132, 108);
		ckbXoaAnhDaDung.Name = "ckbXoaAnhDaDung";
		ckbXoaAnhDaDung.Size = new System.Drawing.Size(174, 20);
		ckbXoaAnhDaDung.TabIndex = 35;
		ckbXoaAnhDaDung.Text = "Tự động xóa ảnh đã dùng";
		ckbXoaAnhDaDung.UseVisualStyleBackColor = true;
		txtPathFolder.Location = new System.Drawing.Point(132, 79);
		txtPathFolder.Name = "txtPathFolder";
		txtPathFolder.Size = new System.Drawing.Size(194, 23);
		txtPathFolder.TabIndex = 0;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 82);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(74, 16);
		label5.TabIndex = 34;
		label5.Text = "Folder ảnh:";
		D1829B3A.AutoSize = true;
		D1829B3A.Location = new System.Drawing.Point(27, 52);
		D1829B3A.Name = "label1";
		D1829B3A.Size = new System.Drawing.Size(99, 16);
		D1829B3A.TabIndex = 31;
		D1829B3A.Text = "Tên ha\u0300nh đô\u0323ng:";
		B2B68E2D.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B2B68E2D.BackColor = System.Drawing.Color.Maroon;
		B2B68E2D.Cursor = System.Windows.Forms.Cursors.Hand;
		B2B68E2D.FlatAppearance.BorderSize = 0;
		B2B68E2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B2B68E2D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B2B68E2D.ForeColor = System.Drawing.Color.White;
		B2B68E2D.Location = new System.Drawing.Point(189, 137);
		B2B68E2D.Name = "btnCancel";
		B2B68E2D.Size = new System.Drawing.Size(92, 29);
		B2B68E2D.TabIndex = 10;
		B2B68E2D.Text = "Đóng";
		B2B68E2D.UseVisualStyleBackColor = false;
		B2B68E2D.Click += new System.EventHandler(ACBEF692);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 137);
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
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 182);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDUpAvatar";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDUpAvatar_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
