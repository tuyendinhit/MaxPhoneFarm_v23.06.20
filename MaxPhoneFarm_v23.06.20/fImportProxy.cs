using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fImportProxy : Form
{
	internal IContainer icontainer_0 = null;

	internal BunifuCards D33D5F9B;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuDragControl bunifuDragControl_0;

	internal PictureBox A516E182;

	internal Label label8;

	internal Label lblStatus;

	internal RichTextBox txtProxy;

	internal Label E38C2636;

	internal NumericUpDown FE1FAE23;

	internal CheckBox ckbKhongNhapTaiKhoanDaCo;

	internal Label F5A329B5;

	internal RadioButton E82D5414;

	internal RadioButton E8BE35A6;

	internal Label label3;

	internal ComboBox cbbTypeProxy;

	internal Label F32C6BA9;

	public fImportProxy()
	{
		InitializeComponent();
		Language.SetLanguage(this);
		cbbTypeProxy.SelectedIndex = 0;
	}

	private void B38A7935(object sender, EventArgs e)
	{
		Close();
	}

	private void A814A494(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtProxy.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			List<string> list = new List<string>();
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p thêm Proxy!"), 3);
				return;
			}
			int num = Convert.ToInt32(FE1FAE23.Value);
			for (int i = 0; i < num; i++)
			{
				list.AddRange(f1808BA);
			}
			if (E82D5414.Checked)
			{
				list = Common.F78FD80F(list);
			}
			Queue<string> queue = new Queue<string>(list);
			int selectedIndex = cbbTypeProxy.SelectedIndex;
			List<string> list2 = new List<string>();
			for (int j = 0; j < fMain.fMain_0.dtgvAcc.Rows.Count; j++)
			{
				if (Convert.ToBoolean(fMain.fMain_0.method_117(j, "cChose")) && (!(fMain.fMain_0.method_117(j, "cProxy") != "") || !ckbKhongNhapTaiKhoanDaCo.Checked))
				{
					if (queue.Count == 0)
					{
						break;
					}
					string text = (queue.Dequeue() + "*" + selectedIndex).Replace("'", "''");
					list2.Add(fMain.fMain_0.method_117(j, "cId") + "|" + text);
				}
			}
			if (CommonSQL.smethod_18("proxy", list2))
			{
				queue = new Queue<string>(list);
				for (int k = 0; k < fMain.fMain_0.dtgvAcc.Rows.Count; k++)
				{
					if (Convert.ToBoolean(fMain.fMain_0.method_117(k, "cChose")) && (!(fMain.fMain_0.method_117(k, "cProxy") != "") || !ckbKhongNhapTaiKhoanDaCo.Checked))
					{
						if (queue.Count == 0)
						{
							break;
						}
						string object_ = (queue.Dequeue() + "*" + selectedIndex).Replace("'", "''");
						fMain.fMain_0.SetCellAccount(k, "cProxy", object_);
					}
				}
			}
			if (MessageBoxHelper.smethod_1(Language.GetValue("Nhâ\u0323p thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?")) == DialogResult.Yes)
			{
				Close();
			}
		}
		catch (Exception)
		{
			MessageBoxHelper.Show(Language.GetValue("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			A814A494(null, null);
		}
	}

	private void txtProxy_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtProxy.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch Proxy ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportProxy));
		D33D5F9B = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		A516E182 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		txtProxy = new System.Windows.Forms.RichTextBox();
		E38C2636 = new System.Windows.Forms.Label();
		FE1FAE23 = new System.Windows.Forms.NumericUpDown();
		ckbKhongNhapTaiKhoanDaCo = new System.Windows.Forms.CheckBox();
		F5A329B5 = new System.Windows.Forms.Label();
		E82D5414 = new System.Windows.Forms.RadioButton();
		E8BE35A6 = new System.Windows.Forms.RadioButton();
		label3 = new System.Windows.Forms.Label();
		cbbTypeProxy = new System.Windows.Forms.ComboBox();
		F32C6BA9 = new System.Windows.Forms.Label();
		D33D5F9B.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A516E182).BeginInit();
		((System.ComponentModel.ISupportInitialize)FE1FAE23).BeginInit();
		SuspendLayout();
		D33D5F9B.BackColor = System.Drawing.Color.White;
		D33D5F9B.BorderRadius = 0;
		D33D5F9B.BottomSahddow = true;
		D33D5F9B.color = System.Drawing.Color.SaddleBrown;
		D33D5F9B.Controls.Add(pnlHeader);
		D33D5F9B.Dock = System.Windows.Forms.DockStyle.Top;
		D33D5F9B.LeftSahddow = false;
		D33D5F9B.Location = new System.Drawing.Point(0, 0);
		D33D5F9B.Name = "bunifuCards1";
		D33D5F9B.RightSahddow = true;
		D33D5F9B.ShadowDepth = 20;
		D33D5F9B.Size = new System.Drawing.Size(477, 38);
		D33D5F9B.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(A516E182);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(477, 32);
		pnlHeader.TabIndex = 9;
		A516E182.Cursor = System.Windows.Forms.Cursors.Default;
		A516E182.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		A516E182.Location = new System.Drawing.Point(4, 1);
		A516E182.Name = "pictureBox1";
		A516E182.Size = new System.Drawing.Size(34, 27);
		A516E182.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A516E182.TabIndex = 77;
		A516E182.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(445, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(B38A7935);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(477, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Nhâ\u0323p Proxy";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(244, 386);
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
		btnAdd.Location = new System.Drawing.Point(135, 386);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Xa\u0301c nhâ\u0323n";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(A814A494);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		label8.AutoSize = true;
		label8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label8.Location = new System.Drawing.Point(331, 252);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(115, 16);
		label8.TabIndex = 5;
		label8.Text = "(Mỗi proxy 1 dòng)";
		lblStatus.AutoSize = true;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.Location = new System.Drawing.Point(30, 47);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(127, 16);
		lblStatus.TabIndex = 6;
		lblStatus.Text = "Danh sa\u0301ch Proxy (0):";
		txtProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtProxy.Location = new System.Drawing.Point(34, 66);
		txtProxy.Name = "txtProxy";
		txtProxy.Size = new System.Drawing.Size(409, 181);
		txtProxy.TabIndex = 118;
		txtProxy.Text = "";
		txtProxy.WordWrap = false;
		txtProxy.TextChanged += new System.EventHandler(txtProxy_TextChanged);
		E38C2636.AutoSize = true;
		E38C2636.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E38C2636.Location = new System.Drawing.Point(31, 298);
		E38C2636.Name = "label1";
		E38C2636.Size = new System.Drawing.Size(119, 16);
		E38C2636.TabIndex = 119;
		E38C2636.Text = "Sô\u0301 ta\u0300i khoa\u0309n/proxy:";
		FE1FAE23.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FE1FAE23.Location = new System.Drawing.Point(164, 296);
		FE1FAE23.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		FE1FAE23.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		FE1FAE23.Name = "nudTaiKhoanPerUa";
		FE1FAE23.Size = new System.Drawing.Size(69, 23);
		FE1FAE23.TabIndex = 120;
		FE1FAE23.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		ckbKhongNhapTaiKhoanDaCo.AutoSize = true;
		ckbKhongNhapTaiKhoanDaCo.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbKhongNhapTaiKhoanDaCo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbKhongNhapTaiKhoanDaCo.Location = new System.Drawing.Point(33, 349);
		ckbKhongNhapTaiKhoanDaCo.Name = "ckbKhongNhapTaiKhoanDaCo";
		ckbKhongNhapTaiKhoanDaCo.Size = new System.Drawing.Size(283, 20);
		ckbKhongNhapTaiKhoanDaCo.TabIndex = 121;
		ckbKhongNhapTaiKhoanDaCo.Text = "Không nhâ\u0323p va\u0300o như\u0303ng ta\u0300i khoa\u0309n đa\u0303 co\u0301 Proxy";
		ckbKhongNhapTaiKhoanDaCo.UseVisualStyleBackColor = true;
		F5A329B5.AutoSize = true;
		F5A329B5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F5A329B5.Location = new System.Drawing.Point(30, 325);
		F5A329B5.Name = "label2";
		F5A329B5.Size = new System.Drawing.Size(131, 16);
		F5A329B5.TabIndex = 119;
		F5A329B5.Text = "Tu\u0300y cho\u0323n nhâ\u0323p Proxy:";
		E82D5414.AutoSize = true;
		E82D5414.Cursor = System.Windows.Forms.Cursors.Hand;
		E82D5414.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E82D5414.Location = new System.Drawing.Point(253, 323);
		E82D5414.Name = "rbNgauNhien";
		E82D5414.Size = new System.Drawing.Size(89, 20);
		E82D5414.TabIndex = 122;
		E82D5414.Text = "Ngâ\u0303u nhiên";
		E82D5414.UseVisualStyleBackColor = true;
		E8BE35A6.AutoSize = true;
		E8BE35A6.Checked = true;
		E8BE35A6.Cursor = System.Windows.Forms.Cursors.Hand;
		E8BE35A6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E8BE35A6.Location = new System.Drawing.Point(164, 323);
		E8BE35A6.Name = "rbLanLuot";
		E8BE35A6.Size = new System.Drawing.Size(71, 20);
		E8BE35A6.TabIndex = 122;
		E8BE35A6.TabStop = true;
		E8BE35A6.Text = "Lâ\u0300n lươ\u0323t";
		E8BE35A6.UseVisualStyleBackColor = true;
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(31, 267);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(70, 16);
		label3.TabIndex = 119;
		label3.Text = "Loa\u0323i Proxy:";
		cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeProxy.Enabled = false;
		cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbTypeProxy.FormattingEnabled = true;
		cbbTypeProxy.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		cbbTypeProxy.Location = new System.Drawing.Point(164, 264);
		cbbTypeProxy.Name = "cbbTypeProxy";
		cbbTypeProxy.Size = new System.Drawing.Size(140, 24);
		cbbTypeProxy.TabIndex = 123;
		F32C6BA9.AutoSize = true;
		F32C6BA9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F32C6BA9.ForeColor = System.Drawing.Color.Red;
		F32C6BA9.Location = new System.Drawing.Point(179, 47);
		F32C6BA9.Name = "label4";
		F32C6BA9.Size = new System.Drawing.Size(265, 16);
		F32C6BA9.TabIndex = 119;
		F32C6BA9.Text = "(Đi\u0323nh da\u0323ng: IP:PORT, chưa hô\u0303 trơ\u0323 user pass)";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(477, 432);
		base.Controls.Add(lblStatus);
		base.Controls.Add(cbbTypeProxy);
		base.Controls.Add(E8BE35A6);
		base.Controls.Add(E82D5414);
		base.Controls.Add(ckbKhongNhapTaiKhoanDaCo);
		base.Controls.Add(FE1FAE23);
		base.Controls.Add(F5A329B5);
		base.Controls.Add(F32C6BA9);
		base.Controls.Add(label3);
		base.Controls.Add(E38C2636);
		base.Controls.Add(txtProxy);
		base.Controls.Add(label8);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(D33D5F9B);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fImportProxy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		D33D5F9B.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A516E182).EndInit();
		((System.ComponentModel.ISupportInitialize)FE1FAE23).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
