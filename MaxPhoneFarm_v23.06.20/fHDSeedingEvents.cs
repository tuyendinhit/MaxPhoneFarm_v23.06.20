using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDSeedingEvents : Form
{
	internal JSON_Settings f72FAFBC_0 = null;

	internal string FE8F3EA0;

	internal string string_0;

	internal string string_1;

	internal int int_0;

	internal static bool FCA1342B;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl CE3477B9;

	internal Panel EF07C3AB;

	internal TextBox D9BD63B6;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel E0276B1C;

	internal Button C811B7BF;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel E0034AAE;

	internal Label label2;

	internal NumericUpDown nudMoiBanBeTo;

	internal NumericUpDown nudMoiBanBeFrom;

	internal Label A7AB10B2;

	internal Panel BCA5AB1D;

	internal CheckBox ckbMoiBanBe;

	internal CheckBox ckbThamGia;

	internal CheckBox C52AFF8B;

	internal TextBox txtLinkEvent;

	internal Label label5;

	internal Label lblLinkEvent;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown nudDelayFrom;

	internal Label label6;

	internal Label FAB54E28;

	public fHDSeedingEvents(string B0043808, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		FCA1342B = false;
		FE8F3EA0 = B0043808;
		string_1 = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Seeding Events";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			D9BD63B6.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			D9BD63B6.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void B60CBD11(object sender, EventArgs e)
	{
		try
		{
			txtLinkEvent.Text = f72FAFBC_0.GetValue("txtLinkEvent");
			C52AFF8B.Checked = f72FAFBC_0.AA824D29("ckbQuanTam");
			ckbThamGia.Checked = f72FAFBC_0.AA824D29("ckbThamGia");
			ckbMoiBanBe.Checked = f72FAFBC_0.AA824D29("ckbMoiBanBe");
			nudMoiBanBeFrom.Value = f72FAFBC_0.method_0("nudMoiBanBeFrom", 1);
			nudMoiBanBeTo.Value = f72FAFBC_0.method_0("nudMoiBanBeTo", 1);
			nudDelayFrom.Value = f72FAFBC_0.method_0("nudDelayFrom", 3);
			nudDelayTo.Value = f72FAFBC_0.method_0("nudDelayTo", 5);
		}
		catch
		{
		}
		ckbMoiBanBe_CheckedChanged(null, null);
	}

	private void C811B7BF_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = D9BD63B6.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtLinkEvent", (object)txtLinkEvent.Text);
		f72FAFBC.GetValue("ckbQuanTam", C52AFF8B.Checked);
		f72FAFBC.GetValue("ckbThamGia", ckbThamGia.Checked);
		f72FAFBC.GetValue("ckbMoiBanBe", ckbMoiBanBe.Checked);
		f72FAFBC.GetValue("nudMoiBanBeFrom", nudMoiBanBeFrom.Value);
		f72FAFBC.GetValue("nudMoiBanBeTo", nudMoiBanBeTo.Value);
		f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(FE8F3EA0, text, string_0, text2))
				{
					FCA1342B = true;
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
			if (Class123.smethod_14(string_1, text, text2))
			{
				FCA1342B = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void C02556B5(object sender, EventArgs e)
	{
		Close();
	}

	private void FF8CC084(object sender, PaintEventArgs e)
	{
		if (EF07C3AB.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, EF07C3AB.ClientSize.Width - num, EF07C3AB.ClientSize.Height - num));
		}
	}

	private void ckbMoiBanBe_CheckedChanged(object sender, EventArgs e)
	{
		BCA5AB1D.Enabled = ckbMoiBanBe.Checked;
	}

	private void E0257DB9(object sender, EventArgs e)
	{
		if (C52AFF8B.Checked && ckbThamGia.Checked)
		{
			ckbThamGia.Checked = false;
		}
	}

	private void ckbThamGia_CheckedChanged(object sender, EventArgs e)
	{
		if (C52AFF8B.Checked && ckbThamGia.Checked)
		{
			C52AFF8B.Checked = false;
		}
	}

	protected override void Dispose(bool F7906737)
	{
		if (F7906737 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(F7906737);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDSeedingEvents));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		E0034AAE = new Bunifu.Framework.UI.BunifuCustomLabel();
		CE3477B9 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		E0276B1C = new System.Windows.Forms.Panel();
		C811B7BF = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		EF07C3AB = new System.Windows.Forms.Panel();
		BCA5AB1D = new System.Windows.Forms.Panel();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudMoiBanBeTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		label6 = new System.Windows.Forms.Label();
		nudMoiBanBeFrom = new System.Windows.Forms.NumericUpDown();
		FAB54E28 = new System.Windows.Forms.Label();
		A7AB10B2 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		ckbMoiBanBe = new System.Windows.Forms.CheckBox();
		ckbThamGia = new System.Windows.Forms.CheckBox();
		C52AFF8B = new System.Windows.Forms.CheckBox();
		txtLinkEvent = new System.Windows.Forms.TextBox();
		D9BD63B6 = new System.Windows.Forms.TextBox();
		label5 = new System.Windows.Forms.Label();
		lblLinkEvent = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		E0276B1C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		EF07C3AB.SuspendLayout();
		BCA5AB1D.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudMoiBanBeTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudMoiBanBeFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = E0034AAE;
		bunifuDragControl_0.Vertical = true;
		E0034AAE.BackColor = System.Drawing.Color.Transparent;
		E0034AAE.Cursor = System.Windows.Forms.Cursors.SizeAll;
		E0034AAE.Dock = System.Windows.Forms.DockStyle.Fill;
		E0034AAE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E0034AAE.ForeColor = System.Drawing.Color.Black;
		E0034AAE.Location = new System.Drawing.Point(0, 0);
		E0034AAE.Name = "bunifuCustomLabel1";
		E0034AAE.Size = new System.Drawing.Size(359, 31);
		E0034AAE.TabIndex = 12;
		E0034AAE.Text = "Cấu hình Seeding Events";
		E0034AAE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		CE3477B9.Fixed = true;
		CE3477B9.Horizontal = true;
		CE3477B9.TargetControl = E0276B1C;
		CE3477B9.Vertical = true;
		E0276B1C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E0276B1C.BackColor = System.Drawing.Color.White;
		E0276B1C.Controls.Add(C811B7BF);
		E0276B1C.Controls.Add(pictureBox1);
		E0276B1C.Controls.Add(E0034AAE);
		E0276B1C.Cursor = System.Windows.Forms.Cursors.SizeAll;
		E0276B1C.Location = new System.Drawing.Point(0, 3);
		E0276B1C.Name = "pnlHeader";
		E0276B1C.Size = new System.Drawing.Size(359, 31);
		E0276B1C.TabIndex = 9;
		C811B7BF.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		C811B7BF.Cursor = System.Windows.Forms.Cursors.Hand;
		C811B7BF.FlatAppearance.BorderSize = 0;
		C811B7BF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C811B7BF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C811B7BF.ForeColor = System.Drawing.Color.White;
		C811B7BF.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		C811B7BF.Location = new System.Drawing.Point(328, 1);
		C811B7BF.Name = "button1";
		C811B7BF.Size = new System.Drawing.Size(30, 30);
		C811B7BF.TabIndex = 77;
		C811B7BF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C811B7BF.UseVisualStyleBackColor = true;
		C811B7BF.Click += new System.EventHandler(C811B7BF_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		EF07C3AB.BackColor = System.Drawing.Color.White;
		EF07C3AB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EF07C3AB.Controls.Add(BCA5AB1D);
		EF07C3AB.Controls.Add(ckbMoiBanBe);
		EF07C3AB.Controls.Add(ckbThamGia);
		EF07C3AB.Controls.Add(C52AFF8B);
		EF07C3AB.Controls.Add(txtLinkEvent);
		EF07C3AB.Controls.Add(D9BD63B6);
		EF07C3AB.Controls.Add(label5);
		EF07C3AB.Controls.Add(lblLinkEvent);
		EF07C3AB.Controls.Add(label1);
		EF07C3AB.Controls.Add(btnCancel);
		EF07C3AB.Controls.Add(btnAdd);
		EF07C3AB.Controls.Add(bunifuCards1);
		EF07C3AB.Cursor = System.Windows.Forms.Cursors.Arrow;
		EF07C3AB.Dock = System.Windows.Forms.DockStyle.Fill;
		EF07C3AB.Location = new System.Drawing.Point(0, 0);
		EF07C3AB.Name = "panel1";
		EF07C3AB.Size = new System.Drawing.Size(362, 301);
		EF07C3AB.TabIndex = 0;
		EF07C3AB.Paint += new System.Windows.Forms.PaintEventHandler(FF8CC084);
		BCA5AB1D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		BCA5AB1D.Controls.Add(nudDelayTo);
		BCA5AB1D.Controls.Add(nudMoiBanBeTo);
		BCA5AB1D.Controls.Add(nudDelayFrom);
		BCA5AB1D.Controls.Add(label6);
		BCA5AB1D.Controls.Add(nudMoiBanBeFrom);
		BCA5AB1D.Controls.Add(FAB54E28);
		BCA5AB1D.Controls.Add(A7AB10B2);
		BCA5AB1D.Controls.Add(label2);
		BCA5AB1D.Location = new System.Drawing.Point(132, 183);
		BCA5AB1D.Name = "plMoiBanBe";
		BCA5AB1D.Size = new System.Drawing.Size(194, 58);
		BCA5AB1D.TabIndex = 44;
		nudDelayTo.Location = new System.Drawing.Point(142, 31);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(48, 23);
		nudDelayTo.TabIndex = 39;
		nudMoiBanBeTo.Location = new System.Drawing.Point(142, 2);
		nudMoiBanBeTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudMoiBanBeTo.Name = "nudMoiBanBeTo";
		nudMoiBanBeTo.Size = new System.Drawing.Size(48, 23);
		nudMoiBanBeTo.TabIndex = 39;
		nudDelayFrom.Location = new System.Drawing.Point(71, 31);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(48, 23);
		nudDelayFrom.TabIndex = 38;
		label6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label6.Location = new System.Drawing.Point(119, 33);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(25, 16);
		label6.TabIndex = 42;
		label6.Text = ">";
		label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudMoiBanBeFrom.Location = new System.Drawing.Point(71, 2);
		nudMoiBanBeFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudMoiBanBeFrom.Name = "nudMoiBanBeFrom";
		nudMoiBanBeFrom.Size = new System.Drawing.Size(48, 23);
		nudMoiBanBeFrom.TabIndex = 38;
		FAB54E28.AutoSize = true;
		FAB54E28.Location = new System.Drawing.Point(2, 33);
		FAB54E28.Name = "label4";
		FAB54E28.Size = new System.Drawing.Size(63, 16);
		FAB54E28.TabIndex = 34;
		FAB54E28.Text = "Delay (s):";
		A7AB10B2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A7AB10B2.Location = new System.Drawing.Point(119, 4);
		A7AB10B2.Name = "label3";
		A7AB10B2.Size = new System.Drawing.Size(25, 16);
		A7AB10B2.TabIndex = 42;
		A7AB10B2.Text = ">";
		A7AB10B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(2, 4);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(63, 16);
		label2.TabIndex = 34;
		label2.Text = "Số lượng:";
		ckbMoiBanBe.AutoSize = true;
		ckbMoiBanBe.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbMoiBanBe.Location = new System.Drawing.Point(132, 161);
		ckbMoiBanBe.Name = "ckbMoiBanBe";
		ckbMoiBanBe.Size = new System.Drawing.Size(89, 20);
		ckbMoiBanBe.TabIndex = 43;
		ckbMoiBanBe.Text = "Mời bạn bè";
		ckbMoiBanBe.UseVisualStyleBackColor = true;
		ckbMoiBanBe.CheckedChanged += new System.EventHandler(ckbMoiBanBe_CheckedChanged);
		ckbThamGia.AutoSize = true;
		ckbThamGia.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbThamGia.Location = new System.Drawing.Point(132, 135);
		ckbThamGia.Name = "ckbThamGia";
		ckbThamGia.Size = new System.Drawing.Size(80, 20);
		ckbThamGia.TabIndex = 43;
		ckbThamGia.Text = "Tham gia";
		ckbThamGia.UseVisualStyleBackColor = true;
		ckbThamGia.CheckedChanged += new System.EventHandler(ckbThamGia_CheckedChanged);
		C52AFF8B.AutoSize = true;
		C52AFF8B.Cursor = System.Windows.Forms.Cursors.Hand;
		C52AFF8B.Location = new System.Drawing.Point(132, 109);
		C52AFF8B.Name = "ckbQuanTam";
		C52AFF8B.Size = new System.Drawing.Size(82, 20);
		C52AFF8B.TabIndex = 43;
		C52AFF8B.Text = "Quan tâm";
		C52AFF8B.UseVisualStyleBackColor = true;
		C52AFF8B.CheckedChanged += new System.EventHandler(E0257DB9);
		txtLinkEvent.Location = new System.Drawing.Point(132, 78);
		txtLinkEvent.Name = "txtLinkEvent";
		txtLinkEvent.Size = new System.Drawing.Size(194, 23);
		txtLinkEvent.TabIndex = 0;
		D9BD63B6.Location = new System.Drawing.Point(132, 49);
		D9BD63B6.Name = "txtTenHanhDong";
		D9BD63B6.Size = new System.Drawing.Size(194, 23);
		D9BD63B6.TabIndex = 0;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 110);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(64, 16);
		label5.TabIndex = 31;
		label5.Text = "Tùy chọn:";
		lblLinkEvent.AutoSize = true;
		lblLinkEvent.Location = new System.Drawing.Point(27, 81);
		lblLinkEvent.Name = "lblLinkEvent";
		lblLinkEvent.Size = new System.Drawing.Size(69, 16);
		lblLinkEvent.TabIndex = 31;
		lblLinkEvent.Text = "Link Event:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 256);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(C02556B5);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 256);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(E0276B1C);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 301);
		base.Controls.Add(EF07C3AB);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDSeedingEvents";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B60CBD11);
		E0276B1C.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		EF07C3AB.ResumeLayout(false);
		EF07C3AB.PerformLayout();
		BCA5AB1D.ResumeLayout(false);
		BCA5AB1D.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudMoiBanBeTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudMoiBanBeFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
