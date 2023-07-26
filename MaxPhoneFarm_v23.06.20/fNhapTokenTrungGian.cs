using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapTokenTrungGian : Form
{
	internal static bool F08FF18B;

	internal IContainer icontainer_0 = null;

	internal BunifuCards A68AD00E;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button A2894F1D;

	internal Button AD3B5521;

	internal Button btnAdd;

	internal BunifuDragControl A12B0A87;

	internal PictureBox D6307906;

	internal Label A98AE91B;

	internal TextBox token;

	internal Button FCAEEC16;

	public fNhapTokenTrungGian()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		F08FF18B = false;
	}

	private void A533A004(object sender, EventArgs e)
	{
		Close();
	}

	private void B6233D26(object sender, EventArgs e)
	{
        SettingsTool.GetSettings("configGeneral").GetValue("token", (object)token.Text);
		SettingsTool.smethod_0("configGeneral");
		F08FF18B = true;
		Close();
	}

	private void AD3B5521_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fNhapTokenTrungGian_Load(object sender, EventArgs e)
	{
		token.Text = SettingsTool.GetSettings("configGeneral").GetValue("token");
	}

	private void FCAEEC16_Click(object sender, EventArgs e)
	{
		if (EA98BF20.D90D78B1("", token.Text, "", ""))
		{
			MessageBoxHelper.Show("Token live!");
		}
		else
		{
			MessageBoxHelper.Show("Token die!");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapTokenTrungGian));
		A68AD00E = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		D6307906 = new System.Windows.Forms.PictureBox();
		A2894F1D = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		AD3B5521 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		A12B0A87 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		A98AE91B = new System.Windows.Forms.Label();
		token = new System.Windows.Forms.TextBox();
		FCAEEC16 = new System.Windows.Forms.Button();
		A68AD00E.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D6307906).BeginInit();
		SuspendLayout();
		A68AD00E.BackColor = System.Drawing.Color.White;
		A68AD00E.BorderRadius = 0;
		A68AD00E.BottomSahddow = true;
		A68AD00E.color = System.Drawing.Color.SaddleBrown;
		A68AD00E.Controls.Add(pnlHeader);
		A68AD00E.Dock = System.Windows.Forms.DockStyle.Top;
		A68AD00E.LeftSahddow = false;
		A68AD00E.Location = new System.Drawing.Point(0, 0);
		A68AD00E.Name = "bunifuCards1";
		A68AD00E.RightSahddow = true;
		A68AD00E.ShadowDepth = 20;
		A68AD00E.Size = new System.Drawing.Size(449, 34);
		A68AD00E.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(D6307906);
		pnlHeader.Controls.Add(A2894F1D);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(449, 28);
		pnlHeader.TabIndex = 9;
		D6307906.Cursor = System.Windows.Forms.Cursors.Default;
		D6307906.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		D6307906.Location = new System.Drawing.Point(3, 2);
		D6307906.Name = "pictureBox1";
		D6307906.Size = new System.Drawing.Size(34, 27);
		D6307906.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		D6307906.TabIndex = 17;
		D6307906.TabStop = false;
		A2894F1D.Cursor = System.Windows.Forms.Cursors.Hand;
		A2894F1D.Dock = System.Windows.Forms.DockStyle.Right;
		A2894F1D.FlatAppearance.BorderSize = 0;
		A2894F1D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A2894F1D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A2894F1D.ForeColor = System.Drawing.Color.White;
		A2894F1D.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		A2894F1D.Location = new System.Drawing.Point(417, 0);
		A2894F1D.Name = "btnMinimize";
		A2894F1D.Size = new System.Drawing.Size(32, 28);
		A2894F1D.TabIndex = 9;
		A2894F1D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		A2894F1D.UseVisualStyleBackColor = true;
		A2894F1D.Click += new System.EventHandler(A533A004);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(449, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Nhập Token trung gian";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		AD3B5521.BackColor = System.Drawing.Color.Maroon;
		AD3B5521.Cursor = System.Windows.Forms.Cursors.Hand;
		AD3B5521.FlatAppearance.BorderSize = 0;
		AD3B5521.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AD3B5521.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AD3B5521.ForeColor = System.Drawing.Color.White;
		AD3B5521.Location = new System.Drawing.Point(230, 112);
		AD3B5521.Name = "btnCancel";
		AD3B5521.Size = new System.Drawing.Size(92, 29);
		AD3B5521.TabIndex = 4;
		AD3B5521.Text = "Đo\u0301ng";
		AD3B5521.UseVisualStyleBackColor = false;
		AD3B5521.Click += new System.EventHandler(AD3B5521_Click);
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
		btnAdd.Click += new System.EventHandler(B6233D26);
		A12B0A87.Fixed = true;
		A12B0A87.Horizontal = true;
		A12B0A87.TargetControl = bunifuCustomLabel1;
		A12B0A87.Vertical = true;
		A98AE91B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A98AE91B.Location = new System.Drawing.Point(31, 61);
		A98AE91B.Name = "label2";
		A98AE91B.Size = new System.Drawing.Size(110, 16);
		A98AE91B.TabIndex = 36;
		A98AE91B.Text = "Token trung gian:";
		A98AE91B.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		token.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		token.Location = new System.Drawing.Point(147, 58);
		token.Name = "token";
		token.Size = new System.Drawing.Size(196, 23);
		token.TabIndex = 35;
		FCAEEC16.Cursor = System.Windows.Forms.Cursors.Hand;
		FCAEEC16.Location = new System.Drawing.Point(349, 58);
		FCAEEC16.Name = "btnCheckLiveTokenTg";
		FCAEEC16.Size = new System.Drawing.Size(61, 23);
		FCAEEC16.TabIndex = 37;
		FCAEEC16.Text = "Kiểm tra";
		FCAEEC16.Click += new System.EventHandler(FCAEEC16_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(449, 159);
		base.Controls.Add(A98AE91B);
		base.Controls.Add(token);
		base.Controls.Add(FCAEEC16);
		base.Controls.Add(AD3B5521);
		base.Controls.Add(btnAdd);
		base.Controls.Add(A68AD00E);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fNhapTokenTrungGian";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fNhapTokenTrungGian_Load);
		A68AD00E.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)D6307906).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
