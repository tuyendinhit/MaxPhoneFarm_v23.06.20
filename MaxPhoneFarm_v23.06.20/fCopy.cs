using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCopy : Form
{
	internal List<ComboBox> EF81C715;

	internal List<string> B0053EA3 = new List<string>();

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel AF97F83B;

	internal BunifuCustomLabel F8A84815;

	internal Button btnMinimize;

	internal Button btnCancel;

	internal Button C49277A3;

	internal Label E4BE8BA7;

	internal BunifuDragControl bunifuDragControl_0;

	internal ComboBox F02F971C;

	internal ComboBox cbbDinhDang2;

	internal ComboBox cbbDinhDang3;

	internal ComboBox cbbDinhDang4;

	internal Label A0B50AA7;

	internal ComboBox cbbDinhDang5;

	internal Label ED0F54A7;

	internal ComboBox cbbDinhDang6;

	internal Label BCBC2A2A;

	internal ComboBox cbbDinhDang7;

	internal Label label11;

	internal Label D5A20B21;

	internal Label label10;

	internal ComboBox cbbDinhDang9;

	internal ComboBox cbbDinhDang8;

	internal Label E0995912;

	internal Label C3A8973B;

	internal Button B913A78C;

	internal ComboBox cbbDinhDang10;

	internal Label CCBFBC96;

	public fCopy(List<string> F18A9716)
	{
		InitializeComponent();
		B0053EA3 = F18A9716;
		Language.SetLanguage(this);
		EF81C715 = new List<ComboBox> { F02F971C, cbbDinhDang2, cbbDinhDang3, cbbDinhDang4, cbbDinhDang5, cbbDinhDang6, cbbDinhDang7, cbbDinhDang8, cbbDinhDang9, cbbDinhDang10 };
	}

	private void C4184C31(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		Language.smethod_1(F8A84815);
		Language.smethod_1(E4BE8BA7);
		Language.smethod_1(B913A78C);
		Language.smethod_1(C49277A3);
		Language.smethod_1(btnCancel);
	}

	private void CB07953E()
	{
		try
		{
			string text = "";
			for (int i = 0; i < EF81C715.Count; i++)
			{
				text = text + EF81C715[i].SelectedIndex + "|";
			}
			text = text.TrimEnd('|');
			File.WriteAllText("settings\\format_copy.txt", text);
		}
		catch
		{
		}
	}

	private void method_1()
	{
		try
		{
			if (File.Exists("settings\\format_copy.txt"))
			{
				string text = File.ReadAllText("settings\\format_copy.txt");
				for (int i = 0; i < EF81C715.Count; i++)
				{
					EF81C715[i].SelectedIndex = Convert.ToInt32(text.Split('|')[i]);
				}
			}
		}
		catch
		{
		}
	}

	private void method_2()
	{
		try
		{
			for (int i = 0; i < EF81C715.Count; i++)
			{
				EF81C715[i].SelectedIndex = -1;
			}
		}
		catch
		{
		}
	}

	private void AA9CC805(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			string text = "";
			int num = 0;
			int num2 = EF81C715.Count - 1;
			while (num2 >= 0)
			{
				if (EF81C715[num2].SelectedIndex == -1)
				{
					num2--;
					continue;
				}
				num = num2 + 1;
				break;
			}
			if (num == 0)
			{
				MessageBoxHelper.Show("vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng câ\u0300n copy!", 3);
				return;
			}
			CB07953E();
			int num3 = 0;
			for (int i = 0; i < B0053EA3.Count; i++)
			{
				text = "";
				string[] array = B0053EA3[i].Split('|');
				for (int j = 0; j < EF81C715.Count; j++)
				{
					if (EF81C715[j].SelectedIndex != -1)
					{
						text += array[EF81C715[j].SelectedIndex];
					}
					text += "|";
				}
				text = text.TrimEnd('|');
				for (num3 = text.Split('|').Count(); num3 < num; num3++)
				{
					text += "|";
				}
				list.Add(text);
			}
			string string_ = string.Join("\r\n", list);
			Common.SetTextToClipboard(string_);
			MessageBoxHelper.Show("Copy tha\u0300nh công!");
			Close();
		}
		catch (Exception ex)
		{
			Common.smethod_43(null, ex.ToString());
			MessageBoxHelper.Show("Có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void BCA9273E(object sender, EventArgs e)
	{
		Close();
	}

	private void B913A78C_Click(object sender, EventArgs e)
	{
		method_2();
	}

	private void fCopy_Load(object sender, EventArgs e)
	{
		foreach (ComboBox item in EF81C715)
		{
			Common.BEBCBE97(item, new List<string>
			{
				"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Tên",
				"Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú", "Mail khôi phục", "Tương tác cuối"
			});
			item.SelectedIndex = -1;
			item.DropDownWidth = 100;
		}
		method_1();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCopy));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		AF97F83B = new System.Windows.Forms.Panel();
		btnMinimize = new System.Windows.Forms.Button();
		F8A84815 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		C49277A3 = new System.Windows.Forms.Button();
		E4BE8BA7 = new System.Windows.Forms.Label();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		F02F971C = new System.Windows.Forms.ComboBox();
		cbbDinhDang2 = new System.Windows.Forms.ComboBox();
		cbbDinhDang3 = new System.Windows.Forms.ComboBox();
		cbbDinhDang4 = new System.Windows.Forms.ComboBox();
		A0B50AA7 = new System.Windows.Forms.Label();
		cbbDinhDang5 = new System.Windows.Forms.ComboBox();
		ED0F54A7 = new System.Windows.Forms.Label();
		cbbDinhDang6 = new System.Windows.Forms.ComboBox();
		BCBC2A2A = new System.Windows.Forms.Label();
		cbbDinhDang7 = new System.Windows.Forms.ComboBox();
		label11 = new System.Windows.Forms.Label();
		D5A20B21 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		cbbDinhDang9 = new System.Windows.Forms.ComboBox();
		cbbDinhDang8 = new System.Windows.Forms.ComboBox();
		E0995912 = new System.Windows.Forms.Label();
		C3A8973B = new System.Windows.Forms.Label();
		B913A78C = new System.Windows.Forms.Button();
		cbbDinhDang10 = new System.Windows.Forms.ComboBox();
		CCBFBC96 = new System.Windows.Forms.Label();
		bunifuCards1.SuspendLayout();
		AF97F83B.SuspendLayout();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(AF97F83B);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(1122, 38);
		bunifuCards1.TabIndex = 0;
		AF97F83B.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		AF97F83B.BackColor = System.Drawing.Color.White;
		AF97F83B.Controls.Add(btnMinimize);
		AF97F83B.Controls.Add(F8A84815);
		AF97F83B.Location = new System.Drawing.Point(0, 5);
		AF97F83B.Name = "pnlHeader";
		AF97F83B.Size = new System.Drawing.Size(1122, 32);
		AF97F83B.TabIndex = 9;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(1090, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(C4184C31);
		F8A84815.BackColor = System.Drawing.Color.Transparent;
		F8A84815.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F8A84815.Dock = System.Windows.Forms.DockStyle.Fill;
		F8A84815.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F8A84815.ForeColor = System.Drawing.Color.Black;
		F8A84815.Location = new System.Drawing.Point(0, 0);
		F8A84815.Name = "bunifuCustomLabel1";
		F8A84815.Size = new System.Drawing.Size(1122, 32);
		F8A84815.TabIndex = 1;
		F8A84815.Text = "Tu\u0300y cho\u0323n đi\u0323nh da\u0323ng sao che\u0301p";
		F8A84815.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(622, 124);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(BCA9273E);
		C49277A3.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		C49277A3.Cursor = System.Windows.Forms.Cursors.Hand;
		C49277A3.FlatAppearance.BorderSize = 0;
		C49277A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C49277A3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C49277A3.ForeColor = System.Drawing.Color.White;
		C49277A3.Location = new System.Drawing.Point(514, 124);
		C49277A3.Name = "btnAdd";
		C49277A3.Size = new System.Drawing.Size(92, 29);
		C49277A3.TabIndex = 3;
		C49277A3.Text = "Xa\u0301c nhâ\u0323n";
		C49277A3.UseVisualStyleBackColor = false;
		C49277A3.Click += new System.EventHandler(AA9CC805);
		E4BE8BA7.AutoSize = true;
		E4BE8BA7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		E4BE8BA7.Location = new System.Drawing.Point(20, 66);
		E4BE8BA7.Name = "label1";
		E4BE8BA7.Size = new System.Drawing.Size(131, 16);
		E4BE8BA7.TabIndex = 20;
		E4BE8BA7.Text = "Cho\u0323n đi\u0323nh da\u0323ng copy:";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = F8A84815;
		bunifuDragControl_0.Vertical = true;
		F02F971C.Cursor = System.Windows.Forms.Cursors.Hand;
		F02F971C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		F02F971C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F02F971C.FormattingEnabled = true;
		F02F971C.Location = new System.Drawing.Point(158, 65);
		F02F971C.Name = "cbbDinhDang1";
		F02F971C.Size = new System.Drawing.Size(78, 24);
		F02F971C.TabIndex = 42;
		cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang2.FormattingEnabled = true;
		cbbDinhDang2.Location = new System.Drawing.Point(255, 65);
		cbbDinhDang2.Name = "cbbDinhDang2";
		cbbDinhDang2.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang2.TabIndex = 43;
		cbbDinhDang3.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang3.FormattingEnabled = true;
		cbbDinhDang3.Location = new System.Drawing.Point(352, 65);
		cbbDinhDang3.Name = "cbbDinhDang3";
		cbbDinhDang3.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang3.TabIndex = 44;
		cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang4.FormattingEnabled = true;
		cbbDinhDang4.Location = new System.Drawing.Point(449, 65);
		cbbDinhDang4.Name = "cbbDinhDang4";
		cbbDinhDang4.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang4.TabIndex = 45;
		A0B50AA7.AutoSize = true;
		A0B50AA7.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A0B50AA7.Location = new System.Drawing.Point(721, 67);
		A0B50AA7.Name = "label14";
		A0B50AA7.Size = new System.Drawing.Size(19, 19);
		A0B50AA7.TabIndex = 49;
		A0B50AA7.Text = "|";
		cbbDinhDang5.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang5.FormattingEnabled = true;
		cbbDinhDang5.Location = new System.Drawing.Point(546, 65);
		cbbDinhDang5.Name = "cbbDinhDang5";
		cbbDinhDang5.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang5.TabIndex = 46;
		ED0F54A7.AutoSize = true;
		ED0F54A7.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		ED0F54A7.Location = new System.Drawing.Point(624, 67);
		ED0F54A7.Name = "label13";
		ED0F54A7.Size = new System.Drawing.Size(19, 19);
		ED0F54A7.TabIndex = 50;
		ED0F54A7.Text = "|";
		cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang6.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang6.FormattingEnabled = true;
		cbbDinhDang6.Location = new System.Drawing.Point(643, 65);
		cbbDinhDang6.Name = "cbbDinhDang6";
		cbbDinhDang6.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang6.TabIndex = 47;
		BCBC2A2A.AutoSize = true;
		BCBC2A2A.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BCBC2A2A.Location = new System.Drawing.Point(527, 67);
		BCBC2A2A.Name = "label12";
		BCBC2A2A.Size = new System.Drawing.Size(19, 19);
		BCBC2A2A.TabIndex = 51;
		BCBC2A2A.Text = "|";
		cbbDinhDang7.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang7.FormattingEnabled = true;
		cbbDinhDang7.Location = new System.Drawing.Point(740, 65);
		cbbDinhDang7.Name = "cbbDinhDang7";
		cbbDinhDang7.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang7.TabIndex = 48;
		label11.AutoSize = true;
		label11.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label11.Location = new System.Drawing.Point(430, 67);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(19, 19);
		label11.TabIndex = 52;
		label11.Text = "|";
		D5A20B21.AutoSize = true;
		D5A20B21.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D5A20B21.Location = new System.Drawing.Point(236, 67);
		D5A20B21.Name = "label9";
		D5A20B21.Size = new System.Drawing.Size(19, 19);
		D5A20B21.TabIndex = 53;
		D5A20B21.Text = "|";
		label10.AutoSize = true;
		label10.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label10.Location = new System.Drawing.Point(333, 67);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(19, 19);
		label10.TabIndex = 54;
		label10.Text = "|";
		cbbDinhDang9.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang9.FormattingEnabled = true;
		cbbDinhDang9.Location = new System.Drawing.Point(934, 65);
		cbbDinhDang9.Name = "cbbDinhDang9";
		cbbDinhDang9.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang9.TabIndex = 48;
		cbbDinhDang8.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang8.FormattingEnabled = true;
		cbbDinhDang8.Location = new System.Drawing.Point(837, 65);
		cbbDinhDang8.Name = "cbbDinhDang8";
		cbbDinhDang8.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang8.TabIndex = 47;
		E0995912.AutoSize = true;
		E0995912.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E0995912.Location = new System.Drawing.Point(818, 67);
		E0995912.Name = "label2";
		E0995912.Size = new System.Drawing.Size(19, 19);
		E0995912.TabIndex = 50;
		E0995912.Text = "|";
		C3A8973B.AutoSize = true;
		C3A8973B.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C3A8973B.Location = new System.Drawing.Point(915, 67);
		C3A8973B.Name = "label3";
		C3A8973B.Size = new System.Drawing.Size(19, 19);
		C3A8973B.TabIndex = 49;
		C3A8973B.Text = "|";
		B913A78C.BackColor = System.Drawing.Color.DarkOrange;
		B913A78C.Cursor = System.Windows.Forms.Cursors.Hand;
		B913A78C.FlatAppearance.BorderSize = 0;
		B913A78C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B913A78C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B913A78C.ForeColor = System.Drawing.Color.White;
		B913A78C.Location = new System.Drawing.Point(377, 124);
		B913A78C.Name = "button1";
		B913A78C.Size = new System.Drawing.Size(121, 29);
		B913A78C.TabIndex = 4;
		B913A78C.Text = "Reset định dạng";
		B913A78C.UseVisualStyleBackColor = false;
		B913A78C.Click += new System.EventHandler(B913A78C_Click);
		cbbDinhDang10.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang10.FormattingEnabled = true;
		cbbDinhDang10.Location = new System.Drawing.Point(1033, 65);
		cbbDinhDang10.Name = "cbbDinhDang10";
		cbbDinhDang10.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang10.TabIndex = 48;
		CCBFBC96.AutoSize = true;
		CCBFBC96.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CCBFBC96.Location = new System.Drawing.Point(1014, 67);
		CCBFBC96.Name = "label4";
		CCBFBC96.Size = new System.Drawing.Size(19, 19);
		CCBFBC96.TabIndex = 49;
		CCBFBC96.Text = "|";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1122, 165);
		base.Controls.Add(F02F971C);
		base.Controls.Add(cbbDinhDang2);
		base.Controls.Add(cbbDinhDang3);
		base.Controls.Add(cbbDinhDang4);
		base.Controls.Add(CCBFBC96);
		base.Controls.Add(C3A8973B);
		base.Controls.Add(A0B50AA7);
		base.Controls.Add(cbbDinhDang5);
		base.Controls.Add(E0995912);
		base.Controls.Add(cbbDinhDang8);
		base.Controls.Add(ED0F54A7);
		base.Controls.Add(cbbDinhDang6);
		base.Controls.Add(cbbDinhDang10);
		base.Controls.Add(cbbDinhDang9);
		base.Controls.Add(BCBC2A2A);
		base.Controls.Add(cbbDinhDang7);
		base.Controls.Add(label11);
		base.Controls.Add(D5A20B21);
		base.Controls.Add(label10);
		base.Controls.Add(E4BE8BA7);
		base.Controls.Add(B913A78C);
		base.Controls.Add(btnCancel);
		base.Controls.Add(C49277A3);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCopy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fCopy_Load);
		bunifuCards1.ResumeLayout(false);
		AF97F83B.ResumeLayout(false);
		ResumeLayout(false);
		PerformLayout();
	}
}
