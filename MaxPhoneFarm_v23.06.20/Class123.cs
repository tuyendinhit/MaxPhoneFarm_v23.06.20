using System;
using System.Collections.Generic;
using System.Data;

internal class Class123
{
	public static bool smethod_0(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			int num = C09C8EAB.F40D043B.C2B7F81C("SELECT COUNT(*) AS count FROM pragma_table_info('" + string_0 + "') WHERE name='" + string_1 + "'");
			if (num > 0)
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

	public static bool smethod_1(string A59C8019, string F03BEB01, int D41B7795)
	{
		bool result = false;
		try
		{
			if (C09C8EAB.F40D043B.EA84A08B("ALTER TABLE " + A59C8019 + " ADD COLUMN '" + F03BEB01 + "' " + ((D41B7795 == 0) ? "INT" : "TEXT") + ";") > 0)
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

	public static DataTable D22C6CAB(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT * FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			result = C09C8EAB.F40D043B.method_0(string_);
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_2(string string_0)
	{
		string result = "";
		try
		{
			string string_ = "SELECT TenKichBan FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			result = C09C8EAB.F40D043B.method_0(string_).Rows[0][0].ToString();
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static DataTable smethod_3()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "DROP TABLE IF EXISTS tmp;CREATE TEMPORARY TABLE tmp(Stt INTEGER PRIMARY KEY AUTOINCREMENT, Id_KichBan INTEGER, TenKichBan TEXT);INSERT INTO tmp (Id_KichBan, TenKichBan) SELECT Id_KichBan, TenKichBan FROM Kich_Ban;SELECT Id_KichBan, TenKichBan, (Stt||'. '||TenKichBan) AS Ten FROM tmp;";
			result = C09C8EAB.F40D043B.method_0(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_4()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT * FROM Kich_Ban ORDER BY Id_KichBan DESC LIMIT 1";
			result = C09C8EAB.F40D043B.method_0(string_);
		}
		catch
		{
		}
		return result;
	}

	public static string E93A548E(string string_0)
	{
		string result = "";
		try
		{
			string string_ = "SELECT CauHinh FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			result = C09C8EAB.F40D043B.method_0(string_).Rows[0]["CauHinh"].ToString();
		}
		catch
		{
		}
		return result;
	}

	public static bool smethod_5(string string_0, string EA1790B5)
	{
		try
		{
			string string_ = "UPDATE Kich_Ban SET CauHinh = '" + EA1790B5 + "' WHERE Id_KichBan = " + string_0;
			return C09C8EAB.F40D043B.EA84A08B(string_) > 0;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_6(string string_0)
	{
		try
		{
			string string_ = "SELECT Id_KichBan FROM Kich_Ban WHERE TenKichBan = '" + string_0 + "'";
			if (C09C8EAB.F40D043B.method_0(string_).Rows.Count > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_7(string A5AC8E07)
	{
		bool result = false;
		try
		{
			string string_ = "INSERT INTO Kich_Ban (TenKichBan) VALUES ('" + A5AC8E07 + "')";
			if (C09C8EAB.F40D043B.EA84A08B(string_) > 0)
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

	public static bool B0A197BE(string DB85FB9B, string string_0)
	{
		bool result = false;
		try
		{
			string string_ = "UPDATE Kich_Ban SET TenKichBan = '" + string_0 + "' WHERE Id_KichBan = " + DB85FB9B;
			if (C09C8EAB.F40D043B.EA84A08B(string_) > 0)
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

	public static bool FBBA661D(string string_0)
	{
		bool result = false;
		try
		{
			string string_ = "DELETE FROM Kich_Ban WHERE Id_KichBan = " + string_0;
			if (C09C8EAB.F40D043B.EA84A08B(string_) > 0)
			{
				EC865D31(string_0);
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

	public static bool smethod_8(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			if (smethod_7(string_1))
			{
				string text = smethod_4().Rows[0]["Id_KichBan"].ToString();
				DataTable dataTable = C09C8EAB.F40D043B.method_0("SELECT * FROM Hanh_Dong WHERE Id_KichBan = " + string_0);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					string string_2 = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + dataTable.Rows[i]["STT"].ToString() + "," + text + ", '" + dataTable.Rows[i]["TenHanhDong"].ToString() + "', " + dataTable.Rows[i]["Id_TuongTac"].ToString() + ", '" + dataTable.Rows[i]["CauHinh"].ToString().Replace("'", "''") + "')";
					C09C8EAB.F40D043B.EA84A08B(string_2);
				}
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

	public static DataTable C7BE863B(string E81DF82F = "", string string_0 = "")
	{
		DataTable result = new DataTable();
		try
		{
			string text = "";
			if (E81DF82F != "")
			{
				text = text + "Id_TuongTac = " + E81DF82F + " AND ";
			}
			if (string_0 != "")
			{
				text = text + "TenTuongTac = '" + string_0 + "'";
			}
			if (text != "")
			{
				if (text.EndsWith(" AND "))
				{
					text = text.Replace(" AND ", "");
				}
				string string_ = "SELECT * FROM Tuong_Tac WHERE " + text;
				result = C09C8EAB.F40D043B.method_0(string_);
			}
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_9(string A3B81BA4)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong, t1.TenHanhDong,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + A3B81BA4 + " ORDER BY t1.STT";
			result = C09C8EAB.F40D043B.method_0(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_10(string string_0)
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_HanhDong = " + string_0;
			result = C09C8EAB.F40D043B.method_0(string_);
		}
		catch
		{
		}
		return result;
	}

	public static DataTable smethod_11()
	{
		DataTable result = new DataTable();
		try
		{
			string string_ = "SELECT t1.Id_HanhDong,t1.TenHanhDong,t1.CauHinh,t2.Id_TuongTac,t2.TenTuongTac, t2.MoTa FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac ORDER BY Id_HanhDong DESC LIMIT 1";
			result = C09C8EAB.F40D043B.method_0(string_);
		}
		catch
		{
		}
		return result;
	}

	public static bool CC3CE6AB(string ED9CE50D)
	{
		try
		{
			string string_ = "SELECT Id_HanhDong FROM Hanh_Dong WHERE TenHanhDong = '" + ED9CE50D + "'";
			if (C09C8EAB.F40D043B.method_0(string_).Rows.Count > 0)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static int A3A46880()
	{
		try
		{
			string string_ = "SELECT Id_HanhDong FROM Hanh_Dong ORDER BY Id_HanhDong DESC LIMIT 1";
			return C09C8EAB.F40D043B.C2B7F81C(string_);
		}
		catch
		{
		}
		return -1;
	}

	public static bool smethod_12(string B81D5B06, string CC260B2E, string string_0, string D9253C2E)
	{
		bool result = false;
		try
		{
			string text = "";
			try
			{
				text = C09C8EAB.F40D043B.method_0("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + B81D5B06 + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
			}
			catch
			{
			}
			text = ((text == "") ? "1" : (Convert.ToInt32(text) + 1).ToString());
			D9253C2E = D9253C2E.Replace("'", "''");
			string string_ = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + text + "," + B81D5B06 + ", '" + CC260B2E + "', " + string_0 + ", '" + D9253C2E + "')";
			if (C09C8EAB.F40D043B.EA84A08B(string_) > 0)
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

	public static bool smethod_13(string string_0, string B79BFA1A)
	{
		bool result = false;
		try
		{
			DataTable dataTable = C09C8EAB.F40D043B.method_0("SELECT * FROM Hanh_Dong WHERE Id_HanhDong = " + string_0);
			string text = "";
			try
			{
				text = C09C8EAB.F40D043B.method_0("SELECT STT FROM Hanh_Dong WHERE Id_KichBan = " + dataTable.Rows[0]["Id_KichBan"].ToString() + " ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
			}
			catch
			{
			}
			text = ((text == "") ? "1" : (Convert.ToInt32(text) + 1).ToString());
			string string_ = "INSERT INTO Hanh_Dong (STT,Id_KichBan, TenHanhDong, Id_TuongTac, CauHinh) VALUES (" + text + "," + dataTable.Rows[0]["Id_KichBan"].ToString() + ", '" + B79BFA1A + "', " + dataTable.Rows[0]["Id_TuongTac"].ToString() + ", '" + dataTable.Rows[0]["CauHinh"].ToString().Replace("'", "''") + "')";
			if (C09C8EAB.F40D043B.EA84A08B(string_) > 0)
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

	public static bool smethod_14(string string_0, string string_1 = "", string string_2 = "")
	{
		bool result = false;
		try
		{
			string text = "";
			string_2 = string_2.Replace("'", "''");
			if (string_1 != "")
			{
				text = text + "TenHanhDong = '" + string_1 + "',";
			}
			if (string_2 != "")
			{
				text = text + "CauHinh = '" + string_2 + "'";
			}
			if (text != "")
			{
				text = text.TrimEnd(',');
				string string_3 = "UPDATE Hanh_Dong SET " + text + " WHERE Id_HanhDong = " + string_0;
				if (C09C8EAB.F40D043B.EA84A08B(string_3) > 0)
				{
					result = true;
					return result;
				}
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static bool E2AD70B8(string string_0, string string_1)
	{
		bool result = false;
		try
		{
			string text = C09C8EAB.F40D043B.method_0("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + string_0).Rows[0]["STT"].ToString();
			string text2 = C09C8EAB.F40D043B.method_0("SELECT STT FROM Hanh_Dong WHERE Id_HanhDong = " + string_1).Rows[0]["STT"].ToString();
			string string_2 = "UPDATE Hanh_Dong SET STT = " + text2 + " WHERE Id_HanhDong = " + string_0;
			string string_3 = "UPDATE Hanh_Dong SET STT = " + text + " WHERE Id_HanhDong = " + string_1;
			if (C09C8EAB.F40D043B.EA84A08B(string_2) > 0 && C09C8EAB.F40D043B.EA84A08B(string_3) > 0)
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

	public static bool smethod_15(string C2225AAD)
	{
		bool result = false;
		try
		{
			string string_ = "DELETE FROM Hanh_Dong WHERE Id_HanhDong = " + C2225AAD;
			if (C09C8EAB.F40D043B.EA84A08B(string_) > 0)
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

	public static bool EC865D31(string string_0)
	{
		bool result = false;
		try
		{
			string string_ = "DELETE FROM Hanh_Dong WHERE Id_KichBan = " + string_0;
			if (C09C8EAB.F40D043B.EA84A08B(string_) > 0)
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

	public static List<string> A0AD6B0A(string string_0, string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			string string_2 = "SELECT t1.Id_HanhDong FROM Hanh_Dong t1 JOIN Tuong_Tac t2 ON t1.Id_TuongTac = t2.Id_TuongTac WHERE t1.Id_KichBan = " + string_0 + " AND t2.TenTuongTac = '" + string_1 + "'";
			DataTable dataTable = C09C8EAB.F40D043B.method_0(string_2);
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				list.Add(dataTable.Rows[i]["Id_HanhDong"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_16(string string_0)
	{
		string result = "";
		try
		{
			string string_ = "SELECT CauHinh FROM Hanh_Dong WHERE Id_HanhDong = " + string_0;
			result = C09C8EAB.F40D043B.method_0(string_).Rows[0]["CauHinh"].ToString();
		}
		catch
		{
		}
		return result;
	}

	public static bool FF378FA5(List<string> D31B6DB9, string string_0)
	{
		try
		{
			string string_ = "SELECT COUNT(*) FROM Hanh_Dong WHERE Id_KichBan IN (" + string.Join(",", D31B6DB9) + ") AND Id_TuongTac = (SELECT Id_TuongTac FROM Tuong_Tac WHERE TenTuongTac='" + string_0 + "')";
			int num = C09C8EAB.F40D043B.C2B7F81C(string_);
			return num > 0;
		}
		catch
		{
		}
		return false;
	}
}
