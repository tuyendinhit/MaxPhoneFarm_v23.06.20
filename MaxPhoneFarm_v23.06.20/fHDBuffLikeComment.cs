using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBuffLikeComment : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string DBB56439;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer D492AFA0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl C624EE2D;

	internal Panel panel1;

	internal NumericUpDown A9A36590;

	internal NumericUpDown nudDelayFrom;

	internal TextBox txtTenHanhDong;

	internal Label label7;

	internal Label label6;

	internal Label label5;

	internal Label D3A65F0D;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards AA2EDE8D;

	internal Panel A223AEAF;

	internal Button button1;

	internal PictureBox FA28652B;

	internal BunifuCustomLabel D7124088;

	internal CheckBox D2936D88;

	internal CheckBox C82883AB;

	internal Label C7B50B11;

	internal Label label2;

	internal NumericUpDown DB36E026;

	internal NumericUpDown nudTimeFrom;

	internal Label label9;

	internal Label label4;

	internal Label label3;

	internal Panel C63C0433;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton C3820923;

	internal Label label8;

	internal RichTextBox A2BBF0BC;

	internal Label label11;

	internal Label lblStatus;

	internal Panel plAnh;

	internal TextBox txtAnh;

	internal RichTextBox txtIdPost;

	internal CheckBox D6BA35B9;

	internal CheckBox ckbComment;

	internal Label CD10A59E;

	internal Label label49;

	internal NumericUpDown nudSoLuongUidFrom;

	internal Label label68;

	internal NumericUpDown E296AC22;

	internal Label label66;

	internal RadioButton A9224F9C;

	internal RadioButton rbCommentTheoThuTu;

	internal Label AD062125;

	internal Button btnDown;

	internal Button E6B4073E;

	internal Panel panel2;

	internal Panel panel3;

	internal Button C5823631;

	internal Button button2;

	internal Button button4;

	public fHDBuffLikeComment(string D0992A90, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		DBB56439 = D0992A90;
		string_1 = string_2;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDBuffLikeComment").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDBuffLikeComment', 'Buff Like, Comment');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDBuffLikeComment");
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
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDBuffLikeComment_Load(object sender, EventArgs e)
	{
		try
		{
			nudTimeFrom.Value = f72FAFBC_0.method_0("nudTimeFrom", 3);
			DB36E026.Value = f72FAFBC_0.method_0("nudTimeTo", 5);
			nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			A9A36590.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			nudSoLuongUidFrom.Value = f72FAFBC_0.method_0("nudSoLuongUidFrom", 1);
			E296AC22.Value = f72FAFBC_0.method_0("nudSoLuongUidTo", 3);
			D2936D88.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			C82883AB.Checked = f72FAFBC_0.AA824D29("ckbShareWall");
			ckbComment.Checked = f72FAFBC_0.AA824D29("ckbComment");
			A2BBF0BC.Text = f72FAFBC_0.GetValue("txtComment");
			txtIdPost.Text = f72FAFBC_0.GetValue("txtIdPost");
			D6BA35B9.Checked = f72FAFBC_0.AA824D29("ckbSendAnh");
			txtAnh.Text = f72FAFBC_0.GetValue("txtAnh");
			if (f72FAFBC_0.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				C3820923.Checked = true;
			}
			if (f72FAFBC_0.method_0("typeComment") == 1)
			{
				A9224F9C.Checked = true;
			}
			else
			{
				rbCommentTheoThuTu.Checked = true;
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

	private void BBA05223(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
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
		if (ckbComment.Checked)
		{
			List<string> f1808BA2 = A2BBF0BC.Lines.ToList();
			f1808BA2 = Common.RemoveEmptyItems(f1808BA2);
			if (f1808BA2.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudTimeFrom", nudTimeFrom.Value);
		f72FAFBC.GetValue("nudTimeTo", DB36E026.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", A9A36590.Value);
		f72FAFBC.GetValue("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		f72FAFBC.GetValue("nudSoLuongUidTo", E296AC22.Value);
		f72FAFBC.GetValue("ckbInteract", D2936D88.Checked);
		f72FAFBC.GetValue("ckbShareWall", C82883AB.Checked);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)A2BBF0BC.Text.Trim());
		f72FAFBC.GetValue("txtIdPost", (object)txtIdPost.Text.Trim());
		f72FAFBC.GetValue("ckbSendAnh", D6BA35B9.Checked);
		f72FAFBC.GetValue("txtAnh", (object)txtAnh.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		int num2 = 0;
		if (A9224F9C.Checked)
		{
			num2 = 1;
		}
		f72FAFBC.GetValue("typeComment", num2);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(DBB56439, text, string_0, text2))
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DC221102(object sender, PaintEventArgs e)
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
		try
		{
			List<string> f1808BA = A2BBF0BC.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		method_2(null, null);
		EA9A3400(null, null);
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void EA9A3400(object sender, EventArgs e)
	{
		C63C0433.Enabled = ckbComment.Checked;
	}

	private void F09D392F(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtIdPost.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			label2.Text = string.Format(Language.GetValue("Danh sa\u0301ch ID bài viết ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void D6BA35B9_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = D6BA35B9.Checked;
	}

	private void panel1_Click(object sender, EventArgs e)
	{
	}

	private void FA28652B_Click(object sender, EventArgs e)
	{
	}

	private void CD10A59E_Click(object sender, EventArgs e)
	{
	}

	private void rbCommentTheoThuTu_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void AD062125_Click(object sender, EventArgs e)
	{
	}

	private void A9224F9C_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void DD16E5B0(object sender, EventArgs e)
	{
		C63C0433.Height = 195;
	}

	private void E41BDC86(object sender, EventArgs e)
	{
		C63C0433.Height = 237;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		A2BBF0BC.Focus();
	}

	private void D106C33C(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		A2BBF0BC.Focus();
	}

	private void AA1E8A9F(object sender, EventArgs e)
	{
	}

	private void button4_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	private void C3820923_CheckedChanged(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && D492AFA0 != null)
		{
			D492AFA0.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		D492AFA0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBuffLikeComment));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(D492AFA0);
		D7124088 = new Bunifu.Framework.UI.BunifuCustomLabel();
		C624EE2D = new Bunifu.Framework.UI.BunifuDragControl(D492AFA0);
		A223AEAF = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		FA28652B = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		panel2 = new System.Windows.Forms.Panel();
		C5823631 = new System.Windows.Forms.Button();
		C3820923 = new System.Windows.Forms.RadioButton();
		button2 = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		label49 = new System.Windows.Forms.Label();
		nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		label68 = new System.Windows.Forms.Label();
		E296AC22 = new System.Windows.Forms.NumericUpDown();
		label66 = new System.Windows.Forms.Label();
		C63C0433 = new System.Windows.Forms.Panel();
		panel3 = new System.Windows.Forms.Panel();
		rbCommentTheoThuTu = new System.Windows.Forms.RadioButton();
		A9224F9C = new System.Windows.Forms.RadioButton();
		btnDown = new System.Windows.Forms.Button();
		button4 = new System.Windows.Forms.Button();
		E6B4073E = new System.Windows.Forms.Button();
		AD062125 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		A2BBF0BC = new System.Windows.Forms.RichTextBox();
		label11 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		plAnh = new System.Windows.Forms.Panel();
		txtAnh = new System.Windows.Forms.TextBox();
		CD10A59E = new System.Windows.Forms.Label();
		txtIdPost = new System.Windows.Forms.RichTextBox();
		D6BA35B9 = new System.Windows.Forms.CheckBox();
		ckbComment = new System.Windows.Forms.CheckBox();
		C7B50B11 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		C82883AB = new System.Windows.Forms.CheckBox();
		D2936D88 = new System.Windows.Forms.CheckBox();
		DB36E026 = new System.Windows.Forms.NumericUpDown();
		A9A36590 = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label9 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		D3A65F0D = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		AA2EDE8D = new Bunifu.Framework.UI.BunifuCards();
		A223AEAF.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FA28652B).BeginInit();
		panel1.SuspendLayout();
		panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)E296AC22).BeginInit();
		C63C0433.SuspendLayout();
		panel3.SuspendLayout();
		plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DB36E026).BeginInit();
		((System.ComponentModel.ISupportInitialize)A9A36590).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		AA2EDE8D.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = D7124088;
		bunifuDragControl_0.Vertical = true;
		D7124088.BackColor = System.Drawing.Color.Transparent;
		D7124088.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D7124088.Dock = System.Windows.Forms.DockStyle.Fill;
		D7124088.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D7124088.ForeColor = System.Drawing.Color.Black;
		D7124088.Location = new System.Drawing.Point(0, 0);
		D7124088.Name = "bunifuCustomLabel1";
		D7124088.Size = new System.Drawing.Size(684, 31);
		D7124088.TabIndex = 12;
		D7124088.Text = "Cấu hình Buff Like, Comment ba\u0300i viê\u0301t";
		D7124088.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C624EE2D.Fixed = true;
		C624EE2D.Horizontal = true;
		C624EE2D.TargetControl = A223AEAF;
		C624EE2D.Vertical = true;
		A223AEAF.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A223AEAF.BackColor = System.Drawing.Color.White;
		A223AEAF.Controls.Add(button1);
		A223AEAF.Controls.Add(FA28652B);
		A223AEAF.Controls.Add(D7124088);
		A223AEAF.Cursor = System.Windows.Forms.Cursors.SizeAll;
		A223AEAF.Location = new System.Drawing.Point(0, 3);
		A223AEAF.Name = "pnlHeader";
		A223AEAF.Size = new System.Drawing.Size(684, 31);
		A223AEAF.TabIndex = 9;
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
		FA28652B.Cursor = System.Windows.Forms.Cursors.Default;
		FA28652B.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		FA28652B.Location = new System.Drawing.Point(3, 2);
		FA28652B.Name = "pictureBox1";
		FA28652B.Size = new System.Drawing.Size(34, 27);
		FA28652B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		FA28652B.TabIndex = 76;
		FA28652B.TabStop = false;
		FA28652B.Click += new System.EventHandler(FA28652B_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(label49);
		panel1.Controls.Add(nudSoLuongUidFrom);
		panel1.Controls.Add(label68);
		panel1.Controls.Add(E296AC22);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(C63C0433);
		panel1.Controls.Add(plAnh);
		panel1.Controls.Add(txtIdPost);
		panel1.Controls.Add(D6BA35B9);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(C7B50B11);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(C82883AB);
		panel1.Controls.Add(D2936D88);
		panel1.Controls.Add(DB36E026);
		panel1.Controls.Add(A9A36590);
		panel1.Controls.Add(nudTimeFrom);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(D3A65F0D);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(AA2EDE8D);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(687, 437);
		panel1.TabIndex = 0;
		panel1.Click += new System.EventHandler(panel1_Click);
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(DC221102);
		panel2.Controls.Add(C5823631);
		panel2.Controls.Add(C3820923);
		panel2.Controls.Add(button2);
		panel2.Controls.Add(rbNganCachKyTu);
		panel2.Location = new System.Drawing.Point(67, 147);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(200, 43);
		panel2.TabIndex = 42;
		C5823631.Cursor = System.Windows.Forms.Cursors.Help;
		C5823631.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C5823631.Location = new System.Drawing.Point(165, 22);
		C5823631.Name = "button3";
		C5823631.Size = new System.Drawing.Size(21, 21);
		C5823631.TabIndex = 172;
		C5823631.Text = "?";
		C5823631.UseVisualStyleBackColor = true;
		C5823631.Click += new System.EventHandler(D106C33C);
		C3820923.AutoSize = true;
		C3820923.Checked = true;
		C3820923.Cursor = System.Windows.Forms.Cursors.Hand;
		C3820923.Location = new System.Drawing.Point(3, 3);
		C3820923.Name = "rbNganCachMoiDong";
		C3820923.Size = new System.Drawing.Size(155, 20);
		C3820923.TabIndex = 3;
		C3820923.TabStop = true;
		C3820923.Text = "Nội dung chỉ có 1 dòng";
		C3820923.UseVisualStyleBackColor = true;
		C3820923.CheckedChanged += new System.EventHandler(C3820923_CheckedChanged);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(165, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 21);
		button2.TabIndex = 173;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(3, 24);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		rbNganCachKyTu.TabIndex = 3;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(26, 108);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(107, 16);
		label49.TabIndex = 169;
		label49.Text = "Sô\u0301 lươ\u0323ng ID/Nick:";
		nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongUidFrom.Location = new System.Drawing.Point(134, 106);
		nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongUidFrom.TabIndex = 167;
		nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label68.AutoSize = true;
		label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label68.Location = new System.Drawing.Point(289, 108);
		label68.Name = "label68";
		label68.Size = new System.Drawing.Size(19, 16);
		label68.TabIndex = 170;
		label68.Text = "ID";
		E296AC22.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		E296AC22.Location = new System.Drawing.Point(231, 106);
		E296AC22.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		E296AC22.Name = "nudSoLuongUidTo";
		E296AC22.Size = new System.Drawing.Size(56, 23);
		E296AC22.TabIndex = 168;
		E296AC22.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label66.Location = new System.Drawing.Point(196, 108);
		label66.Name = "label66";
		label66.Size = new System.Drawing.Size(29, 16);
		label66.TabIndex = 171;
		label66.Text = "đê\u0301n";
		label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C63C0433.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C63C0433.Controls.Add(panel2);
		C63C0433.Controls.Add(panel3);
		C63C0433.Controls.Add(btnDown);
		C63C0433.Controls.Add(button4);
		C63C0433.Controls.Add(E6B4073E);
		C63C0433.Controls.Add(AD062125);
		C63C0433.Controls.Add(label8);
		C63C0433.Controls.Add(A2BBF0BC);
		C63C0433.Controls.Add(label11);
		C63C0433.Controls.Add(lblStatus);
		C63C0433.Location = new System.Drawing.Point(371, 126);
		C63C0433.Name = "plComment";
		C63C0433.Size = new System.Drawing.Size(281, 195);
		C63C0433.TabIndex = 164;
		panel3.Controls.Add(rbCommentTheoThuTu);
		panel3.Controls.Add(A9224F9C);
		panel3.Location = new System.Drawing.Point(67, 191);
		panel3.Name = "panel3";
		panel3.Size = new System.Drawing.Size(200, 43);
		panel3.TabIndex = 43;
		rbCommentTheoThuTu.AutoSize = true;
		rbCommentTheoThuTu.Checked = true;
		rbCommentTheoThuTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbCommentTheoThuTu.Location = new System.Drawing.Point(3, 2);
		rbCommentTheoThuTu.Name = "rbCommentTheoThuTu";
		rbCommentTheoThuTu.Size = new System.Drawing.Size(201, 20);
		rbCommentTheoThuTu.TabIndex = 3;
		rbCommentTheoThuTu.TabStop = true;
		rbCommentTheoThuTu.Text = "Comment theo thứ tự nội dung";
		rbCommentTheoThuTu.UseVisualStyleBackColor = true;
		rbCommentTheoThuTu.CheckedChanged += new System.EventHandler(rbCommentTheoThuTu_CheckedChanged);
		A9224F9C.AutoSize = true;
		A9224F9C.Cursor = System.Windows.Forms.Cursors.Hand;
		A9224F9C.Location = new System.Drawing.Point(3, 23);
		A9224F9C.Name = "rbCommentNgauNhien";
		A9224F9C.Size = new System.Drawing.Size(200, 20);
		A9224F9C.TabIndex = 3;
		A9224F9C.Text = "Comment ngẫu nhiên nội dung";
		A9224F9C.UseVisualStyleBackColor = true;
		A9224F9C.CheckedChanged += new System.EventHandler(A9224F9C_CheckedChanged);
		btnDown.BackgroundImage = Resource.Bitmap_91;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Location = new System.Drawing.Point(224, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 40;
		btnDown.Click += new System.EventHandler(E41BDC86);
		button4.Cursor = System.Windows.Forms.Cursors.Help;
		button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button4.Location = new System.Drawing.Point(136, 126);
		button4.Name = "button4";
		button4.Size = new System.Drawing.Size(21, 21);
		button4.TabIndex = 173;
		button4.Text = "?";
		button4.UseVisualStyleBackColor = true;
		button4.Click += new System.EventHandler(button4_Click);
		E6B4073E.BackgroundImage = Resource.Bitmap_73;
		E6B4073E.Cursor = System.Windows.Forms.Cursors.Hand;
		E6B4073E.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		E6B4073E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E6B4073E.Location = new System.Drawing.Point(255, -1);
		E6B4073E.Name = "btnUp";
		E6B4073E.Size = new System.Drawing.Size(25, 25);
		E6B4073E.TabIndex = 41;
		E6B4073E.Click += new System.EventHandler(DD16E5B0);
		AD062125.AutoSize = true;
		AD062125.Location = new System.Drawing.Point(4, 193);
		AD062125.Name = "label13";
		AD062125.Size = new System.Drawing.Size(64, 16);
		AD062125.TabIndex = 2;
		AD062125.Text = "Tùy chọn:";
		AD062125.Click += new System.EventHandler(AD062125_Click);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 150);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(64, 16);
		label8.TabIndex = 2;
		label8.Text = "Tùy chọn:";
		A2BBF0BC.Location = new System.Drawing.Point(7, 25);
		A2BBF0BC.Name = "txtComment";
		A2BBF0BC.Size = new System.Drawing.Size(263, 102);
		A2BBF0BC.TabIndex = 1;
		A2BBF0BC.Text = "";
		A2BBF0BC.WordWrap = false;
		A2BBF0BC.TextChanged += new System.EventHandler(AA1E8A9F);
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(5, 128);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(133, 16);
		label11.TabIndex = 0;
		label11.Text = "Spin nội dung {a|b|c}";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(118, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận:";
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(txtAnh);
		plAnh.Controls.Add(CD10A59E);
		plAnh.Enabled = false;
		plAnh.Location = new System.Drawing.Point(371, 348);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(281, 31);
		plAnh.TabIndex = 166;
		txtAnh.Location = new System.Drawing.Point(136, 3);
		txtAnh.Name = "txtAnh";
		txtAnh.Size = new System.Drawing.Size(140, 23);
		txtAnh.TabIndex = 155;
		CD10A59E.AutoSize = true;
		CD10A59E.Location = new System.Drawing.Point(3, 6);
		CD10A59E.Name = "label12";
		CD10A59E.Size = new System.Drawing.Size(137, 16);
		CD10A59E.TabIndex = 39;
		CD10A59E.Text = "Đường dẫn folder ảnh:";
		CD10A59E.Click += new System.EventHandler(CD10A59E_Click);
		txtIdPost.Location = new System.Drawing.Point(30, 152);
		txtIdPost.Name = "txtIdPost";
		txtIdPost.Size = new System.Drawing.Size(297, 207);
		txtIdPost.TabIndex = 1;
		txtIdPost.Text = "";
		txtIdPost.WordWrap = false;
		txtIdPost.TextChanged += new System.EventHandler(F09D392F);
		D6BA35B9.AutoSize = true;
		D6BA35B9.Cursor = System.Windows.Forms.Cursors.Hand;
		D6BA35B9.Location = new System.Drawing.Point(353, 324);
		D6BA35B9.Name = "ckbSendAnh";
		D6BA35B9.Size = new System.Drawing.Size(103, 20);
		D6BA35B9.TabIndex = 165;
		D6BA35B9.Text = "Bình luận ảnh";
		D6BA35B9.UseVisualStyleBackColor = true;
		D6BA35B9.CheckedChanged += new System.EventHandler(D6BA35B9_CheckedChanged);
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(353, 103);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(127, 20);
		ckbComment.TabIndex = 163;
		ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(EA9A3400);
		C7B50B11.AutoSize = true;
		C7B50B11.Location = new System.Drawing.Point(27, 362);
		C7B50B11.Name = "label10";
		C7B50B11.Size = new System.Drawing.Size(96, 16);
		C7B50B11.TabIndex = 39;
		C7B50B11.Text = "(Mỗi ID 1 dòng)";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 132);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(153, 16);
		label2.TabIndex = 40;
		label2.Text = "Danh sa\u0301ch ID bài viết (0):";
		C82883AB.AutoSize = true;
		C82883AB.Cursor = System.Windows.Forms.Cursors.Hand;
		C82883AB.Location = new System.Drawing.Point(508, 79);
		C82883AB.Name = "ckbShareWall";
		C82883AB.Size = new System.Drawing.Size(143, 20);
		C82883AB.TabIndex = 6;
		C82883AB.Text = "Chia sẻ bài về tường";
		C82883AB.UseVisualStyleBackColor = true;
		D2936D88.AutoSize = true;
		D2936D88.Cursor = System.Windows.Forms.Cursors.Hand;
		D2936D88.Location = new System.Drawing.Point(353, 79);
		D2936D88.Name = "ckbInteract";
		D2936D88.Size = new System.Drawing.Size(93, 20);
		D2936D88.TabIndex = 5;
		D2936D88.Text = "Like ba\u0300i viê\u0301t";
		D2936D88.UseVisualStyleBackColor = true;
		DB36E026.Location = new System.Drawing.Point(568, 50);
		DB36E026.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		DB36E026.Name = "nudTimeTo";
		DB36E026.Size = new System.Drawing.Size(51, 23);
		DB36E026.TabIndex = 4;
		A9A36590.Location = new System.Drawing.Point(231, 78);
		A9A36590.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A9A36590.Name = "nudDelayTo";
		A9A36590.Size = new System.Drawing.Size(56, 23);
		A9A36590.TabIndex = 4;
		nudTimeFrom.Location = new System.Drawing.Point(490, 50);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(51, 23);
		nudTimeFrom.TabIndex = 3;
		nudDelayFrom.Location = new System.Drawing.Point(134, 78);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label9.Location = new System.Drawing.Point(541, 52);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 38;
		label9.Text = "đê\u0301n";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label7.Location = new System.Drawing.Point(196, 80);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(621, 52);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(30, 16);
		label4.TabIndex = 36;
		label4.Text = "giây";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(289, 80);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(350, 52);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(138, 16);
		label3.TabIndex = 34;
		label3.Text = "Thơ\u0300i gian xem bài viết:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 80);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(89, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chờ:";
		D3A65F0D.AutoSize = true;
		D3A65F0D.Location = new System.Drawing.Point(27, 52);
		D3A65F0D.Name = "label1";
		D3A65F0D.Size = new System.Drawing.Size(98, 16);
		D3A65F0D.TabIndex = 31;
		D3A65F0D.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(349, 395);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(242, 395);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(BBA05223);
		AA2EDE8D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		AA2EDE8D.BackColor = System.Drawing.Color.White;
		AA2EDE8D.BorderRadius = 0;
		AA2EDE8D.BottomSahddow = true;
		AA2EDE8D.color = System.Drawing.Color.DarkViolet;
		AA2EDE8D.Controls.Add(A223AEAF);
		AA2EDE8D.LeftSahddow = false;
		AA2EDE8D.Location = new System.Drawing.Point(1, 0);
		AA2EDE8D.Name = "bunifuCards1";
		AA2EDE8D.RightSahddow = true;
		AA2EDE8D.ShadowDepth = 20;
		AA2EDE8D.Size = new System.Drawing.Size(684, 37);
		AA2EDE8D.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(687, 437);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffLikeComment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBuffLikeComment_Load);
		A223AEAF.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)FA28652B).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)E296AC22).EndInit();
		C63C0433.ResumeLayout(false);
		C63C0433.PerformLayout();
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)DB36E026).EndInit();
		((System.ComponentModel.ISupportInitialize)A9A36590).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		AA2EDE8D.ResumeLayout(false);
		ResumeLayout(false);
	}
}
