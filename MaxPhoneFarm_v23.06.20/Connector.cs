using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

public class Connector
{
	internal static Connector gclass8_0;

	internal string string_0 = "Data Source=" + Base.string_2 + "\\database\\db_maxcare.sqlite;Version=3;";

	internal SQLiteConnection sqliteConnection_0 = null;

	public static Connector GClass8_0
	{
		get
		{
			if (gclass8_0 == null)
			{
				gclass8_0 = new Connector();
			}
			return gclass8_0;
		}
		private set
		{
			gclass8_0 = value;
		}
	}

	private Connector()
	{
	}

	private void method_0()
	{
		try
		{
			string text = "Data Source=" + Base.string_2 + "\\database\\db_maxcare.sqlite;Version=3;";
			if (text != string_0)
			{
				string_0 = text;
				if (sqliteConnection_0.State == ConnectionState.Open)
				{
					sqliteConnection_0.Close();
				}
				sqliteConnection_0.ConnectionString = string_0;
				sqliteConnection_0.Open();
			}
			else
			{
				if (sqliteConnection_0 == null)
				{
					sqliteConnection_0 = new SQLiteConnection(string_0);
				}
				if (sqliteConnection_0.State == ConnectionState.Closed)
				{
					sqliteConnection_0.Open();
				}
			}
		}
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "CheckConnectServer");
		}
	}

	public DataTable method_1(string BDAEE00E)
	{
		DataTable dataTable = new DataTable();
		try
		{
			method_0();
			SQLiteCommand cmd = new SQLiteCommand(BDAEE00E, sqliteConnection_0);
			SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
			sQLiteDataAdapter.Fill(dataTable);
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "ExecuteQuery");
		}
		return dataTable;
	}

	public DataTable C3A3BC2B(List<string> list_0)
	{
		DataTable dataTable = new DataTable();
		try
		{
			method_0();
			for (int i = 0; i < list_0.Count; i++)
			{
				string commandText = list_0[i];
				SQLiteCommand cmd = new SQLiteCommand(commandText, sqliteConnection_0);
				SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
				sQLiteDataAdapter.Fill(dataTable);
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "ExecuteQuery");
		}
		return dataTable;
	}

	public int method_2(List<string> list_0)
	{
		int result = 0;
		try
		{
			method_0();
			for (int i = 0; i < list_0.Count; i++)
			{
				string commandText = list_0[i];
				SQLiteCommand sQLiteCommand = new SQLiteCommand(commandText, sqliteConnection_0);
				result = sQLiteCommand.ExecuteNonQuery();
			}
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "ExecuteNonQuery");
		}
		return result;
	}

	public int A1A9B8A2(string string_1)
	{
		int result = 0;
		try
		{
			method_0();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sqliteConnection_0);
			result = sQLiteCommand.ExecuteNonQuery();
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "ExecuteNonQuery: " + string_1);
		}
		return result;
	}

	public int method_3(string string_1)
	{
		int result = 0;
		try
		{
			method_0();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sqliteConnection_0);
			long num = (long)sQLiteCommand.ExecuteScalar();
			result = (int)num;
		}
		catch (Exception exception_)
		{
			Common.ExportError(null, exception_, "ExecuteScalar: " + string_1);
		}
		return result;
	}
}
