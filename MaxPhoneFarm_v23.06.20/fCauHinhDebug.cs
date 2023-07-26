using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhDebug : Form
{
	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuCustomLabel BDBEF633;

	internal PictureBox F8B72309;

	internal CheckBox ckbCheckpoint;

	internal CheckBox ckbChangedPass;

	internal CheckBox C50DF40A;

	internal CheckBox ckbLoginFail;

	internal CheckBox ckbCheckSpam;

	internal CheckBox ckbJobSeeding;

	public fCauHinhDebug()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configDebug").GetValue("ckbCheckpoint", ckbCheckpoint.Checked);
		SettingsTool.GetSettings("configDebug").GetValue("ckbChangedPass", ckbChangedPass.Checked);
		SettingsTool.GetSettings("configDebug").GetValue("ckbChangeInfoDevice", C50DF40A.Checked);
		SettingsTool.GetSettings("configDebug").GetValue("ckbLoginFail", ckbLoginFail.Checked);
		SettingsTool.GetSettings("configDebug").GetValue("ckbCheckSpam", ckbCheckSpam.Checked);
		SettingsTool.GetSettings("configDebug").GetValue("ckbJobSeeding", ckbJobSeeding.Checked);
		SettingsTool.smethod_0("configDebug");
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B52484A4(object sender, EventArgs e)
	{
	}

	private void F6B27513(object sender, EventArgs e)
	{
		ckbCheckpoint.Checked = SettingsTool.GetSettings("configDebug").AA824D29("ckbCheckpoint");
		ckbChangedPass.Checked = SettingsTool.GetSettings("configDebug").AA824D29("ckbChangedPass");
		C50DF40A.Checked = SettingsTool.GetSettings("configDebug").AA824D29("ckbChangeInfoDevice");
		ckbLoginFail.Checked = SettingsTool.GetSettings("configDebug").AA824D29("ckbLoginFail");
		ckbCheckSpam.Checked = SettingsTool.GetSettings("configDebug").AA824D29("ckbCheckSpam");
		ckbJobSeeding.Checked = SettingsTool.GetSettings("configDebug").AA824D29("ckbJobSeeding");
	}

	protected override void Dispose(bool D792658C)
	{
		if (D792658C && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D792658C);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhDebug));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		F8B72309 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		BDBEF633 = new Bunifu.Framework.UI.BunifuCustomLabel();
		ckbCheckpoint = new System.Windows.Forms.CheckBox();
		ckbChangedPass = new System.Windows.Forms.CheckBox();
		C50DF40A = new System.Windows.Forms.CheckBox();
		ckbLoginFail = new System.Windows.Forms.CheckBox();
		ckbCheckSpam = new System.Windows.Forms.CheckBox();
		ckbJobSeeding = new System.Windows.Forms.CheckBox();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F8B72309).BeginInit();
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
		bunifuCards1.Size = new System.Drawing.Size(479, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(F8B72309);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(479, 32);
		pnlHeader.TabIndex = 9;
		F8B72309.Cursor = System.Windows.Forms.Cursors.Default;
		F8B72309.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		F8B72309.Location = new System.Drawing.Point(3, 2);
		F8B72309.Name = "pictureBox1";
		F8B72309.Size = new System.Drawing.Size(34, 27);
		F8B72309.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		F8B72309.TabIndex = 17;
		F8B72309.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(447, 0);
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(479, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh Debug";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(247, 258);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(143, 258);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		BDBEF633.BackColor = System.Drawing.Color.Transparent;
		BDBEF633.Cursor = System.Windows.Forms.Cursors.SizeAll;
		BDBEF633.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BDBEF633.ForeColor = System.Drawing.Color.Black;
		BDBEF633.Location = new System.Drawing.Point(51, 41);
		BDBEF633.Name = "lblStatus";
		BDBEF633.Size = new System.Drawing.Size(384, 32);
		BDBEF633.TabIndex = 21;
		BDBEF633.Text = "Vui lo\u0300ng cho\u0323n như\u0303ng thông tin câ\u0300n xuất log!";
		BDBEF633.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		BDBEF633.Click += new System.EventHandler(B52484A4);
		ckbCheckpoint.AutoSize = true;
		ckbCheckpoint.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCheckpoint.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbCheckpoint.Location = new System.Drawing.Point(118, 86);
		ckbCheckpoint.Name = "ckbCheckpoint";
		ckbCheckpoint.Size = new System.Drawing.Size(88, 20);
		ckbCheckpoint.TabIndex = 22;
		ckbCheckpoint.Text = "Checkpoint";
		ckbCheckpoint.UseVisualStyleBackColor = true;
		ckbChangedPass.AutoSize = true;
		ckbChangedPass.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbChangedPass.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbChangedPass.Location = new System.Drawing.Point(118, 112);
		ckbChangedPass.Name = "ckbChangedPass";
		ckbChangedPass.Size = new System.Drawing.Size(106, 20);
		ckbChangedPass.TabIndex = 22;
		ckbChangedPass.Text = "Changed pass";
		ckbChangedPass.UseVisualStyleBackColor = true;
		C50DF40A.AutoSize = true;
		C50DF40A.Cursor = System.Windows.Forms.Cursors.Hand;
		C50DF40A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C50DF40A.Location = new System.Drawing.Point(118, 138);
		C50DF40A.Name = "ckbChangeInfoDevice";
		C50DF40A.Size = new System.Drawing.Size(136, 20);
		C50DF40A.TabIndex = 22;
		C50DF40A.Text = "Change Info Device";
		C50DF40A.UseVisualStyleBackColor = true;
		ckbLoginFail.AutoSize = true;
		ckbLoginFail.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLoginFail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbLoginFail.Location = new System.Drawing.Point(118, 164);
		ckbLoginFail.Name = "ckbLoginFail";
		ckbLoginFail.Size = new System.Drawing.Size(77, 20);
		ckbLoginFail.TabIndex = 22;
		ckbLoginFail.Text = "Login fail";
		ckbLoginFail.UseVisualStyleBackColor = true;
		ckbCheckSpam.AutoSize = true;
		ckbCheckSpam.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCheckSpam.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbCheckSpam.Location = new System.Drawing.Point(118, 190);
		ckbCheckSpam.Name = "ckbCheckSpam";
		ckbCheckSpam.Size = new System.Drawing.Size(117, 20);
		ckbCheckSpam.TabIndex = 22;
		ckbCheckSpam.Text = "Facebook Spam";
		ckbCheckSpam.UseVisualStyleBackColor = true;
		ckbJobSeeding.AutoSize = true;
		ckbJobSeeding.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbJobSeeding.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbJobSeeding.Location = new System.Drawing.Point(118, 216);
		ckbJobSeeding.Name = "ckbJobSeeding";
		ckbJobSeeding.Size = new System.Drawing.Size(95, 20);
		ckbJobSeeding.TabIndex = 22;
		ckbJobSeeding.Text = "Job Seeding";
		ckbJobSeeding.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(479, 300);
		base.Controls.Add(ckbJobSeeding);
		base.Controls.Add(ckbCheckSpam);
		base.Controls.Add(ckbLoginFail);
		base.Controls.Add(C50DF40A);
		base.Controls.Add(ckbChangedPass);
		base.Controls.Add(ckbCheckpoint);
		base.Controls.Add(BDBEF633);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhDebug";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(F6B27513);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)F8B72309).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
