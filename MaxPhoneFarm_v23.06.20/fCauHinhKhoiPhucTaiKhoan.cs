using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhKhoiPhucTaiKhoan : Form
{
	internal static bool bool_0 = false;

	internal static int A01AC2AD = 0;

	internal static string F6371800 = "";

	internal int int_0 = 0;

	internal IContainer icontainer_0 = null;

	internal BunifuCards B4B2B0BC;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Button CB25790A;

	internal Button btnAdd;

	internal BunifuDragControl F330623D;

	internal PictureBox pictureBox1;

	internal RadioButton rbThuMucCu;

	internal RadioButton FE9EF73B;

	internal Button BBA5D626;

	internal ComboBox A4052191;

	internal Panel plThuMucKhac;

	public fCauHinhKhoiPhucTaiKhoan()
	{
		InitializeComponent();
		method_0();
		Language.SetLanguage(this);
		bool_0 = false;
		A01AC2AD = 0;
		F6371800 = "";
	}

	private void EA2B7C28()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(rbThuMucCu);
		Language.smethod_1(FE9EF73B);
		Language.smethod_1(BBA5D626);
		Language.smethod_1(btnAdd);
		Language.smethod_1(CB25790A);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B29AA213(object sender, EventArgs e)
	{
		if (FE9EF73B.Checked)
		{
			if (A4052191.SelectedIndex == -1)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng thêm thư mục để lưu tài khoản!"), 3);
				return;
			}
			A01AC2AD = 1;
			F6371800 = A4052191.SelectedValue.ToString();
		}
		bool_0 = true;
		Close();
	}

	private void CB25790A_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fCauHinhKhoiPhucTaiKhoan_Load(object sender, EventArgs e)
	{
		D1802131(null, null);
	}

	private void EA1359A1(object sender, EventArgs e)
	{
		fAddFile form_ = new fAddFile();
		Common.smethod_16(form_);
		if (fAddFile.bool_0)
		{
			method_0();
			A4052191.SelectedIndex = A4052191.Items.Count - 1;
		}
	}

	private void method_0()
	{
		int_0 = A4052191.SelectedIndex;
		DataTable dataTable = CommonSQL.smethod_0();
		if (dataTable.Rows.Count > 0)
		{
			A4052191.DataSource = dataTable;
			A4052191.ValueMember = "id";
			A4052191.DisplayMember = "name";
			if (int_0 == -1)
			{
				int_0 = 0;
			}
			A4052191.SelectedIndex = int_0;
		}
	}

	private void D1802131(object sender, EventArgs e)
	{
		plThuMucKhac.Enabled = FE9EF73B.Checked;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhKhoiPhucTaiKhoan));
		B4B2B0BC = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		CB25790A = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		F330623D = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		rbThuMucCu = new System.Windows.Forms.RadioButton();
		FE9EF73B = new System.Windows.Forms.RadioButton();
		BBA5D626 = new System.Windows.Forms.Button();
		A4052191 = new System.Windows.Forms.ComboBox();
		plThuMucKhac = new System.Windows.Forms.Panel();
		B4B2B0BC.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		plThuMucKhac.SuspendLayout();
		SuspendLayout();
		B4B2B0BC.BackColor = System.Drawing.Color.White;
		B4B2B0BC.BorderRadius = 0;
		B4B2B0BC.BottomSahddow = true;
		B4B2B0BC.color = System.Drawing.Color.SaddleBrown;
		B4B2B0BC.Controls.Add(pnlHeader);
		B4B2B0BC.Dock = System.Windows.Forms.DockStyle.Top;
		B4B2B0BC.LeftSahddow = false;
		B4B2B0BC.Location = new System.Drawing.Point(0, 0);
		B4B2B0BC.Name = "bunifuCards1";
		B4B2B0BC.RightSahddow = true;
		B4B2B0BC.ShadowDepth = 20;
		B4B2B0BC.Size = new System.Drawing.Size(365, 34);
		B4B2B0BC.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(365, 28);
		pnlHeader.TabIndex = 9;
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
		btnMinimize.Location = new System.Drawing.Point(333, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 28);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(365, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh Khôi phu\u0323c ta\u0300i khoa\u0309n";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		CB25790A.BackColor = System.Drawing.Color.Maroon;
		CB25790A.Cursor = System.Windows.Forms.Cursors.Hand;
		CB25790A.FlatAppearance.BorderSize = 0;
		CB25790A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CB25790A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CB25790A.ForeColor = System.Drawing.Color.White;
		CB25790A.Location = new System.Drawing.Point(188, 162);
		CB25790A.Name = "btnCancel";
		CB25790A.Size = new System.Drawing.Size(92, 29);
		CB25790A.TabIndex = 4;
		CB25790A.Text = "Đo\u0301ng";
		CB25790A.UseVisualStyleBackColor = false;
		CB25790A.Click += new System.EventHandler(CB25790A_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(84, 162);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(B29AA213);
		F330623D.Fixed = true;
		F330623D.Horizontal = true;
		F330623D.TargetControl = bunifuCustomLabel1;
		F330623D.Vertical = true;
		rbThuMucCu.AutoSize = true;
		rbThuMucCu.Checked = true;
		rbThuMucCu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbThuMucCu.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		rbThuMucCu.Location = new System.Drawing.Point(36, 56);
		rbThuMucCu.Name = "rbThuMucCu";
		rbThuMucCu.Size = new System.Drawing.Size(165, 20);
		rbThuMucCu.TabIndex = 5;
		rbThuMucCu.TabStop = true;
		rbThuMucCu.Text = "Khôi phu\u0323c vê\u0300 thư mu\u0323c cu\u0303";
		rbThuMucCu.UseVisualStyleBackColor = true;
		FE9EF73B.AutoSize = true;
		FE9EF73B.Cursor = System.Windows.Forms.Cursors.Hand;
		FE9EF73B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FE9EF73B.Location = new System.Drawing.Point(36, 82);
		FE9EF73B.Name = "rbThuMucKhac";
		FE9EF73B.Size = new System.Drawing.Size(179, 20);
		FE9EF73B.TabIndex = 5;
		FE9EF73B.Text = "Chuyê\u0309n sang thư mu\u0323c kha\u0301c";
		FE9EF73B.UseVisualStyleBackColor = true;
		FE9EF73B.CheckedChanged += new System.EventHandler(D1802131);
		BBA5D626.Cursor = System.Windows.Forms.Cursors.Hand;
		BBA5D626.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BBA5D626.Location = new System.Drawing.Point(210, 2);
		BBA5D626.Name = "button1";
		BBA5D626.Size = new System.Drawing.Size(62, 27);
		BBA5D626.TabIndex = 48;
		BBA5D626.Text = "Thêm";
		BBA5D626.UseVisualStyleBackColor = true;
		BBA5D626.Click += new System.EventHandler(EA1359A1);
		A4052191.Cursor = System.Windows.Forms.Cursors.Hand;
		A4052191.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		A4052191.DropDownWidth = 269;
		A4052191.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A4052191.FormattingEnabled = true;
		A4052191.Location = new System.Drawing.Point(3, 3);
		A4052191.Name = "cbbThuMuc";
		A4052191.Size = new System.Drawing.Size(201, 24);
		A4052191.TabIndex = 47;
		plThuMucKhac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plThuMucKhac.Controls.Add(A4052191);
		plThuMucKhac.Controls.Add(BBA5D626);
		plThuMucKhac.Location = new System.Drawing.Point(55, 108);
		plThuMucKhac.Name = "plThuMucKhac";
		plThuMucKhac.Size = new System.Drawing.Size(278, 33);
		plThuMucKhac.TabIndex = 49;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(365, 205);
		base.Controls.Add(plThuMucKhac);
		base.Controls.Add(FE9EF73B);
		base.Controls.Add(rbThuMucCu);
		base.Controls.Add(CB25790A);
		base.Controls.Add(btnAdd);
		base.Controls.Add(B4B2B0BC);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhKhoiPhucTaiKhoan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhKhoiPhucTaiKhoan_Load);
		B4B2B0BC.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		plThuMucKhac.ResumeLayout(false);
		ResumeLayout(false);
		PerformLayout();
	}
}
