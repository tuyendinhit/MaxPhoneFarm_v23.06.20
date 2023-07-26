using System;
using System.Data;
using System.Data.SQLite;

public class C09C8EAB
{
	internal static C09C8EAB AF09B487;

	internal string string_0 = "Data Source=interact\\interact.sqlite;Version=3;";

	internal SQLiteConnection sqliteConnection_0 = null;

	public static C09C8EAB F40D043B
	{
		get
		{
			if (AF09B487 == null)
			{
				AF09B487 = new C09C8EAB();
			}
			return AF09B487;
		}
		private set
		{
			AF09B487 = value;
		}
	}

	private C09C8EAB()
	{
	}

	private void E003ABB2()
	{
		try
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
		catch (Exception a81E)
		{
			Common.smethod_43(a81E, "CheckConnectServer");
		}
	}

	public DataTable method_0(string string_1)
	{
		DataTable dataTable = new DataTable();
		try
		{
			E003ABB2();
			SQLiteCommand cmd = new SQLiteCommand(string_1, sqliteConnection_0);
			SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
			sQLiteDataAdapter.Fill(dataTable);
		}
		catch
		{
		}
		return dataTable;
	}

	public int EA84A08B(string string_1)
	{
		int result = 0;
		try
		{
			E003ABB2();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sqliteConnection_0);
			result = sQLiteCommand.ExecuteNonQuery();
		}
		catch
		{
		}
		return result;
	}

	public int C2B7F81C(string string_1)
	{
		int result = -1;
		try
		{
			E003ABB2();
			SQLiteCommand sQLiteCommand = new SQLiteCommand(string_1, sqliteConnection_0);
			long num = (long)sQLiteCommand.ExecuteScalar();
			result = (int)num;
		}
		catch
		{
		}
		return result;
	}
}
