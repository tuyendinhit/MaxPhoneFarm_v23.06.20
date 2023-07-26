using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDVerifyAccount : Form
{
	internal JSON_Settings AF8B10B1;

	internal string EE34A990;

	internal string C48F6031;

	internal string string_0;

	internal int int_0;

	internal static bool bool_0;

	internal List<string> list_0 = new List<string>();

	internal List<string> list_1 = new List<string>();

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl E89FDC90;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel C311DD24;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal ToolTip BEA84183;

	internal Button btnNhapHotmail;

	internal RadioButton rbMailDomain;

	internal RadioButton rbHotmail;

	internal Button AD0745A0;

	public fHDVerifyAccount(string A133FB83, int int_1 = 0, string D6244F3B = "")
	{
		InitializeComponent();
		bool_0 = false;
		EE34A990 = A133FB83;
		string_0 = D6244F3B;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Verify Account";
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
			C48F6031 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(D6244F3B);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		AF8B10B1 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDVerifyAccount_Load(object sender, EventArgs e)
	{
		try
		{
			if (AF8B10B1.method_0("typeMail") == 0)
			{
				rbHotmail.Checked = true;
			}
			else
			{
				rbMailDomain.Checked = true;
			}
			list_0 = AF8B10B1.EC378D8A("lstHotmail");
			Common.DB181F2D(btnNhapHotmail, list_0.Count);
			list_1 = AF8B10B1.EC378D8A("lstMailDomain");
			Common.DB181F2D(AD0745A0, list_1.Count);
		}
		catch
		{
		}
		E7B15B2C(null, null);
		E3860599(null, null);
		method_0(null, null);
		A20A60A0(null, null);
		rbHotmail_CheckedChanged(null, null);
		rbMailDomain_CheckedChanged(null, null);
	}

	private void FA0678BD(object sender, EventArgs e)
	{
		Close();
	}

	private void F7A1762D(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		int num = 0;
		if (rbMailDomain.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeMail", num);
		f72FAFBC.method_3("lstHotmail", list_0);
		f72FAFBC.method_3("lstMailDomain", list_1);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class123.smethod_12(EE34A990, text, C48F6031, text2))
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
			if (Class123.smethod_14(string_0, text, text2))
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

	private void A084AB08(object sender, EventArgs e)
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

	private void E3860599(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void A20A60A0(object sender, EventArgs e)
	{
	}

	private void DA3A39BD(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch hotmail (mail|pass mail)", "Danh sa\u0301ch mail|pass mail", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		list_0 = fNhapDuLieu4.list_0;
		Common.DB181F2D(btnNhapHotmail, list_0.Count);
	}

	private void E7B15B2C(object sender, EventArgs e)
	{
	}

	private void rbHotmail_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapHotmail.Enabled = rbHotmail.Checked;
	}

	private void rbMailDomain_CheckedChanged(object sender, EventArgs e)
	{
		AD0745A0.Enabled = rbMailDomain.Checked;
	}

	private void AD0745A0_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_1, "Nhâ\u0323p danh sa\u0301ch link mail domain", "Danh sa\u0301ch link mail domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
		Common.smethod_16(fNhapDuLieu4);
		list_1 = fNhapDuLieu4.list_0;
		Common.DB181F2D(AD0745A0, list_1.Count);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDVerifyAccount));
		E89FDC90 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		C311DD24 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		rbMailDomain = new System.Windows.Forms.RadioButton();
		rbHotmail = new System.Windows.Forms.RadioButton();
		AD0745A0 = new System.Windows.Forms.Button();
		btnNhapHotmail = new System.Windows.Forms.Button();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		BEA84183 = new System.Windows.Forms.ToolTip(icontainer_0);
		C311DD24.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		E89FDC90.Fixed = true;
		E89FDC90.Horizontal = true;
		E89FDC90.TargetControl = bunifuCustomLabel1;
		E89FDC90.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(352, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Verify Account";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = C311DD24;
		bunifuDragControl_0.Vertical = true;
		C311DD24.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C311DD24.BackColor = System.Drawing.Color.White;
		C311DD24.Controls.Add(button1);
		C311DD24.Controls.Add(pictureBox1);
		C311DD24.Controls.Add(bunifuCustomLabel1);
		C311DD24.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C311DD24.Location = new System.Drawing.Point(0, 3);
		C311DD24.Name = "pnlHeader";
		C311DD24.Size = new System.Drawing.Size(352, 31);
		C311DD24.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(321, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(FA0678BD);
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
		panel1.Controls.Add(rbMailDomain);
		panel1.Controls.Add(rbHotmail);
		panel1.Controls.Add(AD0745A0);
		panel1.Controls.Add(btnNhapHotmail);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(355, 195);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		rbMailDomain.AutoSize = true;
		rbMailDomain.Cursor = System.Windows.Forms.Cursors.Hand;
		rbMailDomain.Location = new System.Drawing.Point(23, 112);
		rbMailDomain.Name = "rbMailDomain";
		rbMailDomain.Size = new System.Drawing.Size(94, 20);
		rbMailDomain.TabIndex = 117;
		rbMailDomain.TabStop = true;
		rbMailDomain.Text = "Mail domain";
		rbMailDomain.UseVisualStyleBackColor = true;
		rbMailDomain.CheckedChanged += new System.EventHandler(rbMailDomain_CheckedChanged);
		rbHotmail.AutoSize = true;
		rbHotmail.Cursor = System.Windows.Forms.Cursors.Hand;
		rbHotmail.Location = new System.Drawing.Point(23, 81);
		rbHotmail.Name = "rbHotmail";
		rbHotmail.Size = new System.Drawing.Size(68, 20);
		rbHotmail.TabIndex = 117;
		rbHotmail.TabStop = true;
		rbHotmail.Text = "Hotmail";
		rbHotmail.UseVisualStyleBackColor = true;
		rbHotmail.CheckedChanged += new System.EventHandler(rbHotmail_CheckedChanged);
		AD0745A0.Cursor = System.Windows.Forms.Cursors.Hand;
		AD0745A0.Location = new System.Drawing.Point(125, 109);
		AD0745A0.Name = "btnNhapMailDomain";
		AD0745A0.Size = new System.Drawing.Size(194, 27);
		AD0745A0.TabIndex = 116;
		AD0745A0.Text = "Nhập (0)";
		AD0745A0.UseVisualStyleBackColor = true;
		AD0745A0.Click += new System.EventHandler(AD0745A0_Click);
		btnNhapHotmail.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapHotmail.Location = new System.Drawing.Point(125, 78);
		btnNhapHotmail.Name = "btnNhapHotmail";
		btnNhapHotmail.Size = new System.Drawing.Size(194, 27);
		btnNhapHotmail.TabIndex = 116;
		btnNhapHotmail.Text = "Nhập (0)";
		btnNhapHotmail.UseVisualStyleBackColor = true;
		btnNhapHotmail.Click += new System.EventHandler(DA3A39BD);
		txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(20, 52);
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
		btnCancel.Location = new System.Drawing.Point(187, 152);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(A084AB08);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(80, 152);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(F7A1762D);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(C311DD24);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(352, 37);
		bunifuCards1.TabIndex = 28;
		BEA84183.AutomaticDelay = 0;
		BEA84183.AutoPopDelay = 0;
		BEA84183.InitialDelay = 0;
		BEA84183.ReshowDelay = 0;
		BEA84183.ShowAlways = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(355, 195);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDVerifyAccount";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDVerifyAccount_Load);
		C311DD24.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
