using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXoaReel : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string BC180AA5;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl D22D6583;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal TextBox CFACF9B5;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox F12BFC1F;

	internal BunifuCustomLabel D7967B86;

	internal Label label19;

	internal Label label20;

	internal NumericUpDown nudKhoangCachTo;

	internal NumericUpDown nudKhoangCachFrom;

	internal Label label18;

	internal Label B39BD82A;

	internal NumericUpDown D53CA000;

	internal NumericUpDown nudSoLuongFrom;

	internal Label label16;

	internal Label label15;

	public fHDXoaReel(string E31B7426, int A187B40E = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		BC180AA5 = E31B7426;
		string_1 = string_2;
		int_0 = A187B40E;
		string text = base.Name.Substring(1);
		string text2 = "Xóa Reel";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (A187B40E)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			CFACF9B5.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			CFACF9B5.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void DF297430(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = f72FAFBC_0.method_0("nudSoLuongFrom", 1);
			D53CA000.Value = f72FAFBC_0.method_0("nudSoLuongTo", 1);
			nudKhoangCachFrom.Value = f72FAFBC_0.method_0("nudKhoangCachFrom", 5);
			nudKhoangCachTo.Value = f72FAFBC_0.method_0("nudKhoangCachTo", 10);
		}
		catch (Exception)
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AD121639(object sender, EventArgs e)
	{
		string text = CFACF9B5.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", D53CA000.Value);
		f72FAFBC.GetValue("nudKhoangCachFrom", nudKhoangCachFrom.Value);
		f72FAFBC.GetValue("nudKhoangCachTo", nudKhoangCachTo.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(BC180AA5, text, string_0, text2))
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

	private void F12BFC1F_Click(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXoaReel));
		D22D6583 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D7967B86 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		F12BFC1F = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		label19 = new System.Windows.Forms.Label();
		label20 = new System.Windows.Forms.Label();
		nudKhoangCachTo = new System.Windows.Forms.NumericUpDown();
		nudKhoangCachFrom = new System.Windows.Forms.NumericUpDown();
		label18 = new System.Windows.Forms.Label();
		B39BD82A = new System.Windows.Forms.Label();
		D53CA000 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		label16 = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		btnAdd = new System.Windows.Forms.Button();
		CFACF9B5 = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F12BFC1F).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)D53CA000).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D22D6583.Fixed = true;
		D22D6583.Horizontal = true;
		D22D6583.TargetControl = D7967B86;
		D22D6583.Vertical = true;
		D7967B86.BackColor = System.Drawing.Color.Transparent;
		D7967B86.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D7967B86.Dock = System.Windows.Forms.DockStyle.Fill;
		D7967B86.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D7967B86.ForeColor = System.Drawing.Color.Black;
		D7967B86.Location = new System.Drawing.Point(0, 0);
		D7967B86.Name = "bunifuCustomLabel1";
		D7967B86.Size = new System.Drawing.Size(341, 31);
		D7967B86.TabIndex = 12;
		D7967B86.Text = "Cấu hình Xóa Reel";
		D7967B86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(F12BFC1F);
		pnlHeader.Controls.Add(D7967B86);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(341, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(310, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 0;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		F12BFC1F.Cursor = System.Windows.Forms.Cursors.Default;
		F12BFC1F.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		F12BFC1F.Location = new System.Drawing.Point(3, 2);
		F12BFC1F.Name = "pictureBox1";
		F12BFC1F.Size = new System.Drawing.Size(34, 27);
		F12BFC1F.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		F12BFC1F.TabIndex = 76;
		F12BFC1F.TabStop = false;
		F12BFC1F.Click += new System.EventHandler(F12BFC1F_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(label19);
		panel1.Controls.Add(label20);
		panel1.Controls.Add(nudKhoangCachTo);
		panel1.Controls.Add(nudKhoangCachFrom);
		panel1.Controls.Add(label18);
		panel1.Controls.Add(B39BD82A);
		panel1.Controls.Add(D53CA000);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(label16);
		panel1.Controls.Add(label15);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(CFACF9B5);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(344, 189);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		label19.AutoSize = true;
		label19.Location = new System.Drawing.Point(274, 109);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(30, 16);
		label19.TabIndex = 43;
		label19.Text = "giây";
		label20.Location = new System.Drawing.Point(188, 109);
		label20.Name = "label20";
		label20.Size = new System.Drawing.Size(29, 16);
		label20.TabIndex = 42;
		label20.Text = "đến";
		label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudKhoangCachTo.Location = new System.Drawing.Point(219, 107);
		nudKhoangCachTo.Name = "nudKhoangCachTo";
		nudKhoangCachTo.Size = new System.Drawing.Size(51, 23);
		nudKhoangCachTo.TabIndex = 41;
		nudKhoangCachFrom.Location = new System.Drawing.Point(134, 107);
		nudKhoangCachFrom.Name = "nudKhoangCachFrom";
		nudKhoangCachFrom.Size = new System.Drawing.Size(51, 23);
		nudKhoangCachFrom.TabIndex = 40;
		label18.AutoSize = true;
		label18.Location = new System.Drawing.Point(274, 83);
		label18.Name = "label18";
		label18.Size = new System.Drawing.Size(29, 16);
		label18.TabIndex = 39;
		label18.Text = "reel";
		B39BD82A.Location = new System.Drawing.Point(188, 83);
		B39BD82A.Name = "label17";
		B39BD82A.Size = new System.Drawing.Size(29, 16);
		B39BD82A.TabIndex = 38;
		B39BD82A.Text = "đến";
		B39BD82A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D53CA000.Location = new System.Drawing.Point(219, 78);
		D53CA000.Name = "nudSoLuongTo";
		D53CA000.Size = new System.Drawing.Size(51, 23);
		D53CA000.TabIndex = 37;
		nudSoLuongFrom.Location = new System.Drawing.Point(134, 78);
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(51, 23);
		nudSoLuongFrom.TabIndex = 36;
		label16.AutoSize = true;
		label16.Location = new System.Drawing.Point(30, 109);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(72, 16);
		label16.TabIndex = 35;
		label16.Text = "Delay time:";
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(30, 80);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(89, 16);
		label15.TabIndex = 34;
		label15.Text = "Số lượng reel:";
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(76, 148);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(AD121639);
		CFACF9B5.Location = new System.Drawing.Point(134, 49);
		CFACF9B5.Name = "txtTenHanhDong";
		CFACF9B5.Size = new System.Drawing.Size(174, 23);
		CFACF9B5.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(30, 52);
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
		btnCancel.Location = new System.Drawing.Point(175, 148);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(341, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(344, 189);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXoaReel";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(DF297430);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)F12BFC1F).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)D53CA000).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
