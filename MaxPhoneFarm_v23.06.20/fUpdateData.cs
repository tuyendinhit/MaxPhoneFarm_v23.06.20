using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fUpdateData : Form
{
	internal fMain D2A714BD;

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal BunifuCustomLabel DC2D439F;

	internal Button btnMinimize;

	internal ComboBox cbbTypeUpdate;

	internal Label DFAFE12D;

	internal TextBox txbData;

	internal Label label2;

	internal Button btnCancel;

	internal Button CB15E6B2;

	internal PictureBox D1832D0B;

	internal Label C3979DA9;

	internal ComboBox EFBE8E3A;

	public fUpdateData(fMain B5B01E33, string AB91CC2B)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		D2A714BD = B5B01E33;
		cbbTypeUpdate.Text = AB91CC2B;
		EFBE8E3A.SelectedIndex = 0;
	}

	private void method_0()
	{
		Language.smethod_1(DC2D439F);
		Language.smethod_1(DFAFE12D);
		Language.smethod_1(label2);
		Language.smethod_1(C3979DA9);
		Language.smethod_1(CB15E6B2);
		Language.smethod_1(btnCancel);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D481F001(object sender, EventArgs e)
	{
		Close();
	}

	private void A10AC18C(object sender, EventArgs e)
	{
		try
		{
			bool flag = false;
			if (txbData.Text.Equals("") || txbData.Text.Equals("|"))
			{
				if (MessageBoxHelper.smethod_1(string.Format(Language.GetValue("Ba\u0323n co\u0301 chă\u0301c muô\u0301n xo\u0301a dư\u0303 liê\u0323u của {0} tài khoản?"), D2A714BD.method_109())) == DialogResult.Yes)
				{
					flag = true;
				}
			}
			else if (MessageBoxHelper.smethod_1(string.Format(Language.GetValue("Ba\u0323n co\u0301 chă\u0301c muô\u0301n câ\u0323p nhâ\u0323t dư\u0303 liê\u0323u của {0} tài khoản?"), D2A714BD.method_109())) == DialogResult.Yes)
			{
				flag = true;
			}
			if (!flag)
			{
				return;
			}
			List<string> list = new List<string>();
			string text = txbData.Text;
			for (int i = 0; i < D2A714BD.dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(D2A714BD.dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list.Add(D2A714BD.method_117(i, "cId"));
				}
			}
			string text2 = cbbTypeUpdate.Text;
			string text3 = text2;
			switch (HashString.DA8CEBAB(text3))
			{
			case 267393898u:
			{
				if (!(text3 == "Notes") || !CommonSQL.FE347784(list, "ghiChu", text))
				{
					break;
				}
				for (int k = 0; k < D2A714BD.dtgvAcc.Rows.Count; k++)
				{
					if (Convert.ToBoolean(D2A714BD.dtgvAcc.Rows[k].Cells["cChose"].Value))
					{
						D2A714BD.SetCellAccount(k, "cGhiChu", text);
					}
				}
				break;
			}
			case 96026087u:
			{
				if (!(text3 == "Mail|pass"))
				{
					break;
				}
				if (text.Split('|').Length != 2)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p la\u0323i đi\u0323nh da\u0323ng Mail|Pass Mail!"), 3);
					return;
				}
				if (!CommonSQL.smethod_10(list, "email|passmail", text))
				{
					break;
				}
				for (int m = 0; m < D2A714BD.dtgvAcc.Rows.Count; m++)
				{
					if (Convert.ToBoolean(D2A714BD.dtgvAcc.Rows[m].Cells["cChose"].Value))
					{
						D2A714BD.SetCellAccount(m, "cEmail", text.Split('|')[0]);
						D2A714BD.SetCellAccount(m, "cPassMail", text.Split('|')[1]);
					}
				}
				break;
			}
			case 976575442u:
			{
				if (!(text3 == "Token") || !CommonSQL.FE347784(list, "token", text))
				{
					break;
				}
				for (int num3 = 0; num3 < D2A714BD.dtgvAcc.Rows.Count; num3++)
				{
					if (Convert.ToBoolean(D2A714BD.dtgvAcc.Rows[num3].Cells["cChose"].Value))
					{
						D2A714BD.SetCellAccount(num3, "cToken", text);
					}
				}
				break;
			}
			case 750979128u:
			{
				if (!(text3 == "Password") || !CommonSQL.FE347784(list, "pass", text))
				{
					break;
				}
				for (int num2 = 0; num2 < D2A714BD.dtgvAcc.Rows.Count; num2++)
				{
					if (Convert.ToBoolean(D2A714BD.dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						D2A714BD.SetCellAccount(num2, "cPassword", text);
					}
				}
				break;
			}
			case 2249983736u:
			{
				if (!(text3 == "2FA") || !CommonSQL.FE347784(list, "fa2", text))
				{
					break;
				}
				for (int l = 0; l < D2A714BD.dtgvAcc.Rows.Count; l++)
				{
					if (Convert.ToBoolean(D2A714BD.dtgvAcc.Rows[l].Cells["cChose"].Value))
					{
						D2A714BD.SetCellAccount(l, "cFa2", text);
					}
				}
				break;
			}
			case 1335761915u:
			{
				if (!(text3 == "Proxy"))
				{
					break;
				}
				int selectedIndex = EFBE8E3A.SelectedIndex;
				string text4 = ((text == "") ? "" : (text + "*" + selectedIndex));
				if (!CommonSQL.FE347784(list, "proxy", text4))
				{
					break;
				}
				for (int num = 0; num < D2A714BD.dtgvAcc.Rows.Count; num++)
				{
					if (Convert.ToBoolean(D2A714BD.dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						D2A714BD.SetCellAccount(num, "cProxy", text4);
					}
				}
				break;
			}
			case 3646757383u:
			{
				if (!(text3 == "Useragent") || !CommonSQL.FE347784(list, "useragent", text))
				{
					break;
				}
				for (int num4 = 0; num4 < D2A714BD.dtgvAcc.Rows.Count; num4++)
				{
					if (Convert.ToBoolean(D2A714BD.dtgvAcc.Rows[num4].Cells["cChose"].Value))
					{
						D2A714BD.SetCellAccount(num4, "cUseragent", text);
					}
				}
				break;
			}
			case 3243292492u:
			{
				if (!(text3 == "Birthday") || !CommonSQL.FE347784(list, "birthday", text))
				{
					break;
				}
				for (int n = 0; n < D2A714BD.dtgvAcc.Rows.Count; n++)
				{
					if (Convert.ToBoolean(D2A714BD.dtgvAcc.Rows[n].Cells["cChose"].Value))
					{
						D2A714BD.SetCellAccount(n, "cBirthday", text);
					}
				}
				break;
			}
			case 3183131359u:
			{
				if (!(text3 == "Cookie") || !CommonSQL.FE347784(list, "cookie1", text))
				{
					break;
				}
				for (int j = 0; j < D2A714BD.dtgvAcc.Rows.Count; j++)
				{
					if (Convert.ToBoolean(D2A714BD.dtgvAcc.Rows[j].Cells["cChose"].Value))
					{
						D2A714BD.SetCellAccount(j, "cCookies", text);
					}
				}
				break;
			}
			}
			Close();
		}
		catch
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lòng thử lại sau!"), 2);
		}
	}

	private void DB2DA800(object sender, EventArgs e)
	{
		bool visible = cbbTypeUpdate.Text == "Proxy";
		C3979DA9.Visible = visible;
		EFBE8E3A.Visible = visible;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUpdateData));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		btnMinimize = new System.Windows.Forms.Button();
		D1832D0B = new System.Windows.Forms.PictureBox();
		DC2D439F = new Bunifu.Framework.UI.BunifuCustomLabel();
		cbbTypeUpdate = new System.Windows.Forms.ComboBox();
		DFAFE12D = new System.Windows.Forms.Label();
		txbData = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		CB15E6B2 = new System.Windows.Forms.Button();
		C3979DA9 = new System.Windows.Forms.Label();
		EFBE8E3A = new System.Windows.Forms.ComboBox();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D1832D0B).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(416, 38);
		bunifuCards1.TabIndex = 12;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(D1832D0B);
		pnlHeader.Controls.Add(DC2D439F);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(416, 32);
		pnlHeader.TabIndex = 9;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(382, -1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		D1832D0B.Cursor = System.Windows.Forms.Cursors.Default;
		D1832D0B.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		D1832D0B.Location = new System.Drawing.Point(3, 1);
		D1832D0B.Name = "pictureBox1";
		D1832D0B.Size = new System.Drawing.Size(34, 27);
		D1832D0B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		D1832D0B.TabIndex = 79;
		D1832D0B.TabStop = false;
		DC2D439F.BackColor = System.Drawing.Color.Transparent;
		DC2D439F.Dock = System.Windows.Forms.DockStyle.Fill;
		DC2D439F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DC2D439F.ForeColor = System.Drawing.Color.Black;
		DC2D439F.Location = new System.Drawing.Point(0, 0);
		DC2D439F.Name = "bunifuCustomLabel1";
		DC2D439F.Size = new System.Drawing.Size(416, 32);
		DC2D439F.TabIndex = 12;
		DC2D439F.Text = "Cập nhật dữ liệu";
		DC2D439F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		cbbTypeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeUpdate.FormattingEnabled = true;
		cbbTypeUpdate.ItemHeight = 16;
		cbbTypeUpdate.Items.AddRange(new object[9] { "Token", "Cookie", "Password", "Mail|pass", "2FA", "Birthday", "Useragent", "Proxy", "Notes" });
		cbbTypeUpdate.Location = new System.Drawing.Point(146, 48);
		cbbTypeUpdate.Name = "cbbTypeUpdate";
		cbbTypeUpdate.Size = new System.Drawing.Size(238, 24);
		cbbTypeUpdate.TabIndex = 13;
		cbbTypeUpdate.SelectedIndexChanged += new System.EventHandler(DB2DA800);
		DFAFE12D.AutoSize = true;
		DFAFE12D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DFAFE12D.Location = new System.Drawing.Point(34, 51);
		DFAFE12D.Name = "label1";
		DFAFE12D.Size = new System.Drawing.Size(105, 16);
		DFAFE12D.TabIndex = 14;
		DFAFE12D.Text = "Dữ liệu cập nhật:";
		txbData.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txbData.Location = new System.Drawing.Point(146, 79);
		txbData.Name = "txbData";
		txbData.Size = new System.Drawing.Size(238, 23);
		txbData.TabIndex = 15;
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(34, 82);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(84, 16);
		label2.TabIndex = 16;
		label2.Text = "Nhập dữ liệu:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(209, 145);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 18;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(D481F001);
		CB15E6B2.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		CB15E6B2.Cursor = System.Windows.Forms.Cursors.Hand;
		CB15E6B2.FlatAppearance.BorderSize = 0;
		CB15E6B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CB15E6B2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CB15E6B2.ForeColor = System.Drawing.Color.White;
		CB15E6B2.Location = new System.Drawing.Point(111, 145);
		CB15E6B2.Name = "btnAdd";
		CB15E6B2.Size = new System.Drawing.Size(92, 29);
		CB15E6B2.TabIndex = 17;
		CB15E6B2.Text = "Lưu";
		CB15E6B2.UseVisualStyleBackColor = false;
		CB15E6B2.Click += new System.EventHandler(A10AC18C);
		C3979DA9.AutoSize = true;
		C3979DA9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C3979DA9.Location = new System.Drawing.Point(34, 111);
		C3979DA9.Name = "label3";
		C3979DA9.Size = new System.Drawing.Size(70, 16);
		C3979DA9.TabIndex = 16;
		C3979DA9.Text = "Loại proxy:";
		EFBE8E3A.Cursor = System.Windows.Forms.Cursors.Hand;
		EFBE8E3A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		EFBE8E3A.Enabled = false;
		EFBE8E3A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EFBE8E3A.FormattingEnabled = true;
		EFBE8E3A.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		EFBE8E3A.Location = new System.Drawing.Point(146, 108);
		EFBE8E3A.Name = "cbbTypeProxy";
		EFBE8E3A.Size = new System.Drawing.Size(130, 24);
		EFBE8E3A.TabIndex = 124;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(416, 188);
		base.Controls.Add(EFBE8E3A);
		base.Controls.Add(btnCancel);
		base.Controls.Add(CB15E6B2);
		base.Controls.Add(C3979DA9);
		base.Controls.Add(label2);
		base.Controls.Add(txbData);
		base.Controls.Add(DFAFE12D);
		base.Controls.Add(cbbTypeUpdate);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fUpdateData";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fUpdateData";
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)D1832D0B).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
