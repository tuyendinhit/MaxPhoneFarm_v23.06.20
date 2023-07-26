using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

internal class DatagridviewHelper
{
	public static void B52BC1AA(DataGridView F92CAF3D, int D5A29F9B, string C7088FAF, int int_0 = 0, string ED8725BC = "Đơ\u0323i {time} giây...")
	{
		try
		{
			int int_ = Environment.TickCount;
			while ((Environment.TickCount - int_) / 1000 - int_0 < 0)
			{
				F92CAF3D.Invoke((MethodInvoker)delegate
				{
					F92CAF3D.Rows[D5A29F9B].Cells[C7088FAF].Value = ED8725BC.Replace("{time}", (int_0 - (Environment.TickCount - int_) / 1000).ToString());
				});
				Common.DelayTime(0.5);
			}
		}
		catch
		{
		}
	}

	public static void DD22C1BB(DataGridView dataGridView_0, int int_0, string C2A20997, int int_1 = 0, int int_2 = 0, string E4A907AD = "Đơ\u0323i {time} giây...")
	{
		try
		{
			int int_3 = Environment.TickCount;
			while ((Environment.TickCount - int_3) / 1000 - int_1 < 0)
			{
				dataGridView_0.Invoke((MethodInvoker)delegate
				{
					dataGridView_0.Rows[int_0].Cells[C2A20997].Value = E4A907AD.Replace("{time}", (int_2 - (Environment.TickCount - int_3) / 1000).ToString());
				});
				Common.DelayTime(0.5);
			}
		}
		catch
		{
		}
	}

	public static string smethod_0(DataGridView dataGridView_0, int FC181D94, int BD196A2C)
	{
		string BFB897A4 = "";
		try
		{
			if (dataGridView_0.Rows[FC181D94].Cells[BD196A2C].Value != null)
			{
				try
				{
					BFB897A4 = dataGridView_0.Rows[FC181D94].Cells[BD196A2C].Value.ToString();
				}
				catch
				{
					dataGridView_0.Invoke((MethodInvoker)delegate
					{
						BFB897A4 = dataGridView_0.Rows[FC181D94].Cells[BD196A2C].Value.ToString();
					});
				}
			}
		}
		catch
		{
		}
		return BFB897A4;
	}

	public static string E83E252C(DataGridView dataGridView_0, int int_0, string F92C2883)
	{
		string C238D53C = "";
		try
		{
			if (dataGridView_0.Rows[int_0].Cells[F92C2883].Value != null)
			{
				try
				{
					C238D53C = dataGridView_0.Rows[int_0].Cells[F92C2883].Value.ToString();
				}
				catch
				{
					dataGridView_0.Invoke((MethodInvoker)delegate
					{
						C238D53C = dataGridView_0.Rows[int_0].Cells[F92C2883].Value.ToString();
					});
				}
			}
		}
		catch
		{
		}
		return C238D53C;
	}

	public static void smethod_1(DataGridView dataGridView_0, int int_0, int int_1, object object_0)
	{
		try
		{
			try
			{
				dataGridView_0.Invoke((MethodInvoker)delegate
				{
					dataGridView_0.Rows[int_0].Cells[int_1].Value = object_0;
				});
			}
			catch
			{
				dataGridView_0.Rows[int_0].Cells[int_1].Value = object_0;
			}
		}
		catch
		{
		}
	}

	public static void AD3DF791(DataGridView FB8EFBB5, int F5B8AE0E, string string_0, object object_0)
	{
		try
		{
			if (UpdateStatus.isSaveSettings && string_0 == "cStatus")
			{
				string fC2F538A = E83E252C(FB8EFBB5, F5B8AE0E, "cId");
				UpdateStatus.smethod_0(fC2F538A, object_0.ToString());
			}
			try
			{
				FB8EFBB5.Invoke((MethodInvoker)delegate
				{
					FB8EFBB5.Rows[F5B8AE0E].Cells[string_0].Value = object_0;
				});
			}
			catch
			{
				FB8EFBB5.Rows[F5B8AE0E].Cells[string_0].Value = object_0;
			}
		}
		catch
		{
		}
	}

