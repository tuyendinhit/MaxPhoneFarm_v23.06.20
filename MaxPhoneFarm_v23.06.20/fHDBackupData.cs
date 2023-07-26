using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDBackupData : Form
{
	internal JSON_Settings B5BD1D98;

	internal string FA03E122;

	internal string E93475A1;

	internal string string_0;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl D320BBB8;

	internal Panel EB2922AE;

	internal TextBox txtTenHanhDong;

	internal Label label1;

	internal Button B0316409;

	internal Button btnAdd;

	internal BunifuCards D7224109;

	internal Panel A7AF3783;

	internal Button button1;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel plAnh;

	internal CheckBox E535DE26;

	internal CheckBox ckbNgaySinh;

	internal CheckBox D18EDA03;

	internal NumericUpDown DE2076B6;

	internal Label label10;

	internal Label A4209010;

	internal Label label3;

	internal CheckBox ckbBinhLuan;

	internal GroupBox A39C433A;

	internal CheckBox ckbCreateHTML;

	internal Panel plComment;

	internal NumericUpDown nudSoThang;

	internal Label D4B6982F;

	internal Label label4;

	internal Label label5;

	internal CheckBox BE1BAA39;

	internal Button button2;

	public fHDBackupData(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		FA03E122 = string_1;
		string_0 = string_2;
		int_0 = int_1;
		if (Class123.C7BE863B("", "HDBackupData").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDBackupData', '{  \"ckbNgaySinh\": \"True\",  \"ckbAnhBanBe\": \"True\",  \"nudSoLuongAnh\": \"20\",  \"ckbNhanTin\": \"True\",  \"ckbBinhLuan\": \"True\",  \"ckbCreateHTML\": \"True\"}', 'Backup dữ liệu');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDBackupData");
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			E93475A1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		B5BD1D98 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDBackupData_Load(object sender, EventArgs e)
	{
		try
		{
			ckbNgaySinh.Checked = B5BD1D98.AA824D29("ckbNgaySinh", A72188BC: true);
			E535DE26.Checked = B5BD1D98.AA824D29("ckbAnhBanBe", A72188BC: true);
			BE1BAA39.Checked = B5BD1D98.AA824D29("ckbBackupImageNangCao");
			DE2076B6.Value = B5BD1D98.method_0("nudSoLuongAnh", 20);
			nudSoThang.Value = B5BD1D98.method_0("nudSoThang", 5);
			D18EDA03.Checked = B5BD1D98.AA824D29("ckbNhanTin", A72188BC: true);
			ckbBinhLuan.Checked = B5BD1D98.AA824D29("ckbBinhLuan", A72188BC: true);
			ckbCreateHTML.Checked = B5BD1D98.AA824D29("ckbCreateHTML", A72188BC: true);
		}
		catch
		{
		}
		A31322AA();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F381F790(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		if (!ckbNgaySinh.Checked && !E535DE26.Checked && !D18EDA03.Checked && !ckbBinhLuan.Checked)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng chọn cấu hình backup!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("ckbNgaySinh", ckbNgaySinh.Checked);
		f72FAFBC.GetValue("ckbAnhBanBe", E535DE26.Checked);
		f72FAFBC.GetValue("ckbBackupImageNangCao", BE1BAA39.Checked);
		f72FAFBC.GetValue("nudSoLuongAnh", DE2076B6.Value);
		f72FAFBC.GetValue("ckbNhanTin", D18EDA03.Checked);
		f72FAFBC.GetValue("ckbBinhLuan", ckbBinhLuan.Checked);
		f72FAFBC.GetValue("nudSoThang", nudSoThang.Value);
		f72FAFBC.GetValue("ckbCreateHTML", ckbCreateHTML.Checked);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(FA03E122, text, E93475A1, text2))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (Class123.smethod_14(string_0, text, text2))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void A596158D(object sender, EventArgs e)
	{
		Close();
	}

	private void B59A6A20(object sender, PaintEventArgs e)
	{
		if (EB2922AE.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, EB2922AE.ClientSize.Width - num, EB2922AE.ClientSize.Height - num));
		}
	}

	private void A31322AA()
	{
		method_0(null, null);
		E535DE26_CheckedChanged(null, null);
		ckbBinhLuan_CheckedChanged(null, null);
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void E535DE26_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = E535DE26.Checked;
	}

	private void ckbBinhLuan_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbBinhLuan.Checked;
	}

	private void BC89F41A(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Nếu tích tùy chọn này thì sẽ backup được nhiều ảnh bạn bè hơn.") + "\r\n" + Language.GetValue("Đồng nghĩa với việc tốc độ backup sẽ chậm hơn!"));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBackupData));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D320BBB8 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		A7AF3783 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		EB2922AE = new System.Windows.Forms.Panel();
		A39C433A = new System.Windows.Forms.GroupBox();
		ckbNgaySinh = new System.Windows.Forms.CheckBox();
		D18EDA03 = new System.Windows.Forms.CheckBox();
		plComment = new System.Windows.Forms.Panel();
		nudSoThang = new System.Windows.Forms.NumericUpDown();
		D4B6982F = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		plAnh = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		BE1BAA39 = new System.Windows.Forms.CheckBox();
		DE2076B6 = new System.Windows.Forms.NumericUpDown();
		label10 = new System.Windows.Forms.Label();
		A4209010 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		ckbBinhLuan = new System.Windows.Forms.CheckBox();
		E535DE26 = new System.Windows.Forms.CheckBox();
		ckbCreateHTML = new System.Windows.Forms.CheckBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		B0316409 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		D7224109 = new Bunifu.Framework.UI.BunifuCards();
		A7AF3783.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		EB2922AE.SuspendLayout();
		A39C433A.SuspendLayout();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoThang).BeginInit();
		plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DE2076B6).BeginInit();
		D7224109.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Backup dữ liệu";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D320BBB8.Fixed = true;
		D320BBB8.Horizontal = true;
		D320BBB8.TargetControl = A7AF3783;
		D320BBB8.Vertical = true;
		A7AF3783.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A7AF3783.BackColor = System.Drawing.Color.White;
		A7AF3783.Controls.Add(button1);
		A7AF3783.Controls.Add(pictureBox1);
		A7AF3783.Controls.Add(bunifuCustomLabel1);
		A7AF3783.Cursor = System.Windows.Forms.Cursors.SizeAll;
		A7AF3783.Location = new System.Drawing.Point(0, 3);
		A7AF3783.Name = "pnlHeader";
		A7AF3783.Size = new System.Drawing.Size(359, 31);
		A7AF3783.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(328, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 0;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		EB2922AE.BackColor = System.Drawing.Color.White;
		EB2922AE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EB2922AE.Controls.Add(A39C433A);
		EB2922AE.Controls.Add(ckbCreateHTML);
		EB2922AE.Controls.Add(txtTenHanhDong);
		EB2922AE.Controls.Add(label1);
		EB2922AE.Controls.Add(B0316409);
		EB2922AE.Controls.Add(btnAdd);
		EB2922AE.Controls.Add(D7224109);
		EB2922AE.Cursor = System.Windows.Forms.Cursors.Arrow;
		EB2922AE.Dock = System.Windows.Forms.DockStyle.Fill;
		EB2922AE.Location = new System.Drawing.Point(0, 0);
		EB2922AE.Name = "panel1";
		EB2922AE.Size = new System.Drawing.Size(362, 373);
		EB2922AE.TabIndex = 0;
		EB2922AE.Paint += new System.Windows.Forms.PaintEventHandler(B59A6A20);
		A39C433A.Controls.Add(ckbNgaySinh);
		A39C433A.Controls.Add(D18EDA03);
		A39C433A.Controls.Add(plComment);
		A39C433A.Controls.Add(plAnh);
		A39C433A.Controls.Add(ckbBinhLuan);
		A39C433A.Controls.Add(E535DE26);
		A39C433A.Location = new System.Drawing.Point(30, 82);
		A39C433A.Name = "groupBox1";
		A39C433A.Size = new System.Drawing.Size(295, 205);
		A39C433A.TabIndex = 1;
		A39C433A.TabStop = false;
		A39C433A.Text = "Cấu hình backup";
		ckbNgaySinh.AutoSize = true;
		ckbNgaySinh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbNgaySinh.Location = new System.Drawing.Point(12, 20);
		ckbNgaySinh.Name = "ckbNgaySinh";
		ckbNgaySinh.Size = new System.Drawing.Size(82, 20);
		ckbNgaySinh.TabIndex = 0;
		ckbNgaySinh.Text = "Ngày sinh";
		ckbNgaySinh.UseVisualStyleBackColor = true;
		D18EDA03.AutoSize = true;
		D18EDA03.Cursor = System.Windows.Forms.Cursors.Hand;
		D18EDA03.Location = new System.Drawing.Point(12, 122);
		D18EDA03.Name = "ckbNhanTin";
		D18EDA03.Size = new System.Drawing.Size(185, 20);
		D18EDA03.TabIndex = 2;
		D18EDA03.Text = "Danh sách nhắn tin gần đây";
		D18EDA03.UseVisualStyleBackColor = true;
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(nudSoThang);
		plComment.Controls.Add(D4B6982F);
		plComment.Controls.Add(label4);
		plComment.Controls.Add(label5);
		plComment.Location = new System.Drawing.Point(30, 169);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(221, 27);
		plComment.TabIndex = 8;
		nudSoThang.Location = new System.Drawing.Point(119, 1);
		nudSoThang.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudSoThang.Name = "nudSoThang";
		nudSoThang.Size = new System.Drawing.Size(52, 23);
		nudSoThang.TabIndex = 0;
		nudSoThang.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		D4B6982F.AutoSize = true;
		D4B6982F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D4B6982F.Location = new System.Drawing.Point(172, 3);
		D4B6982F.Name = "label2";
		D4B6982F.Size = new System.Drawing.Size(40, 16);
		D4B6982F.TabIndex = 151;
		D4B6982F.Text = "tháng";
		label4.AutoSize = true;
		label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label4.Location = new System.Drawing.Point(2, 3);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(100, 16);
		label4.TabIndex = 152;
		label4.Text = "Số lượng tháng:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(3, 0);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(0, 16);
		label5.TabIndex = 31;
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(button2);
		plAnh.Controls.Add(BE1BAA39);
		plAnh.Controls.Add(DE2076B6);
		plAnh.Controls.Add(label10);
		plAnh.Controls.Add(A4209010);
		plAnh.Controls.Add(label3);
		plAnh.Location = new System.Drawing.Point(30, 69);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(221, 50);
		plAnh.TabIndex = 8;
		button2.Cursor = System.Windows.Forms.Cursors.Help;
		button2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button2.Location = new System.Drawing.Point(154, 25);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(23, 23);
		button2.TabIndex = 153;
		button2.Text = "?";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(BC89F41A);
		BE1BAA39.AutoSize = true;
		BE1BAA39.Cursor = System.Windows.Forms.Cursors.Hand;
		BE1BAA39.Location = new System.Drawing.Point(5, 26);
		BE1BAA39.Name = "ckbBackupImageNangCao";
		BE1BAA39.Size = new System.Drawing.Size(148, 20);
		BE1BAA39.TabIndex = 0;
		BE1BAA39.Text = "Backup ảnh nâng cao";
		BE1BAA39.UseVisualStyleBackColor = true;
		DE2076B6.Location = new System.Drawing.Point(119, 1);
		DE2076B6.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		DE2076B6.Name = "nudSoLuongAnh";
		DE2076B6.Size = new System.Drawing.Size(52, 23);
		DE2076B6.TabIndex = 0;
		DE2076B6.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label10.AutoSize = true;
		label10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label10.Location = new System.Drawing.Point(173, 3);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(29, 16);
		label10.TabIndex = 151;
		label10.Text = "a\u0309nh";
		A4209010.AutoSize = true;
		A4209010.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A4209010.Location = new System.Drawing.Point(2, 3);
		A4209010.Name = "label7";
		A4209010.Size = new System.Drawing.Size(115, 16);
		A4209010.TabIndex = 152;
		A4209010.Text = "Số lươ\u0323ng a\u0309nh/ba\u0323n:";
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(3, 0);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(0, 16);
		label3.TabIndex = 31;
		ckbBinhLuan.AutoSize = true;
		ckbBinhLuan.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBinhLuan.Location = new System.Drawing.Point(12, 148);
		ckbBinhLuan.Name = "ckbBinhLuan";
		ckbBinhLuan.Size = new System.Drawing.Size(142, 20);
		ckbBinhLuan.TabIndex = 3;
		ckbBinhLuan.Text = "Danh sách bình luận";
		ckbBinhLuan.UseVisualStyleBackColor = true;
		ckbBinhLuan.CheckedChanged += new System.EventHandler(ckbBinhLuan_CheckedChanged);
		E535DE26.AutoSize = true;
		E535DE26.Cursor = System.Windows.Forms.Cursors.Hand;
		E535DE26.Location = new System.Drawing.Point(12, 46);
		E535DE26.Name = "ckbAnhBanBe";
		E535DE26.Size = new System.Drawing.Size(92, 20);
		E535DE26.TabIndex = 1;
		E535DE26.Text = "Ảnh bạn bè";
		E535DE26.UseVisualStyleBackColor = true;
		E535DE26.CheckedChanged += new System.EventHandler(E535DE26_CheckedChanged);
		ckbCreateHTML.AutoSize = true;
		ckbCreateHTML.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCreateHTML.Location = new System.Drawing.Point(30, 293);
		ckbCreateHTML.Name = "ckbCreateHTML";
		ckbCreateHTML.Size = new System.Drawing.Size(267, 20);
		ckbCreateHTML.TabIndex = 2;
		ckbCreateHTML.Text = "Tự động tạo luôn File Html sau khi backup";
		ckbCreateHTML.UseVisualStyleBackColor = true;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(193, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		B0316409.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B0316409.BackColor = System.Drawing.Color.Maroon;
		B0316409.Cursor = System.Windows.Forms.Cursors.Hand;
		B0316409.FlatAppearance.BorderSize = 0;
		B0316409.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B0316409.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B0316409.ForeColor = System.Drawing.Color.White;
		B0316409.Location = new System.Drawing.Point(189, 327);
		B0316409.Name = "btnCancel";
		B0316409.Size = new System.Drawing.Size(92, 29);
		B0316409.TabIndex = 4;
		B0316409.Text = "Đóng";
		B0316409.UseVisualStyleBackColor = false;
		B0316409.Click += new System.EventHandler(A596158D);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 327);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(F381F790);
		D7224109.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D7224109.BackColor = System.Drawing.Color.White;
		D7224109.BorderRadius = 0;
		D7224109.BottomSahddow = true;
		D7224109.color = System.Drawing.Color.DarkViolet;
		D7224109.Controls.Add(A7AF3783);
		D7224109.LeftSahddow = false;
		D7224109.Location = new System.Drawing.Point(1, 0);
		D7224109.Name = "bunifuCards1";
		D7224109.RightSahddow = true;
		D7224109.ShadowDepth = 20;
		D7224109.Size = new System.Drawing.Size(359, 37);
		D7224109.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 373);
		base.Controls.Add(EB2922AE);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBackupData";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBackupData_Load);
		A7AF3783.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		EB2922AE.ResumeLayout(false);
		EB2922AE.PerformLayout();
		A39C433A.ResumeLayout(false);
		A39C433A.PerformLayout();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoThang).EndInit();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)DE2076B6).EndInit();
		D7224109.ResumeLayout(false);
		ResumeLayout(false);
	}
}
