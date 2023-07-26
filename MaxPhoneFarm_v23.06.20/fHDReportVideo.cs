using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDReportVideo : Form
{
	internal JSON_Settings F90F5B0B = null;

	internal string string_0;

	internal string FA10D1BA;

	internal string string_1;

	internal int int_0;

	internal static bool D114959C;

	internal Dictionary<string, List<string>> dictionary_0 = new Dictionary<string, List<string>>
	{
		{
			"Nudity",
			new List<string> { "Adult nudity", "Sexually suggestive", "Sexual activity", "Sexual exploitation", "Sexual services", "Involves a child" }
		},
		{
			"Violence",
			new List<string> { "Graphic violence", "Death or severe injury", "Violent threat", "Animal abuse", "Sexual violence", "Something Else" }
		},
		{
			"Harassment",
			new List<string> { "Me" }
		},
		{
			"Hate speech",
			new List<string> { "Race or ethnicity", "National origin", "Religious affiliation", "Social caste", "Select Sexual orientation", "Sex or gender identity", "Disability or disease", "Something else" }
		},
		{
			"Something else",
			new List<string> { "Intellectual property" }
		}
	};

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal TextBox txtTenHanhDong;

	internal Label D5B1C7B5;

	internal Label EDADF607;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button C893D424;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel DFAC6F1C;

	internal TextBox D33E5626;

	internal ComboBox cbbNoiDungCon;

	internal ComboBox cbbNoiDungCha;

	internal Label D617E398;

	public fHDReportVideo(string FE8A3805, int BDAF4B33 = 0, string CC82B788 = "")
	{
		InitializeComponent();
		D114959C = false;
		string_0 = FE8A3805;
		string_1 = CC82B788;
		int_0 = BDAF4B33;
		string text = base.Name.Substring(1);
		string text2 = "Report";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (BDAF4B33)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			FA10D1BA = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(CC82B788);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F90F5B0B = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void F6083B83(object sender, EventArgs e)
	{
		try
		{
			B8A3B088();
			D33E5626.Text = F90F5B0B.GetValue("txtLinkVideo");
			cbbNoiDungCha.Text = F90F5B0B.GetValue("cbbNoiDungCha");
			cbbNoiDungCha_SelectedIndexChanged(null, null);
			cbbNoiDungCon.Text = F90F5B0B.GetValue("cbbNoiDungCon");
		}
		catch
		{
		}
	}

	private void B8A3B088()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < dictionary_0.Keys.Count; i++)
		{
			dictionary.Add(i.ToString(), dictionary_0.Keys.ElementAt(i));
		}
		cbbNoiDungCha.DataSource = new BindingSource(dictionary, null);
		cbbNoiDungCha.DisplayMember = "Value";
		cbbNoiDungCha.ValueMember = "Key";
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (string item in dictionary_0[cbbNoiDungCha.Text])
		{
			dictionary.Add(item, item);
		}
		cbbNoiDungCon.DataSource = new BindingSource(dictionary, null);
		cbbNoiDungCon.DisplayMember = "Value";
		cbbNoiDungCon.ValueMember = "Key";
	}

	private void C893D424_Click(object sender, EventArgs e)
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
		f72FAFBC.GetValue("txtLinkVideo", (object)D33E5626.Text);
		f72FAFBC.GetValue("cbbNoiDungCha", (object)cbbNoiDungCha.Text);
		f72FAFBC.GetValue("cbbNoiDungCon", (object)cbbNoiDungCon.Text);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, FA10D1BA, text2))
				{
					D114959C = true;
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
				D114959C = true;
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

	private void A0A95B1C(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void cbbNoiDungCha_SelectedIndexChanged(object sender, EventArgs e)
	{
		string key = cbbNoiDungCha.Text;
		if (dictionary_0.ContainsKey(key) && dictionary_0[key].Count > 0)
		{
			cbbNoiDungCon.Visible = true;
			method_0();
			cbbNoiDungCon.SelectedIndex = 0;
		}
		else
		{
			cbbNoiDungCon.Visible = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDReportVideo));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		DFAC6F1C = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		C893D424 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		D33E5626 = new System.Windows.Forms.TextBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		D5B1C7B5 = new System.Windows.Forms.Label();
		EDADF607 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		cbbNoiDungCon = new System.Windows.Forms.ComboBox();
		cbbNoiDungCha = new System.Windows.Forms.ComboBox();
		D617E398 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DFAC6F1C;
		bunifuDragControl_0.Vertical = true;
		DFAC6F1C.BackColor = System.Drawing.Color.Transparent;
		DFAC6F1C.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DFAC6F1C.Dock = System.Windows.Forms.DockStyle.Fill;
		DFAC6F1C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DFAC6F1C.ForeColor = System.Drawing.Color.Black;
		DFAC6F1C.Location = new System.Drawing.Point(0, 0);
		DFAC6F1C.Name = "bunifuCustomLabel1";
		DFAC6F1C.Size = new System.Drawing.Size(359, 31);
		DFAC6F1C.TabIndex = 12;
		DFAC6F1C.Text = "Cấu hình Report video";
		DFAC6F1C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(C893D424);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(DFAC6F1C);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		C893D424.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		C893D424.Cursor = System.Windows.Forms.Cursors.Hand;
		C893D424.FlatAppearance.BorderSize = 0;
		C893D424.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C893D424.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C893D424.ForeColor = System.Drawing.Color.White;
		C893D424.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		C893D424.Location = new System.Drawing.Point(328, 1);
		C893D424.Name = "button1";
		C893D424.Size = new System.Drawing.Size(30, 30);
		C893D424.TabIndex = 77;
		C893D424.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C893D424.UseVisualStyleBackColor = true;
		C893D424.Click += new System.EventHandler(C893D424_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(cbbNoiDungCon);
		panel1.Controls.Add(cbbNoiDungCha);
		panel1.Controls.Add(D617E398);
		panel1.Controls.Add(D33E5626);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(D5B1C7B5);
		panel1.Controls.Add(EDADF607);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 227);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(A0A95B1C);
		D33E5626.Location = new System.Drawing.Point(132, 79);
		D33E5626.Name = "txtLinkVideo";
		D33E5626.Size = new System.Drawing.Size(194, 23);
		D33E5626.TabIndex = 0;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		D5B1C7B5.AutoSize = true;
		D5B1C7B5.Location = new System.Drawing.Point(27, 82);
		D5B1C7B5.Name = "label5";
		D5B1C7B5.Size = new System.Drawing.Size(68, 16);
		D5B1C7B5.TabIndex = 34;
		D5B1C7B5.Text = "Link video:";
		EDADF607.AutoSize = true;
		EDADF607.Location = new System.Drawing.Point(27, 52);
		EDADF607.Name = "label1";
		EDADF607.Size = new System.Drawing.Size(98, 16);
		EDADF607.TabIndex = 31;
		EDADF607.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 182);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
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
		btnAdd.Location = new System.Drawing.Point(82, 182);
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
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		cbbNoiDungCon.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbNoiDungCon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbNoiDungCon.DropDownWidth = 300;
		cbbNoiDungCon.FormattingEnabled = true;
		cbbNoiDungCon.Location = new System.Drawing.Point(132, 138);
		cbbNoiDungCon.Name = "cbbNoiDungCon";
		cbbNoiDungCon.Size = new System.Drawing.Size(194, 24);
		cbbNoiDungCon.TabIndex = 38;
		cbbNoiDungCha.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbNoiDungCha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbNoiDungCha.DropDownWidth = 300;
		cbbNoiDungCha.FormattingEnabled = true;
		cbbNoiDungCha.Location = new System.Drawing.Point(132, 108);
		cbbNoiDungCha.Name = "cbbNoiDungCha";
		cbbNoiDungCha.Size = new System.Drawing.Size(194, 24);
		cbbNoiDungCha.TabIndex = 37;
		cbbNoiDungCha.SelectedIndexChanged += new System.EventHandler(cbbNoiDungCha_SelectedIndexChanged);
		D617E398.AutoSize = true;
		D617E398.Location = new System.Drawing.Point(27, 111);
		D617E398.Name = "label2";
		D617E398.Size = new System.Drawing.Size(94, 16);
		D617E398.TabIndex = 36;
		D617E398.Text = "Chọn nội dung:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 227);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDReportVideo";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(F6083B83);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
