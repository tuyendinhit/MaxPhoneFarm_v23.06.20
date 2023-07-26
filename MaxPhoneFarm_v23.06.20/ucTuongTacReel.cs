using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ucTuongTacReel : UserControl
{
	internal JSON_Settings F22BAD3B;

	internal IContainer icontainer_0 = null;

	internal Button btnSave;

	internal Button btnCancel;

	internal Panel plComment;

	internal RichTextBox DA37183F;

	internal Label B81235A3;

	internal CheckBox BA0A0A88;

	internal CheckBox D79110BE;

	internal CheckBox ckbInteract;

	internal NumericUpDown nudTimeTo;

	internal NumericUpDown nudTimeFrom;

	internal Label label13;

	internal Label label14;

	internal Label FB12AB13;

	internal Panel panel2;

	internal Button button3;

	internal RadioButton A39ED21A;

	internal Button button2;

	internal RadioButton DC3E52AD;

	internal Label D32D7E10;

	internal Label label11;

	public ucTuongTacReel(JSON_Settings f72FAFBC_0)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		F22BAD3B = f72FAFBC_0;
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Hide();
	}

	private void CA32A884(object sender, EventArgs e)
	{
		method_1();
		Hide();
	}

	private void method_0()
	{
		try
		{
			nudTimeFrom.Value = F22BAD3B.method_0("nudTimeFrom", 15);
			nudTimeTo.Value = F22BAD3B.method_0("nudTimeTo", 30);
			ckbInteract.Checked = F22BAD3B.AA824D29("ckbInteract");
			BA0A0A88.Checked = F22BAD3B.AA824D29("ckbComment");
			D79110BE.Checked = F22BAD3B.AA824D29("ckbShareWall");
			DA37183F.Text = F22BAD3B.GetValue("txtComment");
			if (F22BAD3B.method_0("typeNganCachCommentReel") == 1)
			{
				DC3E52AD.Checked = true;
			}
			else
			{
				A39ED21A.Checked = true;
			}
			BA0A0A88_CheckedChanged(null, null);
		}
		catch
		{
		}
	}

	private void method_1()
	{
		F22BAD3B.GetValue("nudTimeFrom", nudTimeFrom.Value);
		F22BAD3B.GetValue("nudTimeTo", nudTimeTo.Value);
		F22BAD3B.GetValue("ckbInteract", ckbInteract.Checked);
		F22BAD3B.GetValue("ckbShareWall", D79110BE.Checked);
		F22BAD3B.GetValue("ckbComment", BA0A0A88.Checked);
        F22BAD3B.GetValue("txtComment", (object)DA37183F.Text.Trim());
		int num = 0;
		if (DC3E52AD.Checked)
		{
			num = 1;
		}
		F22BAD3B.GetValue("typeNganCachCommentReel", num);
	}

	private void ucTuongTacReel_Load(object sender, EventArgs e)
	{
		method_0();
	}

	private void ucTuongTacReel_VisibleChanged(object sender, EventArgs e)
	{
		if (base.Visible)
		{
			method_0();
		}
	}

	private void BA0A0A88_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = BA0A0A88.Checked;
	}

	private void DA37183F_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(DA37183F, B81235A3, DC3E52AD.Checked ? 1 : 0);
	}

	private void FA0FBA15(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		DA37183F.Focus();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fHelpNhapComment());
		DA37183F.Focus();
	}

	private void A39ED21A_CheckedChanged(object sender, EventArgs e)
	{
		Common.D936DD84(DA37183F, B81235A3, DC3E52AD.Checked ? 1 : 0);
	}

	private void AC1E9F2F(object sender, EventArgs e)
	{
		Common.D936DD84(DA37183F, B81235A3, DC3E52AD.Checked ? 1 : 0);
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
		btnSave = new System.Windows.Forms.Button();
		btnCancel = new System.Windows.Forms.Button();
		plComment = new System.Windows.Forms.Panel();
		DA37183F = new System.Windows.Forms.RichTextBox();
		B81235A3 = new System.Windows.Forms.Label();
		BA0A0A88 = new System.Windows.Forms.CheckBox();
		D79110BE = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudTimeTo = new System.Windows.Forms.NumericUpDown();
		nudTimeFrom = new System.Windows.Forms.NumericUpDown();
		label13 = new System.Windows.Forms.Label();
		label14 = new System.Windows.Forms.Label();
		FB12AB13 = new System.Windows.Forms.Label();
		panel2 = new System.Windows.Forms.Panel();
		button3 = new System.Windows.Forms.Button();
		A39ED21A = new System.Windows.Forms.RadioButton();
		button2 = new System.Windows.Forms.Button();
		DC3E52AD = new System.Windows.Forms.RadioButton();
		D32D7E10 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).BeginInit();
		panel2.SuspendLayout();
		SuspendLayout();
		btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnSave.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
		btnSave.FlatAppearance.BorderSize = 0;
		btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnSave.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnSave.ForeColor = System.Drawing.Color.White;
		btnSave.Location = new System.Drawing.Point(71, 398);
		btnSave.Name = "btnSave";
		btnSave.Size = new System.Drawing.Size(92, 29);
		btnSave.TabIndex = 180;
		btnSave.Text = "Lưu";
		btnSave.UseVisualStyleBackColor = false;
		btnSave.Click += new System.EventHandler(CA32A884);
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(181, 398);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 181;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(panel2);
		plComment.Controls.Add(D32D7E10);
		plComment.Controls.Add(label11);
		plComment.Controls.Add(DA37183F);
		plComment.Controls.Add(B81235A3);
		plComment.Location = new System.Drawing.Point(37, 98);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(278, 284);
		plComment.TabIndex = 187;
		DA37183F.Location = new System.Drawing.Point(6, 24);
		DA37183F.Name = "txtComment";
		DA37183F.Size = new System.Drawing.Size(264, 191);
		DA37183F.TabIndex = 45;
		DA37183F.Text = "";
		DA37183F.WordWrap = false;
		DA37183F.TextChanged += new System.EventHandler(DA37183F_TextChanged);
		B81235A3.AutoSize = true;
		B81235A3.Location = new System.Drawing.Point(3, 5);
		B81235A3.Name = "lblStatus";
		B81235A3.Size = new System.Drawing.Size(139, 16);
		B81235A3.TabIndex = 0;
		B81235A3.Text = "Nội dung bình luận (0):";
		BA0A0A88.AutoSize = true;
		BA0A0A88.Cursor = System.Windows.Forms.Cursors.Hand;
		BA0A0A88.Location = new System.Drawing.Point(19, 72);
		BA0A0A88.Name = "ckbComment";
		BA0A0A88.Size = new System.Drawing.Size(81, 20);
		BA0A0A88.TabIndex = 186;
		BA0A0A88.Text = "Comment";
		BA0A0A88.UseVisualStyleBackColor = true;
		BA0A0A88.CheckedChanged += new System.EventHandler(BA0A0A88_CheckedChanged);
		D79110BE.AutoSize = true;
		D79110BE.Cursor = System.Windows.Forms.Cursors.Hand;
		D79110BE.Location = new System.Drawing.Point(121, 46);
		D79110BE.Name = "ckbShareWall";
		D79110BE.Size = new System.Drawing.Size(89, 20);
		D79110BE.TabIndex = 185;
		D79110BE.Text = "Share Wall";
		D79110BE.UseVisualStyleBackColor = true;
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(19, 46);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(48, 20);
		ckbInteract.TabIndex = 184;
		ckbInteract.Text = "Like";
		ckbInteract.UseVisualStyleBackColor = true;
		nudTimeTo.Location = new System.Drawing.Point(218, 17);
		nudTimeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeTo.Name = "nudTimeTo";
		nudTimeTo.Size = new System.Drawing.Size(56, 23);
		nudTimeTo.TabIndex = 183;
		nudTimeFrom.Location = new System.Drawing.Point(121, 17);
		nudTimeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTimeFrom.Name = "nudTimeFrom";
		nudTimeFrom.Size = new System.Drawing.Size(56, 23);
		nudTimeFrom.TabIndex = 182;
		label13.Location = new System.Drawing.Point(183, 19);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(29, 16);
		label13.TabIndex = 190;
		label13.Text = "đê\u0301n";
		label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label14.AutoSize = true;
		label14.Location = new System.Drawing.Point(279, 19);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(30, 16);
		label14.TabIndex = 189;
		label14.Text = "giây";
		FB12AB13.AutoSize = true;
		FB12AB13.Location = new System.Drawing.Point(16, 19);
		FB12AB13.Name = "label21";
		FB12AB13.Size = new System.Drawing.Size(93, 16);
		FB12AB13.TabIndex = 188;
		FB12AB13.Text = "Thơ\u0300i gian xem:";
		panel2.Controls.Add(button3);
		panel2.Controls.Add(A39ED21A);
		panel2.Controls.Add(button2);
		panel2.Controls.Add(DC3E52AD);
		panel2.Location = new System.Drawing.Point(65, 237);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(200, 43);
		panel2.TabIndex = 182;
		button3.Cursor = System.Windows.Forms.Cursors.Help;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.Location = new System.Drawing.Point(165, 22);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(21, 21);
		button3.TabIndex = 172;
		button3.Text = "?";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		A39ED21A.AutoSize = true;
		A39ED21A.Checked = true;
		A39ED21A.Cursor = System.Windows.Forms.Cursors.Hand;
		A39ED21A.Location = new System.Drawing.Point(3, 3);
		A39ED21A.Name = "rbNganCachMoiDong";
		A39ED21A.Size = new System.Drawing.Size(155, 20);
		A39ED21A.TabIndex = 3;
		A39ED21A.TabStop = true;
		A39ED21A.Text = "Nội dung chỉ có 1 dòng";
		A39ED21A.UseVisualStyleBackColor = true;
		A39ED21A.CheckedChanged += new System.EventHandler(A39ED21A_CheckedChanged);
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(165, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(21, 21);
		button2.TabIndex = 173;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(FA0FBA15);
		DC3E52AD.AutoSize = true;
		DC3E52AD.Cursor = System.Windows.Forms.Cursors.Hand;
		DC3E52AD.Location = new System.Drawing.Point(3, 24);
		DC3E52AD.Name = "rbNganCachKyTu";
		DC3E52AD.Size = new System.Drawing.Size(159, 20);
		DC3E52AD.TabIndex = 3;
		DC3E52AD.Text = "Nội dung có nhiều dòng";
		DC3E52AD.UseVisualStyleBackColor = true;
		DC3E52AD.CheckedChanged += new System.EventHandler(AC1E9F2F);
		D32D7E10.AutoSize = true;
		D32D7E10.Location = new System.Drawing.Point(2, 240);
		D32D7E10.Name = "label3";
		D32D7E10.Size = new System.Drawing.Size(64, 16);
		D32D7E10.TabIndex = 181;
		D32D7E10.Text = "Tùy chọn:";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(3, 218);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(133, 16);
		label11.TabIndex = 180;
		label11.Text = "Spin nội dung {a|b|c}";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.White;
		base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		base.Controls.Add(plComment);
		base.Controls.Add(BA0A0A88);
		base.Controls.Add(D79110BE);
		base.Controls.Add(ckbInteract);
		base.Controls.Add(nudTimeTo);
		base.Controls.Add(nudTimeFrom);
		base.Controls.Add(label13);
		base.Controls.Add(label14);
		base.Controls.Add(FB12AB13);
		base.Controls.Add(btnSave);
		base.Controls.Add(btnCancel);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Name = "ucTuongTacReel";
		base.Size = new System.Drawing.Size(340, 440);
		base.Load += new System.EventHandler(ucTuongTacReel_Load);
		base.VisibleChanged += new System.EventHandler(ucTuongTacReel_VisibleChanged);
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudTimeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTimeFrom).EndInit();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}
}
