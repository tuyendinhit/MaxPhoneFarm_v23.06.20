using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBuffFollowUID : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string string_0;

	internal string F4848EAE;

	internal string string_1;

	internal int BEBE56A4;

	internal static bool D29ACAAE;

	internal IContainer D19A4FA2 = null;

	internal BunifuDragControl B5033803;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel E793828E;

	internal TextBox B2989494;

	internal Label CB0EC307;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Label lblUid;

	internal TextBox txtUid;

	public fHDBuffFollowUID(string string_2, int int_0 = 0, string string_3 = "")
	{
		InitializeComponent();
		D29ACAAE = false;
		string_0 = string_2;
		string_1 = string_3;
		BEBE56A4 = int_0;
		if (Class123.C7BE863B("", "HDBuffFollowUID").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDBuffFollowUID', 'Buff Follow UID');");
		}
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDBuffFollowUID");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			F4848EAE = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B2989494.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_3);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			B2989494.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDBuffFollowUID_Load(object sender, EventArgs e)
	{
		try
		{
			txtUid.Text = f72FAFBC_0.GetValue("txtUid");
		}
		catch
		{
		}
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = B2989494.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtUid", (object)txtUid.Text.Trim());
		string text2 = f72FAFBC.C71A4EA4();
		if (BEBE56A4 == 0)
		{
			if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, F4848EAE, text2))
				{
					D29ACAAE = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class123.smethod_14(string_1, text, text2))
			{
				D29ACAAE = true;
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

	private void E793828E_Paint(object sender, PaintEventArgs e)
	{
		if (E793828E.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, E793828E.ClientSize.Width - num, E793828E.ClientSize.Height - num));
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool D710EBB6)
	{
		if (D710EBB6 && D19A4FA2 != null)
		{
			D19A4FA2.Dispose();
		}
		base.Dispose(D710EBB6);
	}

	private void InitializeComponent()
	{
		D19A4FA2 = new System.ComponentModel.Container();
		B5033803 = new Bunifu.Framework.UI.BunifuDragControl(D19A4FA2);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(D19A4FA2);
		pnlHeader = new System.Windows.Forms.Panel();
		btnMinimize = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		E793828E = new System.Windows.Forms.Panel();
		txtUid = new System.Windows.Forms.TextBox();
		lblUid = new System.Windows.Forms.Label();
		B2989494 = new System.Windows.Forms.TextBox();
		CB0EC307 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		E793828E.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		B5033803.Fixed = true;
		B5033803.Horizontal = true;
		B5033803.TargetControl = bunifuCustomLabel1;
		B5033803.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(343, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Buff Follow UID";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(343, 31);
		pnlHeader.TabIndex = 9;
		btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = Resource.Bitmap_9;
		btnMinimize.Location = new System.Drawing.Point(310, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 78;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		E793828E.BackColor = System.Drawing.Color.White;
		E793828E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E793828E.Controls.Add(txtUid);
		E793828E.Controls.Add(lblUid);
		E793828E.Controls.Add(B2989494);
		E793828E.Controls.Add(CB0EC307);
		E793828E.Controls.Add(btnCancel);
		E793828E.Controls.Add(btnAdd);
		E793828E.Controls.Add(bunifuCards1);
		E793828E.Cursor = System.Windows.Forms.Cursors.Arrow;
		E793828E.Dock = System.Windows.Forms.DockStyle.Fill;
		E793828E.Location = new System.Drawing.Point(0, 0);
		E793828E.Name = "panel1";
		E793828E.Size = new System.Drawing.Size(346, 159);
		E793828E.TabIndex = 0;
		E793828E.Paint += new System.Windows.Forms.PaintEventHandler(E793828E_Paint);
		txtUid.Location = new System.Drawing.Point(132, 78);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(188, 23);
		txtUid.TabIndex = 129;
		lblUid.AutoSize = true;
		lblUid.Location = new System.Drawing.Point(21, 81);
		lblUid.Name = "lblUid";
		lblUid.Size = new System.Drawing.Size(98, 16);
		lblUid.TabIndex = 126;
		lblUid.Text = "UID câ\u0300n Follow:";
		B2989494.Location = new System.Drawing.Point(132, 49);
		B2989494.Name = "txtTenHanhDong";
		B2989494.Size = new System.Drawing.Size(188, 23);
		B2989494.TabIndex = 0;
		CB0EC307.AutoSize = true;
		CB0EC307.Location = new System.Drawing.Point(21, 52);
		CB0EC307.Name = "label1";
		CB0EC307.Size = new System.Drawing.Size(99, 16);
		CB0EC307.TabIndex = 31;
		CB0EC307.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(177, 117);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(79, 117);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 11;
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
		bunifuCards1.Size = new System.Drawing.Size(343, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(346, 159);
		base.Controls.Add(E793828E);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffFollowUID";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBuffFollowUID_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		E793828E.ResumeLayout(false);
		E793828E.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
