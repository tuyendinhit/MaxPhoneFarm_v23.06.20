using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapDuLieu1 : Form
{
	internal string D9BC3F82 = "";

	internal string C11E149C = "";

	internal List<string> list_0 = new List<string>();

	internal IContainer D83DF685 = null;

	internal BunifuCards bunifuCards1;

	internal Panel panel1;

	internal BunifuDragControl bunifuDragControl_0;

	internal ToolTip B9883D12;

	internal BunifuCards bunifuCards2;

	internal Panel pnlHeader;

	internal Button D0117623;

	internal PictureBox pictureBox1;

	internal Button btnMinimize;

	internal BunifuCustomLabel lblTitle;

	internal Label D5B9D7A8;

	internal Button FC0C36BC;

	internal Button btnAdd;

	internal Label lblFooter;

	internal RichTextBox txtComment;

	public fNhapDuLieu1(string string_0, string A41BD005 = "Nhập danh sách Uid cần clone", string C7BA0401 = "Danh sách Uid", string EE2C6B34 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})", List<string> AC37741B = null)
	{
		InitializeComponent();
		Common.smethod_14(string_0);
		D9BC3F82 = string_0;
		C11E149C = C7BA0401;
		lblTitle.Text = A41BD005;
		D5B9D7A8.Text = C7BA0401 + " (0):";
		lblFooter.Text = EE2C6B34;
		if (AC37741B != null)
		{
			File.WriteAllLines(string_0, AC37741B);
			txtComment.Lines = AC37741B.ToArray();
		}
		else
		{
			txtComment.Lines = File.ReadAllLines(string_0);
		}
		txtComment_TextChanged(null, null);
		Language.SetLanguage(this);
	}

	public fNhapDuLieu1(List<string> list_1, string string_0 = "Nhập danh sách Uid cần clone", string F3A56F89 = "Danh sách Uid", string string_1 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})")
	{
		InitializeComponent();
		list_0 = list_1;
		C11E149C = F3A56F89;
		lblTitle.Text = string_0;
		D5B9D7A8.Text = F3A56F89 + " (0):";
		lblFooter.Text = string_1;
		Language.SetLanguage(this);
	}

	private void F41D4B87(object sender, EventArgs e)
	{
		if (D9BC3F82 != "")
		{
			txtComment.Lines = File.ReadAllLines(D9BC3F82);
		}
		else
		{
			txtComment.Lines = list_0.ToArray();
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void FBADAA8D(object sender, PaintEventArgs e)
	{
	}

	private void D0117623_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void BA82E62F(object sender, EventArgs e)
	{
		try
		{
			if (D9BC3F82 != "")
			{
				File.WriteAllText(D9BC3F82, txtComment.Text.Trim());
			}
			else
			{
				list_0 = txtComment.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			}
			if (MessageBoxHelper.smethod_1("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
			{
				Close();
			}
		}
		catch
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void BC95473C(object sender, EventArgs e)
	{
		Close();
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtComment, D5B9D7A8);
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && D83DF685 != null)
		{
			D83DF685.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		D83DF685 = new System.ComponentModel.Container();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		lblFooter = new System.Windows.Forms.Label();
		D5B9D7A8 = new System.Windows.Forms.Label();
		FC0C36BC = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		D0117623 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(D83DF685);
		B9883D12 = new System.Windows.Forms.ToolTip(D83DF685);
		txtComment = new System.Windows.Forms.RichTextBox();
		panel1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
		bunifuCards1.Size = new System.Drawing.Size(234, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(txtComment);
		panel1.Controls.Add(lblFooter);
		panel1.Controls.Add(D5B9D7A8);
		panel1.Controls.Add(FC0C36BC);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(563, 364);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(FBADAA8D);
		lblFooter.AutoSize = true;
		lblFooter.Location = new System.Drawing.Point(13, 299);
		lblFooter.Name = "lblFooter";
		lblFooter.Size = new System.Drawing.Size(266, 16);
		lblFooter.TabIndex = 49;
		lblFooter.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		D5B9D7A8.AutoSize = true;
		D5B9D7A8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D5B9D7A8.Location = new System.Drawing.Point(13, 45);
		D5B9D7A8.Name = "lblStatus";
		D5B9D7A8.Size = new System.Drawing.Size(140, 16);
		D5B9D7A8.TabIndex = 47;
		D5B9D7A8.Text = "Nội dung bình luận (0):";
		FC0C36BC.BackColor = System.Drawing.Color.Maroon;
		FC0C36BC.Cursor = System.Windows.Forms.Cursors.Hand;
		FC0C36BC.FlatAppearance.BorderSize = 0;
		FC0C36BC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FC0C36BC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FC0C36BC.ForeColor = System.Drawing.Color.White;
		FC0C36BC.Location = new System.Drawing.Point(286, 321);
		FC0C36BC.Name = "btnCancel";
		FC0C36BC.Size = new System.Drawing.Size(92, 29);
		FC0C36BC.TabIndex = 46;
		FC0C36BC.Text = "Đóng";
		FC0C36BC.UseVisualStyleBackColor = false;
		FC0C36BC.Click += new System.EventHandler(BC95473C);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(182, 321);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(BA82E62F);
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
		bunifuCards2.Size = new System.Drawing.Size(561, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(D0117623);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(lblTitle);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(561, 31);
		pnlHeader.TabIndex = 9;
		D0117623.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		D0117623.Cursor = System.Windows.Forms.Cursors.Hand;
		D0117623.FlatAppearance.BorderSize = 0;
		D0117623.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D0117623.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D0117623.ForeColor = System.Drawing.Color.White;
		D0117623.Image = Resource.Bitmap_9;
		D0117623.Location = new System.Drawing.Point(530, 1);
		D0117623.Name = "button2";
		D0117623.Size = new System.Drawing.Size(30, 30);
		D0117623.TabIndex = 77;
		D0117623.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		D0117623.UseVisualStyleBackColor = true;
		D0117623.Click += new System.EventHandler(D0117623_Click);
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
		lblTitle.Size = new System.Drawing.Size(561, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Nhập nội dung comment";
		lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = lblTitle;
		bunifuDragControl_0.Vertical = true;
		B9883D12.AutomaticDelay = 0;
		B9883D12.AutoPopDelay = 10000;
		B9883D12.InitialDelay = 200;
		B9883D12.ReshowDelay = 40;
		txtComment.Location = new System.Drawing.Point(16, 64);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(528, 231);
		txtComment.TabIndex = 50;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(563, 364);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fNhapDuLieu1";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(F41D4B87);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}
}
