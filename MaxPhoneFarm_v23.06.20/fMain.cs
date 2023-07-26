using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;
using WindowsFormsControlLibrary1;

public class fMain : Form
{
    internal Random random_0 = new Random();

	internal bool bool_0;

	internal static fMain fMain_0;

	internal List<Thread> list_0 = null;

	internal Thread FDA57818 = null;

	internal List<string> list_1 = null;

	internal List<string> list_2 = new List<string>();

	internal List<string> CEBE77B6 = new List<string>();

	internal List<A4AF3582> list_3 = null;

	internal List<string> list_4 = null;

	internal List<string> list_5 = null;

	internal List<Class27> list_6 = null;

	internal List<string> B8BDDBB3 = null;

	internal List<Class6> list_7 = null;

	internal List<string> list_8 = null;

	internal List<Class7> A2817D31 = null;

	internal List<string> list_9 = null;

	internal List<Class4> list_10 = null;

	internal List<string> A625580B = null;

	internal List<GClass4> F284EF3B = null;

	internal List<GClass3> list_11 = null;

	internal List<string> list_12 = null;

	internal Dictionary<string, List<string>> dictionary_0 = null;

	internal Dictionary<string, List<string>> dictionary_1 = null;

	internal Dictionary<string, List<string>> C61991A0 = null;

	internal Dictionary<string, List<string>> dictionary_2 = null;

	internal Dictionary<string, List<string>> dictionary_3 = null;

	internal Dictionary<string, List<string>> dictionary_4 = null;

	internal Dictionary<string, List<string>> B68B3D0D = null;

	internal Dictionary<string, List<string>> E2AC9E1F = null;

	internal Dictionary<string, List<string>> dictionary_5 = null;

	internal Dictionary<string, List<string>> C292E829 = null;

	internal Dictionary<string, List<string>> dictionary_6 = null;

	internal Dictionary<string, List<string>> dictionary_7 = null;

	internal Dictionary<string, List<string>> C8289C88 = null;

	internal Dictionary<string, List<string>> F605BBA9 = null;

	internal Dictionary<string, List<string>> CAB1A00C = null;

	internal Dictionary<string, List<string>> dictionary_8 = null;

	internal Dictionary<string, List<string>> C50FA08A = null;

	internal Dictionary<string, List<string>> dictionary_9 = null;

	internal Dictionary<string, List<string>> dictionary_10 = null;

	internal Dictionary<string, List<string>> C42A3EA1 = null;

	internal Dictionary<string, List<string>> dictionary_11 = null;

	internal Dictionary<string, List<string>> dictionary_12 = null;

	internal Dictionary<string, Dictionary<string, int>> D80EF33F = null;

	internal object C93B70AC = new object();

	internal object object_0 = new object();

	internal int BF1E1492 = 0;

	internal object object_1 = new object();

	internal object B7A06AA0 = new object();

	internal object BA9050A1 = new object();

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal object object_2 = new object();

	internal object D739380E = new object();

	internal object B6A38A39 = new object();

	internal object object_3 = new object();

	internal object FF808304 = new object();

	internal object A894A284 = new object();

	internal object object_4 = new object();

	internal object object_5 = new object();

	internal object object_6 = new object();

	internal bool bool_1 = false;

	internal int int_0 = -1;

	internal bool E7A6A48F = true;

	internal object object_7 = new object();

	internal object C2B32D21 = new object();

	internal object object_8 = new object();

	internal object object_9 = new object();

	internal object E33BD2AE = new object();

	internal int AC974180 = -1;

	internal bool bool_2 = true;

	internal bool bool_3 = false;

	internal object object_10 = new object();

	internal Bitmap bitmap_0 = Resource.E71E1C92;

	internal Bitmap bitmap_1 = Resource.EF0A430E;

	internal int A29C1486 = 0;

	internal IContainer CA33E616 = null;

	internal DataGridView dtgvAcc;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuCards bunifuCards1;

	internal Panel DF05800B;

	internal PictureBox pictureBox1;

	internal Button button2;

	internal Button button1;

	internal Button btnMinimize;

	internal MenuStrip menuStrip1;

	internal ToolStripMenuItem A6014E37;

	internal ToolStripMenuItem toolStripMenuItem_0;

	internal Label EDBAB4B7;

	internal ComboBox cbbThuMuc;

	internal ContextMenuStrip ctmsAcc;

	internal ToolStripMenuItem F033EF83;

	internal ToolStripMenuItem liveToolStripMenuItem;

	internal ToolStripMenuItem B735D685;

	internal ToolStripMenuItem tokenToolStripMenuItem;

	internal ToolStripMenuItem FE155729;

	internal ToolStripMenuItem uidPassToolStripMenuItem;

	internal ToolStripMenuItem AD1A1C09;

	internal ToolStripMenuItem toolStripMenuItem_1;

	internal ToolStripMenuItem toolStripMenuItem_2;

	internal ToolStripMenuItem checkCookieToolStripMenuItem;

	internal ToolStripMenuItem C3A2FC8E;

	internal ToolStripMenuItem toolStripMenuItem_3;

	internal ToolStripMenuItem E4184ABA;

	internal Button btnInteract;

	internal ToolStripMenuItem toolStripMenuItem_4;

	internal ToolStripMenuItem toolStripMenuItem_5;

	internal ToolStripMenuItem toolStripMenuItem_6;

	internal ToolStripMenuItem F9841C0B;

	internal ToolStripMenuItem toolStripMenuItem_7;

	internal ToolStripMenuItem tokenToolStripMenuItem2;

	internal ToolStripMenuItem cookieToolStripMenuItem3;

	internal Button btnPause;

	internal ToolStripMenuItem toolStripMenuItem_8;

	internal ToolStripMenuItem A3040DA2;

	internal ToolStripMenuItem FB980FA5;

	internal ToolStripMenuItem A12C7CB7;

	internal ToolStripMenuItem toolStripMenuItem_9;

	internal BunifuCustomTextbox FFAFC3B3;

	internal ToolStripMenuItem DE23BE8B;

	internal ToolStripMenuItem toolStripMenuItem_10;

	internal ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;

	internal StatusStrip statusStrip1;

	internal ToolStripStatusLabel EBA6FB27;

	internal ToolStripStatusLabel lblStatus;

	internal ToolStripStatusLabel DA0FAD16;

	internal ToolStripStatusLabel lblKey;

	internal ToolStripStatusLabel D30FF534;

	internal ToolStripStatusLabel lblCountDeviceRunning;

	internal ToolStripStatusLabel E7A0700F;

	internal ToolStripStatusLabel txbUid;

	internal ToolStripStatusLabel lblUser;

	internal ToolStripStatusLabel toolStripStatusLabel9;

	internal ToolStripStatusLabel toolStripStatusLabel10;

	internal ToolStripStatusLabel CE1C833B;

	internal ToolStripStatusLabel lblCountSelect;

	internal ToolStripMenuItem fAToolStripMenuItem;

	internal ToolStripMenuItem tinhTrangToolStripMenuItem;

	internal ToolStripMenuItem locTrungToolStripMenuItem;

	internal ToolStripMenuItem A1AED3A8;

	internal BunifuDragControl bunifuDragControl_1;

	internal ToolTip toolTip_0;

	internal ToolStripMenuItem toolStripMenuItem_11;

	internal ToolStripMenuItem toolStripMenuItem_12;

	internal ToolStripMenuItem AA83531A;

	internal ToolStripMenuItem toolStripMenuItem_13;

	internal ToolStripMenuItem toolStripMenuItem_14;

	internal ToolStripMenuItem toolStripMenuItem_15;

	internal ToolStripMenuItem useragentToolStripMenuItem;

	internal ToolStripMenuItem EE1661AD;

	internal ToolStripMenuItem E3108B09;

	internal ToolStripMenuItem F703662A;

	internal ComboBox cbbSearch;

	internal ToolStripMenuItem C41205B6;

	internal ToolStripMenuItem CAAE0387;

	internal Button btnAddFile;

	internal Button btnDeleteFile;

	internal Button EA12B498;

	internal ComboBox cbbTinhTrang;

	internal Label label2;

	internal Button A18F7693;

	internal ToolStripMenuItem toolStripMenuItem_16;

	internal Panel plTrangThai;

	internal Label lblTrangThai;

	internal ToolStripMenuItem F822A922;

	internal ToolStripMenuItem checkAvatarToolStripMenuItem;

	internal ToolStripMenuItem A2051002;

	internal ToolStripMenuItem toolStripMenuItem_17;

	internal ToolStripMenuItem checkInfoUIDToolStripMenuItem;

	internal ToolStripMenuItem toolStripMenuItem_18;

	internal ToolStripMenuItem B02753B5;

	internal ToolStripMenuItem toolStripMenuItem_19;

	internal ToolStripMenuItem toolStripMenuItem_20;

	internal ToolStripMenuItem B481DD21;

	internal Button btnEditFile;

	internal ToolStripMenuItem BE3278AB;

	internal ToolStripMenuItem toolStripMenuItem_21;

	internal ToolStripMenuItem lToolStripMenuItem;

	internal ToolStripMenuItem toolStripMenuItem_22;

	internal ToolStripMenuItem checkLiveUidToolStripMenuItem;

	internal Panel panel1;

	internal ToolStripMenuItem D4129739;

	internal ToolStripStatusLabel lblDateExpried;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal ToolStripMenuItem BD85F20D;

	internal ToolStripStatusLabel toolStripStatusLabel4;

	internal ToolStripStatusLabel CCACF12E;

	internal ToolStripMenuItem D2359803;

	internal NotifyIcon notifyIcon_0;

	internal ToolStripMenuItem profileToolStripMenuItem;

	internal ToolStripStatusLabel toolStripStatusLabel2;

	internal ToolStripStatusLabel lblCountTotal;

	internal ToolStripMenuItem toolStripMenuItem_23;

	internal ToolStripMenuItem CF8DC72F;

	internal ToolStripMenuItem toolStripMenuItem3;

	internal PictureBox picLanguage;

	internal ToolStripMenuItem copyDataDeviceToolStripMenuItem;

	internal ToolStripMenuItem toolStripMenuItem_24;

	internal ToolStripMenuItem AF8E5F17;

	internal ToolStripMenuItem unlockCheckpointToolStripMenuItem;

	internal ToolStripMenuItem C0318199;

	internal ToolStripMenuItem checkFileBackupGroupToolStripMenuItem;

	internal ToolStripMenuItem toolStripMenuItem_25;

	internal ToolStripMenuItem backupGroupToolStripMenuItem;

	internal ToolStripMenuItem toolStripMenuItem_26;

	internal Panel panel2;

	internal Panel plQuanLyThuMuc;

	internal Button BtnSearch;

	internal ToolStripMenuItem toolStripMenuItem_27;

	internal ToolStripMenuItem toolStripMenuItem_28;

	internal ToolStripMenuItem CEAD541D;

	internal ToolStripMenuItem testSpinTextToolStripMenuItem;

	internal ToolStripMenuItem B41C13A7;

	internal ToolStripMenuItem loginPhoneToolStripMenuItem;

	internal ToolStripMenuItem C60F910E;

	internal ToolStripMenuItem toolStripMenuItem7;

	internal ToolStripMenuItem toolStripMenuItem8;

	internal ToolStripMenuItem donDepProfileToolStripMenuItem;

	internal ToolStripMenuItem toolStripMenuItem9;

	internal DataGridViewCheckBoxColumn FD96692B;

	internal DataGridViewTextBoxColumn cStt;

	internal DataGridViewTextBoxColumn cId;

	internal DataGridViewTextBoxColumn cUid;

	internal DataGridViewTextBoxColumn cToken;

	internal DataGridViewTextBoxColumn C6BC568F;

	internal DataGridViewTextBoxColumn BC260A35;

	internal DataGridViewTextBoxColumn cPhone;

	internal DataGridViewTextBoxColumn cName;

	internal DataGridViewTextBoxColumn cFollow;

	internal DataGridViewTextBoxColumn AC2B6237;

	internal DataGridViewTextBoxColumn cGroup;

	internal DataGridViewTextBoxColumn cBirthday;

	internal DataGridViewTextBoxColumn cGender;

	internal DataGridViewTextBoxColumn cPassword;

	internal DataGridViewTextBoxColumn cMailRecovery;

	internal DataGridViewTextBoxColumn EF2018BD;

	internal DataGridViewTextBoxColumn B405F6B2;

	internal DataGridViewTextBoxColumn CE81988A;

	internal DataGridViewTextBoxColumn B00DD887;

	internal DataGridViewTextBoxColumn cProxy;

	internal DataGridViewTextBoxColumn cDateCreateAcc;

	internal DataGridViewTextBoxColumn cAvatar;

	internal DataGridViewTextBoxColumn cProfile;

	internal DataGridViewTextBoxColumn cThuMuc;

	internal DataGridViewTextBoxColumn cInteractEnd;

	internal DataGridViewTextBoxColumn AEB27D00;

	internal DataGridViewTextBoxColumn cInfo;

	internal DataGridViewTextBoxColumn cGhiChu;

	internal DataGridViewTextBoxColumn cDeviceId;

	internal DataGridViewTextBoxColumn cIp;

	internal DataGridViewTextBoxColumn cStatus;

	internal ToolStripMenuItem toolStripMenuItem_29;

	internal ToolStripMenuItem BCBAFC26;

	internal ToolStripMenuItem E4A13219;

	internal ToolStripMenuItem regAccTiktokToolStripMenuItem;

	internal ToolStripMenuItem getTokencookieToolStripMenuItem;

	internal ToolStripMenuItem regCloneToolStripMenuItem;

	internal ToolStripMenuItem checkInfoDeviceToolStripMenuItem;


	public fMain(string log)
	{
		InitializeComponent();
		picLanguage.Image = ((Base.smethod_0() != "VN") ? bitmap_0 : bitmap_1);
		if (log != "")
		{
			string[] array = log.Split('|');
			lblDateExpried.Text = Convert.ToDateTime(array[2]).ToString("dd/MM/yyyy");
			lblKey.Text = ((array[3].Length < 13) ? "MIN" : array[3].Substring(0, 12)) + "****";
			lblUser.Text = array[0];
			Base.int_1 = Convert.ToInt32(array[5]);
		}
		fMain_0 = this;
		method_0();
		FFAFC3B3.smethod_3();
	}

	private void method_0()
	{
		Language.SetLanguage(this);
		Language.smethod_5(ctmsAcc);
		bunifuCustomLabel1.Text = bunifuCustomLabel1.Text.Split('-')[0] + "- " + Language.GetValue(bunifuCustomLabel1.Text.Split('-')[1].Trim()) + " - MIN SOFTWARE";
		BunifuCustomLabel bunifuCustomLabel = bunifuCustomLabel1;
		bunifuCustomLabel.Text = bunifuCustomLabel.Text + " (" + Base.int_1 + " Devices)";
	}

	protected override void OnLoad(EventArgs EEA88DBF)
	{
		Application.Idle += method_1;
	}

	private void method_1(object sender, EventArgs e)
	{
		Application.Idle -= method_1;
		/*if (!File.Exists("AutoUpdate.exe") || new FileInfo("AutoUpdate.exe").Length != 534016L)
		{
			Common.EDB3F1B7("https://download.minsoftware.vn/download/AutoUpdate.zip");
		}
		if (!File.Exists("app\\maxchange.apk") || new FileInfo("app\\maxchange.apk").Length != 2971884L)
		{
			Common.EDB3F1B7("https://download.minsoftware.vn/download/maxchangenew.zip");
		}*/
		if (!File.Exists("dll\\x64\\OpenCvSharpExtern.dll") || !File.Exists("dll\\x86\\OpenCvSharpExtern.dll"))
		{
			Common.EDB3F1B7("https://download.minsoftware.vn/OpenCvSharp/dll.zip");
		}
		if (!File.Exists("app\\collegeproxy.apk") || new FileInfo("app\\collegeproxy.apk").Length != 6811185L)
		{
			Common.EDB3F1B7("https://download.minsoftware.vn/download/collegeproxy.zip");
		}
		lblStatus.Text = Language.GetValue("Đã kích hoạt");
		Base.string_3 = GClass12.smethod_14();
		SetupFolder.StartApplication();
		method_3();
		method_121();
		method_4(1);
		DE81740C();
		menuStrip1.Cursor = Cursors.Hand;
	}

	public void method_2(int FB123F30)
	{
		try
		{
			statusStrip1.Invoke((MethodInvoker)delegate
			{
				lblCountDeviceRunning.Text = FB123F30.ToString();
			});
		}
		catch
		{
		}
	}

	private void method_3()
	{
		Dictionary<string, string> dataSource = new Dictionary<string, string>
		{
			{ "cUid", "UID" },
			{
				"cPassword",
				Language.GetValue("Mật khẩu")
			},
			{
				"cName",
				Language.GetValue("Tên")
			},
			{
				"cBirthday",
				Language.GetValue("Ngày sinh")
			},
			{
				"cGender",
				Language.GetValue("Giới tính")
			},
			{ "cToken", "Token" },
			{ "cCookies", "Cookie" },
			{ "cEmail", "Email" },
			{ "cPassMail", "Pass email" },
			{ "cFa2", "2FA" },
			{
				"cGhiChu",
				Language.GetValue("Ghi chu\u0301")
			},
			{
				"cInteractEnd",
				Language.GetValue("Tương ta\u0301c cuô\u0301i")
			}
		};
		cbbSearch.DataSource = new BindingSource(dataSource, null);
		cbbSearch.ValueMember = "Key";
		cbbSearch.DisplayMember = "Value";
	}

	private void method_4(int ACB24337 = -1)
	{
		E7A6A48F = false;
		DataTable dataSource = CommonSQL.smethod_0(C60DC214: true);
		cbbThuMuc.DataSource = dataSource;
		cbbThuMuc.ValueMember = "id";
		cbbThuMuc.DisplayMember = "name";
		if (ACB24337 != -1 && cbbThuMuc.Items.Count >= ACB24337)
		{
			cbbThuMuc.SelectedIndex = ACB24337;
		}
		else if (cbbThuMuc.Items.Count == 2)
		{
			cbbThuMuc.SelectedIndex = -1;
		}
		E7A6A48F = true;
	}

	private void DE81740C(List<string> list_13 = null)
	{
		try
		{
			DataTable dataSource = CommonSQL.smethod_6(list_13);
			cbbTinhTrang.DataSource = dataSource;
			cbbTinhTrang.ValueMember = "id";
			cbbTinhTrang.DisplayMember = "name";
		}
		catch
		{
		}
	}

	private void A4335002(object sender, EventArgs e)
	{
		try
		{
			UpdateStatus.smethod_1();
			Environment.Exit(0);
			Application.Exit();
		}
		catch
		{
			Close();
		}
	}

	private void BE168597(object sender, EventArgs e)
	{
		this.smethod_2();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void FA986092(object sender, EventArgs e)
	{
		string text = "";
		if (cbbThuMuc.SelectedValue != null)
		{
			text = cbbThuMuc.SelectedValue.ToString();
		}
		method_4();
		if (text != "999999" && text != "-1")
		{
			int_0 = -1;
			cbbThuMuc.SelectedValue = text;
			return;
		}
		E7A6A48F = false;
		cbbThuMuc.SelectedValue = text;
		E7A6A48F = true;
		DE81740C(fChonThuMuc.list_0);
	}

	private List<string> method_5()
	{
		List<string> result = null;
		try
		{
			string text = cbbThuMuc.SelectedValue.ToString();
			string text2 = text;
			if (!(text2 == "-1"))
			{
				result = ((text2 == "999999") ? GClass22.smethod_2(fChonThuMuc.list_0) : new List<string> { cbbThuMuc.SelectedValue.ToString() });
			}
		}
		catch
		{
		}
		return result;
	}

	private void FE1C1880(List<string> list_13 = null, string string_0 = "")
	{
		try
		{
			dtgvAcc.Rows.Clear();
			if (string_0 == "[Tất cả tình trạng]" || string_0 == Language.GetValue("[Tất cả tình trạng]"))
			{
				string_0 = "";
			}
			try
			{
				DataTable dataTable_ = CommonSQL.smethod_11(list_13, string_0);
				D135A89E(dataTable_);
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	private void D135A89E(DataTable dataTable_0)
	{
		DatagridviewHelper.AB825897(dtgvAcc, dataTable_0);
		BA332092(0);
		method_119();
		method_89();
	}

	private void method_6(JArray jarray_0)
	{
		DatagridviewHelper.E7818906(dtgvAcc, jarray_0);
		BA332092(0);
		method_119();
		method_89();
	}

	private void CE3E348C(object sender, EventArgs e)
	{
		try
		{
			string text = "";
			if (cbbThuMuc.SelectedValue != null)
			{
				text = cbbThuMuc.SelectedValue.ToString();
			}
			fImportAccount fImportAccount2 = new fImportAccount(text);
			Common.smethod_16(fImportAccount2);
			if (fImportAccount2.bool_0 || fImportAccount2.bool_1)
			{
				method_4();
				int_0 = -1;
				if (fImportAccount2.bool_0)
				{
					cbbThuMuc.SelectedValue = fImportAccount2.int_0;
				}
				else
				{
					cbbThuMuc.SelectedValue = text;
				}
			}
		}
		catch
		{
		}
	}

	private int E09E011B(string string_0)
	{
		int result = -1;
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			if (dtgvAcc.Rows[i].Cells["cId"].Value.ToString().Equals(string_0))
			{
				result = i;
				break;
			}
		}
		return result;
	}

	private void method_7(string string_0)
	{
		switch (string_0)
		{
		case "ToggleCheck":
		{
			for (int k = 0; k < dtgvAcc.SelectedRows.Count; k++)
			{
				int index = dtgvAcc.SelectedRows[k].Index;
				SetCellAccount(index, "cChose", !Convert.ToBoolean(method_117(index, "cChose")));
			}
			BA332092();
			break;
		}
		case "SelectHighline":
		{
			DataGridViewSelectedRowCollection selectedRows = dtgvAcc.SelectedRows;
			for (int j = 0; j < selectedRows.Count; j++)
			{
				SetCellAccount(selectedRows[j].Index, "cChose", true);
			}
			BA332092();
			break;
		}
		case "UnAll":
		{
			for (int l = 0; l < dtgvAcc.RowCount; l++)
			{
				SetCellAccount(l, "cChose", false);
			}
			BA332092(0);
			break;
		}
		case "All":
		{
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				SetCellAccount(i, "cChose", true);
			}
			BA332092(dtgvAcc.RowCount);
			break;
		}
		}
	}

	private bool method_8()
	{
		if (method_109() == 0)
		{
			MessageBoxHelper.Show("Vui lòng chọn tài khoản muốn sử dụng chức năng này!", 3);
			return false;
		}
		return true;
	}

	private void method_9(string string_0)
	{
		if (method_8())
		{
			try
			{
				List<string> values = F7352394(string_0);
				Common.SetTextToClipboard(string.Join("\r\n", values));
			}
			catch
			{
			}
		}
	}

	private List<string> F7352394(string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			List<string> list2 = string_0.Split('|').ToList();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				List<string> list3 = new List<string>();
				for (int j = 0; j < list2.Count; j++)
				{
					string text = method_117(i, list2[j]);
					if (list2[j] == "cProxy" && text.Length > 2)
					{
						if (text[text.Length - 2].ToString() == "*")
						{
							text = text.Substring(0, text.Length - 2);
						}
					}
					else if (list2[j] == "cMa2Fa")
					{
						text = Common.GetTotp(method_117(i, "cFa2"));
					}
					list3.Add(text);
				}
				list.Add(string.Join("|", list3));
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	private void C986F503(object sender, EventArgs e)
	{
		method_7("All");
	}

	private void liveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_7("SelectHighline");
	}

	private void F228DD8C(object sender, EventArgs e)
	{
		method_7("UnAll");
	}

	private void DCA3B6A4(object sender, EventArgs e)
	{
		method_9("cToken");
	}

	private void CF05A638(object sender, EventArgs e)
	{
		method_9("cCookies");
	}

	private void E6381903(object sender, EventArgs e)
	{
		method_9("cUid");
	}

	private void EDA7981A(object sender, EventArgs e)
	{
		method_9("cPassword");
	}

	private void uidPassToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_9("cUid|cPassword");
	}

	private void AD1A1C09_Click(object sender, EventArgs e)
	{
		method_9("cUid|cPassword|cToken|cCookies");
	}

	private void F191E30F(object sender, EventArgs e)
	{
		Common.smethod_16(new fAddFile());
		if (fAddFile.bool_0)
		{
			method_4();
			cbbThuMuc.SelectedIndex = cbbThuMuc.Items.Count - 2;
		}
	}

	private void method_10()
	{
		for (int i = 0; i < dtgvAcc.SelectedRows.Count; i++)
		{
			dtgvAcc.Rows.RemoveAt(dtgvAcc.SelectedRows[i].Index);
		}
	}

	private void fMain_Load(object sender, EventArgs e)
	{
	}

	private void ctmsAcc_Opening(object sender, CancelEventArgs e)
	{
		toolStripMenuItem_2.DropDownItems.Clear();
		DataTable dataTable = CommonSQL.smethod_0();
		int num = 0;
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			DataRow dataRow = dataTable.Rows[i];
			if (dataRow["id"].ToString() != ((cbbThuMuc.SelectedValue == null) ? "" : cbbThuMuc.SelectedValue.ToString()))
			{
				toolStripMenuItem_2.DropDownItems.Add(dataRow["name"].ToString());
				toolStripMenuItem_2.DropDownItems[i - num].Tag = dataRow["id"];
				toolStripMenuItem_2.DropDownItems[i - num].Click += method_14;
			}
			else
			{
				num++;
			}
		}
		A12C7CB7.DropDownItems.Clear();
		List<string> list = new List<string>();
		string text = "";
		string text2 = "";
		for (int j = 0; j < dtgvAcc.RowCount; j++)
		{
			text = method_117(j, "cStatus");
			if (text != "")
			{
				text2 = Regex.Match(text, "\\(Proxy: (.*?)\\)", RegexOptions.Singleline).Value;
				if (text2 != "")
				{
					text = text.Replace(text2, "").Trim();
				}
				text2 = Regex.Match(text, "\\(IP: (.*?)\\)", RegexOptions.Singleline).Value;
				if (text2 != "")
				{
					text = text.Replace(text2, "").Trim();
				}
				text2 = Regex.Match(text, "\\[(.*?)\\]").Value;
				if (text2 != "")
				{
					text = text.Replace(text2, "").Trim();
				}
				if (text != "" && !list.Contains(text))
				{
					list.Add(text);
				}
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			A12C7CB7.DropDownItems.Add(list[k]);
			A12C7CB7.DropDownItems[k].Click += method_12;
		}
		tinhTrangToolStripMenuItem.DropDownItems.Clear();
		list = new List<string>();
		string text3 = "";
		for (int l = 0; l < dtgvAcc.RowCount; l++)
		{
			text3 = method_117(l, "cInfo");
			if (!text3.Equals("") && !list.Contains(text3))
			{
				list.Add(text3);
			}
		}
		for (int m = 0; m < list.Count; m++)
		{
			tinhTrangToolStripMenuItem.DropDownItems.Add(list[m]);
			tinhTrangToolStripMenuItem.DropDownItems[m].Click += method_11;
		}
	}

	private void method_11(object sender, EventArgs e)
	{
		method_13("cInfo", (sender as ToolStripMenuItem).Text);
	}

	private void method_12(object sender, EventArgs e)
	{
		method_13("cStatus", (sender as ToolStripMenuItem).Text);
	}

	private void method_13(string string_0, string string_1)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			dtgvAcc.Rows[i].Cells["cChose"].Value = method_117(i, string_0).Contains(string_1);
		}
		BA332092();
	}

	private void method_14(object sender, EventArgs e)
	{
		if (Convert.ToInt32(lblCountSelect.Text) == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn tài khoản muốn chuyển!"), 3);
			return;
		}
		ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
		if (MessageBoxHelper.smethod_1(string.Format(Language.GetValue("Bạn có thực sự muốn chuyển {0} tài khoản sang thư mục [{1}]?"), lblCountSelect.Text, toolStripMenuItem.Text)) == DialogResult.Yes)
		{
			FBB6D391(toolStripMenuItem.Tag.ToString());
		}
	}

	private void FBB6D391(string string_0)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list.Add(dtgvAcc.Rows[i].Cells["cId"].Value.ToString());
				}
			}
			if (CommonSQL.FE347784(list, "idfile", string_0))
			{
				for (int j = 0; j < dtgvAcc.RowCount; j++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
					{
						dtgvAcc.Rows.RemoveAt(j--);
					}
				}
				method_119();
				method_95();
				BA332092(0);
				method_89();
				MessageBoxHelper.Show(string.Format(Language.GetValue("Chuyển thành công {0} tài khoản!"), list.Count));
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Chuyển thất bại, vui lòng thử lại sau!"), 2);
			}
		}
		catch
		{
		}
	}

	private void C93E4834(bool E43C18A6)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				list.Add(dtgvAcc.Rows[i].Cells["cId"].Value.ToString());
			}
		}
		if (list.Count == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn tài khoản cần xóa!"));
		}
		else
		{
			if (MessageBoxHelper.smethod_1(string.Format(Language.GetValue("Bạn có muốn xóa {0} tài khoản đã chọn?"), method_109()) + "\r\n" + Language.GetValue("(Ta\u0300i khoa\u0309n sau khi xo\u0301a se\u0303 đươ\u0323c lưu ta\u0323i mu\u0323c [Ta\u0300i khoa\u0309n đa\u0303 xo\u0301a])")) != DialogResult.Yes)
			{
				return;
			}
			if (E43C18A6)
			{
				int int_ = 0;
				int num = 0;
				while (num < dtgvAcc.Rows.Count)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (int_ < 10)
						{
							Interlocked.Increment(ref int_);
							int int_0 = num++;
							Thread thread = new Thread((ThreadStart)delegate
							{
								SetStatusAccount(int_0, Language.GetValue("Đang xo\u0301a profile..."));
								D7227036(int_0);
								Interlocked.Decrement(ref int_);
							});
							thread.IsBackground = true;
							thread.Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
				while (int_ > 0)
				{
					Common.DelayTime(1.0);
				}
			}
			if (CommonSQL.smethod_16(list))
			{
				CommonSQL.smethod_10(list, "device", "");
				bool flag = SettingsTool.GetSettings("configGeneral").AA824D29("isRunSwap");
				string text = E3A31B0C.smethod_1();
				for (int j = 0; j < dtgvAcc.RowCount; j++)
				{
					if (!Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
					{
						continue;
					}
					if (!flag)
					{
						string text2 = method_117(j, "cDevice");
						if (text2 != "" && Directory.Exists(text + "\\vms\\leidian" + text2))
						{
							try
							{
								Directory.Delete(text + "\\vms\\leidian" + text2, recursive: true);
							}
							catch
							{
							}
						}
					}
					dtgvAcc.Rows.RemoveAt(j--);
				}
				method_95();
				method_89();
				BA332092(0);
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Xóa thất bại, vui lòng thử lại sau!"), 2);
			}
		}
	}

	public List<string> method_15()
	{
		List<string> list = new List<string>();
		try
		{
			if (SettingsTool.GetSettings("configGeneral").method_0("typeApiTinsoft") == 0)
			{
				RequestXNet b01F5C = new RequestXNet("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0);
				string json = b01F5C.RequestGet("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + SettingsTool.GetSettings("configGeneral").GetValue("txtApiUser"));
				JObject jObject = JObject.Parse(json);
				foreach (JToken item in (IEnumerable<JToken>)(jObject["data"]!))
				{
					if (Convert.ToBoolean(item["success"]!.ToString()))
					{
						list.Add(item["key"]!.ToString());
					}
				}
			}
			else
			{
				List<string> list2 = SettingsTool.GetSettings("configGeneral").EC378D8A("txtApiProxy");
				foreach (string item2 in list2)
				{
					if (A4AF3582.smethod_0(item2))
					{
						list.Add(item2);
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	private bool method_16(string string_0)
	{
		return Common.E001543D(string_0);
	}

	private Dictionary<string, List<string>> method_17(string ED1BE319, string string_0, string string_1 = "txtUid", int C00C879A = -1)
	{
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
		try
		{
			List<string> list = Class123.A0AD6B0A(ED1BE319, string_0);
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					string text = list[i];
					JSON_Settings f72FAFBC = new JSON_Settings(Class123.smethod_16(text), D7BE7F11: true);
					List<string> list2 = new List<string>();
					list2 = ((C00C879A == -1) ? ((!(string_1 == "txtUid") && !(string_1 == "txtIdNhomChiDinh")) ? f72FAFBC.EC378D8A(string_1, f72FAFBC.method_0("typeNganCach")) : f72FAFBC.EC378D8A(string_1)) : f72FAFBC.EC378D8A(string_1, C00C879A));
					dictionary.Add(text, list2);
				}
			}
		}
		catch
		{
		}
		return dictionary;
	}

	private void AF9FF735(Dictionary<string, List<string>> dictionary_13, string string_0 = "txtUid")
	{
		if (dictionary_13.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<string, List<string>> item in dictionary_13)
		{
			string key = item.Key;
			List<string> value = item.Value;
			JSON_Settings f72FAFBC = new JSON_Settings(Class123.smethod_16(key), D7BE7F11: true);
			if (string_0 == "txtUid" || string_0 == "txtIdNhomChiDinh")
			{
				f72FAFBC.method_3(string_0, value);
			}
			else
			{
				f72FAFBC.A53F37B4(string_0, value, f72FAFBC.method_0("typeNganCach"));
			}
			Class123.smethod_14(key, "", f72FAFBC.C71A4EA4());
		}
	}

	private void FF9B9E91()
	{
		Common.D58FD026("fViewLD");
	}

	private void btnInteract_Click(object sender, EventArgs e)
	{
		method_18(0, e != null && (e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control);
	}

	private void method_18(int int_1 = 0, bool bool_4 = false, JSON_Settings f72FAFBC_0 = null)
	{
		try
		{
			bool_0 = false;
			if (method_109() == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn tài khoản muốn chạy!"), 3);
				return;
			}
			JSON_Settings EFAD = new JSON_Settings();
			Common.smethod_16(new fDeviceList(ref EFAD));
			List<string> list = EFAD.EC378D8A("lstDeviceId");
			if (list.Count == 0)
			{
				return;
			}
			int int_2 = list.Count;
			int_2 = ((method_109() < int_2) ? method_109() : int_2);
			Base.FA2640AB = new GClass14(list.GetRange(0, int_2));
			switch (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp"))
			{
			case 7:
			{
				list_4 = method_15();
				if (list_4.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Proxy Tinsoft không đủ, vui lòng mua thêm!"), 2);
					return;
				}
				list_3 = new List<A4AF3582>();
				for (int m = 0; m < list_4.Count; m++)
				{
					A4AF3582 item4 = new A4AF3582(list_4[m], SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPTinsoft"), SettingsTool.GetSettings("configGeneral").method_0("cbbLocationTinsoft"));
					list_3.Add(item4);
				}
				if (list_4.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPTinsoft") < int_2)
				{
					int_2 = list_4.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPTinsoft");
				}
				break;
			}
			case 8:
			{
				list_5 = SettingsTool.GetSettings("configGeneral").EC378D8A("txtListProxy");
				if (list_5.Count < Base.FA2640AB.D90E8EA6())
				{
					MessageBoxHelper.Show(Language.GetValue("Số lượng XProxy < Số lượng phone, vui lòng cấu hình lại!"), 2);
					return;
				}
				for (int n = 0; n < Base.FA2640AB.D90E8EA6(); n++)
				{
					Base.FA2640AB.list_0[n].EE33D530(SettingsTool.GetSettings("configGeneral").GetValue("txtServiceURLXProxy"), list_5[n]);
				}
				break;
			}
			case 10:
			{
				B8BDDBB3 = SettingsTool.GetSettings("configGeneral").EC378D8A("txtApiKeyTMProxy");
				if (B8BDDBB3.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Proxy không đủ, vui lòng mua thêm!"), 2);
					return;
				}
				list_6 = new List<Class27>();
				for (int k = 0; k < B8BDDBB3.Count; k++)
				{
					Class27 item2 = new Class27(B8BDDBB3[k], 0, SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPTMProxy"));
					list_6.Add(item2);
				}
				if (B8BDDBB3.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPTMProxy") < int_2)
				{
					int_2 = B8BDDBB3.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPTMProxy");
				}
				break;
			}
			case 11:
			{
				list_8 = SettingsTool.GetSettings("configGeneral").EC378D8A("txtListProxyv6");
				if (list_8.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Proxy không đủ, vui lòng cấu hình lại!"), 2);
					return;
				}
				list_7 = new List<Class6>();
				for (int l = 0; l < list_8.Count; l++)
				{
					Class6 item3 = new Class6(SettingsTool.GetSettings("configGeneral").GetValue("txtApiProxyv6"), list_8[l], 0, SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPProxyv6"));
					list_7.Add(item3);
				}
				if (list_8.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPProxyv6") < int_2)
				{
					int_2 = list_8.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPProxyv6");
				}
				break;
			}
			case 12:
			{
				list_9 = SettingsTool.GetSettings("configGeneral").EC378D8A("txtApiShopLike");
				if (list_9.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Proxy không đủ, vui lòng mua thêm!"), 2);
					return;
				}
				A2817D31 = new List<Class7>();
				for (int j = 0; j < list_9.Count; j++)
				{
					Class7 item = new Class7(list_9[j], 0, SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPShopLike"));
					A2817D31.Add(item);
				}
				if (list_9.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPShopLike") < int_2)
				{
					int_2 = list_9.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPShopLike");
				}
				break;
			}
			case 13:
			{
				A625580B = SettingsTool.GetSettings("configGeneral").EC378D8A("txtApiKeyMinProxy");
				if (A625580B.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("MinProxy không đủ, vui lòng mua thêm!"), 2);
					return;
				}
				list_10 = new List<Class4>();
				for (int num = 0; num < A625580B.Count; num++)
				{
					Class4 item5 = new Class4(SettingsTool.GetSettings("configGeneral").method_0("typeMin"), A625580B[num], SettingsTool.GetSettings("configGeneral").method_0("typeProxyMin"), SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPMinProxy"));
					list_10.Add(item5);
				}
				if (A625580B.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPMinProxy") < int_2)
				{
					int_2 = A625580B.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPMinProxy");
				}
				break;
			}
			case 14:
			{
				list_12 = SettingsTool.GetSettings("configGeneral").EC378D8A("txtListObcProxy");
				if (list_12.Count == 0)
				{
					MessageBoxHelper.Show(Language.GetValue("Proxy không đủ, vui lòng cấu hình lại!"), 2);
					return;
				}
				F284EF3B = new List<GClass4>();
				list_11 = new List<GClass3>();
				Dictionary<string, List<string>> source = GClass3.B0B8FE21(SettingsTool.GetSettings("configGeneral").GetValue("txtLinkWebObcProxy"));
				for (int i = 0; i < list_12.Count; i++)
				{
					string string_0 = list_12[i].Split(':')[1];
					string key = source.FirstOrDefault((KeyValuePair<string, List<string>> keyValuePair_0) => keyValuePair_0.Value.Contains(string_0)).Key;
					if (!string.IsNullOrEmpty(key))
					{
						GClass3 gClass = GClass3.smethod_0(list_11, key);
						if (gClass == null)
						{
							gClass = new GClass3(key);
							list_11.Add(gClass);
						}
						GClass4 gClass2 = new GClass4(SettingsTool.GetSettings("configGeneral").GetValue("txtLinkWebObcProxy"), list_12[i], 0, SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPObcProxy"), key);
						F284EF3B.Add(gClass2);
						gClass.method_0(gClass2);
					}
				}
				if (F284EF3B.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPObcProxy") < int_2)
				{
					int_2 = F284EF3B.Count * SettingsTool.GetSettings("configGeneral").method_0("nudLuongPerIPObcProxy");
				}
				break;
			}
			}
			list_0 = new List<Thread>();
			list_1 = new List<string>();
			if (int_1 == 1)
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						foreach (AC28BD29 ac28BD29_5 in Base.FA2640AB.list_0)
						{
							Thread thread9 = new Thread((ThreadStart)delegate
							{
								ac28BD29_5.method_47();
								ac28BD29_5.F2BCA293();
							});
							thread9.IsBackground = true;
							thread9.Start();
						}
						int num15 = 0;
						while (num15 < dtgvAcc.Rows.Count && !bool_0 && int_2 != 0)
						{
							if (Convert.ToBoolean(dtgvAcc.Rows[num15].Cells["cChose"].Value))
							{
								int_2--;
								if (bool_0)
								{
									break;
								}
								AC28BD29 ac28BD29_4 = null;
								lock (Base.FA2640AB)
								{
									ac28BD29_4 = Base.FA2640AB.method_0();
								}
								if (ac28BD29_4 != null)
								{
									int int_6 = num15++;
									Thread thread10 = new Thread((ThreadStart)delegate
									{
										try
										{
											SetStatusAccount(int_6, "Connect phone...");
											int tickCount5 = Environment.TickCount;
											int num17 = 1;
											while (true)
											{
												SetStatusAccount(int_6, "Connect phone" + ((num17 != 1) ? $" ({num17})" : "") + "...");
												if (ac28BD29_4.method_2() != "")
												{
													SetStatusAccount(int_6, $"Connect phone ({num17}) success!");
													//ac28BD29_4.SetLanguage2();
													SetCellAccount(int_6, "cDeviceId", SettingsTool.GetSettings("device").GetValue(ac28BD29_4.String_1));
													method_23(int_6, ac28BD29_4, "", int_1);
													if (!SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRepeatAll"))
													{
														SetCellAccount(int_6, "cChose", false);
													}
													Base.FA2640AB.method_1(ac28BD29_4, bool_0: false);
													return;
												}
												num17++;
												if (Environment.TickCount - tickCount5 >= 300000)
												{
													break;
												}
												Common.DelayTime(1.0);
											}
											SetStatusAccount(int_6, "Connect phone fail!");
										}
										catch (Exception ex7)
										{
											if (ex7.ToString().Contains("Thread was being aborted."))
											{
												if (!SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRepeatAll"))
												{
													SetCellAccount(int_6, "cChose", false);
												}
												Base.FA2640AB.method_1(ac28BD29_4, bool_0: false);
											}
										}
									})
									{
										Name = int_6.ToString()
									};
									lock (list_0)
									{
										list_0.Add(thread10);
									}
									thread10.IsBackground = true;
									thread10.Start();
								}
							}
							else
							{
								num15++;
							}
						}
						for (int num16 = 0; num16 < list_0.Count; num16++)
						{
							list_0[num16].Join();
						}
					}
					catch (ThreadAbortException ex6)
					{
						if (ex6.ToString().Contains("Thread was being aborted."))
						{
						}
					}
					method_88("stop");
					bool_3 = false;
				});
				thread.IsBackground = true;
				thread.Start();
				return;
			}
			if (int_1 == 2)
			{
				Thread thread2 = new Thread((ThreadStart)delegate
				{
					try
					{
						foreach (AC28BD29 ED1F9028 in Base.FA2640AB.list_0)
						{
							Thread thread7 = new Thread((ThreadStart)delegate
							{
								ED1F9028.method_47();
								ED1F9028.F2BCA293();
							});
							thread7.IsBackground = true;
							thread7.Start();
						}
						int num12 = 0;
						while (num12 < dtgvAcc.Rows.Count && !bool_0)
						{
							if (Convert.ToBoolean(dtgvAcc.Rows[num12].Cells["cChose"].Value))
							{
								if (bool_0)
								{
									break;
								}
								AC28BD29 ac28BD29_3 = null;
								lock (Base.FA2640AB)
								{
									ac28BD29_3 = Base.FA2640AB.method_0();
								}
								if (ac28BD29_3 != null)
								{
									int F9288E80 = num12++;
									Thread thread8 = new Thread((ThreadStart)delegate
									{
										try
										{
											SetStatusAccount(F9288E80, "Connect phone...");
											int tickCount4 = Environment.TickCount;
											int num14 = 1;
											while (true)
											{
												SetStatusAccount(F9288E80, "Connect phone" + ((num14 != 1) ? $" ({num14})" : "") + "...");
												if (ac28BD29_3.method_2() != "")
												{
													SetStatusAccount(F9288E80, $"Connect phone ({num14}) success!");
													//ac28BD29_3.SetLanguage2();
													SetCellAccount(F9288E80, "cDeviceId", SettingsTool.GetSettings("device").GetValue(ac28BD29_3.String_1));
													string text3 = method_117(F9288E80, "cDevice").Trim();
													string text4 = text3.Replace(ac28BD29_3.String_1 + "_", "");
													List<string> list3 = ac28BD29_3.EA82A612();
													if (!list3.Contains(text4))
													{
														text4 = list3.Except(CommonSQL.B9B0A816(ac28BD29_3.String_1)).FirstOrDefault();
														if (!string.IsNullOrEmpty(text4))
														{
															method_114(F9288E80, "cDevice", ac28BD29_3.String_1 + "_" + text4, "device");
														}
													}
													if (string.IsNullOrEmpty(text4))
													{
														bool_0 = true;
														SetStatusAccount(F9288E80, Language.GetValue("Hết App Facebook trống!"));
													}
													else
													{
														ac28BD29_3.FacebookPacker = text4;
														method_23(F9288E80, ac28BD29_3, "", int_1);
														if (!SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRepeatAll"))
														{
															SetCellAccount(F9288E80, "cChose", false);
														}
														Base.FA2640AB.method_1(ac28BD29_3, bool_0: false);
													}
													return;
												}
												num14++;
												if (Environment.TickCount - tickCount4 >= 300000)
												{
													break;
												}
												Common.DelayTime(1.0);
											}
											SetStatusAccount(F9288E80, "Connect phone fail!");
										}
										catch (Exception ex5)
										{
											if (ex5.ToString().Contains("Thread was being aborted."))
											{
												if (!SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRepeatAll"))
												{
													SetCellAccount(F9288E80, "cChose", false);
												}
												Base.FA2640AB.method_1(ac28BD29_3, bool_0: false);
											}
										}
									})
									{
										Name = F9288E80.ToString()
									};
									lock (list_0)
									{
										list_0.Add(thread8);
									}
									thread8.IsBackground = true;
									thread8.Start();
								}
							}
							else
							{
								num12++;
							}
						}
						for (int num13 = 0; num13 < list_0.Count; num13++)
						{
							list_0[num13].Join();
						}
					}
					catch (ThreadAbortException ex4)
					{
						if (ex4.ToString().Contains("Thread was being aborted."))
						{
						}
					}
					method_88("stop");
					bool_3 = false;
				});
				thread2.IsBackground = true;
				thread2.Start();
				return;
			}
			int int_3;
			string F035D52B;
			Thread thread3 = new Thread((ThreadStart)delegate
			{
				try
				{
					JSON_Settings f72FAFBC = new JSON_Settings();
					if (!bool_4)
					{
						goto IL_003a;
					}
					Common.smethod_16(new fHenGioChayDung(f72FAFBC));
					if (!f72FAFBC.AA824D29("isCancel"))
					{
						goto IL_003a;
					}
					goto end_IL_0001;
					IL_003a:
					method_88("start");
					if (f72FAFBC.GetValue("timeStart") != "")
					{
						string text = f72FAFBC.GetValue("timeStart");
						string[] array = text.Trim().Split(':');
						DateTime cF97C1B = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(array[0]), Convert.ToInt32(array[1]), Convert.ToInt32(array[2]));
						if (cF97C1B.CompareTo(DateTime.Now) == -1)
						{
							cF97C1B = cF97C1B.AddDays(1.0);
						}
						int int_4 = Common.B590F31A(cF97C1B);
						try
						{
							int_3 = Environment.TickCount;
							while (Environment.TickCount - int_3 < int_4 * 1000 && !bool_0)
							{
								Invoke((MethodInvoker)delegate
								{
									lblStatus.Text = "Chạy sau {time}s".Replace("{time}", Common.smethod_10(int_4 - (Environment.TickCount - int_3) / 1000));
								});
								Common.DelayTime(0.5);
							}
							Invoke((MethodInvoker)delegate
							{
								lblStatus.Text = "Đã kích hoạt";
							});
						}
						catch (Exception)
						{
						}
					}
					if (!bool_0)
					{
						foreach (AC28BD29 ac28BD29_ in Base.FA2640AB.list_0)
						{
							Thread thread4 = new Thread((ThreadStart)delegate
							{
								ac28BD29_.method_47();
								ac28BD29_.F2BCA293();
							});
							thread4.IsBackground = true;
							thread4.Start();
						}
						bool_3 = true;
						List<string> list2 = new List<string>();
						F035D52B = "";
						string text2 = "";
						int num2 = SettingsTool.GetSettings("configInteractGeneral").method_0("nudSoLuotChay", 1);
						if (num2 == 0)
						{
							num2 = 1;
						}
						for (int num3 = 0; num3 < num2; num3++)
						{
							list2 = new List<string>();
							if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRepeatAll"))
							{
								text2 = ((num2 > 1) ? string.Format(Language.GetValue("Lượt {0}/{1}. "), num3 + 1, num2) : "");
								if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("RepeatAllVIP"))
								{
									list2 = SettingsTool.GetSettings("configInteractGeneral").EC378D8A("lstIdKichBan");
									if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRandomKichBan"))
									{
										list2 = Common.F78FD80F(list2);
										list2 = Common.F78FD80F(list2);
										list2 = Common.F78FD80F(list2);
									}
								}
								else
								{
									list2.Add(SettingsTool.GetSettings("configInteractGeneral").GetValue("cbbKichBan"));
								}
							}
							else
							{
								list2.Add(SettingsTool.GetSettings("configInteractGeneral").GetValue("cbbKichBan"));
							}
							for (int num4 = 0; num4 < list2.Count; num4++)
							{
								if (bool_0)
								{
									break;
								}
								F035D52B = list2[num4];
								if (text2 != "")
								{
									AE0E9628(text2 + string.Format(Language.GetValue("Kịch bản") + ": {0}...", Class123.smethod_2(F035D52B)));
								}
								if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRandomThuTuTaiKhoan"))
								{
									dtgvAcc.Invoke((MethodInvoker)delegate
									{
										A28F9110();
									});
								}
								dictionary_0 = method_17(F035D52B, "HDThamGiaNhomUid");
								dictionary_1 = method_17(F035D52B, "HDKetBanTepUid");
								dictionary_9 = method_17(F035D52B, "HDSpamBaiViet");
								dictionary_2 = method_17(F035D52B, "HDDangReel", "txtNoiDung");
								dictionary_3 = method_17(F035D52B, "HDDangBaiTuong", "txtNoiDung");
								dictionary_4 = method_17(F035D52B, "HDDangBaiNhom", "txtNoiDung");
								B68B3D0D = method_17(F035D52B, "HDDangBaiNhom", "txtIdNhomChiDinh");
								dictionary_5 = method_17(F035D52B, "HDDangBaiPage", "txtNoiDung");
								C292E829 = method_17(F035D52B, "HDDangBaiPage", "txtIdNhomChiDinh");
								dictionary_6 = method_17(F035D52B, "HDAddMail", "lstHotmail");
								dictionary_7 = method_17(F035D52B, "HDVerifyAccount", "lstHotmail");
								C8289C88 = method_17(F035D52B, "HDTuongTacPage");
								F605BBA9 = method_17(F035D52B, "HDDongBoDanhBa", "txtSdt");
								CAB1A00C = method_17(F035D52B, "HDDanhGiaPage", "txtComment");
								dictionary_8 = method_17(F035D52B, "HDTuongTacBaiVietChiDinh", "txtComment");
								C50FA08A = method_17(F035D52B, "HDTuongTacVideo", "txtComment");
								C42A3EA1 = method_17(F035D52B, "HDShareBaiNangCao", "txtNoiDung");
								dictionary_10 = new Dictionary<string, List<string>>();
								E2AC9E1F = new Dictionary<string, List<string>>();
								dictionary_11 = method_17(F035D52B, "HDDangStory", "txtDanhSachBaiHat");
								dictionary_12 = method_17(F035D52B, "HDDangStory", "txtDanhSachBaiHat");
								D80EF33F = new Dictionary<string, Dictionary<string, int>>();
								if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 14)
								{
									for (int num5 = 0; num5 < list_11.Count; num5++)
									{
										list_11[num5].method_3();
									}
								}
								FDA57818 = new Thread((ThreadStart)delegate
								{
									try
									{
										int num9 = 0;
										while (num9 < dtgvAcc.Rows.Count && !bool_0)
										{
											if (Convert.ToBoolean(dtgvAcc.Rows[num9].Cells["cChose"].Value))
											{
												if (bool_0)
												{
													break;
												}
												AC28BD29 ac28BD29_2 = null;
												lock (Base.FA2640AB)
												{
													ac28BD29_2 = Base.FA2640AB.method_0();
												}
												if (ac28BD29_2 != null)
												{
													int int_5 = num9++;
													Thread thread6 = new Thread((ThreadStart)delegate
													{
														try
														{
															SetStatusAccount(int_5, "Connect phone...");
															int tickCount3 = Environment.TickCount;
															int num11 = 1;
															while (true)
															{
																SetStatusAccount(int_5, "Connect phone" + ((num11 != 1) ? $" ({num11})" : "") + "...");
																if (ac28BD29_2.method_2() != "")
																{
																	switch (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp"))
																	{
																	case 8:
																		ac28BD29_2.AABD1000();
																		break;
																	}
																	SetStatusAccount(int_5, $"Connect phone ({num11}) success!");
																	//ac28BD29_2.SetLanguage2();
																	SetCellAccount(int_5, "cDeviceId", SettingsTool.GetSettings("device").GetValue(ac28BD29_2.String_1));
																	method_23(int_5, ac28BD29_2, F035D52B, int_1, f72FAFBC_0);
																	if (!SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRepeatAll") || F08831A5(int_5) != "Live" || method_116(int_5).ToLower().Contains("checkpoint") || method_116(int_5).ToLower().Contains("invalid username or password"))
																	{
																		SetCellAccount(int_5, "cChose", false);
																	}
																	Base.FA2640AB.method_1(ac28BD29_2, bool_0: false);
																	return;
																}
																num11++;
																if (Environment.TickCount - tickCount3 >= 300000)
																{
																	break;
																}
																Common.DelayTime(1.0);
															}
															SetStatusAccount(int_5, "Connect phone fail!");
														}
														catch (Exception ex3)
														{
															if (ex3.ToString().Contains("Thread was being aborted."))
															{
																if (!SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRepeatAll"))
																{
																	SetCellAccount(int_5, "cChose", false);
																}
																Base.FA2640AB.method_1(ac28BD29_2, bool_0: false);
															}
														}
													})
													{
														Name = int_5.ToString()
													};
													list_1.Add(thread6.Name.ToString());
													lock (list_0)
													{
														list_0.Add(thread6);
													}
													thread6.IsBackground = true;
													thread6.Start();
												}
											}
											else
											{
												num9++;
											}
										}
										for (int num10 = 0; num10 < list_0.Count; num10++)
										{
											list_0[num10].Join();
										}
									}
									catch (ThreadAbortException ex2)
									{
										if (ex2.ToString().Contains("Thread was being aborted."))
										{
										}
									}
								});
								FDA57818.IsBackground = true;
								FDA57818.Start();
								if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbGioiHanThoiGianChayKichBan"))
								{
									int num6 = random_0.Next(SettingsTool.GetSettings("configInteractGeneral").method_0("nudThoiGianChayKichBanFrom"), SettingsTool.GetSettings("configInteractGeneral").method_0("nudThoiGianChayKichBanTo") + 1);
									if (!FDA57818.Join(num6 * 60000))
									{
										method_19();
									}
								}
								else
								{
									FDA57818.Join();
								}
								AF9FF735(dictionary_0);
								AF9FF735(dictionary_1);
								AF9FF735(dictionary_9);
								AF9FF735(dictionary_2, "txtNoiDung");
								AF9FF735(dictionary_3, "txtNoiDung");
								AF9FF735(dictionary_4, "txtNoiDung");
								AF9FF735(B68B3D0D, "txtIdNhomChiDinh");
								AF9FF735(dictionary_5, "txtNoiDung");
								AF9FF735(C292E829, "txtIdNhomChiDinh");
								AF9FF735(dictionary_6, "lstHotmail");
								AF9FF735(dictionary_7, "lstHotmail");
								AF9FF735(C8289C88);
								AF9FF735(F605BBA9, "txtSdt");
								AF9FF735(CAB1A00C, "txtComment");
								AF9FF735(dictionary_8, "txtComment");
								AF9FF735(C50FA08A, "txtComment");
								AF9FF735(C42A3EA1, "txtNoiDung");
								if (bool_0)
								{
									break;
								}
								if (num4 + 1 < list2.Count)
								{
									int num7 = Base.rd.Next(SettingsTool.GetSettings("configInteractGeneral").method_0("nudDelayKichBanFrom"), SettingsTool.GetSettings("configInteractGeneral").method_0("nudDelayKichBanTo") + 1);
									int tickCount = Environment.TickCount;
									while ((Environment.TickCount - tickCount) / 1000 - num7 < 0)
									{
										AE0E9628(text2 + string.Format(Language.GetValue("Chạy kịch bản tiếp theo sau {time} giây...").Replace("{time}", (num7 - (Environment.TickCount - tickCount) / 1000).ToString())));
										Common.DelayTime(0.5);
										if (bool_0)
										{
											break;
										}
									}
								}
							}
							if (!SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRepeatAll") || bool_0)
							{
								break;
							}
							if (num3 + 1 < num2)
							{
								int num8 = Base.rd.Next(SettingsTool.GetSettings("configInteractGeneral").method_0("nudDelayTurnFrom"), SettingsTool.GetSettings("configInteractGeneral").method_0("nudDelayTurnTo") + 1) * 60;
								int tickCount2 = Environment.TickCount;
								while ((Environment.TickCount - tickCount2) / 1000 - num8 < 0)
								{
									AE0E9628(text2 + string.Format(Language.GetValue("Chạy lượt tiếp theo sau {time} giây...").Replace("{time}", (num8 - (Environment.TickCount - tickCount2) / 1000).ToString())));
									Common.DelayTime(0.5);
									if (bool_0)
									{
										break;
									}
								}
							}
							if (bool_0)
							{
								break;
							}
						}
					}
					end_IL_0001:;
				}
				catch (Exception exception_2)
				{
					Common.ExportError(null, exception_2);
				}
				method_69();
				if (!SettingsTool.GetSettings("configGeneral").AA824D29("ckbKhongAddVaoFormView"))
				{
					FF9B9E91();
				}
				method_88("stop");
				foreach (AC28BD29 ac28BD29_0 in Base.FA2640AB.list_0)
				{
					Thread thread5 = new Thread((ThreadStart)delegate
					{
						ac28BD29_0.E0A70A3E();
					});
					thread5.IsBackground = true;
					thread5.Start();
				}
				if (SettingsTool.GetSettings("configGeneral").AA824D29("ckbTatADBKhiDungTool", A72188BC: true))
				{
					F4B11823.EE87B2B7();
					GClass1.smethod_2();
					Class64.CloseServerAppium();
				}
				bool_3 = false;
			});
			thread3.IsBackground = true;
			thread3.Start();
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_);
			method_88("stop");
			bool_3 = false;
		}
	}

	private void method_19()
	{
		FDA57818.Abort();
		for (int i = 0; i < list_0.Count; i++)
		{
			list_0[i].Abort();
			while (list_0[i].IsAlive)
			{
				Thread.Sleep(1000);
			}
		}
		while (FDA57818.IsAlive)
		{
			Thread.Sleep(1000);
		}
	}

	private bool method_20(Chrome E2AEEB94)
	{
		bool result = true;
		try
		{
			GClass12.smethod_5(E2AEEB94);
			string text = E2AEEB94.method_3("a", "href", "/privacy/touch/tags/review/");
			if (text != "" && E2AEEB94.method_14(4, text) == 1)
			{
				E2AEEB94.method_21();
				if (!Convert.ToBoolean(E2AEEB94.F4AF93AB("return document.querySelector('input[type=\"checkbox\"]').checked+''").ToString()))
				{
					E2AEEB94.method_14(4, "form div[role=\"button\"]");
				}
				return true;
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	private List<string> CE318DA3(List<string> C833F698)
	{
		List<string> list = new List<string>();
		C833F698 = C833F698.Distinct().ToList();
		for (int i = 0; i < C833F698.Count; i++)
		{
			if (C833F698[i] != "[0,0][0,0]")
			{
				list.Add(C833F698[i]);
			}
		}
		return list;
	}

	private int method_21(AC28BD29 BB25432B, int int_1, string string_0, int int_2)
	{
		string text = method_117(int_1, "cId");
		int num = -1;
		string text2 = method_117(int_1, "cUid");
		string text3 = method_117(int_1, "cEmail");
		string d99379A = method_117(int_1, "cPassword");
		string string_ = method_117(int_1, "cFa2");
		string text4 = "";
		if (text2 != "")
		{
			string text5 = FileHelper.GetPathToCurrentFolder() + "\\device\\" + text2 + ".tar.gz";
			if (!File.Exists(text5))
			{
				string text6 = FileHelper.GetPathToCurrentFolder() + "\\device\\" + text + ".tar.gz";
				string text7 = FileHelper.GetPathToCurrentFolder() + "\\device\\" + text3 + ".tar.gz";
				if (File.Exists(text6))
				{
					Common.smethod_50(text6, text5);
				}
				else if (text3 != "" && File.Exists(text7))
				{
					Common.smethod_50(text7, text5);
				}
			}
		}
		if (SettingsTool.GetSettings("configInteractGeneral").method_0("typeLogin") == 0)
		{
			SetStatusAccount(int_1, string_0 + Language.GetValue("Login Uid|Pass..."));
			text4 = text2;
		}
		else
		{
			SetStatusAccount(int_1, string_0 + Language.GetValue("Login Email|Pass..."));
			text4 = text3;
		}
		num = BB25432B.AB03C014(text2, text4, d99379A, string_, SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp"), int_2);
		switch (num)
		{
		case -2:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Không thể kết nối thiết bị!"));
			break;
		case 0:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Đăng nhập thất bại!"), 0, BB25432B);
			break;
		case 1:
			CC1905A5(int_1, "Live");
			break;
		case 2:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Checkpoint!"));
			CC1905A5(int_1, "Checkpoint", BB25432B);
			break;
		case 3:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Không có 2fa!"));
			break;
		case 4:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Tài khoản không đúng!"));
			break;
		case 5:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Mật khẩu không đúng!"));
			CC1905A5(int_1, "Changed pass", BB25432B);
			break;
		case 6:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Mã 2FA không đúng!"));
			break;
		case 7:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Lỗi kết nối Internet!"));
			break;
		case 8:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Tài khoản chưa xác minh!"));
			break;
		case 9:
			BB25432B.method_59(BB25432B.FacebookPacker);
			if (num != 1)
			{
				SetStatusAccount(int_1, string_0 + Language.GetValue("Facebook bắt add sđt!"));
			}
			break;
		case 10:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Không thê\u0309 login!"));
			break;
		case 11:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Login fail: You’re Temporarily Blocked"), 0, BB25432B);
			break;
		case 12:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Login fail: You can't log in right now"), 0, BB25432B);
			break;
		case 13:
			SetStatusAccount(int_1, string_0 + "Facebook Spam", 0, BB25432B);
			break;
		}
		return num;
	}

	private int method_22(AC28BD29 ac28BD29_0, int int_1, string string_0)
	{
		method_117(int_1, "cId");
		string string_ = method_117(int_1, "cUid");
		string a81157B = method_117(int_1, "cPassword");
		string string_2 = method_117(int_1, "cFa2");
		int num = ac28BD29_0.F0065AB8(string_, a81157B, string_2);
		switch (num)
		{
		case -4:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Lỗi app Fb!"));
			break;
		case -2:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Không thể kết nối thiết bị!"));
			break;
		case -1:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Tài khoản bị đăng xuất!"));
			break;
		case 2:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Checkpoint!"));
			CC1905A5(int_1, "Checkpoint", ac28BD29_0);
			break;
		case 3:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Không có 2fa!"));
			break;
		case 4:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Tài khoản không đúng!"));
			break;
		case 5:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Mật khẩu không đúng!"));
			CC1905A5(int_1, "Changed pass", ac28BD29_0);
			break;
		case 6:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Mã 2FA không đúng!"));
			break;
		case 7:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Lỗi kết nối Internet!"));
			break;
		case 8:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Tài khoản chưa xác minh!"));
			break;
		case 10:
			SetStatusAccount(int_1, string_0 + Language.GetValue("Không thê\u0309 login lại!"));
			break;
		case 13:
			SetStatusAccount(int_1, string_0 + "Facebook Spam!");
			break;
		}
		return num;
	}

	private void method_23(int int_1, AC28BD29 BC198A85, string string_0, int int_2 = 0, JSON_Settings f72FAFBC_0 = null)
	{
		int int_3 = 0;
		if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbGioiHanThoiGianChayTaiKhoan"))
		{
			int_3 = random_0.Next(SettingsTool.GetSettings("configInteractGeneral").method_0("nudThoiGianChayTaiKhoanFrom"), SettingsTool.GetSettings("configInteractGeneral").method_0("nudThoiGianChayTaiKhoanTo") + 1);
		}
		GClass0 gClass = new GClass0(Thread.CurrentThread, int_3);
		int num = 0;
		string text = "";
		int num2 = -1;
		int DBBE2E = 0;
		int A08FDD0B = 0;
		int int_4 = 0;
		int FD0C = 0;
		int int_5 = 0;
		int int_6 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int B39AE = 0;
		int int_7 = 0;
		int int_8 = -1;
		int int_9 = -1;
		string D0A0E5AD = "";
		A4AF3582 a4AF = null;
		D59F6E91 d59F6E = null;
		Class27 @class = null;
		Class6 class2 = null;
		Class7 class3 = null;
		Class4 class4 = null;
		GClass4 gClass2 = null;
		int num7 = 0;
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		Convert.ToInt32(method_117(int_1, "cSTT"));
		string text2 = method_117(int_1, "cUid");
		string text3 = method_117(int_1, "cId");
		method_117(int_1, "cEmail");
		string string_ = method_117(int_1, "cFa2");
		string f9A9A = method_117(int_1, "cPassword");
		string input = method_117(int_1, "cCookies");
		string text4 = method_117(int_1, "cToken");
		if (text2 == "")
		{
			text2 = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
			if (text2 != "")
			{
				method_114(int_1, "cUid", text2, "uid");
			}
		}
		BC198A85.E985C0AA(text3);
		try
		{
			try
			{
				if (f72FAFBC_0?.AA824D29("RegClone") ?? false)
				{
					int num8 = 0;
					int num9 = 0;
					int num10 = 0;
					int num11 = SettingsTool.GetSettings("configRegClone").method_0("cbbChangeIP");
					List<string> list = SettingsTool.GetSettings("configRegClone").EC378D8A("txtProxy");
					Queue<string> queue = new Queue<string>(GClass22.smethod_1(list));
					while (!bool_0)
					{
						if (!SettingsTool.GetSettings("configGeneral").AA824D29("ckbKhongChangeDevice"))
						{
							SetStatusAccount(int_1, text + $"{num8}/{num9}/{num10}, Change device...");
							BC198A85.ChangeDeviceInfo();
						}
						switch (num11)
						{
						case 1:
							SetStatusAccount(int_1, text + $"{num8}/{num9}/{num10}, Reset 4G...");
							BC198A85.A906F3A9();
							break;
						case 2:
						{
							SetStatusAccount(int_1, text + $"{num8}/{num9}/{num10}, Connect proxy...");
							if (queue.Count == 0)
							{
								queue = new Queue<string>(GClass22.smethod_1(list));
							}
							string string_2 = queue.Dequeue();
							BC198A85.RemoveProxy();
							BC198A85.E0068C33(0, string_2);
							BC198A85.ConnectHttpProxy();
							break;
						}
						}
						num10++;
						SetStatusAccount(int_1, text + $"{num8}/{num9}/{num10}, Reg...");
						switch (AE3E63A9(BC198A85))
						{
						case 1:
							num8++;
							break;
						case 2:
							num9++;
							break;
						}
					}
					SetStatusAccount(int_1, text + $"{num8}/{num9}/{num10}, Done!");
					num7 = 1;
				}
				else if (int_2 == 0 && SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbCheckLiveUid", A72188BC: true) && method_16(text2) && EA98BF20.CheckLiveWall(text2).StartsWith("0|"))
				{
					SetStatusAccount(int_1, Language.GetValue("Tài khoản Die!"));
					CC1905A5(int_1, "Die");
					num7 = 1;
				}
				else if (bool_0)
				{
					SetStatusAccount(int_1, text + Language.GetValue("Đã dừng!"));
					num7 = 1;
				}
				else
				{
					BC198A85.RemoveProxy();
					switch (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp"))
					{
					case 7:
						SetStatusAccount(int_1, Language.GetValue("Đang lấy proxy Tinsoft..."));
						break;
					case 8:
					{
						string text6 = BC198A85.E2B66888();
						BC198A85.E0068C33(0, text6);
						if (SettingsTool.GetSettings("configGeneral").AA824D29("ckbShowProxy"))
						{
							text = "(Proxy: " + text6 + ") ";
						}
						SetStatusAccount(int_1, text + "Reset Xproxy...");
						if (BC198A85.method_6())
						{
							SetStatusAccount(int_1, text + "Reset Xproxy, " + Language.GetValue("đợi") + " {time}s...", SettingsTool.GetSettings("configGeneral").method_0("nudDelayConnectXproxy", 10));
							break;
						}
						SetStatusAccount(int_1, Language.GetValue("Reset Xproxy fail!"));
						num7 = 1;
						goto end_IL_0187;
					}
					case 9:
					{
						string text5 = method_117(int_1, "cProxy");
						int a489CE8B = ((!text5.EndsWith("*0")) ? 1 : 0);
						if (text5 != "")
						{
							if (text5.EndsWith("*0") || text5.EndsWith("*1"))
							{
								text5 = text5.Substring(0, text5.Length - 2);
							}
							BC198A85.E0068C33(a489CE8B, text5);
						}
						break;
					}
					case 10:
						SetStatusAccount(int_1, Language.GetValue("Đang lấy TMProxy..."));
						break;
					case 11:
						SetStatusAccount(int_1, Language.GetValue("Đang lấy Proxyv6..."));
						break;
					case 12:
						SetStatusAccount(int_1, Language.GetValue("Đang lấy Proxy ShopLike..."));
						break;
					case 13:
						SetStatusAccount(int_1, Language.GetValue("Đang lấy Api MinProxy..."));
						break;
					case 14:
						SetStatusAccount(int_1, Language.GetValue("Đang chờ lấy Proxy..."));
						break;
					case 15:
						SetStatusAccount(int_1, text + Language.GetValue("Reset 4G..."));
						if (BC198A85.A906F3A9())
						{
							break;
						}
						SetStatusAccount(int_1, text + Language.GetValue("Error Reset 4G!"));
						num7 = 1;
						goto end_IL_0187;
					}
					if (bool_0)
					{
						SetStatusAccount(int_1, text + Language.GetValue("Đã dừng!"));
						num7 = 1;
					}
					else if (!BC198A85.ConnectHttpProxy())
					{
						SetStatusAccount(int_1, text + Language.GetValue("Connect proxy fail!"));
						num7 = 1;
					}
					else
					{
						if (SettingsTool.GetSettings("configGeneral").AA824D29("ckbKhongCheckIP"))
						{
							goto IL_080e;
						}
						string text7 = "";
						for (int i = 0; i < 2; i++)
						{
							SetStatusAccount(int_1, text + "Check IP...");
							text7 = BC198A85.BC0B8D27();
							if (text7 != "" || i == 1)
							{
								break;
							}
							int num12 = SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp");
							int num13 = num12;
							if (num13 != 15)
							{
								BC198A85.method_110();
								BC198A85.TimeDelay(1.0);
								BC198A85.method_111();
								BC198A85.TimeDelay(5.0);
							}
							else
							{
								BC198A85.A906F3A9();
								BC198A85.TimeDelay(3.0);
							}
						}
						if (text7 == "")
						{
							SetStatusAccount(int_1, text + Language.GetValue("Không check được IP!"));
							num7 = 1;
						}
						else
						{
							if (!text7.Contains("Proxy Authentication Required"))
							{
								text = "(IP: " + text7 + ") ";
								goto IL_080e;
							}
							SetStatusAccount(int_1, text + Language.GetValue("Proxy chưa ủy quyền!"));
							num7 = 1;
						}
					}
				}
				goto end_IL_0187;
				IL_080e:
				if (bool_0)
				{
					SetStatusAccount(int_1, text + Language.GetValue("Đã dừng!"));
					num7 = 1;
				}
				else
				{
					if (/*int_2 == 2 ||*/ SettingsTool.GetSettings("configGeneral").AA824D29("ckbKhongChangeDevice")) //|| !(Convert.ToDouble(BC198A85.GetAndroidVersion()) >= 10.0))
					{
						goto IL_08e3;
					}
					SetStatusAccount(int_1, text + "Change info device...");
					if (BC198A85.ChangerTuongTac(text2))
					{
						SetStatusAccount(int_1, text + "Change info device success!");
						method_114(int_1, "cDevice", BC198A85.NameFake, "device");
						goto IL_08e3;
					}
					SetStatusAccount(int_1, text + "Change info device fail!");
					num7 = 1;
				}
				goto end_IL_0187;
				IL_08e3:
				if (bool_0)
				{
					SetStatusAccount(int_1, text + Language.GetValue("Đã dừng!"));
					num7 = 1;
				}
				else
				{
					gClass.method_0();
					if (SettingsTool.GetSettings("configGeneral").AA824D29("ckbRemoveAccountsInSettings"))
					{
						BC198A85.method_100();
					}
					while (true)
					{
						BC198A85.ClearDataApp("com.android.providers.contacts");
						num = method_21(BC198A85, int_1, text, int_2);
						if (int_2 != 5)
						{
							if (num == 1 || num == 8)
							{
								flag3 = true;
								SetStatusAccount(int_1, text + Language.GetValue("Đăng nhập thành công!"));
								C19A0F19(BC198A85);
								switch (int_2)
								{
								default:
									if (!bool_0)
									{
										string text8 = BC198A85.AF03B30E();
										text4 = text8.Split('|')[0];
										input = text8.Split('|')[1];
										string value = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
										if (value.Trim() != "")
										{
											if (method_16(text2))
											{
												if (text2 != value)
												{
													goto IL_0a20;
												}
											}
											else
											{
												if (text2 != "" && method_117(int_1, "cEmail").Trim() == "")
												{
													method_114(int_1, "cEmail", text2, "email");
												}
												text2 = value;
												method_114(int_1, "cUid", text2, "uid");
											}
										}
										if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbGetToken") && text4 != "")
										{
											CommonSQL.UpdateFieldToAccount(text3, "token", text4);
											SetCellAccount(int_1, "cToken", text4);
										}
										if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbGetCookie") && input != "")
										{
											CommonSQL.UpdateFieldToAccount(text3, "cookie1", input);
											SetCellAccount(int_1, "cCookies", input);
										}
										if (int_2 != 0)
										{
											num7 = 1;
											break;
										}
										DataTable dataTable = Class123.smethod_9(string_0);
										if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbRandomHanhDong"))
										{
											dataTable = Common.smethod_46(dataTable, 3);
										}
										string text9 = "";
										string text10 = "";
										DataTable dataTable2 = new DataTable();
										string d399C = Class123.E93A548E(string_0);
										JSON_Settings f72FAFBC = new JSON_Settings(d399C, D7BE7F11: true);
										int num15 = f72FAFBC.method_0("typeSoLuongHanhDong");
										int num16 = f72FAFBC.method_0("nudHanhDongFrom");
										int num17 = f72FAFBC.method_0("nudHanhDongTo");
										int num18 = dataTable.Rows.Count;
										if (num15 == 1 && num16 <= num17)
										{
											num18 = Base.rd.Next(num16, num17 + 1);
											if (num18 > dataTable.Rows.Count)
											{
												num18 = dataTable.Rows.Count;
											}
										}
										int num19 = 0;
										while (true)
										{
											if (num19 < num18)
											{
												if (bool_0)
												{
													SetStatusAccount(int_1, text + Language.GetValue("Đã dừng!"));
													num7 = 1;
													break;
												}
												num = method_22(BC198A85, int_1, text);
												if (num != 0 && num != 1)
												{
													num7 = 1;
													break;
												}
												try
												{
													text10 = dataTable.Rows[num19]["TenHanhDong"].ToString();
													text9 = dataTable.Rows[num19]["Id_HanhDong"].ToString();
													SetStatusAccount(int_1, text + Language.GetValue("Đang") + " " + text10 + "...");
													dataTable2 = Class123.smethod_10(text9);
													JSON_Settings f72FAFBC2 = new JSON_Settings(dataTable2.Rows[0]["CauHinh"].ToString(), D7BE7F11: true);
													try
													{
														string text11 = dataTable2.Rows[0]["TenTuongTac"].ToString();
														string text12 = text11;
														uint num20 = HashString.DA8CEBAB(text12);
														if (num20 <= 2419354813u)
														{
															switch (num20)
															{
															case 105160162u:
																if (text12 == "HDDangBaiTuong")
																{
																	num = method_55(int_1, text, BC198A85, f72FAFBC2, text10, text9);
																}
																break;
															case 34992592u:
																if (text12 == "HDXemWatchTheoTuKhoa")
																{
																	num = FA1402BE(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 31913242u:
																if (text12 == "HDReportVideo")
																{
																	num = BB214F1D(ref int_9, int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 152310871u:
																if (text12 == "HDUpCover")
																{
																	num = method_39(int_1, text, BC198A85, f72FAFBC2, text10);
																	num4 = ((num == 1) ? 1 : 2);
																}
																break;
															case 115118702u:
																if (text12 == "HDSpamNhom")
																{
																	num = method_84(int_1, text, BC198A85, f72FAFBC2, text10, text9);
																}
																break;
															case 167896116u:
																if (text12 == "HDTuongTacBaiVietTuKhoa")
																{
																	num = CC03DE3E(int_1, text, BC198A85, f72FAFBC2, text10, text9);
																}
																break;
															case 155455705u:
																if (text12 == "HDDangBaiNhom")
																{
																	num = A031C48E(int_1, text, BC198A85, f72FAFBC2, text10, text9);
																}
																break;
															case 516966741u:
																if (text12 == "HDDangReel")
																{
																	num = method_54(ref int_8, int_1, text, BC198A85, f72FAFBC2, text10, text9, input);
																}
																break;
															case 311671696u:
																if (text12 == "HDKetBanGoiY")
																{
																	num = method_65(ref B39AE, int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 551470432u:
																if (text12 == "HDSpamBanBe")
																{
																	num = C8BC6407(int_1, text, BC198A85, f72FAFBC2, text10, text9);
																}
																break;
															case 523366477u:
																if (text12 == "HDBuffFollowUID")
																{
																	num = method_81(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 614517095u:
																if (text12 == "HDReport")
																{
																	num = method_37(ref int_9, int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 582938346u:
																if (text12 == "HDXemStory")
																{
																	num = method_64(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 786238800u:
																if (text12 == "HDXemWatch")
																{
																	num = method_60(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 745266353u:
																if (text12 == "HDXemReel")
																{
																	num = F0214724(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 894688135u:
																if (text12 == "HDTuongTacReelChiDinh")
																{
																	num = B804088D(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 852508141u:
																if (text12 == "HDKetBanTepUid")
																{
																	num = B4999E85(int_1, text, BC198A85, f72FAFBC2, text9, text10);
																}
																break;
															case 1526944464u:
																if (text12 == "HDTuongTacBanBe")
																{
																	num = D7A3BBA6(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 1340375996u:
																if (text12 == "HDBatCheDoChuyenNghiep")
																{
																	num = method_36(int_1, text, BC198A85, text10);
																}
																break;
															case 1653385921u:
																if (text12 == "HDNghiGiaiLao")
																{
																	num = FEAA85AE(int_1, text, f72FAFBC2, text10);
																}
																break;
															case 1577102954u:
																if (text12 == "HDSpamNewfeed")
																{
																	num = method_85(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 1823818229u:
																if (text12 == "HDUpAvatar")
																{
																	num = method_38(int_1, text, BC198A85, f72FAFBC2, text10);
																	num3 = ((num == 1) ? 1 : 2);
																}
																break;
															case 1780458336u:
																if (text12 == "HDDangBaiPage")
																{
																	num = B930AA3D(int_1, text, BC198A85, f72FAFBC2, text10, text9);
																}
																break;
															case 1952866892u:
																if (text12 == "HDKetBanTheoTuKhoa")
																{
																	num = D62AA80C(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 1884305945u:
																if (text12 == "HDDocThongBao")
																{
																	num = method_62(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 2030328732u:
																if (text12 == "HDOnOff2FA")
																{
																	num = B584D3AE(int_1, text, BC198A85, f72FAFBC2, text10);
																	num6 = num;
																}
																break;
															case 2004466602u:
																if (!(text12 == "HDDoiTen"))
																{
																	break;
																}
																num = FF3AA6B7(ref int_6, int_1, text, BC198A85, f72FAFBC2, text10);
																if (int_6 == 1)
																{
																	string text13 = EA98BF20.smethod_9(text2);
																	if (text13 != "")
																	{
																		method_114(int_1, "cName", text13, "name");
																	}
																}
																break;
															case 2277183375u:
																if (text12 == "HDRoiNhom")
																{
																	num = method_43(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 2149398608u:
																if (text12 == "HDBuffLikePage")
																{
																	num = method_80(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 2419354813u:
																if (text12 == "HDTaoNhom")
																{
																	num = B1B3FD1A(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															case 2345355553u:
																if (text12 == "HDSeedingEvents")
																{
																	num = E8BE5A8E(int_1, text, BC198A85, f72FAFBC2, text10);
																}
																break;
															}
														}
														else
														{
															if (num20 <= 3102074063u)
															{
																switch (num20)
																{
																default:
																	goto end_IL_0d20;
																case 2540878680u:
																	if (text12 == "HDThamGiaNhomTuKhoa")
																	{
																		num = D401D48A(int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	goto end_IL_0d20;
																case 2437988220u:
																	if (text12 == "HDMoiBanBeLikePage")
																	{
																		num = B6BA8881(int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	goto end_IL_0d20;
																case 2433475627u:
																	if (text12 == "HDChaySeeding")
																	{
																		num = method_24(int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	goto end_IL_0d20;
																case 2553440797u:
																	if (text12 == "HDCapNhatThongTin")
																	{
																		num = method_41(ref D0A0E5AD, int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	goto end_IL_0d20;
																case 2550743232u:
																	if (text12 == "HDTuongTacWall")
																	{
																		num = method_71(int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	goto end_IL_0d20;
																case 2862981448u:
																	if (text12 == "HDCauHinhTaiKhoan")
																	{
																		num = method_40(int_1, text, BC198A85, text10);
																	}
																	goto end_IL_0d20;
																case 2821037716u:
																	if (text12 == "HDHuyKetBan")
																	{
																		num = method_58(int_1, text, BC198A85, f72FAFBC2, text4, input, text10);
																	}
																	goto end_IL_0d20;
																case 2924758840u:
																	if (text12 == "HDMoiBanBeVaoNhom")
																	{
																		num = method_42(int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	goto end_IL_0d20;
																case 2922412940u:
																	if (text12 == "HDTaoPage")
																	{
																		num = A2A1211C(int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	goto end_IL_0d20;
																case 3010844127u:
																	if (text12 == "HDXoaReel")
																	{
																		num = method_53(int_1, text, BC198A85, f72FAFBC2, text10, text9, input);
																	}
																	goto end_IL_0d20;
																case 2944435598u:
																	if (text12 == "HDThamGiaNhomUid")
																	{
																		num = E33C0EA8(int_1, text, BC198A85, f72FAFBC2, text9, text10);
																	}
																	goto end_IL_0d20;
																case 3094399544u:
																	if (text12 == "HDDongBoDanhBa")
																	{
																		num = CA0ECE3C(int_1, text, BC198A85, f72FAFBC2, text9, text10);
																	}
																	goto end_IL_0d20;
																case 3035546143u:
																	if (text12 == "HDTuongTacNewsfeed")
																	{
																		num = method_70(int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	goto end_IL_0d20;
																case 3102074063u:
																	if (text12 == "HDTuongTacVideo")
																	{
																		break;
																	}
																	goto end_IL_0d20;
																case 3099572506u:
																	if (text12 == "HDDangXuatThietBiCu")
																	{
																		num = CD8C43A7(int_1, text, BC198A85, text10);
																	}
																	goto end_IL_0d20;
																}
																goto IL_1926;
															}
															if (num20 <= 3671364376u)
															{
																switch (num20)
																{
																case 3255732838u:
																	if (text12 == "HDDoiMatKhau")
																	{
																		num = F71C9A17(ref int_5, int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	break;
																case 3182739171u:
																	if (text12 == "HDTuongTacBaiVietChiDinh")
																	{
																		num = method_77(int_1, text, BC198A85, f72FAFBC2, text10, text9);
																	}
																	break;
																case 3375859832u:
																	if (text12 == "HDDanhGiaPage")
																	{
																		num = BBB0D1BD(int_1, text, BC198A85, f72FAFBC2, text9, text10);
																	}
																	break;
																case 3363219176u:
																	if (text12 == "HDTuongTacReelTuKhoa")
																	{
																		num = CB3AB7BA(int_1, text, BC198A85, f72FAFBC2, text10, text9);
																	}
																	break;
																case 3503341118u:
																	if (text12 == "HDTuongTacNhom")
																	{
																		num = method_79(int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	break;
																case 3495710863u:
																	if (text12 == "HDShareBaiNangCao")
																	{
																		num = E6A9E6AD(int_1, text, BC198A85, f72FAFBC2, text9, text10);
																		num2 = num;
																	}
																	break;
																case 3671364376u:
																	if (text12 == "HDThamGiaNhomGoiY")
																	{
																		num = method_51(int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	break;
																case 3609367991u:
																	if (text12 == "HDAddMail")
																	{
																		num = method_35(ref DBBE2E, ref int_4, ref FD0C, int_1, text, BC198A85, f72FAFBC2, text9, text10);
																		if (DBBE2E == 7)
																		{
																			bool_0 = true;
																		}
																	}
																	break;
																}
															}
															else if (num20 <= 4062736188u)
															{
																if (num20 <= 3877387086u)
																{
																	if (num20 != 3677432718u)
																	{
																		if (num20 == 3877387086u && text12 == "HDTuongTacLivestream")
																		{
																			goto IL_1926;
																		}
																	}
																	else if (text12 == "HDDangStory")
																	{
																		num = method_82(ref int_7, int_1, text, BC198A85, f72FAFBC2, text10, text9);
																	}
																}
																else
																{
																	switch (num20)
																	{
																	case 4062736188u:
																		if (text12 == "HDXoaSdt")
																		{
																			num = F81EC224(int_1, text, BC198A85, text10);
																			num5 = num;
																		}
																		break;
																	case 4033341327u:
																		if (text12 == "HDVerifyAccount")
																		{
																			num = D0AFB48D(ref A08FDD0B, int_1, text, BC198A85, f72FAFBC2, text9, text10);
																			if (A08FDD0B == 8)
																			{
																				A08FDD0B = 0;
																				CC1905A5(int_1, "Checkpoint", BC198A85);
																				SetStatusAccount(int_1, text + "Checkpoint!");
																				num7 = 1;
																				goto IL_1f74;
																			}
																			break;
																		}
																		break;
																	}
																}
															}
															else
															{
																switch (num20)
																{
																case 4095834327u:
																	if (text12 == "HDXacNhanKetBan")
																	{
																		num = EF9C309C(int_1, text, BC198A85, f72FAFBC2, text10);
																	}
																	break;
																case 4080982511u:
																	if (text12 == "HDTuongTacPage")
																	{
																		num = FE0D7408(int_1, text, BC198A85, f72FAFBC2, text9, text10);
																	}
																	break;
																case 4198930712u:
																	if (text12 == "HDXoaThietBiTinCay")
																	{
																		num = FA9F9110(int_1, text, BC198A85, text10);
																	}
																	break;
																case 4189681400u:
																	if (text12 == "HDSpamBaiViet")
																	{
																		num = method_83(int_1, text, BC198A85, f72FAFBC2, text10, text9);
																	}
																	break;
																}
															}
														}
														goto end_IL_0d20;
														IL_1926:
														num = E493A119(int_1, text, BC198A85, f72FAFBC2, text10, text9);
														end_IL_0d20:;
													}
													catch (Exception a81E)
													{
														Common.smethod_43(a81E, dataTable2.Rows[0]["TenTuongTac"].ToString());
													}
												}
												catch (Exception a81E2)
												{
													Common.smethod_43(a81E2, "Tuong tac theo kich ban");
												}
												switch (num)
												{
												default:
													goto IL_1adf;
												case -5:
													flag2 = true;
													break;
												case -4:
													flag = true;
													break;
												case -2:
													goto end_IL_0187;
												}
											}
											if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbCapNhatThongTin"))
											{
												SetStatusAccount(int_1, text + "Check info...");
												method_34(BC198A85, int_1, text + "Check info...", input, SettingsTool.GetSettings("configInteractGeneral"));
											}
											if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbCongKhaiThongTin"))
											{
												SetStatusAccount(int_1, text + "Public info account...");
												method_32(BC198A85, int_1, text + "Public info account...");
											}
											if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbAllowFollow"))
											{
												SetStatusAccount(int_1, text + "Allow follow...");
												method_33(BC198A85, int_1, text + "Allow follow...");
											}
											if (!SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbLogOut"))
											{
											}
											if (SettingsTool.GetSettings("configInteractGeneral").AA824D29("ckbCheckGoiYKetBan"))
											{
												if (B39AE == 0)
												{
													SetStatusAccount(int_1, text + Language.GetValue("Check gợi ý kết bạn") + "...");
													FA905AA0(BC198A85, int_1, text, "fb://faceweb/f?href=https://m.facebook.com/friends/center/suggestions/");
													B39AE = ((BC198A85.FindElement(10, "", new List<string> { "//*[@text='No Suggestions Available']", "//android.widget.Button[contains(@text, \"as a friend\")]" }) == "//android.widget.Button[contains(@text, \"as a friend\")]") ? 1 : 2);
													SetStatusAccount(int_1, text + Language.GetValue("Check gợi ý kết bạn") + ": " + ((B39AE == 1) ? "Yes" : "No") + "!");
												}
											}
											else
											{
												B39AE = 0;
											}
											break;
											IL_1adf:
											num19++;
										}
									}
									else
									{
										SetStatusAccount(int_1, text + Language.GetValue("Đã dừng!"));
										num7 = 1;
									}
									break;
								case 6:
								{
									SetStatusAccount(int_1, text + "Backup group...");
									input = BC198A85.AF03B30E().Split('|')[1];
									List<string> list2 = EA98BF20.smethod_1(input, BC198A85.Proxy, BC198A85.int_1, f72FAFBC_0.AA824D29("ckbCheckNhomKiemDuyet"));
									File.WriteAllLines("backupgroup\\" + text2 + ".txt", list2);
									SetStatusAccount(int_1, text + $"Backup group success: {list2.Count}!");
									method_114(int_1, "cGroup", list2.Count.ToString(), "groups");
									num7 = 1;
									break;
								}
								case 4:
									SetStatusAccount(int_1, text + Language.GetValue("Reg Instagram..."));
									switch (BC198A85.D7AD8787(text2, f9A9A, string_))
									{
									default:
										SetStatusAccount(int_1, text + Language.GetValue("Reg Instagram fail!"));
										method_120(int_1, 1);
										break;
									case 3:
										SetStatusAccount(int_1, text + Language.GetValue("Reg Instagram fail: Tài khoản đã tồn tại!"));
										method_120(int_1, 1);
										break;
									case 1:
										SetStatusAccount(int_1, text + Language.GetValue("Reg Instagram success!"));
										method_120(int_1, 2);
										break;
									}
									num7 = 1;
									break;
								case 3:
								{
									SetStatusAccount(int_1, text + Language.GetValue("Reg Tiktok..."));
									int num14 = BC198A85.method_92("", "", "", "");
									if (num14 == 1)
									{
										SetStatusAccount(int_1, text + Language.GetValue("Reg Tiktok success!"));
										method_120(int_1, 2);
									}
									else
									{
										SetStatusAccount(int_1, text + Language.GetValue("Reg Tiktok fail!"));
										method_120(int_1, 1);
									}
									num7 = 1;
									break;
								}
								}
							}
							else
							{
								if (int_2 == 2)
								{
									BC198A85.ClearDataApp(BC198A85.FacebookPacker);
								}
								num7 = 1;
							}
						}
						else
						{
							CBAF278E(int_1, text, BC198A85);
							num7 = 1;
						}
						break;
						IL_0a20:
						BC198A85.ClearDataApp(BC198A85.FacebookPacker);
						string b41F7EA = FileHelper.GetPathToCurrentFolder() + "\\profile\\" + text2 + ".tar.gz";
						Common.smethod_49(b41F7EA);
					}
				}
				end_IL_0187:;
			}
			catch (Exception ex)
			{
				if (!ex.ToString().Contains("Thread was being aborted."))
				{
					SetStatusAccount(int_1, text + Language.GetValue("Lô\u0303i không xa\u0301c đi\u0323nh!"));
					num7 = 1;
					Common.ExportError(null, ex, Language.GetValue("Lô\u0303i không xa\u0301c đi\u0323nh!"));
				}
			}
			goto IL_1f74;
			IL_1f74:
			string text14 = "";
			if (num7 == 1)
			{
				text14 = method_116(int_1);
			}
			else if (method_16(text2) && EA98BF20.CheckLiveWall(text2).StartsWith("0|"))
			{
				CC1905A5(int_1, "Die");
				text14 = Language.GetValue("Tài khoản Die!");
			}
			if (int_2 != 2)
			{
				if (flag3 && Convert.ToDouble(BC198A85.GetAndroidVersion()) >= 9.0)
				{
					SetStatusAccount(int_1, text + Language.GetValue("Backup data Fb..."));
					BC198A85.BackupAppFb(text2);
					CommonSQL.UpdateFieldToAccount(text3, "profile", "Yes");
					SetCellAccount(int_1, "cProfile", "Yes");
					SetStatusAccount(int_1, text + Language.GetValue("Backup data Fb xong!"));
					if (!File.Exists(FileHelper.GetPathToCurrentFolder() + "\\device\\" + text2 + ".tar.gz"))
					{
						BC198A85.BackupAppMaxChange(text2);
					}
				}
				if (int_2 == 1)
				{
					BC198A85.method_58(BC198A85.FacebookPacker);
				}
				else
				{
					BC198A85.ClearDataApp("com.facebook.katana");
					BC198A85.RunCMD("shell input keyevent 3");
					BC198A85.RemoveProxy();
				}
			}
			else
			{
				BC198A85.method_59(BC198A85.FacebookPacker);
			}
			string text15 = "";
			if (A08FDD0B != 0)
			{
				string text16 = "";
				switch (A08FDD0B)
				{
				case 1:
					text16 = "Success";
					break;
				case 2:
					text16 = "Fail";
					break;
				case 3:
					text16 = "Fail (Sai pass)";
					break;
				case 4:
					text16 = "Fail (No OTP)";
					break;
				case 5:
					text16 = "Fail (Cannot connect Mail)";
					break;
				case 6:
					text16 = "Fail (Không có tùy chọn Add mail)";
					break;
				case 7:
					text16 = "Fail (Hết mail)";
					break;
				}
				text15 = text15 + "-Verify " + text16;
			}
			if (DBBE2E != 0)
			{
				string text17 = "";
				switch (DBBE2E)
				{
				case 1:
					text17 = "Success";
					break;
				case 2:
					text17 = "Fail";
					break;
				case 3:
					text17 = "Fail (Sai pass)";
					CC1905A5(int_1, "Changed pass", BC198A85);
					break;
				case 4:
					text17 = "Fail (No OTP)";
					break;
				case 5:
					text17 = "Fail (Cannot connect Mail)";
					break;
				case 6:
					text17 = "Fail (Không có tùy chọn Add mail)";
					break;
				case 7:
					text17 = "Fail (Hết mail)";
					break;
				case 8:
					text17 = "Fail (No pass)";
					break;
				}
				text15 = text15 + "-Add Mail " + text17;
			}
			if (int_4 != 0)
			{
				string text18 = "";
				switch (int_4)
				{
				case 2:
					text18 = "Fail";
					break;
				case 1:
					text18 = "Success";
					break;
				}
				text15 = text15 + "-Set Primary Mail " + text18;
			}
			if (FD0C != 0)
			{
				string text19 = "";
				switch (FD0C)
				{
				case 2:
					text19 = "Fail";
					break;
				case 1:
					text19 = "Success";
					break;
				}
				text15 = text15 + "-Remove Mail " + text19;
			}
			if (int_5 != 0)
			{
				string text20 = "";
				switch (int_5)
				{
				case 1:
					text20 = "Success";
					break;
				case 2:
					text20 = "Fail";
					break;
				case 3:
					text20 = "Fail (Sai pass)";
					CC1905A5(int_1, "Changed pass", BC198A85);
					break;
				case 4:
					text20 = "Fail (Lỗi Internet)";
					break;
				case 5:
					text20 = "Fail (Pass mới giống pass cũ)";
					break;
				}
				text15 = text15 + "-Change Pass " + text20;
			}
			if (int_6 != 0)
			{
				string text21 = "";
				switch (int_6)
				{
				case 1:
					text21 = "Success";
					break;
				case 2:
					text21 = "Fail";
					break;
				case 3:
					text21 = "Fail (Sai pass)";
					CC1905A5(int_1, "Changed pass", BC198A85);
					break;
				case 4:
					text21 = "Fail (You can't change your name on Facebook right now)";
					break;
				case 5:
					text21 = "Fail (Something went wrong)";
					break;
				}
				text15 = text15 + "-Đổi tên " + text21;
			}
			if (num3 != 0)
			{
				string text22 = "";
				switch (num3)
				{
				case 2:
					text22 = "Fail";
					break;
				case 1:
					text22 = "Success";
					break;
				}
				text15 = text15 + "-Up avatar " + text22;
			}
			if (num4 != 0)
			{
				string text23 = "";
				switch (num4)
				{
				case 2:
					text23 = "Fail";
					break;
				case 1:
					text23 = "Success";
					break;
				}
				text15 = text15 + "-Up cover " + text23;
			}
			if (num6 != 0)
			{
				string text24 = "";
				switch (num6)
				{
				case 1:
					text24 = "-Bật 2FA Success";
					break;
				case 2:
					text24 = "-Bật 2FA Fail";
					break;
				case 3:
					text24 = "-Sai pass";
					CC1905A5(int_1, "Changed pass", BC198A85);
					break;
				case 4:
					text24 = "-Bật 2FA Fail (Đã có 2fa)";
					break;
				case 5:
					text24 = "-Bật 2FA Fail (otp từ 2fa sai)";
					break;
				case 6:
					text24 = "-Tắt 2FA Success";
					break;
				}
				text15 += text24;
			}
			if (num5 != 0)
			{
				string text25 = "";
				switch (num5)
				{
				case 1:
					text25 = "Success";
					break;
				case 2:
					text25 = "Fail";
					break;
				case 3:
					text25 = "Fail (Sai pass)";
					CC1905A5(int_1, "Changed pass", BC198A85);
					break;
				case 4:
					text25 = "Fail (Chưa có mail)";
					break;
				case 5:
					text25 = "Fail (This content is no longer available)";
					break;
				}
				text15 = text15 + "-Xóa Sđt " + text25;
			}
			if (B39AE != 0)
			{
				string text26 = "";
				switch (B39AE)
				{
				case 2:
					text26 = "No";
					break;
				case 1:
					text26 = "Yes";
					break;
				}
				text15 = text15 + "- Gợi ý kết bạn: " + text26;
			}
			if (int_7 != 0)
			{
				int num21 = int_7;
				int num22 = num21;
				if (num22 == 2)
				{
					text15 += "- Đăng story fail: Không tìm thấy";
				}
			}
			if (int_8 != -1)
			{
				text15 += $"- Đăng reel: {int_8}";
			}
			if (int_9 != -1)
			{
				text15 += $"- Report: {int_9}";
			}
			if (D0A0E5AD != "")
			{
				text15 = text15 + "- Cập nhật thông tin: " + D0A0E5AD.TrimEnd('-');
			}
			if (num2 > -1)
			{
				text15 += $"- Share success {num2}!";
			}
			string text27 = text14;
			string text28 = text27;
			if (!(text28 == ""))
			{
				SetStatusAccount(int_1, text + text14 + ((text14 == "") ? text15.TrimStart('-') : text15) + (flag2 ? "- Lô\u0303i mơ\u0309 link" : "") + (flag ? "- Facebook blocked" : ""));
			}
			else
			{
				SetStatusAccount(int_1, text + Language.GetValue("Đã tương tác xong!") + (flag2 ? "- Lô\u0303i mơ\u0309 link" : "") + (flag ? "- Facebook blocked" : "") + text15 + " [" + gClass.method_1() + "(s)]");
				method_114(int_1, "cInteractEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "interactEnd");
				if (F08831A5(int_1) != "Changed pass")
				{
					CC1905A5(int_1, "Live");
				}
			}
			if (method_116(int_1).Contains("Internet"))
			{
				int num23 = SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp");
				int num24 = num23;
				if (num24 != 15)
				{
					BC198A85.method_110();
					BC198A85.method_111();
				}
				else
				{
					BC198A85.A906F3A9();
				}
			}
			lock (object_0)
			{
				switch (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp"))
				{
				case 7:
					a4AF?.F5BB9188();
					break;
				case 8:
					d59F6E?.E82C7A27(SettingsTool.GetSettings("configGeneral").method_0("typeRunXproxy"));
					break;
				case 10:
					@class?.method_0();
					break;
				case 11:
					class2?.method_0();
					break;
				case 12:
					class3?.method_0();
					break;
				case 13:
					class4?.A6964C31();
					break;
				case 14:
					gClass2?.F618B2B9();
					break;
				case 9:
					break;
				}
			}
			list_1.Remove(Thread.CurrentThread.Name.ToString());
		}
		catch (Exception ex2)
		{
			if (!ex2.ToString().Contains("Thread was being aborted."))
			{
				return;
			}
			try
			{
				if (flag3)
				{
					SetStatusAccount(int_1, text + Language.GetValue("Backup data Fb..."));
					BC198A85.BackupAppFb(text2);
					CommonSQL.UpdateFieldToAccount(text3, "profile", "Yes");
					SetCellAccount(int_1, "cProfile", "Yes");
				}
				BC198A85.ClearDataApp("com.facebook.katana");
				BC198A85.RunCMD("shell input keyevent 3");
				SetStatusAccount(int_1, text + Language.GetValue("Đã tương tác xong!") + (flag2 ? "- Lô\u0303i mơ\u0309 link" : "") + (flag ? "- Facebook blocked" : "") + " [" + gClass.method_1() + "(s)]");
				method_114(int_1, "cInteractEnd", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "interactEnd");
				lock (object_0)
				{
					switch (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp"))
					{
					case 7:
						a4AF?.F5BB9188();
						break;
					case 8:
						d59F6E?.E82C7A27(SettingsTool.GetSettings("configGeneral").method_0("typeRunXproxy"));
						break;
					case 10:
						@class?.method_0();
						break;
					case 11:
						class2?.method_0();
						break;
					case 12:
						class3?.method_0();
						break;
					case 13:
						class4?.A6964C31();
						break;
					case 14:
						gClass2?.F618B2B9();
						break;
					case 9:
						break;
					}
				}
				list_1.Remove(Thread.CurrentThread.Name.ToString());
			}
			catch (Exception)
			{
			}
		}
	}

	private void C19A0F19(AC28BD29 C80B1E12)
	{
	}

	private void D0297BA6(string string_0, string string_1)
	{
		lock (B7A06AA0)
		{
			File.AppendAllText(string_0, string_1 + "\r\n");
		}
	}

	private int AE3E63A9(AC28BD29 ac28BD29_0)
	{
		if (!Base.bool_0)
		{
			return 0;
		}
		return 0;
	}

	private int method_24(int int_1, string string_0, AC28BD29 A820AE29, JSON_Settings f72FAFBC_0, string string_1)
	{
		string text = method_117(int_1, "cUid");
		int minValue = f72FAFBC_0.method_0("nudDelayFrom", 3);
		int num = f72FAFBC_0.method_0("nudDelayTo", 5);
		try
		{
			SetStatusAccount(int_1, string_0 + "Get Job...");
			int num2 = 0;
			int num3 = 0;
			List<OrderDetail> list = JobHelper.D7AC96A4(text);
			for (int i = 0; i < list.Count; i++)
			{
				OrderDetail c387042E = list[i];
				string text2 = string_0 + $"Đang làm {i + 1}/{list.Count} -> {c387042E.CEB2DD02}: ";
				JSON_Settings f72FAFBC = new JSON_Settings();
				f72FAFBC.GetValue("id", (object)c387042E.BF2F92AA);
				f72FAFBC.GetValue("content", (object)c387042E.String_1);
				(bool, string) tuple = (false, "");
				string cEB2DD = c387042E.CEB2DD02;
				string text3 = cEB2DD;
				switch (HashString.DA8CEBAB(text3))
				{
				case 1466588889u:
					if (text3 == "view_reel")
					{
						tuple = method_25(int_1, text2, A820AE29, f72FAFBC);
					}
					break;
				case 119173917u:
					if (text3 == "like_post")
					{
						f72FAFBC.GetValue("reaction", (object)c387042E.String_0);
						tuple = CC33EEBB(int_1, text2, A820AE29, f72FAFBC);
					}
					break;
				case 2458671617u:
					if (text3 == "review_page")
					{
						f72FAFBC.GetValue("isReviewPage", true);
						tuple = method_30(int_1, text2, A820AE29, f72FAFBC);
					}
					break;
				case 1738982494u:
					if (text3 == "comment")
					{
						tuple = method_26(int_1, text2, A820AE29, f72FAFBC);
					}
					break;
				case 1533824880u:
					if (text3 == "follow")
					{
						tuple = BB33E209(int_1, text2, A820AE29, f72FAFBC);
					}
					break;
				case 3685020920u:
					if (text3 == "view")
					{
						tuple = DFBF9E8D(int_1, text2, A820AE29, f72FAFBC);
					}
					break;
				case 2848586808u:
					if (text3 == "share")
					{
						tuple = method_27(int_1, text2, A820AE29, f72FAFBC);
					}
					break;
				case 3983124032u:
					if (text3 == "like_page")
					{
						f72FAFBC.GetValue("isLikePage", true);
						tuple = method_30(int_1, text2, A820AE29, f72FAFBC);
					}
					break;
				case 3777140709u:
					if (text3 == "join_group")
					{
						tuple = method_28(int_1, text2, A820AE29, f72FAFBC);
					}
					break;
				case 3717946706u:
					if (text3 == "view_story")
					{
						tuple = BC2D5D9B(int_1, text2, A820AE29, f72FAFBC);
					}
					break;
				}
				if (tuple.Item1)
				{
					num2++;
				}
				else
				{
					num3++;
					method_29(c387042E, tuple.Item2, A820AE29);
				}
				JobHelper.EC3BF620(text, c387042E, tuple.Item1, tuple.Item2);
				if (i + 1 != list.Count)
				{
					SetStatusAccount(int_1, text2 + "Làm Job tiếp sau {time}s...", Base.rd.Next(minValue, num + 1));
					int num4 = method_22(A820AE29, int_1, string_0);
					if (num4 != 0 && num4 != 1)
					{
						break;
					}
					continue;
				}
				break;
			}
		}
		catch
		{
		}
		return 0;
	}

	private (bool isSuccess, string error) CC33EEBB(int D9A2CC11, string B8AEC620, AC28BD29 ac28BD29_0, JSON_Settings D2A6C109)
	{
		string text = D2A6C109.GetValue("id");
		string item = D2A6C109.GetValue("reaction");
		bool item2 = false;
		string text2 = text + ": ";
		if (text.Contains("facebook.com/reel/"))
		{
			text2 += "Không dùng được với link reel!";
		}
		else
		{
			try
			{
				SetStatusAccount(D9A2CC11, B8AEC620 + Language.GetValue("Mở bài viết..."));
				int num = EAB1360A(ac28BD29_0, D9A2CC11, B8AEC620, text);
				if (num != 1)
				{
					text2 += "Lỗi mở link!";
				}
				else
				{
					string d80AC = ("like,love,care,haha,wow,sad,angry".Split(',').ToList().IndexOf(item) + 1).ToString();
					int num2 = 0;
					while (true)
					{
						if (num2 < 5)
						{
							SetStatusAccount(D9A2CC11, B8AEC620 + "Find Like...");
							string text3 = ac28BD29_0.GetPageSource();
							if (ac28BD29_0.DoesElementExist(0, text3, "//*[@content-desc=\"Make a post on Facebook\"]"))
							{
								text2 += "Lỗi mở link!";
								break;
							}
							List<string> list = ac28BD29_0.method_28(0, text3, new List<string> { "//*[@content-desc=\"Like button. Double tap and hold to react.\"]", "//*[@content-desc=\"Like Button\"]", "//*[@content-desc='Like']" });
							SetStatusAccount(D9A2CC11, B8AEC620 + "Find Like: " + list.Count);
							if (list.Count > 0)
							{
								if (ac28BD29_0.method_15() == "com.facebook.video.activity.DeprecatedFullscreenVideoPlayerActivity")
								{
									string text4 = list.First();
									Point point = new Class65(text4).F799891B();
									Point point2 = new Class65("[35," + text4.Split(new string[3] { "[", ",", "]" }, StringSplitOptions.RemoveEmptyEntries)[1] + "][65," + text4.Split(new string[3] { "[", ",", "]" }, StringSplitOptions.RemoveEmptyEntries)[3] + "]").F799891B();
									SetStatusAccount(D9A2CC11, B8AEC620 + "Tap Reaction...");
									ac28BD29_0.method_50(point.X, point.Y, point2.X, point2.Y);
									ac28BD29_0.method_54(1.0, 1.5);
									ac28BD29_0.C628163C(d80AC);
									ac28BD29_0.method_54(1.0, 1.5);
									item2 = true;
									break;
								}
								Point point3 = ac28BD29_0.method_51(list.First());
								if ((ac28BD29_0.ED9CDB24(text3, "Create a reel") && ac28BD29_0.method_37(point3.X, point3.Y)) || (ac28BD29_0.method_49(point3.X, point3.Y) && ac28BD29_0.C628163C(d80AC)))
								{
									item2 = true;
									break;
								}
							}
							SetStatusAccount(D9A2CC11, B8AEC620 + "Scroll...");
							if (!ac28BD29_0.CE16082B() || ac28BD29_0.method_68())
							{
								num2++;
								continue;
							}
						}
						text2 += "Timeout!";
						break;
					}
				}
			}
			catch (Exception ex)
			{
				text2 = text2 + "Exception: " + ex.ToString() + "!";
			}
		}
		return (item2, text2);
	}

	private (bool isSuccess, string error) DFBF9E8D(int CF94A294, string string_0, AC28BD29 BF384909, JSON_Settings D822F121)
	{
		string text = D822F121.GetValue("id");
		bool item = false;
		string text2 = text + ": ";
		try
		{
			SetStatusAccount(CF94A294, string_0 + Language.GetValue("Mở bài viết..."));
			int num = EAB1360A(BF384909, CF94A294, string_0, text);
			if (num != 1)
			{
				text2 += "Lỗi mở link!";
			}
			else
			{
				BF384909.method_40(5, "//*[contains(@content-desc,'Play')]", "");
				SetStatusAccount(CF94A294, string_0 + Language.GetValue("Xem video {time}s..."), 5);
				item = true;
			}
		}
		catch (Exception ex)
		{
			text2 = text2 + "Exception: " + ex.ToString() + "!";
		}
		return (item, text2);
	}

	private (bool isSuccess, string error) method_25(int BC084705, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0)
	{
		string text = f72FAFBC_0.GetValue("id");
		bool item = false;
		string text2 = text + ": ";
		try
		{
			SetStatusAccount(BC084705, string_0 + Language.GetValue("Mở bài viết..."));
			int num = EAB1360A(ac28BD29_0, BC084705, string_0, text);
			if (num != 1)
			{
				text2 += "Lỗi mở link!";
			}
			else
			{
				SetStatusAccount(BC084705, string_0 + Language.GetValue("Xem reel {time}s..."), 5);
				item = true;
			}
		}
		catch (Exception ex)
		{
			text2 = text2 + "Exception: " + ex.ToString() + "!";
		}
		return (item, text2);
	}

	private (bool isSuccess, string error) BC2D5D9B(int int_1, string string_0, AC28BD29 E11AF7B0, JSON_Settings f72FAFBC_0)
	{
		string text = f72FAFBC_0.GetValue("id");
		bool item = false;
		string text2 = text + ": ";
		try
		{
			SetStatusAccount(int_1, string_0 + Language.GetValue("Mở bài viết..."));
			int num = EAB1360A(E11AF7B0, int_1, string_0, text);
			if (num != 1)
			{
				text2 += "Lỗi mở link!";
			}
			else
			{
				string string_ = "";
				if (E11AF7B0.C60AEB35(60, ref string_, "(//*[@text='Stories'])[2]"))
				{
					if (E11AF7B0.method_40(10, "//*[@text='Tap to view story']", string_))
					{
						SetStatusAccount(int_1, string_0 + Language.GetValue("Xem story..."));
						if (!E11AF7B0.method_40(3, "//*[@text='Play Video']", "") || !E11AF7B0.method_37(700, 1400))
						{
						}
						SetStatusAccount(int_1, string_0 + Language.GetValue("Xem story {time}s..."), 1);
						item = true;
					}
					else
					{
						text2 += "Không tìm thấy [Tap to view story]!";
					}
				}
				else
				{
					text2 += "Không load được story!";
				}
			}
		}
		catch (Exception ex)
		{
			text2 = text2 + "Exception: " + ex.ToString() + "!";
		}
		return (item, text2);
	}

	private (bool isSuccess, string error) method_26(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0)
	{
		string text = f72FAFBC_0.GetValue("id");
		string string_ = f72FAFBC_0.GetValue("content");
		bool item = false;
		string text2 = text + ": ";
		try
		{
			SetStatusAccount(int_1, string_0 + Language.GetValue("Mở bài viết..."));
			int num = EAB1360A(ac28BD29_0, int_1, string_0, text);
			if (num != 1)
			{
				text2 += "Lỗi mở link!";
			}
			else
			{
				int num2 = 0;
				while (true)
				{
					if (num2 < 5)
					{
						SetStatusAccount(int_1, string_0 + "Find Comment...");
						string a00A61A = ac28BD29_0.GetPageSource();
						List<string> list = ac28BD29_0.method_28(0, a00A61A, new List<string> { "//*[@content-desc=\"Comment Button\"]", "//*[@content-desc=\"Answer Button\"]", "//*[@text='Answer']", "//*[@text=\"Comment\"]", "//*[@content-desc=\"Comment\"]", "//android.widget.EditText[@resource-id='composerInput']" });
						SetStatusAccount(int_1, string_0 + "Find Comment: " + list.Count);
						if (list.Count > 0)
						{
							Point point = ac28BD29_0.method_51(list.Last());
							SetStatusAccount(int_1, string_0 + "Tap Comment...");
							if (ac28BD29_0.method_37(point.X, point.Y))
							{
								ac28BD29_0.method_54(1.0, 2.0);
								int num3 = 0;
								while (num3 < 2)
								{
									SetStatusAccount(int_1, string_0 + "Find EditText...");
									if (!ac28BD29_0.DoesElementExist(5, "", "//android.widget.EditText"))
									{
										if (!ac28BD29_0.TapByXPath("//android.widget.LinearLayout[@content-desc=\"Comment input box\"]"))
										{
											break;
										}
										num3++;
										continue;
									}
									SetStatusAccount(int_1, string_0 + Language.GetValue("Nhập dữ liệu..."));
									ac28BD29_0.SendByXPath("//android.widget.EditText", string_);
									ac28BD29_0.method_54(1.0, 2.0);
									SetStatusAccount(int_1, string_0 + "Tap Send...");
									a00A61A = "";
									string a28409BD = ac28BD29_0.CB3C4B8A(5, ref a00A61A, new List<string> { "//*[@content-desc=\"Send\"]", "//*[@text='Post']" });
									if (ac28BD29_0.TapByXPath(a28409BD, a00A61A))
									{
										SetStatusAccount(int_1, string_0 + "Tap Send, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(3, 6));
										ac28BD29_0.method_30(120);
									}
									item = true;
									goto end_IL_0032;
								}
							}
						}
						SetStatusAccount(int_1, string_0 + "Scroll...");
						if (!ac28BD29_0.CE16082B() || ac28BD29_0.method_68())
						{
							num2++;
							continue;
						}
					}
					text2 += "Timeout!";
					break;
				}
			}
			end_IL_0032:;
		}
		catch (Exception ex)
		{
			text2 = text2 + "Exception: " + ex.ToString() + "!";
		}
		return (item, text2);
	}

	private (bool isSuccess, string error) method_27(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0)
	{
		string text = f72FAFBC_0.GetValue("id");
		bool item = false;
		string text2 = text + ": ";
		try
		{
			SetStatusAccount(int_1, string_0 + Language.GetValue("Mở bài viết..."));
			int num = EAB1360A(ac28BD29_0, int_1, string_0, text);
			if (num != 1)
			{
				text2 += "Lỗi mở link!";
			}
			else
			{
				string text3 = "";
				int tickCount = Environment.TickCount;
				while (true)
				{
					text3 = ac28BD29_0.GetPageSource();
					string text4 = ac28BD29_0.FindElement(0, text3, new List<string> { "//*[@content-desc=\"Share Button\"]", "//*[@text=\"Share\"]", "//*[@content-desc=\"Share\"]", "//*[@content-desc=\"Share Now\"]", "//*[@content-desc='Write Post']", "//*[@content-desc='POST']" });
					switch (text4)
					{
					case "//*[@content-desc=\"Share Button\"]":
					case "//*[@text=\"Share\"]":
					case "//*[@content-desc=\"Share\"]":
					case "//*[@content-desc='Write Post']":
						SetStatusAccount(int_1, string_0 + "Tap " + ac28BD29_0.method_105(text4) + "...");
						ac28BD29_0.TapByXPath(text4, text3);
						goto IL_00a0;
					default:
						SetStatusAccount(int_1, string_0 + "Scroll...");
						if (ac28BD29_0.CE16082B() && !ac28BD29_0.method_68())
						{
							break;
						}
						goto IL_00a0;
					case "//*[@content-desc=\"Share Now\"]":
					case "//*[@content-desc='POST']":
						SetStatusAccount(int_1, string_0 + "Tap " + ac28BD29_0.method_105(text4) + "...");
						ac28BD29_0.TapByXPath(text4, text3);
						ac28BD29_0.TimeDelay(5.0);
						item = true;
						break;
					}
					break;
					IL_00a0:
					ac28BD29_0.TimeDelay(2.0);
					if (Environment.TickCount - tickCount >= 60000)
					{
						text2 += "Timeout!";
						break;
					}
				}
			}
		}
		catch (Exception ex)
		{
			text2 = text2 + "Exception: " + ex.ToString() + "!";
		}
		return (item, text2);
	}

	private (bool isSuccess, string error) BB33E209(int int_1, string F5036F8D, AC28BD29 ac28BD29_0, JSON_Settings F614902C)
	{
		string text = F614902C.GetValue("id");
		bool item = false;
		string text2 = text + ": ";
		try
		{
			text = Regex.Match(text, "\\d+").Value;
			SetStatusAccount(int_1, F5036F8D + "Go to Profile " + text + "...");
			if (!FA905AA0(ac28BD29_0, int_1, F5036F8D, "fb://profile/" + text))
			{
				text2 += "Lỗi mở link!";
			}
			else
			{
				SetStatusAccount(int_1, F5036F8D + "Follow Uid...");
				string text3 = "";
				int num = 0;
				int tickCount = Environment.TickCount;
				int num2 = 60;
				while (true)
				{
					text3 = "";
					switch (ac28BD29_0.CB3C4B8A(10, ref text3, new List<string> { "//*[@content-desc='Follow']", "//*[@content-desc='Following']", "//*[@content-desc='More']" }))
					{
					case "//*[@content-desc='Follow']":
						if (num <= 2)
						{
							num++;
							ac28BD29_0.TapByXPath("//*[@content-desc='Follow']", text3);
							break;
						}
						text2 += "Fb báo lỗi khi nhấn Follow!";
						goto end_IL_0020;
					case "//*[@content-desc='More']":
						if (!ac28BD29_0.method_40(0, "//*[@content-desc=\"More\"]", text3))
						{
							break;
						}
						while (true)
						{
							Bitmap bitmap = null;
							string text4 = ac28BD29_0.method_85(10, ref bitmap, new List<string> { "dataimage\\following", "dataimage\\follow" });
							if (!(text4 == "dataimage\\following"))
							{
								if (text4 == "dataimage\\follow")
								{
									if (num <= 2)
									{
										num++;
										ac28BD29_0.BD33F0BA(text4, bitmap);
										ac28BD29_0.TimeDelay(2.0);
										if (Environment.TickCount - tickCount <= 30000)
										{
											continue;
										}
										goto IL_018d;
									}
									text2 += "Fb báo lỗi khi nhấn Follow!";
									break;
								}
								text2 += "Không hiện nút Follow!";
								break;
							}
							if (num > 0)
							{
								item = true;
							}
							text2 += "Đã follow trước đó!";
							break;
						}
						goto end_IL_0020;
					case "//*[@content-desc='Following']":
						if (num > 0)
						{
							item = true;
						}
						text2 += "Đã follow trước đó!";
						goto end_IL_0020;
					}
					goto IL_018d;
					IL_018d:
					ac28BD29_0.TimeDelay(2.0);
					if (Environment.TickCount - tickCount > num2 * 1000)
					{
						text2 += "Timeout!";
						break;
					}
				}
			}
			end_IL_0020:;
		}
		catch (Exception ex)
		{
			text2 = text2 + "Exception: " + ex.ToString() + "!";
		}
		return (item, text2);
	}

	private (bool isSuccess, string error) method_28(int D7BA6014, string string_0, AC28BD29 ac28BD29_0, JSON_Settings F995D229)
	{
		string text = F995D229.GetValue("id");
		bool flag = F995D229.AA824D29("isAnswer");
		List<string> list_ = F995D229.EC378D8A("lstCauTraLoi");
		bool item = false;
		string text2 = text + ": ";
		try
		{
			SetStatusAccount(D7BA6014, string_0 + "Go to Group " + text + "...");
			if (!FA905AA0(ac28BD29_0, D7BA6014, string_0, "fb://group/" + text))
			{
				text2 += "Lỗi mở link!";
			}
			else
			{
				SetStatusAccount(D7BA6014, string_0 + "Find Join...");
				string string_ = "";
				string text3 = "";
				for (int i = 0; i < 2; i++)
				{
					switch (ac28BD29_0.CB3C4B8A(5, ref string_, new List<string> { "//*[@content-desc=\"Cancel Request\"]", "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]", "//*[starts-with(@content-desc, 'joined')]", "//*[starts-with(@content-desc, 'Join ')]" }))
					{
					case "//*[starts-with(@content-desc, 'Join ')]":
						SetStatusAccount(D7BA6014, string_0 + "Tap Join...");
						ac28BD29_0.method_40(0, "//*[starts-with(@content-desc, 'Join ')]", string_);
						ac28BD29_0.TimeDelay(3.0);
						if (flag)
						{
							string_ = "";
							text3 = ac28BD29_0.CB3C4B8A(5, ref string_, new List<string> { "//android.view.ViewGroup[@content-desc=\"Answer Questions\"]", "//android.view.ViewGroup[@content-desc=\"Cancel Request\"]", "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]", "//android.view.ViewGroup[@content-desc=\"Submit\"]", "//*[starts-with(@content-desc,'followed')]" });
							if (text3 == "//android.view.ViewGroup[@content-desc=\"Answer Questions\"]" || text3 == "//android.view.ViewGroup[@content-desc=\"Submit\"]")
							{
								if (text3 == "//android.view.ViewGroup[@content-desc=\"Answer Questions\"]")
								{
									SetStatusAccount(D7BA6014, string_0 + "Tap Answer...");
									ac28BD29_0.method_40(0, text3, string_);
									ac28BD29_0.TimeDelay(2.0);
								}
								method_86(D7BA6014, string_0, ac28BD29_0, list_);
							}
						}
						item = true;
						goto end_IL_003d;
					case "//*[@content-desc=\"Cancel Request\"]":
						text2 += "Đã gửi yêu cầu vào nhóm trước đó!";
						goto end_IL_003d;
					case "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]":
					case "//*[starts-with(@content-desc, 'joined')]":
						text2 += "Đã là thành viên của nhóm!";
						goto end_IL_003d;
					}
					ac28BD29_0.FB3ACF2E(-1);
					ac28BD29_0.TimeDelay(1.0);
				}
			}
			end_IL_003d:;
		}
		catch (Exception ex)
		{
			text2 = text2 + "Exception: " + ex.ToString() + "!";
		}
		return (item, text2);
	}

	private void method_29(OrderDetail c387042E_0, string string_0, AC28BD29 E4BE3E94)
	{
		if (SettingsTool.GetSettings("configDebug").AA824D29("ckbJobSeeding"))
		{
			lock (BA9050A1)
			{
				string text = E4BE3E94.method_123("LogSeeding");
				File.AppendAllText("logJob.txt", "---------" + text + "---------\r\n");
				File.AppendAllText("logJob.txt", "device: " + E4BE3E94.String_1 + "\r\n");
				File.AppendAllText("logJob.txt", "filePath: CheckDevice\\" + E4BE3E94.String_1 + "\\" + text + ".png\r\n");
				File.AppendAllText("logJob.txt", "type: " + c387042E_0.CEB2DD02 + "\r\n");
				File.AppendAllText("logJob.txt", "object_id: " + c387042E_0.BF2F92AA + "\r\n");
				File.AppendAllText("logJob.txt", "error: " + string_0 + "\r\n");
			}
		}
	}

	private (bool isSuccess, string error) method_30(int int_1, string string_0, AC28BD29 EEBF3B18, JSON_Settings f72FAFBC_0)
	{
		string text = f72FAFBC_0.GetValue("id");
		bool flag = f72FAFBC_0.AA824D29("isLikePage");
		bool flag2 = f72FAFBC_0.AA824D29("isReviewPage");
		bool item = false;
		string text2 = text + ": ";
		try
		{
			if (flag)
			{
				(item, text2) = method_31(int_1, string_0, EEBF3B18, f72FAFBC_0);
			}
			if (flag2)
			{
				(item, text2) = D527C2BC(int_1, string_0, EEBF3B18, f72FAFBC_0);
			}
		}
		catch (Exception ex)
		{
			text2 = text2 + "Exception: " + ex.ToString() + "!";
		}
		return (item, text2);
	}

	private (bool isSuccess, string error) method_31(int int_1, string string_0, AC28BD29 D20C222A, JSON_Settings f72FAFBC_0)
	{
		string text = f72FAFBC_0.GetValue("id");
		bool item = false;
		string text2 = text + ": ";
		try
		{
			while (true)
			{
				SetStatusAccount(int_1, string_0 + "Go to Page " + text + "...");
				if (FA905AA0(D20C222A, int_1, string_0, "fb://" + ((!text.StartsWith("1000")) ? "page" : "profile") + "/" + text))
				{
					SetStatusAccount(int_1, string_0 + "Like Page...");
					switch (AA0BBF13(D20C222A, int_1, string_0))
					{
					case -1:
						break;
					case 1:
						item = true;
						goto end_IL_0020;
					default:
						goto end_IL_0020;
					}
					continue;
				}
				text2 += "Lỗi mở link!";
				break;
			}
			end_IL_0020:;
		}
		catch (Exception ex)
		{
			text2 = text2 + "Exception: " + ex.ToString() + "!";
		}
		return (item, text2);
	}

	private (bool isSuccess, string error) D527C2BC(int EE9EA809, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0)
	{
		string text = f72FAFBC_0.GetValue("id");
		string text2 = f72FAFBC_0.GetValue("content");
		bool item = false;
		string text3 = text + ": ";
		if (text2.Trim() == "")
		{
			text3 += "Không có nội dung!";
		}
		else
		{
			try
			{
				string string_ = "";
				while (true)
				{
					IL_005d:
					SetStatusAccount(EE9EA809, string_0 + "Go to Page " + text + "...");
					if (FA905AA0(ac28BD29_0, EE9EA809, string_0, "fb://" + ((!text.StartsWith("1000")) ? "page" : "profile") + "/" + text))
					{
						SetStatusAccount(EE9EA809, string_0 + "Review Page...");
						if (ac28BD29_0.CB3C4B8A(0, ref string_, new List<string> { "//android.widget.TextView[contains(@content-desc,\"Reviews, Tab\")]", "//*[@content-desc='Posts, tab']" }) == "" && !ac28BD29_0.TapByXPath("//android.widget.Button[@content-desc=\"Cancel\"]", string_))
						{
							continue;
						}
						int num = 0;
						int num2 = 0;
						int num3 = 0;
						string text4 = "";
						int num4 = 0;
						int num5 = 1;
						int tickCount = Environment.TickCount;
						int num6 = 120;
						while (true)
						{
							string_ = ac28BD29_0.GetPageSource();
							text4 = ac28BD29_0.FindElement(0, string_, new List<string> { "//*[contains(@content-desc,\"Reviews, Tab\")]", "//*[contains(@content-desc, \"Home\")]", "//*[@content-desc='About, tab']", "//*[@content-desc='How are ratings calculated?']", "//*[@content-desc=\"YES\"]", "//android.widget.EditText[starts-with(@text,'What')]", "//androidx.recyclerview.widget.RecyclerView/parent::*/parent::*/child::*", "//androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup" });
							string text5 = text4;
							string text6 = text5;
							uint num7 = HashString.DA8CEBAB(text6);
							if (num7 > 3483486136u)
							{
								switch (num7)
								{
								case 3976528780u:
									if (!(text6 == "//*[@content-desc='How are ratings calculated?']"))
									{
										break;
									}
									if (ac28BD29_0.DoesElementExist(0, string_, "//*[@content-desc=\"YES\"]"))
									{
										if (num2 < 2)
										{
											num2++;
											ac28BD29_0.TapByXPath("//*[@content-desc=\"YES\"]", string_);
											goto IL_03a8;
										}
										text3 += "Lỗi Click Yes!";
									}
									else
									{
										text3 += "Đã review trước đó!";
									}
									goto end_IL_0056;
								case 3660407778u:
									if (!(text6 == "//*[contains(@content-desc,\"Reviews, Tab\")]"))
									{
										break;
									}
									if (ac28BD29_0.DoesElementExist(0, string_, "//*[@content-desc=\"YES\"]"))
									{
										ac28BD29_0.TapByXPath("//*[@content-desc=\"YES\"]", string_);
										goto IL_03a8;
									}
									if (num < 2)
									{
										SetStatusAccount(EE9EA809, string_0 + "Tap " + ac28BD29_0.method_105(text4) + "...");
										num++;
										ac28BD29_0.TapByXPath(text4, string_);
										goto IL_03a8;
									}
									text3 += "Không tìm thấy nút YES!";
									goto end_IL_0056;
								case 4283911937u:
								{
									if (!(text6 == "//android.widget.EditText[starts-with(@text,'What')]"))
									{
										break;
									}
									int num8 = 0;
									while (num8 < 10)
									{
										ac28BD29_0.SendByXPath("//android.widget.EditText", text2);
										ac28BD29_0.TimeDelay(1.0);
										if (!ac28BD29_0.method_102(0, "", "must be at least 25 characters"))
										{
											if (ac28BD29_0.TapByXPath("(//androidx.viewpager.widget.ViewPager//android.view.ViewGroup)[last()]"))
											{
												break;
											}
											ac28BD29_0.TimeDelay(1.0);
											num8++;
											continue;
										}
										text3 = text3 + "Content < 25 ký tự (content: " + text2 + ")!";
										goto end_IL_0056;
									}
									goto IL_03a8;
								}
								case 4186682215u:
								{
									if (!(text6 == "//*[contains(@content-desc, \"Home\")]"))
									{
										break;
									}
									string text7 = ac28BD29_0.FindElements(0, string_, "//*[contains(@content-desc, \"Home\")]").FirstOrDefault();
									if (string.IsNullOrEmpty(text7))
									{
										goto IL_03a8;
									}
									if (num3 < 2)
									{
										num3++;
										Point point = ac28BD29_0.method_51(text7);
										ac28BD29_0.method_50(point.X + ac28BD29_0.method_14() / 2, point.Y, point.X, point.Y);
										goto IL_03a8;
									}
									text3 += "Không tìm thấy nút Review Page!";
									goto end_IL_0056;
								}
								case 4058141664u:
									if (!(text6 == "//androidx.viewpager.widget.ViewPager/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup"))
									{
										break;
									}
									item = true;
									goto end_IL_0056;
								}
								goto IL_036a;
							}
							if (num7 <= 606570513)
							{
								if (num7 != 532719482)
								{
									if (num7 != 606570513 || !(text6 == "//*[@content-desc='About, tab']"))
									{
										goto IL_036a;
									}
									ac28BD29_0.TapByXPath(text4, string_);
									ac28BD29_0.TimeDelay(3.0);
									bool flag = false;
									for (int i = 0; i < 5; i++)
									{
										if (!ac28BD29_0.BD33F0BA("dataimage\\rate") || !ac28BD29_0.method_102(30, "", "How are ratings calculated"))
										{
											if (ac28BD29_0.CE16082B(1, 1, 3000))
											{
												break;
											}
											continue;
										}
										ac28BD29_0.method_19();
										flag = true;
										break;
									}
									if (!flag)
									{
										text3 += "Không tìm thấy nút Review Page!";
										break;
									}
								}
								else
								{
									if (!(text6 == "//android.widget.ProgressBar"))
									{
										goto IL_036a;
									}
									SetStatusAccount(EE9EA809, string_0 + "Loading...");
									if (!ac28BD29_0.method_30(60))
									{
										if (num4 < num5)
										{
											num4++;
											goto IL_005d;
										}
										text3 += "Không load được trang!";
										break;
									}
								}
							}
							else if (num7 != 2535497917u)
							{
								if (num7 != 3483486136u || !(text6 == "//*[@content-desc=\"YES\"]"))
								{
									goto IL_036a;
								}
								if (num2 >= 2)
								{
									text3 += "Lỗi Click Yes!";
									break;
								}
								num2++;
								ac28BD29_0.TapByXPath("//*[@content-desc=\"YES\"]", string_);
							}
							else
							{
								if (!(text6 == "//androidx.recyclerview.widget.RecyclerView/parent::*/parent::*/child::*"))
								{
									goto IL_036a;
								}
								ac28BD29_0.E832B991(ac28BD29_0.FindElements(0, string_, text4).LastOrDefault());
							}
							goto IL_03a8;
							IL_036a:
							SetStatusAccount(EE9EA809, string_0 + "Scroll...");
							if (ac28BD29_0.CE16082B())
							{
								switch (method_22(ac28BD29_0, EE9EA809, string_0))
								{
								case 1:
									break;
								case 0:
									goto IL_03a8;
								default:
									goto end_IL_0056;
								}
								goto IL_005d;
							}
							goto IL_03a8;
							IL_03a8:
							ac28BD29_0.TimeDelay(1.0);
							if (Environment.TickCount - tickCount >= num6 * 1000)
							{
								text3 += "Timeout!";
								break;
							}
						}
						break;
					}
					text3 += "Lỗi mở link!";
					break;
				}
				end_IL_0056:;
			}
			catch (Exception ex)
			{
				text3 = text3 + "Exception: " + ex.ToString() + "!";
			}
		}
		return (item, text3);
	}

	private void CBAF278E(int int_1, string EE9E8D91, AC28BD29 A81699AA)
	{
		try
		{
			if (A81699AA.DoesElementExist(20, "", "//*[@content-desc='Get started']"))
			{
				CC1905A5(int_1, "Checkpoint", A81699AA);
				int num = 0;
				int num2 = 6;
				int num3 = 0;
				int num4 = 15;
				string text = "";
				string text2 = "";
				int tickCount = Environment.TickCount;
				do
				{
					text2 = A81699AA.GetPageSource();
					string text3 = A81699AA.FindElement(0, text2, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='Get started']", "//*[@content-desc='Next']", "//android.widget.EditText[@text='Enter new password']", "//*[@content-desc='Save changes']", "//*[@content-desc='Close']", "//*[@content-desc='Back to Facebook']" });
					string text4 = text3;
					string text5 = text4;
					uint num5 = HashString.DA8CEBAB(text5);
					if (num5 > 1259562933)
					{
						if (num5 > 1927859440)
						{
							if (num5 != 3165355182u)
							{
								if (num5 != 3880773775u || !(text5 == "//*[@content-desc='Close']"))
								{
									goto IL_0131;
								}
							}
							else if (!(text5 == "//*[@content-desc='Get started']"))
							{
								goto IL_0131;
							}
							goto IL_0163;
						}
						if (num5 != 1792698548)
						{
							if (num5 == 1927859440 && text5 == "//android.widget.EditText[@text='Enter new password']")
							{
								text = DateTime.Now.ToString("MMdd") + "unlock956" + Common.CreateRandomStringNumber(5);
								A81699AA.SendByXPath(text3, text);
								A81699AA.TimeDelay(2.0);
								A81699AA.TapByXPath("//*[@content-desc='Save changes']");
								method_114(int_1, "cPassword", text, "pass");
								goto IL_0171;
							}
						}
						else if (text5 == "//*[@content-desc='Next']")
						{
							goto IL_0163;
						}
					}
					else
					{
						if (num5 <= 532719482)
						{
							if (num5 != 281629319)
							{
								if (num5 != 532719482 || !(text5 == "//android.widget.ProgressBar"))
								{
									goto IL_0131;
								}
							}
							else
							{
								if (!(text5 == "//*[@text='Tap to retry']"))
								{
									goto IL_0131;
								}
								if (num >= num2)
								{
									return;
								}
								num++;
								A81699AA.CE16082B(-1);
							}
							goto IL_0171;
						}
						if (num5 != 785803401)
						{
							if (num5 == 1259562933 && text5 == "//*[@content-desc='Back to Facebook']")
							{
								goto IL_0163;
							}
						}
						else if (text5 == "//*[@content-desc='Save changes']")
						{
							if (text == "")
							{
								text = DateTime.Now.ToString("MMdd") + "unlock956" + Common.CreateRandomStringNumber(5);
								A81699AA.SendByXPath("//android.widget.EditText", text);
								A81699AA.TimeDelay(2.0);
								method_114(int_1, "cPassword", text, "pass");
							}
							A81699AA.TapByXPath(text3, text2);
							goto IL_0171;
						}
					}
					goto IL_0131;
					IL_0163:
					A81699AA.TapByXPath(text3, text2);
					goto IL_0171;
					IL_0131:
					if (!A81699AA.AF365B16())
					{
						if (A81699AA.CE16082B())
						{
							if (num3 >= num4)
							{
								return;
							}
							num3++;
						}
						else
						{
							num3 = 0;
						}
						goto IL_0171;
					}
					CC1905A5(int_1, "Live");
					SetStatusAccount(int_1, "Unlock checkpoint success!");
					return;
					IL_0171:
					A81699AA.TimeDelay(2.0);
				}
				while (Environment.TickCount - tickCount < 300000);
			}
			if (A81699AA.AF365B16())
			{
				CC1905A5(int_1, "Live");
				SetStatusAccount(int_1, "Account Live!");
			}
			else
			{
				SetStatusAccount(int_1, EE9E8D91 + "Unlock checkpoint fail!");
			}
		}
		catch
		{
		}
	}

	private void method_32(AC28BD29 ac28BD29_0, int int_1, string string_0)
	{
		string text = "";
		int tickCount = Environment.TickCount;
		int num = 120;
		if (!FA905AA0(ac28BD29_0, int_1, string_0, "fb://settings"))
		{
			return;
		}
		string text2 = "How people find and contact you";
		string text3 = "";
		string text4 = "";
		do
		{
			text = ac28BD29_0.GetPageSource();
			if (!ac28BD29_0.DoesElementExist(0, text, "//*[@content-desc='" + text2 + "']"))
			{
				if (ac28BD29_0.CE16082B())
				{
					break;
				}
				continue;
			}
			ac28BD29_0.TapByXPath("//*[@content-desc='" + text2 + "']", text);
			while (true)
			{
				switch (text2)
				{
				case "How people find and contact you":
				{
					string text9 = text3;
					string text10 = text9;
					if (text10 != null && text10.Length == 0)
					{
						text3 = "//*[@text='Who can send you friend requests?']";
						text4 = "[@text='Everyone']";
						break;
					}
					switch (text10)
					{
					default:
						text3 = "";
						text2 = "Posts";
						break;
					case "//*[@text='Who can look you up using the email address you provided?']":
						text3 = "//*[@text='Who can look you up using the phone number you provided?']";
						text4 = "[@text='Everyone']";
						break;
					case "//*[@text='Who can see your friends list?']":
						text3 = "//*[@text='Who can look you up using the email address you provided?']";
						text4 = "[@text='Everyone']";
						break;
					case "//*[@text='Who can send you friend requests?']":
						text3 = "//*[@text='Who can see your friends list?']";
						text4 = "[@text='Public' or starts-with(@content-desc, 'Public')]";
						break;
					}
					break;
				}
				case "Reels":
				{
					string text7 = text3;
					string text8 = text7;
					if (!(text8 == ""))
					{
						text3 = "";
						text2 = "";
					}
					else
					{
						text3 = "//*[@text='Public' or starts-with(@content-desc, 'Public')]";
						text4 = "[@text='Public' or starts-with(@content-desc, 'Public')]";
					}
					break;
				}
				case "Stories":
				{
					string text11 = text3;
					string text12 = text11;
					if (!(text12 == ""))
					{
						text3 = "";
						text2 = "Reels";
					}
					else
					{
						text3 = "//*[contains(@text,'who can see your story')]";
						text4 = "[@text='Public' or starts-with(@content-desc, 'Public')]";
					}
					break;
				}
				case "Posts":
				{
					string text5 = text3;
					string text6 = text5;
					if (!(text6 == ""))
					{
						text3 = "";
						text2 = "Stories";
					}
					else
					{
						text3 = "//*[@text='Who can see your future posts?']";
						text4 = "[@text='Public' or starts-with(@content-desc, 'Public')]";
					}
					break;
				}
				}
				if (text3 == "")
				{
					break;
				}
				if (!ac28BD29_0.C60AEB35(10, ref text, text3))
				{
					continue;
				}
				int num2 = 0;
				num2 = ((!ac28BD29_0.DoesElementExist(0, text, text3 + "/parent::*/child::*" + text4)) ? 1 : 0);
				if (num2 == 0)
				{
					num2 = ((text2 == "Reels" && ac28BD29_0.DoesElementExist(0, text, "//*" + text4)) ? 2 : 0);
				}
				if (num2 > 0)
				{
					if (num2 == 1)
					{
						ac28BD29_0.TapByXPath(text3, text);
						ac28BD29_0.TimeDelay(1.0);
					}
					ac28BD29_0.method_40(10, "//*" + text4, "");
					if (ac28BD29_0.method_40(5, "//*[@content-desc='Done' or @text='CHANGE' or @text='SAVE']", ""))
					{
						ac28BD29_0.TimeDelay(3.0);
						ac28BD29_0.method_30(10);
					}
					ac28BD29_0.method_19();
					ac28BD29_0.method_30(10);
				}
				text = "";
			}
			ac28BD29_0.method_19();
			ac28BD29_0.TimeDelay(3.0);
		}
		while (!(text2 == "") && Environment.TickCount - tickCount < num * 1000);
	}

	private void method_33(AC28BD29 D5BC958E, int E307381D, string string_0)
	{
		if (FA905AA0(D5BC958E, E307381D, string_0, "fb://faceweb/f?href=/settings/subscribe") && D5BC958E.method_43("", 10, "(//*[@text='Public'])[1]"))
		{
			D5BC958E.TimeDelay(2.0);
			D5BC958E.method_30(10);
		}
	}

	private void method_34(AC28BD29 C90D7D12, int A091930D, string string_0, string string_1, JSON_Settings EBAFAB8E)
	{
		try
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string value = "";
			string value2 = "";
			string text6 = "";
			if (!EBAFAB8E.AA824D29("ckbEmail"))
			{
				text4 = "-";
			}
			if (!EBAFAB8E.AA824D29("ckbGender"))
			{
				text3 = "-";
			}
			if (!EBAFAB8E.AA824D29("ckbBirthday"))
			{
				text2 = "-";
			}
			if (!EBAFAB8E.AA824D29("ckbGroup"))
			{
				text5 = "-";
			}
			if (!EBAFAB8E.AA824D29("ckbNgayTao"))
			{
				value = "-";
			}
			if (!EBAFAB8E.AA824D29("ckbName"))
			{
				value2 = "-";
			}
			if (!EBAFAB8E.AA824D29("ckbPhone"))
			{
				text6 = "-";
			}
			if (string.IsNullOrEmpty(text6) && FA905AA0(C90D7D12, A091930D, string_0, "fb://facewebmodal/f?href=https://mbasic.facebook.com/settings/sms/?ref_component=mbasic_bookmark&ref_page=XMenuController"))
			{
				for (int i = 0; i < 3; i++)
				{
					text = C90D7D12.GetPageSource();
					if (!C90D7D12.DoesElementExist(0, text, "//*[@text='Remove']"))
					{
						if (!C90D7D12.ED9CDB24(text, "Add a Mobile Number", "Add Number", "Add phone number"))
						{
							if (C90D7D12.CE16082B(-1))
							{
								break;
							}
							C90D7D12.TimeDelay(3.0);
							continue;
						}
						method_114(A091930D, "cPhone", text6, "phone");
						text6 = "-";
						break;
					}
					text6 = C90D7D12.method_23(text, "//*[@text='Current Phone Numbers']/following::android.widget.TextView[1]", "text").FirstOrDefault();
					if (!string.IsNullOrEmpty(text6))
					{
						method_114(A091930D, "cPhone", text6, "phone");
					}
					break;
				}
			}
			if ((string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text3) || string.IsNullOrEmpty(text4) || string.IsNullOrEmpty(text5) || string.IsNullOrEmpty(text6)) && FA905AA0(C90D7D12, A091930D, string_0, "fb://profile_edit"))
			{
				int tickCount = Environment.TickCount;
				do
				{
					text = C90D7D12.GetPageSource();
					if (C90D7D12.method_40(0, "//*[@text='Edit Your About Info']", text))
					{
						continue;
					}
					if (string.IsNullOrEmpty(text6) && C90D7D12.DoesElementExist(0, text, "//*[@text='Mobile']/preceding-sibling::*"))
					{
						text6 = C90D7D12.method_23(text, "//*[@text='Mobile']/preceding-sibling::*", "text").FirstOrDefault();
						if (!string.IsNullOrEmpty(text6))
						{
							method_114(A091930D, "cPhone", text6, "phone");
						}
					}
					if (string.IsNullOrEmpty(text4) && C90D7D12.DoesElementExist(0, text, "//*[@text='Email']/preceding-sibling::*"))
					{
						text4 = C90D7D12.method_23(text, "//*[@text='Email']/preceding-sibling::*", "text").FirstOrDefault();
						if (!string.IsNullOrEmpty(text4))
						{
							method_114(A091930D, "cEmail", text4, "email");
						}
					}
					if (string.IsNullOrEmpty(text2) && C90D7D12.DoesElementExist(0, text, "//*[@text='Birthday']/preceding-sibling::*"))
					{
						text2 = C90D7D12.method_23(text, "//*[@text='Birthday']/preceding-sibling::*", "text").FirstOrDefault();
						if (!string.IsNullOrEmpty(text2))
						{
							text2 = Common.AC063C3B(text2);
							if (text2 != "")
							{
								method_114(A091930D, "cBirthday", text2, "birthday");
							}
						}
					}
					if (string.IsNullOrEmpty(text3) && C90D7D12.DoesElementExist(0, text, "//*[@text='Gender']/preceding-sibling::*"))
					{
						text3 = C90D7D12.method_23(text, "//*[@text='Gender']/preceding-sibling::*", "text").FirstOrDefault();
						if (!string.IsNullOrEmpty(text3))
						{
							method_114(A091930D, "cGender", text3, "gender");
						}
					}
					if (string.IsNullOrEmpty(text5) && C90D7D12.DoesElementExist(0, text, "//*[@content-desc='GROUPS' or @text='GROUPS']"))
					{
						Class65 @class = Class65.smethod_0(C90D7D12.FindElements(0, text, "//*[@content-desc='GROUPS' or @text='GROUPS']").First(), C90D7D12.FindElements(0, text, "//*[@content-desc='See All']"));
						if (@class != null)
						{
							C90D7D12.E832B991(@class.AA3F9A29());
							text = "";
							if (C90D7D12.C60AEB35(30, ref text, "//*[contains(@text, 'PUBLIC')]"))
							{
								text5 = C90D7D12.method_23(text, "//*[contains(@text, 'PUBLIC')]", "text").FirstOrDefault();
								text5 = text5.Replace("public", "").Trim();
								if (!string.IsNullOrEmpty(text5))
								{
									method_114(A091930D, "cGroup", text5, "groups");
								}
							}
						}
					}
					if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text3) && !string.IsNullOrEmpty(text4) && !string.IsNullOrEmpty(text5) && !string.IsNullOrEmpty(text6))
					{
						break;
					}
				}
				while (!C90D7D12.CE16082B() && Environment.TickCount - tickCount < 90000);
			}
			if (string.IsNullOrEmpty(value) && FA905AA0(C90D7D12, A091930D, string_0, "https://m.facebook.com/your_information/list?tile=PERSONAL_INFO_GROUPING"))
			{
				text = "";
				if (C90D7D12.C60AEB35(30, ref text, "//android.widget.Button[starts-with(@text,'Your account creation date')]"))
				{
					value = C90D7D12.method_23(text, "//android.widget.Button[starts-with(@text,'Your account creation date')]", "text").FirstOrDefault();
					value = value.Replace("Your account creation date".ToLower(), "").Replace("The date you created your account".ToLower(), "").Trim();
					if (!string.IsNullOrEmpty(value))
					{
						value = Common.smethod_60(value);
						if (value != "")
						{
							method_114(A091930D, "cDateCreateAcc", value, "dateCreateAcc");
						}
					}
				}
			}
			if (!string.IsNullOrEmpty(value2) || !FA905AA0(C90D7D12, A091930D, string_0, "https://m.facebook.com/settings/account/"))
			{
				return;
			}
			text = "";
			if (!C90D7D12.C60AEB35(30, ref text, "//*[starts-with(@content-desc,'Name') or starts-with(@text,'Name')]"))
			{
				return;
			}
			value2 = C90D7D12.method_23(text, "//*[starts-with(@content-desc,'Name') or starts-with(@text,'Name')]", "content-desc").FirstOrDefault();
			if (string.IsNullOrEmpty(value2))
			{
				value2 = C90D7D12.method_23(text, "//*[starts-with(@content-desc,'Name') or starts-with(@text,'Name')]", "text").FirstOrDefault();
			}
			if (!string.IsNullOrEmpty(value2))
			{
				value2 = value2.Substring(value2.IndexOf(' ') + 1);
				value2 = string.Join(" ", from string_025 in value2.Split(' ')
					select string_025[0].ToString().ToUpper() + string_025.Substring(1));
				if (!string.IsNullOrEmpty(value2))
				{
					method_114(A091930D, "cName", value2, "name");
				}
			}
		}
		catch
		{
		}
	}

	private int CA0ECE3C(int E2945F01, string string_0, AC28BD29 F12C4E00, JSON_Settings f72FAFBC_0, string string_1, string string_2)
	{
		int f988D70A = f72FAFBC_0.method_0("nudSoLuongFrom");
		int e234B = f72FAFBC_0.method_0("nudSoLuongTo");
		bool flag = f72FAFBC_0.AA824D29("ckbTuDongXoa");
		bool flag2 = f72FAFBC_0.AA824D29("ckbAutoAddFriend");
		int minValue = f72FAFBC_0.method_0("nudSoLuongKetBanFrom");
		int num = f72FAFBC_0.method_0("nudSoLuongKetBanTo");
		int minValue2 = f72FAFBC_0.method_0("nudDelayFrom");
		int num2 = f72FAFBC_0.method_0("nudDelayTo");
		int result = 0;
		string text = string_0 + Language.GetValue("Đang") + " " + string_2 + ": ";
		SetStatusAccount(E2945F01, text + Language.GetValue("Đang chạy..."));
		try
		{
			int num3 = F12C4E00.C4B7B817(f988D70A, e234B);
			List<string> list = new List<string>();
			if (!flag)
			{
				list = F605BBA9[string_1].GetRange(0, num3);
			}
			else
			{
				lock (F605BBA9)
				{
					if (F605BBA9[string_1].Count > 0)
					{
						if (num3 > F605BBA9[string_1].Count)
						{
							num3 = F605BBA9[string_1].Count;
						}
						list = F605BBA9[string_1].GetRange(0, num3);
						F605BBA9[string_1].RemoveRange(0, num3);
					}
				}
			}
			if (list.Count > 0)
			{
				SetStatusAccount(E2945F01, text + Language.GetValue("Import danh bạ..."));
				F12C4E00.ClearDataApp("com.android.providers.contacts");
				F12C4E00.method_58("com.google.android.contacts");
				string text2 = "";
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					SetStatusAccount(E2945F01, text + $"Import danh bạ ({i + 1}/{count})...");
					text2 = SetupFolder.CB36E50E();
					F12C4E00.RunCMD("shell am start -a android.intent.action.INSERT -t vnd.android.cursor.dir/contact -e name '" + text2 + "' -e phone " + list[i].Replace(" ", ""));
					F12C4E00.TimeDelay(2.0);
					F12C4E00.method_40(5, "//*[@text='Save']", "");
				}
				try
				{
					int num4 = 0;
					int num5 = 6;
					while (true)
					{
						IL_0792:
						F12C4E00.method_18(F12C4E00.FacebookPacker + "/" + F12C4E00.FacebookPacker + ".settings.activity.SettingsActivity");
						F12C4E00.TimeDelay(3.0);
						switch (method_22(F12C4E00, E2945F01, text))
						{
						case 0:
						{
							string text3 = "";
							int tickCount = Environment.TickCount;
							do
							{
								text3 = F12C4E00.GetPageSource();
								string text4 = F12C4E00.FindElement(0, text3, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='Continuous contacts upload, off, switch']", "//*[@text='Allow']", "//*[@content-desc='Continuous contacts upload, on, switch']", "//*[@text='TURN OFF']", "//*[@text='Get started']", "//*[@text='ADD FRIEND']", "//*[@resource-id='android:id/empty']" });
								string text5 = text4;
								string text6 = text5;
								uint num6 = HashString.DA8CEBAB(text6);
								if (num6 > 1811260005)
								{
									if (num6 > 2344326954u)
									{
										if (num6 != 2566009361u)
										{
											if (num6 != 3600610036u)
											{
												if (num6 != 4131407489u || !(text6 == "//*[@text='TURN OFF']"))
												{
													goto IL_0331;
												}
											}
											else if (!(text6 == "//*[@text='Get started']"))
											{
												goto IL_0331;
											}
										}
										else if (!(text6 == "//*[@content-desc='Continuous contacts upload, on, switch']"))
										{
											goto IL_0331;
										}
										goto IL_0373;
									}
									if (num6 != 1983850854)
									{
										if (num6 == 2344326954u && text6 == "//*[@text='ADD FRIEND']")
										{
											if (!flag2)
											{
												break;
											}
											text = string_0 + Language.GetValue("Đang") + " " + string_2 + ": Kết bạn ";
											int num7 = Base.rd.Next(minValue, num + 1);
											int num8 = 0;
											for (int j = 0; j < num7 + 10; j++)
											{
												SetStatusAccount(E2945F01, text + $"({num8}/{num7}), Find Add Friend...");
												List<string> list2 = F12C4E00.FindElements(10, "", text4);
												SetStatusAccount(E2945F01, text + $"({num8}/{num7}), Find Add Friend: " + list2.Count);
												if (list2.Count == 0)
												{
													SetStatusAccount(E2945F01, text + $"({num8}/{num7}), Scroll...");
													if (F12C4E00.CE16082B())
													{
														SetStatusAccount(E2945F01, text + $"({num8}/{num7}), Can't Scroll...");
														break;
													}
													SetStatusAccount(E2945F01, text + $"({num8}/{num7}), Find Add Friend...");
													list2 = F12C4E00.FindElements(10, "", text4);
													SetStatusAccount(E2945F01, text + $"({num8}/{num7}), Find Add Friend: " + list2.Count);
													if (list2.Count == 0)
													{
														break;
													}
												}
												string text7 = list2.smethod_8();
												SetStatusAccount(E2945F01, text + $"({num8}/{num7}), Tap Add Friend...");
												if (text7 != "" && F12C4E00.E832B991(text7))
												{
													num8++;
												}
												if (num8 < num7)
												{
													SetStatusAccount(E2945F01, text + $"({num8}/{num7}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
													switch (method_22(F12C4E00, E2945F01, string_0))
													{
													case 0:
														continue;
													case 1:
														break;
													default:
														goto end_IL_027b;
													}
													goto IL_0792;
												}
												SetStatusAccount(E2945F01, text + $"({num8}/{num7}): Done!");
												break;
											}
											break;
										}
									}
									else if (text6 == "//*[@resource-id='android:id/empty']")
									{
										break;
									}
								}
								else if (num6 <= 281629319)
								{
									if (num6 != 82008644)
									{
										if (num6 == 281629319 && text6 == "//*[@text='Tap to retry']")
										{
											if (num4 < num5)
											{
												num4++;
												F12C4E00.CE16082B(-1);
												goto IL_03a3;
											}
											break;
										}
									}
									else if (text6 == "//*[@text='Allow']")
									{
										goto IL_0373;
									}
								}
								else if (num6 != 532719482)
								{
									if (num6 == 1811260005 && text6 == "//*[@content-desc='Continuous contacts upload, off, switch']")
									{
										goto IL_0373;
									}
								}
								else if (text6 == "//android.widget.ProgressBar")
								{
									SetStatusAccount(E2945F01, text + "Loading...");
									goto IL_03a3;
								}
								goto IL_0331;
								IL_0373:
								SetStatusAccount(E2945F01, text + "Tap " + F12C4E00.method_105(text4) + "...");
								F12C4E00.TapByXPath(text4, text3);
								goto IL_03a3;
								IL_0331:
								SetStatusAccount(E2945F01, text + "Scroll...");
								if (F12C4E00.CE16082B())
								{
									switch (method_22(F12C4E00, E2945F01, text))
									{
									case 0:
										goto IL_03a3;
									case 1:
										goto IL_0792;
									}
									break;
								}
								goto IL_03a3;
								IL_03a3:
								F12C4E00.TimeDelay(2.0);
							}
							while (Environment.TickCount - tickCount < 300000);
							goto end_IL_027b;
						}
						case 1:
							break;
						default:
							goto end_IL_027b;
						}
					}
					end_IL_027b:;
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return result;
	}

	private int B584D3AE(int int_1, string string_0, AC28BD29 A39F6E9B, JSON_Settings f72FAFBC_0, string A785C72C)
	{
		int result = 2;
		string text = method_117(int_1, "cPassword");
		if (text == "")
		{
			SetStatusAccount(int_1, string_0 + Language.GetValue("Không có password"));
		}
		else
		{
			string text2 = string_0 + Language.GetValue("Đang") + " " + A785C72C + ": ";
			SetStatusAccount(int_1, text2 + Language.GetValue("Đang chạy..."));
			bool flag = f72FAFBC_0.method_0("typeOnOff2FA") == 1;
			int num = f72FAFBC_0.method_0("neuDaCo2FA");
			bool flag2 = f72FAFBC_0.method_0("typeOnOff2FA") == 0;
			int num2 = 0;
			int num3 = 6;
			while (FA905AA0(A39F6E9B, int_1, text2, "fb://facewebmodal/f?href=https://m.facebook.com/security/2fac/settings/"))
			{
				string text3 = "";
				string text4 = "";
				int num4 = 0;
				int num5 = 0;
				int tickCount = Environment.TickCount;
				do
				{
					text4 = A39F6E9B.GetPageSource();
					string text5 = A39F6E9B.FindElement(0, text4, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@text='Turn off']", "//*[@text='Enter confirmation code']", "//*[@text='Enter Password']//android.widget.EditText", "//*[@text='Set up app on a different device']", "//*[@text='Two-factor authentication is on']", "//*[@text='Use authentication app']" });
					string text6 = text5;
					string text7 = text6;
					uint num6 = HashString.DA8CEBAB(text7);
					if (num6 > 1211399273)
					{
						if (num6 <= 1630274194)
						{
							if (num6 != 1501499670)
							{
								if (num6 == 1630274194 && text7 == "//*[@text='Two-factor authentication is on']")
								{
									if (flag)
									{
										if (text3 != "")
										{
											method_114(int_1, "cFa2", text3, "fa2");
											result = 1;
											break;
										}
										if (num == 0)
										{
											result = 4;
											break;
										}
										if (num == 1 && A39F6E9B.DoesElementExist(0, text4, "//*[@content-desc='Add a new app']"))
										{
											A39F6E9B.TapByXPath("//*[@content-desc='Add a new app']", text4);
										}
										else if (num == 2 && A39F6E9B.DoesElementExist(0, text4, "//*[@text='Turn off']"))
										{
											A39F6E9B.TapByXPath("//*[@text='Turn off']", text4);
										}
										else
										{
											A39F6E9B.TapByXPath("//*[@text='Authentication app']", text4);
										}
									}
									else if (flag2)
									{
										A39F6E9B.TapByXPath("//*[@text='Turn off']", text4);
									}
									goto IL_0407;
								}
							}
							else if (text7 == "//*[@content-desc='Add a new app']")
							{
								goto IL_01da;
							}
							goto IL_033e;
						}
						if (num6 != 2049668434)
						{
							if (num6 != 2305529162u)
							{
								if (num6 != 2497398125u || !(text7 == "//*[@text='Enter confirmation code']"))
								{
									goto IL_033e;
								}
								if (A39F6E9B.ED9CDB24(text4, "This code isn't right. Please try again"))
								{
									num4++;
									if (num4 > num5)
									{
										result = 5;
										break;
									}
								}
								string string_ = Common.GetTotp(text3);
								A39F6E9B.SendByXPath("//android.widget.EditText", string_);
								A39F6E9B.TimeDelay(1.0);
								A39F6E9B.B2016D94(AC28BD29.DB353F82.E22EE10E);
								A39F6E9B.TimeDelay(2.0);
								A39F6E9B.B2016D94(AC28BD29.DB353F82.E22EE10E);
							}
							else
							{
								if (!(text7 == "//*[@text='Enter Password']//android.widget.EditText"))
								{
									goto IL_033e;
								}
								if (A39F6E9B.ED9CDB24(text4, "The password you entered was incorrect"))
								{
									result = 3;
									break;
								}
								A39F6E9B.SendByXPath(text5, text);
								A39F6E9B.TimeDelay(2.0);
								A39F6E9B.method_40(3, "//*[@text='Continue']", "");
							}
						}
						else
						{
							if (!(text7 == "//*[@text='Set up app on a different device']"))
							{
								goto IL_033e;
							}
							text3 = Regex.Match(text4, "secret%3D(.*?)%").Groups[1].Value;
							if (text3 == "")
							{
								text3 = A39F6E9B.method_23(text4, "//*[@text='Or enter this code into your authentication app']/parent::*/child::*[last()]", "text").FirstOrDefault();
								if (text3 == null)
								{
									text3 = "";
								}
							}
							if (!(text3 != ""))
							{
								goto IL_057f;
							}
							A39F6E9B.FB3ACF2E(1, 2);
							A39F6E9B.method_40(3, "//*[@text='Continue']", "");
						}
					}
					else
					{
						if (num6 > 532719482)
						{
							if (num6 != 954530049)
							{
								if (num6 == 1211399273 && text7 == "//*[@text='Use authentication app']")
								{
									goto IL_01da;
								}
							}
							else if (text7 == "//*[@text='Turn off']")
							{
								goto IL_01da;
							}
							goto IL_033e;
						}
						if (num6 != 281629319)
						{
							if (num6 != 532719482 || !(text7 == "//android.widget.ProgressBar"))
							{
								goto IL_033e;
							}
							SetStatusAccount(int_1, text2 + "Loading...");
						}
						else
						{
							if (!(text7 == "//*[@text='Tap to retry']"))
							{
								goto IL_033e;
							}
							if (num2 >= num3)
							{
								break;
							}
							num2++;
							A39F6E9B.CE16082B(-1);
						}
					}
					goto IL_0407;
					IL_0407:
					A39F6E9B.TimeDelay(2.0);
					continue;
					IL_01da:
					if (!(text5 == "//*[@text='Use authentication app']" && flag2))
					{
						SetStatusAccount(int_1, text2 + "Tap " + A39F6E9B.method_105(text5) + "...");
						A39F6E9B.TapByXPath(text5, text4);
						goto IL_0407;
					}
					method_114(int_1, "cFa2", "", "fa2");
					result = 6;
					break;
					IL_033e:
					SetStatusAccount(int_1, text2 + "Scroll...");
					if (A39F6E9B.CE16082B())
					{
						switch (method_22(A39F6E9B, int_1, text2))
						{
						case 0:
							break;
						case 1:
							goto IL_057f;
						default:
							goto IL_05d4;
						}
					}
					goto IL_0407;
				}
				while (Environment.TickCount - tickCount < 300000);
				break;
				IL_057f:;
			}
		}
		goto IL_05d4;
		IL_05d4:
		return result;
	}

	private int method_35(ref int DBBE2E91, ref int int_1, ref int FD0C7203, int int_2, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_1, string string_2)
	{
		string text = method_117(int_2, "cPassword");
		if (text == "")
		{
			DBBE2E91 = 8;
		}
		else
		{
			method_117(int_2, "cId");
			string text2 = string_0 + Language.GetValue("Đang") + " " + string_2 + ": ";
			SetStatusAccount(int_2, text2 + Language.GetValue("Đang chạy..."));
			bool flag = f72FAFBC_0.AA824D29("ckbAddMail");
			int num = f72FAFBC_0.method_0("typeAddMail");
			int num2 = f72FAFBC_0.method_0("typeMail");
			List<string> list = f72FAFBC_0.EC378D8A("lstMailDomain");
			if (num2 != 1 || list.Count != 0)
			{
				string text3 = "";
				if (list.Count > 0)
				{
					text3 = list.OrderBy((string string_0) => Guid.NewGuid()).First();
				}
				List<string> list2 = f72FAFBC_0.EC378D8A("lstDomain");
				if (num2 != 2 || list2.Count != 0)
				{
					string string_3 = "";
					if (list2.Count > 0)
					{
						string_3 = list2.OrderBy((string string_0) => Guid.NewGuid()).First();
					}
					bool flag2 = flag && f72FAFBC_0.AA824D29("ckbSetPrimaryMail");
					bool flag3 = f72FAFBC_0.AA824D29("ckbRemoveMail");
					while (true)
					{
						IL_13aa:
						if (flag3)
						{
							FD0C7203 = 2;
							string text4 = "";
							int num3 = 0;
							int num4 = 6;
							while (FA905AA0(ac28BD29_0, int_2, text2, "fb://notification_settings_email"))
							{
								int num5 = 0;
								int tickCount = Environment.TickCount;
								while (true)
								{
									text4 = ac28BD29_0.GetPageSource();
									string text5 = ac28BD29_0.FindElement(0, text4, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='menu']", "//*[@text='Remove']", "//*[@text='YES']", "//*[@content-desc='+ ADD EMAIL']" });
									switch (text5)
									{
									case "//*[@text='Remove']":
									case "//*[@text='YES']":
										SetStatusAccount(int_2, text2 + "Tap " + ac28BD29_0.method_105(text5) + "...");
										ac28BD29_0.TapByXPath(text5, text4);
										goto IL_10d2;
									default:
										SetStatusAccount(int_2, text2 + "Scroll...");
										if (ac28BD29_0.CE16082B())
										{
											int num6 = method_22(ac28BD29_0, int_2, text2);
											if (num6 == 1)
											{
												goto IL_1388;
											}
											if (num6 != 0)
											{
												goto IL_13e2;
											}
											List<string> list3 = ac28BD29_0.method_104();
											if (list3.Count == 2 && list3.Contains("back") && string.Join("|", list3).Contains("email"))
											{
												ac28BD29_0.method_19();
												goto IL_1388;
											}
										}
										goto IL_10d2;
									case "//*[@text='Tap to retry']":
										if (num3 < num4)
										{
											num3++;
											ac28BD29_0.CE16082B(-1);
											goto IL_10d2;
										}
										goto IL_13e2;
									case "//android.widget.ProgressBar":
										SetStatusAccount(int_2, text2 + "Loading...");
										if (!ac28BD29_0.method_30(15))
										{
											ac28BD29_0.method_19();
										}
										goto IL_10d2;
									case "//*[@content-desc='menu']":
										if (num5 == ac28BD29_0.FindElements(0, text4, text5).Count)
										{
											SetStatusAccount(int_2, text2 + "Tap " + ac28BD29_0.method_105(text5) + "...");
											ac28BD29_0.TapByXPath(text5, text4);
											ac28BD29_0.TimeDelay(1.0);
											ac28BD29_0.method_40(10, "//*[@text='Make primary']", "");
										}
										else
										{
											num5 = ac28BD29_0.FindElements(0, text4, text5).Count;
											SetStatusAccount(int_2, text2 + "Tap " + ac28BD29_0.method_105(text5) + "...");
											ac28BD29_0.TapByXPath(text5, text4);
										}
										goto IL_10d2;
									case "//*[@content-desc='+ ADD EMAIL']":
										{
											FD0C7203 = 1;
											break;
										}
										IL_10d2:
										ac28BD29_0.TimeDelay(2.0);
										if (Environment.TickCount - tickCount < 600000)
										{
											continue;
										}
										break;
									}
									break;
								}
								goto IL_019f;
								IL_1388:;
							}
							break;
						}
						goto IL_019f;
						IL_019f:
						if (!flag || int_1 == 1)
						{
							break;
						}
						DBBE2E91 = 2;
						string text6 = "";
						string text7 = "";
						string text8 = "";
						bool flag4 = false;
						int num7 = 0;
						int num8 = 2;
						int num9 = 0;
						int num10 = 6;
						if (num == 0)
						{
							while (true)
							{
								IL_0841:
								text6 = "";
								if (!FA905AA0(ac28BD29_0, int_2, text2, "https://m.facebook.com/settings/email/add"))
								{
									break;
								}
								int tickCount2 = Environment.TickCount;
								do
								{
									text8 = ac28BD29_0.GetPageSource();
									string text9 = ac28BD29_0.FindElement(0, text8, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//android.widget.Button[@text='Add Email']", "//*[@text='Confirm Email Address' or @content-desc='Confirm Email Address']", "//*[@text='Enter Confirmation Code']", "//*[@content-desc='Next']", "//*[@text='Make primary']", "//*[contains(@text,'please re-enter your password')]/parent::*//android.widget.EditText" });
									switch (text9)
									{
									case "//android.widget.Button[@text='Add Email']":
										break;
									default:
										goto IL_047e;
									case "//*[@text='Tap to retry']":
										goto IL_050d;
									case "//android.widget.ProgressBar":
										goto IL_0531;
									case "//*[contains(@text,'please re-enter your password')]/parent::*//android.widget.EditText":
										goto IL_056e;
									case "//*[@text='Enter Confirmation Code']":
										goto IL_05c2;
									case "//*[@text='Confirm Email Address' or @content-desc='Confirm Email Address']":
										goto IL_0768;
									}
									if (!(text6 != ""))
									{
										switch (num2)
										{
										case 0:
											lock (dictionary_6)
											{
												while (text6 == "")
												{
													if (dictionary_6[string_1].Count != 0)
													{
														int index = random_0.Next(0, dictionary_6[string_1].Count);
														string[] array = dictionary_6[string_1][index].Split('|');
														if (array.Length > 1)
														{
															text6 = array[0].Trim().ToLower();
															text7 = array[1].Trim();
														}
														dictionary_6[string_1].RemoveAt(index);
														continue;
													}
													DBBE2E91 = 7;
													goto end_IL_020f;
												}
											}
											goto default;
										case 1:
											text6 = Common.A8AF5A8E((from B69BDF21 in SetupFolder.smethod_3()
												orderby Guid.NewGuid()
												select B69BDF21).First() + (from E42F0EAC in SetupFolder.F68AD388()
												orderby Guid.NewGuid()
												select E42F0EAC).First()).Replace(" ", "").ToLower() + Common.CreateRandomNumber(6) + Regex.Match(text3, "@\\w+.\\w+").Value;
											goto default;
										case 2:
											text6 = new GeneratorEmail
											{
												string_1 = string_3
											}.E28B883B();
											goto default;
										default:
											{
												ac28BD29_0.SendByXPath("//android.widget.EditText", text6);
												ac28BD29_0.TimeDelay(1.0);
												ac28BD29_0.SendByXPath("//*[contains(@text,'please enter your Facebook password')]/parent::*//android.widget.EditText", text);
												ac28BD29_0.TimeDelay(1.0);
												ac28BD29_0.TapByXPath(text9, text8);
												goto IL_0400;
											}
											end_IL_020f:
											break;
										}
										break;
									}
									goto IL_0400;
									IL_0768:
									SetStatusAccount(int_2, text2 + "Tap " + ac28BD29_0.method_105(text9) + "...");
									ac28BD29_0.TapByXPath(text9, text8);
									goto IL_0400;
									IL_05c2:
									string text10;
									if (ac28BD29_0.DoesElementExist(0, text8, "//*[@text='Confirm']/parent::*/parent::*//android.widget.EditText"))
									{
										while (true)
										{
											SetStatusAccount(int_2, text2 + "Get otp...");
											text10 = "";
											switch (num2)
											{
											case 2:
												text10 = new GeneratorEmail(text6).method_0(0, 120);
												break;
											case 1:
												text10 = EmailHelper.D8097D8F(0, text3, text6);
												break;
											case 0:
												text10 = ImapHelper.GetOtpFromMail(0, text6, text7, 60, "", "");
												if (text10 == "")
												{
													text10 = EmailHelper.smethod_2("https://volamtuan.pro", 0, text6, text7);
												}
												break;
											}
											if (text10 == "not connect" || text10 == "fail")
											{
												break;
											}
											text10 = Regex.Match(text10, "c=(.*?)&").Groups[1].Value;
											if (!(text10 == ""))
											{
												goto IL_06fc;
											}
											if (num7 < num8)
											{
												num7++;
												ac28BD29_0.TapByXPath("//*[@text='Resend confirmation email']", text8);
												continue;
											}
											goto IL_13bb;
										}
										DBBE2E91 = 5;
										break;
									}
									if (!ac28BD29_0.DoesElementExist(0, text8, "//*[contains(@text,'profile picture')]"))
									{
										goto IL_0400;
									}
									goto IL_0865;
									IL_0531:
									SetStatusAccount(int_2, text2 + "Loading...");
									if (!ac28BD29_0.method_30(15))
									{
										ac28BD29_0.method_19();
									}
									goto IL_0400;
									IL_13bb:
									DBBE2E91 = 4;
									break;
									IL_06fc:
									SetStatusAccount(int_2, text2 + "Get otp: " + text10);
									ac28BD29_0.SendByXPath("//*[@text='Confirm']/parent::*/parent::*//android.widget.EditText", text10);
									ac28BD29_0.TimeDelay(1.0);
									ac28BD29_0.TapByXPath("//*[@text='Confirm']", text8);
									flag4 = true;
									goto IL_0400;
									IL_0400:
									ac28BD29_0.TimeDelay(2.0);
									continue;
									IL_050d:
									if (num9 >= num10)
									{
										break;
									}
									num9++;
									ac28BD29_0.CE16082B(-1);
									goto IL_0400;
									IL_056e:
									if (!ac28BD29_0.ED9CDB24(text8, "The password you entered was incorrect"))
									{
										ac28BD29_0.SendByXPath("//android.widget.EditText", text);
										ac28BD29_0.TimeDelay(1.0);
										ac28BD29_0.TapByXPath("//*[@text='Continue']", text8);
										goto IL_0400;
									}
									DBBE2E91 = 3;
									break;
									IL_047e:
									SetStatusAccount(int_2, text2 + "Scroll...");
									if (ac28BD29_0.CE16082B())
									{
										int num11 = method_22(ac28BD29_0, int_2, text2);
										if (num11 == 1)
										{
											goto IL_0841;
										}
										if (num11 != 0)
										{
											break;
										}
										List<string> list4 = ac28BD29_0.method_104();
										if (list4.Count == 2 && list4.Contains("back") && string.Join("|", list4).Contains("email"))
										{
											ac28BD29_0.method_19();
											goto IL_0841;
										}
									}
									goto IL_0400;
								}
								while (Environment.TickCount - tickCount2 < 600000);
								break;
							}
							break;
						}
						while (FA905AA0(ac28BD29_0, int_2, text2, "fb://notification_settings_email"))
						{
							int tickCount3 = Environment.TickCount;
							do
							{
								text8 = ac28BD29_0.GetPageSource();
								string text11 = ac28BD29_0.FindElement(0, text8, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='+ ADD EMAIL']", "//android.widget.EditText[@text='Enter your email']", "//*[@text='Confirm Email']", "//*[@content-desc='Next']", "//*[@text='Make primary']" });
								string text12 = text11;
								string text13 = text12;
								uint num12 = HashString.DA8CEBAB(text13);
								if (num12 > 490657884)
								{
									if (num12 <= 1753447723)
									{
										switch (num12)
										{
										case 1753447723u:
											if (!(text13 == "//*[@text='Make primary']"))
											{
												break;
											}
											SetStatusAccount(int_2, text2 + "Tap " + ac28BD29_0.method_105(text11) + "...");
											ac28BD29_0.TapByXPath(text11, text8);
											int_1 = 1;
											goto IL_0bda;
										case 532719482u:
											if (!(text13 == "//android.widget.ProgressBar"))
											{
												break;
											}
											SetStatusAccount(int_2, text2 + "Loading...");
											if (!ac28BD29_0.method_30(15))
											{
												ac28BD29_0.method_19();
											}
											goto IL_0bda;
										}
										goto IL_0a08;
									}
									if (num12 != 1792698548)
									{
										if (num12 != 3616337277u || !(text13 == "//*[@content-desc='+ ADD EMAIL']"))
										{
											goto IL_0a08;
										}
									}
									else if (!(text13 == "//*[@content-desc='Next']"))
									{
										goto IL_0a08;
									}
									if (flag4)
									{
										DBBE2E91 = 1;
										method_114(int_2, "cEmail", text6, "email");
										method_114(int_2, "cPassMail", text7, "passmail");
										if (!flag2)
										{
											break;
										}
										if (int_1 == 1)
										{
											goto IL_13aa;
										}
										int_1 = 2;
										if (text11 != "//*[@content-desc='+ ADD EMAIL']")
										{
											goto IL_105f;
										}
										if (!ac28BD29_0.DoesElementExist(0, text8, "//*[@content-desc='menu']"))
										{
											int_1 = 1;
											FD0C7203 = 1;
											break;
										}
										ac28BD29_0.TapByXPath("//*[@content-desc='menu']", text8);
									}
									else
									{
										SetStatusAccount(int_2, text2 + "Tap " + ac28BD29_0.method_105(text11) + "...");
										ac28BD29_0.TapByXPath(text11, text8);
										if (text11 == "//*[@content-desc='Next']")
										{
											string value = "";
											for (int i = 0; i < 3; i++)
											{
												ac28BD29_0.TimeDelay(2.0);
												value = ac28BD29_0.method_23("", "//android.widget.EditText", "text").FirstOrDefault();
												if (string.IsNullOrEmpty(value))
												{
													break;
												}
											}
											if (!string.IsNullOrEmpty(value))
											{
												ac28BD29_0.method_31("//android.widget.EditText");
												text6 = "";
											}
										}
									}
								}
								else if (num12 != 130929265)
								{
									if (num12 != 281629319)
									{
										if (num12 != 490657884 || !(text13 == "//android.widget.EditText[@text='Enter your email']"))
										{
											goto IL_0a08;
										}
										if (num2 == 0)
										{
											lock (dictionary_6)
											{
												while (text6 == "")
												{
													if (dictionary_6[string_1].Count != 0)
													{
														int index2 = random_0.Next(0, dictionary_6[string_1].Count);
														string[] array2 = dictionary_6[string_1][index2].Split('|');
														if (array2.Length > 1)
														{
															text6 = array2[0].Trim().ToLower();
															text7 = array2[1].Trim();
														}
														dictionary_6[string_1].RemoveAt(index2);
														continue;
													}
													DBBE2E91 = 7;
													goto IL_13e2;
												}
											}
										}
										else
										{
											text6 = Common.A8AF5A8E((from string_09 in SetupFolder.smethod_3()
												orderby Guid.NewGuid()
												select string_09).First() + (from FBA2A02E in SetupFolder.F68AD388()
												orderby Guid.NewGuid()
												select FBA2A02E).First()).Replace(" ", "").ToLower() + Common.CreateRandomNumber(6) + Regex.Match(text3, "@\\w+.\\w+").Value;
										}
										ac28BD29_0.SendByXPath(text11, text6);
										ac28BD29_0.TimeDelay(1.0);
										ac28BD29_0.TapByXPath("//*[@content-desc='NEXT']", text8);
									}
									else
									{
										if (!(text13 == "//*[@text='Tap to retry']"))
										{
											goto IL_0a08;
										}
										if (num9 >= num10)
										{
											break;
										}
										num9++;
										ac28BD29_0.CE16082B(-1);
									}
								}
								else
								{
									if (!(text13 == "//*[@text='Confirm Email']"))
									{
										goto IL_0a08;
									}
									if (ac28BD29_0.DoesElementExist(0, text8, "//android.widget.EditText[@text='Confirmation Code']"))
									{
										SetStatusAccount(int_2, text2 + "Get otp...");
										string text14 = "";
										switch (num2)
										{
										case 0:
											text14 = ImapHelper.GetOtpFromMail(0, text6, text7, 60, "", "");
											if (text14 == "")
											{
												text14 = EmailHelper.smethod_2("https://volamtuan.pro", 0, text6, text7);
											}
											break;
										case 1:
											text14 = EmailHelper.D8097D8F(0, text3, text6);
											break;
										case 2:
											text14 = new GeneratorEmail(text6).method_0(0, 120);
											break;
										}
										if (text14 == "not connect" || text14 == "fail")
										{
											DBBE2E91 = 5;
											break;
										}
										text14 = Regex.Match(text14, "c=(.*?)&").Groups[1].Value;
										if (text14 == "")
										{
											DBBE2E91 = 4;
											break;
										}
										SetStatusAccount(int_2, text2 + "Get otp: " + text14);
										ac28BD29_0.SendByXPath("//android.widget.EditText[@text='Confirmation Code']", text14);
										ac28BD29_0.TimeDelay(1.0);
										ac28BD29_0.TapByXPath("//*[@content-desc='CONFIRM']", text8);
										flag4 = true;
									}
									else if (!string.IsNullOrEmpty(ac28BD29_0.method_23(text8, "//android.widget.EditText", "text").FirstOrDefault()))
									{
										if (num7 >= num8)
										{
											DBBE2E91 = 4;
											break;
										}
										num7++;
										ac28BD29_0.method_31("//android.widget.EditText");
									}
								}
								goto IL_0bda;
								IL_0a08:
								SetStatusAccount(int_2, text2 + "Scroll...");
								if (ac28BD29_0.CE16082B())
								{
									switch (method_22(ac28BD29_0, int_2, text2))
									{
									case 0:
										break;
									case 1:
										goto IL_105f;
									default:
										goto IL_13e2;
									}
									List<string> list5 = ac28BD29_0.method_104();
									if (list5.Count == 2 && list5.Contains("back") && string.Join("|", list5).Contains("email"))
									{
										ac28BD29_0.method_19();
									}
								}
								goto IL_0bda;
								IL_0bda:
								ac28BD29_0.TimeDelay(2.0);
							}
							while (Environment.TickCount - tickCount3 < 600000);
							break;
							IL_105f:;
						}
						break;
						IL_0865:
						DBBE2E91 = 1;
						method_114(int_2, "cEmail", text6, "email");
						method_114(int_2, "cPassMail", text7, "passmail");
						if (!flag2)
						{
							break;
						}
						int_1 = 2;
						if (!FA905AA0(ac28BD29_0, int_2, text2, "fb://notification_settings_email"))
						{
							break;
						}
						if (ac28BD29_0.method_40(10, "//*[@content-desc='menu']", "") && ac28BD29_0.method_40(10, "//*[@text='Make primary']", ""))
						{
							ac28BD29_0.method_54(2.0, 3.0);
							int_1 = 1;
							continue;
						}
						int_1 = 1;
						FD0C7203 = 1;
						break;
					}
				}
			}
		}
		goto IL_13e2;
		IL_13e2:
		return 0;
	}

	private int D0AFB48D(ref int A08FDD0B, int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_1, string string_2)
	{
		method_117(int_1, "cId");
		string string_3 = ac28BD29_0.method_78();
		string text = string_0 + Language.GetValue("Đang") + " " + string_2 + ": ";
		SetStatusAccount(int_1, text + Language.GetValue("Đang chạy..."));
		int num = f72FAFBC_0.method_0("typeMail");
		List<string> list = f72FAFBC_0.EC378D8A("lstMailDomain");
		if (num != 1 || list.Count != 0)
		{
			string text2 = list.OrderBy((string AE01582B) => Guid.NewGuid()).First();
			A08FDD0B = 2;
			string text3 = "";
			string text4 = "";
			string text5 = "";
			int num2 = 0;
			int num3 = 2;
			int num4 = 0;
			int num5 = 6;
			while (true)
			{
				IL_08a7:
				int tickCount = Environment.TickCount;
				do
				{
					text5 = ac28BD29_0.GetPageSource();
					string text6 = ac28BD29_0.FindElement(0, text5, new List<string>
					{
						"//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='Confirm by email']", "//android.widget.EditText[@text='Email address']", "//android.widget.EditText[@text='Confirmation code']", "//android.widget.TextView[@text='save your login info']", "//*[@content-desc='skip' or @text='skip']", "//android.view.ViewGroup[@content-desc=\"Continue in English (US)\"]", "//android.view.ViewGroup[@content-desc=\"Allow\"]", "//com.android.packageinstaller,id/do_not_ask_checkbox",
						"//android.widget.Button[@text=\"NEVER\"]", "//*[@text='No thanks']", "//*[@content-desc='I ACCEPT']", "//*[@content-desc='Allow all cookies']", "//*[@content-desc='deny' or @text='deny']"
					});
					string text7 = text6;
					string text8 = text7;
					uint num6 = HashString.DA8CEBAB(text8);
					if (num6 > 689557640)
					{
						if (num6 <= 2879920751u)
						{
							if (num6 > 1378667548)
							{
								if (num6 != 2698810085u)
								{
									if (num6 == 2879920751u && text8 == "//android.widget.TextView[@text='save your login info']")
									{
										ac28BD29_0.TapByXPath("//android.widget.Button[@text='OK']", text5);
										goto IL_065e;
									}
								}
								else if (text8 == "//*[@text='No thanks']")
								{
									goto IL_064f;
								}
								goto IL_05c1;
							}
							if (num6 != 728177876)
							{
								if (num6 != 1378667548 || !(text8 == "//android.view.ViewGroup[@content-desc=\"Continue in English (US)\"]"))
								{
									goto IL_05c1;
								}
							}
							else if (!(text8 == "//com.android.packageinstaller:id/do_not_ask_checkbox"))
							{
								goto IL_05c1;
							}
						}
						else
						{
							if (num6 <= 3691564067u)
							{
								if (num6 != 3056511029u)
								{
									if (num6 != 3691564067u || !(text8 == "//android.widget.EditText[@text='Email address']"))
									{
										goto IL_05c1;
									}
									if (num == 0)
									{
										lock (dictionary_7)
										{
											while (text3 == "")
											{
												if (dictionary_7[string_1].Count != 0)
												{
													int index = random_0.Next(0, dictionary_7[string_1].Count);
													string[] array = dictionary_7[string_1][index].Split('|');
													if (array.Length > 1)
													{
														text3 = array[0].Trim().ToLower();
														text4 = array[1].Trim();
													}
													dictionary_7[string_1].RemoveAt(index);
													continue;
												}
												A08FDD0B = 7;
												goto IL_08f7;
											}
										}
									}
									else
									{
										text3 = Common.A8AF5A8E((from string_01 in SetupFolder.smethod_3()
											orderby Guid.NewGuid()
											select string_01).First() + (from FC8B84A9 in SetupFolder.F68AD388()
											orderby Guid.NewGuid()
											select FC8B84A9).First()).Replace(" ", "").ToLower() + Common.CreateRandomNumber(6) + Regex.Match(text2, "@\\w+.\\w+").Value;
									}
									ac28BD29_0.SendByXPath(text6, text3);
									ac28BD29_0.TimeDelay(1.0);
									string a28409BD = ac28BD29_0.FindElement(0, text5, new List<string> { "//*[@text='Continue']", "//*[@text='Update email address']" });
									ac28BD29_0.TapByXPath(a28409BD, text5);
								}
								else
								{
									if (!(text8 == "//android.widget.EditText[@text='Confirmation code']"))
									{
										goto IL_05c1;
									}
									if (ac28BD29_0.DoesElementExist(0, text5, "//android.widget.EditText[@text='Confirmation Code']"))
									{
										SetStatusAccount(int_1, text + "Get otp...");
										string text9 = "";
										int num7 = 0;
										while (num7 < 3)
										{
											if (!EA98BF20.CheckLiveWall(string_3).StartsWith("0|"))
											{
												switch (num)
												{
												case 0:
													text9 = ImapHelper.GetOtpFromMail(0, text3, text4, 60, "", "");
													if (text9 == "")
													{
														text9 = EmailHelper.smethod_2("https://volamtuan.pro", 0, text3, text4);
													}
													break;
												case 1:
													text9 = EmailHelper.D8097D8F(0, text2, text3);
													break;
												case 2:
													text9 = new GeneratorEmail(text3).method_0(0, 120);
													break;
												}
												if (!(text9 == "not connect") && !(text9 == "fail"))
												{
													if (text9 != "")
													{
														break;
													}
													num7++;
													continue;
												}
												goto IL_08b8;
											}
											goto IL_08bd;
										}
										text9 = Regex.Match(text9, "c=(.*?)&").Groups[1].Value;
										if (text9 == "")
										{
											A08FDD0B = 4;
											break;
										}
										SetStatusAccount(int_1, text + "Get otp: " + text9);
										ac28BD29_0.SendByXPath(text6, text9);
										ac28BD29_0.TimeDelay(1.0);
										ac28BD29_0.TapByXPath("//*[@text='Confirm']", text5);
									}
									else if (!string.IsNullOrEmpty(ac28BD29_0.method_23(text5, "//android.widget.EditText", "text").FirstOrDefault()))
									{
										if (num2 >= num3)
										{
											A08FDD0B = 4;
											break;
										}
										num2++;
										ac28BD29_0.method_31("//android.widget.EditText");
									}
								}
								goto IL_065e;
							}
							if (num6 != 3919975960u)
							{
								if (num6 != 4002761936u || !(text8 == "//*[@content-desc='skip' or @text='skip']"))
								{
									goto IL_05c1;
								}
							}
							else if (!(text8 == "//*[@content-desc='I ACCEPT']"))
							{
								goto IL_05c1;
							}
						}
					}
					else
					{
						if (num6 <= 281629319)
						{
							if (num6 != 14426572)
							{
								if (num6 != 38614762)
								{
									if (num6 == 281629319 && text8 == "//*[@text='Tap to retry']")
									{
										if (num4 >= num5)
										{
											break;
										}
										num4++;
										ac28BD29_0.CE16082B(-1);
										goto IL_065e;
									}
								}
								else if (text8 == "//android.view.ViewGroup[@content-desc=\"Allow\"]")
								{
									goto IL_064f;
								}
							}
							else if (text8 == "//*[@content-desc='deny' or @text='deny']")
							{
								goto IL_064f;
							}
							goto IL_05c1;
						}
						if (num6 > 454760892)
						{
							if (num6 != 532719482)
							{
								if (num6 != 689557640 || !(text8 == "//*[@content-desc='Confirm by email']"))
								{
									goto IL_05c1;
								}
								ac28BD29_0.TapByXPath(text6, text5);
							}
							else
							{
								if (!(text8 == "//android.widget.ProgressBar"))
								{
									goto IL_05c1;
								}
								SetStatusAccount(int_1, text + "Loading...");
							}
							goto IL_065e;
						}
						if (num6 != 300361078)
						{
							if (num6 != 454760892 || !(text8 == "//android.widget.Button[@text=\"NEVER\"]"))
							{
								goto IL_05c1;
							}
						}
						else if (!(text8 == "//*[@content-desc='Allow all cookies']"))
						{
							goto IL_05c1;
						}
					}
					goto IL_064f;
					IL_08bd:
					A08FDD0B = 8;
					break;
					IL_08b8:
					A08FDD0B = 5;
					break;
					IL_065e:
					ac28BD29_0.TimeDelay(2.0);
					continue;
					IL_064f:
					ac28BD29_0.TapByXPath(text6, text5);
					goto IL_065e;
					IL_05c1:
					if (!EA98BF20.CheckLiveWall(string_3).StartsWith("0|"))
					{
						if (ac28BD29_0.ED9CDB24(text5, "Something\u00a0went\u00a0wrong. Please\u00a0try\u00a0again"))
						{
							ac28BD29_0.method_31("//android.widget.EditText");
						}
						else
						{
							if (ac28BD29_0.AF365B16(text5))
							{
								A08FDD0B = 1;
								method_114(int_1, "cEmail", text3, "email");
								method_114(int_1, "cPassMail", text4, "passmail");
								break;
							}
							SetStatusAccount(int_1, text + "Scroll...");
							if (ac28BD29_0.CE16082B())
							{
								int num8 = method_22(ac28BD29_0, int_1, text);
								if (num8 == 1)
								{
									goto IL_08a7;
								}
								if (num8 != 0)
								{
									break;
								}
							}
						}
						goto IL_065e;
					}
					A08FDD0B = 8;
					break;
				}
				while (Environment.TickCount - tickCount < 600000);
				break;
			}
		}
		goto IL_08f7;
		IL_08f7:
		return 0;
	}

	private int CD8C43A7(int int_1, string string_0, AC28BD29 ac28BD29_0, string string_1)
	{
		string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
		SetStatusAccount(int_1, text + Language.GetValue("Đang chạy..."));
		bool flag = false;
		try
		{
			if (FA905AA0(ac28BD29_0, int_1, text, "fb://facewebmodal/f?href=https://mbasic.facebook.com/settings/security_login/sessions/"))
			{
				int num = 60;
				string text2 = "";
				string text3 = "";
				bool flag2 = false;
				int tickCount = Environment.TickCount;
				while (Environment.TickCount - tickCount < num * 1000)
				{
					text2 = "";
					text3 = ac28BD29_0.CB3C4B8A(0, ref text2, new List<string> { "//android.widget.Button[@text='Log out of all sessions']", "//android.widget.Button[@text='Log out']" });
					string text4 = text3;
					string text5 = text4;
					if (!(text5 == "//android.widget.Button[@text='Log out of all sessions']"))
					{
						if (!(text5 == "//android.widget.Button[@text='Log out']"))
						{
							if (flag2)
							{
								ac28BD29_0.EE294CB1(30.0, "//android.widget.Button[@text='Log out']");
								ac28BD29_0.method_30(30);
								flag = true;
								break;
							}
						}
						else
						{
							SetStatusAccount(int_1, text + "Tap " + Regex.Match(text3, "'(.*?)'").Groups[1].Value + "...");
							ac28BD29_0.TapByXPath(text3, text2);
							flag2 = true;
						}
					}
					else
					{
						SetStatusAccount(int_1, text + "Tap " + Regex.Match(text3, "'(.*?)'").Groups[1].Value + "...");
						ac28BD29_0.TapByXPath(text3, text2);
					}
					ac28BD29_0.TimeDelay(2.0);
				}
			}
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	private int method_36(int int_1, string string_0, AC28BD29 D594F891, string string_1)
	{
		string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
		SetStatusAccount(int_1, text + Language.GetValue("Đang chạy..."));
		bool flag = false;
		try
		{
			while (FA905AA0(D594F891, int_1, text, "fb://profile"))
			{
				int num = 60;
				string text2 = "";
				string text3 = "";
				for (int tickCount = Environment.TickCount; Environment.TickCount - tickCount < num * 1000; D594F891.TimeDelay(2.0))
				{
					text2 = "";
					text3 = D594F891.CB3C4B8A(0, ref text2, new List<string> { "//*[@content-desc='More']", "//*[@content-desc='Turn on']" });
					string text4 = text3;
					string text5 = text4;
					if (!(text5 == "//*[@content-desc='More']"))
					{
						if (!(text5 == "//*[@content-desc='Turn on']"))
						{
							Bitmap f608D = D594F891.method_87();
							if (D594F891.method_84("dataimage\\turnonpromode", f608D))
							{
								D594F891.BD33F0BA("dataimage\\turnonpromode", f608D);
								continue;
							}
							if (D594F891.method_84("dataimage\\turnoffpromode", f608D))
							{
								flag = true;
								break;
							}
							if (D594F891.method_104(text2).Count == 1)
							{
								D594F891.method_44(0, D594F891.method_104(text2).First(), text2);
								continue;
							}
							SetStatusAccount(int_1, text + "Scroll...");
							if (D594F891.CE16082B(-1))
							{
								switch (method_22(D594F891, int_1, text))
								{
								default:
									goto end_IL_004d;
								case 0:
									continue;
								case 1:
									break;
								}
								goto IL_0242;
							}
						}
						else
						{
							SetStatusAccount(int_1, text + "Tap " + Regex.Match(text3, "'(.*?)'").Groups[1].Value + "...");
							D594F891.TapByXPath(text3, text2);
							D594F891.method_30(10);
						}
					}
					else
					{
						if (D594F891.DoesElementExist(0, text2, "//*[starts-with(@text,'Professional mode') or starts-with(@content-desc,'Professional mode')]"))
						{
							flag = true;
							break;
						}
						SetStatusAccount(int_1, text + "Tap " + Regex.Match(text3, "'(.*?)'").Groups[1].Value + "...");
						D594F891.TapByXPath(text3, text2);
					}
				}
				break;
				IL_0242:;
			}
			end_IL_004d:;
		}
		catch
		{
		}
		return flag ? 1 : 0;
	}

	private int method_37(ref int int_1, int B18F5D34, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string B00F7104)
	{
		string text = string_0 + Language.GetValue("Đang") + " " + B00F7104 + ": ";
		SetStatusAccount(B18F5D34, text + Language.GetValue("Đang chạy..."));
		f72FAFBC_0.GetValue("txtId");
		f72FAFBC_0.GetValue("cbbNoiDungCha");
		f72FAFBC_0.GetValue("cbbNoiDungCon");
		if (!Base.bool_0)
		{
			return 0;
		}
		return 0;
	}

	private int BB214F1D(ref int int_1, int E53EA618, string string_0, AC28BD29 ac28BD29_0, JSON_Settings C70CEC22, string string_1)
	{
		if (!Base.bool_0)
		{
			return 0;
		}
		return 0;
	}

	private int FA9F9110(int DF2D1436, string AB22FA8D, AC28BD29 ac28BD29_0, string string_0)
	{
		string text = AB22FA8D + Language.GetValue("Đang") + " " + string_0 + ": ";
		SetStatusAccount(DF2D1436, text + Language.GetValue("Đang chạy..."));
		method_44(ac28BD29_0);
		return 1;
	}

	private int method_38(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_1)
	{
		bool flag = false;
		string path = f72FAFBC_0.GetValue("txtPathFolder");
		bool flag2 = f72FAFBC_0.AA824D29("ckbXoaAnhDaDung");
		if (Directory.GetFiles(path).Length != 0)
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			SetStatusAccount(int_1, text + Language.GetValue("Đang chạy..."));
			try
			{
				int num = 0;
				int num2 = 3;
				int num3 = 0;
				int num4 = 6;
				while (FA905AA0(ac28BD29_0, int_1, text, "fb://profile_edit"))
				{
					string text2 = "";
					if (flag2)
					{
						lock (object_2)
						{
							text2 = (from string_06 in Directory.GetFiles(path)
								orderby Guid.NewGuid()
								select string_06).FirstOrDefault();
							if (string.IsNullOrEmpty(text2))
							{
								break;
							}
							ac28BD29_0.method_96(new List<string> { text2 });
							Common.smethod_49(text2);
							goto IL_0163;
						}
					}
					text2 = (from string_03 in Directory.GetFiles(path)
						orderby Guid.NewGuid()
						select string_03).FirstOrDefault();
					if (!string.IsNullOrEmpty(text2))
					{
						ac28BD29_0.method_96(new List<string> { text2 });
						goto IL_0163;
					}
					break;
					IL_0163:
					string text3 = "";
					int tickCount = Environment.TickCount;
					bool flag3 = false;
					do
					{
						text3 = ac28BD29_0.GetPageSource();
						string text4 = ac28BD29_0.FindElement(0, text3, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='Profile picture, Button']", "//android.widget.Button[@text='ALLOW']", "//android.view.ViewGroup[@content-desc='SAVE']", "//*[@content-desc='Photo']", "//*[@content-desc='Photo. Disabled.']" });
						string text5 = text4;
						string text6 = text5;
						uint num5 = HashString.DA8CEBAB(text6);
						if (num5 > 532719482)
						{
							if (num5 <= 3462202881u)
							{
								if (num5 != 2289923420u)
								{
									if (num5 == 3462202881u && text6 == "//*[@content-desc='Photo. Disabled.']")
									{
										if (num >= num2)
										{
											goto IL_0483;
										}
										num++;
										ac28BD29_0.TapByXPath("//*[@content-desc='Back']", text3);
										goto IL_02d8;
									}
								}
								else if (text6 == "//*[@content-desc='Profile picture, Button']")
								{
									goto IL_0295;
								}
								goto IL_0219;
							}
							if (num5 != 3803917544u)
							{
								if (num5 != 4090015443u || !(text6 == "//android.widget.Button[@text='ALLOW']"))
								{
									goto IL_0219;
								}
							}
							else if (!(text6 == "//android.view.ViewGroup[@content-desc='SAVE']"))
							{
								goto IL_0219;
							}
							goto IL_0295;
						}
						if (num5 != 273826655)
						{
							if (num5 != 281629319)
							{
								if (num5 != 532719482 || !(text6 == "//android.widget.ProgressBar"))
								{
									goto IL_0219;
								}
								SetStatusAccount(int_1, text + "Loading...");
							}
							else
							{
								if (!(text6 == "//*[@text='Tap to retry']"))
								{
									goto IL_0219;
								}
								if (num3 >= num4)
								{
									break;
								}
								num3++;
								ac28BD29_0.CE16082B(-1);
							}
						}
						else
						{
							if (!(text6 == "//*[@content-desc='Photo']"))
							{
								goto IL_0219;
							}
							List<string> list = ac28BD29_0.FindElements(0, "", text4);
							if (list.Count > 1)
							{
								list = list.GetRange(0, list.Count - 1);
							}
							string string_2 = list.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
							ac28BD29_0.E832B991(string_2);
							flag3 = true;
						}
						goto IL_02d8;
						IL_02d8:
						ac28BD29_0.TimeDelay(2.0);
						continue;
						IL_0295:
						if (!(text4 == "//*[@content-desc='Profile picture, Button']" && flag3))
						{
							SetStatusAccount(int_1, text + "Tap " + ac28BD29_0.method_105(text4) + "...");
							ac28BD29_0.TapByXPath(text4, text3);
							goto IL_02d8;
						}
						flag = true;
						break;
						IL_0219:
						if (ac28BD29_0.DoesElementExist(0, text3, "//android.widget.TextView[@text='CAMERA ROLL']") && !ac28BD29_0.DoesElementExist(0, text3, "//*[@content-desc='Live camera']"))
						{
							ac28BD29_0.TapByXPath("//*[@content-desc='Back']", text3);
						}
						else
						{
							SetStatusAccount(int_1, text + "Scroll...");
							if (ac28BD29_0.CE16082B())
							{
								switch (method_22(ac28BD29_0, int_1, text))
								{
								case 0:
									goto IL_02d8;
								case 1:
									goto IL_0483;
								}
								break;
							}
						}
						goto IL_02d8;
					}
					while (Environment.TickCount - tickCount < 300000);
					break;
					IL_0483:;
				}
			}
			catch
			{
			}
		}
		return flag ? 1 : 0;
	}

	private int method_39(int DE9FA8BF, string B89EE9A9, AC28BD29 E0BC9408, JSON_Settings FD19361C, string string_0)
	{
		bool flag = false;
		string path = FD19361C.GetValue("txtPathFolder");
		bool flag2 = FD19361C.AA824D29("ckbXoaAnhDaDung");
		if (Directory.GetFiles(path).Length != 0)
		{
			string text = B89EE9A9 + Language.GetValue("Đang") + " " + string_0 + ": ";
			SetStatusAccount(DE9FA8BF, text + Language.GetValue("Đang chạy..."));
			try
			{
				int num = 0;
				int num2 = 3;
				int num3 = 0;
				int num4 = 6;
				while (FA905AA0(E0BC9408, DE9FA8BF, text, "fb://profile_edit"))
				{
					string text2 = "";
					if (flag2)
					{
						lock (D739380E)
						{
							text2 = (from B392998A in Directory.GetFiles(path)
								orderby Guid.NewGuid()
								select B392998A).FirstOrDefault();
							if (string.IsNullOrEmpty(text2))
							{
								break;
							}
							E0BC9408.method_96(new List<string> { text2 });
							Common.smethod_49(text2);
							goto IL_0163;
						}
					}
					text2 = (from CF89B124 in Directory.GetFiles(path)
						orderby Guid.NewGuid()
						select CF89B124).FirstOrDefault();
					if (!string.IsNullOrEmpty(text2))
					{
						E0BC9408.method_96(new List<string> { text2 });
						goto IL_0163;
					}
					break;
					IL_0163:
					string text3 = "";
					int tickCount = Environment.TickCount;
					bool flag3 = false;
					do
					{
						text3 = E0BC9408.GetPageSource();
						string text4 = E0BC9408.FindElement(0, text3, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[contains(@content-desc,'cover photo')]", "//android.widget.Button[@text='ALLOW']", "//android.view.ViewGroup[@content-desc='SAVE']", "//*[@content-desc='Photo']", "//*[@content-desc='Photo. Disabled.']" });
						string text5 = text4;
						string text6 = text5;
						uint num5 = HashString.DA8CEBAB(text6);
						if (num5 > 281629319)
						{
							if (num5 > 3462202881u)
							{
								if (num5 != 3803917544u)
								{
									if (num5 != 4090015443u || !(text6 == "//android.widget.Button[@text='ALLOW']"))
									{
										goto IL_022d;
									}
								}
								else if (!(text6 == "//android.view.ViewGroup[@content-desc='SAVE']"))
								{
									goto IL_022d;
								}
								goto IL_026d;
							}
							if (num5 != 532719482)
							{
								if (num5 != 3462202881u || !(text6 == "//*[@content-desc='Photo. Disabled.']"))
								{
									goto IL_022d;
								}
								if (num >= num2)
								{
									goto IL_044a;
								}
								num++;
								E0BC9408.TapByXPath("//*[@content-desc='Back']", text3);
							}
							else
							{
								if (!(text6 == "//android.widget.ProgressBar"))
								{
									goto IL_022d;
								}
								SetStatusAccount(DE9FA8BF, text + "Loading...");
							}
						}
						else
						{
							if (num5 == 250204863)
							{
								if (!(text6 == "//*[contains(@content-desc,'cover photo')]"))
								{
									goto IL_022d;
								}
								goto IL_026d;
							}
							if (num5 != 273826655)
							{
								if (num5 != 281629319 || !(text6 == "//*[@text='Tap to retry']"))
								{
									goto IL_022d;
								}
								if (num3 >= num4)
								{
									break;
								}
								num3++;
								E0BC9408.CE16082B(-1);
							}
							else
							{
								if (!(text6 == "//*[@content-desc='Photo']"))
								{
									goto IL_022d;
								}
								List<string> list = E0BC9408.FindElements(0, "", text4);
								if (list.Count > 1)
								{
									list = list.GetRange(0, list.Count - 1);
								}
								string string_ = list.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
								E0BC9408.E832B991(string_);
								flag3 = true;
							}
						}
						goto IL_02b0;
						IL_026d:
						if (!(text4 == "//*[contains(@content-desc,'cover photo')]" && flag3))
						{
							SetStatusAccount(DE9FA8BF, text + "Tap " + E0BC9408.method_105(text4) + "...");
							E0BC9408.TapByXPath(text4, text3);
							goto IL_02b0;
						}
						flag = true;
						break;
						IL_02b0:
						E0BC9408.TimeDelay(2.0);
						continue;
						IL_022d:
						SetStatusAccount(DE9FA8BF, text + "Scroll...");
						if (E0BC9408.CE16082B())
						{
							switch (method_22(E0BC9408, DE9FA8BF, text))
							{
							case 0:
								goto IL_02b0;
							case 1:
								goto IL_044a;
							}
							break;
						}
						goto IL_02b0;
					}
					while (Environment.TickCount - tickCount < 300000);
					break;
					IL_044a:;
				}
			}
			catch
			{
			}
		}
		return flag ? 1 : 0;
	}

	private int F81EC224(int F989780B, string string_0, AC28BD29 ac28BD29_0, string string_1)
	{
		string text = method_117(F989780B, "cPassword");
		if (text == "")
		{
			SetStatusAccount(F989780B, string_0 + Language.GetValue("Không có password"));
			return 0;
		}
		string text2 = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
		SetStatusAccount(F989780B, text2 + Language.GetValue("Đang chạy..."));
		int result = 2;
		int num = 0;
		int num2 = 2;
		int num3 = 0;
		int num4 = 6;
		while (FA905AA0(ac28BD29_0, F989780B, text2, "fb://facewebmodal/f?href=https://mbasic.facebook.com/settings/sms/?ref_component=mbasic_bookmark&ref_page=XMenuController"))
		{
			string text3 = "";
			int tickCount = Environment.TickCount;
			while (true)
			{
				text3 = ac28BD29_0.GetPageSource();
				string text4 = ac28BD29_0.FindElement(0, text3, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@text='Remove']", "//android.widget.CheckBox[@text='I understand I could lose access to my account']", "//*[@text='Remove phone'][@focused='false']", "//*[@text='Remove phone'][@focused='true']" });
				switch (text4)
				{
				case "//*[@text='Remove']":
					if (!text3.Contains("you can't delete the primary phone number if we don't have other contact info for you. Please add another phone or add an email address to your account"))
					{
						SetStatusAccount(F989780B, text2 + "Tap " + ac28BD29_0.method_105(text4) + "...");
						ac28BD29_0.TapByXPath(text4, text3);
						goto IL_00eb;
					}
					result = 4;
					break;
				default:
					if (!ac28BD29_0.ED9CDB24(text3, "Add a Mobile Number", "Add Number", "Add phone number"))
					{
						if (!ac28BD29_0.ED9CDB24(text3, "This content is no longer available"))
						{
							SetStatusAccount(F989780B, text2 + "Scroll...");
							if (ac28BD29_0.CE16082B())
							{
								switch (method_22(ac28BD29_0, F989780B, text2))
								{
								case 0:
									break;
								case 1:
									goto IL_0355;
								default:
									goto end_IL_0355;
								}
							}
							goto IL_00eb;
						}
						goto IL_0347;
					}
					result = 1;
					break;
				case "//*[@text='Tap to retry']":
					if (num3 >= num4)
					{
						break;
					}
					num3++;
					ac28BD29_0.CE16082B(-1);
					goto IL_00eb;
				case "//android.widget.ProgressBar":
					SetStatusAccount(F989780B, text2 + "Loading...");
					goto IL_00eb;
				case "//*[@text='Remove phone'][@focused='true']":
					if (text3.Contains("Incorrect password"))
					{
						result = 3;
						break;
					}
					goto IL_00eb;
				case "//*[@text='Remove phone'][@focused='false']":
					ac28BD29_0.SendByXPath("//android.widget.EditText", text);
					ac28BD29_0.TimeDelay(2.0);
					SetStatusAccount(F989780B, text2 + "Tap " + ac28BD29_0.method_105(text4) + "...");
					ac28BD29_0.TapByXPath(text4, text3);
					goto IL_00eb;
				case "//android.widget.CheckBox[@text='I understand I could lose access to my account']":
					{
						ac28BD29_0.TapByXPath("//android.widget.CheckBox[@text='I understand I could lose access to my account'][@checked='false']", text3);
						ac28BD29_0.TimeDelay(2.0);
						ac28BD29_0.TapByXPath("//*[@text='Remove Number']", text3);
						goto IL_00eb;
					}
					IL_00eb:
					ac28BD29_0.TimeDelay(2.0);
					if (Environment.TickCount - tickCount < 300000)
					{
						continue;
					}
					break;
				}
				break;
			}
			break;
			IL_0347:
			if (num < num2)
			{
				num++;
				continue;
			}
			result = 5;
			break;
			continue;
			end_IL_0355:
			break;
			IL_0355:;
		}
		return result;
	}

	private int B1B3FD1A(int A722631C, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_1)
	{
		string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
		SetStatusAccount(A722631C, text + Language.GetValue("Đang chạy..."));
		List<string> list = f72FAFBC_0.EC378D8A("txtTenNhom");
		int f988D70A = f72FAFBC_0.method_0("nudSoLuongFrom");
		int e234B = f72FAFBC_0.method_0("nudSoLuongTo");
		int num = ac28BD29_0.C4B7B817(f988D70A, e234B);
		int num2 = 0;
		int num3 = 0;
		int num4 = 6;
		while (true)
		{
			IL_0468:
			SetStatusAccount(A722631C, text + $"({num2 + 1}/{num})...");
			ac28BD29_0.method_69("fb://groups_targeted_tab");
			ac28BD29_0.TimeDelay(2.0);
			string text2 = "";
			int tickCount = Environment.TickCount;
			while (true)
			{
				text2 = ac28BD29_0.GetPageSource();
				string text3 = ac28BD29_0.FindElement(0, text2, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='Your groups']", "//android.widget.EditText[@text='Name your group']", "//*[starts-with(@content-desc,'Public, Anyone can see')]", "//*[@content-desc='Create group'][@clickable='true']", "//*[@text='Invite members']", "//*[@content-desc='Open create options']", "//*[@content-desc='Close create options']/parent::*/child::*[1]", "//*[contains(@content-desc,'Create a Group')]" });
				string text4 = text3;
				string text5 = text4;
				uint num5 = HashString.DA8CEBAB(text5);
				if (num5 > 1072647801)
				{
					if (num5 <= 3376106338u)
					{
						if (num5 != 3334663986u)
						{
							if (num5 == 3376106338u && text5 == "//*[@content-desc='Close create options']/parent::*/child::*[1]")
							{
								goto IL_0200;
							}
						}
						else if (text5 == "//android.widget.EditText[@text='Name your group']")
						{
							string string_2 = list.smethod_8().smethod_0(2);
							ac28BD29_0.SendByXPath(text3, string_2);
							ac28BD29_0.TimeDelay(1.0);
							ac28BD29_0.TapByXPath("//*[@content-desc='Choose privacy']", text2);
							goto IL_022f;
						}
					}
					else if (num5 != 3472275803u)
					{
						if (num5 != 3651748629u)
						{
							if (num5 == 3660169492u && text5 == "//*[contains(@content-desc,'Create a Group')]")
							{
								goto IL_0200;
							}
						}
						else if (text5 == "//*[starts-with(@content-desc,'Public, Anyone can see')]")
						{
							SetStatusAccount(A722631C, text + "Tap " + ac28BD29_0.method_105(text3) + "...");
							ac28BD29_0.TapByXPath(text3, text2);
							ac28BD29_0.TimeDelay(1.0);
							ac28BD29_0.TapByXPath("//*[starts-with(@content-desc,'Done')]");
							goto IL_022f;
						}
					}
					else if (text5 == "//*[@content-desc='Create group'][@clickable='true']")
					{
						goto IL_0200;
					}
				}
				else
				{
					if (num5 <= 281629319)
					{
						if (num5 != 157897078)
						{
							if (num5 != 281629319 || !(text5 == "//*[@text='Tap to retry']"))
							{
								goto IL_01c0;
							}
							if (num3 >= num4)
							{
								goto IL_04c1;
							}
							num3++;
							ac28BD29_0.CE16082B(-1);
						}
						else
						{
							if (!(text5 == "//*[@content-desc='Your groups']"))
							{
								goto IL_01c0;
							}
							if (ac28BD29_0.DoesElementExist(0, text2, "//*[@content-desc='Open create options']"))
							{
								text3 = "//*[@content-desc='Open create options']";
							}
							else if (ac28BD29_0.DoesElementExist(0, text2, "//*[@content-desc='Create actions entry point']"))
							{
								text3 = "//*[@content-desc='Create actions entry point']";
							}
							else if (ac28BD29_0.DoesElementExist(0, text2, "//*[@content-desc='Create group']"))
							{
								text3 = "//*[@content-desc='Create group']";
							}
							SetStatusAccount(A722631C, text + "Tap " + ac28BD29_0.method_105(text3) + "...");
							ac28BD29_0.TapByXPath(text3, text2);
						}
						goto IL_022f;
					}
					if (num5 != 532719482)
					{
						if (num5 != 826887081)
						{
							if (num5 == 1072647801 && text5 == "//*[@content-desc='Open create options']")
							{
								goto IL_0200;
							}
						}
						else if (text5 == "//*[@text='Invite members']")
						{
							num2++;
							if (num2 < num)
							{
								break;
							}
							goto IL_04c1;
						}
					}
					else if (text5 == "//android.widget.ProgressBar")
					{
						SetStatusAccount(A722631C, text + "Loading...");
						goto IL_022f;
					}
				}
				goto IL_01c0;
				IL_04c1:
				return num2;
				IL_0200:
				SetStatusAccount(A722631C, text + "Tap " + ac28BD29_0.method_105(text3) + "...");
				ac28BD29_0.TapByXPath(text3, text2);
				goto IL_022f;
				IL_01c0:
				SetStatusAccount(A722631C, text + "Scroll...");
				if (ac28BD29_0.CE16082B())
				{
					switch (method_22(ac28BD29_0, A722631C, text))
					{
					case 0:
						break;
					case 1:
						goto IL_0468;
					default:
						goto IL_04c1;
					}
				}
				goto IL_022f;
				IL_022f:
				ac28BD29_0.TimeDelay(2.0);
				if (Environment.TickCount - tickCount < 300000)
				{
					continue;
				}
				goto IL_04c1;
			}
		}
	}

	private int A2A1211C(int D98FB722, string EB86E33F, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_0)
	{
		int num = 0;
		try
		{
			string text = EB86E33F + Language.GetValue("Đang") + " " + string_0 + ": ";
			SetStatusAccount(D98FB722, text + Language.GetValue("Đang chạy..."));
			int f988D70A = f72FAFBC_0.method_0("nudSoLuongFrom");
			int e234B = f72FAFBC_0.method_0("nudSoLuongTo");
			int num2 = ac28BD29_0.C4B7B817(f988D70A, e234B);
			int minValue = f72FAFBC_0.method_0("nudDelayFrom", 3);
			int num3 = f72FAFBC_0.method_0("nudDelayTo", 5);
			List<string> collection = f72FAFBC_0.EC378D8A("txtTenNhom");
			List<string> collection2 = f72FAFBC_0.EC378D8A("txtCatagory");
			List<string> list = new List<string>(collection);
			List<string> list2 = new List<string>(collection2);
			if (list.Count != 0)
			{
				int num4 = 0;
				int num5 = 3;
				while (true)
				{
					IL_05d9:
					SetStatusAccount(D98FB722, text + $"({num + 1}/{num2})...");
					ac28BD29_0.method_69("fb://pagestab");
					ac28BD29_0.TimeDelay(2.0);
					int num6 = 0;
					int num7 = 5;
					string text2 = "";
					int tickCount = Environment.TickCount;
					do
					{
						text2 = ac28BD29_0.GetPageSource();
						string text3 = ac28BD29_0.FindElement(0, text2, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='Create']", "//*[@content-desc='Get Started']", "//android.widget.EditText[@text='Page name']", "//*[@content-desc='Next']", "//*[@content-desc='Skip']" });
						string text4 = text3;
						string text5 = text4;
						uint num8 = HashString.DA8CEBAB(text5);
						if (num8 > 532719482)
						{
							if (num8 <= 1792698548)
							{
								if (num8 != 1598931890)
								{
									if (num8 == 1792698548 && text5 == "//*[@content-desc='Next']")
									{
										if (!ac28BD29_0.DoesElementExist(0, text2, "//android.widget.ImageView"))
										{
											if (ac28BD29_0.FindElement(0, text2, new List<string> { "//*[@content-desc='Describe what your Page is about']", "//*[@content-desc='Edit action button']" }) != "")
											{
												num++;
												SetStatusAccount(D98FB722, text + $"({num}/{num2}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue, num3 + 1));
												if (num >= num2)
												{
													break;
												}
												goto IL_05d9;
											}
											SetStatusAccount(D98FB722, text + $"({num + 1}/{num2}), " + "Tap " + ac28BD29_0.method_105(text3) + "...");
											ac28BD29_0.TapByXPath(text3, text2);
										}
										goto IL_03d1;
									}
								}
								else if (text5 == "//*[@content-desc='Skip']")
								{
									num++;
									if (num >= num2)
									{
										break;
									}
									goto IL_05d9;
								}
								goto IL_0349;
							}
							if (num8 != 2862658382u)
							{
								if (num8 != 3906601821u || !(text5 == "//*[@content-desc='Create']"))
								{
									goto IL_0349;
								}
								if (ac28BD29_0.ED9CDB24(text2, "Cannot create Page") || num6 >= num7)
								{
									break;
								}
								num6++;
								if (ac28BD29_0.DoesElementExist(0, text2, "//android.widget.EditText[@text='Search for categories']"))
								{
									string text6 = "";
									if (list2.Count == 0)
									{
										list2 = new List<string>(collection2);
									}
									if (list2.Count > 0)
									{
										text6 = list2.First();
										list2.RemoveAt(0);
									}
									if (text6 == "")
									{
										text6 = Common.CreateRandomString(1);
									}
									ac28BD29_0.SendByXPath("//android.widget.EditText[@text='Search for categories']", text6);
									ac28BD29_0.TimeDelay(2.0);
									ac28BD29_0.TapByXPath("//android.widget.EditText/parent::*/following-sibling::*[1]/child::*");
									ac28BD29_0.TimeDelay(2.0);
									text2 = ac28BD29_0.GetPageSource();
								}
								SetStatusAccount(D98FB722, text + $"({num + 1}/{num2}), " + "Tap " + ac28BD29_0.method_105(text3) + "...");
								ac28BD29_0.TapByXPath(text3, text2);
							}
							else
							{
								if (!(text5 == "//*[@content-desc='Get Started']"))
								{
									goto IL_0349;
								}
								SetStatusAccount(D98FB722, text + "Tap " + ac28BD29_0.method_105(text3) + "...");
								ac28BD29_0.TapByXPath(text3, text2);
							}
						}
						else if (num8 != 36404325)
						{
							if (num8 != 281629319)
							{
								if (num8 != 532719482 || !(text5 == "//android.widget.ProgressBar"))
								{
									goto IL_0349;
								}
								SetStatusAccount(D98FB722, text + $"({num + 1}/{num2}), " + "Loading...");
							}
							else
							{
								if (!(text5 == "//*[@text='Tap to retry']"))
								{
									goto IL_0349;
								}
								if (num4 >= num5)
								{
									break;
								}
								num4++;
								ac28BD29_0.CE16082B(-1);
							}
						}
						else
						{
							if (!(text5 == "//android.widget.EditText[@text='Page name']"))
							{
								goto IL_0349;
							}
							string text7 = "";
							if (list.Count == 0)
							{
								list = new List<string>(collection);
							}
							text7 = list.First();
							list.RemoveAt(0);
							text7 = GClass6.smethod_0(text7);
							ac28BD29_0.SendByXPath(text3, text7);
						}
						goto IL_03d1;
						IL_03d1:
						ac28BD29_0.TimeDelay(2.0);
						continue;
						IL_0349:
						SetStatusAccount(D98FB722, text + $"({num + 1}/{num2}), " + "Scroll...");
						if (ac28BD29_0.CE16082B())
						{
							switch (method_22(ac28BD29_0, D98FB722, text))
							{
							case 0:
								goto IL_03d1;
							case 1:
								goto IL_05d9;
							}
							break;
						}
						goto IL_03d1;
					}
					while (Environment.TickCount - tickCount < 300000);
					break;
				}
			}
		}
		catch (Exception)
		{
		}
		return num;
	}

	private int method_40(int B0AF453F, string C1142AA9, AC28BD29 D323468D, string string_0)
	{
		string text = C1142AA9 + Language.GetValue("Đang") + " " + string_0 + ": ";
		SetStatusAccount(B0AF453F, text + Language.GetValue("Đang chạy..."));
		int result = 2;
		int num = 0;
		int num2 = 6;
		while (FA905AA0(D323468D, B0AF453F, text, "fb://facewebmodal/f?href=https://m.facebook.com/settings/subscribe/?settings_tracking=mbasic_footer_link%3Asettings_3_0_pecs&_rdr"))
		{
			string text2 = "";
			int tickCount = Environment.TickCount;
			do
			{
				List<string> list = D323468D.FindElements(0, "", "//android.view.View[@resource-id='m_check_list_aria_label']/parent::*/*[@text='Public']");
				foreach (string item in list)
				{
					D323468D.E832B991(item);
				}
				text2 = D323468D.GetPageSource();
				string text3 = D323468D.FindElement(0, text2, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//android.view.View[@resource-id='m_check_list_aria_label']/parent::*/*[@text='Public']", "//android.widget.CheckBox[@text='I understand I could lose access to my account']", "//android.widget.Button[@text='Remove phone'][@focused='false']", "//android.widget.Button[@text='Remove phone'][@focused='true']", "//android.widget.Button[@text='Add Number']" });
				string text4 = text3;
				string text5 = text4;
				uint num3 = HashString.DA8CEBAB(text5);
				if (num3 <= 1240253437)
				{
					if (num3 != 281629319)
					{
						switch (num3)
						{
						case 1240253437u:
							if (!(text5 == "//android.widget.Button[@text='Remove phone'][@focused='false']"))
							{
								break;
							}
							goto IL_02ae;
						case 532719482u:
							if (!(text5 == "//android.widget.ProgressBar"))
							{
								break;
							}
							SetStatusAccount(B0AF453F, text + "Loading...");
							goto IL_02ae;
						}
					}
					else if (text5 == "//*[@text='Tap to retry']")
					{
						if (num >= num2)
						{
							break;
						}
						num++;
						D323468D.CE16082B(-1);
						goto IL_02ae;
					}
				}
				else if (num3 <= 3058708030u)
				{
					switch (num3)
					{
					case 3058708030u:
						if (!(text5 == "//android.view.View[@resource-id='m_check_list_aria_label']/parent::*/*[@text='Public']"))
						{
							break;
						}
						D323468D.TapByXPath(text3, text2);
						goto IL_02ae;
					case 2264810661u:
						if (!(text5 == "//android.widget.CheckBox[@text='I understand I could lose access to my account']"))
						{
							break;
						}
						D323468D.TapByXPath("//android.widget.CheckBox[@text='I understand I could lose access to my account'][@checked='false']", text2);
						D323468D.TimeDelay(2.0);
						D323468D.TapByXPath("//android.widget.Button[@text='Remove Number']", text2);
						goto IL_02ae;
					}
				}
				else if (num3 != 4038011690u)
				{
					if (num3 == 4151471674u && text5 == "//android.widget.Button[@text='Add Number']")
					{
						result = 1;
						break;
					}
				}
				else if (text5 == "//android.widget.Button[@text='Remove phone'][@focused='true']")
				{
					if (text2.Contains("Incorrect password"))
					{
						result = 3;
						break;
					}
					goto IL_02ae;
				}
				SetStatusAccount(B0AF453F, text + "Scroll...");
				if (D323468D.CE16082B())
				{
					int num4 = method_22(D323468D, B0AF453F, text);
					if (num4 == 1)
					{
						goto IL_02ef;
					}
					if (num4 != 0)
					{
						break;
					}
				}
				goto IL_02ae;
				IL_02ae:
				D323468D.TimeDelay(2.0);
			}
			while (Environment.TickCount - tickCount < 300000);
			break;
			IL_02ef:;
		}
		return result;
	}

	private int F71C9A17(ref int int_1, int int_2, string DC9095B7, AC28BD29 ac28BD29_0, JSON_Settings E4B0C80B, string string_0)
	{
		method_117(int_2, "cId");
		string text = method_117(int_2, "cPassword");
		if (!(text == ""))
		{
			string text2 = "";
			if (E4B0C80B.method_0("typeMatKhau") == 0)
			{
				text2 = Common.CreateRandomStringNumber(10);
			}
			else
			{
				string text3 = (from CE8DC611 in E4B0C80B.EC378D8A("txtMatKhau")
					orderby Guid.NewGuid()
					select CE8DC611).FirstOrDefault();
				if (string.IsNullOrEmpty(text3))
				{
					goto IL_052d;
				}
				if (text3.Contains("*"))
				{
					string[] array = text3.Split('*');
					text2 = array[0];
					for (int i = 1; i < array.Length; i++)
					{
						text2 += Common.CreateRandomString(1);
						text2 += array[i];
					}
				}
				else
				{
					text2 = text3;
				}
			}
			E4B0C80B.method_0("nudTimeOut", 30);
			bool flag = E4B0C80B.AA824D29("ckbDangXuatThietBiCu");
			string text4 = DC9095B7 + Language.GetValue("Đang") + " " + string_0 + ": ";
			SetStatusAccount(int_2, text4 + Language.GetValue("Đang chạy..."));
			int_1 = 2;
			int num = 0;
			int num2 = 6;
			while (FA905AA0(ac28BD29_0, int_2, text4, "fb://security_settings"))
			{
				string text5 = "";
				int num3 = 0;
				int tickCount = Environment.TickCount;
				do
				{
					text5 = ac28BD29_0.GetPageSource();
					string text6 = ac28BD29_0.FindElement(0, text5, new List<string> { "//android.widget.EditText", "//*[@text='Change password' or @content-desc='Change password']", "//*[@text='Log out of other devices?']", "//*[@text='Log out']", "//android.widget.ProgressBar", "//*[@text='Tap to retry']" });
					switch (text6)
					{
					case "//*[@text='Change password' or @content-desc='Change password']":
					case "//*[@text='Log out']":
						SetStatusAccount(int_2, text4 + "Tap " + ac28BD29_0.method_105(text6) + "...");
						ac28BD29_0.TapByXPath(text6, text5);
						if (text6 == "//*[@text='Log out']")
						{
							break;
						}
						goto IL_01c1;
					default:
					{
						int num4 = method_22(ac28BD29_0, int_2, text4);
						if (num4 == 1)
						{
							goto IL_04d0;
						}
						if (num4 != 0)
						{
							break;
						}
						goto IL_01c1;
					}
					case "//*[@text='Tap to retry']":
						if (num < num2)
						{
							num++;
							ac28BD29_0.CE16082B(-1);
							goto IL_01c1;
						}
						int_1 = 4;
						break;
					case "//android.widget.ProgressBar":
						SetStatusAccount(int_2, text4 + "Loading...");
						goto IL_01c1;
					case "//*[@text='Log out of other devices?']":
						int_1 = 1;
						method_114(int_2, "cPassword", text2, "pass");
						if (ac28BD29_0.DoesElementExist(0, text5, "//*[@text=\"WHERE YOU'RE LOGGED IN\"]"))
						{
							if (!ac28BD29_0.DoesElementExist(0, text5, "//*[@text='Log out of all sessions']"))
							{
								do
								{
									SetStatusAccount(int_2, text4 + "Scroll...");
									if (ac28BD29_0.CE16082B())
									{
										break;
									}
									ac28BD29_0.TimeDelay(2.0);
									text5 = "";
								}
								while (!ac28BD29_0.C60AEB35(0, ref text5, "//*[@text='Log out of all sessions']"));
							}
							ac28BD29_0.TapByXPath("//*[@text='Log out of all sessions']", text5);
						}
						else
						{
							if (!flag)
							{
								ac28BD29_0.TapByXPath("//*[@text='stay logged in']", text5);
								ac28BD29_0.TimeDelay(2.0);
								ac28BD29_0.TapByXPath("//*[@text='Continue']", text5);
								break;
							}
							ac28BD29_0.TapByXPath("//*[@text='Review other devices']", text5);
							ac28BD29_0.TimeDelay(2.0);
							ac28BD29_0.TapByXPath("//*[@text='Continue']", text5);
						}
						goto IL_01c1;
					case "//android.widget.EditText":
						{
							if (num3 > 0)
							{
								if (!(ac28BD29_0.FindElement(0, text5, new List<string> { "//*[@text='Enter a valid password and try again.']", "//*[@text='Your old password was incorrectly typed.']" }) != ""))
								{
									if (ac28BD29_0.ED9CDB24(text5, "Password must differ from old password"))
									{
										int_1 = 5;
										break;
									}
									continue;
								}
								int_1 = 3;
								break;
							}
							num3++;
							ac28BD29_0.SendByXPath("(//android.widget.EditText)[1]", text);
							ac28BD29_0.TimeDelay(1.0);
							ac28BD29_0.SendByXPath("(//android.widget.EditText)[2]", text2);
							ac28BD29_0.TimeDelay(1.0);
							ac28BD29_0.SendByXPath("(//android.widget.EditText)[3]", text2);
							ac28BD29_0.TimeDelay(1.0);
							ac28BD29_0.TapByXPath("//*[@text='Save changes' or @content-desc='Update Password']", text5);
							goto IL_01c1;
						}
						IL_01c1:
						ac28BD29_0.TimeDelay(2.0);
						continue;
					}
					break;
				}
				while (Environment.TickCount - tickCount < 300000);
				break;
				IL_04d0:;
			}
		}
		goto IL_052d;
		IL_052d:
		return 1;
	}

	private int FF3AA6B7(ref int int_1, int int_2, string F5168838, AC28BD29 ac28BD29_0, JSON_Settings BC801B85, string E233B823)
	{
		method_117(int_2, "cId");
		string text = method_117(int_2, "cPassword");
		if (!(text == ""))
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			int num = BC801B85.method_0("typeDatTen");
			if (num == 1)
			{
				list = BC801B85.EC378D8A("lstHo");
				list2 = BC801B85.EC378D8A("lstTenDem");
				list3 = BC801B85.EC378D8A("lstTen");
			}
			else if (BC801B85.method_0("typeTenRandom") == 0)
			{
				list = SetupFolder.smethod_3();
				list2 = SetupFolder.smethod_4();
				list3 = SetupFolder.F68AD388();
			}
			else
			{
				list = SetupFolder.DF31DAB8();
				list2 = new List<string>();
				list3 = SetupFolder.smethod_5();
			}
			string text2 = "";
			string string_ = "";
			string text3 = "";
			text2 = list.OrderBy((string E13C2D20) => Guid.NewGuid()).First();
			if (list2.Count > 0)
			{
				string_ = list2.OrderBy((string string_0) => Guid.NewGuid()).First();
			}
			text3 = list3.OrderBy((string string_0) => Guid.NewGuid()).First();
			string text4 = F5168838 + Language.GetValue("Đang") + " " + E233B823 + ": ";
			SetStatusAccount(int_2, text4 + Language.GetValue("Đang chạy..."));
			int_1 = 2;
			int num2 = 0;
			int num3 = 6;
			while (FA905AA0(ac28BD29_0, int_2, text4, "fb://settings"))
			{
				string text5 = "";
				int tickCount = Environment.TickCount;
				do
				{
					text5 = ac28BD29_0.GetPageSource();
					string text6 = ac28BD29_0.FindElement(0, text5, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='Personal and account information' or @text='Personal information']", "//*[contains(@text, \"You can't change your name on Facebook right now\")]", "//*[@text='Something went wrong. We're working on getting it fixed as soon as we can.']", "//*[@text='Review Change']", "//*[@text='Incorrect password.']", "//*[@text='Save changes']", "//*[@text='Name']", "//*[@text='Preview Your New Name']" });
					string text7 = text6;
					string text8 = text7;
					uint num4 = HashString.DA8CEBAB(text8);
					if (num4 > 1076335294)
					{
						if (num4 <= 1706730051)
						{
							if (num4 != 1211291022)
							{
								if (num4 == 1706730051 && text8 == "//*[contains(@text, \"You can't change your name on Facebook right now\")]")
								{
									int_1 = 4;
									break;
								}
							}
							else if (text8 == "//*[@content-desc='Personal and account information' or @text='Personal information']")
							{
								goto IL_02e9;
							}
						}
						else if (num4 != 2517234137u)
						{
							if (num4 != 2597739800u)
							{
								if (num4 == 3711050133u && text8 == "//*[@text='Review Change']")
								{
									ac28BD29_0.SendByXPath("(//android.widget.EditText)[1]", text2);
									ac28BD29_0.TimeDelay(1.0);
									ac28BD29_0.SendByXPath("(//android.widget.EditText)[2]", string_);
									ac28BD29_0.TimeDelay(1.0);
									ac28BD29_0.SendByXPath("(//android.widget.EditText)[3]", text3);
									ac28BD29_0.TimeDelay(1.0);
									ac28BD29_0.method_41(text6, text5);
									ac28BD29_0.TimeDelay(3.0);
									goto IL_0344;
								}
							}
							else if (text8 == "//*[@text='Name']")
							{
								goto IL_02e9;
							}
						}
						else if (text8 == "//*[@text='Preview Your New Name']")
						{
							int_1 = 1;
							break;
						}
					}
					else
					{
						if (num4 <= 322623071)
						{
							if (num4 != 281629319)
							{
								if (num4 != 322623071 || !(text8 == "//*[@text='Save changes']"))
								{
									goto IL_0323;
								}
								ac28BD29_0.SendByXPath("//android.widget.EditText", text);
								ac28BD29_0.TimeDelay(1.0);
								ac28BD29_0.TapByXPath(text6, text5);
							}
							else
							{
								if (!(text8 == "//*[@text='Tap to retry']"))
								{
									goto IL_0323;
								}
								if (num2 >= num3)
								{
									break;
								}
								num2++;
								ac28BD29_0.CE16082B(-1);
							}
							goto IL_0344;
						}
						if (num4 != 532719482)
						{
							if (num4 != 1042405475)
							{
								if (num4 == 1076335294 && text8 == "//*[@text='Something went wrong. We're working on getting it fixed as soon as we can.']")
								{
									int_1 = 5;
									break;
								}
							}
							else if (text8 == "//*[@text='Incorrect password.']")
							{
								int_1 = 3;
								break;
							}
						}
						else if (text8 == "//android.widget.ProgressBar")
						{
							SetStatusAccount(int_2, text4 + "Loading...");
							goto IL_0344;
						}
					}
					goto IL_0323;
					IL_02e9:
					if (ac28BD29_0.DoesElementExist(0, text5, "//*[@text='Name']"))
					{
						text6 = "//*[@text='Name']";
					}
					ac28BD29_0.TapByXPath(text6, text5);
					goto IL_0344;
					IL_0344:
					ac28BD29_0.TimeDelay(2.0);
					continue;
					IL_0323:
					int num5 = method_22(ac28BD29_0, int_2, text4);
					if (num5 == 1)
					{
						goto IL_0526;
					}
					if (num5 != 0)
					{
						break;
					}
					goto IL_0344;
				}
				while (Environment.TickCount - tickCount < 300000);
				break;
				IL_0526:;
			}
		}
		return 1;
	}

	private int method_41(ref string D0A0E5AD, int FA95C601, string A200788D, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string AAAC358E)
	{
		bool flag = f72FAFBC_0.AA824D29("ckbBio");
		bool flag2 = f72FAFBC_0.AA824D29("ckbWork");
		bool flag3 = f72FAFBC_0.AA824D29("ckbHighSchool");
		bool flag4 = f72FAFBC_0.AA824D29("ckbCollege");
		bool flag5 = f72FAFBC_0.AA824D29("ckbCurrentCity");
		bool flag6 = f72FAFBC_0.AA824D29("ckbHometown");
		bool flag7 = f72FAFBC_0.AA824D29("ckbRelationship");
		bool flag8 = f72FAFBC_0.AA824D29("ckbGender");
		bool flag9 = f72FAFBC_0.AA824D29("ckbBirthday");
		List<string> source = f72FAFBC_0.EC378D8A("txtBio", f72FAFBC_0.method_0("typeSplitBio"));
		List<string> source2 = f72FAFBC_0.EC378D8A("lstWork");
		List<string> source3 = f72FAFBC_0.EC378D8A("lstHighSchool");
		List<string> source4 = f72FAFBC_0.EC378D8A("lstCollege");
		List<string> source5 = f72FAFBC_0.EC378D8A("lstCurrentCity");
		List<string> source6 = f72FAFBC_0.EC378D8A("lstHometown");
		string text = f72FAFBC_0.GetValue("cbbRelationship").Split('|').ToList()
			.smethod_8();
		bool flag10 = f72FAFBC_0.AA824D29("ckbSkipWhenHave");
		string text2 = f72FAFBC_0.GetValue("cbbGender").Split('|').ToList()
			.smethod_8();
		List<string> source7 = f72FAFBC_0.EC378D8A("lstDay");
		List<string> source8 = f72FAFBC_0.EC378D8A("lstMonth");
		List<string> source9 = f72FAFBC_0.EC378D8A("lstYear");
		string text3 = A200788D + Language.GetValue("Đang") + " " + AAAC358E + ": ";
		SetStatusAccount(FA95C601, text3 + Language.GetValue("Đang chạy..."));
		if (!flag)
		{
			goto IL_0475;
		}
		int num = 0;
		int num2 = 6;
		SetStatusAccount(FA95C601, text3 + Language.GetValue("Cập nhật") + " Bio...");
		while (FA905AA0(ac28BD29_0, FA95C601, text3, "fb://profile_edit"))
		{
			bool flag11 = false;
			string text4 = "";
			int tickCount = Environment.TickCount;
			while (true)
			{
				text4 = ac28BD29_0.GetPageSource();
				string text5 = ac28BD29_0.FindElement(0, text4, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[contains(@content-desc, 'Tap to edit bio')]", "//android.widget.EditText", "//*[@text='Edit']", "//*[@content-desc='Edit Bio']" });
				switch (text5)
				{
				case "//*[contains(@content-desc, 'Tap to edit bio')]":
				case "//*[@text='Edit']":
				case "//*[@content-desc='Edit Bio']":
					if ((!flag10 || !(text5 == "//*[@content-desc='Edit Bio']")) && !flag11)
					{
						if (text5 == "//*[@text='Edit']")
						{
							Class65 @class = Class65.smethod_0(ac28BD29_0.FindElements(0, text4, "//*[@text='Bio']").First(), ac28BD29_0.FindElements(0, text4, text5));
							if (@class != null)
							{
								ac28BD29_0.E832B991(@class.AA3F9A29());
							}
						}
						else
						{
							ac28BD29_0.TapByXPath(text5, text4);
						}
						goto IL_0290;
					}
					goto IL_0475;
				default:
				{
					int num3 = method_22(ac28BD29_0, FA95C601, text3);
					if (num3 == 1)
					{
						goto IL_0458;
					}
					if (num3 != 0)
					{
						break;
					}
					goto IL_0290;
				}
				case "//*[@text='Tap to retry']":
					if (num >= num2)
					{
						break;
					}
					num++;
					ac28BD29_0.CE16082B(-1);
					goto IL_0290;
				case "//android.widget.ProgressBar":
					SetStatusAccount(FA95C601, text3 + "Loading...");
					goto IL_0290;
				case "//android.widget.EditText":
					{
						string string_ = Common.SpinText(source.OrderBy((string string_0) => Guid.NewGuid()).First());
						ac28BD29_0.SendByXPath(text5, string_);
						ac28BD29_0.TimeDelay(3.0);
						ac28BD29_0.TapByXPath("//*[@text='Save' or @content-desc='Save']", text4);
						flag11 = true;
						D0A0E5AD = "Bio-";
						goto IL_0290;
					}
					IL_0290:
					ac28BD29_0.TimeDelay(2.0);
					if (Environment.TickCount - tickCount < 300000)
					{
						continue;
					}
					goto IL_0475;
				}
				break;
			}
			break;
			IL_0458:;
		}
		goto IL_29a4;
		IL_29a4:
		return 1;
		IL_17de:
		if (!flag6)
		{
			goto IL_1d04;
		}
		int num4 = 0;
		int num5 = 6;
		SetStatusAccount(FA95C601, text3 + Language.GetValue("Cập nhật") + " Hometown...");
		while (ac28BD29_0.ED9CDB24("", "Edit Profile", "Edit Details") || FA905AA0(ac28BD29_0, FA95C601, text3, "fb://profile_edit"))
		{
			string text6 = "";
			bool flag12 = false;
			string text7 = "";
			int tickCount2 = Environment.TickCount;
			while (true)
			{
				text7 = ac28BD29_0.GetPageSource();
				string text8 = ac28BD29_0.FindElement(0, text7, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@text='Edit']", "//*[@text='Add']", "//*[@text='Add hometown']", "//android.widget.TextView[contains(@text,'From')]", "//*[@text='Edit hometown']", "//android.widget.EditText[@text='Select hometown']" });
				string text9 = text8;
				string text10 = text9;
				uint num6 = HashString.DA8CEBAB(text10);
				if (num6 > 1021549810)
				{
					if (num6 <= 2007378049)
					{
						if (num6 != 1134098073)
						{
							if (num6 == 2007378049 && text10 == "//*[@text='Add hometown']")
							{
								goto IL_1863;
							}
						}
						else if (text10 == "//android.widget.TextView[contains(@text,'From')]")
						{
							if (!flag10 && !flag12)
							{
								Class65 class2 = Class65.smethod_0(ac28BD29_0.FindElements(0, text7, text8).First(), ac28BD29_0.FindElements(0, text7, "//*[@content-desc='Edit']"));
								if (class2 != null)
								{
									ac28BD29_0.E832B991(class2.AA3F9A29());
								}
								goto IL_1b1e;
							}
							goto IL_1d04;
						}
					}
					else if (num6 != 2324930432u)
					{
						if (num6 == 3204427031u && text10 == "//*[@text='Edit']")
						{
							goto IL_199d;
						}
					}
					else if (text10 == "//android.widget.EditText[@text='Select hometown']")
					{
						text6 = source6.OrderBy((string string_0) => Guid.NewGuid()).First();
						ac28BD29_0.SendByXPath(text8, text6);
						ac28BD29_0.TimeDelay(2.0);
						List<string> list = ac28BD29_0.FindElements(10, "", "//android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup");
						if (list.Count > 0)
						{
							if (list.Count == 1 && ac28BD29_0.ED9CDB24("", "No Results Found"))
							{
								goto IL_1d04;
							}
							ac28BD29_0.E832B991(list.OrderBy((string F6880587) => Guid.NewGuid()).First());
						}
						goto IL_1b1e;
					}
				}
				else
				{
					if (num6 <= 532719482)
					{
						if (num6 != 281629319)
						{
							if (num6 != 532719482 || !(text10 == "//android.widget.ProgressBar"))
							{
								goto IL_1a3b;
							}
							SetStatusAccount(FA95C601, text3 + "Loading...");
						}
						else
						{
							if (!(text10 == "//*[@text='Tap to retry']"))
							{
								goto IL_1a3b;
							}
							if (num4 >= num5)
							{
								break;
							}
							num4++;
							ac28BD29_0.CE16082B(-1);
						}
						goto IL_1b1e;
					}
					if (num6 != 540160250)
					{
						if (num6 == 1021549810 && text10 == "//*[@text='Add']")
						{
							goto IL_199d;
						}
					}
					else if (text10 == "//*[@text='Edit hometown']")
					{
						goto IL_1863;
					}
				}
				goto IL_1a3b;
				IL_199d:
				if (!flag12)
				{
					Class65 class3 = Class65.smethod_0(ac28BD29_0.FindElements(0, text7, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text7, "//*[@text='Edit']"));
					if (class3 == null)
					{
						class3 = Class65.smethod_0(ac28BD29_0.FindElements(0, text7, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text7, "//*[@text='Add']"));
					}
					if (class3 != null)
					{
						ac28BD29_0.E832B991(class3.AA3F9A29());
					}
					else
					{
						ac28BD29_0.FB3ACF2E();
					}
					goto IL_1b1e;
				}
				goto IL_1d04;
				IL_1b1e:
				ac28BD29_0.TimeDelay(2.0);
				if (Environment.TickCount - tickCount2 < 300000)
				{
					continue;
				}
				goto IL_1d04;
				IL_1a3b:
				if (!ac28BD29_0.CE16082B())
				{
					goto IL_1b1e;
				}
				goto IL_1c9b;
				IL_1863:
				if (text6 != "")
				{
					ac28BD29_0.TapByXPath("//*[@text='Save' or @content-desc='Save'][@enabled='true']", text7);
					D0A0E5AD += "Hometown-";
					flag12 = true;
				}
				else if (ac28BD29_0.DoesElementExist(0, text7, "//*[@text='Hometown Name (Required)']"))
				{
					ac28BD29_0.TapByXPath("//*[@text='Hometown Name (Required)']", text7);
				}
				else if (text8 == "//*[@text='Add hometown']")
				{
					ac28BD29_0.TapByXPath(text8, text7);
				}
				else if (text8 == "//*[@text='Edit hometown']")
				{
					ac28BD29_0.TapByXPath("//*[@content-desc='Remove hometown']", text7);
				}
				goto IL_1b1e;
			}
			break;
			IL_1c9b:
			int num7 = method_22(ac28BD29_0, FA95C601, text3);
			if (num7 == 1)
			{
				continue;
			}
			if (num7 != 0)
			{
				break;
			}
			goto IL_1d04;
		}
		goto IL_29a4;
		IL_233f:
		if (flag8 || flag9)
		{
			int num8 = 0;
			int num9 = 6;
			SetStatusAccount(FA95C601, text3 + Language.GetValue("Cập nhật") + " Birthday/Gender...");
			while (FA905AA0(ac28BD29_0, FA95C601, text3, "fb://profile_edit"))
			{
				string text11 = "";
				int tickCount3 = Environment.TickCount;
				do
				{
					text11 = ac28BD29_0.GetPageSource();
					string text12 = ac28BD29_0.FindElement(0, text11, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@text='Edit Your About Info']", "//*[@text='Basic info']", "//*[@text='Birthday']/parent::*/child::*[2]/child::*/child::*" });
					switch (text12)
					{
					case "//*[@text='Edit Your About Info']":
						SetStatusAccount(FA95C601, text3 + "Tap " + ac28BD29_0.method_105(text12) + "...");
						ac28BD29_0.TapByXPath(text12, text11);
						goto IL_23b8;
					default:
						if (!ac28BD29_0.CE16082B())
						{
							goto IL_23b8;
						}
						goto IL_252d;
					case "//*[@text='Tap to retry']":
						if (num8 >= num9)
						{
							break;
						}
						num8++;
						ac28BD29_0.CE16082B(-1);
						goto IL_23b8;
					case "//android.widget.ProgressBar":
						SetStatusAccount(FA95C601, text3 + "Loading...");
						goto IL_23b8;
					case "//*[@text='Basic info']":
					{
						Class65 class4 = Class65.smethod_0(ac28BD29_0.FindElements(0, text11, text12).First(), ac28BD29_0.method_28(0, text11, new List<string> { "//*[@text='Edit']" }));
						if (class4 != null)
						{
							ac28BD29_0.E832B991(class4.AA3F9A29());
						}
						goto IL_23b8;
					}
					case "//*[@text='Birthday']/parent::*/child::*[2]/child::*/child::*":
					{
						if (flag9 && !ac28BD29_0.ED9CDB24(text11, "There is a limit to how many times you can change your birthday"))
						{
							string text13 = source8.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
							if (!string.IsNullOrEmpty(text13))
							{
								ac28BD29_0.TapByXPath(text12 + "[1]/child::*", text11);
								ac28BD29_0.TimeDelay(2.0);
								text13 = text13.TrimStart('0');
								if (text13 == "12")
								{
									ac28BD29_0.CE16082B();
									ac28BD29_0.TimeDelay(2.0);
								}
								ac28BD29_0.TapByXPath("//*[@text='" + Common.smethod_61(text13) + "']");
								ac28BD29_0.TimeDelay(1.0);
							}
							string text14 = source7.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
							if (!string.IsNullOrEmpty(text14))
							{
								ac28BD29_0.TapByXPath(text12 + "[2]/child::*");
								ac28BD29_0.TimeDelay(2.0);
								text14 = text14.TrimStart('0');
								if (!ac28BD29_0.TapByXPath("//*[@text='" + text14 + "']"))
								{
									ac28BD29_0.CE16082B(-1, 3);
									ac28BD29_0.TimeDelay(2.0);
									for (int i = 0; i < 3; i++)
									{
										if (!ac28BD29_0.TapByXPath("//*[@text='" + text14 + "']"))
										{
											ac28BD29_0.CE16082B();
											ac28BD29_0.TimeDelay(2.0);
											continue;
										}
										ac28BD29_0.TimeDelay(1.0);
										break;
									}
								}
							}
							string text15 = source9.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
							if (!string.IsNullOrEmpty(text15))
							{
								ac28BD29_0.TapByXPath("//*[@text='Birth Year']/parent::*/child::*[2]/child::*/child::*/child::*");
								ac28BD29_0.TimeDelay(2.0);
								if (!ac28BD29_0.TapByXPath("//*[@text='" + text15 + "']"))
								{
									ac28BD29_0.CE16082B(1, 5);
									ac28BD29_0.TimeDelay(2.0);
									for (int j = 0; j < 5; j++)
									{
										if (!ac28BD29_0.TapByXPath("//*[@text='" + text15 + "']"))
										{
											ac28BD29_0.CE16082B(-1);
											ac28BD29_0.TimeDelay(2.0);
											continue;
										}
										ac28BD29_0.TimeDelay(1.0);
										break;
									}
								}
							}
							ac28BD29_0.method_40(5, "//*[@text='I confirm that I am ']", "");
							method_114(FA95C601, "cBirthday", text13 + "/" + text14 + "/" + text15, "birthday");
							D0A0E5AD += "Birthday-";
						}
						if (flag8)
						{
							ac28BD29_0.method_40(5, "//*[@text='" + text2 + "']", "");
							D0A0E5AD += "Gender-";
						}
						for (int k = 0; k < 3; k++)
						{
							if (ac28BD29_0.TapByXPath("//*[@text='Save']"))
							{
								break;
							}
							ac28BD29_0.CE16082B();
							ac28BD29_0.TimeDelay(2.0);
						}
						ac28BD29_0.EE294CB1(60.0, "//*[@text='Cancel']");
						break;
					}
					}
					break;
					IL_23b8:
					ac28BD29_0.TimeDelay(2.0);
				}
				while (Environment.TickCount - tickCount3 < 300000);
				break;
				IL_252d:
				int num10 = method_22(ac28BD29_0, FA95C601, text3);
				if (num10 != 1)
				{
					if (num10 == 0)
					{
					}
					break;
				}
			}
		}
		goto IL_29a4;
		IL_0475:
		if (!flag2)
		{
			goto IL_093b;
		}
		int num11 = 0;
		int num12 = 6;
		SetStatusAccount(FA95C601, text3 + Language.GetValue("Cập nhật") + " Work...");
		while (ac28BD29_0.ED9CDB24("", "Edit Profile", "Edit Details") || FA905AA0(ac28BD29_0, FA95C601, text3, "fb://profile_edit"))
		{
			bool flag13 = false;
			string text16 = "";
			int tickCount4 = Environment.TickCount;
			while (true)
			{
				text16 = ac28BD29_0.GetPageSource();
				string text17 = ac28BD29_0.FindElement(0, text16, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@text='Edit']", "//*[@text='Add']", "//*[@text='Add work']", "//*[@text='Workplace Name']", "//android.widget.EditText[@text='Select workplace']", "//*[@text='Edit Details']", "//*[@text='Save' or @content-desc='Save'][@enabled='true']" });
				string text18 = text17;
				string text19 = text18;
				uint num6 = HashString.DA8CEBAB(text19);
				if (num6 > 1021549810)
				{
					if (num6 <= 1252544463)
					{
						if (num6 != 1087892284)
						{
							if (num6 == 1252544463 && text19 == "//*[@text='Add work']")
							{
								goto IL_0666;
							}
						}
						else if (text19 == "//*[@text='Save' or @content-desc='Save'][@enabled='true']")
						{
							ac28BD29_0.TapByXPath(text17, text16);
							D0A0E5AD += "Work-";
							flag13 = true;
							goto IL_074a;
						}
					}
					else if (num6 != 1391936344)
					{
						if (num6 != 1810015401)
						{
							if (num6 == 3204427031u && text19 == "//*[@text='Edit']")
							{
								goto IL_0666;
							}
						}
						else if (text19 == "//android.widget.EditText[@text='Select workplace']")
						{
							ac28BD29_0.SendByXPath(text17, source2.OrderBy((string string_0) => Guid.NewGuid()).First());
							ac28BD29_0.TimeDelay(2.0);
							List<string> list2 = ac28BD29_0.FindElements(10, "", "//android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup");
							if (list2.Count > 0)
							{
								if (list2.Count == 1 && ac28BD29_0.ED9CDB24("", "No Results Found"))
								{
									goto IL_093b;
								}
								ac28BD29_0.E832B991(list2.OrderBy((string string_0) => Guid.NewGuid()).First());
							}
							goto IL_074a;
						}
					}
					else if (text19 == "//*[@text='Workplace Name']")
					{
						goto IL_0666;
					}
				}
				else
				{
					if (num6 <= 532719482)
					{
						if (num6 != 281629319)
						{
							if (num6 != 532719482 || !(text19 == "//android.widget.ProgressBar"))
							{
								goto IL_0652;
							}
							SetStatusAccount(FA95C601, text3 + "Loading...");
						}
						else
						{
							if (!(text19 == "//*[@text='Tap to retry']"))
							{
								goto IL_0652;
							}
							if (num11 >= num12)
							{
								break;
							}
							num11++;
							ac28BD29_0.CE16082B(-1);
						}
						goto IL_074a;
					}
					if (num6 != 872652337)
					{
						if (num6 == 1021549810 && text19 == "//*[@text='Add']")
						{
							goto IL_0666;
						}
					}
					else if (text19 == "//*[@text='Edit Details']")
					{
					}
				}
				goto IL_0652;
				IL_0666:
				if ((!flag10 || !(text17 == "//*[@text='Add work']") || !ac28BD29_0.DoesElementExist(0, text16, "//*[starts-with(@text,'Works at')]")) && !flag13)
				{
					if (text17 == "//*[@text='Edit']" || text17 == "//*[@text='Add']")
					{
						Class65 class5 = Class65.smethod_0(ac28BD29_0.FindElements(0, text16, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text16, "//*[@text='Edit']"));
						if (class5 == null)
						{
							class5 = Class65.smethod_0(ac28BD29_0.FindElements(0, text16, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text16, "//*[@text='Add']"));
						}
						if (class5 != null)
						{
							ac28BD29_0.E832B991(class5.AA3F9A29());
						}
						else
						{
							ac28BD29_0.FB3ACF2E();
						}
					}
					else
					{
						ac28BD29_0.TapByXPath(text17, text16);
					}
					goto IL_074a;
				}
				goto IL_093b;
				IL_0652:
				if (!ac28BD29_0.CE16082B())
				{
					goto IL_074a;
				}
				goto IL_08d2;
				IL_074a:
				ac28BD29_0.TimeDelay(2.0);
				if (Environment.TickCount - tickCount4 < 300000)
				{
					continue;
				}
				goto IL_093b;
			}
			break;
			IL_08d2:
			int num13 = method_22(ac28BD29_0, FA95C601, text3);
			if (num13 == 1)
			{
				continue;
			}
			if (num13 != 0)
			{
				break;
			}
			goto IL_093b;
		}
		goto IL_29a4;
		IL_093b:
		if (!flag3)
		{
			goto IL_0dfe;
		}
		int num14 = 0;
		int num15 = 6;
		SetStatusAccount(FA95C601, text3 + Language.GetValue("Cập nhật") + " High School...");
		while (ac28BD29_0.ED9CDB24("", "Edit Profile", "Edit Details") || FA905AA0(ac28BD29_0, FA95C601, text3, "fb://profile_edit"))
		{
			bool flag14 = false;
			string text20 = "";
			int tickCount5 = Environment.TickCount;
			while (true)
			{
				text20 = ac28BD29_0.GetPageSource();
				string text21 = ac28BD29_0.FindElement(0, text20, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@text='Edit']", "//*[@text='Add']", "//*[@text='High School Name (Required)']", "//*[@text='Add a high school' or @text='Add high school']", "//android.widget.EditText[@text='Select school']", "//*[@text='Edit Details']", "//*[@text='Save' or @content-desc='Save'][@enabled='true']" });
				string text22 = text21;
				string text23 = text22;
				uint num6 = HashString.DA8CEBAB(text23);
				if (num6 > 872652337)
				{
					if (num6 <= 1087892284)
					{
						if (num6 != 1021549810)
						{
							if (num6 == 1087892284 && text23 == "//*[@text='Save' or @content-desc='Save'][@enabled='true']")
							{
								ac28BD29_0.TapByXPath(text21, text20);
								D0A0E5AD += "HighSchool-";
								flag14 = true;
								goto IL_0c0d;
							}
						}
						else if (text23 == "//*[@text='Add']")
						{
							goto IL_0a31;
						}
					}
					else if (num6 != 2331951731u)
					{
						if (num6 != 2980637099u)
						{
							if (num6 == 3204427031u && text23 == "//*[@text='Edit']")
							{
								goto IL_0a31;
							}
						}
						else if (text23 == "//*[@text='Add a high school' or @text='Add high school']")
						{
							goto IL_0a31;
						}
					}
					else if (text23 == "//android.widget.EditText[@text='Select school']")
					{
						ac28BD29_0.SendByXPath(text21, source3.OrderBy((string CDAB8D3F) => Guid.NewGuid()).First());
						ac28BD29_0.TimeDelay(2.0);
						List<string> list3 = ac28BD29_0.FindElements(10, "", "//android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup");
						if (list3.Count > 0)
						{
							if (list3.Count == 1 && ac28BD29_0.ED9CDB24("", "No Results Found"))
							{
								goto IL_0dfe;
							}
							ac28BD29_0.E832B991(list3.OrderBy((string DB29A209) => Guid.NewGuid()).First());
						}
						goto IL_0c0d;
					}
				}
				else if (num6 <= 281629319)
				{
					if (num6 != 187204304)
					{
						if (num6 == 281629319 && text23 == "//*[@text='Tap to retry']")
						{
							if (num14 >= num15)
							{
								break;
							}
							num14++;
							ac28BD29_0.CE16082B(-1);
							goto IL_0c0d;
						}
					}
					else if (text23 == "//*[@text='High School Name (Required)']")
					{
						goto IL_0a31;
					}
				}
				else if (num6 != 532719482)
				{
					if (num6 == 872652337 && text23 == "//*[@text='Edit Details']")
					{
					}
				}
				else if (text23 == "//android.widget.ProgressBar")
				{
					SetStatusAccount(FA95C601, text3 + "Loading...");
					goto IL_0c0d;
				}
				if (!ac28BD29_0.CE16082B())
				{
					goto IL_0c0d;
				}
				goto IL_0d95;
				IL_0c0d:
				ac28BD29_0.TimeDelay(2.0);
				if (Environment.TickCount - tickCount5 < 300000)
				{
					continue;
				}
				goto IL_0dfe;
				IL_0a31:
				if ((!flag10 || !(text21 == "//*[@text='Add a high school' or @text='Add high school']") || !ac28BD29_0.DoesElementExist(0, text20, "//*[starts-with(@text,'Studied at')]")) && !flag14)
				{
					if (text21 == "//*[@text='Edit']" || text21 == "//*[@text='Add']")
					{
						Class65 class6 = Class65.smethod_0(ac28BD29_0.FindElements(0, text20, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text20, "//*[@text='Edit']"));
						if (class6 == null)
						{
							class6 = Class65.smethod_0(ac28BD29_0.FindElements(0, text20, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text20, "//*[@text='Add']"));
						}
						if (class6 != null)
						{
							ac28BD29_0.E832B991(class6.AA3F9A29());
						}
						else
						{
							ac28BD29_0.FB3ACF2E();
						}
					}
					else
					{
						ac28BD29_0.TapByXPath(text21, text20);
					}
					goto IL_0c0d;
				}
				goto IL_0dfe;
			}
			break;
			IL_0d95:
			int num16 = method_22(ac28BD29_0, FA95C601, text3);
			if (num16 == 1)
			{
				continue;
			}
			if (num16 != 0)
			{
				break;
			}
			goto IL_0dfe;
		}
		goto IL_29a4;
		IL_1d04:
		if (!flag7)
		{
			goto IL_233f;
		}
		int num17 = 0;
		int num18 = 6;
		SetStatusAccount(FA95C601, text3 + Language.GetValue("Cập nhật") + " Relationship...");
		while (ac28BD29_0.ED9CDB24("", "Edit Profile", "Edit Details") || FA905AA0(ac28BD29_0, FA95C601, text3, "fb://profile_edit"))
		{
			bool flag15 = false;
			bool flag16 = false;
			string text24 = "";
			int tickCount6 = Environment.TickCount;
			while (true)
			{
				text24 = ac28BD29_0.GetPageSource();
				string text25 = ac28BD29_0.FindElement(0, text24, new List<string>
				{
					"//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@text='Edit']", "//*[@text='Add']", "//*[@text='Add a relationship status']", "//*[@text='Relationship Status']", "//*[@text=\"Single\"]", "//*[@text=\"In a relationship\"]", "//*[@text=\"Engaged\"]", "//*[@text=\"Married\"]",
					"//*[@text=\"In a civil union\"]", "//*[@text=\"In a domestic partnership\"]", "//*[@text=\"In an open relationship\"]", "//*[@text=\"It's complicated\"]", "//*[@text=\"Separated\"]", "//*[@text=\"Divorced\"]", "//*[@text=\"Widowed\"]"
				});
				string text26 = text25;
				string text27 = text26;
				uint num6 = HashString.DA8CEBAB(text27);
				if (num6 > 1031124291)
				{
					if (num6 <= 3204427031u)
					{
						if (num6 > 2195122918u)
						{
							if (num6 != 2228260562u)
							{
								if (num6 == 3204427031u && text27 == "//*[@text='Edit']")
								{
									goto IL_1dd1;
								}
							}
							else if (text27 == "//*[@text=\"Widowed\"]")
							{
								goto IL_1f25;
							}
							goto IL_1f11;
						}
						if (num6 != 2079588125)
						{
							if (num6 != 2195122918u || !(text27 == "//*[@text=\"Separated\"]"))
							{
								goto IL_1f11;
							}
						}
						else if (!(text27 == "//*[@text=\"In a civil union\"]"))
						{
							goto IL_1f11;
						}
					}
					else
					{
						if (num6 <= 3468505873u)
						{
							if (num6 != 3252945837u)
							{
								if (num6 == 3468505873u && text27 == "//*[@text='Add a relationship status']")
								{
									ac28BD29_0.TapByXPath(text25, text24);
									goto IL_1fa6;
								}
							}
							else if (text27 == "//*[@text=\"In a domestic partnership\"]")
							{
								goto IL_1f25;
							}
							goto IL_1f11;
						}
						if (num6 != 3876716033u)
						{
							if (num6 != 3937624089u)
							{
								if (num6 != 4217740579u || !(text27 == "//*[@text=\"It's complicated\"]"))
								{
									goto IL_1f11;
								}
							}
							else if (!(text27 == "//*[@text=\"Married\"]"))
							{
								goto IL_1f11;
							}
						}
						else if (!(text27 == "//*[@text=\"Single\"]"))
						{
							goto IL_1f11;
						}
					}
					goto IL_1f25;
				}
				if (num6 <= 532719482)
				{
					if (num6 <= 465737673)
					{
						if (num6 != 281629319)
						{
							if (num6 != 465737673 || !(text27 == "//*[@text='Relationship Status']"))
							{
								goto IL_1f11;
							}
							if (ac28BD29_0.DoesElementExist(0, text24, "//*[@text='Save' or @content-desc='Save']"))
							{
								ac28BD29_0.TapByXPath(text25, text24);
							}
							else
							{
								if (!ac28BD29_0.DoesElementExist(0, text24, "//*[@text=\"" + text + "\"]"))
								{
									for (int l = 0; l < 5; l++)
									{
										if (ac28BD29_0.CE16082B())
										{
											break;
										}
										text24 = "";
										if (ac28BD29_0.C60AEB35(0, ref text24, "//*[@text=\"" + text + "\"]"))
										{
											break;
										}
									}
								}
								if (ac28BD29_0.TapByXPath("//*[@text=\"" + text + "\"]", text24))
								{
									flag16 = true;
								}
							}
						}
						else
						{
							if (!(text27 == "//*[@text='Tap to retry']"))
							{
								goto IL_1f11;
							}
							if (num17 >= num18)
							{
								break;
							}
							num17++;
							ac28BD29_0.CE16082B(-1);
						}
						goto IL_1fa6;
					}
					if (num6 != 525520161)
					{
						if (num6 == 532719482 && text27 == "//android.widget.ProgressBar")
						{
							SetStatusAccount(FA95C601, text3 + "Loading...");
							goto IL_1fa6;
						}
					}
					else if (text27 == "//*[@text=\"In an open relationship\"]")
					{
						goto IL_1f25;
					}
				}
				else
				{
					if (num6 <= 731756576)
					{
						if (num6 != 669693435)
						{
							if (num6 != 731756576 || !(text27 == "//*[@text=\"Engaged\"]"))
							{
								goto IL_1f11;
							}
						}
						else if (!(text27 == "//*[@text=\"In a relationship\"]"))
						{
							goto IL_1f11;
						}
						goto IL_1f25;
					}
					if (num6 != 1021549810)
					{
						if (num6 == 1031124291 && text27 == "//*[@text=\"Divorced\"]")
						{
							goto IL_1f25;
						}
					}
					else if (text27 == "//*[@text='Add']")
					{
						goto IL_1dd1;
					}
				}
				goto IL_1f11;
				IL_1f25:
				if (!flag15)
				{
					if (flag16)
					{
						ac28BD29_0.TapByXPath("//*[@text='Save' or @content-desc='Save'][@enabled='true']", text24);
						flag15 = true;
						D0A0E5AD += "Relationship-";
					}
					else
					{
						Class65 class7 = Class65.smethod_0(ac28BD29_0.FindElements(0, text24, text25).First(), ac28BD29_0.FindElements(0, text24, "//*[@content-desc='Edit']"));
						if (class7 != null)
						{
							ac28BD29_0.E832B991(class7.AA3F9A29());
						}
						else
						{
							ac28BD29_0.TapByXPath(text25, text24);
						}
					}
					goto IL_1fa6;
				}
				goto IL_233f;
				IL_1fa6:
				ac28BD29_0.TimeDelay(2.0);
				if (Environment.TickCount - tickCount6 < 300000)
				{
					continue;
				}
				goto IL_233f;
				IL_1f11:
				if (!ac28BD29_0.CE16082B())
				{
					goto IL_1fa6;
				}
				goto IL_22d6;
				IL_1dd1:
				if (!flag15)
				{
					Class65 class8 = Class65.smethod_0(ac28BD29_0.FindElements(0, text24, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text24, "//*[@text='Edit']"));
					if (class8 == null)
					{
						class8 = Class65.smethod_0(ac28BD29_0.FindElements(0, text24, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text24, "//*[@text='Add']"));
					}
					if (class8 != null)
					{
						ac28BD29_0.E832B991(class8.AA3F9A29());
					}
					else
					{
						ac28BD29_0.FB3ACF2E();
					}
					goto IL_1fa6;
				}
				goto IL_233f;
			}
			break;
			IL_22d6:
			int num19 = method_22(ac28BD29_0, FA95C601, text3);
			if (num19 == 1)
			{
				continue;
			}
			if (num19 != 0)
			{
				break;
			}
			goto IL_233f;
		}
		goto IL_29a4;
		IL_0dfe:
		if (!flag4)
		{
			goto IL_12c4;
		}
		int num20 = 0;
		int num21 = 6;
		SetStatusAccount(FA95C601, text3 + Language.GetValue("Cập nhật") + " College...");
		while (ac28BD29_0.ED9CDB24("", "Edit Profile", "Edit Details") || FA905AA0(ac28BD29_0, FA95C601, text3, "fb://profile_edit"))
		{
			bool flag17 = false;
			string text28 = "";
			int tickCount7 = Environment.TickCount;
			while (true)
			{
				text28 = ac28BD29_0.GetPageSource();
				string text29 = ac28BD29_0.FindElement(0, text28, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@text='Edit']", "//*[@text='Add']", "//*[@text='College Name (Required)']", "//*[@text='Add a college' or @text='Add college']", "//android.widget.EditText[@text='Select school']", "//*[@text='Edit Details']", "//*[@text='Save' or @content-desc='Save'][@enabled='true']" });
				string text30 = text29;
				string text31 = text30;
				uint num6 = HashString.DA8CEBAB(text31);
				if (num6 > 1021549810)
				{
					if (num6 <= 2054847849)
					{
						if (num6 != 1087892284)
						{
							if (num6 == 2054847849 && text31 == "//*[@text='Add a college' or @text='Add college']")
							{
								goto IL_0ef7;
							}
						}
						else if (text31 == "//*[@text='Save' or @content-desc='Save'][@enabled='true']")
						{
							ac28BD29_0.TapByXPath(text29, text28);
							D0A0E5AD += "College-";
							flag17 = true;
							goto IL_10d3;
						}
					}
					else if (num6 != 2331951731u)
					{
						if (num6 != 3079778049u)
						{
							if (num6 == 3204427031u && text31 == "//*[@text='Edit']")
							{
								goto IL_0ef7;
							}
						}
						else if (text31 == "//*[@text='College Name (Required)']")
						{
							goto IL_0ef7;
						}
					}
					else if (text31 == "//android.widget.EditText[@text='Select school']")
					{
						ac28BD29_0.SendByXPath(text29, source4.OrderBy((string string_0) => Guid.NewGuid()).First());
						ac28BD29_0.TimeDelay(2.0);
						List<string> list4 = ac28BD29_0.FindElements(10, "", "//android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup");
						if (list4.Count > 0)
						{
							if (list4.Count == 1 && ac28BD29_0.ED9CDB24("", "No Results Found"))
							{
								goto IL_12c4;
							}
							ac28BD29_0.E832B991(list4.OrderBy((string string_0) => Guid.NewGuid()).First());
						}
						goto IL_10d3;
					}
				}
				else
				{
					if (num6 <= 532719482)
					{
						if (num6 != 281629319)
						{
							if (num6 != 532719482 || !(text31 == "//android.widget.ProgressBar"))
							{
								goto IL_0ff4;
							}
							SetStatusAccount(FA95C601, text3 + "Loading...");
						}
						else
						{
							if (!(text31 == "//*[@text='Tap to retry']"))
							{
								goto IL_0ff4;
							}
							if (num20 >= num21)
							{
								break;
							}
							num20++;
							ac28BD29_0.CE16082B(-1);
						}
						goto IL_10d3;
					}
					if (num6 != 872652337)
					{
						if (num6 == 1021549810 && text31 == "//*[@text='Add']")
						{
							goto IL_0ef7;
						}
					}
					else if (text31 == "//*[@text='Edit Details']")
					{
					}
				}
				goto IL_0ff4;
				IL_0ff4:
				if (!ac28BD29_0.CE16082B())
				{
					goto IL_10d3;
				}
				goto IL_125b;
				IL_10d3:
				ac28BD29_0.TimeDelay(2.0);
				if (Environment.TickCount - tickCount7 < 300000)
				{
					continue;
				}
				goto IL_12c4;
				IL_0ef7:
				if ((!flag10 || !(text29 == "//*[@text='Add a college' or @text='Add college']") || !ac28BD29_0.DoesElementExist(0, text28, "//*[starts-with(@text,'Studied at')]")) && !flag17)
				{
					if (text29 == "//*[@text='Edit']" || text29 == "//*[@text='Add']")
					{
						Class65 class9 = Class65.smethod_0(ac28BD29_0.FindElements(0, text28, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text28, "//*[@text='Edit']"));
						if (class9 == null)
						{
							class9 = Class65.smethod_0(ac28BD29_0.FindElements(0, text28, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text28, "//*[@text='Add']"));
						}
						if (class9 != null)
						{
							ac28BD29_0.E832B991(class9.AA3F9A29());
						}
						else
						{
							ac28BD29_0.FB3ACF2E();
						}
					}
					else
					{
						ac28BD29_0.TapByXPath(text29, text28);
					}
					goto IL_10d3;
				}
				goto IL_12c4;
			}
			break;
			IL_125b:
			int num22 = method_22(ac28BD29_0, FA95C601, text3);
			if (num22 == 1)
			{
				continue;
			}
			if (num22 != 0)
			{
				break;
			}
			goto IL_12c4;
		}
		goto IL_29a4;
		IL_12c4:
		if (!flag5)
		{
			goto IL_17de;
		}
		int num23 = 0;
		int num24 = 6;
		SetStatusAccount(FA95C601, text3 + Language.GetValue("Cập nhật") + " Current City...");
		while (ac28BD29_0.ED9CDB24("", "Edit Profile", "Edit Details") || FA905AA0(ac28BD29_0, FA95C601, text3, "fb://profile_edit"))
		{
			string text32 = "";
			bool flag18 = false;
			string text33 = "";
			int tickCount8 = Environment.TickCount;
			while (true)
			{
				text33 = ac28BD29_0.GetPageSource();
				string text34 = ac28BD29_0.FindElement(0, text33, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@text='Edit']", "//*[@text='Add']", "//*[@text='Add current city']", "//android.widget.TextView[contains(@text,'Lives in')]", "//*[@text='Edit current city']", "//android.widget.EditText[@text='Select current city']" });
				string text35 = text34;
				string text36 = text35;
				uint num6 = HashString.DA8CEBAB(text36);
				if (num6 > 1021549810)
				{
					if (num6 <= 2144658411)
					{
						if (num6 != 1715593925)
						{
							if (num6 == 2144658411 && text36 == "//android.widget.TextView[contains(@text,'Lives in')]")
							{
								if (!flag10 && !flag18)
								{
									Class65 class10 = Class65.smethod_0(ac28BD29_0.FindElements(0, text33, text34).First(), ac28BD29_0.FindElements(0, text33, "//*[@content-desc='Edit']"));
									if (class10 != null)
									{
										ac28BD29_0.E832B991(class10.AA3F9A29());
									}
									goto IL_1526;
								}
								goto IL_17de;
							}
						}
						else if (text36 == "//*[@text='Edit current city']")
						{
							goto IL_148f;
						}
					}
					else if (num6 != 2516121178u)
					{
						if (num6 == 3204427031u && text36 == "//*[@text='Edit']")
						{
							goto IL_13dd;
						}
					}
					else if (text36 == "//*[@text='Add current city']")
					{
						goto IL_148f;
					}
				}
				else
				{
					if (num6 <= 532719482)
					{
						if (num6 != 281629319)
						{
							if (num6 != 532719482 || !(text36 == "//android.widget.ProgressBar"))
							{
								goto IL_147b;
							}
							SetStatusAccount(FA95C601, text3 + "Loading...");
						}
						else
						{
							if (!(text36 == "//*[@text='Tap to retry']"))
							{
								goto IL_147b;
							}
							if (num23 >= num24)
							{
								break;
							}
							num23++;
							ac28BD29_0.CE16082B(-1);
						}
						goto IL_1526;
					}
					if (num6 != 577862615)
					{
						if (num6 == 1021549810 && text36 == "//*[@text='Add']")
						{
							goto IL_13dd;
						}
					}
					else if (text36 == "//android.widget.EditText[@text='Select current city']")
					{
						text32 = source5.OrderBy((string A691599B) => Guid.NewGuid()).First();
						ac28BD29_0.SendByXPath(text34, text32);
						ac28BD29_0.TimeDelay(2.0);
						List<string> list5 = ac28BD29_0.FindElements(10, "", "//android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup");
						if (list5.Count > 0)
						{
							if (list5.Count == 1 && ac28BD29_0.ED9CDB24("", "No Results Found"))
							{
								goto IL_17de;
							}
							ac28BD29_0.E832B991(list5.OrderBy((string string_0) => Guid.NewGuid()).First());
						}
						goto IL_1526;
					}
				}
				goto IL_147b;
				IL_1526:
				ac28BD29_0.TimeDelay(2.0);
				if (Environment.TickCount - tickCount8 < 300000)
				{
					continue;
				}
				goto IL_17de;
				IL_147b:
				if (!ac28BD29_0.CE16082B())
				{
					goto IL_1526;
				}
				goto IL_1775;
				IL_148f:
				if (text32 != "")
				{
					ac28BD29_0.TapByXPath("//*[@text='Save' or @content-desc='Save'][@enabled='true']", text33);
					flag18 = true;
					D0A0E5AD += "Current City-";
				}
				else if (ac28BD29_0.DoesElementExist(0, text33, "//*[@text='Add Current City (Required)']"))
				{
					ac28BD29_0.TapByXPath("//*[@text='Add Current City (Required)']", text33);
				}
				else if (text34 == "//*[@text='Add current city']")
				{
					ac28BD29_0.TapByXPath(text34, text33);
				}
				else if (text34 == "//*[@text='Edit current city']")
				{
					ac28BD29_0.TapByXPath("//*[@content-desc='Remove current city']", text33);
				}
				goto IL_1526;
				IL_13dd:
				if (!flag18)
				{
					Class65 class11 = Class65.smethod_0(ac28BD29_0.FindElements(0, text33, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text33, "//*[@text='Edit']"));
					if (class11 == null)
					{
						class11 = Class65.smethod_0(ac28BD29_0.FindElements(0, text33, "//*[@text='Details']").FirstOrDefault(), ac28BD29_0.FindElements(0, text33, "//*[@text='Add']"));
					}
					if (class11 != null)
					{
						ac28BD29_0.E832B991(class11.AA3F9A29());
					}
					else
					{
						ac28BD29_0.FB3ACF2E();
					}
					goto IL_1526;
				}
				goto IL_17de;
			}
			break;
			IL_1775:
			int num25 = method_22(ac28BD29_0, FA95C601, text3);
			if (num25 == 1)
			{
				continue;
			}
			if (num25 != 0)
			{
				break;
			}
			goto IL_17de;
		}
		goto IL_29a4;
	}

	private int E6A9E6AD(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_1, string E5081336)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		string text = method_117(int_1, "cUid");
		string text2 = ac28BD29_0.AF03B30E().Split('|')[1];
		if (text2 == "")
		{
			text2 = method_117(int_1, "cCookies");
		}
		try
		{
			string text3 = string_0 + Language.GetValue("Đang") + " " + E5081336 + ": ";
			bool flag = f72FAFBC_0.AA824D29("ckbShareBaiLenTuong");
			bool flag2 = f72FAFBC_0.AA824D29("ckbShareBaiLenNhom");
			bool flag3 = f72FAFBC_0.AA824D29("ckbShareNhomNangCao");
			bool flag4 = f72FAFBC_0.AA824D29("ckbChiShareNhomKKD");
			bool flag5 = f72FAFBC_0.AA824D29("ckbUuTienShareNhomNhieuThanhVien");
			bool flag6 = f72FAFBC_0.AA824D29("ckbBackupDanhSachNhom");
			bool flag7 = f72FAFBC_0.AA824D29("ckbKhongShareTrungNhom");
			bool flag8 = f72FAFBC_0.AA824D29("ckbChiShareNhomThuocDanhSach");
			List<string> f1808BA = f72FAFBC_0.EC378D8A("lstNhomTuNhap");
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			int f988D70A = f72FAFBC_0.method_0("nudCountGroupFrom");
			int e234B = f72FAFBC_0.method_0("nudCountGroupTo");
			int num4 = ac28BD29_0.C4B7B817(f988D70A, e234B);
			int minValue = f72FAFBC_0.method_0("nudDelayFrom");
			int num5 = f72FAFBC_0.method_0("nudDelayTo");
			List<string> f1808BA2 = f72FAFBC_0.EC378D8A("txtLinkChiaSe");
			f1808BA2 = Common.RemoveEmptyItems(f1808BA2);
			if (!dictionary_10.ContainsKey(string_1))
			{
				dictionary_10.Add(string_1, new List<string>());
			}
			string text4 = f1808BA2[int_1 % f1808BA2.Count];
			int num6 = f72FAFBC_0.method_0("typeLinkShare");
			if (num6 == 2)
			{
				num6 = 1;
			}
			bool flag9 = f72FAFBC_0.AA824D29("ckbVanBan");
			bool flag10 = f72FAFBC_0.AA824D29("ckbTuDongXoaNoiDung");
			bool flag11 = f72FAFBC_0.AA824D29("ckbTuongTacTruocKhiShare");
			int int_2 = f72FAFBC_0.method_0("nudSoLuongFrom");
			int int_3 = f72FAFBC_0.method_0("nudSoLuongTo");
			bool flag12 = f72FAFBC_0.AA824D29("ckbInteract");
			string text5 = f72FAFBC_0.GetValue("typeReaction");
			bool flag13 = f72FAFBC_0.AA824D29("ckbComment");
			List<string> list = f72FAFBC_0.EC378D8A("txtComment");
			bool bool_ = f72FAFBC_0.AA824D29("ckbBinhLuanNhieuLan");
			int e527819C = f72FAFBC_0.method_0("nudBinhLuanNhieuLanDelayFrom");
			int int_4 = f72FAFBC_0.method_0("nudBinhLuanNhieuLanDelayTo");
			string text6 = "";
			if (flag11)
			{
				SetStatusAccount(int_1, text3 + Language.GetValue("Tương ta\u0301c..."));
				if (num6 == 0)
				{
					ECAC5AB6(int_1, text3, ac28BD29_0, text4, int_2, int_3, flag12, text5, flag13, list, D09FD898: false, bool_, e527819C, int_4, "");
				}
				else
				{
					method_78(int_1, text3, ac28BD29_0, text4, int_2, int_3, flag12, text5, flag13, list, bool_4: false, bool_5: false, "");
				}
			}
			if (!flag)
			{
				goto IL_0b47;
			}
			while (true)
			{
				IL_0a80:
				SetStatusAccount(int_1, string_0 + Language.GetValue("Share Wall..."));
				if (num6 != 0)
				{
					SetStatusAccount(int_1, text3 + "Open post...");
					num3 = EAB1360A(ac28BD29_0, int_1, text3, text4);
					if (num3 != 1)
					{
						break;
					}
					bool flag14 = false;
					int num7 = 600;
					for (int tickCount = Environment.TickCount; Environment.TickCount - tickCount < num7 * 1000; ac28BD29_0.TimeDelay(1.0))
					{
						text6 = "";
						string text7 = ac28BD29_0.CB3C4B8A(0, ref text6, new List<string> { "//*[@text='SHARE' or @content-desc='SHARE']", "//android.widget.EditText", "//android.widget.Toast[@text=\"Posting…\"]" });
						switch (text7)
						{
						case "//android.widget.Toast[@text=\"Posting…\"]":
							goto IL_043f;
						case "//android.widget.EditText":
							goto IL_0458;
						case "//*[@text='SHARE' or @content-desc='SHARE']":
							goto IL_05fe;
						}
						SetStatusAccount(int_1, text3 + "Scroll...");
						if (!ac28BD29_0.CE16082B() || ac28BD29_0.method_68())
						{
							continue;
						}
						switch (method_22(ac28BD29_0, int_1, text3))
						{
						default:
							goto end_IL_005d;
						case 0:
							continue;
						case 1:
							break;
						}
						goto IL_0a80;
						IL_05fe:
						SetStatusAccount(int_1, text3 + "Tap Share...");
						if (flag14)
						{
							break;
						}
						ac28BD29_0.TapByXPath(text7, text6);
						flag14 = true;
						continue;
						IL_043f:
						ac28BD29_0.TimeDelay(1.0);
						continue;
						IL_0458:
						if (!flag14)
						{
							SetStatusAccount(int_1, text3 + "Scroll...");
							if (ac28BD29_0.CE16082B() && ac28BD29_0.method_68())
							{
							}
							continue;
						}
						if (flag9 && C42A3EA1[string_1].Count > 0)
						{
							string string_2 = "";
							if (!flag10)
							{
								string_2 = C42A3EA1[string_1].OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
							}
							else
							{
								lock (C42A3EA1)
								{
									int index = random_0.Next(0, C42A3EA1[string_1].Count);
									string_2 = C42A3EA1[string_1][index];
									C42A3EA1[string_1].RemoveAt(index);
								}
							}
							SetStatusAccount(int_1, text3 + Language.GetValue("Nhập dữ liệu..."));
							ac28BD29_0.SendByXPath(text7, string_2);
							ac28BD29_0.TimeDelay(1.0);
						}
						string text8 = ac28BD29_0.method_28(0, "", new List<string> { "//*[@text='POST' or @content-desc='POST']", "//*[@content-desc='Share Now']" }).FirstOrDefault();
						if (string.IsNullOrEmpty(text8))
						{
							continue;
						}
						SetStatusAccount(int_1, text3 + "Tap Share now...");
						ac28BD29_0.E832B991(text8);
						num++;
						break;
					}
				}
				else
				{
					SetStatusAccount(int_1, text3 + "Open livestream...");
					num3 = DEA54A85(ac28BD29_0, int_1, text3, text4);
					if (num3 != 1)
					{
						break;
					}
					int num8 = 0;
					int num9 = 10;
					int num10 = 600;
					int tickCount2 = Environment.TickCount;
					while (Environment.TickCount - tickCount2 < num10 * 1000)
					{
						text6 = "";
						string text9 = ac28BD29_0.CB3C4B8A(0, ref text6, new List<string> { "//*[@content-desc='SHARE' or @text='SHARE']", "//*[@text='INVITE' or @content-desc='INVITE']", "//*[@content-desc='Write Post']", "//android.widget.EditText", "//*[@content-desc='Play again' or @text='Play again']", "//*[@text='save your login info']" });
						switch (text9)
						{
						default:
						{
							switch (method_22(ac28BD29_0, int_1, text3))
							{
							case 0:
								break;
							case 1:
								goto IL_0a80;
							default:
								goto end_IL_005d;
							}
							List<string> source = ac28BD29_0.method_24(0, text6);
							if (source.Where((string string_0) => !string_0.Contains($"[{ac28BD29_0.method_14()},{ac28BD29_0.method_13()}]")).Count() == 0)
							{
								if (num8 >= num9)
								{
									break;
								}
								num8++;
								ac28BD29_0.method_37(140, 2460);
							}
							goto IL_0a50;
						}
						case "//android.widget.EditText":
						{
							if (flag9 && C42A3EA1[string_1].Count > 0)
							{
								string string_3 = "";
								if (!flag10)
								{
									string_3 = C42A3EA1[string_1].OrderBy((string E6B6C514) => Guid.NewGuid()).FirstOrDefault();
								}
								else
								{
									lock (C42A3EA1)
									{
										int index2 = random_0.Next(0, C42A3EA1[string_1].Count);
										string_3 = C42A3EA1[string_1][index2];
										C42A3EA1[string_1].RemoveAt(index2);
									}
								}
								SetStatusAccount(int_1, text3 + Language.GetValue("Nhập dữ liệu..."));
								ac28BD29_0.SendByXPath(text9, string_3);
								ac28BD29_0.TimeDelay(1.0);
							}
							string text10 = ac28BD29_0.method_28(0, "", new List<string> { "//*[@text='POST' or @content-desc='POST']", "//*[@content-desc='Share Now']" }).FirstOrDefault();
							if (!string.IsNullOrEmpty(text10))
							{
								SetStatusAccount(int_1, text3 + "Tap Share now...");
								ac28BD29_0.E832B991(text10);
								num++;
								break;
							}
							goto IL_0a50;
						}
						case "//*[@text='save your login info']":
							ac28BD29_0.TapByXPath("//android.widget.Button[@text='OK']", text6);
							goto IL_0a50;
						case "//*[@text='INVITE' or @content-desc='INVITE']":
							ac28BD29_0.method_19();
							goto IL_0a50;
						case "//*[@content-desc='Write Post']":
						case "//*[@content-desc='Play again' or @text='Play again']":
							SetStatusAccount(int_1, text3 + "Tap " + Regex.Match(text9, "'(.*?)'").Groups[1].Value + "...");
							ac28BD29_0.TapByXPath(text9, text6);
							goto IL_0a50;
						case "//*[@content-desc='SHARE' or @text='SHARE']":
							{
								if (num8 >= num9)
								{
									break;
								}
								num8++;
								SetStatusAccount(int_1, text3 + "Tap " + Regex.Match(text9, "'(.*?)'").Groups[1].Value + "...");
								ac28BD29_0.TapByXPath(text9, text6);
								goto IL_0a50;
							}
							IL_0a50:
							ac28BD29_0.TimeDelay(1.0);
							continue;
						}
						break;
					}
				}
				SetStatusAccount(int_1, text3 + "Share wall done, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue, num5 + 1));
				goto IL_0b47;
			}
			goto end_IL_005d;
			IL_0b47:
			List<string> list2;
			bool flag15;
			if (flag2)
			{
				list2 = new List<string>();
				flag15 = false;
				if (!flag3)
				{
					goto IL_1c3b;
				}
				int num11 = 0;
				while (true)
				{
					if (num11 < 2)
					{
						if (num11 == 1)
						{
							num3 = method_22(ac28BD29_0, int_1, string_0);
							if (num3 != 0 && num3 != 1)
							{
								break;
							}
						}
						bool flag16 = true;
						List<string> list3 = new List<string>();
						if (flag6 && File.Exists("backupgroup\\" + text + ".txt"))
						{
							list3 = Common.E00852A6("backupgroup\\" + text + ".txt");
							if (list3.Count > 0)
							{
								string[] array = list3[0].Split('|');
								flag16 = array.Length < 4 || !new string[2] { "true", "false" }.Contains(array[3].ToLower());
							}
						}
						if (flag16)
						{
							SetStatusAccount(int_1, string_0 + Language.GetValue("Scan group..."));
							list3 = EA98BF20.smethod_1(text2, ac28BD29_0.Proxy, ac28BD29_0.int_1, E18D752E: true);
						}
						if (list3.Count <= 0)
						{
							goto IL_0dab;
						}
						if (flag6)
						{
							File.WriteAllLines("backupgroup\\" + text + ".txt", list3);
						}
						list2 = ((!flag4) ? list3.Select((string EA0E5126) => EA0E5126).ToList() : list3.Where((string string_0) => string_0.Split('|')[3].ToLower() == "false").ToList());
						if (flag5)
						{
							list2.Sort((string C212768F, string E818241D) => int.Parse(E818241D.Split('|')[2]).CompareTo(int.Parse(C212768F.Split('|')[2])));
						}
						else
						{
							list2 = list2.OrderBy((string string_0) => Guid.NewGuid()).ToList();
						}
						if (list2.Count <= 0)
						{
							if (flag8)
							{
								for (int i = 0; i < list2.Count; i++)
								{
									string item = list2[i].Split('|')[0];
									if (!f1808BA.Contains(item))
									{
										list2.RemoveAt(i--);
									}
								}
							}
							goto IL_0dab;
						}
					}
					if ((flag15 = flag4 || flag5 || flag7) && list2.Count == 0)
					{
						break;
					}
					goto IL_1c3b;
					IL_0dab:
					num11++;
				}
			}
			goto end_IL_005d;
			IL_1c3b:
			while (true)
			{
				IL_1c3b_2:
				SetStatusAccount(int_1, string_0 + "Share Groups...");
				if (num6 != 0)
				{
					List<string> list4 = new List<string>();
					string text11 = "";
					SetStatusAccount(int_1, text3 + "Open post...");
					num3 = EAB1360A(ac28BD29_0, int_1, text3, text4);
					if (num3 != 1)
					{
						break;
					}
					bool flag17 = false;
					bool flag18 = false;
					int num12 = 600;
					int tickCount3 = Environment.TickCount;
					while (Environment.TickCount - tickCount3 < num12 * 1000)
					{
						text6 = "";
						string text12 = ac28BD29_0.CB3C4B8A(0, ref text6, new List<string> { "//*[@text='SHARE' or @content-desc='SHARE']", "//android.view.ViewGroup[@content-desc='Share to a group']", "//*[@content-desc='Share to a community']", "//android.widget.TextView[@text='Choose group']", "//android.widget.EditText", "//android.widget.Toast[@text=\"Posting…\"]" });
						switch (text12)
						{
						default:
							SetStatusAccount(int_1, text3 + $"{num2}/{num4}, Scroll...");
							if (ac28BD29_0.CE16082B() && !ac28BD29_0.method_68())
							{
								switch (method_22(ac28BD29_0, int_1, text3))
								{
								default:
									goto end_IL_005d;
								case 0:
									goto IL_1510;
								case 1:
									break;
								}
								goto IL_1c3b_2;
							}
							goto IL_1510;
						case "//android.widget.Toast[@text=\"Posting…\"]":
							ac28BD29_0.TimeDelay(1.0);
							goto IL_1510;
						case "//android.widget.EditText":
							if (!flag17)
							{
								SetStatusAccount(int_1, text3 + $"{num2}/{num4}, Scroll...");
								if (ac28BD29_0.CE16082B() && ac28BD29_0.method_68())
								{
								}
							}
							else if (!flag18)
							{
								List<string> list6 = ac28BD29_0.FindElements(0, "", "//android.widget.HorizontalScrollView/android.view.ViewGroup/android.view.ViewGroup");
								if (list6.Count > 1)
								{
									ac28BD29_0.method_52(list6.Last(), list6.First());
								}
							}
							else
							{
								if (flag9 && C42A3EA1[string_1].Count > 0)
								{
									string string_4 = "";
									if (!flag10)
									{
										string_4 = C42A3EA1[string_1].OrderBy((string CC03DA28) => Guid.NewGuid()).FirstOrDefault();
									}
									else
									{
										lock (C42A3EA1)
										{
											int index3 = random_0.Next(0, C42A3EA1[string_1].Count);
											string_4 = C42A3EA1[string_1][index3];
											C42A3EA1[string_1].RemoveAt(index3);
										}
									}
									SetStatusAccount(int_1, text3 + $"{num2}/{num4} " + Language.GetValue("Nhập dữ liệu..."));
									ac28BD29_0.SendByXPath(text12, string_4);
									ac28BD29_0.TimeDelay(1.0);
								}
								string text13 = ac28BD29_0.method_28(0, "", new List<string> { "//*[@content-desc='POST']" }).FirstOrDefault();
								if (!string.IsNullOrEmpty(text13))
								{
									SetStatusAccount(int_1, text3 + $"{num2}/{num4}, Tap Post...");
									ac28BD29_0.E832B991(text13);
									num2++;
									if (num2 >= num4)
									{
										break;
									}
									SetStatusAccount(int_1, text3 + $"{num2}/{num4}, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue, num5 + 1));
								}
							}
							goto IL_1510;
						case "//android.widget.TextView[@text='Choose group']":
							do
							{
								IL_1432:
								if (!flag15)
								{
									goto IL_1242;
								}
								if (list2.Count == 0)
								{
									break;
								}
								string item2 = list2[0].Split('|')[0];
								text11 = list2[0].Split('|')[1];
								list2.RemoveAt(0);
								if (flag7)
								{
									lock (dictionary_10)
									{
										if (!dictionary_10[string_1].Contains(item2))
										{
											dictionary_10[string_1].Add(item2);
											goto IL_1403;
										}
									}
									goto IL_1432;
								}
								goto IL_1403;
								IL_1403:
								ac28BD29_0.SendByXPath("//android.widget.EditText", text11);
								ac28BD29_0.TimeDelay(2.0);
								goto IL_1242;
								IL_1242:
								text11 = "";
								for (int j = 0; j < 30; ac28BD29_0.TimeDelay(1.0), j++)
								{
									text6 = ac28BD29_0.GetPageSource();
									List<string> list5 = ac28BD29_0.method_23(text6, "//android.widget.ListView/android.widget.Button/android.view.ViewGroup", "content-desc");
									if (list5.Count > 0)
									{
										text11 = (from string_02 in list5.Except(list4)
											orderby Guid.NewGuid()
											select string_02).FirstOrDefault();
										if (!string.IsNullOrEmpty(text11))
										{
											break;
										}
										SetStatusAccount(int_1, text3 + $"{num2}/{num4}, Scroll...");
										if (!ac28BD29_0.CE16082B() || ac28BD29_0.method_68())
										{
											continue;
										}
										goto IL_1c73;
									}
									if (!ac28BD29_0.DoesElementExist(0, text6, "//*[@text='No Groups']"))
									{
										continue;
									}
									goto IL_1356;
								}
								goto IL_143e;
								IL_1356:;
							}
							while (flag15);
							break;
						case "//android.view.ViewGroup[@content-desc='Share to a group']":
						case "//*[@content-desc='Share to a community']":
							SetStatusAccount(int_1, text3 + $"{num2}/{num4}, Tap Share to group...");
							ac28BD29_0.TapByXPath(text12, text6);
							flag18 = true;
							goto IL_1510;
						case "//*[@text='SHARE' or @content-desc='SHARE']":
							{
								SetStatusAccount(int_1, text3 + $"{num2}/{num4}, Tap Share...");
								ac28BD29_0.TapByXPath(text12, text6);
								flag17 = true;
								goto IL_1510;
							}
							IL_143e:
							if (string.IsNullOrEmpty(text11))
							{
								break;
							}
							list4.Add(text11);
							if (ac28BD29_0.method_44(0, text11, text6))
							{
								SetStatusAccount(int_1, text3 + $"{num2}/{num4}, Tap group...");
							}
							goto IL_1510;
							IL_1510:
							ac28BD29_0.TimeDelay(1.0);
							continue;
						}
						break;
					}
				}
				else
				{
					SetStatusAccount(int_1, text3 + "Open livestream...");
					num3 = DEA54A85(ac28BD29_0, int_1, text3, text4);
					if (num3 != 1)
					{
						break;
					}
					int num13 = 0;
					int num14 = 10;
					int num15 = 600;
					for (int tickCount4 = Environment.TickCount; Environment.TickCount - tickCount4 < num15 * 1000; ac28BD29_0.TimeDelay(1.0))
					{
						text6 = "";
						string text14 = ac28BD29_0.CB3C4B8A(0, ref text6, new List<string> { "//*[@content-desc='SHARE']", "//*[@text='INVITE' or @content-desc='INVITE']", "//android.widget.ImageButton[@content-desc='Share to Group']", "//*[@content-desc='Share to a community']", "//android.widget.EditText", "//*[@content-desc='Play again' or @text='Play again']", "//*[@text='save your login info']" });
						string text15 = text14;
						string text16 = text15;
						uint num16 = HashString.DA8CEBAB(text16);
						if (num16 > 1835260571)
						{
							if (num16 <= 3206045620u)
							{
								if (num16 != 1964222373)
								{
									if (num16 == 3206045620u && text16 == "//*[@text='INVITE' or @content-desc='INVITE']")
									{
										ac28BD29_0.method_19();
										continue;
									}
								}
								else if (text16 == "//android.widget.EditText")
								{
									if (flag9 && C42A3EA1[string_1].Count > 0)
									{
										string string_5 = "";
										if (!flag10)
										{
											string_5 = C42A3EA1[string_1].OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
										}
										else
										{
											lock (C42A3EA1)
											{
												int index4 = random_0.Next(0, C42A3EA1[string_1].Count);
												string_5 = C42A3EA1[string_1][index4];
												C42A3EA1[string_1].RemoveAt(index4);
											}
										}
										SetStatusAccount(int_1, text3 + $"{num2}/{num4} " + Language.GetValue("Nhập dữ liệu..."));
										ac28BD29_0.SendByXPath(text14, string_5);
										ac28BD29_0.TimeDelay(1.0);
									}
									int num17 = 0;
									while (num2 < num4)
									{
										num17++;
										if (num17 % 6 != 0 || method_22(ac28BD29_0, int_1, string_0) == 0)
										{
											if (!flag15)
											{
												goto IL_198d;
											}
											while (list2.Count != 0)
											{
												string item3 = list2[0].Split('|')[0];
												string string_6 = list2[0].Split('|')[1];
												list2.RemoveAt(0);
												if (flag7)
												{
													lock (dictionary_10)
													{
														if (dictionary_10[string_1].Contains(item3))
														{
															continue;
														}
														dictionary_10[string_1].Add(item3);
														goto IL_1963;
													}
												}
												goto IL_1963;
												IL_1963:
												ac28BD29_0.SendByXPath("(//android.widget.EditText)[2]", string_6);
												ac28BD29_0.TimeDelay(2.0);
												goto IL_198d;
											}
										}
										goto end_IL_005d;
										IL_198d:
										text6 = "";
										List<string> list7 = ac28BD29_0.method_29(0, ref text6, new List<string> { "//android.widget.Button[@text='SHARE']", "//*[@content-desc='POST']" });
										if (list7.Count > 0)
										{
											SetStatusAccount(int_1, text3 + $"{num2}/{num4}, Tap Share...");
											ac28BD29_0.E832B991(list7.smethod_8());
											num2++;
											if (num2 < num4)
											{
												SetStatusAccount(int_1, text3 + $"{num2}/{num4}, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue, num5 + 1));
												continue;
											}
											goto IL_1c73;
										}
										if (!ac28BD29_0.DoesElementExist(0, text6, "//*[@text='INVITE' or @content-desc='INVITE']"))
										{
											if (flag15)
											{
												continue;
											}
											SetStatusAccount(int_1, text3 + $"{num2}/{num4}, Scroll...");
											if (!ac28BD29_0.CE16082B())
											{
												continue;
											}
											goto IL_1ac2;
										}
										ac28BD29_0.method_19();
										break;
									}
									continue;
								}
								goto IL_1b2c;
							}
							if (num16 != 3477674470u)
							{
								if (num16 != 3974476160u || !(text16 == "//*[@content-desc='Play again' or @text='Play again']"))
								{
									goto IL_1b2c;
								}
							}
							else if (!(text16 == "//android.widget.ImageButton[@content-desc='Share to Group']"))
							{
								goto IL_1b2c;
							}
							goto IL_1ba0;
						}
						if (num16 != 815715068)
						{
							if (num16 != 1094531760)
							{
								if (num16 == 1835260571 && text16 == "//*[@content-desc='Share to a community']")
								{
									goto IL_1ba0;
								}
							}
							else if (text16 == "//*[@text='save your login info']")
							{
								ac28BD29_0.TapByXPath("//android.widget.Button[@text='OK']", text6);
								continue;
							}
							goto IL_1b2c;
						}
						if (!(text16 == "//*[@content-desc='SHARE']"))
						{
							goto IL_1b2c;
						}
						if (num13 < num14)
						{
							num13++;
							SetStatusAccount(int_1, text3 + string.Format("{0}/{1} Tap {2}...", num2, num4, Regex.Match(text14, "'(.*?)'").Groups[1].Value));
							ac28BD29_0.TapByXPath(text14, text6);
							continue;
						}
						goto end_IL_005d;
						IL_1ac2:
						if (ac28BD29_0.method_68())
						{
							continue;
						}
						goto IL_1c23;
						IL_1b2c:
						List<string> source2 = ac28BD29_0.method_24(0, text6);
						if (source2.Where((string string_0) => !string_0.Contains($"[{ac28BD29_0.method_14()},{ac28BD29_0.method_13()}]")).Count() != 0)
						{
							continue;
						}
						if (num13 < num14)
						{
							num13++;
							ac28BD29_0.method_37(140, 2460);
							continue;
						}
						goto end_IL_005d;
						IL_1ba0:
						SetStatusAccount(int_1, text3 + string.Format("{0}/{1} Tap {2}...", num2, num4, Regex.Match(text14, "'(.*?)'").Groups[1].Value));
						ac28BD29_0.TapByXPath(text14, text6);
					}
				}
				goto IL_1c73;
				IL_1c73:
				SetStatusAccount(int_1, text3 + "Share group done, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue, num5 + 1));
				break;
				IL_1c23:
				switch (method_22(ac28BD29_0, int_1, text3))
				{
				case 1:
					continue;
				default:
					goto end_IL_005d;
				case 0:
					break;
				}
				goto IL_1c73;
			}
			end_IL_005d:;
		}
		catch
		{
		}
		return num + num2;
	}

	private int B6BA8881(int int_1, string BC9521AC, AC28BD29 B507729D, JSON_Settings f72FAFBC_0, string string_0)
	{
		int result = 0;
		try
		{
			string text = BC9521AC + Language.GetValue("Đang") + " " + string_0 + ": ";
			List<string> list = f72FAFBC_0.EC378D8A("txtUid");
			int f988D70A = f72FAFBC_0.method_0("nudSoLuongFrom");
			int e234B = f72FAFBC_0.method_0("nudSoLuongTo");
			string text2 = list[int_1 % list.Count];
			int num = 0;
			int num2 = B507729D.C4B7B817(f988D70A, e234B);
			SetStatusAccount(int_1, text + "Go to Page " + text2 + "...");
			if (text2.StartsWith("1000"))
			{
				if (FA905AA0(B507729D, int_1, text, "fb://profile/" + text2) && B507729D.method_40(10, "//*[@content-desc='More']", ""))
				{
					B507729D.TimeDelay(2.0);
					if (B507729D.BD33F0BA("dataimage/invitefriends", null, 10))
					{
						B507729D.TimeDelay(2.0);
						if (B507729D.BD33F0BA("dataimage/selectall", null, 10))
						{
							B507729D.TimeDelay(2.0);
							if (B507729D.BD33F0BA("dataimage/sendinvites", null, 10))
							{
								goto IL_0311;
							}
						}
					}
				}
			}
			else if (FA905AA0(B507729D, int_1, text, "fb://page/" + text2 + "/invite_friends_to_like_page"))
			{
				SetStatusAccount(int_1, text + "Find checkbox...");
				num++;
				List<string> list2 = B507729D.FindElements(0, "", "//android.widget.CheckBox[@checked='false']");
				SetStatusAccount(int_1, text + "Find checkbox: " + list2.Count);
				if (list2.Count != 0)
				{
					for (int i = 0; i < num2; i++)
					{
						if (list2.Count > 1)
						{
							string text3 = list2.First();
							list2.Remove(text3);
							SetStatusAccount(int_1, text + $"{i + 1}/{num2}, Tap checkbox...");
							B507729D.E832B991(text3);
							B507729D.method_54(0.5, 1.0);
							continue;
						}
						SetStatusAccount(int_1, text + $"{i + 1}/{num2}, Scroll...");
						if (B507729D.CE16082B())
						{
							break;
						}
						i--;
						SetStatusAccount(int_1, text + $"{i + 1}/{num2}, Find checkbox...");
						list2 = B507729D.FindElements(0, "", "//android.widget.CheckBox[@checked='false']");
					}
					SetStatusAccount(int_1, text + "Tap Invite...");
					if (B507729D.method_40(3, "//android.widget.ImageView[@content-desc=\"Invite selected friends\"]", ""))
					{
						goto IL_0311;
					}
				}
			}
			goto end_IL_0002;
			IL_0311:
			SetStatusAccount(int_1, text + "Tap Invite, " + Language.GetValue("đợi") + " {time}s...", 3);
			SetStatusAccount(int_1, text + "Loading...");
			B507729D.method_30(5);
			end_IL_0002:;
		}
		catch
		{
		}
		return result;
	}

	private int method_42(int int_1, string string_0, AC28BD29 BAB9CA30, JSON_Settings f72FAFBC_0, string D53CF8B4)
	{
		string text = f72FAFBC_0.EC378D8A("txtIdGroup").smethod_8();
		f72FAFBC_0.method_0("typeInvite");
		int f988D70A = f72FAFBC_0.method_0("nudSoLuongFrom");
		int e234B = f72FAFBC_0.method_0("nudSoLuongTo");
		int minValue = f72FAFBC_0.method_0("nudDelayFrom");
		int num = f72FAFBC_0.method_0("nudDelayTo");
		int result = 1;
		int num2 = 0;
		int num3 = BAB9CA30.C4B7B817(f988D70A, e234B);
		try
		{
			string text2 = string_0 + Language.GetValue("Đang") + " " + D53CF8B4 + ": ";
			SetStatusAccount(int_1, text2 + "Go to Group " + text + "...");
			if (FA905AA0(BAB9CA30, int_1, text2, "fb://group/" + text))
			{
				BAB9CA30.FB3ACF2E(-1);
				BAB9CA30.TimeDelay(1.0);
				SetStatusAccount(int_1, text2 + "Find Invite Members...");
				BAB9CA30.method_40(10, "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]", "");
				SetStatusAccount(int_1, text2 + "Tap Invite Members...");
				SetStatusAccount(int_1, text2 + "Find Invite...");
				List<string> list = BAB9CA30.FindElements(3, "", "//android.view.ViewGroup[@content-desc=\"Invite\"]");
				if (list.Count > 0)
				{
					string text3 = "";
					for (int i = 0; i < num3 + 10; i++)
					{
						if (list.Count == 0)
						{
							SetStatusAccount(int_1, text2 + $"({num2}/{num3}), Scroll...");
							if (BAB9CA30.CE16082B())
							{
								break;
							}
							SetStatusAccount(int_1, text2 + $"({num2}/{num3}), Find Invite...");
							list = BAB9CA30.FindElements(3, "", "//android.view.ViewGroup[@content-desc=\"Invite\"]");
							if (list.Count == 0)
							{
								break;
							}
						}
						text3 = list.LastOrDefault();
						list.Remove(text3);
						SetStatusAccount(int_1, text2 + $"({num2}/{num3}), Tap Invite...");
						BAB9CA30.E832B991(text3);
						num2++;
						if (num2 < num3)
						{
							SetStatusAccount(int_1, text2 + $"({num2}/{num3}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue, num + 1));
							continue;
						}
						SetStatusAccount(int_1, text2 + $"({num2}/{num3}), Done!");
						break;
					}
				}
			}
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	public int method_43(int int_1, string AD1A61B2, AC28BD29 ac28BD29_0, JSON_Settings EF026E22, string string_0)
	{
		int minValue = EF026E22.method_0("nudSoLuongFrom");
		int num = EF026E22.method_0("nudSoLuongTo");
		int minValue2 = EF026E22.method_0("nudDelayFrom");
		int num2 = EF026E22.method_0("nudDelayTo");
		int num3 = EF026E22.method_0("typeRoiNhom");
		bool flag = EF026E22.AA824D29("ckbDieuKienKiemDuyet");
		bool flag2 = EF026E22.AA824D29("ckbDieuKienThanhVien");
		int F6A8F1B8 = EF026E22.method_0("nudThanhVienToiDa");
		bool flag3 = EF026E22.AA824D29("ckbDieuKienTuKhoa");
		List<string> list_0 = EF026E22.EC378D8A("txtTuKhoa");
		List<string> list = EF026E22.EC378D8A("txtIDNhomGiuLai");
		int num4 = 0;
		int num5 = random_0.Next(minValue, num + 1);
		try
		{
			string text = AD1A61B2 + Language.GetValue("Đang") + " " + string_0 + ": ";
			if (num3 == 0 && list.Count == 0)
			{
				ac28BD29_0.method_69("fb://groups_targeted_tab");
				if (ac28BD29_0.method_40(10, "//*[@content-desc='Settings']", ""))
				{
					while (true)
					{
						SetStatusAccount(int_1, text + $"({num4}/{num5})...");
						bool flag4 = false;
						while (true)
						{
							string string_ = "";
							string text2 = ac28BD29_0.CB3C4B8A(10, ref string_, new List<string> { "//*[starts-with(@content-desc,'Membership')]", "//*[starts-with(@content-desc,\"You're a member of\")]", "(//*[@text='LEAVE GROUP'])[last()]" });
							if (!(text2 == ""))
							{
								if (text2 != "")
								{
									ac28BD29_0.TapByXPath(text2, string_);
									if (text2 == "(//*[@text='LEAVE GROUP'])[last()]")
									{
										flag4 = true;
										break;
									}
								}
							}
							else
							{
								if (!ac28BD29_0.DoesElementExist(0, "", "//android.widget.ProgressBar"))
								{
									break;
								}
								ac28BD29_0.method_19();
							}
						}
						if (flag4)
						{
							num4++;
							if (num4 < num5)
							{
								SetStatusAccount(int_1, text + $"({num4}/{num5}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
								ac28BD29_0.method_19();
								continue;
							}
							SetStatusAccount(int_1, text + $"({num4}/{num5}), Done!");
							break;
						}
						break;
					}
				}
			}
			else
			{
				SetStatusAccount(int_1, text + "Scan groups...");
				string eF90C = ac28BD29_0.AF03B30E().Split('|')[1];
				List<string> source = EA98BF20.smethod_1(eF90C, ac28BD29_0.Proxy, ac28BD29_0.int_1, flag);
				if (num3 == 0)
				{
					source = source.Select((string string_0) => string_0.Split('|')[0]).ToList();
				}
				else
				{
					List<string> list2 = new List<string>();
					if (flag)
					{
						list2 = (from BF85282D in source
							where BF85282D.Split('|')[3].ToLower() == "true"
							select BF85282D into string_04
							select string_04.Split('|')[0]).ToList();
					}
					List<string> collection = new List<string>();
					if (flag2)
					{
						collection = (from F0153208 in source
							where Convert.ToInt32(F0153208.Split('|')[2]) < F6A8F1B8
							select F0153208 into D0B74A99
							select D0B74A99.Split('|')[0]).ToList();
					}
					List<string> collection2 = new List<string>();
					if (flag3)
					{
						list_0 = list_0.ConvertAll((string string_0) => string_0.ToLower());
						collection2 = (from string_05 in source
							where method_50(string_05.Split('|')[1], list_0)
							select string_05.Split('|')[0]).ToList();
					}
					list2.AddRange(collection);
					list2.AddRange(collection2);
					source = list2.Distinct().ToList();
				}
				if (list.Count > 0)
				{
					source = source.Except(list).ToList();
				}
				SetStatusAccount(int_1, text + "Scan groups: " + source.Count);
				string text3 = "";
				while (num4 < num5 && source.Count != 0)
				{
					text3 = source[random_0.Next(0, source.Count)];
					source.Remove(text3);
					while (true)
					{
						SetStatusAccount(int_1, text + $"({num4}/{num5}), Go to Group {text3}...");
						if (!FA905AA0(ac28BD29_0, int_1, text, "fb://group/" + text3))
						{
							break;
						}
						SetStatusAccount(int_1, text + $"({num4}/{num5}), " + Language.GetValue("Rời nhóm") + "...");
						string text4 = "";
						int num6 = 0;
						int num7 = 6;
						int tickCount = Environment.TickCount;
						do
						{
							text4 = ac28BD29_0.GetPageSource();
							string text5 = ac28BD29_0.FindElement(0, text4, new List<string>
							{
								"//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='Reload page']", "//*[@content-desc='Delete Invite' or @text='Delete Invite']", "//*[starts-with(@content-desc, 'joined')]", "//*[starts-with(@content-desc, 'followed')]", "//*[starts-with(@content-desc,'Leave ') or starts-with(@text,'Leave ')]", "//*[starts-with(@content-desc,'Unfollow ') or starts-with(@text,'Unfollow ')]", "//*[starts-with(@content-desc,'You have left this group')]", "//*[starts-with(@content-desc, 'Join ')]",
								"//*[@content-desc='Follow group']", "//*[@content-desc='manage group']"
							});
							string text6 = text5;
							string text7 = text6;
							uint num8 = HashString.DA8CEBAB(text7);
							if (num8 > 1390486005)
							{
								if (num8 <= 2271211187u)
								{
									if (num8 != 1591760391)
									{
										if (num8 != 1727591820)
										{
											if (num8 == 2271211187u && text7 == "//*[@content-desc='Reload page']")
											{
												if (num6 >= num7)
												{
													break;
												}
												num6++;
												SetStatusAccount(int_1, text + $"({num4}/{num5}), " + "Tap " + ac28BD29_0.method_105(text5) + "...");
												ac28BD29_0.TapByXPath(text5, text4);
												goto IL_0759;
											}
										}
										else if (text7 == "//*[starts-with(@content-desc,'Leave ') or starts-with(@text,'Leave ')]")
										{
											goto IL_0617;
										}
									}
									else if (text7 == "//*[@content-desc='Follow group']")
									{
										break;
									}
								}
								else if (num8 != 2686990081u)
								{
									if (num8 != 3403591058u)
									{
										if (num8 == 3938925310u && text7 == "//*[starts-with(@content-desc, 'joined')]")
										{
											goto IL_0680;
										}
									}
									else if (text7 == "//*[starts-with(@content-desc,'You have left this group')]")
									{
										break;
									}
								}
								else if (text7 == "//*[starts-with(@content-desc, 'Join ')]")
								{
									break;
								}
							}
							else if (num8 <= 532719482)
							{
								if (num8 != 281629319)
								{
									if (num8 != 313138500)
									{
										if (num8 == 532719482 && text7 == "//android.widget.ProgressBar")
										{
											SetStatusAccount(int_1, text + "Loading...");
											goto IL_0759;
										}
									}
									else if (text7 == "//*[starts-with(@content-desc,'Unfollow ') or starts-with(@text,'Unfollow ')]")
									{
										goto IL_0617;
									}
								}
								else if (text7 == "//*[@text='Tap to retry']")
								{
									if (num6 >= num7)
									{
										break;
									}
									num6++;
									ac28BD29_0.CE16082B(-1);
									goto IL_0759;
								}
							}
							else if (num8 != 643667242)
							{
								if (num8 != 1145824053)
								{
									if (num8 == 1390486005 && text7 == "//*[starts-with(@content-desc, 'followed')]")
									{
										goto IL_0680;
									}
								}
								else if (text7 == "//*[@content-desc='manage group']")
								{
									break;
								}
							}
							else if (text7 == "//*[@content-desc='Delete Invite' or @text='Delete Invite']")
							{
								goto IL_0680;
							}
							if (!ac28BD29_0.ED9CDB24(text4, "An error occurred leaving this group, please try again"))
							{
								SetStatusAccount(int_1, text + $"({num4}/{num5}), " + "Scroll...");
								if (!ac28BD29_0.CE16082B())
								{
									goto IL_0759;
								}
								goto IL_093f;
							}
							goto end_IL_00cb;
							IL_0759:
							ac28BD29_0.TimeDelay(2.0);
							continue;
							IL_0680:
							SetStatusAccount(int_1, text + $"({num4}/{num5}), " + "Tap " + ac28BD29_0.method_105(text5) + "...");
							ac28BD29_0.TapByXPath(text5, text4);
							goto IL_0759;
							IL_0617:
							ac28BD29_0.E832B991(ac28BD29_0.FindElements(0, text4, text5).Last());
							goto IL_0759;
						}
						while (Environment.TickCount - tickCount < 60000);
						goto IL_09a3;
						IL_093f:
						int num9 = method_22(ac28BD29_0, int_1, text);
						if (num9 == 1)
						{
							continue;
						}
						if (num9 != 0)
						{
							break;
						}
						goto IL_09a3;
						IL_09a3:
						num4++;
						if (num4 < num5)
						{
							SetStatusAccount(int_1, text + $"({num4}/{num5}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
							goto IL_09f9;
						}
						SetStatusAccount(int_1, text + $"({num4}/{num5}), Done!");
						break;
					}
					break;
					IL_09f9:;
				}
			}
			end_IL_00cb:;
		}
		catch
		{
		}
		return num4;
	}

	public int E8BE5A8E(int A29893BD, string string_0, AC28BD29 CC911D88, JSON_Settings f72FAFBC_0, string B23E1799)
	{
		string string_ = f72FAFBC_0.GetValue("txtLinkEvent");
		bool flag = f72FAFBC_0.AA824D29("ckbQuanTam");
		bool flag2 = f72FAFBC_0.AA824D29("ckbThamGia");
		bool flag3 = f72FAFBC_0.AA824D29("ckbMoiBanBe");
		int minValue = f72FAFBC_0.method_0("nudMoiBanBeFrom", 1);
		int num = f72FAFBC_0.method_0("nudMoiBanBeTo", 1);
		int minValue2 = f72FAFBC_0.method_0("nudDelayFrom", 3);
		int num2 = f72FAFBC_0.method_0("nudDelayTo", 5);
		int num3 = 0;
		try
		{
			int num4 = random_0.Next(minValue, num + 1);
			string text = string_0 + Language.GetValue("Đang") + " " + B23E1799 + ": ";
			SetStatusAccount(A29893BD, text + "Open events...");
			if (FA905AA0(CC911D88, A29893BD, text, string_))
			{
				int num5 = 0;
				int num6 = 3;
				int tickCount = Environment.TickCount;
				int num7 = 300;
				while (true)
				{
					string text2 = CC911D88.GetPageSource();
					string text3 = CC911D88.FindElement(0, text2, new List<string> { "//*[@content-desc='Event Ended']", "//*[@content-desc='Interested']", "//*[@content-desc='Share']", "//*[@content-desc='Invite']", "//*[@content-desc='Add event']" });
					switch (text3)
					{
					default:
						if (CC911D88.DoesElementExist(0, text2, "//android.widget.ProgressBar"))
						{
							SetStatusAccount(A29893BD, text + "Loading...");
						}
						else if (CC911D88.DoesElementExist(0, text2, "//*[@text='Tap to retry']"))
						{
							if (num5 >= num6)
							{
								break;
							}
							num5++;
							CC911D88.CE16082B(-1);
						}
						else
						{
							SetStatusAccount(A29893BD, text + "Scroll...");
							if (CC911D88.CE16082B())
							{
								break;
							}
						}
						goto IL_033c;
					case "//*[@content-desc='Add event']":
						CC911D88.method_19();
						goto IL_033c;
					case "//*[@content-desc='Invite']":
						SetStatusAccount(A29893BD, text + $"Invite ({num3 + 1}/{num4})...");
						CC911D88.TapByXPath(text3, text2);
						num3++;
						SetStatusAccount(A29893BD, text + $"Invite ({num3}/{num4}), delay {{time}}s...", Base.rd.Next(minValue2, num2 + 1));
						if (num3 > num4)
						{
							SetStatusAccount(A29893BD, text + $"Invite ({num3 + 1}/{num4}) done!");
							break;
						}
						goto IL_033c;
					case "//*[@content-desc='Share']":
						SetStatusAccount(A29893BD, text + "Tap " + CC911D88.method_105(text3) + "...");
						CC911D88.TapByXPath(text3, text2);
						goto IL_033c;
					case "//*[@content-desc='Interested']":
						{
							if (flag)
							{
								SetStatusAccount(A29893BD, text + Language.GetValue("Quan tâm") + "...");
								CC911D88.TapByXPath(text3, text2);
								CC911D88.TimeDelay(2.0);
								flag = false;
							}
							if (flag2)
							{
								SetStatusAccount(A29893BD, text + Language.GetValue("Tham gia") + "...");
								CC911D88.TapByXPath("//*[@content-desc='Going']", text2);
								CC911D88.TimeDelay(2.0);
								flag2 = false;
							}
							if (flag3)
							{
								CC911D88.TapByXPath("//*[@content-desc='More']", text2);
								goto IL_033c;
							}
							break;
						}
						IL_033c:
						if (Environment.TickCount - tickCount <= num7 * 1000)
						{
							goto IL_0353;
						}
						break;
					}
					break;
					IL_0353:
					CC911D88.TimeDelay(1.0);
				}
			}
		}
		catch
		{
		}
		return num3;
	}

	private void method_44(AC28BD29 E81AA920)
	{
		E81AA920.method_69("https://m.facebook.com/settings/security/two_factor/devices/");
		string text = "";
		int tickCount = Environment.TickCount;
		do
		{
			text = "";
			string text2 = E81AA920.CB3C4B8A(10, ref text, new List<string> { "//*[contains(@text,'No trusted devices')]", "//*[@text='Remove']" });
			if (!(text2 == "") && !(text2 == "//*[contains(@text,'No trusted devices')]"))
			{
				E81AA920.TapByXPath("//*[@text='Remove']", text);
				E81AA920.TimeDelay(2.0);
				continue;
			}
			break;
		}
		while (Environment.TickCount - tickCount < 120000);
	}

	private List<string> method_45(List<string> B985581A, string B039D7A8, string ED19A907, string string_0, int int_1)
	{
		List<string> A23E9B3E = new List<string>();
		try
		{
			int EC206BB9 = 0;
			int num = ((B985581A.Count < 100) ? B985581A.Count : 100);
			int num2 = 0;
			while (num2 < B985581A.Count)
			{
				if (EC206BB9 < num)
				{
					Interlocked.Increment(ref EC206BB9);
					int int_2 = num2++;
					Thread thread = new Thread((ThreadStart)delegate
					{
						try
						{
							string text = B985581A[int_2].Split('|')[0];
							RequestXNet b01F5C = new RequestXNet(B039D7A8, ED19A907, string_0, int_1);
							string text2 = b01F5C.RequestGet("https://m.facebook.com/groups/" + text + "/madminpanel");
							if (!text2.Contains("madminpanel/pending/"))
							{
								lock (A23E9B3E)
								{
									A23E9B3E.Add(text);
								}
							}
						}
						catch
						{
						}
						Interlocked.Decrement(ref EC206BB9);
					});
					thread.IsBackground = true;
					thread.Start();
				}
				else
				{
					Application.DoEvents();
					Thread.Sleep(200);
				}
			}
			while (EC206BB9 > 0)
			{
				Application.DoEvents();
				Thread.Sleep(1000);
			}
		}
		catch
		{
		}
		return A23E9B3E;
	}

	private int FEAA85AE(int int_1, string string_0, JSON_Settings f72FAFBC_0, string B4B32011)
	{
		SetStatusAccount(int_1, string_0 + string.Format(Language.GetValue("Đang {0}, " + Language.GetValue("đợi") + " {time}s..."), B4B32011), Base.rd.Next(f72FAFBC_0.method_0("nudDelayFrom"), f72FAFBC_0.method_0("nudDelayTo") + 1));
		return 1;
	}

	private void method_46(Chrome BD22729A, string string_0, int int_1)
	{
		try
		{
			if (BD22729A != null)
			{
				string text = Application.StartupPath + "\\log_capture";
				switch (int_1)
				{
				case 0:
					text += "\\checkpoint";
					break;
				case 1:
					text += "\\loginfail";
					break;
				case 2:
					text += "\\disconnect";
					break;
				}
				Common.CreateFolder(text);
				BD22729A.method_32(text, string_0);
				File.WriteAllText(text + "\\" + string_0 + ".txt", BD22729A.AB2275A9());
				File.WriteAllText(text + "\\" + string_0 + ".html", BD22729A.method_1());
			}
		}
		catch
		{
		}
	}

	private bool method_47(Chrome DC167933)
	{
		bool flag = false;
		try
		{
			DC167933.D920192A("https://www.instagram.com/");
			method_68();
			switch (DC167933.method_26(10.0, "[href=\"/accounts/activity/\"]", "form button"))
			{
			case 2:
				DC167933.method_14(4, "form button", 1);
				switch (DC167933.method_26(10.0, "[href=\"/accounts/activity/\"]", "[name=\"__CONFIRM__\"]", "[name=\"username\"]"))
				{
				case 2:
				{
					DC167933.C2B42BB6(1.0);
					DC167933.method_14(2, "__CONFIRM__");
					string text = "minsoft" + Common.CreateRandomString(3) + Common.CreateRandomString(5);
					DC167933.method_17(2, "username", text);
					Common.DelayTime(1.0);
					string text2 = "Minsoft_" + Common.CreateRandomString(6);
					DC167933.method_17(2, "password", text2);
					method_68();
					DC167933.method_14(4, "form button[type=\"submit\"]");
					method_68();
					if (DC167933.C6B3E9B0("[href=\"/accounts/activity/\"]", 10.0) == 1)
					{
						flag = true;
					}
					if (!flag && DC167933.C6B3E9B0("[type=\"button\"]") == 1)
					{
						flag = true;
					}
					if (flag)
					{
						lock (B6A38A39)
						{
							File.AppendAllText("account_ig.txt", text + "|" + text2 + Environment.NewLine);
							return flag;
						}
					}
					return flag;
				}
				default:
					return flag;
				case 1:
				case 3:
					return flag;
				}
			case 1:
				flag = true;
				return flag;
			default:
				return flag;
			}
		}
		catch
		{
			return flag;
		}
	}

	private void D7892297(Chrome gclass9_0)
	{
		try
		{
			GClass12.smethod_3(gclass9_0);
			if (gclass9_0.C6B3E9B0("#bookmarks_jewel a", 3.0) != 1)
			{
				return;
			}
			method_68();
			gclass9_0.method_14(4, "#bookmarks_jewel a");
			method_68(1);
			if (gclass9_0.method_24("document.querySelector('[data-sigil=\"logout\"]')", 3.0) == 1)
			{
				gclass9_0.method_27("document.querySelector('[data-sigil=\"logout\"]')");
				method_68(1);
				gclass9_0.method_14(4, "[data-sigil=\"logout\"]");
				method_68();
				if (gclass9_0.C6B3E9B0("[name=\"m_savepass\"]", 3.0) == 1)
				{
					gclass9_0.method_14(2, "m_savepass");
					method_68();
				}
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(gclass9_0, exception_, "Logout error");
		}
	}

	private bool method_48(Chrome gclass9_0)
	{
		bool result = false;
		try
		{
			gclass9_0.D920192A("https://m.facebook.com/settings/security_login/sessions/log_out_all/confirm/");
			gclass9_0.C2B42BB6(1.0);
			string text = "";
			for (int i = 0; i < 10; i++)
			{
				text = gclass9_0.F4AF93AB("return document.documentElement.innerHTML.match(new RegExp('/security/settings/sessions/log_out_all/(.*?)\"'))[0].replace('\"','').split('amp;').join('');").ToString();
				if (!(text != ""))
				{
					gclass9_0.C2B42BB6(1.0);
					continue;
				}
				gclass9_0.D920192A("https://m.facebook.com" + text);
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	private bool method_49(Chrome gclass9_0)
	{
		bool result = false;
		try
		{
			gclass9_0.D920192A("https://m.facebook.com/settings/subscribe/");
			gclass9_0.C2B42BB6(1.0);
			if (gclass9_0.C6B3E9B0("[data-sigil=\"audience-options-list\"]>label", 10.0) == 1)
			{
				if (!Convert.ToBoolean(gclass9_0.F4AF93AB("return document.querySelector('[data-sigil=\"audience-options-list\"]>label').getAttribute('data-sigil').includes('selected')+''")))
				{
					if (gclass9_0.method_14(4, "[data-sigil=\"audience-options-list\"]>label") == 1)
					{
						result = true;
						return result;
					}
					return result;
				}
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	private bool method_50(string C7B977A8, List<string> B78D6C3D)
	{
		bool result = false;
		try
		{
			for (int i = 0; i < B78D6C3D.Count; i++)
			{
				if (Common.A8AF5A8E(C7B977A8).ToLower().Contains(Common.A8AF5A8E(B78D6C3D[i]).ToLower()))
				{
					result = true;
					return result;
				}
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public int D401D48A(int int_1, string string_0, AC28BD29 C53D15BE, JSON_Settings f72FAFBC_0, string CD89C6AC)
	{
		List<string> f1808BA = f72FAFBC_0.EC378D8A("txtTuKhoa");
		int minValue = f72FAFBC_0.method_0("nudSoLuongFrom");
		int num = f72FAFBC_0.method_0("nudSoLuongTo");
		int minValue2 = f72FAFBC_0.method_0("nudDelayFrom");
		int num2 = f72FAFBC_0.method_0("nudDelayTo");
		bool flag = f72FAFBC_0.AA824D29("ckbTuDongTraLoiCauHoi");
		List<string> list_ = f72FAFBC_0.EC378D8A("txtCauTraLoi");
		int num3 = 0;
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + CD89C6AC + ": ";
			int num4 = random_0.Next(minValue, num + 1);
			if (num4 != 0)
			{
				f1808BA = Common.RemoveEmptyItems(f1808BA);
				string string_ = f1808BA[random_0.Next(0, f1808BA.Count)];
				string_ = Common.SpinText(string_);
				while (true)
				{
					IL_04e9:
					SetStatusAccount(int_1, text + "Search Group...");
					if (!C53D15BE.method_71(string_, "Groups"))
					{
						break;
					}
					List<string> list = new List<string>();
					for (int i = 0; i < num4 + 10; i++)
					{
						string text2;
						string string_2;
						switch (method_22(C53D15BE, int_1, string_0))
						{
						case 0:
						{
							SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Join...");
							list = C53D15BE.FindElements(5, "", "//*[starts-with(@content-desc, 'Join ')]");
							SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Join: " + list.Count);
							if (list.Count != 0)
							{
								goto IL_0274;
							}
							for (int j = 0; j < 10; j++)
							{
								SetStatusAccount(int_1, text + $"({num3}/{num4}), Scroll...");
								if (C53D15BE.CE16082B())
								{
									break;
								}
								SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Join...");
								list = C53D15BE.FindElements(5, "", "//*[starts-with(@content-desc, 'Join ')]");
								SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Join: " + list.Count);
								if (list.Count > 0)
								{
									break;
								}
							}
							if (list.Count != 0)
							{
								goto IL_0274;
							}
							goto end_IL_0068;
						}
						case 1:
							break;
						default:
							goto end_IL_0068;
							IL_0274:
							text2 = list.smethod_8();
							list.Remove(text2);
							SetStatusAccount(int_1, text + $"({num3}/{num4}), Tap Join...");
							if (!C53D15BE.E832B991(text2))
							{
								continue;
							}
							string_2 = "";
							SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Submit...");
							if (C53D15BE.C60AEB35(5, ref string_2, "//android.view.ViewGroup[@content-desc=\"Submit\"]"))
							{
								if (flag)
								{
									method_86(int_1, text + $"({num3}/{num4}), ", C53D15BE, list_);
								}
								else
								{
									SetStatusAccount(int_1, text + $"({num3}/{num4}), Back...");
									if (!C53D15BE.method_40(0, "//android.view.ViewGroup[@content-desc=\"Back\"]", string_2))
									{
										C53D15BE.method_19();
									}
									string_2 = "";
									SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Exit...");
									if (C53D15BE.C60AEB35(5, ref string_2, "//android.widget.TextView[@text=\"Exit without answering?\"]"))
									{
										SetStatusAccount(int_1, text + $"({num3}/{num4}), Tap Exit...");
										C53D15BE.method_40(0, "//android.widget.Button[@text=\"EXIT\"]", string_2);
										C53D15BE.method_54(1.0, 1.5);
									}
								}
								SetStatusAccount(int_1, text + $"({num3}/{num4}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
							}
							if (C53D15BE.method_28(0, "", new List<string> { "//android.view.ViewGroup[@content-desc=\"Cancel request\"]", "//android.widget.Button[@content-desc=\"Member tools\"]" }).Count > 0)
							{
								SetStatusAccount(int_1, text + $"({num3}/{num4}), Back...");
								C53D15BE.method_19();
							}
							num3++;
							if (num3 < num4)
							{
								continue;
							}
							SetStatusAccount(int_1, text + $"({num3}/{num4}), Done!");
							goto end_IL_0068;
						}
						goto IL_04e9;
					}
					break;
				}
			}
			end_IL_0068:;
		}
		catch
		{
			num3 = -1;
		}
		return num3;
	}

	public int method_51(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings A220DD98, string string_1)
	{
		int minValue = A220DD98.method_0("nudSoLuongFrom");
		int num = A220DD98.method_0("nudSoLuongTo");
		int minValue2 = A220DD98.method_0("nudDelayFrom");
		int num2 = A220DD98.method_0("nudDelayTo");
		bool flag = A220DD98.AA824D29("ckbTuDongTraLoiCauHoi");
		List<string> list_ = A220DD98.EC378D8A("txtCauTraLoi");
		int num3 = 0;
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			int num4 = random_0.Next(minValue, num + 1);
			if (num4 != 0)
			{
				while (true)
				{
					IL_04ad:
					SetStatusAccount(int_1, text + "Go to " + Language.GetValue("Nhóm gợi ý") + "...");
					if (!FA905AA0(ac28BD29_0, int_1, text, "fb://faceweb/f?href=https://m.facebook.com/groups_browse/see_all/?category_id=212609529249058"))
					{
						break;
					}
					List<string> list = new List<string>();
					for (int i = 0; i < num4 + 10; i++)
					{
						string text2;
						string string_2;
						switch (method_22(ac28BD29_0, int_1, string_0))
						{
						case 0:
						{
							SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Join...");
							list = ac28BD29_0.FindElements(5, "", "//android.view.ViewGroup[@content-desc='Join']");
							SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Join: " + list.Count);
							if (list.Count != 0)
							{
								goto IL_0239;
							}
							for (int j = 0; j < 10; j++)
							{
								SetStatusAccount(int_1, text + $"({num3}/{num4}), Scroll...");
								if (ac28BD29_0.CE16082B())
								{
									break;
								}
								SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Join...");
								list = ac28BD29_0.FindElements(5, "", "//android.view.ViewGroup[@content-desc='Join']");
								SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Join: " + list.Count);
								if (list.Count > 0)
								{
									break;
								}
							}
							if (list.Count != 0)
							{
								goto IL_0239;
							}
							goto end_IL_0059;
						}
						case 1:
							break;
						default:
							goto end_IL_0059;
							IL_0239:
							text2 = list.smethod_8();
							list.Remove(text2);
							SetStatusAccount(int_1, text + $"({num3}/{num4}), Tap Join...");
							if (!ac28BD29_0.E832B991(text2))
							{
								continue;
							}
							string_2 = "";
							SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Submit...");
							if (ac28BD29_0.C60AEB35(5, ref string_2, "//android.view.ViewGroup[@content-desc=\"Submit\"]"))
							{
								if (flag)
								{
									method_86(int_1, text + $"({num3}/{num4}), ", ac28BD29_0, list_);
								}
								else
								{
									SetStatusAccount(int_1, text + $"({num3}/{num4}), Back...");
									if (!ac28BD29_0.method_40(0, "//android.view.ViewGroup[@content-desc=\"Back\"]", string_2))
									{
										ac28BD29_0.method_19();
									}
									string_2 = "";
									SetStatusAccount(int_1, text + $"({num3}/{num4}), Find Exit...");
									if (ac28BD29_0.C60AEB35(5, ref string_2, "//android.widget.TextView[@text=\"Exit without answering?\"]"))
									{
										SetStatusAccount(int_1, text + $"({num3}/{num4}), Tap Exit...");
										ac28BD29_0.method_40(0, "//android.widget.Button[@text=\"EXIT\"]", string_2);
										ac28BD29_0.method_54(1.0, 1.5);
									}
								}
								SetStatusAccount(int_1, text + $"({num3}/{num4}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
							}
							if (ac28BD29_0.method_28(0, "", new List<string> { "//android.view.ViewGroup[@content-desc=\"Cancel request\"]", "//android.widget.Button[@content-desc=\"Member tools\"]" }).Count > 0)
							{
								SetStatusAccount(int_1, text + $"({num3}/{num4}), Back...");
								ac28BD29_0.method_19();
							}
							num3++;
							if (num3 < num4)
							{
								continue;
							}
							SetStatusAccount(int_1, text + $"({num3}/{num4}), Done!");
							goto end_IL_0059;
						}
						goto IL_04ad;
					}
					break;
				}
			}
			end_IL_0059:;
		}
		catch
		{
			num3 = -1;
		}
		return num3;
	}

	private int DEA54A85(AC28BD29 ac28BD29_0, int int_1, string string_0, string string_1)
	{
		int result = 0;
		string text = E20A2AB2.B79CC01F(string_1);
		if (!(text == ""))
		{
			int num = 0;
			int num2 = 5;
			string text2 = "";
			string text3 = "";
			for (int i = 0; i < 3; i++)
			{
				while (num < num2)
				{
					num++;
					if (!FA905AA0(ac28BD29_0, int_1, string_0, "fb://fullscreen_video/" + text + "?loop=0"))
					{
						break;
					}
					for (int j = 1; j < 11; j++)
					{
						text2 = ac28BD29_0.GetPageSource();
						text3 = ac28BD29_0.CB3C4B8A(0, ref text2, new List<string> { "//*[@content-desc='SHARE' or @text='SHARE']" });
						if (!(text3 != ""))
						{
							if (j % 3 == 0)
							{
								int num3 = method_22(ac28BD29_0, int_1, string_0);
								if (num3 == 1)
								{
									goto IL_0194;
								}
								if (num3 != 0)
								{
									result = num3;
									goto IL_01bd;
								}
							}
							if (!ac28BD29_0.method_15().Contains("com.facebook.video.activity.DeprecatedFullscreenVideoPlayerActivity"))
							{
								if (num < num2)
								{
									num++;
									FA905AA0(ac28BD29_0, int_1, string_0, "fb://fullscreen_video/" + text + "?loop=0");
									continue;
								}
							}
							else
							{
								List<string> source = ac28BD29_0.method_24(0, text2);
								if (source.Where((string string_0) => !string_0.Contains($"[{ac28BD29_0.method_14()},{ac28BD29_0.method_13()}]")).Count() != 0)
								{
									ac28BD29_0.TimeDelay(1.0);
									continue;
								}
								result = 1;
							}
						}
						else
						{
							result = 1;
						}
						goto IL_01bd;
					}
					goto IL_01a3;
					IL_0194:;
				}
				break;
				IL_01a3:;
			}
		}
		goto IL_01bd;
		IL_01bd:
		return result;
	}

	private int EAB1360A(AC28BD29 F9BD4016, int int_1, string string_0, string string_1)
	{
		int result = 0;
		if (!string_1.Contains("facebook.com/reel/"))
		{
			if (string_1.Contains("photo") || string_1.Contains("v="))
			{
				string text = E20A2AB2.B79CC01F(string_1);
				if (Common.smethod_28(text))
				{
					string_1 = "https://m.facebook.com/" + text;
				}
			}
			else if (string_1.Contains("groups"))
			{
				string value = Regex.Match(string_1, "groups/(.*?)/").Groups[1].Value;
				if (value == "")
				{
					value = Regex.Match(string_1, "groups/(.*?)\\?").Groups[1].Value;
				}
				if (value != "")
				{
					string text2 = E20A2AB2.B79CC01F(string_1);
					if (text2 != "")
					{
						string_1 = "https://m.facebook.com/groups/" + value + "/permalink/" + text2 + "/";
					}
				}
			}
			else if (string_1.Contains("story_fbid"))
			{
				string value2 = Regex.Match(string_1, "id=(\\d+)").Groups[1].Value;
				if (value2 != "")
				{
					string text3 = E20A2AB2.B79CC01F(string_1);
					if (text3 != "")
					{
						string_1 = "https://m.facebook.com/" + value2 + "/posts/" + text3 + "/";
					}
				}
			}
			else if (!string_1.StartsWith("http"))
			{
				string_1 = "https://m.facebook.com/" + string_1;
			}
		}
		string text4 = F9BD4016.GetPageSource();
		if (!F9BD4016.DoesElementExist(0, text4, "//*[@content-desc=\"Make a post on Facebook\"]"))
		{
			F9BD4016.D7950A0F();
			F9BD4016.TimeDelay(2.0);
			text4 = F9BD4016.GetPageSource();
		}
		string text5 = F9BD4016.FindElements(0, text4, "//*[@content-desc=\"Make a post on Facebook\"]").FirstOrDefault() ?? "";
		string text6 = "";
		string text7 = "";
		int num = 0;
		int num2 = 3;
		int num3 = 0;
		int num4 = 3;
		while (FA905AA0(F9BD4016, int_1, string_0, string_1))
		{
			int num5 = 1;
			while (num5 < 11)
			{
				text4 = F9BD4016.GetPageSource();
				text6 = F9BD4016.FindElements(0, text4, "//*[@content-desc=\"Make a post on Facebook\"]").FirstOrDefault() ?? "";
				if (!(text6 != "") || !(text6 == text5))
				{
					text7 = F9BD4016.CB3C4B8A(0, ref text4, new List<string> { "//*[@content-desc='Post Menu']", "//*[@content-desc='More options' or @text='More options']", "//*[@content-desc='More']", "//*[@text='Tap to retry']", "//*[starts-with(@content-desc,'Join ')]", "//*[@content-desc='See what was used to create this reel']", "//*[@content-desc='Reel. Swipe up to see more.']", "(//*[@text='Stories'])[2]", "//*[@content-desc='Like']" });
					if (!(text7 == "//*[starts-with(@content-desc,'Join ')]"))
					{
						if (text7 == "//*[@text='Tap to retry']")
						{
							if (num3 >= num4)
							{
								result = 2;
								break;
							}
							num3++;
							F9BD4016.TapByXPath("//*[@text='Tap to retry']", text4);
							F9BD4016.TimeDelay(5.0);
						}
						else
						{
							if (text7 != "")
							{
								result = 1;
								break;
							}
							if (F9BD4016.ED9CDB24(text4, "The page you requested cannot be displayed right now"))
							{
								result = 2;
								break;
							}
							if (F9BD4016.ED9CDB24(text4, "Tap to view story"))
							{
								result = 1;
								break;
							}
						}
						if (num5 % 3 == 0)
						{
							int num6 = method_22(F9BD4016, int_1, string_0);
							if (num6 == 1)
							{
								goto IL_0428;
							}
							if (num6 != 0)
							{
								result = num6;
								break;
							}
						}
						if (!string_1.Contains("/stories/") || !F9BD4016.DoesElementExist(60, "", "(//*[@text='Stories'])[2]"))
						{
							F9BD4016.FB3ACF2E(-1);
							F9BD4016.TimeDelay(1.0);
							num5++;
							continue;
						}
						result = 1;
						break;
					}
					F9BD4016.TapByXPath(text7, text4);
					F9BD4016.method_54(2.0, 3.0);
				}
				else
				{
					num++;
					if (num > num2)
					{
						result = 2;
						break;
					}
				}
				goto IL_0428;
			}
			break;
			IL_0428:;
		}
		return result;
	}

	private bool method_52(int int_1, string string_0, AC28BD29 BE25BE00, string AF2C0C37, int int_2 = 1, bool bool_4 = false)
	{
		bool result = false;
		SetStatusAccount(int_1, string_0 + "Upload media...");
		if (bool_4)
		{
			lock (object_3)
			{
				List<string> list = (from string_08 in Directory.GetFiles(AF2C0C37)
					where !string_08.EndsWith(".txt")
					select string_08).ToList();
				if (list.Count > 0)
				{
					List<string> list2 = new List<string>();
					string text = "";
					for (int i = 0; i < int_2; i++)
					{
						if (list.Count == 0)
						{
							break;
						}
						text = list.OrderBy((string C8929B25) => Guid.NewGuid()).FirstOrDefault();
						list.Remove(text);
						list2.Add(text);
					}
					BE25BE00.method_96(list2);
					BE25BE00.TimeDelay(2.0);
					for (int j = 0; j < list2.Count; j++)
					{
						Common.smethod_49(list2[j]);
					}
					result = true;
				}
			}
		}
		else
		{
			List<string> list3 = new List<string>();
			if (AF2C0C37.EndsWith(".mp4"))
			{
				list3.Add(AF2C0C37);
			}
			else
			{
				list3 = (from string_055 in Directory.GetFiles(AF2C0C37)
					where !string_055.EndsWith(".txt")
					select string_055).ToList();
			}
			if (list3.Count > 0)
			{
				List<string> list4 = new List<string>();
				string text2 = "";
				for (int k = 0; k < int_2; k++)
				{
					if (list3.Count == 0)
					{
						break;
					}
					text2 = list3.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
					list3.Remove(text2);
					list4.Add(text2);
				}
				BE25BE00.method_96(list4);
				BE25BE00.TimeDelay(2.0);
				result = true;
			}
		}
		SetStatusAccount(int_1, string_0 + "Upload media done!");
		return result;
	}

	public int method_53(int EB914FA2, string FC861A99, AC28BD29 ac28BD29_0, JSON_Settings CC0F27A7, string F438F386, string string_0, string string_1)
	{
		int minValue = CC0F27A7.method_0("nudSoLuongFrom", 1);
		int num = CC0F27A7.method_0("nudSoLuongTo", 1);
		int minValue2 = CC0F27A7.method_0("nudKhoangCachFrom");
		int num2 = CC0F27A7.method_0("nudKhoangCachTo");
		int num3 = 0;
		string text = "";
		string text2 = "";
		try
		{
			string text3 = FC861A99 + Language.GetValue("Đang") + " " + F438F386 + ": ";
			int num4 = random_0.Next(minValue, num + 1);
			for (int i = 0; i < num4 + 5 && num3 < num4; i++)
			{
				SetStatusAccount(EB914FA2, text3 + $"({num3 + 1}/{num4})...");
				try
				{
					while (true)
					{
						ac28BD29_0.DD071C25();
						ac28BD29_0.method_54(2.0, 3.0);
						switch (method_22(ac28BD29_0, EB914FA2, FC861A99))
						{
						case 1:
							break;
						default:
							goto end_IL_00d5;
						case 0:
						{
							int num5 = 0;
							int tickCount = Environment.TickCount;
							int num6 = 300;
							do
							{
								SetStatusAccount(EB914FA2, text3 + $"({num3 + 1}/{num4})...");
								text = ac28BD29_0.GetPageSource();
								text2 = ac28BD29_0.FindElement(0, text, new List<string> { "//*[@content-desc='Navigate to your Reels profile']", "//*[@content-desc='View suggested entities']", "//*[@content-desc='Delete']", "//*[@text='Are you sure you want to remove your reel from Facebook?']" });
								switch (text2)
								{
								case "//*[@content-desc='Navigate to your Reels profile']":
									if (num5 > 0)
									{
										ac28BD29_0.TapByXPath("//*[@content-desc='Menu']", text);
										break;
									}
									num5++;
									SetStatusAccount(EB914FA2, text3 + "Tap " + ac28BD29_0.method_105(text2) + "...");
									ac28BD29_0.TapByXPath(text2, text);
									break;
								default:
								{
									SetStatusAccount(EB914FA2, text3 + $"({num3 + 1}/{num4}), Scroll...");
									if (!ac28BD29_0.CE16082B(-1))
									{
										break;
									}
									int num7 = method_22(ac28BD29_0, EB914FA2, FC861A99);
									if (num7 != 1 && num7 != 0)
									{
										goto end_IL_0090;
									}
									goto IL_0382;
								}
								case "//*[@text='Are you sure you want to remove your reel from Facebook?']":
									ac28BD29_0.TapByXPath("//*[@text='DELETE']", text);
									ac28BD29_0.TimeDelay(2.0);
									ac28BD29_0.method_30(30);
									num3++;
									if (num3 < num4)
									{
										SetStatusAccount(EB914FA2, text3 + $"({num3}/{num4}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
										break;
									}
									goto end_IL_00d5;
								case "//*[@content-desc='Delete']":
									ac28BD29_0.TapByXPath(text2, text);
									break;
								case "//*[@content-desc='View suggested entities']":
									if (ac28BD29_0.method_40(10, "//*[starts-with(@content-desc,'Reel,')]", ""))
									{
										break;
									}
									goto end_IL_00d5;
								}
								ac28BD29_0.TimeDelay(1.0);
							}
							while (Environment.TickCount - tickCount < num6 * 1000);
							goto IL_0382;
						}
						}
					}
					end_IL_00d5:;
				}
				catch
				{
					continue;
				}
				break;
				continue;
				end_IL_0090:
				break;
				IL_0382:;
			}
		}
		catch
		{
		}
		return num3;
	}

	public int method_54(ref int int_1, int int_2, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string F40CFE1F, string FA3C83B4, string string_1)
	{
		int minValue = f72FAFBC_0.method_0("nudSoLuongFrom", 1);
		int num = f72FAFBC_0.method_0("nudSoLuongTo", 1);
		int minValue2 = f72FAFBC_0.method_0("nudKhoangCachFrom");
		int num2 = f72FAFBC_0.method_0("nudKhoangCachTo");
		bool flag = f72FAFBC_0.AA824D29("ckbVanBan");
		bool flag2 = f72FAFBC_0.AA824D29("ckbXoaNguyenLieuDaDung");
		bool flag3 = f72FAFBC_0.AA824D29("ckbHashtag");
		List<string> list = f72FAFBC_0.EC378D8A("txtHashtag");
		int int_3 = f72FAFBC_0.method_0("nudSoHashtagFrom", 1);
		int int_4 = f72FAFBC_0.method_0("nudSoHashtagTo", 1);
		bool bool_ = f72FAFBC_0.AA824D29("ckbXoaVideoDaDang");
		string text = f72FAFBC_0.GetValue("txtPathAnh");
		int num3 = f72FAFBC_0.method_0("typeReel");
		int e40D7F = f72FAFBC_0.method_0("nudTimeOutLoadVideo", 300);
		int num4 = f72FAFBC_0.method_0("cbbWhenTimeout");
		bool flag4 = f72FAFBC_0.AA824D29("ckbTuongTacReel");
		bool flag5 = f72FAFBC_0.AA824D29("ckbKhoNoiDung");
		string path = f72FAFBC_0.GetValue("txtKhoNoiDung");
		bool flag6 = f72FAFBC_0.AA824D29("ckbThuMucMedia");
		string path2 = f72FAFBC_0.GetValue("txtThuMucMedia") + "\\" + method_117(int_2, "cUid");
		int num5 = 0;
		string text2 = "";
		string text3 = "";
		List<string> list2 = new List<string>();
		if (num3 == 1)
		{
			if (string_1 != "")
			{
				list2 = EA98BF20.smethod_0(string_1, ac28BD29_0.Proxy, ac28BD29_0.int_1);
			}
			if (list2.Count == 0)
			{
				string_1 = ac28BD29_0.AF03B30E().Split('|')[1];
				list2 = EA98BF20.smethod_0(string_1, ac28BD29_0.Proxy, ac28BD29_0.int_1);
			}
			if (list2.Count == 0)
			{
				goto IL_1230;
			}
		}
		try
		{
			string text4 = string_0 + Language.GetValue("Đang") + " " + F40CFE1F + ": ";
			List<string> list3;
			List<string> list4;
			if (!flag || dictionary_2[FA3C83B4].Count != 0 || flag5 || flag6)
			{
				list3 = new List<string>();
				list4 = new List<string>();
				if (flag5)
				{
					if (Directory.Exists(path))
					{
						try
						{
							list4 = Directory.GetDirectories(path).ToList();
						}
						catch (Exception)
						{
						}
						if (list4.Count != 0)
						{
							goto IL_02e4;
						}
					}
				}
				else
				{
					if (!flag6)
					{
						if (!flag2)
						{
							list3 = Common.smethod_11(dictionary_2[FA3C83B4]);
						}
						goto IL_02e4;
					}
					bool_ = false;
					if (Directory.Exists(path2))
					{
						try
						{
							list4 = Directory.GetFiles(path2).ToList();
						}
						catch (Exception)
						{
						}
						if (list4.Count != 0)
						{
							goto IL_02e4;
						}
					}
				}
			}
			goto end_IL_01e0;
			IL_02e4:
			int num6 = random_0.Next(minValue, num + 1);
			for (int i = 0; i < num6 + 5 && num5 < num6; i++)
			{
				SetStatusAccount(int_2, text4 + $"({num5 + 1}/{num6})...");
				try
				{
					if (flag5)
					{
						text = list4[int_2 % list4.Count];
						flag = false;
						string text5 = (from A89B4615 in Directory.GetFiles(text)
							where A89B4615.ToLower().EndsWith("post.txt")
							select A89B4615).FirstOrDefault();
						if (!string.IsNullOrEmpty(text5))
						{
							flag = true;
							list3.AddRange(File.ReadAllLines(text5));
						}
						goto IL_040e;
					}
					if (!flag6)
					{
						goto IL_040e;
					}
					if (list4.Count == 0)
					{
						break;
					}
					text = list4.First();
					flag = true;
					list3.Add(Path.GetFileNameWithoutExtension(text));
					flag2 = false;
					goto IL_040e;
					IL_040e:
					while (true)
					{
						if (num3 == 0)
						{
							ac28BD29_0.DD071C25();
							ac28BD29_0.method_54(2.0, 3.0);
							int num7 = method_22(ac28BD29_0, int_2, string_0);
							if (num7 == 1)
							{
								continue;
							}
							if (num7 != 0)
							{
								break;
							}
						}
						else
						{
							if (list2.Count == 0)
							{
								goto IL_1220;
							}
							string text6 = list2.OrderBy((string string_0) => Guid.NewGuid()).First();
							list2.Remove(text6);
							if (!FA905AA0(ac28BD29_0, int_2, text4, "fb://page/" + text6))
							{
								goto IL_1220;
							}
						}
						int num8 = 0;
						int num9 = 1;
						bool flag7 = false;
						int tickCount = Environment.TickCount;
						int num10 = 300;
						while (true)
						{
							text2 = ac28BD29_0.GetPageSource();
							text3 = ac28BD29_0.FindElement(0, text2, new List<string>
							{
								"//*[@content-desc='Create a reel']", "//*[@content-desc='Next']", "//*[@text='Allow access' or @content-desc='Allow access']", "//*[@content-desc='Video']", "//*[@content-desc='Gallery']", "//*[@text='Who can see reels?']", "//*[@content-desc='Opens the audience picker']", "//*[@content-desc='Set as default audience for reels']/android.widget.CheckBox[@checked='false']", "//*[@content-desc='Save default audience']", "//*[starts-with(@content-desc, 'Public; Anyone on or off Facebook')]",
								"//*[starts-with(@content-desc, 'Friends of friends; Your friends of friends')]", "//*[@text='UNLOCK']", "//*[@text='Allow']", "//android.widget.EditText[starts-with(@text,'Describe your reel')]", "//android.widget.EditText[starts-with(@text,'Write a description')]", "//*[@content-desc='Create Action Button']", "//*[@content-desc='Follow']", "(//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup)[last()]/child::*", "//*[@content-desc='Overview']", "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View"
							});
							string text7 = text3;
							string text8 = text7;
							uint num11 = HashString.DA8CEBAB(text8);
							if (num11 > 940152427)
							{
								if (num11 <= 1441361486)
								{
									if (num11 <= 986644698)
									{
										if (num11 != 975484661)
										{
											if (num11 == 986644698 && text8 == "//*[@content-desc='Create a reel']")
											{
												if (method_52(int_2, text4 + $"({num5 + 1}/{num6}), ", ac28BD29_0, text, 1, bool_))
												{
													ac28BD29_0.method_40(0, text3, text2);
													goto IL_0f1c;
												}
												break;
											}
										}
										else if (text8 == "//android.widget.EditText[starts-with(@text,'Write a description')]")
										{
											goto IL_08cf;
										}
									}
									else if (num11 != 1142163927)
									{
										if (num11 != 1294296500)
										{
											if (num11 == 1441361486 && text8 == "//*[@content-desc='Set as default audience for reels']/android.widget.CheckBox[@checked='false']")
											{
												goto IL_0db3;
											}
										}
										else if (text8 == "//*[@content-desc='Follow']")
										{
											goto IL_0594;
										}
									}
									else if (text8 == "(//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup)[last()]/child::*")
									{
										string text9 = ac28BD29_0.FindElements(0, text2, "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View").FirstOrDefault();
										if (!string.IsNullOrEmpty(text9) && new Class65(text9).B9898119 < 2000)
										{
											Class65 @class = new Class65(text9);
											Class65 class2 = new Class65(@class.int_0, 2000, @class.int_1, 2000);
											ac28BD29_0.method_52(@class.AA3F9A29(), class2.AA3F9A29());
										}
										else
										{
											List<Class65> list5 = Class65.smethod_2(text2, text3);
											if (list5.Count > 1 && list5[0].E42395AA < 2300)
											{
												if (!method_52(int_2, text4 + $"({num5 + 1}/{num6}), ", ac28BD29_0, text, 1, bool_))
												{
													break;
												}
												ac28BD29_0.E832B991(list5.Last().AA3F9A29());
											}
											else
											{
												ac28BD29_0.CE16082B(2);
											}
										}
										goto IL_0f1c;
									}
								}
								else if (num11 <= 2624184915u)
								{
									if (num11 != 1792698548)
									{
										if (num11 == 2624184915u && text8 == "//*[starts-with(@content-desc, 'Friends of friends; Your friends of friends')]")
										{
											goto IL_082d;
										}
									}
									else if (text8 == "//*[@content-desc='Next']")
									{
										goto IL_0db3;
									}
								}
								else if (num11 != 2708651264u)
								{
									if (num11 != 3347773629u)
									{
										if (num11 == 4070114641u && text8 == "//*[@content-desc='Opens the audience picker']")
										{
											goto IL_08cf;
										}
									}
									else if (text8 == "//*[@content-desc='Save default audience']")
									{
										goto IL_0db3;
									}
								}
								else if (text8 == "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View")
								{
									if (num3 != 0 || num5 != 0 || !ac28BD29_0.method_15().Contains("com.facebook.fbshorts.viewer.activity.FbShortsViewerActivity") || !ac28BD29_0.DoesElementExist(0, text2, "//*[@content-desc='See what was used to create this reel']") || ac28BD29_0.DoesElementExist(0, text2, "//*[@content-desc='Create a reel']"))
									{
										string text10 = ac28BD29_0.FindElements(0, text2, "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View").FirstOrDefault();
										if (!string.IsNullOrEmpty(text10) && new Class65(text10).B9898119 < 2000)
										{
											Class65 class3 = new Class65(text10);
											Class65 class4 = new Class65(class3.int_0, 2000, class3.int_1, 2000);
											ac28BD29_0.method_52(class3.AA3F9A29(), class4.AA3F9A29());
										}
										goto IL_0f1c;
									}
									num5 = -2;
									break;
								}
							}
							else if (num11 <= 413844824)
							{
								if (num11 <= 82008644)
								{
									if (num11 != 17785684)
									{
										if (num11 == 82008644 && text8 == "//*[@text='Allow']")
										{
											goto IL_0db3;
										}
									}
									else if (text8 == "//*[@text='Allow access' or @content-desc='Allow access']")
									{
										goto IL_0db3;
									}
								}
								else if (num11 != 330244122)
								{
									if (num11 != 337542542)
									{
										if (num11 == 413844824 && text8 == "//*[@content-desc='Video']")
										{
											goto IL_0db3;
										}
									}
									else if (text8 == "//*[@text='Who can see reels?']")
									{
										goto IL_10a0;
									}
								}
								else if (text8 == "//*[@content-desc='Overview']")
								{
									ac28BD29_0.CE16082B();
									goto IL_0f1c;
								}
							}
							else if (num11 <= 507363469)
							{
								if (num11 != 505387006)
								{
									if (num11 == 507363469 && text8 == "//*[@content-desc='Gallery']")
									{
										goto IL_0db3;
									}
								}
								else if (text8 == "//*[starts-with(@content-desc, 'Public; Anyone on or off Facebook')]")
								{
									goto IL_082d;
								}
							}
							else if (num11 != 819745119)
							{
								if (num11 != 856161075)
								{
									if (num11 == 940152427 && text8 == "//*[@content-desc='Create Action Button']")
									{
										goto IL_0594;
									}
								}
								else if (text8 == "//*[@text='UNLOCK']")
								{
									goto IL_10a0;
								}
							}
							else if (text8 == "//android.widget.EditText[starts-with(@text,'Describe your reel')]")
							{
								goto IL_08cf;
							}
							if (num5 != 0 || !ac28BD29_0.method_15().Contains("com.facebook.fbshorts.viewer.activity.FbShortsViewerActivity") || !ac28BD29_0.DoesElementExist(0, text2, "//*[@content-desc='See what was used to create this reel']") || ac28BD29_0.DoesElementExist(0, text2, "//*[@content-desc='Create a reel']"))
							{
								SetStatusAccount(int_2, text4 + $"({num5 + 1}/{num6}), Scroll...");
								if (ac28BD29_0.CE16082B(-1))
								{
									int num12 = method_22(ac28BD29_0, int_2, string_0);
									if (num12 == 1 || num12 == 0)
									{
										goto IL_1220;
									}
									break;
								}
								goto IL_0f1c;
							}
							num5 = -2;
							break;
							IL_0b5a:
							ac28BD29_0.TapByXPath("//*[@text='Share reel' or @content-desc='Share reel' or @text='Share now' or @content-desc='Share now' or @text='Share' or @content-desc='Share']");
							SetStatusAccount(int_2, text4 + $"({num5 + 1}/{num6}), Tap Share reel, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(3, 6));
							SetStatusAccount(int_2, text4 + string.Format("({0}/{1}), {2} post success...", num5 + 1, num6, Language.GetValue("đợi")));
							bool flag8 = ac28BD29_0.method_30(e40D7F) || num4 == 0;
							if (flag6)
							{
								Common.smethod_49(text);
								list4.Remove(text);
							}
							if (flag8)
							{
								if (flag4)
								{
									if (flag5)
									{
										string text11 = (from string_07 in Directory.GetFiles(text)
											where string_07.ToLower().EndsWith("cmt.txt")
											select string_07).FirstOrDefault();
										if (!string.IsNullOrEmpty(text11))
										{
											f72FAFBC_0.GetValue("ckbComment", true);
											f72FAFBC_0.GetValue("txtComment", (object)File.ReadAllText(text11));
											f72FAFBC_0.GetValue("typeNganCach", 0);
										}
										else
										{
											f72FAFBC_0.GetValue("txtComment", (object)"");
										}
									}
									else
									{
										f72FAFBC_0.GetValue("typeNganCach", f72FAFBC_0.method_0("typeNganCachCommentReel"));
									}
									B804088D(int_2, text4 + $"({num5 + 1}/{num6}), ", ac28BD29_0, f72FAFBC_0, Language.GetValue("tương tác"));
								}
								num5++;
								if (num5 < num6)
								{
									SetStatusAccount(int_2, text4 + $"({num5 + 1}/{num6}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
									goto IL_0f1c;
								}
								break;
							}
							goto IL_1220;
							IL_0a29:
							string text13;
							if (flag3)
							{
								list = f72FAFBC_0.EC378D8A("txtHashtag");
								int num13 = Common.F413B12C(int_3, int_4);
								for (int j = 0; j < num13; j++)
								{
									if (list.Count == 0)
									{
										break;
									}
									string text12 = list.OrderBy((string string_0) => Guid.NewGuid()).First();
									list.Remove(text12);
									text13 = text13 + text12 + " ";
								}
								text13 = text13.Trim();
							}
							text13 = Common.SpinText(text13);
							if (text13.Trim() != "")
							{
								ac28BD29_0.method_54(1.0, 1.5);
								SetStatusAccount(int_2, text4 + $"({num5 + 1}/{num6}), " + Language.GetValue("Nhập dữ liệu..."));
								ac28BD29_0.SendByXPath("//android.widget.EditText", text13 + "\n");
								ac28BD29_0.method_54(1.0, 1.5);
							}
							goto IL_0b5a;
							IL_10a0:
							ac28BD29_0.TapByXPath("//*[@text='OK']", text2);
							goto IL_0f1c;
							IL_0f1c:
							ac28BD29_0.TimeDelay(1.0);
							if (Environment.TickCount - tickCount < num10 * 1000)
							{
								continue;
							}
							goto IL_1220;
							IL_082d:
							if (flag7)
							{
								ac28BD29_0.TapByXPath("//*[@content-desc='Back']", text2);
							}
							else
							{
								flag7 = true;
								SetStatusAccount(int_2, text4 + "Tap " + ac28BD29_0.method_105(text3) + "...");
								ac28BD29_0.TapByXPath(text3, text2);
							}
							goto IL_0f1c;
							IL_0594:
							string text14 = ac28BD29_0.FindElements(0, text2, "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View").FirstOrDefault();
							if (!string.IsNullOrEmpty(text14) && new Class65(text14).B9898119 < 2000)
							{
								Class65 class5 = new Class65(text14);
								Class65 class6 = new Class65(class5.int_0, 2000, class5.int_1, 2000);
								ac28BD29_0.method_52(class5.AA3F9A29(), class6.AA3F9A29());
							}
							else
							{
								List<Class65> list6 = Class65.smethod_2(text2, text3 + "/parent::*/child::*");
								if (list6.Count <= 1)
								{
									list6 = Class65.smethod_2(text2, "(" + text3 + "/parent::*/parent::*/child::*)[last()]/child::*");
								}
								if (list6.Count > 1 && list6[0].E42395AA < 2300)
								{
									if (!method_52(int_2, text4 + $"({num5 + 1}/{num6}), ", ac28BD29_0, text, 1, bool_))
									{
										break;
									}
									ac28BD29_0.E832B991(list6[1].AA3F9A29());
								}
								else
								{
									ac28BD29_0.CE16082B(2);
								}
							}
							goto IL_0f1c;
							IL_0db3:
							ac28BD29_0.method_40(0, text3, text2);
							goto IL_0f1c;
							IL_08cf:
							if (ac28BD29_0.DoesElementExist(0, text2, "//*[@content-desc='Public']") || num8 == num9 || text3 == "//android.widget.EditText[starts-with(@text,'Describe your reel')]" || text3 == "//android.widget.EditText[starts-with(@text,'Write a description')]")
							{
								if ((ac28BD29_0.DoesElementExist(0, text2, "//android.widget.EditText[starts-with(@text,'Describe your reel')]") || ac28BD29_0.DoesElementExist(0, text2, "//android.widget.EditText[starts-with(@text,'Write a description')]")) && flag)
								{
									text13 = "";
									if (!flag2)
									{
										if (list3.Count == 0)
										{
											list3 = Common.smethod_11(dictionary_2[FA3C83B4]);
										}
										text13 = list3.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
										list3.Remove(text13);
										goto IL_0a29;
									}
									lock (dictionary_2)
									{
										if (dictionary_2[FA3C83B4].Count == 0)
										{
											break;
										}
										int index = random_0.Next(0, dictionary_2[FA3C83B4].Count);
										text13 = dictionary_2[FA3C83B4][index];
										dictionary_2[FA3C83B4].RemoveAt(index);
										goto IL_0a29;
									}
								}
								goto IL_0b5a;
							}
							num8++;
							SetStatusAccount(int_2, text4 + "Tap " + ac28BD29_0.method_105(text3) + "...");
							ac28BD29_0.TapByXPath(text3, text2);
							goto IL_0f1c;
						}
						break;
					}
				}
				catch
				{
					continue;
				}
				break;
				IL_1220:;
			}
			end_IL_01e0:;
		}
		catch
		{
		}
		goto IL_1230;
		IL_1230:
		int_1 = num5;
		return num5;
	}

	public int method_55(int int_1, string string_0, AC28BD29 F1965C1D, JSON_Settings AD809689, string D2A3AF3C, string string_1)
	{
		int minValue = AD809689.method_0("nudSoLuongFrom", 1);
		int num = AD809689.method_0("nudSoLuongTo", 1);
		int minValue2 = AD809689.method_0("nudKhoangCachFrom");
		int num2 = AD809689.method_0("nudKhoangCachTo");
		bool flag = AD809689.AA824D29("ckbVanBan");
		bool flag2 = AD809689.AA824D29("ckbUseBackground");
		bool flag3 = AD809689.AA824D29("ckbXoaNguyenLieuDaDung");
		bool flag4 = AD809689.AA824D29("ckbAnh");
		string aF2C0C = AD809689.GetValue("txtPathAnh");
		int minValue3 = AD809689.method_0("nudSoLuongAnhFrom");
		int num3 = AD809689.method_0("nudSoLuongAnhTo");
		bool flag5 = AD809689.AA824D29("ckbDangLink");
		List<string> list = AD809689.EC378D8A("txtLinkShare");
		bool flag6 = AD809689.AA824D29("ckbXoaLink");
		int num4 = 0;
		string text = "";
		string text2 = "";
		try
		{
			string text3 = string_0 + Language.GetValue("Đang") + " " + D2A3AF3C + ": ";
			if (!flag || dictionary_3[string_1].Count != 0)
			{
				List<string> list2 = new List<string>();
				if (!flag3)
				{
					list2 = Common.smethod_11(dictionary_3[string_1]);
				}
				int num5 = random_0.Next(minValue, num + 1);
				for (int i = 0; i < num5 + 5; i++)
				{
					if (num4 >= num5)
					{
						break;
					}
					SetStatusAccount(int_1, text3 + $"({num4 + 1}/{num5})...");
					try
					{
						if (!F1965C1D.DoesElementExist(0, "", "//android.view.ViewGroup[@content-desc=\"Make a post on Facebook\"]"))
						{
							SetStatusAccount(int_1, text3 + $"({num4 + 1}/{num5}), Go to Home...");
							F1965C1D.D7950A0F();
							F1965C1D.TimeDelay(2.0);
						}
						int tickCount = Environment.TickCount;
						int num6 = 300;
						while (true)
						{
							text = F1965C1D.GetPageSource();
							text2 = F1965C1D.FindElement(0, text, new List<string> { "//android.view.ViewGroup[@content-desc=\"Make a post on Facebook\"]", "//*[@content-desc='POST'][@enabled='true']", "//android.widget.EditText", "//android.view.View[@content-desc='Public']", "//android.widget.TextView[@text='Choose default audience']" });
							string text4;
							switch (text2)
							{
							case "//android.view.ViewGroup[@content-desc=\"Make a post on Facebook\"]":
							case "//android.view.View[@content-desc='Public']":
								SetStatusAccount(int_1, text3 + "Tap " + F1965C1D.method_105(text2) + "...");
								F1965C1D.TapByXPath(text2, text);
								goto IL_024c;
							default:
								SetStatusAccount(int_1, text3 + $"({num4 + 1}/{num5}), Scroll...");
								if (F1965C1D.CE16082B(-1))
								{
									int num7 = method_22(F1965C1D, int_1, string_0);
									if (num7 == 1 || num7 == 0)
									{
										break;
									}
									return num4;
								}
								goto IL_024c;
							case "//android.widget.TextView[@text='Choose default audience']":
							{
								bool flag7 = false;
								if (F1965C1D.method_40(5, "//android.widget.Button[@content-desc=\"Public Anyone on or off Facebook\"]", ""))
								{
									flag7 = F1965C1D.method_43("", 5, "//*[@text='Done']", "//*[@text='Save']");
								}
								if (!flag7)
								{
									F1965C1D.method_40(5, "//android.widget.ImageView[@content-desc=\"Back\"]", "");
									F1965C1D.TimeDelay(2.0);
								}
								goto IL_024c;
							}
							case "//android.widget.EditText":
								if (!F1965C1D.C60AEB35(0, ref text, "//android.view.ViewGroup[@content-desc=\"Choose privacy Public\"]"))
								{
									bool flag9 = false;
									F1965C1D.method_40(0, "//android.view.ViewGroup[contains(@content-desc,\"Choose privacy\")]", text);
									if (F1965C1D.method_40(5, "//android.widget.Button[@content-desc=\"Public Anyone on or off Facebook\"]", ""))
									{
										flag9 = F1965C1D.method_40(5, "//android.widget.Button[@text='Done']", "");
									}
									if (!flag9)
									{
										F1965C1D.method_40(5, "//android.widget.ImageView[@content-desc=\"Back\"]", "");
										F1965C1D.TimeDelay(2.0);
									}
								}
								if (flag5)
								{
									F1965C1D.method_54(1.0, 1.5);
									SetStatusAccount(int_1, text3 + $"({num4 + 1}/{num5}), " + Language.GetValue("Nhập dữ liệu..."));
									F1965C1D.SendByXPath("//android.widget.EditText", list[int_1 % list.Count]);
									F1965C1D.method_54(1.0, 1.5);
									F1965C1D.B2016D94(AC28BD29.DB353F82.const_62);
									F1965C1D.method_54(1.0, 1.5);
									F1965C1D.DoesElementExist(15, "", "//*[@content-desc='Remove']");
									F1965C1D.method_54(2.0, 3.0);
									if (flag6)
									{
										F1965C1D.method_31("//android.widget.EditText");
										F1965C1D.method_54(1.0, 1.5);
									}
								}
								if (flag)
								{
									text4 = "";
									if (!flag3)
									{
										if (list2.Count == 0)
										{
											list2 = Common.smethod_11(dictionary_3[string_1]);
										}
										text4 = list2.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
										list2.Remove(text4);
										goto IL_05d9;
									}
									lock (dictionary_3)
									{
										if (dictionary_3[string_1].Count != 0)
										{
											int index = random_0.Next(0, dictionary_3[string_1].Count);
											text4 = dictionary_3[string_1][index];
											dictionary_3[string_1].RemoveAt(index);
											goto IL_05d9;
										}
									}
									return num4;
								}
								goto IL_075a;
							case "//*[@content-desc='POST'][@enabled='true']":
								{
									SetStatusAccount(int_1, text3 + "Tap " + F1965C1D.method_105(text2) + "...");
									F1965C1D.TapByXPath(text2, text);
									SetStatusAccount(int_1, text3 + $"({num4 + 1}/{num5}), Tap Post, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(3, 6));
									SetStatusAccount(int_1, text3 + $"({num4 + 1}/{num5}), " + Language.GetValue("đợi") + " post success...");
									if (F1965C1D.method_30(flag4 ? 300 : 60))
									{
										num4++;
										if (num4 >= num5)
										{
											return num4;
										}
										SetStatusAccount(int_1, text3 + $"({num4 + 1}/{num5}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
									}
									break;
								}
								IL_05d9:
								text4 = Common.SpinText(text4);
								if (text4.Trim() != "")
								{
									F1965C1D.method_54(1.0, 1.5);
									SetStatusAccount(int_1, text3 + $"({num4 + 1}/{num5}), " + Language.GetValue("Nhập dữ liệu..."));
									if (flag5 && !flag6)
									{
										text4 = F1965C1D.method_23("", "//android.widget.EditText", "text").First() + text4;
									}
									F1965C1D.SendByXPath("//android.widget.EditText", text4);
									F1965C1D.method_54(1.0, 1.5);
									F1965C1D.B2016D94(AC28BD29.DB353F82.const_62);
									F1965C1D.method_54(1.0, 1.5);
									if (flag2)
									{
										SetStatusAccount(int_1, text3 + $"({num4 + 1}/{num5}), Find background...");
										List<string> list3 = F1965C1D.FindElements(0, "", "//android.view.ViewGroup[contains(@content-desc,\", background\")]");
										if (list3.Count > 2)
										{
											list3.RemoveAt(list3.Count - 1);
											SetStatusAccount(int_1, text3 + $"({num4 + 1}/{num5}), Tap background...");
											F1965C1D.E832B991(list3.smethod_8());
										}
									}
								}
								goto IL_075a;
								IL_075a:
								if (flag4)
								{
									int num8 = Base.rd.Next(minValue3, num3 + 1);
									if (method_52(int_1, text3 + $"({num4 + 1}/{num5}), ", F1965C1D, aF2C0C, num8))
									{
										F1965C1D.method_40(5, "//android.view.ViewGroup[@content-desc='Photo/video']", "");
										bool flag8 = false;
										for (int j = 0; j < 10; j++)
										{
											text = F1965C1D.GetPageSource();
											text2 = F1965C1D.FindElement(0, text, new List<string> { "//android.widget.Button[@text='ALLOW']", "//android.view.ViewGroup[@content-desc='Allow access']", "//android.view.ViewGroup[@content-desc='Choose layout']", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']" });
											if (!(text2 == "//android.view.ViewGroup[@content-desc='Choose layout']") && !(text2 == "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
											{
												if (text2 != "")
												{
													SetStatusAccount(int_1, text3 + "Tap " + F1965C1D.method_105(text2) + "...");
													F1965C1D.TapByXPath(text2, text);
												}
												else
												{
													F1965C1D.CE16082B(-1);
												}
												F1965C1D.TimeDelay(1.0);
												continue;
											}
											if (!F1965C1D.DoesElementExist(0, text, "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
											{
												break;
											}
											if (F1965C1D.method_40(0, "//android.view.ViewGroup[@content-desc='Select multiple']", text))
											{
												F1965C1D.TimeDelay(2.0);
											}
											List<string> list4 = F1965C1D.FindElements(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']");
											for (int k = 0; k < 5; k++)
											{
												for (int l = 0; l < num8; l++)
												{
													while (list4.Count == 0)
													{
														SetStatusAccount(int_1, text3 + "Scroll...");
														if (F1965C1D.CE16082B())
														{
															break;
														}
														list4 = F1965C1D.FindElements(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']");
													}
													if (list4.Count == 0)
													{
														break;
													}
													string text5 = list4.OrderBy((string F911C492) => Guid.NewGuid()).FirstOrDefault();
													list4.Remove(text5);
													F1965C1D.method_36(new Class65(text5).method_0());
												}
												if (list4.Count == 0 || F1965C1D.FindElements(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='true']").Count >= num8)
												{
													break;
												}
											}
											F1965C1D.method_40(0, "//android.view.ViewGroup[@content-desc='NEXT']", "");
											flag8 = true;
											break;
										}
										if (!flag8)
										{
											F1965C1D.method_19();
										}
									}
								}
								goto IL_024c;
								IL_024c:
								F1965C1D.TimeDelay(1.0);
								if (Environment.TickCount - tickCount < num6 * 1000)
								{
									continue;
								}
								break;
							}
							break;
						}
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
		return num4;
	}

	public int A031C48E(int int_1, string DA361C8C, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_0, string ADBC661F)
	{
		int minValue = f72FAFBC_0.method_0("nudSoLuongFrom", 1);
		int num = f72FAFBC_0.method_0("nudSoLuongTo", 1);
		int minValue2 = f72FAFBC_0.method_0("nudKhoangCachFrom");
		int num2 = f72FAFBC_0.method_0("nudKhoangCachTo");
		int num3 = f72FAFBC_0.method_0("typeNhom");
		bool flag = f72FAFBC_0.AA824D29("ckbChiShareNhomKKD");
		bool flag2 = f72FAFBC_0.AA824D29("ckbUuTienShareNhomNhieuThanhVien");
		bool flag3 = f72FAFBC_0.AA824D29("ckbBackupDanhSachNhom");
		bool flag4 = f72FAFBC_0.AA824D29("ckbKhongShareTrungNhom");
		bool flag5 = f72FAFBC_0.AA824D29("ckbChiShareNhomThuocDanhSach");
		List<string> f1808BA = f72FAFBC_0.EC378D8A("lstNhomTuNhap");
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		bool flag6 = f72FAFBC_0.AA824D29("ckbTuDongXoaUid");
		bool flag7 = f72FAFBC_0.AA824D29("ckbVanBan");
		bool flag8 = f72FAFBC_0.AA824D29("ckbUseBackground");
		bool flag9 = f72FAFBC_0.AA824D29("ckbXoaNguyenLieuDaDung");
		bool flag10 = f72FAFBC_0.AA824D29("ckbAnh");
		string aF2C0C = f72FAFBC_0.GetValue("txtPathAnh");
		int minValue3 = f72FAFBC_0.method_0("nudSoLuongAnhFrom");
		int num4 = f72FAFBC_0.method_0("nudSoLuongAnhTo");
		bool flag11 = f72FAFBC_0.AA824D29("ckbDangLink");
		List<string> list = f72FAFBC_0.EC378D8A("txtLinkShare");
		bool flag12 = f72FAFBC_0.AA824D29("ckbXoaLink");
		bool flag13 = f72FAFBC_0.AA824D29("ckbEvent");
		string text = f72FAFBC_0.GetValue("txtEvent");
		bool flag14 = f72FAFBC_0.AA824D29("ckbXuatLinkBaiViet");
		if (!E2AC9E1F.ContainsKey(ADBC661F))
		{
			E2AC9E1F.Add(ADBC661F, new List<string>());
		}
		int num5 = 0;
		try
		{
			string text2 = DA361C8C + Language.GetValue("Đang") + " " + string_0 + ": ";
			if (!flag7 || dictionary_4[ADBC661F].Count != 0)
			{
				List<string> list2 = new List<string>();
				if (!flag9)
				{
					list2 = Common.smethod_11(dictionary_4[ADBC661F]);
				}
				List<string> list3 = new List<string>();
				if (num3 == 0 || num3 == 1)
				{
					switch (num3)
					{
					case 0:
					{
						SetStatusAccount(int_1, text2 + "Scan groups...");
						string text3 = ac28BD29_0.AF03B30E().Split('|')[1];
						string value = Regex.Match(text3, "c_user=(\\d+)").Groups[1].Value;
						bool flag15 = true;
						List<string> list4 = new List<string>();
						if (flag3 && File.Exists("backupgroup\\" + value + ".txt"))
						{
							list4 = Common.E00852A6("backupgroup\\" + value + ".txt");
							if (list4.Count > 0)
							{
								string[] array = list4[0].Split('|');
								flag15 = array.Length < 4 || !new string[2] { "true", "false" }.Contains(array[3].ToLower());
							}
						}
						if (flag15)
						{
							SetStatusAccount(int_1, DA361C8C + Language.GetValue("Scan group..."));
							list4 = EA98BF20.smethod_1(text3, ac28BD29_0.Proxy, ac28BD29_0.int_1, flag);
						}
						if (list4.Count != 0)
						{
							if (flag3)
							{
								File.WriteAllLines("backupgroup\\" + value + ".txt", list4);
							}
							list3 = ((!flag) ? list4.Select((string FCBF9215) => FCBF9215).ToList() : list4.Where((string string_0) => string_0.Split('|')[3].ToLower() == "false").ToList());
							if (flag2)
							{
								list3.Sort((string string_0, string F5144D9D) => int.Parse(F5144D9D.Split('|')[2]).CompareTo(int.Parse(string_0.Split('|')[2])));
							}
							else
							{
								list3 = list3.OrderBy((string string_0) => Guid.NewGuid()).ToList();
							}
							list3 = list3.Select((string string_0) => string_0.Split('|')[0]).ToList();
							if (flag5)
							{
								list3 = list3.Intersect(f1808BA).ToList();
							}
							goto default;
						}
						goto end_IL_01ab;
					}
					case 1:
						list3 = EE98FB8B(B68B3D0D[ADBC661F]);
						goto default;
					default:
						if (list3.Count != 0)
						{
							break;
						}
						goto end_IL_01ab;
					}
				}
				int num6 = random_0.Next(minValue, num + 1);
				string text4 = "";
				string text5 = "";
				string text6 = "";
				for (int i = 0; i < num6 + 5 && num5 < num6; i++)
				{
					switch (num3)
					{
					case 0:
						if (list3.Count != 0)
						{
							if (!flag4)
							{
								int index3 = random_0.Next(0, list3.Count);
								if (flag2)
								{
									index3 = 0;
								}
								text6 = list3[index3];
								list3.RemoveAt(index3);
								break;
							}
							while (list3.Count != 0)
							{
								int index4 = random_0.Next(0, list3.Count);
								if (flag2)
								{
									index4 = 0;
								}
								text6 = list3[index4];
								list3.RemoveAt(index4);
								lock (E2AC9E1F)
								{
									if (E2AC9E1F[ADBC661F].Contains(text6))
									{
										continue;
									}
									E2AC9E1F[ADBC661F].Add(text6);
									goto end_IL_04ff;
								}
							}
						}
						goto end_IL_01ab;
					case 1:
						if (list3.Count != 0)
						{
							if (!flag6)
							{
								int index = random_0.Next(0, list3.Count);
								text6 = list3[index];
								list3.RemoveAt(index);
								break;
							}
							lock (B68B3D0D)
							{
								if (B68B3D0D[ADBC661F].Count != 0)
								{
									int index2 = random_0.Next(0, B68B3D0D[ADBC661F].Count);
									text6 = B68B3D0D[ADBC661F][index2];
									B68B3D0D[ADBC661F].RemoveAt(index2);
									break;
								}
							}
						}
						goto end_IL_01ab;
					default:
						{
							f72FAFBC_0.GetValue("nudSoLuongFrom", 1);
							f72FAFBC_0.GetValue("nudSoLuongTo", 1);
							B1B3FD1A(int_1, text2 + $"({num5 + 1}/{num6}), " + "Tạo nhóm", ac28BD29_0, f72FAFBC_0, "...");
							if (!ac28BD29_0.method_43("", 5, "//*[@text='Next']") || !ac28BD29_0.method_43("", 5, "//*[@text='Continue later']") || !ac28BD29_0.method_43("", 5, "//*[@text='CONFIRM']"))
							{
								continue;
							}
							break;
						}
						end_IL_04ff:
						break;
					}
					try
					{
						while (true)
						{
							IL_12d9:
							if (num3 == 0 || num3 == 1)
							{
								SetStatusAccount(int_1, text2 + $"({num5 + 1}/{num6}), Go to group {text6}...");
								if (!FA905AA0(ac28BD29_0, int_1, text2, "fb://group/" + text6))
								{
									break;
								}
							}
							int num7 = 0;
							int tickCount = Environment.TickCount;
							int num8 = 300;
							do
							{
								text4 = ac28BD29_0.GetPageSource();
								text5 = ac28BD29_0.FindElement(0, text4, new List<string> { "//android.view.ViewGroup[starts-with(@content-desc, \"Write something\")]", "//android.view.ViewGroup[@content-desc='Discussion']", "//android.view.ViewGroup[@content-desc='Cancel request']", "//*[starts-with(@content-desc, 'Join ')]", "//android.view.ViewGroup[@content-desc=\"Submit\"]", "//*[@content-desc='POST'][@enabled='true']", "//android.widget.EditText", "//android.view.View[@content-desc='Public']" });
								string text7 = text5;
								string text8 = text7;
								uint num9 = HashString.DA8CEBAB(text8);
								string text10;
								if (num9 > 1964222373)
								{
									if (num9 <= 2686990081u)
									{
										if (num9 != 2593578165u)
										{
											if (num9 == 2686990081u && text8 == "//*[starts-with(@content-desc, 'Join ')]")
											{
												if (num7 >= 2)
												{
													break;
												}
												int count = ac28BD29_0.FindElements(0, text4, text5).Count;
												if (count == 1)
												{
													num7++;
													SetStatusAccount(int_1, text2 + "Tap " + ac28BD29_0.method_105(text5) + "...");
													ac28BD29_0.TapByXPath(text5, text4);
												}
												else
												{
													if (!ac28BD29_0.DoesElementExist(0, text4, "//*[@content-desc='Invite Members' or starts-with(@content-desc,'invite others to join')]"))
													{
														break;
													}
													ac28BD29_0.CE16082B();
												}
												goto IL_099d;
											}
										}
										else if (text8 == "//android.view.ViewGroup[@content-desc='Discussion']")
										{
											goto IL_096d;
										}
									}
									else if (num9 != 2689758236u)
									{
										if (num9 == 3698172066u && text8 == "//android.view.ViewGroup[@content-desc='Cancel request']")
										{
											break;
										}
									}
									else if (text8 == "//android.view.ViewGroup[starts-with(@content-desc, \"Write something\")]")
									{
										goto IL_096d;
									}
								}
								else if (num9 <= 819242523)
								{
									if (num9 != 16665493)
									{
										if (num9 == 819242523 && text8 == "//android.view.ViewGroup[@content-desc=\"Submit\"]")
										{
											break;
										}
									}
									else if (text8 == "//*[@content-desc='POST'][@enabled='true']")
									{
										SetStatusAccount(int_1, text2 + "Tap " + ac28BD29_0.method_105(text5) + "...");
										ac28BD29_0.TapByXPath(text5, text4);
										SetStatusAccount(int_1, text2 + $"({num5 + 1}/{num6}), Tap Post, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(3, 6));
										text4 = "";
										if (ac28BD29_0.C60AEB35(5, ref text4, "//*[@content-desc='Not now']"))
										{
											ac28BD29_0.TapByXPath("//*[@content-desc='Not now']", text4);
											ac28BD29_0.TimeDelay(3.0);
										}
										SetStatusAccount(int_1, text2 + $"({num5 + 1}/{num6}), " + Language.GetValue("đợi") + " post success...");
										if (!ac28BD29_0.method_30(flag10 ? 300 : 60))
										{
											break;
										}
										if (flag14)
										{
											bool flag16 = ac28BD29_0.method_40(5, "//*[@content-desc='Show profile']", "");
											for (int j = 0; j < 10; j++)
											{
												text4 = ac28BD29_0.GetPageSource();
												if (!ac28BD29_0.TapByXPath("//*[@content-desc='Post menu']", text4))
												{
													if (ac28BD29_0.DoesElementExist(0, text4, "//*[@content-desc='Admin']"))
													{
														ac28BD29_0.CE16082B(1, 1, 3000);
													}
													ac28BD29_0.TimeDelay(2.0);
													continue;
												}
												flag16 = true;
												break;
											}
											if (flag16)
											{
												flag16 = ac28BD29_0.BD33F0BA("dataimage\\copylink", null, 10);
											}
											if (flag16)
											{
												string text9 = ac28BD29_0.method_20();
												if (!string.IsNullOrEmpty(text9))
												{
													method_56(text9 ?? "");
												}
											}
										}
										num5++;
										if (num5 < num6)
										{
											SetStatusAccount(int_1, text2 + $"({num5 + 1}/{num6}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
											break;
										}
										return num5;
									}
								}
								else if (num9 != 1740273391)
								{
									if (num9 == 1964222373 && text8 == "//android.widget.EditText")
									{
										if (flag11)
										{
											ac28BD29_0.method_54(1.0, 1.5);
											SetStatusAccount(int_1, text2 + $"({num5 + 1}/{num6}), " + Language.GetValue("Nhập dữ liệu..."));
											ac28BD29_0.SendByXPath("//android.widget.EditText", list[int_1 % list.Count]);
											ac28BD29_0.method_54(1.0, 1.5);
											ac28BD29_0.B2016D94(AC28BD29.DB353F82.const_62);
											ac28BD29_0.method_54(1.0, 1.5);
											ac28BD29_0.DoesElementExist(15, "", "//*[@content-desc='Remove']");
											ac28BD29_0.method_54(2.0, 3.0);
											if (flag12)
											{
												ac28BD29_0.method_31("//android.widget.EditText");
												ac28BD29_0.method_54(1.0, 1.5);
											}
										}
										if (flag7)
										{
											text10 = "";
											if (!flag9)
											{
												if (list2.Count == 0)
												{
													list2 = Common.smethod_11(dictionary_4[ADBC661F]);
												}
												text10 = list2.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
												list2.Remove(text10);
												goto IL_0c37;
											}
											lock (dictionary_4)
											{
												if (dictionary_4[ADBC661F].Count != 0)
												{
													int index5 = random_0.Next(0, dictionary_4[ADBC661F].Count);
													text10 = dictionary_4[ADBC661F][index5];
													dictionary_4[ADBC661F].RemoveAt(index5);
													goto IL_0c37;
												}
											}
											return num5;
										}
										goto IL_0d8b;
									}
								}
								else if (text8 == "//android.view.View[@content-desc='Public']")
								{
									goto IL_096d;
								}
								if (ac28BD29_0.ED9CDB24(text4, "This content isn't available", "When this happens, it's usually because the owner only shared it with a small group of people, changed who can see it or it's been deleted.", "Reload page", "Something went wrong"))
								{
									break;
								}
								SetStatusAccount(int_1, text2 + $"({num5 + 1}/{num6}), Scroll...");
								bool flag17 = false;
								if ((num7 <= 0) ? ac28BD29_0.CE16082B(-1) : ac28BD29_0.CE16082B())
								{
									switch (method_22(ac28BD29_0, int_1, DA361C8C))
									{
									case 1:
										break;
									case 0:
										goto end_IL_0777;
									default:
										return num5;
									}
									goto IL_12d9;
								}
								goto IL_099d;
								IL_0d8b:
								if (flag10)
								{
									int num10 = Base.rd.Next(minValue3, num4 + 1);
									if (method_52(int_1, text2 + $"({num5 + 1}/{num6}), ", ac28BD29_0, aF2C0C, num10))
									{
										ac28BD29_0.method_40(5, "//android.view.ViewGroup[@content-desc='Photo/video']", "");
										for (int k = 0; k < 10; k++)
										{
											text4 = ac28BD29_0.GetPageSource();
											text5 = ac28BD29_0.FindElement(0, text4, new List<string> { "//android.widget.Button[@text='ALLOW']", "//android.view.ViewGroup[@content-desc='Allow access']", "//android.view.ViewGroup[@content-desc='Choose layout']", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']" });
											if (!(text5 == "//android.view.ViewGroup[@content-desc='Choose layout']") && !(text5 == "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
											{
												if (text5 != "")
												{
													SetStatusAccount(int_1, text2 + "Tap " + ac28BD29_0.method_105(text5) + "...");
													ac28BD29_0.TapByXPath(text5, text4);
												}
												else
												{
													ac28BD29_0.CE16082B(-1);
												}
												ac28BD29_0.TimeDelay(1.0);
												continue;
											}
											if (!ac28BD29_0.DoesElementExist(0, text4, "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
											{
												break;
											}
											if (ac28BD29_0.method_40(0, "//android.view.ViewGroup[@content-desc='Select multiple']", text4))
											{
												ac28BD29_0.TimeDelay(2.0);
											}
											List<string> list5 = ac28BD29_0.FindElements(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']");
											for (int l = 0; l < 5; l++)
											{
												for (int m = 0; m < num10; m++)
												{
													while (list5.Count == 0)
													{
														SetStatusAccount(int_1, text2 + "Scroll...");
														if (ac28BD29_0.CE16082B())
														{
															break;
														}
														list5 = ac28BD29_0.FindElements(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']");
													}
													if (list5.Count == 0)
													{
														break;
													}
													string text11 = list5.OrderBy((string D6BF94B2) => Guid.NewGuid()).FirstOrDefault();
													list5.Remove(text11);
													ac28BD29_0.method_36(new Class65(text11).method_0());
												}
												if (list5.Count == 0 || ac28BD29_0.FindElements(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='true']").Count >= num10)
												{
													break;
												}
											}
											ac28BD29_0.method_40(0, "//android.view.ViewGroup[@content-desc='NEXT']", "");
											break;
										}
									}
								}
								if (flag13)
								{
									for (int n = 0; n < 10; n++)
									{
										text4 = ac28BD29_0.GetPageSource();
										text5 = ac28BD29_0.FindElement(0, text4, new List<string> { "//*[@content-desc='Add more to your post']", "//android.widget.EditText[@text='Search Events']" });
										if (text5 == "//*[@content-desc='Add more to your post']")
										{
											string text12 = "//*[@content-desc='Add more to your post']/parent::*/parent::*/parent::*/child::*[last()]//androidx.recyclerview.widget.RecyclerView/child::*";
											if (ac28BD29_0.DoesElementExist(0, text4, text12))
											{
												ac28BD29_0.CE16082B();
												ac28BD29_0.TimeDelay(1.0);
												if (!ac28BD29_0.method_40(2, "//*[@content-desc='Tag event']", ""))
												{
													ac28BD29_0.method_53(ac28BD29_0.FindElements(0, "", text12 + "[1]").First(), ac28BD29_0.FindElements(0, "", text12 + "[last()]").First());
													break;
												}
												continue;
											}
											SetStatusAccount(int_1, text2 + "Tap " + ac28BD29_0.method_105(text5) + "...");
											ac28BD29_0.TapByXPath(text5, text4);
										}
										else if (text5 == "//android.widget.EditText[@text='Search Events']")
										{
											ac28BD29_0.SendByXPath(text5, text + " ");
											ac28BD29_0.TimeDelay(1.0);
											ac28BD29_0.B2016D94(AC28BD29.DB353F82.const_67);
											ac28BD29_0.TimeDelay(3.0);
											ac28BD29_0.method_30(10);
										}
										else if (ac28BD29_0.DoesElementExist(0, text4, "//*[@text='Select an Event to Tag']"))
										{
											string text13 = ac28BD29_0.FindElements(5, text4, "//androidx.recyclerview.widget.RecyclerView/child::*").FirstOrDefault();
											if (string.IsNullOrEmpty(text13))
											{
												ac28BD29_0.TapByXPath("//*[@content-desc='Back']");
											}
											else
											{
												ac28BD29_0.E832B991(text13);
											}
											ac28BD29_0.TimeDelay(2.0);
											break;
										}
										ac28BD29_0.TimeDelay(1.0);
									}
								}
								goto IL_099d;
								IL_099d:
								ac28BD29_0.TimeDelay(2.0);
								continue;
								IL_096d:
								SetStatusAccount(int_1, text2 + "Tap " + ac28BD29_0.method_105(text5) + "...");
								ac28BD29_0.TapByXPath(text5, text4);
								goto IL_099d;
								IL_0c37:
								text10 = Common.SpinText(text10);
								if (text10.Trim() != "")
								{
									ac28BD29_0.method_54(1.0, 1.5);
									SetStatusAccount(int_1, text2 + $"({num5 + 1}/{num6}), " + Language.GetValue("Nhập dữ liệu..."));
									if (flag11 && !flag12)
									{
										text10 = ac28BD29_0.method_23("", "//android.widget.EditText", "text").First() + text10;
									}
									ac28BD29_0.SendByXPath("//android.widget.EditText", text10);
									ac28BD29_0.method_54(1.0, 1.5);
									ac28BD29_0.B2016D94(AC28BD29.DB353F82.const_62);
									ac28BD29_0.method_54(1.0, 1.5);
									if (flag8)
									{
										SetStatusAccount(int_1, text2 + $"({num5 + 1}/{num6}), Tap Background...");
										List<string> list6 = ac28BD29_0.FindElements(0, "", "//android.view.ViewGroup[contains(@content-desc,\", background\")]");
										if (list6.Count > 2)
										{
											list6.RemoveAt(list6.Count - 1);
											ac28BD29_0.E832B991(list6.smethod_8());
										}
									}
								}
								goto IL_0d8b;
							}
							while (Environment.TickCount - tickCount < num8 * 1000);
							break;
						}
						end_IL_0777:;
					}
					catch
					{
					}
				}
			}
			end_IL_01ab:;
		}
		catch
		{
		}
		return num5;
	}

	private void method_56(string string_0)
	{
		lock (FF808304)
		{
			File.AppendAllText("posts.txt", string_0 + Environment.NewLine);
		}
	}

	private bool method_57(int F4285B9F, string string_0, AC28BD29 ac28BD29_0, string string_1, string string_2)
	{
		return false;
	}

	public int B930AA3D(int int_1, string string_0, AC28BD29 A1BEA902, JSON_Settings D5366306, string string_1, string string_2)
	{
		int minValue = D5366306.method_0("nudSoLuongFrom", 1);
		int num = D5366306.method_0("nudSoLuongTo", 1);
		int minValue2 = D5366306.method_0("nudKhoangCachFrom");
		int num2 = D5366306.method_0("nudKhoangCachTo");
		int num3 = D5366306.method_0("typeNhom");
		bool flag = D5366306.AA824D29("ckbTuDongXoaUid");
		D5366306.AA824D29("ckbChiDangNhomKKD");
		bool flag2 = D5366306.AA824D29("ckbVanBan");
		bool flag3 = D5366306.AA824D29("ckbUseBackground");
		bool flag4 = D5366306.AA824D29("ckbXoaNguyenLieuDaDung");
		bool flag5 = D5366306.AA824D29("ckbHashtag");
		List<string> list = D5366306.EC378D8A("txtHashtag");
		int int_2 = D5366306.method_0("nudSoHashtagFrom", 1);
		int int_3 = D5366306.method_0("nudSoHashtagTo", 1);
		bool flag6 = D5366306.AA824D29("ckbAnh");
		string aF2C0C = D5366306.GetValue("txtPathAnh");
		bool bool_ = D5366306.AA824D29("ckbXoaAnhDaDang");
		int minValue3 = D5366306.method_0("nudSoLuongAnhFrom");
		int num4 = D5366306.method_0("nudSoLuongAnhTo");
		int num5 = 0;
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			if (dictionary_5[string_2].Count != 0)
			{
				List<string> list2 = new List<string>();
				if (!flag4)
				{
					list2 = Common.smethod_11(dictionary_5[string_2]);
				}
				List<string> list3 = new List<string>();
				if (num3 == 0)
				{
					SetStatusAccount(int_1, text + "Scan page...");
					string string_3 = A1BEA902.AF03B30E().Split('|')[1];
					list3 = EA98BF20.smethod_0(string_3, A1BEA902.Proxy, A1BEA902.int_1);
				}
				else
				{
					list3 = EE98FB8B(C292E829[string_2]);
				}
				if (list3.Count != 0)
				{
					int num6 = random_0.Next(minValue, num + 1);
					string text2 = "";
					string text3 = "";
					string text4 = "";
					int num7 = 0;
					while (num7 < num6 + 5 && num5 < num6 && list3.Count != 0)
					{
						if (num3 == 1 && flag)
						{
							lock (C292E829)
							{
								if (C292E829[string_2].Count == 0)
								{
									break;
								}
								int index = random_0.Next(0, C292E829[string_2].Count);
								text4 = C292E829[string_2][index];
								C292E829[string_2].RemoveAt(index);
								goto IL_0325;
							}
						}
						if (list3.Count != 0)
						{
							int index2 = random_0.Next(0, list3.Count);
							text4 = list3[index2];
							list3.RemoveAt(index2);
							goto IL_0325;
						}
						break;
						IL_0325:
						try
						{
							while (true)
							{
								IL_0ba1:
								SetStatusAccount(int_1, text + $"({num5 + 1}/{num6}), Go to page {text4}...");
								if (!FA905AA0(A1BEA902, int_1, text, "fb://page/" + text4))
								{
									break;
								}
								bool flag7 = false;
								int tickCount = Environment.TickCount;
								int num8 = 300;
								do
								{
									text2 = A1BEA902.GetPageSource();
									text3 = A1BEA902.FindElement(0, text2, new List<string>
									{
										"//*[@content-desc='Overview']", "//*[@content-desc='Create a post']", "//android.view.ViewGroup[starts-with(@content-desc, \"Write something\")]", "//android.view.ViewGroup[@content-desc='Discussion']", "//android.view.ViewGroup[@content-desc='Cancel request']", "//android.view.ViewGroup[@content-desc=\"Submit\"]", "//android.widget.EditText[@text='Help your video stand out with a title']", "//*[@content-desc='POST'][@enabled='true']", "//*[@content-desc='SHARE'][@enabled='true']", "//android.widget.EditText",
										"//android.view.View[@content-desc='Public']"
									});
									string text5 = text3;
									string text6 = text5;
									uint num9 = HashString.DA8CEBAB(text6);
									string text7;
									if (num9 > 1964222373)
									{
										if (num9 <= 2567919276u)
										{
											if (num9 != 2070156739)
											{
												if (num9 != 2419027548u)
												{
													if (num9 == 2567919276u && text6 == "//*[@content-desc='Create a post']")
													{
														goto IL_0486;
													}
												}
												else if (text6 == "//*[@content-desc='SHARE'][@enabled='true']")
												{
													goto IL_0bf0;
												}
											}
											else if (text6 == "//android.widget.EditText[@text='Help your video stand out with a title']")
											{
												A1BEA902.SendByXPath(text3, " ");
												goto IL_04b6;
											}
										}
										else if (num9 != 2593578165u)
										{
											if (num9 != 2689758236u)
											{
												if (num9 == 3698172066u && text6 == "//android.view.ViewGroup[@content-desc='Cancel request']")
												{
													break;
												}
											}
											else if (text6 == "//android.view.ViewGroup[starts-with(@content-desc, \"Write something\")]")
											{
												goto IL_0486;
											}
										}
										else if (text6 == "//android.view.ViewGroup[@content-desc='Discussion']")
										{
											goto IL_0486;
										}
									}
									else if (num9 <= 330244122)
									{
										if (num9 != 16665493)
										{
											if (num9 == 330244122 && text6 == "//*[@content-desc='Overview']")
											{
												goto IL_0486;
											}
										}
										else if (text6 == "//*[@content-desc='POST'][@enabled='true']")
										{
											goto IL_0bf0;
										}
									}
									else if (num9 != 819242523)
									{
										if (num9 != 1740273391)
										{
											if (num9 == 1964222373 && text6 == "//android.widget.EditText")
											{
												if (flag2)
												{
													text7 = "";
													if (!flag4)
													{
														if (list2.Count == 0)
														{
															list2 = Common.smethod_11(dictionary_5[string_2]);
														}
														text7 = list2.OrderBy((string FFB5FC1B) => Guid.NewGuid()).FirstOrDefault();
														list2.Remove(text7);
														goto IL_065d;
													}
													lock (dictionary_5)
													{
														if (dictionary_5[string_2].Count != 0)
														{
															int index3 = random_0.Next(0, dictionary_5[string_2].Count);
															text7 = dictionary_5[string_2][index3];
															dictionary_5[string_2].RemoveAt(index3);
															goto IL_065d;
														}
													}
													return num5;
												}
												goto IL_081e;
											}
										}
										else if (text6 == "//android.view.View[@content-desc='Public']")
										{
											goto IL_0486;
										}
									}
									else if (text6 == "//android.view.ViewGroup[@content-desc=\"Submit\"]")
									{
										break;
									}
									if (A1BEA902.ED9CDB24(text2, "This content isn't available", "When this happens, it's usually because the owner only shared it with a small group of people, changed who can see it or it's been deleted.", "Reload page"))
									{
										break;
									}
									SetStatusAccount(int_1, text + $"({num5 + 1}/{num6}), Scroll...");
									bool flag8 = false;
									if ((!flag7) ? A1BEA902.CE16082B(-1) : A1BEA902.CE16082B())
									{
										switch (method_22(A1BEA902, int_1, string_0))
										{
										case 1:
											break;
										case 0:
											goto end_IL_0326;
										default:
											return num5;
										}
										goto IL_0ba1;
									}
									goto IL_04b6;
									IL_04b6:
									A1BEA902.TimeDelay(2.0);
									continue;
									IL_081e:
									if (flag6)
									{
										int num10 = Base.rd.Next(minValue3, num4 + 1);
										if (method_52(int_1, text + $"({num5 + 1}/{num6}), ", A1BEA902, aF2C0C, num10, bool_))
										{
											A1BEA902.method_40(5, "//android.view.ViewGroup[@content-desc='Photo/video']", "");
											for (int i = 0; i < 10; i++)
											{
												text2 = A1BEA902.GetPageSource();
												text3 = A1BEA902.FindElement(0, text2, new List<string> { "//android.widget.Button[@text='ALLOW']", "//android.view.ViewGroup[@content-desc='Allow access']", "//android.view.ViewGroup[@content-desc='Choose layout']", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']" });
												if (!(text3 == "//android.view.ViewGroup[@content-desc='Choose layout']") && !(text3 == "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
												{
													if (text3 != "")
													{
														SetStatusAccount(int_1, text + "Tap " + A1BEA902.method_105(text3) + "...");
														A1BEA902.TapByXPath(text3, text2);
													}
													else
													{
														A1BEA902.CE16082B(-1);
													}
													A1BEA902.TimeDelay(1.0);
													continue;
												}
												if (!A1BEA902.DoesElementExist(0, text2, "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']"))
												{
													break;
												}
												if (A1BEA902.method_40(0, "//android.view.ViewGroup[@content-desc='Select multiple']", text2))
												{
													A1BEA902.TimeDelay(2.0);
												}
												List<string> list4 = A1BEA902.FindElements(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']");
												for (int j = 0; j < 5; j++)
												{
													for (int k = 0; k < num10; k++)
													{
														while (list4.Count == 0)
														{
															SetStatusAccount(int_1, text + "Scroll...");
															if (A1BEA902.CE16082B())
															{
																break;
															}
															list4 = A1BEA902.FindElements(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']");
														}
														if (list4.Count == 0)
														{
															break;
														}
														string text8 = list4.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
														list4.Remove(text8);
														A1BEA902.method_36(new Class65(text8).method_0());
													}
													if (list4.Count == 0 || A1BEA902.FindElements(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='true']").Count >= num10)
													{
														break;
													}
												}
												A1BEA902.method_40(0, "//android.view.ViewGroup[@content-desc='NEXT']", "");
												break;
											}
										}
									}
									goto IL_04b6;
									IL_0bf0:
									SetStatusAccount(int_1, text + "Tap " + A1BEA902.method_105(text3) + "...");
									A1BEA902.TapByXPath(text3, text2);
									A1BEA902.TimeDelay(2.0);
									A1BEA902.method_40(10, text3, "");
									SetStatusAccount(int_1, text + $"({num5 + 1}/{num6}), Tap Share, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(3, 6));
									SetStatusAccount(int_1, text + $"({num5 + 1}/{num6}), " + Language.GetValue("đợi") + " post success...");
									A1BEA902.CE16082B(-1);
									A1BEA902.TimeDelay(2.0);
									if (A1BEA902.method_30(flag6 ? 300 : 60))
									{
										num5++;
										if (num5 < num6)
										{
											SetStatusAccount(int_1, text + $"({num5 + 1}/{num6}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
											break;
										}
										return num5;
									}
									break;
									IL_065d:
									if (flag5)
									{
										text7 += "\n";
										list = D5366306.EC378D8A("txtHashtag");
										int num11 = Common.F413B12C(int_2, int_3);
										for (int l = 0; l < num11; l++)
										{
											if (list.Count == 0)
											{
												break;
											}
											string text9 = list.OrderBy((string string_0) => Guid.NewGuid()).First();
											list.Remove(text9);
											text7 = text7 + text9 + " ";
										}
										text7 = text7.Trim();
									}
									text7 = Common.SpinText(text7);
									if (text7.Trim() != "")
									{
										A1BEA902.method_54(1.0, 1.5);
										SetStatusAccount(int_1, text + $"({num5 + 1}/{num6}), " + Language.GetValue("Nhập dữ liệu..."));
										A1BEA902.SendByXPath("//android.widget.EditText", text7);
										A1BEA902.method_54(1.0, 1.5);
										A1BEA902.B2016D94(AC28BD29.DB353F82.const_62);
										A1BEA902.method_54(1.0, 1.5);
										if (flag3)
										{
											SetStatusAccount(int_1, text + $"({num5 + 1}/{num6}), Tap Background...");
											List<string> list5 = A1BEA902.FindElements(0, "", "//android.view.ViewGroup[contains(@content-desc,\", background\")]");
											if (list5.Count > 2)
											{
												list5.RemoveAt(list5.Count - 1);
												A1BEA902.E832B991(list5.smethod_8());
											}
										}
									}
									goto IL_081e;
									IL_0486:
									SetStatusAccount(int_1, text + "Tap " + A1BEA902.method_105(text3) + "...");
									A1BEA902.TapByXPath(text3, text2);
									goto IL_04b6;
								}
								while (Environment.TickCount - tickCount < num8 * 1000);
								break;
							}
							end_IL_0326:;
						}
						catch
						{
						}
						num7++;
					}
				}
			}
		}
		catch
		{
		}
		return num5;
	}

	public int method_58(int F202CA0D, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_1, string string_2, string string_3)
	{
		int num = f72FAFBC_0.method_0("typeHuyKetBan");
		int minValue = f72FAFBC_0.method_0("nudSoLuongFrom");
		int num2 = f72FAFBC_0.method_0("nudSoLuongTo");
		List<string> eBB1FDA = f72FAFBC_0.EC378D8A("txtUid");
		int minValue2 = f72FAFBC_0.method_0("nudDelayFrom");
		int num3 = f72FAFBC_0.method_0("nudDelayTo");
		List<string> list = f72FAFBC_0.EC378D8A("txtUidKhongHuyKetBan");
		int num4 = 0;
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_3 + ": ";
			int num5 = random_0.Next(minValue, num2 + 1);
			if (num5 > 0)
			{
				if (num == 0 && list.Count == 0)
				{
					List<string> list2 = new List<string>();
					string text2 = "//*[@content-desc='More options']";
					string string_4 = "";
					while (ac28BD29_0.B7873BB0() || FA905AA0(ac28BD29_0, F202CA0D, text, "fb://friends"))
					{
						list2 = ac28BD29_0.method_26(10, ref string_4, text2);
						if (list2.Count == 0)
						{
							break;
						}
						for (int i = 0; i < num5 + 10; i++)
						{
							switch (method_22(ac28BD29_0, F202CA0D, string_0))
							{
							case 0:
							{
								string text3 = list2.smethod_8();
								SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), Tap More options...");
								ac28BD29_0.B1BACBA0(string_4);
								if (!(text3 != "") || !ac28BD29_0.method_36(new Class65(text3).method_0()))
								{
									goto IL_0248;
								}
								string_4 = "";
								if (!ac28BD29_0.A92BECA1(10, ref string_4))
								{
									goto IL_0248;
								}
								ac28BD29_0.TimeDelay(1.0);
								ac28BD29_0.TapByXPath("//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup[last()]", string_4);
								ac28BD29_0.TimeDelay(1.0);
								if (!ac28BD29_0.method_40(10, "//android.widget.Button[@text='CONFIRM']", ""))
								{
									goto IL_0248;
								}
								num4++;
								if (num4 < num5)
								{
									SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num3 + 1));
									goto IL_0248;
								}
								SetStatusAccount(F202CA0D, text + $"({num4}/{num5}): Done!");
								goto end_IL_0068;
							}
							case 1:
								break;
							default:
								goto end_IL_0068;
								IL_0248:
								SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), Find {ac28BD29_0.method_105(text2)}...");
								string_4 = "";
								list2 = ac28BD29_0.method_26(5, ref string_4, text2);
								SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), Find {ac28BD29_0.method_105(text2)}: " + list2.Count);
								if (list2.Count != 0)
								{
									continue;
								}
								SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), Scroll...");
								if (!ac28BD29_0.CE16082B())
								{
									SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), Find {ac28BD29_0.method_105(text2)}...");
									string_4 = "";
									list2 = ac28BD29_0.method_26(10, ref string_4, text2);
									SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), Find {ac28BD29_0.method_105(text2)}: " + list2.Count);
									if (list2.Count != 0)
									{
										continue;
									}
								}
								else
								{
									SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), Can't Scroll...");
								}
								goto end_IL_0068;
							}
							goto IL_03d7;
						}
						break;
						IL_03d7:;
					}
				}
				else
				{
					if (string_2 == "")
					{
						string text4 = ac28BD29_0.AF03B30E();
						string_2 = text4.Split('|')[1];
					}
					List<string> list3 = method_67(string_2, "", ac28BD29_0.Proxy, ac28BD29_0.int_1);
					if (num == 1)
					{
						list3 = Common.D8190238(list3, eBB1FDA);
					}
					if (list.Count > 0)
					{
						list3 = Common.E91CEBAC(list3, list);
					}
					if (list3.Count == 0)
					{
						return num4;
					}
					if (num == 1)
					{
						num5 = list3.Count;
					}
					string text5 = "";
					while (list3.Count > 0)
					{
						text5 = list3.smethod_8();
						list3.Remove(text5);
						SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), Go to Profile {text5}...");
						if (!FA905AA0(ac28BD29_0, F202CA0D, text, "fb://profile/" + text5))
						{
							break;
						}
						SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), Hủy kết bạn...");
						for (int j = 0; j < 4; j++)
						{
							string string_5 = "";
							string text6 = ac28BD29_0.CB3C4B8A(5, ref string_5, new List<string> { "(//android.view.ViewGroup[@content-desc='Friends'])[1]", "//android.view.ViewGroup[@content-desc=\"Unfriend\"]", "//android.widget.Button[@text=\"CONFIRM\"]" });
							if (!(text6 != ""))
							{
								break;
							}
							ac28BD29_0.TapByXPath(text6, string_5);
							if (!(text6 == "//android.widget.Button[@text=\"CONFIRM\"]"))
							{
								continue;
							}
							num4++;
							if (num4 < num5)
							{
								SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num3 + 1));
								continue;
							}
							SetStatusAccount(F202CA0D, text + $"({num4}/{num5}), Done!");
							goto end_IL_0068;
						}
					}
				}
			}
			end_IL_0068:;
		}
		catch
		{
		}
		return num4;
	}

	public int DF0BF838(int FF1FBF1A, string string_0, Chrome gclass9_0, int EF97A321, int int_1, int int_2, int int_3, Random random_1, string string_1 = "")
	{
		string a9364E = method_117(FF1FBF1A, "cUid");
		string string_2 = method_117(FF1FBF1A, "cPassword");
		string string_3 = method_117(FF1FBF1A, "cFa2");
		int num = 0;
		int num2 = random_1.Next(int_2, int_3 + 1);
		int num3 = 0;
		int num4 = 0;
		try
		{
			int num5;
			do
			{
				gclass9_0.D920192A("https://m.facebook.com/friends/center/requests/outgoing/");
				method_68();
				num5 = method_63(gclass9_0, a9364E, string_2, string_3);
			}
			while (num5 == 1);
			if (new List<int> { -3, -2, -1, 2 }.Contains(num5))
			{
				return -1;
			}
			if (gclass9_0.C6B3E9B0("[data-sigil=\"context-layer-root content-pane\"]", 10.0) == 1)
			{
				if (Convert.ToInt32(gclass9_0.F4AF93AB("return document.querySelectorAll('[data-sigil=\"undoable-action\"]').length").ToString()) == 0)
				{
					return num;
				}
				while (num < num2)
				{
					if (!gclass9_0.B2277F30())
					{
						if (gclass9_0.F4AF93AB("return document.querySelectorAll('[data-sigil=\"undoable-action\"]')[" + num4 + "].getAttribute('data-sigil')").ToString() != null)
						{
							method_68();
							gclass9_0.method_27("document.querySelectorAll('[data-sigil=\"touchable check m-cancel-request\"]')[" + num4 + "]");
							method_68();
							gclass9_0.method_14(4, "[data-sigil=\"touchable check m-cancel-request\"]", num4);
							num++;
							num4++;
							SetStatusAccount(FF1FBF1A, string_0 + Language.GetValue("Đang") + $" {string_1} ({num}/{num2})...");
							gclass9_0.C2B42BB6(random_1.Next(int_2, int_3 + 1));
							continue;
						}
						break;
					}
					return -2;
				}
			}
		}
		catch
		{
		}
		return num;
	}

	public int F0214724(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string D6823488)
	{
		int int_2 = f72FAFBC_0.method_0("nudTimeFrom");
		int int_3 = f72FAFBC_0.method_0("nudTimeTo");
		bool bool_ = f72FAFBC_0.AA824D29("ckbInteract");
		bool bool_2 = f72FAFBC_0.AA824D29("ckbShareWall");
		bool bool_3 = f72FAFBC_0.AA824D29("ckbComment");
		List<string> list_ = f72FAFBC_0.EC378D8A("txtComment", f72FAFBC_0.method_0("typeNganCach"));
		int result = 0;
		try
		{
			string dE812B2A = string_0 + Language.GetValue("Đang") + " " + D6823488 + ": ";
			while (true)
			{
				ac28BD29_0.DD071C25();
				ac28BD29_0.method_54(2.0, 3.0);
				switch (method_22(ac28BD29_0, int_1, string_0))
				{
				case 1:
					break;
				default:
					goto end_IL_0065;
				case 0:
					method_72(int_1, dE812B2A, ac28BD29_0, int_2, int_3, bool_, "0124", 0, 9999, bool_3, 0, 9999, list_, bool_2, 0, 9999);
					goto end_IL_0065;
				}
			}
			end_IL_0065:;
		}
		catch
		{
			result = -1;
		}
		return result;
	}

	private void method_59(string string_0)
	{
		lock (A894A284)
		{
			File.AppendAllText("LinkReel.txt", string_0 + "\r\n");
		}
	}

	public int B804088D(int int_1, string string_0, AC28BD29 DCBF5D30, JSON_Settings f72FAFBC_0, string string_1)
	{
		List<string> list = f72FAFBC_0.EC378D8A("txtIdPost");
		int minValue = f72FAFBC_0.method_0("nudTimeFrom");
		int num = f72FAFBC_0.method_0("nudTimeTo");
		bool flag = f72FAFBC_0.AA824D29("ckbInteract");
		bool flag2 = f72FAFBC_0.AA824D29("ckbShareWall");
		bool flag3 = f72FAFBC_0.AA824D29("ckbComment");
		List<string> list2 = f72FAFBC_0.EC378D8A("txtComment", f72FAFBC_0.method_0("typeNganCach"));
		flag3 = list2.Count > 0;
		int result = 0;
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			if (list.Count == 0)
			{
				if (!Base.bool_0)
				{
					return 0;
				}
				goto IL_024d;
			}
			string text2 = list[int_1 % list.Count];
			if (Common.smethod_28(text2))
			{
				text2 = ((!text2.StartsWith("1000")) ? ("fb://group/" + text2) : ("fb://profile/" + text2));
				bool flag4 = false;
				int num2 = 0;
				while (true)
				{
					if (num2 < 3)
					{
						if (!FA905AA0(DCBF5D30, int_1, text, text2))
						{
							break;
						}
						for (int i = 0; i < 20; i++)
						{
							string text3 = DCBF5D30.FindElements(0, "", "//*[@content-desc=\"Author's profile\"]").FirstOrDefault();
							if (!string.IsNullOrEmpty(text3))
							{
								Point point = new Class65(text3).method_0();
								if (point.Y + 200 < DCBF5D30.method_13())
								{
									DCBF5D30.method_37(point.X, point.Y + 200);
									DCBF5D30.TimeDelay(3.0);
								}
							}
							if (!DCBF5D30.method_15().Contains("com.facebook.fbshorts.viewer.activity.FbShortsViewerActivity"))
							{
								if (DCBF5D30.CE16082B())
								{
									break;
								}
								DCBF5D30.TimeDelay(2.0);
								continue;
							}
							flag4 = true;
							break;
						}
						if (!flag4 && DCBF5D30.DoesElementExist(0, "", "//*[@content-desc='SHARE']"))
						{
							num2++;
							continue;
						}
					}
					if (!flag4)
					{
						break;
					}
					goto IL_024d;
				}
			}
			else if (FA905AA0(DCBF5D30, int_1, text, text2))
			{
				goto IL_024d;
			}
			goto end_IL_0080;
			IL_024d:
			SetStatusAccount(int_1, text + Language.GetValue("Xem, " + Language.GetValue("đợi") + " {time}s..."), Base.rd.Next(minValue, num + 1));
			SetStatusAccount(int_1, text + Language.GetValue("Tương tác..."));
			int int_2 = 0;
			int int_3 = 0;
			int FEB51E = 0;
			List<string> C6832E1A = new List<string>();
			for (int j = 0; j < 5; j++)
			{
				C13AAEBB(int_1, text, DCBF5D30, flag, "0", ref int_2, flag3, ref int_3, list2, ref C6832E1A, flag2, ref FEB51E, 1);
				if (int_2 <= 0 && int_3 <= 0 && (flag || flag3 || flag2))
				{
					SetStatusAccount(int_1, text + "Scroll...");
					if (DCBF5D30.CE16082B() && !DCBF5D30.method_68())
					{
						break;
					}
					continue;
				}
				break;
			}
			end_IL_0080:;
		}
		catch
		{
			result = -1;
		}
		return result;
	}

	public int method_60(int int_1, string string_0, AC28BD29 F4AA3D37, JSON_Settings CC92CA8E, string DE0BD11D)
	{
		int int_2 = CC92CA8E.method_0("nudTimeFrom");
		int int_3 = CC92CA8E.method_0("nudTimeTo");
		bool bool_ = CC92CA8E.AA824D29("ckbInteract");
		int int_4 = CC92CA8E.method_0("nudCountLikeFrom");
		int int_5 = CC92CA8E.method_0("nudCountLikeTo");
		bool bool_2 = CC92CA8E.AA824D29("ckbShareWall");
		int int_6 = CC92CA8E.method_0("nudCountShareFrom");
		int int_7 = CC92CA8E.method_0("nudCountShareTo");
		bool bool_3 = CC92CA8E.AA824D29("ckbComment");
		List<string> list_ = CC92CA8E.EC378D8A("txtComment");
		int int_8 = CC92CA8E.method_0("nudCountCommentFrom");
		int int_9 = CC92CA8E.method_0("nudCountCommentTo");
		CC92CA8E.method_0("nudPercentLike", 50);
		CC92CA8E.method_0("nudPercentShare", 50);
		CC92CA8E.method_0("nudPercentComment", 50);
		int result = 0;
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + DE0BD11D + ": ";
			SetStatusAccount(int_1, text + "Go to Watch...");
			if (FA905AA0(F4AA3D37, int_1, text, "fb://watch"))
			{
				method_72(int_1, text, F4AA3D37, int_2, int_3, bool_, "0124", int_4, int_5, bool_3, int_8, int_9, list_, bool_2, int_6, int_7);
			}
		}
		catch
		{
			result = -1;
		}
		return result;
	}

	public int FA1402BE(int int_1, string string_0, AC28BD29 C9368030, JSON_Settings f72FAFBC_0, string string_1)
	{
		List<string> source = f72FAFBC_0.EC378D8A("txtTuKhoa");
		int int_2 = f72FAFBC_0.method_0("nudTimeFrom");
		int int_3 = f72FAFBC_0.method_0("nudTimeTo");
		bool e42EBF = f72FAFBC_0.AA824D29("ckbInteract");
		int int_4 = f72FAFBC_0.method_0("nudCountLikeFrom");
		int int_5 = f72FAFBC_0.method_0("nudCountLikeTo");
		bool dD0E2B = f72FAFBC_0.AA824D29("ckbShareWall");
		int int_6 = f72FAFBC_0.method_0("nudCountShareFrom");
		int b = f72FAFBC_0.method_0("nudCountShareTo");
		bool bool_ = f72FAFBC_0.AA824D29("ckbComment");
		List<string> b0863A = f72FAFBC_0.EC378D8A("txtComment");
		int int_7 = f72FAFBC_0.method_0("nudCountCommentFrom");
		int int_8 = f72FAFBC_0.method_0("nudCountCommentTo");
		int result = 0;
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			SetStatusAccount(int_1, text + "Go to Watch...");
			if (FA905AA0(C9368030, int_1, text, "fb://watch"))
			{
				SetStatusAccount(int_1, text + "Find Search Video...");
				if (C9368030.method_40(5, "//android.widget.Button[@content-desc=\"Search Videos\"]", ""))
				{
					string text2 = source.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
					if (!string.IsNullOrEmpty(text2))
					{
						SetStatusAccount(int_1, text + "Find " + Language.GetValue("Nhập dữ liệu..."));
						if (C9368030.method_40(5, "//android.widget.EditText", ""))
						{
							SetStatusAccount(int_1, text + Language.GetValue("Nhập dữ liệu..."));
							C9368030.SendByXPath("//android.widget.EditText", text2);
							C9368030.TimeDelay(1.0);
							SetStatusAccount(int_1, text + "Search...");
							C9368030.B2016D94(AC28BD29.DB353F82.E22EE10E);
							C9368030.method_54(2.0, 3.0);
							E40A2E10(int_1, text, C9368030, int_2, int_3, e42EBF, int_4, int_5, bool_, int_7, int_8, b0863A, dD0E2B, int_6, b);
						}
					}
				}
			}
		}
		catch
		{
		}
		return result;
	}

	private bool method_61(AC28BD29 D5A967A1)
	{
		bool result = false;
		for (int i = 0; i < 5; i++)
		{
			string text = D5A967A1.method_81("dataimage\\282Notify");
			if (text == "")
			{
				break;
			}
			List<string> list = D5A967A1.FindElements(10, "", "//androidx.recyclerview.widget.RecyclerView[@resource-id='android:id/list']/child::*");
			string text2 = "";
			for (int j = 0; j < list.Count; j++)
			{
				if (new Class65(list[j]).method_1(text))
				{
					text2 = list[j];
					break;
				}
			}
			if (text2 == "")
			{
				break;
			}
			string string_ = "";
			List<string> list2 = D5A967A1.FindElements(10, "", "//*[@content-desc=\"Manage the notification's settings\"]");
			for (int k = 0; k < list2.Count; k++)
			{
				if (new Class65(text2).method_1(list2[k]))
				{
					string_ = list2[k];
					break;
				}
			}
			D5A967A1.E832B991(string_);
			D5A967A1.method_40(10, "//*[@content-desc='Remove this notification']", "");
			result = true;
			D5A967A1.TimeDelay(3.0);
		}
		return result;
	}

	private int method_62(int F2258791, string string_0, AC28BD29 ac28BD29_0, JSON_Settings DF9FA792, string string_1)
	{
		int f988D70A = DF9FA792.method_0("nudSoLuongFrom");
		int e234B = DF9FA792.method_0("nudSoLuongTo");
		int int_ = DF9FA792.method_0("nudDelayFrom");
		int int_2 = DF9FA792.method_0("nudDelayTo");
		bool flag = DF9FA792.AA824D29("ckbReadRandom", A72188BC: true);
		int num = 0;
		int num2 = ac28BD29_0.C4B7B817(f988D70A, e234B);
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			while (true)
			{
				IL_0305:
				SetStatusAccount(F2258791, text + "Go to Notify...");
				if (!ac28BD29_0.method_75())
				{
					break;
				}
				List<string> list = new List<string>();
				for (; num < num2; SetStatusAccount(F2258791, text + $"({num}/{num2}), Back..."), ac28BD29_0.method_19())
				{
					string text2;
					switch (method_22(ac28BD29_0, F2258791, string_0))
					{
					case 0:
						SetStatusAccount(F2258791, text + $"({num}/{num2}), Check danh sách Notify...");
						if (list.Count != 0)
						{
							goto IL_015a;
						}
						if (num <= 0)
						{
							goto IL_0118;
						}
						if (!ac28BD29_0.CE16082B(1, 2))
						{
							ac28BD29_0.method_54(2.0, 3.0);
							goto IL_0118;
						}
						goto end_IL_0054;
					case 1:
						break;
					default:
						goto end_IL_0054;
						IL_015a:
						text2 = "";
						text2 = ((!flag) ? list.FirstOrDefault() : list.smethod_8());
						list.Remove(text2);
						SetStatusAccount(F2258791, text + $"({num}/{num2}), Tap Notify...");
						ac28BD29_0.method_36(new Class65(text2).method_0());
						SetStatusAccount(F2258791, text + $"({num}/{num2}), Tap Notify, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(2, 4));
						num++;
						SetStatusAccount(F2258791, text + $"({num}/{num2}), Scroll...");
						ac28BD29_0.FB008A0E(int_, int_2);
						SetStatusAccount(F2258791, text + $"({num}/{num2}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(1, 3));
						if (ac28BD29_0.method_41("//*[@text='This Was Me']") && ac28BD29_0.method_42(10, "//*[@text='Continue']", ""))
						{
							ac28BD29_0.DoesElementExist(10, "", "//*[@text='Done']");
						}
						else
							_ = 0;
						continue;
						IL_0118:
						if (DF9FA792.AA824D29("ckbXoaThongBaoSpam"))
						{
							method_61(ac28BD29_0);
						}
						list = ac28BD29_0.FindElements(10, "", "//androidx.recyclerview.widget.RecyclerView[@resource-id='android:id/list']/child::*");
						if (list.Count != 0)
						{
							list.RemoveAt(0);
							goto IL_015a;
						}
						goto end_IL_0054;
					}
					goto IL_0305;
				}
				break;
			}
			end_IL_0054:;
		}
		catch
		{
		}
		return num;
	}

	private int method_63(Chrome gclass9_0, string A9364E18, string string_0, string string_1, bool FD2D351D = false)
	{
		int result = 0;
		GClass12.D52B6005(gclass9_0, FD2D351D);
		switch (gclass9_0.GEnum4_0)
		{
		case GEnum4.const_1:
			result = -2;
			break;
		case GEnum4.const_2:
		case GEnum4.const_3:
		{
			string text = GClass12.F23FFB1F(gclass9_0, A9364E18, string_0, string_1, "https://m.facebook.com/", 2);
			result = ((text == "1") ? 1 : 2);
			break;
		}
		case GEnum4.const_4:
			result = -1;
			break;
		case GEnum4.E0230DBD:
			result = -3;
			break;
		}
		return result;
	}

	public int method_64(int int_1, string string_0, AC28BD29 A19AFB33, JSON_Settings f72FAFBC_0, string B00954AD)
	{
		int f988D70A = f72FAFBC_0.method_0("nudSoLuongFrom");
		int e234B = f72FAFBC_0.method_0("nudSoLuongTo");
		bool flag = f72FAFBC_0.AA824D29("ckbInteract");
		string text = f72FAFBC_0.GetValue("typeReaction");
		bool flag2 = f72FAFBC_0.AA824D29("ckbComment");
		List<string> list = f72FAFBC_0.EC378D8A("txtComment");
		string text2 = "";
		int num = A19AFB33.C4B7B817(f988D70A, e234B);
		try
		{
			string text3 = string_0 + Language.GetValue("Đang") + " " + B00954AD + ": ";
			while (true)
			{
				IL_0546:
				SetStatusAccount(int_1, text3 + "Go to Home...");
				A19AFB33.D7950A0F();
				A19AFB33.method_54(2.0, 3.0);
				switch (method_22(A19AFB33, int_1, string_0))
				{
				case 0:
				{
					string text4 = "";
					SetStatusAccount(int_1, text3 + "Find Story...");
					int tickCount = Environment.TickCount;
					int num2 = 10;
					do
					{
						text4 = A19AFB33.GetPageSource();
						string text5 = A19AFB33.FindElement(0, text4, new List<string> { "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]", "//*[contains(@content-desc,\"'s story\")]" });
						string text6 = text5;
						string text7 = text6;
						if (!(text7 == "//*[contains(@content-desc,\"'s story\")]"))
						{
							if (text7 == "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]")
							{
								A19AFB33.TapByXPath(text5, text4);
							}
							continue;
						}
						A19AFB33.TapByXPath(text5, text4);
						int tickCount2 = Environment.TickCount;
						while (Environment.TickCount - tickCount2 < num * 1000)
						{
							switch (method_22(A19AFB33, int_1, string_0))
							{
							case 0:
							{
								SetStatusAccount(int_1, text3 + "Xem Story, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(4, 8));
								text4 = A19AFB33.GetPageSource();
								string text8 = A19AFB33.FindElements(0, text4, "//android.view.ViewGroup[@content-desc=\" See Video \"]").FirstOrDefault();
								if (!string.IsNullOrEmpty(text8))
								{
									SetStatusAccount(int_1, text3 + "Tap See Video...");
									A19AFB33.E832B991(text8);
								}
								if (flag2)
								{
									SetStatusAccount(int_1, text3 + "Find Reply to...");
									string text9 = A19AFB33.method_28(0, text4, new List<string> { "//*[contains(@content-desc,\"Reply to\")]", "//*[contains(@content-desc,'comment on the story')]" }).LastOrDefault();
									if (!string.IsNullOrEmpty(text9))
									{
										text2 = list.smethod_8();
										text2 = Common.SpinText(text2);
										SetStatusAccount(int_1, text3 + "Tap Reply to...");
										A19AFB33.E832B991(text9);
										A19AFB33.TimeDelay(1.0);
										if (A19AFB33.DoesElementExist(3, "", "//android.widget.EditText"))
										{
											SetStatusAccount(int_1, text3 + Language.GetValue("Nhập dữ liệu..."));
											A19AFB33.SendByXPath("//android.widget.EditText", text2);
											SetStatusAccount(int_1, text3 + "Tap Send...");
											A19AFB33.method_40(1, "//*[@content-desc=\"SEND\"]", "");
											A19AFB33.method_54(1.0, 1.5);
											if (A19AFB33.DoesElementExist(0, "", "//android.widget.EditText"))
											{
												A19AFB33.method_19(2);
											}
										}
										else
										{
											A19AFB33.method_19();
										}
									}
								}
								SetStatusAccount(int_1, text3 + "Find Like...");
								string text10 = A19AFB33.FindElements(0, "", "//*[contains(@content-desc, \"Like\")]").FirstOrDefault();
								if (!string.IsNullOrEmpty(text10))
								{
									Point point = A19AFB33.method_51(text10);
									Point point2 = A19AFB33.method_51("[35," + text10.Split(new string[3] { "[", ",", "]" }, StringSplitOptions.RemoveEmptyEntries)[1] + "][65," + text10.Split(new string[3] { "[", ",", "]" }, StringSplitOptions.RemoveEmptyEntries)[3] + "]");
									if (flag)
									{
										SetStatusAccount(int_1, text3 + "Tap Rection...");
										A19AFB33.method_50(point.X, point.Y, point2.X, point2.Y);
										A19AFB33.method_54(1.0, 1.5);
										A19AFB33.C628163C((Convert.ToInt32(text[A19AFB33.C4B7B817(0, text.Length - 1)].ToString()) + 1).ToString());
										A19AFB33.method_54(1.0, 1.5);
										A19AFB33.method_50(point2.X, point2.Y, point.X, point.Y);
										A19AFB33.method_54(1.0, 1.5);
									}
									A19AFB33.method_50(point.X, point.Y / 2, point2.X, point2.Y / 2);
								}
								continue;
							}
							case 1:
								break;
							default:
								goto end_IL_006b;
							}
							goto IL_0546;
						}
						break;
					}
					while (Environment.TickCount - tickCount < num2 * 1000);
					goto end_IL_006b;
				}
				case 1:
					break;
				default:
					goto end_IL_006b;
				}
			}
			end_IL_006b:;
		}
		catch
		{
		}
		return num;
	}

	public int E493A119(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string AD13D808, string string_1)
	{
		string string_2 = f72FAFBC_0.GetValue("txtLinkVideo");
		int int_2 = f72FAFBC_0.method_0("nudSoLuongFrom");
		int int_3 = f72FAFBC_0.method_0("nudSoLuongTo");
		bool bool_ = f72FAFBC_0.AA824D29("ckbInteract");
		string string_3 = f72FAFBC_0.GetValue("typeReaction");
		bool bool_2 = f72FAFBC_0.AA824D29("ckbComment");
		List<string> list_ = f72FAFBC_0.EC378D8A("txtComment");
		bool bool_3 = f72FAFBC_0.AA824D29("ckbBinhLuanNhieuLan");
		int e527819C = f72FAFBC_0.method_0("nudBinhLuanNhieuLanDelayFrom");
		int int_4 = f72FAFBC_0.method_0("nudBinhLuanNhieuLanDelayTo");
		bool d09FD = f72FAFBC_0.AA824D29("ckbTuDongXoaNoiDung");
		string text = string_0 + Language.GetValue("Đang") + " " + AD13D808 + ": ";
		ECAC5AB6(int_1, text, ac28BD29_0, string_2, int_2, int_3, bool_, string_3, bool_2, list_, d09FD, bool_3, e527819C, int_4, string_1);
		SetStatusAccount(int_1, text + Language.GetValue("Xem video xong!"));
		return 0;
	}

	public int ECAC5AB6(int int_1, string string_0, AC28BD29 ac28BD29_0, string string_1, int int_2, int int_3, bool bool_4, string string_2, bool bool_5, List<string> list_13, bool D09FD898, bool bool_6, int E527819C, int int_4, string C99F4E99)
	{
		try
		{
			int int_5 = 0;
			int int_6 = 0;
			int BA3525AB = 0;
			int num = 0;
			int num2 = 0;
			num = 1;
			list_13 = Common.RemoveEmptyItems(list_13);
			List<string> list = Common.smethod_11(list_13);
			List<string> list_14 = new List<string>();
			if (C99F4E99 == "")
			{
				list_14 = Common.smethod_11(list_13);
			}
			num2 = 1;
			if (bool_6)
			{
				num2 = 99999;
			}
			int num3 = ac28BD29_0.C4B7B817(int_2, int_3);
			int num4 = DEA54A85(ac28BD29_0, int_1, string_0, string_1);
			if (num4 == 1)
			{
				int tickCount = Environment.TickCount;
				SetStatusAccount(int_1, string_0 + Language.GetValue("Đang xem video") + "...");
				do
				{
					if (C99F4E99 != "" && C50FA08A[C99F4E99].Count > 0)
					{
						string item = "";
						if (!D09FD898)
						{
							item = C50FA08A[C99F4E99].OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
						}
						else
						{
							lock (C50FA08A)
							{
								int index = random_0.Next(0, C50FA08A[C99F4E99].Count);
								item = C50FA08A[C99F4E99][index];
								C50FA08A[C99F4E99].RemoveAt(index);
							}
						}
						list.Clear();
						list.Add(item);
					}
					method_73(int_1, string_0, ac28BD29_0, bool_4 && int_5 < num, string_2, ref int_5, bool_5 && int_6 < num2, ref int_6, list, ref list_14, D1314C80: false, ref BA3525AB);
					if (bool_5 && int_6 < num2)
					{
						SetStatusAccount(int_1, string_0 + Language.GetValue("Đang xem video") + ", " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(E527819C, int_4 + 1));
						continue;
					}
					int num5 = (Environment.TickCount - tickCount) / 1000;
					SetStatusAccount(int_1, string_0 + Language.GetValue("Đang xem video") + " {time}s...", num3 - num5);
					break;
				}
				while (Environment.TickCount - tickCount < num3 * 1000);
			}
		}
		catch
		{
		}
		return 0;
	}

	public int EF9C309C(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string B331898D)
	{
		int minValue = f72FAFBC_0.method_0("nudSoLuongFrom");
		int num = f72FAFBC_0.method_0("nudSoLuongTo");
		int minValue2 = f72FAFBC_0.method_0("nudDelayFrom");
		int num2 = f72FAFBC_0.method_0("nudDelayTo");
		int num3 = 0;
		try
		{
			int num4 = random_0.Next(minValue, num + 1);
			if (num4 != 0)
			{
				string text = string_0 + Language.GetValue("Đang") + " " + B331898D + ": ";
				while (true)
				{
					IL_041f:
					SetStatusAccount(int_1, text + "Go to Friend Accept...");
					if (!FA905AA0(ac28BD29_0, int_1, text, "fb://requests"))
					{
						break;
					}
					string text2 = "";
					int num5 = 0;
					int num6 = 3;
					int tickCount = Environment.TickCount;
					do
					{
						text2 = ac28BD29_0.GetPageSource();
						string text3 = ac28BD29_0.FindElement(0, text2, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='Requests']", "//*[@content-desc='See All']", "//*[starts-with(@content-desc, 'Confirm')]", "//*[@text='No Suggestions Available']", "//*[@content-desc='ok' or @text='ok']", "//*[@content-desc='Cancel' or @text='Cancel']", "//*[@content-desc='See friend suggestions']", "//*[contains(@content-desc,'Profile picture')]" });
						string text4 = text3;
						string text5 = text4;
						uint num7 = HashString.DA8CEBAB(text5);
						if (num7 > 678173661)
						{
							if (num7 <= 2674201672u)
							{
								if (num7 != 989703687)
								{
									if (num7 != 2674201672u || !(text5 == "//*[@content-desc='Cancel' or @text='Cancel']"))
									{
										goto IL_020d;
									}
								}
								else if (!(text5 == "//*[@content-desc='See All']"))
								{
									goto IL_020d;
								}
								goto IL_024f;
							}
							if (num7 != 2855582911u)
							{
								if (num7 != 3099647473u)
								{
									if (num7 == 3752914912u && text5 == "//*[@content-desc='ok' or @text='ok']")
									{
										goto IL_024f;
									}
								}
								else if (text5 == "//*[starts-with(@content-desc, 'Confirm')]")
								{
									List<string> list = ac28BD29_0.FindElements(0, text2, text3);
									string dB31F = list.smethod_8();
									Point point_ = new Class65(dB31F).method_0();
									SetStatusAccount(int_1, text + $"({num3}/{num4}), Tap Confirm...");
									if (ac28BD29_0.method_36(point_))
									{
										num3++;
										if (num3 >= num4)
										{
											SetStatusAccount(int_1, text + $"({num3}/{num4}): Done!");
											break;
										}
										SetStatusAccount(int_1, text + $"({num3}/{num4}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
										tickCount = Environment.TickCount;
									}
									goto IL_027f;
								}
							}
							else if (text5 == "//*[@content-desc='Requests']")
							{
								goto IL_024f;
							}
						}
						else
						{
							if (num7 <= 281629319)
							{
								if (num7 != 100753459)
								{
									if (num7 != 281629319 || !(text5 == "//*[@text='Tap to retry']"))
									{
										goto IL_020d;
									}
									if (num5 >= num6)
									{
										break;
									}
									num5++;
									ac28BD29_0.CE16082B(-1);
								}
								else
								{
									if (!(text5 == "//*[contains(@content-desc,'Profile picture')]"))
									{
										goto IL_020d;
									}
									ac28BD29_0.method_19();
								}
								goto IL_027f;
							}
							if (num7 != 532719482)
							{
								if (num7 == 678173661 && text5 == "//*[@content-desc='See friend suggestions']")
								{
									break;
								}
							}
							else if (text5 == "//android.widget.ProgressBar")
							{
								SetStatusAccount(int_1, text + "Loading...");
								goto IL_027f;
							}
						}
						goto IL_020d;
						IL_024f:
						SetStatusAccount(int_1, text + "Tap " + ac28BD29_0.method_105(text3) + "...");
						ac28BD29_0.TapByXPath(text3, text2);
						goto IL_027f;
						IL_020d:
						SetStatusAccount(int_1, text + "Scroll...");
						if (ac28BD29_0.CE16082B(-1))
						{
							int num8 = method_22(ac28BD29_0, int_1, text);
							if (num8 == 1)
							{
								goto IL_041f;
							}
							if (num8 != 0)
							{
								break;
							}
						}
						goto IL_027f;
						IL_027f:
						ac28BD29_0.TimeDelay(2.0);
					}
					while (Environment.TickCount - tickCount < 60000);
					break;
				}
			}
		}
		catch
		{
			num3 = -1;
		}
		return num3;
	}

	public int D62AA80C(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_1)
	{
		List<string> f1808BA = f72FAFBC_0.EC378D8A("txtTuKhoa");
		int minValue = f72FAFBC_0.method_0("nudSoLuongFrom");
		int num = f72FAFBC_0.method_0("nudSoLuongTo");
		int minValue2 = f72FAFBC_0.method_0("nudDelayFrom");
		int num2 = f72FAFBC_0.method_0("nudDelayTo");
		int minValue3 = f72FAFBC_0.method_0("nudSoLuongKetBanMoiTuKhoaFrom", 1);
		int num3 = f72FAFBC_0.method_0("nudSoLuongKetBanMoiTuKhoaTo", 2);
		int num4 = 0;
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			int num5 = random_0.Next(minValue, num + 1);
			if (num5 != 0)
			{
				f1808BA = Common.RemoveEmptyItems(f1808BA);
				while (f1808BA.Count > 0)
				{
					string text2 = f1808BA.smethod_8();
					f1808BA.Remove(text2);
					text2 = Common.SpinText(text2);
					int num6 = 0;
					int num7 = Base.rd.Next(minValue3, num3 + 1);
					while (true)
					{
						IL_03a8:
						SetStatusAccount(int_1, text + "Search People...");
						if (!ac28BD29_0.method_71(text2, "People"))
						{
							break;
						}
						switch (method_22(ac28BD29_0, int_1, string_0))
						{
						case 0:
						{
							SetStatusAccount(int_1, text + "Find Add Friend...");
							List<string> list = ac28BD29_0.method_28(5, "", new List<string> { "//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup/child::*[2]", "//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/child::*[3]", "//android.view.ViewGroup[@content-desc=\"Add Friend\"]" });
							list = ac28BD29_0.method_118(list);
							SetStatusAccount(int_1, text + "Search People: " + list.Count);
							for (int i = 0; i < num7 + 10; i++)
							{
								switch (method_22(ac28BD29_0, int_1, string_0))
								{
								case 0:
									break;
								case 1:
									goto IL_03a8;
								default:
									goto end_IL_0068;
								}
								if (list.Count == 0)
								{
									for (int j = 0; j < 5; j++)
									{
										SetStatusAccount(int_1, text + $"({num4}/{num5}), Scroll...");
										if (ac28BD29_0.CE16082B(1, 2))
										{
											break;
										}
										SetStatusAccount(int_1, text + $"({num4}/{num5}), Find Add Friend...");
										list = ac28BD29_0.method_28(5, "", new List<string> { "//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup/child::*[2]", "//androidx.recyclerview.widget.RecyclerView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/child::*[3]", "//android.view.ViewGroup[@content-desc=\"Add Friend\"]" });
										list = ac28BD29_0.method_118(list);
										SetStatusAccount(int_1, text + $"({num4}/{num5}), Find Add Friend: " + list.Count);
										if (list.Count > 0)
										{
											break;
										}
									}
									if (list.Count == 0)
									{
										break;
									}
								}
								string text3 = list.smethod_8();
								list.Remove(text3);
								if (!(text3 != ""))
								{
									continue;
								}
								SetStatusAccount(int_1, text + $"({num4}/{num5}), Tap Friend...");
								if (!ac28BD29_0.E832B991(text3))
								{
									continue;
								}
								num4++;
								if (num4 < num5)
								{
									num6++;
									if (num6 >= num7)
									{
										break;
									}
									SetStatusAccount(int_1, text + $"({num4}/{num5}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
									continue;
								}
								goto end_IL_0068;
							}
							break;
						}
						case 1:
							continue;
						default:
							goto end_IL_0068;
						}
						goto IL_03d4;
					}
					break;
					IL_03d4:;
				}
			}
			end_IL_0068:;
		}
		catch
		{
			num4 = -1;
		}
		return num4;
	}

	public int method_65(ref int B39AE723, int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_1)
	{
		int minValue = f72FAFBC_0.method_0("nudSoLuongFrom");
		int num = f72FAFBC_0.method_0("nudSoLuongTo");
		int minValue2 = f72FAFBC_0.method_0("nudDelayFrom");
		int num2 = f72FAFBC_0.method_0("nudDelayTo");
		int num3 = 0;
		try
		{
			int num4 = random_0.Next(minValue, num + 1);
			if (num4 != 0)
			{
				string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
				while (true)
				{
					IL_048e:
					SetStatusAccount(int_1, text + "Goto Friend Suggest...");
					if (!FA905AA0(ac28BD29_0, int_1, text, "fb://requests"))
					{
						break;
					}
					string text2 = "";
					int num5 = 0;
					int num6 = 3;
					int tickCount = Environment.TickCount;
					do
					{
						text2 = ac28BD29_0.GetPageSource();
						string text3 = ac28BD29_0.FindElement(0, text2, new List<string>
						{
							"//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='Suggestions']", "//*[contains(@content-desc,'as a friend') or contains(@text,'as a friend')]", "//*[@text='No Suggestions Available']", "//*[@content-desc='Search for a friend']", "//*[@content-desc='Upload contacts']", "//*[@content-desc='ok' or @text='ok']", "//*[@content-desc='CONFIRM' or @text='CONFIRM']", "//*[@content-desc='Cancel' or @text='Cancel']",
							"//*[@content-desc='Requests']", "//*[contains(@content-desc,'Profile picture')]"
						});
						string text4 = text3;
						string text5 = text4;
						uint num7 = HashString.DA8CEBAB(text5);
						if (num7 > 815925795)
						{
							if (num7 <= 2855582911u)
							{
								if (num7 != 827047850)
								{
									if (num7 != 2674201672u)
									{
										if (num7 == 2855582911u && text5 == "//*[@content-desc='Requests']")
										{
											goto IL_04e9;
										}
									}
									else if (text5 == "//*[@content-desc='Cancel' or @text='Cancel']")
									{
										goto IL_019d;
									}
								}
								else if (text5 == "//*[@content-desc='Suggestions']")
								{
									goto IL_019d;
								}
							}
							else if (num7 != 3752914912u)
							{
								if (num7 != 4091450689u)
								{
									if (num7 == 4251023282u && text5 == "//*[@content-desc='CONFIRM' or @text='CONFIRM']")
									{
										goto IL_019d;
									}
								}
								else if (text5 == "//*[@content-desc='Upload contacts']")
								{
									goto IL_04e9;
								}
							}
							else if (text5 == "//*[@content-desc='ok' or @text='ok']")
							{
								goto IL_019d;
							}
						}
						else
						{
							if (num7 <= 532719482)
							{
								if (num7 != 100753459)
								{
									if (num7 != 281629319)
									{
										if (num7 != 532719482 || !(text5 == "//android.widget.ProgressBar"))
										{
											goto IL_0159;
										}
										SetStatusAccount(int_1, text + "Loading...");
									}
									else
									{
										if (!(text5 == "//*[@text='Tap to retry']"))
										{
											goto IL_0159;
										}
										if (num5 >= num6)
										{
											break;
										}
										num5++;
										ac28BD29_0.CE16082B(-1);
									}
								}
								else
								{
									if (!(text5 == "//*[contains(@content-desc,'Profile picture')]"))
									{
										goto IL_0159;
									}
									ac28BD29_0.method_19();
								}
								goto IL_01cf;
							}
							if (num7 != 555639826)
							{
								if (num7 != 672400718)
								{
									if (num7 == 815925795 && text5 == "//*[@content-desc='Search for a friend']")
									{
										goto IL_04e9;
									}
								}
								else if (text5 == "//*[contains(@content-desc,'as a friend') or contains(@text,'as a friend')]")
								{
									B39AE723 = 1;
									List<string> list = ac28BD29_0.FindElements(0, text2, text3);
									string dB31F = list.smethod_8();
									Point point_ = new Class65(dB31F).method_0();
									SetStatusAccount(int_1, text + $"({num3}/{num4}), Tap Add Friend...");
									if (ac28BD29_0.method_36(point_))
									{
										num3++;
										if (num3 >= num4)
										{
											SetStatusAccount(int_1, text + $"({num3}/{num4}): Done!");
											break;
										}
										SetStatusAccount(int_1, text + $"({num3}/{num4}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue2, num2 + 1));
										tickCount = Environment.TickCount;
									}
									goto IL_01cf;
								}
							}
							else if (text5 == "//*[@text='No Suggestions Available']")
							{
								goto IL_04e9;
							}
						}
						goto IL_0159;
						IL_04e9:
						B39AE723 = 2;
						break;
						IL_019d:
						SetStatusAccount(int_1, text + "Tap " + ac28BD29_0.method_105(text3) + "...");
						ac28BD29_0.TapByXPath(text3, text2);
						goto IL_01cf;
						IL_0159:
						SetStatusAccount(int_1, text + "Scroll...");
						if (ac28BD29_0.CE16082B(-1))
						{
							int num8 = method_22(ac28BD29_0, int_1, text);
							if (num8 == 1)
							{
								goto IL_048e;
							}
							if (num8 != 0)
							{
								break;
							}
						}
						goto IL_01cf;
						IL_01cf:
						ac28BD29_0.TimeDelay(2.0);
					}
					while (Environment.TickCount - tickCount < 60000);
					break;
				}
			}
		}
		catch
		{
			num3 = -1;
		}
		return num3;
	}

	public List<string> method_66(string string_0, string B818F03F, string CC8F4AAF, string string_1, int A7AEC390)
	{
		List<string> list = new List<string>();
		try
		{
			RequestXNet b01F5C = new RequestXNet(CC8F4AAF, string_0, string_1, A7AEC390);
			string json = b01F5C.RequestGet("https://graph.facebook.com/v3.0/me/groups?access_token=" + B818F03F + "&limit=5000&fields=id,name").ToString();
			JObject jObject = JObject.Parse(json);
			foreach (JToken item in (IEnumerable<JToken>)(jObject["data"]!))
			{
				list.Add(item["id"]!.ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public List<string> method_67(string string_0, string string_1, string string_2, int E5B718BC)
	{
		List<string> list = new List<string>();
		try
		{
			RequestXNet b01F5C = new RequestXNet(string_0, string_1, string_2, E5B718BC);
			string value = Regex.Match(string_0, "c_user=(\\d+)").Groups[1].Value;
			string input = b01F5C.RequestGet("https://m.facebook.com/help");
			string value2 = Regex.Match(input, "fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			string json = b01F5C.method_1("https://www.facebook.com/api/graphql", "q=me(){friends}&fb_dtsg=" + value2);
			JObject jObject = JObject.Parse(json);
			int num = jObject[value]!["friends"]!["nodes"].Count();
			for (int i = 0; i < num; i++)
			{
				list.Add(jObject[value]!["friends"]!["nodes"]![i]!["id"]!.ToString());
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public List<string> EE98FB8B(List<string> A9BDBF2B)
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < A9BDBF2B.Count; i++)
			{
				list.Add(A9BDBF2B[i]);
			}
		}
		catch
		{
		}
		return list;
	}

	private void method_68(int int_1 = 0)
	{
		Common.DelayTime(random_0.Next(int_1 + 1, int_1 + 4));
	}

	public void AE0E9628(string string_0)
	{
		plTrangThai.Invoke((MethodInvoker)delegate
		{
			if (!plTrangThai.Visible)
			{
				plTrangThai.Visible = true;
			}
		});
		lblTrangThai.Invoke((MethodInvoker)delegate
		{
			lblTrangThai.Text = string_0;
		});
		Application.DoEvents();
	}

	public void method_69()
	{
		try
		{
			plTrangThai.Invoke((MethodInvoker)delegate
			{
				if (plTrangThai.Visible)
				{
					plTrangThai.Visible = false;
				}
			});
		}
		catch
		{
		}
	}

	public int method_70(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings FE335CA7, string A7AA3834)
	{
		int int_2 = FE335CA7.method_0("nudTimeFrom");
		int int_3 = FE335CA7.method_0("nudTimeTo");
		bool bool_ = FE335CA7.AA824D29("ckbInteract");
		int int_4 = FE335CA7.method_0("nudCountLikeFrom", 1);
		int int_5 = FE335CA7.method_0("nudCountLikeTo", 3);
		bool bool_2 = FE335CA7.AA824D29("ckbComment");
		int int_6 = FE335CA7.method_0("nudCountCommentFrom", 1);
		int int_7 = FE335CA7.method_0("nudCountCommentTo", 3);
		List<string> list_ = FE335CA7.EC378D8A("txtComment", FE335CA7.method_0("typeNganCach"));
		bool bool_3 = FE335CA7.AA824D29("ckbShareWall");
		int int_8 = FE335CA7.method_0("nudCountShareFrom", 1);
		int int_9 = FE335CA7.method_0("nudCountShareTo", 3);
		int result = 0;
		try
		{
			ac28BD29_0.D7950A0F();
			ac28BD29_0.method_54(1.0, 2.0);
			string dE812B2A = string_0 + Language.GetValue("Đang") + " " + A7AA3834 + ": ";
			method_72(int_1, dE812B2A, ac28BD29_0, int_2, int_3, bool_, "0124", int_4, int_5, bool_2, int_6, int_7, list_, bool_3, int_8, int_9);
		}
		catch (Exception)
		{
			result = -1;
		}
		return result;
	}

	public int method_71(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_1)
	{
		int int_2 = f72FAFBC_0.method_0("nudTimeFrom");
		int int_3 = f72FAFBC_0.method_0("nudTimeTo");
		bool bool_ = f72FAFBC_0.AA824D29("ckbInteract");
		int int_4 = f72FAFBC_0.method_0("nudCountLikeFrom", 1);
		int int_5 = f72FAFBC_0.method_0("nudCountLikeTo", 3);
		bool bool_2 = f72FAFBC_0.AA824D29("ckbComment");
		int int_6 = f72FAFBC_0.method_0("nudCountCommentFrom", 1);
		int int_7 = f72FAFBC_0.method_0("nudCountCommentTo", 3);
		List<string> list_ = f72FAFBC_0.EC378D8A("txtComment", f72FAFBC_0.method_0("typeNganCach"));
		bool bool_3 = f72FAFBC_0.AA824D29("ckbShareWall");
		int int_8 = f72FAFBC_0.method_0("nudCountShareFrom", 1);
		int int_9 = f72FAFBC_0.method_0("nudCountShareTo", 3);
		int result = 0;
		try
		{
			ac28BD29_0.method_69("fb://profile");
			ac28BD29_0.method_54(1.0, 2.0);
			string dE812B2A = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			method_72(int_1, dE812B2A, ac28BD29_0, int_2, int_3, bool_, "0124", int_4, int_5, bool_2, int_6, int_7, list_, bool_3, int_8, int_9);
		}
		catch (Exception)
		{
			result = -1;
		}
		return result;
	}

	public int method_72(int int_1, string DE812B2A, AC28BD29 ac28BD29_0, int int_2, int int_3, bool bool_4, string C23CDF0B, int int_4, int int_5, bool bool_5, int int_6, int int_7, List<string> list_13, bool bool_6, int int_8, int int_9, int int_10 = 0, bool bool_7 = false, string string_0 = "", int F5231290 = -1, int FC852727 = -1)
	{
		bool flag = ac28BD29_0.method_15().Contains("com.facebook.fbshorts");
		if (int_10 == 0)
		{
			int int_11 = 0;
			int int_12 = 0;
			int FEB51E = 0;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (bool_4)
			{
				num = ac28BD29_0.C4B7B817(int_4, int_5);
			}
			list_13 = Common.RemoveEmptyItems(list_13);
			List<string> C6832E1A = Common.smethod_11(list_13);
			if (bool_5)
			{
				num2 = ac28BD29_0.C4B7B817(int_6, int_7);
			}
			if (bool_6)
			{
				num3 = ac28BD29_0.C4B7B817(int_8, int_9);
			}
			int num4 = ac28BD29_0.C4B7B817(int_2, int_3);
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount < num4 * 1000)
			{
				switch (method_22(ac28BD29_0, int_1, DE812B2A))
				{
				case 0:
					SetStatusAccount(int_1, DE812B2A + "Scroll...");
					if (ac28BD29_0.CE16082B(1, 2) && !ac28BD29_0.method_68())
					{
						if (!ac28BD29_0.DoesElementExist(0, "", "//android.view.ViewGroup[@content-desc='Try it']"))
						{
							break;
						}
						ac28BD29_0.method_19();
					}
					C13AAEBB(int_1, DE812B2A, ac28BD29_0, bool_4 && int_11 < num, C23CDF0B, ref int_11, bool_5 && int_12 < num2, ref int_12, list_13, ref C6832E1A, bool_6 && FEB51E < num3, ref FEB51E);
					SetStatusAccount(int_1, DE812B2A + "Delay {time}s...", Base.rd.Next(2, 4));
					continue;
				case 1:
					continue;
				}
				break;
			}
		}
		else
		{
			int num5 = ac28BD29_0.C4B7B817(int_2, int_3);
			int int_13 = 0;
			int int_14 = 0;
			int FEB51E2 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			if (bool_4)
			{
				num6 = num5;
			}
			list_13 = Common.RemoveEmptyItems(list_13);
			List<string> C6832E1A2 = Common.smethod_11(list_13);
			if (bool_5)
			{
				num7 = num5;
			}
			if (bool_6)
			{
				num8 = num5;
			}
			int num9 = 1;
			for (int i = 0; i < num5 + 5; i++)
			{
				int num10 = method_22(ac28BD29_0, int_1, DE812B2A);
				if (num10 == 1)
				{
					ac28BD29_0.D7950A0F();
				}
				else if (num10 != 0)
				{
					break;
				}
				bool flag2 = false;
				if (flag)
				{
					if (i > 0)
					{
						flag2 = ac28BD29_0.CE16082B();
					}
				}
				else
				{
					flag2 = ac28BD29_0.CE16082B(1, 2);
				}
				if (flag2 && !ac28BD29_0.method_68())
				{
					break;
				}
				C13AAEBB(int_1, DE812B2A + $"({num9}/{num5}) ", ac28BD29_0, bool_4 && int_13 < num6, C23CDF0B, ref int_13, bool_5 && int_14 < num7, ref int_14, list_13, ref C6832E1A2, bool_6 && FEB51E2 < num8, ref FEB51E2, int_10, bool_7, string_0);
				if (int_13 >= num5 || int_14 >= num5 || FEB51E2 >= num5)
				{
					break;
				}
				num9 = new List<int> { int_13, int_14, FEB51E2 }.OrderBy((int int_0) => int_0).Last() + 1;
				if (F5231290 > -1 && FC852727 > -1)
				{
					SetStatusAccount(int_1, DE812B2A + $"({num9}/{num5}), delay {{time}}s...", ac28BD29_0.C4B7B817(F5231290, FC852727));
				}
				else
				{
					ac28BD29_0.method_54(1.5, 3.0);
				}
			}
		}
		return 0;
	}

	public int E40A2E10(int int_1, string string_0, AC28BD29 ac28BD29_0, int int_2, int int_3, bool E42EBF90, int int_4, int int_5, bool bool_4, int int_6, int int_7, List<string> B0863A83, bool DD0E2B07, int int_8, int B8849783)
	{
		int int_9 = 0;
		int int_10 = 0;
		int BA3525AB = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (E42EBF90)
		{
			num = ac28BD29_0.C4B7B817(int_4, int_5);
		}
		B0863A83 = Common.RemoveEmptyItems(B0863A83);
		List<string> list_ = Common.smethod_11(B0863A83);
		if (bool_4)
		{
			num2 = ac28BD29_0.C4B7B817(int_6, int_7);
		}
		if (DD0E2B07)
		{
			num3 = ac28BD29_0.C4B7B817(int_8, B8849783);
		}
		new List<string>();
		new List<string>();
		new List<string>();
		int num4 = ac28BD29_0.C4B7B817(int_2, int_3);
		int tickCount = Environment.TickCount;
		while (Environment.TickCount - tickCount < num4 * 1000)
		{
			int num5 = method_22(ac28BD29_0, int_1, string_0);
			if (num5 == 1 || num5 != 0)
			{
				break;
			}
			SetStatusAccount(int_1, string_0 + "Scroll...");
			if (ac28BD29_0.CE16082B(1, 2) && !ac28BD29_0.method_68())
			{
				break;
			}
			SetStatusAccount(int_1, string_0 + "Delay {time}s...", Base.rd.Next(3, 6));
			if (!(E42EBF90 || bool_4 || DD0E2B07))
			{
				continue;
			}
			SetStatusAccount(int_1, string_0 + "Tap Video...");
			if (ac28BD29_0.TapByXPath("//android.view.ViewGroup[@content-desc=\"Video\"]"))
			{
				if (!ac28BD29_0.DoesElementExist(3, "", "//android.view.ViewGroup[@content-desc=\"More options\"]"))
				{
					method_73(int_1, string_0, ac28BD29_0, E42EBF90 && int_9 < num, "", ref int_9, bool_4 && int_10 < num2, ref int_10, B0863A83, ref list_, DD0E2B07 && BA3525AB < num3, ref BA3525AB);
				}
				else
				{
					ac28BD29_0.FB3ACF2E();
					C13AAEBB(int_1, string_0, ac28BD29_0, E42EBF90 && int_9 < num, "0124", ref int_9, bool_4 && int_10 < num2, ref int_10, B0863A83, ref list_, DD0E2B07 && BA3525AB < num3, ref BA3525AB);
				}
				ac28BD29_0.method_19();
			}
		}
		return 0;
	}

	public int method_73(int B703E28F, string B6985DA6, AC28BD29 ac28BD29_0, bool BC9A7CA3, string string_0, ref int int_1, bool bool_4, ref int int_2, List<string> B6A1B89F, ref List<string> list_13, bool D1314C80, ref int BA3525AB)
	{
		new List<string>();
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		string text = "";
		if (BC9A7CA3)
		{
			SetStatusAccount(B703E28F, B6985DA6 + "Find Like...");
			string text2 = ac28BD29_0.FindElements(0, "", "//*[contains(@content-desc, \"Like\")]").FirstOrDefault();
			if (!string.IsNullOrEmpty(text2))
			{
				Point point = ac28BD29_0.method_51(text2);
				Point point2 = ac28BD29_0.method_51("[35," + text2.Split(new string[3] { "[", ",", "]" }, StringSplitOptions.RemoveEmptyEntries)[1] + "][65," + text2.Split(new string[3] { "[", ",", "]" }, StringSplitOptions.RemoveEmptyEntries)[3] + "]");
				SetStatusAccount(B703E28F, B6985DA6 + "Tap Reaction...");
				ac28BD29_0.method_50(point.X, point.Y, point2.X, point2.Y);
				ac28BD29_0.method_54(1.0, 1.5);
				string d80AC = "";
				if (string_0 != "")
				{
					d80AC = (Convert.ToInt32(string_0[ac28BD29_0.C4B7B817(0, string_0.Length - 1)].ToString()) + 1).ToString();
				}
				ac28BD29_0.C628163C(d80AC);
				ac28BD29_0.method_54(1.0, 1.5);
				ac28BD29_0.method_50(point2.X, point2.Y, point.X, point.Y);
				ac28BD29_0.method_54(1.0, 1.5);
				int_1++;
			}
		}
		if (bool_4)
		{
			SetStatusAccount(B703E28F, B6985DA6 + "Find Comment...");
			string a00A61A = ac28BD29_0.GetPageSource();
			list = ac28BD29_0.method_28(0, a00A61A, new List<string> { "//*[@text=\"Write a comment…\"]" });
			if (list.Count > 0)
			{
				Point point3 = ac28BD29_0.method_51(list.Last());
				if (list_13.Count == 0)
				{
					list_13 = Common.smethod_11(B6A1B89F);
				}
				text = list_13[ac28BD29_0.C4B7B817(0, list_13.Count - 1)];
				list_13.Remove(text);
				text = Common.SpinText(text);
				SetStatusAccount(B703E28F, B6985DA6 + "Tap Comment...");
				if (ac28BD29_0.method_37(point3.X, point3.Y))
				{
					ac28BD29_0.method_54(1.0, 2.0);
					SetStatusAccount(B703E28F, B6985DA6 + "Find EditText...");
					if (ac28BD29_0.DoesElementExist(5, "", "//android.widget.EditText"))
					{
						SetStatusAccount(B703E28F, B6985DA6 + Language.GetValue("Nhập dữ liệu..."));
						ac28BD29_0.SendByXPath("//android.widget.EditText", text);
						ac28BD29_0.method_54(1.0, 2.0);
						SetStatusAccount(B703E28F, B6985DA6 + "Tap Send...");
						if (ac28BD29_0.TapByXPath("//*[@content-desc=\"Send\"]"))
						{
							SetStatusAccount(B703E28F, B6985DA6 + "Tap Send, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(3, 6));
						}
						int_2++;
					}
					else
					{
						SetStatusAccount(B703E28F, B6985DA6 + "Back...");
						ac28BD29_0.method_19();
						ac28BD29_0.method_54(1.0, 2.0);
					}
				}
			}
		}
		if (D1314C80)
		{
			SetStatusAccount(B703E28F, B6985DA6 + "Find Share...");
			string a00A61A2 = ac28BD29_0.GetPageSource();
			list2 = ac28BD29_0.method_28(0, a00A61A2, new List<string> { "//*[@content-desc=\"SHARE\"]" });
			if (list2.Count > 0)
			{
				Point point4 = ac28BD29_0.method_51(list2.Last());
				SetStatusAccount(B703E28F, B6985DA6 + "Tap Share...");
				if (ac28BD29_0.method_37(point4.X, point4.Y))
				{
					ac28BD29_0.method_54(1.5, 2.0);
					SetStatusAccount(B703E28F, B6985DA6 + "Find Post...");
					if (ac28BD29_0.method_40(5, "//android.widget.ImageButton[@content-desc=\"Write Post\"]", "") && ac28BD29_0.method_40(5, "//android.widget.Button[@text =\"POST\"]", ""))
					{
						SetStatusAccount(B703E28F, B6985DA6 + "Tap Post, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(1, 3));
						BA3525AB++;
					}
					else
					{
						SetStatusAccount(B703E28F, B6985DA6 + "Back...");
						ac28BD29_0.method_19(1, 0.3);
					}
				}
			}
		}
		return 0;
	}

	public int C13AAEBB(int int_1, string string_0, AC28BD29 E0A51122, bool bool_4, string string_1, ref int int_2, bool bool_5, ref int int_3, List<string> DBAFF282, ref List<string> C6832E1A, bool bool_6, ref int FEB51E05, int EA3D06B1 = 0, bool bool_7 = false, string string_2 = "")
	{
		bool bool_8;
		if (bool_8 = E0A51122.method_15().Contains("com.facebook.fbshorts"))
		{
			string_1 = "1";
			bool_7 = false;
		}
		string text = E0A51122.GetPageSource();
		if (E0A51122.DoesElementExist(0, text, "//android.widget.EditText[@text='Write a comment…']") && E0A51122.method_28(0, text, new List<string> { "//*[@content-desc=\"Comment Button\"]", "//*[@content-desc=\"Answer Button\"]", "//*[@text='Answer']", "//*[@text=\"Comment\"]", "//*[@content-desc=\"Comment\"]" }).Count == 0)
		{
			method_75(bool_8, int_1, string_0, E0A51122, bool_4, string_1, ref int_2, bool_5, ref int_3, DBAFF282, ref C6832E1A, bool_6, ref FEB51E05, EA3D06B1, bool_7, string_2);
			method_74(bool_8, int_1, string_0, E0A51122, bool_4, string_1, ref int_2, bool_5, ref int_3, DBAFF282, ref C6832E1A, bool_6, ref FEB51E05, EA3D06B1, bool_7, string_2);
			method_76(bool_8, int_1, string_0, E0A51122, bool_4, string_1, ref int_2, bool_5, ref int_3, DBAFF282, ref C6832E1A, bool_6, ref FEB51E05, EA3D06B1, bool_7, string_2);
		}
		else
		{
			method_74(bool_8, int_1, string_0, E0A51122, bool_4, string_1, ref int_2, bool_5, ref int_3, DBAFF282, ref C6832E1A, bool_6, ref FEB51E05, EA3D06B1, bool_7, string_2);
			method_75(bool_8, int_1, string_0, E0A51122, bool_4, string_1, ref int_2, bool_5, ref int_3, DBAFF282, ref C6832E1A, bool_6, ref FEB51E05, EA3D06B1, bool_7, string_2);
			method_76(bool_8, int_1, string_0, E0A51122, bool_4, string_1, ref int_2, bool_5, ref int_3, DBAFF282, ref C6832E1A, bool_6, ref FEB51E05, EA3D06B1, bool_7, string_2);
		}
		return 0;
	}

	private void method_74(bool bool_4, int int_1, string string_0, AC28BD29 ac28BD29_0, bool CFB83D00, string F73E8B1B, ref int int_2, bool DB1F58B8, ref int CE15FE3F, List<string> list_13, ref List<string> list_14, bool FC37F0AF, ref int int_3, int int_4 = 0, bool bool_5 = false, string string_1 = "")
	{
		List<string> list = new List<string>();
		if (!CFB83D00)
		{
			return;
		}
		SetStatusAccount(int_1, string_0 + "Find Like...");
		string text = ac28BD29_0.GetPageSource();
		list = ac28BD29_0.method_28(0, text, new List<string> { "//*[@content-desc=\"Like button. Double tap and hold to react.\"]", "//*[@content-desc=\"Like Button\"]", "//*[@content-desc='Like']", "//*[contains(@content-desc, ', pressed. Double tap and hold to change reaction.')]" });
		SetStatusAccount(int_1, string_0 + "Find Like: " + list.Count);
		if (list.Count <= 0 || (int_4 != 1 && ac28BD29_0.C4B7B817(1, 100) % 3 != 0))
		{
			return;
		}
		string text2 = list.Where((string string_0) => new Class65(string_0).int_0 == 0).FirstOrDefault();
		if (string.IsNullOrEmpty(text2))
		{
			text2 = list.First();
		}
		Point point = ac28BD29_0.method_51(text2);
		string d80AC = "";
		if (F73E8B1B != "")
		{
			d80AC = (Convert.ToInt32(F73E8B1B[ac28BD29_0.C4B7B817(0, F73E8B1B.Length - 1)].ToString()) + 1).ToString();
		}
		SetStatusAccount(int_1, string_0 + "Tap Reaction...");
		bool flag = false;
		if (bool_4)
		{
			if (!ac28BD29_0.DoesElementExist(0, text, "//*[@content-desc='Like']/child::*"))
			{
				ac28BD29_0.method_37(point.X, point.Y);
			}
			flag = true;
		}
		else if (ac28BD29_0.method_49(point.X, point.Y) && ac28BD29_0.C628163C(d80AC))
		{
			flag = true;
		}
		if (flag)
		{
			int_2++;
			SetStatusAccount(int_1, string_0 + "Reaction, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(1, 3));
		}
	}

	private void method_75(bool bool_4, int A9A837BA, string string_0, AC28BD29 ac28BD29_0, bool AA918515, string string_1, ref int int_1, bool bool_5, ref int D837A434, List<string> list_13, ref List<string> list_14, bool bool_6, ref int C5915306, int int_2 = 0, bool F681F724 = false, string string_2 = "")
	{
		bool flag = false;
		List<string> list = new List<string>();
		string text = "";
		if (!(bool_5 || F681F724))
		{
			return;
		}
		SetStatusAccount(A9A837BA, string_0 + "Find Comment...");
		string text2 = ac28BD29_0.GetPageSource();
		list = ac28BD29_0.method_28(0, text2, new List<string> { "//*[@content-desc=\"Comment Button\"]", "//*[@content-desc=\"Answer Button\"]", "//*[@text='Answer']", "//*[@text=\"Comment\"]", "//*[@content-desc=\"Comment\"]", "//android.widget.EditText[@resource-id='composerInput']", "//android.widget.EditText[@text='Write a comment…']" });
		SetStatusAccount(A9A837BA, string_0 + "Find Comment: " + list.Count);
		if (list.Count <= 0)
		{
			return;
		}
		flag = !ac28BD29_0.DoesElementExist(0, text2, "//android.widget.EditText[@text='Write a comment…']");
		if (int_2 != 1 && ac28BD29_0.C4B7B817(1, 100) % 3 != 0)
		{
			return;
		}
		Point point = ac28BD29_0.method_51(list.First());
		SetStatusAccount(A9A837BA, string_0 + "Tap Comment...");
		if (!ac28BD29_0.method_37(point.X, point.Y))
		{
			return;
		}
		ac28BD29_0.method_54(1.0, 2.0);
		int i;
		for (i = 0; i < 2; i++)
		{
			SetStatusAccount(A9A837BA, string_0 + "Find EditText...");
			if (!ac28BD29_0.DoesElementExist(5, "", "//android.widget.EditText"))
			{
				if (!ac28BD29_0.TapByXPath("//android.widget.LinearLayout[@content-desc=\"Comment input box\"]"))
				{
					break;
				}
				continue;
			}
			if (bool_5)
			{
				if (list_14.Count == 0)
				{
					list_14 = Common.smethod_11(list_13);
				}
				text = list_14[ac28BD29_0.C4B7B817(0, list_14.Count - 1)];
				list_14.Remove(text);
				text = Common.SpinText(text);
				SetStatusAccount(A9A837BA, string_0 + Language.GetValue("Nhập dữ liệu..."));
				ac28BD29_0.SendByXPath("//android.widget.EditText", text);
				ac28BD29_0.method_54(1.0, 2.0);
			}
			if (F681F724 && method_52(A9A837BA, string_0, ac28BD29_0, string_2))
			{
				SetStatusAccount(A9A837BA, string_0 + "Find Camera...");
				if (ac28BD29_0.method_40(5, "//android.view.ViewGroup[@content-desc='Show photos and videos']", ""))
				{
					SetStatusAccount(A9A837BA, string_0 + "Select image...");
					for (int j = 0; j < 10; j++)
					{
						string string_3 = ac28BD29_0.GetPageSource();
						string text3 = ac28BD29_0.FindElement(0, string_3, new List<string> { "//android.widget.Button[@text='Allow']", "//android.widget.Button[@text='Enable gallery access']", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']" });
						if (text3 == "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']")
						{
							List<string> list2 = ac28BD29_0.FindElements(0, "", "//android.view.ViewGroup/android.view.ViewGroup[@content-desc='Photo' or @content-desc='Video']/parent::*[@selected='false']");
							if (list2.Count > 1)
							{
								list2 = list2.GetRange(0, list2.Count - 1);
							}
							if (list2.Count > 0)
							{
								string dB31F = list2.OrderBy((string string_0) => Guid.NewGuid()).First();
								ac28BD29_0.method_36(new Class65(dB31F).method_0());
								break;
							}
						}
						else if (text3 != "")
						{
							SetStatusAccount(A9A837BA, string_0 + "Tap " + ac28BD29_0.method_105(text3) + "...");
							ac28BD29_0.TapByXPath(text3, string_3);
						}
						ac28BD29_0.TimeDelay(1.0);
					}
					ac28BD29_0.method_19();
				}
			}
			SetStatusAccount(A9A837BA, string_0 + "Tap Send...");
			text2 = "";
			string a28409BD = ac28BD29_0.CB3C4B8A(5, ref text2, new List<string> { "//*[@content-desc=\"Send\"]", "//*[@text='Post']" });
			if (ac28BD29_0.TapByXPath(a28409BD, text2))
			{
				SetStatusAccount(A9A837BA, string_0 + "Tap Send, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(3, 6));
				ac28BD29_0.method_30(120);
				ac28BD29_0.DoesElementExist(10, "", "//androidx.recyclerview.widget.RecyclerView/child::*[1]//*[@content-desc='Just now']");
			}
			D837A434++;
			break;
		}
		if (flag)
		{
			SetStatusAccount(A9A837BA, string_0 + "Back...");
			if (i == 1)
			{
				ac28BD29_0.method_19();
			}
			else
			{
				ac28BD29_0.method_19(2, 0.3);
			}
			ac28BD29_0.method_54(1.0, 2.0);
		}
		else
		{
			text2 = ac28BD29_0.GetPageSource();
			if (ac28BD29_0.DoesElementExist(0, text2, "//android.widget.EditText[@text='Write a comment…']") && ac28BD29_0.method_28(0, text2, new List<string> { "//*[@content-desc=\"Comment Button\"]", "//*[@content-desc=\"Answer Button\"]", "//*[@text='Answer']", "//*[@text=\"Comment\"]", "//*[@content-desc=\"Comment\"]" }).Count == 0)
			{
				ac28BD29_0.FB3ACF2E(-1);
			}
		}
	}

	private void method_76(bool bool_4, int AC80D80A, string B2A8B82D, AC28BD29 ac28BD29_0, bool bool_5, string E08A2625, ref int int_1, bool D888AFAB, ref int E819FD1E, List<string> CBBF7817, ref List<string> list_13, bool bool_6, ref int int_2, int E7A70FB8 = 0, bool D40B250F = false, string string_0 = "")
	{
		List<string> list = new List<string>();
		if (!bool_6)
		{
			return;
		}
		List<string> list2 = new List<string> { "//*[@content-desc=\"Share Button\"]", "//*[@text=\"Share\"]" };
		string text = ac28BD29_0.method_15();
		if (text.Contains("com.facebook.fbshorts"))
		{
			list2.Add("//*[@content-desc=\"Share\"]");
		}
		SetStatusAccount(AC80D80A, B2A8B82D + "Find Share...");
		string a00A61A = ac28BD29_0.GetPageSource();
		list = ac28BD29_0.method_28(0, a00A61A, list2);
		SetStatusAccount(AC80D80A, B2A8B82D + "Find Share: " + list.Count);
		if (list.Count <= 0 || (E7A70FB8 != 1 && ac28BD29_0.C4B7B817(1, 100) % 3 != 0))
		{
			return;
		}
		Point point = ac28BD29_0.method_51(list.First());
		SetStatusAccount(AC80D80A, B2A8B82D + "Tap Share...");
		if (!ac28BD29_0.method_37(point.X, point.Y))
		{
			return;
		}
		ac28BD29_0.method_54(1.5, 2.0);
		SetStatusAccount(AC80D80A, B2A8B82D + "Find Share Now...");
		string string_ = "";
		if (ac28BD29_0.C60AEB35(5, ref string_, "//*[@content-desc=\"Share Now\"]"))
		{
			if (!ac28BD29_0.DoesElementExist(0, string_, "//*[@content-desc='Public']"))
			{
				ac28BD29_0.method_40(0, "//*[@content-desc='Write Post']/preceding-sibling::*[1]", string_);
				if (ac28BD29_0.method_40(10, "//*[@text='Public' or starts-with(@content-desc, 'Public')]", ""))
				{
					ac28BD29_0.method_40(5, "//android.widget.CheckBox[@text='Set as default audience.'][@checked='false']", "");
					ac28BD29_0.method_40(5, "//*[@content-desc='Done' or @text='Done' or @text='CHANGE' or @text='SAVE']", "");
				}
				else
				{
					ac28BD29_0.method_19();
				}
				string_ = "";
				ac28BD29_0.C60AEB35(5, ref string_, "//*[@content-desc=\"Share Now\"]");
			}
			if (ac28BD29_0.method_40(0, "//*[@content-desc=\"Share Now\"]", string_))
			{
				int_2++;
				SetStatusAccount(AC80D80A, B2A8B82D + "Tap Share Now, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(1, 3));
			}
		}
		else
		{
			SetStatusAccount(AC80D80A, B2A8B82D + "Back...");
			ac28BD29_0.method_19(1, 0.3);
		}
	}

	public int method_77(int CBA56F0A, string string_0, AC28BD29 ac28BD29_0, JSON_Settings B9BD6AAB, string string_1, string string_2)
	{
		int result = 1;
		int minValue = B9BD6AAB.method_0("nudDelayFrom", 3);
		int num = B9BD6AAB.method_0("nudDelayTo", 5);
		int f988D70A = B9BD6AAB.method_0("nudSoLuongUidFrom", 1);
		int e234B = B9BD6AAB.method_0("nudSoLuongUidTo", 3);
		bool flag = B9BD6AAB.AA824D29("ckbGetPostAPI");
		string string_3 = B9BD6AAB.GetValue("txtApiGetPost");
		List<string> list = B9BD6AAB.EC378D8A("txtIdPost");
		bool flag2 = list.Where((string string_0) => string_0.Contains("|")).Count() > 0;
		if (!flag && flag2)
		{
			lock (D80EF33F)
			{
				if (!D80EF33F.ContainsKey(string_2))
				{
					D80EF33F.Add(string_2, new Dictionary<string, int>());
					for (int i = 0; i < list.Count; i++)
					{
						string[] array = list[i].Split('|');
						int value = 1;
						string key = list[i];
						if (array.Length > 1)
						{
							try
							{
								value = Convert.ToInt32(array[0]);
							}
							catch
							{
							}
							key = array[1];
						}
						D80EF33F[string_2].Add(key, value);
					}
				}
			}
			if (D80EF33F[string_2].Count == 0)
			{
				goto IL_0580;
			}
		}
		int int_ = B9BD6AAB.method_0("nudTimeFrom");
		int int_2 = B9BD6AAB.method_0("nudTimeTo");
		bool a90EA = B9BD6AAB.AA824D29("ckbInteract");
		string string_4 = B9BD6AAB.GetValue("typeReaction");
		bool b = B9BD6AAB.AA824D29("ckbComment");
		List<string> d93C = B9BD6AAB.EC378D8A("txtComment", B9BD6AAB.method_0("typeNganCach"));
		bool bool_ = B9BD6AAB.AA824D29("ckbTuDongXoaNoiDung");
		bool bool_2 = B9BD6AAB.AA824D29("ckbAnh");
		string c92B = B9BD6AAB.GetValue("txtPathAnh");
		bool flag3 = B9BD6AAB.AA824D29("ckbTuongTacVideoTrenPost");
		int minValue2 = B9BD6AAB.method_0("nudTuongTacVideoTrenPostFrom", 3);
		int num2 = B9BD6AAB.method_0("nudTuongTacVideoTrenPostTo", 5);
		int num3 = ac28BD29_0.C4B7B817(f988D70A, e234B);
		string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
		List<string> list2 = new List<string>();
		for (int num4 = 0; num4 < num3; num4++)
		{
			string text2 = "";
			if (flag)
			{
				SetStatusAccount(CBA56F0A, text + "Getting Post...");
				for (int j = 0; j < 5; j++)
				{
					text2 = new RequestXNet("", "", "", 0).RequestGet(string_3);
					text2 = text2.Replace("\\/", "/").Trim();
					if (text2 != "")
					{
						break;
					}
					ac28BD29_0.TimeDelay(1.0);
				}
				if (text2 == "")
				{
					break;
				}
			}
			else
			{
				if (list.Count == 0)
				{
					break;
				}
				text = string_0 + Language.GetValue("Đang") + $" {string_1} ({num4 + 1}/{num3}): ";
				if (flag2)
				{
					lock (D80EF33F[string_2])
					{
						foreach (KeyValuePair<string, int> item in D80EF33F[string_2])
						{
							if (!list2.Contains(item.Key) && item.Value > 0)
							{
								text2 = item.Key;
								D80EF33F[string_2][text2]--;
								break;
							}
						}
						if (string.IsNullOrEmpty(text2))
						{
							break;
						}
						list2.Add(text2);
						goto IL_047c;
					}
				}
				text2 = list.OrderBy((string A3883132) => Guid.NewGuid()).First();
				list.Remove(text2);
			}
			goto IL_047c;
			IL_047c:
			method_78(CBA56F0A, text, ac28BD29_0, text2, int_, int_2, a90EA, string_4, b, d93C, bool_, bool_2, c92B, string_2);
			if (flag3)
			{
				SetStatusAccount(CBA56F0A, text + Language.GetValue("Tap video..."));
				if (ac28BD29_0.TapByXPath("//*[starts-with(@content-desc,'Shared Link:')]"))
				{
					ac28BD29_0.DoesElementExist(10, "", "//*[@resource-id='movie_player']");
					ac28BD29_0.E80B893F("//android.widget.Button[@text='TAP TO UNMUTE']", 10);
					SetStatusAccount(CBA56F0A, text + Language.GetValue("Xem video, " + Language.GetValue("đợi") + " {time}s..."), Base.rd.Next(minValue2, num2 + 1));
				}
			}
			SetStatusAccount(CBA56F0A, text + Language.GetValue("Tương tác xong, " + Language.GetValue("đợi") + " {time}s..."), Base.rd.Next(minValue, num + 1));
		}
		goto IL_0580;
		IL_0580:
		return result;
	}

	public int method_78(int int_1, string string_0, AC28BD29 C2A61D12, string A21837B9, int int_2, int int_3, bool A90EA990, string string_1, bool B9190581, List<string> D93C2123, bool bool_4, bool bool_5, string C92B8596, string string_2 = "")
	{
		try
		{
			SetStatusAccount(int_1, string_0 + Language.GetValue("Mở bài viết..."));
			int num = EAB1360A(C2A61D12, int_1, string_0, A21837B9);
			if (num == 1)
			{
				SetStatusAccount(int_1, string_0 + Language.GetValue("Xem ba\u0300i viê\u0301t, " + Language.GetValue("đợi") + " {time}s..."), Base.rd.Next(int_2, int_3 + 1));
				SetStatusAccount(int_1, string_0 + Language.GetValue("Tương tác ba\u0300i viê\u0301t..."));
				int int_4 = 0;
				int int_5 = 0;
				int FEB51E = 0;
				List<string> C6832E1A = new List<string>();
				List<string> list = new List<string>();
				if (string_2 == "")
				{
					list = Common.smethod_11(D93C2123);
				}
				else if (dictionary_8[string_2].Count > 0)
				{
					string item = "";
					if (!bool_4)
					{
						item = dictionary_8[string_2].OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
					}
					else
					{
						lock (dictionary_8)
						{
							int index = random_0.Next(0, dictionary_8[string_2].Count);
							item = dictionary_8[string_2][index];
							dictionary_8[string_2].RemoveAt(index);
						}
					}
					list.Add(item);
				}
				for (int i = 0; i < 5; i++)
				{
					C13AAEBB(int_1, string_0, C2A61D12, A90EA990, string_1, ref int_4, B9190581, ref int_5, list, ref C6832E1A, bool_6: false, ref FEB51E, 1, bool_5, C92B8596);
					if (int_4 <= 0 && int_5 <= 0)
					{
						SetStatusAccount(int_1, string_0 + "Scroll...");
						if (C2A61D12.CE16082B() && !C2A61D12.method_68())
						{
							break;
						}
						continue;
					}
					break;
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public int D7A3BBA6(int AA90230E, string string_0, AC28BD29 D4393787, JSON_Settings A2BC4298, string string_1)
	{
		int minValue = A2BC4298.method_0("nudSoLuongBanBeFrom");
		int num = A2BC4298.method_0("nudSoLuongBanBeTo");
		int int_ = A2BC4298.method_0("nudTimeFrom");
		int int_2 = A2BC4298.method_0("nudTimeTo");
		bool bool_ = A2BC4298.AA824D29("ckbInteract");
		int int_3 = A2BC4298.method_0("nudCountLikeFrom", 1);
		int int_4 = A2BC4298.method_0("nudCountLikeTo", 3);
		bool bool_2 = A2BC4298.AA824D29("ckbComment");
		int int_5 = A2BC4298.method_0("nudCountCommentFrom", 1);
		int int_6 = A2BC4298.method_0("nudCountCommentTo", 3);
		List<string> list_ = A2BC4298.EC378D8A("txtComment", A2BC4298.method_0("typeNganCach"));
		bool bool_3 = A2BC4298.AA824D29("ckbShareWall");
		int int_7 = A2BC4298.method_0("nudCountShareFrom", 1);
		int int_8 = A2BC4298.method_0("nudCountShareTo", 3);
		int num2 = 0;
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			int num3 = random_0.Next(minValue, num + 1);
			if (num3 != 0)
			{
				while (num2 < num3)
				{
					num2++;
					SetStatusAccount(AA90230E, text + $"({num2}/{num3}), Go to Friend...");
					if (!FA905AA0(D4393787, AA90230E, text, "fb://friends"))
					{
						break;
					}
					SetStatusAccount(AA90230E, text + $"({num2}/{num3}), Find Friend...");
					List<string> list = D4393787.FindElements(3, "", "//android.view.View[contains(@content-desc,\", profile picture\") or contains(@text,\", profile picture\")]");
					SetStatusAccount(AA90230E, text + $"({num2}/{num3}), Find Friend: " + list.Count);
					if (list.Count == 0)
					{
						break;
					}
					SetStatusAccount(AA90230E, text + $"({num2}/{num3}), Scroll...");
					int num4 = 0;
					if (list.Count >= 6)
					{
						while (!D4393787.CE16082B())
						{
							num4++;
							if (num4 >= 5)
							{
								break;
							}
						}
						int num5 = D4393787.C4B7B817(0, ((num4 < 1) ? 1 : num4) - 1);
						for (int i = 0; i < num5; i++)
						{
							if (D4393787.CE16082B(-1))
							{
								break;
							}
						}
						SetStatusAccount(AA90230E, text + $"({num2}/{num3}), Find Friend...");
						list = D4393787.FindElements(3, "", "//android.view.View[contains(@content-desc,\", profile picture\") or contains(@text,\", profile picture\")]");
					}
					SetStatusAccount(AA90230E, text + $"({num2}/{num3}), Tap Friend...");
					D4393787.E832B991(list.smethod_8());
					D4393787.method_54(2.0, 3.0);
					method_72(AA90230E, text + $"({num2}/{num3}), ", D4393787, int_, int_2, bool_, "0124", int_3, int_4, bool_2, int_5, int_6, list_, bool_3, int_7, int_8);
				}
			}
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "HDTuongTacBanBe");
		}
		return num2;
	}

	public int method_79(int B801ECB8, string BF173A12, AC28BD29 BB1BE82A, JSON_Settings f72FAFBC_0, string CA08E200)
	{
		int minValue = f72FAFBC_0.method_0("nudSoLuongNhomFrom");
		int num = f72FAFBC_0.method_0("nudSoLuongNhomTo");
		int int_ = f72FAFBC_0.method_0("nudTimeFrom");
		int int_2 = f72FAFBC_0.method_0("nudTimeTo");
		bool bool_ = f72FAFBC_0.AA824D29("ckbInteract");
		int int_3 = f72FAFBC_0.method_0("nudCountLikeFrom", 1);
		int int_4 = f72FAFBC_0.method_0("nudCountLikeTo", 3);
		bool bool_2 = f72FAFBC_0.AA824D29("ckbComment");
		int int_5 = f72FAFBC_0.method_0("nudCountCommentFrom", 1);
		int int_6 = f72FAFBC_0.method_0("nudCountCommentTo", 3);
		List<string> list_ = f72FAFBC_0.EC378D8A("txtComment", f72FAFBC_0.method_0("typeNganCach"));
		bool bool_3 = f72FAFBC_0.AA824D29("ckbShareWall");
		int int_7 = f72FAFBC_0.method_0("nudCountShareFrom", 1);
		int int_8 = f72FAFBC_0.method_0("nudCountShareTo", 3);
		int num2 = 0;
		try
		{
			string text = BF173A12 + Language.GetValue("Đang") + " " + CA08E200 + ": ";
			int num3 = random_0.Next(minValue, num + 1);
			if (num3 != 0)
			{
				while (num2 < num3)
				{
					num2++;
					SetStatusAccount(B801ECB8, text + $"({num2}/{num3}), Go to Group...");
					if (!FA905AA0(BB1BE82A, B801ECB8, text, "fb://faceweb/f?href=https://m.facebook.com/groups_browse/your_groups/"))
					{
						break;
					}
					SetStatusAccount(B801ECB8, text + $"({num2}/{num3}), Find Group...");
					List<string> list = BB1BE82A.FindElements(3, "", "//android.view.View[starts-with(@content-desc,\"group image link\") or starts-with(@text,\"group image link\")]");
					SetStatusAccount(B801ECB8, text + $"({num2}/{num3}), Find Group: " + list.Count);
					if (list.Count == 0)
					{
						break;
					}
					SetStatusAccount(B801ECB8, text + $"({num2}/{num3}), Scroll...");
					int num4 = 0;
					if (list.Count >= 9)
					{
						while (!BB1BE82A.CE16082B())
						{
							num4++;
							if (num4 >= 5)
							{
								break;
							}
						}
						int num5 = BB1BE82A.C4B7B817(0, ((num4 < 1) ? 1 : num4) - 1);
						for (int i = 0; i < num5; i++)
						{
							if (BB1BE82A.CE16082B(-1))
							{
								break;
							}
						}
						SetStatusAccount(B801ECB8, text + $"({num2}/{num3}), Find Group...");
						list = BB1BE82A.FindElements(3, "", "//android.view.View[starts-with(@content-desc,\"group image link\") or starts-with(@text,\"group image link\")]");
					}
					SetStatusAccount(B801ECB8, text + $"({num2}/{num3}), Tap Group...");
					BB1BE82A.E832B991(list.smethod_8());
					BB1BE82A.method_54(2.0, 3.0);
					method_72(B801ECB8, text + $"({num2}/{num3}), ", BB1BE82A, int_, int_2, bool_, "0124", int_3, int_4, bool_2, int_5, int_6, list_, bool_3, int_7, int_8);
				}
			}
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "HDTTuongTacNhom");
		}
		return num2;
	}

	public int FE0D7408(int int_1, string string_0, AC28BD29 CD9EAB11, JSON_Settings f72FAFBC_0, string AD09B382, string string_1)
	{
		int minValue = f72FAFBC_0.method_0("nudSoLuongPageFrom");
		int num = f72FAFBC_0.method_0("nudSoLuongPageTo");
		bool flag = f72FAFBC_0.AA824D29("ckbTuDongXoaUid");
		int int_2 = f72FAFBC_0.method_0("nudTimeFrom");
		int int_3 = f72FAFBC_0.method_0("nudTimeTo");
		bool bool_ = f72FAFBC_0.AA824D29("ckbInteract");
		int int_4 = f72FAFBC_0.method_0("nudCountLikeFrom", 1);
		int int_5 = f72FAFBC_0.method_0("nudCountLikeTo", 3);
		bool bool_2 = f72FAFBC_0.AA824D29("ckbComment");
		int int_6 = f72FAFBC_0.method_0("nudCountCommentFrom", 1);
		int int_7 = f72FAFBC_0.method_0("nudCountCommentTo", 3);
		List<string> list_ = f72FAFBC_0.EC378D8A("txtComment", f72FAFBC_0.method_0("typeNganCach"));
		bool bool_3 = f72FAFBC_0.AA824D29("ckbShareWall");
		int int_8 = f72FAFBC_0.method_0("nudCountShareFrom", 1);
		int int_9 = f72FAFBC_0.method_0("nudCountShareTo", 3);
		int num2 = 0;
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			int num3 = random_0.Next(minValue, num + 1);
			if (num3 != 0)
			{
				List<string> list = new List<string>();
				if (!flag)
				{
					list = Common.smethod_11(C8289C88[AD09B382]);
				}
				string text2 = "";
				while (num2 < num3)
				{
					num2++;
					if (!flag)
					{
						if (list.Count != 0)
						{
							text2 = list[random_0.Next(0, list.Count)];
							list.Remove(text2);
							goto IL_0234;
						}
						break;
					}
					lock (C8289C88)
					{
						if (C8289C88[AD09B382].Count == 0)
						{
							break;
						}
						text2 = C8289C88[AD09B382][random_0.Next(0, C8289C88[AD09B382].Count)];
						C8289C88[AD09B382].Remove(text2);
						goto IL_0234;
					}
					IL_0234:
					SetStatusAccount(int_1, text + $"({num2}/{num3}), Go to Page {text2}...");
					if (FA905AA0(CD9EAB11, int_1, text, "fb://" + (text2.StartsWith("1000") ? "profile" : "page") + "/" + text2))
					{
						SetStatusAccount(int_1, text + $"({num2}/{num3}), Find Post...");
						if (CD9EAB11.method_40(5, "//*[contains(@content-desc,\"Posts, Tab\")]", ""))
						{
							CD9EAB11.method_54(2.0, 3.0);
							method_72(int_1, text + $"({num2}/{num3}), ", CD9EAB11, int_2, int_3, bool_, "0124", int_4, int_5, bool_2, int_6, int_7, list_, bool_3, int_8, int_9);
						}
						continue;
					}
					break;
				}
			}
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "HDTTuongTacPage");
		}
		return num2;
	}

	public int BBB0D1BD(int B223DC20, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string E58A03AC, string F1B24B03)
	{
		bool flag = f72FAFBC_0.AA824D29("ckbTuDongXoaNoiDung");
		string text = "";
		if (CAB1A00C[E58A03AC].Count > 0)
		{
			if (!flag)
			{
				text = CAB1A00C[E58A03AC][random_0.Next(0, CAB1A00C[E58A03AC].Count)];
			}
			else
			{
				lock (CAB1A00C)
				{
					int index = random_0.Next(0, CAB1A00C[E58A03AC].Count);
					text = CAB1A00C[E58A03AC][index];
					CAB1A00C[E58A03AC].RemoveAt(index);
				}
			}
		}
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("id", (object)f72FAFBC_0.GetValue("txtUid"));
		f72FAFBC.GetValue("isLikePage", f72FAFBC_0.AA824D29("ckbInteract"));
		f72FAFBC.GetValue("isReviewPage", true);
		f72FAFBC.GetValue("content", (object)text);
		string string_ = string_0 + Language.GetValue("Đang") + " " + F1B24B03 + ": ";
		(bool, string) tuple = method_30(B223DC20, string_, ac28BD29_0, f72FAFBC);
		if (!tuple.Item1 && flag)
		{
			lock (CAB1A00C)
			{
				CAB1A00C[E58A03AC].Add(text);
			}
		}
		return tuple.Item1 ? 1 : 0;
	}

	public int method_80(int C3858DA8, string D283DE0D, AC28BD29 C981C125, JSON_Settings AC3A8B18, string AAAC2FBE)
	{
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("id", (object)AC3A8B18.GetValue("txtUid"));
		f72FAFBC.GetValue("isLikePage", true);
		string string_ = D283DE0D + Language.GetValue("Đang") + " " + AAAC2FBE + ": ";
		return method_30(C3858DA8, string_, C981C125, f72FAFBC).isSuccess ? 1 : 0;
	}

	public int AA0BBF13(AC28BD29 ac28BD29_0, int int_1, string string_0)
	{
		string text = "";
		int tickCount = Environment.TickCount;
		int num = 10;
		do
		{
			SetStatusAccount(int_1, string_0 + "Find Like...");
			text = ac28BD29_0.GetPageSource();
			string text2 = ac28BD29_0.FindElement(0, text, new List<string> { "//android.view.ViewGroup[@content-desc='Liked']", "//android.view.ViewGroup[@content-desc='Following']", "//android.view.ViewGroup[@content-desc='Like']", "//android.view.ViewGroup[@content-desc='like button']/android.view.ViewGroup", "//android.view.ViewGroup[@content-desc='like button']", "//android.view.ViewGroup[@content-desc='Follow']" });
			switch (text2)
			{
			default:
				SetStatusAccount(int_1, string_0 + "Scroll...");
				if (ac28BD29_0.CE16082B(-1))
				{
					switch (method_22(ac28BD29_0, int_1, string_0))
					{
					case 0:
						goto IL_00a7;
					case 1:
						return -1;
					}
					break;
				}
				goto IL_00a7;
			case "//android.view.ViewGroup[@content-desc='Like']":
			case "//android.view.ViewGroup[@content-desc='like button']/android.view.ViewGroup":
			case "//android.view.ViewGroup[@content-desc='like button']":
			case "//android.view.ViewGroup[@content-desc='Follow']":
				SetStatusAccount(int_1, string_0 + "Tap " + ac28BD29_0.method_105(text2) + "...");
				ac28BD29_0.TapByXPath(text2, text);
				SetStatusAccount(int_1, string_0 + "Tap Like, " + Language.GetValue("đợi") + " {time}s...", 3);
				return 1;
			case "//android.view.ViewGroup[@content-desc='Liked']":
			case "//android.view.ViewGroup[@content-desc='Following']":
				break;
			}
			break;
			IL_00a7:
			ac28BD29_0.TimeDelay(1.0);
		}
		while (Environment.TickCount - tickCount < num * 1000);
		return 0;
	}

	public int method_81(int D215822E, string string_0, AC28BD29 AE8DA393, JSON_Settings f72FAFBC_0, string string_1)
	{
		JSON_Settings f72FAFBC = new JSON_Settings();
		f72FAFBC.GetValue("id", (object)f72FAFBC_0.GetValue("txtUid"));
		string f5036F8D = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
		return BB33E209(D215822E, f5036F8D, AE8DA393, f72FAFBC).isSuccess ? 1 : 0;
	}

	public int method_82(ref int int_1, int B61DF23E, string string_0, AC28BD29 ac28BD29_0, JSON_Settings C189EC10, string FAAEA71E, string string_1)
	{
		int minValue = C189EC10.method_0("nudSoLuongFrom");
		int num = C189EC10.method_0("nudSoLuongTo");
		int num2 = C189EC10.method_0("typeDang");
		List<string> collection = C189EC10.EC378D8A("txtNoiDung");
		List<string> list = new List<string>();
		bool flag = C189EC10.AA824D29("ckbUseBackgroundText");
		int num3 = C189EC10.method_0("typeBaiHat");
		bool flag2 = C189EC10.AA824D29("ckbUseBackgroundNhac");
		bool flag3 = C189EC10.AA824D29("ckbAnh");
		string aF2C0C = C189EC10.GetValue("txtPathAnh");
		bool bool_ = C189EC10.AA824D29("ckbXoaAnhDaDang");
		string aF2C0C2 = C189EC10.GetValue("txtChiDangAnhPathAnh");
		bool bool_2 = C189EC10.AA824D29("ckbChiDangAnhXoaAnhDaDang");
		if (flag2 && flag3)
		{
			if (ac28BD29_0.C4B7B817(1, 100) % 2 == 0)
			{
				flag2 = false;
			}
			else
			{
				flag3 = false;
			}
		}
		int num4 = 0;
		string text = "";
		string text2 = "";
		try
		{
			string text3 = string_0 + Language.GetValue("Đang") + " " + FAAEA71E + ": ";
			int num5 = random_0.Next(minValue, num + 1);
			bool flag4 = false;
			int num6 = 0;
			while (num6 < num5 + 5)
			{
				int num7 = 0;
				int num8 = 1;
				while (num4 < num5)
				{
					SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5})...");
					try
					{
						ac28BD29_0.D7950A0F();
						int tickCount = Environment.TickCount;
						int num9 = 300;
						switch (num2)
						{
						case 0:
						{
							List<string> list2 = new List<string> { "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]", "//*[@content-desc='Add to story']", "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*", "//*[@content-desc='Start a Text story']", "//*[@content-desc='Select background']", "//*[contains(@content-desc,', background')]", "//android.widget.EditText[@content-desc='Text field']", "//*[@text='Privacy']", "//*[@text='Public']", "//android.widget.Button[@content-desc='Share']" };
							if (!flag)
							{
								list2.Remove("//*[@content-desc='Select background']");
								list2.Remove("//*[contains(@content-desc,', background')]");
							}
							do
							{
								text = ac28BD29_0.GetPageSource();
								text2 = ac28BD29_0.FindElement(0, text, list2);
								string text4 = text2;
								string text5 = text4;
								uint num10 = HashString.DA8CEBAB(text5);
								if (num10 > 725689854)
								{
									if (num10 <= 2516125468u)
									{
										if (num10 != 2378966911u)
										{
											if (num10 == 2516125468u && text5 == "//*[contains(@content-desc,', background')]")
											{
												List<string> source = ac28BD29_0.FindElements(0, text, text2);
												ac28BD29_0.E832B991(source.OrderBy((string string_0) => Guid.NewGuid()).First());
												goto IL_04e4;
											}
										}
										else if (text5 == "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]")
										{
											goto IL_030f;
										}
									}
									else if (num10 != 2923101247u)
									{
										if (num10 != 3025215824u)
										{
											if (num10 == 3339772369u && text5 == "//*[@text='Privacy']")
											{
												goto IL_030f;
											}
										}
										else if (text5 == "//*[@content-desc='Add to story']")
										{
											goto IL_030f;
										}
									}
									else if (text5 == "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*")
									{
										if ((ac28BD29_0.method_23(text, "(" + text2 + ")[1]", "content-desc").FirstOrDefault() ?? "").Contains("music"))
										{
											ac28BD29_0.TapByXPath("(" + text2 + ")[last()]", text);
										}
										else
										{
											ac28BD29_0.TapByXPath("(" + text2 + ")[1]", text);
										}
										goto IL_04e4;
									}
								}
								else if (num10 <= 349629914)
								{
									if (num10 != 159668279)
									{
										if (num10 == 349629914 && text5 == "//*[@text='Public']")
										{
											goto IL_030f;
										}
									}
									else if (text5 == "//*[@content-desc='Select background']")
									{
										goto IL_030f;
									}
								}
								else if (num10 != 471470080)
								{
									if (num10 != 598952663)
									{
										if (num10 == 725689854 && text5 == "//*[@content-desc='Start a Text story']")
										{
											goto IL_030f;
										}
									}
									else if (text5 == "//android.widget.Button[@content-desc='Share']")
									{
										SetStatusAccount(B61DF23E, text3 + "Tap " + ac28BD29_0.method_105(text2) + "...");
										ac28BD29_0.TapByXPath(text2, text);
										ac28BD29_0.TimeDelay(2.0);
										if (ac28BD29_0.method_40(10, "//android.widget.Button[@text='NOT NOW']", ""))
										{
											SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), Tap Post, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(3, 6));
										}
										SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), " + Language.GetValue("đợi") + " post success...");
										if (flag4)
										{
											ac28BD29_0.D7950A0F();
											ac28BD29_0.TimeDelay(3.0);
										}
										if (ac28BD29_0.method_30(flag3 ? 300 : 60))
										{
											num4++;
											if (num4 < num5)
											{
												break;
											}
											return num4;
										}
										break;
									}
								}
								else if (text5 == "//android.widget.EditText[@content-desc='Text field']")
								{
									if (list.Count == 0)
									{
										list = new List<string>(collection);
									}
									string text6 = list.OrderBy((string string_0) => Guid.NewGuid()).FirstOrDefault();
									list.Remove(text6);
									text6 = Common.SpinText(text6);
									if (text6.Trim() != "")
									{
										ac28BD29_0.method_54(1.0, 1.5);
										SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), " + Language.GetValue("Nhập dữ liệu..."));
										ac28BD29_0.SendByXPath(text2, text6);
										ac28BD29_0.TimeDelay(2.0);
										ac28BD29_0.TapByXPath("(//android.widget.Button[@content-desc='Back']/parent::*/child::*)[last()]", text);
									}
									goto IL_04e4;
								}
								if (ac28BD29_0.DoesElementExist(0, text, "//*[@content-desc='Stories']"))
								{
									Class65 @class = new Class65(ac28BD29_0.FindElements(0, text, "//*[@content-desc='Stories']").FirstOrDefault());
									if (@class.E42395AA - @class.B9898119 < 200)
									{
										ac28BD29_0.E832B991(@class.AA3F9A29());
										goto IL_04e4;
									}
								}
								SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), Scroll...");
								if (ac28BD29_0.CE16082B(-1))
								{
									int num11 = method_22(ac28BD29_0, B61DF23E, string_0);
									if (num11 == 1 || num11 == 0)
									{
										break;
									}
									return num4;
								}
								goto IL_04e4;
								IL_030f:
								SetStatusAccount(B61DF23E, text3 + "Tap " + ac28BD29_0.method_105(text2) + "...");
								ac28BD29_0.TapByXPath(text2, text);
								switch (text2)
								{
								case "//*[@content-desc='Add to story']":
									flag4 = true;
									break;
								case "//*[@text='Privacy']":
									ac28BD29_0.DoesElementExist(60, "", "//*[@text='Public']");
									break;
								case "//*[@text='Public']":
									ac28BD29_0.method_40(5, "//*[@text='CHANGE' or @text='SAVE']", "");
									ac28BD29_0.TapByXPath("//*[@content-desc='Back']", text);
									ac28BD29_0.method_30(60);
									break;
								}
								goto IL_04e4;
								IL_04e4:
								if (text2 != "")
								{
									list2.Remove(text2);
								}
								ac28BD29_0.TimeDelay(2.0);
							}
							while (Environment.TickCount - tickCount < num9 * 1000);
							goto end_IL_017c;
						}
						case 1:
						{
							List<string> list3 = new List<string>
							{
								"//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]", "//*[@content-desc='Add to story']", "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*", "//*[@content-desc='Start a Music story']", "(//*[@content-desc='Photo'])[last()]", "//*[@content-desc='Select background']", "//*[contains(@content-desc,', background')]", "//*[@content-desc='Close background styles tray']", "//android.widget.EditText[starts-with(@text,'Search music')]", "//*[@content-desc='Song preview']",
								"//*[@text='Done']", "//*[@text='Privacy']", "//*[@text='Public']", "//android.widget.Button[@content-desc='Share']", "//android.widget.ProgressBar"
							};
							if (!flag2)
							{
								list3.Remove("//*[@content-desc='Select background']");
								list3.Remove("//*[contains(@content-desc,', background')]");
							}
							if (!flag3)
							{
								list3.Remove("(//*[@content-desc='Photo'])[last()]");
							}
							while (true)
							{
								text = ac28BD29_0.GetPageSource();
								text2 = ac28BD29_0.FindElement(0, text, list3);
								string text7 = text2;
								string text8 = text7;
								uint num10 = HashString.DA8CEBAB(text8);
								if (num10 > 2378966911u)
								{
									if (num10 <= 3330475511u)
									{
										if (num10 <= 2923101247u)
										{
											if (num10 != 2516125468u)
											{
												if (num10 != 2923101247u || !(text8 == "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*"))
												{
													goto IL_0cf7;
												}
												if ((ac28BD29_0.method_23(text, "(" + text2 + ")[1]", "content-desc").FirstOrDefault() ?? "").Contains("music"))
												{
													ac28BD29_0.TapByXPath("(" + text2 + ")[last()]", text);
												}
												else
												{
													ac28BD29_0.TapByXPath("(" + text2 + ")[1]", text);
												}
											}
											else
											{
												if (!(text8 == "//*[contains(@content-desc,', background')]"))
												{
													goto IL_0cf7;
												}
												List<string> source2 = ac28BD29_0.FindElements(0, text, text2);
												ac28BD29_0.E832B991(source2.OrderBy((string AA8F1BB6) => Guid.NewGuid()).First());
												ac28BD29_0.TimeDelay(2.0);
												ac28BD29_0.TapByXPath("//*[@content-desc='Close background styles tray']", text);
											}
											goto IL_0e39;
										}
										if (num10 != 3025215824u)
										{
											if (num10 != 3330475511u || !(text8 == "//*[@content-desc='Close background styles tray']"))
											{
												goto IL_0cf7;
											}
										}
										else if (!(text8 == "//*[@content-desc='Add to story']"))
										{
											goto IL_0cf7;
										}
									}
									else
									{
										if (num10 > 3802764538u)
										{
											if (num10 != 3872622007u)
											{
												if (num10 == 4152636390u && text8 == "//android.widget.EditText[starts-with(@text,'Search music')]")
												{
													if (num3 == 1)
													{
														int num12 = 0;
														int num13 = 3;
														do
														{
															num12++;
															if (num12 <= num13)
															{
																string text9 = "";
																lock (dictionary_12)
																{
																	if (dictionary_12[string_1].Count == 0)
																	{
																		dictionary_12[string_1] = new List<string>(dictionary_11[string_1]);
																	}
																	text9 = dictionary_12[string_1].OrderBy((string string_0) => Guid.NewGuid()).First();
																	dictionary_12[string_1].Remove(text9);
																}
																text9 = Common.SpinText(text9);
																if (text9.Trim() != "")
																{
																	ac28BD29_0.method_54(1.0, 1.5);
																	SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), " + Language.GetValue("Nhập dữ liệu..."));
																	ac28BD29_0.TapByXPath(text2, text);
																	ac28BD29_0.SendByXPath(text2, text9 + " ");
																	ac28BD29_0.B2016D94(AC28BD29.DB353F82.const_67);
																	ac28BD29_0.TimeDelay(2.0);
																}
																continue;
															}
															int_1 = 2;
															return num4;
														}
														while (!ac28BD29_0.DoesElementExist(30, "", "//*[@content-desc='Song preview']"));
													}
													else
													{
														ac28BD29_0.DoesElementExist(120, "", "//*[@content-desc='Song preview']");
													}
													goto IL_0e39;
												}
											}
											else if (text8 == "//*[@text='Done']")
											{
												goto IL_0d90;
											}
											goto IL_0cf7;
										}
										if (num10 != 3339772369u)
										{
											if (num10 != 3802764538u || !(text8 == "//*[@content-desc='Start a Music story']"))
											{
												goto IL_0cf7;
											}
										}
										else if (!(text8 == "//*[@text='Privacy']"))
										{
											goto IL_0cf7;
										}
									}
									goto IL_0d90;
								}
								if (num10 <= 532719482)
								{
									if (num10 != 159668279)
									{
										if (num10 != 349629914)
										{
											if (num10 == 532719482 && text8 == "//android.widget.ProgressBar")
											{
												SetStatusAccount(B61DF23E, text3 + "Loading...");
												if (!ac28BD29_0.method_30(60))
												{
													if (num7 < num8)
													{
														num7++;
														break;
													}
													return num4;
												}
												goto IL_0e39;
											}
										}
										else if (text8 == "//*[@text='Public']")
										{
											goto IL_0d90;
										}
									}
									else if (text8 == "//*[@content-desc='Select background']")
									{
										goto IL_0d90;
									}
									goto IL_0cf7;
								}
								if (num10 > 630380789)
								{
									if (num10 != 2097544948)
									{
										if (num10 == 2378966911u && text8 == "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]")
										{
											goto IL_0d90;
										}
									}
									else if (text8 == "//*[@content-desc='Song preview']")
									{
										if (flag3)
										{
											method_52(B61DF23E, text3 + $"({num4 + 1}/{num5}), ", ac28BD29_0, aF2C0C, 1, bool_);
										}
										SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), Tap song...");
										Point point = new Class65(ac28BD29_0.FindElements(0, text, text2).First()).F799891B();
										ac28BD29_0.method_37(point.X - 500, point.Y);
										for (int i = 0; i < 60; i++)
										{
											ac28BD29_0.TimeDelay(2.0);
											if (ac28BD29_0.GetPageSource() != text)
											{
												break;
											}
										}
										goto IL_0e39;
									}
									goto IL_0cf7;
								}
								if (num10 != 598952663)
								{
									if (num10 != 630380789 || !(text8 == "(//*[@content-desc='Photo'])[last()]"))
									{
										goto IL_0cf7;
									}
									goto IL_0d90;
								}
								if (!(text8 == "//android.widget.Button[@content-desc='Share']"))
								{
									goto IL_0cf7;
								}
								SetStatusAccount(B61DF23E, text3 + "Tap " + ac28BD29_0.method_105(text2) + "...");
								ac28BD29_0.TapByXPath(text2, text);
								ac28BD29_0.TimeDelay(2.0);
								if (ac28BD29_0.method_40(10, "//android.widget.Button[@text='NOT NOW']", ""))
								{
									SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), Tap Post, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(3, 6));
								}
								SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), " + Language.GetValue("đợi") + " post success...");
								if (flag4)
								{
									ac28BD29_0.D7950A0F();
									ac28BD29_0.TimeDelay(3.0);
								}
								if (ac28BD29_0.method_30(flag3 ? 300 : 60))
								{
									num4++;
									if (num4 >= num5)
									{
										return num4;
									}
								}
								goto end_IL_017c;
								IL_0d90:
								SetStatusAccount(B61DF23E, text3 + "Tap " + ac28BD29_0.method_105(text2) + "...");
								ac28BD29_0.TapByXPath(text2, text);
								switch (text2)
								{
								case "//*[@content-desc='Add to story']":
									flag4 = true;
									break;
								case "//*[@text='Privacy']":
									ac28BD29_0.DoesElementExist(60, "", "//*[@text='Public']");
									break;
								case "//*[@text='Public']":
									ac28BD29_0.method_40(5, "//*[@text='CHANGE' or @text='SAVE']", "");
									ac28BD29_0.TapByXPath("//*[@content-desc='Back']", text);
									ac28BD29_0.method_30(60);
									break;
								}
								goto IL_0e39;
								IL_0cf7:
								if (ac28BD29_0.DoesElementExist(0, text, "//*[@content-desc='Stories']"))
								{
									Class65 class2 = new Class65(ac28BD29_0.FindElements(0, text, "//*[@content-desc='Stories']").FirstOrDefault());
									if (class2.E42395AA - class2.B9898119 < 200)
									{
										ac28BD29_0.E832B991(class2.AA3F9A29());
										goto IL_0e39;
									}
								}
								SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), Scroll...");
								if (!ac28BD29_0.CE16082B(-1))
								{
									goto IL_0e39;
								}
								int num14 = method_22(ac28BD29_0, B61DF23E, string_0);
								if (num14 != 1 && num14 != 0)
								{
									return num4;
								}
								goto end_IL_017c;
								IL_0e39:
								if (text2 != "")
								{
									list3.Remove(text2);
								}
								ac28BD29_0.TimeDelay(2.0);
								if (Environment.TickCount - tickCount < num9 * 1000)
								{
									continue;
								}
								goto end_IL_017c;
							}
							continue;
						}
						}
						List<string> list4 = new List<string> { "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]", "//*[@content-desc='Add to story']", "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*", "//*[@content-desc='Photo' or @content-desc='Video']/*[@content-desc='Photo' or @content-desc='Video']", "//*[@text='Privacy']", "//*[@text='Public']", "//android.widget.Button[@content-desc='Share']", "//android.widget.ProgressBar" };
						method_52(B61DF23E, text3 + $"({num4 + 1}/{num5}), ", ac28BD29_0, aF2C0C2, 1, bool_2);
						while (true)
						{
							text = ac28BD29_0.GetPageSource();
							text2 = ac28BD29_0.FindElement(0, text, list4);
							string text10 = text2;
							string text11 = text10;
							uint num10 = HashString.DA8CEBAB(text11);
							if (num10 > 2378966911u)
							{
								if (num10 <= 3025215824u)
								{
									if (num10 != 2923101247u)
									{
										if (num10 == 3025215824u && text11 == "//*[@content-desc='Add to story']")
										{
											goto IL_14dc;
										}
									}
									else if (text11 == "//*[@content-desc='Stories']//androidx.recyclerview.widget.RecyclerView/child::*/child::*")
									{
										if ((ac28BD29_0.method_23(text, "(" + text2 + ")[1]", "content-desc").FirstOrDefault() ?? "").Contains("music"))
										{
											ac28BD29_0.TapByXPath("(" + text2 + ")[last()]", text);
										}
										else
										{
											ac28BD29_0.TapByXPath("(" + text2 + ")[1]", text);
										}
										goto IL_1585;
									}
								}
								else if (num10 != 3339772369u)
								{
									if (num10 == 3808682138u && text11 == "//*[@content-desc='Photo' or @content-desc='Video']/*[@content-desc='Photo' or @content-desc='Video']")
									{
										if (ac28BD29_0.DoesElementExist(0, text, "//*[@content-desc='Stories']"))
										{
											Class65 class3 = new Class65(ac28BD29_0.FindElements(0, text, "//*[@content-desc='Stories']").FirstOrDefault());
											if (class3.E42395AA - class3.B9898119 < 200)
											{
												ac28BD29_0.E832B991(class3.AA3F9A29());
												goto IL_1585;
											}
										}
										SetStatusAccount(B61DF23E, text3 + "Tap " + ac28BD29_0.method_105(text2) + "...");
										ac28BD29_0.TapByXPath(text2, text);
										goto IL_1585;
									}
								}
								else if (text11 == "//*[@text='Privacy']")
								{
									goto IL_14dc;
								}
								goto IL_1443;
							}
							if (num10 <= 532719482)
							{
								if (num10 != 349629914)
								{
									if (num10 == 532719482 && text11 == "//android.widget.ProgressBar")
									{
										SetStatusAccount(B61DF23E, text3 + "Loading...");
										if (!ac28BD29_0.method_30(60))
										{
											if (num7 < num8)
											{
												num7++;
												break;
											}
											return num4;
										}
										goto IL_1585;
									}
								}
								else if (text11 == "//*[@text='Public']")
								{
									goto IL_14dc;
								}
								goto IL_1443;
							}
							if (num10 != 598952663)
							{
								if (num10 != 2378966911u || !(text11 == "//*[@content-desc='Create a reel']/parent::*/parent::*/parent::*/parent::*/parent::*/child::*[1]/child::*[1]"))
								{
									goto IL_1443;
								}
								goto IL_14dc;
							}
							if (!(text11 == "//android.widget.Button[@content-desc='Share']"))
							{
								goto IL_1443;
							}
							SetStatusAccount(B61DF23E, text3 + "Tap " + ac28BD29_0.method_105(text2) + "...");
							ac28BD29_0.TapByXPath(text2, text);
							ac28BD29_0.TimeDelay(2.0);
							if (ac28BD29_0.method_40(10, "//android.widget.Button[@text='NOT NOW']", ""))
							{
								SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), Tap Post, " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(3, 6));
							}
							SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), " + Language.GetValue("đợi") + " post success...");
							if (flag4)
							{
								ac28BD29_0.D7950A0F();
								ac28BD29_0.TimeDelay(3.0);
							}
							if (ac28BD29_0.method_30(flag3 ? 300 : 60))
							{
								num4++;
								if (num4 >= num5)
								{
									return num4;
								}
							}
							goto end_IL_017c;
							IL_14dc:
							SetStatusAccount(B61DF23E, text3 + "Tap " + ac28BD29_0.method_105(text2) + "...");
							ac28BD29_0.TapByXPath(text2, text);
							switch (text2)
							{
							case "//*[@content-desc='Add to story']":
								flag4 = true;
								break;
							case "//*[@text='Privacy']":
								ac28BD29_0.DoesElementExist(60, "", "//*[@text='Public']");
								break;
							case "//*[@text='Public']":
								ac28BD29_0.method_40(5, "//*[@text='CHANGE' or @text='SAVE']", "");
								ac28BD29_0.TapByXPath("//*[@content-desc='Back']", text);
								ac28BD29_0.method_30(60);
								break;
							}
							goto IL_1585;
							IL_1585:
							if (text2 != "")
							{
								list4.Remove(text2);
							}
							ac28BD29_0.TimeDelay(2.0);
							if (Environment.TickCount - tickCount < num9 * 1000)
							{
								continue;
							}
							goto end_IL_017c;
							IL_1443:
							if (ac28BD29_0.DoesElementExist(0, text, "//*[@content-desc='Stories']"))
							{
								Class65 class4 = new Class65(ac28BD29_0.FindElements(0, text, "//*[@content-desc='Stories']").FirstOrDefault());
								if (class4.E42395AA - class4.B9898119 < 200)
								{
									ac28BD29_0.E832B991(class4.AA3F9A29());
									goto IL_1585;
								}
							}
							SetStatusAccount(B61DF23E, text3 + $"({num4 + 1}/{num5}), Scroll...");
							if (!ac28BD29_0.CE16082B(-1))
							{
								goto IL_1585;
							}
							int num15 = method_22(ac28BD29_0, B61DF23E, string_0);
							if (num15 != 1 && num15 != 0)
							{
								return num4;
							}
							goto end_IL_017c;
						}
						continue;
						end_IL_017c:;
					}
					catch
					{
					}
					num6++;
					goto IL_013a;
				}
				break;
				IL_013a:;
			}
		}
		catch
		{
		}
		return num4;
	}

	public int method_83(int BE8B209C, string string_0, AC28BD29 A02ECC90, JSON_Settings f72FAFBC_0, string string_1, string string_2)
	{
		int minValue = f72FAFBC_0.method_0("nudSoLuongUidFrom");
		int num = f72FAFBC_0.method_0("nudSoLuongUidTo");
		int num2 = f72FAFBC_0.method_0("nudSoLuongBaiVietFrom");
		int num3 = f72FAFBC_0.method_0("nudSoLuongBaiVietTo");
		int f = f72FAFBC_0.method_0("nudDelayFrom");
		int fC = f72FAFBC_0.method_0("nudDelayTo");
		int num4 = f72FAFBC_0.method_0("typeID");
		bool bool_ = f72FAFBC_0.AA824D29("ckbInteract");
		string c23CDF0B = f72FAFBC_0.GetValue("typeReaction");
		bool bool_2 = f72FAFBC_0.AA824D29("ckbShareWall");
		bool bool_3 = f72FAFBC_0.AA824D29("ckbComment");
		List<string> list = f72FAFBC_0.EC378D8A("txtComment", f72FAFBC_0.method_0("typeNganCach"));
		bool flag = f72FAFBC_0.AA824D29("ckbTuDongXoaUid");
		bool bool_4 = f72FAFBC_0.AA824D29("ckbAnh");
		string string_3 = f72FAFBC_0.GetValue("txtPathAnh");
		bool flag2 = f72FAFBC_0.AA824D29("ckbReel");
		new List<string>();
		List<string> list2 = new List<string>();
		if (!flag)
		{
			list2 = EE98FB8B(dictionary_9[string_2]);
		}
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			int num5 = random_0.Next(minValue, num + 1);
			for (int num6 = 0; num6 < num5; num6++)
			{
				string text2 = "";
				if (flag)
				{
					lock (dictionary_9)
					{
						if (dictionary_9[string_2].Count == 0)
						{
							break;
						}
						int index = random_0.Next(0, dictionary_9[string_2].Count);
						text2 = dictionary_9[string_2][index];
						dictionary_9[string_2].RemoveAt(index);
						goto IL_0241;
					}
				}
				if (list2.Count != 0)
				{
					text2 = list2[random_0.Next(0, list2.Count)];
					list2.Remove(text2);
					goto IL_0241;
				}
				break;
				IL_0241:
				string text3 = "";
				switch (num4)
				{
				case 0:
					text3 = "fb://profile/" + text2;
					break;
				case 1:
					text3 = "fb://group/" + text2;
					break;
				case 2:
					text3 = ((!text2.StartsWith("1000")) ? ("fb://page/" + text2) : ("fb://profile/" + text2));
					break;
				}
				while (FA905AA0(A02ECC90, BE8B209C, text, text3))
				{
					for (int i = 0; i < list.Count; i++)
					{
						list[i] = list[i].Replace("@[uid:0]", "@[" + text2 + ":0]");
					}
					if (flag2)
					{
						int num7 = 0;
						int num8 = 4;
						int tickCount = Environment.TickCount;
						string string_4;
						string text4;
						while (true)
						{
							string_4 = A02ECC90.GetPageSource();
							text4 = A02ECC90.FindElement(0, string_4, new List<string> { "//*[@content-desc='Reels' or (@content-desc='Reels, tab' and @selected='false')]", "//*[starts-with(@content-desc,'Reel,')]", "//*[@content-desc='Posts, tab']" });
							switch (text4)
							{
							case "//*[@content-desc='Reels' or (@content-desc='Reels, tab' and @selected='false')]":
								SetStatusAccount(BE8B209C, text + $"({num6 + 1}/{num5}), " + "Tap " + A02ECC90.method_105(text4) + "...");
								A02ECC90.TapByXPath(text4, string_4);
								goto IL_037f;
							default:
								SetStatusAccount(BE8B209C, text + $"({num6 + 1}/{num5}), " + "Scroll...");
								if (A02ECC90.CE16082B())
								{
									int num9 = method_22(A02ECC90, BE8B209C, text);
									if (num9 == 1)
									{
										goto IL_04ac;
									}
									if (num9 != 0)
									{
										goto end_IL_04ac;
									}
								}
								goto IL_037f;
							case "//*[@content-desc='Posts, tab']":
								num7++;
								if (num7 >= num8)
								{
									goto end_IL_04ac;
								}
								A02ECC90.TapByXPath("//*[@content-desc='Posts, tab']/parent::*/parent::*/child::*[last()]/child::*", string_4);
								goto IL_037f;
							case "//*[starts-with(@content-desc,'Reel,')]":
								break;
								IL_037f:
								if (Environment.TickCount - tickCount < 60000)
								{
									A02ECC90.TimeDelay(2.0);
									continue;
								}
								goto end_IL_04ac;
							}
							break;
						}
						SetStatusAccount(BE8B209C, text + $"({num6 + 1}/{num5}), " + "Tap " + A02ECC90.method_105(text4) + "...");
						A02ECC90.TapByXPath(text4, string_4);
					}
					else if (text3.Contains("page"))
					{
						A02ECC90.TapByXPath("//*[contains(@content-desc,\"Posts, Tab\")]");
						A02ECC90.TimeDelay(2.0);
					}
					method_72(BE8B209C, text + $"({num6 + 1}/{num5}), ", A02ECC90, num2, num3, bool_, c23CDF0B, num2, num3, bool_3, num2, num3, list, bool_2, 0, 0, 1, bool_4, string_3, f, fC);
					break;
					continue;
					end_IL_04ac:
					break;
					IL_04ac:;
				}
			}
		}
		catch
		{
		}
		return 0;
	}

	public int CC03DE3E(int E4AE0D95, string string_0, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string string_1, string string_2)
	{
		List<string> f1808BA = f72FAFBC_0.EC378D8A("txtTuKhoa");
		int num = f72FAFBC_0.method_0("nudSoLuongBaiVietFrom");
		int num2 = f72FAFBC_0.method_0("nudSoLuongBaiVietTo");
		int f = f72FAFBC_0.method_0("nudDelayFrom");
		int fC = f72FAFBC_0.method_0("nudDelayTo");
		bool bool_ = f72FAFBC_0.AA824D29("ckbInteract");
		string c23CDF0B = f72FAFBC_0.GetValue("typeReaction");
		bool bool_2 = f72FAFBC_0.AA824D29("ckbComment");
		List<string> f1808BA2 = f72FAFBC_0.EC378D8A("txtComment", f72FAFBC_0.method_0("typeNganCach"));
		bool bool_3 = f72FAFBC_0.AA824D29("ckbAnh");
		string string_3 = f72FAFBC_0.GetValue("txtPathAnh");
		new List<string>();
		new List<string>();
		f1808BA2 = Common.RemoveEmptyItems(f1808BA2);
		EE98FB8B(f1808BA2);
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + string_1 + ": ";
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			string string_4 = f1808BA[random_0.Next(0, f1808BA.Count)];
			string_4 = Common.SpinText(string_4);
			SetStatusAccount(E4AE0D95, text + "Search Post...");
			if (ac28BD29_0.method_71(string_4, "Posts"))
			{
				method_72(E4AE0D95, text, ac28BD29_0, num, num2, bool_, c23CDF0B, num, num2, bool_2, num, num2, f1808BA2, bool_6: false, 0, 0, 1, bool_3, string_3, f, fC);
			}
		}
		catch
		{
		}
		return 0;
	}

	public int CB3AB7BA(int int_1, string AD10061D, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string EA2214A7, string string_0)
	{
		List<string> f1808BA = f72FAFBC_0.EC378D8A("txtTuKhoa");
		int minValue = f72FAFBC_0.method_0("nudTimeFrom");
		int num = f72FAFBC_0.method_0("nudTimeTo");
		int int_2 = f72FAFBC_0.method_0("nudSoLuongFrom");
		int int_3 = f72FAFBC_0.method_0("nudSoLuongTo");
		bool flag = f72FAFBC_0.AA824D29("ckbInteract");
		bool flag2 = f72FAFBC_0.AA824D29("ckbShareWall");
		bool flag3 = f72FAFBC_0.AA824D29("ckbComment");
		List<string> dBAFF = f72FAFBC_0.EC378D8A("txtComment", f72FAFBC_0.method_0("typeNganCach"));
		try
		{
			string text = AD10061D + Language.GetValue("Đang") + " " + EA2214A7 + ": ";
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			string string_ = f1808BA[random_0.Next(0, f1808BA.Count)];
			string_ = Common.SpinText(string_);
			SetStatusAccount(int_1, text + "Search...");
			ac28BD29_0.method_72(string_);
			int num2 = Common.F413B12C(int_2, int_3);
			int num3 = 0;
			while (ac28BD29_0.TapByXPath($"//androidx.recyclerview.widget.RecyclerView/child::*/child::*/child::*[{num3 % 9 + 1}]"))
			{
				num3++;
				text = AD10061D + Language.GetValue("Đang") + $" {EA2214A7}: ({num3}/{num2}), ";
				SetStatusAccount(int_1, text + Language.GetValue("Xem, " + Language.GetValue("đợi") + " {time}s..."), Base.rd.Next(minValue, num + 1));
				SetStatusAccount(int_1, text + Language.GetValue("Tương tác..."));
				int int_4 = 0;
				int int_5 = 0;
				int FEB51E = 0;
				List<string> C6832E1A = new List<string>();
				for (int i = 0; i < 5; i++)
				{
					C13AAEBB(int_1, text, ac28BD29_0, flag, "0", ref int_4, flag3, ref int_5, dBAFF, ref C6832E1A, flag2, ref FEB51E, 1);
					if (int_4 > 0 || int_5 > 0 || (!flag && !flag3 && !flag2))
					{
						break;
					}
					SetStatusAccount(int_1, text + "Scroll...");
					if (ac28BD29_0.CE16082B() && !ac28BD29_0.method_68())
					{
						break;
					}
				}
				if (num3 < num2)
				{
					ac28BD29_0.TimeDelay(2.0);
					ac28BD29_0.method_19();
					ac28BD29_0.TimeDelay(2.0);
					if (num3 % 9 == 0)
					{
						ac28BD29_0.CE16082B(1, 2);
					}
					continue;
				}
				break;
			}
		}
		catch
		{
		}
		return 0;
	}

	public int method_84(int A1ACE52C, string D0A276AB, AC28BD29 EE114DB5, JSON_Settings f72FAFBC_0, string string_0, string D782E3A4)
	{
		int minValue = f72FAFBC_0.method_0("nudSoLuongUidFrom");
		int num = f72FAFBC_0.method_0("nudSoLuongUidTo");
		int num2 = f72FAFBC_0.method_0("nudSoLuongBaiVietFrom");
		int num3 = f72FAFBC_0.method_0("nudSoLuongBaiVietTo");
		int f988D70A = f72FAFBC_0.method_0("nudDelayFrom");
		int e234B = f72FAFBC_0.method_0("nudDelayTo");
		bool bool_ = f72FAFBC_0.AA824D29("ckbInteract");
		string c23CDF0B = f72FAFBC_0.GetValue("typeReaction");
		bool bool_2 = f72FAFBC_0.AA824D29("ckbComment");
		List<string> f1808BA = f72FAFBC_0.EC378D8A("txtComment", f72FAFBC_0.method_0("typeNganCach"));
		bool bool_3 = f72FAFBC_0.AA824D29("ckbAnh");
		string string_ = f72FAFBC_0.GetValue("txtPathAnh");
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		try
		{
			string text = D0A276AB + Language.GetValue("Đang") + " " + string_0 + ": ";
			int num4 = random_0.Next(minValue, num + 1);
			int num5 = 0;
			while (num5 < num4)
			{
				while (true)
				{
					SetStatusAccount(A1ACE52C, text + $"({num5 + 1}/{num4}), Go to Group...");
					if (!FA905AA0(EE114DB5, A1ACE52C, text, "fb://faceweb/f?href=https://m.facebook.com/groups_browse/your_groups/"))
					{
						break;
					}
					SetStatusAccount(A1ACE52C, text + $"({num5 + 1}/{num4}), Find Group...");
					List<string> list = EE114DB5.FindElements(3, "", "//android.view.View[starts-with(@content-desc,\"group image link\") or starts-with(@text,\"group image link\")]");
					SetStatusAccount(A1ACE52C, text + $"({num5 + 1}/{num4}), Find Group: " + list.Count);
					if (list.Count == 0)
					{
						break;
					}
					SetStatusAccount(A1ACE52C, text + $"({num5 + 1}/{num4}), Scroll...");
					int num6 = 0;
					if (list.Count >= 9)
					{
						while (!EE114DB5.CE16082B())
						{
							num6++;
							if (num6 >= 5)
							{
								break;
							}
						}
						int num7 = EE114DB5.C4B7B817(0, ((num6 < 1) ? 1 : num6) - 1);
						for (int i = 0; i < num7; i++)
						{
							if (EE114DB5.CE16082B(-1))
							{
								break;
							}
						}
						SetStatusAccount(A1ACE52C, text + $"({num5 + 1}/{num4}), Find Group...");
						list = EE114DB5.FindElements(3, "", "//android.view.View[starts-with(@content-desc,\"group image link\") or starts-with(@text,\"group image link\")]");
					}
					SetStatusAccount(A1ACE52C, text + $"({num5 + 1}/{num4}), Tap Group...");
					EE114DB5.E832B991(list.smethod_8());
					EE114DB5.method_54(2.0, 3.0);
					switch (method_22(EE114DB5, A1ACE52C, D0A276AB))
					{
					case 1:
						break;
					case 0:
						goto IL_031e;
					default:
						goto end_IL_00cd;
					}
					continue;
					IL_031e:
					method_72(A1ACE52C, text + $"({num5 + 1}/{num4}), ", EE114DB5, num2, num3, bool_, c23CDF0B, num2, num3, bool_2, num2, num3, f1808BA, bool_6: false, 0, 0, 1, bool_3, string_);
					SetStatusAccount(A1ACE52C, text + $"({num5 + 1}/{num4}), delay {{time}}s...", EE114DB5.C4B7B817(f988D70A, e234B));
					num5++;
					goto IL_0399;
				}
				break;
				IL_0399:;
			}
			end_IL_00cd:;
		}
		catch
		{
		}
		return 0;
	}

	public int C8BC6407(int int_1, string string_0, AC28BD29 AA3F281B, JSON_Settings f72FAFBC_0, string EFB313A9, string B80A2028)
	{
		int minValue = f72FAFBC_0.method_0("nudSoLuongUidFrom");
		int num = f72FAFBC_0.method_0("nudSoLuongUidTo");
		int num2 = f72FAFBC_0.method_0("nudSoLuongBaiVietFrom");
		int num3 = f72FAFBC_0.method_0("nudSoLuongBaiVietTo");
		int f988D70A = f72FAFBC_0.method_0("nudDelayFrom");
		int e234B = f72FAFBC_0.method_0("nudDelayTo");
		bool bool_ = f72FAFBC_0.AA824D29("ckbInteract");
		string c23CDF0B = f72FAFBC_0.GetValue("typeReaction");
		bool bool_2 = f72FAFBC_0.AA824D29("ckbComment");
		List<string> f1808BA = f72FAFBC_0.EC378D8A("txtComment", f72FAFBC_0.method_0("typeNganCach"));
		bool bool_3 = f72FAFBC_0.AA824D29("ckbAnh");
		string string_ = f72FAFBC_0.GetValue("txtPathAnh");
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		try
		{
			string text = string_0 + Language.GetValue("Đang") + " " + EFB313A9 + ": ";
			int num4 = random_0.Next(minValue, num + 1);
			int num5 = 0;
			while (num5 < num4)
			{
				while (true)
				{
					SetStatusAccount(int_1, text + $"({num5 + 1}/{num4}), Go to Friend...");
					if (!FA905AA0(AA3F281B, int_1, text, "fb://friends"))
					{
						break;
					}
					SetStatusAccount(int_1, text + $"({num5 + 1}/{num4}), Find Friend...");
					List<string> list = AA3F281B.FindElements(3, "", "//android.view.View[contains(@content-desc,\", profile picture\") or contains(@text,\", profile picture\")]");
					SetStatusAccount(int_1, text + $"({num5 + 1}/{num4}), Find Friend: " + list.Count);
					if (list.Count == 0)
					{
						break;
					}
					SetStatusAccount(int_1, text + $"({num5 + 1}/{num4}), Scroll...");
					int num6 = 0;
					if (list.Count >= 6)
					{
						while (!AA3F281B.CE16082B())
						{
							num6++;
							if (num6 >= 5)
							{
								break;
							}
						}
						int num7 = AA3F281B.C4B7B817(0, ((num6 < 1) ? 1 : num6) - 1);
						for (int i = 0; i < num7; i++)
						{
							if (AA3F281B.CE16082B(-1))
							{
								break;
							}
						}
						SetStatusAccount(int_1, text + $"({num5 + 1}/{num4}), Find Friend...");
						list = AA3F281B.FindElements(3, "", "//android.view.View[contains(@content-desc,\", profile picture\") or contains(@text,\", profile picture\")]");
					}
					SetStatusAccount(int_1, text + $"({num5 + 1}/{num4}), Tap Friend...");
					AA3F281B.E832B991(list.smethod_8());
					AA3F281B.method_54(2.0, 3.0);
					switch (method_22(AA3F281B, int_1, string_0))
					{
					case 1:
						break;
					case 0:
						goto IL_031d;
					default:
						goto end_IL_00cd;
					}
					continue;
					IL_031d:
					method_72(int_1, text + $"({num5 + 1}/{num4}), ", AA3F281B, num2, num3, bool_, c23CDF0B, num2, num3, bool_2, num2, num3, f1808BA, bool_6: false, 0, 0, 1, bool_3, string_);
					SetStatusAccount(int_1, text + $"({num5 + 1}/{num4}), delay {{time}}s...", AA3F281B.C4B7B817(f988D70A, e234B));
					num5++;
					goto IL_0398;
				}
				break;
				IL_0398:;
			}
			end_IL_00cd:;
		}
		catch
		{
		}
		return 0;
	}

	public int method_85(int F1870C36, string C4BAF5B6, AC28BD29 B182DF3A, JSON_Settings E00EAB90, string string_0)
	{
		int num = E00EAB90.method_0("nudSoLuongBaiVietFrom");
		int num2 = E00EAB90.method_0("nudSoLuongBaiVietTo");
		int f = E00EAB90.method_0("nudDelayFrom");
		int fC = E00EAB90.method_0("nudDelayTo");
		bool bool_ = E00EAB90.AA824D29("ckbInteract");
		string c23CDF0B = E00EAB90.GetValue("typeReaction");
		bool bool_2 = E00EAB90.AA824D29("ckbComment");
		List<string> f1808BA = E00EAB90.EC378D8A("txtComment", E00EAB90.method_0("typeNganCach"));
		bool bool_3 = E00EAB90.AA824D29("ckbAnh");
		string string_ = E00EAB90.GetValue("txtPathAnh");
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		try
		{
			string dE812B2A = C4BAF5B6 + Language.GetValue("Đang") + " " + string_0 + ": ";
			B182DF3A.D7950A0F();
			B182DF3A.method_54(1.0, 2.0);
			method_72(F1870C36, dE812B2A, B182DF3A, num, num2, bool_, c23CDF0B, num, num2, bool_2, num, num2, f1808BA, bool_6: false, 0, 0, 1, bool_3, string_, f, fC);
		}
		catch
		{
		}
		return 0;
	}

	public int D1AA84B0(int int_1, string ED13F338, Chrome gclass9_0, int int_2, int int_3, int int_4, int D7028303, int int_5, int int_6, bool bool_4, List<string> list_13, Random random_1, string string_0 = "", bool bool_5 = false, string string_1 = "", bool A8898A10 = false, string string_2 = "", bool bool_6 = false, int EF95B8A3 = 0, bool bool_7 = false, bool A8228734 = false, List<string> DD22EDA6 = null, int int_7 = 0)
	{
		string a9364E = method_117(int_1, "cUid");
		string string_3 = method_117(int_1, "cPassword");
		string string_4 = method_117(int_1, "cFa2");
		int num = 0;
		string text = "";
		string text2 = "";
		List<string> list = new List<string>();
		list_13 = Common.RemoveEmptyItems(list_13);
		list = EE98FB8B(list_13);
		List<string> a9BDBF2B = new List<string>();
		List<string> list2 = new List<string>();
		if (bool_5)
		{
			a9BDBF2B = Directory.GetFiles(string_1).ToList();
			list2 = EE98FB8B(a9BDBF2B);
		}
		List<string> list3 = new List<string>();
		if (!A8898A10)
		{
			list3 = EE98FB8B(C61991A0[string_2]);
		}
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		try
		{
			int num5 = random_1.Next(int_2, int_3 + 1);
			int num6 = 0;
			while (num6 < num5)
			{
				string text3 = "";
				if (A8898A10)
				{
					lock (C61991A0)
					{
						if (C61991A0[string_2].Count == 0)
						{
							break;
						}
						text3 = C61991A0[string_2][random_1.Next(0, C61991A0[string_2].Count)];
						C61991A0[string_2].Remove(text3);
						goto IL_017e;
					}
				}
				if (list3.Count != 0)
				{
					text3 = list3[random_1.Next(0, list3.Count)];
					list3.Remove(text3);
					goto IL_017e;
				}
				break;
				IL_017e:
				if (bool_6 && EF95B8A3 == 0)
				{
					do
					{
						gclass9_0.D920192A("https://m.facebook.com/" + text3);
						gclass9_0.C2B42BB6(2.0);
						num4 = method_63(gclass9_0, a9364E, string_3, string_4);
					}
					while (num4 == 1);
					if (new List<int> { -3, -2, -1, 2 }.Contains(num4))
					{
						return -1;
					}
					string text4 = gclass9_0.F4AF93AB("return document.documentElement.innerHTML.match(new RegExp('<title>(.*?)</title>'))[1]").ToString();
					text4 = text4.Split('-')[0].Trim();
					int num7 = 0;
					int num8 = 0;
					if (gclass9_0.method_24($"document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}]") == 1)
					{
						num7 = 0;
						if (Convert.ToBoolean(gclass9_0.F4AF93AB($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{num8}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')!=null)+''")) || Convert.ToBoolean(gclass9_0.F4AF93AB($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{num8}].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]')!=null)+''")) || Convert.ToBoolean(gclass9_0.F4AF93AB($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{num8}].querySelector('[data-sigil=\"share-popup\"]')!=null)+''")))
						{
							num7++;
						}
						if (gclass9_0.B2277F30())
						{
							return -2;
						}
						gclass9_0.method_27("document.querySelectorAll('[data-store*=\"linkdata\"]')[" + num8 + "]");
						method_68(3);
						if (bool_7 && Convert.ToBoolean(gclass9_0.F4AF93AB($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{num8}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')!=null)+''")))
						{
							gclass9_0.method_27("document.querySelectorAll('[data-store*=\"linkdata\"]')[" + num8 + "].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')");
							num7++;
							if (Convert.ToBoolean(gclass9_0.F4AF93AB($"var output='false';var x=document.querySelectorAll('[data-store*=\"linkdata\"]')[{num8}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a');  if(x!=null) output=(JSON.parse(x.getAttribute('data-store')).reaction==0)+''; return output;").ToString()))
							{
								method_68();
								gclass9_0.method_14(4, "[data-store*=\"linkdata\"]", num8, 4, "[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a");
								method_68();
							}
						}
						if (A8228734 && Convert.ToBoolean(gclass9_0.F4AF93AB($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{num8}].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]')!=null)+''")))
						{
							num7++;
							gclass9_0.method_14(4, "[data-store*=\"linkdata\"]", num8, 4, "[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]");
							method_68();
							if (gclass9_0.C6B3E9B0("[data-sigil=\"textarea mufi-composer m-textarea-input\"]", 5.0) == 1)
							{
								method_68();
								gclass9_0.method_27("document.querySelector('[data-sigil =\"textarea mufi-composer m-textarea-input\"]')");
								method_68();
								List<string> list4 = new List<string>();
								if (list4.Count == 0)
								{
									list4 = EE98FB8B(DD22EDA6);
								}
								string text5 = list4[random_1.Next(0, list4.Count)];
								list4.Remove(text5);
								text5 = Common.SpinText(text5);
								text5 = text5.Replace("[u]", text4);
								gclass9_0.method_19(4, "[data-sigil =\"textarea mufi-composer m-textarea-input\"]", text5 + " ", 0.1);
								method_68(3);
								for (int i = 0; i < 10; i++)
								{
									if (gclass9_0.method_14(2, "submit") == 1)
									{
										break;
									}
									Common.DelayTime(1.0);
								}
								method_68(2);
							}
							gclass9_0.method_11();
							method_68();
						}
					}
				}
				do
				{
					gclass9_0.D920192A("https://m.facebook.com/messages/read/?fbid=" + text3);
					method_68();
					num4 = method_63(gclass9_0, a9364E, string_3, string_4);
				}
				while (num4 == 1);
				if (!new List<int> { -3, -2, -1, 2 }.Contains(num4))
				{
					if (gclass9_0.C6B3E9B0("[name=\"body\"]", 10.0) == 1)
					{
						if (bool_5)
						{
							int num9 = random_1.Next(int_4, D7028303 + 1);
							num2 = Convert.ToInt32(gclass9_0.F4AF93AB("return document.querySelectorAll('[data-sigil=\"touchable\"]>img').length"));
							if (gclass9_0.C6B3E9B0("[data-sigil=\"m-raw-file-input\"]") == 1)
							{
								for (int j = 0; j < num9; j++)
								{
									if (list2.Count == 0)
									{
										list2 = EE98FB8B(a9BDBF2B);
									}
									text2 = list2[random_1.Next(0, list2.Count)];
									list2.Remove(text2);
									gclass9_0.method_17(4, "[data-sigil=\"m-raw-file-input\"]", text2);
									gclass9_0.C2B42BB6(1.0);
								}
							}
							for (int k = 0; k < 60; k++)
							{
								num3 = Convert.ToInt32(gclass9_0.F4AF93AB("return document.querySelectorAll('[data-sigil=\"touchable\"]>img').length"));
								if (num3 >= num9 + num2)
								{
									break;
								}
								gclass9_0.C2B42BB6(1.0);
							}
							method_68();
						}
						if (bool_4)
						{
							if (list.Count == 0)
							{
								list = EE98FB8B(list_13);
							}
							text = list[random_1.Next(0, list.Count)];
							list.Remove(text);
							text = Common.SpinText(text);
							string newValue = gclass9_0.F4AF93AB("return document.querySelector('[data-sigil=\" token\"]').innerText.replace('×','').trim()").ToString();
							text = text.Replace("[u]", newValue);
							gclass9_0.method_20(SettingsTool.GetSettings("configGeneral").method_0("tocDoGoVanBan"), 4, "[name=\"body\"]", text, 0.1);
							method_68();
						}
						num4 = gclass9_0.method_26(5.0, "[name=\"Send\"]", "[name=\"send\"]");
						if (num4 == 1)
						{
							gclass9_0.method_14(4, "[name=\"Send\"]");
						}
						else
						{
							gclass9_0.method_14(4, "[name=\"send\"]");
						}
						method_68();
						num++;
						SetStatusAccount(int_1, ED13F338 + Language.GetValue("Đang") + $" {string_0} ({num}/{num5})...");
						if (gclass9_0.B2277F30())
						{
							return -2;
						}
						gclass9_0.C2B42BB6(random_1.Next(int_5, int_6 + 1));
						if (bool_6 && EF95B8A3 == 1)
						{
							do
							{
								gclass9_0.D920192A("https://m.facebook.com/" + text3);
								gclass9_0.C2B42BB6(2.0);
								num4 = method_63(gclass9_0, a9364E, string_3, string_4);
							}
							while (num4 == 1);
							if (new List<int> { -3, -2, -1, 2 }.Contains(num4))
							{
								return -1;
							}
							string text6 = gclass9_0.F4AF93AB("return document.documentElement.innerHTML.match(new RegExp('<title>(.*?)</title>'))[1]").ToString();
							text6 = text6.Split('-')[0].Trim();
							int num10 = 0;
							int num11 = 0;
							if (gclass9_0.method_24($"document.querySelectorAll('[data-store*=\"linkdata\"]')[{0}]") == 1)
							{
								num10 = 0;
								if (Convert.ToBoolean(gclass9_0.F4AF93AB($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{num11}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')!=null)+''")) || Convert.ToBoolean(gclass9_0.F4AF93AB($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{num11}].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]')!=null)+''")) || Convert.ToBoolean(gclass9_0.F4AF93AB($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{num11}].querySelector('[data-sigil=\"share-popup\"]')!=null)+''")))
								{
									num10++;
								}
								if (gclass9_0.B2277F30())
								{
									return -2;
								}
								gclass9_0.method_27("document.querySelectorAll('[data-store*=\"linkdata\"]')[" + num11 + "]");
								method_68(3);
								if (bool_7 && Convert.ToBoolean(gclass9_0.F4AF93AB($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{num11}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')!=null)+''")))
								{
									gclass9_0.method_27("document.querySelectorAll('[data-store*=\"linkdata\"]')[" + num11 + "].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a')");
									num10++;
									if (Convert.ToBoolean(gclass9_0.F4AF93AB($"var output='false';var x=document.querySelectorAll('[data-store*=\"linkdata\"]')[{num11}].querySelector('[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a');  if(x!=null) output=(JSON.parse(x.getAttribute('data-store')).reaction==0)+''; return output;").ToString()))
									{
										method_68();
										gclass9_0.method_14(4, "[data-store*=\"linkdata\"]", num11, 4, "[data-store*=\"linkdata\"]>footer>div>div:nth-child(2)>div:nth-child(1)>a");
										method_68();
									}
								}
								if (A8228734 && Convert.ToBoolean(gclass9_0.F4AF93AB($"return (document.querySelectorAll('[data-store*=\"linkdata\"]')[{num11}].querySelector('[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]')!=null)+''")))
								{
									num10++;
									gclass9_0.method_14(4, "[data-store*=\"linkdata\"]", num11, 4, "[data-sigil=\"feed-ufi-focus feed-ufi-trigger ufiCommentLink mufi-composer-focus\"]");
									method_68();
									if (gclass9_0.C6B3E9B0("[data-sigil=\"textarea mufi-composer m-textarea-input\"]", 5.0) == 1)
									{
										method_68();
										gclass9_0.method_27("document.querySelector('[data-sigil =\"textarea mufi-composer m-textarea-input\"]')");
										method_68();
										List<string> list5 = new List<string>();
										if (list5.Count == 0)
										{
											list5 = EE98FB8B(DD22EDA6);
										}
										string text7 = list5[random_1.Next(0, list5.Count)];
										list5.Remove(text7);
										text7 = Common.SpinText(text7);
										text7 = text7.Replace("[u]", text6);
										gclass9_0.method_19(4, "[data-sigil =\"textarea mufi-composer m-textarea-input\"]", text7 + " ", 0.1);
										method_68(3);
										for (int l = 0; l < 10; l++)
										{
											if (gclass9_0.method_14(2, "submit") == 1)
											{
												break;
											}
											Common.DelayTime(1.0);
										}
										method_68(2);
									}
									gclass9_0.method_11();
									method_68();
								}
							}
						}
					}
					num6++;
					continue;
				}
				return -1;
			}
		}
		catch
		{
			num = -1;
		}
		return num;
	}

	public int C01C09B4(int int_1, string string_0, Chrome CFA5D30D, int BE84243B, int int_2, List<string> list_13, int int_3, int int_4, Random random_1, string string_1 = "")
	{
		string a9364E = method_117(int_1, "cUid");
		string string_2 = method_117(int_1, "cPassword");
		string string_3 = method_117(int_1, "cFa2");
		int num = 0;
		try
		{
			List<string> list = new List<string>();
			list = EE98FB8B(list_13);
			string text = "";
			int num2 = random_1.Next(BE84243B, int_2 + 1);
			if (num2 != 0)
			{
				while (true)
				{
					if (GClass12.EB82CE09(CFA5D30D) != -2)
					{
						int num3 = method_63(CFA5D30D, a9364E, string_2, string_3);
						if (num3 == 1)
						{
							continue;
						}
						if (!new List<int> { -3, -2, -1, 2 }.Contains(num3))
						{
							GClass12.smethod_13(CFA5D30D);
							while (true)
							{
								num3 = method_63(CFA5D30D, a9364E, string_2, string_3);
								if (num3 == 1)
								{
									break;
								}
								if (new List<int> { -3, -2, -1, 2 }.Contains(num3))
								{
									return -1;
								}
								int num4 = CFA5D30D.DE832319("[data-sigil=\"undoable-action\"]");
								if (num4 > 0)
								{
									int int_5 = Base.rd.Next(0, num4);
									CFA5D30D.method_27("document.querySelectorAll('[data-sigil=\"undoable-action\"]>div:nth-child(1)>a')[" + int_5 + "]");
									method_68();
									CFA5D30D.method_14(4, "[data-sigil=\"undoable-action\"]>div:nth-child(1)>a", int_5);
									method_68(2);
									if (CFA5D30D.C6B3E9B0("[data-sigil=\"hq-profile-logging-action-bar-button\"]>a", 3.0) == 1)
									{
										GClass12.smethod_13(CFA5D30D);
										CFA5D30D.method_27("document.querySelector('[data-sigil=\"hq-profile-logging-action-bar-button\"]>a')");
										method_68();
										CFA5D30D.method_14(4, "[data-sigil=\"hq-profile-logging-action-bar-button\"]>a");
										method_68(2);
										if (CFA5D30D.C6B3E9B0("[name=\"body\"]", 5.0) != 1)
										{
											goto IL_0388;
										}
										if (list.Count == 0)
										{
											list = EE98FB8B(list_13);
										}
										text = list[random_1.Next(0, list.Count)];
										list.Remove(text);
										text = Common.SpinText(text);
										string newValue = CFA5D30D.F4AF93AB("return document.querySelector('[data-sigil=\" token\"]').innerText.replace('×','').trim()").ToString();
										text = text.Replace("[u]", newValue);
										method_68();
										switch (SettingsTool.GetSettings("configGeneral").method_0("tocDoGoVanBan"))
										{
										case 0:
											CFA5D30D.B0381A81(Base.rd, 4, "[name=\"body\"]", text, 0.1);
											break;
										case 1:
											CFA5D30D.method_19(4, "[name=\"body\"]", text, 0.1);
											break;
										case 2:
											CFA5D30D.method_17(4, "[name=\"body\"]", text);
											break;
										}
										method_68();
										num3 = CFA5D30D.method_26(5.0, "[name=\"Send\"]", "[name=\"send\"]");
										if (num3 == 1)
										{
											CFA5D30D.method_14(4, "[name=\"Send\"]");
										}
										else
										{
											CFA5D30D.method_14(4, "[name=\"send\"]");
										}
										method_68();
										num++;
										SetStatusAccount(int_1, string_0 + Language.GetValue("Đang") + $" {string_1} ({num}/{num2})...");
										if (CFA5D30D.B2277F30())
										{
											return -2;
										}
										CFA5D30D.C2B42BB6(random_1.Next(int_3, int_4 + 1));
										if (num < num2)
										{
											goto IL_0388;
										}
									}
								}
								goto end_IL_0029;
								IL_0388:
								CFA5D30D.method_11();
								CFA5D30D.method_21();
								CFA5D30D.method_11();
								CFA5D30D.method_21();
								if (CFA5D30D.C6B3E9B0("[data-sigil=\"undoable-action\"]") != 1)
								{
									CFA5D30D.method_11();
									CFA5D30D.method_21();
									if (CFA5D30D.C6B3E9B0("[data-sigil=\"undoable-action\"]") != 1)
									{
										break;
									}
								}
							}
							continue;
						}
						return -1;
					}
					return -2;
				}
			}
			end_IL_0029:;
		}
		catch
		{
			num = -1;
		}
		return num;
	}

	public int D43D5825(int E0806134, string string_0, Chrome gclass9_0, string string_1, string string_2, int int_1, int E23C8611, List<string> list_13, int int_2, int int_3, string D60BCE1D, int BCBDCB02, Random D5B08F8F, string EBBB9EAF = "", int D08EA437 = 0, List<string> list_14 = null)
	{
		string a9364E = method_117(E0806134, "cUid");
		string string_3 = method_117(E0806134, "cPassword");
		string string_4 = method_117(E0806134, "cFa2");
		int result = 0;
		try
		{
			List<string> list = new List<string>();
			if (D08EA437 == 0)
			{
				C01C09B4(E0806134, string_0, gclass9_0, int_1, E23C8611, list_13, int_2, int_3, D5B08F8F, EBBB9EAF);
			}
			else
			{
				list = EE98FB8B(list_14);
				List<string> list2 = new List<string>();
				list2 = EE98FB8B(list_13);
				string text = "";
				string text2 = "";
				int count = list.Count;
				int num = 0;
				int num2 = D5B08F8F.Next(int_1, E23C8611 + 1);
				for (int i = 0; i < count; i++)
				{
					if (num == num2)
					{
						break;
					}
					num++;
					if (list2.Count == 0)
					{
						list2 = EE98FB8B(list_13);
					}
					text = list2[D5B08F8F.Next(0, list2.Count)];
					text2 = list[D5B08F8F.Next(0, list.Count)];
					list.Remove(text2);
					list2.Remove(text);
					text = Common.SpinText(text);
					int num3;
					do
					{
						gclass9_0.D920192A("https://m.facebook.com/messages/read/?fbid=" + text2);
						method_68(2);
						num3 = method_63(gclass9_0, a9364E, string_3, string_4);
					}
					while (num3 == 1);
					if (!new List<int> { -3, -2, -1, 2 }.Contains(num3))
					{
						if (gclass9_0.C6B3E9B0("[name=\"body\"]", 5.0) == 1)
						{
							method_68();
							gclass9_0.method_20(SettingsTool.GetSettings("configGeneral").method_0("tocDoGoVanBan"), 4, "[name=\"body\"]", text, 0.1);
							method_68();
							num3 = gclass9_0.method_26(5.0, "[name=\"Send\"]", "[name=\"send\"]");
							if (num3 == 1)
							{
								gclass9_0.method_14(4, "[name=\"Send\"]");
							}
							else
							{
								gclass9_0.method_14(4, "[name=\"send\"]");
							}
							method_68();
							if (EBBB9EAF == "")
							{
								SetStatusAccount(E0806134, string_0 + Language.GetValue("Đang nhắn tin bạn bè") + $" ({num}/{num2})...");
							}
							else
							{
								SetStatusAccount(E0806134, string_0 + Language.GetValue("Đang") + $" {EBBB9EAF} ({num}/{num2})...");
							}
							gclass9_0.C2B42BB6(D5B08F8F.Next(int_2, int_3 + 1));
						}
						continue;
					}
					return -1;
				}
			}
		}
		catch
		{
			result = -1;
		}
		return result;
	}

	public int ED962E15(int DD88D231, string string_0, Chrome gclass9_0, int C1BB3C89, int E30FF0BC, int int_1, int int_2, Random random_1, string string_1 = "")
	{
		string a9364E = method_117(DD88D231, "cUid");
		string string_2 = method_117(DD88D231, "cPassword");
		string string_3 = method_117(DD88D231, "cFa2");
		int num = 0;
		int num2 = 0;
		try
		{
			while (true)
			{
				IL_01cd:
				if (GClass12.smethod_12(gclass9_0) != -2)
				{
					int num3 = method_63(gclass9_0, a9364E, string_2, string_3);
					if (num3 == 1)
					{
						continue;
					}
					if (!new List<int> { -3, -2, -1, 2 }.Contains(num3))
					{
						int num4 = random_1.Next(C1BB3C89, E30FF0BC + 1);
						while (num < num4)
						{
							num3 = method_63(gclass9_0, a9364E, string_2, string_3);
							if (num3 != 1)
							{
								if (!new List<int> { -3, -2, -1, 2 }.Contains(num3))
								{
									if (gclass9_0.C6B3E9B0("[data-sigil=\"touchable ajaxify\"]", 5.0) == 1)
									{
										num2 = 0;
										gclass9_0.method_27("document.querySelector('[data-sigil=\"touchable ajaxify\"]')");
										method_68();
										gclass9_0.method_14(4, "[data-sigil=\"touchable ajaxify\"]");
										num++;
										method_68(2);
										if (string_1 == "")
										{
											SetStatusAccount(DD88D231, string_0 + Language.GetValue("Đang chọc bạn bè") + $" ({num}/{num4})...");
										}
										else
										{
											SetStatusAccount(DD88D231, string_0 + Language.GetValue("Đang") + $" {string_1} ({num}/{num4})...");
										}
										gclass9_0.C2B42BB6(random_1.Next(int_1, int_2 + 1));
									}
									else
									{
										gclass9_0.method_10();
										num2++;
										if (num2 == 2)
										{
											break;
										}
									}
									continue;
								}
								return -1;
							}
							goto IL_01cd;
						}
						break;
					}
					return -1;
				}
				return -2;
			}
		}
		catch
		{
			num = -1;
		}
		return num;
	}

	private int B4999E85(int F43F9832, string A63C699E, AC28BD29 ac28BD29_0, JSON_Settings f72FAFBC_0, string FC248E9D, string string_0)
	{
		int f988D70A = f72FAFBC_0.method_0("nudSoLuongFrom");
		int e234B = f72FAFBC_0.method_0("nudSoLuongTo");
		int minValue = f72FAFBC_0.method_0("nudDelayFrom");
		int num = f72FAFBC_0.method_0("nudDelayTo");
		bool flag = f72FAFBC_0.AA824D29("ckbTuongTac");
		int int_ = f72FAFBC_0.method_0("nudTimeFrom");
		int int_2 = f72FAFBC_0.method_0("nudTimeTo");
		bool bool_ = f72FAFBC_0.AA824D29("ckbTuongTacLike");
		int int_3 = f72FAFBC_0.method_0("nudCountLikeFrom");
		int int_4 = f72FAFBC_0.method_0("nudCountLikeTo");
		bool bool_2 = f72FAFBC_0.AA824D29("ckbTuongTacComment");
		List<string> list_ = f72FAFBC_0.EC378D8A("txtComment");
		int int_5 = f72FAFBC_0.method_0("nudCountCommentFrom");
		int int_6 = f72FAFBC_0.method_0("nudCountCommentTo");
		bool flag2 = f72FAFBC_0.AA824D29("ckbTuDongXoaUid");
		int result = 0;
		int num2 = ac28BD29_0.C4B7B817(f988D70A, e234B);
		string text = "";
		List<string> list = new List<string>();
		if (!flag2)
		{
			list = Common.smethod_11(dictionary_1[FC248E9D]);
		}
		try
		{
			string text2 = A63C699E + Language.GetValue("Đang") + " " + string_0 + ": ";
			int num3 = 0;
			int num4 = 0;
			int num5 = 3;
			int num6 = 0;
			while (num6 < num2 + 10)
			{
				if (!flag2)
				{
					if (list.Count != 0)
					{
						text = list[random_0.Next(0, list.Count)];
						list.Remove(text);
						goto IL_021e;
					}
					break;
				}
				lock (dictionary_1)
				{
					if (dictionary_1[FC248E9D].Count == 0)
					{
						break;
					}
					text = dictionary_1[FC248E9D][random_0.Next(0, dictionary_1[FC248E9D].Count)];
					dictionary_1[FC248E9D].Remove(text);
					goto IL_021e;
				}
				IL_021e:
				bool flag3 = false;
				while (true)
				{
					SetStatusAccount(F43F9832, text2 + $"({num3}/{num2}), Go to Profile {text}...");
					if (!FA905AA0(ac28BD29_0, F43F9832, text2, "fb://profile/" + text))
					{
						break;
					}
					int num7 = 0;
					int num8 = 6;
					string text3 = "";
					int tickCount = Environment.TickCount;
					while (true)
					{
						text3 = ac28BD29_0.GetPageSource();
						string text4 = ac28BD29_0.FindElement(0, text3, new List<string> { "//android.widget.ProgressBar", "//*[@text='Tap to retry']", "//*[@content-desc='Reload page']", "//*[@content-desc='Add Friend']", "//*[@text='Does this person know you?']", "//*[@content-desc='Requested']", "//*[@content-desc='Respond']", "//*[@content-desc='Friends']", "//*[@text='Your friend request is on the way!']", "//*[@content-desc='More']" });
						string text5 = text4;
						string text6 = text5;
						uint num9 = HashString.DA8CEBAB(text6);
						if (num9 > 1601492691)
						{
							if (num9 > 2271211187u)
							{
								if (num9 != 2497527736u)
								{
									if (num9 != 2820186270u)
									{
										if (num9 == 3367448010u && text6 == "//*[@text='Does this person know you?']")
										{
											text4 = "//*[@text='CONFIRM']";
											SetStatusAccount(F43F9832, text2 + $"({num3}/{num2}), " + "Tap " + ac28BD29_0.method_105(text4) + "...");
											ac28BD29_0.TapByXPath(text4, text3);
											goto IL_0526;
										}
									}
									else if (text6 == "//*[@content-desc='Respond']")
									{
										goto IL_0820;
									}
								}
								else if (text6 == "//*[@content-desc='Add Friend']")
								{
									if (!flag)
									{
										SetStatusAccount(F43F9832, text2 + $"({num3}/{num2}), " + "Tap " + ac28BD29_0.method_105(text4) + "...");
										ac28BD29_0.TapByXPath(text4, text3);
										flag3 = true;
										goto IL_0526;
									}
									goto IL_0774;
								}
								goto IL_03d4;
							}
							if (num9 != 1804624556)
							{
								if (num9 != 2271211187u || !(text6 == "//*[@content-desc='Reload page']"))
								{
									goto IL_03d4;
								}
								if (num7 >= num8)
								{
									goto IL_0820;
								}
								num7++;
								SetStatusAccount(F43F9832, text2 + $"({num3}/{num2}), " + "Tap " + ac28BD29_0.method_105(text4) + "...");
								ac28BD29_0.TapByXPath(text4, text3);
							}
							else
							{
								if (!(text6 == "//*[@content-desc='More']"))
								{
									goto IL_03d4;
								}
								ac28BD29_0.TapByXPath(text4, text3);
							}
						}
						else
						{
							if (num9 > 532719482)
							{
								if (num9 != 641677479)
								{
									if (num9 != 1346668722)
									{
										if (num9 == 1601492691 && text6 == "//*[@text='Your friend request is on the way!']")
										{
											text4 = "//*[@content-desc='Close']";
											SetStatusAccount(F43F9832, text2 + $"({num3}/{num2}), " + "Tap " + ac28BD29_0.method_105(text4) + "...");
											ac28BD29_0.TapByXPath(text4, text3);
											goto IL_0526;
										}
									}
									else if (text6 == "//*[@content-desc='Friends']")
									{
										goto IL_0820;
									}
								}
								else if (text6 == "//*[@content-desc='Requested']")
								{
									goto IL_0820;
								}
								goto IL_03d4;
							}
							if (num9 != 281629319)
							{
								if (num9 != 532719482 || !(text6 == "//android.widget.ProgressBar"))
								{
									goto IL_03d4;
								}
								SetStatusAccount(F43F9832, text2 + $"({num3}/{num2}), " + "Loading...");
							}
							else
							{
								if (!(text6 == "//*[@text='Tap to retry']"))
								{
									goto IL_03d4;
								}
								if (num7 >= num8)
								{
									break;
								}
								num7++;
								ac28BD29_0.CE16082B(-1);
							}
						}
						goto IL_0526;
						IL_0526:
						ac28BD29_0.TimeDelay(2.0);
						if (Environment.TickCount - tickCount < 45000)
						{
							continue;
						}
						goto IL_0820;
						IL_03d4:
						Bitmap f608D = ac28BD29_0.method_87();
						if (ac28BD29_0.method_84("dataimage\\addfriend", f608D))
						{
							SetStatusAccount(F43F9832, text2 + $"({num3}/{num2}), " + "Tap " + ac28BD29_0.method_105(text4) + "...");
							ac28BD29_0.BD33F0BA("dataimage\\addfriend", f608D);
							flag3 = true;
						}
						else
						{
							if (ac28BD29_0.method_84("dataimage\\requested", f608D) || ac28BD29_0.ED9CDB24(text3, "There was a problem sending your friend request. Please try again later"))
							{
								goto IL_0820;
							}
							SetStatusAccount(F43F9832, text2 + text2 + $"({num3}/{num2}), " + "Scroll...");
							if (ac28BD29_0.CE16082B())
							{
								goto IL_075c;
							}
						}
						goto IL_0526;
					}
					break;
					IL_0820:
					if (flag3)
					{
						num3++;
						if (num3 >= num2)
						{
							break;
						}
						SetStatusAccount(F43F9832, text2 + $"({num3}/{num2}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue, num + 1));
						num4 = 0;
					}
					else
					{
						num4++;
						if (num4 >= num5)
						{
							break;
						}
					}
					num6++;
					goto IL_0895;
					IL_0774:
					method_72(F43F9832, text2 + $"({num3}/{num2}), ", ac28BD29_0, int_, int_2, bool_, "0124", int_3, int_4, bool_2, int_5, int_6, list_, bool_6: false, 0, 0);
					flag = false;
					tickCount = Environment.TickCount;
					continue;
					IL_075c:
					switch (method_22(ac28BD29_0, F43F9832, text2))
					{
					case 1:
						continue;
					case 0:
						break;
					default:
						goto end_IL_0114;
					}
					goto IL_0820;
				}
				break;
				IL_0895:;
			}
			end_IL_0114:;
		}
		catch
		{
		}
		return result;
	}

	private int E33C0EA8(int int_1, string string_0, AC28BD29 ac28BD29_0, JSON_Settings B888380D, string string_1, string string_2)
	{
		int f988D70A = B888380D.method_0("nudSoLuongFrom");
		int e234B = B888380D.method_0("nudSoLuongTo");
		int minValue = B888380D.method_0("nudDelayFrom");
		int num = B888380D.method_0("nudDelayTo");
		bool flag = B888380D.AA824D29("ckbTuDongTraLoiCauHoi");
		List<string> list = B888380D.EC378D8A("txtCauTraLoi");
		bool flag2 = B888380D.AA824D29("ckbTuDongXoaUid");
		int num2 = 0;
		int num3 = ac28BD29_0.C4B7B817(f988D70A, e234B);
		string text = "";
		List<string> list2 = new List<string>();
		if (!flag2)
		{
			list2 = Common.smethod_11(dictionary_0[string_1]);
		}
		try
		{
			string text2 = string_0 + Language.GetValue("Đang") + " " + string_2 + ": ";
			for (int num4 = 0; num4 < num3 + 10; num4++)
			{
				if (!flag2)
				{
					if (list2.Count != 0)
					{
						text = list2.smethod_8();
						list2.Remove(text);
						goto IL_0169;
					}
					break;
				}
				lock (dictionary_0)
				{
					if (dictionary_0[string_1].Count == 0)
					{
						break;
					}
					text = dictionary_0[string_1].smethod_8();
					dictionary_0[string_1].Remove(text);
					goto IL_0169;
				}
				IL_0169:
				JSON_Settings f72FAFBC = new JSON_Settings();
				f72FAFBC.GetValue("id", (object)text);
				f72FAFBC.GetValue("isAnswer", flag);
				f72FAFBC.method_3("lstCauTraLoi", list);
				if (method_28(int_1, string_0 + Language.GetValue("Đang") + $" {string_2}: ({num2}/{num3}), ", ac28BD29_0, f72FAFBC).isSuccess)
				{
					num2++;
					if (num2 >= num3)
					{
						SetStatusAccount(int_1, text2 + $"({num2}/{num3}), Done!");
						break;
					}
					SetStatusAccount(int_1, text2 + $"({num2}/{num3}), " + Language.GetValue("đợi") + " {time}s...", Base.rd.Next(minValue, num + 1));
				}
			}
		}
		catch
		{
		}
		return num2;
	}

	private void method_86(int int_1, string string_0, AC28BD29 ac28BD29_0, List<string> list_13)
	{
		string text = "";
		bool flag = false;
		int num = 0;
		while (true)
		{
			if (num >= 10)
			{
				return;
			}
			text = "";
			SetStatusAccount(int_1, string_0 + "Find EditText...");
			List<string> list = ac28BD29_0.FindElements(0, text, "//android.widget.EditText[@text=\"Write your answer...\"]");
			if (list.Count > 0)
			{
				SetStatusAccount(int_1, string_0 + Language.GetValue("Nhập dữ liệu..."));
				for (int i = 0; i < list.Count; i++)
				{
					ac28BD29_0.SendByXPath("(//android.widget.EditText[@text=\"Write your answer...\"])[1]", list_13.smethod_8());
					ac28BD29_0.method_54(1.0, 1.5);
				}
			}
			text = "";
			SetStatusAccount(int_1, string_0 + "Find checkbox...");
			List<string> list2 = ac28BD29_0.method_26(0, ref text, "//android.view.ViewGroup[@content-desc=\"You can choose multiple options\"]/parent::*/child::*");
			if (list2.Count > 0)
			{
				SetStatusAccount(int_1, string_0 + "Check checkbox...");
				foreach (string item in list2)
				{
					ac28BD29_0.E832B991(item);
				}
			}
			text = "";
			SetStatusAccount(int_1, string_0 + "Find radio...");
			list2 = ac28BD29_0.method_26(0, ref text, "//android.view.ViewGroup[@content-desc=\"You can choose one option\"]/parent::*/child::*");
			if (list2.Count > 0)
			{
				SetStatusAccount(int_1, string_0 + "Check radio...");
				foreach (string item2 in list2)
				{
					ac28BD29_0.E832B991(item2);
				}
			}
			if (!flag)
			{
				text = "";
				SetStatusAccount(int_1, string_0 + "Find Agree...");
				list2 = ac28BD29_0.method_26(0, ref text, "//android.view.ViewGroup[starts-with(@content-desc,\"I agree to the group rules\")]");
				if (list2.Count > 0)
				{
					flag = true;
					SetStatusAccount(int_1, string_0 + "Check Agree...");
					foreach (string item3 in list2)
					{
						ac28BD29_0.E832B991(item3);
					}
				}
			}
			SetStatusAccount(int_1, string_0 + "Scroll...");
			if (ac28BD29_0.CE16082B())
			{
				break;
			}
			num++;
		}
		SetStatusAccount(int_1, string_0 + "Tap Submit...");
		if (ac28BD29_0.method_40(0, "//android.view.ViewGroup[@content-desc='Submit'][@clickable='true']", ""))
		{
			ac28BD29_0.EE294CB1(10.0, "//android.view.ViewGroup[@content-desc='Submit'][@clickable='true']");
		}
	}

	private void C729EC0F()
	{
		try
		{
			dtgvAcc.Invoke((MethodInvoker)delegate
			{
				foreach (DataGridViewColumn column in dtgvAcc.Columns)
				{
					column.SortMode = DataGridViewColumnSortMode.NotSortable;
				}
			});
		}
		catch (Exception)
		{
		}
	}

	private void method_87()
	{
		try
		{
			dtgvAcc.Invoke((MethodInvoker)delegate
			{
				foreach (DataGridViewColumn column in dtgvAcc.Columns)
				{
					column.SortMode = DataGridViewColumnSortMode.Automatic;
				}
			});
		}
		catch
		{
		}
	}

	private void method_88(string BABEFEA0)
	{
		Invoke((MethodInvoker)delegate
		{
			try
			{
				if (BABEFEA0 == "start")
				{
					btnInteract.Enabled = false;
					plQuanLyThuMuc.Enabled = false;
					btnPause.Enabled = true;
					C729EC0F();
				}
				else if (BABEFEA0 == "stop")
				{
					method_2(0);
					btnPause.Text = Language.GetValue("Dừng Tương Tác");
					btnInteract.Enabled = true;
					plQuanLyThuMuc.Enabled = true;
					btnPause.Enabled = false;
					method_87();
				}
			}
			catch (Exception)
			{
			}
		});
	}

	private void C63DC381(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex > -1)
		{
			try
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
				BA332092();
			}
			catch
			{
			}
		}
	}

	private void A3853A30(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			method_7("ToggleCheck");
		}
	}

	private void E7007020(string string_0)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(method_117(i, "cChose")))
				{
					list.Add(method_117(i, "cId"));
				}
			}
			if (list.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng cho\u0323n ta\u0300i khoa\u0309n câ\u0300n câ\u0323p nhâ\u0323t!"), 3);
			}
			else
			{
				Common.smethod_16(new fUpdateData(this, string_0));
			}
		}
		catch
		{
		}
	}

	private void DE1E0400(object sender, EventArgs e)
	{
		E7007020("Password");
	}

	private void tokenToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		E7007020("Token");
	}

	private void cookieToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		E7007020("Cookie");
	}

	private void toolStripMenuItem_10_Click(object sender, EventArgs e)
	{
		E7007020("Mail|pass");
	}

	private void A2A77B30(object sender, EventArgs e)
	{
		E7007020("2FA");
	}

	private void AB9C0B0B(object sender, EventArgs e)
	{
		try
		{
			if (bool_0)
			{
				if (MessageBoxHelper.smethod_1("Bạn có muốn phần mềm dừng ngay lập tức?") == DialogResult.Yes)
				{
					btnPause.Enabled = false;
					Thread thread = new Thread((ThreadStart)delegate
					{
						method_19();
					});
					thread.IsBackground = true;
					thread.Start();
				}
			}
			else
			{
				bool_0 = true;
				btnPause.Text = Language.GetValue("Đang dư\u0300ng...");
			}
		}
		catch
		{
		}
	}

	private void toolStripMenuItem_6_Click(object sender, EventArgs e)
	{
		FA986092(null, null);
	}

	private void btnDeleteFile_Click(object sender, EventArgs e)
	{
		int selectedIndex = cbbThuMuc.SelectedIndex;
		if (MessageBoxHelper.smethod_1(string.Format(Language.GetValue("Bạn có thực sự muốn xóa thư mục [{0}] không?"), cbbThuMuc.Text)) == DialogResult.Yes)
		{
			if (CommonSQL.BB39031A(cbbThuMuc.SelectedValue.ToString()))
			{
				MessageBoxHelper.Show(string.Format(Language.GetValue("Xoá thành công thư mục [{0}] !"), cbbThuMuc.Text));
				method_4();
				cbbThuMuc.SelectedIndex = selectedIndex - 1;
			}
			else
			{
				MessageBoxHelper.Show(string.Format(Language.GetValue("Không thể xóa thư mục [{0}] !"), cbbThuMuc.Text), 2);
			}
		}
	}

	private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!E7A6A48F || cbbThuMuc.SelectedValue == null || !GClass6.B62D3203(cbbThuMuc.SelectedValue.ToString()) || (cbbThuMuc.SelectedValue.ToString() != "999999" && int_0 == cbbThuMuc.SelectedIndex))
		{
			return;
		}
		string text = cbbThuMuc.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-1"))
		{
			if (!(text2 == "999999"))
			{
				DE81740C(method_5());
			}
			else
			{
				Common.smethod_16(new fChonThuMuc());
				if (!fChonThuMuc.bool_1 || fChonThuMuc.list_0 == null || fChonThuMuc.list_0.Count == 0)
				{
					E7A6A48F = false;
					cbbThuMuc.SelectedIndex = ((int_0 != -1) ? int_0 : 0);
					E7A6A48F = true;
				}
				else
				{
					DE81740C(fChonThuMuc.list_0);
				}
			}
		}
		else
		{
			DE81740C();
		}
		int_0 = cbbThuMuc.SelectedIndex;
		if (cbbThuMuc.SelectedValue != null)
		{
			string text3 = cbbThuMuc.SelectedValue.ToString();
			if (text3 == "-1" || text3 == "999999")
			{
				btnDeleteFile.BackColor = Color.Gray;
				btnDeleteFile.Enabled = false;
				btnEditFile.BackColor = Color.Gray;
				btnEditFile.Enabled = false;
			}
			else
			{
				btnDeleteFile.BackColor = Color.White;
				btnDeleteFile.Enabled = true;
				btnEditFile.BackColor = Color.White;
				btnEditFile.Enabled = true;
			}
		}
	}

	private void CC90C615(object sender, EventArgs e)
	{
		method_9("cEmail|cPassMail");
	}

	private void FB980FA5_Click(object sender, EventArgs e)
	{
		method_9("cUid|cPassword|cToken|cCookies|cEmail|cPassMail");
	}

	private void method_89()
	{
		try
		{
			lblCountTotal.Text = dtgvAcc.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void BA332092(int D4B39B81 = -1)
	{
		if (D4B39B81 == -1)
		{
			D4B39B81 = 0;
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					D4B39B81++;
				}
			}
		}
		lblCountSelect.Text = D4B39B81.ToString();
	}

	private void method_90(int int_1)
	{
		int int_2 = 0;
		int E7373E94 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		string string_0 = SettingsTool.GetSettings("configGeneral").GetValue("token");
		bool_0 = false;
		Thread thread = new Thread((ThreadStart)delegate
		{
			method_88("start");
			switch (int_1)
			{
			case 0:
			{
				int num4 = 0;
				while (num4 < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num4].Cells["cChose"].Value))
					{
						if (int_2 < E7373E94)
						{
							Interlocked.Increment(ref int_2);
							int int_5 = num4++;
							Thread thread5 = new Thread((ThreadStart)delegate
							{
								SetStatusAccount(int_5, Language.GetValue("Đang kiểm tra..."));
								method_92(int_5, string_0);
								Interlocked.Decrement(ref int_2);
							});
							thread5.IsBackground = true;
							thread5.Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num4++;
					}
				}
				break;
			}
			case 1:
			{
				int num6 = 0;
				while (num6 < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num6].Cells["cChose"].Value))
					{
						if (int_2 < E7373E94)
						{
							Interlocked.Increment(ref int_2);
							int int_3 = num6++;
							Thread thread7 = new Thread((ThreadStart)delegate
							{
								SetStatusAccount(int_3, Language.GetValue("Đang kiểm tra..."));
								A92ABF10(int_3);
								Interlocked.Decrement(ref int_2);
							});
							thread7.IsBackground = true;
							thread7.Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num6++;
					}
				}
				break;
			}
			case 2:
			{
				int num2 = 0;
				while (num2 < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						if (int_2 < E7373E94)
						{
							Interlocked.Increment(ref int_2);
							int int_6 = num2++;
							Thread thread3 = new Thread((ThreadStart)delegate
							{
								SetStatusAccount(int_6, Language.GetValue("Đang kiểm tra..."));
								method_93(int_6);
								Interlocked.Decrement(ref int_2);
							});
							thread3.IsBackground = true;
							thread3.Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num2++;
					}
				}
				break;
			}
			case 3:
			{
				int num5 = 0;
				while (num5 < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num5].Cells["cChose"].Value))
					{
						if (int_2 < E7373E94)
						{
							Interlocked.Increment(ref int_2);
							int int_4 = num5++;
							Thread thread6 = new Thread((ThreadStart)delegate
							{
								SetStatusAccount(int_4, Language.GetValue("Đang kiểm tra..."));
								BF071EB2(int_4);
								Interlocked.Decrement(ref int_2);
							});
							thread6.IsBackground = true;
							thread6.Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num5++;
					}
				}
				break;
			}
			case 4:
			{
				int num3 = 0;
				while (num3 < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num3].Cells["cChose"].Value))
					{
						if (int_2 < E7373E94)
						{
							Interlocked.Increment(ref int_2);
							int E1241321 = num3++;
							Thread thread4 = new Thread((ThreadStart)delegate
							{
								SetStatusAccount(E1241321, Language.GetValue("Đang kiểm tra..."));
								F82A8C21(E1241321);
								Interlocked.Decrement(ref int_2);
							});
							thread4.IsBackground = true;
							thread4.Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num3++;
					}
				}
				break;
			}
			case 5:
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (int_2 < E7373E94)
						{
							Interlocked.Increment(ref int_2);
							int int_7 = num++;
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								SetStatusAccount(int_7, Language.GetValue("Đang kiểm tra..."));
								method_91(int_7);
								Interlocked.Decrement(ref int_2);
							});
							thread2.IsBackground = true;
							thread2.Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
				break;
			}
			}
			int tickCount = Environment.TickCount;
			while (int_2 > 0 && Environment.TickCount - tickCount <= 60000)
			{
				Common.DelayTime(1.0);
			}
			method_88("stop");
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_91(int row)
	{
		try
		{
			string string_ = method_117(row, "cId");
			string uid = method_117(row, "cUid");
			if (!method_16(uid))
			{
				SetStatusAccount(row, Language.GetValue("Uid không hợp lệ!"));
				return;
			}
			string text = "";
			string text2 = PhoneFarmLib.Common.CheckInfoUid(uid);
			if (text2.StartsWith("0|"))
			{
				if (EA98BF20.CheckLiveWall(uid).StartsWith("0|"))
				{
					SetStatusAccount(row, Language.GetValue("Tài khoản Die!"));
					CC1905A5(row, "Die");
				}
				else
				{
					SetStatusAccount(row, Language.GetValue("Không check đươ\u0323c!"));
				}
			}
			else if (text2.StartsWith("1|"))
			{
				string[] array = text2.Split('|');
				string text3 = array[1];
				string text4 = array[2];
				string text5 = array[3];
				CommonSQL.smethod_9(string_, "name|friends|dateCreateAcc", text3 + "|" + text4 + "|" + text5);
				SetCellAccount(row, "cName", text3);
				SetCellAccount(row, "cFriend", text4);
				SetCellAccount(row, "cdateCreateAcc", text5);
				CC1905A5(row, "Live");
				text = Language.GetValue("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
				SetStatusAccount(row, text);
			}
			else
			{
				SetStatusAccount(row, Language.GetValue("Không check đươ\u0323c!"));
			}
		}
		catch
		{
			SetStatusAccount(row, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void F82A8C21(int int_1)
	{
		try
		{
			string text = "";
			string text2 = "";
			text = dtgvAcc.Rows[int_1].Cells["cEmail"].Value.ToString();
			text2 = dtgvAcc.Rows[int_1].Cells["cPassMail"].Value.ToString();
			if (text == "" || text2 == "")
			{
				SetStatusAccount(int_1, Language.GetValue("Không tìm thấy mail!"));
			}
			else if (ImapHelper.CheckConnectImap(text, text2))
			{
				SetStatusAccount(int_1, Language.GetValue("Tài khoản mail: live!"));
			}
			else
			{
				SetStatusAccount(int_1, Language.GetValue("Tài khoản mail: die!"));
			}
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show(ex.ToString());
			SetStatusAccount(int_1, Language.GetValue("Lỗi!"));
		}
	}

	private void method_92(int int_1, string string_0)
	{
		try
		{
			method_117(int_1, "cId");
			string string_ = method_117(int_1, "cUid");
			if (!method_16(string_))
			{
				SetStatusAccount(int_1, Language.GetValue("Uid không hợp lệ!"));
				return;
			}
			string text = "";
			string text2 = "";
			string text3 = EA98BF20.CheckLiveWall(string_);
			if (text3.StartsWith("0|"))
			{
				text = "Die";
				text2 = "Wall die";
			}
			else if (text3.StartsWith("1|"))
			{
				text = "Live";
				text2 = "Wall live";
			}
			else
			{
				text2 = Language.GetValue("Không check được!");
			}
			SetStatusAccount(int_1, text2);
			if (text != "")
			{
				CC1905A5(int_1, text);
			}
		}
		catch
		{
			SetStatusAccount(int_1, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void A92ABF10(int BABC5D26)
	{
		try
		{
			string text = "";
			method_117(BABC5D26, "cId");
			string string_ = method_117(BABC5D26, "cCookies");
			string text2 = method_117(BABC5D26, "cToken");
			if (text2.Trim() == "")
			{
				SetStatusAccount(BABC5D26, Language.GetValue("Token trô\u0301ng!"));
				return;
			}
			string text3 = method_117(BABC5D26, "cUseragent");
			string text4 = "";
			int num = 0;
			if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 9)
			{
				text4 = method_117(BABC5D26, "cProxy");
				num = (text4.EndsWith("*1") ? 1 : 0);
				if (text4.EndsWith("*0") || text4.EndsWith("*1"))
				{
					text4 = text4.Substring(0, text4.Length - 2);
				}
			}
			if (text3 == "" && text4.Split(':').Length == 4)
			{
				text3 = Base.string_3;
			}
			string text5 = "";
			if (!EA98BF20.D90D78B1(string_, text2, text3, text4, num))
			{
				text5 = "Token die";
			}
			else
			{
				text = "Live";
				text5 = "Token live";
			}
			SetStatusAccount(BABC5D26, text5);
			if (text != "")
			{
				CC1905A5(BABC5D26, text);
			}
		}
		catch
		{
			SetStatusAccount(BABC5D26, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void method_93(int int_1)
	{
		try
		{
			string text = "";
			method_117(int_1, "cId");
			string text2 = method_117(int_1, "cCookies");
			if (text2.Trim() == "")
			{
				SetStatusAccount(int_1, Language.GetValue("Cookie trô\u0301ng!"));
				return;
			}
			string text3 = method_117(int_1, "cUseragent");
			string text4 = "";
			int num = 0;
			if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 9)
			{
				text4 = method_117(int_1, "cProxy");
				num = (text4.EndsWith("*1") ? 1 : 0);
				if (text4.EndsWith("*0") || text4.EndsWith("*1"))
				{
					text4 = text4.Substring(0, text4.Length - 2);
				}
			}
			if (text3 == "" && text4.Split(':').Length == 4)
			{
				text3 = Base.string_3;
			}
			string text5 = "";
			if (!EA98BF20.smethod_3(text2, text3, text4, num).StartsWith("1|"))
			{
				text5 = "Cookie die";
			}
			else
			{
				text = "Live";
				text5 = "Cookie live";
			}
			SetStatusAccount(int_1, text5);
			if (text != "")
			{
				CC1905A5(int_1, text);
			}
		}
		catch
		{
			SetStatusAccount(int_1, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void BF071EB2(int int_1)
	{
		string f037F2B = dtgvAcc.Rows[int_1].Cells["cId"].Value.ToString();
		string string_ = dtgvAcc.Rows[int_1].Cells["cUid"].Value.ToString();
		string string_2 = dtgvAcc.Rows[int_1].Cells["cPassword"].Value.ToString();
		string text = method_117(int_1, "cUseragent");
		string text2 = "";
		int num = 0;
		if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 9)
		{
			text2 = method_117(int_1, "cProxy");
			num = (text2.EndsWith("*1") ? 1 : 0);
			if (text2.EndsWith("*0") || text2.EndsWith("*1"))
			{
				text2 = text2.Substring(0, text2.Length - 2);
			}
		}
		if (text == "" && text2.Split(':').Length == 4)
		{
			text = Base.string_3;
		}
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = EA98BF20.D42B7486(string_, string_2, "", text2, num);
		switch (text6.Split('|')[0])
		{
		case "3":
			text3 = "Changed pass";
			break;
		case "2":
			text3 = ((!(text6.Split('|')[1].Trim() != "")) ? Language.GetValue("Checkpoint") : ("Checkpoint: " + text6.Split('|')[1]));
			break;
		case "1":
			text5 = text6.Split('|')[1];
			text3 = "Live";
			break;
		case "5":
			text4 = Language.GetValue("Không check đươ\u0323c (Co\u0301 2fa)!");
			break;
		case "0":
		case "4":
			text4 = Language.GetValue("Không check đươ\u0323c!");
			break;
		}
		if (text4 == "")
		{
			text4 = Language.GetValue("Đa\u0303 check Done!");
		}
		if (text5 != "")
		{
			SetCellAccount(int_1, "cCookies", text5);
			CommonSQL.UpdateFieldToAccount(f037F2B, "cookie1", text5);
		}
		if (text3 != "")
		{
			CC1905A5(int_1, text3);
		}
		SetStatusAccount(int_1, text4);
	}

	private void toolStripMenuItem_9_Click(object sender, EventArgs e)
	{
		method_90(0);
	}

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		if (MessageBoxHelper.smethod_1(Language.GetValue("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) == DialogResult.Yes)
		{
			method_90(1);
		}
	}

	private void B5199DA9(object sender, EventArgs e)
	{
		method_90(2);
	}

	private void method_94(object sender, EventArgs e)
	{
		method_90(3);
	}

	private void DE23BE8B_Click(object sender, EventArgs e)
	{
		method_9("cEmail");
	}

	private void B0062D3F(object sender, EventArgs e)
	{
		try
		{
			if (cbbSearch.SelectedIndex == -1)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn kiểu tìm kiếm!"), 3);
				return;
			}
			string columnName = cbbSearch.SelectedValue.ToString();
			string text = FFAFC3B3.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng nhập nội dung tìm kiếm!"), 3);
				return;
			}
			List<int> list = new List<int>();
			text = Common.A8AF5A8E(text.ToLower());
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				string text2 = dtgvAcc.Rows[i].Cells[columnName].Value.ToString();
				text2 = Common.A8AF5A8E(text2.ToLower());
				text = Common.A8AF5A8E(text.ToLower());
				if (text2.Contains(text))
				{
					list.Add(i);
				}
			}
			int index = 0;
			int num = -1;
			try
			{
				num = dtgvAcc.CurrentRow.Index;
			}
			catch
			{
				num = -1;
			}
			if (list.Count <= 0)
			{
				return;
			}
			if (num >= list[list.Count - 1])
			{
				index = 0;
			}
			else
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (num < list[j])
					{
						index = j;
						break;
					}
				}
			}
			int index2 = list[index];
			dtgvAcc.CurrentCell = dtgvAcc.Rows[index2].Cells[columnName];
			dtgvAcc.ClearSelection();
			dtgvAcc.Rows[index2].Selected = true;
		}
		catch (Exception)
		{
		}
	}

	private void DE3EC6BF(object sender, EventArgs e)
	{
		method_9("cUid|cPassword|cToken|cCookies|cEmail|cPassMail|cFa2");
	}

	private void toolStripStatusLabel9_Click(object sender, EventArgs e)
	{
		Hide();
        SettingsTool.GetSettings("settingLogin").GetValue("UserName", (object)"");
        SettingsTool.GetSettings("settingLogin").GetValue("PassWord", (object)"");
		SettingsTool.smethod_0("settingLogin");
		fActive fActive2 = new fActive(0);
		fActive2.ShowInTaskbar = true;
		fActive2.ShowDialog();
	}

	private void method_95()
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			SetCellAccount(i, "cSTT", i + 1);
		}
	}

	private void fAToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_9("cFa2");
	}

	private void checkAvatarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		int CE88A4B3 = 0;
		int int_0 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		bool_0 = false;
		new Thread((ThreadStart)delegate
		{
			method_88("start");
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (CE88A4B3 < int_0)
					{
						Interlocked.Increment(ref CE88A4B3);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							SetStatusAccount(int_, Language.GetValue("Đang kiểm tra..."));
							CheckMyAvatar(int_);
							Interlocked.Decrement(ref CE88A4B3);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (CE88A4B3 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			method_88("stop");
		}).Start();
	}

	private void CheckMyAvatar(int row)
	{
		try
		{
			string uid = dtgvAcc.Rows[row].Cells["cUid"].Value.ToString();
			string id = dtgvAcc.Rows[row].Cells["cId"].Value.ToString();
            if (PhoneFarmLib.Common.CheckAvatar(uid))
            {
                SetStatusAccount(row, Language.GetValue("Đa\u0303 co\u0301 avatar!"));
                SetCellAccount(row, "cAvatar", "Yes");
                CommonSQL.UpdateFieldToAccount(id, "avatar", "Yes");
            }
            else
            {
                SetStatusAccount(row, Language.GetValue("Không co\u0301 avatar!"));
                SetCellAccount(row, "cAvatar", "No");
                CommonSQL.UpdateFieldToAccount(id, "avatar", "No");
            }
		}
		catch
		{
			SetStatusAccount(row, "Lỗi!");
		}
	}

	private void locTrungToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					string item = method_117(i, "cUid");
					if (list2.Contains(item))
					{
						list.Add(item);
					}
					else
					{
						list2.Add(item);
					}
				}
			}
			if (list.Count == 0)
			{
				MessageBoxHelper.Show("Không có tài khoản trùng nhau!");
				return;
			}
			List<string> list3 = Common.smethod_11(list);
			DataTable dataTable = CommonSQL.E1B5F13E(list3);
			dataTable.DefaultView.Sort = "uid ASC";
			dataTable = dataTable.DefaultView.ToTable();
			dtgvAcc.Rows.Clear();
			D135A89E(dataTable);
		}
		catch (Exception)
		{
		}
	}

	private void method_96(object sender, EventArgs e)
	{
	}

	private void method_97(object sender, EventArgs e)
	{
	}

	private void D7227036(int EC834FA8)
	{
		try
		{
			string f037F2B = dtgvAcc.Rows[EC834FA8].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[EC834FA8].Cells["cUid"].Value.ToString();
			string text2 = FileHelper.GetPathToCurrentFolder() + "\\profile\\" + text;
			string path = text2 + "\\data.tar.gz";
			string path2 = text2 + ".zip";
			if (text.Trim() == "")
			{
				SetStatusAccount(EC834FA8, Language.GetValue("Chưa tạo profile!"));
				SetCellAccount(EC834FA8, "cProfile", "No");
				CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "No");
			}
			else if (File.Exists(path))
			{
				try
				{
					File.Delete(path);
					SetStatusAccount(EC834FA8, Language.GetValue("Xóa profile thành công!"));
					SetCellAccount(EC834FA8, "cProfile", "No");
					CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "No");
				}
				catch
				{
					SetStatusAccount(EC834FA8, Language.GetValue("Xóa profile thâ\u0301t ba\u0323i!"));
				}
			}
			else if (File.Exists(path2))
			{
				try
				{
					File.Delete(path2);
					SetStatusAccount(EC834FA8, Language.GetValue("Xóa profile thành công!"));
					SetCellAccount(EC834FA8, "cProfile", "No");
					CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "No");
				}
				catch
				{
					SetStatusAccount(EC834FA8, Language.GetValue("Xóa profile thâ\u0301t ba\u0323i!"));
				}
			}
			else
			{
				SetStatusAccount(EC834FA8, Language.GetValue("Chưa tạo profile!"));
			}
		}
		catch
		{
			SetStatusAccount(EC834FA8, Language.GetValue("Xóa profile thất bại!"));
		}
	}

	private void method_98(int int_1, string string_0)
	{
		try
		{
			string f037F2B = method_117(int_1, "cId");
			string text = method_117(int_1, "cUid");
			string_0 = string_0 + "\\" + text + ".tar.gz";
			if (File.Exists(string_0))
			{
				SetStatusAccount(int_1, Language.GetValue("Đã backup data Fb!"));
				SetCellAccount(int_1, "cProfile", "Yes");
				CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "Yes");
			}
			else
			{
				SetStatusAccount(int_1, Language.GetValue("Chưa backup data Fb!"));
				SetCellAccount(int_1, "cProfile", "No");
				CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "No");
			}
		}
		catch
		{
		}
	}

	public void method_99(string string_0)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch
		{
		}
	}

	private void pictureBox1_DoubleClick(object sender, EventArgs e)
	{
		method_99("Chrome");
	}

	private void FC37A68F(object sender, ToolStripItemClickedEventArgs e)
	{
	}

	private void A1AED3A8_Click(object sender, EventArgs e)
	{
		method_9("cUid|cPassword|cFa2");
	}

	private void A6014E37_Click(object sender, EventArgs e)
	{
		Dictionary<string, bool> B387D = new Dictionary<string, bool>();
		B387D.Add("isChangePathDatabase", value: false);
		Common.smethod_16(new fCauHinhChung(ref B387D));
		if (B387D["isChangePathDatabase"])
		{
			method_4();
			int_0 = -1;
			cbbThuMuc.SelectedIndex = -1;
			cbbThuMuc.SelectedIndex = 0;
		}
	}

	private void toolStripMenuItem_11_Click(object sender, EventArgs e)
	{
		try
		{
			if (method_8())
			{
				List<string> f18A = F7352394("cUid|cPassword|cToken|cCookies|cEmail|cPassMail|cFa2|cUseragent|cProxy|cName|cGender|cFollow|cFriend|cGroup|cBirthday|cDateCreateAcc|cGhiChu|cMailRecovery|cInteractEnd");
				Common.smethod_16(new fCopy(f18A));
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Error Copy");
		}
	}

	private void D3814D0A(object sender, EventArgs e)
	{
		method_9("cMa2Fa");
	}

	private void AE147393(object sender, EventArgs e)
	{
	}

	private void E3B585B5(int int_1)
	{
		int EC9BCA2D = 0;
		int int_2 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		string string_0 = SettingsTool.GetSettings("configGeneral").GetValue("token");
		string C280222B = SettingsTool.GetSettings("configGeneral").GetValue("cookie");
		if (int_1 == 0 && !EA98BF20.D90D78B1("", string_0, "", ""))
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lòng kiểm tra lại token trung gian!"), 3);
			return;
		}
		if (int_1 == 4 && EA98BF20.smethod_3(C280222B, "", "", 0).StartsWith("0|"))
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lòng kiểm tra lại cookie trung gian!"), 3);
			return;
		}
		this.bool_0 = false;
		bool bool_0 = false;
		bool bool_1 = false;
		bool F39BC599 = false;
		int int_3 = 0;
		Thread thread = new Thread((ThreadStart)delegate
		{
			method_88("start");
			switch (int_1)
			{
			case 0:
			{
				int num3 = 0;
				while (num3 < dtgvAcc.Rows.Count && !this.bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num3].Cells["cChose"].Value))
					{
						if (EC9BCA2D < int_2)
						{
							Interlocked.Increment(ref EC9BCA2D);
							int int_4 = num3++;
							Thread thread4 = new Thread((ThreadStart)delegate
							{
								SetStatusAccount(int_4, Language.GetValue("Đang kiểm tra..."));
								if (!B215B5BB(int_4, string_0, AB936034: true))
								{
									this.bool_0 = true;
									bool_0 = true;
								}
								Interlocked.Decrement(ref EC9BCA2D);
							});
							thread4.IsBackground = true;
							thread4.Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num3++;
					}
				}
				goto default;
			}
			case 1:
			{
				int num4 = 0;
				while (num4 < dtgvAcc.Rows.Count && !this.bool_0)
				{
					if (!Convert.ToBoolean(dtgvAcc.Rows[num4].Cells["cChose"].Value))
					{
						num4++;
						continue;
					}
					if (EC9BCA2D < int_2)
					{
						Interlocked.Increment(ref EC9BCA2D);
						int F7AED1B8 = num4++;
						Thread thread5 = new Thread((ThreadStart)delegate
						{
							SetStatusAccount(F7AED1B8, Language.GetValue("Đang kiểm tra..."));
							B126E2B8(F7AED1B8);
							Interlocked.Decrement(ref EC9BCA2D);
						});
						thread5.IsBackground = true;
						thread5.Start();
						continue;
					}
					if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 0 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 7 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 8 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 9 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 10 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 11 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 12 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 13 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 14)
					{
						Common.DelayTime(1.0);
						continue;
					}
					while (EC9BCA2D > 0)
					{
						Common.DelayTime(1.0);
					}
					if (this.bool_0)
					{
						break;
					}
					Interlocked.Increment(ref int_3);
					if (int_3 < Convert.ToInt32((SettingsTool.GetSettings("configGeneral").GetValue("ip_nudChangeIpCount") == "") ? "1" : SettingsTool.GetSettings("configGeneral").GetValue("ip_nudChangeIpCount")))
					{
						continue;
					}
					for (int j = 0; j < 3; j++)
					{
						F39BC599 = Common.smethod_44(SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp"), SettingsTool.GetSettings("configGeneral").method_0("typeDcom"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom"), SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink"), SettingsTool.GetSettings("configGeneral").method_0("ip_cbbHostpot"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN"));
						if (F39BC599)
						{
							break;
						}
					}
					if (F39BC599)
					{
						int_3 = 0;
						continue;
					}
					goto IL_044f;
				}
				goto default;
			}
			case 2:
			{
				int num2 = 0;
				while (num2 < dtgvAcc.Rows.Count && !this.bool_0)
				{
					if (!Convert.ToBoolean(dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						num2++;
						continue;
					}
					if (EC9BCA2D < int_2)
					{
						Interlocked.Increment(ref EC9BCA2D);
						int int_5 = num2++;
						Thread thread3 = new Thread((ThreadStart)delegate
						{
							SetStatusAccount(int_5, Language.GetValue("Đang kiểm tra..."));
							method_100(int_5);
							Interlocked.Decrement(ref EC9BCA2D);
						});
						thread3.IsBackground = true;
						thread3.Start();
						continue;
					}
					if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 0 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 7 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 8 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 9 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 10 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 11 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 12 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 13 || SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 14)
					{
						Common.DelayTime(1.0);
						continue;
					}
					while (EC9BCA2D > 0)
					{
						Common.DelayTime(1.0);
					}
					if (this.bool_0)
					{
						break;
					}
					Interlocked.Increment(ref int_3);
					if (int_3 < Convert.ToInt32((SettingsTool.GetSettings("configGeneral").GetValue("ip_nudChangeIpCount") == "") ? "1" : SettingsTool.GetSettings("configGeneral").GetValue("ip_nudChangeIpCount")))
					{
						continue;
					}
					for (int i = 0; i < 3; i++)
					{
						F39BC599 = Common.smethod_44(SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp"), SettingsTool.GetSettings("configGeneral").method_0("typeDcom"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtProfileNameDcom"), SettingsTool.GetSettings("configGeneral").GetValue("txtUrlHilink"), SettingsTool.GetSettings("configGeneral").method_0("ip_cbbHostpot"), SettingsTool.GetSettings("configGeneral").GetValue("ip_txtNordVPN"));
						if (F39BC599)
						{
							break;
						}
					}
					if (F39BC599)
					{
						int_3 = 0;
						continue;
					}
					goto IL_07a5;
				}
				goto default;
			}
			case 4:
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count && !this.bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (EC9BCA2D < int_2)
						{
							Interlocked.Increment(ref EC9BCA2D);
							int int_6 = num++;
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								SetStatusAccount(int_6, Language.GetValue("Đang kiểm tra..."));
								if (!B5A86B92(int_6, C280222B))
								{
									this.bool_0 = true;
									bool_1 = true;
								}
								Interlocked.Decrement(ref EC9BCA2D);
							});
							thread2.IsBackground = true;
							thread2.Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
				goto default;
			}
			default:
				{
					int tickCount = Environment.TickCount;
					while (EC9BCA2D > 0 && Environment.TickCount - tickCount <= 60000)
					{
						Common.DelayTime(1.0);
					}
					break;
				}
				IL_044f:
				MessageBoxHelper.Show(Language.GetValue("Không thê\u0309 đô\u0309i ip!"), 3);
				break;
				IL_07a5:
				MessageBoxHelper.Show(Language.GetValue("Không thê\u0309 đô\u0309i ip!"), 3);
				break;
			}
			method_88("stop");
			if (bool_0)
			{
				MessageBoxHelper.Show(Language.GetValue("Token trung gian die!"));
			}
			if (bool_1)
			{
				MessageBoxHelper.Show(Language.GetValue("Cookie trung gian die!"));
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private bool B215B5BB(int int_1, string string_0, bool AB936034)
	{
		try
		{
			string string_ = method_117(int_1, "cId");
			string text = method_117(int_1, "cUid");
			string text2 = method_117(int_1, "cUseragent");
			string text3 = "";
			int d00A = 0;
			if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 9)
			{
				text3 = method_117(int_1, "cProxy");
				d00A = (text3.EndsWith("*1") ? 1 : 0);
				if (text3.EndsWith("*0") || text3.EndsWith("*1"))
				{
					text3 = text3.Substring(0, text3.Length - 2);
				}
			}
			if (text2 == "" && text3.Split(':').Length == 4)
			{
				text2 = Base.string_3;
			}
			if (AB936034)
			{
				text2 = "";
				text3 = "";
				d00A = 0;
			}
			string text4 = "";
			string text5 = "";
			if (text == "")
			{
				text5 = Language.GetValue("Không co\u0301 uid!");
			}
			else
			{
				string text6 = EA98BF20.D0814DB9(string_0, text, text2, text3, d00A);
				if (text6 == "-1")
				{
					SetStatusAccount(int_1, Language.GetValue("Không check đươ\u0323c!"));
					return false;
				}
				string[] array = text6.Split('|');
				if (Convert.ToBoolean(array[0]))
				{
					text4 = "Live";
					CommonSQL.smethod_9(string_, "name|gender|birthday|friends|groups" + ((array[5] != "") ? "|email" : ""), array[1] + "|" + array[2] + "|" + array[3] + "|" + array[6] + "|" + array[7] + ((array[5] != "") ? ("|" + array[5]) : ""));
					SetCellAccount(int_1, "cName", array[1]);
					SetCellAccount(int_1, "cGender", array[2]);
					SetCellAccount(int_1, "cBirthday", array[3]);
					if (array[5] != "")
					{
						SetCellAccount(int_1, "cEmail", array[5]);
					}
					SetCellAccount(int_1, "cFriend", array[6]);
					SetCellAccount(int_1, "cGroup", array[7]);
					text5 = "Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!";
				}
				else
				{
					text4 = "Die";
					text5 = Language.GetValue("Tài khoản die!");
				}
			}
			SetStatusAccount(int_1, text5);
			if (text4 != "")
			{
				CC1905A5(int_1, text4);
			}
		}
		catch
		{
			SetStatusAccount(int_1, Language.GetValue("Không check đươ\u0323c!"));
		}
		return true;
	}

	private void method_100(int E036E48B)
	{
		try
		{
			string string_ = method_117(E036E48B, "cId");
			string text = method_117(E036E48B, "cCookies");
			method_117(E036E48B, "cToken");
			string text2 = method_117(E036E48B, "cUseragent");
			string text3 = "";
			int num = 0;
			if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 9)
			{
				text3 = method_117(E036E48B, "cProxy");
				num = (text3.EndsWith("*1") ? 1 : 0);
				if (text3.EndsWith("*0") || text3.EndsWith("*1"))
				{
					text3 = text3.Substring(0, text3.Length - 2);
				}
			}
			if (text2 == "" && text3.Split(':').Length == 4)
			{
				text2 = Base.string_3;
			}
			string text4 = "";
			string text5 = "";
			if (text == "")
			{
				text4 = Language.GetValue("Cookie trô\u0301ng");
			}
			else
			{
				string text6 = EA98BF20.smethod_11(text, text2, text3, num);
				if (text6 == "-1")
				{
					text4 = "Cookie die";
				}
				else
				{
					string[] array = text6.Split('|');
					if (Convert.ToBoolean(array[0]))
					{
						text5 = "Live";
						CommonSQL.smethod_9(string_, "name|gender|birthday|friends|groups" + ((array[5] != "") ? "|email" : ""), array[1] + "|" + array[2] + "|" + array[3] + "|" + array[6] + "|" + array[7] + ((array[5] != "") ? ("|" + array[5]) : ""));
						SetCellAccount(E036E48B, "cName", array[1]);
						SetCellAccount(E036E48B, "cGender", array[2]);
						SetCellAccount(E036E48B, "cBirthday", array[3]);
						if (array[5] != "")
						{
							SetCellAccount(E036E48B, "cEmail", array[5]);
						}
						SetCellAccount(E036E48B, "cFriend", array[6]);
						SetCellAccount(E036E48B, "cGroup", array[7]);
						text4 = Language.GetValue("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
					}
					else
					{
						text5 = "Die";
						text4 = Language.GetValue("Tài khoản die!");
					}
				}
			}
			SetStatusAccount(E036E48B, text4);
			if (text5 != "")
			{
				CC1905A5(E036E48B, text5);
			}
		}
		catch
		{
			SetStatusAccount(E036E48B, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private bool B5A86B92(int CA301197, string D00A941F)
	{
		try
		{
			string text = method_117(CA301197, "cId");
			string string_ = method_117(CA301197, "cUid");
			string text2 = "";
			string text3 = EA98BF20.smethod_12(string_, D00A941F);
			if (text3 == "-1")
			{
				SetStatusAccount(CA301197, Language.GetValue("Không check đươ\u0323c!"));
				return false;
			}
			string[] array = text3.Split('|');
			if (Convert.ToBoolean(array[0]))
			{
				CommonSQL.smethod_9(text, "name|gender", array[1] + "|" + array[2]);
				SetCellAccount(CA301197, "cName", array[1]);
				SetCellAccount(CA301197, "cGender", array[2]);
				if (array[6] != "")
				{
					SetCellAccount(CA301197, "cFriend", array[6]);
					CommonSQL.UpdateFieldToAccount(text, "friends", array[6]);
				}
				if (array[7] != "")
				{
					SetCellAccount(CA301197, "cGroup", array[7]);
					CommonSQL.UpdateFieldToAccount(text, "groups", array[7]);
				}
				CC1905A5(CA301197, "Live");
				text2 = Language.GetValue("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
			}
			else
			{
				CC1905A5(CA301197, "Die");
				text2 = Language.GetValue("Tài khoản Die!");
			}
			SetStatusAccount(CA301197, text2);
		}
		catch
		{
			SetStatusAccount(CA301197, Language.GetValue("Không check đươ\u0323c!"));
		}
		return true;
	}

	private void B126E2B8(int int_1)
	{
		try
		{
			string string_ = method_117(int_1, "cId");
			string text = method_117(int_1, "cToken");
			string text2 = method_117(int_1, "cUseragent");
			string text3 = "";
			int d00A = 0;
			if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 9)
			{
				text3 = method_117(int_1, "cProxy");
				d00A = (text3.EndsWith("*1") ? 1 : 0);
				if (text3.EndsWith("*0") || text3.EndsWith("*1"))
				{
					text3 = text3.Substring(0, text3.Length - 2);
				}
			}
			if (text2 == "" && text3.Split(':').Length == 4)
			{
				text2 = Base.string_3;
			}
			string text4 = "";
			string text5 = "";
			if (text == "")
			{
				text5 = Language.GetValue("Token trô\u0301ng");
			}
			else
			{
				string text6 = EA98BF20.D0814DB9(text, "", text2, text3, d00A);
				if (text6 == "-1")
				{
					text5 = "Token die";
				}
				else
				{
					string[] array = text6.Split('|');
					if (Convert.ToBoolean(array[0]))
					{
						text4 = "Live";
						CommonSQL.smethod_9(string_, "name|gender|birthday|friends|groups" + ((array[5] != "") ? "|email" : ""), array[1] + "|" + array[2] + "|" + array[3] + "|" + array[6] + "|" + array[7] + ((array[5] != "") ? ("|" + array[5]) : ""));
						SetCellAccount(int_1, "cName", array[1]);
						SetCellAccount(int_1, "cGender", array[2]);
						SetCellAccount(int_1, "cBirthday", array[3]);
						if (array[5] != "")
						{
							SetCellAccount(int_1, "cEmail", array[5]);
						}
						SetCellAccount(int_1, "cFriend", array[6]);
						SetCellAccount(int_1, "cGroup", array[7]);
					}
					else
					{
						text4 = "Die";
					}
					text5 = Language.GetValue("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
				}
			}
			SetStatusAccount(int_1, text5);
			if (text4 != "")
			{
				CC1905A5(int_1, text4);
			}
		}
		catch
		{
			SetStatusAccount(int_1, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void C921DD8D(object sender, EventArgs e)
	{
		Common.smethod_16(new fNhapTokenTrungGian());
		if (fNhapTokenTrungGian.F08FF18B)
		{
			E3B585B5(0);
		}
	}

	private void method_101(object sender, EventArgs e)
	{
		E3B585B5(1);
	}

	private void method_102(object sender, EventArgs e)
	{
		if (MessageBoxHelper.smethod_1(Language.GetValue("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) == DialogResult.Yes)
		{
			E3B585B5(2);
		}
	}

	private List<string> BB133710(List<string> A51DD800, int CD0D0426 = 50, string string_0 = ",")
	{
		int num = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)A51DD800.Count * 1.0 / (double)CD0D0426)));
		List<string> list = new List<string>();
		for (int i = 0; i < num; i++)
		{
			list.Add(string.Join(string_0, A51DD800.GetRange(CD0D0426 * i, (CD0D0426 * i + CD0D0426 <= A51DD800.Count) ? CD0D0426 : (A51DD800.Count % CD0D0426))));
		}
		return list;
	}

	private void method_103(object sender, EventArgs e)
	{
		string A3045621 = Base.string_4;
		int AE9E0B0D = 0;
		int int_0 = 10;
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (AE9E0B0D < int_0)
						{
							Interlocked.Increment(ref AE9E0B0D);
							int A63BB38 = num++;
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								try
								{
									method_104(A63BB38, A3045621);
									Interlocked.Decrement(ref AE9E0B0D);
								}
								catch (Exception a81E2)
								{
									Common.smethod_43(a81E2);
								}
							});
							thread2.IsBackground = true;
							thread2.Start();
						}
						else
						{
							Common.DelayTime(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (AE9E0B0D > 0)
				{
					Common.DelayTime(1.0);
				}
			}
			catch (Exception a81E)
			{
				Common.smethod_43(a81E);
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_104(int int_1, string string_0, bool bool_4 = false, string string_1 = "")
	{
		try
		{
			string text = "";
			string input = DatagridviewHelper.E83E252C(dtgvAcc, int_1, "cCookie");
			string text2 = dtgvAcc.Rows[int_1].Cells["cUid"].Value.ToString();
			if (text2 == "")
			{
				text2 = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
			}
			text = ((!File.Exists("backup\\" + text2 + "\\ngaysinh.txt")) ? "||" : File.ReadAllText("backup\\" + text2 + "\\ngaysinh.txt"));
			DatagridviewHelper.AD3DF791(dtgvAcc, int_1, "cStatus", Language.GetValue("Đang tạo file Html..."));
			if (text2 != "")
			{
				string text3 = text.Split('|')[2].Replace("\"", "\\\"").Replace("'", "\\'");
				string text4 = text.Split('|')[1];
				if (text3 == "")
				{
					text3 = "NoName";
				}
				if (text4 == "")
				{
					text4 = "00/00/0000";
				}
				string_0 = string_0.Replace("{{uid}}", text2).Replace("{{birthday}}", text4).Replace("{{name}}", text3);
				string text5 = "backup\\" + text2;
				if (!Directory.Exists(text5))
				{
					return;
				}
				if (File.Exists(text5 + "\\lscomment.txt"))
				{
					string text6 = "";
					List<string> list = File.ReadAllLines(text5 + "\\lscomment.txt").ToList();
					int count = list.Count;
					for (int i = 0; i < count; i++)
					{
						text6 = text6 + "\"" + list[i].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
					}
					if (text6 != "")
					{
						text6 = text6.Remove(text6.Length - 1, 1);
						string_0 = string_0.Replace("{comments}", text6);
					}
					else
					{
						string_0 = string_0.Replace("{comments}", "");
					}
				}
				else
				{
					string_0 = string_0.Replace("{comments}", "");
				}
				if (File.Exists(text5 + "\\banbeinbox.txt"))
				{
					string text7 = "";
					List<string> list2 = File.ReadAllLines(text5 + "\\banbeinbox.txt").ToList();
					int count2 = list2.Count;
					for (int j = 0; j < count2; j++)
					{
						text7 = text7 + "\"" + list2[j].Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
					}
					if (text7 != "")
					{
						text7 = text7.Remove(text7.Length - 1, 1);
						string_0 = string_0.Replace("{messages}", text7);
					}
					else
					{
						string_0 = string_0.Replace("{messages}", "");
					}
				}
				else
				{
					string_0 = string_0.Replace("{messages}", "");
				}
				if (File.Exists(text5 + "\\" + text2 + ".txt"))
				{
					string text8 = "";
					string text9 = "";
					string text10 = File.ReadAllText(text5 + "\\" + text2 + ".txt");
					string[] array = text10.Split(new string[1] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
					for (int k = 0; k < array.Length; k++)
					{
						string[] array2 = array[k].Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
						if (array2.Length != 0)
						{
							text9 = "";
							for (int l = 0; l < array2.Length; l++)
							{
								string[] array3 = array2[l].Split('*');
								text9 = text9 + "\"" + array3[2].Split('|')[0] + "\",";
							}
							text9 = text9.Remove(text9.Length - 1, 1);
							text8 = text8 + "{\"uid\":\"" + array2[0].Split('*')[0] + "\",\"name\":\"" + array2[0].Split('*')[1] + "\",\"photos\":[" + text9 + "],\"show\":true},";
						}
					}
					text8 = text8.Remove(text8.Length - 1, 1);
					string_0 = string_0.Replace("{photos}", text8);
				}
				else
				{
					string_0 = string_0.Replace("{photos}", "");
				}
				File.WriteAllText(text5 + "\\" + text2 + ".html", string_0);
				DatagridviewHelper.AD3DF791(dtgvAcc, int_1, "cStatus", Language.GetValue("Ta\u0323o tha\u0300nh công!"));
				return;
			}
			DatagridviewHelper.AD3DF791(dtgvAcc, int_1, "cStatus", Language.GetValue("Không co\u0301 uid!"));
		}
		catch
		{
			DatagridviewHelper.AD3DF791(dtgvAcc, int_1, "cStatus", Language.GetValue("Lô\u0303i ta\u0323o file!"));
		}
	}

	private bool DCA3A510(string CF9E282E, string string_0, string string_1 = "backup\\")
	{
		bool result = false;
		try
		{
			string text = "";
			text = ((!File.Exists(string_1 + "\\" + CF9E282E + "\\ngaysinh.txt")) ? "||" : File.ReadAllText(string_1 + "\\" + CF9E282E + "\\ngaysinh.txt"));
			if (CF9E282E != "")
			{
				string text2 = text.Split('|')[2].Replace("\"", "\\\"").Replace("'", "\\'");
				string text3 = text.Split('|')[1];
				if (text2 == "")
				{
					text2 = "NoName";
				}
				if (text3 == "")
				{
					text3 = "00/00/0000";
				}
				string_0 = string_0.Replace("{{uid}}", CF9E282E).Replace("{{birthday}}", text3).Replace("{{name}}", text2);
				string text4 = string_1 + "\\" + CF9E282E;
				if (Directory.Exists(text4))
				{
					if (File.Exists(text4 + "\\lscomment.txt"))
					{
						string text5 = "";
						List<string> list = File.ReadAllLines(text4 + "\\lscomment.txt").ToList();
						int count = list.Count;
						for (int i = 0; i < count; i++)
						{
							text5 = text5 + "\"" + list[i].Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
						}
						if (text5 != "")
						{
							text5 = text5.Remove(text5.Length - 1, 1);
							string_0 = string_0.Replace("{comments}", text5);
						}
						else
						{
							string_0 = string_0.Replace("{comments}", "");
						}
					}
					else
					{
						string_0 = string_0.Replace("{comments}", "");
					}
					if (File.Exists(text4 + "\\banbeinbox.txt"))
					{
						string text6 = "";
						List<string> list2 = File.ReadAllLines(text4 + "\\banbeinbox.txt").ToList();
						int count2 = list2.Count;
						for (int j = 0; j < count2; j++)
						{
							text6 = text6 + "\"" + list2[j].Replace("\"", "\\\"").Replace("'", "\\'") + "\",";
						}
						if (text6 != "")
						{
							text6 = text6.Remove(text6.Length - 1, 1);
							string_0 = string_0.Replace("{messages}", text6);
						}
						else
						{
							string_0 = string_0.Replace("{messages}", "");
						}
					}
					else
					{
						string_0 = string_0.Replace("{messages}", "");
					}
					if (File.Exists(text4 + "\\" + CF9E282E + ".txt"))
					{
						string text7 = "";
						string text8 = "";
						string text9 = File.ReadAllText(text4 + "\\" + CF9E282E + ".txt");
						string[] array = text9.Split(new string[1] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
						for (int k = 0; k < array.Length; k++)
						{
							string[] array2 = array[k].Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
							if (array2.Length != 0)
							{
								text8 = "";
								for (int l = 0; l < array2.Length; l++)
								{
									string[] array3 = array2[l].Split('*');
									text8 = text8 + "\"" + array3[2].Split('|')[0] + "\",";
								}
								text8 = text8.Remove(text8.Length - 1, 1);
								text7 = text7 + "{\"uid\":\"" + array2[0].Split('*')[0] + "\",\"name\":\"" + array2[0].Split('*')[1] + "\",\"photos\":[" + text8 + "],\"show\":true},";
							}
						}
						text7 = text7.Remove(text7.Length - 1, 1);
						string_0 = string_0.Replace("{photos}", text7);
					}
					else
					{
						string_0 = string_0.Replace("{photos}", "");
					}
					File.WriteAllText(text4 + "\\" + CF9E282E + ".html", string_0);
					result = true;
					return result;
				}
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	private void dtgvAcc_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
	{
		try
		{
			List<string> list = new List<string> { "cStt", "cFriend", "cGroup", "cFollow" };
			string text = e.CellValue1.ToString().Trim();
			string text2 = e.CellValue2.ToString().Trim();
			if (text == "" || text2 == "")
			{
				e.SortResult = text.CompareTo(text2);
			}
			else if (list.Contains(e.Column.Name))
			{
				if (!Common.smethod_28(text))
				{
					text = ((text != "") ? "-1" : "-2");
				}
				if (!Common.smethod_28(text2))
				{
					text2 = ((text2 != "") ? "-1" : "-2");
				}
				e.SortResult = int.Parse(text).CompareTo(int.Parse(text2));
			}
			else if (e.Column.Name == "cInteractEnd")
			{
				e.SortResult = Common.F11F4A37(text).CompareTo(Common.F11F4A37(text2));
			}
			else if (e.Column.Name == "cDateDelete")
			{
				e.SortResult = Common.F11F4A37(text, "HH:mm:ss dd/MM/yyyy").CompareTo(Common.F11F4A37(text2, "HH:mm:ss dd/MM/yyyy"));
			}
			else if (e.Column.Name == "cStatus")
			{
				string text3 = "";
				string text4 = "";
				text3 = ((!text.StartsWith("(")) ? text : text.Substring(text.IndexOf(")") + 1).Trim());
				text4 = ((!text2.StartsWith("(")) ? text2 : text2.Substring(text2.IndexOf(")") + 1).Trim());
				e.SortResult = text3.CompareTo(text4);
			}
			else if (e.Column.Name == "cBirthday")
			{
				e.SortResult = Common.F11F4A37(text, "M/d/yyyy").CompareTo(Common.F11F4A37(text2, "M/d/yyyy"));
			}
			else if (e.Column.Name == "cDateCreateAcc")
			{
				e.SortResult = Common.F11F4A37(text, "dd/MM/yyyy HH:mm:ss tt").CompareTo(Common.F11F4A37(text2, "dd/MM/yyyy HH:mm:ss tt"));
			}
			else
			{
				e.SortResult = text.CompareTo(text2);
			}
		}
		catch (Exception)
		{
			e.SortResult = 0;
		}
		e.Handled = true;
	}

	private void E230D204(object sender, EventArgs e)
	{
		string text = SettingsTool.GetSettings("configDatagridview").C71A4EA4();
		Common.smethod_16(new fCauHinhHienThi());
		if (text != SettingsTool.GetSettings("configDatagridview").C71A4EA4())
		{
			method_121();
		}
	}

	private void DB375EB6(object sender, EventArgs e)
	{
		E7007020("Useragent");
	}

	private void method_105(object sender, EventArgs e)
	{
		if (method_109() == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng cho\u0323n như\u0303ng ta\u0300i khoa\u0309n muô\u0301n nhâ\u0323p Proxy!"), 3);
		}
		else
		{
			Common.smethod_16(new fImportProxy());
		}
	}

	private void C49D5B23(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		bool_0 = false;
		Thread thread = new Thread((ThreadStart)delegate
		{
			method_88("start");
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							SetStatusAccount(int_2, Language.GetValue("Đang kiểm tra..."));
							method_106(int_2);
							Interlocked.Decrement(ref int_0);
						});
						thread2.IsBackground = true;
						thread2.Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			method_88("stop");
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_106(int F299AC93)
	{
		try
		{
			string text = dtgvAcc.Rows[F299AC93].Cells["cProxy"].Value.ToString();
			if (text.Trim() == "")
			{
				SetStatusAccount(F299AC93, Language.GetValue("Proxy trô\u0301ng!"));
				return;
			}
			int b03CE = 0;
			if (text.EndsWith("*1"))
			{
				b03CE = 1;
			}
			if (text.EndsWith("*0") || text.EndsWith("*1"))
			{
				text = text.Substring(0, text.Length - 2);
			}
			if (!(Common.CheckProxy(text, b03CE) != ""))
			{
				SetStatusAccount(F299AC93, "Proxy Die!");
			}
			else
			{
				SetStatusAccount(F299AC93, "Proxy Live!");
			}
		}
		catch
		{
			SetStatusAccount(F299AC93, "Error!");
		}
	}

	private void D3243D83(object sender, EventArgs e)
	{
		E7007020("Proxy");
	}

	private void E3108B09_Click(object sender, EventArgs e)
	{
		method_9("cUseragent");
	}

	private void F703662A_Click(object sender, EventArgs e)
	{
		method_9("cProxy");
	}

	private void C41205B6_Click(object sender, EventArgs e)
	{
		E7007020("Notes");
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
		{
			try
			{
				Process.Start(Path.GetDirectoryName(Application.ExecutablePath));
			}
			catch
			{
			}
		}
		else
		{
			if ((e as MouseEventArgs).Button != MouseButtons.Left || Control.ModifierKeys != Keys.Control)
			{
				return;
			}
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					Common.RunCMD(Application.ExecutablePath + " a");
				}
				catch
				{
				}
			});
			thread.IsBackground = true;
			thread.Start();
		}
	}

	private void CAAE0387_Click(object sender, EventArgs e)
	{
		E7007020("Birthday");
	}

	private void cbbTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_2 || cbbTinhTrang.SelectedValue == null || !GClass6.B62D3203(cbbTinhTrang.SelectedValue.ToString()) || (cbbTinhTrang.SelectedValue.ToString() != "-1" && AC974180 == cbbTinhTrang.SelectedIndex))
		{
			return;
		}
		string text = cbbThuMuc.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-1"))
		{
			if (!(text2 == "999999"))
			{
				FE1C1880(method_5(), cbbTinhTrang.Text);
			}
			else
			{
				FE1C1880(fChonThuMuc.list_0, cbbTinhTrang.Text);
			}
		}
		else
		{
			FE1C1880(null, cbbTinhTrang.Text);
		}
		AC974180 = cbbTinhTrang.SelectedIndex;
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		C93E4834(E43C18A6: false);
	}

	private void toolStripMenuItem_16_Click(object sender, EventArgs e)
	{
		method_90(4);
	}

	private void C585D73C(object sender, EventArgs e)
	{
	}

	private void BCBAFC26_Click(object sender, EventArgs e)
	{
		A6B2FC1C();
	}

	private void A6B2FC1C()
	{
		List<int> list_0 = new List<int>();
		for (int i = 0; i < method_109(); i++)
		{
			list_0.Add(0);
		}
		this.list_0 = new List<Thread>();
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						int int_0 = num++;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							int f0B = Common.F1924C3A(ref list_0);
							method_107(int_0, f0B);
						})
						{
							Name = int_0.ToString()
						};
						this.list_0.Add(thread2);
						thread2.IsBackground = true;
						thread2.Start();
					}
					else
					{
						num++;
					}
				}
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_, "LoginHotmail()");
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_107(int int_1, int F0B43922)
	{
		Chrome chrome = null;
		string text = method_117(int_1, "cEmail");
		string string_ = method_117(int_1, "cPassMail");
		string string_2 = SetupFolder.BF20001D(random_0);
		try
		{
			SetStatusAccount(int_1, Language.GetValue("Đang mơ\u0309 tri\u0300nh duyê\u0323t..."));
			Point b3B5AFAB = Common.AC17F101(F0B43922, 5, 2);
			Point point_ = Common.smethod_40(5, 2);
			bool flag = false;
			try
			{
				chrome = new Chrome
				{
					A58D4D9A = false,
					Point_0 = point_,
					B3B5AFAB = b3B5AFAB,
					Int32_1 = 3,
					Int32_2 = 60,
					String_0 = string_2
				};
				if (SettingsTool.GetSettings("configGeneral").method_0("typeBrowser") != 0)
				{
					chrome.String_3 = SettingsTool.GetSettings("configGeneral").GetValue("txtLinkToOtherBrowser");
				}
				if (!chrome.method_0())
				{
					SetStatusAccount(int_1, Language.GetValue("Lỗi mở trình duyệt!"));
					return;
				}
				SetStatusAccount(int_1, Language.GetValue("Đang đăng nhâ\u0323p..."));
				if (text.Contains("hotmail") || text.Contains("outlook"))
				{
					chrome.D920192A("https://login.live.com/login.srf");
					chrome.C2B42BB6(1.0);
					if (chrome.C6B3E9B0("[name=\"loginfmt\"]", 10.0) == 1)
					{
						chrome.method_17(2, "loginfmt", text);
						chrome.C2B42BB6(0.1);
						chrome.method_14(1, "idSIButton9");
						if (chrome.C6B3E9B0("[name=\"passwd\"]", 10.0) == 1)
						{
							chrome.C2B42BB6(2.0);
							chrome.method_17(2, "passwd", string_);
							chrome.C2B42BB6(2.0);
							chrome.method_14(1, "idSIButton9", 0, 0, "", 0, 10);
							for (int i = 0; i < 10; chrome.C2B42BB6(1.0), i++)
							{
								switch (chrome.method_26(0.0, "[name=\"DontShowAgain\"]", "#O365_MainLink_NavMenu"))
								{
								default:
									switch (chrome.method_26(0.0, "#idA_IL_ForgotPassword0", "[name=\"passwd\"]"))
									{
									case 2:
										SetStatusAccount(int_1, Language.GetValue("Không có pass mail!"));
										return;
									case 1:
										SetStatusAccount(int_1, Language.GetValue("Mail sai pass!"));
										return;
									}
									if (chrome.AB2275A9().Contains("https://account.live.com/Abuse"))
									{
										SetStatusAccount(int_1, Language.GetValue("Mail đã bị khóa!"));
										return;
									}
									continue;
								case 1:
									chrome.method_14(2, "DontShowAgain");
									chrome.C2B42BB6(0.1);
									chrome.method_14(1, "idSIButton9");
									break;
								case 2:
									break;
								}
								break;
							}
							if (!chrome.AB2275A9().StartsWith("https://outlook.live.com"))
							{
								chrome.D920192A("https://outlook.live.com/mail/0/");
							}
							flag = true;
						}
					}
				}
				else if (text.Contains("yandex"))
				{
					chrome.D920192A("https://passport.yandex.com/auth?from=mail&origin=hostroot_homer_auth_com&retpath=https%3A%2F%2Fmail.yandex.com%2F&backpath=https%3A%2F%2Fmail.yandex.com%3Fnoretpath%3D1");
					chrome.C2B42BB6(1.0);
					if (chrome.C6B3E9B0("#passp-field-login", 10.0) == 1)
					{
						chrome.method_17(1, "passp-field-login", text);
						chrome.C2B42BB6(0.1);
						chrome.method_14(4, ".Button2_type_submit");
						if (chrome.C6B3E9B0("#passp-field-passwd", 10.0) == 1)
						{
							chrome.method_17(1, "passp-field-passwd", string_);
							chrome.C2B42BB6(0.1);
							chrome.method_14(4, ".Button2_type_submit");
							while (true)
							{
								switch (chrome.method_26(10.0, ".mail-ComposeButton", ".Textinput-Hint_state_error", "[data-t=\"phone_skip\"]"))
								{
								case 3:
									goto IL_043e;
								case 1:
									flag = true;
									break;
								}
								break;
								IL_043e:
								chrome.C2B42BB6(1.0);
								chrome.method_14(4, "[data-t=\"phone_skip\"]");
								chrome.C2B42BB6(2.0);
							}
						}
					}
				}
				else
				{
					chrome.D920192A("https://outlook.office.com/mail/inbox");
					chrome.C2B42BB6(1.0);
					if (chrome.C6B3E9B0("[name=\"loginfmt\"]", 10.0) == 1)
					{
						chrome.method_17(2, "loginfmt", text);
						chrome.C2B42BB6(0.1);
						chrome.method_14(1, "idSIButton9");
						if (chrome.C6B3E9B0("[name=\"passwd\"]", 10.0) == 1)
						{
							chrome.method_17(2, "passwd", string_);
							chrome.C2B42BB6(2.0);
							chrome.method_14(1, "idSIButton9", 0, 0, "", 0, 10);
							int num = chrome.method_26(10.0, "[name=\"DontShowAgain\"]", "#O365_MainLink_NavMenu");
							int num2 = num;
							int num3 = num2;
							if (num3 == 1)
							{
								chrome.method_14(2, "DontShowAgain");
								chrome.C2B42BB6(0.1);
								chrome.method_14(1, "idSIButton9");
							}
							chrome.method_9("https://outlook.office.com/mail/inbox");
							flag = true;
						}
					}
				}
				if (flag)
				{
					SetStatusAccount(int_1, Language.GetValue("Đăng nhâ\u0323p thành công!"));
				}
			}
			catch (Exception exception_)
			{
				SetStatusAccount(int_1, Language.GetValue("Lô\u0303i đăng nhâ\u0323p!"));
				Common.ExportError(chrome, exception_, "Login Error!");
			}
		}
		catch (Exception exception_2)
		{
			SetStatusAccount(int_1, Language.GetValue("Lô\u0303i không xa\u0301c đi\u0323nh!"));
			Common.ExportError(chrome, exception_2);
		}
	}

	private void method_108(object sender, EventArgs e)
	{
		A28F9110();
	}

	private void A28F9110(int int_1 = 1)
	{
		try
		{
			for (int i = 0; i < int_1; i++)
			{
				if (dtgvAcc.RowCount <= 1)
				{
					continue;
				}
				List<DataGridViewRow> list = new List<DataGridViewRow>();
				foreach (DataGridViewRow item in (IEnumerable)dtgvAcc.Rows)
				{
					list.Add(item);
				}
				int num = list.Count;
				while (num > 1)
				{
					num--;
					int index = Base.rd.Next(num + 1);
					DataGridViewRow value = list[index];
					list[index] = list[num];
					list[num] = value;
				}
				dtgvAcc.Rows.Clear();
				foreach (DataGridViewRow item2 in list)
				{
					dtgvAcc.Rows.Add(item2);
				}
			}
		}
		catch
		{
		}
	}

	public int method_109()
	{
		int result = 0;
		try
		{
			result = Convert.ToInt32(lblCountSelect.Text);
		}
		catch
		{
		}
		return result;
	}

	private void A1BAEFBF(object sender, EventArgs e)
	{
		if (MessageBoxHelper.smethod_1(string.Format(Language.GetValue("Bạn có chắc muốn xóa dữ liệu backup của {0} tài khoản?"), method_109())) != DialogResult.Yes)
		{
			return;
		}
		int int_0 = 0;
		int int_1 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		Thread thread = new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int CDBDA38D = num++;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							SetStatusAccount(CDBDA38D, Language.GetValue("Đang xo\u0301a dữ liệu backup..."));
							method_110(CDBDA38D);
							Interlocked.Decrement(ref int_0);
						});
						thread2.IsBackground = true;
						thread2.Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_110(int int_1)
	{
		try
		{
			string f037F2B = dtgvAcc.Rows[int_1].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_1].Cells["cUid"].Value.ToString();
			if (text.Trim() == "")
			{
				SetStatusAccount(int_1, Language.GetValue("Chưa backup!"));
				return;
			}
			string path = "backup\\" + text;
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
				SetStatusAccount(int_1, Language.GetValue("Xóa dữ liệu backup thành công!"));
				SetCellAccount(int_1, "cBackup", "");
				CommonSQL.UpdateFieldToAccount(f037F2B, "backup", "");
			}
			else
			{
				SetStatusAccount(int_1, Language.GetValue("Chưa backup!"));
			}
		}
		catch
		{
			SetStatusAccount(int_1, Language.GetValue("Xóa dữ liệu backup thất bại!"));
		}
	}

	private void method_111(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = 10;
		string string_0 = E3A31B0C.smethod_0();
		Thread thread = new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int C42E7024 = num++;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							SetStatusAccount(C42E7024, "Check backup...");
							A3241717(C42E7024, string_0);
							Interlocked.Decrement(ref int_0);
						});
						thread2.IsBackground = true;
						thread2.Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void A3241717(int int_1, string string_0)
	{
		try
		{
			string f037F2B = dtgvAcc.Rows[int_1].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_1].Cells["cUid"].Value.ToString();
			string_0 = string_0 + "\\" + text + "\\" + text + ".txt";
			if (File.Exists(string_0))
			{
				SetStatusAccount(int_1, Language.GetValue("Đã backup!"));
				SetCellAccount(int_1, "cBackup", Common.smethod_8(string_0));
				CommonSQL.UpdateFieldToAccount(f037F2B, "backup", Common.smethod_8(string_0));
			}
			else
			{
				SetStatusAccount(int_1, Language.GetValue("Chưa backup!"));
				SetCellAccount(int_1, "cBackup", "");
				CommonSQL.UpdateFieldToAccount(f037F2B, "backup", "");
			}
		}
		catch
		{
		}
	}

	private void checkInfoUIDToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_90(5);
	}

	private void C7236B08(object sender, EventArgs e)
	{
		Common.smethod_16(new fNhapTokenTrungGian_DownAvatar());
		if (!fNhapTokenTrungGian_DownAvatar.A0064D3F)
		{
			return;
		}
		string C419ABA3 = SettingsTool.GetSettings("configGeneral").GetValue("pathFolderAvatar");
		if (!Directory.Exists(C419ABA3))
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lòng kiểm tra lại Nơi lưu Avatar!"), 2);
			return;
		}
		int int_0 = 0;
		int B188EA1F = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		bool_0 = false;
		Thread thread = new Thread((ThreadStart)delegate
		{
			method_88("start");
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < B188EA1F)
					{
						Interlocked.Increment(ref int_0);
						int int_ = num++;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							SetStatusAccount(int_, Language.GetValue("Đang kiểm tra..."));
							method_112(int_, C419ABA3);
							Interlocked.Decrement(ref int_0);
						});
						thread2.IsBackground = true;
						thread2.Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			method_88("stop");
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_112(int B4086D28, string F3A3BFA2)
	{
		try
		{
			string string_ = dtgvAcc.Rows[B4086D28].Cells["cUid"].Value.ToString();
			dtgvAcc.Rows[B4086D28].Cells["cId"].Value.ToString();
			if (EA98BF20.EDB6C3A3(string_, F3A3BFA2))
			{
				SetStatusAccount(B4086D28, Language.GetValue("Tải xuống thành công!"));
			}
			else
			{
				SetStatusAccount(B4086D28, Language.GetValue("Tải xuống thất bại!"));
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "DownloadAvatar");
			SetStatusAccount(B4086D28, Language.GetValue("Tải xuống thất bại!"));
		}
	}

	private void toolStripMenuItem_18_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fBin());
	}

	private void toolStripMenuItem_19_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fTienIchLocTrung());
	}

	private void E1230328(object sender, EventArgs e)
	{
		try
		{
			Process.Start("chrome.exe", "http://app.minsoftware.xyz/textfree.html");
		}
		catch
		{
			Process.Start("http://app.minsoftware.xyz/textfree.html");
		}
	}

	private void BD830A36(object sender, EventArgs e)
	{
	}

	private void F224AEB0(object sender, EventArgs e)
	{
		Common.smethod_16(new fTienIchCheckImapHotmail());
	}

	private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (e.RowIndex > -1)
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
				BA332092();
			}
		}
		catch
		{
		}
	}

	private void btnEditFile_Click(object sender, EventArgs e)
	{
		List<string> list = method_5();
		if (list != null && list.Count == 1)
		{
			fEditFile fEditFile2 = new fEditFile(list[0], cbbThuMuc.Text);
			fEditFile2.ShowInTaskbar = false;
			fEditFile2.ShowDialog();
			int selectedIndex = cbbThuMuc.SelectedIndex;
			if (fEditFile2.bool_0)
			{
				method_4();
				int_0 = -1;
				cbbThuMuc.SelectedIndex = selectedIndex;
			}
		}
	}

	private void BE3278AB_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fTienIchCheckProxy());
	}

	private void toolStripMenuItem_21_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fNhapCookieTrungGian());
		if (fNhapCookieTrungGian.bool_0)
		{
			E3B585B5(4);
		}
	}

	private void D9BD898F(object sender, EventArgs e)
	{
		fLocTheoDanhSachUid fLocTheoDanhSachUid2 = new fLocTheoDanhSachUid();
		Common.smethod_16(fLocTheoDanhSachUid2);
		if (fLocTheoDanhSachUid2.list_0.Count > 0)
		{
			List<string> list = Common.smethod_11(fLocTheoDanhSachUid2.list_0);
			DataTable dataTable_ = CommonSQL.B01A5A9E(list);
			dtgvAcc.Rows.Clear();
			D135A89E(dataTable_);
		}
	}

	private void DF3C6D09(object sender, EventArgs e)
	{
		Common.smethod_16(new fCauHinhTuongTac());
	}

	public void SetStatusAccount(int int_1, string string_0, int int_2 = 0, AC28BD29 DE86C211 = null)
	{
		if (DE86C211 != null)
		{
			if (SettingsTool.GetSettings("configDebug").AA824D29("ckbLoginFail") && (string_0.Contains(Language.GetValue("Đăng nhập thất bại!")) || string_0.Contains("Login fail")))
			{
				DE86C211.method_123("LoginFail");
			}
			else if (SettingsTool.GetSettings("configDebug").AA824D29("ckbCheckSpam") && string_0.Contains("Facebook Spam"))
			{
				DE86C211.method_123("FacebookSpam");
			}
		}
		if (int_2 > 0)
		{
			DatagridviewHelper.B52BC1AA(dtgvAcc, int_1, "cStatus", int_2, string_0);
		}
		else
		{
			DatagridviewHelper.AD3DF791(dtgvAcc, int_1, "cStatus", string_0);
		}
	}

	public void CC1905A5(int ADA8F389, string DEA7EC94, AC28BD29 ac28BD29_0 = null)
	{
		if (ac28BD29_0 != null)
		{
			if (DEA7EC94.Contains("Checkpoint") && SettingsTool.GetSettings("configDebug").AA824D29("ckbCheckpoint"))
			{
				ac28BD29_0.method_123("Checkpoint");
			}
			else if (DEA7EC94.Contains("Changed pass") && SettingsTool.GetSettings("configDebug").AA824D29("ckbChangedPass"))
			{
				ac28BD29_0.method_123("ChangedPass");
			}
		}
		DatagridviewHelper.AD3DF791(dtgvAcc, ADA8F389, "cInfo", DEA7EC94);
		method_119(ADA8F389);
		CommonSQL.UpdateFieldToAccount(method_117(ADA8F389, "cId"), "info", DEA7EC94);
	}

	public void SetCellAccount(int int_1, string ED14F6A5, object object_11, bool bool_4 = true)
	{
		if (bool_4 || !(object_11.ToString().Trim() == ""))
		{
			DatagridviewHelper.AD3DF791(dtgvAcc, int_1, ED14F6A5, object_11);
		}
	}

	public void method_114(int CC0A7323, string string_0, string D10DACA2, string string_1, bool bool_4 = true)
	{
		if (bool_4 || !(D10DACA2.ToString().Trim() == ""))
		{
			DatagridviewHelper.AD3DF791(dtgvAcc, CC0A7323, string_0, D10DACA2);
			CommonSQL.UpdateFieldToAccount(method_117(CC0A7323, "cId"), string_1, D10DACA2);
		}
	}

	public void method_115(int FA33AB23, int ECA36C95, object CEA5FE30)
	{
		DatagridviewHelper.smethod_1(dtgvAcc, FA33AB23, ECA36C95, CEA5FE30);
	}

	public string method_116(int int_1)
	{
		string text = DatagridviewHelper.E83E252C(dtgvAcc, int_1, "cStatus");
		if (text.StartsWith("("))
		{
			return text.Substring(text.IndexOf(')') + 1).Trim();
		}
		return text;
	}

	public string F08831A5(int int_1)
	{
		return DatagridviewHelper.E83E252C(dtgvAcc, int_1, "cInfo");
	}

	public string method_117(int int_1, string string_0)
	{
		return DatagridviewHelper.E83E252C(dtgvAcc, int_1, string_0);
	}

	public string method_118(int int_1, int int_2)
	{
		return DatagridviewHelper.smethod_0(dtgvAcc, int_1, int_2);
	}

	private void method_119(int E895431A = -1)
	{
		if (SettingsTool.GetSettings("configGeneral").method_0("typePhanBietMau") == 0)
		{
			if (E895431A == -1)
			{
				for (int i = 0; i < dtgvAcc.RowCount; i++)
				{
					string text = F08831A5(i);
					if (text == "Live")
					{
						dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					}
					else if (text.Contains("Die") || text.Contains("Checkpoint") || text.Contains("Changed pass"))
					{
						dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
					}
				}
			}
			else
			{
				string text2 = F08831A5(E895431A);
				if (text2 == "Live")
				{
					dtgvAcc.Rows[E895431A].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
				}
				else if (text2.Contains("Die") || text2.Contains("Checkpoint") || text2.Contains("Changed pass"))
				{
					dtgvAcc.Rows[E895431A].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
				}
			}
		}
		else if (E895431A == -1)
		{
			for (int j = 0; j < dtgvAcc.RowCount; j++)
			{
				string text3 = F08831A5(j);
				if (text3 == "Live")
				{
					dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Green;
				}
				else if (text3.Contains("Die") || text3.Contains(Language.GetValue("Checkpoint")) || text3.Contains("Changed pass"))
				{
					dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Red;
				}
			}
		}
		else
		{
			string text4 = F08831A5(E895431A);
			if (text4 == "Live")
			{
				dtgvAcc.Rows[E895431A].DefaultCellStyle.ForeColor = Color.Green;
			}
			else if (text4.Contains("Die") || text4.Contains(Language.GetValue("Checkpoint")) || text4.Contains("Changed pass"))
			{
				dtgvAcc.Rows[E895431A].DefaultCellStyle.ForeColor = Color.Red;
			}
		}
	}

	private void method_120(int int_1, int int_2)
	{
		switch (int_2)
		{
		case 2:
			dtgvAcc.Rows[int_1].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
			break;
		case 1:
			dtgvAcc.Rows[int_1].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
			break;
		}
	}

	private void method_121()
	{
		dtgvAcc.Columns["cToken"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("cToken");
		dtgvAcc.Columns["cCookies"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbCookie");
		dtgvAcc.Columns["cEmail"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbEmail");
		dtgvAcc.Columns["cName"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbTen");
		dtgvAcc.Columns["cFriend"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbBanBe");
		dtgvAcc.Columns["cGroup"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbNhom");
		dtgvAcc.Columns["cBirthday"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbNgaySinh");
		dtgvAcc.Columns["cGender"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbGioiTinh");
		dtgvAcc.Columns["cPassword"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbMatKhau");
		dtgvAcc.Columns["cPassMail"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbMatKhauMail");
		dtgvAcc.Columns["cPhone"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbPhone");
		dtgvAcc.Columns["cBackup"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbBackup");
		dtgvAcc.Columns["cFa2"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbMa2FA");
		dtgvAcc.Columns["cUseragent"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbUseragent");
		dtgvAcc.Columns["cProxy"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbProxy");
		dtgvAcc.Columns["cDateCreateAcc"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbNgayTao");
		dtgvAcc.Columns["cAvatar"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbAvatar");
		dtgvAcc.Columns["cProfile"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbProfile");
		dtgvAcc.Columns["cInfo"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbTinhTrang");
		dtgvAcc.Columns["cThuMuc"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbThuMuc");
		dtgvAcc.Columns["cGhiChu"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbGhiChu");
		dtgvAcc.Columns["cFollow"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbFollow");
		dtgvAcc.Columns["cInteractEnd"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbInteractEnd");
		dtgvAcc.Columns["cDevice"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbDevice");
	}

	private void E536F13B(object sender, EventArgs e)
	{
		Common.smethod_16(new fCapNhatDuLieu());
		if (fCapNhatDuLieu.bool_0)
		{
			FA986092(null, null);
		}
	}

	private void E4A13219_Click(object sender, EventArgs e)
	{
		A6B2FC1C();
	}

	private void dtgvAcc_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (bool_3 && e.ColumnIndex == 0)
		{
			BA332092();
		}
	}

	private void method_122(string DD8DB3B8)
	{
		Common.smethod_16(new fSelectFolder());
		string string_ = fSelectFolder.string_0;
		if (string_ == "")
		{
			return;
		}
		List<string> list = new List<string>();
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			try
			{
				if (Convert.ToBoolean(method_117(i, "cChose")))
				{
					string text = method_117(i, "cUid");
					list.Add(DD8DB3B8 + "\\" + text + "|" + string_ + "\\" + text);
				}
			}
			catch
			{
			}
		}
		if (list.Count > 0)
		{
			Common.smethod_16(new fShowProgressBar(list));
			MessageBoxHelper.Show(Language.GetValue("Đa\u0303 copy dư\u0303 liê\u0323u xong!"));
		}
	}

	private void B827020A(object sender, EventArgs e)
	{
		Common.smethod_16(new fTienIchCheckLiveUid());
	}

	private void D4129739_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fContact());
	}

	private void method_123(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = 10;
		Thread thread = new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.RowCount)
			{
				if (Convert.ToBoolean(method_117(num, "cChose")))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int DF075A2D = num++;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							SetStatusAccount(DF075A2D, "Check profile LD...");
							method_124(DF075A2D);
							Interlocked.Decrement(ref int_0);
						});
						thread2.IsBackground = true;
						thread2.Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_124(int int_1)
	{
		try
		{
			string f037F2B = method_117(int_1, "cId");
			string text = method_117(int_1, "cUid");
			string text2 = FileHelper.GetPathToCurrentFolder() + "\\profile\\" + text;
			string path = text2 + "\\data.tar.gz";
			string path2 = text2 + ".zip";
			if (File.Exists(path) || File.Exists(path2))
			{
				SetStatusAccount(int_1, Language.GetValue("Đã backup LD!"));
				SetCellAccount(int_1, "cProfile", "Yes");
				CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "Yes");
			}
			else
			{
				SetStatusAccount(int_1, Language.GetValue("Chưa backup LD!"));
				SetCellAccount(int_1, "cProfile", "No");
				CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "No");
			}
		}
		catch
		{
		}
	}

	private void method_125(int E9A90610)
	{
		try
		{
			string f037F2B = method_117(E9A90610, "cId");
			string text = method_117(E9A90610, "cUid");
			string text2 = FileHelper.GetPathToCurrentFolder() + "\\profile\\" + text + ".tar.gz";
			if (!File.Exists(text2))
			{
				SetStatusAccount(E9A90610, Language.GetValue("Chưa backup data app Fb!"));
				SetCellAccount(E9A90610, "cProfile", "No");
				CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "No");
			}
			SetStatusAccount(E9A90610, "Get token/cookie...");
			string text3 = Common.GetTokenCookie(text2);
			if (text3 != "|" && text3 != "")
			{
				string text4 = text3.Split('|')[0];
				string text5 = text3.Split('|')[1];
				if (text4 != "")
				{
					method_114(E9A90610, "cToken", text4, "token");
				}
				if (text5 != "")
				{
					method_114(E9A90610, "cCookies", text5, "cookie1");
				}
				SetStatusAccount(E9A90610, Language.GetValue("Đã cập nhật token/cookie!"));
			}
			else
			{
				SetStatusAccount(E9A90610, Language.GetValue("Không lấy được token/cookie!"));
			}
		}
		catch
		{
			SetStatusAccount(E9A90610, Language.GetValue("Không lấy được token/cookie!"));
		}
	}

	public string method_126(string string_0)
	{
		string path = Path.Combine(string_0, "data.vmdk");
		string text = "";
		string text2 = "";
		string result = "";
		if (File.Exists(path))
		{
			using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using BufferedStream stream2 = new BufferedStream(stream);
				using StreamReader streamReader = new StreamReader(stream2);
				string text3;
				while ((text3 = streamReader.ReadLine()) != null)
				{
					if (!text3.Contains("access_token\":\""))
					{
						if (text3.Contains("accessToken\":\""))
						{
							string text4 = Regex.Split(text3, "accessToken\":\"")[1].Split('"')[0];
							Console.WriteLine(text4);
							text = text4;
							if (text2 != "" && text != "")
							{
								break;
							}
						}
						else
						{
							if (!text3.Contains("[{\"name\":\"c_user\""))
							{
								continue;
							}
							string json = "[{\"name\":\"c_user\"" + text3.Split(new string[1] { "[{\"name\":\"c_user\"" }, StringSplitOptions.None)[1].Split(']')[0].Replace("\\\"", "\"") + "]";
							JArray jArray = JArray.Parse(json);
							List<string> list = new List<string>();
							foreach (JToken item in jArray)
							{
								list.Add(item["name"]!.ToString() + "=" + item["value"]!.ToString());
							}
							string text5 = string.Join("; ", list);
							text2 = text5;
							if (text2 != "" && text != "")
							{
								break;
							}
						}
						continue;
					}
					string text6 = Regex.Split(text3, "access_token\":\"")[1].Split('"')[0];
					text = text6;
					string json2 = Regex.Split(text3, "session_cookie_string\":\"")[1].Split(']')[0].Replace("\\\"", "\"") + "]";
					JArray jArray2 = JArray.Parse(json2);
					List<string> list2 = new List<string>();
					foreach (JToken item2 in jArray2)
					{
						list2.Add(item2["name"]!.ToString() + "=" + item2["value"]!.ToString());
					}
					string text7 = string.Join("; ", list2);
					text2 = text7;
					break;
				}
			}
			result = text + "|" + text2;
		}
		return result;
	}

	private void B2125829(object sender, EventArgs e)
	{
		try
		{
			if (method_109() == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn tài khoản muốn chạy!"), 3);
				return;
			}
			string string_0 = E3A31B0C.smethod_1(1);
			if (string_0 == "")
			{
				MessageBoxHelper.Show(Language.GetValue("Đường dẫn LDPlayer trống!"), 3);
				return;
			}
			if (!Directory.Exists(string_0))
			{
				MessageBoxHelper.Show(Language.GetValue("Đường dẫn LDPlayer không hợp lệ!"), 3);
				return;
			}
			method_88("start");
			int int_0 = 0;
			int int_1 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
			bool_0 = false;
			Thread thread = new Thread((ThreadStart)delegate
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count && !bool_0)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (int_0 < int_1)
						{
							Interlocked.Increment(ref int_0);
							int int_2 = num++;
							Thread thread2 = new Thread((ThreadStart)delegate
							{
								SetStatusAccount(int_2, Language.GetValue("Đang check..."));
								C00D9803(int_2, string_0);
								Interlocked.Decrement(ref int_0);
							});
							thread2.IsBackground = true;
							thread2.Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
				method_88("stop");
			});
			thread.IsBackground = true;
			thread.Start();
		}
		catch
		{
		}
	}

	private void C00D9803(int CC04B994, string BF385EA6)
	{
		string string_ = method_117(CC04B994, "cId");
		string text = method_117(CC04B994, "cDevice");
		if (text != "" && Directory.Exists(BF385EA6 + "\\vms\\leidian" + text))
		{
			try
			{
				SetStatusAccount(CC04B994, Language.GetValue("Đang xo\u0301a LDPlayer..."));
				Directory.Delete(BF385EA6 + "\\vms\\leidian" + text, recursive: true);
				SetCellAccount(CC04B994, "cDevice", "");
				CommonSQL.smethod_9(string_, "device", "");
				SetStatusAccount(CC04B994, Language.GetValue("Xóa LDPlayer thành công!"));
			}
			catch
			{
				SetStatusAccount(CC04B994, Language.GetValue("Xóa LDPlayer thất bại!"));
			}
		}
		else
		{
			SetStatusAccount(CC04B994, Language.GetValue("Chưa tạo LDPlayer!"));
		}
	}

	private void BBBC911D(object sender, EventArgs e)
	{
	}

	private void dtgvAcc_SelectionChanged(object sender, EventArgs e)
	{
		CCACF12E.Text = dtgvAcc.SelectedRows.Count.ToString();
	}

	private void FD240F92(object sender, EventArgs e)
	{
		Common.smethod_16(new fTienIchCheckStatusXProxy());
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void method_127(object sender, EventArgs e)
	{
		if (MessageBoxHelper.smethod_1(string.Format(Language.GetValue("Bạn có chắc muốn xóa file backup info device của {0} tài khoản?"), method_109())) != DialogResult.Yes)
		{
			return;
		}
		int int_0 = 0;
		int int_1 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		Thread thread = new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							SetStatusAccount(int_2, Language.GetValue("Đang xo\u0301a backup device..."));
							method_128(int_2);
							Interlocked.Decrement(ref int_0);
						});
						thread2.IsBackground = true;
						thread2.Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_128(int int_1)
	{
		try
		{
			dtgvAcc.Rows[int_1].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_1].Cells["cUid"].Value.ToString();
			string path = FileHelper.GetPathToCurrentFolder() + "\\device\\" + text;
			if (text.Trim() == "")
			{
				SetStatusAccount(int_1, Language.GetValue("Chưa backup device!"));
			}
			else if (Directory.Exists(path))
			{
				try
				{
					Directory.Delete(path, recursive: true);
					SetStatusAccount(int_1, Language.GetValue("Xóa backup device thành công!"));
				}
				catch
				{
					SetStatusAccount(int_1, Language.GetValue("Xóa backup device thâ\u0301t ba\u0323i!"));
				}
			}
			else
			{
				SetStatusAccount(int_1, Language.GetValue("Chưa backup device!"));
			}
		}
		catch
		{
			SetStatusAccount(int_1, Language.GetValue("Xóa backup device thất bại!"));
		}
	}

	private void method_129(string string_0, JSON_Settings f72FAFBC_0 = null)
	{
		int E7A5679F = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		string string_2 = "";
		if (string_0 == "CopyBackupDataFb" || string_0 == "CopyDataDevice")
		{
			string_2 = Common.F68F9C11();
			if (string_2 == "")
			{
				return;
			}
		}
		string string_1 = "";
		string A63F7D94 = "";
		if (string_0 == "TaoThuMucMedia")
		{
			E7A5679F = 1;
			string_1 = f72FAFBC_0.GetValue("txtFolderMedia");
			A63F7D94 = f72FAFBC_0.GetValue("txtFolderSave");
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			List<Thread> list = new List<Thread>();
			int num = 0;
			while (num < dtgvAcc.RowCount)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					while (list.Count >= E7A5679F)
					{
						Common.DelayTime(1.0);
						for (int i = 0; i < list.Count; i++)
						{
							list[i].Join();
							list.RemoveAt(i--);
						}
					}
					int int_0 = num++;
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						string text = string_0;
						string text2 = text;
						switch (HashString.DA8CEBAB(text2))
						{
						case 149233318u:
							if (text2 == "CopyDataDevice")
							{
								method_134(int_0, string_2);
							}
							break;
						case 5199931u:
							if (text2 == "CheckBackupDevice")
							{
								method_131(int_0);
							}
							break;
						case 1824901299u:
							if (text2 == "TaoThuMucMedia")
							{
								method_135(int_0, string_1, A63F7D94);
							}
							break;
						case 1338799404u:
							if (text2 == "DeleteDataDevice")
							{
								method_133(int_0);
							}
							break;
						case 1214579449u:
							if (text2 == "CheckBackupDataFb")
							{
								method_130(int_0);
							}
							break;
						case 2616307503u:
							if (text2 == "DeleteBackupGroup")
							{
								method_132(int_0);
							}
							break;
						case 1827507468u:
							if (text2 == "DeleteBackupDataFb")
							{
								E92F6895(int_0);
							}
							break;
						case 4016774266u:
							if (text2 == "GetTokenCookie")
							{
								method_125(int_0);
							}
							break;
						case 3276978916u:
							if (text2 == "CheckBackupGroup")
							{
								DC10692F(int_0);
							}
							break;
						case 2851902418u:
							if (text2 == "CopyBackupDataFb")
							{
								AA9C8BB2(int_0, string_2);
							}
							break;
						}
					});
					list.Add(thread2);
					thread2.IsBackground = true;
					thread2.Start();
				}
				else
				{
					num++;
				}
			}
			for (int j = 0; j < list.Count; j++)
			{
				list[j].Join();
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_130(int int_1)
	{
		string f037F2B = method_117(int_1, "cId");
		string text = method_117(int_1, "cUid");
		string path = FileHelper.GetPathToCurrentFolder() + "\\profile\\" + text + ".tar.gz";
		if (File.Exists(path))
		{
			SetStatusAccount(int_1, Language.GetValue("Đã backup data app Fb!"));
			SetCellAccount(int_1, "cProfile", "Yes");
			CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "Yes");
		}
		else
		{
			SetStatusAccount(int_1, Language.GetValue("Chưa backup data app Fb!"));
			SetCellAccount(int_1, "cProfile", "No");
			CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "No");
		}
	}

	private void method_131(int int_1)
	{
		method_117(int_1, "cId");
		string text = method_117(int_1, "cUid");
		string path = FileHelper.GetPathToCurrentFolder() + "\\device\\" + text + ".tar.gz";
		if (File.Exists(path))
		{
			SetStatusAccount(int_1, Language.GetValue("Đã backup info device!"));
		}
		else
		{
			SetStatusAccount(int_1, Language.GetValue("Chưa backup info device!"));
		}
	}

	private void E92F6895(int int_1)
	{
		string f037F2B = method_117(int_1, "cId");
		string text = method_117(int_1, "cUid");
		string text2 = FileHelper.GetPathToCurrentFolder() + "\\profile\\" + text + ".tar.gz";
		if (File.Exists(text2))
		{
			if (Common.smethod_49(text2))
			{
				SetStatusAccount(int_1, Language.GetValue("Xóa data app Fb thành công!"));
				SetCellAccount(int_1, "cProfile", "No");
				CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "No");
			}
			else
			{
				SetStatusAccount(int_1, Language.GetValue("Xóa data app Fb thất bại!"));
			}
		}
		else
		{
			SetStatusAccount(int_1, Language.GetValue("Chưa backup data app Fb!"));
			SetCellAccount(int_1, "cProfile", "No");
			CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "No");
		}
	}

	private void DC10692F(int int_1)
	{
		method_117(int_1, "cId");
		string text = method_117(int_1, "cUid");
		string path = FileHelper.GetPathToCurrentFolder() + "\\backupgroup\\" + text + ".txt";
		if (File.Exists(path))
		{
			SetStatusAccount(int_1, Language.GetValue("Đã backup group!"));
		}
		else
		{
			SetStatusAccount(int_1, Language.GetValue("Chưa backup group!"));
		}
	}

	private void method_132(int D3AD9A9E)
	{
		method_117(D3AD9A9E, "cId");
		string text = method_117(D3AD9A9E, "cUid");
		string text2 = FileHelper.GetPathToCurrentFolder() + "\\backupgroup\\" + text + ".txt";
		if (File.Exists(text2))
		{
			if (Common.smethod_49(text2))
			{
				SetStatusAccount(D3AD9A9E, Language.GetValue("Xóa data backup group thành công!"));
			}
			else
			{
				SetStatusAccount(D3AD9A9E, Language.GetValue("Xóa data backup group thất bại!"));
			}
		}
		else
		{
			SetStatusAccount(D3AD9A9E, Language.GetValue("Chưa backup group!"));
		}
	}

	private void method_133(int C903FA1F)
	{
		method_117(C903FA1F, "cId");
		string text = method_117(C903FA1F, "cUid");
		string text2 = FileHelper.GetPathToCurrentFolder() + "\\device\\" + text + ".tar.gz";
		if (File.Exists(text2))
		{
			if (Common.smethod_49(text2))
			{
				SetStatusAccount(C903FA1F, Language.GetValue("Đã xóa data device!"));
			}
			else
			{
				SetStatusAccount(C903FA1F, Language.GetValue("Xóa data device thất bại!"));
			}
		}
		else
		{
			SetStatusAccount(C903FA1F, Language.GetValue("Chưa có data device!"));
		}
	}

	private void AA9C8BB2(int BE296E98, string A41BA59F)
	{
		method_117(BE296E98, "cId");
		string text = method_117(BE296E98, "cUid");
		string text2 = FileHelper.GetPathToCurrentFolder() + "\\profile\\" + text + ".tar.gz";
		string c398043D = A41BA59F + "\\" + text + ".tar.gz";
		if (File.Exists(text2))
		{
			if (Common.smethod_47(text2, c398043D))
			{
				SetStatusAccount(BE296E98, "Copy data app Fb " + Language.GetValue("thành công") + "!");
			}
			else
			{
				SetStatusAccount(BE296E98, "Copy data app Fb " + Language.GetValue("thất bại") + "!");
			}
		}
		else
		{
			SetStatusAccount(BE296E98, Language.GetValue("Chưa backup data app Fb!"));
			method_114(BE296E98, "cProfile", "No", "profile");
		}
	}

	private void method_134(int int_1, string string_0)
	{
		method_117(int_1, "cId");
		string text = method_117(int_1, "cUid");
		string text2 = FileHelper.GetPathToCurrentFolder() + "\\device\\" + text + ".tar.gz";
		string c398043D = string_0 + "\\" + text + ".tar.gz";
		if (File.Exists(text2))
		{
			if (Common.smethod_47(text2, c398043D))
			{
				SetStatusAccount(int_1, "Copy data device " + Language.GetValue("thành công") + "!");
			}
			else
			{
				SetStatusAccount(int_1, "Copy data device " + Language.GetValue("thất bại") + "!");
			}
		}
		else
		{
			SetStatusAccount(int_1, Language.GetValue("Chưa có data device!"));
		}
	}

	private void method_135(int C0179317, string string_0, string string_1)
	{
		try
		{
			string text = method_117(C0179317, "cUid");
			string_1 = string_1 + "\\" + text;
			Common.smethod_48(string_0, string_1);
			SetStatusAccount(C0179317, Language.GetValue("Tạo thành công!"));
		}
		catch
		{
			SetStatusAccount(C0179317, Language.GetValue("Tạo thất bại!"));
		}
	}

	private void D6A2308D(object sender, EventArgs e)
	{
		if (method_109() == 0)
		{
			MessageBoxHelper.Show(Language.GetValue("Vui lo\u0300ng cho\u0323n như\u0303ng ta\u0300i khoa\u0309n muô\u0301n nhâ\u0323p Proxy!"), 3);
		}
		else
		{
			Common.smethod_16(new fImportProxy());
		}
	}

	private void A8A0C01B(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				dtgvAcc.Rows.RemoveAt(i--);
			}
		}
		method_95();
		method_89();
		BA332092(0);
	}

	public bool FA905AA0(AC28BD29 AD2DE885, int int_1, string string_0, string string_1)
	{
		while (true)
		{
			AD2DE885.method_69(string_1);
			AD2DE885.TimeDelay(2.0);
			if (string_1.StartsWith("fb://page/") && !string_1.Contains("invite_friends_to_like_page"))
			{
				AD2DE885.TimeDelay(3.0);
				for (int i = 0; i < 5; i++)
				{
					string string_2 = "";
					string text = AD2DE885.CB3C4B8A(5, ref string_2, new List<string> { "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View", "//*[@content-desc='Create Action Button']", "//*[@content-desc='Follow']", "(//android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.widget.LinearLayout/android.view.ViewGroup/android.view.ViewGroup)[last()]/child::*", "//*[@content-desc='page cover photo']" });
					if (text == "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View")
					{
						string dB31F = AD2DE885.FindElements(0, string_2, "//android.view.ViewGroup/android.widget.FrameLayout/android.view.View").FirstOrDefault();
						if (new Class65(dB31F).B9898119 >= 2000)
						{
							break;
						}
						Class65 @class = new Class65(dB31F);
						Class65 class2 = new Class65(@class.int_0, 2000, @class.int_1, 2000);
						AD2DE885.method_52(@class.AA3F9A29(), class2.AA3F9A29());
						continue;
					}
					if (text != "")
					{
						break;
					}
					if (AD2DE885.method_104(string_2).Count != 2 || !AD2DE885.method_104(string_2).Contains("Back".ToLower()) || !AD2DE885.method_104(string_2).Contains("Search".ToLower()))
					{
						if (AD2DE885.CE16082B())
						{
							break;
						}
						continue;
					}
					goto IL_015a;
				}
			}
			if (string_1.Contains("/stories/") && AD2DE885.DoesElementExist(150, "", "(//*[@text='Stories'])[2]"))
			{
				break;
			}
			switch (method_22(AD2DE885, int_1, string_0))
			{
			case 1:
				break;
			default:
				return false;
			case 0:
				return true;
			}
			continue;
			IL_015a:
			AD2DE885.method_19();
			AD2DE885.TimeDelay(2.0);
		}
		return true;
	}

	private void A2A61088(object sender, EventArgs e)
	{
		method_18(2);
	}

	private void CBA74584(object sender, EventArgs e)
	{
		if (picLanguage.Image == bitmap_0)
		{
			picLanguage.Image = bitmap_1;
			Base.C891C93E();
			MessageBoxHelper.Show("Vui lòng mở lại phần mềm để cập nhật ngôn ngữ!");
		}
		else
		{
			picLanguage.Image = bitmap_0;
			Base.C891C93E("EN");
		}
		Base.smethod_0();
		method_0();
	}

	private void copyDataDeviceToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_129("CopyDataDevice");
	}

	private void E231CC2B(object sender, EventArgs e)
	{
		method_129("DeleteDataDevice");
	}

	private void C6ACE49D(object sender, EventArgs e)
	{
		try
		{
			Common.smethod_16(new fClearProfile());
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show(ex.ToString(), 3);
		}
	}

	private void F70A3E16(object sender, EventArgs e)
	{
		method_18(3);
	}

	private void AF8E5F17_Click(object sender, EventArgs e)
	{
		method_18(4);
	}

	private void toolStripMenuItem_26_Click(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		bool_0 = false;
		Thread thread = new Thread((ThreadStart)delegate
		{
			method_88("start");
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (bool_0)
				{
					break;
				}
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int B9ADC9B3 = num++;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							string text = method_117(B9ADC9B3, "cBirthday");
							string text2 = Common.AC063C3B(text);
							if (text2 != "")
							{
								if (text2 != text)
								{
									method_114(B9ADC9B3, "cBirthday", text2, "birthday");
								}
								SetStatusAccount(B9ADC9B3, "Convert success!");
							}
							else
							{
								SetStatusAccount(B9ADC9B3, "Convert fail!");
							}
							Interlocked.Decrement(ref int_0);
						});
						thread2.IsBackground = true;
						thread2.Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			method_88("stop");
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void B21A5106(object sender, EventArgs e)
	{
		A29C1486++;
		if (A29C1486 >= 3)
		{
			A29C1486 = 0;
			new fCauHinhDebug().ShowDialog();
		}
	}

	private void unlockCheckpointToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_18(5);
	}

	private void checkFileBackupGroupToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_129("CheckBackupGroup");
	}

	private void C3A395AA(object sender, EventArgs e)
	{
		method_129("DeleteBackupGroup");
	}

	private void backupGroupToolStripMenuItem_Click(object sender, EventArgs e)
	{
		fCauHinhBackupGroup fCauHinhBackupGroup2 = new fCauHinhBackupGroup();
		Common.smethod_16(fCauHinhBackupGroup2);
		if (fCauHinhBackupGroup2.DA885494)
		{
			if (SettingsTool.GetSettings("configBackupGroup").method_0("typeRun") == 0)
			{
				method_18(6, bool_4: false, SettingsTool.GetSettings("configBackupGroup"));
			}
			else if (SettingsTool.GetSettings("configBackupGroup").method_0("typeRun") == 1)
			{
			}
		}
	}

	private void toolStripMenuItem_27_Click(object sender, EventArgs e)
	{
		fLocTheoDanhSachUid fLocTheoDanhSachUid2 = new fLocTheoDanhSachUid();
		Common.smethod_16(fLocTheoDanhSachUid2);
		if (fLocTheoDanhSachUid2.list_0.Count > 0)
		{
			List<string> list = Common.smethod_11(fLocTheoDanhSachUid2.list_0);
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				string item = method_117(i, "cUid");
				string item2 = method_117(i, "cEmail");
				SetCellAccount(i, "cChose", list.Contains(item) || list.Contains(item2));
			}
			BA332092();
		}
	}

	private void B8845BA6(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		int num = 0;
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				continue;
			}
			try
			{
				string item = method_117(i, "cUid");
				if (list2.Contains(item))
				{
					list.Add(dtgvAcc.Rows[i].Cells["cId"].Value.ToString());
					dtgvAcc.Rows.RemoveAt(i);
					i--;
					num++;
				}
				else
				{
					list2.Add(item);
				}
			}
			catch
			{
			}
		}
		CommonSQL.smethod_16(list);
		method_95();
		method_89();
		BA332092();
		MessageBoxHelper.Show($"Đã loại bỏ {num} tài khoản bị trùng!");
	}

	private void FFAFC3B3_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			B0062D3F(null, null);
		}
	}

	private void BD85F20D_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			MessageBoxHelper.Show(Class64.A42EF119);
		}
		else
		{
			new fDeviceList().Show();
		}
	}

	private void CEAD541D_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fQuanLyNhom());
	}

	private void B43AE4BA(object sender, EventArgs e)
	{
		Common.smethod_16(new fTienIchTestSpinContent());
	}

	private void A7830B90(object sender, EventArgs e)
	{
		if (method_109() == 0)
		{
			MessageBoxHelper.Show("Vui lòng chọn tài khoản muốn sử dụng chức năng này!", 3);
			return;
		}
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list.Add(method_117(i, "cId"));
				}
			}
			if (CommonSQL.smethod_19(list))
			{
				FA986092(null, null);
				MessageBoxHelper.Show("Khôi phục thành công!");
			}
			else
			{
				MessageBoxHelper.Show("Khôi phục thất bại!", 2);
			}
		}
		catch (Exception)
		{
		}
	}

	private void loginPhoneToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_18(1);
	}

	private void C60F910E_Click(object sender, EventArgs e)
	{
		method_129("CheckBackupDataFb");
	}

	private void DB3F04A6(object sender, EventArgs e)
	{
		method_129("CheckBackupDataFb");
	}

	private void toolStripMenuItem9_Click(object sender, EventArgs e)
	{
		method_129("CopyBackupDataFb");
	}

	private void B8BE76AB(object sender, EventArgs e)
	{
		method_129("DeleteBackupDataFb");
	}

	private void donDepProfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			Common.smethod_16(new fClearProfile());
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show(ex.ToString(), 3);
		}
	}

	private void DF05800B_DoubleClick(object sender, EventArgs e)
	{
		this.smethod_2();
	}

	private void DBAC1483(object sender, EventArgs e)
	{
	}

	private void EF37FD0C(object sender, EventArgs e)
	{
		if (method_8())
		{
			JSON_Settings f72FAFBC = new JSON_Settings();
			Common.smethod_16(new fTaoThuMucMedia(f72FAFBC));
			string text = f72FAFBC.GetValue("txtFolderMedia");
			string text2 = f72FAFBC.GetValue("txtFolderSave");
			if (!(text == "") && !(text2 == ""))
			{
				method_129("TaoThuMucMedia", f72FAFBC);
			}
		}
	}

	private void F8AEEBA7(object sender, EventArgs e)
	{
		method_129("GetTokenCookie");
	}

	private void A4BB6392(object sender, EventArgs e)
	{
		Common.smethod_16(new fCauHinhRegClone());
		if (fCauHinhRegClone.AB99B71B)
		{
			JSON_Settings json = new JSON_Settings();
			json.GetValue("RegClone", true);
			method_18(0, bool_4: false, json);
		}
	}

	private void checkInfoDeviceToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_129("CheckBackupDevice");
	}

	protected override void Dispose(bool D731A406)
	{
		if (D731A406 && CA33E616 != null)
		{
			CA33E616.Dispose();
		}
		base.Dispose(D731A406);
	}

	private void InitializeComponent()
	{
		CA33E616 = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
		dtgvAcc = new System.Windows.Forms.DataGridView();
		FD96692B = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
		C6BC568F = new System.Windows.Forms.DataGridViewTextBoxColumn();
		BC260A35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cFollow = new System.Windows.Forms.DataGridViewTextBoxColumn();
		AC2B6237 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cMailRecovery = new System.Windows.Forms.DataGridViewTextBoxColumn();
		EF2018BD = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B405F6B2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		CE81988A = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B00DD887 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cDateCreateAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cAvatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cInteractEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
		AEB27D00 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cDeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		ctmsAcc = new System.Windows.Forms.ContextMenuStrip(CA33E616);
		F033EF83 = new System.Windows.Forms.ToolStripMenuItem();
		C3A2FC8E = new System.Windows.Forms.ToolStripMenuItem();
		liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		tinhTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		A12C7CB7 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_27 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		CF8DC72F = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_23 = new System.Windows.Forms.ToolStripMenuItem();
		B735D685 = new System.Windows.Forms.ToolStripMenuItem();
		F822A922 = new System.Windows.Forms.ToolStripMenuItem();
		E4184ABA = new System.Windows.Forms.ToolStripMenuItem();
		tokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		FE155729 = new System.Windows.Forms.ToolStripMenuItem();
		DE23BE8B = new System.Windows.Forms.ToolStripMenuItem();
		fAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_13 = new System.Windows.Forms.ToolStripMenuItem();
		uidPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		A1AED3A8 = new System.Windows.Forms.ToolStripMenuItem();
		A3040DA2 = new System.Windows.Forms.ToolStripMenuItem();
		AD1A1C09 = new System.Windows.Forms.ToolStripMenuItem();
		FB980FA5 = new System.Windows.Forms.ToolStripMenuItem();
		uidPassTokenCookieMailPassMail2faToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		E3108B09 = new System.Windows.Forms.ToolStripMenuItem();
		F703662A = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_11 = new System.Windows.Forms.ToolStripMenuItem();
		loginPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		checkCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_9 = new System.Windows.Forms.ToolStripMenuItem();
		checkInfoUIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		checkAvatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		C60F910E = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_16 = new System.Windows.Forms.ToolStripMenuItem();
		A2051002 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_12 = new System.Windows.Forms.ToolStripMenuItem();
		AA83531A = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_21 = new System.Windows.Forms.ToolStripMenuItem();
		F9841C0B = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_22 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
		tokenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		cookieToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_10 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_14 = new System.Windows.Forms.ToolStripMenuItem();
		useragentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		EE1661AD = new System.Windows.Forms.ToolStripMenuItem();
		C41205B6 = new System.Windows.Forms.ToolStripMenuItem();
		CAAE0387 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
		donDepProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		getTokencookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		checkInfoDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_24 = new System.Windows.Forms.ToolStripMenuItem();
		copyDataDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		C0318199 = new System.Windows.Forms.ToolStripMenuItem();
		backupGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		checkFileBackupGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_25 = new System.Windows.Forms.ToolStripMenuItem();
		CEAD541D = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_8 = new System.Windows.Forms.ToolStripMenuItem();
		lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		locTrungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_28 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_17 = new System.Windows.Forms.ToolStripMenuItem();
		BCBAFC26 = new System.Windows.Forms.ToolStripMenuItem();
		E4A13219 = new System.Windows.Forms.ToolStripMenuItem();
		unlockCheckpointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		regAccTiktokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		AF8E5F17 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_26 = new System.Windows.Forms.ToolStripMenuItem();
		B41C13A7 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_29 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		regCloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(CA33E616);
		DF05800B = new System.Windows.Forms.Panel();
		picLanguage = new System.Windows.Forms.PictureBox();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		button2 = new System.Windows.Forms.Button();
		button1 = new System.Windows.Forms.Button();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		menuStrip1 = new System.Windows.Forms.MenuStrip();
		A6014E37 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		BD85F20D = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_15 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_18 = new System.Windows.Forms.ToolStripMenuItem();
		B02753B5 = new System.Windows.Forms.ToolStripMenuItem();
		checkLiveUidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		BE3278AB = new System.Windows.Forms.ToolStripMenuItem();
		B481DD21 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_19 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_20 = new System.Windows.Forms.ToolStripMenuItem();
		D2359803 = new System.Windows.Forms.ToolStripMenuItem();
		testSpinTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		D4129739 = new System.Windows.Forms.ToolStripMenuItem();
		EA12B498 = new System.Windows.Forms.Button();
		btnEditFile = new System.Windows.Forms.Button();
		btnDeleteFile = new System.Windows.Forms.Button();
		btnAddFile = new System.Windows.Forms.Button();
		cbbTinhTrang = new System.Windows.Forms.ComboBox();
		cbbThuMuc = new System.Windows.Forms.ComboBox();
		label2 = new System.Windows.Forms.Label();
		EDBAB4B7 = new System.Windows.Forms.Label();
		A18F7693 = new System.Windows.Forms.Button();
		cbbSearch = new System.Windows.Forms.ComboBox();
		FFAFC3B3 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
		statusStrip1 = new System.Windows.Forms.StatusStrip();
		EBA6FB27 = new System.Windows.Forms.ToolStripStatusLabel();
		lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
		DA0FAD16 = new System.Windows.Forms.ToolStripStatusLabel();
		lblKey = new System.Windows.Forms.ToolStripStatusLabel();
		E7A0700F = new System.Windows.Forms.ToolStripStatusLabel();
		txbUid = new System.Windows.Forms.ToolStripStatusLabel();
		lblUser = new System.Windows.Forms.ToolStripStatusLabel();
		toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
		toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
		lblDateExpried = new System.Windows.Forms.ToolStripStatusLabel();
		toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
		CCACF12E = new System.Windows.Forms.ToolStripStatusLabel();
		CE1C833B = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountSelect = new System.Windows.Forms.ToolStripStatusLabel();
		toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountTotal = new System.Windows.Forms.ToolStripStatusLabel();
		D30FF534 = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountDeviceRunning = new System.Windows.Forms.ToolStripStatusLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(CA33E616);
		toolTip_0 = new System.Windows.Forms.ToolTip(CA33E616);
		btnPause = new System.Windows.Forms.Button();
		btnInteract = new System.Windows.Forms.Button();
		plTrangThai = new System.Windows.Forms.Panel();
		lblTrangThai = new System.Windows.Forms.Label();
		panel1 = new System.Windows.Forms.Panel();
		plQuanLyThuMuc = new System.Windows.Forms.Panel();
		panel2 = new System.Windows.Forms.Panel();
		BtnSearch = new System.Windows.Forms.Button();
		notifyIcon_0 = new System.Windows.Forms.NotifyIcon(CA33E616);
		((System.ComponentModel.ISupportInitialize)dtgvAcc).BeginInit();
		ctmsAcc.SuspendLayout();
		DF05800B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)picLanguage).BeginInit();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		bunifuCards1.SuspendLayout();
		menuStrip1.SuspendLayout();
		statusStrip1.SuspendLayout();
		plTrangThai.SuspendLayout();
		panel1.SuspendLayout();
		plQuanLyThuMuc.SuspendLayout();
		panel2.SuspendLayout();
		SuspendLayout();
		dtgvAcc.AllowUserToAddRows = false;
		dtgvAcc.AllowUserToDeleteRows = false;
		dtgvAcc.AllowUserToResizeRows = false;
		dtgvAcc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		dtgvAcc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dtgvAcc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvAcc.Columns.AddRange(FD96692B, cStt, cId, cUid, cToken, C6BC568F, BC260A35, cPhone, cName, cFollow, AC2B6237, cGroup, cBirthday, cGender, cPassword, cMailRecovery, EF2018BD, B405F6B2, CE81988A, B00DD887, cProxy, cDateCreateAcc, cAvatar, cProfile, cThuMuc, cInteractEnd, AEB27D00, cInfo, cGhiChu, cDeviceId, cIp, cStatus);
		dtgvAcc.ContextMenuStrip = ctmsAcc;
		dtgvAcc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		dtgvAcc.Location = new System.Drawing.Point(9, 108);
		dtgvAcc.Name = "dtgvAcc";
		dtgvAcc.RowHeadersVisible = false;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dtgvAcc.RowsDefaultCellStyle = dataGridViewCellStyle2;
		dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dtgvAcc.Size = new System.Drawing.Size(1226, 474);
		dtgvAcc.TabIndex = 0;
		dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(C63DC381);
		dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellDoubleClick);
		dtgvAcc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellValueChanged);
		dtgvAcc.SelectionChanged += new System.EventHandler(dtgvAcc_SelectionChanged);
		dtgvAcc.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(dtgvAcc_SortCompare);
		dtgvAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(A3853A30);
		FD96692B.HeaderText = "Chọn";
		FD96692B.Name = "cChose";
		FD96692B.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
		FD96692B.Width = 40;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		cStt.DefaultCellStyle = dataGridViewCellStyle3;
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.Width = 35;
		cId.HeaderText = "Id";
		cId.Name = "cId";
		cId.Visible = false;
		cId.Width = 90;
		cUid.HeaderText = "UID";
		cUid.Name = "cUid";
		cUid.Width = 80;
		cToken.HeaderText = "Token";
		cToken.Name = "cToken";
		cToken.Visible = false;
		cToken.Width = 70;
		C6BC568F.HeaderText = "Cookie";
		C6BC568F.Name = "cCookies";
		C6BC568F.Visible = false;
		C6BC568F.Width = 70;
		BC260A35.HeaderText = "Email";
		BC260A35.Name = "cEmail";
		BC260A35.Visible = false;
		BC260A35.Width = 60;
		cPhone.HeaderText = "Phone";
		cPhone.Name = "cPhone";
		cPhone.Visible = false;
		cPhone.Width = 60;
		cName.HeaderText = "Tên";
		cName.Name = "cName";
		cName.Visible = false;
		cName.Width = 70;
		cFollow.HeaderText = "Theo do\u0303i";
		cFollow.Name = "cFollow";
		cFollow.Visible = false;
		cFollow.Width = 80;
		AC2B6237.HeaderText = "Ba\u0323n be\u0300";
		AC2B6237.Name = "cFriend";
		AC2B6237.Visible = false;
		AC2B6237.Width = 70;
		cGroup.HeaderText = "Nho\u0301m";
		cGroup.Name = "cGroup";
		cGroup.Visible = false;
		cGroup.Width = 60;
		cBirthday.HeaderText = "Nga\u0300y sinh";
		cBirthday.Name = "cBirthday";
		cBirthday.Width = 90;
		cGender.HeaderText = "Giới Tính";
		cGender.Name = "cGender";
		cGender.Width = 80;
		cPassword.HeaderText = "Mật khẩu";
		cPassword.Name = "cPassword";
		cPassword.Visible = false;
		cPassword.Width = 70;
		cMailRecovery.HeaderText = "Email khôi phục";
		cMailRecovery.Name = "cMailRecovery";
		cMailRecovery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		cMailRecovery.Visible = false;
		cMailRecovery.Width = 120;
		EF2018BD.HeaderText = "Mật khẩu mail";
		EF2018BD.Name = "cPassMail";
		EF2018BD.Visible = false;
		EF2018BD.Width = 120;
		B405F6B2.HeaderText = "Backup";
		B405F6B2.Name = "cBackup";
		B405F6B2.Width = 70;
		CE81988A.HeaderText = "Mã 2FA";
		CE81988A.Name = "cFa2";
		CE81988A.Width = 80;
		B00DD887.HeaderText = "Useragent";
		B00DD887.Name = "cUseragent";
		B00DD887.Width = 70;
		cProxy.HeaderText = "Proxy";
		cProxy.Name = "cProxy";
		cProxy.Width = 55;
		cDateCreateAcc.HeaderText = "Nga\u0300y ta\u0323o";
		cDateCreateAcc.Name = "cDateCreateAcc";
		cDateCreateAcc.Width = 85;
		cAvatar.HeaderText = "Avatar";
		cAvatar.Name = "cAvatar";
		cAvatar.Width = 50;
		cProfile.HeaderText = "Profile";
		cProfile.Name = "cProfile";
		cProfile.Width = 50;
		cThuMuc.HeaderText = "Thư mục";
		cThuMuc.Name = "cThuMuc";
		cInteractEnd.HeaderText = "Lâ\u0300n tương ta\u0301c cuô\u0301i";
		cInteractEnd.Name = "cInteractEnd";
		cInteractEnd.Width = 160;
		AEB27D00.HeaderText = "Device Info";
		AEB27D00.Name = "cDevice";
		cInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		cInfo.HeaderText = "Tình Trạng";
		cInfo.Name = "cInfo";
		cGhiChu.HeaderText = "Ghi Chú";
		cGhiChu.Name = "cGhiChu";
		cDeviceId.HeaderText = "Thiết bị";
		cDeviceId.Name = "cDeviceId";
		cDeviceId.Width = 105;
		cIp.HeaderText = "IP";
		cIp.Name = "cIp";
		cIp.Visible = false;
		cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cStatus.HeaderText = "Trạng Thái";
		cStatus.MinimumWidth = 200;
		cStatus.Name = "cStatus";
		ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[16]
		{
			F033EF83, toolStripMenuItem_3, CF8DC72F, toolStripMenuItem_23, B735D685, loginPhoneToolStripMenuItem, toolStripMenuItem_1, checkCookieToolStripMenuItem, toolStripMenuItem_12, F9841C0B,
			toolStripMenuItem_2, profileToolStripMenuItem, C0318199, toolStripMenuItem_8, toolStripMenuItem_6, regCloneToolStripMenuItem
		});
		ctmsAcc.Name = "ctmsAcc";
		ctmsAcc.Size = new System.Drawing.Size(177, 356);
		ctmsAcc.Opening += new System.ComponentModel.CancelEventHandler(ctmsAcc_Opening);
		F033EF83.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { C3A2FC8E, liveToolStripMenuItem, tinhTrangToolStripMenuItem, A12C7CB7, toolStripMenuItem_27 });
		F033EF83.Image = (System.Drawing.Image)resources.GetObject("chọnLiveToolStripMenuItem.Image");
		F033EF83.Name = "chọnLiveToolStripMenuItem";
		F033EF83.Size = new System.Drawing.Size(176, 22);
		F033EF83.Text = "Chọn";
		C3A2FC8E.Image = (System.Drawing.Image)resources.GetObject("tấtCảToolStripMenuItem.Image");
		C3A2FC8E.Name = "tấtCảToolStripMenuItem";
		C3A2FC8E.Size = new System.Drawing.Size(209, 22);
		C3A2FC8E.Text = "Tất cả";
		C3A2FC8E.Click += new System.EventHandler(C986F503);
		liveToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("liveToolStripMenuItem.Image");
		liveToolStripMenuItem.Name = "liveToolStripMenuItem";
		liveToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
		liveToolStripMenuItem.Text = "Bôi đen";
		liveToolStripMenuItem.Click += new System.EventHandler(liveToolStripMenuItem_Click);
		tinhTrangToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tinhTrangToolStripMenuItem.Image");
		tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
		tinhTrangToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
		tinhTrangToolStripMenuItem.Text = "Ti\u0300nh tra\u0323ng";
		A12C7CB7.Image = (System.Drawing.Image)resources.GetObject("trạngTháiToolStripMenuItem.Image");
		A12C7CB7.Name = "trạngTháiToolStripMenuItem";
		A12C7CB7.Size = new System.Drawing.Size(209, 22);
		A12C7CB7.Text = "Trạng thái";
		A12C7CB7.Click += new System.EventHandler(AE147393);
		toolStripMenuItem_27.Image = Resource.Bitmap_15;
		toolStripMenuItem_27.Name = "chDanhSáchTheoUIDEmailToolStripMenuItem";
		toolStripMenuItem_27.Size = new System.Drawing.Size(209, 22);
		toolStripMenuItem_27.Text = "Chọn danh sách theo UID";
		toolStripMenuItem_27.Click += new System.EventHandler(toolStripMenuItem_27_Click);
		toolStripMenuItem_3.Image = (System.Drawing.Image)resources.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
		toolStripMenuItem_3.Name = "bỏChọnTấtCảToolStripMenuItem";
		toolStripMenuItem_3.Size = new System.Drawing.Size(176, 22);
		toolStripMenuItem_3.Text = "Bỏ chọn tất cả";
		toolStripMenuItem_3.Click += new System.EventHandler(F228DD8C);
		CF8DC72F.Image = Resource.Bitmap_97;
		CF8DC72F.Name = "ẩnKhỏiDanhSáchToolStripMenuItem";
		CF8DC72F.Size = new System.Drawing.Size(176, 22);
		CF8DC72F.Text = "Ẩn khỏi danh sách";
		CF8DC72F.Click += new System.EventHandler(A8A0C01B);
		toolStripMenuItem_23.Image = Resource.F78CF81A;
		toolStripMenuItem_23.Name = "gánProxyChoTàiKhoảnToolStripMenuItem";
		toolStripMenuItem_23.Size = new System.Drawing.Size(176, 22);
		toolStripMenuItem_23.Text = "Nhập Proxy";
		toolStripMenuItem_23.Click += new System.EventHandler(D6A2308D);
		B735D685.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[16]
		{
			F822A922, E4184ABA, tokenToolStripMenuItem, FE155729, DE23BE8B, fAToolStripMenuItem, toolStripMenuItem_13, uidPassToolStripMenuItem, A1AED3A8, A3040DA2,
			AD1A1C09, FB980FA5, uidPassTokenCookieMailPassMail2faToolStripMenuItem, E3108B09, F703662A, toolStripMenuItem_11
		});
		B735D685.Image = (System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image");
		B735D685.Name = "copyToolStripMenuItem";
		B735D685.Size = new System.Drawing.Size(176, 22);
		B735D685.Text = "Copy";
		F822A922.Image = (System.Drawing.Image)resources.GetObject("uidToolStripMenuItem.Image");
		F822A922.Name = "uidToolStripMenuItem";
		F822A922.Size = new System.Drawing.Size(289, 22);
		F822A922.Text = "Uid";
		F822A922.Click += new System.EventHandler(E6381903);
		E4184ABA.Image = (System.Drawing.Image)resources.GetObject("passToolStripMenuItem.Image");
		E4184ABA.Name = "passToolStripMenuItem";
		E4184ABA.Size = new System.Drawing.Size(289, 22);
		E4184ABA.Text = "Pass";
		E4184ABA.Click += new System.EventHandler(EDA7981A);
		tokenToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tokenToolStripMenuItem.Image");
		tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
		tokenToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		tokenToolStripMenuItem.Text = "Token";
		tokenToolStripMenuItem.Click += new System.EventHandler(DCA3B6A4);
		FE155729.Image = (System.Drawing.Image)resources.GetObject("cookieToolStripMenuItem.Image");
		FE155729.Name = "cookieToolStripMenuItem";
		FE155729.Size = new System.Drawing.Size(289, 22);
		FE155729.Text = "Cookie";
		FE155729.Click += new System.EventHandler(CF05A638);
		DE23BE8B.Image = (System.Drawing.Image)resources.GetObject("mailToolStripMenuItem.Image");
		DE23BE8B.Name = "mailToolStripMenuItem";
		DE23BE8B.Size = new System.Drawing.Size(289, 22);
		DE23BE8B.Text = "Email";
		DE23BE8B.Click += new System.EventHandler(DE23BE8B_Click);
		fAToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("fAToolStripMenuItem.Image");
		fAToolStripMenuItem.Name = "fAToolStripMenuItem";
		fAToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		fAToolStripMenuItem.Text = "2FA";
		fAToolStripMenuItem.Click += new System.EventHandler(fAToolStripMenuItem_Click);
		toolStripMenuItem_13.Image = (System.Drawing.Image)resources.GetObject("maBaoMât6SôToolStripMenuItem.Image");
		toolStripMenuItem_13.Name = "maBaoMât6SôToolStripMenuItem";
		toolStripMenuItem_13.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem_13.Text = "Ma\u0303 ba\u0309o mâ\u0323t 6 sô\u0301 từ 2FA";
		toolStripMenuItem_13.Click += new System.EventHandler(D3814D0A);
		uidPassToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassToolStripMenuItem.Image");
		uidPassToolStripMenuItem.Name = "uidPassToolStripMenuItem";
		uidPassToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		uidPassToolStripMenuItem.Text = "Uid|Pass";
		uidPassToolStripMenuItem.Click += new System.EventHandler(uidPassToolStripMenuItem_Click);
		A1AED3A8.Image = (System.Drawing.Image)resources.GetObject("uidPass2FaToolStripMenuItem.Image");
		A1AED3A8.Name = "uidPass2FaToolStripMenuItem";
		A1AED3A8.Size = new System.Drawing.Size(289, 22);
		A1AED3A8.Text = "Uid|Pass|2Fa";
		A1AED3A8.Click += new System.EventHandler(A1AED3A8_Click);
		A3040DA2.Image = (System.Drawing.Image)resources.GetObject("mailPassMailToolStripMenuItem.Image");
		A3040DA2.Name = "mailPassMailToolStripMenuItem";
		A3040DA2.Size = new System.Drawing.Size(289, 22);
		A3040DA2.Text = "Mail|Pass mail";
		A3040DA2.Click += new System.EventHandler(CC90C615);
		AD1A1C09.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieToolStripMenuItem.Image");
		AD1A1C09.Name = "uidPassTokenCookieToolStripMenuItem";
		AD1A1C09.Size = new System.Drawing.Size(289, 22);
		AD1A1C09.Text = "Uid|Pass|Token|Cookie";
		AD1A1C09.Click += new System.EventHandler(AD1A1C09_Click);
		FB980FA5.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMailToolStripMenuItem.Image");
		FB980FA5.Name = "uidPassTokenCookieMailPassMailToolStripMenuItem";
		FB980FA5.Size = new System.Drawing.Size(289, 22);
		FB980FA5.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail";
		FB980FA5.Click += new System.EventHandler(FB980FA5_Click);
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image");
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Name = "uidPassTokenCookieMailPassMail2faToolStripMenuItem";
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail|2fa";
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Click += new System.EventHandler(DE3EC6BF);
		E3108B09.Image = (System.Drawing.Image)resources.GetObject("useragentToolStripMenuItem1.Image");
		E3108B09.Name = "useragentToolStripMenuItem1";
		E3108B09.Size = new System.Drawing.Size(289, 22);
		E3108B09.Text = "Useragent";
		E3108B09.Click += new System.EventHandler(E3108B09_Click);
		F703662A.Image = (System.Drawing.Image)resources.GetObject("proxyToolStripMenuItem1.Image");
		F703662A.Name = "proxyToolStripMenuItem1";
		F703662A.Size = new System.Drawing.Size(289, 22);
		F703662A.Text = "Proxy";
		F703662A.Click += new System.EventHandler(F703662A_Click);
		toolStripMenuItem_11.Image = (System.Drawing.Image)resources.GetObject("đinhDangKhacToolStripMenuItem.Image");
		toolStripMenuItem_11.Name = "đinhDangKhacToolStripMenuItem";
		toolStripMenuItem_11.Size = new System.Drawing.Size(289, 22);
		toolStripMenuItem_11.Text = "Other...";
		toolStripMenuItem_11.Click += new System.EventHandler(toolStripMenuItem_11_Click);
		loginPhoneToolStripMenuItem.Image = Resource.Bitmap_56;
		loginPhoneToolStripMenuItem.Name = "loginPhoneToolStripMenuItem";
		loginPhoneToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
		loginPhoneToolStripMenuItem.Text = "Login phone";
		loginPhoneToolStripMenuItem.Click += new System.EventHandler(loginPhoneToolStripMenuItem_Click);
		toolStripMenuItem_1.Image = (System.Drawing.Image)resources.GetObject("xóaTàiKhoảnToolStripMenuItem.Image");
		toolStripMenuItem_1.Name = "xóaTàiKhoảnToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(176, 22);
		toolStripMenuItem_1.Text = "Xóa ta\u0300i khoa\u0309n";
		toolStripMenuItem_1.Click += new System.EventHandler(toolStripMenuItem_1_Click);
		checkCookieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { toolStripMenuItem_9, checkInfoUIDToolStripMenuItem, toolStripMenuItem_5, toolStripMenuItem_4, checkAvatarToolStripMenuItem, C60F910E, toolStripMenuItem_16, A2051002 });
		checkCookieToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("checkCookieToolStripMenuItem.Image");
		checkCookieToolStripMenuItem.Name = "checkCookieToolStripMenuItem";
		checkCookieToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
		checkCookieToolStripMenuItem.Text = "Kiểm tra tài khoản";
		checkCookieToolStripMenuItem.Click += new System.EventHandler(BD830A36);
		toolStripMenuItem_9.Name = "kiểmTraWallToolStripMenuItem";
		toolStripMenuItem_9.Size = new System.Drawing.Size(153, 22);
		toolStripMenuItem_9.Text = "Check Wall";
		toolStripMenuItem_9.ToolTipText = "Không cần dùng token";
		toolStripMenuItem_9.Click += new System.EventHandler(toolStripMenuItem_9_Click);
		checkInfoUIDToolStripMenuItem.Name = "checkInfoUIDToolStripMenuItem";
		checkInfoUIDToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
		checkInfoUIDToolStripMenuItem.Text = "Check Info UID";
		checkInfoUIDToolStripMenuItem.ToolTipText = "Không cần dùng token\r\nCâ\u0323p nhâ\u0323t thông tin: Ho\u0323 tên, Giớ\u0301i ti\u0301nh, [Email], [Ba\u0323n be\u0300], [Nho\u0301m], [Nga\u0300y sinh]";
		checkInfoUIDToolStripMenuItem.Click += new System.EventHandler(checkInfoUIDToolStripMenuItem_Click);
		toolStripMenuItem_5.Name = "kiểmTraTokenToolStripMenuItem";
		toolStripMenuItem_5.Size = new System.Drawing.Size(153, 22);
		toolStripMenuItem_5.Text = "Check Token";
		toolStripMenuItem_5.Click += new System.EventHandler(toolStripMenuItem_5_Click);
		toolStripMenuItem_4.Name = "kiểmTraCookieToolStripMenuItem";
		toolStripMenuItem_4.Size = new System.Drawing.Size(153, 22);
		toolStripMenuItem_4.Text = "Check Cookie";
		toolStripMenuItem_4.Click += new System.EventHandler(B5199DA9);
		checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
		checkAvatarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
		checkAvatarToolStripMenuItem.Text = "Check Avatar";
		checkAvatarToolStripMenuItem.Click += new System.EventHandler(checkAvatarToolStripMenuItem_Click);
		C60F910E.Name = "toolStripMenuItem6";
		C60F910E.Size = new System.Drawing.Size(153, 22);
		C60F910E.Text = "Check Profile";
		C60F910E.Click += new System.EventHandler(C60F910E_Click);
		toolStripMenuItem_16.Name = "kiểmTraMailpassMailToolStripMenuItem";
		toolStripMenuItem_16.Size = new System.Drawing.Size(153, 22);
		toolStripMenuItem_16.Text = "Mail|pass Mail";
		toolStripMenuItem_16.Click += new System.EventHandler(toolStripMenuItem_16_Click);
		A2051002.Name = "checkProxyToolStripMenuItem";
		A2051002.Size = new System.Drawing.Size(153, 22);
		A2051002.Text = "Check Proxy";
		A2051002.Click += new System.EventHandler(C49D5B23);
		toolStripMenuItem_12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { AA83531A, toolStripMenuItem_21 });
		toolStripMenuItem_12.Image = (System.Drawing.Image)resources.GetObject("câpNhâtThôngTinCaNhânToolStripMenuItem.Image");
		toolStripMenuItem_12.Name = "câpNhâtThôngTinCaNhânToolStripMenuItem";
		toolStripMenuItem_12.Size = new System.Drawing.Size(176, 22);
		toolStripMenuItem_12.Text = "Câ\u0323p nhâ\u0323t thông tin";
		AA83531A.Name = "sưDungTokenTrungGianToolStripMenuItem";
		AA83531A.Size = new System.Drawing.Size(216, 22);
		AA83531A.Text = "Sư\u0309 du\u0323ng Token trung gian";
		AA83531A.ToolTipText = "Câ\u0323p nhâ\u0323t thông tin: Ho\u0323 tên, Giớ\u0301i ti\u0301nh, [Email], [Ba\u0323n be\u0300], [Nho\u0301m], [Nga\u0300y sinh]";
		AA83531A.Click += new System.EventHandler(C921DD8D);
		toolStripMenuItem_21.Name = "sửDụngCookieTrungGianToolStripMenuItem";
		toolStripMenuItem_21.Size = new System.Drawing.Size(216, 22);
		toolStripMenuItem_21.Text = "Sử dụng Cookie trung gian";
		toolStripMenuItem_21.Click += new System.EventHandler(toolStripMenuItem_21_Click);
		F9841C0B.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[10] { toolStripMenuItem_22, toolStripMenuItem_7, tokenToolStripMenuItem2, cookieToolStripMenuItem3, toolStripMenuItem_10, toolStripMenuItem_14, useragentToolStripMenuItem, EE1661AD, C41205B6, CAAE0387 });
		F9841C0B.Image = (System.Drawing.Image)resources.GetObject("cậpNhậtDữLiệuToolStripMenuItem.Image");
		F9841C0B.Name = "cậpNhậtDữLiệuToolStripMenuItem";
		F9841C0B.Size = new System.Drawing.Size(176, 22);
		F9841C0B.Text = "Cập nhật dữ liệu";
		toolStripMenuItem_22.Image = Resource.Bitmap_109;
		toolStripMenuItem_22.Name = "cậpToolStripMenuItem";
		toolStripMenuItem_22.Size = new System.Drawing.Size(175, 22);
		toolStripMenuItem_22.Text = "Cập nhật hàng loạt";
		toolStripMenuItem_22.Click += new System.EventHandler(E536F13B);
		toolStripMenuItem_7.Image = (System.Drawing.Image)resources.GetObject("mậtKhẩuToolStripMenuItem1.Image");
		toolStripMenuItem_7.Name = "mậtKhẩuToolStripMenuItem1";
		toolStripMenuItem_7.Size = new System.Drawing.Size(175, 22);
		toolStripMenuItem_7.Text = "Password";
		toolStripMenuItem_7.Click += new System.EventHandler(DE1E0400);
		tokenToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("tokenToolStripMenuItem2.Image");
		tokenToolStripMenuItem2.Name = "tokenToolStripMenuItem2";
		tokenToolStripMenuItem2.Size = new System.Drawing.Size(175, 22);
		tokenToolStripMenuItem2.Text = "Token";
		tokenToolStripMenuItem2.Click += new System.EventHandler(tokenToolStripMenuItem2_Click);
		cookieToolStripMenuItem3.Image = (System.Drawing.Image)resources.GetObject("cookieToolStripMenuItem3.Image");
		cookieToolStripMenuItem3.Name = "cookieToolStripMenuItem3";
		cookieToolStripMenuItem3.Size = new System.Drawing.Size(175, 22);
		cookieToolStripMenuItem3.Text = "Cookie";
		cookieToolStripMenuItem3.Click += new System.EventHandler(cookieToolStripMenuItem3_Click);
		toolStripMenuItem_10.Image = (System.Drawing.Image)resources.GetObject("mailKhôiPhụcToolStripMenuItem.Image");
		toolStripMenuItem_10.Name = "mailKhôiPhụcToolStripMenuItem";
		toolStripMenuItem_10.Size = new System.Drawing.Size(175, 22);
		toolStripMenuItem_10.Text = "Email|Pass Email";
		toolStripMenuItem_10.Click += new System.EventHandler(toolStripMenuItem_10_Click);
		toolStripMenuItem_14.Image = (System.Drawing.Image)resources.GetObject("mã2FAToolStripMenuItem.Image");
		toolStripMenuItem_14.Name = "mã2FAToolStripMenuItem";
		toolStripMenuItem_14.Size = new System.Drawing.Size(175, 22);
		toolStripMenuItem_14.Text = "Mã 2FA";
		toolStripMenuItem_14.Click += new System.EventHandler(A2A77B30);
		useragentToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("useragentToolStripMenuItem.Image");
		useragentToolStripMenuItem.Name = "useragentToolStripMenuItem";
		useragentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
		useragentToolStripMenuItem.Text = "Useragent";
		useragentToolStripMenuItem.Click += new System.EventHandler(DB375EB6);
		EE1661AD.Image = (System.Drawing.Image)resources.GetObject("proxyToolStripMenuItem.Image");
		EE1661AD.Name = "proxyToolStripMenuItem";
		EE1661AD.Size = new System.Drawing.Size(175, 22);
		EE1661AD.Text = "Proxy";
		EE1661AD.Click += new System.EventHandler(D3243D83);
		C41205B6.Image = Resource.Bitmap_111;
		C41205B6.Name = "ghiChuToolStripMenuItem";
		C41205B6.Size = new System.Drawing.Size(175, 22);
		C41205B6.Text = "Ghi chu\u0301";
		C41205B6.Click += new System.EventHandler(C41205B6_Click);
		CAAE0387.Image = Resource.Bitmap_62;
		CAAE0387.Name = "ngàySinhToolStripMenuItem";
		CAAE0387.Size = new System.Drawing.Size(175, 22);
		CAAE0387.Text = "Ngày sinh";
		CAAE0387.Click += new System.EventHandler(CAAE0387_Click);
		toolStripMenuItem_2.Image = (System.Drawing.Image)resources.GetObject("chuyểnThưMụcToolStripMenuItem.Image");
		toolStripMenuItem_2.Name = "chuyểnThưMụcToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(176, 22);
		toolStripMenuItem_2.Text = "Chuyển thư mục";
		profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { toolStripMenuItem7, toolStripMenuItem8, toolStripMenuItem9, donDepProfileToolStripMenuItem, getTokencookieToolStripMenuItem, checkInfoDeviceToolStripMenuItem, toolStripMenuItem_24, copyDataDeviceToolStripMenuItem });
		profileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("profileToolStripMenuItem.Image");
		profileToolStripMenuItem.Name = "profileToolStripMenuItem";
		profileToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
		profileToolStripMenuItem.Text = "Profile Phone";
		toolStripMenuItem7.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem7.Image");
		toolStripMenuItem7.Name = "toolStripMenuItem7";
		toolStripMenuItem7.Size = new System.Drawing.Size(168, 22);
		toolStripMenuItem7.Text = "Check profile";
		toolStripMenuItem7.Click += new System.EventHandler(DB3F04A6);
		toolStripMenuItem8.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem8.Image");
		toolStripMenuItem8.Name = "toolStripMenuItem8";
		toolStripMenuItem8.Size = new System.Drawing.Size(168, 22);
		toolStripMenuItem8.Text = "Xóa profile";
		toolStripMenuItem8.Click += new System.EventHandler(B8BE76AB);
		toolStripMenuItem9.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem9.Image");
		toolStripMenuItem9.Name = "toolStripMenuItem9";
		toolStripMenuItem9.Size = new System.Drawing.Size(168, 22);
		toolStripMenuItem9.Text = "Copy profile";
		toolStripMenuItem9.Click += new System.EventHandler(toolStripMenuItem9_Click);
		donDepProfileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("donDepProfileToolStripMenuItem.Image");
		donDepProfileToolStripMenuItem.Name = "donDepProfileToolStripMenuItem";
		donDepProfileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
		donDepProfileToolStripMenuItem.Text = "Do\u0323n de\u0323p";
		donDepProfileToolStripMenuItem.Click += new System.EventHandler(donDepProfileToolStripMenuItem_Click);
		getTokencookieToolStripMenuItem.Image = Resource.Bitmap_101;
		getTokencookieToolStripMenuItem.Name = "getTokencookieToolStripMenuItem";
		getTokencookieToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
		getTokencookieToolStripMenuItem.Text = "Get token|cookie";
		getTokencookieToolStripMenuItem.Click += new System.EventHandler(F8AEEBA7);
		checkInfoDeviceToolStripMenuItem.Image = Resource.Bitmap_34;
		checkInfoDeviceToolStripMenuItem.Name = "checkInfoDeviceToolStripMenuItem";
		checkInfoDeviceToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
		checkInfoDeviceToolStripMenuItem.Text = "Check info device";
		checkInfoDeviceToolStripMenuItem.Click += new System.EventHandler(checkInfoDeviceToolStripMenuItem_Click);
		toolStripMenuItem_24.Image = Resource.Bitmap_83;
		toolStripMenuItem_24.Name = "xóaDataDeviceToolStripMenuItem";
		toolStripMenuItem_24.Size = new System.Drawing.Size(168, 22);
		toolStripMenuItem_24.Text = "Xóa info device";
		toolStripMenuItem_24.Click += new System.EventHandler(E231CC2B);
		copyDataDeviceToolStripMenuItem.Image = Resource.DD3C6B9A;
		copyDataDeviceToolStripMenuItem.Name = "copyDataDeviceToolStripMenuItem";
		copyDataDeviceToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
		copyDataDeviceToolStripMenuItem.Text = "Copy info device";
		copyDataDeviceToolStripMenuItem.Click += new System.EventHandler(copyDataDeviceToolStripMenuItem_Click);
		C0318199.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { backupGroupToolStripMenuItem, checkFileBackupGroupToolStripMenuItem, toolStripMenuItem_25, CEAD541D });
		C0318199.Image = Resource.Bitmap_37;
		C0318199.Name = "dataBackupGroupToolStripMenuItem";
		C0318199.Size = new System.Drawing.Size(176, 22);
		C0318199.Text = "Data Backup Group";
		backupGroupToolStripMenuItem.Name = "backupGroupToolStripMenuItem";
		backupGroupToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
		backupGroupToolStripMenuItem.Text = "Backup group";
		backupGroupToolStripMenuItem.Click += new System.EventHandler(backupGroupToolStripMenuItem_Click);
		checkFileBackupGroupToolStripMenuItem.Name = "checkFileBackupGroupToolStripMenuItem";
		checkFileBackupGroupToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
		checkFileBackupGroupToolStripMenuItem.Text = "Check data group";
		checkFileBackupGroupToolStripMenuItem.Click += new System.EventHandler(checkFileBackupGroupToolStripMenuItem_Click);
		toolStripMenuItem_25.Name = "xóaFileBackupGroupToolStripMenuItem";
		toolStripMenuItem_25.Size = new System.Drawing.Size(168, 22);
		toolStripMenuItem_25.Text = "Xóa data group";
		toolStripMenuItem_25.Click += new System.EventHandler(C3A395AA);
		CEAD541D.Name = "mởFormQuảnLýToolStripMenuItem";
		CEAD541D.Size = new System.Drawing.Size(168, 22);
		CEAD541D.Text = "Mở form quản lý";
		CEAD541D.Click += new System.EventHandler(CEAD541D_Click);
		toolStripMenuItem_8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[13]
		{
			lToolStripMenuItem, locTrungToolStripMenuItem, toolStripMenuItem_28, toolStripMenuItem_17, BCBAFC26, E4A13219, unlockCheckpointToolStripMenuItem, regAccTiktokToolStripMenuItem, AF8E5F17, toolStripMenuItem3,
			toolStripMenuItem_26, B41C13A7, toolStripMenuItem_29
		});
		toolStripMenuItem_8.Image = (System.Drawing.Image)resources.GetObject("chứcNăngToolStripMenuItem1.Image");
		toolStripMenuItem_8.Name = "chứcNăngToolStripMenuItem1";
		toolStripMenuItem_8.Size = new System.Drawing.Size(176, 22);
		toolStripMenuItem_8.Text = "Chức năng";
		lToolStripMenuItem.Image = Resource.ADA4F185;
		lToolStripMenuItem.Name = "lToolStripMenuItem";
		lToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
		lToolStripMenuItem.Text = "Lọc tài khoản theo UID/Email";
		lToolStripMenuItem.Click += new System.EventHandler(D9BD898F);
		locTrungToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("locTrungToolStripMenuItem.Image");
		locTrungToolStripMenuItem.Name = "locTrungToolStripMenuItem";
		locTrungToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
		locTrungToolStripMenuItem.Text = "Lo\u0323c tài khoản tru\u0300ng nhau";
		locTrungToolStripMenuItem.Click += new System.EventHandler(locTrungToolStripMenuItem_Click);
		toolStripMenuItem_28.Image = Resource.BA87398A;
		toolStripMenuItem_28.Name = "xóaTàiKhoảnTrùngNhauToolStripMenuItem";
		toolStripMenuItem_28.Size = new System.Drawing.Size(253, 22);
		toolStripMenuItem_28.Text = "Xóa tài khoản trùng nhau";
		toolStripMenuItem_28.Click += new System.EventHandler(B8845BA6);
		toolStripMenuItem_17.Image = Resource.Bitmap_18;
		toolStripMenuItem_17.Name = "tảiXuốngAvatarToolStripMenuItem";
		toolStripMenuItem_17.Size = new System.Drawing.Size(253, 22);
		toolStripMenuItem_17.Text = "Tải xuống avatar";
		toolStripMenuItem_17.Click += new System.EventHandler(C7236B08);
		BCBAFC26.Image = Resource.Bitmap_107;
		BCBAFC26.Name = "loginHotmailToolStripMenuItem";
		BCBAFC26.Size = new System.Drawing.Size(253, 22);
		BCBAFC26.Text = "Login Hotmail (ẩn)";
		BCBAFC26.Click += new System.EventHandler(BCBAFC26_Click);
		E4A13219.Image = Resource.B3874631;
		E4A13219.Name = "loginYandexToolStripMenuItem";
		E4A13219.Size = new System.Drawing.Size(253, 22);
		E4A13219.Text = "Login Yandex (ẩn)";
		E4A13219.Click += new System.EventHandler(E4A13219_Click);
		unlockCheckpointToolStripMenuItem.Image = Resource.Bitmap_181;
		unlockCheckpointToolStripMenuItem.Name = "unlockCheckpointToolStripMenuItem";
		unlockCheckpointToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
		unlockCheckpointToolStripMenuItem.Text = "Unlock Checkpoint (ẩn)";
		unlockCheckpointToolStripMenuItem.Click += new System.EventHandler(unlockCheckpointToolStripMenuItem_Click);
		regAccTiktokToolStripMenuItem.Image = Resource.Bitmap_151;
		regAccTiktokToolStripMenuItem.Name = "regAccTiktokToolStripMenuItem";
		regAccTiktokToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
		regAccTiktokToolStripMenuItem.Text = "Reg Acc Tiktok (ẩn)";
		regAccTiktokToolStripMenuItem.Click += new System.EventHandler(F70A3E16);
		AF8E5F17.Image = Resource.Bitmap_100;
		AF8E5F17.Name = "toolStripMenuItem4";
		AF8E5F17.Size = new System.Drawing.Size(253, 22);
		AF8E5F17.Text = "Reg Acc Instagram (ẩn)";
		AF8E5F17.Click += new System.EventHandler(AF8E5F17_Click);
		toolStripMenuItem3.Image = Resource.Bitmap_92;
		toolStripMenuItem3.Name = "toolStripMenuItem3";
		toolStripMenuItem3.Size = new System.Drawing.Size(253, 22);
		toolStripMenuItem3.Text = "Login App Fb Clone (ẩn)";
		toolStripMenuItem3.Click += new System.EventHandler(A2A61088);
		toolStripMenuItem_26.Image = Resource.F69DFB2B;
		toolStripMenuItem_26.Name = "chuyểnĐịnhDạngNgàySinhMMddyyyyToolStripMenuItem";
		toolStripMenuItem_26.Size = new System.Drawing.Size(253, 22);
		toolStripMenuItem_26.Text = "Convert format birthday (ẩn)";
		toolStripMenuItem_26.Click += new System.EventHandler(toolStripMenuItem_26_Click);
		B41C13A7.Image = Resource.Bitmap_77;
		B41C13A7.Name = "khôiPhụcPassOldToolStripMenuItem";
		B41C13A7.Size = new System.Drawing.Size(253, 22);
		B41C13A7.Text = "Khôi phục mật khẩu trước đó (ẩn)";
		B41C13A7.Click += new System.EventHandler(A7830B90);
		toolStripMenuItem_29.Image = Resource.Bitmap_4;
		toolStripMenuItem_29.Name = "tạoThưMụcMediaToolStripMenuItem";
		toolStripMenuItem_29.Size = new System.Drawing.Size(253, 22);
		toolStripMenuItem_29.Text = "Tạo thư mục media";
		toolStripMenuItem_29.Click += new System.EventHandler(EF37FD0C);
		toolStripMenuItem_6.Image = (System.Drawing.Image)resources.GetObject("tảiLạiDanhSáchToolStripMenuItem.Image");
		toolStripMenuItem_6.Name = "tảiLạiDanhSáchToolStripMenuItem";
		toolStripMenuItem_6.Size = new System.Drawing.Size(176, 22);
		toolStripMenuItem_6.Text = "Tải lại danh sách";
		toolStripMenuItem_6.Click += new System.EventHandler(toolStripMenuItem_6_Click);
		regCloneToolStripMenuItem.Image = Resource.Bitmap_53;
		regCloneToolStripMenuItem.Name = "regCloneToolStripMenuItem";
		regCloneToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
		regCloneToolStripMenuItem.Text = "Reg Clone (ẩn)";
		regCloneToolStripMenuItem.Click += new System.EventHandler(A4BB6392);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DF05800B;
		bunifuDragControl_0.Vertical = true;
		DF05800B.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DF05800B.BackColor = System.Drawing.Color.White;
		DF05800B.Controls.Add(picLanguage);
		DF05800B.Controls.Add(pictureBox1);
		DF05800B.Controls.Add(button2);
		DF05800B.Controls.Add(button1);
		DF05800B.Controls.Add(btnMinimize);
		DF05800B.Controls.Add(bunifuCustomLabel1);
		DF05800B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DF05800B.Location = new System.Drawing.Point(0, 5);
		DF05800B.Name = "pnlHeader";
		DF05800B.Size = new System.Drawing.Size(1243, 29);
		DF05800B.TabIndex = 0;
		DF05800B.DoubleClick += new System.EventHandler(DF05800B_DoubleClick);
		picLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		picLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
		picLanguage.Image = Resource.EF0A430E;
		picLanguage.Location = new System.Drawing.Point(1116, 2);
		picLanguage.Name = "picLanguage";
		picLanguage.Size = new System.Drawing.Size(25, 25);
		picLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		picLanguage.TabIndex = 10;
		picLanguage.TabStop = false;
		picLanguage.Click += new System.EventHandler(CBA74584);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(6, 1);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 12;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		pictureBox1.DoubleClick += new System.EventHandler(pictureBox1_DoubleClick);
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.Dock = System.Windows.Forms.DockStyle.Right;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
		button2.Location = new System.Drawing.Point(1147, 0);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(32, 29);
		button2.TabIndex = 0;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.Dock = System.Windows.Forms.DockStyle.Right;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(1179, 0);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(32, 29);
		button1.TabIndex = 1;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(BE168597);
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(1211, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 29);
		btnMinimize.TabIndex = 2;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(A4335002);
		bunifuCustomLabel1.AutoSize = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(43, 6);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(731, 16);
		bunifuCustomLabel1.TabIndex = 3;
		bunifuCustomLabel1.Text = "MAX PHONE FARM v23.06.20 - Phần Mềm Quản Lý Va\u0300 Chăm So\u0301c Tài Khoản Facebook Trên Phone - MIN SOFTWARE";
		bunifuCustomLabel1.DoubleClick += new System.EventHandler(B21A5106);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.RoyalBlue;
		bunifuCards1.Controls.Add(DF05800B);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(1244, 38);
		bunifuCards1.TabIndex = 0;
		menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		menuStrip1.AutoSize = false;
		menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
		menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[7] { A6014E37, toolStripMenuItem_0, BD85F20D, toolStripMenuItem_15, toolStripMenuItem_18, B02753B5, D4129739 });
		menuStrip1.Location = new System.Drawing.Point(1, 37);
		menuStrip1.Name = "menuStrip1";
		menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		menuStrip1.Size = new System.Drawing.Size(1243, 25);
		menuStrip1.Stretch = false;
		menuStrip1.TabIndex = 1;
		menuStrip1.Text = "menuStrip1";
		A6014E37.Image = Resource.Bitmap_102;
		A6014E37.Name = "hệThốngToolStripMenuItem";
		A6014E37.Size = new System.Drawing.Size(123, 21);
		A6014E37.Text = "Câ\u0301u hi\u0300nh chung";
		A6014E37.Click += new System.EventHandler(A6014E37_Click);
		toolStripMenuItem_0.Image = Resource.D8BF7C05;
		toolStripMenuItem_0.Name = "càiĐặtToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(143, 21);
		toolStripMenuItem_0.Text = "Câ\u0301u hi\u0300nh tương ta\u0301c";
		toolStripMenuItem_0.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
		toolStripMenuItem_0.Click += new System.EventHandler(DF3C6D09);
		BD85F20D.Image = Resource.Bitmap_162;
		BD85F20D.Name = "toolStripMenuItem5";
		BD85F20D.Size = new System.Drawing.Size(117, 21);
		BD85F20D.Text = "Quản lý phone";
		BD85F20D.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
		BD85F20D.Click += new System.EventHandler(DBAC1483);
		BD85F20D.MouseDown += new System.Windows.Forms.MouseEventHandler(BD85F20D_MouseDown);
		toolStripMenuItem_15.Image = Resource.E53E2DAF;
		toolStripMenuItem_15.Name = "thoátToolStripMenuItem";
		toolStripMenuItem_15.Size = new System.Drawing.Size(131, 21);
		toolStripMenuItem_15.Text = "Câ\u0301u hi\u0300nh hiê\u0309n thi\u0323";
		toolStripMenuItem_15.Click += new System.EventHandler(E230D204);
		toolStripMenuItem_18.Image = Resource.Bitmap_82;
		toolStripMenuItem_18.Name = "taiKhoanĐaXoaToolStripMenuItem";
		toolStripMenuItem_18.Size = new System.Drawing.Size(133, 21);
		toolStripMenuItem_18.Text = "Ta\u0300i khoa\u0309n đa\u0303 xo\u0301a";
		toolStripMenuItem_18.Click += new System.EventHandler(toolStripMenuItem_18_Click);
		B02753B5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[7] { checkLiveUidToolStripMenuItem, BE3278AB, B481DD21, toolStripMenuItem_19, toolStripMenuItem_20, D2359803, testSpinTextToolStripMenuItem });
		B02753B5.Image = Resource.Bitmap_70;
		B02753B5.Name = "tiệnÍchToolStripMenuItem";
		B02753B5.Size = new System.Drawing.Size(80, 21);
		B02753B5.Text = "Tiện ích";
		checkLiveUidToolStripMenuItem.Image = Resource.Bitmap_65;
		checkLiveUidToolStripMenuItem.Name = "checkLiveUidToolStripMenuItem";
		checkLiveUidToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
		checkLiveUidToolStripMenuItem.Text = "Check Live Uid";
		checkLiveUidToolStripMenuItem.Click += new System.EventHandler(B827020A);
		BE3278AB.Image = Resource.CF1E5CAB;
		BE3278AB.Name = "checkProxyToolStripMenuItem1";
		BE3278AB.Size = new System.Drawing.Size(240, 22);
		BE3278AB.Text = "Check Proxy";
		BE3278AB.Click += new System.EventHandler(BE3278AB_Click);
		B481DD21.Image = Resource.BF8C190C;
		B481DD21.Name = "checkHotmailToolStripMenuItem";
		B481DD21.Size = new System.Drawing.Size(240, 22);
		B481DD21.Text = "Check Imap Hotmail";
		B481DD21.Click += new System.EventHandler(F224AEB0);
		toolStripMenuItem_19.Image = Resource.Bitmap_105;
		toolStripMenuItem_19.Name = "lọcTrùngDữLiệuToolStripMenuItem";
		toolStripMenuItem_19.Size = new System.Drawing.Size(240, 22);
		toolStripMenuItem_19.Text = "Lọc trùng dữ liệu";
		toolStripMenuItem_19.Click += new System.EventHandler(toolStripMenuItem_19_Click);
		toolStripMenuItem_20.Image = Resource.Bitmap_130;
		toolStripMenuItem_20.Name = "xửLýChuỗiOnlineToolStripMenuItem";
		toolStripMenuItem_20.Size = new System.Drawing.Size(240, 22);
		toolStripMenuItem_20.Text = "Xử lý chuỗi cơ bản";
		toolStripMenuItem_20.Click += new System.EventHandler(E1230328);
		D2359803.Image = Resource.Bitmap_112;
		D2359803.Name = "checkStatusXproxyToolStripMenuItem";
		D2359803.Size = new System.Drawing.Size(240, 22);
		D2359803.Text = "Check status Xproxy/ProxyV6";
		D2359803.Click += new System.EventHandler(FD240F92);
		testSpinTextToolStripMenuItem.Image = Resource.Bitmap_13;
		testSpinTextToolStripMenuItem.Name = "testSpinTextToolStripMenuItem";
		testSpinTextToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
		testSpinTextToolStripMenuItem.Text = "Test Spin Content";
		testSpinTextToolStripMenuItem.Click += new System.EventHandler(B43AE4BA);
		D4129739.Image = Resource.Bitmap_131;
		D4129739.Name = "liênHệToolStripMenuItem";
		D4129739.Size = new System.Drawing.Size(76, 21);
		D4129739.Text = "Liên hệ";
		D4129739.Click += new System.EventHandler(D4129739_Click);
		EA12B498.BackgroundImage = Resource.Bitmap_6;
		EA12B498.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		EA12B498.Cursor = System.Windows.Forms.Cursors.Hand;
		EA12B498.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		EA12B498.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EA12B498.Location = new System.Drawing.Point(492, 2);
		EA12B498.Name = "btnLoadAcc";
		EA12B498.Size = new System.Drawing.Size(25, 25);
		EA12B498.TabIndex = 6;
		toolTip_0.SetToolTip(EA12B498, "Load lại danh sách");
		EA12B498.Click += new System.EventHandler(FA986092);
		btnEditFile.BackColor = System.Drawing.Color.White;
		btnEditFile.BackgroundImage = Resource.Bitmap_89;
		btnEditFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		btnEditFile.Cursor = System.Windows.Forms.Cursors.Hand;
		btnEditFile.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnEditFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnEditFile.Location = new System.Drawing.Point(429, 2);
		btnEditFile.Name = "btnEditFile";
		btnEditFile.Size = new System.Drawing.Size(25, 25);
		btnEditFile.TabIndex = 5;
		toolTip_0.SetToolTip(btnEditFile, "Sửa tên thư mục");
		btnEditFile.UseVisualStyleBackColor = false;
		btnEditFile.Click += new System.EventHandler(btnEditFile_Click);
		btnDeleteFile.BackColor = System.Drawing.Color.White;
		btnDeleteFile.BackgroundImage = Resource.Bitmap_147;
		btnDeleteFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		btnDeleteFile.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDeleteFile.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDeleteFile.Location = new System.Drawing.Point(460, 2);
		btnDeleteFile.Name = "btnDeleteFile";
		btnDeleteFile.Size = new System.Drawing.Size(25, 25);
		btnDeleteFile.TabIndex = 5;
		toolTip_0.SetToolTip(btnDeleteFile, "Xóa thư mục");
		btnDeleteFile.UseVisualStyleBackColor = false;
		btnDeleteFile.Click += new System.EventHandler(btnDeleteFile_Click);
		btnAddFile.BackgroundImage = Resource.Bitmap_121;
		btnAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		btnAddFile.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAddFile.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAddFile.Location = new System.Drawing.Point(398, 2);
		btnAddFile.Name = "btnAddFile";
		btnAddFile.Size = new System.Drawing.Size(25, 25);
		btnAddFile.TabIndex = 4;
		toolTip_0.SetToolTip(btnAddFile, "Thêm thư mục");
		btnAddFile.Click += new System.EventHandler(F191E30F);
		cbbTinhTrang.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTinhTrang.DropDownHeight = 200;
		cbbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTinhTrang.DropDownWidth = 300;
		cbbTinhTrang.FormattingEnabled = true;
		cbbTinhTrang.IntegralHeight = false;
		cbbTinhTrang.ItemHeight = 16;
		cbbTinhTrang.Items.AddRange(new object[1] { "[Tất cả tình trạng]" });
		cbbTinhTrang.Location = new System.Drawing.Point(271, 3);
		cbbTinhTrang.Name = "cbbTinhTrang";
		cbbTinhTrang.Size = new System.Drawing.Size(121, 24);
		cbbTinhTrang.TabIndex = 3;
		cbbTinhTrang.SelectedIndexChanged += new System.EventHandler(cbbTinhTrang_SelectedIndexChanged);
		cbbThuMuc.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbThuMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbThuMuc.DropDownWidth = 350;
		cbbThuMuc.FormattingEnabled = true;
		cbbThuMuc.ItemHeight = 16;
		cbbThuMuc.Location = new System.Drawing.Point(67, 3);
		cbbThuMuc.Name = "cbbThuMuc";
		cbbThuMuc.Size = new System.Drawing.Size(167, 24);
		cbbThuMuc.TabIndex = 1;
		cbbThuMuc.SelectedIndexChanged += new System.EventHandler(cbbThuMuc_SelectedIndexChanged);
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(235, 5);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(31, 16);
		label2.TabIndex = 2;
		label2.Text = "Lọc:";
		EDBAB4B7.AutoSize = true;
		EDBAB4B7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EDBAB4B7.Location = new System.Drawing.Point(4, 6);
		EDBAB4B7.Name = "label1";
		EDBAB4B7.Size = new System.Drawing.Size(63, 16);
		EDBAB4B7.TabIndex = 0;
		EDBAB4B7.Text = "Thư mục:";
		A18F7693.BackColor = System.Drawing.Color.White;
		A18F7693.Cursor = System.Windows.Forms.Cursors.Hand;
		A18F7693.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A18F7693.Image = Resource.B73FE39C;
		A18F7693.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		A18F7693.Location = new System.Drawing.Point(524, 1);
		A18F7693.Name = "button9";
		A18F7693.Size = new System.Drawing.Size(130, 27);
		A18F7693.TabIndex = 7;
		A18F7693.Text = "Nhập tài khoản";
		A18F7693.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		A18F7693.UseVisualStyleBackColor = true;
		A18F7693.Click += new System.EventHandler(CE3E348C);
		cbbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbSearch.DropDownWidth = 100;
		cbbSearch.FormattingEnabled = true;
		cbbSearch.Location = new System.Drawing.Point(3, 3);
		cbbSearch.Name = "cbbSearch";
		cbbSearch.Size = new System.Drawing.Size(86, 24);
		cbbSearch.TabIndex = 0;
		FFAFC3B3.BorderColor = System.Drawing.Color.SeaGreen;
		FFAFC3B3.Location = new System.Drawing.Point(95, 3);
		FFAFC3B3.Name = "txbSearch";
		FFAFC3B3.Size = new System.Drawing.Size(144, 23);
		FFAFC3B3.TabIndex = 1;
		FFAFC3B3.KeyDown += new System.Windows.Forms.KeyEventHandler(FFAFC3B3_KeyDown);
		statusStrip1.BackColor = System.Drawing.SystemColors.Control;
		statusStrip1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[18]
		{
			EBA6FB27, lblStatus, DA0FAD16, lblKey, E7A0700F, txbUid, lblUser, toolStripStatusLabel9, toolStripStatusLabel10, lblDateExpried,
			toolStripStatusLabel4, CCACF12E, CE1C833B, lblCountSelect, toolStripStatusLabel2, lblCountTotal, D30FF534, lblCountDeviceRunning
		});
		statusStrip1.Location = new System.Drawing.Point(0, 586);
		statusStrip1.Name = "statusStrip1";
		statusStrip1.Size = new System.Drawing.Size(1243, 22);
		statusStrip1.SizingGrip = false;
		statusStrip1.TabIndex = 9;
		statusStrip1.Text = "statusStrip1";
		statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(FC37A68F);
		EBA6FB27.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EBA6FB27.Name = "toolStripStatusLabel1";
		EBA6FB27.Size = new System.Drawing.Size(78, 17);
		EBA6FB27.Text = "Trạng thái:";
		lblStatus.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.ForeColor = System.Drawing.Color.Green;
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(97, 17);
		lblStatus.Text = "Đang kiê\u0309m tra...";
		DA0FAD16.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DA0FAD16.Name = "toolStripStatusLabel3";
		DA0FAD16.Size = new System.Drawing.Size(81, 17);
		DA0FAD16.Text = "Mã thiết bị:";
		lblKey.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblKey.ForeColor = System.Drawing.Color.Teal;
		lblKey.Name = "lblKey";
		lblKey.Size = new System.Drawing.Size(49, 17);
		lblKey.Text = "******";
		E7A0700F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E7A0700F.Name = "toolStripStatusLabel8";
		E7A0700F.Size = new System.Drawing.Size(41, 17);
		E7A0700F.Text = "User:";
		txbUid.Name = "txbUid";
		txbUid.Size = new System.Drawing.Size(0, 17);
		lblUser.Name = "lblUser";
		lblUser.Size = new System.Drawing.Size(55, 17);
		lblUser.Text = "******";
		toolStripStatusLabel9.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel9.IsLink = true;
		toolStripStatusLabel9.Name = "toolStripStatusLabel9";
		toolStripStatusLabel9.Size = new System.Drawing.Size(66, 17);
		toolStripStatusLabel9.Text = "Đăng xuâ\u0301t";
		toolStripStatusLabel9.Click += new System.EventHandler(toolStripStatusLabel9_Click);
		toolStripStatusLabel10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel10.Name = "toolStripStatusLabel10";
		toolStripStatusLabel10.Size = new System.Drawing.Size(98, 17);
		toolStripStatusLabel10.Text = "Ngày hết hạn:";
		lblDateExpried.Name = "lblDateExpried";
		lblDateExpried.Size = new System.Drawing.Size(73, 17);
		lblDateExpried.Text = "20/10/2020";
		toolStripStatusLabel4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel4.Name = "toolStripStatusLabel4";
		toolStripStatusLabel4.Size = new System.Drawing.Size(59, 17);
		toolStripStatusLabel4.Text = "Bôi đen:";
		toolStripStatusLabel4.Click += new System.EventHandler(BBBC911D);
		CCACF12E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CCACF12E.ForeColor = System.Drawing.Color.Blue;
		CCACF12E.Name = "lblCountHighline";
		CCACF12E.Size = new System.Drawing.Size(15, 17);
		CCACF12E.Text = "0";
		CE1C833B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CE1C833B.Name = "toolStripStatusLabel5";
		CE1C833B.Size = new System.Drawing.Size(65, 17);
		CE1C833B.Text = "Đã chọn:";
		lblCountSelect.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountSelect.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
		lblCountSelect.Name = "lblCountSelect";
		lblCountSelect.Size = new System.Drawing.Size(15, 17);
		lblCountSelect.Text = "0";
		toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel2.Name = "toolStripStatusLabel2";
		toolStripStatusLabel2.Size = new System.Drawing.Size(52, 17);
		toolStripStatusLabel2.Text = "Tất cả:";
		lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountTotal.ForeColor = System.Drawing.Color.Maroon;
		lblCountTotal.Name = "lblCountTotal";
		lblCountTotal.Size = new System.Drawing.Size(15, 17);
		lblCountTotal.Text = "0";
		D30FF534.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D30FF534.Name = "toolStripStatusLabel7";
		D30FF534.Size = new System.Drawing.Size(111, 17);
		D30FF534.Text = "Device Running:";
		lblCountDeviceRunning.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountDeviceRunning.ForeColor = System.Drawing.Color.DarkGreen;
		lblCountDeviceRunning.Name = "lblCountDeviceRunning";
		lblCountDeviceRunning.Size = new System.Drawing.Size(15, 17);
		lblCountDeviceRunning.Text = "0";
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_1.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 30000;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 40;
		btnPause.BackColor = System.Drawing.Color.White;
		btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
		btnPause.Enabled = false;
		btnPause.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnPause.Image = (System.Drawing.Image)resources.GetObject("btnPause.Image");
		btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		btnPause.Location = new System.Drawing.Point(144, 70);
		btnPause.Name = "btnPause";
		btnPause.Size = new System.Drawing.Size(128, 32);
		btnPause.TabIndex = 3;
		btnPause.Text = "Dừng Tương Tác      ";
		toolTip_0.SetToolTip(btnPause, "Dư\u0300ng tương ta\u0301c");
		btnPause.UseVisualStyleBackColor = true;
		btnPause.Click += new System.EventHandler(AB9C0B0B);
		btnInteract.Cursor = System.Windows.Forms.Cursors.Hand;
		btnInteract.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnInteract.Image = (System.Drawing.Image)resources.GetObject("btnInteract.Image");
		btnInteract.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		btnInteract.Location = new System.Drawing.Point(8, 70);
		btnInteract.Name = "btnInteract";
		btnInteract.Size = new System.Drawing.Size(128, 32);
		btnInteract.TabIndex = 2;
		btnInteract.Text = "Chạy Tương Tác      ";
		toolTip_0.SetToolTip(btnInteract, "Bă\u0301t đâ\u0300u cha\u0323y tương ta\u0301c");
		btnInteract.UseVisualStyleBackColor = false;
		btnInteract.Click += new System.EventHandler(btnInteract_Click);
		plTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		plTrangThai.BackColor = System.Drawing.Color.Gainsboro;
		plTrangThai.Controls.Add(lblTrangThai);
		plTrangThai.Location = new System.Drawing.Point(869, 36);
		plTrangThai.Name = "plTrangThai";
		plTrangThai.Size = new System.Drawing.Size(373, 26);
		plTrangThai.TabIndex = 10;
		plTrangThai.Visible = false;
		lblTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
		lblTrangThai.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblTrangThai.Location = new System.Drawing.Point(0, 0);
		lblTrangThai.Name = "lblTrangThai";
		lblTrangThai.Size = new System.Drawing.Size(373, 26);
		lblTrangThai.TabIndex = 0;
		lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(plQuanLyThuMuc);
		panel1.Controls.Add(panel2);
		panel1.Controls.Add(btnPause);
		panel1.Controls.Add(statusStrip1);
		panel1.Controls.Add(btnInteract);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(1245, 610);
		panel1.TabIndex = 11;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		plQuanLyThuMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plQuanLyThuMuc.Controls.Add(cbbThuMuc);
		plQuanLyThuMuc.Controls.Add(cbbTinhTrang);
		plQuanLyThuMuc.Controls.Add(EA12B498);
		plQuanLyThuMuc.Controls.Add(EDBAB4B7);
		plQuanLyThuMuc.Controls.Add(btnEditFile);
		plQuanLyThuMuc.Controls.Add(A18F7693);
		plQuanLyThuMuc.Controls.Add(btnDeleteFile);
		plQuanLyThuMuc.Controls.Add(label2);
		plQuanLyThuMuc.Controls.Add(btnAddFile);
		plQuanLyThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		plQuanLyThuMuc.Location = new System.Drawing.Point(577, 71);
		plQuanLyThuMuc.Name = "plQuanLyThuMuc";
		plQuanLyThuMuc.Size = new System.Drawing.Size(657, 31);
		plQuanLyThuMuc.TabIndex = 10;
		panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel2.Controls.Add(BtnSearch);
		panel2.Controls.Add(cbbSearch);
		panel2.Controls.Add(FFAFC3B3);
		panel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		panel2.Location = new System.Drawing.Point(297, 71);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(274, 31);
		panel2.TabIndex = 10;
		BtnSearch.BackgroundImage = Resource.Bitmap_133;
		BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
		BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BtnSearch.Location = new System.Drawing.Point(245, 3);
		BtnSearch.Name = "BtnSearch";
		BtnSearch.Size = new System.Drawing.Size(24, 23);
		BtnSearch.TabIndex = 4;
		BtnSearch.Click += new System.EventHandler(B0062D3F);
		notifyIcon_0.Text = "notifyIcon1";
		notifyIcon_0.Visible = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1245, 610);
		base.Controls.Add(plTrangThai);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(menuStrip1);
		base.Controls.Add(dtgvAcc);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MainMenuStrip = menuStrip1;
		base.Name = "fMain";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "MAX PHONE FARM";
		base.Load += new System.EventHandler(fMain_Load);
		((System.ComponentModel.ISupportInitialize)dtgvAcc).EndInit();
		ctmsAcc.ResumeLayout(false);
		DF05800B.ResumeLayout(false);
		DF05800B.PerformLayout();
		((System.ComponentModel.ISupportInitialize)picLanguage).EndInit();
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		bunifuCards1.ResumeLayout(false);
		menuStrip1.ResumeLayout(false);
		menuStrip1.PerformLayout();
		statusStrip1.ResumeLayout(false);
		statusStrip1.PerformLayout();
		plTrangThai.ResumeLayout(false);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plQuanLyThuMuc.ResumeLayout(false);
		plQuanLyThuMuc.PerformLayout();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_136()
	{
		if (plTrangThai.Visible)
		{
			plTrangThai.Visible = false;
		}
	}

	[CompilerGenerated]
	private void method_137()
	{
		foreach (DataGridViewColumn column in dtgvAcc.Columns)
		{
			column.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
	}

	[CompilerGenerated]
	private void method_138()
	{
		foreach (DataGridViewColumn column in dtgvAcc.Columns)
		{
			column.SortMode = DataGridViewColumnSortMode.Automatic;
		}
	}

	[CompilerGenerated]
	private void method_139()
	{
		method_19();
	}
}
