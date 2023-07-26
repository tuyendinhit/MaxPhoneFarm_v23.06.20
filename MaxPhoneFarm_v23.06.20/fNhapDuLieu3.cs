using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapDuLieu3 : Form
{
	internal string string_0 = "";

	internal string string_1 = "";

	internal string D30E479D = "";

	internal int int_0 = 0;

	internal IContainer CEB3CF27 = null;

	internal BunifuCards FAB79EB4;

	internal Panel panel1;

	internal BunifuDragControl bunifuDragControl_0;

	internal ToolTip A727388C;

	internal BunifuCards D5A5158C;

	internal Panel pnlHeader;

	internal Button B8B8D99E;

	internal PictureBox E9803514;

	internal Button D033E805;

	internal BunifuCustomLabel D310C625;

	internal Label lblStatus;

	internal Button F3B864BA;

	internal Button B33F3DAF;

	internal Label lblFooter;

	internal RichTextBox txtComment;

	internal Button AD043A90;

	internal Button button1;

	internal RadioButton D19FDE04;

	internal RadioButton CD1DA729;

	internal Label C7183BAF;

	public fNhapDuLieu3(string string_2, string string_3 = "Nhập danh sách Uid cần clone", string A216D20D = "Danh sách Uid", string string_4 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})", List<string> F9A96689 = null)
	{
		InitializeComponent();
		Common.smethod_14(string_2);
		string_0 = string_2;
		string_1 = A216D20D;
		D310C625.Text = string_3;
		lblStatus.Text = A216D20D + " (0):";
		lblFooter.Text = string_4;
		if (F9A96689 != null)
		{
			File.WriteAllLines(string_2, F9A96689);
			txtComment.Lines = F9A96689.ToArray();
		}
		else
		{
			txtComment.Lines = File.ReadAllLines(string_2);
		}
		F1B1D109(null, null);
		Language.SetLanguage(this);
	}

	public fNhapDuLieu3(string string_2, int int_1, string string_3 = "Nhập danh sách Uid cần clone", string string_4 = "Danh sách Uid", string C801C734 = "(Spin nội dung {a|b|c})")
	{
		InitializeComponent();
		D30E479D = string_2;
		int_0 = int_1;
		string_1 = string_4;
		D310C625.Text = string_3;
		lblStatus.Text = string_4 + " (0):";
		lblFooter.Text = C801C734;
		Language.SetLanguage(this);
	}

	private void FF31300B(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			CD1DA729.Checked = true;
		}
		else
		{
			D19FDE04.Checked = true;
		}
		if (string_0 != "")
		{
			txtComment.Lines = File.ReadAllLines(string_0);
		}
		else
		{
			txtComment.Text = D30E479D;
		}
	}

	private void DE8B42B9(object sender, PaintEventArgs e)
	{
	}

	private void CA366E9E(object sender, EventArgs e)
	{
		Close();
	}

	private void D105EEA0(object sender, EventArgs e)
	{
		try
		{
			if (string_0 != "")
			{
				File.WriteAllText(string_0, txtComment.Text.Trim());
			}
			else
			{
				D30E479D = txtComment.Text;
				int_0 = ((!CD1DA729.Checked) ? 1 : 0);
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

	private void F3B864BA_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F1B1D109(object sender, EventArgs e)
	{
		int b5968D3F = ((!CD1DA729.Checked) ? 1 : 0);
		Common.D936DD84(txtComment, lblStatus, b5968D3F);
	}

	private void A8BC37A7(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
	}

	private void AD043A90_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
	}

	private void CD1DA729_CheckedChanged(object sender, EventArgs e)
	{
		F1B1D109(null, null);
	}

	private void D19FDE04_CheckedChanged(object sender, EventArgs e)
	{
		F1B1D109(null, null);
	}

	protected override void Dispose(bool D58A3A31)
	{
		if (D58A3A31 && CEB3CF27 != null)
		{
			CEB3CF27.Dispose();
		}
		base.Dispose(D58A3A31);
	}

	private void InitializeComponent()
	{
		CEB3CF27 = new System.ComponentModel.Container();
		FAB79EB4 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		AD043A90 = new System.Windows.Forms.Button();
		button1 = new System.Windows.Forms.Button();
		D19FDE04 = new System.Windows.Forms.RadioButton();
		CD1DA729 = new System.Windows.Forms.RadioButton();
		C7183BAF = new System.Windows.Forms.Label();
		txtComment = new System.Windows.Forms.RichTextBox();
		lblFooter = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		F3B864BA = new System.Windows.Forms.Button();
		B33F3DAF = new System.Windows.Forms.Button();
		D5A5158C = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		B8B8D99E = new System.Windows.Forms.Button();
		E9803514 = new System.Windows.Forms.PictureBox();
		D033E805 = new System.Windows.Forms.Button();
		D310C625 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(CEB3CF27);
		A727388C = new System.Windows.Forms.ToolTip(CEB3CF27);
		panel1.SuspendLayout();
		D5A5158C.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)E9803514).BeginInit();
		SuspendLayout();
		FAB79EB4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FAB79EB4.BackColor = System.Drawing.Color.White;
		FAB79EB4.BorderRadius = 5;
		FAB79EB4.BottomSahddow = true;
		FAB79EB4.color = System.Drawing.Color.SaddleBrown;
		FAB79EB4.LeftSahddow = false;
		FAB79EB4.Location = new System.Drawing.Point(0, 0);
		FAB79EB4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		FAB79EB4.Name = "bunifuCards1";
		FAB79EB4.RightSahddow = true;
		FAB79EB4.ShadowDepth = 20;
		FAB79EB4.Size = new System.Drawing.Size(234, 47);
		FAB79EB4.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(AD043A90);
		panel1.Controls.Add(button1);
		panel1.Controls.Add(D19FDE04);
		panel1.Controls.Add(CD1DA729);
		panel1.Controls.Add(C7183BAF);
		panel1.Controls.Add(txtComment);
		panel1.Controls.Add(lblFooter);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(F3B864BA);
		panel1.Controls.Add(B33F3DAF);
		panel1.Controls.Add(D5A5158C);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(563, 355);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(DE8B42B9);
		AD043A90.Cursor = System.Windows.Forms.Cursors.Help;
		AD043A90.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AD043A90.Location = new System.Drawing.Point(237, 274);
		AD043A90.Name = "button3";
		AD043A90.Size = new System.Drawing.Size(21, 23);
		AD043A90.TabIndex = 198;
		AD043A90.Text = "?";
		AD043A90.UseVisualStyleBackColor = true;
		AD043A90.Click += new System.EventHandler(AD043A90_Click);
		button1.Cursor = System.Windows.Forms.Cursors.Help;
		button1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button1.Location = new System.Drawing.Point(237, 251);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(21, 23);
		button1.TabIndex = 199;
		button1.Text = "?";
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(A8BC37A7);
		D19FDE04.AutoSize = true;
		D19FDE04.Cursor = System.Windows.Forms.Cursors.Hand;
		D19FDE04.Location = new System.Drawing.Point(78, 275);
		D19FDE04.Name = "rbNganCachKyTu";
		D19FDE04.Size = new System.Drawing.Size(159, 20);
		D19FDE04.TabIndex = 197;
		D19FDE04.Text = "Nội dung có nhiều dòng";
		D19FDE04.UseVisualStyleBackColor = true;
		D19FDE04.CheckedChanged += new System.EventHandler(D19FDE04_CheckedChanged);
		CD1DA729.AutoSize = true;
		CD1DA729.Checked = true;
		CD1DA729.Cursor = System.Windows.Forms.Cursors.Hand;
		CD1DA729.Location = new System.Drawing.Point(78, 253);
		CD1DA729.Name = "rbNganCachMoiDong";
		CD1DA729.Size = new System.Drawing.Size(155, 20);
		CD1DA729.TabIndex = 196;
		CD1DA729.TabStop = true;
		CD1DA729.Text = "Nội dung chỉ có 1 dòng";
		CD1DA729.UseVisualStyleBackColor = true;
		CD1DA729.CheckedChanged += new System.EventHandler(CD1DA729_CheckedChanged);
		C7183BAF.AutoSize = true;
		C7183BAF.Location = new System.Drawing.Point(13, 253);
		C7183BAF.Name = "label9";
		C7183BAF.Size = new System.Drawing.Size(64, 16);
		C7183BAF.TabIndex = 195;
		C7183BAF.Text = "Tùy chọn:";
		txtComment.Location = new System.Drawing.Point(16, 64);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(528, 186);
		txtComment.TabIndex = 50;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(F1B1D109);
		lblFooter.AutoSize = true;
		lblFooter.Location = new System.Drawing.Point(404, 253);
		lblFooter.Name = "lblFooter";
		lblFooter.Size = new System.Drawing.Size(143, 16);
		lblFooter.TabIndex = 49;
		lblFooter.Text = "(Spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		lblStatus.Location = new System.Drawing.Point(13, 45);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(139, 16);
		lblStatus.TabIndex = 47;
		lblStatus.Text = "Nội dung bình luận (0):";
		F3B864BA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F3B864BA.BackColor = System.Drawing.Color.Maroon;
		F3B864BA.Cursor = System.Windows.Forms.Cursors.Hand;
		F3B864BA.FlatAppearance.BorderSize = 0;
		F3B864BA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F3B864BA.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F3B864BA.ForeColor = System.Drawing.Color.White;
		F3B864BA.Location = new System.Drawing.Point(287, 313);
		F3B864BA.Name = "btnCancel";
		F3B864BA.Size = new System.Drawing.Size(92, 29);
		F3B864BA.TabIndex = 46;
		F3B864BA.Text = "Đóng";
		F3B864BA.UseVisualStyleBackColor = false;
		F3B864BA.Click += new System.EventHandler(F3B864BA_Click);
		B33F3DAF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B33F3DAF.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		B33F3DAF.Cursor = System.Windows.Forms.Cursors.Hand;
		B33F3DAF.FlatAppearance.BorderSize = 0;
		B33F3DAF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B33F3DAF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B33F3DAF.ForeColor = System.Drawing.Color.White;
		B33F3DAF.Location = new System.Drawing.Point(183, 313);
		B33F3DAF.Name = "btnAdd";
		B33F3DAF.Size = new System.Drawing.Size(92, 29);
		B33F3DAF.TabIndex = 45;
		B33F3DAF.Text = "Lưu";
		B33F3DAF.UseVisualStyleBackColor = false;
		B33F3DAF.Click += new System.EventHandler(D105EEA0);
		D5A5158C.BackColor = System.Drawing.Color.White;
		D5A5158C.BorderRadius = 0;
		D5A5158C.BottomSahddow = true;
		D5A5158C.color = System.Drawing.Color.SaddleBrown;
		D5A5158C.Controls.Add(pnlHeader);
		D5A5158C.Dock = System.Windows.Forms.DockStyle.Top;
		D5A5158C.LeftSahddow = false;
		D5A5158C.Location = new System.Drawing.Point(0, 0);
		D5A5158C.Name = "bunifuCards2";
		D5A5158C.RightSahddow = true;
		D5A5158C.ShadowDepth = 20;
		D5A5158C.Size = new System.Drawing.Size(561, 37);
		D5A5158C.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(B8B8D99E);
		pnlHeader.Controls.Add(E9803514);
		pnlHeader.Controls.Add(D033E805);
		pnlHeader.Controls.Add(D310C625);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(561, 31);
		pnlHeader.TabIndex = 9;
		B8B8D99E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B8B8D99E.Cursor = System.Windows.Forms.Cursors.Hand;
		B8B8D99E.FlatAppearance.BorderSize = 0;
		B8B8D99E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B8B8D99E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B8B8D99E.ForeColor = System.Drawing.Color.White;
		B8B8D99E.Image = Resource.Bitmap_9;
		B8B8D99E.Location = new System.Drawing.Point(530, 1);
		B8B8D99E.Name = "button2";
		B8B8D99E.Size = new System.Drawing.Size(30, 30);
		B8B8D99E.TabIndex = 77;
		B8B8D99E.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B8B8D99E.UseVisualStyleBackColor = true;
		B8B8D99E.Click += new System.EventHandler(CA366E9E);
		E9803514.Cursor = System.Windows.Forms.Cursors.Default;
		E9803514.Image = Resource.AC35C73C;
		E9803514.Location = new System.Drawing.Point(3, 2);
		E9803514.Name = "pictureBox1";
		E9803514.Size = new System.Drawing.Size(34, 27);
		E9803514.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		E9803514.TabIndex = 76;
		E9803514.TabStop = false;
		D033E805.Cursor = System.Windows.Forms.Cursors.Hand;
		D033E805.FlatAppearance.BorderSize = 0;
		D033E805.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D033E805.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D033E805.ForeColor = System.Drawing.Color.White;
		D033E805.Location = new System.Drawing.Point(899, 1);
		D033E805.Name = "btnMinimize";
		D033E805.Size = new System.Drawing.Size(30, 30);
		D033E805.TabIndex = 9;
		D033E805.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		D033E805.UseVisualStyleBackColor = true;
		D310C625.BackColor = System.Drawing.Color.Transparent;
		D310C625.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D310C625.Dock = System.Windows.Forms.DockStyle.Fill;
		D310C625.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D310C625.ForeColor = System.Drawing.Color.Black;
		D310C625.Location = new System.Drawing.Point(0, 0);
		D310C625.Name = "lblTitle";
		D310C625.Size = new System.Drawing.Size(561, 31);
		D310C625.TabIndex = 12;
		D310C625.Text = "Nhập nội dung comment";
		D310C625.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = D310C625;
		bunifuDragControl_0.Vertical = true;
		A727388C.AutomaticDelay = 0;
		A727388C.AutoPopDelay = 10000;
		A727388C.InitialDelay = 200;
		A727388C.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(563, 355);
		base.Controls.Add(panel1);
		base.Controls.Add(FAB79EB4);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fNhapDuLieu3";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(FF31300B);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		D5A5158C.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)E9803514).EndInit();
		ResumeLayout(false);
	}
}
