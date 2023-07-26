using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fEditFile : Form
{
	internal string string_0;

	internal string A8357D2C;

	internal bool bool_0 = false;

	internal IContainer D1165930 = null;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Button EE1C8E17;

	internal Button C9A40705;

	internal Label label1;

	internal BunifuDragControl bunifuDragControl_0;

	internal TextBox txtNameFileOld;

	internal PictureBox pictureBox1;

	internal TextBox D1A0A82E;

	internal Label label2;

	public fEditFile(string string_1, string F5206BBC)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		string_0 = string_1;
		A8357D2C = F5206BBC;
		bool_0 = false;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(label1);
		Language.smethod_1(label2);
		Language.smethod_1(C9A40705);
		Language.smethod_1(EE1C8E17);
	}

	private void A516AA30(object sender, EventArgs e)
	{
		string text = D1A0A82E.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lòng điền tên thư mục mới!"), 3);
			D1A0A82E.Focus();
		}
		else if (CommonSQL.C1381FAC(text))
		{
			MessageBoxHelper.Show(Language.GetValue("Tên thư mục này đã tồn tại, vui lòng nhập tên khác!"), 3);
			D1A0A82E.Focus();
		}
		else if (text.Equals(txtNameFileOld.Text.Trim()))
		{
			MessageBoxHelper.Show(Language.GetValue("Tên thư mục mới phải khác thư mục cũ!"), 3);
			D1A0A82E.Focus();
		}
		else if (CommonSQL.smethod_3(string_0, text))
		{
			bool_0 = true;
			if (MessageBoxHelper.smethod_1(Language.GetValue("Cập nhật thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?")) == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			MessageBoxHelper.Show(Language.GetValue("Cập nhật tên thư mục lỗi!"));
		}
	}

	private void EE1C8E17_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F22D1C26(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			A516AA30(null, null);
		}
	}

	private void BC08542A(object sender, EventArgs e)
	{
		txtNameFileOld.Text = A8357D2C;
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && D1165930 != null)
		{
			D1165930.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		D1165930 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditFile));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		EE1C8E17 = new System.Windows.Forms.Button();
		C9A40705 = new System.Windows.Forms.Button();
		label1 = new System.Windows.Forms.Label();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(D1165930);
		txtNameFileOld = new System.Windows.Forms.TextBox();
		D1A0A82E = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
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
		bunifuCards1.Size = new System.Drawing.Size(396, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(396, 32);
		pnlHeader.TabIndex = 9;
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
		bunifuCustomLabel1.Text = "Cập nhật Tên thư mục";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		EE1C8E17.BackColor = System.Drawing.Color.Maroon;
		EE1C8E17.Cursor = System.Windows.Forms.Cursors.Hand;
		EE1C8E17.FlatAppearance.BorderSize = 0;
		EE1C8E17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EE1C8E17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EE1C8E17.ForeColor = System.Drawing.Color.White;
		EE1C8E17.Location = new System.Drawing.Point(204, 138);
		EE1C8E17.Name = "btnCancel";
		EE1C8E17.Size = new System.Drawing.Size(92, 29);
		EE1C8E17.TabIndex = 4;
		EE1C8E17.Text = "Hủy";
		EE1C8E17.UseVisualStyleBackColor = false;
		EE1C8E17.Click += new System.EventHandler(EE1C8E17_Click);
		C9A40705.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		C9A40705.Cursor = System.Windows.Forms.Cursors.Hand;
		C9A40705.FlatAppearance.BorderSize = 0;
		C9A40705.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C9A40705.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C9A40705.ForeColor = System.Drawing.Color.White;
		C9A40705.Location = new System.Drawing.Point(100, 138);
		C9A40705.Name = "btnAdd";
		C9A40705.Size = new System.Drawing.Size(92, 29);
		C9A40705.TabIndex = 3;
		C9A40705.Text = "Cập nhật";
		C9A40705.UseVisualStyleBackColor = false;
		C9A40705.Click += new System.EventHandler(A516AA30);
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label1.Location = new System.Drawing.Point(33, 69);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(102, 16);
		label1.TabIndex = 20;
		label1.Text = "Tên thư mu\u0323c cũ:";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		txtNameFileOld.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
		txtNameFileOld.Location = new System.Drawing.Point(150, 66);
		txtNameFileOld.Name = "txtNameFileOld";
		txtNameFileOld.ReadOnly = true;
		txtNameFileOld.Size = new System.Drawing.Size(209, 23);
		txtNameFileOld.TabIndex = 2;
		txtNameFileOld.KeyDown += new System.Windows.Forms.KeyEventHandler(F22D1C26);
		D1A0A82E.Location = new System.Drawing.Point(150, 95);
		D1A0A82E.Name = "txtNameFileNew";
		D1A0A82E.Size = new System.Drawing.Size(209, 23);
		D1A0A82E.TabIndex = 2;
		D1A0A82E.KeyDown += new System.Windows.Forms.KeyEventHandler(F22D1C26);
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label2.Location = new System.Drawing.Point(33, 98);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(110, 16);
		label2.TabIndex = 20;
		label2.Text = "Tên thư mu\u0323c mới:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(396, 182);
		base.Controls.Add(label2);
		base.Controls.Add(label1);
		base.Controls.Add(EE1C8E17);
		base.Controls.Add(C9A40705);
		base.Controls.Add(D1A0A82E);
		base.Controls.Add(txtNameFileOld);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fEditFile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(BC08542A);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
