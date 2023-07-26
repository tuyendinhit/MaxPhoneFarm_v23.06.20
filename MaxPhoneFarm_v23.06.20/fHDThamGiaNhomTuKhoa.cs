using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDThamGiaNhomTuKhoa : Form
{
	internal JObject jobject_0;

	internal string F92B46A0;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool E38DA63E;

	internal IContainer AABAFF2D = null;

	internal BunifuDragControl D43D4621;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox D5055233;

	internal Label E39C3E0D;

	internal Label label4;

	internal Label label2;

	internal Label F53E3B09;

	internal Button btnCancel;

	internal Button AFA490A9;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label label8;

	internal Label lblStatus;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudDelayFrom;

	internal Label label7;

	internal Label label6;

	internal Label F931C723;

	internal RichTextBox C339E83E;

	internal ToolTip ED979484;

	internal Panel plTuongTac;

	internal CheckBox ckbTuDongTraLoiCauHoi;

	internal TextBox txtCauTraLoi;

	internal Label label9;

	internal Label CC199DB5;

	public fHDThamGiaNhomTuKhoa(string EA978F00, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		E38DA63E = false;
		F92B46A0 = EA978F00;
		string_1 = string_2;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDThamGiaNhomTuKhoa");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			D5055233.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			AFA490A9.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			D5055233.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(F53E3B09);
		Language.smethod_1(label2);
		Language.smethod_1(E39C3E0D);
		Language.smethod_1(label4);
		Language.smethod_1(F931C723);
		Language.smethod_1(label7);
		Language.smethod_1(label6);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(ckbTuDongTraLoiCauHoi);
		Language.smethod_1(CC199DB5);
		Language.smethod_1(label9);
		Language.smethod_1(AFA490A9);
		Language.smethod_1(btnCancel);
	}

	private void B2AE3DA6(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			C339E83E.Text = jobject_0["txtTuKhoa"]!.ToString();
			ckbTuDongTraLoiCauHoi.Checked = Convert.ToBoolean(jobject_0["ckbTuDongTraLoiCauHoi"]);
			txtCauTraLoi.Text = jobject_0["txtCauTraLoi"]!.ToString();
		}
		catch
		{
		}
		method_1();
	}

	private void method_1()
	{
		ckbTuDongTraLoiCauHoi_CheckedChanged(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A526DD9F(object sender, EventArgs e)
	{
		string text = D5055233.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> f1808BA = C339E83E.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sách từ khóa!"), 3);
			return;
		}
		if (ckbTuDongTraLoiCauHoi.Checked)
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
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("txtTuKhoa", (object)C339E83E.Text.Trim());
		f72FAFBC.GetValue("ckbTuDongTraLoiCauHoi", ckbTuDongTraLoiCauHoi.Checked);
		f72FAFBC.GetValue("txtCauTraLoi", (object)txtCauTraLoi.Text.Trim());
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(F92B46A0, text, string_0, text2))
				{
					E38DA63E = true;
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
				E38DA63E = true;
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

	private void E294158C(object sender, EventArgs e)
	{
	}

	private void C339E83E_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = C339E83E.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch từ khóa ({0}):"), f1808BA.Count.ToString());
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
			CC199DB5.Text = string.Format(Language.GetValue("Danh sách câu trả lời ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void ckbTuDongTraLoiCauHoi_CheckedChanged(object sender, EventArgs e)
	{
		plTuongTac.Enabled = ckbTuDongTraLoiCauHoi.Checked;
	}

	protected override void Dispose(bool E1261107)
	{
		if (E1261107 && AABAFF2D != null)
		{
			AABAFF2D.Dispose();
		}
		base.Dispose(E1261107);
	}

	private void InitializeComponent()
	{
		AABAFF2D = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDThamGiaNhomTuKhoa));
		D43D4621 = new Bunifu.Framework.UI.BunifuDragControl(AABAFF2D);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(AABAFF2D);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plTuongTac = new System.Windows.Forms.Panel();
		txtCauTraLoi = new System.Windows.Forms.TextBox();
		label9 = new System.Windows.Forms.Label();
		CC199DB5 = new System.Windows.Forms.Label();
		ckbTuDongTraLoiCauHoi = new System.Windows.Forms.CheckBox();
		C339E83E = new System.Windows.Forms.RichTextBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		F931C723 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		D5055233 = new System.Windows.Forms.TextBox();
		E39C3E0D = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		F53E3B09 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		AFA490A9 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		ED979484 = new System.Windows.Forms.ToolTip(AABAFF2D);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plTuongTac.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D43D4621.Fixed = true;
		D43D4621.Horizontal = true;
		D43D4621.TargetControl = bunifuCustomLabel1;
		D43D4621.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(710, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Tham gia nhóm theo từ khóa";
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
		pnlHeader.Size = new System.Drawing.Size(710, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(679, 1);
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
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(plTuongTac);
		panel1.Controls.Add(ckbTuDongTraLoiCauHoi);
		panel1.Controls.Add(C339E83E);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(F931C723);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(D5055233);
		panel1.Controls.Add(E39C3E0D);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(F53E3B09);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(AFA490A9);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(713, 375);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plTuongTac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuongTac.Controls.Add(txtCauTraLoi);
		plTuongTac.Controls.Add(label9);
		plTuongTac.Controls.Add(CC199DB5);
		plTuongTac.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		plTuongTac.Location = new System.Drawing.Point(367, 74);
		plTuongTac.Name = "plTuongTac";
		plTuongTac.Size = new System.Drawing.Size(310, 238);
		plTuongTac.TabIndex = 116;
		txtCauTraLoi.Location = new System.Drawing.Point(7, 25);
		txtCauTraLoi.Multiline = true;
		txtCauTraLoi.Name = "txtCauTraLoi";
		txtCauTraLoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtCauTraLoi.Size = new System.Drawing.Size(294, 190);
		txtCauTraLoi.TabIndex = 1;
		txtCauTraLoi.WordWrap = false;
		txtCauTraLoi.TextChanged += new System.EventHandler(txtCauTraLoi_TextChanged);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(3, 218);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(265, 16);
		label9.TabIndex = 0;
		label9.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		CC199DB5.AutoSize = true;
		CC199DB5.Location = new System.Drawing.Point(3, 4);
		CC199DB5.Name = "lblStatusComment";
		CC199DB5.Size = new System.Drawing.Size(153, 16);
		CC199DB5.TabIndex = 0;
		CC199DB5.Text = "Danh sách câu trả lời (0):";
		ckbTuDongTraLoiCauHoi.AutoSize = true;
		ckbTuDongTraLoiCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongTraLoiCauHoi.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongTraLoiCauHoi.Location = new System.Drawing.Point(349, 51);
		ckbTuDongTraLoiCauHoi.Name = "ckbTuDongTraLoiCauHoi";
		ckbTuDongTraLoiCauHoi.Size = new System.Drawing.Size(156, 20);
		ckbTuDongTraLoiCauHoi.TabIndex = 115;
		ckbTuDongTraLoiCauHoi.Text = "Tự động trả lời câu hỏi";
		ckbTuDongTraLoiCauHoi.UseVisualStyleBackColor = true;
		ckbTuDongTraLoiCauHoi.CheckedChanged += new System.EventHandler(ckbTuDongTraLoiCauHoi_CheckedChanged);
		C339E83E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C339E83E.Location = new System.Drawing.Point(31, 159);
		C339E83E.Name = "txtTuKhoa";
		C339E83E.Size = new System.Drawing.Size(295, 136);
		C339E83E.TabIndex = 114;
		C339E83E.Text = "";
		C339E83E.WordWrap = false;
		C339E83E.TextChanged += new System.EventHandler(C339E83E_TextChanged);
		nudDelayTo.Location = new System.Drawing.Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(28, 296);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(259, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi từ khóa 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(27, 139);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(139, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch từ khóa (0):";
		nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		label7.Location = new System.Drawing.Point(194, 113);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(287, 113);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		F931C723.AutoSize = true;
		F931C723.Location = new System.Drawing.Point(27, 113);
		F931C723.Name = "label5";
		F931C723.Size = new System.Drawing.Size(89, 16);
		F931C723.TabIndex = 44;
		F931C723.Text = "Thơ\u0300i gian chơ\u0300:";
		nudSoLuongTo.Location = new System.Drawing.Point(229, 80);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		D5055233.Location = new System.Drawing.Point(132, 49);
		D5055233.Name = "txtTenHanhDong";
		D5055233.Size = new System.Drawing.Size(194, 23);
		D5055233.TabIndex = 0;
		E39C3E0D.Location = new System.Drawing.Point(194, 82);
		E39C3E0D.Name = "label3";
		E39C3E0D.Size = new System.Drawing.Size(29, 16);
		E39C3E0D.TabIndex = 37;
		E39C3E0D.Text = "đê\u0301n";
		E39C3E0D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(287, 82);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(39, 16);
		label4.TabIndex = 35;
		label4.Text = "nhóm";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 82);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(99, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		F53E3B09.AutoSize = true;
		F53E3B09.Location = new System.Drawing.Point(27, 52);
		F53E3B09.Name = "label1";
		F53E3B09.Size = new System.Drawing.Size(98, 16);
		F53E3B09.TabIndex = 31;
		F53E3B09.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(354, 329);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		AFA490A9.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		AFA490A9.Cursor = System.Windows.Forms.Cursors.Hand;
		AFA490A9.FlatAppearance.BorderSize = 0;
		AFA490A9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AFA490A9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AFA490A9.ForeColor = System.Drawing.Color.White;
		AFA490A9.Location = new System.Drawing.Point(247, 329);
		AFA490A9.Name = "btnAdd";
		AFA490A9.Size = new System.Drawing.Size(92, 29);
		AFA490A9.TabIndex = 6;
		AFA490A9.Text = "Thêm";
		AFA490A9.UseVisualStyleBackColor = false;
		AFA490A9.Click += new System.EventHandler(A526DD9F);
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
		ED979484.AutomaticDelay = 0;
		ED979484.AutoPopDelay = 0;
		ED979484.InitialDelay = 0;
		ED979484.ReshowDelay = 0;
		ED979484.ShowAlways = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(713, 375);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDThamGiaNhomTuKhoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B2AE3DA6);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plTuongTac.ResumeLayout(false);
		plTuongTac.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
