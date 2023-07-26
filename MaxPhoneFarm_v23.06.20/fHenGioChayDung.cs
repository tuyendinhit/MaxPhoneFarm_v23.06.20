using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHenGioChayDung : Form
{
	[CompilerGenerated]
	private sealed class Class57
	{
		internal Control E40AC183;

		internal bool bool_0;

		internal void A93C7903()
		{
			E40AC183.Enabled = bool_0;
		}
	}

	internal JSON_Settings f72FAFBC_0;

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button ADA0021C;

	internal BunifuDragControl D1A81683;

	internal PictureBox E41015A0;

	internal Button btnCancel;

	internal Button A28A86A1;

	internal CheckBox ckbTatPhanMem;

	internal CheckBox ckbTatMay;

	internal CheckBox B7821A9D;

	internal ComboBox cbbHenGioChayTime;

	internal Button CDBCB098;

	internal Button button4;

	internal CheckBox E8186488;

	internal CheckBox ckbHenGioDung;

	internal ComboBox cbbHenGioDungTime;

	internal Button button7;

	internal Button button8;

	internal Panel E5318AB4;

	internal Panel plHenGioDung;

	internal Panel panel1;

	public fHenGioChayDung(JSON_Settings A82C5BA2)
	{
		InitializeComponent();
		f72FAFBC_0 = A82C5BA2;
	}

	private void ADA0021C_Click(object sender, EventArgs e)
	{
		f72FAFBC_0.GetValue("isCancel", true);
		Close();
	}

	private void method_0(Control FCA6FA81, bool BFBBD0A6 = true)
	{
		try
		{
			FCA6FA81.Invoke((Action)delegate
			{
				FCA6FA81.Enabled = BFBBD0A6;
			});
		}
		catch
		{
		}
	}

	private void fHenGioChayDung_Load(object sender, EventArgs e)
	{
		method_1();
		E8186488.Checked = SettingsTool.GetSettings("henGioTatTool").AA824D29("ckbHenGioChay");
		cbbHenGioChayTime.Text = SettingsTool.GetSettings("henGioTatTool").GetValue("timeStart");
		ckbHenGioDung.Checked = SettingsTool.GetSettings("henGioTatTool").AA824D29("ckbHenGioDung");
		cbbHenGioDungTime.Text = SettingsTool.GetSettings("henGioTatTool").GetValue("timeStop");
		ckbTatPhanMem.Checked = SettingsTool.GetSettings("henGioTatTool").AA824D29("ckbTatPhanMem");
		B7821A9D.Checked = SettingsTool.GetSettings("henGioTatTool").AA824D29("ckbGiaiPhongDungLuong");
		ckbTatMay.Checked = SettingsTool.GetSettings("henGioTatTool").AA824D29("ckbTatMay");
		E8186488_CheckedChanged(null, null);
		ckbHenGioDung_CheckedChanged(null, null);
	}

	private void method_1()
	{
		method_4(cbbHenGioChayTime, "lstTimeStart");
		method_4(cbbHenGioDungTime, "lstTimeStop");
	}

	private void A28A86A1_Click(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("henGioTatTool").GetValue("ckbHenGioChay", E8186488.Checked);
        SettingsTool.GetSettings("henGioTatTool").GetValue("timeStart", (object)cbbHenGioChayTime.Text);
		SettingsTool.GetSettings("henGioTatTool").GetValue("ckbHenGioDung", ckbHenGioDung.Checked);
        SettingsTool.GetSettings("henGioTatTool").GetValue("timeStop", (object)cbbHenGioDungTime.Text);
		SettingsTool.GetSettings("henGioTatTool").GetValue("ckbTatPhanMem", ckbTatPhanMem.Checked);
		SettingsTool.GetSettings("henGioTatTool").GetValue("ckbGiaiPhongDungLuong", B7821A9D.Checked);
		SettingsTool.GetSettings("henGioTatTool").GetValue("ckbTatMay", ckbTatMay.Checked);
		SettingsTool.smethod_0("henGioTatTool");
		if (E8186488.Checked)
		{
            f72FAFBC_0.GetValue("timeStart", (object)cbbHenGioChayTime.Text);
		}
		if (ckbHenGioDung.Checked)
		{
            f72FAFBC_0.GetValue("timeStop", (object)cbbHenGioDungTime.Text);
		}
		f72FAFBC_0.GetValue("ckbTatPhanMem", ckbTatPhanMem.Enabled && ckbTatPhanMem.Checked);
		f72FAFBC_0.GetValue("ckbGiaiPhongDungLuong", B7821A9D.Enabled && B7821A9D.Checked);
		f72FAFBC_0.GetValue("ckbTatMay", ckbTatMay.Enabled && ckbTatMay.Checked);
		Close();
	}

	private void BC320EBA(object sender, EventArgs e)
	{
		f72FAFBC_0.GetValue("isCancel", true);
		Close();
	}

	private void method_2(ComboBox comboBox_0, string A68AFF06)
	{
		fHenGioChayDungAddTime fHenGioChayDungAddTime2 = new fHenGioChayDungAddTime();
		fHenGioChayDungAddTime2.ShowDialog();
		string string_ = fHenGioChayDungAddTime2.string_0;
		if (!(string_ == ""))
		{
			List<string> list = SettingsTool.GetSettings("henGioTatTool").EC378D8A(A68AFF06);
			list.Add(string_);
			SettingsTool.GetSettings("henGioTatTool").method_3(A68AFF06, list);
			SettingsTool.smethod_0("henGioTatTool");
			comboBox_0.Items.Add(string_);
			comboBox_0.SelectedIndex = comboBox_0.Items.Count - 1;
		}
	}

	private void method_3(ComboBox comboBox_0, string string_0)
	{
		if (comboBox_0.Items.Count == 0 || MessageBoxHelper.smethod_1("Bạn có chắc chắn muốn xóa thời gian này không?") == DialogResult.No)
		{
			return;
		}
		List<string> list = SettingsTool.GetSettings("henGioTatTool").EC378D8A(string_0);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Split('-')[0].Trim() == comboBox_0.Text)
			{
				list.RemoveAt(i--);
			}
		}
		SettingsTool.GetSettings("henGioTatTool").method_3(string_0, list);
		SettingsTool.smethod_0("henGioTatTool");
		int selectedIndex = comboBox_0.SelectedIndex;
		comboBox_0.Items.RemoveAt(comboBox_0.SelectedIndex);
		if (selectedIndex == comboBox_0.Items.Count)
		{
			comboBox_0.SelectedIndex = comboBox_0.Items.Count - 1;
		}
		else
		{
			comboBox_0.SelectedIndex = selectedIndex;
		}
	}

	private void method_4(ComboBox comboBox_0, string string_0)
	{
		List<string> list = SettingsTool.GetSettings("henGioTatTool").EC378D8A(string_0);
		if (list.Count == 0)
		{
			if (string_0 == "lstTimeStart")
			{
				list.Add("08:00:00");
			}
			else
			{
				list.Add("22:30:00");
			}
			SettingsTool.GetSettings("henGioTatTool").method_3(string_0, list);
			SettingsTool.smethod_0("henGioTatTool");
		}
		foreach (string item in list)
		{
			comboBox_0.Items.Add(item.Split('-')[0].Trim());
		}
		comboBox_0.SelectedIndex = 0;
	}

	private void CDBCB098_Click(object sender, EventArgs e)
	{
		method_2(cbbHenGioChayTime, "lstTimeStart");
	}

	private void button4_Click(object sender, EventArgs e)
	{
		method_3(cbbHenGioChayTime, "lstTimeStart");
	}

	private void button7_Click(object sender, EventArgs e)
	{
		method_2(cbbHenGioDungTime, "lstTimeStop");
	}

	private void button8_Click(object sender, EventArgs e)
	{
		method_3(cbbHenGioDungTime, "lstTimeStop");
	}

	private void E8186488_CheckedChanged(object sender, EventArgs e)
	{
		E5318AB4.Enabled = E8186488.Checked;
	}

	private void ckbHenGioDung_CheckedChanged(object sender, EventArgs e)
	{
		plHenGioDung.Enabled = ckbHenGioDung.Checked;
		ckbTatPhanMem.Enabled = ckbHenGioDung.Checked;
		B7821A9D.Enabled = ckbHenGioDung.Checked;
		ckbTatMay.Enabled = ckbHenGioDung.Checked;
	}

	protected override void Dispose(bool C3142102)
	{
		if (C3142102 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C3142102);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHenGioChayDung));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		E41015A0 = new System.Windows.Forms.PictureBox();
		ADA0021C = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D1A81683 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		btnCancel = new System.Windows.Forms.Button();
		A28A86A1 = new System.Windows.Forms.Button();
		ckbTatPhanMem = new System.Windows.Forms.CheckBox();
		ckbTatMay = new System.Windows.Forms.CheckBox();
		B7821A9D = new System.Windows.Forms.CheckBox();
		cbbHenGioChayTime = new System.Windows.Forms.ComboBox();
		CDBCB098 = new System.Windows.Forms.Button();
		button4 = new System.Windows.Forms.Button();
		E8186488 = new System.Windows.Forms.CheckBox();
		ckbHenGioDung = new System.Windows.Forms.CheckBox();
		cbbHenGioDungTime = new System.Windows.Forms.ComboBox();
		button7 = new System.Windows.Forms.Button();
		button8 = new System.Windows.Forms.Button();
		E5318AB4 = new System.Windows.Forms.Panel();
		plHenGioDung = new System.Windows.Forms.Panel();
		panel1 = new System.Windows.Forms.Panel();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E41015A0).BeginInit();
		E5318AB4.SuspendLayout();
		plHenGioDung.SuspendLayout();
		panel1.SuspendLayout();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(379, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(E41015A0);
		pnlHeader.Controls.Add(ADA0021C);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(379, 32);
		pnlHeader.TabIndex = 9;
		E41015A0.Cursor = System.Windows.Forms.Cursors.Default;
		E41015A0.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		E41015A0.Location = new System.Drawing.Point(3, 2);
		E41015A0.Name = "pictureBox1";
		E41015A0.Size = new System.Drawing.Size(34, 27);
		E41015A0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		E41015A0.TabIndex = 17;
		E41015A0.TabStop = false;
		ADA0021C.Cursor = System.Windows.Forms.Cursors.Hand;
		ADA0021C.Dock = System.Windows.Forms.DockStyle.Right;
		ADA0021C.FlatAppearance.BorderSize = 0;
		ADA0021C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		ADA0021C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ADA0021C.ForeColor = System.Drawing.Color.White;
		ADA0021C.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		ADA0021C.Location = new System.Drawing.Point(347, 0);
		ADA0021C.Name = "btnMinimize";
		ADA0021C.Size = new System.Drawing.Size(32, 32);
		ADA0021C.TabIndex = 9;
		ADA0021C.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		ADA0021C.UseVisualStyleBackColor = true;
		ADA0021C.Click += new System.EventHandler(ADA0021C_Click);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(379, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Hẹn giờ chạy tool";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D1A81683.Fixed = true;
		D1A81683.Horizontal = true;
		D1A81683.TargetControl = bunifuCustomLabel1;
		D1A81683.Vertical = true;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(200, 100);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 183;
		btnCancel.Text = "Hủy";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(BC320EBA);
		A28A86A1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A28A86A1.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		A28A86A1.Cursor = System.Windows.Forms.Cursors.Hand;
		A28A86A1.FlatAppearance.BorderSize = 0;
		A28A86A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A28A86A1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A28A86A1.ForeColor = System.Drawing.Color.White;
		A28A86A1.Location = new System.Drawing.Point(92, 100);
		A28A86A1.Name = "btnAdd";
		A28A86A1.Size = new System.Drawing.Size(92, 29);
		A28A86A1.TabIndex = 182;
		A28A86A1.Text = "Xa\u0301c nhâ\u0323n";
		A28A86A1.UseVisualStyleBackColor = false;
		A28A86A1.Click += new System.EventHandler(A28A86A1_Click);
		ckbTatPhanMem.AutoSize = true;
		ckbTatPhanMem.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTatPhanMem.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbTatPhanMem.Location = new System.Drawing.Point(34, 199);
		ckbTatPhanMem.Name = "ckbTatPhanMem";
		ckbTatPhanMem.Size = new System.Drawing.Size(110, 20);
		ckbTatPhanMem.TabIndex = 194;
		ckbTatPhanMem.Text = "Tắt phần mềm";
		ckbTatPhanMem.UseVisualStyleBackColor = true;
		ckbTatPhanMem.Visible = false;
		ckbTatMay.AutoSize = true;
		ckbTatMay.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTatMay.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbTatMay.Location = new System.Drawing.Point(34, 251);
		ckbTatMay.Name = "ckbTatMay";
		ckbTatMay.Size = new System.Drawing.Size(73, 20);
		ckbTatMay.TabIndex = 194;
		ckbTatMay.Text = "Tắt máy";
		ckbTatMay.UseVisualStyleBackColor = true;
		ckbTatMay.Visible = false;
		B7821A9D.AutoSize = true;
		B7821A9D.Cursor = System.Windows.Forms.Cursors.Hand;
		B7821A9D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B7821A9D.Location = new System.Drawing.Point(34, 225);
		B7821A9D.Name = "ckbGiaiPhongDungLuong";
		B7821A9D.Size = new System.Drawing.Size(154, 20);
		B7821A9D.TabIndex = 194;
		B7821A9D.Text = "Giải phóng dung lượng";
		B7821A9D.UseVisualStyleBackColor = true;
		B7821A9D.Visible = false;
		cbbHenGioChayTime.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbHenGioChayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbHenGioChayTime.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbHenGioChayTime.FormattingEnabled = true;
		cbbHenGioChayTime.Location = new System.Drawing.Point(3, 3);
		cbbHenGioChayTime.Name = "cbbHenGioChayTime";
		cbbHenGioChayTime.Size = new System.Drawing.Size(151, 24);
		cbbHenGioChayTime.TabIndex = 195;
		CDBCB098.Cursor = System.Windows.Forms.Cursors.Hand;
		CDBCB098.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CDBCB098.Location = new System.Drawing.Point(160, 2);
		CDBCB098.Name = "button1";
		CDBCB098.Size = new System.Drawing.Size(25, 25);
		CDBCB098.TabIndex = 196;
		CDBCB098.Text = "+";
		CDBCB098.UseVisualStyleBackColor = true;
		CDBCB098.Click += new System.EventHandler(CDBCB098_Click);
		button4.Cursor = System.Windows.Forms.Cursors.Hand;
		button4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button4.Location = new System.Drawing.Point(187, 2);
		button4.Name = "button4";
		button4.Size = new System.Drawing.Size(25, 25);
		button4.TabIndex = 196;
		button4.Text = "-";
		button4.UseVisualStyleBackColor = true;
		button4.Click += new System.EventHandler(button4_Click);
		E8186488.AutoSize = true;
		E8186488.Cursor = System.Windows.Forms.Cursors.Hand;
		E8186488.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E8186488.Location = new System.Drawing.Point(34, 62);
		E8186488.Name = "ckbHenGioChay";
		E8186488.Size = new System.Drawing.Size(99, 20);
		E8186488.TabIndex = 194;
		E8186488.Text = "Hẹn giờ chạy";
		E8186488.UseVisualStyleBackColor = true;
		E8186488.CheckedChanged += new System.EventHandler(E8186488_CheckedChanged);
		ckbHenGioDung.AutoSize = true;
		ckbHenGioDung.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHenGioDung.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbHenGioDung.Location = new System.Drawing.Point(34, 172);
		ckbHenGioDung.Name = "ckbHenGioDung";
		ckbHenGioDung.Size = new System.Drawing.Size(102, 20);
		ckbHenGioDung.TabIndex = 194;
		ckbHenGioDung.Text = "Hẹn giờ dừng";
		ckbHenGioDung.UseVisualStyleBackColor = true;
		ckbHenGioDung.Visible = false;
		ckbHenGioDung.CheckedChanged += new System.EventHandler(ckbHenGioDung_CheckedChanged);
		cbbHenGioDungTime.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbHenGioDungTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbHenGioDungTime.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbHenGioDungTime.FormattingEnabled = true;
		cbbHenGioDungTime.Location = new System.Drawing.Point(3, 3);
		cbbHenGioDungTime.Name = "cbbHenGioDungTime";
		cbbHenGioDungTime.Size = new System.Drawing.Size(151, 24);
		cbbHenGioDungTime.TabIndex = 195;
		button7.Cursor = System.Windows.Forms.Cursors.Hand;
		button7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button7.Location = new System.Drawing.Point(160, 2);
		button7.Name = "button7";
		button7.Size = new System.Drawing.Size(25, 25);
		button7.TabIndex = 196;
		button7.Text = "+";
		button7.UseVisualStyleBackColor = true;
		button7.Click += new System.EventHandler(button7_Click);
		button8.Cursor = System.Windows.Forms.Cursors.Hand;
		button8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button8.Location = new System.Drawing.Point(187, 2);
		button8.Name = "button8";
		button8.Size = new System.Drawing.Size(25, 25);
		button8.TabIndex = 196;
		button8.Text = "-";
		button8.UseVisualStyleBackColor = true;
		button8.Click += new System.EventHandler(button8_Click);
		E5318AB4.Controls.Add(cbbHenGioChayTime);
		E5318AB4.Controls.Add(CDBCB098);
		E5318AB4.Controls.Add(button4);
		E5318AB4.Location = new System.Drawing.Point(135, 57);
		E5318AB4.Name = "plHenGioChay";
		E5318AB4.Size = new System.Drawing.Size(212, 29);
		E5318AB4.TabIndex = 197;
		plHenGioDung.Controls.Add(cbbHenGioDungTime);
		plHenGioDung.Controls.Add(button7);
		plHenGioDung.Controls.Add(button8);
		plHenGioDung.Location = new System.Drawing.Point(135, 167);
		plHenGioDung.Name = "plHenGioDung";
		plHenGioDung.Size = new System.Drawing.Size(212, 29);
		plHenGioDung.TabIndex = 197;
		plHenGioDung.Visible = false;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(bunifuCards1);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(381, 142);
		panel1.TabIndex = 198;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(381, 142);
		base.Controls.Add(plHenGioDung);
		base.Controls.Add(E5318AB4);
		base.Controls.Add(ckbTatMay);
		base.Controls.Add(B7821A9D);
		base.Controls.Add(ckbHenGioDung);
		base.Controls.Add(E8186488);
		base.Controls.Add(ckbTatPhanMem);
		base.Controls.Add(btnCancel);
		base.Controls.Add(A28A86A1);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fHenGioChayDung";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fHenGioChayDung_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E41015A0).EndInit();
		E5318AB4.ResumeLayout(false);
		plHenGioDung.ResumeLayout(false);
		panel1.ResumeLayout(false);
		ResumeLayout(false);
		PerformLayout();
	}
}
