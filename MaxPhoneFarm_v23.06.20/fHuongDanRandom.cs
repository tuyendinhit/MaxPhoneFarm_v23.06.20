using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHuongDanRandom : Form
{
	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel BC2EE53E;

	internal BunifuDragControl bunifuDragControl_0;

	internal ToolTip toolTip_0;

	internal BunifuCards bunifuCards2;

	internal Panel pnlHeader;

	internal Button A6B76C05;

	internal PictureBox C03A2A16;

	internal Button btnMinimize;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal ContextMenuStrip D428C89A;

	internal ToolStripMenuItem C20C1A84;

	internal ToolStripMenuItem toolStripMenuItem_0;

	internal ToolStripMenuItem toolStripMenuItem_1;

	internal DataGridView FA263D00;

	internal DataGridViewTextBoxColumn cSTT;

	internal DataGridViewTextBoxColumn cTuKhoa;

	internal DataGridViewImageColumn CA9E5C18;

	public fHuongDanRandom()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		F3A53BB3();
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		foreach (DataGridViewColumn column in FA263D00.Columns)
		{
			Language.E3937E81(column);
		}
	}

	private void F3A53BB3()
	{
		new Random();
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[r1]", Resource.Bitmap_43);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[r2]", Resource.F8B1413F);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[r3]", Resource.EE8421BC);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[r4]", Resource.Bitmap_44);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[r5]", Resource.Bitmap_45);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[r6]", Resource.Bitmap_46);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[r7]", Resource.Bitmap_47);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[r8]", Resource.D63346B4);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[d]", Resource.A1059CA5);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[t]", Resource.Bitmap_48);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[n*]", Resource.Bitmap_49);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[s*]", Resource.F98C718A);
		FA263D00.Rows.Add(FA263D00.RowCount + 1, "[q***]", Resource.Bitmap_50);
	}

	private void fHuongDanRandom_Load(object sender, EventArgs e)
	{
	}

	private void BC2EE53E_Paint(object sender, PaintEventArgs e)
	{
	}

	private void A6B76C05_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool FD154C8E)
	{
		if (FD154C8E && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(FD154C8E);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		BC2EE53E = new System.Windows.Forms.Panel();
		FA263D00 = new System.Windows.Forms.DataGridView();
		cSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cTuKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
		CA9E5C18 = new System.Windows.Forms.DataGridViewImageColumn();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		A6B76C05 = new System.Windows.Forms.Button();
		C03A2A16 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D428C89A = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
		C20C1A84 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		BC2EE53E.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FA263D00).BeginInit();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C03A2A16).BeginInit();
		D428C89A.SuspendLayout();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(243, 47);
		bunifuCards1.TabIndex = 12;
		BC2EE53E.BackColor = System.Drawing.Color.White;
		BC2EE53E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BC2EE53E.Controls.Add(FA263D00);
		BC2EE53E.Controls.Add(bunifuCards2);
		BC2EE53E.Dock = System.Windows.Forms.DockStyle.Fill;
		BC2EE53E.Location = new System.Drawing.Point(0, 0);
		BC2EE53E.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		BC2EE53E.Name = "panel1";
		BC2EE53E.Size = new System.Drawing.Size(572, 503);
		BC2EE53E.TabIndex = 37;
		BC2EE53E.Paint += new System.Windows.Forms.PaintEventHandler(BC2EE53E_Paint);
		FA263D00.AllowUserToAddRows = false;
		FA263D00.AllowUserToDeleteRows = false;
		FA263D00.AllowUserToResizeRows = false;
		FA263D00.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
		FA263D00.BackgroundColor = System.Drawing.Color.White;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		FA263D00.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		FA263D00.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		FA263D00.Columns.AddRange(cSTT, cTuKhoa, CA9E5C18);
		FA263D00.Location = new System.Drawing.Point(11, 43);
		FA263D00.Name = "dgv";
		FA263D00.ReadOnly = true;
		FA263D00.RowHeadersVisible = false;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
		FA263D00.RowsDefaultCellStyle = dataGridViewCellStyle2;
		FA263D00.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		FA263D00.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		FA263D00.Size = new System.Drawing.Size(547, 447);
		FA263D00.TabIndex = 75;
		cSTT.HeaderText = "STT";
		cSTT.Name = "cSTT";
		cSTT.ReadOnly = true;
		cSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		cSTT.Width = 40;
		cTuKhoa.HeaderText = "Từ khóa";
		cTuKhoa.Name = "cTuKhoa";
		cTuKhoa.ReadOnly = true;
		cTuKhoa.Width = 80;
		CA9E5C18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		CA9E5C18.HeaderText = "Nội dung random";
		CA9E5C18.Name = "cNoiDung";
		CA9E5C18.ReadOnly = true;
		CA9E5C18.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		CA9E5C18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
		bunifuCards2.Size = new System.Drawing.Size(570, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(A6B76C05);
		pnlHeader.Controls.Add(C03A2A16);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(570, 31);
		pnlHeader.TabIndex = 9;
		A6B76C05.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		A6B76C05.Cursor = System.Windows.Forms.Cursors.Hand;
		A6B76C05.FlatAppearance.BorderSize = 0;
		A6B76C05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A6B76C05.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A6B76C05.ForeColor = System.Drawing.Color.White;
		A6B76C05.Image = Resource.Bitmap_9;
		A6B76C05.Location = new System.Drawing.Point(539, 1);
		A6B76C05.Name = "button2";
		A6B76C05.Size = new System.Drawing.Size(30, 30);
		A6B76C05.TabIndex = 77;
		A6B76C05.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		A6B76C05.UseVisualStyleBackColor = true;
		A6B76C05.Click += new System.EventHandler(A6B76C05_Click);
		C03A2A16.Cursor = System.Windows.Forms.Cursors.Default;
		C03A2A16.Image = Resource.AC35C73C;
		C03A2A16.Location = new System.Drawing.Point(3, 2);
		C03A2A16.Name = "pictureBox1";
		C03A2A16.Size = new System.Drawing.Size(34, 27);
		C03A2A16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		C03A2A16.TabIndex = 76;
		C03A2A16.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Location = new System.Drawing.Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(570, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Hướng dẫn random nội dung";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D428C89A.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { C20C1A84, toolStripMenuItem_0, toolStripMenuItem_1 });
		D428C89A.Name = "contextMenuStrip1";
		D428C89A.Size = new System.Drawing.Size(153, 70);
		C20C1A84.Name = "thêmMớiToolStripMenuItem";
		C20C1A84.Size = new System.Drawing.Size(152, 22);
		C20C1A84.Text = "Thêm chủ đề";
		toolStripMenuItem_0.Name = "sửaToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_0.Text = "Sửa tên chủ đề";
		toolStripMenuItem_1.Name = "xóaToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_1.Text = "Xóa chủ đề";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(572, 503);
		base.Controls.Add(BC2EE53E);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHuongDanRandom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fHuongDanRandom_Load);
		BC2EE53E.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)FA263D00).EndInit();
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)C03A2A16).EndInit();
		D428C89A.ResumeLayout(false);
		ResumeLayout(false);
	}
}
