using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDUpCover : Form
{
	internal JSON_Settings f72FAFBC_0 = null;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int C71D9023;

	internal static bool bool_0;

	internal IContainer C386BB23 = null;

	internal BunifuDragControl BF2900A6;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label A39E1D2A;

	internal Label label1;

	internal Button DC8E7B98;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel F3AA6FB6;

	internal Button B2B1AB0E;

	internal PictureBox DAA628B1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal TextBox A3ADED0A;

	internal CheckBox ckbXoaAnhDaDung;

	public fHDUpCover(string B32106B2, int int_0 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = B32106B2;
		string_2 = string_3;
		C71D9023 = int_0;
		string text = "HDUpCover";
		string text2 = "Up cover";
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
		Language.smethod_1(A39E1D2A);
		Language.smethod_1(btnAdd);
		Language.smethod_1(DC8E7B98);
	}

	private void B393793C(object sender, EventArgs e)
	{
		try
		{
			A3ADED0A.Text = f72FAFBC_0.GetValue("txtPathFolder");
			ckbXoaAnhDaDung.Checked = f72FAFBC_0.AA824D29("ckbXoaAnhDaDung");
		}
		catch
		{
		}
	}

	private void B0931632(object sender, EventArgs e)
	{
		Close();
	}

	private void F500B1B0(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtPathFolder", (object)A3ADED0A.Text);
		f72FAFBC.GetValue("ckbXoaAnhDaDung", ckbXoaAnhDaDung.Checked);
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (C71D9023 == 0)
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

	private void DD0F320D(object sender, EventArgs e)
	{
		Close();
	}

	private void E3B24CBD(object sender, PaintEventArgs e)
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
		if (CA1BA01F && C386BB23 != null)
		{
			C386BB23.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		C386BB23 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDUpCover));
		BF2900A6 = new Bunifu.Framework.UI.BunifuDragControl(C386BB23);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(C386BB23);
		F3AA6FB6 = new System.Windows.Forms.Panel();
		B2B1AB0E = new System.Windows.Forms.Button();
		DAA628B1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		ckbXoaAnhDaDung = new System.Windows.Forms.CheckBox();
		A3ADED0A = new System.Windows.Forms.TextBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		A39E1D2A = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		DC8E7B98 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		F3AA6FB6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DAA628B1).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		BF2900A6.Fixed = true;
		BF2900A6.Horizontal = true;
		BF2900A6.TargetControl = bunifuCustomLabel1;
		BF2900A6.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Up Cover";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = F3AA6FB6;
		bunifuDragControl_0.Vertical = true;
		F3AA6FB6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F3AA6FB6.BackColor = System.Drawing.Color.White;
		F3AA6FB6.Controls.Add(B2B1AB0E);
		F3AA6FB6.Controls.Add(DAA628B1);
		F3AA6FB6.Controls.Add(bunifuCustomLabel1);
		F3AA6FB6.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F3AA6FB6.Location = new System.Drawing.Point(0, 3);
		F3AA6FB6.Name = "pnlHeader";
		F3AA6FB6.Size = new System.Drawing.Size(359, 31);
		F3AA6FB6.TabIndex = 9;
		B2B1AB0E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B2B1AB0E.Cursor = System.Windows.Forms.Cursors.Hand;
		B2B1AB0E.FlatAppearance.BorderSize = 0;
		B2B1AB0E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B2B1AB0E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B2B1AB0E.ForeColor = System.Drawing.Color.White;
		B2B1AB0E.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		B2B1AB0E.Location = new System.Drawing.Point(328, 1);
		B2B1AB0E.Name = "button1";
		B2B1AB0E.Size = new System.Drawing.Size(30, 30);
		B2B1AB0E.TabIndex = 77;
		B2B1AB0E.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B2B1AB0E.UseVisualStyleBackColor = true;
		B2B1AB0E.Click += new System.EventHandler(B0931632);
		DAA628B1.Cursor = System.Windows.Forms.Cursors.Default;
		DAA628B1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		DAA628B1.Location = new System.Drawing.Point(3, 2);
		DAA628B1.Name = "pictureBox1";
		DAA628B1.Size = new System.Drawing.Size(34, 27);
		DAA628B1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		DAA628B1.TabIndex = 76;
		DAA628B1.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(ckbXoaAnhDaDung);
		panel1.Controls.Add(A3ADED0A);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(A39E1D2A);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(DC8E7B98);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 180);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(E3B24CBD);
		ckbXoaAnhDaDung.AutoSize = true;
		ckbXoaAnhDaDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbXoaAnhDaDung.Location = new System.Drawing.Point(132, 108);
		ckbXoaAnhDaDung.Name = "ckbXoaAnhDaDung";
		ckbXoaAnhDaDung.Size = new System.Drawing.Size(173, 20);
		ckbXoaAnhDaDung.TabIndex = 36;
		ckbXoaAnhDaDung.Text = "Tự động xóa ảnh đã dùng";
		ckbXoaAnhDaDung.UseVisualStyleBackColor = true;
		A3ADED0A.Location = new System.Drawing.Point(132, 79);
		A3ADED0A.Name = "txtPathFolder";
		A3ADED0A.Size = new System.Drawing.Size(194, 23);
		A3ADED0A.TabIndex = 0;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		A39E1D2A.AutoSize = true;
		A39E1D2A.Location = new System.Drawing.Point(27, 82);
		A39E1D2A.Name = "label5";
		A39E1D2A.Size = new System.Drawing.Size(73, 16);
		A39E1D2A.TabIndex = 34;
		A39E1D2A.Text = "Folder ảnh:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		DC8E7B98.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		DC8E7B98.BackColor = System.Drawing.Color.Maroon;
		DC8E7B98.Cursor = System.Windows.Forms.Cursors.Hand;
		DC8E7B98.FlatAppearance.BorderSize = 0;
		DC8E7B98.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DC8E7B98.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DC8E7B98.ForeColor = System.Drawing.Color.White;
		DC8E7B98.Location = new System.Drawing.Point(189, 136);
		DC8E7B98.Name = "btnCancel";
		DC8E7B98.Size = new System.Drawing.Size(92, 29);
		DC8E7B98.TabIndex = 10;
		DC8E7B98.Text = "Đóng";
		DC8E7B98.UseVisualStyleBackColor = false;
		DC8E7B98.Click += new System.EventHandler(DD0F320D);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 136);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(F500B1B0);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(F3AA6FB6);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 180);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDUpCover";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B393793C);
		F3AA6FB6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)DAA628B1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
