using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDoiTen : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int int_0;

	internal static bool bool_0;

	internal List<string> B3233F91 = new List<string>();

	internal List<string> list_0 = new List<string>();

	internal List<string> list_1 = new List<string>();

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl C52167AA;

	internal Panel A18B8922;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel E31158AA;

	internal Button button1;

	internal PictureBox CA09732E;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel EB16A51C;

	internal Button E92FAC35;

	internal Button button7;

	internal Button E1018D3C;

	internal RadioButton rdTenTuDat;

	internal RadioButton rdTenRandom;

	internal Panel CBA7C20B;

	internal RadioButton DB3142A7;

	internal RadioButton rdTenRandomViet;

	public fHDDoiTen(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đổi tên";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (int_1)
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

	private void A490B10D()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void fHDDoiTen_Load(object sender, EventArgs e)
	{
		try
		{
			if (f72FAFBC_0.method_0("typeDatTen") == 0)
			{
				rdTenRandom.Checked = true;
			}
			else
			{
				rdTenTuDat.Checked = true;
			}
			if (f72FAFBC_0.method_0("typeTenRandom") == 0)
			{
				rdTenRandomViet.Checked = true;
			}
			else
			{
				DB3142A7.Checked = true;
			}
			B3233F91 = f72FAFBC_0.EC378D8A("lstHo");
			list_0 = f72FAFBC_0.EC378D8A("lstTenDem");
			list_1 = f72FAFBC_0.EC378D8A("lstTen");
			rdTenTuDat_CheckedChanged(null, null);
			rdTenRandom_CheckedChanged(null, null);
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
		JSON_Settings f72FAFBC = new JSON_Settings();
		int num = 0;
		if (rdTenTuDat.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeDatTen", num);
		int num2 = 0;
		if (DB3142A7.Checked)
		{
			num2 = 1;
		}
		f72FAFBC.GetValue("typeTenRandom", num2);
		f72FAFBC.method_3("lstHo", B3233F91);
		f72FAFBC.method_3("lstTenDem", list_0);
		f72FAFBC.method_3("lstTen", list_1);
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
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

	private void BA909619(object sender, EventArgs e)
	{
		Close();
	}

	private void A18B8922_Paint(object sender, PaintEventArgs e)
	{
		if (A18B8922.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A18B8922.ClientSize.Width - num, A18B8922.ClientSize.Height - num));
		}
	}

	private void rdTenTuDat_CheckedChanged(object sender, EventArgs e)
	{
		EB16A51C.Enabled = rdTenTuDat.Checked;
	}

	private void rdTenRandom_CheckedChanged(object sender, EventArgs e)
	{
		CBA7C20B.Enabled = rdTenRandom.Checked;
	}

	private void AC343D2C(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(B3233F91, "Nhâ\u0323p danh sa\u0301ch Họ", "Danh sa\u0301ch Họ", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		B3233F91 = fNhapDuLieu4.list_0;
	}

	private void button7_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch Tên đệm", "Danh sa\u0301ch Tên đệm", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		list_0 = fNhapDuLieu4.list_0;
	}

	private void E92FAC35_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_1, "Nhâ\u0323p danh sa\u0301ch Tên", "Danh sa\u0301ch Tên", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		list_1 = fNhapDuLieu4.list_0;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDoiTen));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		C52167AA = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		E31158AA = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		CA09732E = new System.Windows.Forms.PictureBox();
		A18B8922 = new System.Windows.Forms.Panel();
		EB16A51C = new System.Windows.Forms.Panel();
		E92FAC35 = new System.Windows.Forms.Button();
		button7 = new System.Windows.Forms.Button();
		E1018D3C = new System.Windows.Forms.Button();
		rdTenTuDat = new System.Windows.Forms.RadioButton();
		rdTenRandom = new System.Windows.Forms.RadioButton();
		CBA7C20B = new System.Windows.Forms.Panel();
		DB3142A7 = new System.Windows.Forms.RadioButton();
		rdTenRandomViet = new System.Windows.Forms.RadioButton();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		E31158AA.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)CA09732E).BeginInit();
		A18B8922.SuspendLayout();
		EB16A51C.SuspendLayout();
		CBA7C20B.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(320, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đổi tên";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C52167AA.Fixed = true;
		C52167AA.Horizontal = true;
		C52167AA.TargetControl = E31158AA;
		C52167AA.Vertical = true;
		E31158AA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E31158AA.BackColor = System.Drawing.Color.White;
		E31158AA.Controls.Add(button1);
		E31158AA.Controls.Add(CA09732E);
		E31158AA.Controls.Add(bunifuCustomLabel1);
		E31158AA.Cursor = System.Windows.Forms.Cursors.SizeAll;
		E31158AA.Location = new System.Drawing.Point(0, 3);
		E31158AA.Name = "pnlHeader";
		E31158AA.Size = new System.Drawing.Size(320, 31);
		E31158AA.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(289, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		CA09732E.Cursor = System.Windows.Forms.Cursors.Default;
		CA09732E.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		CA09732E.Location = new System.Drawing.Point(3, 2);
		CA09732E.Name = "pictureBox1";
		CA09732E.Size = new System.Drawing.Size(34, 27);
		CA09732E.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		CA09732E.TabIndex = 76;
		CA09732E.TabStop = false;
		A18B8922.BackColor = System.Drawing.Color.White;
		A18B8922.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A18B8922.Controls.Add(EB16A51C);
		A18B8922.Controls.Add(rdTenTuDat);
		A18B8922.Controls.Add(rdTenRandom);
		A18B8922.Controls.Add(CBA7C20B);
		A18B8922.Controls.Add(txtTenHanhDong);
		A18B8922.Controls.Add(label1);
		A18B8922.Controls.Add(btnCancel);
		A18B8922.Controls.Add(btnAdd);
		A18B8922.Controls.Add(bunifuCards1);
		A18B8922.Cursor = System.Windows.Forms.Cursors.Arrow;
		A18B8922.Dock = System.Windows.Forms.DockStyle.Fill;
		A18B8922.Location = new System.Drawing.Point(0, 0);
		A18B8922.Name = "panel1";
		A18B8922.Size = new System.Drawing.Size(323, 238);
		A18B8922.TabIndex = 0;
		A18B8922.Paint += new System.Windows.Forms.PaintEventHandler(A18B8922_Paint);
		EB16A51C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EB16A51C.Controls.Add(E92FAC35);
		EB16A51C.Controls.Add(button7);
		EB16A51C.Controls.Add(E1018D3C);
		EB16A51C.Location = new System.Drawing.Point(44, 150);
		EB16A51C.Name = "plTenTuDat";
		EB16A51C.Size = new System.Drawing.Size(240, 29);
		EB16A51C.TabIndex = 136;
		E92FAC35.Cursor = System.Windows.Forms.Cursors.Hand;
		E92FAC35.Location = new System.Drawing.Point(171, 0);
		E92FAC35.Name = "button8";
		E92FAC35.Size = new System.Drawing.Size(67, 27);
		E92FAC35.TabIndex = 124;
		E92FAC35.Text = "Nhập tên";
		E92FAC35.UseVisualStyleBackColor = true;
		E92FAC35.Click += new System.EventHandler(E92FAC35_Click);
		button7.Cursor = System.Windows.Forms.Cursors.Hand;
		button7.Location = new System.Drawing.Point(69, 0);
		button7.Name = "button7";
		button7.Size = new System.Drawing.Size(96, 27);
		button7.TabIndex = 124;
		button7.Text = "Nhập tên đệm";
		button7.UseVisualStyleBackColor = true;
		button7.Click += new System.EventHandler(button7_Click);
		E1018D3C.Cursor = System.Windows.Forms.Cursors.Hand;
		E1018D3C.Location = new System.Drawing.Point(0, 0);
		E1018D3C.Name = "button6";
		E1018D3C.Size = new System.Drawing.Size(63, 27);
		E1018D3C.TabIndex = 124;
		E1018D3C.Text = "Nhập họ";
		E1018D3C.UseVisualStyleBackColor = true;
		E1018D3C.Click += new System.EventHandler(AC343D2C);
		rdTenTuDat.AutoSize = true;
		rdTenTuDat.Checked = true;
		rdTenTuDat.Cursor = System.Windows.Forms.Cursors.Hand;
		rdTenTuDat.Location = new System.Drawing.Point(29, 127);
		rdTenTuDat.Name = "rdTenTuDat";
		rdTenTuDat.Size = new System.Drawing.Size(155, 20);
		rdTenTuDat.TabIndex = 138;
		rdTenTuDat.TabStop = true;
		rdTenTuDat.Text = "Tên do người dùng đặt";
		rdTenTuDat.UseVisualStyleBackColor = true;
		rdTenTuDat.CheckedChanged += new System.EventHandler(rdTenTuDat_CheckedChanged);
		rdTenRandom.AutoSize = true;
		rdTenRandom.Cursor = System.Windows.Forms.Cursors.Hand;
		rdTenRandom.Location = new System.Drawing.Point(29, 78);
		rdTenRandom.Name = "rdTenRandom";
		rdTenRandom.Size = new System.Drawing.Size(114, 20);
		rdTenRandom.TabIndex = 137;
		rdTenRandom.Text = "Tên ngẫu nhiên";
		rdTenRandom.UseVisualStyleBackColor = true;
		rdTenRandom.CheckedChanged += new System.EventHandler(rdTenRandom_CheckedChanged);
		CBA7C20B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		CBA7C20B.Controls.Add(DB3142A7);
		CBA7C20B.Controls.Add(rdTenRandomViet);
		CBA7C20B.Location = new System.Drawing.Point(44, 98);
		CBA7C20B.Name = "plTenNgauNhien";
		CBA7C20B.Size = new System.Drawing.Size(240, 25);
		CBA7C20B.TabIndex = 139;
		DB3142A7.AutoSize = true;
		DB3142A7.Cursor = System.Windows.Forms.Cursors.Hand;
		DB3142A7.Location = new System.Drawing.Point(80, 1);
		DB3142A7.Name = "rdTenRandomNgoai";
		DB3142A7.Size = new System.Drawing.Size(82, 20);
		DB3142A7.TabIndex = 134;
		DB3142A7.Text = "Tên ngoại";
		DB3142A7.UseVisualStyleBackColor = true;
		rdTenRandomViet.AutoSize = true;
		rdTenRandomViet.Checked = true;
		rdTenRandomViet.Cursor = System.Windows.Forms.Cursors.Hand;
		rdTenRandomViet.Location = new System.Drawing.Point(2, 1);
		rdTenRandomViet.Name = "rdTenRandomViet";
		rdTenRandomViet.Size = new System.Drawing.Size(71, 20);
		rdTenRandomViet.TabIndex = 134;
		rdTenRandomViet.TabStop = true;
		rdTenRandomViet.Text = "Tên việt";
		rdTenRandomViet.UseVisualStyleBackColor = true;
		txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(159, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(26, 52);
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
		btnCancel.Location = new System.Drawing.Point(168, 193);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(BA909619);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(61, 193);
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
		bunifuCards1.Controls.Add(E31158AA);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(320, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(323, 238);
		base.Controls.Add(A18B8922);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDoiTen";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDoiTen_Load);
		E31158AA.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)CA09732E).EndInit();
		A18B8922.ResumeLayout(false);
		A18B8922.PerformLayout();
		EB16A51C.ResumeLayout(false);
		CBA7C20B.ResumeLayout(false);
		CBA7C20B.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
