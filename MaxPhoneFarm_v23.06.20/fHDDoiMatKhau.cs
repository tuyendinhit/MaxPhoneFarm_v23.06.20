using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDoiMatKhau : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int int_0;

	internal static bool bool_0;

	internal List<string> A124F824 = new List<string>();

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl AB8F0182;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button A11EA82A;

	internal PictureBox B9804D95;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal RadioButton A12E5D8C;

	internal RadioButton rbMatKhauRandom;

	internal Label C0158C1B;

	internal NumericUpDown C7305F2C;

	internal Label label3;

	internal Label D336BD19;

	internal Button E696E605;

	internal Button btnNhapMatKhau;

	internal CheckBox B197EAA2;

	public fHDDoiMatKhau(string string_3, int EA2C78B9 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = EA2C78B9;
		string text = base.Name.Substring(1);
		string text2 = "Đô\u0309i mâ\u0323t khâ\u0309u";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (EA2C78B9)
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

	private void A40D6D94()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(C0158C1B);
		Language.smethod_1(rbMatKhauRandom);
		Language.smethod_1(A12E5D8C);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void C4802CB9(object sender, EventArgs e)
	{
		try
		{
			if (f72FAFBC_0.method_0("typeMatKhau") == 0)
			{
				rbMatKhauRandom.Checked = true;
			}
			else
			{
				A12E5D8C.Checked = true;
			}
			A124F824 = f72FAFBC_0.EC378D8A("txtMatKhau");
			Common.DB181F2D(btnNhapMatKhau, A124F824.Count);
			C7305F2C.Value = f72FAFBC_0.method_0("nudTimeOut", 30);
			B197EAA2.Checked = f72FAFBC_0.AA824D29("ckbDangXuatThietBiCu");
			method_0(null, null);
			A12E5D8C_CheckedChanged(null, null);
		}
		catch
		{
		}
	}

	private void A11EA82A_Click(object sender, EventArgs e)
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
		if (rbMatKhauRandom.Checked)
		{
			f72FAFBC.GetValue("typeMatKhau", 0);
		}
		else
		{
			f72FAFBC.GetValue("typeMatKhau", 1);
		}
		f72FAFBC.method_3("txtMatKhau", A124F824);
		f72FAFBC.GetValue("nudTimeOut", C7305F2C.Value);
		f72FAFBC.GetValue("ckbDangXuatThietBiCu", B197EAA2.Checked);
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
	}

	private void A12E5D8C_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapMatKhau.Enabled = A12E5D8C.Checked;
		btnNhapMatKhau.Enabled = A12E5D8C.Checked;
	}

	private void E696E605_Click(object sender, EventArgs e)
	{
		string cF0CF = "Có thể sử dụng ký tự * để random 1 ký tự ngẫu nhiên!\r\nVí dụ: MIN****** => MINdfghta";
		MessageBoxHelper.Show(Language.GetValue(cF0CF));
	}

	private void CDA4733D(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(A124F824, "Nhâ\u0323p danh sa\u0301ch mật khẩu", "Danh sa\u0301ch Mật khẩu", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		A124F824 = fNhapDuLieu4.list_0;
		Common.DB181F2D(btnNhapMatKhau, A124F824.Count);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDoiMatKhau));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		AB8F0182 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		A11EA82A = new System.Windows.Forms.Button();
		B9804D95 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		btnNhapMatKhau = new System.Windows.Forms.Button();
		E696E605 = new System.Windows.Forms.Button();
		C7305F2C = new System.Windows.Forms.NumericUpDown();
		A12E5D8C = new System.Windows.Forms.RadioButton();
		rbMatKhauRandom = new System.Windows.Forms.RadioButton();
		label3 = new System.Windows.Forms.Label();
		D336BD19 = new System.Windows.Forms.Label();
		C0158C1B = new System.Windows.Forms.Label();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		B197EAA2 = new System.Windows.Forms.CheckBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B9804D95).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C7305F2C).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(331, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đô\u0309i mâ\u0323t khâ\u0309u";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		AB8F0182.Fixed = true;
		AB8F0182.Horizontal = true;
		AB8F0182.TargetControl = pnlHeader;
		AB8F0182.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(A11EA82A);
		pnlHeader.Controls.Add(B9804D95);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(331, 31);
		pnlHeader.TabIndex = 9;
		A11EA82A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		A11EA82A.Cursor = System.Windows.Forms.Cursors.Hand;
		A11EA82A.FlatAppearance.BorderSize = 0;
		A11EA82A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A11EA82A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A11EA82A.ForeColor = System.Drawing.Color.White;
		A11EA82A.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		A11EA82A.Location = new System.Drawing.Point(300, 1);
		A11EA82A.Name = "button1";
		A11EA82A.Size = new System.Drawing.Size(30, 30);
		A11EA82A.TabIndex = 77;
		A11EA82A.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		A11EA82A.UseVisualStyleBackColor = true;
		A11EA82A.Click += new System.EventHandler(A11EA82A_Click);
		B9804D95.Cursor = System.Windows.Forms.Cursors.Default;
		B9804D95.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		B9804D95.Location = new System.Drawing.Point(3, 2);
		B9804D95.Name = "pictureBox1";
		B9804D95.Size = new System.Drawing.Size(34, 27);
		B9804D95.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B9804D95.TabIndex = 76;
		B9804D95.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(B197EAA2);
		panel1.Controls.Add(btnNhapMatKhau);
		panel1.Controls.Add(E696E605);
		panel1.Controls.Add(C7305F2C);
		panel1.Controls.Add(A12E5D8C);
		panel1.Controls.Add(rbMatKhauRandom);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(D336BD19);
		panel1.Controls.Add(C0158C1B);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(334, 226);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		btnNhapMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapMatKhau.Location = new System.Drawing.Point(174, 116);
		btnNhapMatKhau.Name = "btnNhapMatKhau";
		btnNhapMatKhau.Size = new System.Drawing.Size(87, 27);
		btnNhapMatKhau.TabIndex = 51;
		btnNhapMatKhau.Text = "Nhập (0)";
		btnNhapMatKhau.UseVisualStyleBackColor = true;
		btnNhapMatKhau.Click += new System.EventHandler(CDA4733D);
		E696E605.Cursor = System.Windows.Forms.Cursors.Help;
		E696E605.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E696E605.Location = new System.Drawing.Point(265, 116);
		E696E605.Name = "button2";
		E696E605.Size = new System.Drawing.Size(28, 27);
		E696E605.TabIndex = 50;
		E696E605.Text = "?";
		E696E605.UseVisualStyleBackColor = true;
		E696E605.Click += new System.EventHandler(E696E605_Click);
		C7305F2C.Location = new System.Drawing.Point(174, 256);
		C7305F2C.Maximum = new decimal(new int[4] { -727379969, 232, 0, 0 });
		C7305F2C.Name = "nudTimeOut";
		C7305F2C.Size = new System.Drawing.Size(87, 23);
		C7305F2C.TabIndex = 49;
		A12E5D8C.AutoSize = true;
		A12E5D8C.Cursor = System.Windows.Forms.Cursors.Hand;
		A12E5D8C.Location = new System.Drawing.Point(44, 119);
		A12E5D8C.Name = "rbMatKhauChiDinh";
		A12E5D8C.Size = new System.Drawing.Size(130, 20);
		A12E5D8C.TabIndex = 47;
		A12E5D8C.Text = "Mâ\u0323t khâ\u0309u chi\u0309 đi\u0323nh:";
		A12E5D8C.UseVisualStyleBackColor = true;
		A12E5D8C.CheckedChanged += new System.EventHandler(A12E5D8C_CheckedChanged);
		rbMatKhauRandom.AutoSize = true;
		rbMatKhauRandom.Checked = true;
		rbMatKhauRandom.Cursor = System.Windows.Forms.Cursors.Hand;
		rbMatKhauRandom.Location = new System.Drawing.Point(44, 96);
		rbMatKhauRandom.Name = "rbMatKhauRandom";
		rbMatKhauRandom.Size = new System.Drawing.Size(89, 20);
		rbMatKhauRandom.TabIndex = 47;
		rbMatKhauRandom.TabStop = true;
		rbMatKhauRandom.Text = "Ngẫu nhiên";
		rbMatKhauRandom.UseVisualStyleBackColor = true;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(263, 258);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(30, 16);
		label3.TabIndex = 44;
		label3.Text = "giây";
		D336BD19.AutoSize = true;
		D336BD19.Location = new System.Drawing.Point(27, 258);
		D336BD19.Name = "label2";
		D336BD19.Size = new System.Drawing.Size(140, 16);
		D336BD19.TabIndex = 44;
		D336BD19.Text = "Thơ\u0300i gian chơ\u0300 đô\u0309i pass:";
		C0158C1B.AutoSize = true;
		C0158C1B.Location = new System.Drawing.Point(27, 76);
		C0158C1B.Name = "label8";
		C0158C1B.Size = new System.Drawing.Size(146, 16);
		C0158C1B.TabIndex = 44;
		C0158C1B.Text = "Tùy chọn mâ\u0323t khâ\u0309u mơ\u0301i:";
		txtTenHanhDong.Location = new System.Drawing.Point(131, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(162, 23);
		txtTenHanhDong.TabIndex = 0;
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
		btnCancel.Location = new System.Drawing.Point(174, 184);
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
		btnAdd.Location = new System.Drawing.Point(67, 184);
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
		bunifuCards1.Size = new System.Drawing.Size(331, 37);
		bunifuCards1.TabIndex = 28;
		B197EAA2.AutoSize = true;
		B197EAA2.Cursor = System.Windows.Forms.Cursors.Hand;
		B197EAA2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B197EAA2.Location = new System.Drawing.Point(30, 149);
		B197EAA2.Name = "ckbDangXuatThietBiCu";
		B197EAA2.Size = new System.Drawing.Size(144, 20);
		B197EAA2.TabIndex = 114;
		B197EAA2.Text = "Đăng xuất thiết bị cũ";
		B197EAA2.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(334, 226);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDoiMatKhau";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(C4802CB9);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)B9804D95).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C7305F2C).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
