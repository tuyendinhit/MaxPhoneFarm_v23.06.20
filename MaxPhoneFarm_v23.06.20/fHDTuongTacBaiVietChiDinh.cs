using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDTuongTacBaiVietChiDinh : Form
{
	internal JSON_Settings CB89E72A;

	internal string string_0;

	internal string BA28B72F;

	internal string string_1;

	internal int A2B0C32E;

	internal static bool DD9D103D;

	internal List<CheckBox> list_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl D721CF22;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button DB823A31;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel E1B16713;

	internal NumericUpDown A485C310;

	internal NumericUpDown nudTimeFrom;

	internal Label label9;

	internal Label B387C0B5;

	internal Label label3;

	internal Panel plComment;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton rbNganCachMoiDong;

	internal Label label8;

	internal RichTextBox txtComment;

	internal Label FD3CFE29;

	internal Label A29E0228;

	internal CheckBox F9AD8885;

	internal Panel EE26D506;

	internal Button CDBAF92C;

	internal Button button2;

	internal CheckBox ckbTuDongXoaNoiDung;

	internal CheckBox C33F2A8C;

	internal LinkLabel linkLabel1;

	internal Panel E31CEB31;

	internal TextBox txtPathAnh;

	internal Label CD876A0B;

	internal CheckBox ckbAnh;

	internal Label label49;

	internal NumericUpDown DE2F04A5;

	internal Label label68;

	internal NumericUpDown E1188E1E;

	internal Label label66;

	internal RichTextBox txtIdPost;

	internal Label lblDanhSachBaiViet;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudDelayFrom;

	internal Label BF1885B4;

	internal Label DE91900E;

	internal Label label10;

	internal Panel BB213D89;

	internal CheckBox ckbTuongTacVideoTrenPost;

	internal Label label2;

	internal Label label5;

	internal Label label12;

	internal NumericUpDown nudTuongTacVideoTrenPostFrom;

	internal NumericUpDown nudTuongTacVideoTrenPostTo;

	internal Button F4B3C424;

	internal Panel plInteract;

	internal CheckBox ckbGian;

	internal CheckBox C92143BE;

	internal CheckBox ckbWow;

	internal CheckBox ckbHaha;

	internal CheckBox ckbThuong;

	internal CheckBox ckbTym;

	internal CheckBox F32611B0;

	internal Panel panel7;

	internal RadioButton radioButton3;

	internal RadioButton radioButton4;

	internal Label F31AEE2D;

	internal TextBox txtApiGetPost;

	internal CheckBox C824F72E;

	public fHDTuongTacBaiVietChiDinh(string string_2, int A38B5D01 = 0, string string_3 = "")
	{
		InitializeComponent();
		Language.SetLanguage(this);
		DD9D103D = false;
		string_0 = string_2;
		string_1 = string_3;
		A2B0C32E = A38B5D01;
		if (Class123.C7BE863B("", "HDTuongTacBaiVietChiDinh").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTuongTacBaiVietChiDinh', 'Tương ta\u0301c ba\u0300i viê\u0301t chi\u0309 đi\u0323nh');");
		}
		string d399C = "";
		switch (A38B5D01)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDTuongTacBaiVietChiDinh");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			BA28B72F = dataTable2.Rows[0]["Id_TuongTac"].ToString();
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
		CB89E72A = new JSON_Settings(d399C, D7BE7F11: true);
	}

	private void fHDTuongTacBaiVietChiDinh_Load(object sender, EventArgs e)
	{
		try
		{
			nudDelayFrom.Value = CB89E72A.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = CB89E72A.method_0("nudDelayTo", 5);
			DE2F04A5.Value = CB89E72A.method_0("nudSoLuongUidFrom", 1);
			E1188E1E.Value = CB89E72A.method_0("nudSoLuongUidTo", 3);
			txtIdPost.Text = CB89E72A.GetValue("txtIdPost");
			nudTimeFrom.Value = CB89E72A.method_0("nudTimeFrom", 3);
			A485C310.Value = CB89E72A.method_0("nudTimeTo", 5);
			C33F2A8C.Checked = CB89E72A.AA824D29("ckbInteract");
			string text = CB89E72A.GetValue("typeReaction");
			list_0 = new List<CheckBox> { F32611B0, ckbTym, ckbThuong, ckbHaha, ckbWow, C92143BE, ckbGian };
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].Checked = text.Contains(i.ToString());
			}
			F9AD8885.Checked = CB89E72A.AA824D29("ckbComment");
			txtComment.Text = CB89E72A.GetValue("txtComment");
			ckbTuDongXoaNoiDung.Checked = CB89E72A.AA824D29("ckbTuDongXoaNoiDung");
			if (CB89E72A.method_0("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			ckbAnh.Checked = CB89E72A.AA824D29("ckbAnh");
			txtPathAnh.Text = CB89E72A.GetValue("txtPathAnh");
			ckbTuongTacVideoTrenPost.Checked = CB89E72A.AA824D29("ckbTuongTacVideoTrenPost");
			nudTuongTacVideoTrenPostFrom.Value = CB89E72A.method_0("nudTuongTacVideoTrenPostFrom", 3);
			nudTuongTacVideoTrenPostTo.Value = CB89E72A.method_0("nudTuongTacVideoTrenPostTo", 5);
			C824F72E.Checked = CB89E72A.AA824D29("ckbGetPostAPI");
			txtApiGetPost.Text = CB89E72A.GetValue("txtApiGetPost");
		}
		catch
		{
		}
		method_1();
	}

	private void C2063C03(object sender, EventArgs e)
	{
		Close();
	}

	private void BB0F83B9(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (F9AD8885.Checked)
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
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("nudSoLuongUidFrom", DE2F04A5.Value);
		f72FAFBC.GetValue("nudSoLuongUidTo", E1188E1E.Value);
		f72FAFBC.GetValue("txtIdPost", (object)txtIdPost.Text.Trim());
		f72FAFBC.GetValue("nudTimeFrom", nudTimeFrom.Value);
		f72FAFBC.GetValue("nudTimeTo", A485C310.Value);
		f72FAFBC.GetValue("ckbInteract", C33F2A8C.Checked);
		string text2 = "";
		for (int i = 0; i < list_0.Count; i++)
		{
			text2 += (list_0[i].Checked ? (i.ToString() ?? "") : "");
		}
		f72FAFBC.GetValue("typeReaction", (object)text2);
		f72FAFBC.GetValue("ckbComment", F9AD8885.Checked);
		f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
		f72FAFBC.GetValue("ckbTuDongXoaNoiDung", ckbTuDongXoaNoiDung.Checked);
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		f72FAFBC.GetValue("typeNganCach", num);
		f72FAFBC.GetValue("ckbAnh", ckbAnh.Checked);
		f72FAFBC.GetValue("txtPathAnh", (object)txtPathAnh.Text.Trim());
		f72FAFBC.GetValue("ckbTuongTacVideoTrenPost", ckbTuongTacVideoTrenPost.Checked);
		f72FAFBC.GetValue("nudTuongTacVideoTrenPostFrom", nudTuongTacVideoTrenPostFrom.Value);
		f72FAFBC.GetValue("nudTuongTacVideoTrenPostTo", nudTuongTacVideoTrenPostTo.Value);
		f72FAFBC.GetValue("ckbGetPostAPI", C824F72E.Checked);
		f72FAFBC.GetValue("txtApiGetPost", (object)txtApiGetPost.Text.Trim());
		string text3 = f72FAFBC.C71A4EA4();
		if (A2B0C32E == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, BA28B72F, text3))
				{
					DD9D103D = true;
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
				DD9D103D = true;
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
		try
		{
			List<string> f1808BA = txtComment.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			A29E0228.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		C33F2A8C_CheckedChanged(null, null);
		F9AD8885_CheckedChanged(null, null);
		C89CBB9B(null, null);
		ckbTuongTacVideoTrenPost_CheckedChanged(null, null);
		C824F72E_CheckedChanged(null, null);
	}

	private void F9AD8885_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = F9AD8885.Checked;
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void panel1_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void method_6(object sender, EventArgs e)
	{
	}

	private void method_7(object sender, EventArgs e)
	{
		plComment.Height = 195;
	}

	private void DD27DE3A(object sender, EventArgs e)
	{
		plComment.Height = 237;
	}

	private void CE24A01F(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void CDBAF92C_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		method_8();
	}

	private void FB897C13(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	private void method_8()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			A29E0228.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_8();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_8();
	}

	private void C33F2A8C_CheckedChanged(object sender, EventArgs e)
	{
		plInteract.Enabled = C33F2A8C.Checked;
	}

	private void C6327AB7(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Common.smethod_16(new fHuongDanRandom());
	}

	private void C89CBB9B(object sender, EventArgs e)
	{
		E31CEB31.Enabled = ckbAnh.Checked;
	}

	private void txtIdPost_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtIdPost, lblDanhSachBaiViet);
	}

	private void ckbTuongTacVideoTrenPost_CheckedChanged(object sender, EventArgs e)
	{
		BB213D89.Enabled = ckbTuongTacVideoTrenPost.Checked;
	}

	private void F4B3C424_Click(object sender, EventArgs e)
	{
		txtIdPost.Height = 228;
	}

	private void C824F72E_CheckedChanged(object sender, EventArgs e)
	{
		txtApiGetPost.Enabled = C824F72E.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDTuongTacBaiVietChiDinh));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		E1B16713 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D721CF22 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		DB823A31 = new System.Windows.Forms.Button();
		panel1 = new System.Windows.Forms.Panel();
		plInteract = new System.Windows.Forms.Panel();
		ckbGian = new System.Windows.Forms.CheckBox();
		C92143BE = new System.Windows.Forms.CheckBox();
		ckbWow = new System.Windows.Forms.CheckBox();
		ckbHaha = new System.Windows.Forms.CheckBox();
		ckbThuong = new System.Windows.Forms.CheckBox();
		ckbTym = new System.Windows.Forms.CheckBox();
		F32611B0 = new System.Windows.Forms.CheckBox();
		panel7 = new System.Windows.Forms.Panel();
		radioButton3 = new System.Windows.Forms.RadioButton();
		radioButton4 = new System.Windows.Forms.RadioButton();
		F31AEE2D = new System.Windows.Forms.Label();
		F4B3C424 = new System.Windows.Forms.Button();
		label49 = new System.Windows.Forms.Label();
		DE2F04A5 = new System.Windows.Forms.NumericUpDown();
		label68 = new System.Windows.Forms.Label();
		E1188E1E = new System.Windows.Forms.NumericUpDown();
		label66 = new System.Windows.Forms.Label();
		txtIdPost = new System.Windows.Forms.RichTextBox();
		lblDanhSachBaiViet = new System.Windows.Forms.Label();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		BF1885B4 = new System.Windows.Forms.Label();
		DE91900E = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		E31CEB31 = new System.Windows.Forms.Panel();
		txtPathAnh = new System.Windows.Forms.TextBox();
		CD876A0B = new System.Windows.Forms.Label();
		ckbAnh = new System.Windows.Forms.CheckBox();
		C33F2A8C = new System.Windows.Forms.CheckBox();
		BB213D89 = new System.Windows.Forms.Panel();
		label2 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		nudTuongTacVideoTrenPostFrom = new System.Windows.Forms.NumericUpDown();
		nudTuongTacVideoTrenPostTo = new System.Windows.Forms.NumericUpDown();
		plComment = new System.Windows.Forms.Panel();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		ckbTuDongXoaNoiDung = new System.Windows.Forms.CheckBox();
		EE26D506 = new System.Windows.Forms.Panel();
		CDBAF92C = new System.Windows.Forms.Button();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		button2 = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		label8 = new System.Windows.Forms.Label();
		txtComment = new System.Windows.Forms.RichTextBox();
		FD3CFE29 = new System.Windows.Forms.Label();
		A29E0228 = new System.Windows.Forms.Label();
		ckbTuongTacVideoTrenPost = new System.Windows.Forms.CheckBox();
		F9AD8885 = new System.Windows.Forms.CheckBox();
		A485C310 = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label9 = new System.Windows.Forms.Label();
		B387C0B5 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		C824F72E = new System.Windows.Forms.CheckBox();
		txtApiGetPost = new System.Windows.Forms.TextBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plInteract.SuspendLayout();
		panel7.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DE2F04A5).BeginInit();
		((System.ComponentModel.ISupportInitialize)E1188E1E).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		E31CEB31.SuspendLayout();
		BB213D89.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudTuongTacVideoTrenPostFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTuongTacVideoTrenPostTo).BeginInit();
		plComment.SuspendLayout();
		EE26D506.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A485C310).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = E1B16713;
		bunifuDragControl_0.Vertical = true;
		E1B16713.BackColor = System.Drawing.Color.Transparent;
		E1B16713.Cursor = System.Windows.Forms.Cursors.SizeAll;
		E1B16713.Dock = System.Windows.Forms.DockStyle.Fill;
		E1B16713.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E1B16713.ForeColor = System.Drawing.Color.Black;
		E1B16713.Location = new System.Drawing.Point(0, 0);
		E1B16713.Name = "bunifuCustomLabel1";
		E1B16713.Size = new System.Drawing.Size(679, 31);
		E1B16713.TabIndex = 12;
		E1B16713.Text = "Câ\u0301u hi\u0300nh Tương ta\u0301c ba\u0300i viê\u0301t";
		E1B16713.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D721CF22.Fixed = true;
		D721CF22.Horizontal = true;
		D721CF22.TargetControl = pnlHeader;
		D721CF22.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(E1B16713);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(679, 31);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		DB823A31.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		DB823A31.Cursor = System.Windows.Forms.Cursors.Hand;
		DB823A31.FlatAppearance.BorderSize = 0;
		DB823A31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DB823A31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DB823A31.ForeColor = System.Drawing.Color.White;
		DB823A31.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		DB823A31.Location = new System.Drawing.Point(688, 5);
		DB823A31.Name = "button1";
		DB823A31.Size = new System.Drawing.Size(30, 30);
		DB823A31.TabIndex = 77;
		DB823A31.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		DB823A31.UseVisualStyleBackColor = true;
		DB823A31.Click += new System.EventHandler(C2063C03);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(txtIdPost);
		panel1.Controls.Add(txtApiGetPost);
		panel1.Controls.Add(plInteract);
		panel1.Controls.Add(F4B3C424);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(DE2F04A5);
		panel1.Controls.Add(label68);
		panel1.Controls.Add(E1188E1E);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(lblDanhSachBaiViet);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(BF1885B4);
		panel1.Controls.Add(DE91900E);
		panel1.Controls.Add(label10);
		panel1.Controls.Add(E31CEB31);
		panel1.Controls.Add(ckbAnh);
		panel1.Controls.Add(C33F2A8C);
		panel1.Controls.Add(BB213D89);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(C824F72E);
		panel1.Controls.Add(ckbTuongTacVideoTrenPost);
		panel1.Controls.Add(F9AD8885);
		panel1.Controls.Add(A485C310);
		panel1.Controls.Add(nudTimeFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(B387C0B5);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(723, 535);
		panel1.TabIndex = 0;
		panel1.Click += new System.EventHandler(panel1_Click);
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plInteract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plInteract.Controls.Add(ckbGian);
		plInteract.Controls.Add(C92143BE);
		plInteract.Controls.Add(ckbWow);
		plInteract.Controls.Add(ckbHaha);
		plInteract.Controls.Add(ckbThuong);
		plInteract.Controls.Add(ckbTym);
		plInteract.Controls.Add(F32611B0);
		plInteract.Controls.Add(panel7);
		plInteract.Controls.Add(F31AEE2D);
		plInteract.Location = new System.Drawing.Point(380, 130);
		plInteract.Name = "plInteract";
		plInteract.Size = new System.Drawing.Size(312, 33);
		plInteract.TabIndex = 192;
		ckbGian.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGian.Image = Resource.Bitmap_5;
		ckbGian.Location = new System.Drawing.Point(266, 1);
		ckbGian.Name = "ckbGian";
		ckbGian.Size = new System.Drawing.Size(40, 30);
		ckbGian.TabIndex = 179;
		ckbGian.UseVisualStyleBackColor = true;
		C92143BE.Cursor = System.Windows.Forms.Cursors.Hand;
		C92143BE.Image = Resource.Bitmap_174;
		C92143BE.Location = new System.Drawing.Point(222, 1);
		C92143BE.Name = "ckbBuon";
		C92143BE.Size = new System.Drawing.Size(40, 30);
		C92143BE.TabIndex = 178;
		C92143BE.UseVisualStyleBackColor = true;
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
		ckbThuong.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbThuong.Image = Resource.DD3ED6B8;
		ckbThuong.Location = new System.Drawing.Point(90, 1);
		ckbThuong.Name = "ckbThuong";
		ckbThuong.Size = new System.Drawing.Size(40, 30);
		ckbThuong.TabIndex = 175;
		ckbThuong.UseVisualStyleBackColor = true;
		ckbTym.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTym.Image = Resource.C8AF3BB6;
		ckbTym.Location = new System.Drawing.Point(46, 1);
		ckbTym.Name = "ckbTym";
		ckbTym.Size = new System.Drawing.Size(40, 30);
		ckbTym.TabIndex = 174;
		ckbTym.UseVisualStyleBackColor = true;
		F32611B0.Checked = true;
		F32611B0.CheckState = System.Windows.Forms.CheckState.Checked;
		F32611B0.Cursor = System.Windows.Forms.Cursors.Hand;
		F32611B0.Image = Resource.Bitmap_163;
		F32611B0.Location = new System.Drawing.Point(2, 1);
		F32611B0.Name = "ckbLike";
		F32611B0.Size = new System.Drawing.Size(40, 30);
		F32611B0.TabIndex = 173;
		F32611B0.UseVisualStyleBackColor = true;
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
		F31AEE2D.AutoSize = true;
		F31AEE2D.Location = new System.Drawing.Point(4, 302);
		F31AEE2D.Name = "label26";
		F31AEE2D.Size = new System.Drawing.Size(64, 16);
		F31AEE2D.TabIndex = 2;
		F31AEE2D.Text = "Tùy chọn:";
		F4B3C424.BackgroundImage = Resource.Bitmap_73;
		F4B3C424.Cursor = System.Windows.Forms.Cursors.Hand;
		F4B3C424.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		F4B3C424.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F4B3C424.Location = new System.Drawing.Point(304, 131);
		F4B3C424.Name = "btnUp";
		F4B3C424.Size = new System.Drawing.Size(25, 25);
		F4B3C424.TabIndex = 191;
		F4B3C424.Click += new System.EventHandler(F4B3C424_Click);
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(27, 80);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(100, 16);
		label49.TabIndex = 188;
		label49.Text = "Sô\u0301 bài viết/Nick:";
		DE2F04A5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		DE2F04A5.Location = new System.Drawing.Point(136, 78);
		DE2F04A5.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		DE2F04A5.Name = "nudSoLuongUidFrom";
		DE2F04A5.Size = new System.Drawing.Size(56, 23);
		DE2F04A5.TabIndex = 186;
		DE2F04A5.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label68.AutoSize = true;
		label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label68.Location = new System.Drawing.Point(291, 80);
		label68.Name = "label68";
		label68.Size = new System.Drawing.Size(24, 16);
		label68.TabIndex = 189;
		label68.Text = "bài";
		E1188E1E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		E1188E1E.Location = new System.Drawing.Point(233, 78);
		E1188E1E.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		E1188E1E.Name = "nudSoLuongUidTo";
		E1188E1E.Size = new System.Drawing.Size(56, 23);
		E1188E1E.TabIndex = 187;
		E1188E1E.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label66.Location = new System.Drawing.Point(198, 80);
		label66.Name = "label66";
		label66.Size = new System.Drawing.Size(29, 16);
		label66.TabIndex = 190;
		label66.Text = "đê\u0301n";
		label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		txtIdPost.Location = new System.Drawing.Point(30, 156);
		txtIdPost.Name = "txtIdPost";
		txtIdPost.Size = new System.Drawing.Size(300, 311);
		txtIdPost.TabIndex = 179;
		txtIdPost.Text = "";
		txtIdPost.WordWrap = false;
		txtIdPost.TextChanged += new System.EventHandler(txtIdPost_TextChanged);
		lblDanhSachBaiViet.AutoSize = true;
		lblDanhSachBaiViet.Location = new System.Drawing.Point(27, 137);
		lblDanhSachBaiViet.Name = "lblDanhSachBaiViet";
		lblDanhSachBaiViet.Size = new System.Drawing.Size(160, 16);
		lblDanhSachBaiViet.TabIndex = 185;
		lblDanhSachBaiViet.Text = "Danh sa\u0301ch link bài viết (0):";
		nudDelayTo.Location = new System.Drawing.Point(233, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 181;
		nudDelayFrom.Location = new System.Drawing.Point(136, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 180;
		BF1885B4.Location = new System.Drawing.Point(198, 109);
		BF1885B4.Name = "label7";
		BF1885B4.Size = new System.Drawing.Size(29, 16);
		BF1885B4.TabIndex = 184;
		BF1885B4.Text = "đê\u0301n";
		BF1885B4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DE91900E.AutoSize = true;
		DE91900E.Location = new System.Drawing.Point(291, 109);
		DE91900E.Name = "label6";
		DE91900E.Size = new System.Drawing.Size(30, 16);
		DE91900E.TabIndex = 183;
		DE91900E.Text = "giây";
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(27, 109);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(89, 16);
		label10.TabIndex = 182;
		label10.Text = "Thơ\u0300i gian chờ:";
		E31CEB31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E31CEB31.Controls.Add(txtPathAnh);
		E31CEB31.Controls.Add(CD876A0B);
		E31CEB31.Location = new System.Drawing.Point(379, 436);
		E31CEB31.Name = "plAnh";
		E31CEB31.Size = new System.Drawing.Size(313, 31);
		E31CEB31.TabIndex = 178;
		txtPathAnh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtPathAnh.Location = new System.Drawing.Point(90, 3);
		txtPathAnh.Name = "txtPathAnh";
		txtPathAnh.Size = new System.Drawing.Size(218, 23);
		txtPathAnh.TabIndex = 1;
		CD876A0B.AutoSize = true;
		CD876A0B.Location = new System.Drawing.Point(3, 6);
		CD876A0B.Name = "label14";
		CD876A0B.Size = new System.Drawing.Size(88, 16);
		CD876A0B.TabIndex = 0;
		CD876A0B.Text = "Thư mu\u0323c ảnh:";
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAnh.Location = new System.Drawing.Point(362, 412);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new System.Drawing.Size(103, 20);
		ckbAnh.TabIndex = 177;
		ckbAnh.Text = "Bình luận ảnh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += new System.EventHandler(C89CBB9B);
		C33F2A8C.AutoSize = true;
		C33F2A8C.Cursor = System.Windows.Forms.Cursors.Hand;
		C33F2A8C.Location = new System.Drawing.Point(362, 104);
		C33F2A8C.Name = "ckbInteract";
		C33F2A8C.Size = new System.Drawing.Size(112, 20);
		C33F2A8C.TabIndex = 167;
		C33F2A8C.Text = "Ba\u0300y to\u0309 ca\u0309m xu\u0301c";
		C33F2A8C.UseVisualStyleBackColor = true;
		C33F2A8C.CheckedChanged += new System.EventHandler(C33F2A8C_CheckedChanged);
		BB213D89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BB213D89.Controls.Add(label2);
		BB213D89.Controls.Add(label5);
		BB213D89.Controls.Add(label12);
		BB213D89.Controls.Add(nudTuongTacVideoTrenPostFrom);
		BB213D89.Controls.Add(nudTuongTacVideoTrenPostTo);
		BB213D89.Location = new System.Drawing.Point(49, 436);
		BB213D89.Name = "plTuongTacVideoTrenPost";
		BB213D89.Size = new System.Drawing.Size(281, 31);
		BB213D89.TabIndex = 164;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(3, 5);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(93, 16);
		label2.TabIndex = 34;
		label2.Text = "Thời gian xem:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(237, 5);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(30, 16);
		label5.TabIndex = 36;
		label5.Text = "giây";
		label12.Location = new System.Drawing.Point(154, 5);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(29, 16);
		label12.TabIndex = 38;
		label12.Text = "đê\u0301n";
		label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudTuongTacVideoTrenPostFrom.Location = new System.Drawing.Point(102, 3);
		nudTuongTacVideoTrenPostFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTuongTacVideoTrenPostFrom.Name = "nudTuongTacVideoTrenPostFrom";
		nudTuongTacVideoTrenPostFrom.Size = new System.Drawing.Size(51, 23);
		nudTuongTacVideoTrenPostFrom.TabIndex = 3;
		nudTuongTacVideoTrenPostTo.Location = new System.Drawing.Point(184, 3);
		nudTuongTacVideoTrenPostTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTuongTacVideoTrenPostTo.Name = "nudTuongTacVideoTrenPostTo";
		nudTuongTacVideoTrenPostTo.Size = new System.Drawing.Size(51, 23);
		nudTuongTacVideoTrenPostTo.TabIndex = 4;
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(linkLabel1);
		plComment.Controls.Add(ckbTuDongXoaNoiDung);
		plComment.Controls.Add(EE26D506);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(FD3CFE29);
		plComment.Controls.Add(A29E0228);
		plComment.Location = new System.Drawing.Point(380, 193);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(312, 216);
		plComment.TabIndex = 164;
		linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.Location = new System.Drawing.Point(221, 128);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(81, 16);
		linkLabel1.TabIndex = 191;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Random icon";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(C6327AB7);
		ckbTuDongXoaNoiDung.AutoSize = true;
		ckbTuDongXoaNoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaNoiDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongXoaNoiDung.Location = new System.Drawing.Point(7, 192);
		ckbTuDongXoaNoiDung.Name = "ckbTuDongXoaNoiDung";
		ckbTuDongXoaNoiDung.Size = new System.Drawing.Size(219, 20);
		ckbTuDongXoaNoiDung.TabIndex = 131;
		ckbTuDongXoaNoiDung.Text = "Tư\u0323 đô\u0323ng xo\u0301a nô\u0323i dung đa\u0303 sư\u0309 du\u0323ng";
		ckbTuDongXoaNoiDung.UseVisualStyleBackColor = true;
		EE26D506.Controls.Add(CDBAF92C);
		EE26D506.Controls.Add(rbNganCachMoiDong);
		EE26D506.Controls.Add(button2);
		EE26D506.Controls.Add(rbNganCachKyTu);
		EE26D506.Location = new System.Drawing.Point(70, 144);
		EE26D506.Name = "panel2";
		EE26D506.Size = new System.Drawing.Size(200, 46);
		EE26D506.TabIndex = 42;
		CDBAF92C.Cursor = System.Windows.Forms.Cursors.Help;
		CDBAF92C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CDBAF92C.Location = new System.Drawing.Point(165, 22);
		CDBAF92C.Name = "button3";
		CDBAF92C.Size = new System.Drawing.Size(21, 21);
		CDBAF92C.TabIndex = 172;
		CDBAF92C.Text = "?";
		CDBAF92C.UseVisualStyleBackColor = true;
		CDBAF92C.Click += new System.EventHandler(CDBAF92C_Click);
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
		rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(165, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 21);
		button2.TabIndex = 173;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(CE24A01F);
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(3, 24);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(159, 20);
		rbNganCachKyTu.TabIndex = 3;
		rbNganCachKyTu.Text = "Nội dung có nhiều dòng";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 147);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(64, 16);
		label8.TabIndex = 2;
		label8.Text = "Tùy chọn:";
		txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtComment.Location = new System.Drawing.Point(7, 25);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(294, 102);
		txtComment.TabIndex = 1;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		FD3CFE29.AutoSize = true;
		FD3CFE29.Location = new System.Drawing.Point(5, 128);
		FD3CFE29.Name = "label11";
		FD3CFE29.Size = new System.Drawing.Size(133, 16);
		FD3CFE29.TabIndex = 0;
		FD3CFE29.Text = "Spin nội dung {a|b|c}";
		A29E0228.AutoSize = true;
		A29E0228.Location = new System.Drawing.Point(3, 5);
		A29E0228.Name = "lblStatus";
		A29E0228.Size = new System.Drawing.Size(139, 16);
		A29E0228.TabIndex = 0;
		A29E0228.Text = "Nội dung bình luận (0):";
		ckbTuongTacVideoTrenPost.AutoSize = true;
		ckbTuongTacVideoTrenPost.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuongTacVideoTrenPost.Location = new System.Drawing.Point(31, 413);
		ckbTuongTacVideoTrenPost.Name = "ckbTuongTacVideoTrenPost";
		ckbTuongTacVideoTrenPost.Size = new System.Drawing.Size(190, 20);
		ckbTuongTacVideoTrenPost.TabIndex = 163;
		ckbTuongTacVideoTrenPost.Text = "Tương tác video trên bài viết";
		ckbTuongTacVideoTrenPost.UseVisualStyleBackColor = true;
		ckbTuongTacVideoTrenPost.CheckedChanged += new System.EventHandler(ckbTuongTacVideoTrenPost_CheckedChanged);
		F9AD8885.AutoSize = true;
		F9AD8885.Cursor = System.Windows.Forms.Cursors.Hand;
		F9AD8885.Location = new System.Drawing.Point(362, 170);
		F9AD8885.Name = "ckbComment";
		F9AD8885.Size = new System.Drawing.Size(127, 20);
		F9AD8885.TabIndex = 163;
		F9AD8885.Text = "Bi\u0300nh luâ\u0323n văn bản";
		F9AD8885.UseVisualStyleBackColor = true;
		F9AD8885.CheckedChanged += new System.EventHandler(F9AD8885_CheckedChanged);
		A485C310.Location = new System.Drawing.Point(526, 78);
		A485C310.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A485C310.Name = "nudTimeTo";
		A485C310.Size = new System.Drawing.Size(51, 23);
		A485C310.TabIndex = 4;
		nudTimeFrom.Location = new System.Drawing.Point(448, 78);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(51, 23);
		nudTimeFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(136, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label9.Location = new System.Drawing.Point(499, 80);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(29, 16);
		label9.TabIndex = 38;
		label9.Text = "đê\u0301n";
		label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B387C0B5.AutoSize = true;
		B387C0B5.Location = new System.Drawing.Point(579, 80);
		B387C0B5.Name = "label4";
		B387C0B5.Size = new System.Drawing.Size(30, 16);
		B387C0B5.TabIndex = 36;
		B387C0B5.Text = "giây";
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(359, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(83, 16);
		label3.TabIndex = 34;
		label3.Text = "Xem bài viết:";
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
		btnCancel.Location = new System.Drawing.Point(369, 490);
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
		btnAdd.Location = new System.Drawing.Point(262, 490);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(BB0F83B9);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(DB823A31);
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(721, 37);
		bunifuCards1.TabIndex = 28;
		C824F72E.AutoSize = true;
		C824F72E.Cursor = System.Windows.Forms.Cursors.Hand;
		C824F72E.Location = new System.Drawing.Point(31, 390);
		C824F72E.Name = "ckbGetPostAPI";
		C824F72E.Size = new System.Drawing.Size(134, 20);
		C824F72E.TabIndex = 163;
		C824F72E.Text = "Lấy bài viết từ API:";
		C824F72E.UseVisualStyleBackColor = true;
		C824F72E.CheckedChanged += new System.EventHandler(C824F72E_CheckedChanged);
		txtApiGetPost.Location = new System.Drawing.Point(161, 388);
		txtApiGetPost.Name = "txtApiGetPost";
		txtApiGetPost.Size = new System.Drawing.Size(168, 23);
		txtApiGetPost.TabIndex = 193;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(723, 535);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTuongTacBaiVietChiDinh";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDTuongTacBaiVietChiDinh_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plInteract.ResumeLayout(false);
		plInteract.PerformLayout();
		panel7.ResumeLayout(false);
		panel7.PerformLayout();
		((System.ComponentModel.ISupportInitialize)DE2F04A5).EndInit();
		((System.ComponentModel.ISupportInitialize)E1188E1E).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		E31CEB31.ResumeLayout(false);
		E31CEB31.PerformLayout();
		BB213D89.ResumeLayout(false);
		BB213D89.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudTuongTacVideoTrenPostFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTuongTacVideoTrenPostTo).EndInit();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		EE26D506.ResumeLayout(false);
		EE26D506.PerformLayout();
		((System.ComponentModel.ISupportInitialize)A485C310).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
