using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTaoThuMucMedia : Form
{
	internal JSON_Settings f72FAFBC_0 = null;

	internal bool A3348C34 = false;

	internal IContainer D324EE2E = null;

	internal BunifuCards bunifuCards1;

	internal Panel C69F6096;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Button FD9F43A4;

	internal Button btnAdd;

	internal Label A4BE508C;

	internal BunifuDragControl F7037B8B;

	internal PictureBox pictureBox1;

	internal TextBox txtFolderSave;

	internal Label label2;

	internal TextBox txtFolderMedia;

	public fTaoThuMucMedia(JSON_Settings f72FAFBC_1)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		f72FAFBC_0 = f72FAFBC_1;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtFolderMedia.Text.Trim();
		string text2 = txtFolderSave.Text.Trim();
		if (text == "" || text2 == "")
		{
			MessageBoxHelper.Show("Không được để trống!", 3);
			return;
		}
		if (!Directory.Exists(text))
		{
			MessageBoxHelper.Show("Thư mục media không tồn tại!", 3);
			return;
		}
		if (!Directory.Exists(text2))
		{
			MessageBoxHelper.Show("Thư mục lưu không tồn tại!", 3);
			return;
		}
        f72FAFBC_0.GetValue("txtFolderMedia", (object)txtFolderMedia.Text.Trim());
        f72FAFBC_0.GetValue("txtFolderSave", (object)txtFolderSave.Text.Trim());
		Close();
	}

	private void B23A0B0C(object sender, EventArgs e)
	{
		Close();
	}

	private void txtFolderMedia_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			btnAdd_Click(null, null);
		}
	}

	private void fTaoThuMucMedia_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && D324EE2E != null)
		{
			D324EE2E.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		D324EE2E = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTaoThuMucMedia));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		C69F6096 = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		FD9F43A4 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		A4BE508C = new System.Windows.Forms.Label();
		F7037B8B = new Bunifu.Framework.UI.BunifuDragControl(D324EE2E);
		txtFolderSave = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		txtFolderMedia = new System.Windows.Forms.TextBox();
		bunifuCards1.SuspendLayout();
		C69F6096.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(C69F6096);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(396, 38);
		bunifuCards1.TabIndex = 0;
		C69F6096.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C69F6096.BackColor = System.Drawing.Color.White;
		C69F6096.Controls.Add(pictureBox1);
		C69F6096.Controls.Add(btnMinimize);
		C69F6096.Controls.Add(bunifuCustomLabel1);
		C69F6096.Location = new System.Drawing.Point(0, 5);
		C69F6096.Name = "pnlHeader";
		C69F6096.Size = new System.Drawing.Size(396, 32);
		C69F6096.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(4, 1);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 77;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(362, -2);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(396, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Cấu hình";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FD9F43A4.BackColor = System.Drawing.Color.Maroon;
		FD9F43A4.Cursor = System.Windows.Forms.Cursors.Hand;
		FD9F43A4.FlatAppearance.BorderSize = 0;
		FD9F43A4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FD9F43A4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FD9F43A4.ForeColor = System.Drawing.Color.White;
		FD9F43A4.Location = new System.Drawing.Point(204, 138);
		FD9F43A4.Name = "btnCancel";
		FD9F43A4.Size = new System.Drawing.Size(92, 29);
		FD9F43A4.TabIndex = 3;
		FD9F43A4.Text = "Hủy";
		FD9F43A4.UseVisualStyleBackColor = false;
		FD9F43A4.Click += new System.EventHandler(B23A0B0C);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(100, 138);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 2;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		A4BE508C.AutoSize = true;
		A4BE508C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A4BE508C.Location = new System.Drawing.Point(33, 69);
		A4BE508C.Name = "label1";
		A4BE508C.Size = new System.Drawing.Size(87, 16);
		A4BE508C.TabIndex = 20;
		A4BE508C.Text = "Folder media:";
		F7037B8B.Fixed = true;
		F7037B8B.Horizontal = true;
		F7037B8B.TargetControl = bunifuCustomLabel1;
		F7037B8B.Vertical = true;
		txtFolderSave.Location = new System.Drawing.Point(124, 95);
		txtFolderSave.Name = "txtFolderSave";
		txtFolderSave.Size = new System.Drawing.Size(235, 23);
		txtFolderSave.TabIndex = 1;
		txtFolderSave.KeyDown += new System.Windows.Forms.KeyEventHandler(txtFolderMedia_KeyDown);
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label2.Location = new System.Drawing.Point(33, 98);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(70, 16);
		label2.TabIndex = 20;
		label2.Text = "Folder lưu:";
		txtFolderMedia.Location = new System.Drawing.Point(124, 66);
		txtFolderMedia.Name = "txtFolderMedia";
		txtFolderMedia.Size = new System.Drawing.Size(235, 23);
		txtFolderMedia.TabIndex = 0;
		txtFolderMedia.KeyDown += new System.Windows.Forms.KeyEventHandler(txtFolderMedia_KeyDown);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(396, 182);
		base.Controls.Add(label2);
		base.Controls.Add(A4BE508C);
		base.Controls.Add(FD9F43A4);
		base.Controls.Add(btnAdd);
		base.Controls.Add(txtFolderMedia);
		base.Controls.Add(txtFolderSave);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fTaoThuMucMedia";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fTaoThuMucMedia_Load);
		bunifuCards1.ResumeLayout(false);
		C69F6096.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
