using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhBackupGroup : Form
{
	internal bool DA885494 = false;

	internal IContainer C1234601 = null;

	internal BunifuCards bunifuCards1;

	internal Panel D2098F9A;

	internal BunifuCustomLabel BC03909C;

	internal Button FEBC1F0D;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuDragControl bunifuDragControl_0;

	internal PictureBox pictureBox1;

	internal CheckBox D7ABD2A5;

	internal Label EE1608AF;

	internal RadioButton rbRunByPhone;

	internal RadioButton E0ACEC21;

	public fCauHinhBackupGroup()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void FEBC1F0D_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FA33801D(object sender, EventArgs e)
	{
		if (rbRunByPhone.Checked)
		{
			SettingsTool.GetSettings("configBackupGroup").GetValue("typeRun", 0);
		}
		else if (E0ACEC21.Checked)
		{
			SettingsTool.GetSettings("configBackupGroup").GetValue("typeRun", 1);
		}
		SettingsTool.GetSettings("configBackupGroup").GetValue("ckbCheckNhomKiemDuyet", D7ABD2A5.Checked);
		SettingsTool.smethod_0("configBackupGroup");
		DA885494 = true;
		Close();
	}

	private void FA935D0C(object sender, EventArgs e)
	{
		Close();
	}

	private void fCauHinhBackupGroup_Load(object sender, EventArgs e)
	{
		switch (SettingsTool.GetSettings("configBackupGroup").method_0("typeRun"))
		{
		case 1:
			E0ACEC21.Checked = true;
			break;
		case 0:
			rbRunByPhone.Checked = true;
			break;
		}
		D7ABD2A5.Checked = SettingsTool.GetSettings("configBackupGroup").AA824D29("ckbCheckNhomKiemDuyet");
	}

	private void E0ACEC21_Click(object sender, EventArgs e)
	{
		if (E0ACEC21.Checked && MessageBoxHelper.smethod_1(Language.GetValue("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) == DialogResult.No)
		{
			E0ACEC21.Checked = false;
		}
	}

	private void D7ABD2A5_Click(object sender, EventArgs e)
	{
		if (D7ABD2A5.Checked && MessageBoxHelper.smethod_1(Language.GetValue("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) == DialogResult.No)
		{
			D7ABD2A5.Checked = false;
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && C1234601 != null)
		{
			C1234601.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		C1234601 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhBackupGroup));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		D2098F9A = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		FEBC1F0D = new System.Windows.Forms.Button();
		BC03909C = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(C1234601);
		D7ABD2A5 = new System.Windows.Forms.CheckBox();
		EE1608AF = new System.Windows.Forms.Label();
		rbRunByPhone = new System.Windows.Forms.RadioButton();
		E0ACEC21 = new System.Windows.Forms.RadioButton();
		bunifuCards1.SuspendLayout();
		D2098F9A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(D2098F9A);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(319, 38);
		bunifuCards1.TabIndex = 0;
		D2098F9A.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D2098F9A.BackColor = System.Drawing.Color.White;
		D2098F9A.Controls.Add(pictureBox1);
		D2098F9A.Controls.Add(FEBC1F0D);
		D2098F9A.Controls.Add(BC03909C);
		D2098F9A.Location = new System.Drawing.Point(0, 5);
		D2098F9A.Name = "pnlHeader";
		D2098F9A.Size = new System.Drawing.Size(319, 32);
		D2098F9A.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		FEBC1F0D.Cursor = System.Windows.Forms.Cursors.Hand;
		FEBC1F0D.Dock = System.Windows.Forms.DockStyle.Right;
		FEBC1F0D.FlatAppearance.BorderSize = 0;
		FEBC1F0D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FEBC1F0D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FEBC1F0D.ForeColor = System.Drawing.Color.White;
		FEBC1F0D.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		FEBC1F0D.Location = new System.Drawing.Point(287, 0);
		FEBC1F0D.Name = "btnMinimize";
		FEBC1F0D.Size = new System.Drawing.Size(32, 32);
		FEBC1F0D.TabIndex = 9;
		FEBC1F0D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		FEBC1F0D.UseVisualStyleBackColor = true;
		FEBC1F0D.Click += new System.EventHandler(FEBC1F0D_Click);
		BC03909C.BackColor = System.Drawing.Color.Transparent;
		BC03909C.Cursor = System.Windows.Forms.Cursors.SizeAll;
		BC03909C.Dock = System.Windows.Forms.DockStyle.Fill;
		BC03909C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BC03909C.ForeColor = System.Drawing.Color.Black;
		BC03909C.Location = new System.Drawing.Point(0, 0);
		BC03909C.Name = "bunifuCustomLabel1";
		BC03909C.Size = new System.Drawing.Size(319, 32);
		BC03909C.TabIndex = 1;
		BC03909C.Text = "Câ\u0301u hi\u0300nh Backup Group";
		BC03909C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(167, 147);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(FA935D0C);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(63, 147);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(FA33801D);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = BC03909C;
		bunifuDragControl_0.Vertical = true;
		D7ABD2A5.AutoSize = true;
		D7ABD2A5.Cursor = System.Windows.Forms.Cursors.Hand;
		D7ABD2A5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D7ABD2A5.Location = new System.Drawing.Point(67, 111);
		D7ABD2A5.Name = "ckbCheckNhomKiemDuyet";
		D7ABD2A5.Size = new System.Drawing.Size(162, 20);
		D7ABD2A5.TabIndex = 22;
		D7ABD2A5.Text = "Check nhóm kiểm duyệt";
		D7ABD2A5.UseVisualStyleBackColor = true;
		D7ABD2A5.Click += new System.EventHandler(D7ABD2A5_Click);
		EE1608AF.AutoSize = true;
		EE1608AF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EE1608AF.Location = new System.Drawing.Point(64, 62);
		EE1608AF.Name = "label1";
		EE1608AF.Size = new System.Drawing.Size(64, 16);
		EE1608AF.TabIndex = 23;
		EE1608AF.Text = "Tùy chọn:";
		rbRunByPhone.AutoSize = true;
		rbRunByPhone.Cursor = System.Windows.Forms.Cursors.Hand;
		rbRunByPhone.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		rbRunByPhone.Location = new System.Drawing.Point(134, 62);
		rbRunByPhone.Name = "rbRunByPhone";
		rbRunByPhone.Size = new System.Drawing.Size(112, 20);
		rbRunByPhone.TabIndex = 24;
		rbRunByPhone.TabStop = true;
		rbRunByPhone.Text = "Sử dụng phone";
		rbRunByPhone.UseVisualStyleBackColor = true;
		E0ACEC21.AutoSize = true;
		E0ACEC21.Cursor = System.Windows.Forms.Cursors.Hand;
		E0ACEC21.Enabled = false;
		E0ACEC21.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E0ACEC21.Location = new System.Drawing.Point(134, 85);
		E0ACEC21.Name = "rbRunHidden";
		E0ACEC21.Size = new System.Drawing.Size(121, 20);
		E0ACEC21.TabIndex = 24;
		E0ACEC21.TabStop = true;
		E0ACEC21.Text = "Chạy ẩn (cookie)";
		E0ACEC21.UseVisualStyleBackColor = true;
		E0ACEC21.Click += new System.EventHandler(E0ACEC21_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(319, 189);
		base.Controls.Add(E0ACEC21);
		base.Controls.Add(rbRunByPhone);
		base.Controls.Add(EE1608AF);
		base.Controls.Add(D7ABD2A5);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhBackupGroup";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhBackupGroup_Load);
		bunifuCards1.ResumeLayout(false);
		D2098F9A.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
