using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacBaiVietIA : Form
{
	internal JSON_Settings C78CD01D;

	internal string string_0;

	internal string string_1;

	internal string D03EF023;

	internal int int_0;

	internal static bool FA290E84;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl A522192F;

	internal BunifuDragControl EF14CC38;

	internal Panel E0BAD78E;

	internal TextBox BF37551A;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal PictureBox B12B9692;

	internal BunifuCustomLabel A125AA2E;

	internal Button EB9DED21;

	internal Label lblUid;

	internal Label label15;

	internal Label F308B638;

	internal TextBox E723D323;

	internal Label label7;

	internal Label label4;

	internal Label C1BA1F1E;

	internal NumericUpDown nudThoiGianLuotTo;

	internal NumericUpDown nudThoiGianLuotFrom;

	internal Label label3;

	internal NumericUpDown F991AAB5;

	internal NumericUpDown A2BB952C;

	internal Panel plTuongTacQuangCao;

	internal RichTextBox txtNoiDungTinNhan;

	internal Label label2;

	internal CheckBox ckbTuongTacQuangCao;

	public fHDTuongTacBaiVietIA(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		FA290E84 = false;
		string_0 = string_2;
		D03EF023 = string_3;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDTuongTacBaiVietIA").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBaiVietIA', 'Tương tác ba\u0300i viê\u0301t IA');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDTuongTacBaiVietIA");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			BF37551A.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = "Câ\u0323p nhâ\u0323t";
			BF37551A.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		C78CD01D = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void F6AA0F88()
	{
		Language.smethod_1(A125AA2E);
		Language.smethod_1(label1);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
		Language.smethod_1(lblUid);
		Language.smethod_1(label3);
	}

	private void FA27480F(object sender, EventArgs e)
	{
		try
		{
			E723D323.Text = C78CD01D.GetValue("txtIdPage");
			F991AAB5.Value = C78CD01D.method_0("nudSoLuongBaiFrom", 1);
			A2BB952C.Value = C78CD01D.method_0("nudSoLuongBaiTo", 3);
			nudThoiGianLuotFrom.Value = C78CD01D.method_0("nudThoiGianLuotFrom", 30);
			nudThoiGianLuotTo.Value = C78CD01D.method_0("nudThoiGianLuotTo", 30);
		}
		catch
		{
		}
		AA25CA1D();
	}

	private void EB9DED21_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = BF37551A.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtIdPage", (object)E723D323.Text.Trim());
		f72FAFBC.GetValue("nudSoLuongBaiFrom", F991AAB5.Value);
		f72FAFBC.GetValue("nudSoLuongBaiTo", A2BB952C.Value);
		f72FAFBC.GetValue("nudThoiGianLuotFrom", nudThoiGianLuotFrom.Value);
		f72FAFBC.GetValue("nudThoiGianLuotTo", nudThoiGianLuotTo.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text2))
				{
					FA290E84 = true;
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
			if (Class123.smethod_14(D03EF023, text, text2))
			{
				FA290E84 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FE0342AF(object sender, PaintEventArgs e)
	{
		if (E0BAD78E.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, E0BAD78E.ClientSize.Width - num, E0BAD78E.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1()
	{
	}

	private void AA25CA1D()
	{
		method_2(null, null);
		B9A405B1(null, null);
		ckbTuongTacQuangCao_CheckedChanged(null, null);
	}

	private void B9A405B1(object sender, EventArgs e)
	{
	}

	private void CC862310(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
		}
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void ckbTuongTacQuangCao_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTacQuangCao.Enabled = ckbTuongTacQuangCao.Checked;
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
		A522192F = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		A125AA2E = new Bunifu.Framework.UI.BunifuCustomLabel();
		EF14CC38 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		EB9DED21 = new System.Windows.Forms.Button();
		B12B9692 = new System.Windows.Forms.PictureBox();
		E0BAD78E = new System.Windows.Forms.Panel();
		plTuongTacQuangCao = new System.Windows.Forms.Panel();
		txtNoiDungTinNhan = new System.Windows.Forms.RichTextBox();
		label2 = new System.Windows.Forms.Label();
		ckbTuongTacQuangCao = new System.Windows.Forms.CheckBox();
		lblUid = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		F308B638 = new System.Windows.Forms.Label();
		E723D323 = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		C1BA1F1E = new System.Windows.Forms.Label();
		nudThoiGianLuotTo = new System.Windows.Forms.NumericUpDown();
		nudThoiGianLuotFrom = new System.Windows.Forms.NumericUpDown();
		label3 = new System.Windows.Forms.Label();
		F991AAB5 = new System.Windows.Forms.NumericUpDown();
		A2BB952C = new System.Windows.Forms.NumericUpDown();
		BF37551A = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B12B9692).BeginInit();
		E0BAD78E.SuspendLayout();
		plTuongTacQuangCao.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudThoiGianLuotTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudThoiGianLuotFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)F991AAB5).BeginInit();
		((System.ComponentModel.ISupportInitialize)A2BB952C).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		A522192F.Fixed = true;
		A522192F.Horizontal = true;
		A522192F.TargetControl = A125AA2E;
		A522192F.Vertical = true;
		A125AA2E.BackColor = System.Drawing.Color.Transparent;
		A125AA2E.Cursor = System.Windows.Forms.Cursors.SizeAll;
		A125AA2E.Dock = System.Windows.Forms.DockStyle.Fill;
		A125AA2E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A125AA2E.ForeColor = System.Drawing.Color.Black;
		A125AA2E.Location = new System.Drawing.Point(0, 0);
		A125AA2E.Name = "bunifuCustomLabel1";
		A125AA2E.Size = new System.Drawing.Size(352, 31);
		A125AA2E.TabIndex = 12;
		A125AA2E.Text = "Cấu hình Tương tác ba\u0300i viê\u0301t IA";
		A125AA2E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		EF14CC38.Fixed = true;
		EF14CC38.Horizontal = true;
		EF14CC38.TargetControl = pnlHeader;
		EF14CC38.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(EB9DED21);
		pnlHeader.Controls.Add(B12B9692);
		pnlHeader.Controls.Add(A125AA2E);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(352, 31);
		pnlHeader.TabIndex = 9;
		EB9DED21.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		EB9DED21.Cursor = System.Windows.Forms.Cursors.Hand;
		EB9DED21.FlatAppearance.BorderSize = 0;
		EB9DED21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EB9DED21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EB9DED21.ForeColor = System.Drawing.Color.White;
		EB9DED21.Image = Resource.Bitmap_9;
		EB9DED21.Location = new System.Drawing.Point(319, 0);
		EB9DED21.Name = "btnMinimize";
		EB9DED21.Size = new System.Drawing.Size(32, 32);
		EB9DED21.TabIndex = 78;
		EB9DED21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		EB9DED21.UseVisualStyleBackColor = true;
		EB9DED21.Click += new System.EventHandler(EB9DED21_Click);
		B12B9692.Cursor = System.Windows.Forms.Cursors.Default;
		B12B9692.Image = Resource.AC35C73C;
		B12B9692.Location = new System.Drawing.Point(3, 2);
		B12B9692.Name = "pictureBox1";
		B12B9692.Size = new System.Drawing.Size(34, 27);
		B12B9692.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B12B9692.TabIndex = 76;
		B12B9692.TabStop = false;
		B12B9692.Click += new System.EventHandler(CC862310);
		E0BAD78E.BackColor = System.Drawing.Color.White;
		E0BAD78E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E0BAD78E.Controls.Add(plTuongTacQuangCao);
		E0BAD78E.Controls.Add(ckbTuongTacQuangCao);
		E0BAD78E.Controls.Add(lblUid);
		E0BAD78E.Controls.Add(label15);
		E0BAD78E.Controls.Add(F308B638);
		E0BAD78E.Controls.Add(E723D323);
		E0BAD78E.Controls.Add(label7);
		E0BAD78E.Controls.Add(label4);
		E0BAD78E.Controls.Add(C1BA1F1E);
		E0BAD78E.Controls.Add(nudThoiGianLuotTo);
		E0BAD78E.Controls.Add(nudThoiGianLuotFrom);
		E0BAD78E.Controls.Add(label3);
		E0BAD78E.Controls.Add(F991AAB5);
		E0BAD78E.Controls.Add(A2BB952C);
		E0BAD78E.Controls.Add(BF37551A);
		E0BAD78E.Controls.Add(label1);
		E0BAD78E.Controls.Add(btnCancel);
		E0BAD78E.Controls.Add(btnAdd);
		E0BAD78E.Controls.Add(bunifuCards1);
		E0BAD78E.Cursor = System.Windows.Forms.Cursors.Arrow;
		E0BAD78E.Dock = System.Windows.Forms.DockStyle.Fill;
		E0BAD78E.Location = new System.Drawing.Point(0, 0);
		E0BAD78E.Name = "panel1";
		E0BAD78E.Size = new System.Drawing.Size(355, 222);
		E0BAD78E.TabIndex = 0;
		E0BAD78E.Paint += new System.Windows.Forms.PaintEventHandler(FE0342AF);
		plTuongTacQuangCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuongTacQuangCao.Controls.Add(txtNoiDungTinNhan);
		plTuongTacQuangCao.Controls.Add(label2);
		plTuongTacQuangCao.Location = new System.Drawing.Point(24, 241);
		plTuongTacQuangCao.Name = "plTuongTacQuangCao";
		plTuongTacQuangCao.Size = new System.Drawing.Size(305, 103);
		plTuongTacQuangCao.TabIndex = 142;
		plTuongTacQuangCao.Visible = false;
		txtNoiDungTinNhan.Location = new System.Drawing.Point(7, 24);
		txtNoiDungTinNhan.Name = "txtNoiDungTinNhan";
		txtNoiDungTinNhan.Size = new System.Drawing.Size(292, 73);
		txtNoiDungTinNhan.TabIndex = 1;
		txtNoiDungTinNhan.Text = "";
		txtNoiDungTinNhan.WordWrap = false;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(4, 4);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(166, 16);
		label2.TabIndex = 0;
		label2.Text = "Nhâ\u0323p nô\u0323i dung tin nhă\u0301n (0):";
		ckbTuongTacQuangCao.AutoSize = true;
		ckbTuongTacQuangCao.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuongTacQuangCao.Location = new System.Drawing.Point(24, 219);
		ckbTuongTacQuangCao.Name = "ckbTuongTacQuangCao";
		ckbTuongTacQuangCao.Size = new System.Drawing.Size(247, 20);
		ckbTuongTacQuangCao.TabIndex = 141;
		ckbTuongTacQuangCao.Text = "Tư\u0323 đô\u0323ng tương ta\u0301c qua\u0309ng ca\u0301o (să\u0301p co\u0301)";
		ckbTuongTacQuangCao.UseVisualStyleBackColor = true;
		ckbTuongTacQuangCao.Visible = false;
		ckbTuongTacQuangCao.CheckedChanged += new System.EventHandler(ckbTuongTacQuangCao_CheckedChanged);
		lblUid.AutoSize = true;
		lblUid.Location = new System.Drawing.Point(21, 81);
		lblUid.Name = "lblUid";
		lblUid.Size = new System.Drawing.Size(57, 16);
		lblUid.TabIndex = 140;
		lblUid.Text = "ID Page:";
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(21, 138);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(114, 16);
		label15.TabIndex = 134;
		label15.Text = "Thơ\u0300i gian lươ\u0301t/ba\u0300i:";
		F308B638.AutoSize = true;
		F308B638.Location = new System.Drawing.Point(21, 109);
		F308B638.Name = "label5";
		F308B638.Size = new System.Drawing.Size(109, 16);
		F308B638.TabIndex = 135;
		F308B638.Text = "Sô\u0301 lươ\u0323ng ba\u0300i viê\u0301t:";
		E723D323.Location = new System.Drawing.Point(141, 78);
		E723D323.Name = "txtIdPage";
		E723D323.Size = new System.Drawing.Size(188, 23);
		E723D323.TabIndex = 127;
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(299, 138);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(31, 16);
		label7.TabIndex = 136;
		label7.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(299, 109);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(25, 16);
		label4.TabIndex = 137;
		label4.Text = "ba\u0300i";
		C1BA1F1E.Location = new System.Drawing.Point(203, 138);
		C1BA1F1E.Name = "label6";
		C1BA1F1E.Size = new System.Drawing.Size(29, 16);
		C1BA1F1E.TabIndex = 138;
		C1BA1F1E.Text = "đê\u0301n";
		C1BA1F1E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudThoiGianLuotTo.Location = new System.Drawing.Point(238, 136);
		nudThoiGianLuotTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudThoiGianLuotTo.Name = "nudThoiGianLuotTo";
		nudThoiGianLuotTo.Size = new System.Drawing.Size(56, 23);
		nudThoiGianLuotTo.TabIndex = 132;
		nudThoiGianLuotFrom.Location = new System.Drawing.Point(141, 136);
		nudThoiGianLuotFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudThoiGianLuotFrom.Name = "nudThoiGianLuotFrom";
		nudThoiGianLuotFrom.Size = new System.Drawing.Size(56, 23);
		nudThoiGianLuotFrom.TabIndex = 130;
		label3.Location = new System.Drawing.Point(203, 109);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 139;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F991AAB5.Location = new System.Drawing.Point(141, 107);
		F991AAB5.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F991AAB5.Name = "nudSoLuongBaiFrom";
		F991AAB5.Size = new System.Drawing.Size(56, 23);
		F991AAB5.TabIndex = 131;
		A2BB952C.Location = new System.Drawing.Point(238, 107);
		A2BB952C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A2BB952C.Name = "nudSoLuongBaiTo";
		A2BB952C.Size = new System.Drawing.Size(56, 23);
		A2BB952C.TabIndex = 133;
		BF37551A.Location = new System.Drawing.Point(141, 49);
		BF37551A.Name = "txtTenHanhDong";
		BF37551A.Size = new System.Drawing.Size(188, 23);
		BF37551A.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(21, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(180, 176);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
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
		btnAdd.Location = new System.Drawing.Point(78, 176);
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
		bunifuCards1.Size = new System.Drawing.Size(352, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(355, 222);
		base.Controls.Add(E0BAD78E);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacBaiVietIA";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(FA27480F);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)B12B9692).EndInit();
		E0BAD78E.ResumeLayout(false);
		E0BAD78E.PerformLayout();
		plTuongTacQuangCao.ResumeLayout(false);
		plTuongTacQuangCao.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudThoiGianLuotTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudThoiGianLuotFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)F991AAB5).EndInit();
		((System.ComponentModel.ISupportInitialize)A2BB952C).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
