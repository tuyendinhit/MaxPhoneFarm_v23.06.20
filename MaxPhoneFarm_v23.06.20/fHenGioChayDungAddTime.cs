using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHenGioChayDungAddTime : Form
{
	[CompilerGenerated]
	private sealed class Class58
	{
		internal Control B28A5436;

		internal bool bool_0;

		internal void method_0()
		{
			B28A5436.Enabled = bool_0;
		}
	}

	internal string string_0;

	internal IContainer A181B920 = null;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal BunifuCustomLabel CA0AAB2D;

	internal Button D7888D91;

	internal BunifuDragControl bunifuDragControl_0;

	internal PictureBox F09EC791;

	internal DateTimePicker C59C54B0;

	internal Button DA9AF43E;

	internal Button btnAdd;

	internal Label label7;

	internal Panel panel1;

	public fHenGioChayDungAddTime()
	{
		InitializeComponent();
	}

	private void A62137A4(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0(Control control_0, bool E619F784 = true)
	{
		try
		{
			control_0.Invoke((Action)delegate
			{
				control_0.Enabled = E619F784;
			});
		}
		catch
		{
		}
	}

	private void CE2AEC00(object sender, EventArgs e)
	{
	}

	private void BBACF9A1(object sender, EventArgs e)
	{
		string_0 = C59C54B0.Value.ToString("HH:mm:ss");
		Close();
	}

	private void DA9AF43E_Click(object sender, EventArgs e)
	{
		string_0 = "";
		Close();
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && A181B920 != null)
		{
			A181B920.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		A181B920 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHenGioChayDungAddTime));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		F09EC791 = new System.Windows.Forms.PictureBox();
		D7888D91 = new System.Windows.Forms.Button();
		CA0AAB2D = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(A181B920);
		C59C54B0 = new System.Windows.Forms.DateTimePicker();
		DA9AF43E = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		label7 = new System.Windows.Forms.Label();
		panel1 = new System.Windows.Forms.Panel();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F09EC791).BeginInit();
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
		bunifuCards1.Size = new System.Drawing.Size(256, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(F09EC791);
		pnlHeader.Controls.Add(D7888D91);
		pnlHeader.Controls.Add(CA0AAB2D);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(256, 32);
		pnlHeader.TabIndex = 9;
		F09EC791.Cursor = System.Windows.Forms.Cursors.Default;
		F09EC791.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		F09EC791.Location = new System.Drawing.Point(3, 2);
		F09EC791.Name = "pictureBox1";
		F09EC791.Size = new System.Drawing.Size(34, 27);
		F09EC791.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		F09EC791.TabIndex = 17;
		F09EC791.TabStop = false;
		D7888D91.Cursor = System.Windows.Forms.Cursors.Hand;
		D7888D91.Dock = System.Windows.Forms.DockStyle.Right;
		D7888D91.FlatAppearance.BorderSize = 0;
		D7888D91.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D7888D91.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D7888D91.ForeColor = System.Drawing.Color.White;
		D7888D91.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		D7888D91.Location = new System.Drawing.Point(224, 0);
		D7888D91.Name = "btnMinimize";
		D7888D91.Size = new System.Drawing.Size(32, 32);
		D7888D91.TabIndex = 9;
		D7888D91.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		D7888D91.UseVisualStyleBackColor = true;
		D7888D91.Click += new System.EventHandler(A62137A4);
		CA0AAB2D.BackColor = System.Drawing.Color.Transparent;
		CA0AAB2D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CA0AAB2D.Dock = System.Windows.Forms.DockStyle.Fill;
		CA0AAB2D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CA0AAB2D.ForeColor = System.Drawing.Color.Black;
		CA0AAB2D.Location = new System.Drawing.Point(0, 0);
		CA0AAB2D.Name = "bunifuCustomLabel1";
		CA0AAB2D.Size = new System.Drawing.Size(256, 32);
		CA0AAB2D.TabIndex = 1;
		CA0AAB2D.Text = "Thêm thời gian";
		CA0AAB2D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = CA0AAB2D;
		bunifuDragControl_0.Vertical = true;
		C59C54B0.CustomFormat = "HH:mm:ss";
		C59C54B0.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C59C54B0.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
		C59C54B0.Location = new System.Drawing.Point(132, 60);
		C59C54B0.Margin = new System.Windows.Forms.Padding(4);
		C59C54B0.Name = "dtpTime";
		C59C54B0.Size = new System.Drawing.Size(83, 23);
		C59C54B0.TabIndex = 193;
		DA9AF43E.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		DA9AF43E.BackColor = System.Drawing.Color.Maroon;
		DA9AF43E.Cursor = System.Windows.Forms.Cursors.Hand;
		DA9AF43E.FlatAppearance.BorderSize = 0;
		DA9AF43E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DA9AF43E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DA9AF43E.ForeColor = System.Drawing.Color.White;
		DA9AF43E.Location = new System.Drawing.Point(138, 105);
		DA9AF43E.Name = "btnCancel";
		DA9AF43E.Size = new System.Drawing.Size(92, 29);
		DA9AF43E.TabIndex = 183;
		DA9AF43E.Text = "Hủy";
		DA9AF43E.UseVisualStyleBackColor = false;
		DA9AF43E.Click += new System.EventHandler(DA9AF43E_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(30, 105);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 182;
		btnAdd.Text = "Xa\u0301c nhâ\u0323n";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(BBACF9A1);
		label7.AutoSize = true;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(31, 63);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(94, 16);
		label7.TabIndex = 192;
		label7.Text = "Nhập thời gian:";
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(256, 147);
		panel1.TabIndex = 194;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(256, 147);
		base.Controls.Add(C59C54B0);
		base.Controls.Add(DA9AF43E);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(label7);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fHenGioChayDungAddTime";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "fAddFile";
		base.Load += new System.EventHandler(CE2AEC00);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)F09EC791).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
