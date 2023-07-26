using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fSelectFolder : Form
{
	internal static string string_0 = "";

	internal IContainer CB0F180B = null;

	internal BunifuCards F82EB198;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Button BFB89C1F;

	internal Button C202A429;

	internal BunifuDragControl A69ADC32;

	internal PictureBox pictureBox1;

	internal Label label2;

	internal TextBox txtPathFolder;

	public fSelectFolder()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		string_0 = "";
	}

	private void F6A50E94()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label2);
		Language.smethod_1(C202A429);
		Language.smethod_1(BFB89C1F);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C202A429_Click(object sender, EventArgs e)
	{
		string_0 = txtPathFolder.Text.Trim();
		if (string_0 == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p đươ\u0300ng dâ\u0303n Folder!"), 2);
			txtPathFolder.Focus();
		}
		else
		{
			Close();
		}
	}

	private void FF926427(object sender, EventArgs e)
	{
		Close();
	}

	private void F78E6828(object sender, EventArgs e)
	{
		string_0 = "";
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && CB0F180B != null)
		{
			CB0F180B.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		CB0F180B = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSelectFolder));
		F82EB198 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		BFB89C1F = new System.Windows.Forms.Button();
		C202A429 = new System.Windows.Forms.Button();
		A69ADC32 = new Bunifu.Framework.UI.BunifuDragControl(CB0F180B);
		label2 = new System.Windows.Forms.Label();
		txtPathFolder = new System.Windows.Forms.TextBox();
		F82EB198.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		F82EB198.BackColor = System.Drawing.Color.White;
		F82EB198.BorderRadius = 0;
		F82EB198.BottomSahddow = true;
		F82EB198.color = System.Drawing.Color.SaddleBrown;
		F82EB198.Controls.Add(pnlHeader);
		F82EB198.Dock = System.Windows.Forms.DockStyle.Top;
		F82EB198.LeftSahddow = false;
		F82EB198.Location = new System.Drawing.Point(0, 0);
		F82EB198.Name = "bunifuCards1";
		F82EB198.RightSahddow = true;
		F82EB198.ShadowDepth = 20;
		F82EB198.Size = new System.Drawing.Size(449, 34);
		F82EB198.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
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
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(417, 0);
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(449, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Cho\u0323n nơi lưu";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		BFB89C1F.BackColor = System.Drawing.Color.Maroon;
		BFB89C1F.Cursor = System.Windows.Forms.Cursors.Hand;
		BFB89C1F.FlatAppearance.BorderSize = 0;
		BFB89C1F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BFB89C1F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BFB89C1F.ForeColor = System.Drawing.Color.White;
		BFB89C1F.Location = new System.Drawing.Point(230, 108);
		BFB89C1F.Name = "btnCancel";
		BFB89C1F.Size = new System.Drawing.Size(92, 29);
		BFB89C1F.TabIndex = 4;
		BFB89C1F.Text = "Đo\u0301ng";
		BFB89C1F.UseVisualStyleBackColor = false;
		BFB89C1F.Click += new System.EventHandler(FF926427);
		C202A429.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		C202A429.Cursor = System.Windows.Forms.Cursors.Hand;
		C202A429.FlatAppearance.BorderSize = 0;
		C202A429.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C202A429.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C202A429.ForeColor = System.Drawing.Color.White;
		C202A429.Location = new System.Drawing.Point(126, 108);
		C202A429.Name = "btnAdd";
		C202A429.Size = new System.Drawing.Size(92, 29);
		C202A429.TabIndex = 3;
		C202A429.Text = "Lưu";
		C202A429.UseVisualStyleBackColor = false;
		C202A429.Click += new System.EventHandler(C202A429_Click);
		A69ADC32.Fixed = true;
		A69ADC32.Horizontal = true;
		A69ADC32.TargetControl = bunifuCustomLabel1;
		A69ADC32.Vertical = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(31, 61);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(147, 16);
		label2.TabIndex = 36;
		label2.Text = "Nhâ\u0323p đươ\u0300ng dâ\u0303n Folder:";
		label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		txtPathFolder.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtPathFolder.Location = new System.Drawing.Point(184, 58);
		txtPathFolder.Name = "txtPathFolder";
		txtPathFolder.Size = new System.Drawing.Size(227, 23);
		txtPathFolder.TabIndex = 35;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(449, 159);
		base.Controls.Add(label2);
		base.Controls.Add(txtPathFolder);
		base.Controls.Add(BFB89C1F);
		base.Controls.Add(C202A429);
		base.Controls.Add(F82EB198);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fSelectFolder";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(F78E6828);
		F82EB198.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
