using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fImportUseragent : Form
{
	internal IContainer AE0D64BE = null;

	internal BunifuCards EC28CF1D;

	internal Panel pnlHeader;

	internal BunifuCustomLabel AE989DB3;

	internal Button CE127BA0;

	internal Button E2A58118;

	internal Button btnAdd;

	internal BunifuDragControl bunifuDragControl_0;

	internal PictureBox C114BC84;

	internal Label label8;

	internal Label lblStatus;

	internal RichTextBox txtUseragent;

	internal Label label1;

	internal NumericUpDown nudTaiKhoanPerUa;

	internal CheckBox C205799E;

	internal Label label2;

	internal RadioButton rbNgauNhien;

	internal RadioButton rbLanLuot;

	public fImportUseragent()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void CE127BA0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		Language.smethod_1(AE989DB3);
		Language.smethod_1(lblStatus);
		Language.smethod_1(label1);
		Language.smethod_1(label8);
		Language.smethod_1(label2);
		Language.smethod_1(rbLanLuot);
		Language.smethod_1(rbNgauNhien);
		Language.smethod_1(C205799E);
		Language.smethod_1(btnAdd);
		Language.smethod_1(E2A58118);
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUseragent.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			List<string> list = new List<string>();
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p thêm Useragent!"), 3);
				return;
			}
			int num = Convert.ToInt32(nudTaiKhoanPerUa.Value);
			for (int i = 0; i < f1808BA.Count; i++)
			{
				for (int j = 0; j < num; j++)
				{
					list.Add(f1808BA[i]);
				}
			}
			if (rbNgauNhien.Checked)
			{
				list = Common.F78FD80F(list);
			}
			Queue<string> queue = new Queue<string>(list);
			for (int k = 0; k < fMain.fMain_0.dtgvAcc.Rows.Count; k++)
			{
				if (Convert.ToBoolean(fMain.fMain_0.method_117(k, "cChose")) && (!(fMain.fMain_0.method_117(k, "cUseragent") != "") || !C205799E.Checked))
				{
					if (queue.Count == 0)
					{
						break;
					}
					string text = queue.Dequeue().Replace("'", "''");
					if (CommonSQL.UpdateFieldToAccount(fMain.fMain_0.method_117(k, "cId"), "useragent", text))
					{
						fMain.fMain_0.SetCellAccount(k, "cUseragent", text);
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

	private void B193DC04(object sender, EventArgs e)
	{
		Close();
	}

	private void C58F4532(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			btnAdd_Click(null, null);
		}
	}

	private void txtUseragent_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUseragent.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatus.Text = string.Format(Language.GetValue("Danh sa\u0301ch Useragent ({0}):"), f1808BA.Count);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && AE0D64BE != null)
		{
			AE0D64BE.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		AE0D64BE = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportUseragent));
		EC28CF1D = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		C114BC84 = new System.Windows.Forms.PictureBox();
		CE127BA0 = new System.Windows.Forms.Button();
		AE989DB3 = new Bunifu.Framework.UI.BunifuCustomLabel();
		E2A58118 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(AE0D64BE);
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		txtUseragent = new System.Windows.Forms.RichTextBox();
		label1 = new System.Windows.Forms.Label();
		nudTaiKhoanPerUa = new System.Windows.Forms.NumericUpDown();
		C205799E = new System.Windows.Forms.CheckBox();
		label2 = new System.Windows.Forms.Label();
		rbNgauNhien = new System.Windows.Forms.RadioButton();
		rbLanLuot = new System.Windows.Forms.RadioButton();
		EC28CF1D.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C114BC84).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTaiKhoanPerUa).BeginInit();
		SuspendLayout();
		EC28CF1D.BackColor = System.Drawing.Color.White;
		EC28CF1D.BorderRadius = 0;
		EC28CF1D.BottomSahddow = true;
		EC28CF1D.color = System.Drawing.Color.SaddleBrown;
		EC28CF1D.Controls.Add(pnlHeader);
		EC28CF1D.Dock = System.Windows.Forms.DockStyle.Top;
		EC28CF1D.LeftSahddow = false;
		EC28CF1D.Location = new System.Drawing.Point(0, 0);
		EC28CF1D.Name = "bunifuCards1";
		EC28CF1D.RightSahddow = true;
		EC28CF1D.ShadowDepth = 20;
		EC28CF1D.Size = new System.Drawing.Size(477, 38);
		EC28CF1D.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(C114BC84);
		pnlHeader.Controls.Add(CE127BA0);
		pnlHeader.Controls.Add(AE989DB3);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(477, 32);
		pnlHeader.TabIndex = 9;
		C114BC84.Cursor = System.Windows.Forms.Cursors.Default;
		C114BC84.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		C114BC84.Location = new System.Drawing.Point(4, 1);
		C114BC84.Name = "pictureBox1";
		C114BC84.Size = new System.Drawing.Size(34, 27);
		C114BC84.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		C114BC84.TabIndex = 77;
		C114BC84.TabStop = false;
		CE127BA0.Cursor = System.Windows.Forms.Cursors.Hand;
		CE127BA0.Dock = System.Windows.Forms.DockStyle.Right;
		CE127BA0.FlatAppearance.BorderSize = 0;
		CE127BA0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CE127BA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CE127BA0.ForeColor = System.Drawing.Color.White;
		CE127BA0.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		CE127BA0.Location = new System.Drawing.Point(445, 0);
		CE127BA0.Name = "btnMinimize";
		CE127BA0.Size = new System.Drawing.Size(32, 32);
		CE127BA0.TabIndex = 9;
		CE127BA0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		CE127BA0.UseVisualStyleBackColor = true;
		CE127BA0.Click += new System.EventHandler(CE127BA0_Click);
		AE989DB3.BackColor = System.Drawing.Color.Transparent;
		AE989DB3.Cursor = System.Windows.Forms.Cursors.SizeAll;
		AE989DB3.Dock = System.Windows.Forms.DockStyle.Fill;
		AE989DB3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AE989DB3.ForeColor = System.Drawing.Color.Black;
		AE989DB3.Location = new System.Drawing.Point(0, 0);
		AE989DB3.Name = "bunifuCustomLabel1";
		AE989DB3.Size = new System.Drawing.Size(477, 32);
		AE989DB3.TabIndex = 1;
		AE989DB3.Text = "Nhâ\u0323p Useragent";
		AE989DB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E2A58118.BackColor = System.Drawing.Color.Maroon;
		E2A58118.Cursor = System.Windows.Forms.Cursors.Hand;
		E2A58118.FlatAppearance.BorderSize = 0;
		E2A58118.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E2A58118.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E2A58118.ForeColor = System.Drawing.Color.White;
		E2A58118.Location = new System.Drawing.Point(245, 342);
		E2A58118.Name = "btnCancel";
		E2A58118.Size = new System.Drawing.Size(92, 29);
		E2A58118.TabIndex = 4;
		E2A58118.Text = "Đo\u0301ng";
		E2A58118.UseVisualStyleBackColor = false;
		E2A58118.Click += new System.EventHandler(B193DC04);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(136, 342);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Xa\u0301c nhâ\u0323n";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = AE989DB3;
		bunifuDragControl_0.Vertical = true;
		label8.AutoSize = true;
		label8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label8.Location = new System.Drawing.Point(301, 252);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(141, 16);
		label8.TabIndex = 5;
		label8.Text = "(Mỗi useragent 1 dòng)";
		lblStatus.AutoSize = true;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.Location = new System.Drawing.Point(30, 47);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(154, 16);
		lblStatus.TabIndex = 6;
		lblStatus.Text = "Danh sa\u0301ch Useragent (0):";
		txtUseragent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUseragent.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtUseragent.Location = new System.Drawing.Point(34, 66);
		txtUseragent.Name = "txtUseragent";
		txtUseragent.Size = new System.Drawing.Size(409, 181);
		txtUseragent.TabIndex = 118;
		txtUseragent.Text = "";
		txtUseragent.WordWrap = false;
		txtUseragent.TextChanged += new System.EventHandler(txtUseragent_TextChanged);
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(31, 252);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(146, 16);
		label1.TabIndex = 119;
		label1.Text = "Sô\u0301 ta\u0300i khoa\u0309n/Useragent:";
		nudTaiKhoanPerUa.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		nudTaiKhoanPerUa.Location = new System.Drawing.Point(184, 250);
		nudTaiKhoanPerUa.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTaiKhoanPerUa.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudTaiKhoanPerUa.Name = "nudTaiKhoanPerUa";
		nudTaiKhoanPerUa.Size = new System.Drawing.Size(69, 23);
		nudTaiKhoanPerUa.TabIndex = 120;
		nudTaiKhoanPerUa.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		C205799E.AutoSize = true;
		C205799E.Cursor = System.Windows.Forms.Cursors.Hand;
		C205799E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C205799E.Location = new System.Drawing.Point(33, 303);
		C205799E.Name = "ckbKhongNhapTaiKhoanDaCo";
		C205799E.Size = new System.Drawing.Size(310, 20);
		C205799E.TabIndex = 121;
		C205799E.Text = "Không nhâ\u0323p va\u0300o như\u0303ng ta\u0300i khoa\u0309n đa\u0303 co\u0301 Useragent";
		C205799E.UseVisualStyleBackColor = true;
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(30, 279);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(158, 16);
		label2.TabIndex = 119;
		label2.Text = "Tu\u0300y cho\u0323n nhâ\u0323p Useragent:";
		rbNgauNhien.AutoSize = true;
		rbNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNgauNhien.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		rbNgauNhien.Location = new System.Drawing.Point(274, 277);
		rbNgauNhien.Name = "rbNgauNhien";
		rbNgauNhien.Size = new System.Drawing.Size(89, 20);
		rbNgauNhien.TabIndex = 122;
		rbNgauNhien.Text = "Ngâ\u0303u nhiên";
		rbNgauNhien.UseVisualStyleBackColor = true;
		rbLanLuot.AutoSize = true;
		rbLanLuot.Checked = true;
		rbLanLuot.Cursor = System.Windows.Forms.Cursors.Hand;
		rbLanLuot.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		rbLanLuot.Location = new System.Drawing.Point(184, 277);
		rbLanLuot.Name = "rbLanLuot";
		rbLanLuot.Size = new System.Drawing.Size(71, 20);
		rbLanLuot.TabIndex = 122;
		rbLanLuot.TabStop = true;
		rbLanLuot.Text = "Lâ\u0300n lươ\u0323t";
		rbLanLuot.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(477, 388);
		base.Controls.Add(rbLanLuot);
		base.Controls.Add(rbNgauNhien);
		base.Controls.Add(C205799E);
		base.Controls.Add(nudTaiKhoanPerUa);
		base.Controls.Add(label2);
		base.Controls.Add(label1);
		base.Controls.Add(txtUseragent);
		base.Controls.Add(label8);
		base.Controls.Add(lblStatus);
		base.Controls.Add(E2A58118);
		base.Controls.Add(btnAdd);
		base.Controls.Add(EC28CF1D);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fImportUseragent";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		EC28CF1D.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)C114BC84).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTaiKhoanPerUa).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
