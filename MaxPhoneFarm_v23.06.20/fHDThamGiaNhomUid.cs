using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDThamGiaNhomUid : Form
{
	internal JObject B08B69BF;

	internal string string_0;

	internal string string_1;

	internal string B3AE4407;

	internal int int_0;

	internal static bool B1BC6A8A;

	internal IContainer C0B0D41B = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl DAA87FAC;

	internal Panel D92F4F28;

	internal NumericUpDown E40B1D22;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox txtTenHanhDong;

	internal Label label3;

	internal Label C51D381F;

	internal Label label2;

	internal Label label1;

	internal Button btnCancel;

	internal Button ED120C32;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button E083663E;

	internal PictureBox C00DE298;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label label8;

	internal Label lblStatus;

	internal NumericUpDown BC9DA61B;

	internal NumericUpDown nudDelayFrom;

	internal Label B0AC0591;

	internal Label label6;

	internal Label BA2E252E;

	internal RichTextBox txtUid;

	internal CheckBox A1A03920;

	internal ToolTip toolTip_0;

	internal Panel plTuongTac;

	internal CheckBox B52E4C87;

	internal TextBox txtCauTraLoi;

	internal Label C48FDAA0;

	internal Label lblStatusComment;

	public fHDThamGiaNhomUid(string string_2, int int_1 = 0, string string_3 = "")
	{
		InitializeComponent();
		B1BC6A8A = false;
		string_0 = string_2;
		B3AE4407 = string_3;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDThamGiaNhomUid");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			ED120C32.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		B08B69BF = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(label2);
		Language.smethod_1(label3);
		Language.smethod_1(C51D381F);
		Language.smethod_1(BA2E252E);
		Language.smethod_1(B0AC0591);
		Language.smethod_1(label6);
		Language.smethod_1(B52E4C87);
		Language.smethod_1(lblStatusComment);
		Language.smethod_1(C48FDAA0);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(A1A03920);
		Language.smethod_1(ED120C32);
		Language.smethod_1(btnCancel);
	}

	private void FF20EC95(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(B08B69BF["nudSoLuongFrom"]);
			E40B1D22.Value = Convert.ToInt32(B08B69BF["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(B08B69BF["nudDelayFrom"]);
			BC9DA61B.Value = Convert.ToInt32(B08B69BF["nudDelayTo"]);
			A1A03920.Checked = Convert.ToBoolean(B08B69BF["ckbThamGiaNhomTrungNhau"]);
			txtUid.Text = B08B69BF["txtUid"]!.ToString();
			B52E4C87.Checked = Convert.ToBoolean(B08B69BF["ckbTuDongTraLoiCauHoi"]);
			A1A03920.Checked = Convert.ToBoolean(B08B69BF["ckbTuDongXoaUid"]);
			txtCauTraLoi.Text = B08B69BF["txtCauTraLoi"]!.ToString();
		}
		catch
		{
		}
		E2236189();
	}

	private void E2236189()
	{
		B52E4C87_CheckedChanged(null, null);
	}

	private void F70D0217(object sender, EventArgs e)
	{
		Close();
	}

	private void ED120C32_Click(object sender, EventArgs e)
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
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sách uid nhóm!"), 3);
			return;
		}
		if (B52E4C87.Checked)
		{
			f1808BA = txtCauTraLoi.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sách câu trả lời!"), 3);
				return;
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", E40B1D22.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", BC9DA61B.Value);
		f72FAFBC.GetValue("ckbThamGiaNhomTrungNhau", A1A03920.Checked);
		f72FAFBC.GetValue("txtUid", (object)txtUid.Text.Trim());
		f72FAFBC.GetValue("ckbTuDongTraLoiCauHoi", B52E4C87.Checked);
		f72FAFBC.GetValue("ckbTuDongXoaUid", A1A03920.Checked);
		f72FAFBC.GetValue("txtCauTraLoi", (object)txtCauTraLoi.Text.Trim());
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text2))
				{
					B1BC6A8A = true;
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
			if (Class123.smethod_14(B3AE4407, text, text2))
			{
				B1BC6A8A = true;
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

	private void CE9AFF30(object sender, PaintEventArgs e)
	{
		if (D92F4F28.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, D92F4F28.ClientSize.Width - num, D92F4F28.ClientSize.Height - num));
		}
	}

	private void E8882C8A(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUid.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid nhóm cần tham gia ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtCauTraLoi_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtCauTraLoi.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatusComment.Text = string.Format(Language.GetValue("Danh sách câu trả lời ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void B52E4C87_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTac.Enabled = B52E4C87.Checked;
	}

	private void label8_Click(object sender, EventArgs e)
	{
	}

	private void lblStatus_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && C0B0D41B != null)
		{
			C0B0D41B.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		C0B0D41B = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDThamGiaNhomUid));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(C0B0D41B);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		DAA87FAC = new Bunifu.Framework.UI.BunifuDragControl(C0B0D41B);
		pnlHeader = new System.Windows.Forms.Panel();
		E083663E = new System.Windows.Forms.Button();
		C00DE298 = new System.Windows.Forms.PictureBox();
		D92F4F28 = new System.Windows.Forms.Panel();
		plTuongTac = new System.Windows.Forms.Panel();
		txtCauTraLoi = new System.Windows.Forms.TextBox();
		C48FDAA0 = new System.Windows.Forms.Label();
		lblStatusComment = new System.Windows.Forms.Label();
		B52E4C87 = new System.Windows.Forms.CheckBox();
		txtUid = new System.Windows.Forms.RichTextBox();
		A1A03920 = new System.Windows.Forms.CheckBox();
		BC9DA61B = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		B0AC0591 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		BA2E252E = new System.Windows.Forms.Label();
		E40B1D22 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		C51D381F = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		ED120C32 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(C0B0D41B);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C00DE298).BeginInit();
		D92F4F28.SuspendLayout();
		plTuongTac.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BC9DA61B).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)E40B1D22).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(687, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tham gia nhóm theo tệp UID";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DAA87FAC.Fixed = true;
		DAA87FAC.Horizontal = true;
		DAA87FAC.TargetControl = pnlHeader;
		DAA87FAC.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(E083663E);
		pnlHeader.Controls.Add(C00DE298);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(687, 31);
		pnlHeader.TabIndex = 9;
		E083663E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		E083663E.Cursor = System.Windows.Forms.Cursors.Hand;
		E083663E.FlatAppearance.BorderSize = 0;
		E083663E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E083663E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E083663E.ForeColor = System.Drawing.Color.White;
		E083663E.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		E083663E.Location = new System.Drawing.Point(656, 1);
		E083663E.Name = "button1";
		E083663E.Size = new System.Drawing.Size(30, 30);
		E083663E.TabIndex = 77;
		E083663E.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		E083663E.UseVisualStyleBackColor = true;
		E083663E.Click += new System.EventHandler(F70D0217);
		C00DE298.Cursor = System.Windows.Forms.Cursors.Default;
		C00DE298.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		C00DE298.Location = new System.Drawing.Point(3, 2);
		C00DE298.Name = "pictureBox1";
		C00DE298.Size = new System.Drawing.Size(34, 27);
		C00DE298.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		C00DE298.TabIndex = 76;
		C00DE298.TabStop = false;
		D92F4F28.BackColor = System.Drawing.Color.White;
		D92F4F28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D92F4F28.Controls.Add(plTuongTac);
		D92F4F28.Controls.Add(B52E4C87);
		D92F4F28.Controls.Add(txtUid);
		D92F4F28.Controls.Add(A1A03920);
		D92F4F28.Controls.Add(BC9DA61B);
		D92F4F28.Controls.Add(label8);
		D92F4F28.Controls.Add(lblStatus);
		D92F4F28.Controls.Add(nudDelayFrom);
		D92F4F28.Controls.Add(B0AC0591);
		D92F4F28.Controls.Add(label6);
		D92F4F28.Controls.Add(BA2E252E);
		D92F4F28.Controls.Add(E40B1D22);
		D92F4F28.Controls.Add(nudSoLuongFrom);
		D92F4F28.Controls.Add(txtTenHanhDong);
		D92F4F28.Controls.Add(label3);
		D92F4F28.Controls.Add(C51D381F);
		D92F4F28.Controls.Add(label2);
		D92F4F28.Controls.Add(label1);
		D92F4F28.Controls.Add(btnCancel);
		D92F4F28.Controls.Add(ED120C32);
		D92F4F28.Controls.Add(bunifuCards1);
		D92F4F28.Cursor = System.Windows.Forms.Cursors.Arrow;
		D92F4F28.Dock = System.Windows.Forms.DockStyle.Fill;
		D92F4F28.Location = new System.Drawing.Point(0, 0);
		D92F4F28.Name = "panel1";
		D92F4F28.Size = new System.Drawing.Size(690, 402);
		D92F4F28.TabIndex = 0;
		D92F4F28.Paint += new System.Windows.Forms.PaintEventHandler(CE9AFF30);
		plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuongTac.Controls.Add(txtCauTraLoi);
		plTuongTac.Controls.Add(C48FDAA0);
		plTuongTac.Controls.Add(lblStatusComment);
		plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		plTuongTac.Location = new System.Drawing.Point(48, 162);
		plTuongTac.Name = "plTuongTac";
		plTuongTac.Size = new System.Drawing.Size(278, 179);
		plTuongTac.TabIndex = 116;
		txtCauTraLoi.Location = new System.Drawing.Point(6, 25);
		txtCauTraLoi.Multiline = true;
		txtCauTraLoi.Name = "txtCauTraLoi";
		txtCauTraLoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtCauTraLoi.Size = new System.Drawing.Size(265, 128);
		txtCauTraLoi.TabIndex = 1;
		txtCauTraLoi.WordWrap = false;
		txtCauTraLoi.TextChanged += new System.EventHandler(txtCauTraLoi_TextChanged);
		C48FDAA0.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		C48FDAA0.AutoSize = true;
		C48FDAA0.Location = new System.Drawing.Point(3, 158);
		C48FDAA0.Name = "label9";
		C48FDAA0.Size = new System.Drawing.Size(133, 16);
		C48FDAA0.TabIndex = 0;
		C48FDAA0.Text = "(Mỗi nội dung 1 dòng)";
		lblStatusComment.AutoSize = true;
		lblStatusComment.Location = new System.Drawing.Point(3, 4);
		lblStatusComment.Name = "lblStatusComment";
		lblStatusComment.Size = new System.Drawing.Size(153, 16);
		lblStatusComment.TabIndex = 0;
		lblStatusComment.Text = "Danh sách câu trả lời (0):";
		B52E4C87.AutoSize = true;
		B52E4C87.Cursor = System.Windows.Forms.Cursors.Hand;
		B52E4C87.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		B52E4C87.Location = new System.Drawing.Point(30, 139);
		B52E4C87.Name = "ckbTuDongTraLoiCauHoi";
		B52E4C87.Size = new System.Drawing.Size(156, 20);
		B52E4C87.TabIndex = 115;
		B52E4C87.Text = "Tự động trả lời câu hỏi";
		B52E4C87.UseVisualStyleBackColor = true;
		B52E4C87.CheckedChanged += new System.EventHandler(B52E4C87_CheckedChanged);
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(356, 72);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(295, 230);
		txtUid.TabIndex = 114;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(E8882C8A);
		A1A03920.AutoSize = true;
		A1A03920.Cursor = System.Windows.Forms.Cursors.Hand;
		A1A03920.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A1A03920.Location = new System.Drawing.Point(355, 324);
		A1A03920.Name = "ckbTuDongXoaUid";
		A1A03920.Size = new System.Drawing.Size(298, 20);
		A1A03920.TabIndex = 113;
		A1A03920.Text = "Tư\u0323 đô\u0323ng xo\u0301a Uid nho\u0301m đa\u0303 gư\u0309i yêu câ\u0300u tham gia";
		A1A03920.UseVisualStyleBackColor = true;
		BC9DA61B.Location = new System.Drawing.Point(229, 111);
		BC9DA61B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BC9DA61B.Name = "nudDelayTo";
		BC9DA61B.Size = new System.Drawing.Size(56, 23);
		BC9DA61B.TabIndex = 4;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(553, 305);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(102, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi Uid 1 dòng)";
		label8.Click += new System.EventHandler(label8_Click);
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(352, 52);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(228, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch Uid nhóm cần tham gia (0):";
		lblStatus.Click += new System.EventHandler(lblStatus_Click);
		nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		B0AC0591.Location = new System.Drawing.Point(194, 113);
		B0AC0591.Name = "label7";
		B0AC0591.Size = new System.Drawing.Size(29, 16);
		B0AC0591.TabIndex = 46;
		B0AC0591.Text = "đê\u0301n";
		B0AC0591.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(287, 113);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		BA2E252E.AutoSize = true;
		BA2E252E.Location = new System.Drawing.Point(27, 113);
		BA2E252E.Name = "label5";
		BA2E252E.Size = new System.Drawing.Size(89, 16);
		BA2E252E.TabIndex = 44;
		BA2E252E.Text = "Thơ\u0300i gian chơ\u0300:";
		E40B1D22.Location = new System.Drawing.Point(229, 80);
		E40B1D22.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E40B1D22.Name = "nudSoLuongTo";
		E40B1D22.Size = new System.Drawing.Size(56, 23);
		E40B1D22.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		label3.Location = new System.Drawing.Point(194, 82);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C51D381F.AutoSize = true;
		C51D381F.Location = new System.Drawing.Point(287, 82);
		C51D381F.Name = "label4";
		C51D381F.Size = new System.Drawing.Size(39, 16);
		C51D381F.TabIndex = 35;
		C51D381F.Text = "nhóm";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 82);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(99, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(355, 359);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		ED120C32.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		ED120C32.Cursor = System.Windows.Forms.Cursors.Hand;
		ED120C32.FlatAppearance.BorderSize = 0;
		ED120C32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		ED120C32.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		ED120C32.ForeColor = System.Drawing.Color.White;
		ED120C32.Location = new System.Drawing.Point(248, 359);
		ED120C32.Name = "btnAdd";
		ED120C32.Size = new System.Drawing.Size(92, 29);
		ED120C32.TabIndex = 6;
		ED120C32.Text = "Thêm";
		ED120C32.UseVisualStyleBackColor = false;
		ED120C32.Click += new System.EventHandler(ED120C32_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(687, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(690, 402);
		base.Controls.Add(D92F4F28);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(FF20EC95);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)C00DE298).EndInit();
		D92F4F28.ResumeLayout(false);
		D92F4F28.PerformLayout();
		plTuongTac.ResumeLayout(false);
		plTuongTac.PerformLayout();
		((System.ComponentModel.ISupportInitialize)BC9DA61B).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)E40B1D22).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
