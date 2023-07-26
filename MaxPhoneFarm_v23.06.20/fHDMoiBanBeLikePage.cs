using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDMoiBanBeLikePage : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string B622B19D;

	internal string A290D730;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl D827BE0E;

	internal Panel E18B7F29;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox DE968C32;

	internal Label D3175802;

	internal Label label4;

	internal Label AA95AF20;

	internal Label label1;

	internal Button btnCancel;

	internal Button EC86EC10;

	internal BunifuCards AC3C83AE;

	internal Panel C0A443BE;

	internal Button E3BF1729;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Label label8;

	internal Label C92DE629;

	internal RichTextBox ADBB0080;

	internal ToolTip D88BC61D;

	public fHDMoiBanBeLikePage(string EB16E115, int int_1 = 0, string A198C730 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = EB16E115;
		A290D730 = A198C730;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Mơ\u0300i ba\u0323n be\u0300 like page";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			B622B19D = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			DE968C32.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(A198C730);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			EC86EC10.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			DE968C32.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void DE9EB7A8()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(AA95AF20);
		Language.smethod_1(D3175802);
		Language.smethod_1(label4);
		Language.smethod_1(C92DE629);
		Language.smethod_1(label8);
		Language.smethod_1(EC86EC10);
		Language.smethod_1(btnCancel);
	}

	private void fHDMoiBanBeLikePage_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 5);
			nudSoLuongTo.Value = f72FAFBC_0.method_0("nudSoLuongTo", 5);
			ADBB0080.Text = f72FAFBC_0.GetValue("txtUid");
		}
		catch
		{
		}
	}

	private void BA825C31(object sender, EventArgs e)
	{
		Close();
	}

	private void BD938EA4(object sender, EventArgs e)
	{
		string text = DE968C32.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		List<string> f1808BA = ADBB0080.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		if (f1808BA.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sách uid nhóm!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("txtUid", (object)ADBB0080.Text.Trim());
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, B622B19D, text2))
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
			if (Class123.smethod_14(A290D730, text, text2))
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

	private void E18B7F29_Paint(object sender, PaintEventArgs e)
	{
		if (E18B7F29.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, E18B7F29.ClientSize.Width - num, E18B7F29.ClientSize.Height - num));
		}
	}

	private void D6A1D128(object sender, EventArgs e)
	{
		Common.D936DD84(ADBB0080, C92DE629);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDMoiBanBeLikePage));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D827BE0E = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		C0A443BE = new System.Windows.Forms.Panel();
		E3BF1729 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		E18B7F29 = new System.Windows.Forms.Panel();
		ADBB0080 = new System.Windows.Forms.RichTextBox();
		label8 = new System.Windows.Forms.Label();
		C92DE629 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		DE968C32 = new System.Windows.Forms.TextBox();
		D3175802 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		AA95AF20 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		EC86EC10 = new System.Windows.Forms.Button();
		AC3C83AE = new Bunifu.Framework.UI.BunifuCards();
		D88BC61D = new System.Windows.Forms.ToolTip(icontainer_0);
		C0A443BE.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		E18B7F29.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		AC3C83AE.SuspendLayout();
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
		bunifuCustomLabel1.Text = "Cấu hình Mời bạn bè like page";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D827BE0E.Fixed = true;
		D827BE0E.Horizontal = true;
		D827BE0E.TargetControl = C0A443BE;
		D827BE0E.Vertical = true;
		C0A443BE.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C0A443BE.BackColor = System.Drawing.Color.White;
		C0A443BE.Controls.Add(E3BF1729);
		C0A443BE.Controls.Add(pictureBox1);
		C0A443BE.Controls.Add(bunifuCustomLabel1);
		C0A443BE.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C0A443BE.Location = new System.Drawing.Point(0, 3);
		C0A443BE.Name = "pnlHeader";
		C0A443BE.Size = new System.Drawing.Size(359, 31);
		C0A443BE.TabIndex = 9;
		E3BF1729.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		E3BF1729.Cursor = System.Windows.Forms.Cursors.Hand;
		E3BF1729.FlatAppearance.BorderSize = 0;
		E3BF1729.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E3BF1729.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E3BF1729.ForeColor = System.Drawing.Color.White;
		E3BF1729.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		E3BF1729.Location = new System.Drawing.Point(328, 1);
		E3BF1729.Name = "button1";
		E3BF1729.Size = new System.Drawing.Size(30, 30);
		E3BF1729.TabIndex = 77;
		E3BF1729.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		E3BF1729.UseVisualStyleBackColor = true;
		E3BF1729.Click += new System.EventHandler(BA825C31);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		E18B7F29.BackColor = System.Drawing.Color.White;
		E18B7F29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E18B7F29.Controls.Add(ADBB0080);
		E18B7F29.Controls.Add(label8);
		E18B7F29.Controls.Add(C92DE629);
		E18B7F29.Controls.Add(nudSoLuongTo);
		E18B7F29.Controls.Add(nudSoLuongFrom);
		E18B7F29.Controls.Add(DE968C32);
		E18B7F29.Controls.Add(D3175802);
		E18B7F29.Controls.Add(label4);
		E18B7F29.Controls.Add(AA95AF20);
		E18B7F29.Controls.Add(label1);
		E18B7F29.Controls.Add(btnCancel);
		E18B7F29.Controls.Add(EC86EC10);
		E18B7F29.Controls.Add(AC3C83AE);
		E18B7F29.Cursor = System.Windows.Forms.Cursors.Arrow;
		E18B7F29.Dock = System.Windows.Forms.DockStyle.Fill;
		E18B7F29.Location = new System.Drawing.Point(0, 0);
		E18B7F29.Name = "panel1";
		E18B7F29.Size = new System.Drawing.Size(362, 371);
		E18B7F29.TabIndex = 0;
		E18B7F29.Paint += new System.Windows.Forms.PaintEventHandler(E18B7F29_Paint);
		ADBB0080.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		ADBB0080.Location = new System.Drawing.Point(31, 126);
		ADBB0080.Name = "txtUid";
		ADBB0080.Size = new System.Drawing.Size(295, 167);
		ADBB0080.TabIndex = 114;
		ADBB0080.Text = "";
		ADBB0080.WordWrap = false;
		ADBB0080.TextChanged += new System.EventHandler(D6A1D128);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(28, 296);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(129, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi ID Page 1 dòng)";
		C92DE629.AutoSize = true;
		C92DE629.Location = new System.Drawing.Point(27, 106);
		C92DE629.Name = "lblStatus";
		C92DE629.Size = new System.Drawing.Size(196, 16);
		C92DE629.TabIndex = 0;
		C92DE629.Text = "Danh sa\u0301ch Uid page cần mơ\u0300i (0):";
		nudSoLuongTo.Location = new System.Drawing.Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		DE968C32.Location = new System.Drawing.Point(132, 49);
		DE968C32.Name = "txtTenHanhDong";
		DE968C32.Size = new System.Drawing.Size(194, 23);
		DE968C32.TabIndex = 0;
		D3175802.Location = new System.Drawing.Point(194, 80);
		D3175802.Name = "label3";
		D3175802.Size = new System.Drawing.Size(29, 16);
		D3175802.TabIndex = 37;
		D3175802.Text = "đê\u0301n";
		D3175802.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(287, 80);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(29, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		AA95AF20.AutoSize = true;
		AA95AF20.Location = new System.Drawing.Point(27, 80);
		AA95AF20.Name = "label2";
		AA95AF20.Size = new System.Drawing.Size(89, 16);
		AA95AF20.TabIndex = 32;
		AA95AF20.Text = "Sô\u0301 lươ\u0323ng mơ\u0300i:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(193, 329);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		EC86EC10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		EC86EC10.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		EC86EC10.Cursor = System.Windows.Forms.Cursors.Hand;
		EC86EC10.FlatAppearance.BorderSize = 0;
		EC86EC10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EC86EC10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EC86EC10.ForeColor = System.Drawing.Color.White;
		EC86EC10.Location = new System.Drawing.Point(82, 329);
		EC86EC10.Name = "btnAdd";
		EC86EC10.Size = new System.Drawing.Size(92, 29);
		EC86EC10.TabIndex = 6;
		EC86EC10.Text = "Thêm";
		EC86EC10.UseVisualStyleBackColor = false;
		EC86EC10.Click += new System.EventHandler(BD938EA4);
		AC3C83AE.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		AC3C83AE.BackColor = System.Drawing.Color.White;
		AC3C83AE.BorderRadius = 0;
		AC3C83AE.BottomSahddow = true;
		AC3C83AE.color = System.Drawing.Color.DarkViolet;
		AC3C83AE.Controls.Add(C0A443BE);
		AC3C83AE.LeftSahddow = false;
		AC3C83AE.Location = new System.Drawing.Point(1, 0);
		AC3C83AE.Name = "bunifuCards1";
		AC3C83AE.RightSahddow = true;
		AC3C83AE.ShadowDepth = 20;
		AC3C83AE.Size = new System.Drawing.Size(359, 37);
		AC3C83AE.TabIndex = 28;
		D88BC61D.AutomaticDelay = 0;
		D88BC61D.AutoPopDelay = 0;
		D88BC61D.InitialDelay = 0;
		D88BC61D.ReshowDelay = 0;
		D88BC61D.ShowAlways = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 371);
		base.Controls.Add(E18B7F29);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDMoiBanBeLikePage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDMoiBanBeLikePage_Load);
		C0A443BE.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		E18B7F29.ResumeLayout(false);
		E18B7F29.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		AC3C83AE.ResumeLayout(false);
		ResumeLayout(false);
	}
}
