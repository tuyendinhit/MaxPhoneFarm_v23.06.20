using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKetBanVoiBanBeCuaUid : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string F306A186;

	internal string string_0;

	internal string B22A85A8;

	internal int int_0;

	internal static bool AF9A8D9B;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl ED895D35;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox txtTenHanhDong;

	internal Label label3;

	internal Label label4;

	internal Label label2;

	internal Label A794EC31;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel CA89929D;

	internal Button EC8FB69E;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label label8;

	internal Label lblStatus;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown E9848624;

	internal Label label7;

	internal Label label6;

	internal Label label5;

	internal RichTextBox txtUid;

	internal ToolTip toolTip_0;

	public fHDKetBanVoiBanBeCuaUid(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		AF9A8D9B = false;
		F306A186 = string_1;
		B22A85A8 = string_2;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDKetBanVoiBanBeCuaUid").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDKetBanVoiBanBeCuaUid', 'Kết bạn với bạn bè của Uid');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDKetBanVoiBanBeCuaUid");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
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
		Language.smethod_1(A794EC31);
		Language.smethod_1(label2);
		Language.smethod_1(label3);
		Language.smethod_1(label4);
		Language.smethod_1(label5);
		Language.smethod_1(label7);
		Language.smethod_1(label6);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void B809C1BD(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = f72FAFBC_0.method_0("nudSoLuongTo", 5);
			E9848624.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			txtUid.Text = f72FAFBC_0.GetValue("txtUid");
		}
		catch
		{
		}
	}

	private void EC8FB69E_Click(object sender, EventArgs e)
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
		List<string> f1808BA = txtUid.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sách uid!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", E9848624.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("txtUid", (object)txtUid.Text.Trim());
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(F306A186, text, string_0, text2))
				{
					AF9A8D9B = true;
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
			if (Class123.smethod_14(B22A85A8, text, text2))
			{
				AF9A8D9B = true;
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

	private void DA235A12(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUid.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanVoiBanBeCuaUid));
		ED895D35 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		CA89929D = new System.Windows.Forms.Panel();
		EC8FB69E = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		txtUid = new System.Windows.Forms.RichTextBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		E9848624 = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		A794EC31 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		CA89929D.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)E9848624).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		ED895D35.Fixed = true;
		ED895D35.Horizontal = true;
		ED895D35.TargetControl = bunifuCustomLabel1;
		ED895D35.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Kết bạn với bạn bè của Uid";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = CA89929D;
		bunifuDragControl_0.Vertical = true;
		CA89929D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CA89929D.BackColor = System.Drawing.Color.White;
		CA89929D.Controls.Add(EC8FB69E);
		CA89929D.Controls.Add(pictureBox1);
		CA89929D.Controls.Add(bunifuCustomLabel1);
		CA89929D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CA89929D.Location = new System.Drawing.Point(0, 3);
		CA89929D.Name = "pnlHeader";
		CA89929D.Size = new System.Drawing.Size(359, 31);
		CA89929D.TabIndex = 9;
		EC8FB69E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		EC8FB69E.Cursor = System.Windows.Forms.Cursors.Hand;
		EC8FB69E.FlatAppearance.BorderSize = 0;
		EC8FB69E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EC8FB69E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EC8FB69E.ForeColor = System.Drawing.Color.White;
		EC8FB69E.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		EC8FB69E.Location = new System.Drawing.Point(328, 1);
		EC8FB69E.Name = "button1";
		EC8FB69E.Size = new System.Drawing.Size(30, 30);
		EC8FB69E.TabIndex = 77;
		EC8FB69E.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		EC8FB69E.UseVisualStyleBackColor = true;
		EC8FB69E.Click += new System.EventHandler(EC8FB69E_Click);
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
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(E9848624);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(A794EC31);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 374);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(DA235A12);
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(31, 159);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(295, 136);
		txtUid.TabIndex = 114;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		nudDelayTo.Location = new System.Drawing.Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(28, 298);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(103, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi Uid 1 dòng)";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(27, 139);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(115, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch Uid (0):";
		E9848624.Location = new System.Drawing.Point(132, 111);
		E9848624.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E9848624.Name = "nudDelayFrom";
		E9848624.Size = new System.Drawing.Size(56, 23);
		E9848624.TabIndex = 3;
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(194, 113);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(290, 113);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 113);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(90, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(194, 82);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(290, 82);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 82);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(89, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		A794EC31.AutoSize = true;
		A794EC31.Location = new System.Drawing.Point(27, 52);
		A794EC31.Name = "label1";
		A794EC31.Size = new System.Drawing.Size(99, 16);
		A794EC31.TabIndex = 31;
		A794EC31.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(190, 328);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(83, 328);
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
		bunifuCards1.Controls.Add(CA89929D);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 374);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanVoiBanBeCuaUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B809C1BD);
		CA89929D.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)E9848624).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
