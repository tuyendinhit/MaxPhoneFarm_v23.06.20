using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapProxy : Form
{
	internal List<string> list_0 = new List<string>();

	internal int FB19BA9B = 0;

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel DB22FA85;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Button E811C88D;

	internal Button btnAdd;

	internal BunifuDragControl A204B3A4;

	internal PictureBox F8B6AF0A;

	internal Label lblStatus;

	internal Label label4;

	internal RichTextBox BB3E472E;

	internal Label label1;

	internal NumericUpDown nudCountDevice;

	public fNhapProxy()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		if (File.Exists("settings\\proxy.txt"))
		{
			BB3E472E.Lines = File.ReadAllLines("settings\\proxy.txt");
		}
	}

	private void A0B931A8(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			list_0 = BB3E472E.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			FB19BA9B = Convert.ToInt32(nudCountDevice.Value);
			File.WriteAllLines("settings\\proxy.txt", list_0);
			Close();
		}
		catch (Exception)
		{
			MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void D1BABA16(object sender, EventArgs e)
	{
		Close();
	}

	private void E939BAB1(object sender, EventArgs e)
	{
		Common.D936DD84(BB3E472E, lblStatus);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapProxy));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		DB22FA85 = new System.Windows.Forms.Panel();
		F8B6AF0A = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		E811C88D = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		A204B3A4 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		lblStatus = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		BB3E472E = new System.Windows.Forms.RichTextBox();
		label1 = new System.Windows.Forms.Label();
		nudCountDevice = new System.Windows.Forms.NumericUpDown();
		bunifuCards1.SuspendLayout();
		DB22FA85.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F8B6AF0A).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountDevice).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(DB22FA85);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(428, 38);
		bunifuCards1.TabIndex = 0;
		DB22FA85.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DB22FA85.BackColor = System.Drawing.Color.White;
		DB22FA85.Controls.Add(F8B6AF0A);
		DB22FA85.Controls.Add(btnMinimize);
		DB22FA85.Controls.Add(bunifuCustomLabel1);
		DB22FA85.Location = new System.Drawing.Point(0, 5);
		DB22FA85.Name = "pnlHeader";
		DB22FA85.Size = new System.Drawing.Size(428, 32);
		DB22FA85.TabIndex = 9;
		F8B6AF0A.Cursor = System.Windows.Forms.Cursors.Default;
		F8B6AF0A.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		F8B6AF0A.Location = new System.Drawing.Point(4, 1);
		F8B6AF0A.Name = "pictureBox1";
		F8B6AF0A.Size = new System.Drawing.Size(34, 27);
		F8B6AF0A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		F8B6AF0A.TabIndex = 77;
		F8B6AF0A.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(396, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(A0B931A8);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(428, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Nhâ\u0323p Proxy";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E811C88D.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E811C88D.BackColor = System.Drawing.Color.Maroon;
		E811C88D.Cursor = System.Windows.Forms.Cursors.Hand;
		E811C88D.FlatAppearance.BorderSize = 0;
		E811C88D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E811C88D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E811C88D.ForeColor = System.Drawing.Color.White;
		E811C88D.Location = new System.Drawing.Point(222, 310);
		E811C88D.Name = "btnCancel";
		E811C88D.Size = new System.Drawing.Size(92, 29);
		E811C88D.TabIndex = 3;
		E811C88D.Text = "Đo\u0301ng";
		E811C88D.UseVisualStyleBackColor = false;
		E811C88D.Click += new System.EventHandler(D1BABA16);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(113, 310);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 2;
		btnAdd.Text = "Xa\u0301c nhâ\u0323n";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		A204B3A4.Fixed = true;
		A204B3A4.Horizontal = true;
		A204B3A4.TargetControl = bunifuCustomLabel1;
		A204B3A4.Vertical = true;
		lblStatus.AutoSize = true;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.Location = new System.Drawing.Point(25, 58);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(127, 16);
		lblStatus.TabIndex = 120;
		lblStatus.Text = "Danh sa\u0301ch Proxy (0):";
		label4.AutoSize = true;
		label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label4.ForeColor = System.Drawing.Color.Red;
		label4.Location = new System.Drawing.Point(281, 58);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(123, 16);
		label4.TabIndex = 122;
		label4.Text = "(Đi\u0323nh da\u0323ng: Ip:Port)";
		BB3E472E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BB3E472E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BB3E472E.Location = new System.Drawing.Point(29, 77);
		BB3E472E.Name = "txtData";
		BB3E472E.Size = new System.Drawing.Size(373, 181);
		BB3E472E.TabIndex = 121;
		BB3E472E.Text = "";
		BB3E472E.WordWrap = false;
		BB3E472E.TextChanged += new System.EventHandler(E939BAB1);
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(26, 264);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(106, 16);
		label1.TabIndex = 123;
		label1.Text = "Số thiết bị/Proxy:";
		nudCountDevice.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		nudCountDevice.Location = new System.Drawing.Point(134, 262);
		nudCountDevice.Name = "nudCountDevice";
		nudCountDevice.Size = new System.Drawing.Size(76, 23);
		nudCountDevice.TabIndex = 124;
		nudCountDevice.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(428, 353);
		base.Controls.Add(nudCountDevice);
		base.Controls.Add(label1);
		base.Controls.Add(lblStatus);
		base.Controls.Add(label4);
		base.Controls.Add(BB3E472E);
		base.Controls.Add(E811C88D);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fNhapProxy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		bunifuCards1.ResumeLayout(false);
		DB22FA85.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)F8B6AF0A).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountDevice).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
