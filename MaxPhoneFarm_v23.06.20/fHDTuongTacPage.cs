using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacPage : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int int_0;

	internal static bool D700B89E;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button btnCancel;

	internal Button AF0D5A2D;

	internal BunifuCards B8204636;

	internal Panel D28DD729;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label EF0B819C;

	internal Label D8314693;

	internal CheckBox ckbComment;

	internal CheckBox ckbInteract;

	internal CheckBox ckbShareWall;

	internal RadioButton E5ADF318;

	internal RadioButton FF11D0B9;

	internal Label label9;

	internal Button C08E1FAD;

	internal Button C8AB4EBC;

	internal RichTextBox FC2B8710;

	internal Panel plCountComment;

	internal NumericUpDown nudCountCommentFrom;

	internal Label F5334780;

	internal Label EEABFC04;

	internal NumericUpDown nudCountCommentTo;

	internal Panel plCountShareWall;

	internal NumericUpDown nudCountShareFrom;

	internal Label label11;

	internal Label label12;

	internal NumericUpDown nudCountShareTo;

	internal Panel A9B7E790;

	internal NumericUpDown nudCountLikeFrom;

	internal Label label2;

	internal Label label10;

	internal NumericUpDown nudCountLikeTo;

	internal NumericUpDown B1B04633;

	internal NumericUpDown C3BBEB2C;

	internal Label D79AC517;

	internal Label E7113221;

	internal Label E52E1310;

	internal GroupBox groupBox1;

	internal Label label49;

	internal NumericUpDown nudSoLuongPageFrom;

	internal Label E52D1731;

	internal NumericUpDown B901DFBD;

	internal Label C991ECBC;

	internal Button btnMinimize;

	internal RichTextBox txtUid;

	internal Label label3;

	internal Label E02EE9B0;

	internal CheckBox CA0B7411;

	public fHDTuongTacPage(string B495D8B9, int int_1 = 0, string FD17FF8F = "")
	{
		InitializeComponent();
		D700B89E = false;
		string_0 = B495D8B9;
		string_2 = FD17FF8F;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDTuongTacPage").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacPage', 'Tương tác Page');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDTuongTacPage");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(FD17FF8F);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			AF0D5A2D.Text = "Câ\u0323p nhâ\u0323t";
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void D09361AF()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(label49);
		Language.smethod_1(C991ECBC);
		Language.smethod_1(E52D1731);
		Language.smethod_1(groupBox1);
		Language.smethod_1(E52E1310);
		Language.smethod_1(D79AC517);
		Language.smethod_1(E7113221);
		Language.smethod_1(ckbInteract);
		Language.smethod_1(label10);
		Language.smethod_1(label2);
		Language.smethod_1(label12);
		Language.smethod_1(label11);
		Language.smethod_1(EEABFC04);
		Language.smethod_1(F5334780);
		Language.smethod_1(D8314693);
		Language.smethod_1(EF0B819C);
		Language.smethod_1(label9);
		Language.smethod_1(FF11D0B9);
		Language.smethod_1(E5ADF318);
		Language.smethod_1(AF0D5A2D);
		Language.smethod_1(btnCancel);
		Language.smethod_1(E02EE9B0);
		Language.smethod_1(label3);
		Language.smethod_1(CA0B7411);
	}

	private void EC29A885(object sender, EventArgs e)
	{
		try
		{
			txtUid.Text = f72FAFBC_0.GetValue("txtUid");
			CA0B7411.Checked = f72FAFBC_0.AA824D29("ckbTuDongXoaUid");
			nudSoLuongPageFrom.Value = f72FAFBC_0.method_0("nudSoLuongPageFrom", 1);
			B901DFBD.Value = f72FAFBC_0.method_0("nudSoLuongPageTo", 3);
			C3BBEB2C.Value = f72FAFBC_0.method_0("nudTimeFrom", 10);
			B1B04633.Value = f72FAFBC_0.method_0("nudTimeTo", 30);
			nudCountLikeFrom.Value = f72FAFBC_0.method_0("nudCountLikeFrom", 1);
			nudCountLikeTo.Value = f72FAFBC_0.method_0("nudCountLikeTo", 3);
			nudCountShareFrom.Value = f72FAFBC_0.method_0("nudCountShareFrom", 1);
			nudCountShareTo.Value = f72FAFBC_0.method_0("nudCountShareTo", 3);
			nudCountCommentFrom.Value = f72FAFBC_0.method_0("nudCountCommentFrom", 1);
			nudCountCommentTo.Value = f72FAFBC_0.method_0("nudCountCommentTo", 3);
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			ckbShareWall.Checked = f72FAFBC_0.AA824D29("ckbShareWall");
			ckbComment.Checked = f72FAFBC_0.AA824D29("ckbComment");
			FC2B8710.Text = f72FAFBC_0.GetValue("txtComment");
			if (f72FAFBC_0.method_0("typeNganCach") == 1)
			{
				E5ADF318.Checked = true;
			}
			else
			{
				FF11D0B9.Checked = true;
			}
		}
		catch
		{
		}
		method_2();
	}

	private void A48E180F(object sender, EventArgs e)
	{
		Close();
	}

	private void AF0D5A2D_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> f1808BA = FC2B8710.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!", 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtUid", (object)txtUid.Text.Trim());
		f72FAFBC.GetValue("ckbTuDongXoaUid", CA0B7411.Checked);
		f72FAFBC.GetValue("nudSoLuongPageFrom", nudSoLuongPageFrom.Value);
		f72FAFBC.GetValue("nudSoLuongPageTo", B901DFBD.Value);
		f72FAFBC.GetValue("nudTimeFrom", C3BBEB2C.Value);
		f72FAFBC.GetValue("nudTimeTo", B1B04633.Value);
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		f72FAFBC.GetValue("ckbShareWall", ckbShareWall.Checked);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)FC2B8710.Text.Trim());
		f72FAFBC.GetValue("nudCountLikeFrom", nudCountLikeFrom.Value);
		f72FAFBC.GetValue("nudCountLikeTo", nudCountLikeTo.Value);
		f72FAFBC.GetValue("nudCountShareFrom", nudCountShareFrom.Value);
		f72FAFBC.GetValue("nudCountShareTo", nudCountShareTo.Value);
		f72FAFBC.GetValue("nudCountCommentFrom", nudCountCommentFrom.Value);
		f72FAFBC.GetValue("nudCountCommentTo", nudCountCommentTo.Value);
		int num = 0;
		if (E5ADF318.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, d9253C2E))
				{
					D700B89E = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class123.smethod_14(string_2, text, d9253C2E))
			{
				D700B89E = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
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

	private void method_0(object sender, EventArgs e)
	{
	}

	private void CF371C0E(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!FF11D0B9.Checked) ? FC2B8710.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : FC2B8710.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			D8314693.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_2()
	{
		ckbInteract_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
		E29B8792(null, null);
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plCountComment.Enabled = ckbComment.Checked;
		plComment.Enabled = ckbComment.Checked;
	}

	private void C8AB4EBC_Click(object sender, EventArgs e)
	{
		groupBox1.Height = 312;
	}

	private void F6843686(object sender, EventArgs e)
	{
		groupBox1.Height = 353;
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			C8AB4EBC.Visible = true;
			C08E1FAD.Visible = true;
		}
	}

	private void FF11D0B9_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void E5ADF318_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		A9B7E790.Enabled = ckbInteract.Checked;
	}

	private void E29B8792(object sender, EventArgs e)
	{
		plCountShareWall.Enabled = ckbShareWall.Checked;
	}

	private void A61C7C2D(object sender, EventArgs e)
	{
		Common.D936DD84(txtUid, E02EE9B0);
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
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D28DD729 = new System.Windows.Forms.Panel();
		btnMinimize = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		CA0B7411 = new System.Windows.Forms.CheckBox();
		txtUid = new System.Windows.Forms.RichTextBox();
		label3 = new System.Windows.Forms.Label();
		E02EE9B0 = new System.Windows.Forms.Label();
		groupBox1 = new System.Windows.Forms.GroupBox();
		plComment = new System.Windows.Forms.Panel();
		FC2B8710 = new System.Windows.Forms.RichTextBox();
		C08E1FAD = new System.Windows.Forms.Button();
		C8AB4EBC = new System.Windows.Forms.Button();
		E5ADF318 = new System.Windows.Forms.RadioButton();
		FF11D0B9 = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		EF0B819C = new System.Windows.Forms.Label();
		D8314693 = new System.Windows.Forms.Label();
		E52E1310 = new System.Windows.Forms.Label();
		ckbInteract = new System.Windows.Forms.CheckBox();
		ckbShareWall = new System.Windows.Forms.CheckBox();
		ckbComment = new System.Windows.Forms.CheckBox();
		plCountComment = new System.Windows.Forms.Panel();
		nudCountCommentFrom = new System.Windows.Forms.NumericUpDown();
		F5334780 = new System.Windows.Forms.Label();
		EEABFC04 = new System.Windows.Forms.Label();
		nudCountCommentTo = new System.Windows.Forms.NumericUpDown();
		E7113221 = new System.Windows.Forms.Label();
		plCountShareWall = new System.Windows.Forms.Panel();
		nudCountShareFrom = new System.Windows.Forms.NumericUpDown();
		label11 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		nudCountShareTo = new System.Windows.Forms.NumericUpDown();
		A9B7E790 = new System.Windows.Forms.Panel();
		nudCountLikeFrom = new System.Windows.Forms.NumericUpDown();
		label2 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		nudCountLikeTo = new System.Windows.Forms.NumericUpDown();
		D79AC517 = new System.Windows.Forms.Label();
		B1B04633 = new System.Windows.Forms.NumericUpDown();
		C3BBEB2C = new System.Windows.Forms.NumericUpDown();
		label49 = new System.Windows.Forms.Label();
		nudSoLuongPageFrom = new System.Windows.Forms.NumericUpDown();
		E52D1731 = new System.Windows.Forms.Label();
		B901DFBD = new System.Windows.Forms.NumericUpDown();
		C991ECBC = new System.Windows.Forms.Label();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		AF0D5A2D = new System.Windows.Forms.Button();
		B8204636 = new Bunifu.Framework.UI.BunifuCards();
		D28DD729.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		groupBox1.SuspendLayout();
		plComment.SuspendLayout();
		plCountComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountCommentFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountCommentTo).BeginInit();
		plCountShareWall.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountShareTo).BeginInit();
		A9B7E790.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)B1B04633).BeginInit();
		((System.ComponentModel.ISupportInitialize)C3BBEB2C).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongPageFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)B901DFBD).BeginInit();
		B8204636.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(687, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tương tác Page";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = D28DD729;
		bunifuDragControl_1.Vertical = true;
		D28DD729.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D28DD729.BackColor = System.Drawing.Color.White;
		D28DD729.Controls.Add(btnMinimize);
		D28DD729.Controls.Add(pictureBox1);
		D28DD729.Controls.Add(bunifuCustomLabel1);
		D28DD729.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D28DD729.Location = new System.Drawing.Point(0, 3);
		D28DD729.Name = "pnlHeader";
		D28DD729.Size = new System.Drawing.Size(687, 31);
		D28DD729.TabIndex = 9;
		btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = Resource.Bitmap_9;
		btnMinimize.Location = new System.Drawing.Point(654, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 78;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(A48E180F);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(CA0B7411);
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(E02EE9B0);
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(nudSoLuongPageFrom);
		panel1.Controls.Add(E52D1731);
		panel1.Controls.Add(B901DFBD);
		panel1.Controls.Add(C991ECBC);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(AF0D5A2D);
		panel1.Controls.Add(B8204636);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(690, 453);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		CA0B7411.AutoSize = true;
		CA0B7411.Cursor = System.Windows.Forms.Cursors.Hand;
		CA0B7411.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		CA0B7411.Location = new System.Drawing.Point(24, 371);
		CA0B7411.Name = "ckbTuDongXoaUid";
		CA0B7411.Size = new System.Drawing.Size(229, 20);
		CA0B7411.TabIndex = 128;
		CA0B7411.Text = "Tư\u0323 đô\u0323ng xo\u0301a Uid page đa\u0303 tương tác";
		CA0B7411.UseVisualStyleBackColor = true;
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(25, 130);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(295, 219);
		txtUid.TabIndex = 127;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(A61C7C2D);
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(222, 352);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(103, 16);
		label3.TabIndex = 125;
		label3.Text = "(Mỗi Uid 1 dòng)";
		E02EE9B0.AutoSize = true;
		E02EE9B0.Location = new System.Drawing.Point(21, 110);
		E02EE9B0.Name = "lblUid";
		E02EE9B0.Size = new System.Drawing.Size(147, 16);
		E02EE9B0.TabIndex = 126;
		E02EE9B0.Text = "Danh sa\u0301ch Uid Page (0):";
		groupBox1.Controls.Add(plComment);
		groupBox1.Controls.Add(E52E1310);
		groupBox1.Controls.Add(ckbInteract);
		groupBox1.Controls.Add(ckbShareWall);
		groupBox1.Controls.Add(ckbComment);
		groupBox1.Controls.Add(plCountComment);
		groupBox1.Controls.Add(E7113221);
		groupBox1.Controls.Add(plCountShareWall);
		groupBox1.Controls.Add(A9B7E790);
		groupBox1.Controls.Add(D79AC517);
		groupBox1.Controls.Add(B1B04633);
		groupBox1.Controls.Add(C3BBEB2C);
		groupBox1.Location = new System.Drawing.Point(344, 80);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(321, 312);
		groupBox1.TabIndex = 124;
		groupBox1.TabStop = false;
		groupBox1.Text = "Cấu hình tương tác/Page";
		plComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(FC2B8710);
		plComment.Controls.Add(C08E1FAD);
		plComment.Controls.Add(C8AB4EBC);
		plComment.Controls.Add(E5ADF318);
		plComment.Controls.Add(FF11D0B9);
		plComment.Controls.Add(label9);
		plComment.Controls.Add(EF0B819C);
		plComment.Controls.Add(D8314693);
		plComment.Location = new System.Drawing.Point(30, 140);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(281, 163);
		plComment.TabIndex = 10;
		FC2B8710.Location = new System.Drawing.Point(7, 27);
		FC2B8710.Name = "txtComment";
		FC2B8710.Size = new System.Drawing.Size(266, 111);
		FC2B8710.TabIndex = 106;
		FC2B8710.Text = "";
		FC2B8710.WordWrap = false;
		FC2B8710.TextChanged += new System.EventHandler(CF371C0E);
		C08E1FAD.BackgroundImage = Resource.Bitmap_91;
		C08E1FAD.Cursor = System.Windows.Forms.Cursors.Hand;
		C08E1FAD.Location = new System.Drawing.Point(224, -1);
		C08E1FAD.Name = "btnDown";
		C08E1FAD.Size = new System.Drawing.Size(25, 25);
		C08E1FAD.TabIndex = 7;
		C08E1FAD.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		C08E1FAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C08E1FAD.Visible = false;
		C08E1FAD.Click += new System.EventHandler(F6843686);
		C8AB4EBC.BackgroundImage = Resource.Bitmap_73;
		C8AB4EBC.Cursor = System.Windows.Forms.Cursors.Hand;
		C8AB4EBC.Location = new System.Drawing.Point(255, -1);
		C8AB4EBC.Name = "btnUp";
		C8AB4EBC.Size = new System.Drawing.Size(25, 25);
		C8AB4EBC.TabIndex = 7;
		C8AB4EBC.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		C8AB4EBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C8AB4EBC.Visible = false;
		C8AB4EBC.Click += new System.EventHandler(C8AB4EBC_Click);
		E5ADF318.AutoSize = true;
		E5ADF318.Cursor = System.Windows.Forms.Cursors.Hand;
		E5ADF318.Location = new System.Drawing.Point(69, 182);
		E5ADF318.Name = "rbNganCachKyTu";
		E5ADF318.Size = new System.Drawing.Size(203, 20);
		E5ADF318.TabIndex = 6;
		E5ADF318.Text = "Các nội dung ngăn cách bởi \"|\"";
		E5ADF318.UseVisualStyleBackColor = true;
		E5ADF318.CheckedChanged += new System.EventHandler(E5ADF318_CheckedChanged);
		FF11D0B9.AutoSize = true;
		FF11D0B9.Checked = true;
		FF11D0B9.Cursor = System.Windows.Forms.Cursors.Hand;
		FF11D0B9.Location = new System.Drawing.Point(69, 161);
		FF11D0B9.Name = "rbNganCachMoiDong";
		FF11D0B9.Size = new System.Drawing.Size(171, 20);
		FF11D0B9.TabIndex = 5;
		FF11D0B9.TabStop = true;
		FF11D0B9.Text = "Mỗi dòng là một nội dung";
		FF11D0B9.UseVisualStyleBackColor = true;
		FF11D0B9.CheckedChanged += new System.EventHandler(FF11D0B9_CheckedChanged);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(4, 161);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(65, 16);
		label9.TabIndex = 4;
		label9.Text = "Tùy chọn:";
		EF0B819C.AutoSize = true;
		EF0B819C.Location = new System.Drawing.Point(4, 141);
		EF0B819C.Name = "label8";
		EF0B819C.Size = new System.Drawing.Size(266, 16);
		EF0B819C.TabIndex = 0;
		EF0B819C.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		D8314693.AutoSize = true;
		D8314693.Location = new System.Drawing.Point(3, 5);
		D8314693.Name = "lblStatus";
		D8314693.Size = new System.Drawing.Size(140, 16);
		D8314693.TabIndex = 0;
		D8314693.Text = "Nội dung bình luận (0):";
		E52E1310.AutoSize = true;
		E52E1310.Location = new System.Drawing.Point(6, 25);
		E52E1310.Name = "label21";
		E52E1310.Size = new System.Drawing.Size(92, 16);
		E52E1310.TabIndex = 110;
		E52E1310.Text = "Thơ\u0300i gian lươ\u0301t:";
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(9, 53);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(76, 20);
		ckbInteract.TabIndex = 7;
		ckbInteract.Text = "Cảm xúc";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareWall.Location = new System.Drawing.Point(9, 82);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new System.Drawing.Size(90, 20);
		ckbShareWall.TabIndex = 8;
		ckbShareWall.Text = "Share Wall";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbShareWall.CheckedChanged += new System.EventHandler(E29B8792);
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(9, 111);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(82, 20);
		ckbComment.TabIndex = 9;
		ckbComment.Text = "Comment";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		plCountComment.Controls.Add(nudCountCommentFrom);
		plCountComment.Controls.Add(F5334780);
		plCountComment.Controls.Add(EEABFC04);
		plCountComment.Controls.Add(nudCountCommentTo);
		plCountComment.Location = new System.Drawing.Point(116, 110);
		plCountComment.Name = "plCountComment";
		plCountComment.Size = new System.Drawing.Size(196, 25);
		plCountComment.TabIndex = 118;
		nudCountCommentFrom.Location = new System.Drawing.Point(1, 1);
		nudCountCommentFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentFrom.Name = "nudCountCommentFrom";
		nudCountCommentFrom.Size = new System.Drawing.Size(56, 23);
		nudCountCommentFrom.TabIndex = 1;
		F5334780.AutoSize = true;
		F5334780.Location = new System.Drawing.Point(159, 3);
		F5334780.Name = "label13";
		F5334780.Size = new System.Drawing.Size(30, 16);
		F5334780.TabIndex = 35;
		F5334780.Text = "lươ\u0323t";
		EEABFC04.Location = new System.Drawing.Point(63, 3);
		EEABFC04.Name = "label14";
		EEABFC04.Size = new System.Drawing.Size(29, 16);
		EEABFC04.TabIndex = 37;
		EEABFC04.Text = "đê\u0301n";
		EEABFC04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudCountCommentTo.Location = new System.Drawing.Point(98, 1);
		nudCountCommentTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountCommentTo.Name = "nudCountCommentTo";
		nudCountCommentTo.Size = new System.Drawing.Size(56, 23);
		nudCountCommentTo.TabIndex = 2;
		E7113221.AutoSize = true;
		E7113221.Location = new System.Drawing.Point(275, 25);
		E7113221.Name = "label18";
		E7113221.Size = new System.Drawing.Size(31, 16);
		E7113221.TabIndex = 112;
		E7113221.Text = "giây";
		plCountShareWall.Controls.Add(nudCountShareFrom);
		plCountShareWall.Controls.Add(label11);
		plCountShareWall.Controls.Add(label12);
		plCountShareWall.Controls.Add(nudCountShareTo);
		plCountShareWall.Location = new System.Drawing.Point(116, 80);
		plCountShareWall.Name = "plCountShareWall";
		plCountShareWall.Size = new System.Drawing.Size(196, 25);
		plCountShareWall.TabIndex = 117;
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
		A9B7E790.Controls.Add(nudCountLikeFrom);
		A9B7E790.Controls.Add(label2);
		A9B7E790.Controls.Add(label10);
		A9B7E790.Controls.Add(nudCountLikeTo);
		A9B7E790.Location = new System.Drawing.Point(116, 51);
		A9B7E790.Name = "plCountLike";
		A9B7E790.Size = new System.Drawing.Size(196, 25);
		A9B7E790.TabIndex = 116;
		nudCountLikeFrom.Location = new System.Drawing.Point(1, 1);
		nudCountLikeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLikeFrom.Name = "nudCountLikeFrom";
		nudCountLikeFrom.Size = new System.Drawing.Size(56, 23);
		nudCountLikeFrom.TabIndex = 1;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(159, 3);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(30, 16);
		label2.TabIndex = 35;
		label2.Text = "lươ\u0323t";
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
		D79AC517.Location = new System.Drawing.Point(179, 25);
		D79AC517.Name = "label16";
		D79AC517.Size = new System.Drawing.Size(29, 16);
		D79AC517.TabIndex = 114;
		D79AC517.Text = "đê\u0301n";
		D79AC517.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B1B04633.Location = new System.Drawing.Point(214, 23);
		B1B04633.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B1B04633.Name = "nudTimeTo";
		B1B04633.Size = new System.Drawing.Size(56, 23);
		B1B04633.TabIndex = 107;
		C3BBEB2C.Location = new System.Drawing.Point(117, 23);
		C3BBEB2C.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C3BBEB2C.Name = "nudTimeFrom";
		C3BBEB2C.Size = new System.Drawing.Size(56, 23);
		C3BBEB2C.TabIndex = 106;
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(21, 82);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(96, 16);
		label49.TabIndex = 121;
		label49.Text = "Sô\u0301 lươ\u0323ng page:";
		nudSoLuongPageFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongPageFrom.Location = new System.Drawing.Point(132, 80);
		nudSoLuongPageFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongPageFrom.Name = "nudSoLuongPageFrom";
		nudSoLuongPageFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongPageFrom.TabIndex = 119;
		nudSoLuongPageFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		E52D1731.AutoSize = true;
		E52D1731.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		E52D1731.Location = new System.Drawing.Point(290, 82);
		E52D1731.Name = "label68";
		E52D1731.Size = new System.Drawing.Size(36, 16);
		E52D1731.TabIndex = 122;
		E52D1731.Text = "page";
		B901DFBD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B901DFBD.Location = new System.Drawing.Point(229, 80);
		B901DFBD.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		B901DFBD.Name = "nudSoLuongPageTo";
		B901DFBD.Size = new System.Drawing.Size(56, 23);
		B901DFBD.TabIndex = 120;
		B901DFBD.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		C991ECBC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C991ECBC.Location = new System.Drawing.Point(194, 82);
		C991ECBC.Name = "label66";
		C991ECBC.Size = new System.Drawing.Size(29, 16);
		C991ECBC.TabIndex = 123;
		C991ECBC.Text = "đê\u0301n";
		C991ECBC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(188, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(21, 52);
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
		btnCancel.Location = new System.Drawing.Point(354, 407);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		AF0D5A2D.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		AF0D5A2D.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		AF0D5A2D.Cursor = System.Windows.Forms.Cursors.Hand;
		AF0D5A2D.FlatAppearance.BorderSize = 0;
		AF0D5A2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AF0D5A2D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AF0D5A2D.ForeColor = System.Drawing.Color.White;
		AF0D5A2D.Location = new System.Drawing.Point(241, 407);
		AF0D5A2D.Name = "btnAdd";
		AF0D5A2D.Size = new System.Drawing.Size(92, 29);
		AF0D5A2D.TabIndex = 11;
		AF0D5A2D.Text = "Thêm";
		AF0D5A2D.UseVisualStyleBackColor = false;
		AF0D5A2D.Click += new System.EventHandler(AF0D5A2D_Click);
		B8204636.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B8204636.BackColor = System.Drawing.Color.White;
		B8204636.BorderRadius = 0;
		B8204636.BottomSahddow = true;
		B8204636.color = System.Drawing.Color.DarkViolet;
		B8204636.Controls.Add(D28DD729);
		B8204636.LeftSahddow = false;
		B8204636.Location = new System.Drawing.Point(1, 0);
		B8204636.Name = "bunifuCards1";
		B8204636.RightSahddow = true;
		B8204636.ShadowDepth = 20;
		B8204636.Size = new System.Drawing.Size(687, 37);
		B8204636.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(690, 453);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacPage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(EC29A885);
		D28DD729.ResumeLayout(false);
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
		((System.ComponentModel.ISupportInitialize)nudCountShareFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountShareTo).EndInit();
		A9B7E790.ResumeLayout(false);
		A9B7E790.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountLikeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLikeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)B1B04633).EndInit();
		((System.ComponentModel.ISupportInitialize)C3BBEB2C).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongPageFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)B901DFBD).EndInit();
		B8204636.ResumeLayout(false);
		ResumeLayout(false);
	}
}
