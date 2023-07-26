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

public class fClearBackup : Form
{
	[CompilerGenerated]
	private sealed class Class69
	{
		internal int int_0;

		internal int F220A53E;

		internal string string_0;

		internal fClearBackup fClearBackup_0;

		internal int int_1;

		internal Action A086CB80;

		internal void FA0D6108()
		{
			try
			{
				int num = 0;
				while (num < fClearBackup_0.E43B4108.Count)
				{
					if (int_0 < F220A53E)
					{
						CD1C2133 CS_0024_003C_003E8__locals0 = new CD1C2133
						{
							AE32E42C = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.D693E197 = num++;
						Thread thread = new Thread((ThreadStart)delegate
						{
							try
							{
								string path = CS_0024_003C_003E8__locals0.AE32E42C.string_0 + "\\" + CS_0024_003C_003E8__locals0.AE32E42C.fClearBackup_0.E43B4108[CS_0024_003C_003E8__locals0.D693E197];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref CS_0024_003C_003E8__locals0.AE32E42C.int_1);
								CS_0024_003C_003E8__locals0.AE32E42C.fClearBackup_0.method_1(string.Format(Language.GetValue("Đang dọn dẹp backup {0}/{1}..."), CS_0024_003C_003E8__locals0.AE32E42C.int_1, CS_0024_003C_003E8__locals0.AE32E42C.fClearBackup_0.E43B4108.Count));
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.AE32E42C.int_0);
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
				fClearBackup_0.Invoke((Action)delegate
				{
					fClearBackup_0.Close();
					MessageBoxHelper.Show(Language.GetValue("Đã dọn dẹp file backup xong!"));
				});
			}
			catch
			{
			}
		}

		internal void AAAF350E()
		{
			fClearBackup_0.Close();
			MessageBoxHelper.Show(Language.GetValue("Đã dọn dẹp file backup xong!"));
		}
	}

	[CompilerGenerated]
	private sealed class CD1C2133
	{
		internal int D693E197;

		internal Class69 AE32E42C;

		internal void E7823038()
		{
			try
			{
				string path = AE32E42C.string_0 + "\\" + AE32E42C.fClearBackup_0.E43B4108[D693E197];
				Directory.Delete(path, recursive: true);
				Interlocked.Increment(ref AE32E42C.int_1);
				AE32E42C.fClearBackup_0.method_1(string.Format(Language.GetValue("Đang dọn dẹp backup {0}/{1}..."), AE32E42C.int_1, AE32E42C.fClearBackup_0.E43B4108.Count));
				Interlocked.Decrement(ref AE32E42C.int_0);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class CD38232B
	{
		internal fClearBackup DCBF5184;

		internal string string_0;

		internal void AB2C010B()
		{
			DCBF5184.lblStatus.Text = string_0;
		}
	}

	internal List<string> E43B4108 = new List<string>();

	internal IContainer CF0D282C = null;

	internal BunifuCards A90C9B84;

	internal Panel FB3AFF2D;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal Button btnCancel;

	internal Button AB30E51F;

	internal BunifuDragControl F420A9AD;

	internal BunifuCustomLabel lblStatus;

	internal PictureBox EC369EA4;

	public fClearBackup()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AB30E51F_Click(object sender, EventArgs e)
	{
		AB30E51F.Enabled = false;
		btnCancel.Enabled = false;
		method_1(string.Format(Language.GetValue("Đang dọn dẹp backup {0}/{1}..."), 0, E43B4108.Count));
		int int_0 = 0;
		int F220A53E = 20;
		int int_1 = 0;
		string string_0 = FileHelper.GetPathToCurrentFolder() + "\\backup";
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < E43B4108.Count)
				{
					if (int_0 < F220A53E)
					{
						Interlocked.Increment(ref int_0);
						int D693E197 = num++;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							try
							{
								string path = string_0 + "\\" + E43B4108[D693E197];
								Directory.Delete(path, recursive: true);
								Interlocked.Increment(ref int_1);
								method_1(string.Format(Language.GetValue("Đang dọn dẹp backup {0}/{1}..."), int_1, E43B4108.Count));
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
					MessageBoxHelper.Show(Language.GetValue("Đã dọn dẹp file backup xong!"));
				});
			}
			catch
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void E6B1882B(object sender, EventArgs e)
	{
		Close();
	}

	private void E2A02E96(object sender, EventArgs e)
	{
	}

	private List<string> method_0()
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

	private void method_1(string BB89A700)
	{
		Invoke((Action)delegate
		{
			lblStatus.Text = BB89A700;
		});
	}

	private void fClearBackup_Load(object sender, EventArgs e)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				List<string> list = Directory.GetDirectories(FileHelper.GetPathToCurrentFolder() + "\\backup").ToList();
				List<string> list2 = method_0();
				string text = "";
				for (int i = 0; i < list.Count; i++)
				{
					text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
					if (!list2.Contains(text))
					{
						E43B4108.Add(text);
					}
				}
				if (E43B4108.Count > 0)
				{
					Invoke((Action)delegate
					{
						lblStatus.Text = string.Format(Language.GetValue("Tìm thấy {0} file backup rác!"), E43B4108.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
						AB30E51F.Visible = true;
						btnCancel.Visible = true;
					});
				}
				else
				{
					Invoke((Action)delegate
					{
						Close();
						MessageBoxHelper.Show(Language.GetValue("Không có file backup rác!"));
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

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && CF0D282C != null)
		{
			CF0D282C.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		CF0D282C = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fClearBackup));
		A90C9B84 = new Bunifu.Framework.UI.BunifuCards();
		FB3AFF2D = new System.Windows.Forms.Panel();
		EC369EA4 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		AB30E51F = new System.Windows.Forms.Button();
		F420A9AD = new Bunifu.Framework.UI.BunifuDragControl(CF0D282C);
		lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
		A90C9B84.SuspendLayout();
		FB3AFF2D.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)EC369EA4).BeginInit();
		SuspendLayout();
		A90C9B84.BackColor = System.Drawing.Color.White;
		A90C9B84.BorderRadius = 0;
		A90C9B84.BottomSahddow = true;
		A90C9B84.color = System.Drawing.Color.SaddleBrown;
		A90C9B84.Controls.Add(FB3AFF2D);
		A90C9B84.Dock = System.Windows.Forms.DockStyle.Top;
		A90C9B84.LeftSahddow = false;
		A90C9B84.Location = new System.Drawing.Point(0, 0);
		A90C9B84.Name = "bunifuCards1";
		A90C9B84.RightSahddow = true;
		A90C9B84.ShadowDepth = 20;
		A90C9B84.Size = new System.Drawing.Size(396, 38);
		A90C9B84.TabIndex = 0;
		FB3AFF2D.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FB3AFF2D.BackColor = System.Drawing.Color.White;
		FB3AFF2D.Controls.Add(EC369EA4);
		FB3AFF2D.Controls.Add(btnMinimize);
		FB3AFF2D.Controls.Add(bunifuCustomLabel1);
		FB3AFF2D.Location = new System.Drawing.Point(0, 5);
		FB3AFF2D.Name = "pnlHeader";
		FB3AFF2D.Size = new System.Drawing.Size(396, 32);
		FB3AFF2D.TabIndex = 9;
		EC369EA4.Cursor = System.Windows.Forms.Cursors.Default;
		EC369EA4.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		EC369EA4.Location = new System.Drawing.Point(3, 2);
		EC369EA4.Name = "pictureBox1";
		EC369EA4.Size = new System.Drawing.Size(34, 27);
		EC369EA4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		EC369EA4.TabIndex = 17;
		EC369EA4.TabStop = false;
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
		bunifuCustomLabel1.Text = "Dọn dẹp backup";
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
		btnCancel.Click += new System.EventHandler(E6B1882B);
		AB30E51F.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		AB30E51F.Cursor = System.Windows.Forms.Cursors.Hand;
		AB30E51F.FlatAppearance.BorderSize = 0;
		AB30E51F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AB30E51F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AB30E51F.ForeColor = System.Drawing.Color.White;
		AB30E51F.Location = new System.Drawing.Point(100, 105);
		AB30E51F.Name = "btnAdd";
		AB30E51F.Size = new System.Drawing.Size(92, 29);
		AB30E51F.TabIndex = 3;
		AB30E51F.Text = "Đồng ý";
		AB30E51F.UseVisualStyleBackColor = false;
		AB30E51F.Visible = false;
		AB30E51F.Click += new System.EventHandler(AB30E51F_Click);
		F420A9AD.Fixed = true;
		F420A9AD.Horizontal = true;
		F420A9AD.TargetControl = bunifuCustomLabel1;
		F420A9AD.Vertical = true;
		lblStatus.BackColor = System.Drawing.Color.Transparent;
		lblStatus.Cursor = System.Windows.Forms.Cursors.SizeAll;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.ForeColor = System.Drawing.Color.Black;
		lblStatus.Location = new System.Drawing.Point(-1, 57);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(396, 32);
		lblStatus.TabIndex = 21;
		lblStatus.Text = "Đang quét file backup...";
		lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		lblStatus.Click += new System.EventHandler(E2A02E96);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(396, 145);
		base.Controls.Add(lblStatus);
		base.Controls.Add(btnCancel);
		base.Controls.Add(AB30E51F);
		base.Controls.Add(A90C9B84);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fClearBackup";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fClearBackup_Load);
		A90C9B84.ResumeLayout(false);
		FB3AFF2D.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)EC369EA4).EndInit();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_2()
	{
		try
		{
			List<string> list = Directory.GetDirectories(FileHelper.GetPathToCurrentFolder() + "\\backup").ToList();
			List<string> list2 = method_0();
			string text = "";
			for (int i = 0; i < list.Count; i++)
			{
				text = list[i].Substring(list[i].LastIndexOf("\\") + 1);
				if (!list2.Contains(text))
				{
					E43B4108.Add(text);
				}
			}
			if (E43B4108.Count > 0)
			{
				Invoke((Action)delegate
				{
					lblStatus.Text = string.Format(Language.GetValue("Tìm thấy {0} file backup rác!"), E43B4108.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
					AB30E51F.Visible = true;
					btnCancel.Visible = true;
				});
			}
			else
			{
				Invoke((Action)delegate
				{
					Close();
					MessageBoxHelper.Show(Language.GetValue("Không có file backup rác!"));
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
		lblStatus.Text = string.Format(Language.GetValue("Tìm thấy {0} file backup rác!"), E43B4108.Count) + "\r\n" + Language.GetValue("Bạn có muốn dọn dẹp?");
		AB30E51F.Visible = true;
		btnCancel.Visible = true;
	}

	[CompilerGenerated]
	private void CA0A9610()
	{
		Close();
		MessageBoxHelper.Show(Language.GetValue("Không có file backup rác!"));
	}

	[CompilerGenerated]
	private void method_4()
	{
		Close();
	}
}
