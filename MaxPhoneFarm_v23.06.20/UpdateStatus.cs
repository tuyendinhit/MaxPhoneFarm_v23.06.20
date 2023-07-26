using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

internal class UpdateStatus
{
	[Serializable]
	[CompilerGenerated]
	private sealed class F0A61AA0
	{
		internal static readonly F0A61AA0 _003C_003E9 = new F0A61AA0();

		internal static Func<DataRow, string> _003C_003E9__4_0;

		internal static Func<DataRow, string> _003C_003E9__4_1;

		internal static Func<KeyValuePair<string, string>, bool> _003C_003E9__5_0;

		internal static Func<KeyValuePair<string, string>, string> _003C_003E9__5_1;

		internal string E113CA05(DataRow dataRow_0)
		{
			return dataRow_0[0].ToString();
		}

		internal string AF900C8D(DataRow CE0DE6AE)
		{
			return CE0DE6AE[1].ToString();
		}

		internal bool EE27EF08(KeyValuePair<string, string> keyValuePair_0)
		{
			KeyValuePair<string, string> keyValuePair = keyValuePair_0;
			return keyValuePair.Value.Trim() != "";
		}

		internal string method_0(KeyValuePair<string, string> keyValuePair_0)
		{
			KeyValuePair<string, string> keyValuePair = keyValuePair_0;
			string key = keyValuePair.Key;
			keyValuePair = keyValuePair_0;
			return key + "|" + keyValuePair.Value;
		}
	}

	internal static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();

	internal static bool isSaveSettings = false;

	public static string A0837914(string string_0)
	{
		if (!isSaveSettings)
		{
			return "";
		}
		string result = "";
		if (dictionary_0.ContainsKey(string_0))
		{
			result = dictionary_0[string_0];
		}
		return result;
	}

	public static void smethod_0(string FC2F538A, string string_0)
	{
		if (isSaveSettings)
		{
			if (dictionary_0.ContainsKey(FC2F538A))
			{
				dictionary_0[FC2F538A] = string_0;
			}
			else
			{
				dictionary_0.Add(FC2F538A, string_0);
			}
		}
	}

	public static void BF344D80()
	{
		if (isSaveSettings)
		{
			DataTable source = CommonSQL.smethod_5();
			dictionary_0 = source.AsEnumerable().ToDictionary((DataRow dataRow_0) => dataRow_0[0].ToString(), (DataRow CE0DE6AE) => CE0DE6AE[1].ToString());
		}
	}

	public static void smethod_1()
	{
		if (isSaveSettings)
		{
			List<string> e23D = dictionary_0.Where(delegate(KeyValuePair<string, string> keyValuePair_0)
			{
				KeyValuePair<string, string> keyValuePair2 = keyValuePair_0;
				return keyValuePair2.Value.Trim() != "";
			}).Select(delegate(KeyValuePair<string, string> keyValuePair_0)
			{
				KeyValuePair<string, string> keyValuePair = keyValuePair_0;
				string key = keyValuePair.Key;
				keyValuePair = keyValuePair_0;
				return key + "|" + keyValuePair.Value;
			}).ToList();
			CommonSQL.smethod_18("status", e23D);
		}
	}
}
