using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDPhanHoiTinNhan : Form
{
	internal JObject jobject_0;

	internal string string_0;

	internal string string_1;

	internal string F9255A8F;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer E70C9B02 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel EF3A1A0A;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox B5AE4516;

	internal Label CDB7FE94;

	internal Label EAAAF7B6;

	internal Label label2;

	internal Label AC3CB004;

	internal Button btnCancel;

	internal Button CE2F1EB5;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel EF839515;

	internal Label label8;

	internal Label lblStatus;

	internal TextBox txtTinNhan;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudDelayFrom;

	internal Label F60671BE;

	internal Label label6;

	internal Label DB38EE04;

	internal Button button2;

	public fHDPhanHoiTinNhan(string string_2, int A90B4DB5 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		F9255A8F = string_3;
		int_0 = A90B4DB5;
		string json = "";
		switch (A90B4DB5)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDPhanHoiTinNhan");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B5AE4516.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			CE2F1EB5.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			B5AE4516.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(EF839515);
		Language.smethod_1(AC3CB004);
		Language.smethod_1(label2);
		Language.smethod_1(CDB7FE94);
		Language.smethod_1(EAAAF7B6);
		Language.smethod_1(DB38EE04);
		Language.smethod_1(F60671BE);
		Language.smethod_1(label6);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(button2);
		Language.smethod_1(CE2F1EB5);
		Language.smethod_1(btnCancel);
	}

	private void fHDPhanHoiTinNhan_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			txtTinNhan.Text = jobject_0["txtTinNhan"]!.ToString();
		}
		catch
		{
		}
	}

	private void F201593B(object sender, EventArgs e)
	{
		Close();
	}

	private void B7850F2E(object sender, EventArgs e)
	{
		string text = B5AE4516.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> f1808BA = txtTinNhan.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhă\u0301n!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("txtTinNhan", (object)txtTinNhan.Text.Trim());
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, text2))
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
			if (Class123.smethod_14(F9255A8F, text, text2))
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

	private void D2B39A8C(object sender, EventArgs e)
	{
		Close();
	}

	private void EF3A1A0A_Paint(object sender, PaintEventArgs e)
	{
		if (EF3A1A0A.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, EF3A1A0A.ClientSize.Width - num, EF3A1A0A.ClientSize.Height - num));
		}
	}

	private void B61088A1(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtTinNhan.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch tin nhă\u0301n ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người nhận!"));
	}

	protected override void Dispose(bool CF0AEE9B)
	{
		if (CF0AEE9B && E70C9B02 != null)
		{
			E70C9B02.Dispose();
		}
		base.Dispose(CF0AEE9B);
	}

	private void InitializeComponent()
	{
		E70C9B02 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDPhanHoiTinNhan));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(E70C9B02);
		EF839515 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(E70C9B02);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		EF3A1A0A = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		txtTinNhan = new System.Windows.Forms.TextBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		F60671BE = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		DB38EE04 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		B5AE4516 = new System.Windows.Forms.TextBox();
		CDB7FE94 = new System.Windows.Forms.Label();
		EAAAF7B6 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		AC3CB004 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		CE2F1EB5 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		EF3A1A0A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = EF839515;
		bunifuDragControl_0.Vertical = true;
		EF839515.BackColor = System.Drawing.Color.Transparent;
		EF839515.Cursor = System.Windows.Forms.Cursors.SizeAll;
		EF839515.Dock = System.Windows.Forms.DockStyle.Fill;
		EF839515.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EF839515.ForeColor = System.Drawing.Color.Black;
		EF839515.Location = new System.Drawing.Point(0, 0);
		EF839515.Name = "bunifuCustomLabel1";
		EF839515.Size = new System.Drawing.Size(359, 31);
		EF839515.TabIndex = 12;
		EF839515.Text = "Cấu hình Pha\u0309n hô\u0300i tin nhă\u0301n";
		EF839515.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(EF839515);
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
		button1.Click += new System.EventHandler(F201593B);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		EF3A1A0A.BackColor = System.Drawing.Color.White;
		EF3A1A0A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EF3A1A0A.Controls.Add(button2);
		EF3A1A0A.Controls.Add(txtTinNhan);
		EF3A1A0A.Controls.Add(nudDelayTo);
		EF3A1A0A.Controls.Add(label8);
		EF3A1A0A.Controls.Add(lblStatus);
		EF3A1A0A.Controls.Add(nudDelayFrom);
		EF3A1A0A.Controls.Add(F60671BE);
		EF3A1A0A.Controls.Add(label6);
		EF3A1A0A.Controls.Add(DB38EE04);
		EF3A1A0A.Controls.Add(nudSoLuongTo);
		EF3A1A0A.Controls.Add(nudSoLuongFrom);
		EF3A1A0A.Controls.Add(B5AE4516);
		EF3A1A0A.Controls.Add(CDB7FE94);
		EF3A1A0A.Controls.Add(EAAAF7B6);
		EF3A1A0A.Controls.Add(label2);
		EF3A1A0A.Controls.Add(AC3CB004);
		EF3A1A0A.Controls.Add(btnCancel);
		EF3A1A0A.Controls.Add(CE2F1EB5);
		EF3A1A0A.Controls.Add(bunifuCards1);
		EF3A1A0A.Cursor = System.Windows.Forms.Cursors.Arrow;
		EF3A1A0A.Dock = System.Windows.Forms.DockStyle.Fill;
		EF3A1A0A.Location = new System.Drawing.Point(0, 0);
		EF3A1A0A.Name = "panel1";
		EF3A1A0A.Size = new System.Drawing.Size(362, 385);
		EF3A1A0A.TabIndex = 0;
		EF3A1A0A.Paint += new System.Windows.Forms.PaintEventHandler(EF3A1A0A_Paint);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(304, 302);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(23, 23);
		button2.TabIndex = 94;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		txtTinNhan.Location = new System.Drawing.Point(31, 164);
		txtTinNhan.Multiline = true;
		txtTinNhan.Name = "txtTinNhan";
		txtTinNhan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtTinNhan.Size = new System.Drawing.Size(295, 138);
		txtTinNhan.TabIndex = 5;
		txtTinNhan.WordWrap = false;
		txtTinNhan.TextChanged += new System.EventHandler(B61088A1);
		nudDelayTo.Location = new System.Drawing.Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(28, 305);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(266, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(27, 142);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(143, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch tin nhă\u0301n (0):";
		nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		F60671BE.Location = new System.Drawing.Point(194, 113);
		F60671BE.Name = "label7";
		F60671BE.Size = new System.Drawing.Size(29, 16);
		F60671BE.TabIndex = 46;
		F60671BE.Text = "đê\u0301n";
		F60671BE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(286, 113);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		DB38EE04.AutoSize = true;
		DB38EE04.Location = new System.Drawing.Point(27, 113);
		DB38EE04.Name = "label5";
		DB38EE04.Size = new System.Drawing.Size(90, 16);
		DB38EE04.TabIndex = 44;
		DB38EE04.Text = "Thơ\u0300i gian chơ\u0300:";
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
		B5AE4516.Location = new System.Drawing.Point(132, 49);
		B5AE4516.Name = "txtTenHanhDong";
		B5AE4516.Size = new System.Drawing.Size(194, 23);
		B5AE4516.TabIndex = 0;
		CDB7FE94.Location = new System.Drawing.Point(194, 82);
		CDB7FE94.Name = "label3";
		CDB7FE94.Size = new System.Drawing.Size(29, 16);
		CDB7FE94.TabIndex = 37;
		CDB7FE94.Text = "đê\u0301n";
		CDB7FE94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		EAAAF7B6.AutoSize = true;
		EAAAF7B6.Location = new System.Drawing.Point(286, 82);
		EAAAF7B6.Name = "label4";
		EAAAF7B6.Size = new System.Drawing.Size(29, 16);
		EAAAF7B6.TabIndex = 35;
		EAAAF7B6.Text = "ba\u0323n";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 82);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(89, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		AC3CB004.AutoSize = true;
		AC3CB004.Location = new System.Drawing.Point(27, 52);
		AC3CB004.Name = "label1";
		AC3CB004.Size = new System.Drawing.Size(99, 16);
		AC3CB004.TabIndex = 31;
		AC3CB004.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(185, 336);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(D2B39A8C);
		CE2F1EB5.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		CE2F1EB5.Cursor = System.Windows.Forms.Cursors.Hand;
		CE2F1EB5.FlatAppearance.BorderSize = 0;
		CE2F1EB5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CE2F1EB5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CE2F1EB5.ForeColor = System.Drawing.Color.White;
		CE2F1EB5.Location = new System.Drawing.Point(78, 336);
		CE2F1EB5.Name = "btnAdd";
		CE2F1EB5.Size = new System.Drawing.Size(92, 29);
		CE2F1EB5.TabIndex = 6;
		CE2F1EB5.Text = "Thêm";
		CE2F1EB5.UseVisualStyleBackColor = false;
		CE2F1EB5.Click += new System.EventHandler(B7850F2E);
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
		base.ClientSize = new System.Drawing.Size(362, 385);
		base.Controls.Add(EF3A1A0A);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDPhanHoiTinNhan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDPhanHoiTinNhan_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		EF3A1A0A.ResumeLayout(false);
		EF3A1A0A.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
