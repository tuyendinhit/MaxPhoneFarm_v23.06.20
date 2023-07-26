using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapTokenTrungGian_DownAvatar : Form
{
	internal static bool A0064D3F;

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button EC98F7AC;

	internal Button CD2E5E92;

	internal Button btnAdd;

	internal BunifuDragControl D78F9B36;

	internal PictureBox pictureBox1;

	internal Button metroButton1;

	internal TextBox txtPathFolder;

	internal Label EFBD4738;

	public fNhapTokenTrungGian_DownAvatar()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		A0064D3F = false;
	}

	private void EC98F7AC_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
        SettingsTool.GetSettings("configGeneral").GetValue("pathFolderAvatar", (object)txtPathFolder.Text);
		SettingsTool.smethod_0("configGeneral");
		A0064D3F = true;
		Close();
	}

	private void D603E1AE(object sender, EventArgs e)
	{
		Close();
	}

	private void E0A28D02(object sender, EventArgs e)
	{
		txtPathFolder.Text = SettingsTool.GetSettings("configGeneral").GetValue("pathFolderAvatar");
	}

	private void metroButton1_Click(object sender, EventArgs e)
	{
		txtPathFolder.Text = Common.F68F9C11();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapTokenTrungGian_DownAvatar));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		EC98F7AC = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		CD2E5E92 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		D78F9B36 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		metroButton1 = new System.Windows.Forms.Button();
		txtPathFolder = new System.Windows.Forms.TextBox();
		EFBD4738 = new System.Windows.Forms.Label();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(449, 34);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(EC98F7AC);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(449, 28);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		EC98F7AC.Cursor = System.Windows.Forms.Cursors.Hand;
		EC98F7AC.Dock = System.Windows.Forms.DockStyle.Right;
		EC98F7AC.FlatAppearance.BorderSize = 0;
		EC98F7AC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EC98F7AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EC98F7AC.ForeColor = System.Drawing.Color.White;
		EC98F7AC.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		EC98F7AC.Location = new System.Drawing.Point(417, 0);
		EC98F7AC.Name = "btnMinimize";
		EC98F7AC.Size = new System.Drawing.Size(32, 28);
		EC98F7AC.TabIndex = 9;
		EC98F7AC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		EC98F7AC.UseVisualStyleBackColor = true;
		EC98F7AC.Click += new System.EventHandler(EC98F7AC_Click);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(449, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Cấu hình Tải xuống avatar";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		CD2E5E92.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		CD2E5E92.BackColor = System.Drawing.Color.Maroon;
		CD2E5E92.Cursor = System.Windows.Forms.Cursors.Hand;
		CD2E5E92.FlatAppearance.BorderSize = 0;
		CD2E5E92.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CD2E5E92.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CD2E5E92.ForeColor = System.Drawing.Color.White;
		CD2E5E92.Location = new System.Drawing.Point(248, 109);
		CD2E5E92.Name = "btnCancel";
		CD2E5E92.Size = new System.Drawing.Size(92, 29);
		CD2E5E92.TabIndex = 4;
		CD2E5E92.Text = "Đo\u0301ng";
		CD2E5E92.UseVisualStyleBackColor = false;
		CD2E5E92.Click += new System.EventHandler(D603E1AE);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(144, 109);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		D78F9B36.Fixed = true;
		D78F9B36.Horizontal = true;
		D78F9B36.TargetControl = bunifuCustomLabel1;
		D78F9B36.Vertical = true;
		metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
		metroButton1.Location = new System.Drawing.Point(346, 58);
		metroButton1.Name = "metroButton1";
		metroButton1.Size = new System.Drawing.Size(61, 23);
		metroButton1.TabIndex = 37;
		metroButton1.Text = "Chọn";
		metroButton1.Click += new System.EventHandler(metroButton1_Click);
		txtPathFolder.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtPathFolder.Location = new System.Drawing.Point(144, 58);
		txtPathFolder.Name = "txtPathFolder";
		txtPathFolder.Size = new System.Drawing.Size(196, 23);
		txtPathFolder.TabIndex = 35;
		EFBD4738.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EFBD4738.Location = new System.Drawing.Point(26, 61);
		EFBD4738.Name = "label1";
		EFBD4738.Size = new System.Drawing.Size(112, 16);
		EFBD4738.TabIndex = 36;
		EFBD4738.Text = "Nơi lưu Avatar:";
		EFBD4738.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(449, 153);
		base.Controls.Add(EFBD4738);
		base.Controls.Add(txtPathFolder);
		base.Controls.Add(metroButton1);
		base.Controls.Add(CD2E5E92);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fNhapTokenTrungGian_DownAvatar";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(E0A28D02);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
