using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fQuanLyNhom : Form
{
	internal bool A12C5419 = false;

	internal List<string> list_0 = new List<string>();

	internal List<string> BB117B83 = new List<string>();

	internal IContainer EBB2F10B = null;

	internal BunifuCards bunifuCards1;

	internal Panel AEBA3FAB;

	internal BunifuCustomLabel B80F098B;

	internal Button btnMinimize;

	internal BunifuDragControl FB8EC034;

	internal PictureBox pictureBox1;

	internal ComboBox C78A178F;

	internal Label label1;

	internal DataGridView dtgvAcc;

	internal DataGridViewCheckBoxColumn AF338424;

	internal DataGridViewTextBoxColumn C6381B8C;

	internal DataGridViewTextBoxColumn cId;

	internal DataGridViewTextBoxColumn E51FE914;

	internal DataGridViewTextBoxColumn cThanhVien;

	internal DataGridViewTextBoxColumn cKiemDuyet;

	internal ContextMenuStrip ctmsAcc;

	internal ToolStripMenuItem CD2350A2;

	internal ToolStripMenuItem toolStripMenuItem_0;

	internal ToolStripMenuItem E61EEA38;

	internal ToolStripMenuItem tinhTrangToolStripMenuItem;

	internal ToolStripMenuItem D62B5280;

	internal ToolStripMenuItem toolStripMenuItem_1;

	internal ToolStripMenuItem toolStripMenuItem_2;

	internal ToolStripMenuItem BB3C10A0;

	internal ToolStripMenuItem trueToolStripMenuItem;

	internal ToolStripMenuItem falseToolStripMenuItem;

	internal StatusStrip statusStrip1;

	internal ToolStripStatusLabel toolStripStatusLabel4;

	internal ToolStripStatusLabel E8169EB1;

	internal ToolStripStatusLabel A90508BF;

	internal ToolStripStatusLabel D5AAD792;

	internal ToolStripStatusLabel toolStripStatusLabel2;

	internal ToolStripStatusLabel lblCountTotal;

	public fQuanLyNhom()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DB20F506(object sender, EventArgs e)
	{
		method_1();
		method_0();
	}

	private void method_0()
	{
		try
		{
			BB117B83 = new List<string>();
			list_0 = new List<string>();
			string path = "backupgroup";
			string[] files = Directory.GetFiles(path);
			foreach (string path2 in files)
			{
				List<string> list = File.ReadAllText(path2).Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
				for (int j = 0; j < list.Count; j++)
				{
					string text = list[j].Replace(" |", " *").Replace("| ", "* ");
					if (text.Split('|').Length < 4)
					{
						for (int num = 0; num < 4 - text.Split('|').Length; num++)
						{
							text += "|";
						}
					}
					if (!BB117B83.Contains(text.Split('|')[0]))
					{
						BB117B83.Add(text.Split('|')[0]);
						list_0.Add(text);
					}
				}
			}
			dtgvAcc.Rows.Clear();
			for (int k = 0; k < list_0.Count; k++)
			{
				string text2 = list_0[k];
				dtgvAcc.Rows.Add(false, dtgvAcc.RowCount + 1, text2.Split('|')[0], text2.Split('|')[1], text2.Split('|')[2], text2.Split('|')[3].ToUpper());
			}
			method_3();
		}
		catch
		{
		}
	}

	private void B6AB47B4()
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			DB9CD600(i, "cStt", i + 1);
		}
	}

	private void method_1()
	{
		List<string> f0B9E2B = new List<string> { "Tất cả", "Kiểm duyệt", "Không kiểm duyệt" };
		Common.BEBCBE97(C78A178F, f0B9E2B);
	}

	private void AB1C1085(object sender, EventArgs e)
	{
		method_0();
	}

	public void DB9CD600(int int_0, string string_0, object B824C41E)
	{
		DatagridviewHelper.AD3DF791(dtgvAcc, int_0, string_0, B824C41E);
	}

	public string method_2(int D2997A0F, string string_0)
	{
		return DatagridviewHelper.E83E252C(dtgvAcc, D2997A0F, string_0);
	}

	private void method_3()
	{
		try
		{
			lblCountTotal.Text = dtgvAcc.RowCount.ToString();
		}
		catch
		{
		}
	}

	private void method_4(int int_0 = -1)
	{
		if (int_0 == -1)
		{
			int_0 = 0;
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					int_0++;
				}
			}
		}
		D5AAD792.Text = int_0.ToString();
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			DB9CD600(i, "cChose", true);
		}
		method_4(dtgvAcc.RowCount);
	}

	private void D62B5280_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			DB9CD600(i, "cChose", false);
		}
		method_4(0);
	}

	private void E61EEA38_Click(object sender, EventArgs e)
	{
		DataGridViewSelectedRowCollection selectedRows = dtgvAcc.SelectedRows;
		for (int i = 0; i < selectedRows.Count; i++)
		{
			DB9CD600(selectedRows[i].Index, "cChose", true);
		}
		method_4();
	}

	private void trueToolStripMenuItem_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			DB9CD600(i, "cChose", method_2(i, "cKiemDuyet").ToLower() == "true");
		}
		method_4();
	}

	private void falseToolStripMenuItem_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			DB9CD600(i, "cChose", method_2(i, "cKiemDuyet").ToLower() == "false");
		}
		method_4();
	}

	private void E313039D(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			if (D5AAD792.Text == "0")
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn những dòng muốn copy!"), 3);
				return;
			}
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					text = text + method_2(i, "cId") + "\r\n";
				}
			}
			Common.SetTextToClipboard(text.TrimEnd('\r', '\n'));
		}
		catch
		{
		}
	}

	private void F32E190B(object sender, EventArgs e)
	{
		dtgvAcc.Rows.Clear();
		if (C78A178F.SelectedIndex == 0)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				string text = list_0[i];
				dtgvAcc.Rows.Add(false, dtgvAcc.RowCount + 1, text.Split('|')[0], text.Split('|')[1], text.Split('|')[2], text.Split('|')[3].ToUpper());
			}
		}
		else if (C78A178F.SelectedIndex == 1)
		{
			for (int j = 0; j < list_0.Count; j++)
			{
				string text2 = list_0[j];
				if (text2.Split('|')[3].ToLower() == "true")
				{
					dtgvAcc.Rows.Add(false, dtgvAcc.RowCount + 1, text2.Split('|')[0], text2.Split('|')[1], text2.Split('|')[2], text2.Split('|')[3].ToUpper());
				}
			}
		}
		else if (C78A178F.SelectedIndex == 2)
		{
			for (int k = 0; k < list_0.Count; k++)
			{
				string text3 = list_0[k];
				if (text3.Split('|')[3].ToLower() == "false")
				{
					dtgvAcc.Rows.Add(false, dtgvAcc.RowCount + 1, text3.Split('|')[0], text3.Split('|')[1], text3.Split('|')[2], text3.Split('|')[3].ToUpper());
				}
			}
		}
		method_4(0);
		method_3();
	}

	private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0)
		{
			try
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
				method_4();
			}
			catch
			{
			}
		}
	}

	private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
			method_4();
		}
		catch
		{
		}
	}

	private void dtgvAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void dtgvAcc_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			for (int i = 0; i < dtgvAcc.SelectedRows.Count; i++)
			{
				int index = dtgvAcc.SelectedRows[i].Index;
				DB9CD600(index, "cChose", !Convert.ToBoolean(method_2(index, "cChose")));
			}
			method_4();
		}
	}

	private void D986EB9E(object sender, EventArgs e)
	{
		E8169EB1.Text = dtgvAcc.SelectedRows.Count.ToString();
	}

	private void F1110D3D(object sender, DataGridViewSortCompareEventArgs e)
	{
		List<string> list = new List<string> { "cStt", "cThanhVien" };
		if (list.Contains(e.Column.Name))
		{
			string text = "";
			text = ((e.CellValue1.ToString().Trim() == "") ? "-2" : ((!Common.smethod_28(e.CellValue1.ToString())) ? "-1" : e.CellValue1.ToString()));
			string text2 = "";
			text2 = ((e.CellValue2.ToString().Trim() == "") ? "-2" : ((!Common.smethod_28(e.CellValue2.ToString())) ? "-1" : e.CellValue2.ToString()));
			e.SortResult = int.Parse(text).CompareTo(int.Parse(text2));
			e.Handled = true;
		}
		else
		{
			e.SortResult = ((e.CellValue1.ToString() == "") ? "" : e.CellValue1.ToString()).CompareTo((e.CellValue2.ToString() == "") ? "" : e.CellValue2.ToString());
			e.Handled = true;
		}
	}

	private void EC386282(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			DataObject dataObject = (DataObject)Clipboard.GetDataObject();
			string[] array = dataObject.GetData(DataFormats.Text).ToString().Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.Split('|').Length > 1 && !BB117B83.Contains(text.Split('|')[0]))
				{
					BB117B83.Add(text.Split('|')[0]);
					list_0.Add(text.Split('|')[0] + "|||" + text.Split('|')[1]);
					list.Add(text.Split('|')[0] + "|||" + text.Split('|')[1]);
					dtgvAcc.Rows.Add(false, dtgvAcc.RowCount + 1, text.Split('|')[0], "", "", text.Split('|')[1].ToUpper());
				}
			}
			File.AppendAllLines("backupgroup\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", list);
			method_3();
		}
		catch
		{
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && EBB2F10B != null)
		{
			EBB2F10B.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		EBB2F10B = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyNhom));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		AEBA3FAB = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		B80F098B = new Bunifu.Framework.UI.BunifuCustomLabel();
		FB8EC034 = new Bunifu.Framework.UI.BunifuDragControl(EBB2F10B);
		C78A178F = new System.Windows.Forms.ComboBox();
		label1 = new System.Windows.Forms.Label();
		dtgvAcc = new System.Windows.Forms.DataGridView();
		AF338424 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		C6381B8C = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		E51FE914 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cKiemDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
		ctmsAcc = new System.Windows.Forms.ContextMenuStrip(EBB2F10B);
		CD2350A2 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		E61EEA38 = new System.Windows.Forms.ToolStripMenuItem();
		tinhTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		trueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		falseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		D62B5280 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		BB3C10A0 = new System.Windows.Forms.ToolStripMenuItem();
		statusStrip1 = new System.Windows.Forms.StatusStrip();
		toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
		E8169EB1 = new System.Windows.Forms.ToolStripStatusLabel();
		A90508BF = new System.Windows.Forms.ToolStripStatusLabel();
		D5AAD792 = new System.Windows.Forms.ToolStripStatusLabel();
		toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountTotal = new System.Windows.Forms.ToolStripStatusLabel();
		bunifuCards1.SuspendLayout();
		AEBA3FAB.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)dtgvAcc).BeginInit();
		ctmsAcc.SuspendLayout();
		statusStrip1.SuspendLayout();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(AEBA3FAB);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(906, 38);
		bunifuCards1.TabIndex = 0;
		AEBA3FAB.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		AEBA3FAB.BackColor = System.Drawing.Color.White;
		AEBA3FAB.Controls.Add(pictureBox1);
		AEBA3FAB.Controls.Add(btnMinimize);
		AEBA3FAB.Controls.Add(B80F098B);
		AEBA3FAB.Location = new System.Drawing.Point(0, 5);
		AEBA3FAB.Name = "pnlHeader";
		AEBA3FAB.Size = new System.Drawing.Size(906, 32);
		AEBA3FAB.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(874, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		B80F098B.BackColor = System.Drawing.Color.Transparent;
		B80F098B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B80F098B.Dock = System.Windows.Forms.DockStyle.Fill;
		B80F098B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B80F098B.ForeColor = System.Drawing.Color.Black;
		B80F098B.Location = new System.Drawing.Point(0, 0);
		B80F098B.Name = "bunifuCustomLabel1";
		B80F098B.Size = new System.Drawing.Size(906, 32);
		B80F098B.TabIndex = 1;
		B80F098B.Text = "Quản lý nhóm";
		B80F098B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FB8EC034.Fixed = true;
		FB8EC034.Horizontal = true;
		FB8EC034.TargetControl = B80F098B;
		FB8EC034.Vertical = true;
		C78A178F.Cursor = System.Windows.Forms.Cursors.Hand;
		C78A178F.DropDownWidth = 350;
		C78A178F.FormattingEnabled = true;
		C78A178F.ItemHeight = 16;
		C78A178F.Items.AddRange(new object[3] { "Toàn bộ", "Nhóm không kiểm duyệt", "Nhóm kiểm duyệt" });
		C78A178F.Location = new System.Drawing.Point(71, 41);
		C78A178F.Name = "cbbKiemDuyet";
		C78A178F.Size = new System.Drawing.Size(184, 24);
		C78A178F.TabIndex = 7;
		C78A178F.SelectedIndexChanged += new System.EventHandler(F32E190B);
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(10, 44);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(55, 16);
		label1.TabIndex = 6;
		label1.Text = "Hiển thị:";
		dtgvAcc.AllowUserToAddRows = false;
		dtgvAcc.AllowUserToDeleteRows = false;
		dtgvAcc.AllowUserToResizeRows = false;
		dtgvAcc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
		dtgvAcc.Columns.AddRange(AF338424, C6381B8C, cId, E51FE914, cThanhVien, cKiemDuyet);
		dtgvAcc.ContextMenuStrip = ctmsAcc;
		dtgvAcc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		dtgvAcc.Location = new System.Drawing.Point(12, 72);
		dtgvAcc.Name = "dtgvAcc";
		dtgvAcc.RowHeadersVisible = false;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dtgvAcc.RowsDefaultCellStyle = dataGridViewCellStyle2;
		dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dtgvAcc.Size = new System.Drawing.Size(882, 483);
		dtgvAcc.TabIndex = 5;
		dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellClick);
		dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellDoubleClick);
		dtgvAcc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellValueChanged);
		dtgvAcc.SelectionChanged += new System.EventHandler(D986EB9E);
		dtgvAcc.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(F1110D3D);
		dtgvAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(dtgvAcc_KeyDown);
		AF338424.HeaderText = "Chọn";
		AF338424.Name = "cChose";
		AF338424.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		AF338424.Width = 40;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		C6381B8C.DefaultCellStyle = dataGridViewCellStyle3;
		C6381B8C.HeaderText = "STT";
		C6381B8C.Name = "cStt";
		C6381B8C.Width = 50;
		cId.HeaderText = "ID Nhóm";
		cId.Name = "cId";
		cId.Width = 120;
		E51FE914.HeaderText = "Tên nhóm";
		E51FE914.Name = "cTen";
		E51FE914.Width = 200;
		cThanhVien.HeaderText = "Thành viên";
		cThanhVien.Name = "cThanhVien";
		cThanhVien.Width = 120;
		cKiemDuyet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cKiemDuyet.HeaderText = "Kiểm duyệt";
		cKiemDuyet.MinimumWidth = 200;
		cKiemDuyet.Name = "cKiemDuyet";
		ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { CD2350A2, D62B5280, toolStripMenuItem_1, toolStripMenuItem_2, BB3C10A0 });
		ctmsAcc.Name = "ctmsAcc";
		ctmsAcc.Size = new System.Drawing.Size(180, 114);
		CD2350A2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { toolStripMenuItem_0, E61EEA38, tinhTrangToolStripMenuItem });
		CD2350A2.Image = (System.Drawing.Image)resources.GetObject("chọnLiveToolStripMenuItem.Image");
		CD2350A2.Name = "chọnLiveToolStripMenuItem";
		CD2350A2.Size = new System.Drawing.Size(179, 22);
		CD2350A2.Text = "Chọn";
		toolStripMenuItem_0.Image = (System.Drawing.Image)resources.GetObject("tấtCảToolStripMenuItem.Image");
		toolStripMenuItem_0.Name = "tấtCảToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(134, 22);
		toolStripMenuItem_0.Text = "Tất cả";
		toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		E61EEA38.Image = (System.Drawing.Image)resources.GetObject("liveToolStripMenuItem.Image");
		E61EEA38.Name = "liveToolStripMenuItem";
		E61EEA38.Size = new System.Drawing.Size(134, 22);
		E61EEA38.Text = "Bôi đen";
		E61EEA38.Click += new System.EventHandler(E61EEA38_Click);
		tinhTrangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { trueToolStripMenuItem, falseToolStripMenuItem });
		tinhTrangToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tinhTrangToolStripMenuItem.Image");
		tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
		tinhTrangToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
		tinhTrangToolStripMenuItem.Text = "Kiểm duyệt";
		trueToolStripMenuItem.Name = "trueToolStripMenuItem";
		trueToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
		trueToolStripMenuItem.Text = "True";
		trueToolStripMenuItem.Click += new System.EventHandler(trueToolStripMenuItem_Click);
		falseToolStripMenuItem.Name = "falseToolStripMenuItem";
		falseToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
		falseToolStripMenuItem.Text = "False";
		falseToolStripMenuItem.Click += new System.EventHandler(falseToolStripMenuItem_Click);
		D62B5280.Image = (System.Drawing.Image)resources.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
		D62B5280.Name = "bỏChọnTấtCảToolStripMenuItem";
		D62B5280.Size = new System.Drawing.Size(179, 22);
		D62B5280.Text = "Bỏ chọn tất cả";
		D62B5280.Click += new System.EventHandler(D62B5280_Click);
		toolStripMenuItem_1.Image = Resource.Bitmap_75;
		toolStripMenuItem_1.Name = "copyIDNhómToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(179, 22);
		toolStripMenuItem_1.Text = "Copy ID nhóm";
		toolStripMenuItem_1.Click += new System.EventHandler(E313039D);
		toolStripMenuItem_2.Image = Resource.Bitmap_78;
		toolStripMenuItem_2.Name = "pasteIDKiểmDuyệtToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(179, 22);
		toolStripMenuItem_2.Text = "Paste ID|Kiểm duyệt";
		toolStripMenuItem_2.Click += new System.EventHandler(EC386282);
		BB3C10A0.Image = (System.Drawing.Image)resources.GetObject("tảiLạiDanhSáchToolStripMenuItem.Image");
		BB3C10A0.Name = "tảiLạiDanhSáchToolStripMenuItem";
		BB3C10A0.Size = new System.Drawing.Size(179, 22);
		BB3C10A0.Text = "Tải lại danh sách";
		BB3C10A0.Click += new System.EventHandler(AB1C1085);
		statusStrip1.BackColor = System.Drawing.SystemColors.Control;
		statusStrip1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[6] { toolStripStatusLabel4, E8169EB1, A90508BF, D5AAD792, toolStripStatusLabel2, lblCountTotal });
		statusStrip1.Location = new System.Drawing.Point(0, 558);
		statusStrip1.Name = "statusStrip1";
		statusStrip1.Size = new System.Drawing.Size(906, 22);
		statusStrip1.SizingGrip = false;
		statusStrip1.TabIndex = 10;
		statusStrip1.Text = "statusStrip1";
		toolStripStatusLabel4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel4.Name = "toolStripStatusLabel4";
		toolStripStatusLabel4.Size = new System.Drawing.Size(59, 17);
		toolStripStatusLabel4.Text = "Bôi đen:";
		E8169EB1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E8169EB1.ForeColor = System.Drawing.Color.Blue;
		E8169EB1.Name = "lblCountHighline";
		E8169EB1.Size = new System.Drawing.Size(15, 17);
		E8169EB1.Text = "0";
		A90508BF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A90508BF.Name = "toolStripStatusLabel5";
		A90508BF.Size = new System.Drawing.Size(65, 17);
		A90508BF.Text = "Đã chọn:";
		D5AAD792.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D5AAD792.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
		D5AAD792.Name = "lblCountSelect";
		D5AAD792.Size = new System.Drawing.Size(15, 17);
		D5AAD792.Text = "0";
		toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel2.Name = "toolStripStatusLabel2";
		toolStripStatusLabel2.Size = new System.Drawing.Size(52, 17);
		toolStripStatusLabel2.Text = "Tất cả:";
		lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountTotal.ForeColor = System.Drawing.Color.Maroon;
		lblCountTotal.Name = "lblCountTotal";
		lblCountTotal.Size = new System.Drawing.Size(15, 17);
		lblCountTotal.Text = "0";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(906, 580);
		base.Controls.Add(statusStrip1);
		base.Controls.Add(C78A178F);
		base.Controls.Add(label1);
		base.Controls.Add(dtgvAcc);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fQuanLyNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(DB20F506);
		bunifuCards1.ResumeLayout(false);
		AEBA3FAB.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)dtgvAcc).EndInit();
		ctmsAcc.ResumeLayout(false);
		statusStrip1.ResumeLayout(false);
		statusStrip1.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}
}
