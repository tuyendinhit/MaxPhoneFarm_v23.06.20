using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBuffLikePage : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string string_1;

	internal string string_2;

	internal int int_0;

	internal static bool E71955B1;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl FE2C028E;

	internal Panel BEA5D185;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button B78CF337;

	internal Button BEB645AC;

	internal BunifuCards E206C2A4;

	internal Panel pnlHeader;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel B7B72D0E;

	internal Button AE920B11;

	internal Label FF1F8332;

	internal TextBox C8B7F627;

	public fHDBuffLikePage(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		E71955B1 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDBuffLikePage").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDBuffLikePage', 'Buff Like Page');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDBuffLikePage");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_4);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			BEB645AC.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDBuffLikePage_Load(object sender, EventArgs e)
	{
		try
		{
			C8B7F627.Text = f72FAFBC_0.GetValue("txtUid");
		}
		catch
		{
		}
	}

	private void CC924AA0(object sender, EventArgs e)
	{
		Close();
	}

	private void B71C722F(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtUid", (object)C8B7F627.Text.Trim());
		string d9253C2E = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, string_1, d9253C2E))
				{
					E71955B1 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class123.smethod_14(string_2, text, d9253C2E))
			{
				E71955B1 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void B5102039(object sender, EventArgs e)
	{
		Close();
	}

	private void A4301D98(object sender, PaintEventArgs e)
	{
		if (BEA5D185.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, BEA5D185.ClientSize.Width - num, BEA5D185.ClientSize.Height - num));
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
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
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		B7B72D0E = new Bunifu.Framework.UI.BunifuCustomLabel();
		FE2C028E = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		AE920B11 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		BEA5D185 = new System.Windows.Forms.Panel();
		C8B7F627 = new System.Windows.Forms.TextBox();
		FF1F8332 = new System.Windows.Forms.Label();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		B78CF337 = new System.Windows.Forms.Button();
		BEB645AC = new System.Windows.Forms.Button();
		E206C2A4 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		BEA5D185.SuspendLayout();
		E206C2A4.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = B7B72D0E;
		bunifuDragControl_0.Vertical = true;
		B7B72D0E.BackColor = System.Drawing.Color.Transparent;
		B7B72D0E.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B7B72D0E.Dock = System.Windows.Forms.DockStyle.Fill;
		B7B72D0E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B7B72D0E.ForeColor = System.Drawing.Color.Black;
		B7B72D0E.Location = new System.Drawing.Point(0, 0);
		B7B72D0E.Name = "bunifuCustomLabel1";
		B7B72D0E.Size = new System.Drawing.Size(343, 31);
		B7B72D0E.TabIndex = 12;
		B7B72D0E.Text = "Cấu hình Buff Like Page";
		B7B72D0E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FE2C028E.Fixed = true;
		FE2C028E.Horizontal = true;
		FE2C028E.TargetControl = pnlHeader;
		FE2C028E.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(AE920B11);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(B7B72D0E);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(343, 31);
		pnlHeader.TabIndex = 9;
		AE920B11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		AE920B11.Cursor = System.Windows.Forms.Cursors.Hand;
		AE920B11.FlatAppearance.BorderSize = 0;
		AE920B11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AE920B11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		AE920B11.ForeColor = System.Drawing.Color.White;
		AE920B11.Image = Resource.Bitmap_9;
		AE920B11.Location = new System.Drawing.Point(310, 0);
		AE920B11.Name = "btnMinimize";
		AE920B11.Size = new System.Drawing.Size(32, 32);
		AE920B11.TabIndex = 78;
		AE920B11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		AE920B11.UseVisualStyleBackColor = true;
		AE920B11.Click += new System.EventHandler(CC924AA0);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		BEA5D185.BackColor = System.Drawing.Color.White;
		BEA5D185.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BEA5D185.Controls.Add(C8B7F627);
		BEA5D185.Controls.Add(FF1F8332);
		BEA5D185.Controls.Add(txtTenHanhDong);
		BEA5D185.Controls.Add(label1);
		BEA5D185.Controls.Add(B78CF337);
		BEA5D185.Controls.Add(BEB645AC);
		BEA5D185.Controls.Add(E206C2A4);
		BEA5D185.Cursor = System.Windows.Forms.Cursors.Arrow;
		BEA5D185.Dock = System.Windows.Forms.DockStyle.Fill;
		BEA5D185.Location = new System.Drawing.Point(0, 0);
		BEA5D185.Name = "panel1";
		BEA5D185.Size = new System.Drawing.Size(346, 159);
		BEA5D185.TabIndex = 0;
		BEA5D185.Paint += new System.Windows.Forms.PaintEventHandler(A4301D98);
		C8B7F627.Location = new System.Drawing.Point(132, 78);
		C8B7F627.Name = "txtUid";
		C8B7F627.Size = new System.Drawing.Size(188, 23);
		C8B7F627.TabIndex = 129;
		FF1F8332.AutoSize = true;
		FF1F8332.Location = new System.Drawing.Point(21, 81);
		FF1F8332.Name = "lblUid";
		FF1F8332.Size = new System.Drawing.Size(55, 16);
		FF1F8332.TabIndex = 126;
		FF1F8332.Text = "Id Page:";
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(188, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(21, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		B78CF337.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B78CF337.BackColor = System.Drawing.Color.Maroon;
		B78CF337.Cursor = System.Windows.Forms.Cursors.Hand;
		B78CF337.FlatAppearance.BorderSize = 0;
		B78CF337.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B78CF337.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B78CF337.ForeColor = System.Drawing.Color.White;
		B78CF337.Location = new System.Drawing.Point(177, 117);
		B78CF337.Name = "btnCancel";
		B78CF337.Size = new System.Drawing.Size(92, 29);
		B78CF337.TabIndex = 12;
		B78CF337.Text = "Đóng";
		B78CF337.UseVisualStyleBackColor = false;
		B78CF337.Click += new System.EventHandler(B5102039);
		BEB645AC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		BEB645AC.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		BEB645AC.Cursor = System.Windows.Forms.Cursors.Hand;
		BEB645AC.FlatAppearance.BorderSize = 0;
		BEB645AC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BEB645AC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BEB645AC.ForeColor = System.Drawing.Color.White;
		BEB645AC.Location = new System.Drawing.Point(79, 117);
		BEB645AC.Name = "btnAdd";
		BEB645AC.Size = new System.Drawing.Size(92, 29);
		BEB645AC.TabIndex = 11;
		BEB645AC.Text = "Thêm";
		BEB645AC.UseVisualStyleBackColor = false;
		BEB645AC.Click += new System.EventHandler(B71C722F);
		E206C2A4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E206C2A4.BackColor = System.Drawing.Color.White;
		E206C2A4.BorderRadius = 0;
		E206C2A4.BottomSahddow = true;
		E206C2A4.color = System.Drawing.Color.DarkViolet;
		E206C2A4.Controls.Add(pnlHeader);
		E206C2A4.LeftSahddow = false;
		E206C2A4.Location = new System.Drawing.Point(1, 0);
		E206C2A4.Name = "bunifuCards1";
		E206C2A4.RightSahddow = true;
		E206C2A4.ShadowDepth = 20;
		E206C2A4.Size = new System.Drawing.Size(343, 37);
		E206C2A4.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(346, 159);
		base.Controls.Add(BEA5D185);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffLikePage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBuffLikePage_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		BEA5D185.ResumeLayout(false);
		BEA5D185.PerformLayout();
		E206C2A4.ResumeLayout(false);
		ResumeLayout(false);
	}
}
