using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhHienThi : Form
{
	internal IContainer D236A587 = null;

	internal BunifuCards bunifuCards1;

	internal Panel DF0B9839;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuCustomLabel DB37CC26;

	internal PictureBox FD2E9DB3;

	internal CheckBox ckbToken;

	internal CheckBox ckbCookie;

	internal CheckBox F481EC39;

	internal CheckBox ckbTen;

	internal CheckBox ckbBanBe;

	internal CheckBox FFAD1CB4;

	internal CheckBox ckbNgaySinh;

	internal CheckBox ckbGioiTinh;

	internal CheckBox ckbMatKhau;

	internal CheckBox ckbMatKhauMail;

	internal CheckBox ckbBackup;

	internal CheckBox F79F2BAF;

	internal CheckBox D11A680C;

	internal CheckBox ckbProxy;

	internal CheckBox DC8A10AD;

	internal CheckBox ckbAvatar;

	internal CheckBox EB0DCF30;

	internal CheckBox B5A3C1B3;

	internal CheckBox ACB38B89;

	internal CheckBox ckbThuMuc;

	internal CheckBox ckbFollow;

	internal CheckBox ckbInteractEnd;

	internal CheckBox ckbDevice;

	internal CheckBox FE2D0639;

	public fCauHinhHienThi()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void E8172391(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configDatagridview").GetValue("cToken", ckbToken.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbCookie", ckbCookie.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbEmail", F481EC39.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbTen", ckbTen.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbBanBe", ckbBanBe.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbNhom", FFAD1CB4.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbNgaySinh", ckbNgaySinh.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbGioiTinh", ckbGioiTinh.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbMatKhau", ckbMatKhau.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbMatKhauMail", ckbMatKhauMail.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbPhone", FE2D0639.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbBackup", ckbBackup.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbMa2FA", F79F2BAF.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbUseragent", D11A680C.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbProxy", ckbProxy.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbNgayTao", DC8A10AD.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbAvatar", ckbAvatar.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbProfile", EB0DCF30.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbTinhTrang", B5A3C1B3.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbThuMuc", ckbThuMuc.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbGhiChu", ACB38B89.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbFollow", ckbFollow.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbInteractEnd", ckbInteractEnd.Checked);
		SettingsTool.GetSettings("configDatagridview").GetValue("ckbDevice", ckbDevice.Checked);
		SettingsTool.smethod_0("configDatagridview");
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FEBD1B26(object sender, EventArgs e)
	{
	}

	private void fCauHinhHienThi_Load(object sender, EventArgs e)
	{
		ckbToken.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("cToken");
		ckbCookie.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbCookie");
		F481EC39.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbEmail");
		ckbTen.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbTen");
		ckbBanBe.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbBanBe");
		FFAD1CB4.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbNhom");
		ckbNgaySinh.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbNgaySinh");
		ckbGioiTinh.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbGioiTinh");
		ckbMatKhau.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbMatKhau");
		ckbMatKhauMail.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbMatKhauMail");
		FE2D0639.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbPhone");
		ckbBackup.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbBackup");
		F79F2BAF.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbMa2FA");
		D11A680C.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbUseragent");
		ckbProxy.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbProxy");
		DC8A10AD.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbNgayTao");
		ckbAvatar.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbAvatar");
		EB0DCF30.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbProfile");
		B5A3C1B3.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbTinhTrang");
		ckbThuMuc.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbThuMuc");
		ACB38B89.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbGhiChu");
		ckbFollow.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbFollow");
		ckbInteractEnd.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbInteractEnd");
		ckbDevice.Checked = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbDevice");
	}

	protected override void Dispose(bool C32C9391)
	{
		if (C32C9391 && D236A587 != null)
		{
			D236A587.Dispose();
		}
		base.Dispose(C32C9391);
	}

	private void InitializeComponent()
	{
		D236A587 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhHienThi));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		DF0B9839 = new System.Windows.Forms.Panel();
		FD2E9DB3 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(D236A587);
		DB37CC26 = new Bunifu.Framework.UI.BunifuCustomLabel();
		ckbToken = new System.Windows.Forms.CheckBox();
		ckbCookie = new System.Windows.Forms.CheckBox();
		F481EC39 = new System.Windows.Forms.CheckBox();
		ckbTen = new System.Windows.Forms.CheckBox();
		ckbBanBe = new System.Windows.Forms.CheckBox();
		FFAD1CB4 = new System.Windows.Forms.CheckBox();
		ckbNgaySinh = new System.Windows.Forms.CheckBox();
		ckbGioiTinh = new System.Windows.Forms.CheckBox();
		ckbMatKhau = new System.Windows.Forms.CheckBox();
		ckbMatKhauMail = new System.Windows.Forms.CheckBox();
		ckbBackup = new System.Windows.Forms.CheckBox();
		F79F2BAF = new System.Windows.Forms.CheckBox();
		D11A680C = new System.Windows.Forms.CheckBox();
		ckbProxy = new System.Windows.Forms.CheckBox();
		DC8A10AD = new System.Windows.Forms.CheckBox();
		ckbAvatar = new System.Windows.Forms.CheckBox();
		EB0DCF30 = new System.Windows.Forms.CheckBox();
		B5A3C1B3 = new System.Windows.Forms.CheckBox();
		ACB38B89 = new System.Windows.Forms.CheckBox();
		ckbThuMuc = new System.Windows.Forms.CheckBox();
		ckbFollow = new System.Windows.Forms.CheckBox();
		ckbInteractEnd = new System.Windows.Forms.CheckBox();
		ckbDevice = new System.Windows.Forms.CheckBox();
		FE2D0639 = new System.Windows.Forms.CheckBox();
		bunifuCards1.SuspendLayout();
		DF0B9839.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FD2E9DB3).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(DF0B9839);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(479, 38);
		bunifuCards1.TabIndex = 0;
		DF0B9839.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DF0B9839.BackColor = System.Drawing.Color.White;
		DF0B9839.Controls.Add(FD2E9DB3);
		DF0B9839.Controls.Add(btnMinimize);
		DF0B9839.Controls.Add(bunifuCustomLabel1);
		DF0B9839.Location = new System.Drawing.Point(0, 5);
		DF0B9839.Name = "pnlHeader";
		DF0B9839.Size = new System.Drawing.Size(479, 32);
		DF0B9839.TabIndex = 9;
		FD2E9DB3.Cursor = System.Windows.Forms.Cursors.Default;
		FD2E9DB3.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		FD2E9DB3.Location = new System.Drawing.Point(3, 2);
		FD2E9DB3.Name = "pictureBox1";
		FD2E9DB3.Size = new System.Drawing.Size(34, 27);
		FD2E9DB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		FD2E9DB3.TabIndex = 17;
		FD2E9DB3.TabStop = false;
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
		btnMinimize.Click += new System.EventHandler(E8172391);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(479, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh hiê\u0309n thi\u0323";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(247, 253);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(143, 253);
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
		DB37CC26.BackColor = System.Drawing.Color.Transparent;
		DB37CC26.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DB37CC26.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DB37CC26.ForeColor = System.Drawing.Color.Black;
		DB37CC26.Location = new System.Drawing.Point(51, 41);
		DB37CC26.Name = "lblStatus";
		DB37CC26.Size = new System.Drawing.Size(384, 32);
		DB37CC26.TabIndex = 21;
		DB37CC26.Text = "Vui lo\u0300ng cho\u0323n như\u0303ng cô\u0323t câ\u0300n hiê\u0309n thi\u0323!";
		DB37CC26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DB37CC26.Click += new System.EventHandler(FEBD1B26);
		ckbToken.AutoSize = true;
		ckbToken.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbToken.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbToken.Location = new System.Drawing.Point(31, 85);
		ckbToken.Name = "ckbToken";
		ckbToken.Size = new System.Drawing.Size(61, 20);
		ckbToken.TabIndex = 22;
		ckbToken.Text = "Token";
		ckbToken.UseVisualStyleBackColor = true;
		ckbCookie.AutoSize = true;
		ckbCookie.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCookie.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbCookie.Location = new System.Drawing.Point(31, 111);
		ckbCookie.Name = "ckbCookie";
		ckbCookie.Size = new System.Drawing.Size(64, 20);
		ckbCookie.TabIndex = 22;
		ckbCookie.Text = "Cookie";
		ckbCookie.UseVisualStyleBackColor = true;
		F481EC39.AutoSize = true;
		F481EC39.Cursor = System.Windows.Forms.Cursors.Hand;
		F481EC39.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F481EC39.Location = new System.Drawing.Point(31, 137);
		F481EC39.Name = "ckbEmail";
		F481EC39.Size = new System.Drawing.Size(57, 20);
		F481EC39.TabIndex = 22;
		F481EC39.Text = "Email";
		F481EC39.UseVisualStyleBackColor = true;
		ckbTen.AutoSize = true;
		ckbTen.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTen.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbTen.Location = new System.Drawing.Point(31, 163);
		ckbTen.Name = "ckbTen";
		ckbTen.Size = new System.Drawing.Size(48, 20);
		ckbTen.TabIndex = 22;
		ckbTen.Text = "Tên";
		ckbTen.UseVisualStyleBackColor = true;
		ckbBanBe.AutoSize = true;
		ckbBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBanBe.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbBanBe.Location = new System.Drawing.Point(31, 215);
		ckbBanBe.Name = "ckbBanBe";
		ckbBanBe.Size = new System.Drawing.Size(65, 20);
		ckbBanBe.TabIndex = 22;
		ckbBanBe.Text = "Ba\u0323n be\u0300";
		ckbBanBe.UseVisualStyleBackColor = true;
		FFAD1CB4.AutoSize = true;
		FFAD1CB4.Cursor = System.Windows.Forms.Cursors.Hand;
		FFAD1CB4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FFAD1CB4.Location = new System.Drawing.Point(128, 85);
		FFAD1CB4.Name = "ckbNhom";
		FFAD1CB4.Size = new System.Drawing.Size(59, 20);
		FFAD1CB4.TabIndex = 22;
		FFAD1CB4.Text = "Nho\u0301m";
		FFAD1CB4.UseVisualStyleBackColor = true;
		ckbNgaySinh.AutoSize = true;
		ckbNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbNgaySinh.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbNgaySinh.Location = new System.Drawing.Point(128, 111);
		ckbNgaySinh.Name = "ckbNgaySinh";
		ckbNgaySinh.Size = new System.Drawing.Size(81, 20);
		ckbNgaySinh.TabIndex = 22;
		ckbNgaySinh.Text = "Nga\u0300y sinh";
		ckbNgaySinh.UseVisualStyleBackColor = true;
		ckbGioiTinh.AutoSize = true;
		ckbGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGioiTinh.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbGioiTinh.Location = new System.Drawing.Point(128, 137);
		ckbGioiTinh.Name = "ckbGioiTinh";
		ckbGioiTinh.Size = new System.Drawing.Size(72, 20);
		ckbGioiTinh.TabIndex = 22;
		ckbGioiTinh.Text = "Giơ\u0301i ti\u0301nh";
		ckbGioiTinh.UseVisualStyleBackColor = true;
		ckbMatKhau.AutoSize = true;
		ckbMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbMatKhau.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbMatKhau.Location = new System.Drawing.Point(128, 163);
		ckbMatKhau.Name = "ckbMatKhau";
		ckbMatKhau.Size = new System.Drawing.Size(78, 20);
		ckbMatKhau.TabIndex = 22;
		ckbMatKhau.Text = "Mâ\u0323t khâ\u0309u";
		ckbMatKhau.UseVisualStyleBackColor = true;
		ckbMatKhauMail.AutoSize = true;
		ckbMatKhauMail.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbMatKhauMail.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbMatKhauMail.Location = new System.Drawing.Point(128, 189);
		ckbMatKhauMail.Name = "ckbMatKhauMail";
		ckbMatKhauMail.Size = new System.Drawing.Size(106, 20);
		ckbMatKhauMail.TabIndex = 22;
		ckbMatKhauMail.Text = "Mâ\u0323t khâ\u0309u mail";
		ckbMatKhauMail.UseVisualStyleBackColor = true;
		ckbBackup.AutoSize = true;
		ckbBackup.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBackup.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbBackup.Location = new System.Drawing.Point(253, 111);
		ckbBackup.Name = "ckbBackup";
		ckbBackup.Size = new System.Drawing.Size(66, 20);
		ckbBackup.TabIndex = 22;
		ckbBackup.Text = "Backup";
		ckbBackup.UseVisualStyleBackColor = true;
		F79F2BAF.AutoSize = true;
		F79F2BAF.Cursor = System.Windows.Forms.Cursors.Hand;
		F79F2BAF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F79F2BAF.Location = new System.Drawing.Point(253, 85);
		F79F2BAF.Name = "ckbMa2FA";
		F79F2BAF.Size = new System.Drawing.Size(69, 20);
		F79F2BAF.TabIndex = 22;
		F79F2BAF.Text = "Ma\u0303 2FA";
		F79F2BAF.UseVisualStyleBackColor = true;
		D11A680C.AutoSize = true;
		D11A680C.Cursor = System.Windows.Forms.Cursors.Hand;
		D11A680C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D11A680C.Location = new System.Drawing.Point(253, 137);
		D11A680C.Name = "ckbUseragent";
		D11A680C.Size = new System.Drawing.Size(84, 20);
		D11A680C.TabIndex = 22;
		D11A680C.Text = "Useragent";
		D11A680C.UseVisualStyleBackColor = true;
		ckbProxy.AutoSize = true;
		ckbProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbProxy.Location = new System.Drawing.Point(253, 163);
		ckbProxy.Name = "ckbProxy";
		ckbProxy.Size = new System.Drawing.Size(57, 20);
		ckbProxy.TabIndex = 22;
		ckbProxy.Text = "Proxy";
		ckbProxy.UseVisualStyleBackColor = true;
		DC8A10AD.AutoSize = true;
		DC8A10AD.Cursor = System.Windows.Forms.Cursors.Hand;
		DC8A10AD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DC8A10AD.Location = new System.Drawing.Point(253, 189);
		DC8A10AD.Name = "ckbNgayTao";
		DC8A10AD.Size = new System.Drawing.Size(76, 20);
		DC8A10AD.TabIndex = 22;
		DC8A10AD.Text = "Nga\u0300y ta\u0323o";
		DC8A10AD.UseVisualStyleBackColor = true;
		ckbAvatar.AutoSize = true;
		ckbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAvatar.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbAvatar.Location = new System.Drawing.Point(253, 215);
		ckbAvatar.Name = "ckbAvatar";
		ckbAvatar.Size = new System.Drawing.Size(63, 20);
		ckbAvatar.TabIndex = 22;
		ckbAvatar.Text = "Avatar";
		ckbAvatar.UseVisualStyleBackColor = true;
		EB0DCF30.AutoSize = true;
		EB0DCF30.Cursor = System.Windows.Forms.Cursors.Hand;
		EB0DCF30.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EB0DCF30.Location = new System.Drawing.Point(356, 85);
		EB0DCF30.Name = "ckbProfile";
		EB0DCF30.Size = new System.Drawing.Size(62, 20);
		EB0DCF30.TabIndex = 22;
		EB0DCF30.Text = "Profile";
		EB0DCF30.UseVisualStyleBackColor = true;
		B5A3C1B3.AutoSize = true;
		B5A3C1B3.Cursor = System.Windows.Forms.Cursors.Hand;
		B5A3C1B3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B5A3C1B3.Location = new System.Drawing.Point(356, 163);
		B5A3C1B3.Name = "ckbTinhTrang";
		B5A3C1B3.Size = new System.Drawing.Size(85, 20);
		B5A3C1B3.TabIndex = 22;
		B5A3C1B3.Text = "Ti\u0300nh tra\u0323ng";
		B5A3C1B3.UseVisualStyleBackColor = true;
		ACB38B89.AutoSize = true;
		ACB38B89.Cursor = System.Windows.Forms.Cursors.Hand;
		ACB38B89.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ACB38B89.Location = new System.Drawing.Point(356, 215);
		ACB38B89.Name = "ckbGhiChu";
		ACB38B89.Size = new System.Drawing.Size(68, 20);
		ACB38B89.TabIndex = 22;
		ACB38B89.Text = "Ghi chú";
		ACB38B89.UseVisualStyleBackColor = true;
		ckbThuMuc.AutoSize = true;
		ckbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbThuMuc.Location = new System.Drawing.Point(356, 189);
		ckbThuMuc.Name = "ckbThuMuc";
		ckbThuMuc.Size = new System.Drawing.Size(77, 20);
		ckbThuMuc.TabIndex = 22;
		ckbThuMuc.Text = "Thư mục";
		ckbThuMuc.UseVisualStyleBackColor = true;
		ckbFollow.AutoSize = true;
		ckbFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbFollow.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbFollow.Location = new System.Drawing.Point(31, 189);
		ckbFollow.Name = "ckbFollow";
		ckbFollow.Size = new System.Drawing.Size(76, 20);
		ckbFollow.TabIndex = 22;
		ckbFollow.Text = "Theo do\u0303i";
		ckbFollow.UseVisualStyleBackColor = true;
		ckbInteractEnd.AutoSize = true;
		ckbInteractEnd.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteractEnd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbInteractEnd.Location = new System.Drawing.Point(356, 111);
		ckbInteractEnd.Name = "ckbInteractEnd";
		ckbInteractEnd.Size = new System.Drawing.Size(111, 20);
		ckbInteractEnd.TabIndex = 22;
		ckbInteractEnd.Text = "Tương ta\u0301c cuô\u0301i";
		ckbInteractEnd.UseVisualStyleBackColor = true;
		ckbDevice.AutoSize = true;
		ckbDevice.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDevice.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbDevice.Location = new System.Drawing.Point(356, 137);
		ckbDevice.Name = "ckbDevice";
		ckbDevice.Size = new System.Drawing.Size(89, 20);
		ckbDevice.TabIndex = 22;
		ckbDevice.Text = "Device Info";
		ckbDevice.UseVisualStyleBackColor = true;
		FE2D0639.AutoSize = true;
		FE2D0639.Cursor = System.Windows.Forms.Cursors.Hand;
		FE2D0639.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FE2D0639.Location = new System.Drawing.Point(128, 215);
		FE2D0639.Name = "ckbPhone";
		FE2D0639.Size = new System.Drawing.Size(61, 20);
		FE2D0639.TabIndex = 22;
		FE2D0639.Text = "Phone";
		FE2D0639.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(479, 295);
		base.Controls.Add(ckbThuMuc);
		base.Controls.Add(ACB38B89);
		base.Controls.Add(ckbInteractEnd);
		base.Controls.Add(B5A3C1B3);
		base.Controls.Add(EB0DCF30);
		base.Controls.Add(ckbAvatar);
		base.Controls.Add(DC8A10AD);
		base.Controls.Add(ckbProxy);
		base.Controls.Add(D11A680C);
		base.Controls.Add(F79F2BAF);
		base.Controls.Add(ckbBackup);
		base.Controls.Add(FE2D0639);
		base.Controls.Add(ckbMatKhauMail);
		base.Controls.Add(ckbMatKhau);
		base.Controls.Add(ckbGioiTinh);
		base.Controls.Add(ckbNgaySinh);
		base.Controls.Add(FFAD1CB4);
		base.Controls.Add(ckbFollow);
		base.Controls.Add(ckbBanBe);
		base.Controls.Add(ckbTen);
		base.Controls.Add(F481EC39);
		base.Controls.Add(ckbCookie);
		base.Controls.Add(ckbToken);
		base.Controls.Add(DB37CC26);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(ckbDevice);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhHienThi";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhHienThi_Load);
		bunifuCards1.ResumeLayout(false);
		DF0B9839.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)FD2E9DB3).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
