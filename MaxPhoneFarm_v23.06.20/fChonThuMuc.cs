using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonThuMuc : Form
{
	internal bool bool_0 = false;

	internal static List<string> list_0;

	internal static List<string> F5BA2A9C;

	internal static bool bool_1;

	internal IContainer C12C3799 = null;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button B69A803D;

	internal Button ECBAD533;

	internal Button btnAdd;

	internal BunifuDragControl E79C452B;

	internal PictureBox EC1AF383;

	internal Label B596C284;

	internal Label lblCountTotal;

	internal Label D8BC1B2F;

	internal Label lblCountChoose;

	internal Label label2;

	internal DataGridView C5345B90;

	internal CheckBox checkBox1;

	internal DataGridViewCheckBoxColumn cChose;

	internal DataGridViewTextBoxColumn EE078EA4;

	internal DataGridViewTextBoxColumn cId;

	internal DataGridViewTextBoxColumn B291E733;

	internal Button CA3B3E26;

	internal Button button5;

	public fChonThuMuc(bool bool_2 = false)
	{
		InitializeComponent();
		bool_1 = false;
		bool_0 = bool_2;
	}

	private void B69A803D_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		bool_1 = true;
		if (bool_0)
		{
			F5BA2A9C = new List<string>();
			for (int i = 0; i < C5345B90.Rows.Count; i++)
			{
				if (Convert.ToBoolean(C5345B90.Rows[i].Cells["cChose"].Value))
				{
					F5BA2A9C.Add(DatagridviewHelper.E83E252C(C5345B90, i, "cId"));
				}
			}
			if (F5BA2A9C.Count == 0)
			{
				MessageBoxHelper.Show("Vui lòng chọn ít nhất 1 thư mục!", 2);
				return;
			}
		}
		else
		{
			list_0 = new List<string>();
			for (int j = 0; j < C5345B90.Rows.Count; j++)
			{
				if (Convert.ToBoolean(C5345B90.Rows[j].Cells["cChose"].Value))
				{
					list_0.Add(DatagridviewHelper.E83E252C(C5345B90, j, "cId"));
				}
			}
			if (list_0.Count == 0)
			{
				MessageBoxHelper.Show("Vui lòng chọn ít nhất 1 thư mục!", 2);
				return;
			}
		}
		Close();
	}

	private void ECBAD533_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fChonThuMuc_Load(object sender, EventArgs e)
	{
		if (bool_0)
		{
			if (F5BA2A9C == null)
			{
				F5BA2A9C = new List<string>();
			}
			method_0(F5BA2A9C);
		}
		else
		{
			if (list_0 == null)
			{
				list_0 = new List<string>();
			}
			method_0(list_0);
		}
	}

	private void method_0(List<string> list_1 = null)
	{
		try
		{
			DataTable dataTable = ((!bool_0) ? CommonSQL.smethod_0() : CommonSQL.smethod_1());
			if (list_1 != null && list_1.Count > 0)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					if (list_1.Contains(dataTable.Rows[i]["id"].ToString()))
					{
						C5345B90.Rows.Add(true, i + 1, dataTable.Rows[i]["id"], dataTable.Rows[i]["name"]);
					}
					else
					{
						C5345B90.Rows.Add(false, i + 1, dataTable.Rows[i]["id"], dataTable.Rows[i]["name"]);
					}
				}
			}
			else
			{
				for (int j = 0; j < dataTable.Rows.Count; j++)
				{
					C5345B90.Rows.Add(false, j + 1, dataTable.Rows[j]["id"], dataTable.Rows[j]["name"]);
				}
			}
			E5A1541D();
			F734DF03();
			if (ED823A20() == C5345B90.RowCount)
			{
				checkBox1.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
			}
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "LoadListFiles");
			MessageBoxHelper.Show("Có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void E5A1541D()
	{
		try
		{
			lblCountChoose.Text = ED823A20().ToString();
		}
		catch
		{
		}
	}

	private void C5345B90_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex > -1)
		{
			E5A1541D();
			if (ED823A20() == C5345B90.RowCount)
			{
				checkBox1.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
			}
		}
	}

	private void F734DF03()
	{
		try
		{
			lblCountTotal.Text = C5345B90.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void AF918B36(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (Convert.ToBoolean(C5345B90.CurrentRow.Cells["cChose"].Value))
			{
				C5345B90.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				C5345B90.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private int ED823A20()
	{
		int num = 0;
		for (int i = 0; i < C5345B90.Rows.Count; i++)
		{
			if (Convert.ToBoolean(C5345B90.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		return num;
	}

	private void C5345B90_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0 || e.RowIndex <= -1)
		{
			return;
		}
		try
		{
			if (Convert.ToBoolean(C5345B90.CurrentRow.Cells["cChose"].Value))
			{
				C5345B90.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				C5345B90.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private void checkBox1_Click(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			for (int i = 0; i < C5345B90.Rows.Count; i++)
			{
				DatagridviewHelper.AD3DF791(C5345B90, i, "cChose", true);
			}
		}
		else
		{
			for (int j = 0; j < C5345B90.Rows.Count; j++)
			{
				DatagridviewHelper.AD3DF791(C5345B90, j, "cChose", false);
			}
		}
	}

	private void D3090AAB(object sender, EventArgs e)
	{
		int index = C5345B90.SelectedRows[0].Index;
		if (index == 0)
		{
			return;
		}
		string text = DatagridviewHelper.E83E252C(C5345B90, index - 1, "cId");
		string text2 = DatagridviewHelper.E83E252C(C5345B90, index, "cId");
		if (text + text2 != "")
		{
			if (CommonSQL.BD33A63D(text, text2))
			{
				Common.E93D873E(ref C5345B90, index, index - 1, 2);
				C5345B90.ClearSelection();
				C5345B90.Rows[index - 1].Selected = true;
			}
			else
			{
				MessageBoxHelper.Show("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void CA3B3E26_Click(object sender, EventArgs e)
	{
		int index = C5345B90.SelectedRows[0].Index;
		if (index == C5345B90.RowCount - 1)
		{
			return;
		}
		string text = DatagridviewHelper.E83E252C(C5345B90, index + 1, "cId");
		string text2 = DatagridviewHelper.E83E252C(C5345B90, index, "cId");
		if (text + text2 != "")
		{
			if (CommonSQL.BD33A63D(text, text2))
			{
				Common.E93D873E(ref C5345B90, index, index + 1, 2);
				C5345B90.ClearSelection();
				C5345B90.Rows[index + 1].Selected = true;
			}
			else
			{
				MessageBoxHelper.Show("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void C5345B90_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			for (int i = 0; i < C5345B90.SelectedRows.Count; i++)
			{
				int index = C5345B90.SelectedRows[i].Index;
				DatagridviewHelper.AD3DF791(C5345B90, index, "cChose", !Convert.ToBoolean(DatagridviewHelper.E83E252C(C5345B90, index, "cChose")));
			}
			ED823A20();
		}
	}

	protected override void Dispose(bool AE8BFD38)
	{
		if (AE8BFD38 && C12C3799 != null)
		{
			C12C3799.Dispose();
		}
		base.Dispose(AE8BFD38);
	}

	private void InitializeComponent()
	{
		C12C3799 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonThuMuc));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		EC1AF383 = new System.Windows.Forms.PictureBox();
		B69A803D = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		ECBAD533 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		E79C452B = new Bunifu.Framework.UI.BunifuDragControl(C12C3799);
		B596C284 = new System.Windows.Forms.Label();
		lblCountTotal = new System.Windows.Forms.Label();
		D8BC1B2F = new System.Windows.Forms.Label();
		lblCountChoose = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		C5345B90 = new System.Windows.Forms.DataGridView();
		cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		EE078EA4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B291E733 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		checkBox1 = new System.Windows.Forms.CheckBox();
		CA3B3E26 = new System.Windows.Forms.Button();
		button5 = new System.Windows.Forms.Button();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)EC1AF383).BeginInit();
		((System.ComponentModel.ISupportInitialize)C5345B90).BeginInit();
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
		bunifuCards1.Size = new System.Drawing.Size(487, 34);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(EC1AF383);
		pnlHeader.Controls.Add(B69A803D);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(487, 28);
		pnlHeader.TabIndex = 9;
		EC1AF383.Cursor = System.Windows.Forms.Cursors.Default;
		EC1AF383.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		EC1AF383.Location = new System.Drawing.Point(3, 2);
		EC1AF383.Name = "pictureBox1";
		EC1AF383.Size = new System.Drawing.Size(34, 27);
		EC1AF383.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		EC1AF383.TabIndex = 17;
		EC1AF383.TabStop = false;
		B69A803D.Cursor = System.Windows.Forms.Cursors.Hand;
		B69A803D.Dock = System.Windows.Forms.DockStyle.Right;
		B69A803D.FlatAppearance.BorderSize = 0;
		B69A803D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B69A803D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B69A803D.ForeColor = System.Drawing.Color.White;
		B69A803D.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		B69A803D.Location = new System.Drawing.Point(455, 0);
		B69A803D.Name = "btnMinimize";
		B69A803D.Size = new System.Drawing.Size(32, 28);
		B69A803D.TabIndex = 9;
		B69A803D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B69A803D.UseVisualStyleBackColor = true;
		B69A803D.Click += new System.EventHandler(B69A803D_Click);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(487, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Chọn Danh sách thư mục";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ECBAD533.BackColor = System.Drawing.Color.Maroon;
		ECBAD533.Cursor = System.Windows.Forms.Cursors.Hand;
		ECBAD533.FlatAppearance.BorderSize = 0;
		ECBAD533.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		ECBAD533.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		ECBAD533.ForeColor = System.Drawing.Color.White;
		ECBAD533.Location = new System.Drawing.Point(248, 374);
		ECBAD533.Name = "btnCancel";
		ECBAD533.Size = new System.Drawing.Size(92, 29);
		ECBAD533.TabIndex = 4;
		ECBAD533.Text = "Đo\u0301ng";
		ECBAD533.UseVisualStyleBackColor = false;
		ECBAD533.Click += new System.EventHandler(ECBAD533_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(144, 374);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		E79C452B.Fixed = true;
		E79C452B.Horizontal = true;
		E79C452B.TargetControl = bunifuCustomLabel1;
		E79C452B.Vertical = true;
		B596C284.AutoSize = true;
		B596C284.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B596C284.Location = new System.Drawing.Point(263, 346);
		B596C284.Name = "label1";
		B596C284.Size = new System.Drawing.Size(58, 16);
		B596C284.TabIndex = 6;
		B596C284.Text = "Tổng số:";
		lblCountTotal.AutoSize = true;
		lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblCountTotal.ForeColor = System.Drawing.Color.DarkRed;
		lblCountTotal.Location = new System.Drawing.Point(321, 347);
		lblCountTotal.Name = "lblCountTotal";
		lblCountTotal.Size = new System.Drawing.Size(14, 16);
		lblCountTotal.TabIndex = 6;
		lblCountTotal.Text = "0";
		D8BC1B2F.AutoSize = true;
		D8BC1B2F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D8BC1B2F.Location = new System.Drawing.Point(128, 346);
		D8BC1B2F.Name = "label3";
		D8BC1B2F.Size = new System.Drawing.Size(59, 16);
		D8BC1B2F.TabIndex = 6;
		D8BC1B2F.Text = "Đã chọn:";
		lblCountChoose.AutoSize = true;
		lblCountChoose.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblCountChoose.ForeColor = System.Drawing.Color.DarkGreen;
		lblCountChoose.Location = new System.Drawing.Point(186, 347);
		lblCountChoose.Name = "lblCountChoose";
		lblCountChoose.Size = new System.Drawing.Size(14, 16);
		lblCountChoose.TabIndex = 6;
		lblCountChoose.Text = "0";
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.ForeColor = System.Drawing.Color.DarkRed;
		label2.Location = new System.Drawing.Point(12, 320);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(177, 16);
		label2.TabIndex = 6;
		label2.Text = "(Click đúp vào dòng để chọn!)";
		C5345B90.AllowUserToAddRows = false;
		C5345B90.AllowUserToDeleteRows = false;
		C5345B90.AllowUserToResizeRows = false;
		C5345B90.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		C5345B90.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		C5345B90.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		C5345B90.Columns.AddRange(cChose, EE078EA4, cId, B291E733);
		C5345B90.Location = new System.Drawing.Point(15, 40);
		C5345B90.Name = "dtgvAcc";
		C5345B90.ReadOnly = true;
		C5345B90.RowHeadersVisible = false;
		C5345B90.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		C5345B90.Size = new System.Drawing.Size(415, 277);
		C5345B90.TabIndex = 7;
		C5345B90.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(C5345B90_CellClick);
		C5345B90.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(AF918B36);
		C5345B90.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(C5345B90_CellValueChanged);
		C5345B90.KeyDown += new System.Windows.Forms.KeyEventHandler(C5345B90_KeyDown);
		cChose.HeaderText = "";
		cChose.Name = "cChose";
		cChose.ReadOnly = true;
		cChose.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		cChose.Width = 30;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		EE078EA4.DefaultCellStyle = dataGridViewCellStyle2;
		EE078EA4.HeaderText = "STT";
		EE078EA4.Name = "cStt";
		EE078EA4.ReadOnly = true;
		EE078EA4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		EE078EA4.Width = 35;
		cId.HeaderText = "Id";
		cId.Name = "cId";
		cId.ReadOnly = true;
		cId.Visible = false;
		cId.Width = 90;
		B291E733.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		B291E733.HeaderText = "Thư mục";
		B291E733.Name = "cThuMuc";
		B291E733.ReadOnly = true;
		checkBox1.AutoSize = true;
		checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		checkBox1.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		checkBox1.Location = new System.Drawing.Point(25, 45);
		checkBox1.Name = "checkBox1";
		checkBox1.Size = new System.Drawing.Size(15, 14);
		checkBox1.TabIndex = 8;
		checkBox1.UseVisualStyleBackColor = true;
		checkBox1.Click += new System.EventHandler(checkBox1_Click);
		CA3B3E26.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		CA3B3E26.Cursor = System.Windows.Forms.Cursors.Hand;
		CA3B3E26.Image = Resource.F385FA99;
		CA3B3E26.Location = new System.Drawing.Point(436, 85);
		CA3B3E26.Name = "button4";
		CA3B3E26.Size = new System.Drawing.Size(41, 38);
		CA3B3E26.TabIndex = 81;
		CA3B3E26.UseVisualStyleBackColor = true;
		CA3B3E26.Click += new System.EventHandler(CA3B3E26_Click);
		button5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button5.Cursor = System.Windows.Forms.Cursors.Hand;
		button5.Image = Resource.BB37B2AA;
		button5.Location = new System.Drawing.Point(436, 40);
		button5.Name = "button5";
		button5.Size = new System.Drawing.Size(41, 38);
		button5.TabIndex = 82;
		button5.UseVisualStyleBackColor = true;
		button5.Click += new System.EventHandler(D3090AAB);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(487, 415);
		base.Controls.Add(CA3B3E26);
		base.Controls.Add(button5);
		base.Controls.Add(checkBox1);
		base.Controls.Add(C5345B90);
		base.Controls.Add(lblCountChoose);
		base.Controls.Add(label2);
		base.Controls.Add(lblCountTotal);
		base.Controls.Add(D8BC1B2F);
		base.Controls.Add(B596C284);
		base.Controls.Add(ECBAD533);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fChonThuMuc";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fChonThuMuc_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)EC1AF383).EndInit();
		((System.ComponentModel.ISupportInitialize)C5345B90).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
