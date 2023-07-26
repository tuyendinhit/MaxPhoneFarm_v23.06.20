using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;

internal class Class65
{
	internal int int_0;

	internal int B9898119;

	internal int int_1;

	internal int E42395AA;

	internal Random random_0;

	public Class65(string DB31F415)
	{
		string[] array = DB31F415.Split('[', ',', ']');
        int_0 = Convert.ToInt32(array[1]);
		int_1 = Convert.ToInt32(array[4]);
		B9898119 = Convert.ToInt32(array[2]);
		E42395AA = Convert.ToInt32(array[5]);
		random_0 = new Random();
	}

	public Class65(int int_2, int int_3, int int_4, int int_5)
	{
		int_0 = int_2;
		B9898119 = int_3;
		int_1 = int_4;
		E42395AA = int_5;
		random_0 = new Random();
	}

	public string AA3F9A29()
	{
		return $"[{int_0},{B9898119}][{int_1},{E42395AA}]";
	}

	internal Point method_0()
	{
		try
		{
			int x = (int_0 + int_1) / 2;
			int y = (B9898119 + E42395AA) / 2;
			return new Point(x, y);
		}
		catch (Exception)
		{
		}
		return default(Point);
	}

	internal int BE370D87()
	{
		return E42395AA - B9898119;
	}

	internal int EF17DB9C()
	{
		return int_1 - int_0;
	}

	public Point F799891B()
	{
		try
		{
			int x = random_0.Next(int_0, int_1 + 1);
			int y = random_0.Next(B9898119, E42395AA + 1);
			return new Point(x, y);
		}
		catch (Exception)
		{
		}
		return default(Point);
	}

	public bool method_1(string string_0)
	{
		return smethod_1(AA3F9A29(), string_0) != null;
	}

	public Class65 A597EA3E(string C9AB5DB7)
	{
		return CC850639(AA3F9A29(), C9AB5DB7);
	}

	public static Class65 smethod_0(string string_0, List<string> list_0)
	{
		Class65 result = null;
		try
		{
			Class65 @class = new Class65(string_0);
			for (int i = 0; i < list_0.Count; i++)
			{
				Class65 class2 = new Class65(list_0[i]);
				int num = ((@class.B9898119 < class2.B9898119) ? class2.B9898119 : @class.B9898119);
				int num2 = ((@class.E42395AA < class2.E42395AA) ? @class.E42395AA : class2.E42395AA);
				if (num < num2)
				{
					result = new Class65(class2.int_0, num, class2.int_1, num2);
					break;
				}
			}
		}
		catch
		{
		}
		return result;
	}

	public static Class65 smethod_1(string ADB55981, string B3001384)
	{
		Class65 result = null;
		try
		{
			Class65 @class = new Class65(ADB55981);
			Class65 class2 = new Class65(B3001384);
			int int_ = Math.Max(@class.int_0, class2.int_0);
			int num = Math.Max(@class.B9898119, class2.B9898119);
			int int_2 = Math.Min(@class.int_1, class2.int_1);
			int num2 = Math.Min(@class.E42395AA, class2.E42395AA);
			if (num < num2)
			{
				result = new Class65(int_, num, int_2, num2);
			}
		}
		catch
		{
		}
		return result;
	}

	public static Class65 CC850639(string F91977AC, string string_0)
	{
		Class65 result = null;
		try
		{
			Class65 @class = new Class65(F91977AC);
			Class65 class2 = new Class65(string_0);
			if (@class.E42395AA < class2.E42395AA)
			{
				result = new Class65(class2.int_0, @class.E42395AA + 1, class2.int_1, class2.E42395AA);
			}
		}
		catch
		{
		}
		return result;
	}

	public static List<Class65> smethod_2(string B63EDC14, string DA9B8B8A)
	{
		Dictionary<int, List<Class65>> dictionary = new Dictionary<int, List<Class65>>();
		List<string> list = F59F8115(B63EDC14, DA9B8B8A);
		foreach (string item in list)
		{
			Class65 @class = new Class65(item);
			if (!dictionary.ContainsKey(@class.B9898119))
			{
				dictionary.Add(@class.B9898119, new List<Class65>());
			}
			dictionary[@class.B9898119].Add(@class);
		}
		if (dictionary.Count > 0)
		{
			return dictionary.OrderByDescending((KeyValuePair<int, List<Class65>> keyValuePair_0) => keyValuePair_0.Value.Count).First().Value;
		}
		return new List<Class65>();
	}

	public static List<string> F59F8115(string string_0, string string_1, string string_2 = "bounds")
	{
		List<string> list = new List<string>();
		try
		{
			string_0 = string_0.ToLower();
			string_1 = string_1.ToLower();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(string_0);
			XmlNodeList xmlNodeList = xmlDocument.SelectNodes(string_1);
			for (int i = 0; i < xmlNodeList.Count; i++)
			{
				list.Add(xmlNodeList[i].Attributes[string_2].Value);
			}
		}
		catch (Exception)
		{
		}
		return list;
	}
}
