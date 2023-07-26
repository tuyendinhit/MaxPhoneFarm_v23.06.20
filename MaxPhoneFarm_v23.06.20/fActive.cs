using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fActive : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class B0124380
	{
		internal static readonly B0124380 _003C_003E9 = new B0124380();

		internal static Action<Process> _003C_003E9__5_1;

		internal static Action<Process> _003C_003E9__5_3;

		internal void B1323839(Process process_0)
		{
			process_0.Kill();
		}

		internal void method_0(Process process_0)
		{
			process_0.Kill();
		}
	}

	[CompilerGenerated]
	private sealed class D68FAA09
	{
		internal fActive fActive_0;

		internal string BF2A22A9;

		internal void method_0()
		{
			fActive_0.lblStatus.Text = Language.GetValue(BF2A22A9);
		}
	}

	[CompilerGenerated]
	private sealed class Class86
	{
		internal string[] string_0;

		internal fActive AC202E0F;

		internal string string_1;

		internal string C036B811;

		internal MethodInvoker D4AE850B;

		internal MethodInvoker methodInvoker_0;

		internal MethodInvoker DEB55882;

		internal MethodInvoker methodInvoker_1;

		internal bool AC34DBAC(Process process_0)
		{
			return string_0.Any(process_0.ProcessName.ToLower().Contains);
		}

		internal bool method_0(Process F4087E96)
		{
			return string_0.Any(F4087E96.MainWindowTitle.ToLower().Contains);
		}

		internal void method_1()
		{
			AC202E0F.btnLogin.Invoke((MethodInvoker)delegate
			{
				AC202E0F.btnLogin.Enabled = false;
			});
			AC202E0F.method_1("Đang kiểm tra đăng nhập...");
			try
			{
				new GClass13();
				new Random();
				string text = Common.smethod_3(string_1, C036B811);
				if (text.Trim() == "")
				{
					AC202E0F.method_1(AC202E0F.method_0(4));
					AC202E0F.btnLogin.Invoke((MethodInvoker)delegate
					{
						AC202E0F.btnLogin.Enabled = true;
					});
					return;
				}
				string text2 = Common.smethod_2(text, 70.ToString());
				bool flag = false;
				if (text2.Trim() == "")
				{
					flag = true;
					AC202E0F.method_1(AC202E0F.method_0(5));
				}
				else if (text2.Contains("chuakichhoat"))
				{
					flag = true;
					AC202E0F.method_1(AC202E0F.method_0(2));
				}
				else if (text2.Contains("hethan"))
				{
					flag = true;
					AC202E0F.method_1(AC202E0F.method_0(3));
				}
				if (flag)
				{
					AC202E0F.btnLogin.Invoke((MethodInvoker)delegate
					{
						AC202E0F.btnLogin.Enabled = true;
					});
					return;
				}
				_ = text2.Split('|')[0];
				_ = text2.Split('|')[1];
				_ = text2.Split('|')[2];
				_ = text2.Split('|')[3];
				_ = text2.Split('|')[4];
				_ = text2.Split('|')[5];
				AC202E0F.method_1("Đăng nhập thành công!");
				MessageBoxHelper.Show(Language.GetValue("Thiết bị của bạn đã được kích hoạt, cảm ơn đã sử dụng phần mềm của Min Software.") + "\r\n" + Language.GetValue("Vui lòng mở lại phần mềm để sử dụng!"));
                SettingsTool.GetSettings("settingLogin").GetValue("UserName", (object)string_1);
                SettingsTool.GetSettings("settingLogin").GetValue("PassWord", (object)C036B811);
				SettingsTool.smethod_0("settingLogin");
				Environment.Exit(0);
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_, "Active error");
				MessageBoxHelper.Show("Lỗi không xác định!!!", 2);
				AC202E0F.btnLogin.Invoke((MethodInvoker)delegate
				{
					AC202E0F.btnLogin.Enabled = true;
				});
			}
		}

		internal void A58FF717()
		{
			AC202E0F.btnLogin.Enabled = false;
		}

		internal void method_2()
		{
			AC202E0F.btnLogin.Enabled = true;
		}

		internal void method_3()
		{
			AC202E0F.btnLogin.Enabled = true;
		}

		internal void A68055A5()
		{
			AC202E0F.btnLogin.Enabled = true;
		}
	}

	internal int int_0 = 0;

	internal Bitmap D634E784 = Resource.E71E1C92;

	internal Bitmap CD35429C = Resource.EF0A430E;

	internal IContainer icontainer_0 = null;

	internal BunifuCards F01E1D1D;

	internal Panel pnlHeader;

	internal PictureBox C0980D1B;

	internal BunifuCustomLabel A82DC100;

	internal BunifuMetroTextbox EB2C929C;

	internal BunifuCustomLabel A0A9B29B;

	internal BunifuCustomLabel bunifuCustomLabel3;

	internal BunifuMetroTextbox BB143027;

	internal Button btnLogin;

	internal Label lblStatus;

	internal LinkLabel B210EBB9;

	internal Label label1;

	internal Button btnMinimize;

	internal BunifuDragControl A80FD694;

	internal PictureBox pictureBox2;

	internal BunifuCustomLabel bunifuCustomLabel8;

	internal BunifuCustomLabel bunifuCustomLabel5;

	internal BunifuCustomLabel bunifuCustomLabel6;

	internal BunifuCustomLabel bunifuCustomLabel4;

	internal BunifuCustomLabel C69AF006;

	internal BunifuCustomLabel bunifuCustomLabel7;

	internal BunifuDragControl FD0F4E01;

	internal PictureBox picLanguage;

	internal LinkLabel DE3075AC;

	internal Label label2;

	public fActive(int int_1)
	{
		InitializeComponent();
		int_0 = int_1;
		lblStatus.Text = method_0(int_1);
		C69AF006.Text = Common.smethod_0();
		picLanguage.Image = ((Base.smethod_0() != "VN") ? D634E784 : CD35429C);
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}

	private string method_0(int int_1 = 0)
	{
		return int_1 switch
		{
			0 => "", 
			1 => Language.GetValue("Vui lòng đăng nhập để sử dụng phần mềm!!!"), 
			2 => Language.GetValue("Thiết bị của bạn chưa được kích hoạt!!!"), 
			3 => Language.GetValue("Thiết bị của bạn đã hết hạn sử dụng!!!"), 
			4 => Language.GetValue("Tài khoản hoặc mật khẩu bạn nhập không đúng!!!"), 
			_ => Language.GetValue("Lỗi không xác định!"), 
		};
	}

	private void method_1(string B032BA98)
	{
		lblStatus.Invoke((MethodInvoker)delegate
		{
			lblStatus.Text = Language.GetValue(B032BA98);
		});
	}

	private void D3350930(object sender, EventArgs e)
	{
		string[] string_0 = new string[6] { "fiddler", "charles", "wireshark", "burp", "dnspy", "megadumper" };
		(from process_0 in Process.GetProcesses()
			where string_0.Any(process_0.ProcessName.ToLower().Contains)
			select process_0).ToList().ForEach(delegate(Process process_0)
		{
			process_0.Kill();
		});
		(from F4087E96 in Process.GetProcesses()
			where string_0.Any(F4087E96.MainWindowTitle.ToLower().Contains)
			select F4087E96).ToList().ForEach(delegate(Process process_0)
		{
			process_0.Kill();
		});
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			MessageBoxHelper.Show("Vui lòng chạy bằng quyền Admin!\r\nPlease Run Aplication As Administrator!");
			Environment.Exit(0);
		}
		string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
		if (File.Exists(path))
		{
			try
			{
				List<string> list = new List<string> { "minsoftware" };
				using StreamReader streamReader = new StreamReader(path);
				string empty = string.Empty;
				while ((empty = streamReader.ReadLine()) != null)
				{
					foreach (string item in list)
					{
						if (empty.ToLower().Contains(item))
						{
							MessageBoxHelper.Show("Vui lòng cấu hình lại file hosts nếu muốn mở phần mềm!", 2);
							Environment.Exit(0);
						}
					}
				}
			}
			catch
			{
				MessageBoxHelper.Show("Vui lòng cấu hình lại file hosts nếu muốn mở phần mềm!", 2);
				Environment.Exit(0);
			}
		}
		string string_1 = EB2C929C.Text.Trim();
		string C036B811 = BB143027.Text.Trim();
		if (string_1 == "" || C036B811 == "")
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lòng điền đầy đủ thông tin!"), 3);
			return;
		}
		if (!string_1.Contains("@"))
		{
			string_1 += "@gmail.com";
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			btnLogin.Invoke((MethodInvoker)delegate
			{
				btnLogin.Enabled = false;
			});
			method_1("Đang kiểm tra đăng nhập...");
			try
			{
				new GClass13();
				new Random();
				string text = Common.smethod_3(string_1, C036B811);
				if (text.Trim() == "")
				{
					method_1(method_0(4));
					btnLogin.Invoke((MethodInvoker)delegate
					{
						btnLogin.Enabled = true;
					});
				}
				else
				{
					string text2 = Common.smethod_2(text, 70.ToString());
					bool flag = false;
					if (text2.Trim() == "")
					{
						flag = true;
						method_1(method_0(5));
					}
					else if (text2.Contains("chuakichhoat"))
					{
						flag = true;
						method_1(method_0(2));
					}
					else if (text2.Contains("hethan"))
					{
						flag = true;
						method_1(method_0(3));
					}
					if (flag)
					{
						btnLogin.Invoke((MethodInvoker)delegate
						{
							btnLogin.Enabled = true;
						});
					}
					else
					{
						_ = text2.Split('|')[0];
						_ = text2.Split('|')[1];
						_ = text2.Split('|')[2];
						_ = text2.Split('|')[3];
						_ = text2.Split('|')[4];
						_ = text2.Split('|')[5];
						method_1("Đăng nhập thành công!");
						MessageBoxHelper.Show(Language.GetValue("Thiết bị của bạn đã được kích hoạt, cảm ơn đã sử dụng phần mềm của Min Software.") + "\r\n" + Language.GetValue("Vui lòng mở lại phần mềm để sử dụng!"));
                        SettingsTool.GetSettings("settingLogin").GetValue("UserName", (object)string_1);
                        SettingsTool.GetSettings("settingLogin").GetValue("PassWord", (object)C036B811);
						SettingsTool.smethod_0("settingLogin");
						Environment.Exit(0);
					}
				}
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_, "Active error");
				MessageBoxHelper.Show("Lỗi không xác định!!!", 2);
				btnLogin.Invoke((MethodInvoker)delegate
				{
					btnLogin.Enabled = true;
				});
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void fActive_FormClosing(object sender, FormClosingEventArgs e)
	{
		Environment.Exit(0);
	}

	private void DC080AB3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("chrome.exe", "http://app.minsoftware.xyz/signup");
		}
		catch
		{
			Process.Start("http://app.minsoftware.xyz/signup");
		}
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		Common.SetTextToClipboard(C69AF006.Text);
		MessageBoxHelper.Show(Language.GetValue("Đã copy mã thiết bị!"));
	}

	private void BB143027_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			D3350930(null, null);
		}
	}

	private void picLanguage_Click(object sender, EventArgs e)
	{
		if (picLanguage.Image == D634E784)
		{
			picLanguage.Image = CD35429C;
			Base.C891C93E();
			MessageBoxHelper.Show("Vui lòng mở lại phần mềm để cập nhật ngôn ngữ!");
		}
		else
		{
			picLanguage.Image = D634E784;
			Base.C891C93E("EN");
		}
		Base.smethod_0();
		Language.SetLanguage(this);
	}

	private void DE3075AC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://bit.ly/DieukhoanvaChinhsach";
		try
		{
			Process.Start("chrome.exe", text);
		}
		catch
		{
			Process.Start(text);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fActive));
		F01E1D1D = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		picLanguage = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		C0980D1B = new System.Windows.Forms.PictureBox();
		A82DC100 = new Bunifu.Framework.UI.BunifuCustomLabel();
		EB2C929C = new Bunifu.Framework.UI.BunifuMetroTextbox();
		A0A9B29B = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
		BB143027 = new Bunifu.Framework.UI.BunifuMetroTextbox();
		btnLogin = new System.Windows.Forms.Button();
		lblStatus = new System.Windows.Forms.Label();
		B210EBB9 = new System.Windows.Forms.LinkLabel();
		label1 = new System.Windows.Forms.Label();
		A80FD694 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pictureBox2 = new System.Windows.Forms.PictureBox();
		bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
		C69AF006 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
		FD0F4E01 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		DE3075AC = new System.Windows.Forms.LinkLabel();
		label2 = new System.Windows.Forms.Label();
		F01E1D1D.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)picLanguage).BeginInit();
		((System.ComponentModel.ISupportInitialize)C0980D1B).BeginInit();
		((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
		SuspendLayout();
		F01E1D1D.BackColor = System.Drawing.Color.White;
		F01E1D1D.BorderRadius = 0;
		F01E1D1D.BottomSahddow = true;
		F01E1D1D.color = System.Drawing.Color.SaddleBrown;
		F01E1D1D.Controls.Add(pnlHeader);
		F01E1D1D.LeftSahddow = false;
		F01E1D1D.Location = new System.Drawing.Point(0, 0);
		F01E1D1D.Name = "bunifuCards1";
		F01E1D1D.RightSahddow = true;
		F01E1D1D.ShadowDepth = 20;
		F01E1D1D.Size = new System.Drawing.Size(395, 38);
		F01E1D1D.TabIndex = 11;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(picLanguage);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(C0980D1B);
		pnlHeader.Controls.Add(A82DC100);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(393, 32);
		pnlHeader.TabIndex = 9;
		picLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		picLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
		picLanguage.Image = Resource.EF0A430E;
		picLanguage.Location = new System.Drawing.Point(330, 2);
		picLanguage.Name = "picLanguage";
		picLanguage.Size = new System.Drawing.Size(25, 25);
		picLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		picLanguage.TabIndex = 14;
		picLanguage.TabStop = false;
		picLanguage.Click += new System.EventHandler(picLanguage_Click);
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(361, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 13;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		C0980D1B.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		C0980D1B.Location = new System.Drawing.Point(6, 2);
		C0980D1B.Name = "pictureBox1";
		C0980D1B.Size = new System.Drawing.Size(34, 27);
		C0980D1B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		C0980D1B.TabIndex = 12;
		C0980D1B.TabStop = false;
		A82DC100.AutoSize = true;
		A82DC100.BackColor = System.Drawing.Color.Transparent;
		A82DC100.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A82DC100.ForeColor = System.Drawing.Color.Black;
		A82DC100.Location = new System.Drawing.Point(42, 7);
		A82DC100.Name = "bunifuCustomLabel1";
		A82DC100.Size = new System.Drawing.Size(268, 16);
		A82DC100.TabIndex = 7;
		A82DC100.Text = "MAX PHONE FARM - Kích hoạt bản quyền";
		EB2C929C.BorderColorFocused = System.Drawing.Color.FromArgb(192, 64, 0);
		EB2C929C.BorderColorIdle = System.Drawing.Color.FromArgb(64, 64, 64);
		EB2C929C.BorderColorMouseHover = System.Drawing.Color.FromArgb(192, 64, 0);
		EB2C929C.BorderThickness = 3;
		EB2C929C.Cursor = System.Windows.Forms.Cursors.IBeam;
		EB2C929C.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EB2C929C.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
		EB2C929C.isPassword = false;
		EB2C929C.Location = new System.Drawing.Point(117, 46);
		EB2C929C.Margin = new System.Windows.Forms.Padding(4);
		EB2C929C.Name = "txbUserName";
		EB2C929C.Size = new System.Drawing.Size(228, 29);
		EB2C929C.TabIndex = 0;
		EB2C929C.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
		EB2C929C.KeyDown += new System.Windows.Forms.KeyEventHandler(BB143027_KeyDown);
		A0A9B29B.AutoSize = true;
		A0A9B29B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A0A9B29B.Location = new System.Drawing.Point(37, 52);
		A0A9B29B.Name = "bunifuCustomLabel2";
		A0A9B29B.Size = new System.Drawing.Size(44, 16);
		A0A9B29B.TabIndex = 13;
		A0A9B29B.Text = "Email:";
		bunifuCustomLabel3.AutoSize = true;
		bunifuCustomLabel3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel3.Location = new System.Drawing.Point(37, 91);
		bunifuCustomLabel3.Name = "bunifuCustomLabel3";
		bunifuCustomLabel3.Size = new System.Drawing.Size(72, 16);
		bunifuCustomLabel3.TabIndex = 15;
		bunifuCustomLabel3.Text = "Mật khẩu:";
		BB143027.BorderColorFocused = System.Drawing.Color.FromArgb(192, 64, 0);
		BB143027.BorderColorIdle = System.Drawing.Color.FromArgb(64, 64, 64);
		BB143027.BorderColorMouseHover = System.Drawing.Color.FromArgb(192, 64, 0);
		BB143027.BorderThickness = 3;
		BB143027.Cursor = System.Windows.Forms.Cursors.IBeam;
		BB143027.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BB143027.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
		BB143027.isPassword = true;
		BB143027.Location = new System.Drawing.Point(117, 83);
		BB143027.Margin = new System.Windows.Forms.Padding(4);
		BB143027.Name = "txbPassword";
		BB143027.Size = new System.Drawing.Size(228, 29);
		BB143027.TabIndex = 1;
		BB143027.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
		BB143027.KeyDown += new System.Windows.Forms.KeyEventHandler(BB143027_KeyDown);
		btnLogin.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
		btnLogin.FlatAppearance.BorderSize = 0;
		btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnLogin.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnLogin.ForeColor = System.Drawing.Color.White;
		btnLogin.Location = new System.Drawing.Point(149, 136);
		btnLogin.Name = "btnLogin";
		btnLogin.Size = new System.Drawing.Size(115, 29);
		btnLogin.TabIndex = 2;
		btnLogin.Text = "Đăng nhập";
		btnLogin.UseVisualStyleBackColor = false;
		btnLogin.Click += new System.EventHandler(D3350930);
		lblStatus.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.ForeColor = System.Drawing.Color.Red;
		lblStatus.Location = new System.Drawing.Point(10, 115);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(371, 18);
		lblStatus.TabIndex = 28;
		lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B210EBB9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B210EBB9.AutoSize = true;
		B210EBB9.Cursor = System.Windows.Forms.Cursors.Hand;
		B210EBB9.LinkColor = System.Drawing.Color.FromArgb(53, 120, 229);
		B210EBB9.Location = new System.Drawing.Point(292, 211);
		B210EBB9.Name = "linkLabel1";
		B210EBB9.Size = new System.Drawing.Size(27, 16);
		B210EBB9.TabIndex = 3;
		B210EBB9.TabStop = true;
		B210EBB9.Text = "đây";
		B210EBB9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(DC080AB3);
		label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(105, 211);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(187, 16);
		label1.TabIndex = 30;
		label1.Text = "Đăng ký tài khoản mới bấm vào";
		label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		A80FD694.Fixed = true;
		A80FD694.Horizontal = true;
		A80FD694.TargetControl = pnlHeader;
		A80FD694.Vertical = true;
		pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
		pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
		pictureBox2.Location = new System.Drawing.Point(357, 247);
		pictureBox2.Name = "pictureBox2";
		pictureBox2.Size = new System.Drawing.Size(20, 20);
		pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		pictureBox2.TabIndex = 42;
		pictureBox2.TabStop = false;
		pictureBox2.Click += new System.EventHandler(pictureBox2_Click);
		bunifuCustomLabel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		bunifuCustomLabel8.AutoSize = true;
		bunifuCustomLabel8.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel8.ForeColor = System.Drawing.Color.Gray;
		bunifuCustomLabel8.Location = new System.Drawing.Point(224, 234);
		bunifuCustomLabel8.Name = "bunifuCustomLabel8";
		bunifuCustomLabel8.Size = new System.Drawing.Size(140, 13);
		bunifuCustomLabel8.TabIndex = 40;
		bunifuCustomLabel8.Text = "https://minsoftware.vn";
		bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		bunifuCustomLabel5.AutoSize = true;
		bunifuCustomLabel5.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel5.ForeColor = System.Drawing.Color.Gray;
		bunifuCustomLabel5.Location = new System.Drawing.Point(73, 234);
		bunifuCustomLabel5.Name = "bunifuCustomLabel5";
		bunifuCustomLabel5.Size = new System.Drawing.Size(83, 13);
		bunifuCustomLabel5.TabIndex = 41;
		bunifuCustomLabel5.Text = "0358.39.4040";
		bunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		bunifuCustomLabel6.AutoSize = true;
		bunifuCustomLabel6.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel6.Location = new System.Drawing.Point(168, 234);
		bunifuCustomLabel6.Name = "bunifuCustomLabel6";
		bunifuCustomLabel6.Size = new System.Drawing.Size(56, 13);
		bunifuCustomLabel6.TabIndex = 38;
		bunifuCustomLabel6.Text = "Website:";
		bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		bunifuCustomLabel4.AutoSize = true;
		bunifuCustomLabel4.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel4.Location = new System.Drawing.Point(22, 234);
		bunifuCustomLabel4.Name = "bunifuCustomLabel4";
		bunifuCustomLabel4.Size = new System.Drawing.Size(53, 13);
		bunifuCustomLabel4.TabIndex = 39;
		bunifuCustomLabel4.Text = "Hotline: ";
		C69AF006.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		C69AF006.AutoSize = true;
		C69AF006.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C69AF006.ForeColor = System.Drawing.Color.Gray;
		C69AF006.Location = new System.Drawing.Point(94, 252);
		C69AF006.Name = "lblKey";
		C69AF006.Size = new System.Drawing.Size(231, 13);
		C69AF006.TabIndex = 37;
		C69AF006.Text = "********************************";
		bunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		bunifuCustomLabel7.AutoSize = true;
		bunifuCustomLabel7.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel7.Location = new System.Drawing.Point(22, 252);
		bunifuCustomLabel7.Name = "bunifuCustomLabel7";
		bunifuCustomLabel7.Size = new System.Drawing.Size(70, 13);
		bunifuCustomLabel7.TabIndex = 36;
		bunifuCustomLabel7.Text = "Mã thiết bị:";
		FD0F4E01.Fixed = true;
		FD0F4E01.Horizontal = true;
		FD0F4E01.TargetControl = A82DC100;
		FD0F4E01.Vertical = true;
		DE3075AC.Cursor = System.Windows.Forms.Cursors.Hand;
		DE3075AC.Location = new System.Drawing.Point(153, 187);
		DE3075AC.Name = "linkLabel2";
		DE3075AC.Size = new System.Drawing.Size(109, 16);
		DE3075AC.TabIndex = 50;
		DE3075AC.TabStop = true;
		DE3075AC.Text = "(Xem điều khoản)";
		DE3075AC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DE3075AC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(DE3075AC_LinkClicked);
		label2.ForeColor = System.Drawing.Color.Red;
		label2.Location = new System.Drawing.Point(0, 168);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(393, 16);
		label2.TabIndex = 49;
		label2.Text = "Khi đăng nhập, bạn đã đồng ý với điều khoản của chúng tôi!";
		label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(393, 277);
		base.Controls.Add(DE3075AC);
		base.Controls.Add(label2);
		base.Controls.Add(pictureBox2);
		base.Controls.Add(bunifuCustomLabel8);
		base.Controls.Add(bunifuCustomLabel5);
		base.Controls.Add(bunifuCustomLabel6);
		base.Controls.Add(bunifuCustomLabel4);
		base.Controls.Add(C69AF006);
		base.Controls.Add(bunifuCustomLabel7);
		base.Controls.Add(B210EBB9);
		base.Controls.Add(label1);
		base.Controls.Add(lblStatus);
		base.Controls.Add(btnLogin);
		base.Controls.Add(bunifuCustomLabel3);
		base.Controls.Add(BB143027);
		base.Controls.Add(A0A9B29B);
		base.Controls.Add(EB2C929C);
		base.Controls.Add(F01E1D1D);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "fActive";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "MAX PHONE FARM";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(fActive_FormClosing);
		F01E1D1D.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		pnlHeader.PerformLayout();
		((System.ComponentModel.ISupportInitialize)picLanguage).EndInit();
		((System.ComponentModel.ISupportInitialize)C0980D1B).EndInit();
		((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
