using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDSpamBaiViet : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string D61A949D;

	internal string string_0;

	internal string string_1;

	internal int C13FB2B2;

	internal static bool bool_0;

	internal List<CheckBox> list_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl D8A3EF2D;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal NumericUpDown AA3850BA;

	internal NumericUpDown nudSoLuongBaiVietTo;

	internal NumericUpDown F43E0218;

	internal NumericUpDown nudSoLuongBaiVietFrom;

	internal TextBox txtTenHanhDong;

	internal Label label7;

	internal Label label3;

	internal Label label6;

	internal Label label4;

	internal Label D41601AE;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button C60B89A3;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label label8;

	internal Label lblStatus;

	internal CheckBox ckbComment;

	internal Label DF25C912;

	internal NumericUpDown nudSoLuongUidFrom;

	internal Label BD019999;

	internal Label label19;

	internal NumericUpDown nudSoLuongUidTo;

	internal Label label66;

	internal RichTextBox txtUid;

	internal RichTextBox txtComment;

	internal CheckBox ckbTuDongXoaUid;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton rbNganCachMoiDong;

	internal Label F003A283;

	internal Label label10;

	internal Button button3;

	internal Button button2;

	internal LinkLabel linkLabel1;

	internal CheckBox ckbInteract;

	internal Label label2;

	internal RadioButton rbPage;

	internal RadioButton rbGroup;

	internal RadioButton rbUser;

	internal Panel plAnh;

	internal TextBox txtPathAnh;

	internal Label B724CE36;

	internal CheckBox ckbAnh;

	internal Panel plInteract;

	internal CheckBox E62E093E;

	internal CheckBox C132780F;

	internal CheckBox AE307FA2;

	internal CheckBox ckbHaha;

	internal CheckBox F517752A;

	internal CheckBox DDA49188;

	internal CheckBox D4802E86;

	internal Panel F4816E08;

	internal RadioButton radioButton3;

	internal RadioButton radioButton4;

	internal Label B73CDA95;

	internal CheckBox D1015611;

	internal CheckBox ckbReel;

	public fHDSpamBaiViet(string DBB2B687, int int_0 = 0, string string_2 = "")
	{
		InitializeComponent();
		Language.SetLanguage(this);
		bool_0 = false;
		D61A949D = DBB2B687;
		string_1 = string_2;
		C13FB2B2 = int_0;
		if (Class123.C7BE863B("", "HDSpamBaiViet").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDSpamBaiViet', 'Spam ba\u0300i viê\u0301t');");
		}
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDSpamBaiViet");
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
	}

	private void fHDSpamBaiViet_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongUidFrom.Value = f72FAFBC_0.method_0("nudSoLuongUidFrom", 1);
			nudSoLuongUidTo.Value = f72FAFBC_0.method_0("nudSoLuongUidTo", 1);
			nudSoLuongBaiVietFrom.Value = f72FAFBC_0.method_0("nudSoLuongBaiVietFrom", 1);
			nudSoLuongBaiVietTo.Value = f72FAFBC_0.method_0("nudSoLuongBaiVietTo", 1);
			F43E0218.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			AA3850BA.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
			switch (f72FAFBC_0.method_0("typeID"))
			{
			case 0:
				rbUser.Checked = true;
				break;
			case 1:
				rbGroup.Checked = true;
				break;
			case 2:
				rbPage.Checked = true;
				break;
			}
			txtUid.Text = f72FAFBC_0.GetValue("txtUid");
			ckbInteract.Checked = f72FAFBC_0.AA824D29("ckbInteract");
			string text = f72FAFBC_0.GetValue("typeReaction");
			list_0 = new List<CheckBox> { D4802E86, DDA49188, F517752A, ckbHaha, AE307FA2, C132780F, E62E093E };
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].Checked = text.Contains(i.ToString());
			}
			D1015611.Checked = f72FAFBC_0.AA824D29("ckbShareWall");
			ckbComment.Checked = f72FAFBC_0.AA824D29("ckbComment");
			txtComment.Text = f72FAFBC_0.GetValue("txtComment");
			ckbTuDongXoaUid.Checked = f72FAFBC_0.AA824D29("ckbTuDongXoaUid");
			if (f72FAFBC_0.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			ckbAnh.Checked = f72FAFBC_0.AA824D29("ckbAnh");
			txtPathAnh.Text = f72FAFBC_0.GetValue("txtPathAnh");
			ckbReel.Checked = f72FAFBC_0.AA824D29("ckbReel");
		}
		catch
		{
		}
		method_2();
	}

	private void C60B89A3_Click(object sender, EventArgs e)
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
		List<string> f1808BA = txtUid.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch ID!"), 3);
			return;
		}
		if (ckbComment.Checked)
		{
			List<string> f1808BA2 = txtComment.Lines.ToList();
			f1808BA2 = Common.RemoveEmptyItems(f1808BA2);
			if (f1808BA2.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongUidFrom", nudSoLuongUidFrom.Value);
		f72FAFBC.GetValue("nudSoLuongUidTo", nudSoLuongUidTo.Value);
		f72FAFBC.GetValue("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
		f72FAFBC.GetValue("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", F43E0218.Value);
		f72FAFBC.GetValue("nudDelayTo", AA3850BA.Value);
		int num = 0;
		if (rbGroup.Checked)
		{
			num = 1;
		}
		if (rbPage.Checked)
		{
			num = 2;
		}
		f72FAFBC.GetValue("typeID", num);
		f72FAFBC.GetValue("txtUid", (object)txtUid.Text.Trim());
		f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
		string text2 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			text2 += (list_0[i].Checked ? (i.ToString() ?? "") : "");
		}
		f72FAFBC.GetValue("typeReaction", (object)text2);
		f72FAFBC.GetValue("ckbShareWall", D1015611.Checked);
		f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		f72FAFBC.GetValue("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		int num2 = 0;
		if (rbNganCachKyTu.Checked)
		{
			num2 = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num2);
		f72FAFBC.GetValue("ckbAnh", ckbAnh.Checked);
		f72FAFBC.GetValue("txtPathAnh", (object)txtPathAnh.Text.Trim());
		f72FAFBC.GetValue("ckbReel", ckbReel.Checked);
		string text3 = f72FAFBC.C71A4EA4();
		if (C13FB2B2 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(D61A949D, text, string_0, text3))
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
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_2()
	{
		ckbInteract_CheckedChanged(null, null);
		ckbComment_CheckedChanged(null, null);
		ckbAnh_CheckedChanged(null, null);
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void C514D408(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUid.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			label10.Text = string.Format(Language.GetValue("Nhập danh sách ID User/Group/Page ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtComment_MouseLeave(object sender, EventArgs e)
	{
	}

	private void txtComment_MouseEnter(object sender, EventArgs e)
	{
	}

	private void D8ACD29D(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void A22D639A(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void method_3(object sender, EventArgs e)
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

	private void C9B93599(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void ckbInteract_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = ckbInteract.Checked;
	}

	private void CE9E76B3(object sender, EventArgs e)
	{
	}

	private void ckbAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnh.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDSpamBaiViet));
		D8A3EF2D = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		C60B89A3 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plInteract = new System.Windows.Forms.Panel();
		E62E093E = new System.Windows.Forms.CheckBox();
		C132780F = new System.Windows.Forms.CheckBox();
		AE307FA2 = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		F517752A = new System.Windows.Forms.CheckBox();
		DDA49188 = new System.Windows.Forms.CheckBox();
		D4802E86 = new System.Windows.Forms.CheckBox();
		F4816E08 = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		radioButton4 = new System.Windows.Forms.RadioButton();
		B73CDA95 = new System.Windows.Forms.Label();
		plAnh = new System.Windows.Forms.Panel();
		txtPathAnh = new System.Windows.Forms.TextBox();
		B724CE36 = new System.Windows.Forms.Label();
		ckbAnh = new System.Windows.Forms.CheckBox();
		label2 = new System.Windows.Forms.Label();
		rbPage = new System.Windows.Forms.RadioButton();
		rbGroup = new System.Windows.Forms.RadioButton();
		rbUser = new System.Windows.Forms.RadioButton();
		ckbInteract = new System.Windows.Forms.CheckBox();
		plComment = new System.Windows.Forms.Panel();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		button3 = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		F003A283 = new System.Windows.Forms.Label();
		txtComment = new System.Windows.Forms.RichTextBox();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		txtUid = new System.Windows.Forms.RichTextBox();
		label10 = new System.Windows.Forms.Label();
		DF25C912 = new System.Windows.Forms.Label();
		nudSoLuongUidFrom = new System.Windows.Forms.NumericUpDown();
		BD019999 = new System.Windows.Forms.Label();
		label19 = new System.Windows.Forms.Label();
		nudSoLuongUidTo = new System.Windows.Forms.NumericUpDown();
		label66 = new System.Windows.Forms.Label();
		D1015611 = new System.Windows.Forms.CheckBox();
		ckbComment = new System.Windows.Forms.CheckBox();
		ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		AA3850BA = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		F43E0218 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		D41601AE = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		ckbReel = new System.Windows.Forms.CheckBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plInteract.SuspendLayout();
		F4816E08.SuspendLayout();
		plAnh.SuspendLayout();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)AA3850BA).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)F43E0218).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D8A3EF2D.Fixed = true;
		D8A3EF2D.Horizontal = true;
		D8A3EF2D.TargetControl = bunifuCustomLabel1;
		D8A3EF2D.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(710, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Spam ba\u0300i viê\u0301t";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(C60B89A3);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(710, 31);
		pnlHeader.TabIndex = 9;
		C60B89A3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		C60B89A3.Cursor = System.Windows.Forms.Cursors.Hand;
		C60B89A3.FlatAppearance.BorderSize = 0;
		C60B89A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C60B89A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C60B89A3.ForeColor = System.Drawing.Color.White;
		C60B89A3.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		C60B89A3.Location = new System.Drawing.Point(679, 1);
		C60B89A3.Name = "button1";
		C60B89A3.Size = new System.Drawing.Size(30, 30);
		C60B89A3.TabIndex = 77;
		C60B89A3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C60B89A3.UseVisualStyleBackColor = true;
		C60B89A3.Click += new System.EventHandler(C60B89A3_Click);
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
		panel1.Controls.Add(ckbReel);
		panel1.Controls.Add(plInteract);
		panel1.Controls.Add(plAnh);
		panel1.Controls.Add(ckbAnh);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(rbPage);
		panel1.Controls.Add(rbGroup);
		panel1.Controls.Add(rbUser);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(label10);
		panel1.Controls.Add(DF25C912);
		panel1.Controls.Add(nudSoLuongUidFrom);
		panel1.Controls.Add(BD019999);
		panel1.Controls.Add(label19);
		panel1.Controls.Add(nudSoLuongUidTo);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(D1015611);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(ckbTuDongXoaUid);
		panel1.Controls.Add(AA3850BA);
		panel1.Controls.Add(nudSoLuongBaiVietTo);
		panel1.Controls.Add(F43E0218);
		panel1.Controls.Add(nudSoLuongBaiVietFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(D41601AE);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(713, 481);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plInteract.Controls.Add(E62E093E);
		plInteract.Controls.Add(C132780F);
		plInteract.Controls.Add(AE307FA2);
		plInteract.Controls.Add(ckbHaha);
		plInteract.Controls.Add(F517752A);
		plInteract.Controls.Add(DDA49188);
		plInteract.Controls.Add(D4802E86);
		plInteract.Controls.Add(F4816E08);
		plInteract.Controls.Add(B73CDA95);
		plInteract.Location = new System.Drawing.Point(367, 108);
		plInteract.Name = "plInteract";
		plInteract.Size = new System.Drawing.Size(312, 33);
		plInteract.TabIndex = 181;
		E62E093E.Cursor = System.Windows.Forms.Cursors.Hand;
		E62E093E.Image = Resource.Bitmap_5;
		E62E093E.Location = new System.Drawing.Point(266, 1);
		E62E093E.Name = "ckbGian";
		E62E093E.Size = new System.Drawing.Size(40, 30);
		E62E093E.TabIndex = 179;
		E62E093E.UseVisualStyleBackColor = true;
		C132780F.Cursor = System.Windows.Forms.Cursors.Hand;
		C132780F.Image = Resource.Bitmap_174;
		C132780F.Location = new System.Drawing.Point(222, 1);
		C132780F.Name = "ckbBuon";
		C132780F.Size = new System.Drawing.Size(40, 30);
		C132780F.TabIndex = 178;
		C132780F.UseVisualStyleBackColor = true;
		AE307FA2.Cursor = System.Windows.Forms.Cursors.Hand;
		AE307FA2.Image = Resource.F391A116;
		AE307FA2.Location = new System.Drawing.Point(178, 1);
		AE307FA2.Name = "ckbWow";
		AE307FA2.Size = new System.Drawing.Size(40, 30);
		AE307FA2.TabIndex = 177;
		AE307FA2.UseVisualStyleBackColor = true;
		ckbHaha.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHaha.Image = Resource.Bitmap_38;
		ckbHaha.Location = new System.Drawing.Point(134, 1);
		ckbHaha.Name = "ckbHaha";
		ckbHaha.Size = new System.Drawing.Size(40, 30);
		ckbHaha.TabIndex = 176;
		ckbHaha.UseVisualStyleBackColor = true;
		F517752A.Cursor = System.Windows.Forms.Cursors.Hand;
		F517752A.Image = Resource.DD3ED6B8;
		F517752A.Location = new System.Drawing.Point(90, 1);
		F517752A.Name = "ckbThuong";
		F517752A.Size = new System.Drawing.Size(40, 30);
		F517752A.TabIndex = 175;
		F517752A.UseVisualStyleBackColor = true;
		DDA49188.Cursor = System.Windows.Forms.Cursors.Hand;
		DDA49188.Image = Resource.C8AF3BB6;
		DDA49188.Location = new System.Drawing.Point(46, 1);
		DDA49188.Name = "ckbTym";
		DDA49188.Size = new System.Drawing.Size(40, 30);
		DDA49188.TabIndex = 174;
		DDA49188.UseVisualStyleBackColor = true;
		D4802E86.Checked = true;
		D4802E86.CheckState = System.Windows.Forms.CheckState.Checked;
		D4802E86.Cursor = System.Windows.Forms.Cursors.Hand;
		D4802E86.Image = Resource.Bitmap_163;
		D4802E86.Location = new System.Drawing.Point(2, 1);
		D4802E86.Name = "ckbLike";
		D4802E86.Size = new System.Drawing.Size(40, 30);
		D4802E86.TabIndex = 173;
		D4802E86.UseVisualStyleBackColor = true;
		F4816E08.Controls.Add(radioButton3);
		F4816E08.Controls.Add(radioButton4);
		F4816E08.Location = new System.Drawing.Point(67, 300);
		F4816E08.Name = "panel7";
		F4816E08.Size = new System.Drawing.Size(200, 43);
		F4816E08.TabIndex = 43;
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
		B73CDA95.AutoSize = true;
		B73CDA95.Location = new System.Drawing.Point(4, 302);
		B73CDA95.Name = "label26";
		B73CDA95.Size = new System.Drawing.Size(64, 16);
		B73CDA95.TabIndex = 2;
		B73CDA95.Text = "Tùy chọn:";
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(txtPathAnh);
		plAnh.Controls.Add(B724CE36);
		plAnh.Location = new System.Drawing.Point(366, 394);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(313, 31);
		plAnh.TabIndex = 176;
		txtPathAnh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtPathAnh.Location = new System.Drawing.Point(90, 3);
		txtPathAnh.Name = "txtPathAnh";
		txtPathAnh.Size = new System.Drawing.Size(218, 23);
		txtPathAnh.TabIndex = 1;
		B724CE36.AutoSize = true;
		B724CE36.Location = new System.Drawing.Point(3, 6);
		B724CE36.Name = "label14";
		B724CE36.Size = new System.Drawing.Size(88, 16);
		B724CE36.TabIndex = 0;
		B724CE36.Text = "Thư mu\u0323c ảnh:";
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAnh.Location = new System.Drawing.Point(349, 370);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new System.Drawing.Size(103, 20);
		ckbAnh.TabIndex = 175;
		ckbAnh.Text = "Bình luận ảnh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += new System.EventHandler(ckbAnh_CheckedChanged);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(28, 166);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(93, 16);
		label2.TabIndex = 174;
		label2.Text = "Loại đối tượng:";
		rbPage.AutoSize = true;
		rbPage.Cursor = System.Windows.Forms.Cursors.Hand;
		rbPage.Location = new System.Drawing.Point(271, 164);
		rbPage.Name = "rbPage";
		rbPage.Size = new System.Drawing.Size(53, 20);
		rbPage.TabIndex = 173;
		rbPage.Text = "Page";
		rbPage.UseVisualStyleBackColor = true;
		rbGroup.AutoSize = true;
		rbGroup.Cursor = System.Windows.Forms.Cursors.Hand;
		rbGroup.Location = new System.Drawing.Point(204, 164);
		rbGroup.Name = "rbGroup";
		rbGroup.Size = new System.Drawing.Size(59, 20);
		rbGroup.TabIndex = 172;
		rbGroup.Text = "Group";
		rbGroup.UseVisualStyleBackColor = true;
		rbUser.AutoSize = true;
		rbUser.Checked = true;
		rbUser.Cursor = System.Windows.Forms.Cursors.Hand;
		rbUser.Location = new System.Drawing.Point(135, 164);
		rbUser.Name = "rbUser";
		rbUser.Size = new System.Drawing.Size(61, 20);
		rbUser.TabIndex = 171;
		rbUser.TabStop = true;
		rbUser.Text = "Profile";
		rbUser.UseVisualStyleBackColor = true;
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(349, 82);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(112, 20);
		ckbInteract.TabIndex = 169;
		ckbInteract.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		ckbInteract.UseVisualStyleBackColor = true;
		ckbInteract.CheckedChanged += new System.EventHandler(ckbInteract_CheckedChanged);
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(linkLabel1);
		plComment.Controls.Add(button3);
		plComment.Controls.Add(button2);
		plComment.Controls.Add(rbNganCachKyTu);
		plComment.Controls.Add(rbNganCachMoiDong);
		plComment.Controls.Add(F003A283);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(lblStatus);
		plComment.Location = new System.Drawing.Point(367, 173);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(312, 193);
		plComment.TabIndex = 10;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.Location = new System.Drawing.Point(219, 127);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(81, 16);
		linkLabel1.TabIndex = 192;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(C9B93599);
		button3.Cursor = System.Windows.Forms.Cursors.Help;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(229, 168);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(21, 23);
		button3.TabIndex = 4;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(A22D639A);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(229, 145);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 23);
		button2.TabIndex = 4;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(D8ACD29D);
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
		F003A283.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		F003A283.AutoSize = true;
		F003A283.Location = new System.Drawing.Point(5, 147);
		F003A283.Name = "label9";
		F003A283.Size = new System.Drawing.Size(64, 16);
		F003A283.TabIndex = 2;
		F003A283.Text = "Tùy chọn:";
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
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(31, 210);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(299, 189);
		txtUid.TabIndex = 117;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(C514D408);
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(27, 190);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(242, 16);
		label10.TabIndex = 116;
		label10.Text = "Nhập danh sách ID User/Group/Page (0):";
		DF25C912.AutoSize = true;
		DF25C912.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		DF25C912.Location = new System.Drawing.Point(27, 81);
		DF25C912.Name = "label49";
		DF25C912.Size = new System.Drawing.Size(106, 16);
		DF25C912.TabIndex = 92;
		DF25C912.Text = "Sô\u0301 lươ\u0323ng ID/nick:";
		nudSoLuongUidFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongUidFrom.Location = new System.Drawing.Point(137, 79);
		nudSoLuongUidFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidFrom.Name = "nudSoLuongUidFrom";
		nudSoLuongUidFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongUidFrom.TabIndex = 1;
		nudSoLuongUidFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		BD019999.AutoSize = true;
		BD019999.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		BD019999.Location = new System.Drawing.Point(292, 81);
		BD019999.Name = "label68";
		BD019999.Size = new System.Drawing.Size(19, 16);
		BD019999.TabIndex = 99;
		BD019999.Text = "ID";
		label19.AutoSize = true;
		label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label19.Location = new System.Drawing.Point(27, 110);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(89, 16);
		label19.TabIndex = 101;
		label19.Text = "Sô\u0301 ba\u0300i viết/ID:";
		nudSoLuongUidTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongUidTo.Location = new System.Drawing.Point(234, 79);
		nudSoLuongUidTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongUidTo.Name = "nudSoLuongUidTo";
		nudSoLuongUidTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongUidTo.TabIndex = 2;
		nudSoLuongUidTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label66.Location = new System.Drawing.Point(199, 81);
		label66.Name = "label66";
		label66.Size = new System.Drawing.Size(29, 16);
		label66.TabIndex = 105;
		label66.Text = "đê\u0301n";
		label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D1015611.AutoSize = true;
		D1015611.Cursor = System.Windows.Forms.Cursors.Hand;
		D1015611.Location = new System.Drawing.Point(598, 149);
		D1015611.Name = "ckbShareWall";
		D1015611.Size = new System.Drawing.Size(87, 20);
		D1015611.TabIndex = 9;
		D1015611.Text = "Share wall";
		D1015611.UseVisualStyleBackColor = true;
		D1015611.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(349, 149);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(127, 20);
		ckbComment.TabIndex = 9;
		ckbComment.Text = "Bi\u0300nh luâ\u0323n văn bản";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaUid.Location = new System.Drawing.Point(31, 402);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new System.Drawing.Size(190, 20);
		ckbTuDongXoaUid.TabIndex = 8;
		ckbTuDongXoaUid.Text = "Tự động xóa ID đã tương tác";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		AA3850BA.Location = new System.Drawing.Point(234, 137);
		AA3850BA.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		AA3850BA.Name = "nudDelayTo";
		AA3850BA.Size = new System.Drawing.Size(56, 23);
		AA3850BA.TabIndex = 6;
		nudSoLuongBaiVietTo.Location = new System.Drawing.Point(234, 108);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		F43E0218.Location = new System.Drawing.Point(137, 137);
		F43E0218.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		F43E0218.Name = "nudDelayFrom";
		F43E0218.Size = new System.Drawing.Size(56, 23);
		F43E0218.TabIndex = 5;
		nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(137, 108);
		nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(137, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(193, 23);
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
		D41601AE.AutoSize = true;
		D41601AE.Location = new System.Drawing.Point(27, 139);
		D41601AE.Name = "label5";
		D41601AE.Size = new System.Drawing.Size(89, 16);
		D41601AE.TabIndex = 34;
		D41601AE.Text = "Thơ\u0300i gian chơ\u0300:";
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
		btnCancel.Location = new System.Drawing.Point(364, 439);
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
		btnAdd.Location = new System.Drawing.Point(257, 439);
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
		bunifuCards1.Size = new System.Drawing.Size(710, 37);
		bunifuCards1.TabIndex = 28;
		ckbReel.AutoSize = true;
		ckbReel.Location = new System.Drawing.Point(279, 402);
		ckbReel.Name = "ckbReel";
		ckbReel.Size = new System.Drawing.Size(51, 20);
		ckbReel.TabIndex = 182;
		ckbReel.Text = "Reel";
		ckbReel.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(713, 481);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDSpamBaiViet";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDSpamBaiViet_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plInteract.ResumeLayout(false);
		plInteract.PerformLayout();
		F4816E08.ResumeLayout(false);
		F4816E08.PerformLayout();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongUidTo).EndInit();
		((System.ComponentModel.ISupportInitialize)AA3850BA).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)F43E0218).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
