using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDAddMail : Form
{
	internal JSON_Settings f72FAFBC_0;

	internal string E8889B91;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal List<string> list_0 = new List<string>();

	internal List<string> list_1 = new List<string>();

	internal List<string> DB93F494 = new List<string>();

	internal IContainer FEA9CD0C = null;

	internal BunifuDragControl C9226E95;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel DD2A77B2;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button B42AB13C;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal CheckBox F98E75BA;

	internal ToolTip toolTip_0;

	internal Panel EBA58B23;

	internal CheckBox ckbAddMail;

	internal Button btnNhapMail;

	internal CheckBox ckbSetPrimaryMail;

	internal Label label4;

	internal ComboBox C990F8AD;

	internal ComboBox cbbTypeAddMail;

	internal Label EC14270C;

	public fHDAddMail(string DF2E7B26, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		E8889B91 = DF2E7B26;
		string_1 = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Add mail";
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
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void B30EE319(object sender, EventArgs e)
	{
		try
		{
			ckbAddMail.Checked = f72FAFBC_0.AA824D29("ckbAddMail");
			cbbTypeAddMail.SelectedIndex = f72FAFBC_0.method_0("typeAddMail");
			C990F8AD.SelectedIndex = f72FAFBC_0.method_0("typeMail");
			list_0 = f72FAFBC_0.EC378D8A("lstHotmail");
			list_1 = f72FAFBC_0.EC378D8A("lstMailDomain");
			DB93F494 = f72FAFBC_0.EC378D8A("lstDomain");
			ckbSetPrimaryMail.Checked = f72FAFBC_0.AA824D29("ckbSetPrimaryMail");
			F98E75BA.Checked = f72FAFBC_0.AA824D29("ckbRemoveMail");
		}
		catch
		{
		}
		ckbSetPrimaryMail_CheckedChanged(null, null);
		ckbAddMail_CheckedChanged(null, null);
		E205C53D(null, null);
		E7368505();
	}

	private void CE230F0F(object sender, EventArgs e)
	{
		Close();
	}

	private void EA3C6F95(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("ckbAddMail", ckbAddMail.Checked);
		f72FAFBC.GetValue("typeAddMail", cbbTypeAddMail.SelectedIndex);
		f72FAFBC.GetValue("typeMail", C990F8AD.SelectedIndex);
		f72FAFBC.method_3("lstHotmail", list_0);
		f72FAFBC.method_3("lstMailDomain", list_1);
		f72FAFBC.method_3("lstDomain", DB93F494);
		f72FAFBC.GetValue("ckbSetPrimaryMail", ckbSetPrimaryMail.Checked);
		f72FAFBC.GetValue("ckbRemoveMail", F98E75BA.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class123.smethod_12(E8889B91, text, string_0, text2))
				{
					bool_0 = true;
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
			if (Class123.smethod_14(string_1, text, text2))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void B42AB13C_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DD2A77B2_Paint(object sender, PaintEventArgs e)
	{
		if (DD2A77B2.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, DD2A77B2.ClientSize.Width - num, DD2A77B2.ClientSize.Height - num));
		}
	}

	private void ckbAddMail_CheckedChanged(object sender, EventArgs e)
	{
		EBA58B23.Enabled = ckbAddMail.Checked;
		if (!ckbAddMail.Checked)
		{
			F98E75BA.Enabled = true;
		}
		else if (ckbSetPrimaryMail.Checked)
		{
			F98E75BA.Checked = true;
			F98E75BA.Enabled = false;
		}
	}

	private void btnNhapMail_Click(object sender, EventArgs e)
	{
		switch (C990F8AD.SelectedIndex)
		{
		case 0:
		{
			fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch hotmail (mail|pass mail)", "Danh sa\u0301ch mail|pass mail", "(Mô\u0303i nội dung 1 do\u0300ng)");
			Common.smethod_16(fNhapDuLieu4);
			list_0 = fNhapDuLieu4.list_0;
			Common.DB181F2D(btnNhapMail, list_0.Count);
			break;
		}
		case 1:
		{
			fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_1, "Nhâ\u0323p danh sa\u0301ch link mail domain", "Danh sa\u0301ch link mail domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
			Common.smethod_16(fNhapDuLieu4);
			list_1 = fNhapDuLieu4.list_0;
			Common.DB181F2D(btnNhapMail, list_1.Count);
			break;
		}
		case 2:
		{
			fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(DB93F494, "Nhâ\u0323p danh sa\u0301ch domain", "Danh sa\u0301ch domain", "(Mô\u0303i nội dung 1 do\u0300ng)");
			Common.smethod_16(fNhapDuLieu4);
			DB93F494 = fNhapDuLieu4.list_0;
			Common.DB181F2D(btnNhapMail, DB93F494.Count);
			break;
		}
		}
	}

	private void ckbSetPrimaryMail_CheckedChanged(object sender, EventArgs e)
	{
		if (ckbSetPrimaryMail.Checked)
		{
			F98E75BA.Checked = true;
			F98E75BA.Enabled = false;
		}
		else
		{
			F98E75BA.Enabled = true;
		}
	}

	private void E205C53D(object sender, EventArgs e)
	{
		E7368505();
	}

	private void E7368505()
	{
		switch (C990F8AD.SelectedIndex)
		{
		case 0:
			Common.DB181F2D(btnNhapMail, list_0.Count);
			break;
		case 1:
			Common.DB181F2D(btnNhapMail, list_1.Count);
			break;
		case 2:
			Common.DB181F2D(btnNhapMail, DB93F494.Count);
			break;
		}
	}

	private void D7B73802(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
		{
			EBA58B23.Height = ((EBA58B23.Height == 90) ? 58 : 90);
		}
	}

	protected override void Dispose(bool DBABEDA3)
	{
		if (DBABEDA3 && FEA9CD0C != null)
		{
			FEA9CD0C.Dispose();
		}
		base.Dispose(DBABEDA3);
	}

	private void InitializeComponent()
	{
		FEA9CD0C = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDAddMail));
		C9226E95 = new Bunifu.Framework.UI.BunifuDragControl(FEA9CD0C);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(FEA9CD0C);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		DD2A77B2 = new System.Windows.Forms.Panel();
		EBA58B23 = new System.Windows.Forms.Panel();
		C990F8AD = new System.Windows.Forms.ComboBox();
		cbbTypeAddMail = new System.Windows.Forms.ComboBox();
		btnNhapMail = new System.Windows.Forms.Button();
		ckbSetPrimaryMail = new System.Windows.Forms.CheckBox();
		label4 = new System.Windows.Forms.Label();
		EC14270C = new System.Windows.Forms.Label();
		ckbAddMail = new System.Windows.Forms.CheckBox();
		F98E75BA = new System.Windows.Forms.CheckBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		B42AB13C = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(FEA9CD0C);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		DD2A77B2.SuspendLayout();
		EBA58B23.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		C9226E95.Fixed = true;
		C9226E95.Horizontal = true;
		C9226E95.TargetControl = bunifuCustomLabel1;
		C9226E95.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(363, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Add Mail";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(363, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(332, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(CE230F0F);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		DD2A77B2.BackColor = System.Drawing.Color.White;
		DD2A77B2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		DD2A77B2.Controls.Add(EBA58B23);
		DD2A77B2.Controls.Add(ckbAddMail);
		DD2A77B2.Controls.Add(F98E75BA);
		DD2A77B2.Controls.Add(txtTenHanhDong);
		DD2A77B2.Controls.Add(label1);
		DD2A77B2.Controls.Add(B42AB13C);
		DD2A77B2.Controls.Add(btnAdd);
		DD2A77B2.Controls.Add(bunifuCards1);
		DD2A77B2.Cursor = System.Windows.Forms.Cursors.Arrow;
		DD2A77B2.Dock = System.Windows.Forms.DockStyle.Fill;
		DD2A77B2.Location = new System.Drawing.Point(0, 0);
		DD2A77B2.Name = "panel1";
		DD2A77B2.Size = new System.Drawing.Size(366, 235);
		DD2A77B2.TabIndex = 0;
		DD2A77B2.Paint += new System.Windows.Forms.PaintEventHandler(DD2A77B2_Paint);
		EBA58B23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EBA58B23.Controls.Add(C990F8AD);
		EBA58B23.Controls.Add(cbbTypeAddMail);
		EBA58B23.Controls.Add(btnNhapMail);
		EBA58B23.Controls.Add(ckbSetPrimaryMail);
		EBA58B23.Controls.Add(label4);
		EBA58B23.Controls.Add(EC14270C);
		EBA58B23.Location = new System.Drawing.Point(41, 98);
		EBA58B23.Name = "plAddMail";
		EBA58B23.Size = new System.Drawing.Size(300, 58);
		EBA58B23.TabIndex = 115;
		EBA58B23.Click += new System.EventHandler(D7B73802);
		C990F8AD.Cursor = System.Windows.Forms.Cursors.Hand;
		C990F8AD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		C990F8AD.DropDownWidth = 200;
		C990F8AD.FormattingEnabled = true;
		C990F8AD.Items.AddRange(new object[3] { "Hotmail", "Mail domain", "https://generator.email/" });
		C990F8AD.Location = new System.Drawing.Point(83, 6);
		C990F8AD.Name = "cbbTypeMail";
		C990F8AD.Size = new System.Drawing.Size(121, 24);
		C990F8AD.TabIndex = 118;
		C990F8AD.SelectedIndexChanged += new System.EventHandler(E205C53D);
		cbbTypeAddMail.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeAddMail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeAddMail.FormattingEnabled = true;
		cbbTypeAddMail.Items.AddRange(new object[2] { "Add mail bình thường", "Tut không cần pass" });
		cbbTypeAddMail.Location = new System.Drawing.Point(76, 58);
		cbbTypeAddMail.Name = "cbbTypeAddMail";
		cbbTypeAddMail.Size = new System.Drawing.Size(213, 24);
		cbbTypeAddMail.TabIndex = 118;
		btnNhapMail.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapMail.Location = new System.Drawing.Point(209, 5);
		btnNhapMail.Name = "btnNhapMail";
		btnNhapMail.Size = new System.Drawing.Size(86, 27);
		btnNhapMail.TabIndex = 116;
		btnNhapMail.Text = "Nhập (0)";
		btnNhapMail.UseVisualStyleBackColor = true;
		btnNhapMail.Click += new System.EventHandler(btnNhapMail_Click);
		ckbSetPrimaryMail.AutoSize = true;
		ckbSetPrimaryMail.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSetPrimaryMail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbSetPrimaryMail.Location = new System.Drawing.Point(10, 34);
		ckbSetPrimaryMail.Name = "ckbSetPrimaryMail";
		ckbSetPrimaryMail.Size = new System.Drawing.Size(181, 20);
		ckbSetPrimaryMail.TabIndex = 113;
		ckbSetPrimaryMail.Text = "Set mail mới lên mail chính";
		ckbSetPrimaryMail.UseVisualStyleBackColor = true;
		ckbSetPrimaryMail.CheckedChanged += new System.EventHandler(ckbSetPrimaryMail_CheckedChanged);
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(7, 9);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(63, 16);
		label4.TabIndex = 31;
		label4.Text = "Loại mail:";
		EC14270C.AutoSize = true;
		EC14270C.Location = new System.Drawing.Point(7, 61);
		EC14270C.Name = "label3";
		EC14270C.Size = new System.Drawing.Size(64, 16);
		EC14270C.TabIndex = 31;
		EC14270C.Text = "Tùy chọn:";
		ckbAddMail.AutoSize = true;
		ckbAddMail.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAddMail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbAddMail.Location = new System.Drawing.Point(23, 75);
		ckbAddMail.Name = "ckbAddMail";
		ckbAddMail.Size = new System.Drawing.Size(75, 20);
		ckbAddMail.TabIndex = 113;
		ckbAddMail.Text = "Add Mail";
		ckbAddMail.UseVisualStyleBackColor = true;
		ckbAddMail.CheckedChanged += new System.EventHandler(ckbAddMail_CheckedChanged);
		F98E75BA.AutoSize = true;
		F98E75BA.Cursor = System.Windows.Forms.Cursors.Hand;
		F98E75BA.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F98E75BA.Location = new System.Drawing.Point(23, 162);
		F98E75BA.Name = "ckbRemoveMail";
		F98E75BA.Size = new System.Drawing.Size(101, 20);
		F98E75BA.TabIndex = 113;
		F98E75BA.Text = "Xóa mail phụ";
		F98E75BA.UseVisualStyleBackColor = true;
		txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(216, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(20, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		B42AB13C.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B42AB13C.BackColor = System.Drawing.Color.Maroon;
		B42AB13C.Cursor = System.Windows.Forms.Cursors.Hand;
		B42AB13C.FlatAppearance.BorderSize = 0;
		B42AB13C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B42AB13C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B42AB13C.ForeColor = System.Drawing.Color.White;
		B42AB13C.Location = new System.Drawing.Point(193, 192);
		B42AB13C.Name = "btnCancel";
		B42AB13C.Size = new System.Drawing.Size(92, 29);
		B42AB13C.TabIndex = 7;
		B42AB13C.Text = "Đóng";
		B42AB13C.UseVisualStyleBackColor = false;
		B42AB13C.Click += new System.EventHandler(B42AB13C_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(86, 192);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(EA3C6F95);
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
		bunifuCards1.Size = new System.Drawing.Size(363, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(366, 235);
		base.Controls.Add(DD2A77B2);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDAddMail";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B30EE319);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		DD2A77B2.ResumeLayout(false);
		DD2A77B2.PerformLayout();
		EBA58B23.ResumeLayout(false);
		EBA58B23.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
