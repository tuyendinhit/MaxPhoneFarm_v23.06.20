using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDBaiVietBanBe : Form
{
	internal JObject jobject_0;

	internal string CE3012A8;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer EA0D8007 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl B33519AC;

	internal Panel panel1;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudSoLuongBaiVietTo;

	internal NumericUpDown A0B86505;

	internal NumericUpDown nudSoLuongBaiVietFrom;

	internal TextBox txtTenHanhDong;

	internal Label label7;

	internal Label label3;

	internal Label label6;

	internal Label label4;

	internal Label AF0047BC;

	internal Label AA870E25;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button C7217009;

	internal PictureBox D5B7F28C;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plComment;

	internal Label label8;

	internal Label BE19B03B;

	internal CheckBox ckbComment;

	internal CheckBox ckbInteract;

	internal CheckBox AE1B5524;

	internal Label F92BFD06;

	internal NumericUpDown C7B2622D;

	internal Label CB0A8E0F;

	internal Label F2B3FAB7;

	internal NumericUpDown EC15CDAC;

	internal Label label66;

	internal RadioButton rbNganCachKyTu;

	internal RadioButton rbNganCachMoiDong;

	internal Label E587C716;

	internal Button D68B3CB1;

	internal Button btnUp;

	internal RichTextBox B504E527;

	internal Button button2;

	public fHDBaiVietBanBe(string string_2, int int_1 = 0, string FA946BB7 = "")
	{
		InitializeComponent();
		bool_0 = false;
		CE3012A8 = string_2;
		string_1 = FA946BB7;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDBaiVietBanBe");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(FA946BB7);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void EA20B607(object sender, EventArgs e)
	{
		try
		{
			C7B2622D.Value = Convert.ToInt32(jobject_0["nudSoLuongBanBeFrom"]);
			EC15CDAC.Value = Convert.ToInt32(jobject_0["nudSoLuongBanBeTo"]);
			nudSoLuongBaiVietFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongBaiVietFrom"]);
			nudSoLuongBaiVietTo.Value = Convert.ToInt32(jobject_0["nudSoLuongBaiVietTo"]);
			A0B86505.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			ckbInteract.Checked = Convert.ToBoolean(jobject_0["ckbInteract"]);
			AE1B5524.Checked = Convert.ToBoolean(jobject_0["ckbShareWall"]);
			ckbComment.Checked = Convert.ToBoolean(jobject_0["ckbComment"]);
			B504E527.Text = jobject_0["txtComment"]!.ToString();
			if (Convert.ToInt32(jobject_0["typeNganCach"]) == 1)
			{
				rbNganCachKyTu.Checked = true;
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

	private void C7217009_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) != DialogResult.Yes)
			{
				return;
			}
			string text = txtTenHanhDong.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
				return;
			}
			if (ckbComment.Checked)
			{
				List<string> f1808BA = B504E527.Lines.ToList();
				f1808BA = Common.RemoveEmptyItems(f1808BA);
				if (f1808BA.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
					return;
				}
			}
			JSON_Settings f72FAFBC = new JSON_Settings();
			f72FAFBC.GetValue("nudSoLuongBanBeFrom", C7B2622D.Value);
			f72FAFBC.GetValue("nudSoLuongBanBeTo", EC15CDAC.Value);
			f72FAFBC.GetValue("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			f72FAFBC.GetValue("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			f72FAFBC.GetValue("nudDelayFrom", A0B86505.Value);
			f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
			f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
			f72FAFBC.GetValue("ckbShareWall", AE1B5524.Checked);
			f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
			f72FAFBC.GetValue("txtComment", (object)B504E527.Text.Trim());
			int num = 0;
			if (rbNganCachKyTu.Checked)
			{
				num = 1;
			}
			f72FAFBC.GetValue("typeNganCach", num);
			string d9253C2E = f72FAFBC.C71A4EA4();
			if (Class123.smethod_12(CE3012A8, text, string_0, d9253C2E))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
		else
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) != DialogResult.Yes)
			{
				return;
			}
			string text2 = txtTenHanhDong.Text.Trim();
			if (text2 == "")
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
				return;
			}
			if (ckbComment.Checked)
			{
				List<string> f1808BA2 = B504E527.Lines.ToList();
				f1808BA2 = Common.RemoveEmptyItems(f1808BA2);
				if (f1808BA2.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
					return;
				}
			}
			JSON_Settings f72FAFBC2 = new JSON_Settings();
			f72FAFBC2.GetValue("nudSoLuongBanBeFrom", C7B2622D.Value);
			f72FAFBC2.GetValue("nudSoLuongBanBeTo", EC15CDAC.Value);
			f72FAFBC2.GetValue("nudSoLuongBaiVietFrom", nudSoLuongBaiVietFrom.Value);
			f72FAFBC2.GetValue("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			f72FAFBC2.GetValue("nudDelayFrom", A0B86505.Value);
			f72FAFBC2.GetValue("nudDelayTo", nudDelayTo.Value);
			f72FAFBC2.GetValue("ckbInteract", ckbInteract.Checked);
			f72FAFBC2.GetValue("ckbShareWall", AE1B5524.Checked);
			f72FAFBC2.GetValue("ckbComment", ckbComment.Checked);
			f72FAFBC2.GetValue("txtComment", (object)B504E527.Text.Trim());
			int num2 = 0;
			if (rbNganCachKyTu.Checked)
			{
				num2 = 1;
			}
			f72FAFBC2.GetValue("typeNganCach", num2);
			string string_ = f72FAFBC2.C71A4EA4();
			if (Class123.smethod_14(string_1, text2, string_))
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

	private void EF1B2C8E(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void CB166318(object sender, EventArgs e)
	{
	}

	private void FCA45E11(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? B504E527.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : B504E527.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			BE19B03B.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1()
	{
		method_2(null, null);
		ckbComment_CheckedChanged(null, null);
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void C11E3988(object sender, EventArgs e)
	{
		plComment.Height = 163;
	}

	private void D68B3CB1_Click(object sender, EventArgs e)
	{
		plComment.Height = 207;
	}

	private void D5B7F28C_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			D68B3CB1.Visible = true;
		}
	}

	private void rbNganCachMoiDong_CheckedChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	protected override void Dispose(bool ED222CB0)
	{
		if (ED222CB0 && EA0D8007 != null)
		{
			EA0D8007.Dispose();
		}
		base.Dispose(ED222CB0);
	}

	private void InitializeComponent()
	{
		EA0D8007 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBaiVietBanBe));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(EA0D8007);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		B33519AC = new Bunifu.Framework.UI.BunifuDragControl(EA0D8007);
		pnlHeader = new System.Windows.Forms.Panel();
		C7217009 = new System.Windows.Forms.Button();
		D5B7F28C = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		F92BFD06 = new System.Windows.Forms.Label();
		C7B2622D = new System.Windows.Forms.NumericUpDown();
		CB0A8E0F = new System.Windows.Forms.Label();
		F2B3FAB7 = new System.Windows.Forms.Label();
		EC15CDAC = new System.Windows.Forms.NumericUpDown();
		label66 = new System.Windows.Forms.Label();
		plComment = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		B504E527 = new System.Windows.Forms.RichTextBox();
		D68B3CB1 = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		E587C716 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		BE19B03B = new System.Windows.Forms.Label();
		ckbComment = new System.Windows.Forms.CheckBox();
		AE1B5524 = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		A0B86505 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		AF0047BC = new System.Windows.Forms.Label();
		AA870E25 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D5B7F28C).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C7B2622D).BeginInit();
		((System.ComponentModel.ISupportInitialize)EC15CDAC).BeginInit();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)A0B86505).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).BeginInit();
		bunifuCards1.SuspendLayout();
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
		bunifuCustomLabel1.Text = "Cấu hình Bài viết Bạn bè";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B33519AC.Fixed = true;
		B33519AC.Horizontal = true;
		B33519AC.TargetControl = pnlHeader;
		B33519AC.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(C7217009);
		pnlHeader.Controls.Add(D5B7F28C);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		C7217009.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		C7217009.Cursor = System.Windows.Forms.Cursors.Hand;
		C7217009.FlatAppearance.BorderSize = 0;
		C7217009.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C7217009.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C7217009.ForeColor = System.Drawing.Color.White;
		C7217009.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		C7217009.Location = new System.Drawing.Point(328, 1);
		C7217009.Name = "button1";
		C7217009.Size = new System.Drawing.Size(30, 30);
		C7217009.TabIndex = 77;
		C7217009.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C7217009.UseVisualStyleBackColor = true;
		C7217009.Click += new System.EventHandler(C7217009_Click);
		D5B7F28C.Cursor = System.Windows.Forms.Cursors.Default;
		D5B7F28C.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		D5B7F28C.Location = new System.Drawing.Point(3, 2);
		D5B7F28C.Name = "pictureBox1";
		D5B7F28C.Size = new System.Drawing.Size(34, 27);
		D5B7F28C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		D5B7F28C.TabIndex = 76;
		D5B7F28C.TabStop = false;
		D5B7F28C.Click += new System.EventHandler(D5B7F28C_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(F92BFD06);
		panel1.Controls.Add(C7B2622D);
		panel1.Controls.Add(CB0A8E0F);
		panel1.Controls.Add(F2B3FAB7);
		panel1.Controls.Add(EC15CDAC);
		panel1.Controls.Add(label66);
		panel1.Controls.Add(plComment);
		panel1.Controls.Add(ckbComment);
		panel1.Controls.Add(AE1B5524);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudSoLuongBaiVietTo);
		panel1.Controls.Add(A0B86505);
		panel1.Controls.Add(nudSoLuongBaiVietFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(AF0047BC);
		panel1.Controls.Add(AA870E25);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 468);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(EF1B2C8E);
		F92BFD06.AutoSize = true;
		F92BFD06.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F92BFD06.Location = new System.Drawing.Point(27, 81);
		F92BFD06.Name = "label49";
		F92BFD06.Size = new System.Drawing.Size(107, 16);
		F92BFD06.TabIndex = 92;
		F92BFD06.Text = "Sô\u0301 lươ\u0323ng ba\u0323n be\u0300:";
		C7B2622D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C7B2622D.Location = new System.Drawing.Point(135, 79);
		C7B2622D.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		C7B2622D.Name = "nudSoLuongBanBeFrom";
		C7B2622D.Size = new System.Drawing.Size(56, 23);
		C7B2622D.TabIndex = 1;
		C7B2622D.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		CB0A8E0F.AutoSize = true;
		CB0A8E0F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		CB0A8E0F.Location = new System.Drawing.Point(290, 81);
		CB0A8E0F.Name = "label68";
		CB0A8E0F.Size = new System.Drawing.Size(29, 16);
		CB0A8E0F.TabIndex = 99;
		CB0A8E0F.Text = "ba\u0323n";
		F2B3FAB7.AutoSize = true;
		F2B3FAB7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F2B3FAB7.Location = new System.Drawing.Point(27, 112);
		F2B3FAB7.Name = "label19";
		F2B3FAB7.Size = new System.Drawing.Size(99, 16);
		F2B3FAB7.TabIndex = 101;
		F2B3FAB7.Text = "Sô\u0301 ba\u0300i viê\u0301t/ba\u0323n:";
		EC15CDAC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		EC15CDAC.Location = new System.Drawing.Point(232, 79);
		EC15CDAC.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		EC15CDAC.Name = "nudSoLuongBanBeTo";
		EC15CDAC.Size = new System.Drawing.Size(56, 23);
		EC15CDAC.TabIndex = 2;
		EC15CDAC.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label66.Location = new System.Drawing.Point(197, 81);
		label66.Name = "label66";
		label66.Size = new System.Drawing.Size(29, 16);
		label66.TabIndex = 105;
		label66.Text = "đê\u0301n";
		label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(button2);
		plComment.Controls.Add(B504E527);
		plComment.Controls.Add(D68B3CB1);
		plComment.Controls.Add(btnUp);
		plComment.Controls.Add(rbNganCachKyTu);
		plComment.Controls.Add(rbNganCachMoiDong);
		plComment.Controls.Add(E587C716);
		plComment.Controls.Add(label8);
		plComment.Controls.Add(BE19B03B);
		plComment.Location = new System.Drawing.Point(48, 248);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(281, 163);
		plComment.TabIndex = 10;
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(199, 2);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(23, 23);
		button2.TabIndex = 126;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		B504E527.Location = new System.Drawing.Point(7, 27);
		B504E527.Name = "txtComment";
		B504E527.Size = new System.Drawing.Size(266, 111);
		B504E527.TabIndex = 106;
		B504E527.Text = "";
		B504E527.WordWrap = false;
		B504E527.TextChanged += new System.EventHandler(FCA45E11);
		D68B3CB1.BackgroundImage = Resource.Bitmap_91;
		D68B3CB1.Cursor = System.Windows.Forms.Cursors.Hand;
		D68B3CB1.Location = new System.Drawing.Point(224, -1);
		D68B3CB1.Name = "btnDown";
		D68B3CB1.Size = new System.Drawing.Size(25, 25);
		D68B3CB1.TabIndex = 7;
		D68B3CB1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		D68B3CB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D68B3CB1.Visible = false;
		D68B3CB1.Click += new System.EventHandler(D68B3CB1_Click);
		btnUp.BackgroundImage = Resource.Bitmap_73;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.Location = new System.Drawing.Point(255, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 7;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Visible = false;
		btnUp.Click += new System.EventHandler(C11E3988);
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(69, 182);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(203, 20);
		rbNganCachKyTu.TabIndex = 6;
		rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(69, 161);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(171, 20);
		rbNganCachMoiDong.TabIndex = 5;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += new System.EventHandler(rbNganCachMoiDong_CheckedChanged);
		E587C716.AutoSize = true;
		E587C716.Location = new System.Drawing.Point(4, 161);
		E587C716.Name = "label9";
		E587C716.Size = new System.Drawing.Size(65, 16);
		E587C716.TabIndex = 4;
		E587C716.Text = "Tùy chọn:";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 141);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(266, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		BE19B03B.AutoSize = true;
		BE19B03B.Location = new System.Drawing.Point(3, 5);
		BE19B03B.Name = "lblStatus";
		BE19B03B.Size = new System.Drawing.Size(140, 16);
		BE19B03B.TabIndex = 0;
		BE19B03B.Text = "Nội dung bình luận (0):";
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(30, 223);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(131, 20);
		ckbComment.TabIndex = 9;
		ckbComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		AE1B5524.AutoSize = true;
		AE1B5524.Cursor = System.Windows.Forms.Cursors.Hand;
		AE1B5524.Location = new System.Drawing.Point(30, 197);
		AE1B5524.Name = "ckbShareWall";
		AE1B5524.Size = new System.Drawing.Size(123, 20);
		AE1B5524.TabIndex = 8;
		AE1B5524.Text = "Chia sẻ về tường";
		AE1B5524.UseVisualStyleBackColor = true;
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 171);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(49, 20);
		ckbInteract.TabIndex = 7;
		ckbInteract.Text = "Like";
		ckbInteract.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new System.Drawing.Point(232, 140);
		nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 6;
		nudSoLuongBaiVietTo.Location = new System.Drawing.Point(232, 110);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		A0B86505.Location = new System.Drawing.Point(135, 140);
		A0B86505.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		A0B86505.Name = "nudDelayFrom";
		A0B86505.Size = new System.Drawing.Size(56, 23);
		A0B86505.TabIndex = 5;
		nudSoLuongBaiVietFrom.Location = new System.Drawing.Point(135, 110);
		nudSoLuongBaiVietFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietFrom.Name = "nudSoLuongBaiVietFrom";
		nudSoLuongBaiVietFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietFrom.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(135, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Location = new System.Drawing.Point(197, 142);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Location = new System.Drawing.Point(197, 112);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(290, 142);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(290, 112);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(25, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0300i";
		AF0047BC.AutoSize = true;
		AF0047BC.Location = new System.Drawing.Point(27, 142);
		AF0047BC.Name = "label5";
		AF0047BC.Size = new System.Drawing.Size(90, 16);
		AF0047BC.TabIndex = 34;
		AF0047BC.Text = "Thơ\u0300i gian chơ\u0300:";
		AA870E25.AutoSize = true;
		AA870E25.Location = new System.Drawing.Point(27, 52);
		AA870E25.Name = "label1";
		AA870E25.Size = new System.Drawing.Size(99, 16);
		AA870E25.TabIndex = 31;
		AA870E25.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 423);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 423);
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
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 468);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(EA20B607);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)D5B7F28C).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C7B2622D).EndInit();
		((System.ComponentModel.ISupportInitialize)EC15CDAC).EndInit();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)A0B86505).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
