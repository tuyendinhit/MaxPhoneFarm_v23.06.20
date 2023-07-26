using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapWifi : Form
{
	internal List<string> list_0 = new List<string>();

	internal int int_0 = 0;

	internal IContainer icontainer_0 = null;

	internal BunifuCards BD24F231;

	internal Panel pnlHeader;

	internal BunifuCustomLabel BFBFEEA6;

	internal Button btnMinimize;

	internal Button DA12E7B5;

	internal Button EC926D00;

	internal BunifuDragControl bunifuDragControl_0;

	internal PictureBox pictureBox1;

	internal Label lblStatus;

	internal Label FDA77E36;

	internal RichTextBox A8229B24;

	internal Label AAB628A7;

	internal NumericUpDown nudCountDevice;

	public fNhapWifi()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		if (File.Exists("settings\\wifi.txt"))
		{
			A8229B24.Lines = File.ReadAllLines("settings\\wifi.txt");
		}
	}

	private void method_0()
	{
		Language.smethod_1(BFBFEEA6);
		Language.smethod_1(EC926D00);
		Language.smethod_1(DA12E7B5);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void EC926D00_Click(object sender, EventArgs e)
	{
		try
		{
			list_0 = A8229B24.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			int_0 = Convert.ToInt32(nudCountDevice.Value);
			File.WriteAllLines("settings\\wifi.txt", list_0);
			Close();
		}
		catch (Exception)
		{
			MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void DA12E7B5_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A8229B24_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(A8229B24, lblStatus);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapWifi));
		BD24F231 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		BFBFEEA6 = new Bunifu.Framework.UI.BunifuCustomLabel();
		DA12E7B5 = new System.Windows.Forms.Button();
		EC926D00 = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		lblStatus = new System.Windows.Forms.Label();
		FDA77E36 = new System.Windows.Forms.Label();
		A8229B24 = new System.Windows.Forms.RichTextBox();
		AAB628A7 = new System.Windows.Forms.Label();
		nudCountDevice = new System.Windows.Forms.NumericUpDown();
		BD24F231.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountDevice).BeginInit();
		SuspendLayout();
		BD24F231.BackColor = System.Drawing.Color.White;
		BD24F231.BorderRadius = 0;
		BD24F231.BottomSahddow = true;
		BD24F231.color = System.Drawing.Color.SaddleBrown;
		BD24F231.Controls.Add(pnlHeader);
		BD24F231.Dock = System.Windows.Forms.DockStyle.Top;
		BD24F231.LeftSahddow = false;
		BD24F231.Location = new System.Drawing.Point(0, 0);
		BD24F231.Name = "bunifuCards1";
		BD24F231.RightSahddow = true;
		BD24F231.ShadowDepth = 20;
		BD24F231.Size = new System.Drawing.Size(428, 38);
		BD24F231.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(BFBFEEA6);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(428, 32);
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
		btnMinimize.Location = new System.Drawing.Point(396, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		BFBFEEA6.BackColor = System.Drawing.Color.Transparent;
		BFBFEEA6.Cursor = System.Windows.Forms.Cursors.SizeAll;
		BFBFEEA6.Dock = System.Windows.Forms.DockStyle.Fill;
		BFBFEEA6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BFBFEEA6.ForeColor = System.Drawing.Color.Black;
		BFBFEEA6.Location = new System.Drawing.Point(0, 0);
		BFBFEEA6.Name = "bunifuCustomLabel1";
		BFBFEEA6.Size = new System.Drawing.Size(428, 32);
		BFBFEEA6.TabIndex = 1;
		BFBFEEA6.Text = "Nhâ\u0323p Wifi";
		BFBFEEA6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DA12E7B5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		DA12E7B5.BackColor = System.Drawing.Color.Maroon;
		DA12E7B5.Cursor = System.Windows.Forms.Cursors.Hand;
		DA12E7B5.FlatAppearance.BorderSize = 0;
		DA12E7B5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DA12E7B5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DA12E7B5.ForeColor = System.Drawing.Color.White;
		DA12E7B5.Location = new System.Drawing.Point(222, 310);
		DA12E7B5.Name = "btnCancel";
		DA12E7B5.Size = new System.Drawing.Size(92, 29);
		DA12E7B5.TabIndex = 3;
		DA12E7B5.Text = "Đo\u0301ng";
		DA12E7B5.UseVisualStyleBackColor = false;
		DA12E7B5.Click += new System.EventHandler(DA12E7B5_Click);
		EC926D00.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		EC926D00.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		EC926D00.Cursor = System.Windows.Forms.Cursors.Hand;
		EC926D00.FlatAppearance.BorderSize = 0;
		EC926D00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EC926D00.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EC926D00.ForeColor = System.Drawing.Color.White;
		EC926D00.Location = new System.Drawing.Point(113, 310);
		EC926D00.Name = "btnAdd";
		EC926D00.Size = new System.Drawing.Size(92, 29);
		EC926D00.TabIndex = 2;
		EC926D00.Text = "Xa\u0301c nhâ\u0323n";
		EC926D00.UseVisualStyleBackColor = false;
		EC926D00.Click += new System.EventHandler(EC926D00_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = BFBFEEA6;
		bunifuDragControl_0.Vertical = true;
		lblStatus.AutoSize = true;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.Location = new System.Drawing.Point(25, 58);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(118, 16);
		lblStatus.TabIndex = 120;
		lblStatus.Text = "Danh sa\u0301ch Wifi (0):";
		FDA77E36.AutoSize = true;
		FDA77E36.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FDA77E36.ForeColor = System.Drawing.Color.Red;
		FDA77E36.Location = new System.Drawing.Point(195, 58);
		FDA77E36.Name = "label4";
		FDA77E36.Size = new System.Drawing.Size(207, 16);
		FDA77E36.TabIndex = 122;
		FDA77E36.Text = "(Đi\u0323nh da\u0323ng: Wifi_Name|Password)";
		A8229B24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		A8229B24.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A8229B24.Location = new System.Drawing.Point(29, 77);
		A8229B24.Name = "txtData";
		A8229B24.Size = new System.Drawing.Size(373, 181);
		A8229B24.TabIndex = 121;
		A8229B24.Text = "";
		A8229B24.WordWrap = false;
		A8229B24.TextChanged += new System.EventHandler(A8229B24_TextChanged);
		AAB628A7.AutoSize = true;
		AAB628A7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		AAB628A7.Location = new System.Drawing.Point(26, 264);
		AAB628A7.Name = "label1";
		AAB628A7.Size = new System.Drawing.Size(97, 16);
		AAB628A7.TabIndex = 123;
		AAB628A7.Text = "Số thiết bị/Wifi:";
		nudCountDevice.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		nudCountDevice.Location = new System.Drawing.Point(125, 262);
		nudCountDevice.Name = "nudCountDevice";
		nudCountDevice.Size = new System.Drawing.Size(76, 23);
		nudCountDevice.TabIndex = 124;
		nudCountDevice.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(428, 353);
		base.Controls.Add(nudCountDevice);
		base.Controls.Add(AAB628A7);
		base.Controls.Add(lblStatus);
		base.Controls.Add(FDA77E36);
		base.Controls.Add(A8229B24);
		base.Controls.Add(DA12E7B5);
		base.Controls.Add(EC926D00);
		base.Controls.Add(BD24F231);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fNhapWifi";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		BD24F231.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountDevice).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
