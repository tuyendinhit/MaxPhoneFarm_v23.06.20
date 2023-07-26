using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDChucMungSinhNhat : Form
{
	internal JObject jobject_0;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int AA011914;

	internal static bool B1AE6EA5;

	internal IContainer EF8C5104 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl F43A8B02;

	internal Panel panel1;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox txtTenHanhDong;

	internal Label F928012B;

	internal Label D922FF3C;

	internal Label label2;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox D79E68A6;

	internal BunifuCustomLabel B31F2FAC;

	internal Label label8;

	internal Label lblStatus;

	internal TextBox D20F3324;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudDelayFrom;

	internal Label label7;

	internal Label label6;

	internal Label label5;

	internal RadioButton rbDangBai;

	internal RadioButton rbNhanTin;

	internal Label label28;

	public fHDChucMungSinhNhat(string string_3, int int_0 = 0, string EA376D95 = "")
	{
		InitializeComponent();
		B1AE6EA5 = false;
		string_0 = string_3;
		string_2 = EA376D95;
		AA011914 = int_0;
		string json = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDChucMungSinhNhat");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(EA376D95);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(B31F2FAC);
		Language.smethod_1(label1);
		Language.smethod_1(label2);
		Language.smethod_1(F928012B);
		Language.smethod_1(D922FF3C);
		Language.smethod_1(label5);
		Language.smethod_1(label7);
		Language.smethod_1(label6);
		Language.smethod_1(label28);
		Language.smethod_1(rbNhanTin);
		Language.smethod_1(rbDangBai);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void fHDChucMungSinhNhat_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			if (Convert.ToInt32(jobject_0["typeAction"]) == 0)
			{
				rbNhanTin.Checked = true;
			}
			else
			{
				rbDangBai.Checked = true;
			}
			D20F3324.Text = jobject_0["txtContent"]!.ToString();
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C4858A33(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> f1808BA = D20F3324.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhă\u0301n/ba\u0300i viê\u0301t!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		if (rbNhanTin.Checked)
		{
			f72FAFBC.GetValue("typeAction", 0);
		}
		else
		{
			f72FAFBC.GetValue("typeAction", 1);
		}
		f72FAFBC.GetValue("txtContent", (object)D20F3324.Text.Trim());
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (AA011914 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, d9253C2E))
				{
					B1AE6EA5 = true;
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
			if (Class123.smethod_14(string_2, text, d9253C2E))
			{
				B1AE6EA5 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void C9A8589C(object sender, EventArgs e)
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

	private void DC242903(object sender, EventArgs e)
	{
	}

	private void B639E011(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = D20F3324.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch tin nhă\u0301n/ba\u0300i viê\u0301t ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người nhận!"));
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && EF8C5104 != null)
		{
			EF8C5104.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		EF8C5104 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDChucMungSinhNhat));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(EF8C5104);
		B31F2FAC = new Bunifu.Framework.UI.BunifuCustomLabel();
		F43A8B02 = new Bunifu.Framework.UI.BunifuDragControl(EF8C5104);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		D79E68A6 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		rbDangBai = new System.Windows.Forms.RadioButton();
		rbNhanTin = new System.Windows.Forms.RadioButton();
		label28 = new System.Windows.Forms.Label();
		D20F3324 = new System.Windows.Forms.TextBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		F928012B = new System.Windows.Forms.Label();
		D922FF3C = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D79E68A6).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = B31F2FAC;
		bunifuDragControl_0.Vertical = true;
		B31F2FAC.BackColor = System.Drawing.Color.Transparent;
		B31F2FAC.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B31F2FAC.Dock = System.Windows.Forms.DockStyle.Fill;
		B31F2FAC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B31F2FAC.ForeColor = System.Drawing.Color.Black;
		B31F2FAC.Location = new System.Drawing.Point(0, 0);
		B31F2FAC.Name = "bunifuCustomLabel1";
		B31F2FAC.Size = new System.Drawing.Size(359, 31);
		B31F2FAC.TabIndex = 12;
		B31F2FAC.Text = "Cấu hình Chúc mừng sinh nhật";
		B31F2FAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F43A8B02.Fixed = true;
		F43A8B02.Horizontal = true;
		F43A8B02.TargetControl = pnlHeader;
		F43A8B02.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(D79E68A6);
		pnlHeader.Controls.Add(B31F2FAC);
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
		D79E68A6.Cursor = System.Windows.Forms.Cursors.Default;
		D79E68A6.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		D79E68A6.Location = new System.Drawing.Point(3, 2);
		D79E68A6.Name = "pictureBox1";
		D79E68A6.Size = new System.Drawing.Size(34, 27);
		D79E68A6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		D79E68A6.TabIndex = 76;
		D79E68A6.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(rbDangBai);
		panel1.Controls.Add(rbNhanTin);
		panel1.Controls.Add(label28);
		panel1.Controls.Add(D20F3324);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(F928012B);
		panel1.Controls.Add(D922FF3C);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 408);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		rbDangBai.AutoSize = true;
		rbDangBai.Cursor = System.Windows.Forms.Cursors.Hand;
		rbDangBai.Location = new System.Drawing.Point(229, 141);
		rbDangBai.Name = "rbDangBai";
		rbDangBai.Size = new System.Drawing.Size(77, 20);
		rbDangBai.TabIndex = 91;
		rbDangBai.Text = "Đăng ba\u0300i";
		rbDangBai.UseVisualStyleBackColor = true;
		rbNhanTin.AutoSize = true;
		rbNhanTin.Checked = true;
		rbNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNhanTin.Location = new System.Drawing.Point(132, 141);
		rbNhanTin.Name = "rbNhanTin";
		rbNhanTin.Size = new System.Drawing.Size(73, 20);
		rbNhanTin.TabIndex = 90;
		rbNhanTin.TabStop = true;
		rbNhanTin.Text = "Nhă\u0301n tin";
		rbNhanTin.UseVisualStyleBackColor = true;
		label28.AutoSize = true;
		label28.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label28.Location = new System.Drawing.Point(28, 141);
		label28.Name = "label28";
		label28.Size = new System.Drawing.Size(67, 16);
		label28.TabIndex = 92;
		label28.Text = "Hi\u0300nh thư\u0301c:";
		D20F3324.Location = new System.Drawing.Point(31, 191);
		D20F3324.Multiline = true;
		D20F3324.Name = "txtContent";
		D20F3324.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		D20F3324.Size = new System.Drawing.Size(295, 138);
		D20F3324.TabIndex = 5;
		D20F3324.WordWrap = false;
		D20F3324.TextChanged += new System.EventHandler(B639E011);
		nudDelayTo.Location = new System.Drawing.Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(28, 332);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(266, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(27, 169);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(189, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch tin nhă\u0301n/ba\u0300i viê\u0301t (0):";
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
		label6.Location = new System.Drawing.Point(286, 113);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 113);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(90, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
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
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		F928012B.Location = new System.Drawing.Point(194, 82);
		F928012B.Name = "label3";
		F928012B.Size = new System.Drawing.Size(29, 16);
		F928012B.TabIndex = 37;
		F928012B.Text = "đê\u0301n";
		F928012B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D922FF3C.AutoSize = true;
		D922FF3C.Location = new System.Drawing.Point(286, 82);
		D922FF3C.Name = "label4";
		D922FF3C.Size = new System.Drawing.Size(29, 16);
		D922FF3C.TabIndex = 35;
		D922FF3C.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 82);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(89, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(185, 363);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(C9A8589C);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(78, 363);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(C4858A33);
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
		base.ClientSize = new System.Drawing.Size(362, 408);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChucMungSinhNhat";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDChucMungSinhNhat_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)D79E68A6).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
