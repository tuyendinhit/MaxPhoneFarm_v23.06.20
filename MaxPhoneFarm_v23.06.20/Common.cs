using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Ionic.Zip;
using Newtonsoft.Json.Linq;
using OpenCvSharp;
using RestSharp;
using static OpenCvSharp.ML.LogisticRegression;

public class Common
{
	internal static Random rd;

	internal static int A6900AB9;

	internal static int int_0;

	internal static object D2201231;

	internal static string string_0;

	public static string smethod_0()
	{
		return "cccc";
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckLicense(byte[] byte_0, byte[] byte_1, byte[] byte_2);

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetApiToken(byte[] BBAD5E09, byte[] byte_0, byte[] byte_1);

	public static string DCA2B4A5(IntPtr E6271113)
	{
		try
		{
			string s = Marshal.PtrToStringAnsi(E6271113);
			byte[] bytes = Encoding.Default.GetBytes(s);
			return Encoding.UTF8.GetString(bytes);
		}
		catch
		{
		}
		return "";
	}

	public static byte[] smethod_1(string string_1)
	{
		try
		{
			return Encoding.UTF8.GetBytes(string_1);
		}
		catch
		{
		}
		return null;
	}

	public static string smethod_2(string string_1, string string_2)
	{
		string text = Base.string_0;
		string text2 = "";
		for (int i = 0; i < 2; i++)
		{
			text2 = DCA2B4A5(CheckLicense(Encoding.UTF8.GetBytes(text), Encoding.UTF8.GetBytes(string_1), Encoding.UTF8.GetBytes(string_2)));
			if (!(text2 == ""))
			{
				break;
			}
			text = text.Replace("https://", "http://");
		}
		return text2;
	}

	public static string smethod_3(string D61BDD3E, string string_1)
	{
		string text = Base.string_0;
		string text2 = "";
		for (int i = 0; i < 2; i++)
		{
			text2 = DCA2B4A5(GetApiToken(Encoding.UTF8.GetBytes(text), Encoding.UTF8.GetBytes(D61BDD3E), Encoding.UTF8.GetBytes(string_1)));
			if (!(text2 == ""))
			{
				break;
			}
			text = text.Replace("https://", "http://");
		}
		return text2;
	}

	public static void EDB3F1B7(string E0399BBC)
	{
		fDownloadFile fDownloadFile2 = new fDownloadFile(E0399BBC);
		fDownloadFile2.ShowDialog();
	}

	public static void D936DD84(RichTextBox F58992BD, Control B5977534, int B5968D3F = 0)
	{
		try
		{
			string text = B5977534.Text;
			List<string> list = new List<string>();
			list = ((B5968D3F != 0) ? F58992BD.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : F58992BD.Lines.ToList());
			list = RemoveEmptyItems(list);
			B5977534.Text = text.Replace(Regex.Match(text, "\\((.*?)\\)").Value, "(" + list.Count + ")");
		}
		catch
		{
		}
	}

	public static void DB181F2D(Control control_0, int int_1)
	{
		try
		{
			string text = control_0.Text;
			control_0.Text = text.Replace(Regex.Match(text, "\\((.*?)\\)").Value, "(" + int_1 + ")");
		}
		catch
		{
		}
	}

	public static List<string> E00852A6(string E710CD25)
	{
		return File.ReadAllText(E710CD25).Split(new string[2] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries).ToList();
	}

	public static bool C19E7306(int int_1)
	{
		int num = Base.rd.Next(1, 101);
		if (num <= int_1)
		{
			return true;
		}
		return false;
	}

	public static void smethod_4(string string_1, string string_2, string string_3 = "tungmin")
	{
		try
		{
			using ZipFile zipFile = new ZipFile();
			if (string_3 != "")
			{
				zipFile.Password = string_3;
			}
			zipFile.AddDirectory(string_1);
			zipFile.Save(string_2);
		}
		catch (Exception)
		{
		}
	}

	public static void D1852B21(string string_1, string CF3E0600, string D12BFCA6 = "tungmin")
	{
		try
		{
			using ZipFile zipFile = new ZipFile(string_1, Encoding.UTF8);
			if (D12BFCA6 != "")
			{
				zipFile.Password = D12BFCA6;
			}
			zipFile.ExtractAll(CF3E0600, ExtractExistingFileAction.OverwriteSilently);
		}
		catch (Exception)
		{
		}
	}

	public static bool smethod_5(string string_1)
	{
		try
		{
			FormCollection openForms = Application.OpenForms;
			foreach (Form item in openForms)
			{
				if (item.Name == string_1)
				{
					return true;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool D58FD026(string string_1)
	{
		try
		{
			FormCollection openForms = Application.OpenForms;
			foreach (Form form_0 in openForms)
			{
				if (form_0.Name == string_1)
				{
					form_0.Invoke((MethodInvoker)delegate
					{
						form_0.Close();
					});
					break;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	public static string C2391A8D(object F9375714)
	{
		string text = "";
		try
		{
			PropertyInfo[] properties = F9375714.GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				text = text + propertyInfo.GetValue(F9375714)?.ToString() + ",";
			}
			text = text.TrimEnd(',');
		}
		catch
		{
		}
		return text;
	}

	public static List<string> D8190238(List<string> list_0, List<string> EBB1FDA1)
	{
		List<string> result = new List<string>();
		try
		{
			result = list_0.Intersect(EBB1FDA1).ToList();
		}
		catch
		{
		}
		return result;
	}

	public static List<string> E91CEBAC(List<string> list_0, List<string> list_1)
	{
		List<string> result = new List<string>();
		try
		{
			result = list_0.Except(list_1).ToList();
		}
		catch
		{
		}
		return result;
	}

	private static void smethod_6(string E614D384)
	{
		ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + E614D384 + "\" enable");
		Process process = new Process();
		process.StartInfo = startInfo;
		process.Start();
	}

	private static void ADB50287(string string_1)
	{
		ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + string_1 + "\" disable");
		Process process = new Process();
		process.StartInfo = startInfo;
		process.Start();
	}

	public static string smethod_7(string string_1)
	{
		try
		{
			return Directory.GetCreationTime(string_1).ToString("yyyy/MM/dd HH:mm:ss");
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_8(string B190DFBB)
	{
		try
		{
			return File.GetCreationTime(B190DFBB).ToString("yyyy/MM/dd HH:mm:ss");
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_9(ref List<string> DB8AC71E, Random random_1)
	{
		string text = "";
		try
		{
			int index = random_1.Next(0, DB8AC71E.Count);
			text = DB8AC71E[index];
			DB8AC71E.RemoveAt(index);
		}
		catch (Exception)
		{
			throw;
		}
		return text;
	}

	public static string smethod_10(int int_1)
	{
		try
		{
			TimeSpan.FromSeconds(int_1);
			if (int_1 < 60)
			{
				return TimeSpan.FromSeconds(int_1).ToString("ss");
			}
			if (int_1 < 3600)
			{
				return TimeSpan.FromSeconds(int_1).ToString("mm\\:ss");
			}
			return TimeSpan.FromSeconds(int_1).ToString("hh\\:mm\\:ss");
		}
		catch
		{
			return "";
		}
	}

	public static void E08E7930(string string_1, string string_2, string string_3, string string_4, string string_5 = "C:\\Program Files (x86)\\Google\\Chrome\\Application", string B11A779E = "C:\\Users\\Xuan Tung\\Desktop\\MaxUid\\images\\icon_64.ico")
	{
		string text = Path.Combine(string_2, string_1 + ".lnk");
		GInterface1 gInterface = (GInterface1)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
		GInterface0 gInterface2 = (GInterface0)(dynamic)gInterface.imethod_0(text);
		gInterface2.String_1 = "Shortcut Chrome MIN Software";
		gInterface2.D8BF1F8D = string_5;
		gInterface2.String_2 = B11A779E;
		gInterface2.C18140B5 = string_3;
		gInterface2.String_0 = string_4;
		gInterface2.imethod_0();
	}

	public static List<string> smethod_11(List<string> CE05019E)
	{
		List<string> list = new List<string>();
		try
		{
			for (int i = 0; i < CE05019E.Count; i++)
			{
				list.Add(CE05019E[i]);
			}
		}
		catch
		{
		}
		return list;
	}

	public static string SpinText(string text)
	{
        string pattern = "{[^{}]*}";
        Match match = Regex.Match(text, pattern);
        while (match.Success)
        {
            string[] array = text.Substring(match.Index + 1, match.Length - 2).Split('|');
            text = text.Substring(0, match.Index) + array[Base.rd.Next(array.Length)] + text.Substring(match.Index + match.Length);
            match = Regex.Match(text, pattern);
        }
        text = GetIconFacebook.ProcessString(text);
        return text;
    }
    public static bool IsNumber(string pValue)
    {
        if (pValue == "")
        {
            return false;
        }
        for (int i = 0; i < pValue.Length; i++)
        {
            if (!char.IsDigit(pValue[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static bool SetTextToClipboard(string string_1)
	{
		bool result = false;
		try
		{
			Clipboard.SetText(string_1);
			result = true;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void smethod_12(string string_1, string string_2 = "Nhập danh sách Uid cần clone", string string_3 = "Danh sách Uid", string CDBE788B = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})")
	{
		try
		{
			if (!File.Exists(string_1))
			{
				smethod_14(string_1);
			}
			smethod_16(new fNhapDuLieu1(string_1, string_2, string_3, CDBE788B));
		}
		catch
		{
		}
	}

	public static DateTime DC8AAF95(double double_0)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(double_0).ToLocalTime();
	}

	public static Form smethod_13(string E83A7508, string E7157DB6)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Type[] types = executingAssembly.GetTypes();
		int num = 0;
		while (true)
		{
			if (num < types.Length)
			{
				Type type = types[num];
				if (type.BaseType != null && type.BaseType.FullName == "System.Windows.Forms.Form" && type.FullName == E83A7508)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return Activator.CreateInstance(Type.GetType(E83A7508), "", 1, E7157DB6) as Form;
	}

	public static void smethod_14(string string_1)
	{
		try
		{
			if (!File.Exists(string_1))
			{
				File.AppendAllText(string_1, "");
			}
		}
		catch
		{
		}
	}

	public static void F0A2131B(DataGridView D12EC5AE)
	{
		for (int i = 0; i < D12EC5AE.RowCount; i++)
		{
			D12EC5AE.Rows[i].Selected = false;
		}
	}

	public static void CreateFolder(string string_1)
	{
		try
		{
			if (!Directory.Exists(string_1))
			{
				Directory.CreateDirectory(string_1);
			}
		}
		catch
		{
		}
	}

	public static void smethod_16(Form form_0)
	{
		try
		{
			form_0.ShowInTaskbar = false;
			form_0.ShowDialog();
		}
		catch
		{
		}
	}

	public static List<int> smethod_17(List<int> list_0)
	{
		int num = 0;
		int num2 = list_0.Count;
		int num3 = 0;
		while (num2 != 0)
		{
			num3 = Base.rd.Next(0, list_0.Count);
			num2--;
			num = list_0[num2];
			list_0[num2] = list_0[num3];
			list_0[num3] = num;
		}
		return list_0;
	}

	public static List<string> F78FD80F(List<string> list_0)
	{
		string text = "";
		int num = list_0.Count;
		int num2 = 0;
		while (num != 0)
		{
			num2 = Base.rd.Next(0, list_0.Count);
			num--;
			text = list_0[num];
			list_0[num] = list_0[num2];
			list_0[num2] = text;
		}
		return list_0;
	}

	public static List<string> RemoveEmptyItems(List<string> F1808BA3)
	{
		List<string> list = new List<string>();
		string text = "";
		for (int i = 0; i < F1808BA3.Count; i++)
		{
			text = F1808BA3[i].Trim();
			if (text != "")
			{
				list.Add(text);
			}
		}
		return list;
	}

	public static string smethod_19(string string_1, string string_2, int int_1 = 10)
	{
		Process process = new Process();
		process.StartInfo.FileName = string_1;
		process.StartInfo.Arguments = string_2;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardError = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
		process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
		StringBuilder E110592B = new StringBuilder();
		process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				E110592B.Append(e.Data + "\n");
			}
		};
		process.Start();
		process.BeginOutputReadLine();
		if (int_1 < 0)
		{
			process.WaitForExit();
		}
		else
		{
			process.WaitForExit(int_1 * 1000);
		}
		process.Close();
		return E110592B.ToString();
	}

	public static bool F23FCB3D(string DD97D8B9)
	{
		bool flag = false;
		string text = smethod_19("rasdial.exe", "\"" + DD97D8B9 + "\"", 3);
		if (text.Contains("Successfully connected to "))
		{
			flag = true;
		}
		else if (text.Contains("You are already connected to "))
		{
			for (int i = 0; i < 3; i++)
			{
				text = smethod_19("rasdial.exe", "\"" + DD97D8B9 + "\" /disconnect", 3);
				if (!(text.Trim() == "Command completed successfully."))
				{
					DelayTime(1.0);
					continue;
				}
				flag = true;
				break;
			}
			DelayTime(1.0);
			if (flag)
			{
				for (int j = 0; j < 3; j++)
				{
					text = smethod_19("rasdial.exe", "\"" + DD97D8B9 + "\"", 3);
					if (!text.Contains("Successfully connected to "))
					{
						DelayTime(1.0);
						continue;
					}
					flag = true;
					break;
				}
			}
			DelayTime(1.0);
		}
		else
		{
			flag = false;
		}
		return flag;
	}

	public static string smethod_20(string FC90FF9B, string FA91F432)
	{
		if (!FC90FF9B.EndsWith(FA91F432))
		{
			return FC90FF9B;
		}
		return FC90FF9B.Remove(FC90FF9B.LastIndexOf(FA91F432));
	}

	public static void smethod_21(DataGridView dataGridView_0, string BDB34F05, char char_0 = '|')
	{
		List<string> list = new List<string>();
		string text = "";
		object obj = null;
		for (int i = 0; i < dataGridView_0.RowCount; i++)
		{
			text = "";
			for (int j = 0; j < dataGridView_0.ColumnCount; j++)
			{
				obj = dataGridView_0.Rows[i].Cells[j].Value;
				text += ((obj == null) ? char_0.ToString() : (obj?.ToString() + char_0));
			}
			text = text.TrimEnd(char_0);
			list.Add(text);
		}
		File.WriteAllLines(BDB34F05, list);
	}

	public static void smethod_22(DataGridView dataGridView_0, string DDA34C90, char char_0 = '|')
	{
		if (!File.Exists(DDA34C90))
		{
			smethod_14(DDA34C90);
		}
		List<string> list = File.ReadAllLines(DDA34C90).ToList();
		string text = "";
		if (list.Count > 0)
		{
			for (int i = 0; i < list.Count; i++)
			{
				text = list[i];
				DataGridViewRowCollection rows = dataGridView_0.Rows;
				object[] values = text.Split(char_0);
				rows.Add(values);
			}
		}
	}

	public static string F68F9C11(string string_1 = "")
	{
		string result = "";
		try
		{
			F399DFB5 f399DFB = new F399DFB5
			{
				String_1 = "Select a folder"
			};
			if (!string.IsNullOrEmpty(string_1))
			{
				f399DFB.String_0 = string_1;
			}
			if (f399DFB.A00CD39B())
			{
				result = f399DFB.String_2;
			}
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_23(string A987CDAD = "Chọn File txt", string string_1 = "txt Files (*.txt)|*.txt|")
	{
		string result = "";
		try
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = string_1 + "All files (*.*)|*.*";
			openFileDialog.Title = A987CDAD;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				result = openFileDialog.FileName;
			}
		}
		catch
		{
		}
		return result;
	}

	public static void smethod_24(string string_1)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_1);
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch
		{
		}
	}

	public static bool smethod_25(string string_1)
	{
		bool result = true;
		foreach (char c in string_1)
		{
			if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != '.')
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public static string smethod_26(string string_1)
	{
		string text = "";
		for (int i = 0; i < string_1.Length; i++)
		{
			char c = string_1[i];
			if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
			{
				text += c;
			}
		}
		return text;
	}

	public static string smethod_27(string string_1)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_1);
		string_1 = Encoding.UTF8.GetString(bytes);
		return string_1;
	}

	public static bool smethod_28(string string_1)
	{
		if (string_1 == "")
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < string_1.Length)
			{
				char c = string_1[num];
				if (!char.IsDigit(c))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static int smethod_29(string string_1)
	{
		if (smethod_28(string_1))
		{
			return Convert.ToInt32(string_1);
		}
		return 0;
	}

	public static bool smethod_30(string string_1)
	{
		int num = 0;
		while (true)
		{
			if (num < string_1.Length)
			{
				char c = string_1[num];
				if (char.IsDigit(c))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void smethod_31(string F0975012)
	{
		string text = "zzz999.html";
		File.WriteAllText(text, F0975012);
		Process.Start(text);
	}

	public static string ED086A87(string string_1)
	{
		try
		{
			return new RequestXNet("", "", "", 0).RequestGet(string_1);
		}
		catch
		{
			return null;
		}
	}

	public static bool C306AF9D(string FF002993)
	{
		try
		{
			new MailAddress(FF002993);
			return true;
		}
		catch (FormatException)
		{
			return false;
		}
	}

	public static string D71CCDB7(string C82BAE29, string EE83DCAC = "X2")
	{
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(C82BAE29));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString(EE83DCAC));
		}
		return stringBuilder.ToString();
	}

	public static string BB0F571B(string string_1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		return Convert.ToBase64String(bytes);
	}

	public static string B537BA12(string string_1)
	{
		byte[] bytes = Convert.FromBase64String(string_1);
		return Encoding.UTF8.GetString(bytes);
	}

    public static string CreateRandomStringNumber(int int_2, Random random_1 = null)
    {
        string text = "";
        if (random_1 == null)
        {
            random_1 = new Random();
        }
        string text2 = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        for (int i = 0; i < int_2; i++)
        {
            text += text2[random_1.Next(0, text2.Length)];
        }
        return text;
    }

    public static string CreateRandomString(int int_2, Random random_1 = null)
	{
        string text = "";
        if (random_1 == null)
        {
            random_1 = Base.rd;
        }
        string text2 = "abcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < int_2; i++)
        {
            text += text2[random_1.Next(0, text2.Length)];
        }
        return text;
    }

    public static string CreateRandomNumber(int DD89F9AF, Random random_1 = null)
    {
        string text = "";
        if (random_1 == null)
        {
            random_1 = new Random();
        }
        string text2 = "0123456789";
        for (int i = 0; i < DD89F9AF; i++)
        {
            text += text2[random_1.Next(0, text2.Length)];
        }
        return text;
    }

    public static string A8AF5A8E(string string_1)
	{
		Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
		string input = string_1.Normalize(NormalizationForm.FormD);
		return regex.Replace(input, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
	}

	public static string RunCMD(string string_1, int A908E9A9 = 10)
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + string_1;
			process.StartInfo.Verb = "runas";
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
			process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
			StringBuilder stringBuilder_0 = new StringBuilder();
			process.OutputDataReceived += delegate(object sender, DataReceivedEventArgs e)
			{
				if (!string.IsNullOrEmpty(e.Data))
				{
					stringBuilder_0.Append(e.Data + "\n");
				}
			};
			process.Start();
			process.BeginOutputReadLine();
			process.WaitForExit((A908E9A9 < 0) ? (-1) : (A908E9A9 * 1000));
			process.Close();
			result = stringBuilder_0.ToString().Trim();
		}
		catch
		{
		}
		return result;
	}

	public static void DelayTime(double A9898F27)
	{
		Application.DoEvents();
		Thread.Sleep(Convert.ToInt32(A9898F27 * 1000.0));
	}

	public static string smethod_35(string string_1)
	{
		return WebUtility.HtmlDecode(string_1);
	}

	public static string smethod_36(string string_1)
	{
		return WebUtility.HtmlEncode(string_1);
	}

	public static string smethod_37(string string_1)
	{
		return WebUtility.UrlDecode(string_1);
	}

	public static string smethod_38(string B402B3B7)
	{
		return WebUtility.UrlEncode(B402B3B7);
	}

	public static System.Drawing.Point smethod_39()
	{
		if (SettingsTool.GetSettings("configChrome").method_0("width") == 0)
		{
			SettingsTool.GetSettings("configChrome").GetValue("width", A6900AB9);
			SettingsTool.GetSettings("configChrome").GetValue("heigh", int_0);
			SettingsTool.smethod_0("configChrome");
		}
		A6900AB9 = SettingsTool.GetSettings("configChrome").method_0("width");
		int_0 = SettingsTool.GetSettings("configChrome").method_0("heigh");
		return new System.Drawing.Point(A6900AB9, int_0);
	}

	public static System.Drawing.Point smethod_40(int int_1, int F087ED9A)
	{
		System.Drawing.Point point = smethod_39();
		A6900AB9 = point.X;
		int_0 = point.Y;
		int x = A6900AB9 / int_1 + 15;
		int y = int_0 / F087ED9A + 10;
		return new System.Drawing.Point(x, y);
	}

	public static System.Drawing.Point AC17F101(int int_1, int int_2, int int_3)
	{
		System.Drawing.Point point = smethod_39();
		A6900AB9 = point.X;
		int_0 = point.Y;
		System.Drawing.Point result = default(System.Drawing.Point);
		while (int_1 >= int_2 * int_3)
		{
			int_1 -= int_2 * int_3;
		}
		switch (int_3)
		{
		case 1:
			result.Y = 0;
			break;
		case 2:
			if (int_1 < int_2)
			{
				result.Y = 0;
			}
			else if (int_1 < int_2 * 2)
			{
				result.Y = int_0 / 2;
				int_1 -= int_2;
			}
			break;
		case 3:
			if (int_1 < int_2)
			{
				result.Y = 0;
			}
			else if (int_1 < int_2 * 2)
			{
				result.Y = int_0 / 3;
				int_1 -= int_2;
			}
			else if (int_1 < int_2 * 3)
			{
				result.Y = int_0 / 3 * 2;
				int_1 -= int_2 * 2;
			}
			break;
		case 4:
			if (int_1 < int_2)
			{
				result.Y = 0;
			}
			else if (int_1 < int_2 * 2)
			{
				result.Y = int_0 / 4;
				int_1 -= int_2;
			}
			else if (int_1 < int_2 * 3)
			{
				result.Y = int_0 / 4 * 2;
				int_1 -= int_2 * 2;
			}
			else if (int_1 < int_2 * 4)
			{
				result.Y = int_0 / 4 * 3;
				int_1 -= int_2 * 3;
			}
			break;
		case 5:
			if (int_1 < int_2)
			{
				result.Y = 0;
			}
			else if (int_1 < int_2 * 2)
			{
				result.Y = int_0 / 5;
				int_1 -= int_2;
			}
			else if (int_1 < int_2 * 3)
			{
				result.Y = int_0 / 5 * 2;
				int_1 -= int_2 * 2;
			}
			else if (int_1 < int_2 * 4)
			{
				result.Y = int_0 / 5 * 3;
				int_1 -= int_2 * 3;
			}
			else
			{
				result.Y = int_0 / 5 * 4;
				int_1 -= int_2 * 4;
			}
			break;
		}
		int num = A6900AB9 / int_2;
		result.X = int_1 * num - 10;
		return result;
	}

	public static int F1924C3A(ref List<int> list_0)
	{
		int result = 0;
		lock (list_0)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i] == 0)
				{
					result = i;
					list_0[i] = 1;
					break;
				}
			}
		}
		return result;
	}

	public static void EF8586BB(ref List<int> ADA6021A, int int_1)
	{
		lock (ADA6021A)
		{
			ADA6021A[int_1] = 0;
		}
	}

	public static double F38B1687(DateTime dateTime_0)
	{
		return (dateTime_0 - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds;
	}

	/*public static string CheckProxy(string AB35322B, int B03CE837, int FFB6761C = 0)
	{
		return CheckIP(AB35322B + "*" + B03CE837);
	}*/

	public static string CheckIP(string E518D3B9)
	{
        string result = "";
        try
        {
            RequestXNet fDA5E = new RequestXNet("", "", "", 0);
            string text = "";
            text = fDA5E.RequestGet("http://lumtest.com/myip.json");
            result = JObject.Parse(text)["ip"]!.ToString();
        }
        catch
        {
        }
        return result;
    }
    public static string CheckProxy(string proxy, int typeProxy)
    {
        string text = "";
        try
        {
            RequestXNet requestXNet = new RequestXNet("", SetupFolder.GetUseragentIPhone(rd), proxy, typeProxy);
            return requestXNet.RequestGet("https://api64.ipify.org/");
        }
        catch (Exception)
        {
            return CheckProxy2(proxy, typeProxy);
        }
    }
    public static string CheckProxy2(string proxy, int typeProxy)
    {
        string result = "";
        try
        {
            RequestXNet requestXNet = new RequestXNet("", SetupFolder.GetUseragentIPhone(rd), proxy, typeProxy);
            result = requestXNet.RequestGet("https://ipcuatoi.com/");
            result = requestXNet.RequestGet("http://v4v6.ipv6-test.com/api/myip.php");
        }
        catch (Exception ex)
        {
            ExportError(null, ex, "Check Proxy2");
        }
        return result;
    }
    /*public static string CheckProxy(string proxy, int typeProxy, int timeOut = 30)
    {
        string string_ = "";
        List<string> list = new List<string> { "https://icanhazip.com", "https://api.myip.com/", "https://api64.ipify.org/", "http://v4v6.ipv6-test.com/api/myip.php/" };
        try
        {
            int int_3 = 0;
            int count = list.Count;
            List<Thread> list2 = new List<Thread>();
            for (int i = 0; i < count; i++)
            {
                string url = list[i];
                Thread thread = new Thread((ThreadStart)delegate
                {
                    int tickCount = Environment.TickCount;
                    while (Environment.TickCount - tickCount < 20000)
                    {
                        string text = CheckProxy2(url, proxy, typeProxy);
                        if (text != "" && !text.Contains("html"))
                        {
                            string_ = text;
                            break;
                        }
                    }
                    Interlocked.Increment(ref int_3);
                });
                list2.Add(thread);
                thread.Start();
            }
            while (int_3 < count && string_ == "")
            {
                Thread.Sleep(1000);
            }
            foreach (Thread item in list2)
            {
                try
                {
                    item.Abort();
                }
                catch (Exception)
                {
                }
            }
        }
        catch
        {
        }
        return string_.Trim();
    }*/
    /*private static string CheckProxy2(string url, string proxy, int Type)
    {
        string text = "";
        try
        {
            RequestXNet req = new RequestXNet("", "", proxy, Type);
            req.http.AddHeader("Cache-Control", "no-cache");
            if (proxy != "")
            {
                req.http.Proxy.ConnectTimeout = 5000;
            }
            text = req.RequestGet(url);
            if (url == "https://api.myip.com/")
            {
                text = Regex.Match(text, "ip\":\"(.*?)\"").Groups[1].Value;
            }
        }
        catch (Exception)
        {
        }
        return text;
    }*/
    public static string GetTokenCookie(string string_1)
    {
        string path = Path.Combine(string_1, "data.vmdk");
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

    public static void ExportError(Chrome chrome, Exception exception_0, string string_1 = "")
	{
		try
		{
			if (!Directory.Exists("log"))
			{
				Directory.CreateDirectory("log");
			}
			if (!Directory.Exists("log\\html"))
			{
				Directory.CreateDirectory("log\\html");
			}
			if (!Directory.Exists("log\\images"))
			{
				Directory.CreateDirectory("log\\images");
			}
			Random random = new Random();
			string text = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + random.Next(1000, 9999);
			if (chrome != null)
			{
				string contents = chrome.F4AF93AB("var markup = document.documentElement.innerHTML;return markup;").ToString();
				chrome.method_32("log\\images\\", text);
				File.WriteAllText("log\\html\\" + text + ".html", contents);
			}
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			streamWriter.WriteLine("File: " + text);
			if (string_1 != "")
			{
				streamWriter.WriteLine("Error: " + string_1);
			}
			streamWriter.WriteLine();
			if (exception_0 != null)
			{
				streamWriter.WriteLine("Type: " + exception_0.GetType().FullName);
				streamWriter.WriteLine("Message: " + exception_0.Message);
				streamWriter.WriteLine("StackTrace: " + exception_0.StackTrace);
				exception_0 = exception_0.InnerException;
			}
		}
		catch
		{
		}
	}

	public static int B590F31A(DateTime CF97C1B5)
	{
		DateTime now = DateTime.Now;
		return Convert.ToInt32((CF97C1B5 - now).TotalSeconds);
	}

	public static void smethod_43(Exception A81E2315, string string_1 = "")
	{
		try
		{
			using StreamWriter streamWriter = new StreamWriter("log\\log.txt", append: true);
			streamWriter.WriteLine("-----------------------------------------------------------------------------");
			streamWriter.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			if (string_1 != "")
			{
				streamWriter.WriteLine("Error: " + string_1);
			}
			streamWriter.WriteLine();
			if (A81E2315 != null)
			{
				streamWriter.WriteLine("Type: " + A81E2315.GetType().FullName);
				streamWriter.WriteLine("Message: " + A81E2315.Message);
				streamWriter.WriteLine("StackTrace: " + A81E2315.StackTrace);
				A81E2315 = A81E2315.InnerException;
			}
		}
		catch
		{
		}
	}

	public static bool smethod_44(int FE3B4503, int int_1, string string_1, string F8BA100B, int A83C4B11, string string_2)
	{
		bool result = false;
		string text = "";
		try
		{
			switch (FE3B4503)
			{
			case 0:
				return true;
			case 1:
			{
				string text2 = CheckIP("");
				IntPtr intptr_ = GClass7.smethod_2(null, "HMA VPN");
				GClass7.smethod_0(intptr_);
				GClass7.smethod_9(GClass7.smethod_6(intptr_, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
				Thread.Sleep(5000);
				string text3 = CheckIP("");
				GClass7.smethod_9(GClass7.smethod_6(intptr_, "Chrome_RenderWidgetHostHWND", "Chrome Legacy Window"), 356, 286);
				int tickCount = Environment.TickCount;
				do
				{
					text = CheckIP("");
				}
				while (Environment.TickCount - tickCount <= 20000 && (text == text2 || text == text3));
				if (text != text2)
				{
					result = true;
				}
				break;
			}
			case 2:
			{
				if (int_1 == 0)
				{
					result = F23FCB3D(string_1);
					break;
				}
				int num = smethod_45(F8BA100B);
				if (num == 0)
				{
					Thread.Sleep(2000);
					num = smethod_45(F8BA100B);
				}
				result = num == 1;
				break;
			}
			}
		}
		catch (Exception exception_)
		{
			ExportError(null, exception_, "Error ChangeIP");
		}
		return result;
	}

	public static int smethod_45(string E71E7A8F)
	{
		int result = -1;
		try
		{
			string text = "http" + Regex.Match(E71E7A8F, "http(.*?)/html").Groups[1].Value;
			GClass13 gClass = new GClass13("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36");
			string input = gClass.method_0(E71E7A8F);
			string text2 = "";
			try
			{
				text2 = Regex.Matches(input, "csrf_token\" content=\"(.*?)\"")[1].Groups[1].Value;
			}
			catch
			{
				text2 = Regex.Match(gClass.method_0(text + "/api/webserver/token"), "<token>(.*?)</token>").Groups[1].Value;
			}
			input = gClass.method_0(text + "/api/dialup/mobile-dataswitch");
			gClass.F123C51A.SetDefaultHeaders(new string[8]
			{
				"__RequestVerificationToken: " + text2,
				"Accept: */*",
				"Accept-Encoding: gzip, deflate",
				"Accept-Language: vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5",
				"Content-Type: application/x-www-form-urlencoded; charset=UTF-8",
				"X-Requested-With: XMLHttpRequest",
				"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
				"user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36"
			});
			string text3 = "";
			if (input.Contains("dataswitch>1"))
			{
				text3 = input.Replace("response", "request").Replace("dataswitch>1", "dataswitch>0");
			}
			else
			{
				if (!input.Contains("dataswitch>0"))
				{
					return -1;
				}
				text3 = input.Replace("response", "request").Replace("dataswitch>0", "dataswitch>1");
			}
			string text4 = gClass.method_1(text + "/api/dialup/mobile-dataswitch", text3);
			if (text4.Contains("OK"))
			{
				input = gClass.method_0(text + "/api/dialup/mobile-dataswitch");
				if (input.Contains("dataswitch>1<"))
				{
					for (int i = 0; i < 10; i++)
					{
						string text5 = gClass.method_0(text + "/api/monitoring/traffic-statistics");
						if (!text5.Contains("<CurrentUpload>0"))
						{
							break;
						}
						Thread.Sleep(1000);
					}
				}
				return Convert.ToInt32(Regex.Match(input, "dataswitch>(.*?)<").Groups[1].Value);
			}
			result = -1;
		}
		catch
		{
		}
		return result;
	}

	public static DateTime F11F4A37(string string_1, string string_2 = "dd/MM/yyyy HH:mm:ss")
	{
		try
		{
			if (string_1.Trim() != "")
			{
				return DateTime.ParseExact(string_1, string_2, CultureInfo.InvariantCulture);
			}
		}
		catch (Exception)
		{
		}
		return DateTime.MinValue;
	}

	public static string GetTotp(string two2fa)
	{
        string text = "";
        using (WebClient web = new WebClient())
        {
            text = Regex.Match(web.DownloadString($"https://2fa.live/tok/{two2fa.Replace(" ", "").Trim()}"), ":\"(.*?)\"").Groups[1].Value;
        }
        return text;
    }

	public static DataTable smethod_46(DataTable dataTable_0, int AB819E9F = 1)
	{
		try
		{
			for (int i = 0; i < AB819E9F; i++)
			{
				dataTable_0 = (from DataRow AFB63B8F in dataTable_0.Rows
					orderby Guid.NewGuid()
					select AFB63B8F).CopyToDataTable();
			}
		}
		catch
		{
		}
		return dataTable_0;
	}

	public static bool smethod_47(string string_1, string C398043D)
	{
		try
		{
			File.Copy(string_1, C398043D, overwrite: true);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool smethod_48(string string_1, string A019BB94)
	{
		try
		{
			CreateFolder(A019BB94);
			string[] directories = Directory.GetDirectories(string_1, "*", SearchOption.AllDirectories);
			foreach (string text in directories)
			{
				Directory.CreateDirectory(text.Replace(string_1, A019BB94));
			}
			string[] files = Directory.GetFiles(string_1, "*.*", SearchOption.AllDirectories);
			foreach (string text2 in files)
			{
				File.Copy(text2, text2.Replace(string_1, A019BB94), overwrite: true);
			}
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool B5AAF3AD(string CA811425, string string_1)
	{
		try
		{
			Directory.Move(CA811425, string_1);
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool smethod_49(string B41F7EA1)
	{
		try
		{
			if (File.Exists(B41F7EA1))
			{
				File.Delete(B41F7EA1);
			}
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static bool DC3740BE(string DD137083)
	{
		try
		{
			Directory.Delete(DD137083, recursive: true);
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static int F413B12C(int int_1, int int_2)
	{
		if (int_1 > int_2)
		{
			int_2 = int_1;
		}
		return new Random().Next(int_1, int_2);
	}

	internal static void smethod_50(string string_1, string string_2)
	{
		try
		{
			smethod_49(string_2);
			File.Move(string_1, string_2);
		}
		catch
		{
		}
	}

	public static System.Drawing.Point smethod_51(Process process_0)
	{
		IntPtr mainWindowHandle = process_0.MainWindowHandle;
		Rect B43E201A = default(Rect);
		GClass2.GetWindowRect(mainWindowHandle, ref B43E201A);
		return new System.Drawing.Point(B43E201A.Width, B43E201A.Height);
	}

	public static void smethod_52(List<Process> list_0, int int_1)
	{
		int x = smethod_39().X;
		int num = -5;
		int num2 = 0;
		for (int i = 0; i < list_0.Count; i++)
		{
			try
			{
				IntPtr mainWindowHandle = list_0[i].MainWindowHandle;
				string text = list_0[i].MainWindowTitle.Split('|')[2];
				System.Drawing.Point point = new System.Drawing.Point(int.Parse(text.Split('x')[0]), int.Parse(text.Split('x')[1]));
				int num3 = (int)Math.Round((double)x / (double)int_1);
				int num4 = (int)Math.Round((double)((num3 - 34) * point.Y) * 1.0 / (double)point.X + 70.0);
				GClass2.MoveWindow(mainWindowHandle, num, num2, num3, num4, bool_0: true);
				GClass2.SetForegroundWindow(mainWindowHandle);
				num += num3 - 15;
				if ((i + 1) % int_1 == 0)
				{
					num = -5;
					num2 += num4 - 10;
				}
			}
			catch
			{
			}
		}
	}

	public static List<Form> smethod_53(string AD9DD0B7)
	{
		List<Form> list = new List<Form>();
		FormCollection openForms = Application.OpenForms;
		foreach (Form item in openForms)
		{
			if (item.Name == AD9DD0B7)
			{
				list.Add(item);
			}
		}
		return list;
	}

	public static List<Form> smethod_54()
	{
		return smethod_53("fView");
	}

	public static void smethod_55(fMain E2A7C6A8 = null, bool D5B1F18F = true)
	{
		List<Form> list_0 = smethod_54();
		if (D5B1F18F)
		{
			if (list_0.Count == 0)
			{
				new fView().Show();
				return;
			}
			list_0[0].Invoke((MethodInvoker)delegate
			{
				list_0[0].Show();
				list_0[0].BringToFront();
			});
		}
		else
		{
			fView obj = new fView();
			obj.Text = "View Phone - MIN SOFTWARE";
			obj.Show();
		}
	}

	public static void A38D61A1(Form form_0 = null)
	{
		if (form_0 == null)
		{
			List<Form> list = smethod_54();
			foreach (Form form_ in list)
			{
				form_.Invoke((MethodInvoker)delegate
				{
					form_.Close();
					form_.Dispose();
				});
			}
		}
		else
		{
			form_0.Invoke((MethodInvoker)delegate
			{
				form_0.Close();
			});
		}
	}

	public static void smethod_56(IntPtr D13B7587, string string_1)
	{
		List<Form> list = smethod_54();
		(list[0] as fView).method_1(D13B7587, string_1);
	}

	public static void smethod_57(int int_1, Form E40ED8B0 = null)
	{
		if (E40ED8B0 == null)
		{
			List<Form> list = smethod_54();
			(list[0] as fView).method_2(int_1);
		}
		else
		{
			(E40ED8B0 as fView).method_2(int_1);
		}
	}

	internal static bool smethod_58(string DD9328AD)
	{
		return DD9328AD.Length != Regex.Replace(DD9328AD, "\\p{Cs}", "").Length;
	}

	internal static void smethod_59(string FAA91005, string string_1)
	{
		byte[] array = Convert.FromBase64String(FAA91005);
		using MemoryStream stream = new MemoryStream(array, 0, array.Length);
		Image image = Image.FromStream(stream, useEmbeddedColorManagement: true);
		image.Save(string_1);
	}

	internal static string AC063C3B(string B9A85807)
	{
		try
		{
			if (B9A85807.Split('/').Length == 3 && smethod_28(B9A85807.Replace("/", "")))
			{
				return B9A85807;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "january", "1" },
				{ "february", "2" },
				{ "march", "3" },
				{ "april", "4" },
				{ "may", "5" },
				{ "june", "6" },
				{ "july", "7" },
				{ "august", "8" },
				{ "september", "9" },
				{ "october", "10" },
				{ "november", "11" },
				{ "december", "12" }
			};
			string[] array = B9A85807.Split(new char[2] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length > 2)
			{
				string text = dictionary[array[0]];
				if (text != "")
				{
					string text2 = array[1];
					string text3 = array[2];
					string text4 = text + "/" + text2 + "/" + text3;
					if (text4.Split('/').Length == 3 && smethod_28(text4.Replace("/", "")))
					{
						return text4;
					}
				}
			}
		}
		catch
		{
		}
		return "";
	}

	internal static string smethod_60(string string_1)
	{
		try
		{
			if (string_1.Split('/').Length == 3 && smethod_28(string_1.Replace("/", "")))
			{
				return string_1;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{
					"january".Substring(0, 3),
					"1"
				},
				{
					"february".Substring(0, 3),
					"2"
				},
				{
					"march".Substring(0, 3),
					"3"
				},
				{
					"april".Substring(0, 3),
					"4"
				},
				{
					"may".Substring(0, 3),
					"5"
				},
				{
					"june".Substring(0, 3),
					"6"
				},
				{
					"july".Substring(0, 3),
					"7"
				},
				{
					"august".Substring(0, 3),
					"8"
				},
				{
					"september".Substring(0, 3),
					"9"
				},
				{
					"october".Substring(0, 3),
					"10"
				},
				{
					"november".Substring(0, 3),
					"11"
				},
				{
					"december".Substring(0, 3),
					"12"
				}
			};
			string[] array = string_1.Split(new char[2] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length > 2)
			{
				string text = dictionary[array[0]];
				if (text != "")
				{
					string text2 = array[1];
					string text3 = array[2];
					string text4 = text + "/" + text2 + "/" + text3;
					if (text4.Split('/').Length == 3 && smethod_28(text4.Replace("/", "")))
					{
						return text4;
					}
				}
			}
		}
		catch
		{
		}
		return "";
	}

	internal static string smethod_61(string B00E630C)
	{
		try
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "1", "january" },
				{ "2", "february" },
				{ "3", "march" },
				{ "4", "april" },
				{ "5", "may" },
				{ "6", "june" },
				{ "7", "july" },
				{ "8", "august" },
				{ "9", "september" },
				{ "10", "october" },
				{ "11", "november" },
				{ "12", "december" }
			};
			return dictionary[B00E630C.TrimStart('0')];
		}
		catch
		{
		}
		return "";
	}

	public static void BEBCBE97(ComboBox B2936309, List<string> F0B9E2B8)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < F0B9E2B8.Count; i++)
		{
			dictionary.Add(i.ToString() ?? "", Language.GetValue(F0B9E2B8[i]));
		}
		B2936309.DataSource = new BindingSource(dictionary, null);
		B2936309.DisplayMember = "Value";
		B2936309.ValueMember = "Key";
	}

	public static void smethod_62(ComboBox CD120314, Dictionary<string, string> E2104228)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (KeyValuePair<string, string> item in E2104228)
		{
			dictionary.Add(item.Key, Language.GetValue(item.Value));
		}
		CD120314.DataSource = new BindingSource(dictionary, null);
		CD120314.DisplayMember = "Value";
		CD120314.ValueMember = "Key";
	}

	internal static bool E001543D(string C99A9E9C)
	{
		return smethod_28(C99A9E9C) && C99A9E9C.StartsWith("1");
	}

	public static void E93D873E(ref DataGridView B2117F9D, int int_1, int int_2, int AA99BD1D = 1)
	{
		string text = "";
		for (int i = AA99BD1D; i < B2117F9D.Columns.Count; i++)
		{
			text = DatagridviewHelper.smethod_0(B2117F9D, int_1, i);
			DatagridviewHelper.smethod_1(B2117F9D, int_1, i, DatagridviewHelper.smethod_0(B2117F9D, int_2, i));
			DatagridviewHelper.smethod_1(B2117F9D, int_2, i, text);
		}
	}

	public static void smethod_63(UserControl userControl_0, ContainerControl containerControl_0)
	{
		userControl_0.Left = (containerControl_0.ClientSize.Width - userControl_0.Width) / 2;
		userControl_0.Top = (containerControl_0.ClientSize.Height - userControl_0.Height) / 2;
		userControl_0.BringToFront();
		userControl_0.Visible = true;
	}

	static Common()
	{
		rd = new Random();
		A6900AB9 = Screen.PrimaryScreen.WorkingArea.Width;
		int_0 = Screen.PrimaryScreen.WorkingArea.Height;
		D2201231 = new object();
		string_0 = "";
	}
}
