using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCapNhatDuLieu : Form
{
	[CompilerGenerated]
	private sealed class EB2A4237
	{
		internal Label label_0;

		internal void method_0()
		{
			int num = Convert.ToInt32(label_0.Text);
			label_0.Text = (num + 1).ToString();
		}
	}

	[CompilerGenerated]
	private sealed class Class53
	{
		internal fCapNhatDuLieu fCapNhatDuLieu_0;

		internal string string_0;

		internal void E8145C1C()
		{
			fCapNhatDuLieu_0.lblStatus.Text = string_0;
		}
	}

	internal static bool bool_0;

	internal List<ComboBox> FB95F78B;

	internal List<string> F53DF390 = new List<string>();

	internal List<string> EB8E4C3F = new List<string>();

	internal List<string> list_0 = new List<string>();

	internal IContainer icontainer_0 = null;

	internal Button btnAdd;

	internal Button C0BBDBB4;

	internal Label FA803130;

	internal ComboBox cbbDinhDangNhap;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl bunifuDragControl_1;

	internal RichTextBox F2151D1A;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel pnlHeader;

	internal BunifuCards EA89F700;

	internal ContextMenuStrip A6AEBF88;

	internal ToolStripMenuItem toolStripMenuItem_0;

	internal ToolStripMenuItem toolStripMenuItem_1;

	internal ToolStripMenuItem toolStripMenuItem_2;

	internal ToolStripMenuItem toolStripMenuItem_3;

	internal ToolStripMenuItem toolStripMenuItem_4;

	internal ToolStripMenuItem toolStripMenuItem2;

	internal ToolStripMenuItem DF173C09;

	internal ToolStripMenuItem toolStripMenuItem_5;

	internal ToolStripMenuItem toolStripMenuItem_6;

	internal Label B732BDAF;

	internal Label lblSuccess;

	internal Label lblError;

	internal Label lblTotal;

	internal Label C09AFEA8;

	internal Label EE06E5AF;

	internal Label lblStatus;

	internal PictureBox A6B06B2E;

	internal Button btnMinimize;

	internal PictureBox pictureBox2;

	internal Panel C098BCB9;

	internal Label label1;

	internal ComboBox BF391EA5;

	internal ComboBox cbbDinhDang2;

	internal ComboBox A3307F20;

	internal ComboBox C13E3494;

	internal Label label14;

	internal ComboBox cbbDinhDang5;

	internal Label B5101224;

	internal ComboBox cbbDinhDang8;

	internal Label A2AAF53F;

	internal ComboBox BD92F02A;

	internal Label label12;

	internal ComboBox cbbDinhDang7;

	internal Label label11;

	internal Label label9;

	internal Label label10;

	internal ComboBox cbbTypeProxy;

	internal Label label2;

	internal Label label5;

	internal ComboBox cbbDinhDang9;

	internal Label label15;

	internal ComboBox cbbDinhDang11;

	internal Label label6;

	internal ComboBox cbbDinhDang10;

	internal Label B5BD48A1;

	internal ComboBox EA2A7F0F;

	public fCapNhatDuLieu()
	{
		InitializeComponent();
		cbbDinhDangNhap.SelectedIndex = 0;
		FB95F78B = new List<ComboBox>
		{
			BF391EA5, cbbDinhDang2, A3307F20, C13E3494, cbbDinhDang5, BD92F02A, cbbDinhDang7, cbbDinhDang8, cbbDinhDang9, cbbDinhDang10,
			cbbDinhDang11, EA2A7F0F
		};
		bool_0 = false;
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(bunifuCustomLabel1);
		Language.smethod_1(lblStatus);
		Language.smethod_1(B732BDAF);
		Language.smethod_1(C09AFEA8);
		Language.smethod_1(EE06E5AF);
		Language.smethod_1(FA803130);
		Language.smethod_1(btnAdd);
		Language.smethod_1(C0BBDBB4);
	}

	private void C0BBDBB4_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		EB8E4C3F = new List<string>();
		list_0 = new List<string>();
		try
		{
			List<string> f1808BA = F2151D1A.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show("Vui lòng nhâ\u0323p thông tin ta\u0300i khoa\u0309n!");
				F2151D1A.Focus();
				return;
			}
			int selectedIndex = cbbDinhDangNhap.SelectedIndex;
			if (selectedIndex != 5)
			{
				goto IL_00b9;
			}
			bool flag = false;
			for (int i = 0; i < FB95F78B.Count; i++)
			{
				if (FB95F78B[i].SelectedIndex > -1)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				goto IL_00b9;
			}
			MessageBoxHelper.Show("Vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng ta\u0300i khoa\u0309n!");
			goto end_IL_0016;
			IL_00b9:
			lblSuccess.Text = "0";
			lblError.Text = "0";
			F53DF390 = new List<string>();
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string text7 = "";
			string text8 = "";
			string text9 = "";
			string text10 = "";
			string text11 = "";
			string text12 = "";
			string text13 = "";
			string text14 = "";
			string text15 = "";
			string text16 = "";
			for (int j = 0; j < f1808BA.Count; j++)
			{
				text = "";
				text2 = "";
				text3 = "";
				text4 = "";
				text5 = "";
				text6 = "";
				text7 = "";
				text8 = "";
				text9 = "";
				text10 = "";
				text11 = "";
				text12 = "";
				text13 = "";
				text14 = "";
				text15 = "";
				text16 = "";
				try
				{
					string[] array = f1808BA[j].Split('|');
					switch (selectedIndex)
					{
					case 0:
						text = array[0];
						text2 = array[1];
						break;
					case 1:
						text = array[0];
						text2 = array[1];
						text7 = array[2];
						break;
					case 2:
						text = array[0];
						text2 = array[1];
						text3 = array[2];
						text4 = array[3];
						break;
					case 3:
						text = array[0];
						text2 = array[1];
						text3 = array[2];
						text4 = array[3];
						text5 = array[4];
						text6 = array[5];
						break;
					case 4:
						text = array[0];
						text2 = array[1];
						text3 = array[2];
						text4 = array[3];
						text5 = array[4];
						text6 = array[5];
						text7 = array[6];
						break;
					case 5:
					{
						text = array[0];
						for (int k = 1; k < FB95F78B.Count; k++)
						{
							string text17 = FB95F78B[k - 1].Text;
							string text18 = text17;
							switch (HashString.DA8CEBAB(text18))
							{
							case 776692014u:
								if (text18 == "Ghi chú")
								{
									text15 = array[k];
								}
								break;
							case 747205759u:
								if (text18 == "Tương tác cuối")
								{
									text16 = array[k];
								}
								break;
							case 1127555431u:
								if (text18 == "Email")
								{
									text5 = array[k];
								}
								break;
							case 976575442u:
								if (text18 == "Token")
								{
									text3 = array[k];
								}
								break;
							case 1802569846u:
								if (text18 == "Mail khôi phục")
								{
									text14 = array[k];
								}
								break;
							case 1335761915u:
								if (text18 == "Proxy")
								{
									text9 = ((array[k] == "") ? "" : (array[k] + "*" + cbbTypeProxy.SelectedIndex));
								}
								break;
							case 2589850865u:
								if (text18 == "Ngày sinh")
								{
									text10 = array[k];
								}
								break;
							case 2249983736u:
								if (text18 == "2FA")
								{
									text7 = array[k];
								}
								break;
							case 3183131359u:
								if (text18 == "Cookie")
								{
									text4 = array[k];
								}
								break;
							case 2958674405u:
								if (text18 == "Ngày tạo")
								{
									text13 = array[k];
								}
								break;
							case 3611366992u:
								if (text18 == "Pass Email")
								{
									text6 = array[k];
								}
								break;
							case 3209957741u:
								if (text18 == "Uid")
								{
									text = array[k];
								}
								break;
							case 3763899592u:
								if (text18 == "Bạn bè")
								{
									text12 = array[k];
								}
								break;
							case 3646757383u:
								if (text18 == "Useragent")
								{
									text8 = array[k];
								}
								break;
							case 3797810878u:
								if (text18 == "Giới tính")
								{
									text11 = array[k];
								}
								break;
							case 3797654840u:
								if (text18 == "Pass")
								{
									text2 = array[k];
								}
								break;
							}
						}
						break;
					}
					}
					F53DF390.Add(text + "|" + text2 + "|" + text3 + "|" + text4 + "|" + text5 + "|" + text6 + "|" + text7 + "|" + text8 + "|" + text9 + "|" + text10 + "|" + text11 + "|" + text12 + "|" + text13 + "|" + text14 + "|" + text15 + "|" + text16);
					EB8E4C3F.Add(f1808BA[j]);
				}
				catch
				{
					BD9595B2(lblError);
					list_0.Add(f1808BA[j]);
				}
			}
			btnAdd.Invoke((MethodInvoker)delegate
			{
				btnAdd.Enabled = false;
			});
			method_1("Đang cập nhật dữ liệu...");
			for (int l = 0; l < F53DF390.Count; l++)
			{
				if (CommonSQL.EA9BF215(F53DF390[l]))
				{
					BD9595B2(lblSuccess);
				}
				else
				{
					BD9595B2(lblError);
				}
			}
			btnAdd.Invoke((MethodInvoker)delegate
			{
				btnAdd.Enabled = true;
			});
			EB8E4C3F.AddRange(list_0);
			F2151D1A.Lines = EB8E4C3F.ToArray();
			method_1(Language.GetValue("Cập nhật dữ liệu xong!"));
			MessageBoxHelper.Show("Cập nhật dữ liệu xong!");
			bool_0 = true;
			end_IL_0016:;
		}
		catch (Exception a81E)
		{
			MessageBoxHelper.Show("Đa\u0303 co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!");
			Common.smethod_43(a81E, "UpdateAccount");
		}
	}

	private void method_1(string string_0)
	{
		Application.DoEvents();
		lblStatus.Invoke((MethodInvoker)delegate
		{
			lblStatus.Text = string_0;
		});
	}

	private void F2151D1A_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = F2151D1A.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			lblTotal.Text = f1808BA.Count.ToString();
		}
		catch
		{
		}
	}

	private void BD9595B2(Label E083E3BD)
	{
		Application.DoEvents();
		lock (E083E3BD)
		{
			E083E3BD.Invoke((MethodInvoker)delegate
			{
				int num = Convert.ToInt32(E083E3BD.Text);
				E083E3BD.Text = (num + 1).ToString();
			});
		}
	}

	private void cbbDinhDangNhap_SelectedIndexChanged(object sender, EventArgs e)
	{
		C098BCB9.Visible = cbbDinhDangNhap.SelectedIndex == cbbDinhDangNhap.Items.Count - 1;
	}

	private bool method_2()
	{
		bool result = false;
		List<int> list = new List<int>();
		int num = 0;
		for (int i = 0; i <= 6; i++)
		{
			num = FB95F78B[i].SelectedIndex;
			if (num != -1)
			{
				if (list.Contains(num))
				{
					result = true;
					break;
				}
				list.Add(num);
			}
		}
		return result;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C5A50786(object sender, EventArgs e)
	{
		bool visible = false;
		for (int i = 0; i < FB95F78B.Count; i++)
		{
			if (FB95F78B[i].Text == "Proxy")
			{
				visible = true;
				break;
			}
		}
		label2.Visible = visible;
		cbbTypeProxy.Visible = visible;
	}

	private void B3191812(object sender, EventArgs e)
	{
		foreach (ComboBox item in FB95F78B)
		{
			Common.BEBCBE97(item, new List<string>
			{
				"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Ngày sinh",
				"Giới tính", "Bạn bè", "Ngày tạo", "Mail khôi phục", "Ghi chú", "Tương tác cuối"
			});
			item.SelectedIndex = -1;
			item.DropDownWidth = 100;
		}
		cbbTypeProxy.SelectedIndex = 0;
	}

	protected override void Dispose(bool F184E4AB)
	{
		if (F184E4AB && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(F184E4AB);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCapNhatDuLieu));
		btnAdd = new System.Windows.Forms.Button();
		C0BBDBB4 = new System.Windows.Forms.Button();
		FA803130 = new System.Windows.Forms.Label();
		cbbDinhDangNhap = new System.Windows.Forms.ComboBox();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox2 = new System.Windows.Forms.PictureBox();
		A6B06B2E = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		F2151D1A = new System.Windows.Forms.RichTextBox();
		EA89F700 = new Bunifu.Framework.UI.BunifuCards();
		A6AEBF88 = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		DF173C09 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		B732BDAF = new System.Windows.Forms.Label();
		lblSuccess = new System.Windows.Forms.Label();
		lblError = new System.Windows.Forms.Label();
		lblTotal = new System.Windows.Forms.Label();
		C09AFEA8 = new System.Windows.Forms.Label();
		EE06E5AF = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		C098BCB9 = new System.Windows.Forms.Panel();
		B5BD48A1 = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		EA2A7F0F = new System.Windows.Forms.ComboBox();
		cbbDinhDang11 = new System.Windows.Forms.ComboBox();
		cbbDinhDang9 = new System.Windows.Forms.ComboBox();
		cbbTypeProxy = new System.Windows.Forms.ComboBox();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		BF391EA5 = new System.Windows.Forms.ComboBox();
		cbbDinhDang2 = new System.Windows.Forms.ComboBox();
		A3307F20 = new System.Windows.Forms.ComboBox();
		C13E3494 = new System.Windows.Forms.ComboBox();
		label14 = new System.Windows.Forms.Label();
		cbbDinhDang5 = new System.Windows.Forms.ComboBox();
		label6 = new System.Windows.Forms.Label();
		B5101224 = new System.Windows.Forms.Label();
		cbbDinhDang10 = new System.Windows.Forms.ComboBox();
		cbbDinhDang8 = new System.Windows.Forms.ComboBox();
		A2AAF53F = new System.Windows.Forms.Label();
		BD92F02A = new System.Windows.Forms.ComboBox();
		label12 = new System.Windows.Forms.Label();
		cbbDinhDang7 = new System.Windows.Forms.ComboBox();
		label11 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)A6B06B2E).BeginInit();
		EA89F700.SuspendLayout();
		A6AEBF88.SuspendLayout();
		C098BCB9.SuspendLayout();
		SuspendLayout();
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(482, 460);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(97, 31);
		btnAdd.TabIndex = 13;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		C0BBDBB4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		C0BBDBB4.BackColor = System.Drawing.Color.Maroon;
		C0BBDBB4.Cursor = System.Windows.Forms.Cursors.Hand;
		C0BBDBB4.FlatAppearance.BorderSize = 0;
		C0BBDBB4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C0BBDBB4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C0BBDBB4.ForeColor = System.Drawing.Color.White;
		C0BBDBB4.Location = new System.Drawing.Point(599, 460);
		C0BBDBB4.Name = "btnCancel";
		C0BBDBB4.Size = new System.Drawing.Size(97, 31);
		C0BBDBB4.TabIndex = 14;
		C0BBDBB4.Text = "Đo\u0301ng";
		C0BBDBB4.UseVisualStyleBackColor = false;
		C0BBDBB4.Click += new System.EventHandler(C0BBDBB4_Click);
		FA803130.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FA803130.Location = new System.Drawing.Point(9, 367);
		FA803130.Name = "label8";
		FA803130.Size = new System.Drawing.Size(97, 14);
		FA803130.TabIndex = 39;
		FA803130.Text = "Chọn định dạng:";
		FA803130.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		cbbDinhDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDangNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDangNhap.FormattingEnabled = true;
		cbbDinhDangNhap.Items.AddRange(new object[6] { "Uid|Pass", "Uid|Pass|2FA", "Uid|Pass|Token|Cookie", "Uid|Pass|Token|Cookie|Email|Pass Email", "Uid|Pass|Token|Cookie|Email|Pass Email|2FA", "Other..." });
		cbbDinhDangNhap.Location = new System.Drawing.Point(112, 364);
		cbbDinhDangNhap.Name = "cbbDinhDangNhap";
		cbbDinhDangNhap.Size = new System.Drawing.Size(269, 24);
		cbbDinhDangNhap.TabIndex = 40;
		cbbDinhDangNhap.SelectedIndexChanged += new System.EventHandler(cbbDinhDangNhap_SelectedIndexChanged);
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(1179, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox2);
		pnlHeader.Controls.Add(A6B06B2E);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(1179, 31);
		pnlHeader.TabIndex = 9;
		pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
		pictureBox2.Location = new System.Drawing.Point(2, 3);
		pictureBox2.Name = "pictureBox2";
		pictureBox2.Size = new System.Drawing.Size(34, 27);
		pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox2.TabIndex = 79;
		pictureBox2.TabStop = false;
		A6B06B2E.Cursor = System.Windows.Forms.Cursors.Default;
		A6B06B2E.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		A6B06B2E.Location = new System.Drawing.Point(-156, 2);
		A6B06B2E.Name = "pictureBox1";
		A6B06B2E.Size = new System.Drawing.Size(34, 27);
		A6B06B2E.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A6B06B2E.TabIndex = 78;
		A6B06B2E.TabStop = false;
		btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(1147, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(30, 30);
		btnMinimize.TabIndex = 77;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		F2151D1A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F2151D1A.Location = new System.Drawing.Point(12, 77);
		F2151D1A.Name = "txbAccount";
		F2151D1A.Size = new System.Drawing.Size(1147, 277);
		F2151D1A.TabIndex = 48;
		F2151D1A.Text = "";
		F2151D1A.WordWrap = false;
		F2151D1A.TextChanged += new System.EventHandler(F2151D1A_TextChanged);
		EA89F700.BackColor = System.Drawing.Color.White;
		EA89F700.BorderRadius = 0;
		EA89F700.BottomSahddow = true;
		EA89F700.color = System.Drawing.Color.DarkViolet;
		EA89F700.Controls.Add(pnlHeader);
		EA89F700.Dock = System.Windows.Forms.DockStyle.Top;
		EA89F700.LeftSahddow = false;
		EA89F700.Location = new System.Drawing.Point(0, 0);
		EA89F700.Name = "bunifuCards1";
		EA89F700.RightSahddow = true;
		EA89F700.ShadowDepth = 20;
		EA89F700.Size = new System.Drawing.Size(1179, 37);
		EA89F700.TabIndex = 49;
		A6AEBF88.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A6AEBF88.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { toolStripMenuItem_0, toolStripMenuItem2, DF173C09, toolStripMenuItem_5, toolStripMenuItem_6 });
		A6AEBF88.Name = "ctmsAcc";
		A6AEBF88.Size = new System.Drawing.Size(179, 114);
		toolStripMenuItem_0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { toolStripMenuItem_1, toolStripMenuItem_2, toolStripMenuItem_3, toolStripMenuItem_4 });
		toolStripMenuItem_0.Name = "chọnToolStripMenuItem1";
		toolStripMenuItem_0.Size = new System.Drawing.Size(178, 22);
		toolStripMenuItem_0.Text = "Chọn";
		toolStripMenuItem_1.Name = "tấtCảToolStripMenuItem1";
		toolStripMenuItem_1.Size = new System.Drawing.Size(143, 22);
		toolStripMenuItem_1.Text = "Tất cả";
		toolStripMenuItem_2.Name = "bôiĐenToolStripMenuItem1";
		toolStripMenuItem_2.Size = new System.Drawing.Size(143, 22);
		toolStripMenuItem_2.Text = "Bôi đen";
		toolStripMenuItem_3.Name = "tàiKhoản0ToolStripMenuItem";
		toolStripMenuItem_3.Size = new System.Drawing.Size(143, 22);
		toolStripMenuItem_3.Text = "Tài khoản=0";
		toolStripMenuItem_4.Name = "tàiKhoản1ToolStripMenuItem";
		toolStripMenuItem_4.Size = new System.Drawing.Size(143, 22);
		toolStripMenuItem_4.Text = "Tài khoản=1";
		toolStripMenuItem2.Name = "toolStripMenuItem2";
		toolStripMenuItem2.Size = new System.Drawing.Size(178, 22);
		toolStripMenuItem2.Text = "Bỏ chọn tất cả";
		DF173C09.Name = "tạoThiếtBịToolStripMenuItem";
		DF173C09.Size = new System.Drawing.Size(178, 22);
		DF173C09.Text = "Tạo thiết bị";
		toolStripMenuItem_5.Name = "xóaThiếtBịToolStripMenuItem";
		toolStripMenuItem_5.Size = new System.Drawing.Size(178, 22);
		toolStripMenuItem_5.Text = "Xóa thiết bị";
		toolStripMenuItem_6.Name = "loadDanhSachThiêtBiToolStripMenuItem1";
		toolStripMenuItem_6.Size = new System.Drawing.Size(178, 22);
		toolStripMenuItem_6.Text = "Làm mới danh sa\u0301ch";
		B732BDAF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		B732BDAF.Location = new System.Drawing.Point(704, 58);
		B732BDAF.Name = "label3";
		B732BDAF.Size = new System.Drawing.Size(87, 16);
		B732BDAF.TabIndex = 55;
		B732BDAF.Text = "Tha\u0300nh công:";
		B732BDAF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		lblSuccess.AutoSize = true;
		lblSuccess.BackColor = System.Drawing.SystemColors.Control;
		lblSuccess.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblSuccess.ForeColor = System.Drawing.Color.FromArgb(53, 120, 229);
		lblSuccess.Location = new System.Drawing.Point(787, 55);
		lblSuccess.Name = "lblSuccess";
		lblSuccess.Size = new System.Drawing.Size(19, 19);
		lblSuccess.TabIndex = 50;
		lblSuccess.Text = "0";
		lblError.AutoSize = true;
		lblError.BackColor = System.Drawing.SystemColors.Control;
		lblError.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblError.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		lblError.Location = new System.Drawing.Point(910, 55);
		lblError.Name = "lblError";
		lblError.Size = new System.Drawing.Size(19, 19);
		lblError.TabIndex = 51;
		lblError.Text = "0";
		lblTotal.AutoSize = true;
		lblTotal.BackColor = System.Drawing.SystemColors.Control;
		lblTotal.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblTotal.ForeColor = System.Drawing.Color.Teal;
		lblTotal.Location = new System.Drawing.Point(1070, 56);
		lblTotal.Name = "lblTotal";
		lblTotal.Size = new System.Drawing.Size(19, 19);
		lblTotal.TabIndex = 53;
		lblTotal.Text = "0";
		C09AFEA8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		C09AFEA8.Location = new System.Drawing.Point(861, 58);
		C09AFEA8.Name = "label4";
		C09AFEA8.Size = new System.Drawing.Size(52, 16);
		C09AFEA8.TabIndex = 56;
		C09AFEA8.Text = "Lỗi:";
		C09AFEA8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		EE06E5AF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		EE06E5AF.Location = new System.Drawing.Point(1010, 58);
		EE06E5AF.Name = "label7";
		EE06E5AF.Size = new System.Drawing.Size(63, 16);
		EE06E5AF.TabIndex = 59;
		EE06E5AF.Text = "Tô\u0309ng sô\u0301:";
		EE06E5AF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
		lblStatus.Location = new System.Drawing.Point(12, 44);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(227, 28);
		lblStatus.TabIndex = 60;
		lblStatus.Text = "Nhập thông tin tài khoản:";
		lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C098BCB9.Controls.Add(B5BD48A1);
		C098BCB9.Controls.Add(label15);
		C098BCB9.Controls.Add(label5);
		C098BCB9.Controls.Add(EA2A7F0F);
		C098BCB9.Controls.Add(cbbDinhDang11);
		C098BCB9.Controls.Add(cbbDinhDang9);
		C098BCB9.Controls.Add(cbbTypeProxy);
		C098BCB9.Controls.Add(label2);
		C098BCB9.Controls.Add(label1);
		C098BCB9.Controls.Add(BF391EA5);
		C098BCB9.Controls.Add(cbbDinhDang2);
		C098BCB9.Controls.Add(A3307F20);
		C098BCB9.Controls.Add(C13E3494);
		C098BCB9.Controls.Add(label14);
		C098BCB9.Controls.Add(cbbDinhDang5);
		C098BCB9.Controls.Add(label6);
		C098BCB9.Controls.Add(B5101224);
		C098BCB9.Controls.Add(cbbDinhDang10);
		C098BCB9.Controls.Add(cbbDinhDang8);
		C098BCB9.Controls.Add(A2AAF53F);
		C098BCB9.Controls.Add(BD92F02A);
		C098BCB9.Controls.Add(label12);
		C098BCB9.Controls.Add(cbbDinhDang7);
		C098BCB9.Controls.Add(label11);
		C098BCB9.Controls.Add(label9);
		C098BCB9.Controls.Add(label10);
		C098BCB9.Location = new System.Drawing.Point(6, 392);
		C098BCB9.Name = "plDinhDangNhap";
		C098BCB9.Size = new System.Drawing.Size(1157, 62);
		C098BCB9.TabIndex = 61;
		B5BD48A1.AutoSize = true;
		B5BD48A1.Font = new System.Drawing.Font("Tahoma", 12f);
		B5BD48A1.Location = new System.Drawing.Point(1057, 7);
		B5BD48A1.Name = "label16";
		B5BD48A1.Size = new System.Drawing.Size(15, 19);
		B5BD48A1.TabIndex = 128;
		B5BD48A1.Text = "|";
		label15.AutoSize = true;
		label15.Font = new System.Drawing.Font("Tahoma", 12f);
		label15.Location = new System.Drawing.Point(961, 6);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(15, 19);
		label15.TabIndex = 128;
		label15.Text = "|";
		label5.AutoSize = true;
		label5.Font = new System.Drawing.Font("Tahoma", 12f);
		label5.Location = new System.Drawing.Point(774, 4);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(15, 19);
		label5.TabIndex = 128;
		label5.Text = "|";
		EA2A7F0F.Cursor = System.Windows.Forms.Cursors.Hand;
		EA2A7F0F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		EA2A7F0F.FormattingEnabled = true;
		EA2A7F0F.Location = new System.Drawing.Point(1072, 7);
		EA2A7F0F.Name = "cbbDinhDang12";
		EA2A7F0F.Size = new System.Drawing.Size(78, 24);
		EA2A7F0F.TabIndex = 127;
		cbbDinhDang11.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang11.FormattingEnabled = true;
		cbbDinhDang11.Location = new System.Drawing.Point(976, 6);
		cbbDinhDang11.Name = "cbbDinhDang11";
		cbbDinhDang11.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang11.TabIndex = 127;
		cbbDinhDang9.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang9.FormattingEnabled = true;
		cbbDinhDang9.Location = new System.Drawing.Point(789, 4);
		cbbDinhDang9.Name = "cbbDinhDang9";
		cbbDinhDang9.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang9.TabIndex = 127;
		cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbTypeProxy.FormattingEnabled = true;
		cbbTypeProxy.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		cbbTypeProxy.Location = new System.Drawing.Point(85, 33);
		cbbTypeProxy.Name = "cbbTypeProxy";
		cbbTypeProxy.Size = new System.Drawing.Size(130, 24);
		cbbTypeProxy.TabIndex = 126;
		cbbTypeProxy.Visible = false;
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(7, 36);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(70, 16);
		label2.TabIndex = 125;
		label2.Text = "Loại proxy:";
		label2.Visible = false;
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 12f);
		label1.Location = new System.Drawing.Point(5, 3);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(39, 19);
		label1.TabIndex = 42;
		label1.Text = "Uid|";
		BF391EA5.Cursor = System.Windows.Forms.Cursors.Hand;
		BF391EA5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		BF391EA5.FormattingEnabled = true;
		BF391EA5.Location = new System.Drawing.Point(44, 3);
		BF391EA5.Name = "cbbDinhDang1";
		BF391EA5.Size = new System.Drawing.Size(78, 24);
		BF391EA5.TabIndex = 40;
		BF391EA5.SelectedIndexChanged += new System.EventHandler(C5A50786);
		cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang2.FormattingEnabled = true;
		cbbDinhDang2.Location = new System.Drawing.Point(137, 3);
		cbbDinhDang2.Name = "cbbDinhDang2";
		cbbDinhDang2.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang2.TabIndex = 40;
		cbbDinhDang2.SelectedIndexChanged += new System.EventHandler(C5A50786);
		A3307F20.Cursor = System.Windows.Forms.Cursors.Hand;
		A3307F20.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		A3307F20.FormattingEnabled = true;
		A3307F20.Location = new System.Drawing.Point(230, 3);
		A3307F20.Name = "cbbDinhDang3";
		A3307F20.Size = new System.Drawing.Size(78, 24);
		A3307F20.TabIndex = 40;
		A3307F20.SelectedIndexChanged += new System.EventHandler(C5A50786);
		C13E3494.Cursor = System.Windows.Forms.Cursors.Hand;
		C13E3494.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		C13E3494.FormattingEnabled = true;
		C13E3494.Location = new System.Drawing.Point(323, 3);
		C13E3494.Name = "cbbDinhDang4";
		C13E3494.Size = new System.Drawing.Size(78, 24);
		C13E3494.TabIndex = 40;
		C13E3494.SelectedIndexChanged += new System.EventHandler(C5A50786);
		label14.AutoSize = true;
		label14.Font = new System.Drawing.Font("Tahoma", 12f);
		label14.Location = new System.Drawing.Point(587, 3);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(15, 19);
		label14.TabIndex = 41;
		label14.Text = "|";
		cbbDinhDang5.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang5.FormattingEnabled = true;
		cbbDinhDang5.Location = new System.Drawing.Point(416, 3);
		cbbDinhDang5.Name = "cbbDinhDang5";
		cbbDinhDang5.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang5.TabIndex = 40;
		cbbDinhDang5.SelectedIndexChanged += new System.EventHandler(C5A50786);
		label6.AutoSize = true;
		label6.Font = new System.Drawing.Font("Tahoma", 12f);
		label6.Location = new System.Drawing.Point(867, 5);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(15, 19);
		label6.TabIndex = 41;
		label6.Text = "|";
		B5101224.AutoSize = true;
		B5101224.Font = new System.Drawing.Font("Tahoma", 12f);
		B5101224.Location = new System.Drawing.Point(680, 3);
		B5101224.Name = "label17";
		B5101224.Size = new System.Drawing.Size(15, 19);
		B5101224.TabIndex = 41;
		B5101224.Text = "|";
		cbbDinhDang10.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang10.FormattingEnabled = true;
		cbbDinhDang10.Location = new System.Drawing.Point(882, 5);
		cbbDinhDang10.Name = "cbbDinhDang10";
		cbbDinhDang10.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang10.TabIndex = 40;
		cbbDinhDang10.SelectedIndexChanged += new System.EventHandler(C5A50786);
		cbbDinhDang8.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang8.FormattingEnabled = true;
		cbbDinhDang8.Location = new System.Drawing.Point(695, 3);
		cbbDinhDang8.Name = "cbbDinhDang8";
		cbbDinhDang8.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang8.TabIndex = 40;
		cbbDinhDang8.SelectedIndexChanged += new System.EventHandler(C5A50786);
		A2AAF53F.AutoSize = true;
		A2AAF53F.Font = new System.Drawing.Font("Tahoma", 12f);
		A2AAF53F.Location = new System.Drawing.Point(494, 3);
		A2AAF53F.Name = "label13";
		A2AAF53F.Size = new System.Drawing.Size(15, 19);
		A2AAF53F.TabIndex = 41;
		A2AAF53F.Text = "|";
		BD92F02A.Cursor = System.Windows.Forms.Cursors.Hand;
		BD92F02A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		BD92F02A.FormattingEnabled = true;
		BD92F02A.Location = new System.Drawing.Point(509, 3);
		BD92F02A.Name = "cbbDinhDang6";
		BD92F02A.Size = new System.Drawing.Size(78, 24);
		BD92F02A.TabIndex = 40;
		BD92F02A.SelectedIndexChanged += new System.EventHandler(C5A50786);
		label12.AutoSize = true;
		label12.Font = new System.Drawing.Font("Tahoma", 12f);
		label12.Location = new System.Drawing.Point(401, 3);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(15, 19);
		label12.TabIndex = 41;
		label12.Text = "|";
		cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang7.FormattingEnabled = true;
		cbbDinhDang7.Location = new System.Drawing.Point(602, 3);
		cbbDinhDang7.Name = "cbbDinhDang7";
		cbbDinhDang7.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang7.TabIndex = 40;
		cbbDinhDang7.SelectedIndexChanged += new System.EventHandler(C5A50786);
		label11.AutoSize = true;
		label11.Font = new System.Drawing.Font("Tahoma", 12f);
		label11.Location = new System.Drawing.Point(308, 3);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(15, 19);
		label11.TabIndex = 41;
		label11.Text = "|";
		label9.AutoSize = true;
		label9.Font = new System.Drawing.Font("Tahoma", 12f);
		label9.Location = new System.Drawing.Point(122, 3);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(15, 19);
		label9.TabIndex = 41;
		label9.Text = "|";
		label10.AutoSize = true;
		label10.Font = new System.Drawing.Font("Tahoma", 12f);
		label10.Location = new System.Drawing.Point(215, 3);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(15, 19);
		label10.TabIndex = 41;
		label10.Text = "|";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1179, 502);
		base.Controls.Add(C098BCB9);
		base.Controls.Add(lblStatus);
		base.Controls.Add(B732BDAF);
		base.Controls.Add(lblSuccess);
		base.Controls.Add(lblError);
		base.Controls.Add(lblTotal);
		base.Controls.Add(C09AFEA8);
		base.Controls.Add(EE06E5AF);
		base.Controls.Add(btnAdd);
		base.Controls.Add(C0BBDBB4);
		base.Controls.Add(F2151D1A);
		base.Controls.Add(EA89F700);
		base.Controls.Add(cbbDinhDangNhap);
		base.Controls.Add(FA803130);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCapNhatDuLieu";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Nhập tài khoản";
		base.Load += new System.EventHandler(B3191812);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)A6B06B2E).EndInit();
		EA89F700.ResumeLayout(false);
		A6AEBF88.ResumeLayout(false);
		C098BCB9.ResumeLayout(false);
		C098BCB9.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void D22EFE99()
	{
		btnAdd.Enabled = false;
	}

	[CompilerGenerated]
	private void method_3()
	{
		btnAdd.Enabled = true;
	}
}
