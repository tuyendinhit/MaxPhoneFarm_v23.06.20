using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacBanBe : Form
{
	internal JSON_Settings E80F0702;

	internal string FE2E8D0B;

	internal string string_0;

	internal string C32EE585;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label A91DD7AE;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel EDB31B28;

	internal Panel plComment;

	internal Label label8;

	internal Label lblStatus;

	internal CheckBox ckbComment;

	internal CheckBox AF03D62E;

	internal CheckBox A7850E91;

	internal Label label9;

	internal Button BF1307B7;

	internal Button btnUp;

	internal RichTextBox txtComment;

	internal Panel plCountComment;

	internal NumericUpDown nudCountCommentFrom;

	internal Label label13;

	internal Label CB1E9199;

	internal NumericUpDown nudCountCommentTo;

	internal Panel plCountShareWall;

	internal NumericUpDown F1250B9F;

	internal Label label11;

	internal Label label12;

	internal NumericUpDown nudCountShareTo;

	internal Panel plCountLike;

	internal NumericUpDown nudCountLikeFrom;

	internal Label EEA2B799;

	internal Label label10;

	internal NumericUpDown B294142D;

	internal NumericUpDown E3A50A15;

	internal NumericUpDown nudTimeFrom;

	internal Label label16;

	internal Label label18;

	internal Label label21;

	internal GroupBox groupBox1;

	internal Label label49;

	internal NumericUpDown nudSoLuongBanBeFrom;

	internal Label label68;

	internal NumericUpDown nudSoLuongBanBeTo;

	internal Label F23E5B2A;

	internal Button EDB43B21;

	internal Button A0380704;

	internal RadioButton EE8CBB3A;

	internal RadioButton rbNganCachMoiDong;

	public fHDTuongTacBanBe(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		FE2E8D0B = string_1;
		C32EE585 = string_2;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDTuongTacBanBe").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBanBe', 'Tương tác Bạn bè');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDTuongTacBanBe");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		E80F0702 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(EDB31B28);
		Language.smethod_1(A91DD7AE);
		Language.smethod_1(label49);
		Language.smethod_1(F23E5B2A);
		Language.smethod_1(label68);
		Language.smethod_1(groupBox1);
		Language.smethod_1(label21);
		Language.smethod_1(label16);
		Language.smethod_1(label18);
		Language.smethod_1(label10);
		Language.smethod_1(EEA2B799);
		Language.smethod_1(label12);
		Language.smethod_1(label11);
		Language.smethod_1(CB1E9199);
		Language.smethod_1(label13);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
		Language.smethod_1(AF03D62E);
	}

	private void E9878731(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongBanBeFrom.Value = E80F0702.method_0("nudSoLuongBanBeFrom", 1);
			nudSoLuongBanBeTo.Value = E80F0702.method_0("nudSoLuongBanBeTo", 3);
			nudTimeFrom.Value = E80F0702.method_0("nudTimeFrom", 10);
			E3A50A15.Value = E80F0702.method_0("nudTimeTo", 30);
			nudCountLikeFrom.Value = E80F0702.method_0("nudCountLikeFrom", 1);
			B294142D.Value = E80F0702.method_0("nudCountLikeTo", 3);
			F1250B9F.Value = E80F0702.method_0("nudCountShareFrom", 1);
			nudCountShareTo.Value = E80F0702.method_0("nudCountShareTo", 3);
			nudCountCommentFrom.Value = E80F0702.method_0("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = E80F0702.method_0("nudCountCommentTo", 3);
			AF03D62E.Checked = E80F0702.AA824D29("ckbInteract");
			A7850E91.Checked = E80F0702.AA824D29("ckbShareWall");
			ckbComment.Checked = E80F0702.AA824D29("ckbComment");
			txtComment.Text = E80F0702.GetValue("txtComment");
			if (E80F0702.method_0("typeNganCach") == 1)
			{
				EE8CBB3A.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
		}
		catch
		{
		}
		DB2EFBB0();
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
		if (ckbComment.Checked)
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
		f72FAFBC.GetValue("nudSoLuongBanBeFrom", nudSoLuongBanBeFrom.Value);
		f72FAFBC.GetValue("nudSoLuongBanBeTo", nudSoLuongBanBeTo.Value);
		f72FAFBC.GetValue("nudTimeFrom", nudTimeFrom.Value);
		f72FAFBC.GetValue("nudTimeTo", E3A50A15.Value);
		f72FAFBC.GetValue("ckbInteract", AF03D62E.Checked);
		f72FAFBC.GetValue("ckbShareWall", A7850E91.Checked);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		f72FAFBC.GetValue("nudCountLikeFrom", nudCountLikeFrom.Value);
		f72FAFBC.GetValue("nudCountLikeTo", B294142D.Value);
		f72FAFBC.GetValue("nudCountShareFrom", F1250B9F.Value);
		f72FAFBC.GetValue("nudCountShareTo", nudCountShareTo.Value);
		f72FAFBC.GetValue("nudCountCommentFrom", nudCountCommentFrom.Value);
		f72FAFBC.GetValue("nudCountCommentTo", nudCountCommentTo.Value);
		int num = 0;
		if (EE8CBB3A.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(FE2E8D0B, text, string_0, text2))
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
			if (Class123.smethod_14(C32EE585, text, text2))
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

	private void CDAD3613(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void CC332397(object sender, EventArgs e)
	{
		A7AF95BF();
	}

	private void A7AF95BF()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void DB2EFBB0()
	{
		AF03D62E_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
		A7850E91_CheckedChanged(null, null);
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plCountComment.Enabled = ckbComment.Checked;
		plComment.Enabled = ckbComment.Checked;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		groupBox1.Height = 341;
	}

	private void DDA82798(object sender, EventArgs e)
	{
		groupBox1.Height = 382;
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			BF1307B7.Visible = true;
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		A7AF95BF();
	}

	private void method_2(object sender, EventArgs e)
	{
		A7AF95BF();
	}

	private void AF03D62E_CheckedChanged(object sender, EventArgs e)
	{
		plCountLike.Enabled = AF03D62E.Checked;
	}

	private void A7850E91_CheckedChanged(object sender, EventArgs e)
	{
		plCountShareWall.Enabled = A7850E91.Checked;
	}

	private void C919801C(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	private void B6141524(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	private void EDB43B21_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacBanBe));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		EDB31B28 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		groupBox1 = new System.Windows.Forms.GroupBox();
		plComment = new System.Windows.Forms.Panel();
		EDB43B21 = new System.Windows.Forms.Button();
		A0380704 = new System.Windows.Forms.Button();
		EE8CBB3A = new System.Windows.Forms.RadioButton();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		txtComment = new System.Windows.Forms.RichTextBox();
		BF1307B7 = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		label9 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		label21 = new System.Windows.Forms.Label();
		AF03D62E = new System.Windows.Forms.CheckBox();
		A7850E91 = new System.Windows.Forms.CheckBox();
		ckbComment = new System.Windows.Forms.CheckBox();
		plCountComment = new System.Windows.Forms.Panel();
		nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		label13 = new System.Windows.Forms.Label();
		CB1E9199 = new System.Windows.Forms.Label();
		nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		label18 = new System.Windows.Forms.Label();
		plCountShareWall = new System.Windows.Forms.Panel();
		F1250B9F = new System.Windows.Forms.NumericUpDown();
		label11 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		nudCountShareTo = new System.Windows.Forms.NumericUpDown();
		plCountLike = new System.Windows.Forms.Panel();
		nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		EEA2B799 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		B294142D = new System.Windows.Forms.NumericUpDown();
		label16 = new System.Windows.Forms.Label();
		E3A50A15 = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		label49 = new System.Windows.Forms.Label();
		nudSoLuongBanBeFrom = new System.Windows.Forms.NumericUpDown();
		label68 = new System.Windows.Forms.Label();
		nudSoLuongBanBeTo = new System.Windows.Forms.NumericUpDown();
		F23E5B2A = new System.Windows.Forms.Label();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		A91DD7AE = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		groupBox1.SuspendLayout();
		plComment.SuspendLayout();
		plCountComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).BeginInit();
		plCountShareWall.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F1250B9F).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountShareTo).BeginInit();
		plCountLike.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)B294142D).BeginInit();
		((System.ComponentModel.ISupportInitialize)E3A50A15).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBanBeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBanBeTo).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = EDB31B28;
		bunifuDragControl_0.Vertical = true;
		EDB31B28.BackColor = System.Drawing.Color.Transparent;
		EDB31B28.Cursor = System.Windows.Forms.Cursors.SizeAll;
		EDB31B28.Dock = System.Windows.Forms.DockStyle.Fill;
		EDB31B28.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EDB31B28.ForeColor = System.Drawing.Color.Black;
		EDB31B28.Location = new System.Drawing.Point(0, 0);
		EDB31B28.Name = "bunifuCustomLabel1";
		EDB31B28.Size = new System.Drawing.Size(359, 31);
		EDB31B28.TabIndex = 12;
		EDB31B28.Text = "Cấu hình Tương tác Bạn bè";
		EDB31B28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(EDB31B28);
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
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(nudSoLuongBanBeFrom);
		panel1.Controls.Add(label68);
		panel1.Controls.Add(nudSoLuongBanBeTo);
		panel1.Controls.Add(F23E5B2A);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(A91DD7AE);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 482);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		groupBox1.Controls.Add(plComment);
		groupBox1.Controls.Add(label21);
		groupBox1.Controls.Add(AF03D62E);
		groupBox1.Controls.Add(A7850E91);
		groupBox1.Controls.Add(ckbComment);
		groupBox1.Controls.Add(plCountComment);
		groupBox1.Controls.Add(label18);
		groupBox1.Controls.Add(plCountShareWall);
		groupBox1.Controls.Add(plCountLike);
		groupBox1.Controls.Add(label16);
		groupBox1.Controls.Add(E3A50A15);
		groupBox1.Controls.Add(nudTimeFrom);
		groupBox1.Location = new System.Drawing.Point(21, 111);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(321, 312);
		groupBox1.TabIndex = 124;
		groupBox1.TabStop = false;
		groupBox1.Text = "Cấu hình tương tác/Bạn bè";
		plComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(EDB43B21);
		plComment.Controls.Add(A0380704);
		plComment.Controls.Add(EE8CBB3A);
		plComment.Controls.Add(rbNganCachMoiDong);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(BF1307B7);
		plComment.Controls.Add(btnUp);
		plComment.Controls.Add(label9);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(lblStatus);
		plComment.Location = new System.Drawing.Point(32, 141);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(281, 162);
		plComment.TabIndex = 10;
		EDB43B21.Cursor = System.Windows.Forms.Cursors.Help;
		EDB43B21.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EDB43B21.Location = new System.Drawing.Point(223, 184);
		EDB43B21.Name = "button3";
		EDB43B21.Size = new System.Drawing.Size(21, 23);
		EDB43B21.TabIndex = 111;
		EDB43B21.Text = "?";
		EDB43B21.UseVisualStyleBackColor = true;
		EDB43B21.Click += new System.EventHandler(EDB43B21_Click);
		A0380704.Cursor = System.Windows.Forms.Cursors.Help;
		A0380704.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A0380704.Location = new System.Drawing.Point(223, 161);
		A0380704.Name = "button2";
		A0380704.Size = new System.Drawing.Size(21, 23);
		A0380704.TabIndex = 112;
		A0380704.Text = "?";
		A0380704.UseVisualStyleBackColor = true;
		A0380704.Click += new System.EventHandler(B6141524);
		EE8CBB3A.AutoSize = true;
		EE8CBB3A.Cursor = System.Windows.Forms.Cursors.Hand;
		EE8CBB3A.Location = new System.Drawing.Point(68, 182);
		EE8CBB3A.Name = "rbNganCachKyTu";
		EE8CBB3A.Size = new System.Drawing.Size(159, 20);
		EE8CBB3A.TabIndex = 110;
		EE8CBB3A.Text = "Nội dung có nhiều dòng";
		EE8CBB3A.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(68, 161);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		rbNganCachMoiDong.TabIndex = 109;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		txtComment.Location = new System.Drawing.Point(7, 27);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(266, 111);
		txtComment.TabIndex = 106;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(CC332397);
		BF1307B7.BackgroundImage = Resource.Bitmap_91;
		BF1307B7.Cursor = System.Windows.Forms.Cursors.Hand;
		BF1307B7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		BF1307B7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BF1307B7.Location = new System.Drawing.Point(224, -1);
		BF1307B7.Name = "btnDown";
		BF1307B7.Size = new System.Drawing.Size(25, 25);
		BF1307B7.TabIndex = 7;
		BF1307B7.Visible = false;
		BF1307B7.Click += new System.EventHandler(DDA82798);
		btnUp.BackgroundImage = Resource.Bitmap_73;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Location = new System.Drawing.Point(255, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 7;
		btnUp.Visible = false;
		btnUp.Click += new System.EventHandler(btnUp_Click);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(4, 161);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(64, 16);
		label9.TabIndex = 4;
		label9.Text = "Tùy chọn:";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 141);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(265, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		label21.AutoSize = true;
		label21.Location = new System.Drawing.Point(6, 25);
		label21.Name = "label21";
		label21.Size = new System.Drawing.Size(91, 16);
		label21.TabIndex = 110;
		label21.Text = "Thơ\u0300i gian lươ\u0301t:";
		AF03D62E.AutoSize = true;
		AF03D62E.Cursor = System.Windows.Forms.Cursors.Hand;
		AF03D62E.Location = new System.Drawing.Point(10, 53);
		AF03D62E.Name = "ckbInteract";
		AF03D62E.Size = new System.Drawing.Size(75, 20);
		AF03D62E.TabIndex = 7;
		AF03D62E.Text = "Cảm xúc";
		AF03D62E.UseVisualStyleBackColor = true;
		AF03D62E.CheckedChanged += new System.EventHandler(AF03D62E_CheckedChanged);
		A7850E91.AutoSize = true;
		A7850E91.Cursor = System.Windows.Forms.Cursors.Hand;
		A7850E91.Location = new System.Drawing.Point(10, 82);
		A7850E91.Name = "ckbShareWall";
		A7850E91.Size = new System.Drawing.Size(89, 20);
		A7850E91.TabIndex = 8;
		A7850E91.Text = "Share Wall";
		A7850E91.UseVisualStyleBackColor = true;
		A7850E91.CheckedChanged += new System.EventHandler(A7850E91_CheckedChanged);
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(10, 111);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(81, 20);
		ckbComment.TabIndex = 9;
		ckbComment.Text = "Comment";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		plCountComment.Controls.Add(nudCountCommentFrom);
		plCountComment.Controls.Add(label13);
		plCountComment.Controls.Add(CB1E9199);
		plCountComment.Controls.Add(nudCountCommentTo);
		plCountComment.Location = new System.Drawing.Point(117, 110);
		plCountComment.Name = "plCountComment";
		plCountComment.Size = new System.Drawing.Size(196, 25);
		plCountComment.TabIndex = 118;
		nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentFrom.Name = "nudCountCommentFrom";
		nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		nudCountCommentFrom.TabIndex = 1;
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(156, 3);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(24, 16);
		label13.TabIndex = 35;
		label13.Text = "lần";
		CB1E9199.Location = new System.Drawing.Point(63, 3);
		CB1E9199.Name = "label14";
		CB1E9199.Size = new System.Drawing.Size(29, 16);
		CB1E9199.TabIndex = 37;
		CB1E9199.Text = "đê\u0301n";
		CB1E9199.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
		nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentTo.Name = "nudCountCommentTo";
		nudCountCommentTo.Size = new System.Drawing.Size(56, 23);
		nudCountCommentTo.TabIndex = 2;
		label18.AutoSize = true;
		label18.Location = new System.Drawing.Point(273, 25);
		label18.Name = "label18";
		label18.Size = new System.Drawing.Size(30, 16);
		label18.TabIndex = 112;
		label18.Text = "giây";
		plCountShareWall.Controls.Add(F1250B9F);
		plCountShareWall.Controls.Add(label11);
		plCountShareWall.Controls.Add(label12);
		plCountShareWall.Controls.Add(nudCountShareTo);
		plCountShareWall.Location = new System.Drawing.Point(117, 80);
		plCountShareWall.Name = "plCountShareWall";
		plCountShareWall.Size = new System.Drawing.Size(196, 25);
		plCountShareWall.TabIndex = 117;
		F1250B9F.Location = new System.Drawing.Point(1, 1);
		F1250B9F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F1250B9F.Name = "nudCountShareFrom";
		F1250B9F.Size = new System.Drawing.Size(56, 23);
		F1250B9F.TabIndex = 1;
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(156, 3);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(24, 16);
		label11.TabIndex = 35;
		label11.Text = "lần";
		label12.Location = new System.Drawing.Point(63, 3);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(29, 16);
		label12.TabIndex = 37;
		label12.Text = "đê\u0301n";
		label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountShareTo.Location = new System.Drawing.Point(98, 1);
		nudCountShareTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountShareTo.Name = "nudCountShareTo";
		nudCountShareTo.Size = new System.Drawing.Size(56, 23);
		nudCountShareTo.TabIndex = 2;
		plCountLike.Controls.Add(nudCountLikeFrom);
		plCountLike.Controls.Add(EEA2B799);
		plCountLike.Controls.Add(label10);
		plCountLike.Controls.Add(B294142D);
		plCountLike.Location = new System.Drawing.Point(117, 51);
		plCountLike.Name = "plCountLike";
		plCountLike.Size = new System.Drawing.Size(196, 25);
		plCountLike.TabIndex = 116;
		nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeFrom.Name = "nudCountLikeFrom";
		nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		nudCountLikeFrom.TabIndex = 1;
		EEA2B799.AutoSize = true;
		EEA2B799.Location = new System.Drawing.Point(156, 3);
		EEA2B799.Name = "label2";
		EEA2B799.Size = new System.Drawing.Size(24, 16);
		EEA2B799.TabIndex = 35;
		EEA2B799.Text = "lần";
		label10.Location = new System.Drawing.Point(63, 3);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(29, 16);
		label10.TabIndex = 37;
		label10.Text = "đê\u0301n";
		label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B294142D.Location = new System.Drawing.Point(98, 1);
		B294142D.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B294142D.Name = "nudCountLikeTo";
		B294142D.Size = new System.Drawing.Size(56, 23);
		B294142D.TabIndex = 2;
		label16.Location = new System.Drawing.Point(179, 25);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(29, 16);
		label16.TabIndex = 114;
		label16.Text = "đê\u0301n";
		label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E3A50A15.Location = new System.Drawing.Point(215, 23);
		E3A50A15.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E3A50A15.Name = "nudTimeTo";
		E3A50A15.Size = new System.Drawing.Size(56, 23);
		E3A50A15.TabIndex = 107;
		nudTimeFrom.Location = new System.Drawing.Point(117, 23);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 106;
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(18, 82);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(106, 16);
		label49.TabIndex = 121;
		label49.Text = "Sô\u0301 lươ\u0323ng ba\u0323n be\u0300:";
		nudSoLuongBanBeFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongBanBeFrom.Location = new System.Drawing.Point(129, 80);
		nudSoLuongBanBeFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBanBeFrom.Name = "nudSoLuongBanBeFrom";
		nudSoLuongBanBeFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBanBeFrom.TabIndex = 119;
		nudSoLuongBanBeFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label68.AutoSize = true;
		label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label68.Location = new System.Drawing.Point(287, 82);
		label68.Name = "label68";
		label68.Size = new System.Drawing.Size(28, 16);
		label68.TabIndex = 122;
		label68.Text = "ba\u0323n";
		nudSoLuongBanBeTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongBanBeTo.Location = new System.Drawing.Point(226, 80);
		nudSoLuongBanBeTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBanBeTo.Name = "nudSoLuongBanBeTo";
		nudSoLuongBanBeTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBanBeTo.TabIndex = 120;
		nudSoLuongBanBeTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		F23E5B2A.AutoSize = true;
		F23E5B2A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F23E5B2A.Location = new System.Drawing.Point(191, 82);
		F23E5B2A.Name = "label66";
		F23E5B2A.Size = new System.Drawing.Size(28, 16);
		F23E5B2A.TabIndex = 123;
		F23E5B2A.Text = "đê\u0301n";
		txtTenHanhDong.Location = new System.Drawing.Point(129, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(213, 23);
		txtTenHanhDong.TabIndex = 0;
		A91DD7AE.AutoSize = true;
		A91DD7AE.Location = new System.Drawing.Point(18, 52);
		A91DD7AE.Name = "label1";
		A91DD7AE.Size = new System.Drawing.Size(98, 16);
		A91DD7AE.TabIndex = 31;
		A91DD7AE.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(186, 440);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(CDAD3613);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(79, 440);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 11;
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
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 482);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(E9878731);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		plCountComment.ResumeLayout(false);
		plCountComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).EndInit();
		plCountShareWall.ResumeLayout(false);
		plCountShareWall.PerformLayout();
		((System.ComponentModel.ISupportInitialize)F1250B9F).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountShareTo).EndInit();
		plCountLike.ResumeLayout(false);
		plCountLike.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)B294142D).EndInit();
		((System.ComponentModel.ISupportInitialize)E3A50A15).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBanBeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBanBeTo).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
