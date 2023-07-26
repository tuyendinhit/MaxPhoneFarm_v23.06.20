using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDSpamBanBe : Form
{
	internal JSON_Settings F5033238;

	internal string A3367E10;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal List<CheckBox> list_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl B2071D8D;

	internal BunifuDragControl D2A145B5;

	internal Panel panel1;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudSoLuongBaiVietTo;

	internal NumericUpDown nudDelayFrom;

	internal NumericUpDown nudSoLuongBaiVietFrom;

	internal TextBox txtTenHanhDong;

	internal Label label7;

	internal Label label3;

	internal Label label6;

	internal Label label4;

	internal Label C811CB94;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel D70E650B;

	internal Button BE9D7385;

	internal PictureBox AF249293;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label label8;

	internal Label AEAF5528;

	internal CheckBox ckbComment;

	internal Label label49;

	internal NumericUpDown AD136817;

	internal Label CC85E892;

	internal Label label19;

	internal NumericUpDown FC1BD621;

	internal Label B1295E99;

	internal RichTextBox txtComment;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton rbNganCachMoiDong;

	internal Label C89FFA0C;

	internal Button button3;

	internal Button button2;

	internal LinkLabel EAB274A2;

	internal CheckBox C006B695;

	internal Panel A68B722B;

	internal TextBox txtPathAnh;

	internal Label label14;

	internal CheckBox ckbAnh;

	internal Panel A785FD00;

	internal CheckBox ckbGian;

	internal CheckBox AD2E6403;

	internal CheckBox ckbWow;

	internal CheckBox ckbHaha;

	internal CheckBox EE03C339;

	internal CheckBox ckbTym;

	internal CheckBox ckbLike;

	internal Panel panel7;

	internal RadioButton radioButton3;

	internal RadioButton radioButton4;

	internal Label label26;

	public fHDSpamBanBe(string string_2, int CD37EB2A = 0, string string_3 = "")
	{
		InitializeComponent();
		Language.SetLanguage(this);
		bool_0 = false;
		A3367E10 = string_2;
		string_1 = string_3;
		int_0 = CD37EB2A;
		if (Class123.C7BE863B("", "HDSpamBanBe").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDSpamBanBe', 'Spam bạn bè');");
		}
		string d399C = "";
		switch (CD37EB2A)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDSpamBanBe");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
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
		F5033238 = new JSON_Settings(d399C, D7BE7F11: true);
	}

	private void B92E0036(object sender, EventArgs e)
	{
		try
		{
			AD136817.Value = F5033238.method_0("nudSoLuongUidFrom", 1);
			FC1BD621.Value = F5033238.method_0("nudSoLuongUidTo", 1);
			nudSoLuongBaiVietFrom.Value = F5033238.method_0("nudSoLuongBaiVietFrom", 1);
			nudSoLuongBaiVietTo.Value = F5033238.method_0("nudSoLuongBaiVietTo", 1);
			nudDelayFrom.Value = F5033238.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = F5033238.method_0("nudDelayTo", 5);
			C006B695.Checked = F5033238.AA824D29("ckbInteract");
			string text = F5033238.GetValue("typeReaction");
			list_0 = new List<CheckBox> { ckbLike, ckbTym, EE03C339, ckbHaha, ckbWow, AD2E6403, ckbGian };
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].Checked = text.Contains(i.ToString());
			}
			ckbComment.Checked = F5033238.AA824D29("ckbComment");
			txtComment.Text = F5033238.GetValue("txtComment");
			if (F5033238.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			ckbAnh.Checked = F5033238.AA824D29("ckbAnh");
			txtPathAnh.Text = F5033238.GetValue("txtPathAnh");
		}
		catch
		{
		}
		BD14CF21();
	}

	private void D0ADA618(object sender, EventArgs e)
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
		f72FAFBC.GetValue("nudSoLuongUidFrom", AD136817.Value);
		f72FAFBC.GetValue("nudSoLuongUidTo", FC1BD621.Value);
		f72FAFBC.GetValue("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		f72FAFBC.GetValue("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("ckbInteract", C006B695.Checked);
		string text2 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			text2 += (list_0[i].Checked ? (i.ToString() ?? "") : "");
		}
		f72FAFBC.GetValue("typeReaction", (object)text2);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		f72FAFBC.GetValue("ckbAnh", ckbAnh.Checked);
		f72FAFBC.GetValue("txtPathAnh", (object)txtPathAnh.Text.Trim());
		string text3 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(A3367E10, text, string_0, text3))
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
			if (Class123.smethod_14(string_1, text, text3))
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

	private void F6014395(object sender, PaintEventArgs e)
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

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			AEAF5528.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void BD14CF21()
	{
		C006B695_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
		ckbAnh_CheckedChanged(null, null);
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void txtComment_MouseLeave(object sender, EventArgs e)
	{
	}

	private void txtComment_MouseEnter(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void E19803BD(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Chú ý: Nếu là ID Fanpage thì cần thêm /posts vào sau ID.") + "\r\n" + Language.GetValue("Ví dụ") + ": 15465478242/posts");
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void D700DFA5(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void C006B695_CheckedChanged(object sender, EventArgs e)
	{
		A785FD00.Enabled = C006B695.Checked;
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void ckbAnh_CheckedChanged(object sender, EventArgs e)
	{
		A68B722B.Enabled = ckbAnh.Checked;
	}

	protected override void Dispose(bool B8197833)
	{
		if (B8197833 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B8197833);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDSpamBanBe));
		B2071D8D = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D2A145B5 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D70E650B = new System.Windows.Forms.Panel();
		BE9D7385 = new System.Windows.Forms.Button();
		AF249293 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		A68B722B = new System.Windows.Forms.Panel();
		txtPathAnh = new System.Windows.Forms.TextBox();
		label14 = new System.Windows.Forms.Label();
		ckbAnh = new System.Windows.Forms.CheckBox();
		C006B695 = new System.Windows.Forms.CheckBox();
		plComment = new System.Windows.Forms.Panel();
		EAB274A2 = new System.Windows.Forms.LinkLabel();
		button3 = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		C89FFA0C = new System.Windows.Forms.Label();
		txtComment = new System.Windows.Forms.RichTextBox();
		label8 = new System.Windows.Forms.Label();
		AEAF5528 = new System.Windows.Forms.Label();
		label49 = new System.Windows.Forms.Label();
		AD136817 = new System.Windows.Forms.NumericUpDown();
		CC85E892 = new System.Windows.Forms.Label();
		label19 = new System.Windows.Forms.Label();
		FC1BD621 = new System.Windows.Forms.NumericUpDown();
		B1295E99 = new System.Windows.Forms.Label();
		ckbComment = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		C811CB94 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		A785FD00 = new System.Windows.Forms.Panel();
		ckbGian = new System.Windows.Forms.CheckBox();
		AD2E6403 = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		EE03C339 = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		ckbLike = new System.Windows.Forms.CheckBox();
		panel7 = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		radioButton4 = new System.Windows.Forms.RadioButton();
		label26 = new System.Windows.Forms.Label();
		D70E650B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)AF249293).BeginInit();
		panel1.SuspendLayout();
		A68B722B.SuspendLayout();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)AD136817).BeginInit();
		((System.ComponentModel.ISupportInitialize)FC1BD621).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		A785FD00.SuspendLayout();
		panel7.SuspendLayout();
		SuspendLayout();
		B2071D8D.Fixed = true;
		B2071D8D.Horizontal = true;
		B2071D8D.TargetControl = bunifuCustomLabel1;
		B2071D8D.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(389, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Spam bạn bè";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D2A145B5.Fixed = true;
		D2A145B5.Horizontal = true;
		D2A145B5.TargetControl = D70E650B;
		D2A145B5.Vertical = true;
		D70E650B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D70E650B.BackColor = System.Drawing.Color.White;
		D70E650B.Controls.Add(BE9D7385);
		D70E650B.Controls.Add(AF249293);
		D70E650B.Controls.Add(bunifuCustomLabel1);
		D70E650B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D70E650B.Location = new System.Drawing.Point(0, 3);
		D70E650B.Name = "pnlHeader";
		D70E650B.Size = new System.Drawing.Size(389, 31);
		D70E650B.TabIndex = 9;
		BE9D7385.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		BE9D7385.Cursor = System.Windows.Forms.Cursors.Hand;
		BE9D7385.FlatAppearance.BorderSize = 0;
		BE9D7385.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BE9D7385.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BE9D7385.ForeColor = System.Drawing.Color.White;
		BE9D7385.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		BE9D7385.Location = new System.Drawing.Point(358, 1);
		BE9D7385.Name = "button1";
		BE9D7385.Size = new System.Drawing.Size(30, 30);
		BE9D7385.TabIndex = 77;
		BE9D7385.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		BE9D7385.UseVisualStyleBackColor = true;
		BE9D7385.Click += new System.EventHandler(D0ADA618);
		AF249293.Cursor = System.Windows.Forms.Cursors.Default;
		AF249293.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		AF249293.Location = new System.Drawing.Point(3, 2);
		AF249293.Name = "pictureBox1";
		AF249293.Size = new System.Drawing.Size(34, 27);
		AF249293.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		AF249293.TabIndex = 76;
		AF249293.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(A785FD00);
		panel1.Controls.Add(A68B722B);
		panel1.Controls.Add(ckbAnh);
		panel1.Controls.Add(C006B695);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(AD136817);
		panel1.Controls.Add(CC85E892);
		panel1.Controls.Add(label19);
		panel1.Controls.Add(FC1BD621);
		panel1.Controls.Add(B1295E99);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudSoLuongBaiVietTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(nudSoLuongBaiVietFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(C811CB94);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(392, 566);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(F6014395);
		A68B722B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A68B722B.Controls.Add(txtPathAnh);
		A68B722B.Controls.Add(label14);
		A68B722B.Location = new System.Drawing.Point(47, 478);
		A68B722B.Name = "plAnh";
		A68B722B.Size = new System.Drawing.Size(313, 31);
		A68B722B.TabIndex = 176;
		txtPathAnh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtPathAnh.Location = new System.Drawing.Point(90, 3);
		txtPathAnh.Name = "txtPathAnh";
		txtPathAnh.Size = new System.Drawing.Size(218, 23);
		txtPathAnh.TabIndex = 1;
		label14.AutoSize = true;
		label14.Location = new System.Drawing.Point(3, 6);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(88, 16);
		label14.TabIndex = 0;
		label14.Text = "Thư mu\u0323c ảnh:";
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAnh.Location = new System.Drawing.Point(30, 454);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new System.Drawing.Size(103, 20);
		ckbAnh.TabIndex = 175;
		ckbAnh.Text = "Bình luận ảnh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += new System.EventHandler(ckbAnh_CheckedChanged);
		C006B695.AutoSize = true;
		C006B695.Cursor = System.Windows.Forms.Cursors.Hand;
		C006B695.Location = new System.Drawing.Point(30, 166);
		C006B695.Name = "ckbInteract";
		C006B695.Size = new System.Drawing.Size(112, 20);
		C006B695.TabIndex = 169;
		C006B695.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		C006B695.UseVisualStyleBackColor = true;
		C006B695.CheckedChanged += new System.EventHandler(C006B695_CheckedChanged);
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(EAB274A2);
		plComment.Controls.Add(button3);
		plComment.Controls.Add(button2);
		plComment.Controls.Add(rbNganCachKyTu);
		plComment.Controls.Add(rbNganCachMoiDong);
		plComment.Controls.Add(C89FFA0C);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(AEAF5528);
		plComment.Location = new System.Drawing.Point(48, 257);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(312, 193);
		plComment.TabIndex = 10;
		EAB274A2.AutoSize = true;
		EAB274A2.Cursor = System.Windows.Forms.Cursors.Hand;
		EAB274A2.Location = new System.Drawing.Point(191, 126);
		EAB274A2.Name = "linkLabel1";
		EAB274A2.Size = new System.Drawing.Size(81, 16);
		EAB274A2.TabIndex = 192;
		EAB274A2.TabStop = true;
		EAB274A2.Text = "Random icon";
		EAB274A2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(D700DFA5);
		button3.Cursor = System.Windows.Forms.Cursors.Help;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(229, 168);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(21, 23);
		button3.TabIndex = 4;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(229, 145);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 23);
		button2.TabIndex = 4;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		rbNganCachKyTu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(70, 168);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		rbNganCachKyTu.TabIndex = 3;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		rbNganCachMoiDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(70, 147);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(155, 20);
		rbNganCachMoiDong.TabIndex = 3;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Nội dung chỉ có 1 dòng";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		C89FFA0C.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		C89FFA0C.AutoSize = true;
		C89FFA0C.Location = new System.Drawing.Point(5, 147);
		C89FFA0C.Name = "label9";
		C89FFA0C.Size = new System.Drawing.Size(64, 16);
		C89FFA0C.TabIndex = 2;
		C89FFA0C.Text = "Tùy chọn:";
		txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtComment.Location = new System.Drawing.Point(7, 25);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(294, 99);
		txtComment.TabIndex = 1;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		txtComment.MouseEnter += new System.EventHandler(txtComment_MouseEnter);
		txtComment.MouseLeave += new System.EventHandler(txtComment_MouseLeave);
		label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 127);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(143, 16);
		label8.TabIndex = 0;
		label8.Text = "(Spin nội dung {a|b|c})";
		AEAF5528.AutoSize = true;
		AEAF5528.Location = new System.Drawing.Point(3, 5);
		AEAF5528.Name = "lblStatus";
		AEAF5528.Size = new System.Drawing.Size(139, 16);
		AEAF5528.TabIndex = 0;
		AEAF5528.Text = "Nội dung bình luận (0):";
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(27, 81);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(88, 16);
		label49.TabIndex = 92;
		label49.Text = "Sô\u0301 lươ\u0323ng bạn:";
		AD136817.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		AD136817.Location = new System.Drawing.Point(137, 79);
		AD136817.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		AD136817.Name = "nudSoLuongUidFrom";
		AD136817.Size = new System.Drawing.Size(56, 23);
		AD136817.TabIndex = 1;
		AD136817.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		CC85E892.AutoSize = true;
		CC85E892.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		CC85E892.Location = new System.Drawing.Point(292, 81);
		CC85E892.Name = "label68";
		CC85E892.Size = new System.Drawing.Size(28, 16);
		CC85E892.TabIndex = 99;
		CC85E892.Text = "bạn";
		label19.AutoSize = true;
		label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label19.Location = new System.Drawing.Point(27, 110);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(98, 16);
		label19.TabIndex = 101;
		label19.Text = "Sô\u0301 ba\u0300i viết/bạn:";
		FC1BD621.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		FC1BD621.Location = new System.Drawing.Point(234, 79);
		FC1BD621.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		FC1BD621.Name = "nudSoLuongUidTo";
		FC1BD621.Size = new System.Drawing.Size(56, 23);
		FC1BD621.TabIndex = 2;
		FC1BD621.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		B1295E99.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B1295E99.Location = new System.Drawing.Point(199, 81);
		B1295E99.Name = "label66";
		B1295E99.Size = new System.Drawing.Size(29, 16);
		B1295E99.TabIndex = 105;
		B1295E99.Text = "đê\u0301n";
		B1295E99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(30, 233);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(127, 20);
		ckbComment.TabIndex = 9;
		ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		nudDelayTo.Location = new System.Drawing.Point(234, 137);
		nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 6;
		nudSoLuongBaiVietTo.Location = new System.Drawing.Point(234, 108);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(137, 137);
		nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(137, 108);
		nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(137, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(223, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Location = new System.Drawing.Point(199, 139);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Location = new System.Drawing.Point(199, 110);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(292, 139);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(292, 110);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(24, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0300i";
		C811CB94.AutoSize = true;
		C811CB94.Location = new System.Drawing.Point(27, 139);
		C811CB94.Name = "label5";
		C811CB94.Size = new System.Drawing.Size(99, 16);
		C811CB94.TabIndex = 34;
		C811CB94.Text = "Thơ\u0300i gian delay:";
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
		btnCancel.Location = new System.Drawing.Point(204, 524);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
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
		btnAdd.Location = new System.Drawing.Point(97, 524);
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
		bunifuCards1.Controls.Add(D70E650B);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(389, 37);
		bunifuCards1.TabIndex = 28;
		A785FD00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A785FD00.Controls.Add(ckbGian);
		A785FD00.Controls.Add(AD2E6403);
		A785FD00.Controls.Add(ckbWow);
		A785FD00.Controls.Add(ckbHaha);
		A785FD00.Controls.Add(EE03C339);
		A785FD00.Controls.Add(ckbTym);
		A785FD00.Controls.Add(ckbLike);
		A785FD00.Controls.Add(panel7);
		A785FD00.Controls.Add(label26);
		A785FD00.Location = new System.Drawing.Point(48, 192);
		A785FD00.Name = "plInteract";
		A785FD00.Size = new System.Drawing.Size(312, 33);
		A785FD00.TabIndex = 181;
		ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGian.Image = Resource.Bitmap_5;
		ckbGian.Location = new System.Drawing.Point(266, 1);
		ckbGian.Name = "ckbGian";
		ckbGian.Size = new System.Drawing.Size(40, 30);
		ckbGian.TabIndex = 179;
		ckbGian.UseVisualStyleBackColor = true;
		AD2E6403.Cursor = System.Windows.Forms.Cursors.Hand;
		AD2E6403.Image = Resource.Bitmap_174;
		AD2E6403.Location = new System.Drawing.Point(222, 1);
		AD2E6403.Name = "ckbBuon";
		AD2E6403.Size = new System.Drawing.Size(40, 30);
		AD2E6403.TabIndex = 178;
		AD2E6403.UseVisualStyleBackColor = true;
		ckbWow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbWow.Image = Resource.F391A116;
		ckbWow.Location = new System.Drawing.Point(178, 1);
		ckbWow.Name = "ckbWow";
		ckbWow.Size = new System.Drawing.Size(40, 30);
		ckbWow.TabIndex = 177;
		ckbWow.UseVisualStyleBackColor = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Image = Resource.Bitmap_38;
		ckbHaha.Location = new System.Drawing.Point(134, 1);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(40, 30);
		ckbHaha.TabIndex = 176;
		ckbHaha.UseVisualStyleBackColor = true;
		EE03C339.Cursor = System.Windows.Forms.Cursors.Hand;
		EE03C339.Image = Resource.DD3ED6B8;
		EE03C339.Location = new System.Drawing.Point(90, 1);
		EE03C339.Name = "ckbThuong";
		EE03C339.Size = new System.Drawing.Size(40, 30);
		EE03C339.TabIndex = 175;
		EE03C339.UseVisualStyleBackColor = true;
		ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTym.Image = Resource.C8AF3BB6;
		ckbTym.Location = new System.Drawing.Point(46, 1);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new System.Drawing.Size(40, 30);
		ckbTym.TabIndex = 174;
		ckbTym.UseVisualStyleBackColor = true;
		ckbLike.Checked = true;
		ckbLike.CheckState = System.Windows.Forms.CheckState.Checked;
		ckbLike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLike.Image = Resource.Bitmap_163;
		ckbLike.Location = new System.Drawing.Point(2, 1);
		ckbLike.Name = "ckbLike";
		ckbLike.Size = new System.Drawing.Size(40, 30);
		ckbLike.TabIndex = 173;
		ckbLike.UseVisualStyleBackColor = true;
		panel7.Controls.Add(radioButton3);
		panel7.Controls.Add(radioButton4);
		panel7.Location = new System.Drawing.Point(67, 300);
		panel7.Name = "panel7";
		panel7.Size = new System.Drawing.Size(200, 43);
		panel7.TabIndex = 43;
		radioButton3.AutoSize = true;
		radioButton3.Checked = true;
		radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton3.Location = new System.Drawing.Point(3, 2);
		radioButton3.Name = "radioButton3";
		radioButton3.Size = new System.Drawing.Size(201, 20);
		radioButton3.TabIndex = 3;
		radioButton3.TabStop = true;
		radioButton3.Text = "Comment theo thứ tự nội dung";
		radioButton3.UseVisualStyleBackColor = true;
		radioButton4.AutoSize = true;
		radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		radioButton4.Location = new System.Drawing.Point(3, 23);
		radioButton4.Name = "radioButton4";
		radioButton4.Size = new System.Drawing.Size(200, 20);
		radioButton4.TabIndex = 3;
		radioButton4.Text = "Comment ngẫu nhiên nội dung";
		radioButton4.UseVisualStyleBackColor = true;
		label26.AutoSize = true;
		label26.Location = new System.Drawing.Point(4, 302);
		label26.Name = "label26";
		label26.Size = new System.Drawing.Size(64, 16);
		label26.TabIndex = 2;
		label26.Text = "Tùy chọn:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(392, 566);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDSpamBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B92E0036);
		D70E650B.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)AF249293).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		A68B722B.ResumeLayout(false);
		A68B722B.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)AD136817).EndInit();
		((System.ComponentModel.ISupportInitialize)FC1BD621).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		A785FD00.ResumeLayout(false);
		A785FD00.PerformLayout();
		panel7.ResumeLayout(false);
		panel7.PerformLayout();
		ResumeLayout(false);
	}
}
