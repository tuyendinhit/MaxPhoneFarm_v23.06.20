using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacNhomV2 : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string E5833EAC;

	internal int B731D9BE;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl A8B75C8B;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel A9355F35;

	internal TextBox txtTenHanhDong;

	internal Label AA862B1E;

	internal Button F42368B1;

	internal Button btnAdd;

	internal BunifuCards BEAEE394;

	internal Panel B68127A6;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel F609160E;

	internal Label label8;

	internal Label FD3535A4;

	internal CheckBox CAB1AB10;

	internal CheckBox ckbInteract;

	internal CheckBox BCB662A2;

	internal RadioButton CEA6C90F;

	internal RadioButton B323D50E;

	internal Label label9;

	internal Button AE3A248C;

	internal Button E7888F8D;

	internal RichTextBox txtComment;

	internal Panel F60DEAB7;

	internal NumericUpDown nudCountCommentFrom;

	internal Label label13;

	internal Label DDBD121D;

	internal NumericUpDown nudCountCommentTo;

	internal Panel AE2E4593;

	internal NumericUpDown nudCountShareFrom;

	internal Label label11;

	internal Label label12;

	internal NumericUpDown D0097432;

	internal Panel plCountLike;

	internal NumericUpDown nudCountLikeFrom;

	internal Label F583AFA9;

	internal Label E2936D93;

	internal NumericUpDown D086C530;

	internal NumericUpDown DBAC2B28;

	internal NumericUpDown nudTimeFrom;

	internal Label label16;

	internal Label label18;

	internal Label label21;

	internal Button C9A168BD;

	public fHDTuongTacNhomV2(string E93410B9, int A637AF84 = 0, string F38E3FB5 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = E93410B9;
		E5833EAC = F38E3FB5;
		B731D9BE = A637AF84;
		if (Class123.C7BE863B("", "HDTuongTacNhom").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacNhom', 'Tương tác Nhóm');");
		}
		string d399C = "";
		switch (A637AF84)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDTuongTacNhom");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(F38E3FB5);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void AB17053B(object sender, EventArgs e)
	{
		try
		{
			nudTimeFrom.Value = f72FAFBC_0.method_0("nudTimeFrom", 10);
			DBAC2B28.Value = f72FAFBC_0.method_0("nudTimeTo", 30);
			nudCountLikeFrom.Value = f72FAFBC_0.method_0("nudCountLikeFrom", 1);
			D086C530.Value = f72FAFBC_0.method_0("nudCountLikeTo", 3);
			nudCountShareFrom.Value = f72FAFBC_0.method_0("nudCountShareFrom", 1);
			D0097432.Value = f72FAFBC_0.method_0("nudCountShareTo", 3);
			nudCountCommentFrom.Value = f72FAFBC_0.method_0("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = f72FAFBC_0.method_0("nudCountCommentTo", 3);
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			BCB662A2.Checked = f72FAFBC_0.AA824D29("ckbShareWall");
			CAB1AB10.Checked = f72FAFBC_0.AA824D29("ckbComment");
			txtComment.Text = f72FAFBC_0.GetValue("txtComment");
			if (f72FAFBC_0.method_0("typeNganCach") == 1)
			{
				CEA6C90F.Checked = true;
			}
			else
			{
				B323D50E.Checked = true;
			}
		}
		catch
		{
		}
		D60C8836();
	}

	private void C9A168BD_Click(object sender, EventArgs e)
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
		if (CAB1AB10.Checked)
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
		f72FAFBC.GetValue("nudTimeFrom", nudTimeFrom.Value);
		f72FAFBC.GetValue("nudTimeTo", DBAC2B28.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		f72FAFBC.GetValue("ckbShareWall", BCB662A2.Checked);
		f72FAFBC.GetValue("ckbComment", CAB1AB10.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		f72FAFBC.GetValue("nudCountLikeFrom", nudCountLikeFrom.Value);
		f72FAFBC.GetValue("nudCountLikeTo", D086C530.Value);
		f72FAFBC.GetValue("nudCountShareFrom", nudCountShareFrom.Value);
		f72FAFBC.GetValue("nudCountShareTo", D0097432.Value);
		f72FAFBC.GetValue("nudCountCommentFrom", nudCountCommentFrom.Value);
		f72FAFBC.GetValue("nudCountCommentTo", nudCountCommentTo.Value);
		int num = 0;
		if (CEA6C90F.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		string text2 = f72FAFBC.C71A4EA4();
		if (B731D9BE == 0)
		{
			if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
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
		else if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class123.smethod_14(E5833EAC, text, text2))
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

	private void BEB9B593(object sender, EventArgs e)
	{
		Close();
	}

	private void A03B2613(object sender, PaintEventArgs e)
	{
		if (A9355F35.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, A9355F35.ClientSize.Width - num, A9355F35.ClientSize.Height - num));
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!B323D50E.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			FD3535A4.Text = Language.GetValue("Nội dung bình luận") + " (" + list.Count + "):";
		}
		catch
		{
		}
	}

	private void D60C8836()
	{
		ckbInteract_CheckedChanged(null, null);
		CAB1AB10_CheckedChanged(null, null);
		BCB662A2_CheckedChanged(null, null);
	}

	private void CAB1AB10_CheckedChanged(object sender, EventArgs e)
	{
		F60DEAB7.Enabled = CAB1AB10.Checked;
		F609160E.Enabled = CAB1AB10.Checked;
	}

	private void E7888F8D_Click(object sender, EventArgs e)
	{
		F609160E.Height = 195;
	}

	private void AE3A248C_Click(object sender, EventArgs e)
	{
		F609160E.Height = 209;
	}

	private void FE91758D(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			E7888F8D.Visible = true;
			AE3A248C.Visible = true;
		}
	}

	private void B323D50E_CheckedChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void CEA6C90F_CheckedChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		plCountLike.Enabled = ckbInteract.Checked;
	}

	private void BCB662A2_CheckedChanged(object sender, EventArgs e)
	{
		AE2E4593.Enabled = BCB662A2.Checked;
	}

	protected override void Dispose(bool A21C9B8C)
	{
		if (A21C9B8C && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(A21C9B8C);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		A8B75C8B = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		B68127A6 = new System.Windows.Forms.Panel();
		C9A168BD = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		A9355F35 = new System.Windows.Forms.Panel();
		F609160E = new System.Windows.Forms.Panel();
		txtComment = new System.Windows.Forms.RichTextBox();
		AE3A248C = new System.Windows.Forms.Button();
		E7888F8D = new System.Windows.Forms.Button();
		CEA6C90F = new System.Windows.Forms.RadioButton();
		B323D50E = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		FD3535A4 = new System.Windows.Forms.Label();
		label21 = new System.Windows.Forms.Label();
		ckbInteract = new System.Windows.Forms.CheckBox();
		BCB662A2 = new System.Windows.Forms.CheckBox();
		CAB1AB10 = new System.Windows.Forms.CheckBox();
		F60DEAB7 = new System.Windows.Forms.Panel();
		nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		label13 = new System.Windows.Forms.Label();
		DDBD121D = new System.Windows.Forms.Label();
		nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		label18 = new System.Windows.Forms.Label();
		AE2E4593 = new System.Windows.Forms.Panel();
		nudCountShareFrom = new System.Windows.Forms.NumericUpDown();
		label11 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		D0097432 = new System.Windows.Forms.NumericUpDown();
		plCountLike = new System.Windows.Forms.Panel();
		nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		F583AFA9 = new System.Windows.Forms.Label();
		E2936D93 = new System.Windows.Forms.Label();
		D086C530 = new System.Windows.Forms.NumericUpDown();
		label16 = new System.Windows.Forms.Label();
		DBAC2B28 = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		AA862B1E = new System.Windows.Forms.Label();
		F42368B1 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		BEAEE394 = new Bunifu.Framework.UI.BunifuCards();
		B68127A6.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		A9355F35.SuspendLayout();
		F609160E.SuspendLayout();
		F60DEAB7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).BeginInit();
		AE2E4593.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)D0097432).BeginInit();
		plCountLike.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)D086C530).BeginInit();
		((System.ComponentModel.ISupportInitialize)DBAC2B28).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		BEAEE394.SuspendLayout();
		SuspendLayout();
		A8B75C8B.Fixed = true;
		A8B75C8B.Horizontal = true;
		A8B75C8B.TargetControl = bunifuCustomLabel1;
		A8B75C8B.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Nhóm";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = B68127A6;
		bunifuDragControl_0.Vertical = true;
		B68127A6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B68127A6.BackColor = System.Drawing.Color.White;
		B68127A6.Controls.Add(C9A168BD);
		B68127A6.Controls.Add(pictureBox1);
		B68127A6.Controls.Add(bunifuCustomLabel1);
		B68127A6.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B68127A6.Location = new System.Drawing.Point(0, 3);
		B68127A6.Name = "pnlHeader";
		B68127A6.Size = new System.Drawing.Size(359, 31);
		B68127A6.TabIndex = 9;
		C9A168BD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		C9A168BD.Cursor = System.Windows.Forms.Cursors.Hand;
		C9A168BD.FlatAppearance.BorderSize = 0;
		C9A168BD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C9A168BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C9A168BD.ForeColor = System.Drawing.Color.White;
		C9A168BD.Image = Resource.Bitmap_9;
		C9A168BD.Location = new System.Drawing.Point(326, 0);
		C9A168BD.Name = "btnMinimize";
		C9A168BD.Size = new System.Drawing.Size(32, 32);
		C9A168BD.TabIndex = 78;
		C9A168BD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C9A168BD.UseVisualStyleBackColor = true;
		C9A168BD.Click += new System.EventHandler(C9A168BD_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(FE91758D);
		A9355F35.BackColor = System.Drawing.Color.White;
		A9355F35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A9355F35.Controls.Add(F609160E);
		A9355F35.Controls.Add(label21);
		A9355F35.Controls.Add(ckbInteract);
		A9355F35.Controls.Add(BCB662A2);
		A9355F35.Controls.Add(CAB1AB10);
		A9355F35.Controls.Add(F60DEAB7);
		A9355F35.Controls.Add(label18);
		A9355F35.Controls.Add(AE2E4593);
		A9355F35.Controls.Add(txtTenHanhDong);
		A9355F35.Controls.Add(plCountLike);
		A9355F35.Controls.Add(AA862B1E);
		A9355F35.Controls.Add(label16);
		A9355F35.Controls.Add(F42368B1);
		A9355F35.Controls.Add(DBAC2B28);
		A9355F35.Controls.Add(btnAdd);
		A9355F35.Controls.Add(nudTimeFrom);
		A9355F35.Controls.Add(BEAEE394);
		A9355F35.Cursor = System.Windows.Forms.Cursors.Arrow;
		A9355F35.Dock = System.Windows.Forms.DockStyle.Fill;
		A9355F35.Location = new System.Drawing.Point(0, 0);
		A9355F35.Name = "panel1";
		A9355F35.Size = new System.Drawing.Size(362, 420);
		A9355F35.TabIndex = 0;
		A9355F35.Paint += new System.Windows.Forms.PaintEventHandler(A03B2613);
		F609160E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F609160E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F609160E.Controls.Add(txtComment);
		F609160E.Controls.Add(AE3A248C);
		F609160E.Controls.Add(E7888F8D);
		F609160E.Controls.Add(CEA6C90F);
		F609160E.Controls.Add(B323D50E);
		F609160E.Controls.Add(label9);
		F609160E.Controls.Add(label8);
		F609160E.Controls.Add(FD3535A4);
		F609160E.Location = new System.Drawing.Point(42, 195);
		F609160E.Name = "plComment";
		F609160E.Size = new System.Drawing.Size(281, 163);
		F609160E.TabIndex = 10;
		txtComment.Location = new System.Drawing.Point(7, 27);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(266, 111);
		txtComment.TabIndex = 106;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		AE3A248C.BackgroundImage = Resource.Bitmap_91;
		AE3A248C.Cursor = System.Windows.Forms.Cursors.Hand;
		AE3A248C.Location = new System.Drawing.Point(224, -1);
		AE3A248C.Name = "btnDown";
		AE3A248C.Size = new System.Drawing.Size(25, 25);
		AE3A248C.TabIndex = 7;
		AE3A248C.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		AE3A248C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AE3A248C.Visible = false;
		AE3A248C.Click += new System.EventHandler(AE3A248C_Click);
		E7888F8D.BackgroundImage = Resource.Bitmap_73;
		E7888F8D.Cursor = System.Windows.Forms.Cursors.Hand;
		E7888F8D.Location = new System.Drawing.Point(255, -1);
		E7888F8D.Name = "btnUp";
		E7888F8D.Size = new System.Drawing.Size(25, 25);
		E7888F8D.TabIndex = 7;
		E7888F8D.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		E7888F8D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E7888F8D.Visible = false;
		E7888F8D.Click += new System.EventHandler(E7888F8D_Click);
		CEA6C90F.AutoSize = true;
		CEA6C90F.Cursor = System.Windows.Forms.Cursors.Hand;
		CEA6C90F.Location = new System.Drawing.Point(69, 182);
		CEA6C90F.Name = "rbNganCachKyTu";
		CEA6C90F.Size = new System.Drawing.Size(203, 20);
		CEA6C90F.TabIndex = 6;
		CEA6C90F.Text = "Các nội dung ngăn cách bởi \"|\"";
		CEA6C90F.UseVisualStyleBackColor = true;
		CEA6C90F.CheckedChanged += new System.EventHandler(CEA6C90F_CheckedChanged);
		B323D50E.AutoSize = true;
		B323D50E.Checked = true;
		B323D50E.Cursor = System.Windows.Forms.Cursors.Hand;
		B323D50E.Location = new System.Drawing.Point(69, 161);
		B323D50E.Name = "rbNganCachMoiDong";
		B323D50E.Size = new System.Drawing.Size(171, 20);
		B323D50E.TabIndex = 5;
		B323D50E.TabStop = true;
		B323D50E.Text = "Mỗi dòng là một nội dung";
		B323D50E.UseVisualStyleBackColor = true;
		B323D50E.CheckedChanged += new System.EventHandler(B323D50E_CheckedChanged);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(4, 161);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(65, 16);
		label9.TabIndex = 4;
		label9.Text = "Tùy chọn:";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 141);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(266, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		FD3535A4.AutoSize = true;
		FD3535A4.Location = new System.Drawing.Point(3, 5);
		FD3535A4.Name = "lblStatus";
		FD3535A4.Size = new System.Drawing.Size(140, 16);
		FD3535A4.TabIndex = 0;
		FD3535A4.Text = "Nội dung bình luận (0):";
		label21.AutoSize = true;
		label21.Location = new System.Drawing.Point(18, 80);
		label21.Name = "label21";
		label21.Size = new System.Drawing.Size(92, 16);
		label21.TabIndex = 110;
		label21.Text = "Thơ\u0300i gian lươ\u0301t:";
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(21, 108);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(76, 20);
		ckbInteract.TabIndex = 7;
		ckbInteract.Text = "Cảm xúc";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		BCB662A2.AutoSize = true;
		BCB662A2.Cursor = System.Windows.Forms.Cursors.Hand;
		BCB662A2.Location = new System.Drawing.Point(21, 137);
		BCB662A2.Name = "ckbShareWall";
		BCB662A2.Size = new System.Drawing.Size(90, 20);
		BCB662A2.TabIndex = 8;
		BCB662A2.Text = "Share Wall";
		BCB662A2.UseVisualStyleBackColor = true;
		BCB662A2.CheckedChanged += new System.EventHandler(BCB662A2_CheckedChanged);
		CAB1AB10.AutoSize = true;
		CAB1AB10.Cursor = System.Windows.Forms.Cursors.Hand;
		CAB1AB10.Location = new System.Drawing.Point(21, 166);
		CAB1AB10.Name = "ckbComment";
		CAB1AB10.Size = new System.Drawing.Size(82, 20);
		CAB1AB10.TabIndex = 9;
		CAB1AB10.Text = "Comment";
		CAB1AB10.UseVisualStyleBackColor = true;
		CAB1AB10.CheckedChanged += new System.EventHandler(CAB1AB10_CheckedChanged);
		F60DEAB7.Controls.Add(nudCountCommentFrom);
		F60DEAB7.Controls.Add(label13);
		F60DEAB7.Controls.Add(DDBD121D);
		F60DEAB7.Controls.Add(nudCountCommentTo);
		F60DEAB7.Location = new System.Drawing.Point(128, 165);
		F60DEAB7.Name = "plCountComment";
		F60DEAB7.Size = new System.Drawing.Size(196, 25);
		F60DEAB7.TabIndex = 118;
		nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentFrom.Name = "nudCountCommentFrom";
		nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		nudCountCommentFrom.TabIndex = 1;
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(159, 3);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(30, 16);
		label13.TabIndex = 35;
		label13.Text = "lươ\u0323t";
		DDBD121D.AutoSize = true;
		DDBD121D.Location = new System.Drawing.Point(63, 3);
		DDBD121D.Name = "label14";
		DDBD121D.Size = new System.Drawing.Size(29, 16);
		DDBD121D.TabIndex = 37;
		DDBD121D.Text = "đê\u0301n";
		nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
		nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentTo.Name = "nudCountCommentTo";
		nudCountCommentTo.Size = new System.Drawing.Size(56, 23);
		nudCountCommentTo.TabIndex = 2;
		label18.AutoSize = true;
		label18.Location = new System.Drawing.Point(287, 80);
		label18.Name = "label18";
		label18.Size = new System.Drawing.Size(31, 16);
		label18.TabIndex = 112;
		label18.Text = "giây";
		AE2E4593.Controls.Add(nudCountShareFrom);
		AE2E4593.Controls.Add(label11);
		AE2E4593.Controls.Add(label12);
		AE2E4593.Controls.Add(D0097432);
		AE2E4593.Location = new System.Drawing.Point(128, 135);
		AE2E4593.Name = "plCountShareWall";
		AE2E4593.Size = new System.Drawing.Size(196, 25);
		AE2E4593.TabIndex = 117;
		nudCountShareFrom.Location = new System.Drawing.Point(1, 1);
		nudCountShareFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountShareFrom.Name = "nudCountShareFrom";
		nudCountShareFrom.Size = new System.Drawing.Size(56, 23);
		nudCountShareFrom.TabIndex = 1;
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(159, 3);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(30, 16);
		label11.TabIndex = 35;
		label11.Text = "lươ\u0323t";
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(63, 3);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(29, 16);
		label12.TabIndex = 37;
		label12.Text = "đê\u0301n";
		D0097432.Location = new System.Drawing.Point(98, 1);
		D0097432.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D0097432.Name = "nudCountShareTo";
		D0097432.Size = new System.Drawing.Size(56, 23);
		D0097432.TabIndex = 2;
		plCountLike.Controls.Add(nudCountLikeFrom);
		plCountLike.Controls.Add(F583AFA9);
		plCountLike.Controls.Add(E2936D93);
		plCountLike.Controls.Add(D086C530);
		plCountLike.Location = new System.Drawing.Point(128, 106);
		plCountLike.Name = "plCountLike";
		plCountLike.Size = new System.Drawing.Size(196, 25);
		plCountLike.TabIndex = 116;
		nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeFrom.Name = "nudCountLikeFrom";
		nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		nudCountLikeFrom.TabIndex = 1;
		F583AFA9.AutoSize = true;
		F583AFA9.Location = new System.Drawing.Point(159, 3);
		F583AFA9.Name = "label2";
		F583AFA9.Size = new System.Drawing.Size(30, 16);
		F583AFA9.TabIndex = 35;
		F583AFA9.Text = "lươ\u0323t";
		E2936D93.AutoSize = true;
		E2936D93.Location = new System.Drawing.Point(63, 3);
		E2936D93.Name = "label10";
		E2936D93.Size = new System.Drawing.Size(29, 16);
		E2936D93.TabIndex = 37;
		E2936D93.Text = "đê\u0301n";
		D086C530.Location = new System.Drawing.Point(98, 1);
		D086C530.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D086C530.Name = "nudCountLikeTo";
		D086C530.Size = new System.Drawing.Size(56, 23);
		D086C530.TabIndex = 2;
		label16.AutoSize = true;
		label16.Location = new System.Drawing.Point(191, 80);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(29, 16);
		label16.TabIndex = 114;
		label16.Text = "đê\u0301n";
		DBAC2B28.Location = new System.Drawing.Point(226, 78);
		DBAC2B28.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DBAC2B28.Name = "nudTimeTo";
		DBAC2B28.Size = new System.Drawing.Size(56, 23);
		DBAC2B28.TabIndex = 107;
		nudTimeFrom.Location = new System.Drawing.Point(129, 78);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 106;
		txtTenHanhDong.Location = new System.Drawing.Point(129, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(195, 23);
		txtTenHanhDong.TabIndex = 0;
		AA862B1E.AutoSize = true;
		AA862B1E.Location = new System.Drawing.Point(18, 52);
		AA862B1E.Name = "label1";
		AA862B1E.Size = new System.Drawing.Size(99, 16);
		AA862B1E.TabIndex = 31;
		AA862B1E.Text = "Tên ha\u0300nh đô\u0323ng:";
		F42368B1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F42368B1.BackColor = System.Drawing.Color.Maroon;
		F42368B1.Cursor = System.Windows.Forms.Cursors.Hand;
		F42368B1.FlatAppearance.BorderSize = 0;
		F42368B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F42368B1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F42368B1.ForeColor = System.Drawing.Color.White;
		F42368B1.Location = new System.Drawing.Point(189, 375);
		F42368B1.Name = "btnCancel";
		F42368B1.Size = new System.Drawing.Size(92, 29);
		F42368B1.TabIndex = 12;
		F42368B1.Text = "Đóng";
		F42368B1.UseVisualStyleBackColor = false;
		F42368B1.Click += new System.EventHandler(BEB9B593);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 375);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 11;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		BEAEE394.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		BEAEE394.BackColor = System.Drawing.Color.White;
		BEAEE394.BorderRadius = 0;
		BEAEE394.BottomSahddow = true;
		BEAEE394.color = System.Drawing.Color.DarkViolet;
		BEAEE394.Controls.Add(B68127A6);
		BEAEE394.LeftSahddow = false;
		BEAEE394.Location = new System.Drawing.Point(1, 0);
		BEAEE394.Name = "bunifuCards1";
		BEAEE394.RightSahddow = true;
		BEAEE394.ShadowDepth = 20;
		BEAEE394.Size = new System.Drawing.Size(359, 37);
		BEAEE394.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 420);
		base.Controls.Add(A9355F35);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(AB17053B);
		B68127A6.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		A9355F35.ResumeLayout(false);
		A9355F35.PerformLayout();
		F609160E.ResumeLayout(false);
		F609160E.PerformLayout();
		F60DEAB7.ResumeLayout(false);
		F60DEAB7.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).EndInit();
		AE2E4593.ResumeLayout(false);
		AE2E4593.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)D0097432).EndInit();
		plCountLike.ResumeLayout(false);
		plCountLike.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)D086C530).EndInit();
		((System.ComponentModel.ISupportInitialize)DBAC2B28).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		BEAEE394.ResumeLayout(false);
		ResumeLayout(false);
	}
}
