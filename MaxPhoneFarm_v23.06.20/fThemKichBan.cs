using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fThemKichBan : Form
{
	internal int D7101283 = 0;

	internal string E1B9BE31 = "";

	internal IContainer AEB38429 = null;

	internal BunifuDragControl F00A5321;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuCards B2A29193;

	internal Panel pnlHeader;

	internal PictureBox D828F732;

	internal BunifuCustomLabel D8A19B35;

	internal Button button1;

	internal Label label2;

	internal Button CE3FC20D;

	internal Button btnAdd;

	internal TextBox F78FA417;

	internal Panel C4B5A982;

	public fThemKichBan(int BFB194BA, string string_0 = "")
	{
		InitializeComponent();
		Language.SetLanguage(this);
		D7101283 = BFB194BA;
		E1B9BE31 = string_0;
		if (BFB194BA == 1)
		{
			D8A19B35.Text = Language.GetValue("Câ\u0323p nhâ\u0323t ki\u0323ch ba\u0309n");
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			F78FA417.Text = Class123.D22C6CAB(string_0).Rows[0]["TenKichBan"].ToString();
		}
	}

	private void fThemKichBan_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C0264411(object sender, EventArgs e)
	{
		string text = F78FA417.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ki\u0323ch ba\u0309n!"), 2);
		}
		else if (D7101283 == 0)
		{
			if (Class123.smethod_7(text))
			{
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
		else if (Class123.B0A197BE(E1B9BE31, text))
		{
			Close();
		}
		else
		{
			MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void CE3FC20D_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C4B5A982_Paint(object sender, PaintEventArgs e)
	{
		if (C4B5A982.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C4B5A982.ClientSize.Width - num, C4B5A982.ClientSize.Height - num));
		}
	}

	private void F78FA417_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			C0264411(null, null);
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && AEB38429 != null)
		{
			AEB38429.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		AEB38429 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemKichBan));
		F00A5321 = new Bunifu.Framework.UI.BunifuDragControl(AEB38429);
		D8A19B35 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(AEB38429);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		D828F732 = new System.Windows.Forms.PictureBox();
		B2A29193 = new Bunifu.Framework.UI.BunifuCards();
		label2 = new System.Windows.Forms.Label();
		CE3FC20D = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		F78FA417 = new System.Windows.Forms.TextBox();
		C4B5A982 = new System.Windows.Forms.Panel();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D828F732).BeginInit();
		B2A29193.SuspendLayout();
		SuspendLayout();
		F00A5321.Fixed = true;
		F00A5321.Horizontal = true;
		F00A5321.TargetControl = D8A19B35;
		F00A5321.Vertical = true;
		D8A19B35.BackColor = System.Drawing.Color.Transparent;
		D8A19B35.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D8A19B35.Dock = System.Windows.Forms.DockStyle.Fill;
		D8A19B35.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D8A19B35.ForeColor = System.Drawing.Color.Black;
		D8A19B35.Location = new System.Drawing.Point(0, 0);
		D8A19B35.Name = "bunifuCustomLabel1";
		D8A19B35.Size = new System.Drawing.Size(324, 31);
		D8A19B35.TabIndex = 12;
		D8A19B35.Text = "Thêm kịch bản";
		D8A19B35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(D828F732);
		pnlHeader.Controls.Add(D8A19B35);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(1, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(324, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(293, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		D828F732.Cursor = System.Windows.Forms.Cursors.Default;
		D828F732.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		D828F732.Location = new System.Drawing.Point(3, 2);
		D828F732.Name = "pictureBox1";
		D828F732.Size = new System.Drawing.Size(34, 27);
		D828F732.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		D828F732.TabIndex = 76;
		D828F732.TabStop = false;
		B2A29193.BackColor = System.Drawing.Color.White;
		B2A29193.BorderRadius = 0;
		B2A29193.BottomSahddow = true;
		B2A29193.color = System.Drawing.Color.DarkViolet;
		B2A29193.Controls.Add(pnlHeader);
		B2A29193.LeftSahddow = false;
		B2A29193.Location = new System.Drawing.Point(2, 0);
		B2A29193.Name = "bunifuCards1";
		B2A29193.RightSahddow = true;
		B2A29193.ShadowDepth = 20;
		B2A29193.Size = new System.Drawing.Size(327, 37);
		B2A29193.TabIndex = 12;
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label2.Location = new System.Drawing.Point(32, 55);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(85, 16);
		label2.TabIndex = 24;
		label2.Text = "Tên kịch bản:";
		CE3FC20D.BackColor = System.Drawing.Color.Maroon;
		CE3FC20D.Cursor = System.Windows.Forms.Cursors.Hand;
		CE3FC20D.FlatAppearance.BorderSize = 0;
		CE3FC20D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CE3FC20D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CE3FC20D.ForeColor = System.Drawing.Color.White;
		CE3FC20D.Location = new System.Drawing.Point(171, 96);
		CE3FC20D.Name = "btnCancel";
		CE3FC20D.Size = new System.Drawing.Size(92, 29);
		CE3FC20D.TabIndex = 2;
		CE3FC20D.Text = "Đóng";
		CE3FC20D.UseVisualStyleBackColor = false;
		CE3FC20D.Click += new System.EventHandler(CE3FC20D_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(67, 96);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 1;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(C0264411);
		F78FA417.Lines = new string[0];
		F78FA417.Location = new System.Drawing.Point(124, 52);
		F78FA417.MaxLength = 32767;
		F78FA417.Name = "txtTen";
		F78FA417.PasswordChar = '\0';
		F78FA417.ScrollBars = System.Windows.Forms.ScrollBars.None;
		F78FA417.SelectedText = "";
		F78FA417.SelectionLength = 0;
		F78FA417.SelectionStart = 0;
		F78FA417.ShortcutsEnabled = true;
		F78FA417.Size = new System.Drawing.Size(171, 23);
		F78FA417.TabIndex = 0;
		F78FA417.KeyDown += new System.Windows.Forms.KeyEventHandler(F78FA417_KeyDown);
		C4B5A982.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C4B5A982.Dock = System.Windows.Forms.DockStyle.Fill;
		C4B5A982.Location = new System.Drawing.Point(0, 0);
		C4B5A982.Name = "panel1";
		C4B5A982.Size = new System.Drawing.Size(330, 137);
		C4B5A982.TabIndex = 25;
		C4B5A982.Paint += new System.Windows.Forms.PaintEventHandler(C4B5A982_Paint);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(330, 137);
		base.Controls.Add(label2);
		base.Controls.Add(CE3FC20D);
		base.Controls.Add(btnAdd);
		base.Controls.Add(F78FA417);
		base.Controls.Add(B2A29193);
		base.Controls.Add(C4B5A982);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fThemKichBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fThemKichBan_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)D828F732).EndInit();
		B2A29193.ResumeLayout(false);
		ResumeLayout(false);
		PerformLayout();
	}
}
