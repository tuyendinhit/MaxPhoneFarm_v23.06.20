using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapDuLieu2 : Form
{
	internal string B02A9C3B = "";

	internal Random F99BAF0F = new Random();

	internal bool bool_0 = false;

	internal IContainer AFA3F20B = null;

	internal BunifuCards CEA95F18;

	internal Panel panel1;

	internal BunifuDragControl AA3FCC19;

	internal ToolTip toolTip_0;

	internal BunifuCards bunifuCards2;

	internal Panel pnlHeader;

	internal Button button2;

	internal PictureBox B783CF0C;

	internal Button E50EE48E;

	internal BunifuCustomLabel lblTitle;

	internal Button btnSave;

	internal TextBox E917759F;

	internal GroupBox DABC271E;

	internal GroupBox C127CE13;

	internal DataGridView BE8D9790;

	internal Button EC182086;

	internal DataGridViewTextBoxColumn cSTT;

	internal DataGridViewTextBoxColumn FBA34A34;

	internal DataGridViewButtonColumn CE2C1DB6;

	internal DataGridViewButtonColumn cSua;

	internal DataGridViewButtonColumn F9A54D31;

	internal Button btnHuy;

	public fNhapDuLieu2(string string_0, string EB2E1095)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		B02A9C3B = string_0;
		lblTitle.Text = EB2E1095;
	}

	private void DB9F1414()
	{
		Language.smethod_1(lblTitle);
		Language.smethod_1(DABC271E);
		Language.smethod_1(C127CE13);
		foreach (DataGridViewColumn column in BE8D9790.Columns)
		{
			Language.E3937E81(column);
		}
		Language.smethod_1(EC182086);
		Language.smethod_1(btnSave);
		Language.smethod_1(btnHuy);
	}

	private void fNhapDuLieu2_Load(object sender, EventArgs e)
	{
		Common.CreateFolder(B02A9C3B);
		F4B60582(B02A9C3B);
	}

	private void method_0(int int_0)
	{
		E917759F.Lines = File.ReadAllLines(DatagridviewHelper.E83E252C(BE8D9790, int_0, "cName"));
	}

	private void F4B60582(string string_0)
	{
		int num = -1;
		switch (BE8D9790.RowCount)
		{
		default:
			num = BE8D9790.SelectedRows[0].Index;
			break;
		case 1:
			num = 0;
			break;
		case 0:
			break;
		}
		BE8D9790.Rows.Clear();
		List<string> list = Directory.GetFiles(string_0).ToList();
		for (int i = 0; i < list.Count; i++)
		{
			BE8D9790.Rows.Add(i + 1, list[i], Language.GetValue("Chi tiê\u0301t"), Language.GetValue("Sư\u0309a"), Language.GetValue("Xo\u0301a"));
		}
		if (num == -1 && BE8D9790.RowCount > 0)
		{
			num = 0;
		}
		else if (num + 1 > BE8D9790.RowCount)
		{
			num = BE8D9790.RowCount - 1;
		}
		if (num == -1)
		{
			E917759F.Text = "";
			return;
		}
		Common.F0A2131B(BE8D9790);
		BE8D9790.Rows[num].Selected = true;
		method_0(num);
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_1(int int_0)
	{
		if (int_0 == 1)
		{
			BE8D9790.Enabled = false;
			EC182086.Enabled = false;
			btnSave.Enabled = true;
			btnHuy.Enabled = true;
			E917759F.ReadOnly = false;
			E917759F.Focus();
		}
		else
		{
			BE8D9790.Enabled = true;
			EC182086.Enabled = true;
			btnSave.Enabled = false;
			btnHuy.Enabled = false;
			E917759F.ReadOnly = true;
		}
	}

	private void D59D4484(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			string text2;
			do
			{
				text2 = DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss_") + Common.CreateRandomString(3) + ".txt";
			}
			while (File.Exists(text2));
			text = B02A9C3B + "\\" + text2;
			Common.smethod_14(text);
			E917759F.Lines = File.ReadAllLines(text);
			BE8D9790.Rows.Add(BE8D9790.RowCount + 1, text, Language.GetValue("Chi tiê\u0301t"), Language.GetValue("Sư\u0309a"), Language.GetValue("Xo\u0301a"));
			Common.F0A2131B(BE8D9790);
			BE8D9790.Rows[BE8D9790.RowCount - 1].Selected = true;
			method_1(1);
			bool_0 = true;
		}
		catch
		{
			MessageBoxHelper.Show(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void DF2C80A9(object sender, EventArgs e)
	{
	}

	private void ED863DBE(object sender, EventArgs e)
	{
	}

	private void BE8D9790_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
	{
		string name = BE8D9790.Columns[e.ColumnIndex].Name;
		if (name != "cChiTiet" && name != "cSua" && name != "cXoa")
		{
			BE8D9790.Cursor = Cursors.Default;
		}
		else if (e.RowIndex < BE8D9790.RowCount)
		{
			BE8D9790.Cursor = Cursors.Hand;
		}
	}

	private void BE8D9790_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		DataGridView dataGridView = (DataGridView)sender;
		if (!(dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) || e.RowIndex < 0)
		{
			return;
		}
		switch (dataGridView.Columns[e.ColumnIndex].Name)
		{
		case "cXoa":
			if (MessageBoxHelper.smethod_1(Language.GetValue("Bạn có muốn xóa?")) == DialogResult.Yes)
			{
				File.Delete(DatagridviewHelper.E83E252C(BE8D9790, e.RowIndex, "cName"));
				F4B60582(B02A9C3B);
			}
			break;
		case "cSua":
			E917759F.Lines = File.ReadAllLines(DatagridviewHelper.E83E252C(BE8D9790, e.RowIndex, "cName"));
			bool_0 = false;
			method_1(1);
			break;
		case "cChiTiet":
			method_0(e.RowIndex);
			break;
		}
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		try
		{
			string text = BE8D9790.SelectedRows[0].Cells["cName"].Value.ToString();
			Common.smethod_14(text);
			if (E917759F.Text.Trim() == "")
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập nội dung cần lưu!"), 3);
			}
			else if (MessageBoxHelper.smethod_1(Language.GetValue("Bạn có muốn lưu lại?")) == DialogResult.Yes)
			{
				File.WriteAllLines(text, E917759F.Lines);
				MessageBoxHelper.Show(Language.GetValue("Lưu thành công!"));
				method_1(2);
			}
		}
		catch
		{
			MessageBoxHelper.Show(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void btnHuy_Click(object sender, EventArgs e)
	{
		try
		{
			string text = BE8D9790.SelectedRows[0].Cells["cName"].Value.ToString();
			Common.smethod_14(text);
			if (MessageBoxHelper.smethod_1(Language.GetValue("Bạn có muốn hủy?")) == DialogResult.Yes)
			{
				if (bool_0)
				{
					File.Delete(text);
				}
				method_1(2);
				F4B60582(B02A9C3B);
			}
		}
		catch
		{
			MessageBoxHelper.Show(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && AFA3F20B != null)
		{
			AFA3F20B.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		AFA3F20B = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		CEA95F18 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		DABC271E = new System.Windows.Forms.GroupBox();
		BE8D9790 = new System.Windows.Forms.DataGridView();
		cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
		FBA34A34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		CE2C1DB6 = new System.Windows.Forms.DataGridViewButtonColumn();
		cSua = new System.Windows.Forms.DataGridViewButtonColumn();
		F9A54D31 = new System.Windows.Forms.DataGridViewButtonColumn();
		EC182086 = new System.Windows.Forms.Button();
		C127CE13 = new System.Windows.Forms.GroupBox();
		E917759F = new System.Windows.Forms.TextBox();
		btnSave = new System.Windows.Forms.Button();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		B783CF0C = new System.Windows.Forms.PictureBox();
		E50EE48E = new System.Windows.Forms.Button();
		lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		AA3FCC19 = new Bunifu.Framework.UI.BunifuDragControl(AFA3F20B);
		toolTip_0 = new System.Windows.Forms.ToolTip(AFA3F20B);
		btnHuy = new System.Windows.Forms.Button();
		panel1.SuspendLayout();
		DABC271E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BE8D9790).BeginInit();
		C127CE13.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B783CF0C).BeginInit();
		SuspendLayout();
		CEA95F18.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CEA95F18.BackColor = System.Drawing.Color.White;
		CEA95F18.BorderRadius = 5;
		CEA95F18.BottomSahddow = true;
		CEA95F18.color = System.Drawing.Color.SaddleBrown;
		CEA95F18.LeftSahddow = false;
		CEA95F18.Location = new System.Drawing.Point(0, 0);
		CEA95F18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		CEA95F18.Name = "bunifuCards1";
		CEA95F18.RightSahddow = true;
		CEA95F18.ShadowDepth = 20;
		CEA95F18.Size = new System.Drawing.Size(425, 47);
		CEA95F18.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(DABC271E);
		panel1.Controls.Add(C127CE13);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(754, 388);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		DABC271E.Controls.Add(BE8D9790);
		DABC271E.Controls.Add(EC182086);
		DABC271E.Location = new System.Drawing.Point(3, 43);
		DABC271E.Name = "groupBox1";
		DABC271E.Size = new System.Drawing.Size(284, 339);
		DABC271E.TabIndex = 50;
		DABC271E.TabStop = false;
		DABC271E.Text = " Danh sa\u0301ch nô\u0323i dung";
		BE8D9790.AllowUserToAddRows = false;
		BE8D9790.AllowUserToDeleteRows = false;
		BE8D9790.AllowUserToResizeRows = false;
		BE8D9790.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		BE8D9790.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		BE8D9790.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		BE8D9790.Columns.AddRange(cSTT, FBA34A34, CE2C1DB6, cSua, F9A54D31);
		BE8D9790.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		BE8D9790.Location = new System.Drawing.Point(6, 22);
		BE8D9790.Name = "dtgvDanhSach";
		BE8D9790.RowHeadersVisible = false;
		BE8D9790.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		BE8D9790.Size = new System.Drawing.Size(272, 277);
		BE8D9790.TabIndex = 76;
		BE8D9790.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(BE8D9790_CellContentClick);
		BE8D9790.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(BE8D9790_CellMouseEnter);
		BE8D9790.MouseHover += new System.EventHandler(ED863DBE);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		cSTT.DefaultCellStyle = dataGridViewCellStyle2;
		cSTT.HeaderText = "STT";
		cSTT.Name = "cSTT";
		cSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		cSTT.Width = 40;
		FBA34A34.HeaderText = "Tên file";
		FBA34A34.Name = "cName";
		FBA34A34.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		FBA34A34.Visible = false;
		CE2C1DB6.HeaderText = "Chi tiê\u0301t";
		CE2C1DB6.Name = "cChiTiet";
		CE2C1DB6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		CE2C1DB6.Width = 80;
		cSua.HeaderText = "Sư\u0309a";
		cSua.Name = "cSua";
		cSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		cSua.Width = 71;
		F9A54D31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		F9A54D31.HeaderText = "Xo\u0301a";
		F9A54D31.Name = "cXoa";
		F9A54D31.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		EC182086.BackColor = System.Drawing.Color.Green;
		EC182086.Cursor = System.Windows.Forms.Cursors.Hand;
		EC182086.FlatAppearance.BorderSize = 0;
		EC182086.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EC182086.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EC182086.ForeColor = System.Drawing.Color.White;
		EC182086.Location = new System.Drawing.Point(186, 303);
		EC182086.Name = "btnAdd";
		EC182086.Size = new System.Drawing.Size(92, 29);
		EC182086.TabIndex = 45;
		EC182086.Text = "Thêm";
		EC182086.UseVisualStyleBackColor = false;
		EC182086.Click += new System.EventHandler(D59D4484);
		C127CE13.Controls.Add(E917759F);
		C127CE13.Controls.Add(btnHuy);
		C127CE13.Controls.Add(btnSave);
		C127CE13.Location = new System.Drawing.Point(293, 43);
		C127CE13.Name = "groupBox2";
		C127CE13.Size = new System.Drawing.Size(455, 339);
		C127CE13.TabIndex = 50;
		C127CE13.TabStop = false;
		C127CE13.Text = "Chi tiê\u0301t";
		E917759F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E917759F.Location = new System.Drawing.Point(5, 22);
		E917759F.Multiline = true;
		E917759F.Name = "txtContent";
		E917759F.ReadOnly = true;
		E917759F.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		E917759F.Size = new System.Drawing.Size(444, 277);
		E917759F.TabIndex = 48;
		E917759F.WordWrap = false;
		E917759F.TextChanged += new System.EventHandler(DF2C80A9);
		btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		btnSave.Enabled = false;
		btnSave.FlatAppearance.BorderSize = 0;
		btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnSave.ForeColor = System.Drawing.Color.White;
		btnSave.Location = new System.Drawing.Point(256, 304);
		btnSave.Name = "btnSave";
		btnSave.Size = new System.Drawing.Size(92, 29);
		btnSave.TabIndex = 45;
		btnSave.Text = "Lưu";
		btnSave.UseVisualStyleBackColor = false;
		btnSave.Click += new System.EventHandler(btnSave_Click);
		bunifuCards2.BackColor = System.Drawing.Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new System.Drawing.Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new System.Drawing.Size(752, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(B783CF0C);
		pnlHeader.Controls.Add(E50EE48E);
		pnlHeader.Controls.Add(lblTitle);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(752, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = Resource.Bitmap_9;
		button2.Location = new System.Drawing.Point(721, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		B783CF0C.Cursor = System.Windows.Forms.Cursors.Default;
		B783CF0C.Image = Resource.AC35C73C;
		B783CF0C.Location = new System.Drawing.Point(3, 2);
		B783CF0C.Name = "pictureBox1";
		B783CF0C.Size = new System.Drawing.Size(34, 27);
		B783CF0C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B783CF0C.TabIndex = 76;
		B783CF0C.TabStop = false;
		E50EE48E.Cursor = System.Windows.Forms.Cursors.Hand;
		E50EE48E.FlatAppearance.BorderSize = 0;
		E50EE48E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E50EE48E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E50EE48E.ForeColor = System.Drawing.Color.White;
		E50EE48E.Location = new System.Drawing.Point(899, 1);
		E50EE48E.Name = "btnMinimize";
		E50EE48E.Size = new System.Drawing.Size(30, 30);
		E50EE48E.TabIndex = 9;
		E50EE48E.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		E50EE48E.UseVisualStyleBackColor = true;
		lblTitle.BackColor = System.Drawing.Color.Transparent;
		lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
		lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblTitle.ForeColor = System.Drawing.Color.Black;
		lblTitle.Location = new System.Drawing.Point(0, 0);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new System.Drawing.Size(752, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Nhập nội dung comment";
		lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		AA3FCC19.Fixed = true;
		AA3FCC19.Horizontal = true;
		AA3FCC19.TargetControl = lblTitle;
		AA3FCC19.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		btnHuy.BackColor = System.Drawing.Color.FromArgb(128, 64, 0);
		btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
		btnHuy.Enabled = false;
		btnHuy.FlatAppearance.BorderSize = 0;
		btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnHuy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnHuy.ForeColor = System.Drawing.Color.White;
		btnHuy.Location = new System.Drawing.Point(357, 304);
		btnHuy.Name = "btnHuy";
		btnHuy.Size = new System.Drawing.Size(92, 29);
		btnHuy.TabIndex = 45;
		btnHuy.Text = "Hủy";
		btnHuy.UseVisualStyleBackColor = false;
		btnHuy.Click += new System.EventHandler(btnHuy_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(754, 388);
		base.Controls.Add(panel1);
		base.Controls.Add(CEA95F18);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fNhapDuLieu2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fNhapDuLieu2_Load);
		panel1.ResumeLayout(false);
		DABC271E.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)BE8D9790).EndInit();
		C127CE13.ResumeLayout(false);
		C127CE13.PerformLayout();
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)B783CF0C).EndInit();
		ResumeLayout(false);
	}
}
