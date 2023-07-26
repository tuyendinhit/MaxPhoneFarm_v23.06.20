using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonKichBan : Form
{
	internal IContainer DD125AA2 = null;

	internal ToolTip F8BFD137;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal GroupBox groupBox1;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button button1;

	internal DataGridView dtgvKichBan;

	internal Panel panel1;

	internal Button button2;

	internal Button button3;

	internal GroupBox groupBox2;

	internal Label B525AD21;

	internal Button btnCancel;

	internal Button F203CE95;

	internal Label lblCountAcc;

	internal Label C3189088;

	internal Label label1;

	internal DataGridView dtgvKichBanChoose;

	internal DataGridViewTextBoxColumn cStt;

	internal DataGridViewTextBoxColumn D70E1DAC;

	internal DataGridViewTextBoxColumn cTenKichBan;

	internal DataGridViewTextBoxColumn C015F639;

	internal DataGridViewTextBoxColumn A33098B5;

	internal DataGridViewTextBoxColumn CD991FA8;

	public fChonKichBan()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void B402E794(object sender, EventArgs e)
	{
		CEBC70B5();
		CEBC70B5(SettingsTool.GetSettings("configInteractGeneral").EC378D8A("lstIdKichBan"));
	}

	private void CEBC70B5(List<string> BEB5A30F = null)
	{
		try
		{
			if (BEB5A30F != null && BEB5A30F.Count > 0)
			{
				dtgvKichBanChoose.Rows.Clear();
				for (int i = 0; i < BEB5A30F.Count; i++)
				{
					DataTable dataTable = Class123.D22C6CAB(BEB5A30F[i]);
					if (dataTable.Rows.Count > 0)
					{
						DataRow dataRow = dataTable.Rows[0];
						dtgvKichBanChoose.Rows.Add(dtgvKichBanChoose.RowCount + 1, dataRow["Id_KichBan"], dataRow["TenKichBan"]);
					}
				}
				return;
			}
			dtgvKichBan.Rows.Clear();
			DataTable dataTable2 = Class123.smethod_3();
			if (dataTable2.Rows.Count > 0)
			{
				for (int j = 0; j < dataTable2.Rows.Count; j++)
				{
					DataRow dataRow2 = dataTable2.Rows[j];
					dtgvKichBan.Rows.Add(j + 1, dataRow2["Id_KichBan"], dataRow2["TenKichBan"]);
				}
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
		}
	}

	private void E3001285(object sender, EventArgs e)
	{
		Close();
	}

	public void method_0(ref DataGridView D0A1091F, int E32E9718, int int_0)
	{
		string text = "";
		for (int i = 1; i < D0A1091F.Columns.Count; i++)
		{
			text = DatagridviewHelper.smethod_0(D0A1091F, E32E9718, i);
			DatagridviewHelper.smethod_1(D0A1091F, E32E9718, i, DatagridviewHelper.smethod_0(D0A1091F, int_0, i));
			DatagridviewHelper.smethod_1(D0A1091F, int_0, i, text);
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		int index = dtgvKichBanChoose.SelectedRows[0].Index;
		if (index != 0)
		{
			string text = DatagridviewHelper.E83E252C(dtgvKichBanChoose, index - 1, "cIdKichBanChoose");
			string text2 = DatagridviewHelper.E83E252C(dtgvKichBanChoose, index, "cIdKichBanChoose");
			if (text + text2 != "")
			{
				method_0(ref dtgvKichBanChoose, index, index - 1);
				dtgvKichBanChoose.Rows[index - 1].Selected = true;
			}
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		int index = dtgvKichBanChoose.SelectedRows[0].Index;
		if (index != dtgvKichBanChoose.RowCount - 1)
		{
			string text = DatagridviewHelper.E83E252C(dtgvKichBanChoose, index + 1, "cIdKichBanChoose");
			string text2 = DatagridviewHelper.E83E252C(dtgvKichBanChoose, index, "cIdKichBanChoose");
			if (text + text2 != "")
			{
				method_0(ref dtgvKichBanChoose, index, index + 1);
				dtgvKichBanChoose.Rows[index + 1].Selected = true;
			}
		}
	}

	private void B5A9C8AB(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private bool method_1(string string_0)
	{
		bool result = false;
		for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
		{
			if (string_0 == dtgvKichBanChoose.Rows[i].Cells[1].Value.ToString())
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void ED0768AC(object sender, DataGridViewCellEventArgs e)
	{
		int num = Convert.ToInt32(dtgvKichBan.SelectedRows[0].Cells[1].Value);
		string text = dtgvKichBan.SelectedRows[0].Cells[2].Value.ToString();
		if (!method_1(num.ToString()))
		{
			dtgvKichBanChoose.Rows.Add(dtgvKichBanChoose.RowCount + 1, num, text);
		}
	}

	private void EC35232F(object sender, DataGridViewCellEventArgs e)
	{
		dtgvKichBanChoose.Rows.RemoveAt(dtgvKichBanChoose.SelectedRows[0].Index);
		for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
		{
			DatagridviewHelper.AD3DF791(dtgvKichBanChoose, i, "cSTTChoose", i + 1);
		}
	}

	private void F203CE95_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvKichBanChoose.RowCount; i++)
			{
				list.Add(DatagridviewHelper.E83E252C(dtgvKichBanChoose, i, "cIdKichBanChoose"));
			}
			SettingsTool.GetSettings("configInteractGeneral").method_3("lstIdKichBan", list);
			SettingsTool.smethod_0("configInteractGeneral");
			Close();
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			MessageBoxHelper.Show(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 3);
		}
	}

	private void B23673AC(object sender, DataGridViewRowsAddedEventArgs e)
	{
		lblCountAcc.Text = dtgvKichBanChoose.RowCount.ToString();
	}

	private void dtgvKichBanChoose_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
	{
		lblCountAcc.Text = dtgvKichBanChoose.RowCount.ToString();
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && DD125AA2 != null)
		{
			DD125AA2.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		DD125AA2 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonKichBan));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		F8BFD137 = new System.Windows.Forms.ToolTip(DD125AA2);
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(DD125AA2);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(DD125AA2);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		groupBox1 = new System.Windows.Forms.GroupBox();
		B525AD21 = new System.Windows.Forms.Label();
		dtgvKichBan = new System.Windows.Forms.DataGridView();
		cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		D70E1DAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cTenKichBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		btnCancel = new System.Windows.Forms.Button();
		F203CE95 = new System.Windows.Forms.Button();
		groupBox2 = new System.Windows.Forms.GroupBox();
		lblCountAcc = new System.Windows.Forms.Label();
		C3189088 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		button3 = new System.Windows.Forms.Button();
		dtgvKichBanChoose = new System.Windows.Forms.DataGridView();
		C015F639 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		A33098B5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		CD991FA8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		button2 = new System.Windows.Forms.Button();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dtgvKichBan).BeginInit();
		bunifuCards1.SuspendLayout();
		panel1.SuspendLayout();
		groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dtgvKichBanChoose).BeginInit();
		SuspendLayout();
		F8BFD137.AutomaticDelay = 0;
		F8BFD137.AutoPopDelay = 10000;
		F8BFD137.InitialDelay = 200;
		F8BFD137.ReshowDelay = 40;
		F8BFD137.ToolTipTitle = "Chú thích";
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(696, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Chọn danh sách kịch bản chạy";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(696, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(667, 2);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(E3001285);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		groupBox1.BackColor = System.Drawing.Color.White;
		groupBox1.Controls.Add(B525AD21);
		groupBox1.Controls.Add(dtgvKichBan);
		groupBox1.Location = new System.Drawing.Point(12, 41);
		groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		groupBox1.Name = "groupBox1";
		groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		groupBox1.Size = new System.Drawing.Size(308, 302);
		groupBox1.TabIndex = 1;
		groupBox1.TabStop = false;
		groupBox1.Text = "Danh sách kịch bản";
		B525AD21.AutoSize = true;
		B525AD21.ForeColor = System.Drawing.Color.Red;
		B525AD21.Location = new System.Drawing.Point(3, 281);
		B525AD21.Name = "label2";
		B525AD21.Size = new System.Drawing.Size(193, 16);
		B525AD21.TabIndex = 81;
		B525AD21.Text = "(Click đúp vào kịch bản để chọn)";
		dtgvKichBan.AllowUserToAddRows = false;
		dtgvKichBan.AllowUserToDeleteRows = false;
		dtgvKichBan.AllowUserToResizeRows = false;
		dtgvKichBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dtgvKichBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dtgvKichBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvKichBan.Columns.AddRange(cStt, D70E1DAC, cTenKichBan);
		dtgvKichBan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		dtgvKichBan.Location = new System.Drawing.Point(6, 20);
		dtgvKichBan.MultiSelect = false;
		dtgvKichBan.Name = "dtgvKichBan";
		dtgvKichBan.RowHeadersVisible = false;
		dtgvKichBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dtgvKichBan.Size = new System.Drawing.Size(296, 258);
		dtgvKichBan.TabIndex = 76;
		dtgvKichBan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(ED0768AC);
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.Width = 35;
		D70E1DAC.HeaderText = "Id kịch bản";
		D70E1DAC.Name = "cIdKichBan";
		D70E1DAC.Visible = false;
		cTenKichBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cTenKichBan.HeaderText = "Tên kịch bản";
		cTenKichBan.Name = "cTenKichBan";
		cTenKichBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
		bunifuCards1.Size = new System.Drawing.Size(699, 37);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(F203CE95);
		panel1.Controls.Add(bunifuCards1);
		panel1.Controls.Add(groupBox2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(702, 391);
		panel1.TabIndex = 13;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(B5A9C8AB);
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(359, 350);
		btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 22;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		F203CE95.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		F203CE95.Cursor = System.Windows.Forms.Cursors.Hand;
		F203CE95.FlatAppearance.BorderSize = 0;
		F203CE95.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F203CE95.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F203CE95.ForeColor = System.Drawing.Color.White;
		F203CE95.Location = new System.Drawing.Point(252, 350);
		F203CE95.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		F203CE95.Name = "btnSave";
		F203CE95.Size = new System.Drawing.Size(92, 29);
		F203CE95.TabIndex = 21;
		F203CE95.Text = "Lưu";
		F203CE95.UseVisualStyleBackColor = false;
		F203CE95.Click += new System.EventHandler(F203CE95_Click);
		groupBox2.BackColor = System.Drawing.Color.White;
		groupBox2.Controls.Add(lblCountAcc);
		groupBox2.Controls.Add(C3189088);
		groupBox2.Controls.Add(label1);
		groupBox2.Controls.Add(button3);
		groupBox2.Controls.Add(dtgvKichBanChoose);
		groupBox2.Controls.Add(button2);
		groupBox2.Location = new System.Drawing.Point(325, 40);
		groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		groupBox2.Name = "groupBox2";
		groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
		groupBox2.Size = new System.Drawing.Size(363, 302);
		groupBox2.TabIndex = 1;
		groupBox2.TabStop = false;
		groupBox2.Text = "Kịch bản cần chạy";
		lblCountAcc.AutoSize = true;
		lblCountAcc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		lblCountAcc.ForeColor = System.Drawing.Color.Blue;
		lblCountAcc.Location = new System.Drawing.Point(297, 281);
		lblCountAcc.Name = "lblCountAcc";
		lblCountAcc.Size = new System.Drawing.Size(16, 16);
		lblCountAcc.TabIndex = 82;
		lblCountAcc.Text = "0";
		C3189088.AutoSize = true;
		C3189088.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		C3189088.Location = new System.Drawing.Point(255, 281);
		C3189088.Name = "label7";
		C3189088.Size = new System.Drawing.Size(44, 16);
		C3189088.TabIndex = 83;
		C3189088.Text = "Tổng:";
		label1.AutoSize = true;
		label1.ForeColor = System.Drawing.Color.Red;
		label1.Location = new System.Drawing.Point(4, 282);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(186, 16);
		label1.TabIndex = 81;
		label1.Text = "(Click đúp vào kịch bản để xóa)";
		button3.Cursor = System.Windows.Forms.Cursors.Hand;
		button3.Image = Resource.F385FA99;
		button3.Location = new System.Drawing.Point(314, 64);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(41, 38);
		button3.TabIndex = 78;
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		dtgvKichBanChoose.AllowUserToAddRows = false;
		dtgvKichBanChoose.AllowUserToDeleteRows = false;
		dtgvKichBanChoose.AllowUserToResizeRows = false;
		dtgvKichBanChoose.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dtgvKichBanChoose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		dtgvKichBanChoose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvKichBanChoose.Columns.AddRange(C015F639, A33098B5, CD991FA8);
		dtgvKichBanChoose.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		dtgvKichBanChoose.Location = new System.Drawing.Point(6, 20);
		dtgvKichBanChoose.MultiSelect = false;
		dtgvKichBanChoose.Name = "dtgvKichBanChoose";
		dtgvKichBanChoose.RowHeadersVisible = false;
		dtgvKichBanChoose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dtgvKichBanChoose.Size = new System.Drawing.Size(302, 258);
		dtgvKichBanChoose.TabIndex = 76;
		dtgvKichBanChoose.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(EC35232F);
		dtgvKichBanChoose.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(B23673AC);
		dtgvKichBanChoose.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(dtgvKichBanChoose_RowsRemoved);
		C015F639.HeaderText = "STT";
		C015F639.Name = "cSTTChoose";
		C015F639.Width = 35;
		A33098B5.HeaderText = "Id kịch bản";
		A33098B5.Name = "cIdKichBanChoose";
		A33098B5.Visible = false;
		CD991FA8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		CD991FA8.HeaderText = "Tên kịch bản";
		CD991FA8.Name = "cTenKichBanChoose";
		CD991FA8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.Image = Resource.BB37B2AA;
		button2.Location = new System.Drawing.Point(314, 19);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(41, 38);
		button2.TabIndex = 78;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(702, 391);
		base.Controls.Add(groupBox1);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fChonKichBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B402E794);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)dtgvKichBan).EndInit();
		bunifuCards1.ResumeLayout(false);
		panel1.ResumeLayout(false);
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)dtgvKichBanChoose).EndInit();
		ResumeLayout(false);
	}
}
