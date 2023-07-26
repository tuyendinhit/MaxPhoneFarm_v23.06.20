using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXemWatch : Form
{
	internal JSON_Settings E886E90B;

	internal string EB0DE799;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer B0A9172B = null;

	internal BunifuDragControl D0A77A3E;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal TextBox DF3E4E9A;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label D0B1400E;

	internal Label lblStatus;

	internal CheckBox ckbComment;

	internal CheckBox E90CDA96;

	internal CheckBox ckbShareWall;

	internal Panel AD29319C;

	internal NumericUpDown E5A24EBF;

	internal Label E78F86AB;

	internal Label label14;

	internal NumericUpDown E227CF07;

	internal Panel plCountShareWall;

	internal NumericUpDown A7219399;

	internal Label label11;

	internal Label label12;

	internal NumericUpDown nudCountShareTo;

	internal Panel plCountLike;

	internal NumericUpDown nudCountLikeFrom;

	internal Label E4A46DAB;

	internal Label label10;

	internal NumericUpDown nudCountLikeTo;

	internal RichTextBox D9134200;

	internal NumericUpDown nudPercentComment;

	internal Label A8ADC593;

	internal Label label19;

	internal NumericUpDown A58DA01E;

	internal Label B434CA8C;

	internal Label label17;

	internal NumericUpDown CD13FF3F;

	internal Label BBB63614;

	internal Label label15;

	internal NumericUpDown nudTimeTo;

	internal NumericUpDown EF18A3AC;

	internal Label C33EE186;

	internal Label label4;

	internal Label label2;

	public fHDXemWatch(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		EB0DE799 = string_2;
		string_1 = string_3;
		int_0 = int_1;
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDXemWatch");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			DF3E4E9A.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			DF3E4E9A.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		E886E90B = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(label2);
		Language.smethod_1(C33EE186);
		Language.smethod_1(label4);
		Language.smethod_1(label10);
		Language.smethod_1(E4A46DAB);
		Language.smethod_1(label12);
		Language.smethod_1(label11);
		Language.smethod_1(label14);
		Language.smethod_1(E78F86AB);
		Language.smethod_1(lblStatus);
		Language.smethod_1(D0B1400E);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void fHDXemWatch_Load(object sender, EventArgs e)
	{
		try
		{
			EF18A3AC.Value = E886E90B.method_0("nudTimeFrom", 30);
			nudTimeTo.Value = E886E90B.method_0("nudTimeTo", 30);
			E90CDA96.Checked = E886E90B.AA824D29("ckbInteract");
			ckbComment.Checked = E886E90B.AA824D29("ckbComment");
			ckbShareWall.Checked = E886E90B.AA824D29("ckbShareWall");
			D9134200.Text = E886E90B.GetValue("txtComment");
			nudCountLikeFrom.Value = E886E90B.method_0("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = E886E90B.method_0("nudCountLikeTo", 3);
			A7219399.Value = E886E90B.method_0("nudCountShareFrom", 1);
			nudCountShareTo.Value = E886E90B.method_0("nudCountShareTo", 3);
			E5A24EBF.Value = E886E90B.method_0("nudCountCommentFrom", 1);
			E227CF07.Value = E886E90B.method_0("nudCountCommentTo", 3);
			CD13FF3F.Value = E886E90B.method_0("nudPercentLike", 50);
			A58DA01E.Value = E886E90B.method_0("nudPercentShare", 50);
			nudPercentComment.Value = E886E90B.method_0("nudPercentComment", 50);
		}
		catch
		{
		}
		method_1();
	}

	private void DC9EF0AE(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = DF3E4E9A.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> f1808BA = D9134200.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudTimeFrom", EF18A3AC.Value);
		f72FAFBC.GetValue("nudTimeTo", nudTimeTo.Value);
		f72FAFBC.GetValue("ckbInteract", E90CDA96.Checked);
		f72FAFBC.GetValue("ckbShareWall", ckbShareWall.Checked);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)D9134200.Text.Trim());
		f72FAFBC.GetValue("nudCountLikeFrom", nudCountLikeFrom.Value);
		f72FAFBC.GetValue("nudCountLikeTo", nudCountLikeTo.Value);
		f72FAFBC.GetValue("nudCountShareFrom", A7219399.Value);
		f72FAFBC.GetValue("nudCountShareTo", nudCountShareTo.Value);
		f72FAFBC.GetValue("nudCountCommentFrom", E5A24EBF.Value);
		f72FAFBC.GetValue("nudCountCommentTo", E227CF07.Value);
		f72FAFBC.GetValue("nudPercentLike", CD13FF3F.Value);
		f72FAFBC.GetValue("nudPercentShare", A58DA01E.Value);
		f72FAFBC.GetValue("nudPercentComment", nudPercentComment.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(EB0DE799, text, string_0, text2))
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

	private void D003DD0A(object sender, EventArgs e)
	{
		Close();
	}

	private void FE0E3606(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void D9134200_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = D9134200.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		E90CDA96_CheckedChanged(null, null);
		D43A2F05(null, null);
		ckbShareWall_CheckedChanged(null, null);
	}

	private void D43A2F05(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
		AD29319C.Enabled = ckbComment.Checked;
	}

	private void E90CDA96_CheckedChanged(object sender, EventArgs e)
	{
		plCountLike.Enabled = E90CDA96.Checked;
	}

	private void ckbShareWall_CheckedChanged(object sender, EventArgs e)
	{
		plCountShareWall.Enabled = ckbShareWall.Checked;
	}

	private void method_2(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && B0A9172B != null)
		{
			B0A9172B.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		B0A9172B = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXemWatch));
		D0A77A3E = new Bunifu.Framework.UI.BunifuDragControl(B0A9172B);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(B0A9172B);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		nudTimeTo = new System.Windows.Forms.NumericUpDown();
		EF18A3AC = new System.Windows.Forms.NumericUpDown();
		C33EE186 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		AD29319C = new System.Windows.Forms.Panel();
		nudPercentComment = new System.Windows.Forms.NumericUpDown();
		E5A24EBF = new System.Windows.Forms.NumericUpDown();
		A8ADC593 = new System.Windows.Forms.Label();
		E78F86AB = new System.Windows.Forms.Label();
		label14 = new System.Windows.Forms.Label();
		label19 = new System.Windows.Forms.Label();
		E227CF07 = new System.Windows.Forms.NumericUpDown();
		plCountShareWall = new System.Windows.Forms.Panel();
		A58DA01E = new System.Windows.Forms.NumericUpDown();
		A7219399 = new System.Windows.Forms.NumericUpDown();
		B434CA8C = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		label17 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		nudCountShareTo = new System.Windows.Forms.NumericUpDown();
		plCountLike = new System.Windows.Forms.Panel();
		CD13FF3F = new System.Windows.Forms.NumericUpDown();
		nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		BBB63614 = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		E4A46DAB = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		plComment = new System.Windows.Forms.Panel();
		D9134200 = new System.Windows.Forms.RichTextBox();
		D0B1400E = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		ckbComment = new System.Windows.Forms.CheckBox();
		ckbShareWall = new System.Windows.Forms.CheckBox();
		E90CDA96 = new System.Windows.Forms.CheckBox();
		DF3E4E9A = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)EF18A3AC).BeginInit();
		AD29319C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudPercentComment).BeginInit();
		((System.ComponentModel.ISupportInitialize)E5A24EBF).BeginInit();
		((System.ComponentModel.ISupportInitialize)E227CF07).BeginInit();
		plCountShareWall.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A58DA01E).BeginInit();
		((System.ComponentModel.ISupportInitialize)A7219399).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountShareTo).BeginInit();
		plCountLike.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)CD13FF3F).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).BeginInit();
		plComment.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D0A77A3E.Fixed = true;
		D0A77A3E.Horizontal = true;
		D0A77A3E.TargetControl = bunifuCustomLabel1;
		D0A77A3E.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(356, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Xem Watch";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(356, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(325, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(DC9EF0AE);
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
		panel1.Controls.Add(nudTimeTo);
		panel1.Controls.Add(EF18A3AC);
		panel1.Controls.Add(C33EE186);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(AD29319C);
		panel1.Controls.Add(plCountShareWall);
		panel1.Controls.Add(plCountLike);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(ckbShareWall);
		panel1.Controls.Add(E90CDA96);
		panel1.Controls.Add(DF3E4E9A);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(359, 424);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(FE0E3606);
		nudTimeTo.Location = new System.Drawing.Point(219, 78);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new System.Drawing.Size(56, 23);
		nudTimeTo.TabIndex = 46;
		EF18A3AC.Location = new System.Drawing.Point(132, 78);
		EF18A3AC.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		EF18A3AC.Name = "nudTimeFrom";
		EF18A3AC.Size = new System.Drawing.Size(56, 23);
		EF18A3AC.TabIndex = 45;
		C33EE186.Location = new System.Drawing.Point(190, 80);
		C33EE186.Name = "label3";
		C33EE186.Size = new System.Drawing.Size(29, 16);
		C33EE186.TabIndex = 49;
		C33EE186.Text = "đê\u0301n";
		C33EE186.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(274, 80);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(30, 16);
		label4.TabIndex = 48;
		label4.Text = "giây";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(93, 16);
		label2.TabIndex = 47;
		label2.Text = "Thơ\u0300i gian xem:";
		AD29319C.Controls.Add(nudPercentComment);
		AD29319C.Controls.Add(E5A24EBF);
		AD29319C.Controls.Add(A8ADC593);
		AD29319C.Controls.Add(E78F86AB);
		AD29319C.Controls.Add(label14);
		AD29319C.Controls.Add(label19);
		AD29319C.Controls.Add(E227CF07);
		AD29319C.Location = new System.Drawing.Point(132, 166);
		AD29319C.Name = "plCountComment";
		AD29319C.Size = new System.Drawing.Size(186, 25);
		AD29319C.TabIndex = 44;
		nudPercentComment.Location = new System.Drawing.Point(237, 1);
		nudPercentComment.Name = "nudPercentComment";
		nudPercentComment.Size = new System.Drawing.Size(44, 23);
		nudPercentComment.TabIndex = 38;
		nudPercentComment.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		E5A24EBF.Location = new System.Drawing.Point(1, 1);
		E5A24EBF.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E5A24EBF.Name = "nudCountCommentFrom";
		E5A24EBF.Size = new System.Drawing.Size(56, 23);
		E5A24EBF.TabIndex = 1;
		A8ADC593.AutoSize = true;
		A8ADC593.Location = new System.Drawing.Point(283, 3);
		A8ADC593.Name = "label20";
		A8ADC593.Size = new System.Drawing.Size(19, 16);
		A8ADC593.TabIndex = 35;
		A8ADC593.Text = "%";
		E78F86AB.AutoSize = true;
		E78F86AB.Location = new System.Drawing.Point(142, 3);
		E78F86AB.Name = "label13";
		E78F86AB.Size = new System.Drawing.Size(24, 16);
		E78F86AB.TabIndex = 35;
		E78F86AB.Text = "lần";
		label14.Location = new System.Drawing.Point(57, 3);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(29, 16);
		label14.TabIndex = 37;
		label14.Text = "đê\u0301n";
		label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label19.AutoSize = true;
		label19.Location = new System.Drawing.Point(182, 3);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(55, 16);
		label19.TabIndex = 35;
		label19.Text = "Percent:";
		E227CF07.Location = new System.Drawing.Point(86, 1);
		E227CF07.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E227CF07.Name = "nudCountCommentTo";
		E227CF07.Size = new System.Drawing.Size(56, 23);
		E227CF07.TabIndex = 2;
		plCountShareWall.Controls.Add(A58DA01E);
		plCountShareWall.Controls.Add(A7219399);
		plCountShareWall.Controls.Add(B434CA8C);
		plCountShareWall.Controls.Add(label11);
		plCountShareWall.Controls.Add(label17);
		plCountShareWall.Controls.Add(label12);
		plCountShareWall.Controls.Add(nudCountShareTo);
		plCountShareWall.Location = new System.Drawing.Point(132, 136);
		plCountShareWall.Name = "plCountShareWall";
		plCountShareWall.Size = new System.Drawing.Size(186, 25);
		plCountShareWall.TabIndex = 43;
		A58DA01E.Location = new System.Drawing.Point(237, 1);
		A58DA01E.Name = "nudPercentShare";
		A58DA01E.Size = new System.Drawing.Size(44, 23);
		A58DA01E.TabIndex = 38;
		A58DA01E.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		A7219399.Location = new System.Drawing.Point(1, 1);
		A7219399.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A7219399.Name = "nudCountShareFrom";
		A7219399.Size = new System.Drawing.Size(56, 23);
		A7219399.TabIndex = 1;
		B434CA8C.AutoSize = true;
		B434CA8C.Location = new System.Drawing.Point(283, 3);
		B434CA8C.Name = "label18";
		B434CA8C.Size = new System.Drawing.Size(19, 16);
		B434CA8C.TabIndex = 35;
		B434CA8C.Text = "%";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(142, 3);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(24, 16);
		label11.TabIndex = 35;
		label11.Text = "lần";
		label17.AutoSize = true;
		label17.Location = new System.Drawing.Point(182, 3);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(55, 16);
		label17.TabIndex = 35;
		label17.Text = "Percent:";
		label12.Location = new System.Drawing.Point(57, 3);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(29, 16);
		label12.TabIndex = 37;
		label12.Text = "đê\u0301n";
		label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountShareTo.Location = new System.Drawing.Point(86, 1);
		nudCountShareTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountShareTo.Name = "nudCountShareTo";
		nudCountShareTo.Size = new System.Drawing.Size(56, 23);
		nudCountShareTo.TabIndex = 2;
		plCountLike.Controls.Add(CD13FF3F);
		plCountLike.Controls.Add(nudCountLikeFrom);
		plCountLike.Controls.Add(BBB63614);
		plCountLike.Controls.Add(label15);
		plCountLike.Controls.Add(E4A46DAB);
		plCountLike.Controls.Add(label10);
		plCountLike.Controls.Add(nudCountLikeTo);
		plCountLike.Location = new System.Drawing.Point(132, 106);
		plCountLike.Name = "plCountLike";
		plCountLike.Size = new System.Drawing.Size(186, 25);
		plCountLike.TabIndex = 42;
		CD13FF3F.Location = new System.Drawing.Point(237, 1);
		CD13FF3F.Name = "nudPercentLike";
		CD13FF3F.Size = new System.Drawing.Size(44, 23);
		CD13FF3F.TabIndex = 38;
		CD13FF3F.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeFrom.Name = "nudCountLikeFrom";
		nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		nudCountLikeFrom.TabIndex = 1;
		BBB63614.AutoSize = true;
		BBB63614.Location = new System.Drawing.Point(283, 3);
		BBB63614.Name = "label16";
		BBB63614.Size = new System.Drawing.Size(19, 16);
		BBB63614.TabIndex = 35;
		BBB63614.Text = "%";
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(182, 3);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(55, 16);
		label15.TabIndex = 35;
		label15.Text = "Percent:";
		E4A46DAB.AutoSize = true;
		E4A46DAB.Location = new System.Drawing.Point(142, 3);
		E4A46DAB.Name = "label9";
		E4A46DAB.Size = new System.Drawing.Size(24, 16);
		E4A46DAB.TabIndex = 35;
		E4A46DAB.Text = "lần";
		label10.Location = new System.Drawing.Point(57, 3);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(29, 16);
		label10.TabIndex = 37;
		label10.Text = "đê\u0301n";
		label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountLikeTo.Location = new System.Drawing.Point(86, 1);
		nudCountLikeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeTo.Name = "nudCountLikeTo";
		nudCountLikeTo.Size = new System.Drawing.Size(56, 23);
		nudCountLikeTo.TabIndex = 2;
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(D9134200);
		plComment.Controls.Add(D0B1400E);
		plComment.Controls.Add(lblStatus);
		plComment.Location = new System.Drawing.Point(48, 196);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(285, 164);
		plComment.TabIndex = 8;
		D9134200.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D9134200.Location = new System.Drawing.Point(6, 24);
		D9134200.Name = "txtComment";
		D9134200.Size = new System.Drawing.Size(271, 114);
		D9134200.TabIndex = 45;
		D9134200.Text = "";
		D9134200.WordWrap = false;
		D9134200.TextChanged += new System.EventHandler(D9134200_TextChanged);
		D0B1400E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D0B1400E.AutoSize = true;
		D0B1400E.Location = new System.Drawing.Point(4, 141);
		D0B1400E.Name = "label8";
		D0B1400E.Size = new System.Drawing.Size(265, 16);
		D0B1400E.TabIndex = 0;
		D0B1400E.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(30, 168);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(81, 20);
		ckbComment.TabIndex = 7;
		ckbComment.Text = "Comment";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(D43A2F05);
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareWall.Location = new System.Drawing.Point(30, 138);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new System.Drawing.Size(89, 20);
		ckbShareWall.TabIndex = 6;
		ckbShareWall.Text = "Share Wall";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbShareWall.CheckedChanged += new System.EventHandler(ckbShareWall_CheckedChanged);
		E90CDA96.AutoSize = true;
		E90CDA96.Cursor = System.Windows.Forms.Cursors.Hand;
		E90CDA96.Location = new System.Drawing.Point(30, 108);
		E90CDA96.Name = "ckbInteract";
		E90CDA96.Size = new System.Drawing.Size(48, 20);
		E90CDA96.TabIndex = 5;
		E90CDA96.Text = "Like";
		E90CDA96.UseVisualStyleBackColor = true;
		E90CDA96.CheckedChanged += new System.EventHandler(E90CDA96_CheckedChanged);
		DF3E4E9A.Location = new System.Drawing.Point(132, 49);
		DF3E4E9A.Name = "txtTenHanhDong";
		DF3E4E9A.Size = new System.Drawing.Size(201, 23);
		DF3E4E9A.TabIndex = 0;
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
		btnCancel.Location = new System.Drawing.Point(189, 378);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(D003DD0A);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 378);
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
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(356, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(359, 424);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXemWatch";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXemWatch_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)EF18A3AC).EndInit();
		AD29319C.ResumeLayout(false);
		AD29319C.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudPercentComment).EndInit();
		((System.ComponentModel.ISupportInitialize)E5A24EBF).EndInit();
		((System.ComponentModel.ISupportInitialize)E227CF07).EndInit();
		plCountShareWall.ResumeLayout(false);
		plCountShareWall.PerformLayout();
		((System.ComponentModel.ISupportInitialize)A58DA01E).EndInit();
		((System.ComponentModel.ISupportInitialize)A7219399).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountShareTo).EndInit();
		plCountLike.ResumeLayout(false);
		plCountLike.PerformLayout();
		((System.ComponentModel.ISupportInitialize)CD13FF3F).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).EndInit();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
