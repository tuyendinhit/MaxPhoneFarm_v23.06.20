using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

internal class CommonSQL
{
	public static bool C1381FAC(string string_0)
	{
		return Connector.GClass8_0.method_3("SELECT COUNT(*) FROM files WHERE name='" + string_0 + "' AND active=1;") > 0;
	}

	public static DataTable smethod_0(bool C60DC214 = false)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			text = (C60DC214 ? ("select id, name, STT from files where active=1 UNION SELECT -1 AS id, '" + Language.GetValue("[Tất cả thư mục]") + "' AS name, -1 AS STT UNION SELECT 999999 AS id, '" + Language.GetValue("[Chọn nhiều thư mục]") + "' AS name, 999999 AS STT ORDER BY STT") : "select id, name from files where active=1 ORDER BY STT");
			result = Connector.GClass8_0.method_1(text);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_1(bool FF01A51F = false)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			text = (FF01A51F ? ("select id, name from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0) UNION SELECT -1 AS id, '" + Language.GetValue("[Tất cả thư mục]") + "' AS name UNION SELECT 999999 AS id, '" + Language.GetValue("[Chọn nhiều thư mục]") + "' AS name ORDER BY id ASC") : "select id, name from files WHERE id IN (SELECT DISTINCT idfile FROM accounts WHERE active=0)");
			result = Connector.GClass8_0.method_1(text);
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_2(string C6B5E6A1)
	{
		bool result = true;
		try
		{
			int num = Connector.GClass8_0.method_3("SELECT MAX(STT) FROM files");
			string bDAEE00E = "INSERT INTO files (name, createddate, active, STT) values('" + C6B5E6A1 + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',1," + (num + 1) + ")";
			Connector.GClass8_0.method_1(bDAEE00E);
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_3(string string_0, string string_1)
	{
		try
		{
			string string_2 = "UPDATE files SET name='" + string_1 + "' where id=" + string_0;
			return Connector.GClass8_0.A1A9B8A2(string_2) > 0;
		}
		catch
		{
		}
		return false;
	}

	public static bool BB39031A(string string_0)
	{
		bool result = false;
		try
		{
			if (Connector.GClass8_0.method_3("SELECT COUNT(idfile) FROM accounts WHERE idfile=" + string_0) == 0)
			{
				result = Connector.GClass8_0.A1A9B8A2("delete from files where id=" + string_0) > 0;
				return result;
			}
			if (Connector.GClass8_0.A1A9B8A2("UPDATE files SET active=0 where id=" + string_0) > 0)
			{
				result = smethod_13(string_0);
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_4()
	{
		bool result = false;
		try
		{
			result = Connector.GClass8_0.A1A9B8A2("delete from files where id NOT IN (SELECT DISTINCT idfile FROM accounts) AND active=0") > 0;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static DataTable smethod_5()
	{
		DataTable result = new DataTable();
		try
		{
			string bDAEE00E = "SELECT id, status FROM accounts";
			result = Connector.GClass8_0.method_1(bDAEE00E);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_6(List<string> list_0, bool bool_0 = true)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			text = ((list_0 != null && list_0.Count != 0) ? ("where idfile IN (" + string.Join(",", list_0) + ") AND active=" + (bool_0 ? 1 : 0)) : ("where active=" + (bool_0 ? 1 : 0)));
			string bDAEE00E = "SELECT '-1' as id, '" + Language.GetValue("[Tất cả tình trạng]") + "' AS name UNION select DISTINCT '0' as id,info from accounts " + text + " ORDER BY id ASC";
			result = Connector.GClass8_0.method_1(bDAEE00E);
		}
		catch
		{
		}
		return result;
	}

	public static List<string> smethod_7(List<string> E319B12A)
	{
		List<string> list = new List<string>();
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)E319B12A.Count * 1.0 / 100.0)));
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "INSERT INTO accounts(uid, pass,token,cookie1,email,name,friends,groups,birthday,gender,info,fa2,idfile,passmail,useragent,proxy,dateCreateAcc,dateImport,mailrecovery,active) VALUES " + string.Join(",", E319B12A.GetRange(num * i, (num * i + num <= E319B12A.Count) ? num : (E319B12A.Count % num)));
				list.Add(text);
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static string ED864D9D(string string_0, string E1B49CAA, string D4037321, string string_1, string string_2, string string_3, string A91E0A93, string BF98B8B6, string string_4, string BC86953B, string D7171504, string string_5, string DDB327BC, string string_6, string string_7, string string_8, string string_9, string FB2FEF21)
	{
		string text = "";
		try
		{
			text = "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}',1)";
			text = string.Format(text, string_0.Replace("'", "''"), E1B49CAA.Replace("'", "''"), D4037321, string_1, string_2, string_3.Replace("'", "''"), A91E0A93, BF98B8B6, string_4, BC86953B, D7171504, string_5, DDB327BC, string_6, string_7, string_8, string_9, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), FB2FEF21);
		}
		catch
		{
		}
		return text;
	}

	public static bool UpdateFieldToAccount(string F037F2B7, string string_0, string string_1)
	{
		bool result = false;
		try
		{
			string text = "";
			if (string_0 == "pass")
			{
				text = ", pass_old=pass";
			}
			string string_2 = "update accounts set " + string_0 + " = '" + string_1.Replace("'", "''") + "'" + text + " where id=" + F037F2B7;
			if (Connector.GClass8_0.A1A9B8A2(string_2) > 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_9(string string_0, string D5ABF20F, string string_1, bool FAA08B3F = true)
	{
		bool result = false;
		try
		{
			if (D5ABF20F.Split('|').Length == string_1.Split('|').Length)
			{
				int num = D5ABF20F.Split('|').Length;
				string text = "";
				for (int i = 0; i < num; i++)
				{
					if (FAA08B3F || !(string_1.Split('|')[i].Trim() == ""))
					{
						text = text + D5ABF20F.Split('|')[i] + "='" + string_1.Split('|')[i].Replace("'", "''") + "',";
					}
				}
				text = text.TrimEnd(',');
				string string_2 = "update accounts set " + text + " where id=" + string_0;
				result = Connector.GClass8_0.A1A9B8A2(string_2) > 0;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_10(List<string> E339E89B, string string_0, string D830F111)
	{
		bool result = false;
		try
		{
			if (string_0.Split('|').Length == D830F111.Split('|').Length)
			{
				int num = string_0.Split('|').Length;
				string text = "";
				for (int i = 0; i < num; i++)
				{
					text = text + string_0.Split('|')[i] + "='" + D830F111.Split('|')[i].Replace("'", "''") + "',";
				}
				text = text.TrimEnd(',');
				int num2 = 100;
				int num3 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)E339E89B.Count * 1.0 / 100.0)));
				List<string> list = new List<string>();
				string text2 = "";
				for (int j = 0; j < num3; j++)
				{
					text2 = "update accounts set " + text + " where id IN (" + string.Join(",", E339E89B.GetRange(num2 * j, (num2 * j + num2 <= E339E89B.Count) ? num2 : (E339E89B.Count % num2))) + ")";
					list.Add(text2);
				}
				if (Connector.GClass8_0.method_2(list) > 0)
				{
					result = true;
					return result;
				}
				result = false;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool FE347784(List<string> list_0, string EF24439F, string C5810118)
	{
		bool result = false;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			string text2 = "";
			if (EF24439F == "pass")
			{
				text2 = ", pass_old=pass";
			}
			for (int i = 0; i < num2; i++)
			{
				text = "update accounts set " + EF24439F + " = '" + C5810118.Replace("'", "''") + "'" + text2 + " where id IN (" + string.Join(",", list_0.GetRange(num * i, (num * i + num <= list_0.Count) ? num : (list_0.Count % num))) + ")";
				list.Add(text);
			}
			if (Connector.GClass8_0.method_2(list) > 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool AD1D743A(List<string> list_0, string string_0, string string_1)
	{
		bool result = true;
		try
		{
			string string_2 = "update files set " + string_0 + " = '" + string_1 + "' where id IN (" + string.Join(",", list_0) + ")";
			if (Connector.GClass8_0.A1A9B8A2(string_2) > 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static DataTable smethod_11(List<string> A694499D = null, string string_0 = "", bool bool_0 = true)
	{
		DataTable result = new DataTable();
		try
		{
			string text = "WHERE ";
			string text2 = ((A694499D == null || A694499D.Count <= 0) ? "" : ("t1.idFile IN (" + string.Join(",", A694499D) + ")"));
			if (text2 != "")
			{
				text = text + text2 + " AND ";
			}
			string text3 = ((string_0 != "") ? ("t1.info = '" + string_0 + "'") : "");
			if (text3 != "")
			{
				text = text + text3 + " AND ";
			}
			string text4 = $"t1.active = '{(bool_0 ? 1 : 0)}'";
			text += text4;
			string bDAEE00E = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id " + text + " ORDER BY t1.idfile";
			result = Connector.GClass8_0.method_1(bDAEE00E);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable E1B5F13E(List<string> list_0, bool DD1B4602 = true, List<string> C8106991 = null)
	{
		DataTable result = new DataTable();
		try
		{
			if (list_0[0].StartsWith("@"))
			{
				List<string> list = new List<string>();
				string text = "";
				for (int i = 0; i < list_0.Count; i++)
				{
					text = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email Like ('%" + list_0[i] + "%') and t1.active=" + (DD1B4602 ? "1" : "0");
					list.Add(text);
				}
				result = Connector.GClass8_0.C3A3BC2B(list);
			}
			else if (list_0[0].Contains("@"))
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list2 = new List<string>();
				string text2 = "";
				for (int j = 0; j < num2; j++)
				{
					text2 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email IN ('" + string.Join("','", list_0.GetRange(num * j, (num * j + num <= list_0.Count) ? num : (list_0.Count % num))) + "') and t1.active=" + (DD1B4602 ? "1" : "0") + " ORDER BY t1.email";
					list2.Add(text2);
				}
				result = Connector.GClass8_0.C3A3BC2B(list2);
			}
			else
			{
				int num3 = 100;
				int num4 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list3 = new List<string>();
				string text3 = "";
				for (int k = 0; k < num4; k++)
				{
					text3 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.uid IN ('" + string.Join("','", list_0.GetRange(num3 * k, (num3 * k + num3 <= list_0.Count) ? num3 : (list_0.Count % num3))) + "') and t1.active=" + (DD1B4602 ? "1" : "0") + " ORDER BY t1.uid";
					list3.Add(text3);
				}
				result = Connector.GClass8_0.C3A3BC2B(list3);
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "GetAccFromFile");
		}
		return result;
	}

	public static DataTable smethod_12(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string bDAEE00E = "select " + string_0 + " from accounts where active = 1";
			result = Connector.GClass8_0.method_1(bDAEE00E);
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_13(string DE1E5526)
	{
		bool result = true;
		try
		{
			if (Connector.GClass8_0.A1A9B8A2("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where idfile=" + DE1E5526) > 0)
			{
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static string smethod_14(string F4A88819)
	{
		string text = "";
		try
		{
			DataTable dataTable = Connector.GClass8_0.method_1("SELECT uid, pass,fa2, token, cookie1,email, passmail FROM accounts WHERE id ='" + F4A88819 + "'");
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				for (int j = 0; j < dataTable.Columns.Count; j++)
				{
					text = text + dataTable.Rows[i][j].ToString() + "|";
				}
				text = text.Substring(0, text.Length - 1);
			}
		}
		catch (Exception)
		{
		}
		return text;
	}

	public static DataTable smethod_15(List<string> F729C897)
	{
		DataTable result = new DataTable();
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)F729C897.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "SELECT uid, pass, token, cookie1,email, passmail, fa2 FROM accounts WHERE id IN ('" + string.Join("','", F729C897.GetRange(num * i, (num * i + num <= F729C897.Count) ? num : (F729C897.Count % num))) + "')";
				list.Add(text);
			}
			result = Connector.GClass8_0.C3A3BC2B(list);
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "GetAccFromFile");
		}
		return result;
	}

	public static bool smethod_16(List<string> list_0, bool E5A8B49A = false)
	{
		if (E5A8B49A)
		{
			List<string> list = new List<string>();
			DataTable dataTable = smethod_15(list_0);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				string text = "";
				for (int j = 0; j < dataTable.Columns.Count; j++)
				{
					text = text + dataTable.Rows[i][j].ToString() + "|";
				}
				text = text.Substring(0, text.Length - 1);
				list.Add(text);
			}
			File.AppendAllText("bin.txt", "======" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "======\r\n");
			File.AppendAllLines("bin.txt", list);
		}
		bool result = true;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list2 = new List<string>();
			string text2 = "";
			for (int k = 0; k < num2; k++)
			{
				text2 = ((!E5A8B49A) ? ("UPDATE accounts SET active=0, dateDelete='" + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "' where id IN (" + string.Join(",", list_0.GetRange(num * k, (num * k + num <= list_0.Count) ? num : (list_0.Count % num))) + ")") : ("delete from accounts where id IN (" + string.Join(",", list_0.GetRange(num * k, (num * k + num <= list_0.Count) ? num : (list_0.Count % num))) + ")"));
				list2.Add(text2);
			}
			for (int l = 0; l < list2.Count; l++)
			{
				result = Connector.GClass8_0.A1A9B8A2(list2[l]) > 0;
			}
			return result;
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "DeleteAccountToDatabase");
			return result;
		}
	}

	public static bool EA9BF215(string string_0)
	{
		string[] array = string_0.Split('|');
		string text = "";
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
		string text15 = "";
		string text16 = "";
		text = array[0];
		if (text.Trim() == "")
		{
			return false;
		}
		text2 = array[1];
		text3 = array[2];
		text4 = array[3];
		text5 = array[4];
		text6 = array[5];
		text7 = array[6];
		text8 = array[7];
		text9 = array[8];
		text10 = array[9];
		text11 = array[10];
		text12 = array[11];
		text13 = array[12];
		text14 = array[13];
		text15 = array[14];
		text16 = array[15];
		List<string> list = new List<string>();
		list.Add((text2 != "") ? ("pass|" + text2) : "");
		list.Add((text3 != "") ? ("token|" + text3) : "");
		list.Add((text4 != "") ? ("cookie1|" + text4) : "");
		list.Add((text5 != "") ? ("email|" + text5) : "");
		list.Add((text6 != "") ? ("passmail|" + text6) : "");
		list.Add((text7 != "") ? ("fa2|" + text7) : "");
		list.Add((text8 != "") ? ("useragent|" + text8) : "");
		list.Add((text9 != "") ? ("proxy|" + text9) : "");
		list.Add((text10 != "") ? ("birthday|" + text10) : "");
		list.Add((text11 != "") ? ("gender|" + text11) : "");
		list.Add((text12 != "") ? ("friends|" + text12) : "");
		list.Add((text13 != "") ? ("dateCreateAcc|" + text13) : "");
		list.Add((text14 != "") ? ("mailrecovery|" + text14) : "");
		list.Add((text15 != "") ? ("ghiChu|" + text15) : "");
		list.Add((text16 != "") ? ("interactEnd|" + text16) : "");
		string text17 = "update accounts set";
		foreach (string item in list)
		{
			if (item != "")
			{
				text17 = text17 + " " + item.Split('|')[0] + "='" + item.Split('|')[1] + "',";
				if (item.Split('|')[0] == "pass")
				{
					text17 += "pass_old=pass,";
				}
			}
		}
		text17 = text17.TrimEnd(',');
		text17 = text17 + " where uid='" + text + "'";
		return Connector.GClass8_0.A1A9B8A2(text17) > 0;
	}

	public static string E611AAB1(string EE31BB27)
	{
		try
		{
			return Connector.GClass8_0.method_3("SELECT idFile FROM accounts WHERE id='" + EE31BB27 + "'").ToString();
		}
		catch
		{
		}
		return "";
	}

	public static bool CheckColumnIsExistInTable(string string_0, string string_1)
	{
		return Connector.GClass8_0.method_3("SELECT COUNT(*) AS count FROM pragma_table_info('" + string_0 + "') WHERE name='" + string_1 + "'") > 0;
	}

	public static bool A906A63C(string BB0B8B89)
	{
		return Connector.GClass8_0.method_3("SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='" + BB0B8B89 + "';") > 0;
	}

	public static bool AddColumnsIntoTable(string string_0, string string_1, int AD1617AA)
	{
		bool result = false;
		try
		{
			if (Connector.GClass8_0.A1A9B8A2("ALTER TABLE " + string_0 + " ADD COLUMN '" + string_1 + "' " + ((AD1617AA == 0) ? "INT" : "TEXT") + ";") > 0)
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool smethod_17(string string_0, string string_1, string string_2)
	{
		bool result = true;
		try
		{
			string bDAEE00E = "INSERT INTO interacts(uid, timeInteract,hanhDong,cauHinh) VALUES ('" + string_0 + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + string_1 + "','" + string_2 + "')";
			Connector.GClass8_0.method_1(bDAEE00E);
			return result;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_18(string string_0, List<string> E23D0797, string D7BABF8D = "accounts")
	{
		List<string> list = new List<string>();
		string text = "";
		string text2 = "";
		string text3 = "";
		for (int i = 0; i < E23D0797.Count; i++)
		{
			text = E23D0797[i].Split('|')[0];
			text2 = E23D0797[i].Split('|')[1];
			if (!string.IsNullOrEmpty(text))
			{
				list.Add(text);
				text3 = text3 + "WHEN '" + text + "' THEN '" + text2 + "' ";
			}
		}
		string string_ = "UPDATE " + D7BABF8D + " SET " + string_0 + " = CASE id " + text3 + "END WHERE id IN('" + string.Join("','", list) + "'); ";
		return Connector.GClass8_0.A1A9B8A2(string_) > 0;
	}

	public static List<string> B9B0A816(string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string bDAEE00E = "SELECT device FROM accounts WHERE device LIKE '" + string_0 + "_com.facebook.ka%' AND active=1";
			DataTable dataTable = Connector.GClass8_0.method_1(bDAEE00E);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i]["device"].ToString().Trim().Replace(string_0 + "_", ""));
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static DataTable B01A5A9E(List<string> list_0, bool E4230E9E = true)
	{
		DataTable result = new DataTable();
		try
		{
			if (list_0[0].StartsWith("@"))
			{
				List<string> list = new List<string>();
				string text = "";
				for (int i = 0; i < list_0.Count; i++)
				{
					text = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email Like ('%" + list_0[i] + "%') and t1.active=" + (E4230E9E ? 1 : 0);
					list.Add(text);
				}
				result = Connector.GClass8_0.C3A3BC2B(list);
			}
			else if (list_0[0].Contains("@"))
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list2 = new List<string>();
				string text2 = "";
				for (int j = 0; j < num2; j++)
				{
					text2 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.email IN ('" + string.Join("','", list_0.GetRange(num * j, (num * j + num <= list_0.Count) ? num : (list_0.Count % num))) + "') and t1.active=" + (E4230E9E ? 1 : 0) + " ORDER BY t1.email";
					list2.Add(text2);
				}
				result = Connector.GClass8_0.C3A3BC2B(list2);
			}
			else
			{
				int num3 = 100;
				int num4 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
				List<string> list3 = new List<string>();
				string text3 = "";
				for (int k = 0; k < num4; k++)
				{
					text3 = "SELECT t1.*, t2.name AS nameFile FROM accounts t1 JOIN files t2 ON t1.idfile=t2.id WHERE t1.uid IN ('" + string.Join("','", list_0.GetRange(num3 * k, (num3 * k + num3 <= list_0.Count) ? num3 : (list_0.Count % num3))) + "') and t1.active=" + (E4230E9E ? 1 : 0) + " ORDER BY t1.uid";
					list3.Add(text3);
				}
				result = Connector.GClass8_0.C3A3BC2B(list3);
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "GetAccFromFile");
		}
		return result;
	}

	public static bool smethod_19(List<string> list_0)
	{
		bool result = false;
		try
		{
			int num = 100;
			int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)list_0.Count * 1.0 / 100.0)));
			List<string> list = new List<string>();
			string text = "";
			for (int i = 0; i < num2; i++)
			{
				text = "update accounts set pass=pass_old, pass_old=pass where id IN (" + string.Join(",", list_0.GetRange(num * i, (num * i + num <= list_0.Count) ? num : (list_0.Count % num))) + ")";
				list.Add(text);
			}
			result = Connector.GClass8_0.method_2(list) > 0;
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool BD33A63D(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			string text = Connector.GClass8_0.method_1("SELECT STT FROM files WHERE id = " + string_0).Rows[0]["STT"].ToString();
			string text2 = Connector.GClass8_0.method_1("SELECT STT FROM files WHERE id = " + string_1).Rows[0]["STT"].ToString();
			string string_2 = "UPDATE files SET STT = " + text2 + " WHERE id = " + string_0;
			string string_3 = "UPDATE files SET STT = " + text + " WHERE id = " + string_1;
			if (Connector.GClass8_0.A1A9B8A2(string_2) > 0 && Connector.GClass8_0.A1A9B8A2(string_3) > 0)
			{
				result = true;
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}
}
