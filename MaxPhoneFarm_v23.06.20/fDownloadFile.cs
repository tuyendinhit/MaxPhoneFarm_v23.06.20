using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public class fDownloadFile : Form
{
	[CompilerGenerated]
	private sealed class A0256CA7
	{
		internal fDownloadFile fDownloadFile_0;

		internal Uri uri_0;

		internal string C89A9AB9;

		internal void BB8F7F12()
		{
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += fDownloadFile_0.C6925A83;
			webClient.DownloadFileCompleted += fDownloadFile_0.method_1;
			webClient.DownloadFileAsync(uri_0, C89A9AB9);
		}
	}

	[CompilerGenerated]
	private sealed class Class55
	{
		internal DownloadProgressChangedEventArgs downloadProgressChangedEventArgs_0;

		internal fDownloadFile fDownloadFile_0;

		internal void method_0()
		{
			double num = double.Parse(downloadProgressChangedEventArgs_0.BytesReceived.ToString());
			double num2 = double.Parse(downloadProgressChangedEventArgs_0.TotalBytesToReceive.ToString());
			double d = num / num2 * 100.0;
			fDownloadFile_0.lblproccess.Text = $"Downloading ({int.Parse(Math.Truncate(d).ToString())}%)...";
			fDownloadFile_0.progressBar1.Value = int.Parse(Math.Truncate(d).ToString());
		}
	}

	internal string string_0 = "";

	internal string string_1 = "";

	internal IContainer icontainer_0 = null;

	internal Label lblproccess;

	internal ProgressBar progressBar1;

	public fDownloadFile(string string_2)
	{
		InitializeComponent();
		BDA52A00();
		string_0 = string_2;
		string_1 = Path.GetFileName(string_0);
	}

	private void BDA52A00()
	{
		Language.smethod_1(lblproccess);
	}

	private void fDownloadFile_Load(object sender, EventArgs e)
	{
		try
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			_ = Base.E696F236 + Base.string_1;
			if (InternetConnection.C41C7284())
			{
				Uri uri_ = new Uri(string_0);
				Common.DC3740BE("download");
				Common.CreateFolder("download");
				E52800AE(uri_, FileHelper.GetPathToCurrentFolder() + "\\download\\" + string_1);
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Không co\u0301 kê\u0301t nô\u0301i Internet, vui lo\u0300ng kiê\u0309m tra la\u0323i!"));
				Close();
			}
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show("Error: " + ex.Message, 2);
			Close();
		}
	}

	public void B7B655B8(string string_2, string string_3)
	{
		DirectoryInfo directoryInfo_ = new DirectoryInfo(string_2);
		DirectoryInfo directoryInfo_2 = new DirectoryInfo(string_3);
		method_0(directoryInfo_, directoryInfo_2);
	}

	public void method_0(DirectoryInfo directoryInfo_0, DirectoryInfo directoryInfo_1)
	{
		Directory.CreateDirectory(directoryInfo_1.FullName);
		int num = 1;
		FileInfo[] files = directoryInfo_0.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			Application.DoEvents();
			fileInfo.CopyTo(Path.Combine(directoryInfo_1.FullName, fileInfo.Name), overwrite: true);
			num++;
		}
		DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			DirectoryInfo directoryInfo_2 = directoryInfo_1.CreateSubdirectory(directoryInfo.Name);
			method_0(directoryInfo, directoryInfo_2);
		}
	}

	private void E52800AE(Uri uri_0, string string_2)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += C6925A83;
			webClient.DownloadFileCompleted += method_1;
			webClient.DownloadFileAsync(uri_0, string_2);
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void C6925A83(object sender, DownloadProgressChangedEventArgs e)
	{
		BeginInvoke((MethodInvoker)delegate
		{
			double num = double.Parse(e.BytesReceived.ToString());
			double num2 = double.Parse(e.TotalBytesToReceive.ToString());
			double d = num / num2 * 100.0;
			lblproccess.Text = $"Downloading ({int.Parse(Math.Truncate(d).ToString())}%)...";
			progressBar1.Value = int.Parse(Math.Truncate(d).ToString());
		});
	}

	private void method_1(object sender, AsyncCompletedEventArgs e)
	{
		BeginInvoke((MethodInvoker)delegate
		{
			lblproccess.Text = Language.GetValue("Unzip file...");
		});
		try
		{
			ZipFile.ExtractToDirectory("./download/" + string_1, "./download/");
			Common.smethod_49("./download/" + string_1);
			B7B655B8("download", "./");
			Common.DC3740BE("download");
			BeginInvoke((MethodInvoker)delegate
			{
				Close();
			});
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show("Error: " + ex.Message, 2);
			BeginInvoke((MethodInvoker)delegate
			{
				Close();
			});
		}
	}

	protected override void Dispose(bool B901EA1A)
	{
		if (B901EA1A && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B901EA1A);
	}

	private void InitializeComponent()
	{
		lblproccess = new System.Windows.Forms.Label();
		progressBar1 = new System.Windows.Forms.ProgressBar();
		SuspendLayout();
		lblproccess.AutoSize = true;
		lblproccess.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblproccess.Location = new System.Drawing.Point(34, 22);
		lblproccess.Name = "lblproccess";
		lblproccess.Size = new System.Drawing.Size(125, 16);
		lblproccess.TabIndex = 1;
		lblproccess.Text = "Downloading (0%)...";
		progressBar1.Location = new System.Drawing.Point(37, 52);
		progressBar1.Name = "progressBar1";
		progressBar1.Size = new System.Drawing.Size(219, 23);
		progressBar1.TabIndex = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		base.ClientSize = new System.Drawing.Size(294, 104);
		base.Controls.Add(progressBar1);
		base.Controls.Add(lblproccess);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fDownloadFile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "frm_progress";
		base.Load += new System.EventHandler(fDownloadFile_Load);
		ResumeLayout(false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void method_2()
	{
		lblproccess.Text = Language.GetValue("Unzip file...");
	}

	[CompilerGenerated]
	private void method_3()
	{
		Close();
	}

	[CompilerGenerated]
	private void method_4()
	{
		Close();
	}
}
