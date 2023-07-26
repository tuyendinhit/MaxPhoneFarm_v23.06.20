using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckStatusXProxy : Form
{
	[CompilerGenerated]
	private sealed class Class67
	{
		internal string F4848112;

		internal fTienIchCheckStatusXProxy E297A684;

		internal void method_0()
		{
			try
			{
				if (F4848112.StartsWith("http"))
				{
					for (int i = 0; i < E297A684.dtgv.RowCount; i++)
					{
						Thread thread = new Thread(new B29CE991
						{
							class67_0 = this,
							int_0 = i
						}.method_0);
						thread.IsBackground = true;
						thread.Start();
					}
				}
				else
				{
					for (int j = 0; j < E297A684.dtgv.RowCount; j++)
					{
						Thread thread2 = new Thread(new Class68
						{
							class67_0 = this,
							int_0 = j
						}.ED84BE3B);
						thread2.IsBackground = true;
						thread2.Start();
					}
				}
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class B29CE991
	{
		internal int int_0;

		internal Class67 class67_0;

		internal void method_0()
		{
			try
			{
				string text = class67_0.E297A684.dtgv.Rows[int_0].Cells["cProxy"].Value.ToString();
				string string_ = class67_0.F4848112 + "/status?proxy=" + text;
				string object_ = new RequestXNet("", "", "", 0).RequestGet(string_);
				DatagridviewHelper.AD3DF791(class67_0.E297A684.dtgv, int_0, "cStatus", object_);
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class68
	{
		internal int int_0;

		internal Class67 class67_0;

		internal void ED84BE3B()
		{
			try
			{
				string text = class67_0.E297A684.dtgv.Rows[int_0].Cells["cProxy"].Value.ToString();
				string string_ = "https://api.proxyv6.net/api/check-list-proxy?api_key=" + class67_0.F4848112;
				string text2 = text.Split(':')[2] + ":" + text.Split(':')[3] + "@" + text.Split(':')[0] + ":" + text.Split(':')[1];
				string string_2 = "{\"proxies\": [\"" + text2 + "\"]}";
				RequestXNet b01F5C = new RequestXNet("", "", "", 0);
				string object_ = b01F5C.method_1(string_, string_2, "application/json");
				DatagridviewHelper.AD3DF791(class67_0.E297A684.dtgv, int_0, "cStatus", object_);
			}
			catch
			{
			}
		}
	}

	internal bool bool_0 = false;

	internal static List<string> list_0;

	internal static List<string> list_1;

	internal static bool A71C46A0;

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal BunifuDragControl bunifuDragControl_0;

	internal PictureBox BEAA4234;

	internal DataGridView dtgv;

	internal RichTextBox txtListProxy;

	internal Label label17;

	internal Label label1;

	internal DataGridViewTextBoxColumn cStt;

	internal DataGridViewTextBoxColumn cProxy;

	internal DataGridViewTextBoxColumn cStatus;

	internal Button A53151A1;

	internal Label label2;

	internal TextBox txtUrl;

	public fTienIchCheckStatusXProxy(bool bool_1 = false)
	{
		InitializeComponent();
		A71C46A0 = false;
		bool_0 = bool_1;
		Language.SetLanguage(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0(object sender, EventArgs e)
	{
		A71C46A0 = true;
		if (bool_0)
		{
			list_1 = new List<string>();
			for (int i = 0; i < dtgv.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgv.Rows[i].Cells["cChose"].Value))
				{
					list_1.Add(DatagridviewHelper.E83E252C(dtgv, i, "cId"));
				}
			}
			if (list_1.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		else
		{
			list_0 = new List<string>();
			for (int j = 0; j < dtgv.Rows.Count; j++)
			{
				if (Convert.ToBoolean(dtgv.Rows[j].Cells["cChose"].Value))
				{
					list_0.Add(DatagridviewHelper.E83E252C(dtgv, j, "cId"));
				}
			}
			if (list_0.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng chọn ít nhất 1 thư mục!"), 2);
				return;
			}
		}
		Close();
	}

	private void CE0680B8(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (Convert.ToBoolean(dtgv.CurrentRow.Cells["cChose"].Value))
			{
				dtgv.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				dtgv.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private int method_1()
	{
		int num = 0;
		for (int i = 0; i < dtgv.Rows.Count; i++)
		{
			if (Convert.ToBoolean(dtgv.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		return num;
	}

	private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex != 0)
		{
			return;
		}
		try
		{
			if (Convert.ToBoolean(dtgv.CurrentRow.Cells["cChose"].Value))
			{
				dtgv.CurrentRow.Cells["cChose"].Value = false;
			}
			else
			{
				dtgv.CurrentRow.Cells["cChose"].Value = true;
			}
		}
		catch
		{
		}
	}

	private void txtListProxy_TextChanged(object sender, EventArgs e)
	{
		Common.D936DD84(txtListProxy, label17);
	}

	private void A53151A1_Click(object sender, EventArgs e)
	{
		if (txtUrl.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập URL trước!", 3);
			txtUrl.Focus();
			return;
		}
		if (txtListProxy.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập proxy trước!", 3);
			txtListProxy.Focus();
			return;
		}
		string F4848112 = txtUrl.Text.Trim().TrimEnd('/');
		List<string> f1808BA = txtListProxy.Lines.ToList();
		f1808BA = Common.RemoveEmptyItems(f1808BA);
		dtgv.Rows.Clear();
		for (int i = 0; i < f1808BA.Count; i++)
		{
			dtgv.Rows.Add(i + 1, f1808BA[i], "Đang check...");
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				if (F4848112.StartsWith("http"))
				{
					for (int j = 0; j < dtgv.RowCount; j++)
					{
						int int_ = j;
						Thread thread2 = new Thread((ThreadStart)delegate
						{
							try
							{
								string text3 = dtgv.Rows[int_].Cells["cProxy"].Value.ToString();
								string string_3 = F4848112 + "/status?proxy=" + text3;
								string object_2 = new RequestXNet("", "", "", 0).RequestGet(string_3);
								DatagridviewHelper.AD3DF791(dtgv, int_, "cStatus", object_2);
							}
							catch
							{
							}
						});
						thread2.IsBackground = true;
						thread2.Start();
					}
				}
				else
				{
					for (int k = 0; k < dtgv.RowCount; k++)
					{
						int int_0 = k;
						Thread thread3 = new Thread((ThreadStart)delegate
						{
							try
							{
								string text = dtgv.Rows[int_0].Cells["cProxy"].Value.ToString();
								string string_ = "https://api.proxyv6.net/api/check-list-proxy?api_key=" + F4848112;
								string text2 = text.Split(':')[2] + ":" + text.Split(':')[3] + "@" + text.Split(':')[0] + ":" + text.Split(':')[1];
								string string_2 = "{\"proxies\": [\"" + text2 + "\"]}";
								RequestXNet b01F5C = new RequestXNet("", "", "", 0);
								string object_ = b01F5C.method_1(string_, string_2, "application/json");
								DatagridviewHelper.AD3DF791(dtgv, int_0, "cStatus", object_);
							}
							catch
							{
							}
						});
						thread3.IsBackground = true;
						thread3.Start();
					}
				}
			}
			catch
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	protected override void Dispose(bool E013DE36)
	{
		if (E013DE36 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(E013DE36);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTienIchCheckStatusXProxy));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		BEAA4234 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		dtgv = new System.Windows.Forms.DataGridView();
		cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		txtListProxy = new System.Windows.Forms.RichTextBox();
		label17 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		A53151A1 = new System.Windows.Forms.Button();
		label2 = new System.Windows.Forms.Label();
		txtUrl = new System.Windows.Forms.TextBox();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)BEAA4234).BeginInit();
		((System.ComponentModel.ISupportInitialize)dtgv).BeginInit();
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
		bunifuCards1.Size = new System.Drawing.Size(530, 34);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(BEAA4234);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(530, 28);
		pnlHeader.TabIndex = 9;
		BEAA4234.Cursor = System.Windows.Forms.Cursors.Default;
		BEAA4234.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		BEAA4234.Location = new System.Drawing.Point(3, 2);
		BEAA4234.Name = "pictureBox1";
		BEAA4234.Size = new System.Drawing.Size(34, 27);
		BEAA4234.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		BEAA4234.TabIndex = 17;
		BEAA4234.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(498, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 28);
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(530, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Check status XProxy";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		dtgv.AllowUserToAddRows = false;
		dtgv.AllowUserToDeleteRows = false;
		dtgv.AllowUserToResizeRows = false;
		dtgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgv.Columns.AddRange(cStt, cProxy, cStatus);
		dtgv.Location = new System.Drawing.Point(15, 318);
		dtgv.Name = "dtgv";
		dtgv.ReadOnly = true;
		dtgv.RowHeadersVisible = false;
		dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dtgv.Size = new System.Drawing.Size(499, 211);
		dtgv.TabIndex = 7;
		dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgv_CellClick);
		dtgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(CE0680B8);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		cStt.DefaultCellStyle = dataGridViewCellStyle2;
		cStt.HeaderText = "STT";
		cStt.Name = "cStt";
		cStt.ReadOnly = true;
		cStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		cStt.Width = 35;
		cProxy.HeaderText = "Proxy";
		cProxy.Name = "cProxy";
		cProxy.ReadOnly = true;
		cProxy.Width = 90;
		cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cStatus.HeaderText = "Status";
		cStatus.Name = "cStatus";
		cStatus.ReadOnly = true;
		txtListProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtListProxy.Font = new System.Drawing.Font("Tahoma", 9.75f);
		txtListProxy.Location = new System.Drawing.Point(15, 92);
		txtListProxy.Name = "txtListProxy";
		txtListProxy.Size = new System.Drawing.Size(499, 158);
		txtListProxy.TabIndex = 146;
		txtListProxy.Text = "";
		txtListProxy.WordWrap = false;
		txtListProxy.TextChanged += new System.EventHandler(txtListProxy_TextChanged);
		label17.AutoSize = true;
		label17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label17.Location = new System.Drawing.Point(12, 73);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(97, 16);
		label17.TabIndex = 145;
		label17.Text = "Nhập Proxy (0):";
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label1.Location = new System.Drawing.Point(12, 299);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(55, 16);
		label1.TabIndex = 145;
		label1.Text = "Kết quả:";
		A53151A1.BackColor = System.Drawing.Color.Green;
		A53151A1.Cursor = System.Windows.Forms.Cursors.Hand;
		A53151A1.FlatAppearance.BorderSize = 0;
		A53151A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A53151A1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A53151A1.ForeColor = System.Drawing.Color.White;
		A53151A1.Location = new System.Drawing.Point(223, 261);
		A53151A1.Name = "btnCheck";
		A53151A1.Size = new System.Drawing.Size(82, 33);
		A53151A1.TabIndex = 147;
		A53151A1.Text = "Check";
		A53151A1.UseVisualStyleBackColor = false;
		A53151A1.Click += new System.EventHandler(A53151A1_Click);
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label2.Location = new System.Drawing.Point(12, 48);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(34, 16);
		label2.TabIndex = 145;
		label2.Text = "URL:";
		txtUrl.Font = new System.Drawing.Font("Tahoma", 9.75f);
		txtUrl.Location = new System.Drawing.Point(53, 47);
		txtUrl.Name = "txtUrl";
		txtUrl.Size = new System.Drawing.Size(461, 23);
		txtUrl.TabIndex = 148;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(530, 547);
		base.Controls.Add(txtUrl);
		base.Controls.Add(A53151A1);
		base.Controls.Add(txtListProxy);
		base.Controls.Add(label2);
		base.Controls.Add(label1);
		base.Controls.Add(label17);
		base.Controls.Add(dtgv);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fTienIchCheckStatusXProxy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)BEAA4234).EndInit();
		((System.ComponentModel.ISupportInitialize)dtgv).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
