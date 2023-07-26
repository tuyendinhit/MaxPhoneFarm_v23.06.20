using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDocThongBao : Form
{
	internal JSON_Settings FE1D6F13;

	internal string FF32A194;

	internal string AA836626;

	internal string AA84873A;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown A9106229;

	internal NumericUpDown nudDelayFrom;

	internal NumericUpDown C4079507;

	internal TextBox txtTenHanhDong;

	internal Label label7;

	internal Label label3;

	internal Label label5;

	internal Label label2;

	internal Label label1;

	internal Button D0A6651D;

	internal Button D78D4C29;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button DE80B53A;

	internal PictureBox E62B6A03;

	internal BunifuCustomLabel DA066E1B;

	internal CheckBox E221A186;

	public fHDDocThongBao(string string_0, int C59DCEBE = 0, string FFADD5B2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		FF32A194 = string_0;
		AA84873A = FFADD5B2;
		int_0 = C59DCEBE;
		string d399C = "";
		switch (C59DCEBE)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDDocThongBao");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			AA836626 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(FFADD5B2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			D78D4C29.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		FE1D6F13 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void FE3D84A7(object sender, EventArgs e)
	{
		try
		{
			C4079507.Value = FE1D6F13.method_0("nudSoLuongFrom");
			A9106229.Value = FE1D6F13.method_0("nudSoLuongTo");
			nudDelayFrom.Value = FE1D6F13.method_0("nudDelayFrom");
			nudDelayTo.Value = FE1D6F13.method_0("nudDelayTo");
			E221A186.Checked = FE1D6F13.AA824D29("ckbXoaThongBaoSpam");
		}
		catch
		{
		}
	}

	private void DE80B53A_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D78D4C29_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", C4079507.Value);
		f72FAFBC.GetValue("nudSoLuongTo", A9106229.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		f72FAFBC.GetValue("ckbXoaThongBaoSpam", E221A186.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(FF32A194, text, AA836626, text2))
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
			if (Class123.smethod_14(AA84873A, text, text2))
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

	private void D0A6651D_Click(object sender, EventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDocThongBao));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		DA066E1B = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		DE80B53A = new System.Windows.Forms.Button();
		E62B6A03 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		E221A186 = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		A9106229 = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		C4079507 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		D0A6651D = new System.Windows.Forms.Button();
		D78D4C29 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E62B6A03).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)A9106229).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)C4079507).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DA066E1B;
		bunifuDragControl_0.Vertical = true;
		DA066E1B.BackColor = System.Drawing.Color.Transparent;
		DA066E1B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DA066E1B.Dock = System.Windows.Forms.DockStyle.Fill;
		DA066E1B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DA066E1B.ForeColor = System.Drawing.Color.Black;
		DA066E1B.Location = new System.Drawing.Point(0, 0);
		DA066E1B.Name = "bunifuCustomLabel1";
		DA066E1B.Size = new System.Drawing.Size(314, 31);
		DA066E1B.TabIndex = 12;
		DA066E1B.Text = "Cấu hình Đọc thông báo";
		DA066E1B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(DE80B53A);
		pnlHeader.Controls.Add(E62B6A03);
		pnlHeader.Controls.Add(DA066E1B);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(314, 31);
		pnlHeader.TabIndex = 9;
		DE80B53A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		DE80B53A.Cursor = System.Windows.Forms.Cursors.Hand;
		DE80B53A.FlatAppearance.BorderSize = 0;
		DE80B53A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DE80B53A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DE80B53A.ForeColor = System.Drawing.Color.White;
		DE80B53A.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		DE80B53A.Location = new System.Drawing.Point(283, 1);
		DE80B53A.Name = "button1";
		DE80B53A.Size = new System.Drawing.Size(30, 30);
		DE80B53A.TabIndex = 77;
		DE80B53A.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		DE80B53A.UseVisualStyleBackColor = true;
		DE80B53A.Click += new System.EventHandler(DE80B53A_Click);
		E62B6A03.Cursor = System.Windows.Forms.Cursors.Default;
		E62B6A03.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		E62B6A03.Location = new System.Drawing.Point(3, 2);
		E62B6A03.Name = "pictureBox1";
		E62B6A03.Size = new System.Drawing.Size(34, 27);
		E62B6A03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		E62B6A03.TabIndex = 76;
		E62B6A03.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(E221A186);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(A9106229);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(C4079507);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(D0A6651D);
		panel1.Controls.Add(D78D4C29);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(317, 213);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		E221A186.AutoSize = true;
		E221A186.Location = new System.Drawing.Point(132, 136);
		E221A186.Name = "ckbXoaThongBaoSpam";
		E221A186.Size = new System.Drawing.Size(144, 20);
		E221A186.TabIndex = 39;
		E221A186.Text = "Xóa thông báo spam";
		E221A186.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new System.Drawing.Point(226, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 6;
		A9106229.Location = new System.Drawing.Point(226, 78);
		A9106229.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A9106229.Name = "nudSoLuongTo";
		A9106229.Size = new System.Drawing.Size(56, 23);
		A9106229.TabIndex = 2;
		nudDelayFrom.Location = new System.Drawing.Point(132, 107);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		C4079507.Location = new System.Drawing.Point(132, 78);
		C4079507.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C4079507.Name = "nudSoLuongFrom";
		C4079507.Size = new System.Drawing.Size(56, 23);
		C4079507.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(150, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(192, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(192, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(17, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(109, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chơ\u0300 (s):";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(17, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(63, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(17, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		D0A6651D.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		D0A6651D.BackColor = System.Drawing.Color.Maroon;
		D0A6651D.Cursor = System.Windows.Forms.Cursors.Hand;
		D0A6651D.FlatAppearance.BorderSize = 0;
		D0A6651D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D0A6651D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D0A6651D.ForeColor = System.Drawing.Color.White;
		D0A6651D.Location = new System.Drawing.Point(167, 169);
		D0A6651D.Name = "btnCancel";
		D0A6651D.Size = new System.Drawing.Size(92, 29);
		D0A6651D.TabIndex = 8;
		D0A6651D.Text = "Đóng";
		D0A6651D.UseVisualStyleBackColor = false;
		D0A6651D.Click += new System.EventHandler(D0A6651D_Click);
		D78D4C29.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		D78D4C29.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		D78D4C29.Cursor = System.Windows.Forms.Cursors.Hand;
		D78D4C29.FlatAppearance.BorderSize = 0;
		D78D4C29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D78D4C29.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D78D4C29.ForeColor = System.Drawing.Color.White;
		D78D4C29.Location = new System.Drawing.Point(63, 169);
		D78D4C29.Name = "btnAdd";
		D78D4C29.Size = new System.Drawing.Size(92, 29);
		D78D4C29.TabIndex = 7;
		D78D4C29.Text = "Thêm";
		D78D4C29.UseVisualStyleBackColor = false;
		D78D4C29.Click += new System.EventHandler(D78D4C29_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(314, 37);
		bunifuCards1.TabIndex = 9;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(317, 213);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDocThongBao";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(FE3D84A7);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E62B6A03).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)A9106229).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)C4079507).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
