using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDChocBanBe : Form
{
	internal JObject jobject_0;

	internal string BE1AFBA0;

	internal string A42670AC;

	internal string string_0;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl B89E3D27;

	internal Panel F236B385;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown A6A85C1F;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox F50BFA36;

	internal Label label7;

	internal Label E4B5BB8C;

	internal Label C82AB88B;

	internal Label label4;

	internal Label label5;

	internal Label label2;

	internal Label label1;

	internal Button btnCancel;

	internal Button C9BD631D;

	internal BunifuCards CFB06801;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	public fHDChocBanBe(string string_1, int CDA3430E = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		BE1AFBA0 = string_1;
		string_0 = string_2;
		int_0 = CDA3430E;
		string json = "";
		switch (CDA3430E)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDChocBanBe");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			A42670AC = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			F50BFA36.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			C9BD631D.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			F50BFA36.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(label2);
		Language.smethod_1(E4B5BB8C);
		Language.smethod_1(label4);
		Language.smethod_1(label5);
		Language.smethod_1(label7);
		Language.smethod_1(C82AB88B);
		Language.smethod_1(C9BD631D);
		Language.smethod_1(btnCancel);
	}

	private void fHDChocBanBe_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			A6A85C1F.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D7A2EA17(object sender, EventArgs e)
	{
		string text = F50BFA36.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", A6A85C1F.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(BE1AFBA0, text, A42670AC, text2))
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

	private void E41CC21D(object sender, EventArgs e)
	{
		Close();
	}

	private void F236B385_Paint(object sender, PaintEventArgs e)
	{
		if (F236B385.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, F236B385.ClientSize.Width - num, F236B385.ClientSize.Height - num));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDChocBanBe));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		B89E3D27 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		F236B385 = new System.Windows.Forms.Panel();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		A6A85C1F = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		F50BFA36 = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		E4B5BB8C = new System.Windows.Forms.Label();
		C82AB88B = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		C9BD631D = new System.Windows.Forms.Button();
		CFB06801 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		F236B385.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)A6A85C1F).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		CFB06801.SuspendLayout();
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
		bunifuCustomLabel1.Text = "Cấu hình Cho\u0323c ba\u0323n be\u0300";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B89E3D27.Fixed = true;
		B89E3D27.Horizontal = true;
		B89E3D27.TargetControl = pnlHeader;
		B89E3D27.Vertical = true;
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
		F236B385.BackColor = System.Drawing.Color.White;
		F236B385.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F236B385.Controls.Add(nudDelayTo);
		F236B385.Controls.Add(nudSoLuongTo);
		F236B385.Controls.Add(A6A85C1F);
		F236B385.Controls.Add(nudSoLuongFrom);
		F236B385.Controls.Add(F50BFA36);
		F236B385.Controls.Add(label7);
		F236B385.Controls.Add(E4B5BB8C);
		F236B385.Controls.Add(C82AB88B);
		F236B385.Controls.Add(label4);
		F236B385.Controls.Add(label5);
		F236B385.Controls.Add(label2);
		F236B385.Controls.Add(label1);
		F236B385.Controls.Add(btnCancel);
		F236B385.Controls.Add(C9BD631D);
		F236B385.Controls.Add(CFB06801);
		F236B385.Cursor = System.Windows.Forms.Cursors.Arrow;
		F236B385.Dock = System.Windows.Forms.DockStyle.Fill;
		F236B385.Location = new System.Drawing.Point(0, 0);
		F236B385.Name = "panel1";
		F236B385.Size = new System.Drawing.Size(362, 199);
		F236B385.TabIndex = 0;
		F236B385.Paint += new System.Windows.Forms.PaintEventHandler(F236B385_Paint);
		nudDelayTo.Location = new System.Drawing.Point(229, 115);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudSoLuongTo.Location = new System.Drawing.Point(229, 84);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		A6A85C1F.Location = new System.Drawing.Point(132, 115);
		A6A85C1F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A6A85C1F.Name = "nudDelayFrom";
		A6A85C1F.Size = new System.Drawing.Size(56, 23);
		A6A85C1F.TabIndex = 3;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 84);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		F50BFA36.Location = new System.Drawing.Point(132, 49);
		F50BFA36.Name = "txtTenHanhDong";
		F50BFA36.Size = new System.Drawing.Size(194, 23);
		F50BFA36.TabIndex = 0;
		label7.Location = new System.Drawing.Point(194, 117);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E4B5BB8C.Location = new System.Drawing.Point(194, 86);
		E4B5BB8C.Name = "label3";
		E4B5BB8C.Size = new System.Drawing.Size(29, 16);
		E4B5BB8C.TabIndex = 37;
		E4B5BB8C.Text = "đê\u0301n";
		E4B5BB8C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C82AB88B.AutoSize = true;
		C82AB88B.Location = new System.Drawing.Point(287, 117);
		C82AB88B.Name = "label6";
		C82AB88B.Size = new System.Drawing.Size(31, 16);
		C82AB88B.TabIndex = 36;
		C82AB88B.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(287, 86);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 117);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(90, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 86);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(94, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng cho\u0323c:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 154);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(E41CC21D);
		C9BD631D.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		C9BD631D.Cursor = System.Windows.Forms.Cursors.Hand;
		C9BD631D.FlatAppearance.BorderSize = 0;
		C9BD631D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C9BD631D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C9BD631D.ForeColor = System.Drawing.Color.White;
		C9BD631D.Location = new System.Drawing.Point(82, 154);
		C9BD631D.Name = "btnAdd";
		C9BD631D.Size = new System.Drawing.Size(92, 29);
		C9BD631D.TabIndex = 9;
		C9BD631D.Text = "Thêm";
		C9BD631D.UseVisualStyleBackColor = false;
		C9BD631D.Click += new System.EventHandler(D7A2EA17);
		CFB06801.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CFB06801.BackColor = System.Drawing.Color.White;
		CFB06801.BorderRadius = 0;
		CFB06801.BottomSahddow = true;
		CFB06801.color = System.Drawing.Color.DarkViolet;
		CFB06801.Controls.Add(pnlHeader);
		CFB06801.LeftSahddow = false;
		CFB06801.Location = new System.Drawing.Point(1, 0);
		CFB06801.Name = "bunifuCards1";
		CFB06801.RightSahddow = true;
		CFB06801.ShadowDepth = 20;
		CFB06801.Size = new System.Drawing.Size(359, 37);
		CFB06801.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 199);
		base.Controls.Add(F236B385);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChocBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDChocBanBe_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		F236B385.ResumeLayout(false);
		F236B385.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)A6A85C1F).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		CFB06801.ResumeLayout(false);
		ResumeLayout(false);
	}
}
