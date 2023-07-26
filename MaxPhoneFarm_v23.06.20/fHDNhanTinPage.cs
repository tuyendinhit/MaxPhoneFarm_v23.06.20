using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDNhanTinPage : Form
{
	internal JObject F0A3EFA5;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int int_0;

	internal static bool DD2AA603;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl F306CA33;

	internal Panel FAA3B29F;

	internal NumericUpDown D414E633;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox FF98F98A;

	internal Label label3;

	internal Label E5BBEC05;

	internal Label F116AD95;

	internal Label E82A2B22;

	internal Button D3B6098B;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox FD903EB7;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label label8;

	internal Label lblStatus;

	internal TextBox DFBC6C29;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudDelayFrom;

	internal Label AE970CAA;

	internal Label label6;

	internal Label E6A87605;

	internal TextBox txtIdPage;

	internal Label D8170EBA;

	public fHDNhanTinPage(string string_3, int int_1 = 0, string A308C91B = "")
	{
		InitializeComponent();
		DD2AA603 = false;
		string_0 = string_3;
		string_2 = A308C91B;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDNhanTinPage");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			FF98F98A.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(A308C91B);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			FF98F98A.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F0A3EFA5 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(E82A2B22);
		Language.smethod_1(F116AD95);
		Language.smethod_1(label3);
		Language.smethod_1(E5BBEC05);
		Language.smethod_1(E6A87605);
		Language.smethod_1(AE970CAA);
		Language.smethod_1(label6);
		Language.smethod_1(D8170EBA);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label8);
		Language.smethod_1(btnAdd);
		Language.smethod_1(D3B6098B);
	}

	private void E6BBFF01(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(F0A3EFA5["nudSoLuongFrom"]);
			D414E633.Value = Convert.ToInt32(F0A3EFA5["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(F0A3EFA5["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(F0A3EFA5["nudDelayTo"]);
			txtIdPage.Text = F0A3EFA5["txtIdPage"]!.ToString();
			DFBC6C29.Text = F0A3EFA5["txtTinNhan"]!.ToString();
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = FF98F98A.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> f1808BA = txtIdPage.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch ID Page!"), 3);
			return;
		}
		f1808BA = DFBC6C29.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung tin nhă\u0301n!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", D414E633.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("txtIdPage", (object)txtIdPage.Text.Trim());
		f72FAFBC.GetValue("txtTinNhan", (object)DFBC6C29.Text.Trim());
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, d9253C2E))
				{
					DD2AA603 = true;
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
				DD2AA603 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void D0A5F48F(object sender, EventArgs e)
	{
		Close();
	}

	private void C3B61200(object sender, PaintEventArgs e)
	{
		if (FAA3B29F.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, FAA3B29F.ClientSize.Width - num, FAA3B29F.ClientSize.Height - num));
		}
	}

	private void DFBC6C29_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = DFBC6C29.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch tin nhă\u0301n ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void A792009E(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtIdPage.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			D8170EBA.Text = string.Format(Language.GetValue("Danh sa\u0301ch ID Page ({0}):"), f1808BA.Count.ToString());
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDNhanTinPage));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		F306CA33 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		FD903EB7 = new System.Windows.Forms.PictureBox();
		FAA3B29F = new System.Windows.Forms.Panel();
		DFBC6C29 = new System.Windows.Forms.TextBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		AE970CAA = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		E6A87605 = new System.Windows.Forms.Label();
		D414E633 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		FF98F98A = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		E5BBEC05 = new System.Windows.Forms.Label();
		F116AD95 = new System.Windows.Forms.Label();
		E82A2B22 = new System.Windows.Forms.Label();
		D3B6098B = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		D8170EBA = new System.Windows.Forms.Label();
		txtIdPage = new System.Windows.Forms.TextBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FD903EB7).BeginInit();
		FAA3B29F.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)D414E633).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Nhă\u0301n tin page";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F306CA33.Fixed = true;
		F306CA33.Horizontal = true;
		F306CA33.TargetControl = pnlHeader;
		F306CA33.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(FD903EB7);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
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
		FD903EB7.Cursor = System.Windows.Forms.Cursors.Default;
		FD903EB7.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		FD903EB7.Location = new System.Drawing.Point(3, 2);
		FD903EB7.Name = "pictureBox1";
		FD903EB7.Size = new System.Drawing.Size(34, 27);
		FD903EB7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		FD903EB7.TabIndex = 76;
		FD903EB7.TabStop = false;
		FAA3B29F.BackColor = System.Drawing.Color.White;
		FAA3B29F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FAA3B29F.Controls.Add(txtIdPage);
		FAA3B29F.Controls.Add(DFBC6C29);
		FAA3B29F.Controls.Add(nudDelayTo);
		FAA3B29F.Controls.Add(label8);
		FAA3B29F.Controls.Add(D8170EBA);
		FAA3B29F.Controls.Add(lblStatus);
		FAA3B29F.Controls.Add(nudDelayFrom);
		FAA3B29F.Controls.Add(AE970CAA);
		FAA3B29F.Controls.Add(label6);
		FAA3B29F.Controls.Add(E6A87605);
		FAA3B29F.Controls.Add(D414E633);
		FAA3B29F.Controls.Add(nudSoLuongFrom);
		FAA3B29F.Controls.Add(FF98F98A);
		FAA3B29F.Controls.Add(label3);
		FAA3B29F.Controls.Add(E5BBEC05);
		FAA3B29F.Controls.Add(F116AD95);
		FAA3B29F.Controls.Add(E82A2B22);
		FAA3B29F.Controls.Add(D3B6098B);
		FAA3B29F.Controls.Add(btnAdd);
		FAA3B29F.Controls.Add(bunifuCards1);
		FAA3B29F.Cursor = System.Windows.Forms.Cursors.Arrow;
		FAA3B29F.Dock = System.Windows.Forms.DockStyle.Fill;
		FAA3B29F.Location = new System.Drawing.Point(0, 0);
		FAA3B29F.Name = "panel1";
		FAA3B29F.Size = new System.Drawing.Size(362, 500);
		FAA3B29F.TabIndex = 0;
		FAA3B29F.Paint += new System.Windows.Forms.PaintEventHandler(C3B61200);
		DFBC6C29.Location = new System.Drawing.Point(31, 286);
		DFBC6C29.Multiline = true;
		DFBC6C29.Name = "txtTinNhan";
		DFBC6C29.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		DFBC6C29.Size = new System.Drawing.Size(295, 138);
		DFBC6C29.TabIndex = 5;
		DFBC6C29.WordWrap = false;
		DFBC6C29.TextChanged += new System.EventHandler(DFBC6C29_TextChanged);
		nudDelayTo.Location = new System.Drawing.Point(229, 111);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(28, 427);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(266, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(27, 264);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(143, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch tin nhă\u0301n (0):";
		nudDelayFrom.Location = new System.Drawing.Point(132, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		AE970CAA.AutoSize = true;
		AE970CAA.Location = new System.Drawing.Point(194, 113);
		AE970CAA.Name = "label7";
		AE970CAA.Size = new System.Drawing.Size(29, 16);
		AE970CAA.TabIndex = 46;
		AE970CAA.Text = "đê\u0301n";
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(290, 113);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		E6A87605.AutoSize = true;
		E6A87605.Location = new System.Drawing.Point(27, 113);
		E6A87605.Name = "label5";
		E6A87605.Size = new System.Drawing.Size(90, 16);
		E6A87605.TabIndex = 44;
		E6A87605.Text = "Thơ\u0300i gian chơ\u0300:";
		D414E633.Location = new System.Drawing.Point(229, 80);
		D414E633.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D414E633.Name = "nudSoLuongTo";
		D414E633.Size = new System.Drawing.Size(56, 23);
		D414E633.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 80);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		FF98F98A.Location = new System.Drawing.Point(132, 49);
		FF98F98A.Name = "txtTenHanhDong";
		FF98F98A.Size = new System.Drawing.Size(194, 23);
		FF98F98A.TabIndex = 0;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(194, 82);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		E5BBEC05.AutoSize = true;
		E5BBEC05.Location = new System.Drawing.Point(290, 82);
		E5BBEC05.Name = "label4";
		E5BBEC05.Size = new System.Drawing.Size(29, 16);
		E5BBEC05.TabIndex = 35;
		E5BBEC05.Text = "ba\u0323n";
		F116AD95.AutoSize = true;
		F116AD95.Location = new System.Drawing.Point(27, 82);
		F116AD95.Name = "label2";
		F116AD95.Size = new System.Drawing.Size(96, 16);
		F116AD95.TabIndex = 32;
		F116AD95.Text = "Sô\u0301 lươ\u0323ng page:";
		E82A2B22.AutoSize = true;
		E82A2B22.Location = new System.Drawing.Point(27, 52);
		E82A2B22.Name = "label1";
		E82A2B22.Size = new System.Drawing.Size(99, 16);
		E82A2B22.TabIndex = 31;
		E82A2B22.Text = "Tên ha\u0300nh đô\u0323ng:";
		D3B6098B.BackColor = System.Drawing.Color.Maroon;
		D3B6098B.Cursor = System.Windows.Forms.Cursors.Hand;
		D3B6098B.FlatAppearance.BorderSize = 0;
		D3B6098B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D3B6098B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D3B6098B.ForeColor = System.Drawing.Color.White;
		D3B6098B.Location = new System.Drawing.Point(185, 456);
		D3B6098B.Name = "btnCancel";
		D3B6098B.Size = new System.Drawing.Size(92, 29);
		D3B6098B.TabIndex = 7;
		D3B6098B.Text = "Đóng";
		D3B6098B.UseVisualStyleBackColor = false;
		D3B6098B.Click += new System.EventHandler(D0A5F48F);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(78, 456);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
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
		D8170EBA.AutoSize = true;
		D8170EBA.Location = new System.Drawing.Point(28, 139);
		D8170EBA.Name = "lblStatusPage";
		D8170EBA.Size = new System.Drawing.Size(141, 16);
		D8170EBA.TabIndex = 0;
		D8170EBA.Text = "Danh sa\u0301ch ID Page (0):";
		txtIdPage.Location = new System.Drawing.Point(32, 161);
		txtIdPage.Multiline = true;
		txtIdPage.Name = "txtIdPage";
		txtIdPage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtIdPage.Size = new System.Drawing.Size(295, 98);
		txtIdPage.TabIndex = 5;
		txtIdPage.WordWrap = false;
		txtIdPage.TextChanged += new System.EventHandler(A792009E);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 500);
		base.Controls.Add(FAA3B29F);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDNhanTinPage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(E6BBFF01);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)FD903EB7).EndInit();
		FAA3B29F.ResumeLayout(false);
		FAA3B29F.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)D414E633).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
