using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDBaiVietNhom : Form
{
	internal JObject jobject_0;

	internal string string_0;

	internal string string_1;

	internal string D5B1583D;

	internal int D092F2AE;

	internal static bool bool_0;

	internal IContainer icontainer_0 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal Panel panel1;

	internal NumericUpDown D593822D;

	internal NumericUpDown nudSoLuongBaiVietTo;

	internal NumericUpDown nudDelayFrom;

	internal NumericUpDown BD2D302D;

	internal TextBox B7840C17;

	internal Label EB1D839B;

	internal Label label3;

	internal Label label6;

	internal Label label4;

	internal Label label5;

	internal Label D504A591;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox EE229295;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal CheckBox BA0C8D12;

	internal CheckBox ckbInteract;

	internal CheckBox C5B97789;

	internal Label label49;

	internal NumericUpDown nudSoLuongNhomFrom;

	internal Label label68;

	internal Label label19;

	internal NumericUpDown nudSoLuongNhomTo;

	internal Label D203BB10;

	internal Panel C70F9C9B;

	internal RichTextBox txtComment;

	internal Button ECA17F13;

	internal Button btnUp;

	internal RadioButton BCBD5D32;

	internal RadioButton rbNganCachMoiDong;

	internal Label label9;

	internal Label label8;

	internal Label lblStatus;

	internal Panel FE348AA0;

	internal Button button2;

	internal TextBox CC84BE15;

	internal CheckBox ckbSendAnh;

	internal Button A380A430;

	public fHDBaiVietNhom(string C2B78139, int CF349507 = 0, string C709A69D = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = C2B78139;
		D5B1583D = C709A69D;
		D092F2AE = CF349507;
		string json = "";
		switch (CF349507)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDBaiVietNhom");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B7840C17.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(C709A69D);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			B7840C17.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void FE8CC231()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(D504A591);
		Language.smethod_1(label49);
		Language.smethod_1(D203BB10);
		Language.smethod_1(label68);
		Language.smethod_1(label19);
		Language.smethod_1(label3);
		Language.smethod_1(label4);
		Language.smethod_1(label5);
		Language.smethod_1(EB1D839B);
		Language.smethod_1(label6);
		Language.smethod_1(C5B97789);
		Language.smethod_1(ckbSendAnh);
		Language.smethod_1(button2);
		Language.smethod_1(BA0C8D12);
		Language.smethod_1(lblStatus);
		Language.smethod_1(A380A430);
		Language.smethod_1(label8);
		Language.smethod_1(btnAdd);
		Language.smethod_1(btnCancel);
	}

	private void fHDBaiVietNhom_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongNhomFrom.Value = Convert.ToInt32(jobject_0["nudSoLuongNhomFrom"]);
			nudSoLuongNhomTo.Value = Convert.ToInt32(jobject_0["nudSoLuongNhomTo"]);
			BD2D302D.Value = Convert.ToInt32(jobject_0["nudSoLuongBaiVietFrom"]);
			nudSoLuongBaiVietTo.Value = Convert.ToInt32(jobject_0["nudSoLuongBaiVietTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			D593822D.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			ckbInteract.Checked = Convert.ToBoolean(jobject_0["ckbInteract"]);
			C5B97789.Checked = Convert.ToBoolean(jobject_0["ckbShareWall"]);
			BA0C8D12.Checked = Convert.ToBoolean(jobject_0["ckbComment"]);
			txtComment.Text = jobject_0["txtComment"]!.ToString();
			if (Convert.ToInt32(jobject_0["typeNganCach"]) == 1)
			{
				BCBD5D32.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			ckbSendAnh.Checked = Convert.ToBoolean(jobject_0["ckbSendAnh"]);
			CC84BE15.Text = jobject_0["txtAnh"]!.ToString();
		}
		catch
		{
		}
		method_2();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (D092F2AE == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) != DialogResult.Yes)
			{
				return;
			}
			string text = B7840C17.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
				return;
			}
			if (BA0C8D12.Checked)
			{
				List<string> f1808BA = txtComment.Lines.ToList();
				f1808BA = Common.RemoveEmptyItems(f1808BA);
				if (f1808BA.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
					return;
				}
			}
			if (ckbSendAnh.Checked && CC84BE15.Text.Trim().Length == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng chọn folder ảnh!"), 3);
				return;
			}
			JSON_Settings f72FAFBC = new JSON_Settings();
			f72FAFBC.GetValue("nudSoLuongNhomFrom", nudSoLuongNhomFrom.Value);
			f72FAFBC.GetValue("nudSoLuongNhomTo", nudSoLuongNhomTo.Value);
			f72FAFBC.GetValue("nudSoLuongBaiVietFrom", BD2D302D.Value);
			f72FAFBC.GetValue("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
			f72FAFBC.GetValue("nudDelayTo", D593822D.Value);
			f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
			f72FAFBC.GetValue("ckbShareWall", C5B97789.Checked);
			f72FAFBC.GetValue("ckbComment", BA0C8D12.Checked);
			f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
			int num = 0;
			if (BCBD5D32.Checked)
			{
				num = 1;
			}
			f72FAFBC.GetValue("typeNganCach", num);
			f72FAFBC.GetValue("ckbSendAnh", ckbSendAnh.Checked);
			f72FAFBC.GetValue("txtAnh", (object)CC84BE15.Text.Trim());
			string d9253C2E = f72FAFBC.C71A4EA4();
			if (Class123.smethod_12(string_0, text, string_1, d9253C2E))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
		else
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) != DialogResult.Yes)
			{
				return;
			}
			string text2 = B7840C17.Text.Trim();
			if (text2 == "")
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
				return;
			}
			if (BA0C8D12.Checked)
			{
				List<string> f1808BA2 = txtComment.Lines.ToList();
				f1808BA2 = Common.RemoveEmptyItems(f1808BA2);
				if (f1808BA2.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
					return;
				}
			}
			if (ckbSendAnh.Checked && CC84BE15.Text.Trim().Length == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng chọn folder ảnh!"), 3);
				return;
			}
			JSON_Settings f72FAFBC2 = new JSON_Settings();
			f72FAFBC2.GetValue("nudSoLuongNhomFrom", nudSoLuongNhomFrom.Value);
			f72FAFBC2.GetValue("nudSoLuongNhomTo", nudSoLuongNhomTo.Value);
			f72FAFBC2.GetValue("nudSoLuongBaiVietFrom", BD2D302D.Value);
			f72FAFBC2.GetValue("nudSoLuongBaiVietTo", nudSoLuongBaiVietTo.Value);
			f72FAFBC2.GetValue("nudDelayFrom", nudDelayFrom.Value);
			f72FAFBC2.GetValue("nudDelayTo", D593822D.Value);
			f72FAFBC2.GetValue("ckbInteract", ckbInteract.Checked);
			f72FAFBC2.GetValue("ckbShareWall", C5B97789.Checked);
			f72FAFBC2.GetValue("ckbComment", BA0C8D12.Checked);
			f72FAFBC2.GetValue("txtComment", (object)txtComment.Text.Trim());
			int num2 = 0;
			if (BCBD5D32.Checked)
			{
				num2 = 1;
			}
			f72FAFBC2.GetValue("typeNganCach", num2);
			f72FAFBC2.GetValue("ckbSendAnh", ckbSendAnh.Checked);
			f72FAFBC2.GetValue("txtAnh", (object)CC84BE15.Text.Trim());
			string string_ = f72FAFBC2.C71A4EA4();
			if (Class123.smethod_14(D5B1583D, text2, string_))
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

	private void method_0(object sender, EventArgs e)
	{
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!rbNganCachMoiDong.Checked) ? txtComment.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtComment.Lines.ToList());
			list = Common.RemoveEmptyItems(list);
			lblStatus.Text = string.Format(Language.GetValue("Nội dung bình luận ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_2()
	{
		method_3(null, null);
		E9300706(null, null);
		ckbSendAnh_CheckedChanged(null, null);
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void E9300706(object sender, EventArgs e)
	{
		C70F9C9B.Enabled = BA0C8D12.Checked;
	}

	private void E307C501(object sender, EventArgs e)
	{
		method_1();
	}

	private void BCBD5D32_CheckedChanged(object sender, EventArgs e)
	{
		method_1();
	}

	private void ECA17F13_Click(object sender, EventArgs e)
	{
		C70F9C9B.Height = 207;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		C70F9C9B.Height = 163;
	}

	private void EE229295_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			ECA17F13.Visible = true;
		}
	}

	private void ckbSendAnh_CheckedChanged(object sender, EventArgs e)
	{
		FE348AA0.Enabled = ckbSendAnh.Checked;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		CC84BE15.Text = Common.F68F9C11();
	}

	private void F8BA2514(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên của người đăng bài!"));
	}

	protected override void Dispose(bool D18A0E89)
	{
		if (D18A0E89 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D18A0E89);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBaiVietNhom));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		EE229295 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		FE348AA0 = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		CC84BE15 = new System.Windows.Forms.TextBox();
		ckbSendAnh = new System.Windows.Forms.CheckBox();
		C70F9C9B = new System.Windows.Forms.Panel();
		A380A430 = new System.Windows.Forms.Button();
		txtComment = new System.Windows.Forms.RichTextBox();
		ECA17F13 = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		BCBD5D32 = new System.Windows.Forms.RadioButton();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		label49 = new System.Windows.Forms.Label();
		nudSoLuongNhomFrom = new System.Windows.Forms.NumericUpDown();
		label68 = new System.Windows.Forms.Label();
		label19 = new System.Windows.Forms.Label();
		nudSoLuongNhomTo = new System.Windows.Forms.NumericUpDown();
		D203BB10 = new System.Windows.Forms.Label();
		BA0C8D12 = new System.Windows.Forms.CheckBox();
		C5B97789 = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		D593822D = new System.Windows.Forms.NumericUpDown();
		nudSoLuongBaiVietTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		BD2D302D = new System.Windows.Forms.NumericUpDown();
		B7840C17 = new System.Windows.Forms.TextBox();
		EB1D839B = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		D504A591 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)EE229295).BeginInit();
		panel1.SuspendLayout();
		FE348AA0.SuspendLayout();
		C70F9C9B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongNhomFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongNhomTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)D593822D).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)BD2D302D).BeginInit();
		bunifuCards1.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(680, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Bài viết Nhóm";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(EE229295);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(680, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(649, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		EE229295.Cursor = System.Windows.Forms.Cursors.Default;
		EE229295.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		EE229295.Location = new System.Drawing.Point(3, 2);
		EE229295.Name = "pictureBox1";
		EE229295.Size = new System.Drawing.Size(34, 27);
		EE229295.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		EE229295.TabIndex = 76;
		EE229295.TabStop = false;
		EE229295.Click += new System.EventHandler(EE229295_Click);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(FE348AA0);
		panel1.Controls.Add(ckbSendAnh);
		panel1.Controls.Add(C70F9C9B);
		panel1.Controls.Add(label49);
		panel1.Controls.Add(nudSoLuongNhomFrom);
		panel1.Controls.Add(label68);
		panel1.Controls.Add(label19);
		panel1.Controls.Add(nudSoLuongNhomTo);
		panel1.Controls.Add(D203BB10);
		panel1.Controls.Add(BA0C8D12);
		panel1.Controls.Add(C5B97789);
		panel1.Controls.Add(ckbInteract);
		panel1.Controls.Add(D593822D);
		panel1.Controls.Add(nudSoLuongBaiVietTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(BD2D302D);
		panel1.Controls.Add(B7840C17);
		panel1.Controls.Add(EB1D839B);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(D504A591);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(683, 308);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		FE348AA0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FE348AA0.Controls.Add(button2);
		FE348AA0.Controls.Add(CC84BE15);
		FE348AA0.Enabled = false;
		FE348AA0.Location = new System.Drawing.Point(48, 217);
		FE348AA0.Name = "plAnh";
		FE348AA0.Size = new System.Drawing.Size(281, 31);
		FE348AA0.TabIndex = 164;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.Location = new System.Drawing.Point(215, 2);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(61, 25);
		button2.TabIndex = 156;
		button2.Text = "Chọn";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		CC84BE15.Location = new System.Drawing.Point(3, 3);
		CC84BE15.Name = "txtAnh";
		CC84BE15.Size = new System.Drawing.Size(206, 23);
		CC84BE15.TabIndex = 155;
		ckbSendAnh.AutoSize = true;
		ckbSendAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbSendAnh.Location = new System.Drawing.Point(30, 195);
		ckbSendAnh.Name = "ckbSendAnh";
		ckbSendAnh.Size = new System.Drawing.Size(104, 20);
		ckbSendAnh.TabIndex = 163;
		ckbSendAnh.Text = "Bình luận ảnh";
		ckbSendAnh.UseVisualStyleBackColor = true;
		ckbSendAnh.CheckedChanged += new System.EventHandler(ckbSendAnh_CheckedChanged);
		C70F9C9B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C70F9C9B.Controls.Add(A380A430);
		C70F9C9B.Controls.Add(txtComment);
		C70F9C9B.Controls.Add(ECA17F13);
		C70F9C9B.Controls.Add(btnUp);
		C70F9C9B.Controls.Add(BCBD5D32);
		C70F9C9B.Controls.Add(rbNganCachMoiDong);
		C70F9C9B.Controls.Add(label9);
		C70F9C9B.Controls.Add(label8);
		C70F9C9B.Controls.Add(lblStatus);
		C70F9C9B.Location = new System.Drawing.Point(369, 84);
		C70F9C9B.Name = "plComment";
		C70F9C9B.Size = new System.Drawing.Size(281, 163);
		C70F9C9B.TabIndex = 106;
		A380A430.Cursor = System.Windows.Forms.Cursors.Help;
		A380A430.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A380A430.Location = new System.Drawing.Point(199, 2);
		A380A430.Name = "button3";
		A380A430.Size = new System.Drawing.Size(23, 23);
		A380A430.TabIndex = 165;
		A380A430.Text = "?";
		A380A430.UseVisualStyleBackColor = true;
		A380A430.Click += new System.EventHandler(F8BA2514);
		txtComment.Location = new System.Drawing.Point(7, 27);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(266, 111);
		txtComment.TabIndex = 106;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		ECA17F13.BackgroundImage = Resource.Bitmap_91;
		ECA17F13.Cursor = System.Windows.Forms.Cursors.Hand;
		ECA17F13.Location = new System.Drawing.Point(224, -1);
		ECA17F13.Name = "btnDown";
		ECA17F13.Size = new System.Drawing.Size(25, 25);
		ECA17F13.TabIndex = 7;
		ECA17F13.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		ECA17F13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		ECA17F13.Visible = false;
		ECA17F13.Click += new System.EventHandler(ECA17F13_Click);
		btnUp.BackgroundImage = Resource.Bitmap_73;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.Location = new System.Drawing.Point(255, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 7;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Visible = false;
		btnUp.Click += new System.EventHandler(btnUp_Click);
		BCBD5D32.AutoSize = true;
		BCBD5D32.Cursor = System.Windows.Forms.Cursors.Hand;
		BCBD5D32.Location = new System.Drawing.Point(69, 182);
		BCBD5D32.Name = "rbNganCachKyTu";
		BCBD5D32.Size = new System.Drawing.Size(203, 20);
		BCBD5D32.TabIndex = 6;
		BCBD5D32.Text = "Các nội dung ngăn cách bởi \"|\"";
		BCBD5D32.UseVisualStyleBackColor = true;
		BCBD5D32.CheckedChanged += new System.EventHandler(BCBD5D32_CheckedChanged);
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(69, 161);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(171, 20);
		rbNganCachMoiDong.TabIndex = 5;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += new System.EventHandler(E307C501);
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(4, 161);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(65, 16);
		label9.TabIndex = 4;
		label9.Text = "Tùy chọn:";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(4, 141);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(266, 16);
		label8.TabIndex = 0;
		label8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(140, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(27, 81);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(100, 16);
		label49.TabIndex = 92;
		label49.Text = "Sô\u0301 lươ\u0323ng nhóm:";
		nudSoLuongNhomFrom.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongNhomFrom.Location = new System.Drawing.Point(135, 79);
		nudSoLuongNhomFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongNhomFrom.Name = "nudSoLuongNhomFrom";
		nudSoLuongNhomFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongNhomFrom.TabIndex = 1;
		nudSoLuongNhomFrom.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		label68.AutoSize = true;
		label68.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label68.Location = new System.Drawing.Point(293, 81);
		label68.Name = "label68";
		label68.Size = new System.Drawing.Size(40, 16);
		label68.TabIndex = 99;
		label68.Text = "nhóm";
		label19.AutoSize = true;
		label19.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label19.Location = new System.Drawing.Point(27, 112);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(86, 16);
		label19.TabIndex = 101;
		label19.Text = "Sô\u0301 ba\u0300i/nhóm:";
		nudSoLuongNhomTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongNhomTo.Location = new System.Drawing.Point(232, 79);
		nudSoLuongNhomTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongNhomTo.Name = "nudSoLuongNhomTo";
		nudSoLuongNhomTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongNhomTo.TabIndex = 2;
		nudSoLuongNhomTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		D203BB10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D203BB10.Location = new System.Drawing.Point(197, 81);
		D203BB10.Name = "label66";
		D203BB10.Size = new System.Drawing.Size(29, 16);
		D203BB10.TabIndex = 105;
		D203BB10.Text = "đê\u0301n";
		D203BB10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		BA0C8D12.AutoSize = true;
		BA0C8D12.Cursor = System.Windows.Forms.Cursors.Hand;
		BA0C8D12.Location = new System.Drawing.Point(369, 62);
		BA0C8D12.Name = "ckbComment";
		BA0C8D12.Size = new System.Drawing.Size(128, 20);
		BA0C8D12.TabIndex = 9;
		BA0C8D12.Text = "Bi\u0300nh luâ\u0323n văn bản";
		BA0C8D12.UseVisualStyleBackColor = true;
		BA0C8D12.CheckedChanged += new System.EventHandler(E9300706);
		C5B97789.AutoSize = true;
		C5B97789.Cursor = System.Windows.Forms.Cursors.Hand;
		C5B97789.Location = new System.Drawing.Point(135, 171);
		C5B97789.Name = "ckbShareWall";
		C5B97789.Size = new System.Drawing.Size(123, 20);
		C5B97789.TabIndex = 8;
		C5B97789.Text = "Chia sẻ về tường";
		C5B97789.UseVisualStyleBackColor = true;
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(30, 171);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(49, 20);
		ckbInteract.TabIndex = 7;
		ckbInteract.Text = "Like";
		ckbInteract.UseVisualStyleBackColor = true;
		D593822D.Location = new System.Drawing.Point(232, 140);
		D593822D.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		D593822D.Name = "nudDelayTo";
		D593822D.Size = new System.Drawing.Size(56, 23);
		D593822D.TabIndex = 6;
		nudSoLuongBaiVietTo.Location = new System.Drawing.Point(232, 110);
		nudSoLuongBaiVietTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongBaiVietTo.Name = "nudSoLuongBaiVietTo";
		nudSoLuongBaiVietTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongBaiVietTo.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(135, 140);
		nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		BD2D302D.Location = new System.Drawing.Point(135, 110);
		BD2D302D.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		BD2D302D.Name = "nudSoLuongBaiVietFrom";
		BD2D302D.Size = new System.Drawing.Size(56, 23);
		BD2D302D.TabIndex = 3;
		B7840C17.Location = new System.Drawing.Point(135, 49);
		B7840C17.Name = "txtTenHanhDong";
		B7840C17.Size = new System.Drawing.Size(194, 23);
		B7840C17.TabIndex = 0;
		EB1D839B.Location = new System.Drawing.Point(197, 142);
		EB1D839B.Name = "label7";
		EB1D839B.Size = new System.Drawing.Size(29, 16);
		EB1D839B.TabIndex = 38;
		EB1D839B.Text = "đê\u0301n";
		EB1D839B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Location = new System.Drawing.Point(197, 112);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(293, 142);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(293, 112);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(25, 16);
		label4.TabIndex = 35;
		label4.Text = "ba\u0300i";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 142);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(90, 16);
		label5.TabIndex = 34;
		label5.Text = "Thơ\u0300i gian chơ\u0300:";
		D504A591.AutoSize = true;
		D504A591.Location = new System.Drawing.Point(27, 52);
		D504A591.Name = "label1";
		D504A591.Size = new System.Drawing.Size(99, 16);
		D504A591.TabIndex = 31;
		D504A591.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(351, 263);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(244, 263);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 11;
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
		bunifuCards1.Size = new System.Drawing.Size(680, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(683, 308);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBaiVietNhom_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)EE229295).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		FE348AA0.ResumeLayout(false);
		FE348AA0.PerformLayout();
		C70F9C9B.ResumeLayout(false);
		C70F9C9B.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongNhomFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongNhomTo).EndInit();
		((System.ComponentModel.ISupportInitialize)D593822D).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongBaiVietTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)BD2D302D).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
