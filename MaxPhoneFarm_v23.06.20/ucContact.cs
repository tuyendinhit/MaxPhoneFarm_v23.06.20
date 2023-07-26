using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class ucContact : UserControl
{
	internal IContainer A0B9D883 = null;

	internal Label label12;

	internal Label label3;

	internal Panel panel2;

	internal LinkLabel linkLabel1;

	internal LinkLabel DDA40EA3;

	internal Label label4;

	internal Label DE8E1B88;

	internal Label label6;

	internal Label F900DC9C;

	internal PictureBox pictureBox2;

	internal PictureBox pictureBox1;

	internal Label F233D309;

	internal PictureBox pictureBox3;

	internal Label EAA065A0;

	internal Label CC938C3F;

	internal Label C3AC72B8;

	internal Label CD09A10F;

	public ucContact()
	{
		InitializeComponent();
	}

	private void DDA40EA3_Click(object sender, EventArgs e)
	{
		string text = (sender as LinkLabel).Text;
		try
		{
			Process.Start("chrome.exe", text);
		}
		catch
		{
			Process.Start(text);
		}
	}

	protected override void Dispose(bool CA1BA01F)
	{
		if (CA1BA01F && A0B9D883 != null)
		{
			A0B9D883.Dispose();
		}
		base.Dispose(CA1BA01F);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucContact));
		label12 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		panel2 = new System.Windows.Forms.Panel();
		pictureBox3 = new System.Windows.Forms.PictureBox();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		DDA40EA3 = new System.Windows.Forms.LinkLabel();
		label4 = new System.Windows.Forms.Label();
		EAA065A0 = new System.Windows.Forms.Label();
		CC938C3F = new System.Windows.Forms.Label();
		DE8E1B88 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		C3AC72B8 = new System.Windows.Forms.Label();
		CD09A10F = new System.Windows.Forms.Label();
		F900DC9C = new System.Windows.Forms.Label();
		F233D309 = new System.Windows.Forms.Label();
		pictureBox2 = new System.Windows.Forms.PictureBox();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
		((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		label12.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label12.ForeColor = System.Drawing.Color.Red;
		label12.Location = new System.Drawing.Point(214, 357);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(489, 110);
		label12.TabIndex = 28;
		label12.Text = "Chú ý: Nghiêm cấm sử dụng phần mềm vào các mục đích xấu, vi phạm pháp luật. Nếu cố tình sẽ bị xóa khỏi hệ thống vĩnh viễn, và phải chịu hoàn toàn trách nhiệm trước pháp luật.";
		label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label3.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		label3.Location = new System.Drawing.Point(209, 172);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(164, 25);
		label3.TabIndex = 27;
		label3.Text = "Hỗ trợ phần mềm:";
		panel2.BackColor = System.Drawing.Color.WhiteSmoke;
		panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel2.Controls.Add(pictureBox3);
		panel2.Controls.Add(linkLabel1);
		panel2.Controls.Add(DDA40EA3);
		panel2.Controls.Add(label4);
		panel2.Controls.Add(EAA065A0);
		panel2.Controls.Add(CC938C3F);
		panel2.Controls.Add(DE8E1B88);
		panel2.Controls.Add(label6);
		panel2.Controls.Add(C3AC72B8);
		panel2.Controls.Add(CD09A10F);
		panel2.Controls.Add(F900DC9C);
		panel2.Location = new System.Drawing.Point(214, 198);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(489, 146);
		panel2.TabIndex = 25;
		pictureBox3.Image = Resource.B4A3BF17;
		pictureBox3.Location = new System.Drawing.Point(340, -3);
		pictureBox3.Name = "pictureBox3";
		pictureBox3.Size = new System.Drawing.Size(150, 150);
		pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		pictureBox3.TabIndex = 10;
		pictureBox3.TabStop = false;
		linkLabel1.AutoSize = true;
		linkLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		linkLabel1.Location = new System.Drawing.Point(94, 4);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(247, 25);
		linkLabel1.TabIndex = 9;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "https://maxphonefarm.com/";
		linkLabel1.Click += new System.EventHandler(DDA40EA3_Click);
		DDA40EA3.AutoSize = true;
		DDA40EA3.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DDA40EA3.Location = new System.Drawing.Point(94, 33);
		DDA40EA3.Name = "linkLabel2";
		DDA40EA3.Size = new System.Drawing.Size(242, 25);
		DDA40EA3.TabIndex = 9;
		DDA40EA3.TabStop = true;
		DDA40EA3.Text = "http://bit.ly/MaxPhoneFarm";
		DDA40EA3.Click += new System.EventHandler(DDA40EA3_Click);
		label4.AutoSize = true;
		label4.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label4.ForeColor = System.Drawing.Color.Black;
		label4.Location = new System.Drawing.Point(3, 4);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(83, 25);
		label4.TabIndex = 2;
		label4.Text = "Website:";
		EAA065A0.AutoSize = true;
		EAA065A0.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EAA065A0.ForeColor = System.Drawing.Color.Black;
		EAA065A0.Location = new System.Drawing.Point(4, 118);
		EAA065A0.Name = "label9";
		EAA065A0.Size = new System.Drawing.Size(95, 25);
		EAA065A0.TabIndex = 2;
		EAA065A0.Text = "Khiếu nại:";
		CC938C3F.AutoSize = true;
		CC938C3F.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CC938C3F.ForeColor = System.Drawing.Color.Black;
		CC938C3F.Location = new System.Drawing.Point(3, 91);
		CC938C3F.Name = "label7";
		CC938C3F.Size = new System.Drawing.Size(62, 25);
		CC938C3F.TabIndex = 2;
		CC938C3F.Text = "CSKH:";
		DE8E1B88.AutoSize = true;
		DE8E1B88.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DE8E1B88.ForeColor = System.Drawing.Color.Black;
		DE8E1B88.Location = new System.Drawing.Point(3, 64);
		DE8E1B88.Name = "label5";
		DE8E1B88.Size = new System.Drawing.Size(77, 25);
		DE8E1B88.TabIndex = 2;
		DE8E1B88.Text = "Hotline:";
		label6.AutoSize = true;
		label6.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label6.ForeColor = System.Drawing.Color.Black;
		label6.Location = new System.Drawing.Point(3, 33);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(87, 25);
		label6.TabIndex = 2;
		label6.Text = "Fanpage:";
		C3AC72B8.AutoSize = true;
		C3AC72B8.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C3AC72B8.ForeColor = System.Drawing.Color.Black;
		C3AC72B8.Location = new System.Drawing.Point(94, 118);
		C3AC72B8.Name = "label8";
		C3AC72B8.Size = new System.Drawing.Size(120, 25);
		C3AC72B8.TabIndex = 2;
		C3AC72B8.Text = "0358.394.040";
		CD09A10F.AutoSize = true;
		CD09A10F.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CD09A10F.ForeColor = System.Drawing.Color.Black;
		CD09A10F.Location = new System.Drawing.Point(94, 91);
		CD09A10F.Name = "label2";
		CD09A10F.Size = new System.Drawing.Size(120, 25);
		CD09A10F.TabIndex = 2;
		CD09A10F.Text = "0966.260.829";
		F900DC9C.AutoSize = true;
		F900DC9C.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F900DC9C.ForeColor = System.Drawing.Color.Black;
		F900DC9C.Location = new System.Drawing.Point(94, 64);
		F900DC9C.Name = "label11";
		F900DC9C.Size = new System.Drawing.Size(246, 25);
		F900DC9C.TabIndex = 2;
		F900DC9C.Text = "0975.337.854 - 085.226.1234";
		F233D309.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F233D309.Location = new System.Drawing.Point(33, 143);
		F233D309.Name = "label1";
		F233D309.Size = new System.Drawing.Size(653, 21);
		F233D309.TabIndex = 21;
		F233D309.Text = "PHẦN MỀM HỖ TRỢ KINH DOANH ONLINE - TỰ ĐỘNG HÓA MỌI THAO TÁC CỦA BẠN";
		F233D309.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		pictureBox2.Image = Resource.Bitmap_1;
		pictureBox2.Location = new System.Drawing.Point(-17, 172);
		pictureBox2.Name = "pictureBox2";
		pictureBox2.Size = new System.Drawing.Size(230, 295);
		pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox2.TabIndex = 23;
		pictureBox2.TabStop = false;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(66, 3);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(620, 130);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		pictureBox1.TabIndex = 22;
		pictureBox1.TabStop = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.Controls.Add(label12);
		base.Controls.Add(label3);
		base.Controls.Add(panel2);
		base.Controls.Add(pictureBox2);
		base.Controls.Add(pictureBox1);
		base.Controls.Add(F233D309);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "ucContact";
		base.Size = new System.Drawing.Size(714, 472);
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
		((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
