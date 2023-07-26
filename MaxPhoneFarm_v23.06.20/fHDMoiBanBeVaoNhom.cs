using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDMoiBanBeVaoNhom : Form
{
	internal JSON_Settings f72FAFBC_0 = null;

	internal string B2B36D82;

	internal string F908C08E;

	internal string string_0;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl E1970F22;

	internal Panel panel1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox txtTenHanhDong;

	internal Label label3;

	internal Label label4;

	internal Label FCB5EAA1;

	internal Label B3050320;

	internal Button btnCancel;

	internal Button CB3C3705;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label lblStatus;

	internal ToolTip toolTip_0;

	internal RadioButton rbInviteSuggest;

	internal RadioButton rbInviteRandom;

	internal Label label5;

	internal NumericUpDown E52056A5;

	internal NumericUpDown A4902299;

	internal Label label9;

	internal Label E69D4209;

	internal Label label6;

	internal RichTextBox txtIdGroup;

	public fHDMoiBanBeVaoNhom(string AF2D19A4, int int_1 = 0, string EF33100B = "")
	{
		InitializeComponent();
		bool_0 = false;
		B2B36D82 = AF2D19A4;
		string_0 = EF33100B;
		int_0 = int_1;
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDMoiBanBeVaoNhom");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			F908C08E = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(EF33100B);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			CB3C3705.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
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
		Language.smethod_1(B3050320);
		Language.smethod_1(FCB5EAA1);
		Language.smethod_1(label3);
		Language.smethod_1(label4);
		Language.smethod_1(label6);
		Language.smethod_1(label9);
		Language.smethod_1(E69D4209);
		Language.smethod_1(label5);
		Language.smethod_1(rbInviteRandom);
		Language.smethod_1(rbInviteSuggest);
		Language.smethod_1(lblStatus);
		Language.smethod_1(CB3C3705);
		Language.smethod_1(btnCancel);
	}

	private void fHDMoiBanBeVaoNhom_Load(object sender, EventArgs e)
	{
		try
		{
			if (f72FAFBC_0.method_0("typeInvite", 1) == 0)
			{
				rbInviteRandom.Checked = true;
			}
			else
			{
				rbInviteSuggest.Checked = true;
			}
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 3);
			nudSoLuongTo.Value = f72FAFBC_0.method_0("nudSoLuongTo", 5);
			A4902299.Value = f72FAFBC_0.method_0("nudDelayFrom", 1);
			E52056A5.Value = f72FAFBC_0.method_0("nudDelayTo", 3);
			txtIdGroup.Text = f72FAFBC_0.GetValue("txtIdGroup");
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B9885333(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", A4902299.Value);
		f72FAFBC.GetValue("nudDelayTo", E52056A5.Value);
		f72FAFBC.GetValue("txtIdGroup", (object)txtIdGroup.Text.Trim());
		if (rbInviteRandom.Checked)
		{
			f72FAFBC.GetValue("typeInvite", 0);
		}
		else
		{
			f72FAFBC.GetValue("typeInvite", 1);
		}
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(B2B36D82, text, F908C08E, text2))
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

	private void DD0617A6(object sender, PaintEventArgs e)
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
		if (CA1BA01F && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDMoiBanBeVaoNhom));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		E1970F22 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		rbInviteSuggest = new System.Windows.Forms.RadioButton();
		rbInviteRandom = new System.Windows.Forms.RadioButton();
		label5 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		E52056A5 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		A4902299 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label9 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		E69D4209 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		FCB5EAA1 = new System.Windows.Forms.Label();
		B3050320 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		CB3C3705 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		txtIdGroup = new System.Windows.Forms.RichTextBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E52056A5).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)A4902299).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
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
		bunifuCustomLabel1.Text = "Cấu hình Mời bạn bè vào nhóm";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E1970F22.Fixed = true;
		E1970F22.Horizontal = true;
		E1970F22.TargetControl = pnlHeader;
		E1970F22.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
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
		panel1.Controls.Add(txtIdGroup);
		panel1.Controls.Add(rbInviteSuggest);
		panel1.Controls.Add(rbInviteRandom);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(E52056A5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(A4902299);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(E69D4209);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(FCB5EAA1);
		panel1.Controls.Add(B3050320);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(CB3C3705);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 330);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(DD0617A6);
		rbInviteSuggest.AutoSize = true;
		rbInviteSuggest.Cursor = System.Windows.Forms.Cursors.Hand;
		rbInviteSuggest.Location = new System.Drawing.Point(132, 339);
		rbInviteSuggest.Name = "rbInviteSuggest";
		rbInviteSuggest.Size = new System.Drawing.Size(135, 20);
		rbInviteSuggest.TabIndex = 115;
		rbInviteSuggest.Text = "Gợi ý của Facebook";
		rbInviteSuggest.UseVisualStyleBackColor = true;
		rbInviteSuggest.Visible = false;
		rbInviteRandom.AutoSize = true;
		rbInviteRandom.Checked = true;
		rbInviteRandom.Cursor = System.Windows.Forms.Cursors.Hand;
		rbInviteRandom.Location = new System.Drawing.Point(132, 363);
		rbInviteRandom.Name = "rbInviteRandom";
		rbInviteRandom.Size = new System.Drawing.Size(155, 20);
		rbInviteRandom.TabIndex = 115;
		rbInviteRandom.TabStop = true;
		rbInviteRandom.Text = "Mời ngẫu nhiên ba\u0323n be\u0300";
		rbInviteRandom.UseVisualStyleBackColor = true;
		rbInviteRandom.Visible = false;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 341);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(89, 16);
		label5.TabIndex = 0;
		label5.Text = "Tùy chọn mời:";
		label5.Visible = false;
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(27, 138);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(93, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nhâ\u0323p ID nho\u0301m:";
		E52056A5.Location = new System.Drawing.Point(229, 109);
		E52056A5.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E52056A5.Name = "nudDelayTo";
		E52056A5.Size = new System.Drawing.Size(56, 23);
		E52056A5.TabIndex = 2;
		nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		A4902299.Location = new System.Drawing.Point(132, 109);
		A4902299.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A4902299.Name = "nudDelayFrom";
		A4902299.Size = new System.Drawing.Size(56, 23);
		A4902299.TabIndex = 1;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label9.Location = new System.Drawing.Point(194, 111);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 37;
		label9.Text = "đê\u0301n";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Location = new System.Drawing.Point(194, 82);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E69D4209.AutoSize = true;
		E69D4209.Location = new System.Drawing.Point(287, 111);
		E69D4209.Name = "label7";
		E69D4209.Size = new System.Drawing.Size(30, 16);
		E69D4209.TabIndex = 35;
		E69D4209.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(287, 82);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(28, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(27, 111);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(99, 16);
		label6.TabIndex = 32;
		label6.Text = "Thơ\u0300i gian delay:";
		FCB5EAA1.AutoSize = true;
		FCB5EAA1.Location = new System.Drawing.Point(27, 82);
		FCB5EAA1.Name = "label2";
		FCB5EAA1.Size = new System.Drawing.Size(88, 16);
		FCB5EAA1.TabIndex = 32;
		FCB5EAA1.Text = "Sô\u0301 lươ\u0323ng mơ\u0300i:";
		B3050320.AutoSize = true;
		B3050320.Location = new System.Drawing.Point(27, 52);
		B3050320.Name = "label1";
		B3050320.Size = new System.Drawing.Size(98, 16);
		B3050320.TabIndex = 31;
		B3050320.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(191, 290);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		CB3C3705.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		CB3C3705.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		CB3C3705.Cursor = System.Windows.Forms.Cursors.Hand;
		CB3C3705.FlatAppearance.BorderSize = 0;
		CB3C3705.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CB3C3705.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CB3C3705.ForeColor = System.Drawing.Color.White;
		CB3C3705.Location = new System.Drawing.Point(80, 290);
		CB3C3705.Name = "btnAdd";
		CB3C3705.Size = new System.Drawing.Size(92, 29);
		CB3C3705.TabIndex = 6;
		CB3C3705.Text = "Thêm";
		CB3C3705.UseVisualStyleBackColor = false;
		CB3C3705.Click += new System.EventHandler(B9885333);
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
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		txtIdGroup.Location = new System.Drawing.Point(132, 138);
		txtIdGroup.Name = "txtIdGroup";
		txtIdGroup.Size = new System.Drawing.Size(194, 143);
		txtIdGroup.TabIndex = 116;
		txtIdGroup.Text = "";
		txtIdGroup.WordWrap = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 330);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDMoiBanBeVaoNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDMoiBanBeVaoNhom_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)E52056A5).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)A4902299).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
