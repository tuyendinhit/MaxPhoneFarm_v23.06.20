using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDKetBanThanhVienNhom : Form
{
	internal JObject BE1DB31A;

	internal string A0B12EA4;

	internal string string_0;

	internal string string_1;

	internal int EB30543C;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl ED192128;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal NumericUpDown F131A4B6;

	internal NumericUpDown D8BD9DA0;

	internal TextBox txtTenHanhDong;

	internal Label label3;

	internal Label label4;

	internal Label E6A4D039;

	internal Label label1;

	internal Button D989A908;

	internal Button E926F100;

	internal BunifuCards A4209DB9;

	internal Panel pnlHeader;

	internal Button EF8D0196;

	internal PictureBox A43590A6;

	internal BunifuCustomLabel CB05DE24;

	internal Label A2B64D2A;

	internal Label BE97E782;

	internal NumericUpDown C415DF3E;

	internal NumericUpDown nudDelayFrom;

	internal Label label7;

	internal Label label6;

	internal Label label5;

	internal RichTextBox txtUid;

	internal ToolTip toolTip_0;

	public fHDKetBanThanhVienNhom(string string_2, int int_0 = 0, string CA3FB607 = "")
	{
		InitializeComponent();
		bool_0 = false;
		A0B12EA4 = string_2;
		string_1 = CA3FB607;
		EB30543C = int_0;
		string json = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDKetBanThanhVienNhom");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(CA3FB607);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			E926F100.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		BE1DB31A = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(CB05DE24);
		Language.smethod_1(label1);
		Language.smethod_1(E6A4D039);
		Language.smethod_1(label3);
		Language.smethod_1(label4);
		Language.smethod_1(label5);
		Language.smethod_1(label7);
		Language.smethod_1(label6);
		Language.smethod_1(BE97E782);
		Language.smethod_1(A2B64D2A);
		Language.smethod_1(E926F100);
		Language.smethod_1(D989A908);
	}

	private void AE9EAD02(object sender, EventArgs e)
	{
		try
		{
			D8BD9DA0.Value = Convert.ToInt32(BE1DB31A["nudSoLuongFrom"]);
			F131A4B6.Value = Convert.ToInt32(BE1DB31A["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(BE1DB31A["nudDelayFrom"]);
			C415DF3E.Value = Convert.ToInt32(BE1DB31A["nudDelayTo"]);
			txtUid.Text = BE1DB31A["txtUid"]!.ToString();
		}
		catch
		{
		}
	}

	private void EF8D0196_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E926F100_Click(object sender, EventArgs e)
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
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", D8BD9DA0.Value);
		f72FAFBC.GetValue("nudSoLuongTo", F131A4B6.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", C415DF3E.Value);
		f72FAFBC.GetValue("txtUid", (object)txtUid.Text.Trim());
		string text2 = f72FAFBC.C71A4EA4();
		if (EB30543C == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(A0B12EA4, text, string_0, text2))
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

	private void D989A908_Click(object sender, EventArgs e)
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

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUid.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			BE97E782.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid nhóm ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKetBanThanhVienNhom));
		ED192128 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		CB05DE24 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		EF8D0196 = new System.Windows.Forms.Button();
		A43590A6 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		txtUid = new System.Windows.Forms.RichTextBox();
		C415DF3E = new System.Windows.Forms.NumericUpDown();
		A2B64D2A = new System.Windows.Forms.Label();
		BE97E782 = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		F131A4B6 = new System.Windows.Forms.NumericUpDown();
		D8BD9DA0 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		E6A4D039 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		D989A908 = new System.Windows.Forms.Button();
		E926F100 = new System.Windows.Forms.Button();
		A4209DB9 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A43590A6).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C415DF3E).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)F131A4B6).BeginInit();
		((System.ComponentModel.ISupportInitialize)D8BD9DA0).BeginInit();
		A4209DB9.SuspendLayout();
		SuspendLayout();
		ED192128.Fixed = true;
		ED192128.Horizontal = true;
		ED192128.TargetControl = CB05DE24;
		ED192128.Vertical = true;
		CB05DE24.BackColor = System.Drawing.Color.Transparent;
		CB05DE24.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CB05DE24.Dock = System.Windows.Forms.DockStyle.Fill;
		CB05DE24.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CB05DE24.ForeColor = System.Drawing.Color.Black;
		CB05DE24.Location = new System.Drawing.Point(0, 0);
		CB05DE24.Name = "bunifuCustomLabel1";
		CB05DE24.Size = new System.Drawing.Size(359, 31);
		CB05DE24.TabIndex = 12;
		CB05DE24.Text = "Cấu hình Kết bạn thành viên nhóm";
		CB05DE24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(EF8D0196);
		pnlHeader.Controls.Add(A43590A6);
		pnlHeader.Controls.Add(CB05DE24);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		EF8D0196.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		EF8D0196.Cursor = System.Windows.Forms.Cursors.Hand;
		EF8D0196.FlatAppearance.BorderSize = 0;
		EF8D0196.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EF8D0196.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EF8D0196.ForeColor = System.Drawing.Color.White;
		EF8D0196.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		EF8D0196.Location = new System.Drawing.Point(328, 1);
		EF8D0196.Name = "button1";
		EF8D0196.Size = new System.Drawing.Size(30, 30);
		EF8D0196.TabIndex = 77;
		EF8D0196.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		EF8D0196.UseVisualStyleBackColor = true;
		EF8D0196.Click += new System.EventHandler(EF8D0196_Click);
		A43590A6.Cursor = System.Windows.Forms.Cursors.Default;
		A43590A6.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		A43590A6.Location = new System.Drawing.Point(3, 2);
		A43590A6.Name = "pictureBox1";
		A43590A6.Size = new System.Drawing.Size(34, 27);
		A43590A6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A43590A6.TabIndex = 76;
		A43590A6.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(C415DF3E);
		panel1.Controls.Add(A2B64D2A);
		panel1.Controls.Add(BE97E782);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(F131A4B6);
		panel1.Controls.Add(D8BD9DA0);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(E6A4D039);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(D989A908);
		panel1.Controls.Add(E926F100);
		panel1.Controls.Add(A4209DB9);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 374);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(31, 159);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(295, 136);
		txtUid.TabIndex = 114;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		C415DF3E.Location = new System.Drawing.Point(229, 111);
		C415DF3E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C415DF3E.Name = "nudDelayTo";
		C415DF3E.Size = new System.Drawing.Size(56, 23);
		C415DF3E.TabIndex = 4;
		A2B64D2A.AutoSize = true;
		A2B64D2A.Location = new System.Drawing.Point(28, 298);
		A2B64D2A.Name = "label8";
		A2B64D2A.Size = new System.Drawing.Size(103, 16);
		A2B64D2A.TabIndex = 0;
		A2B64D2A.Text = "(Mỗi Uid 1 dòng)";
		BE97E782.AutoSize = true;
		BE97E782.Location = new System.Drawing.Point(27, 139);
		BE97E782.Name = "lblStatus";
		BE97E782.Size = new System.Drawing.Size(151, 16);
		BE97E782.TabIndex = 0;
		BE97E782.Text = "Danh sa\u0301ch Uid nhóm (0):";
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
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 113);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(90, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		F131A4B6.Location = new System.Drawing.Point(229, 80);
		F131A4B6.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F131A4B6.Name = "nudSoLuongTo";
		F131A4B6.Size = new System.Drawing.Size(56, 23);
		F131A4B6.TabIndex = 2;
		D8BD9DA0.Location = new System.Drawing.Point(132, 80);
		D8BD9DA0.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D8BD9DA0.Name = "nudSoLuongFrom";
		D8BD9DA0.Size = new System.Drawing.Size(56, 23);
		D8BD9DA0.TabIndex = 1;
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
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(287, 82);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		E6A4D039.AutoSize = true;
		E6A4D039.Location = new System.Drawing.Point(27, 82);
		E6A4D039.Name = "label2";
		E6A4D039.Size = new System.Drawing.Size(89, 16);
		E6A4D039.TabIndex = 32;
		E6A4D039.Text = "Sô\u0301 lươ\u0323ng ba\u0323n:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		D989A908.BackColor = System.Drawing.Color.Maroon;
		D989A908.Cursor = System.Windows.Forms.Cursors.Hand;
		D989A908.FlatAppearance.BorderSize = 0;
		D989A908.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D989A908.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D989A908.ForeColor = System.Drawing.Color.White;
		D989A908.Location = new System.Drawing.Point(190, 328);
		D989A908.Name = "btnCancel";
		D989A908.Size = new System.Drawing.Size(92, 29);
		D989A908.TabIndex = 7;
		D989A908.Text = "Đóng";
		D989A908.UseVisualStyleBackColor = false;
		D989A908.Click += new System.EventHandler(D989A908_Click);
		E926F100.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		E926F100.Cursor = System.Windows.Forms.Cursors.Hand;
		E926F100.FlatAppearance.BorderSize = 0;
		E926F100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E926F100.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E926F100.ForeColor = System.Drawing.Color.White;
		E926F100.Location = new System.Drawing.Point(83, 328);
		E926F100.Name = "btnAdd";
		E926F100.Size = new System.Drawing.Size(92, 29);
		E926F100.TabIndex = 6;
		E926F100.Text = "Thêm";
		E926F100.UseVisualStyleBackColor = false;
		E926F100.Click += new System.EventHandler(E926F100_Click);
		A4209DB9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A4209DB9.BackColor = System.Drawing.Color.White;
		A4209DB9.BorderRadius = 0;
		A4209DB9.BottomSahddow = true;
		A4209DB9.color = System.Drawing.Color.DarkViolet;
		A4209DB9.Controls.Add(pnlHeader);
		A4209DB9.LeftSahddow = false;
		A4209DB9.Location = new System.Drawing.Point(1, 0);
		A4209DB9.Name = "bunifuCards1";
		A4209DB9.RightSahddow = true;
		A4209DB9.ShadowDepth = 20;
		A4209DB9.Size = new System.Drawing.Size(359, 37);
		A4209DB9.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 374);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKetBanThanhVienNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(AE9EAD02);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A43590A6).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C415DF3E).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)F131A4B6).EndInit();
		((System.ComponentModel.ISupportInitialize)D8BD9DA0).EndInit();
		A4209DB9.ResumeLayout(false);
		ResumeLayout(false);
	}
}
