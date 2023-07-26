using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCheckProxy : Form
{
	internal AC28BD29 ac28BD29_0;

	internal IContainer D522C08D = null;

	internal BunifuCards bunifuCards1;

	internal Panel pnlHeader;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Button btnMinimize;

	internal BunifuDragControl bunifuDragControl_0;

	internal PictureBox A11F482A;

	internal DataGridView dtgv;

	internal RichTextBox txtListProxy;

	internal Label FB04CAB0;

	internal Label A8B0D92F;

	internal DataGridViewTextBoxColumn F234D609;

	internal DataGridViewTextBoxColumn cProxy;

	internal DataGridViewTextBoxColumn CC21AE24;
    private IContainer components;
    internal DataGridViewTextBoxColumn cStt;
    internal DataGridViewTextBoxColumn cStatus;
    internal Button btnCheck;

	public fCheckProxy(AC28BD29 ac28BD29_1)
	{
		InitializeComponent();
		ac28BD29_0 = ac28BD29_1;
	}

	private void EFBD00A3(object sender, EventArgs e)
	{
		Close();
	}

	private void CA9D3A92(object sender, DataGridViewCellEventArgs e)
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

	private void CAA1DD96_CellClick(object sender, DataGridViewCellEventArgs e)
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

	private void CC1D8FB7(object sender, EventArgs e)
	{
		Common.D936DD84(txtListProxy, FB04CAB0);
	}

	private void btnCheck_Click(object sender, EventArgs e)
	{
		if (txtListProxy.Text.Trim() == "")
		{
			MessageBoxHelper.Show("Vui lòng nhập proxy trước!", 3);
			txtListProxy.Focus();
			return;
		}
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
				for (int j = 0; j < dtgv.RowCount; j++)
				{
					int row = j;
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						try
						{
							string string_ = dtgv.Rows[row].Cells["cProxy"].Value.ToString();
							ac28BD29_0.E0068C33(0, string_);
							string object_ = ac28BD29_0.BC0B8D27();
							DatagridviewHelper.AD3DF791(dtgv, row, "cStatus", object_);
						}
						catch
						{
						}
					});
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	protected override void Dispose(bool F939381C)
	{
		if (F939381C && D522C08D != null)
		{
			D522C08D.Dispose();
		}
		base.Dispose(F939381C);
	}

	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCheckProxy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.A11F482A = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.cStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtListProxy = new System.Windows.Forms.RichTextBox();
            this.FB04CAB0 = new System.Windows.Forms.Label();
            this.A8B0D92F = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.bunifuCards1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.A11F482A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 0;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SaddleBrown;
            this.bunifuCards1.Controls.Add(this.pnlHeader);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(530, 34);
            this.bunifuCards1.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.A11F482A);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.bunifuCustomLabel1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(530, 28);
            this.pnlHeader.TabIndex = 9;
            // 
            // A11F482A
            // 
            this.A11F482A.Cursor = System.Windows.Forms.Cursors.Default;
            this.A11F482A.Image = ((System.Drawing.Image)(resources.GetObject("A11F482A.Image")));
            this.A11F482A.Location = new System.Drawing.Point(3, 2);
            this.A11F482A.Name = "A11F482A";
            this.A11F482A.Size = new System.Drawing.Size(34, 27);
            this.A11F482A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.A11F482A.TabIndex = 17;
            this.A11F482A.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(498, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 28);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.EFBD00A3);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(530, 28);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Check Proxy";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl_0
            // 
            this.bunifuDragControl_0.Fixed = true;
            this.bunifuDragControl_0.Horizontal = true;
            this.bunifuDragControl_0.TargetControl = this.bunifuCustomLabel1;
            this.bunifuDragControl_0.Vertical = true;
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStt,
            this.cProxy,
            this.cStatus});
            this.dtgv.Location = new System.Drawing.Point(19, 288);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(499, 247);
            this.dtgv.TabIndex = 7;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CAA1DD96_CellClick);
            this.dtgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CA9D3A92);
            // 
            // cStt
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cStt.DefaultCellStyle = dataGridViewCellStyle2;
            this.cStt.HeaderText = "STT";
            this.cStt.Name = "cStt";
            this.cStt.ReadOnly = true;
            this.cStt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cStt.Width = 35;
            // 
            // cProxy
            // 
            this.cProxy.HeaderText = "Proxy";
            this.cProxy.Name = "cProxy";
            this.cProxy.ReadOnly = true;
            this.cProxy.Width = 90;
            // 
            // cStatus
            // 
            this.cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cStatus.HeaderText = "Status";
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            // 
            // txtListProxy
            // 
            this.txtListProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtListProxy.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.txtListProxy.Location = new System.Drawing.Point(15, 66);
            this.txtListProxy.Name = "txtListProxy";
            this.txtListProxy.Size = new System.Drawing.Size(499, 158);
            this.txtListProxy.TabIndex = 146;
            this.txtListProxy.Text = "";
            this.txtListProxy.WordWrap = false;
            this.txtListProxy.TextChanged += new System.EventHandler(this.CC1D8FB7);
            // 
            // FB04CAB0
            // 
            this.FB04CAB0.AutoSize = true;
            this.FB04CAB0.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FB04CAB0.Location = new System.Drawing.Point(12, 47);
            this.FB04CAB0.Name = "FB04CAB0";
            this.FB04CAB0.Size = new System.Drawing.Size(97, 16);
            this.FB04CAB0.TabIndex = 145;
            this.FB04CAB0.Text = "Nhập Proxy (0):";
            // 
            // A8B0D92F
            // 
            this.A8B0D92F.AutoSize = true;
            this.A8B0D92F.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.A8B0D92F.Location = new System.Drawing.Point(16, 269);
            this.A8B0D92F.Name = "A8B0D92F";
            this.A8B0D92F.Size = new System.Drawing.Size(55, 16);
            this.A8B0D92F.TabIndex = 145;
            this.A8B0D92F.Text = "Kết quả:";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Green;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(225, 233);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(82, 33);
            this.btnCheck.TabIndex = 147;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // fCheckProxy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(530, 547);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtListProxy);
            this.Controls.Add(this.A8B0D92F);
            this.Controls.Add(this.FB04CAB0);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.bunifuCards1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCheckProxy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAddFile";
            this.bunifuCards1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.A11F482A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	[CompilerGenerated]
	private void method_0()
	{
		try
		{
			for (int i = 0; i < dtgv.RowCount; i++)
			{
				int int_0 = i;
				Thread thread = new Thread((ThreadStart)delegate
				{
					try
					{
						string string_ = dtgv.Rows[int_0].Cells["cProxy"].Value.ToString();
						ac28BD29_0.E0068C33(0, string_);
						string object_ = ac28BD29_0.BC0B8D27();
						DatagridviewHelper.AD3DF791(dtgv, int_0, "cStatus", object_);
					}
					catch
					{
					}
				});
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
	}
}