	public static void AB825897(DataGridView F21625BB, DataTable dataTable_0, bool AE172E1C = false)
	{
		if (!AE172E1C)
		{
			for (int i = 0; i < dataTable_0.Rows.Count; i++)
			{
				DataRow dataRow = dataTable_0.Rows[i];
				F21625BB.Rows.Add(false, F21625BB.RowCount + 1, dataRow["id"], dataRow["uid"], dataRow["token"], dataRow["cookie1"], dataRow["email"], dataRow["phone"], dataRow["name"], dataRow["follow"], dataRow["friends"], dataRow["groups"], dataRow["birthday"], dataRow["gender"], dataRow["pass"], "", dataRow["passmail"], dataRow["backup"], dataRow["fa2"], dataRow["useragent"], dataRow["proxy"], dataRow["dateCreateAcc"], dataRow["avatar"], dataRow["profile"], dataRow["nameFile"], dataRow["interactEnd"], dataRow["device"], dataRow["info"], dataRow["ghiChu"], "", "", UpdateStatus.A0837914(dataRow["id"].ToString()));
			}
		}
		else
		{
			for (int j = 0; j < dataTable_0.Rows.Count; j++)
			{
				DataRow dataRow2 = dataTable_0.Rows[j];
				F21625BB.Rows.Add(false, F21625BB.RowCount + 1, dataRow2["id"], dataRow2["uid"], dataRow2["token"], dataRow2["cookie1"], dataRow2["email"], dataRow2["phone"], dataRow2["name"], dataRow2["follow"], dataRow2["friends"], dataRow2["groups"], dataRow2["birthday"], dataRow2["gender"], dataRow2["pass"], dataRow2["mailrecovery"], dataRow2["passmail"], dataRow2["backup"], dataRow2["fa2"], dataRow2["useragent"], dataRow2["proxy"], dataRow2["dateCreateAcc"], dataRow2["avatar"], dataRow2["profile"], dataRow2["nameFile"], dataRow2["interactEnd"], dataRow2["info"], dataRow2["ghiChu"], dataRow2["dateDelete"], UpdateStatus.A0837914(dataRow2["id"].ToString()));
			}
		}
	}

	public static void E7818906(DataGridView dataGridView_0, JArray jarray_0, bool bool_0 = false)
	{
		if (!bool_0)
		{
			for (int i = 0; i < jarray_0.Count; i++)
			{
				JToken jToken = jarray_0[i];
				dataGridView_0.Rows.Add(false, dataGridView_0.RowCount + 1, jToken["id"], jToken["uid"], jToken["token"], jToken["cookie1"], jToken["email"], jToken["phone"], jToken["name"], jToken["follow"], jToken["friends"], jToken["groups"], jToken["birthday"], jToken["gender"], jToken["pass"], "", jToken["passmail"], jToken["backup"], jToken["fa2"], jToken["useragent"], jToken["proxy"], jToken["dateCreateAcc"], jToken["avatar"], jToken["profile"], jToken["nameFile"], jToken["interactEnd"], jToken["device"], jToken["info"], jToken["ghiChu"], "", "", UpdateStatus.A0837914(jToken["id"]!.ToString()));
			}
		}
		else
		{
			for (int j = 0; j < jarray_0.Count; j++)
			{
				JToken jToken2 = jarray_0[j];
				dataGridView_0.Rows.Add(false, dataGridView_0.RowCount + 1, jToken2["id"], jToken2["uid"], jToken2["token"], jToken2["cookie1"], jToken2["email"], jToken2["phone"], jToken2["name"], jToken2["follow"], jToken2["friends"], jToken2["groups"], jToken2["birthday"], jToken2["gender"], jToken2["pass"], jToken2["mailrecovery"], jToken2["passmail"], jToken2["backup"], jToken2["fa2"], jToken2["useragent"], jToken2["proxy"], jToken2["dateCreateAcc"], jToken2["avatar"], jToken2["profile"], jToken2["nameFile"], jToken2["interactEnd"], jToken2["info"], jToken2["ghiChu"], jToken2["dateDelete"], UpdateStatus.A0837914(jToken2["id"]!.ToString()));
			}
		}
	}
}
