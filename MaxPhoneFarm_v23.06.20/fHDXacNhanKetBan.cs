using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXacNhanKetBan : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string D40DF037;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown FB20F834;

	internal TextBox txtTenHanhDong;

	internal Label FBA90CA9;

	internal Label CEBED51B;

	internal Label B92AE901;

	internal Label AE2E443D;

	internal Button btnCancel;

	internal Button C2216C1A;

	internal BunifuCards bunifuCards1;

	internal Panel C9BD70A9;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown EB9FB198;

	internal Label label7;

	internal Label B935B4AC;

	internal Label CABCDE8D;

	internal CheckBox FD14093E;

	internal CheckBox ckbOnlyAddFriendWithMutualFriends;

	public fHDXacNhanKetBan(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		D40DF037 = string_2;
		string_1 = string_3;
		int_0 = int_1;
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDXacNhanKetBan");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			C2216C1A.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
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
		Language.smethod_1(AE2E443D);
		Language.smethod_1(B92AE901);
		Language.smethod_1(FBA90CA9);
		Language.smethod_1(CEBED51B);
		Language.smethod_1(CABCDE8D);
		Language.smethod_1(label7);
		Language.smethod_1(B935B4AC);
		Language.smethod_1(FD14093E);
		Language.smethod_1(ckbOnlyAddFriendWithMutualFriends);
		Language.smethod_1(C2216C1A);
		Language.smethod_1(btnCancel);
	}

	private void fHDXacNhanKetBan_Load(object sender, EventArgs e)
	{
		try
		{
			FB20F834.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = f72FAFBC_0.method_0("nudSoLuongTo", 3);
			EB9FB198.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			FD14093E.Checked = f72FAFBC_0.AA824D29("ckbChiKetBanTenCoDau");
			ckbOnlyAddFriendWithMutualFriends.Checked = f72FAFBC_0.AA824D29("ckbOnlyAddFriendWithMutualFriends");
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C2216C1A_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", FB20F834.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", EB9FB198.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("ckbChiKetBanTenCoDau", FD14093E.Checked);
		f72FAFBC.GetValue("ckbOnlyAddFriendWithMutualFriends", ckbOnlyAddFriendWithMutualFriends.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(D40DF037, text, string_0, text2))
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
			if (Class123.smethod_14(string_1, text, text2))
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

	protected override void Dispose(bool C43AF4BF)
	{
		if (C43AF4BF && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C43AF4BF);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXacNhanKetBan));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		C9BD70A9 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		ckbOnlyAddFriendWithMutualFriends = new System.Windows.Forms.CheckBox();
		FD14093E = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		EB9FB198 = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		B935B4AC = new System.Windows.Forms.Label();
		CABCDE8D = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		FB20F834 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		FBA90CA9 = new System.Windows.Forms.Label();
		CEBED51B = new System.Windows.Forms.Label();
		B92AE901 = new System.Windows.Forms.Label();
		AE2E443D = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		C2216C1A = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		C9BD70A9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)EB9FB198).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)FB20F834).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Xác nhận kết bạn";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = C9BD70A9;
		bunifuDragControl_1.Vertical = true;
		C9BD70A9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C9BD70A9.BackColor = System.Drawing.Color.White;
		C9BD70A9.Controls.Add(button1);
		C9BD70A9.Controls.Add(pictureBox1);
		C9BD70A9.Controls.Add(bunifuCustomLabel1);
		C9BD70A9.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C9BD70A9.Location = new System.Drawing.Point(0, 3);
		C9BD70A9.Name = "pnlHeader";
		C9BD70A9.Size = new System.Drawing.Size(359, 31);
		C9BD70A9.TabIndex = 9;
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
		panel1.Controls.Add(ckbOnlyAddFriendWithMutualFriends);
		panel1.Controls.Add(FD14093E);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(EB9FB198);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(B935B4AC);
		panel1.Controls.Add(CABCDE8D);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(FB20F834);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(FBA90CA9);
		panel1.Controls.Add(CEBED51B);
		panel1.Controls.Add(B92AE901);
		panel1.Controls.Add(AE2E443D);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(C2216C1A);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 192);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		ckbOnlyAddFriendWithMutualFriends.AutoSize = true;
		ckbOnlyAddFriendWithMutualFriends.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbOnlyAddFriendWithMutualFriends.Location = new System.Drawing.Point(30, 231);
		ckbOnlyAddFriendWithMutualFriends.Name = "ckbOnlyAddFriendWithMutualFriends";
		ckbOnlyAddFriendWithMutualFriends.Size = new System.Drawing.Size(227, 20);
		ckbOnlyAddFriendWithMutualFriends.TabIndex = 49;
		ckbOnlyAddFriendWithMutualFriends.Text = "Chỉ kết bạn với người có bạn chung";
		ckbOnlyAddFriendWithMutualFriends.UseVisualStyleBackColor = true;
		FD14093E.AutoSize = true;
		FD14093E.Cursor = System.Windows.Forms.Cursors.Hand;
		FD14093E.Location = new System.Drawing.Point(30, 207);
		FD14093E.Name = "ckbChiKetBanTenCoDau";
		FD14093E.Size = new System.Drawing.Size(304, 20);
		FD14093E.TabIndex = 48;
		FD14093E.Text = "Chỉ kết bạn với tên có dấu (Kết bạn với nick Việt)";
		FD14093E.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new System.Drawing.Point(229, 112);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		EB9FB198.Location = new System.Drawing.Point(132, 112);
		EB9FB198.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		EB9FB198.Name = "nudDelayFrom";
		EB9FB198.Size = new System.Drawing.Size(56, 23);
		EB9FB198.TabIndex = 3;
		label7.Location = new System.Drawing.Point(194, 114);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B935B4AC.AutoSize = true;
		B935B4AC.Location = new System.Drawing.Point(287, 114);
		B935B4AC.Name = "label6";
		B935B4AC.Size = new System.Drawing.Size(31, 16);
		B935B4AC.TabIndex = 45;
		B935B4AC.Text = "giây";
		CABCDE8D.AutoSize = true;
		CABCDE8D.Location = new System.Drawing.Point(27, 114);
		CABCDE8D.Name = "label5";
		CABCDE8D.Size = new System.Drawing.Size(90, 16);
		CABCDE8D.TabIndex = 44;
		CABCDE8D.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new System.Drawing.Point(229, 81);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		FB20F834.Location = new System.Drawing.Point(132, 81);
		FB20F834.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FB20F834.Name = "nudSoLuongFrom";
		FB20F834.Size = new System.Drawing.Size(56, 23);
		FB20F834.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		FBA90CA9.Location = new System.Drawing.Point(194, 83);
		FBA90CA9.Name = "label3";
		FBA90CA9.Size = new System.Drawing.Size(29, 16);
		FBA90CA9.TabIndex = 37;
		FBA90CA9.Text = "đê\u0301n";
		FBA90CA9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		CEBED51B.AutoSize = true;
		CEBED51B.Location = new System.Drawing.Point(287, 83);
		CEBED51B.Name = "label4";
		CEBED51B.Size = new System.Drawing.Size(29, 16);
		CEBED51B.TabIndex = 35;
		CEBED51B.Text = "ba\u0323n";
		B92AE901.AutoSize = true;
		B92AE901.Location = new System.Drawing.Point(27, 83);
		B92AE901.Name = "label2";
		B92AE901.Size = new System.Drawing.Size(89, 16);
		B92AE901.TabIndex = 32;
		B92AE901.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		AE2E443D.AutoSize = true;
		AE2E443D.Location = new System.Drawing.Point(27, 52);
		AE2E443D.Name = "label1";
		AE2E443D.Size = new System.Drawing.Size(99, 16);
		AE2E443D.TabIndex = 31;
		AE2E443D.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 148);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		C2216C1A.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		C2216C1A.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		C2216C1A.Cursor = System.Windows.Forms.Cursors.Hand;
		C2216C1A.FlatAppearance.BorderSize = 0;
		C2216C1A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C2216C1A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C2216C1A.ForeColor = System.Drawing.Color.White;
		C2216C1A.Location = new System.Drawing.Point(82, 148);
		C2216C1A.Name = "btnAdd";
		C2216C1A.Size = new System.Drawing.Size(92, 29);
		C2216C1A.TabIndex = 6;
		C2216C1A.Text = "Thêm";
		C2216C1A.UseVisualStyleBackColor = false;
		C2216C1A.Click += new System.EventHandler(C2216C1A_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(C9BD70A9);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 192);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXacNhanKetBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXacNhanKetBan_Load);
		C9BD70A9.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)EB9FB198).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)FB20F834).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
