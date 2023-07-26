using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXemWatchTheoTuKhoa : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string B19E940D;

	internal int AD053C38;

	internal static bool bool_0;

	internal IContainer E9352F8D = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label A5335EB2;

	internal Label label1;

	internal Button btnCancel;

	internal Button DE0AA106;

	internal BunifuCards E3BD6E11;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label label8;

	internal Label AF320C39;

	internal CheckBox FAB8463B;

	internal CheckBox ckbInteract;

	internal CheckBox ckbShareWall;

	internal Panel F2AAD199;

	internal NumericUpDown nudCountCommentFrom;

	internal Label label13;

	internal Label label14;

	internal NumericUpDown nudCountCommentTo;

	internal Panel plCountShareWall;

	internal NumericUpDown nudCountShareFrom;

	internal Label label11;

	internal Label D3BE5B2E;

	internal NumericUpDown BDBC642F;

	internal Panel B336A9BF;

	internal NumericUpDown nudCountLikeFrom;

	internal Label label9;

	internal Label DF876B35;

	internal NumericUpDown nudCountLikeTo;

	internal RichTextBox DCB614B0;

	internal RichTextBox txtTuKhoa;

	internal Label label16;

	internal Label DEB09D81;

	internal NumericUpDown C7B8ECBF;

	internal NumericUpDown nudTimeFrom;

	internal Label E73DA593;

	internal Label label4;

	public fHDXemWatchTheoTuKhoa(string string_2, int AB9CA619 = 0, string A30D6F1F = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		B19E940D = A30D6F1F;
		AD053C38 = AB9CA619;
		if (Class123.C7BE863B("", "HDXemWatchTheoTuKhoa").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDXemWatchTheoTuKhoa', '" + Language.GetValue("Xem watch theo tư\u0300 kho\u0301a") + "');");
		}
		string d399C = "";
		switch (AB9CA619)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDXemWatchTheoTuKhoa");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(A30D6F1F);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			DE0AA106.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
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
		Language.smethod_1(label1);
		Language.smethod_1(E73DA593);
		Language.smethod_1(label4);
		Language.smethod_1(A5335EB2);
		Language.smethod_1(DF876B35);
		Language.smethod_1(label9);
		Language.smethod_1(D3BE5B2E);
		Language.smethod_1(label11);
		Language.smethod_1(label14);
		Language.smethod_1(label13);
		Language.smethod_1(AF320C39);
		Language.smethod_1(label8);
		Language.smethod_1(DE0AA106);
		Language.smethod_1(btnCancel);
		Language.smethod_1(DEB09D81);
	}

	private void fHDXemWatchTheoTuKhoa_Load(object sender, EventArgs e)
	{
		try
		{
			txtTuKhoa.Text = f72FAFBC_0.GetValue("txtTuKhoa");
			nudTimeFrom.Value = f72FAFBC_0.method_0("nudTimeFrom", 30);
			C7B8ECBF.Value = f72FAFBC_0.method_0("nudTimeTo", 30);
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			FAB8463B.Checked = f72FAFBC_0.AA824D29("ckbComment");
			ckbShareWall.Checked = f72FAFBC_0.AA824D29("ckbShareWall");
			DCB614B0.Text = f72FAFBC_0.GetValue("txtComment");
			nudCountLikeFrom.Value = f72FAFBC_0.method_0("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = f72FAFBC_0.method_0("nudCountLikeTo", 3);
			nudCountShareFrom.Value = f72FAFBC_0.method_0("nudCountShareFrom", 1);
			BDBC642F.Value = f72FAFBC_0.method_0("nudCountShareTo", 3);
			nudCountCommentFrom.Value = f72FAFBC_0.method_0("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = f72FAFBC_0.method_0("nudCountCommentTo", 3);
		}
		catch
		{
		}
		C5A7018F();
	}

	private void A4388A32(object sender, EventArgs e)
	{
		Close();
	}

	private void DE0AA106_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (FAB8463B.Checked)
		{
			List<string> f1808BA = DCB614B0.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtTuKhoa", (object)txtTuKhoa.Text.Trim());
		f72FAFBC.GetValue("nudTimeFrom", nudTimeFrom.Value);
		f72FAFBC.GetValue("nudTimeTo", C7B8ECBF.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		f72FAFBC.GetValue("ckbShareWall", ckbShareWall.Checked);
		f72FAFBC.GetValue("ckbComment", FAB8463B.Checked);
		f72FAFBC.GetValue("txtComment", (object)DCB614B0.Text.Trim());
		f72FAFBC.GetValue("nudCountLikeFrom", nudCountLikeFrom.Value);
		f72FAFBC.GetValue("nudCountLikeTo", nudCountLikeTo.Value);
		f72FAFBC.GetValue("nudCountShareFrom", nudCountShareFrom.Value);
		f72FAFBC.GetValue("nudCountShareTo", BDBC642F.Value);
		f72FAFBC.GetValue("nudCountCommentFrom", nudCountCommentFrom.Value);
		f72FAFBC.GetValue("nudCountCommentTo", nudCountCommentTo.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (AD053C38 == 0)
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
			if (Class123.smethod_14(B19E940D, text, text2))
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

	private void E4997B08(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void DCB614B0_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = DCB614B0.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			AF320C39.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void C5A7018F()
	{
		ckbInteract_CheckedChanged(null, null);
		A49B9D13(null, null);
		ckbShareWall_CheckedChanged(null, null);
	}

	private void A49B9D13(object sender, EventArgs e)
	{
		plComment.Enabled = FAB8463B.Checked;
		F2AAD199.Enabled = FAB8463B.Checked;
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		B336A9BF.Enabled = ckbInteract.Checked;
	}

	private void ckbShareWall_CheckedChanged(object sender, EventArgs e)
	{
		plCountShareWall.Enabled = ckbShareWall.Checked;
	}

	private void method_1(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	private void txtTuKhoa_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtTuKhoa.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			label16.Text = string.Format(Language.GetValue("({0})"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && E9352F8D != null)
		{
			E9352F8D.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		E9352F8D = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXemWatchTheoTuKhoa));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(E9352F8D);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(E9352F8D);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		txtTuKhoa = new System.Windows.Forms.RichTextBox();
		F2AAD199 = new System.Windows.Forms.Panel();
		nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		label13 = new System.Windows.Forms.Label();
		label14 = new System.Windows.Forms.Label();
		nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		plCountShareWall = new System.Windows.Forms.Panel();
		nudCountShareFrom = new System.Windows.Forms.NumericUpDown();
		label11 = new System.Windows.Forms.Label();
		D3BE5B2E = new System.Windows.Forms.Label();
		BDBC642F = new System.Windows.Forms.NumericUpDown();
		B336A9BF = new System.Windows.Forms.Panel();
		nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		label9 = new System.Windows.Forms.Label();
		DF876B35 = new System.Windows.Forms.Label();
		nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		plComment = new System.Windows.Forms.Panel();
		DCB614B0 = new System.Windows.Forms.RichTextBox();
		label8 = new System.Windows.Forms.Label();
		AF320C39 = new System.Windows.Forms.Label();
		FAB8463B = new System.Windows.Forms.CheckBox();
		ckbShareWall = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		A5335EB2 = new System.Windows.Forms.Label();
		label16 = new System.Windows.Forms.Label();
		DEB09D81 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		DE0AA106 = new System.Windows.Forms.Button();
		E3BD6E11 = new Bunifu.Framework.UI.BunifuCards();
		C7B8ECBF = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		E73DA593 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		F2AAD199.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).BeginInit();
		plCountShareWall.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)BDBC642F).BeginInit();
		B336A9BF.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).BeginInit();
		plComment.SuspendLayout();
		E3BD6E11.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C7B8ECBF).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
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
		bunifuCustomLabel1.Text = "Cấu hình Xem Watch theo tư\u0300 kho\u0301a";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
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
		button1.Click += new System.EventHandler(A4388A32);
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
		panel1.Controls.Add(C7B8ECBF);
		panel1.Controls.Add(nudTimeFrom);
		panel1.Controls.Add(E73DA593);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(txtTuKhoa);
		panel1.Controls.Add(F2AAD199);
		panel1.Controls.Add(plCountShareWall);
		panel1.Controls.Add(B336A9BF);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(FAB8463B);
		panel1.Controls.Add(ckbShareWall);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(A5335EB2);
		panel1.Controls.Add(label16);
		panel1.Controls.Add(DEB09D81);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(DE0AA106);
		panel1.Controls.Add(E3BD6E11);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 491);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(E4997B08);
		txtTuKhoa.Location = new System.Drawing.Point(132, 77);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new System.Drawing.Size(195, 72);
		txtTuKhoa.TabIndex = 45;
		txtTuKhoa.Text = "";
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += new System.EventHandler(txtTuKhoa_TextChanged);
		F2AAD199.Controls.Add(nudCountCommentFrom);
		F2AAD199.Controls.Add(label13);
		F2AAD199.Controls.Add(label14);
		F2AAD199.Controls.Add(nudCountCommentTo);
		F2AAD199.Location = new System.Drawing.Point(131, 238);
		F2AAD199.Name = "plCountComment";
		F2AAD199.Size = new System.Drawing.Size(195, 25);
		F2AAD199.TabIndex = 44;
		nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentFrom.Name = "nudCountCommentFrom";
		nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		nudCountCommentFrom.TabIndex = 1;
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(159, 3);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(25, 16);
		label13.TabIndex = 35;
		label13.Text = "lần";
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
		plCountShareWall.Controls.Add(label11);
		plCountShareWall.Controls.Add(D3BE5B2E);
		plCountShareWall.Controls.Add(BDBC642F);
		plCountShareWall.Location = new System.Drawing.Point(131, 210);
		plCountShareWall.Name = "plCountShareWall";
		plCountShareWall.Size = new System.Drawing.Size(195, 25);
		plCountShareWall.TabIndex = 43;
		nudCountShareFrom.Location = new System.Drawing.Point(1, 1);
		nudCountShareFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountShareFrom.Name = "nudCountShareFrom";
		nudCountShareFrom.Size = new System.Drawing.Size(56, 23);
		nudCountShareFrom.TabIndex = 1;
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(159, 3);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(25, 16);
		label11.TabIndex = 35;
		label11.Text = "lần";
		D3BE5B2E.Location = new System.Drawing.Point(63, 3);
		D3BE5B2E.Name = "label12";
		D3BE5B2E.Size = new System.Drawing.Size(29, 16);
		D3BE5B2E.TabIndex = 37;
		D3BE5B2E.Text = "đê\u0301n";
		D3BE5B2E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		BDBC642F.Location = new System.Drawing.Point(98, 1);
		BDBC642F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BDBC642F.Name = "nudCountShareTo";
		BDBC642F.Size = new System.Drawing.Size(56, 23);
		BDBC642F.TabIndex = 2;
		B336A9BF.Controls.Add(nudCountLikeFrom);
		B336A9BF.Controls.Add(label9);
		B336A9BF.Controls.Add(DF876B35);
		B336A9BF.Controls.Add(nudCountLikeTo);
		B336A9BF.Location = new System.Drawing.Point(131, 182);
		B336A9BF.Name = "plCountLike";
		B336A9BF.Size = new System.Drawing.Size(195, 25);
		B336A9BF.TabIndex = 42;
		nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeFrom.Name = "nudCountLikeFrom";
		nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		nudCountLikeFrom.TabIndex = 1;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(159, 3);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(25, 16);
		label9.TabIndex = 35;
		label9.Text = "lần";
		DF876B35.Location = new System.Drawing.Point(63, 3);
		DF876B35.Name = "label10";
		DF876B35.Size = new System.Drawing.Size(29, 16);
		DF876B35.TabIndex = 37;
		DF876B35.Text = "đê\u0301n";
		DF876B35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountLikeTo.Location = new System.Drawing.Point(98, 1);
		nudCountLikeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeTo.Name = "nudCountLikeTo";
		nudCountLikeTo.Size = new System.Drawing.Size(56, 23);
		nudCountLikeTo.TabIndex = 2;
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(DCB614B0);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(AF320C39);
		plComment.Location = new System.Drawing.Point(47, 266);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(278, 164);
		plComment.TabIndex = 8;
		DCB614B0.Location = new System.Drawing.Point(6, 24);
		DCB614B0.Name = "txtComment";
		DCB614B0.Size = new System.Drawing.Size(264, 114);
		DCB614B0.TabIndex = 45;
		DCB614B0.Text = "";
		DCB614B0.WordWrap = false;
		DCB614B0.TextChanged += new System.EventHandler(DCB614B0_TextChanged);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 141);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(266, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		AF320C39.AutoSize = true;
		AF320C39.Location = new System.Drawing.Point(3, 5);
		AF320C39.Name = "lblStatus";
		AF320C39.Size = new System.Drawing.Size(140, 16);
		AF320C39.TabIndex = 0;
		AF320C39.Text = "Nội dung bình luận (0):";
		FAB8463B.AutoSize = true;
		FAB8463B.Cursor = System.Windows.Forms.Cursors.Hand;
		FAB8463B.Location = new System.Drawing.Point(29, 240);
		FAB8463B.Name = "ckbComment";
		FAB8463B.Size = new System.Drawing.Size(82, 20);
		FAB8463B.TabIndex = 7;
		FAB8463B.Text = "Comment";
		FAB8463B.UseVisualStyleBackColor = true;
		FAB8463B.CheckedChanged += new System.EventHandler(A49B9D13);
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareWall.Location = new System.Drawing.Point(29, 212);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new System.Drawing.Size(90, 20);
		ckbShareWall.TabIndex = 6;
		ckbShareWall.Text = "Share Wall";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbShareWall.CheckedChanged += new System.EventHandler(ckbShareWall_CheckedChanged);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(29, 184);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(49, 20);
		ckbInteract.TabIndex = 5;
		ckbInteract.Text = "Like";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		A5335EB2.AutoSize = true;
		A5335EB2.Location = new System.Drawing.Point(26, 157);
		A5335EB2.Name = "label5";
		A5335EB2.Size = new System.Drawing.Size(94, 16);
		A5335EB2.TabIndex = 34;
		A5335EB2.Text = "Thơ\u0300i gian xem:";
		label16.Location = new System.Drawing.Point(27, 93);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(89, 16);
		label16.TabIndex = 31;
		label16.Text = "(0)";
		label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DEB09D81.AutoSize = true;
		DEB09D81.Location = new System.Drawing.Point(27, 76);
		DEB09D81.Name = "label15";
		DEB09D81.Size = new System.Drawing.Size(89, 16);
		DEB09D81.TabIndex = 31;
		DEB09D81.Text = "Nhâ\u0323p tư\u0300 kho\u0301a:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 448);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		DE0AA106.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		DE0AA106.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		DE0AA106.Cursor = System.Windows.Forms.Cursors.Hand;
		DE0AA106.FlatAppearance.BorderSize = 0;
		DE0AA106.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DE0AA106.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DE0AA106.ForeColor = System.Drawing.Color.White;
		DE0AA106.Location = new System.Drawing.Point(82, 448);
		DE0AA106.Name = "btnAdd";
		DE0AA106.Size = new System.Drawing.Size(92, 29);
		DE0AA106.TabIndex = 9;
		DE0AA106.Text = "Thêm";
		DE0AA106.UseVisualStyleBackColor = false;
		DE0AA106.Click += new System.EventHandler(DE0AA106_Click);
		E3BD6E11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E3BD6E11.BackColor = System.Drawing.Color.White;
		E3BD6E11.BorderRadius = 0;
		E3BD6E11.BottomSahddow = true;
		E3BD6E11.color = System.Drawing.Color.DarkViolet;
		E3BD6E11.Controls.Add(pnlHeader);
		E3BD6E11.LeftSahddow = false;
		E3BD6E11.Location = new System.Drawing.Point(1, 0);
		E3BD6E11.Name = "bunifuCards1";
		E3BD6E11.RightSahddow = true;
		E3BD6E11.ShadowDepth = 20;
		E3BD6E11.Size = new System.Drawing.Size(359, 37);
		E3BD6E11.TabIndex = 28;
		C7B8ECBF.Location = new System.Drawing.Point(229, 155);
		C7B8ECBF.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C7B8ECBF.Name = "nudTimeTo";
		C7B8ECBF.Size = new System.Drawing.Size(56, 23);
		C7B8ECBF.TabIndex = 51;
		nudTimeFrom.Location = new System.Drawing.Point(132, 155);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 50;
		E73DA593.Location = new System.Drawing.Point(194, 157);
		E73DA593.Name = "label3";
		E73DA593.Size = new System.Drawing.Size(29, 16);
		E73DA593.TabIndex = 53;
		E73DA593.Text = "đê\u0301n";
		E73DA593.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(290, 157);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(31, 16);
		label4.TabIndex = 52;
		label4.Text = "giây";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 491);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXemWatchTheoTuKhoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXemWatchTheoTuKhoa_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		F2AAD199.ResumeLayout(false);
		F2AAD199.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).EndInit();
		plCountShareWall.ResumeLayout(false);
		plCountShareWall.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)BDBC642F).EndInit();
		B336A9BF.ResumeLayout(false);
		B336A9BF.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).EndInit();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		E3BD6E11.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)C7B8ECBF).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		ResumeLayout(false);
	}
}
