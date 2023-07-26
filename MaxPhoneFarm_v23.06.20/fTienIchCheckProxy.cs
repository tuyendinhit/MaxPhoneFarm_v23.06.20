using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckProxy : Form
{
	[CompilerGenerated]
	private sealed class CB0BE833
	{
		internal int int_0;

		internal int int_1;

		internal fTienIchCheckProxy D8228518;
	}

	[CompilerGenerated]
	private sealed class CD10F082
	{
		internal string string_0;

		internal CB0BE833 EF822D09;

		internal void method_0()
		{
			if (EF822D09.D8228518.CheckProy(string_0, EF822D09.int_0))
			{
				EF822D09.D8228518.AddRowIntoTextbox(EF822D09.D8228518.A48B0BAC, string_0);
			}
			else
			{
				EF822D09.D8228518.AddRowIntoTextbox(EF822D09.D8228518.txtChuaTao, string_0);
			}
			Interlocked.Decrement(ref EF822D09.int_1);
		}
	}

	[CompilerGenerated]
	private sealed class B09A2A92
	{
		internal RichTextBox richTextBox_0;

		internal string string_0;

		internal void method_0()
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
		}
	}

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel panel1;

	internal BunifuDragControl DA891393;

	internal ToolTip C2915E29;

	internal BunifuCards bunifuCards2;

	internal Panel pnlHeader;

	internal Button button2;

	internal PictureBox pictureBox1;

	internal Button btnMinimize;

	internal BunifuCustomLabel C7B74EA2;

	internal Button CA93ABA1;

	internal RichTextBox txtInput;

	internal GroupBox D13DEDBF;

	internal RichTextBox A48B0BAC;

	internal GroupBox BDBC1796;

	internal GroupBox C29AA9A6;

	internal RichTextBox txtChuaTao;

	internal Label E1A32983;

	internal ComboBox cbbTypeProxy;

	internal Label C1142F21;

	public fTienIchCheckProxy()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(BDBC1796);
		Language.smethod_1(C1142F21);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CA93ABA1_Click(object sender, EventArgs e)
	{
		try
		{
			int typeProxy = cbbTypeProxy.SelectedIndex;
			List<string> list = new List<string>();
			list = txtInput.Lines.ToList();
			int iThread = 0;
			int num = 10;
			E1A32983.Invoke((MethodInvoker)delegate
			{
				E1A32983.Visible = true;
			});
			int num2 = 0;
			while (num2 < list.Count)
			{
				if (iThread < num)
				{
					Interlocked.Increment(ref iThread);
					string Proxy = list[num2++];
					Thread thread = new Thread((ThreadStart)delegate
					{
						if (CheckProy(Proxy, typeProxy))
						{
							AddRowIntoTextbox(A48B0BAC, Proxy);
						}
						else
						{
							AddRowIntoTextbox(txtChuaTao, Proxy);
						}
						Interlocked.Decrement(ref iThread);
					});
					thread.IsBackground = true;
					thread.Start();
				}
				else
				{
					Application.DoEvents();
					Common.DelayTime(1.0);
				}
			}
			while (iThread > 0)
			{
				Common.DelayTime(1.0);
			}
			E1A32983.Invoke((MethodInvoker)delegate
			{
				E1A32983.Visible = false;
			});
			MessageBoxHelper.Show(Language.GetValue("Đã check xong!"));
		}
		catch (Exception)
		{
			MessageBoxHelper.Show(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void AddRowIntoTextbox(RichTextBox richTextBox_0, string ED8F928F)
	{
		richTextBox_0.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + ED8F928F + "\r\n";
		});
	}

	private bool CheckProy(string Proxy, int typeProxy)
	{
		try
		{
			if (Common.CheckProxy(Proxy, typeProxy) != "")
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private void F4B99182(object sender, EventArgs e)
	{
		Common.D936DD84(txtInput, BDBC1796);
	}

	private void A48B0BAC_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = A48B0BAC.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			D13DEDBF.Text = "LIVE (" + f1808BA.Count + ")";
		}
		catch
		{
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void B5910715(object sender, EventArgs e)
	{
		cbbTypeProxy.SelectedIndex = 0;
	}

	private void txtChuaTao_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtChuaTao.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			C29AA9A6.Text = "DIE (" + f1808BA.Count + ")";
		}
		catch
		{
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
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		E1A32983 = new System.Windows.Forms.Label();
		C29AA9A6 = new System.Windows.Forms.GroupBox();
		txtChuaTao = new System.Windows.Forms.RichTextBox();
		D13DEDBF = new System.Windows.Forms.GroupBox();
		A48B0BAC = new System.Windows.Forms.RichTextBox();
		BDBC1796 = new System.Windows.Forms.GroupBox();
		cbbTypeProxy = new System.Windows.Forms.ComboBox();
		C1142F21 = new System.Windows.Forms.Label();
		txtInput = new System.Windows.Forms.RichTextBox();
		CA93ABA1 = new System.Windows.Forms.Button();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		C7B74EA2 = new Bunifu.Framework.UI.BunifuCustomLabel();
		DA891393 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		C2915E29 = new System.Windows.Forms.ToolTip(icontainer_0);
		panel1.SuspendLayout();
		C29AA9A6.SuspendLayout();
		D13DEDBF.SuspendLayout();
		BDBC1796.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(421, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(E1A32983);
		panel1.Controls.Add(C29AA9A6);
		panel1.Controls.Add(D13DEDBF);
		panel1.Controls.Add(BDBC1796);
		panel1.Controls.Add(CA93ABA1);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(750, 404);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		E1A32983.AutoSize = true;
		E1A32983.ForeColor = System.Drawing.Color.DarkGreen;
		E1A32983.Location = new System.Drawing.Point(435, 59);
		E1A32983.Name = "lblStatus";
		E1A32983.Size = new System.Drawing.Size(71, 16);
		E1A32983.TabIndex = 52;
		E1A32983.Text = "Checking...";
		E1A32983.Visible = false;
		C29AA9A6.Controls.Add(txtChuaTao);
		C29AA9A6.ForeColor = System.Drawing.Color.DarkRed;
		C29AA9A6.Location = new System.Drawing.Point(521, 91);
		C29AA9A6.Name = "grChuaTao";
		C29AA9A6.Size = new System.Drawing.Size(221, 307);
		C29AA9A6.TabIndex = 51;
		C29AA9A6.TabStop = false;
		C29AA9A6.Text = "DIE (0)";
		txtChuaTao.Dock = System.Windows.Forms.DockStyle.Fill;
		txtChuaTao.Location = new System.Drawing.Point(3, 19);
		txtChuaTao.Name = "txtChuaTao";
		txtChuaTao.Size = new System.Drawing.Size(215, 285);
		txtChuaTao.TabIndex = 50;
		txtChuaTao.Text = "";
		txtChuaTao.WordWrap = false;
		txtChuaTao.TextChanged += new System.EventHandler(txtChuaTao_TextChanged);
		D13DEDBF.Controls.Add(A48B0BAC);
		D13DEDBF.ForeColor = System.Drawing.Color.DarkGreen;
		D13DEDBF.Location = new System.Drawing.Point(294, 91);
		D13DEDBF.Name = "grDaTao";
		D13DEDBF.Size = new System.Drawing.Size(221, 307);
		D13DEDBF.TabIndex = 51;
		D13DEDBF.TabStop = false;
		D13DEDBF.Text = "LIVE (0)";
		A48B0BAC.Dock = System.Windows.Forms.DockStyle.Fill;
		A48B0BAC.Location = new System.Drawing.Point(3, 19);
		A48B0BAC.Name = "txtDaTao";
		A48B0BAC.Size = new System.Drawing.Size(215, 285);
		A48B0BAC.TabIndex = 50;
		A48B0BAC.Text = "";
		A48B0BAC.WordWrap = false;
		A48B0BAC.TextChanged += new System.EventHandler(A48B0BAC_TextChanged);
		BDBC1796.Controls.Add(cbbTypeProxy);
		BDBC1796.Controls.Add(C1142F21);
		BDBC1796.Controls.Add(txtInput);
		BDBC1796.Location = new System.Drawing.Point(6, 40);
		BDBC1796.Name = "groupBox1";
		BDBC1796.Size = new System.Drawing.Size(282, 358);
		BDBC1796.TabIndex = 51;
		BDBC1796.TabStop = false;
		BDBC1796.Text = "Nhập Proxy (0)";
		cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbTypeProxy.FormattingEnabled = true;
		cbbTypeProxy.Items.AddRange(new object[2] { "HTTP/HTTPS", "Sock5" });
		cbbTypeProxy.Location = new System.Drawing.Point(83, 324);
		cbbTypeProxy.Name = "cbbTypeProxy";
		cbbTypeProxy.Size = new System.Drawing.Size(193, 24);
		cbbTypeProxy.TabIndex = 126;
		C1142F21.AutoSize = true;
		C1142F21.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C1142F21.Location = new System.Drawing.Point(6, 327);
		C1142F21.Name = "label3";
		C1142F21.Size = new System.Drawing.Size(71, 16);
		C1142F21.TabIndex = 125;
		C1142F21.Text = "Loa\u0323i Proxy:";
		txtInput.Location = new System.Drawing.Point(9, 19);
		txtInput.Name = "txtInput";
		txtInput.Size = new System.Drawing.Size(267, 299);
		txtInput.TabIndex = 50;
		txtInput.Text = "";
		txtInput.WordWrap = false;
		txtInput.TextChanged += new System.EventHandler(F4B99182);
		CA93ABA1.BackColor = System.Drawing.Color.Green;
		CA93ABA1.Cursor = System.Windows.Forms.Cursors.Hand;
		CA93ABA1.FlatAppearance.BorderSize = 0;
		CA93ABA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CA93ABA1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CA93ABA1.ForeColor = System.Drawing.Color.White;
		CA93ABA1.Location = new System.Drawing.Point(294, 49);
		CA93ABA1.Name = "btnAdd";
		CA93ABA1.Size = new System.Drawing.Size(135, 36);
		CA93ABA1.TabIndex = 45;
		CA93ABA1.Text = "Check";
		CA93ABA1.UseVisualStyleBackColor = false;
		CA93ABA1.Click += new System.EventHandler(CA93ABA1_Click);
		bunifuCards2.BackColor = System.Drawing.Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new System.Drawing.Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new System.Drawing.Size(748, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(C7B74EA2);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(748, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = Resource.Bitmap_9;
		button2.Location = new System.Drawing.Point(717, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = Resource.AC35C73C;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Location = new System.Drawing.Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		C7B74EA2.BackColor = System.Drawing.Color.Transparent;
		C7B74EA2.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C7B74EA2.Dock = System.Windows.Forms.DockStyle.Fill;
		C7B74EA2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C7B74EA2.ForeColor = System.Drawing.Color.Black;
		C7B74EA2.Location = new System.Drawing.Point(0, 0);
		C7B74EA2.Name = "lblTitle";
		C7B74EA2.Size = new System.Drawing.Size(748, 31);
		C7B74EA2.TabIndex = 12;
		C7B74EA2.Text = "Check Proxy";
		C7B74EA2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DA891393.Fixed = true;
		DA891393.Horizontal = true;
		DA891393.TargetControl = C7B74EA2;
		DA891393.Vertical = true;
		C2915E29.AutomaticDelay = 0;
		C2915E29.AutoPopDelay = 10000;
		C2915E29.InitialDelay = 200;
		C2915E29.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(750, 404);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchCheckProxy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(B5910715);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		C29AA9A6.ResumeLayout(false);
		D13DEDBF.ResumeLayout(false);
		BDBC1796.ResumeLayout(false);
		BDBC1796.PerformLayout();
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_3()
	{
		E1A32983.Visible = true;
	}

	[CompilerGenerated]
	private void method_4()
	{
		E1A32983.Visible = false;
	}
}
