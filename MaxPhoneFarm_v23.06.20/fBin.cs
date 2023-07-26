using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;
using WindowsFormsControlLibrary1;

public class fBin : Form
{
	[CompilerGenerated]
	private sealed class Class32
	{
		internal fBin fBin_0;

		internal int int_0;

		internal int C8331EB2;

		internal void method_0()
		{
			try
			{
				int num = 0;
				while (num < fBin_0.dtgvAcc.Rows.Count)
				{
					if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (int_0 < C8331EB2)
						{
							Class33 CS_0024_003C_003E8__locals0 = new Class33
							{
								CD161736 = this
							};
							Interlocked.Increment(ref int_0);
							CS_0024_003C_003E8__locals0.C19D568B = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string input = DatagridviewHelper.E83E252C(CS_0024_003C_003E8__locals0.CD161736.fBin_0.dtgvAcc, CS_0024_003C_003E8__locals0.C19D568B, "cCookies");
									string text = DatagridviewHelper.E83E252C(CS_0024_003C_003E8__locals0.CD161736.fBin_0.dtgvAcc, CS_0024_003C_003E8__locals0.C19D568B, "cUid");
									if (text == "")
									{
										text = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
									}
									if (File.Exists("backup\\" + text + "\\" + text + ".html"))
									{
										Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\backup\\" + text + "\\" + text + ".html");
									}
									else
									{
										DatagridviewHelper.AD3DF791(CS_0024_003C_003E8__locals0.CD161736.fBin_0.dtgvAcc, CS_0024_003C_003E8__locals0.C19D568B, "cStatus", Language.GetValue("Chưa tạo html!"));
									}
									Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.CD161736.int_0);
								}
								catch (Exception ex2)
								{
									Common.smethod_43(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							Common.DelayTime(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (int_0 > 0)
				{
					Common.DelayTime(1.0);
				}
			}
			catch (Exception ex)
			{
				Common.smethod_43(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class33
	{
		internal int C19D568B;

		internal Class32 CD161736;

		internal void method_0()
		{
			try
			{
				string input = DatagridviewHelper.E83E252C(CD161736.fBin_0.dtgvAcc, C19D568B, "cCookies");
				string text = DatagridviewHelper.E83E252C(CD161736.fBin_0.dtgvAcc, C19D568B, "cUid");
				if (text == "")
				{
					text = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
				}
				if (File.Exists("backup\\" + text + "\\" + text + ".html"))
				{
					Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\backup\\" + text + "\\" + text + ".html");
				}
				else
				{
					DatagridviewHelper.AD3DF791(CD161736.fBin_0.dtgvAcc, C19D568B, "cStatus", Language.GetValue("Chưa tạo html!"));
				}
				Interlocked.Decrement(ref CD161736.int_0);
			}
			catch (Exception ex)
			{
				Common.smethod_43(null, ex.ToString());
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class34
	{
		internal fBin fBin_0;

		internal int B73A0B32;

		internal int int_0;

		internal void method_0()
		{
			fBin_0.C43C18AB("start");
			int num = 0;
			while (num < fBin_0.dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (fBin_0.CA2F94BD)
				{
					break;
				}
				if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (B73A0B32 < int_0)
					{
						Class35 CS_0024_003C_003E8__locals0 = new Class35
						{
							class34_0 = this
						};
						Interlocked.Increment(ref B73A0B32);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class34_0.fBin_0.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals0.int_0, 0, CS_0024_003C_003E8__locals0.class34_0.fBin_0.dtgvAcc);
							CS_0024_003C_003E8__locals0.class34_0.fBin_0.method_27(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class34_0.B73A0B32);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (B73A0B32 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			fBin_0.C43C18AB("stop");
		}
	}

	[CompilerGenerated]
	private sealed class Class35
	{
		internal int int_0;

		internal Class34 class34_0;

		internal void method_0()
		{
			class34_0.fBin_0.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", int_0, 0, class34_0.fBin_0.dtgvAcc);
			class34_0.fBin_0.method_27(int_0);
			Interlocked.Decrement(ref class34_0.B73A0B32);
		}
	}

	[CompilerGenerated]
	private sealed class Class36
	{
		internal int AA8521A4;

		internal int B6826F94;

		internal fBin fBin_0;

		internal void method_0()
		{
			int num = 0;
			while (num < fBin_0.dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (AA8521A4 < B6826F94)
					{
						Class37 CS_0024_003C_003E8__locals0 = new Class37
						{
							AB9CC932 = this
						};
						Interlocked.Increment(ref AA8521A4);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.AB9CC932.fBin_0.method_9(Language.GetValue("Đang xo\u0301a dữ liệu backup..."), "cStatus", CS_0024_003C_003E8__locals0.int_0, 0, CS_0024_003C_003E8__locals0.AB9CC932.fBin_0.dtgvAcc);
							CS_0024_003C_003E8__locals0.AB9CC932.fBin_0.method_30(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.AB9CC932.AA8521A4);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class37
	{
		internal int int_0;

		internal Class36 AB9CC932;

		internal void BD897B30()
		{
			AB9CC932.fBin_0.method_9(Language.GetValue("Đang xo\u0301a dữ liệu backup..."), "cStatus", int_0, 0, AB9CC932.fBin_0.dtgvAcc);
			AB9CC932.fBin_0.method_30(int_0);
			Interlocked.Decrement(ref AB9CC932.AA8521A4);
		}
	}

	[CompilerGenerated]
	private sealed class Class38
	{
		internal fBin F5BEC3BC;

		internal int int_0;

		internal int int_1;

		internal string string_0;

		internal void method_0()
		{
			int num = 0;
			while (num < F5BEC3BC.dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(F5BEC3BC.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Class39 CS_0024_003C_003E8__locals0 = new Class39
						{
							class38_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.D8A9919E = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.class38_0.F5BEC3BC.method_4(CS_0024_003C_003E8__locals0.D8A9919E, Language.GetValue("Đang check backup..."));
							CS_0024_003C_003E8__locals0.class38_0.F5BEC3BC.AF0B0BA6(CS_0024_003C_003E8__locals0.D8A9919E, CS_0024_003C_003E8__locals0.class38_0.string_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.class38_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class39
	{
		internal int D8A9919E;

		internal Class38 class38_0;

		internal void method_0()
		{
			class38_0.F5BEC3BC.method_4(D8A9919E, Language.GetValue("Đang check backup..."));
			class38_0.F5BEC3BC.AF0B0BA6(D8A9919E, class38_0.string_0);
			Interlocked.Decrement(ref class38_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class ADB9BCAD
	{
		internal string string_0;

		internal fBin fBin_0;

		internal void method_0()
		{
			try
			{
				if (string_0 == "start")
				{
					fBin_0.grTimKiem.Enabled = false;
					fBin_0.grQuanLyThuMuc.Enabled = false;
				}
				else if (string_0 == "stop")
				{
					fBin_0.grTimKiem.Enabled = true;
					fBin_0.grQuanLyThuMuc.Enabled = true;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class40
	{
		internal fBin DF95C42E;

		internal int CB13CA23;

		internal int int_0;

		internal int int_1;

		internal string C73C8736;

		internal void method_0()
		{
			DF95C42E.C43C18AB("start");
			switch (CB13CA23)
			{
			case 0:
			{
				int num4 = 0;
				while (num4 < DF95C42E.dtgvAcc.Rows.Count && !DF95C42E.CA2F94BD)
				{
					if (Convert.ToBoolean(DF95C42E.dtgvAcc.Rows[num4].Cells["cChose"].Value))
					{
						if (int_0 < int_1)
						{
							BD9AC088 CS_0024_003C_003E8__locals5 = new BD9AC088
							{
								B68FCD8C = this
							};
							Interlocked.Increment(ref int_0);
							CS_0024_003C_003E8__locals5.int_0 = num4++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals5.B68FCD8C.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals5.int_0, 0, CS_0024_003C_003E8__locals5.B68FCD8C.DF95C42E.dtgvAcc);
								CS_0024_003C_003E8__locals5.B68FCD8C.DF95C42E.EBBE493F(CS_0024_003C_003E8__locals5.int_0, CS_0024_003C_003E8__locals5.B68FCD8C.C73C8736);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals5.B68FCD8C.int_0);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num4++;
					}
				}
				break;
			}
			case 1:
			{
				int num6 = 0;
				while (num6 < DF95C42E.dtgvAcc.Rows.Count && !DF95C42E.CA2F94BD)
				{
					if (Convert.ToBoolean(DF95C42E.dtgvAcc.Rows[num6].Cells["cChose"].Value))
					{
						if (int_0 < int_1)
						{
							Class41 CS_0024_003C_003E8__locals0 = new Class41
							{
								C3188983 = this
							};
							Interlocked.Increment(ref int_0);
							CS_0024_003C_003E8__locals0.int_0 = num6++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals0.C3188983.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals0.int_0, 0, CS_0024_003C_003E8__locals0.C3188983.DF95C42E.dtgvAcc);
								CS_0024_003C_003E8__locals0.C3188983.DF95C42E.F28D8489(CS_0024_003C_003E8__locals0.int_0);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.C3188983.int_0);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num6++;
					}
				}
				break;
			}
			case 2:
			{
				int num2 = 0;
				while (num2 < DF95C42E.dtgvAcc.Rows.Count && !DF95C42E.CA2F94BD)
				{
					if (Convert.ToBoolean(DF95C42E.dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						if (int_0 < int_1)
						{
							CA052018 CS_0024_003C_003E8__locals1 = new CA052018
							{
								class40_0 = this
							};
							Interlocked.Increment(ref int_0);
							CS_0024_003C_003E8__locals1.E91405A2 = num2++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals1.class40_0.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals1.E91405A2, 0, CS_0024_003C_003E8__locals1.class40_0.DF95C42E.dtgvAcc);
								CS_0024_003C_003E8__locals1.class40_0.DF95C42E.method_21(CS_0024_003C_003E8__locals1.E91405A2);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals1.class40_0.int_0);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num2++;
					}
				}
				break;
			}
			case 3:
			{
				int num5 = 0;
				while (num5 < DF95C42E.dtgvAcc.Rows.Count && !DF95C42E.CA2F94BD)
				{
					if (Convert.ToBoolean(DF95C42E.dtgvAcc.Rows[num5].Cells["cChose"].Value))
					{
						if (int_0 < int_1)
						{
							Class42 CS_0024_003C_003E8__locals2 = new Class42
							{
								C3093B3C = this
							};
							Interlocked.Increment(ref int_0);
							CS_0024_003C_003E8__locals2.A18D7485 = num5++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals2.C3093B3C.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals2.A18D7485, 0, CS_0024_003C_003E8__locals2.C3093B3C.DF95C42E.dtgvAcc);
								CS_0024_003C_003E8__locals2.C3093B3C.DF95C42E.C4212539(CS_0024_003C_003E8__locals2.A18D7485);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals2.C3093B3C.int_0);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num5++;
					}
				}
				break;
			}
			case 4:
			{
				int num3 = 0;
				while (num3 < DF95C42E.dtgvAcc.Rows.Count && !DF95C42E.CA2F94BD)
				{
					if (Convert.ToBoolean(DF95C42E.dtgvAcc.Rows[num3].Cells["cChose"].Value))
					{
						if (int_0 < int_1)
						{
							Class43 CS_0024_003C_003E8__locals3 = new Class43
							{
								class40_0 = this
							};
							Interlocked.Increment(ref int_0);
							CS_0024_003C_003E8__locals3.int_0 = num3++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals3.class40_0.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals3.int_0, 0, CS_0024_003C_003E8__locals3.class40_0.DF95C42E.dtgvAcc);
								CS_0024_003C_003E8__locals3.class40_0.DF95C42E.method_20(CS_0024_003C_003E8__locals3.int_0);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals3.class40_0.int_0);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num3++;
					}
				}
				break;
			}
			case 5:
			{
				int num = 0;
				while (num < DF95C42E.dtgvAcc.Rows.Count && !DF95C42E.CA2F94BD)
				{
					if (Convert.ToBoolean(DF95C42E.dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (int_0 < int_1)
						{
							A7337525 CS_0024_003C_003E8__locals4 = new A7337525
							{
								B03E0EA0 = this
							};
							Interlocked.Increment(ref int_0);
							CS_0024_003C_003E8__locals4.int_0 = num++;
							new Thread((ThreadStart)delegate
							{
								CS_0024_003C_003E8__locals4.B03E0EA0.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", CS_0024_003C_003E8__locals4.int_0, 0, CS_0024_003C_003E8__locals4.B03E0EA0.DF95C42E.dtgvAcc);
								CS_0024_003C_003E8__locals4.B03E0EA0.DF95C42E.method_19(CS_0024_003C_003E8__locals4.int_0);
								Interlocked.Decrement(ref CS_0024_003C_003E8__locals4.B03E0EA0.int_0);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
				break;
			}
			}
			int tickCount = Environment.TickCount;
			while (int_0 > 0 && Environment.TickCount - tickCount <= 60000)
			{
				Common.DelayTime(1.0);
			}
			DF95C42E.C43C18AB("stop");
		}
	}

	[CompilerGenerated]
	private sealed class BD9AC088
	{
		internal int int_0;

		internal Class40 B68FCD8C;

		internal void A6330794()
		{
			B68FCD8C.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", int_0, 0, B68FCD8C.DF95C42E.dtgvAcc);
			B68FCD8C.DF95C42E.EBBE493F(int_0, B68FCD8C.C73C8736);
			Interlocked.Decrement(ref B68FCD8C.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class41
	{
		internal int int_0;

		internal Class40 C3188983;

		internal void B98A76A5()
		{
			C3188983.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", int_0, 0, C3188983.DF95C42E.dtgvAcc);
			C3188983.DF95C42E.F28D8489(int_0);
			Interlocked.Decrement(ref C3188983.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class CA052018
	{
		internal int E91405A2;

		internal Class40 class40_0;

		internal void method_0()
		{
			class40_0.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", E91405A2, 0, class40_0.DF95C42E.dtgvAcc);
			class40_0.DF95C42E.method_21(E91405A2);
			Interlocked.Decrement(ref class40_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class42
	{
		internal int A18D7485;

		internal Class40 C3093B3C;

		internal void method_0()
		{
			C3093B3C.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", A18D7485, 0, C3093B3C.DF95C42E.dtgvAcc);
			C3093B3C.DF95C42E.C4212539(A18D7485);
			Interlocked.Decrement(ref C3093B3C.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class43
	{
		internal int int_0;

		internal Class40 class40_0;

		internal void method_0()
		{
			class40_0.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", int_0, 0, class40_0.DF95C42E.dtgvAcc);
			class40_0.DF95C42E.method_20(int_0);
			Interlocked.Decrement(ref class40_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class A7337525
	{
		internal int int_0;

		internal Class40 B03E0EA0;

		internal void method_0()
		{
			B03E0EA0.DF95C42E.method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", int_0, 0, B03E0EA0.DF95C42E.dtgvAcc);
			B03E0EA0.DF95C42E.method_19(int_0);
			Interlocked.Decrement(ref B03E0EA0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class A3106599
	{
		internal int int_0;

		internal int EE24BB96;

		internal fBin ED845EA0;

		internal void method_0()
		{
			int num = 0;
			while (num < ED845EA0.dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(ED845EA0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < EE24BB96)
					{
						Class44 CS_0024_003C_003E8__locals0 = new Class44
						{
							a3106599_0 = this
						};
						Interlocked.Increment(ref int_0);
						CS_0024_003C_003E8__locals0.AD29B7AC = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.a3106599_0.ED845EA0.method_9(Language.GetValue("Đang xo\u0301a profile..."), "cStatus", CS_0024_003C_003E8__locals0.AD29B7AC, 0, CS_0024_003C_003E8__locals0.a3106599_0.ED845EA0.dtgvAcc);
							CS_0024_003C_003E8__locals0.a3106599_0.ED845EA0.method_23(CS_0024_003C_003E8__locals0.AD29B7AC);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.a3106599_0.int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class44
	{
		internal int AD29B7AC;

		internal A3106599 a3106599_0;

		internal void method_0()
		{
			a3106599_0.ED845EA0.method_9(Language.GetValue("Đang xo\u0301a profile..."), "cStatus", AD29B7AC, 0, a3106599_0.ED845EA0.dtgvAcc);
			a3106599_0.ED845EA0.method_23(AD29B7AC);
			Interlocked.Decrement(ref a3106599_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class FC03B70A
	{
		internal fBin fBin_0;

		internal int BE3D1C0E;

		internal int int_0;

		internal void method_0()
		{
			int num = 0;
			while (num < fBin_0.dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(fBin_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (BE3D1C0E < int_0)
					{
						Class45 CS_0024_003C_003E8__locals0 = new Class45
						{
							fc03B70A_0 = this
						};
						Interlocked.Increment(ref BE3D1C0E);
						CS_0024_003C_003E8__locals0.int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							CS_0024_003C_003E8__locals0.fc03B70A_0.fBin_0.method_9(Language.GetValue("Đang check profile..."), "cStatus", CS_0024_003C_003E8__locals0.int_0, 0, CS_0024_003C_003E8__locals0.fc03B70A_0.fBin_0.dtgvAcc);
							CS_0024_003C_003E8__locals0.fc03B70A_0.fBin_0.B482E004(CS_0024_003C_003E8__locals0.int_0);
							Interlocked.Decrement(ref CS_0024_003C_003E8__locals0.fc03B70A_0.BE3D1C0E);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class45
	{
		internal int int_0;

		internal FC03B70A fc03B70A_0;

		internal void method_0()
		{
			fc03B70A_0.fBin_0.method_9(Language.GetValue("Đang check profile..."), "cStatus", int_0, 0, fc03B70A_0.fBin_0.dtgvAcc);
			fc03B70A_0.fBin_0.B482E004(int_0);
			Interlocked.Decrement(ref fc03B70A_0.BE3D1C0E);
		}
	}

	internal Random random_0 = new Random();

	internal bool CA2F94BD;

	internal object object_0 = new object();

	internal object object_1 = new object();

	internal int BCAD5798 = 0;

	internal object object_2 = new object();

	internal List<string> EE1FB4BE = new List<string>();

	internal List<string> list_0 = new List<string>();

	internal List<string> B12E4803 = new List<string>();

	internal object object_3 = new object();

	internal List<int> list_1 = new List<int>();

	internal bool bool_0 = false;

	internal object ED801B8A = new object();

	internal int int_0 = -1;

	internal bool bool_1 = true;

	internal object object_4 = new object();

	internal object object_5 = new object();

	internal object object_6 = new object();

	internal object object_7 = new object();

	internal object BD2E48A0 = new object();

	internal int FBBA83AE = -1;

	internal bool bool_2 = true;

	internal List<A4AF3582> F79A491D = null;

	internal List<D59F6E91> A2894D10 = null;

	internal List<Class27> EB393813 = null;

	internal List<string> list_2 = null;

	internal List<string> B6BF2925 = null;

	internal List<string> C52E330F = null;

	internal List<Thread> DF8B91A1 = null;

	internal IContainer icontainer_0 = null;

	internal DataGridView dtgvAcc;

	internal BunifuDragControl F781CA0E;

	internal BunifuCards C9015402;

	internal Panel F3221FB0;

	internal PictureBox C3160B89;

	internal Button button2;

	internal Button button1;

	internal Button E6053A39;

	internal BunifuCustomLabel B531ACAB;

	internal MenuStrip menuStrip1;

	internal GroupBox grQuanLyThuMuc;

	internal Label label1;

	internal ComboBox D1AF0537;

	internal ContextMenuStrip ctmsAcc;

	internal ToolStripMenuItem toolStripMenuItem_0;

	internal ToolStripMenuItem liveToolStripMenuItem;

	internal ToolStripMenuItem FC248A3F;

	internal ToolStripMenuItem tokenToolStripMenuItem;

	internal ToolStripMenuItem cookieToolStripMenuItem;

	internal ToolStripMenuItem A6A8159C;

	internal ToolStripMenuItem uidPassTokenCookieToolStripMenuItem;

	internal ToolStripMenuItem toolStripMenuItem_1;

	internal ToolStripMenuItem A33498AD;

	internal ToolStripMenuItem toolStripMenuItem_2;

	internal ToolStripMenuItem AA05B298;

	internal ToolStripMenuItem AC3C6ABF;

	internal ToolStripMenuItem toolStripMenuItem_3;

	internal ToolStripMenuItem C834A7BE;

	internal ToolStripMenuItem toolStripMenuItem_4;

	internal ToolStripMenuItem toolStripMenuItem_5;

	internal ToolStripMenuItem mailPassMailToolStripMenuItem;

	internal ToolStripMenuItem C22983AA;

	internal ToolStripMenuItem DEBD7106;

	internal ToolStripMenuItem DEB7FE26;

	internal GroupBox grTimKiem;

	internal BunifuCustomTextbox txbSearch;

	internal ToolStripMenuItem mailToolStripMenuItem;

	internal ToolStripMenuItem uidPassTokenCookieMailPassMail2faToolStripMenuItem;

	internal ToolStripMenuItem fAToolStripMenuItem;

	internal ToolStripMenuItem tinhTrangToolStripMenuItem;

	internal ToolStripMenuItem uidPass2FaToolStripMenuItem;

	internal BunifuDragControl A41AE315;

	internal ToolTip BB3BE919;

	internal ToolStripMenuItem toolStripMenuItem_6;

	internal ToolStripMenuItem toolStripMenuItem_7;

	internal ToolStripMenuItem toolStripMenuItem_8;

	internal ToolStripMenuItem DCA1D0BD;

	internal ToolStripMenuItem proxyToolStripMenuItem1;

	internal ComboBox cbbSearch;

	internal Button btnLoadAcc;

	internal ComboBox A0203D34;

	internal Label C017E608;

	internal ToolStripMenuItem toolStripMenuItem_9;

	internal Button BtnSearch;

	internal ToolStripMenuItem uidToolStripMenuItem;

	internal ToolStripMenuItem checkAvatarToolStripMenuItem;

	internal ToolStripMenuItem checkProxyToolStripMenuItem;

	internal ToolStripMenuItem checkProfileToolStripMenuItem1;

	internal ToolStripMenuItem EE0B0639;

	internal ToolStripMenuItem EE257EBB;

	internal ToolStripMenuItem A607580A;

	internal StatusStrip F8BAEE9A;

	internal ToolStripStatusLabel CBA9C70B;

	internal ToolStripStatusLabel B088C79D;

	internal ToolStripStatusLabel toolStripStatusLabel7;

	internal ToolStripStatusLabel lblCountTotal;

	internal DataGridViewCheckBoxColumn cChose;

	internal DataGridViewTextBoxColumn EE0F2880;

	internal DataGridViewTextBoxColumn cId;

	internal DataGridViewTextBoxColumn cUid;

	internal DataGridViewTextBoxColumn cToken;

	internal DataGridViewTextBoxColumn A09F631C;

	internal DataGridViewTextBoxColumn FE89DDA5;

	internal DataGridViewTextBoxColumn AF0DEB09;

	internal DataGridViewTextBoxColumn cName;

	internal DataGridViewTextBoxColumn cFollow;

	internal DataGridViewTextBoxColumn cFriend;

	internal DataGridViewTextBoxColumn CC97E00D;

	internal DataGridViewTextBoxColumn cBirthday;

	internal DataGridViewTextBoxColumn E18BE606;

	internal DataGridViewTextBoxColumn cPassword;

	internal DataGridViewTextBoxColumn B5A0F2A1;

	internal DataGridViewTextBoxColumn cPassMail;

	internal DataGridViewTextBoxColumn B70CECA5;

	internal DataGridViewTextBoxColumn cFa2;

	internal DataGridViewTextBoxColumn CF016A03;

	internal DataGridViewTextBoxColumn cProxy;

	internal DataGridViewTextBoxColumn cDateCreateAcc;

	internal DataGridViewTextBoxColumn FA36B6BC;

	internal DataGridViewTextBoxColumn cProfile;

	internal DataGridViewTextBoxColumn cThuMuc;

	internal DataGridViewTextBoxColumn B905F38A;

	internal DataGridViewTextBoxColumn C9947698;

	internal DataGridViewTextBoxColumn cGhiChu;

	internal DataGridViewTextBoxColumn cDateDelete;

	internal DataGridViewTextBoxColumn cStatus;

	internal Button F80C9C82;

	internal Button D03ADA1C;

	internal Label EE2AB393;

	internal ToolStripMenuItem FFB4E61B;

	internal ToolStripMenuItem EB08C73B;

	public fBin()
	{
		InitializeComponent();
		method_1();
		method_0();
		menuStrip1.Cursor = Cursors.Hand;
		Language.SetLanguage(this);
		Language.smethod_5(ctmsAcc);
	}

	private void method_0()
	{
		Dictionary<string, string> dataSource = new Dictionary<string, string>
		{
			{ "cUid", "UID" },
			{ "cToken", "Token" },
			{ "cCookies", "Cookie" },
			{ "cEmail", "Email" },
			{ "cPassMail", "Pass email" },
			{
				"cName",
				Language.GetValue("Tên")
			},
			{
				"cBirthday",
				Language.GetValue("Ngày sinh")
			},
			{
				"cGender",
				Language.GetValue("Giới tính")
			},
			{
				"cPassword",
				Language.GetValue("Mật khẩu")
			},
			{
				"cGhiChu",
				Language.GetValue("Ghi chu\u0301")
			},
			{
				"cInteractEnd",
				Language.GetValue("Tương ta\u0301c cuô\u0301i")
			}
		};
		cbbSearch.DataSource = new BindingSource(dataSource, null);
		cbbSearch.ValueMember = "Key";
		cbbSearch.DisplayMember = "Value";
	}

	private void method_1()
	{
		dtgvAcc.Columns["cToken"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("cToken");
		dtgvAcc.Columns["cCookies"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbCookie");
		dtgvAcc.Columns["cEmail"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbEmail");
		dtgvAcc.Columns["cName"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbTen");
		dtgvAcc.Columns["cFriend"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbBanBe");
		dtgvAcc.Columns["cGroup"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbNhom");
		dtgvAcc.Columns["cBirthday"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbNgaySinh");
		dtgvAcc.Columns["cGender"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbGioiTinh");
		dtgvAcc.Columns["cPassword"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbMatKhau");
		dtgvAcc.Columns["cPassMail"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbMatKhauMail");
		dtgvAcc.Columns["cBackup"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbBackup");
		dtgvAcc.Columns["cFa2"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbMa2FA");
		dtgvAcc.Columns["cUseragent"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbUseragent");
		dtgvAcc.Columns["cProxy"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbProxy");
		dtgvAcc.Columns["cDateCreateAcc"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbNgayTao");
		dtgvAcc.Columns["cAvatar"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbAvatar");
		dtgvAcc.Columns["cProfile"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbProfile");
		dtgvAcc.Columns["cInfo"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbTinhTrang");
		dtgvAcc.Columns["cThuMuc"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbThuMuc");
		dtgvAcc.Columns["cGhiChu"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbGhiChu");
		dtgvAcc.Columns["cFollow"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbFollow");
		dtgvAcc.Columns["cInteractEnd"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbInteractEnd");
		dtgvAcc.Columns["cPhone"].Visible = SettingsTool.GetSettings("configDatagridview").AA824D29("ckbPhone");
	}

	protected override void OnLoad(EventArgs EEA88DBF)
	{
		Application.Idle += B30D493C;
	}

	private void C3A039B7(object sender, EventArgs e)
	{
		Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		this.smethod_2();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void btnLoadAcc_Click(object sender, EventArgs e)
	{
		string text = "";
		if (D1AF0537.SelectedValue != null)
		{
			text = D1AF0537.SelectedValue.ToString();
		}
		D7A0F89C();
		if (text != "999999" && text != "-1")
		{
			int_0 = -1;
			D1AF0537.SelectedValue = text;
			return;
		}
		bool_1 = false;
		D1AF0537.SelectedValue = text;
		bool_1 = true;
		A30E820B(fChonThuMuc.F5BA2A9C);
	}

	private List<string> DE848412()
	{
		List<string> result = null;
		try
		{
			string text = D1AF0537.SelectedValue.ToString();
			string text2 = text;
			if (!(text2 == "-1"))
			{
				result = ((text2 == "999999") ? GClass22.smethod_2(fChonThuMuc.F5BA2A9C) : new List<string> { D1AF0537.SelectedValue.ToString() });
			}
		}
		catch
		{
		}
		return result;
	}

	private void DF2BE010(List<string> list_3 = null, string DF811139 = "", bool bool_3 = false)
	{
		try
		{
			dtgvAcc.Rows.Clear();
			if (DF811139 == "[Tất cả tình trạng]" || DF811139 == Language.GetValue("[Tất cả tình trạng]"))
			{
				DF811139 = "";
			}
			DataTable dataTable_ = CommonSQL.smethod_11(list_3, DF811139, bool_3);
			method_2(dataTable_);
		}
		catch (Exception)
		{
		}
	}

	private void method_2(DataTable dataTable_0)
	{
		DatagridviewHelper.AB825897(dtgvAcc, dataTable_0, AE172E1C: true);
		DB1232BB(0);
		method_3();
		C6A5CC86();
	}

	private void A610FE92(int EDB087AC, int E7843591)
	{
		switch (E7843591)
		{
		case 2:
			dtgvAcc.Rows[EDB087AC].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
			break;
		case 1:
			dtgvAcc.Rows[EDB087AC].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
			break;
		}
	}

	private void method_3(int int_1 = -1)
	{
		if (SettingsTool.GetSettings("configGeneral").method_0("typePhanBietMau") == 0)
		{
			if (int_1 == -1)
			{
				for (int i = 0; i < dtgvAcc.RowCount; i++)
				{
					string text = method_6(i);
					if (text == "Live")
					{
						dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					}
					else if (text.Contains("Die") || text.Contains(Language.GetValue("Checkpoint")) || text.Contains("Changed pass"))
					{
						dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
					}
				}
			}
			else
			{
				string text2 = method_6(int_1);
				if (text2 == "Live")
				{
					dtgvAcc.Rows[int_1].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
				}
				else if (text2.Contains("Die") || text2.Contains(Language.GetValue("Checkpoint")) || text2.Contains("Changed pass"))
				{
					dtgvAcc.Rows[int_1].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
				}
			}
		}
		else if (int_1 == -1)
		{
			for (int j = 0; j < dtgvAcc.RowCount; j++)
			{
				string text3 = method_6(j);
				if (text3 == "Live")
				{
					dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Green;
				}
				else if (text3.Contains("Die") || text3.Contains(Language.GetValue("Checkpoint")) || text3.Contains("Changed pass"))
				{
					dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Red;
				}
			}
		}
		else
		{
			string text4 = method_6(int_1);
			if (text4 == "Live")
			{
				dtgvAcc.Rows[int_1].DefaultCellStyle.ForeColor = Color.Green;
			}
			else if (text4.Contains("Die") || text4.Contains(Language.GetValue("Checkpoint")) || text4.Contains("Changed pass"))
			{
				dtgvAcc.Rows[int_1].DefaultCellStyle.ForeColor = Color.Red;
			}
		}
	}

	public void method_4(int int_1, string string_0)
	{
		DatagridviewHelper.AD3DF791(dtgvAcc, int_1, "cStatus", string_0);
	}

	public void AF3E1011(int int_1, string string_0)
	{
		DatagridviewHelper.AD3DF791(dtgvAcc, int_1, "cInfo", string_0);
		method_3(int_1);
		CommonSQL.UpdateFieldToAccount(method_7(int_1, "cId"), "info", string_0);
	}

	public void method_5(int C2B7A80B, string B63406A2, object object_8)
	{
		DatagridviewHelper.AD3DF791(dtgvAcc, C2B7A80B, B63406A2, object_8);
	}

	public void A5BC8B07(int F51020B1, int D2BCC937, object object_8)
	{
		DatagridviewHelper.smethod_1(dtgvAcc, F51020B1, D2BCC937, object_8);
	}

	public string DEB17624(int D02EE2A5)
	{
		return DatagridviewHelper.E83E252C(dtgvAcc, D02EE2A5, "cStatus");
	}

	public string method_6(int A9338414)
	{
		return DatagridviewHelper.E83E252C(dtgvAcc, A9338414, "cInfo");
	}

	public string method_7(int int_1, string A42ABC11)
	{
		return DatagridviewHelper.E83E252C(dtgvAcc, int_1, A42ABC11);
	}

	public string method_8(int int_1, int int_2)
	{
		return DatagridviewHelper.smethod_0(dtgvAcc, int_1, int_2);
	}

	private void C6A5CC86()
	{
		try
		{
			lblCountTotal.Text = dtgvAcc.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void DB1232BB(int int_1 = -1)
	{
		if (int_1 == -1)
		{
			int_1 = 0;
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					int_1++;
				}
			}
		}
		B088C79D.Text = int_1.ToString();
	}

	private void E03635AF(int B122489B = -1)
	{
		if (SettingsTool.GetSettings("configGeneral").method_0("typePhanBietMau") == 0)
		{
			if (B122489B == -1)
			{
				for (int i = 0; i < dtgvAcc.RowCount; i++)
				{
					string text = DatagridviewHelper.E83E252C(dtgvAcc, i, "cInfo");
					if (text == "Live")
					{
						dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
					}
					else if (text.Contains("Die") || text.Contains(Language.GetValue("Checkpoint")) || text.Contains("Changed pass"))
					{
						dtgvAcc.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
					}
				}
				return;
			}
			string text2 = DatagridviewHelper.E83E252C(dtgvAcc, B122489B, "cInfo");
			string text3 = text2;
			if (!(text3 == "Live"))
			{
				if (text3 == "Die")
				{
					dtgvAcc.Rows[B122489B].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
				}
			}
			else
			{
				dtgvAcc.Rows[B122489B].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 182);
			}
		}
		else if (B122489B == -1)
		{
			for (int j = 0; j < dtgvAcc.RowCount; j++)
			{
				string text4 = DatagridviewHelper.E83E252C(dtgvAcc, j, "cInfo");
				if (text4.Contains("Die") || text4.Contains(Language.GetValue("Checkpoint")))
				{
					dtgvAcc.Rows[j].DefaultCellStyle.ForeColor = Color.Red;
				}
			}
		}
		else
		{
			string text5 = DatagridviewHelper.E83E252C(dtgvAcc, B122489B, "cInfo");
			string text6 = text5;
			if (!(text6 == "Live") && text6 == "Die")
			{
				dtgvAcc.Rows[B122489B].DefaultCellStyle.ForeColor = Color.Red;
			}
		}
	}

	private void method_9(string DFB41D34, string string_0, int BD835C88, int int_1, DataGridView C298122D)
	{
		if (!bool_0)
		{
			DatagridviewHelper.AD3DF791(dtgvAcc, BD835C88, string_0, DFB41D34);
		}
		if (string_0 == "cInfo")
		{
			E03635AF(BD835C88);
		}
	}

	private void method_10(string string_0)
	{
		switch (string_0)
		{
		case "ToggleCheck":
		{
			for (int k = 0; k < dtgvAcc.SelectedRows.Count; k++)
			{
				int index = dtgvAcc.SelectedRows[k].Index;
				method_5(index, "cChose", !Convert.ToBoolean(method_7(index, "cChose")));
			}
			DB1232BB();
			break;
		}
		case "SelectHighline":
		{
			DataGridViewSelectedRowCollection selectedRows = dtgvAcc.SelectedRows;
			for (int j = 0; j < selectedRows.Count; j++)
			{
				method_5(selectedRows[j].Index, "cChose", true);
			}
			DB1232BB();
			break;
		}
		case "UnAll":
		{
			for (int l = 0; l < dtgvAcc.RowCount; l++)
			{
				method_5(l, "cChose", false);
			}
			DB1232BB(0);
			break;
		}
		case "All":
		{
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				method_5(i, "cChose", true);
			}
			DB1232BB(dtgvAcc.RowCount);
			break;
		}
		}
	}

	private void method_11(string ED2D7614)
	{
		if (method_12())
		{
			try
			{
				List<string> values = method_13(ED2D7614);
				Common.SetTextToClipboard(string.Join("\r\n", values));
			}
			catch
			{
			}
		}
	}

	private bool method_12()
	{
		if (method_29() == 0)
		{
			MessageBoxHelper.Show("Vui lòng chọn tài khoản muốn sử dụng chức năng này!", 3);
			return false;
		}
		return true;
	}

	private List<string> method_13(string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			List<string> list2 = string_0.Split('|').ToList();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				List<string> list3 = new List<string>();
				for (int j = 0; j < list2.Count; j++)
				{
					string text = method_7(i, list2[j]);
					if (list2[j] == "cProxy" && text.Length > 2)
					{
						if (text[text.Length - 2].ToString() == "*")
						{
							text = text.Substring(0, text.Length - 2);
						}
					}
					else if (list2[j] == "cMa2Fa")
					{
						text = Common.GetTotp(method_7(i, "cFa2"));
					}
					list3.Add(text);
				}
				list.Add(string.Join("|", list3));
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		method_10("All");
	}

	private void CD001529(object sender, EventArgs e)
	{
		method_10("SelectHighline");
	}

	private void C138102F(object sender, EventArgs e)
	{
		method_10("UnAll");
	}

	private void tokenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_11("cToken");
	}

	private void BD0F753F(object sender, EventArgs e)
	{
		method_11("cCookies");
	}

	private void uidToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_11("cUid");
	}

	private void AC3C6ABF_Click(object sender, EventArgs e)
	{
		method_11("cPassword");
	}

	private void A0957632(object sender, EventArgs e)
	{
		method_11("cUid|cPassword");
	}

	private void uidPassTokenCookieToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_11("cUid|cPassword|cToken|cCookies");
	}

	private void fBin_Load(object sender, EventArgs e)
	{
	}

	private void E907EAA8(object sender, CancelEventArgs e)
	{
		DEBD7106.DropDownItems.Clear();
		List<string> list = new List<string>();
		string text = "";
		string text2 = "";
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			text = DatagridviewHelper.E83E252C(dtgvAcc, i, "cStatus");
			if (text != "")
			{
				text2 = Regex.Match(text, "\\(IP: (.*?)\\)").Value;
				if (text2 != "")
				{
					text = text.Replace(text2, "").Trim();
				}
				text2 = Regex.Match(text, "\\[(.*?)\\]").Value;
				if (text2 != "")
				{
					text = text.Replace(text2, "").Trim();
				}
				if (text != "" && !list.Contains(text))
				{
					list.Add(text);
				}
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			DEBD7106.DropDownItems.Add(list[j]);
			DEBD7106.DropDownItems[j].Click += CC852302;
		}
		tinhTrangToolStripMenuItem.DropDownItems.Clear();
		list = new List<string>();
		for (int k = 0; k < dtgvAcc.RowCount; k++)
		{
			if (dtgvAcc.Rows[k].Cells["cInfo"].Value != null && !DatagridviewHelper.E83E252C(dtgvAcc, k, "cInfo").Equals("") && !list.Contains(DatagridviewHelper.E83E252C(dtgvAcc, k, "cInfo")))
			{
				list.Add(DatagridviewHelper.E83E252C(dtgvAcc, k, "cInfo"));
			}
		}
		for (int l = 0; l < list.Count; l++)
		{
			tinhTrangToolStripMenuItem.DropDownItems.Add(list[l]);
			tinhTrangToolStripMenuItem.DropDownItems[l].Click += method_14;
		}
	}

	private void method_14(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			string value = toolStripMenuItem.Text;
			if (DatagridviewHelper.E83E252C(dtgvAcc, i, "cInfo").Equals(value))
			{
				dtgvAcc.Rows[i].Cells["cChose"].Value = true;
			}
			else
			{
				dtgvAcc.Rows[i].Cells["cChose"].Value = false;
			}
		}
	}

	private void CC852302(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			string value = toolStripMenuItem.Text;
			if (DatagridviewHelper.E83E252C(dtgvAcc, i, "cStatus").Contains(value))
			{
				dtgvAcc.Rows[i].Cells["cChose"].Value = true;
			}
			else
			{
				dtgvAcc.Rows[i].Cells["cChose"].Value = false;
			}
		}
	}

	private void method_15()
	{
		List<string> list = new List<string>();
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				list.Add(dtgvAcc.Rows[i].Cells["cId"].Value.ToString());
			}
		}
		if (list.Count == 0)
		{
			MessageBoxHelper.Show("Vui lòng chọn tài khoản cần xóa!", 3);
			return;
		}
		if (MessageBoxHelper.smethod_1(string.Format(Language.GetValue("Bạn có thực sự muốn xóa {0} tài khoản đã chọn?"), method_29()) + "\r\n\r\n" + Language.GetValue("Chu\u0301 y\u0301: Ta\u0300i khoa\u0309n đa\u0303 xo\u0301a thi\u0300 không thê\u0309 khôi phu\u0323c la\u0323i đươ\u0323c nư\u0303a!")) == DialogResult.Yes)
		{
			if (CommonSQL.smethod_16(list, E5A8B49A: true))
			{
				for (int j = 0; j < dtgvAcc.RowCount; j++)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
					{
						dtgvAcc.Rows.RemoveAt(j--);
					}
				}
				if (CommonSQL.smethod_4())
				{
					C982320D();
				}
			}
			else
			{
				MessageBoxHelper.Show("Xóa thất bại, vui lòng thử lại sau!", 2);
			}
			method_22();
		}
		method_17();
		method_16();
	}

	private void C982320D()
	{
		E03635AF();
		method_22();
		method_17();
		method_16();
	}

	private bool A709710E(string EB807E3F)
	{
		return Common.smethod_28(EB807E3F) && !EB807E3F.StartsWith("0");
	}

	private void C43C18AB(string string_0)
	{
		Invoke((MethodInvoker)delegate
		{
			try
			{
				if (string_0 == "start")
				{
					grTimKiem.Enabled = false;
					grQuanLyThuMuc.Enabled = false;
				}
				else if (string_0 == "stop")
				{
					grTimKiem.Enabled = true;
					grQuanLyThuMuc.Enabled = true;
				}
			}
			catch (Exception)
			{
			}
		});
	}

	private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == 0 && e.RowIndex > -1)
		{
			try
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
				DB1232BB();
			}
			catch
			{
			}
		}
	}

	private void B93E501B(object sender, KeyEventArgs e)
	{
		if (e.KeyValue == 32)
		{
			method_10("ToggleCheck");
		}
	}

	private void EEA00933(int CA1234AC, string string_0)
	{
		if (!bool_0)
		{
			DatagridviewHelper.AD3DF791(dtgvAcc, CA1234AC, "cStatus", string_0);
		}
	}

	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		btnLoadAcc_Click(null, null);
	}

	private void A91E2D90(object sender, EventArgs e)
	{
		if (!bool_1 || D1AF0537.SelectedValue == null || !GClass6.B62D3203(D1AF0537.SelectedValue.ToString()) || (D1AF0537.SelectedValue.ToString() != "999999" && int_0 == D1AF0537.SelectedIndex))
		{
			return;
		}
		string text = D1AF0537.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-1"))
		{
			if (!(text2 == "999999"))
			{
				A30E820B(DE848412());
			}
			else
			{
				Common.smethod_16(new fChonThuMuc(bool_2: true));
				if (!fChonThuMuc.bool_1 || fChonThuMuc.F5BA2A9C == null || fChonThuMuc.F5BA2A9C.Count == 0)
				{
					bool_1 = false;
					D1AF0537.SelectedIndex = ((int_0 != -1) ? int_0 : 0);
					bool_1 = true;
				}
				else
				{
					A30E820B(fChonThuMuc.F5BA2A9C);
				}
			}
		}
		else
		{
			A30E820B();
		}
		int_0 = D1AF0537.SelectedIndex;
	}

	private void E3AA4AA5(object sender, EventArgs e)
	{
		method_11("cEmail|cPassMail");
	}

	private void C22983AA_Click(object sender, EventArgs e)
	{
		method_11("cUid|cPassword|cToken|cCookies|cEmail|cPassMail");
	}

	private void method_16()
	{
		int num = 0;
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				num++;
			}
		}
		try
		{
			B088C79D.Text = num.ToString();
		}
		catch
		{
		}
	}

	private void checkAvatarToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void method_17()
	{
		try
		{
			lblCountTotal.Text = dtgvAcc.Rows.Count.ToString();
		}
		catch
		{
		}
	}

	private void B30D493C(object sender, EventArgs e)
	{
		Application.Idle -= B30D493C;
		method_1();
		D7A0F89C();
		A30E820B();
	}

	private void D7A0F89C()
	{
		bool_1 = false;
		DataTable dataSource = CommonSQL.smethod_1(FF01A51F: true);
		D1AF0537.DataSource = dataSource;
		D1AF0537.ValueMember = "id";
		D1AF0537.DisplayMember = "name";
		bool_1 = true;
	}

	private void A30E820B(List<string> list_3 = null)
	{
		try
		{
			DataTable dataSource = CommonSQL.smethod_6(list_3, bool_0: false);
			A0203D34.DataSource = dataSource;
			A0203D34.ValueMember = "id";
			A0203D34.DisplayMember = "name";
		}
		catch
		{
		}
	}

	private void method_18(int int_1)
	{
		int int_2 = 0;
		int int_3 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		string C73C8736 = SettingsTool.GetSettings("configGeneral").GetValue("token");
		CA2F94BD = false;
		new Thread((ThreadStart)delegate
		{
			C43C18AB("start");
			switch (int_1)
			{
			case 0:
			{
				int num4 = 0;
				while (num4 < dtgvAcc.Rows.Count && !CA2F94BD)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num4].Cells["cChose"].Value))
					{
						if (int_2 < int_3)
						{
							Interlocked.Increment(ref int_2);
							int int_5 = num4++;
							new Thread((ThreadStart)delegate
							{
								method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", int_5, 0, dtgvAcc);
								EBBE493F(int_5, C73C8736);
								Interlocked.Decrement(ref int_2);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num4++;
					}
				}
				break;
			}
			case 1:
			{
				int num6 = 0;
				while (num6 < dtgvAcc.Rows.Count && !CA2F94BD)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num6].Cells["cChose"].Value))
					{
						if (int_2 < int_3)
						{
							Interlocked.Increment(ref int_2);
							int int_4 = num6++;
							new Thread((ThreadStart)delegate
							{
								method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", int_4, 0, dtgvAcc);
								F28D8489(int_4);
								Interlocked.Decrement(ref int_2);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num6++;
					}
				}
				break;
			}
			case 2:
			{
				int num2 = 0;
				while (num2 < dtgvAcc.Rows.Count && !CA2F94BD)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						if (int_2 < int_3)
						{
							Interlocked.Increment(ref int_2);
							int E91405A2 = num2++;
							new Thread((ThreadStart)delegate
							{
								method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", E91405A2, 0, dtgvAcc);
								method_21(E91405A2);
								Interlocked.Decrement(ref int_2);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num2++;
					}
				}
				break;
			}
			case 3:
			{
				int num5 = 0;
				while (num5 < dtgvAcc.Rows.Count && !CA2F94BD)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num5].Cells["cChose"].Value))
					{
						if (int_2 < int_3)
						{
							Interlocked.Increment(ref int_2);
							int A18D7485 = num5++;
							new Thread((ThreadStart)delegate
							{
								method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", A18D7485, 0, dtgvAcc);
								C4212539(A18D7485);
								Interlocked.Decrement(ref int_2);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num5++;
					}
				}
				break;
			}
			case 4:
			{
				int num3 = 0;
				while (num3 < dtgvAcc.Rows.Count && !CA2F94BD)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num3].Cells["cChose"].Value))
					{
						if (int_2 < int_3)
						{
							Interlocked.Increment(ref int_2);
							int int_6 = num3++;
							new Thread((ThreadStart)delegate
							{
								method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", int_6, 0, dtgvAcc);
								method_20(int_6);
								Interlocked.Decrement(ref int_2);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num3++;
					}
				}
				break;
			}
			case 5:
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count && !CA2F94BD)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (int_2 < int_3)
						{
							Interlocked.Increment(ref int_2);
							int int_7 = num++;
							new Thread((ThreadStart)delegate
							{
								method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", int_7, 0, dtgvAcc);
								method_19(int_7);
								Interlocked.Decrement(ref int_2);
							}).Start();
						}
						else
						{
							Application.DoEvents();
							Thread.Sleep(200);
						}
					}
					else
					{
						num++;
					}
				}
				break;
			}
			}
			int tickCount = Environment.TickCount;
			while (int_2 > 0 && Environment.TickCount - tickCount <= 60000)
			{
				Common.DelayTime(1.0);
			}
			C43C18AB("stop");
		}).Start();
	}

	private void method_19(int row)
	{
		try
		{
			string text = method_7(row, "cId");
			string text2 = method_7(row, "cUid");
			if (!A709710E(text2))
			{
				method_4(row, Language.GetValue("Uid không hợp lệ!"));
				return;
			}
			string text3 = "";
			string text4 = PhoneFarmLib.Common.CheckInfoUid(text2);
			if (text4.StartsWith("0|"))
			{
				if (EA98BF20.CheckLiveWall(text2).StartsWith("0|"))
				{
					method_4(row, Language.GetValue("Tài khoản Die!"));
					AF3E1011(row, "Die");
				}
				else
				{
					method_4(row, Language.GetValue("Không check đươ\u0323c!"));
				}
			}
			else if (text4.StartsWith("1|"))
			{
				string[] array = text4.Split('|');
				string text5 = array[2];
				string text6 = array[3].ToLower();
				string text7 = array[4];
				string text8 = array[5];
				string text9 = array[6];
				CommonSQL.smethod_9(text, "name|gender|friends|groups", text5 + "|" + text6 + "|" + text8 + "|" + text9);
				method_5(row, "cName", text5);
				method_5(row, "cGender", text6);
				method_5(row, "cFriend", text8);
				method_5(row, "cGroup", text9);
				if (text7 != "")
				{
					method_5(row, "cBirthday", text7);
					CommonSQL.UpdateFieldToAccount(text, "birthday", text7);
				}
				AF3E1011(row, "Live");
				text3 = Language.GetValue("Câ\u0323p nhâ\u0323t thông tin tha\u0300nh công!");
				method_4(row, text3);
			}
			else
			{
				method_4(row, Language.GetValue("Không check đươ\u0323c!"));
			}
		}
		catch
		{
			method_4(row, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void method_20(int int_1)
	{
		try
		{
			string text = "";
			string text2 = "";
			text = dtgvAcc.Rows[int_1].Cells["cEmail"].Value.ToString();
			text2 = dtgvAcc.Rows[int_1].Cells["cPassMail"].Value.ToString();
			if (text == "" || text2 == "")
			{
				method_4(int_1, Language.GetValue("Không tìm thấy mail!"));
			}
			else if (ImapHelper.CheckConnectImap(text, text2))
			{
				method_4(int_1, Language.GetValue("Tài khoản mail: live!"));
			}
			else
			{
				method_4(int_1, Language.GetValue("Tài khoản mail: die!"));
			}
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show(ex.ToString());
			method_4(int_1, Language.GetValue("Lỗi!"));
		}
	}

	private void EBBE493F(int int_1, string string_0)
	{
		try
		{
			method_7(int_1, "cId");
			string text = method_7(int_1, "cUid");
			if (!A709710E(text))
			{
				method_4(int_1, Language.GetValue("Uid không hợp lệ!"));
				return;
			}
			string text2 = "";
			string text3 = "";
			string text4 = EA98BF20.CheckLiveWall(text);
			if (text4.StartsWith("0|"))
			{
				text2 = "Die";
				text3 = "Wall die";
			}
			else if (text4.StartsWith("1|"))
			{
				text2 = "Live";
				text3 = "Wall live";
			}
			else
			{
				text3 = Language.GetValue("Không check đươ\u0323c!");
			}
			method_4(int_1, text3);
			if (text2 != "")
			{
				AF3E1011(int_1, text2);
			}
		}
		catch
		{
			method_4(int_1, Language.GetValue("Không check đươ\u0323c!"));
		}
	}

	private void F28D8489(int int_1)
	{
		try
		{
			string text = "";
			DatagridviewHelper.E83E252C(dtgvAcc, int_1, "cId");
			string string_ = DatagridviewHelper.E83E252C(dtgvAcc, int_1, "cCookies");
			string f008840C = DatagridviewHelper.E83E252C(dtgvAcc, int_1, "cToken");
			string d = DatagridviewHelper.E83E252C(dtgvAcc, int_1, "cUseragent");
			string text2 = "";
			int num = 0;
			if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 9)
			{
				text2 = method_7(int_1, "cProxy");
				num = (text2.EndsWith("*1") ? 1 : 0);
				if (text2.EndsWith("*0") || text2.EndsWith("*1"))
				{
					text2 = text2.Substring(0, text2.Length - 2);
				}
			}
			string text3 = "";
			if (!EA98BF20.D90D78B1(string_, f008840C, d, text2, num))
			{
				text3 = "Token die";
			}
			else
			{
				text = "Live";
				text3 = "Token live";
			}
			method_9(text3, "cStatus", int_1, 2, dtgvAcc);
			if (text != "")
			{
				AF3E1011(int_1, text);
			}
		}
		catch
		{
			method_9(Language.GetValue("Không check đươ\u0323c!"), "cStatus", int_1, 2, dtgvAcc);
		}
	}

	private void method_21(int CD87D21C)
	{
		try
		{
			string text = "";
			DatagridviewHelper.E83E252C(dtgvAcc, CD87D21C, "cId");
			string a42479BB = DatagridviewHelper.E83E252C(dtgvAcc, CD87D21C, "cCookies");
			string string_ = DatagridviewHelper.E83E252C(dtgvAcc, CD87D21C, "cUseragent");
			string text2 = "";
			int num = 0;
			if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 9)
			{
				text2 = method_7(CD87D21C, "cProxy");
				num = (text2.EndsWith("*1") ? 1 : 0);
				if (text2.EndsWith("*0") || text2.EndsWith("*1"))
				{
					text2 = text2.Substring(0, text2.Length - 2);
				}
			}
			string text3 = "";
			if (!EA98BF20.smethod_3(a42479BB, string_, text2, num).StartsWith("1|"))
			{
				text3 = "Cookie die";
			}
			else
			{
				text = "Live";
				text3 = "Cookie live";
			}
			method_9(text3, "cStatus", CD87D21C, 2, dtgvAcc);
			if (text != "")
			{
				AF3E1011(CD87D21C, text);
			}
		}
		catch
		{
			method_9(Language.GetValue("Không check đươ\u0323c!"), "cStatus", CD87D21C, 2, dtgvAcc);
		}
	}

	private void C4212539(int int_1)
	{
		string f037F2B = dtgvAcc.Rows[int_1].Cells["cId"].Value.ToString();
		string string_ = dtgvAcc.Rows[int_1].Cells["cUid"].Value.ToString();
		string string_2 = dtgvAcc.Rows[int_1].Cells["cPassword"].Value.ToString();
		DatagridviewHelper.E83E252C(dtgvAcc, int_1, "cUseragent");
		string text = "";
		int num = 0;
		if (SettingsTool.GetSettings("configGeneral").method_0("ip_iTypeChangeIp") == 9)
		{
			text = method_7(int_1, "cProxy");
			num = (text.EndsWith("*1") ? 1 : 0);
			if (text.EndsWith("*0") || text.EndsWith("*1"))
			{
				text = text.Substring(0, text.Length - 2);
			}
		}
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = EA98BF20.D42B7486(string_, string_2, "", text, num);
		switch (text5.Split('|')[0])
		{
		case "3":
			text2 = "Changed pass";
			break;
		case "2":
			text2 = ((!(text5.Split('|')[1].Trim() != "")) ? Language.GetValue("Checkpoint") : ("Checkpoint: " + text5.Split('|')[1]));
			break;
		case "1":
			text4 = text5.Split('|')[1];
			text2 = "Live";
			break;
		case "5":
			text3 = Language.GetValue("Không check đươ\u0323c (Co\u0301 2fa)!");
			break;
		case "0":
		case "4":
			text3 = Language.GetValue("Không check đươ\u0323c!");
			break;
		}
		if (text3 == "")
		{
			text3 = Language.GetValue("Đa\u0303 check xong!");
		}
		if (text4 != "")
		{
			CommonSQL.UpdateFieldToAccount(f037F2B, "cookie1", text4);
			method_9(text4, "cCookies", int_1, 1, dtgvAcc);
		}
		if (text2 != "")
		{
			AF3E1011(int_1, text2);
		}
		method_9(text3, "cStatus", int_1, 1, dtgvAcc);
	}

	private void DEB7FE26_Click(object sender, EventArgs e)
	{
		method_18(0);
	}

	private void C834A7BE_Click(object sender, EventArgs e)
	{
		if (MessageBoxHelper.smethod_1("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?") == DialogResult.Yes)
		{
			method_18(1);
		}
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		method_18(2);
	}

	private void AD8718B1(object sender, EventArgs e)
	{
		method_18(3);
	}

	private void mailToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_11("cEmail");
	}

	private void BtnSearch_Click(object sender, EventArgs e)
	{
		try
		{
			if (cbbSearch.SelectedIndex == -1)
			{
				MessageBoxHelper.Show("Vui lòng chọn kiểu tìm kiếm!");
				return;
			}
			string columnName = cbbSearch.SelectedValue.ToString();
			string text = txbSearch.Text.Trim();
			if (text == "")
			{
				MessageBoxHelper.Show("Vui lòng nhập nội dung tìm kiếm!");
				return;
			}
			List<int> list = new List<int>();
			text = Common.A8AF5A8E(text.ToLower());
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				string text2 = dtgvAcc.Rows[i].Cells[columnName].Value.ToString();
				text2 = Common.A8AF5A8E(text2.ToLower());
				text = Common.A8AF5A8E(text.ToLower());
				if (text2.Contains(text))
				{
					list.Add(i);
				}
			}
			int index = 0;
			if (list.Count <= 0)
			{
				return;
			}
			int index2 = dtgvAcc.CurrentRow.Index;
			if (index2 >= list[list.Count - 1])
			{
				index = 0;
			}
			else
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (index2 < list[j])
					{
						index = j;
						break;
					}
				}
			}
			int index3 = list[index];
			dtgvAcc.CurrentCell = dtgvAcc.Rows[index3].Cells[columnName];
			dtgvAcc.ClearSelection();
			dtgvAcc.Rows[index3].Selected = true;
		}
		catch
		{
		}
	}

	private void uidPassTokenCookieMailPassMail2faToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_11("cUid|cPassword|cToken|cCookies|cEmail|cPassMail|cFa2");
	}

	private void method_22()
	{
		for (int i = 0; i < dtgvAcc.RowCount; i++)
		{
			DatagridviewHelper.AD3DF791(dtgvAcc, i, "cSTT", i + 1);
		}
	}

	private void BA10268A(object sender, EventArgs e)
	{
		method_11("cFa2");
	}

	private void B013A48C(object sender, EventArgs e)
	{
		if (MessageBoxHelper.smethod_1(string.Format(Language.GetValue("Bạn có chắc muốn xóa Profile của {0} tài khoản?"), method_29())) != DialogResult.Yes)
		{
			return;
		}
		int int_0 = 0;
		int EE24BB96 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < EE24BB96)
					{
						Interlocked.Increment(ref int_0);
						int AD29B7AC = num++;
						new Thread((ThreadStart)delegate
						{
							method_9(Language.GetValue("Đang xo\u0301a profile..."), "cStatus", AD29B7AC, 0, dtgvAcc);
							method_23(AD29B7AC);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_23(int int_1)
	{
		try
		{
			string f037F2B = dtgvAcc.Rows[int_1].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_1].Cells["cUid"].Value.ToString();
			if (text.Trim() == "")
			{
				method_9(Language.GetValue("Chưa tạo profile!"), "cStatus", int_1, 0, dtgvAcc);
				return;
			}
			string path = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text;
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
				method_9(Language.GetValue("Xóa profile thành công!"), "cStatus", int_1, 0, dtgvAcc);
				method_9("No", "cProfile", int_1, 0, dtgvAcc);
				CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "No");
			}
			else
			{
				method_9(Language.GetValue("Chưa tạo profile!"), "cStatus", int_1, 0, dtgvAcc);
			}
		}
		catch
		{
			method_9(Language.GetValue("Xóa profile thất bại!"), "cStatus", int_1, 0, dtgvAcc);
		}
	}

	private void BA9F0881(object sender, EventArgs e)
	{
		int BE3D1C0E = 0;
		int int_0 = 10;
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (BE3D1C0E < int_0)
					{
						Interlocked.Increment(ref BE3D1C0E);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							method_9(Language.GetValue("Đang check profile..."), "cStatus", int_, 0, dtgvAcc);
							B482E004(int_);
							Interlocked.Decrement(ref BE3D1C0E);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void B482E004(int int_1)
	{
		try
		{
			string f037F2B = dtgvAcc.Rows[int_1].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_1].Cells["cUid"].Value.ToString();
			string path = SettingsTool.GetSettings("configGeneral").GetValue("txbPathProfile") + "\\" + text;
			if (Directory.Exists(path))
			{
				method_9(Language.GetValue("Đã có profile!"), "cStatus", int_1, 0, dtgvAcc);
				method_9("Yes", "cProfile", int_1, 0, dtgvAcc);
				CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "Yes");
			}
			else
			{
				method_9(Language.GetValue("Chưa tạo profile!"), "cStatus", int_1, 0, dtgvAcc);
				method_9("No", "cProfile", int_1, 0, dtgvAcc);
				CommonSQL.UpdateFieldToAccount(f037F2B, "profile", "No");
			}
		}
		catch
		{
		}
	}

	private void F18C8195(object sender, EventArgs e)
	{
		try
		{
			Common.smethod_16(new fClearProfile());
		}
		catch (Exception ex)
		{
			MessageBoxHelper.Show(ex.ToString(), 3);
		}
	}

	public void method_24(string string_0)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
		}
		catch
		{
		}
	}

	private void C3160B89_DoubleClick(object sender, EventArgs e)
	{
		method_24("Chrome");
	}

	private void D0102436(object sender, EventArgs e)
	{
		method_11("cUid|cPassword|cFa2");
	}

	private void FF8DB61B(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list.Add(method_7(i, "cUid") + "|" + method_7(i, "cPassword") + "|" + method_7(i, "cToken") + "|" + method_7(i, "cCookies") + "|" + method_7(i, "cEmail") + "|" + method_7(i, "cPassMail") + "|" + method_7(i, "cFa2") + "|" + method_7(i, "cUseragent") + "|" + method_7(i, "cProxy").Split('*')[0] + "|" + method_7(i, "cName") + "|" + method_7(i, "cGender") + "|" + method_7(i, "cFollow") + "|" + method_7(i, "cFriend") + "|" + method_7(i, "cGroup") + "|" + method_7(i, "cBirthday") + "|" + method_7(i, "cDateCreateAcc") + "|" + method_7(i, "cGhiChu") + "|" + method_7(i, "cMailRecovery") + "|" + method_7(i, "cInteractEnd"));
				}
			}
			if (list.Count <= 0)
			{
				MessageBoxHelper.Show("Vui lòng chọn danh sách tài khoản muốn copy thông tin!", 3);
			}
			else
			{
				Common.smethod_16(new fCopy(list));
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "Error Copy");
		}
	}

	private void B33D0907(object sender, EventArgs e)
	{
		method_11("cMa2Fa");
	}

	private void DEBD7106_Click(object sender, EventArgs e)
	{
	}

	private void method_25(object sender, EventArgs e)
	{
		int int_0 = 0;
		int C8331EB2 = 10;
		new Thread((ThreadStart)delegate
		{
			try
			{
				int num = 0;
				while (num < dtgvAcc.Rows.Count)
				{
					if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						if (int_0 < C8331EB2)
						{
							Interlocked.Increment(ref int_0);
							int C19D568B = num++;
							new Thread((ThreadStart)delegate
							{
								try
								{
									string input = DatagridviewHelper.E83E252C(dtgvAcc, C19D568B, "cCookies");
									string text = DatagridviewHelper.E83E252C(dtgvAcc, C19D568B, "cUid");
									if (text == "")
									{
										text = Regex.Match(input, "c_user=(\\d+)").Groups[1].Value;
									}
									if (File.Exists("backup\\" + text + "\\" + text + ".html"))
									{
										Process.Start(Path.GetDirectoryName(Application.ExecutablePath) + "\\backup\\" + text + "\\" + text + ".html");
									}
									else
									{
										DatagridviewHelper.AD3DF791(dtgvAcc, C19D568B, "cStatus", Language.GetValue("Chưa tạo html!"));
									}
									Interlocked.Decrement(ref int_0);
								}
								catch (Exception ex2)
								{
									Common.smethod_43(null, ex2.ToString());
								}
							}).Start();
						}
						else
						{
							Common.DelayTime(1.0);
						}
					}
					else
					{
						num++;
					}
				}
				while (int_0 > 0)
				{
					Common.DelayTime(1.0);
				}
			}
			catch (Exception ex)
			{
				Common.smethod_43(null, ex.ToString());
			}
		}).Start();
	}

	private void method_26(object sender, EventArgs e)
	{
		string text = "";
		using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
		{
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
			{
				return;
			}
			text = folderBrowserDialog.SelectedPath;
		}
		int num = 0;
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			try
			{
				if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				string text2 = dtgvAcc.Rows[i].Cells["cUid"].Value.ToString();
				try
				{
					if (File.Exists("backup\\" + text2 + "\\" + text2 + ".html"))
					{
						File.Copy("backup\\" + text2 + "\\" + text2 + ".html", text + "\\" + text2 + ".html");
						num++;
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		MessageBoxHelper.Show(string.Format(Language.GetValue("Copy thành công {0} tệp backup html!"), num));
	}

	private void D3895F01(object sender, EventArgs e)
	{
		string text = "";
		using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
		{
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult != DialogResult.OK || string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
			{
				return;
			}
			text = folderBrowserDialog.SelectedPath;
		}
		int num = 0;
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			try
			{
				if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					continue;
				}
				string text2 = dtgvAcc.Rows[i].Cells["cUid"].Value.ToString();
				try
				{
					if (!Directory.Exists(text + "\\" + text2))
					{
						Directory.CreateDirectory(text + "\\" + text2);
					}
					string[] files = Directory.GetFiles("backup\\" + text2);
					for (int j = 0; j < files.Length; j++)
					{
						File.Copy(files[j], text + "\\" + text2 + "\\" + Path.GetFileName(files[j]));
					}
					num++;
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		MessageBoxHelper.Show(string.Format(Language.GetValue("Copy thành công {0} thư mục backup!"), num));
	}

	private void EA0F6F19(object sender, DataGridViewSortCompareEventArgs e)
	{
		try
		{
			List<string> list = new List<string> { "cStt", "cFriend", "cGroup", "cFollow" };
			string text = e.CellValue1.ToString().Trim();
			string text2 = e.CellValue2.ToString().Trim();
			if (text == "" || text2 == "")
			{
				e.SortResult = text.CompareTo(text2);
			}
			else if (list.Contains(e.Column.Name))
			{
				if (!Common.smethod_28(text))
				{
					text = ((text != "") ? "-1" : "-2");
				}
				if (!Common.smethod_28(text2))
				{
					text2 = ((text2 != "") ? "-1" : "-2");
				}
				e.SortResult = int.Parse(text).CompareTo(int.Parse(text2));
			}
			else if (e.Column.Name == "cInteractEnd")
			{
				e.SortResult = Common.F11F4A37(text).CompareTo(Common.F11F4A37(text2));
			}
			else if (e.Column.Name == "cDateDelete")
			{
				e.SortResult = Common.F11F4A37(text, "HH:mm:ss dd/MM/yyyy").CompareTo(Common.F11F4A37(text2, "HH:mm:ss dd/MM/yyyy"));
			}
			else if (e.Column.Name == "cStatus")
			{
				string text3 = "";
				string text4 = "";
				text3 = ((!text.StartsWith("(")) ? text : text.Substring(text.IndexOf(")") + 1).Trim());
				text4 = ((!text2.StartsWith("(")) ? text2 : text2.Substring(text2.IndexOf(")") + 1).Trim());
				e.SortResult = text3.CompareTo(text4);
			}
			else if (e.Column.Name == "cBirthday")
			{
				e.SortResult = Common.F11F4A37(text, "M/d/yyyy").CompareTo(Common.F11F4A37(text2, "M/d/yyyy"));
			}
			else if (e.Column.Name == "cDateCreateAcc")
			{
				e.SortResult = Common.F11F4A37(text, "dd/MM/yyyy h:mm:ss tt").CompareTo(Common.F11F4A37(text2, "dd/MM/yyyy h:mm:ss tt"));
			}
			else
			{
				e.SortResult = text.CompareTo(text2);
			}
		}
		catch (Exception)
		{
			e.SortResult = 0;
		}
		e.Handled = true;
	}

	private void toolStripMenuItem_8_Click(object sender, EventArgs e)
	{
		Common.smethod_16(new fCauHinhHienThi());
		method_1();
	}

	private void checkProxyToolStripMenuItem_Click(object sender, EventArgs e)
	{
		int B73A0B32 = 0;
		int int_0 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		CA2F94BD = false;
		new Thread((ThreadStart)delegate
		{
			C43C18AB("start");
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				Application.DoEvents();
				if (CA2F94BD)
				{
					break;
				}
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (B73A0B32 < int_0)
					{
						Interlocked.Increment(ref B73A0B32);
						int int_ = num++;
						new Thread((ThreadStart)delegate
						{
							method_9(Language.GetValue("Đang kiểm tra..."), "cStatus", int_, 0, dtgvAcc);
							method_27(int_);
							Interlocked.Decrement(ref B73A0B32);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
			int tickCount = Environment.TickCount;
			while (B73A0B32 > 0 && Environment.TickCount - tickCount <= 30000)
			{
				Application.DoEvents();
				Thread.Sleep(300);
			}
			C43C18AB("stop");
		}).Start();
	}

	private void method_27(int B91E131E)
	{
		try
		{
			string text = dtgvAcc.Rows[B91E131E].Cells["cProxy"].Value.ToString();
			int b03CE = 0;
			if (text.EndsWith("*1"))
			{
				b03CE = 1;
			}
			text = text.Substring(0, text.Length - 2);
			int num = 0;
			int num2 = 0;
			string text2 = "";
			bool flag = false;
			for (int i = 0; i < 10; i++)
			{
				text2 = Common.CheckProxy(text, b03CE);
				if (text2 != "")
				{
					num++;
					if (num == 3)
					{
						flag = true;
						break;
					}
				}
				else
				{
					num2++;
					if (num2 == 3)
					{
						break;
					}
				}
			}
			if (!flag)
			{
				method_9("Proxy Die!", "cStatus", B91E131E, 2, dtgvAcc);
			}
			else
			{
				method_9("Proxy Live!", "cStatus", B91E131E, 2, dtgvAcc);
			}
		}
		catch
		{
			method_9(Language.GetValue("Lỗi!!!"), "cStatus", B91E131E, 2, dtgvAcc);
		}
	}

	private void DCA1D0BD_Click(object sender, EventArgs e)
	{
		method_11("cUseragent");
	}

	private void D4240F0F(object sender, EventArgs e)
	{
		method_11("cProxy");
	}

	private void method_28(object sender, EventArgs e)
	{
		for (int i = 0; i < dtgvAcc.Rows.Count; i++)
		{
			if (CA2F94BD)
			{
				break;
			}
			if (!Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
			{
				continue;
			}
			string text = "backup\\" + DatagridviewHelper.E83E252C(dtgvAcc, i, "cUid");
			if (Directory.Exists(text))
			{
				try
				{
					Process.Start(text);
					EEA00933(i, Language.GetValue("Mở thành công!"));
				}
				catch
				{
					EEA00933(i, Language.GetValue("Mở thất bại!"));
				}
			}
			else
			{
				EEA00933(i, Language.GetValue("Chưa backup!"));
			}
		}
	}

	private void A639D2BE(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Alt)
		{
			try
			{
				Process.Start(Path.GetDirectoryName(Application.ExecutablePath));
			}
			catch
			{
			}
		}
	}

	private void F3A8F22D(object sender, EventArgs e)
	{
		if (!bool_2 || A0203D34.SelectedValue == null || !GClass6.B62D3203(A0203D34.SelectedValue.ToString()) || (A0203D34.SelectedValue.ToString() != "-1" && FBBA83AE == A0203D34.SelectedIndex))
		{
			return;
		}
		string text = D1AF0537.SelectedValue.ToString();
		string text2 = text;
		if (!(text2 == "-1"))
		{
			if (!(text2 == "999999"))
			{
				DF2BE010(DE848412(), A0203D34.Text);
			}
			else
			{
				DF2BE010(fChonThuMuc.F5BA2A9C, A0203D34.Text);
			}
		}
		else
		{
			DF2BE010(null, A0203D34.Text);
		}
		FBBA83AE = A0203D34.SelectedIndex;
	}

	private void B0A895BB(object sender, EventArgs e)
	{
		method_15();
	}

	private void A3B974BA(object sender, EventArgs e)
	{
		method_18(4);
	}

	public int method_29()
	{
		int num = 0;
		try
		{
			for (int i = 0; i < dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					num++;
				}
			}
		}
		catch
		{
		}
		return num;
	}

	private void F8950C13(object sender, EventArgs e)
	{
		if (MessageBoxHelper.smethod_1(string.Format(Language.GetValue("Bạn có chắc muốn xóa dữ liệu backup của {0} tài khoản?"), method_29())) != DialogResult.Yes)
		{
			return;
		}
		int AA8521A4 = 0;
		int B6826F94 = SettingsTool.GetSettings("configGeneral").method_0("nudHideThread", 10);
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (AA8521A4 < B6826F94)
					{
						Interlocked.Increment(ref AA8521A4);
						int int_0 = num++;
						new Thread((ThreadStart)delegate
						{
							method_9(Language.GetValue("Đang xo\u0301a dữ liệu backup..."), "cStatus", int_0, 0, dtgvAcc);
							method_30(int_0);
							Interlocked.Decrement(ref AA8521A4);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void method_30(int int_1)
	{
		try
		{
			string f037F2B = dtgvAcc.Rows[int_1].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_1].Cells["cUid"].Value.ToString();
			if (text.Trim() == "")
			{
				method_9(Language.GetValue("Chưa backup!"), "cStatus", int_1, 0, dtgvAcc);
				return;
			}
			string path = "backup\\" + text;
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
				method_9(Language.GetValue("Xóa dữ liệu backup thành công!"), "cStatus", int_1, 0, dtgvAcc);
				method_9("", "cBackup", int_1, 0, dtgvAcc);
				CommonSQL.UpdateFieldToAccount(f037F2B, "backup", "");
			}
			else
			{
				method_9(Language.GetValue("Chưa backup!"), "cStatus", int_1, 0, dtgvAcc);
			}
		}
		catch
		{
			method_9(Language.GetValue("Xóa dữ liệu backup thất bại!"), "cStatus", int_1, 0, dtgvAcc);
		}
	}

	private void B021F206(object sender, EventArgs e)
	{
		int int_0 = 0;
		int int_1 = 10;
		string string_0 = SettingsTool.AC3A549C();
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			while (num < dtgvAcc.Rows.Count)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[num].Cells["cChose"].Value))
				{
					if (int_0 < int_1)
					{
						Interlocked.Increment(ref int_0);
						int D8A9919E = num++;
						new Thread((ThreadStart)delegate
						{
							method_4(D8A9919E, Language.GetValue("Đang check backup..."));
							AF0B0BA6(D8A9919E, string_0);
							Interlocked.Decrement(ref int_0);
						}).Start();
					}
					else
					{
						Application.DoEvents();
						Thread.Sleep(200);
					}
				}
				else
				{
					num++;
				}
			}
		}).Start();
	}

	private void AF0B0BA6(int int_1, string C71C2AB4)
	{
		try
		{
			string f037F2B = dtgvAcc.Rows[int_1].Cells["cId"].Value.ToString();
			string text = dtgvAcc.Rows[int_1].Cells["cUid"].Value.ToString();
			C71C2AB4 = C71C2AB4 + "\\" + text + "\\" + text + ".txt";
			if (File.Exists(C71C2AB4))
			{
				method_4(int_1, Language.GetValue("Đã backup!"));
				method_5(int_1, "cBackup", Common.smethod_8(C71C2AB4));
				CommonSQL.UpdateFieldToAccount(f037F2B, "backup", Common.smethod_8(C71C2AB4));
			}
			else
			{
				method_4(int_1, Language.GetValue("Chưa backup!"));
				method_5(int_1, "cBackup", "");
				CommonSQL.UpdateFieldToAccount(f037F2B, "backup", "");
			}
		}
		catch
		{
		}
	}

	private void EE0B0639_Click(object sender, EventArgs e)
	{
		method_18(5);
	}

	private void F80C9C82_Click(object sender, EventArgs e)
	{
		method_31();
	}

	private void method_31()
	{
		if (method_29() == 0)
		{
			MessageBoxHelper.Show("Vui lo\u0300ng cho\u0323n ta\u0300i khoa\u0309n câ\u0300n khôi phu\u0323c!", 3);
			return;
		}
		Common.smethod_16(new fCauHinhKhoiPhucTaiKhoan());
		if (fCauHinhKhoiPhucTaiKhoan.bool_0)
		{
			try
			{
				if (fCauHinhKhoiPhucTaiKhoan.A01AC2AD == 0)
				{
					List<string> list = new List<string>();
					List<string> list2 = new List<string>();
					for (int i = 0; i < dtgvAcc.RowCount; i++)
					{
						if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
						{
							string text = DatagridviewHelper.E83E252C(dtgvAcc, i, "cId");
							string item = CommonSQL.E611AAB1(text);
							list.Add(text);
							list2.Add(item);
							dtgvAcc.Rows.RemoveAt(i--);
						}
					}
					method_22();
					CommonSQL.AD1D743A(list2, "active", "1");
					if (CommonSQL.FE347784(list, "active", "1"))
					{
						MessageBoxHelper.Show(string.Format(Language.GetValue("Đa\u0303 khôi phu\u0323c tha\u0300nh công {0} ta\u0300i khoa\u0309n!"), list.Count));
					}
					else
					{
						MessageBoxHelper.Show("Lô\u0303i khôi phu\u0323c ta\u0300i khoa\u0309n, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
					}
				}
				else
				{
					string f = fCauHinhKhoiPhucTaiKhoan.F6371800;
					List<string> list3 = new List<string>();
					for (int j = 0; j < dtgvAcc.RowCount; j++)
					{
						if (Convert.ToBoolean(dtgvAcc.Rows[j].Cells["cChose"].Value))
						{
							string item2 = DatagridviewHelper.E83E252C(dtgvAcc, j, "cId");
							list3.Add(item2);
							dtgvAcc.Rows.RemoveAt(j--);
						}
					}
					method_22();
					if (CommonSQL.FE347784(list3, "idFile", f) && CommonSQL.FE347784(list3, "active", "1"))
					{
						MessageBoxHelper.Show(string.Format(Language.GetValue("Đa\u0303 khôi phu\u0323c tha\u0300nh công {0} ta\u0300i khoa\u0309n!"), list3.Count));
					}
					else
					{
						MessageBoxHelper.Show("Lô\u0303i khôi phu\u0323c ta\u0300i khoa\u0309n, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
					}
				}
			}
			catch (Exception exception_)
			{
				Common.ExportError(null, exception_, "Khoi Phuc Tai Khoan");
			}
		}
		method_17();
		method_16();
	}

	private void D03ADA1C_Click(object sender, EventArgs e)
	{
		method_15();
	}

	private void A607580A_Click(object sender, EventArgs e)
	{
		method_31();
	}

	public List<string> ADA30B2D()
	{
		List<string> list = new List<string>();
		try
		{
			if (SettingsTool.GetSettings("configGeneral").method_0("typeApiTinsoft") == 0)
			{
				RequestXNet b01F5C = new RequestXNet("", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)", "", 0);
				string json = b01F5C.RequestGet("http://proxy.tinsoftsv.com/api/getUserKeys.php?key=" + SettingsTool.GetSettings("configGeneral").GetValue("txtApiUser"));
				JObject jObject = JObject.Parse(json);
				foreach (JToken item in (IEnumerable<JToken>)(jObject["data"]!))
				{
					if (Convert.ToBoolean(item["success"]!.ToString()))
					{
						list.Add(item["key"]!.ToString());
					}
				}
			}
			else
			{
				List<string> list2 = SettingsTool.GetSettings("configGeneral").EC378D8A("txtApiProxy");
				foreach (string item2 in list2)
				{
					if (A4AF3582.smethod_0(item2))
					{
						list.Add(item2);
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	private void dtgvAcc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		try
		{
			if (e.RowIndex > -1)
			{
				dtgvAcc.CurrentRow.Cells["cChose"].Value = !Convert.ToBoolean(dtgvAcc.CurrentRow.Cells["cChose"].Value);
				DB1232BB();
			}
		}
		catch
		{
		}
	}

	private void EE2AB393_Click(object sender, EventArgs e)
	{
	}

	private void EB08C73B_Click(object sender, EventArgs e)
	{
		fLocTheoDanhSachUid fLocTheoDanhSachUid2 = new fLocTheoDanhSachUid();
		Common.smethod_16(fLocTheoDanhSachUid2);
		if (fLocTheoDanhSachUid2.list_0.Count > 0)
		{
			List<string> list = Common.smethod_11(fLocTheoDanhSachUid2.list_0);
			DataTable dataTable_ = CommonSQL.E1B5F13E(list, DD1B4602: false);
			dtgvAcc.Rows.Clear();
			method_2(dataTable_);
		}
	}

	private void F48CF13C(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			for (int i = 0; i < dtgvAcc.RowCount; i++)
			{
				if (Convert.ToBoolean(dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					string item = method_7(i, "cUid");
					if (list2.Contains(item))
					{
						list.Add(item);
					}
					else
					{
						list2.Add(item);
					}
				}
			}
			if (list.Count == 0)
			{
				MessageBoxHelper.Show("Không có tài khoản trùng nhau!");
				return;
			}
			List<string> list3 = Common.smethod_11(list);
			DataTable dataTable = CommonSQL.E1B5F13E(list3, DD1B4602: false);
			dataTable.DefaultView.Sort = "uid ASC";
			dataTable = dataTable.DefaultView.ToTable();
			dtgvAcc.Rows.Clear();
			method_2(dataTable);
		}
		catch (Exception)
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBin));
		dtgvAcc = new System.Windows.Forms.DataGridView();
		cChose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		EE0F2880 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cUid = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
		A09F631C = new System.Windows.Forms.DataGridViewTextBoxColumn();
		FE89DDA5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		AF0DEB09 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cFollow = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cFriend = new System.Windows.Forms.DataGridViewTextBoxColumn();
		CC97E00D = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
		E18BE606 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B5A0F2A1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cPassMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B70CECA5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cFa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		CF016A03 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cProxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cDateCreateAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		FA36B6BC = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cThuMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
		B905F38A = new System.Windows.Forms.DataGridViewTextBoxColumn();
		C9947698 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cDateDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
		cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		ctmsAcc = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		tinhTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		DEBD7106 = new System.Windows.Forms.ToolStripMenuItem();
		AA05B298 = new System.Windows.Forms.ToolStripMenuItem();
		A607580A = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		FC248A3F = new System.Windows.Forms.ToolStripMenuItem();
		uidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		AC3C6ABF = new System.Windows.Forms.ToolStripMenuItem();
		tokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		cookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		fAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_7 = new System.Windows.Forms.ToolStripMenuItem();
		A6A8159C = new System.Windows.Forms.ToolStripMenuItem();
		uidPass2FaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		mailPassMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		uidPassTokenCookieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		C22983AA = new System.Windows.Forms.ToolStripMenuItem();
		uidPassTokenCookieMailPassMail2faToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		DCA1D0BD = new System.Windows.Forms.ToolStripMenuItem();
		proxyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_6 = new System.Windows.Forms.ToolStripMenuItem();
		A33498AD = new System.Windows.Forms.ToolStripMenuItem();
		DEB7FE26 = new System.Windows.Forms.ToolStripMenuItem();
		EE0B0639 = new System.Windows.Forms.ToolStripMenuItem();
		C834A7BE = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		checkAvatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		checkProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		EE257EBB = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_9 = new System.Windows.Forms.ToolStripMenuItem();
		checkProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		FFB4E61B = new System.Windows.Forms.ToolStripMenuItem();
		EB08C73B = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		F781CA0E = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		F3221FB0 = new System.Windows.Forms.Panel();
		C3160B89 = new System.Windows.Forms.PictureBox();
		button2 = new System.Windows.Forms.Button();
		button1 = new System.Windows.Forms.Button();
		E6053A39 = new System.Windows.Forms.Button();
		B531ACAB = new Bunifu.Framework.UI.BunifuCustomLabel();
		C9015402 = new Bunifu.Framework.UI.BunifuCards();
		menuStrip1 = new System.Windows.Forms.MenuStrip();
		toolStripMenuItem_8 = new System.Windows.Forms.ToolStripMenuItem();
		grQuanLyThuMuc = new System.Windows.Forms.GroupBox();
		btnLoadAcc = new System.Windows.Forms.Button();
		A0203D34 = new System.Windows.Forms.ComboBox();
		D1AF0537 = new System.Windows.Forms.ComboBox();
		C017E608 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		grTimKiem = new System.Windows.Forms.GroupBox();
		BtnSearch = new System.Windows.Forms.Button();
		cbbSearch = new System.Windows.Forms.ComboBox();
		txbSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
		A41AE315 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		BB3BE919 = new System.Windows.Forms.ToolTip(icontainer_0);
		F8BAEE9A = new System.Windows.Forms.StatusStrip();
		CBA9C70B = new System.Windows.Forms.ToolStripStatusLabel();
		B088C79D = new System.Windows.Forms.ToolStripStatusLabel();
		toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
		lblCountTotal = new System.Windows.Forms.ToolStripStatusLabel();
		F80C9C82 = new System.Windows.Forms.Button();
		D03ADA1C = new System.Windows.Forms.Button();
		EE2AB393 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)dtgvAcc).BeginInit();
		ctmsAcc.SuspendLayout();
		F3221FB0.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C3160B89).BeginInit();
		C9015402.SuspendLayout();
		menuStrip1.SuspendLayout();
		grQuanLyThuMuc.SuspendLayout();
		grTimKiem.SuspendLayout();
		F8BAEE9A.SuspendLayout();
		SuspendLayout();
		dtgvAcc.AllowUserToAddRows = false;
		dtgvAcc.AllowUserToDeleteRows = false;
		dtgvAcc.AllowUserToResizeRows = false;
		dtgvAcc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		dtgvAcc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		dtgvAcc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dtgvAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dtgvAcc.Columns.AddRange(cChose, EE0F2880, cId, cUid, cToken, A09F631C, FE89DDA5, AF0DEB09, cName, cFollow, cFriend, CC97E00D, cBirthday, E18BE606, cPassword, B5A0F2A1, cPassMail, B70CECA5, cFa2, CF016A03, cProxy, cDateCreateAcc, FA36B6BC, cProfile, cThuMuc, B905F38A, C9947698, cGhiChu, cDateDelete, cStatus);
		dtgvAcc.ContextMenuStrip = ctmsAcc;
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		dtgvAcc.DefaultCellStyle = dataGridViewCellStyle2;
		dtgvAcc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
		dtgvAcc.Location = new System.Drawing.Point(2, 124);
		dtgvAcc.Name = "dtgvAcc";
		dtgvAcc.ReadOnly = true;
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		dtgvAcc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
		dtgvAcc.RowHeadersVisible = false;
		dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dtgvAcc.RowsDefaultCellStyle = dataGridViewCellStyle4;
		dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		dtgvAcc.Size = new System.Drawing.Size(1199, 461);
		dtgvAcc.TabIndex = 0;
		dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellClick);
		dtgvAcc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dtgvAcc_CellDoubleClick);
		dtgvAcc.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(EA0F6F19);
		dtgvAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(B93E501B);
		cChose.HeaderText = "Chọn";
		cChose.Name = "cChose";
		cChose.ReadOnly = true;
		cChose.Width = 40;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		EE0F2880.DefaultCellStyle = dataGridViewCellStyle5;
		EE0F2880.HeaderText = "STT";
		EE0F2880.Name = "cStt";
		EE0F2880.ReadOnly = true;
		EE0F2880.Width = 35;
		cId.HeaderText = "Id";
		cId.Name = "cId";
		cId.ReadOnly = true;
		cId.Visible = false;
		cId.Width = 90;
		cUid.HeaderText = "UID";
		cUid.Name = "cUid";
		cUid.ReadOnly = true;
		cUid.Width = 80;
		cToken.HeaderText = "Token";
		cToken.Name = "cToken";
		cToken.ReadOnly = true;
		cToken.Width = 70;
		A09F631C.HeaderText = "Cookie";
		A09F631C.Name = "cCookies";
		A09F631C.ReadOnly = true;
		A09F631C.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		A09F631C.Width = 70;
		FE89DDA5.HeaderText = "Email";
		FE89DDA5.Name = "cEmail";
		FE89DDA5.ReadOnly = true;
		FE89DDA5.Width = 60;
		AF0DEB09.HeaderText = "Phone";
		AF0DEB09.Name = "cPhone";
		AF0DEB09.ReadOnly = true;
		AF0DEB09.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		AF0DEB09.Visible = false;
		AF0DEB09.Width = 90;
		cName.HeaderText = "Tên";
		cName.Name = "cName";
		cName.ReadOnly = true;
		cName.Width = 70;
		cFollow.HeaderText = "Theo do\u0303i";
		cFollow.Name = "cFollow";
		cFollow.ReadOnly = true;
		cFollow.Width = 80;
		cFriend.HeaderText = "Ba\u0323n be\u0300";
		cFriend.Name = "cFriend";
		cFriend.ReadOnly = true;
		cFriend.Width = 70;
		CC97E00D.HeaderText = "Nho\u0301m";
		CC97E00D.Name = "cGroup";
		CC97E00D.ReadOnly = true;
		CC97E00D.Width = 60;
		cBirthday.HeaderText = "Nga\u0300y sinh";
		cBirthday.Name = "cBirthday";
		cBirthday.ReadOnly = true;
		cBirthday.Width = 90;
		E18BE606.HeaderText = "Giới Tính";
		E18BE606.Name = "cGender";
		E18BE606.ReadOnly = true;
		E18BE606.Width = 80;
		cPassword.HeaderText = "Mật khẩu";
		cPassword.Name = "cPassword";
		cPassword.ReadOnly = true;
		cPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		cPassword.Visible = false;
		cPassword.Width = 70;
		B5A0F2A1.HeaderText = "Email khôi phục";
		B5A0F2A1.Name = "cMailRecovery";
		B5A0F2A1.ReadOnly = true;
		B5A0F2A1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		B5A0F2A1.Visible = false;
		B5A0F2A1.Width = 120;
		cPassMail.HeaderText = "Mật khẩu mail";
		cPassMail.Name = "cPassMail";
		cPassMail.ReadOnly = true;
		cPassMail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		cPassMail.Visible = false;
		cPassMail.Width = 120;
		B70CECA5.HeaderText = "Backup";
		B70CECA5.Name = "cBackup";
		B70CECA5.ReadOnly = true;
		B70CECA5.Width = 70;
		cFa2.HeaderText = "Mã 2FA";
		cFa2.Name = "cFa2";
		cFa2.ReadOnly = true;
		cFa2.Width = 65;
		CF016A03.HeaderText = "Useragent";
		CF016A03.Name = "cUseragent";
		CF016A03.ReadOnly = true;
		CF016A03.Width = 70;
		cProxy.HeaderText = "Proxy";
		cProxy.Name = "cProxy";
		cProxy.ReadOnly = true;
		cProxy.Width = 55;
		cDateCreateAcc.HeaderText = "Nga\u0300y ta\u0323o";
		cDateCreateAcc.Name = "cDateCreateAcc";
		cDateCreateAcc.ReadOnly = true;
		cDateCreateAcc.Width = 85;
		FA36B6BC.HeaderText = "Avatar";
		FA36B6BC.Name = "cAvatar";
		FA36B6BC.ReadOnly = true;
		FA36B6BC.Width = 50;
		cProfile.HeaderText = "Profile";
		cProfile.Name = "cProfile";
		cProfile.ReadOnly = true;
		cProfile.Width = 50;
		cThuMuc.HeaderText = "Thư mục";
		cThuMuc.Name = "cThuMuc";
		cThuMuc.ReadOnly = true;
		B905F38A.HeaderText = "Lâ\u0300n tương ta\u0301c cuô\u0301i";
		B905F38A.Name = "cInteractEnd";
		B905F38A.ReadOnly = true;
		C9947698.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
		C9947698.HeaderText = "Tình Trạng";
		C9947698.Name = "cInfo";
		C9947698.ReadOnly = true;
		C9947698.Width = 90;
		cGhiChu.HeaderText = "Ghi Chú";
		cGhiChu.Name = "cGhiChu";
		cGhiChu.ReadOnly = true;
		cDateDelete.HeaderText = "Thơ\u0300i gian xo\u0301a";
		cDateDelete.Name = "cDateDelete";
		cDateDelete.ReadOnly = true;
		cDateDelete.Width = 111;
		cStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
		cStatus.HeaderText = "Trạng Thái";
		cStatus.Name = "cStatus";
		cStatus.ReadOnly = true;
		ctmsAcc.Items.AddRange(new System.Windows.Forms.ToolStripItem[8] { toolStripMenuItem_0, AA05B298, A607580A, toolStripMenuItem_1, FC248A3F, A33498AD, FFB4E61B, toolStripMenuItem_4 });
		ctmsAcc.Name = "ctmsAcc";
		ctmsAcc.Size = new System.Drawing.Size(198, 180);
		ctmsAcc.Opening += new System.ComponentModel.CancelEventHandler(E907EAA8);
		toolStripMenuItem_0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { toolStripMenuItem_2, liveToolStripMenuItem, tinhTrangToolStripMenuItem, DEBD7106 });
		toolStripMenuItem_0.Image = (System.Drawing.Image)resources.GetObject("chọnLiveToolStripMenuItem.Image");
		toolStripMenuItem_0.Name = "chọnLiveToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(197, 22);
		toolStripMenuItem_0.Text = "Chọn";
		toolStripMenuItem_2.Image = (System.Drawing.Image)resources.GetObject("tấtCảToolStripMenuItem.Image");
		toolStripMenuItem_2.Name = "tấtCảToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(129, 22);
		toolStripMenuItem_2.Text = "Tất cả";
		toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		liveToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("liveToolStripMenuItem.Image");
		liveToolStripMenuItem.Name = "liveToolStripMenuItem";
		liveToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
		liveToolStripMenuItem.Text = "Bôi đen";
		liveToolStripMenuItem.Click += new System.EventHandler(CD001529);
		tinhTrangToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tinhTrangToolStripMenuItem.Image");
		tinhTrangToolStripMenuItem.Name = "tinhTrangToolStripMenuItem";
		tinhTrangToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
		tinhTrangToolStripMenuItem.Text = "Ti\u0300nh tra\u0323ng";
		DEBD7106.Image = (System.Drawing.Image)resources.GetObject("trạngTháiToolStripMenuItem.Image");
		DEBD7106.Name = "trạngTháiToolStripMenuItem";
		DEBD7106.Size = new System.Drawing.Size(129, 22);
		DEBD7106.Text = "Trạng thái";
		DEBD7106.Click += new System.EventHandler(DEBD7106_Click);
		AA05B298.Image = (System.Drawing.Image)resources.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
		AA05B298.Name = "bỏChọnTấtCảToolStripMenuItem";
		AA05B298.Size = new System.Drawing.Size(197, 22);
		AA05B298.Text = "Bỏ chọn tất cả";
		AA05B298.Click += new System.EventHandler(C138102F);
		A607580A.Image = Resource.B682811A;
		A607580A.Name = "khôiPhucTaiKhoanToolStripMenuItem";
		A607580A.Size = new System.Drawing.Size(197, 22);
		A607580A.Text = "Khôi phu\u0323c ta\u0300i khoa\u0309n";
		A607580A.Click += new System.EventHandler(A607580A_Click);
		toolStripMenuItem_1.Image = Resource.Bitmap_80;
		toolStripMenuItem_1.Name = "xóaTàiKhoảnToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(197, 22);
		toolStripMenuItem_1.Text = "Xóa ta\u0300i khoa\u0309n vi\u0303nh viê\u0303n";
		toolStripMenuItem_1.Click += new System.EventHandler(B0A895BB);
		FC248A3F.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[16]
		{
			uidToolStripMenuItem, AC3C6ABF, tokenToolStripMenuItem, cookieToolStripMenuItem, mailToolStripMenuItem, fAToolStripMenuItem, toolStripMenuItem_7, A6A8159C, uidPass2FaToolStripMenuItem, mailPassMailToolStripMenuItem,
			uidPassTokenCookieToolStripMenuItem, C22983AA, uidPassTokenCookieMailPassMail2faToolStripMenuItem, DCA1D0BD, proxyToolStripMenuItem1, toolStripMenuItem_6
		});
		FC248A3F.Image = (System.Drawing.Image)resources.GetObject("copyToolStripMenuItem.Image");
		FC248A3F.Name = "copyToolStripMenuItem";
		FC248A3F.Size = new System.Drawing.Size(197, 22);
		FC248A3F.Text = "Copy";
		uidToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidToolStripMenuItem.Image");
		uidToolStripMenuItem.Name = "uidToolStripMenuItem";
		uidToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
		uidToolStripMenuItem.Text = "Uid";
		uidToolStripMenuItem.Click += new System.EventHandler(uidToolStripMenuItem_Click);
		AC3C6ABF.Image = (System.Drawing.Image)resources.GetObject("passToolStripMenuItem.Image");
		AC3C6ABF.Name = "passToolStripMenuItem";
		AC3C6ABF.Size = new System.Drawing.Size(290, 22);
		AC3C6ABF.Text = "Pass";
		AC3C6ABF.Click += new System.EventHandler(AC3C6ABF_Click);
		tokenToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("tokenToolStripMenuItem.Image");
		tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
		tokenToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
		tokenToolStripMenuItem.Text = "Token";
		tokenToolStripMenuItem.Click += new System.EventHandler(tokenToolStripMenuItem_Click);
		cookieToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("cookieToolStripMenuItem.Image");
		cookieToolStripMenuItem.Name = "cookieToolStripMenuItem";
		cookieToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
		cookieToolStripMenuItem.Text = "Cookie";
		cookieToolStripMenuItem.Click += new System.EventHandler(BD0F753F);
		mailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("mailToolStripMenuItem.Image");
		mailToolStripMenuItem.Name = "mailToolStripMenuItem";
		mailToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
		mailToolStripMenuItem.Text = "Email";
		mailToolStripMenuItem.Click += new System.EventHandler(mailToolStripMenuItem_Click);
		fAToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("fAToolStripMenuItem.Image");
		fAToolStripMenuItem.Name = "fAToolStripMenuItem";
		fAToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
		fAToolStripMenuItem.Text = "2FA";
		fAToolStripMenuItem.Click += new System.EventHandler(BA10268A);
		toolStripMenuItem_7.Image = (System.Drawing.Image)resources.GetObject("maBaoMât6SôToolStripMenuItem.Image");
		toolStripMenuItem_7.Name = "maBaoMât6SôToolStripMenuItem";
		toolStripMenuItem_7.Size = new System.Drawing.Size(290, 22);
		toolStripMenuItem_7.Text = "Ma\u0303 ba\u0309o mâ\u0323t 6 sô\u0301";
		toolStripMenuItem_7.Click += new System.EventHandler(B33D0907);
		A6A8159C.Image = (System.Drawing.Image)resources.GetObject("uidPassToolStripMenuItem.Image");
		A6A8159C.Name = "uidPassToolStripMenuItem";
		A6A8159C.Size = new System.Drawing.Size(290, 22);
		A6A8159C.Text = "Uid|Pass";
		A6A8159C.Click += new System.EventHandler(A0957632);
		uidPass2FaToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPass2FaToolStripMenuItem.Image");
		uidPass2FaToolStripMenuItem.Name = "uidPass2FaToolStripMenuItem";
		uidPass2FaToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
		uidPass2FaToolStripMenuItem.Text = "Uid|Pass|2Fa";
		uidPass2FaToolStripMenuItem.Click += new System.EventHandler(D0102436);
		mailPassMailToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("mailPassMailToolStripMenuItem.Image");
		mailPassMailToolStripMenuItem.Name = "mailPassMailToolStripMenuItem";
		mailPassMailToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
		mailPassMailToolStripMenuItem.Text = "Mail|Pass mail";
		mailPassMailToolStripMenuItem.Click += new System.EventHandler(E3AA4AA5);
		uidPassTokenCookieToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieToolStripMenuItem.Image");
		uidPassTokenCookieToolStripMenuItem.Name = "uidPassTokenCookieToolStripMenuItem";
		uidPassTokenCookieToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
		uidPassTokenCookieToolStripMenuItem.Text = "Uid|Pass|Token|Cookie";
		uidPassTokenCookieToolStripMenuItem.Click += new System.EventHandler(uidPassTokenCookieToolStripMenuItem_Click);
		C22983AA.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMailToolStripMenuItem.Image");
		C22983AA.Name = "uidPassTokenCookieMailPassMailToolStripMenuItem";
		C22983AA.Size = new System.Drawing.Size(290, 22);
		C22983AA.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail";
		C22983AA.Click += new System.EventHandler(C22983AA_Click);
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("uidPassTokenCookieMailPassMail2faToolStripMenuItem.Image");
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Name = "uidPassTokenCookieMailPassMail2faToolStripMenuItem";
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Text = "Uid|Pass|Token|Cookie|Mail|Pass mail|2fa";
		uidPassTokenCookieMailPassMail2faToolStripMenuItem.Click += new System.EventHandler(uidPassTokenCookieMailPassMail2faToolStripMenuItem_Click);
		DCA1D0BD.Image = (System.Drawing.Image)resources.GetObject("useragentToolStripMenuItem1.Image");
		DCA1D0BD.Name = "useragentToolStripMenuItem1";
		DCA1D0BD.Size = new System.Drawing.Size(290, 22);
		DCA1D0BD.Text = "Useragent";
		DCA1D0BD.Click += new System.EventHandler(DCA1D0BD_Click);
		proxyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("proxyToolStripMenuItem1.Image");
		proxyToolStripMenuItem1.Name = "proxyToolStripMenuItem1";
		proxyToolStripMenuItem1.Size = new System.Drawing.Size(290, 22);
		proxyToolStripMenuItem1.Text = "Proxy";
		proxyToolStripMenuItem1.Click += new System.EventHandler(D4240F0F);
		toolStripMenuItem_6.Image = (System.Drawing.Image)resources.GetObject("đinhDangKhacToolStripMenuItem.Image");
		toolStripMenuItem_6.Name = "đinhDangKhacToolStripMenuItem";
		toolStripMenuItem_6.Size = new System.Drawing.Size(290, 22);
		toolStripMenuItem_6.Text = "Đi\u0323nh da\u0323ng kha\u0301c...";
		toolStripMenuItem_6.Click += new System.EventHandler(FF8DB61B);
		A33498AD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[10] { DEB7FE26, EE0B0639, C834A7BE, toolStripMenuItem_3, checkAvatarToolStripMenuItem, checkProfileToolStripMenuItem1, EE257EBB, toolStripMenuItem_5, toolStripMenuItem_9, checkProxyToolStripMenuItem });
		A33498AD.Image = (System.Drawing.Image)resources.GetObject("checkCookieToolStripMenuItem.Image");
		A33498AD.Name = "checkCookieToolStripMenuItem";
		A33498AD.Size = new System.Drawing.Size(197, 22);
		A33498AD.Text = "Kiểm tra tài khoản";
		DEB7FE26.Name = "kiểmTraWallToolStripMenuItem";
		DEB7FE26.Size = new System.Drawing.Size(164, 22);
		DEB7FE26.Text = "Check Wall";
		DEB7FE26.ToolTipText = "Không cần dùng token";
		DEB7FE26.Click += new System.EventHandler(DEB7FE26_Click);
		EE0B0639.Name = "checkInfoUIDToolStripMenuItem";
		EE0B0639.Size = new System.Drawing.Size(164, 22);
		EE0B0639.Text = "Check Info UID";
		EE0B0639.ToolTipText = "Không cần dùng token\r\nCâ\u0323p nhâ\u0323t thông tin: Ho\u0323 tên, Giớ\u0301i ti\u0301nh, [Email], [Ba\u0323n be\u0300], [Nho\u0301m], [Nga\u0300y sinh]";
		EE0B0639.Click += new System.EventHandler(EE0B0639_Click);
		C834A7BE.Name = "kiểmTraTokenToolStripMenuItem";
		C834A7BE.Size = new System.Drawing.Size(164, 22);
		C834A7BE.Text = "Check Token";
		C834A7BE.Click += new System.EventHandler(C834A7BE_Click);
		toolStripMenuItem_3.Name = "kiểmTraCookieToolStripMenuItem";
		toolStripMenuItem_3.Size = new System.Drawing.Size(164, 22);
		toolStripMenuItem_3.Text = "Check Cookie";
		toolStripMenuItem_3.Click += new System.EventHandler(toolStripMenuItem_3_Click);
		checkAvatarToolStripMenuItem.Name = "checkAvatarToolStripMenuItem";
		checkAvatarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
		checkAvatarToolStripMenuItem.Text = "Check Avatar";
		checkAvatarToolStripMenuItem.Click += new System.EventHandler(checkAvatarToolStripMenuItem_Click);
		checkProfileToolStripMenuItem1.Name = "checkProfileToolStripMenuItem1";
		checkProfileToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
		checkProfileToolStripMenuItem1.Text = "Check Profile";
		checkProfileToolStripMenuItem1.Click += new System.EventHandler(BA9F0881);
		EE257EBB.Name = "checkBackupToolStripMenuItem1";
		EE257EBB.Size = new System.Drawing.Size(164, 22);
		EE257EBB.Text = "Check Backup";
		EE257EBB.Click += new System.EventHandler(B021F206);
		toolStripMenuItem_5.Name = "kiểmTraTàiKhoảnToolStripMenuItem";
		toolStripMenuItem_5.Size = new System.Drawing.Size(164, 22);
		toolStripMenuItem_5.Text = "Dạng checkpoint";
		toolStripMenuItem_5.ToolTipText = "Chi\u0309 sư\u0309 du\u0323ng khi ta\u0300i khoa\u0309n đa\u0303 bi\u0323 checkpoint!";
		toolStripMenuItem_5.Click += new System.EventHandler(AD8718B1);
		toolStripMenuItem_9.Name = "kiểmTraMailpassMailToolStripMenuItem";
		toolStripMenuItem_9.Size = new System.Drawing.Size(164, 22);
		toolStripMenuItem_9.Text = "Mail|pass Mail";
		toolStripMenuItem_9.Click += new System.EventHandler(A3B974BA);
		checkProxyToolStripMenuItem.Name = "checkProxyToolStripMenuItem";
		checkProxyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
		checkProxyToolStripMenuItem.Text = "Check Proxy";
		checkProxyToolStripMenuItem.Click += new System.EventHandler(checkProxyToolStripMenuItem_Click);
		FFB4E61B.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { EB08C73B });
		FFB4E61B.Image = (System.Drawing.Image)resources.GetObject("chứcNăngToolStripMenuItem1.Image");
		FFB4E61B.Name = "chứcNăngToolStripMenuItem1";
		FFB4E61B.Size = new System.Drawing.Size(197, 22);
		FFB4E61B.Text = "Chức năng";
		EB08C73B.Image = (System.Drawing.Image)resources.GetObject("lToolStripMenuItem.Image");
		EB08C73B.Name = "lToolStripMenuItem";
		EB08C73B.Size = new System.Drawing.Size(228, 22);
		EB08C73B.Text = "Lọc tài khoản theo UID/Email";
		EB08C73B.Click += new System.EventHandler(EB08C73B_Click);
		toolStripMenuItem_4.Image = (System.Drawing.Image)resources.GetObject("tảiLạiDanhSáchToolStripMenuItem.Image");
		toolStripMenuItem_4.Name = "tảiLạiDanhSáchToolStripMenuItem";
		toolStripMenuItem_4.Size = new System.Drawing.Size(197, 22);
		toolStripMenuItem_4.Text = "Tải lại danh sách";
		toolStripMenuItem_4.Click += new System.EventHandler(toolStripMenuItem_4_Click);
		F781CA0E.Fixed = true;
		F781CA0E.Horizontal = true;
		F781CA0E.TargetControl = F3221FB0;
		F781CA0E.Vertical = true;
		F3221FB0.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F3221FB0.BackColor = System.Drawing.Color.White;
		F3221FB0.Controls.Add(C3160B89);
		F3221FB0.Controls.Add(button2);
		F3221FB0.Controls.Add(button1);
		F3221FB0.Controls.Add(E6053A39);
		F3221FB0.Controls.Add(B531ACAB);
		F3221FB0.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F3221FB0.Location = new System.Drawing.Point(0, 5);
		F3221FB0.Name = "pnlHeader";
		F3221FB0.Size = new System.Drawing.Size(1203, 29);
		F3221FB0.TabIndex = 0;
		C3160B89.Cursor = System.Windows.Forms.Cursors.Arrow;
		C3160B89.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		C3160B89.Location = new System.Drawing.Point(6, 1);
		C3160B89.Name = "pictureBox1";
		C3160B89.Size = new System.Drawing.Size(34, 27);
		C3160B89.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		C3160B89.TabIndex = 12;
		C3160B89.TabStop = false;
		C3160B89.Click += new System.EventHandler(A639D2BE);
		C3160B89.DoubleClick += new System.EventHandler(C3160B89_DoubleClick);
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.Dock = System.Windows.Forms.DockStyle.Right;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
		button2.Location = new System.Drawing.Point(1107, 0);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(32, 29);
		button2.TabIndex = 0;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.Dock = System.Windows.Forms.DockStyle.Right;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(1139, 0);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(32, 29);
		button1.TabIndex = 1;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		E6053A39.Cursor = System.Windows.Forms.Cursors.Hand;
		E6053A39.Dock = System.Windows.Forms.DockStyle.Right;
		E6053A39.FlatAppearance.BorderSize = 0;
		E6053A39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E6053A39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E6053A39.ForeColor = System.Drawing.Color.White;
		E6053A39.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		E6053A39.Location = new System.Drawing.Point(1171, 0);
		E6053A39.Name = "btnMinimize";
		E6053A39.Size = new System.Drawing.Size(32, 29);
		E6053A39.TabIndex = 2;
		E6053A39.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		E6053A39.UseVisualStyleBackColor = true;
		E6053A39.Click += new System.EventHandler(C3A039B7);
		B531ACAB.AutoSize = true;
		B531ACAB.BackColor = System.Drawing.Color.Transparent;
		B531ACAB.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B531ACAB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B531ACAB.ForeColor = System.Drawing.Color.Black;
		B531ACAB.Location = new System.Drawing.Point(43, 6);
		B531ACAB.Name = "bunifuCustomLabel1";
		B531ACAB.Size = new System.Drawing.Size(185, 16);
		B531ACAB.TabIndex = 3;
		B531ACAB.Text = "Danh sa\u0301ch ta\u0300i khoa\u0309n đa\u0303 xo\u0301a";
		C9015402.BackColor = System.Drawing.Color.White;
		C9015402.BorderRadius = 0;
		C9015402.BottomSahddow = true;
		C9015402.color = System.Drawing.Color.DarkRed;
		C9015402.Controls.Add(F3221FB0);
		C9015402.Dock = System.Windows.Forms.DockStyle.Top;
		C9015402.LeftSahddow = false;
		C9015402.Location = new System.Drawing.Point(0, 0);
		C9015402.Name = "bunifuCards1";
		C9015402.RightSahddow = true;
		C9015402.ShadowDepth = 20;
		C9015402.Size = new System.Drawing.Size(1204, 38);
		C9015402.TabIndex = 0;
		menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		menuStrip1.AutoSize = false;
		menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
		menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { toolStripMenuItem_8 });
		menuStrip1.Location = new System.Drawing.Point(0, 37);
		menuStrip1.Name = "menuStrip1";
		menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
		menuStrip1.Size = new System.Drawing.Size(1201, 25);
		menuStrip1.Stretch = false;
		menuStrip1.TabIndex = 1;
		menuStrip1.Text = "menuStrip1";
		toolStripMenuItem_8.Image = Resource.E53E2DAF;
		toolStripMenuItem_8.Name = "thoátToolStripMenuItem";
		toolStripMenuItem_8.Size = new System.Drawing.Size(131, 21);
		toolStripMenuItem_8.Text = "Câ\u0301u hi\u0300nh hiê\u0309n thi\u0323";
		toolStripMenuItem_8.Click += new System.EventHandler(toolStripMenuItem_8_Click);
		grQuanLyThuMuc.Controls.Add(btnLoadAcc);
		grQuanLyThuMuc.Controls.Add(A0203D34);
		grQuanLyThuMuc.Controls.Add(D1AF0537);
		grQuanLyThuMuc.Controls.Add(C017E608);
		grQuanLyThuMuc.Controls.Add(label1);
		grQuanLyThuMuc.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		grQuanLyThuMuc.Location = new System.Drawing.Point(292, 65);
		grQuanLyThuMuc.Name = "grQuanLyThuMuc";
		grQuanLyThuMuc.Size = new System.Drawing.Size(445, 53);
		grQuanLyThuMuc.TabIndex = 5;
		grQuanLyThuMuc.TabStop = false;
		grQuanLyThuMuc.Text = "Quản lý thư mục";
		btnLoadAcc.BackgroundImage = Resource.Bitmap_6;
		btnLoadAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
		btnLoadAcc.Cursor = System.Windows.Forms.Cursors.Hand;
		btnLoadAcc.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnLoadAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnLoadAcc.Location = new System.Drawing.Point(416, 19);
		btnLoadAcc.Name = "btnLoadAcc";
		btnLoadAcc.Size = new System.Drawing.Size(25, 25);
		btnLoadAcc.TabIndex = 6;
		BB3BE919.SetToolTip(btnLoadAcc, "Load lại danh sách");
		btnLoadAcc.Click += new System.EventHandler(btnLoadAcc_Click);
		A0203D34.Cursor = System.Windows.Forms.Cursors.Hand;
		A0203D34.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		A0203D34.DropDownWidth = 300;
		A0203D34.FormattingEnabled = true;
		A0203D34.ItemHeight = 16;
		A0203D34.Items.AddRange(new object[1] { "[Tất cả tình trạng]" });
		A0203D34.Location = new System.Drawing.Point(289, 19);
		A0203D34.Name = "cbbTinhTrang";
		A0203D34.Size = new System.Drawing.Size(121, 24);
		A0203D34.TabIndex = 3;
		A0203D34.SelectedIndexChanged += new System.EventHandler(F3A8F22D);
		D1AF0537.Cursor = System.Windows.Forms.Cursors.Hand;
		D1AF0537.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		D1AF0537.DropDownWidth = 350;
		D1AF0537.FormattingEnabled = true;
		D1AF0537.ItemHeight = 16;
		D1AF0537.Items.AddRange(new object[1] { "[Tất cả thư mục]" });
		D1AF0537.Location = new System.Drawing.Point(72, 19);
		D1AF0537.Name = "cbbThuMuc";
		D1AF0537.Size = new System.Drawing.Size(173, 24);
		D1AF0537.TabIndex = 1;
		D1AF0537.SelectedIndexChanged += new System.EventHandler(A91E2D90);
		C017E608.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C017E608.Location = new System.Drawing.Point(249, 22);
		C017E608.Name = "label2";
		C017E608.Size = new System.Drawing.Size(42, 16);
		C017E608.TabIndex = 2;
		C017E608.Text = "Lọc:";
		C017E608.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(8, 23);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(64, 16);
		label1.TabIndex = 0;
		label1.Text = "Thư mục:";
		label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		grTimKiem.Controls.Add(BtnSearch);
		grTimKiem.Controls.Add(cbbSearch);
		grTimKiem.Controls.Add(txbSearch);
		grTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		grTimKiem.Location = new System.Drawing.Point(2, 65);
		grTimKiem.Name = "grTimKiem";
		grTimKiem.Size = new System.Drawing.Size(284, 53);
		grTimKiem.TabIndex = 4;
		grTimKiem.TabStop = false;
		grTimKiem.Text = "Tìm kiếm";
		BtnSearch.BackgroundImage = Resource.Bitmap_133;
		BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
		BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BtnSearch.Location = new System.Drawing.Point(253, 18);
		BtnSearch.Name = "BtnSearch";
		BtnSearch.Size = new System.Drawing.Size(24, 24);
		BtnSearch.TabIndex = 2;
		BtnSearch.Click += new System.EventHandler(BtnSearch_Click);
		cbbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbSearch.DropDownWidth = 100;
		cbbSearch.FormattingEnabled = true;
		cbbSearch.Location = new System.Drawing.Point(12, 18);
		cbbSearch.Name = "cbbSearch";
		cbbSearch.Size = new System.Drawing.Size(86, 24);
		cbbSearch.TabIndex = 0;
		txbSearch.BorderColor = System.Drawing.Color.SeaGreen;
		txbSearch.Location = new System.Drawing.Point(104, 19);
		txbSearch.Name = "txbSearch";
		txbSearch.Size = new System.Drawing.Size(143, 23);
		txbSearch.TabIndex = 1;
		A41AE315.Fixed = true;
		A41AE315.Horizontal = true;
		A41AE315.TargetControl = B531ACAB;
		A41AE315.Vertical = true;
		BB3BE919.AutomaticDelay = 0;
		BB3BE919.AutoPopDelay = 30000;
		BB3BE919.InitialDelay = 0;
		BB3BE919.ReshowDelay = 40;
		F8BAEE9A.BackColor = System.Drawing.SystemColors.Control;
		F8BAEE9A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F8BAEE9A.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { CBA9C70B, B088C79D, toolStripStatusLabel7, lblCountTotal });
		F8BAEE9A.Location = new System.Drawing.Point(0, 588);
		F8BAEE9A.Name = "statusStrip1";
		F8BAEE9A.Size = new System.Drawing.Size(1204, 22);
		F8BAEE9A.TabIndex = 11;
		F8BAEE9A.Text = "statusStrip1";
		CBA9C70B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CBA9C70B.Name = "toolStripStatusLabel5";
		CBA9C70B.Size = new System.Drawing.Size(65, 17);
		CBA9C70B.Text = "Đã chọn:";
		B088C79D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B088C79D.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
		B088C79D.Name = "lblCountSelect";
		B088C79D.Size = new System.Drawing.Size(15, 17);
		B088C79D.Text = "0";
		toolStripStatusLabel7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		toolStripStatusLabel7.Name = "toolStripStatusLabel7";
		toolStripStatusLabel7.Size = new System.Drawing.Size(52, 17);
		toolStripStatusLabel7.Text = "Tất cả:";
		lblCountTotal.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblCountTotal.ForeColor = System.Drawing.Color.Maroon;
		lblCountTotal.Name = "lblCountTotal";
		lblCountTotal.Size = new System.Drawing.Size(15, 17);
		lblCountTotal.Text = "0";
		F80C9C82.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		F80C9C82.BackColor = System.Drawing.Color.White;
		F80C9C82.Cursor = System.Windows.Forms.Cursors.Hand;
		F80C9C82.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F80C9C82.Image = Resource.B682811A;
		F80C9C82.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		F80C9C82.Location = new System.Drawing.Point(836, 78);
		F80C9C82.Name = "button9";
		F80C9C82.Size = new System.Drawing.Size(158, 34);
		F80C9C82.TabIndex = 12;
		F80C9C82.Text = "Khôi phu\u0323c ta\u0300i khoa\u0309n";
		F80C9C82.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		F80C9C82.UseVisualStyleBackColor = true;
		F80C9C82.Click += new System.EventHandler(F80C9C82_Click);
		D03ADA1C.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		D03ADA1C.BackColor = System.Drawing.Color.White;
		D03ADA1C.Cursor = System.Windows.Forms.Cursors.Hand;
		D03ADA1C.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D03ADA1C.Image = Resource.Bitmap_80;
		D03ADA1C.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		D03ADA1C.Location = new System.Drawing.Point(1000, 78);
		D03ADA1C.Name = "button3";
		D03ADA1C.Size = new System.Drawing.Size(201, 34);
		D03ADA1C.TabIndex = 12;
		D03ADA1C.Text = "Xo\u0301a ta\u0300i khoa\u0309n vi\u0303nh viê\u0303n";
		D03ADA1C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		D03ADA1C.UseVisualStyleBackColor = true;
		D03ADA1C.Click += new System.EventHandler(D03ADA1C_Click);
		EE2AB393.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		EE2AB393.BackColor = System.Drawing.SystemColors.Control;
		EE2AB393.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EE2AB393.ForeColor = System.Drawing.Color.Red;
		EE2AB393.Location = new System.Drawing.Point(688, 591);
		EE2AB393.Name = "label3";
		EE2AB393.Size = new System.Drawing.Size(515, 16);
		EE2AB393.TabIndex = 13;
		EE2AB393.Text = "[Bôi đen nhiều dòng rồi nhấn phím Space] hoặc [Click đúp vào tài khoản] để tích chọn!";
		EE2AB393.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		EE2AB393.Click += new System.EventHandler(EE2AB393_Click);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1204, 610);
		base.Controls.Add(EE2AB393);
		base.Controls.Add(D03ADA1C);
		base.Controls.Add(F80C9C82);
		base.Controls.Add(F8BAEE9A);
		base.Controls.Add(grTimKiem);
		base.Controls.Add(grQuanLyThuMuc);
		base.Controls.Add(dtgvAcc);
		base.Controls.Add(C9015402);
		base.Controls.Add(menuStrip1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MainMenuStrip = menuStrip1;
		base.Name = "fBin";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "MAX CARE";
		base.Load += new System.EventHandler(fBin_Load);
		((System.ComponentModel.ISupportInitialize)dtgvAcc).EndInit();
		ctmsAcc.ResumeLayout(false);
		F3221FB0.ResumeLayout(false);
		F3221FB0.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C3160B89).EndInit();
		C9015402.ResumeLayout(false);
		menuStrip1.ResumeLayout(false);
		menuStrip1.PerformLayout();
		grQuanLyThuMuc.ResumeLayout(false);
		grTimKiem.ResumeLayout(false);
		grTimKiem.PerformLayout();
		F8BAEE9A.ResumeLayout(false);
		F8BAEE9A.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}
}
