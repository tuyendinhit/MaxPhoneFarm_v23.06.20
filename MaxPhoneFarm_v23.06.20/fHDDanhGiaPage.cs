using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDanhGiaPage : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string EA2A3F36;

	internal int E11B369E;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl EA0EC60B;

	internal Panel panel1;

	internal TextBox D8A8C018;

	internal Label BF03098C;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel F4AF75B3;

	internal Label lblStatus;

	internal CheckBox ckbInteract;

	internal RichTextBox B39CFE01;

	internal Button D807D70F;

	internal Label lblUid;

	internal TextBox txtUid;

	internal CheckBox C110E416;

	internal Button button3;

	internal Button button2;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton B4034928;

	internal Label label9;

	public fHDDanhGiaPage(string string_2, int E09B2BB8 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		EA2A3F36 = string_3;
		E11B369E = E09B2BB8;
		if (Class123.C7BE863B("", "HDDanhGiaPage").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDDanhGiaPage', 'Đánh giá Page');");
		}
		string d399C = "";
		switch (E09B2BB8)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDDanhGiaPage");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			D8A8C018.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			D8A8C018.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDDanhGiaPage_Load(object sender, EventArgs e)
	{
		try
		{
			txtUid.Text = f72FAFBC_0.GetValue("txtUid");
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			B39CFE01.Text = f72FAFBC_0.GetValue("txtComment");
			if (f72FAFBC_0.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				B4034928.Checked = true;
			}
			C110E416.Checked = f72FAFBC_0.AA824D29("ckbTuDongXoaNoiDung");
		}
		catch
		{
		}
		method_0();
	}

	private void D807D70F_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = D8A8C018.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> f1808BA = B39CFE01.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung đánh giá!", 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtUid", (object)txtUid.Text.Trim());
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		f72FAFBC.GetValue("txtComment", (object)B39CFE01.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		f72FAFBC.GetValue("ckbTuDongXoaNoiDung", C110E416.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (E11B369E == 0)
		{
			if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text2))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class123.smethod_14(EA2A3F36, text, text2))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void FABBA7A3(object sender, EventArgs e)
	{
		Close();
	}

	private void CC0F0735(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void B39CFE01_TextChanged(object sender, EventArgs e)
	{
		int b5968D3F = ((!B4034928.Checked) ? 1 : 0);
		Common.D936DD84(B39CFE01, lblStatus, b5968D3F);
	}

	private void method_0()
	{
		ckbInteract_CheckedChanged(null, null);
		D6213829(null, null);
		method_1(null, null);
	}

	private void D6213829(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		B39CFE01.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		B39CFE01.Focus();
	}

	private void B4034928_CheckedChanged(object sender, EventArgs e)
	{
		int b5968D3F = ((!B4034928.Checked) ? 1 : 0);
		Common.D936DD84(B39CFE01, lblStatus, b5968D3F);
	}

	private void CF0DAEA2(object sender, EventArgs e)
	{
		int b5968D3F = ((!B4034928.Checked) ? 1 : 0);
		Common.D936DD84(B39CFE01, lblStatus, b5968D3F);
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
		F4AF75B3 = new Bunifu.Framework.UI.BunifuCustomLabel();
		EA0EC60B = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		D807D70F = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		button3 = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		B4034928 = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		C110E416 = new System.Windows.Forms.CheckBox();
		B39CFE01 = new System.Windows.Forms.RichTextBox();
		txtUid = new System.Windows.Forms.TextBox();
		lblStatus = new System.Windows.Forms.Label();
		ckbInteract = new System.Windows.Forms.CheckBox();
		lblUid = new System.Windows.Forms.Label();
		D8A8C018 = new System.Windows.Forms.TextBox();
		BF03098C = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = F4AF75B3;
		bunifuDragControl_0.Vertical = true;
		F4AF75B3.BackColor = System.Drawing.Color.Transparent;
		F4AF75B3.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F4AF75B3.Dock = System.Windows.Forms.DockStyle.Fill;
		F4AF75B3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F4AF75B3.ForeColor = System.Drawing.Color.Black;
		F4AF75B3.Location = new System.Drawing.Point(0, 0);
		F4AF75B3.Name = "bunifuCustomLabel1";
		F4AF75B3.Size = new System.Drawing.Size(343, 31);
		F4AF75B3.TabIndex = 12;
		F4AF75B3.Text = "Cấu hình Đánh giá Page";
		F4AF75B3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		EA0EC60B.Fixed = true;
		EA0EC60B.Horizontal = true;
		EA0EC60B.TargetControl = pnlHeader;
		EA0EC60B.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(D807D70F);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(F4AF75B3);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(343, 31);
		pnlHeader.TabIndex = 9;
		D807D70F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		D807D70F.Cursor = System.Windows.Forms.Cursors.Hand;
		D807D70F.FlatAppearance.BorderSize = 0;
		D807D70F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D807D70F.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D807D70F.ForeColor = System.Drawing.Color.White;
		D807D70F.Image = Resource.Bitmap_9;
		D807D70F.Location = new System.Drawing.Point(310, 0);
		D807D70F.Name = "btnMinimize";
		D807D70F.Size = new System.Drawing.Size(32, 32);
		D807D70F.TabIndex = 78;
		D807D70F.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		D807D70F.UseVisualStyleBackColor = true;
		D807D70F.Click += new System.EventHandler(D807D70F_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(button3);
		panel1.Controls.Add(button2);
		panel1.Controls.Add(rbNganCachKyTu);
		panel1.Controls.Add(B4034928);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(C110E416);
		panel1.Controls.Add(B39CFE01);
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(lblUid);
		panel1.Controls.Add(D8A8C018);
		panel1.Controls.Add(BF03098C);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(346, 387);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(CC0F0735);
		button3.Cursor = System.Windows.Forms.Cursors.Help;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(245, 286);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(21, 23);
		button3.TabIndex = 134;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(245, 263);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 23);
		button2.TabIndex = 135;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(86, 286);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		rbNganCachKyTu.TabIndex = 132;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(CF0DAEA2);
		B4034928.AutoSize = true;
		B4034928.Checked = true;
		B4034928.Cursor = System.Windows.Forms.Cursors.Hand;
		B4034928.Location = new System.Drawing.Point(86, 265);
		B4034928.Name = "rbNganCachMoiDong";
		B4034928.Size = new System.Drawing.Size(155, 20);
		B4034928.TabIndex = 133;
		B4034928.TabStop = true;
		B4034928.Text = "Nội dung chỉ có 1 dòng";
		B4034928.UseVisualStyleBackColor = true;
		B4034928.CheckedChanged += new System.EventHandler(B4034928_CheckedChanged);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(21, 265);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(64, 16);
		label9.TabIndex = 131;
		label9.Text = "Tùy chọn:";
		C110E416.AutoSize = true;
		C110E416.Cursor = System.Windows.Forms.Cursors.Hand;
		C110E416.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C110E416.Location = new System.Drawing.Point(24, 312);
		C110E416.Name = "ckbTuDongXoaNoiDung";
		C110E416.Size = new System.Drawing.Size(219, 20);
		C110E416.TabIndex = 130;
		C110E416.Text = "Tư\u0323 đô\u0323ng xo\u0301a nô\u0323i dung đa\u0303 sư\u0309 du\u0323ng";
		C110E416.UseVisualStyleBackColor = true;
		B39CFE01.Location = new System.Drawing.Point(25, 150);
		B39CFE01.Name = "txtComment";
		B39CFE01.Size = new System.Drawing.Size(295, 111);
		B39CFE01.TabIndex = 106;
		B39CFE01.Text = "";
		B39CFE01.WordWrap = false;
		B39CFE01.TextChanged += new System.EventHandler(B39CFE01_TextChanged);
		txtUid.Location = new System.Drawing.Point(132, 78);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(188, 23);
		txtUid.TabIndex = 129;
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(21, 130);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(136, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung đánh giá (0):";
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(24, 105);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(80, 20);
		ckbInteract.TabIndex = 7;
		ckbInteract.Text = "Like page";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		lblUid.AutoSize = true;
		lblUid.Location = new System.Drawing.Point(21, 81);
		lblUid.Name = "lblUid";
		lblUid.Size = new System.Drawing.Size(55, 16);
		lblUid.TabIndex = 126;
		lblUid.Text = "Id Page:";
		D8A8C018.Location = new System.Drawing.Point(132, 49);
		D8A8C018.Name = "txtTenHanhDong";
		D8A8C018.Size = new System.Drawing.Size(188, 23);
		D8A8C018.TabIndex = 0;
		BF03098C.AutoSize = true;
		BF03098C.Location = new System.Drawing.Point(21, 52);
		BF03098C.Name = "label1";
		BF03098C.Size = new System.Drawing.Size(98, 16);
		BF03098C.TabIndex = 31;
		BF03098C.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(177, 345);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(FABBA7A3);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(79, 345);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 11;
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
		bunifuCards1.Size = new System.Drawing.Size(343, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(346, 387);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDanhGiaPage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDanhGiaPage_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
