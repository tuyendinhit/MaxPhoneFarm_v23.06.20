using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchTestSpinContent : Form
{
	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel panel1;

	internal BunifuDragControl AC1B0B26;

	internal ToolTip B01C2127;

	internal BunifuCards bunifuCards2;

	internal Panel pnlHeader;

	internal Button button2;

	internal PictureBox C8A5B934;

	internal Button btnMinimize;

	internal BunifuCustomLabel A02E0028;

	internal Button AF86BBB3;

	internal RichTextBox D2A356AB;

	internal GroupBox groupBox2;

	internal RichTextBox B304D833;

	internal GroupBox groupBox1;

	public fTienIchTestSpinContent()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AF86BBB3_Click(object sender, EventArgs e)
	{
		try
		{
			string string_ = D2A356AB.Text;
			B304D833.Text = Common.SpinText(string_);
		}
		catch (Exception)
		{
			MessageBoxHelper.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void D2A356AB_TextChanged(object sender, EventArgs e)
	{
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void B304D833_TextChanged(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchTestSpinContent_Load(object sender, EventArgs e)
	{
		method_0(null, null);
		method_1(null, null);
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
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		groupBox2 = new System.Windows.Forms.GroupBox();
		B304D833 = new System.Windows.Forms.RichTextBox();
		groupBox1 = new System.Windows.Forms.GroupBox();
		D2A356AB = new System.Windows.Forms.RichTextBox();
		AF86BBB3 = new System.Windows.Forms.Button();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		C8A5B934 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		A02E0028 = new Bunifu.Framework.UI.BunifuCustomLabel();
		AC1B0B26 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		B01C2127 = new System.Windows.Forms.ToolTip(icontainer_0);
		panel1.SuspendLayout();
		groupBox2.SuspendLayout();
		groupBox1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C8A5B934).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(509, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(groupBox2);
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(AF86BBB3);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(838, 600);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		groupBox2.Controls.Add(B304D833);
		groupBox2.Location = new System.Drawing.Point(469, 40);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(361, 223);
		groupBox2.TabIndex = 51;
		groupBox2.TabStop = false;
		groupBox2.Text = "Output";
		B304D833.Location = new System.Drawing.Point(6, 22);
		B304D833.Name = "txtOutput";
		B304D833.Size = new System.Drawing.Size(349, 194);
		B304D833.TabIndex = 50;
		B304D833.Text = "";
		B304D833.WordWrap = false;
		B304D833.TextChanged += new System.EventHandler(B304D833_TextChanged);
		groupBox1.Controls.Add(D2A356AB);
		groupBox1.Location = new System.Drawing.Point(6, 40);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(361, 223);
		groupBox1.TabIndex = 51;
		groupBox1.TabStop = false;
		groupBox1.Text = "Input";
		D2A356AB.Location = new System.Drawing.Point(6, 22);
		D2A356AB.Name = "txtInput";
		D2A356AB.Size = new System.Drawing.Size(349, 194);
		D2A356AB.TabIndex = 50;
		D2A356AB.Text = "";
		D2A356AB.WordWrap = false;
		D2A356AB.TextChanged += new System.EventHandler(D2A356AB_TextChanged);
		AF86BBB3.BackColor = System.Drawing.Color.Green;
		AF86BBB3.Cursor = System.Windows.Forms.Cursors.Hand;
		AF86BBB3.FlatAppearance.BorderSize = 0;
		AF86BBB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AF86BBB3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AF86BBB3.ForeColor = System.Drawing.Color.White;
		AF86BBB3.Location = new System.Drawing.Point(379, 138);
		AF86BBB3.Name = "btnAdd";
		AF86BBB3.Size = new System.Drawing.Size(78, 29);
		AF86BBB3.TabIndex = 45;
		AF86BBB3.Text = "Spin";
		AF86BBB3.UseVisualStyleBackColor = false;
		AF86BBB3.Click += new System.EventHandler(AF86BBB3_Click);
		bunifuCards2.BackColor = System.Drawing.Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new System.Drawing.Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new System.Drawing.Size(836, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(C8A5B934);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(A02E0028);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(836, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = Resource.Bitmap_9;
		button2.Location = new System.Drawing.Point(805, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		C8A5B934.Cursor = System.Windows.Forms.Cursors.Default;
		C8A5B934.Image = Resource.AC35C73C;
		C8A5B934.Location = new System.Drawing.Point(3, 2);
		C8A5B934.Name = "pictureBox1";
		C8A5B934.Size = new System.Drawing.Size(34, 27);
		C8A5B934.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		C8A5B934.TabIndex = 76;
		C8A5B934.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Location = new System.Drawing.Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		A02E0028.BackColor = System.Drawing.Color.Transparent;
		A02E0028.Cursor = System.Windows.Forms.Cursors.SizeAll;
		A02E0028.Dock = System.Windows.Forms.DockStyle.Fill;
		A02E0028.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A02E0028.ForeColor = System.Drawing.Color.Black;
		A02E0028.Location = new System.Drawing.Point(0, 0);
		A02E0028.Name = "lblTitle";
		A02E0028.Size = new System.Drawing.Size(836, 31);
		A02E0028.TabIndex = 12;
		A02E0028.Text = "Test Spin Content";
		A02E0028.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		AC1B0B26.Fixed = true;
		AC1B0B26.Horizontal = true;
		AC1B0B26.TargetControl = A02E0028;
		AC1B0B26.Vertical = true;
		B01C2127.AutomaticDelay = 0;
		B01C2127.AutoPopDelay = 10000;
		B01C2127.InitialDelay = 200;
		B01C2127.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(838, 270);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchTestSpinContent";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fTienIchTestSpinContent_Load);
		panel1.ResumeLayout(false);
		groupBox2.ResumeLayout(false);
		groupBox1.ResumeLayout(false);
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)C8A5B934).EndInit();
		ResumeLayout(false);
	}
}
