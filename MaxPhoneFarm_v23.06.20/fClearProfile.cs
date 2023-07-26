using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fClearProfile : Form
{
	[CompilerGenerated]
	private sealed class Class84
	{
		internal int int_0;

		internal int B4073208;

		internal fClearProfile fClearProfile_0;

		internal int int_1;

		internal Action FE8C7A2D;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < fClearProfile_0.list_0.Count)
				{
					if (int_0 < B4073208)
					{
						FE914E8B CS_0024_003C_003E8__locals0 = new FE914E8B
						{
							FA91CD00 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						Thread thread = new Thread((ThreadStart)delegate
						{
							try
							{
								string text = FileHelper.GetPathToCurrentFolder() + "\\profile\\" + CS_0024_003C_003E8__locals0.FA91CD00.fClearProfile_0.list_0[CS_0024_003C_003E8__locals0.int_0];
								if (File.Exists(text + ".tar.gz"))
								{
									File.Delete(text + ".tar.gz");
								}
								text = FileHelper.GetPathToCurrentFolder() + "\\device\\" + CS_0024_003C_003E8__locals0.FA91CD00.fClearProfile_0.list_0[CS_0024_003C_003E8__locals0.int_0];
								if (File.Exists(text + ".tar.gz"))
								{
									File.Delete(text + ".tar.gz");
								}
								Interlocked.Increment(ref CS_0024_003C_003E8__locals0.FA91CD00.int_1);
								CS_0024_003C_003E8__locals0.FA91CD00.fClearProfile_0.method_0(string.Format(Language.GetValue("Đang dọn dẹp data {0}/{1}..."), CS_0024_003C_003E8__locals0.FA91CD00.int_1, CS_0024_003C_003E8__locals0.FA91CD00.fClearProfile_0.list_0.Count));
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.FA91CD00.int_0);
							}
							catch
							{
							}
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
				while (int_0 > 0)
				{
					Common.DelayTime(1.0);
				}
				fClearProfile_0.Invoke((Action)delegate
				{
					fClearProfile_0.Close();
					MessageBoxHelper.Show(Language.GetValue("Đã dọn dẹp profile xong!"));
				});
			}
			catch
			{
			}
		}

		internal void method_1()
		{
			fClearProfile_0.Close();
			MessageBoxHelper.Show(Language.GetValue("Đã dọn dẹp profile xong!"));
		}
	}

	[CompilerGenerated]
	private sealed class FE914E8B
	{
		internal int int_0;

		internal Class84 FA91CD00;

		internal void E9A4F21A()
		{
			try
			{
				string text = FileHelper.GetPathToCurrentFolder() + "\\profile\\" + FA91CD00.fClearProfile_0.list_0[int_0];
				if (File.Exists(text + ".tar.gz"))
				{
					File.Delete(text + ".tar.gz");
				}
				text = FileHelper.GetPathToCurrentFolder() + "\\device\\" + FA91CD00.fClearProfile_0.list_0[int_0];
				if (File.Exists(text + ".tar.gz"))
				{
					File.Delete(text + ".tar.gz");
				}
				Interlocked.Increment(ref FA91CD00.int_1);
				FA91CD00.fClearProfile_0.method_0(string.Format(Language.GetValue("Đang dọn dẹp data {0}/{1}..."), FA91CD00.int_1, FA91CD00.fClearProfile_0.list_0.Count));
				Interlocked.Decrement(ref FA91CD00.int_0);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class85
	{
		internal fClearProfile D80A07BD;

		internal string string_0;

		internal void method_0()
		{
			D80A07BD.lblStatus.Text = string_0;
		}
	}

	internal List<string> list_0 = new List<string>();

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Button btnCancel;

	internal Button btnAdd;

	internal BunifuDragControl B421171C;

	internal BunifuCustomLabel lblStatus;

	internal PictureBox pictureBox1;

	public fClearProfile()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		btnAdd.Enabled = false;
		btnCancel.Enabled = false;
		int int_1 = 0;
		method_0(string.Format(Language.GetValue("Đang dọn dẹp data {0}/{1}..."), int_1, list_0.Count));
		int int_0 = 0;
		int B4073208 = 20;
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < list_0.Count)
				{
					if (int_0 < B4073208)
					{
						Interlocked.Increment(ref int_0);
						int int_2 = num++;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							try
							{
								string text = FileHelper.GetPathToCurrentFolder() + "\\profile\\" + list_0[int_2];
								if (File.Exists(text + ".tar.gz"))
								{
									File.Delete(text + ".tar.gz");
								}
								text = FileHelper.GetPathToCurrentFolder() + "\\device\\" + list_0[int_2];
								if (File.Exists(text + ".tar.gz"))
								{
									File.Delete(text + ".tar.gz");
								}
								Interlocked.Increment(ref int_1);
								method_0(string.Format(Language.GetValue("Đang dọn dẹp data {0}/{1}..."), int_1, list_0.Count));
								Interlocked.Decrement(ref int_0);
							}
							catch
							{
							}
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
				while (int_0 > 0)
				{
					Common.DelayTime(1.0);
				}
				Invoke((Action)delegate
				{
					Close();
					MessageBoxHelper.Show(Language.GetValue("Đã dọn dẹp profile xong!"));
				});
			}
			catch
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void EAB1FB35(object sender, EventArgs e)
	{
	}

	private List<string> E6B4C782()
	{
		List<string> list = new List<string>();
		try
		{
			DataTable dataTable = CommonSQL.smethod_12("uid");
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i]["uid"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	private void method_0(string string_0)
	{
		Invoke((Action)delegate
		{
			lblStatus.Text = string_0;
		});
	}

	protected override void OnLoad(EventArgs EEA88DBF)
	{
		Application.Idle += method_1;
	}

	private void method_1(object sender, EventArgs e)
	{
		Application.Idle -= method_1;
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				List<string> list = new List<string>();
				string path = FileHelper.GetPathToCurrentFolder() + "\\profile";
				DirectoryInfo directoryInfo = new DirectoryInfo(path);
				FileInfo[] files = directoryInfo.GetFiles("*.tar.gz");
				FileInfo[] array = files;
				foreach (FileInfo fileInfo in array)
				{
					list.Add(Path.GetFileNameWithoutExtension(fileInfo.FullName).Split('.')[0]);
				}
				string path2 = FileHelper.GetPathToCurrentFolder() + "\\device";
				DirectoryInfo directoryInfo2 = new DirectoryInfo(path2);
				FileInfo[] files2 = directoryInfo2.GetFiles("*.tar.gz");
				FileInfo[] array2 = files2;
				foreach (FileInfo fileInfo2 in array2)
				{
					list.Add(Path.GetFileNameWithoutExtension(fileInfo2.FullName).Split('.')[0]);
				}
				list = list.Distinct().ToList();
				List<string> second = E6B4C782();
				list_0 = list.Except(second).ToList();
				if (list_0.Count > 0)
				{
					Invoke((Action)delegate
					{
						lblStatus.Text = string.Format(Language.GetValue("Tìm thấy {0} data rác!"), list_0.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
						btnAdd.Visible = true;
						btnCancel.Visible = true;
					});
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("Không có data rác!"));
					Invoke((Action)delegate
					{
						Close();
					});
				}
			}
			catch (Exception)
			{
				Invoke((Action)delegate
				{
					Close();
				});
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void fClearProfile_Load(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fClearProfile));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		B421171C = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(396, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(396, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(364, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(396, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Dọn dẹp profile";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(204, 105);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Hủy";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Visible = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(100, 105);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Đồng ý";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Visible = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		B421171C.Fixed = true;
		B421171C.Horizontal = true;
		B421171C.TargetControl = bunifuCustomLabel1;
		B421171C.Vertical = true;
		lblStatus.BackColor = System.Drawing.Color.Transparent;
		lblStatus.Cursor = System.Windows.Forms.Cursors.SizeAll;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.ForeColor = System.Drawing.Color.Black;
		lblStatus.Location = new System.Drawing.Point(-1, 57);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(396, 32);
		lblStatus.TabIndex = 21;
		lblStatus.Text = "Đang quét profile...";
		lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		lblStatus.Click += new System.EventHandler(EAB1FB35);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(396, 145);
		base.Controls.Add(lblStatus);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fClearProfile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fClearProfile_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_2()
	{
		try
		{
			List<string> list = new List<string>();
			string path = FileHelper.GetPathToCurrentFolder() + "\\profile";
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			FileInfo[] files = directoryInfo.GetFiles("*.tar.gz");
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				list.Add(Path.GetFileNameWithoutExtension(fileInfo.FullName).Split('.')[0]);
			}
			string path2 = FileHelper.GetPathToCurrentFolder() + "\\device";
			DirectoryInfo directoryInfo2 = new DirectoryInfo(path2);
			FileInfo[] files2 = directoryInfo2.GetFiles("*.tar.gz");
			FileInfo[] array2 = files2;
			foreach (FileInfo fileInfo2 in array2)
			{
				list.Add(Path.GetFileNameWithoutExtension(fileInfo2.FullName).Split('.')[0]);
			}
			list = list.Distinct().ToList();
			List<string> second = E6B4C782();
			list_0 = list.Except(second).ToList();
			if (list_0.Count > 0)
			{
				Invoke((Action)delegate
				{
					lblStatus.Text = string.Format(Language.GetValue("Tìm thấy {0} data rác!"), list_0.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
					btnAdd.Visible = true;
					btnCancel.Visible = true;
				});
			}
			else
			{
				MessageBoxHelper.Show(Language.GetValue("Không có data rác!"));
				Invoke((Action)delegate
				{
					Close();
				});
			}
		}
		catch (Exception)
		{
			Invoke((Action)delegate
			{
				Close();
			});
		}
	}

	[CompilerGenerated]
	private void method_3()
	{
		lblStatus.Text = string.Format(Language.GetValue("Tìm thấy {0} data rác!"), list_0.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
		btnAdd.Visible = true;
		btnCancel.Visible = true;
	}

	[CompilerGenerated]
	private void method_4()
	{
		Close();
	}

	[CompilerGenerated]
	private void A728F204()
	{
		Close();
	}
}
