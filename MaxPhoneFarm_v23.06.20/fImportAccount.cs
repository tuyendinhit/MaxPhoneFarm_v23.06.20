using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fImportAccount : Form
{
	[CompilerGenerated]
	private sealed class Class46
	{
		internal bool bool_0;

		internal int int_0;

		internal string string_0;

		internal List<string> CFB6631B;

		internal fImportAccount fImportAccount_0;

		internal void method_0()
		{
			try
			{
				fImportAccount_0.btnAdd.Invoke((MethodInvoker)delegate
				{
					fImportAccount_0.btnAdd.Enabled = false;
				});
				fImportAccount_0.method_2(Language.GetValue("Chuẩn bị thêm tài khoản..."), fImportAccount_0.lblStatus);
				if (bool_0)
				{
					int num = 0;
					while (num < fImportAccount_0.list_0.Count)
					{
						if (fImportAccount_0.list_1.Count < int_0)
						{
							Class47 CS_0024_003C_003E8__locals0 = new Class47
							{
								class46_0 = this,
								int_0 = num++
							};
							fImportAccount_0.method_2($"Check info {CS_0024_003C_003E8__locals0.int_0 + 1}/{fImportAccount_0.list_0.Count}...", fImportAccount_0.lblStatus);
							Thread thread = new Thread((ThreadStart)delegate
							{
								try
								{
									string text3 = CS_0024_003C_003E8__locals0.class46_0.fImportAccount_0.list_0[CS_0024_003C_003E8__locals0.int_0];
									if (text3 != "")
									{
										string text4 = CS_0024_003C_003E8__locals0.class46_0.fImportAccount_0.EF94CE9D(CS_0024_003C_003E8__locals0.class46_0.string_0, text3, CS_0024_003C_003E8__locals0.class46_0.bool_0);
										if (text4 != "")
										{
											lock (CS_0024_003C_003E8__locals0.class46_0.CFB6631B)
											{
												CS_0024_003C_003E8__locals0.class46_0.CFB6631B.Add(text4);
											}
										}
									}
								}
								catch (Exception)
								{
								}
							});
							fImportAccount_0.list_1.Add(thread);
							thread.Start();
							continue;
						}
						for (int i = 0; i < fImportAccount_0.list_1.Count; i++)
						{
							if (!fImportAccount_0.list_1[i].IsAlive)
							{
								fImportAccount_0.list_1.RemoveAt(i--);
							}
						}
					}
					for (int j = 0; j < fImportAccount_0.list_1.Count; j++)
					{
						fImportAccount_0.list_1[j].Join();
					}
				}
				else
				{
					for (int k = 0; k < fImportAccount_0.list_0.Count; k++)
					{
						try
						{
							string text = fImportAccount_0.list_0[k];
							if (text != "")
							{
								string text2 = fImportAccount_0.EF94CE9D(string_0, text, bool_0);
								if (text2 != "")
								{
									CFB6631B.Add(text2);
								}
							}
						}
						catch
						{
						}
					}
				}
				fImportAccount_0.method_2(Language.GetValue("Đang thêm tài khoản..."), fImportAccount_0.lblStatus);
				if (CFB6631B.Count >= 0)
				{
					CFB6631B = CommonSQL.smethod_7(CFB6631B);
					for (int l = 0; l < CFB6631B.Count; l++)
					{
						fImportAccount_0.method_3(fImportAccount_0.lblSuccess, Connector.GClass8_0.A1A9B8A2(CFB6631B[l]));
					}
				}
				fImportAccount_0.method_2((Convert.ToInt32(fImportAccount_0.F1ADA699.Text) - Convert.ToInt32(fImportAccount_0.lblSuccess.Text)).ToString() ?? "", fImportAccount_0.lblError);
				fImportAccount_0.btnAdd.Invoke((MethodInvoker)delegate
				{
					fImportAccount_0.btnAdd.Enabled = true;
				});
				fImportAccount_0.method_2(Language.GetValue("Thêm tài khoản thành công!"), fImportAccount_0.lblStatus);
				MessageBoxHelper.Show("Thêm tài khoản thành công!");
				fImportAccount_0.bool_0 = true;
				fImportAccount_0.int_0 = Convert.ToInt32(string_0);
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_, "AddAccount");
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class47
	{
		internal int int_0;

		internal Class46 class46_0;

		internal void method_0()
		{
			try
			{
				string text = class46_0.fImportAccount_0.list_0[int_0];
				if (!(text != ""))
				{
					return;
				}
				string text2 = class46_0.fImportAccount_0.EF94CE9D(class46_0.string_0, text, class46_0.bool_0);
				if (text2 != "")
				{
					lock (class46_0.CFB6631B)
					{
						class46_0.CFB6631B.Add(text2);
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class48
	{
		internal Label E6B91914;

		internal string FA1A95A9;

		internal void C92876BA()
		{
			Application.DoEvents();
			E6B91914.Text = FA1A95A9;
		}
	}

	[CompilerGenerated]
	private sealed class Class49
	{
		internal Label label_0;

		internal int D8984B1A;

		internal void F9A42995()
		{
			Application.DoEvents();
			label_0.Text = (Convert.ToInt32(label_0.Text) + ((D8984B1A == -1) ? 1 : D8984B1A)).ToString();
		}

		internal void method_0()
		{
			Application.DoEvents();
			label_0.Text = (Convert.ToInt32(label_0.Text) + D8984B1A).ToString();
		}
	}

	internal bool bool_0 = false;

	internal int int_0 = -1;

	internal bool bool_1 = false;

	internal List<ComboBox> E28FDE20;

	internal int int_1 = 0;

	internal List<string> list_0 = new List<string>();

	internal List<Thread> list_1 = null;

	internal object A08518BE = new object();

	internal List<string> list_2 = new List<string>();

	internal string string_0 = FileHelper.GetPathToCurrentFolder() + "\\settings\\inputformat.txt";

	internal IContainer icontainer_0 = null;

	internal BunifuCards bunifuCards1;

	internal Button btnAdd;

	internal Button btnCancel;

	internal Label lblSuccess;

	internal Label lblError;

	internal Label F1ADA699;

	internal Label A130B90F;

	internal Label label4;

	internal Label E2961306;

	internal Label lblStatus;

	internal Label B9B3B29A;

	internal ComboBox E99C6E0D;

	internal ComboBox cbbDinhDang1;

	internal Label DE01B417;

	internal ComboBox E8A334A3;

	internal Label label10;

	internal ComboBox cbbDinhDang3;

	internal Label EEB71809;

	internal ComboBox cbbDinhDang4;

	internal Label label12;

	internal ComboBox ED0C013E;

	internal Label DC9393BB;

	internal ComboBox cbbDinhDang6;

	internal Label BBA5A390;

	internal ComboBox B918B638;

	internal BunifuDragControl bunifuDragControl_0;

	internal BunifuDragControl A8AA8EBF;

	internal Panel plDinhDangNhap;

	internal PictureBox CA9B04B4;

	internal Label label16;

	internal ComboBox A10A3B03;

	internal Button DF1474A4;

	internal RichTextBox txbAccount;

	internal Label label18;

	internal Label label17;

	internal ComboBox AAA72B2D;

	internal ComboBox BB3D19BA;

	internal Button BE9FE310;

	internal Button button3;

	internal Label label19;

	internal Label label1;

	internal ComboBox cbbDinhDang10;

	internal ComboBox cbbDinhDang11;

	internal Panel pnlHeader;

	internal Button btnMinimize;

	internal BunifuCustomLabel bunifuCustomLabel1;

	internal Panel panel1;

	internal CheckBox ckbCheckThongTin;

	public fImportAccount(string string_1)
	{
		InitializeComponent();
		Language.SetLanguage(this);
		method_1();
		if (string_1 != "" && string_1 != "-1" && string_1 != "999999")
		{
			A10A3B03.SelectedValue = string_1;
		}
		E99C6E0D.SelectedIndex = 0;
		bool_1 = false;
		bool_0 = false;
		int_0 = -1;
		method_0();
	}

	private void method_0()
	{
		E28FDE20 = new List<ComboBox>
		{
			cbbDinhDang1, E8A334A3, cbbDinhDang3, cbbDinhDang4, ED0C013E, cbbDinhDang6, B918B638, AAA72B2D, BB3D19BA, cbbDinhDang10,
			cbbDinhDang11
		};
		foreach (ComboBox item in E28FDE20)
		{
			Common.BEBCBE97(item, new List<string>
			{
				"", "Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy",
				"Birthday", "Bạn bè", "Ngày tạo", "Mail khôi phục"
			});
			item.SelectedIndex = -1;
			item.DropDownWidth = 100;
		}
	}

	private void method_1()
	{
		int_1 = A10A3B03.SelectedIndex;
		DataTable dataTable = CommonSQL.smethod_0();
		if (dataTable.Rows.Count > 0)
		{
			A10A3B03.DataSource = dataTable;
			A10A3B03.ValueMember = "id";
			A10A3B03.DisplayMember = "name";
			if (int_1 == -1)
			{
				int_1 = 0;
			}
			A10A3B03.SelectedIndex = int_1;
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F527D197(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txbAccount.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			if (f1808BA.Count == 0)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng nhâ\u0323p thông tin ta\u0300i khoa\u0309n!"), 3);
				txbAccount.Focus();
				return;
			}
			if (A10A3B03.SelectedValue == null)
			{
				MessageBoxHelper.Show(Language.GetValue("Vui lòng cho\u0323n thư mu\u0323c!"), 3);
				return;
			}
			string string_0 = A10A3B03.SelectedValue.ToString();
			bool bool_0 = ckbCheckThongTin.Checked;
			string text = E99C6E0D.Text;
			int selectedIndex = E99C6E0D.SelectedIndex;
			if (selectedIndex != E99C6E0D.Items.Count - 1)
			{
				goto IL_0174;
			}
			bool flag = false;
			for (int i = 0; i < E28FDE20.Count; i++)
			{
				if (E28FDE20[i].SelectedIndex > 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				MessageBoxHelper.Show("Vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng ta\u0300i khoa\u0309n!", 3);
				return;
			}
			text = "";
			for (int j = 0; j < E28FDE20.Count; j++)
			{
				text = text + E28FDE20[j].Text + "|";
			}
			text = text.TrimEnd('|');
			goto IL_0174;
			IL_0174:
			if (text == "")
			{
				MessageBoxHelper.Show("Vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng ta\u0300i khoa\u0309n!");
				return;
			}
			int int_0 = 100;
			if (f1808BA.Count < 100)
			{
				int_0 = f1808BA.Count;
			}
			lblSuccess.Text = "0";
			lblError.Text = "0";
			list_0 = new List<string>();
			List<string> list = text.Split('|').ToList();
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			string text7 = "";
			string text8 = "";
			string text9 = "";
			string text10 = "";
			string text11 = "";
			string text12 = "";
			string text13 = "";
			string text14 = "";
			for (int k = 0; k < f1808BA.Count; k++)
			{
				string[] array = f1808BA[k].Split('|');
				try
				{
					for (int l = 0; l < list.Count; l++)
					{
						string text15 = list[l];
						string text16 = text15;
						uint num = HashString.DA8CEBAB(text16);
						if (num <= 2589850865u)
						{
							if (num <= 1439766491)
							{
								if (num <= 1127555431)
								{
									switch (num)
									{
									case 1127555431u:
										if (text16 == "Email")
										{
											text6 = array[l];
										}
										break;
									case 976575442u:
										if (text16 == "Token")
										{
											text4 = array[l];
										}
										break;
									}
									continue;
								}
								if (num == 1335761915)
								{
									if (text16 == "Proxy")
									{
										text10 = ((!(array[l].Trim() == "")) ? (array[l] + "*0") : "");
									}
									continue;
								}
								if (num != 1439766491 || !(text16 == "Email recover"))
								{
									continue;
								}
							}
							else
							{
								if (num > 1802569846)
								{
									if (num != 2249983736u)
									{
										if (num != 2589850865u || !(text16 == "Ngày sinh"))
										{
											continue;
										}
										goto IL_04a4;
									}
									if (text16 == "2FA")
									{
										text8 = array[l];
									}
									continue;
								}
								if (num == 1674345338)
								{
									if (!(text16 == "Friends"))
									{
										continue;
									}
									goto IL_0560;
								}
								if (num != 1802569846 || !(text16 == "Mail khôi phục"))
								{
									continue;
								}
							}
							text14 = array[l];
							continue;
						}
						if (num <= 3243292492u)
						{
							if (num > 3183131359u)
							{
								if (num != 3209957741u)
								{
									if (num != 3243292492u || !(text16 == "Birthday"))
									{
										continue;
									}
									goto IL_04a4;
								}
								if (text16 == "Uid")
								{
									text2 = array[l];
								}
								continue;
							}
							if (num != 2958674405u)
							{
								if (num == 3183131359u && text16 == "Cookie")
								{
									text5 = array[l];
								}
								continue;
							}
							if (!(text16 == "Ngày tạo"))
							{
								continue;
							}
						}
						else
						{
							if (num > 3611366992u)
							{
								if (num != 3646757383u)
								{
									if (num != 3763899592u)
									{
										if (num == 3797654840u && text16 == "Pass")
										{
											text3 = array[l];
										}
										continue;
									}
									if (!(text16 == "Bạn bè"))
									{
										continue;
									}
									goto IL_0560;
								}
								if (text16 == "Useragent")
								{
									text9 = array[l];
								}
								continue;
							}
							if (num != 3578917853u)
							{
								if (num == 3611366992u && text16 == "Pass Email")
								{
									text7 = array[l];
								}
								continue;
							}
							if (!(text16 == "Date created"))
							{
								continue;
							}
						}
						text13 = array[l];
						continue;
						IL_04a4:
						text11 = array[l];
						continue;
						IL_0560:
						text12 = array[l];
					}
					list_0.Add(text2 + "|" + text3 + "|" + text4 + "|" + text5 + "|" + text6 + "|" + text7 + "|" + text8 + "|" + text9 + "|" + text10 + "|" + text11 + "|" + text12 + "|" + text13 + "|" + text14);
				}
				catch
				{
					method_3(lblError);
				}
			}
			List<string> CFB6631B = new List<string>();
			list_1 = new List<Thread>();
			new Thread((ThreadStart)delegate
			{
				try
				{
					btnAdd.Invoke((MethodInvoker)delegate
					{
						btnAdd.Enabled = false;
					});
					method_2(Language.GetValue("Chuẩn bị thêm tài khoản..."), lblStatus);
					if (bool_0)
					{
						int num2 = 0;
						while (num2 < list_0.Count)
						{
							if (list_1.Count < int_0)
							{
								int int_ = num2++;
								method_2($"Check info {int_ + 1}/{list_0.Count}...", lblStatus);
								Thread thread = new Thread((ThreadStart)delegate
								{
									try
									{
										string text19 = list_0[int_];
										if (text19 != "")
										{
											string text20 = EF94CE9D(string_0, text19, bool_0);
											if (text20 != "")
											{
												lock (CFB6631B)
												{
													CFB6631B.Add(text20);
												}
											}
										}
									}
									catch (Exception)
									{
									}
								});
								list_1.Add(thread);
								thread.Start();
							}
							else
							{
								for (int m = 0; m < list_1.Count; m++)
								{
									if (!list_1[m].IsAlive)
									{
										list_1.RemoveAt(m--);
									}
								}
							}
						}
						for (int n = 0; n < list_1.Count; n++)
						{
							list_1[n].Join();
						}
					}
					else
					{
						for (int num3 = 0; num3 < list_0.Count; num3++)
						{
							try
							{
								string text17 = list_0[num3];
								if (text17 != "")
								{
									string text18 = EF94CE9D(string_0, text17, bool_0);
									if (text18 != "")
									{
										CFB6631B.Add(text18);
									}
								}
							}
							catch
							{
							}
						}
					}
					method_2(Language.GetValue("Đang thêm tài khoản..."), lblStatus);
					if (CFB6631B.Count >= 0)
					{
						CFB6631B = CommonSQL.smethod_7(CFB6631B);
						for (int num4 = 0; num4 < CFB6631B.Count; num4++)
						{
							method_3(lblSuccess, Connector.GClass8_0.A1A9B8A2(CFB6631B[num4]));
						}
					}
					method_2((Convert.ToInt32(F1ADA699.Text) - Convert.ToInt32(lblSuccess.Text)).ToString() ?? "", lblError);
					btnAdd.Invoke((MethodInvoker)delegate
					{
						btnAdd.Enabled = true;
					});
					method_2(Language.GetValue("Thêm tài khoản thành công!"), lblStatus);
					MessageBoxHelper.Show("Thêm tài khoản thành công!");
					this.bool_0 = true;
					this.int_0 = Convert.ToInt32(string_0);
				}
				catch (Exception exception_2)
				{
					Common.ExportError(null, exception_2, "AddAccount");
				}
			}).Start();
		}
		catch (Exception exception_)
		{
			MessageBoxHelper.Show("Đa\u0303 co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			Common.ExportError(null, exception_, "AddAccount");
		}
	}

	private string EF94CE9D(string string_1, string string_2, bool B4083E22)
	{
		try
		{
			string[] array = string_2.Split('|');
			string text = array[0];
			string e1B49CAA = array[1];
			string d = array[2];
			string text2 = array[3];
			string string_3 = array[4];
			string string_4 = array[5];
			string string_5 = array[6];
			string string_6 = array[7];
			string string_7 = array[8];
			string string_8 = array[9];
			string a91E0A = array[10];
			string string_9 = array[11];
			string fB2FEF = array[12];
			string string_10 = "";
			string bF98B8B = "";
			string bC86953B = "";
			string d2 = "unknow";
			if (text == "")
			{
				text = Regex.Match(text2, "c_user=(\\d+)").Groups[1].Value;
			}
			if (B4083E22 && text != "")
			{
				string text3 = PhoneFarmLib.Common.CheckInfoUid(text);
				if (text3.StartsWith("0|"))
				{
					if (EA98BF20.CheckLiveWall(text).StartsWith("0|"))
					{
						d2 = "Die";
					}
				}
				else if (text3.StartsWith("1|"))
				{
					string[] array2 = text3.Split('|');
					string_10 = array2[1];
					a91E0A = array2[2];
					string_9 = array2[3];
					d2 = "Live";
				}
			}
			return CommonSQL.ED864D9D(text, e1B49CAA, d, text2, string_3, string_10, a91E0A, bF98B8B, string_8, bC86953B, d2, string_5, string_1, string_4, string_6, string_7, string_9, fB2FEF);
		}
		catch (Exception)
		{
		}
		return "";
	}

	private void method_2(string string_1, Label A7A252A7)
	{
		A7A252A7.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			A7A252A7.Text = string_1;
		});
	}

	private void txbAccount_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> f1808BA = txbAccount.Lines.ToList();
			f1808BA = Common.RemoveEmptyItems(f1808BA);
			F1ADA699.Text = f1808BA.Count.ToString();
		}
		catch
		{
		}
	}

	private void method_3(Label A20E9103, int int_2 = -1)
	{
		if (int_2 == -1)
		{
			A20E9103.Invoke((MethodInvoker)delegate
			{
				Application.DoEvents();
				A20E9103.Text = (Convert.ToInt32(A20E9103.Text) + ((int_2 == -1) ? 1 : int_2)).ToString();
			});
		}
		else
		{
			A20E9103.Invoke((MethodInvoker)delegate
			{
				Application.DoEvents();
				A20E9103.Text = (Convert.ToInt32(A20E9103.Text) + int_2).ToString();
			});
		}
	}

	private void FD088335(object sender, EventArgs e)
	{
		plDinhDangNhap.Visible = E99C6E0D.SelectedIndex == E99C6E0D.Items.Count - 1;
		if (plDinhDangNhap.Visible)
		{
			method_6();
		}
	}

	private void CE105028(object sender, EventArgs e)
	{
		fAddFile form_ = new fAddFile();
		Common.smethod_16(form_);
		if (fAddFile.bool_0)
		{
			method_1();
			A10A3B03.SelectedIndex = A10A3B03.Items.Count - 1;
			bool_1 = true;
		}
	}

	private bool F099C924()
	{
		return false;
	}

	private void BB3D19BA_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (F099C924())
		{
			MessageBoxHelper.Show("Tu\u0300y cho\u0323n na\u0300y đa\u0303 tô\u0300n ta\u0323i, vui lo\u0300ng cho\u0323n tu\u0300y cho\u0323n kha\u0301c!", 3);
			(sender as ComboBox).SelectedIndex = -1;
		}
	}

	private void A10A3B03_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void BE9FE310_Click(object sender, EventArgs e)
	{
		method_4();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		method_5();
	}

	private void method_4()
	{
		try
		{
			for (int i = 0; i < E28FDE20.Count; i++)
			{
				E28FDE20[i].SelectedIndex = -1;
			}
		}
		catch
		{
		}
	}

	private void method_5()
	{
		try
		{
			string text = "";
			for (int i = 0; i < E28FDE20.Count; i++)
			{
				text = text + E28FDE20[i].SelectedIndex + "|";
			}
			text = text.TrimEnd('|');
			File.WriteAllText("settings\\format_paste.txt", text);
		}
		catch
		{
		}
	}

	private void method_6()
	{
		try
		{
			if (File.Exists("settings\\format_paste.txt"))
			{
				string text = File.ReadAllText("settings\\format_paste.txt");
				for (int i = 0; i < E28FDE20.Count; i++)
				{
					E28FDE20[i].SelectedIndex = Convert.ToInt32(text.Split('|')[i]);
				}
			}
		}
		catch
		{
		}
	}

	private void EABF48A4(object sender, EventArgs e)
	{
	}

	private void method_7(object sender, EventArgs e)
	{
		int selectedIndex = E99C6E0D.SelectedIndex;
		if (selectedIndex == -1 || selectedIndex == E99C6E0D.Items.Count - 1)
		{
			MessageBoxHelper.Show("Không thể xóa định dạng này!", 3);
			return;
		}
		string text = E99C6E0D.Text;
		if (MessageBoxHelper.smethod_1(string.Format(Language.GetValue("Ba\u0323n co\u0301 muô\u0301n xóa định dạng \"{0}\"?"), text)) == DialogResult.Yes)
		{
			list_2.Remove(text);
			File.WriteAllLines(string_0, list_2);
			method_8();
			E99C6E0D.SelectedIndex = ((selectedIndex != 0 || E99C6E0D.Items.Count <= 0) ? (selectedIndex - 1) : 0);
		}
	}

	private void fImportAccount_Load(object sender, EventArgs e)
	{
		Common.smethod_14(string_0);
		list_2 = File.ReadAllText(string_0).Split(new string[2] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
		if (list_2.Count == 0)
		{
			list_2 = new List<string> { "Uid|Pass|2FA", "Cookie", "Uid|Pass", "Uid|Pass|Token|Cookie", "Uid|Pass|Token|Cookie|Email|Pass Email", "Uid|Pass|Token|Cookie|Email|Pass Email|2FA" };
		}
		method_8();
		E99C6E0D.SelectedIndex = 0;
	}

	private void method_8()
	{
		E99C6E0D.Items.Clear();
		for (int i = 0; i < list_2.Count; i++)
		{
			E99C6E0D.Items.Add(list_2[i]);
		}
		E99C6E0D.Items.Add("Other...");
	}

	protected override void Dispose(bool C6AA419E)
	{
		if (C6AA419E && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C6AA419E);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportAccount));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		CA9B04B4 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnAdd = new System.Windows.Forms.Button();
		btnCancel = new System.Windows.Forms.Button();
		lblSuccess = new System.Windows.Forms.Label();
		lblError = new System.Windows.Forms.Label();
		F1ADA699 = new System.Windows.Forms.Label();
		A130B90F = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		E2961306 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		B9B3B29A = new System.Windows.Forms.Label();
		E99C6E0D = new System.Windows.Forms.ComboBox();
		cbbDinhDang1 = new System.Windows.Forms.ComboBox();
		DE01B417 = new System.Windows.Forms.Label();
		E8A334A3 = new System.Windows.Forms.ComboBox();
		label10 = new System.Windows.Forms.Label();
		cbbDinhDang3 = new System.Windows.Forms.ComboBox();
		EEB71809 = new System.Windows.Forms.Label();
		cbbDinhDang4 = new System.Windows.Forms.ComboBox();
		label12 = new System.Windows.Forms.Label();
		ED0C013E = new System.Windows.Forms.ComboBox();
		DC9393BB = new System.Windows.Forms.Label();
		cbbDinhDang6 = new System.Windows.Forms.ComboBox();
		BBA5A390 = new System.Windows.Forms.Label();
		B918B638 = new System.Windows.Forms.ComboBox();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		A8AA8EBF = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		plDinhDangNhap = new System.Windows.Forms.Panel();
		BE9FE310 = new System.Windows.Forms.Button();
		button3 = new System.Windows.Forms.Button();
		label19 = new System.Windows.Forms.Label();
		label18 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		cbbDinhDang10 = new System.Windows.Forms.ComboBox();
		label17 = new System.Windows.Forms.Label();
		AAA72B2D = new System.Windows.Forms.ComboBox();
		cbbDinhDang11 = new System.Windows.Forms.ComboBox();
		BB3D19BA = new System.Windows.Forms.ComboBox();
		label16 = new System.Windows.Forms.Label();
		A10A3B03 = new System.Windows.Forms.ComboBox();
		DF1474A4 = new System.Windows.Forms.Button();
		txbAccount = new System.Windows.Forms.RichTextBox();
		panel1 = new System.Windows.Forms.Panel();
		ckbCheckThongTin = new System.Windows.Forms.CheckBox();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)CA9B04B4).BeginInit();
		plDinhDangNhap.SuspendLayout();
		panel1.SuspendLayout();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(1142, 37);
		bunifuCards1.TabIndex = 11;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(CA9B04B4);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(1142, 31);
		pnlHeader.TabIndex = 9;
		CA9B04B4.Cursor = System.Windows.Forms.Cursors.Default;
		CA9B04B4.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		CA9B04B4.Location = new System.Drawing.Point(3, 2);
		CA9B04B4.Name = "pictureBox1";
		CA9B04B4.Size = new System.Drawing.Size(34, 27);
		CA9B04B4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		CA9B04B4.TabIndex = 76;
		CA9B04B4.TabStop = false;
		btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(1110, 2);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnCancel_Click);
		bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(1104, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Nhập Tài Khoản";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(459, 525);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(107, 31);
		btnAdd.TabIndex = 13;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(F527D197);
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(573, 525);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(107, 31);
		btnCancel.TabIndex = 14;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		lblSuccess.AutoSize = true;
		lblSuccess.BackColor = System.Drawing.SystemColors.Control;
		lblSuccess.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblSuccess.ForeColor = System.Drawing.Color.FromArgb(53, 120, 229);
		lblSuccess.Location = new System.Drawing.Point(106, 51);
		lblSuccess.Name = "lblSuccess";
		lblSuccess.Size = new System.Drawing.Size(19, 19);
		lblSuccess.TabIndex = 23;
		lblSuccess.Text = "0";
		lblError.AutoSize = true;
		lblError.BackColor = System.Drawing.SystemColors.Control;
		lblError.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblError.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		lblError.Location = new System.Drawing.Point(528, 51);
		lblError.Name = "lblError";
		lblError.Size = new System.Drawing.Size(19, 19);
		lblError.TabIndex = 24;
		lblError.Text = "0";
		F1ADA699.AutoSize = true;
		F1ADA699.BackColor = System.Drawing.SystemColors.Control;
		F1ADA699.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F1ADA699.ForeColor = System.Drawing.Color.Teal;
		F1ADA699.Location = new System.Drawing.Point(910, 51);
		F1ADA699.Name = "lblTotal";
		F1ADA699.Size = new System.Drawing.Size(19, 19);
		F1ADA699.TabIndex = 26;
		F1ADA699.Text = "0";
		A130B90F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		A130B90F.Location = new System.Drawing.Point(22, 53);
		A130B90F.Name = "label3";
		A130B90F.RightToLeft = System.Windows.Forms.RightToLeft.No;
		A130B90F.Size = new System.Drawing.Size(87, 16);
		A130B90F.TabIndex = 34;
		A130B90F.Text = "Tha\u0300nh công:";
		A130B90F.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		label4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		label4.Location = new System.Drawing.Point(480, 53);
		label4.Name = "label4";
		label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
		label4.Size = new System.Drawing.Size(52, 16);
		label4.TabIndex = 35;
		label4.Text = "Lỗi:";
		label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		E2961306.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		E2961306.Location = new System.Drawing.Point(851, 53);
		E2961306.Name = "label7";
		E2961306.RightToLeft = System.Windows.Forms.RightToLeft.No;
		E2961306.Size = new System.Drawing.Size(63, 16);
		E2961306.TabIndex = 38;
		E2961306.Text = "Tô\u0309ng sô\u0301:";
		E2961306.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.Location = new System.Drawing.Point(12, 86);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(1023, 28);
		lblStatus.TabIndex = 27;
		lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B9B3B29A.AutoSize = true;
		B9B3B29A.Location = new System.Drawing.Point(12, 397);
		B9B3B29A.Name = "label8";
		B9B3B29A.Size = new System.Drawing.Size(102, 16);
		B9B3B29A.TabIndex = 39;
		B9B3B29A.Text = "Định dạng nhập:";
		E99C6E0D.Cursor = System.Windows.Forms.Cursors.Hand;
		E99C6E0D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		E99C6E0D.FormattingEnabled = true;
		E99C6E0D.Items.AddRange(new object[7] { "Uid|Pass|2FA", "Cookie", "Uid|Pass", "Uid|Pass|Token|Cookie", "Uid|Pass|Token|Cookie|Email|Pass Email", "Uid|Pass|Token|Cookie|Email|Pass Email|2FA", "Other..." });
		E99C6E0D.Location = new System.Drawing.Point(115, 394);
		E99C6E0D.Name = "cbbDinhDangNhap";
		E99C6E0D.Size = new System.Drawing.Size(331, 24);
		E99C6E0D.TabIndex = 40;
		E99C6E0D.SelectedIndexChanged += new System.EventHandler(FD088335);
		cbbDinhDang1.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang1.DropDownWidth = 100;
		cbbDinhDang1.FormattingEnabled = true;
		cbbDinhDang1.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang1.Location = new System.Drawing.Point(3, 3);
		cbbDinhDang1.Name = "cbbDinhDang1";
		cbbDinhDang1.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang1.TabIndex = 40;
		cbbDinhDang1.SelectedIndexChanged += new System.EventHandler(BB3D19BA_SelectedIndexChanged);
		DE01B417.AutoSize = true;
		DE01B417.Font = new System.Drawing.Font("Tahoma", 12f);
		DE01B417.Location = new System.Drawing.Point(81, 3);
		DE01B417.Name = "label9";
		DE01B417.Size = new System.Drawing.Size(15, 19);
		DE01B417.TabIndex = 41;
		DE01B417.Text = "|";
		E8A334A3.Cursor = System.Windows.Forms.Cursors.Hand;
		E8A334A3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		E8A334A3.DropDownWidth = 100;
		E8A334A3.FormattingEnabled = true;
		E8A334A3.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		E8A334A3.Location = new System.Drawing.Point(96, 3);
		E8A334A3.Name = "cbbDinhDang2";
		E8A334A3.Size = new System.Drawing.Size(78, 24);
		E8A334A3.TabIndex = 40;
		E8A334A3.SelectedIndexChanged += new System.EventHandler(BB3D19BA_SelectedIndexChanged);
		label10.AutoSize = true;
		label10.Font = new System.Drawing.Font("Tahoma", 12f);
		label10.Location = new System.Drawing.Point(174, 3);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(15, 19);
		label10.TabIndex = 41;
		label10.Text = "|";
		cbbDinhDang3.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang3.DropDownWidth = 100;
		cbbDinhDang3.FormattingEnabled = true;
		cbbDinhDang3.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang3.Location = new System.Drawing.Point(189, 3);
		cbbDinhDang3.Name = "cbbDinhDang3";
		cbbDinhDang3.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang3.TabIndex = 40;
		cbbDinhDang3.SelectedIndexChanged += new System.EventHandler(BB3D19BA_SelectedIndexChanged);
		EEB71809.AutoSize = true;
		EEB71809.Font = new System.Drawing.Font("Tahoma", 12f);
		EEB71809.Location = new System.Drawing.Point(267, 3);
		EEB71809.Name = "label11";
		EEB71809.Size = new System.Drawing.Size(15, 19);
		EEB71809.TabIndex = 41;
		EEB71809.Text = "|";
		cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang4.DropDownWidth = 100;
		cbbDinhDang4.FormattingEnabled = true;
		cbbDinhDang4.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang4.Location = new System.Drawing.Point(282, 3);
		cbbDinhDang4.Name = "cbbDinhDang4";
		cbbDinhDang4.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang4.TabIndex = 40;
		cbbDinhDang4.SelectedIndexChanged += new System.EventHandler(BB3D19BA_SelectedIndexChanged);
		label12.AutoSize = true;
		label12.Font = new System.Drawing.Font("Tahoma", 12f);
		label12.Location = new System.Drawing.Point(360, 3);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(15, 19);
		label12.TabIndex = 41;
		label12.Text = "|";
		ED0C013E.Cursor = System.Windows.Forms.Cursors.Hand;
		ED0C013E.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		ED0C013E.DropDownWidth = 100;
		ED0C013E.FormattingEnabled = true;
		ED0C013E.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		ED0C013E.Location = new System.Drawing.Point(375, 3);
		ED0C013E.Name = "cbbDinhDang5";
		ED0C013E.Size = new System.Drawing.Size(78, 24);
		ED0C013E.TabIndex = 40;
		ED0C013E.SelectedIndexChanged += new System.EventHandler(BB3D19BA_SelectedIndexChanged);
		DC9393BB.AutoSize = true;
		DC9393BB.Font = new System.Drawing.Font("Tahoma", 12f);
		DC9393BB.Location = new System.Drawing.Point(453, 3);
		DC9393BB.Name = "label13";
		DC9393BB.Size = new System.Drawing.Size(15, 19);
		DC9393BB.TabIndex = 41;
		DC9393BB.Text = "|";
		cbbDinhDang6.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang6.DropDownWidth = 100;
		cbbDinhDang6.FormattingEnabled = true;
		cbbDinhDang6.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang6.Location = new System.Drawing.Point(468, 3);
		cbbDinhDang6.Name = "cbbDinhDang6";
		cbbDinhDang6.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang6.TabIndex = 40;
		cbbDinhDang6.SelectedIndexChanged += new System.EventHandler(BB3D19BA_SelectedIndexChanged);
		BBA5A390.AutoSize = true;
		BBA5A390.Font = new System.Drawing.Font("Tahoma", 12f);
		BBA5A390.Location = new System.Drawing.Point(546, 3);
		BBA5A390.Name = "label14";
		BBA5A390.Size = new System.Drawing.Size(15, 19);
		BBA5A390.TabIndex = 41;
		BBA5A390.Text = "|";
		B918B638.Cursor = System.Windows.Forms.Cursors.Hand;
		B918B638.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		B918B638.DropDownWidth = 100;
		B918B638.FormattingEnabled = true;
		B918B638.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		B918B638.Location = new System.Drawing.Point(561, 3);
		B918B638.Name = "cbbDinhDang7";
		B918B638.Size = new System.Drawing.Size(78, 24);
		B918B638.TabIndex = 40;
		B918B638.SelectedIndexChanged += new System.EventHandler(BB3D19BA_SelectedIndexChanged);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		A8AA8EBF.Fixed = true;
		A8AA8EBF.Horizontal = true;
		A8AA8EBF.TargetControl = pnlHeader;
		A8AA8EBF.Vertical = true;
		plDinhDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plDinhDangNhap.Controls.Add(BE9FE310);
		plDinhDangNhap.Controls.Add(button3);
		plDinhDangNhap.Controls.Add(cbbDinhDang1);
		plDinhDangNhap.Controls.Add(E8A334A3);
		plDinhDangNhap.Controls.Add(cbbDinhDang3);
		plDinhDangNhap.Controls.Add(cbbDinhDang4);
		plDinhDangNhap.Controls.Add(label19);
		plDinhDangNhap.Controls.Add(label18);
		plDinhDangNhap.Controls.Add(BBA5A390);
		plDinhDangNhap.Controls.Add(ED0C013E);
		plDinhDangNhap.Controls.Add(label1);
		plDinhDangNhap.Controls.Add(cbbDinhDang10);
		plDinhDangNhap.Controls.Add(label17);
		plDinhDangNhap.Controls.Add(AAA72B2D);
		plDinhDangNhap.Controls.Add(DC9393BB);
		plDinhDangNhap.Controls.Add(cbbDinhDang11);
		plDinhDangNhap.Controls.Add(cbbDinhDang6);
		plDinhDangNhap.Controls.Add(BB3D19BA);
		plDinhDangNhap.Controls.Add(label12);
		plDinhDangNhap.Controls.Add(B918B638);
		plDinhDangNhap.Controls.Add(EEB71809);
		plDinhDangNhap.Controls.Add(DE01B417);
		plDinhDangNhap.Controls.Add(label10);
		plDinhDangNhap.Location = new System.Drawing.Point(115, 420);
		plDinhDangNhap.Name = "plDinhDangNhap";
		plDinhDangNhap.Size = new System.Drawing.Size(1016, 75);
		plDinhDangNhap.TabIndex = 46;
		BE9FE310.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		BE9FE310.BackColor = System.Drawing.Color.DarkOrange;
		BE9FE310.Cursor = System.Windows.Forms.Cursors.Hand;
		BE9FE310.FlatAppearance.BorderSize = 0;
		BE9FE310.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BE9FE310.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BE9FE310.ForeColor = System.Drawing.Color.White;
		BE9FE310.Location = new System.Drawing.Point(379, 35);
		BE9FE310.Name = "button2";
		BE9FE310.Size = new System.Drawing.Size(121, 29);
		BE9FE310.TabIndex = 43;
		BE9FE310.Text = "Reset định dạng";
		BE9FE310.UseVisualStyleBackColor = false;
		BE9FE310.Click += new System.EventHandler(BE9FE310_Click);
		button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		button3.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		button3.Cursor = System.Windows.Forms.Cursors.Hand;
		button3.FlatAppearance.BorderSize = 0;
		button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		button3.ForeColor = System.Drawing.Color.White;
		button3.Location = new System.Drawing.Point(516, 35);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(120, 29);
		button3.TabIndex = 42;
		button3.Text = "Lưu định dạng";
		button3.UseVisualStyleBackColor = false;
		button3.Click += new System.EventHandler(button3_Click);
		label19.AutoSize = true;
		label19.Font = new System.Drawing.Font("Tahoma", 12f);
		label19.Location = new System.Drawing.Point(919, 3);
		label19.Name = "label19";
		label19.Size = new System.Drawing.Size(15, 19);
		label19.TabIndex = 41;
		label19.Text = "|";
		label18.AutoSize = true;
		label18.Font = new System.Drawing.Font("Tahoma", 12f);
		label18.Location = new System.Drawing.Point(732, 3);
		label18.Name = "label18";
		label18.Size = new System.Drawing.Size(15, 19);
		label18.TabIndex = 41;
		label18.Text = "|";
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 12f);
		label1.Location = new System.Drawing.Point(826, 5);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(15, 19);
		label1.TabIndex = 41;
		label1.Text = "|";
		cbbDinhDang10.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang10.DropDownWidth = 100;
		cbbDinhDang10.FormattingEnabled = true;
		cbbDinhDang10.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang10.Location = new System.Drawing.Point(841, 3);
		cbbDinhDang10.Name = "cbbDinhDang10";
		cbbDinhDang10.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang10.TabIndex = 40;
		cbbDinhDang10.SelectedIndexChanged += new System.EventHandler(BB3D19BA_SelectedIndexChanged);
		label17.AutoSize = true;
		label17.Font = new System.Drawing.Font("Tahoma", 12f);
		label17.Location = new System.Drawing.Point(639, 3);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(15, 19);
		label17.TabIndex = 41;
		label17.Text = "|";
		AAA72B2D.Cursor = System.Windows.Forms.Cursors.Hand;
		AAA72B2D.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		AAA72B2D.DropDownWidth = 100;
		AAA72B2D.FormattingEnabled = true;
		AAA72B2D.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		AAA72B2D.Location = new System.Drawing.Point(654, 3);
		AAA72B2D.Name = "cbbDinhDang8";
		AAA72B2D.Size = new System.Drawing.Size(78, 24);
		AAA72B2D.TabIndex = 40;
		AAA72B2D.SelectedIndexChanged += new System.EventHandler(BB3D19BA_SelectedIndexChanged);
		cbbDinhDang11.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang11.DropDownWidth = 100;
		cbbDinhDang11.FormattingEnabled = true;
		cbbDinhDang11.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang11.Location = new System.Drawing.Point(934, 3);
		cbbDinhDang11.Name = "cbbDinhDang11";
		cbbDinhDang11.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang11.TabIndex = 40;
		cbbDinhDang11.SelectedIndexChanged += new System.EventHandler(BB3D19BA_SelectedIndexChanged);
		BB3D19BA.Cursor = System.Windows.Forms.Cursors.Hand;
		BB3D19BA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		BB3D19BA.DropDownWidth = 100;
		BB3D19BA.FormattingEnabled = true;
		BB3D19BA.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		BB3D19BA.Location = new System.Drawing.Point(747, 3);
		BB3D19BA.Name = "cbbDinhDang9";
		BB3D19BA.Size = new System.Drawing.Size(78, 24);
		BB3D19BA.TabIndex = 40;
		BB3D19BA.SelectedIndexChanged += new System.EventHandler(BB3D19BA_SelectedIndexChanged);
		label16.AutoSize = true;
		label16.Location = new System.Drawing.Point(12, 368);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(92, 16);
		label16.TabIndex = 39;
		label16.Text = "Cho\u0323n thư mu\u0323c:";
		A10A3B03.Cursor = System.Windows.Forms.Cursors.Hand;
		A10A3B03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		A10A3B03.DropDownWidth = 269;
		A10A3B03.FormattingEnabled = true;
		A10A3B03.Location = new System.Drawing.Point(115, 365);
		A10A3B03.Name = "cbbThuMuc";
		A10A3B03.Size = new System.Drawing.Size(268, 24);
		A10A3B03.TabIndex = 40;
		A10A3B03.SelectedIndexChanged += new System.EventHandler(A10A3B03_SelectedIndexChanged);
		DF1474A4.Cursor = System.Windows.Forms.Cursors.Hand;
		DF1474A4.Location = new System.Drawing.Point(390, 364);
		DF1474A4.Name = "button1";
		DF1474A4.Size = new System.Drawing.Size(56, 25);
		DF1474A4.TabIndex = 45;
		DF1474A4.Text = "Thêm";
		DF1474A4.UseVisualStyleBackColor = true;
		DF1474A4.Click += new System.EventHandler(CE105028);
		txbAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txbAccount.Location = new System.Drawing.Point(13, 120);
		txbAccount.Name = "txbAccount";
		txbAccount.Size = new System.Drawing.Size(1118, 238);
		txbAccount.TabIndex = 48;
		txbAccount.Text = "";
		txbAccount.WordWrap = false;
		txbAccount.TextChanged += new System.EventHandler(txbAccount_TextChanged);
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(ckbCheckThongTin);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(1143, 569);
		panel1.TabIndex = 52;
		ckbCheckThongTin.AutoSize = true;
		ckbCheckThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCheckThongTin.Location = new System.Drawing.Point(12, 497);
		ckbCheckThongTin.Name = "ckbCheckThongTin";
		ckbCheckThongTin.Size = new System.Drawing.Size(255, 20);
		ckbCheckThongTin.TabIndex = 0;
		ckbCheckThongTin.Text = "Check thông tin (Tên, Bạn bè, Ngày tạo)";
		ckbCheckThongTin.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1143, 569);
		base.Controls.Add(txbAccount);
		base.Controls.Add(plDinhDangNhap);
		base.Controls.Add(DF1474A4);
		base.Controls.Add(A10A3B03);
		base.Controls.Add(E99C6E0D);
		base.Controls.Add(label16);
		base.Controls.Add(B9B3B29A);
		base.Controls.Add(E2961306);
		base.Controls.Add(label4);
		base.Controls.Add(A130B90F);
		base.Controls.Add(lblStatus);
		base.Controls.Add(F1ADA699);
		base.Controls.Add(lblError);
		base.Controls.Add(lblSuccess);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fImportAccount";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Nhập tài khoản";
		base.Load += new System.EventHandler(fImportAccount_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)CA9B04B4).EndInit();
		plDinhDangNhap.ResumeLayout(false);
		plDinhDangNhap.PerformLayout();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void method_9()
	{
		btnAdd.Enabled = false;
	}

	[CompilerGenerated]
	private void B71D8C85()
	{
		btnAdd.Enabled = true;
	}
}
