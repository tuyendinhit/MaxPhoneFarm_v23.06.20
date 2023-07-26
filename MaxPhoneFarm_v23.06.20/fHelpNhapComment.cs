using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHelpNhapComment : Form
{
	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal BunifuCustomLabel F996209E;

	internal Button btnMinimize;

	internal Button B2AEF231;

	internal BunifuDragControl A5A7CCBB;

	internal PictureBox pictureBox1;

	internal Label label1;

	internal PictureBox AE837C9C;

	internal Panel panel1;

	public fHelpNhapComment()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(F996209E);
		Language.smethod_1(label1);
		Language.smethod_1(B2AEF231);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B2AEF231_Click(object sender, EventArgs e)
	{
		Close();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHelpNhapComment));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		F996209E = new Bunifu.Framework.UI.BunifuCustomLabel();
		B2AEF231 = new System.Windows.Forms.Button();
		A5A7CCBB = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		label1 = new System.Windows.Forms.Label();
		AE837C9C = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)AE837C9C).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(577, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(F996209E);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(577, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = Resource.Bitmap_9;
		btnMinimize.Location = new System.Drawing.Point(544, -1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		F996209E.BackColor = System.Drawing.Color.Transparent;
		F996209E.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F996209E.Dock = System.Windows.Forms.DockStyle.Fill;
		F996209E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F996209E.ForeColor = System.Drawing.Color.Black;
		F996209E.Location = new System.Drawing.Point(0, 0);
		F996209E.Name = "bunifuCustomLabel1";
		F996209E.Size = new System.Drawing.Size(577, 32);
		F996209E.TabIndex = 1;
		F996209E.Text = "Hướng dẫn nhập Nội dung có nhiều dòng";
		F996209E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B2AEF231.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		B2AEF231.BackColor = System.Drawing.Color.Maroon;
		B2AEF231.Cursor = System.Windows.Forms.Cursors.Hand;
		B2AEF231.FlatAppearance.BorderSize = 0;
		B2AEF231.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B2AEF231.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B2AEF231.ForeColor = System.Drawing.Color.White;
		B2AEF231.Location = new System.Drawing.Point(246, 380);
		B2AEF231.Name = "btnCancel";
		B2AEF231.Size = new System.Drawing.Size(92, 29);
		B2AEF231.TabIndex = 4;
		B2AEF231.Text = "Đo\u0301ng";
		B2AEF231.UseVisualStyleBackColor = false;
		B2AEF231.Click += new System.EventHandler(B2AEF231_Click);
		A5A7CCBB.Fixed = true;
		A5A7CCBB.Horizontal = true;
		A5A7CCBB.TargetControl = F996209E;
		A5A7CCBB.Vertical = true;
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(28, 60);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(366, 16);
		label1.TabIndex = 5;
		label1.Text = "Vui lòng nhập các nội dung ngăn cách nhau bởi dấu | như sau:";
		AE837C9C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		AE837C9C.Image = Resource.Bitmap_39;
		AE837C9C.Location = new System.Drawing.Point(31, 86);
		AE837C9C.Name = "pictureBox2";
		AE837C9C.Size = new System.Drawing.Size(516, 273);
		AE837C9C.TabIndex = 6;
		AE837C9C.TabStop = false;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(578, 421);
		panel1.TabIndex = 7;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(578, 421);
		base.Controls.Add(AE837C9C);
		base.Controls.Add(label1);
		base.Controls.Add(B2AEF231);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fHelpNhapComment";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)AE837C9C).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
