using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacReelChiDinh : Form
{
	internal JSON_Settings DD8EDCA1;

	internal string string_0;

	internal string string_1;

	internal string CC133604;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal NumericUpDown nudTimeTo;

	internal NumericUpDown nudTimeFrom;

	internal TextBox txtTenHanhDong;

	internal Label ADB2C898;

	internal Label label5;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards DFABC83B;

	internal Panel D61968BF;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label lblStatus;

	internal CheckBox F823698E;

	internal CheckBox ckbInteract;

	internal CheckBox ckbShareWall;

	internal RichTextBox txtComment;

	internal Label label6;

	internal Label EF3E0601;

	internal Panel DD269B38;

	internal Button C62CDC2D;

	internal RadioButton rbNganCachMoiDong;

	internal Button AF070517;

	internal RadioButton A4AA6418;

	internal Label label3;

	internal Label label11;

	internal RichTextBox txtIdPost;

	public fHDTuongTacReelChiDinh(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		CC133604 = string_3;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Tương tác Reel chỉ định";
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
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		DD8EDCA1 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDTuongTacReelChiDinh_Load(object sender, EventArgs e)
	{
		try
		{
			txtIdPost.Text = DD8EDCA1.GetValue("txtIdPost");
			nudTimeFrom.Value = DD8EDCA1.method_0("nudTimeFrom", 15);
			nudTimeTo.Value = DD8EDCA1.method_0("nudTimeTo", 30);
			ckbInteract.Checked = DD8EDCA1.AA824D29("ckbInteract");
			F823698E.Checked = DD8EDCA1.AA824D29("ckbComment");
			ckbShareWall.Checked = DD8EDCA1.AA824D29("ckbShareWall");
			txtComment.Text = DD8EDCA1.GetValue("txtComment");
			if (DD8EDCA1.method_0("typeNganCach") == 1)
			{
				A4AA6418.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
		}
		catch
		{
		}
		method_0();
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
		if (F823698E.Checked)
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
		f72FAFBC.GetValue("txtIdPost", (object)txtIdPost.Text.Trim());
		f72FAFBC.GetValue("nudTimeFrom", nudTimeFrom.Value);
		f72FAFBC.GetValue("nudTimeTo", nudTimeTo.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		f72FAFBC.GetValue("ckbShareWall", ckbShareWall.Checked);
		f72FAFBC.GetValue("ckbComment", F823698E.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		int num = 0;
		if (A4AA6418.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text2))
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
			if (Class123.smethod_14(CC133604, text, text2))
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

	private void E2BAE70F(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtComment, lblStatus, A4AA6418.Checked ? 1 : 0);
	}

	private void method_0()
	{
		A0B34186(null, null);
		F823698E_CheckedChanged(null, null);
		ckbShareWall_CheckedChanged(null, null);
	}

	private void F823698E_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = F823698E.Checked;
	}

	private void A0B34186(object sender, EventArgs e)
	{
	}

	private void ckbShareWall_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void AF070517_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void C62CDC2D_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void AC8C8D99(object sender, EventArgs e)
	{
		Common.D936DD84(txtComment, lblStatus, A4AA6418.Checked ? 1 : 0);
	}

	private void A4AA6418_CheckedChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtComment, lblStatus, A4AA6418.Checked ? 1 : 0);
	}

	private void B1B86924(object sender, EventArgs e)
	{
		Common.D936DD84(txtIdPost, EF3E0601);
	}

	protected override void Dispose(bool A8A89AA7)
	{
		if (A8A89AA7 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(A8A89AA7);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacReelChiDinh));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D61968BF = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		txtIdPost = new System.Windows.Forms.RichTextBox();
		EF3E0601 = new System.Windows.Forms.Label();
		plComment = new System.Windows.Forms.Panel();
		DD269B38 = new System.Windows.Forms.Panel();
		C62CDC2D = new System.Windows.Forms.Button();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		AF070517 = new System.Windows.Forms.Button();
		A4AA6418 = new System.Windows.Forms.RadioButton();
		label3 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		txtComment = new System.Windows.Forms.RichTextBox();
		lblStatus = new System.Windows.Forms.Label();
		F823698E = new System.Windows.Forms.CheckBox();
		ckbShareWall = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudTimeTo = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		ADB2C898 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		DFABC83B = new Bunifu.Framework.UI.BunifuCards();
		D61968BF.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plComment.SuspendLayout();
		DD269B38.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		DFABC83B.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(683, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Reel chỉ định";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = D61968BF;
		bunifuDragControl_1.Vertical = true;
		D61968BF.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D61968BF.BackColor = System.Drawing.Color.White;
		D61968BF.Controls.Add(button1);
		D61968BF.Controls.Add(pictureBox1);
		D61968BF.Controls.Add(bunifuCustomLabel1);
		D61968BF.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D61968BF.Location = new System.Drawing.Point(0, 3);
		D61968BF.Name = "pnlHeader";
		D61968BF.Size = new System.Drawing.Size(683, 31);
		D61968BF.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(652, 1);
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
		panel1.Controls.Add(txtIdPost);
		panel1.Controls.Add(EF3E0601);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(F823698E);
		panel1.Controls.Add(ckbShareWall);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(nudTimeTo);
		panel1.Controls.Add(nudTimeFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(ADB2C898);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(DFABC83B);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(686, 452);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(E2BAE70F);
		txtIdPost.Location = new System.Drawing.Point(364, 99);
		txtIdPost.Name = "txtIdPost";
		txtIdPost.Size = new System.Drawing.Size(288, 286);
		txtIdPost.TabIndex = 43;
		txtIdPost.Text = "";
		txtIdPost.WordWrap = false;
		txtIdPost.TextChanged += new System.EventHandler(B1B86924);
		EF3E0601.AutoSize = true;
		EF3E0601.Location = new System.Drawing.Point(361, 80);
		EF3E0601.Name = "label2";
		EF3E0601.Size = new System.Drawing.Size(123, 16);
		EF3E0601.TabIndex = 42;
		EF3E0601.Text = "Link thước phim (0):";
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(DD269B38);
		plComment.Controls.Add(label3);
		plComment.Controls.Add(label11);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(lblStatus);
		plComment.Location = new System.Drawing.Point(48, 157);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(278, 228);
		plComment.TabIndex = 8;
		DD269B38.Controls.Add(C62CDC2D);
		DD269B38.Controls.Add(rbNganCachMoiDong);
		DD269B38.Controls.Add(AF070517);
		DD269B38.Controls.Add(A4AA6418);
		DD269B38.Location = new System.Drawing.Point(65, 181);
		DD269B38.Name = "panel2";
		DD269B38.Size = new System.Drawing.Size(200, 43);
		DD269B38.TabIndex = 179;
		C62CDC2D.Cursor = System.Windows.Forms.Cursors.Help;
		C62CDC2D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C62CDC2D.Location = new System.Drawing.Point(165, 22);
		C62CDC2D.Name = "button3";
		C62CDC2D.Size = new System.Drawing.Size(21, 21);
		C62CDC2D.TabIndex = 172;
		C62CDC2D.Text = "?";
		C62CDC2D.UseVisualStyleBackColor = true;
		C62CDC2D.Click += new System.EventHandler(C62CDC2D_Click);
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(3, 3);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		rbNganCachMoiDong.TabIndex = 3;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += new System.EventHandler(AC8C8D99);
		AF070517.Cursor = System.Windows.Forms.Cursors.Help;
		AF070517.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AF070517.Location = new System.Drawing.Point(165, 1);
		AF070517.Name = "button2";
		AF070517.Size = new System.Drawing.Size(21, 21);
		AF070517.TabIndex = 173;
		AF070517.Text = "?";
		AF070517.UseVisualStyleBackColor = true;
		AF070517.Click += new System.EventHandler(AF070517_Click);
		A4AA6418.AutoSize = true;
		A4AA6418.Cursor = System.Windows.Forms.Cursors.Hand;
		A4AA6418.Location = new System.Drawing.Point(3, 24);
		A4AA6418.Name = "rbNganCachKyTu";
		A4AA6418.Size = new System.Drawing.Size(159, 20);
		A4AA6418.TabIndex = 3;
		A4AA6418.Text = "Nội dung có nhiều dòng";
		A4AA6418.UseVisualStyleBackColor = true;
		A4AA6418.CheckedChanged += new System.EventHandler(A4AA6418_CheckedChanged);
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(2, 184);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(64, 16);
		label3.TabIndex = 178;
		label3.Text = "Tùy chọn:";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(3, 162);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(133, 16);
		label11.TabIndex = 177;
		label11.Text = "Spin nội dung {a|b|c}";
		txtComment.Location = new System.Drawing.Point(6, 24);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(264, 135);
		txtComment.TabIndex = 45;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		F823698E.AutoSize = true;
		F823698E.Cursor = System.Windows.Forms.Cursors.Hand;
		F823698E.Location = new System.Drawing.Point(30, 131);
		F823698E.Name = "ckbComment";
		F823698E.Size = new System.Drawing.Size(81, 20);
		F823698E.TabIndex = 7;
		F823698E.Text = "Comment";
		F823698E.UseVisualStyleBackColor = true;
		F823698E.CheckedChanged += new System.EventHandler(F823698E_CheckedChanged);
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareWall.Location = new System.Drawing.Point(132, 105);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new System.Drawing.Size(89, 20);
		ckbShareWall.TabIndex = 6;
		ckbShareWall.Text = "Share Wall";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbShareWall.CheckedChanged += new System.EventHandler(ckbShareWall_CheckedChanged);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 105);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(48, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Like";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(A0B34186);
		nudTimeTo.Location = new System.Drawing.Point(229, 78);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new System.Drawing.Size(56, 23);
		nudTimeTo.TabIndex = 4;
		nudTimeFrom.Location = new System.Drawing.Point(132, 78);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		ADB2C898.Location = new System.Drawing.Point(194, 80);
		ADB2C898.Name = "label7";
		ADB2C898.Size = new System.Drawing.Size(29, 16);
		ADB2C898.TabIndex = 38;
		ADB2C898.Text = "đê\u0301n";
		ADB2C898.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(290, 80);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 80);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(93, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian xem:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
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
		btnCancel.Location = new System.Drawing.Point(351, 410);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(244, 410);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		DFABC83B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DFABC83B.BackColor = System.Drawing.Color.White;
		DFABC83B.BorderRadius = 0;
		DFABC83B.BottomSahddow = true;
		DFABC83B.color = System.Drawing.Color.DarkViolet;
		DFABC83B.Controls.Add(D61968BF);
		DFABC83B.LeftSahddow = false;
		DFABC83B.Location = new System.Drawing.Point(1, 0);
		DFABC83B.Name = "bunifuCards1";
		DFABC83B.RightSahddow = true;
		DFABC83B.ShadowDepth = 20;
		DFABC83B.Size = new System.Drawing.Size(683, 37);
		DFABC83B.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(686, 452);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacReelChiDinh";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTuongTacReelChiDinh_Load);
		D61968BF.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		DD269B38.ResumeLayout(false);
		DD269B38.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		DFABC83B.ResumeLayout(false);
		ResumeLayout(false);
	}
}
