using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapCookieTrungGian : Form
{
	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel ACAE960C;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button AABACC25;

	internal Button A19573A5;

	internal Button btnAdd;

	internal BunifuDragControl bunifuDragControl_0;

	internal PictureBox pictureBox1;

	internal Label label2;

	internal TextBox txtCookie;

	internal Button C42EF68E;

	public fNhapCookieTrungGian()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		bool_0 = false;
	}

	private void EB9D4186(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
        SettingsTool.GetSettings("configGeneral").GetValue("cookie", (object)txtCookie.Text);
		SettingsTool.smethod_0("configGeneral");
		bool_0 = true;
		Close();
	}

	private void A19573A5_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fNhapCookieTrungGian_Load(object sender, EventArgs e)
	{
		txtCookie.Text = SettingsTool.GetSettings("configGeneral").GetValue("cookie");
	}

	private void C42EF68E_Click(object sender, EventArgs e)
	{
		if (EA98BF20.smethod_3(txtCookie.Text, "", "", 0).StartsWith("1|"))
		{
			MessageBoxHelper.Show("Cookie live!");
		}
		else
		{
			MessageBoxHelper.Show("Cookie die!");
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapCookieTrungGian));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		ACAE960C = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		AABACC25 = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		A19573A5 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		label2 = new System.Windows.Forms.Label();
		txtCookie = new System.Windows.Forms.TextBox();
		C42EF68E = new System.Windows.Forms.Button();
		bunifuCards1.SuspendLayout();
		ACAE960C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(ACAE960C);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(449, 34);
		bunifuCards1.TabIndex = 0;
		ACAE960C.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		ACAE960C.BackColor = System.Drawing.Color.White;
		ACAE960C.Controls.Add(pictureBox1);
		ACAE960C.Controls.Add(AABACC25);
		ACAE960C.Controls.Add(bunifuCustomLabel1);
		ACAE960C.Location = new System.Drawing.Point(0, 3);
		ACAE960C.Name = "pnlHeader";
		ACAE960C.Size = new System.Drawing.Size(449, 28);
		ACAE960C.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		AABACC25.Cursor = System.Windows.Forms.Cursors.Hand;
		AABACC25.Dock = System.Windows.Forms.DockStyle.Right;
		AABACC25.FlatAppearance.BorderSize = 0;
		AABACC25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AABACC25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		AABACC25.ForeColor = System.Drawing.Color.White;
		AABACC25.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		AABACC25.Location = new System.Drawing.Point(417, 0);
		AABACC25.Name = "btnMinimize";
		AABACC25.Size = new System.Drawing.Size(32, 28);
		AABACC25.TabIndex = 9;
		AABACC25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		AABACC25.UseVisualStyleBackColor = true;
		AABACC25.Click += new System.EventHandler(EB9D4186);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(449, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Nhập Cookie trung gian";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A19573A5.BackColor = System.Drawing.Color.Maroon;
		A19573A5.Cursor = System.Windows.Forms.Cursors.Hand;
		A19573A5.FlatAppearance.BorderSize = 0;
		A19573A5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A19573A5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A19573A5.ForeColor = System.Drawing.Color.White;
		A19573A5.Location = new System.Drawing.Point(230, 112);
		A19573A5.Name = "btnCancel";
		A19573A5.Size = new System.Drawing.Size(92, 29);
		A19573A5.TabIndex = 4;
		A19573A5.Text = "Đo\u0301ng";
		A19573A5.UseVisualStyleBackColor = false;
		A19573A5.Click += new System.EventHandler(A19573A5_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(126, 112);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(31, 61);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(113, 16);
		label2.TabIndex = 36;
		label2.Text = "Cookie trung gian:";
		label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		txtCookie.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtCookie.Location = new System.Drawing.Point(147, 58);
		txtCookie.Name = "txtCookie";
		txtCookie.Size = new System.Drawing.Size(196, 23);
		txtCookie.TabIndex = 35;
		C42EF68E.Cursor = System.Windows.Forms.Cursors.Hand;
		C42EF68E.Location = new System.Drawing.Point(349, 58);
		C42EF68E.Name = "btnCheckLiveTokenTg";
		C42EF68E.Size = new System.Drawing.Size(61, 23);
		C42EF68E.TabIndex = 37;
		C42EF68E.Text = "Kiểm tra";
		C42EF68E.Click += new System.EventHandler(C42EF68E_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(449, 159);
		base.Controls.Add(label2);
		base.Controls.Add(txtCookie);
		base.Controls.Add(C42EF68E);
		base.Controls.Add(A19573A5);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fNhapCookieTrungGian";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fNhapCookieTrungGian_Load);
		bunifuCards1.ResumeLayout(false);
		ACAE960C.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
