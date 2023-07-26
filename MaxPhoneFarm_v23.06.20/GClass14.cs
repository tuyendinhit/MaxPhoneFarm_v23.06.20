using System.Collections.Generic;

public class GClass14
{
	internal List<AC28BD29> list_0;

	internal List<AC28BD29> list_1;

	public GClass14(List<string> D684FC24)
	{
		list_0 = new List<AC28BD29>();
		list_1 = new List<AC28BD29>();
		foreach (string item in D684FC24)
		{
			list_0.Add(new AC28BD29(item));
		}
		fMain.fMain_0.method_2(D90E8EA6());
	}

	public int D90E8EA6()
	{
		return list_0.Count;
	}

	public void E7154231(AC28BD29 ac28BD29_0)
	{
		lock (list_0)
		{
			list_0.Remove(ac28BD29_0);
			list_1.Add(ac28BD29_0);
		}
		fMain.fMain_0.method_2(D90E8EA6());
	}

	public AC28BD29 method_0()
	{
		lock (list_0)
		{
			while (true)
			{
				foreach (AC28BD29 item in list_0)
				{
					if (!item.bool_0)
					{
						method_1(item, bool_0: true);
						return item;
					}
				}
				if (list_1.Count <= 0)
				{
					break;
				}
				List<string> list = GClass1.GetDevices();
				bool flag = false;
				for (int i = 0; i < list_1.Count; i++)
				{
					if (list.Contains(list_1[i].String_1))
					{
						flag = true;
						list_0.Add(list_1[i]);
						method_1(list_1[i], bool_0: false);
						list_1[i].searchComplete = false;
						list_1.Remove(list_1[i--]);
					}
				}
				if (flag)
				{
					fMain.fMain_0.method_2(D90E8EA6());
					continue;
				}
				break;
			}
		}
		return null;
	}

	public void method_1(AC28BD29 ac28BD29_0, bool bool_0)
	{
		if (ac28BD29_0 != null)
		{
			ac28BD29_0.bool_0 = bool_0;
		}
	}
}
