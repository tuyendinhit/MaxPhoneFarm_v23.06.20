using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhRegClone : Form
{
	internal static bool AB99B71B;

	internal IContainer C609C619 = null;

	internal BunifuCards AF182FB9;

	internal Panel E3271710;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Button btnCancel;

	internal Button E58BA82C;

	internal BunifuDragControl B9AC640C;

	internal PictureBox pictureBox1;

	internal Label label1;

	internal Label B223BBA9;

	internal TextBox txtSoDienThoai;

	internal Label label3;

	internal TextBox FD228F01;

	internal Button btnHo;

	internal ComboBox cbbGioiTinh;

	internal Button BD84DCA9;

	internal Label label4;

	internal Button btnTenDem;

	internal Label label5;

	internal TextBox txtOutputFolder;

	internal ComboBox AE061A2D;

	internal Panel plHoTen;

	internal Label DD3A43AD;

	internal ComboBox cbbChangeIP;

	internal Panel ED8B543C;

	internal RichTextBox AB0ED82E;

	internal Label lblProxy;

	internal Label label7;

	internal NumericUpDown C12B3215;

	public fCauHinhRegClone()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		AB99B71B = false;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E58BA82C_Click(object sender, EventArgs e)
	{
		SettingsTool.GetSettings("configRegClone").GetValue("cbbHoTen", AE061A2D.SelectedIndex);
		SettingsTool.GetSettings("configRegClone").GetValue("cbbGioiTinh", cbbGioiTinh.SelectedValue);
		SettingsTool.GetSettings("configRegClone").GetValue("cbbChangeIP", cbbChangeIP.SelectedValue);
        SettingsTool.GetSettings("configRegClone").GetValue("txtProxy", (object)AB0ED82E.Text);
        SettingsTool.GetSettings("configRegClone").GetValue("txtMatKhau", (object)FD228F01.Text);
        SettingsTool.GetSettings("configRegClone").GetValue("txtSoDienThoai", (object)txtSoDienThoai.Text);
		string text = txtOutputFolder.Text.Trim();
        SettingsTool.GetSettings("configRegClone").GetValue("txtOutputFolder", (object)text);
		SettingsTool.GetSettings("configRegClone").GetValue("nudTimeout", C12B3215.Value);
		SettingsTool.smethod_0("configRegClone");
		Common.CreateFolder(text);
		AB99B71B = true;
		Close();
	}

	private void D4244307(object sender, EventArgs e)
	{
		Close();
	}

	private void EB948933(object sender, EventArgs e)
	{
		method_0();
		method_1();
		method_2();
		cbbGioiTinh.SelectedValue = SettingsTool.GetSettings("configRegClone").GetValue("cbbGioiTinh");
		AE061A2D.SelectedValue = SettingsTool.GetSettings("configRegClone").GetValue("cbbHoTen", "0");
		cbbChangeIP.SelectedValue = SettingsTool.GetSettings("configRegClone").GetValue("cbbChangeIP", "0");
		AB0ED82E.Text = SettingsTool.GetSettings("configRegClone").GetValue("txtProxy");
		FD228F01.Text = SettingsTool.GetSettings("configRegClone").GetValue("txtMatKhau", "Min@*********");
		txtSoDienThoai.Text = SettingsTool.GetSettings("configRegClone").GetValue("txtSoDienThoai", "+84{94|82}*******");
		txtOutputFolder.Text = SettingsTool.GetSettings("configRegClone").GetValue("txtOutputFolder", FileHelper.GetPathToCurrentFolder() + "\\regclone");
		C12B3215.Value = SettingsTool.GetSettings("configRegClone").method_0("nudTimeout", 180);
		AE061A2D_SelectedIndexChanged(null, null);
		A5077E2A(null, null);
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("", "Random");
		dictionary.Add("Female", "Nữ");
		dictionary.Add("Male", "Nam");
		cbbGioiTinh.DataSource = new BindingSource(dictionary, null);
		cbbGioiTinh.DisplayMember = "Value";
		cbbGioiTinh.ValueMember = "Key";
	}

	private void method_1()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Random tên việt");
		dictionary.Add("1", "Random tên ngoại");
		dictionary.Add("2", "Người dùng nhập");
		AE061A2D.DataSource = new BindingSource(dictionary, null);
		AE061A2D.DisplayMember = "Value";
		AE061A2D.ValueMember = "Key";
	}

	private void method_2()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Không đổi IP");
		dictionary.Add("1", "4G Mobile");
		dictionary.Add("2", "Random proxy");
		cbbChangeIP.DataSource = new BindingSource(dictionary, null);
		cbbChangeIP.DisplayMember = "Value";
		cbbChangeIP.ValueMember = "Key";
	}

	private void btnHo_Click(object sender, EventArgs e)
	{
		DCBB79A8("settings\\ho.txt");
	}

	private void DCBB79A8(string B41E1E28)
	{
		try
		{
			if (!File.Exists(B41E1E28))
			{
				File.AppendAllText(B41E1E28, "");
			}
			Process.Start(B41E1E28);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	private void btnTenDem_Click(object sender, EventArgs e)
	{
		DCBB79A8("settings\\tendem.txt");
	}

	private void BD84DCA9_Click(object sender, EventArgs e)
	{
		DCBB79A8("settings\\ten.txt");
	}

	private void AE061A2D_SelectedIndexChanged(object sender, EventArgs e)
	{
		plHoTen.Enabled = AE061A2D.SelectedIndex == AE061A2D.Items.Count - 1;
	}

	private void A5077E2A(object sender, EventArgs e)
	{
		ED8B543C.Enabled = cbbChangeIP.SelectedIndex == cbbChangeIP.Items.Count - 1;
	}

	private void AB0ED82E_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(AB0ED82E, lblProxy);
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && C609C619 != null)
		{
			C609C619.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		C609C619 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhRegClone));
		AF182FB9 = new Bunifu.Framework.UI.BunifuCards();
		E3271710 = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		E58BA82C = new System.Windows.Forms.Button();
		B9AC640C = new Bunifu.Framework.UI.BunifuDragControl(C609C619);
		label1 = new System.Windows.Forms.Label();
		B223BBA9 = new System.Windows.Forms.Label();
		txtSoDienThoai = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		FD228F01 = new System.Windows.Forms.TextBox();
		btnHo = new System.Windows.Forms.Button();
		cbbGioiTinh = new System.Windows.Forms.ComboBox();
		BD84DCA9 = new System.Windows.Forms.Button();
		label4 = new System.Windows.Forms.Label();
		btnTenDem = new System.Windows.Forms.Button();
		label5 = new System.Windows.Forms.Label();
		txtOutputFolder = new System.Windows.Forms.TextBox();
		AE061A2D = new System.Windows.Forms.ComboBox();
		plHoTen = new System.Windows.Forms.Panel();
		DD3A43AD = new System.Windows.Forms.Label();
		cbbChangeIP = new System.Windows.Forms.ComboBox();
		ED8B543C = new System.Windows.Forms.Panel();
		lblProxy = new System.Windows.Forms.Label();
		AB0ED82E = new System.Windows.Forms.RichTextBox();
		label7 = new System.Windows.Forms.Label();
		C12B3215 = new System.Windows.Forms.NumericUpDown();
		AF182FB9.SuspendLayout();
		E3271710.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		plHoTen.SuspendLayout();
		ED8B543C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C12B3215).BeginInit();
		SuspendLayout();
		AF182FB9.BackColor = System.Drawing.Color.White;
		AF182FB9.BorderRadius = 0;
		AF182FB9.BottomSahddow = true;
		AF182FB9.color = System.Drawing.Color.SaddleBrown;
		AF182FB9.Controls.Add(E3271710);
		AF182FB9.Dock = System.Windows.Forms.DockStyle.Top;
		AF182FB9.LeftSahddow = false;
		AF182FB9.Location = new System.Drawing.Point(0, 0);
		AF182FB9.Name = "bunifuCards1";
		AF182FB9.RightSahddow = true;
		AF182FB9.ShadowDepth = 20;
		AF182FB9.Size = new System.Drawing.Size(400, 38);
		AF182FB9.TabIndex = 0;
		E3271710.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E3271710.BackColor = System.Drawing.Color.White;
		E3271710.Controls.Add(pictureBox1);
		E3271710.Controls.Add(btnMinimize);
		E3271710.Controls.Add(bunifuCustomLabel1);
		E3271710.Location = new System.Drawing.Point(0, 5);
		E3271710.Name = "pnlHeader";
		E3271710.Size = new System.Drawing.Size(400, 32);
		E3271710.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(368, 0);
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(400, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh Reg clone";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(208, 414);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(D4244307);
		E58BA82C.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E58BA82C.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		E58BA82C.Cursor = System.Windows.Forms.Cursors.Hand;
		E58BA82C.FlatAppearance.BorderSize = 0;
		E58BA82C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E58BA82C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E58BA82C.ForeColor = System.Drawing.Color.White;
		E58BA82C.Location = new System.Drawing.Point(104, 414);
		E58BA82C.Name = "btnAdd";
		E58BA82C.Size = new System.Drawing.Size(92, 29);
		E58BA82C.TabIndex = 3;
		E58BA82C.Text = "Lưu";
		E58BA82C.UseVisualStyleBackColor = false;
		E58BA82C.Click += new System.EventHandler(E58BA82C_Click);
		B9AC640C.Fixed = true;
		B9AC640C.Horizontal = true;
		B9AC640C.TargetControl = bunifuCustomLabel1;
		B9AC640C.Vertical = true;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(35, 71);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(49, 16);
		label1.TabIndex = 10;
		label1.Text = "Họ tên:";
		B223BBA9.AutoSize = true;
		B223BBA9.Location = new System.Drawing.Point(35, 134);
		B223BBA9.Name = "label2";
		B223BBA9.Size = new System.Drawing.Size(58, 16);
		B223BBA9.TabIndex = 14;
		B223BBA9.Text = "Giới tính:";
		txtSoDienThoai.Location = new System.Drawing.Point(128, 190);
		txtSoDienThoai.Name = "txtSoDienThoai";
		txtSoDienThoai.Size = new System.Drawing.Size(234, 23);
		txtSoDienThoai.TabIndex = 29;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(35, 164);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(64, 16);
		label3.TabIndex = 18;
		label3.Text = "Mật khẩu:";
		FD228F01.Location = new System.Drawing.Point(128, 161);
		FD228F01.Name = "txtMatKhau";
		FD228F01.Size = new System.Drawing.Size(234, 23);
		FD228F01.TabIndex = 26;
		btnHo.Cursor = System.Windows.Forms.Cursors.Hand;
		btnHo.Location = new System.Drawing.Point(0, 1);
		btnHo.Name = "btnHo";
		btnHo.Size = new System.Drawing.Size(74, 29);
		btnHo.TabIndex = 23;
		btnHo.Text = "Họ";
		btnHo.UseVisualStyleBackColor = true;
		btnHo.Click += new System.EventHandler(btnHo_Click);
		cbbGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbGioiTinh.FormattingEnabled = true;
		cbbGioiTinh.Location = new System.Drawing.Point(128, 131);
		cbbGioiTinh.Name = "cbbGioiTinh";
		cbbGioiTinh.Size = new System.Drawing.Size(234, 24);
		cbbGioiTinh.TabIndex = 25;
		BD84DCA9.Cursor = System.Windows.Forms.Cursors.Hand;
		BD84DCA9.Location = new System.Drawing.Point(160, 1);
		BD84DCA9.Name = "btnTen";
		BD84DCA9.Size = new System.Drawing.Size(74, 29);
		BD84DCA9.TabIndex = 21;
		BD84DCA9.Text = "Tên";
		BD84DCA9.UseVisualStyleBackColor = true;
		BD84DCA9.Click += new System.EventHandler(BD84DCA9_Click);
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(35, 193);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(87, 16);
		label4.TabIndex = 16;
		label4.Text = "Số điện thoại:";
		btnTenDem.Cursor = System.Windows.Forms.Cursors.Hand;
		btnTenDem.Location = new System.Drawing.Point(80, 1);
		btnTenDem.Name = "btnTenDem";
		btnTenDem.Size = new System.Drawing.Size(74, 29);
		btnTenDem.TabIndex = 24;
		btnTenDem.Text = "Tên đệm";
		btnTenDem.UseVisualStyleBackColor = true;
		btnTenDem.Click += new System.EventHandler(btnTenDem_Click);
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(35, 222);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(70, 16);
		label5.TabIndex = 16;
		label5.Text = "Folder lưu:";
		txtOutputFolder.Location = new System.Drawing.Point(128, 219);
		txtOutputFolder.Name = "txtOutputFolder";
		txtOutputFolder.Size = new System.Drawing.Size(234, 23);
		txtOutputFolder.TabIndex = 29;
		AE061A2D.Cursor = System.Windows.Forms.Cursors.Hand;
		AE061A2D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		AE061A2D.FormattingEnabled = true;
		AE061A2D.Location = new System.Drawing.Point(128, 68);
		AE061A2D.Name = "cbbHoTen";
		AE061A2D.Size = new System.Drawing.Size(234, 24);
		AE061A2D.TabIndex = 25;
		AE061A2D.SelectedIndexChanged += new System.EventHandler(AE061A2D_SelectedIndexChanged);
		plHoTen.Controls.Add(btnHo);
		plHoTen.Controls.Add(btnTenDem);
		plHoTen.Controls.Add(BD84DCA9);
		plHoTen.Location = new System.Drawing.Point(128, 95);
		plHoTen.Name = "plHoTen";
		plHoTen.Size = new System.Drawing.Size(234, 31);
		plHoTen.TabIndex = 30;
		DD3A43AD.AutoSize = true;
		DD3A43AD.Location = new System.Drawing.Point(35, 251);
		DD3A43AD.Name = "label6";
		DD3A43AD.Size = new System.Drawing.Size(46, 16);
		DD3A43AD.TabIndex = 16;
		DD3A43AD.Text = "Đổi IP:";
		cbbChangeIP.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbChangeIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbChangeIP.FormattingEnabled = true;
		cbbChangeIP.Location = new System.Drawing.Point(128, 248);
		cbbChangeIP.Name = "cbbChangeIP";
		cbbChangeIP.Size = new System.Drawing.Size(234, 24);
		cbbChangeIP.TabIndex = 25;
		cbbChangeIP.SelectedIndexChanged += new System.EventHandler(A5077E2A);
		ED8B543C.Controls.Add(AB0ED82E);
		ED8B543C.Controls.Add(lblProxy);
		ED8B543C.Location = new System.Drawing.Point(122, 272);
		ED8B543C.Name = "plChangeIP";
		ED8B543C.Size = new System.Drawing.Size(245, 102);
		ED8B543C.TabIndex = 31;
		lblProxy.AutoSize = true;
		lblProxy.Location = new System.Drawing.Point(2, 4);
		lblProxy.Name = "lblProxy";
		lblProxy.Size = new System.Drawing.Size(64, 16);
		lblProxy.TabIndex = 0;
		lblProxy.Text = "Proxy (0):";
		AB0ED82E.Location = new System.Drawing.Point(5, 24);
		AB0ED82E.Name = "txtProxy";
		AB0ED82E.Size = new System.Drawing.Size(235, 75);
		AB0ED82E.TabIndex = 1;
		AB0ED82E.Text = "";
		AB0ED82E.WordWrap = false;
		AB0ED82E.TextChanged += new System.EventHandler(AB0ED82E_TextChanged);
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(35, 380);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(79, 16);
		label7.TabIndex = 14;
		label7.Text = "Timeout (s):";
		C12B3215.Location = new System.Drawing.Point(127, 378);
		C12B3215.Maximum = new decimal(new int[4] { 99999999, 0, 0, 0 });
		C12B3215.Name = "nudTimeout";
		C12B3215.Size = new System.Drawing.Size(103, 23);
		C12B3215.TabIndex = 32;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(400, 456);
		base.Controls.Add(C12B3215);
		base.Controls.Add(ED8B543C);
		base.Controls.Add(plHoTen);
		base.Controls.Add(label1);
		base.Controls.Add(label7);
		base.Controls.Add(B223BBA9);
		base.Controls.Add(txtOutputFolder);
		base.Controls.Add(txtSoDienThoai);
		base.Controls.Add(label3);
		base.Controls.Add(FD228F01);
		base.Controls.Add(cbbChangeIP);
		base.Controls.Add(AE061A2D);
		base.Controls.Add(cbbGioiTinh);
		base.Controls.Add(DD3A43AD);
		base.Controls.Add(label5);
		base.Controls.Add(label4);
		base.Controls.Add(btnCancel);
		base.Controls.Add(E58BA82C);
		base.Controls.Add(AF182FB9);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhRegClone";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(EB948933);
		AF182FB9.ResumeLayout(false);
		E3271710.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		plHoTen.ResumeLayout(false);
		ED8B543C.ResumeLayout(false);
		ED8B543C.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C12B3215).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
