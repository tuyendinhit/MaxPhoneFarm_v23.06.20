using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchLocTrung : Form
{
	internal IContainer D125D9B8 = null;

	internal BunifuCards AB298021;

	internal Panel panel1;

	internal BunifuDragControl bunifuDragControl_0;

	internal ToolTip toolTip_0;

	internal BunifuCards D3050188;

	internal Panel pnlHeader;

	internal Button button2;

	internal PictureBox pictureBox1;

	internal Button btnMinimize;

	internal BunifuCustomLabel lblTitle;

	internal Button btnAdd;

	internal RichTextBox txtInput;

	internal GroupBox groupBox2;

	internal RichTextBox A91AFE8F;

	internal GroupBox E4AC8202;

	internal Button btnNhapTuFile;

	internal TextBox D7950583;

	internal RadioButton rbTuNhap;

	internal RadioButton B995740C;

	public fTienIchLocTrung()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(lblTitle);
		Language.smethod_1(B995740C);
		Language.smethod_1(btnNhapTuFile);
		Language.smethod_1(rbTuNhap);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> source = new List<string>();
			string text = D7950583.Text.Trim();
			if (B995740C.Checked)
			{
				if (text.EndsWith(".txt"))
				{
					if (!File.Exists(text))
					{
						MessageBoxHelper.Show(Language.GetValue("File dữ liệu nhập không tồn tại!"), 2);
					}
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("File nhập vào chỉ hỗ trợ đối với File (.txt)!"), 2);
				}
			}
			if (B995740C.Checked)
			{
				source = File.ReadAllLines(text).ToList();
			}
			else if (rbTuNhap.Checked)
			{
				source = txtInput.Lines.ToList();
			}
			List<string> list = source.Distinct().ToList();
			A91AFE8F.Lines = list.ToArray();
			MessageBoxHelper.Show(Language.GetValue("Đã lọc xong!"));
		}
		catch (Exception)
		{
			MessageBoxHelper.Show(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void txtInput_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtInput, rbTuNhap);
	}

	private void C0AC782E(object sender, EventArgs e)
	{
		D7950583.Enabled = B995740C.Checked;
		btnNhapTuFile.Enabled = B995740C.Checked;
	}

	private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		txtInput.Enabled = rbTuNhap.Checked;
	}

	private void btnNhapTuFile_Click(object sender, EventArgs e)
	{
		D7950583.Text = Common.smethod_23();
	}

	private void F88FAE91(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = A91AFE8F.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			groupBox2.Text = $"Output ({f1808BA.Count.ToString()})";
		}
		catch
		{
		}
	}

	private void BC1AA496(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchLocTrung_Load(object sender, EventArgs e)
	{
		C0AC782E(null, null);
		rbTuNhap_CheckedChanged(null, null);
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && D125D9B8 != null)
		{
			D125D9B8.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		D125D9B8 = new System.ComponentModel.Container();
		AB298021 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		groupBox2 = new System.Windows.Forms.GroupBox();
		A91AFE8F = new System.Windows.Forms.RichTextBox();
		E4AC8202 = new System.Windows.Forms.GroupBox();
		btnNhapTuFile = new System.Windows.Forms.Button();
		txtInput = new System.Windows.Forms.RichTextBox();
		D7950583 = new System.Windows.Forms.TextBox();
		rbTuNhap = new System.Windows.Forms.RadioButton();
		B995740C = new System.Windows.Forms.RadioButton();
		btnAdd = new System.Windows.Forms.Button();
		D3050188 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(D125D9B8);
		toolTip_0 = new System.Windows.Forms.ToolTip(D125D9B8);
		panel1.SuspendLayout();
		groupBox2.SuspendLayout();
		E4AC8202.SuspendLayout();
		D3050188.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		AB298021.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		AB298021.BackColor = System.Drawing.Color.White;
		AB298021.BorderRadius = 5;
		AB298021.BottomSahddow = true;
		AB298021.color = System.Drawing.Color.SaddleBrown;
		AB298021.LeftSahddow = false;
		AB298021.Location = new System.Drawing.Point(0, 0);
		AB298021.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		AB298021.Name = "bunifuCards1";
		AB298021.RightSahddow = true;
		AB298021.ShadowDepth = 20;
		AB298021.Size = new System.Drawing.Size(509, 47);
		AB298021.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(groupBox2);
		panel1.Controls.Add(E4AC8202);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(D3050188);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(838, 270);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(BC1AA496);
		groupBox2.Controls.Add(A91AFE8F);
		groupBox2.Location = new System.Drawing.Point(469, 40);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(361, 223);
		groupBox2.TabIndex = 51;
		groupBox2.TabStop = false;
		groupBox2.Text = "Output (0)";
		A91AFE8F.Location = new System.Drawing.Point(6, 22);
		A91AFE8F.Name = "txtOutput";
		A91AFE8F.Size = new System.Drawing.Size(349, 194);
		A91AFE8F.TabIndex = 50;
		A91AFE8F.Text = "";
		A91AFE8F.WordWrap = false;
		A91AFE8F.TextChanged += new System.EventHandler(F88FAE91);
		E4AC8202.Controls.Add(btnNhapTuFile);
		E4AC8202.Controls.Add(txtInput);
		E4AC8202.Controls.Add(D7950583);
		E4AC8202.Controls.Add(rbTuNhap);
		E4AC8202.Controls.Add(B995740C);
		E4AC8202.Location = new System.Drawing.Point(6, 40);
		E4AC8202.Name = "groupBox1";
		E4AC8202.Size = new System.Drawing.Size(361, 223);
		E4AC8202.TabIndex = 51;
		E4AC8202.TabStop = false;
		E4AC8202.Text = "Input";
		btnNhapTuFile.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapTuFile.Location = new System.Drawing.Point(287, 22);
		btnNhapTuFile.Name = "btnNhapTuFile";
		btnNhapTuFile.Size = new System.Drawing.Size(65, 24);
		btnNhapTuFile.TabIndex = 2;
		btnNhapTuFile.Text = "Chọn";
		btnNhapTuFile.Click += new System.EventHandler(btnNhapTuFile_Click);
		txtInput.Location = new System.Drawing.Point(30, 75);
		txtInput.Name = "txtInput";
		txtInput.Size = new System.Drawing.Size(322, 141);
		txtInput.TabIndex = 50;
		txtInput.Text = "";
		txtInput.WordWrap = false;
		txtInput.TextChanged += new System.EventHandler(txtInput_TextChanged);
		D7950583.Location = new System.Drawing.Point(110, 22);
		D7950583.Name = "txtNhapTuFile";
		D7950583.Size = new System.Drawing.Size(171, 23);
		D7950583.TabIndex = 1;
		rbTuNhap.AutoSize = true;
		rbTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		rbTuNhap.Location = new System.Drawing.Point(9, 49);
		rbTuNhap.Name = "rbTuNhap";
		rbTuNhap.Size = new System.Drawing.Size(95, 20);
		rbTuNhap.TabIndex = 0;
		rbTuNhap.Text = "Tự nhập (0)";
		rbTuNhap.UseVisualStyleBackColor = true;
		rbTuNhap.CheckedChanged += new System.EventHandler(rbTuNhap_CheckedChanged);
		B995740C.AutoSize = true;
		B995740C.Checked = true;
		B995740C.Cursor = System.Windows.Forms.Cursors.Hand;
		B995740C.Location = new System.Drawing.Point(9, 23);
		B995740C.Name = "rbNhapTuFile";
		B995740C.Size = new System.Drawing.Size(95, 20);
		B995740C.TabIndex = 0;
		B995740C.TabStop = true;
		B995740C.Text = "Nhập từ File";
		B995740C.UseVisualStyleBackColor = true;
		B995740C.CheckedChanged += new System.EventHandler(C0AC782E);
		btnAdd.BackColor = System.Drawing.Color.Green;
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(379, 138);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(78, 29);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Start";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		D3050188.BackColor = System.Drawing.Color.White;
		D3050188.BorderRadius = 0;
		D3050188.BottomSahddow = true;
		D3050188.color = System.Drawing.Color.SaddleBrown;
		D3050188.Controls.Add(pnlHeader);
		D3050188.Dock = System.Windows.Forms.DockStyle.Top;
		D3050188.LeftSahddow = false;
		D3050188.Location = new System.Drawing.Point(0, 0);
		D3050188.Name = "bunifuCards2";
		D3050188.RightSahddow = true;
		D3050188.ShadowDepth = 20;
		D3050188.Size = new System.Drawing.Size(836, 37);
		D3050188.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(lblTitle);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(836, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = Resource.Bitmap_9;
		button2.Location = new System.Drawing.Point(805, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
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
		lblTitle.BackColor = System.Drawing.Color.Transparent;
		lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
		lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblTitle.ForeColor = System.Drawing.Color.Black;
		lblTitle.Location = new System.Drawing.Point(0, 0);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new System.Drawing.Size(836, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Lọc trùng dữ liệu";
		lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = lblTitle;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(838, 270);
		base.Controls.Add(panel1);
		base.Controls.Add(AB298021);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchLocTrung";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fTienIchLocTrung_Load);
		panel1.ResumeLayout(false);
		groupBox2.ResumeLayout(false);
		E4AC8202.ResumeLayout(false);
		E4AC8202.PerformLayout();
		D3050188.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}
}
