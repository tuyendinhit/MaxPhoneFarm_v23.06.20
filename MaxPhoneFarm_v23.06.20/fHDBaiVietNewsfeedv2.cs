using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDBaiVietNewsfeedv2 : Form
{
	internal JObject jobject_0;

	internal string B8B3DABD;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool F20EAD90;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel D0BB4FB6;

	internal NumericUpDown E92DFBAB;

	internal NumericUpDown nudTimeTo;

	internal NumericUpDown nudDelayFrom;

	internal NumericUpDown ADA06308;

	internal TextBox txtTenHanhDong;

	internal Label label7;

	internal Label label3;

	internal Label label6;

	internal Label label4;

	internal Label C025CA2A;

	internal Label DDBD312D;

	internal Label label1;

	internal Button btnCancel;

	internal Button E51B0725;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox FD0CD90D;

	internal BunifuCustomLabel F1B8BCBF;

	internal Panel plComment;

	internal Label EB2D183D;

	internal Label lblStatus;

	internal CheckBox D8151A14;

	internal CheckBox F23EA1B2;

	internal TextBox txtComment;

	internal CheckBox B89EAB08;

	public fHDBaiVietNewsfeedv2(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		F20EAD90 = false;
		B8B3DABD = string_2;
		string_1 = string_3;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDBaiVietNewsfeedv2").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBaiVietNewsfeedv2', '{  \"nudTimeFrom\": \"10\",  \"nudTimeTo\": \"30\",  \"nudDelayFrom\": \"2\",  \"nudDelayTo\": \"3\",  \"ckbInteract\": \"True\",  \"ckbShareWall\": \"False\",  \"ckbComment\": \"False\",  \"txtComment\": \"\"}', 'Bài viết Newsfeed v2');");
		}
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDBaiVietNewsfeedv2");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			E51B0725.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void fHDBaiVietNewsfeedv2_Load(object sender, EventArgs e)
	{
		try
		{
			ADA06308.Value = Convert.ToInt32(jobject_0["nudTimeFrom"]);
			nudTimeTo.Value = Convert.ToInt32(jobject_0["nudTimeTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			E92DFBAB.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			F23EA1B2.Checked = Convert.ToBoolean(jobject_0["ckbInteract"]);
			B89EAB08.Checked = Convert.ToBoolean(jobject_0["ckbShareWall"]);
			D8151A14.Checked = Convert.ToBoolean(jobject_0["ckbComment"]);
			txtComment.Text = jobject_0["txtComment"]!.ToString();
		}
		catch
		{
		}
		method_1();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D1A0492D(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) != DialogResult.Yes)
			{
				return;
			}
			string text = txtTenHanhDong.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
				return;
			}
			if (D8151A14.Checked)
			{
				List<string> f1808BA = txtComment.Lines.ToList();
				f1808BA = Common.RemoveEmptyItems(f1808BA);
				if (f1808BA.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
					return;
				}
			}
			JSON_Settings f72FAFBC = new JSON_Settings();
			f72FAFBC.GetValue("nudTimeFrom", ADA06308.Value);
			f72FAFBC.GetValue("nudTimeTo", nudTimeTo.Value);
			f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
			f72FAFBC.GetValue("nudDelayTo", E92DFBAB.Value);
			f72FAFBC.GetValue("ckbInteract", F23EA1B2.Checked);
			f72FAFBC.GetValue("ckbShareWall", B89EAB08.Checked);
			f72FAFBC.GetValue("ckbComment", D8151A14.Checked);
			f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
			string d9253C2E = f72FAFBC.C71A4EA4();
			if (Class123.smethod_12(B8B3DABD, text, string_0, d9253C2E))
			{
				F20EAD90 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
		else
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) != DialogResult.Yes)
			{
				return;
			}
			string text2 = txtTenHanhDong.Text.Trim();
			if (text2 == "")
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
				return;
			}
			if (D8151A14.Checked)
			{
				List<string> f1808BA2 = txtComment.Lines.ToList();
				f1808BA2 = Common.RemoveEmptyItems(f1808BA2);
				if (f1808BA2.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
					return;
				}
			}
			JSON_Settings f72FAFBC2 = new JSON_Settings();
			f72FAFBC2.GetValue("nudTimeFrom", ADA06308.Value);
			f72FAFBC2.GetValue("nudTimeTo", nudTimeTo.Value);
			f72FAFBC2.GetValue("nudDelayFrom", nudDelayFrom.Value);
			f72FAFBC2.GetValue("nudDelayTo", E92DFBAB.Value);
			f72FAFBC2.GetValue("ckbInteract", F23EA1B2.Checked);
			f72FAFBC2.GetValue("ckbShareWall", B89EAB08.Checked);
			f72FAFBC2.GetValue("ckbComment", D8151A14.Checked);
			f72FAFBC2.GetValue("txtComment", (object)txtComment.Text.Trim());
			string string_ = f72FAFBC2.C71A4EA4();
			if (Class123.smethod_14(string_1, text2, string_))
			{
				F20EAD90 = true;
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

	private void D1BBE7B8(object sender, PaintEventArgs e)
	{
		if (D0BB4FB6.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, D0BB4FB6.ClientSize.Width - num, D0BB4FB6.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtComment.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		F7BD312E(null, null);
		A01395BA(null, null);
	}

	private void F7BD312E(object sender, EventArgs e)
	{
	}

	private void A01395BA(object sender, EventArgs e)
	{
		plComment.Enabled = D8151A14.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBaiVietNewsfeedv2));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		F1B8BCBF = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		FD0CD90D = new System.Windows.Forms.PictureBox();
		D0BB4FB6 = new System.Windows.Forms.Panel();
		plComment = new System.Windows.Forms.Panel();
		txtComment = new System.Windows.Forms.TextBox();
		EB2D183D = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		D8151A14 = new System.Windows.Forms.CheckBox();
		B89EAB08 = new System.Windows.Forms.CheckBox();
		F23EA1B2 = new System.Windows.Forms.CheckBox();
		E92DFBAB = new System.Windows.Forms.NumericUpDown();
		nudTimeTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		ADA06308 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		C025CA2A = new System.Windows.Forms.Label();
		DDBD312D = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		E51B0725 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FD0CD90D).BeginInit();
		D0BB4FB6.SuspendLayout();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E92DFBAB).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)ADA06308).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = F1B8BCBF;
		bunifuDragControl_0.Vertical = true;
		F1B8BCBF.BackColor = System.Drawing.Color.Transparent;
		F1B8BCBF.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F1B8BCBF.Dock = System.Windows.Forms.DockStyle.Fill;
		F1B8BCBF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F1B8BCBF.ForeColor = System.Drawing.Color.Black;
		F1B8BCBF.Location = new System.Drawing.Point(0, 0);
		F1B8BCBF.Name = "bunifuCustomLabel1";
		F1B8BCBF.Size = new System.Drawing.Size(359, 31);
		F1B8BCBF.TabIndex = 12;
		F1B8BCBF.Text = "Cấu hình Bài viết Newsfeed v2";
		F1B8BCBF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(FD0CD90D);
		pnlHeader.Controls.Add(F1B8BCBF);
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
		FD0CD90D.Cursor = System.Windows.Forms.Cursors.Default;
		FD0CD90D.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		FD0CD90D.Location = new System.Drawing.Point(3, 2);
		FD0CD90D.Name = "pictureBox1";
		FD0CD90D.Size = new System.Drawing.Size(34, 27);
		FD0CD90D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		FD0CD90D.TabIndex = 76;
		FD0CD90D.TabStop = false;
		D0BB4FB6.BackColor = System.Drawing.Color.White;
		D0BB4FB6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D0BB4FB6.Controls.Add(plComment);
		D0BB4FB6.Controls.Add(D8151A14);
		D0BB4FB6.Controls.Add(B89EAB08);
		D0BB4FB6.Controls.Add(F23EA1B2);
		D0BB4FB6.Controls.Add(E92DFBAB);
		D0BB4FB6.Controls.Add(nudTimeTo);
		D0BB4FB6.Controls.Add(nudDelayFrom);
		D0BB4FB6.Controls.Add(ADA06308);
		D0BB4FB6.Controls.Add(txtTenHanhDong);
		D0BB4FB6.Controls.Add(label7);
		D0BB4FB6.Controls.Add(label3);
		D0BB4FB6.Controls.Add(label6);
		D0BB4FB6.Controls.Add(label4);
		D0BB4FB6.Controls.Add(C025CA2A);
		D0BB4FB6.Controls.Add(DDBD312D);
		D0BB4FB6.Controls.Add(label1);
		D0BB4FB6.Controls.Add(btnCancel);
		D0BB4FB6.Controls.Add(E51B0725);
		D0BB4FB6.Controls.Add(bunifuCards1);
		D0BB4FB6.Cursor = System.Windows.Forms.Cursors.Arrow;
		D0BB4FB6.Dock = System.Windows.Forms.DockStyle.Fill;
		D0BB4FB6.Location = new System.Drawing.Point(0, 0);
		D0BB4FB6.Name = "panel1";
		D0BB4FB6.Size = new System.Drawing.Size(362, 436);
		D0BB4FB6.TabIndex = 0;
		D0BB4FB6.Paint += new System.Windows.Forms.PaintEventHandler(D1BBE7B8);
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(EB2D183D);
		plComment.Controls.Add(lblStatus);
		plComment.Location = new System.Drawing.Point(48, 218);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(278, 164);
		plComment.TabIndex = 8;
		txtComment.Location = new System.Drawing.Point(7, 27);
		txtComment.Multiline = true;
		txtComment.Name = "txtComment";
		txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtComment.Size = new System.Drawing.Size(261, 111);
		txtComment.TabIndex = 1;
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		EB2D183D.AutoSize = true;
		EB2D183D.Location = new System.Drawing.Point(4, 141);
		EB2D183D.Name = "label8";
		EB2D183D.Size = new System.Drawing.Size(266, 16);
		EB2D183D.TabIndex = 0;
		EB2D183D.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(140, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		D8151A14.AutoSize = true;
		D8151A14.Cursor = System.Windows.Forms.Cursors.Hand;
		D8151A14.Location = new System.Drawing.Point(30, 193);
		D8151A14.Name = "ckbComment";
		D8151A14.Size = new System.Drawing.Size(131, 20);
		D8151A14.TabIndex = 7;
		D8151A14.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		D8151A14.UseVisualStyleBackColor = true;
		D8151A14.CheckedChanged += new System.EventHandler(A01395BA);
		B89EAB08.AutoSize = true;
		B89EAB08.Cursor = System.Windows.Forms.Cursors.Hand;
		B89EAB08.Location = new System.Drawing.Point(30, 167);
		B89EAB08.Name = "ckbShareWall";
		B89EAB08.Size = new System.Drawing.Size(123, 20);
		B89EAB08.TabIndex = 6;
		B89EAB08.Text = "Chia sẻ về tường";
		B89EAB08.UseVisualStyleBackColor = true;
		F23EA1B2.AutoSize = true;
		F23EA1B2.Cursor = System.Windows.Forms.Cursors.Hand;
		F23EA1B2.Location = new System.Drawing.Point(30, 141);
		F23EA1B2.Name = "ckbInteract";
		F23EA1B2.Size = new System.Drawing.Size(49, 20);
		F23EA1B2.TabIndex = 5;
		F23EA1B2.Text = "Like";
		F23EA1B2.UseVisualStyleBackColor = true;
		E92DFBAB.Location = new System.Drawing.Point(231, 111);
		E92DFBAB.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E92DFBAB.Name = "nudDelayTo";
		E92DFBAB.Size = new System.Drawing.Size(56, 23);
		E92DFBAB.TabIndex = 4;
		nudTimeTo.Location = new System.Drawing.Point(231, 80);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new System.Drawing.Size(56, 23);
		nudTimeTo.TabIndex = 2;
		nudDelayFrom.Location = new System.Drawing.Point(134, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		ADA06308.Location = new System.Drawing.Point(134, 80);
		ADA06308.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		ADA06308.Name = "nudTimeFrom";
		ADA06308.Size = new System.Drawing.Size(56, 23);
		ADA06308.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(196, 113);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(196, 82);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(292, 113);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(292, 82);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(31, 16);
		label4.TabIndex = 35;
		label4.Text = "giây";
		C025CA2A.AutoSize = true;
		C025CA2A.Location = new System.Drawing.Point(27, 113);
		C025CA2A.Name = "label5";
		C025CA2A.Size = new System.Drawing.Size(111, 16);
		C025CA2A.TabIndex = 34;
		C025CA2A.Text = "Khoa\u0309ng ca\u0301ch lươ\u0301t:";
		DDBD312D.AutoSize = true;
		DDBD312D.Location = new System.Drawing.Point(27, 82);
		DDBD312D.Name = "label2";
		DDBD312D.Size = new System.Drawing.Size(92, 16);
		DDBD312D.TabIndex = 32;
		DDBD312D.Text = "Thơ\u0300i gian lươ\u0301t:";
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
		btnCancel.Location = new System.Drawing.Point(189, 393);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		E51B0725.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		E51B0725.Cursor = System.Windows.Forms.Cursors.Hand;
		E51B0725.FlatAppearance.BorderSize = 0;
		E51B0725.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E51B0725.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E51B0725.ForeColor = System.Drawing.Color.White;
		E51B0725.Location = new System.Drawing.Point(82, 393);
		E51B0725.Name = "btnAdd";
		E51B0725.Size = new System.Drawing.Size(92, 29);
		E51B0725.TabIndex = 9;
		E51B0725.Text = "Thêm";
		E51B0725.UseVisualStyleBackColor = false;
		E51B0725.Click += new System.EventHandler(D1A0492D);
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
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 436);
		base.Controls.Add(D0BB4FB6);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietNewsfeedv2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBaiVietNewsfeedv2_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)FD0CD90D).EndInit();
		D0BB4FB6.ResumeLayout(false);
		D0BB4FB6.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)E92DFBAB).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)ADA06308).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
