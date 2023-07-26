using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacNewsfeed : Form
{
	internal JSON_Settings FB91A822 = null;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl A337C792;

	internal BunifuDragControl CAA27503;

	internal Panel FB377F16;

	internal NumericUpDown nudTimeTo;

	internal NumericUpDown nudTimeFrom;

	internal TextBox txtTenHanhDong;

	internal Label D7B11B21;

	internal Label label4;

	internal Label label2;

	internal Label C0BB3802;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel DD358499;

	internal Button button1;

	internal PictureBox A28E94B9;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal CheckBox ckbComment;

	internal CheckBox ckbInteract;

	internal CheckBox E6185D9D;

	internal Panel plCountComment;

	internal NumericUpDown nudCountCommentFrom;

	internal Label EB02E737;

	internal Label label14;

	internal NumericUpDown nudCountCommentTo;

	internal Panel plCountShareWall;

	internal NumericUpDown nudCountShareFrom;

	internal Label C32F0937;

	internal Label label12;

	internal NumericUpDown C82AEA8E;

	internal Panel C23E2C8D;

	internal NumericUpDown F299902A;

	internal Label label9;

	internal Label label10;

	internal NumericUpDown nudCountLikeTo;

	internal Panel plComment;

	internal RichTextBox D122A536;

	internal Button btnDown;

	internal Button btnUp;

	internal Label label8;

	internal Label EC961CA2;

	internal Label F0B84114;

	internal Button button3;

	internal Button button2;

	internal RadioButton DD2D1D84;

	internal RadioButton rbNganCachMoiDong;

	public fHDTuongTacNewsfeed(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDTuongTacNewsfeed").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacNewsfeed', 'Tương tác Newsfeed');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDTuongTacNewsfeed");
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
		FB91A822 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void D980F7B1()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(C0BB3802);
		Language.smethod_1(label2);
		Language.smethod_1(D7B11B21);
		Language.smethod_1(label4);
		Language.smethod_1(label10);
		Language.smethod_1(label9);
		Language.smethod_1(label12);
		Language.smethod_1(C32F0937);
		Language.smethod_1(label14);
		Language.smethod_1(EB02E737);
		Language.smethod_1(F0B84114);
		Language.smethod_1(EC961CA2);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
		Language.smethod_1(ckbInteract);
	}

	private void fHDTuongTacNewsfeed_Load(object sender, EventArgs e)
	{
		try
		{
			nudTimeFrom.Value = FB91A822.method_0("nudTimeFrom", 10);
			nudTimeTo.Value = FB91A822.method_0("nudTimeTo", 30);
			F299902A.Value = FB91A822.method_0("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = FB91A822.method_0("nudCountLikeTo", 3);
			nudCountShareFrom.Value = FB91A822.method_0("nudCountShareFrom", 1);
			C82AEA8E.Value = FB91A822.method_0("nudCountShareTo", 3);
			nudCountCommentFrom.Value = FB91A822.method_0("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = FB91A822.method_0("nudCountCommentTo", 3);
			ckbInteract.Checked = FB91A822.AA824D29("ckbInteract");
			E6185D9D.Checked = FB91A822.AA824D29("ckbShareWall");
			ckbComment.Checked = FB91A822.AA824D29("ckbComment");
			D122A536.Text = FB91A822.GetValue("txtComment");
			if (FB91A822.method_0("typeNganCach") == 1)
			{
				DD2D1D84.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
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

	private void C286F50C(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> f1808BA = D122A536.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudTimeFrom", nudTimeFrom.Value);
		f72FAFBC.GetValue("nudTimeTo", nudTimeTo.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		f72FAFBC.GetValue("ckbShareWall", E6185D9D.Checked);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)D122A536.Text.Trim());
		f72FAFBC.GetValue("nudCountLikeFrom", F299902A.Value);
		f72FAFBC.GetValue("nudCountLikeTo", nudCountLikeTo.Value);
		f72FAFBC.GetValue("nudCountShareFrom", nudCountShareFrom.Value);
		f72FAFBC.GetValue("nudCountShareTo", C82AEA8E.Value);
		f72FAFBC.GetValue("nudCountCommentFrom", nudCountCommentFrom.Value);
		f72FAFBC.GetValue("nudCountCommentTo", nudCountCommentTo.Value);
		int num = 0;
		if (DD2D1D84.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FB377F16_Paint(object sender, PaintEventArgs e)
	{
		if (FB377F16.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, FB377F16.ClientSize.Width - num, FB377F16.ClientSize.Height - num));
		}
	}

	private void D122A536_TextChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? D122A536.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : D122A536.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			F0B84114.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		ckbInteract_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
		FF29A808(null, null);
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		C23E2C8D.Enabled = ckbInteract.Checked;
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plCountComment.Enabled = ckbComment.Checked;
		plComment.Enabled = ckbComment.Checked;
	}

	private void FF29A808(object sender, EventArgs e)
	{
		plCountShareWall.Enabled = E6185D9D.Checked;
	}

	private void D888DBAB(object sender, EventArgs e)
	{
		plComment.Height = 207;
	}

	private void A2868109(object sender, EventArgs e)
	{
		plComment.Height = 163;
	}

	private void A28E94B9_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		method_0();
	}

	private void DE18C714(object sender, EventArgs e)
	{
		method_0();
	}

	private void A084591B(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	protected override void Dispose(bool EA35548D)
	{
		if (EA35548D && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(EA35548D);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacNewsfeed));
		A337C792 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		CAA27503 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		DD358499 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		A28E94B9 = new System.Windows.Forms.PictureBox();
		FB377F16 = new System.Windows.Forms.Panel();
		plComment = new System.Windows.Forms.Panel();
		button3 = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		DD2D1D84 = new System.Windows.Forms.RadioButton();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		D122A536 = new System.Windows.Forms.RichTextBox();
		btnDown = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		label8 = new System.Windows.Forms.Label();
		EC961CA2 = new System.Windows.Forms.Label();
		F0B84114 = new System.Windows.Forms.Label();
		plCountComment = new System.Windows.Forms.Panel();
		nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		EB02E737 = new System.Windows.Forms.Label();
		label14 = new System.Windows.Forms.Label();
		nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		plCountShareWall = new System.Windows.Forms.Panel();
		nudCountShareFrom = new System.Windows.Forms.NumericUpDown();
		C32F0937 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		C82AEA8E = new System.Windows.Forms.NumericUpDown();
		C23E2C8D = new System.Windows.Forms.Panel();
		F299902A = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		ckbComment = new System.Windows.Forms.CheckBox();
		E6185D9D = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudTimeTo = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		D7B11B21 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		C0BB3802 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		DD358499.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A28E94B9).BeginInit();
		FB377F16.SuspendLayout();
		plComment.SuspendLayout();
		plCountComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).BeginInit();
		plCountShareWall.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)C82AEA8E).BeginInit();
		C23E2C8D.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F299902A).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		A337C792.Fixed = true;
		A337C792.Horizontal = true;
		A337C792.TargetControl = bunifuCustomLabel1;
		A337C792.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Newsfeed";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		CAA27503.Fixed = true;
		CAA27503.Horizontal = true;
		CAA27503.TargetControl = DD358499;
		CAA27503.Vertical = true;
		DD358499.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DD358499.BackColor = System.Drawing.Color.White;
		DD358499.Controls.Add(button1);
		DD358499.Controls.Add(A28E94B9);
		DD358499.Controls.Add(bunifuCustomLabel1);
		DD358499.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DD358499.Location = new System.Drawing.Point(0, 3);
		DD358499.Name = "pnlHeader";
		DD358499.Size = new System.Drawing.Size(359, 31);
		DD358499.TabIndex = 9;
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
		A28E94B9.Cursor = System.Windows.Forms.Cursors.Default;
		A28E94B9.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		A28E94B9.Location = new System.Drawing.Point(3, 2);
		A28E94B9.Name = "pictureBox1";
		A28E94B9.Size = new System.Drawing.Size(34, 27);
		A28E94B9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A28E94B9.TabIndex = 76;
		A28E94B9.TabStop = false;
		A28E94B9.Click += new System.EventHandler(A28E94B9_Click);
		FB377F16.BackColor = System.Drawing.Color.White;
		FB377F16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FB377F16.Controls.Add(plComment);
		FB377F16.Controls.Add(plCountComment);
		FB377F16.Controls.Add(plCountShareWall);
		FB377F16.Controls.Add(C23E2C8D);
		FB377F16.Controls.Add(ckbComment);
		FB377F16.Controls.Add(E6185D9D);
		FB377F16.Controls.Add(ckbInteract);
		FB377F16.Controls.Add(nudTimeTo);
		FB377F16.Controls.Add(nudTimeFrom);
		FB377F16.Controls.Add(txtTenHanhDong);
		FB377F16.Controls.Add(D7B11B21);
		FB377F16.Controls.Add(label4);
		FB377F16.Controls.Add(label2);
		FB377F16.Controls.Add(C0BB3802);
		FB377F16.Controls.Add(btnCancel);
		FB377F16.Controls.Add(btnAdd);
		FB377F16.Controls.Add(bunifuCards1);
		FB377F16.Cursor = System.Windows.Forms.Cursors.Arrow;
		FB377F16.Dock = System.Windows.Forms.DockStyle.Fill;
		FB377F16.Location = new System.Drawing.Point(0, 0);
		FB377F16.Name = "panel1";
		FB377F16.Size = new System.Drawing.Size(362, 415);
		FB377F16.TabIndex = 0;
		FB377F16.Paint += new System.Windows.Forms.PaintEventHandler(FB377F16_Paint);
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(button3);
		plComment.Controls.Add(button2);
		plComment.Controls.Add(DD2D1D84);
		plComment.Controls.Add(rbNganCachMoiDong);
		plComment.Controls.Add(D122A536);
		plComment.Controls.Add(btnDown);
		plComment.Controls.Add(btnUp);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(EC961CA2);
		plComment.Controls.Add(F0B84114);
		plComment.Location = new System.Drawing.Point(50, 192);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(281, 163);
		plComment.TabIndex = 42;
		button3.Cursor = System.Windows.Forms.Cursors.Help;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(224, 183);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(21, 23);
		button3.TabIndex = 111;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(224, 160);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 23);
		button2.TabIndex = 112;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		DD2D1D84.AutoSize = true;
		DD2D1D84.Cursor = System.Windows.Forms.Cursors.Hand;
		DD2D1D84.Location = new System.Drawing.Point(69, 181);
		DD2D1D84.Name = "rbNganCachKyTu";
		DD2D1D84.Size = new System.Drawing.Size(159, 20);
		DD2D1D84.TabIndex = 110;
		DD2D1D84.Text = "Nội dung có nhiều dòng";
		DD2D1D84.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(69, 160);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		rbNganCachMoiDong.TabIndex = 109;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		D122A536.Location = new System.Drawing.Point(7, 27);
		D122A536.Name = "txtComment";
		D122A536.Size = new System.Drawing.Size(266, 111);
		D122A536.TabIndex = 106;
		D122A536.Text = "";
		D122A536.WordWrap = false;
		D122A536.TextChanged += new System.EventHandler(D122A536_TextChanged);
		btnDown.BackgroundImage = Resource.Bitmap_91;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Location = new System.Drawing.Point(224, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 7;
		btnDown.Visible = false;
		btnDown.Click += new System.EventHandler(D888DBAB);
		btnUp.BackgroundImage = Resource.Bitmap_73;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Location = new System.Drawing.Point(255, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 7;
		btnUp.Visible = false;
		btnUp.Click += new System.EventHandler(A2868109);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 161);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(64, 16);
		label8.TabIndex = 4;
		label8.Text = "Tùy chọn:";
		EC961CA2.AutoSize = true;
		EC961CA2.Location = new System.Drawing.Point(4, 141);
		EC961CA2.Name = "label15";
		EC961CA2.Size = new System.Drawing.Size(265, 16);
		EC961CA2.TabIndex = 0;
		EC961CA2.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		F0B84114.AutoSize = true;
		F0B84114.Location = new System.Drawing.Point(3, 5);
		F0B84114.Name = "lblStatus";
		F0B84114.Size = new System.Drawing.Size(139, 16);
		F0B84114.TabIndex = 0;
		F0B84114.Text = "Nội dung bình luận (0):";
		plCountComment.Controls.Add(nudCountCommentFrom);
		plCountComment.Controls.Add(EB02E737);
		plCountComment.Controls.Add(label14);
		plCountComment.Controls.Add(nudCountCommentTo);
		plCountComment.Location = new System.Drawing.Point(136, 163);
		plCountComment.Name = "plCountComment";
		plCountComment.Size = new System.Drawing.Size(195, 25);
		plCountComment.TabIndex = 41;
		nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentFrom.Name = "nudCountCommentFrom";
		nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		nudCountCommentFrom.TabIndex = 1;
		EB02E737.AutoSize = true;
		EB02E737.Location = new System.Drawing.Point(157, 3);
		EB02E737.Name = "label13";
		EB02E737.Size = new System.Drawing.Size(24, 16);
		EB02E737.TabIndex = 35;
		EB02E737.Text = "lần";
		label14.Location = new System.Drawing.Point(63, 3);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(29, 16);
		label14.TabIndex = 37;
		label14.Text = "đê\u0301n";
		label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
		nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentTo.Name = "nudCountCommentTo";
		nudCountCommentTo.Size = new System.Drawing.Size(56, 23);
		nudCountCommentTo.TabIndex = 2;
		plCountShareWall.Controls.Add(nudCountShareFrom);
		plCountShareWall.Controls.Add(C32F0937);
		plCountShareWall.Controls.Add(label12);
		plCountShareWall.Controls.Add(C82AEA8E);
		plCountShareWall.Location = new System.Drawing.Point(136, 134);
		plCountShareWall.Name = "plCountShareWall";
		plCountShareWall.Size = new System.Drawing.Size(195, 25);
		plCountShareWall.TabIndex = 40;
		nudCountShareFrom.Location = new System.Drawing.Point(1, 1);
		nudCountShareFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountShareFrom.Name = "nudCountShareFrom";
		nudCountShareFrom.Size = new System.Drawing.Size(56, 23);
		nudCountShareFrom.TabIndex = 1;
		C32F0937.AutoSize = true;
		C32F0937.Location = new System.Drawing.Point(157, 3);
		C32F0937.Name = "label11";
		C32F0937.Size = new System.Drawing.Size(24, 16);
		C32F0937.TabIndex = 35;
		C32F0937.Text = "lần";
		label12.Location = new System.Drawing.Point(63, 3);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(29, 16);
		label12.TabIndex = 37;
		label12.Text = "đê\u0301n";
		label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C82AEA8E.Location = new System.Drawing.Point(98, 1);
		C82AEA8E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C82AEA8E.Name = "nudCountShareTo";
		C82AEA8E.Size = new System.Drawing.Size(56, 23);
		C82AEA8E.TabIndex = 2;
		C23E2C8D.Controls.Add(F299902A);
		C23E2C8D.Controls.Add(label9);
		C23E2C8D.Controls.Add(label10);
		C23E2C8D.Controls.Add(nudCountLikeTo);
		C23E2C8D.Location = new System.Drawing.Point(136, 105);
		C23E2C8D.Name = "plCountLike";
		C23E2C8D.Size = new System.Drawing.Size(195, 25);
		C23E2C8D.TabIndex = 39;
		F299902A.Location = new System.Drawing.Point(1, 1);
		F299902A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F299902A.Name = "nudCountLikeFrom";
		F299902A.Size = new System.Drawing.Size(56, 23);
		F299902A.TabIndex = 1;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(157, 3);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(24, 16);
		label9.TabIndex = 35;
		label9.Text = "lần";
		label10.Location = new System.Drawing.Point(63, 3);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(29, 16);
		label10.TabIndex = 37;
		label10.Text = "đê\u0301n";
		label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountLikeTo.Location = new System.Drawing.Point(98, 1);
		nudCountLikeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeTo.Name = "nudCountLikeTo";
		nudCountLikeTo.Size = new System.Drawing.Size(56, 23);
		nudCountLikeTo.TabIndex = 2;
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(30, 165);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(81, 20);
		ckbComment.TabIndex = 7;
		ckbComment.Text = "Comment";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		E6185D9D.AutoSize = true;
		E6185D9D.Cursor = System.Windows.Forms.Cursors.Hand;
		E6185D9D.Location = new System.Drawing.Point(30, 136);
		E6185D9D.Name = "ckbShareWall";
		E6185D9D.Size = new System.Drawing.Size(89, 20);
		E6185D9D.TabIndex = 6;
		E6185D9D.Text = "Share Wall";
		E6185D9D.UseVisualStyleBackColor = true;
		E6185D9D.CheckedChanged += new System.EventHandler(FF29A808);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 107);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(75, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Cảm xúc";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		nudTimeTo.Location = new System.Drawing.Point(234, 77);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new System.Drawing.Size(56, 23);
		nudTimeTo.TabIndex = 2;
		nudTimeFrom.Location = new System.Drawing.Point(137, 77);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(137, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		D7B11B21.Location = new System.Drawing.Point(199, 79);
		D7B11B21.Name = "label3";
		D7B11B21.Size = new System.Drawing.Size(29, 16);
		D7B11B21.TabIndex = 37;
		D7B11B21.Text = "đê\u0301n";
		D7B11B21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(292, 79);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(30, 16);
		label4.TabIndex = 35;
		label4.Text = "giây";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 79);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(91, 16);
		label2.TabIndex = 32;
		label2.Text = "Thơ\u0300i gian lươ\u0301t:";
		C0BB3802.AutoSize = true;
		C0BB3802.Location = new System.Drawing.Point(27, 52);
		C0BB3802.Name = "label1";
		C0BB3802.Size = new System.Drawing.Size(98, 16);
		C0BB3802.TabIndex = 31;
		C0BB3802.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 371);
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
		btnAdd.Location = new System.Drawing.Point(82, 371);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(C286F50C);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(DD358499);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 415);
		base.Controls.Add(FB377F16);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacNewsfeed";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTuongTacNewsfeed_Load);
		DD358499.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A28E94B9).EndInit();
		FB377F16.ResumeLayout(false);
		FB377F16.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		plCountComment.ResumeLayout(false);
		plCountComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).EndInit();
		plCountShareWall.ResumeLayout(false);
		plCountShareWall.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)C82AEA8E).EndInit();
		C23E2C8D.ResumeLayout(false);
		C23E2C8D.PerformLayout();
		((System.ComponentModel.ISupportInitialize)F299902A).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
