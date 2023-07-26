using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDNghiGiaiLao : Form
{
	internal JSON_Settings f72FAFBC_0 = null;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int ABAAC4AA;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal NumericUpDown BCAAD506;

	internal NumericUpDown nudDelayFrom;

	internal TextBox txtTenHanhDong;

	internal Label label7;

	internal Label label6;

	internal Label label5;

	internal Label A52270B5;

	internal Button D91D3A01;

	internal Button btnAdd;

	internal BunifuCards B720EB96;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox D9929802;

	internal BunifuCustomLabel DD107B3B;

	public fHDNghiGiaiLao(string string_3, int int_0 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		ABAAC4AA = int_0;
		if (Class123.C7BE863B("", "HDNghiGiaiLao").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDNghiGiaiLao', 'Nghỉ giải lao');");
		}
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDNghiGiaiLao");
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

	private void method_0()
	{
		Language.smethod_1(DD107B3B);
		Language.smethod_1(A52270B5);
		Language.smethod_1(label5);
		Language.smethod_1(label7);
		Language.smethod_1(label6);
		Language.smethod_1(btnAdd);
		Language.smethod_1(D91D3A01);
	}

	private void fHDNghiGiaiLao_Load(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			BCAAD506.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void F3127FAB(object sender, EventArgs e)
	{
		Close();
	}

	private void C99D5D34(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", BCAAD506.Value);
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (ABAAC4AA == 0)
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

	private void D91D3A01_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F239861D(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool B82904B7)
	{
		if (B82904B7 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B82904B7);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDNghiGiaiLao));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		DD107B3B = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		D9929802 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		BCAAD506 = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		A52270B5 = new System.Windows.Forms.Label();
		D91D3A01 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		B720EB96 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D9929802).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BCAAD506).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		B720EB96.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DD107B3B;
		bunifuDragControl_0.Vertical = true;
		DD107B3B.BackColor = System.Drawing.Color.Transparent;
		DD107B3B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DD107B3B.Dock = System.Windows.Forms.DockStyle.Fill;
		DD107B3B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DD107B3B.ForeColor = System.Drawing.Color.Black;
		DD107B3B.Location = new System.Drawing.Point(0, 0);
		DD107B3B.Name = "bunifuCustomLabel1";
		DD107B3B.Size = new System.Drawing.Size(359, 31);
		DD107B3B.TabIndex = 12;
		DD107B3B.Text = "Cấu hình Nghỉ giải lao";
		DD107B3B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(D9929802);
		pnlHeader.Controls.Add(DD107B3B);
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
		button1.Click += new System.EventHandler(F3127FAB);
		D9929802.Cursor = System.Windows.Forms.Cursors.Default;
		D9929802.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		D9929802.Location = new System.Drawing.Point(3, 2);
		D9929802.Name = "pictureBox1";
		D9929802.Size = new System.Drawing.Size(34, 27);
		D9929802.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		D9929802.TabIndex = 76;
		D9929802.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(BCAAD506);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(A52270B5);
		panel1.Controls.Add(D91D3A01);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(B720EB96);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 160);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(F239861D);
		BCAAD506.Location = new System.Drawing.Point(229, 80);
		BCAAD506.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BCAAD506.Name = "nudDelayTo";
		BCAAD506.Size = new System.Drawing.Size(56, 23);
		BCAAD506.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(132, 80);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Location = new System.Drawing.Point(194, 82);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(287, 82);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 82);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(90, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		A52270B5.AutoSize = true;
		A52270B5.Location = new System.Drawing.Point(27, 52);
		A52270B5.Name = "label1";
		A52270B5.Size = new System.Drawing.Size(99, 16);
		A52270B5.TabIndex = 31;
		A52270B5.Text = "Tên ha\u0300nh đô\u0323ng:";
		D91D3A01.BackColor = System.Drawing.Color.Maroon;
		D91D3A01.Cursor = System.Windows.Forms.Cursors.Hand;
		D91D3A01.FlatAppearance.BorderSize = 0;
		D91D3A01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D91D3A01.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D91D3A01.ForeColor = System.Drawing.Color.White;
		D91D3A01.Location = new System.Drawing.Point(189, 116);
		D91D3A01.Name = "btnCancel";
		D91D3A01.Size = new System.Drawing.Size(92, 29);
		D91D3A01.TabIndex = 10;
		D91D3A01.Text = "Đóng";
		D91D3A01.UseVisualStyleBackColor = false;
		D91D3A01.Click += new System.EventHandler(D91D3A01_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 116);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(C99D5D34);
		B720EB96.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B720EB96.BackColor = System.Drawing.Color.White;
		B720EB96.BorderRadius = 0;
		B720EB96.BottomSahddow = true;
		B720EB96.color = System.Drawing.Color.DarkViolet;
		B720EB96.Controls.Add(pnlHeader);
		B720EB96.LeftSahddow = false;
		B720EB96.Location = new System.Drawing.Point(1, 0);
		B720EB96.Name = "bunifuCards1";
		B720EB96.RightSahddow = true;
		B720EB96.ShadowDepth = 20;
		B720EB96.Size = new System.Drawing.Size(359, 37);
		B720EB96.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 160);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDNghiGiaiLao";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDNghiGiaiLao_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)D9929802).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)BCAAD506).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		B720EB96.ResumeLayout(false);
		ResumeLayout(false);
	}
}
