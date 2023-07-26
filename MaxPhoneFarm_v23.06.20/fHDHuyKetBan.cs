using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDHuyKetBan : Form
{
	internal JSON_Settings C705EA2B;

	internal string E182D8BB;

	internal string FA2D649C;

	internal string string_0;

	internal int EB065FB4;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal NumericUpDown C7A37F89;

	internal NumericUpDown nudSoLuongFrom;

	internal TextBox C58AFCA1;

	internal Label DFB4FB3D;

	internal Label label4;

	internal Label B8049630;

	internal Label label1;

	internal Button E3BB26BF;

	internal Button btnAdd;

	internal BunifuCards D58F538F;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown C00C3D83;

	internal Label label7;

	internal Label label6;

	internal Label label5;

	internal RadioButton C2854635;

	internal RadioButton FD1B0825;

	internal Label label8;

	internal Panel C807351D;

	internal Label DA352D8D;

	internal RichTextBox txtUid;

	internal Panel F3B4CEA2;

	internal RichTextBox txtUidKhongHuyKetBan;

	internal Label label10;

	public fHDHuyKetBan(string A5B8028D, int int_0 = 0, string string_1 = "")
	{
		InitializeComponent();
		bool_0 = false;
		E182D8BB = A5B8028D;
		string_0 = string_1;
		EB065FB4 = int_0;
		string d399C = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDHuyKetBan");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			FA2D649C = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			C58AFCA1.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_1);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			C58AFCA1.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		C705EA2B = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDHuyKetBan_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = C705EA2B.method_0("nudSoLuongFrom");
			C7A37F89.Value = C705EA2B.method_0("nudSoLuongTo");
			C00C3D83.Value = C705EA2B.method_0("nudDelayFrom");
			nudDelayTo.Value = C705EA2B.method_0("nudDelayTo");
			if (C705EA2B.method_0("typeHuyKetBan") == 0)
			{
				FD1B0825.Checked = true;
			}
			else
			{
				C2854635.Checked = true;
			}
			txtUid.Text = C705EA2B.GetValue("txtUid");
			txtUidKhongHuyKetBan.Text = C705EA2B.GetValue("txtUidKhongHuyKetBan");
			A5B02393(null, null);
			C2854635_CheckedChanged(null, null);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CC8624A8(object sender, EventArgs e)
	{
		string text = C58AFCA1.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", nudSoLuongFrom.Value);
		f72FAFBC.GetValue("nudSoLuongTo", C7A37F89.Value);
		f72FAFBC.GetValue("nudDelayFrom", C00C3D83.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		if (FD1B0825.Checked)
		{
			f72FAFBC.GetValue("typeHuyKetBan", 0);
		}
		else
		{
			f72FAFBC.GetValue("typeHuyKetBan", 1);
		}
		f72FAFBC.GetValue("txtUid", (object)txtUid.Text);
		f72FAFBC.GetValue("txtUidKhongHuyKetBan", (object)txtUidKhongHuyKetBan.Text);
		string text2 = f72FAFBC.C71A4EA4();
		if (EB065FB4 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(E182D8BB, text, FA2D649C, text2))
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
			if (Class123.smethod_14(string_0, text, text2))
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

	private void E3BB26BF_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A9116283(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void E48E8F97(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUid.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			DA352D8D.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid cần hủy kết bạn ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void A5B02393(object sender, EventArgs e)
	{
		F3B4CEA2.Enabled = FD1B0825.Checked;
	}

	private void C2854635_CheckedChanged(object sender, EventArgs e)
	{
		C807351D.Enabled = C2854635.Checked;
	}

	private void txtUidKhongHuyKetBan_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUidKhongHuyKetBan.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			label10.Text = string.Format(Language.GetValue("Danh sách UID bạn bè cần giữ lại ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void E107ED1A(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool D1A85CAF)
	{
		if (D1A85CAF && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D1A85CAF);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDHuyKetBan));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		txtUidKhongHuyKetBan = new System.Windows.Forms.RichTextBox();
		C807351D = new System.Windows.Forms.Panel();
		DA352D8D = new System.Windows.Forms.Label();
		txtUid = new System.Windows.Forms.RichTextBox();
		F3B4CEA2 = new System.Windows.Forms.Panel();
		B8049630 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		DFB4FB3D = new System.Windows.Forms.Label();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		C7A37F89 = new System.Windows.Forms.NumericUpDown();
		C2854635 = new System.Windows.Forms.RadioButton();
		FD1B0825 = new System.Windows.Forms.RadioButton();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		C00C3D83 = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		C58AFCA1 = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		E3BB26BF = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		D58F538F = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		C807351D.SuspendLayout();
		F3B4CEA2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)C7A37F89).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)C00C3D83).BeginInit();
		D58F538F.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(645, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Hủy kết bạn";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(645, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(614, 1);
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
		panel1.Controls.Add(txtUidKhongHuyKetBan);
		panel1.Controls.Add(C807351D);
		panel1.Controls.Add(F3B4CEA2);
		panel1.Controls.Add(C2854635);
		panel1.Controls.Add(FD1B0825);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(C00C3D83);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label10);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(C58AFCA1);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(E3BB26BF);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(D58F538F);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(648, 411);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(A9116283);
		txtUidKhongHuyKetBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUidKhongHuyKetBan.Location = new System.Drawing.Point(361, 99);
		txtUidKhongHuyKetBan.Name = "txtUidKhongHuyKetBan";
		txtUidKhongHuyKetBan.Size = new System.Drawing.Size(253, 243);
		txtUidKhongHuyKetBan.TabIndex = 117;
		txtUidKhongHuyKetBan.Text = "";
		txtUidKhongHuyKetBan.WordWrap = false;
		txtUidKhongHuyKetBan.TextChanged += new System.EventHandler(txtUidKhongHuyKetBan_TextChanged);
		C807351D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C807351D.Controls.Add(DA352D8D);
		C807351D.Controls.Add(txtUid);
		C807351D.Location = new System.Drawing.Point(59, 208);
		C807351D.Name = "plHuyTheoUid";
		C807351D.Size = new System.Drawing.Size(267, 134);
		C807351D.TabIndex = 118;
		DA352D8D.AutoSize = true;
		DA352D8D.Location = new System.Drawing.Point(3, 3);
		DA352D8D.Name = "lblStatus";
		DA352D8D.Size = new System.Drawing.Size(208, 16);
		DA352D8D.TabIndex = 116;
		DA352D8D.Text = "Danh sa\u0301ch Uid cần hủy kết bạn (0):";
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(7, 23);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(253, 106);
		txtUid.TabIndex = 117;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(E48E8F97);
		F3B4CEA2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F3B4CEA2.Controls.Add(B8049630);
		F3B4CEA2.Controls.Add(label4);
		F3B4CEA2.Controls.Add(DFB4FB3D);
		F3B4CEA2.Controls.Add(nudSoLuongFrom);
		F3B4CEA2.Controls.Add(C7A37F89);
		F3B4CEA2.Location = new System.Drawing.Point(59, 155);
		F3B4CEA2.Name = "plHuyNgauNhien";
		F3B4CEA2.Size = new System.Drawing.Size(267, 27);
		F3B4CEA2.TabIndex = 118;
		B8049630.AutoSize = true;
		B8049630.Location = new System.Drawing.Point(3, 3);
		B8049630.Name = "label2";
		B8049630.Size = new System.Drawing.Size(63, 16);
		B8049630.TabIndex = 32;
		B8049630.Text = "Sô\u0301 lươ\u0323ng:";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(225, 3);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(28, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0323n";
		DFB4FB3D.Location = new System.Drawing.Point(135, 3);
		DFB4FB3D.Name = "label3";
		DFB4FB3D.Size = new System.Drawing.Size(29, 16);
		DFB4FB3D.TabIndex = 37;
		DFB4FB3D.Text = "đê\u0301n";
		DFB4FB3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudSoLuongFrom.Location = new System.Drawing.Point(73, 1);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		C7A37F89.Location = new System.Drawing.Point(167, 1);
		C7A37F89.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C7A37F89.Name = "nudSoLuongTo";
		C7A37F89.Size = new System.Drawing.Size(56, 23);
		C7A37F89.TabIndex = 2;
		C2854635.AutoSize = true;
		C2854635.Cursor = System.Windows.Forms.Cursors.Hand;
		C2854635.Location = new System.Drawing.Point(46, 185);
		C2854635.Name = "rbHuyTheoUid";
		C2854635.Size = new System.Drawing.Size(145, 20);
		C2854635.TabIndex = 47;
		C2854635.Text = "Hủy kết bạn theo UID";
		C2854635.UseVisualStyleBackColor = true;
		C2854635.CheckedChanged += new System.EventHandler(C2854635_CheckedChanged);
		FD1B0825.AutoSize = true;
		FD1B0825.Checked = true;
		FD1B0825.Cursor = System.Windows.Forms.Cursors.Hand;
		FD1B0825.Location = new System.Drawing.Point(46, 132);
		FD1B0825.Name = "rbHuyNgauNhien";
		FD1B0825.Size = new System.Drawing.Size(176, 20);
		FD1B0825.TabIndex = 47;
		FD1B0825.TabStop = true;
		FD1B0825.Text = "Ngẫu nhiên danh sách bạn";
		FD1B0825.UseVisualStyleBackColor = true;
		FD1B0825.CheckedChanged += new System.EventHandler(A5B02393);
		nudDelayTo.Location = new System.Drawing.Point(226, 78);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		C00C3D83.Location = new System.Drawing.Point(132, 78);
		C00C3D83.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C00C3D83.Name = "nudDelayFrom";
		C00C3D83.Size = new System.Drawing.Size(56, 23);
		C00C3D83.TabIndex = 3;
		label7.Location = new System.Drawing.Point(192, 80);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(285, 80);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(358, 80);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(222, 16);
		label10.TabIndex = 44;
		label10.Text = "Danh sách UID bạn bè cần giữ lại (0):";
		label10.Click += new System.EventHandler(E107ED1A);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(27, 110);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(134, 16);
		label8.TabIndex = 44;
		label8.Text = "Tùy chọn hủy kết bạn:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 80);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(89, 16);
		label5.TabIndex = 44;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		C58AFCA1.Location = new System.Drawing.Point(132, 49);
		C58AFCA1.Name = "txtTenHanhDong";
		C58AFCA1.Size = new System.Drawing.Size(194, 23);
		C58AFCA1.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		E3BB26BF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E3BB26BF.BackColor = System.Drawing.Color.Maroon;
		E3BB26BF.Cursor = System.Windows.Forms.Cursors.Hand;
		E3BB26BF.FlatAppearance.BorderSize = 0;
		E3BB26BF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E3BB26BF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E3BB26BF.ForeColor = System.Drawing.Color.White;
		E3BB26BF.Location = new System.Drawing.Point(351, 364);
		E3BB26BF.Name = "btnCancel";
		E3BB26BF.Size = new System.Drawing.Size(92, 29);
		E3BB26BF.TabIndex = 7;
		E3BB26BF.Text = "Đóng";
		E3BB26BF.UseVisualStyleBackColor = false;
		E3BB26BF.Click += new System.EventHandler(E3BB26BF_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(244, 364);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(CC8624A8);
		D58F538F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D58F538F.BackColor = System.Drawing.Color.White;
		D58F538F.BorderRadius = 0;
		D58F538F.BottomSahddow = true;
		D58F538F.color = System.Drawing.Color.DarkViolet;
		D58F538F.Controls.Add(pnlHeader);
		D58F538F.LeftSahddow = false;
		D58F538F.Location = new System.Drawing.Point(1, 0);
		D58F538F.Name = "bunifuCards1";
		D58F538F.RightSahddow = true;
		D58F538F.ShadowDepth = 20;
		D58F538F.Size = new System.Drawing.Size(645, 37);
		D58F538F.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(648, 411);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDHuyKetBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDHuyKetBan_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		C807351D.ResumeLayout(false);
		C807351D.PerformLayout();
		F3B4CEA2.ResumeLayout(false);
		F3B4CEA2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)C7A37F89).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)C00C3D83).EndInit();
		D58F538F.ResumeLayout(false);
		ResumeLayout(false);
	}
}
