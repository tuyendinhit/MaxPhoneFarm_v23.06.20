using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDBaiVietNewsfeed : Form
{
	internal JObject A6861B3E;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl FF08D386;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudDelayFrom;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox txtTenHanhDong;

	internal Label label7;

	internal Label label3;

	internal Label CF0ECA06;

	internal Label label4;

	internal Label label5;

	internal Label F42762AC;

	internal Label label1;

	internal Button D339973B;

	internal Button A406093A;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel CF8F593C;

	internal Panel plComment;

	internal Label D6B8CC33;

	internal CheckBox A00B99B5;

	internal CheckBox B69FB514;

	internal CheckBox D438C60C;

	internal RichTextBox EB938E0B;

	internal Button btnDown;

	internal Button btnUp;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton BF80A1BF;

	internal Label BDAC223B;

	internal Label label8;

	internal Button button2;

	public fHDBaiVietNewsfeed(string A61EDF39, int CE81CFAC = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = A61EDF39;
		string_2 = string_3;
		int_0 = CE81CFAC;
		string json = "";
		switch (CE81CFAC)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDBaiVietNewsfeed");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			A406093A.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		A6861B3E = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(CF8F593C);
		Language.smethod_1(label1);
		Language.smethod_1(F42762AC);
		Language.smethod_1(label3);
		Language.smethod_1(label4);
		Language.smethod_1(label5);
		Language.smethod_1(label7);
		Language.smethod_1(CF0ECA06);
		Language.smethod_1(D438C60C);
		Language.smethod_1(A00B99B5);
		Language.smethod_1(D6B8CC33);
		Language.smethod_1(button2);
		Language.smethod_1(label8);
		Language.smethod_1(A406093A);
		Language.smethod_1(D339973B);
	}

	private void D62B95A1(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(A6861B3E["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(A6861B3E["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(A6861B3E["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(A6861B3E["nudDelayTo"]);
			B69FB514.Checked = Convert.ToBoolean(A6861B3E["ckbInteract"]);
			D438C60C.Checked = Convert.ToBoolean(A6861B3E["ckbShareWall"]);
			A00B99B5.Checked = Convert.ToBoolean(A6861B3E["ckbComment"]);
			EB938E0B.Text = A6861B3E["txtComment"]!.ToString();
			if (Convert.ToInt32(A6861B3E["typeNganCach"]) == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				BF80A1BF.Checked = true;
			}
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

	private void A406093A_Click(object sender, EventArgs e)
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
			if (A00B99B5.Checked)
			{
				List<string> f1808BA = EB938E0B.Lines.ToList();
				f1808BA = Common.RemoveEmptyItems(f1808BA);
				if (f1808BA.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
					return;
				}
			}
			JSON_Settings f72FAFBC = new JSON_Settings();
			f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
			f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
			f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
			f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
			f72FAFBC.GetValue("ckbInteract", B69FB514.Checked);
			f72FAFBC.GetValue("ckbShareWall", D438C60C.Checked);
			f72FAFBC.GetValue("ckbComment", A00B99B5.Checked);
			f72FAFBC.GetValue("txtComment", (object)EB938E0B.Text.Trim());
			int num = 0;
			if (rbNganCachKyTu.Checked)
			{
				num = 1;
			}
			f72FAFBC.GetValue("typeNganCach", num);
			string d9253C2E = f72FAFBC.C71A4EA4();
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
			if (A00B99B5.Checked)
			{
				List<string> f1808BA2 = EB938E0B.Lines.ToList();
				f1808BA2 = Common.RemoveEmptyItems(f1808BA2);
				if (f1808BA2.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
					return;
				}
			}
			JSON_Settings f72FAFBC2 = new JSON_Settings();
			f72FAFBC2.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
			f72FAFBC2.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
			f72FAFBC2.GetValue("nudDelayFrom", nudDelayFrom.Value);
			f72FAFBC2.GetValue("nudDelayTo", nudDelayTo.Value);
			f72FAFBC2.GetValue("ckbInteract", B69FB514.Checked);
			f72FAFBC2.GetValue("ckbShareWall", D438C60C.Checked);
			f72FAFBC2.GetValue("ckbComment", A00B99B5.Checked);
			f72FAFBC2.GetValue("txtComment", (object)EB938E0B.Text.Trim());
			int num2 = 0;
			if (rbNganCachKyTu.Checked)
			{
				num2 = 1;
			}
			f72FAFBC2.GetValue("typeNganCach", num2);
			string text3 = f72FAFBC2.C71A4EA4();
			if (Class123.smethod_14(string_2, text2, text3))
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

	private void D339973B_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BB395630(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void F100D29B(object sender, EventArgs e)
	{
	}

	private void D83DBE1E(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = EB938E0B.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			D6B8CC33.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		method_2(null, null);
		A00B99B5_CheckedChanged(null, null);
		BF80A1BF_CheckedChanged(null, null);
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void A00B99B5_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = A00B99B5.Checked;
	}

	private void A3BDF5AB(object sender, EventArgs e)
	{
		method_3();
	}

	private void method_3()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!BF80A1BF.Checked) ? EB938E0B.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : EB938E0B.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			D6B8CC33.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void BE0F9191(object sender, EventArgs e)
	{
		plComment.Height = 205;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		plComment.Height = 165;
	}

	private void BF80A1BF_CheckedChanged(object sender, EventArgs e)
	{
		method_3();
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void D595E390(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBaiVietNewsfeed));
		FF08D386 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		CF8F593C = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plComment = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		EB938E0B = new System.Windows.Forms.RichTextBox();
		btnDown = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		BF80A1BF = new System.Windows.Forms.RadioButton();
		BDAC223B = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		D6B8CC33 = new System.Windows.Forms.Label();
		A00B99B5 = new System.Windows.Forms.CheckBox();
		D438C60C = new System.Windows.Forms.CheckBox();
		B69FB514 = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		CF0ECA06 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		F42762AC = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		D339973B = new System.Windows.Forms.Button();
		A406093A = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		FF08D386.Fixed = true;
		FF08D386.Horizontal = true;
		FF08D386.TargetControl = CF8F593C;
		FF08D386.Vertical = true;
		CF8F593C.BackColor = System.Drawing.Color.Transparent;
		CF8F593C.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CF8F593C.Dock = System.Windows.Forms.DockStyle.Fill;
		CF8F593C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CF8F593C.ForeColor = System.Drawing.Color.Black;
		CF8F593C.Location = new System.Drawing.Point(0, 0);
		CF8F593C.Name = "bunifuCustomLabel1";
		CF8F593C.Size = new System.Drawing.Size(359, 31);
		CF8F593C.TabIndex = 12;
		CF8F593C.Text = "Cấu hình Bài viết Newsfeed";
		CF8F593C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(CF8F593C);
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
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(A00B99B5);
		panel1.Controls.Add(D438C60C);
		panel1.Controls.Add(B69FB514);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(CF0ECA06);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(F42762AC);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(D339973B);
		panel1.Controls.Add(A406093A);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 436);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(BB395630);
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(button2);
		plComment.Controls.Add(EB938E0B);
		plComment.Controls.Add(btnDown);
		plComment.Controls.Add(btnUp);
		plComment.Controls.Add(rbNganCachKyTu);
		plComment.Controls.Add(BF80A1BF);
		plComment.Controls.Add(BDAC223B);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(D6B8CC33);
		plComment.Location = new System.Drawing.Point(48, 218);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(278, 165);
		plComment.TabIndex = 8;
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(196, 2);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(23, 23);
		button2.TabIndex = 126;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(D595E390);
		EB938E0B.Location = new System.Drawing.Point(7, 27);
		EB938E0B.Name = "txtComment";
		EB938E0B.Size = new System.Drawing.Size(263, 111);
		EB938E0B.TabIndex = 114;
		EB938E0B.Text = "";
		EB938E0B.WordWrap = false;
		EB938E0B.TextChanged += new System.EventHandler(A3BDF5AB);
		btnDown.BackgroundImage = Resource.Bitmap_91;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.Location = new System.Drawing.Point(221, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 112;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Visible = false;
		btnDown.Click += new System.EventHandler(BE0F9191);
		btnUp.BackgroundImage = Resource.Bitmap_73;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.Location = new System.Drawing.Point(252, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 113;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Visible = false;
		btnUp.Click += new System.EventHandler(btnUp_Click);
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(68, 182);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(203, 20);
		rbNganCachKyTu.TabIndex = 111;
		rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(BF80A1BF_CheckedChanged);
		BF80A1BF.AutoSize = true;
		BF80A1BF.Checked = true;
		BF80A1BF.Cursor = System.Windows.Forms.Cursors.Hand;
		BF80A1BF.Location = new System.Drawing.Point(68, 161);
		BF80A1BF.Name = "rbNganCachMoiDong";
		BF80A1BF.Size = new System.Drawing.Size(171, 20);
		BF80A1BF.TabIndex = 110;
		BF80A1BF.TabStop = true;
		BF80A1BF.Text = "Mỗi dòng là một nội dung";
		BF80A1BF.UseVisualStyleBackColor = true;
		BF80A1BF.CheckedChanged += new System.EventHandler(BF80A1BF_CheckedChanged);
		BDAC223B.AutoSize = true;
		BDAC223B.Location = new System.Drawing.Point(3, 161);
		BDAC223B.Name = "label9";
		BDAC223B.Size = new System.Drawing.Size(65, 16);
		BDAC223B.TabIndex = 109;
		BDAC223B.Text = "Tùy chọn:";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(3, 142);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(266, 16);
		label8.TabIndex = 107;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		D6B8CC33.AutoSize = true;
		D6B8CC33.Location = new System.Drawing.Point(4, 4);
		D6B8CC33.Name = "lblStatus";
		D6B8CC33.Size = new System.Drawing.Size(140, 16);
		D6B8CC33.TabIndex = 0;
		D6B8CC33.Text = "Nội dung bình luận (0):";
		A00B99B5.AutoSize = true;
		A00B99B5.Cursor = System.Windows.Forms.Cursors.Hand;
		A00B99B5.Location = new System.Drawing.Point(30, 193);
		A00B99B5.Name = "ckbComment";
		A00B99B5.Size = new System.Drawing.Size(131, 20);
		A00B99B5.TabIndex = 7;
		A00B99B5.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		A00B99B5.UseVisualStyleBackColor = true;
		A00B99B5.CheckedChanged += new System.EventHandler(A00B99B5_CheckedChanged);
		D438C60C.AutoSize = true;
		D438C60C.Cursor = System.Windows.Forms.Cursors.Hand;
		D438C60C.Location = new System.Drawing.Point(30, 167);
		D438C60C.Name = "ckbShareWall";
		D438C60C.Size = new System.Drawing.Size(123, 20);
		D438C60C.TabIndex = 6;
		D438C60C.Text = "Chia sẻ về tường";
		D438C60C.UseVisualStyleBackColor = true;
		B69FB514.AutoSize = true;
		B69FB514.Cursor = System.Windows.Forms.Cursors.Hand;
		B69FB514.Location = new System.Drawing.Point(30, 141);
		B69FB514.Name = "ckbInteract";
		B69FB514.Size = new System.Drawing.Size(49, 20);
		B69FB514.TabIndex = 5;
		B69FB514.Text = "Like";
		B69FB514.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new System.Drawing.Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Location = new System.Drawing.Point(194, 113);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Location = new System.Drawing.Point(194, 82);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		CF0ECA06.AutoSize = true;
		CF0ECA06.Location = new System.Drawing.Point(290, 113);
		CF0ECA06.Name = "label6";
		CF0ECA06.Size = new System.Drawing.Size(31, 16);
		CF0ECA06.TabIndex = 36;
		CF0ECA06.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(290, 82);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(25, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0300i";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 113);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(90, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		F42762AC.AutoSize = true;
		F42762AC.Location = new System.Drawing.Point(27, 82);
		F42762AC.Name = "label2";
		F42762AC.Size = new System.Drawing.Size(109, 16);
		F42762AC.TabIndex = 32;
		F42762AC.Text = "Sô\u0301 lươ\u0323ng ba\u0300i viê\u0301t:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		D339973B.BackColor = System.Drawing.Color.Maroon;
		D339973B.Cursor = System.Windows.Forms.Cursors.Hand;
		D339973B.FlatAppearance.BorderSize = 0;
		D339973B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D339973B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D339973B.ForeColor = System.Drawing.Color.White;
		D339973B.Location = new System.Drawing.Point(189, 393);
		D339973B.Name = "btnCancel";
		D339973B.Size = new System.Drawing.Size(92, 29);
		D339973B.TabIndex = 10;
		D339973B.Text = "Đóng";
		D339973B.UseVisualStyleBackColor = false;
		D339973B.Click += new System.EventHandler(D339973B_Click);
		A406093A.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		A406093A.Cursor = System.Windows.Forms.Cursors.Hand;
		A406093A.FlatAppearance.BorderSize = 0;
		A406093A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A406093A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A406093A.ForeColor = System.Drawing.Color.White;
		A406093A.Location = new System.Drawing.Point(82, 393);
		A406093A.Name = "btnAdd";
		A406093A.Size = new System.Drawing.Size(92, 29);
		A406093A.TabIndex = 9;
		A406093A.Text = "Thêm";
		A406093A.UseVisualStyleBackColor = false;
		A406093A.Click += new System.EventHandler(A406093A_Click);
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
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietNewsfeed";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D62B95A1);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
