using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDBaiVietFanpage : Form
{
	internal JObject jobject_0;

	internal string B39ED42A;

	internal string CC30741D;

	internal string string_0;

	internal int AA3AAE98;

	internal static bool bool_0;

	internal IContainer C0B55FB2 = null;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl F58F8837;

	internal Panel CF0F0381;

	internal NumericUpDown nudDelayTo;

	internal NumericUpDown D2B3E7BA;

	internal NumericUpDown nudDelayFrom;

	internal NumericUpDown D7199EA8;

	internal TextBox txtTenHanhDong;

	internal Label AB071AB4;

	internal Label label3;

	internal Label label6;

	internal Label label4;

	internal Label label5;

	internal Label label1;

	internal Button btnCancel;

	internal Button C99EB723;

	internal BunifuCards B891C3AF;

	internal Panel pnlHeader;

	internal Button button1;

	internal PictureBox CDB36626;

	internal BunifuCustomLabel CBACC53C;

	internal Panel plComment;

	internal Label lblStatus;

	internal CheckBox ckbComment;

	internal CheckBox ckbInteract;

	internal CheckBox ckbShareWall;

	internal Label label49;

	internal NumericUpDown C03FB2BB;

	internal Label FD26E62F;

	internal Label C81BB6AF;

	internal NumericUpDown nudSoLuongPageTo;

	internal Label label66;

	internal Label label2;

	internal Label lblStatusUid;

	internal RichTextBox txtUid;

	internal CheckBox ckbLikePage;

	internal Panel F7ACF1BE;

	internal Label label9;

	internal NumericUpDown nudViewFrom;

	internal Label label10;

	internal Label EB0DCBA7;

	internal NumericUpDown nudViewTo;

	internal CheckBox F10F923F;

	internal RichTextBox txtComment;

	internal Button btnDown;

	internal Button B7B0AAAC;

	internal RadioButton D49BFFBD;

	internal RadioButton rbNganCachMoiDong;

	internal Label AE0CED83;

	internal Label B8BD8FA8;

	internal Button FE232C0C;

	public fHDBaiVietFanpage(string string_1, int int_0 = 0, string AD11D204 = "")
	{
		InitializeComponent();
		bool_0 = false;
		B39ED42A = string_1;
		string_0 = AD11D204;
		AA3AAE98 = int_0;
		string json = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class123.C7BE863B("", "HDBaiVietFanpage");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			CC30741D = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = Language.GetValue(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class123.smethod_10(AD11D204);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			C99EB723.Text = Language.GetValue("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		jobject_0 = JObject.Parse(json);
		Language.SetLanguage(this);
	}

	private void fHDBaiVietFanpage_Load(object sender, EventArgs e)
	{
		try
		{
			C03FB2BB.Value = Convert.ToInt32(jobject_0["nudSoLuongPageFrom"]);
			nudSoLuongPageTo.Value = Convert.ToInt32(jobject_0["nudSoLuongPageTo"]);
			D7199EA8.Value = Convert.ToInt32(jobject_0["nudSoLuongBaiVietFrom"]);
			D2B3E7BA.Value = Convert.ToInt32(jobject_0["nudSoLuongBaiVietTo"]);
			nudDelayFrom.Value = Convert.ToInt32(jobject_0["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(jobject_0["nudDelayTo"]);
			txtUid.Text = jobject_0["txtUid"]!.ToString();
			ckbInteract.Checked = Convert.ToBoolean(jobject_0["ckbInteract"]);
			ckbShareWall.Checked = Convert.ToBoolean(jobject_0["ckbShareWall"]);
			ckbComment.Checked = Convert.ToBoolean(jobject_0["ckbComment"]);
			txtComment.Text = jobject_0["txtComment"]!.ToString();
			if (Convert.ToInt32(jobject_0["typeNganCach"]) == 1)
			{
				D49BFFBD.Checked = true;
			}
			else
			{
				rbNganCachMoiDong.Checked = true;
			}
			ckbLikePage.Checked = Convert.ToBoolean(jobject_0["ckbLikePage"]);
			F10F923F.Checked = Convert.ToBoolean(jobject_0["ckbAutoPlayVideo"]);
			nudViewFrom.Value = Convert.ToInt32(jobject_0["nudViewFrom"]);
			nudViewTo.Value = Convert.ToInt32(jobject_0["nudViewTo"]);
		}
		catch
		{
		}
		E09DD1A1();
	}

	private void B30F26B9(object sender, EventArgs e)
	{
		Close();
	}

	private void C99EB723_Click(object sender, EventArgs e)
	{
		if (AA3AAE98 == 0)
		{
			if (MessageBoxHelper.smethod_1(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) != DialogResult.Yes)
			{
				return;
			}
			string text = txtTenHanhDong.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
				return;
			}
			List<string> f1808BA = txtUid.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Id page!"), 3);
				return;
			}
			if (ckbComment.Checked)
			{
				f1808BA = txtComment.Lines.ToList();
				f1808BA = Common.RemoveEmptyItems(f1808BA);
				if (f1808BA.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
					return;
				}
			}
			JSON_Settings f72FAFBC = new JSON_Settings();
			f72FAFBC.GetValue("nudSoLuongPageFrom", C03FB2BB.Value);
			f72FAFBC.GetValue("nudSoLuongPageTo", nudSoLuongPageTo.Value);
			f72FAFBC.GetValue("nudSoLuongBaiVietFrom", D7199EA8.Value);
			f72FAFBC.GetValue("nudSoLuongBaiVietTo", D2B3E7BA.Value);
			f72FAFBC.GetValue("nudDelayFrom", nudDelayFrom.Value);
			f72FAFBC.GetValue("nudDelayTo", nudDelayTo.Value);
			f72FAFBC.GetValue("txtUid", (object)txtUid.Text.Trim());
			f72FAFBC.GetValue("ckbInteract", ckbInteract.Checked);
			f72FAFBC.GetValue("ckbShareWall", ckbShareWall.Checked);
			f72FAFBC.GetValue("ckbComment", ckbComment.Checked);
			f72FAFBC.GetValue("txtComment", (object)txtComment.Text.Trim());
			int num = 0;
			if (D49BFFBD.Checked)
			{
				num = 1;
			}
			f72FAFBC.GetValue("typeNganCach", num);
			f72FAFBC.GetValue("ckbLikePage", ckbLikePage.Checked);
			f72FAFBC.GetValue("ckbAutoPlayVideo", F10F923F.Checked);
			f72FAFBC.GetValue("nudViewFrom", nudViewFrom.Value);
			f72FAFBC.GetValue("nudViewTo", nudViewTo.Value);
			string d9253C2E = f72FAFBC.C71A4EA4();
			if (Class123.smethod_12(B39ED42A, text, CC30741D, d9253C2E))
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
			string text2 = txtTenHanhDong.Text.Trim();
			if (text2 == "")
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
				return;
			}
			List<string> f1808BA2 = txtUid.Lines.ToList();
			f1808BA2 = Common.RemoveEmptyItems(f1808BA2);
			if (f1808BA2.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p danh sa\u0301ch Id page!"), 3);
				return;
			}
			if (ckbComment.Checked)
			{
				f1808BA2 = txtComment.Lines.ToList();
				f1808BA2 = Common.RemoveEmptyItems(f1808BA2);
				if (f1808BA2.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng nhâ\u0323p nô\u0323i dung bi\u0300nh luâ\u0323n!"), 3);
					return;
				}
			}
			JSON_Settings f72FAFBC2 = new JSON_Settings();
			f72FAFBC2.GetValue("nudSoLuongPageFrom", C03FB2BB.Value);
			f72FAFBC2.GetValue("nudSoLuongPageTo", nudSoLuongPageTo.Value);
			f72FAFBC2.GetValue("nudSoLuongBaiVietFrom", D7199EA8.Value);
			f72FAFBC2.GetValue("nudSoLuongBaiVietTo", D2B3E7BA.Value);
			f72FAFBC2.GetValue("nudDelayFrom", nudDelayFrom.Value);
			f72FAFBC2.GetValue("nudDelayTo", nudDelayTo.Value);
			f72FAFBC2.GetValue("txtUid", (object)txtUid.Text.Trim());
			f72FAFBC2.GetValue("ckbInteract", ckbInteract.Checked);
			f72FAFBC2.GetValue("ckbShareWall", ckbShareWall.Checked);
			f72FAFBC2.GetValue("ckbComment", ckbComment.Checked);
			f72FAFBC2.GetValue("txtComment", (object)txtComment.Text.Trim());
			int num2 = 0;
			if (D49BFFBD.Checked)
			{
				num2 = 1;
			}
			f72FAFBC2.GetValue("typeNganCach", num2);
			f72FAFBC2.GetValue("ckbLikePage", ckbLikePage.Checked);
			f72FAFBC2.GetValue("ckbAutoPlayVideo", F10F923F.Checked);
			f72FAFBC2.GetValue("nudViewFrom", nudViewFrom.Value);
			f72FAFBC2.GetValue("nudViewTo", nudViewTo.Value);
			string string_ = f72FAFBC2.C71A4EA4();
			if (Class123.smethod_14(string_0, text2, string_))
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

	private void CA84388E(object sender, EventArgs e)
	{
		Close();
	}

	private void A6B422BC(object sender, PaintEventArgs e)
	{
		if (CF0F0381.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, CF0F0381.ClientSize.Width - num, CF0F0381.ClientSize.Height - num));
		}
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
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

	private void E09DD1A1()
	{
		method_1(null, null);
		ckbComment_CheckedChanged(null, null);
		F10F923F_CheckedChanged(null, null);
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void txtUid_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtUid.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblStatusUid.Text = string.Format(Language.GetValue("Danh sa\u0301ch Uid page cần tương ta\u0301c ({0}):"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void F10F923F_CheckedChanged(object sender, EventArgs e)
	{
		F7ACF1BE.Enabled = F10F923F.Checked;
	}

	private void btnDown_Click(object sender, EventArgs e)
	{
		plComment.Height = 206;
	}

	private void E223C7B1(object sender, EventArgs e)
	{
		plComment.Height = 164;
	}

	private void CDB36626_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			B7B0AAAC.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void DC2616AF(object sender, EventArgs e)
	{
		method_0();
	}

	private void AF3CA6A0(object sender, EventArgs e)
	{
		method_0();
	}

	private void FE232C0C_Click(object sender, EventArgs e)
	{
		MessageBoxHelper.Show(Language.GetValue("Có thể dùng [u] để thay thế tên page!"));
	}

	protected override void Dispose(bool A5186000)
	{
		if (A5186000 && C0B55FB2 != null)
		{
			C0B55FB2.Dispose();
		}
		base.Dispose(A5186000);
	}

	private void InitializeComponent()
	{
		C0B55FB2 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDBaiVietFanpage));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(C0B55FB2);
		CBACC53C = new Bunifu.Framework.UI.BunifuCustomLabel();
		F58F8837 = new Bunifu.Framework.UI.BunifuDragControl(C0B55FB2);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		CDB36626 = new System.Windows.Forms.PictureBox();
		CF0F0381 = new System.Windows.Forms.Panel();
		txtUid = new System.Windows.Forms.RichTextBox();
		label2 = new System.Windows.Forms.Label();
		lblStatusUid = new System.Windows.Forms.Label();
		label49 = new System.Windows.Forms.Label();
		C03FB2BB = new System.Windows.Forms.NumericUpDown();
		FD26E62F = new System.Windows.Forms.Label();
		C81BB6AF = new System.Windows.Forms.Label();
		nudSoLuongPageTo = new System.Windows.Forms.NumericUpDown();
		label66 = new System.Windows.Forms.Label();
		F7ACF1BE = new System.Windows.Forms.Panel();
		label9 = new System.Windows.Forms.Label();
		nudViewFrom = new System.Windows.Forms.NumericUpDown();
		label10 = new System.Windows.Forms.Label();
		EB0DCBA7 = new System.Windows.Forms.Label();
		nudViewTo = new System.Windows.Forms.NumericUpDown();
		plComment = new System.Windows.Forms.Panel();
		FE232C0C = new System.Windows.Forms.Button();
		txtComment = new System.Windows.Forms.RichTextBox();
		btnDown = new System.Windows.Forms.Button();
		B7B0AAAC = new System.Windows.Forms.Button();
		D49BFFBD = new System.Windows.Forms.RadioButton();
		rbNganCachMoiDong = new System.Windows.Forms.RadioButton();
		AE0CED83 = new System.Windows.Forms.Label();
		B8BD8FA8 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		ckbComment = new System.Windows.Forms.CheckBox();
		ckbShareWall = new System.Windows.Forms.CheckBox();
		ckbLikePage = new System.Windows.Forms.CheckBox();
		F10F923F = new System.Windows.Forms.CheckBox();
		ckbInteract = new System.Windows.Forms.CheckBox();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		D2B3E7BA = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		D7199EA8 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		AB071AB4 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		C99EB723 = new System.Windows.Forms.Button();
		B891C3AF = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)CDB36626).BeginInit();
		CF0F0381.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C03FB2BB).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongPageTo).BeginInit();
		F7ACF1BE.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudViewFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudViewTo).BeginInit();
		plComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)D2B3E7BA).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)D7199EA8).BeginInit();
		B891C3AF.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = CBACC53C;
		bunifuDragControl_0.Vertical = true;
		CBACC53C.BackColor = System.Drawing.Color.Transparent;
		CBACC53C.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CBACC53C.Dock = System.Windows.Forms.DockStyle.Fill;
		CBACC53C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CBACC53C.ForeColor = System.Drawing.Color.Black;
		CBACC53C.Location = new System.Drawing.Point(0, 0);
		CBACC53C.Name = "bunifuCustomLabel1";
		CBACC53C.Size = new System.Drawing.Size(680, 31);
		CBACC53C.TabIndex = 12;
		CBACC53C.Text = "Cấu hình Bài viết Fanpage";
		CBACC53C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F58F8837.Fixed = true;
		F58F8837.Horizontal = true;
		F58F8837.TargetControl = pnlHeader;
		F58F8837.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(CDB36626);
		pnlHeader.Controls.Add(CBACC53C);
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
		button1.Click += new System.EventHandler(B30F26B9);
		CDB36626.Cursor = System.Windows.Forms.Cursors.Default;
		CDB36626.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		CDB36626.Location = new System.Drawing.Point(3, 2);
		CDB36626.Name = "pictureBox1";
		CDB36626.Size = new System.Drawing.Size(34, 27);
		CDB36626.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		CDB36626.TabIndex = 76;
		CDB36626.TabStop = false;
		CDB36626.Click += new System.EventHandler(CDB36626_Click);
		CF0F0381.BackColor = System.Drawing.Color.White;
		CF0F0381.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		CF0F0381.Controls.Add(txtUid);
		CF0F0381.Controls.Add(label2);
		CF0F0381.Controls.Add(lblStatusUid);
		CF0F0381.Controls.Add(label49);
		CF0F0381.Controls.Add(C03FB2BB);
		CF0F0381.Controls.Add(FD26E62F);
		CF0F0381.Controls.Add(C81BB6AF);
		CF0F0381.Controls.Add(nudSoLuongPageTo);
		CF0F0381.Controls.Add(label66);
		CF0F0381.Controls.Add(F7ACF1BE);
		CF0F0381.Controls.Add(plComment);
		CF0F0381.Controls.Add(ckbComment);
		CF0F0381.Controls.Add(ckbShareWall);
		CF0F0381.Controls.Add(ckbLikePage);
		CF0F0381.Controls.Add(F10F923F);
		CF0F0381.Controls.Add(ckbInteract);
		CF0F0381.Controls.Add(nudDelayTo);
		CF0F0381.Controls.Add(D2B3E7BA);
		CF0F0381.Controls.Add(nudDelayFrom);
		CF0F0381.Controls.Add(D7199EA8);
		CF0F0381.Controls.Add(txtTenHanhDong);
		CF0F0381.Controls.Add(AB071AB4);
		CF0F0381.Controls.Add(label3);
		CF0F0381.Controls.Add(label6);
		CF0F0381.Controls.Add(label4);
		CF0F0381.Controls.Add(label5);
		CF0F0381.Controls.Add(label1);
		CF0F0381.Controls.Add(btnCancel);
		CF0F0381.Controls.Add(C99EB723);
		CF0F0381.Controls.Add(B891C3AF);
		CF0F0381.Cursor = System.Windows.Forms.Cursors.Arrow;
		CF0F0381.Dock = System.Windows.Forms.DockStyle.Fill;
		CF0F0381.Location = new System.Drawing.Point(0, 0);
		CF0F0381.Name = "panel1";
		CF0F0381.Size = new System.Drawing.Size(683, 427);
		CF0F0381.TabIndex = 0;
		CF0F0381.Paint += new System.Windows.Forms.PaintEventHandler(A6B422BC);
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(31, 186);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(299, 166);
		txtUid.TabIndex = 117;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(txtUid_TextChanged);
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(28, 356);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(103, 16);
		label2.TabIndex = 115;
		label2.Text = "(Mỗi Uid 1 dòng)";
		lblStatusUid.AutoSize = true;
		lblStatusUid.Location = new System.Drawing.Point(27, 166);
		lblStatusUid.Name = "lblStatusUid";
		lblStatusUid.Size = new System.Drawing.Size(229, 16);
		lblStatusUid.TabIndex = 116;
		lblStatusUid.Text = "Danh sa\u0301ch Uid page cần tương ta\u0301c (0):";
		label49.AutoSize = true;
		label49.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label49.Location = new System.Drawing.Point(27, 81);
		label49.Name = "label49";
		label49.Size = new System.Drawing.Size(96, 16);
		label49.TabIndex = 92;
		label49.Text = "Sô\u0301 lươ\u0323ng page:";
		C03FB2BB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C03FB2BB.Location = new System.Drawing.Point(135, 79);
		C03FB2BB.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		C03FB2BB.Name = "nudSoLuongPageFrom";
		C03FB2BB.Size = new System.Drawing.Size(56, 23);
		C03FB2BB.TabIndex = 1;
		C03FB2BB.Value = new decimal(new int[4] { 5, 0, 0, 0 });
		FD26E62F.AutoSize = true;
		FD26E62F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		FD26E62F.Location = new System.Drawing.Point(290, 81);
		FD26E62F.Name = "label68";
		FD26E62F.Size = new System.Drawing.Size(36, 16);
		FD26E62F.TabIndex = 99;
		FD26E62F.Text = "page";
		C81BB6AF.AutoSize = true;
		C81BB6AF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		C81BB6AF.Location = new System.Drawing.Point(27, 112);
		C81BB6AF.Name = "label19";
		C81BB6AF.Size = new System.Drawing.Size(106, 16);
		C81BB6AF.TabIndex = 101;
		C81BB6AF.Text = "Sô\u0301 ba\u0300i viết/page:";
		nudSoLuongPageTo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		nudSoLuongPageTo.Location = new System.Drawing.Point(232, 79);
		nudSoLuongPageTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongPageTo.Name = "nudSoLuongPageTo";
		nudSoLuongPageTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongPageTo.TabIndex = 2;
		nudSoLuongPageTo.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		label66.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label66.Location = new System.Drawing.Point(197, 81);
		label66.Name = "label66";
		label66.Size = new System.Drawing.Size(29, 16);
		label66.TabIndex = 105;
		label66.Text = "đê\u0301n";
		label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F7ACF1BE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F7ACF1BE.Controls.Add(label9);
		F7ACF1BE.Controls.Add(nudViewFrom);
		F7ACF1BE.Controls.Add(label10);
		F7ACF1BE.Controls.Add(EB0DCBA7);
		F7ACF1BE.Controls.Add(nudViewTo);
		F7ACF1BE.Location = new System.Drawing.Point(369, 76);
		F7ACF1BE.Name = "panel2";
		F7ACF1BE.Size = new System.Drawing.Size(281, 29);
		F7ACF1BE.TabIndex = 10;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(4, 5);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(94, 16);
		label9.TabIndex = 0;
		label9.Text = "Thơ\u0300i gian xem:";
		nudViewFrom.Location = new System.Drawing.Point(101, 2);
		nudViewFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudViewFrom.Name = "nudViewFrom";
		nudViewFrom.Size = new System.Drawing.Size(48, 23);
		nudViewFrom.TabIndex = 5;
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(241, 5);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(31, 16);
		label10.TabIndex = 36;
		label10.Text = "giây";
		EB0DCBA7.Location = new System.Drawing.Point(155, 4);
		EB0DCBA7.Name = "label11";
		EB0DCBA7.Size = new System.Drawing.Size(29, 16);
		EB0DCBA7.TabIndex = 38;
		EB0DCBA7.Text = "đê\u0301n";
		EB0DCBA7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudViewTo.Location = new System.Drawing.Point(190, 2);
		nudViewTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudViewTo.Name = "nudViewTo";
		nudViewTo.Size = new System.Drawing.Size(48, 23);
		nudViewTo.TabIndex = 6;
		plComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plComment.Controls.Add(FE232C0C);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(btnDown);
		plComment.Controls.Add(B7B0AAAC);
		plComment.Controls.Add(D49BFFBD);
		plComment.Controls.Add(rbNganCachMoiDong);
		plComment.Controls.Add(AE0CED83);
		plComment.Controls.Add(B8BD8FA8);
		plComment.Controls.Add(lblStatus);
		plComment.Location = new System.Drawing.Point(369, 188);
		plComment.Name = "plComment";
		plComment.Size = new System.Drawing.Size(281, 164);
		plComment.TabIndex = 10;
		FE232C0C.Cursor = System.Windows.Forms.Cursors.Help;
		FE232C0C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FE232C0C.Location = new System.Drawing.Point(199, 2);
		FE232C0C.Name = "button3";
		FE232C0C.Size = new System.Drawing.Size(23, 23);
		FE232C0C.TabIndex = 166;
		FE232C0C.Text = "?";
		FE232C0C.UseVisualStyleBackColor = true;
		FE232C0C.Click += new System.EventHandler(FE232C0C_Click);
		txtComment.Location = new System.Drawing.Point(6, 27);
		txtComment.Name = "txtComment";
		txtComment.Size = new System.Drawing.Size(266, 111);
		txtComment.TabIndex = 113;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += new System.EventHandler(txtComment_TextChanged);
		btnDown.BackgroundImage = Resource.Bitmap_91;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.Location = new System.Drawing.Point(224, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 111;
		btnDown.Visible = false;
		btnDown.Click += new System.EventHandler(btnDown_Click);
		B7B0AAAC.BackgroundImage = Resource.Bitmap_73;
		B7B0AAAC.Cursor = System.Windows.Forms.Cursors.Hand;
		B7B0AAAC.Location = new System.Drawing.Point(255, -1);
		B7B0AAAC.Name = "btnUp";
		B7B0AAAC.Size = new System.Drawing.Size(25, 25);
		B7B0AAAC.TabIndex = 112;
		B7B0AAAC.Visible = false;
		B7B0AAAC.Click += new System.EventHandler(E223C7B1);
		D49BFFBD.AutoSize = true;
		D49BFFBD.Cursor = System.Windows.Forms.Cursors.Hand;
		D49BFFBD.Location = new System.Drawing.Point(68, 182);
		D49BFFBD.Name = "rbNganCachKyTu";
		D49BFFBD.Size = new System.Drawing.Size(203, 20);
		D49BFFBD.TabIndex = 110;
		D49BFFBD.Text = "Các nội dung ngăn cách bởi \"|\"";
		D49BFFBD.UseVisualStyleBackColor = true;
		D49BFFBD.CheckedChanged += new System.EventHandler(AF3CA6A0);
		rbNganCachMoiDong.AutoSize = true;
		rbNganCachMoiDong.Checked = true;
		rbNganCachMoiDong.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachMoiDong.Location = new System.Drawing.Point(68, 161);
		rbNganCachMoiDong.Name = "rbNganCachMoiDong";
		rbNganCachMoiDong.Size = new System.Drawing.Size(171, 20);
		rbNganCachMoiDong.TabIndex = 109;
		rbNganCachMoiDong.TabStop = true;
		rbNganCachMoiDong.Text = "Mỗi dòng là một nội dung";
		rbNganCachMoiDong.UseVisualStyleBackColor = true;
		rbNganCachMoiDong.CheckedChanged += new System.EventHandler(DC2616AF);
		AE0CED83.AutoSize = true;
		AE0CED83.Location = new System.Drawing.Point(3, 161);
		AE0CED83.Name = "label8";
		AE0CED83.Size = new System.Drawing.Size(65, 16);
		AE0CED83.TabIndex = 108;
		AE0CED83.Text = "Tùy chọn:";
		B8BD8FA8.AutoSize = true;
		B8BD8FA8.Location = new System.Drawing.Point(3, 141);
		B8BD8FA8.Name = "label12";
		B8BD8FA8.Size = new System.Drawing.Size(266, 16);
		B8BD8FA8.TabIndex = 107;
		B8BD8FA8.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(3, 5);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(140, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Nội dung bình luận (0):";
		ckbComment.AutoSize = true;
		ckbComment.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbComment.Location = new System.Drawing.Point(351, 163);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new System.Drawing.Size(176, 20);
		ckbComment.TabIndex = 9;
		ckbComment.Text = "Tư\u0323 đô\u0323ng bi\u0300nh luâ\u0323n ba\u0300i viê\u0301t";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += new System.EventHandler(ckbComment_CheckedChanged);
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbShareWall.Location = new System.Drawing.Point(351, 137);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new System.Drawing.Size(168, 20);
		ckbShareWall.TabIndex = 8;
		ckbShareWall.Text = "Chia sẻ ba\u0300i viê\u0301t về tường";
		ckbShareWall.UseVisualStyleBackColor = true;
		ckbLikePage.AutoSize = true;
		ckbLikePage.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLikePage.Location = new System.Drawing.Point(351, 355);
		ckbLikePage.Name = "ckbLikePage";
		ckbLikePage.Size = new System.Drawing.Size(235, 20);
		ckbLikePage.TabIndex = 7;
		ckbLikePage.Text = "Like Fanpage sau khi tương ta\u0301c xong";
		ckbLikePage.UseVisualStyleBackColor = true;
		F10F923F.AutoSize = true;
		F10F923F.Cursor = System.Windows.Forms.Cursors.Hand;
		F10F923F.Location = new System.Drawing.Point(351, 50);
		F10F923F.Name = "ckbAutoPlayVideo";
		F10F923F.Size = new System.Drawing.Size(286, 20);
		F10F923F.TabIndex = 7;
		F10F923F.Text = "Tư\u0323 đô\u0323ng xem Video (Nê\u0301u ba\u0300i viê\u0301t chư\u0301a video)";
		F10F923F.UseVisualStyleBackColor = true;
		F10F923F.CheckedChanged += new System.EventHandler(F10F923F_CheckedChanged);
		ckbInteract.AutoSize = true;
		ckbInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbInteract.Location = new System.Drawing.Point(351, 111);
		ckbInteract.Name = "ckbInteract";
		ckbInteract.Size = new System.Drawing.Size(94, 20);
		ckbInteract.TabIndex = 7;
		ckbInteract.Text = "Like ba\u0300i viê\u0301t";
		ckbInteract.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new System.Drawing.Point(232, 140);
		nudDelayTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 6;
		D2B3E7BA.Location = new System.Drawing.Point(232, 110);
		D2B3E7BA.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		D2B3E7BA.Name = "nudSoLuongBaiVietTo";
		D2B3E7BA.Size = new System.Drawing.Size(56, 23);
		D2B3E7BA.TabIndex = 4;
		nudDelayFrom.Location = new System.Drawing.Point(135, 140);
		nudDelayFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		D7199EA8.Location = new System.Drawing.Point(135, 110);
		D7199EA8.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		D7199EA8.Name = "nudSoLuongBaiVietFrom";
		D7199EA8.Size = new System.Drawing.Size(56, 23);
		D7199EA8.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(135, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(195, 23);
		txtTenHanhDong.TabIndex = 0;
		AB071AB4.Location = new System.Drawing.Point(197, 142);
		AB071AB4.Name = "label7";
		AB071AB4.Size = new System.Drawing.Size(29, 16);
		AB071AB4.TabIndex = 38;
		AB071AB4.Text = "đê\u0301n";
		AB071AB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Location = new System.Drawing.Point(197, 112);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(290, 142);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(31, 16);
		label6.TabIndex = 36;
		label6.Text = "giây";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(290, 112);
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
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(99, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(351, 383);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 12;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(CA84388E);
		C99EB723.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		C99EB723.Cursor = System.Windows.Forms.Cursors.Hand;
		C99EB723.FlatAppearance.BorderSize = 0;
		C99EB723.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C99EB723.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C99EB723.ForeColor = System.Drawing.Color.White;
		C99EB723.Location = new System.Drawing.Point(244, 383);
		C99EB723.Name = "btnAdd";
		C99EB723.Size = new System.Drawing.Size(92, 29);
		C99EB723.TabIndex = 11;
		C99EB723.Text = "Thêm";
		C99EB723.UseVisualStyleBackColor = false;
		C99EB723.Click += new System.EventHandler(C99EB723_Click);
		B891C3AF.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B891C3AF.BackColor = System.Drawing.Color.White;
		B891C3AF.BorderRadius = 0;
		B891C3AF.BottomSahddow = true;
		B891C3AF.color = System.Drawing.Color.DarkViolet;
		B891C3AF.Controls.Add(pnlHeader);
		B891C3AF.LeftSahddow = false;
		B891C3AF.Location = new System.Drawing.Point(1, 0);
		B891C3AF.Name = "bunifuCards1";
		B891C3AF.RightSahddow = true;
		B891C3AF.ShadowDepth = 20;
		B891C3AF.Size = new System.Drawing.Size(680, 37);
		B891C3AF.TabIndex = 28;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(683, 427);
		base.Controls.Add(CF0F0381);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBaiVietFanpage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDBaiVietFanpage_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)CDB36626).EndInit();
		CF0F0381.ResumeLayout(false);
		CF0F0381.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C03FB2BB).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongPageTo).EndInit();
		F7ACF1BE.ResumeLayout(false);
		F7ACF1BE.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudViewFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudViewTo).EndInit();
		plComment.ResumeLayout(false);
		plComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)D2B3E7BA).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)D7199EA8).EndInit();
		B891C3AF.ResumeLayout(false);
		ResumeLayout(false);
	}
}
