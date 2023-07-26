using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDSeedingByVideo : Form
{
	internal JSON_Settings E6248812;

	internal string C73EC105;

	internal string string_0;

	internal string D3808E12;

	internal int F823A786;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudDelayFrom;

	internal TextBox F892DA27;

	internal Label label7;

	internal Label label6;

	internal Label FF3A570D;

	internal Label label1;

	internal Button btnCancel;

	internal Button CB2CC29D;

	internal BunifuCards B49AF283;

	internal Panel CE95DD12;

	internal Button button1;

	internal PictureBox C49E1830;

	internal BunifuCustomLabel CDB85786;

	internal Label label10;

	internal Label F6BD8A2D;

	internal Panel E63BDBA1;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton FB34DBB8;

	internal Label DC8213AA;

	internal RichTextBox FAB6DEA7;

	internal Label DFBC9930;

	internal Label BF9FBF29;

	internal Panel plVideo;

	internal Button E88594B0;

	internal TextBox txtVideo;

	internal RichTextBox txtIdPost;

	internal CheckBox F4375B23;

	internal CheckBox F0BB529B;

	public fHDSeedingByVideo(string string_1, int int_0 = 0, string AC2065BC = "")
	{
		InitializeComponent();
		bool_0 = false;
		C73EC105 = string_1;
		D3808E12 = AC2065BC;
		F823A786 = int_0;
		if (Class123.C7BE863B("", "HDSeedingByVideo").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDSeedingByVideo', 'Seeding bằng video');");
		}
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDSeedingByVideo");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			F892DA27.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(AC2065BC);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			CB2CC29D.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			F892DA27.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		E6248812 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void D7BACBB8()
	{
		Language.smethod_1(CDB85786);
		Language.smethod_1(label1);
		Language.smethod_1(FF3A570D);
		Language.smethod_1(label7);
		Language.smethod_1(label6);
		Language.smethod_1(F6BD8A2D);
		Language.smethod_1(label10);
		Language.smethod_1(label10);
		Language.smethod_1(F0BB529B);
		Language.smethod_1(BF9FBF29);
		Language.smethod_1(DFBC9930);
		Language.smethod_1(DC8213AA);
		Language.smethod_1(FB34DBB8);
		Language.smethod_1(rbNganCachKyTu);
		Language.smethod_1(F4375B23);
		Language.smethod_1(E88594B0);
		Language.smethod_1(CB2CC29D);
		Language.smethod_1(btnCancel);
	}

	private void D5A35A22(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = E6248812.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = E6248812.method_0("nudDelayTo", 5);
			F0BB529B.Checked = E6248812.AA824D29("ckbComment");
			FAB6DEA7.Text = E6248812.GetValue("txtComment");
			txtIdPost.Text = E6248812.GetValue("txtIdPost");
			F4375B23.Checked = E6248812.AA824D29("ckbSendVideo");
			txtVideo.Text = E6248812.GetValue("txtVideo");
			if (E6248812.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				FB34DBB8.Checked = true;
			}
		}
		catch
		{
		}
		C02AE33B();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CB2CC29D_Click(object sender, EventArgs e)
	{
		string text = F892DA27.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> f1808BA = txtIdPost.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Id ba\u0300i viê\u0301t câ\u0300n buff like, comment!"), 3);
			return;
		}
		if (F0BB529B.Checked)
		{
			List<string> f1808BA2 = FAB6DEA7.Lines.ToList();
			f1808BA2 = Common.RemoveEmptyItems(f1808BA2);
			if (f1808BA2.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("ckbComment", F0BB529B.Checked);
		f72FAFBC.GetValue("txtComment", (object)FAB6DEA7.Text.Trim());
		f72FAFBC.GetValue("txtIdPost", (object)txtIdPost.Text.Trim());
		f72FAFBC.GetValue("ckbSendVideo", F4375B23.Checked);
		f72FAFBC.GetValue("txtVideo", (object)txtVideo.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		string text2 = f72FAFBC.C71A4EA4();
		if (F823A786 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(C73EC105, text, string_0, text2))
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
			if (Class123.smethod_14(D3808E12, text, text2))
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

	private void CEB5D98A(object sender, EventArgs e)
	{
		Close();
	}

	private void A60F4FB7(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void A5BD2F30(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = FAB6DEA7.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			BF9FBF29.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void C02AE33B()
	{
		E832023D(null, null);
		B23286BE(null, null);
	}

	private void E832023D(object sender, EventArgs e)
	{
	}

	private void B23286BE(object sender, EventArgs e)
	{
		E63BDBA1.Enabled = F0BB529B.Checked;
	}

	private void txtIdPost_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtIdPost.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			F6BD8A2D.Text = string.Format(Language.GetValue("Danh sa\u0301ch ID bài viết ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void C08FB11E(object sender, EventArgs e)
	{
		txtVideo.Text = Common.F68F9C11();
	}

	private void F4375B23_CheckedChanged(object sender, EventArgs e)
	{
		plVideo.Enabled = F4375B23.Checked;
	}

	private void panel1_Click(object sender, EventArgs e)
	{
	}

	private void A93C2236(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDSeedingByVideo));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		CDB85786 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		CE95DD12 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		C49E1830 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		E63BDBA1 = new System.Windows.Forms.Panel();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		FB34DBB8 = new System.Windows.Forms.RadioButton();
		DC8213AA = new System.Windows.Forms.Label();
		FAB6DEA7 = new System.Windows.Forms.RichTextBox();
		DFBC9930 = new System.Windows.Forms.Label();
		BF9FBF29 = new System.Windows.Forms.Label();
		plVideo = new System.Windows.Forms.Panel();
		E88594B0 = new System.Windows.Forms.Button();
		txtVideo = new System.Windows.Forms.TextBox();
		txtIdPost = new System.Windows.Forms.RichTextBox();
		F4375B23 = new System.Windows.Forms.CheckBox();
		F0BB529B = new System.Windows.Forms.CheckBox();
		label10 = new System.Windows.Forms.Label();
		F6BD8A2D = new System.Windows.Forms.Label();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		F892DA27 = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		FF3A570D = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		CB2CC29D = new System.Windows.Forms.Button();
		B49AF283 = new Bunifu.Framework.UI.BunifuCards();
		CE95DD12.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C49E1830).BeginInit();
		panel1.SuspendLayout();
		E63BDBA1.SuspendLayout();
		plVideo.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		B49AF283.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = CDB85786;
		bunifuDragControl_0.Vertical = true;
		CDB85786.BackColor = System.Drawing.Color.Transparent;
		CDB85786.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CDB85786.Dock = System.Windows.Forms.DockStyle.Fill;
		CDB85786.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CDB85786.ForeColor = System.Drawing.Color.Black;
		CDB85786.Location = new System.Drawing.Point(0, 0);
		CDB85786.Name = "bunifuCustomLabel1";
		CDB85786.Size = new System.Drawing.Size(684, 31);
		CDB85786.TabIndex = 12;
		CDB85786.Text = "Cấu hình Seeding ba\u0300i viê\u0301t";
		CDB85786.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = CE95DD12;
		bunifuDragControl_1.Vertical = true;
		CE95DD12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CE95DD12.BackColor = System.Drawing.Color.White;
		CE95DD12.Controls.Add(button1);
		CE95DD12.Controls.Add(C49E1830);
		CE95DD12.Controls.Add(CDB85786);
		CE95DD12.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CE95DD12.Location = new System.Drawing.Point(0, 3);
		CE95DD12.Name = "pnlHeader";
		CE95DD12.Size = new System.Drawing.Size(684, 31);
		CE95DD12.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(653, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		C49E1830.Cursor = System.Windows.Forms.Cursors.Default;
		C49E1830.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		C49E1830.Location = new System.Drawing.Point(3, 2);
		C49E1830.Name = "pictureBox1";
		C49E1830.Size = new System.Drawing.Size(34, 27);
		C49E1830.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		C49E1830.TabIndex = 76;
		C49E1830.TabStop = false;
		C49E1830.Click += new System.EventHandler(A93C2236);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(E63BDBA1);
		panel1.Controls.Add(plVideo);
		panel1.Controls.Add(txtIdPost);
		panel1.Controls.Add(F4375B23);
		panel1.Controls.Add(F0BB529B);
		panel1.Controls.Add(label10);
		panel1.Controls.Add(F6BD8A2D);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(F892DA27);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(FF3A570D);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(CB2CC29D);
		panel1.Controls.Add(B49AF283);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(687, 437);
		panel1.TabIndex = 0;
		panel1.Click += new System.EventHandler(panel1_Click);
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(A60F4FB7);
		E63BDBA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E63BDBA1.Controls.Add(rbNganCachKyTu);
		E63BDBA1.Controls.Add(FB34DBB8);
		E63BDBA1.Controls.Add(DC8213AA);
		E63BDBA1.Controls.Add(FAB6DEA7);
		E63BDBA1.Controls.Add(DFBC9930);
		E63BDBA1.Controls.Add(BF9FBF29);
		E63BDBA1.Location = new System.Drawing.Point(371, 104);
		E63BDBA1.Name = "plComment";
		E63BDBA1.Size = new System.Drawing.Size(281, 193);
		E63BDBA1.TabIndex = 164;
		rbNganCachKyTu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(70, 168);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(203, 20);
		rbNganCachKyTu.TabIndex = 3;
		rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		FB34DBB8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		FB34DBB8.AutoSize = true;
		FB34DBB8.Checked = true;
		FB34DBB8.Cursor = System.Windows.Forms.Cursors.Hand;
		FB34DBB8.Location = new System.Drawing.Point(70, 147);
		FB34DBB8.Name = "rbNganCachMoiDong";
		FB34DBB8.Size = new System.Drawing.Size(171, 20);
		FB34DBB8.TabIndex = 3;
		FB34DBB8.TabStop = true;
		FB34DBB8.Text = "Mỗi dòng là một nội dung";
		FB34DBB8.UseVisualStyleBackColor = true;
		DC8213AA.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		DC8213AA.AutoSize = true;
		DC8213AA.Location = new System.Drawing.Point(4, 147);
		DC8213AA.Name = "label8";
		DC8213AA.Size = new System.Drawing.Size(65, 16);
		DC8213AA.TabIndex = 2;
		DC8213AA.Text = "Tùy chọn:";
		FAB6DEA7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FAB6DEA7.Location = new System.Drawing.Point(7, 25);
		FAB6DEA7.Name = "txtComment";
		FAB6DEA7.Size = new System.Drawing.Size(263, 99);
		FAB6DEA7.TabIndex = 1;
		FAB6DEA7.Text = "";
		FAB6DEA7.WordWrap = false;
		DFBC9930.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		DFBC9930.AutoSize = true;
		DFBC9930.Location = new System.Drawing.Point(5, 127);
		DFBC9930.Name = "label11";
		DFBC9930.Size = new System.Drawing.Size(134, 16);
		DFBC9930.TabIndex = 0;
		DFBC9930.Text = "Spin nội dung {a|b|c}";
		BF9FBF29.AutoSize = true;
		BF9FBF29.Location = new System.Drawing.Point(3, 5);
		BF9FBF29.Name = "lblStatus";
		BF9FBF29.Size = new System.Drawing.Size(119, 16);
		BF9FBF29.TabIndex = 0;
		BF9FBF29.Text = "Nội dung bình luận:";
		plVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plVideo.Controls.Add(E88594B0);
		plVideo.Controls.Add(txtVideo);
		plVideo.Enabled = false;
		plVideo.Location = new System.Drawing.Point(371, 325);
		plVideo.Name = "plVideo";
		plVideo.Size = new System.Drawing.Size(281, 31);
		plVideo.TabIndex = 166;
		E88594B0.Cursor = System.Windows.Forms.Cursors.Hand;
		E88594B0.Location = new System.Drawing.Point(217, 2);
		E88594B0.Name = "button3";
		E88594B0.Size = new System.Drawing.Size(59, 25);
		E88594B0.TabIndex = 156;
		E88594B0.Text = "Chọn";
		E88594B0.UseVisualStyleBackColor = true;
		E88594B0.Click += new System.EventHandler(C08FB11E);
		txtVideo.Location = new System.Drawing.Point(3, 3);
		txtVideo.Name = "txtVideo";
		txtVideo.Size = new System.Drawing.Size(208, 23);
		txtVideo.TabIndex = 155;
		txtIdPost.Location = new System.Drawing.Point(30, 129);
		txtIdPost.Name = "txtIdPost";
		txtIdPost.Size = new System.Drawing.Size(297, 230);
		txtIdPost.TabIndex = 1;
		txtIdPost.Text = "";
		txtIdPost.WordWrap = false;
		txtIdPost.TextChanged += new System.EventHandler(txtIdPost_TextChanged);
		F4375B23.AutoSize = true;
		F4375B23.Cursor = System.Windows.Forms.Cursors.Hand;
		F4375B23.Location = new System.Drawing.Point(353, 303);
		F4375B23.Name = "ckbSendVideo";
		F4375B23.Size = new System.Drawing.Size(113, 20);
		F4375B23.TabIndex = 165;
		F4375B23.Text = "Bình luận video";
		F4375B23.UseVisualStyleBackColor = true;
		F4375B23.CheckedChanged += new System.EventHandler(F4375B23_CheckedChanged);
		F0BB529B.AutoSize = true;
		F0BB529B.Cursor = System.Windows.Forms.Cursors.Hand;
		F0BB529B.Location = new System.Drawing.Point(353, 79);
		F0BB529B.Name = "ckbComment";
		F0BB529B.Size = new System.Drawing.Size(128, 20);
		F0BB529B.TabIndex = 163;
		F0BB529B.Text = "Bi\u0300nh luâ\u0323n văn bản";
		F0BB529B.UseVisualStyleBackColor = true;
		F0BB529B.CheckedChanged += new System.EventHandler(B23286BE);
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(27, 362);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(97, 16);
		label10.TabIndex = 39;
		label10.Text = "(Mỗi ID 1 dòng)";
		F6BD8A2D.AutoSize = true;
		F6BD8A2D.Location = new System.Drawing.Point(27, 108);
		F6BD8A2D.Name = "label2";
		F6BD8A2D.Size = new System.Drawing.Size(154, 16);
		F6BD8A2D.TabIndex = 40;
		F6BD8A2D.Text = "Danh sa\u0301ch ID bài viết (0):";
		nudDelayTo.Location = new System.Drawing.Point(231, 78);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(134, 78);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		F892DA27.Location = new System.Drawing.Point(134, 49);
		F892DA27.Name = "txtTenHanhDong";
		F892DA27.Size = new System.Drawing.Size(194, 23);
		F892DA27.TabIndex = 0;
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(196, 80);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(292, 80);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		FF3A570D.AutoSize = true;
		FF3A570D.Location = new System.Drawing.Point(27, 80);
		FF3A570D.Name = "label5";
		FF3A570D.Size = new System.Drawing.Size(100, 16);
		FF3A570D.TabIndex = 34;
		FF3A570D.Text = "Thơ\u0300i gian delay:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(343, 395);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(CEB5D98A);
		CB2CC29D.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		CB2CC29D.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		CB2CC29D.Cursor = System.Windows.Forms.Cursors.Hand;
		CB2CC29D.FlatAppearance.BorderSize = 0;
		CB2CC29D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CB2CC29D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CB2CC29D.ForeColor = System.Drawing.Color.White;
		CB2CC29D.Location = new System.Drawing.Point(236, 395);
		CB2CC29D.Name = "btnAdd";
		CB2CC29D.Size = new System.Drawing.Size(92, 29);
		CB2CC29D.TabIndex = 9;
		CB2CC29D.Text = "Thêm";
		CB2CC29D.UseVisualStyleBackColor = false;
		CB2CC29D.Click += new System.EventHandler(CB2CC29D_Click);
		B49AF283.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B49AF283.BackColor = System.Drawing.Color.White;
		B49AF283.BorderRadius = 0;
		B49AF283.BottomSahddow = true;
		B49AF283.color = System.Drawing.Color.DarkViolet;
		B49AF283.Controls.Add(CE95DD12);
		B49AF283.LeftSahddow = false;
		B49AF283.Location = new System.Drawing.Point(1, 0);
		B49AF283.Name = "bunifuCards1";
		B49AF283.RightSahddow = true;
		B49AF283.ShadowDepth = 20;
		B49AF283.Size = new System.Drawing.Size(684, 37);
		B49AF283.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(687, 437);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDSeedingByVideo";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D5A35A22);
		CE95DD12.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)C49E1830).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		E63BDBA1.ResumeLayout(false);
		E63BDBA1.PerformLayout();
		plVideo.ResumeLayout(false);
		plVideo.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		B49AF283.ResumeLayout(false);
		ResumeLayout(false);
	}
}
