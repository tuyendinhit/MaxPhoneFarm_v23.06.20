using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDHuyLoiMoiKetBan : Form
{
	internal JObject jobject_0;

	internal string CC1C12A3;

	internal string A035AC33;

	internal string string_0;

	internal int int_0;

	internal static bool E38E79BE;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl A5A8CA3F;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel C21C741C;

	internal NumericUpDown A58EFA03;

	internal NumericUpDown C33582BA;

	internal TextBox txtTenHanhDong;

	internal Label E91C421D;

	internal Label EA0F1428;

	internal Label label2;

	internal Label label1;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox F122F001;

	internal BunifuCustomLabel EDB1D52E;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown CA828B19;

	internal Label label7;

	internal Label label6;

	internal Label FC27749B;

	public fHDHuyLoiMoiKetBan(string string_1, int F382E800 = 0, string string_2 = "")
	{
		InitializeComponent();
		E38E79BE = false;
		CC1C12A3 = string_1;
		string_0 = string_2;
		int_0 = F382E800;
		string json = "";
		switch (F382E800)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDHuyLoiMoiKetBan");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			A035AC33 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(EDB1D52E);
		Language.smethod_1(label1);
		Language.smethod_1(label2);
		Language.smethod_1(E91C421D);
		Language.smethod_1(EA0F1428);
		Language.smethod_1(FC27749B);
		Language.smethod_1(label7);
		Language.smethod_1(label6);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void fHDHuyLoiMoiKetBan_Load(object sender, EventArgs e)
	{
		try
		{
			C33582BA.Value = Convert.ToInt32(jobject_0["nudSoLuongFrom"]);
			A58EFA03.Value = Convert.ToInt32(jobject_0["nudSoLuongTo"]);
			CA828B19.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("nudSoLuongFrom", C33582BA.Value);
		f72FAFBC.GetValue("nudSoLuongTo", A58EFA03.Value);
		f72FAFBC.GetValue("nudDelayFrom", CA828B19.Value);
		f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(CC1C12A3, text, A035AC33, text2))
				{
					E38E79BE = true;
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
				E38E79BE = true;
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

	private void F9AFA933(object sender, PaintEventArgs e)
	{
		if (C21C741C.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C21C741C.ClientSize.Width - num, C21C741C.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool E88EC637)
	{
		if (E88EC637 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(E88EC637);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDHuyLoiMoiKetBan));
		A5A8CA3F = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		EDB1D52E = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		F122F001 = new System.Windows.Forms.PictureBox();
		C21C741C = new System.Windows.Forms.Panel();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		CA828B19 = new System.Windows.Forms.NumericUpDown();
		label7 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		FC27749B = new System.Windows.Forms.Label();
		A58EFA03 = new System.Windows.Forms.NumericUpDown();
		C33582BA = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		E91C421D = new System.Windows.Forms.Label();
		EA0F1428 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F122F001).BeginInit();
		C21C741C.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)CA828B19).BeginInit();
		((System.ComponentModel.ISupportInitialize)A58EFA03).BeginInit();
		((System.ComponentModel.ISupportInitialize)C33582BA).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		A5A8CA3F.Fixed = true;
		A5A8CA3F.Horizontal = true;
		A5A8CA3F.TargetControl = EDB1D52E;
		A5A8CA3F.Vertical = true;
		EDB1D52E.BackColor = System.Drawing.Color.Transparent;
		EDB1D52E.Cursor = System.Windows.Forms.Cursors.SizeAll;
		EDB1D52E.Dock = System.Windows.Forms.DockStyle.Fill;
		EDB1D52E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EDB1D52E.ForeColor = System.Drawing.Color.Black;
		EDB1D52E.Location = new System.Drawing.Point(0, 0);
		EDB1D52E.Name = "bunifuCustomLabel1";
		EDB1D52E.Size = new System.Drawing.Size(359, 31);
		EDB1D52E.TabIndex = 12;
		EDB1D52E.Text = "Cấu hình Hủy lời mời kết bạn";
		EDB1D52E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(F122F001);
		pnlHeader.Controls.Add(EDB1D52E);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
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
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		F122F001.Cursor = System.Windows.Forms.Cursors.Default;
		F122F001.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		F122F001.Location = new System.Drawing.Point(3, 2);
		F122F001.Name = "pictureBox1";
		F122F001.Size = new System.Drawing.Size(34, 27);
		F122F001.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		F122F001.TabIndex = 76;
		F122F001.TabStop = false;
		C21C741C.BackColor = System.Drawing.Color.White;
		C21C741C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C21C741C.Controls.Add(nudDelayTo);
		C21C741C.Controls.Add(CA828B19);
		C21C741C.Controls.Add(label7);
		C21C741C.Controls.Add(label6);
		C21C741C.Controls.Add(FC27749B);
		C21C741C.Controls.Add(A58EFA03);
		C21C741C.Controls.Add(C33582BA);
		C21C741C.Controls.Add(txtTenHanhDong);
		C21C741C.Controls.Add(E91C421D);
		C21C741C.Controls.Add(EA0F1428);
		C21C741C.Controls.Add(label2);
		C21C741C.Controls.Add(label1);
		C21C741C.Controls.Add(btnCancel);
		C21C741C.Controls.Add(btnAdd);
		C21C741C.Controls.Add(bunifuCards1);
		C21C741C.Cursor = System.Windows.Forms.Cursors.Arrow;
		C21C741C.Dock = System.Windows.Forms.DockStyle.Fill;
		C21C741C.Location = new System.Drawing.Point(0, 0);
		C21C741C.Name = "panel1";
		C21C741C.Size = new System.Drawing.Size(362, 191);
		C21C741C.TabIndex = 0;
		C21C741C.Paint += new System.Windows.Forms.PaintEventHandler(F9AFA933);
		nudDelayTo.Location = new System.Drawing.Point(223, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		CA828B19.Location = new System.Drawing.Point(132, 107);
		CA828B19.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		CA828B19.Name = "nudDelayFrom";
		CA828B19.Size = new System.Drawing.Size(56, 23);
		CA828B19.TabIndex = 3;
		label7.Location = new System.Drawing.Point(191, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 46;
		label7.Text = "đê\u0301n";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(280, 109);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		FC27749B.AutoSize = true;
		FC27749B.Location = new System.Drawing.Point(27, 109);
		FC27749B.Name = "label5";
		FC27749B.Size = new System.Drawing.Size(89, 16);
		FC27749B.TabIndex = 44;
		FC27749B.Text = "Thơ\u0300i gian chơ\u0300:";
		A58EFA03.Location = new System.Drawing.Point(223, 78);
		A58EFA03.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A58EFA03.Name = "nudSoLuongTo";
		A58EFA03.Size = new System.Drawing.Size(56, 23);
		A58EFA03.TabIndex = 2;
		C33582BA.Location = new System.Drawing.Point(132, 78);
		C33582BA.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C33582BA.Name = "nudSoLuongFrom";
		C33582BA.Size = new System.Drawing.Size(56, 23);
		C33582BA.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		E91C421D.Location = new System.Drawing.Point(191, 80);
		E91C421D.Name = "label3";
		E91C421D.Size = new System.Drawing.Size(29, 16);
		E91C421D.TabIndex = 37;
		E91C421D.Text = "đê\u0301n";
		E91C421D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		EA0F1428.AutoSize = true;
		EA0F1428.Location = new System.Drawing.Point(280, 80);
		EA0F1428.Name = "label4";
		EA0F1428.Size = new System.Drawing.Size(45, 16);
		EA0F1428.TabIndex = 35;
		EA0F1428.Text = "lời mời";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(63, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng:";
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
		btnCancel.Location = new System.Drawing.Point(191, 148);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(84, 148);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 191);
		base.Controls.Add(C21C741C);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDHuyLoiMoiKetBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDHuyLoiMoiKetBan_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)F122F001).EndInit();
		C21C741C.ResumeLayout(false);
		C21C741C.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)CA828B19).EndInit();
		((System.ComponentModel.ISupportInitialize)A58EFA03).EndInit();
		((System.ComponentModel.ISupportInitialize)C33582BA).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
