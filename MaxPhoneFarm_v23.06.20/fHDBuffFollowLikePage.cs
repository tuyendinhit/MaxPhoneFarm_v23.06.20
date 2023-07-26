using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDBuffFollowLikePage : Form
{
	internal JObject BD3A7E98;

	internal string string_0;

	internal string BA92D682;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer AA021DA0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl B6964907;

	internal Panel F6B023B7;

	internal NumericUpDown BA978504;

	internal NumericUpDown nudDelayFrom;

	internal TextBox txtTenHanhDong;

	internal Label D29D6DA5;

	internal Label label6;

	internal Label label5;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel CBAA4E1D;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label label10;

	internal TextBox txtUid;

	internal Label EBB02EB9;

	internal CheckBox ckbFollow;

	internal CheckBox ckbLike;

	public fHDBuffFollowLikePage(string D607B6A2, int A6A4BE8B = 0, string D8BDA00D = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = D607B6A2;
		string_1 = D8BDA00D;
		int_0 = A6A4BE8B;
		if (Class123.C7BE863B("", "HDBuffFollowLikePage").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBuffFollowLikePage', '{  \"txtUid\": \"\", \"ckbLike\": \"True\",  \"ckbFollow\": \"False\",\"nudDelayFrom\": \"5\",  \"nudDelayTo\": \"10\"}', 'Buff Like, Follow page');");
		}
		string json = "";
		switch (A6A4BE8B)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDBuffFollowLikePage");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			BA92D682 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(D8BDA00D);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		BD3A7E98 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void BB02331B()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(label5);
		Language.smethod_1(D29D6DA5);
		Language.smethod_1(label6);
		Language.smethod_1(EBB02EB9);
		Language.smethod_1(label10);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void A93761B8(object sender, EventArgs e)
	{
		try
		{
			ckbLike.Checked = Convert.ToBoolean(BD3A7E98["ckbLike"]);
			ckbFollow.Checked = Convert.ToBoolean(BD3A7E98["ckbFollow"]);
			nudDelayFrom.Value = Convert.ToInt32(BD3A7E98["nudDelayFrom"]);
			BA978504.Value = Convert.ToInt32(BD3A7E98["nudDelayTo"]);
			txtUid.Text = BD3A7E98["txtUid"]!.ToString();
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
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
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Uid page!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", BA978504.Value);
		f72FAFBC.GetValue("txtUid", (object)txtUid.Text.Trim());
		f72FAFBC.GetValue("ckbLike", ckbLike.Checked);
		f72FAFBC.GetValue("ckbFollow", ckbFollow.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, BA92D682, text2))
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

	private void A5905AAE(object sender, EventArgs e)
	{
		Close();
	}

	private void F6B023B7_Paint(object sender, PaintEventArgs e)
	{
		if (F6B023B7.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, F6B023B7.ClientSize.Width - num, F6B023B7.ClientSize.Height - num));
		}
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUid.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			EBB02EB9.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid Page ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && AA021DA0 != null)
		{
			AA021DA0.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		AA021DA0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBuffFollowLikePage));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(AA021DA0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		B6964907 = new Bunifu.Framework.UI.BunifuDragControl(AA021DA0);
		CBAA4E1D = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		F6B023B7 = new System.Windows.Forms.Panel();
		ckbFollow = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		label10 = new System.Windows.Forms.Label();
		txtUid = new System.Windows.Forms.TextBox();
		EBB02EB9 = new System.Windows.Forms.Label();
		BA978504 = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		D29D6DA5 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		CBAA4E1D.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		F6B023B7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BA978504).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
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
		bunifuCustomLabel1.Text = "Cấu hình Buff Like, Follow page";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B6964907.Fixed = true;
		B6964907.Horizontal = true;
		B6964907.TargetControl = CBAA4E1D;
		B6964907.Vertical = true;
		CBAA4E1D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CBAA4E1D.BackColor = System.Drawing.Color.White;
		CBAA4E1D.Controls.Add(button1);
		CBAA4E1D.Controls.Add(pictureBox1);
		CBAA4E1D.Controls.Add(bunifuCustomLabel1);
		CBAA4E1D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CBAA4E1D.Location = new System.Drawing.Point(0, 3);
		CBAA4E1D.Name = "pnlHeader";
		CBAA4E1D.Size = new System.Drawing.Size(359, 31);
		CBAA4E1D.TabIndex = 9;
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
		F6B023B7.BackColor = System.Drawing.Color.White;
		F6B023B7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F6B023B7.Controls.Add(ckbFollow);
		F6B023B7.Controls.Add(ckbLike);
		F6B023B7.Controls.Add(label10);
		F6B023B7.Controls.Add(txtUid);
		F6B023B7.Controls.Add(EBB02EB9);
		F6B023B7.Controls.Add(BA978504);
		F6B023B7.Controls.Add(nudDelayFrom);
		F6B023B7.Controls.Add(txtTenHanhDong);
		F6B023B7.Controls.Add(D29D6DA5);
		F6B023B7.Controls.Add(label6);
		F6B023B7.Controls.Add(label5);
		F6B023B7.Controls.Add(label1);
		F6B023B7.Controls.Add(btnCancel);
		F6B023B7.Controls.Add(btnAdd);
		F6B023B7.Controls.Add(bunifuCards1);
		F6B023B7.Cursor = System.Windows.Forms.Cursors.Arrow;
		F6B023B7.Dock = System.Windows.Forms.DockStyle.Fill;
		F6B023B7.Location = new System.Drawing.Point(0, 0);
		F6B023B7.Name = "panel1";
		F6B023B7.Size = new System.Drawing.Size(362, 440);
		F6B023B7.TabIndex = 0;
		F6B023B7.Paint += new System.Windows.Forms.PaintEventHandler(F6B023B7_Paint);
		ckbFollow.AutoSize = true;
		ckbFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbFollow.Location = new System.Drawing.Point(30, 131);
		ckbFollow.Name = "ckbFollow";
		ckbFollow.Size = new System.Drawing.Size(96, 20);
		ckbFollow.TabIndex = 43;
		ckbFollow.Text = "Follow page";
		ckbFollow.UseVisualStyleBackColor = true;
		ckbLike.AutoSize = true;
		ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike.Location = new System.Drawing.Point(30, 105);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new System.Drawing.Size(81, 20);
		ckbLike.TabIndex = 42;
		ckbLike.Text = "Like page";
		ckbLike.UseVisualStyleBackColor = true;
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(28, 370);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(103, 16);
		label10.TabIndex = 39;
		label10.Text = "(Mỗi Uid 1 dòng)";
		txtUid.Location = new System.Drawing.Point(31, 173);
		txtUid.Multiline = true;
		txtUid.Name = "txtUid";
		txtUid.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtUid.Size = new System.Drawing.Size(297, 194);
		txtUid.TabIndex = 41;
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		EBB02EB9.AutoSize = true;
		EBB02EB9.Location = new System.Drawing.Point(27, 153);
		EBB02EB9.Name = "label2";
		EBB02EB9.Size = new System.Drawing.Size(147, 16);
		EBB02EB9.TabIndex = 40;
		EBB02EB9.Text = "Danh sa\u0301ch Uid Page (0):";
		BA978504.Location = new System.Drawing.Point(231, 78);
		BA978504.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BA978504.Name = "nudDelayTo";
		BA978504.Size = new System.Drawing.Size(56, 23);
		BA978504.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(134, 78);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		D29D6DA5.Location = new System.Drawing.Point(196, 80);
		D29D6DA5.Name = "label7";
		D29D6DA5.Size = new System.Drawing.Size(29, 16);
		D29D6DA5.TabIndex = 38;
		D29D6DA5.Text = "đê\u0301n";
		D29D6DA5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(289, 80);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 80);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(100, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian delay:";
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
		btnCancel.Location = new System.Drawing.Point(188, 395);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(A5905AAE);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(81, 395);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(CBAA4E1D);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 440);
		base.Controls.Add(F6B023B7);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffFollowLikePage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A93761B8);
		CBAA4E1D.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		F6B023B7.ResumeLayout(false);
		F6B023B7.PerformLayout();
		((System.ComponentModel.ISupportInitialize)BA978504).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
