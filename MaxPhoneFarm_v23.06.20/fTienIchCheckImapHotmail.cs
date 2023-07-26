using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckImapHotmail : Form
{
	[CompilerGenerated]
	private sealed class Class82
	{
		internal int EC9EE493;

		internal fTienIchCheckImapHotmail CF139586;
	}

	[CompilerGenerated]
	private sealed class E48FBA3F
	{
		internal string string_0;

		internal Class82 E734F33B;

		internal void A932E936()
		{
			if (E734F33B.CF139586.AA8A041C(string_0))
			{
				E734F33B.CF139586.B002662B(E734F33B.CF139586.txtDaTao, string_0);
			}
			else
			{
				E734F33B.CF139586.B002662B(E734F33B.CF139586.AC19AEAF, string_0);
			}
			Interlocked.Decrement(ref E734F33B.EC9EE493);
		}
	}

	[CompilerGenerated]
	private sealed class Class83
	{
		internal RichTextBox richTextBox_0;

		internal string FA06DD36;

		internal void C31CE22C()
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + FA06DD36 + "\r\n";
		}
	}

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel panel1;

	internal BunifuDragControl bunifuDragControl_0;

	internal ToolTip A891DFA2;

	internal BunifuCards bunifuCards2;

	internal Panel pnlHeader;

	internal Button button2;

	internal PictureBox pictureBox1;

	internal Button BD15F301;

	internal BunifuCustomLabel lblTitle;

	internal Button btnAdd;

	internal RichTextBox txtInput;

	internal GroupBox grDaTao;

	internal RichTextBox txtDaTao;

	internal GroupBox groupBox1;

	internal Button btnNhapTuFile;

	internal TextBox E02BFA83;

	internal RadioButton rbTuNhap;

	internal RadioButton rbNhapTuFile;

	internal GroupBox grChuaTao;

	internal RichTextBox AC19AEAF;

	internal Label lblStatus;

	public fTienIchCheckImapHotmail()
	{
		InitializeComponent();
		Language.SetLanguage(this);
	}

	private void method_0()
	{
		Language.smethod_1(rbNhapTuFile);
		Language.smethod_1(btnNhapTuFile);
		Language.smethod_1(rbTuNhap);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			string text = E02BFA83.Text.Trim();
			if (rbNhapTuFile.Checked)
			{
				if (text.EndsWith(".txt"))
				{
					if (!File.Exists(text))
					{
						MessageBoxHelper.Show(Language.GetValue("File dữ liệu nhập không tồn tại!"), 2);
					}
				}
				else
				{
					MessageBoxHelper.Show(Language.GetValue("File nhập vào chỉ hỗ trợ đối với File (.txt)!"), 2);
				}
			}
			if (rbNhapTuFile.Checked)
			{
				list = File.ReadAllLines(text).ToList();
			}
			else if (rbTuNhap.Checked)
			{
				list = txtInput.Lines.ToList();
			}
			int EC9EE493 = 0;
			int num = 10;
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Visible = true;
			});
			int num2 = 0;
			while (num2 < list.Count)
			{
				if (EC9EE493 < num)
				{
					Interlocked.Increment(ref EC9EE493);
					string string_0 = list[num2++];
					Thread thread = new Thread((ThreadStart)delegate
					{
						if (AA8A041C(string_0))
						{
							B002662B(txtDaTao, string_0);
						}
						else
						{
							B002662B(AC19AEAF, string_0);
						}
						Interlocked.Decrement(ref EC9EE493);
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
			while (EC9EE493 > 0)
			{
				Common.DelayTime(1.0);
			}
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Visible = false;
			});
			MessageBoxHelper.Show(Language.GetValue("Đã check xong!"));
		}
		catch (Exception)
		{
			MessageBoxHelper.Show(Language.GetValue("Đã có lỗi xảy ra, vui lòng thử lại sau!"), 2);
		}
	}

	private void B002662B(RichTextBox richTextBox_0, string string_0)
	{
		richTextBox_0.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
		});
	}

	private bool AA8A041C(string string_0)
	{
		try
		{
			string[] array = string_0.Split('|');
			string text = array[0];
			string text2 = array[1];
			if (text == "" || text2 == "")
			{
				return false;
			}
			return ImapHelper.CheckConnectImap(text, text2);
		}
		catch
		{
		}
		return false;
	}

	private void txtInput_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtInput, rbTuNhap);
	}

	private void E63AD12C(object sender, EventArgs e)
	{
		E02BFA83.Enabled = rbNhapTuFile.Checked;
		btnNhapTuFile.Enabled = rbNhapTuFile.Checked;
	}

	private void rbTuNhap_CheckedChanged(object sender, EventArgs e)
	{
		txtInput.Enabled = rbTuNhap.Checked;
	}

	private void btnNhapTuFile_Click(object sender, EventArgs e)
	{
		E02BFA83.Text = Common.smethod_23();
	}

	private void B420B6B4(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txtDaTao.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			grDaTao.Text = string.Format(Language.GetValue("Live ({0})"), f1808BA.Count.ToString());
		}
		catch
		{
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchCheckImapHotmail_Load(object sender, EventArgs e)
	{
		E63AD12C(null, null);
		rbTuNhap_CheckedChanged(null, null);
	}

	private void AC19AEAF_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = AC19AEAF.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			grChuaTao.Text = string.Format(Language.GetValue("Die ({0})"), f1808BA.Count.ToString());
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
		lblStatus = new System.Windows.Forms.Label();
		grChuaTao = new System.Windows.Forms.GroupBox();
		AC19AEAF = new System.Windows.Forms.RichTextBox();
		grDaTao = new System.Windows.Forms.GroupBox();
		txtDaTao = new System.Windows.Forms.RichTextBox();
		groupBox1 = new System.Windows.Forms.GroupBox();
		btnNhapTuFile = new System.Windows.Forms.Button();
		txtInput = new System.Windows.Forms.RichTextBox();
		E02BFA83 = new System.Windows.Forms.TextBox();
		rbTuNhap = new System.Windows.Forms.RadioButton();
		rbNhapTuFile = new System.Windows.Forms.RadioButton();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		BD15F301 = new System.Windows.Forms.Button();
		lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		A891DFA2 = new System.Windows.Forms.ToolTip(icontainer_0);
		panel1.SuspendLayout();
		grChuaTao.SuspendLayout();
		grDaTao.SuspendLayout();
		groupBox1.SuspendLayout();
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
		bunifuCards1.Size = new System.Drawing.Size(466, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(grChuaTao);
		panel1.Controls.Add(grDaTao);
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(795, 404);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		lblStatus.AutoSize = true;
		lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
		lblStatus.Location = new System.Drawing.Point(480, 59);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(71, 16);
		lblStatus.TabIndex = 52;
		lblStatus.Text = "Checking...";
		lblStatus.Visible = false;
		grChuaTao.Controls.Add(AC19AEAF);
		grChuaTao.ForeColor = System.Drawing.Color.DarkRed;
		grChuaTao.Location = new System.Drawing.Point(566, 91);
		grChuaTao.Name = "grChuaTao";
		grChuaTao.Size = new System.Drawing.Size(221, 307);
		grChuaTao.TabIndex = 51;
		grChuaTao.TabStop = false;
		grChuaTao.Text = "Die (0)";
		AC19AEAF.Dock = System.Windows.Forms.DockStyle.Fill;
		AC19AEAF.Location = new System.Drawing.Point(3, 19);
		AC19AEAF.Name = "txtChuaTao";
		AC19AEAF.Size = new System.Drawing.Size(215, 285);
		AC19AEAF.TabIndex = 50;
		AC19AEAF.Text = "";
		AC19AEAF.WordWrap = false;
		AC19AEAF.TextChanged += new System.EventHandler(AC19AEAF_TextChanged);
		grDaTao.Controls.Add(txtDaTao);
		grDaTao.ForeColor = System.Drawing.Color.DarkGreen;
		grDaTao.Location = new System.Drawing.Point(339, 91);
		grDaTao.Name = "grDaTao";
		grDaTao.Size = new System.Drawing.Size(221, 307);
		grDaTao.TabIndex = 51;
		grDaTao.TabStop = false;
		grDaTao.Text = "Live (0)";
		txtDaTao.Dock = System.Windows.Forms.DockStyle.Fill;
		txtDaTao.Location = new System.Drawing.Point(3, 19);
		txtDaTao.Name = "txtDaTao";
		txtDaTao.Size = new System.Drawing.Size(215, 285);
		txtDaTao.TabIndex = 50;
		txtDaTao.Text = "";
		txtDaTao.WordWrap = false;
		txtDaTao.TextChanged += new System.EventHandler(B420B6B4);
		groupBox1.Controls.Add(btnNhapTuFile);
		groupBox1.Controls.Add(txtInput);
		groupBox1.Controls.Add(E02BFA83);
		groupBox1.Controls.Add(rbTuNhap);
		groupBox1.Controls.Add(rbNhapTuFile);
		groupBox1.Location = new System.Drawing.Point(6, 40);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(316, 358);
		groupBox1.TabIndex = 51;
		groupBox1.TabStop = false;
		groupBox1.Text = "Input: Email|Pass mail";
		btnNhapTuFile.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapTuFile.Location = new System.Drawing.Point(243, 22);
		btnNhapTuFile.Name = "btnNhapTuFile";
		btnNhapTuFile.Size = new System.Drawing.Size(64, 24);
		btnNhapTuFile.TabIndex = 2;
		btnNhapTuFile.Text = "Chọn";
		btnNhapTuFile.Click += new System.EventHandler(btnNhapTuFile_Click);
		txtInput.Location = new System.Drawing.Point(30, 75);
		txtInput.Name = "txtInput";
		txtInput.Size = new System.Drawing.Size(277, 277);
		txtInput.TabIndex = 50;
		txtInput.Text = "";
		txtInput.WordWrap = false;
		txtInput.TextChanged += new System.EventHandler(txtInput_TextChanged);
		E02BFA83.Location = new System.Drawing.Point(110, 22);
		E02BFA83.Name = "txtNhapTuFile";
		E02BFA83.Size = new System.Drawing.Size(127, 23);
		E02BFA83.TabIndex = 1;
		rbTuNhap.AutoSize = true;
		rbTuNhap.Checked = true;
		rbTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		rbTuNhap.Location = new System.Drawing.Point(9, 49);
		rbTuNhap.Name = "rbTuNhap";
		rbTuNhap.Size = new System.Drawing.Size(95, 20);
		rbTuNhap.TabIndex = 0;
		rbTuNhap.TabStop = true;
		rbTuNhap.Text = "Tự nhập (0)";
		rbTuNhap.UseVisualStyleBackColor = true;
		rbTuNhap.CheckedChanged += new System.EventHandler(rbTuNhap_CheckedChanged);
		rbNhapTuFile.AutoSize = true;
		rbNhapTuFile.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNhapTuFile.Location = new System.Drawing.Point(9, 23);
		rbNhapTuFile.Name = "rbNhapTuFile";
		rbNhapTuFile.Size = new System.Drawing.Size(95, 20);
		rbNhapTuFile.TabIndex = 0;
		rbNhapTuFile.Text = "Nhập từ File";
		rbNhapTuFile.UseVisualStyleBackColor = true;
		rbNhapTuFile.CheckedChanged += new System.EventHandler(E63AD12C);
		btnAdd.BackColor = System.Drawing.Color.Green;
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(339, 49);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(135, 36);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Check";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
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
		bunifuCards2.Size = new System.Drawing.Size(793, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(BD15F301);
		pnlHeader.Controls.Add(lblTitle);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(793, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = Resource.Bitmap_9;
		button2.Location = new System.Drawing.Point(762, 1);
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
		BD15F301.Cursor = System.Windows.Forms.Cursors.Hand;
		BD15F301.FlatAppearance.BorderSize = 0;
		BD15F301.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BD15F301.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		BD15F301.ForeColor = System.Drawing.Color.White;
		BD15F301.Location = new System.Drawing.Point(899, 1);
		BD15F301.Name = "btnMinimize";
		BD15F301.Size = new System.Drawing.Size(30, 30);
		BD15F301.TabIndex = 9;
		BD15F301.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		BD15F301.UseVisualStyleBackColor = true;
		lblTitle.BackColor = System.Drawing.Color.Transparent;
		lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
		lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
		lblTitle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblTitle.ForeColor = System.Drawing.Color.Black;
		lblTitle.Location = new System.Drawing.Point(0, 0);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new System.Drawing.Size(793, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Check Imap Hotmail, Yandex";
		lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = lblTitle;
		bunifuDragControl_0.Vertical = true;
		A891DFA2.AutomaticDelay = 0;
		A891DFA2.AutoPopDelay = 10000;
		A891DFA2.InitialDelay = 200;
		A891DFA2.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(795, 404);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchCheckImapHotmail";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fTienIchCheckImapHotmail_Load);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		grChuaTao.ResumeLayout(false);
		grDaTao.ResumeLayout(false);
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void A217FE0E()
	{
		lblStatus.Visible = true;
	}

	[CompilerGenerated]
	private void method_1()
	{
		lblStatus.Visible = false;
	}
}
