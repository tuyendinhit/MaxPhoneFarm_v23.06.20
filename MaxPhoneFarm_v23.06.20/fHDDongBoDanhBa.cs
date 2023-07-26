using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDongBoDanhBa : Form
{
	internal JSON_Settings EBB7E6AC;

	internal string string_0;

	internal string D2053698;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal IContainer FC22F009 = null;

	internal BunifuDragControl DD0A44B9;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal TextBox F432503B;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards CD9C10BF;

	internal Panel pnlHeader;

	internal PictureBox A9007D27;

	internal BunifuCustomLabel C21A60A9;

	internal NumericUpDown nudSoLuongTo;

	internal NumericUpDown B2377F8E;

	internal Label label7;

	internal Label label6;

	internal Label FF141391;

	internal Label A524F402;

	internal Label lblStatusUid;

	internal CheckBox C3A6B0B8;

	internal Button CE8A03A7;

	internal RichTextBox F581E500;

	internal Panel plAutoAddFriend;

	internal NumericUpDown C69BB09A;

	internal NumericUpDown ED142F9E;

	internal Label label2;

	internal Label label3;

	internal Label label4;

	internal NumericUpDown nudSoLuongKetBanTo;

	internal NumericUpDown E6187E0E;

	internal Label AF9C1AAE;

	internal Label label9;

	internal Label label11;

	internal CheckBox D2A68D03;

	public fHDDongBoDanhBa(string EC299CBF, int D82E5290 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = EC299CBF;
		string_1 = string_2;
		int_0 = D82E5290;
		string text = "HDDongBoDanhBa";
		string text2 = "Đồng bộ danh bạ";
		if (Class123.C7BE863B("", "HDDongBoDanhBa").Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (D82E5290)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			D2053698 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			F432503B.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			F432503B.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		EBB7E6AC = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void A622ABB1(object sender, EventArgs e)
	{
		try
		{
			F581E500.Text = EBB7E6AC.GetValue("txtSdt");
			B2377F8E.Value = EBB7E6AC.method_0("nudSoLuongFrom", 10);
			nudSoLuongTo.Value = EBB7E6AC.method_0("nudSoLuongTo", 10);
			C3A6B0B8.Checked = EBB7E6AC.AA824D29("ckbTuDongXoa");
			D2A68D03.Checked = EBB7E6AC.AA824D29("ckbAutoAddFriend");
			E6187E0E.Value = EBB7E6AC.method_0("nudSoLuongKetBanFrom", 2);
			nudSoLuongKetBanTo.Value = EBB7E6AC.method_0("nudSoLuongKetBanTo", 5);
			ED142F9E.Value = EBB7E6AC.method_0("nudDelayFrom", 2);
			C69BB09A.Value = EBB7E6AC.method_0("nudDelayTo", 5);
			D2A68D03_CheckedChanged(null, null);
		}
		catch
		{
		}
	}

	private void CE8A03A7_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = F432503B.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtSdt", (object)F581E500.Text.Trim());
		f72FAFBC.GetValue("nudSoLuongFrom", B2377F8E.Value);
		f72FAFBC.GetValue("nudSoLuongTo", nudSoLuongTo.Value);
		f72FAFBC.GetValue("ckbTuDongXoa", C3A6B0B8.Checked);
		f72FAFBC.GetValue("ckbAutoAddFriend", D2A68D03.Checked);
		f72FAFBC.GetValue("nudSoLuongKetBanFrom", E6187E0E.Value);
		f72FAFBC.GetValue("nudSoLuongKetBanTo", nudSoLuongKetBanTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", ED142F9E.Value);
		f72FAFBC.GetValue("nudDelayTo", C69BB09A.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, D2053698, text2))
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
		else if (MessageBoxHelper.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class123.smethod_14(string_1, text, text2))
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

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void A886229A(object sender, EventArgs e)
	{
		Common.D936DD84(F581E500, lblStatusUid);
	}

	private void D2A68D03_CheckedChanged(object sender, EventArgs e)
	{
		plAutoAddFriend.Enabled = D2A68D03.Checked;
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && FC22F009 != null)
		{
			FC22F009.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		FC22F009 = new System.ComponentModel.Container();
		DD0A44B9 = new Bunifu.Framework.UI.BunifuDragControl(FC22F009);
		C21A60A9 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(FC22F009);
		pnlHeader = new System.Windows.Forms.Panel();
		CE8A03A7 = new System.Windows.Forms.Button();
		A9007D27 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		plAutoAddFriend = new System.Windows.Forms.Panel();
		C69BB09A = new System.Windows.Forms.NumericUpDown();
		ED142F9E = new System.Windows.Forms.NumericUpDown();
		label2 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		nudSoLuongKetBanTo = new System.Windows.Forms.NumericUpDown();
		E6187E0E = new System.Windows.Forms.NumericUpDown();
		AF9C1AAE = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		F581E500 = new System.Windows.Forms.RichTextBox();
		D2A68D03 = new System.Windows.Forms.CheckBox();
		C3A6B0B8 = new System.Windows.Forms.CheckBox();
		lblStatusUid = new System.Windows.Forms.Label();
		A524F402 = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		B2377F8E = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		FF141391 = new System.Windows.Forms.Label();
		F432503B = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		CD9C10BF = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A9007D27).BeginInit();
		panel1.SuspendLayout();
		plAutoAddFriend.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C69BB09A).BeginInit();
		((System.ComponentModel.ISupportInitialize)ED142F9E).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongKetBanTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)E6187E0E).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)B2377F8E).BeginInit();
		CD9C10BF.SuspendLayout();
		SuspendLayout();
		DD0A44B9.Fixed = true;
		DD0A44B9.Horizontal = true;
		DD0A44B9.TargetControl = C21A60A9;
		DD0A44B9.Vertical = true;
		C21A60A9.BackColor = System.Drawing.Color.Transparent;
		C21A60A9.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C21A60A9.Dock = System.Windows.Forms.DockStyle.Fill;
		C21A60A9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C21A60A9.ForeColor = System.Drawing.Color.Black;
		C21A60A9.Location = new System.Drawing.Point(0, 0);
		C21A60A9.Name = "bunifuCustomLabel1";
		C21A60A9.Size = new System.Drawing.Size(354, 31);
		C21A60A9.TabIndex = 12;
		C21A60A9.Text = "Cấu hình Đồng bộ danh bạ";
		C21A60A9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(CE8A03A7);
		pnlHeader.Controls.Add(A9007D27);
		pnlHeader.Controls.Add(C21A60A9);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(354, 31);
		pnlHeader.TabIndex = 9;
		CE8A03A7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		CE8A03A7.Cursor = System.Windows.Forms.Cursors.Hand;
		CE8A03A7.FlatAppearance.BorderSize = 0;
		CE8A03A7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CE8A03A7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CE8A03A7.ForeColor = System.Drawing.Color.White;
		CE8A03A7.Image = Resource.Bitmap_9;
		CE8A03A7.Location = new System.Drawing.Point(324, 1);
		CE8A03A7.Name = "button1";
		CE8A03A7.Size = new System.Drawing.Size(30, 30);
		CE8A03A7.TabIndex = 80;
		CE8A03A7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		CE8A03A7.UseVisualStyleBackColor = true;
		CE8A03A7.Click += new System.EventHandler(CE8A03A7_Click);
		A9007D27.Cursor = System.Windows.Forms.Cursors.Default;
		A9007D27.Image = Resource.AC35C73C;
		A9007D27.Location = new System.Drawing.Point(3, 2);
		A9007D27.Name = "pictureBox1";
		A9007D27.Size = new System.Drawing.Size(34, 27);
		A9007D27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A9007D27.TabIndex = 76;
		A9007D27.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(plAutoAddFriend);
		panel1.Controls.Add(F581E500);
		panel1.Controls.Add(D2A68D03);
		panel1.Controls.Add(C3A6B0B8);
		panel1.Controls.Add(lblStatusUid);
		panel1.Controls.Add(A524F402);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(B2377F8E);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(FF141391);
		panel1.Controls.Add(F432503B);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(CD9C10BF);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(357, 505);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plAutoAddFriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAutoAddFriend.Controls.Add(C69BB09A);
		plAutoAddFriend.Controls.Add(ED142F9E);
		plAutoAddFriend.Controls.Add(label2);
		plAutoAddFriend.Controls.Add(label3);
		plAutoAddFriend.Controls.Add(label4);
		plAutoAddFriend.Controls.Add(nudSoLuongKetBanTo);
		plAutoAddFriend.Controls.Add(E6187E0E);
		plAutoAddFriend.Controls.Add(AF9C1AAE);
		plAutoAddFriend.Controls.Add(label9);
		plAutoAddFriend.Controls.Add(label11);
		plAutoAddFriend.Location = new System.Drawing.Point(49, 391);
		plAutoAddFriend.Name = "plAutoAddFriend";
		plAutoAddFriend.Size = new System.Drawing.Size(277, 60);
		plAutoAddFriend.TabIndex = 51;
		C69BB09A.Location = new System.Drawing.Point(173, 32);
		C69BB09A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C69BB09A.Name = "nudDelayTo";
		C69BB09A.Size = new System.Drawing.Size(56, 23);
		C69BB09A.TabIndex = 51;
		ED142F9E.Location = new System.Drawing.Point(89, 32);
		ED142F9E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		ED142F9E.Name = "nudDelayFrom";
		ED142F9E.Size = new System.Drawing.Size(56, 23);
		ED142F9E.TabIndex = 50;
		label2.Location = new System.Drawing.Point(145, 34);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(29, 16);
		label2.TabIndex = 58;
		label2.Text = "đê\u0301n";
		label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(231, 34);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(30, 16);
		label3.TabIndex = 57;
		label3.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(3, 34);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(89, 16);
		label4.TabIndex = 56;
		label4.Text = "Thời gian chờ:";
		nudSoLuongKetBanTo.Location = new System.Drawing.Point(173, 4);
		nudSoLuongKetBanTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongKetBanTo.Name = "nudSoLuongKetBanTo";
		nudSoLuongKetBanTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongKetBanTo.TabIndex = 49;
		E6187E0E.Location = new System.Drawing.Point(89, 4);
		E6187E0E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E6187E0E.Name = "nudSoLuongKetBanFrom";
		E6187E0E.Size = new System.Drawing.Size(56, 23);
		E6187E0E.TabIndex = 48;
		AF9C1AAE.Location = new System.Drawing.Point(145, 6);
		AF9C1AAE.Name = "label8";
		AF9C1AAE.Size = new System.Drawing.Size(29, 16);
		AF9C1AAE.TabIndex = 55;
		AF9C1AAE.Text = "đê\u0301n";
		AF9C1AAE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(231, 6);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(28, 16);
		label9.TabIndex = 54;
		label9.Text = "ba\u0323n";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(3, 6);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(63, 16);
		label11.TabIndex = 53;
		label11.Text = "Sô\u0301 lươ\u0323ng:";
		F581E500.Location = new System.Drawing.Point(31, 101);
		F581E500.Name = "txtSdt";
		F581E500.Size = new System.Drawing.Size(295, 183);
		F581E500.TabIndex = 50;
		F581E500.Text = "";
		F581E500.TextChanged += new System.EventHandler(A886229A);
		D2A68D03.AutoSize = true;
		D2A68D03.Cursor = System.Windows.Forms.Cursors.Hand;
		D2A68D03.Location = new System.Drawing.Point(30, 366);
		D2A68D03.Name = "ckbAutoAddFriend";
		D2A68D03.Size = new System.Drawing.Size(208, 20);
		D2A68D03.TabIndex = 2;
		D2A68D03.Text = "Tự động kết bạn nếu có đề xuất";
		D2A68D03.UseVisualStyleBackColor = true;
		D2A68D03.CheckedChanged += new System.EventHandler(D2A68D03_CheckedChanged);
		C3A6B0B8.AutoSize = true;
		C3A6B0B8.Cursor = System.Windows.Forms.Cursors.Hand;
		C3A6B0B8.Location = new System.Drawing.Point(30, 340);
		C3A6B0B8.Name = "ckbTuDongXoa";
		C3A6B0B8.Size = new System.Drawing.Size(259, 20);
		C3A6B0B8.TabIndex = 2;
		C3A6B0B8.Text = "Tự động xóa những sđt đã được đồng bộ";
		C3A6B0B8.UseVisualStyleBackColor = true;
		lblStatusUid.AutoSize = true;
		lblStatusUid.Location = new System.Drawing.Point(27, 81);
		lblStatusUid.Name = "lblStatusUid";
		lblStatusUid.Size = new System.Drawing.Size(201, 16);
		lblStatusUid.TabIndex = 0;
		lblStatusUid.Text = "Nhập danh sách số điện thoại (0):";
		A524F402.AutoSize = true;
		A524F402.Location = new System.Drawing.Point(27, 287);
		A524F402.Name = "label10";
		A524F402.Size = new System.Drawing.Size(157, 16);
		A524F402.TabIndex = 0;
		A524F402.Text = "(Mỗi số điện thoại 1 dòng)";
		nudSoLuongTo.Location = new System.Drawing.Point(243, 311);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 1215752191, 23, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(50, 23);
		nudSoLuongTo.TabIndex = 4;
		B2377F8E.Location = new System.Drawing.Point(160, 311);
		B2377F8E.Maximum = new decimal(new int[4] { 1215752191, 23, 0, 0 });
		B2377F8E.Name = "nudSoLuongFrom";
		B2377F8E.Size = new System.Drawing.Size(50, 23);
		B2377F8E.TabIndex = 3;
		label7.Location = new System.Drawing.Point(212, 313);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(28, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(295, 313);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(20, 16);
		label6.TabIndex = 45;
		label6.Text = "số";
		FF141391.AutoSize = true;
		FF141391.Location = new System.Drawing.Point(28, 313);
		FF141391.Name = "label5";
		FF141391.Size = new System.Drawing.Size(130, 16);
		FF141391.TabIndex = 44;
		FF141391.Text = "Số lượng Sđt/thiết bị:";
		F432503B.Location = new System.Drawing.Point(132, 49);
		F432503B.Name = "txtTenHanhDong";
		F432503B.Size = new System.Drawing.Size(194, 23);
		F432503B.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(187, 463);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(80, 463);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		CD9C10BF.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CD9C10BF.BackColor = System.Drawing.Color.White;
		CD9C10BF.BorderRadius = 0;
		CD9C10BF.BottomSahddow = true;
		CD9C10BF.color = System.Drawing.Color.DarkViolet;
		CD9C10BF.Controls.Add(pnlHeader);
		CD9C10BF.LeftSahddow = false;
		CD9C10BF.Location = new System.Drawing.Point(1, 0);
		CD9C10BF.Name = "bunifuCards1";
		CD9C10BF.RightSahddow = true;
		CD9C10BF.ShadowDepth = 20;
		CD9C10BF.Size = new System.Drawing.Size(354, 37);
		CD9C10BF.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(357, 505);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDongBoDanhBa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A622ABB1);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A9007D27).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plAutoAddFriend.ResumeLayout(false);
		plAutoAddFriend.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C69BB09A).EndInit();
		((System.ComponentModel.ISupportInitialize)ED142F9E).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongKetBanTo).EndInit();
		((System.ComponentModel.ISupportInitialize)E6187E0E).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)B2377F8E).EndInit();
		CD9C10BF.ResumeLayout(false);
		ResumeLayout(false);
	}
}
