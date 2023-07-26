using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDReport : Form
{
	internal JSON_Settings f72FAFBC_0 = null;

	internal string string_0;

	internal string B2B9F42A;

	internal string string_1;

	internal int int_0;

	internal static bool bool_0;

	internal Dictionary<string, List<string>> dictionary_0 = new Dictionary<string, List<string>>
	{
		{
			"Hate speech",
			new List<string>()
		},
		{
			"Nudity or Sexual Content",
			new List<string> { "Adult nudity", "Sexually suggestive", "Sexual activity", "Sexual exploitation", "Sexual services", "Involves a child" }
		},
		{
			"Violence",
			new List<string> { "Credible threat of violence", "Theft or vandalism", "Suicide or self harm", "Graphic violence" }
		},
		{
			"Harassment",
			new List<string> { "It's me", "It's someone else" }
		},
		{
			"Unauthorized sales",
			new List<string> { "Promotes Drug Use", "Selling or purchasing guns, weapons, drugs", "Selling Prescription Pharmaceuticals", "Promotes Online Gambling", "Something else" }
		},
		{
			"Pretending to be something",
			new List<string> { "Me", "Celebrity", "A friend", "A business" }
		},
		{
			"Pretending to be someone",
			new List<string> { "Me", "Celebrity", "A friend", "A business" }
		},
		{
			"Fraud or scam",
			new List<string> { "Asking me for financial information", "Other" }
		},
		{
			"Fake account",
			new List<string>()
		},
		{
			"Fake name",
			new List<string>()
		},
		{
			"Intellectual property",
			new List<string>()
		},
		{
			"I can't access my account",
			new List<string>()
		},
		{
			"Something else",
			new List<string>()
		},
		{
			"Harassment or bullying",
			new List<string>()
		},
		{
			"Posting inappropriate things",
			new List<string> { "Submit without post" }
		},
		{
			"Fake page",
			new List<string>()
		},
		{
			"False information",
			new List<string> { "Health", "Politics", "Social issue", "Something else" }
		}
	};

	internal IContainer DB302394 = null;

	internal BunifuDragControl C711B9AC;

	internal BunifuDragControl bunifuDragControl_0;

	internal Panel panel1;

	internal TextBox B2B1E80E;

	internal Label A5BC06A6;

	internal Label C035CD86;

	internal Button EB364187;

	internal Button DE3CBBA1;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button D334528B;

	internal PictureBox pictureBox1;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal TextBox txtId;

	internal ComboBox A32AE61D;

	internal ComboBox cbbNoiDungCha;

	internal Label label2;

	public fHDReport(string A23C0097, int B49DED33 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = A23C0097;
		string_1 = string_2;
		int_0 = B49DED33;
		string text = base.Name.Substring(1);
		string text2 = "Report";
		if (Class123.C7BE863B("", text).Rows.Count == 0)
		{
			C09C8EAB.F40D043B.EA84A08B("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string d399C = "";
		switch (B49DED33)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", text);
			d399C = dataTable2.Rows[0]["CauHinh"].ToString();
			B2B9F42A = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B2B1E80E.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(string_2);
			d399C = dataTable.Rows[0]["CauHinh"].ToString();
			DE3CBBA1.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			B2B1E80E.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		f72FAFBC_0 = new JSON_Settings(d399C, D7BE7F11: true);
		Language.SetLanguage(this);
	}

	private void fHDReport_Load(object sender, EventArgs e)
	{
		try
		{
			method_0();
			txtId.Text = f72FAFBC_0.GetValue("txtId");
			cbbNoiDungCha.Text = f72FAFBC_0.GetValue("cbbNoiDungCha", "Random");
			FF8B59AD(null, null);
			A32AE61D.Text = f72FAFBC_0.GetValue("cbbNoiDungCon", "Random");
		}
		catch
		{
		}
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("-1", "Random");
		for (int i = 0; i < dictionary_0.Keys.Count; i++)
		{
			dictionary.Add(i.ToString(), dictionary_0.Keys.ElementAt(i));
		}
		cbbNoiDungCha.DataSource = new BindingSource(dictionary, null);
		cbbNoiDungCha.DisplayMember = "Value";
		cbbNoiDungCha.ValueMember = "Key";
	}

	private void AABDB025()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("Random", "Random");
		foreach (string item in dictionary_0[cbbNoiDungCha.Text])
		{
			dictionary.Add(item, item);
		}
		A32AE61D.DataSource = new BindingSource(dictionary, null);
		A32AE61D.DisplayMember = "Value";
		A32AE61D.ValueMember = "Key";
	}

	private void D334528B_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DE3CBBA1_Click(object sender, EventArgs e)
	{
		string text = B2B1E80E.Text.Trim();
		if (text == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("txtId", (object)txtId.Text);
		f72FAFBC.GetValue("cbbNoiDungCha", (object)cbbNoiDungCha.Text);
		f72FAFBC.GetValue("cbbNoiDungCon", (object)A32AE61D.Text);
		string text2 = f72FAFBC.C71A4EA4();
		if (int_0 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class123.smethod_12(string_0, text, B2B9F42A, text2))
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

	private void EB364187_Click(object sender, EventArgs e)
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

	private void FF8B59AD(object sender, EventArgs e)
	{
		string key = cbbNoiDungCha.Text;
		if (dictionary_0.ContainsKey(key) && dictionary_0[key].Count > 0)
		{
			A32AE61D.Visible = true;
			AABDB025();
			A32AE61D.SelectedIndex = 0;
		}
		else
		{
			A32AE61D.Visible = false;
		}
	}

	protected override void Dispose(bool BF3E879A)
	{
		if (BF3E879A && DB302394 != null)
		{
			DB302394.Dispose();
		}
		base.Dispose(BF3E879A);
	}

	private void InitializeComponent()
	{
		DB302394 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDReport));
		C711B9AC = new Bunifu.Framework.UI.BunifuDragControl(DB302394);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(DB302394);
		pnlHeader = new System.Windows.Forms.Panel();
		D334528B = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		txtId = new System.Windows.Forms.TextBox();
		B2B1E80E = new System.Windows.Forms.TextBox();
		A5BC06A6 = new System.Windows.Forms.Label();
		C035CD86 = new System.Windows.Forms.Label();
		EB364187 = new System.Windows.Forms.Button();
		DE3CBBA1 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		label2 = new System.Windows.Forms.Label();
		cbbNoiDungCha = new System.Windows.Forms.ComboBox();
		A32AE61D = new System.Windows.Forms.ComboBox();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		C711B9AC.Fixed = true;
		C711B9AC.Horizontal = true;
		C711B9AC.TargetControl = bunifuCustomLabel1;
		C711B9AC.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Report";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(D334528B);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		D334528B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		D334528B.Cursor = System.Windows.Forms.Cursors.Hand;
		D334528B.FlatAppearance.BorderSize = 0;
		D334528B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D334528B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D334528B.ForeColor = System.Drawing.Color.White;
		D334528B.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		D334528B.Location = new System.Drawing.Point(328, 1);
		D334528B.Name = "button1";
		D334528B.Size = new System.Drawing.Size(30, 30);
		D334528B.TabIndex = 77;
		D334528B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		D334528B.UseVisualStyleBackColor = true;
		D334528B.Click += new System.EventHandler(D334528B_Click);
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
		panel1.Controls.Add(A32AE61D);
		panel1.Controls.Add(cbbNoiDungCha);
		panel1.Controls.Add(txtId);
		panel1.Controls.Add(B2B1E80E);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(A5BC06A6);
		panel1.Controls.Add(C035CD86);
		panel1.Controls.Add(EB364187);
		panel1.Controls.Add(DE3CBBA1);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 229);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		txtId.Location = new System.Drawing.Point(132, 79);
		txtId.Name = "txtId";
		txtId.Size = new System.Drawing.Size(194, 23);
		txtId.TabIndex = 0;
		B2B1E80E.Location = new System.Drawing.Point(132, 49);
		B2B1E80E.Name = "txtTenHanhDong";
		B2B1E80E.Size = new System.Drawing.Size(194, 23);
		B2B1E80E.TabIndex = 0;
		A5BC06A6.AutoSize = true;
		A5BC06A6.Location = new System.Drawing.Point(27, 82);
		A5BC06A6.Name = "label5";
		A5BC06A6.Size = new System.Drawing.Size(96, 16);
		A5BC06A6.TabIndex = 34;
		A5BC06A6.Text = "Id Profile/Page:";
		C035CD86.AutoSize = true;
		C035CD86.Location = new System.Drawing.Point(27, 52);
		C035CD86.Name = "label1";
		C035CD86.Size = new System.Drawing.Size(98, 16);
		C035CD86.TabIndex = 31;
		C035CD86.Text = "Tên ha\u0300nh đô\u0323ng:";
		EB364187.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		EB364187.BackColor = System.Drawing.Color.Maroon;
		EB364187.Cursor = System.Windows.Forms.Cursors.Hand;
		EB364187.FlatAppearance.BorderSize = 0;
		EB364187.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EB364187.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EB364187.ForeColor = System.Drawing.Color.White;
		EB364187.Location = new System.Drawing.Point(189, 184);
		EB364187.Name = "btnCancel";
		EB364187.Size = new System.Drawing.Size(92, 29);
		EB364187.TabIndex = 10;
		EB364187.Text = "Đóng";
		EB364187.UseVisualStyleBackColor = false;
		EB364187.Click += new System.EventHandler(EB364187_Click);
		DE3CBBA1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		DE3CBBA1.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		DE3CBBA1.Cursor = System.Windows.Forms.Cursors.Hand;
		DE3CBBA1.FlatAppearance.BorderSize = 0;
		DE3CBBA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DE3CBBA1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DE3CBBA1.ForeColor = System.Drawing.Color.White;
		DE3CBBA1.Location = new System.Drawing.Point(82, 184);
		DE3CBBA1.Name = "btnAdd";
		DE3CBBA1.Size = new System.Drawing.Size(92, 29);
		DE3CBBA1.TabIndex = 9;
		DE3CBBA1.Text = "Thêm";
		DE3CBBA1.UseVisualStyleBackColor = false;
		DE3CBBA1.Click += new System.EventHandler(DE3CBBA1_Click);
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
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 113);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(94, 16);
		label2.TabIndex = 34;
		label2.Text = "Chọn nội dung:";
		cbbNoiDungCha.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbNoiDungCha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbNoiDungCha.DropDownWidth = 300;
		cbbNoiDungCha.FormattingEnabled = true;
		cbbNoiDungCha.Location = new System.Drawing.Point(132, 110);
		cbbNoiDungCha.Name = "cbbNoiDungCha";
		cbbNoiDungCha.Size = new System.Drawing.Size(194, 24);
		cbbNoiDungCha.TabIndex = 35;
		cbbNoiDungCha.SelectedIndexChanged += new System.EventHandler(FF8B59AD);
		A32AE61D.Cursor = System.Windows.Forms.Cursors.Hand;
		A32AE61D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		A32AE61D.DropDownWidth = 300;
		A32AE61D.FormattingEnabled = true;
		A32AE61D.Location = new System.Drawing.Point(132, 140);
		A32AE61D.Name = "cbbNoiDungCon";
		A32AE61D.Size = new System.Drawing.Size(194, 24);
		A32AE61D.TabIndex = 35;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 229);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDReport";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDReport_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
