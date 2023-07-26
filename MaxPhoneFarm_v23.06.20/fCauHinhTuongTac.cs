using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhTuongTac : Form
{
	internal IContainer D4855305 = null;

	internal BunifuCards AE11250B;

	internal Panel pnlHeader;

	internal BunifuCustomLabel A3AD12A2;

	internal Button B1824096;

	internal Button DD02DC17;

	internal Button AAAA7103;

	internal BunifuDragControl AA13F482;

	internal PictureBox DE9D64A7;

	internal GroupBox DDAACE03;

	internal CheckBox ckbRandomHanhDong;

	internal ComboBox cbbKichBan;

	internal Button C3155BB6;

	internal Label D8A502BE;

	internal CheckBox CB8FB23D;

	internal Panel panel1;

	internal CheckBox ckbRepeatAll;

	internal Label label2;

	internal Panel panel2;

	internal RadioButton rbLoginEmailPass;

	internal RadioButton rbLoginUidPass;

	internal Panel B2148C09;

	internal Label label6;

	internal Label label4;

	internal NumericUpDown nudDelayTurnFrom;

	internal Label F421EB3F;

	internal NumericUpDown F984A196;

	internal Label F2A8A7BB;

	internal NumericUpDown F3A1A987;

	internal Label label10;

	internal CheckBox ckbCheckLiveUid;

	internal GroupBox groupBox1;

	internal CheckBox ckbRandomThuTuTaiKhoan;

	internal Panel F39EAC19;

	internal Label label3;

	internal NumericUpDown nudThoiGianChayKichBanTo;

	internal NumericUpDown nudThoiGianChayKichBanFrom;

	internal Panel D1258395;

	internal Label BC08D501;

	internal NumericUpDown AF28040D;

	internal NumericUpDown nudThoiGianChayTaiKhoanFrom;

	internal CheckBox ckbGioiHanThoiGianChayKichBan;

	internal CheckBox ckbGioiHanThoiGianChayTaiKhoan;

	internal CheckBox DA11EA8D;

	internal Panel plCapNhatThongTin;

	internal CheckBox ckbEmail;

	internal CheckBox ckbNgayTao;

	internal CheckBox DC0B552B;

	internal CheckBox F6285615;

	internal CheckBox CB0C4392;

	internal CheckBox C8ADFC2E;

	internal CheckBox ckbFriend;

	internal CheckBox ckbName;

	internal CheckBox ckbCapNhatThongTin;

	internal CheckBox ckbCongKhaiThongTin;

	internal CheckBox ECA93290;

	internal CheckBox E727AA0C;

	internal CheckBox ckbAllowFollow;

	public fCauHinhTuongTac()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void B1824096_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AAAA7103_Click(object sender, EventArgs e)
	{
		int num = 0;
		if (rbLoginEmailPass.Checked)
		{
			num = 1;
		}
		SettingsTool.GetSettings("configInteractGeneral").GetValue("typeLogin", num);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbGetToken", CB8FB23D.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbGetCookie", E727AA0C.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbCheckGoiYKetBan", DA11EA8D.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbCheckLiveUid", ckbCheckLiveUid.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbCongKhaiThongTin", ckbCongKhaiThongTin.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbAllowFollow", ckbAllowFollow.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbCapNhatThongTin", ckbCapNhatThongTin.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbName", ckbName.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbGender", C8ADFC2E.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbBirthday", F6285615.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbNgayTao", ckbNgayTao.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbEmail", ckbEmail.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbPhone", ECA93290.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbFriend", ckbFriend.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbGroup", CB0C4392.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbFollow", DC0B552B.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbRepeatAll", ckbRepeatAll.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("nudDelayTurnFrom", nudDelayTurnFrom.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("nudDelayTurnTo", F984A196.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("nudSoLuotChay", F3A1A987.Value);
        SettingsTool.GetSettings("configInteractGeneral").GetValue("RepeatAllVIP", (object)"false");
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbRandomThuTuTaiKhoan", ckbRandomThuTuTaiKhoan.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("cbbKichBan", cbbKichBan.SelectedValue);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbRandomHanhDong", ckbRandomHanhDong.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbGioiHanThoiGianChayTaiKhoan", ckbGioiHanThoiGianChayTaiKhoan.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("nudThoiGianChayTaiKhoanFrom", nudThoiGianChayTaiKhoanFrom.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("nudThoiGianChayTaiKhoanTo", AF28040D.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("ckbGioiHanThoiGianChayKichBan", ckbGioiHanThoiGianChayKichBan.Checked);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("nudThoiGianChayKichBanFrom", nudThoiGianChayKichBanFrom.Value);
		SettingsTool.GetSettings("configInteractGeneral").GetValue("nudThoiGianChayKichBanTo", nudThoiGianChayKichBanTo.Value);
		SettingsTool.smethod_0("configInteractGeneral");
		if (MessageBoxHelper.smethod_1(Language.GetValue("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?")) == DialogResult.Yes)
		{
			Close();
		}
	}

	private void DD02DC17_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C3155BB6_Click(object sender, EventArgs e)
	{
		string string_ = "";
		try
		{
			if (cbbKichBan.Items.Count > 0)
			{
				string_ = cbbKichBan.SelectedValue.ToString();
			}
		}
		catch
		{
		}
		Common.smethod_16(new fDanhSachKichBan_Old(string_));
		method_1();
	}

	private void C91F14BD()
	{
		D09CB915(null, null);
		ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged(null, null);
		E5A24882(null, null);
		ckbCapNhatThongTin_CheckedChanged(null, null);
	}

	private void fCauHinhTuongTac_Load(object sender, EventArgs e)
	{
		method_1();
		method_0();
		C91F14BD();
	}

	private void method_0()
	{
		try
		{
			switch (SettingsTool.GetSettings("configInteractGeneral").method_0("typeLogin"))
			{
			case 1:
				rbLoginEmailPass.Checked = true;
				break;
			case 0:
				rbLoginUidPass.Checked = true;
				break;
			}
			CB8FB23D.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbGetToken");
			E727AA0C.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbGetCookie");
			DA11EA8D.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbCheckGoiYKetBan");
			ckbCheckLiveUid.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbCheckLiveUid");
			ckbCongKhaiThongTin.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbCongKhaiThongTin");
			ckbAllowFollow.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbAllowFollow");
			ckbCapNhatThongTin.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbCapNhatThongTin");
			ckbName.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbName");
			C8ADFC2E.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbGender");
			F6285615.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbBirthday");
			ckbNgayTao.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbNgayTao");
			ckbEmail.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbEmail");
			ECA93290.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbPhone");
			ckbFriend.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbFriend");
			CB0C4392.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbGroup");
			DC0B552B.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbFollow");
			ckbRepeatAll.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRepeatAll");
			nudDelayTurnFrom.Value = SettingsTool.GetSettings("configInteractGeneral").method_0("nudDelayTurnFrom");
			F984A196.Value = SettingsTool.GetSettings("configInteractGeneral").method_0("nudDelayTurnTo");
			F3A1A987.Value = SettingsTool.GetSettings("configInteractGeneral").method_0("nudSoLuotChay");
			ckbRandomThuTuTaiKhoan.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRandomThuTuTaiKhoan");
			cbbKichBan.SelectedValue = SettingsTool.GetSettings("configInteractGeneral").GetValue("cbbKichBan");
			ckbRandomHanhDong.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRandomHanhDong");
			ckbGioiHanThoiGianChayTaiKhoan.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbGioiHanThoiGianChayTaiKhoan");
			nudThoiGianChayTaiKhoanFrom.Value = SettingsTool.GetSettings("configInteractGeneral").method_0("nudThoiGianChayTaiKhoanFrom", 1);
			AF28040D.Value = SettingsTool.GetSettings("configInteractGeneral").method_0("nudThoiGianChayTaiKhoanTo", 1);
			ckbGioiHanThoiGianChayKichBan.Checked = SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbGioiHanThoiGianChayKichBan");
			nudThoiGianChayKichBanFrom.Value = SettingsTool.GetSettings("configInteractGeneral").method_0("nudThoiGianChayKichBanFrom", 1);
			nudThoiGianChayKichBanTo.Value = SettingsTool.GetSettings("configInteractGeneral").method_0("nudThoiGianChayKichBanTo", 1);
		}
		catch
		{
		}
	}

	private void method_1()
	{
		int num = -1;
		if (cbbKichBan.SelectedIndex != -1)
		{
			num = cbbKichBan.SelectedIndex;
		}
		DataTable dataSource = Class123.smethod_3();
		cbbKichBan.DataSource = dataSource;
		cbbKichBan.ValueMember = "Id_KichBan";
		cbbKichBan.DisplayMember = "Ten";
		if (num != -1 && num != 0 && cbbKichBan.Items.Count >= num + 1)
		{
			cbbKichBan.SelectedIndex = num;
		}
		else if (cbbKichBan.Items.Count > 0)
		{
			cbbKichBan.SelectedIndex = 0;
		}
	}

	private void D09CB915(object sender, EventArgs e)
	{
		B2148C09.Enabled = ckbRepeatAll.Checked;
	}

	private void ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged(object sender, EventArgs e)
	{
		D1258395.Enabled = ckbGioiHanThoiGianChayTaiKhoan.Checked;
	}

	private void E5A24882(object sender, EventArgs e)
	{
		F39EAC19.Enabled = ckbGioiHanThoiGianChayKichBan.Checked;
	}

	private void ckbCapNhatThongTin_CheckedChanged(object sender, EventArgs e)
	{
		plCapNhatThongTin.Enabled = ckbCapNhatThongTin.Checked;
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && D4855305 != null)
		{
			D4855305.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		D4855305 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhTuongTac));
		AE11250B = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		DE9D64A7 = new System.Windows.Forms.PictureBox();
		B1824096 = new System.Windows.Forms.Button();
		A3AD12A2 = new Bunifu.Framework.UI.BunifuCustomLabel();
		DD02DC17 = new System.Windows.Forms.Button();
		AAAA7103 = new System.Windows.Forms.Button();
		AA13F482 = new Bunifu.Framework.UI.BunifuDragControl(D4855305);
		DDAACE03 = new System.Windows.Forms.GroupBox();
		F39EAC19 = new System.Windows.Forms.Panel();
		label3 = new System.Windows.Forms.Label();
		nudThoiGianChayKichBanTo = new System.Windows.Forms.NumericUpDown();
		nudThoiGianChayKichBanFrom = new System.Windows.Forms.NumericUpDown();
		D1258395 = new System.Windows.Forms.Panel();
		BC08D501 = new System.Windows.Forms.Label();
		AF28040D = new System.Windows.Forms.NumericUpDown();
		nudThoiGianChayTaiKhoanFrom = new System.Windows.Forms.NumericUpDown();
		ckbGioiHanThoiGianChayKichBan = new System.Windows.Forms.CheckBox();
		ckbGioiHanThoiGianChayTaiKhoan = new System.Windows.Forms.CheckBox();
		ckbRandomHanhDong = new System.Windows.Forms.CheckBox();
		cbbKichBan = new System.Windows.Forms.ComboBox();
		D8A502BE = new System.Windows.Forms.Label();
		C3155BB6 = new System.Windows.Forms.Button();
		label2 = new System.Windows.Forms.Label();
		CB8FB23D = new System.Windows.Forms.CheckBox();
		ckbRepeatAll = new System.Windows.Forms.CheckBox();
		panel1 = new System.Windows.Forms.Panel();
		groupBox1 = new System.Windows.Forms.GroupBox();
		plCapNhatThongTin = new System.Windows.Forms.Panel();
		ECA93290 = new System.Windows.Forms.CheckBox();
		ckbEmail = new System.Windows.Forms.CheckBox();
		ckbNgayTao = new System.Windows.Forms.CheckBox();
		DC0B552B = new System.Windows.Forms.CheckBox();
		F6285615 = new System.Windows.Forms.CheckBox();
		CB0C4392 = new System.Windows.Forms.CheckBox();
		C8ADFC2E = new System.Windows.Forms.CheckBox();
		ckbFriend = new System.Windows.Forms.CheckBox();
		ckbName = new System.Windows.Forms.CheckBox();
		ckbCapNhatThongTin = new System.Windows.Forms.CheckBox();
		panel2 = new System.Windows.Forms.Panel();
		rbLoginEmailPass = new System.Windows.Forms.RadioButton();
		rbLoginUidPass = new System.Windows.Forms.RadioButton();
		B2148C09 = new System.Windows.Forms.Panel();
		label6 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		nudDelayTurnFrom = new System.Windows.Forms.NumericUpDown();
		F421EB3F = new System.Windows.Forms.Label();
		F984A196 = new System.Windows.Forms.NumericUpDown();
		F2A8A7BB = new System.Windows.Forms.Label();
		F3A1A987 = new System.Windows.Forms.NumericUpDown();
		label10 = new System.Windows.Forms.Label();
		ckbCheckLiveUid = new System.Windows.Forms.CheckBox();
		ckbAllowFollow = new System.Windows.Forms.CheckBox();
		ckbCongKhaiThongTin = new System.Windows.Forms.CheckBox();
		DA11EA8D = new System.Windows.Forms.CheckBox();
		E727AA0C = new System.Windows.Forms.CheckBox();
		ckbRandomThuTuTaiKhoan = new System.Windows.Forms.CheckBox();
		AE11250B.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DE9D64A7).BeginInit();
		DDAACE03.SuspendLayout();
		F39EAC19.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudThoiGianChayKichBanTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudThoiGianChayKichBanFrom).BeginInit();
		D1258395.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)AF28040D).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudThoiGianChayTaiKhoanFrom).BeginInit();
		panel1.SuspendLayout();
		groupBox1.SuspendLayout();
		plCapNhatThongTin.SuspendLayout();
		panel2.SuspendLayout();
		B2148C09.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTurnFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)F984A196).BeginInit();
		((System.ComponentModel.ISupportInitialize)F3A1A987).BeginInit();
		SuspendLayout();
		AE11250B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		AE11250B.BackColor = System.Drawing.Color.White;
		AE11250B.BorderRadius = 0;
		AE11250B.BottomSahddow = true;
		AE11250B.color = System.Drawing.Color.FromArgb(24, 119, 242);
		AE11250B.Controls.Add(pnlHeader);
		AE11250B.LeftSahddow = false;
		AE11250B.Location = new System.Drawing.Point(2, 1);
		AE11250B.Name = "bunifuCards1";
		AE11250B.RightSahddow = true;
		AE11250B.ShadowDepth = 20;
		AE11250B.Size = new System.Drawing.Size(441, 38);
		AE11250B.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(DE9D64A7);
		pnlHeader.Controls.Add(B1824096);
		pnlHeader.Controls.Add(A3AD12A2);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(441, 32);
		pnlHeader.TabIndex = 9;
		DE9D64A7.Cursor = System.Windows.Forms.Cursors.Default;
		DE9D64A7.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		DE9D64A7.Location = new System.Drawing.Point(3, 1);
		DE9D64A7.Name = "pictureBox1";
		DE9D64A7.Size = new System.Drawing.Size(34, 27);
		DE9D64A7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		DE9D64A7.TabIndex = 78;
		DE9D64A7.TabStop = false;
		B1824096.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B1824096.Cursor = System.Windows.Forms.Cursors.Hand;
		B1824096.FlatAppearance.BorderSize = 0;
		B1824096.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B1824096.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B1824096.ForeColor = System.Drawing.Color.White;
		B1824096.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		B1824096.Location = new System.Drawing.Point(407, -2);
		B1824096.Name = "btnMinimize";
		B1824096.Size = new System.Drawing.Size(32, 32);
		B1824096.TabIndex = 9;
		B1824096.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B1824096.UseVisualStyleBackColor = true;
		B1824096.Click += new System.EventHandler(B1824096_Click);
		A3AD12A2.BackColor = System.Drawing.Color.Transparent;
		A3AD12A2.Cursor = System.Windows.Forms.Cursors.SizeAll;
		A3AD12A2.Dock = System.Windows.Forms.DockStyle.Fill;
		A3AD12A2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A3AD12A2.ForeColor = System.Drawing.Color.Black;
		A3AD12A2.Location = new System.Drawing.Point(0, 0);
		A3AD12A2.Name = "bunifuCustomLabel1";
		A3AD12A2.Size = new System.Drawing.Size(441, 32);
		A3AD12A2.TabIndex = 1;
		A3AD12A2.Text = "Cấu hình Tương tác";
		A3AD12A2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DD02DC17.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		DD02DC17.BackColor = System.Drawing.Color.Maroon;
		DD02DC17.Cursor = System.Windows.Forms.Cursors.Hand;
		DD02DC17.FlatAppearance.BorderSize = 0;
		DD02DC17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DD02DC17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DD02DC17.ForeColor = System.Drawing.Color.White;
		DD02DC17.Location = new System.Drawing.Point(226, 583);
		DD02DC17.Name = "btnCancel";
		DD02DC17.Size = new System.Drawing.Size(92, 29);
		DD02DC17.TabIndex = 4;
		DD02DC17.Text = "Đóng";
		DD02DC17.UseVisualStyleBackColor = false;
		DD02DC17.Click += new System.EventHandler(DD02DC17_Click);
		AAAA7103.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		AAAA7103.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		AAAA7103.Cursor = System.Windows.Forms.Cursors.Hand;
		AAAA7103.FlatAppearance.BorderSize = 0;
		AAAA7103.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AAAA7103.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AAAA7103.ForeColor = System.Drawing.Color.White;
		AAAA7103.Location = new System.Drawing.Point(122, 583);
		AAAA7103.Name = "btnAdd";
		AAAA7103.Size = new System.Drawing.Size(92, 29);
		AAAA7103.TabIndex = 3;
		AAAA7103.Text = "Lưu";
		AAAA7103.UseVisualStyleBackColor = false;
		AAAA7103.Click += new System.EventHandler(AAAA7103_Click);
		AA13F482.Fixed = true;
		AA13F482.Horizontal = true;
		AA13F482.TargetControl = A3AD12A2;
		AA13F482.Vertical = true;
		DDAACE03.Controls.Add(F39EAC19);
		DDAACE03.Controls.Add(D1258395);
		DDAACE03.Controls.Add(ckbGioiHanThoiGianChayKichBan);
		DDAACE03.Controls.Add(ckbGioiHanThoiGianChayTaiKhoan);
		DDAACE03.Controls.Add(ckbRandomHanhDong);
		DDAACE03.Controls.Add(cbbKichBan);
		DDAACE03.Controls.Add(D8A502BE);
		DDAACE03.Controls.Add(C3155BB6);
		DDAACE03.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DDAACE03.Location = new System.Drawing.Point(11, 423);
		DDAACE03.Name = "groupBox2";
		DDAACE03.Size = new System.Drawing.Size(420, 144);
		DDAACE03.TabIndex = 7;
		DDAACE03.TabStop = false;
		DDAACE03.Text = "Tùy chọn tương tác";
		F39EAC19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F39EAC19.Controls.Add(label3);
		F39EAC19.Controls.Add(nudThoiGianChayKichBanTo);
		F39EAC19.Controls.Add(nudThoiGianChayKichBanFrom);
		F39EAC19.Location = new System.Drawing.Point(292, 108);
		F39EAC19.Name = "plGioiHanThoiGianChayKichBan";
		F39EAC19.Size = new System.Drawing.Size(123, 27);
		F39EAC19.TabIndex = 10;
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(52, 4);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(18, 16);
		label3.TabIndex = 4;
		label3.Text = ">";
		nudThoiGianChayKichBanTo.Location = new System.Drawing.Point(71, 1);
		nudThoiGianChayKichBanTo.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		nudThoiGianChayKichBanTo.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudThoiGianChayKichBanTo.Name = "nudThoiGianChayKichBanTo";
		nudThoiGianChayKichBanTo.Size = new System.Drawing.Size(48, 23);
		nudThoiGianChayKichBanTo.TabIndex = 3;
		nudThoiGianChayKichBanTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		nudThoiGianChayKichBanFrom.Location = new System.Drawing.Point(1, 1);
		nudThoiGianChayKichBanFrom.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		nudThoiGianChayKichBanFrom.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudThoiGianChayKichBanFrom.Name = "nudThoiGianChayKichBanFrom";
		nudThoiGianChayKichBanFrom.Size = new System.Drawing.Size(48, 23);
		nudThoiGianChayKichBanFrom.TabIndex = 3;
		nudThoiGianChayKichBanFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		D1258395.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D1258395.Controls.Add(BC08D501);
		D1258395.Controls.Add(AF28040D);
		D1258395.Controls.Add(nudThoiGianChayTaiKhoanFrom);
		D1258395.Location = new System.Drawing.Point(292, 76);
		D1258395.Name = "plGioiHanThoiGianChayTaiKhoan";
		D1258395.Size = new System.Drawing.Size(123, 27);
		D1258395.TabIndex = 10;
		BC08D501.AutoSize = true;
		BC08D501.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BC08D501.Location = new System.Drawing.Point(52, 4);
		BC08D501.Name = "label13";
		BC08D501.Size = new System.Drawing.Size(18, 16);
		BC08D501.TabIndex = 4;
		BC08D501.Text = ">";
		AF28040D.Location = new System.Drawing.Point(71, 1);
		AF28040D.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		AF28040D.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		AF28040D.Name = "nudThoiGianChayTaiKhoanTo";
		AF28040D.Size = new System.Drawing.Size(48, 23);
		AF28040D.TabIndex = 3;
		AF28040D.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		nudThoiGianChayTaiKhoanFrom.Location = new System.Drawing.Point(1, 1);
		nudThoiGianChayTaiKhoanFrom.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		nudThoiGianChayTaiKhoanFrom.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudThoiGianChayTaiKhoanFrom.Name = "nudThoiGianChayTaiKhoanFrom";
		nudThoiGianChayTaiKhoanFrom.Size = new System.Drawing.Size(48, 23);
		nudThoiGianChayTaiKhoanFrom.TabIndex = 3;
		nudThoiGianChayTaiKhoanFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		ckbGioiHanThoiGianChayKichBan.AutoSize = true;
		ckbGioiHanThoiGianChayKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGioiHanThoiGianChayKichBan.Location = new System.Drawing.Point(19, 112);
		ckbGioiHanThoiGianChayKichBan.Name = "ckbGioiHanThoiGianChayKichBan";
		ckbGioiHanThoiGianChayKichBan.Size = new System.Drawing.Size(270, 20);
		ckbGioiHanThoiGianChayKichBan.TabIndex = 7;
		ckbGioiHanThoiGianChayKichBan.Text = "Giới hạn thời gian chạy mỗi kịch bản (phút)";
		ckbGioiHanThoiGianChayKichBan.UseVisualStyleBackColor = true;
		ckbGioiHanThoiGianChayKichBan.CheckedChanged += new System.EventHandler(E5A24882);
		ckbGioiHanThoiGianChayTaiKhoan.AutoSize = true;
		ckbGioiHanThoiGianChayTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbGioiHanThoiGianChayTaiKhoan.Location = new System.Drawing.Point(19, 79);
		ckbGioiHanThoiGianChayTaiKhoan.Name = "ckbGioiHanThoiGianChayTaiKhoan";
		ckbGioiHanThoiGianChayTaiKhoan.Size = new System.Drawing.Size(273, 20);
		ckbGioiHanThoiGianChayTaiKhoan.TabIndex = 8;
		ckbGioiHanThoiGianChayTaiKhoan.Text = "Giới hạn thời gian chạy mỗi tài khoản (giây)";
		ckbGioiHanThoiGianChayTaiKhoan.UseVisualStyleBackColor = true;
		ckbGioiHanThoiGianChayTaiKhoan.CheckedChanged += new System.EventHandler(ckbGioiHanThoiGianChayTaiKhoan_CheckedChanged);
		ckbRandomHanhDong.AutoSize = true;
		ckbRandomHanhDong.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbRandomHanhDong.Location = new System.Drawing.Point(19, 53);
		ckbRandomHanhDong.Name = "ckbRandomHanhDong";
		ckbRandomHanhDong.Size = new System.Drawing.Size(199, 20);
		ckbRandomHanhDong.TabIndex = 2;
		ckbRandomHanhDong.Text = "Random thứ tự các hành động";
		ckbRandomHanhDong.UseVisualStyleBackColor = true;
		cbbKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbKichBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbKichBan.DropDownWidth = 300;
		cbbKichBan.FormattingEnabled = true;
		cbbKichBan.Location = new System.Drawing.Point(115, 23);
		cbbKichBan.Name = "cbbKichBan";
		cbbKichBan.Size = new System.Drawing.Size(174, 24);
		cbbKichBan.TabIndex = 1;
		D8A502BE.AutoSize = true;
		D8A502BE.Location = new System.Drawing.Point(16, 26);
		D8A502BE.Name = "label1";
		D8A502BE.Size = new System.Drawing.Size(92, 16);
		D8A502BE.TabIndex = 0;
		D8A502BE.Text = "Chọn kịch bản:";
		C3155BB6.Cursor = System.Windows.Forms.Cursors.Hand;
		C3155BB6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		C3155BB6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C3155BB6.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C3155BB6.Location = new System.Drawing.Point(295, 23);
		C3155BB6.Name = "btnQuanLyKichBan";
		C3155BB6.Size = new System.Drawing.Size(120, 25);
		C3155BB6.TabIndex = 1;
		C3155BB6.Text = "Quản lý kịch bản";
		C3155BB6.Click += new System.EventHandler(C3155BB6_Click);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(16, 24);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(100, 16);
		label2.TabIndex = 3;
		label2.Text = "Kiểu đăng nhâ\u0323p:";
		CB8FB23D.AutoSize = true;
		CB8FB23D.Cursor = System.Windows.Forms.Cursors.Hand;
		CB8FB23D.Location = new System.Drawing.Point(19, 76);
		CB8FB23D.Name = "ckbGetToken";
		CB8FB23D.Size = new System.Drawing.Size(133, 20);
		CB8FB23D.TabIndex = 2;
		CB8FB23D.Text = "Tự động lấy Token";
		CB8FB23D.UseVisualStyleBackColor = true;
		ckbRepeatAll.AutoSize = true;
		ckbRepeatAll.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbRepeatAll.Location = new System.Drawing.Point(19, 257);
		ckbRepeatAll.Name = "ckbRepeatAll";
		ckbRepeatAll.Size = new System.Drawing.Size(344, 20);
		ckbRepeatAll.TabIndex = 2;
		ckbRepeatAll.Text = "Chạy tương tác lại toàn bộ tài khoản sau khi hoàn thành";
		ckbRepeatAll.UseVisualStyleBackColor = true;
		ckbRepeatAll.CheckedChanged += new System.EventHandler(D09CB915);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(DDAACE03);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(443, 625);
		panel1.TabIndex = 8;
		groupBox1.Controls.Add(plCapNhatThongTin);
		groupBox1.Controls.Add(ckbCapNhatThongTin);
		groupBox1.Controls.Add(panel2);
		groupBox1.Controls.Add(B2148C09);
		groupBox1.Controls.Add(ckbCheckLiveUid);
		groupBox1.Controls.Add(ckbAllowFollow);
		groupBox1.Controls.Add(ckbCongKhaiThongTin);
		groupBox1.Controls.Add(DA11EA8D);
		groupBox1.Controls.Add(E727AA0C);
		groupBox1.Controls.Add(CB8FB23D);
		groupBox1.Controls.Add(label2);
		groupBox1.Controls.Add(ckbRandomThuTuTaiKhoan);
		groupBox1.Controls.Add(ckbRepeatAll);
		groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75f);
		groupBox1.Location = new System.Drawing.Point(11, 43);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(420, 374);
		groupBox1.TabIndex = 8;
		groupBox1.TabStop = false;
		groupBox1.Text = "Tùy chọn";
		plCapNhatThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plCapNhatThongTin.Controls.Add(ECA93290);
		plCapNhatThongTin.Controls.Add(ckbEmail);
		plCapNhatThongTin.Controls.Add(ckbNgayTao);
		plCapNhatThongTin.Controls.Add(DC0B552B);
		plCapNhatThongTin.Controls.Add(F6285615);
		plCapNhatThongTin.Controls.Add(CB0C4392);
		plCapNhatThongTin.Controls.Add(C8ADFC2E);
		plCapNhatThongTin.Controls.Add(ckbFriend);
		plCapNhatThongTin.Controls.Add(ckbName);
		plCapNhatThongTin.Location = new System.Drawing.Point(39, 174);
		plCapNhatThongTin.Name = "plCapNhatThongTin";
		plCapNhatThongTin.Size = new System.Drawing.Size(376, 52);
		plCapNhatThongTin.TabIndex = 15;
		ECA93290.AutoSize = true;
		ECA93290.Cursor = System.Windows.Forms.Cursors.Hand;
		ECA93290.Location = new System.Drawing.Point(183, 28);
		ECA93290.Name = "ckbPhone";
		ECA93290.Size = new System.Drawing.Size(61, 20);
		ECA93290.TabIndex = 0;
		ECA93290.Text = "Phone";
		ECA93290.UseVisualStyleBackColor = true;
		ckbEmail.AutoSize = true;
		ckbEmail.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbEmail.Location = new System.Drawing.Point(183, 2);
		ckbEmail.Name = "ckbEmail";
		ckbEmail.Size = new System.Drawing.Size(57, 20);
		ckbEmail.TabIndex = 0;
		ckbEmail.Text = "Email";
		ckbEmail.UseVisualStyleBackColor = true;
		ckbNgayTao.AutoSize = true;
		ckbNgayTao.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbNgayTao.Location = new System.Drawing.Point(89, 28);
		ckbNgayTao.Name = "ckbNgayTao";
		ckbNgayTao.Size = new System.Drawing.Size(76, 20);
		ckbNgayTao.TabIndex = 0;
		ckbNgayTao.Text = "Ngày tạo";
		ckbNgayTao.UseVisualStyleBackColor = true;
		DC0B552B.AutoSize = true;
		DC0B552B.Location = new System.Drawing.Point(319, 27);
		DC0B552B.Name = "ckbFollow";
		DC0B552B.Size = new System.Drawing.Size(91, 20);
		DC0B552B.TabIndex = 0;
		DC0B552B.Text = "Follow (ẩn)";
		DC0B552B.UseVisualStyleBackColor = true;
		DC0B552B.Visible = false;
		F6285615.AutoSize = true;
		F6285615.Cursor = System.Windows.Forms.Cursors.Hand;
		F6285615.Location = new System.Drawing.Point(89, 2);
		F6285615.Name = "ckbBirthday";
		F6285615.Size = new System.Drawing.Size(81, 20);
		F6285615.TabIndex = 0;
		F6285615.Text = "Ngày sinh";
		F6285615.UseVisualStyleBackColor = true;
		CB0C4392.AutoSize = true;
		CB0C4392.Cursor = System.Windows.Forms.Cursors.Hand;
		CB0C4392.Location = new System.Drawing.Point(253, 2);
		CB0C4392.Name = "ckbGroup";
		CB0C4392.Size = new System.Drawing.Size(60, 20);
		CB0C4392.TabIndex = 0;
		CB0C4392.Text = "Group";
		CB0C4392.UseVisualStyleBackColor = true;
		C8ADFC2E.AutoSize = true;
		C8ADFC2E.Cursor = System.Windows.Forms.Cursors.Hand;
		C8ADFC2E.Location = new System.Drawing.Point(4, 2);
		C8ADFC2E.Name = "ckbGender";
		C8ADFC2E.Size = new System.Drawing.Size(72, 20);
		C8ADFC2E.TabIndex = 0;
		C8ADFC2E.Text = "Giới tính";
		C8ADFC2E.UseVisualStyleBackColor = true;
		ckbFriend.AutoSize = true;
		ckbFriend.Location = new System.Drawing.Point(319, 3);
		ckbFriend.Name = "ckbFriend";
		ckbFriend.Size = new System.Drawing.Size(90, 20);
		ckbFriend.TabIndex = 0;
		ckbFriend.Text = "Friend (ẩn)";
		ckbFriend.UseVisualStyleBackColor = true;
		ckbFriend.Visible = false;
		ckbName.AutoSize = true;
		ckbName.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbName.Location = new System.Drawing.Point(4, 28);
		ckbName.Name = "ckbName";
		ckbName.Size = new System.Drawing.Size(59, 20);
		ckbName.TabIndex = 0;
		ckbName.Text = "Name";
		ckbName.UseVisualStyleBackColor = true;
		ckbCapNhatThongTin.AutoSize = true;
		ckbCapNhatThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCapNhatThongTin.Location = new System.Drawing.Point(19, 151);
		ckbCapNhatThongTin.Name = "ckbCapNhatThongTin";
		ckbCapNhatThongTin.Size = new System.Drawing.Size(181, 20);
		ckbCapNhatThongTin.TabIndex = 14;
		ckbCapNhatThongTin.Text = "Tự động cập nhật thông tin";
		ckbCapNhatThongTin.UseVisualStyleBackColor = true;
		ckbCapNhatThongTin.CheckedChanged += new System.EventHandler(ckbCapNhatThongTin_CheckedChanged);
		panel2.Controls.Add(rbLoginEmailPass);
		panel2.Controls.Add(rbLoginUidPass);
		panel2.Location = new System.Drawing.Point(115, 21);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(292, 26);
		panel2.TabIndex = 6;
		rbLoginEmailPass.AutoSize = true;
		rbLoginEmailPass.Cursor = System.Windows.Forms.Cursors.Hand;
		rbLoginEmailPass.Location = new System.Drawing.Point(93, 3);
		rbLoginEmailPass.Name = "rbLoginEmailPass";
		rbLoginEmailPass.Size = new System.Drawing.Size(88, 20);
		rbLoginEmailPass.TabIndex = 4;
		rbLoginEmailPass.Text = "Email|Pass";
		rbLoginEmailPass.UseVisualStyleBackColor = true;
		rbLoginUidPass.AutoSize = true;
		rbLoginUidPass.Checked = true;
		rbLoginUidPass.Cursor = System.Windows.Forms.Cursors.Hand;
		rbLoginUidPass.Location = new System.Drawing.Point(3, 3);
		rbLoginUidPass.Name = "rbLoginUidPass";
		rbLoginUidPass.Size = new System.Drawing.Size(75, 20);
		rbLoginUidPass.TabIndex = 4;
		rbLoginUidPass.TabStop = true;
		rbLoginUidPass.Text = "Uid|Pass";
		rbLoginUidPass.UseVisualStyleBackColor = true;
		B2148C09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B2148C09.Controls.Add(label6);
		B2148C09.Controls.Add(label4);
		B2148C09.Controls.Add(nudDelayTurnFrom);
		B2148C09.Controls.Add(F421EB3F);
		B2148C09.Controls.Add(F984A196);
		B2148C09.Controls.Add(F2A8A7BB);
		B2148C09.Controls.Add(F3A1A987);
		B2148C09.Controls.Add(label10);
		B2148C09.Location = new System.Drawing.Point(39, 279);
		B2148C09.Name = "plRepeatAll";
		B2148C09.Size = new System.Drawing.Size(376, 64);
		B2148C09.TabIndex = 13;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(3, 7);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(83, 16);
		label6.TabIndex = 5;
		label6.Text = "Sô\u0301 lươ\u0323t cha\u0323y:";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(3, 36);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(144, 16);
		label4.TabIndex = 6;
		label4.Text = "Chờ cha\u0323y lươ\u0323t tiê\u0301p theo:";
		nudDelayTurnFrom.Location = new System.Drawing.Point(154, 34);
		nudDelayTurnFrom.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		nudDelayTurnFrom.Name = "nudDelayTurnFrom";
		nudDelayTurnFrom.Size = new System.Drawing.Size(65, 23);
		nudDelayTurnFrom.TabIndex = 9;
		F421EB3F.AutoSize = true;
		F421EB3F.Location = new System.Drawing.Point(222, 8);
		F421EB3F.Name = "label5";
		F421EB3F.Size = new System.Drawing.Size(29, 16);
		F421EB3F.TabIndex = 10;
		F421EB3F.Text = "lươ\u0323t";
		F421EB3F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F984A196.Location = new System.Drawing.Point(252, 34);
		F984A196.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		F984A196.Name = "nudDelayTurnTo";
		F984A196.Size = new System.Drawing.Size(65, 23);
		F984A196.TabIndex = 8;
		F2A8A7BB.AutoSize = true;
		F2A8A7BB.Location = new System.Drawing.Point(320, 37);
		F2A8A7BB.Name = "label11";
		F2A8A7BB.Size = new System.Drawing.Size(32, 16);
		F2A8A7BB.TabIndex = 11;
		F2A8A7BB.Text = "phút";
		F3A1A987.Location = new System.Drawing.Point(154, 5);
		F3A1A987.Maximum = new decimal(new int[4] { 276447231, 23283, 0, 0 });
		F3A1A987.Name = "nudSoLuotChay";
		F3A1A987.Size = new System.Drawing.Size(65, 23);
		F3A1A987.TabIndex = 7;
		label10.Location = new System.Drawing.Point(222, 37);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(29, 16);
		label10.TabIndex = 12;
		label10.Text = "đến";
		label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ckbCheckLiveUid.AutoSize = true;
		ckbCheckLiveUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCheckLiveUid.Location = new System.Drawing.Point(19, 51);
		ckbCheckLiveUid.Name = "ckbCheckLiveUid";
		ckbCheckLiveUid.Size = new System.Drawing.Size(192, 20);
		ckbCheckLiveUid.TabIndex = 2;
		ckbCheckLiveUid.Text = "Check Live Uid trước khi chạy";
		ckbCheckLiveUid.UseVisualStyleBackColor = true;
		ckbAllowFollow.AutoSize = true;
		ckbAllowFollow.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAllowFollow.Location = new System.Drawing.Point(292, 348);
		ckbAllowFollow.Name = "ckbAllowFollow";
		ckbAllowFollow.Size = new System.Drawing.Size(130, 20);
		ckbAllowFollow.TabIndex = 2;
		ckbAllowFollow.Text = "Cho phép theo dõi";
		ckbAllowFollow.UseVisualStyleBackColor = true;
		ckbCongKhaiThongTin.AutoSize = true;
		ckbCongKhaiThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCongKhaiThongTin.Location = new System.Drawing.Point(19, 348);
		ckbCongKhaiThongTin.Name = "ckbCongKhaiThongTin";
		ckbCongKhaiThongTin.Size = new System.Drawing.Size(192, 20);
		ckbCongKhaiThongTin.TabIndex = 2;
		ckbCongKhaiThongTin.Text = "Công khai thông tin tài khoản";
		ckbCongKhaiThongTin.UseVisualStyleBackColor = true;
		DA11EA8D.AutoSize = true;
		DA11EA8D.Cursor = System.Windows.Forms.Cursors.Hand;
		DA11EA8D.Location = new System.Drawing.Point(19, 126);
		DA11EA8D.Name = "ckbCheckGoiYKetBan";
		DA11EA8D.Size = new System.Drawing.Size(138, 20);
		DA11EA8D.TabIndex = 2;
		DA11EA8D.Text = "Check Gợi ý kết bạn";
		DA11EA8D.UseVisualStyleBackColor = true;
		E727AA0C.AutoSize = true;
		E727AA0C.Cursor = System.Windows.Forms.Cursors.Hand;
		E727AA0C.Location = new System.Drawing.Point(19, 101);
		E727AA0C.Name = "ckbGetCookie";
		E727AA0C.Size = new System.Drawing.Size(136, 20);
		E727AA0C.TabIndex = 2;
		E727AA0C.Text = "Tự động lấy Cookie";
		E727AA0C.UseVisualStyleBackColor = true;
		ckbRandomThuTuTaiKhoan.AutoSize = true;
		ckbRandomThuTuTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbRandomThuTuTaiKhoan.Location = new System.Drawing.Point(19, 232);
		ckbRandomThuTuTaiKhoan.Name = "ckbRandomThuTuTaiKhoan";
		ckbRandomThuTuTaiKhoan.Size = new System.Drawing.Size(254, 20);
		ckbRandomThuTuTaiKhoan.TabIndex = 2;
		ckbRandomThuTuTaiKhoan.Text = "Xáo trộn thứ tự tài khoản trước khi chạy";
		ckbRandomThuTuTaiKhoan.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(443, 625);
		base.Controls.Add(DD02DC17);
		base.Controls.Add(AAAA7103);
		base.Controls.Add(AE11250B);
		base.Controls.Add(panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhTuongTac";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhTuongTac_Load);
		AE11250B.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)DE9D64A7).EndInit();
		DDAACE03.ResumeLayout(false);
		DDAACE03.PerformLayout();
		F39EAC19.ResumeLayout(false);
		F39EAC19.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudThoiGianChayKichBanTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudThoiGianChayKichBanFrom).EndInit();
		D1258395.ResumeLayout(false);
		D1258395.PerformLayout();
		((System.ComponentModel.ISupportInitialize)AF28040D).EndInit();
		((System.ComponentModel.ISupportInitialize)nudThoiGianChayTaiKhoanFrom).EndInit();
		panel1.ResumeLayout(false);
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		plCapNhatThongTin.ResumeLayout(false);
		plCapNhatThongTin.PerformLayout();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		B2148C09.ResumeLayout(false);
		B2148C09.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTurnFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)F984A196).EndInit();
		((System.ComponentModel.ISupportInitialize)F3A1A987).EndInit();
		ResumeLayout(false);
	}
}
