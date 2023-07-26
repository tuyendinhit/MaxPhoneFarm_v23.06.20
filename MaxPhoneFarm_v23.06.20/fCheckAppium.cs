using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using OpenCvSharp;

public class fCheckAppium : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class E9889289
	{
		internal static readonly E9889289 _003C_003E9 = new E9889289();

		internal static Func<string, bool> _003C_003E9__15_0;

		internal bool C130BE1C(string string_0)
		{
			return !string.IsNullOrWhiteSpace(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class54
	{
		internal fCheckAppium A921C5B4;

		internal bool C128158C;

		internal bool bool_0;

		internal bool bool_1;

		internal MethodInvoker methodInvoker_0;

		internal void method_0()
		{
			try
			{
				A921C5B4.Invoke((MethodInvoker)delegate
				{
					AC28BD29 aC28BD = A921C5B4.E98A79A7();
					if (aC28BD != null)
					{
						if (C128158C)
						{
							A921C5B4.A202CE29.Text = aC28BD.method_15();
						}
						if (bool_0)
						{
							try
							{
								A921C5B4.string_0 = aC28BD.GetPageSource();
								A921C5B4.method_4(A921C5B4.string_0);
							}
							catch
							{
							}
						}
						if (bool_1)
						{
							try
							{
								A921C5B4.bitmap_0 = aC28BD.method_87();
								A921C5B4.pictureBox1.Image = new Bitmap(A921C5B4.bitmap_0);
							}
							catch
							{
							}
						}
					}
				});
			}
			catch (Exception ex)
			{
				MessageBoxHelper.Show("Erorr: " + ex.ToString(), 2);
			}
		}

		internal void method_1()
		{
			AC28BD29 aC28BD = A921C5B4.E98A79A7();
			if (aC28BD == null)
			{
				return;
			}
			if (C128158C)
			{
				A921C5B4.A202CE29.Text = aC28BD.method_15();
			}
			if (bool_0)
			{
				try
				{
					A921C5B4.string_0 = aC28BD.GetPageSource();
					A921C5B4.method_4(A921C5B4.string_0);
				}
				catch
				{
				}
			}
			if (bool_1)
			{
				try
				{
					A921C5B4.bitmap_0 = aC28BD.method_87();
					A921C5B4.pictureBox1.Image = new Bitmap(A921C5B4.bitmap_0);
				}
				catch
				{
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class EE89CCB8
	{
		internal StringBuilder stringBuilder_0;

		internal void method_0(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				stringBuilder_0.Append(e.Data + "\n");
			}
		}
	}

	internal string EB00F734 = "";

	internal Bitmap bitmap_0;

	internal string string_0;

	internal List<string> D2A89BBB = new List<string>();

	internal Bitmap bitmap_1 = null;

	internal Random EB824B8F = new Random();

	internal IContainer icontainer_0 = null;

	internal Button button2;

	internal GroupBox groupBox2;

	internal Button F09336AF;

	internal TextBox txtContent;

	internal Label FC0FAC1F;

	internal TextBox txtBoundToDraw;

	internal TextBox C9133B94;

	internal Button CAB76F27;

	internal TextBox BC0326AB;

	internal Label label13;

	internal PictureBox pictureBox1;

	internal Button F9BB6634;

	internal Button button19;

	internal Button B81E6909;

	internal GroupBox B510A901;

	internal TextBox txtFolderPathToCropImage;

	internal Label label3;

	internal TextBox txtFolderPathToSaveImage;

	internal Label label12;

	internal TextBox txtTextToDraw;

	internal Label E7994CA0;

	internal Button button20;

	internal Button button22;

	internal Button button21;

	internal Button EA27DE8E;

	internal TextBox txtFile;

	internal GroupBox A2B85EA3;

	internal Label DDAE5B3D;

	internal Button button14;

	internal TextBox F69D96BE;

	internal TextBox EB85979D;

	internal GroupBox groupBox8;

	internal GClass20 CDA07A3A;

	internal DataGridView dtgvAttribute;

	internal DataGridViewTextBoxColumn B93F9A1E;

	internal DataGridViewTextBoxColumn cValue;

	internal TextBox txtXPath;

	internal TextBox txtValue;

	internal TextBox DE84352B;

	internal Label BA9E26B1;

	internal Label BF251398;

	internal Label BE2CAFBB;

	internal Button button25;

	internal Button button4;

	internal Button button3;

	internal ComboBox cbbDevice;

	internal PictureBox pictureBox2;

	internal Label label4;

	internal Label label5;

	internal TextBox txtPathImage;

	internal TextBox txtPathXml;

	internal Button F43B7EBE;

	internal Label label6;

	internal Button button6;

	internal Button CB85F694;

	internal Button button9;

	internal Label label7;

	internal TextBox A202CE29;

	internal Button EDB9611E;

	internal Button button30;

	internal Button button10;

	internal TextBox txtImage;

	internal Label label8;

	internal Button button11;

	internal Button C7A2352C;

	internal RichTextBox txtSearchXpath;

	public fCheckAppium(string string_1 = "")
	{
		InitializeComponent();
		EB00F734 = string_1;
	}

	private void B106A91F(object sender, EventArgs e)
	{
		try
		{
			string text = cbbDevice.Text.Trim();
			if (!(text == ""))
			{
				pictureBox1.Image = new Bitmap(bitmap_1);
				D2A89BBB.Clear();
			}
		}
		catch
		{
		}
	}

	private void CAB76F27_Click(object sender, EventArgs e)
	{
		List<string> list = txtBoundToDraw.Lines.ToList();
		Bitmap bitmap = (Bitmap)pictureBox1.Image;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != "")
			{
				try
				{
					bitmap = method_1(bitmap, list[i]);
					D2A89BBB.Add(list[i]);
				}
				catch
				{
				}
			}
		}
		pictureBox1.Image = bitmap;
	}

	private bool method_0(string string_1)
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

	private int E2001CB4(params int[] DC246083)
	{
		if (DC246083.Length == 0)
		{
			return 0;
		}
		int num = DC246083[0];
		for (int i = 1; i < DC246083.Length; i++)
		{
			if (DC246083[i] > num)
			{
				num = DC246083[i];
			}
		}
		return num;
	}

	private void F9BB6634_Click(object sender, EventArgs e)
	{
		List<string> d2A89BBB = D2A89BBB;
		d2A89BBB = method_3(d2A89BBB);
		if (d2A89BBB.Count == 0 || bitmap_1 == null)
		{
			return;
		}
		string text = txtFolderPathToCropImage.Text.Trim();
		try
		{
			Bitmap eC2E6F = bitmap_1;
			List<int> list = new List<int>();
			string[] files = Directory.GetFiles(text);
			string[] array = files;
			foreach (string path in array)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
				if (method_0(fileNameWithoutExtension))
				{
					list.Add(Convert.ToInt32(fileNameWithoutExtension));
				}
			}
			int num = E2001CB4(list.ToArray()) + 1;
			for (int j = 0; j < d2A89BBB.Count; j++)
			{
				try
				{
					E40E1331(eC2E6F, d2A89BBB[j], Path.Combine(text, num++ + ".png"));
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	private Bitmap method_1(Bitmap bitmap_2, string string_1)
	{
		string[] array = string_1.Split('[', ',', ']');
        Pen pen = new Pen(Color.Red, 2f);
		Graphics graphics = Graphics.FromImage(bitmap_2);
		graphics.DrawRectangle(pen, Convert.ToInt32(array[1]) - 1, Convert.ToInt32(array[2]) - 1, Convert.ToInt32(array[4]) - Convert.ToInt32(array[1]) + 2, Convert.ToInt32(array[5]) - Convert.ToInt32(array[2]) + 2);
		return bitmap_2;
	}

	private Bitmap method_2(Bitmap bitmap_2, Rect rect_0)
	{
		Pen pen = new Pen(Color.Red, 2f);
		Graphics graphics = Graphics.FromImage(bitmap_2);
		graphics.DrawRectangle(pen, rect_0.X - 1, rect_0.Y - 1, rect_0.Width + 2, rect_0.Height + 2);
		return bitmap_2;
	}

	private void E40E1331(Bitmap EC2E6F30, string string_1, string FE1F9A34)
	{
		string[] array = string_1.Split('[', ',', ']');
        Bitmap bitmap = EC2E6F30.Clone(new Rectangle(Convert.ToInt32(array[1]), Convert.ToInt32(array[2]), Convert.ToInt32(array[4]) - Convert.ToInt32(array[1]), Convert.ToInt32(array[5]) - Convert.ToInt32(array[2])), EC2E6F30.PixelFormat);
		bitmap.Save(FE1F9A34);
	}

	private void F09336AF_Click(object sender, EventArgs e)
	{
		string text = cbbDevice.Text.Trim();
		if (!(text == ""))
		{
			AC28BD29 aC28BD = E98A79A7();
			if (aC28BD != null)
			{
				aC28BD.SendByXPath(txtXPath.Text.Trim(), txtContent.Text.Trim());
				button25_Click(null, null);
			}
		}
	}

	public List<string> method_3(List<string> list_0)
	{
		return list_0.Where((string string_0) => !string.IsNullOrWhiteSpace(string_0)).ToList();
	}

	private void button14_Click(object sender, EventArgs e)
	{
		cbbDevice.Text.Trim();
	}

	private void C5912FB8(object sender, EventArgs e)
	{
		string path = txtFolderPathToCropImage.Text.Trim();
		pictureBox1.Image.Save(Path.Combine(path, "_.png"));
	}

	private string A890A230(int int_0, int int_1)
	{
		try
		{
			if (pictureBox1.Image != null)
			{
				int num = pictureBox1.Image.Width;
				int num2 = pictureBox1.Image.Height;
				int num3 = pictureBox1.ClientRectangle.Width;
				int num4 = pictureBox1.ClientRectangle.Height;
				double num5 = (double)num3 / (double)num;
				double num6 = (double)num4 / (double)num2;
				double num7 = Math.Min(num5, num6);
				double num8 = ((num7 == num5) ? 0.0 : (((double)num3 - num7 * (double)num) / 2.0));
				double num9 = ((num7 == num6) ? 0.0 : (((double)num4 - num7 * (double)num2) / 2.0));
				int num10 = (int)(((double)int_0 - num8) / num7);
				int num11 = (int)(((double)int_1 - num9) / num7);
				string text = ((num10 < 0 || num10 > num) ? "-" : num10.ToString());
				string text2 = ((num11 < 0 || num11 > num2) ? "-" : num11.ToString());
				return text + "|" + text2;
			}
		}
		catch
		{
		}
		return "0|0";
	}

	private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
	{
		string text = A890A230(e.X, e.Y);
		C9133B94.Text = text.Split('|')[0];
		BC0326AB.Text = text.Split('|')[1];
	}

	private void DEBB1A98(object sender, MouseEventArgs e)
	{
		int num = txtBoundToDraw.Lines.Length;
		string text = "";
		if (num > 0)
		{
			text = txtBoundToDraw.Lines[num - 1];
		}
		if (text.Contains("]["))
		{
			TextBox textBox = txtBoundToDraw;
			textBox.Text = textBox.Text + "\r\n[" + C9133B94.Text + "," + BC0326AB.Text + "]";
		}
		else
		{
			TextBox textBox = txtBoundToDraw;
			textBox.Text = textBox.Text + "[" + C9133B94.Text + "," + BC0326AB.Text + "]";
		}
	}

	private void B91F769C(object sender, EventArgs e)
	{
		string text = cbbDevice.Text.Trim();
		if (text == "")
		{
		}
	}

	private void BF251398_Click(object sender, EventArgs e)
	{
	}

	private void txtFolderPathToCropImage_TextChanged(object sender, EventArgs e)
	{
	}

	private void button20_Click(object sender, EventArgs e)
	{
		string text = cbbDevice.Text.Trim();
		if (text == "")
		{
		}
	}

	private void button21_Click(object sender, EventArgs e)
	{
		txtBoundToDraw.Clear();
	}

	private void button22_Click(object sender, EventArgs e)
	{
		txtTextToDraw.Clear();
	}

	private void EA27DE8E_Click(object sender, EventArgs e)
	{
		try
		{
			bitmap_1 = new Bitmap(txtFile.Text.Trim());
			pictureBox1.Image = new Bitmap(bitmap_1);
			D2A89BBB.Clear();
		}
		catch
		{
		}
	}

	private void button25_Click(object sender, EventArgs e)
	{
		bool bool_1 = true;
		bool bool_0 = true;
		bool C128158C = true;
		if (e != null && (e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			bool_0 = false;
			C128158C = false;
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				Invoke((MethodInvoker)delegate
				{
					AC28BD29 aC28BD = E98A79A7();
					if (aC28BD != null)
					{
						if (C128158C)
						{
							A202CE29.Text = aC28BD.method_15();
						}
						if (bool_0)
						{
							try
							{
								string_0 = aC28BD.GetPageSource();
								method_4(string_0);
							}
							catch
							{
							}
						}
						if (bool_1)
						{
							try
							{
								bitmap_0 = aC28BD.method_87();
								pictureBox1.Image = new Bitmap(bitmap_0);
							}
							catch
							{
							}
						}
					}
				});
			}
			catch (Exception ex)
			{
				MessageBoxHelper.Show("Erorr: " + ex.ToString(), 2);
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_4(string string_1)
	{
		try
		{
			if (string_1 == "")
			{
				CDA07A3A.Nodes.Clear();
				return;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(string_1);
			CDA07A3A.Nodes.Clear();
			foreach (XmlNode childNode in xmlDocument.DocumentElement.ChildNodes)
			{
				method_7(CDA07A3A.Nodes, childNode);
			}
			CDA07A3A.ExpandAll();
			TreeNodeCollection nodes = CDA07A3A.Nodes;
			foreach (TreeNode item in nodes)
			{
				method_5(item);
			}
		}
		catch (Exception)
		{
		}
	}

	private void method_5(TreeNode treeNode_0)
	{
		string xml = treeNode_0.Text;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(xml);
		XmlElement documentElement = xmlDocument.DocumentElement;
		foreach (XmlAttribute attribute in documentElement.Attributes)
		{
			if ((attribute.Name == "text" || attribute.Name == "content-desc") && attribute.Value != "")
			{
				treeNode_0.BackColor = Color.FromArgb(212, 237, 182);
				break;
			}
		}
		foreach (TreeNode node in treeNode_0.Nodes)
		{
			method_5(node);
		}
	}

	private void method_6(TreeNode treeNode_0)
	{
		treeNode_0.ForeColor = Color.Black;
		foreach (TreeNode node in treeNode_0.Nodes)
		{
			method_6(node);
		}
	}

	private void method_7(TreeNodeCollection F6807788, XmlNode A6385399)
	{
		if (A6385399.HasChildNodes)
		{
			string outerXml = A6385399.OuterXml;
			TreeNode treeNode = F6807788.Add(outerXml);
			XmlNodeList childNodes = A6385399.ChildNodes;
			for (int i = 0; i <= childNodes.Count - 1; i++)
			{
				XmlNode a = A6385399.ChildNodes[i];
				method_7(treeNode.Nodes, a);
			}
		}
		else
		{
			string text = A6385399.OuterXml.Trim();
			F6807788.Add(text);
		}
	}

	private void A8AC93A5(object sender, TreeViewEventArgs e)
	{
		dtgvAttribute.Rows.Clear();
		method_8(-1);
		try
		{
			string xml = CDA07A3A.SelectedNode.Text;
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			XmlElement documentElement = xmlDocument.DocumentElement;
			foreach (XmlAttribute attribute in documentElement.Attributes)
			{
				DataGridViewRow dataGridViewRow = dtgvAttribute.Rows[dtgvAttribute.Rows.Add()];
				dataGridViewRow.Cells["cAttribute"].Value = attribute.Name;
				dataGridViewRow.Cells["cValue"].Value = attribute.Value;
				if ((attribute.Name == "text" || attribute.Name == "content-desc") && attribute.Value != "")
				{
					dataGridViewRow.DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					method_8(dataGridViewRow.Index);
				}
			}
			Bitmap bitmap_ = new Bitmap(bitmap_0);
			bitmap_ = method_1(bitmap_, documentElement.Attributes["bounds"].Value);
			pictureBox1.Image = bitmap_;
		}
		catch (Exception)
		{
		}
	}

	private void B899CABE(object sender, DataGridViewCellEventArgs e)
	{
		method_8(e.RowIndex);
	}

	private void method_8(int C68EDEB0)
	{
		if (C68EDEB0 < 0)
		{
			DE84352B.Text = "";
			txtValue.Text = "";
			txtXPath.Text = "";
			return;
		}
		DataGridViewRow dataGridViewRow = dtgvAttribute.Rows[C68EDEB0];
		string text = dataGridViewRow.Cells["cAttribute"].Value.ToString();
		string text2 = dataGridViewRow.Cells["cValue"].Value.ToString();
		DataGridViewRowCollection rows = dtgvAttribute.Rows;
		string text3 = "";
		for (int i = 0; i < rows.Count; i++)
		{
			if (rows[i].Cells["cAttribute"].Value.ToString() == "class")
			{
				text3 = rows[i].Cells["cValue"].Value.ToString();
				break;
			}
		}
		List<string> list = new List<string> { "android.widget.Button", "android.widget.EditText" };
		if (!list.Contains(text3))
		{
			text3 = "*";
		}
		DE84352B.Text = text;
		txtValue.Text = text2;
		if (text2.Contains("'"))
		{
			txtXPath.Text = "//" + text3 + "[@" + text + "=\"" + text2 + "\"]";
		}
		else
		{
			txtXPath.Text = "//" + text3 + "[@" + text + "='" + text2 + "']";
		}
	}

	private void BC08F537(object sender, EventArgs e)
	{
		cbbDevice.Items.Clear();
		List<string> list = method_10();
		if (list.Count != 0)
		{
			for (int i = 0; i < list.Count; i++)
			{
				cbbDevice.Items.Add(list[i]);
			}
			cbbDevice.SelectedIndex = 0;
		}
	}

	public string method_9(string string_1, int C5B265BD = 10)
	{
		string text = "";
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			if (!string_1.StartsWith("adb") && !string_1.StartsWith("scrcpy"))
			{
				process.StartInfo.Arguments = "/c " + string_1;
			}
			else
			{
				process.StartInfo.Arguments = "/c " + Environment.GetEnvironmentVariable("ANDROID_HOME", EnvironmentVariableTarget.Machine) + "\\platform-tools\\" + string_1;
			}
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
			if (C5B265BD < 0)
			{
				process.WaitForExit();
			}
			else
			{
				process.WaitForExit(C5B265BD * 1000);
			}
			process.Close();
			text = stringBuilder_0.ToString().Trim();
			if (text.Contains("daemon not running") && !text.Contains("daemon started successfully"))
			{
				Thread.Sleep(1000);
				method_9(string_1, C5B265BD);
			}
		}
		catch
		{
		}
		return text;
	}

	public List<string> method_10()
	{
		List<string> list = new List<string>();
		string text = method_9("adb devices", 5);
		string[] array = text.Replace("List of devices attached", "").Trim().Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			if (!array[i].Contains("offline") && array[i].Contains("device"))
			{
				list.Add(array[i].Trim().Split('\t')[0]);
			}
		}
		return list;
	}

	private void button3_Click(object sender, EventArgs e)
	{
		DataGridViewRowCollection rows = dtgvAttribute.Rows;
		string text = "";
		for (int i = 0; i < rows.Count; i++)
		{
			if (rows[i].Cells["cAttribute"].Value.ToString() == "bounds")
			{
				text = rows[i].Cells["cValue"].Value.ToString();
				break;
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			AC28BD29 aC28BD = E98A79A7();
			if (aC28BD != null)
			{
				aC28BD.E832B991(text);
				button25_Click(null, null);
			}
		}
	}

	private void FB2C8013(object sender, EventArgs e)
	{
		string text = txtXPath.Text.Trim();
		if (!string.IsNullOrEmpty(text))
		{
			AC28BD29 aC28BD = E98A79A7();
			if (aC28BD != null)
			{
				aC28BD.E80B893F(text);
				button25_Click(null, null);
			}
		}
	}

	private AC28BD29 E98A79A7()
	{
		string text = cbbDevice.Text.Trim();
		if (!string.IsNullOrEmpty(text))
		{
			AC28BD29 aC28BD = new AC28BD29(text);
			if (aC28BD.method_2() != "")
			{
				return aC28BD;
			}
		}
		return null;
	}

	private void A415AC3F(object sender, EventArgs e)
	{
		try
		{
			string text = txtPathXml.Text.Trim();
			if (!string.IsNullOrEmpty(text))
			{
				if (File.Exists(text))
				{
					string_0 = File.ReadAllText(text);
				}
				else
				{
					string_0 = text;
				}
				string_0 = Regex.Match(string_0, "<\\?xml(.*?)</hierarchy>", RegexOptions.Singleline).Value;
				method_4(string_0);
			}
			string text2 = txtPathImage.Text.Trim();
			if (!string.IsNullOrEmpty(text2))
			{
				bitmap_0 = new Bitmap(text2);
				pictureBox1.Image = new Bitmap(bitmap_0);
			}
		}
		catch (Exception)
		{
		}
	}

	private void CB85F694_Click(object sender, EventArgs e)
	{
		txtPathImage.Text = method_11("Chọn File png", "png Files (*.png)|*.png|");
	}

	private string method_11(string string_1 = "Chọn File txt", string string_2 = "txt Files (*.txt)|*.txt|")
	{
		string result = "";
		try
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = string_2 + "All files (*.*)|*.*";
			openFileDialog.Title = string_1;
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

	private void AD2A0A0D(object sender, EventArgs e)
	{
		txtPathXml.Text = method_11();
	}

	private void button6_Click(object sender, EventArgs e)
	{
		TreeNodeCollection nodes = CDA07A3A.Nodes;
		foreach (TreeNode item in nodes)
		{
			method_6(item);
		}
		List<string> list = txtSearchXpath.Text.Trim().Split(new char[1] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
		if (list.Count == 0)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			string text = list[i];
			if (text.Contains("|"))
			{
				text = text.Split('|')[1];
			}
			List<string> list2 = E93F330E(string_0, text);
			list[i] = list2.Count + "|" + text;
			if (list2.Count == 0)
			{
				continue;
			}
			List<TreeNode> list_ = new List<TreeNode>();
			foreach (TreeNode item2 in nodes)
			{
				method_12(item2, list2, ref list_);
			}
			if (list_.Count <= 0)
			{
				continue;
			}
			foreach (TreeNode item3 in list_)
			{
				item3.ForeColor = Color.Red;
			}
			CDA07A3A.SelectedNode = list_[0];
		}
		txtSearchXpath.Lines = list.ToArray();
	}

	private void method_12(TreeNode treeNode_0, List<string> list_0, ref List<TreeNode> list_1)
	{
		if (list_0?.Contains(treeNode_0.Text.ToLower()) ?? false)
		{
			list_1.Add(treeNode_0);
		}
		foreach (TreeNode node in treeNode_0.Nodes)
		{
			method_12(node, list_0, ref list_1);
		}
	}

	private List<string> E93F330E(string A8B469BF, string C63B633E)
	{
		List<string> list = new List<string>();
		try
		{
			A8B469BF = A8B469BF.ToLower();
			C63B633E = C63B633E.ToLower();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(A8B469BF.ToLower());
			XmlNodeList xmlNodeList = xmlDocument.SelectNodes(C63B633E);
			for (int i = 0; i < xmlNodeList.Count; i++)
			{
				list.Add(xmlNodeList[i].OuterXml);
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	private void EDB9611E_Click(object sender, EventArgs e)
	{
		string value = cbbDevice.Text.Trim();
		if (!string.IsNullOrEmpty(value))
		{
			AC28BD29 aC28BD = E98A79A7();
			if (aC28BD != null)
			{
				aC28BD.method_18(A202CE29.Text.Trim());
				button25_Click(null, null);
			}
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
		Common.SetTextToClipboard(C9133B94.Text + " " + BC0326AB.Text);
	}

	private void fCheckAppium_Load(object sender, EventArgs e)
	{
		if (EB00F734 != "")
		{
			cbbDevice.Text = EB00F734;
			button25_Click(null, null);
		}
	}

	private void CB877490(object sender, EventArgs e)
	{
		A72AC103();
	}

	private void A72AC103(bool B10D15BA = false)
	{
		try
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "png files (*.png) | *.png";
			DialogResult dialogResult = saveFileDialog.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;
				bitmap_0.Save(fileName);
				if (B10D15BA)
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = "mspaint.exe";
					processStartInfo.Arguments = "\"" + fileName + "\"";
					Process.Start(processStartInfo);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void FB8A770F(object sender, EventArgs e)
	{
		A72AC103(B10D15BA: true);
	}

	private void A62629B1(object sender, EventArgs e)
	{
		string_0 = string_0.Replace("\r\n", " ");
		Common.SetTextToClipboard(string_0);
	}

	private void button11_Click(object sender, EventArgs e)
	{
		try
		{
			string text = txtImage.Text.Trim();
			List<Bitmap> list = new List<Bitmap>();
			if (Directory.Exists(text))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				FileInfo[] files = directoryInfo.GetFiles();
				FileInfo[] array = files;
				foreach (FileInfo fileInfo in array)
				{
					Bitmap item = (Bitmap)Image.FromFile(fileInfo.FullName);
					list.Add(item);
				}
			}
			else if (File.Exists(text))
			{
				list.Add((Bitmap)Image.FromFile(text));
			}
			List<Rect> list2 = new List<Rect>();
			for (int j = 0; j < list.Count; j++)
			{
				list2.AddRange(new AC28BD29("").method_80(bitmap_0, list[j], 0.99));
			}
			label8.Text = $"({list2.Count})";
			if (list2.Count != 0)
			{
				for (int k = 0; k < list2.Count; k++)
				{
					bitmap_0 = method_2(bitmap_0, list2[k]);
				}
				pictureBox1.Image = new Bitmap(bitmap_0);
			}
		}
		catch (Exception)
		{
		}
	}

	private void dtgvAttribute_KeyUp(object sender, KeyEventArgs e)
	{
		int index = dtgvAttribute.CurrentRow.Index;
		if (index >= 0)
		{
			method_8(index);
		}
	}

	private void dtgvAttribute_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		int index = dtgvAttribute.CurrentRow.Index;
		if (index >= 0)
		{
			method_8(index);
		}
	}

	protected override void Dispose(bool A9828D35)
	{
		if (A9828D35 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(A9828D35);
	}

	private void InitializeComponent()
	{
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCheckAppium));
		button2 = new System.Windows.Forms.Button();
		groupBox2 = new System.Windows.Forms.GroupBox();
		txtImage = new System.Windows.Forms.TextBox();
		label8 = new System.Windows.Forms.Label();
		button11 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		B510A901 = new System.Windows.Forms.GroupBox();
		txtTextToDraw = new System.Windows.Forms.TextBox();
		txtBoundToDraw = new System.Windows.Forms.TextBox();
		txtFolderPathToSaveImage = new System.Windows.Forms.TextBox();
		txtFolderPathToCropImage = new System.Windows.Forms.TextBox();
		F9BB6634 = new System.Windows.Forms.Button();
		button19 = new System.Windows.Forms.Button();
		E7994CA0 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		label13 = new System.Windows.Forms.Label();
		button20 = new System.Windows.Forms.Button();
		label3 = new System.Windows.Forms.Label();
		button22 = new System.Windows.Forms.Button();
		button21 = new System.Windows.Forms.Button();
		CAB76F27 = new System.Windows.Forms.Button();
		C9133B94 = new System.Windows.Forms.TextBox();
		A2B85EA3 = new System.Windows.Forms.GroupBox();
		DDAE5B3D = new System.Windows.Forms.Label();
		button14 = new System.Windows.Forms.Button();
		F69D96BE = new System.Windows.Forms.TextBox();
		EB85979D = new System.Windows.Forms.TextBox();
		EA27DE8E = new System.Windows.Forms.Button();
		B81E6909 = new System.Windows.Forms.Button();
		txtFile = new System.Windows.Forms.TextBox();
		button10 = new System.Windows.Forms.Button();
		button30 = new System.Windows.Forms.Button();
		BC0326AB = new System.Windows.Forms.TextBox();
		F09336AF = new System.Windows.Forms.Button();
		txtContent = new System.Windows.Forms.TextBox();
		FC0FAC1F = new System.Windows.Forms.Label();
		groupBox8 = new System.Windows.Forms.GroupBox();
		C7A2352C = new System.Windows.Forms.Button();
		CDA07A3A = new GClass20();
		dtgvAttribute = new System.Windows.Forms.DataGridView();
		B93F9A1E = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
		txtXPath = new System.Windows.Forms.TextBox();
		label6 = new System.Windows.Forms.Label();
		BE2CAFBB = new System.Windows.Forms.Label();
		BF251398 = new System.Windows.Forms.Label();
		button6 = new System.Windows.Forms.Button();
		txtValue = new System.Windows.Forms.TextBox();
		BA9E26B1 = new System.Windows.Forms.Label();
		DE84352B = new System.Windows.Forms.TextBox();
		button4 = new System.Windows.Forms.Button();
		button3 = new System.Windows.Forms.Button();
		button25 = new System.Windows.Forms.Button();
		cbbDevice = new System.Windows.Forms.ComboBox();
		pictureBox2 = new System.Windows.Forms.PictureBox();
		label4 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		txtPathImage = new System.Windows.Forms.TextBox();
		txtPathXml = new System.Windows.Forms.TextBox();
		F43B7EBE = new System.Windows.Forms.Button();
		CB85F694 = new System.Windows.Forms.Button();
		button9 = new System.Windows.Forms.Button();
		label7 = new System.Windows.Forms.Label();
		A202CE29 = new System.Windows.Forms.TextBox();
		EDB9611E = new System.Windows.Forms.Button();
		txtSearchXpath = new System.Windows.Forms.RichTextBox();
		groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		B510A901.SuspendLayout();
		A2B85EA3.SuspendLayout();
		groupBox8.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dtgvAttribute).BeginInit();
		((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
		SuspendLayout();
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.Location = new System.Drawing.Point(332, 54);
		button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(106, 26);
		button2.TabIndex = 0;
		button2.Text = "Screen Shot";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(B106A91F);
		groupBox2.Controls.Add(txtImage);
		groupBox2.Controls.Add(label8);
		groupBox2.Controls.Add(button11);
		groupBox2.Controls.Add(pictureBox1);
		groupBox2.Controls.Add(B510A901);
		groupBox2.Controls.Add(C9133B94);
		groupBox2.Controls.Add(A2B85EA3);
		groupBox2.Controls.Add(EA27DE8E);
		groupBox2.Controls.Add(B81E6909);
		groupBox2.Controls.Add(txtFile);
		groupBox2.Controls.Add(button10);
		groupBox2.Controls.Add(button30);
		groupBox2.Controls.Add(button2);
		groupBox2.Controls.Add(BC0326AB);
		groupBox2.Location = new System.Drawing.Point(15, 122);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new System.Drawing.Size(332, 655);
		groupBox2.TabIndex = 2;
		groupBox2.TabStop = false;
		groupBox2.Text = "Xử lý Ảnh";
		txtImage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		txtImage.Location = new System.Drawing.Point(41, 625);
		txtImage.Name = "txtImage";
		txtImage.Size = new System.Drawing.Size(223, 23);
		txtImage.TabIndex = 13;
		label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(2, 628);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(37, 16);
		label8.TabIndex = 15;
		label8.Text = "Path:";
		button11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button11.Cursor = System.Windows.Forms.Cursors.Hand;
		button11.Location = new System.Drawing.Point(268, 624);
		button11.Name = "button11";
		button11.Size = new System.Drawing.Size(58, 25);
		button11.TabIndex = 14;
		button11.Text = "Search";
		button11.UseVisualStyleBackColor = true;
		button11.Click += new System.EventHandler(button11_Click);
		pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
		pictureBox1.Location = new System.Drawing.Point(6, 22);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(320, 569);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 5;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(pictureBox1_MouseMove);
		pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(DEBB1A98);
		B510A901.Controls.Add(txtTextToDraw);
		B510A901.Controls.Add(txtBoundToDraw);
		B510A901.Controls.Add(txtFolderPathToSaveImage);
		B510A901.Controls.Add(txtFolderPathToCropImage);
		B510A901.Controls.Add(F9BB6634);
		B510A901.Controls.Add(button19);
		B510A901.Controls.Add(E7994CA0);
		B510A901.Controls.Add(label12);
		B510A901.Controls.Add(label13);
		B510A901.Controls.Add(button20);
		B510A901.Controls.Add(label3);
		B510A901.Controls.Add(button22);
		B510A901.Controls.Add(button21);
		B510A901.Controls.Add(CAB76F27);
		B510A901.Location = new System.Drawing.Point(332, 87);
		B510A901.Name = "groupBox7";
		B510A901.Size = new System.Drawing.Size(278, 241);
		B510A901.TabIndex = 10;
		B510A901.TabStop = false;
		B510A901.Text = "Draw, Crop";
		txtTextToDraw.Location = new System.Drawing.Point(70, 99);
		txtTextToDraw.Multiline = true;
		txtTextToDraw.Name = "txtTextToDraw";
		txtTextToDraw.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		txtTextToDraw.Size = new System.Drawing.Size(147, 71);
		txtTextToDraw.TabIndex = 1;
		txtTextToDraw.WordWrap = false;
		txtBoundToDraw.Location = new System.Drawing.Point(70, 22);
		txtBoundToDraw.Multiline = true;
		txtBoundToDraw.Name = "txtBoundToDraw";
		txtBoundToDraw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
		txtBoundToDraw.Size = new System.Drawing.Size(147, 71);
		txtBoundToDraw.TabIndex = 1;
		txtBoundToDraw.WordWrap = false;
		txtFolderPathToSaveImage.Location = new System.Drawing.Point(103, 209);
		txtFolderPathToSaveImage.Name = "txtFolderPathToSaveImage";
		txtFolderPathToSaveImage.Size = new System.Drawing.Size(114, 23);
		txtFolderPathToSaveImage.TabIndex = 1;
		txtFolderPathToSaveImage.TextChanged += new System.EventHandler(txtFolderPathToCropImage_TextChanged);
		txtFolderPathToCropImage.Location = new System.Drawing.Point(103, 178);
		txtFolderPathToCropImage.Name = "txtFolderPathToCropImage";
		txtFolderPathToCropImage.Size = new System.Drawing.Size(114, 23);
		txtFolderPathToCropImage.TabIndex = 1;
		txtFolderPathToCropImage.TextChanged += new System.EventHandler(txtFolderPathToCropImage_TextChanged);
		F9BB6634.Cursor = System.Windows.Forms.Cursors.Hand;
		F9BB6634.Location = new System.Drawing.Point(223, 176);
		F9BB6634.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		F9BB6634.Name = "button12";
		F9BB6634.Size = new System.Drawing.Size(49, 26);
		F9BB6634.TabIndex = 0;
		F9BB6634.Text = "Crop";
		F9BB6634.UseVisualStyleBackColor = true;
		F9BB6634.Click += new System.EventHandler(F9BB6634_Click);
		button19.Cursor = System.Windows.Forms.Cursors.Hand;
		button19.Location = new System.Drawing.Point(223, 207);
		button19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		button19.Name = "button19";
		button19.Size = new System.Drawing.Size(49, 26);
		button19.TabIndex = 0;
		button19.Text = "Save";
		button19.UseVisualStyleBackColor = true;
		button19.Click += new System.EventHandler(C5912FB8);
		E7994CA0.AutoSize = true;
		E7994CA0.Location = new System.Drawing.Point(10, 99);
		E7994CA0.Name = "label16";
		E7994CA0.Size = new System.Drawing.Size(37, 16);
		E7994CA0.TabIndex = 3;
		E7994CA0.Text = "Text:";
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(10, 212);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(95, 16);
		label12.TabIndex = 3;
		label12.Text = "Folder lưu ảnh:";
		label12.Click += new System.EventHandler(BF251398_Click);
		label13.AutoSize = true;
		label13.Location = new System.Drawing.Point(10, 22);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(53, 16);
		label13.TabIndex = 3;
		label13.Text = "Bounds:";
		button20.Cursor = System.Windows.Forms.Cursors.Hand;
		button20.Location = new System.Drawing.Point(223, 99);
		button20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		button20.Name = "button20";
		button20.Size = new System.Drawing.Size(49, 26);
		button20.TabIndex = 0;
		button20.Text = "Draw";
		button20.UseVisualStyleBackColor = true;
		button20.Click += new System.EventHandler(button20_Click);
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(10, 181);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(95, 16);
		label3.TabIndex = 3;
		label3.Text = "Folder lưu ảnh:";
		label3.Click += new System.EventHandler(BF251398_Click);
		button22.Cursor = System.Windows.Forms.Cursors.Hand;
		button22.Location = new System.Drawing.Point(223, 130);
		button22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		button22.Name = "button22";
		button22.Size = new System.Drawing.Size(49, 26);
		button22.TabIndex = 0;
		button22.Text = "Clear";
		button22.UseVisualStyleBackColor = true;
		button22.Click += new System.EventHandler(button22_Click);
		button21.Cursor = System.Windows.Forms.Cursors.Hand;
		button21.Location = new System.Drawing.Point(223, 53);
		button21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		button21.Name = "button21";
		button21.Size = new System.Drawing.Size(49, 26);
		button21.TabIndex = 0;
		button21.Text = "Clear";
		button21.UseVisualStyleBackColor = true;
		button21.Click += new System.EventHandler(button21_Click);
		CAB76F27.Cursor = System.Windows.Forms.Cursors.Hand;
		CAB76F27.Location = new System.Drawing.Point(223, 22);
		CAB76F27.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		CAB76F27.Name = "button1";
		CAB76F27.Size = new System.Drawing.Size(49, 26);
		CAB76F27.TabIndex = 0;
		CAB76F27.Text = "Draw";
		CAB76F27.UseVisualStyleBackColor = true;
		CAB76F27.Click += new System.EventHandler(CAB76F27_Click);
		C9133B94.Location = new System.Drawing.Point(6, 597);
		C9133B94.Name = "txtMouseX";
		C9133B94.ReadOnly = true;
		C9133B94.Size = new System.Drawing.Size(64, 23);
		C9133B94.TabIndex = 4;
		C9133B94.Text = "0";
		C9133B94.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		A2B85EA3.Controls.Add(DDAE5B3D);
		A2B85EA3.Controls.Add(button14);
		A2B85EA3.Controls.Add(F69D96BE);
		A2B85EA3.Controls.Add(EB85979D);
		A2B85EA3.Location = new System.Drawing.Point(332, 334);
		A2B85EA3.Name = "groupBox3";
		A2B85EA3.Size = new System.Drawing.Size(278, 193);
		A2B85EA3.TabIndex = 9;
		A2B85EA3.TabStop = false;
		A2B85EA3.Text = "Run CMD";
		DDAE5B3D.AutoSize = true;
		DDAE5B3D.Location = new System.Drawing.Point(6, 19);
		DDAE5B3D.Name = "label2";
		DDAE5B3D.Size = new System.Drawing.Size(70, 16);
		DDAE5B3D.TabIndex = 3;
		DDAE5B3D.Text = "Command:";
		button14.Cursor = System.Windows.Forms.Cursors.Hand;
		button14.Location = new System.Drawing.Point(223, 16);
		button14.Name = "button14";
		button14.Size = new System.Drawing.Size(50, 25);
		button14.TabIndex = 2;
		button14.Text = "Run";
		button14.UseVisualStyleBackColor = true;
		button14.Click += new System.EventHandler(button14_Click);
		F69D96BE.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F69D96BE.Location = new System.Drawing.Point(9, 46);
		F69D96BE.Multiline = true;
		F69D96BE.Name = "txtResultCmd";
		F69D96BE.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		F69D96BE.Size = new System.Drawing.Size(263, 141);
		F69D96BE.TabIndex = 1;
		F69D96BE.WordWrap = false;
		EB85979D.Location = new System.Drawing.Point(83, 17);
		EB85979D.Name = "txtCommand";
		EB85979D.Size = new System.Drawing.Size(134, 23);
		EB85979D.TabIndex = 1;
		EA27DE8E.Cursor = System.Windows.Forms.Cursors.Hand;
		EA27DE8E.Location = new System.Drawing.Point(555, 20);
		EA27DE8E.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		EA27DE8E.Name = "button23";
		EA27DE8E.Size = new System.Drawing.Size(55, 26);
		EA27DE8E.TabIndex = 0;
		EA27DE8E.Text = "Open";
		EA27DE8E.UseVisualStyleBackColor = true;
		EA27DE8E.Click += new System.EventHandler(EA27DE8E_Click);
		B81E6909.Cursor = System.Windows.Forms.Cursors.Hand;
		B81E6909.Location = new System.Drawing.Point(445, 54);
		B81E6909.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		B81E6909.Name = "button18";
		B81E6909.Size = new System.Drawing.Size(165, 26);
		B81E6909.TabIndex = 0;
		B81E6909.Text = "Screen Shot + Open Paint";
		B81E6909.UseVisualStyleBackColor = true;
		B81E6909.Click += new System.EventHandler(B91F769C);
		txtFile.Location = new System.Drawing.Point(332, 22);
		txtFile.Name = "txtFile";
		txtFile.Size = new System.Drawing.Size(217, 23);
		txtFile.TabIndex = 1;
		button10.Cursor = System.Windows.Forms.Cursors.Hand;
		button10.Location = new System.Drawing.Point(246, 596);
		button10.Name = "button10";
		button10.Size = new System.Drawing.Size(80, 24);
		button10.TabIndex = 12;
		button10.Text = "Save + Edit";
		button10.UseVisualStyleBackColor = true;
		button10.Click += new System.EventHandler(FB8A770F);
		button30.Cursor = System.Windows.Forms.Cursors.Hand;
		button30.Location = new System.Drawing.Point(197, 596);
		button30.Name = "button30";
		button30.Size = new System.Drawing.Size(43, 24);
		button30.TabIndex = 12;
		button30.Text = "Save";
		button30.UseVisualStyleBackColor = true;
		button30.Click += new System.EventHandler(CB877490);
		BC0326AB.Location = new System.Drawing.Point(76, 597);
		BC0326AB.Name = "txtMouseY";
		BC0326AB.ReadOnly = true;
		BC0326AB.Size = new System.Drawing.Size(64, 23);
		BC0326AB.TabIndex = 4;
		BC0326AB.Text = "0";
		BC0326AB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		F09336AF.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		F09336AF.Cursor = System.Windows.Forms.Cursors.Hand;
		F09336AF.Location = new System.Drawing.Point(773, 743);
		F09336AF.Name = "button8";
		F09336AF.Size = new System.Drawing.Size(84, 25);
		F09336AF.TabIndex = 2;
		F09336AF.Text = "InputText";
		F09336AF.UseVisualStyleBackColor = true;
		F09336AF.Click += new System.EventHandler(F09336AF_Click);
		txtContent.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		txtContent.Location = new System.Drawing.Point(557, 744);
		txtContent.Name = "txtContent";
		txtContent.Size = new System.Drawing.Size(210, 23);
		txtContent.TabIndex = 1;
		FC0FAC1F.AutoSize = true;
		FC0FAC1F.Location = new System.Drawing.Point(12, 9);
		FC0FAC1F.Name = "label1";
		FC0FAC1F.Size = new System.Drawing.Size(65, 16);
		FC0FAC1F.TabIndex = 3;
		FC0FAC1F.Text = "Device ID:";
		groupBox8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		groupBox8.Controls.Add(txtSearchXpath);
		groupBox8.Controls.Add(C7A2352C);
		groupBox8.Controls.Add(CDA07A3A);
		groupBox8.Controls.Add(dtgvAttribute);
		groupBox8.Controls.Add(txtXPath);
		groupBox8.Controls.Add(label6);
		groupBox8.Controls.Add(BE2CAFBB);
		groupBox8.Controls.Add(BF251398);
		groupBox8.Controls.Add(button6);
		groupBox8.Controls.Add(F09336AF);
		groupBox8.Controls.Add(txtValue);
		groupBox8.Controls.Add(BA9E26B1);
		groupBox8.Controls.Add(txtContent);
		groupBox8.Controls.Add(DE84352B);
		groupBox8.Controls.Add(button4);
		groupBox8.Controls.Add(button3);
		groupBox8.Location = new System.Drawing.Point(353, 4);
		groupBox8.Name = "groupBox8";
		groupBox8.Size = new System.Drawing.Size(863, 774);
		groupBox8.TabIndex = 11;
		groupBox8.TabStop = false;
		C7A2352C.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		C7A2352C.Cursor = System.Windows.Forms.Cursors.Hand;
		C7A2352C.Location = new System.Drawing.Point(504, 743);
		C7A2352C.Name = "button13";
		C7A2352C.Size = new System.Drawing.Size(43, 24);
		C7A2352C.TabIndex = 12;
		C7A2352C.Text = "Copy";
		C7A2352C.UseVisualStyleBackColor = true;
		C7A2352C.Click += new System.EventHandler(A62629B1);
		CDA07A3A.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CDA07A3A.Location = new System.Drawing.Point(7, 21);
		CDA07A3A.Name = "treeView1";
		CDA07A3A.ShowNodeToolTips = true;
		CDA07A3A.Size = new System.Drawing.Size(541, 747);
		CDA07A3A.TabIndex = 9;
		CDA07A3A.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(A8AC93A5);
		dtgvAttribute.AllowUserToAddRows = false;
		dtgvAttribute.AllowUserToDeleteRows = false;
		dtgvAttribute.AllowUserToResizeRows = false;
		dtgvAttribute.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		dtgvAttribute.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dtgvAttribute.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dtgvAttribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvAttribute.Columns.AddRange(B93F9A1E, cValue);
		dtgvAttribute.Location = new System.Drawing.Point(557, 129);
		dtgvAttribute.MultiSelect = false;
		dtgvAttribute.Name = "dtgvAttribute";
		dtgvAttribute.ReadOnly = true;
		dtgvAttribute.RowHeadersVisible = false;
		dtgvAttribute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dtgvAttribute.Size = new System.Drawing.Size(300, 486);
		dtgvAttribute.TabIndex = 8;
		dtgvAttribute.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAttribute_CellClick);
		dtgvAttribute.KeyUp += new System.Windows.Forms.KeyEventHandler(dtgvAttribute_KeyUp);
		B93F9A1E.HeaderText = "Attribute";
		B93F9A1E.Name = "cAttribute";
		B93F9A1E.ReadOnly = true;
		cValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cValue.HeaderText = "Value";
		cValue.Name = "cValue";
		cValue.ReadOnly = true;
		txtXPath.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		txtXPath.Location = new System.Drawing.Point(616, 679);
		txtXPath.Name = "txtXPath";
		txtXPath.Size = new System.Drawing.Size(241, 23);
		txtXPath.TabIndex = 1;
		label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(554, 25);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(45, 16);
		label6.TabIndex = 3;
		label6.Text = "XPath:";
		label6.Click += new System.EventHandler(BF251398_Click);
		BE2CAFBB.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		BE2CAFBB.AutoSize = true;
		BE2CAFBB.Location = new System.Drawing.Point(554, 653);
		BE2CAFBB.Name = "label17";
		BE2CAFBB.Size = new System.Drawing.Size(44, 16);
		BE2CAFBB.TabIndex = 3;
		BE2CAFBB.Text = "Value:";
		BE2CAFBB.Click += new System.EventHandler(BF251398_Click);
		BF251398.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		BF251398.AutoSize = true;
		BF251398.Location = new System.Drawing.Point(554, 682);
		BF251398.Name = "label19";
		BF251398.Size = new System.Drawing.Size(45, 16);
		BF251398.TabIndex = 3;
		BF251398.Text = "XPath:";
		BF251398.Click += new System.EventHandler(BF251398_Click);
		button6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button6.Cursor = System.Windows.Forms.Cursors.Hand;
		button6.Location = new System.Drawing.Point(799, 21);
		button6.Name = "button6";
		button6.Size = new System.Drawing.Size(58, 25);
		button6.TabIndex = 2;
		button6.Text = "Search";
		button6.UseVisualStyleBackColor = true;
		button6.Click += new System.EventHandler(button6_Click);
		txtValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		txtValue.Location = new System.Drawing.Point(616, 650);
		txtValue.Name = "txtValue";
		txtValue.Size = new System.Drawing.Size(241, 23);
		txtValue.TabIndex = 1;
		BA9E26B1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		BA9E26B1.AutoSize = true;
		BA9E26B1.Location = new System.Drawing.Point(554, 624);
		BA9E26B1.Name = "label18";
		BA9E26B1.Size = new System.Drawing.Size(61, 16);
		BA9E26B1.TabIndex = 3;
		BA9E26B1.Text = "Attribute:";
		DE84352B.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		DE84352B.Location = new System.Drawing.Point(616, 621);
		DE84352B.Name = "txtAttribute";
		DE84352B.Size = new System.Drawing.Size(241, 23);
		DE84352B.TabIndex = 1;
		button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		button4.Cursor = System.Windows.Forms.Cursors.Hand;
		button4.Location = new System.Drawing.Point(713, 708);
		button4.Name = "button4";
		button4.Size = new System.Drawing.Size(144, 30);
		button4.TabIndex = 2;
		button4.Text = "Tap By Element";
		button4.UseVisualStyleBackColor = true;
		button4.Click += new System.EventHandler(FB2C8013);
		button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		button3.Cursor = System.Windows.Forms.Cursors.Hand;
		button3.Location = new System.Drawing.Point(557, 708);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(150, 30);
		button3.TabIndex = 2;
		button3.Text = "Tap By Bound";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		button25.Cursor = System.Windows.Forms.Cursors.Hand;
		button25.Location = new System.Drawing.Point(285, 5);
		button25.Name = "button25";
		button25.Size = new System.Drawing.Size(62, 24);
		button25.TabIndex = 12;
		button25.Text = "Check";
		button25.UseVisualStyleBackColor = true;
		button25.Click += new System.EventHandler(button25_Click);
		cbbDevice.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDevice.DropDownWidth = 300;
		cbbDevice.FormattingEnabled = true;
		cbbDevice.Location = new System.Drawing.Point(76, 5);
		cbbDevice.Name = "cbbDevice";
		cbbDevice.Size = new System.Drawing.Size(175, 24);
		cbbDevice.TabIndex = 13;
		pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
		pictureBox2.Image = Resource.Bitmap_148;
		pictureBox2.Location = new System.Drawing.Point(254, 5);
		pictureBox2.Name = "pictureBox2";
		pictureBox2.Size = new System.Drawing.Size(25, 25);
		pictureBox2.TabIndex = 11;
		pictureBox2.TabStop = false;
		pictureBox2.Click += new System.EventHandler(BC08F537);
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(12, 66);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(34, 16);
		label4.TabIndex = 3;
		label4.Text = "Xml:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(12, 39);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(48, 16);
		label5.TabIndex = 3;
		label5.Text = "Image:";
		txtPathImage.AllowDrop = true;
		txtPathImage.Location = new System.Drawing.Point(76, 36);
		txtPathImage.Name = "txtPathImage";
		txtPathImage.Size = new System.Drawing.Size(175, 23);
		txtPathImage.TabIndex = 14;
		txtPathXml.Location = new System.Drawing.Point(76, 63);
		txtPathXml.Name = "txtPathXml";
		txtPathXml.Size = new System.Drawing.Size(175, 23);
		txtPathXml.TabIndex = 14;
		F43B7EBE.Cursor = System.Windows.Forms.Cursors.Hand;
		F43B7EBE.Location = new System.Drawing.Point(285, 35);
		F43B7EBE.Name = "button5";
		F43B7EBE.Size = new System.Drawing.Size(62, 51);
		F43B7EBE.TabIndex = 12;
		F43B7EBE.Text = "Check";
		F43B7EBE.UseVisualStyleBackColor = true;
		F43B7EBE.Click += new System.EventHandler(A415AC3F);
		CB85F694.Cursor = System.Windows.Forms.Cursors.Hand;
		CB85F694.Location = new System.Drawing.Point(253, 35);
		CB85F694.Name = "button7";
		CB85F694.Size = new System.Drawing.Size(28, 25);
		CB85F694.TabIndex = 12;
		CB85F694.Text = "...";
		CB85F694.UseVisualStyleBackColor = true;
		CB85F694.Click += new System.EventHandler(CB85F694_Click);
		button9.Cursor = System.Windows.Forms.Cursors.Hand;
		button9.Location = new System.Drawing.Point(253, 62);
		button9.Name = "button9";
		button9.Size = new System.Drawing.Size(28, 25);
		button9.TabIndex = 12;
		button9.Text = "...";
		button9.UseVisualStyleBackColor = true;
		button9.Click += new System.EventHandler(AD2A0A0D);
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(12, 95);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(52, 16);
		label7.TabIndex = 3;
		label7.Text = "Activity:";
		A202CE29.Location = new System.Drawing.Point(76, 92);
		A202CE29.Name = "txtActivity";
		A202CE29.Size = new System.Drawing.Size(175, 23);
		A202CE29.TabIndex = 14;
		EDB9611E.Cursor = System.Windows.Forms.Cursors.Hand;
		EDB9611E.Location = new System.Drawing.Point(253, 91);
		EDB9611E.Name = "button29";
		EDB9611E.Size = new System.Drawing.Size(94, 25);
		EDB9611E.TabIndex = 12;
		EDB9611E.Text = "Open";
		EDB9611E.UseVisualStyleBackColor = true;
		EDB9611E.Click += new System.EventHandler(EDB9611E_Click);
		txtSearchXpath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		txtSearchXpath.Location = new System.Drawing.Point(605, 21);
		txtSearchXpath.Name = "txtSearchXpath";
		txtSearchXpath.Size = new System.Drawing.Size(188, 102);
		txtSearchXpath.TabIndex = 13;
		txtSearchXpath.Text = "";
		txtSearchXpath.WordWrap = false;
		AllowDrop = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1225, 783);
		base.Controls.Add(A202CE29);
		base.Controls.Add(txtPathXml);
		base.Controls.Add(txtPathImage);
		base.Controls.Add(label7);
		base.Controls.Add(pictureBox2);
		base.Controls.Add(cbbDevice);
		base.Controls.Add(F43B7EBE);
		base.Controls.Add(button9);
		base.Controls.Add(EDB9611E);
		base.Controls.Add(CB85F694);
		base.Controls.Add(button25);
		base.Controls.Add(groupBox8);
		base.Controls.Add(label5);
		base.Controls.Add(label4);
		base.Controls.Add(FC0FAC1F);
		base.Controls.Add(groupBox2);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fCheckAppium";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "ToolCheckAppium";
		base.Load += new System.EventHandler(fCheckAppium_Load);
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		B510A901.ResumeLayout(false);
		B510A901.PerformLayout();
		A2B85EA3.ResumeLayout(false);
		A2B85EA3.PerformLayout();
		groupBox8.ResumeLayout(false);
		groupBox8.PerformLayout();
		((System.ComponentModel.ISupportInitialize)dtgvAttribute).EndInit();
		((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
