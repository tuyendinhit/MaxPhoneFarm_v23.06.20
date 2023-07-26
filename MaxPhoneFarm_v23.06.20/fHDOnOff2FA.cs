using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDOnOff2FA : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string A5852AA9;

	internal string D9017C95;

	internal string string_0;

	internal int A388F917;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel A33868AD;

	internal TextBox txtTenHanhDong;

	internal Label C91674A6;

	internal Button btnCancel;

	internal Button E4347CA7;

	internal BunifuCards bunifuCards1;

	internal Panel BBA72113;

	internal Button BFB4AF83;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel EA2E810D;

	internal RadioButton rbBat2FA;

	internal RadioButton rbTat2FA;

	internal Panel DDBBFF9D;

	internal RadioButton rbXoa2FACu;

	internal RadioButton rbGiu2FACu;

	internal RadioButton F12647B1;

	internal Label F5092432;

	public fHDOnOff2FA(string string_1, int F707641F = 0, string A3BAFE19 = "")
	{
		InitializeComponent();
		bool_0 = false;
		A5852AA9 = string_1;
		string_0 = A3BAFE19;
		A388F917 = F707641F;
		string text = base.Name.Substring(1);
		string text2 = "Bật - Tắt 2FA";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (F707641F)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			D9017C95 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(A3BAFE19);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			E4347CA7.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void E4025496()
	{
		Language.smethod_1(EA2E810D);
		Language.smethod_1(C91674A6);
		Language.smethod_1(rbTat2FA);
		Language.smethod_1(rbBat2FA);
		Language.smethod_1(E4347CA7);
		Language.smethod_1(btnCancel);
	}

	private void fHDOnOff2FA_Load(object sender, EventArgs e)
	{
		try
		{
			if (f72FAFBC_0.method_0("typeOnOff2FA") == 0)
			{
				rbTat2FA.Checked = true;
			}
			else
			{
				rbBat2FA.Checked = true;
			}
			if (f72FAFBC_0.method_0("neuDaCo2FA") == 0)
			{
				F12647B1.Checked = true;
			}
			else if (f72FAFBC_0.method_0("neuDaCo2FA") == 1)
			{
				rbGiu2FACu.Checked = true;
			}
			else
			{
				rbXoa2FACu.Checked = true;
			}
			BD17492E(null, null);
			EEBC2D92(null, null);
		}
		catch
		{
		}
	}

	private void BFB4AF83_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A3B4243C(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		if (rbTat2FA.Checked)
		{
			f72FAFBC.GetValue("typeOnOff2FA", 0);
		}
		else
		{
			f72FAFBC.GetValue("typeOnOff2FA", 1);
		}
		if (F12647B1.Checked)
		{
			f72FAFBC.GetValue("neuDaCo2FA", 0);
		}
		else if (rbGiu2FACu.Checked)
		{
			f72FAFBC.GetValue("neuDaCo2FA", 1);
		}
		else
		{
			f72FAFBC.GetValue("neuDaCo2FA", 2);
		}
		string text2 = f72FAFBC.C71A4EA4();
		if (A388F917 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(A5852AA9, text, D9017C95, text2))
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
			if (Class123.smethod_14(string_0, text, text2))
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

	private void A33868AD_Paint(object sender, PaintEventArgs e)
	{
		if (A33868AD.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A33868AD.ClientSize.Width - num, A33868AD.ClientSize.Height - num));
		}
	}

	private void BD17492E(object sender, EventArgs e)
	{
	}

	private void EEBC2D92(object sender, EventArgs e)
	{
		DDBBFF9D.Enabled = rbBat2FA.Checked;
	}

	protected override void Dispose(bool AE1D9586)
	{
		if (AE1D9586 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(AE1D9586);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDOnOff2FA));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		EA2E810D = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		BBA72113 = new System.Windows.Forms.Panel();
		BFB4AF83 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		A33868AD = new System.Windows.Forms.Panel();
		rbBat2FA = new System.Windows.Forms.RadioButton();
		rbTat2FA = new System.Windows.Forms.RadioButton();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		C91674A6 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		E4347CA7 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		DDBBFF9D = new System.Windows.Forms.Panel();
		F5092432 = new System.Windows.Forms.Label();
		F12647B1 = new System.Windows.Forms.RadioButton();
		rbGiu2FACu = new System.Windows.Forms.RadioButton();
		rbXoa2FACu = new System.Windows.Forms.RadioButton();
		BBA72113.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		A33868AD.SuspendLayout();
		bunifuCards1.SuspendLayout();
		DDBBFF9D.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = EA2E810D;
		bunifuDragControl_0.Vertical = true;
		EA2E810D.BackColor = System.Drawing.Color.Transparent;
		EA2E810D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		EA2E810D.Dock = System.Windows.Forms.DockStyle.Fill;
		EA2E810D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EA2E810D.ForeColor = System.Drawing.Color.Black;
		EA2E810D.Location = new System.Drawing.Point(0, 0);
		EA2E810D.Name = "bunifuCustomLabel1";
		EA2E810D.Size = new System.Drawing.Size(358, 31);
		EA2E810D.TabIndex = 12;
		EA2E810D.Text = "Cấu hình Bật - Tắt 2FA";
		EA2E810D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = BBA72113;
		bunifuDragControl_1.Vertical = true;
		BBA72113.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		BBA72113.BackColor = System.Drawing.Color.White;
		BBA72113.Controls.Add(BFB4AF83);
		BBA72113.Controls.Add(pictureBox1);
		BBA72113.Controls.Add(EA2E810D);
		BBA72113.Cursor = System.Windows.Forms.Cursors.SizeAll;
		BBA72113.Location = new System.Drawing.Point(0, 3);
		BBA72113.Name = "pnlHeader";
		BBA72113.Size = new System.Drawing.Size(358, 31);
		BBA72113.TabIndex = 9;
		BFB4AF83.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		BFB4AF83.Cursor = System.Windows.Forms.Cursors.Hand;
		BFB4AF83.FlatAppearance.BorderSize = 0;
		BFB4AF83.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BFB4AF83.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BFB4AF83.ForeColor = System.Drawing.Color.White;
		BFB4AF83.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		BFB4AF83.Location = new System.Drawing.Point(327, 1);
		BFB4AF83.Name = "button1";
		BFB4AF83.Size = new System.Drawing.Size(30, 30);
		BFB4AF83.TabIndex = 77;
		BFB4AF83.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		BFB4AF83.UseVisualStyleBackColor = true;
		BFB4AF83.Click += new System.EventHandler(BFB4AF83_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		A33868AD.BackColor = System.Drawing.Color.White;
		A33868AD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A33868AD.Controls.Add(DDBBFF9D);
		A33868AD.Controls.Add(rbBat2FA);
		A33868AD.Controls.Add(rbTat2FA);
		A33868AD.Controls.Add(txtTenHanhDong);
		A33868AD.Controls.Add(C91674A6);
		A33868AD.Controls.Add(btnCancel);
		A33868AD.Controls.Add(E4347CA7);
		A33868AD.Controls.Add(bunifuCards1);
		A33868AD.Cursor = System.Windows.Forms.Cursors.Arrow;
		A33868AD.Dock = System.Windows.Forms.DockStyle.Fill;
		A33868AD.Location = new System.Drawing.Point(0, 0);
		A33868AD.Name = "panel1";
		A33868AD.Size = new System.Drawing.Size(361, 263);
		A33868AD.TabIndex = 0;
		A33868AD.Paint += new System.Windows.Forms.PaintEventHandler(A33868AD_Paint);
		rbBat2FA.AutoSize = true;
		rbBat2FA.Cursor = System.Windows.Forms.Cursors.Hand;
		rbBat2FA.Location = new System.Drawing.Point(30, 105);
		rbBat2FA.Name = "rbBat2FA";
		rbBat2FA.Size = new System.Drawing.Size(69, 20);
		rbBat2FA.TabIndex = 47;
		rbBat2FA.Text = "Bật 2FA";
		rbBat2FA.UseVisualStyleBackColor = true;
		rbBat2FA.CheckedChanged += new System.EventHandler(EEBC2D92);
		rbTat2FA.AutoSize = true;
		rbTat2FA.Checked = true;
		rbTat2FA.Cursor = System.Windows.Forms.Cursors.Hand;
		rbTat2FA.Location = new System.Drawing.Point(29, 81);
		rbTat2FA.Name = "rbTat2FA";
		rbTat2FA.Size = new System.Drawing.Size(70, 20);
		rbTat2FA.TabIndex = 47;
		rbTat2FA.TabStop = true;
		rbTat2FA.Text = "Tắt 2FA";
		rbTat2FA.UseVisualStyleBackColor = true;
		txtTenHanhDong.Location = new System.Drawing.Point(131, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(204, 23);
		txtTenHanhDong.TabIndex = 0;
		C91674A6.AutoSize = true;
		C91674A6.Location = new System.Drawing.Point(26, 52);
		C91674A6.Name = "label1";
		C91674A6.Size = new System.Drawing.Size(98, 16);
		C91674A6.TabIndex = 31;
		C91674A6.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(187, 218);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		E4347CA7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E4347CA7.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		E4347CA7.Cursor = System.Windows.Forms.Cursors.Hand;
		E4347CA7.FlatAppearance.BorderSize = 0;
		E4347CA7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E4347CA7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E4347CA7.ForeColor = System.Drawing.Color.White;
		E4347CA7.Location = new System.Drawing.Point(80, 218);
		E4347CA7.Name = "btnAdd";
		E4347CA7.Size = new System.Drawing.Size(92, 29);
		E4347CA7.TabIndex = 6;
		E4347CA7.Text = "Thêm";
		E4347CA7.UseVisualStyleBackColor = false;
		E4347CA7.Click += new System.EventHandler(A3B4243C);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(BBA72113);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(358, 37);
		bunifuCards1.TabIndex = 28;
		DDBBFF9D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		DDBBFF9D.Controls.Add(rbXoa2FACu);
		DDBBFF9D.Controls.Add(rbGiu2FACu);
		DDBBFF9D.Controls.Add(F12647B1);
		DDBBFF9D.Controls.Add(F5092432);
		DDBBFF9D.Location = new System.Drawing.Point(131, 105);
		DDBBFF9D.Name = "plBat2FA";
		DDBBFF9D.Size = new System.Drawing.Size(204, 97);
		DDBBFF9D.TabIndex = 48;
		F5092432.AutoSize = true;
		F5092432.Location = new System.Drawing.Point(3, 2);
		F5092432.Name = "label2";
		F5092432.Size = new System.Drawing.Size(169, 16);
		F5092432.TabIndex = 31;
		F5092432.Text = "Nếu tài khoản đã có 2FA thì:";
		F12647B1.AutoSize = true;
		F12647B1.Cursor = System.Windows.Forms.Cursors.Hand;
		F12647B1.Location = new System.Drawing.Point(6, 22);
		F12647B1.Name = "rbKhongBat2FA";
		F12647B1.Size = new System.Drawing.Size(134, 20);
		F12647B1.TabIndex = 32;
		F12647B1.TabStop = true;
		F12647B1.Text = "Không bật 2FA nữa";
		F12647B1.UseVisualStyleBackColor = true;
		rbGiu2FACu.AutoSize = true;
		rbGiu2FACu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbGiu2FACu.Location = new System.Drawing.Point(6, 47);
		rbGiu2FACu.Name = "rbGiu2FACu";
		rbGiu2FACu.Size = new System.Drawing.Size(188, 20);
		rbGiu2FACu.TabIndex = 33;
		rbGiu2FACu.TabStop = true;
		rbGiu2FACu.Text = "Giữ 2FA cũ và thêm 2FA mới";
		rbGiu2FACu.UseVisualStyleBackColor = true;
		rbXoa2FACu.AutoSize = true;
		rbXoa2FACu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbXoa2FACu.Location = new System.Drawing.Point(6, 72);
		rbXoa2FACu.Name = "rbXoa2FACu";
		rbXoa2FACu.Size = new System.Drawing.Size(193, 20);
		rbXoa2FACu.TabIndex = 34;
		rbXoa2FACu.TabStop = true;
		rbXoa2FACu.Text = "Xóa 2FA cũ rồi thêm 2FA mới";
		rbXoa2FACu.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(361, 263);
		base.Controls.Add(A33868AD);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDOnOff2FA";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDOnOff2FA_Load);
		BBA72113.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		A33868AD.ResumeLayout(false);
		A33868AD.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		DDBBFF9D.ResumeLayout(false);
		DDBBFF9D.PerformLayout();
		ResumeLayout(false);
	}
}
