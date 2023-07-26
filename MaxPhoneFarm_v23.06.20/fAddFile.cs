using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fAddFile : Form
{
	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuCards F2A2C187;

	internal Panel pnlHeader;

	internal BunifuCustomLabel CEB4813D;

	internal Button btnMinimize;

	internal Button B820CAA0;

	internal Button C33ABC19;

	internal Label label1;

	internal BunifuDragControl C20A8E27;

	internal TextBox D3A752A2;

	internal PictureBox pictureBox1;

	public fAddFile()
	{
		InitializeComponent();
		bool_0 = false;
		Language.SetLanguage(this);
	}

	private void B014C496()
	{
		Language.smethod_1(CEB4813D);
		Language.smethod_1(label1);
		Language.smethod_1(C33ABC19);
		Language.smethod_1(B820CAA0);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C33ABC19_Click(object sender, EventArgs e)
	{
		string text = D3A752A2.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lòng điền tên thư mục!"));
			D3A752A2.Focus();
		}
		else if (CommonSQL.C1381FAC(text))
		{
			MessageBoxHelper.Show(Language.GetValue("Tên thư mục này đã tồn tại, vui lòng nhập tên khác!"));
			D3A752A2.Focus();
		}
		else if (CommonSQL.smethod_2(text))
		{
			bool_0 = true;
			if (MessageBoxHelper.smethod_1(Language.GetValue("Thêm thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?")) == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			MessageBoxHelper.Show(Language.GetValue("Thêm thư mục lỗi!"));
		}
	}

	private void B131F19F(object sender, EventArgs e)
	{
		Close();
	}

	private void D3A752A2_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			C33ABC19_Click(null, null);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddFile));
		F2A2C187 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		CEB4813D = new Bunifu.Framework.UI.BunifuCustomLabel();
		B820CAA0 = new System.Windows.Forms.Button();
		C33ABC19 = new System.Windows.Forms.Button();
		label1 = new System.Windows.Forms.Label();
		C20A8E27 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		D3A752A2 = new System.Windows.Forms.TextBox();
		F2A2C187.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		F2A2C187.BackColor = System.Drawing.Color.White;
		F2A2C187.BorderRadius = 0;
		F2A2C187.BottomSahddow = true;
		F2A2C187.color = System.Drawing.Color.SaddleBrown;
		F2A2C187.Controls.Add(pnlHeader);
		F2A2C187.Dock = System.Windows.Forms.DockStyle.Top;
		F2A2C187.LeftSahddow = false;
		F2A2C187.Location = new System.Drawing.Point(0, 0);
		F2A2C187.Name = "bunifuCards1";
		F2A2C187.RightSahddow = true;
		F2A2C187.ShadowDepth = 20;
		F2A2C187.Size = new System.Drawing.Size(396, 38);
		F2A2C187.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(CEB4813D);
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
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(364, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		CEB4813D.BackColor = System.Drawing.Color.Transparent;
		CEB4813D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CEB4813D.Dock = System.Windows.Forms.DockStyle.Fill;
		CEB4813D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CEB4813D.ForeColor = System.Drawing.Color.Black;
		CEB4813D.Location = new System.Drawing.Point(0, 0);
		CEB4813D.Name = "bunifuCustomLabel1";
		CEB4813D.Size = new System.Drawing.Size(396, 32);
		CEB4813D.TabIndex = 1;
		CEB4813D.Text = "Thêm thư mục";
		CEB4813D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B820CAA0.BackColor = System.Drawing.Color.Maroon;
		B820CAA0.Cursor = System.Windows.Forms.Cursors.Hand;
		B820CAA0.FlatAppearance.BorderSize = 0;
		B820CAA0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B820CAA0.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B820CAA0.ForeColor = System.Drawing.Color.White;
		B820CAA0.Location = new System.Drawing.Point(204, 105);
		B820CAA0.Name = "btnCancel";
		B820CAA0.Size = new System.Drawing.Size(92, 29);
		B820CAA0.TabIndex = 4;
		B820CAA0.Text = "Hủy";
		B820CAA0.UseVisualStyleBackColor = false;
		B820CAA0.Click += new System.EventHandler(B131F19F);
		C33ABC19.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		C33ABC19.Cursor = System.Windows.Forms.Cursors.Hand;
		C33ABC19.FlatAppearance.BorderSize = 0;
		C33ABC19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C33ABC19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C33ABC19.ForeColor = System.Drawing.Color.White;
		C33ABC19.Location = new System.Drawing.Point(100, 105);
		C33ABC19.Name = "btnAdd";
		C33ABC19.Size = new System.Drawing.Size(92, 29);
		C33ABC19.TabIndex = 3;
		C33ABC19.Text = "Thêm";
		C33ABC19.UseVisualStyleBackColor = false;
		C33ABC19.Click += new System.EventHandler(C33ABC19_Click);
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label1.Location = new System.Drawing.Point(33, 62);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(86, 16);
		label1.TabIndex = 20;
		label1.Text = "Tên thư mu\u0323c:";
		label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		C20A8E27.Fixed = true;
		C20A8E27.Horizontal = true;
		C20A8E27.TargetControl = CEB4813D;
		C20A8E27.Vertical = true;
		D3A752A2.Location = new System.Drawing.Point(125, 59);
		D3A752A2.Name = "txbNameFile";
		D3A752A2.Size = new System.Drawing.Size(234, 23);
		D3A752A2.TabIndex = 2;
		D3A752A2.KeyDown += new System.Windows.Forms.KeyEventHandler(D3A752A2_KeyDown);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(396, 145);
		base.Controls.Add(label1);
		base.Controls.Add(B820CAA0);
		base.Controls.Add(C33ABC19);
		base.Controls.Add(D3A752A2);
		base.Controls.Add(F2A2C187);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fAddFile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		F2A2C187.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
