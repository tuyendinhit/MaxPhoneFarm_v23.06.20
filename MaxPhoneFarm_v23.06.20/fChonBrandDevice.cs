using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonBrandDevice : Form
{
	internal List<string> list_0 = new List<string>();

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel A3BEF4AF;

	internal BunifuCustomLabel C7165F9F;

	internal Button btnMinimize;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuDragControl C9256A9B;

	internal PictureBox C590AA9C;

	internal Label EB000B87;

	internal Label C4A1D20B;

	internal Label label3;

	internal Label D38BA829;

	internal Label A11E0E20;

	internal DataGridView dtgvAcc;

	internal CheckBox checkBox1;

	internal DataGridViewCheckBoxColumn F63D2503;

	internal DataGridViewTextBoxColumn cStt;

	internal DataGridViewTextBoxColumn cBrandDevice;

	internal Panel panel1;

	public fChonBrandDevice(List<string> D5016B1F)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		list_0 = D5016B1F;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		list_0 = new List<string>();
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				list_0.Add(DatagridviewHelper.E83E252C(dtgvAcc, i, "cBrandDevice"));
			}
		}
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fChonBrandDevice_Load(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		try
		{
			List<string> list = new List<string>
			{
				"vsmart", "google", "samsung", "LGE", "YuLong", "OPPO", "vivo", "realme", "Xiaomi", "Redmi",
				"Asus", "Huawei", "Sony", "Sharp", "motorola", "Fujitsu", "Kyocera", "FREETEL", "Nokia", "ZTE",
				"Lenovo", "HONOR", "HTC", "Essential", "Verizon", "Panasonic", "VAIO", "micromax", "MetroPCS", "NEC"
			};
			for (int i = 0; i < list.Count; i++)
			{
				dtgvAcc.Rows.Add(list_0.Contains(list[i]), i + 1, list[i]);
			}
			method_1();
			method_2();
			if (method_3() == dtgvAcc.RowCount)
			{
				checkBox1.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
			}
		}
		catch (Exception)
		{
			MessageBoxHelper.Show(Language.GetValue("Có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void method_1()
	{
		try
		{
			D38BA829.Text = method_3().ToString();
		}
		catch
		{
		}
	}

	private void dtgvAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0)
		{
			method_1();
			if (method_3() == dtgvAcc.RowCount)
			{
				checkBox1.Checked = true;
			}
			else
			{
				checkBox1.Checked = false;
			}
		}
	}

	private void method_2()
	{
		try
		{
			C4A1D20B.Text = dtgvAcc.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
		}
		catch
		{
		}
	}

	private int method_3()
	{
		int num = 0;
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		return num;
	}

	private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0)
		{
			return;
		}
		try
		{
			if (Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value))
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private void D020B01B(object sender, EventArgs e)
	{
		if (checkBox1.Checked)
		{
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				DatagridviewHelper.AD3DF791(dtgvAcc, i, "cChose", true);
			}
		}
		else
		{
			for (int j = 0; j < dtgvAcc.Rows.Count; j++)
			{
				DatagridviewHelper.AD3DF791(dtgvAcc, j, "cChose", false);
			}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonBrandDevice));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		A3BEF4AF = new System.Windows.Forms.Panel();
		C590AA9C = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		C7165F9F = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		C9256A9B = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		EB000B87 = new System.Windows.Forms.Label();
		C4A1D20B = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		D38BA829 = new System.Windows.Forms.Label();
		A11E0E20 = new System.Windows.Forms.Label();
		dtgvAcc = new System.Windows.Forms.DataGridView();
		F63D2503 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cBrandDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
		checkBox1 = new System.Windows.Forms.CheckBox();
		panel1 = new System.Windows.Forms.Panel();
		bunifuCards1.SuspendLayout();
		A3BEF4AF.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C590AA9C).BeginInit();
		((System.ComponentModel.ISupportInitialize)dtgvAcc).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(A3BEF4AF);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(317, 34);
		bunifuCards1.TabIndex = 0;
		A3BEF4AF.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A3BEF4AF.BackColor = System.Drawing.Color.White;
		A3BEF4AF.Controls.Add(C590AA9C);
		A3BEF4AF.Controls.Add(btnMinimize);
		A3BEF4AF.Controls.Add(C7165F9F);
		A3BEF4AF.Location = new System.Drawing.Point(0, 3);
		A3BEF4AF.Name = "pnlHeader";
		A3BEF4AF.Size = new System.Drawing.Size(317, 28);
		A3BEF4AF.TabIndex = 9;
		C590AA9C.Cursor = System.Windows.Forms.Cursors.Default;
		C590AA9C.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		C590AA9C.Location = new System.Drawing.Point(3, 2);
		C590AA9C.Name = "pictureBox1";
		C590AA9C.Size = new System.Drawing.Size(34, 27);
		C590AA9C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		C590AA9C.TabIndex = 17;
		C590AA9C.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(285, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 28);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		C7165F9F.BackColor = System.Drawing.Color.Transparent;
		C7165F9F.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C7165F9F.Dock = System.Windows.Forms.DockStyle.Fill;
		C7165F9F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C7165F9F.ForeColor = System.Drawing.Color.Black;
		C7165F9F.Location = new System.Drawing.Point(0, 0);
		C7165F9F.Name = "bunifuCustomLabel1";
		C7165F9F.Size = new System.Drawing.Size(317, 28);
		C7165F9F.TabIndex = 1;
		C7165F9F.Text = "Chọn Danh sách brand device";
		C7165F9F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(156, 280);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(52, 280);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		C9256A9B.Fixed = true;
		C9256A9B.Horizontal = true;
		C9256A9B.TargetControl = C7165F9F;
		C9256A9B.Vertical = true;
		EB000B87.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EB000B87.Location = new System.Drawing.Point(153, 252);
		EB000B87.Name = "label1";
		EB000B87.Size = new System.Drawing.Size(59, 16);
		EB000B87.TabIndex = 6;
		EB000B87.Text = "Tổng số:";
		EB000B87.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		C4A1D20B.AutoSize = true;
		C4A1D20B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C4A1D20B.ForeColor = System.Drawing.Color.DarkRed;
		C4A1D20B.Location = new System.Drawing.Point(211, 253);
		C4A1D20B.Name = "lblCountTotal";
		C4A1D20B.Size = new System.Drawing.Size(14, 16);
		C4A1D20B.TabIndex = 6;
		C4A1D20B.Text = "0";
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(49, 252);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(59, 16);
		label3.TabIndex = 6;
		label3.Text = "Đã chọn:";
		D38BA829.AutoSize = true;
		D38BA829.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D38BA829.ForeColor = System.Drawing.Color.DarkGreen;
		D38BA829.Location = new System.Drawing.Point(107, 253);
		D38BA829.Name = "lblCountChoose";
		D38BA829.Size = new System.Drawing.Size(14, 16);
		D38BA829.TabIndex = 6;
		D38BA829.Text = "0";
		A11E0E20.AutoSize = true;
		A11E0E20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A11E0E20.ForeColor = System.Drawing.Color.DarkRed;
		A11E0E20.Location = new System.Drawing.Point(12, 227);
		A11E0E20.Name = "label2";
		A11E0E20.Size = new System.Drawing.Size(177, 16);
		A11E0E20.TabIndex = 6;
		A11E0E20.Text = "(Click đúp vào dòng để chọn!)";
		dtgvAcc.AllowUserToAddRows = false;
		dtgvAcc.AllowUserToDeleteRows = false;
		dtgvAcc.AllowUserToResizeRows = false;
		dtgvAcc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvAcc.Columns.AddRange(F63D2503, cStt, cBrandDevice);
		dtgvAcc.Location = new System.Drawing.Point(15, 40);
		dtgvAcc.Name = "dtgvAcc";
		dtgvAcc.ReadOnly = true;
		dtgvAcc.RowHeadersVisible = false;
		dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dtgvAcc.Size = new System.Drawing.Size(287, 184);
		dtgvAcc.TabIndex = 7;
		dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellClick);
		dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellDoubleClick);
		dtgvAcc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellValueChanged);
		F63D2503.HeaderText = "";
		F63D2503.Name = "cChose";
		F63D2503.ReadOnly = true;
		F63D2503.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		F63D2503.Width = 30;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		cStt.DefaultCellStyle = dataGridViewCellStyle2;
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.ReadOnly = true;
		cStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		cStt.Width = 35;
		cBrandDevice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cBrandDevice.HeaderText = "Brand Device";
		cBrandDevice.Name = "cBrandDevice";
		cBrandDevice.ReadOnly = true;
		checkBox1.AutoSize = true;
		checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
		checkBox1.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		checkBox1.Location = new System.Drawing.Point(25, 45);
		checkBox1.Name = "checkBox1";
		checkBox1.Size = new System.Drawing.Size(15, 14);
		checkBox1.TabIndex = 8;
		checkBox1.UseVisualStyleBackColor = true;
		checkBox1.Click += new System.EventHandler(D020B01B);
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(317, 322);
		panel1.TabIndex = 9;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(317, 322);
		base.Controls.Add(checkBox1);
		base.Controls.Add(dtgvAcc);
		base.Controls.Add(D38BA829);
		base.Controls.Add(A11E0E20);
		base.Controls.Add(C4A1D20B);
		base.Controls.Add(label3);
		base.Controls.Add(EB000B87);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fChonBrandDevice";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Chọn brand device";
		base.Load += new System.EventHandler(fChonBrandDevice_Load);
		bunifuCards1.ResumeLayout(false);
		A3BEF4AF.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)C590AA9C).EndInit();
		((System.ComponentModel.ISupportInitialize)dtgvAcc).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
